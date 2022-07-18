namespace LuoEasyPrint
{

	public partial class progressexcel : Form
	{
		// Token: 0x06001CE5 RID: 7397 RVA: 0x000E78B8 File Offset: 0x000E5AB8
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

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000E78F8 File Offset: 0x000E5AF8
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
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
			System.Drawing.Size size = new System.Drawing.Size(242, 54);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "正在处理中，请稍候...";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Image = Properties.Resources.delete;
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(75, 7);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(83, 31);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "取消导出";
			this.ToolTip1.SetToolTip(this.Button1, "关于进度窗口，立即取消导出");
			this.Button1.UseVisualStyleBackColor = false;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.ProgressBar1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			System.Windows.Forms.Control panel = this.Panel1;
			location = new System.Drawing.Point(0, 0);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			System.Windows.Forms.Control panel2 = this.Panel1;
			size = new System.Drawing.Size(244, 56);
			panel2.Size = size;
			this.Panel1.TabIndex = 2;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Button1);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			System.Windows.Forms.Control panel3 = this.Panel2;
			location = new System.Drawing.Point(0, 56);
			panel3.Location = location;
			this.Panel2.Name = "Panel2";
			System.Windows.Forms.Control panel4 = this.Panel2;
			size = new System.Drawing.Size(244, 41);
			panel4.Size = size;
			this.Panel2.TabIndex = 3;
			System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new System.Drawing.Point(-1, 34);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new System.Drawing.Size(244, 23);
			progressBar2.Size = size;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.TabIndex = 1;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(244, 97);
			this.ClientSize = size;
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "progressexcel";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导出数据为Excel文件";
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x04000EA4 RID: 3748
		private System.ComponentModel.IContainer components;
	}
}
