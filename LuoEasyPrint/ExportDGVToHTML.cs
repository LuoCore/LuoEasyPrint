using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000136 RID: 310
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExportDataGridViewToHTML : IDisposable
	{
		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000A20B File Offset: 0x0000840B
		public void ExportDGVToHTML(DataGridView dgv, string title, Font titlefont)
		{
			this.ExportDGVToHTML(dgv, title, titlefont, "", true);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0000A21C File Offset: 0x0000841C
		public void ExportDGVToHTML(DataGridView dgv, string title, Font titlefont, string filename, bool isshowprogress = true)
		{
			this.ExportDGVToHTML(dgv, null, title, titlefont, filename, isshowprogress);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000E7DD8 File Offset: 0x000E5FD8
		public void ExportDGVToHTML(DataGridView dgv, TreeView tv, string title, Font titlefont)
		{
			this.ExportDGVToHTML(dgv, tv, title, titlefont, null, "", null, "", "", true);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000E7E04 File Offset: 0x000E6004
		public void ExportDGVToHTML(DataGridView dgv, TreeView tv, string title, Font titlefont, string filename, bool isshowprogress = true)
		{
			this.ExportDGVToHTML(dgv, tv, title, titlefont, null, "", null, "", filename, isshowprogress);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000E7E2C File Offset: 0x000E602C
		public void ExportDGVToHTML(DataGridView dgv, TreeView tv, string title, Font titlefont, Font tableheaderfont, string tableheader, Font tablefooterfont, string tablefooter, string filename, bool isshowprogress = true)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0)
				{
					progressexcel progressexcel = null;
					if (isshowprogress)
					{
						progressexcel = new progressexcel();
						progressexcel.Text = "导出HTML（网页）文件";
						progressexcel.TopMost = true;
						progressexcel.Visible = true;
						Module1.G_CancelExportDGVToExcel = false;
						progressexcel.Label1.Text = "正在做导出前的准备，请稍侯……";
						Application.DoEvents();
					}
					if (this.mystream != null)
					{
						this.mystream.Dispose();
						this.mystream = null;
					}
					this.mystream = new StreamWriter(filename, false, Encoding.UTF8);
					this.mystream.WriteLine("<html>");
					this.mystream.WriteLine("<head><title>" + title + "</title></head>");
					this.mystream.WriteLine("<body>");
					if (titlefont == null)
					{
						titlefont = new Font("黑体", 18f, FontStyle.Bold);
					}
					if (title != null && String.Compare(title, "", false) != 0)
					{
						this.mystream.WriteLine("<p align=\"center\"><center>");
						this.WriteStartFont(titlefont);
						this.mystream.WriteLine(this.MyReplace(title));
						this.WriteEndFont(titlefont);
						this.mystream.WriteLine("</center></p>");
					}
					if (String.Compare(tableheader, "", false) != 0)
					{
						if (tableheaderfont == null)
						{
							tableheaderfont = new Font("宋体", 12f);
						}
						this.mystream.WriteLine("<p align=\"center\">");
						this.WriteStartFont(tableheaderfont);
						this.mystream.WriteLine(this.MyReplace(tableheader));
						this.WriteEndFont(tableheaderfont);
						this.mystream.WriteLine("</p>");
					}
					Module1.G_CancelExportDGVToExcel = false;
					this.mystream.WriteLine("<table border=\"1\" cellspacing=\"0\"  align=\"center\">");
					if (isshowprogress)
					{
						progressexcel.ProgressBar1.Maximum = dgv.RowCount;
						progressexcel.Label1.Text = "正导出表头，请稍侯……";
						Application.DoEvents();
					}
					if (dgv.ColumnHeadersVisible)
					{
						this.AddHead(dgv, tv);
					}
					int num = 0;
					int num2 = dgv.RowCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (isshowprogress)
						{
							progressexcel.Label1.Text = string.Concat(new string[]
							{
								"正在导出第〖",
								Convert.ToString(i + 1),
								"〗条记录，共〖",
								Convert.ToString(dgv.RowCount),
								"〗条记录，已完成〖",
								Strings.Format((double)(i + 1) / (double)dgv.RowCount, "###.##%"),
								"〗"
							});
							progressexcel.ProgressBar1.Value = i + 1;
							Application.DoEvents();
							if (Module1.G_CancelExportDGVToExcel)
							{
								break;
							}
						}
						if (dgv.Rows[i].Visible)
						{
							this.mystream.Write("<tr>");
							this.AddRow(dgv, i);
							this.mystream.WriteLine("</tr>");
						}
					}
					if (isshowprogress)
					{
						progressexcel.Close();
						progressexcel.Dispose();
					}
					this.mystream.WriteLine("</table>");
					if (String.Compare(tablefooter, "", false) != 0)
					{
						if (tablefooterfont == null)
						{
							tablefooterfont = new Font("宋体", 12f);
						}
						this.mystream.WriteLine("<p align=\"center\">");
						this.WriteStartFont(tablefooterfont);
						this.mystream.WriteLine(this.MyReplace(tablefooter));
						this.WriteEndFont(tablefooterfont);
						this.mystream.WriteLine("</p>");
					}
					this.mystream.WriteLine("</body></html>");
					this.mystream.Flush();
					this.mystream.Close();
				}
			}
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000E81AC File Offset: 0x000E63AC
		private void WriteStartFont(Font ff)
		{
			if (ff != null)
			{
				this.mystream.WriteLine(string.Concat(new string[]
				{
					"<font  style=\"font-family:",
					ff.Name,
					"; font-size:",
					Convert.ToString(ff.Size),
					"\"px>"
				}));
				if (ff.Bold)
				{
					this.mystream.WriteLine("<b>");
				}
				if (ff.Italic)
				{
					this.mystream.WriteLine("<i>");
				}
				if (ff.Underline)
				{
					this.mystream.WriteLine("<u>");
				}
				if (ff.Strikeout)
				{
					this.mystream.WriteLine("<del>");
				}
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000E8268 File Offset: 0x000E6468
		private void WriteEndFont(Font ff)
		{
			if (ff != null)
			{
				if (ff.Strikeout)
				{
					this.mystream.WriteLine("</del>");
				}
				if (ff.Underline)
				{
					this.mystream.WriteLine("</u>");
				}
				if (ff.Italic)
				{
					this.mystream.WriteLine("</i>");
				}
				if (ff.Bold)
				{
					this.mystream.WriteLine("</b>");
				}
				this.mystream.WriteLine("</font>");
			}
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000E82E8 File Offset: 0x000E64E8
		private string MyReplace(string ss)
		{
			return Strings.Replace(ss, "\r\n", "<br/>", 1, -1, CompareMethod.Binary);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000E830C File Offset: 0x000E650C
		private void AddHead(DataGridView dgv)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0)
				{
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
						array2[i] = dgv.Columns[i].DisplayIndex;
					}
					Array.Sort<int, int>(array2, array);
					int num3 = 0;
					int num4 = dgv.ColumnCount - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (dgv.Columns[array[j]].Visible)
						{
							int width = dgv.Columns[array[j]].Width;
							Font dgvheaderFont = Module1.GetDGVHeaderFont(dgv.Columns[array[j]]);
							Color dgvheaderForeColor = Module1.GetDGVHeaderForeColor(dgv.Columns[array[j]]);
							Color dgvheaderBackColor = Module1.GetDGVHeaderBackColor(dgv.Columns[array[j]]);
							string text = "<td width=\"" + Convert.ToString(width) + "\"";
							text = text + " height=\"" + Convert.ToString(dgv.ColumnHeadersHeight) + "\"";
							text += "  valign=\"middle\"";
							text += "  align=\"center\"";
							text = text + " style=\"background:#" + this.ConvertColorToHTML(dgvheaderBackColor) + "\"";
							text += ">";
							text = text + "<font color=\"#" + this.ConvertColorToHTML(dgvheaderForeColor) + "\">";
							this.mystream.WriteLine(text);
							this.WriteStartFont(dgvheaderFont);
							text = this.MyReplace(dgv.Columns[array[j]].HeaderText);
							this.mystream.WriteLine(text);
							this.WriteEndFont(dgvheaderFont);
							this.mystream.WriteLine("</font></td>");
						}
					}
				}
			}
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000E8500 File Offset: 0x000E6700
		private void AddHead(DataGridView dgv, TreeView tv)
		{
			checked
			{
				if (dgv != null)
				{
					if (tv == null)
					{
						this.mystream.WriteLine("<tr align=center>");
						this.AddHead(dgv);
						this.mystream.WriteLine("</tr>");
					}
					else
					{
						float[] array = new float[dgv.ColumnCount - 1 + 1];
						int num = 0;
						int num2 = dgv.ColumnCount - 1;
						for (int i = num; i <= num2; i++)
						{
							array[i] = (float)dgv.Columns[i].Width;
						}
						mytree mytree = new mytree(tv, dgv, array);
						int leves = mytree.GetLeves();
						if (mytree.GetColumns() != dgv.ColumnCount)
						{
							this.mystream.WriteLine("<tr align=center>");
							this.AddHead(dgv);
							this.mystream.WriteLine("</tr>");
						}
						else
						{
							int num3 = 1;
							int num4 = leves;
							for (int j = num3; j <= num4; j++)
							{
								this.mystream.WriteLine("<tr align=center>");
								this.AddHead(dgv, mytree, j);
								this.mystream.WriteLine("</tr>");
							}
						}
						mytree.Dispose();
					}
				}
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000E860C File Offset: 0x000E680C
		private void AddHead(DataGridView dgv, mytree myheader, int curlevel)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0)
				{
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
						array2[i] = dgv.Columns[i].DisplayIndex;
					}
					Array.Sort<int, int>(array2, array);
					int value = (int)Math.Round((double)dgv.ColumnHeadersHeight / (double)myheader.GetLeves());
					int num3 = 0;
					int num4 = dgv.ColumnCount - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (dgv.Columns[array[j]].Visible)
						{
							int cellHeightLevels = myheader.GetCellHeightLevels(array[j], curlevel);
							int cellWidthCols = myheader.GetCellWidthCols(array[j], curlevel);
							if (cellHeightLevels == 0 | cellWidthCols == 0)
							{
								if (cellHeightLevels == 0)
								{
								}
							}
							else
							{
								string text = myheader.GetNodeText(array[j], curlevel);
								text = this.MyReplace(text);
								Font font = myheader.GetNodeFont(array[j], curlevel);
								if (font == null)
								{
									font = Module1.GetDGVHeaderFont(dgv.Columns[array[j]]);
								}
								Color cc = myheader.GetNodeForeColor(array[j], curlevel);
								if (cc.IsEmpty)
								{
									cc = Module1.GetDGVHeaderForeColor(dgv.Columns[array[j]]);
								}
								Color cc2 = myheader.GetNodeBackColor(array[j], curlevel);
								if (cc2.IsEmpty)
								{
									cc2 = Module1.GetDGVHeaderBackColor(dgv.Columns[array[j]]);
								}
								int value2;
								if (cellWidthCols == 1 & cellHeightLevels == 1)
								{
									value2 = dgv.Columns[array[j]].Width;
								}
								else
								{
									value2 = (int)Math.Round((double)myheader.GetCellWidth2(array[j], curlevel));
								}
								string text2 = "<td width=\"" + Convert.ToString(value2) + "\"";
								text2 = text2 + " height=\"" + Convert.ToString(value) + "\"";
								text2 += "  valign=\"middle\"";
								text2 += "  align=\"center\"";
								text2 = text2 + " style=\"background:#" + this.ConvertColorToHTML(cc2) + "\"";
								if (cellWidthCols != 0)
								{
									text2 = text2 + " colspan=\"" + Convert.ToString(cellWidthCols) + "\"";
								}
								if (cellHeightLevels != 0)
								{
									text2 = text2 + "  rowspan=\"" + Convert.ToString(cellHeightLevels) + "\"";
								}
								text2 += ">";
								text2 = text2 + "<font color=\"#" + this.ConvertColorToHTML(cc) + "\">";
								this.mystream.WriteLine(text2);
								this.WriteStartFont(font);
								this.mystream.WriteLine(text);
								this.WriteEndFont(font);
								this.mystream.WriteLine("</font></td>");
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000E88F0 File Offset: 0x000E6AF0
		private void AddRow(DataGridView dgv, int rowindex)
		{
			checked
			{
				if (dgv != null && rowindex < dgv.RowCount && dgv.ColumnCount > 0 && dgv.RowCount > 0 && dgv.Rows[rowindex].Visible)
				{
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
						array2[i] = dgv.Columns[i].DisplayIndex;
					}
					Array.Sort<int, int>(array2, array);
					int height = dgv.Rows[rowindex].Height;
					int num3 = 1;
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					int num7 = 0;
					int num8 = 1;
					int num9 = 0;
					int num10 = dgv.ColumnCount - 1;
					for (int j = num9; j <= num10; j++)
					{
						if (dgv.Columns[array[j]].Visible)
						{
							num8 = 1;
							num3 = 1;
							num6 = 0;
							num4 = 0;
							num7 = 0;
							num6 = 0;
							num4 = 0;
							num5 = 0;
							string left = Convert.ToString(dgv.Rows[rowindex].Cells[array[j]].Tag);
							int value;
							int num14=0;
							int num16=0;
							if (String.Compare(left, "垂直合并", false) != 0)
							{
								if (String.Compare(left, "#垂直合并#", false) != 0)
								{
									if (String.Compare(left, "上合并", false) != 0)
									{
										if (String.Compare(left, "下合并", false) != 0)
										{
											int num13=0;
											int num15=0;
											if (String.Compare(left, "水平合并", false) != 0)
											{
												if (String.Compare(left, "#水平合并#", false) != 0)
												{
													if (String.Compare(left, "左合并", false) != 0)
													{
														if (String.Compare(left, "右合并", false) != 0)
														{
															if (String.Compare(left, "合并", false) != 0)
															{
																if (String.Compare(left, "左上合并", false) != 0)
																{
																	if (String.Compare(left, "左下合并", false) != 0)
																	{
																		if (String.Compare(left, "右上合并", false) != 0)
																		{
																			if (String.Compare(left, "右下合并", false) != 0)
																			{
																				if (String.Compare(left, "上边合并", false) != 0)
																				{
																					if (String.Compare(left, "下边合并", false) != 0)
																					{
																						if (String.Compare(left, "左边合并", false) != 0)
																						{
																							if (String.Compare(left, "右边合并", false) != 0)
																							{
																								num8 = 1;
																								num3 = 1;
																								value = dgv.Columns[array[j]].Width;
																								goto IL_389;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
															float num11=0;
															float num12=0;
															mymerge.GetHVMergeWidthAndHeight(dgv, array[j], rowindex, ref num11, ref num12, ref num7, ref num6, ref num4, ref num5, ref num13, ref num14, ref num15, ref num16);
															num8 = num6 + num7 + 1;
															num3 = num4 + num5 + 1;
															value = (int)Math.Round((double)num11);
															if (num3 > 1 & num8 > 1)
															{
																if (num4 == 0 & num6 == 0)
																{
																	goto IL_389;
																}
																if (num6 == 0)
																{
																	goto IL_7C5;
																}
																goto IL_7C5;
															}
															else if (num3 > 1)
															{
																if (num4 == 0)
																{
																	goto IL_389;
																}
																goto IL_7C5;
															}
															else
															{
																if (num8 <= 1)
																{
																	goto IL_389;
																}
																if (num6 == 0)
																{
																	goto IL_389;
																}
																goto IL_7C5;
															}
														}
													}
												}
											}
											value = (int)Math.Round((double)mymerge.GetHMergeWidth(dgv, array[j], rowindex, ref num8, ref num6, ref num7, ref num13, ref num15, true));
											if (num8 <= 1)
											{
												goto IL_389;
											}
											if (num6 == 0)
											{
												goto IL_389;
											}
											goto IL_7C5;
										}
									}
								}
							}
							mymerge.GetVMergeHeight(dgv, array[j], rowindex, ref num3, ref num5, ref num4, ref num14, ref num16);
							value = dgv.Columns[array[j]].Width;
							if (num3 > 1 && num4 != 0)
							{
								goto IL_7C5;
							}
							IL_389:
							string text = "<td width=\"" + Convert.ToString(value) + "\"";
							text = text + " height=\"" + Convert.ToString(height) + "\"";
							DataGridViewContentAlignment alignment = Module1.GetDGVCellStyle(dgv.Rows[rowindex].Cells[array[j]]).Alignment;
							if (alignment == DataGridViewContentAlignment.BottomCenter)
							{
								goto IL_43E;
							}
							if (alignment == DataGridViewContentAlignment.BottomLeft)
							{
								goto IL_43E;
							}
							if (alignment == DataGridViewContentAlignment.BottomRight)
							{
								goto IL_43E;
							}
							if (alignment != DataGridViewContentAlignment.MiddleCenter)
							{
								if (alignment != DataGridViewContentAlignment.MiddleLeft)
								{
									if (alignment != DataGridViewContentAlignment.MiddleRight)
									{
										if (alignment != DataGridViewContentAlignment.NotSet)
										{
											text += "  valign=\"top\"";
											goto IL_44C;
										}
									}
								}
							}
							text += "  valign=\"middle\"";
							IL_44C:
							DataGridViewContentAlignment alignment2 = Module1.GetDGVCellStyle(dgv.Rows[rowindex].Cells[array[j]]).Alignment;
							if (alignment2 == DataGridViewContentAlignment.BottomLeft)
							{
								goto IL_4CA;
							}
							if (alignment2 == DataGridViewContentAlignment.MiddleLeft)
							{
								goto IL_4CA;
							}
							if (alignment2 == DataGridViewContentAlignment.TopLeft)
							{
								goto IL_4CA;
							}
							if (alignment2 == DataGridViewContentAlignment.NotSet)
							{
								goto IL_4CA;
							}
							if (alignment2 != DataGridViewContentAlignment.BottomCenter)
							{
								if (alignment2 != DataGridViewContentAlignment.MiddleCenter)
								{
									if (alignment2 != DataGridViewContentAlignment.TopCenter)
									{
										text += "  align=\"right\"";
										goto IL_4D8;
									}
								}
							}
							text += "  align=\"center\"";
							IL_4D8:
							Font dgvcellFont = Module1.GetDGVCellFont(dgv.Rows[rowindex].Cells[array[j]]);
							Color dgvcellBackColor = Module1.GetDGVCellBackColor(dgv.Rows[rowindex].Cells[array[j]]);
							Color dgvcellForeColor = Module1.GetDGVCellForeColor(dgv.Rows[rowindex].Cells[array[j]]);
							text = text + " style=\"background:#" + this.ConvertColorToHTML(dgvcellBackColor) + "\"";
							text = string.Concat(new string[]
							{
								text,
								" colspan=\"",
								Convert.ToString(num8),
								"\"  rowspan=\"",
								Convert.ToString(num3),
								"\""
							});
							text += ">";
							text = text + "<font color=\"#" + this.ConvertColorToHTML(dgvcellForeColor) + "\">";
							this.mystream.WriteLine(text);
							text = "";
							this.WriteStartFont(dgvcellFont);
							if (dgv.Columns[array[j]] is DataGridViewImageColumn)
							{
								if (dgv.Rows[rowindex].Cells[array[j]].Value != null && dgv.Rows[rowindex].Cells[array[j]].FormattedValue != null)
								{
									text = string.Concat(new string[]
									{
										text,
										"<img height=\"",
										Convert.ToString(height),
										"\" width=\"",
										Convert.ToString(value),
										"\""
									});
									text = text + "src=\"data:image/png;base64," + Module1.ConvertImageToString((Image)dgv.Rows[rowindex].Cells[array[j]].FormattedValue);
									text += "\"/>";
								}
							}
							else if (dgv.Columns[array[j]] is DataGridViewCheckBoxColumn)
							{
								if (dgv.Rows[rowindex].Cells[array[j]].FormattedValue == null)
								{
									text += "  <input  type=\"checkbox\"   />";
								}
								else if (DataTypeConversion.ToBoolean(dgv.Rows[rowindex].Cells[array[j]].FormattedValue))
								{
									text += "  <input  type=\"checkbox\"  checked />";
								}
								else
								{
									text += "  <input  type=\"checkbox\"   />";
								}
							}
							else
							{
								text += this.MyReplace(Convert.ToString(dgv.Rows[rowindex].Cells[array[j]].FormattedValue));
							}
							this.mystream.WriteLine(text);
							this.WriteEndFont(dgvcellFont);
							this.mystream.WriteLine("</font></td>");
							goto IL_7C5;
							IL_4CA:
							text += "  align=\"left\"";
							goto IL_4D8;
							IL_43E:
							text += "  valign=\"bottom\"";
							goto IL_44C;
						}
						IL_7C5:;
					}
				}
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000E90D4 File Offset: 0x000E72D4
		private string ConvertColorToHTML(Color cc)
		{
			string text = (cc.ToArgb() & 16777215).ToString("X2");
			while (text.Length < 6)
			{
				text = "0" + text;
			}
			return text;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0000A22C File Offset: 0x0000842C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing && this.mystream != null)
			{
				this.mystream.Dispose();
				this.mystream = null;
			}
			this.disposedValue = true;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0000A25A File Offset: 0x0000845A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000EAB RID: 3755
		private StreamWriter mystream;

		// Token: 0x04000EAC RID: 3756
		private bool disposedValue;
	}
}
