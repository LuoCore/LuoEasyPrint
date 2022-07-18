namespace LuoEasyPrint
{

	public partial class progress2 : Form
	{
		// Token: 0x06001221 RID: 4641 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
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

		// Token: 0x06001222 RID: 4642 RVA: 0x0008F604 File Offset: 0x0008D804
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label = this.Label1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(230, 56);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "正在努力处理中，请稍侯……";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(230, 56);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "progress2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "progress";
			this.TopMost = true;
			this.ResumeLayout(false);
		}

		// Token: 0x04000964 RID: 2404
		private System.ComponentModel.IContainer components;
	}
}
