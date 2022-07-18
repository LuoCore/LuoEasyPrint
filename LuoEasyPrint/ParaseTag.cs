using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200006D RID: 109
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ParaseTag
	{
		// Token: 0x06000DCA RID: 3530 RVA: 0x0006E368 File Offset: 0x0006C568
		public ParaseTag()
		{
			this.sp_col = "\u0005";
			this.IsPrint = true;
			this.ColWidth = 10m;
			this.Fieldfont = new Font("宋体", 12f);
			this.Fieldforecolor = Color.Black;
			this.Fieldbackcolor = Color.White;
			this.Cellfont = new Font("宋体", 10f);
			this.Cellforecolor = Color.Black;
			this.Cellbackcolor = Color.White;
			this.Cellfield = "";
			this.CellHalign = StringAlignment.Near;
			this.CellValign = StringAlignment.Center;
			this.CellMul = false;
			this.CellType = "常规";
			this.CellFormat = "";
			this.CellformatEx = "";
			this.IsComputer = false;
			this.Cellcomputer = "";
			this.IsPrintZero = false;
			this.ImageType = DataGridViewImageCellLayout.Stretch;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0006E458 File Offset: 0x0006C658
		public string SaveTags()
		{
			string str;
			if (this.IsPrint)
			{
				str = "1";
			}
			else
			{
				str = "0";
			}
			str = str + this.sp_col + Convert.ToString(this.ColWidth);
			str = str + this.sp_col + Module1.ConvertFontToString(this.Fieldfont);
			str = str + this.sp_col + Module1.ConvertColorToString(this.Fieldforecolor);
			str = str + this.sp_col + Module1.ConvertColorToString(this.Fieldbackcolor);
			str = str + this.sp_col + Module1.ConvertFontToString(this.Cellfont);
			str = str + this.sp_col + Module1.ConvertColorToString(this.Cellforecolor);
			str = str + this.sp_col + Module1.ConvertColorToString(this.Cellbackcolor);
			str = str + this.sp_col + this.Cellfield;
			str = str + this.sp_col + Convert.ToString((int)this.CellHalign);
			str = str + this.sp_col + Convert.ToString((int)this.CellValign);
			str = str + this.sp_col + Convert.ToString(Interaction.IIf(this.CellMul, "1", "0"));
			str = str + this.sp_col + this.CellType;
			str = str + this.sp_col + this.CellFormat;
			str = str + this.sp_col + Convert.ToString(Interaction.IIf(this.IsComputer, "1", "0"));
			str = str + this.sp_col + this.Cellcomputer;
			if (this.IsPrintZero)
			{
				str = str + this.sp_col + "1";
			}
			else
			{
				str = str + this.sp_col + "0";
			}
			str = str + this.sp_col + this.CellformatEx;
			return str + this.sp_col + Convert.ToString((int)this.ImageType);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0006E650 File Offset: 0x0006C850
		public void RestoreTags(string mytag)
		{
			if (String.Compare(mytag, "", false) != 0)
			{
				string[] array = Strings.Split(mytag, this.sp_col, -1, CompareMethod.Binary);
				if (String.Compare(array[0], "1", false) == 0)
				{
					this.IsPrint = true;
				}
				else
				{
					this.IsPrint = false;
				}
				try
				{
					this.ColWidth = Convert.ToDecimal(array[1]);
				}
				catch (Exception ex)
				{
					this.ColWidth = 10m;
				}
				if (array.Length > 2)
				{
					this.Fieldfont = Module1.ConvertStringToFont(array[2]);
					this.Fieldforecolor = Module1.ConvertStringToColor(array[3]);
					this.Fieldbackcolor = Module1.ConvertStringToColor(array[4]);
					this.Cellfont = Module1.ConvertStringToFont(array[5]);
					this.Cellforecolor = Module1.ConvertStringToColor(array[6]);
					this.Cellbackcolor = Module1.ConvertStringToColor(array[7]);
					this.Cellfield = array[8];
					this.CellHalign = (StringAlignment)Convert.ToInt32(array[9]);
					this.CellValign = (StringAlignment)Convert.ToInt32(array[10]);
					if (String.Compare(array[11], "1", false) == 0)
					{
						this.CellMul = true;
					}
					else
					{
						this.CellMul = false;
					}
					this.CellType = array[12];
					this.CellFormat = array[13];
					if (String.Compare(array[14], "1", false) == 0)
					{
						this.IsComputer = true;
					}
					else
					{
						this.IsComputer = false;
					}
					this.Cellcomputer = array[15];
					if (String.Compare(array[16], "1", false) == 0)
					{
						this.IsPrintZero = true;
					}
					else
					{
						this.IsPrintZero = false;
					}
					if (array.Length >= 18)
					{
						this.CellformatEx = array[17];
					}
					else
					{
						this.CellformatEx = "";
					}
					if (array.Length >= 19)
					{
						this.ImageType = (DataGridViewImageCellLayout)Convert.ToInt32(array[18]);
					}
					else
					{
						this.ImageType = DataGridViewImageCellLayout.Stretch;
					}
				}
			}
		}

		// Token: 0x040006ED RID: 1773
		private string sp_col;

		// Token: 0x040006EE RID: 1774
		public bool IsPrint;

		// Token: 0x040006EF RID: 1775
		public decimal ColWidth;

		// Token: 0x040006F0 RID: 1776
		public Font Fieldfont;

		// Token: 0x040006F1 RID: 1777
		public Color Fieldforecolor;

		// Token: 0x040006F2 RID: 1778
		public Color Fieldbackcolor;

		// Token: 0x040006F3 RID: 1779
		public Font Cellfont;

		// Token: 0x040006F4 RID: 1780
		public Color Cellforecolor;

		// Token: 0x040006F5 RID: 1781
		public Color Cellbackcolor;

		// Token: 0x040006F6 RID: 1782
		public string Cellfield;

		// Token: 0x040006F7 RID: 1783
		public StringAlignment CellHalign;

		// Token: 0x040006F8 RID: 1784
		public StringAlignment CellValign;

		// Token: 0x040006F9 RID: 1785
		public bool CellMul;

		// Token: 0x040006FA RID: 1786
		public string CellType;

		// Token: 0x040006FB RID: 1787
		public string CellFormat;

		// Token: 0x040006FC RID: 1788
		public string CellformatEx;

		// Token: 0x040006FD RID: 1789
		public bool IsComputer;

		// Token: 0x040006FE RID: 1790
		public string Cellcomputer;

		// Token: 0x040006FF RID: 1791
		public bool IsPrintZero;

		// Token: 0x04000700 RID: 1792
		public DataGridViewImageCellLayout ImageType;
	}
}
