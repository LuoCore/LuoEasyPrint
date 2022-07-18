namespace LuoEasyPrint
{
	
	internal partial class mywait : Form
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x000042F0 File Offset: 0x000024F0
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(Disposing);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0004E4CC File Offset: 0x0004C6CC
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control label = this.Label1;
			System.Drawing.Point location = new System.Drawing.Point(7, 8);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(252, 71);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "正在读取报表模板，请稍侯……";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			size = new System.Drawing.Size(264, 81);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			location = new System.Drawing.Point(1, 1);
			this.Location = location;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mywait";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);
		}

		// Token: 0x04000497 RID: 1175
		private System.ComponentModel.IContainer components;
	}
}
