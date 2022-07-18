namespace LuoEasyPrint
{
	public partial class SimpleReportSet : Form
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x00078A8C File Offset: 0x00076C8C
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				this.CurCol = null;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00078AD0 File Offset: 0x00076CD0
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(SimpleReportSet));
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.GroupBoxpaper = new System.Windows.Forms.GroupBox();
			this.GroupBox24 = new System.Windows.Forms.GroupBox();
			this.myh = new System.Windows.Forms.NumericUpDown();
			this.Label81 = new System.Windows.Forms.Label();
			this.fx = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.myw = new System.Windows.Forms.NumericUpDown();
			this.Label82 = new System.Windows.Forms.Label();
			this.papertype = new System.Windows.Forms.ComboBox();
			this.Label46 = new System.Windows.Forms.Label();
			this.GroupBox14 = new System.Windows.Forms.GroupBox();
			this.Label50 = new System.Windows.Forms.Label();
			this.Label49 = new System.Windows.Forms.Label();
			this.pagemarginr = new System.Windows.Forms.NumericUpDown();
			this.pagemarginl = new System.Windows.Forms.NumericUpDown();
			this.pagemarginb = new System.Windows.Forms.NumericUpDown();
			this.pagemargint = new System.Windows.Forms.NumericUpDown();
			this.Label48 = new System.Windows.Forms.Label();
			this.Label47 = new System.Windows.Forms.Label();
			this.GroupBoxwater = new System.Windows.Forms.GroupBox();
			this.sytm = new System.Windows.Forms.NumericUpDown();
			this.Button27 = new System.Windows.Forms.Button();
			this.syfx = new System.Windows.Forms.ComboBox();
			this.sytext = new System.Windows.Forms.TextBox();
			this.Label52 = new System.Windows.Forms.Label();
			this.Label53 = new System.Windows.Forms.Label();
			this.TabPage8 = new System.Windows.Forms.TabPage();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.reportheaderspace = new System.Windows.Forms.NumericUpDown();
			this.Label34 = new System.Windows.Forms.Label();
			this.reportheaderfont = new System.Windows.Forms.Button();
			this.reportheadertext = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.Label31 = new System.Windows.Forms.Label();
			this.reportheaderalignment = new System.Windows.Forms.ComboBox();
			this.GroupBoxtitle1 = new System.Windows.Forms.GroupBox();
			this.maintitleheight = new System.Windows.Forms.NumericUpDown();
			this.Label40 = new System.Windows.Forms.Label();
			this.maintitle = new System.Windows.Forms.TextBox();
			this.Label54 = new System.Windows.Forms.Label();
			this.maintitleprinteverpage = new System.Windows.Forms.CheckBox();
			this.maintitlealign = new System.Windows.Forms.ComboBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBoxtitle2 = new System.Windows.Forms.GroupBox();
			this.subtitleheight = new System.Windows.Forms.NumericUpDown();
			this.Label41 = new System.Windows.Forms.Label();
			this.d1 = new System.Windows.Forms.DataGridView();
			this.DataGridViewTextBoxColumn_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subtitlepritneverypage = new System.Windows.Forms.CheckBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox31 = new System.Windows.Forms.GroupBox();
			this.bordertype = new System.Windows.Forms.ComboBox();
			this.fieldheight = new System.Windows.Forms.NumericUpDown();
			this.Label3 = new System.Windows.Forms.Label();
			this.rowheight = new System.Windows.Forms.NumericUpDown();
			this.Label24 = new System.Windows.Forms.Label();
			this.linewidth = new System.Windows.Forms.NumericUpDown();
			this.linecolor = new System.Windows.Forms.Button();
			this.Label27 = new System.Windows.Forms.Label();
			this.Label89 = new System.Windows.Forms.Label();
			this.zoomtopaperwidth = new System.Windows.Forms.CheckBox();
			this.gwxouterborder = new System.Windows.Forms.CheckBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cbottom = new System.Windows.Forms.NumericUpDown();
			this.ctop = new System.Windows.Forms.NumericUpDown();
			this.cright = new System.Windows.Forms.NumericUpDown();
			this.cleft = new System.Windows.Forms.NumericUpDown();
			this.Label30 = new System.Windows.Forms.Label();
			this.Label29 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.GroupBox17 = new System.Windows.Forms.GroupBox();
			this.Cbackcolor = new System.Windows.Forms.CheckBox();
			this.Cforecolor = new System.Windows.Forms.CheckBox();
			this.bbackcolor = new System.Windows.Forms.Button();
			this.jsh = new System.Windows.Forms.Label();
			this.bforecolor = new System.Windows.Forms.Button();
			this.minsize = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBoxtablestyle = new System.Windows.Forms.GroupBox();
			this.fl = new System.Windows.Forms.GroupBox();
			this.ljj = new System.Windows.Forms.NumericUpDown();
			this.ls = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.R4 = new System.Windows.Forms.RadioButton();
			this.R3 = new System.Windows.Forms.RadioButton();
			this.R2 = new System.Windows.Forms.RadioButton();
			this.R1 = new System.Windows.Forms.RadioButton();
			this.pt = new System.Windows.Forms.GroupBox();
			this.fixedrows = new System.Windows.Forms.NumericUpDown();
			this.addemptyrow = new System.Windows.Forms.CheckBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.fy = new System.Windows.Forms.GroupBox();
			this.columns = new System.Windows.Forms.ComboBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.gz = new System.Windows.Forms.GroupBox();
			this.gzjj = new System.Windows.Forms.NumericUpDown();
			this.gzwrap = new System.Windows.Forms.CheckBox();
			this.lz = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.fieldtitle = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.fieldname = new System.Windows.Forms.ComboBox();
			this.colwidth = new System.Windows.Forms.NumericUpDown();
			this.Label78 = new System.Windows.Forms.Label();
			this.iscomp = new System.Windows.Forms.CheckBox();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.Button31 = new System.Windows.Forms.Button();
			this.Button32 = new System.Windows.Forms.Button();
			this.Button33 = new System.Windows.Forms.Button();
			this.t1 = new System.Windows.Forms.TreeView();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.GroupBox10 = new System.Windows.Forms.GroupBox();
			this.Button9 = new System.Windows.Forms.Button();
			this.Button12 = new System.Windows.Forms.Button();
			this.GroupBox13 = new System.Windows.Forms.GroupBox();
			this.Button19 = new System.Windows.Forms.Button();
			this.Button18 = new System.Windows.Forms.Button();
			this.GroupBoxformat = new System.Windows.Forms.GroupBox();
			this.GroupBox11 = new System.Windows.Forms.GroupBox();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.formatbotton = new System.Windows.Forms.Button();
			this.Label26 = new System.Windows.Forms.Label();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.xg = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.comptxt = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.coltype = new System.Windows.Forms.ListBox();
			this.ml = new System.Windows.Forms.CheckBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.colformat = new System.Windows.Forms.TextBox();
			this.printzero = new System.Windows.Forms.CheckBox();
			this.GroupBoxxx2 = new System.Windows.Forms.GroupBox();
			this.Button16 = new System.Windows.Forms.Button();
			this.headerfont = new System.Windows.Forms.Label();
			this.Button11 = new System.Windows.Forms.Button();
			this.GroupBoxxx3 = new System.Windows.Forms.GroupBox();
			this.Button15 = new System.Windows.Forms.Button();
			this.cellfont = new System.Windows.Forms.Label();
			this.Button10 = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.valg = new System.Windows.Forms.ComboBox();
			this.halg = new System.Windows.Forms.ComboBox();
			this.isprint = new System.Windows.Forms.CheckBox();
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.reportfooterspace = new System.Windows.Forms.NumericUpDown();
			this.Label35 = new System.Windows.Forms.Label();
			this.reportfooterfont = new System.Windows.Forms.Button();
			this.reportfootertext = new System.Windows.Forms.TextBox();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label37 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.reportfooteralignment = new System.Windows.Forms.ComboBox();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.tablefooterheight = new System.Windows.Forms.NumericUpDown();
			this.Label11 = new System.Windows.Forms.Label();
			this.d2 = new System.Windows.Forms.DataGridView();
			this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tablefooterprinteverypage = new System.Windows.Forms.CheckBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button24 = new System.Windows.Forms.Button();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Label90 = new System.Windows.Forms.Label();
			this.Label88 = new System.Windows.Forms.Label();
			this.GroupBoxheader3 = new System.Windows.Forms.GroupBox();
			this.Button29 = new System.Windows.Forms.Button();
			this.rightb = new System.Windows.Forms.TextBox();
			this.rightm = new System.Windows.Forms.TextBox();
			this.rightt = new System.Windows.Forms.TextBox();
			this.Label56 = new System.Windows.Forms.Label();
			this.Label57 = new System.Windows.Forms.Label();
			this.Label58 = new System.Windows.Forms.Label();
			this.GroupBoxheader2 = new System.Windows.Forms.GroupBox();
			this.drawfooter = new System.Windows.Forms.CheckBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.pageright = new System.Windows.Forms.TextBox();
			this.pagemiddle = new System.Windows.Forms.TextBox();
			this.pageleft = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.GroupBoxheader1 = new System.Windows.Forms.GroupBox();
			this.drawheader = new System.Windows.Forms.CheckBox();
			this.Button8 = new System.Windows.Forms.Button();
			this.pager = new System.Windows.Forms.TextBox();
			this.pagem = new System.Windows.Forms.TextBox();
			this.pagel = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.TabPage7 = new System.Windows.Forms.TabPage();
			this.Label14 = new System.Windows.Forms.Label();
			this.GroupBoxZDX = new System.Windows.Forms.GroupBox();
			this.GroupBoxzdx3 = new System.Windows.Forms.GroupBox();
			this.zdxlinecolor = new System.Windows.Forms.Button();
			this.zdx_dashdotdot = new System.Windows.Forms.RadioButton();
			this.zdx_dashdot = new System.Windows.Forms.RadioButton();
			this.zdx_dot = new System.Windows.Forms.RadioButton();
			this.zdx_dash = new System.Windows.Forms.RadioButton();
			this.zdx_solid = new System.Windows.Forms.RadioButton();
			this.GroupBoxzdx2 = new System.Windows.Forms.GroupBox();
			this.zdxtext = new System.Windows.Forms.TextBox();
			this.Button37 = new System.Windows.Forms.Button();
			this.GroupBoxzdx1 = new System.Windows.Forms.GroupBox();
			this.zdxposition = new System.Windows.Forms.NumericUpDown();
			this.zdxtype_bottom = new System.Windows.Forms.RadioButton();
			this.zdxtype_right = new System.Windows.Forms.RadioButton();
			this.zdxtype_top = new System.Windows.Forms.RadioButton();
			this.zdxtype_left = new System.Windows.Forms.RadioButton();
			this.Label83 = new System.Windows.Forms.Label();
			this.isdrawzdx = new System.Windows.Forms.CheckBox();
			this.Button20 = new System.Windows.Forms.Button();
			this.Button17 = new System.Windows.Forms.Button();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
			this.FontDialog1 = new System.Windows.Forms.FontDialog();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.GroupBoxpaper.SuspendLayout();
			this.GroupBox24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myw).BeginInit();
			this.GroupBox14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pagemarginr).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pagemarginl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pagemarginb).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pagemargint).BeginInit();
			this.GroupBoxwater.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.sytm).BeginInit();
			this.TabPage8.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.reportheaderspace).BeginInit();
			this.GroupBoxtitle1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.maintitleheight).BeginInit();
			this.GroupBoxtitle2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.subtitleheight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.d1).BeginInit();
			this.TabPage1.SuspendLayout();
			this.GroupBox31.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.fieldheight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.rowheight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.linewidth).BeginInit();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.cbottom).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ctop).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cright).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cleft).BeginInit();
			this.GroupBox17.SuspendLayout();
			this.GroupBoxtablestyle.SuspendLayout();
			this.fl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.ljj).BeginInit();
			this.pt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.fixedrows).BeginInit();
			this.fy.SuspendLayout();
			this.gz.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.gzjj).BeginInit();
			this.TabPage3.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.colwidth).BeginInit();
			this.GroupBox6.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			this.GroupBox10.SuspendLayout();
			this.GroupBox13.SuspendLayout();
			this.GroupBoxformat.SuspendLayout();
			this.GroupBox11.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.GroupBoxxx2.SuspendLayout();
			this.GroupBoxxx3.SuspendLayout();
			this.TabPage5.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.reportfooterspace).BeginInit();
			this.GroupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.tablefooterheight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.d2).BeginInit();
			this.TabPage2.SuspendLayout();
			this.GroupBoxheader3.SuspendLayout();
			this.GroupBoxheader2.SuspendLayout();
			this.GroupBoxheader1.SuspendLayout();
			this.TabPage7.SuspendLayout();
			this.GroupBoxZDX.SuspendLayout();
			this.GroupBoxzdx3.SuspendLayout();
			this.GroupBoxzdx2.SuspendLayout();
			this.GroupBoxzdx1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.zdxposition).BeginInit();
			this.SuspendLayout();
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			System.Windows.Forms.Control splitContainer = this.SplitContainer1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			splitContainer.Location = location;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);
			this.SplitContainer1.Panel2.Controls.Add(this.Button20);
			this.SplitContainer1.Panel2.Controls.Add(this.Button17);
			System.Windows.Forms.Control splitContainer2 = this.SplitContainer1;
			System.Drawing.Size size = new System.Drawing.Size(544, 522);
			splitContainer2.Size = size;
			this.SplitContainer1.SplitterDistance = 491;
			this.SplitContainer1.TabIndex = 0;
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.TabPage8);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage5);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage7);
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			System.Windows.Forms.Control tabControl = this.TabControl1;
			location = new System.Drawing.Point(0, 0);
			tabControl.Location = location;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			System.Windows.Forms.Control tabControl2 = this.TabControl1;
			size = new System.Drawing.Size(544, 491);
			tabControl2.Size = size;
			this.TabControl1.TabIndex = 11;
			this.TabPage4.Controls.Add(this.GroupBoxpaper);
			this.TabPage4.Controls.Add(this.GroupBoxwater);
			System.Windows.Forms.TabPage tabPage = this.TabPage4;
			location = new System.Drawing.Point(4, 22);
			tabPage.Location = location;
			this.TabPage4.Name = "TabPage4";
			System.Windows.Forms.Control tabPage2 = this.TabPage4;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
			tabPage2.Padding = padding;
			System.Windows.Forms.Control tabPage3 = this.TabPage4;
			size = new System.Drawing.Size(536, 465);
			tabPage3.Size = size;
			this.TabPage4.TabIndex = 7;
			this.TabPage4.Text = "页  面";
			this.TabPage4.UseVisualStyleBackColor = true;
			this.GroupBoxpaper.Controls.Add(this.GroupBox24);
			this.GroupBoxpaper.Controls.Add(this.GroupBox14);
			System.Windows.Forms.Control groupBoxpaper = this.GroupBoxpaper;
			location = new System.Drawing.Point(11, 4);
			groupBoxpaper.Location = location;
			this.GroupBoxpaper.Name = "GroupBoxpaper";
			System.Windows.Forms.Control groupBoxpaper2 = this.GroupBoxpaper;
			size = new System.Drawing.Size(522, 212);
			groupBoxpaper2.Size = size;
			this.GroupBoxpaper.TabIndex = 106;
			this.GroupBoxpaper.TabStop = false;
			this.GroupBoxpaper.Text = "页面";
			this.GroupBox24.Controls.Add(this.myh);
			this.GroupBox24.Controls.Add(this.Label81);
			this.GroupBox24.Controls.Add(this.fx);
			this.GroupBox24.Controls.Add(this.Label4);
			this.GroupBox24.Controls.Add(this.myw);
			this.GroupBox24.Controls.Add(this.Label82);
			this.GroupBox24.Controls.Add(this.papertype);
			this.GroupBox24.Controls.Add(this.Label46);
			System.Windows.Forms.Control groupBox = this.GroupBox24;
			location = new System.Drawing.Point(6, 29);
			groupBox.Location = location;
			this.GroupBox24.Name = "GroupBox24";
			System.Windows.Forms.Control groupBox2 = this.GroupBox24;
			size = new System.Drawing.Size(510, 96);
			groupBox2.Size = size;
			this.GroupBox24.TabIndex = 12;
			this.GroupBox24.TabStop = false;
			this.GroupBox24.Text = "纸张";
			this.myh.DecimalPlaces = 2;
			System.Windows.Forms.Control myh = this.myh;
			location = new System.Drawing.Point(269, 55);
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
			size = new System.Drawing.Size(98, 21);
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
			System.Windows.Forms.Control label = this.Label81;
			location = new System.Drawing.Point(192, 59);
			label.Location = location;
			this.Label81.Name = "Label81";
			System.Windows.Forms.Control label2 = this.Label81;
			size = new System.Drawing.Size(77, 12);
			label2.Size = size;
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
			location = new System.Drawing.Point(443, 55);
			fx.Location = location;
			this.fx.Name = "fx";
			System.Windows.Forms.Control fx2 = this.fx;
			size = new System.Drawing.Size(61, 20);
			fx2.Size = size;
			this.fx.TabIndex = 4;
			this.Label4.AutoSize = true;
			System.Windows.Forms.Control label3 = this.Label4;
			location = new System.Drawing.Point(378, 59);
			label3.Location = location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Control label4 = this.Label4;
			size = new System.Drawing.Size(65, 12);
			label4.Size = size;
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
			size = new System.Drawing.Size(98, 21);
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
			System.Windows.Forms.Control label5 = this.Label82;
			location = new System.Drawing.Point(5, 59);
			label5.Location = location;
			this.Label82.Name = "Label82";
			System.Windows.Forms.Control label6 = this.Label82;
			size = new System.Drawing.Size(77, 12);
			label6.Size = size;
			this.Label82.TabIndex = 27;
			this.Label82.Text = "宽度(毫米)：";
			this.papertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.papertype.FormattingEnabled = true;
			System.Windows.Forms.Control papertype = this.papertype;
			location = new System.Drawing.Point(70, 22);
			papertype.Location = location;
			this.papertype.Name = "papertype";
			System.Windows.Forms.Control papertype2 = this.papertype;
			size = new System.Drawing.Size(434, 20);
			papertype2.Size = size;
			this.papertype.TabIndex = 1;
			this.Label46.AutoSize = true;
			System.Windows.Forms.Control label7 = this.Label46;
			location = new System.Drawing.Point(5, 26);
			label7.Location = location;
			this.Label46.Name = "Label46";
			System.Windows.Forms.Control label8 = this.Label46;
			size = new System.Drawing.Size(65, 12);
			label8.Size = size;
			this.Label46.TabIndex = 3;
			this.Label46.Text = "打印纸张：";
			this.GroupBox14.Controls.Add(this.Label50);
			this.GroupBox14.Controls.Add(this.Label49);
			this.GroupBox14.Controls.Add(this.pagemarginr);
			this.GroupBox14.Controls.Add(this.pagemarginl);
			this.GroupBox14.Controls.Add(this.pagemarginb);
			this.GroupBox14.Controls.Add(this.pagemargint);
			this.GroupBox14.Controls.Add(this.Label48);
			this.GroupBox14.Controls.Add(this.Label47);
			System.Windows.Forms.Control groupBox3 = this.GroupBox14;
			location = new System.Drawing.Point(6, 138);
			groupBox3.Location = location;
			this.GroupBox14.Name = "GroupBox14";
			System.Windows.Forms.Control groupBox4 = this.GroupBox14;
			size = new System.Drawing.Size(510, 57);
			groupBox4.Size = size;
			this.GroupBox14.TabIndex = 10;
			this.GroupBox14.TabStop = false;
			this.GroupBox14.Text = "页边距(单位：毫米）";
			this.Label50.AutoSize = true;
			System.Windows.Forms.Control label9 = this.Label50;
			location = new System.Drawing.Point(131, 26);
			label9.Location = location;
			this.Label50.Name = "Label50";
			System.Windows.Forms.Control label10 = this.Label50;
			size = new System.Drawing.Size(53, 12);
			label10.Size = size;
			this.Label50.TabIndex = 3;
			this.Label50.Text = "下边距：";
			this.Label49.AutoSize = true;
			System.Windows.Forms.Control label11 = this.Label49;
			location = new System.Drawing.Point(4, 26);
			label11.Location = location;
			this.Label49.Name = "Label49";
			System.Windows.Forms.Control label12 = this.Label49;
			size = new System.Drawing.Size(53, 12);
			label12.Size = size;
			this.Label49.TabIndex = 3;
			this.Label49.Text = "上边距：";
			this.pagemarginr.DecimalPlaces = 2;
			System.Windows.Forms.Control pagemarginr = this.pagemarginr;
			location = new System.Drawing.Point(435, 24);
			pagemarginr.Location = location;
			System.Windows.Forms.NumericUpDown pagemarginr2 = this.pagemarginr;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			pagemarginr2.Maximum = num;
			this.pagemarginr.Name = "pagemarginr";
			System.Windows.Forms.Control pagemarginr3 = this.pagemarginr;
			size = new System.Drawing.Size(59, 21);
			pagemarginr3.Size = size;
			this.pagemarginr.TabIndex = 2;
			this.pagemarginr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown pagemarginr4 = this.pagemarginr;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			pagemarginr4.Value = num;
			this.pagemarginl.DecimalPlaces = 2;
			System.Windows.Forms.Control pagemarginl = this.pagemarginl;
			location = new System.Drawing.Point(308, 24);
			pagemarginl.Location = location;
			System.Windows.Forms.NumericUpDown pagemarginl2 = this.pagemarginl;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			pagemarginl2.Maximum = num;
			this.pagemarginl.Name = "pagemarginl";
			System.Windows.Forms.Control pagemarginl3 = this.pagemarginl;
			size = new System.Drawing.Size(59, 21);
			pagemarginl3.Size = size;
			this.pagemarginl.TabIndex = 2;
			this.pagemarginl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown pagemarginl4 = this.pagemarginl;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			pagemarginl4.Value = num;
			this.pagemarginb.DecimalPlaces = 2;
			System.Windows.Forms.Control pagemarginb = this.pagemarginb;
			location = new System.Drawing.Point(187, 22);
			pagemarginb.Location = location;
			System.Windows.Forms.NumericUpDown pagemarginb2 = this.pagemarginb;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			pagemarginb2.Maximum = num;
			this.pagemarginb.Name = "pagemarginb";
			System.Windows.Forms.Control pagemarginb3 = this.pagemarginb;
			size = new System.Drawing.Size(59, 21);
			pagemarginb3.Size = size;
			this.pagemarginb.TabIndex = 2;
			this.pagemarginb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown pagemarginb4 = this.pagemarginb;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			pagemarginb4.Value = num;
			this.pagemargint.DecimalPlaces = 2;
			System.Windows.Forms.Control pagemargint = this.pagemargint;
			location = new System.Drawing.Point(59, 22);
			pagemargint.Location = location;
			System.Windows.Forms.NumericUpDown pagemargint2 = this.pagemargint;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			pagemargint2.Maximum = num;
			this.pagemargint.Name = "pagemargint";
			System.Windows.Forms.Control pagemargint3 = this.pagemargint;
			size = new System.Drawing.Size(59, 21);
			pagemargint3.Size = size;
			this.pagemargint.TabIndex = 2;
			this.pagemargint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown pagemargint4 = this.pagemargint;
			num = new decimal(new int[]
			{
				105,
				0,
				0,
				65536
			});
			pagemargint4.Value = num;
			this.Label48.AutoSize = true;
			System.Windows.Forms.Control label13 = this.Label48;
			location = new System.Drawing.Point(385, 26);
			label13.Location = location;
			this.Label48.Name = "Label48";
			System.Windows.Forms.Control label14 = this.Label48;
			size = new System.Drawing.Size(53, 12);
			label14.Size = size;
			this.Label48.TabIndex = 3;
			this.Label48.Text = "右边距：";
			this.Label47.AutoSize = true;
			System.Windows.Forms.Control label15 = this.Label47;
			location = new System.Drawing.Point(258, 26);
			label15.Location = location;
			this.Label47.Name = "Label47";
			System.Windows.Forms.Control label16 = this.Label47;
			size = new System.Drawing.Size(53, 12);
			label16.Size = size;
			this.Label47.TabIndex = 3;
			this.Label47.Text = "左边距：";
			this.GroupBoxwater.Controls.Add(this.sytm);
			this.GroupBoxwater.Controls.Add(this.Button27);
			this.GroupBoxwater.Controls.Add(this.syfx);
			this.GroupBoxwater.Controls.Add(this.sytext);
			this.GroupBoxwater.Controls.Add(this.Label52);
			this.GroupBoxwater.Controls.Add(this.Label53);
			System.Windows.Forms.Control groupBoxwater = this.GroupBoxwater;
			location = new System.Drawing.Point(11, 222);
			groupBoxwater.Location = location;
			this.GroupBoxwater.Name = "GroupBoxwater";
			System.Windows.Forms.Control groupBoxwater2 = this.GroupBoxwater;
			size = new System.Drawing.Size(516, 218);
			groupBoxwater2.Size = size;
			this.GroupBoxwater.TabIndex = 19;
			this.GroupBoxwater.TabStop = false;
			this.GroupBoxwater.Text = "水印设置(为空不打印水印)";
			System.Windows.Forms.Control sytm = this.sytm;
			location = new System.Drawing.Point(316, 186);
			sytm.Location = location;
			System.Windows.Forms.NumericUpDown sytm2 = this.sytm;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			sytm2.Maximum = num;
			this.sytm.Name = "sytm";
			System.Windows.Forms.Control sytm3 = this.sytm;
			size = new System.Drawing.Size(57, 21);
			sytm3.Size = size;
			this.sytm.TabIndex = 9;
			System.Windows.Forms.NumericUpDown sytm4 = this.sytm;
			num = new decimal(new int[]
			{
				128,
				0,
				0,
				0
			});
			sytm4.Value = num;
			this.Button27.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button = this.Button27;
			location = new System.Drawing.Point(407, 184);
			button.Location = location;
			this.Button27.Name = "Button27";
			System.Windows.Forms.Control button2 = this.Button27;
			size = new System.Drawing.Size(102, 25);
			button2.Size = size;
			this.Button27.TabIndex = 9;
			this.Button27.Text = "字体及颜色";
			this.Button27.UseVisualStyleBackColor = true;
			this.syfx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.syfx.FormattingEnabled = true;
			this.syfx.Items.AddRange(new object[]
			{
				"水平",
				"垂直"
			});
			System.Windows.Forms.Control syfx = this.syfx;
			location = new System.Drawing.Point(79, 186);
			syfx.Location = location;
			this.syfx.Name = "syfx";
			System.Windows.Forms.Control syfx2 = this.syfx;
			size = new System.Drawing.Size(65, 20);
			syfx2.Size = size;
			this.syfx.TabIndex = 8;
			this.sytext.Font = new System.Drawing.Font("宋体", 72f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control sytext = this.sytext;
			location = new System.Drawing.Point(6, 20);
			sytext.Location = location;
			this.sytext.Multiline = true;
			this.sytext.Name = "sytext";
			this.sytext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control sytext2 = this.sytext;
			size = new System.Drawing.Size(503, 155);
			sytext2.Size = size;
			this.sytext.TabIndex = 7;
			this.Label52.AutoSize = true;
			System.Windows.Forms.Control label17 = this.Label52;
			location = new System.Drawing.Point(8, 190);
			label17.Location = location;
			this.Label52.Name = "Label52";
			System.Windows.Forms.Control label18 = this.Label52;
			size = new System.Drawing.Size(65, 12);
			label18.Size = size;
			this.Label52.TabIndex = 4;
			this.Label52.Text = "打印方向：";
			System.Windows.Forms.Control label19 = this.Label53;
			location = new System.Drawing.Point(150, 188);
			label19.Location = location;
			this.Label53.Name = "Label53";
			System.Windows.Forms.Control label20 = this.Label53;
			size = new System.Drawing.Size(160, 16);
			label20.Size = size;
			this.Label53.TabIndex = 4;
			this.Label53.Text = "透明度(0全透明,255不透明)";
			this.TabPage8.Controls.Add(this.GroupBox4);
			this.TabPage8.Controls.Add(this.GroupBoxtitle1);
			this.TabPage8.Controls.Add(this.GroupBoxtitle2);
			System.Windows.Forms.TabPage tabPage4 = this.TabPage8;
			location = new System.Drawing.Point(4, 22);
			tabPage4.Location = location;
			this.TabPage8.Name = "TabPage8";
			System.Windows.Forms.Control tabPage5 = this.TabPage8;
			padding = new System.Windows.Forms.Padding(3);
			tabPage5.Padding = padding;
			System.Windows.Forms.Control tabPage6 = this.TabPage8;
			size = new System.Drawing.Size(536, 465);
			tabPage6.Size = size;
			this.TabPage8.TabIndex = 8;
			this.TabPage8.Text = "表头及标题";
			this.TabPage8.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.reportheaderspace);
			this.GroupBox4.Controls.Add(this.Label34);
			this.GroupBox4.Controls.Add(this.reportheaderfont);
			this.GroupBox4.Controls.Add(this.reportheadertext);
			this.GroupBox4.Controls.Add(this.Label33);
			this.GroupBox4.Controls.Add(this.Label32);
			this.GroupBox4.Controls.Add(this.Label31);
			this.GroupBox4.Controls.Add(this.reportheaderalignment);
			System.Windows.Forms.Control groupBox5 = this.GroupBox4;
			location = new System.Drawing.Point(6, 6);
			groupBox5.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			System.Windows.Forms.Control groupBox6 = this.GroupBox4;
			size = new System.Drawing.Size(526, 126);
			groupBox6.Size = size;
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "表头";
			System.Windows.Forms.NumericUpDown reportheaderspace = this.reportheaderspace;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			reportheaderspace.Increment = num;
			System.Windows.Forms.Control reportheaderspace2 = this.reportheaderspace;
			location = new System.Drawing.Point(228, 79);
			reportheaderspace2.Location = location;
			System.Windows.Forms.NumericUpDown reportheaderspace3 = this.reportheaderspace;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			reportheaderspace3.Maximum = num;
			this.reportheaderspace.Name = "reportheaderspace";
			System.Windows.Forms.Control reportheaderspace4 = this.reportheaderspace;
			size = new System.Drawing.Size(50, 21);
			reportheaderspace4.Size = size;
			this.reportheaderspace.TabIndex = 39;
			this.reportheaderspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Label34.AutoSize = true;
			System.Windows.Forms.Control label21 = this.Label34;
			location = new System.Drawing.Point(8, 83);
			label21.Location = location;
			this.Label34.Name = "Label34";
			System.Windows.Forms.Control label22 = this.Label34;
			size = new System.Drawing.Size(221, 12);
			label22.Size = size;
			this.Label34.TabIndex = 38;
			this.Label34.Text = "表头与表格\"主标题\"间的间距（毫米）：";
			System.Windows.Forms.Control reportheaderfont = this.reportheaderfont;
			location = new System.Drawing.Point(439, 78);
			reportheaderfont.Location = location;
			this.reportheaderfont.Name = "reportheaderfont";
			System.Windows.Forms.Control reportheaderfont2 = this.reportheaderfont;
			size = new System.Drawing.Size(83, 23);
			reportheaderfont2.Size = size;
			this.reportheaderfont.TabIndex = 36;
			this.reportheaderfont.Text = "字体及颜色";
			this.reportheaderfont.UseVisualStyleBackColor = true;
			this.reportheadertext.AcceptsReturn = true;
			this.reportheadertext.Font = new System.Drawing.Font("宋体", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control reportheadertext = this.reportheadertext;
			location = new System.Drawing.Point(61, 12);
			reportheadertext.Location = location;
			this.reportheadertext.Multiline = true;
			this.reportheadertext.Name = "reportheadertext";
			this.reportheadertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control reportheadertext2 = this.reportheadertext;
			size = new System.Drawing.Size(459, 62);
			reportheadertext2.Size = size;
			this.reportheadertext.TabIndex = 35;
			this.reportheadertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Label33.AutoSize = true;
			this.Label33.ForeColor = System.Drawing.Color.Fuchsia;
			System.Windows.Forms.Control label23 = this.Label33;
			location = new System.Drawing.Point(7, 107);
			label23.Location = location;
			this.Label33.Name = "Label33";
			System.Windows.Forms.Control label24 = this.Label33;
			size = new System.Drawing.Size(383, 12);
			label24.Size = size;
			this.Label33.TabIndex = 34;
			this.Label33.Text = "注：表头内容可以有多行，打印在报表\"主标题 \"的前面，且只首页打印";
			this.Label32.AutoSize = true;
			System.Windows.Forms.Control label25 = this.Label32;
			location = new System.Drawing.Point(284, 83);
			label25.Location = location;
			this.Label32.Name = "Label32";
			System.Windows.Forms.Control label26 = this.Label32;
			size = new System.Drawing.Size(65, 12);
			label26.Size = size;
			this.Label32.TabIndex = 34;
			this.Label32.Text = "对齐方式：";
			this.Label31.AutoSize = true;
			System.Windows.Forms.Control label27 = this.Label31;
			location = new System.Drawing.Point(0, 42);
			label27.Location = location;
			this.Label31.Name = "Label31";
			System.Windows.Forms.Control label28 = this.Label31;
			size = new System.Drawing.Size(65, 12);
			label28.Size = size;
			this.Label31.TabIndex = 34;
			this.Label31.Text = "表头内容：";
			this.reportheaderalignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.reportheaderalignment.FormattingEnabled = true;
			this.reportheaderalignment.Items.AddRange(new object[]
			{
				"居中对齐",
				"左对齐",
				"右对齐"
			});
			System.Windows.Forms.Control reportheaderalignment = this.reportheaderalignment;
			location = new System.Drawing.Point(350, 79);
			reportheaderalignment.Location = location;
			this.reportheaderalignment.Name = "reportheaderalignment";
			System.Windows.Forms.Control reportheaderalignment2 = this.reportheaderalignment;
			size = new System.Drawing.Size(87, 20);
			reportheaderalignment2.Size = size;
			this.reportheaderalignment.TabIndex = 33;
			this.GroupBoxtitle1.Controls.Add(this.maintitleheight);
			this.GroupBoxtitle1.Controls.Add(this.Label40);
			this.GroupBoxtitle1.Controls.Add(this.maintitle);
			this.GroupBoxtitle1.Controls.Add(this.Label54);
			this.GroupBoxtitle1.Controls.Add(this.maintitleprinteverpage);
			this.GroupBoxtitle1.Controls.Add(this.maintitlealign);
			this.GroupBoxtitle1.Controls.Add(this.Button1);
			System.Windows.Forms.Control groupBoxtitle = this.GroupBoxtitle1;
			location = new System.Drawing.Point(7, 138);
			groupBoxtitle.Location = location;
			this.GroupBoxtitle1.Name = "GroupBoxtitle1";
			System.Windows.Forms.Control groupBoxtitle2 = this.GroupBoxtitle1;
			size = new System.Drawing.Size(523, 114);
			groupBoxtitle2.Size = size;
			this.GroupBoxtitle1.TabIndex = 15;
			this.GroupBoxtitle1.TabStop = false;
			this.GroupBoxtitle1.Text = "主标题（可多行）";
			this.maintitleheight.DecimalPlaces = 1;
			this.maintitleheight.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control maintitleheight = this.maintitleheight;
			location = new System.Drawing.Point(272, 84);
			maintitleheight.Location = location;
			System.Windows.Forms.NumericUpDown maintitleheight2 = this.maintitleheight;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			maintitleheight2.Maximum = num;
			this.maintitleheight.Name = "maintitleheight";
			System.Windows.Forms.Control maintitleheight3 = this.maintitleheight;
			size = new System.Drawing.Size(63, 23);
			maintitleheight3.Size = size;
			this.maintitleheight.TabIndex = 30;
			System.Windows.Forms.NumericUpDown maintitleheight4 = this.maintitleheight;
			num = new decimal(new int[]
			{
				7,
				0,
				0,
				0
			});
			maintitleheight4.Value = num;
			this.Label40.AutoSize = true;
			System.Windows.Forms.Control label29 = this.Label40;
			location = new System.Drawing.Point(153, 89);
			label29.Location = location;
			this.Label40.Name = "Label40";
			System.Windows.Forms.Control label30 = this.Label40;
			size = new System.Drawing.Size(113, 12);
			label30.Size = size;
			this.Label40.TabIndex = 29;
			this.Label40.Text = "打印高度（毫米）：";
			this.maintitle.AcceptsReturn = true;
			this.maintitle.Font = new System.Drawing.Font("黑体", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control maintitle = this.maintitle;
			location = new System.Drawing.Point(6, 14);
			maintitle.Location = location;
			this.maintitle.Multiline = true;
			this.maintitle.Name = "maintitle";
			this.maintitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control maintitle2 = this.maintitle;
			size = new System.Drawing.Size(511, 67);
			maintitle2.Size = size;
			this.maintitle.TabIndex = 1;
			this.maintitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Label54.AutoSize = true;
			System.Windows.Forms.Control label31 = this.Label54;
			location = new System.Drawing.Point(6, 89);
			label31.Location = location;
			this.Label54.Name = "Label54";
			System.Windows.Forms.Control label32 = this.Label54;
			size = new System.Drawing.Size(65, 12);
			label32.Size = size;
			this.Label54.TabIndex = 10;
			this.Label54.Text = "对齐方式：";
			this.maintitleprinteverpage.AutoSize = true;
			this.maintitleprinteverpage.Checked = true;
			this.maintitleprinteverpage.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control maintitleprinteverpage = this.maintitleprinteverpage;
			location = new System.Drawing.Point(425, 87);
			maintitleprinteverpage.Location = location;
			this.maintitleprinteverpage.Name = "maintitleprinteverpage";
			System.Windows.Forms.Control maintitleprinteverpage2 = this.maintitleprinteverpage;
			size = new System.Drawing.Size(84, 16);
			maintitleprinteverpage2.Size = size;
			this.maintitleprinteverpage.TabIndex = 14;
			this.maintitleprinteverpage.Text = "每页都打印";
			this.maintitleprinteverpage.UseVisualStyleBackColor = true;
			this.maintitlealign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.maintitlealign.FormattingEnabled = true;
			this.maintitlealign.Items.AddRange(new object[]
			{
				"居中对齐",
				"左对齐",
				"右对齐"
			});
			System.Windows.Forms.Control maintitlealign = this.maintitlealign;
			location = new System.Drawing.Point(73, 85);
			maintitlealign.Location = location;
			this.maintitlealign.Name = "maintitlealign";
			System.Windows.Forms.Control maintitlealign2 = this.maintitlealign;
			size = new System.Drawing.Size(79, 20);
			maintitlealign2.Size = size;
			this.maintitlealign.TabIndex = 9;
			this.Button1.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button3 = this.Button1;
			location = new System.Drawing.Point(341, 83);
			button3.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button4 = this.Button1;
			size = new System.Drawing.Size(78, 24);
			button4.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "字体及颜色";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBoxtitle2.Controls.Add(this.subtitleheight);
			this.GroupBoxtitle2.Controls.Add(this.Label41);
			this.GroupBoxtitle2.Controls.Add(this.d1);
			this.GroupBoxtitle2.Controls.Add(this.subtitlepritneverypage);
			this.GroupBoxtitle2.Controls.Add(this.Button4);
			this.GroupBoxtitle2.Controls.Add(this.Button3);
			this.GroupBoxtitle2.Controls.Add(this.Button2);
			System.Windows.Forms.Control groupBoxtitle3 = this.GroupBoxtitle2;
			location = new System.Drawing.Point(3, 255);
			groupBoxtitle3.Location = location;
			this.GroupBoxtitle2.Name = "GroupBoxtitle2";
			System.Windows.Forms.Control groupBoxtitle4 = this.GroupBoxtitle2;
			size = new System.Drawing.Size(536, 201);
			groupBoxtitle4.Size = size;
			this.GroupBoxtitle2.TabIndex = 37;
			this.GroupBoxtitle2.TabStop = false;
			this.GroupBoxtitle2.Text = "表格页眉";
			this.subtitleheight.DecimalPlaces = 1;
			this.subtitleheight.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control subtitleheight = this.subtitleheight;
			location = new System.Drawing.Point(136, 172);
			subtitleheight.Location = location;
			System.Windows.Forms.NumericUpDown subtitleheight2 = this.subtitleheight;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			subtitleheight2.Maximum = num;
			this.subtitleheight.Name = "subtitleheight";
			System.Windows.Forms.Control subtitleheight3 = this.subtitleheight;
			size = new System.Drawing.Size(72, 23);
			subtitleheight3.Size = size;
			this.subtitleheight.TabIndex = 30;
			System.Windows.Forms.NumericUpDown subtitleheight4 = this.subtitleheight;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			subtitleheight4.Value = num;
			this.Label41.AutoSize = true;
			System.Windows.Forms.Control label33 = this.Label41;
			location = new System.Drawing.Point(12, 177);
			label33.Location = location;
			this.Label41.Name = "Label41";
			System.Windows.Forms.Control label34 = this.Label41;
			size = new System.Drawing.Size(113, 12);
			label34.Size = size;
			this.Label41.TabIndex = 29;
			this.Label41.Text = "单行高度（毫米）：";
			this.d1.AllowUserToAddRows = false;
			this.d1.AllowUserToDeleteRows = false;
			this.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.d1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.DataGridViewTextBoxColumn_0,
				this.DataGridViewTextBoxColumn_1,
				this.DataGridViewTextBoxColumn_2,
				this.DataGridViewTextBoxColumn_3,
				this.DataGridViewTextBoxColumn_4,
				this.DataGridViewTextBoxColumn_5,
				this.DataGridViewTextBoxColumn_6
			});
			this.d1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			System.Windows.Forms.Control d = this.d1;
			location = new System.Drawing.Point(9, 15);
			d.Location = location;
			this.d1.Name = "d1";
			this.d1.ReadOnly = true;
			this.d1.RowTemplate.Height = 23;
			this.d1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			System.Windows.Forms.Control d2 = this.d1;
			size = new System.Drawing.Size(513, 155);
			d2.Size = size;
			this.d1.TabIndex = 11;
			this.DataGridViewTextBoxColumn_0.HeaderText = "打印内容";
			this.DataGridViewTextBoxColumn_0.Name = "打印内容";
			this.DataGridViewTextBoxColumn_0.ReadOnly = true;
			this.DataGridViewTextBoxColumn_1.HeaderText = "打印级次";
			this.DataGridViewTextBoxColumn_1.Name = "打印级次";
			this.DataGridViewTextBoxColumn_1.ReadOnly = true;
			this.DataGridViewTextBoxColumn_1.Width = 60;
			this.DataGridViewTextBoxColumn_2.HeaderText = "对齐方式";
			this.DataGridViewTextBoxColumn_2.Name = "对齐方式";
			this.DataGridViewTextBoxColumn_2.ReadOnly = true;
			this.DataGridViewTextBoxColumn_2.Width = 60;
			this.DataGridViewTextBoxColumn_3.HeaderText = "字体字号";
			this.DataGridViewTextBoxColumn_3.Name = "字体字号";
			this.DataGridViewTextBoxColumn_3.ReadOnly = true;
			this.DataGridViewTextBoxColumn_3.Width = 60;
			this.DataGridViewTextBoxColumn_4.HeaderText = "打印高度";
			this.DataGridViewTextBoxColumn_4.Name = "打印高度";
			this.DataGridViewTextBoxColumn_4.ReadOnly = true;
			this.DataGridViewTextBoxColumn_4.Width = 60;
			this.DataGridViewTextBoxColumn_5.HeaderText = "打印宽度";
			this.DataGridViewTextBoxColumn_5.Name = "打印宽度";
			this.DataGridViewTextBoxColumn_5.ReadOnly = true;
			this.DataGridViewTextBoxColumn_5.Width = 60;
			this.DataGridViewTextBoxColumn_6.HeaderText = "前景颜色";
			this.DataGridViewTextBoxColumn_6.Name = "前景颜色";
			this.DataGridViewTextBoxColumn_6.ReadOnly = true;
			this.DataGridViewTextBoxColumn_6.Width = 60;
			this.subtitlepritneverypage.AutoSize = true;
			this.subtitlepritneverypage.Checked = true;
			this.subtitlepritneverypage.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control subtitlepritneverypage = this.subtitlepritneverypage;
			location = new System.Drawing.Point(234, 175);
			subtitlepritneverypage.Location = location;
			this.subtitlepritneverypage.Name = "subtitlepritneverypage";
			System.Windows.Forms.Control subtitlepritneverypage2 = this.subtitlepritneverypage;
			size = new System.Drawing.Size(96, 16);
			subtitlepritneverypage2.Size = size;
			this.subtitlepritneverypage.TabIndex = 14;
			this.subtitlepritneverypage.Text = "每页都要打印";
			this.subtitlepritneverypage.UseVisualStyleBackColor = true;
			this.Button4.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button5 = this.Button4;
			location = new System.Drawing.Point(462, 171);
			button5.Location = location;
			this.Button4.Name = "Button4";
			System.Windows.Forms.Control button6 = this.Button4;
			size = new System.Drawing.Size(59, 24);
			button6.Size = size;
			this.Button4.TabIndex = 3;
			this.Button4.Text = "修改";
			this.Button4.UseVisualStyleBackColor = true;
			this.Button3.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button7 = this.Button3;
			location = new System.Drawing.Point(397, 171);
			button7.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Control button8 = this.Button3;
			size = new System.Drawing.Size(59, 24);
			button8.Size = size;
			this.Button3.TabIndex = 3;
			this.Button3.Text = "删除";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button2.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button9 = this.Button2;
			location = new System.Drawing.Point(332, 171);
			button9.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button10 = this.Button2;
			size = new System.Drawing.Size(59, 24);
			button10.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.Text = "增加";
			this.Button2.UseVisualStyleBackColor = true;
			this.TabPage1.Controls.Add(this.GroupBox31);
			this.TabPage1.Controls.Add(this.GroupBox3);
			this.TabPage1.Controls.Add(this.GroupBoxtablestyle);
			System.Windows.Forms.TabPage tabPage7 = this.TabPage1;
			location = new System.Drawing.Point(4, 22);
			tabPage7.Location = location;
			this.TabPage1.Name = "TabPage1";
			System.Windows.Forms.Control tabPage8 = this.TabPage1;
			padding = new System.Windows.Forms.Padding(3);
			tabPage8.Padding = padding;
			System.Windows.Forms.Control tabPage9 = this.TabPage1;
			size = new System.Drawing.Size(536, 465);
			tabPage9.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "表格样式";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.GroupBox31.Controls.Add(this.bordertype);
			this.GroupBox31.Controls.Add(this.fieldheight);
			this.GroupBox31.Controls.Add(this.Label3);
			this.GroupBox31.Controls.Add(this.rowheight);
			this.GroupBox31.Controls.Add(this.Label24);
			this.GroupBox31.Controls.Add(this.linewidth);
			this.GroupBox31.Controls.Add(this.linecolor);
			this.GroupBox31.Controls.Add(this.Label27);
			this.GroupBox31.Controls.Add(this.Label89);
			this.GroupBox31.Controls.Add(this.zoomtopaperwidth);
			this.GroupBox31.Controls.Add(this.gwxouterborder);
			System.Windows.Forms.Control groupBox7 = this.GroupBox31;
			location = new System.Drawing.Point(5, 126);
			groupBox7.Location = location;
			this.GroupBox31.Name = "GroupBox31";
			System.Windows.Forms.Control groupBox8 = this.GroupBox31;
			size = new System.Drawing.Size(528, 122);
			groupBox8.Size = size;
			this.GroupBox31.TabIndex = 10;
			this.GroupBox31.TabStop = false;
			this.GroupBox31.Text = "表格设置";
			this.bordertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bordertype.FormattingEnabled = true;
			this.bordertype.Items.AddRange(new object[]
			{
				"表格线",
				"仅横线",
				"仅竖线"
			});
			System.Windows.Forms.Control bordertype = this.bordertype;
			location = new System.Drawing.Point(107, 18);
			bordertype.Location = location;
			this.bordertype.Name = "bordertype";
			System.Windows.Forms.Control bordertype2 = this.bordertype;
			size = new System.Drawing.Size(84, 20);
			bordertype2.Size = size;
			this.bordertype.TabIndex = 33;
			this.fieldheight.DecimalPlaces = 1;
			this.fieldheight.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control fieldheight = this.fieldheight;
			location = new System.Drawing.Point(396, 87);
			fieldheight.Location = location;
			System.Windows.Forms.NumericUpDown fieldheight2 = this.fieldheight;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			fieldheight2.Maximum = num;
			System.Windows.Forms.NumericUpDown fieldheight3 = this.fieldheight;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			fieldheight3.Minimum = num;
			this.fieldheight.Name = "fieldheight";
			System.Windows.Forms.Control fieldheight4 = this.fieldheight;
			size = new System.Drawing.Size(75, 21);
			fieldheight4.Size = size;
			this.fieldheight.TabIndex = 32;
			this.fieldheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown fieldheight5 = this.fieldheight;
			num = new decimal(new int[]
			{
				8,
				0,
				0,
				0
			});
			fieldheight5.Value = num;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Control label35 = this.Label3;
			location = new System.Drawing.Point(252, 91);
			label35.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label36 = this.Label3;
			size = new System.Drawing.Size(149, 12);
			label36.Size = size;
			this.Label3.TabIndex = 29;
			this.Label3.Text = "表格列标题高度（毫米）：";
			this.rowheight.DecimalPlaces = 1;
			this.rowheight.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control rowheight = this.rowheight;
			location = new System.Drawing.Point(152, 87);
			rowheight.Location = location;
			System.Windows.Forms.NumericUpDown rowheight2 = this.rowheight;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			rowheight2.Maximum = num;
			System.Windows.Forms.NumericUpDown rowheight3 = this.rowheight;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			rowheight3.Minimum = num;
			this.rowheight.Name = "rowheight";
			System.Windows.Forms.Control rowheight4 = this.rowheight;
			size = new System.Drawing.Size(75, 21);
			rowheight4.Size = size;
			this.rowheight.TabIndex = 32;
			this.rowheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown rowheight5 = this.rowheight;
			num = new decimal(new int[]
			{
				6,
				0,
				0,
				0
			});
			rowheight5.Value = num;
			this.Label24.AutoSize = true;
			System.Windows.Forms.Control label37 = this.Label24;
			location = new System.Drawing.Point(15, 91);
			label37.Location = location;
			this.Label24.Name = "Label24";
			System.Windows.Forms.Control label38 = this.Label24;
			size = new System.Drawing.Size(137, 12);
			label38.Size = size;
			this.Label24.TabIndex = 29;
			this.Label24.Text = "表格内容行高（毫米）：";
			this.linewidth.DecimalPlaces = 1;
			System.Windows.Forms.NumericUpDown linewidth = this.linewidth;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			linewidth.Increment = num;
			System.Windows.Forms.Control linewidth2 = this.linewidth;
			location = new System.Drawing.Point(395, 20);
			linewidth2.Location = location;
			System.Windows.Forms.NumericUpDown linewidth3 = this.linewidth;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			linewidth3.Maximum = num;
			this.linewidth.Name = "linewidth";
			System.Windows.Forms.Control linewidth4 = this.linewidth;
			size = new System.Drawing.Size(76, 21);
			linewidth4.Size = size;
			this.linewidth.TabIndex = 20;
			this.linewidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown linewidth5 = this.linewidth;
			num = new decimal(new int[]
			{
				3,
				0,
				0,
				65536
			});
			linewidth5.Value = num;
			this.linecolor.ForeColor = System.Drawing.Color.Black;
			System.Windows.Forms.Control linecolor = this.linecolor;
			location = new System.Drawing.Point(15, 51);
			linecolor.Location = location;
			this.linecolor.Name = "linecolor";
			System.Windows.Forms.Control linecolor2 = this.linecolor;
			size = new System.Drawing.Size(100, 23);
			linecolor2.Size = size;
			this.linecolor.TabIndex = 19;
			this.linecolor.Text = "表格线颜色";
			this.linecolor.UseVisualStyleBackColor = true;
			this.Label27.AutoSize = true;
			System.Windows.Forms.Control label39 = this.Label27;
			location = new System.Drawing.Point(14, 22);
			label39.Location = location;
			this.Label27.Name = "Label27";
			System.Windows.Forms.Control label40 = this.Label27;
			size = new System.Drawing.Size(89, 12);
			label40.Size = size;
			this.Label27.TabIndex = 3;
			this.Label27.Text = "表格边框类型：";
			this.Label89.AutoSize = true;
			System.Windows.Forms.Control label41 = this.Label89;
			location = new System.Drawing.Point(252, 23);
			label41.Location = location;
			this.Label89.Name = "Label89";
			System.Windows.Forms.Control label42 = this.Label89;
			size = new System.Drawing.Size(113, 12);
			label42.Size = size;
			this.Label89.TabIndex = 3;
			this.Label89.Text = "表格线宽（毫米）：";
			this.zoomtopaperwidth.AutoSize = true;
			this.zoomtopaperwidth.Checked = true;
			this.zoomtopaperwidth.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control zoomtopaperwidth = this.zoomtopaperwidth;
			location = new System.Drawing.Point(254, 54);
			zoomtopaperwidth.Location = location;
			this.zoomtopaperwidth.Name = "zoomtopaperwidth";
			System.Windows.Forms.Control zoomtopaperwidth2 = this.zoomtopaperwidth;
			size = new System.Drawing.Size(180, 16);
			zoomtopaperwidth2.Size = size;
			this.zoomtopaperwidth.TabIndex = 17;
			this.zoomtopaperwidth.Text = "将表格缩放至纸张宽度或栏宽";
			this.zoomtopaperwidth.UseVisualStyleBackColor = true;
			this.gwxouterborder.AutoSize = true;
			System.Windows.Forms.Control gwxouterborder = this.gwxouterborder;
			location = new System.Drawing.Point(128, 54);
			gwxouterborder.Location = location;
			this.gwxouterborder.Name = "gwxouterborder";
			System.Windows.Forms.Control gwxouterborder2 = this.gwxouterborder;
			size = new System.Drawing.Size(108, 16);
			gwxouterborder2.Size = size;
			this.gwxouterborder.TabIndex = 17;
			this.gwxouterborder.Text = "表格外边框加粗";
			this.gwxouterborder.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.GroupBox1);
			this.GroupBox3.Controls.Add(this.GroupBox17);
			this.GroupBox3.Controls.Add(this.minsize);
			this.GroupBox3.Controls.Add(this.Label6);
			System.Windows.Forms.Control groupBox9 = this.GroupBox3;
			location = new System.Drawing.Point(6, 261);
			groupBox9.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			System.Windows.Forms.Control groupBox10 = this.GroupBox3;
			size = new System.Drawing.Size(527, 186);
			groupBox10.Size = size;
			this.GroupBox3.TabIndex = 4;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "其他设置";
			this.GroupBox1.Controls.Add(this.cbottom);
			this.GroupBox1.Controls.Add(this.ctop);
			this.GroupBox1.Controls.Add(this.cright);
			this.GroupBox1.Controls.Add(this.cleft);
			this.GroupBox1.Controls.Add(this.Label30);
			this.GroupBox1.Controls.Add(this.Label29);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label25);
			System.Windows.Forms.Control groupBox11 = this.GroupBox1;
			location = new System.Drawing.Point(6, 46);
			groupBox11.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			System.Windows.Forms.Control groupBox12 = this.GroupBox1;
			size = new System.Drawing.Size(512, 53);
			groupBox12.Size = size;
			this.GroupBox1.TabIndex = 31;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "单元格边距(毫米)：";
			this.cbottom.DecimalPlaces = 2;
			this.cbottom.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.NumericUpDown cbottom = this.cbottom;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			cbottom.Increment = num;
			System.Windows.Forms.Control cbottom2 = this.cbottom;
			location = new System.Drawing.Point(424, 20);
			cbottom2.Location = location;
			System.Windows.Forms.NumericUpDown cbottom3 = this.cbottom;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			cbottom3.Maximum = num;
			this.cbottom.Name = "cbottom";
			System.Windows.Forms.Control cbottom4 = this.cbottom;
			size = new System.Drawing.Size(75, 23);
			cbottom4.Size = size;
			this.cbottom.TabIndex = 32;
			this.ctop.DecimalPlaces = 2;
			this.ctop.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.NumericUpDown ctop = this.ctop;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			ctop.Increment = num;
			System.Windows.Forms.Control ctop2 = this.ctop;
			location = new System.Drawing.Point(305, 20);
			ctop2.Location = location;
			System.Windows.Forms.NumericUpDown ctop3 = this.ctop;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			ctop3.Maximum = num;
			this.ctop.Name = "ctop";
			System.Windows.Forms.Control ctop4 = this.ctop;
			size = new System.Drawing.Size(75, 23);
			ctop4.Size = size;
			this.ctop.TabIndex = 32;
			this.cright.DecimalPlaces = 2;
			this.cright.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.NumericUpDown cright = this.cright;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			cright.Increment = num;
			System.Windows.Forms.Control cright2 = this.cright;
			location = new System.Drawing.Point(171, 21);
			cright2.Location = location;
			System.Windows.Forms.NumericUpDown cright3 = this.cright;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			cright3.Maximum = num;
			this.cright.Name = "cright";
			System.Windows.Forms.Control cright4 = this.cright;
			size = new System.Drawing.Size(75, 23);
			cright4.Size = size;
			this.cright.TabIndex = 32;
			this.cleft.DecimalPlaces = 2;
			this.cleft.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.NumericUpDown cleft = this.cleft;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			cleft.Increment = num;
			System.Windows.Forms.Control cleft2 = this.cleft;
			location = new System.Drawing.Point(47, 21);
			cleft2.Location = location;
			System.Windows.Forms.NumericUpDown cleft3 = this.cleft;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			cleft3.Maximum = num;
			this.cleft.Name = "cleft";
			System.Windows.Forms.Control cleft4 = this.cleft;
			size = new System.Drawing.Size(75, 23);
			cleft4.Size = size;
			this.cleft.TabIndex = 32;
			System.Windows.Forms.NumericUpDown cleft5 = this.cleft;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			cleft5.Value = num;
			this.Label30.AutoSize = true;
			System.Windows.Forms.Control label43 = this.Label30;
			location = new System.Drawing.Point(12, 25);
			label43.Location = location;
			this.Label30.Name = "Label30";
			System.Windows.Forms.Control label44 = this.Label30;
			size = new System.Drawing.Size(29, 12);
			label44.Size = size;
			this.Label30.TabIndex = 21;
			this.Label30.Text = "左边";
			this.Label29.AutoSize = true;
			System.Windows.Forms.Control label45 = this.Label29;
			location = new System.Drawing.Point(139, 25);
			label45.Location = location;
			this.Label29.Name = "Label29";
			System.Windows.Forms.Control label46 = this.Label29;
			size = new System.Drawing.Size(29, 12);
			label46.Size = size;
			this.Label29.TabIndex = 18;
			this.Label29.Text = "右边";
			this.Label2.AutoSize = true;
			System.Windows.Forms.Control label47 = this.Label2;
			location = new System.Drawing.Point(393, 25);
			label47.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label48 = this.Label2;
			size = new System.Drawing.Size(29, 12);
			label48.Size = size;
			this.Label2.TabIndex = 20;
			this.Label2.Text = "下边";
			this.Label25.AutoSize = true;
			System.Windows.Forms.Control label49 = this.Label25;
			location = new System.Drawing.Point(266, 25);
			label49.Location = location;
			this.Label25.Name = "Label25";
			System.Windows.Forms.Control label50 = this.Label25;
			size = new System.Drawing.Size(29, 12);
			label50.Size = size;
			this.Label25.TabIndex = 19;
			this.Label25.Text = "上边";
			this.GroupBox17.Controls.Add(this.Cbackcolor);
			this.GroupBox17.Controls.Add(this.Cforecolor);
			this.GroupBox17.Controls.Add(this.bbackcolor);
			this.GroupBox17.Controls.Add(this.jsh);
			this.GroupBox17.Controls.Add(this.bforecolor);
			System.Windows.Forms.Control groupBox13 = this.GroupBox17;
			location = new System.Drawing.Point(9, 118);
			groupBox13.Location = location;
			this.GroupBox17.Name = "GroupBox17";
			System.Windows.Forms.Control groupBox14 = this.GroupBox17;
			size = new System.Drawing.Size(509, 46);
			groupBox14.Size = size;
			this.GroupBox17.TabIndex = 29;
			this.GroupBox17.TabStop = false;
			this.GroupBox17.Text = "交替行数据颜色设置";
			this.Cbackcolor.AutoSize = true;
			this.Cbackcolor.Checked = true;
			this.Cbackcolor.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control cbackcolor = this.Cbackcolor;
			location = new System.Drawing.Point(299, 21);
			cbackcolor.Location = location;
			this.Cbackcolor.Name = "Cbackcolor";
			System.Windows.Forms.Control cbackcolor2 = this.Cbackcolor;
			size = new System.Drawing.Size(120, 16);
			cbackcolor2.Size = size;
			this.Cbackcolor.TabIndex = 28;
			this.Cbackcolor.Text = "禁用交替行背景色";
			this.Cbackcolor.UseVisualStyleBackColor = true;
			this.Cforecolor.AutoSize = true;
			this.Cforecolor.Checked = true;
			this.Cforecolor.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control cforecolor = this.Cforecolor;
			location = new System.Drawing.Point(90, 21);
			cforecolor.Location = location;
			this.Cforecolor.Name = "Cforecolor";
			System.Windows.Forms.Control cforecolor2 = this.Cforecolor;
			size = new System.Drawing.Size(120, 16);
			cforecolor2.Size = size;
			this.Cforecolor.TabIndex = 28;
			this.Cforecolor.Text = "禁用交替行前景色";
			this.Cforecolor.UseVisualStyleBackColor = true;
			this.bbackcolor.Enabled = false;
			System.Windows.Forms.Control bbackcolor = this.bbackcolor;
			location = new System.Drawing.Point(430, 17);
			bbackcolor.Location = location;
			this.bbackcolor.Name = "bbackcolor";
			System.Windows.Forms.Control bbackcolor2 = this.bbackcolor;
			size = new System.Drawing.Size(75, 25);
			bbackcolor2.Size = size;
			this.bbackcolor.TabIndex = 27;
			this.bbackcolor.Text = "背景颜色";
			this.bbackcolor.UseVisualStyleBackColor = true;
			this.jsh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.Control jsh = this.jsh;
			location = new System.Drawing.Point(3, 17);
			jsh.Location = location;
			this.jsh.Name = "jsh";
			System.Windows.Forms.Control jsh2 = this.jsh;
			size = new System.Drawing.Size(76, 25);
			jsh2.Size = size;
			this.jsh.TabIndex = 20;
			this.jsh.Text = "结果预览";
			this.jsh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bforecolor.Enabled = false;
			System.Windows.Forms.Control bforecolor = this.bforecolor;
			location = new System.Drawing.Point(213, 17);
			bforecolor.Location = location;
			this.bforecolor.Name = "bforecolor";
			System.Windows.Forms.Control bforecolor2 = this.bforecolor;
			size = new System.Drawing.Size(75, 25);
			bforecolor2.Size = size;
			this.bforecolor.TabIndex = 26;
			this.bforecolor.Text = "前景颜色";
			this.bforecolor.UseVisualStyleBackColor = true;
			this.minsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.minsize.FormattingEnabled = true;
			this.minsize.Items.AddRange(new object[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16"
			});
			System.Windows.Forms.Control minsize = this.minsize;
			location = new System.Drawing.Point(433, 20);
			minsize.Location = location;
			this.minsize.Name = "minsize";
			System.Windows.Forms.Control minsize2 = this.minsize;
			size = new System.Drawing.Size(64, 20);
			minsize2.Size = size;
			this.minsize.TabIndex = 26;
			this.Label6.AutoSize = true;
			System.Windows.Forms.Control label51 = this.Label6;
			location = new System.Drawing.Point(12, 24);
			label51.Location = location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Control label52 = this.Label6;
			size = new System.Drawing.Size(383, 12);
			label52.Size = size;
			this.Label6.TabIndex = 7;
			this.Label6.Text = "若单元格内容打印不下，允许缩小到的最小字号(为0表示不允许缩小)：";
			this.GroupBoxtablestyle.Controls.Add(this.fl);
			this.GroupBoxtablestyle.Controls.Add(this.R4);
			this.GroupBoxtablestyle.Controls.Add(this.R3);
			this.GroupBoxtablestyle.Controls.Add(this.R2);
			this.GroupBoxtablestyle.Controls.Add(this.R1);
			this.GroupBoxtablestyle.Controls.Add(this.pt);
			this.GroupBoxtablestyle.Controls.Add(this.fy);
			this.GroupBoxtablestyle.Controls.Add(this.gz);
			System.Windows.Forms.Control groupBoxtablestyle = this.GroupBoxtablestyle;
			location = new System.Drawing.Point(6, 12);
			groupBoxtablestyle.Location = location;
			this.GroupBoxtablestyle.Name = "GroupBoxtablestyle";
			System.Windows.Forms.Control groupBoxtablestyle2 = this.GroupBoxtablestyle;
			size = new System.Drawing.Size(527, 108);
			groupBoxtablestyle2.Size = size;
			this.GroupBoxtablestyle.TabIndex = 0;
			this.GroupBoxtablestyle.TabStop = false;
			this.GroupBoxtablestyle.Text = "表格打印样式";
			this.fl.Controls.Add(this.ljj);
			this.fl.Controls.Add(this.ls);
			this.fl.Controls.Add(this.Label9);
			this.fl.Controls.Add(this.Label8);
			System.Windows.Forms.Control fl = this.fl;
			location = new System.Drawing.Point(10, 28);
			fl.Location = location;
			this.fl.Name = "fl";
			System.Windows.Forms.Control fl2 = this.fl;
			size = new System.Drawing.Size(448, 42);
			fl2.Size = size;
			this.fl.TabIndex = 6;
			this.fl.TabStop = false;
			this.fl.Text = "特殊参数";
			System.Windows.Forms.NumericUpDown ljj = this.ljj;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			ljj.Increment = num;
			System.Windows.Forms.Control ljj2 = this.ljj;
			location = new System.Drawing.Point(241, 14);
			ljj2.Location = location;
			System.Windows.Forms.NumericUpDown ljj3 = this.ljj;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			ljj3.Maximum = num;
			this.ljj.Name = "ljj";
			System.Windows.Forms.Control ljj4 = this.ljj;
			size = new System.Drawing.Size(60, 21);
			ljj4.Size = size;
			this.ljj.TabIndex = 7;
			this.ljj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown ljj5 = this.ljj;
			num = new decimal(new int[]
			{
				20,
				0,
				0,
				0
			});
			ljj5.Value = num;
			this.ls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ls.FormattingEnabled = true;
			this.ls.Items.AddRange(new object[]
			{
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20"
			});
			System.Windows.Forms.Control ls = this.ls;
			location = new System.Drawing.Point(64, 14);
			ls.Location = location;
			this.ls.Name = "ls";
			System.Windows.Forms.Control ls2 = this.ls;
			size = new System.Drawing.Size(53, 20);
			ls2.Size = size;
			this.ls.TabIndex = 6;
			this.Label9.AutoSize = true;
			System.Windows.Forms.Control label53 = this.Label9;
			location = new System.Drawing.Point(146, 19);
			label53.Location = location;
			this.Label9.Name = "Label9";
			System.Windows.Forms.Control label54 = this.Label9;
			size = new System.Drawing.Size(89, 12);
			label54.Size = size;
			this.Label9.TabIndex = 4;
			this.Label9.Text = "栏间距(毫米)：";
			this.Label8.AutoSize = true;
			System.Windows.Forms.Control label55 = this.Label8;
			location = new System.Drawing.Point(3, 18);
			label55.Location = location;
			this.Label8.Name = "Label8";
			System.Windows.Forms.Control label56 = this.Label8;
			size = new System.Drawing.Size(65, 12);
			label56.Size = size;
			this.Label8.TabIndex = 3;
			this.Label8.Text = "每页栏数：";
			this.R4.AutoSize = true;
			System.Windows.Forms.Control r = this.R4;
			location = new System.Drawing.Point(349, 20);
			r.Location = location;
			this.R4.Name = "R4";
			System.Windows.Forms.Control r2 = this.R4;
			size = new System.Drawing.Size(83, 16);
			r2.Size = size;
			this.R4.TabIndex = 12;
			this.R4.Text = "工资条打印";
			this.R4.UseVisualStyleBackColor = true;
			this.R3.AutoSize = true;
			System.Windows.Forms.Control r3 = this.R3;
			location = new System.Drawing.Point(238, 20);
			r3.Location = location;
			this.R3.Name = "R3";
			System.Windows.Forms.Control r4 = this.R3;
			size = new System.Drawing.Size(71, 16);
			r4.Size = size;
			this.R3.TabIndex = 11;
			this.R3.Text = "跨页打印";
			this.R3.UseVisualStyleBackColor = true;
			this.R2.AutoSize = true;
			System.Windows.Forms.Control r5 = this.R2;
			location = new System.Drawing.Point(127, 20);
			r5.Location = location;
			this.R2.Name = "R2";
			System.Windows.Forms.Control r6 = this.R2;
			size = new System.Drawing.Size(71, 16);
			r6.Size = size;
			this.R2.TabIndex = 10;
			this.R2.Text = "分栏打印";
			this.R2.UseVisualStyleBackColor = true;
			this.R1.AutoSize = true;
			this.R1.Checked = true;
			System.Windows.Forms.Control r7 = this.R1;
			location = new System.Drawing.Point(16, 20);
			r7.Location = location;
			this.R1.Name = "R1";
			System.Windows.Forms.Control r8 = this.R1;
			size = new System.Drawing.Size(71, 16);
			r8.Size = size;
			this.R1.TabIndex = 9;
			this.R1.TabStop = true;
			this.R1.Text = "普通表格";
			this.R1.UseVisualStyleBackColor = true;
			this.pt.Controls.Add(this.fixedrows);
			this.pt.Controls.Add(this.addemptyrow);
			this.pt.Controls.Add(this.Label1);
			System.Windows.Forms.Control pt = this.pt;
			location = new System.Drawing.Point(9, 28);
			pt.Location = location;
			this.pt.Name = "pt";
			System.Windows.Forms.Control pt2 = this.pt;
			size = new System.Drawing.Size(451, 42);
			pt2.Size = size;
			this.pt.TabIndex = 9;
			this.pt.TabStop = false;
			this.pt.Text = "特殊参数";
			this.fixedrows.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control fixedrows = this.fixedrows;
			location = new System.Drawing.Point(254, 14);
			fixedrows.Location = location;
			System.Windows.Forms.NumericUpDown fixedrows2 = this.fixedrows;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			fixedrows2.Maximum = num;
			this.fixedrows.Name = "fixedrows";
			System.Windows.Forms.Control fixedrows3 = this.fixedrows;
			size = new System.Drawing.Size(45, 23);
			fixedrows3.Size = size;
			this.fixedrows.TabIndex = 31;
			this.addemptyrow.AutoSize = true;
			System.Windows.Forms.Control addemptyrow = this.addemptyrow;
			location = new System.Drawing.Point(305, 17);
			addemptyrow.Location = location;
			this.addemptyrow.Name = "addemptyrow";
			System.Windows.Forms.Control addemptyrow2 = this.addemptyrow;
			size = new System.Drawing.Size(126, 16);
			addemptyrow2.Size = size;
			this.addemptyrow.TabIndex = 22;
			this.addemptyrow.Text = " 表格尾部添加空行";
			this.addemptyrow.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label57 = this.Label1;
			location = new System.Drawing.Point(10, 18);
			label57.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label58 = this.Label1;
			size = new System.Drawing.Size(239, 12);
			label58.Size = size;
			this.Label1.TabIndex = 30;
			this.Label1.Text = "每页打印固定行数(为0表示自动确定行数)：";
			this.fy.Controls.Add(this.columns);
			this.fy.Controls.Add(this.Label10);
			System.Windows.Forms.Control fy = this.fy;
			location = new System.Drawing.Point(10, 29);
			fy.Location = location;
			this.fy.Name = "fy";
			System.Windows.Forms.Control fy2 = this.fy;
			size = new System.Drawing.Size(450, 42);
			fy2.Size = size;
			this.fy.TabIndex = 7;
			this.fy.TabStop = false;
			this.fy.Text = "特殊参数";
			this.columns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.columns.FormattingEnabled = true;
			this.columns.Items.AddRange(new object[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			});
			System.Windows.Forms.Control columns = this.columns;
			location = new System.Drawing.Point(178, 14);
			columns.Location = location;
			this.columns.Name = "columns";
			System.Windows.Forms.Control columns2 = this.columns;
			size = new System.Drawing.Size(64, 20);
			columns2.Size = size;
			this.columns.TabIndex = 13;
			this.Label10.AutoSize = true;
			System.Windows.Forms.Control label59 = this.Label10;
			location = new System.Drawing.Point(7, 18);
			label59.Location = location;
			this.Label10.Name = "Label10";
			System.Windows.Forms.Control label60 = this.Label10;
			size = new System.Drawing.Size(173, 12);
			label60.Size = size;
			this.Label10.TabIndex = 7;
			this.Label10.Text = "每页需要重复打印的左边列数：";
			this.gz.Controls.Add(this.gzjj);
			this.gz.Controls.Add(this.gzwrap);
			this.gz.Controls.Add(this.lz);
			this.gz.Controls.Add(this.Label7);
			System.Windows.Forms.Control gz = this.gz;
			location = new System.Drawing.Point(10, 58);
			gz.Location = location;
			this.gz.Name = "gz";
			System.Windows.Forms.Control gz2 = this.gz;
			size = new System.Drawing.Size(511, 42);
			gz2.Size = size;
			this.gz.TabIndex = 5;
			this.gz.TabStop = false;
			this.gz.Text = "特殊参数";
			System.Windows.Forms.NumericUpDown gzjj = this.gzjj;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			gzjj.Increment = num;
			System.Windows.Forms.Control gzjj2 = this.gzjj;
			location = new System.Drawing.Point(112, 13);
			gzjj2.Location = location;
			System.Windows.Forms.NumericUpDown gzjj3 = this.gzjj;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			gzjj3.Maximum = num;
			this.gzjj.Name = "gzjj";
			System.Windows.Forms.Control gzjj4 = this.gzjj;
			size = new System.Drawing.Size(60, 21);
			gzjj4.Size = size;
			this.gzjj.TabIndex = 13;
			this.gzjj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown gzjj5 = this.gzjj;
			num = new decimal(new int[]
			{
				3,
				0,
				0,
				0
			});
			gzjj5.Value = num;
			this.gzwrap.AutoSize = true;
			System.Windows.Forms.Control gzwrap = this.gzwrap;
			location = new System.Drawing.Point(327, 15);
			gzwrap.Location = location;
			this.gzwrap.Name = "gzwrap";
			System.Windows.Forms.Control gzwrap2 = this.gzwrap;
			size = new System.Drawing.Size(96, 16);
			gzwrap2.Size = size;
			this.gzwrap.TabIndex = 3;
			this.gzwrap.Text = "自动换行续打";
			this.gzwrap.UseVisualStyleBackColor = true;
			this.lz.AutoSize = true;
			System.Windows.Forms.Control lz = this.lz;
			location = new System.Drawing.Point(177, 15);
			lz.Location = location;
			this.lz.Name = "lz";
			System.Windows.Forms.Control lz2 = this.lz;
			size = new System.Drawing.Size(138, 16);
			lz2.Size = size;
			this.lz.TabIndex = 3;
			this.lz.Text = "打印内容为空或0的列";
			this.lz.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			System.Windows.Forms.Control label61 = this.Label7;
			location = new System.Drawing.Point(3, 17);
			label61.Location = location;
			this.Label7.Name = "Label7";
			System.Windows.Forms.Control label62 = this.Label7;
			size = new System.Drawing.Size(113, 12);
			label62.Size = size;
			this.Label7.TabIndex = 2;
			this.Label7.Text = "工资条间距(毫米)：";
			this.TabPage3.Controls.Add(this.GroupBox8);
			this.TabPage3.Controls.Add(this.GroupBox6);
			this.TabPage3.Controls.Add(this.GroupBoxformat);
			this.TabPage3.Controls.Add(this.GroupBoxxx2);
			this.TabPage3.Controls.Add(this.GroupBoxxx3);
			this.TabPage3.Controls.Add(this.isprint);
			System.Windows.Forms.TabPage tabPage10 = this.TabPage3;
			location = new System.Drawing.Point(4, 22);
			tabPage10.Location = location;
			this.TabPage3.Name = "TabPage3";
			System.Windows.Forms.Control tabPage11 = this.TabPage3;
			padding = new System.Windows.Forms.Padding(3);
			tabPage11.Padding = padding;
			System.Windows.Forms.Control tabPage12 = this.TabPage3;
			size = new System.Drawing.Size(536, 465);
			tabPage12.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "表格列设置";
			this.TabPage3.UseVisualStyleBackColor = true;
			this.GroupBox8.Controls.Add(this.Label12);
			this.GroupBox8.Controls.Add(this.fieldtitle);
			this.GroupBox8.Controls.Add(this.Label13);
			this.GroupBox8.Controls.Add(this.fieldname);
			this.GroupBox8.Controls.Add(this.colwidth);
			this.GroupBox8.Controls.Add(this.Label78);
			this.GroupBox8.Controls.Add(this.iscomp);
			System.Windows.Forms.Control groupBox15 = this.GroupBox8;
			location = new System.Drawing.Point(250, 8);
			groupBox15.Location = location;
			this.GroupBox8.Name = "GroupBox8";
			System.Windows.Forms.Control groupBox16 = this.GroupBox8;
			size = new System.Drawing.Size(289, 108);
			groupBox16.Size = size;
			this.GroupBox8.TabIndex = 42;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "列";
			this.Label12.AutoSize = true;
			System.Windows.Forms.Control label63 = this.Label12;
			location = new System.Drawing.Point(7, 24);
			label63.Location = location;
			this.Label12.Name = "Label12";
			System.Windows.Forms.Control label64 = this.Label12;
			size = new System.Drawing.Size(41, 12);
			label64.Size = size;
			this.Label12.TabIndex = 9;
			this.Label12.Text = "列标题";
			System.Windows.Forms.Control fieldtitle = this.fieldtitle;
			location = new System.Drawing.Point(54, 21);
			fieldtitle.Location = location;
			this.fieldtitle.Name = "fieldtitle";
			System.Windows.Forms.Control fieldtitle2 = this.fieldtitle;
			size = new System.Drawing.Size(229, 21);
			fieldtitle2.Size = size;
			this.fieldtitle.TabIndex = 31;
			this.Label13.AutoSize = true;
			System.Windows.Forms.Control label65 = this.Label13;
			location = new System.Drawing.Point(7, 54);
			label65.Location = location;
			this.Label13.Name = "Label13";
			System.Windows.Forms.Control label66 = this.Label13;
			size = new System.Drawing.Size(41, 12);
			label66.Size = size;
			this.Label13.TabIndex = 9;
			this.Label13.Text = "列内容";
			this.fieldname.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.fieldname.FormattingEnabled = true;
			System.Windows.Forms.Control fieldname = this.fieldname;
			location = new System.Drawing.Point(54, 51);
			fieldname.Location = location;
			this.fieldname.Name = "fieldname";
			System.Windows.Forms.Control fieldname2 = this.fieldname;
			size = new System.Drawing.Size(229, 20);
			fieldname2.Size = size;
			this.fieldname.TabIndex = 11;
			this.colwidth.DecimalPlaces = 1;
			this.colwidth.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control colwidth = this.colwidth;
			location = new System.Drawing.Point(102, 78);
			colwidth.Location = location;
			System.Windows.Forms.NumericUpDown colwidth2 = this.colwidth;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			colwidth2.Maximum = num;
			this.colwidth.Name = "colwidth";
			System.Windows.Forms.Control colwidth3 = this.colwidth;
			size = new System.Drawing.Size(72, 23);
			colwidth3.Size = size;
			this.colwidth.TabIndex = 28;
			System.Windows.Forms.NumericUpDown colwidth4 = this.colwidth;
			num = new decimal(new int[]
			{
				2,
				0,
				0,
				0
			});
			colwidth4.Value = num;
			this.Label78.AutoSize = true;
			System.Windows.Forms.Control label67 = this.Label78;
			location = new System.Drawing.Point(7, 83);
			label67.Location = location;
			this.Label78.Name = "Label78";
			System.Windows.Forms.Control label68 = this.Label78;
			size = new System.Drawing.Size(89, 12);
			label68.Size = size;
			this.Label78.TabIndex = 27;
			this.Label78.Text = "列宽（毫米）：";
			this.iscomp.AutoSize = true;
			System.Windows.Forms.Control iscomp = this.iscomp;
			location = new System.Drawing.Point(187, 81);
			iscomp.Location = location;
			this.iscomp.Name = "iscomp";
			System.Windows.Forms.Control iscomp2 = this.iscomp;
			size = new System.Drawing.Size(96, 16);
			iscomp2.Size = size;
			this.iscomp.TabIndex = 30;
			this.iscomp.Text = "该列为计算列";
			this.iscomp.UseVisualStyleBackColor = true;
			this.GroupBox6.Controls.Add(this.GroupBox7);
			this.GroupBox6.Controls.Add(this.t1);
			this.GroupBox6.Controls.Add(this.GroupBox10);
			this.GroupBox6.Controls.Add(this.GroupBox13);
			System.Windows.Forms.Control groupBox17 = this.GroupBox6;
			location = new System.Drawing.Point(3, 8);
			groupBox17.Location = location;
			this.GroupBox6.Name = "GroupBox6";
			System.Windows.Forms.Control groupBox18 = this.GroupBox6;
			size = new System.Drawing.Size(241, 304);
			groupBox18.Size = size;
			this.GroupBox6.TabIndex = 41;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "表格列设置";
			this.GroupBox7.Controls.Add(this.Button31);
			this.GroupBox7.Controls.Add(this.Button32);
			this.GroupBox7.Controls.Add(this.Button33);
			System.Windows.Forms.Control groupBox19 = this.GroupBox7;
			location = new System.Drawing.Point(149, 102);
			groupBox19.Location = location;
			this.GroupBox7.Name = "GroupBox7";
			System.Windows.Forms.Control groupBox20 = this.GroupBox7;
			size = new System.Drawing.Size(87, 106);
			groupBox20.Size = size;
			this.GroupBox7.TabIndex = 31;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "添加删除列";
			System.Windows.Forms.Control button11 = this.Button31;
			location = new System.Drawing.Point(7, 19);
			button11.Location = location;
			this.Button31.Name = "Button31";
			System.Windows.Forms.Control button12 = this.Button31;
			size = new System.Drawing.Size(75, 25);
			button12.Size = size;
			this.Button31.TabIndex = 1;
			this.Button31.Text = "添加同级";
			this.Button31.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button13 = this.Button32;
			location = new System.Drawing.Point(7, 47);
			button13.Location = location;
			this.Button32.Name = "Button32";
			System.Windows.Forms.Control button14 = this.Button32;
			size = new System.Drawing.Size(76, 25);
			button14.Size = size;
			this.Button32.TabIndex = 1;
			this.Button32.Text = "添加下级";
			this.Button32.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button15 = this.Button33;
			location = new System.Drawing.Point(7, 74);
			button15.Location = location;
			this.Button33.Name = "Button33";
			System.Windows.Forms.Control button16 = this.Button33;
			size = new System.Drawing.Size(76, 25);
			button16.Size = size;
			this.Button33.TabIndex = 1;
			this.Button33.Text = "删除列";
			this.Button33.UseVisualStyleBackColor = true;
			this.t1.HideSelection = false;
			this.t1.ImageIndex = 1;
			this.t1.ImageList = this.ImageList1;
			System.Windows.Forms.Control t = this.t1;
			location = new System.Drawing.Point(3, 20);
			t.Location = location;
			this.t1.Name = "t1";
			this.t1.SelectedImageIndex = 0;
			System.Windows.Forms.Control t2 = this.t1;
			size = new System.Drawing.Size(140, 278);
			t2.Size = size;
			this.t1.TabIndex = 30;
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "check.png");
			this.ImageList1.Images.SetKeyName(1, "icon_circle-empty.png");
			this.ImageList1.Images.SetKeyName(2, "ball_green.png");
			this.GroupBox10.Controls.Add(this.Button9);
			this.GroupBox10.Controls.Add(this.Button12);
			System.Windows.Forms.Control groupBox21 = this.GroupBox10;
			location = new System.Drawing.Point(149, 214);
			groupBox21.Location = location;
			this.GroupBox10.Name = "GroupBox10";
			System.Windows.Forms.Control groupBox22 = this.GroupBox10;
			size = new System.Drawing.Size(87, 83);
			groupBox22.Size = size;
			this.GroupBox10.TabIndex = 25;
			this.GroupBox10.TabStop = false;
			this.GroupBox10.Text = "列级次调整";
			System.Windows.Forms.Control button17 = this.Button9;
			location = new System.Drawing.Point(10, 47);
			button17.Location = location;
			this.Button9.Name = "Button9";
			System.Windows.Forms.Control button18 = this.Button9;
			size = new System.Drawing.Size(61, 25);
			button18.Size = size;
			this.Button9.TabIndex = 1;
			this.Button9.Text = "右移";
			this.ToolTip1.SetToolTip(this.Button9, "降低级次");
			this.Button9.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button19 = this.Button12;
			location = new System.Drawing.Point(10, 16);
			button19.Location = location;
			this.Button12.Name = "Button12";
			System.Windows.Forms.Control button20 = this.Button12;
			size = new System.Drawing.Size(61, 25);
			button20.Size = size;
			this.Button12.TabIndex = 0;
			this.Button12.Text = "左移";
			this.ToolTip1.SetToolTip(this.Button12, "提升为上一级");
			this.Button12.UseVisualStyleBackColor = true;
			this.GroupBox13.Controls.Add(this.Button19);
			this.GroupBox13.Controls.Add(this.Button18);
			System.Windows.Forms.Control groupBox23 = this.GroupBox13;
			location = new System.Drawing.Point(149, 17);
			groupBox23.Location = location;
			this.GroupBox13.Name = "GroupBox13";
			System.Windows.Forms.Control groupBox24 = this.GroupBox13;
			size = new System.Drawing.Size(87, 78);
			groupBox24.Size = size;
			this.GroupBox13.TabIndex = 25;
			this.GroupBox13.TabStop = false;
			this.GroupBox13.Text = "列顺序调整";
			System.Windows.Forms.Control button21 = this.Button19;
			location = new System.Drawing.Point(10, 46);
			button21.Location = location;
			this.Button19.Name = "Button19";
			System.Windows.Forms.Control button22 = this.Button19;
			size = new System.Drawing.Size(61, 25);
			button22.Size = size;
			this.Button19.TabIndex = 1;
			this.Button19.Text = "下移";
			this.Button19.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button23 = this.Button18;
			location = new System.Drawing.Point(10, 18);
			button23.Location = location;
			this.Button18.Name = "Button18";
			System.Windows.Forms.Control button24 = this.Button18;
			size = new System.Drawing.Size(61, 25);
			button24.Size = size;
			this.Button18.TabIndex = 0;
			this.Button18.Text = "上移";
			this.Button18.UseVisualStyleBackColor = true;
			this.GroupBoxformat.Controls.Add(this.GroupBox11);
			this.GroupBoxformat.Controls.Add(this.formatbotton);
			this.GroupBoxformat.Controls.Add(this.Label26);
			this.GroupBoxformat.Controls.Add(this.GroupBox9);
			this.GroupBoxformat.Controls.Add(this.coltype);
			this.GroupBoxformat.Controls.Add(this.ml);
			this.GroupBoxformat.Controls.Add(this.Label23);
			this.GroupBoxformat.Controls.Add(this.colformat);
			this.GroupBoxformat.Controls.Add(this.printzero);
			System.Windows.Forms.Control groupBoxformat = this.GroupBoxformat;
			location = new System.Drawing.Point(6, 318);
			groupBoxformat.Location = location;
			this.GroupBoxformat.Name = "GroupBoxformat";
			System.Windows.Forms.Control groupBoxformat2 = this.GroupBoxformat;
			size = new System.Drawing.Size(538, 142);
			groupBoxformat2.Size = size;
			this.GroupBoxformat.TabIndex = 22;
			this.GroupBoxformat.TabStop = false;
			this.GroupBoxformat.Text = "列打印格式设置";
			this.GroupBox11.Controls.Add(this.RadioButton3);
			this.GroupBox11.Controls.Add(this.RadioButton2);
			this.GroupBox11.Controls.Add(this.RadioButton1);
			System.Windows.Forms.Control groupBox25 = this.GroupBox11;
			location = new System.Drawing.Point(220, 68);
			groupBox25.Location = location;
			this.GroupBox11.Name = "GroupBox11";
			System.Windows.Forms.Control groupBox26 = this.GroupBox11;
			size = new System.Drawing.Size(301, 60);
			groupBox26.Size = size;
			this.GroupBox11.TabIndex = 35;
			this.GroupBox11.TabStop = false;
			this.GroupBox11.Text = "图片打印格式";
			this.GroupBox11.Visible = false;
			this.RadioButton3.AutoSize = true;
			System.Windows.Forms.Control radioButton = this.RadioButton3;
			location = new System.Drawing.Point(151, 26);
			radioButton.Location = location;
			this.RadioButton3.Name = "RadioButton3";
			System.Windows.Forms.Control radioButton2 = this.RadioButton3;
			size = new System.Drawing.Size(47, 16);
			radioButton2.Size = size;
			this.RadioButton3.TabIndex = 0;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "常规";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			System.Windows.Forms.Control radioButton3 = this.RadioButton2;
			location = new System.Drawing.Point(81, 26);
			radioButton3.Location = location;
			this.RadioButton2.Name = "RadioButton2";
			System.Windows.Forms.Control radioButton4 = this.RadioButton2;
			size = new System.Drawing.Size(47, 16);
			radioButton4.Size = size;
			this.RadioButton2.TabIndex = 0;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "缩放";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			System.Windows.Forms.Control radioButton5 = this.RadioButton1;
			location = new System.Drawing.Point(10, 26);
			radioButton5.Location = location;
			this.RadioButton1.Name = "RadioButton1";
			System.Windows.Forms.Control radioButton6 = this.RadioButton1;
			size = new System.Drawing.Size(47, 16);
			radioButton6.Size = size;
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "拉伸";
			this.RadioButton1.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control formatbotton = this.formatbotton;
			location = new System.Drawing.Point(204, 106);
			formatbotton.Location = location;
			this.formatbotton.Name = "formatbotton";
			System.Windows.Forms.Control formatbotton2 = this.formatbotton;
			size = new System.Drawing.Size(97, 23);
			formatbotton2.Size = size;
			this.formatbotton.TabIndex = 34;
			this.formatbotton.Text = "设置格式...";
			this.formatbotton.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label69 = this.Label26;
			location = new System.Drawing.Point(202, 106);
			label69.Location = location;
			this.Label26.Name = "Label26";
			System.Windows.Forms.Control label70 = this.Label26;
			size = new System.Drawing.Size(319, 26);
			label70.Size = size;
			this.Label26.TabIndex = 33;
			this.Label26.Text = "请在格式串设置中指定显示值与打印值对应列表，显示值与打印值间用/分隔，不同对之间用|分隔，比如：0/对|1/错  等";
			this.GroupBox9.Controls.Add(this.xg);
			this.GroupBox9.Controls.Add(this.Label16);
			this.GroupBox9.Controls.Add(this.comptxt);
			this.GroupBox9.Controls.Add(this.Label5);
			System.Windows.Forms.Control groupBox27 = this.GroupBox9;
			location = new System.Drawing.Point(202, 20);
			groupBox27.Location = location;
			this.GroupBox9.Name = "GroupBox9";
			System.Windows.Forms.Control groupBox28 = this.GroupBox9;
			size = new System.Drawing.Size(325, 42);
			groupBox28.Size = size;
			this.GroupBox9.TabIndex = 32;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "示例";
			System.Windows.Forms.Control xg = this.xg;
			location = new System.Drawing.Point(187, 14);
			xg.Location = location;
			this.xg.Name = "xg";
			this.xg.ReadOnly = true;
			System.Windows.Forms.Control xg2 = this.xg;
			size = new System.Drawing.Size(132, 21);
			xg2.Size = size;
			this.xg.TabIndex = 10;
			this.Label16.AutoSize = true;
			System.Windows.Forms.Control label71 = this.Label16;
			location = new System.Drawing.Point(149, 19);
			label71.Location = location;
			this.Label16.Name = "Label16";
			System.Windows.Forms.Control label72 = this.Label16;
			size = new System.Drawing.Size(41, 12);
			label72.Size = size;
			this.Label16.TabIndex = 9;
			this.Label16.Text = "效果：";
			System.Windows.Forms.Control comptxt = this.comptxt;
			location = new System.Drawing.Point(46, 16);
			comptxt.Location = location;
			this.comptxt.Name = "comptxt";
			System.Windows.Forms.Control comptxt2 = this.comptxt;
			size = new System.Drawing.Size(100, 21);
			comptxt2.Size = size;
			this.comptxt.TabIndex = 10;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Control label73 = this.Label5;
			location = new System.Drawing.Point(8, 19);
			label73.Location = location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Control label74 = this.Label5;
			size = new System.Drawing.Size(41, 12);
			label74.Size = size;
			this.Label5.TabIndex = 9;
			this.Label5.Text = "内容：";
			this.coltype.FormattingEnabled = true;
			this.coltype.ItemHeight = 12;
			this.coltype.Items.AddRange(new object[]
			{
				"文本",
				"数值",
				"日期",
				"逻辑",
				"图像"
			});
			System.Windows.Forms.Control coltype = this.coltype;
			location = new System.Drawing.Point(108, 21);
			coltype.Location = location;
			this.coltype.Name = "coltype";
			System.Windows.Forms.Control coltype2 = this.coltype;
			size = new System.Drawing.Size(88, 112);
			coltype2.Size = size;
			this.coltype.TabIndex = 31;
			this.ml.AutoSize = true;
			System.Windows.Forms.Control ml = this.ml;
			location = new System.Drawing.Point(6, 90);
			ml.Location = location;
			this.ml.Name = "ml";
			System.Windows.Forms.Control ml2 = this.ml;
			size = new System.Drawing.Size(96, 16);
			ml2.Size = size;
			this.ml.TabIndex = 30;
			this.ml.Text = "允许折行打印";
			this.ml.UseVisualStyleBackColor = true;
			this.Label23.AutoSize = true;
			System.Windows.Forms.Control label75 = this.Label23;
			location = new System.Drawing.Point(202, 79);
			label75.Location = location;
			this.Label23.Name = "Label23";
			System.Windows.Forms.Control label76 = this.Label23;
			size = new System.Drawing.Size(77, 12);
			label76.Size = size;
			this.Label23.TabIndex = 9;
			this.Label23.Text = "格式串设置：";
			System.Windows.Forms.Control colformat = this.colformat;
			location = new System.Drawing.Point(281, 73);
			colformat.Location = location;
			this.colformat.Name = "colformat";
			System.Windows.Forms.Control colformat2 = this.colformat;
			size = new System.Drawing.Size(240, 21);
			colformat2.Size = size;
			this.colformat.TabIndex = 31;
			this.printzero.AutoSize = true;
			System.Windows.Forms.Control printzero = this.printzero;
			location = new System.Drawing.Point(6, 46);
			printzero.Location = location;
			this.printzero.Name = "printzero";
			System.Windows.Forms.Control printzero2 = this.printzero;
			size = new System.Drawing.Size(72, 16);
			printzero2.Size = size;
			this.printzero.TabIndex = 30;
			this.printzero.Text = "打印零值";
			this.printzero.UseVisualStyleBackColor = true;
			this.GroupBoxxx2.Controls.Add(this.Button16);
			this.GroupBoxxx2.Controls.Add(this.headerfont);
			this.GroupBoxxx2.Controls.Add(this.Button11);
			System.Windows.Forms.Control groupBoxxx = this.GroupBoxxx2;
			location = new System.Drawing.Point(250, 122);
			groupBoxxx.Location = location;
			this.GroupBoxxx2.Name = "GroupBoxxx2";
			System.Windows.Forms.Control groupBoxxx2 = this.GroupBoxxx2;
			size = new System.Drawing.Size(289, 59);
			groupBoxxx2.Size = size;
			this.GroupBoxxx2.TabIndex = 28;
			this.GroupBoxxx2.TabStop = false;
			this.GroupBoxxx2.Text = "列标题";
			System.Windows.Forms.Control button25 = this.Button16;
			location = new System.Drawing.Point(209, 22);
			button25.Location = location;
			this.Button16.Name = "Button16";
			System.Windows.Forms.Control button26 = this.Button16;
			size = new System.Drawing.Size(75, 27);
			button26.Size = size;
			this.Button16.TabIndex = 29;
			this.Button16.Text = "背景颜色";
			this.Button16.UseVisualStyleBackColor = true;
			this.headerfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.Control headerfont = this.headerfont;
			location = new System.Drawing.Point(6, 17);
			headerfont.Location = location;
			this.headerfont.Name = "headerfont";
			System.Windows.Forms.Control headerfont2 = this.headerfont;
			size = new System.Drawing.Size(122, 37);
			headerfont2.Size = size;
			this.headerfont.TabIndex = 25;
			this.headerfont.Text = "结果预览";
			this.headerfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Windows.Forms.Control button27 = this.Button11;
			location = new System.Drawing.Point(129, 22);
			button27.Location = location;
			this.Button11.Name = "Button11";
			System.Windows.Forms.Control button28 = this.Button11;
			size = new System.Drawing.Size(79, 27);
			button28.Size = size;
			this.Button11.TabIndex = 24;
			this.Button11.Text = "字体及颜色";
			this.Button11.UseVisualStyleBackColor = true;
			this.GroupBoxxx3.Controls.Add(this.Button15);
			this.GroupBoxxx3.Controls.Add(this.cellfont);
			this.GroupBoxxx3.Controls.Add(this.Button10);
			this.GroupBoxxx3.Controls.Add(this.Label15);
			this.GroupBoxxx3.Controls.Add(this.Label28);
			this.GroupBoxxx3.Controls.Add(this.valg);
			this.GroupBoxxx3.Controls.Add(this.halg);
			System.Windows.Forms.Control groupBoxxx3 = this.GroupBoxxx3;
			location = new System.Drawing.Point(250, 196);
			groupBoxxx3.Location = location;
			this.GroupBoxxx3.Name = "GroupBoxxx3";
			System.Windows.Forms.Control groupBoxxx4 = this.GroupBoxxx3;
			size = new System.Drawing.Size(294, 87);
			groupBoxxx4.Size = size;
			this.GroupBoxxx3.TabIndex = 27;
			this.GroupBoxxx3.TabStop = false;
			this.GroupBoxxx3.Text = "列内容";
			System.Windows.Forms.Control button29 = this.Button15;
			location = new System.Drawing.Point(209, 22);
			button29.Location = location;
			this.Button15.Name = "Button15";
			System.Windows.Forms.Control button30 = this.Button15;
			size = new System.Drawing.Size(75, 27);
			button30.Size = size;
			this.Button15.TabIndex = 27;
			this.Button15.Text = "背景颜色";
			this.Button15.UseVisualStyleBackColor = true;
			this.cellfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			System.Windows.Forms.Control cellfont = this.cellfont;
			location = new System.Drawing.Point(3, 17);
			cellfont.Location = location;
			this.cellfont.Name = "cellfont";
			System.Windows.Forms.Control cellfont2 = this.cellfont;
			size = new System.Drawing.Size(122, 37);
			cellfont2.Size = size;
			this.cellfont.TabIndex = 20;
			this.cellfont.Text = "结果预览";
			this.cellfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			System.Windows.Forms.Control button31 = this.Button10;
			location = new System.Drawing.Point(129, 22);
			button31.Location = location;
			this.Button10.Name = "Button10";
			System.Windows.Forms.Control button32 = this.Button10;
			size = new System.Drawing.Size(79, 27);
			button32.Size = size;
			this.Button10.TabIndex = 19;
			this.Button10.Text = "字体及颜色";
			this.Button10.UseVisualStyleBackColor = true;
			this.Label15.AutoSize = true;
			System.Windows.Forms.Control label77 = this.Label15;
			location = new System.Drawing.Point(143, 62);
			label77.Location = location;
			this.Label15.Name = "Label15";
			System.Windows.Forms.Control label78 = this.Label15;
			size = new System.Drawing.Size(53, 12);
			label78.Size = size;
			this.Label15.TabIndex = 9;
			this.Label15.Text = "垂直对齐";
			this.Label28.AutoSize = true;
			System.Windows.Forms.Control label79 = this.Label28;
			location = new System.Drawing.Point(4, 62);
			label79.Location = location;
			this.Label28.Name = "Label28";
			System.Windows.Forms.Control label80 = this.Label28;
			size = new System.Drawing.Size(53, 12);
			label80.Size = size;
			this.Label28.TabIndex = 9;
			this.Label28.Text = "水平对齐";
			this.valg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.valg.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.valg.FormattingEnabled = true;
			this.valg.Items.AddRange(new object[]
			{
				"上对齐",
				"居中对齐",
				"下对齐"
			});
			System.Windows.Forms.Control valg = this.valg;
			location = new System.Drawing.Point(197, 59);
			valg.Location = location;
			this.valg.Name = "valg";
			System.Windows.Forms.Control valg2 = this.valg;
			size = new System.Drawing.Size(86, 20);
			valg2.Size = size;
			this.valg.TabIndex = 11;
			this.halg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.halg.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.halg.FormattingEnabled = true;
			this.halg.Items.AddRange(new object[]
			{
				"左对齐",
				"居中对齐",
				"右对齐"
			});
			System.Windows.Forms.Control halg = this.halg;
			location = new System.Drawing.Point(57, 59);
			halg.Location = location;
			this.halg.Name = "halg";
			System.Windows.Forms.Control halg2 = this.halg;
			size = new System.Drawing.Size(86, 20);
			halg2.Size = size;
			this.halg.TabIndex = 11;
			this.isprint.AutoSize = true;
			System.Windows.Forms.Control isprint = this.isprint;
			location = new System.Drawing.Point(259, 296);
			isprint.Location = location;
			this.isprint.Name = "isprint";
			System.Windows.Forms.Control isprint2 = this.isprint;
			size = new System.Drawing.Size(72, 16);
			isprint2.Size = size;
			this.isprint.TabIndex = 30;
			this.isprint.Text = "打印该列";
			this.isprint.UseVisualStyleBackColor = true;
			this.TabPage5.Controls.Add(this.GroupBox2);
			this.TabPage5.Controls.Add(this.GroupBox5);
			System.Windows.Forms.TabPage tabPage13 = this.TabPage5;
			location = new System.Drawing.Point(4, 22);
			tabPage13.Location = location;
			this.TabPage5.Name = "TabPage5";
			System.Windows.Forms.Control tabPage14 = this.TabPage5;
			padding = new System.Windows.Forms.Padding(3);
			tabPage14.Padding = padding;
			System.Windows.Forms.Control tabPage15 = this.TabPage5;
			size = new System.Drawing.Size(536, 465);
			tabPage15.Size = size;
			this.TabPage5.TabIndex = 4;
			this.TabPage5.Text = "表格尾注及表尾";
			this.TabPage5.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.reportfooterspace);
			this.GroupBox2.Controls.Add(this.Label35);
			this.GroupBox2.Controls.Add(this.reportfooterfont);
			this.GroupBox2.Controls.Add(this.reportfootertext);
			this.GroupBox2.Controls.Add(this.Label36);
			this.GroupBox2.Controls.Add(this.Label37);
			this.GroupBox2.Controls.Add(this.Label38);
			this.GroupBox2.Controls.Add(this.reportfooteralignment);
			System.Windows.Forms.Control groupBox29 = this.GroupBox2;
			location = new System.Drawing.Point(6, 272);
			groupBox29.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			System.Windows.Forms.Control groupBox30 = this.GroupBox2;
			size = new System.Drawing.Size(526, 185);
			groupBox30.Size = size;
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "报表尾";
			System.Windows.Forms.NumericUpDown reportfooterspace = this.reportfooterspace;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			reportfooterspace.Increment = num;
			System.Windows.Forms.Control reportfooterspace2 = this.reportfooterspace;
			location = new System.Drawing.Point(213, 139);
			reportfooterspace2.Location = location;
			System.Windows.Forms.NumericUpDown reportfooterspace3 = this.reportfooterspace;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			reportfooterspace3.Maximum = num;
			this.reportfooterspace.Name = "reportfooterspace";
			System.Windows.Forms.Control reportfooterspace4 = this.reportfooterspace;
			size = new System.Drawing.Size(55, 21);
			reportfooterspace4.Size = size;
			this.reportfooterspace.TabIndex = 39;
			this.reportfooterspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Label35.AutoSize = true;
			System.Windows.Forms.Control label81 = this.Label35;
			location = new System.Drawing.Point(1, 143);
			label81.Location = location;
			this.Label35.Name = "Label35";
			System.Windows.Forms.Control label82 = this.Label35;
			size = new System.Drawing.Size(221, 12);
			label82.Size = size;
			this.Label35.TabIndex = 38;
			this.Label35.Text = "表尾与表格尾部内容间的间距（毫米）：";
			System.Windows.Forms.Control reportfooterfont = this.reportfooterfont;
			location = new System.Drawing.Point(428, 138);
			reportfooterfont.Location = location;
			this.reportfooterfont.Name = "reportfooterfont";
			System.Windows.Forms.Control reportfooterfont2 = this.reportfooterfont;
			size = new System.Drawing.Size(88, 23);
			reportfooterfont2.Size = size;
			this.reportfooterfont.TabIndex = 36;
			this.reportfooterfont.Text = "字体及颜色";
			this.reportfooterfont.UseVisualStyleBackColor = true;
			this.reportfootertext.AcceptsReturn = true;
			this.reportfootertext.Font = new System.Drawing.Font("宋体", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control reportfootertext = this.reportfootertext;
			location = new System.Drawing.Point(61, 11);
			reportfootertext.Location = location;
			this.reportfootertext.Multiline = true;
			this.reportfootertext.Name = "reportfootertext";
			this.reportfootertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control reportfootertext2 = this.reportfootertext;
			size = new System.Drawing.Size(459, 120);
			reportfootertext2.Size = size;
			this.reportfootertext.TabIndex = 35;
			this.reportfootertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Label36.AutoSize = true;
			System.Windows.Forms.Control label83 = this.Label36;
			location = new System.Drawing.Point(2, 163);
			label83.Location = location;
			this.Label36.Name = "Label36";
			System.Windows.Forms.Control label84 = this.Label36;
			size = new System.Drawing.Size(245, 12);
			label84.Size = size;
			this.Label36.TabIndex = 34;
			this.Label36.Text = "注：表尾打印在报表最后，且只最后一页打印";
			this.Label37.AutoSize = true;
			System.Windows.Forms.Control label85 = this.Label37;
			location = new System.Drawing.Point(271, 143);
			label85.Location = location;
			this.Label37.Name = "Label37";
			System.Windows.Forms.Control label86 = this.Label37;
			size = new System.Drawing.Size(65, 12);
			label86.Size = size;
			this.Label37.TabIndex = 34;
			this.Label37.Text = "对齐方式：";
			this.Label38.AutoSize = true;
			System.Windows.Forms.Control label87 = this.Label38;
			location = new System.Drawing.Point(0, 66);
			label87.Location = location;
			this.Label38.Name = "Label38";
			System.Windows.Forms.Control label88 = this.Label38;
			size = new System.Drawing.Size(65, 12);
			label88.Size = size;
			this.Label38.TabIndex = 34;
			this.Label38.Text = "表尾内容：";
			this.reportfooteralignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.reportfooteralignment.FormattingEnabled = true;
			this.reportfooteralignment.Items.AddRange(new object[]
			{
				"居中对齐",
				"左对齐",
				"右对齐"
			});
			System.Windows.Forms.Control reportfooteralignment = this.reportfooteralignment;
			location = new System.Drawing.Point(336, 139);
			reportfooteralignment.Location = location;
			this.reportfooteralignment.Name = "reportfooteralignment";
			System.Windows.Forms.Control reportfooteralignment2 = this.reportfooteralignment;
			size = new System.Drawing.Size(91, 20);
			reportfooteralignment2.Size = size;
			this.reportfooteralignment.TabIndex = 33;
			this.GroupBox5.Controls.Add(this.tablefooterheight);
			this.GroupBox5.Controls.Add(this.Label11);
			this.GroupBox5.Controls.Add(this.d2);
			this.GroupBox5.Controls.Add(this.tablefooterprinteverypage);
			this.GroupBox5.Controls.Add(this.Button5);
			this.GroupBox5.Controls.Add(this.Button6);
			this.GroupBox5.Controls.Add(this.Button24);
			System.Windows.Forms.Control groupBox31 = this.GroupBox5;
			location = new System.Drawing.Point(3, 6);
			groupBox31.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			System.Windows.Forms.Control groupBox32 = this.GroupBox5;
			size = new System.Drawing.Size(529, 260);
			groupBox32.Size = size;
			this.GroupBox5.TabIndex = 37;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "表格尾注（可多行）";
			this.tablefooterheight.DecimalPlaces = 1;
			this.tablefooterheight.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control tablefooterheight = this.tablefooterheight;
			location = new System.Drawing.Point(124, 228);
			tablefooterheight.Location = location;
			System.Windows.Forms.NumericUpDown tablefooterheight2 = this.tablefooterheight;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			tablefooterheight2.Maximum = num;
			this.tablefooterheight.Name = "tablefooterheight";
			System.Windows.Forms.Control tablefooterheight3 = this.tablefooterheight;
			size = new System.Drawing.Size(72, 23);
			tablefooterheight3.Size = size;
			this.tablefooterheight.TabIndex = 30;
			System.Windows.Forms.NumericUpDown tablefooterheight4 = this.tablefooterheight;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			tablefooterheight4.Value = num;
			this.Label11.AutoSize = true;
			System.Windows.Forms.Control label89 = this.Label11;
			location = new System.Drawing.Point(5, 233);
			label89.Location = location;
			this.Label11.Name = "Label11";
			System.Windows.Forms.Control label90 = this.Label11;
			size = new System.Drawing.Size(113, 12);
			label90.Size = size;
			this.Label11.TabIndex = 29;
			this.Label11.Text = "单行高度（毫米）：";
			this.d2.AllowUserToAddRows = false;
			this.d2.AllowUserToDeleteRows = false;
			this.d2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.d2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.DataGridViewTextBoxColumn1,
				this.DataGridViewTextBoxColumn2,
				this.DataGridViewTextBoxColumn3,
				this.DataGridViewTextBoxColumn4,
				this.DataGridViewTextBoxColumn5,
				this.DataGridViewTextBoxColumn6,
				this.DataGridViewTextBoxColumn7
			});
			this.d2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			System.Windows.Forms.Control d3 = this.d2;
			location = new System.Drawing.Point(6, 20);
			d3.Location = location;
			this.d2.Name = "d2";
			this.d2.ReadOnly = true;
			this.d2.RowTemplate.Height = 23;
			this.d2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			System.Windows.Forms.Control d4 = this.d2;
			size = new System.Drawing.Size(513, 200);
			d4.Size = size;
			this.d2.TabIndex = 11;
			this.DataGridViewTextBoxColumn1.HeaderText = "打印内容";
			this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly = true;
			this.DataGridViewTextBoxColumn2.HeaderText = "打印级次";
			this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly = true;
			this.DataGridViewTextBoxColumn2.Width = 60;
			this.DataGridViewTextBoxColumn3.HeaderText = "对齐方式";
			this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly = true;
			this.DataGridViewTextBoxColumn3.Width = 60;
			this.DataGridViewTextBoxColumn4.HeaderText = "字体字号";
			this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly = true;
			this.DataGridViewTextBoxColumn4.Width = 60;
			this.DataGridViewTextBoxColumn5.HeaderText = "打印高度";
			this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly = true;
			this.DataGridViewTextBoxColumn5.Width = 60;
			this.DataGridViewTextBoxColumn6.HeaderText = "打印宽度";
			this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
			this.DataGridViewTextBoxColumn6.ReadOnly = true;
			this.DataGridViewTextBoxColumn6.Width = 60;
			this.DataGridViewTextBoxColumn7.HeaderText = "前景颜色";
			this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
			this.DataGridViewTextBoxColumn7.ReadOnly = true;
			this.DataGridViewTextBoxColumn7.Width = 60;
			this.tablefooterprinteverypage.AutoSize = true;
			this.tablefooterprinteverypage.Checked = true;
			this.tablefooterprinteverypage.CheckState = System.Windows.Forms.CheckState.Checked;
			System.Windows.Forms.Control tablefooterprinteverypage = this.tablefooterprinteverypage;
			location = new System.Drawing.Point(218, 231);
			tablefooterprinteverypage.Location = location;
			this.tablefooterprinteverypage.Name = "tablefooterprinteverypage";
			System.Windows.Forms.Control tablefooterprinteverypage2 = this.tablefooterprinteverypage;
			size = new System.Drawing.Size(96, 16);
			tablefooterprinteverypage2.Size = size;
			this.tablefooterprinteverypage.TabIndex = 14;
			this.tablefooterprinteverypage.Text = "每页都要打印";
			this.tablefooterprinteverypage.UseVisualStyleBackColor = true;
			this.Button5.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button33 = this.Button5;
			location = new System.Drawing.Point(455, 227);
			button33.Location = location;
			this.Button5.Name = "Button5";
			System.Windows.Forms.Control button34 = this.Button5;
			size = new System.Drawing.Size(62, 24);
			button34.Size = size;
			this.Button5.TabIndex = 3;
			this.Button5.Text = "修改";
			this.Button5.UseVisualStyleBackColor = true;
			this.Button6.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button35 = this.Button6;
			location = new System.Drawing.Point(388, 227);
			button35.Location = location;
			this.Button6.Name = "Button6";
			System.Windows.Forms.Control button36 = this.Button6;
			size = new System.Drawing.Size(62, 24);
			button36.Size = size;
			this.Button6.TabIndex = 3;
			this.Button6.Text = "删除";
			this.Button6.UseVisualStyleBackColor = true;
			this.Button24.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button37 = this.Button24;
			location = new System.Drawing.Point(323, 227);
			button37.Location = location;
			this.Button24.Name = "Button24";
			System.Windows.Forms.Control button38 = this.Button24;
			size = new System.Drawing.Size(62, 24);
			button38.Size = size;
			this.Button24.TabIndex = 3;
			this.Button24.Text = "增加";
			this.Button24.UseVisualStyleBackColor = true;
			this.TabPage2.Controls.Add(this.Label90);
			this.TabPage2.Controls.Add(this.Label88);
			this.TabPage2.Controls.Add(this.GroupBoxheader3);
			this.TabPage2.Controls.Add(this.GroupBoxheader2);
			this.TabPage2.Controls.Add(this.GroupBoxheader1);
			System.Windows.Forms.TabPage tabPage16 = this.TabPage2;
			location = new System.Drawing.Point(4, 22);
			tabPage16.Location = location;
			this.TabPage2.Name = "TabPage2";
			System.Windows.Forms.Control tabPage17 = this.TabPage2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage17.Padding = padding;
			System.Windows.Forms.Control tabPage18 = this.TabPage2;
			size = new System.Drawing.Size(536, 465);
			tabPage18.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "页眉页脚";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.Label90.ForeColor = System.Drawing.Color.Fuchsia;
			System.Windows.Forms.Control label91 = this.Label90;
			location = new System.Drawing.Point(5, 407);
			label91.Location = location;
			this.Label90.Name = "Label90";
			System.Windows.Forms.Control label92 = this.Label90;
			size = new System.Drawing.Size(475, 17);
			label92.Size = size;
			this.Label90.TabIndex = 10;
			this.Label90.Text = "注1：页眉页脚打印内容设置中，可用[页码] 可表示页码，[总页数] 表示总页数；";
			this.Label88.ForeColor = System.Drawing.Color.Fuchsia;
			System.Windows.Forms.Control label93 = this.Label88;
			location = new System.Drawing.Point(5, 424);
			label93.Location = location;
			this.Label88.Name = "Label88";
			System.Windows.Forms.Control label94 = this.Label88;
			size = new System.Drawing.Size(528, 29);
			label94.Size = size;
			this.Label88.TabIndex = 10;
			this.Label88.Text = "注2：页眉页脚可设置左、中、右三栏内容，每栏分别占纸张可打印宽度的1/3。如果只有其中的一栏有内容，则设置了内容的这栏打印宽度为整个页面宽度。表格页眉页脚同理。";
			this.GroupBoxheader3.Controls.Add(this.Button29);
			this.GroupBoxheader3.Controls.Add(this.rightb);
			this.GroupBoxheader3.Controls.Add(this.rightm);
			this.GroupBoxheader3.Controls.Add(this.rightt);
			this.GroupBoxheader3.Controls.Add(this.Label56);
			this.GroupBoxheader3.Controls.Add(this.Label57);
			this.GroupBoxheader3.Controls.Add(this.Label58);
			System.Windows.Forms.Control groupBoxheader = this.GroupBoxheader3;
			location = new System.Drawing.Point(8, 268);
			groupBoxheader.Location = location;
			this.GroupBoxheader3.Name = "GroupBoxheader3";
			System.Windows.Forms.Control groupBoxheader2 = this.GroupBoxheader3;
			size = new System.Drawing.Size(527, 136);
			groupBoxheader2.Size = size;
			this.GroupBoxheader3.TabIndex = 9;
			this.GroupBoxheader3.TabStop = false;
			this.GroupBoxheader3.Text = "页边距右边打印内容设置";
			System.Windows.Forms.Control button39 = this.Button29;
			location = new System.Drawing.Point(355, 109);
			button39.Location = location;
			this.Button29.Name = "Button29";
			System.Windows.Forms.Control button40 = this.Button29;
			size = new System.Drawing.Size(137, 23);
			button40.Size = size;
			this.Button29.TabIndex = 16;
			this.Button29.Text = "字体字号及颜色";
			this.Button29.UseVisualStyleBackColor = true;
			this.rightb.AcceptsReturn = true;
			System.Windows.Forms.Control rightb = this.rightb;
			location = new System.Drawing.Point(36, 78);
			rightb.Location = location;
			this.rightb.Multiline = true;
			this.rightb.Name = "rightb";
			this.rightb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control rightb2 = this.rightb;
			size = new System.Drawing.Size(483, 29);
			rightb2.Size = size;
			this.rightb.TabIndex = 15;
			this.rightb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.rightm.AcceptsReturn = true;
			System.Windows.Forms.Control rightm = this.rightm;
			location = new System.Drawing.Point(36, 47);
			rightm.Location = location;
			this.rightm.Multiline = true;
			this.rightm.Name = "rightm";
			this.rightm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control rightm2 = this.rightm;
			size = new System.Drawing.Size(483, 29);
			rightm2.Size = size;
			this.rightm.TabIndex = 14;
			this.rightm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.rightt.AcceptsReturn = true;
			System.Windows.Forms.Control rightt = this.rightt;
			location = new System.Drawing.Point(36, 17);
			rightt.Location = location;
			this.rightt.Multiline = true;
			this.rightt.Name = "rightt";
			this.rightt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control rightt2 = this.rightt;
			size = new System.Drawing.Size(483, 29);
			rightt2.Size = size;
			this.rightt.TabIndex = 13;
			this.Label56.AutoSize = true;
			System.Windows.Forms.Control label95 = this.Label56;
			location = new System.Drawing.Point(6, 25);
			label95.Location = location;
			this.Label56.Name = "Label56";
			System.Windows.Forms.Control label96 = this.Label56;
			size = new System.Drawing.Size(29, 12);
			label96.Size = size;
			this.Label56.TabIndex = 2;
			this.Label56.Text = "上边";
			this.Label57.AutoSize = true;
			System.Windows.Forms.Control label97 = this.Label57;
			location = new System.Drawing.Point(6, 55);
			label97.Location = location;
			this.Label57.Name = "Label57";
			System.Windows.Forms.Control label98 = this.Label57;
			size = new System.Drawing.Size(29, 12);
			label98.Size = size;
			this.Label57.TabIndex = 1;
			this.Label57.Text = "中间";
			this.Label58.AutoSize = true;
			System.Windows.Forms.Control label99 = this.Label58;
			location = new System.Drawing.Point(6, 86);
			label99.Location = location;
			this.Label58.Name = "Label58";
			System.Windows.Forms.Control label100 = this.Label58;
			size = new System.Drawing.Size(29, 12);
			label100.Size = size;
			this.Label58.TabIndex = 0;
			this.Label58.Text = "下边";
			this.GroupBoxheader2.Controls.Add(this.drawfooter);
			this.GroupBoxheader2.Controls.Add(this.Button7);
			this.GroupBoxheader2.Controls.Add(this.pageright);
			this.GroupBoxheader2.Controls.Add(this.pagemiddle);
			this.GroupBoxheader2.Controls.Add(this.pageleft);
			this.GroupBoxheader2.Controls.Add(this.Label17);
			this.GroupBoxheader2.Controls.Add(this.Label18);
			this.GroupBoxheader2.Controls.Add(this.Label19);
			System.Windows.Forms.Control groupBoxheader3 = this.GroupBoxheader2;
			location = new System.Drawing.Point(7, 136);
			groupBoxheader3.Location = location;
			this.GroupBoxheader2.Name = "GroupBoxheader2";
			System.Windows.Forms.Control groupBoxheader4 = this.GroupBoxheader2;
			size = new System.Drawing.Size(527, 130);
			groupBoxheader4.Size = size;
			this.GroupBoxheader2.TabIndex = 9;
			this.GroupBoxheader2.TabStop = false;
			this.GroupBoxheader2.Text = "页脚设置";
			this.drawfooter.AutoSize = true;
			System.Windows.Forms.Control drawfooter = this.drawfooter;
			location = new System.Drawing.Point(38, 108);
			drawfooter.Location = location;
			this.drawfooter.Name = "drawfooter";
			System.Windows.Forms.Control drawfooter2 = this.drawfooter;
			size = new System.Drawing.Size(192, 16);
			drawfooter2.Size = size;
			this.drawfooter.TabIndex = 10;
			this.drawfooter.Text = "在正文与页脚之间打印横线分隔";
			this.drawfooter.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button41 = this.Button7;
			location = new System.Drawing.Point(355, 104);
			button41.Location = location;
			this.Button7.Name = "Button7";
			System.Windows.Forms.Control button42 = this.Button7;
			size = new System.Drawing.Size(138, 23);
			button42.Size = size;
			this.Button7.TabIndex = 11;
			this.Button7.Text = "字体字号及颜色";
			this.Button7.UseVisualStyleBackColor = true;
			this.pageright.AcceptsReturn = true;
			System.Windows.Forms.Control pageright = this.pageright;
			location = new System.Drawing.Point(36, 73);
			pageright.Location = location;
			this.pageright.Multiline = true;
			this.pageright.Name = "pageright";
			this.pageright.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pageright2 = this.pageright;
			size = new System.Drawing.Size(483, 29);
			pageright2.Size = size;
			this.pageright.TabIndex = 9;
			this.pageright.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.pagemiddle.AcceptsReturn = true;
			System.Windows.Forms.Control pagemiddle = this.pagemiddle;
			location = new System.Drawing.Point(36, 44);
			pagemiddle.Location = location;
			this.pagemiddle.Multiline = true;
			this.pagemiddle.Name = "pagemiddle";
			this.pagemiddle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pagemiddle2 = this.pagemiddle;
			size = new System.Drawing.Size(483, 29);
			pagemiddle2.Size = size;
			this.pagemiddle.TabIndex = 8;
			this.pagemiddle.Text = "第[页码]页  共[总页数]页";
			this.pagemiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.pageleft.AcceptsReturn = true;
			System.Windows.Forms.Control pageleft = this.pageleft;
			location = new System.Drawing.Point(36, 14);
			pageleft.Location = location;
			this.pageleft.Multiline = true;
			this.pageleft.Name = "pageleft";
			this.pageleft.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pageleft2 = this.pageleft;
			size = new System.Drawing.Size(483, 29);
			pageleft2.Size = size;
			this.pageleft.TabIndex = 7;
			this.Label17.AutoSize = true;
			System.Windows.Forms.Control label101 = this.Label17;
			location = new System.Drawing.Point(6, 22);
			label101.Location = location;
			this.Label17.Name = "Label17";
			System.Windows.Forms.Control label102 = this.Label17;
			size = new System.Drawing.Size(29, 12);
			label102.Size = size;
			this.Label17.TabIndex = 2;
			this.Label17.Text = "左边";
			this.Label18.AutoSize = true;
			System.Windows.Forms.Control label103 = this.Label18;
			location = new System.Drawing.Point(6, 52);
			label103.Location = location;
			this.Label18.Name = "Label18";
			System.Windows.Forms.Control label104 = this.Label18;
			size = new System.Drawing.Size(29, 12);
			label104.Size = size;
			this.Label18.TabIndex = 1;
			this.Label18.Text = "中间";
			this.Label19.AutoSize = true;
			System.Windows.Forms.Control label105 = this.Label19;
			location = new System.Drawing.Point(6, 81);
			label105.Location = location;
			this.Label19.Name = "Label19";
			System.Windows.Forms.Control label106 = this.Label19;
			size = new System.Drawing.Size(29, 12);
			label106.Size = size;
			this.Label19.TabIndex = 0;
			this.Label19.Text = "右边";
			this.GroupBoxheader1.Controls.Add(this.drawheader);
			this.GroupBoxheader1.Controls.Add(this.Button8);
			this.GroupBoxheader1.Controls.Add(this.pager);
			this.GroupBoxheader1.Controls.Add(this.pagem);
			this.GroupBoxheader1.Controls.Add(this.pagel);
			this.GroupBoxheader1.Controls.Add(this.Label20);
			this.GroupBoxheader1.Controls.Add(this.Label21);
			this.GroupBoxheader1.Controls.Add(this.Label22);
			System.Windows.Forms.Control groupBoxheader5 = this.GroupBoxheader1;
			location = new System.Drawing.Point(6, 4);
			groupBoxheader5.Location = location;
			this.GroupBoxheader1.Name = "GroupBoxheader1";
			System.Windows.Forms.Control groupBoxheader6 = this.GroupBoxheader1;
			size = new System.Drawing.Size(527, 130);
			groupBoxheader6.Size = size;
			this.GroupBoxheader1.TabIndex = 8;
			this.GroupBoxheader1.TabStop = false;
			this.GroupBoxheader1.Text = "页眉设置";
			this.drawheader.AutoSize = true;
			System.Windows.Forms.Control drawheader = this.drawheader;
			location = new System.Drawing.Point(38, 110);
			drawheader.Location = location;
			this.drawheader.Name = "drawheader";
			System.Windows.Forms.Control drawheader2 = this.drawheader;
			size = new System.Drawing.Size(192, 16);
			drawheader2.Size = size;
			this.drawheader.TabIndex = 4;
			this.drawheader.Text = "在页眉与正文之间打印横线分隔";
			this.drawheader.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button43 = this.Button8;
			location = new System.Drawing.Point(356, 104);
			button43.Location = location;
			this.Button8.Name = "Button8";
			System.Windows.Forms.Control button44 = this.Button8;
			size = new System.Drawing.Size(138, 23);
			button44.Size = size;
			this.Button8.TabIndex = 5;
			this.Button8.Text = "字体字号及颜色";
			this.Button8.UseVisualStyleBackColor = true;
			this.pager.AcceptsReturn = true;
			System.Windows.Forms.Control pager = this.pager;
			location = new System.Drawing.Point(37, 74);
			pager.Location = location;
			this.pager.Multiline = true;
			this.pager.Name = "pager";
			this.pager.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pager2 = this.pager;
			size = new System.Drawing.Size(484, 29);
			pager2.Size = size;
			this.pager.TabIndex = 3;
			this.pager.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.pagem.AcceptsReturn = true;
			System.Windows.Forms.Control pagem = this.pagem;
			location = new System.Drawing.Point(37, 44);
			pagem.Location = location;
			this.pagem.Multiline = true;
			this.pagem.Name = "pagem";
			this.pagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pagem2 = this.pagem;
			size = new System.Drawing.Size(484, 29);
			pagem2.Size = size;
			this.pagem.TabIndex = 2;
			this.pagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.pagel.AcceptsReturn = true;
			System.Windows.Forms.Control pagel = this.pagel;
			location = new System.Drawing.Point(37, 14);
			pagel.Location = location;
			this.pagel.Multiline = true;
			this.pagel.Name = "pagel";
			this.pagel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			System.Windows.Forms.Control pagel2 = this.pagel;
			size = new System.Drawing.Size(484, 29);
			pagel2.Size = size;
			this.pagel.TabIndex = 1;
			this.Label20.AutoSize = true;
			System.Windows.Forms.Control label107 = this.Label20;
			location = new System.Drawing.Point(6, 22);
			label107.Location = location;
			this.Label20.Name = "Label20";
			System.Windows.Forms.Control label108 = this.Label20;
			size = new System.Drawing.Size(29, 12);
			label108.Size = size;
			this.Label20.TabIndex = 2;
			this.Label20.Text = "左边";
			this.Label21.AutoSize = true;
			System.Windows.Forms.Control label109 = this.Label21;
			location = new System.Drawing.Point(6, 52);
			label109.Location = location;
			this.Label21.Name = "Label21";
			System.Windows.Forms.Control label110 = this.Label21;
			size = new System.Drawing.Size(29, 12);
			label110.Size = size;
			this.Label21.TabIndex = 1;
			this.Label21.Text = "中间";
			this.Label22.AutoSize = true;
			System.Windows.Forms.Control label111 = this.Label22;
			location = new System.Drawing.Point(6, 82);
			label111.Location = location;
			this.Label22.Name = "Label22";
			System.Windows.Forms.Control label112 = this.Label22;
			size = new System.Drawing.Size(29, 12);
			label112.Size = size;
			this.Label22.TabIndex = 0;
			this.Label22.Text = "右边";
			this.TabPage7.Controls.Add(this.Label14);
			this.TabPage7.Controls.Add(this.GroupBoxZDX);
			System.Windows.Forms.TabPage tabPage19 = this.TabPage7;
			location = new System.Drawing.Point(4, 22);
			tabPage19.Location = location;
			this.TabPage7.Name = "TabPage7";
			System.Windows.Forms.Control tabPage20 = this.TabPage7;
			padding = new System.Windows.Forms.Padding(3);
			tabPage20.Padding = padding;
			System.Windows.Forms.Control tabPage21 = this.TabPage7;
			size = new System.Drawing.Size(536, 465);
			tabPage21.Size = size;
			this.TabPage7.TabIndex = 6;
			this.TabPage7.Text = "装订线及其他";
			this.TabPage7.UseVisualStyleBackColor = true;
			this.Label14.ForeColor = System.Drawing.Color.Fuchsia;
			System.Windows.Forms.Control label113 = this.Label14;
			location = new System.Drawing.Point(6, 434);
			label113.Location = location;
			this.Label14.Name = "Label14";
			System.Windows.Forms.Control label114 = this.Label14;
			size = new System.Drawing.Size(527, 28);
			label114.Size = size;
			this.Label14.TabIndex = 35;
			this.Label14.Text = "注：在设置\"表头\"、主标题、表格页眉、列标题、列内容、表格尾注、报表尾等内容时，双击文本框即可弹出文本编辑窗口，在该窗口中可以插入自定义变量、系统变量、字段变量等参数。";
			this.GroupBoxZDX.Controls.Add(this.GroupBoxzdx3);
			this.GroupBoxZDX.Controls.Add(this.GroupBoxzdx2);
			this.GroupBoxZDX.Controls.Add(this.GroupBoxzdx1);
			this.GroupBoxZDX.Controls.Add(this.isdrawzdx);
			System.Windows.Forms.Control groupBoxZDX = this.GroupBoxZDX;
			location = new System.Drawing.Point(6, 19);
			groupBoxZDX.Location = location;
			this.GroupBoxZDX.Name = "GroupBoxZDX";
			System.Windows.Forms.Control groupBoxZDX2 = this.GroupBoxZDX;
			size = new System.Drawing.Size(522, 298);
			groupBoxZDX2.Size = size;
			this.GroupBoxZDX.TabIndex = 20;
			this.GroupBoxZDX.TabStop = false;
			this.GroupBoxZDX.Text = "装订线设置";
			this.GroupBoxzdx3.Controls.Add(this.zdxlinecolor);
			this.GroupBoxzdx3.Controls.Add(this.zdx_dashdotdot);
			this.GroupBoxzdx3.Controls.Add(this.zdx_dashdot);
			this.GroupBoxzdx3.Controls.Add(this.zdx_dot);
			this.GroupBoxzdx3.Controls.Add(this.zdx_dash);
			this.GroupBoxzdx3.Controls.Add(this.zdx_solid);
			this.GroupBoxzdx3.Enabled = false;
			System.Windows.Forms.Control groupBoxzdx = this.GroupBoxzdx3;
			location = new System.Drawing.Point(12, 237);
			groupBoxzdx.Location = location;
			this.GroupBoxzdx3.Name = "GroupBoxzdx3";
			System.Windows.Forms.Control groupBoxzdx2 = this.GroupBoxzdx3;
			size = new System.Drawing.Size(504, 52);
			groupBoxzdx2.Size = size;
			this.GroupBoxzdx3.TabIndex = 21;
			this.GroupBoxzdx3.TabStop = false;
			this.GroupBoxzdx3.Text = "装订线线条设置";
			System.Windows.Forms.Control zdxlinecolor = this.zdxlinecolor;
			location = new System.Drawing.Point(410, 17);
			zdxlinecolor.Location = location;
			this.zdxlinecolor.Name = "zdxlinecolor";
			System.Windows.Forms.Control zdxlinecolor2 = this.zdxlinecolor;
			size = new System.Drawing.Size(72, 24);
			zdxlinecolor2.Size = size;
			this.zdxlinecolor.TabIndex = 18;
			this.zdxlinecolor.Text = "线条颜色";
			this.zdxlinecolor.UseVisualStyleBackColor = true;
			this.zdx_dashdotdot.AutoSize = true;
			System.Windows.Forms.Control zdx_dashdotdot = this.zdx_dashdotdot;
			location = new System.Drawing.Point(304, 21);
			zdx_dashdotdot.Location = location;
			this.zdx_dashdotdot.Name = "zdx_dashdotdot";
			System.Windows.Forms.Control zdx_dashdotdot2 = this.zdx_dashdotdot;
			size = new System.Drawing.Size(71, 16);
			zdx_dashdotdot2.Size = size;
			this.zdx_dashdotdot.TabIndex = 17;
			this.zdx_dashdotdot.Text = "划线点点";
			this.zdx_dashdotdot.UseVisualStyleBackColor = true;
			this.zdx_dashdot.AutoSize = true;
			System.Windows.Forms.Control zdx_dashdot = this.zdx_dashdot;
			location = new System.Drawing.Point(221, 21);
			zdx_dashdot.Location = location;
			this.zdx_dashdot.Name = "zdx_dashdot";
			System.Windows.Forms.Control zdx_dashdot2 = this.zdx_dashdot;
			size = new System.Drawing.Size(59, 16);
			zdx_dashdot2.Size = size;
			this.zdx_dashdot.TabIndex = 17;
			this.zdx_dashdot.Text = "划线点";
			this.zdx_dashdot.UseVisualStyleBackColor = true;
			this.zdx_dot.AutoSize = true;
			System.Windows.Forms.Control zdx_dot = this.zdx_dot;
			location = new System.Drawing.Point(162, 21);
			zdx_dot.Location = location;
			this.zdx_dot.Name = "zdx_dot";
			System.Windows.Forms.Control zdx_dot2 = this.zdx_dot;
			size = new System.Drawing.Size(35, 16);
			zdx_dot2.Size = size;
			this.zdx_dot.TabIndex = 17;
			this.zdx_dot.Text = "点";
			this.zdx_dot.UseVisualStyleBackColor = true;
			this.zdx_dash.AutoSize = true;
			this.zdx_dash.Checked = true;
			System.Windows.Forms.Control zdx_dash = this.zdx_dash;
			location = new System.Drawing.Point(79, 21);
			zdx_dash.Location = location;
			this.zdx_dash.Name = "zdx_dash";
			System.Windows.Forms.Control zdx_dash2 = this.zdx_dash;
			size = new System.Drawing.Size(59, 16);
			zdx_dash2.Size = size;
			this.zdx_dash.TabIndex = 17;
			this.zdx_dash.TabStop = true;
			this.zdx_dash.Text = "划线段";
			this.zdx_dash.UseVisualStyleBackColor = true;
			this.zdx_solid.AutoSize = true;
			System.Windows.Forms.Control zdx_solid = this.zdx_solid;
			location = new System.Drawing.Point(8, 21);
			zdx_solid.Location = location;
			this.zdx_solid.Name = "zdx_solid";
			System.Windows.Forms.Control zdx_solid2 = this.zdx_solid;
			size = new System.Drawing.Size(47, 16);
			zdx_solid2.Size = size;
			this.zdx_solid.TabIndex = 17;
			this.zdx_solid.Text = "实线";
			this.zdx_solid.UseVisualStyleBackColor = true;
			this.GroupBoxzdx2.Controls.Add(this.zdxtext);
			this.GroupBoxzdx2.Controls.Add(this.Button37);
			this.GroupBoxzdx2.Enabled = false;
			System.Windows.Forms.Control groupBoxzdx3 = this.GroupBoxzdx2;
			location = new System.Drawing.Point(12, 155);
			groupBoxzdx3.Location = location;
			this.GroupBoxzdx2.Name = "GroupBoxzdx2";
			System.Windows.Forms.Control groupBoxzdx4 = this.GroupBoxzdx2;
			size = new System.Drawing.Size(504, 74);
			groupBoxzdx4.Size = size;
			this.GroupBoxzdx2.TabIndex = 20;
			this.GroupBoxzdx2.TabStop = false;
			this.GroupBoxzdx2.Text = "装订线文本";
			this.zdxtext.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control zdxtext = this.zdxtext;
			location = new System.Drawing.Point(6, 20);
			zdxtext.Location = location;
			this.zdxtext.Multiline = true;
			this.zdxtext.Name = "zdxtext";
			System.Windows.Forms.Control zdxtext2 = this.zdxtext;
			size = new System.Drawing.Size(407, 44);
			zdxtext2.Size = size;
			this.zdxtext.TabIndex = 19;
			this.Button37.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			System.Windows.Forms.Control button45 = this.Button37;
			location = new System.Drawing.Point(419, 19);
			button45.Location = location;
			this.Button37.Name = "Button37";
			System.Windows.Forms.Control button46 = this.Button37;
			size = new System.Drawing.Size(72, 45);
			button46.Size = size;
			this.Button37.TabIndex = 17;
			this.Button37.Text = "字体字号及颜色";
			this.Button37.UseVisualStyleBackColor = true;
			this.GroupBoxzdx1.Controls.Add(this.zdxposition);
			this.GroupBoxzdx1.Controls.Add(this.zdxtype_bottom);
			this.GroupBoxzdx1.Controls.Add(this.zdxtype_right);
			this.GroupBoxzdx1.Controls.Add(this.zdxtype_top);
			this.GroupBoxzdx1.Controls.Add(this.zdxtype_left);
			this.GroupBoxzdx1.Controls.Add(this.Label83);
			this.GroupBoxzdx1.Enabled = false;
			System.Windows.Forms.Control groupBoxzdx5 = this.GroupBoxzdx1;
			location = new System.Drawing.Point(12, 58);
			groupBoxzdx5.Location = location;
			this.GroupBoxzdx1.Name = "GroupBoxzdx1";
			System.Windows.Forms.Control groupBoxzdx6 = this.GroupBoxzdx1;
			size = new System.Drawing.Size(504, 91);
			groupBoxzdx6.Size = size;
			this.GroupBoxzdx1.TabIndex = 19;
			this.GroupBoxzdx1.TabStop = false;
			this.GroupBoxzdx1.Text = "装订位置";
			this.zdxposition.DecimalPlaces = 2;
			System.Windows.Forms.Control zdxposition = this.zdxposition;
			location = new System.Drawing.Point(379, 53);
			zdxposition.Location = location;
			System.Windows.Forms.NumericUpDown zdxposition2 = this.zdxposition;
			num = new decimal(new int[]
			{
				15000,
				0,
				0,
				0
			});
			zdxposition2.Maximum = num;
			this.zdxposition.Name = "zdxposition";
			System.Windows.Forms.Control zdxposition3 = this.zdxposition;
			size = new System.Drawing.Size(112, 21);
			zdxposition3.Size = size;
			this.zdxposition.TabIndex = 19;
			this.zdxposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.zdxtype_bottom.AutoSize = true;
			System.Windows.Forms.Control zdxtype_bottom = this.zdxtype_bottom;
			location = new System.Drawing.Point(415, 23);
			zdxtype_bottom.Location = location;
			this.zdxtype_bottom.Name = "zdxtype_bottom";
			System.Windows.Forms.Control zdxtype_bottom2 = this.zdxtype_bottom;
			size = new System.Drawing.Size(83, 16);
			zdxtype_bottom2.Size = size;
			this.zdxtype_bottom.TabIndex = 17;
			this.zdxtype_bottom.Text = "靠下边装订";
			this.zdxtype_bottom.UseVisualStyleBackColor = true;
			this.zdxtype_right.AutoSize = true;
			System.Windows.Forms.Control zdxtype_right = this.zdxtype_right;
			location = new System.Drawing.Point(283, 23);
			zdxtype_right.Location = location;
			this.zdxtype_right.Name = "zdxtype_right";
			System.Windows.Forms.Control zdxtype_right2 = this.zdxtype_right;
			size = new System.Drawing.Size(83, 16);
			zdxtype_right2.Size = size;
			this.zdxtype_right.TabIndex = 17;
			this.zdxtype_right.Text = "靠右边装订";
			this.zdxtype_right.UseVisualStyleBackColor = true;
			this.zdxtype_top.AutoSize = true;
			System.Windows.Forms.Control zdxtype_top = this.zdxtype_top;
			location = new System.Drawing.Point(151, 23);
			zdxtype_top.Location = location;
			this.zdxtype_top.Name = "zdxtype_top";
			System.Windows.Forms.Control zdxtype_top2 = this.zdxtype_top;
			size = new System.Drawing.Size(83, 16);
			zdxtype_top2.Size = size;
			this.zdxtype_top.TabIndex = 17;
			this.zdxtype_top.Text = "靠上边装订";
			this.zdxtype_top.UseVisualStyleBackColor = true;
			this.zdxtype_left.AutoSize = true;
			this.zdxtype_left.Checked = true;
			System.Windows.Forms.Control zdxtype_left = this.zdxtype_left;
			location = new System.Drawing.Point(19, 23);
			zdxtype_left.Location = location;
			this.zdxtype_left.Name = "zdxtype_left";
			System.Windows.Forms.Control zdxtype_left2 = this.zdxtype_left;
			size = new System.Drawing.Size(83, 16);
			zdxtype_left2.Size = size;
			this.zdxtype_left.TabIndex = 17;
			this.zdxtype_left.TabStop = true;
			this.zdxtype_left.Text = "靠左边装订";
			this.zdxtype_left.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label115 = this.Label83;
			location = new System.Drawing.Point(17, 53);
			label115.Location = location;
			this.Label83.Name = "Label83";
			System.Windows.Forms.Control label116 = this.Label83;
			size = new System.Drawing.Size(356, 24);
			label116.Size = size;
			this.Label83.TabIndex = 15;
			this.Label83.Text = "装订线距纸张边界的距离（以毫米为单位，为0表示打印在页边距的正中间）";
			this.isdrawzdx.AutoSize = true;
			System.Windows.Forms.Control isdrawzdx = this.isdrawzdx;
			location = new System.Drawing.Point(15, 23);
			isdrawzdx.Location = location;
			this.isdrawzdx.Name = "isdrawzdx";
			System.Windows.Forms.Control isdrawzdx2 = this.isdrawzdx;
			size = new System.Drawing.Size(96, 16);
			isdrawzdx2.Size = size;
			this.isdrawzdx.TabIndex = 16;
			this.isdrawzdx.Text = "要打印装订线";
			this.isdrawzdx.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button47 = this.Button20;
			location = new System.Drawing.Point(269, 1);
			button47.Location = location;
			this.Button20.Name = "Button20";
			System.Windows.Forms.Control button48 = this.Button20;
			size = new System.Drawing.Size(75, 23);
			button48.Size = size;
			this.Button20.TabIndex = 1;
			this.Button20.Text = "取消";
			this.Button20.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button49 = this.Button17;
			location = new System.Drawing.Point(142, 1);
			button49.Location = location;
			this.Button17.Name = "Button17";
			System.Windows.Forms.Control button50 = this.Button17;
			size = new System.Drawing.Size(75, 23);
			button50.Size = size;
			this.Button17.TabIndex = 0;
			this.Button17.Text = "确定";
			this.Button17.UseVisualStyleBackColor = true;
			this.SaveFileDialog1.Filter = "txt文件|*.txt";
			this.SaveFileDialog1.InitialDirectory = "D:";
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(544, 522);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.SplitContainer1);
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.Name = "SimpleReportSet";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "打印参数设置";
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.TabControl1.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			this.GroupBoxpaper.ResumeLayout(false);
			this.GroupBox24.ResumeLayout(false);
			this.GroupBox24.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.myh).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myw).EndInit();
			this.GroupBox14.ResumeLayout(false);
			this.GroupBox14.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.pagemarginr).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pagemarginl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pagemarginb).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pagemargint).EndInit();
			this.GroupBoxwater.ResumeLayout(false);
			this.GroupBoxwater.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.sytm).EndInit();
			this.TabPage8.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.reportheaderspace).EndInit();
			this.GroupBoxtitle1.ResumeLayout(false);
			this.GroupBoxtitle1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.maintitleheight).EndInit();
			this.GroupBoxtitle2.ResumeLayout(false);
			this.GroupBoxtitle2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.subtitleheight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.d1).EndInit();
			this.TabPage1.ResumeLayout(false);
			this.GroupBox31.ResumeLayout(false);
			this.GroupBox31.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.fieldheight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.rowheight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.linewidth).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.cbottom).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ctop).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cright).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cleft).EndInit();
			this.GroupBox17.ResumeLayout(false);
			this.GroupBox17.PerformLayout();
			this.GroupBoxtablestyle.ResumeLayout(false);
			this.GroupBoxtablestyle.PerformLayout();
			this.fl.ResumeLayout(false);
			this.fl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.ljj).EndInit();
			this.pt.ResumeLayout(false);
			this.pt.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.fixedrows).EndInit();
			this.fy.ResumeLayout(false);
			this.fy.PerformLayout();
			this.gz.ResumeLayout(false);
			this.gz.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.gzjj).EndInit();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.colwidth).EndInit();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox10.ResumeLayout(false);
			this.GroupBox13.ResumeLayout(false);
			this.GroupBoxformat.ResumeLayout(false);
			this.GroupBoxformat.PerformLayout();
			this.GroupBox11.ResumeLayout(false);
			this.GroupBox11.PerformLayout();
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			this.GroupBoxxx2.ResumeLayout(false);
			this.GroupBoxxx3.ResumeLayout(false);
			this.GroupBoxxx3.PerformLayout();
			this.TabPage5.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.reportfooterspace).EndInit();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.tablefooterheight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.d2).EndInit();
			this.TabPage2.ResumeLayout(false);
			this.GroupBoxheader3.ResumeLayout(false);
			this.GroupBoxheader3.PerformLayout();
			this.GroupBoxheader2.ResumeLayout(false);
			this.GroupBoxheader2.PerformLayout();
			this.GroupBoxheader1.ResumeLayout(false);
			this.GroupBoxheader1.PerformLayout();
			this.TabPage7.ResumeLayout(false);
			this.GroupBoxZDX.ResumeLayout(false);
			this.GroupBoxZDX.PerformLayout();
			this.GroupBoxzdx3.ResumeLayout(false);
			this.GroupBoxzdx3.PerformLayout();
			this.GroupBoxzdx2.ResumeLayout(false);
			this.GroupBoxzdx2.PerformLayout();
			this.GroupBoxzdx1.ResumeLayout(false);
			this.GroupBoxzdx1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.zdxposition).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000789 RID: 1929
		private System.ComponentModel.IContainer components;

		// Token: 0x04000882 RID: 2178
		private ParaseTag CurCol;
	}
}
