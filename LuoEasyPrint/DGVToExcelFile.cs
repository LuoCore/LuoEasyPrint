using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000119 RID: 281
	[StandardModule]
	internal sealed class DGVToExcelFile
	{
		// Token: 0x06001CA2 RID: 7330 RVA: 0x000E17B8 File Offset: 0x000DF9B8
		private static int GetPielxs(DataGridView dgv, int width)
		{
			Graphics graphics = dgv.CreateGraphics();
			float width2 = graphics.MeasureString("8", new Font("宋体", 8f)).Width;
			graphics.Dispose();
			int num = 8;
			try
			{
				num = checked((int)Math.Round(Math.Ceiling((double)((float)width / width2))));
				if (num <= 0)
				{
					num = 1;
				}
				else if (num > 255)
				{
					num = 255;
				}
			}
			catch (Exception ex)
			{
			}
			return num;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x000E1844 File Offset: 0x000DFA44
		public static bool myNewDGVtoExcel(DataGridView mydgv, string filename, string title, string TableHeader, string TableFooter, bool isopenfile)
		{
			checked
			{
				bool result;
				if (mydgv == null)
				{
					result = false;
				}
				else
				{
					progressexcel progressexcel = new progressexcel();
					progressexcel.TopMost = true;
					progressexcel.Visible = true;
					Module1.G_CancelExportDGVToExcel = false;
					try
					{
						progressexcel.Label1.Text = "正在做导出前的准备，请稍侯……";
						Application.DoEvents();
						int columnCount = mydgv.ColumnCount;
						int[] array = new int[columnCount - 1 + 1];
						int[] array2 = new int[columnCount - 1 + 1];
						int num = 0;
						int num2 = 0;
						int num3 = columnCount - 1;
						for (int i = num2; i <= num3; i++)
						{
							array[i] = i;
							array2[i] = mydgv.Columns[i].DisplayIndex;
							if (mydgv.Columns[i].Visible)
							{
								num++;
							}
						}
						if (num <= 0)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							result = true;
						}
						else
						{
							Array.Sort<int, int>(array2, array);
							int[] array3 = new int[num - 1 + 1];
							int j = 0;
							int num4 = 0;
							int num5 = columnCount - 1;
							for (int i = num4; i <= num5; i++)
							{
								if (mydgv.Columns[array[i]].Visible)
								{
									array3[j] = array[i];
									j++;
								}
							}
							if (String.Compare(filename, "", false) == 0)
							{
								filename = MyProject.Computer.FileSystem.GetTempFileName();
								if (MyProject.Computer.FileSystem.FileExists(filename))
								{
									try
									{
										MyProject.Computer.FileSystem.DeleteFile(filename);
									}
									catch (Exception ex)
									{
									}
								}
								filename = MyProject.Computer.FileSystem.GetParentPath(filename) + "\\" + Strings.Replace(MyProject.Computer.FileSystem.GetName(filename), ".", "", 1, -1, CompareMethod.Binary) + ".xls";
							}
							else if (MyProject.Computer.FileSystem.FileExists(filename))
							{
								try
								{
									MyProject.Computer.FileSystem.DeleteFile(filename);
								}
								catch (Exception ex2)
								{
								}
							}
							newDGVtoExcel newDGVtoExcel = new newDGVtoExcel();
							if (newDGVtoExcel.CreateFile(filename) != 0)
							{
								progressexcel.Close();
								progressexcel.Dispose();
								Interaction.MsgBox("直接写Excel文件失败,导出数据到Excel文件失败", MsgBoxStyle.OkOnly, "提示信息");
								result = false;
							}
							else
							{
								int num6;
								if (String.Compare(title, "", false) == 0)
								{
									num6 = 1;
								}
								else
								{
									newDGVtoExcel newDGVtoExcel2 = newDGVtoExcel;
									newDGVtoExcel.ValueTypes valueTypes = newDGVtoExcel.ValueTypes.xlsText;
									newDGVtoExcel.CellFont cellFont = newDGVtoExcel.CellFont.xlsFont3;
									newDGVtoExcel.CellAlignment cellAlignment = newDGVtoExcel.CellAlignment.xlsLeftAlign;
									newDGVtoExcel.CellHiddenLocked cellHiddenLocked = newDGVtoExcel.CellHiddenLocked.xlsNormal;
									int num7 = 1;
									int num8 = 1;
									int num9 = 0;
									newDGVtoExcel2.WriteValue(ref valueTypes, ref cellFont, ref cellAlignment, ref cellHiddenLocked, ref num7, ref num8, title, ref num9);
									num6 = 2;
								}
								if (String.Compare(TableHeader, "", false) != 0)
								{
									newDGVtoExcel newDGVtoExcel3 = newDGVtoExcel;
									newDGVtoExcel.ValueTypes valueTypes = newDGVtoExcel.ValueTypes.xlsText;
									newDGVtoExcel.CellFont cellFont = newDGVtoExcel.CellFont.xlsFont2;
									newDGVtoExcel.CellAlignment cellAlignment = newDGVtoExcel.CellAlignment.xlsLeftAlign;
									newDGVtoExcel.CellHiddenLocked cellHiddenLocked = newDGVtoExcel.CellHiddenLocked.xlsNormal;
									int num9 = 2;
									int num8 = 1;
									int num7 = 0;
									newDGVtoExcel3.WriteValue(ref valueTypes, ref cellFont, ref cellAlignment, ref cellHiddenLocked, ref num9, ref num8, TableHeader, ref num7);
									num6++;
								}
								if (mydgv.ColumnHeadersVisible)
								{
									int num10 = 0;
									int num11 = num - 1;
									for (int i = num10; i <= num11; i++)
									{
										newDGVtoExcel newDGVtoExcel4 = newDGVtoExcel;
										newDGVtoExcel.ValueTypes valueTypes = newDGVtoExcel.ValueTypes.xlsText;
										newDGVtoExcel.CellAlignment cellAlignment = (newDGVtoExcel.CellAlignment)122;
										int num9 = i + 1;
										newDGVtoExcel4.WriteValue(ref valueTypes, ref cellAlignment, ref num6, ref num9, mydgv.Columns[array3[i]].HeaderText);
										newDGVtoExcel newDGVtoExcel5 = newDGVtoExcel;
										byte b = (byte)(i + 1);
										byte b2 = (byte)(i + 1);
										short num12 = (short)DGVToExcelFile.GetPielxs(mydgv, mydgv.Columns[array3[i]].Width);
										newDGVtoExcel5.SetColumnWidth(ref b, ref b2, ref num12);
									}
									num6++;
								}
								progressexcel.ProgressBar1.Maximum = mydgv.RowCount;
								int num13 = 0;
								int num14 = mydgv.RowCount - 1;
								for (int i = num13; i <= num14; i++)
								{
									progressexcel.Label1.Text = string.Concat(new string[]
									{
										"正在导出第〖",
										Convert.ToString(i + 1),
										"〗条记录，共〖",
										Convert.ToString(mydgv.RowCount),
										"〗条记录，已完成〖",
										Strings.Format((double)(i + 1) / (double)mydgv.RowCount, "###.##%"),
										"〗"
									});
									progressexcel.ProgressBar1.Value = i + 1;
									Application.DoEvents();
									if (Module1.G_CancelExportDGVToExcel)
									{
										break;
									}
									int num15 = 0;
									int num16 = num - 1;
									j = num15;
									while (j <= num16)
									{
										newDGVtoExcel.ValueTypes valueTypes2 = newDGVtoExcel.ValueTypes.xlsText;
										newDGVtoExcel.CellAlignment cellAlignment2 = (newDGVtoExcel.CellAlignment)120;
										if (mydgv.Columns[array3[j]].ValueType != null)
										{
											string left = Strings.Left(mydgv.Columns[array3[j]].ValueType.Name.ToUpper(), 3);
											if (String.Compare(left, "STR", false) != 0)
											{
												if (String.Compare(left, "INT", false) == 0)
												{
													valueTypes2 = newDGVtoExcel.ValueTypes.xlsInteger;
												}
												else if (String.Compare(left, "DEC", false) == 0)
												{
													valueTypes2 = newDGVtoExcel.ValueTypes.xlsNumber;
												}
											}
										}
										DataGridViewContentAlignment alignment = mydgv.Columns[array3[j]].DefaultCellStyle.Alignment;
										if (alignment == DataGridViewContentAlignment.BottomCenter)
										{
											goto IL_4F1;
										}
										if (alignment == DataGridViewContentAlignment.MiddleCenter)
										{
											goto IL_4F1;
										}
										if (alignment == DataGridViewContentAlignment.TopCenter)
										{
											goto IL_4F1;
										}
										if (alignment != DataGridViewContentAlignment.BottomLeft)
										{
											if (alignment != DataGridViewContentAlignment.MiddleLeft)
											{
												if (alignment != DataGridViewContentAlignment.TopLeft)
												{
													if (alignment != DataGridViewContentAlignment.BottomRight)
													{
														if (alignment != DataGridViewContentAlignment.MiddleRight)
														{
															if (alignment != DataGridViewContentAlignment.TopRight)
															{
																goto IL_4F7;
															}
														}
													}
													cellAlignment2 |= newDGVtoExcel.CellAlignment.xlsRightAlign;
													goto IL_4F7;
												}
											}
										}
										cellAlignment2 |= newDGVtoExcel.CellAlignment.xlsLeftAlign;
										IL_4F7:
										if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewImageColumn", false) == 0)
										{
											newDGVtoExcel newDGVtoExcel6 = newDGVtoExcel;
											int num9 = num6 + i;
											int num8 = j + 1;
											newDGVtoExcel6.WriteValue(ref valueTypes2, ref num9, ref num8, "暂不支持图片列导出");
										}
										else if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewCheckBoxColumn", false) == 0)
										{
											if (mydgv.Rows[i].Cells[array3[j]].Value != null)
											{
												if (DataTypeConversion.ToBoolean(mydgv.Rows[i].Cells[array3[j]].FormattedValue))
												{
													valueTypes2 = newDGVtoExcel.ValueTypes.xlsText;
													newDGVtoExcel newDGVtoExcel7 = newDGVtoExcel;
													int num9 = num6 + i;
													int num8 = j + 1;
													newDGVtoExcel7.WriteValue(ref valueTypes2, ref num9, ref num8, "√");
												}
												else
												{
													valueTypes2 = newDGVtoExcel.ValueTypes.xlsText;
													newDGVtoExcel newDGVtoExcel8 = newDGVtoExcel;
													int num9 = num6 + i;
													int num8 = j + 1;
													newDGVtoExcel8.WriteValue(ref valueTypes2, ref num9, ref num8, "");
												}
											}
										}
										else
										{
											string text = Convert.ToString(mydgv.Rows[i].Cells[array3[j]].FormattedValue) + "";
											if (DataTypeConversion.IsNumeric(text) && Convert.ToDouble(text) > 99999999999.0)
											{
												valueTypes2 = newDGVtoExcel.ValueTypes.xlsText;
											}
											if (valueTypes2 != newDGVtoExcel.ValueTypes.xlsText)
											{
												if (!DataTypeConversion.IsNumeric(text))
												{
													valueTypes2 = newDGVtoExcel.ValueTypes.xlsText;
												}
											}
											newDGVtoExcel newDGVtoExcel9 = newDGVtoExcel;
											int num9 = num6 + i;
											int num8 = j + 1;
											newDGVtoExcel9.WriteValue(ref valueTypes2, ref num9, ref num8, text);
										}
										j++;
										continue;
										IL_4F1:
										cellAlignment2 |= newDGVtoExcel.CellAlignment.xlsCentreAlign;
										goto IL_4F7;
									}
								}
								if (String.Compare(TableFooter, "", false) != 0)
								{
									newDGVtoExcel newDGVtoExcel10 = newDGVtoExcel;
									newDGVtoExcel.ValueTypes valueTypes = newDGVtoExcel.ValueTypes.xlsText;
									newDGVtoExcel.CellFont cellFont = newDGVtoExcel.CellFont.xlsFont2;
									newDGVtoExcel.CellAlignment cellAlignment = newDGVtoExcel.CellAlignment.xlsLeftAlign;
									newDGVtoExcel.CellHiddenLocked cellHiddenLocked = newDGVtoExcel.CellHiddenLocked.xlsNormal;
									int num9 = mydgv.RowCount + num6;
									int num8 = 1;
									int num7 = 0;
									newDGVtoExcel10.WriteValue(ref valueTypes, ref cellFont, ref cellAlignment, ref cellHiddenLocked, ref num9, ref num8, TableFooter, ref num7);
								}
								newDGVtoExcel.CloseFile();
								progressexcel.Close();
								progressexcel.Dispose();
								if (isopenfile && Interaction.MsgBox("导出的Excel文件已保存到【" + filename + " 】\r\n您是否要立即打开这个文件以查看其内容?", MsgBoxStyle.YesNoCancel, "提示信息") == MsgBoxResult.Yes)
								{
									try
									{
										Process.Start(filename);
									}
									catch (Exception ex3)
									{
									}
								}
								result = true;
							}
						}
					}
					catch (Exception ex4)
					{
						progressexcel.Close();
						progressexcel.Dispose();
						Interaction.MsgBox("导出Excel文件时失败，对程序员有用的错误提示是：" + ex4.Message, MsgBoxStyle.OkOnly, "提示信息");
						result = false;
					}
				}
				return result;
			}
		}
	}
}
