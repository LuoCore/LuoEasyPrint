using System.ComponentModel;

namespace LuoEasyPrint
{

	public partial class reportprint : Form
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x0002FA0C File Offset: 0x0002DC0C
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

		// Token: 0x06000535 RID: 1333 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(reportprint));
			this.p = new VB2008Print();
			this.SuspendLayout();
			this.p.CanOpenReport = false;
			this.p.CanSaveReport = true;
			this.p.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
			this.p.Currentx = 0f;
			this.p.Currenty = 0f;
			this.p.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p.DocumentName = "VB2008打印控件";
			this.p.DoubleLineSpace = 4f;
			this.p.EnabledPageSetting = false;
			this.p.EnabledPrint = true;
			this.p.EnablePrintDraft = true;
			this.p.EnableSaveAsImage = true;
			this.p.EnableSaveAsPDF = true;
			this.p.IsAutoAddEmptyRow = false;
			this.p.IsAutoAdjustPrinterMargin = true;
			this.p.IsDGVCellValignmentCenter = true;
			this.p.IsDrawmargin = false;
			this.p.IsDrawPageFooterLine = false;
			this.p.IsDrawPageHeaderLine = false;
			this.p.IsDrawTableFooterEveryPage = false;
			this.p.IsDrawZDX = false;
			this.p.IsImmediatePrintNotPreview = false;
			this.p.IsImmediatePrintNotPreviewShowPrintDialog = false;
			this.p.IsNeedCheckNewPage = true;
			this.p.IsNeedPrintPageHeaderAndFooter = true;
			this.p.IsShowContextMenu = true;
			this.p.IsShowErrorMSG = true;
			this.p.IsShowMessageIfPrinterNotSupportPaper = false;
			this.p.IsShowPageContinues = false;
			this.p.IsShowPrintStatusDialog = true;
			this.p.IsShowProgess = true;
			this.p.IsUseAPIprintDialog = true;
			this.p.IsUseDGVPadding = true;
			this.p.IsUseDoubleLine = false;
			System.Windows.Forms.Control p = this.p;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			p.Location = location;
			this.p.Name = "p";
			this.p.OffsetX = 0f;
			this.p.OffsetY = 0f;
			this.p.OuterBorder = false;
			this.p.OuterBorderColor = System.Drawing.Color.Black;
			this.p.OuterBorderWidth = 2f;
			this.p.PageScale = 1f;
			this.p.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
			this.p.PaperBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.p.PaperForeColor = System.Drawing.Color.White;
			this.p.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.p.PaperLandscape = false;
			this.p.PaperMargins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
			this.p.PaperSize = (System.Drawing.Printing.PaperSize)componentResourceManager.GetObject("p.PaperSize");
			this.p.ShapeDepth = 20;
			System.Windows.Forms.Control p2 = this.p;
			System.Drawing.Size size = new System.Drawing.Size(660, 342);
			p2.Size = size;
			this.p.TabIndex = 0;
			this.p.TextColor = System.Drawing.Color.Black;
			this.p.TextFont = new System.Drawing.Font("宋体", 9f);
			this.p.ToolBarVisible = true;
			this.p.UseAntiAlias = true;
			this.p.WaterMarkColor = System.Drawing.Color.Red;
			this.p.WaterMarkFont = new System.Drawing.Font("华文行楷", 80f, System.Drawing.FontStyle.Bold);
			this.p.WaterMarkLandscape = true;
			this.p.WaterMarkOpacity = 128;
			this.p.WaterMarkText = "";
			this.p.ZDXFont = new System.Drawing.Font("宋体", 9f);
			this.p.ZDXLinecoLor = System.Drawing.Color.Black;
			this.p.ZDXLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.p.ZDXPosition = 0f;
			this.p.ZDXText = "装订线";
			this.p.ZDXTextColor = System.Drawing.Color.Black;
			this.p.ZDXType = VB2008Print.TheZDXTYPE.LEFT;
			this.p.ZDYButton2Text = "";
			this.p.ZDYButton2ToolTipText = "";
			this.p.ZDYButton2Visible = true;
			this.p.ZDYButtonText = "修改报表";
			this.p.ZDYButtonToolTipText = "修改报表";
			this.p.ZDYButtonVisible = true;
			this.p.Zoom = 1.0;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(660, 342);
			this.ClientSize = size;
			this.Controls.Add(this.p);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "reportprint";
			this.Text = "报表打印";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}

		// Token: 0x0400035C RID: 860
		private System.ComponentModel.IContainer components;
	}
}
