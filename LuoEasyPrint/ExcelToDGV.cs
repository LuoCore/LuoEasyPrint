using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace LuoEasyPrint
{
	// Token: 0x0200011C RID: 284
	[StandardModule]
	internal sealed class ExcelToDGV
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x000E63D8 File Offset: 0x000E45D8
		public static bool ImportExcelToDGV(string filename, DataGridView dgv, bool replaceRowHeaderRow, bool isaddmode)
		{
			if (String.Compare(filename, "", false) == 0)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "请选择要导入的Excel文件";
				openFileDialog.AddExtension = true;
				openFileDialog.DefaultExt = "xls";
				openFileDialog.Filter = "97-2003 Excel文件(*.xls)|*.xls|所有文件(*.*)|*.*";
				openFileDialog.FileName = "";
				if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				{
					openFileDialog.Dispose();
					return false;
				}
				filename = openFileDialog.FileName;
				openFileDialog.Dispose();
			}
			checked
			{
				bool result;
				if (!MyProject.Computer.FileSystem.FileExists(filename))
				{
					Interaction.MsgBox("文件【" + filename + "】未找到，导入失败", MsgBoxStyle.Exclamation, "提示信息");
					result = false;
				}
				else if (dgv == null)
				{
					Interaction.MsgBox("传入的DataGridView对象为空，导入失败", MsgBoxStyle.Exclamation, "提示信息");
					result = false;
				}
				else
				{
					progressexcel progressexcel = new progressexcel();
					Module1.G_CancelExportDGVToExcel = false;
					progressexcel.TopMost = true;
					progressexcel.Visible = true;
					try
					{
						progressexcel.Label1.Text = "正在做导入前的准备，请稍侯……";
						progressexcel.Button1.Text = "取消导入";
						progressexcel.Text = "导入Excel到DataGridView中";
						progressexcel.ProgressBar1.Value = 0;
						Application.DoEvents();
						FileStream fileStream;
						try
						{
							fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
						}
						catch (Exception ex)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							Interaction.MsgBox("打开Excel文件〖" + filename + "〗失败，该文件可能正被其他程序打开，请关闭打开该文件的程序后再试。", MsgBoxStyle.Exclamation, "提示信息");
							fileStream = null;
							return false;
						}
						HSSFWorkbook hssfworkbook;
						try
						{
							hssfworkbook = new HSSFWorkbook(fileStream);
						}
						catch (Exception ex2)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							fileStream.Dispose();
							fileStream = null;
							Interaction.MsgBox("打开Excel文件〖" + filename + "〗失败，可能不是有效的Office97-2003 Excel文件格式", MsgBoxStyle.Exclamation, "提示信息");
							hssfworkbook = null;
							return false;
						}
						int numberOfSheets = hssfworkbook.NumberOfSheets;
						if (numberOfSheets <= 0)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							fileStream.Dispose();
							fileStream = null;
							Interaction.MsgBox("Excel文件〖" + filename + "〗中没有可导入的数据", MsgBoxStyle.Exclamation, "提示信息");
							hssfworkbook = null;
							return false;
						}
						ISheet sheet;
						if (numberOfSheets > 1)
						{
							progressexcel.Visible = false;
							ChooseExcelSheet chooseExcelSheet = new ChooseExcelSheet();
							int num = 0;
							int num2 = numberOfSheets - 1;
							for (int i = num; i <= num2; i++)
							{
								chooseExcelSheet.ComboBox1.Items.Add(hssfworkbook.GetSheetName(i));
							}
							chooseExcelSheet.ComboBox1.Text = hssfworkbook.GetSheetName(0);
							if (chooseExcelSheet.ShowDialog() != DialogResult.OK)
							{
								progressexcel.Close();
								progressexcel.Dispose();
								fileStream.Dispose();
								fileStream = null;
								hssfworkbook = null;
								return false;
							}
							progressexcel.Visible = true;
							sheet = hssfworkbook.GetSheet(chooseExcelSheet.ComboBox1.Text);
							chooseExcelSheet.Dispose();
						}
						else
						{
							sheet = hssfworkbook.GetSheetAt(0);
						}
						if (sheet == null)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							fileStream.Dispose();
							fileStream = null;
							hssfworkbook = null;
							Interaction.MsgBox("Excel文件〖" + filename + "〗中不含任何工作表，导入失败", MsgBoxStyle.Exclamation, "提示信息");
							return false;
						}
						IRow row = sheet.GetRow(sheet.FirstRowNum);
						int num3 = (int)row.LastCellNum;
						int lastRowNum = sheet.LastRowNum;
						if (!isaddmode)
						{
							dgv.RowCount = 0;
							if (replaceRowHeaderRow)
							{
								dgv.ColumnCount = num3;
							}
						}
						int columnCount = dgv.ColumnCount;
						int[] array = new int[columnCount - 1 + 1];
						int[] array2 = new int[columnCount - 1 + 1];
						int num4 = 0;
						int num5 = 0;
						int num6 = columnCount - 1;
						for (int j = num5; j <= num6; j++)
						{
							array[j] = j;
							array2[j] = dgv.Columns[j].DisplayIndex;
							if (dgv.Columns[j].Visible)
							{
								num4++;
							}
						}
						if (num4 <= 0)
						{
							progressexcel.Close();
							progressexcel.Dispose();
							return false;
						}
						Array.Sort<int, int>(array2, array);
						int[] array3 = new int[num4 - 1 + 1];
						int k = 0;
						int num7 = 0;
						int num8 = columnCount - 1;
						for (int j = num7; j <= num8; j++)
						{
							if (dgv.Columns[array[j]].Visible)
							{
								array3[k] = array[j];
								k++;
							}
						}
						progressexcel.ProgressBar1.Maximum = lastRowNum;
						if (replaceRowHeaderRow)
						{
							IRow row2 = sheet.GetRow(sheet.FirstRowNum);
							num3 = Math.Min((int)row2.LastCellNum, num4);
							int firstCellNum = (int)row2.FirstCellNum;
							int num9 = num3 - 1;
							for (k = firstCellNum; k <= num9; k++)
							{
								dgv.Columns[array3[k]].HeaderText = row2.GetCell(k).ToString();
							}
						}
						int num10 = sheet.FirstRowNum + 1;
						int num11 = lastRowNum;
						for (int j = num10; j <= num11; j++)
						{
							progressexcel.Label1.Text = string.Concat(new string[]
							{
								"正在导入第〖",
								Convert.ToString(j + 1),
								"〗条记录，共〖",
								Convert.ToString(lastRowNum),
								"〗条记录，已完成〖",
								Strings.Format((double)j / (double)lastRowNum, "##0.##%"),
								"〗"
							});
							progressexcel.ProgressBar1.Value = j;
							Application.DoEvents();
							if (Module1.G_CancelExportDGVToExcel)
							{
								hssfworkbook = null;
								progressexcel.Close();
								progressexcel.Dispose();
								fileStream.Dispose();
								fileStream = null;
								IL_5D2:
								hssfworkbook = null;
								progressexcel.Close();
								progressexcel.Dispose();
								if (fileStream != null)
								{
									fileStream.Dispose();
									fileStream = null;
								}
								return true;
							}
							dgv.RowCount++;
							IRow row2 = sheet.GetRow(j);
							if (row2 != null)
							{
								num3 = Math.Min((int)row2.LastCellNum, num4);
								int firstCellNum2 = (int)row2.FirstCellNum;
								int num12 = num3 - 1;
								for (k = firstCellNum2; k <= num12; k++)
								{
									if (row2.GetCell(k) != null)
									{
										dgv.Rows[dgv.RowCount - 1].Cells[array3[k]].Value = row2.GetCell(k).ToString();
									}
								}
							}
						}
					}
					catch (Exception ex3)
					{
						progressexcel.Close();
						progressexcel.Dispose();
						FileStream fileStream = null;
					}
					result = false;
				}
				return result;
			}
		}
	}
}
