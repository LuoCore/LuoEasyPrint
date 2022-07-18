namespace LuoEasyPrint
{

	public partial class tempform : Form
	{
		// Token: 0x06001242 RID: 4674 RVA: 0x00090484 File Offset: 0x0008E684
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

		// Token: 0x06001243 RID: 4675 RVA: 0x000904C4 File Offset: 0x0008E6C4
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.dd = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.dd).BeginInit();
			this.SuspendLayout();
			this.dd.AllowUserToAddRows = false;
			this.dd.AllowUserToDeleteRows = false;
			this.dd.AllowUserToOrderColumns = true;
			this.dd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			System.Windows.Forms.Control dd = this.dd;
			System.Drawing.Point location = new System.Drawing.Point(31, 22);
			dd.Location = location;
			this.dd.Name = "dd";
			this.dd.RowTemplate.Height = 23;
			System.Windows.Forms.Control dd2 = this.dd;
			System.Drawing.Size size = new System.Drawing.Size(240, 150);
			dd2.Size = size;
			this.dd.TabIndex = 0;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(292, 273);
			this.ClientSize = size;
			this.Controls.Add(this.dd);
			this.Name = "tempform";
			this.Text = "tempform";
			((System.ComponentModel.ISupportInitialize)this.dd).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000998 RID: 2456
		private System.ComponentModel.IContainer components;
	}
}
