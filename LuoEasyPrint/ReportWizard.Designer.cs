namespace LuoEasyPrint
{
	
	public partial class ReportWizard : Form
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x0005073C File Offset: 0x0004E93C
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

		// Token: 0x060008AD RID: 2221 RVA: 0x0005078C File Offset: 0x0004E98C
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.rowheight = new System.Windows.Forms.NumericUpDown();
			this.Label6 = new System.Windows.Forms.Label();
			this.colheaderheight = new System.Windows.Forms.NumericUpDown();
			this.Label5 = new System.Windows.Forms.Label();
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
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.fx2 = new System.Windows.Forms.RadioButton();
			this.fx1 = new System.Windows.Forms.RadioButton();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.myh = new System.Windows.Forms.NumericUpDown();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.myw = new System.Windows.Forms.NumericUpDown();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox12 = new System.Windows.Forms.GroupBox();
			this.rowidaddnewpage = new System.Windows.Forms.CheckBox();
			this.rowidadd = new System.Windows.Forms.CheckBox();
			this.rowid = new System.Windows.Forms.NumericUpDown();
			this.Label16 = new System.Windows.Forms.Label();
			this.C1 = new System.Windows.Forms.CheckedListBox();
			this.GroupBox10 = new System.Windows.Forms.GroupBox();
			this.Button30 = new System.Windows.Forms.Button();
			this.Button16 = new System.Windows.Forms.Button();
			this.Button17 = new System.Windows.Forms.Button();
			this.headerfont = new System.Windows.Forms.Label();
			this.Button11 = new System.Windows.Forms.Button();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.GroupBox13 = new System.Windows.Forms.GroupBox();
			this.Button19 = new System.Windows.Forms.Button();
			this.Button18 = new System.Windows.Forms.Button();
			this.Button13 = new System.Windows.Forms.Button();
			this.Button12 = new System.Windows.Forms.Button();
			this.columnfont = new System.Windows.Forms.Label();
			this.Button9 = new System.Windows.Forms.Button();
			this.ml = new System.Windows.Forms.ComboBox();
			this.ldq = new System.Windows.Forms.ComboBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Label9 = new System.Windows.Forms.Label();
			this.GroupBox14 = new System.Windows.Forms.GroupBox();
			this.t3 = new System.Windows.Forms.TextBox();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.jj = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.zoomtopaper = new System.Windows.Forms.CheckBox();
			this.emptyrow = new System.Windows.Forms.CheckBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.GroupBox11 = new System.Windows.Forms.GroupBox();
			this.pagetitle = new System.Windows.Forms.TextBox();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.t2 = new System.Windows.Forms.TextBox();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.t1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
			this.FontDialog1 = new System.Windows.Forms.FontDialog();
			this.Label7 = new System.Windows.Forms.Label();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.rowheight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.colheaderheight).BeginInit();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.printb).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printr).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.printl).BeginInit();
			this.GroupBox4.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myw).BeginInit();
			this.TabPage2.SuspendLayout();
			this.GroupBox12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.rowid).BeginInit();
			this.GroupBox10.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.GroupBox13.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.GroupBox14.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.jj).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown2).BeginInit();
			this.GroupBox11.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.SuspendLayout();
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			System.Windows.Forms.Control tabControl = this.TabControl1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			tabControl.Location = location;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			System.Windows.Forms.Control tabControl2 = this.TabControl1;
			System.Drawing.Size size = new System.Drawing.Size(359, 414);
			tabControl2.Size = size;
			this.TabControl1.TabIndex = 0;
			this.TabPage1.Controls.Add(this.GroupBox5);
			this.TabPage1.Controls.Add(this.GroupBox3);
			this.TabPage1.Controls.Add(this.GroupBox4);
			this.TabPage1.Controls.Add(this.GroupBox2);
			this.TabPage1.Controls.Add(this.GroupBox1);
			System.Windows.Forms.TabPage tabPage = this.TabPage1;
			location = new System.Drawing.Point(4, 21);
			tabPage.Location = location;
			this.TabPage1.Name = "TabPage1";
			System.Windows.Forms.Control tabPage2 = this.TabPage1;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
			tabPage2.Padding = padding;
			System.Windows.Forms.Control tabPage3 = this.TabPage1;
			size = new System.Drawing.Size(351, 389);
			tabPage3.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "报表模板页面设置";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.GroupBox5.Controls.Add(this.rowheight);
			this.GroupBox5.Controls.Add(this.Label6);
			this.GroupBox5.Controls.Add(this.colheaderheight);
			this.GroupBox5.Controls.Add(this.Label5);
			System.Windows.Forms.Control groupBox = this.GroupBox5;
			location = new System.Drawing.Point(24, 249);
			groupBox.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			System.Windows.Forms.Control groupBox2 = this.GroupBox5;
			size = new System.Drawing.Size(294, 77);
			groupBox2.Size = size;
			this.GroupBox5.TabIndex = 27;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "表格高度设置";
			this.rowheight.DecimalPlaces = 2;
			System.Windows.Forms.Control rowheight = this.rowheight;
			location = new System.Drawing.Point(194, 48);
			rowheight.Location = location;
			this.rowheight.Name = "rowheight";
			System.Windows.Forms.Control rowheight2 = this.rowheight;
			size = new System.Drawing.Size(84, 21);
			rowheight2.Size = size;
			this.rowheight.TabIndex = 26;
			this.rowheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown rowheight3 = this.rowheight;
			decimal num = new decimal(new int[]
			{
				7,
				0,
				0,
				0
			});
			rowheight3.Value = num;
			this.Label6.AutoSize = true;
			System.Windows.Forms.Control label = this.Label6;
			location = new System.Drawing.Point(6, 50);
			label.Location = location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Control label2 = this.Label6;
			size = new System.Drawing.Size(173, 12);
			label2.Size = size;
			this.Label6.TabIndex = 0;
			this.Label6.Text = "表格单行数据行高度（毫米）：";
			this.colheaderheight.DecimalPlaces = 2;
			System.Windows.Forms.Control colheaderheight = this.colheaderheight;
			location = new System.Drawing.Point(194, 20);
			colheaderheight.Location = location;
			this.colheaderheight.Name = "colheaderheight";
			System.Windows.Forms.Control colheaderheight2 = this.colheaderheight;
			size = new System.Drawing.Size(84, 21);
			colheaderheight2.Size = size;
			this.colheaderheight.TabIndex = 26;
			this.colheaderheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown colheaderheight3 = this.colheaderheight;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			colheaderheight3.Value = num;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label5;
			location = new System.Drawing.Point(6, 22);
			label3.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label4 = this.Label5;
			size = new System.Drawing.Size(173, 12);
			label4.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "表格列标题行的高度（毫米）：";
			this.GroupBox3.Controls.Add(this.printb);
			this.GroupBox3.Controls.Add(this.printr);
			this.GroupBox3.Controls.Add(this.Label14);
			this.GroupBox3.Controls.Add(this.printt);
			this.GroupBox3.Controls.Add(this.Label12);
			this.GroupBox3.Controls.Add(this.printl);
			this.GroupBox3.Controls.Add(this.Label13);
			this.GroupBox3.Controls.Add(this.Label11);
			System.Windows.Forms.Control groupBox3 = this.GroupBox3;
			location = new System.Drawing.Point(118, 112);
			groupBox3.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			System.Windows.Forms.Control groupBox4 = this.GroupBox3;
			size = new System.Drawing.Size(203, 78);
			groupBox4.Size = size;
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "页边距（毫米）";
			this.printb.DecimalPlaces = 2;
			System.Windows.Forms.Control printb = this.printb;
			location = new System.Drawing.Point(135, 47);
			printb.Location = location;
			System.Windows.Forms.NumericUpDown printb2 = this.printb;
			num = new decimal(new int[]
			{
				150,
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
				150,
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
			System.Windows.Forms.Control label5 = this.Label14;
			location = new System.Drawing.Point(8, 24);
			label5.Location = location;
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label6 = this.Label14;
			size = new System.Drawing.Size(29, 12);
			label6.Size = size;
			this.Label14.TabIndex = 23;
			this.Label14.Text = "左边";
			this.printt.DecimalPlaces = 2;
			System.Windows.Forms.Control printt = this.printt;
			location = new System.Drawing.Point(39, 47);
			printt.Location = location;
			System.Windows.Forms.NumericUpDown printt2 = this.printt;
			num = new decimal(new int[]
			{
				150,
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
			System.Windows.Forms.Control label7 = this.Label12;
			location = new System.Drawing.Point(105, 24);
			label7.Location = location;
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label8 = this.Label12;
			size = new System.Drawing.Size(29, 12);
			label8.Size = size;
			this.Label12.TabIndex = 21;
			this.Label12.Text = "右边";
			this.printl.DecimalPlaces = 2;
			System.Windows.Forms.Control printl = this.printl;
			location = new System.Drawing.Point(39, 20);
			printl.Location = location;
			System.Windows.Forms.NumericUpDown printl2 = this.printl;
			num = new decimal(new int[]
			{
				150,
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
				10,
				0,
				0,
				0
			});
			printl4.Value = num;
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label9 = this.Label13;
			location = new System.Drawing.Point(4, 51);
			label9.Location = location;
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label10 = this.Label13;
			size = new System.Drawing.Size(29, 12);
			label10.Size = size;
			this.Label13.TabIndex = 24;
			this.Label13.Text = "上边";
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			System.Windows.Forms.Control label11 = this.Label11;
			location = new System.Drawing.Point(105, 51);
			label11.Location = location;
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			System.Windows.Forms.Control label12 = this.Label11;
			size = new System.Drawing.Size(29, 12);
			label12.Size = size;
			this.Label11.TabIndex = 22;
			this.Label11.Text = "下边";
			this.GroupBox4.Controls.Add(this.dq3);
			this.GroupBox4.Controls.Add(this.dq2);
			this.GroupBox4.Controls.Add(this.dq1);
			System.Windows.Forms.Control groupBox5 = this.GroupBox4;
			location = new System.Drawing.Point(24, 198);
			groupBox5.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			System.Windows.Forms.Control groupBox6 = this.GroupBox4;
			size = new System.Drawing.Size(295, 46);
			groupBox6.Size = size;
			this.GroupBox4.TabIndex = 5;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "整个模板在纸张中的对齐方式";
			this.dq3.AutoSize = true;
			System.Windows.Forms.Control dq = this.dq3;
			location = new System.Drawing.Point(186, 20);
			dq.Location = location;
			this.dq3.Name = "dq3";
			System.Windows.Forms.Control dq2 = this.dq3;
			size = new System.Drawing.Size(95, 16);
			dq2.Size = size;
			this.dq3.TabIndex = 0;
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
			this.dq2.Text = "居中对齐";
			this.dq2.UseVisualStyleBackColor = true;
			this.dq1.AutoSize = true;
			this.dq1.Checked = true;
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
			this.GroupBox2.Controls.Add(this.fx2);
			this.GroupBox2.Controls.Add(this.fx1);
			System.Windows.Forms.Control groupBox7 = this.GroupBox2;
			location = new System.Drawing.Point(26, 112);
			groupBox7.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.Control groupBox8 = this.GroupBox2;
			size = new System.Drawing.Size(89, 78);
			groupBox8.Size = size;
			this.GroupBox2.TabIndex = 4;
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
			this.fx1.Checked = true;
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
			this.GroupBox1.Controls.Add(this.myh);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.myw);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			System.Windows.Forms.Control groupBox9 = this.GroupBox1;
			location = new System.Drawing.Point(28, 3);
			groupBox9.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox10 = this.GroupBox1;
			size = new System.Drawing.Size(294, 100);
			groupBox10.Size = size;
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "打印纸张";
			this.myh.DecimalPlaces = 2;
			System.Windows.Forms.Control myh = this.myh;
			location = new System.Drawing.Point(130, 72);
			myh.Location = location;
			System.Windows.Forms.NumericUpDown myh2 = this.myh;
			num = new decimal(new int[]
			{
				1500,
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
			System.Windows.Forms.Control label13 = this.Label3;
			location = new System.Drawing.Point(12, 76);
			label13.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label14 = this.Label3;
			size = new System.Drawing.Size(113, 12);
			label14.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "张纸高度（毫米）：";
			this.myw.DecimalPlaces = 2;
			System.Windows.Forms.Control myw = this.myw;
			location = new System.Drawing.Point(130, 45);
			myw.Location = location;
			System.Windows.Forms.NumericUpDown myw2 = this.myw;
			num = new decimal(new int[]
			{
				1500,
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
			System.Windows.Forms.Control label15 = this.Label2;
			location = new System.Drawing.Point(12, 47);
			label15.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label16 = this.Label2;
			size = new System.Drawing.Size(113, 12);
			label16.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "张纸宽度（毫米）：";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label17 = this.Label1;
			location = new System.Drawing.Point(12, 20);
			label17.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label18 = this.Label1;
			size = new System.Drawing.Size(65, 12);
			label18.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "张纸名称：";
			this.TabPage2.Controls.Add(this.GroupBox12);
			this.TabPage2.Controls.Add(this.C1);
			this.TabPage2.Controls.Add(this.GroupBox10);
			this.TabPage2.Controls.Add(this.GroupBox9);
			this.TabPage2.Controls.Add(this.Label8);
			System.Windows.Forms.TabPage tabPage4 = this.TabPage2;
			location = new System.Drawing.Point(4, 21);
			tabPage4.Location = location;
			this.TabPage2.Name = "TabPage2";
			System.Windows.Forms.Control tabPage5 = this.TabPage2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage5.Padding = padding;
			System.Windows.Forms.Control tabPage6 = this.TabPage2;
			size = new System.Drawing.Size(351, 389);
			tabPage6.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "数据列设置";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.GroupBox12.Controls.Add(this.rowidaddnewpage);
			this.GroupBox12.Controls.Add(this.rowidadd);
			this.GroupBox12.Controls.Add(this.rowid);
			this.GroupBox12.Controls.Add(this.Label16);
			System.Windows.Forms.Control groupBox11 = this.GroupBox12;
			location = new System.Drawing.Point(7, 328);
			groupBox11.Location = location;
			this.GroupBox12.Name = "GroupBox12";
			System.Windows.Forms.Control groupBox12 = this.GroupBox12;
			size = new System.Drawing.Size(336, 53);
			groupBox12.Size = size;
			this.GroupBox12.TabIndex = 33;
			this.GroupBox12.TabStop = false;
			this.GroupBox12.Text = "添加行号列";
			System.Windows.Forms.Control rowidaddnewpage = this.rowidaddnewpage;
			location = new System.Drawing.Point(102, 19);
			rowidaddnewpage.Location = location;
			this.rowidaddnewpage.Name = "rowidaddnewpage";
			System.Windows.Forms.Control rowidaddnewpage2 = this.rowidaddnewpage;
			size = new System.Drawing.Size(97, 28);
			rowidaddnewpage2.Size = size;
			this.rowidaddnewpage.TabIndex = 27;
			this.rowidaddnewpage.Text = "每页行号从1开始重新编号";
			this.rowidaddnewpage.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control rowidadd = this.rowidadd;
			location = new System.Drawing.Point(12, 19);
			rowidadd.Location = location;
			this.rowidadd.Name = "rowidadd";
			System.Windows.Forms.Control rowidadd2 = this.rowidadd;
			size = new System.Drawing.Size(87, 28);
			rowidadd2.Size = size;
			this.rowidadd.TabIndex = 27;
			this.rowidadd.Text = "在首列前添加行号列";
			this.rowidadd.UseVisualStyleBackColor = true;
			this.rowid.DecimalPlaces = 1;
			System.Windows.Forms.Control rowid = this.rowid;
			location = new System.Drawing.Point(273, 23);
			rowid.Location = location;
			this.rowid.Name = "rowid";
			System.Windows.Forms.Control rowid2 = this.rowid;
			size = new System.Drawing.Size(55, 21);
			rowid2.Size = size;
			this.rowid.TabIndex = 26;
			System.Windows.Forms.NumericUpDown rowid3 = this.rowid;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			rowid3.Value = num;
			System.Windows.Forms.Control label19 = this.Label16;
			location = new System.Drawing.Point(208, 20);
			label19.Location = location;
			this.Label16.Name = "Label16";
			System.Windows.Forms.Control label20 = this.Label16;
			size = new System.Drawing.Size(58, 27);
			label20.Size = size;
			this.Label16.TabIndex = 9;
			this.Label16.Text = "列宽（毫米）：";
			this.C1.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.C1.FormattingEnabled = true;
			this.C1.HorizontalScrollbar = true;
			System.Windows.Forms.Control c = this.C1;
			location = new System.Drawing.Point(3, 20);
			c.Location = location;
			this.C1.Name = "C1";
			System.Windows.Forms.Control c2 = this.C1;
			size = new System.Drawing.Size(161, 292);
			c2.Size = size;
			this.C1.TabIndex = 29;
			this.GroupBox10.Controls.Add(this.Button30);
			this.GroupBox10.Controls.Add(this.Button16);
			this.GroupBox10.Controls.Add(this.Button17);
			this.GroupBox10.Controls.Add(this.headerfont);
			this.GroupBox10.Controls.Add(this.Button11);
			System.Windows.Forms.Control groupBox13 = this.GroupBox10;
			location = new System.Drawing.Point(168, 206);
			groupBox13.Location = location;
			this.GroupBox10.Name = "GroupBox10";
			System.Windows.Forms.Control groupBox14 = this.GroupBox10;
			size = new System.Drawing.Size(178, 121);
			groupBox14.Size = size;
			this.GroupBox10.TabIndex = 32;
			this.GroupBox10.TabStop = false;
			this.GroupBox10.Text = "选中列的列标题格式设置";
			System.Windows.Forms.Control button = this.Button30;
			location = new System.Drawing.Point(7, 88);
			button.Location = location;
			this.Button30.Name = "Button30";
			System.Windows.Forms.Control button2 = this.Button30;
			size = new System.Drawing.Size(165, 28);
			button2.Size = size;
			this.Button30.TabIndex = 26;
			this.Button30.Text = "更改列标题文本内容";
			this.Button30.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button3 = this.Button16;
			location = new System.Drawing.Point(87, 57);
			button3.Location = location;
			this.Button16.Name = "Button16";
			System.Windows.Forms.Control button4 = this.Button16;
			size = new System.Drawing.Size(80, 30);
			button4.Size = size;
			this.Button16.TabIndex = 29;
			this.Button16.Text = "背景颜色";
			this.Button16.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button5 = this.Button17;
			location = new System.Drawing.Point(6, 57);
			button5.Location = location;
			this.Button17.Name = "Button17";
			System.Windows.Forms.Control button6 = this.Button17;
			size = new System.Drawing.Size(80, 30);
			button6.Size = size;
			this.Button17.TabIndex = 28;
			this.Button17.Text = "前景颜色";
			this.Button17.UseVisualStyleBackColor = true;
			this.headerfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.Control headerfont = this.headerfont;
			location = new System.Drawing.Point(3, 17);
			headerfont.Location = location;
			this.headerfont.Name = "headerfont";
			System.Windows.Forms.Control headerfont2 = this.headerfont;
			size = new System.Drawing.Size(107, 37);
			headerfont2.Size = size;
			this.headerfont.TabIndex = 25;
			this.headerfont.Text = "预览";
			this.headerfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Windows.Forms.Control button7 = this.Button11;
			location = new System.Drawing.Point(112, 20);
			button7.Location = location;
			this.Button11.Name = "Button11";
			System.Windows.Forms.Control button8 = this.Button11;
			size = new System.Drawing.Size(59, 30);
			button8.Size = size;
			this.Button11.TabIndex = 24;
			this.Button11.Text = "字体";
			this.Button11.UseVisualStyleBackColor = true;
			this.GroupBox9.Controls.Add(this.NumericUpDown1);
			this.GroupBox9.Controls.Add(this.GroupBox13);
			this.GroupBox9.Controls.Add(this.Button13);
			this.GroupBox9.Controls.Add(this.Button12);
			this.GroupBox9.Controls.Add(this.columnfont);
			this.GroupBox9.Controls.Add(this.Button9);
			this.GroupBox9.Controls.Add(this.ml);
			this.GroupBox9.Controls.Add(this.ldq);
			this.GroupBox9.Controls.Add(this.Label27);
			this.GroupBox9.Controls.Add(this.Label4);
			this.GroupBox9.Controls.Add(this.Label28);
			System.Windows.Forms.Control groupBox15 = this.GroupBox9;
			location = new System.Drawing.Point(167, 6);
			groupBox15.Location = location;
			this.GroupBox9.Name = "GroupBox9";
			System.Windows.Forms.Control groupBox16 = this.GroupBox9;
			size = new System.Drawing.Size(180, 211);
			groupBox16.Size = size;
			this.GroupBox9.TabIndex = 31;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "选中列的列详细设置";
			this.NumericUpDown1.DecimalPlaces = 2;
			System.Windows.Forms.Control numericUpDown = this.NumericUpDown1;
			location = new System.Drawing.Point(102, 98);
			numericUpDown.Location = location;
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			numericUpDown2.Maximum = num;
			this.NumericUpDown1.Name = "NumericUpDown1";
			System.Windows.Forms.Control numericUpDown3 = this.NumericUpDown1;
			size = new System.Drawing.Size(69, 21);
			numericUpDown3.Size = size;
			this.NumericUpDown1.TabIndex = 26;
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				2,
				0,
				0,
				0
			});
			numericUpDown4.Value = num;
			this.GroupBox13.Controls.Add(this.Button19);
			this.GroupBox13.Controls.Add(this.Button18);
			System.Windows.Forms.Control groupBox17 = this.GroupBox13;
			location = new System.Drawing.Point(4, 21);
			groupBox17.Location = location;
			this.GroupBox13.Name = "GroupBox13";
			System.Windows.Forms.Control groupBox18 = this.GroupBox13;
			size = new System.Drawing.Size(81, 73);
			groupBox18.Size = size;
			this.GroupBox13.TabIndex = 25;
			this.GroupBox13.TabStop = false;
			this.GroupBox13.Text = "列位置调整";
			System.Windows.Forms.Control button9 = this.Button19;
			location = new System.Drawing.Point(8, 45);
			button9.Location = location;
			this.Button19.Name = "Button19";
			System.Windows.Forms.Control button10 = this.Button19;
			size = new System.Drawing.Size(61, 25);
			button10.Size = size;
			this.Button19.TabIndex = 1;
			this.Button19.Text = "下移";
			this.Button19.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button11 = this.Button18;
			location = new System.Drawing.Point(8, 16);
			button11.Location = location;
			this.Button18.Name = "Button18";
			System.Windows.Forms.Control button12 = this.Button18;
			size = new System.Drawing.Size(61, 25);
			button12.Size = size;
			this.Button18.TabIndex = 0;
			this.Button18.Text = "上移";
			this.Button18.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button13 = this.Button13;
			location = new System.Drawing.Point(87, 166);
			button13.Location = location;
			this.Button13.Name = "Button13";
			System.Windows.Forms.Control button14 = this.Button13;
			size = new System.Drawing.Size(80, 30);
			button14.Size = size;
			this.Button13.TabIndex = 23;
			this.Button13.Text = "背景颜色";
			this.Button13.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button15 = this.Button12;
			location = new System.Drawing.Point(6, 166);
			button15.Location = location;
			this.Button12.Name = "Button12";
			System.Windows.Forms.Control button16 = this.Button12;
			size = new System.Drawing.Size(80, 30);
			button16.Size = size;
			this.Button12.TabIndex = 22;
			this.Button12.Text = "前景颜色";
			this.Button12.UseVisualStyleBackColor = true;
			this.columnfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.Control columnfont = this.columnfont;
			location = new System.Drawing.Point(6, 121);
			columnfont.Location = location;
			this.columnfont.Name = "columnfont";
			System.Windows.Forms.Control columnfont2 = this.columnfont;
			size = new System.Drawing.Size(104, 41);
			columnfont2.Size = size;
			this.columnfont.TabIndex = 21;
			this.columnfont.Text = "预览";
			this.columnfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Windows.Forms.Control button17 = this.Button9;
			location = new System.Drawing.Point(113, 125);
			button17.Location = location;
			this.Button9.Name = "Button9";
			System.Windows.Forms.Control button18 = this.Button9;
			size = new System.Drawing.Size(53, 30);
			button18.Size = size;
			this.Button9.TabIndex = 17;
			this.Button9.Text = "字体";
			this.Button9.UseVisualStyleBackColor = true;
			this.ml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ml.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.ml.FormattingEnabled = true;
			this.ml.Items.AddRange(new object[]
			{
				"允许",
				"不允许"
			});
			System.Windows.Forms.Control ml = this.ml;
			location = new System.Drawing.Point(87, 73);
			ml.Location = location;
			this.ml.Name = "ml";
			System.Windows.Forms.Control ml2 = this.ml;
			size = new System.Drawing.Size(87, 20);
			ml2.Size = size;
			this.ml.TabIndex = 12;
			this.ldq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ldq.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.ldq.FormattingEnabled = true;
			this.ldq.Items.AddRange(new object[]
			{
				"左对齐",
				"居中对齐",
				"右对齐"
			});
			System.Windows.Forms.Control ldq = this.ldq;
			location = new System.Drawing.Point(87, 33);
			ldq.Location = location;
			this.ldq.Name = "ldq";
			System.Windows.Forms.Control ldq2 = this.ldq;
			size = new System.Drawing.Size(87, 20);
			ldq2.Size = size;
			this.ldq.TabIndex = 11;
			this.Label27.AutoSize = true;
			System.Windows.Forms.Control label21 = this.Label27;
			location = new System.Drawing.Point(87, 57);
			label21.Location = location;
			this.Label27.Name = "Label27";
			System.Windows.Forms.Control label22 = this.Label27;
			size = new System.Drawing.Size(89, 12);
			label22.Size = size;
			this.Label27.TabIndex = 10;
			this.Label27.Text = "列允许多行打印";
			System.Windows.Forms.Control label23 = this.Label4;
			location = new System.Drawing.Point(8, 101);
			label23.Location = location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Control label24 = this.Label4;
			size = new System.Drawing.Size(93, 15);
			label24.Size = size;
			this.Label4.TabIndex = 9;
			this.Label4.Text = "列宽（毫米）：";
			this.Label28.AutoSize = true;
			System.Windows.Forms.Control label25 = this.Label28;
			location = new System.Drawing.Point(87, 19);
			label25.Location = location;
			this.Label28.Name = "Label28";
			System.Windows.Forms.Control label26 = this.Label28;
			size = new System.Drawing.Size(65, 12);
			label26.Size = size;
			this.Label28.TabIndex = 9;
			this.Label28.Text = "列对齐方式";
			this.Label8.AutoSize = true;
			System.Windows.Forms.Control label27 = this.Label8;
			location = new System.Drawing.Point(8, 6);
			label27.Location = location;
			this.Label8.Name = "Label8";
			System.Windows.Forms.Control label28 = this.Label8;
			size = new System.Drawing.Size(89, 12);
			label28.Size = size;
			this.Label8.TabIndex = 9;
			this.Label8.Text = "选择要打印的列";
			this.TabPage3.Controls.Add(this.Label9);
			this.TabPage3.Controls.Add(this.GroupBox14);
			this.TabPage3.Controls.Add(this.GroupBox8);
			this.TabPage3.Controls.Add(this.GroupBox11);
			this.TabPage3.Controls.Add(this.GroupBox7);
			this.TabPage3.Controls.Add(this.GroupBox6);
			System.Windows.Forms.TabPage tabPage7 = this.TabPage3;
			location = new System.Drawing.Point(4, 21);
			tabPage7.Location = location;
			this.TabPage3.Name = "TabPage3";
			System.Windows.Forms.Control tabPage8 = this.TabPage3;
			size = new System.Drawing.Size(351, 389);
			tabPage8.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "其他设置";
			this.TabPage3.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label29 = this.Label9;
			location = new System.Drawing.Point(8, 344);
			label29.Location = location;
			this.Label9.Name = "Label9";
			System.Windows.Forms.Control label30 = this.Label9;
			size = new System.Drawing.Size(330, 37);
			label30.Size = size;
			this.Label9.TabIndex = 1;
			this.Label9.Text = "更多详细设置（如页表头、页表尾等），请在接下来打开的报表设计器中设计。注意：如果某区域不需要打印或没有打印内容，您应当在报表设计器中将该区域的高度拖动调整到0。";
			this.GroupBox14.Controls.Add(this.t3);
			System.Windows.Forms.Control groupBox19 = this.GroupBox14;
			location = new System.Drawing.Point(5, 172);
			groupBox19.Location = location;
			this.GroupBox14.Name = "GroupBox14";
			System.Windows.Forms.Control groupBox20 = this.GroupBox14;
			size = new System.Drawing.Size(338, 47);
			groupBox20.Size = size;
			this.GroupBox14.TabIndex = 0;
			this.GroupBox14.TabStop = false;
			this.GroupBox14.Text = "页脚设置(可用[页码]表示当前页号，[总页数]表示总页数)";
			this.t3.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control t = this.t3;
			location = new System.Drawing.Point(5, 19);
			t.Location = location;
			this.t3.Name = "t3";
			System.Windows.Forms.Control t2 = this.t3;
			size = new System.Drawing.Size(323, 23);
			t2.Size = size;
			this.t3.TabIndex = 0;
			this.t3.Text = "共[总页数]页 第[页码]页";
			this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.GroupBox8.Controls.Add(this.jj);
			this.GroupBox8.Controls.Add(this.NumericUpDown2);
			this.GroupBox8.Controls.Add(this.zoomtopaper);
			this.GroupBox8.Controls.Add(this.emptyrow);
			this.GroupBox8.Controls.Add(this.Label15);
			this.GroupBox8.Controls.Add(this.Label10);
			this.GroupBox8.Controls.Add(this.RadioButton2);
			this.GroupBox8.Controls.Add(this.RadioButton1);
			System.Windows.Forms.Control groupBox21 = this.GroupBox8;
			location = new System.Drawing.Point(5, 226);
			groupBox21.Location = location;
			this.GroupBox8.Name = "GroupBox8";
			System.Windows.Forms.Control groupBox22 = this.GroupBox8;
			size = new System.Drawing.Size(338, 114);
			groupBox22.Size = size;
			this.GroupBox8.TabIndex = 0;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "表格打印方式";
			System.Windows.Forms.Control jj = this.jj;
			location = new System.Drawing.Point(262, 46);
			jj.Location = location;
			System.Windows.Forms.NumericUpDown jj2 = this.jj;
			num = new decimal(new int[]
			{
				80,
				0,
				0,
				0
			});
			jj2.Maximum = num;
			this.jj.Name = "jj";
			System.Windows.Forms.Control jj3 = this.jj;
			size = new System.Drawing.Size(67, 21);
			jj3.Size = size;
			this.jj.TabIndex = 3;
			this.jj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown jj4 = this.jj;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			jj4.Value = num;
			System.Windows.Forms.Control numericUpDown5 = this.NumericUpDown2;
			location = new System.Drawing.Point(262, 17);
			numericUpDown5.Location = location;
			System.Windows.Forms.NumericUpDown numericUpDown6 = this.NumericUpDown2;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			numericUpDown6.Maximum = num;
			this.NumericUpDown2.Name = "NumericUpDown2";
			System.Windows.Forms.Control numericUpDown7 = this.NumericUpDown2;
			size = new System.Drawing.Size(67, 21);
			numericUpDown7.Size = size;
			this.NumericUpDown2.TabIndex = 3;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.zoomtopaper.AutoSize = true;
			this.zoomtopaper.Checked = true;
			this.zoomtopaper.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control zoomtopaper = this.zoomtopaper;
			location = new System.Drawing.Point(6, 93);
			zoomtopaper.Location = location;
			this.zoomtopaper.Name = "zoomtopaper";
			System.Windows.Forms.Control zoomtopaper2 = this.zoomtopaper;
			size = new System.Drawing.Size(312, 16);
			zoomtopaper2.Size = size;
			this.zoomtopaper.TabIndex = 2;
			this.zoomtopaper.Text = "按比例缩放表格各列的宽度使表格总宽度等于纸张宽度";
			this.zoomtopaper.UseVisualStyleBackColor = true;
			this.emptyrow.AutoSize = true;
			System.Windows.Forms.Control emptyrow = this.emptyrow;
			location = new System.Drawing.Point(6, 73);
			emptyrow.Location = location;
			this.emptyrow.Name = "emptyrow";
			System.Windows.Forms.Control emptyrow2 = this.emptyrow;
			size = new System.Drawing.Size(330, 16);
			emptyrow2.Size = size;
			this.emptyrow.TabIndex = 2;
			this.emptyrow.Text = "行数不足自动添加空行补足（仅当固定行数不为0时有效）";
			this.emptyrow.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label31 = this.Label15;
			location = new System.Drawing.Point(85, 46);
			label31.Location = location;
			this.Label15.Name = "Label15";
			System.Windows.Forms.Control label32 = this.Label15;
			size = new System.Drawing.Size(173, 24);
			label32.Size = size;
			this.Label15.TabIndex = 1;
			this.Label15.Text = "工资条间距（仅对工资条打印有效，单位毫米）";
			System.Windows.Forms.Control label33 = this.Label10;
			location = new System.Drawing.Point(85, 16);
			label33.Location = location;
			this.Label10.Name = "Label10";
			System.Windows.Forms.Control label34 = this.Label10;
			size = new System.Drawing.Size(173, 24);
			label34.Size = size;
			this.Label10.TabIndex = 1;
			this.Label10.Text = "详细数据每页打印固定行数（为0表示根据纸张高度自动确定）";
			this.RadioButton2.AutoSize = true;
			System.Windows.Forms.Control radioButton = this.RadioButton2;
			location = new System.Drawing.Point(6, 47);
			radioButton.Location = location;
			this.RadioButton2.Name = "RadioButton2";
			System.Windows.Forms.Control radioButton2 = this.RadioButton2;
			size = new System.Drawing.Size(59, 16);
			radioButton2.Size = size;
			this.RadioButton2.TabIndex = 0;
			this.RadioButton2.Text = "工资条";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			System.Windows.Forms.Control radioButton3 = this.RadioButton1;
			location = new System.Drawing.Point(6, 20);
			radioButton3.Location = location;
			this.RadioButton1.Name = "RadioButton1";
			System.Windows.Forms.Control radioButton4 = this.RadioButton1;
			size = new System.Drawing.Size(71, 16);
			radioButton4.Size = size;
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "普通报表";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.GroupBox11.Controls.Add(this.pagetitle);
			System.Windows.Forms.Control groupBox23 = this.GroupBox11;
			location = new System.Drawing.Point(5, 117);
			groupBox23.Location = location;
			this.GroupBox11.Name = "GroupBox11";
			System.Windows.Forms.Control groupBox24 = this.GroupBox11;
			size = new System.Drawing.Size(338, 49);
			groupBox24.Size = size;
			this.GroupBox11.TabIndex = 0;
			this.GroupBox11.TabStop = false;
			this.GroupBox11.Text = "页标题（该标题行每页都会打印）";
			this.pagetitle.Font = new System.Drawing.Font("黑体", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control pagetitle = this.pagetitle;
			location = new System.Drawing.Point(5, 16);
			pagetitle.Location = location;
			this.pagetitle.Name = "pagetitle";
			System.Windows.Forms.Control pagetitle2 = this.pagetitle;
			size = new System.Drawing.Size(323, 30);
			pagetitle2.Size = size;
			this.pagetitle.TabIndex = 0;
			this.pagetitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.GroupBox7.Controls.Add(this.t2);
			System.Windows.Forms.Control groupBox25 = this.GroupBox7;
			location = new System.Drawing.Point(5, 53);
			groupBox25.Location = location;
			this.GroupBox7.Name = "GroupBox7";
			System.Windows.Forms.Control groupBox26 = this.GroupBox7;
			size = new System.Drawing.Size(338, 56);
			groupBox26.Size = size;
			this.GroupBox7.TabIndex = 0;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "报表标题（该标题仅第一页打印）";
			this.t2.Font = new System.Drawing.Font("黑体", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control t3 = this.t2;
			location = new System.Drawing.Point(5, 16);
			t3.Location = location;
			this.t2.Name = "t2";
			System.Windows.Forms.Control t4 = this.t2;
			size = new System.Drawing.Size(323, 35);
			t4.Size = size;
			this.t2.TabIndex = 0;
			this.t2.Text = "报表标题";
			this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.GroupBox6.Controls.Add(this.t1);
			System.Windows.Forms.Control groupBox27 = this.GroupBox6;
			location = new System.Drawing.Point(5, 4);
			groupBox27.Location = location;
			this.GroupBox6.Name = "GroupBox6";
			System.Windows.Forms.Control groupBox28 = this.GroupBox6;
			size = new System.Drawing.Size(338, 44);
			groupBox28.Size = size;
			this.GroupBox6.TabIndex = 0;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "页眉设置(可用[页码]表示当前页号，[总页数]表示总页数)";
			this.t1.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control t5 = this.t1;
			location = new System.Drawing.Point(5, 17);
			t5.Location = location;
			this.t1.Name = "t1";
			System.Windows.Forms.Control t6 = this.t1;
			size = new System.Drawing.Size(323, 23);
			t6.Size = size;
			this.t1.TabIndex = 0;
			this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			System.Windows.Forms.Control button19 = this.Button1;
			location = new System.Drawing.Point(190, 421);
			button19.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button20 = this.Button1;
			size = new System.Drawing.Size(75, 28);
			button20.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button21 = this.Button2;
			location = new System.Drawing.Point(277, 421);
			button21.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button22 = this.Button2;
			size = new System.Drawing.Size(75, 28);
			button22.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "取消";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label7.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			this.Label7.ForeColor = System.Drawing.Color.Red;
			System.Windows.Forms.Control label35 = this.Label7;
			location = new System.Drawing.Point(7, 417);
			label35.Location = location;
			this.Label7.Name = "Label7";
			System.Windows.Forms.Control label36 = this.Label7;
			size = new System.Drawing.Size(161, 29);
			label36.Size = size;
			this.Label7.TabIndex = 2;
			this.Label7.Text = "Label7";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AcceptButton = this.Button1;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Button2;
			size = new System.Drawing.Size(359, 450);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TabControl1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReportWizard";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "EasyReport报表模板设计向导";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.rowheight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.colheaderheight).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.printb).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printr).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.printl).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myw).EndInit();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.GroupBox12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.rowid).EndInit();
			this.GroupBox10.ResumeLayout(false);
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.GroupBox13.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.GroupBox14.ResumeLayout(false);
			this.GroupBox14.PerformLayout();
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.jj).EndInit();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown2).EndInit();
			this.GroupBox11.ResumeLayout(false);
			this.GroupBox11.PerformLayout();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040004C8 RID: 1224
		private System.ComponentModel.IContainer components;

		// Token: 0x0400051F RID: 1311
		private CommomPaperSize mypp;
	}
}
