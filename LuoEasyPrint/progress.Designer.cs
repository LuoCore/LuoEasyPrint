namespace LuoEasyPrint
{

	public partial class progress : Form
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
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

		// Token: 0x0600120F RID: 4623 RVA: 0x0008F034 File Offset: 0x0008D234
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Label1 = new System.Windows.Forms.Label();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label = this.Label1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			label.Location = location;
			System.Windows.Forms.Control label2 = this.Label1;
			System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(0);
			label2.Margin = margin;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label3 = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(238, 63);
			label3.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "正在处理中，请稍候...";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Image = Properties.Resources.delete;
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(67, 6);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(94, 27);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "取消";
			this.ToolTip1.SetToolTip(this.Button1, "关闭处理进度窗口，立即取消本次打印预处理");
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = System.Drawing.SystemColors.Control;
			this.Button2.Image = Properties.Resources.delete;
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(214, 1);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(24, 21);
			button4.Size = size;
			this.Button2.TabIndex = 2;
			this.ToolTip1.SetToolTip(this.Button2, "关闭状态窗口，但不取消当前正在进行的操作");
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Visible = false;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Button1);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			System.Windows.Forms.Control panel = this.Panel2;
			location = new System.Drawing.Point(0, 65);
			panel.Location = location;
			this.Panel2.Name = "Panel2";
			System.Windows.Forms.Control panel2 = this.Panel2;
			size = new System.Drawing.Size(240, 39);
			panel2.Size = size;
			this.Panel2.TabIndex = 3;
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.Button2);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			System.Windows.Forms.Control panel3 = this.Panel3;
			location = new System.Drawing.Point(0, 0);
			panel3.Location = location;
			this.Panel3.Name = "Panel3";
			System.Windows.Forms.Control panel4 = this.Panel3;
			size = new System.Drawing.Size(240, 65);
			panel4.Size = size;
			this.Panel3.TabIndex = 4;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(240, 104);
			this.ClientSize = size;
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "progress";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "正在努力处理中，请稍侯";
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x0400095D RID: 2397
		private System.ComponentModel.IContainer components;
	}
}
