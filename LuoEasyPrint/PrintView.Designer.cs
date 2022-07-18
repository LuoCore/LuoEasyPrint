namespace LuoEasyPrint
{
	// Token: 0x02000084 RID: 132
	
	
	public partial class PrintView : Form
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x0008E3D4 File Offset: 0x0008C5D4
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0008E414 File Offset: 0x0008C614
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(PrintView));
			this.myp = new VB2008Print();
			this.SuspendLayout();
			this.myp.CanOpenReport = true;
			this.myp.CanSaveReport = true;
			this.myp.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
			this.myp.Currentx = 0f;
			this.myp.Currenty = 0f;
			this.myp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myp.DocumentName = ".NET打印控件";
			this.myp.DoubleLineSpace = 4f;
			this.myp.EnabledPageSetting = false;
			this.myp.EnabledPrint = true;
			this.myp.IsAutoAddEmptyRow = false;
			this.myp.IsDGVCellValignmentCenter = true;
			this.myp.IsDrawmargin = true;
			this.myp.IsDrawPageFooterLine = false;
			this.myp.IsDrawPageHeaderLine = false;
			this.myp.IsDrawTableFooterEveryPage = false;
			this.myp.IsDrawZDX = false;
			this.myp.IsImmediatePrintNotPreview = false;
			this.myp.IsImmediatePrintNotPreviewShowPrintDialog = false;
			this.myp.IsNeedCheckNewPage = true;
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
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			myp.Location = location;
			this.myp.Name = "myp";
			this.myp.OuterBorder = false;
			this.myp.OuterBorderColor = System.Drawing.Color.Black;
			this.myp.OuterBorderWidth = 2f;
			this.myp.PageUnits = VB2008Print.PageExportUnit.Inch;
			this.myp.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.myp.PaperLandscape = false;
			this.myp.PaperMargins = new System.Drawing.Printing.Margins(100, 100, 100, 100);
			this.myp.PaperSize = (System.Drawing.Printing.PaperSize)componentResourceManager.GetObject("myp.PaperSize");
			this.myp.ShapeDepth = 8;
			System.Windows.Forms.Control myp2 = this.myp;
			System.Drawing.Size size = new System.Drawing.Size(517, 311);
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
			size = new System.Drawing.Size(517, 311);
			this.ClientSize = size;
			this.Controls.Add(this.myp);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "PrintView";
			this.Text = "PrintView";
			this.ResumeLayout(false);
		}

		// Token: 0x04000953 RID: 2387
		private System.ComponentModel.IContainer components;
	}
}
