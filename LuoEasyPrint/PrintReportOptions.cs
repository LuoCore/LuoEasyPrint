using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000036 RID: 54
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PrintReportOptions
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x0004E658 File Offset: 0x0004C858
		public PrintReportOptions()
		{
			this.myleftmargin = 20f;
			this.myrightmargin = 20f;
			this.mytopmargin = 20f;
			this.mybottommargin = 20f;
			this.mypapername = "A4";
			this.mypaperheight = 297f;
			this.mypaperwidth = 210f;
			this.myalign = StringAlignment.Center;
			this.mypaperlandscape = false;
			this.w_spetator = "\u0001\u0005";
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00004321 File Offset: 0x00002521
		public float LeftMargin
		{
			get
			{
				return this.myleftmargin;
			}
			set
			{
				if (value >= 0f)
				{
					this.myleftmargin = value;
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0004E6EC File Offset: 0x0004C8EC
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00004332 File Offset: 0x00002532
		public float RightMargin
		{
			get
			{
				return this.myrightmargin;
			}
			set
			{
				if (value >= 0f)
				{
					this.myrightmargin = value;
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0004E704 File Offset: 0x0004C904
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00004343 File Offset: 0x00002543
		public float TopMargin
		{
			get
			{
				return this.mytopmargin;
			}
			set
			{
				if (value >= 0f)
				{
					this.mytopmargin = value;
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0004E71C File Offset: 0x0004C91C
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00004354 File Offset: 0x00002554
		public float BottomMargin
		{
			get
			{
				return this.mybottommargin;
			}
			set
			{
				if (value >= 0f)
				{
					this.mybottommargin = value;
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0004E734 File Offset: 0x0004C934
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00004365 File Offset: 0x00002565
		public StringAlignment Align
		{
			get
			{
				return this.myalign;
			}
			set
			{
				this.myalign = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0004E74C File Offset: 0x0004C94C
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x0000436E File Offset: 0x0000256E
		public bool PaperLandScape
		{
			get
			{
				return this.mypaperlandscape;
			}
			set
			{
				this.mypaperlandscape = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0004E760 File Offset: 0x0004C960
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x0004E778 File Offset: 0x0004C978
		public string PaperName
		{
			get
			{
				return this.mypapername;
			}
			set
			{
				this.mypapername = value;
				if (String.Compare(this.mypapername, "[自定义纸张]", false) != 0)
				{
					CommomPaperSize commomPaperSize = new CommomPaperSize();
					PaperSize printForm = definepaper.GetPrintForm("", this.mypapername);
					if (printForm != null)
					{
						this.mypaperwidth = Convert.ToSingle(new decimal((double)printForm.Width * 2.54 / 10.0));
						this.mypaperheight = Convert.ToSingle(new decimal((double)printForm.Height * 2.54 / 10.0));
					}
					commomPaperSize.Dispose();
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0004E818 File Offset: 0x0004CA18
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00004377 File Offset: 0x00002577
		public float PaperHeight
		{
			get
			{
				return this.mypaperheight;
			}
			set
			{
				if (value > 0f)
				{
					this.mypaperheight = value;
				}
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0004E830 File Offset: 0x0004CA30
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00004388 File Offset: 0x00002588
		public float PaperWidth
		{
			get
			{
				return this.mypaperwidth;
			}
			set
			{
				if (value > 0f)
				{
					this.mypaperwidth = value;
				}
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0004E848 File Offset: 0x0004CA48
		public bool ShowPageSetup()
		{
			ReportPageSetup reportPageSetup = new ReportPageSetup();
			reportPageSetup.w_bottommargin = this.mybottommargin;
			reportPageSetup.w_leftmargin = this.myleftmargin;
			reportPageSetup.w_paperheight = this.mypaperheight;
			reportPageSetup.w_paperlandscape = this.mypaperlandscape;
			reportPageSetup.w_papername = this.mypapername;
			reportPageSetup.w_paperwidth = this.mypaperwidth;
			reportPageSetup.w_rightmargin = this.myrightmargin;
			reportPageSetup.w_tablealign = this.myalign;
			reportPageSetup.w_topmargin = this.mytopmargin;
			bool result;
			if (reportPageSetup.ShowDialog() != DialogResult.OK)
			{
				result = false;
			}
			else
			{
				this.mybottommargin = reportPageSetup.w_bottommargin;
				this.myleftmargin = reportPageSetup.w_leftmargin;
				this.mypaperheight = reportPageSetup.w_paperheight;
				this.mypaperlandscape = reportPageSetup.w_paperlandscape;
				this.mypaperwidth = reportPageSetup.w_paperwidth;
				this.mypapername = reportPageSetup.w_papername;
				this.myrightmargin = reportPageSetup.w_rightmargin;
				this.myalign = reportPageSetup.w_tablealign;
				this.mytopmargin = reportPageSetup.w_topmargin;
				reportPageSetup.Dispose();
				result = true;
			}
			return result;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0004E94C File Offset: 0x0004CB4C
		public string SaveCS()
		{
			string str = Convert.ToString(this.myleftmargin);
			str = str + this.w_spetator + Convert.ToString(this.myrightmargin);
			str = str + this.w_spetator + Convert.ToString(this.mytopmargin);
			str = str + this.w_spetator + Convert.ToString(this.mybottommargin);
			str = str + this.w_spetator + Convert.ToString(Interaction.IIf(this.mypaperlandscape, "1", "0"));
			str = str + this.w_spetator + Convert.ToString((int)this.myalign);
			str = str + this.w_spetator + Convert.ToString(this.mypaperwidth);
			str = str + this.w_spetator + Convert.ToString(this.mypaperheight);
			return str + this.w_spetator + this.mypapername;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0004EA38 File Offset: 0x0004CC38
		public bool RestoreCS(string ss)
		{
			string[] array = Strings.Split(ss, this.w_spetator, -1, CompareMethod.Binary);
			bool result;
			try
			{
				this.myleftmargin = Convert.ToSingle(array[0]);
				this.myrightmargin = Convert.ToSingle(array[1]);
				this.mytopmargin = Convert.ToSingle(array[2]);
				this.mybottommargin = Convert.ToSingle(array[3]);
				if (String.Compare(array[4], "1", false) == 0)
				{
					this.PaperLandScape = true;
				}
				else
				{
					this.PaperLandScape = false;
				}
				this.Align = (StringAlignment)Convert.ToInt32(array[5]);
				this.PaperWidth = Convert.ToSingle(array[6]);
				this.PaperHeight = Convert.ToSingle(array[7]);
				this.PaperName = array[8];
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0004EB08 File Offset: 0x0004CD08
		public float GetPaperHeight()
		{
			float result;
			if (this.PaperLandScape)
			{
				result = this.PaperWidth;
			}
			else
			{
				result = this.PaperHeight;
			}
			return result;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0004EB30 File Offset: 0x0004CD30
		public float GetPaperWidth()
		{
			float result;
			if (!this.PaperLandScape)
			{
				result = this.PaperWidth;
			}
			else
			{
				result = this.PaperHeight;
			}
			return result;
		}

		// Token: 0x04000499 RID: 1177
		private float myleftmargin;

		// Token: 0x0400049A RID: 1178
		private float myrightmargin;

		// Token: 0x0400049B RID: 1179
		private float mytopmargin;

		// Token: 0x0400049C RID: 1180
		private float mybottommargin;

		// Token: 0x0400049D RID: 1181
		private string mypapername;

		// Token: 0x0400049E RID: 1182
		private float mypaperheight;

		// Token: 0x0400049F RID: 1183
		private float mypaperwidth;

		// Token: 0x040004A0 RID: 1184
		private StringAlignment myalign;

		// Token: 0x040004A1 RID: 1185
		private bool mypaperlandscape;

		// Token: 0x040004A2 RID: 1186
		private string w_spetator;
	}
}
