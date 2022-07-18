namespace LuoEasyPrint
{
	// Token: 0x02000078 RID: 120
	public partial class draftset : Form
	{
		// Token: 0x0600118E RID: 4494 RVA: 0x0008B7B4 File Offset: 0x000899B4
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

		// Token: 0x0600118F RID: 4495 RVA: 0x0008B7F4 File Offset: 0x000899F4
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.printername = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.GroupBox24 = new System.Windows.Forms.GroupBox();
			this.myh = new System.Windows.Forms.NumericUpDown();
			this.Label81 = new System.Windows.Forms.Label();
			this.fx = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.myw = new System.Windows.Forms.NumericUpDown();
			this.Label82 = new System.Windows.Forms.Label();
			this.papertype = new System.Windows.Forms.ComboBox();
			this.Label46 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.tpage = new System.Windows.Forms.NumericUpDown();
			this.fpage = new System.Windows.Forms.NumericUpDown();
			this.RadioButton6 = new System.Windows.Forms.RadioButton();
			this.RadioButton5 = new System.Windows.Forms.RadioButton();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myw).BeginInit();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.tpage).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fpage).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label = this.Label1;
			System.Drawing.Point location = new System.Drawing.Point(12, 6);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(53, 12);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "打印机：";
			this.printername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.printername.FormattingEnabled = true;
			System.Windows.Forms.Control printername = this.printername;
			location = new System.Drawing.Point(71, 3);
			printername.Location = location;
			this.printername.Name = "printername";
			System.Windows.Forms.Control printername2 = this.printername;
			size = new System.Drawing.Size(369, 20);
			printername2.Size = size;
			this.printername.TabIndex = 1;
			this.GroupBox1.Controls.Add(this.RadioButton4);
			this.GroupBox1.Controls.Add(this.RadioButton3);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new System.Drawing.Point(12, 178);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new System.Drawing.Size(433, 43);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "样式";
			this.RadioButton4.AutoSize = true;
			System.Windows.Forms.Control radioButton = this.RadioButton4;
			location = new System.Drawing.Point(300, 20);
			radioButton.Location = location;
			this.RadioButton4.Name = "RadioButton4";
			System.Windows.Forms.Control radioButton2 = this.RadioButton4;
			size = new System.Drawing.Size(65, 16);
			radioButton2.Size = size;
			this.RadioButton4.TabIndex = 0;
			this.RadioButton4.Text = "每页4张";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.RadioButton3.AutoSize = true;
			System.Windows.Forms.Control radioButton3 = this.RadioButton3;
			location = new System.Drawing.Point(199, 20);
			radioButton3.Location = location;
			this.RadioButton3.Name = "RadioButton3";
			System.Windows.Forms.Control radioButton4 = this.RadioButton3;
			size = new System.Drawing.Size(65, 16);
			radioButton4.Size = size;
			this.RadioButton3.TabIndex = 0;
			this.RadioButton3.Text = "每页3张";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			System.Windows.Forms.Control radioButton5 = this.RadioButton2;
			location = new System.Drawing.Point(96, 20);
			radioButton5.Location = location;
			this.RadioButton2.Name = "RadioButton2";
			System.Windows.Forms.Control radioButton6 = this.RadioButton2;
			size = new System.Drawing.Size(65, 16);
			radioButton6.Size = size;
			this.RadioButton2.TabIndex = 0;
			this.RadioButton2.Text = "每页2张";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			System.Windows.Forms.Control radioButton7 = this.RadioButton1;
			location = new System.Drawing.Point(6, 20);
			radioButton7.Location = location;
			this.RadioButton1.Name = "RadioButton1";
			System.Windows.Forms.Control radioButton8 = this.RadioButton1;
			size = new System.Drawing.Size(65, 16);
			radioButton8.Size = size;
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "每页1张";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.GroupBox24.Controls.Add(this.myh);
			this.GroupBox24.Controls.Add(this.Label81);
			this.GroupBox24.Controls.Add(this.fx);
			this.GroupBox24.Controls.Add(this.Label4);
			this.GroupBox24.Controls.Add(this.myw);
			this.GroupBox24.Controls.Add(this.Label82);
			this.GroupBox24.Controls.Add(this.papertype);
			this.GroupBox24.Controls.Add(this.Label46);
			System.Windows.Forms.Control groupBox3 = this.GroupBox24;
			location = new System.Drawing.Point(14, 29);
			groupBox3.Location = location;
			this.GroupBox24.Name = "GroupBox24";
			System.Windows.Forms.Control groupBox4 = this.GroupBox24;
			size = new System.Drawing.Size(436, 96);
			groupBox4.Size = size;
			this.GroupBox24.TabIndex = 13;
			this.GroupBox24.TabStop = false;
			this.GroupBox24.Text = "纸张";
			this.myh.DecimalPlaces = 2;
			System.Windows.Forms.Control myh = this.myh;
			location = new System.Drawing.Point(229, 55);
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
			size = new System.Drawing.Size(68, 21);
			myh3.Size = size;
			this.myh.TabIndex = 3;
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
			this.Label81.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label81;
			location = new System.Drawing.Point(152, 59);
			label3.Location = location;
			this.Label81.Name = "Label81";
			System.Windows.Forms.Control label4 = this.Label81;
			size = new System.Drawing.Size(77, 12);
			label4.Size = size;
			this.Label81.TabIndex = 28;
			this.Label81.Text = "高度(毫米)：";
			this.fx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fx.FormattingEnabled = true;
			this.fx.Items.AddRange(new object[]
			{
				"横向",
				"纵向"
			});
			System.Windows.Forms.Control fx = this.fx;
			location = new System.Drawing.Point(367, 55);
			fx.Location = location;
			this.fx.Name = "fx";
			System.Windows.Forms.Control fx2 = this.fx;
			size = new System.Drawing.Size(61, 20);
			fx2.Size = size;
			this.fx.TabIndex = 4;
			this.Label4.AutoSize = true;
			System.Windows.Forms.Control label5 = this.Label4;
			location = new System.Drawing.Point(302, 59);
			label5.Location = location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Control label6 = this.Label4;
			size = new System.Drawing.Size(65, 12);
			label6.Size = size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "打印方向：";
			this.myw.DecimalPlaces = 2;
			System.Windows.Forms.Control myw = this.myw;
			location = new System.Drawing.Point(79, 55);
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
			size = new System.Drawing.Size(68, 21);
			myw3.Size = size;
			this.myw.TabIndex = 2;
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
			this.Label82.AutoSize = true;
			System.Windows.Forms.Control label7 = this.Label82;
			location = new System.Drawing.Point(5, 59);
			label7.Location = location;
			this.Label82.Name = "Label82";
			System.Windows.Forms.Control label8 = this.Label82;
			size = new System.Drawing.Size(77, 12);
			label8.Size = size;
			this.Label82.TabIndex = 27;
			this.Label82.Text = "宽度(毫米)：";
			this.papertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.papertype.FormattingEnabled = true;
			System.Windows.Forms.Control papertype = this.papertype;
			location = new System.Drawing.Point(70, 22);
			papertype.Location = location;
			this.papertype.Name = "papertype";
			System.Windows.Forms.Control papertype2 = this.papertype;
			size = new System.Drawing.Size(358, 20);
			papertype2.Size = size;
			this.papertype.TabIndex = 1;
			this.Label46.AutoSize = true;
			System.Windows.Forms.Control label9 = this.Label46;
			location = new System.Drawing.Point(5, 26);
			label9.Location = location;
			this.Label46.Name = "Label46";
			System.Windows.Forms.Control label10 = this.Label46;
			size = new System.Drawing.Size(65, 12);
			label10.Size = size;
			this.Label46.TabIndex = 3;
			this.Label46.Text = "打印纸张：";
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(285, 228);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(75, 29);
			button2.Size = size;
			this.Button1.TabIndex = 14;
			this.Button1.Text = "打印预览";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(372, 228);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(75, 29);
			button4.Size = size;
			this.Button2.TabIndex = 14;
			this.Button2.Text = "取消";
			this.Button2.UseVisualStyleBackColor = true;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Checked = true;
			this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control checkBox = this.CheckBox1;
			location = new System.Drawing.Point(12, 232);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new System.Drawing.Size(144, 16);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 15;
			this.CheckBox1.Text = "用竖线或横线分隔每页";
			this.CheckBox1.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button5 = this.Button3;
			location = new System.Drawing.Point(193, 228);
			button5.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Control button6 = this.Button3;
			size = new System.Drawing.Size(75, 29);
			button6.Size = size;
			this.Button3.TabIndex = 14;
			this.Button3.Text = "开始打印";
			this.Button3.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.tpage);
			this.GroupBox2.Controls.Add(this.fpage);
			this.GroupBox2.Controls.Add(this.RadioButton6);
			this.GroupBox2.Controls.Add(this.RadioButton5);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.Label2);
			System.Windows.Forms.Control groupBox5 = this.GroupBox2;
			location = new System.Drawing.Point(14, 131);
			groupBox5.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.Control groupBox6 = this.GroupBox2;
			size = new System.Drawing.Size(436, 41);
			groupBox6.Size = size;
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "页码范围";
			System.Windows.Forms.Control tpage = this.tpage;
			location = new System.Drawing.Point(310, 15);
			tpage.Location = location;
			System.Windows.Forms.NumericUpDown tpage2 = this.tpage;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			tpage2.Maximum = num;
			System.Windows.Forms.NumericUpDown tpage3 = this.tpage;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			tpage3.Minimum = num;
			this.tpage.Name = "tpage";
			System.Windows.Forms.Control tpage4 = this.tpage;
			size = new System.Drawing.Size(63, 21);
			tpage4.Size = size;
			this.tpage.TabIndex = 3;
			this.tpage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown tpage5 = this.tpage;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			tpage5.Value = num;
			System.Windows.Forms.Control fpage = this.fpage;
			location = new System.Drawing.Point(212, 15);
			fpage.Location = location;
			System.Windows.Forms.NumericUpDown fpage2 = this.fpage;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			fpage2.Maximum = num;
			System.Windows.Forms.NumericUpDown fpage3 = this.fpage;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			fpage3.Minimum = num;
			this.fpage.Name = "fpage";
			System.Windows.Forms.Control fpage4 = this.fpage;
			size = new System.Drawing.Size(63, 21);
			fpage4.Size = size;
			this.fpage.TabIndex = 3;
			this.fpage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown fpage5 = this.fpage;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			fpage5.Value = num;
			this.RadioButton6.AutoSize = true;
			System.Windows.Forms.Control radioButton9 = this.RadioButton6;
			location = new System.Drawing.Point(94, 17);
			radioButton9.Location = location;
			this.RadioButton6.Name = "RadioButton6";
			System.Windows.Forms.Control radioButton10 = this.RadioButton6;
			size = new System.Drawing.Size(59, 16);
			radioButton10.Size = size;
			this.RadioButton6.TabIndex = 0;
			this.RadioButton6.Text = "指定页";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Checked = true;
			System.Windows.Forms.Control radioButton11 = this.RadioButton5;
			location = new System.Drawing.Point(17, 17);
			radioButton11.Location = location;
			this.RadioButton5.Name = "RadioButton5";
			System.Windows.Forms.Control radioButton12 = this.RadioButton5;
			size = new System.Drawing.Size(59, 16);
			radioButton12.Size = size;
			this.RadioButton5.TabIndex = 0;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "全部页";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label11 = this.Label3;
			location = new System.Drawing.Point(281, 19);
			label11.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label12 = this.Label3;
			size = new System.Drawing.Size(0, 12);
			label12.Size = size;
			this.Label3.TabIndex = 0;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Control label13 = this.Label5;
			location = new System.Drawing.Point(287, 19);
			label13.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label14 = this.Label5;
			size = new System.Drawing.Size(17, 12);
			label14.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "到";
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label15 = this.Label2;
			location = new System.Drawing.Point(177, 19);
			label15.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label16 = this.Label2;
			size = new System.Drawing.Size(29, 12);
			label16.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "从：";
			this.AcceptButton = this.Button3;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(459, 260);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox24);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.printername);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.Name = "draftset";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "草稿打印设置";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox24.ResumeLayout(false);
			this.GroupBox24.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myw).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.tpage).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fpage).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040008AD RID: 2221
		private System.ComponentModel.IContainer components;
	}
}
