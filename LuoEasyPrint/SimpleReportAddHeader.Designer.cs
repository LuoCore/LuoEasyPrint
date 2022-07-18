namespace LuoEasyPrint
{
	// Token: 0x02000070 RID: 112
	
	
	public partial class SimpleReportAddHeader : Form
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x00070228 File Offset: 0x0006E428
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

		// Token: 0x06000E3E RID: 3646 RVA: 0x00070268 File Offset: 0x0006E468
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.jc = new System.Windows.Forms.NumericUpDown();
			this.Label3 = new System.Windows.Forms.Label();
			this.dq = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.gd = new System.Windows.Forms.NumericUpDown();
			this.FontDialog1 = new System.Windows.Forms.FontDialog();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.kd = new System.Windows.Forms.NumericUpDown();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.jc).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.gd).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.kd).BeginInit();
			this.SuspendLayout();
			System.Windows.Forms.Control label = this.Label1;
			System.Drawing.Point location = new System.Drawing.Point(7, 45);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(65, 49);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "打印内容：\r\n(双击右边\r\n可选择插\r\n入变量)";
			System.Windows.Forms.Control txt = this.txt;
			location = new System.Drawing.Point(73, 39);
			txt.Location = location;
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			System.Windows.Forms.Control txt2 = this.txt;
			size = new System.Drawing.Size(191, 63);
			txt2.Size = size;
			this.txt.TabIndex = 1;
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label2;
			location = new System.Drawing.Point(11, 14);
			label3.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label4 = this.Label2;
			size = new System.Drawing.Size(65, 12);
			label4.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "打印行次：";
			System.Windows.Forms.Control jc = this.jc;
			location = new System.Drawing.Point(73, 12);
			jc.Location = location;
			System.Windows.Forms.NumericUpDown jc2 = this.jc;
			decimal num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			jc2.Maximum = num;
			System.Windows.Forms.NumericUpDown jc3 = this.jc;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			jc3.Minimum = num;
			this.jc.Name = "jc";
			System.Windows.Forms.Control jc4 = this.jc;
			size = new System.Drawing.Size(58, 21);
			jc4.Size = size;
			this.jc.TabIndex = 2;
			this.jc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown jc5 = this.jc;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			jc5.Value = num;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label5 = this.Label3;
			location = new System.Drawing.Point(12, 119);
			label5.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label6 = this.Label3;
			size = new System.Drawing.Size(65, 12);
			label6.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "对齐方式：";
			this.dq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dq.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.dq.FormattingEnabled = true;
			this.dq.Items.AddRange(new object[]
			{
				"左对齐",
				"居中对齐",
				"右对齐"
			});
			System.Windows.Forms.Control dq = this.dq;
			location = new System.Drawing.Point(75, 116);
			dq.Location = location;
			this.dq.Name = "dq";
			System.Windows.Forms.Control dq2 = this.dq;
			size = new System.Drawing.Size(80, 20);
			dq2.Size = size;
			this.dq.TabIndex = 12;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Control label7 = this.Label5;
			location = new System.Drawing.Point(12, 149);
			label7.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label8 = this.Label5;
			size = new System.Drawing.Size(161, 12);
			label8.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "打印高度（指多少倍行高）：";
			System.Windows.Forms.Control gd = this.gd;
			location = new System.Drawing.Point(206, 147);
			gd.Location = location;
			System.Windows.Forms.NumericUpDown gd2 = this.gd;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			gd2.Maximum = num;
			System.Windows.Forms.NumericUpDown gd3 = this.gd;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			gd3.Minimum = num;
			this.gd.Name = "gd";
			System.Windows.Forms.Control gd4 = this.gd;
			size = new System.Drawing.Size(58, 21);
			gd4.Size = size;
			this.gd.TabIndex = 2;
			System.Windows.Forms.NumericUpDown gd5 = this.gd;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			gd5.Value = num;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(175, 108);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(89, 28);
			button2.Size = size;
			this.Button1.TabIndex = 13;
			this.Button1.Text = "字体及颜色";
			this.Button1.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label9 = this.Label6;
			location = new System.Drawing.Point(12, 173);
			label9.Location = location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Control label10 = this.Label6;
			size = new System.Drawing.Size(161, 25);
			label10.Size = size;
			this.Label6.TabIndex = 0;
			this.Label6.Text = "打印宽度（毫米，为0表示整个纸张可打印宽度）：";
			System.Windows.Forms.Control kd = this.kd;
			location = new System.Drawing.Point(206, 177);
			kd.Location = location;
			System.Windows.Forms.NumericUpDown kd2 = this.kd;
			num = new decimal(new int[]
			{
				1000000,
				0,
				0,
				0
			});
			kd2.Maximum = num;
			this.kd.Name = "kd";
			System.Windows.Forms.Control kd3 = this.kd;
			size = new System.Drawing.Size(58, 21);
			kd3.Size = size;
			this.kd.TabIndex = 2;
			this.Button3.DialogResult = System.Windows.Forms.DialogResult.OK;
			System.Windows.Forms.Control button3 = this.Button3;
			location = new System.Drawing.Point(40, 209);
			button3.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Control button4 = this.Button3;
			size = new System.Drawing.Size(75, 23);
			button4.Size = size;
			this.Button3.TabIndex = 14;
			this.Button3.Text = "确定";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button5 = this.Button4;
			location = new System.Drawing.Point(149, 209);
			button5.Location = location;
			this.Button4.Name = "Button4";
			System.Windows.Forms.Control button6 = this.Button4;
			size = new System.Drawing.Size(75, 23);
			button6.Size = size;
			this.Button4.TabIndex = 14;
			this.Button4.Text = "取消";
			this.Button4.UseVisualStyleBackColor = true;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(279, 241);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dq);
			this.Controls.Add(this.kd);
			this.Controls.Add(this.gd);
			this.Controls.Add(this.jc);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SimpleReportAddHeader";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "添加子标题表格尾注";
			((System.ComponentModel.ISupportInitialize)this.jc).EndInit();
			((System.ComponentModel.ISupportInitialize)this.gd).EndInit();
			((System.ComponentModel.ISupportInitialize)this.kd).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000732 RID: 1842
		private System.ComponentModel.IContainer components;
	}
}
