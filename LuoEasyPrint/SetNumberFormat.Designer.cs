namespace LuoEasyPrint
{
	
	public partial class SetNumberFormat : Form
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x0006E828 File Offset: 0x0006CA28
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

		// Token: 0x06000DCF RID: 3535 RVA: 0x0006E868 File Offset: 0x0006CA68
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.r1 = new System.Windows.Forms.RadioButton();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r3 = new System.Windows.Forms.RadioButton();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.xg = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.comptxt = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			this.r1.AutoSize = true;
			System.Windows.Forms.Control r = this.r1;
			System.Drawing.Point location = new System.Drawing.Point(12, 20);
			r.Location = location;
			this.r1.Name = "r1";
			System.Windows.Forms.Control r2 = this.r1;
			System.Drawing.Size size = new System.Drawing.Size(71, 16);
			r2.Size = size;
			this.r1.TabIndex = 0;
			this.r1.Text = "普通数值";
			this.r1.UseVisualStyleBackColor = true;
			this.r2.AutoSize = true;
			System.Windows.Forms.Control r3 = this.r2;
			location = new System.Drawing.Point(94, 20);
			r3.Location = location;
			this.r2.Name = "r2";
			System.Windows.Forms.Control r4 = this.r2;
			size = new System.Drawing.Size(59, 16);
			r4.Size = size;
			this.r2.TabIndex = 0;
			this.r2.Text = "百分比";
			this.r2.UseVisualStyleBackColor = true;
			this.r3.AutoSize = true;
			this.r3.Checked = true;
			System.Windows.Forms.Control r5 = this.r3;
			location = new System.Drawing.Point(165, 20);
			r5.Location = location;
			this.r3.Name = "r3";
			System.Windows.Forms.Control r6 = this.r3;
			size = new System.Drawing.Size(59, 16);
			r6.Size = size;
			this.r3.TabIndex = 0;
			this.r3.TabStop = true;
			this.r3.Text = "自定义";
			this.r3.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.r3);
			this.GroupBox1.Controls.Add(this.r1);
			this.GroupBox1.Controls.Add(this.r2);
			System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new System.Drawing.Point(12, 5);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new System.Drawing.Size(279, 49);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "类型";
			this.GroupBox9.Controls.Add(this.xg);
			this.GroupBox9.Controls.Add(this.Label16);
			this.GroupBox9.Controls.Add(this.comptxt);
			this.GroupBox9.Controls.Add(this.Label5);
			System.Windows.Forms.Control groupBox3 = this.GroupBox9;
			location = new System.Drawing.Point(12, 145);
			groupBox3.Location = location;
			this.GroupBox9.Name = "GroupBox9";
			System.Windows.Forms.Control groupBox4 = this.GroupBox9;
			size = new System.Drawing.Size(279, 42);
			groupBox4.Size = size;
			this.GroupBox9.TabIndex = 33;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "示例";
			System.Windows.Forms.Control xg = this.xg;
			location = new System.Drawing.Point(163, 14);
			xg.Location = location;
			this.xg.Name = "xg";
			this.xg.ReadOnly = true;
			System.Windows.Forms.Control xg2 = this.xg;
			size = new System.Drawing.Size(108, 21);
			xg2.Size = size;
			this.xg.TabIndex = 10;
			this.Label16.AutoSize = true;
			System.Windows.Forms.Control label = this.Label16;
			location = new System.Drawing.Point(125, 19);
			label.Location = location;
			this.Label16.Name = "Label16";
			System.Windows.Forms.Control label2 = this.Label16;
			size = new System.Drawing.Size(41, 12);
			label2.Size = size;
			this.Label16.TabIndex = 9;
			this.Label16.Text = "效果：";
			System.Windows.Forms.Control comptxt = this.comptxt;
			location = new System.Drawing.Point(46, 16);
			comptxt.Location = location;
			this.comptxt.Name = "comptxt";
			System.Windows.Forms.Control comptxt2 = this.comptxt;
			size = new System.Drawing.Size(76, 21);
			comptxt2.Size = size;
			this.comptxt.TabIndex = 10;
			this.comptxt.Text = "1234.56";
			this.Label5.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label5;
			location = new System.Drawing.Point(8, 19);
			label3.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label4 = this.Label5;
			size = new System.Drawing.Size(41, 12);
			label4.Size = size;
			this.Label5.TabIndex = 9;
			this.Label5.Text = "内容：";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label5 = this.Label1;
			location = new System.Drawing.Point(12, 70);
			label5.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label6 = this.Label1;
			size = new System.Drawing.Size(65, 12);
			label6.Size = size;
			this.Label1.TabIndex = 34;
			this.Label1.Text = "小数位数：";
			System.Windows.Forms.Control numericUpDown = this.NumericUpDown1;
			location = new System.Drawing.Point(72, 66);
			numericUpDown.Location = location;
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown1;
			decimal num = new decimal(new int[]
			{
				20,
				0,
				0,
				0
			});
			numericUpDown2.Maximum = num;
			this.NumericUpDown1.Name = "NumericUpDown1";
			System.Windows.Forms.Control numericUpDown3 = this.NumericUpDown1;
			size = new System.Drawing.Size(60, 21);
			numericUpDown3.Size = size;
			this.NumericUpDown1.TabIndex = 35;
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				2,
				0,
				0,
				0
			});
			numericUpDown4.Value = num;
			this.CheckBox1.AutoSize = true;
			System.Windows.Forms.Control checkBox = this.CheckBox1;
			location = new System.Drawing.Point(144, 69);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new System.Drawing.Size(108, 16);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 36;
			this.CheckBox1.Text = "用千分位分隔符";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label7 = this.Label2;
			location = new System.Drawing.Point(12, 99);
			label7.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label8 = this.Label2;
			size = new System.Drawing.Size(65, 12);
			label8.Size = size;
			this.Label2.TabIndex = 34;
			this.Label2.Text = "货币符号：";
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[]
			{
				"￥",
				"$",
				"€",
				"U.S.＄"
			});
			System.Windows.Forms.Control comboBox = this.ComboBox1;
			location = new System.Drawing.Point(73, 96);
			comboBox.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new System.Drawing.Size(59, 20);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 37;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label9 = this.Label3;
			location = new System.Drawing.Point(12, 125);
			label9.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label10 = this.Label3;
			size = new System.Drawing.Size(65, 12);
			label10.Size = size;
			this.Label3.TabIndex = 34;
			this.Label3.Text = "格 式 串：";
			System.Windows.Forms.Control textBox = this.TextBox1;
			location = new System.Drawing.Point(73, 122);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new System.Drawing.Size(191, 21);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 38;
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(68, 188);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(63, 23);
			button2.Size = size;
			this.Button1.TabIndex = 39;
			this.Button1.Text = "确定";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(159, 188);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(63, 23);
			button4.Size = size;
			this.Button2.TabIndex = 39;
			this.Button2.Text = "取消";
			this.Button2.UseVisualStyleBackColor = true;
			this.AcceptButton = this.Button1;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Button2;
			size = new System.Drawing.Size(297, 217);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.GroupBox9);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetNumberFormat";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "数值格式设置";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000701 RID: 1793
		private System.ComponentModel.IContainer components;
	}
}
