using System;
using System.Data;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000BB RID: 187
	public class XmlTable : XmlGoldPrinterElement
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x00008738 File Offset: 0x00006938
		public XmlTable()
		{
			this._Rows = null;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00008747 File Offset: 0x00006947
		public XmlTable(XmlNode table)
		{
			this._Rows = null;
			base.XmlNode = table;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000C7C5C File Offset: 0x000C5E5C
		public DataTable GetDataTable()
		{
			return this.GetDataTableFromXmlTable(this);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000C7C74 File Offset: 0x000C5E74
		private DataTable GetDataTableFromXmlTable(XmlTable table)
		{
			XmlTableRowCollection rows = table.Rows;
			checked
			{
				DataTable result;
				if (rows.Count > 0)
				{
					XmlTableCellCollection cells = rows[0].Cells;
					DataTable dataTable = new DataTable();
					int num = 0;
					int num2 = cells.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						dataTable.Columns.Add(i.ToString()).DefaultValue = "";
					}
					int num3 = 0;
					int num4 = rows.Count - 1;
					for (int i = num3; i <= num4; i++)
					{
						DataRow dataRow = dataTable.NewRow();
						int num5 = 0;
						int num6 = cells.Count - 1;
						for (int j = num5; j <= num6; j++)
						{
							dataRow[j] = table.Rows[i].Cells[j].Text;
						}
						dataTable.Rows.Add(dataRow);
					}
					result = dataTable;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000C7D60 File Offset: 0x000C5F60
		private XmlTableRowCollection GetRows()
		{
			checked
			{
				if (this._Rows == null)
				{
					XmlTableRowCollection xmlTableRowCollection = new XmlTableRowCollection();
					if (base.XmlNode != null)
					{
						XmlNode xmlNode = base.XmlNode;
						int count = xmlNode.ChildNodes.Count;
						int num = 0;
						int num2 = count - 1;
						for (int i = num; i <= num2; i++)
						{
							XmlTableRow xmlTableRow = new XmlTableRow(xmlNode.ChildNodes[i], this);
							xmlTableRow.Parse();
							xmlTableRowCollection.Add(xmlTableRow);
						}
					}
					this._Rows = xmlTableRowCollection;
				}
				return this._Rows;
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000C7DE0 File Offset: 0x000C5FE0
		public string[,] GetTableText()
		{
			int count = this.Rows.Count;
			checked
			{
				string[,] result;
				if (count > 0)
				{
					int count2 = this.Rows[0].Cells.Count;
					string[,] array = new string[count - 1 + 1, count2 - 1 + 1];
					int num = 0;
					int num2 = this.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						int num3 = 0;
						int num4 = this.Rows[i].Cells.Count - 1;
						for (int j = num3; j <= num4; j++)
						{
							array[i, j] = this.Rows[i].Cells[j].Text;
						}
					}
					result = array;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000875D File Offset: 0x0000695D
		public void LoadFrom(DataTable dataTable)
		{
			this.LoadFrom(dataTable.DefaultView);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0000876B File Offset: 0x0000696B
		public void LoadFrom(DataView dataView)
		{
			this.SetXmlTableFromDataTableView(this, dataView);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00008775 File Offset: 0x00006975
		public void LoadFromHtmlTable(string xmlFileName)
		{
			this.LoadFromHtmlTable(xmlFileName, "table");
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000C7EA0 File Offset: 0x000C60A0
		public void LoadFromHtmlTable(string xmlFileName, string tableName)
		{
			XmlNode xmlNode = XmlParserBase.SelectSingleNodeByNodeName(xmlFileName, tableName);
			base.XmlNode = xmlNode;
			this.Parse();
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000C7EC4 File Offset: 0x000C60C4
		public void LoadFromHtmlTable(string xmlFileName, string tableName, string attributeName, string attributeValue)
		{
			XmlNode xmlNode = XmlParserBase.SelectSingleNodeByAttribute(xmlFileName, tableName, attributeName, attributeValue);
			base.XmlNode = xmlNode;
			this.Parse();
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000C7EEC File Offset: 0x000C60EC
		protected override void ParseMySelf()
		{
			XmlTableFormat xmlTableFormat = new XmlTableFormat(base.XmlNode);
			xmlTableFormat.Parse();
			this._TableFormat = xmlTableFormat;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000C7F14 File Offset: 0x000C6114
		private void SetXmlTableFromDataTableView(XmlTable xmlTable, DataView dataView)
		{
			checked
			{
				if (xmlTable != null && dataView != null)
				{
					int count = dataView.Count;
					int count2 = dataView.Table.Columns.Count;
					if (count > 0)
					{
						xmlTable.Rows.Clear();
						int num = 0;
						int num2 = count - 1;
						for (int i = num; i <= num2; i++)
						{
							XmlTableRow xmlTableRow = new XmlTableRow(xmlTable);
							int num3 = 0;
							int num4 = count2 - 1;
							for (int j = num3; j <= num4; j++)
							{
								XmlTableCell xmlTableCell = new XmlTableCell(xmlTableRow);
								xmlTableCell.Text = dataView[i][j].ToString();
								xmlTableRow.Cells.Add(xmlTableCell);
							}
							xmlTable.Rows.Add(xmlTableRow);
						}
					}
				}
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000C7FC8 File Offset: 0x000C61C8
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00008783 File Offset: 0x00006983
		public XmlBorderFormat BorderFormat
		{
			get
			{
				return this._TableFormat.BorderFormat;
			}
			set
			{
				this._TableFormat.BorderFormat = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000C7FE4 File Offset: 0x000C61E4
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00008791 File Offset: 0x00006991
		public string CellPadding
		{
			get
			{
				return this._TableFormat.CellPadding;
			}
			set
			{
				this._TableFormat.CellPadding = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000C8000 File Offset: 0x000C6200
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000879F File Offset: 0x0000699F
		public string CellSpacing
		{
			get
			{
				return this._TableFormat.CellSpacing;
			}
			set
			{
				this._TableFormat.CellSpacing = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x000C801C File Offset: 0x000C621C
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x000087AD File Offset: 0x000069AD
		public string GridLines
		{
			get
			{
				return this._TableFormat.GridLines;
			}
			set
			{
				this._TableFormat.GridLines = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000C8038 File Offset: 0x000C6238
		public XmlTableRowCollection Rows
		{
			get
			{
				return this.GetRows();
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000C8050 File Offset: 0x000C6250
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x000087BB File Offset: 0x000069BB
		public XmlTableFormat TableFormat
		{
			get
			{
				return this._TableFormat;
			}
			set
			{
				this._TableFormat = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x000C8068 File Offset: 0x000C6268
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x000087C4 File Offset: 0x000069C4
		public XmlTextFormat TextFormat
		{
			get
			{
				return this._TableFormat.TextFormat;
			}
			set
			{
				this._TableFormat.TextFormat = value;
			}
		}

		// Token: 0x04000B42 RID: 2882
		private XmlTableRowCollection _Rows;

		// Token: 0x04000B43 RID: 2883
		private XmlTableFormat _TableFormat;
	}
}
