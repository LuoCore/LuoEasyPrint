using System;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000C0 RID: 192
	public class XmlTableRow : XmlGoldPrinterElement
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x000088EF File Offset: 0x00006AEF
		internal XmlTableRow(XmlTable table)
		{
			this._Table = null;
			this._Cells = null;
			this._Table = table;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0000890C File Offset: 0x00006B0C
		internal XmlTableRow(XmlNode row, XmlTable table) : this(table)
		{
			base.XmlNode = row;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000C8514 File Offset: 0x000C6714
		private XmlTableCellCollection GetCells()
		{
			checked
			{
				if (this._Cells == null)
				{
					XmlTableCellCollection xmlTableCellCollection = new XmlTableCellCollection();
					if (base.XmlNode != null)
					{
						XmlNode xmlNode = base.XmlNode;
						int count = xmlNode.ChildNodes.Count;
						int num = 0;
						int num2 = count - 1;
						for (int i = num; i <= num2; i++)
						{
							XmlTableCell xmlTableCell = new XmlTableCell(xmlNode.ChildNodes[i], this);
							xmlTableCell.Parse();
							xmlTableCellCollection.Add(xmlTableCell);
						}
					}
					this._Cells = xmlTableCellCollection;
				}
				return this._Cells;
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x000C8598 File Offset: 0x000C6798
		protected override void ParseMySelf()
		{
			if (base.XmlNode != null)
			{
				XmlNode xmlNode = base.XmlNode;
				XmlTextFormat xmlTextFormat = new XmlTextFormat(xmlNode);
				xmlTextFormat.Parse();
				this._TextFormat = xmlTextFormat;
				XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(xmlNode);
				xmlBorderFormat.Parse();
				this._BorderFormat = xmlBorderFormat;
				if (this.TextFormat.IsEmpty)
				{
					this._TextFormat = (XmlTextFormat)this._Table.TextFormat.Clone();
				}
				else
				{
					this._TextFormat = (XmlTextFormat)this._Table.TextFormat.CloneNoEmpty(this._TextFormat);
				}
				if (this.BorderFormat.IsEmpty)
				{
					this._BorderFormat = (XmlBorderFormat)this._Table.BorderFormat.Clone();
				}
				else
				{
					this._BorderFormat = (XmlBorderFormat)this._Table.BorderFormat.CloneNoEmpty(this._BorderFormat);
				}
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000C8678 File Offset: 0x000C6878
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000891C File Offset: 0x00006B1C
		public XmlBorderFormat BorderFormat
		{
			get
			{
				return this._BorderFormat;
			}
			set
			{
				this._BorderFormat = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x000C8690 File Offset: 0x000C6890
		public XmlTableCellCollection Cells
		{
			get
			{
				return this.GetCells();
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x000C86A8 File Offset: 0x000C68A8
		public XmlTable Table
		{
			get
			{
				return this._Table;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x000C86C0 File Offset: 0x000C68C0
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x00008925 File Offset: 0x00006B25
		public XmlTextFormat TextFormat
		{
			get
			{
				return this._TextFormat;
			}
			set
			{
				this._TextFormat = value;
			}
		}

		// Token: 0x04000B51 RID: 2897
		private XmlBorderFormat _BorderFormat;

		// Token: 0x04000B52 RID: 2898
		private XmlTableCellCollection _Cells;

		// Token: 0x04000B53 RID: 2899
		private XmlTable _Table;

		// Token: 0x04000B54 RID: 2900
		private XmlTextFormat _TextFormat;
	}
}
