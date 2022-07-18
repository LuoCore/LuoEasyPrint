using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200000D RID: 13
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class showpreview : Form
	{
		// Token: 0x0600013F RID: 319 RVA: 0x0001270C File Offset: 0x0001090C
		public showpreview()
		{
			base.Load += this.DataGridViewPrint_Load;
			this.needrefresh = true;
			this.PaperLandscape = false;
			this.autowrap = false;
			this.mywatermarktext = "";
			this.mywatermarkfont = new Font("华文行楷", 80f, FontStyle.Bold);
			this.mywatermarkopacity = 128;
			this.mywatermarklandscape = true;
			this.mywatermarkcolor = Color.Red;
			this.myshapedepth = 8;
			this.myhzcolumns = "";
			this.myhzfont = null;
			this.myhzforecolor = default(Color);
			this.myhzbackcolor = default(Color);
			this.mygroupcolumne = "";
			this.mygroupnewpage = false;
			this.myaddrowid = false;
			this.myaddrownew = false;
			this.myIsImmediatePrintNotPreviewShowPrintDialog = false;
			this.myIsShowMessageIfPrinterNotSupportPaper = false;
			this.currentprintername = "";
			this.myTableTopLeftTitleAlign = StringAlignment.Near;
			this.myTableTopMiddleTitleAlign = StringAlignment.Center;
			this.myTableTopRightTitleAlign = StringAlignment.Far;
			this.myTableBottomLeftTitleAlign = StringAlignment.Near;
			this.myTableBottomMiddleTitleAlign = StringAlignment.Center;
			this.myTableBottomRightTitleAlign = StringAlignment.Far;
			this.mySumNumberAlign = StringAlignment.Center;
			this.mypagebackgroundimage = null;
			this.myisdrawpageheaderline = false;
			this.myisdrawpagefooterline = false;
			this.myisdrawmargin = false;
			this.myisautoaddemptyrow = false;
			this.myenabledprint = true;
			this.myisdrawtablefootereverypage = false;
			this.myisusedoubleline = false;
			this.myouterborder = false;
			this.myouterbordercolor = Color.Black;
			this.myouterborderwidth = 1f;
			this.thedoublelinespace = 3f;
			this.myZDXtext = "装订线";
			this.myZDXfont = new Font("宋体", 9f);
			this.myZDXtextcolor = Color.Black;
			this.myZDXlinecolor = Color.Black;
			this.myZDXlinestyle = DashStyle.Dash;
			this.myZDXposition = 0f;
			this.myrowheight = 0f;
			this._printcopys = 1;
			this.myisshowprogress = true;
			this.myZDXtype = showpreview.TheZDXTYPE.LEFT;
			this.myisdrawZDX = false;
			this.myenablesaveaspdf = true;
			this.myenablesaveasimage = true;
			this.InitializeComponent();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00012FE0 File Offset: 0x000111E0
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00012FF8 File Offset: 0x000111F8
		internal virtual VB2008Print DataGridViewPrint1
		{
			get
			{
				return this._DataGridViewPrint1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				VB2008Print.EndPrintToPrinterEventHandler value2 = new VB2008Print.EndPrintToPrinterEventHandler(this.DataGridViewPrint1_EndPrintToPrinter);
				VB2008Print.EndPreViewEventHandler value3 = new VB2008Print.EndPreViewEventHandler(this.DataGridViewPrint1_EndPreView);
				VB2008Print.ZDYButtonClickEventHandler value4 = new VB2008Print.ZDYButtonClickEventHandler(this.DataGridViewPrint1_ZDYButtonClick);
				VB2008Print.QueryDefaultPageSettingsEventHandler value5 = new VB2008Print.QueryDefaultPageSettingsEventHandler(this.DataGridViewPrint1_QueryDefaultPageSettings);
				VB2008Print.PrintDocumentEventHandler value6 = new VB2008Print.PrintDocumentEventHandler(this.DataGridViewPrint1_PrintDocument);
				VB2008Print.HeaderFooterOutEventHandler value7 = new VB2008Print.HeaderFooterOutEventHandler(this.DataGridViewPrint1_HeaderFooterOut);
				if (this._DataGridViewPrint1 != null)
				{
					this._DataGridViewPrint1.EndPrintToPrinter -= value2;
					this._DataGridViewPrint1.EndPreView -= value3;
					this._DataGridViewPrint1.ZDYButtonClick -= value4;
					this._DataGridViewPrint1.QueryDefaultPageSettings -= value5;
					this._DataGridViewPrint1.PrintDocument -= value6;
					this._DataGridViewPrint1.HeaderFooterOut -= value7;
				}
				this._DataGridViewPrint1 = value;
				if (this._DataGridViewPrint1 != null)
				{
					this._DataGridViewPrint1.EndPrintToPrinter += value2;
					this._DataGridViewPrint1.EndPreView += value3;
					this._DataGridViewPrint1.ZDYButtonClick += value4;
					this._DataGridViewPrint1.QueryDefaultPageSettings += value5;
					this._DataGridViewPrint1.PrintDocument += value6;
					this._DataGridViewPrint1.HeaderFooterOut += value7;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00013108 File Offset: 0x00011308
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002962 File Offset: 0x00000B62
		internal virtual DataGridView mydgv
		{
			get
			{
				return this._mydgv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mydgv = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00013120 File Offset: 0x00011320
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000296B File Offset: 0x00000B6B
		internal virtual DataGridView mydgv2
		{
			get
			{
				return this._mydgv2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mydgv2 = value;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00013138 File Offset: 0x00011338
		private void DataGridViewPrint1_HeaderFooterOut(int pages, int curpage)
		{
			string text = this.pageleft;
			string text2 = this.pagemiddle;
			string text3 = this.pageright;
			text = text.Replace("[页码]", Conversions.ToString(curpage));
			text = text.Replace("[总页数]", Conversions.ToString(pages));
			text2 = text2.Replace("[页码]", Conversions.ToString(curpage));
			text2 = text2.Replace("[总页数]", Conversions.ToString(pages));
			text3 = text3.Replace("[页码]", Conversions.ToString(curpage));
			text3 = text3.Replace("[总页数]", Conversions.ToString(pages));
			this.DataGridViewPrint1.PrintFooter(text, text2, text3, this.footerfont, this.footercolor, 0);
			text = this.pagel;
			text2 = this.pagem;
			text3 = this.pager;
			text = text.Replace("[页码]", Conversions.ToString(curpage));
			text = text.Replace("[总页数]", Conversions.ToString(pages));
			text2 = text2.Replace("[页码]", Conversions.ToString(curpage));
			text2 = text2.Replace("[总页数]", Conversions.ToString(pages));
			text3 = text3.Replace("[页码]", Conversions.ToString(curpage));
			text3 = text3.Replace("[总页数]", Conversions.ToString(pages));
			this.DataGridViewPrint1.PrintHeader(text, text2, text3, this.headerfont, this.headercolor, 0);
			text = this.myrightt;
			text2 = this.myrightm;
			text3 = this.myrightb;
			text = text.Replace("[页码]", Conversions.ToString(curpage));
			text = text.Replace("[总页数]", Conversions.ToString(pages));
			text2 = text2.Replace("[页码]", Conversions.ToString(curpage));
			text2 = text2.Replace("[总页数]", Conversions.ToString(pages));
			text3 = text3.Replace("[页码]", Conversions.ToString(curpage));
			text3 = text3.Replace("[总页数]", Conversions.ToString(pages));
			this.DataGridViewPrint1.PrintRight(text, text2, text3, this.myrightfont, this.myrightcolor, 0);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001331C File Offset: 0x0001151C
		private void DataGridViewPrint1_PrintDocument()
		{
			this.DataGridViewPrint1.NewPage();
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			if (String.Compare(this.myreportheadertext, "", false) != 0)
			{
				stringFormat.Alignment = this.myreportheaderalignment;
				this.DataGridViewPrint1.DrawText(this.myreportheadertext, this.DataGridViewPrint1.PaperPrintWidth, this.myreportheaderfont, this.myreportheadercolor, stringFormat, 0);
				this.DataGridViewPrint1.NewRow(this.DataGridViewPrint1.LastDrawTextHeight);
				this.DataGridViewPrint1.Currenty = this.DataGridViewPrint1.Currenty + this.myreportheaderspace;
				this.DataGridViewPrint1.IsNewPage(0f, true);
			}
			this.DataGridViewPrint1.TextColor = this.defaultcolor;
			if (this.dgvtoprint.Rows.Count <= 0)
			{
				Interaction.MsgBox("不能打印或生成预览，没有可打印的数据行（或没有可见行）", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (Module1.GetDGVVisibleRows(this.dgvtoprint) <= 0)
			{
				Interaction.MsgBox("不能打印或生成预览，没有可打印的数据行（或没有可见行）", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				int num = 0;
				int num2 = 0;
				checked
				{
					int num3 = this.dgvtoprint.Columns.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (this.dgvtoprint.Columns[i].Visible)
						{
							num++;
						}
					}
				}
				if (num == 0)
				{
					Interaction.MsgBox("不能打印或生成预览，没有可供打印的列，或者所有列均设置为不可见", MsgBoxStyle.OkOnly, "提示信息");
				}
				else
				{
					Module1.CopyDataGridViewShowStatus(this.dgvtoprint, this.mydgv, false);
					try
					{
						if (this.myrowheight != 0f)
						{
							float num4 = this.DataGridViewPrint1.ConvToDisplay(this.myrowheight * 10f, false);
							int num5 = 0;
							checked
							{
								int num6 = this.mydgv.RowCount - 1;
								for (int j = num5; j <= num6; j++)
								{
									if (num4 < 0f)
									{
										this.mydgv.Rows[j].MinimumHeight = (int)Math.Round((double)Math.Abs(num4));
									}
									else if (num4 > 0f)
									{
										this.mydgv.Rows[j].Height = (int)Math.Round((double)num4);
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
					}
					this.DataGridViewPrint1.StartDo(this.mydgv, "", true, this.mygroupcolumne, this.myhzcolumns, this.myaddrownew, this.mygroupnewpage, this.myhzfont, this.myhzforecolor, this.myhzbackcolor, this.autoformat, this.printtype, this.ztitle, this.ztitlefont, this.ftitle, this.ftitlefont, this.bgalignment, this.myborder, this.zoomtopaperwidth, this.autoresizerowheight, this.topfont, this.tablel, this.tablem, this.tabler, this.bottomfont, this.tableleft, this.tablemiddle, this.tableright, this.minfontsize, this.reppagetitle, this.printbackcolor, this.mytitletextstyle, this.mysubtitlestyle, this.fixedcols, this.myaddrowid, this.mycolumns, this.columnspace, this.lastpagemode, this.linespace, this.printzero, this.myheader, this.myTableTopLeftTitleAlign, this.myTableTopMiddleTitleAlign, this.myTableTopRightTitleAlign, this.myTableBottomLeftTitleAlign, this.myTableBottomMiddleTitleAlign, this.myTableBottomRightTitleAlign, this.mySumNumberAlign, this.autowrap, 0f);
					if (String.Compare(this.myreportfootertext, "", false) != 0)
					{
						this.DataGridViewPrint1.Currenty = this.DataGridViewPrint1.Currenty + this.myreportfooterspace;
						stringFormat.Alignment = this.myreportfooteralignment;
						if (this.DataGridViewPrint1.IsNewPage(0f))
						{
							this.DataGridViewPrint1.NewPage();
						}
						this.DataGridViewPrint1.DrawText(this.myreportfootertext, this.DataGridViewPrint1.PaperPrintWidth, this.myreportfooterfont, this.myreportfootercolor, stringFormat, 0);
					}
				}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001370C File Offset: 0x0001190C
		private void DataGridViewPrint1_QueryDefaultPageSettings(ref PaperSize mypapersize, ref Margins thePaperMargin, ref bool isPaperLandscape)
		{
			isPaperLandscape = this.PaperLandscape;
			PaperSize paperSize;
			if (this.paperkind > PaperKind.Custom)
			{
				paperSize = definepaper.GetPrintForm(this.DataGridViewPrint1.GetCurrentPrinterName(), this.paperkind);
			}
			else if (decimal.Compare(this.mypaperwidth, 0m) > 0 & decimal.Compare(this.mypaperheight, 0m) > 0)
			{
				paperSize = null;
			}
			else
			{
				paperSize = definepaper.GetPrintForm(this.DataGridViewPrint1.GetCurrentPrinterName(), this.papername);
			}
			if (paperSize == null)
			{
				if (String.Compare(Strings.Trim(this.papername), "", false) == 0)
				{
					this.papername = "[自定义纸张]";
				}
				try
				{
					mypapersize = checked(new PaperSize(this.papername, (int)Math.Round((double)Module1.ConvertCmToInch(Convert.ToSingle(decimal.Divide(decimal.Multiply(this.mypaperwidth, 100m), 10m)))), (int)Math.Round((double)Module1.ConvertCmToInch(Convert.ToSingle(decimal.Divide(decimal.Multiply(this.mypaperheight, 100m), 10m))))));
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			mypapersize = paperSize;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001385C File Offset: 0x00011A5C
		private void DataGridViewPrint_Load(object sender, EventArgs e)
		{
			if (String.Compare(this.mywindowtext + "", "", false) != 0)
			{
				this.Text = this.mywindowtext;
			}
			if (this.myisimmediateprint)
			{
				this.DataGridViewPrint1.IsImmediatePrintNotPreview = true;
				this.DataGridViewPrint1.IsImmediatePrintNotPreviewShowPrintDialog = this.myIsImmediatePrintNotPreviewShowPrintDialog;
				this.Visible = false;
			}
			else
			{
				this.Visible = true;
				this.DataGridViewPrint1.IsImmediatePrintNotPreview = false;
				this.DataGridViewPrint1.IsImmediatePrintNotPreviewShowPrintDialog = this.myIsImmediatePrintNotPreviewShowPrintDialog;
			}
			this.DataGridViewPrint1.IsShowMessageIfPrinterNotSupportPaper = this.myIsShowMessageIfPrinterNotSupportPaper;
			this.DataGridViewPrint1.IsUseAPIprintDialog = this.myisuseAPIprintDialog;
			this.DataGridViewPrint1.SetPageBackGroundImage(this.mypagebackgroundimage);
			this.DataGridViewPrint1.IsDrawPageFooterLine = this.myisdrawpagefooterline;
			this.DataGridViewPrint1.IsDrawPageHeaderLine = this.myisdrawpageheaderline;
			this.DataGridViewPrint1.IsDrawmargin = this.myisdrawmargin;
			this.DataGridViewPrint1.IsAutoAddEmptyRow = this.myisautoaddemptyrow;
			this.DataGridViewPrint1.zdybutton.Enabled = this.mycaneditprintsettings;
			this.DataGridViewPrint1.IsDrawTableFooterEveryPage = this.myisdrawtablefootereverypage;
			this.DataGridViewPrint1.EnabledPrint = this.myenabledprint;
			this.DataGridViewPrint1.IsDrawZDX = this.myisdrawZDX;
			this.DataGridViewPrint1.ZDXText = this.myZDXtext;
			this.DataGridViewPrint1.ZDXFont = this.myZDXfont;
			this.DataGridViewPrint1.ZDXLinecoLor = this.myZDXlinecolor;
			this.DataGridViewPrint1.ZDXLineStyle = this.myZDXlinestyle;
			this.DataGridViewPrint1.ZDXPosition = this.myZDXposition;
			this.DataGridViewPrint1.ZDXTextColor = this.myZDXtextcolor;
			this.DataGridViewPrint1.ZDXType = (VB2008Print.TheZDXTYPE)this.myZDXtype;
			this.DataGridViewPrint1.DoubleLineSpace = this.thedoublelinespace;
			this.DataGridViewPrint1.IsUseDoubleLine = this.myisusedoubleline;
			this.DataGridViewPrint1.OuterBorder = this.myouterborder;
			this.DataGridViewPrint1.OuterBorderColor = this.myouterbordercolor;
			this.DataGridViewPrint1.OuterBorderWidth = this.myouterborderwidth;
			this.DataGridViewPrint1.EnableSaveAsPDF = this.myenablesaveaspdf;
			this.DataGridViewPrint1.EnableSaveAsImage = this.myenablesaveasimage;
			this.DataGridViewPrint1.IsShowProgess = this.myisshowprogress;
			this.DataGridViewPrint1.PrintCopys = this._printcopys;
			if (this.needrefresh)
			{
				this.MyRefresh();
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public void MyRefresh()
		{
			this.DataGridViewPrint1.IsNeedPrintPageHeaderAndFooter = true;
			if ((!this.myisdrawZDX & String.Compare(Strings.Trim(this.mywatermarktext), "", false) == 0) && (String.Compare(Strings.Trim(this.pagel), "", false) == 0 & String.Compare(Strings.Trim(this.pagem), "", false) == 0 & String.Compare(Strings.Trim(this.pager), "", false) == 0) && (String.Compare(Strings.Trim(this.pageleft), "", false) == 0 & String.Compare(Strings.Trim(this.pagemiddle), "", false) == 0 & String.Compare(Strings.Trim(this.pageright), "", false) == 0) && (String.Compare(Strings.Trim(this.myrightt), "", false) == 0 & String.Compare(Strings.Trim(this.myrightb), "", false) == 0 & String.Compare(Strings.Trim(this.myrightt), "", false) == 0))
			{
				this.DataGridViewPrint1.IsNeedPrintPageHeaderAndFooter = false;
			}
			if (String.Compare(this.currentprintername.Trim(), "", false) != 0)
			{
				this.DataGridViewPrint1.SetCurrentPrinterName(this.currentprintername);
			}
			this.DataGridViewPrint1.IsDrawTableFooterEveryPage = this.myisdrawtablefootereverypage;
			this.DataGridViewPrint1.zdybutton.Enabled = this.mycaneditprintsettings;
			this.DataGridViewPrint1.IsDrawPageFooterLine = this.myisdrawpagefooterline;
			this.DataGridViewPrint1.IsDrawPageHeaderLine = this.myisdrawpageheaderline;
			this.DataGridViewPrint1.IsAutoAddEmptyRow = this.myisautoaddemptyrow;
			this.DataGridViewPrint1.IsShowMessageIfPrinterNotSupportPaper = this.myIsShowMessageIfPrinterNotSupportPaper;
			this.DataGridViewPrint1.DocumentName = this.documentname;
			this.DataGridViewPrint1.PaperMargins = this.mypapermargin;
			this.DataGridViewPrint1.DocumentName = this.documentname;
			this.DataGridViewPrint1.WaterMarkColor = this.mywatermarkcolor;
			this.DataGridViewPrint1.WaterMarkFont = this.mywatermarkfont;
			this.DataGridViewPrint1.WaterMarkLandscape = this.mywatermarklandscape;
			this.DataGridViewPrint1.WaterMarkOpacity = this.mywatermarkopacity;
			this.DataGridViewPrint1.WaterMarkText = this.mywatermarktext;
			this.DataGridViewPrint1.ShapeDepth = this.myshapedepth;
			this.DataGridViewPrint1.IsDGVCellValignmentCenter = this.myIsDGVCellValignmentCenter;
			this.DataGridViewPrint1.EnabledPrint = this.myenabledprint;
			this.DataGridViewPrint1.IsDrawZDX = this.myisdrawZDX;
			this.DataGridViewPrint1.ZDXText = this.myZDXtext;
			this.DataGridViewPrint1.ZDXFont = this.myZDXfont;
			this.DataGridViewPrint1.ZDXLinecoLor = this.myZDXlinecolor;
			this.DataGridViewPrint1.ZDXLineStyle = this.myZDXlinestyle;
			this.DataGridViewPrint1.ZDXPosition = this.myZDXposition;
			this.DataGridViewPrint1.ZDXTextColor = this.myZDXtextcolor;
			this.DataGridViewPrint1.ZDXType = (VB2008Print.TheZDXTYPE)this.myZDXtype;
			this.DataGridViewPrint1.DoubleLineSpace = this.thedoublelinespace;
			this.DataGridViewPrint1.IsUseDoubleLine = this.myisusedoubleline;
			this.DataGridViewPrint1.OuterBorder = this.myouterborder;
			this.DataGridViewPrint1.OuterBorderColor = this.myouterbordercolor;
			this.DataGridViewPrint1.OuterBorderWidth = this.myouterborderwidth;
			this.DataGridViewPrint1.EnableSaveAsPDF = this.myenablesaveaspdf;
			this.DataGridViewPrint1.EnableSaveAsImage = this.myenablesaveasimage;
			this.DataGridViewPrint1.IsShowProgess = this.myisshowprogress;
			this.DataGridViewPrint1.PrintCopys = this._printcopys;
			this.DataGridViewPrint1.InvalidatePreview();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00013E80 File Offset: 0x00012080
		private void DataGridViewPrint1_ZDYButtonClick()
		{
			this.Visible = false;
			Module1.myPrintset.isfirsttimeshow = false;
			Module1.myPrintset.paperkind = this.DataGridViewPrint1.PaperKind;
			Module1.myPrintset.papername = this.DataGridViewPrint1.PaperSize.PaperName;
			Module1.myPrintset.mypapermarign.Left = this.DataGridViewPrint1.PaperMargins.Left;
			Module1.myPrintset.mypapermarign.Right = this.DataGridViewPrint1.PaperMargins.Right;
			Module1.myPrintset.mypapermarign.Top = this.DataGridViewPrint1.PaperMargins.Top;
			Module1.myPrintset.mypapermarign.Bottom = this.DataGridViewPrint1.PaperMargins.Bottom;
			Module1.myPrintset.PaperLandscape = this.DataGridViewPrint1.PaperLandscape;
			try
			{
				Module1.myPrintset.NeedReadFangAn = false;
				Module1.myPrintset.currentprintname = this.DataGridViewPrint1.GetCurrentPrinterName();
				if (!Module1.myPrintset.Modal)
				{
					Module1.myPrintset.ShowDialog();
				}
				else
				{
					Module1.myPrintset.Visible = true;
					Module1.myPrintset.currentprintname = this.DataGridViewPrint1.GetCurrentPrinterName();
					Module1.myPrintset.SetPrintCS();
				}
			}
			catch (Exception ex)
			{
				Module1.myPrintset.Visible = true;
				Module1.myPrintset.currentprintname = this.DataGridViewPrint1.GetCurrentPrinterName();
				Module1.myPrintset.SetPrintCS();
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002590 File Offset: 0x00000790
		private void DataGridViewPrint1_EndPreView()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002974 File Offset: 0x00000B74
		private void DataGridViewPrint1_EndPrintToPrinter()
		{
			if (this.myisimmediateprint)
			{
				this.MyClose();
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001400C File Offset: 0x0001220C
		private void MyClose()
		{
			if (this.InvokeRequired)
			{
				showpreview.MyCl method = new showpreview.MyCl(this.MyClose);
				this.Invoke(method);
			}
			else
			{
				this.Close();
			}
		}

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("DataGridViewPrint1")]
		private VB2008Print _DataGridViewPrint1;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("mydgv")]
		private DataGridView _mydgv;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("mydgv2")]
		private DataGridView _mydgv2;

		// Token: 0x04000092 RID: 146
		public bool needrefresh;

		// Token: 0x04000093 RID: 147
		public bool PaperLandscape;

		// Token: 0x04000094 RID: 148
		public string ztitle;

		// Token: 0x04000095 RID: 149
		public string ftitle;

		// Token: 0x04000096 RID: 150
		public Font ztitlefont;

		// Token: 0x04000097 RID: 151
		public Font ftitlefont;

		// Token: 0x04000098 RID: 152
		public int printtype;

		// Token: 0x04000099 RID: 153
		public DataGridView dgvtoprint;

		// Token: 0x0400009A RID: 154
		public StringAlignment bgalignment;

		// Token: 0x0400009B RID: 155
		public bool zoomtopaperwidth;

		// Token: 0x0400009C RID: 156
		public bool autoresizerowheight;

		// Token: 0x0400009D RID: 157
		public float minfontsize;

		// Token: 0x0400009E RID: 158
		public bool reppagetitle;

		// Token: 0x0400009F RID: 159
		public bool printbackcolor;

		// Token: 0x040000A0 RID: 160
		public string myborder;

		// Token: 0x040000A1 RID: 161
		public float linespace;

		// Token: 0x040000A2 RID: 162
		public bool printzero;

		// Token: 0x040000A3 RID: 163
		public bool autowrap;

		// Token: 0x040000A4 RID: 164
		public int mycolumns;

		// Token: 0x040000A5 RID: 165
		public float columnspace;

		// Token: 0x040000A6 RID: 166
		public bool lastpagemode;

		// Token: 0x040000A7 RID: 167
		public int fixedcols;

		// Token: 0x040000A8 RID: 168
		public string documentname;

		// Token: 0x040000A9 RID: 169
		public Margins mypapermargin;

		// Token: 0x040000AA RID: 170
		public bool autoformat;

		// Token: 0x040000AB RID: 171
		public string pagel;

		// Token: 0x040000AC RID: 172
		public string pagem;

		// Token: 0x040000AD RID: 173
		public string pager;

		// Token: 0x040000AE RID: 174
		public string pageleft;

		// Token: 0x040000AF RID: 175
		public string pageright;

		// Token: 0x040000B0 RID: 176
		public string pagemiddle;

		// Token: 0x040000B1 RID: 177
		public string tablel;

		// Token: 0x040000B2 RID: 178
		public string tablem;

		// Token: 0x040000B3 RID: 179
		public string tabler;

		// Token: 0x040000B4 RID: 180
		public string tableleft;

		// Token: 0x040000B5 RID: 181
		public string tablemiddle;

		// Token: 0x040000B6 RID: 182
		public string tableright;

		// Token: 0x040000B7 RID: 183
		public Font footerfont;

		// Token: 0x040000B8 RID: 184
		public Font headerfont;

		// Token: 0x040000B9 RID: 185
		public Font topfont;

		// Token: 0x040000BA RID: 186
		public Font bottomfont;

		// Token: 0x040000BB RID: 187
		public Color footercolor;

		// Token: 0x040000BC RID: 188
		public Color headercolor;

		// Token: 0x040000BD RID: 189
		public Color defaultcolor;

		// Token: 0x040000BE RID: 190
		public string mywatermarktext;

		// Token: 0x040000C0 RID: 192
		public byte mywatermarkopacity;

		// Token: 0x040000C1 RID: 193
		public bool mywatermarklandscape;

		// Token: 0x040000C2 RID: 194
		public Color mywatermarkcolor;

		// Token: 0x040000C3 RID: 195
		public int myshapedepth;

		// Token: 0x040000C4 RID: 196
		public int mytitletextstyle;

		// Token: 0x040000C5 RID: 197
		public int mysubtitlestyle;

		// Token: 0x040000C6 RID: 198
		public string myrightt;

		// Token: 0x040000C7 RID: 199
		public string myrightm;

		// Token: 0x040000C8 RID: 200
		public string myrightb;

		// Token: 0x040000C9 RID: 201
		public Font myrightfont;

		// Token: 0x040000CA RID: 202
		public Color myrightcolor;

		// Token: 0x040000CB RID: 203
		public bool myisimmediateprint;

		// Token: 0x040000CC RID: 204
		public string mywindowtext;

		// Token: 0x040000CD RID: 205
		public bool myIsDGVCellValignmentCenter;

		// Token: 0x040000CE RID: 206
		public string myhzcolumns;

		// Token: 0x040000CF RID: 207
		public Font myhzfont;

		// Token: 0x040000D0 RID: 208
		public Color myhzforecolor;

		// Token: 0x040000D1 RID: 209
		public Color myhzbackcolor;

		// Token: 0x040000D2 RID: 210
		public string mygroupcolumne;

		// Token: 0x040000D3 RID: 211
		public bool mygroupnewpage;

		// Token: 0x040000D4 RID: 212
		public bool myaddrowid;

		// Token: 0x040000D5 RID: 213
		public bool myaddrownew;

		// Token: 0x040000D6 RID: 214
		public bool myIsImmediatePrintNotPreviewShowPrintDialog;

		// Token: 0x040000D7 RID: 215
		public bool myIsShowMessageIfPrinterNotSupportPaper;

		// Token: 0x040000D8 RID: 216
		public TreeView myheader;

		// Token: 0x040000D9 RID: 217
		public string currentprintername;

		// Token: 0x040000DA RID: 218
		public PaperKind paperkind;

		// Token: 0x040000DB RID: 219
		public string papername;

		// Token: 0x040000DC RID: 220
		public decimal mypaperwidth;

		// Token: 0x040000DD RID: 221
		public decimal mypaperheight;

		// Token: 0x040000DE RID: 222
		public bool myisuseAPIprintDialog;

		// Token: 0x040000DF RID: 223
		public StringAlignment myTableTopLeftTitleAlign;

		// Token: 0x040000E0 RID: 224
		public StringAlignment myTableTopMiddleTitleAlign;

		// Token: 0x040000E1 RID: 225
		public StringAlignment myTableTopRightTitleAlign;

		// Token: 0x040000E2 RID: 226
		public StringAlignment myTableBottomLeftTitleAlign;

		// Token: 0x040000E3 RID: 227
		public StringAlignment myTableBottomMiddleTitleAlign;

		// Token: 0x040000E4 RID: 228
		public StringAlignment myTableBottomRightTitleAlign;

		// Token: 0x040000E5 RID: 229
		public StringAlignment mySumNumberAlign;

		// Token: 0x040000E6 RID: 230
		public Image mypagebackgroundimage;

		// Token: 0x040000E7 RID: 231
		public bool myisdrawpageheaderline;

		// Token: 0x040000E8 RID: 232
		public bool myisdrawpagefooterline;

		// Token: 0x040000E9 RID: 233
		public bool myisdrawmargin;

		// Token: 0x040000EA RID: 234
		public bool myisautoaddemptyrow;

		// Token: 0x040000EB RID: 235
		public bool mycaneditprintsettings;

		// Token: 0x040000EC RID: 236
		public bool myenabledprint;

		// Token: 0x040000ED RID: 237
		public bool myisdrawtablefootereverypage;

		// Token: 0x040000EE RID: 238
		public bool myisusedoubleline;

		// Token: 0x040000EF RID: 239
		public bool myouterborder;

		// Token: 0x040000F0 RID: 240
		public Color myouterbordercolor;

		// Token: 0x040000F1 RID: 241
		public float myouterborderwidth;

		// Token: 0x040000F2 RID: 242
		public float thedoublelinespace;

		// Token: 0x040000F3 RID: 243
		public string myZDXtext;

		// Token: 0x040000F5 RID: 245
		public Color myZDXtextcolor;

		// Token: 0x040000F6 RID: 246
		public Color myZDXlinecolor;

		// Token: 0x040000F7 RID: 247
		public DashStyle myZDXlinestyle;

		// Token: 0x040000F8 RID: 248
		public float myZDXposition;

		// Token: 0x040000F9 RID: 249
		public float myrowheight;

		// Token: 0x040000FA RID: 250
		public short _printcopys;

		// Token: 0x040000FB RID: 251
		public bool myisshowprogress;

		// Token: 0x040000FC RID: 252
		public showpreview.TheZDXTYPE myZDXtype;

		// Token: 0x040000FD RID: 253
		public bool myisdrawZDX;

		// Token: 0x040000FE RID: 254
		public string myreportheadertext;

		// Token: 0x040000FF RID: 255
		public StringAlignment myreportheaderalignment;

		// Token: 0x04000100 RID: 256
		public Font myreportheaderfont;

		// Token: 0x04000101 RID: 257
		public Color myreportheadercolor;

		// Token: 0x04000102 RID: 258
		public float myreportheaderspace;

		// Token: 0x04000103 RID: 259
		public string myreportfootertext;

		// Token: 0x04000104 RID: 260
		public StringAlignment myreportfooteralignment;

		// Token: 0x04000105 RID: 261
		public Font myreportfooterfont;

		// Token: 0x04000106 RID: 262
		public Color myreportfootercolor;

		// Token: 0x04000107 RID: 263
		public float myreportfooterspace;

		// Token: 0x04000108 RID: 264
		public bool myenablesaveaspdf;

		// Token: 0x04000109 RID: 265
		public bool myenablesaveasimage;

		// Token: 0x0200000E RID: 14
		public enum TheZDXTYPE
		{
			// Token: 0x0400010B RID: 267
			LEFT,
			// Token: 0x0400010C RID: 268
			TOP,
			// Token: 0x0400010D RID: 269
			RIGHT,
			// Token: 0x0400010E RID: 270
			BOTTOM
		}

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000154 RID: 340
		public delegate void MyCl();
	}
}
