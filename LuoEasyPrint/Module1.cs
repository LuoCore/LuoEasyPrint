using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000179 RID: 377
	[StandardModule]
	internal sealed class Module1
	{
		// Token: 0x06001F00 RID: 7936
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06001F01 RID: 7937
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int WritePrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06001F02 RID: 7938 RVA: 0x00101B68 File Offset: 0x000FFD68
		public static void CopyDataGridViewByDGVCS(DataGridView dgvtoprint, DataGridView ddv, DGVprint dgvcs)
		{
			try
			{
				switch (dgvcs.PrintRange)
				{
				case DGVprint.DGVPrintRange.AllVisibleRowsAndColumns:
					Module1.CopyDataGridViewShowStatus(dgvtoprint, ddv, dgvcs.IsPrintRowHeaderColumn);
					break;
				case DGVprint.DGVPrintRange.SelectedRows:
					Module1.CopyDataGridViewShowStatus(dgvtoprint, ddv, Module1.GetDGVSelectedMinRowIndex(dgvtoprint), Module1.GetDGVSelectedMaxRowIndex(dgvtoprint), false);
					Module1.SetDGVSelectedRowsVisible(dgvtoprint, ddv, Module1.GetDGVSelectedMinRowIndex(dgvtoprint));
					break;
				case DGVprint.DGVPrintRange.SelectedColumns:
					Module1.CopyDataGridViewShowStatus(dgvtoprint, ddv, false);
					Module1.SetDGVSelectedColumnsVisible(dgvtoprint, ddv);
					break;
				case DGVprint.DGVPrintRange.SelectedRowsAndColumns:
					Module1.CopyDataGridViewShowStatus(dgvtoprint, ddv, Module1.GetDGVSelectedMinRowIndex(dgvtoprint), Module1.GetDGVSelectedMaxRowIndex(dgvtoprint), false);
					Module1.SetDGVSelectedRowsAndColumnsVisible(dgvtoprint, ddv, Module1.GetDGVSelectedMinRowIndex(dgvtoprint));
					break;
				}
				ddv.GridColor = dgvcs.GridColor;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00101C24 File Offset: 0x000FFE24
		public static void CopyTreeView(TreeView s, ref TreeView d, bool isaddrowname = false)
		{
			d.Nodes.Clear();
			checked
			{
				if (s == null)
				{
					d = null;
				}
				else
				{
					d.StateImageList = s.StateImageList;
					d.ImageList = s.ImageList;
					d.ImageIndex = s.ImageIndex;
					if (String.Compare(s.ImageKey, "", false) != 0)
					{
						d.ImageKey = s.ImageKey;
					}
					d.CheckBoxes = s.CheckBoxes;
					d.LineColor = s.LineColor;
					d.Font = (Font)s.Font.Clone();
					d.ForeColor = s.ForeColor;
					int num = 0;
					int num2 = s.Nodes.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						TreeNode treeNode = d.Nodes.Add(s.Nodes[i].Text);
						treeNode.Checked = s.Nodes[i].Checked;
						treeNode.ImageIndex = s.Nodes[i].ImageIndex;
						if (String.Compare(s.Nodes[i].ImageKey, "", false) != 0)
						{
							treeNode.ImageKey = s.Nodes[i].ImageKey;
						}
						treeNode.StateImageIndex = s.Nodes[i].StateImageIndex;
						if (String.Compare(s.Nodes[i].StateImageKey, "", false) != 0)
						{
							treeNode.StateImageKey = s.Nodes[i].StateImageKey;
						}
						treeNode.ForeColor = s.Nodes[i].ForeColor;
						treeNode.BackColor = s.Nodes[i].BackColor;
						if (s.Nodes[i].NodeFont != null)
						{
							treeNode.NodeFont = (Font)s.Nodes[i].NodeFont.Clone();
						}
						Module1.CopyNodes(s.Nodes[i], ref treeNode);
					}
					if (isaddrowname)
					{
						d.Nodes.Insert(0, "行号");
					}
				}
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00101E48 File Offset: 0x00100048
		private static void CopyNodes(TreeNode s, ref TreeNode d)
		{
			checked
			{
				if (s != null)
				{
					int num = 0;
					int num2 = s.Nodes.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						TreeNode treeNode = d.Nodes.Add(s.Nodes[i].Text);
						treeNode.Checked = s.Nodes[i].Checked;
						treeNode.ImageIndex = s.Nodes[i].ImageIndex;
						if (String.Compare(s.Nodes[i].ImageKey, "", false) != 0)
						{
							treeNode.ImageKey = s.Nodes[i].ImageKey;
						}
						treeNode.StateImageIndex = s.Nodes[i].StateImageIndex;
						if (String.Compare(s.Nodes[i].StateImageKey, "", false) != 0)
						{
							treeNode.StateImageKey = s.Nodes[i].StateImageKey;
						}
						treeNode.ForeColor = s.Nodes[i].ForeColor;
						treeNode.BackColor = s.Nodes[i].BackColor;
						if (s.Nodes[i].NodeFont != null)
						{
							treeNode.NodeFont = (Font)s.Nodes[i].NodeFont.Clone();
						}
						Module1.CopyNodes(s.Nodes[i], ref treeNode);
					}
				}
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00101FC0 File Offset: 0x001001C0
		public static string GetINI(string Section, string AppName, string lpDefault, string FileName)
		{
			string text = "";
			text = Strings.LSet(text, 2048);
			Module1.GetPrivateProfileStringA(ref Section, ref AppName, ref lpDefault, ref text, Strings.Len(text), ref FileName);
			string text2 = Strings.Trim(Strings.Left(text, checked(Strings.InStr(text, "\0", CompareMethod.Binary) - 1)));
			text2 = Strings.Replace(text2, "&<br>&", "\r\n", 1, -1, CompareMethod.Binary);
			if (text2 == null)
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00102030 File Offset: 0x00100230
		public static long WriteINI(string Section, string AppName, string lpDefault, string FileName)
		{
			lpDefault = Strings.Replace(lpDefault, "\r\n", "&<br>&", 1, -1, CompareMethod.Binary);
			if (lpDefault == null)
			{
				lpDefault = "";
			}
			return (long)Module1.WritePrivateProfileStringA(ref Section, ref AppName, ref lpDefault, ref FileName);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0010206C File Offset: 0x0010026C
		public static string ConvertFontToString(Font myfont)
		{
			FontConverter fontConverter = new FontConverter();
			return fontConverter.ConvertToString(myfont);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0010208C File Offset: 0x0010028C
		public static string ConvertColorToString(Color mycolor)
		{
			ColorConverter colorConverter = new ColorConverter();
			return colorConverter.ConvertToString(mycolor);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x001020B0 File Offset: 0x001002B0
		public static Color ConvertStringToColor(string pp)
		{
			ColorConverter colorConverter = new ColorConverter();
			Color result;
			try
			{
				object obj = colorConverter.ConvertFromString(pp);
				Color color=new Color();
				result = ((obj != null) ? ((Color)obj) : color);
			}
			catch (Exception ex)
			{
				return Color.FromArgb(0);
			}
			return result;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00102108 File Offset: 0x00100308
		public static Font ConvertStringToFont(string pp)
		{
			FontConverter fontConverter = new FontConverter();
			Font result;
			if (String.Compare(pp, "(无)", false) == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					Font font = (Font)fontConverter.ConvertFromString(pp);
					result = font;
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00102160 File Offset: 0x00100360
		public static void CopyDataGridView(DataGridView sdv, DataGridView ddv, bool IsAddRowHeaderColumn)
		{
			Module1.CopyDataGridView(sdv, ddv);
			checked
			{
				if (IsAddRowHeaderColumn)
				{
					try
					{
						if (ddv.Columns.Count > 0)
						{
							DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
							dataGridViewTextBoxColumn.HeaderCell = (DataGridViewColumnHeaderCell)sdv.TopLeftHeaderCell.Clone();
							if (sdv.TopLeftHeaderCell.HasStyle)
							{
								dataGridViewTextBoxColumn.HeaderCell.Style = sdv.TopLeftHeaderCell.Style.Clone();
							}
							dataGridViewTextBoxColumn.Width = sdv.RowHeadersWidth;
							if (String.Compare(dataGridViewTextBoxColumn.Name + "", "", false) == 0)
							{
								dataGridViewTextBoxColumn.Name = "行标题";
							}
							dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
							ddv.Columns.Insert(0, dataGridViewTextBoxColumn);
							int rowCount = ddv.RowCount;
							int num = 0;
							int num2 = rowCount - 1;
							for (int i = num; i <= num2; i++)
							{
								ddv.Rows[i].Cells[0].Value = Convert.ToString(sdv.Rows[i].HeaderCell.FormattedValue) + "";
								if (sdv.Rows[i].HeaderCell.Style.Font != null)
								{
									ddv.Rows[i].Cells[0].Style.Font = (Font)sdv.Rows[i].HeaderCell.Style.Font.Clone();
								}
								else if (sdv.RowHeadersDefaultCellStyle.Font != null)
								{
									ddv.Rows[i].Cells[0].Style.Font = (Font)sdv.RowHeadersDefaultCellStyle.Font.Clone();
								}
								if (sdv.Rows[i].HeaderCell.Style.Alignment != DataGridViewContentAlignment.NotSet)
								{
									ddv.Rows[i].Cells[0].Style.Alignment = sdv.Rows[i].HeaderCell.Style.Alignment;
								}
								else
								{
									ddv.Rows[i].Cells[0].Style.Alignment = sdv.RowHeadersDefaultCellStyle.Alignment;
								}
								if (sdv.Rows[i].HeaderCell.Style.ForeColor.ToArgb() != 0)
								{
									ddv.Rows[i].Cells[0].Style.ForeColor = sdv.Rows[i].HeaderCell.Style.ForeColor;
								}
								else if (sdv.RowHeadersDefaultCellStyle.ForeColor.ToArgb() != 0)
								{
									ddv.Rows[i].Cells[0].Style.ForeColor = sdv.RowHeadersDefaultCellStyle.ForeColor;
								}
								if (sdv.Rows[i].HeaderCell.Style.BackColor.ToArgb() != 0)
								{
									ddv.Rows[i].Cells[0].Style.BackColor = sdv.Rows[i].HeaderCell.Style.BackColor;
								}
								else if (sdv.RowHeadersDefaultCellStyle.BackColor.ToArgb() != 0)
								{
									ddv.Rows[i].Cells[0].Style.BackColor = sdv.RowHeadersDefaultCellStyle.BackColor;
								}
								if (sdv.Rows[i].HeaderCell.Style.WrapMode != DataGridViewTriState.NotSet)
								{
									ddv.Rows[i].Cells[0].Style.WrapMode = sdv.Rows[i].HeaderCell.Style.WrapMode;
								}
								else if (sdv.RowHeadersDefaultCellStyle.WrapMode != DataGridViewTriState.NotSet)
								{
									ddv.Rows[i].Cells[0].Style.WrapMode = sdv.RowHeadersDefaultCellStyle.WrapMode;
								}
							}
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x001025BC File Offset: 0x001007BC
		public static void CopyDataGridViewShowStatus(DataGridView sdv, DataGridView ddv, bool isprintrowheadercolumn = false)
		{
			progress2 progress = new progress2();
			progress.Show();
			progress.Label1.Text = "正在复制数据……请稍侯";
			Application.DoEvents();
			Module1.CopyDataGridView(sdv, ddv, isprintrowheadercolumn);
			progress.Close();
			progress.Dispose();
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00102600 File Offset: 0x00100800
		public static void CopyDataGridViewShowStatus(DataGridView sdv, DataGridView ddv, int fromrow, int torow, bool isprintrowheadercolumn = false)
		{
			progress2 progress = new progress2();
			progress.Show();
			progress.Label1.Text = "正在复制数据……请稍侯";
			Application.DoEvents();
			Module1.CopyDataGridView(sdv, ddv, fromrow, torow, isprintrowheadercolumn);
			progress.Close();
			progress.Dispose();
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00002590 File Offset: 0x00000790
		public static void MyMsgBox(string ss)
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00102648 File Offset: 0x00100848
		public static void CopyDataGridView(DataGridView sdv, DataGridView ddv)
		{
			checked
			{
				if (sdv != null && ddv != null)
				{
					if (sdv.Equals(ddv))
					{
						Module1.MyMsgBox("在CopyDataGridView函数中发现要复制的DGV与目标DGV完全一样");
					}
					else
					{
						ddv.AllowUserToAddRows = false;
						while (ddv.ColumnCount >= 1)
						{
							ddv.Columns.RemoveAt(0);
						}
						ddv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
						ddv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
						int num = sdv.ColumnCount;
						int num2 = 0;
						int num3 = num - 1;
						int i = num2;
						while (i <= num3)
						{
							if (!(String.Compare(Versioned.TypeName(sdv.Columns[i]), "DataGridViewComboBoxColumn", false) == 0 | String.Compare(Versioned.TypeName(sdv.Columns[i]), "DataGridViewColumn", false) == 0))
							{
								goto IL_235;
							}
							DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
							try
							{
								dataGridViewTextBoxColumn.DefaultCellStyle = sdv.Columns[i].DefaultCellStyle.Clone();
								dataGridViewTextBoxColumn.AutoSizeMode = sdv.Columns[i].AutoSizeMode;
								dataGridViewTextBoxColumn.DisplayIndex = sdv.Columns[i].DisplayIndex;
							}
							catch (Exception ex)
							{
							}
							try
							{
								dataGridViewTextBoxColumn.HeaderCell = (DataGridViewColumnHeaderCell)sdv.Columns[i].HeaderCell.Clone();
								dataGridViewTextBoxColumn.HeaderText = sdv.Columns[i].HeaderText;
								dataGridViewTextBoxColumn.MinimumWidth = sdv.Columns[i].MinimumWidth;
								dataGridViewTextBoxColumn.Resizable = sdv.Columns[i].Resizable;
							}
							catch (Exception ex2)
							{
							}
							try
							{
								dataGridViewTextBoxColumn.Name = sdv.Columns[i].Name;
								dataGridViewTextBoxColumn.Tag = RuntimeHelpers.GetObjectValue(sdv.Columns[i].Tag);
								dataGridViewTextBoxColumn.Visible = sdv.Columns[i].Visible;
								try
								{
									if (String.Compare(Convert.ToString(dataGridViewTextBoxColumn.Tag), "不打印", false) == 0)
									{
										dataGridViewTextBoxColumn.Visible = false;
									}
								}
								catch (Exception ex3)
								{
								}
								dataGridViewTextBoxColumn.Width = sdv.Columns[i].Width;
								goto IL_343;
							}
							catch (Exception ex4)
							{
								goto IL_343;
							}
							goto IL_235;
							IL_343:
							ddv.Columns.Add(dataGridViewTextBoxColumn);
							Block_11:
							try
							{
								ddv.Columns[i].ValueType = sdv.Columns[i].ValueType;
							}
							catch (Exception ex5)
							{
							}
							if (String.Compare(ddv.Columns[i].Name + "", "", false) == 0)
							{
								ddv.Columns[i].Name = "第" + Convert.ToString(i) + "列名";
							}
							ddv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
							ddv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
							i++;
							continue;
							IL_235:
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)sdv.Columns[i].Clone();
							dataGridViewColumn.Frozen = false;
							try
							{
								if (String.Compare(Convert.ToString(dataGridViewColumn.Tag), "不打印", false) == 0)
								{
									dataGridViewColumn.Visible = false;
								}
							}
							catch (Exception ex6)
							{
							}
							ddv.Columns.Add(dataGridViewColumn);
							goto Block_11;
						}
						int[] array = new int[sdv.ColumnCount - 1 + 1];
						int[] array2 = new int[sdv.ColumnCount - 1 + 1];
						int num4 = 0;
						int num5 = sdv.ColumnCount - 1;
						for (int j = num4; j <= num5; j++)
						{
							array[j] = j;
							array2[j] = sdv.Columns[j].DisplayIndex;
						}
						Array.Sort<int, int>(array2, array);
						int num6 = 0;
						int num7 = sdv.ColumnCount - 1;
						for (i = num6; i <= num7; i++)
						{
							ddv.Columns[array[i]].DisplayIndex = sdv.Columns[array[i]].DisplayIndex;
						}
						ddv.ColumnHeadersHeightSizeMode = sdv.ColumnHeadersHeightSizeMode;
						ddv.ColumnHeadersHeight = sdv.ColumnHeadersHeight;
						ddv.ColumnHeadersVisible = sdv.ColumnHeadersVisible;
						if (sdv.RowCount > 0)
						{
							int num8 = sdv.RowCount;
							if (sdv.AllowUserToAddRows && Module1.IsNullLastRow(sdv))
							{
								num8--;
							}
							ddv.RowCount = num8;
							ddv.AlternatingRowsDefaultCellStyle = sdv.AlternatingRowsDefaultCellStyle.Clone();
							ddv.DefaultCellStyle = sdv.DefaultCellStyle.Clone();
							ddv.RowsDefaultCellStyle = sdv.RowsDefaultCellStyle.Clone();
							ddv.ColumnHeadersDefaultCellStyle = sdv.ColumnHeadersDefaultCellStyle.Clone();
							int num9 = 0;
							int num10 = sdv.ColumnCount - 1;
							for (i = num9; i <= num10; i++)
							{
								if (sdv.Columns[i].HasDefaultCellStyle)
								{
									ddv.Columns[i].DefaultCellStyle = sdv.Columns[i].DefaultCellStyle.Clone();
								}
							}
							num = ddv.Columns.Count - 1;
							string[] array3 = new string[num + 1];
							int num11 = 0;
							int num12 = num;
							for (int k = num11; k <= num12; k++)
							{
								array3[k] = Versioned.TypeName(sdv.Columns[k]);
							}
							int num13 = 0;
							int num14 = num8 - 1;
							for (i = num13; i <= num14; i++)
							{
								int num15 = 0;
								int num16 = num;
								int k = num15;
								while (k <= num16)
								{
									if (String.Compare(array3[k], "DataGridViewImageColumn", false) != 0)
									{
										goto IL_616;
									}
									ddv.Rows[i].Cells[k].Value = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Cells[k].FormattedValue);
									if (ddv.Rows[i].Cells[k].Value != null)
									{
										try
										{
											DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)ddv.Rows[i].Cells[k];
											dataGridViewImageCell.ImageLayout = ((DataGridViewImageCell)sdv.Rows[i].Cells[k]).ImageLayout;
											
										}
										catch (Exception ex7)
										{
											
										}
									}
									for (;;)
									{
										IL_6F8:
										if (sdv.Rows[i].Cells[k].HasStyle)
										{
											ddv.Rows[i].Cells[k].Style = sdv.Rows[i].Cells[k].Style.Clone();
										}
										try
										{
											ddv.Rows[i].Cells[k].Tag = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Cells[k].Tag);
											break;
										}
										catch (Exception ex8)
										{
											break;
										}
									}
									k++;
									continue;
									IL_616:
									ddv.Rows[i].Cells[k].Value = Convert.ToString(sdv.Rows[i].Cells[k].FormattedValue) + "";
									
								}
								ddv.Rows[i].Height = sdv.Rows[i].Height;
								ddv.Rows[i].Visible = sdv.Rows[i].Visible;
								if (sdv.Rows[i].HasDefaultCellStyle)
								{
									ddv.Rows[i].DefaultCellStyle = sdv.Rows[i].DefaultCellStyle.Clone();
								}
								try
								{
									ddv.Rows[i].Tag = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Tag);
								}
								catch (Exception ex9)
								{
								}
							}
							ddv.GridColor = sdv.GridColor;
							ddv.Name = sdv.Name;
						}
					}
				}
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00102EC4 File Offset: 0x001010C4
		public static void CopyDataGridView(DataGridView sdv, DataGridView ddv, int fromrow, int torow, bool isprintrowheadercolumn = false)
		{
			checked
			{
				if (sdv != null && ddv != null)
				{
					if (sdv.Equals(ddv))
					{
						Module1.MyMsgBox("在CopyDataGridView函数中发现要复制的DGV与目标DGV完全一样");
					}
					else
					{
						if (fromrow < 0)
						{
							fromrow = 0;
						}
						if (torow > sdv.RowCount - 1 | torow < fromrow)
						{
							torow = sdv.RowCount - 1;
						}
						ddv.AllowUserToAddRows = false;
						while (ddv.ColumnCount >= 1)
						{
							ddv.Columns.RemoveAt(0);
						}
						ddv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
						ddv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
						int num = 0;
						int num2 = sdv.ColumnCount - 1;
						int i = num;
						while (i <= num2)
						{
							if (!(String.Compare(Versioned.TypeName(sdv.Columns[i]), "DataGridViewComboBoxColumn", false) == 0 | String.Compare(Versioned.TypeName(sdv.Columns[i]), "DataGridViewColumn", false) == 0))
							{
								goto IL_256;
							}
							DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
							try
							{
								dataGridViewTextBoxColumn.DefaultCellStyle = sdv.Columns[i].DefaultCellStyle.Clone();
								dataGridViewTextBoxColumn.AutoSizeMode = sdv.Columns[i].AutoSizeMode;
								dataGridViewTextBoxColumn.DisplayIndex = sdv.Columns[i].DisplayIndex;
							}
							catch (Exception ex)
							{
							}
							try
							{
								dataGridViewTextBoxColumn.HeaderCell = (DataGridViewColumnHeaderCell)sdv.Columns[i].HeaderCell.Clone();
								dataGridViewTextBoxColumn.HeaderText = sdv.Columns[i].HeaderText;
								dataGridViewTextBoxColumn.MinimumWidth = sdv.Columns[i].MinimumWidth;
								dataGridViewTextBoxColumn.Resizable = sdv.Columns[i].Resizable;
							}
							catch (Exception ex2)
							{
							}
							try
							{
								dataGridViewTextBoxColumn.Name = sdv.Columns[i].Name;
								dataGridViewTextBoxColumn.Tag = RuntimeHelpers.GetObjectValue(sdv.Columns[i].Tag);
								dataGridViewTextBoxColumn.Visible = sdv.Columns[i].Visible;
								try
								{
									if (String.Compare(Convert.ToString(dataGridViewTextBoxColumn.Tag), "不打印", false) == 0)
									{
										dataGridViewTextBoxColumn.Visible = false;
									}
								}
								catch (Exception ex3)
								{
								}
								dataGridViewTextBoxColumn.Width = sdv.Columns[i].Width;
								goto IL_364;
							}
							catch (Exception ex4)
							{
								goto IL_364;
							}
							goto IL_256;
							IL_364:
							ddv.Columns.Add(dataGridViewTextBoxColumn);
							Block_13:
							try
							{
								ddv.Columns[i].ValueType = sdv.Columns[i].ValueType;
							}
							catch (Exception ex5)
							{
							}
							if (String.Compare(ddv.Columns[i].Name + "", "", false) == 0)
							{
								ddv.Columns[i].Name = "第" + Convert.ToString(i) + "列名";
							}
							ddv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
							ddv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
							i++;
							continue;
							IL_256:
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)sdv.Columns[i].Clone();
							dataGridViewColumn.Frozen = false;
							try
							{
								if (String.Compare(Convert.ToString(dataGridViewColumn.Tag), "不打印", false) == 0)
								{
									dataGridViewColumn.Visible = false;
								}
							}
							catch (Exception ex6)
							{
							}
							ddv.Columns.Add(dataGridViewColumn);
							goto Block_13;
						}
						int[] array = new int[sdv.ColumnCount - 1 + 1];
						int[] array2 = new int[sdv.ColumnCount - 1 + 1];
						int num3 = 0;
						int num4 = sdv.ColumnCount - 1;
						for (int j = num3; j <= num4; j++)
						{
							array[j] = j;
							array2[j] = sdv.Columns[j].DisplayIndex;
						}
						Array.Sort<int, int>(array2, array);
						int num5 = 0;
						int num6 = sdv.ColumnCount - 1;
						for (i = num5; i <= num6; i++)
						{
							ddv.Columns[array[i]].DisplayIndex = sdv.Columns[array[i]].DisplayIndex;
						}
						ddv.ColumnHeadersHeightSizeMode = sdv.ColumnHeadersHeightSizeMode;
						ddv.ColumnHeadersHeight = sdv.ColumnHeadersHeight;
						ddv.ColumnHeadersVisible = sdv.ColumnHeadersVisible;
						if (sdv.RowCount > 0)
						{
							int rowCount = torow - fromrow + 1;
							ddv.RowCount = rowCount;
							ddv.AlternatingRowsDefaultCellStyle = sdv.AlternatingRowsDefaultCellStyle.Clone();
							ddv.DefaultCellStyle = sdv.DefaultCellStyle.Clone();
							ddv.RowsDefaultCellStyle = sdv.RowsDefaultCellStyle.Clone();
							ddv.ColumnHeadersDefaultCellStyle = sdv.ColumnHeadersDefaultCellStyle.Clone();
							int num7 = 0;
							int num8 = sdv.ColumnCount - 1;
							for (i = num7; i <= num8; i++)
							{
								if (sdv.Columns[i].HasDefaultCellStyle)
								{
									ddv.Columns[i].DefaultCellStyle = sdv.Columns[i].DefaultCellStyle.Clone();
								}
							}
							int num9 = fromrow;
							int num10 = torow;
							for (i = num9; i <= num10; i++)
							{
								int num11 = 0;
								int num12 = ddv.Columns.Count - 1;
								int k = num11;
								while (k <= num12)
								{
									if (String.Compare(Versioned.TypeName(sdv.Columns[k]), "DataGridViewImageColumn", false) != 0)
									{
										goto IL_5F1;
									}
									ddv.Rows[i - fromrow].Cells[k].Value = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Cells[k].FormattedValue);
									if (ddv.Rows[i - fromrow].Cells[k].Value != null)
									{
										try
										{
											DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)ddv.Rows[i - fromrow].Cells[k];
											dataGridViewImageCell.ImageLayout = ((DataGridViewImageCell)sdv.Rows[i].Cells[k]).ImageLayout;
											
										}
										catch (Exception ex7)
										{
											
										}
										goto IL_5F1;
									}
									for (;;)
									{
										IL_6D3:
										if (sdv.Rows[i].Cells[k].HasStyle)
										{
											ddv.Rows[i - fromrow].Cells[k].Style = sdv.Rows[i].Cells[k].Style.Clone();
										}
										try
										{
											ddv.Rows[i - fromrow].Cells[k].Tag = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Cells[k].Tag);
											break;
										}
										catch (Exception ex8)
										{
											break;
										}
									}
									k++;
									continue;
									IL_5F1:
									ddv.Rows[i - fromrow].Cells[k].Value = Convert.ToString(sdv.Rows[i].Cells[k].FormattedValue) + "";
									
								}
								ddv.Rows[i - fromrow].Height = sdv.Rows[i].Height;
								ddv.Rows[i - fromrow].Visible = sdv.Rows[i].Visible;
								if (sdv.Rows[i].HasDefaultCellStyle)
								{
									ddv.Rows[i - fromrow].DefaultCellStyle = sdv.Rows[i].DefaultCellStyle.Clone();
								}
								try
								{
									ddv.Rows[i - fromrow].Tag = RuntimeHelpers.GetObjectValue(sdv.Rows[i].Tag);
								}
								catch (Exception ex9)
								{
								}
							}
							ddv.GridColor = sdv.GridColor;
							ddv.Name = sdv.Name;
							if (isprintrowheadercolumn)
							{
								try
								{
									if (ddv.Columns.Count > 0)
									{
										DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
										dataGridViewTextBoxColumn2.HeaderCell = (DataGridViewColumnHeaderCell)sdv.TopLeftHeaderCell.Clone();
										if (sdv.TopLeftHeaderCell.HasStyle)
										{
											dataGridViewTextBoxColumn2.HeaderCell.Style = sdv.TopLeftHeaderCell.Style.Clone();
										}
										dataGridViewTextBoxColumn2.Width = sdv.RowHeadersWidth;
										if (String.Compare(dataGridViewTextBoxColumn2.Name + "", "", false) == 0)
										{
											dataGridViewTextBoxColumn2.Name = "平平自创";
										}
										dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
										ddv.Columns.Insert(0, dataGridViewTextBoxColumn2);
										rowCount = ddv.RowCount;
										int num13 = fromrow;
										int num14 = torow;
										for (i = num13; i <= num14; i++)
										{
											ddv.Rows[i - fromrow].Cells[0].Value = Convert.ToString(sdv.Rows[i].HeaderCell.FormattedValue) + "";
											if (sdv.Rows[i].HeaderCell.Style.Font != null)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.Font = (Font)sdv.Rows[i].HeaderCell.Style.Font.Clone();
											}
											else if (sdv.RowHeadersDefaultCellStyle.Font != null)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.Font = (Font)sdv.RowHeadersDefaultCellStyle.Font.Clone();
											}
											if (sdv.Rows[i].HeaderCell.Style.Alignment != DataGridViewContentAlignment.NotSet)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.Alignment = sdv.Rows[i].HeaderCell.Style.Alignment;
											}
											else
											{
												ddv.Rows[i - fromrow].Cells[0].Style.Alignment = sdv.RowHeadersDefaultCellStyle.Alignment;
											}
											if (sdv.Rows[i].HeaderCell.Style.ForeColor.ToArgb() != 0)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.ForeColor = sdv.Rows[i].HeaderCell.Style.ForeColor;
											}
											else if (sdv.RowHeadersDefaultCellStyle.ForeColor.ToArgb() != 0)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.ForeColor = sdv.RowHeadersDefaultCellStyle.ForeColor;
											}
											if (sdv.Rows[i].HeaderCell.Style.BackColor.ToArgb() != 0)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.BackColor = sdv.Rows[i].HeaderCell.Style.BackColor;
											}
											else if (sdv.RowHeadersDefaultCellStyle.BackColor.ToArgb() != 0)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.BackColor = sdv.RowHeadersDefaultCellStyle.BackColor;
											}
											if (sdv.Rows[i].HeaderCell.Style.WrapMode != DataGridViewTriState.NotSet)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.WrapMode = sdv.Rows[i].HeaderCell.Style.WrapMode;
											}
											else if (sdv.RowHeadersDefaultCellStyle.WrapMode != DataGridViewTriState.NotSet)
											{
												ddv.Rows[i - fromrow].Cells[0].Style.WrapMode = sdv.RowHeadersDefaultCellStyle.WrapMode;
											}
										}
									}
								}
								catch (Exception ex10)
								{
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00103BEC File Offset: 0x00101DEC
		public static void DelDGVAllUnvisibleCols(DataGridView dgv)
		{
			checked
			{
				if (dgv != null)
				{
					try
					{
						int columnCount = dgv.ColumnCount;
						for (int i = columnCount - 1; i >= 0; i += -1)
						{
							if (!dgv.Columns[i].Visible)
							{
								dgv.Columns.RemoveAt(i);
							}
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00103C50 File Offset: 0x00101E50
		public static void AddDGVRowID(DataGridView dgv)
		{
			checked
			{
				if (dgv.Columns.Count > 0)
				{
					DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
					dataGridViewTextBoxColumn.HeaderText = "行号";
					dataGridViewTextBoxColumn.DefaultCellStyle = dgv.DefaultCellStyle.Clone();
					dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					dataGridViewTextBoxColumn.Width = 40;
					dataGridViewTextBoxColumn.Name = "游平自创";
					try
					{
						dgv.Columns.Insert(0, dataGridViewTextBoxColumn);
					}
					catch (Exception ex)
					{
						dataGridViewTextBoxColumn.Frozen = true;
						dgv.Columns.Insert(0, dataGridViewTextBoxColumn);
					}
					try
					{
						int num = 1;
						int num2 = 0;
						int num3 = dgv.RowCount - 1;
						for (int i = num2; i <= num3; i++)
						{
							if (dgv.Rows[i].Visible)
							{
								dgv.Rows[i].Cells[0].Value = Convert.ToString(num);
								num++;
							}
						}
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00103D60 File Offset: 0x00101F60
		public static int GetDGVVisibleRows(DataGridView dgv)
		{
			checked
			{
				int result;
				if (dgv == null)
				{
					result = 0;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = dgv.RowCount - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (dgv.Rows[i].Visible)
						{
							num++;
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00103DA8 File Offset: 0x00101FA8
		public static bool IsNullLastRow(DataGridView dgv)
		{
			checked
			{
				bool result=false;
				if (dgv == null)
				{
					result = false;
				}
				else if (dgv.RowCount <= 0)
				{
					result = false;
				}
				else
				{
					int index = dgv.RowCount - 1;
					bool flag = true;
					try
					{
						int num = 0;
						int num2 = dgv.ColumnCount - 1;
						for (int i = num; i <= num2; i++)
						{
							if (String.Compare(Versioned.TypeName(dgv.Columns[i]), "DataGridViewImageColumn", false) != 0)
							{
								if (Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(dgv.Rows[index].Cells[i].Value, ""), "", false))
								{
									flag = false;
									IL_94:
									if (flag)
									{
										return true;
									}
									return false;
								}
							}
						}
						
					}
					catch (Exception ex)
					{
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00103E78 File Offset: 0x00102078
		public static void SetDGVSelectedRowsVisible(DataGridView sdgv, DataGridView ddgv, int baserows)
		{
			checked
			{
				if (sdgv != null && ddgv != null)
				{
					int num = 0;
					int num2 = ddgv.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						ddgv.Rows[i].Visible = false;
					}
					List<int> dgvselectedRows = Module1.GetDGVSelectedRows(sdgv);
					int num3 = 0;
					int num4 = dgvselectedRows.Count - 1;
					for (int j = num3; j <= num4; j++)
					{
						ddgv.Rows[dgvselectedRows[j] - baserows].Visible = true;
					}
				}
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00103EF0 File Offset: 0x001020F0
		public static void SetDGVSelectedColumnsVisible(DataGridView sdgv, DataGridView ddgv)
		{
			checked
			{
				if (sdgv != null && ddgv != null)
				{
					bool[] array = new bool[sdgv.Columns.Count - 1 + 1];
					int num = 0;
					int num2 = sdgv.Columns.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = false;
					}
					List<int> dgvselectedCols = Module1.GetDGVSelectedCols(sdgv);
					int num3 = 0;
					int num4 = dgvselectedCols.Count - 1;
					for (int j = num3; j <= num4; j++)
					{
						array[dgvselectedCols[j]] = true;
					}
					int num5 = 0;
					int num6 = ddgv.Columns.Count - 1;
					for (int k = num5; k <= num6; k++)
					{
						if (!array[k])
						{
							ddgv.Columns[k].Visible = false;
						}
					}
				}
			}
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00103FA0 File Offset: 0x001021A0
		public static List<int> GetDGVSelectedCols(DataGridView dgv)
		{
			checked
			{
				List<int> result;
				if (dgv == null)
				{
					result = null;
				}
				else if (dgv.SelectedCells.Count <= 0)
				{
					result = null;
				}
				else
				{
					int num = dgv.RowCount - 1;
					int num2 = dgv.ColumnCount - 1;
					List<int> list = new List<int>();
					int num3 = 0;
					int num4 = num2;
					for (int i = num3; i <= num4; i++)
					{
						if (dgv.Columns[i].Visible)
						{
							int num5 = 0;
							int num6 = num;
							for (int j = num5; j <= num6; j++)
							{
								if (dgv.Rows[j].Cells[i].Selected)
								{
									list.Add(i);
									break;
								}
							}
						}
					}
					result = list;
				}
				return result;
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00104050 File Offset: 0x00102250
		public static List<int> GetDGVSelectedRows(DataGridView dgv)
		{
			checked
			{
				List<int> result;
				if (dgv == null)
				{
					result = null;
				}
				else if (dgv.SelectedCells.Count <= 0)
				{
					result = null;
				}
				else
				{
					int num = dgv.RowCount - 1;
					int num2 = dgv.ColumnCount - 1;
					List<int> list = new List<int>();
					int num3 = 0;
					int num4 = num;
					for (int i = num3; i <= num4; i++)
					{
						if (dgv.Rows[i].Visible)
						{
							int num5 = 0;
							int num6 = num2;
							for (int j = num5; j <= num6; j++)
							{
								if (dgv.Rows[i].Cells[j].Selected)
								{
									list.Add(i);
									break;
								}
							}
						}
					}
					result = list;
				}
				return result;
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0000AC6A File Offset: 0x00008E6A
		public static void SetDGVSelectedRowsAndColumnsVisible(DataGridView sdgv, DataGridView ddgv, int baserows)
		{
			Module1.SetDGVSelectedRowsVisible(sdgv, ddgv, baserows);
			Module1.SetDGVSelectedColumnsVisible(sdgv, ddgv);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00104100 File Offset: 0x00102300
		public static int GetDGVSelectedMinRowIndex(DataGridView dgv)
		{
			checked
			{
				int result;
				if (dgv == null)
				{
					result = -1;
				}
				else if (dgv.RowCount <= 0)
				{
					result = -1;
				}
				else if (dgv.SelectedCells.Count <= 0)
				{
					result = -1;
				}
				else
				{
					int num = dgv.RowCount - 1;
					int num2 = dgv.ColumnCount - 1;
					int num3 = 0;
					int num4 = num;
					for (int i = num3; i <= num4; i++)
					{
						int num5 = 0;
						int num6 = num2;
						for (int j = num5; j <= num6; j++)
						{
							if (dgv.Rows[i].Cells[j].Selected)
							{
								return i;
							}
						}
					}
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00104190 File Offset: 0x00102390
		public static int GetDGVSelectedMaxRowIndex(DataGridView dgv)
		{
			checked
			{
				int result;
				if (dgv == null)
				{
					result = -1;
				}
				else if (dgv.RowCount <= 0)
				{
					result = -1;
				}
				else if (dgv.SelectedCells.Count <= 0)
				{
					result = -1;
				}
				else
				{
					int num = dgv.RowCount - 1;
					int num2 = dgv.ColumnCount - 1;
					for (int i = num; i >= 0; i += -1)
					{
						int num3 = 0;
						int num4 = num2;
						for (int j = num3; j <= num4; j++)
						{
							if (dgv.Rows[i].Cells[j].Selected)
							{
								return i;
							}
						}
					}
					result = -1;
				}
				return result;
			}
		}



		// Token: 0x06001F1D RID: 7965 RVA: 0x00104504 File Offset: 0x00102704
		private static DataGridViewContentAlignment ConvertAlignment(HorizontalAlignment ss)
		{
			DataGridViewContentAlignment result;
			switch (ss)
			{
			case HorizontalAlignment.Left:
				result = DataGridViewContentAlignment.MiddleLeft;
				break;
			case HorizontalAlignment.Right:
				result = DataGridViewContentAlignment.MiddleRight;
				break;
			case HorizontalAlignment.Center:
				result = DataGridViewContentAlignment.MiddleCenter;
				break;
			default:
				result = DataGridViewContentAlignment.MiddleLeft;
				break;
			}
			return result;
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00104538 File Offset: 0x00102738
		private static bool IsColumNameExists(DataGridView dd, string tt)
		{
			checked
			{
				bool result;
				if (dd == null)
				{
					result = false;
				}
				else if (String.Compare(tt + "", "", false) == 0)
				{
					result = false;
				}
				else
				{
					string[] array = Strings.Split(tt, ";", -1, CompareMethod.Binary);
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						try
						{
							int displayIndex = dd.Columns[array[i]].DisplayIndex;
						}
						catch (Exception ex)
						{
							return false;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x001045C4 File Offset: 0x001027C4
		public static void CreateHz(DataGridView dgv, int srows, string myhzcolumns, Font hzfont, Color hzforecolor, Color hzbackcolor, StringAlignment SumNumberAlign)
		{
			if (dgv.AllowUserToAddRows)
			{
				dgv.AllowUserToAddRows = false;
			}
			checked
			{
				if (dgv.RowCount > srows)
				{
					dgv.Rows.RemoveAt(dgv.RowCount - 1);
				}
				if (!Module1.IsColumNameExists(dgv, myhzcolumns))
				{
					myhzcolumns = "";
				}
				if (String.Compare(myhzcolumns + "", "", false) != 0)
				{
					string[] array = Strings.Split(myhzcolumns, ";", -1, CompareMethod.Binary);
					if (array.Length >= 1)
					{
						if (dgv.RowCount == srows)
						{
							dgv.Rows.Add();
						}
						decimal num = 0m;
						int num2 = 0;
						int num3 = array.Length - 1;
						string text;
						for (int i = num2; i <= num3; i++)
						{
							num = 0m;
							try
							{
								int num4 = 0;
								int num5 = srows - 1;
								for (int j = num4; j <= num5; j++)
								{
									if (dgv.Rows[j].Visible)
									{
										text = Convert.ToString(dgv.Rows[j].Cells[array[i]].Value);
										if (Versioned.IsNumeric(text))
										{
											num = decimal.Add(num, Convert.ToDecimal(text));
										}
									}
								}
								if (String.Compare(Versioned.TypeName(dgv.Columns[array[i]]), "DataGridViewCheckBoxColumn", false) == 0)
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = false;
								}
								else if (String.Compare(Versioned.TypeName(dgv.Columns[array[i]]), "DataGridViewImageColumn", false) == 0)
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = null;
								}
								else if (decimal.Compare(new decimal(Convert.ToInt64(num)), num) == 0)
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = Convert.ToString(num);
								}
								else
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = Convert.ToString(num);
								}
							}
							catch (Exception ex)
							{
								if (String.Compare(Versioned.TypeName(dgv.Columns[array[i]]), "DataGridViewCheckBoxColumn", false) == 0)
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = false;
								}
								else if (String.Compare(Versioned.TypeName(dgv.Columns[array[i]]), "DataGridViewImageColumn", false) == 0)
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = null;
								}
								else
								{
									dgv.Rows[dgv.RowCount - 1].Cells[array[i]].Value = "";
								}
							}
						}
						if (hzfont != null)
						{
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.Font = hzfont;
						}
						if (hzforecolor.ToArgb() != 0)
						{
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.ForeColor = hzforecolor;
						}
						if (hzbackcolor.ToArgb() != 0)
						{
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.BackColor = hzbackcolor;
						}
						text = Module1.GetDGVFirstColumnName(dgv);
						if (String.Compare(text, "", false) != 0)
						{
							dgv.Rows[dgv.RowCount - 1].Cells[text].Value = "总计";
						}
						dgv.Rows[dgv.RowCount - 1].Cells[text].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
						switch (SumNumberAlign)
						{
						case StringAlignment.Near:
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
							break;
						case StringAlignment.Center:
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
							break;
						case StringAlignment.Far:
							dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00104A30 File Offset: 0x00102C30
		public static void CreateFzHz(DataGridView dgv, string groupcolumn, string myhzcolumns, Font hzfont, Color hzforecolor, Color hzbackcolor, bool addrowid, bool addrowidnew, StringAlignment SumNumberAlign)
		{
			if (dgv.AllowUserToAddRows)
			{
				dgv.AllowUserToAddRows = false;
			}
			if (addrowid)
			{
				Module1.AddDGVRowID(dgv);
			}
			groupcolumn += "";
			checked
			{
				if (String.Compare(groupcolumn, "", false) != 0)
				{
					string[] array = Strings.Split(myhzcolumns, ";", -1, CompareMethod.Binary);
					if (array.Length >= 1)
					{
						int num = 1;
						int fromrow = 0;
						if (String.Compare(Versioned.TypeName(dgv.Columns[groupcolumn]), "DataGridViewImageColumn", false) != 0)
						{
							string left = Convert.ToString(dgv.Rows[0].Cells[groupcolumn].FormattedValue) + "";
							if (dgv.Rows[0].Visible && addrowid)
							{
								dgv.Rows[0].Cells[0].Value = Convert.ToString(num);
								num++;
							}
							int num2 = dgv.RowCount;
							if (!Module1.IsColumNameExists(dgv, myhzcolumns))
							{
								myhzcolumns = "";
							}
							if (String.Compare(myhzcolumns + "", "", false) != 0)
							{
								num2--;
							}
							for (int i = 1; i <= num2 - 1; i++)
							{
								if (String.Compare(left, Convert.ToString(dgv.Rows[i].Cells[groupcolumn].FormattedValue) + "", false) != 0)
								{
									left = Convert.ToString(dgv.Rows[i].Cells[groupcolumn].FormattedValue) + "";
									if (addrowidnew)
									{
										num = 1;
									}
									int torow = i - 1;
									if (Module1.CreateHzRow(dgv, groupcolumn, myhzcolumns, hzfont, hzforecolor, hzbackcolor, fromrow, torow, SumNumberAlign))
									{
										num2 = dgv.RowCount;
										num2--;
										fromrow = i + 1;
										i++;
									}
									else
									{
										fromrow = i;
									}
								}
								if (dgv.Rows[i].Visible && addrowid)
								{
									dgv.Rows[i].Cells[0].Value = Convert.ToString(num);
									num++;
								}
							}
							if (String.Compare(myhzcolumns + "", "", false) == 0)
							{
								Module1.CreateHzRow(dgv, groupcolumn, myhzcolumns, hzfont, hzforecolor, hzbackcolor, fromrow, dgv.RowCount - 1, SumNumberAlign);
							}
							else
							{
								Module1.CreateHzRow(dgv, groupcolumn, myhzcolumns, hzfont, hzforecolor, hzbackcolor, fromrow, dgv.RowCount - 1 - 1, SumNumberAlign);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00104CB0 File Offset: 0x00102EB0
		private static bool CreateHzRow(DataGridView dgv, string groupcolumn, string myhzcolumns, Font hzfont, Color hzforecolor, Color hzbackcolor, int fromrow, int torow, StringAlignment SumNumberAlign)
		{
			checked
			{
				int num = torow + 1;
				decimal num2 = 0m;
				bool result;
				if (String.Compare(myhzcolumns + "", "", false) == 0)
				{
					dgv.Rows[torow].Tag = "分组";
					result = false;
				}
				else
				{
					string[] array = Strings.Split(myhzcolumns, ";", -1, CompareMethod.Binary);
					if (array.Length < 1)
					{
						result = false;
					}
					else
					{
						int num3 = 0;
						for (int i = fromrow; i <= torow; i++)
						{
							if (dgv.Rows[i].Visible)
							{
								num3++;
							}
						}
						if (num3 == 0)
						{
							result = false;
						}
						else
						{
							if (num >= dgv.RowCount)
							{
								dgv.Rows.Add();
							}
							else
							{
								dgv.Rows.Insert(num, new object[0]);
							}
							int num4 = 0;
							int num5 = array.Length - 1;
							string text;
							for (int j = num4; j <= num5; j++)
							{
								num2 = 0m;
								try
								{
									for (int i = fromrow; i <= torow; i++)
									{
										if (dgv.Rows[i].Visible)
										{
											text = Convert.ToString(dgv.Rows[i].Cells[array[j]].Value);
											if (Versioned.IsNumeric(text))
											{
												num2 = decimal.Add(num2, Convert.ToDecimal(text));
											}
										}
									}
									if (String.Compare(Versioned.TypeName(dgv.Columns[array[j]]), "DataGridViewCheckBoxColumn", false) == 0)
									{
										dgv.Rows[num].Cells[array[j]].Value = false;
									}
									else if (String.Compare(Versioned.TypeName(dgv.Columns[array[j]]), "DataGridViewImageColumn", false) == 0)
									{
										dgv.Rows[num].Cells[array[j]].Value = null;
									}
									else if (decimal.Compare(new decimal(Convert.ToInt64(num2)), num2) == 0)
									{
										dgv.Rows[num].Cells[array[j]].Value = Convert.ToString(num2);
									}
									else
									{
										dgv.Rows[num].Cells[array[j]].Value = Convert.ToString(num2);
									}
								}
								catch (Exception ex)
								{
									if (String.Compare(Versioned.TypeName(dgv.Columns[array[j]]), "DataGridViewCheckBoxColumn", false) == 0)
									{
										dgv.Rows[num].Cells[array[j]].Value = false;
									}
									else if (String.Compare(Versioned.TypeName(dgv.Columns[array[j]]), "DataGridViewImageColumn", false) == 0)
									{
										dgv.Rows[num].Cells[array[j]].Value = null;
									}
									else
									{
										dgv.Rows[num].Cells[array[j]].Value = "";
									}
								}
							}
							if (hzfont != null)
							{
								dgv.Rows[num].DefaultCellStyle.Font = hzfont;
							}
							if (hzforecolor.ToArgb() != 0)
							{
								dgv.Rows[num].DefaultCellStyle.ForeColor = hzforecolor;
							}
							if (hzbackcolor.ToArgb() != 0)
							{
								dgv.Rows[num].DefaultCellStyle.BackColor = hzbackcolor;
							}
							dgv.Rows[num].Cells[groupcolumn].Value = RuntimeHelpers.GetObjectValue(dgv.Rows[fromrow].Cells[groupcolumn].Value);
							dgv.Rows[num].Cells[groupcolumn].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							text = Module1.GetDGVFirstColumnName(dgv);
							if (String.Compare(text, "", false) != 0)
							{
								dgv.Rows[num].Cells[text].Value = "小计";
							}
							dgv.Rows[num].Cells[text].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							dgv.Rows[num].Tag = "分组";
							switch (SumNumberAlign)
							{
							case StringAlignment.Near:
								dgv.Rows[num].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
								break;
							case StringAlignment.Center:
								dgv.Rows[num].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
								break;
							case StringAlignment.Far:
								dgv.Rows[num].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
								break;
							}
							result = true;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00105180 File Offset: 0x00103380
		public static string GetDGVFirstColumnName(DataGridView dgv)
		{
			string result = "";
			int num = -1;
			int num2 = 0;
			checked
			{
				int num3 = dgv.ColumnCount - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (num == -1)
					{
						if (dgv.Columns[i].Visible)
						{
							num = dgv.Columns[i].DisplayIndex;
							result = dgv.Columns[i].Name;
						}
					}
					else if (dgv.Columns[i].Visible && dgv.Columns[i].DisplayIndex < num)
					{
						num = dgv.Columns[i].DisplayIndex;
						result = dgv.Columns[i].Name;
					}
				}
				return result;
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00105240 File Offset: 0x00103440
		public static bool IsHzColumn(string myhzcolumns, string columname)
		{
			checked
			{
				bool result;
				if (String.Compare(myhzcolumns, "", false) == 0 | myhzcolumns == null)
				{
					result = false;
				}
				else
				{
					string[] array = Strings.Split(myhzcolumns, ";", -1, CompareMethod.Binary);
					if (array.Length <= 0)
					{
						result = false;
					}
					else
					{
						int num = 0;
						int num2 = array.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							if (String.Compare(array[i], columname, false) == 0)
							{
								return true;
							}
						}
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x001052A8 File Offset: 0x001034A8
		public static bool IsValidPrinterName(string printername)
		{
			bool result = false;
			try
			{
				foreach (object value in PrinterSettings.InstalledPrinters)
				{
					string text = Convert.ToString(value);
					text = Strings.Trim(text);
					if (String.Compare(printername.ToLower(), text.ToLower(), false) == 0)
					{
						result = true;
						break;
					}
				}
			}
			finally
			{
				
			}
			return result;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00105324 File Offset: 0x00103524
		public static void CreatePaper(string printername, string papername, int width, int height)
		{
			PrinterSettings printerSettings = new PrinterSettings();
			if (!Module1.IsValidPrinterName(printername))
			{
				printername = printerSettings.PrinterName;
			}
			PaperSize printForm = definepaper.GetPrintForm(printername, papername);
			if (printForm != null)
			{
				if (checked(printForm.Width != (int)Math.Round(Convert.ToDouble(decimal.Multiply(new decimal(width), 10m)) / 2.54) | printForm.Height != (int)Math.Round(Convert.ToDouble(decimal.Multiply(new decimal(height), 10m)) / 2.54)))
				{
					definepaper.SetPrintForm(printername, papername, (float)width, (float)height);
				}
			}
			else
			{
				definepaper.SetPrintForm(printername, papername, (float)width, (float)height);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x001053E4 File Offset: 0x001035E4
		public static bool IsValidPaper(string printername, string papername)
		{
			PrinterSettings printerSettings = new PrinterSettings();
			if (!Module1.IsValidPrinterName(printername))
			{
				printername = printerSettings.PrinterName;
			}
			return definepaper.GetPrintForm(printername, papername) != null;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0010541C File Offset: 0x0010361C
		public static int ConvertPixlsToTwips(float x, bool isx)
		{
			float num = (float)((double)Module1.G_ruler.ConvertToMM(x, isx) * 56.7);
			return checked((int)Math.Round((double)num));
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0010544C File Offset: 0x0010364C
		public static float ConvertTwipsToPixls(float x, bool isx)
		{
			float num = (float)((double)x / 56.7);
			return (float)((double)Module1.G_ruler.ConvertFromMM(x, isx) * 5.67);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00105484 File Offset: 0x00103684
		public static float ConvertInchToCm(float xx)
		{
			return (float)((double)xx * 2.54);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x001054A0 File Offset: 0x001036A0
		public static float ConvertInchToMm(float xx)
		{
			return (float)((double)xx * 25.4);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x001054BC File Offset: 0x001036BC
		public static float ConvertCmToInch(float xx)
		{
			return (float)((double)xx / 2.54);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x001054D8 File Offset: 0x001036D8
		public static float ConvertMmToInch(float xx)
		{
			return (float)((double)xx / 25.4);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x001054F4 File Offset: 0x001036F4
		public static string ConvertImageToString(string picturefile)
		{
			checked
			{
				string result;
				try
				{
					FileStream fileStream = new FileStream(picturefile, FileMode.Open, FileAccess.Read, FileShare.Read);
					byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
					fileStream.Read(array, 0, (int)fileStream.Length);
					fileStream.Close();
					result = Convert.ToBase64String(array);
				}
				catch (Exception ex)
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00105568 File Offset: 0x00103768
		public static string ConvertImageToString(Image img)
		{
			string result;
			if (img == null)
			{
				result = "";
			}
			else
			{
				try
				{
					string tempFileName = MyProject.Computer.FileSystem.GetTempFileName();
					img.Save(tempFileName, ImageFormat.Png);
					string text = Module1.ConvertImageToString(tempFileName);
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(tempFileName);
					}
					catch (Exception ex)
					{
					}
					result = text;
				}
				catch (Exception ex2)
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00105600 File Offset: 0x00103800
		public static Image ConvertStringToImage(string picturestring)
		{
			Image result;
			if (String.Compare(picturestring + "", "", false) == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					byte[] buffer = Convert.FromBase64String(picturestring);
					MemoryStream stream = new MemoryStream(buffer);
					result = Image.FromStream(stream);
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00105664 File Offset: 0x00103864
		public static string ConvertIcoToString(Icon img)
		{
			checked
			{
				string result;
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					img.Save(memoryStream);
					memoryStream.Position = 0L;
					byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
					memoryStream.Read(array, 0, (int)memoryStream.Length);
					memoryStream.Close();
					result = Convert.ToBase64String(array);
				}
				catch (Exception ex)
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x001056EC File Offset: 0x001038EC
		public static Icon ConvertStringToIcon(string picturestring)
		{
			Icon result;
			if (String.Compare(picturestring + "", "", false) == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					byte[] buffer = Convert.FromBase64String(picturestring);
					MemoryStream stream = new MemoryStream(buffer);
					result = new Icon(stream);
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00105750 File Offset: 0x00103950
		private static DataGridView ConvertListViewToDGV2(ListView lv)
		{
			checked
			{
				DataGridView result;
				if (lv == null)
				{
					result = null;
				}
				else
				{
					DataGridView dataGridView = new DataGridView();
					dataGridView.AllowUserToAddRows = false;
					dataGridView.RowCount = lv.Items.Count;
					dataGridView.ColumnCount = lv.Columns.Count;
					try
					{
						dataGridView.DefaultCellStyle.Font = (Font)lv.Font.Clone();
					}
					catch (Exception ex)
					{
					}
					dataGridView.ForeColor = lv.ForeColor;
					dataGridView.DefaultCellStyle.ForeColor = lv.ForeColor;
					int num = 0;
					int num2 = lv.Columns.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						dataGridView.Columns[i].HeaderText = lv.Columns[i].Text;
						try
						{
							dataGridView.Columns[i].DefaultCellStyle.Font = (Font)lv.Font.Clone();
						}
						catch (Exception ex2)
						{
						}
						dataGridView.Columns[i].Width = lv.Columns[i].Width;
						dataGridView.Columns[i].DisplayIndex = lv.Columns[i].DisplayIndex;
					}
					int num3 = 0;
					int num4 = lv.Items.Count - 1;
					for (int i = num3; i <= num4; i++)
					{
						Module1.CopyListViewItemToDGV(lv, lv.Items[i], dataGridView.Rows[i]);
					}
					result = dataGridView;
				}
				return result;
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x001058F8 File Offset: 0x00103AF8
		public static DataGridView ConvertListViewToDGV(ListView lv)
		{
			checked
			{
				DataGridView result;
				if (lv == null)
				{
					result = null;
				}
				else
				{
					if (lv.ShowGroups)
					{
						DataGridView dataGridView = new DataGridView();
						dataGridView.ColumnCount = lv.Columns.Count;
						dataGridView.AllowUserToAddRows = false;
						try
						{
							dataGridView.DefaultCellStyle.Font = (Font)lv.Font.Clone();
						}
						catch (Exception ex)
						{
						}
						dataGridView.ForeColor = lv.ForeColor;
						dataGridView.DefaultCellStyle.ForeColor = lv.ForeColor;
						int num = 0;
						int num2 = lv.Columns.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							dataGridView.Columns[i].HeaderText = lv.Columns[i].Text;
							try
							{
								dataGridView.Columns[i].DefaultCellStyle.Font = (Font)lv.Font.Clone();
							}
							catch (Exception ex2)
							{
							}
							dataGridView.Columns[i].Width = lv.Columns[i].Width;
							dataGridView.Columns[i].DisplayIndex = lv.Columns[i].DisplayIndex;
						}
						bool flag = false;
						int num3 = 0;
						int num4 = lv.Items.Count - 1;
						for (int i = num3; i <= num4; i++)
						{
							if (lv.Items[i].Group == null)
							{
								flag = true;
								IL_181:
								if (flag)
								{
									dataGridView.RowCount++;
									DataGridViewRow dataGridViewRow = dataGridView.Rows[dataGridView.RowCount - 1];
									Module1.CopyListViewGroutItemToDGV(lv, "Default", HorizontalAlignment.Left, dataGridViewRow);
									int num5 = 0;
									int num6 = lv.Items.Count - 1;
									for (i = num5; i <= num6; i++)
									{
										if (lv.Items[i].Group == null)
										{
											dataGridView.RowCount++;
											dataGridViewRow = dataGridView.Rows[dataGridView.RowCount - 1];
											Module1.CopyListViewItemToDGV(lv, lv.Items[i], dataGridViewRow);
										}
									}
								}
								int num7 = 0;
								int num8 = lv.Groups.Count - 1;
								for (i = num7; i <= num8; i++)
								{
									if (lv.Groups[i].Items.Count > 0)
									{
										dataGridView.RowCount++;
										DataGridViewRow dataGridViewRow = dataGridView.Rows[dataGridView.RowCount - 1];
										Module1.CopyListViewGroutItemToDGV(lv, lv.Groups[i].Header, lv.Groups[i].HeaderAlignment, dataGridViewRow);
										int num9 = 0;
										int num10 = lv.Groups[i].Items.Count - 1;
										for (int j = num9; j <= num10; j++)
										{
											dataGridView.RowCount++;
											dataGridViewRow = dataGridView.Rows[dataGridView.RowCount - 1];
											Module1.CopyListViewItemToDGV(lv, lv.Groups[i].Items[j], dataGridViewRow);
										}
									}
								}
								return dataGridView;
							}
						}
						
					}
					result = Module1.ConvertListViewToDGV2(lv);
				}
				return result;
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00105C44 File Offset: 0x00103E44
		private static void CopyListViewGroutItemToDGV(ListView lv, string mygroupname, HorizontalAlignment alg, DataGridViewRow currow)
		{
			try
			{
				currow.DefaultCellStyle.Font = new Font(lv.Font, FontStyle.Bold);
				currow.DefaultCellStyle.ForeColor = Color.Black;
			}
			catch (Exception ex)
			{
			}
			if (alg == HorizontalAlignment.Right)
			{
				currow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			}
			else if (alg == HorizontalAlignment.Center)
			{
				currow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
			else
			{
				currow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			}
			int num = 0;
			checked
			{
				int num2 = lv.Columns.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					currow.Cells[i].Value = mygroupname;
					currow.Cells[i].Tag = "水平合并";
				}
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00105D10 File Offset: 0x00103F10
		private static void CopyListViewItemToDGV(ListView lv, ListViewItem myitem, DataGridViewRow myrow)
		{
			string text = myitem.Text;
			if (lv.CheckBoxes)
			{
				if (myitem.Checked)
				{
					text = "■ " + text;
				}
				else
				{
					text = "□ " + text;
				}
			}
			myrow.Cells[0].Value = text;
			try
			{
				myrow.Cells[0].Style.Font = (Font)myitem.Font.Clone();
			}
			catch (Exception ex)
			{
			}
			myrow.Cells[0].Style.ForeColor = myitem.ForeColor;
			myrow.Cells[0].Style.BackColor = myitem.BackColor;
			try
			{
				myrow.DefaultCellStyle.Font = (Font)myitem.Font.Clone();
			}
			catch (Exception ex2)
			{
			}
			myrow.DefaultCellStyle.BackColor = myitem.BackColor;
			myrow.DefaultCellStyle.ForeColor = myitem.ForeColor;
			int num = 1;
			checked
			{
				int num2 = lv.Columns.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (i < myitem.SubItems.Count)
					{
						myrow.Cells[i].Value = myitem.SubItems[i].Text;
						if (!myitem.UseItemStyleForSubItems)
						{
							try
							{
								myrow.Cells[i].Style.Font = (Font)myitem.SubItems[i].Font.Clone();
								goto IL_199;
							}
							catch (Exception ex3)
							{
								goto IL_199;
							}
							goto IL_190;
							IL_199:
							myrow.Cells[i].Style.ForeColor = myitem.SubItems[i].ForeColor;
							myrow.Cells[i].Style.BackColor = myitem.SubItems[i].BackColor;
						}
					}
					IL_190:;
				}
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00105F30 File Offset: 0x00104130
		public static string SaveHashTableAsString(Hashtable hh)
		{
			string text = "\u0003";
			string text2 = "\a";
			checked
			{
				string result;
				if (hh == null)
				{
					string text3 = "";
					result = text3;
				}
				else
				{
					string[,] array = mbsjmodule.ParaseVar(hh);
					string text3 = "";
					if (array == null)
					{
						result = "";
					}
					else
					{
						int num = 0;
						int num2 = array.GetLength(0) - 1;
						for (int i = num; i <= num2; i++)
						{
							if (i == 0)
							{
								text3 = array[i, 0] + text2 + array[i, 1];
							}
							else
							{
								text3 = string.Concat(new string[]
								{
									text3,
									text,
									array[i, 0],
									text2,
									array[i, 1]
								});
							}
						}
						result = text3;
					}
				}
				return result;
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00105FF0 File Offset: 0x001041F0
		public static Hashtable RestoreHashTableFromString(string ss)
		{
			checked
			{
				Hashtable result;
				if (String.Compare(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					string delimiter = "\u0003";
					string delimiter2 = "\a";
					string[] array = Strings.Split(ss, delimiter, -1, CompareMethod.Binary);
					Hashtable hashtable = new Hashtable();
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						string[] array2 = Strings.Split(array[i], delimiter2, -1, CompareMethod.Binary);
						hashtable.Add(array2[0], array2[1]);
					}
					result = hashtable;
				}
				return result;
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00106064 File Offset: 0x00104264
		public static Font GetDGVHeaderFont(DataGridViewColumn mycolumn)
		{
			DataGridView dataGridView = mycolumn.DataGridView;
			Font font;
			if (mycolumn.HeaderCell.Style.Font != null)
			{
				font = mycolumn.HeaderCell.Style.Font;
			}
			else if (dataGridView.ColumnHeadersDefaultCellStyle.Font == null)
			{
				font = dataGridView.DefaultCellStyle.Font;
			}
			else
			{
				font = dataGridView.ColumnHeadersDefaultCellStyle.Font;
			}
			return font;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x001060CC File Offset: 0x001042CC
		public static Color GetDGVHeaderForeColor(DataGridViewColumn mycolumn)
		{
			DataGridView dataGridView = mycolumn.DataGridView;
			Color foreColor;
			if (mycolumn.HeaderCell.Style.ForeColor.ToArgb() == 0)
			{
				if (dataGridView.ColumnHeadersDefaultCellStyle.ForeColor.ToArgb() == 0)
				{
					foreColor = dataGridView.DefaultCellStyle.ForeColor;
				}
				else
				{
					foreColor = dataGridView.ColumnHeadersDefaultCellStyle.ForeColor;
				}
			}
			else
			{
				foreColor = mycolumn.HeaderCell.Style.ForeColor;
			}
			return foreColor;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00106144 File Offset: 0x00104344
		public static bool GetDGVHeaderMulline(DataGridViewColumn mycolumn)
		{
			DataGridView dataGridView = mycolumn.DataGridView;
			bool mulline;
			if (mycolumn.HeaderCell.Style.WrapMode == DataGridViewTriState.NotSet)
			{
				if (dataGridView.ColumnHeadersDefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
				{
					mulline = Module1.GetMulline(dataGridView.DefaultCellStyle.WrapMode);
				}
				else
				{
					mulline = Module1.GetMulline(dataGridView.ColumnHeadersDefaultCellStyle.WrapMode);
				}
			}
			else
			{
				mulline = Module1.GetMulline(mycolumn.HeaderCell.Style.WrapMode);
			}
			return mulline;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x001061BC File Offset: 0x001043BC
		public static Color GetDGVHeaderBackColor(DataGridViewColumn mycolumn)
		{
			DataGridView dataGridView = mycolumn.DataGridView;
			Color backColor;
			if (mycolumn.HeaderCell.Style.BackColor.ToArgb() == 0)
			{
				if (dataGridView.ColumnHeadersDefaultCellStyle.BackColor.ToArgb() == 0)
				{
					backColor = dataGridView.DefaultCellStyle.BackColor;
				}
				else
				{
					backColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
				}
			}
			else
			{
				backColor = mycolumn.HeaderCell.Style.BackColor;
			}
			return backColor;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00106234 File Offset: 0x00104434
		public static Font GetDGVCellFont(DataGridViewCell mycell)
		{
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			Font font;
			try
			{
				if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Font == null)
				{
					if (dataGridViewRow.DefaultCellStyle.Font == null)
					{
						if (checked(rowIndex + 1) % 2 == 0)
						{
							if (dataGridView.AlternatingRowsDefaultCellStyle.Font == null)
							{
								if (dataGridView.RowsDefaultCellStyle.Font == null)
								{
									if (dataGridViewColumn.DefaultCellStyle.Font == null)
									{
										font = dataGridView.DefaultCellStyle.Font;
									}
									else
									{
										font = dataGridViewColumn.DefaultCellStyle.Font;
									}
								}
								else
								{
									font = dataGridView.RowsDefaultCellStyle.Font;
								}
							}
							else
							{
								font = dataGridView.AlternatingRowsDefaultCellStyle.Font;
							}
						}
						else if (dataGridView.RowsDefaultCellStyle.Font == null)
						{
							if (dataGridViewColumn.DefaultCellStyle.Font == null)
							{
								font = dataGridView.DefaultCellStyle.Font;
							}
							else
							{
								font = dataGridViewColumn.DefaultCellStyle.Font;
							}
						}
						else
						{
							font = dataGridView.RowsDefaultCellStyle.Font;
						}
					}
					else
					{
						font = dataGridViewRow.DefaultCellStyle.Font;
					}
				}
				else
				{
					font = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Font;
				}
			}
			catch (Exception ex)
			{
				font = dataGridView.DefaultCellStyle.Font;
			}
			dataGridView = null;
			return font;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x001063D4 File Offset: 0x001045D4
		public static Color GetDGVCellForeColor(DataGridViewCell mycell)
		{
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			Color foreColor;
			if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.ForeColor.ToArgb() == 0)
			{
				if (dataGridViewRow.DefaultCellStyle.ForeColor.ToArgb() == 0)
				{
					if (checked(rowIndex + 1) % 2 == 0)
					{
						if (dataGridView.AlternatingRowsDefaultCellStyle.ForeColor.ToArgb() == 0)
						{
							if (dataGridView.RowsDefaultCellStyle.ForeColor.ToArgb() == 0)
							{
								if (dataGridViewColumn.DefaultCellStyle.ForeColor.ToArgb() == 0)
								{
									foreColor = dataGridView.DefaultCellStyle.ForeColor;
								}
								else
								{
									foreColor = dataGridViewColumn.DefaultCellStyle.ForeColor;
								}
							}
							else
							{
								foreColor = dataGridView.RowsDefaultCellStyle.ForeColor;
							}
						}
						else
						{
							foreColor = dataGridView.AlternatingRowsDefaultCellStyle.ForeColor;
						}
					}
					else if (dataGridView.RowsDefaultCellStyle.ForeColor.ToArgb() == 0)
					{
						if (dataGridViewColumn.DefaultCellStyle.ForeColor.ToArgb() == 0)
						{
							foreColor = dataGridView.DefaultCellStyle.ForeColor;
						}
						else
						{
							foreColor = dataGridViewColumn.DefaultCellStyle.ForeColor;
						}
					}
					else
					{
						foreColor = dataGridView.RowsDefaultCellStyle.ForeColor;
					}
				}
				else
				{
					foreColor = dataGridViewRow.DefaultCellStyle.ForeColor;
				}
			}
			else
			{
				foreColor = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.ForeColor;
			}
			return foreColor;
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00106588 File Offset: 0x00104788
		public static Color GetDGVCellBackColor(DataGridViewCell mycell)
		{
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			Color backColor;
			if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.BackColor.ToArgb() == 0)
			{
				if (dataGridViewRow.DefaultCellStyle.BackColor.ToArgb() == 0)
				{
					if (checked(rowIndex + 1) % 2 == 0)
					{
						if (dataGridView.AlternatingRowsDefaultCellStyle.BackColor.ToArgb() == 0)
						{
							if (dataGridView.RowsDefaultCellStyle.BackColor.ToArgb() == 0)
							{
								if (dataGridViewColumn.DefaultCellStyle.BackColor.ToArgb() == 0)
								{
									backColor = dataGridView.DefaultCellStyle.BackColor;
								}
								else
								{
									backColor = dataGridViewColumn.DefaultCellStyle.BackColor;
								}
							}
							else
							{
								backColor = dataGridView.RowsDefaultCellStyle.BackColor;
							}
						}
						else
						{
							backColor = dataGridView.AlternatingRowsDefaultCellStyle.BackColor;
						}
					}
					else if (dataGridView.RowsDefaultCellStyle.BackColor.ToArgb() == 0)
					{
						if (dataGridViewColumn.DefaultCellStyle.BackColor.ToArgb() == 0)
						{
							backColor = dataGridView.DefaultCellStyle.BackColor;
						}
						else
						{
							backColor = dataGridViewColumn.DefaultCellStyle.BackColor;
						}
					}
					else
					{
						backColor = dataGridView.RowsDefaultCellStyle.BackColor;
					}
				}
				else
				{
					backColor = dataGridViewRow.DefaultCellStyle.BackColor;
				}
			}
			else
			{
				backColor = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.BackColor;
			}
			return backColor;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0010673C File Offset: 0x0010493C
		public static bool GetDGVCellMulline(DataGridViewCell mycell)
		{
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			bool mulline;
			if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.WrapMode == DataGridViewTriState.NotSet)
			{
				if (dataGridViewRow.DefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
				{
					if (checked(rowIndex + 1) % 2 == 0)
					{
						if (dataGridView.AlternatingRowsDefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
						{
							if (dataGridView.RowsDefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
							{
								if (dataGridViewColumn.DefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
								{
									mulline = Module1.GetMulline(dataGridView.DefaultCellStyle.WrapMode);
								}
								else
								{
									mulline = Module1.GetMulline(dataGridViewColumn.DefaultCellStyle.WrapMode);
								}
							}
							else
							{
								mulline = Module1.GetMulline(dataGridView.RowsDefaultCellStyle.WrapMode);
							}
						}
						else
						{
							mulline = Module1.GetMulline(dataGridView.AlternatingRowsDefaultCellStyle.WrapMode);
						}
					}
					else if (dataGridView.RowsDefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
					{
						if (dataGridViewColumn.DefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
						{
							mulline = Module1.GetMulline(dataGridView.DefaultCellStyle.WrapMode);
						}
						else
						{
							mulline = Module1.GetMulline(dataGridViewColumn.DefaultCellStyle.WrapMode);
						}
					}
					else
					{
						mulline = Module1.GetMulline(dataGridView.RowsDefaultCellStyle.WrapMode);
					}
				}
				else
				{
					mulline = Module1.GetMulline(dataGridViewRow.DefaultCellStyle.WrapMode);
				}
			}
			else
			{
				mulline = Module1.GetMulline(dataGridViewRow.Cells[dataGridViewColumn.Index].Style.WrapMode);
			}
			return mulline;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x001068E0 File Offset: 0x00104AE0
		public static Margins GetDGVCellPadding(DataGridViewCell mycell)
		{
			Margins margins = new Margins();
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Padding.All == 0)
			{
				if (dataGridViewRow.DefaultCellStyle.Padding.All == 0)
				{
					if (checked(rowIndex + 1) % 2 == 0)
					{
						if (dataGridView.AlternatingRowsDefaultCellStyle.Padding.All == 0)
						{
							if (dataGridView.RowsDefaultCellStyle.Padding.All == 0)
							{
								if (dataGridViewColumn.DefaultCellStyle.Padding.All == 0)
								{
									margins.Left = dataGridView.DefaultCellStyle.Padding.Left;
									margins.Top = dataGridView.DefaultCellStyle.Padding.Top;
									margins.Right = dataGridView.DefaultCellStyle.Padding.Right;
									margins.Bottom = dataGridView.DefaultCellStyle.Padding.Bottom;
								}
								else
								{
									margins.Left = dataGridViewColumn.DefaultCellStyle.Padding.Left;
									margins.Top = dataGridViewColumn.DefaultCellStyle.Padding.Top;
									margins.Right = dataGridViewColumn.DefaultCellStyle.Padding.Right;
									margins.Bottom = dataGridViewColumn.DefaultCellStyle.Padding.Bottom;
								}
							}
							else
							{
								margins.Left = dataGridView.RowsDefaultCellStyle.Padding.Left;
								margins.Top = dataGridView.RowsDefaultCellStyle.Padding.Top;
								margins.Right = dataGridView.RowsDefaultCellStyle.Padding.Right;
								margins.Bottom = dataGridView.RowsDefaultCellStyle.Padding.Bottom;
							}
						}
						else
						{
							margins.Left = dataGridView.AlternatingRowsDefaultCellStyle.Padding.Left;
							margins.Top = dataGridView.AlternatingRowsDefaultCellStyle.Padding.Top;
							margins.Right = dataGridView.AlternatingRowsDefaultCellStyle.Padding.Right;
							margins.Bottom = dataGridView.AlternatingRowsDefaultCellStyle.Padding.Bottom;
						}
					}
					else if (dataGridView.RowsDefaultCellStyle.Padding.All == 0)
					{
						if (dataGridViewColumn.DefaultCellStyle.Padding.All == 0)
						{
							margins.Left = dataGridView.DefaultCellStyle.Padding.Left;
							margins.Top = dataGridView.DefaultCellStyle.Padding.Top;
							margins.Right = dataGridView.DefaultCellStyle.Padding.Right;
							margins.Bottom = dataGridView.DefaultCellStyle.Padding.Bottom;
						}
						else
						{
							margins.Left = dataGridViewColumn.DefaultCellStyle.Padding.Left;
							margins.Top = dataGridViewColumn.DefaultCellStyle.Padding.Top;
							margins.Right = dataGridViewColumn.DefaultCellStyle.Padding.Right;
							margins.Bottom = dataGridViewColumn.DefaultCellStyle.Padding.Bottom;
						}
					}
					else
					{
						margins.Left = dataGridView.RowsDefaultCellStyle.Padding.Left;
						margins.Top = dataGridView.RowsDefaultCellStyle.Padding.Top;
						margins.Right = dataGridView.RowsDefaultCellStyle.Padding.Right;
						margins.Bottom = dataGridView.RowsDefaultCellStyle.Padding.Bottom;
					}
				}
				else
				{
					margins.Left = dataGridViewRow.DefaultCellStyle.Padding.Left;
					margins.Top = dataGridViewRow.DefaultCellStyle.Padding.Top;
					margins.Right = dataGridViewRow.DefaultCellStyle.Padding.Right;
					margins.Bottom = dataGridViewRow.DefaultCellStyle.Padding.Bottom;
				}
			}
			else
			{
				margins.Left = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Padding.Left;
				margins.Top = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Padding.Top;
				margins.Right = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Padding.Right;
				margins.Bottom = dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Padding.Bottom;
			}
			return margins;
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00106E3C File Offset: 0x0010503C
		public static DataGridViewCellStyle GetDGVCellStyle(DataGridViewCell mycell)
		{
			DataGridView dataGridView = mycell.DataGridView;
			int rowIndex = mycell.RowIndex;
			DataGridViewRow dataGridViewRow = dataGridView.Rows[mycell.RowIndex];
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[mycell.ColumnIndex];
			DataGridViewCellStyle result;
			if (dataGridViewRow.Cells[dataGridViewColumn.Index].Style.Alignment == DataGridViewContentAlignment.NotSet)
			{
				if (dataGridViewRow.DefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
				{
					if (checked(rowIndex + 1) % 2 == 0)
					{
						if (dataGridView.AlternatingRowsDefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
						{
							if (dataGridView.RowsDefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
							{
								if (dataGridViewColumn.DefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
								{
									result = dataGridView.DefaultCellStyle;
								}
								else
								{
									result = dataGridViewColumn.DefaultCellStyle;
								}
							}
							else
							{
								result = dataGridView.RowsDefaultCellStyle;
							}
						}
						else
						{
							result = dataGridView.AlternatingRowsDefaultCellStyle;
						}
					}
					else if (dataGridView.RowsDefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
					{
						if (dataGridViewColumn.DefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
						{
							result = dataGridView.DefaultCellStyle;
						}
						else
						{
							result = dataGridViewColumn.DefaultCellStyle;
						}
					}
					else
					{
						result = dataGridView.RowsDefaultCellStyle;
					}
				}
				else
				{
					result = dataGridViewRow.DefaultCellStyle;
				}
			}
			else
			{
				result = dataGridViewRow.Cells[dataGridViewColumn.Index].Style;
			}
			return result;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00106F78 File Offset: 0x00105178
		public static StringAlignment GetHAlignment(DataGridViewContentAlignment mytt)
		{
			if (mytt != DataGridViewContentAlignment.BottomCenter)
			{
				if (mytt != DataGridViewContentAlignment.MiddleCenter)
				{
					if (mytt != DataGridViewContentAlignment.TopCenter)
					{
						if (mytt != DataGridViewContentAlignment.BottomLeft)
						{
							if (mytt != DataGridViewContentAlignment.MiddleLeft)
							{
								if (mytt != DataGridViewContentAlignment.NotSet)
								{
									if (mytt != DataGridViewContentAlignment.TopLeft)
									{
										if (mytt != DataGridViewContentAlignment.BottomRight)
										{
											if (mytt != DataGridViewContentAlignment.MiddleRight)
											{
												if (mytt != DataGridViewContentAlignment.TopRight)
												{
													return StringAlignment.Near;
												}
											}
										}
										return StringAlignment.Far;
									}
								}
							}
						}
						return StringAlignment.Near;
					}
				}
			}
			return StringAlignment.Center;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00106FDC File Offset: 0x001051DC
		public static StringAlignment GetVAlignment(DataGridViewContentAlignment mytt, bool IsDGVCellValignmentCenter)
		{
			StringAlignment result;
			if (IsDGVCellValignmentCenter)
			{
				result = StringAlignment.Center;
			}
			else
			{
				if (mytt != DataGridViewContentAlignment.BottomCenter)
				{
					if (mytt != DataGridViewContentAlignment.BottomLeft)
					{
						if (mytt != DataGridViewContentAlignment.BottomRight)
						{
							if (mytt != DataGridViewContentAlignment.MiddleCenter)
							{
								if (mytt != DataGridViewContentAlignment.MiddleLeft)
								{
									if (mytt != DataGridViewContentAlignment.MiddleRight)
									{
										if (mytt != DataGridViewContentAlignment.NotSet)
										{
											if (mytt != DataGridViewContentAlignment.TopCenter)
											{
												if (mytt != DataGridViewContentAlignment.TopLeft)
												{
													if (mytt != DataGridViewContentAlignment.TopRight)
													{
														return StringAlignment.Center;
													}
												}
											}
										}
										return StringAlignment.Near;
									}
								}
							}
							return StringAlignment.Center;
						}
					}
				}
				result = StringAlignment.Far;
			}
			return result;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00107048 File Offset: 0x00105248
		public static bool GetMulline(DataGridViewTriState mytt)
		{
			bool result;
			switch (mytt)
			{
			case DataGridViewTriState.NotSet:
			case DataGridViewTriState.False:
				result = false;
				break;
			default:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00107070 File Offset: 0x00105270
		public static Font GetDGVColumnHeaderFont(DataGridView dgv, string colname)
		{
			Font result;
			if (dgv == null)
			{
				result = null;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return null;
				}
				if (dataGridViewColumn == null)
				{
					result = null;
				}
				else
				{
					Font font;
					if (dataGridViewColumn.HeaderCell.Style.Font != null)
					{
						font = dataGridViewColumn.HeaderCell.Style.Font;
					}
					else if (dgv.ColumnHeadersDefaultCellStyle.Font == null)
					{
						font = dgv.DefaultCellStyle.Font;
					}
					else
					{
						font = dgv.ColumnHeadersDefaultCellStyle.Font;
					}
					result = font;
				}
			}
			return result;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0010710C File Offset: 0x0010530C
		public static Color GetDGVColumnHeaderForeColor(DataGridView dgv, string colname)
		{
			Color result;
			if (dgv == null)
			{
				result = Color.Black;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return Color.Black;
				}
				if (dataGridViewColumn == null)
				{
					result = Color.Black;
				}
				else
				{
					Color foreColor;
					if (dataGridViewColumn.HeaderCell.Style.ForeColor.ToArgb() == 0)
					{
						if (dgv.ColumnHeadersDefaultCellStyle.ForeColor.ToArgb() == 0)
						{
							foreColor = dgv.DefaultCellStyle.ForeColor;
						}
						else
						{
							foreColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor;
						}
					}
					else
					{
						foreColor = dataGridViewColumn.HeaderCell.Style.ForeColor;
					}
					result = foreColor;
				}
			}
			return result;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x001071C8 File Offset: 0x001053C8
		public static Color GetDGVColumnHeaderBackColor(DataGridView dgv, string colname)
		{
			Color result;
			if (dgv == null)
			{
				result = Color.White;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return Color.White;
				}
				if (dataGridViewColumn == null)
				{
					result = Color.White;
				}
				else
				{
					Color backColor;
					if (dataGridViewColumn.HeaderCell.Style.BackColor.ToArgb() == 0)
					{
						if (dgv.ColumnHeadersDefaultCellStyle.BackColor.ToArgb() == 0)
						{
							backColor = dgv.DefaultCellStyle.BackColor;
						}
						else
						{
							backColor = dgv.ColumnHeadersDefaultCellStyle.BackColor;
						}
					}
					else
					{
						backColor = dataGridViewColumn.HeaderCell.Style.BackColor;
					}
					result = backColor;
				}
			}
			return result;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00107284 File Offset: 0x00105484
		public static Font GetDGVColumnFont(DataGridView dgv, string colname)
		{
			Font result;
			if (dgv == null)
			{
				result = null;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return null;
				}
				if (dataGridViewColumn == null)
				{
					result = null;
				}
				else
				{
					Font font;
					if (dgv.RowsDefaultCellStyle.Font == null)
					{
						if (dataGridViewColumn.DefaultCellStyle.Font == null)
						{
							font = dgv.DefaultCellStyle.Font;
						}
						else
						{
							font = dataGridViewColumn.DefaultCellStyle.Font;
						}
					}
					else
					{
						font = dgv.RowsDefaultCellStyle.Font;
					}
					result = font;
				}
			}
			return result;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00107314 File Offset: 0x00105514
		public static Color GetDGVColumnForeColor(DataGridView dgv, string colname)
		{
			Color result;
			if (dgv == null)
			{
				result = Color.Black;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return Color.Black;
				}
				if (dataGridViewColumn == null)
				{
					result = Color.Black;
				}
				else
				{
					Color foreColor;
					if (dgv.RowsDefaultCellStyle.ForeColor.ToArgb() == 0)
					{
						if (dataGridViewColumn.DefaultCellStyle.ForeColor.ToArgb() == 0)
						{
							foreColor = dgv.DefaultCellStyle.ForeColor;
						}
						else
						{
							foreColor = dataGridViewColumn.DefaultCellStyle.ForeColor;
						}
					}
					else
					{
						foreColor = dgv.RowsDefaultCellStyle.ForeColor;
					}
					result = foreColor;
				}
			}
			return result;
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x001073C8 File Offset: 0x001055C8
		public static Color GetDGVColumnBackColor(DataGridView dgv, string colname)
		{
			Color result;
			if (dgv == null)
			{
				result = Color.Black;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return Color.Black;
				}
				if (dataGridViewColumn == null)
				{
					result = Color.Black;
				}
				else
				{
					Color backColor;
					if (dgv.RowsDefaultCellStyle.BackColor.ToArgb() == 0)
					{
						if (dataGridViewColumn.DefaultCellStyle.BackColor.ToArgb() == 0)
						{
							backColor = dgv.DefaultCellStyle.BackColor;
						}
						else
						{
							backColor = dataGridViewColumn.DefaultCellStyle.BackColor;
						}
					}
					else
					{
						backColor = dgv.RowsDefaultCellStyle.BackColor;
					}
					result = backColor;
				}
			}
			return result;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0010747C File Offset: 0x0010567C
		public static bool GetDGVColumnMulLine(DataGridView dgv, string colname)
		{
			bool result;
			if (dgv == null)
			{
				result = false;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return false;
				}
				if (dataGridViewColumn == null)
				{
					result = false;
				}
				else
				{
					bool mulline;
					if (dgv.RowsDefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
					{
						if (dataGridViewColumn.DefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)
						{
							mulline = Module1.GetMulline(dgv.DefaultCellStyle.WrapMode);
						}
						else
						{
							mulline = Module1.GetMulline(dataGridViewColumn.DefaultCellStyle.WrapMode);
						}
					}
					else
					{
						mulline = Module1.GetMulline(dgv.RowsDefaultCellStyle.WrapMode);
					}
					result = mulline;
				}
			}
			return result;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0010751C File Offset: 0x0010571C
		public static ContentAlignment GetDGVColumnAlignment(DataGridView dgv, string colname)
		{
			ContentAlignment result;
			if (dgv == null)
			{
				result = ContentAlignment.MiddleLeft;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewColumn = dgv.Columns[colname];
				}
				catch (Exception ex)
				{
					return ContentAlignment.MiddleLeft;
				}
				if (dataGridViewColumn == null)
				{
					result = ContentAlignment.MiddleLeft;
				}
				else
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					if (dgv.RowsDefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
					{
						if (dataGridViewColumn.DefaultCellStyle.Alignment == DataGridViewContentAlignment.NotSet)
						{
							dataGridViewCellStyle = dgv.DefaultCellStyle;
						}
						else
						{
							dataGridViewCellStyle = dataGridViewColumn.DefaultCellStyle;
						}
					}
					else
					{
						dataGridViewCellStyle = dgv.RowsDefaultCellStyle;
					}
					DataGridViewContentAlignment alignment = dataGridViewCellStyle.Alignment;
					if (alignment == DataGridViewContentAlignment.BottomCenter)
					{
						result = ContentAlignment.BottomCenter;
					}
					else if (alignment == DataGridViewContentAlignment.BottomLeft)
					{
						result = ContentAlignment.BottomLeft;
					}
					else if (alignment == DataGridViewContentAlignment.BottomRight)
					{
						result = ContentAlignment.BottomRight;
					}
					else if (alignment == DataGridViewContentAlignment.MiddleCenter)
					{
						result = ContentAlignment.MiddleCenter;
					}
					else if (alignment == DataGridViewContentAlignment.MiddleLeft)
					{
						result = ContentAlignment.MiddleLeft;
					}
					else if (alignment == DataGridViewContentAlignment.MiddleRight)
					{
						result = ContentAlignment.MiddleRight;
					}
					else if (alignment == DataGridViewContentAlignment.NotSet)
					{
						result = ContentAlignment.MiddleLeft;
					}
					else if (alignment == DataGridViewContentAlignment.TopCenter)
					{
						result = ContentAlignment.TopCenter;
					}
					else if (alignment == DataGridViewContentAlignment.TopLeft)
					{
						result = ContentAlignment.TopLeft;
					}
					else if (alignment == DataGridViewContentAlignment.TopRight)
					{
						result = ContentAlignment.TopRight;
					}
					else
					{
						result = ContentAlignment.MiddleLeft;
					}
				}
			}
			return result;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0010762C File Offset: 0x0010582C
		public static string EncryptionString(string ss)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(ss);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, new TripleDESCryptoServiceProvider
			{
				Key = Module1.G_mykey,
				IV = Module1.G_myiv
			}.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			string result = Convert.ToBase64String(memoryStream.ToArray());
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x001076A8 File Offset: 0x001058A8
		public static string DecryptionString(string ss)
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			tripleDESCryptoServiceProvider.Key = Module1.G_mykey;
			tripleDESCryptoServiceProvider.IV = Module1.G_myiv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
			byte[] array = Convert.FromBase64String(ss);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			string @string = Encoding.Unicode.GetString(memoryStream.ToArray());
			memoryStream.Dispose();
			return @string;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00107724 File Offset: 0x00105924
		public static Bitmap getDGVCheckBoxCellImage(DataGridViewCell dgvcell, Color mybkcolor)
		{
			Bitmap result;
			if (dgvcell == null)
			{
				result = null;
			}
			else
			{
				CheckBox checkBox = new CheckBox();
				Control control = checkBox;
				Size size = new Size(14, 14);
				control.Size = size;
				checkBox.BackColor = mybkcolor;
				if (dgvcell.FormattedValue != null)
				{
					if (String.Compare(Versioned.TypeName(RuntimeHelpers.GetObjectValue(dgvcell.FormattedValue)), "Boolean", false) == 0)
					{
						if (Convert.ToBoolean(dgvcell.FormattedValue))
						{
							checkBox.Checked = true;
						}
						else
						{
							checkBox.Checked = false;
						}
					}
					else
					{
						switch (Convert.ToInt32(dgvcell.FormattedValue))
						{
						case 0:
							checkBox.Checked = false;
							break;
						case 1:
							checkBox.Checked = true;
							break;
						default:
							checkBox.CheckState = CheckState.Indeterminate;
							break;
						}
					}
				}
				else
				{
					checkBox.Checked = false;
				}
				try
				{
					Bitmap bitmap = new Bitmap(14, 14);
					Graphics graphics = Graphics.FromImage(bitmap);
					Brush brush = new SolidBrush(mybkcolor);
					Graphics graphics2 = graphics;
					Brush brush2 = brush;
					Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
					graphics2.FillRectangle(brush2, rectangle);
					if (bitmap.Height < checkBox.Height)
					{
						checkBox.Height = bitmap.Height;
					}
					if (bitmap.Width < checkBox.Width)
					{
						checkBox.Width = bitmap.Width;
					}
					Control control2 = checkBox;
					Bitmap bitmap2 = bitmap;
					rectangle = checked(new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height));
					control2.DrawToBitmap(bitmap2, rectangle);
					graphics.Dispose();
					checkBox.Dispose();
					result = bitmap;
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x040010E2 RID: 4322
		public const string G_CustomDefinedPaperName = "[自定义纸张]";

		// Token: 0x040010E3 RID: 4323
		public static DataGridViewPrintSet myPrintset;

		// Token: 0x040010E4 RID: 4324
		public static showpreview myshowpreview;

		// Token: 0x040010E5 RID: 4325
		public static Ruler G_ruler = new Ruler();

		// Token: 0x040010E6 RID: 4326
		public static bool G_CancelDocument = false;

		// Token: 0x040010E7 RID: 4327
		public static bool G_CancelExportDGVToExcel = false;

		// Token: 0x040010E8 RID: 4328
		public static bool G_CancelPrint = false;

		// Token: 0x040010E9 RID: 4329
		private static byte[] G_mykey = new byte[]
		{
			10,
			32,
			53,
			24,
			53,
			23,
			88,
			223,
			99,
			10,
			33,
			62,
			64,
			76,
			68,
			98,
			13,
			131,
			93,
			33,
			15,
			56,
			13,
			13
		};

		// Token: 0x040010EA RID: 4330
		private static byte[] G_myiv = new byte[]
		{
			13,
			56,
			87,
			13,
			98,
			53,
			80,
			32
		};
	}
}
