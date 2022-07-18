namespace LuoEasyPrint
{

	public partial class ReportPageSetup : Form
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				if (this.mypp != null)
				{
					this.mypp.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0004EC00 File Offset: 0x0004CE00
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.myh = new System.Windows.Forms.NumericUpDown();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.myw = new System.Windows.Forms.NumericUpDown();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.fx2 = new System.Windows.Forms.RadioButton();
			this.fx1 = new System.Windows.Forms.RadioButton();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.printb = new System.Windows.Forms.NumericUpDown();
			this.printr = new System.Windows.Forms.NumericUpDown();
			this.Label14 = new System.Windows.Forms.Label();
			this.printt = new System.Windows.Forms.NumericUpDown();
			this.Label12 = new System.Windows.Forms.Label();
			this.printl = new System.Windows.Forms.NumericUpDown();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.dq3 = new System.Windows.Forms.RadioButton();
			this.dq2 = new System.Windows.Forms.RadioButton();
			this.dq1 = new System.Windows.Forms.RadioButton();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myw).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.printb).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printr).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printl).BeginInit();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.myh);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.myw);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			System.Windows.Forms.Control groupBox = this.GroupBox1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			System.Drawing.Size size = new System.Drawing.Size(297, 100);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "打印纸张";
			this.myh.DecimalPlaces = 2;
			System.Windows.Forms.Control myh = this.myh;
			location = new System.Drawing.Point(130, 72);
			myh.Location = location;
			System.Windows.Forms.NumericUpDown myh2 = this.myh;
			decimal num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			myh2.Maximum = num;
			this.myh.Name = "myh";
			System.Windows.Forms.Control myh3 = this.myh;
			size = new System.Drawing.Size(160, 21);
			myh3.Size = size;
			this.myh.TabIndex = 25;
			this.myh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown myh4 = this.myh;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			myh4.Value = num;
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			System.Windows.Forms.Control comboBox = this.ComboBox1;
			location = new System.Drawing.Point(130, 17);
			comboBox.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new System.Drawing.Size(161, 20);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 1;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label = this.Label3;
			location = new System.Drawing.Point(12, 76);
			label.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label2 = this.Label3;
			size = new System.Drawing.Size(113, 12);
			label2.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "纸张高度（毫米）：";
			this.myw.DecimalPlaces = 2;
			System.Windows.Forms.Control myw = this.myw;
			location = new System.Drawing.Point(130, 45);
			myw.Location = location;
			System.Windows.Forms.NumericUpDown myw2 = this.myw;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			myw2.Maximum = num;
			this.myw.Name = "myw";
			System.Windows.Forms.Control myw3 = this.myw;
			size = new System.Drawing.Size(160, 21);
			myw3.Size = size;
			this.myw.TabIndex = 26;
			this.myw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown myw4 = this.myw;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			myw4.Value = num;
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label2;
			location = new System.Drawing.Point(12, 47);
			label3.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label4 = this.Label2;
			size = new System.Drawing.Size(113, 12);
			label4.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "纸张宽度（毫米）：";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label5 = this.Label1;
			location = new System.Drawing.Point(12, 20);
			label5.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label6 = this.Label1;
			size = new System.Drawing.Size(65, 12);
			label6.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "张纸名称：";
			this.GroupBox2.Controls.Add(this.fx2);
			this.GroupBox2.Controls.Add(this.fx1);
			System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new System.Drawing.Point(0, 106);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new System.Drawing.Size(89, 78);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "打印方向";
			this.fx2.AutoSize = true;
			System.Windows.Forms.Control fx = this.fx2;
			location = new System.Drawing.Point(10, 50);
			fx.Location = location;
			this.fx2.Name = "fx2";
			System.Windows.Forms.Control fx2 = this.fx2;
			size = new System.Drawing.Size(71, 16);
			fx2.Size = size;
			this.fx2.TabIndex = 0;
			this.fx2.TabStop = true;
			this.fx2.Text = "横向打印";
			this.fx2.UseVisualStyleBackColor = true;
			this.fx1.AutoSize = true;
			System.Windows.Forms.Control fx3 = this.fx1;
			location = new System.Drawing.Point(10, 25);
			fx3.Location = location;
			this.fx1.Name = "fx1";
			System.Windows.Forms.Control fx4 = this.fx1;
			size = new System.Drawing.Size(71, 16);
			fx4.Size = size;
			this.fx1.TabIndex = 0;
			this.fx1.TabStop = true;
			this.fx1.Text = "纵向打印";
			this.fx1.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.printb);
			this.GroupBox3.Controls.Add(this.printr);
			this.GroupBox3.Controls.Add(this.Label14);
			this.GroupBox3.Controls.Add(this.printt);
			this.GroupBox3.Controls.Add(this.Label12);
			this.GroupBox3.Controls.Add(this.printl);
			this.GroupBox3.Controls.Add(this.Label13);
			this.GroupBox3.Controls.Add(this.Label11);
			System.Windows.Forms.Control groupBox5 = this.GroupBox3;
			location = new System.Drawing.Point(92, 106);
			groupBox5.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			size = new System.Drawing.Size(203, 78);
			groupBox6.Size = size;
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "页边距（毫米）";
			this.printb.DecimalPlaces = 2;
			System.Windows.Forms.Control printb = this.printb;
			location = new System.Drawing.Point(135, 47);
			printb.Location = location;
			System.Windows.Forms.NumericUpDown printb2 = this.printb;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			printb2.Maximum = num;
			this.printb.Name = "printb";
			System.Windows.Forms.Control printb3 = this.printb;
			size = new System.Drawing.Size(62, 21);
			printb3.Size = size;
			this.printb.TabIndex = 27;
			this.printb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown printb4 = this.printb;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			printb4.Value = num;
			this.printr.DecimalPlaces = 2;
			System.Windows.Forms.Control printr = this.printr;
			location = new System.Drawing.Point(135, 20);
			printr.Location = location;
			System.Windows.Forms.NumericUpDown printr2 = this.printr;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			printr2.Maximum = num;
			this.printr.Name = "printr";
			System.Windows.Forms.Control printr3 = this.printr;
			size = new System.Drawing.Size(62, 21);
			printr3.Size = size;
			this.printr.TabIndex = 25;
			this.printr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown printr4 = this.printr;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			printr4.Value = num;
			this.Label14.AutoSize = true;
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label7 = this.Label14;
			location = new System.Drawing.Point(8, 24);
			label7.Location = location;
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label8 = this.Label14;
			size = new System.Drawing.Size(29, 12);
			label8.Size = size;
			this.Label14.TabIndex = 23;
			this.Label14.Text = "左边";
			this.printt.DecimalPlaces = 2;
			System.Windows.Forms.Control printt = this.printt;
			location = new System.Drawing.Point(39, 47);
			printt.Location = location;
			System.Windows.Forms.NumericUpDown printt2 = this.printt;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			printt2.Maximum = num;
			this.printt.Name = "printt";
			System.Windows.Forms.Control printt3 = this.printt;
			size = new System.Drawing.Size(62, 21);
			printt3.Size = size;
			this.printt.TabIndex = 28;
			this.printt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown printt4 = this.printt;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			printt4.Value = num;
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label9 = this.Label12;
			location = new System.Drawing.Point(105, 24);
			label9.Location = location;
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label10 = this.Label12;
			size = new System.Drawing.Size(29, 12);
			label10.Size = size;
			this.Label12.TabIndex = 21;
			this.Label12.Text = "右边";
			this.printl.DecimalPlaces = 2;
			System.Windows.Forms.Control printl = this.printl;
			location = new System.Drawing.Point(39, 20);
			printl.Location = location;
			System.Windows.Forms.NumericUpDown printl2 = this.printl;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			printl2.Maximum = num;
			this.printl.Name = "printl";
			System.Windows.Forms.Control printl3 = this.printl;
			size = new System.Drawing.Size(62, 21);
			printl3.Size = size;
			this.printl.TabIndex = 26;
			this.printl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown printl4 = this.printl;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			printl4.Value = num;
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label11 = this.Label13;
			location = new System.Drawing.Point(4, 51);
			label11.Location = location;
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label12 = this.Label13;
			size = new System.Drawing.Size(29, 12);
			label12.Size = size;
			this.Label13.TabIndex = 24;
			this.Label13.Text = "上边";
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label13 = this.Label11;
			location = new System.Drawing.Point(105, 51);
			label13.Location = location;
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label14 = this.Label11;
			size = new System.Drawing.Size(29, 12);
			label14.Size = size;
			this.Label11.TabIndex = 22;
			this.Label11.Text = "下边";
			this.GroupBox4.Controls.Add(this.dq3);
			this.GroupBox4.Controls.Add(this.dq2);
			this.GroupBox4.Controls.Add(this.dq1);
			System.Windows.Forms.Control groupBox7 = this.GroupBox4;
			location = new System.Drawing.Point(0, 190);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			System.Windows.Forms.Control groupBox8 = this.GroupBox4;
			size = new System.Drawing.Size(295, 46);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "对齐方式";
			this.dq3.AutoSize = true;
			System.Windows.Forms.Control dq = this.dq3;
			location = new System.Drawing.Point(186, 20);
			dq.Location = location;
			this.dq3.Name = "dq3";
			System.Windows.Forms.Control dq2 = this.dq3;
			size = new System.Drawing.Size(95, 16);
			dq2.Size = size;
			this.dq3.TabIndex = 0;
			this.dq3.TabStop = true;
			this.dq3.Text = "靠右边距对齐";
			this.dq3.UseVisualStyleBackColor = true;
			this.dq2.AutoSize = true;
			System.Windows.Forms.Control dq3 = this.dq2;
			location = new System.Drawing.Point(112, 20);
			dq3.Location = location;
			this.dq2.Name = "dq2";
			System.Windows.Forms.Control dq4 = this.dq2;
			size = new System.Drawing.Size(71, 16);
			dq4.Size = size;
			this.dq2.TabIndex = 0;
			this.dq2.TabStop = true;
			this.dq2.Text = "居中对齐";
			this.dq2.UseVisualStyleBackColor = true;
			this.dq1.AutoSize = true;
			System.Windows.Forms.Control dq5 = this.dq1;
			location = new System.Drawing.Point(10, 20);
			dq5.Location = location;
			this.dq1.Name = "dq1";
			System.Windows.Forms.Control dq6 = this.dq1;
			size = new System.Drawing.Size(95, 16);
			dq6.Size = size;
			this.dq1.TabIndex = 0;
			this.dq1.TabStop = true;
			this.dq1.Text = "靠左边距对齐";
			this.dq1.UseVisualStyleBackColor = true;
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(130, 243);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(75, 26);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "确定";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(211, 243);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(75, 26);
			button4.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消";
			this.Button2.UseVisualStyleBackColor = true;
			this.AcceptButton = this.Button1;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Button2;
			size = new System.Drawing.Size(297, 274);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReportPageSetup";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "报表打印设置";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myw).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.printb).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printr).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printl).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040004A3 RID: 1187
		private System.ComponentModel.IContainer components;

		// Token: 0x040004C7 RID: 1223
		private CommomPaperSize mypp;
	}
}
