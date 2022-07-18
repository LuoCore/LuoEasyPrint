using System.ComponentModel;
using System.Drawing.Printing;

namespace LuoEasyPrint
{
    partial class DotNetPrint
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            if (this.myZDXfont != null)
            {
                this.myZDXfont.Dispose();
            }
            if (this.myfont != null)
            {
                this.myfont.Dispose();
            }
            if (this.mywatermarkfont != null)
            {
                this.mywatermarkfont.Dispose();
            }
            base.Dispose(disposing);
           
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pd = new System.Drawing.Printing.PrintDocument();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.myms = new System.Windows.Forms.DataGridView();
            this.mydgv2 = new System.Windows.Forms.DataGridView();
            this.tempdgv = new System.Windows.Forms.DataGridView();
            this.BeforePreviewD = new System.Drawing.Printing.PrintDocument();
            this.pagesetup = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.myopen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mybl = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem0 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
            this.mycolsperpage = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
            this.myshowtype = new System.Windows.Forms.ToolStripDropDownButton();
            this.mytype1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mytype2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cpage = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mystatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fpage = new System.Windows.Forms.ToolStripButton();
            this.ppage = new System.Windows.Forms.ToolStripButton();
            this.npage = new System.Windows.Forms.ToolStripButton();
            this.lpage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zdybutton = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printd = new System.Windows.Forms.ToolStripSplitButton();
            this.dy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dy3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.dy4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dy5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.cgprint = new System.Windows.Forms.ToolStripMenuItem();
            this.mysave = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.savepdf = new System.Windows.Forms.ToolStripSeparator();
            this.saveaspdfcur = new System.Windows.Forms.ToolStripMenuItem();
            this.saveaspdfall = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZDYButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PrintPreviewControl1 = new LuoEasyPrint.PrintPreviewControl();
            this.ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdgv)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pd
            // 
            this.Pd.DocumentName = "VB2008打印控件";
            // 
            // PageSetupDialog1
            // 
            this.PageSetupDialog1.Document = this.Pd;
            this.PageSetupDialog1.EnableMetric = true;
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.AllowSomePages = true;
            this.PrintDialog1.Document = this.Pd;
            this.PrintDialog1.ShowNetwork = false;
            this.PrintDialog1.UseEXDialog = true;
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "报表文件(*.you)|*.you";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "报表文件(*.you)|*.you";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_0,
            this.ToolStripMenuItem_5,
            this.ToolStripMenuItem_1,
            this.ToolStripMenuItem13,
            this.ToolStripMenuItem_2,
            this.ToolStripMenuItem14,
            this.ToolStripMenuItem_3,
            this.ToolStripMenuItem_4,
            this.ToolStripMenuItem12,
            this.ToolStripMenuItem_6});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(161, 176);
            // 
            // ToolStripMenuItem_0
            // 
            this.ToolStripMenuItem_0.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.ToolStripMenuItem_0.Name = "ToolStripMenuItem_0";
            this.ToolStripMenuItem_0.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_0.Text = "打印全部页";
            // 
            // ToolStripMenuItem_5
            // 
            this.ToolStripMenuItem_5.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.ToolStripMenuItem_5.Name = "ToolStripMenuItem_5";
            this.ToolStripMenuItem_5.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_5.Text = "打印当前页";
            // 
            // ToolStripMenuItem_1
            // 
            this.ToolStripMenuItem_1.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.ToolStripMenuItem_1.Name = "ToolStripMenuItem_1";
            this.ToolStripMenuItem_1.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_1.Text = "打印……";
            this.ToolStripMenuItem_1.ToolTipText = "选择打印机和打印范围打印";
            // 
            // ToolStripMenuItem13
            // 
            this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
            this.ToolStripMenuItem13.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItem_2
            // 
            this.ToolStripMenuItem_2.Image = global::LuoEasyPrint.Properties.Resources.page1;
            this.ToolStripMenuItem_2.Name = "ToolStripMenuItem_2";
            this.ToolStripMenuItem_2.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_2.Text = "页面设置";
            // 
            // ToolStripMenuItem14
            // 
            this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
            this.ToolStripMenuItem14.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItem_3
            // 
            this.ToolStripMenuItem_3.Image = global::LuoEasyPrint.Properties.Resources.save;
            this.ToolStripMenuItem_3.Name = "ToolStripMenuItem_3";
            this.ToolStripMenuItem_3.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_3.Text = "保存为报表文件";
            // 
            // ToolStripMenuItem_4
            // 
            this.ToolStripMenuItem_4.Image = global::LuoEasyPrint.Properties.Resources.foldopen;
            this.ToolStripMenuItem_4.Name = "ToolStripMenuItem_4";
            this.ToolStripMenuItem_4.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_4.Text = "打开报表文件";
            // 
            // ToolStripMenuItem12
            // 
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            this.ToolStripMenuItem12.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItem_6
            // 
            this.ToolStripMenuItem_6.Name = "ToolStripMenuItem_6";
            this.ToolStripMenuItem_6.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_6.Text = "关于";
            this.ToolStripMenuItem_6.Visible = false;
            // 
            // myms
            // 
            this.myms.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myms.DefaultCellStyle = dataGridViewCellStyle2;
            this.myms.Location = new System.Drawing.Point(120, 132);
            this.myms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myms.Name = "myms";
            this.myms.Size = new System.Drawing.Size(280, 212);
            this.myms.TabIndex = 3;
            // 
            // mydgv2
            // 
            this.mydgv2.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mydgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mydgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mydgv2.DefaultCellStyle = dataGridViewCellStyle4;
            this.mydgv2.Location = new System.Drawing.Point(625, 104);
            this.mydgv2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mydgv2.Name = "mydgv2";
            this.mydgv2.Size = new System.Drawing.Size(188, 249);
            this.mydgv2.TabIndex = 4;
            // 
            // tempdgv
            // 
            this.tempdgv.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tempdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tempdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tempdgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.tempdgv.Location = new System.Drawing.Point(120, 132);
            this.tempdgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempdgv.Name = "tempdgv";
            this.tempdgv.Size = new System.Drawing.Size(280, 212);
            this.tempdgv.TabIndex = 5;
            // 
            // pagesetup
            // 
            this.pagesetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagesetup.Name = "pagesetup";
            this.pagesetup.Size = new System.Drawing.Size(53, 22);
            this.pagesetup.Text = "页面(&U)";
            this.pagesetup.ToolTipText = "显示页面设置对话框";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // myopen
            // 
            this.myopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.myopen.Name = "myopen";
            this.myopen.Size = new System.Drawing.Size(54, 22);
            this.myopen.Text = "打开(&O)";
            this.myopen.ToolTipText = "打开报表文件";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mybl
            // 
            this.mybl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mybl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem11,
            this.ToolStripMenuItem,
            this.ToolStripMenuItem0,
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6,
            this.ToolStripMenuItem7,
            this.ToolStripMenuItem8,
            this.ToolStripMenuItem9,
            this.ToolStripMenuItem10,
            this.ToolStripSeparator4,
            this.ToolStripMenuItem_16});
            this.mybl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mybl.Name = "mybl";
            this.mybl.Size = new System.Drawing.Size(45, 22);
            this.mybl.Text = "比例";
            this.mybl.ToolTipText = "设置打印预览显示比例";
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            this.ToolStripMenuItem11.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem11.Text = "10%";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem.Text = "25%";
            // 
            // ToolStripMenuItem0
            // 
            this.ToolStripMenuItem0.Name = "ToolStripMenuItem0";
            this.ToolStripMenuItem0.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem0.Text = "50%";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem1.Text = "75%";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Checked = true;
            this.ToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem2.Text = "100%";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem3.Text = "125%";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem4.Text = "150%";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem5.Text = "200%";
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem6.Text = "250%";
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem7.Text = "300%";
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem8.Text = "400%";
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem9.Text = "500%";
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem10.Text = "自适应";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // ToolStripMenuItem_16
            // 
            this.ToolStripMenuItem_16.Name = "ToolStripMenuItem_16";
            this.ToolStripMenuItem_16.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem_16.Text = "设置打印缩放比例";
            // 
            // mycolsperpage
            // 
            this.mycolsperpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mycolsperpage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_7,
            this.ToolStripMenuItem_8,
            this.ToolStripMenuItem_9,
            this.ToolStripMenuItem_10,
            this.ToolStripMenuItem_11,
            this.ToolStripMenuItem_12,
            this.ToolStripMenuItem_13,
            this.ToolStripMenuItem_14});
            this.mycolsperpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mycolsperpage.Name = "mycolsperpage";
            this.mycolsperpage.Size = new System.Drawing.Size(69, 22);
            this.mycolsperpage.Text = "横向页数";
            this.mycolsperpage.ToolTipText = "横向显示的页数";
            // 
            // ToolStripMenuItem_7
            // 
            this.ToolStripMenuItem_7.Checked = true;
            this.ToolStripMenuItem_7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_7.Name = "ToolStripMenuItem_7";
            this.ToolStripMenuItem_7.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_7.Text = "1页";
            // 
            // ToolStripMenuItem_8
            // 
            this.ToolStripMenuItem_8.Name = "ToolStripMenuItem_8";
            this.ToolStripMenuItem_8.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_8.Text = "2页";
            // 
            // ToolStripMenuItem_9
            // 
            this.ToolStripMenuItem_9.Name = "ToolStripMenuItem_9";
            this.ToolStripMenuItem_9.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_9.Text = "3页";
            // 
            // ToolStripMenuItem_10
            // 
            this.ToolStripMenuItem_10.Name = "ToolStripMenuItem_10";
            this.ToolStripMenuItem_10.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_10.Text = "4页";
            // 
            // ToolStripMenuItem_11
            // 
            this.ToolStripMenuItem_11.Name = "ToolStripMenuItem_11";
            this.ToolStripMenuItem_11.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_11.Text = "5页";
            // 
            // ToolStripMenuItem_12
            // 
            this.ToolStripMenuItem_12.Name = "ToolStripMenuItem_12";
            this.ToolStripMenuItem_12.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_12.Text = "6页";
            // 
            // ToolStripMenuItem_13
            // 
            this.ToolStripMenuItem_13.Name = "ToolStripMenuItem_13";
            this.ToolStripMenuItem_13.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_13.Text = "8页";
            // 
            // ToolStripMenuItem_14
            // 
            this.ToolStripMenuItem_14.Name = "ToolStripMenuItem_14";
            this.ToolStripMenuItem_14.Size = new System.Drawing.Size(102, 22);
            this.ToolStripMenuItem_14.Text = "10页";
            // 
            // myshowtype
            // 
            this.myshowtype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.myshowtype.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mytype1,
            this.mytype2});
            this.myshowtype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.myshowtype.Name = "myshowtype";
            this.myshowtype.Size = new System.Drawing.Size(45, 22);
            this.myshowtype.Text = "显示";
            this.myshowtype.ToolTipText = "打印预览显示方式";
            // 
            // mytype1
            // 
            this.mytype1.Name = "mytype1";
            this.mytype1.Size = new System.Drawing.Size(124, 22);
            this.mytype1.Text = "连续显示";
            // 
            // mytype2
            // 
            this.mytype2.Checked = true;
            this.mytype2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mytype2.Name = "mytype2";
            this.mytype2.Size = new System.Drawing.Size(124, 22);
            this.mytype2.Text = "单页显示";
            // 
            // cpage
            // 
            this.cpage.DropDownHeight = 180;
            this.cpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpage.DropDownWidth = 75;
            this.cpage.Enabled = false;
            this.cpage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpage.IntegralHeight = false;
            this.cpage.Name = "cpage";
            this.cpage.Size = new System.Drawing.Size(161, 25);
            this.cpage.ToolTipText = "选择要在当前页面中显示的页码(在显示方式为<连续显示>下不可用";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mystatus
            // 
            this.mystatus.BackColor = System.Drawing.Color.Blue;
            this.mystatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mystatus.ForeColor = System.Drawing.Color.Red;
            this.mystatus.Name = "mystatus";
            this.mystatus.Size = new System.Drawing.Size(63, 22);
            this.mystatus.Text = "共【0】页";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // fpage
            // 
            this.fpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fpage.Enabled = false;
            this.fpage.Image = global::LuoEasyPrint.Properties.Resources.fFirst;
            this.fpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fpage.Name = "fpage";
            this.fpage.Size = new System.Drawing.Size(23, 22);
            this.fpage.Text = "第一页";
            // 
            // ppage
            // 
            this.ppage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ppage.Enabled = false;
            this.ppage.Image = global::LuoEasyPrint.Properties.Resources.pPrev;
            this.ppage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ppage.Name = "ppage";
            this.ppage.Size = new System.Drawing.Size(23, 22);
            this.ppage.Text = "上一页";
            // 
            // npage
            // 
            this.npage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.npage.Enabled = false;
            this.npage.Image = global::LuoEasyPrint.Properties.Resources.pnNext;
            this.npage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.npage.Name = "npage";
            this.npage.Size = new System.Drawing.Size(23, 22);
            this.npage.Text = "下一页";
            // 
            // lpage
            // 
            this.lpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lpage.Enabled = false;
            this.lpage.Image = global::LuoEasyPrint.Properties.Resources.lLast;
            this.lpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lpage.Name = "lpage";
            this.lpage.Size = new System.Drawing.Size(23, 22);
            this.lpage.Text = "最后一页";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // zdybutton
            // 
            this.zdybutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zdybutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zdybutton.Name = "zdybutton";
            this.zdybutton.Size = new System.Drawing.Size(23, 4);
            this.zdybutton.Visible = false;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagesetup,
            this.printd,
            this.ToolStripSeparator2,
            this.mysave,
            this.myopen,
            this.ToolStripSeparator3,
            this.mybl,
            this.mycolsperpage,
            this.myshowtype,
            this.cpage,
            this.ToolStripSeparator1,
            this.mystatus,
            this.ToolStripSeparator6,
            this.fpage,
            this.ppage,
            this.npage,
            this.lpage,
            this.ToolStripSeparator5,
            this.zdybutton,
            this.ZDYButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(986, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // printd
            // 
            this.printd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dy1,
            this.dy2,
            this.dy3,
            this.ToolStripMenuItem17,
            this.dy4,
            this.dy5,
            this.ToolStripMenuItem16,
            this.cgprint});
            this.printd.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.printd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printd.Name = "printd";
            this.printd.Size = new System.Drawing.Size(79, 22);
            this.printd.Text = "打印(&P)";
            this.printd.ToolTipText = "显示打印对话框，选择打印机进行打印输出。";
            // 
            // dy1
            // 
            this.dy1.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.dy1.Name = "dy1";
            this.dy1.Size = new System.Drawing.Size(184, 22);
            this.dy1.Text = "打印……";
            this.dy1.ToolTipText = "打印前选择打印机、打印范围、打印份数等选项";
            // 
            // dy2
            // 
            this.dy2.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.dy2.Name = "dy2";
            this.dy2.Size = new System.Drawing.Size(184, 22);
            this.dy2.Text = "快速打印全部页";
            // 
            // dy3
            // 
            this.dy3.Image = global::LuoEasyPrint.Properties.Resources.printer1;
            this.dy3.Name = "dy3";
            this.dy3.Size = new System.Drawing.Size(184, 22);
            this.dy3.Text = "快速打印当前页";
            // 
            // ToolStripMenuItem17
            // 
            this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
            this.ToolStripMenuItem17.Size = new System.Drawing.Size(181, 6);
            // 
            // dy4
            // 
            this.dy4.Name = "dy4";
            this.dy4.Size = new System.Drawing.Size(184, 22);
            this.dy4.Text = "手动双面打印……";
            // 
            // dy5
            // 
            this.dy5.Name = "dy5";
            this.dy5.Size = new System.Drawing.Size(184, 22);
            this.dy5.Text = "手动双面打印全部页";
            // 
            // ToolStripMenuItem16
            // 
            this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
            this.ToolStripMenuItem16.Size = new System.Drawing.Size(181, 6);
            // 
            // cgprint
            // 
            this.cgprint.Name = "cgprint";
            this.cgprint.Size = new System.Drawing.Size(184, 22);
            this.cgprint.Text = "草稿打印……";
            // 
            // mysave
            // 
            this.mysave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem15,
            this.ToolStripMenuItem_15,
            this.savepdf,
            this.saveaspdfcur,
            this.saveaspdfall,
            this.ToolStripSeparator7,
            this.ToolStripMenuItem_17,
            this.ToolStripMenuItem_18});
            this.mysave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mysave.Name = "mysave";
            this.mysave.Size = new System.Drawing.Size(63, 22);
            this.mysave.Text = "保存(&S)";
            this.mysave.ToolTipText = "保存为文件";
            // 
            // ToolStripMenuItem15
            // 
            this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
            this.ToolStripMenuItem15.Size = new System.Drawing.Size(230, 22);
            this.ToolStripMenuItem15.Text = "保存";
            this.ToolStripMenuItem15.ToolTipText = "保存为报表文件";
            // 
            // ToolStripMenuItem_15
            // 
            this.ToolStripMenuItem_15.Name = "ToolStripMenuItem_15";
            this.ToolStripMenuItem_15.Size = new System.Drawing.Size(230, 22);
            this.ToolStripMenuItem_15.Text = "加密保存";
            this.ToolStripMenuItem_15.ToolTipText = "保存为报表文件并设置密码";
            // 
            // savepdf
            // 
            this.savepdf.Name = "savepdf";
            this.savepdf.Size = new System.Drawing.Size(227, 6);
            // 
            // saveaspdfcur
            // 
            this.saveaspdfcur.Name = "saveaspdfcur";
            this.saveaspdfcur.Size = new System.Drawing.Size(230, 22);
            this.saveaspdfcur.Text = "保存为PDF文件（仅当前页）";
            // 
            // saveaspdfall
            // 
            this.saveaspdfall.Name = "saveaspdfall";
            this.saveaspdfall.Size = new System.Drawing.Size(230, 22);
            this.saveaspdfall.Text = "保存为PDF文件（全部页）";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(227, 6);
            // 
            // ToolStripMenuItem_17
            // 
            this.ToolStripMenuItem_17.Name = "ToolStripMenuItem_17";
            this.ToolStripMenuItem_17.Size = new System.Drawing.Size(230, 22);
            this.ToolStripMenuItem_17.Text = "保存为图像（仅当前页）";
            this.ToolStripMenuItem_17.ToolTipText = "将当前页保存为图像文件";
            // 
            // ToolStripMenuItem_18
            // 
            this.ToolStripMenuItem_18.Name = "ToolStripMenuItem_18";
            this.ToolStripMenuItem_18.Size = new System.Drawing.Size(230, 22);
            this.ToolStripMenuItem_18.Text = "保存为图像（全部页）";
            this.ToolStripMenuItem_18.ToolTipText = "将整个打印预览结果保存为图像";
            // 
            // ZDYButton2
            // 
            this.ZDYButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ZDYButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZDYButton2.Name = "ZDYButton2";
            this.ZDYButton2.Size = new System.Drawing.Size(23, 4);
            this.ZDYButton2.Visible = false;
            // 
            // PrintPreviewControl1
            // 
            this.PrintPreviewControl1.AutoZoom = false;
            this.PrintPreviewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PrintPreviewControl1.Columns = 1;
            this.PrintPreviewControl1.ContextMenuStrip = this.ContextMenuStrip1;
            this.PrintPreviewControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintPreviewControl1.Document = this.Pd;
            this.PrintPreviewControl1.ForeColor = System.Drawing.Color.White;
            this.PrintPreviewControl1.IsShowprocessDialog = true;
            this.PrintPreviewControl1.Location = new System.Drawing.Point(0, 25);
            this.PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintPreviewControl1.Name = "PrintPreviewControl1";
            this.PrintPreviewControl1.Rows = 1;
            this.PrintPreviewControl1.Size = new System.Drawing.Size(986, 455);
            this.PrintPreviewControl1.StartPage = 0;
            this.PrintPreviewControl1.TabIndex = 2;
            this.PrintPreviewControl1.UseAntiAlias = true;
            this.PrintPreviewControl1.Zoom = 1D;
            // 
            // DotNetPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tempdgv);
            this.Controls.Add(this.mydgv2);
            this.Controls.Add(this.myms);
            this.Controls.Add(this.PrintPreviewControl1);
            this.Controls.Add(this.ToolStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DotNetPrint";
            this.Size = new System.Drawing.Size(986, 480);
            this.ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdgv)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Font myZDXfont;
		private Font mywatermarkfont;
		private Font myfont;
		private PrintDocument Pd;
		private PageSetupDialog PageSetupDialog1;
		private PrintDialog PrintDialog1;
		private SaveFileDialog SaveFileDialog1;
		private OpenFileDialog OpenFileDialog1;
		private PrintPreviewControl PrintPreviewControl1;
		private ColorDialog ColorDialog1;
		private DataGridView myms;
		private DataGridView mydgv2;
		private DataGridView tempdgv;
		private PrintDocument BeforePreviewD;
		private ContextMenuStrip ContextMenuStrip1;
		private ToolStripMenuItem ToolStripMenuItem_0;
		private ToolStripMenuItem ToolStripMenuItem_1;
		private ToolStripMenuItem ToolStripMenuItem_2;
		private ToolStripMenuItem ToolStripMenuItem_3;
		private ToolStripMenuItem ToolStripMenuItem_4;
		private ToolStripMenuItem ToolStripMenuItem_5;
		private ToolStripSeparator ToolStripMenuItem13;
		private ToolStripSeparator ToolStripMenuItem14;
		private ToolStripSeparator ToolStripMenuItem12;
		private ToolStripMenuItem ToolStripMenuItem_6;
		private ToolStripButton pagesetup;
		private ToolStripSeparator ToolStripSeparator2;
		private ToolStripButton myopen;
		private ToolStripSeparator ToolStripSeparator3;
		private ToolStripDropDownButton mybl;
		private ToolStripMenuItem ToolStripMenuItem11;
		private ToolStripMenuItem ToolStripMenuItem;
		private ToolStripMenuItem ToolStripMenuItem0;
		private ToolStripMenuItem ToolStripMenuItem1;
		private ToolStripMenuItem ToolStripMenuItem2;
		private ToolStripMenuItem ToolStripMenuItem3;
		private ToolStripMenuItem ToolStripMenuItem4;
		private ToolStripMenuItem ToolStripMenuItem5;
		private ToolStripMenuItem ToolStripMenuItem6;
		private ToolStripMenuItem ToolStripMenuItem7;
		private ToolStripMenuItem ToolStripMenuItem8;
		private ToolStripMenuItem ToolStripMenuItem9;
		private ToolStripMenuItem ToolStripMenuItem10;
		private ToolStripDropDownButton mycolsperpage;
		private ToolStripMenuItem ToolStripMenuItem_7;
		private ToolStripMenuItem ToolStripMenuItem_8;
		private ToolStripMenuItem ToolStripMenuItem_9;
		private ToolStripMenuItem ToolStripMenuItem_10;
		private ToolStripMenuItem ToolStripMenuItem_11;
		private ToolStripMenuItem ToolStripMenuItem_12;
		private ToolStripMenuItem ToolStripMenuItem_13;
		private ToolStripMenuItem ToolStripMenuItem_14;
		private ToolStripDropDownButton myshowtype;
		private ToolStripMenuItem mytype1;
		private ToolStripMenuItem mytype2;
		private ToolStripComboBox cpage;
		private ToolStripSeparator ToolStripSeparator1;
		private ToolStripLabel mystatus;
		private ToolStripSeparator ToolStripSeparator6;
		private ToolStripButton fpage;
		private ToolStripButton ppage;
		private ToolStripButton npage;
		private ToolStripButton lpage;
		private ToolStripSeparator ToolStripSeparator5;
		private ToolStripButton zdybutton;
		private ToolStripButton ToolStripButton1;
		private ToolStrip ToolStrip1;
		private ToolTip ToolTip1;
		private ToolStripButton ZDYButton2;
		private ToolStripSplitButton printd;
		private ToolStripMenuItem dy1;
		private ToolStripMenuItem dy2;
		private ToolStripMenuItem dy3;
		private ToolStripSplitButton mysave;
		private ToolStripMenuItem ToolStripMenuItem_15;
		private ToolStripMenuItem ToolStripMenuItem15;
		private ToolStripMenuItem ToolStripMenuItem_16;
		private ToolStripSeparator ToolStripSeparator4;
		private ToolStripSeparator ToolStripMenuItem17;
		private ToolStripMenuItem dy5;
		private ToolStripMenuItem dy4;
		private ToolStripSeparator savepdf;
		private ToolStripMenuItem ToolStripMenuItem_17;
		private ToolStripMenuItem ToolStripMenuItem_18;
		private ToolStripMenuItem saveaspdfcur;
		private ToolStripMenuItem saveaspdfall;
		private ToolStripSeparator ToolStripSeparator7;
		private ToolStripSeparator ToolStripMenuItem16;
		private ToolStripMenuItem cgprint;
	}
}
