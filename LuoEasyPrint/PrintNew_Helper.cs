using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuoEasyPrint
{
    public static partial class PrintNew_Helper
    {
		public static bool IsNewPage(this VB2008Print print, float theheight)
		{
			return print.IsNewPage(theheight, false, false);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000A42DC File Offset: 0x000A24DC
		public static bool IsNewPage(this VB2008Print print, float theheight, bool autonewpage)
		{
			return print.IsNewPage(theheight, autonewpage, true);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000A42F4 File Offset: 0x000A24F4
		public static bool IsNewPage(this VB2008Print print, float theheight, bool autonewpage, bool newpageUsePriorPageset)
		{
			bool flag = theheight + print.Currenty > print.PaperPrintHeight;
			if (flag && autonewpage)
			{
				if (newpageUsePriorPageset)
				{
					print.MyNewPage();
				}
				else
				{
					print.NewPage();
				}
			}
			return flag;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000A4334 File Offset: 0x000A2534
		public static bool MyIsNewPage(this VB2008Print print, float theheight, bool autonewpage)
		{
			bool flag = theheight + print.Currenty > print.PaperPrintHeight;
			if (flag && autonewpage)
			{
				print.MyNewPage();
			}
			return flag;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0000731F File Offset: 0x0000551F
		public static void NewPage(this VB2008Print print)
		{
			if (!print.CancelDocument)
			{
				print.NewPageBefore();
				print.NewPageAfter();
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000A4368 File Offset: 0x000A2568
		public static void NewPage(this VB2008Print print,bool isPaperLandscape)
		{
			if (!print.CancelDocument)
			{
				print.NewPageBefore();
				bool flag = print.isstarting;
				print.isstarting = false;
				print.PaperLandscape = isPaperLandscape;
				print.isstarting = flag;
				print.NewPageAfter();
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000A43A8 File Offset: 0x000A25A8
		public static void NewPage(PaperKind mypaperkind, bool isPaperLandscape)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperLandscape = isPaperLandscape;
				try
				{
					foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (paperSize.Kind == mypaperkind)
						{
							this.mypagesetting.PaperSize = paperSize;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000A444C File Offset: 0x000A264C
		public static void NewPage(PaperKind mypaperkind)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				try
				{
					foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (paperSize.Kind == mypaperkind)
						{
							this.mypagesetting.PaperSize = paperSize;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000A44EC File Offset: 0x000A26EC
		public static void NewPage(PaperKind mypaperkind, Margins thePaperMargin, bool isPaperLandscape)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperLandscape = isPaperLandscape;
				try
				{
					foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (paperSize.Kind == mypaperkind)
						{
							this.mypagesetting.PaperSize = paperSize;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000A459C File Offset: 0x000A279C
		public static void NewPage(PaperKind mypaperkind, Margins thePaperMargin)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				try
				{
					foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (paperSize.Kind == mypaperkind)
						{
							this.mypagesetting.PaperSize = paperSize;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000A4640 File Offset: 0x000A2840
		public static void NewPage(Margins thePaperMargin, bool isPaperLandscape)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperLandscape = isPaperLandscape;
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000A4684 File Offset: 0x000A2884
		public static void NewPage(Margins thePaperMargin)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000A46C4 File Offset: 0x000A28C4
		public static void NewPageBefore()
		{
			checked
			{
				if (this.hasprinterinstalled)
				{
					this.currentpage = this.GetPages() + 1;
					this.Currentx = 0f;
					this.Currenty = 0f;
					this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[this.currentpage + 1]);
					this.mypages[this.currentpage] = new StringBuilder("   ");
					this.GetPageAndPaperSettings(0);
				}
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000A4744 File Offset: 0x000A2944
		public static void NewPageAfter()
		{
			if (this.hasprinterinstalled)
			{
				this.SavePageCS();
				this.SaveFont(this.r_font, null);
				this.DrawMargin();
				this.DrawPageBackGroundImage();
				this.SetStatus("预处理，正在处理第〖" + Conversions.ToString(this.currentpage) + "〗页");
				Application.DoEvents();
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000A47A0 File Offset: 0x000A29A0
		public static void NewPage(PaperSize newpapersize, bool isPaperLandscape)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperLandscape = isPaperLandscape;
				this.PaperSize = newpapersize;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000A47E4 File Offset: 0x000A29E4
		public static void NewPage(PaperSize newpapersize)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperSize = newpapersize;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000A4824 File Offset: 0x000A2A24
		public static void NewPage(PaperSize newpapersize, Margins thePaperMargin, bool isPaperLandscape)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperLandscape = isPaperLandscape;
				this.PaperSize = newpapersize;
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000A4870 File Offset: 0x000A2A70
		public static void NewPage(PaperSize newpapersize, Margins thePaperMargin)
		{
			if (!this.CancelDocument)
			{
				this.NewPageBefore();
				bool flag = this.isstarting;
				this.isstarting = false;
				this.PaperSize = newpapersize;
				this.PaperMargins = thePaperMargin;
				this.isstarting = flag;
				this.NewPageAfter();
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00007335 File Offset: 0x00005535
		public static void NewRow(float currentrowheight)
		{
			if (!Module1.G_CancelDocument)
			{
				this.Currentx = 0f;
				this.Currenty += currentrowheight;
				if (this.Currenty > this.PaperPrintHeight)
				{
					this.MyNewPage();
				}
			}
		}
	}
}
