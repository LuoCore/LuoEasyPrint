using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200011D RID: 285
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class newDGVtoExcel
	{
		// Token: 0x06001CCE RID: 7374
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void RtlMoveMemory([MarshalAs(UnmanagedType.AnsiBStr)] ref string lpvDest, ref short lpvSource, int cbCopy);

		// Token: 0x170008DC RID: 2268
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x000E6A44 File Offset: 0x000E4C44
		public bool PrintGridLines
		{
			[MethodImpl(MethodImplOptions.NoOptimization)]
			set
			{
				try
				{
					newDGVtoExcel.PRINT_GRIDLINES_RECORD print_GRIDLINES_RECORD;
					print_GRIDLINES_RECORD.opcode = 43;
					print_GRIDLINES_RECORD.length = 2;
					if (value)
					{
						print_GRIDLINES_RECORD.PrintFlag = 1;
					}
					else
					{
						print_GRIDLINES_RECORD.PrintFlag = 0;
					}
					FileSystem.FilePut(this.m_shtFileNumber, print_GRIDLINES_RECORD, -1L);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x170008DD RID: 2269
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x000E6AB4 File Offset: 0x000E4CB4
		public bool ProtectSpreadsheet
		{
			[MethodImpl(MethodImplOptions.NoOptimization)]
			set
			{
				try
				{
					newDGVtoExcel.PROTECT_SPREADSHEET_RECORD protect_SPREADSHEET_RECORD;
					protect_SPREADSHEET_RECORD.opcode = 18;
					protect_SPREADSHEET_RECORD.length = 2;
					if (value)
					{
						protect_SPREADSHEET_RECORD.Protect = 1;
					}
					else
					{
						protect_SPREADSHEET_RECORD.Protect = 0;
					}
					FileSystem.FilePut(this.m_shtFileNumber, protect_SPREADSHEET_RECORD, -1L);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000E6B24 File Offset: 0x000E4D24
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int CreateFile(string strFileName)
		{
			int result;
			try
			{
				if (File.Exists(strFileName))
				{
					File.SetAttributes(strFileName, FileAttributes.Normal);
					File.Delete(strFileName);
				}
				this.m_shtFileNumber = FileSystem.FreeFile();
				FileSystem.FileOpen(this.m_shtFileNumber, strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
				FileSystem.FilePut(this.m_shtFileNumber, this.m_udtBEG_FILE_MARKER, -1L);
				this.WriteDefaultFormats();
				this.m_shtHorizPageBreakRows = new short[1];
				this.m_shtNumHorizPageBreaks = 0;
				result = 0;
			}
			catch (Exception ex)
			{
				result = Information.Err().Number;
			}
			return result;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000E6BD0 File Offset: 0x000E4DD0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int CloseFile()
		{
			int result;
			try
			{
				if (this.m_shtFileNumber > 0)
				{
					if (this.m_shtNumHorizPageBreaks > 0)
					{
						int num = Information.UBound(this.m_shtHorizPageBreakRows, 1);
						int num2 = Information.LBound(this.m_shtHorizPageBreakRows, 1);
						short num6;
						short num7;
						checked
						{
							for (int i = num; i >= num2; i += -1)
							{
								int num3 = Information.LBound(this.m_shtHorizPageBreakRows, 1) + 1;
								int num4 = i;
								for (int j = num3; j <= num4; j++)
								{
									if (this.m_shtHorizPageBreakRows[j - 1] > this.m_shtHorizPageBreakRows[j])
									{
										int num5 = (int)this.m_shtHorizPageBreakRows[j - 1];
										this.m_shtHorizPageBreakRows[j - 1] = this.m_shtHorizPageBreakRows[j];
										this.m_shtHorizPageBreakRows[j] = (short)num5;
									}
								}
							}
							this.m_udtHORIZ_PAGE_BREAK.opcode = 27;
							this.m_udtHORIZ_PAGE_BREAK.length =Convert.ToInt16(2 + this.m_shtNumHorizPageBreaks * 2);
							this.m_udtHORIZ_PAGE_BREAK.NumPageBreaks = this.m_shtNumHorizPageBreaks;
							FileSystem.FilePut(this.m_shtFileNumber, this.m_udtHORIZ_PAGE_BREAK, -1L);
							num6 = 1;
							num7 = (short)Information.UBound(this.m_shtHorizPageBreakRows, 1);
						}
						for (short num8 = num6; num8 <= num7; num8 += 1)
						{
							FileSystem.FilePut(this.m_shtFileNumber, newDGVtoExcel.MKI(ref this.m_shtHorizPageBreakRows[(int)num8]), -1L, false);
						}
					}
					FileSystem.FilePut(this.m_shtFileNumber, this.m_udtEND_FILE_MARKER, -1L);
					FileSystem.FileClose(new int[]
					{
						this.m_shtFileNumber
					});
					result = 0;
				}
				else
				{
					result = -1;
				}
			}
			catch (Exception ex)
			{
				result = Information.Err().Number;
			}
			return result;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000E6D84 File Offset: 0x000E4F84
		private void Init()
		{
			this.m_udtBEG_FILE_MARKER.opcode = 9;
			this.m_udtBEG_FILE_MARKER.length = 4;
			this.m_udtBEG_FILE_MARKER.version = 2;
			this.m_udtBEG_FILE_MARKER.ftype = 10;
			this.m_udtEND_FILE_MARKER.opcode = 10;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000A179 File Offset: 0x00008379
		public newDGVtoExcel()
		{
			this.Init();
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000E6DD0 File Offset: 0x000E4FD0
		public int InsertHorizPageBreak(ref int lrow)
		{
			checked
			{
				int result;
				try
				{
					short num;
					if (lrow > 32767)
					{
						num = (short)(lrow - 65536);
					}
					else
					{
						num = (short)(lrow - 1);
					}
					this.m_shtNumHorizPageBreaks += 1;
					this.m_shtHorizPageBreakRows = (short[])Utils.CopyArray((Array)this.m_shtHorizPageBreakRows, new short[(int)(this.m_shtNumHorizPageBreaks + 1)]);
					this.m_shtHorizPageBreakRows[(int)this.m_shtNumHorizPageBreaks] = num;
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000E6E6C File Offset: 0x000E506C
		public int WriteValue(ref newDGVtoExcel.ValueTypes ValueType, ref int lrow, ref int lcol, object Value)
		{
			newDGVtoExcel.CellFont cellFont = newDGVtoExcel.CellFont.xlsFont0;
			newDGVtoExcel.CellAlignment cellAlignment = (newDGVtoExcel.CellAlignment)120;
			newDGVtoExcel.CellHiddenLocked cellHiddenLocked = newDGVtoExcel.CellHiddenLocked.xlsNormal;
			object objectValue = RuntimeHelpers.GetObjectValue(Value);
			int num = 0;
			return this.WriteValue(ref ValueType, ref cellFont, ref cellAlignment, ref cellHiddenLocked, ref lrow, ref lcol, objectValue, ref num);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000E6EA0 File Offset: 0x000E50A0
		public int WriteValue(ref newDGVtoExcel.ValueTypes ValueType, ref newDGVtoExcel.CellAlignment Alignment, ref int lrow, ref int lcol, object Value)
		{
			newDGVtoExcel.CellFont cellFont = newDGVtoExcel.CellFont.xlsFont0;
			newDGVtoExcel.CellHiddenLocked cellHiddenLocked = newDGVtoExcel.CellHiddenLocked.xlsNormal;
			object objectValue = RuntimeHelpers.GetObjectValue(Value);
			int num = 0;
			return this.WriteValue(ref ValueType, ref cellFont, ref Alignment, ref cellHiddenLocked, ref lrow, ref lcol, objectValue, ref num);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000E6ED0 File Offset: 0x000E50D0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int WriteValue(ref newDGVtoExcel.ValueTypes ValueType, ref newDGVtoExcel.CellFont CellFontUsed, ref newDGVtoExcel.CellAlignment Alignment, ref newDGVtoExcel.CellHiddenLocked HiddenLocked, ref int lrow, ref int lcol, object Value, ref int CellFormat)
		{
			checked
			{
				int result=0;
				try
				{
					short row=0;
					if (lrow > 32768)
					{
						row = (short)(lrow - 65536 - 1);
					}
					else
					{
						row = (short)(lrow - 1);
					}
					short col;
					if (lcol > 32768)
					{
						col = (short)(lcol - 65536 - 1);
					}
					else
					{
						col = (short)(lcol - 1);
					}
					switch (ValueType)
					{
					case newDGVtoExcel.ValueTypes.xlsInteger:
					{
						newDGVtoExcel.tInteger tInteger;
						tInteger.opcode = 2;
						tInteger.length = 9;
						tInteger.row = row;
						tInteger.col = col;
						tInteger.rgbAttr1 = (byte)HiddenLocked;
						tInteger.rgbAttr2 = (byte)(CellFontUsed + CellFormat);
						tInteger.rgbAttr3 = (byte)Alignment;
						tInteger.intValue = Convert.ToInt16(Value);
						FileSystem.FilePut(this.m_shtFileNumber, tInteger, -1L);
						break;
					}
					case newDGVtoExcel.ValueTypes.xlsNumber:
					{
						newDGVtoExcel.tNumber tNumber;
						tNumber.opcode = 3;
						tNumber.length = 15;
						tNumber.row = row;
						tNumber.col = col;
						tNumber.rgbAttr1 = (byte)HiddenLocked;
						tNumber.rgbAttr2 = (byte)(CellFontUsed + CellFormat);
						tNumber.rgbAttr3 = (byte)Alignment;
						tNumber.NumberValue = Convert.ToDouble(Value);
						FileSystem.FilePut(this.m_shtFileNumber, tNumber, -1L);
						break;
					}
					case newDGVtoExcel.ValueTypes.xlsText:
					{
						string text = Convert.ToString(Value);
						short num = (short)newDGVtoExcel.GetLength(text);
						newDGVtoExcel.tText tText;
						tText.opcode = 4;
						tText.length = 10;
						tText.TextLength = (byte)num;
						tText.length = Convert.ToInt16(8 + num);
						tText.row = row;
						tText.col = col;
						tText.rgbAttr1 = (byte)HiddenLocked;
						tText.rgbAttr2 = (byte)(CellFontUsed + CellFormat);
						tText.rgbAttr3 = (byte)Alignment;
						FileSystem.FilePut(this.m_shtFileNumber, tText, -1L);
						FileSystem.FilePut(this.m_shtFileNumber, text, -1L, false);
						break;
					}
					}
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000E70F0 File Offset: 0x000E52F0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetMargin(ref newDGVtoExcel.MarginTypes Margin, ref double MarginValue)
		{
			int result;
			try
			{
				newDGVtoExcel.MARGIN_RECORD_LAYOUT margin_RECORD_LAYOUT;
				margin_RECORD_LAYOUT.opcode = checked((short)Margin);
				margin_RECORD_LAYOUT.length = 8;
				margin_RECORD_LAYOUT.MarginValue = MarginValue;
				FileSystem.FilePut(this.m_shtFileNumber, margin_RECORD_LAYOUT, -1L);
				result = 0;
			}
			catch (Exception ex)
			{
				result = Information.Err().Number;
			}
			return result;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000E7160 File Offset: 0x000E5360
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetColumnWidth(ref byte FirstColumn, ref byte LastColumn, ref short WidthValue)
		{
			checked
			{
				int result;
				try
				{
					newDGVtoExcel.COLWIDTH_RECORD colwidth_RECORD;
					colwidth_RECORD.opcode = 36;
					colwidth_RECORD.length = 4;
					colwidth_RECORD.col1 = Convert.ToByte(FirstColumn - 1);
					colwidth_RECORD.col2 =Convert.ToByte(LastColumn - 1);
					colwidth_RECORD.ColumnWidth =Convert.ToInt16(WidthValue * 256);
					FileSystem.FilePut(this.m_shtFileNumber, colwidth_RECORD, -1L);
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000E71F0 File Offset: 0x000E53F0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public short SetFont(ref string FontName, ref short FontHeight, ref newDGVtoExcel.FontFormatting FontFormat)
		{
			checked
			{
				short result;
				try
				{
					short num = (short)newDGVtoExcel.GetLength(FontName);
					newDGVtoExcel.FONT_RECORD font_RECORD;
					font_RECORD.opcode = 49;
					font_RECORD.length =Convert.ToInt16(5 + num);
					font_RECORD.FontHeight = Convert.ToInt16(FontHeight * 20);
					font_RECORD.FontAttributes1 = (byte)FontFormat;
					font_RECORD.FontAttributes2 = 0;
					font_RECORD.FontNameLength = (byte)num;
					FileSystem.FilePut(this.m_shtFileNumber, font_RECORD, -1L);
					FileSystem.FilePut(this.m_shtFileNumber, FontName, -1L, false);
					result = 0;
				}
				catch (Exception ex)
				{
					result = (short)Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000E72A4 File Offset: 0x000E54A4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetHeader(ref string HeaderText)
		{
			checked
			{
				int result;
				try
				{
					short num = (short)newDGVtoExcel.GetLength(HeaderText);
					newDGVtoExcel.HEADER_FOOTER_RECORD header_FOOTER_RECORD;
					header_FOOTER_RECORD.opcode = 20;
					header_FOOTER_RECORD.length = Convert.ToInt16(1 + num);
					header_FOOTER_RECORD.TextLength = (byte)num;
					FileSystem.FilePut(this.m_shtFileNumber, header_FOOTER_RECORD, -1L);
					FileSystem.FilePut(this.m_shtFileNumber, HeaderText, -1L, false);
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000E7338 File Offset: 0x000E5538
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetFooter(ref string FooterText)
		{
			checked
			{
				int result;
				try
				{
					short num = (short)newDGVtoExcel.GetLength(FooterText);
					newDGVtoExcel.HEADER_FOOTER_RECORD header_FOOTER_RECORD;
					header_FOOTER_RECORD.opcode = 21;
					header_FOOTER_RECORD.length = Convert.ToInt16(1 + num);
					header_FOOTER_RECORD.TextLength = (byte)num;
					FileSystem.FilePut(this.m_shtFileNumber, header_FOOTER_RECORD, -1L);
					FileSystem.FilePut(this.m_shtFileNumber, FooterText, -1L, false);
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000E73CC File Offset: 0x000E55CC
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetFilePassword(ref string PasswordText)
		{
			int result;
			try
			{
				short length = checked((short)newDGVtoExcel.GetLength(PasswordText));
				newDGVtoExcel.PASSWORD_RECORD password_RECORD;
				password_RECORD.opcode = 47;
				password_RECORD.length = length;
				FileSystem.FilePut(this.m_shtFileNumber, password_RECORD, -1L);
				FileSystem.FilePut(this.m_shtFileNumber, PasswordText, -1L, false);
				result = 0;
			}
			catch (Exception ex)
			{
				result = Information.Err().Number;
			}
			return result;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000E7454 File Offset: 0x000E5654
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void WriteDefaultFormats()
		{
			string[] array = new string[24];
			string text = "\"";
			array[0] = "General";
			array[1] = "0";
			array[2] = "0.00";
			array[3] = "#,##0";
			array[4] = "#,##0.00";
			array[5] = string.Concat(new string[]
			{
				"#,##0/ ",
				text,
				"$",
				text,
				";/-#,##0/ ",
				text,
				"$",
				text
			});
			array[6] = string.Concat(new string[]
			{
				"#,##0/ ",
				text,
				"$",
				text,
				";[Red]/-#,##0/ ",
				text,
				"$",
				text
			});
			array[7] = string.Concat(new string[]
			{
				"#,##0.00/ ",
				text,
				"$",
				text,
				";/-#,##0.00/ ",
				text,
				"$",
				text
			});
			array[8] = string.Concat(new string[]
			{
				"#,##0.00/ ",
				text,
				"$",
				text,
				";[Red]/-#,##0.00/ ",
				text,
				"$",
				text
			});
			array[9] = "0%";
			array[10] = "0.00%";
			array[11] = "0.00E+00";
			array[12] = "dd/mm/yy";
			array[13] = "dd// mmm/ yy";
			array[14] = "dd// mmm";
			array[15] = "mmm/ yy";
			array[16] = "h:mm/ AM/PM";
			array[17] = "h:mm:ss/ AM/PM";
			array[18] = "hh:mm";
			array[19] = "hh:mm:ss";
			array[20] = "dd/mm/yy/ hh:mm";
			array[21] = "##0.0E+0";
			array[22] = "mm:ss";
			array[23] = "@";
			newDGVtoExcel.FORMAT_COUNT_RECORD format_COUNT_RECORD;
			format_COUNT_RECORD.opcode = 31;
			format_COUNT_RECORD.length = 2;
			checked
			{
				format_COUNT_RECORD.Count = (short)Information.UBound(array, 1);
				FileSystem.FilePut(this.m_shtFileNumber, format_COUNT_RECORD, -1L);
				int num = Information.LBound(array, 1);
				int num2 = Information.UBound(array, 1);
				for (int i = num; i <= num2; i++)
				{
					int num3 = Strings.Len(array[i]);
					newDGVtoExcel.FORMAT_RECORD format_RECORD;
					format_RECORD.opcode = 30;
					format_RECORD.length = (short)(num3 + 1);
					format_RECORD.FormatLenght = (byte)num3;
					FileSystem.FilePut(this.m_shtFileNumber, format_RECORD, -1L);
					int num4 = 1;
					int num5 = num3;
					for (int j = num4; j <= num5; j++)
					{
						byte value = (byte)Strings.Asc(Strings.Mid(array[i], j, 1));
						FileSystem.FilePut(this.m_shtFileNumber, value, -1L);
					}
				}
			}
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000E7734 File Offset: 0x000E5934
		private static string MKI(ref short x)
		{
			string result = Strings.Space(2);
			newDGVtoExcel.RtlMoveMemory(ref result, ref x, 2);
			return result;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000E7754 File Offset: 0x000E5954
		private static int GetLength(string strText)
		{
			return Encoding.Default.GetBytes(strText).Length;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000E7770 File Offset: 0x000E5970
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetDefaultRowHeight(int HeightValue)
		{
			int result;
			try
			{
				newDGVtoExcel.DEF_ROWHEIGHT_RECORD def_ROWHEIGHT_RECORD;
				def_ROWHEIGHT_RECORD.opcode = 37;
				def_ROWHEIGHT_RECORD.length = 2;
				def_ROWHEIGHT_RECORD.RowHeight = checked(HeightValue * 20);
				FileSystem.FilePut(this.m_shtFileNumber, def_ROWHEIGHT_RECORD, -1L);
				result = 0;
			}
			catch (Exception ex)
			{
				result = Information.Err().Number;
			}
			return result;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x000E77E4 File Offset: 0x000E59E4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public int SetRowHeight(int Row, short HeightValue)
		{
			checked
			{
				int result;
				try
				{
					int rowNumber;
					if (Row > 32767)
					{
						rowNumber = Row - 65536;
					}
					else
					{
						rowNumber = Row - 1;
					}
					newDGVtoExcel.ROW_HEIGHT_RECORD row_HEIGHT_RECORD;
					row_HEIGHT_RECORD.opcode = 8;
					row_HEIGHT_RECORD.length = 16;
					row_HEIGHT_RECORD.RowNumber = rowNumber;
					row_HEIGHT_RECORD.FirstColumn = 0;
					row_HEIGHT_RECORD.LastColumn = 256;
					row_HEIGHT_RECORD.RowHeight = (int)(HeightValue * 20);
					row_HEIGHT_RECORD.@internal = 0;
					row_HEIGHT_RECORD.DefaultAttributes = 0;
					row_HEIGHT_RECORD.FileOffset = 0;
					row_HEIGHT_RECORD.rgbAttr1 = 0;
					row_HEIGHT_RECORD.rgbAttr2 = 0;
					row_HEIGHT_RECORD.rgbAttr3 = 0;
					FileSystem.FilePut(this.m_shtFileNumber, row_HEIGHT_RECORD, -1L);
					result = 0;
				}
				catch (Exception ex)
				{
					result = Information.Err().Number;
				}
				return result;
			}
		}

		// Token: 0x04000E2C RID: 3628
		private int m_shtFileNumber;

		// Token: 0x04000E2D RID: 3629
		private newDGVtoExcel.BEG_FILE_RECORD m_udtBEG_FILE_MARKER;

		// Token: 0x04000E2E RID: 3630
		private newDGVtoExcel.END_FILE_RECORD m_udtEND_FILE_MARKER;

		// Token: 0x04000E2F RID: 3631
		private newDGVtoExcel.HPAGE_BREAK_RECORD m_udtHORIZ_PAGE_BREAK;

		// Token: 0x04000E30 RID: 3632
		private short[] m_shtHorizPageBreakRows;

		// Token: 0x04000E31 RID: 3633
		private short m_shtNumHorizPageBreaks;

		// Token: 0x0200011E RID: 286
		public enum ValueTypes
		{
			// Token: 0x04000E33 RID: 3635
			xlsInteger,
			// Token: 0x04000E34 RID: 3636
			xlsNumber,
			// Token: 0x04000E35 RID: 3637
			xlsText
		}

		// Token: 0x0200011F RID: 287
		public enum CellAlignment
		{
			// Token: 0x04000E37 RID: 3639
			xlsGeneralAlign,
			// Token: 0x04000E38 RID: 3640
			xlsLeftAlign,
			// Token: 0x04000E39 RID: 3641
			xlsCentreAlign,
			// Token: 0x04000E3A RID: 3642
			xlsRightAlign,
			// Token: 0x04000E3B RID: 3643
			xlsFillCell,
			// Token: 0x04000E3C RID: 3644
			xlsLeftBorder = 8,
			// Token: 0x04000E3D RID: 3645
			xlsRightBorder = 16,
			// Token: 0x04000E3E RID: 3646
			xlsTopBorder = 32,
			// Token: 0x04000E3F RID: 3647
			xlsBottomBorder = 64,
			// Token: 0x04000E40 RID: 3648
			xlsShaded = 128
		}

		// Token: 0x02000120 RID: 288
		public enum CellFont
		{
			// Token: 0x04000E42 RID: 3650
			xlsFont0,
			// Token: 0x04000E43 RID: 3651
			xlsFont1 = 64,
			// Token: 0x04000E44 RID: 3652
			xlsFont2 = 128,
			// Token: 0x04000E45 RID: 3653
			xlsFont3 = 192
		}

		// Token: 0x02000121 RID: 289
		public enum CellHiddenLocked
		{
			// Token: 0x04000E47 RID: 3655
			xlsNormal,
			// Token: 0x04000E48 RID: 3656
			xlsLocked = 64,
			// Token: 0x04000E49 RID: 3657
			xlsHidden = 128
		}

		// Token: 0x02000122 RID: 290
		public enum MarginTypes
		{
			// Token: 0x04000E4B RID: 3659
			xlsLeftMargin = 38,
			// Token: 0x04000E4C RID: 3660
			xlsRightMargin,
			// Token: 0x04000E4D RID: 3661
			xlsTopMargin,
			// Token: 0x04000E4E RID: 3662
			xlsBottomMargin
		}

		// Token: 0x02000123 RID: 291
		public enum FontFormatting
		{
			// Token: 0x04000E50 RID: 3664
			xlsNoFormat,
			// Token: 0x04000E51 RID: 3665
			xlsBold,
			// Token: 0x04000E52 RID: 3666
			xlsItalic,
			// Token: 0x04000E53 RID: 3667
			xlsUnderline = 4,
			// Token: 0x04000E54 RID: 3668
			xlsStrikeout = 8
		}

		// Token: 0x02000124 RID: 292
		private struct FONT_RECORD
		{
			// Token: 0x04000E55 RID: 3669
			public short opcode;

			// Token: 0x04000E56 RID: 3670
			public short length;

			// Token: 0x04000E57 RID: 3671
			public short FontHeight;

			// Token: 0x04000E58 RID: 3672
			public byte FontAttributes1;

			// Token: 0x04000E59 RID: 3673
			public byte FontAttributes2;

			// Token: 0x04000E5A RID: 3674
			public byte FontNameLength;
		}

		// Token: 0x02000125 RID: 293
		private struct PASSWORD_RECORD
		{
			// Token: 0x04000E5B RID: 3675
			public short opcode;

			// Token: 0x04000E5C RID: 3676
			public short length;
		}

		// Token: 0x02000126 RID: 294
		private struct HEADER_FOOTER_RECORD
		{
			// Token: 0x04000E5D RID: 3677
			public short opcode;

			// Token: 0x04000E5E RID: 3678
			public short length;

			// Token: 0x04000E5F RID: 3679
			public byte TextLength;
		}

		// Token: 0x02000127 RID: 295
		private struct PROTECT_SPREADSHEET_RECORD
		{
			// Token: 0x04000E60 RID: 3680
			public short opcode;

			// Token: 0x04000E61 RID: 3681
			public short length;

			// Token: 0x04000E62 RID: 3682
			public short Protect;
		}

		// Token: 0x02000128 RID: 296
		private struct FORMAT_COUNT_RECORD
		{
			// Token: 0x04000E63 RID: 3683
			public short opcode;

			// Token: 0x04000E64 RID: 3684
			public short length;

			// Token: 0x04000E65 RID: 3685
			public short Count;
		}

		// Token: 0x02000129 RID: 297
		private struct FORMAT_RECORD
		{
			// Token: 0x04000E66 RID: 3686
			public short opcode;

			// Token: 0x04000E67 RID: 3687
			public short length;

			// Token: 0x04000E68 RID: 3688
			public byte FormatLenght;
		}

		// Token: 0x0200012A RID: 298
		private struct COLWIDTH_RECORD
		{
			// Token: 0x04000E69 RID: 3689
			public short opcode;

			// Token: 0x04000E6A RID: 3690
			public short length;

			// Token: 0x04000E6B RID: 3691
			public byte col1;

			// Token: 0x04000E6C RID: 3692
			public byte col2;

			// Token: 0x04000E6D RID: 3693
			public short ColumnWidth;
		}

		// Token: 0x0200012B RID: 299
		private struct BEG_FILE_RECORD
		{
			// Token: 0x04000E6E RID: 3694
			public short opcode;

			// Token: 0x04000E6F RID: 3695
			public short length;

			// Token: 0x04000E70 RID: 3696
			public short version;

			// Token: 0x04000E71 RID: 3697
			public short ftype;
		}

		// Token: 0x0200012C RID: 300
		private struct END_FILE_RECORD
		{
			// Token: 0x04000E72 RID: 3698
			public short opcode;

			// Token: 0x04000E73 RID: 3699
			public short length;
		}

		// Token: 0x0200012D RID: 301
		private struct PRINT_GRIDLINES_RECORD
		{
			// Token: 0x04000E74 RID: 3700
			public short opcode;

			// Token: 0x04000E75 RID: 3701
			public short length;

			// Token: 0x04000E76 RID: 3702
			public short PrintFlag;
		}

		// Token: 0x0200012E RID: 302
		private struct tInteger
		{
			// Token: 0x04000E77 RID: 3703
			public short opcode;

			// Token: 0x04000E78 RID: 3704
			public short length;

			// Token: 0x04000E79 RID: 3705
			public short row;

			// Token: 0x04000E7A RID: 3706
			public short col;

			// Token: 0x04000E7B RID: 3707
			public byte rgbAttr1;

			// Token: 0x04000E7C RID: 3708
			public byte rgbAttr2;

			// Token: 0x04000E7D RID: 3709
			public byte rgbAttr3;

			// Token: 0x04000E7E RID: 3710
			public short intValue;
		}

		// Token: 0x0200012F RID: 303
		private struct tNumber
		{
			// Token: 0x04000E7F RID: 3711
			public short opcode;

			// Token: 0x04000E80 RID: 3712
			public short length;

			// Token: 0x04000E81 RID: 3713
			public short row;

			// Token: 0x04000E82 RID: 3714
			public short col;

			// Token: 0x04000E83 RID: 3715
			public byte rgbAttr1;

			// Token: 0x04000E84 RID: 3716
			public byte rgbAttr2;

			// Token: 0x04000E85 RID: 3717
			public byte rgbAttr3;

			// Token: 0x04000E86 RID: 3718
			public double NumberValue;
		}

		// Token: 0x02000130 RID: 304
		private struct tText
		{
			// Token: 0x04000E87 RID: 3719
			public short opcode;

			// Token: 0x04000E88 RID: 3720
			public short length;

			// Token: 0x04000E89 RID: 3721
			public short row;

			// Token: 0x04000E8A RID: 3722
			public short col;

			// Token: 0x04000E8B RID: 3723
			public byte rgbAttr1;

			// Token: 0x04000E8C RID: 3724
			public byte rgbAttr2;

			// Token: 0x04000E8D RID: 3725
			public byte rgbAttr3;

			// Token: 0x04000E8E RID: 3726
			public byte TextLength;
		}

		// Token: 0x02000131 RID: 305
		private struct MARGIN_RECORD_LAYOUT
		{
			// Token: 0x04000E8F RID: 3727
			public short opcode;

			// Token: 0x04000E90 RID: 3728
			public short length;

			// Token: 0x04000E91 RID: 3729
			public double MarginValue;
		}

		// Token: 0x02000132 RID: 306
		private struct HPAGE_BREAK_RECORD
		{
			// Token: 0x04000E92 RID: 3730
			public short opcode;

			// Token: 0x04000E93 RID: 3731
			public short length;

			// Token: 0x04000E94 RID: 3732
			public short NumPageBreaks;
		}

		// Token: 0x02000133 RID: 307
		private struct DEF_ROWHEIGHT_RECORD
		{
			// Token: 0x04000E95 RID: 3733
			public int opcode;

			// Token: 0x04000E96 RID: 3734
			public int length;

			// Token: 0x04000E97 RID: 3735
			public int RowHeight;
		}

		// Token: 0x02000134 RID: 308
		private struct ROW_HEIGHT_RECORD
		{
			// Token: 0x04000E98 RID: 3736
			public int opcode;

			// Token: 0x04000E99 RID: 3737
			public int length;

			// Token: 0x04000E9A RID: 3738
			public int RowNumber;

			// Token: 0x04000E9B RID: 3739
			public int FirstColumn;

			// Token: 0x04000E9C RID: 3740
			public int LastColumn;

			// Token: 0x04000E9D RID: 3741
			public int RowHeight;

			// Token: 0x04000E9E RID: 3742
			public int @internal;

			// Token: 0x04000E9F RID: 3743
			public byte DefaultAttributes;

			// Token: 0x04000EA0 RID: 3744
			public int FileOffset;

			// Token: 0x04000EA1 RID: 3745
			public byte rgbAttr1;

			// Token: 0x04000EA2 RID: 3746
			public byte rgbAttr2;

			// Token: 0x04000EA3 RID: 3747
			public byte rgbAttr3;
		}
	}
}
