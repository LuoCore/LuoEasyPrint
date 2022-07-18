namespace LuoEasyPrint
{

	public partial class SimpleReportPrint : Form
	{
		// Token: 0x06000E6E RID: 3694 RVA: 0x000718D4 File Offset: 0x0006FAD4
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
					if (this.myschemes != null)
					{
						this.myschemes.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00071924 File Offset: 0x0006FB24
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(SimpleReportPrint));
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripLabel();
			this.fa = new System.Windows.Forms.ToolStripComboBox();
			this.myedit = new System.Windows.Forms.ToolStripButton();
			this.mysaveas = new System.Windows.Forms.ToolStripButton();
			this.myadd = new System.Windows.Forms.ToolStripButton();
			this.mydel = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.exportexcel = new System.Windows.Forms.ToolStripMenuItem();
			this.exportrtf = new System.Windows.Forms.ToolStripMenuItem();
			this.exporthtml = new System.Windows.Forms.ToolStripMenuItem();
			this.exportpdf = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.l_default = new System.Windows.Forms.ToolStripLabel();
			this.myp = new VB2008Print();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton1,
				this.fa,
				this.myedit,
				this.mysaveas,
				this.myadd,
				this.mydel,
				this.ToolStripButton2,
				this.ToolStripButton3,
				this.ToolStripButton4,
				this.ToolStripSeparator1,
				this.l_default
			});
			System.Windows.Forms.Control toolStrip = this.ToolStrip1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			toolStrip.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			System.Windows.Forms.Control toolStrip2 = this.ToolStrip1;
			System.Drawing.Size size = new System.Drawing.Size(791, 25);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 2;
			this.ToolStrip1.Text = "ToolStrip1";
			this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton1.Image = (System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton1.Name = "ToolStripButton1";
			System.Windows.Forms.ToolStripItem toolStripButton = this.ToolStripButton1;
			size = new System.Drawing.Size(68, 22);
			toolStripButton.Size = size;
			this.ToolStripButton1.Text = "打印方案：";
			this.fa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fa.Name = "fa";
			System.Windows.Forms.ToolStripControlHost fa = this.fa;
			size = new System.Drawing.Size(250, 25);
			fa.Size = size;
			this.myedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.myedit.Image = (System.Drawing.Image)componentResourceManager.GetObject("myedit.Image");
			this.myedit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.myedit.Name = "myedit";
			System.Windows.Forms.ToolStripItem myedit = this.myedit;
			size = new System.Drawing.Size(36, 22);
			myedit.Size = size;
			this.myedit.Text = "修改";
			this.myedit.ToolTipText = "弹出打印参数设置窗口，修改当前选定的打印方案的打印参数";
			this.mysaveas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mysaveas.Image = (System.Drawing.Image)componentResourceManager.GetObject("mysaveas.Image");
			this.mysaveas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mysaveas.Name = "mysaveas";
			System.Windows.Forms.ToolStripItem mysaveas = this.mysaveas;
			size = new System.Drawing.Size(36, 22);
			mysaveas.Size = size;
			this.mysaveas.Text = "另存";
			this.mysaveas.ToolTipText = "将当前打印方案另存为新的打印方案";
			this.myadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.myadd.Image = (System.Drawing.Image)componentResourceManager.GetObject("myadd.Image");
			this.myadd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.myadd.Name = "myadd";
			System.Windows.Forms.ToolStripItem myadd = this.myadd;
			size = new System.Drawing.Size(36, 22);
			myadd.Size = size;
			this.myadd.Text = "增加";
			this.myadd.ToolTipText = "增加一个新的打印方案";
			this.mydel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mydel.Image = (System.Drawing.Image)componentResourceManager.GetObject("mydel.Image");
			this.mydel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mydel.Name = "mydel";
			System.Windows.Forms.ToolStripItem mydel = this.mydel;
			size = new System.Drawing.Size(36, 22);
			mydel.Size = size;
			this.mydel.Text = "删除";
			this.mydel.ToolTipText = "删除当前打印方案";
			this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton2.Image = (System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			System.Windows.Forms.ToolStripItem toolStripButton2 = this.ToolStripButton2;
			size = new System.Drawing.Size(84, 22);
			toolStripButton2.Size = size;
			this.ToolStripButton2.Text = "设为默认方案";
			this.ToolStripButton2.ToolTipText = "将当前打印方案设置为默认方案";
			this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton3.Image = (System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton3.Name = "ToolStripButton3";
			System.Windows.Forms.ToolStripItem toolStripButton3 = this.ToolStripButton3;
			size = new System.Drawing.Size(48, 22);
			toolStripButton3.Size = size;
			this.ToolStripButton3.Text = "重命名";
			this.ToolStripButton3.ToolTipText = "重命名当前打印方案";
			this.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.exportexcel,
				this.exportrtf,
				this.exporthtml,
				this.exportpdf
			});
			this.ToolStripButton4.Image = (System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton4.Image");
			this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton4.Name = "ToolStripButton4";
			System.Windows.Forms.ToolStripItem toolStripButton4 = this.ToolStripButton4;
			size = new System.Drawing.Size(69, 22);
			toolStripButton4.Size = size;
			this.ToolStripButton4.Text = "导出数据";
			this.ToolStripButton4.ToolTipText = "注意：仅将表格中的数据导出，不是按打印格式导出";
			this.exportexcel.Name = "exportexcel";
			System.Windows.Forms.ToolStripItem exportexcel = this.exportexcel;
			size = new System.Drawing.Size(170, 22);
			exportexcel.Size = size;
			this.exportexcel.Text = "导出为Excel格式";
			this.exportrtf.Name = "exportrtf";
			System.Windows.Forms.ToolStripItem exportrtf = this.exportrtf;
			size = new System.Drawing.Size(170, 22);
			exportrtf.Size = size;
			this.exportrtf.Text = "导出为RTF格式";
			this.exporthtml.Name = "exporthtml";
			System.Windows.Forms.ToolStripItem exporthtml = this.exporthtml;
			size = new System.Drawing.Size(170, 22);
			exporthtml.Size = size;
			this.exporthtml.Text = "导出为HTML格式";
			this.exportpdf.Name = "exportpdf";
			System.Windows.Forms.ToolStripItem exportpdf = this.exportpdf;
			size = new System.Drawing.Size(170, 22);
			exportpdf.Size = size;
			this.exportpdf.Text = "导出为PDF格式";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator.Size = size;
			this.l_default.ForeColor = System.Drawing.Color.Blue;
			this.l_default.Name = "l_default";
			System.Windows.Forms.ToolStripItem l_default = this.l_default;
			size = new System.Drawing.Size(80, 22);
			l_default.Size = size;
			this.l_default.Text = "默认打印方案";
			this.myp.CanOpenReport = false;
			this.myp.CanSaveReport = true;
			this.myp.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
			this.myp.Currentx = 0f;
			this.myp.Currenty = 0f;
			this.myp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myp.DocumentName = ".NET打印控件";
			this.myp.DoubleLineSpace = 1f;
			this.myp.EnabledPageSetting = false;
			this.myp.EnabledPrint = true;
			this.myp.EnablePrintDraft = true;
			this.myp.EnableSaveAsImage = true;
			this.myp.EnableSaveAsPDF = true;
			this.myp.IsAutoAddEmptyRow = false;
			this.myp.IsAutoAdjustPrinterMargin = true;
			this.myp.IsDGVCellValignmentCenter = true;
			this.myp.IsDrawmargin = false;
			this.myp.IsDrawPageFooterLine = false;
			this.myp.IsDrawPageHeaderLine = false;
			this.myp.IsDrawTableFooterEveryPage = false;
			this.myp.IsDrawZDX = false;
			this.myp.IsImmediatePrintNotPreview = false;
			this.myp.IsImmediatePrintNotPreviewShowPrintDialog = false;
			this.myp.IsNeedCheckNewPage = true;
			this.myp.IsNeedPrintPageHeaderAndFooter = true;
			this.myp.IsShowContextMenu = true;
			this.myp.IsShowErrorMSG = true;
			this.myp.IsShowMessageIfPrinterNotSupportPaper = true;
			this.myp.IsShowPageContinues = false;
			this.myp.IsShowPrintStatusDialog = true;
			this.myp.IsShowProgess = true;
			this.myp.IsUseAPIprintDialog = true;
			this.myp.IsUseDGVPadding = true;
			this.myp.IsUseDoubleLine = false;
			System.Windows.Forms.Control myp = this.myp;
			location = new System.Drawing.Point(0, 25);
			myp.Location = location;
			this.myp.Name = "myp";
			this.myp.OffsetX = 0f;
			this.myp.OffsetY = 0f;
			this.myp.OuterBorder = false;
			this.myp.OuterBorderColor = System.Drawing.Color.Black;
			this.myp.OuterBorderWidth = 0f;
			this.myp.PageScale = 1f;
			this.myp.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
			this.myp.PaperBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.myp.PaperForeColor = System.Drawing.Color.White;
			this.myp.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.myp.PaperLandscape = false;
			this.myp.PaperMargins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
			this.myp.PaperSize = (System.Drawing.Printing.PaperSize)componentResourceManager.GetObject("myp.PaperSize");
			this.myp.ShapeDepth = 20;
			System.Windows.Forms.Control myp2 = this.myp;
			size = new System.Drawing.Size(791, 443);
			myp2.Size = size;
			this.myp.TabIndex = 0;
			this.myp.TextColor = System.Drawing.Color.Black;
			this.myp.TextFont = new System.Drawing.Font("宋体", 9f);
			this.myp.ToolBarVisible = true;
			this.myp.UseAntiAlias = true;
			this.myp.WaterMarkColor = System.Drawing.Color.Red;
			this.myp.WaterMarkFont = new System.Drawing.Font("华文行楷", 80f, System.Drawing.FontStyle.Bold);
			this.myp.WaterMarkLandscape = true;
			this.myp.WaterMarkOpacity = 128;
			this.myp.WaterMarkText = "";
			this.myp.ZDXFont = new System.Drawing.Font("宋体", 9f);
			this.myp.ZDXLinecoLor = System.Drawing.Color.Black;
			this.myp.ZDXLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.myp.ZDXPosition = 0f;
			this.myp.ZDXText = "装订线";
			this.myp.ZDXTextColor = System.Drawing.Color.Black;
			this.myp.ZDXType = VB2008Print.TheZDXTYPE.LEFT;
			this.myp.ZDYButton2Text = "";
			this.myp.ZDYButton2ToolTipText = "";
			this.myp.ZDYButton2Visible = false;
			this.myp.ZDYButtonText = "";
			this.myp.ZDYButtonToolTipText = "";
			this.myp.ZDYButtonVisible = false;
			this.myp.Zoom = 1.0;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(791, 468);
			this.ClientSize = size;
			this.Controls.Add(this.myp);
			this.Controls.Add(this.ToolStrip1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "SimpleReportPrint";
			this.Text = "打印预览";
			this.WindowState = FormWindowState.Maximized;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000743 RID: 1859
		private System.ComponentModel.IContainer components;

		// Token: 0x04000756 RID: 1878
		private SimpleReportSchemes myschemes;
	}
}
