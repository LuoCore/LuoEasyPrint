using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000071 RID: 113
	[StandardModule]
	internal sealed class SimpleReportModule
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x00070DD8 File Offset: 0x0006EFD8
		public static decimal GetTreeViewColWidth(TreeNode node)
		{
			decimal num = 0m;
			checked
			{
				decimal result;
				if (node == null)
				{
					result = 0m;
				}
				else if (node.GetNodeCount(false) > 0)
				{
					int num2 = 0;
					int num3 = node.GetNodeCount(false) - 1;
					for (int i = num2; i <= num3; i++)
					{
						num = decimal.Add(num, SimpleReportModule.GetTreeViewColWidth(node.Nodes[i]));
					}
					result = num;
				}
				else
				{
					ParaseTag paraseTag = new ParaseTag();
					paraseTag.RestoreTags(Convert.ToString(node.Tag));
					result = paraseTag.ColWidth;
				}
				return result;
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00070E58 File Offset: 0x0006F058
		public static bool GetTreeViewColPrint(TreeNode node)
		{
			checked
			{
				bool result;
				if (node == null)
				{
					result = false;
				}
				else if (node.GetNodeCount(false) > 0)
				{
					int num = 0;
					int num2 = node.GetNodeCount(false) - 1;
					for (int i = num; i <= num2; i++)
					{
						if (SimpleReportModule.GetTreeViewColPrint(node.Nodes[i]))
						{
							return true;
						}
					}
					result = false;
				}
				else
				{
					ParaseTag paraseTag = new ParaseTag();
					paraseTag.RestoreTags(Convert.ToString(node.Tag));
					result = paraseTag.IsPrint;
				}
				return result;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00070EC8 File Offset: 0x0006F0C8
		public static string ConvertDGVtoString(DataGridView dgv)
		{
			checked
			{
				string result;
				if (dgv == null)
				{
					result = "";
				}
				else
				{
					string str = "\u0001";
					string str2 = "\u0002";
					string text = "";
					int num = 0;
					int num2 = dgv.RowCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i != 0)
						{
							text += str2;
						}
						int num3 = 0;
						int num4 = dgv.ColumnCount - 1;
						for (int j = num3; j <= num4; j++)
						{
							if (j == 0)
							{
								text += Convert.ToString(dgv.Rows[i].Cells[j].Value);
							}
							else
							{
								text = text + str + Convert.ToString(dgv.Rows[i].Cells[j].Value);
							}
						}
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00070FA0 File Offset: 0x0006F1A0
		public static void ConvertStringToDGV(string ss, DataGridView dgv)
		{
			checked
			{
				if (String.Compare(ss, "", false) == 0)
				{
					if (dgv != null)
					{
						dgv.RowCount = 0;
					}
				}
				else if (dgv != null)
				{
					string delimiter = "\u0001";
					string delimiter2 = "\u0002";
					string[] array = Strings.Split(ss, delimiter2, -1, CompareMethod.Binary);
					dgv.RowCount = array.Length;
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						string[] array2 = Strings.Split(array[i], delimiter, -1, CompareMethod.Binary);
						int num3 = 0;
						int num4 = array2.Length - 1;
						for (int j = num3; j <= num4; j++)
						{
							dgv.Rows[i].Cells[j].Value = array2[j];
						}
					}
				}
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00071050 File Offset: 0x0006F250
		public static string ConvertTreeViewToString(TreeView tv, bool isshowcheckedbox)
		{
			checked
			{
				string result;
				if (tv == null)
				{
					result = "";
				}
				else
				{
					string str = "\u0001";
					string str2 = "\u0002";
					string str3 = "\a";
					string text = Module1.ConvertColorToString(tv.BackColor);
					text = text + str + Module1.ConvertColorToString(tv.ForeColor);
					text = text + str + Module1.ConvertFontToString(tv.Font);
					text = text + str + Convert.ToString(Interaction.IIf(isshowcheckedbox, "1", "0"));
					int num = 0;
					int num2 = tv.Nodes.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						string text2 = SimpleReportModule.ConvertNodeToString(tv.Nodes[i]);
						if (tv.Nodes[i].GetNodeCount(false) > 0)
						{
							text2 = text2 + str3 + SimpleReportModule.ConvertAllNodeToString(tv.Nodes[i]);
						}
						text = text + str2 + text2;
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00071148 File Offset: 0x0006F348
		private static string ConvertAllNodeToString(TreeNode nd)
		{
			checked
			{
				string result;
				if (nd == null)
				{
					result = "";
				}
				else
				{
					string str = "\u0006";
					string str2 = "\b";
					string text = "";
					if (nd.GetNodeCount(false) <= 0)
					{
						result = "";
					}
					else
					{
						int num = 0;
						int num2 = nd.GetNodeCount(false) - 1;
						for (int i = num; i <= num2; i++)
						{
							string text2 = SimpleReportModule.ConvertNodeToString(nd.Nodes[i]);
							if (i == 0)
							{
								text = text2;
							}
							else
							{
								text = text + str + text2;
							}
						}
						int num3 = 0;
						int num4 = nd.GetNodeCount(false) - 1;
						for (int j = num3; j <= num4; j++)
						{
							string text2 = SimpleReportModule.ConvertAllNodeToString(nd.Nodes[j]);
							text = text + str2 + text2;
						}
						result = text;
					}
				}
				return result;
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00071214 File Offset: 0x0006F414
		private static string ConvertNodeToString(TreeNode nd)
		{
			string result;
			if (nd == null)
			{
				result = "";
			}
			else
			{
				string str = "\u0001";
				string text = nd.Text;
				text = text + str + Convert.ToString(Interaction.IIf(nd.Checked, "1", "0"));
				text = text + str + Convert.ToString(nd.Tag);
				result = text;
			}
			return result;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00071278 File Offset: 0x0006F478
		public static void ConvertStringToTreeView(string ss, TreeView tv)
		{
			while (tv.Nodes.Count > 0)
			{
				tv.Nodes[0].Remove();
			}
			tv.LineColor = Color.Black;
			checked
			{
				if (String.Compare(Strings.Trim(ss), "", false) != 0)
				{
					string delimiter = "\a";
					string delimiter2 = "\u0001";
					string delimiter3 = "\u0002";
					string[] array = Strings.Split(ss, delimiter3, -1, CompareMethod.Binary);
					string[] array2 = Strings.Split(array[0], delimiter2, -1, CompareMethod.Binary);
					Color backColor = Module1.ConvertStringToColor(array2[0]);
					Color foreColor = Module1.ConvertStringToColor(array2[1]);
					Font font = Module1.ConvertStringToFont(array2[2]);
					if (String.Compare(array2[3], "1", false) == 0)
					{
						tv.CheckBoxes = true;
					}
					else
					{
						tv.CheckBoxes = false;
					}
					if (font != null)
					{
						tv.Font = font;
					}
					tv.ForeColor = foreColor;
					tv.BackColor = backColor;
					int num = 1;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						array2 = Strings.Split(array[i], delimiter, -1, CompareMethod.Binary);
						TreeNode treeNode = SimpleReportModule.ConvertStringToNode(array2[0]);
						tv.Nodes.Add(treeNode);
						if (array2.Length > 1)
						{
							SimpleReportModule.ConvertAllStringToNode(ref array2[1], treeNode);
						}
					}
				}
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000713A8 File Offset: 0x0006F5A8
		private static void ConvertAllStringToNode(ref string mys, TreeNode parentnode)
		{
			checked
			{
				if (String.Compare(mys, "", false) != 0)
				{
					string delimiter = "\u0006";
					string delimiter2 = "\b";
					string[] array = Strings.Split(mys, delimiter2, 2, CompareMethod.Binary);
					if (array.Length > 1)
					{
						mys = array[1];
					}
					else
					{
						mys = "";
					}
					if (String.Compare(array[0], "", false) != 0)
					{
						string[] array2 = Strings.Split(array[0], delimiter, -1, CompareMethod.Binary);
						TreeNode[] array3 = new TreeNode[array2.Length - 1 + 1];
						int num = 0;
						int num2 = array2.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							array3[i] = SimpleReportModule.ConvertStringToNode(array2[i]);
							parentnode.Nodes.Add(array3[i]);
						}
						int num3 = 0;
						int num4 = array2.Length - 1;
						for (int j = num3; j <= num4; j++)
						{
							SimpleReportModule.ConvertAllStringToNode(ref mys, array3[j]);
						}
					}
				}
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0007147C File Offset: 0x0006F67C
		private static TreeNode ConvertStringToNode(string mys)
		{
			TreeNode result;
			if (String.Compare(mys, "", false) == 0)
			{
				result = null;
			}
			else
			{
				string delimiter = "\u0001";
				string[] array = Strings.Split(mys, delimiter, -1, CompareMethod.Binary);
				TreeNode treeNode = new TreeNode();
				treeNode.Text = array[0];
				if (String.Compare(array[1], "1", false) == 0)
				{
					treeNode.Checked = true;
				}
				else
				{
					treeNode.Checked = false;
				}
				treeNode.Tag = array[2];
				result = treeNode;
			}
			return result;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000714E8 File Offset: 0x0006F6E8
		public static string GetFormatValue(string value, string valuetype, string valueformat)
		{
			string result;
			if (String.Compare(valueformat, "", false) == 0)
			{
				result = value;
			}
			else if (String.Compare(valuetype, "数值", false) == 0)
			{
				result = SimpleReportModule.GetFormatNumeric(value, valueformat);
			}
			else if (String.Compare(valuetype, "日期", false) == 0)
			{
				result = SimpleReportModule.GetFormatDate(value, valueformat);
			}
			else if (String.Compare(valuetype, "逻辑", false) == 0)
			{
				result = SimpleReportModule.GetFormatLog(value, valueformat);
			}
			else
			{
				result = SimpleReportModule.GetFormatText(value, valueformat);
			}
			return result;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00071560 File Offset: 0x0006F760
		private static string GetFormatText(string value, string valueformat)
		{
			string result;
			try
			{
				result = Strings.Format(value, valueformat);
			}
			catch (Exception ex)
			{
				result = value;
			}
			return result;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00071598 File Offset: 0x0006F798
		private static string GetFormatNumeric(string value, string valueformat)
		{
			string result;
			if (!DataTypeConversion.IsNumeric(value))
			{
				result = value;
			}
			else
			{
				try
				{
					result = Strings.Format(Convert.ToDecimal(value), valueformat);
				}
				catch (Exception ex)
				{
					result = value;
				}
			}
			return result;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000715E8 File Offset: 0x0006F7E8
		private static string GetFormatDate(string value, string valueformat)
		{
			string result;
			if (!Information.IsDate(value))
			{
				result = value;
			}
			else
			{
				try
				{
					result = Strings.Format(Convert.ToDateTime(value), valueformat);
				}
				catch (Exception ex)
				{
					result = value;
				}
			}
			return result;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00071638 File Offset: 0x0006F838
		public static string GetFormatLog(string value, string valueformat)
		{
			checked
			{
				string result;
				if (String.Compare(valueformat, "", false) == 0)
				{
					result = value;
				}
				else
				{
					if (!(Strings.InStr(valueformat, value, CompareMethod.Binary) <= 0 & Strings.InStr(valueformat, "？", CompareMethod.Binary) <= 0 & Strings.InStr(valueformat, "?", CompareMethod.Binary) <= 0))
					{
						string result2 = "";
						valueformat = Strings.Replace(valueformat, "｜", "|", 1, -1, CompareMethod.Binary);
						string[] array = Strings.Split(valueformat, "|", -1, CompareMethod.Binary);
						bool flag = false;
						string text = "";
						bool flag2 = false;
						int num = 0;
						int num2 = array.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							string[] array2 = Strings.Split(array[i], "/", -1, CompareMethod.Binary);
							if (array2.Length == 2)
							{
								if (String.Compare(array2[0], value, false) == 0)
								{
									result2 = array2[1];
									flag2 = true;
									IL_105:
									if (!flag2)
									{
										if (flag)
										{
											if (String.Compare(text, "?", false) == 0 | String.Compare(text, "？", false) == 0)
											{
												result2 = value;
											}
											else
											{
												result2 = text;
											}
										}
										else
										{
											result2 = value;
										}
									}
									return result2;
								}
								if (String.Compare(array2[0], "?", false) == 0 | String.Compare(array2[0], "？", false) == 0)
								{
									flag = true;
									text = array2[1];
								}
							}
						}
						
					}
					result = value;
				}
				return result;
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00071784 File Offset: 0x0006F984
		public static string ShowSimpleReportText(string txt, string[] myfield, string[] myarray)
		{
			SimpleReportTextEdit simpleReportTextEdit = new SimpleReportTextEdit();
			simpleReportTextEdit.myfield = myfield;
			simpleReportTextEdit.zdyarray = myarray;
			simpleReportTextEdit.TextBox1.Text = txt;
			string result;
			if (simpleReportTextEdit.ShowDialog() == DialogResult.OK)
			{
				result = simpleReportTextEdit.TextBox1.Text;
			}
			else
			{
				result = txt;
			}
			return result;
		}
	}
}
