namespace LuoEasyPrint
{

	public partial class showpreview : Form
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00012904 File Offset: 0x00010B04
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				this.myZDXfont.Dispose();
				this.mywatermarkfont.Dispose();
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00012958 File Offset: 0x00010B58
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(showpreview));
			this.mydgv = new System.Windows.Forms.DataGridView();
			this.mydgv2 = new System.Windows.Forms.DataGridView();
			this.DataGridViewPrint1 = new VB2008Print();
			((System.ComponentModel.ISupportInitialize)this.mydgv).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.mydgv2).BeginInit();
			this.SuspendLayout();
			this.mydgv.AllowUserToAddRows = false;
			this.mydgv.AllowUserToDeleteRows = false;
			this.mydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			System.Windows.Forms.Control mydgv = this.mydgv;
			System.Drawing.Point location = new System.Drawing.Point(12, 34);
			mydgv.Location = location;
			this.mydgv.Name = "mydgv";
			this.mydgv.RowTemplate.Height = 23;
			System.Windows.Forms.Control mydgv2 = this.mydgv;
			System.Drawing.Size size = new System.Drawing.Size(357, 0);
			mydgv2.Size = size;
			this.mydgv.TabIndex = 1;
			this.mydgv2.AllowUserToAddRows = false;
			this.mydgv2.AllowUserToDeleteRows = false;
			this.mydgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			System.Windows.Forms.Control mydgv3 = this.mydgv2;
			location = new System.Drawing.Point(177, 192);
			mydgv3.Location = location;
			this.mydgv2.Name = "mydgv2";
			this.mydgv2.RowTemplate.Height = 23;
			System.Windows.Forms.Control mydgv4 = this.mydgv2;
			size = new System.Drawing.Size(357, 0);
			mydgv4.Size = size;
			this.mydgv2.TabIndex = 2;
			this.DataGridViewPrint1.CanOpenReport = true;
			this.DataGridViewPrint1.CanSaveReport = true;
			this.DataGridViewPrint1.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
			this.DataGridViewPrint1.Currentx = 0f;
			this.DataGridViewPrint1.Currenty = 0f;
			this.DataGridViewPrint1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewPrint1.DocumentName = "VB2008打印控件";
			this.DataGridViewPrint1.DoubleLineSpace = 2f;
			this.DataGridViewPrint1.EnabledPageSetting = true;
			this.DataGridViewPrint1.EnabledPrint = true;
			this.DataGridViewPrint1.EnableSaveAsImage = true;
			this.DataGridViewPrint1.EnableSaveAsPDF = true;
			this.DataGridViewPrint1.IsAutoAddEmptyRow = false;
			this.DataGridViewPrint1.IsAutoAdjustPrinterMargin = true;
			this.DataGridViewPrint1.IsDGVCellValignmentCenter = true;
			this.DataGridViewPrint1.IsDrawmargin = false;
			this.DataGridViewPrint1.IsDrawPageFooterLine = false;
			this.DataGridViewPrint1.IsDrawPageHeaderLine = false;
			this.DataGridViewPrint1.IsDrawTableFooterEveryPage = false;
			this.DataGridViewPrint1.IsDrawZDX = false;
			this.DataGridViewPrint1.IsImmediatePrintNotPreview = false;
			this.DataGridViewPrint1.IsImmediatePrintNotPreviewShowPrintDialog = false;
			this.DataGridViewPrint1.IsNeedCheckNewPage = true;
			this.DataGridViewPrint1.IsNeedPrintPageHeaderAndFooter = true;
			this.DataGridViewPrint1.IsShowContextMenu = true;
			this.DataGridViewPrint1.IsShowErrorMSG = true;
			this.DataGridViewPrint1.IsShowMessageIfPrinterNotSupportPaper = true;
			this.DataGridViewPrint1.IsShowPageContinues = false;
			this.DataGridViewPrint1.IsShowPrintStatusDialog = true;
			this.DataGridViewPrint1.IsShowProgess = true;
			this.DataGridViewPrint1.IsUseAPIprintDialog = false;
			this.DataGridViewPrint1.IsUseDGVPadding = true;
			this.DataGridViewPrint1.IsUseDoubleLine = false;
			System.Windows.Forms.Control dataGridViewPrint = this.DataGridViewPrint1;
			location = new System.Drawing.Point(0, 0);
			dataGridViewPrint.Location = location;
			this.DataGridViewPrint1.Name = "DataGridViewPrint1";
			this.DataGridViewPrint1.OffsetX = 0f;
			this.DataGridViewPrint1.OffsetY = 0f;
			this.DataGridViewPrint1.OuterBorder = false;
			this.DataGridViewPrint1.OuterBorderColor = System.Drawing.Color.Black;
			this.DataGridViewPrint1.OuterBorderWidth = 2f;
			this.DataGridViewPrint1.PageScale = 1f;
			this.DataGridViewPrint1.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
			this.DataGridViewPrint1.PaperBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.DataGridViewPrint1.PaperForeColor = System.Drawing.Color.White;
			this.DataGridViewPrint1.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.DataGridViewPrint1.PaperLandscape = true;
			this.DataGridViewPrint1.PaperMargins = new System.Drawing.Printing.Margins(150, 150, 150, 150);
			this.DataGridViewPrint1.PaperSize = (System.Drawing.Printing.PaperSize)componentResourceManager.GetObject("DataGridViewPrint1.PaperSize");
			this.DataGridViewPrint1.ShapeDepth = 20;
			System.Windows.Forms.Control dataGridViewPrint2 = this.DataGridViewPrint1;
			size = new System.Drawing.Size(833, 384);
			dataGridViewPrint2.Size = size;
			this.DataGridViewPrint1.TabIndex = 0;
			this.DataGridViewPrint1.TextColor = System.Drawing.Color.Black;
			this.DataGridViewPrint1.TextFont = new System.Drawing.Font("宋体", 9f);
			this.DataGridViewPrint1.ToolBarVisible = true;
			this.DataGridViewPrint1.UseAntiAlias = true;
			this.DataGridViewPrint1.WaterMarkColor = System.Drawing.Color.Red;
			this.DataGridViewPrint1.WaterMarkFont = new System.Drawing.Font("华文行楷", 80f, System.Drawing.FontStyle.Bold);
			this.DataGridViewPrint1.WaterMarkLandscape = true;
			this.DataGridViewPrint1.WaterMarkOpacity = 128;
			this.DataGridViewPrint1.WaterMarkText = "";
			this.DataGridViewPrint1.ZDXFont = new System.Drawing.Font("宋体", 9f);
			this.DataGridViewPrint1.ZDXLinecoLor = System.Drawing.Color.Black;
			this.DataGridViewPrint1.ZDXLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.DataGridViewPrint1.ZDXPosition = 0f;
			this.DataGridViewPrint1.ZDXText = "装订线";
			this.DataGridViewPrint1.ZDXTextColor = System.Drawing.Color.Black;
			this.DataGridViewPrint1.ZDXType = VB2008Print.TheZDXTYPE.LEFT;
			this.DataGridViewPrint1.ZDYButton2Text = "";
			this.DataGridViewPrint1.ZDYButton2ToolTipText = "";
			this.DataGridViewPrint1.ZDYButton2Visible = false;
			this.DataGridViewPrint1.ZDYButtonText = "更改打印参数";
			this.DataGridViewPrint1.ZDYButtonToolTipText = "重新显示DataGridView表格打印参数设置窗口，您可以更改各项参数设置";
			this.DataGridViewPrint1.ZDYButtonVisible = true;
			this.DataGridViewPrint1.Zoom = 1.0;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(833, 384);
			this.ClientSize = size;
			this.Controls.Add(this.mydgv2);
			this.Controls.Add(this.mydgv);
			this.Controls.Add(this.DataGridViewPrint1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.KeyPreview = true;
			this.Name = "showpreview";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "表格打印预览窗口";
			this.WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)this.mydgv).EndInit();
			((System.ComponentModel.ISupportInitialize)this.mydgv2).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400008E RID: 142
		private System.ComponentModel.IContainer components;

		// Token: 0x040000BF RID: 191
		public System.Drawing.Font mywatermarkfont;

		// Token: 0x040000F4 RID: 244
		public System.Drawing.Font myZDXfont;
	}
}
