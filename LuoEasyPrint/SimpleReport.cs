using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x0200006F RID: 111
	[ToolboxBitmap(typeof(SimpleReport), "printer.bmp")]
	[Description("适合打印窗口中单个DataGridView的非可视化打印组件(NET2.0)")]
	[Guid("48DEFCB9-A258-4AF5-90FA-0D48A9BC58D6")]
	public class SimpleReport : Component
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00005B50 File Offset: 0x00003D50
		[DebuggerNonUserCode]
		public SimpleReport(IContainer container) : this()
		{
			if (container != null)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0006FB84 File Offset: 0x0006DD84
		[DebuggerNonUserCode]
		public SimpleReport()
		{
			this.mydgv = null;
			this.mycs = null;
			this.myIsChanged = false;
			this.myisimmediateprint = false;
			this.myisimmediateprintShowPrintDialog = true;
			this.mywindowTitle = "打印预览";
			this.myIsShowMessageIfPrinterNotSupportPaper = false;
			this.mydocumentname = "";
			this.myprintername = "";
			this.myIsRedrawCell = false;
			this.myisdrawmargin = false;
			this.myenablesaveaspdf = true;
			this.myenablesaveasimage = true;
			this.myenableexportpdf = true;
			this.myenableexportexcel = true;
			this.myenableexportrtf = true;
			this.myenableexporthtml = true;
			this.myisshowcontextmenu = true;
			this.myistoolbarvisible = true;
			this.myispreviewtoolbarvisible = true;
			this.myenabledprint = true;
			this.myenablecgprint = true;
			this.myisshowpagecontinues = false;
			this._printcopys = 1;
			this.myisshowprogress = true;
			this.myisonlygetreportstring = false;
			this.InitializeComponent();
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0006FC60 File Offset: 0x0006DE60
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
					if (this.mydgv != null)
					{
						this.mydgv.Dispose();
						this.mydgv = null;
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00005B62 File Offset: 0x00003D62
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00005B6F File Offset: 0x00003D6F
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0006FCCC File Offset: 0x0006DECC
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00005B78 File Offset: 0x00003D78
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00005B85 File Offset: 0x00003D85
		[Description("设置或获取一个值，用于指示打印预览结果在有多页的情况下，是以'单页方式'还是'连续显示方式'显示打印预览结果。为true表示连续显示，为false表示单页显示")]
		public bool IsShowPageContinues
		{
			get
			{
				return this.myisshowpagecontinues;
			}
			set
			{
				this.myisshowpagecontinues = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0006FCF8 File Offset: 0x0006DEF8
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00005B8E File Offset: 0x00003D8E
		[Description("设置或获取一个值，用于指示控件工具栏中的\u3000草稿打印\u3000按钮是否可用")]
		public bool EnablePrintDraft
		{
			get
			{
				return this.myenablecgprint;
			}
			set
			{
				this.myenablecgprint = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0006FD0C File Offset: 0x0006DF0C
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00005B97 File Offset: 0x00003D97
		[Description("设置或获取一个值，用于指示控件工具栏中的 打印 按钮是否可用，为true表示可用，为false表示不可用")]
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0006FD20 File Offset: 0x0006DF20
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00005BA0 File Offset: 0x00003DA0
		[Description("打印预览窗口中的打印工具栏是否可见")]
		public bool PreviewToolBarVisible
		{
			get
			{
				return this.myispreviewtoolbarvisible;
			}
			set
			{
				this.myispreviewtoolbarvisible = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0006FD34 File Offset: 0x0006DF34
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00005BA9 File Offset: 0x00003DA9
		[Description("打印预览窗口中的打印方案设置工具栏是否可见")]
		public bool ToolBarVisible
		{
			get
			{
				return this.myistoolbarvisible;
			}
			set
			{
				this.myistoolbarvisible = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0006FD48 File Offset: 0x0006DF48
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00005BB2 File Offset: 0x00003DB2
		[Description("获取或设置一个值,用于指示是否容许在打印预览界面显示右键快捷菜单")]
		public bool IsShowContextMenu
		{
			get
			{
				return this.myisshowcontextmenu;
			}
			set
			{
				this.myisshowcontextmenu = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0006FD5C File Offset: 0x0006DF5C
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00005BBB File Offset: 0x00003DBB
		[Description("设置一个值，指示打印预览界面的\u3000导出为RTF文件\u3000菜单是否可用")]
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0006FD70 File Offset: 0x0006DF70
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Description("设置一个值，指示打印预览界面的\u3000导出为HTML文件\u3000菜单是否可用")]
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0006FD84 File Offset: 0x0006DF84
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00005BCD File Offset: 0x00003DCD
		[Description("设置一个值，指示打印预览界面的\u3000导出为Excel文件\u3000菜单是否可用")]
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

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0006FD98 File Offset: 0x0006DF98
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00005BD6 File Offset: 0x00003DD6
		[Description("设置一个值，指示打印预览界面的\u3000导出为PDF文件\u3000菜单是否可用")]
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0006FDAC File Offset: 0x0006DFAC
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00005BDF File Offset: 0x00003DDF
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0006FDC0 File Offset: 0x0006DFC0
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00005BE8 File Offset: 0x00003DE8
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00005BF1 File Offset: 0x00003DF1
		[Description("指定在打印DataGridView前是否根据实际要打印的DataGridView重置打印方案中设置的列，该属性只针对打印方案中的默认方案有效。")]
		public bool IsRedrawCell
		{
			get
			{
				return this.myIsRedrawCell;
			}
			set
			{
				this.myIsRedrawCell = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0006FDE8 File Offset: 0x0006DFE8
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00005BFA File Offset: 0x00003DFA
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0006FDFC File Offset: 0x0006DFFC
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00005C03 File Offset: 0x00003E03
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0006FE14 File Offset: 0x0006E014
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00005C11 File Offset: 0x00003E11
		[Description("设置打印文档名称，该名称将显示在打印机打印任务的文档名称栏中")]
		public string DocumentName
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0006FE2C File Offset: 0x0006E02C
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00005C1A File Offset: 0x00003E1A
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0006FE44 File Offset: 0x0006E044
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00005C23 File Offset: 0x00003E23
		public bool IsOnlyGetReportString
		{
			get
			{
				return this.myisonlygetreportstring;
			}
			set
			{
				this.myisonlygetreportstring = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0006FE58 File Offset: 0x0006E058
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00005C2C File Offset: 0x00003E2C
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0006FE6C File Offset: 0x0006E06C
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00005C35 File Offset: 0x00003E35
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0006FE80 File Offset: 0x0006E080
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00005C3E File Offset: 0x00003E3E
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0006FE94 File Offset: 0x0006E094
		[Description("获取一个值，用于指示打印方案在打印预览过程中是否改变了")]
		public bool IsChanged
		{
			get
			{
				return this.myIsChanged;
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00005C47 File Offset: 0x00003E47
		public void Print2(ref string cs, bool canedit, bool canadd, bool candel)
		{
			this.Print2(ref cs, canedit, canadd, candel, "");
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0006FEA8 File Offset: 0x0006E0A8
		public void Print2(ref string cs, bool canedit, bool canadd, bool candel, string defaultschemename)
		{
			SimpleReportPrint simpleReportPrint = new SimpleReportPrint();
			simpleReportPrint.myp.IsImmediatePrintNotPreview = this.IsImmediatePrint;
			simpleReportPrint.myp.IsImmediatePrintNotPreviewShowPrintDialog = this.IsImmediatePrintShowPrintDialog;
			simpleReportPrint.myp.IsShowMessageIfPrinterNotSupportPaper = this.myIsShowMessageIfPrinterNotSupportPaper;
			simpleReportPrint.Text = this.WindowTitle;
			simpleReportPrint.documentname = this.mydocumentname;
			simpleReportPrint.myprintername = this.myprintername;
			simpleReportPrint.myisdrawmargin = this.myisdrawmargin;
			simpleReportPrint.myenablesaveaspdf = this.myenablesaveaspdf;
			simpleReportPrint.myenablesaveasimage = this.myenablesaveasimage;
			simpleReportPrint.myenableexportexcel = this.myenableexportexcel;
			simpleReportPrint.myenableexporthtml = this.myenableexporthtml;
			simpleReportPrint.myenableexportpdf = this.myenableexportpdf;
			simpleReportPrint.myenableexportrtf = this.myenableexportrtf;
			simpleReportPrint.myisshowcontextmenu = this.myisshowcontextmenu;
			simpleReportPrint.myistoolbarvisible = this.myistoolbarvisible;
			simpleReportPrint.myispreviewtoolbarvisible = this.myispreviewtoolbarvisible;
			simpleReportPrint.myenabledprint = this.myenabledprint;
			simpleReportPrint.myenablecgprint = this.myenablecgprint;
			simpleReportPrint.myisshowpagecontinues = this.myisshowpagecontinues;
			simpleReportPrint._printcopys = this.PrintCopys;
			simpleReportPrint.myisshowprogress = this.IsShowProgess;
			simpleReportPrint.myschemenametoprint = defaultschemename;
			if (this.mydgv == null)
			{
				simpleReportPrint.w_dgv = new DataGridView();
			}
			else
			{
				simpleReportPrint.w_dgv = this.mydgv;
			}
			simpleReportPrint.w_Settings = cs;
			simpleReportPrint.W_variable = this.mycs;
			simpleReportPrint.W_canadd = canadd;
			simpleReportPrint.W_canedit = canedit;
			simpleReportPrint.W_canddel = candel;
			simpleReportPrint.IsRedrawCell = this.myIsRedrawCell;
			if (this.IsOnlyGetReportString)
			{
				this.myIsChanged = false;
				simpleReportPrint.MyLoad();
				simpleReportPrint.myp.IsShowProgess = false;
				cs = simpleReportPrint.myp.SaveReportAsString();
			}
			else
			{
				if (!this.IsImmediatePrint)
				{
					simpleReportPrint.ShowDialog();
					if (simpleReportPrint.IsChanged)
					{
						this.myIsChanged = true;
					}
					else
					{
						this.myIsChanged = false;
					}
				}
				else
				{
					simpleReportPrint.MyLoad();
					if (simpleReportPrint.IsChanged)
					{
						this.myIsChanged = true;
					}
					else
					{
						this.myIsChanged = false;
					}
				}
				cs = simpleReportPrint.GetSchemetxt();
			}
			simpleReportPrint.Dispose();
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00005C59 File Offset: 0x00003E59
		public void Print(string csfilename, bool canedit, bool canadd, bool candel)
		{
			this.Print(csfilename, canedit, canadd, candel, "");
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000700AC File Offset: 0x0006E2AC
		public void Print(string csfilename, bool canedit, bool canadd, bool candel, string defaultschemename)
		{
			string text;
			if (String.Compare(csfilename, "", false) != 0)
			{
				if (MyProject.Computer.FileSystem.FileExists(csfilename))
				{
					text = MyProject.Computer.FileSystem.ReadAllText(csfilename);
				}
				else
				{
					text = "";
				}
			}
			else
			{
				text = "";
			}
			this.Print2(ref text, canedit, canadd, candel, defaultschemename);
			if (this.IsChanged)
			{
				MyProject.Computer.FileSystem.WriteAllText(csfilename, text, false);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00070124 File Offset: 0x0006E324
		public void SetReportDataSource(DataGridView dgv)
		{
			if (this.mydgv != null)
			{
				this.mydgv.Dispose();
			}
			if (dgv != null)
			{
				this.mydgv = new DataGridView();
				this.mydgv.AllowUserToAddRows = false;
				Module1.CopyDataGridViewShowStatus(dgv, this.mydgv, false);
			}
			else
			{
				this.mydgv = null;
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00070174 File Offset: 0x0006E374
		public void SetReportDataSource(DataTable tb)
		{
			if (this.mydgv != null)
			{
				this.mydgv.Dispose();
				this.mydgv = null;
			}
			if (tb != null)
			{
				this.mydgv = new DataGridView();
				this.mydgv.AllowUserToAddRows = false;
				tempform tempform = new tempform();
				tempform.dd.DataSource = null;
				tempform.dd.DataSource = tb;
				Module1.CopyDataGridView(tempform.dd, this.mydgv);
				tempform.Dispose();
			}
			else
			{
				this.mydgv = null;
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00005C6B File Offset: 0x00003E6B
		public void SetReportVar(string varname, string varval)
		{
			if (this.mycs == null)
			{
				this.mycs = new Hashtable();
			}
			this.mycs[varname] = varval;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00005C8D File Offset: 0x00003E8D
		public void SetReportVar(Hashtable hstable)
		{
			if (hstable != null)
			{
				this.mycs = (Hashtable)hstable.Clone();
			}
			else
			{
				this.mycs = null;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000701F8 File Offset: 0x0006E3F8
		public static string[] GetAllSchemeNames(string schemefile)
		{
			return SimpleReportSchemes.GetAllSchemeNames(schemefile);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00070210 File Offset: 0x0006E410
		public static string GetDefaultSchemeName(string schemefile)
		{
			return SimpleReportSchemes.GetDefaultSchemeName(schemefile);
		}

		// Token: 0x04000717 RID: 1815
		private IContainer components;

		// Token: 0x04000718 RID: 1816
		private DataGridView mydgv;

		// Token: 0x04000719 RID: 1817
		private Hashtable mycs;

		// Token: 0x0400071A RID: 1818
		private bool myIsChanged;

		// Token: 0x0400071B RID: 1819
		private bool myisimmediateprint;

		// Token: 0x0400071C RID: 1820
		private bool myisimmediateprintShowPrintDialog;

		// Token: 0x0400071D RID: 1821
		private string mywindowTitle;

		// Token: 0x0400071E RID: 1822
		private bool myIsShowMessageIfPrinterNotSupportPaper;

		// Token: 0x0400071F RID: 1823
		private string mydocumentname;

		// Token: 0x04000720 RID: 1824
		private string myprintername;

		// Token: 0x04000721 RID: 1825
		private bool myIsRedrawCell;

		// Token: 0x04000722 RID: 1826
		private bool myisdrawmargin;

		// Token: 0x04000723 RID: 1827
		private bool myenablesaveaspdf;

		// Token: 0x04000724 RID: 1828
		private bool myenablesaveasimage;

		// Token: 0x04000725 RID: 1829
		private bool myenableexportpdf;

		// Token: 0x04000726 RID: 1830
		private bool myenableexportexcel;

		// Token: 0x04000727 RID: 1831
		private bool myenableexportrtf;

		// Token: 0x04000728 RID: 1832
		private bool myenableexporthtml;

		// Token: 0x04000729 RID: 1833
		private bool myisshowcontextmenu;

		// Token: 0x0400072A RID: 1834
		private bool myistoolbarvisible;

		// Token: 0x0400072B RID: 1835
		private bool myispreviewtoolbarvisible;

		// Token: 0x0400072C RID: 1836
		private bool myenabledprint;

		// Token: 0x0400072D RID: 1837
		private bool myenablecgprint;

		// Token: 0x0400072E RID: 1838
		private bool myisshowpagecontinues;

		// Token: 0x0400072F RID: 1839
		private short _printcopys;

		// Token: 0x04000730 RID: 1840
		private bool myisshowprogress;

		// Token: 0x04000731 RID: 1841
		private bool myisonlygetreportstring;
	}
}
