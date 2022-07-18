using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000012 RID: 18
	[ToolboxBitmap(typeof(DGVprint), "printer.bmp")]
	[Description("适合打印窗口中单个DataGridView的非可视化打印组件(net2.0)")]
	[Guid("337DA8CE-71EF-4d26-A033-EC72ECD128BF")]
	public class DGVprint : Component, objsafe.IObjectSafety
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x00003084 File Offset: 0x00001284
		[DebuggerNonUserCode]
		public DGVprint(IContainer container) : this()
		{
			if (container != null)
			{
				container.Add(this);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0002CC88 File Offset: 0x0002AE88
		[DebuggerNonUserCode]
		public DGVprint()
		{
			this.myPaperLandscape = false;
			this.ztitle = "表格主标题";
			this.ftitle = "";
			this.ztitlefont = new Font("黑体", 16f, FontStyle.Bold);
			this.ftitlefont = new Font("宋体", 12f);
			this.myprinttype = 1;
			this.bgalignment = StringAlignment.Center;
			this.myzoomtopaperwidth = true;
			this.myautoresizerowheight = false;
			this.myminfontsize = 6f;
			this.myreppagetitle = true;
			this.myprintbackcolor = true;
			this.myborder = "1111";
			this.mylinespace = 50f;
			this.myprintzero = false;
			this.myautowrap = false;
			this.mycolumns = 2;
			this.mycolumnspace = 50f;
			this.mylastpagemode = true;
			this.myfixedcols = 1;
			this.mydocumentname = "DataGridView打印控件";
			this.mypaperkind = PaperKind.A4;
			this.mypapermargin = new Margins(254, 254, 254, 254);
			this.myautoformat = false;
			this.mypagemiddle = "共[总页数]页 第[页码]页";
			this.myfooterfont = new Font("宋体", 9f);
			this.myheaderfont = new Font("宋体", 9f);
			this.mytopfont = new Font("宋体", 10f);
			this.mybottomfont = new Font("宋体", 10f);
			this.myfootercolor = Color.Black;
			this.myheadercolor = Color.Black;
			this.mydefaultcolor = Color.Black;
			this.mygridcolor = Color.Black;
			this.mywatermarktext = "";
			this.mywatermarkfont = new Font("华文行楷", 80f, FontStyle.Bold);
			this.mywatermarkopacity = 128;
			this.mywatermarklandscape = true;
			this.mywatermarkcolor = Color.Red;
			this.myshapedepth = 18;
			this.myisimmediateprint = false;
			this.myisimmediateprintShowPrintDialog = true;
			this.mywindowTitle = "打印预览结果";
			this.myIsDGVCellValignmentCenter = true;
			this.myisaddrowid = false;
			this.myisgroupnewrowid = false;
			this.mysumcolumns = "";
			this.mysumforecolor = default(Color);
			this.mysumbackcolor = default(Color);
			this.mysumfont = new Font("宋体", 10f);
			this.mysortcolumn = "";
			this.mysortmode = ListSortDirection.Ascending;
			this.mygroupcolumn = "";
			this.mygroupnewpage = false;
			this.myTableTopLeftTitleAlign = StringAlignment.Near;
			this.myTableTopMiddleTitleAlign = StringAlignment.Center;
			this.myTableTopRightTitleAlign = StringAlignment.Far;
			this.myTableBottomLeftTitleAlign = StringAlignment.Near;
			this.myTableBottomMiddleTitleAlign = StringAlignment.Center;
			this.myTableBottomRightTitleAlign = StringAlignment.Far;
			this.mySumNumberAlign = StringAlignment.Center;
			this.myisuseAPIprintDialog = false;
			this.myprintername = "";
			this._printcopys = 1;
			this.myisshowprogress = true;
			this.mypapername = "";
			this.mypaperwidth = 0m;
			this.mypaperheight = 0m;
			this.mypagebackgroundimage = null;
			this.myisprintrowheadercolumn = false;
			this.myisshowaboutpage = true;
			this.myisdrawpageheaderline = false;
			this.myisdrawpagefooterline = false;
			this.myisdrawmargin = false;
			this.myisshowunvisiblecolumn = true;
			this.myisautoaddemptyrow = false;
			this.mycaneditprintsettings = true;
			this.myenabledprint = true;
			this.myrowheight = 0f;
			this.myIsShowMessageIfPrinterNotSupportPaper = false;
			this.myreportheadertext = "";
			this.myreportheaderalignment = StringAlignment.Near;
			this.myreportheaderfont = new Font("宋体", 12f);
			this.myreportheadercolor = Color.Black;
			this.myreportheaderspace = 0f;
			this.myreportfootertext = "";
			this.myreportfooteralignment = StringAlignment.Near;
			this.myreportfooterfont = new Font("宋体", 12f);
			this.myreportfootercolor = Color.Black;
			this.myreportfooterspace = 0f;
			this.myenablesaveaspdf = true;
			this.myenablesaveasimage = true;
			this.myenableexportpdf = true;
			this.myenableexportexcel = true;
			this.myenableexportrtf = true;
			this.myenableexporthtml = true;
			this.myZDXtext = "装订线";
			this.myZDXfont = new Font("宋体", 9f);
			this.myZDXtextcolor = Color.Black;
			this.myZDXlinecolor = Color.Black;
			this.myZDXlinestyle = DashStyle.Dash;
			this.myZDXposition = 0f;
			this.myZDXtype = DGVprint.TheZDXTYPE.LEFT;
			this.myisdrawZDX = false;
			this.myprintrange = DGVprint.DGVPrintRange.AllVisibleRowsAndColumns;
			this.myisdrawtablefootereverypage = false;
			this.myisusedoubleline = false;
			this.myouterborder = false;
			this.myouterbordercolor = Color.Black;
			this.myouterborderwidth = 5.08f;
			this.thedoublelinespace = 10.16f;
			this.myEnableChangePageSettings = true;
			this.myEnableChangeTitle = true;
			this.myEnableChangeTableStyle = true;
			this.myEnableChangeTableSettings = true;
			this.myEnableChangeHeaderAndFooter = true;
			this.myEnableChangeGroup = true;
			this.myEnableChangeSum = true;
			this.myEnableChangeZDX = true;
			this.myEnableChangeWaterMark = true;
			this.myEnableChangeScheme = true;
			this.InitializeComponent();
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0002D140 File Offset: 0x0002B340
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				this.myZDXfont.Dispose();
				this.myfooterfont.Dispose();
				this.myheaderfont.Dispose();
				this.myfooterfont.Dispose();
				this.mybottomfont.Dispose();
				this.myheaderfont.Dispose();
				this.ftitlefont.Dispose();
				this.mysumfont.Dispose();
				this.myreportheaderfont.Dispose();
				this.myreportfooterfont.Dispose();
				this.ztitlefont.Dispose();
				this.mywatermarkfont.Dispose();
				this.mytopfont.Dispose();
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003096 File Offset: 0x00001296
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002588 File Offset: 0x00000788
		public void GetInterfaceSafetyOptions(ref Guid riid, ref int supportedOptions, ref int enabledOptions)
		{
			supportedOptions = 3;
			enabledOptions = 3;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002590 File Offset: 0x00000790
		public void SetInterfaceSafetyOptions(ref Guid riid, int optionSetMask, int enabledOptions)
		{
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0002D20C File Offset: 0x0002B40C
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000030AF File Offset: 0x000012AF
		[Description("指示是否显示打印预览前程序预处理的进度条")]
		public bool IsShowProgess
		{
			get
			{
				return this.myisshowprogress;
			}
			set
			{
				this.myisshowprogress = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0002D220 File Offset: 0x0002B420
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000030B8 File Offset: 0x000012B8
		[Description("设置或获取一个值，用于指示控件在打印时的默认打印份数")]
		public short PrintCopys
		{
			get
			{
				return this._printcopys;
			}
			set
			{
				if (value > 0)
				{
					this._printcopys = value;
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0002D238 File Offset: 0x0002B438
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x000030C5 File Offset: 0x000012C5
		[Description("设置一个值，指示打印参数设置界面的\u3000导出为RTF文件\u3000按钮是否可用")]
		public bool EnableExportRTF
		{
			get
			{
				return this.myenableexportrtf;
			}
			set
			{
				this.myenableexportrtf = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0002D24C File Offset: 0x0002B44C
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x000030CE File Offset: 0x000012CE
		[Description("设置一个值，指示打印参数设置界面的\u3000导出为HTML文件\u3000按钮是否可用")]
		public bool EnableExportHtml
		{
			get
			{
				return this.myenableexporthtml;
			}
			set
			{
				this.myenableexporthtml = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002D260 File Offset: 0x0002B460
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000030D7 File Offset: 0x000012D7
		[Description("设置一个值，指示打印参数设置界面的\u3000导出为Excel文件\u3000按钮是否可用")]
		public bool EnableExportExcel
		{
			get
			{
				return this.myenableexportexcel;
			}
			set
			{
				this.myenableexportexcel = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0002D274 File Offset: 0x0002B474
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000030E0 File Offset: 0x000012E0
		[Description("设置一个值，指示打印参数设置界面的\u3000导出为PDF文件\u3000按钮是否可用")]
		public bool EnableExportPDF
		{
			get
			{
				return this.myenableexportpdf;
			}
			set
			{
				this.myenableexportpdf = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0002D288 File Offset: 0x0002B488
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000030E9 File Offset: 0x000012E9
		[Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为PDF 功能是否可用")]
		public bool EnableSaveAsPDF
		{
			get
			{
				return this.myenablesaveaspdf;
			}
			set
			{
				this.myenablesaveaspdf = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0002D29C File Offset: 0x0002B49C
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000030F2 File Offset: 0x000012F2
		[Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为图片 功能是否可用")]
		public bool EnableSaveAsImage
		{
			get
			{
				return this.myenablesaveasimage;
			}
			set
			{
				this.myenablesaveasimage = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000030FB File Offset: 0x000012FB
		[Description("报表头要打印的内容（注：表头内容打印在表格第一页的 主标题 前面）")]
		public string ReportHeaderText
		{
			get
			{
				return this.myreportheadertext;
			}
			set
			{
				this.myreportheadertext = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003104 File Offset: 0x00001304
		[Description("报表头文本对齐方式设置")]
		public StringAlignment ReportHeaderAlignment
		{
			get
			{
				return this.myreportheaderalignment;
			}
			set
			{
				this.myreportheaderalignment = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000310D File Offset: 0x0000130D
		[Description("报表头文本字体设置")]
		public Font ReportHeaderFont
		{
			get
			{
				Font result;
				if (this.myreportheaderfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myreportheaderfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.myreportheaderfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0002D30C File Offset: 0x0002B50C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003123 File Offset: 0x00001323
		[Description("报表头打印文本的前景颜色")]
		public Color ReportHeaderForeColor
		{
			get
			{
				return this.myreportheadercolor;
			}
			set
			{
				this.myreportheadercolor = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0002D324 File Offset: 0x0002B524
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000312C File Offset: 0x0000132C
		[Description("报表头打印内容与表格主标题之间的间距（以百分之一厘米为单位，默认为0）")]
		public float ReportHeaderSpace
		{
			get
			{
				return this.myreportheaderspace;
			}
			set
			{
				this.myreportheaderspace = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0002D33C File Offset: 0x0002B53C
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003135 File Offset: 0x00001335
		[Description("报表尾要打印的内容（注：表尾内容打印在表格最后一页的后面）")]
		public string ReportFooterText
		{
			get
			{
				return this.myreportfootertext;
			}
			set
			{
				this.myreportfootertext = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0002D354 File Offset: 0x0002B554
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000313E File Offset: 0x0000133E
		[Description("报表尾文本对齐方式设置")]
		public StringAlignment ReportFooterAlignment
		{
			get
			{
				return this.myreportfooteralignment;
			}
			set
			{
				this.myreportfooteralignment = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0002D36C File Offset: 0x0002B56C
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003147 File Offset: 0x00001347
		[Description("报表尾文本字体设置")]
		public Font ReportFooterFont
		{
			get
			{
				Font result;
				if (this.myreportfooterfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myreportfooterfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.myreportfooterfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0002D398 File Offset: 0x0002B598
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000315D File Offset: 0x0000135D
		[Description("报表尾打印文本的前景颜色")]
		public Color ReportFooterForeColor
		{
			get
			{
				return this.myreportfootercolor;
			}
			set
			{
				this.myreportfootercolor = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0002D3B0 File Offset: 0x0002B5B0
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003166 File Offset: 0x00001366
		[Description("报表尾打印内容与表格尾部打印内容之间的间距（以百分之一厘米为单位，默认为0）")]
		public float ReportFooterSpace
		{
			get
			{
				return this.myreportfooterspace;
			}
			set
			{
				this.myreportfooterspace = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0002D3C8 File Offset: 0x0002B5C8
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0000316F File Offset: 0x0000136F
		[Description("行高(毫米)，不含列标题行，为0表示未设置，小于0表示最小行高，大于0表示固定行高")]
		public float RowHeight
		{
			get
			{
				return this.myrowheight;
			}
			set
			{
				this.myrowheight = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003178 File Offset: 0x00001378
		[Description("设置或获取一个值，用于指定是否打印装订线")]
		public bool IsDrawZDX
		{
			get
			{
				return this.myisdrawZDX;
			}
			set
			{
				this.myisdrawZDX = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003181 File Offset: 0x00001381
		[Description("装订线的类型，是靠纸张的左边、上边、右边、下边的哪一边装订")]
		public DGVprint.TheZDXTYPE ZDXType
		{
			get
			{
				return this.myZDXtype;
			}
			set
			{
				this.myZDXtype = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0002D40C File Offset: 0x0002B60C
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000318A File Offset: 0x0000138A
		[Description("指定装订线距纸张边界的大小（以1/100厘米为计量单位）。为0表示打印在页边距的中间，为其他值则表示距纸张边界的距离")]
		public float ZDXPosition
		{
			get
			{
				return this.myZDXposition;
			}
			set
			{
				this.myZDXposition = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0002D424 File Offset: 0x0002B624
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003193 File Offset: 0x00001393
		[Description("要打印的装订线中线条的类型")]
		public DashStyle ZDXLineStyle
		{
			get
			{
				return this.myZDXlinestyle;
			}
			set
			{
				this.myZDXlinestyle = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0002D43C File Offset: 0x0002B63C
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0000319C File Offset: 0x0000139C
		[Description("装订线线条的颜色")]
		public Color ZDXLinecoLor
		{
			get
			{
				return this.myZDXlinecolor;
			}
			set
			{
				this.myZDXlinecolor = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0002D454 File Offset: 0x0002B654
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000031A5 File Offset: 0x000013A5
		[Description("装订线文本的打印颜色")]
		public Color ZDXTextColor
		{
			get
			{
				return this.myZDXtextcolor;
			}
			set
			{
				this.myZDXtextcolor = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0002D46C File Offset: 0x0002B66C
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0002D498 File Offset: 0x0002B698
		[Description("装订线中文本打印的字体")]
		public Font ZDXFont
		{
			get
			{
				Font result;
				if (this.myZDXfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myZDXfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					try
					{
						this.myZDXfont = (Font)value.Clone();
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0002D4DC File Offset: 0x0002B6DC
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000031AE File Offset: 0x000013AE
		[Description("装订线中要打印的文本内容")]
		public string ZDXText
		{
			get
			{
				return this.myZDXtext;
			}
			set
			{
				this.myZDXtext = value;
				this.myZDXtext = this.myZDXtext.Replace("\r\n", "");
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000031D2 File Offset: 0x000013D2
		[Description("指示在使用Print函数传递了方案文件的情况下，在弹出的打印参数设置窗口中，是否允许用户单击 保存方案文件 按钮将当前设置参数覆盖当前方案文件")]
		public bool EnableChangeScheme
		{
			get
			{
				return this.myEnableChangeScheme;
			}
			set
			{
				this.myEnableChangeScheme = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0002D508 File Offset: 0x0002B708
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000031DB File Offset: 0x000013DB
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改水印打印设置（如是水印打印内容、字体、字号等）")]
		public bool EnableChangeWaterMark
		{
			get
			{
				return this.myEnableChangeWaterMark;
			}
			set
			{
				this.myEnableChangeWaterMark = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0002D51C File Offset: 0x0002B71C
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000031E4 File Offset: 0x000013E4
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改装订线打印参数设置")]
		public bool EnableChangeZDX
		{
			get
			{
				return this.myEnableChangeZDX;
			}
			set
			{
				this.myEnableChangeZDX = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0002D530 File Offset: 0x0002B730
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000031ED File Offset: 0x000013ED
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改汇总设置（包括要汇总的列，汇总颜色设置等）")]
		public bool EnableChangeSum
		{
			get
			{
				return this.myEnableChangeSum;
			}
			set
			{
				this.myEnableChangeSum = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0002D544 File Offset: 0x0002B744
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000031F6 File Offset: 0x000013F6
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改分组与排序设置")]
		public bool EnableChangeGroup
		{
			get
			{
				return this.myEnableChangeGroup;
			}
			set
			{
				this.myEnableChangeGroup = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0002D558 File Offset: 0x0002B758
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000031FF File Offset: 0x000013FF
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改页眉与页脚设置（包括页眉与页脚的打印内容、字体等等）")]
		public bool EnableChangeHeaderAndFooter
		{
			get
			{
				return this.myEnableChangeHeaderAndFooter;
			}
			set
			{
				this.myEnableChangeHeaderAndFooter = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0002D56C File Offset: 0x0002B76C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003208 File Offset: 0x00001408
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改表格详细设置（如表格的列对齐方式、字体、颜色等等）")]
		public bool EnableChangeTableSettings
		{
			get
			{
				return this.myEnableChangeTableSettings;
			}
			set
			{
				this.myEnableChangeTableSettings = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0002D580 File Offset: 0x0002B780
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003211 File Offset: 0x00001411
		[Description("指示在弹出的打印参数设置窗口中，是否允许更改表格的打印样式设置（即是否允许在普通打印、跨页打印、多栏打印、工资条打印之间更改）")]
		public bool EnableChangeTableStyle
		{
			get
			{
				return this.myEnableChangeTableStyle;
			}
			set
			{
				this.myEnableChangeTableStyle = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0002D594 File Offset: 0x0002B794
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000321A File Offset: 0x0000141A
		[Description("在弹出的打印参数设置窗口中，是否允许更改标题设置（包括主标题、辅标题和表格页眉与表格页脚）")]
		public bool EnableChangeTitle
		{
			get
			{
				return this.myEnableChangeTitle;
			}
			set
			{
				this.myEnableChangeTitle = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003223 File Offset: 0x00001423
		[Description("在弹出的打印参数设置窗口中，是否允许更改页面设置（如纸张、打印方向、页边距)")]
		public bool EnableChangePageSettings
		{
			get
			{
				return this.myEnableChangePageSettings;
			}
			set
			{
				this.myEnableChangePageSettings = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000322C File Offset: 0x0000142C
		[Description("表格外边框颜色，仅当OuterBorder为True时有效")]
		public Color OuterBorderColor
		{
			get
			{
				return this.myouterbordercolor;
			}
			set
			{
				this.myouterbordercolor = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003235 File Offset: 0x00001435
		[Description("表格外边框宽度，以1/100厘米为计量单位，仅当OuterBorder为True时有效")]
		public float OuterBorderWidth
		{
			get
			{
				return this.myouterborderwidth;
			}
			set
			{
				if (value >= 0f)
				{
					this.myouterborderwidth = value;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0002D5EC File Offset: 0x0002B7EC
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003246 File Offset: 0x00001446
		[Description("指示在打印DataGridView时，是否在表格外添加外边框。")]
		public bool OuterBorder
		{
			get
			{
				return this.myouterborder;
			}
			set
			{
				this.myouterborder = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0002D600 File Offset: 0x0002B800
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000324F File Offset: 0x0000144F
		[Description("设置或获取双线条打印DGV时双线之间的间距（以1/100厘米为计量单位），仅当以双线条样式打印DataGridView时有效（将属性IsUseDoubleLine为true）")]
		public float DoubleLineSpace
		{
			get
			{
				return this.thedoublelinespace;
			}
			set
			{
				if (value >= 0f)
				{
					this.thedoublelinespace = value;
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0002D618 File Offset: 0x0002B818
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003260 File Offset: 0x00001460
		[Description("指示在打印DataGridView时，是否使用双线框打印")]
		public bool IsUseDoubleLine
		{
			get
			{
				return this.myisusedoubleline;
			}
			set
			{
				this.myisusedoubleline = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0002D62C File Offset: 0x0002B82C
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003269 File Offset: 0x00001469
		[Description("指示打印DataGridView时(指定了表格页脚的情况下,对多栏打印（MulColsPrint）及工资条形式打印无效），表格页脚是否每一页都打印。为True表示每一页都打印表格页脚，为False表示仅表格的最后一页打印")]
		public bool IsDrawTableFooterEveryPage
		{
			get
			{
				return this.myisdrawtablefootereverypage;
			}
			set
			{
				this.myisdrawtablefootereverypage = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0002D640 File Offset: 0x0002B840
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003272 File Offset: 0x00001472
		[Description("设置要打印的DataGridView的打印行或列的范围(是打印全部内容还是只打印选中部分的内容等。注意，如果打印选中部分内容（值为AllVisibleRowsAndColumns之外的其他值），则此时会忽略IsPrintRowHeaderColumn属性，即行标题列将永远不会打印）")]
		public DGVprint.DGVPrintRange PrintRange
		{
			get
			{
				return this.myprintrange;
			}
			set
			{
				this.myprintrange = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0002D658 File Offset: 0x0002B858
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x0000327B File Offset: 0x0000147B
		[Description("设置或获取一个值，用于指示打印预览窗口工具栏中的 打印 按钮是否可用，为true表示可用，为false表示不可用")]
		public bool EnabledPrint
		{
			get
			{
				return this.myenabledprint;
			}
			set
			{
				this.myenabledprint = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0002D66C File Offset: 0x0002B86C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003284 File Offset: 0x00001484
		[Description("设置或获取一个值，用于指示打印预览窗口中的 更改打印参数 按钮是否可用")]
		public bool CanEditPrintSettings
		{
			get
			{
				return this.mycaneditprintsettings;
			}
			set
			{
				this.mycaneditprintsettings = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0002D680 File Offset: 0x0002B880
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000328D File Offset: 0x0000148D
		[Description("指示打印DataGridView时，是否自动加添空行以正好填满纸张高度。注意，对工资条打印无效，分栏打印可以自动添加空行，但此时请不要设置表格页脚，不然表格页脚打印位置不正确")]
		public bool IsAutoAddEmptyRow
		{
			get
			{
				return this.myisautoaddemptyrow;
			}
			set
			{
				this.myisautoaddemptyrow = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0002D694 File Offset: 0x0002B894
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003296 File Offset: 0x00001496
		[Description("设置或获取一个值，指示在打印参数设置窗口中是否显示不可见的列。注意，在打印复杂表头的DGV的情况下该参数无效。")]
		public bool IsShowUnvisibleColum
		{
			get
			{
				return this.myisshowunvisiblecolumn;
			}
			set
			{
				this.myisshowunvisiblecolumn = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000329F File Offset: 0x0000149F
		[Description("设置或获取一个值，指示是否在打印预览时画出页边距")]
		public bool IsDrawmargin
		{
			get
			{
				return this.myisdrawmargin;
			}
			set
			{
				this.myisdrawmargin = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x000032A8 File Offset: 0x000014A8
		[Description("是否在页眉与正文之间画一条横线，以便区分页眉与正文")]
		public bool IsDrawPageHeaderLine
		{
			get
			{
				return this.myisdrawpageheaderline;
			}
			set
			{
				this.myisdrawpageheaderline = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x000032B1 File Offset: 0x000014B1
		[Description("是否在正文与页脚之间画一条横线，以便区分正文与页脚")]
		public bool IsDrawPageFooterLine
		{
			get
			{
				return this.myisdrawpagefooterline;
			}
			set
			{
				this.myisdrawpagefooterline = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x000032BA File Offset: 0x000014BA
		[Browsable(false)]
		[Description("该属性已废除")]
		public bool IsShowAboutPage
		{
			get
			{
				return this.myisshowaboutpage;
			}
			set
			{
				this.myisshowaboutpage = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x000032C3 File Offset: 0x000014C3
		[Description("指示是否打印DGV控件的行标题列(该列通常不需要打印,除非您额外编写代码在该列显示数据需要打印)")]
		public bool IsPrintRowHeaderColumn
		{
			get
			{
				return this.myisprintrowheadercolumn;
			}
			set
			{
				this.myisprintrowheadercolumn = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0002D70C File Offset: 0x0002B90C
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x000032CC File Offset: 0x000014CC
		[Description("设置汇总行的汇总数据(如果有汇总行的话)的水平对齐方式")]
		public StringAlignment SumNumberAlign
		{
			get
			{
				return this.mySumNumberAlign;
			}
			set
			{
				this.mySumNumberAlign = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0002D724 File Offset: 0x0002B924
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x000032D5 File Offset: 0x000014D5
		[Description("设置表格页脚右边打印内容的对齐方式")]
		public StringAlignment TableBottomRightTitleAlign
		{
			get
			{
				return this.myTableBottomRightTitleAlign;
			}
			set
			{
				this.myTableBottomRightTitleAlign = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0002D73C File Offset: 0x0002B93C
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000032DE File Offset: 0x000014DE
		[Description("设置表格页脚中间打印内容的对齐方式")]
		public StringAlignment TableBottomMiddleTitleAlign
		{
			get
			{
				return this.myTableBottomMiddleTitleAlign;
			}
			set
			{
				this.myTableBottomMiddleTitleAlign = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0002D754 File Offset: 0x0002B954
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000032E7 File Offset: 0x000014E7
		[Description("设置表格页脚左边打印内容的对齐方式")]
		public StringAlignment TableBottomLeftTitleAlign
		{
			get
			{
				return this.myTableBottomLeftTitleAlign;
			}
			set
			{
				this.myTableBottomLeftTitleAlign = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0002D76C File Offset: 0x0002B96C
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000032F0 File Offset: 0x000014F0
		[Description("设置表格页眉右边打印内容的对齐方式")]
		public StringAlignment TableTopRightTitleAlign
		{
			get
			{
				return this.myTableTopRightTitleAlign;
			}
			set
			{
				this.myTableTopRightTitleAlign = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0002D784 File Offset: 0x0002B984
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000032F9 File Offset: 0x000014F9
		[Description("设置表格页眉中间打印内容的对齐方式")]
		public StringAlignment TableTopMiddleTitleAlign
		{
			get
			{
				return this.myTableTopMiddleTitleAlign;
			}
			set
			{
				this.myTableTopMiddleTitleAlign = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0002D79C File Offset: 0x0002B99C
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003302 File Offset: 0x00001502
		[Description("设置表格页眉左边打印内容的对齐方式")]
		public StringAlignment TableTopLeftTitleAlign
		{
			get
			{
				return this.myTableTopLeftTitleAlign;
			}
			set
			{
				this.myTableTopLeftTitleAlign = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0002D7B4 File Offset: 0x0002B9B4
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000330B File Offset: 0x0000150B
		[Description("设置自定义纸张的宽度，以毫米为计量单位，该属性仅当PaperKind属性设置为Custom(0)时才有效，否则该值无任何作用")]
		public decimal PaperWidth
		{
			get
			{
				return this.mypaperwidth;
			}
			set
			{
				if (decimal.Compare(value, 0m) >= 0)
				{
					if (decimal.Compare(value, 15000m) > 0)
					{
						value = 15000m;
					}
					this.mypaperwidth = value;
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0002D7CC File Offset: 0x0002B9CC
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003349 File Offset: 0x00001549
		[Description("设置自定义纸张的高度，以毫米为计量单位,最大值15000，该属性仅当PaperKind属性设置为Custom(0)时才有效，否则该值无任何作用")]
		public decimal PaperHeight
		{
			get
			{
				return this.mypaperheight;
			}
			set
			{
				if (decimal.Compare(value, 0m) >= 0)
				{
					if (decimal.Compare(value, 15000m) > 0)
					{
						value = 15000m;
					}
					this.mypaperheight = value;
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003387 File Offset: 0x00001587
		[Description("设置或获取默认使用的打印纸张名称，注意，只有当PaperKind属性设置为Custom(0)时此属性才有效，该属性主要用于指定自定义纸张。")]
		public string PaperName
		{
			get
			{
				return this.mypapername;
			}
			set
			{
				this.mypapername = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0002D7FC File Offset: 0x0002B9FC
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003390 File Offset: 0x00001590
		[Description("设置或获取用于文档打印的默认打印机，为空表示使用计算机当前默认打印机进行打印")]
		public string PrinterName
		{
			get
			{
				return this.myprintername;
			}
			set
			{
				this.myprintername = value.Trim();
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002D814 File Offset: 0x0002BA14
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000339E File Offset: 0x0000159E
		[Description("指示是否使用调用API函数的页面设置和打印机选择对话框，为TRUE表示使用API的，为FALSE表示使用.NET自身的。如果没计划使用自定义纸张进行打印，建议设置为FALSE")]
		public bool IsUseAPIprintDialog
		{
			get
			{
				return this.myisuseAPIprintDialog;
			}
			set
			{
				this.myisuseAPIprintDialog = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002D828 File Offset: 0x0002BA28
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000033A7 File Offset: 0x000015A7
		[Description("设置汇总行的字体")]
		public Font SumFont
		{
			get
			{
				Font result;
				if (this.mysumfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.mysumfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.mysumfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0002D854 File Offset: 0x0002BA54
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x000033BD File Offset: 0x000015BD
		[Description("如果要分组打印（指定了分组列GroupColumn），不同的组是否换新页打印，为TRUE表示不同的组换新页打印，为FALSE表示不同的分组连续打印")]
		public bool GroupNewPage
		{
			get
			{
				return this.mygroupnewpage;
			}
			set
			{
				this.mygroupnewpage = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0002D868 File Offset: 0x0002BA68
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x000033C6 File Offset: 0x000015C6
		[Description("指定要分组的列（指列的名称而非列的显示文本），只能指定一个列，为空表示不分组。注意，如果要分组打印或汇总，您应当先按要分组的列排序，或都同时将要分组的列设置为排序列（SortColumn，请参见该列说明），否则本控件是不会自动按分组列进行排序的。")]
		public string GroupColumn
		{
			get
			{
				return this.mygroupcolumn;
			}
			set
			{
				this.mygroupcolumn = value + "";
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0002D880 File Offset: 0x0002BA80
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x000033D9 File Offset: 0x000015D9
		[Description("指定排序列（SortColumn）的排序方式，升序或降序")]
		public ListSortDirection SortMode
		{
			get
			{
				return this.mysortmode;
			}
			set
			{
				this.mysortmode = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0002D898 File Offset: 0x0002BA98
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x000033E2 File Offset: 0x000015E2
		[Description("设置打印DataGridVie时要排序的列（指列的名称而非列的显示文本），只能指定一个列，为空表示不排序。注意，控件总是将列当作文本列来排序，因此您应当指定文本列做为排序列，否则排序的结果可能不是您预期的结果。如果要排序的列不是文本列，您应当在调用本控件打印前先排好序，然后指定此属性为空")]
		public string SortColumn
		{
			get
			{
				return this.mysortcolumn;
			}
			set
			{
				this.mysortcolumn = value + "";
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x000033F5 File Offset: 0x000015F5
		[Description("设置汇总或分组汇总行的背景颜色")]
		public Color SumBackColor
		{
			get
			{
				return this.mysumbackcolor;
			}
			set
			{
				this.mysumbackcolor = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0002D8C8 File Offset: 0x0002BAC8
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000033FE File Offset: 0x000015FE
		[Description("设置汇总或分组汇总行的前景颜色")]
		public Color SumForeColor
		{
			get
			{
				return this.mysumforecolor;
			}
			set
			{
				this.mysumforecolor = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0002D8E0 File Offset: 0x0002BAE0
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003407 File Offset: 0x00001607
		[Description("在分组打印的情况下（GroupColumn属性设置了要分组的列），如果要在第一列前添加行号（isaddrowid属性为TRUE），新的分组的行号是否从1开始重新编号。为TRUE表示不同的组重新从1开始算行号，为FALSE表示整个表格行号连续编号")]
		public bool IsGroupNewRowID
		{
			get
			{
				return this.myisgroupnewrowid;
			}
			set
			{
				this.myisgroupnewrowid = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003410 File Offset: 0x00001610
		[Description("设置要进行汇总的列（指的是列的名称而不是列显示的文本），可以有多列，各列之间请用英文的分号;分隔。为空表示不汇总")]
		public string SumColumns
		{
			get
			{
				return this.mysumcolumns;
			}
			set
			{
				this.mysumcolumns = value + "";
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0002D90C File Offset: 0x0002BB0C
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003423 File Offset: 0x00001623
		[Description("是否在第一列前添加行号")]
		public bool IsAddRowID
		{
			get
			{
				return this.myisaddrowid;
			}
			set
			{
				this.myisaddrowid = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002D920 File Offset: 0x0002BB20
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000342C File Offset: 0x0000162C
		[Description("打印DataGridView时,单元格文本垂直对齐方式是统一使用居中对齐打印,还是和水平对齐一样都使用DataGridView单元格本身的格式设置")]
		public bool IsDGVCellValignmentCenter
		{
			get
			{
				return this.myIsDGVCellValignmentCenter;
			}
			set
			{
				this.myIsDGVCellValignmentCenter = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0002D934 File Offset: 0x0002BB34
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003435 File Offset: 0x00001635
		[Description("打印预览窗口标题栏要显示的文本")]
		public string WindowTitle
		{
			get
			{
				return this.mywindowTitle;
			}
			set
			{
				this.mywindowTitle = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0002D94C File Offset: 0x0002BB4C
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0000343E File Offset: 0x0000163E
		[Description("是否立即打印而不显示打印预览窗口")]
		public bool IsImmediatePrint
		{
			get
			{
				return this.myisimmediateprint;
			}
			set
			{
				this.myisimmediateprint = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0002D960 File Offset: 0x0002BB60
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003447 File Offset: 0x00001647
		[Description("如果IsImmediatePrint属性为TRUE，打印前是否显示选择打印机打印的对话框，默认为TRUE")]
		public bool IsImmediatePrintShowPrintDialog
		{
			get
			{
				return this.myisimmediateprintShowPrintDialog;
			}
			set
			{
				this.myisimmediateprintShowPrintDialog = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002D974 File Offset: 0x0002BB74
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00003450 File Offset: 0x00001650
		[Description("设置或获取一个值，指示如果打印机不支持当前所使用的纸张，在输出到打印机前是否给出提示信息")]
		public bool IsShowMessageIfPrinterNotSupportPaper
		{
			get
			{
				return this.myIsShowMessageIfPrinterNotSupportPaper;
			}
			set
			{
				this.myIsShowMessageIfPrinterNotSupportPaper = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002D988 File Offset: 0x0002BB88
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003459 File Offset: 0x00001659
		[Description("表格主标题文字的打印样式(为0到6,代表6种不同的文字打印方式,0表示普通文字,详情请参见帮助文件")]
		public int TitleTextStyle
		{
			get
			{
				return this.mytitletextstyle;
			}
			set
			{
				if (value < 0 | value > 6)
				{
					value = 0;
				}
				this.mytitletextstyle = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003470 File Offset: 0x00001670
		[Description("表格辅标题文字的打印样式(为0到6,代表6种不同的文字打印方式,0表示普通文字,详情请参见帮助文件")]
		public int SubTitleStyle
		{
			get
			{
				return this.mysubtitlestyle;
			}
			set
			{
				if (value < 0 | value > 6)
				{
					value = 0;
				}
				this.mysubtitlestyle = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003487 File Offset: 0x00001687
		[Description("设置要打印水印的文字,为空字符串表示不打印水印")]
		public string WaterMarkText
		{
			get
			{
				return this.mywatermarktext;
			}
			set
			{
				this.mywatermarktext = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002D9D0 File Offset: 0x0002BBD0
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003490 File Offset: 0x00001690
		[Description("设置要打印的水印的文字的字体字号")]
		public Font WaterMarkFont
		{
			get
			{
				Font result;
				if (this.mywatermarkfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.mywatermarkfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.mywatermarkfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0002D9FC File Offset: 0x0002BBFC
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000034A6 File Offset: 0x000016A6
		[Description("设置要打印的水印的文字方向,TRUE表示水印文字横着打印,为FALSE表示水印文字竖着打印")]
		public bool WaterMarkLandscape
		{
			get
			{
				return this.mywatermarklandscape;
			}
			set
			{
				this.mywatermarklandscape = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0002DA10 File Offset: 0x0002BC10
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x000034AF File Offset: 0x000016AF
		[Description("设置要打印的水印的透明程度,0表示完全透明,255表示完全不透明")]
		public byte WaterMarkOpacity
		{
			get
			{
				return this.mywatermarkopacity;
			}
			set
			{
				this.mywatermarkopacity = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0002DA28 File Offset: 0x0002BC28
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x000034B8 File Offset: 0x000016B8
		[Description("设置要打印的水印的文字的打印颜色")]
		public Color WaterMarkColor
		{
			get
			{
				return this.mywatermarkcolor;
			}
			set
			{
				this.mywatermarkcolor = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0002DA40 File Offset: 0x0002BC40
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x000034C1 File Offset: 0x000016C1
		[Description("用DrawText、DrawCell等函数打印输出文字时，如果最后一个参数textoutstyle不为0(即输出除普通文字外的其他形式的特效文字时),要打印特效文字的深度(1/100厘米)")]
		public int ShapeDepth
		{
			get
			{
				return this.myshapedepth;
			}
			set
			{
				this.myshapedepth = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0002DA58 File Offset: 0x0002BC58
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x000034CA File Offset: 0x000016CA
		[Description("是否打印表格的背景颜色")]
		public bool PrintBackColor
		{
			get
			{
				return this.myprintbackcolor;
			}
			set
			{
				this.myprintbackcolor = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0002DA6C File Offset: 0x0002BC6C
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x000034D3 File Offset: 0x000016D3
		[Description("打印表格的表格线颜色")]
		public Color GridColor
		{
			get
			{
				return this.mygridcolor;
			}
			set
			{
				this.mygridcolor = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0002DA84 File Offset: 0x0002BC84
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x000034DC File Offset: 0x000016DC
		[Description("表格页脚右边要打印的内容，不会每页打印，仅在最后一页的尾部打印")]
		public string TableFooterRight
		{
			get
			{
				return this.mytableright;
			}
			set
			{
				this.mytableright = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0002DA9C File Offset: 0x0002BC9C
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x000034E5 File Offset: 0x000016E5
		[Description("表格页脚中间要打印的内容，不会每页打印，仅在最后一页的尾部打印")]
		public string TableFooterMiddle
		{
			get
			{
				return this.mytablemiddle;
			}
			set
			{
				this.mytablemiddle = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x000034EE File Offset: 0x000016EE
		[Description("表格页脚左边要打印的内容，不会每页打印，仅在最后一页的尾部打印")]
		public string TableFooterLeft
		{
			get
			{
				return this.mytableleft;
			}
			set
			{
				this.mytableleft = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0002DACC File Offset: 0x0002BCCC
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x000034F7 File Offset: 0x000016F7
		[Description("表格页眉右边要打印的内容，如果标题行设置为每页重复打印，则表格页眉也会每页重复打印，否则只在首页打印")]
		public string TableHeaderRight
		{
			get
			{
				return this.mytabler;
			}
			set
			{
				this.mytabler = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00003500 File Offset: 0x00001700
		[Description("表格页眉中间要打印的内容，如果标题行设置为每页重复打印，则表格页眉也会每页重复打印，否则只在首页打印")]
		public string TableHeaderMiddle
		{
			get
			{
				return this.mytablem;
			}
			set
			{
				this.mytablem = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00003509 File Offset: 0x00001709
		[Description("表格页眉左边要打印的内容，如果标题行设置为每页重复打印，则表格页眉也会每页重复打印，否则只在首页打印")]
		public string TableHeaderLeft
		{
			get
			{
				return this.mytablel;
			}
			set
			{
				this.mytablel = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0002DB14 File Offset: 0x0002BD14
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003512 File Offset: 0x00001712
		[Description("页面页脚右边要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageFooterRight
		{
			get
			{
				return this.mypageright;
			}
			set
			{
				this.mypageright = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0002DB2C File Offset: 0x0002BD2C
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000351B File Offset: 0x0000171B
		[Description("页面页脚中间要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageFooterMiddle
		{
			get
			{
				return this.mypagemiddle;
			}
			set
			{
				this.mypagemiddle = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0002DB44 File Offset: 0x0002BD44
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003524 File Offset: 0x00001724
		[Description("页面页脚左边要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageFooterLeft
		{
			get
			{
				return this.mypageleft;
			}
			set
			{
				this.mypageleft = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000352D File Offset: 0x0000172D
		[Description("页面页眉右边要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageHeaderRight
		{
			get
			{
				return this.mypager;
			}
			set
			{
				this.mypager = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0002DB74 File Offset: 0x0002BD74
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003536 File Offset: 0x00001736
		[Description("页面页眉中间要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageHeaderMiddle
		{
			get
			{
				return this.mypagem;
			}
			set
			{
				this.mypagem = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0002DB8C File Offset: 0x0002BD8C
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0000353F File Offset: 0x0000173F
		[Description("页面页眉左边要打印的内容（可用 [页码] 表示当前页码， [总页数] 表示文档总的页码）")]
		public string PageHeaderLeft
		{
			get
			{
				return this.mypagel;
			}
			set
			{
				this.mypagel = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003548 File Offset: 0x00001748
		[Description("默认前景颜色设置（仅对主标题、小标题、表格页眉、表格页脚有效）")]
		public Color DefaultColor
		{
			get
			{
				return this.mydefaultcolor;
			}
			set
			{
				this.mydefaultcolor = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0002DBBC File Offset: 0x0002BDBC
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003551 File Offset: 0x00001751
		[Description("页面页脚颜色设置")]
		public Color PageFooterColor
		{
			get
			{
				return this.myfootercolor;
			}
			set
			{
				this.myfootercolor = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x0000355A File Offset: 0x0000175A
		[Description("页面页眉颜色设置")]
		public Color PageHeaderColor
		{
			get
			{
				return this.myheadercolor;
			}
			set
			{
				this.myheadercolor = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0002DBEC File Offset: 0x0002BDEC
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003563 File Offset: 0x00001763
		[Description("表格页脚字体设置")]
		public Font TableFooterFont
		{
			get
			{
				Font result;
				if (this.mybottomfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.mybottomfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.mybottomfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0002DC18 File Offset: 0x0002BE18
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003579 File Offset: 0x00001779
		[Description("表格页眉字体设置")]
		public Font TableHeaderFont
		{
			get
			{
				Font result;
				if (this.mytopfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.mytopfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.mytopfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0002DC44 File Offset: 0x0002BE44
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0000358F File Offset: 0x0000178F
		[Description("页面页脚字体设置")]
		public Font PageFooterFont
		{
			get
			{
				Font result;
				if (this.myfooterfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myfooterfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.myfooterfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0002DC70 File Offset: 0x0002BE70
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000035A5 File Offset: 0x000017A5
		[Description("页面页眉字体设置")]
		public Font PageHeaderFont
		{
			get
			{
				Font result;
				if (this.myheaderfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myheaderfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.myheaderfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0002DC9C File Offset: 0x0002BE9C
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x000035BB File Offset: 0x000017BB
		[Description("指定是否自动对表格的行高与列宽进行调整，自动调整的过程是，先调整列宽，再调整为单行高")]
		public bool AutoFormat
		{
			get
			{
				return this.myautoformat;
			}
			set
			{
				this.myautoformat = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		[Description("指定页面边距,单位为1/100厘米")]
		public Margins PaperMargins
		{
			get
			{
				return new Margins
				{
					Left = this.mypapermargin.Left,
					Top = this.mypapermargin.Top,
					Bottom = this.mypapermargin.Bottom,
					Right = this.mypapermargin.Right
				};
			}
			set
			{
				this.mypapermargin.Left = value.Left;
				this.mypapermargin.Top = value.Top;
				this.mypapermargin.Bottom = value.Bottom;
				this.mypapermargin.Right = value.Right;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0002DD60 File Offset: 0x0002BF60
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000035C4 File Offset: 0x000017C4
		[Description("设置打印纸张类型，如果是自定义纸张，请将此处设置为0，然后设置PaperName属性，请参见帮助文件中的自定义纸的使用")]
		public PaperKind PaperKind
		{
			get
			{
				return this.mypaperkind;
			}
			set
			{
				this.mypaperkind = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0002DD78 File Offset: 0x0002BF78
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000035CD File Offset: 0x000017CD
		[Description("设置要打印的文档的名称,该名称将显示在打印任务中")]
		public string DocuMentName
		{
			get
			{
				return this.mydocumentname;
			}
			set
			{
				this.mydocumentname = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0002DD90 File Offset: 0x0002BF90
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000035D6 File Offset: 0x000017D6
		[Description("在横向跨页打印DataGridView表格时,每页都要重复打印的左边固定列的列数,仅当PrintType属性为跨页打印MulPagesPrint时才有效")]
		public int FixedCols
		{
			get
			{
				return this.myfixedcols;
			}
			set
			{
				if (value <= 0)
				{
					value = 0;
				}
				this.myfixedcols = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0002DDA8 File Offset: 0x0002BFA8
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x000035E6 File Offset: 0x000017E6
		[Description("在以多栏形式打印DataGridView的情况下,最后一页的打印方式,为TRUE表示最后一页先打印满各栏上边的内容,为FALSE表示先打印满左边栏的内容,仅当PrintType属性为多栏打印MulColsPrint时才有效")]
		public bool LastPageMode
		{
			get
			{
				return this.mylastpagemode;
			}
			set
			{
				this.mylastpagemode = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x000035EF File Offset: 0x000017EF
		[Description("指定栏间距(以1/100厘米为单位),仅当PrintType属性为多栏打印MulColsPrint时才有效")]
		public float ColumnSpace
		{
			get
			{
				return this.mycolumnspace;
			}
			set
			{
				this.mycolumnspace = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x000035F8 File Offset: 0x000017F8
		[Description("指定每页要打印的栏数,仅当PrintType属性为多栏打印MulColsPrint时才有效")]
		public int Columns
		{
			get
			{
				return this.mycolumns;
			}
			set
			{
				if (value <= 0)
				{
					value = 1;
				}
				this.mycolumns = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0002DDEC File Offset: 0x0002BFEC
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003608 File Offset: 0x00001808
		[Description("以工资条形式打印时,为零值和空值的列是否要打印,TRUE表示打印,FALSE表示不打印,仅对PrintType属性为工资条形式打印GZTPrint有效")]
		public bool PrintZero
		{
			get
			{
				return this.myprintzero;
			}
			set
			{
				this.myprintzero = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0002DE00 File Offset: 0x0002C000
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00003611 File Offset: 0x00001811
		[Description("以工资条形式打印时,若一行打印不下，是否自动换行续打,仅对PrintType属性为工资条形式打印GZTPrint有效")]
		public bool AutoWrap
		{
			get
			{
				return this.myautowrap;
			}
			set
			{
				this.myautowrap = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0002DE14 File Offset: 0x0002C014
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000361A File Offset: 0x0000181A
		[Description("以工资条形式打印时,每项工资条之间的行间距(以1/100厘米为单),仅对PrintType属性为工资条形式打印GZTPrint时有效")]
		public float LineSpace
		{
			get
			{
				return this.mylinespace;
			}
			set
			{
				this.mylinespace = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0002DE2C File Offset: 0x0002C02C
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00003623 File Offset: 0x00001823
		[Description("打印的表格边框样式,用4位数字的字符串表示(如\"1111\",\"1221\"),分别代表左、上、右、下4条边框的宽度,\"0000\"表示无边框")]
		public string Border
		{
			get
			{
				return this.myborder;
			}
			set
			{
				if (value.Length != 4)
				{
					this.myborder = "1111";
				}
				else if (!Versioned.IsNumeric(value))
				{
					this.myborder = "1111";
				}
				else
				{
					this.myborder = value;
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0002DE44 File Offset: 0x0002C044
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00003657 File Offset: 0x00001857
		[Description("如果表格无法在一页中打印完,是否每一页都重复打印标题(包括主标题.小标题等)")]
		public bool PrintTitlePerPage
		{
			get
			{
				return this.myreppagetitle;
			}
			set
			{
				this.myreppagetitle = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0002DE58 File Offset: 0x0002C058
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00003660 File Offset: 0x00001860
		[Description("如果表格单元格的内容太多而单元格太小时,程序会自动缩小字号打印,此处指定所能缩小到的最小字号")]
		public float MinFontSize
		{
			get
			{
				return this.myminfontsize;
			}
			set
			{
				if (value <= 0f)
				{
					value = 0f;
				}
				this.myminfontsize = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0002DE70 File Offset: 0x0002C070
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00003678 File Offset: 0x00001878
		[Description("DataGridView表格的打印格式,GeneralPrint表示普通表格,MulColsPrint表示多栏打印,MulPagesPrint跨页打印,GZTPrint表示工资条样式打印")]
		public DGVprint.mytype PrintType
		{
			get
			{
				return (DGVprint.mytype)this.myprinttype;
			}
			set
			{
				this.myprinttype = (int)value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0002DE88 File Offset: 0x0002C088
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00003681 File Offset: 0x00001881
		[Description("打印纸张方向,为TRUE表示横向打印,为FALSE表示纵向打印")]
		public bool PaperLandscape
		{
			get
			{
				return this.myPaperLandscape;
			}
			set
			{
				this.myPaperLandscape = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0002DE9C File Offset: 0x0002C09C
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0000368A File Offset: 0x0000188A
		[Description("要打印表格时显示的主标题内容")]
		public string MainTitle
		{
			get
			{
				return this.ztitle;
			}
			set
			{
				this.ztitle = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00003693 File Offset: 0x00001893
		[Description("打印表格时的显示的辅标题(小标题)内容")]
		public string SubTitle
		{
			get
			{
				return this.ftitle;
			}
			set
			{
				this.ftitle = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0002DECC File Offset: 0x0002C0CC
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000369C File Offset: 0x0000189C
		[Description("主标题字体设置")]
		public Font MainTitleFont
		{
			get
			{
				Font result;
				if (this.ztitlefont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.ztitlefont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.ztitlefont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0002DEF8 File Offset: 0x0002C0F8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x000036B2 File Offset: 0x000018B2
		[Description("辅标题(小标题)字体设置")]
		public Font SubTitleFont
		{
			get
			{
				Font result;
				if (this.ftitlefont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.ftitlefont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.ftitlefont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0002DF24 File Offset: 0x0002C124
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x000036C8 File Offset: 0x000018C8
		[Description("打印的DatagridView表格在页面中的水平对齐方式")]
		public StringAlignment Alignment
		{
			get
			{
				return this.bgalignment;
			}
			set
			{
				this.bgalignment = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0002DF3C File Offset: 0x0002C13C
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x000036D1 File Offset: 0x000018D1
		[Description("打印的DataGridView表格是否自动调整为适合纸张宽度")]
		public bool ZoomToPaperWidth
		{
			get
			{
				return this.myzoomtopaperwidth;
			}
			set
			{
				this.myzoomtopaperwidth = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0002DF50 File Offset: 0x0002C150
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x000036DA File Offset: 0x000018DA
		[Description("打印的DataGridView表格是否自动调整行高(对于分栏打印的其他打印方式则只有在ZoomToPaperWidth为TRUE时才有效,对多栏打印总有效(建议设置为TRUE))")]
		public bool AutoResizeRowHeight
		{
			get
			{
				return this.myautoresizerowheight;
			}
			set
			{
				this.myautoresizerowheight = value;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000036E3 File Offset: 0x000018E3
		public void Print(DataGridView DGVtoprint)
		{
			this.Print(DGVtoprint, true);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000036ED File Offset: 0x000018ED
		public void Print(DataGridView DGVtoprint, bool isShowSettingDialog)
		{
			this.Print(DGVtoprint, isShowSettingDialog, "");
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000036FC File Offset: 0x000018FC
		public void Print(DataGridView DGVtoprint, TreeView columnheadertree)
		{
			this.Print(DGVtoprint, true, "", columnheadertree);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000370C File Offset: 0x0000190C
		public void Print(DataGridView DGVtoprint, bool isShowSettingDialog, TreeView columnheadertree)
		{
			this.Print(DGVtoprint, isShowSettingDialog, "", columnheadertree);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000371C File Offset: 0x0000191C
		public void Print(DataGridView DGVtoprint, bool isShowSettingDialog, string schemefilename)
		{
			this.Print(DGVtoprint, isShowSettingDialog, schemefilename, null);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002DF64 File Offset: 0x0002C164
		public void Print(DataGridView DGVtoprint, bool isShowSettingDialog, string schemefilename, TreeView columnheadertree)
		{
			if (DGVtoprint == null)
			{
				Interaction.MsgBox("不能打印，您没有提供合法有数据的的DataGridView控件", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (DGVtoprint.Rows.Count <= 0 | DGVtoprint.ColumnCount <= 0)
			{
				Interaction.MsgBox("要打印的DataGridView表格没有数据，因此不能打印", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				DGVprint.mut.WaitOne();
				if (Module1.myPrintset != null)
				{
					DGVprint.mut.ReleaseMutex();
				}
				else
				{
					Module1.myPrintset = new DataGridViewPrintSet();
					Module1.CopyDataGridViewByDGVCS(DGVtoprint, Module1.myPrintset.dgvtoprint, this);
					if (!this.myisshowunvisiblecolumn && columnheadertree == null)
					{
						Module1.DelDGVAllUnvisibleCols(Module1.myPrintset.dgvtoprint);
					}
					Module1.myPrintset.NeedReadFangAn = true;
					Module1.myPrintset.dgvtoprint.GridColor = this.mygridcolor;
					Module1.myPrintset.printtype = this.myprinttype;
					Module1.myPrintset.PaperLandscape = this.myPaperLandscape;
					Module1.myPrintset.printbackcolor = this.myprintbackcolor;
					Module1.myPrintset.ztitle = this.ztitle;
					Module1.myPrintset.ftitle = this.ftitle;
					Module1.myPrintset.ztitlefont = (Font)this.ztitlefont.Clone();
					Module1.myPrintset.ftitlefont = (Font)this.ftitlefont.Clone();
					Module1.myPrintset.bgalignment = this.bgalignment;
					Module1.myPrintset.zoomtopaperwidth = this.myzoomtopaperwidth;
					Module1.myPrintset.autoresizerowheight = this.myautoresizerowheight;
					Module1.myPrintset.minfontsize = this.myminfontsize;
					Module1.myPrintset.reppagetitle = this.myreppagetitle;
					Module1.myPrintset.myborder = this.myborder;
					Module1.myPrintset.linespace = this.mylinespace;
					Module1.myPrintset.printzero = this.myprintzero;
					Module1.myPrintset.autowrap = this.myautowrap;
					Module1.myPrintset.mycolumns = this.mycolumns;
					Module1.myPrintset.columnspace = this.mycolumnspace;
					Module1.myPrintset.lastpagemode = this.mylastpagemode;
					Module1.myPrintset.fixedcols = this.myfixedcols;
					Module1.myPrintset.documentname = this.mydocumentname;
					Module1.myPrintset.paperkind = this.mypaperkind;
					Module1.myPrintset.mypapermarign = this.mypapermargin;
					Module1.myPrintset.autoformat = this.myautoformat;
					Module1.myPrintset._printcopys = this._printcopys;
					Module1.myPrintset.myisshowprogress = this.myisshowprogress;
					Module1.myPrintset.mypagel = this.mypagel;
					Module1.myPrintset.mypagem = this.mypagem;
					Module1.myPrintset.mypager = this.mypager;
					Module1.myPrintset.mypageleft = this.mypageleft;
					Module1.myPrintset.mypageright = this.mypageright;
					Module1.myPrintset.mypagemiddle = this.mypagemiddle;
					Module1.myPrintset.mytablel = this.mytablel;
					Module1.myPrintset.mytablem = this.mytablem;
					Module1.myPrintset.mytabler = this.mytabler;
					Module1.myPrintset.mytableleft = this.mytableleft;
					Module1.myPrintset.mytablemiddle = this.mytablemiddle;
					Module1.myPrintset.mytableright = this.mytableright;
					Module1.myPrintset.myfooterfont = (Font)this.myfooterfont.Clone();
					Module1.myPrintset.myheaderfont = (Font)this.myheaderfont.Clone();
					Module1.myPrintset.mytopfont = (Font)this.mytopfont.Clone();
					Module1.myPrintset.mybottomfont = (Font)this.mybottomfont.Clone();
					Module1.myPrintset.myfootercolor = this.myfootercolor;
					Module1.myPrintset.myheadercolor = this.myheadercolor;
					Module1.myPrintset.mydefaultcolor = this.mydefaultcolor;
					Module1.myPrintset.mywatermarkcolor = this.mywatermarkcolor;
					Module1.myPrintset.mywatermarkfont = (Font)this.mywatermarkfont.Clone();
					Module1.myPrintset.mywatermarklandscape = this.mywatermarklandscape;
					Module1.myPrintset.mywatermarkopacity = this.mywatermarkopacity;
					Module1.myPrintset.mywatermarktext = this.mywatermarktext;
					Module1.myPrintset.myshapedepth = this.myshapedepth;
					Module1.myPrintset.mytitletextstyle = this.mytitletextstyle;
					Module1.myPrintset.mysubtitlestyle = this.mysubtitlestyle;
					Module1.myPrintset.schemefilename = schemefilename;
					Module1.myPrintset.datarowcount = Module1.myPrintset.dgvtoprint.RowCount;
					Module1.myPrintset.myaddrowid = this.myisaddrowid;
					Module1.myPrintset.mywindowtext = this.mywindowTitle;
					Module1.myPrintset.myIsDGVCellValignmentCenter = this.myIsDGVCellValignmentCenter;
					Module1.myPrintset.myisimmediateprint = this.myisimmediateprint;
					Module1.myPrintset.myaddrowid = this.myisaddrowid;
					Module1.myPrintset.myaddrownew = this.myisgroupnewrowid;
					Module1.myPrintset.myhzcolumns = this.mysumcolumns;
					Module1.myPrintset.myhzforecolor = this.mysumforecolor;
					Module1.myPrintset.myhzbackcolor = this.mysumbackcolor;
					Module1.myPrintset.myhzfont = (Font)this.mysumfont.Clone();
					Module1.myPrintset.mysortcolumn = this.mysortcolumn;
					Module1.myPrintset.myenableexportrtf = this.myenableexportrtf;
					Module1.myPrintset.myenableexportpdf = this.myenableexportpdf;
					Module1.myPrintset.myenableexporthtml = this.myenableexporthtml;
					Module1.myPrintset.myenableexportexcel = this.myenableexportexcel;
					if (this.mysortmode == ListSortDirection.Ascending)
					{
						Module1.myPrintset.mysorttype = true;
					}
					else
					{
						Module1.myPrintset.mysorttype = false;
					}
					Module1.myPrintset.mygroupcolumne = this.mygroupcolumn;
					Module1.myPrintset.mygroupnewpage = this.mygroupnewpage;
					Module1.myPrintset.myheader = columnheadertree;
					Module1.myPrintset.myIsImmediatePrintNotPreviewShowPrintDialog = this.myisimmediateprintShowPrintDialog;
					Module1.myPrintset.myIsShowMessageIfPrinterNotSupportPaper = this.myIsShowMessageIfPrinterNotSupportPaper;
					Module1.myPrintset.currentprintname = this.myprintername;
					Module1.myPrintset.papername = this.mypapername;
					Module1.myPrintset.myisuseAPIprintDialog = this.myisuseAPIprintDialog;
					Module1.myPrintset.myTableBottomLeftTitleAlign = this.myTableBottomLeftTitleAlign;
					Module1.myPrintset.myTableBottomMiddleTitleAlign = this.myTableBottomMiddleTitleAlign;
					Module1.myPrintset.myTableBottomRightTitleAlign = this.myTableBottomRightTitleAlign;
					Module1.myPrintset.myTableTopLeftTitleAlign = this.myTableTopLeftTitleAlign;
					Module1.myPrintset.myTableTopMiddleTitleAlign = this.myTableTopMiddleTitleAlign;
					Module1.myPrintset.myTableTopRightTitleAlign = this.myTableTopRightTitleAlign;
					Module1.myPrintset.mySumNumberAlign = this.mySumNumberAlign;
					Module1.myPrintset.mypagebackgroundimage = this.mypagebackgroundimage;
					Module1.myPrintset.myisshowaboutpage = this.myisshowaboutpage;
					Module1.myPrintset.myisdrawpagefooterline = this.myisdrawpagefooterline;
					Module1.myPrintset.myisdrawpageheaderline = this.myisdrawpageheaderline;
					Module1.myPrintset.myisdrawmargin = this.myisdrawmargin;
					Module1.myPrintset.myisautoaddemptyrow = this.myisautoaddemptyrow;
					Module1.myPrintset.mycaneditprintsettings = this.mycaneditprintsettings;
					if (String.Compare(this.mypapername.Trim(), "", false) == 0 & this.PaperKind == PaperKind.Custom)
					{
						Module1.myPrintset.papername = "[自定义纸张]";
					}
					else
					{
						Module1.myPrintset.papername = this.mypapername;
					}
					if (this.PaperKind == PaperKind.Custom)
					{
						try
						{
							definepaper.SetPrintForm("", Module1.myPrintset.papername, Convert.ToSingle(this.mypaperwidth), Convert.ToSingle(this.mypaperheight));
						}
						catch (Exception ex)
						{
						}
					}
					Module1.myPrintset.mypaperwidth = this.mypaperwidth;
					Module1.myPrintset.mypaperheight = this.mypaperheight;
					Module1.myPrintset.myisdrawtablefootereverypage = this.myisdrawtablefootereverypage;
					Module1.myPrintset.thedoublelinespace = this.thedoublelinespace;
					Module1.myPrintset.myouterborder = this.myouterborder;
					Module1.myPrintset.myouterbordercolor = this.myouterbordercolor;
					Module1.myPrintset.myouterborderwidth = this.myouterborderwidth;
					Module1.myPrintset.myisusedoubleline = this.myisusedoubleline;
					Module1.myPrintset.myisdrawZDX = this.myisdrawZDX;
					Module1.myPrintset.myZDXfont = (Font)this.ZDXFont.Clone();
					Module1.myPrintset.myZDXlinecolor = this.myZDXlinecolor;
					Module1.myPrintset.myZDXlinestyle = this.myZDXlinestyle;
					Module1.myPrintset.myZDXposition = this.myZDXposition;
					Module1.myPrintset.myZDXtext = this.myZDXtext;
					Module1.myPrintset.myZDXtextcolor = this.myZDXtextcolor;
					Module1.myPrintset.myZDXtype = (DataGridViewPrintSet.TheZDXTYPE)this.myZDXtype;
					Module1.myPrintset.myenabledprint = this.myenabledprint;
					Module1.myPrintset.myrowheight = this.myrowheight;
					Module1.myPrintset.myEnableChangeSum = this.EnableChangeSum;
					Module1.myPrintset.myEnableChangeGroup = this.EnableChangeGroup;
					Module1.myPrintset.myEnableChangeHeaderAndFooter = this.EnableChangeHeaderAndFooter;
					Module1.myPrintset.myEnableChangePageSettings = this.EnableChangePageSettings;
					Module1.myPrintset.myEnableChangeTableSettings = this.EnableChangeTableSettings;
					Module1.myPrintset.myEnableChangeTableStyle = this.EnableChangeTableStyle;
					Module1.myPrintset.myEnableChangeTitle = this.EnableChangeTitle;
					Module1.myPrintset.myEnableChangeWaterMark = this.EnableChangeWaterMark;
					Module1.myPrintset.myEnableChangeZDX = this.EnableChangeZDX;
					Module1.myPrintset.myEnableChangeScheme = this.EnableChangeScheme;
					Module1.myPrintset.myreportheaderalignment = this.myreportheaderalignment;
					Module1.myPrintset.myreportheadercolor = this.myreportheadercolor;
					Module1.myPrintset.myreportheaderfont = (Font)this.myreportheaderfont.Clone();
					Module1.myPrintset.myreportheaderspace = this.myreportheaderspace;
					Module1.myPrintset.myreportheadertext = this.myreportheadertext;
					Module1.myPrintset.myreportfooteralignment = this.myreportfooteralignment;
					Module1.myPrintset.myreportfootercolor = this.myreportfootercolor;
					Module1.myPrintset.myreportfooterfont = (Font)this.myreportfooterfont.Clone();
					Module1.myPrintset.myreportfooterspace = this.myreportfooterspace;
					Module1.myPrintset.myreportfootertext = this.myreportfootertext;
					Module1.myPrintset.myenablesaveasimage = this.myenablesaveasimage;
					Module1.myPrintset.myenablesaveaspdf = this.myenablesaveaspdf;
					Module1.myshowpreview = new showpreview();
					if (!isShowSettingDialog)
					{
						Module1.myPrintset.MyLoad();
						Module1.myPrintset.start();
					}
					else
					{
						Module1.myPrintset.ShowDialog();
					}
					if (Module1.myPrintset != null)
					{
						Module1.myPrintset.Dispose();
						Module1.myPrintset = null;
					}
					if (Module1.myshowpreview != null)
					{
						Module1.myshowpreview.Dispose();
						Module1.myshowpreview = null;
					}
					DGVprint.mut.ReleaseMutex();
				}
			}
		}


		// Token: 0x060004F7 RID: 1271 RVA: 0x0002EA50 File Offset: 0x0002CC50
		public void Print(DataTable DataTabletoprint, bool isShowSettingDialog = true, string schemefilename = "", TreeView columnheadertree = null)
		{
			if (DataTabletoprint == null)
			{
				Interaction.MsgBox("无法打印，要打印的表格为空", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				DataGridView dataGridView = new DataGridView();
				dataGridView = MyProject.Forms.tempform.dd;
				dataGridView.DataSource = DataTabletoprint;
				this.Print(dataGridView, isShowSettingDialog, schemefilename, columnheadertree);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002EA9C File Offset: 0x0002CC9C
		public bool ExportDGVToExcel2(DataGridView dgv)
		{
			return this.ExportDGVToExcel2(dgv, "");
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		public bool ExportDGVToExcel2(DataGridView dgv, string title)
		{
			return this.ExportDGVToExcel2(dgv, title, "", true);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002EAD4 File Offset: 0x0002CCD4
		public bool ExportDGVToExcel2(DataGridView dgv, string title, string filename, bool isopenfile)
		{
			return this.ExportDGVToExcel2(dgv, title, filename, "", "", isopenfile);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002EAF8 File Offset: 0x0002CCF8
		public bool ExportDGVToExcel2(DataGridView dgv, string title, string filename, string TableHeader, string TableFooter, bool isopenfile)
		{
			return DGVToExcelFile.myNewDGVtoExcel(dgv, filename, title, TableHeader, TableFooter, isopenfile);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002EB14 File Offset: 0x0002CD14
		public bool ExportDGVToExcel(DataGridView dgv)
		{
			return DGVtoExcel.DGVToExcel(dgv, "", "", "", "", "", true);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002EB44 File Offset: 0x0002CD44
		public bool ExportDGVToExcel(DataGridView dgv, string title)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, "", "", "", "", true);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002EB70 File Offset: 0x0002CD70
		public bool ExportDGVToExcel(DataGridView dgv, string title, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, "", TableHeader, TableFooter, "", true);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002EB94 File Offset: 0x0002CD94
		public bool ExportDGVToExcel(DataGridView dgv, string title, string filename)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, filename, "", "", "", true);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		public bool ExportDGVToExcel(DataGridView dgv, string title, string filename, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, filename, TableHeader, TableFooter, "", true);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, "", "", "", true);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002EC04 File Offset: 0x0002CE04
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, "", TableHeader, TableFooter, true);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002EC24 File Offset: 0x0002CE24
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string filename)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, filename, "", "", true);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002EC48 File Offset: 0x0002CE48
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string filename, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, filename, TableHeader, TableFooter, true);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00003728 File Offset: 0x00001928
		public void CreatePaper(string papername, int width, int height)
		{
			Module1.CreatePaper(this.PrinterName, papername, width, height);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002EC64 File Offset: 0x0002CE64
		public bool IsValidPaper(string papername)
		{
			return Module1.IsValidPaper(this.PrinterName, papername);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002EC80 File Offset: 0x0002CE80
		public void SetPageBackGroundImage(string imagefilename)
		{
			if (!MyProject.Computer.FileSystem.FileExists(imagefilename))
			{
				this.mypagebackgroundimage = null;
			}
			else
			{
				try
				{
					this.mypagebackgroundimage = Image.FromFile(imagefilename);
				}
				catch (Exception ex)
				{
					this.mypagebackgroundimage = null;
				}
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00003738 File Offset: 0x00001938
		public void SetPageBackGroundImage(Image img)
		{
			this.mypagebackgroundimage = img;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00003741 File Offset: 0x00001941
		public void CopyDataGridView(DataGridView sdv, DataGridView ddv, int fromrow, int torow)
		{
			Module1.CopyDataGridView(sdv, ddv, fromrow, torow, false);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		public bool ImportExcelToDGV(string filename, DataGridView dgv)
		{
			bool result;
			if (dgv == null)
			{
				result = false;
			}
			else
			{
				bool allowUserToAddRows = dgv.AllowUserToAddRows;
				dgv.AllowUserToAddRows = false;
				bool flag;
				if (dgv.ColumnCount <= 0)
				{
					flag = ExcelToDGV.ImportExcelToDGV(filename, dgv, true, false);
				}
				else
				{
					flag = ExcelToDGV.ImportExcelToDGV(filename, dgv, false, true);
				}
				dgv.AllowUserToAddRows = allowUserToAddRows;
				result = flag;
			}
			return result;
		}

		
		

		// Token: 0x040002B9 RID: 697
		private IContainer components;

		// Token: 0x040002BA RID: 698
		private static Mutex mut = new Mutex();

		// Token: 0x040002BB RID: 699
		private bool myPaperLandscape;

		// Token: 0x040002BC RID: 700
		private string ztitle;

		// Token: 0x040002BD RID: 701
		private string ftitle;

		// Token: 0x040002BE RID: 702
		private Font ztitlefont;

		// Token: 0x040002BF RID: 703
		private Font ftitlefont;

		// Token: 0x040002C0 RID: 704
		private int myprinttype;

		// Token: 0x040002C1 RID: 705
		private StringAlignment bgalignment;

		// Token: 0x040002C2 RID: 706
		private bool myzoomtopaperwidth;

		// Token: 0x040002C3 RID: 707
		private bool myautoresizerowheight;

		// Token: 0x040002C4 RID: 708
		private float myminfontsize;

		// Token: 0x040002C5 RID: 709
		private bool myreppagetitle;

		// Token: 0x040002C6 RID: 710
		private bool myprintbackcolor;

		// Token: 0x040002C7 RID: 711
		private string myborder;

		// Token: 0x040002C8 RID: 712
		private float mylinespace;

		// Token: 0x040002C9 RID: 713
		private bool myprintzero;

		// Token: 0x040002CA RID: 714
		private bool myautowrap;

		// Token: 0x040002CB RID: 715
		private int mycolumns;

		// Token: 0x040002CC RID: 716
		private float mycolumnspace;

		// Token: 0x040002CD RID: 717
		private bool mylastpagemode;

		// Token: 0x040002CE RID: 718
		private int myfixedcols;

		// Token: 0x040002CF RID: 719
		private string mydocumentname;

		// Token: 0x040002D0 RID: 720
		private PaperKind mypaperkind;

		// Token: 0x040002D1 RID: 721
		private Margins mypapermargin;

		// Token: 0x040002D2 RID: 722
		private bool myautoformat;

		// Token: 0x040002D3 RID: 723
		private string mypagel;

		// Token: 0x040002D4 RID: 724
		private string mypagem;

		// Token: 0x040002D5 RID: 725
		private string mypager;

		// Token: 0x040002D6 RID: 726
		private string mypageleft;

		// Token: 0x040002D7 RID: 727
		private string mypageright;

		// Token: 0x040002D8 RID: 728
		private string mypagemiddle;

		// Token: 0x040002D9 RID: 729
		private string mytablel;

		// Token: 0x040002DA RID: 730
		private string mytablem;

		// Token: 0x040002DB RID: 731
		private string mytabler;

		// Token: 0x040002DC RID: 732
		private string mytableleft;

		// Token: 0x040002DD RID: 733
		private string mytablemiddle;

		// Token: 0x040002DE RID: 734
		private string mytableright;

		// Token: 0x040002DF RID: 735
		private Font myfooterfont;

		// Token: 0x040002E0 RID: 736
		private Font myheaderfont;

		// Token: 0x040002E1 RID: 737
		private Font mytopfont;

		// Token: 0x040002E2 RID: 738
		private Font mybottomfont;

		// Token: 0x040002E3 RID: 739
		private Color myfootercolor;

		// Token: 0x040002E4 RID: 740
		private Color myheadercolor;

		// Token: 0x040002E5 RID: 741
		private Color mydefaultcolor;

		// Token: 0x040002E6 RID: 742
		private Color mygridcolor;

		// Token: 0x040002E7 RID: 743
		private string mywatermarktext;

		// Token: 0x040002E8 RID: 744
		private Font mywatermarkfont;

		// Token: 0x040002E9 RID: 745
		private byte mywatermarkopacity;

		// Token: 0x040002EA RID: 746
		private bool mywatermarklandscape;

		// Token: 0x040002EB RID: 747
		private Color mywatermarkcolor;

		// Token: 0x040002EC RID: 748
		private int myshapedepth;

		// Token: 0x040002ED RID: 749
		private int mytitletextstyle;

		// Token: 0x040002EE RID: 750
		private int mysubtitlestyle;

		// Token: 0x040002EF RID: 751
		private bool myisimmediateprint;

		// Token: 0x040002F0 RID: 752
		private bool myisimmediateprintShowPrintDialog;

		// Token: 0x040002F1 RID: 753
		private string mywindowTitle;

		// Token: 0x040002F2 RID: 754
		private bool myIsDGVCellValignmentCenter;

		// Token: 0x040002F3 RID: 755
		private bool myisaddrowid;

		// Token: 0x040002F4 RID: 756
		private bool myisgroupnewrowid;

		// Token: 0x040002F5 RID: 757
		private string mysumcolumns;

		// Token: 0x040002F6 RID: 758
		private Color mysumforecolor;

		// Token: 0x040002F7 RID: 759
		private Color mysumbackcolor;

		// Token: 0x040002F8 RID: 760
		private Font mysumfont;

		// Token: 0x040002F9 RID: 761
		private string mysortcolumn;

		// Token: 0x040002FA RID: 762
		private ListSortDirection mysortmode;

		// Token: 0x040002FB RID: 763
		private string mygroupcolumn;

		// Token: 0x040002FC RID: 764
		private bool mygroupnewpage;

		// Token: 0x040002FD RID: 765
		private StringAlignment myTableTopLeftTitleAlign;

		// Token: 0x040002FE RID: 766
		private StringAlignment myTableTopMiddleTitleAlign;

		// Token: 0x040002FF RID: 767
		private StringAlignment myTableTopRightTitleAlign;

		// Token: 0x04000300 RID: 768
		private StringAlignment myTableBottomLeftTitleAlign;

		// Token: 0x04000301 RID: 769
		private StringAlignment myTableBottomMiddleTitleAlign;

		// Token: 0x04000302 RID: 770
		private StringAlignment myTableBottomRightTitleAlign;

		// Token: 0x04000303 RID: 771
		private StringAlignment mySumNumberAlign;

		// Token: 0x04000304 RID: 772
		private bool myisuseAPIprintDialog;

		// Token: 0x04000305 RID: 773
		private string myprintername;

		// Token: 0x04000306 RID: 774
		private short _printcopys;

		// Token: 0x04000307 RID: 775
		private bool myisshowprogress;

		// Token: 0x04000308 RID: 776
		private string mypapername;

		// Token: 0x04000309 RID: 777
		private decimal mypaperwidth;

		// Token: 0x0400030A RID: 778
		private decimal mypaperheight;

		// Token: 0x0400030B RID: 779
		private Image mypagebackgroundimage;

		// Token: 0x0400030C RID: 780
		private bool myisprintrowheadercolumn;

		// Token: 0x0400030D RID: 781
		private bool myisshowaboutpage;

		// Token: 0x0400030E RID: 782
		private bool myisdrawpageheaderline;

		// Token: 0x0400030F RID: 783
		private bool myisdrawpagefooterline;

		// Token: 0x04000310 RID: 784
		private bool myisdrawmargin;

		// Token: 0x04000311 RID: 785
		private bool myisshowunvisiblecolumn;

		// Token: 0x04000312 RID: 786
		private bool myisautoaddemptyrow;

		// Token: 0x04000313 RID: 787
		private bool mycaneditprintsettings;

		// Token: 0x04000314 RID: 788
		private bool myenabledprint;

		// Token: 0x04000315 RID: 789
		private float myrowheight;

		// Token: 0x04000316 RID: 790
		private bool myIsShowMessageIfPrinterNotSupportPaper;

		// Token: 0x04000317 RID: 791
		private string myreportheadertext;

		// Token: 0x04000318 RID: 792
		private StringAlignment myreportheaderalignment;

		// Token: 0x04000319 RID: 793
		private Font myreportheaderfont;

		// Token: 0x0400031A RID: 794
		private Color myreportheadercolor;

		// Token: 0x0400031B RID: 795
		private float myreportheaderspace;

		// Token: 0x0400031C RID: 796
		private string myreportfootertext;

		// Token: 0x0400031D RID: 797
		private StringAlignment myreportfooteralignment;

		// Token: 0x0400031E RID: 798
		private Font myreportfooterfont;

		// Token: 0x0400031F RID: 799
		private Color myreportfootercolor;

		// Token: 0x04000320 RID: 800
		private float myreportfooterspace;

		// Token: 0x04000321 RID: 801
		private bool myenablesaveaspdf;

		// Token: 0x04000322 RID: 802
		private bool myenablesaveasimage;

		// Token: 0x04000323 RID: 803
		private bool myenableexportpdf;

		// Token: 0x04000324 RID: 804
		private bool myenableexportexcel;

		// Token: 0x04000325 RID: 805
		private bool myenableexportrtf;

		// Token: 0x04000326 RID: 806
		private bool myenableexporthtml;

		// Token: 0x04000327 RID: 807
		private string myZDXtext;

		// Token: 0x04000328 RID: 808
		private Font myZDXfont;

		// Token: 0x04000329 RID: 809
		private Color myZDXtextcolor;

		// Token: 0x0400032A RID: 810
		private Color myZDXlinecolor;

		// Token: 0x0400032B RID: 811
		private DashStyle myZDXlinestyle;

		// Token: 0x0400032C RID: 812
		private float myZDXposition;

		// Token: 0x0400032D RID: 813
		private DGVprint.TheZDXTYPE myZDXtype;

		// Token: 0x0400032E RID: 814
		private bool myisdrawZDX;

		// Token: 0x0400032F RID: 815
		private DGVprint.DGVPrintRange myprintrange;

		// Token: 0x04000330 RID: 816
		private bool myisdrawtablefootereverypage;

		// Token: 0x04000331 RID: 817
		private bool myisusedoubleline;

		// Token: 0x04000332 RID: 818
		private bool myouterborder;

		// Token: 0x04000333 RID: 819
		private Color myouterbordercolor;

		// Token: 0x04000334 RID: 820
		private float myouterborderwidth;

		// Token: 0x04000335 RID: 821
		private float thedoublelinespace;

		// Token: 0x04000336 RID: 822
		private bool myEnableChangePageSettings;

		// Token: 0x04000337 RID: 823
		private bool myEnableChangeTitle;

		// Token: 0x04000338 RID: 824
		private bool myEnableChangeTableStyle;

		// Token: 0x04000339 RID: 825
		private bool myEnableChangeTableSettings;

		// Token: 0x0400033A RID: 826
		private bool myEnableChangeHeaderAndFooter;

		// Token: 0x0400033B RID: 827
		private bool myEnableChangeGroup;

		// Token: 0x0400033C RID: 828
		private bool myEnableChangeSum;

		// Token: 0x0400033D RID: 829
		private bool myEnableChangeZDX;

		// Token: 0x0400033E RID: 830
		private bool myEnableChangeWaterMark;

		// Token: 0x0400033F RID: 831
		private bool myEnableChangeScheme;

		// Token: 0x02000013 RID: 19
		public enum mytype
		{
			// Token: 0x04000341 RID: 833
			GeneralPrint = 1,
			// Token: 0x04000342 RID: 834
			MulColsPrint,
			// Token: 0x04000343 RID: 835
			MulPagesPrint,
			// Token: 0x04000344 RID: 836
			GZTPrint
		}

		// Token: 0x02000014 RID: 20
		public enum TheZDXTYPE
		{
			// Token: 0x04000346 RID: 838
			LEFT,
			// Token: 0x04000347 RID: 839
			TOP,
			// Token: 0x04000348 RID: 840
			RIGHT,
			// Token: 0x04000349 RID: 841
			BOTTOM
		}

		// Token: 0x02000015 RID: 21
		public enum DGVPrintRange
		{
			// Token: 0x0400034B RID: 843
			AllVisibleRowsAndColumns,
			// Token: 0x0400034C RID: 844
			SelectedRows,
			// Token: 0x0400034D RID: 845
			SelectedColumns,
			// Token: 0x0400034E RID: 846
			SelectedRowsAndColumns
		}
	}
}
