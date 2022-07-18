namespace LuoEasyPrint
{
	// Token: 0x0200000B RID: 11
	
	
	public partial class PivotTableDetail : Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000B7C0 File Offset: 0x000099C0
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

		// Token: 0x06000063 RID: 99 RVA: 0x0000B800 File Offset: 0x00009A00
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.ToolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.d1 = new MulHeaderDataGridView();
			this.ToolStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.d1).BeginInit();
			this.SuspendLayout();
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton1,
				this.ToolStripButton2,
				this.ToolStripSeparator3,
				this.ToolStripDropDownButton1,
				this.ToolStripSeparator1,
				this.ToolStripButton4,
				this.ToolStripSeparator2,
				this.ToolStripButton3
			});
			System.Windows.Forms.Control toolStrip = this.ToolStrip1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			toolStrip.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			System.Windows.Forms.Control toolStrip2 = this.ToolStrip1;
			System.Drawing.Size size = new System.Drawing.Size(743, 25);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 3;
			this.ToolStrip1.Text = "ToolStrip1";
			this.ToolStripButton1.Image = Properties.Resources.printer1;
			this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton1.Name = "ToolStripButton1";
			System.Windows.Forms.ToolStripItem toolStripButton = this.ToolStripButton1;
			size = new System.Drawing.Size(52, 22);
			toolStripButton.Size = size;
			this.ToolStripButton1.Text = "打印";
			this.ToolStripButton2.Image = Properties.Resources.save;
			this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			System.Windows.Forms.ToolStripItem toolStripButton2 = this.ToolStripButton2;
			size = new System.Drawing.Size(76, 22);
			toolStripButton2.Size = size;
			this.ToolStripButton2.Text = "导出数据";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator.Size = size;
			this.ToolStripButton4.Image = Properties.Resources.SUM;
			this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton4.Name = "ToolStripButton4";
			System.Windows.Forms.ToolStripItem toolStripButton3 = this.ToolStripButton4;
			size = new System.Drawing.Size(52, 22);
			toolStripButton3.Size = size;
			this.ToolStripButton4.Text = "汇总";
			this.ToolStripButton4.ToolTipText = "显示或隐藏汇总列设置";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator2;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator2.Size = size;
			this.ToolStripButton3.Image = Properties.Resources.exit2;
			this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton3.Name = "ToolStripButton3";
			System.Windows.Forms.ToolStripItem toolStripButton4 = this.ToolStripButton3;
			size = new System.Drawing.Size(52, 22);
			toolStripButton4.Size = size;
			this.ToolStripButton3.Text = "退出";
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem_0,
				this.ToolStripMenuItem_1
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new System.Drawing.Size(153, 70);
			contextMenuStrip.Size = size;
			this.ToolStripMenuItem_0.Name = "复制选中内容ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem = this.ToolStripMenuItem_0;
			size = new System.Drawing.Size(152, 22);
			toolStripItem.Size = size;
			this.ToolStripMenuItem_0.Text = "复制选中内容";
			this.ToolStripMenuItem_1.Name = "选中内容求和ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem2 = this.ToolStripMenuItem_1;
			size = new System.Drawing.Size(152, 22);
			toolStripItem2.Size = size;
			this.ToolStripMenuItem_1.Text = "选中内容求和";
			this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem_2,
				this.ToolStripMenuItem_3,
				this.ToolStripMenuItem_4,
				this.ToolStripMenuItem_5
			});
			this.ToolStripDropDownButton1.Image = Properties.Resources.heightandwith;
			this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
			System.Windows.Forms.ToolStripItem toolStripDropDownButton = this.ToolStripDropDownButton1;
			size = new System.Drawing.Size(109, 22);
			toolStripDropDownButton.Size = size;
			this.ToolStripDropDownButton1.Text = "调整表格高宽";
			this.ToolStripDropDownButton1.ToolTipText = "调整表格宽度与高度";
			this.ToolStripMenuItem_2.Name = "自动调整表格列宽包括列标题ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem3 = this.ToolStripMenuItem_2;
			size = new System.Drawing.Size(268, 22);
			toolStripItem3.Size = size;
			this.ToolStripMenuItem_2.Text = "自动调整表格列宽（包括列标题）";
			this.ToolStripMenuItem_3.Name = "自动调整表格列宽不包括列标题ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem4 = this.ToolStripMenuItem_3;
			size = new System.Drawing.Size(268, 22);
			toolStripItem4.Size = size;
			this.ToolStripMenuItem_3.Text = "自动调整表格列宽（不包括列标题）";
			this.ToolStripMenuItem_4.Name = "自动调整表格ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem5 = this.ToolStripMenuItem_4;
			size = new System.Drawing.Size(268, 22);
			toolStripItem5.Size = size;
			this.ToolStripMenuItem_4.Text = "自动调整表格行高（包括列标题）";
			this.ToolStripMenuItem_5.Name = "自动调整表格行高不包括列标题ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem6 = this.ToolStripMenuItem_5;
			size = new System.Drawing.Size(268, 22);
			toolStripItem6.Size = size;
			this.ToolStripMenuItem_5.Text = "自动调整表格行高（不包括列标题）";
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator3;
			size = new System.Drawing.Size(6, 25);
			toolStripSeparator3.Size = size;
			this.d1.AddRowNumber = false;
			this.d1.AllowUserToAddRows = false;
			this.d1.AllowUserToDeleteRows = false;
			this.d1.ColHeaderTreeView = null;
			this.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.d1.ContextMenuStrip = this.ContextMenuStrip1;
			this.d1.Dock = System.Windows.Forms.DockStyle.Fill;
			System.Windows.Forms.Control d = this.d1;
			location = new System.Drawing.Point(0, 25);
			d.Location = location;
			this.d1.Name = "d1";
			this.d1.ReadOnly = true;
			this.d1.RowTemplate.Height = 23;
			System.Windows.Forms.Control d2 = this.d1;
			size = new System.Drawing.Size(743, 260);
			d2.Size = size;
			this.d1.TabIndex = 4;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(743, 285);
			this.ClientSize = size;
			this.Controls.Add(this.d1);
			this.Controls.Add(this.ToolStrip1);
			this.Name = "PivotTableDetail";
			this.Text = "详细数据";
			this.WindowState = FormWindowState.Maximized;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.d1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000034 RID: 52
		private System.ComponentModel.IContainer components;
	}
}
