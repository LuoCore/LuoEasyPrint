using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LuoEasyPrint.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

using ZXing;
using ZXing.Common;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using Rectangle = System.Drawing.Rectangle;

namespace LuoEasyPrint
{
	// Token: 0x0200008F RID: 143
	[Guid("EAD2E038-320D-4228-9BB5-17E61F549497")]
	[DesignerGenerated]
	[ToolboxBitmap(typeof(VB2008Print), "PRINT.BMP")]
	[DefaultEvent("PrintDocument")]
	[Description("可混合打印窗口中的一个或多个DataGridView表格及文本和图片等的可视化打印控件。注意请不要被名称误解了，控件在.NET环境下的C#等语言中也是可以使用的(6.01版，net2.0)")]
	public class VB2008Print : UserControl, objsafe.IObjectSafety
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x00090608 File Offset: 0x0008E808
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				Operators.CompareString
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
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00090680 File Offset: 0x0008E880
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(VB2008Print));
			this.Pd = new PrintDocument();
			this.PageSetupDialog1 = new PageSetupDialog();
			this.PrintDialog1 = new PrintDialog();
			this.SaveFileDialog1 = new SaveFileDialog();
			this.OpenFileDialog1 = new OpenFileDialog();
			this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
			this.ToolStripMenuItem_0 = new ToolStripMenuItem();
			this.ToolStripMenuItem_5 = new ToolStripMenuItem();
			this.ToolStripMenuItem_1 = new ToolStripMenuItem();
			this.ToolStripMenuItem13 = new ToolStripSeparator();
			this.ToolStripMenuItem_2 = new ToolStripMenuItem();
			this.ToolStripMenuItem14 = new ToolStripSeparator();
			this.ToolStripMenuItem_3 = new ToolStripMenuItem();
			this.ToolStripMenuItem_4 = new ToolStripMenuItem();
			this.ToolStripMenuItem12 = new ToolStripSeparator();
			this.ToolStripMenuItem_6 = new ToolStripMenuItem();
			this.ColorDialog1 = new ColorDialog();
			this.myms = new DataGridView();
			this.mydgv2 = new DataGridView();
			this.tempdgv = new DataGridView();
			this.BeforePreviewD = new PrintDocument();
			this.pagesetup = new ToolStripButton();
			this.ToolStripSeparator2 = new ToolStripSeparator();
			this.myopen = new ToolStripButton();
			this.ToolStripSeparator3 = new ToolStripSeparator();
			this.mybl = new ToolStripDropDownButton();
			this.ToolStripMenuItem11 = new ToolStripMenuItem();
			this.ToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem0 = new ToolStripMenuItem();
			this.ToolStripMenuItem1 = new ToolStripMenuItem();
			this.ToolStripMenuItem2 = new ToolStripMenuItem();
			this.ToolStripMenuItem3 = new ToolStripMenuItem();
			this.ToolStripMenuItem4 = new ToolStripMenuItem();
			this.ToolStripMenuItem5 = new ToolStripMenuItem();
			this.ToolStripMenuItem6 = new ToolStripMenuItem();
			this.ToolStripMenuItem7 = new ToolStripMenuItem();
			this.ToolStripMenuItem8 = new ToolStripMenuItem();
			this.ToolStripMenuItem9 = new ToolStripMenuItem();
			this.ToolStripMenuItem10 = new ToolStripMenuItem();
			this.ToolStripSeparator4 = new ToolStripSeparator();
			this.ToolStripMenuItem_16 = new ToolStripMenuItem();
			this.mycolsperpage = new ToolStripDropDownButton();
			this.ToolStripMenuItem_7 = new ToolStripMenuItem();
			this.ToolStripMenuItem_8 = new ToolStripMenuItem();
			this.ToolStripMenuItem_9 = new ToolStripMenuItem();
			this.ToolStripMenuItem_10 = new ToolStripMenuItem();
			this.ToolStripMenuItem_11 = new ToolStripMenuItem();
			this.ToolStripMenuItem_12 = new ToolStripMenuItem();
			this.ToolStripMenuItem_13 = new ToolStripMenuItem();
			this.ToolStripMenuItem_14 = new ToolStripMenuItem();
			this.myshowtype = new ToolStripDropDownButton();
			this.mytype1 = new ToolStripMenuItem();
			this.mytype2 = new ToolStripMenuItem();
			this.cpage = new ToolStripComboBox();
			this.ToolStripSeparator1 = new ToolStripSeparator();
			this.mystatus = new ToolStripLabel();
			this.ToolStripSeparator6 = new ToolStripSeparator();
			this.fpage = new ToolStripButton();
			this.ppage = new ToolStripButton();
			this.npage = new ToolStripButton();
			this.lpage = new ToolStripButton();
			this.ToolStripSeparator5 = new ToolStripSeparator();
			this.zdybutton = new ToolStripButton();
			this.ToolStrip1 = new ToolStrip();
			this.printd = new ToolStripSplitButton();
			this.dy1 = new ToolStripMenuItem();
			this.dy2 = new ToolStripMenuItem();
			this.dy3 = new ToolStripMenuItem();
			this.ToolStripMenuItem17 = new ToolStripSeparator();
			this.dy4 = new ToolStripMenuItem();
			this.dy5 = new ToolStripMenuItem();
			this.ToolStripMenuItem16 = new ToolStripSeparator();
			this.cgprint = new ToolStripMenuItem();
			this.mysave = new ToolStripSplitButton();
			this.ToolStripMenuItem15 = new ToolStripMenuItem();
			this.ToolStripMenuItem_15 = new ToolStripMenuItem();
			this.savepdf = new ToolStripSeparator();
			this.saveaspdfcur = new ToolStripMenuItem();
			this.saveaspdfall = new ToolStripMenuItem();
			this.ToolStripSeparator7 = new ToolStripSeparator();
			this.ToolStripMenuItem_17 = new ToolStripMenuItem();
			this.ToolStripMenuItem_18 = new ToolStripMenuItem();
			this.ZDYButton2 = new ToolStripButton();
			this.ToolTip1 = new ToolTip(this.components);
			this.PrintPreviewControl1 = new PrintPreviewControl();
			this.ContextMenuStrip1.SuspendLayout();
			((ISupportInitialize)this.myms).BeginInit();
			((ISupportInitialize)this.mydgv2).BeginInit();
			((ISupportInitialize)this.tempdgv).BeginInit();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.Pd.DocumentName = "VB2008打印控件";
			this.PageSetupDialog1.Document = this.Pd;
			this.PageSetupDialog1.EnableMetric = true;
			this.PrintDialog1.AllowSomePages = true;
			this.PrintDialog1.Document = this.Pd;
			this.PrintDialog1.ShowNetwork = false;
			this.PrintDialog1.UseEXDialog = true;
			this.SaveFileDialog1.Filter = "报表文件(*.you)|*.you";
			this.OpenFileDialog1.Filter = "报表文件(*.you)|*.you";
			this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem_0,
				this.ToolStripMenuItem_5,
				this.ToolStripMenuItem_1,
				this.ToolStripMenuItem13,
				this.ToolStripMenuItem_2,
				this.ToolStripMenuItem14,
				this.ToolStripMenuItem_3,
				this.ToolStripMenuItem_4,
				this.ToolStripMenuItem12,
				this.ToolStripMenuItem_6
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			Control contextMenuStrip = this.ContextMenuStrip1;
			Size size = new Size(161, 176);
			contextMenuStrip.Size = size;
			this.ToolStripMenuItem_0.Image = Resources.printer1;
			this.ToolStripMenuItem_0.Name = "打印全部";
			ToolStripItem toolStripItem = this.ToolStripMenuItem_0;
			size = new Size(160, 22);
			toolStripItem.Size = size;
			this.ToolStripMenuItem_0.Text = "打印全部页";
			this.ToolStripMenuItem_5.Image = Resources.printer1;
			this.ToolStripMenuItem_5.Name = "打印当前页";
			ToolStripItem toolStripItem2 = this.ToolStripMenuItem_5;
			size = new Size(160, 22);
			toolStripItem2.Size = size;
			this.ToolStripMenuItem_5.Text = "打印当前页";
			this.ToolStripMenuItem_1.Image = Resources.printer1;
			this.ToolStripMenuItem_1.Name = "打印";
			ToolStripItem toolStripItem3 = this.ToolStripMenuItem_1;
			size = new Size(160, 22);
			toolStripItem3.Size = size;
			this.ToolStripMenuItem_1.Text = "打印……";
			this.ToolStripMenuItem_1.ToolTipText = "选择打印机和打印范围打印";
			this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
			ToolStripItem toolStripMenuItem = this.ToolStripMenuItem13;
			size = new Size(157, 6);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem_2.Image = Resources.page1;
			this.ToolStripMenuItem_2.Name = "页面设置";
			ToolStripItem toolStripItem4 = this.ToolStripMenuItem_2;
			size = new Size(160, 22);
			toolStripItem4.Size = size;
			this.ToolStripMenuItem_2.Text = "页面设置";
			this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
			ToolStripItem toolStripMenuItem2 = this.ToolStripMenuItem14;
			size = new Size(157, 6);
			toolStripMenuItem2.Size = size;
			this.ToolStripMenuItem_3.Image = Resources.save;
			this.ToolStripMenuItem_3.Name = "保存为报表文件";
			ToolStripItem toolStripItem5 = this.ToolStripMenuItem_3;
			size = new Size(160, 22);
			toolStripItem5.Size = size;
			this.ToolStripMenuItem_3.Text = "保存为报表文件";
			this.ToolStripMenuItem_4.Image = Resources.foldopen;
			this.ToolStripMenuItem_4.Name = "打开报表文件";
			ToolStripItem toolStripItem6 = this.ToolStripMenuItem_4;
			size = new Size(160, 22);
			toolStripItem6.Size = size;
			this.ToolStripMenuItem_4.Text = "打开报表文件";
			this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
			ToolStripItem toolStripMenuItem3 = this.ToolStripMenuItem12;
			size = new Size(157, 6);
			toolStripMenuItem3.Size = size;
			this.ToolStripMenuItem_6.Name = "关于";
			ToolStripItem toolStripItem7 = this.ToolStripMenuItem_6;
			size = new Size(160, 22);
			toolStripItem7.Size = size;
			this.ToolStripMenuItem_6.Text = "关于";
			this.ToolStripMenuItem_6.Visible = false;
			this.myms.AllowUserToAddRows = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.myms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.myms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.myms.DefaultCellStyle = dataGridViewCellStyle2;
			Control myms = this.myms;
			Point location = new Point(103, 93);
			myms.Location = location;
			this.myms.Name = "myms";
			this.myms.RowTemplate.Height = 23;
			Control myms2 = this.myms;
			size = new Size(10, 0);
			myms2.Size = size;
			this.myms.TabIndex = 3;
			this.mydgv2.AllowUserToAddRows = false;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.mydgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.mydgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Window;
			dataGridViewCellStyle4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			this.mydgv2.DefaultCellStyle = dataGridViewCellStyle4;
			Control mydgv = this.mydgv2;
			location = new Point(330, 199);
			mydgv.Location = location;
			this.mydgv2.Name = "mydgv2";
			this.mydgv2.RowTemplate.Height = 23;
			Control mydgv2 = this.mydgv2;
			size = new Size(10, 0);
			mydgv2.Size = size;
			this.mydgv2.TabIndex = 4;
			this.tempdgv.AllowUserToAddRows = false;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			this.tempdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.tempdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Window;
			dataGridViewCellStyle6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
			this.tempdgv.DefaultCellStyle = dataGridViewCellStyle6;
			Control tempdgv = this.tempdgv;
			location = new Point(338, 207);
			tempdgv.Location = location;
			this.tempdgv.Name = "tempdgv";
			this.tempdgv.RowTemplate.Height = 23;
			Control tempdgv2 = this.tempdgv;
			size = new Size(10, 0);
			tempdgv2.Size = size;
			this.tempdgv.TabIndex = 5;
			this.pagesetup.Image = (Image)componentResourceManager.GetObject("pagesetup.Image");
			this.pagesetup.ImageTransparentColor = Color.Magenta;
			this.pagesetup.Name = "pagesetup";
			ToolStripItem pagesetup = this.pagesetup;
			size = new Size(69, 25);
			pagesetup.Size = size;
			this.pagesetup.Text = "页面(&U)";
			this.pagesetup.ToolTipText = "显示页面设置对话框";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripItem toolStripSeparator = this.ToolStripSeparator2;
			size = new Size(6, 28);
			toolStripSeparator.Size = size;
			this.myopen.Image = (Image)componentResourceManager.GetObject("myopen.Image");
			this.myopen.ImageTransparentColor = Color.Magenta;
			this.myopen.Name = "myopen";
			ToolStripItem myopen = this.myopen;
			size = new Size(70, 25);
			myopen.Size = size;
			this.myopen.Text = "打开(&O)";
			this.myopen.ToolTipText = "打开报表文件";
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			ToolStripItem toolStripSeparator2 = this.ToolStripSeparator3;
			size = new Size(6, 28);
			toolStripSeparator2.Size = size;
			this.mybl.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.mybl.DropDownItems.AddRange(new ToolStripItem[]
			{
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
				this.ToolStripMenuItem_16
			});
			this.mybl.Image = (Image)componentResourceManager.GetObject("mybl.Image");
			this.mybl.ImageTransparentColor = Color.Magenta;
			this.mybl.Name = "mybl";
			ToolStripItem mybl = this.mybl;
			size = new Size(45, 25);
			mybl.Size = size;
			this.mybl.Text = "比例";
			this.mybl.ToolTipText = "设置打印预览显示比例";
			this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
			ToolStripItem toolStripMenuItem4 = this.ToolStripMenuItem11;
			size = new Size(172, 22);
			toolStripMenuItem4.Size = size;
			this.ToolStripMenuItem11.Text = "10%";
			this.ToolStripMenuItem.Name = "ToolStripMenuItem";
			ToolStripItem toolStripMenuItem5 = this.ToolStripMenuItem;
			size = new Size(172, 22);
			toolStripMenuItem5.Size = size;
			this.ToolStripMenuItem.Text = "25%";
			this.ToolStripMenuItem0.Name = "ToolStripMenuItem0";
			ToolStripItem toolStripMenuItem6 = this.ToolStripMenuItem0;
			size = new Size(172, 22);
			toolStripMenuItem6.Size = size;
			this.ToolStripMenuItem0.Text = "50%";
			this.ToolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			ToolStripItem toolStripMenuItem7 = this.ToolStripMenuItem1;
			size = new Size(172, 22);
			toolStripMenuItem7.Size = size;
			this.ToolStripMenuItem1.Text = "75%";
			this.ToolStripMenuItem2.Checked = true;
			this.ToolStripMenuItem2.CheckState = CheckState.Checked;
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			ToolStripItem toolStripMenuItem8 = this.ToolStripMenuItem2;
			size = new Size(172, 22);
			toolStripMenuItem8.Size = size;
			this.ToolStripMenuItem2.Text = "100%";
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			ToolStripItem toolStripMenuItem9 = this.ToolStripMenuItem3;
			size = new Size(172, 22);
			toolStripMenuItem9.Size = size;
			this.ToolStripMenuItem3.Text = "125%";
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			ToolStripItem toolStripMenuItem10 = this.ToolStripMenuItem4;
			size = new Size(172, 22);
			toolStripMenuItem10.Size = size;
			this.ToolStripMenuItem4.Text = "150%";
			this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			ToolStripItem toolStripMenuItem11 = this.ToolStripMenuItem5;
			size = new Size(172, 22);
			toolStripMenuItem11.Size = size;
			this.ToolStripMenuItem5.Text = "200%";
			this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			ToolStripItem toolStripMenuItem12 = this.ToolStripMenuItem6;
			size = new Size(172, 22);
			toolStripMenuItem12.Size = size;
			this.ToolStripMenuItem6.Text = "250%";
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			ToolStripItem toolStripMenuItem13 = this.ToolStripMenuItem7;
			size = new Size(172, 22);
			toolStripMenuItem13.Size = size;
			this.ToolStripMenuItem7.Text = "300%";
			this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
			ToolStripItem toolStripMenuItem14 = this.ToolStripMenuItem8;
			size = new Size(172, 22);
			toolStripMenuItem14.Size = size;
			this.ToolStripMenuItem8.Text = "400%";
			this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
			ToolStripItem toolStripMenuItem15 = this.ToolStripMenuItem9;
			size = new Size(172, 22);
			toolStripMenuItem15.Size = size;
			this.ToolStripMenuItem9.Text = "500%";
			this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
			ToolStripItem toolStripMenuItem16 = this.ToolStripMenuItem10;
			size = new Size(172, 22);
			toolStripMenuItem16.Size = size;
			this.ToolStripMenuItem10.Text = "自适应";
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			ToolStripItem toolStripSeparator3 = this.ToolStripSeparator4;
			size = new Size(169, 6);
			toolStripSeparator3.Size = size;
			this.ToolStripMenuItem_16.Name = "测试ToolStripMenuItem";
			ToolStripItem toolStripItem8 = this.ToolStripMenuItem_16;
			size = new Size(172, 22);
			toolStripItem8.Size = size;
			this.ToolStripMenuItem_16.Text = "设置打印缩放比例";
			this.mycolsperpage.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.mycolsperpage.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem_7,
				this.ToolStripMenuItem_8,
				this.ToolStripMenuItem_9,
				this.ToolStripMenuItem_10,
				this.ToolStripMenuItem_11,
				this.ToolStripMenuItem_12,
				this.ToolStripMenuItem_13,
				this.ToolStripMenuItem_14
			});
			this.mycolsperpage.Image = (Image)componentResourceManager.GetObject("mycolsperpage.Image");
			this.mycolsperpage.ImageTransparentColor = Color.Magenta;
			this.mycolsperpage.Name = "mycolsperpage";
			ToolStripItem mycolsperpage = this.mycolsperpage;
			size = new Size(69, 21);
			mycolsperpage.Size = size;
			this.mycolsperpage.Text = "横向页数";
			this.mycolsperpage.ToolTipText = "横向显示的页数";
			this.ToolStripMenuItem_7.Checked = true;
			this.ToolStripMenuItem_7.CheckState = CheckState.Checked;
			this.ToolStripMenuItem_7.Name = "页ToolStripMenuItem";
			ToolStripItem toolStripItem9 = this.ToolStripMenuItem_7;
			size = new Size(102, 22);
			toolStripItem9.Size = size;
			this.ToolStripMenuItem_7.Text = "1页";
			this.ToolStripMenuItem_8.Name = "页ToolStripMenuItem1";
			ToolStripItem toolStripItem10 = this.ToolStripMenuItem_8;
			size = new Size(102, 22);
			toolStripItem10.Size = size;
			this.ToolStripMenuItem_8.Text = "2页";
			this.ToolStripMenuItem_9.Name = "页ToolStripMenuItem2";
			ToolStripItem toolStripItem11 = this.ToolStripMenuItem_9;
			size = new Size(102, 22);
			toolStripItem11.Size = size;
			this.ToolStripMenuItem_9.Text = "3页";
			this.ToolStripMenuItem_10.Name = "页ToolStripMenuItem3";
			ToolStripItem toolStripItem12 = this.ToolStripMenuItem_10;
			size = new Size(102, 22);
			toolStripItem12.Size = size;
			this.ToolStripMenuItem_10.Text = "4页";
			this.ToolStripMenuItem_11.Name = "页ToolStripMenuItem4";
			ToolStripItem toolStripItem13 = this.ToolStripMenuItem_11;
			size = new Size(102, 22);
			toolStripItem13.Size = size;
			this.ToolStripMenuItem_11.Text = "5页";
			this.ToolStripMenuItem_12.Name = "页ToolStripMenuItem5";
			ToolStripItem toolStripItem14 = this.ToolStripMenuItem_12;
			size = new Size(102, 22);
			toolStripItem14.Size = size;
			this.ToolStripMenuItem_12.Text = "6页";
			this.ToolStripMenuItem_13.Name = "页ToolStripMenuItem6";
			ToolStripItem toolStripItem15 = this.ToolStripMenuItem_13;
			size = new Size(102, 22);
			toolStripItem15.Size = size;
			this.ToolStripMenuItem_13.Text = "8页";
			this.ToolStripMenuItem_14.Name = "页ToolStripMenuItem7";
			ToolStripItem toolStripItem16 = this.ToolStripMenuItem_14;
			size = new Size(102, 22);
			toolStripItem16.Size = size;
			this.ToolStripMenuItem_14.Text = "10页";
			this.myshowtype.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.myshowtype.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mytype1,
				this.mytype2
			});
			this.myshowtype.Image = (Image)componentResourceManager.GetObject("myshowtype.Image");
			this.myshowtype.ImageTransparentColor = Color.Magenta;
			this.myshowtype.Name = "myshowtype";
			ToolStripItem myshowtype = this.myshowtype;
			size = new Size(45, 21);
			myshowtype.Size = size;
			this.myshowtype.Text = "显示";
			this.myshowtype.ToolTipText = "打印预览显示方式";
			this.mytype1.Name = "mytype1";
			ToolStripItem mytype = this.mytype1;
			size = new Size(124, 22);
			mytype.Size = size;
			this.mytype1.Text = "连续显示";
			this.mytype2.Checked = true;
			this.mytype2.CheckState = CheckState.Checked;
			this.mytype2.Name = "mytype2";
			ToolStripItem mytype2 = this.mytype2;
			size = new Size(124, 22);
			mytype2.Size = size;
			this.mytype2.Text = "单页显示";
			this.cpage.DropDownHeight = 180;
			this.cpage.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cpage.DropDownWidth = 75;
			this.cpage.Enabled = false;
			this.cpage.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cpage.IntegralHeight = false;
			this.cpage.Name = "cpage";
			ToolStripControlHost cpage = this.cpage;
			size = new Size(75, 24);
			cpage.Size = size;
			this.cpage.ToolTipText = "选择要在当前页面中显示的页码(在显示方式为<连续显示>下不可用";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripItem toolStripSeparator4 = this.ToolStripSeparator1;
			size = new Size(6, 25);
			toolStripSeparator4.Size = size;
			this.mystatus.BackColor = Color.Blue;
			this.mystatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.mystatus.ForeColor = Color.Red;
			this.mystatus.Name = "mystatus";
			ToolStripItem mystatus = this.mystatus;
			size = new Size(63, 17);
			mystatus.Size = size;
			this.mystatus.Text = "共【0】页";
			this.ToolStripSeparator6.Name = "ToolStripSeparator6";
			ToolStripItem toolStripSeparator5 = this.ToolStripSeparator6;
			size = new Size(6, 25);
			toolStripSeparator5.Size = size;
			this.fpage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.fpage.Enabled = false;
			this.fpage.Image = Resources.fFirst;
			this.fpage.ImageTransparentColor = Color.Magenta;
			this.fpage.Name = "fpage";
			ToolStripItem fpage = this.fpage;
			size = new Size(23, 20);
			fpage.Size = size;
			this.fpage.Text = "第一页";
			this.ppage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ppage.Enabled = false;
			this.ppage.Image = Resources.pPrev;
			this.ppage.ImageTransparentColor = Color.Magenta;
			this.ppage.Name = "ppage";
			ToolStripItem ppage = this.ppage;
			size = new Size(23, 20);
			ppage.Size = size;
			this.ppage.Text = "上一页";
			this.npage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.npage.Enabled = false;
			this.npage.Image = Resources.pnNext;
			this.npage.ImageTransparentColor = Color.Magenta;
			this.npage.Name = "npage";
			ToolStripItem npage = this.npage;
			size = new Size(23, 20);
			npage.Size = size;
			this.npage.Text = "下一页";
			this.lpage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.lpage.Enabled = false;
			this.lpage.Image = Resources.lLast;
			this.lpage.ImageTransparentColor = Color.Magenta;
			this.lpage.Name = "lpage";
			ToolStripItem lpage = this.lpage;
			size = new Size(23, 20);
			lpage.Size = size;
			this.lpage.Text = "最后一页";
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			ToolStripItem toolStripSeparator6 = this.ToolStripSeparator5;
			size = new Size(6, 25);
			toolStripSeparator6.Size = size;
			this.zdybutton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.zdybutton.Image = (Image)componentResourceManager.GetObject("zdybutton.Image");
			this.zdybutton.ImageTransparentColor = Color.Magenta;
			this.zdybutton.Name = "zdybutton";
			ToolStripItem zdybutton = this.zdybutton;
			size = new Size(23, 4);
			zdybutton.Size = size;
			this.zdybutton.Visible = false;
			this.ToolStrip1.Items.AddRange(new ToolStripItem[]
			{
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
				this.ZDYButton2
			});
			Control toolStrip = this.ToolStrip1;
			location = new Point(0, 0);
			toolStrip.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			Control toolStrip2 = this.ToolStrip1;
			size = new Size(410, 28);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 1;
			this.ToolStrip1.Text = "ToolStrip1";
			this.printd.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.dy1,
				this.dy2,
				this.dy3,
				this.ToolStripMenuItem17,
				this.dy4,
				this.dy5,
				this.ToolStripMenuItem16,
				this.cgprint
			});
			this.printd.Image = Resources.printer1;
			this.printd.ImageTransparentColor = Color.Magenta;
			this.printd.Name = "printd";
			ToolStripItem printd = this.printd;
			size = new Size(79, 25);
			printd.Size = size;
			this.printd.Text = "打印(&P)";
			this.printd.ToolTipText = "显示打印对话框，选择打印机进行打印输出。";
			this.dy1.Image = Resources.printer1;
			this.dy1.Name = "dy1";
			ToolStripItem dy = this.dy1;
			size = new Size(184, 22);
			dy.Size = size;
			this.dy1.Text = "打印……";
			this.dy1.ToolTipText = "打印前选择打印机、打印范围、打印份数等选项";
			this.dy2.Image = Resources.printer1;
			this.dy2.Name = "dy2";
			ToolStripItem dy2 = this.dy2;
			size = new Size(184, 22);
			dy2.Size = size;
			this.dy2.Text = "快速打印全部页";
			this.dy3.Image = Resources.printer1;
			this.dy3.Name = "dy3";
			ToolStripItem dy3 = this.dy3;
			size = new Size(184, 22);
			dy3.Size = size;
			this.dy3.Text = "快速打印当前页";
			this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
			ToolStripItem toolStripMenuItem17 = this.ToolStripMenuItem17;
			size = new Size(181, 6);
			toolStripMenuItem17.Size = size;
			this.dy4.Name = "dy4";
			ToolStripItem dy4 = this.dy4;
			size = new Size(184, 22);
			dy4.Size = size;
			this.dy4.Text = "手动双面打印……";
			this.dy5.Name = "dy5";
			ToolStripItem dy5 = this.dy5;
			size = new Size(184, 22);
			dy5.Size = size;
			this.dy5.Text = "手动双面打印全部页";
			this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
			ToolStripItem toolStripMenuItem18 = this.ToolStripMenuItem16;
			size = new Size(181, 6);
			toolStripMenuItem18.Size = size;
			this.cgprint.Name = "cgprint";
			ToolStripItem cgprint = this.cgprint;
			size = new Size(184, 22);
			cgprint.Size = size;
			this.cgprint.Text = "草稿打印……";
			this.mysave.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem15,
				this.ToolStripMenuItem_15,
				this.savepdf,
				this.saveaspdfcur,
				this.saveaspdfall,
				this.ToolStripSeparator7,
				this.ToolStripMenuItem_17,
				this.ToolStripMenuItem_18
			});
			this.mysave.Image = (Image)componentResourceManager.GetObject("mysave.Image");
			this.mysave.ImageTransparentColor = Color.Magenta;
			this.mysave.Name = "mysave";
			ToolStripItem mysave = this.mysave;
			size = new Size(79, 25);
			mysave.Size = size;
			this.mysave.Text = "保存(&S)";
			this.mysave.ToolTipText = "保存为文件";
			this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
			ToolStripItem toolStripMenuItem19 = this.ToolStripMenuItem15;
			size = new Size(230, 22);
			toolStripMenuItem19.Size = size;
			this.ToolStripMenuItem15.Text = "保存";
			this.ToolStripMenuItem15.ToolTipText = "保存为报表文件";
			this.ToolStripMenuItem_15.Name = "加密保存ToolStripMenuItem";
			ToolStripItem toolStripItem17 = this.ToolStripMenuItem_15;
			size = new Size(230, 22);
			toolStripItem17.Size = size;
			this.ToolStripMenuItem_15.Text = "加密保存";
			this.ToolStripMenuItem_15.ToolTipText = "保存为报表文件并设置密码";
			this.savepdf.Name = "savepdf";
			ToolStripItem savepdf = this.savepdf;
			size = new Size(227, 6);
			savepdf.Size = size;
			this.saveaspdfcur.Name = "saveaspdfcur";
			ToolStripItem saveaspdfcur = this.saveaspdfcur;
			size = new Size(230, 22);
			saveaspdfcur.Size = size;
			this.saveaspdfcur.Text = "保存为PDF文件（仅当前页）";
			this.saveaspdfall.Name = "saveaspdfall";
			ToolStripItem saveaspdfall = this.saveaspdfall;
			size = new Size(230, 22);
			saveaspdfall.Size = size;
			this.saveaspdfall.Text = "保存为PDF文件（全部页）";
			this.ToolStripSeparator7.Name = "ToolStripSeparator7";
			ToolStripItem toolStripSeparator7 = this.ToolStripSeparator7;
			size = new Size(227, 6);
			toolStripSeparator7.Size = size;
			this.ToolStripMenuItem_17.Name = "保存为图像仅当前页ToolStripMenuItem";
			ToolStripItem toolStripItem18 = this.ToolStripMenuItem_17;
			size = new Size(230, 22);
			toolStripItem18.Size = size;
			this.ToolStripMenuItem_17.Text = "保存为图像（仅当前页）";
			this.ToolStripMenuItem_17.ToolTipText = "将当前页保存为图像文件";
			this.ToolStripMenuItem_18.Name = "保存为图像全部页ToolStripMenuItem";
			ToolStripItem toolStripItem19 = this.ToolStripMenuItem_18;
			size = new Size(230, 22);
			toolStripItem19.Size = size;
			this.ToolStripMenuItem_18.Text = "保存为图像（全部页）";
			this.ToolStripMenuItem_18.ToolTipText = "将整个打印预览结果保存为图像";
			this.ZDYButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.ZDYButton2.ImageTransparentColor = Color.Magenta;
			this.ZDYButton2.Name = "ZDYButton2";
			ToolStripItem zdybutton2 = this.ZDYButton2;
			size = new Size(23, 4);
			zdybutton2.Size = size;
			this.ZDYButton2.Visible = false;
			this.PrintPreviewControl1.AutoZoom = false;
			this.PrintPreviewControl1.BackColor = SystemColors.AppWorkspace;
			this.PrintPreviewControl1.Columns = 1;
			this.PrintPreviewControl1.ContextMenuStrip = this.ContextMenuStrip1;
			this.PrintPreviewControl1.Cursor = Cursors.Hand;
			this.PrintPreviewControl1.Dock = DockStyle.Fill;
			this.PrintPreviewControl1.Document = this.Pd;
			this.PrintPreviewControl1.ForeColor = Color.White;
			this.PrintPreviewControl1.IsShowprocessDialog = true;
			Control printPreviewControl = this.PrintPreviewControl1;
			location = new Point(0, 28);
			printPreviewControl.Location = location;
			this.PrintPreviewControl1.Name = "PrintPreviewControl1";
			this.PrintPreviewControl1.Rows = 1;
			Control printPreviewControl2 = this.PrintPreviewControl1;
			size = new Size(410, 171);
			printPreviewControl2.Size = size;
			this.PrintPreviewControl1.StartPage = 0;
			this.PrintPreviewControl1.TabIndex = 2;
			this.PrintPreviewControl1.UseAntiAlias = true;
			this.PrintPreviewControl1.Zoom = 1.0;
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.tempdgv);
			this.Controls.Add(this.mydgv2);
			this.Controls.Add(this.myms);
			this.Controls.Add(this.PrintPreviewControl1);
			this.Controls.Add(this.ToolStrip1);
			this.DoubleBuffered = true;
			this.Name = "VB2008Print";
			size = new Size(410, 199);
			this.Size = size;
			this.ContextMenuStrip1.ResumeLayout(false);
			((ISupportInitialize)this.myms).EndInit();
			((ISupportInitialize)this.mydgv2).EndInit();
			((ISupportInitialize)this.tempdgv).EndInit();
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00092910 File Offset: 0x00090B10
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00092928 File Offset: 0x00090B28
		internal virtual PrintDocument Pd
		{
			get
			{
				return this._Pd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				QueryPageSettingsEventHandler value2 = new QueryPageSettingsEventHandler(this.Pd_QueryPageSettings);
				PrintPageEventHandler value3 = new PrintPageEventHandler(this.Pd_PrintPage);
				PrintEventHandler value4 = new PrintEventHandler(this.Pd_EndPrint);
				PrintEventHandler value5 = new PrintEventHandler(this.Pd_BeginPrint);
				if (this._Pd != null)
				{
					this._Pd.QueryPageSettings -= value2;
					this._Pd.PrintPage -= value3;
					this._Pd.EndPrint -= value4;
					this._Pd.BeginPrint -= value5;
				}
				this._Pd = value;
				if (this._Pd != null)
				{
					this._Pd.QueryPageSettings += value2;
					this._Pd.PrintPage += value3;
					this._Pd.EndPrint += value4;
					this._Pd.BeginPrint += value5;
				}
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000929E4 File Offset: 0x00090BE4
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x00006B0A File Offset: 0x00004D0A
		internal virtual PageSetupDialog PageSetupDialog1
		{
			get
			{
				return this._PageSetupDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PageSetupDialog1 = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000929FC File Offset: 0x00090BFC
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00006B13 File Offset: 0x00004D13
		internal virtual PrintDialog PrintDialog1
		{
			get
			{
				return this._PrintDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PrintDialog1 = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00092A14 File Offset: 0x00090C14
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x00006B1C File Offset: 0x00004D1C
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get
			{
				return this._SaveFileDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00092A2C File Offset: 0x00090C2C
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x00006B25 File Offset: 0x00004D25
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get
			{
				return this._OpenFileDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00092A44 File Offset: 0x00090C44
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00092A5C File Offset: 0x00090C5C
		internal virtual PrintPreviewControl PrintPreviewControl1
		{
			get
			{
				return this._PrintPreviewControl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PrintPreviewControl1_MouseWheel);
				MouseEventHandler value3 = new MouseEventHandler(this.PrintPreviewControl1_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.PrintPreviewControl1_MouseUp);
				MouseEventHandler value5 = new MouseEventHandler(this.PrintPreviewControl1_MouseDown);
				EventHandler value6 = new EventHandler(this.PrintPreviewControl1_DoubleClick);
				EventHandler value7 = new EventHandler(this.PrintPreviewControl1_Click);
				KeyEventHandler value8 = new KeyEventHandler(this.PrintPreviewControl1_KeyUp);
				KeyPressEventHandler value9 = new KeyPressEventHandler(this.PrintPreviewControl1_KeyPress);
				if (this._PrintPreviewControl1 != null)
				{
					this._PrintPreviewControl1.MouseWheel -= value2;
					this._PrintPreviewControl1.MouseMove -= value3;
					this._PrintPreviewControl1.MouseUp -= value4;
					this._PrintPreviewControl1.MouseDown -= value5;
					this._PrintPreviewControl1.DoubleClick -= value6;
					this._PrintPreviewControl1.Click -= value7;
					this._PrintPreviewControl1.KeyUp -= value8;
					this._PrintPreviewControl1.KeyPress -= value9;
				}
				this._PrintPreviewControl1 = value;
				if (this._PrintPreviewControl1 != null)
				{
					this._PrintPreviewControl1.MouseWheel += value2;
					this._PrintPreviewControl1.MouseMove += value3;
					this._PrintPreviewControl1.MouseUp += value4;
					this._PrintPreviewControl1.MouseDown += value5;
					this._PrintPreviewControl1.DoubleClick += value6;
					this._PrintPreviewControl1.Click += value7;
					this._PrintPreviewControl1.KeyUp += value8;
					this._PrintPreviewControl1.KeyPress += value9;
				}
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00092BBC File Offset: 0x00090DBC
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00006B2E File Offset: 0x00004D2E
		internal virtual ColorDialog ColorDialog1
		{
			get
			{
				return this._ColorDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColorDialog1 = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00092BD4 File Offset: 0x00090DD4
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00006B37 File Offset: 0x00004D37
		internal virtual DataGridView myms
		{
			get
			{
				return this._myms;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._myms = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00092BEC File Offset: 0x00090DEC
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00006B40 File Offset: 0x00004D40
		internal virtual DataGridView mydgv2
		{
			get
			{
				return this._mydgv2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mydgv2 = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00092C04 File Offset: 0x00090E04
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00006B49 File Offset: 0x00004D49
		internal virtual DataGridView tempdgv
		{
			get
			{
				return this._tempdgv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tempdgv = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00092C1C File Offset: 0x00090E1C
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00092C34 File Offset: 0x00090E34
		internal virtual PrintDocument BeforePreviewD
		{
			get
			{
				return this._BeforePreviewD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintEventHandler value2 = new PrintEventHandler(this.BeforePreviewD_BeginPrint);
				PrintPageEventHandler value3 = new PrintPageEventHandler(this.BeforePreviewD_PrintPage);
				if (this._BeforePreviewD != null)
				{
					this._BeforePreviewD.BeginPrint -= value2;
					this._BeforePreviewD.PrintPage -= value3;
				}
				this._BeforePreviewD = value;
				if (this._BeforePreviewD != null)
				{
					this._BeforePreviewD.BeginPrint += value2;
					this._BeforePreviewD.PrintPage += value3;
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00092CA4 File Offset: 0x00090EA4
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00092CBC File Offset: 0x00090EBC
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this._ContextMenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.ContextMenuStrip1_Opening);
				if (this._ContextMenuStrip1 != null)
				{
					this._ContextMenuStrip1.Opening -= value2;
				}
				this._ContextMenuStrip1 = value;
				if (this._ContextMenuStrip1 != null)
				{
					this._ContextMenuStrip1.Opening += value2;
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00092D08 File Offset: 0x00090F08
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00092D20 File Offset: 0x00090F20
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			get
			{
				return this.toolStripMenuItem_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy2_Click);
				if (this.toolStripMenuItem_0 != null)
				{
					this.toolStripMenuItem_0.Click -= value2;
				}
				this.toolStripMenuItem_0 = value;
				if (this.toolStripMenuItem_0 != null)
				{
					this.toolStripMenuItem_0.Click += value2;
				}
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00092D6C File Offset: 0x00090F6C
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00092D84 File Offset: 0x00090F84
		internal virtual ToolStripMenuItem ToolStripMenuItem_1
		{
			get
			{
				return this.toolStripMenuItem_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_1_Click);
				if (this.toolStripMenuItem_1 != null)
				{
					this.toolStripMenuItem_1.Click -= value2;
				}
				this.toolStripMenuItem_1 = value;
				if (this.toolStripMenuItem_1 != null)
				{
					this.toolStripMenuItem_1.Click += value2;
				}
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00092DD0 File Offset: 0x00090FD0
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x00092DE8 File Offset: 0x00090FE8
		internal virtual ToolStripMenuItem ToolStripMenuItem_2
		{
			get
			{
				return this.toolStripMenuItem_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_2_Click);
				if (this.toolStripMenuItem_2 != null)
				{
					this.toolStripMenuItem_2.Click -= value2;
				}
				this.toolStripMenuItem_2 = value;
				if (this.toolStripMenuItem_2 != null)
				{
					this.toolStripMenuItem_2.Click += value2;
				}
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00092E34 File Offset: 0x00091034
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x00092E4C File Offset: 0x0009104C
		internal virtual ToolStripMenuItem ToolStripMenuItem_3
		{
			get
			{
				return this.toolStripMenuItem_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_3_Click);
				if (this.toolStripMenuItem_3 != null)
				{
					this.toolStripMenuItem_3.Click -= value2;
				}
				this.toolStripMenuItem_3 = value;
				if (this.toolStripMenuItem_3 != null)
				{
					this.toolStripMenuItem_3.Click += value2;
				}
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00092E98 File Offset: 0x00091098
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00092EB0 File Offset: 0x000910B0
		internal virtual ToolStripMenuItem ToolStripMenuItem_4
		{
			get
			{
				return this.toolStripMenuItem_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_4_Click);
				if (this.toolStripMenuItem_4 != null)
				{
					this.toolStripMenuItem_4.Click -= value2;
				}
				this.toolStripMenuItem_4 = value;
				if (this.toolStripMenuItem_4 != null)
				{
					this.toolStripMenuItem_4.Click += value2;
				}
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00092EFC File Offset: 0x000910FC
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x00092F14 File Offset: 0x00091114
		internal virtual ToolStripMenuItem ToolStripMenuItem_5
		{
			get
			{
				return this.toolStripMenuItem_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy3_Click);
				if (this.toolStripMenuItem_5 != null)
				{
					this.toolStripMenuItem_5.Click -= value2;
				}
				this.toolStripMenuItem_5 = value;
				if (this.toolStripMenuItem_5 != null)
				{
					this.toolStripMenuItem_5.Click += value2;
				}
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00092F60 File Offset: 0x00091160
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00006B52 File Offset: 0x00004D52
		internal virtual ToolStripSeparator ToolStripMenuItem13
		{
			get
			{
				return this._ToolStripMenuItem13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem13 = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00092F78 File Offset: 0x00091178
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x00006B5B File Offset: 0x00004D5B
		internal virtual ToolStripSeparator ToolStripMenuItem14
		{
			get
			{
				return this._ToolStripMenuItem14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem14 = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00092F90 File Offset: 0x00091190
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00006B64 File Offset: 0x00004D64
		internal virtual ToolStripSeparator ToolStripMenuItem12
		{
			get
			{
				return this._ToolStripMenuItem12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem12 = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00092FA8 File Offset: 0x000911A8
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00092FC0 File Offset: 0x000911C0
		internal virtual ToolStripMenuItem ToolStripMenuItem_6
		{
			get
			{
				return this.toolStripMenuItem_6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_6_Click);
				if (this.toolStripMenuItem_6 != null)
				{
					this.toolStripMenuItem_6.Click -= value2;
				}
				this.toolStripMenuItem_6 = value;
				if (this.toolStripMenuItem_6 != null)
				{
					this.toolStripMenuItem_6.Click += value2;
				}
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0009300C File Offset: 0x0009120C
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x00093024 File Offset: 0x00091224
		internal virtual ToolStripButton pagesetup
		{
			get
			{
				return this._pagesetup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pagesetup_Click);
				if (this._pagesetup != null)
				{
					this._pagesetup.Click -= value2;
				}
				this._pagesetup = value;
				if (this._pagesetup != null)
				{
					this._pagesetup.Click += value2;
				}
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00093070 File Offset: 0x00091270
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x00006B6D File Offset: 0x00004D6D
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00093088 File Offset: 0x00091288
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x000930A0 File Offset: 0x000912A0
		internal virtual ToolStripButton myopen
		{
			get
			{
				return this._myopen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.myopen_Click);
				if (this._myopen != null)
				{
					this._myopen.Click -= value2;
				}
				this._myopen = value;
				if (this._myopen != null)
				{
					this._myopen.Click += value2;
				}
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000930EC File Offset: 0x000912EC
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x00006B76 File Offset: 0x00004D76
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00093104 File Offset: 0x00091304
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x00006B7F File Offset: 0x00004D7F
		internal virtual ToolStripDropDownButton mybl
		{
			get
			{
				return this._mybl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mybl = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0009311C File Offset: 0x0009131C
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x00093134 File Offset: 0x00091334
		internal virtual ToolStripMenuItem ToolStripMenuItem11
		{
			get
			{
				return this._ToolStripMenuItem11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem11_Click);
				if (this._ToolStripMenuItem11 != null)
				{
					this._ToolStripMenuItem11.Click -= value2;
				}
				this._ToolStripMenuItem11 = value;
				if (this._ToolStripMenuItem11 != null)
				{
					this._ToolStripMenuItem11.Click += value2;
				}
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00093180 File Offset: 0x00091380
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x00093198 File Offset: 0x00091398
		internal virtual ToolStripMenuItem ToolStripMenuItem
		{
			get
			{
				return this._ToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_Click);
				if (this._ToolStripMenuItem != null)
				{
					this._ToolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem = value;
				if (this._ToolStripMenuItem != null)
				{
					this._ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000931E4 File Offset: 0x000913E4
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x000931FC File Offset: 0x000913FC
		internal virtual ToolStripMenuItem ToolStripMenuItem0
		{
			get
			{
				return this._ToolStripMenuItem0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem0_Click);
				if (this._ToolStripMenuItem0 != null)
				{
					this._ToolStripMenuItem0.Click -= value2;
				}
				this._ToolStripMenuItem0 = value;
				if (this._ToolStripMenuItem0 != null)
				{
					this._ToolStripMenuItem0.Click += value2;
				}
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00093248 File Offset: 0x00091448
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00093260 File Offset: 0x00091460
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem1_Click);
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click -= value2;
				}
				this._ToolStripMenuItem1 = value;
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x000932AC File Offset: 0x000914AC
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x000932C4 File Offset: 0x000914C4
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			get
			{
				return this._ToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem2_Click);
				if (this._ToolStripMenuItem2 != null)
				{
					this._ToolStripMenuItem2.Click -= value2;
				}
				this._ToolStripMenuItem2 = value;
				if (this._ToolStripMenuItem2 != null)
				{
					this._ToolStripMenuItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00093310 File Offset: 0x00091510
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00093328 File Offset: 0x00091528
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem3_Click);
				if (this._ToolStripMenuItem3 != null)
				{
					this._ToolStripMenuItem3.Click -= value2;
				}
				this._ToolStripMenuItem3 = value;
				if (this._ToolStripMenuItem3 != null)
				{
					this._ToolStripMenuItem3.Click += value2;
				}
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00093374 File Offset: 0x00091574
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0009338C File Offset: 0x0009158C
		internal virtual ToolStripMenuItem ToolStripMenuItem4
		{
			get
			{
				return this._ToolStripMenuItem4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem4_Click);
				if (this._ToolStripMenuItem4 != null)
				{
					this._ToolStripMenuItem4.Click -= value2;
				}
				this._ToolStripMenuItem4 = value;
				if (this._ToolStripMenuItem4 != null)
				{
					this._ToolStripMenuItem4.Click += value2;
				}
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000933D8 File Offset: 0x000915D8
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x000933F0 File Offset: 0x000915F0
		internal virtual ToolStripMenuItem ToolStripMenuItem5
		{
			get
			{
				return this._ToolStripMenuItem5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
				if (this._ToolStripMenuItem5 != null)
				{
					this._ToolStripMenuItem5.Click -= value2;
				}
				this._ToolStripMenuItem5 = value;
				if (this._ToolStripMenuItem5 != null)
				{
					this._ToolStripMenuItem5.Click += value2;
				}
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0009343C File Offset: 0x0009163C
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x00093454 File Offset: 0x00091654
		internal virtual ToolStripMenuItem ToolStripMenuItem6
		{
			get
			{
				return this._ToolStripMenuItem6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem6_Click);
				if (this._ToolStripMenuItem6 != null)
				{
					this._ToolStripMenuItem6.Click -= value2;
				}
				this._ToolStripMenuItem6 = value;
				if (this._ToolStripMenuItem6 != null)
				{
					this._ToolStripMenuItem6.Click += value2;
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000934A0 File Offset: 0x000916A0
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000934B8 File Offset: 0x000916B8
		internal virtual ToolStripMenuItem ToolStripMenuItem7
		{
			get
			{
				return this._ToolStripMenuItem7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem7_Click);
				if (this._ToolStripMenuItem7 != null)
				{
					this._ToolStripMenuItem7.Click -= value2;
				}
				this._ToolStripMenuItem7 = value;
				if (this._ToolStripMenuItem7 != null)
				{
					this._ToolStripMenuItem7.Click += value2;
				}
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00093504 File Offset: 0x00091704
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x0009351C File Offset: 0x0009171C
		internal virtual ToolStripMenuItem ToolStripMenuItem8
		{
			get
			{
				return this._ToolStripMenuItem8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem8_Click);
				if (this._ToolStripMenuItem8 != null)
				{
					this._ToolStripMenuItem8.Click -= value2;
				}
				this._ToolStripMenuItem8 = value;
				if (this._ToolStripMenuItem8 != null)
				{
					this._ToolStripMenuItem8.Click += value2;
				}
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00093568 File Offset: 0x00091768
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x00093580 File Offset: 0x00091780
		internal virtual ToolStripMenuItem ToolStripMenuItem9
		{
			get
			{
				return this._ToolStripMenuItem9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem9_Click);
				if (this._ToolStripMenuItem9 != null)
				{
					this._ToolStripMenuItem9.Click -= value2;
				}
				this._ToolStripMenuItem9 = value;
				if (this._ToolStripMenuItem9 != null)
				{
					this._ToolStripMenuItem9.Click += value2;
				}
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000935CC File Offset: 0x000917CC
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x000935E4 File Offset: 0x000917E4
		internal virtual ToolStripMenuItem ToolStripMenuItem10
		{
			get
			{
				return this._ToolStripMenuItem10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem10_Click);
				if (this._ToolStripMenuItem10 != null)
				{
					this._ToolStripMenuItem10.Click -= value2;
				}
				this._ToolStripMenuItem10 = value;
				if (this._ToolStripMenuItem10 != null)
				{
					this._ToolStripMenuItem10.Click += value2;
				}
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00093630 File Offset: 0x00091830
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x00006B88 File Offset: 0x00004D88
		internal virtual ToolStripDropDownButton mycolsperpage
		{
			get
			{
				return this._mycolsperpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mycolsperpage = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00093648 File Offset: 0x00091848
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00093660 File Offset: 0x00091860
		internal virtual ToolStripMenuItem ToolStripMenuItem_7
		{
			get
			{
				return this.toolStripMenuItem_7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_7_Click);
				if (this.toolStripMenuItem_7 != null)
				{
					this.toolStripMenuItem_7.Click -= value2;
				}
				this.toolStripMenuItem_7 = value;
				if (this.toolStripMenuItem_7 != null)
				{
					this.toolStripMenuItem_7.Click += value2;
				}
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000936AC File Offset: 0x000918AC
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x000936C4 File Offset: 0x000918C4
		internal virtual ToolStripMenuItem ToolStripMenuItem_8
		{
			get
			{
				return this.toolStripMenuItem_8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_8_Click);
				if (this.toolStripMenuItem_8 != null)
				{
					this.toolStripMenuItem_8.Click -= value2;
				}
				this.toolStripMenuItem_8 = value;
				if (this.toolStripMenuItem_8 != null)
				{
					this.toolStripMenuItem_8.Click += value2;
				}
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00093710 File Offset: 0x00091910
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x00093728 File Offset: 0x00091928
		internal virtual ToolStripMenuItem ToolStripMenuItem_9
		{
			get
			{
				return this.toolStripMenuItem_9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_9_Click);
				if (this.toolStripMenuItem_9 != null)
				{
					this.toolStripMenuItem_9.Click -= value2;
				}
				this.toolStripMenuItem_9 = value;
				if (this.toolStripMenuItem_9 != null)
				{
					this.toolStripMenuItem_9.Click += value2;
				}
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00093774 File Offset: 0x00091974
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0009378C File Offset: 0x0009198C
		internal virtual ToolStripMenuItem ToolStripMenuItem_10
		{
			get
			{
				return this.toolStripMenuItem_10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_10_Click);
				if (this.toolStripMenuItem_10 != null)
				{
					this.toolStripMenuItem_10.Click -= value2;
				}
				this.toolStripMenuItem_10 = value;
				if (this.toolStripMenuItem_10 != null)
				{
					this.toolStripMenuItem_10.Click += value2;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000937D8 File Offset: 0x000919D8
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x000937F0 File Offset: 0x000919F0
		internal virtual ToolStripMenuItem ToolStripMenuItem_11
		{
			get
			{
				return this.toolStripMenuItem_11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_11_Click);
				if (this.toolStripMenuItem_11 != null)
				{
					this.toolStripMenuItem_11.Click -= value2;
				}
				this.toolStripMenuItem_11 = value;
				if (this.toolStripMenuItem_11 != null)
				{
					this.toolStripMenuItem_11.Click += value2;
				}
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0009383C File Offset: 0x00091A3C
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x00093854 File Offset: 0x00091A54
		internal virtual ToolStripMenuItem ToolStripMenuItem_12
		{
			get
			{
				return this.toolStripMenuItem_12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_12_Click);
				if (this.toolStripMenuItem_12 != null)
				{
					this.toolStripMenuItem_12.Click -= value2;
				}
				this.toolStripMenuItem_12 = value;
				if (this.toolStripMenuItem_12 != null)
				{
					this.toolStripMenuItem_12.Click += value2;
				}
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000938A0 File Offset: 0x00091AA0
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x000938B8 File Offset: 0x00091AB8
		internal virtual ToolStripMenuItem ToolStripMenuItem_13
		{
			get
			{
				return this.toolStripMenuItem_13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_13_Click);
				if (this.toolStripMenuItem_13 != null)
				{
					this.toolStripMenuItem_13.Click -= value2;
				}
				this.toolStripMenuItem_13 = value;
				if (this.toolStripMenuItem_13 != null)
				{
					this.toolStripMenuItem_13.Click += value2;
				}
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00093904 File Offset: 0x00091B04
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x0009391C File Offset: 0x00091B1C
		internal virtual ToolStripMenuItem ToolStripMenuItem_14
		{
			get
			{
				return this.toolStripMenuItem_14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_14_Click);
				if (this.toolStripMenuItem_14 != null)
				{
					this.toolStripMenuItem_14.Click -= value2;
				}
				this.toolStripMenuItem_14 = value;
				if (this.toolStripMenuItem_14 != null)
				{
					this.toolStripMenuItem_14.Click += value2;
				}
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00093968 File Offset: 0x00091B68
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00006B91 File Offset: 0x00004D91
		internal virtual ToolStripDropDownButton myshowtype
		{
			get
			{
				return this._myshowtype;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._myshowtype = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00093980 File Offset: 0x00091B80
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00093998 File Offset: 0x00091B98
		internal virtual ToolStripMenuItem mytype1
		{
			get
			{
				return this._mytype1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mytype1_Click);
				if (this._mytype1 != null)
				{
					this._mytype1.Click -= value2;
				}
				this._mytype1 = value;
				if (this._mytype1 != null)
				{
					this._mytype1.Click += value2;
				}
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x000939E4 File Offset: 0x00091BE4
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x000939FC File Offset: 0x00091BFC
		internal virtual ToolStripMenuItem mytype2
		{
			get
			{
				return this._mytype2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mytype2_Click);
				if (this._mytype2 != null)
				{
					this._mytype2.Click -= value2;
				}
				this._mytype2 = value;
				if (this._mytype2 != null)
				{
					this._mytype2.Click += value2;
				}
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00093A48 File Offset: 0x00091C48
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00093A60 File Offset: 0x00091C60
		internal virtual ToolStripComboBox cpage
		{
			get
			{
				return this._cpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.cpage_KeyPress);
				EventHandler value3 = new EventHandler(this.cpage_SelectedIndexChanged);
				if (this._cpage != null)
				{
					this._cpage.KeyPress -= value2;
					this._cpage.SelectedIndexChanged -= value3;
				}
				this._cpage = value;
				if (this._cpage != null)
				{
					this._cpage.KeyPress += value2;
					this._cpage.SelectedIndexChanged += value3;
				}
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00093AD0 File Offset: 0x00091CD0
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x00006B9A File Offset: 0x00004D9A
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00093AE8 File Offset: 0x00091CE8
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x00006BA3 File Offset: 0x00004DA3
		internal virtual ToolStripLabel mystatus
		{
			get
			{
				return this._mystatus;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mystatus = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00093B00 File Offset: 0x00091D00
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x00006BAC File Offset: 0x00004DAC
		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			get
			{
				return this._ToolStripSeparator6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator6 = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00093B18 File Offset: 0x00091D18
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x00093B30 File Offset: 0x00091D30
		internal virtual ToolStripButton fpage
		{
			get
			{
				return this._fpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.fpage_Click);
				if (this._fpage != null)
				{
					this._fpage.Click -= value2;
				}
				this._fpage = value;
				if (this._fpage != null)
				{
					this._fpage.Click += value2;
				}
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00093B7C File Offset: 0x00091D7C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x00093B94 File Offset: 0x00091D94
		internal virtual ToolStripButton ppage
		{
			get
			{
				return this._ppage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ppage_Click);
				if (this._ppage != null)
				{
					this._ppage.Click -= value2;
				}
				this._ppage = value;
				if (this._ppage != null)
				{
					this._ppage.Click += value2;
				}
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00093BE0 File Offset: 0x00091DE0
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x00093BF8 File Offset: 0x00091DF8
		internal virtual ToolStripButton npage
		{
			get
			{
				return this._npage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.npage_Click);
				if (this._npage != null)
				{
					this._npage.Click -= value2;
				}
				this._npage = value;
				if (this._npage != null)
				{
					this._npage.Click += value2;
				}
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00093C44 File Offset: 0x00091E44
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00093C5C File Offset: 0x00091E5C
		internal virtual ToolStripButton lpage
		{
			get
			{
				return this._lpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lpage_Click);
				if (this._lpage != null)
				{
					this._lpage.Click -= value2;
				}
				this._lpage = value;
				if (this._lpage != null)
				{
					this._lpage.Click += value2;
				}
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00093CA8 File Offset: 0x00091EA8
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00006BB5 File Offset: 0x00004DB5
		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			get
			{
				return this._ToolStripSeparator5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator5 = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00093CC0 File Offset: 0x00091EC0
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00093CD8 File Offset: 0x00091ED8
		internal virtual ToolStripButton zdybutton
		{
			get
			{
				return this._zdybutton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.zdybutton_Click);
				if (this._zdybutton != null)
				{
					this._zdybutton.Click -= value2;
				}
				this._zdybutton = value;
				if (this._zdybutton != null)
				{
					this._zdybutton.Click += value2;
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00093D24 File Offset: 0x00091F24
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00006BBE File Offset: 0x00004DBE
		internal virtual ToolStripButton ToolStripButton1
		{
			get
			{
				return this._ToolStripButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripButton1 = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00093D3C File Offset: 0x00091F3C
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00006BC7 File Offset: 0x00004DC7
		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00093D54 File Offset: 0x00091F54
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x00006BD0 File Offset: 0x00004DD0
		internal virtual ToolTip ToolTip1
		{
			get
			{
				return this._ToolTip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00093D6C File Offset: 0x00091F6C
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00093D84 File Offset: 0x00091F84
		internal virtual ToolStripButton ZDYButton2
		{
			get
			{
				return this._ZDYButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.zdybutton2_Click);
				if (this._ZDYButton2 != null)
				{
					this._ZDYButton2.Click -= value2;
				}
				this._ZDYButton2 = value;
				if (this._ZDYButton2 != null)
				{
					this._ZDYButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00093DD0 File Offset: 0x00091FD0
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00093DE8 File Offset: 0x00091FE8
		internal virtual ToolStripSplitButton printd
		{
			get
			{
				return this._printd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.printd_ButtonClick);
				EventHandler value3 = new EventHandler(this.printd_DropDownOpening);
				if (this._printd != null)
				{
					this._printd.ButtonClick -= value2;
					this._printd.DropDownOpening -= value3;
				}
				this._printd = value;
				if (this._printd != null)
				{
					this._printd.ButtonClick += value2;
					this._printd.DropDownOpening += value3;
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00093E58 File Offset: 0x00092058
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00093E70 File Offset: 0x00092070
		internal virtual ToolStripMenuItem dy1
		{
			get
			{
				return this._dy1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy1_ButtonClick);
				if (this._dy1 != null)
				{
					this._dy1.Click -= value2;
				}
				this._dy1 = value;
				if (this._dy1 != null)
				{
					this._dy1.Click += value2;
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00093EBC File Offset: 0x000920BC
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00093ED4 File Offset: 0x000920D4
		internal virtual ToolStripMenuItem dy2
		{
			get
			{
				return this._dy2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy2_Click);
				if (this._dy2 != null)
				{
					this._dy2.Click -= value2;
				}
				this._dy2 = value;
				if (this._dy2 != null)
				{
					this._dy2.Click += value2;
				}
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00093F20 File Offset: 0x00092120
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00093F38 File Offset: 0x00092138
		internal virtual ToolStripMenuItem dy3
		{
			get
			{
				return this._dy3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy3_Click);
				if (this._dy3 != null)
				{
					this._dy3.Click -= value2;
				}
				this._dy3 = value;
				if (this._dy3 != null)
				{
					this._dy3.Click += value2;
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00093F84 File Offset: 0x00092184
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00093F9C File Offset: 0x0009219C
		internal virtual ToolStripSplitButton mysave
		{
			get
			{
				return this._mysave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mysave_Click);
				EventHandler value3 = new EventHandler(this.mysave_DropDownOpening);
				if (this._mysave != null)
				{
					this._mysave.ButtonClick -= value2;
					this._mysave.DropDownOpening -= value3;
				}
				this._mysave = value;
				if (this._mysave != null)
				{
					this._mysave.ButtonClick += value2;
					this._mysave.DropDownOpening += value3;
				}
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0009400C File Offset: 0x0009220C
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00094024 File Offset: 0x00092224
		internal virtual ToolStripMenuItem ToolStripMenuItem_15
		{
			get
			{
				return this.toolStripMenuItem_15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_15_Click);
				if (this.toolStripMenuItem_15 != null)
				{
					this.toolStripMenuItem_15.Click -= value2;
				}
				this.toolStripMenuItem_15 = value;
				if (this.toolStripMenuItem_15 != null)
				{
					this.toolStripMenuItem_15.Click += value2;
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00094070 File Offset: 0x00092270
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00094088 File Offset: 0x00092288
		internal virtual ToolStripMenuItem ToolStripMenuItem15
		{
			get
			{
				return this._ToolStripMenuItem15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mysave_Click);
				if (this._ToolStripMenuItem15 != null)
				{
					this._ToolStripMenuItem15.Click -= value2;
				}
				this._ToolStripMenuItem15 = value;
				if (this._ToolStripMenuItem15 != null)
				{
					this._ToolStripMenuItem15.Click += value2;
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000940D4 File Offset: 0x000922D4
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x000940EC File Offset: 0x000922EC
		internal virtual ToolStripMenuItem ToolStripMenuItem_16
		{
			get
			{
				return this.toolStripMenuItem_16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_16_Click);
				if (this.toolStripMenuItem_16 != null)
				{
					this.toolStripMenuItem_16.Click -= value2;
				}
				this.toolStripMenuItem_16 = value;
				if (this.toolStripMenuItem_16 != null)
				{
					this.toolStripMenuItem_16.Click += value2;
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00094138 File Offset: 0x00092338
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00006BD9 File Offset: 0x00004DD9
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			get
			{
				return this._ToolStripSeparator4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00094150 File Offset: 0x00092350
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00006BE2 File Offset: 0x00004DE2
		internal virtual ToolStripSeparator ToolStripMenuItem17
		{
			get
			{
				return this._ToolStripMenuItem17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem17 = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00094168 File Offset: 0x00092368
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00094180 File Offset: 0x00092380
		internal virtual ToolStripMenuItem dy5
		{
			get
			{
				return this._dy5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dy5_Click);
				if (this._dy5 != null)
				{
					this._dy5.Click -= value2;
				}
				this._dy5 = value;
				if (this._dy5 != null)
				{
					this._dy5.Click += value2;
				}
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000941CC File Offset: 0x000923CC
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x000941E4 File Offset: 0x000923E4
		internal virtual ToolStripMenuItem dy4
		{
			get
			{
				return this._dy4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem16_Click_1);
				if (this._dy4 != null)
				{
					this._dy4.Click -= value2;
				}
				this._dy4 = value;
				if (this._dy4 != null)
				{
					this._dy4.Click += value2;
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00094230 File Offset: 0x00092430
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00006BEB File Offset: 0x00004DEB
		internal virtual ToolStripSeparator savepdf
		{
			get
			{
				return this._savepdf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._savepdf = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00094248 File Offset: 0x00092448
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00094260 File Offset: 0x00092460
		internal virtual ToolStripMenuItem ToolStripMenuItem_17
		{
			get
			{
				return this.toolStripMenuItem_17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_17_Click);
				if (this.toolStripMenuItem_17 != null)
				{
					this.toolStripMenuItem_17.Click -= value2;
				}
				this.toolStripMenuItem_17 = value;
				if (this.toolStripMenuItem_17 != null)
				{
					this.toolStripMenuItem_17.Click += value2;
				}
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000942AC File Offset: 0x000924AC
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x000942C4 File Offset: 0x000924C4
		internal virtual ToolStripMenuItem ToolStripMenuItem_18
		{
			get
			{
				return this.toolStripMenuItem_18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_18_Click);
				if (this.toolStripMenuItem_18 != null)
				{
					this.toolStripMenuItem_18.Click -= value2;
				}
				this.toolStripMenuItem_18 = value;
				if (this.toolStripMenuItem_18 != null)
				{
					this.toolStripMenuItem_18.Click += value2;
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00094310 File Offset: 0x00092510
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x00094328 File Offset: 0x00092528
		internal virtual ToolStripMenuItem saveaspdfcur
		{
			get
			{
				return this._saveaspdfcur;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.saveaspdfcur_Click);
				if (this._saveaspdfcur != null)
				{
					this._saveaspdfcur.Click -= value2;
				}
				this._saveaspdfcur = value;
				if (this._saveaspdfcur != null)
				{
					this._saveaspdfcur.Click += value2;
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00094374 File Offset: 0x00092574
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0009438C File Offset: 0x0009258C
		internal virtual ToolStripMenuItem saveaspdfall
		{
			get
			{
				return this._saveaspdfall;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.saveaspdfall_Click);
				if (this._saveaspdfall != null)
				{
					this._saveaspdfall.Click -= value2;
				}
				this._saveaspdfall = value;
				if (this._saveaspdfall != null)
				{
					this._saveaspdfall.Click += value2;
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000943D8 File Offset: 0x000925D8
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00006BF4 File Offset: 0x00004DF4
		internal virtual ToolStripSeparator ToolStripSeparator7
		{
			get
			{
				return this._ToolStripSeparator7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator7 = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000943F0 File Offset: 0x000925F0
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00006BFD File Offset: 0x00004DFD
		internal virtual ToolStripSeparator ToolStripMenuItem16
		{
			get
			{
				return this._ToolStripMenuItem16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem16 = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00094408 File Offset: 0x00092608
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00094420 File Offset: 0x00092620
		internal virtual ToolStripMenuItem cgprint
		{
			get
			{
				return this._cgprint;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cgprint_Click);
				if (this._cgprint != null)
				{
					this._cgprint.Click -= value2;
				}
				this._cgprint = value;
				if (this._cgprint != null)
				{
					this._cgprint.Click += value2;
				}
			}
		}

		// Token: 0x060012F5 RID: 4853
		[DllImport("GDI32.dll")]
		public static extern int GetDeviceCaps(int hdc, int nIndex);

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002588 File Offset: 0x00000788
		public void GetInterfaceSafetyOptions(ref Guid riid, ref int supportedOptions, ref int enabledOptions)
		{
			supportedOptions = 3;
			enabledOptions = 3;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002590 File Offset: 0x00000790
		public void SetInterfaceSafetyOptions(ref Guid riid, int optionSetMask, int enabledOptions)
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060012F8 RID: 4856 RVA: 0x00006C06 File Offset: 0x00004E06
		// (remove) Token: 0x060012F9 RID: 4857 RVA: 0x00006C1F File Offset: 0x00004E1F
		[Description("在打印预览前发生（PrintDocument事件前发生），可以在此进行默认页面设置")]
		public event VB2008Print.QueryDefaultPageSettingsEventHandler QueryDefaultPageSettings;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060012FA RID: 4858 RVA: 0x00006C38 File Offset: 0x00004E38
		// (remove) Token: 0x060012FB RID: 4859 RVA: 0x00006C51 File Offset: 0x00004E51
		[Description("开始打印，可将要打印的代码写在此事件中（要对每页进行不同的页面设置，请在newpage中指定参数）")]
		public event VB2008Print.PrintDocumentEventHandler PrintDocument;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060012FC RID: 4860 RVA: 0x00006C6A File Offset: 0x00004E6A
		// (remove) Token: 0x060012FD RID: 4861 RVA: 0x00006C83 File Offset: 0x00004E83
		[Description("页眉页脚打印输出事件，在此事件中可以调用输出页眉页脚的函数打印页眉页脚")]
		public event VB2008Print.HeaderFooterOutEventHandler HeaderFooterOut;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060012FE RID: 4862 RVA: 0x00006C9C File Offset: 0x00004E9C
		// (remove) Token: 0x060012FF RID: 4863 RVA: 0x00006CB5 File Offset: 0x00004EB5
		public event VB2008Print.EndPrintToPrinterEventHandler EndPrintToPrinter;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001300 RID: 4864 RVA: 0x00006CCE File Offset: 0x00004ECE
		// (remove) Token: 0x06001301 RID: 4865 RVA: 0x00006CE7 File Offset: 0x00004EE7
		public event VB2008Print.BeginPrintEventHandler BeginPrint;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001302 RID: 4866 RVA: 0x00006D00 File Offset: 0x00004F00
		// (remove) Token: 0x06001303 RID: 4867 RVA: 0x00006D19 File Offset: 0x00004F19
		public event VB2008Print.EndPreViewEventHandler EndPreView;

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0009446C File Offset: 0x0009266C
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x00006D32 File Offset: 0x00004F32
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Image BackgroundImage
		{
			get
			{
				return base.BackgroundImage;
			}
			set
			{
				base.BackgroundImage = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00094484 File Offset: 0x00092684
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00006D3B File Offset: 0x00004F3B
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				base.BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0009449C File Offset: 0x0009269C
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00006D44 File Offset: 0x00004F44
		[Description("设置或获取一个值，用于指示控件在打印时的默认打印份数")]
		public short PrintCopys
		{
			get
			{
				return this._printcopys;
			}
			set
			{
				if (value > 0)
				{
					this._printcopys = value;
				}
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000944B4 File Offset: 0x000926B4
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x00006D51 File Offset: 0x00004F51
		[Description("设置或获取一个值，用于指示控件工具栏中的\u3000草稿打印\u3000按钮是否可用")]
		public bool EnablePrintDraft
		{
			get
			{
				return this.myenablecgprint;
			}
			set
			{
				this.myenablecgprint = value;
				this.cgprint.Enabled = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x000944C8 File Offset: 0x000926C8
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00006D66 File Offset: 0x00004F66
		[Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为PDF 功能是否可用")]
		public bool EnableSaveAsPDF
		{
			get
			{
				return this.myenablesaveaspdf;
			}
			set
			{
				this.myenablesaveaspdf = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x000944DC File Offset: 0x000926DC
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00006D6F File Offset: 0x00004F6F
		[Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为图片 功能是否可用")]
		public bool EnableSaveAsImage
		{
			get
			{
				return this.myenablesaveasimage;
			}
			set
			{
				this.myenablesaveasimage = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x000944F0 File Offset: 0x000926F0
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00006D78 File Offset: 0x00004F78
		[Description("设置或获取一个值，用于指示自动校正打印边距。该属性为5.8版新增加  注意：该值默认为true，一般来说，您也应该将该属性设置为true以解决打印预览结果与打印结果位置不一样的问题。 只有在特殊情况下比如原来使用以前版本的打印控件并且经实际打印测试调整好了页边距，为完整保留原打印效果，才将该属性设置为false")]
		public bool IsAutoAdjustPrinterMargin
		{
			get
			{
				return this.myisautoadjustprintermargin;
			}
			set
			{
				this.myisautoadjustprintermargin = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00094504 File Offset: 0x00092704
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00006D81 File Offset: 0x00004F81
		[Description("设置或获取X位置的偏移，以PageUnits指定的值为计量单位，正数表示向右偏移，负数表示向左偏移")]
		public float OffsetX
		{
			get
			{
				return this.myPYx;
			}
			set
			{
				this.myPYx = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0009451C File Offset: 0x0009271C
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x00006D8A File Offset: 0x00004F8A
		[Description("设置或获取Y位置的偏移，以PageUnits指定的值为计量单位，正数表示向下偏移，负数表示向上偏移")]
		public float OffsetY
		{
			get
			{
				return this.myPYy;
			}
			set
			{
				this.myPYy = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00094534 File Offset: 0x00092734
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00006D93 File Offset: 0x00004F93
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("指示是否需要处理HeaderFooterOut事件（即是否需要打印页眉与页脚、装订线与水印），如果不需要打印页眉、页脚、水印、装订线，则可以将该属性设置为false，这样可以提高速度。默认情况下，该属性为true")]
		public bool IsNeedPrintPageHeaderAndFooter
		{
			get
			{
				return this.myisneedprintpageheaderandfooter;
			}
			set
			{
				this.myisneedprintpageheaderandfooter = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00094548 File Offset: 0x00092748
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00094564 File Offset: 0x00092764
		[Description("纸张背景颜色，也即除纸张外的其余部分的背景颜色")]
		public Color PaperBackColor
		{
			get
			{
				return this.PrintPreviewControl1.BackColor;
			}
			set
			{
				this.PrintPreviewControl1.BackColor = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00094580 File Offset: 0x00092780
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x0009459C File Offset: 0x0009279C
		[Description("前景颜色（也就是打印预览结果中纸张显示的背景颜色，仅对预览有效，不会打印出来）")]
		public Color PaperForeColor
		{
			get
			{
				return this.PrintPreviewControl1.ForeColor;
			}
			set
			{
				this.PrintPreviewControl1.ForeColor = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x000945B8 File Offset: 0x000927B8
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00006D9C File Offset: 0x00004F9C
		[Description("表格外边框颜色，仅当OuterBorder为True时有效")]
		public Color OuterBorderColor
		{
			get
			{
				return this.myouterbordercolor;
			}
			set
			{
				this.myouterbordercolor = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x000945D0 File Offset: 0x000927D0
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00006DA5 File Offset: 0x00004FA5
		[Description("表格外边框宽度，以PageUnits指定的值为计量单位，仅当OuterBorder为True时有效")]
		public float OuterBorderWidth
		{
			get
			{
				return this.myouterborderwidth;
			}
			set
			{
				if (value >= 0f)
				{
					this.myouterborderwidth = value;
				}
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000945E8 File Offset: 0x000927E8
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00006DB6 File Offset: 0x00004FB6
		[Description("指示在用PrintDGV等函数打印DataGridView时，是否在表格外添加外边框。")]
		public bool OuterBorder
		{
			get
			{
				return this.myouterborder;
			}
			set
			{
				this.myouterborder = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000945FC File Offset: 0x000927FC
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00006DBF File Offset: 0x00004FBF
		[Description("设置或获取双线条打印DGV时双线之间的间距（以PageUnits指定的值为计量单位），仅当以双线条样式调用PrintDGV等函数打印DataGridView时有效（将属性IsUseDoubleLine为true）")]
		public float DoubleLineSpace
		{
			get
			{
				return this.thedoublelinespace;
			}
			set
			{
				if (value >= 0f & value < 10000f)
				{
					this.thedoublelinespace = value;
				}
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00094614 File Offset: 0x00092814
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00006DDE File Offset: 0x00004FDE
		[Description("指定在调用PrintDGV等函数打印DataGridView时，是否使用双线框打印")]
		public bool IsUseDoubleLine
		{
			get
			{
				return this.myisusedoubleline;
			}
			set
			{
				this.myisusedoubleline = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x00094628 File Offset: 0x00092828
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00006DE7 File Offset: 0x00004FE7
		[Description("指示打印DataGridView时(如用PrintDGV、PrintDGVPages等函数在指定了表格页脚的情况下,对多栏打印PrintGVCols函数有的情况下无效，对工资条形式打印函数无效），表格页脚是否每一页都打印。为True表示每一页都打印表格页脚，为False表示仅表格的最后一页打印")]
		public bool IsDrawTableFooterEveryPage
		{
			get
			{
				return this.myisdrawtablefootereverypage;
			}
			set
			{
				this.myisdrawtablefootereverypage = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0009463C File Offset: 0x0009283C
		[Browsable(false)]
		[Description("获取一个值，用于指示是否在生成打印预览期间，用户是否单击状态窗口中的取消按钮，取消打印预览的生成")]
		public bool CancelDocument
		{
			get
			{
				return Module1.G_CancelDocument;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00094650 File Offset: 0x00092850
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00006DF0 File Offset: 0x00004FF0
		[Description("指示打印DataGridView时，是否自动加添空行以正好填满纸张高度。注意，对工资条打印无效，分栏打印可以自动添加空行，但此时请不要设置表格页脚，不然表格页脚打印位置不正确")]
		public bool IsAutoAddEmptyRow
		{
			get
			{
				return this.myisautoaddemptyrow;
			}
			set
			{
				this.myisautoaddemptyrow = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00094664 File Offset: 0x00092864
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00006DF9 File Offset: 0x00004FF9
		[Browsable(false)]
		public bool IsShowErrorMSG
		{
			get
			{
				return this.myisshowerrormsg;
			}
			set
			{
				this.myisshowerrormsg = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00094678 File Offset: 0x00092878
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00006E02 File Offset: 0x00005002
		[Description("在使用DrawCell、DrawText、DrawMultiCell函数进行打印输出时，打印输出前是先自动检查是否需要换页才能打印。如果为True，则在使用这几个函数进行打印前，先检查当前Y位置（不检查X位置）是否超出打印范围需要换页，如果需要则自动换页，再进行打印输出；如果为False则不检测，自动在当前位置继续输出，不管输出结果会不会处在页面范围之外")]
		public bool IsNeedCheckNewPage
		{
			get
			{
				return this.myisneedchecknewpage;
			}
			set
			{
				this.myisneedchecknewpage = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0009468C File Offset: 0x0009288C
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00006E0B File Offset: 0x0000500B
		[Description("是否在页眉与正文之间画一条横线，以便区分页眉与正文")]
		public bool IsDrawPageHeaderLine
		{
			get
			{
				return this.myisdrawpageheaderline;
			}
			set
			{
				this.myisdrawpageheaderline = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000946A0 File Offset: 0x000928A0
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x00006E14 File Offset: 0x00005014
		[Description("是否在正文与页脚之间画一条横线，以便区分正文与页脚")]
		public bool IsDrawPageFooterLine
		{
			get
			{
				return this.myisdrawpagefooterline;
			}
			set
			{
				this.myisdrawpagefooterline = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000946B4 File Offset: 0x000928B4
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x00006E1D File Offset: 0x0000501D
		[Description("获取或设置一个值,用于指示是否容许在打印预览界面显示右键快捷菜单")]
		public bool IsShowContextMenu
		{
			get
			{
				return this.myisshowcontextmenu;
			}
			set
			{
				this.myisshowcontextmenu = value;
				if (this.myisshowcontextmenu)
				{
					this.PrintPreviewControl1.ContextMenuStrip = this.ContextMenuStrip1;
				}
				else
				{
					this.PrintPreviewControl1.ContextMenuStrip = null;
				}
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000946C8 File Offset: 0x000928C8
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00006E4D File Offset: 0x0000504D
		[Description("设置要打印水印的文字,为空字符串表示不打印水印")]
		public string WaterMarkText
		{
			get
			{
				return this.mywatermarktext;
			}
			set
			{
				this.mywatermarktext = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x000946E0 File Offset: 0x000928E0
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00006E56 File Offset: 0x00005056
		[Description("设置要打印的水印文字的字体字号")]
		public Font WaterMarkFont
		{
			get
			{
				Font result;
				if (this.mywatermarkfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.mywatermarkfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.mywatermarkfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0009470C File Offset: 0x0009290C
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00006E6C File Offset: 0x0000506C
		[Description("设置要打印的水印的文字方向,TRUE表示水印文字横着打印,为FALSE表示水印文字竖着打印")]
		public bool WaterMarkLandscape
		{
			get
			{
				return this.mywatermarklandscape;
			}
			set
			{
				this.mywatermarklandscape = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00094720 File Offset: 0x00092920
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00006E75 File Offset: 0x00005075
		[Description("设置要打印的水印文本的透明程度,0表示完全透明,255表示完全不透明")]
		public byte WaterMarkOpacity
		{
			get
			{
				return this.mywatermarkopacity;
			}
			set
			{
				this.mywatermarkopacity = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00094738 File Offset: 0x00092938
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00006E7E File Offset: 0x0000507E
		[Description("设置要打印的水印的文字的前景颜色")]
		public Color WaterMarkColor
		{
			get
			{
				return this.mywatermarkcolor;
			}
			set
			{
				this.mywatermarkcolor = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00094750 File Offset: 0x00092950
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00006E87 File Offset: 0x00005087
		[Description("指示是否显示打印预览前程序预处理的进度条")]
		public bool IsShowProgess
		{
			get
			{
				return this.myisshowprogress;
			}
			set
			{
				this.myisshowprogress = value;
				this.PrintPreviewControl1.IsShowprocessDialog = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00094764 File Offset: 0x00092964
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x00006E9C File Offset: 0x0000509C
		[Description("设置或获取一个值，指示如果打印机不支持当前所使用的纸张，在输出到打印机前是否给出提示信息")]
		public bool IsShowMessageIfPrinterNotSupportPaper
		{
			get
			{
				return this.myIsShowMessageIfPrinterNotSupportPaper;
			}
			set
			{
				this.myIsShowMessageIfPrinterNotSupportPaper = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00094778 File Offset: 0x00092978
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x00006EA5 File Offset: 0x000050A5
		[Description("指示是否使用调用API函数的页面设置和打印机选择对话框，为TRUE表示使用API的，为FALSE表示使用.NET自身的。如果没计划使用自定义纸张进行打印，建议设置为FALSE")]
		public bool IsUseAPIprintDialog
		{
			get
			{
				return this.myisuseAPIprintDialog;
			}
			set
			{
				this.myisuseAPIprintDialog = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x0009478C File Offset: 0x0009298C
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x000947A8 File Offset: 0x000929A8
		[Description("设置或获取打印所用的纸张(纸张大小总是以百分之一英寸为单位),与PaperKind属性的区别是,此属性允许使用自定义纸张")]
		public PaperSize PaperSize
		{
			get
			{
				return this.mypagesetting.PaperSize;
			}
			set
			{
				if (!this.isstarting && value != null)
				{
					if (value.Width <= 0 | value.Height <= 0)
					{
						value = definepaper.GetPrintForm(this.GetCurrentPrinterName(), value.PaperName);
					}
					if (value != null)
					{
						try
						{
							if (Operators.CompareString(value.PaperName, "", false) == 0)
							{
								value.PaperName = "用户自定义(空名称)";
							}
						}
						catch (Exception ex)
						{
						}
						this.mypagesetting.PaperSize = value;
					}
				}
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0009483C File Offset: 0x00092A3C
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00006EAE File Offset: 0x000050AE
		[Description("如果IsImmediatePrintNotPreview为TRUE，指示在打印前是否显示打印机选择的对话框，为TRUE表示要显示，为FALSE表示不显示，使用当前打印机立即输出到打印机。")]
		public bool IsImmediatePrintNotPreviewShowPrintDialog
		{
			get
			{
				return this.myIsImmediatePrintNotPreviewShowPrintDialog;
			}
			set
			{
				this.myIsImmediatePrintNotPreviewShowPrintDialog = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00094850 File Offset: 0x00092A50
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00006EB7 File Offset: 0x000050B7
		[Description("指示在预处理完成后是否立即调用print方法进行打印而不再在预览中显示出来")]
		public bool IsImmediatePrintNotPreview
		{
			get
			{
				return this.myisimmediateprintnotpreview;
			}
			set
			{
				this.myisimmediateprintnotpreview = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00094864 File Offset: 0x00092A64
		[Browsable(false)]
		public bool IsEndPreview
		{
			get
			{
				return this.myisendpreview;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00094878 File Offset: 0x00092A78
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00006EC0 File Offset: 0x000050C0
		[Description("打印DataGridView时,单元格文本垂直对齐方式是统一使用居中对齐打印,还是和水平对齐一样都使用DataGridView单元格本身的格式设置")]
		public bool IsDGVCellValignmentCenter
		{
			get
			{
				return this.myIsDGVCellValignmentCenter;
			}
			set
			{
				this.myIsDGVCellValignmentCenter = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0009488C File Offset: 0x00092A8C
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00006EC9 File Offset: 0x000050C9
		[Description("用DrawText、DrawCell等函数打印输出文字时，如果最后一个参数textoutstyle不为0(即输出除普通文字外的其他形式的特效文字时),要打印特效文字的深度,计量单位为打印控件的当前单位")]
		public int ShapeDepth
		{
			get
			{
				return this.myshapedepth;
			}
			set
			{
				this.myshapedepth = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000948A4 File Offset: 0x00092AA4
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x000948D8 File Offset: 0x00092AD8
		[Description("获取或设置一个值，该值指示页面的显示大小，值为 1.0 指示实际大小，为0表示自适应纸张大小,最大值为10(即最大放大10倍)")]
		public double Zoom
		{
			get
			{
				double result;
				if (this.PrintPreviewControl1.AutoZoom)
				{
					result = 0.0;
				}
				else
				{
					result = this.PrintPreviewControl1.Zoom;
				}
				return result;
			}
			set
			{
				if (value >= 0.0)
				{
					if (value * 100.0 < 3.0)
					{
						value = 0.03;
					}
					if (value > 10.0)
					{
						value = 10.0;
					}
					this.ToolStripMenuItem.Checked = false;
					this.ToolStripMenuItem0.Checked = false;
					this.ToolStripMenuItem1.Checked = false;
					this.ToolStripMenuItem2.Checked = false;
					this.ToolStripMenuItem3.Checked = false;
					this.ToolStripMenuItem4.Checked = false;
					this.ToolStripMenuItem5.Checked = false;
					this.ToolStripMenuItem6.Checked = false;
					this.ToolStripMenuItem7.Checked = false;
					this.ToolStripMenuItem8.Checked = false;
					this.ToolStripMenuItem9.Checked = false;
					this.ToolStripMenuItem10.Checked = false;
					this.ToolStripMenuItem11.Checked = false;
					this.PrintPreviewControl1.AutoZoom = false;
					double num = value;
					if (num == 0.0)
					{
						this.PrintPreviewControl1.AutoZoom = true;
						this.ToolStripMenuItem10.Checked = true;
					}
					else
					{
						if (num == 0.1)
						{
							this.ToolStripMenuItem11.Checked = true;
						}
						else if (num == 0.25)
						{
							this.ToolStripMenuItem.Checked = true;
						}
						else if (num == 0.5)
						{
							this.ToolStripMenuItem0.Checked = true;
						}
						else if (num == 0.75)
						{
							this.ToolStripMenuItem1.Checked = true;
						}
						else if (num == 1.0)
						{
							this.ToolStripMenuItem2.Checked = true;
						}
						else if (num == 1.25)
						{
							this.ToolStripMenuItem3.Checked = true;
						}
						else if (num == 1.5)
						{
							this.ToolStripMenuItem4.Checked = true;
						}
						else if (num == 2.0)
						{
							this.ToolStripMenuItem5.Checked = true;
						}
						else if (num == 2.5)
						{
							this.ToolStripMenuItem6.Checked = true;
						}
						else if (num == 3.0)
						{
							this.ToolStripMenuItem7.Checked = true;
						}
						else if (num == 4.0)
						{
							this.ToolStripMenuItem8.Checked = true;
						}
						else if (num == 5.0)
						{
							this.ToolStripMenuItem9.Checked = true;
						}
						try
						{
							this.PrintPreviewControl1.Zoom = value;
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00094B78 File Offset: 0x00092D78
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00094B8C File Offset: 0x00092D8C
		[Description("设置或获取一个值，用于指示打印预览结果在有多页的情况下，是以'单页方式'还是'连续显示方式'显示打印预览结果。为true表示连续显示，为false表示单页显示")]
		public bool IsShowPageContinues
		{
			get
			{
				return this.myisshowpagecontinues;
			}
			set
			{
				this.myisshowpagecontinues = value;
				if (value)
				{
					this.mytype1.Checked = true;
					this.mytype2.Checked = false;
				}
				else
				{
					this.mytype1.Checked = false;
					this.mytype2.Checked = true;
				}
				this.SetPages();
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06001354 RID: 4948 RVA: 0x00006ED2 File Offset: 0x000050D2
		// (remove) Token: 0x06001355 RID: 4949 RVA: 0x00006EEB File Offset: 0x000050EB
		[Description("工具栏中自定义按钮的单击事件")]
		public event VB2008Print.ZDYButtonClickEventHandler ZDYButtonClick;

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00094BDC File Offset: 0x00092DDC
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x00006F04 File Offset: 0x00005104
		[Description("工具栏中自定义的按钮是否可见")]
		public bool ZDYButtonVisible
		{
			get
			{
				return this.myiszdybuttonvisible;
			}
			set
			{
				this.myiszdybuttonvisible = value;
				this.zdybutton.Visible = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00094BF0 File Offset: 0x00092DF0
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00006F19 File Offset: 0x00005119
		[Description("工具栏中自定义按钮显示的按钮文本")]
		public string ZDYButtonText
		{
			get
			{
				return this.zdybutton.Text;
			}
			set
			{
				this.zdybutton.Text = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00094C0C File Offset: 0x00092E0C
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00006F27 File Offset: 0x00005127
		[Description("工具栏中自定义按钮显示的按钮提示文本")]
		public string ZDYButtonToolTipText
		{
			get
			{
				return this.zdybutton.ToolTipText;
			}
			set
			{
				this.zdybutton.ToolTipText = value;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600135C RID: 4956 RVA: 0x00006F35 File Offset: 0x00005135
		// (remove) Token: 0x0600135D RID: 4957 RVA: 0x00006F4E File Offset: 0x0000514E
		[Description("工具栏中自定义按钮2的单击事件")]
		public event VB2008Print.ZDYButton2ClickEventHandler ZDYButton2Click;

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00094C28 File Offset: 0x00092E28
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00006F67 File Offset: 0x00005167
		[Description("工具栏中自定义按钮2是否可见")]
		public bool ZDYButton2Visible
		{
			get
			{
				return this.myiszdybutton2visible;
			}
			set
			{
				this.myiszdybutton2visible = value;
				this.ZDYButton2.Visible = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00094C3C File Offset: 0x00092E3C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00006F7C File Offset: 0x0000517C
		[Description("工具栏中自定义按钮2显示的按钮文本")]
		public string ZDYButton2Text
		{
			get
			{
				return this.ZDYButton2.Text;
			}
			set
			{
				this.ZDYButton2.Text = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00094C58 File Offset: 0x00092E58
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x00006F8A File Offset: 0x0000518A
		[Description("工具栏中自定义按钮2显示的按钮提示文本")]
		public string ZDYButton2ToolTipText
		{
			get
			{
				return this.ZDYButton2.ToolTipText;
			}
			set
			{
				this.ZDYButton2.ToolTipText = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00094C74 File Offset: 0x00092E74
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x00006F98 File Offset: 0x00005198
		[Description("设置页面输出单位,CentiMeter表示1/100厘米，Inch表示1/100英寸")]
		public VB2008Print.PageExportUnit PageUnits
		{
			get
			{
				return this.mypageunits;
			}
			set
			{
				this.mypageunits = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00094C8C File Offset: 0x00092E8C
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00006FA1 File Offset: 0x000051A1
		[Description("指示在发送到打印机打印时，是否显示一个指示正在打印的状态窗口")]
		public bool IsShowPrintStatusDialog
		{
			get
			{
				return this.myishowprintstatusdialog;
			}
			set
			{
				this.myishowprintstatusdialog = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00094CA0 File Offset: 0x00092EA0
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00006FAA File Offset: 0x000051AA
		[Description("是否使用操作系统的防锯齿功能，使用操作系统的防锯齿功能可能提高打印预览的显示效果，但速度较慢")]
		public bool UseAntiAlias
		{
			get
			{
				return this.PrintPreviewControl1.UseAntiAlias;
			}
			set
			{
				this.PrintPreviewControl1.UseAntiAlias = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00094CB8 File Offset: 0x00092EB8
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00006FB8 File Offset: 0x000051B8
		[Description("设置或获取一个值，用于指示控件工具栏中的 打印 按钮是否可用，为true表示可用，为false表示不可用")]
		public bool EnabledPrint
		{
			get
			{
				return this.myenabledprint;
			}
			set
			{
				this.myenabledprint = value;
				if (value)
				{
					this.printd.Enabled = true;
					this.printd.Visible = true;
				}
				else
				{
					this.printd.Enabled = false;
					this.printd.Visible = false;
				}
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00094CCC File Offset: 0x00092ECC
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00006FF6 File Offset: 0x000051F6
		[Description("工具栏中的页面设置按钮是否可用")]
		public bool EnabledPageSetting
		{
			get
			{
				return this.myenabledpagesetting;
			}
			set
			{
				this.myenabledpagesetting = value;
				if (value)
				{
					this.pagesetup.Enabled = true;
					this.pagesetup.Visible = true;
				}
				else
				{
					this.pagesetup.Enabled = false;
					this.pagesetup.Visible = false;
				}
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00094CE0 File Offset: 0x00092EE0
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00007034 File Offset: 0x00005234
		[Description("指示在打印DataGridView时，是否使用DGV本身的DefaultCellStyle .Padding 指定的值做为单元格边距。如果为True,表示是，如果为False,则表示使用本控件的CellMargin属性指定的值作为打印DGV是的单元格边距")]
		public bool IsUseDGVPadding
		{
			get
			{
				return this.myisusedgvpadding;
			}
			set
			{
				this.myisusedgvpadding = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00094CF4 File Offset: 0x00092EF4
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00094D70 File Offset: 0x00092F70
		[Description("单元格边距")]
		public Margins CellMargin
		{
			get
			{
				Margins margins = new Margins();
				try
				{
					margins.Left = this.myCellmargin.Left;
					margins.Bottom = this.myCellmargin.Bottom;
					margins.Top = this.myCellmargin.Top;
					margins.Right = this.myCellmargin.Right;
				}
				catch (Exception ex)
				{
				}
				return margins;
			}
			set
			{
				try
				{
					this.myCellmargin.Left = value.Left;
					this.myCellmargin.Right = value.Right;
					this.myCellmargin.Bottom = value.Bottom;
					this.myCellmargin.Top = value.Top;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00094DE4 File Offset: 0x00092FE4
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000703D File Offset: 0x0000523D
		[Description("设置或获取一个值，指示是否在打印预览时画出页边距")]
		public bool IsDrawmargin
		{
			get
			{
				return this.myisdrawmargin;
			}
			set
			{
				this.myisdrawmargin = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00094DF8 File Offset: 0x00092FF8
		[Browsable(false)]
		public float LastDrawTextHeight
		{
			get
			{
				return this.MyConvFrom(this.mylastdrawtextheight);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00094E14 File Offset: 0x00093014
		[Browsable(false)]
		public float LastDrawTextWidth
		{
			get
			{
				return this.MyConvFrom(this.mylastdrawtextwidth);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00094E30 File Offset: 0x00093030
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00007046 File Offset: 0x00005246
		[Description("打印预览窗口工具栏是否可见")]
		public bool ToolBarVisible
		{
			get
			{
				return this.myistoolbarvisible;
			}
			set
			{
				this.myistoolbarvisible = value;
				this.ToolStrip1.Visible = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00094E44 File Offset: 0x00093044
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000705B File Offset: 0x0000525B
		[Description("是否允许打开报表文件")]
		public bool CanOpenReport
		{
			get
			{
				return this.mycanopenreport;
			}
			set
			{
				this.mycanopenreport = value;
				if (value)
				{
					this.myopen.Enabled = true;
					this.myopen.Visible = true;
				}
				else
				{
					this.myopen.Enabled = false;
					this.myopen.Visible = false;
				}
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x00094E58 File Offset: 0x00093058
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x00007099 File Offset: 0x00005299
		[Description("是否允许保存预览显示结果为报表文件")]
		public bool CanSaveReport
		{
			get
			{
				return this.mycansavereport;
			}
			set
			{
				this.mycansavereport = value;
				if (value)
				{
					this.mysave.Enabled = true;
					this.mysave.Visible = true;
				}
				else
				{
					this.mysave.Enabled = false;
					this.mysave.Visible = false;
				}
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00094E6C File Offset: 0x0009306C
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x00094F24 File Offset: 0x00093124
		[Description("指定页面边距")]
		public Margins PaperMargins
		{
			get
			{
				Margins margins = new Margins();
				checked
				{
					Margins result;
					if (this.mypagesetting == null)
					{
						result = margins;
					}
					else
					{
						margins.Left = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Left));
						margins.Top = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Top));
						margins.Bottom = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Bottom));
						margins.Right = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Right));
						result = margins;
					}
					return result;
				}
			}
			set
			{
				checked
				{
					if (!this.isstarting)
					{
						this.mypagesetting.Margins.Left = (int)Math.Round((double)this.MyConvTo((float)value.Left));
						this.mypagesetting.Margins.Top = (int)Math.Round((double)this.MyConvTo((float)value.Top));
						this.mypagesetting.Margins.Bottom = (int)Math.Round((double)this.MyConvTo((float)value.Bottom));
						this.mypagesetting.Margins.Right = (int)Math.Round((double)this.MyConvTo((float)value.Right));
						this.Pd.DefaultPageSettings = this.mypagesetting;
					}
				}
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00094FE0 File Offset: 0x000931E0
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x00095000 File Offset: 0x00093200
		[Description("指定纸张类型")]
		public PaperKind PaperKind
		{
			get
			{
				return this.mypagesetting.PaperSize.Kind;
			}
			set
			{
				if (!this.isstarting)
				{
					try
					{
						foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
						{
							PaperSize paperSize = (PaperSize)obj;
							if (paperSize.Kind == value)
							{
								this.mypagesetting.PaperSize = paperSize;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.Pd.DefaultPageSettings = this.mypagesetting;
				}
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00095090 File Offset: 0x00093290
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x000950B8 File Offset: 0x000932B8
		[Description("设置纸张打印方向")]
		public bool PaperLandscape
		{
			get
			{
				return this.mypagesetting != null && this.mypagesetting.Landscape;
			}
			set
			{
				if (!this.isstarting)
				{
					try
					{
						this.mypagesetting.Landscape = value;
						this.Pd.DefaultPageSettings = this.mypagesetting;
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0009510C File Offset: 0x0009330C
		public float PaperWidth
		{
			get
			{
				float result;
				try
				{
					if (!this.PaperLandscape)
					{
						result = this.MyConvFrom(this.myPaperWidth[this.currentpage]);
					}
					else
					{
						result = this.MyConvFrom(this.myPaperHeight[this.currentpage]);
					}
				}
				catch (Exception ex)
				{
					try
					{
						if (!this.PaperLandscape)
						{
							result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Width);
							ProjectData.ClearProjectError();
						}
						else
						{
							result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Height);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception ex2)
					{
						result = 0f;
					}
				}
				return result;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000951CC File Offset: 0x000933CC
		public float PaperHeight
		{
			get
			{
				float result;
				try
				{
					if (!this.PaperLandscape)
					{
						result = this.MyConvFrom(this.myPaperHeight[this.currentpage]);
					}
					else
					{
						result = this.MyConvFrom(this.myPaperWidth[this.currentpage]);
					}
				}
				catch (Exception ex)
				{
					try
					{
						if (!this.PaperLandscape)
						{
							result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Height);
							ProjectData.ClearProjectError();
						}
						else
						{
							result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Width);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception ex2)
					{
						result = 0f;
					}
				}
				return result;
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0009528C File Offset: 0x0009348C
		private void SavePaperHeightAndWidth(PaperSize tt)
		{
			checked
			{
				if (!(this.currentpage > this.GetPages() | this.currentpage < 0))
				{
					if (this.myPaperHeight == null | this.myPaperWidth == null)
					{
						this.myPaperHeight = (float[])Utils.CopyArray((Array)this.myPaperHeight, new float[this.GetPages() + 1]);
						this.myPaperWidth = (float[])Utils.CopyArray((Array)this.myPaperWidth, new float[this.GetPages() + 1]);
					}
					else if (this.myPaperHeight.Length <= this.GetPages())
					{
						this.myPaperHeight = (float[])Utils.CopyArray((Array)this.myPaperHeight, new float[this.GetPages() + 1]);
						this.myPaperWidth = (float[])Utils.CopyArray((Array)this.myPaperWidth, new float[this.GetPages() + 1]);
					}
					this.myPaperHeight[this.currentpage] = (float)tt.Height;
					this.myPaperWidth[this.currentpage] = (float)tt.Width;
				}
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x000953A8 File Offset: 0x000935A8
		[Browsable(false)]
		public float PaperPrintWidth
		{
			get
			{
				return this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000953D8 File Offset: 0x000935D8
		[Browsable(false)]
		public float PaperPrintHeight
		{
			get
			{
				return this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00095408 File Offset: 0x00093608
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x000070D7 File Offset: 0x000052D7
		[Description("默认前景颜色，在打印输出函数中没有指定前景颜色对象时，将使用该属性所指定的前景颜色进行打印输出")]
		public Color TextColor
		{
			get
			{
				return this.myforecolor;
			}
			set
			{
				this.myforecolor = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00095420 File Offset: 0x00093620
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x000070E0 File Offset: 0x000052E0
		[Description("默认字体格式，在打印输出函数中没有指定字体对象时，将使用该对象所确定的字体格式进行打印输出")]
		public Font TextFont
		{
			get
			{
				Font result;
				if (this.myfont == null)
				{
					result = null;
				}
				else
				{
					try
					{
						result = (Font)this.myfont.Clone();
					}
					catch (Exception ex)
					{
						result = null;
					}
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					this.myfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00095470 File Offset: 0x00093670
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x000070F6 File Offset: 0x000052F6
		[Browsable(false)]
		public float Currentx
		{
			get
			{
				return this.MyConvFrom(this.mycurrentx);
			}
			set
			{
				this.mycurrentx = this.MyConvTo(value);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0009548C File Offset: 0x0009368C
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00007105 File Offset: 0x00005305
		[Browsable(false)]
		public float Currenty
		{
			get
			{
				return this.MyConvFrom(this.mycurrenty);
			}
			set
			{
				this.mycurrenty = this.MyConvTo(value);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x000954A8 File Offset: 0x000936A8
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00007114 File Offset: 0x00005314
		[Description("设置打印文档名称，该名称将显示在打印机打印任务的文档名称栏中")]
		public string DocumentName
		{
			get
			{
				return this.myDocumentName;
			}
			set
			{
				this.myDocumentName = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x000954C0 File Offset: 0x000936C0
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0000711D File Offset: 0x0000531D
		[Description("获取或设置页面实际打印的缩放比例，为1表示100%比例。注意，该属性与Zoom属性的区别，Zoom的大小只影响屏幕显示比例，而此属性只影响实际打印比例。")]
		public float PageScale
		{
			get
			{
				return this.mypagescale;
			}
			set
			{
				if (value >= 0f)
				{
					if (value == 0f)
					{
						this.mypagescale = 1f;
					}
					this.mypagescale = value;
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x000954D8 File Offset: 0x000936D8
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00007141 File Offset: 0x00005341
		[Description("设置或获取一个值，用于指定是否打印装订线")]
		public bool IsDrawZDX
		{
			get
			{
				return this.myisdrawZDX;
			}
			set
			{
				this.myisdrawZDX = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000954EC File Offset: 0x000936EC
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x0000714A File Offset: 0x0000534A
		[Description("装订线的类型，是靠纸张的左边、上边、右边、下边的哪一边装订")]
		public VB2008Print.TheZDXTYPE ZDXType
		{
			get
			{
				return this.myZDXtype;
			}
			set
			{
				this.myZDXtype = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00095504 File Offset: 0x00093704
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x00007153 File Offset: 0x00005353
		[Description("指定装订线距纸张边界的大小（以PageUnits指定的值为计量单位）。为0表示打印在页边距的中间，为其他值则表示距纸张边界的距离")]
		public float ZDXPosition
		{
			get
			{
				return this.MyConvFrom(this.myZDXposition);
			}
			set
			{
				this.myZDXposition = this.MyConvTo(value);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00095520 File Offset: 0x00093720
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00007162 File Offset: 0x00005362
		[Description("要打印的装订线中线条的类型")]
		public DashStyle ZDXLineStyle
		{
			get
			{
				return this.myZDXlinestyle;
			}
			set
			{
				this.myZDXlinestyle = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00095538 File Offset: 0x00093738
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x0000716B File Offset: 0x0000536B
		[Description("装订线线条的颜色")]
		public Color ZDXLinecoLor
		{
			get
			{
				return this.myZDXlinecolor;
			}
			set
			{
				this.myZDXlinecolor = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00095550 File Offset: 0x00093750
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x00007174 File Offset: 0x00005374
		[Description("装订线文本的打印颜色")]
		public Color ZDXTextColor
		{
			get
			{
				return this.myZDXtextcolor;
			}
			set
			{
				this.myZDXtextcolor = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00095568 File Offset: 0x00093768
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00095594 File Offset: 0x00093794
		[Description("装订线中文本打印的字体")]
		public Font ZDXFont
		{
			get
			{
				Font result;
				if (this.myZDXfont == null)
				{
					result = null;
				}
				else
				{
					result = (Font)this.myZDXfont.Clone();
				}
				return result;
			}
			set
			{
				if (value != null)
				{
					try
					{
						this.myZDXfont = (Font)value.Clone();
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000955D8 File Offset: 0x000937D8
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x0000717D File Offset: 0x0000537D
		[Description("装订线中要打印的文本内容")]
		public string ZDXText
		{
			get
			{
				return this.myZDXtext;
			}
			set
			{
				this.myZDXtext = value;
				this.myZDXtext = this.myZDXtext.Replace("\r\n", "");
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x000955F0 File Offset: 0x000937F0
		private void PrintZDX()
		{
			if (this.IsDrawZDX && !this.CancelDocument)
			{
				this.r_font = null;
				this.Currentx = 0f;
				Pen pen = new Pen(this.ZDXLinecoLor);
				bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
				this.IsNeedCheckNewPage = false;
				pen.DashStyle = this.ZDXLineStyle;
				switch (this.ZDXType)
				{
					case VB2008Print.TheZDXTYPE.TOP:
						{
							float num;
							if (this.ZDXPosition <= 0f)
							{
								num = (float)((double)this.PaperMargins.Top / 2.0 - (double)this.PaperMargins.Top);
							}
							else
							{
								num = this.ZDXPosition - (float)this.PaperMargins.Top;
							}
							float num2 = 0f;
							float x = this.PaperPrintWidth;
							float y = num;
							this.DrawLine(pen, num2, num, x, y);
							float num3 = this.MeasureText("测", this.ZDXFont).Height;
							this.Currentx = num2;
							this.Currenty = num - num3 / 2f;
							this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, true, true, this.PaperPrintWidth, num3, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
							break;
						}
					case VB2008Print.TheZDXTYPE.RIGHT:
						{
							float num2;
							if (this.ZDXPosition <= 0f)
							{
								num2 = (float)((double)this.PaperPrintWidth + (double)this.PaperMargins.Right / 2.0);
							}
							else
							{
								num2 = this.PaperPrintWidth + ((float)this.PaperMargins.Right - this.ZDXPosition);
							}
							float num = 0f;
							float x = num2;
							float y = this.PaperPrintHeight;
							this.DrawLine(pen, num2, num, x, y);
							float num3 = this.MeasureText("测", this.ZDXFont).Width;
							this.Currentx = num2 - num3 / 2f;
							this.Currenty = num;
							this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, false, true, num3, this.PaperPrintHeight, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
							break;
						}
					case VB2008Print.TheZDXTYPE.BOTTOM:
						{
							float num;
							if (this.ZDXPosition <= 0f)
							{
								num = (float)((double)this.PaperHeight - (double)this.PaperMargins.Bottom / 2.0 - (double)this.PaperMargins.Top);
							}
							else
							{
								num = this.PaperHeight - this.ZDXPosition - (float)this.PaperMargins.Top;
							}
							float num2 = 0f;
							float x = this.PaperPrintWidth;
							float y = num;
							this.DrawLine(pen, num2, num, x, y);
							float num3 = this.MeasureText("测", this.ZDXFont).Height;
							this.Currentx = num2;
							this.Currenty = num - num3 / 2f;
							this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, true, true, this.PaperPrintWidth, num3, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
							break;
						}
					default:
						{
							float num2;
							if (this.ZDXPosition <= 0f)
							{
								num2 = (float)((double)this.PaperMargins.Left / 2.0 - (double)this.PaperMargins.Left);
							}
							else
							{
								num2 = this.ZDXPosition - (float)this.PaperMargins.Left;
							}
							float num = 0f;
							float x = num2;
							float y = this.PaperPrintHeight;
							this.DrawLine(pen, num2, num, x, y);
							float num3 = this.MeasureText("测", this.ZDXFont).Width;
							this.Currentx = num2 - num3 / 2f;
							this.Currenty = num;
							this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, false, true, num3, this.PaperPrintHeight, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
							break;
						}
				}
				this.IsNeedCheckNewPage = isNeedCheckNewPage;
				pen.Dispose();
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000959F0 File Offset: 0x00093BF0
		public int GetCurrentPage()
		{
			int result;
			if (this.isstarting)
			{
				result = this.currentpage;
			}
			else
			{
				try
				{
					result = checked((int)Math.Round(Conversion.Val(Strings.Mid(this.cpage.Text, 2))));
				}
				catch (Exception ex)
				{
					result = this.currentpage;
				}
			}
			return result;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00095A54 File Offset: 0x00093C54
		public bool SetCurrentPage(int pagenumber)
		{
			bool result;
			if (pagenumber > this.GetPages())
			{
				result = false;
			}
			else if (pagenumber <= 0)
			{
				result = false;
			}
			else if (this.isstarting)
			{
				if (this.currentpage == pagenumber)
				{
					this.SaveFont(this.r_font, null);
					result = true;
				}
				else
				{
					int page = this.currentpage;
					this.currentpage = pagenumber;
					this.SaveFont(this.r_font, null);
					if (!this.IsPaperSizeEqual(page, this.currentpage))
					{
						this.GetPageAndPaperSettings(this.currentpage);
					}
					result = true;
				}
			}
			else
			{
				this.currentpage = pagenumber;
				this.PrintPreviewControl1.StartPage = checked(this.currentpage - 1);
				result = true;
			}
			return result;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00095AF4 File Offset: 0x00093CF4
		public int GetPages()
		{
			int result;
			if (this.mypages == null)
			{
				result = 0;
			}
			else
			{
				result = checked(this.mypages.Length - 1);
			}
			return result;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00095B1C File Offset: 0x00093D1C
		private float GetPYx()
		{
			float num = this.MyConvTo(this.myPYx);
			if (this.IsAutoAdjustPrinterMargin && this.isprinttoprinter)
			{
				num -= this.unprintablex;
			}
			return num;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00095B54 File Offset: 0x00093D54
		private float GetPYy()
		{
			float num = this.MyConvTo(this.myPYy);
			if (this.IsAutoAdjustPrinterMargin && this.isprinttoprinter)
			{
				num -= this.unprintabley;
			}
			return num;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x000071A1 File Offset: 0x000053A1
		private void PY(Graphics g)
		{
			g.TranslateTransform(this.GetPYx(), this.GetPYy());
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00095B8C File Offset: 0x00093D8C
		private void MyDrawDGVHeaderCell(DataGridViewColumn mycolumn, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
		{
			if (mycolumn != null)
			{
				DataGridView dataGridView = mycolumn.DataGridView;
				if (mycolumn.Visible)
				{
					if (mycellwidth <= 0f)
					{
						mycellwidth = this.ConvFromDisplay((float)mycolumn.Width, true);
					}
					if (mycellheight <= 0f)
					{
						mycellheight = this.ConvFromDisplay((float)dataGridView.ColumnHeadersHeight, false);
					}
					Font dgvheaderFont = Module1.GetDGVHeaderFont(mycolumn);
					Color dgvheaderForeColor = Module1.GetDGVHeaderForeColor(mycolumn);
					bool mulline = Module1.GetDGVHeaderMulline(mycolumn);
					Color dgvheaderBackColor = Module1.GetDGVHeaderBackColor(mycolumn);
					mulline = true;
					if (!isprintbackcolor)
					{
						this.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
					}
					else
					{
						this.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, dgvheaderBackColor, dataGridView.GridColor, 0);
					}
				}
				try
				{
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00095C78 File Offset: 0x00093E78
		private void MyDrawDGVCell(DataGridViewCell dgvcell, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
		{
			checked
			{
				if (dgvcell != null)
				{
					DataGridView dataGridView = dgvcell.DataGridView;
					string s = "";
					Bitmap bitmap = null;
					DataGridViewColumn dataGridViewColumn = dataGridView.Columns[dgvcell.ColumnIndex];
					DataGridViewRow dataGridViewRow = dataGridView.Rows[dgvcell.RowIndex];
					if (dataGridViewColumn.Visible)
					{
						Margins cellMargin = this.CellMargin;
						if (this.IsUseDGVPadding)
						{
							Margins dgvcellPadding = Module1.GetDGVCellPadding(dgvcell);
							this.CellMargin = new Margins((int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Left, true)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Right, true)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Top, false)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Bottom, false)));
						}
						if (mycellwidth <= 0f)
						{
							mycellwidth = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
						}
						if (mycellheight <= 0f)
						{
							mycellheight = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
						}
						Font myf = Module1.GetDGVCellFont(dgvcell);
						DataGridViewCellStyle dataGridViewCellStyle = Module1.GetDGVCellStyle(dgvcell);
						Color dgvcellForeColor = Module1.GetDGVCellForeColor(dgvcell);
						Color dgvcellBackColor = Module1.GetDGVCellBackColor(dgvcell);
						bool dgvcellMulline = Module1.GetDGVCellMulline(dgvcell);
						bool flag = false;
						int num;
						if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewCheckBoxColumn", false) == 0)
						{
							CheckBox checkBox = new CheckBox();
							Control control = checkBox;
							Size size = new Size(14, 14);
							control.Size = size;
							if (isprintbackcolor)
							{
								checkBox.BackColor = dgvcellBackColor;
							}
							else
							{
								checkBox.BackColor = Color.Transparent;
							}
							if (Operators.CompareString(Versioned.TypeName(RuntimeHelpers.GetObjectValue(dgvcell.FormattedValue)), "Boolean", false) == 0)
							{
								if (Conversions.ToBoolean(dgvcell.FormattedValue))
								{
									checkBox.Checked = true;
								}
								else
								{
									checkBox.Checked = false;
								}
							}
							else
							{
								switch (Conversions.ToInteger(dgvcell.FormattedValue))
								{
									case 0:
										checkBox.Checked = false;
										break;
									case 1:
										checkBox.Checked = true;
										break;
									default:
										checkBox.CheckState = CheckState.Indeterminate;
										break;
								}
							}
							if (bitmap != null)
							{
								try
								{
									bitmap.Dispose();
									bitmap = null;
								}
								catch (Exception ex)
								{
								}
							}
							try
							{
								bitmap = new Bitmap((int)Math.Round((double)this.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
								Graphics graphics = Graphics.FromImage(bitmap);
								Brush brush;
								if (isprintbackcolor)
								{
									brush = new SolidBrush(dgvcellBackColor);
								}
								else
								{
									brush = Brushes.White;
								}
								Graphics graphics2 = graphics;
								Brush brush2 = brush;
								Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
								graphics2.FillRectangle(brush2, rectangle);
								if (bitmap.Height < checkBox.Height)
								{
									checkBox.Height = bitmap.Height;
								}
								if (bitmap.Width < checkBox.Width)
								{
									checkBox.Width = bitmap.Width;
								}
								Control control2 = checkBox;
								Bitmap bitmap2 = bitmap;
								rectangle = new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height);
								control2.DrawToBitmap(bitmap2, rectangle);
								graphics.Dispose();
								checkBox.Dispose();
								checkBox = null;
							}
							catch (Exception ex2)
							{
							}
							flag = true;
							num = 2;
						}
						else if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewButtonColumn", false) == 0)
						{
							Button button = new Button();
							button.AutoSize = false;
							Control control3 = button;
							Size size = new Size((int)Math.Round((double)this.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
							control3.Size = size;
							button.Text = "";
							if (isprintbackcolor)
							{
								button.BackColor = dgvcellBackColor;
							}
							else
							{
								button.BackColor = Color.Transparent;
							}
							float currentx = this.Currentx;
							float currenty = this.Currenty;
							try
							{
								bitmap = new Bitmap(button.Width, dataGridViewRow.Height);
								Control control4 = button;
								Bitmap bitmap3 = bitmap;
								Rectangle rectangle = new Rectangle(0, 0, button.Width, (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
								control4.DrawToBitmap(bitmap3, rectangle);
								this.DrawCellImage(bitmap, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, "0000", true, StringAlignment.Center, StringAlignment.Center);
								bitmap.Dispose();
								bitmap = null;
								button.Dispose();
							}
							catch (Exception ex3)
							{
							}
							this.Currentx = currentx;
							this.Currenty = currenty;
							flag = true;
							num = 3;
						}
						else if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
						{
							flag = true;
							num = 1;
						}
						else
						{
							s = Conversions.ToString(dgvcell.FormattedValue) + "";
						}
						if (!flag)
						{
							if (!isprintbackcolor)
							{
								this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
							}
							else
							{
								this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, false, false, false, minfontsize, dgvcellBackColor, dataGridView.GridColor, 0);
							}
						}
						else if (num == 1)
						{
							DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)dgvcell;
							this.DrawCellImage((Bitmap)dgvcell.FormattedValue, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, dataGridViewImageCell.ImageLayout, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter));
						}
						else if (num == 2)
						{
							this.DrawCellImage(bitmap, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, true, StringAlignment.Center, StringAlignment.Center);
						}
						else if (num == 3)
						{
							s = Conversions.ToString(dgvcell.FormattedValue) + "";
							this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
						}
						if (this.IsUseDGVPadding)
						{
							this.CellMargin = cellMargin;
						}
					}
					if (bitmap != null)
					{
						try
						{
							bitmap.Dispose();
							bitmap = null;
						}
						catch (Exception ex4)
						{
						}
					}
					try
					{
						dataGridView = null;
						Font myf = null;
						DataGridViewCellStyle dataGridViewCellStyle = null;
					}
					catch (Exception ex5)
					{
					}
				}
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0009633C File Offset: 0x0009453C
		private static int GetDGVVisibleCols(DataGridView myd)
		{
			checked
			{
				int result;
				if (myd == null)
				{
					result = 0;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = myd.ColumnCount - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (myd.Columns[i].Visible)
						{
							num++;
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00096384 File Offset: 0x00094584
		private void MyWrite(string thename, string thevalue)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = thename + "\0" + thevalue;
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000963E0 File Offset: 0x000945E0
		private void MyWrite(string t1, string t2, string t3)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00096458 File Offset: 0x00094658
		private void MyWrite(string t1, string t2, string t3, string t4)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000964DC File Offset: 0x000946DC
		private void MyWrite(string t1, string t2, string t3, string t4, string t5)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00096570 File Offset: 0x00094770
		private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5,
						"\0",
						t6,
						"\0",
						t7
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00096628 File Offset: 0x00094828
		private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5,
						"\0",
						t6,
						"\0",
						t7,
						"\0",
						t8
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000966EC File Offset: 0x000948EC
		private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5,
						"\0",
						t6,
						"\0",
						t7,
						"\0",
						t8,
						"\0",
						t9
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000967C0 File Offset: 0x000949C0
		private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5,
						"\0",
						t6,
						"\0",
						t7,
						"\0",
						t8,
						"\0",
						t9,
						"\0",
						t10
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000968A4 File Offset: 0x00094AA4
		private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string str = string.Concat(new string[]
					{
						t1,
						"\0",
						t2,
						"\0",
						t3,
						"\0",
						t4,
						"\0",
						t5,
						"\0",
						t6
					});
					this.mypages[this.currentpage].Append("\u0001\u0003" + str);
				}
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00096948 File Offset: 0x00094B48
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						t7,
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(Interaction.IIf(t10, "1", "0")),
						"\0",
						Conversions.ToString(Interaction.IIf(t11, "1", "0")),
						"\0"
					});
					text = text + Conversions.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Conversions.ToString(Interaction.IIf(t13, "1", "0"));
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00096AE0 File Offset: 0x00094CE0
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, StringFormatFlags t10)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						t7,
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text += Conversions.ToString((int)t10);
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00096BF8 File Offset: 0x00094DF8
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					ColorConverter colorConverter = new ColorConverter();
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						colorConverter.ConvertToString(t7),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text += Conversions.ToString((int)t10);
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00096D24 File Offset: 0x00094F24
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					ColorConverter colorConverter = new ColorConverter();
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						colorConverter.ConvertToString(t7),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(Interaction.IIf(t10, "1", "0")),
						"\0",
						Conversions.ToString(Interaction.IIf(t11, "1", "0")),
						"\0"
					});
					text = text + Conversions.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Conversions.ToString(Interaction.IIf(t13, "1", "0"));
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00096ECC File Offset: 0x000950CC
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13, string t14)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					ColorConverter colorConverter = new ColorConverter();
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						colorConverter.ConvertToString(t7),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(Interaction.IIf(t10, "1", "0")),
						"\0",
						Conversions.ToString(Interaction.IIf(t11, "1", "0")),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(Interaction.IIf(t12, "1", "0")),
						"\0",
						Conversions.ToString(Interaction.IIf(t13, "1", "0")),
						"\0"
					});
					text += t14;
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00097098 File Offset: 0x00095298
		private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10, string t11)
		{
			if (this.currentpage < this.mypages.Length)
			{
				if (this.currentpage <= 0)
				{
					this.ShowWriteError();
				}
				else
				{
					ColorConverter colorConverter = new ColorConverter();
					string text = string.Concat(new string[]
					{
						t1,
						"\0",
						Conversions.ToString(t2),
						"\0",
						Conversions.ToString(t3),
						"\0",
						Conversions.ToString(t4),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						Conversions.ToString(t5),
						"\0",
						t6,
						"\0",
						colorConverter.ConvertToString(t7),
						"\0"
					});
					text = string.Concat(new string[]
					{
						text,
						t8,
						"\0",
						t9,
						"\0"
					});
					text = text + Conversions.ToString((int)t10) + "\0";
					text += t11;
					this.mypages[this.currentpage].Append("\u0001\u0003" + text);
				}
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000071B5 File Offset: 0x000053B5
		private void ShowWriteError()
		{
			if (this.IsShowErrorMSG & !this.hasshownewpageerror)
			{
				this.hasshownewpageerror = true;
				Interaction.MsgBox("您在调用控件的打印方法打印输出前未调用NewPage函数创建第1个打印页面\r\n这将导致这部分的打印输出无效（打印内容部分丢失），请注意检查。", MsgBoxStyle.Exclamation, "警告");
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000971D0 File Offset: 0x000953D0
		private bool SaveFont(Font newfont, Font sourcefont)
		{
			FontConverter fontConverter = new FontConverter();
			bool result;
			if (sourcefont == null)
			{
				string text = fontConverter.ConvertToString(newfont);
				this.MyWrite("f", text);
				result = true;
			}
			else
			{
				string right = fontConverter.ConvertToString(sourcefont);
				string text = fontConverter.ConvertToString(newfont);
				if (Operators.CompareString(text, right, false) != 0)
				{
					this.MyWrite("f", text);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00097234 File Offset: 0x00095434
		private void SaveCS()
		{
			this.templandscape = this.PaperLandscape;
			this.temppaperkind = this.PaperKind;
			this.temppapersize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
			this.temppageunits = this.PageUnits;
			this.tempmargintleft = this.mypagesetting.Margins.Left;
			this.tempmargintright = this.mypagesetting.Margins.Right;
			this.tempmarginttop = this.mypagesetting.Margins.Top;
			this.tempmargintbottom = this.mypagesetting.Margins.Bottom;
			this.tempforecolor = this.TextColor;
			this.tempfont = (Font)this.TextFont.Clone();
			this.tempfontwater = (Font)this.WaterMarkFont.Clone();
			this.tempforecolorwater = this.WaterMarkColor;
			this.templandscapewater = this.WaterMarkLandscape;
			this.tempopacitywater = this.mywatermarkopacity;
			this.tempshapedepth = this.myshapedepth;
			this.tempcellmargin = this.myCellmargin;
			this.tempisdrawtableeverypage = this.IsDrawTableFooterEveryPage;
			this.tempisautoaddemptyrow = this.IsAutoAddEmptyRow;
			this.tempisneedchecknewpage = this.IsNeedCheckNewPage;
			this.tempouterborder = this.myouterborder;
			this.tempouterborderwidth = this.myouterborderwidth;
			this.tempouterbordercolor = this.myouterbordercolor;
			this.tempisusedoubleline = this.myisusedoubleline;
			this.tempdoublelinespace = this.thedoublelinespace;
			this.tempIsDGVCellValignmentCenter = this.myIsDGVCellValignmentCenter;
			this.tempIsDrawPageFooterLine = this.myisdrawpagefooterline;
			this.tempIsDrawPageHeaderLine = this.myisdrawpageheaderline;
			this.tempIsUseDGVPadding = this.myisusedgvpadding;
			this.tempoffsetx = this.myPYx;
			this.tempoffsety = this.myPYy;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000071E2 File Offset: 0x000053E2
		private void RestoreEndCS()
		{
			if (this.tempfont != null)
			{
				this.RestoreCS();
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000973F8 File Offset: 0x000955F8
		private void RestoreCS()
		{
			this.PaperLandscape = this.templandscape;
			this.PaperKind = this.temppaperkind;
			if (this.temppapersize != null)
			{
				PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.temppapersize.PaperName);
				if (printForm != null)
				{
					this.PaperSize = printForm;
				}
			}
			this.PageUnits = this.temppageunits;
			try
			{
				this.mypagesetting.Margins.Left = this.tempmargintleft;
				this.mypagesetting.Margins.Right = this.tempmargintright;
				this.mypagesetting.Margins.Top = this.tempmarginttop;
				this.mypagesetting.Margins.Bottom = this.tempmargintbottom;
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.TextFont = (Font)this.tempfont.Clone();
				this.TextColor = this.tempforecolor;
				this.WaterMarkColor = this.tempforecolorwater;
				this.WaterMarkFont = (Font)this.tempfontwater.Clone();
				this.WaterMarkLandscape = this.templandscapewater;
				this.mywatermarkopacity = this.tempopacitywater;
				this.myshapedepth = this.tempshapedepth;
				this.myCellmargin = this.tempcellmargin;
			}
			catch (Exception ex2)
			{
			}
			this.IsDrawTableFooterEveryPage = this.tempisdrawtableeverypage;
			this.IsAutoAddEmptyRow = this.tempisautoaddemptyrow;
			this.IsNeedCheckNewPage = this.tempisneedchecknewpage;
			this.myouterborder = this.tempouterborder;
			this.myouterborderwidth = this.tempouterborderwidth;
			this.myouterbordercolor = this.tempouterbordercolor;
			this.myisusedoubleline = this.tempisusedoubleline;
			this.thedoublelinespace = this.tempdoublelinespace;
			this.myIsDGVCellValignmentCenter = this.tempIsDGVCellValignmentCenter;
			this.myisdrawpagefooterline = this.tempIsDrawPageFooterLine;
			this.myisdrawpageheaderline = this.tempIsDrawPageHeaderLine;
			this.myisusedgvpadding = this.tempIsUseDGVPadding;
			this.myPYx = this.tempoffsetx;
			this.myPYy = this.tempoffsety;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00097604 File Offset: 0x00095804
		private float MyConvTo(float oldvalue)
		{
			switch (this.mypageunits)
			{
				case VB2008Print.PageExportUnit.CentiMeter:
					return (float)((double)oldvalue / 2.54);
				case VB2008Print.PageExportUnit.Inch:
					return oldvalue;
			}
			return oldvalue;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00097648 File Offset: 0x00095848
		private float MyConvFrom(float oldvalue)
		{
			switch (this.mypageunits)
			{
				case VB2008Print.PageExportUnit.CentiMeter:
					return (float)((double)oldvalue * 2.54);
				case VB2008Print.PageExportUnit.Inch:
					return oldvalue;
			}
			return oldvalue;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0009768C File Offset: 0x0009588C
		private float ConvFromDisplayToMM(float myw)
		{
			float pixelsperinchx = this.PIXELSPERINCHX;
			return (float)((double)(myw / pixelsperinchx) * 2.54 * 10.0);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000976C0 File Offset: 0x000958C0
		private float ConvFromMMToDisplay(float myw)
		{
			float num = (float)((double)(myw / 10f) / 2.54);
			float num2 = this.PIXELSPERINCHX;
			num2 = num * num2;
			return Convert.ToSingle(Math.Floor(new decimal(num2)));
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00097700 File Offset: 0x00095900
		private static bool CanSpanPrint(string myleft, string mymiddle, string myright, ref string mys, ref StringAlignment alg)
		{
			int num = 0;
			StringAlignment stringAlignment = StringAlignment.Near;
			checked
			{
				if (Operators.CompareString(myleft, "", false) != 0)
				{
					num++;
					stringAlignment = StringAlignment.Near;
					mys = myleft;
				}
				if (Operators.CompareString(mymiddle, "", false) != 0)
				{
					num++;
					stringAlignment = StringAlignment.Center;
					mys = mymiddle;
				}
				if (Operators.CompareString(myright, "", false) != 0)
				{
					num++;
					stringAlignment = StringAlignment.Far;
					mys = myright;
				}
				bool result = num == 1;
				alg = stringAlignment;
				return result;
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0009776C File Offset: 0x0009596C
		private void SavePageCS()
		{
			PaperSize paperSize = this.mypagesetting.PaperSize;
			this.SavePaperHeightAndWidth(paperSize);
			this.mypages[0].Append("\u0002\u0004");
			this.TheWrite(0, "papersize", Conversions.ToString((int)paperSize.Kind));
			if (paperSize.Kind == PaperKind.Custom)
			{
				this.TheWrite(0, "paperzdy", string.Concat(new string[]
				{
					paperSize.PaperName,
					"\u0006",
					Conversions.ToString(paperSize.Width),
					"\u0006",
					Conversions.ToString(paperSize.Height)
				}));
			}
			else
			{
				this.TheWrite(0, "paperzdy", string.Concat(new string[]
				{
					"[",
					paperSize.PaperName,
					"]\u0006",
					Conversions.ToString(paperSize.Width),
					"\u0006",
					Conversions.ToString(paperSize.Height)
				}));
			}
			this.TheWrite(0, "orientation", Conversions.ToString(Interaction.IIf(this.mypagesetting.Landscape, "1", "0")));
			this.TheWrite(0, "leftmargin", Conversions.ToString(this.mypagesetting.Margins.Left));
			this.TheWrite(0, "topmargin", Conversions.ToString(this.mypagesetting.Margins.Top));
			this.TheWrite(0, "bottommargin", Conversions.ToString(this.mypagesetting.Margins.Bottom));
			this.TheWrite(0, "rightmargin", Conversions.ToString(this.mypagesetting.Margins.Right));
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00097918 File Offset: 0x00095B18
		private void TheWrite(int thepage, string thename, string thevalue)
		{
			string str = thename + "\0" + thevalue;
			this.mypages[thepage].Append("\u0001\u0003" + str);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0009794C File Offset: 0x00095B4C
		private void MyNewPage()
		{
			checked
			{
				if (!Module1.G_CancelDocument)
				{
					if (this.currentpage + 1 <= this.GetPages())
					{
						this.currentpage++;
						this.Currentx = 0f;
						this.Currenty = 0f;
						this.SaveFont(this.r_font, null);
					}
					else
					{
						this.currentpage = this.GetPages() + 1;
						this.Currentx = 0f;
						this.Currenty = 0f;
						this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[this.currentpage + 1]);
						this.mypages[this.currentpage] = new StringBuilder("   ");
						this.NewPageAfter();
					}
				}
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000071F2 File Offset: 0x000053F2
		private void MyNewPage(bool paperLandscape)
		{
			this.mypagesetting.Landscape = paperLandscape;
			this.Pd.DefaultPageSettings = this.mypagesetting;
			this.MyNewPage();
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00097A10 File Offset: 0x00095C10
		private void SetStatus(string tt)
		{
			if (Strings.InStr(tt, "页眉", CompareMethod.Binary) > 0)
			{
				this.mystatus.Text = string.Concat(new string[]
				{
					"共[",
					this.GetPages().ToString(),
					"]页,生成页眉页脚〖",
					Conversions.ToString(this.currentpage),
					"〗"
				});
			}
			else
			{
				this.mystatus.Text = "共[" + this.GetPages().ToString() + "]页 ";
			}
			try
			{
				this.SetStatusNew(tt);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00097ACC File Offset: 0x00095CCC
		private void myNewDoc()
		{
			if (this.myisshowprogress)
			{
				this.ShowStatus();
			}
			Module1.G_CancelDocument = false;
			this.isstarting = true;
			this.myisendpreview = false;
			this.IsOpenReporting = false;
			this.isprinttoprinter = false;
			this.hasshownewpageerror = false;
			this.currentpage = 0;
			this.Currentx = 0f;
			this.Currenty = 0f;
			this.mypictures = 0;
			this.W_myrtfnum = 0;
			this.W_myrtfC = null;
			this.mypicture = null;
			this.myPaperHeight = null;
			this.myPaperWidth = null;
			this.DelMypages();
			GC.Collect();
			this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[1]);
			this.mypages[0] = new StringBuilder("   ");
			if (this.mypagesetting.PaperSize.Height <= 0 | this.mypagesetting.PaperSize.Width <= 0)
			{
				if (this.IsShowErrorMSG)
				{
					Interaction.MsgBox("打印纸张类型出现错误(纸张宽度或高度中出现小于等于0的情况)，将使用A4纸进行打印\r\n原因可能是您使用的自定义纸张大小不正确，或者是控件调用.NET的PageSetupDialog方法时不能返回正确的纸张类型\r\n如果您在本控件的页面设置中更换了打印机，而这两个打印机所支持的纸张类型不一致，就有可能出现此问题。\r\n解决办法是，不要在页面设置中更换打印机，而是应该在控制面板中将要进行打印输出的打印机设置为默认打印机。", MsgBoxStyle.OkOnly, "提示信息");
				}
				try
				{
					foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (paperSize.Kind == PaperKind.A4)
						{
							this.mypagesetting.PaperSize = paperSize;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			this.TheWrite(0, "papersize", Conversions.ToString((int)this.mypagesetting.PaperSize.Kind));
			this.TheWrite(0, "paperzdy", Conversions.ToString(Interaction.IIf(this.PaperKind == PaperKind.Custom, string.Concat(new string[]
			{
				this.mypagesetting.PaperSize.PaperName,
				"\u0006",
				Conversions.ToString(this.mypagesetting.PaperSize.Width),
				"\u0006",
				Conversions.ToString(this.mypagesetting.PaperSize.Height)
			}), "")));
			this.TheWrite(0, "orientation", Conversions.ToString(Interaction.IIf(this.mypagesetting.Landscape, "1", "0")));
			this.TheWrite(0, "leftmargin", Conversions.ToString(this.mypagesetting.Margins.Left));
			this.TheWrite(0, "topmargin", Conversions.ToString(this.mypagesetting.Margins.Top));
			this.TheWrite(0, "bottommargin", Conversions.ToString(this.mypagesetting.Margins.Bottom));
			this.TheWrite(0, "rightmargin", Conversions.ToString(this.mypagesetting.Margins.Right));
			PaperSize paperSize2 = this.mypagesetting.PaperSize;
			this.SavePaperHeightAndWidth(paperSize2);
			if (this.tempfont != null)
			{
				this.tempfont.Dispose();
			}
			if (this.tempfontwater != null)
			{
				this.tempfontwater.Dispose();
			}
			this.r_font = this.TextFont;
			this.SaveCS();
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00097DEC File Offset: 0x00095FEC
		private bool IsPaperSizeEqual(int page1, int page2)
		{
			bool result = true;
			if (page1 == page2)
			{
				result = true;
			}
			else
			{
				try
				{
					string[] array = Strings.Split(this.mypages[0].ToString(), "\u0002\u0004", -1, CompareMethod.Binary);
					result = Strings.Trim(array[page1]).Equals(Strings.Trim(array[page2]));
				}
				catch (Exception ex)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00097E64 File Offset: 0x00096064
		private void myEndDoc()
		{
			if (this.myisneedprintpageheaderandfooter)
			{
				int num = 1;
				int num2 = this.GetPages();
				int num3 = num;
				while (num3 <= num2 && !this.CancelDocument)
				{
					this.SetCurrentPage(num3);
					this.SetStatus(string.Concat(new string[]
					{
						"预处理，正在处理第【",
						Conversions.ToString(this.currentpage),
						"】页的页眉、页脚和水印（共 ",
						Conversions.ToString(this.GetPages()),
						" 页需要处理）"
					}));
					this.myheaderlineposition = 0f;
					VB2008Print.HeaderFooterOutEventHandler headerFooterOutEvent = this.HeaderFooterOutEvent;
					if (headerFooterOutEvent != null)
					{
						headerFooterOutEvent(this.GetPages(), num3);
					}
					this.SetCurrentPage(num3);
					float num4 = 1f;
					float num5 = 10f;
					if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
					{
						num4 = (float)((double)num4 / 2.54);
						num5 = (float)((double)num5 / 2.54);
					}
					if (this.myheaderlineposition == 0f)
					{
						num5 = (float)((double)this.PaperMargins.Top / 2.0);
					}
					else
					{
						num5 = ((float)this.PaperMargins.Top - this.myheaderlineposition) / 2f - num5;
					}
					if (this.IsDrawPageHeaderLine)
					{
						this.DrawLine(0f, 0f - num5, this.PaperPrintWidth, 0f - num5, Color.Black, num4);
					}
					num5 = 10f;
					if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
					{
						num4 = (float)((double)num4 / 2.54);
						num5 = (float)((double)num5 / 2.54);
					}
					if (this.IsDrawPageFooterLine)
					{
						this.DrawLine(0f, this.PaperPrintHeight + num5, this.PaperPrintWidth, this.PaperPrintHeight + num5, Color.Black, num4);
					}
					this.PrintWaterMark();
					this.PrintZDX();
					checked
					{
						num3++;
					}
				}
			}
			this.SetStatus("正在生成预览效果");
			this.RestoreCS();
			this.CloseStatus();
			checked
			{
				try
				{
					this.cpage.Items.Clear();
					int num6 = 1;
					int num7 = this.GetPages();
					for (int i = num6; i <= num7; i++)
					{
						this.cpage.Items.Add("第" + Conversions.ToString(i) + "页");
					}
					this.MyShow();
					this.Enabled = true;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x000980BC File Offset: 0x000962BC
		private void MyShow()
		{
			this.currentpage = 1;
			this.myisendpreview = false;
			this.isstarting = false;
			this.Pd.DocumentName = Conversions.ToString(this.GetPages());
			if (this.myisimmediateprintnotpreview)
			{
				this.myisendpreview = true;
				this.Print(this.myIsImmediatePrintNotPreviewShowPrintDialog);
			}
			else
			{
				this.PrintPreviewControl1.InvalidatePreview();
			}
			try
			{
				this.mystatus.Text = "共【" + Conversions.ToString(this.GetPages()) + "】页";
				if (this.GetPages() >= 1)
				{
					this.cpage.SelectedIndex = 0;
				}
				this.SetPages();
				if (!this.Visible | this.Parent == null)
				{
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00098194 File Offset: 0x00096394
		private void MyEndThread()
		{
			Thread.Sleep(100);
			this.myisendpreview = true;
			if (this.isprinttoprinter)
			{
				this.isprinttoprinter = false;
			}
			else if (this.GetPages() > 0)
			{
				VB2008Print.EndPreViewEventHandler endPreViewEvent = this.EndPreViewEvent;
				if (endPreViewEvent != null)
				{
					endPreViewEvent();
				}
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000981DC File Offset: 0x000963DC
		private SizeF MeasureString(string txt, bool includedcellmargins = true)
		{
			return this.MeasureString(txt, this.myfont, includedcellmargins);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000981FC File Offset: 0x000963FC
		private SizeF MeasureString(string txt, Font myf, bool includedcellmargins = true)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
			SizeF result = this.MeasureString(txt, myf, stringFormat, includedcellmargins);
			stringFormat.Dispose();
			return result;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0009823C File Offset: 0x0009643C
		private SizeF MeasureString(string txt, Font myf, SizeF mysize, bool includedcellmargins = true)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
			SizeF result = this.MeasureString(txt, myf, mysize, stringFormat, includedcellmargins);
			stringFormat.Dispose();
			return result;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00098280 File Offset: 0x00096480
		private SizeF MeasureString(string txt, Font myf, float mywidth, bool includedcellmargins = true)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
			SizeF result = this.MeasureString(txt, myf, mywidth, stringFormat, includedcellmargins);
			stringFormat.Dispose();
			return result;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000982C4 File Offset: 0x000964C4
		private SizeF MeasureString(string txt, Font myf, float mywidth, StringFormat myformat, bool includedcellmargins = true)
		{
			SizeF sizeF = default(SizeF);
			mywidth = this.MyConvTo(mywidth);
			SizeF result;
			if (!includedcellmargins)
			{
				sizeF = this.myg.MeasureString(txt, myf, checked((int)Math.Round((double)(unchecked(mywidth + 1f)))), myformat);
				sizeF.Width = this.MyConvFrom(sizeF.Width);
				sizeF.Height = this.MyConvFrom(sizeF.Height);
				result = sizeF;
			}
			else
			{
				sizeF = this.myg.MeasureString(txt, myf, checked((int)Math.Round((double)(unchecked(mywidth + 1f - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right))))), myformat);
				sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
				sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
				result = sizeF;
			}
			return result;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000983D8 File Offset: 0x000965D8
		private SizeF MeasureString(string txt, Font myf, StringFormat myformat, bool includedcellmargins = true)
		{
			PointF origin = new PointF(0f, 0f);
			SizeF sizeF = default(SizeF);
			SizeF result;
			if (!includedcellmargins)
			{
				sizeF = this.myg.MeasureString(txt, myf, origin, myformat);
				sizeF.Width = this.MyConvFrom(sizeF.Width);
				sizeF.Height = this.MyConvFrom(sizeF.Height);
				result = sizeF;
			}
			else
			{
				try
				{
					sizeF = this.myg.MeasureString(txt, myf, origin, myformat);
				}
				catch (Exception ex)
				{
				}
				if (this.myCellmargin != null)
				{
					sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
					sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
				}
				result = sizeF;
			}
			return result;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000984D8 File Offset: 0x000966D8
		private SizeF MeasureString(string txt, Font myf, SizeF mysize, StringFormat myformat, bool includedcellmargins = true)
		{
			SizeF sizeF = default(SizeF);
			mysize.Height = this.MyConvTo(mysize.Height) + 1f;
			mysize.Width = this.MyConvTo(mysize.Width) + 1f;
			SizeF result;
			if (!includedcellmargins)
			{
				sizeF = this.myg.MeasureString(txt, myf, mysize, myformat);
				sizeF.Width = this.MyConvFrom(sizeF.Width);
				sizeF.Height = this.MyConvFrom(sizeF.Height);
				result = sizeF;
			}
			else
			{
				mysize.Width = mysize.Width - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right);
				mysize.Height = mysize.Height - this.MyConvTo((float)this.myCellmargin.Top) - this.MyConvTo((float)this.myCellmargin.Bottom);
				sizeF = this.myg.MeasureString(txt, myf, mysize, myformat);
				sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
				sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
				result = sizeF;
			}
			return result;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00098640 File Offset: 0x00096840
		private SizeF MeasureString(string txt, Font myf, SizeF mysize, StringFormat myformat, ref int charactersFitted, ref int linesFilled, bool includedcellmargins = true)
		{
			mysize.Height = this.MyConvTo(mysize.Height) + 1f;
			mysize.Width = this.MyConvTo(mysize.Width) + 1f;
			SizeF sizeF = default(SizeF);
			SizeF result;
			if (!includedcellmargins)
			{
				sizeF = this.myg.MeasureString(txt, myf, mysize, myformat, out charactersFitted, out linesFilled);
				sizeF.Width = this.MyConvFrom(sizeF.Width);
				sizeF.Height = this.MyConvFrom(sizeF.Height);
				result = sizeF;
			}
			else
			{
				mysize.Width = mysize.Width - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right);
				mysize.Height = mysize.Height - this.MyConvTo((float)this.myCellmargin.Top) - this.MyConvTo((float)this.myCellmargin.Bottom);
				try
				{
					sizeF = this.myg.MeasureString(txt, myf, mysize, myformat, out charactersFitted, out linesFilled);
				}
				catch (Exception ex)
				{
				}
				sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
				sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
				result = sizeF;
			}
			return result;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x000987D0 File Offset: 0x000969D0
		private void DrawString(string text, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			SizeF mysize = default(SizeF);
			SizeF sizeF = default(SizeF);
			float currentx = this.Currentx;
			mysize = this.MeasureString(text, myf, myformat, includemargins);
			float num = this.PaperPrintHeight - this.Currenty;
			while (mysize.Height > num)
			{
				mysize.Height = num;
				int num2;
				int num3;
				sizeF = this.MeasureString(text, myf, mysize, myformat, ref num2, ref num3, includemargins);
				string text2 = Strings.Mid(text, 1, num2);
				this.Currentx = currentx;
				string text3 = text2;
				RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, sizeF.Width, sizeF.Height);
				this.DrawString(text3, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
				text = Strings.Mid(text, checked(num2 + 1));
				this.MyNewPage();
				mysize = this.MeasureString(text, myf, myformat, includemargins);
				num = this.PaperPrintHeight - this.Currenty;
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				this.Currentx = currentx;
				string text4 = text;
				RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, mysize.Width, mysize.Height);
				this.DrawString(text4, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00098910 File Offset: 0x00096B10
		private void DrawString(string text, float mywidth, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			SizeF mysize = default(SizeF);
			SizeF sizeF = default(SizeF);
			mysize = this.MeasureString(text, myf, mywidth, myformat, includemargins);
			float num = this.PaperPrintHeight - this.Currenty;
			float currentx = this.Currentx;
			while (mysize.Height > num)
			{
				mysize.Height = num;
				mysize.Width = mywidth;
				int num2;
				int num3;
				sizeF = this.MeasureString(text, myf, mysize, myformat, ref num2, ref num3, includemargins);
				string text2 = Strings.Mid(text, 1, num2);
				string text3 = text2;
				RectangleF myrect = new RectangleF(currentx, this.Currenty, mywidth, sizeF.Height);
				this.DrawString(text3, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
				text = Strings.Mid(text, checked(num2 + 1));
				if (Operators.CompareString(text, "", false) == 0)
				{
					break;
				}
				this.MyNewPage();
				mysize = this.MeasureString(text, myf, mywidth, myformat, includemargins);
				num = this.PaperPrintHeight - this.Currenty;
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				string text4 = text;
				RectangleF myrect = new RectangleF(currentx, this.Currenty, mywidth, mysize.Height);
				this.DrawString(text4, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00098A4C File Offset: 0x00096C4C
		private void DrawString(string s, float mywidth, float myheight, Font myf, Color textforecolor, string myborder, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, textforecolor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00098A90 File Offset: 0x00096C90
		private void DrawString(string s, float mywidth, float myheight, Font myf, string myborder, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00098AD8 File Offset: 0x00096CD8
		private void DrawString(string text, RectangleF myrect, Color textforecolor, StringFormat myformat, string myborder, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			this.DrawString(text, myrect, this.myfont, textforecolor, myformat, myborder, minfontsize, includemargins, backcolor, linecolor, textoutstyle);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00098B04 File Offset: 0x00096D04
		private void DrawString(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
		{
			this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, myborder, textforecolor, myformat, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00098B4C File Offset: 0x00096D4C
		private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Color textforecolor, StringFormat myformat, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
		{
			if (myf == null)
			{
				myf = (Font)this.myfont.Clone();
			}
			if (myf == null)
			{
				myf = new Font("宋体", 10f, FontStyle.Regular);
			}
			RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
			myformat.FormatFlags |= StringFormatFlags.LineLimit;
			bool flag = (myformat.FormatFlags & StringFormatFlags.NoWrap) != StringFormatFlags.NoWrap;
			Font font = null;
			try
			{
				font = (Font)myf.Clone();
			}
			catch (Exception ex)
			{
				try
				{
					font = Module1.ConvertStringToFont(Module1.ConvertFontToString(myf));
				}
				catch (Exception ex2)
				{
					font = (Font)this.myfont.Clone();
				}
			}
			float num = myf.Size;
			if (minfontsize > 0f)
			{
				SizeF sizeF = default(SizeF);
				SizeF mysize = new SizeF(mywidth, myheight);
				if (flag)
				{
					int num2;
					int num3;
					sizeF = this.MeasureString(s, myf, mysize, myformat, ref num2, ref num3, includemargins);
					while (num2 < Strings.Len(s) & num > minfontsize)
					{
						num -= 1f;
						font.Dispose();
						font = null;
						font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
						sizeF = this.MeasureString(s, font, mysize, myformat, ref num2, ref num3, includemargins);
					}
				}
				else
				{
					sizeF = this.MeasureString(s, myf, myformat, includemargins);
					while ((sizeF.Height > mysize.Height | sizeF.Width > mysize.Width) & num > minfontsize)
					{
						num -= 1f;
						font.Dispose();
						font = null;
						font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
						sizeF = this.MeasureString(s, font, myformat, includemargins);
					}
				}
			}
			this.DrawTextTrue(s, myrect, font, textforecolor, myformat, myborder, includemargins, backcolor, linecolor, mytextstyle, angle);
			myrect = default(RectangleF);
			font.Dispose();
			font = null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00098D7C File Offset: 0x00096F7C
		private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Color textforecolor, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
		{
			if (myf == null)
			{
				myf = (Font)this.myfont.Clone();
			}
			if (myf == null)
			{
				myf = new Font("宋体", 10f, FontStyle.Regular);
			}
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			stringFormat.LineAlignment = myValg;
			stringFormat.Alignment = myHalg;
			if (!mulline)
			{
				stringFormatFlags |= StringFormatFlags.NoWrap;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoWrap;
			}
			if (overflow)
			{
				stringFormatFlags |= StringFormatFlags.NoClip;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoClip;
			}
			if (directrighttoleft)
			{
				stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
			}
			if (directionVertical)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			stringFormat.FormatFlags = stringFormatFlags;
			this.DrawOutText(s, x, y, mywidth, myheight, myf, myborder, textforecolor, stringFormat, minfontsize, includemargins, backcolor, linecolor, mytextstyle, angle);
			stringFormat.Dispose();
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00098E54 File Offset: 0x00097054
		private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Brush textbrush, StringFormat myformat, float minfontsize, bool includemargins, Color backcolor, Color linecolor)
		{
			if (myf == null)
			{
				myf = (Font)this.myfont.Clone();
			}
			if (myf == null)
			{
				myf = new Font("宋体", 10f, FontStyle.Regular);
			}
			RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
			myformat.FormatFlags |= StringFormatFlags.LineLimit;
			bool flag = (myformat.FormatFlags & StringFormatFlags.NoWrap) != StringFormatFlags.NoWrap;
			Font font = (Font)myf.Clone();
			float num = myf.Size;
			if (minfontsize > 0f)
			{
				SizeF sizeF = default(SizeF);
				SizeF mysize = new SizeF(mywidth, myheight);
				if (flag)
				{
					int num2;
					int num3;
					sizeF = this.MeasureString(s, myf, mysize, myformat, ref num2, ref num3, includemargins);
					while (num2 < Strings.Len(s) & num > minfontsize)
					{
						num -= 1f;
						font.Dispose();
						font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
						sizeF = this.MeasureString(s, font, mysize, myformat, ref num2, ref num3, includemargins);
					}
				}
				else
				{
					sizeF = this.MeasureString(s, myf, myformat, includemargins);
					while ((sizeF.Height > mysize.Height | sizeF.Width > mysize.Width) & num > minfontsize)
					{
						num -= 1f;
						font.Dispose();
						font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
						sizeF = this.MeasureString(s, font, myformat, includemargins);
					}
				}
			}
			this.DrawTextTrue(s, myrect, font, textbrush, myformat, myborder, includemargins, backcolor, linecolor);
			myrect = default(RectangleF);
			font.Dispose();
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00099024 File Offset: 0x00097224
		private void DrawTextTrue(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
		{
			text += "";
			int num = 1;
			string t;
			string t2;
			checked
			{
				do
				{
					if (Strings.InStr(text, Conversions.ToString(Strings.Chr(num)), CompareMethod.Binary) > 0)
					{
						text = Strings.Replace(text, Conversions.ToString(Strings.Chr(num)), "", 1, -1, CompareMethod.Binary);
					}
					num++;
				}
				while (num <= 7);
				if (myformat.LineAlignment == StringAlignment.Center)
				{
					t = "2";
				}
				else if (myformat.LineAlignment == StringAlignment.Near)
				{
					t = "1";
				}
				else
				{
					t = "3";
				}
				if (myformat.Alignment == StringAlignment.Center)
				{
					t2 = "2";
				}
				else if (myformat.Alignment == StringAlignment.Near)
				{
					t2 = "1";
				}
				else
				{
					t2 = "3";
				}
				if (this.SaveFont(myf, this.r_font))
				{
					this.r_font = myf;
				}
				if (backcolor != Color.White)
				{
					this.DrawFillRect(myrect, backcolor);
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				switch (mytextstyle)
				{
					case 0:
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						break;
					case 1:
						if (includemargins)
						{
							this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						else
						{
							this.MyWrite("th", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						break;
					case 2:
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Gray, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Gray, t2, t, myformat.FormatFlags);
						}
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						break;
					case 3:
						if (includemargins)
						{
							this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Gray, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						else
						{
							this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Gray, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						if (includemargins)
						{
							this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						else
						{
							this.MyWrite("th", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags, Conversions.ToString(angle));
						}
						break;
					case 4:
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
						}
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.White, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.White, t2, t, myformat.FormatFlags);
						}
						break;
					case 5:
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left - (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top - (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X - (float)this.ShapeDepth), this.MyConvTo(myrect.Y - (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
						}
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.White, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.White, t2, t, myformat.FormatFlags);
						}
						break;
					case 6:
						{
							for (int i = this.ShapeDepth; i >= 0; i = checked(i + -1))
							{
								if (includemargins)
								{
									this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left - this.MyConvFrom((float)i)), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + this.MyConvFrom((float)i)), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
								}
								else
								{
									this.MyWrite("t", this.MyConvTo(myrect.X - this.MyConvFrom((float)i)), this.MyConvTo(myrect.Y + this.MyConvFrom((float)i)), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
								}
							}
							Color t3;
							if (textforecolor == Color.Black)
							{
								t3 = Color.Red;
							}
							else
							{
								t3 = textforecolor;
							}
							if (includemargins)
							{
								this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, t3, t2, t, myformat.FormatFlags);
							}
							else
							{
								this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, t3, t2, t, myformat.FormatFlags);
							}
							break;
						}
					default:
						if (includemargins)
						{
							this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						else
						{
							this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
						}
						break;
				}
			}
			this.Currentx = myrect.X + myrect.Width;
			this.mylastdrawtextheight = this.MyConvTo(myrect.Height);
			this.mylastdrawtextwidth = this.MyConvTo(myrect.Width);
			if (Operators.CompareString(myborder, "", false) != 0)
			{
				float[] array = new float[4];
				array = VB2008Print.ParaseBorder(myborder);
				if (array[0] == array[1] & array[1] == array[2] & array[2] == array[3])
				{
					if (array[0] != 0f)
					{
						this.DrawRect(myrect.X, myrect.Y, myrect.Width, myrect.Height, linecolor, array[0]);
					}
				}
				else
				{
					if (array[0] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y, myrect.X, myrect.Y + myrect.Height, linecolor, array[0]);
					}
					if (array[1] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y, myrect.X + myrect.Width, myrect.Y, linecolor, array[1]);
					}
					if (array[2] != 0f)
					{
						this.DrawLine(myrect.X + myrect.Width, myrect.Y, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[2]);
					}
					if (array[3] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y + myrect.Height, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[3]);
					}
				}
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0009A070 File Offset: 0x00098270
		private void DrawTextTrue(string text, RectangleF myrect, Font myf, Brush textbrush, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor)
		{
			text += "";
			int num = 1;
			string t;
			string t2;
			checked
			{
				do
				{
					if (Strings.InStr(text, Conversions.ToString(Strings.Chr(num)), CompareMethod.Binary) > 0)
					{
						text = Strings.Replace(text, Conversions.ToString(Strings.Chr(num)), "", 1, -1, CompareMethod.Binary);
					}
					num++;
				}
				while (num <= 7);
				if (myformat.LineAlignment == StringAlignment.Center)
				{
					t = "2";
				}
				else if (myformat.LineAlignment == StringAlignment.Near)
				{
					t = "1";
				}
				else
				{
					t = "3";
				}
				if (myformat.Alignment == StringAlignment.Center)
				{
					t2 = "2";
				}
				else if (myformat.Alignment == StringAlignment.Near)
				{
					t2 = "1";
				}
				else
				{
					t2 = "3";
				}
				if (this.SaveFont(myf, this.r_font))
				{
					this.r_font = myf;
				}
				if (backcolor != Color.White)
				{
					this.DrawFillRect(myrect, backcolor);
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				if (includemargins)
				{
					this.MyWrite("t2", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, this.SaveBrush(textbrush), t2, t, myformat.FormatFlags);
				}
				else
				{
					this.MyWrite("t2", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, this.SaveBrush(textbrush), t2, t, myformat.FormatFlags);
				}
			}
			this.Currentx = myrect.X + myrect.Width;
			this.mylastdrawtextheight = this.MyConvTo(myrect.Height);
			this.mylastdrawtextwidth = this.MyConvTo(myrect.Width);
			if (Operators.CompareString(myborder, "", false) != 0)
			{
				float[] array = new float[4];
				array = VB2008Print.ParaseBorder(myborder);
				if (array[0] == array[1] & array[1] == array[2] & array[2] == array[3])
				{
					if (array[0] != 0f)
					{
						this.DrawRect(myrect.X, myrect.Y, myrect.Width, myrect.Height, linecolor, array[0]);
					}
				}
				else
				{
					if (array[0] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y, myrect.X, myrect.Y + myrect.Height, linecolor, array[0]);
					}
					if (array[1] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y, myrect.X + myrect.Width, myrect.Y, linecolor, array[1]);
					}
					if (array[2] != 0f)
					{
						this.DrawLine(myrect.X + myrect.Width, myrect.Y, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[2]);
					}
					if (array[3] != 0f)
					{
						this.DrawLine(myrect.X, myrect.Y + myrect.Height, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[3]);
					}
				}
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0009A410 File Offset: 0x00098610
		private void MyDrawText2(float x, float y, float mywidth, float myheight, string s, string mybrushstring, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
		{
			Brush brush = VB2008Print.RestoreBrush(mybrushstring);
			this.MyDrawTextOut(x, y, mywidth, myheight, s, brush, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical);
			brush.Dispose();
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0009A448 File Offset: 0x00098648
		private void MyDrawText2(float x, float y, float mywidth, float myheight, string s, string mybrushstring, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
		{
			Brush brush = VB2008Print.RestoreBrush(mybrushstring);
			this.MyDrawTextOut(x, y, mywidth, myheight, s, brush, myHalg, myValg, myflags);
			brush.Dispose();
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0009A47C File Offset: 0x0009867C
		private void MyDrawText(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
		{
			this.MyDrawTextOut(x, y, mywidth, myheight, s, new SolidBrush(color), myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0009A4AC File Offset: 0x000986AC
		private void MyDrawText(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
		{
			this.MyDrawTextOut(x, y, mywidth, myheight, s, new SolidBrush(color), myHalg, myValg, myflags);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0009A4D4 File Offset: 0x000986D4
		private void MyDrawTextOut(float x, float y, float mywidth, float myheight, string s, Brush mybrush, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			if (!mulline)
			{
				stringFormatFlags |= StringFormatFlags.NoWrap;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoWrap;
			}
			if (overflow)
			{
				stringFormatFlags |= StringFormatFlags.NoClip;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoClip;
			}
			if (directrighttoleft)
			{
				stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
			}
			if (directionVertical)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			this.MyDrawTextOut(x, y, mywidth, myheight, s, mybrush, myHalg, myValg, stringFormatFlags);
			stringFormat.Dispose();
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0009A55C File Offset: 0x0009875C
		private void MyDrawTextOut(float x, float y, float mywidth, float myheight, string s, Brush mybrush, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags = (myflags & ~StringFormatFlags.LineLimit);
			stringFormat.Alignment = myHalg;
			stringFormat.LineAlignment = myValg;
			mywidth += 1f;
			RectangleF layoutRectangle = new RectangleF(x + (float)this.mypagesetting.Margins.Left, y + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawString(s, this.myfont, mybrush, layoutRectangle, stringFormat);
			this.myg.Transform = transform;
			stringFormat.Dispose();
			layoutRectangle = default(RectangleF);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00007217 File Offset: 0x00005417
		private void DrawMargin()
		{
			this.MyWrite("mydrawmargin", "");
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0009A618 File Offset: 0x00098818
		private void MyDrawMargin()
		{
			checked
			{
				if (!this.isprinttoprinter && this.IsDrawmargin)
				{
					this.myg.DrawRectangle(new Pen(Color.Red, 2f), -2, -2, this.mypagesetting.Margins.Left - 2, this.mypagesetting.Margins.Top - 2);
					this.myg.DrawRectangle(new Pen(Color.Red, 2f), unchecked(this.MyConvTo(this.PaperPrintWidth) + (float)this.mypagesetting.Margins.Left + 2f), -2f, (float)this.mypagesetting.Margins.Right, (float)(this.mypagesetting.Margins.Top - 2));
					this.myg.DrawRectangle(new Pen(Color.Red, 2f), -2f, unchecked(this.MyConvTo(this.PaperPrintHeight) + (float)this.mypagesetting.Margins.Top + 2f), (float)(this.mypagesetting.Margins.Left - 2), (float)(this.mypagesetting.Margins.Bottom + 2));
					this.myg.DrawRectangle(new Pen(Color.Red, 2f), unchecked(this.MyConvTo(this.PaperPrintWidth) + (float)this.mypagesetting.Margins.Left + 2f), unchecked(this.MyConvTo(this.PaperPrintHeight) + (float)this.mypagesetting.Margins.Top + 2f), (float)(this.mypagesetting.Margins.Right + 2), (float)(this.mypagesetting.Margins.Bottom + 2));
				}
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0009A7D8 File Offset: 0x000989D8
		public void GetPageAndPaperSettings(int thepage)
		{
			checked
			{
				if (thepage >= 0)
				{
					string[] array;
					try
					{
						array = Strings.Split(this.mypages[0].ToString(), "\u0002\u0004", -1, CompareMethod.Binary);
					}
					catch (Exception ex)
					{
						return;
					}
					if (thepage <= Information.UBound(array, 1))
					{
						string expression = array[thepage];
						string[] array2 = Strings.Split(expression, "\u0001\u0003", -1, CompareMethod.Binary);
						bool flag = true;
						int num = 0;
						int num2 = array2.Length - 1;
						int i = num;
						while (i <= num2)
						{
							try
							{
								goto IL_331;
							}
							catch (Exception ex2)
							{
								goto IL_331;
							}
							goto Block_4;
						IL_328:
							i++;
							continue;
						Block_4:
							string[] array3;
							try
							{
							IL_83:
								foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
								{
									PaperSize paperSize = (PaperSize)obj;
									if (paperSize.Kind == (PaperKind)Conversions.ToInteger(array3[1]) & paperSize.Kind != PaperKind.Custom)
									{
										this.mypagesetting.PaperSize = paperSize;
										if (this.mypagesetting.PaperSize.Width == 0)
										{
											if (this.IsShowErrorMSG)
											{
												Interaction.MsgBox("控件纸张类型出现错误，将使用A4纸进行打印\r\n原因是本控件调用.NET的PageSetupDialog方法时不能返回您选择的正确的纸张类型（经上网查询，应该是.NET本身的原因）\r\n如果您在本控件的页面设置中更换了打印机，而这两个打印机所支持的纸张类型不一致，就有可能出现此问题。\r\n解决办法是，不要在页面设置中更换打印机，而是应该在控制面版中将要进行打印输出的打印机设置为默认打印机。", MsgBoxStyle.OkOnly, "提示信息");
											}
											try
											{
												foreach (object obj2 in this.Pd.PrinterSettings.PaperSizes)
												{
													PaperSize paperSize2 = (PaperSize)obj2;
													if (paperSize2.Kind == PaperKind.A4)
													{
														this.mypagesetting.PaperSize = paperSize2;
														flag = false;
														break;
													}
												}
											}
											finally
											{
												IEnumerator enumerator2;
												if (enumerator2 is IDisposable)
												{
													(enumerator2 as IDisposable).Dispose();
												}
											}
										}
										flag = false;
									IL_17A:
										goto IL_328;
									}
								}
								goto IL_17A;
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
						IL_195:
							string left;
							if (Operators.CompareString(left, "orientation", false) == 0)
							{
								if (Operators.CompareString(array3[1], "1", false) == 0)
								{
									this.mypagesetting.Landscape = true;
									goto IL_328;
								}
								this.mypagesetting.Landscape = false;
								goto IL_328;
							}
							else
							{
								if (Operators.CompareString(left, "leftmargin", false) == 0)
								{
									this.mypagesetting.Margins.Left = Conversions.ToInteger(array3[1]);
									goto IL_328;
								}
								if (Operators.CompareString(left, "topmargin", false) == 0)
								{
									this.mypagesetting.Margins.Top = Conversions.ToInteger(array3[1]);
									goto IL_328;
								}
								if (Operators.CompareString(left, "bottommargin", false) == 0)
								{
									this.mypagesetting.Margins.Bottom = Conversions.ToInteger(array3[1]);
									goto IL_328;
								}
								if (Operators.CompareString(left, "rightmargin", false) == 0)
								{
									this.mypagesetting.Margins.Right = Conversions.ToInteger(array3[1]);
									goto IL_328;
								}
								if (Operators.CompareString(left, "paperzdy", false) != 0)
								{
									goto IL_328;
								}
								if (Operators.CompareString(Strings.Trim(array3[1] + ""), "", false) == 0)
								{
									goto IL_328;
								}
								if (flag)
								{
									string[] array4 = Strings.Split(array3[1], "\u0006", -1, CompareMethod.Binary);
									string name = Strings.Trim(array4[0] + "");
									int width = Conversions.ToInteger(array4[1]);
									int height = Conversions.ToInteger(array4[2]);
									bool flag2 = this.isstarting;
									this.isstarting = false;
									this.PaperSize = new PaperSize(name, width, height);
									this.isstarting = flag2;
									goto IL_328;
								}
								goto IL_328;
							}
						IL_331:
							array3 = Strings.Split(array2[i], "\0", -1, CompareMethod.Binary);
							left = array3[0];
							if (Operators.CompareString(left, "papersize", false) == 0)
							{
								goto IL_83;
							}
							goto IL_195;
						}
						try
						{
							array2 = null;
							array = null;
						}
						catch (Exception ex3)
						{
						}
					}
				}
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0009AB9C File Offset: 0x00098D9C
		private void PrintWaterMark()
		{
			if (Operators.CompareString(Strings.Trim(this.mywatermarktext), "", false) != 0)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags &= ~StringFormatFlags.LineLimit;
				if (!this.mywatermarklandscape)
				{
					stringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
				}
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				Color textforecolor = Color.FromArgb((int)this.mywatermarkopacity, this.mywatermarkcolor);
				RectangleF rectangleF = new RectangleF(0f, 0f, this.PaperPrintWidth, this.PaperPrintHeight);
				this.DrawOutText(this.mywatermarktext, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height, this.mywatermarkfont, "", textforecolor, stringFormat, 0f, false, Color.White, Color.White, 1, 0f);
				this.Currentx = 0f;
				this.Currenty = 0f;
				stringFormat.Dispose();
				rectangleF = default(RectangleF);
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0009ACA8 File Offset: 0x00098EA8
		private void MyParasePage(int num)
		{
			checked
			{
				if (num != 0)
				{
					ColorConverter colorConverter = new ColorConverter();
					FontConverter fontConverter = new FontConverter();
					string[] array = Strings.Split(this.mypages[num].ToString(), "\u0001\u0003", -1, CompareMethod.Binary);
					MemoryStream memoryStream = null;
					int num2 = 0;
					int num3 = array.Length - 1;
					int i = num2;
					while (i <= num3)
					{
						try
						{
						}
						catch (Exception ex)
						{
						}
						string[] array2 = Strings.Split(array[i], "\0", -1, CompareMethod.Binary);
						string left = array2[0];
						if (Operators.CompareString(left, "papersize", false) == 0)
						{
							try
							{
								foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
								{
									PaperSize paperSize = (PaperSize)obj;
									if (paperSize.Kind == (PaperKind)Conversions.ToInteger(array2[1]))
									{
										this.mypagesetting.PaperSize = paperSize;
									}
								}
								goto IL_13C2;
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							goto IL_E7;
						}
						goto IL_E7;
					IL_13C2:
						i++;
						continue;
					IL_E7:
						if (Operators.CompareString(left, "orientation", false) == 0)
						{
							if (Operators.CompareString(array2[1], "1", false) == 0)
							{
								this.mypagesetting.Landscape = true;
								goto IL_13C2;
							}
							this.mypagesetting.Landscape = false;
							goto IL_13C2;
						}
						else
						{
							if (Operators.CompareString(left, "leftmargin", false) == 0)
							{
								this.mypagesetting.Margins.Left = Conversions.ToInteger(array2[1]);
								goto IL_13C2;
							}
							if (Operators.CompareString(left, "topmargin", false) == 0)
							{
								this.mypagesetting.Margins.Top = Conversions.ToInteger(array2[1]);
								goto IL_13C2;
							}
							if (Operators.CompareString(left, "bottommargin", false) == 0)
							{
								this.mypagesetting.Margins.Bottom = Conversions.ToInteger(array2[1]);
								goto IL_13C2;
							}
							if (Operators.CompareString(left, "rightmargin", false) == 0)
							{
								this.mypagesetting.Margins.Right = Conversions.ToInteger(array2[1]);
								goto IL_13C2;
							}
							if (Operators.CompareString(left, "setpage", false) == 0)
							{
								this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
								this.Pd.DefaultPageSettings = this.mypagesetting;
								goto IL_13C2;
							}
							if (Operators.CompareString(left, "f", false) == 0)
							{
								this.TextFont = (Font)fontConverter.ConvertFromString(array2[1]);
								if (this.PageScale != 1f & this.isprinttoprinter)
								{
									this.TextFont = new Font(this.TextFont.FontFamily, unchecked(this.TextFont.Size * this.PageScale), this.TextFont.Style, this.TextFont.Unit, this.TextFont.GdiCharSet, this.TextFont.GdiVerticalFont);
									goto IL_13C2;
								}
								goto IL_13C2;
							}
							else
							{
								Color color;
								if (Operators.CompareString(left, "l", false) == 0)
								{
									float x = Conversions.ToSingle(array2[1]);
									float y = Conversions.ToSingle(array2[2]);
									float x2 = Conversions.ToSingle(array2[3]);
									float y2 = Conversions.ToSingle(array2[4]);
									object obj2 = colorConverter.ConvertFromString(array2[5]);
									this.MyDrawline(x, y, x2, y2, (obj2 != null) ? ((Color)obj2) : color, Conversions.ToSingle(array2[6]));
									goto IL_13C2;
								}
								if (Operators.CompareString(left, "lines", false) == 0)
								{
									this.MyDrawLines(array2[1], array2[2]);
									goto IL_13C2;
								}
								if (Operators.CompareString(left, "curve", false) == 0)
								{
									switch (array2.Length)
									{
										case 3:
											this.MyDrawCurve(array2[1], array2[2]);
											goto IL_13C2;
										case 4:
											this.MyDrawCurve(array2[1], array2[2], array2[3]);
											goto IL_13C2;
										case 5:
											this.MyDrawCurve(array2[1], array2[2], array2[3], array2[4]);
											goto IL_13C2;
										case 6:
											this.MyDrawCurve(array2[1], array2[2], array2[3], array2[4], array2[5]);
											goto IL_13C2;
										default:
											goto IL_13C2;
									}
								}
								else if (Operators.CompareString(left, "closedcurve", false) == 0)
								{
									if (array2.Length == 5)
									{
										this.MyDrawClosedCurve(array2[1], array2[2], array2[3], array2[4]);
										goto IL_13C2;
									}
									this.MyDrawClosedCurve(array2[1], array2[2]);
									goto IL_13C2;
								}
								else if (Operators.CompareString(left, "fclosedcurve", false) == 0)
								{
									if (array2.Length == 5)
									{
										this.MyDrawFillClosedCurve(array2[1], array2[2], array2[3], array2[4]);
										goto IL_13C2;
									}
									if (array2.Length == 4)
									{
										this.MyDrawFillClosedCurve(array2[1], array2[2], array2[3]);
										goto IL_13C2;
									}
									this.MyDrawFillClosedCurve(array2[1], array2[2]);
									goto IL_13C2;
								}
								else
								{
									if (Operators.CompareString(left, "dl", false) == 0)
									{
										float x3 = Conversions.ToSingle(array2[1]);
										float y3 = Conversions.ToSingle(array2[2]);
										float x4 = Conversions.ToSingle(array2[3]);
										float y4 = Conversions.ToSingle(array2[4]);
										object obj3 = colorConverter.ConvertFromString(array2[5]);
										this.MyDrawDashline(x3, y3, x4, y4, (obj3 != null) ? ((Color)obj3) : color, Conversions.ToSingle(array2[6]), (DashStyle)Conversions.ToInteger(array2[7]));
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "r", false) == 0)
									{
										float x5 = Conversions.ToSingle(array2[1]);
										float y5 = Conversions.ToSingle(array2[2]);
										float mywidth = Conversions.ToSingle(array2[3]);
										float myheight = Conversions.ToSingle(array2[4]);
										object obj4 = colorConverter.ConvertFromString(array2[5]);
										this.MyDrawRect(x5, y5, mywidth, myheight, (obj4 != null) ? ((Color)obj4) : color, Conversions.ToSingle(array2[6]));
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "rect", false) == 0)
									{
										this.MyDrawRect(array2[1], array2[2]);
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "frect", false) == 0)
									{
										this.MyDrawFillRect(array2[1], array2[2]);
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "rects", false) == 0)
									{
										this.MyDrawRectangles(array2[1], array2[2]);
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "frects", false) == 0)
									{
										this.MyDrawFillRectangles(array2[1], array2[2]);
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "polygon", false) == 0)
									{
										this.MyDrawPolygon(array2[1], array2[2]);
										goto IL_13C2;
									}
									if (Operators.CompareString(left, "fpolygon", false) == 0)
									{
										if (array2.Length == 4)
										{
											this.MyDrawFillPolygon(array2[1], array2[2], array2[3]);
											goto IL_13C2;
										}
										this.MyDrawFillPolygon(array2[1], array2[2]);
										goto IL_13C2;
									}
									else
									{
										if (Operators.CompareString(left, "i", false) == 0)
										{
											Image image;
											if (Versioned.IsNumeric(array2[1]))
											{
												memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
												image = Image.FromStream(memoryStream, true, true);
											}
											else
											{
												image = Module1.ConvertStringToImage(array2[1]);
											}
											this.MyDrawImage(image, Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]));
											image.Dispose();
											if (memoryStream != null)
											{
												memoryStream.Dispose();
											}
											memoryStream = null;
											goto IL_13C2;
										}
										if (Operators.CompareString(left, "p", false) == 0)
										{
											Image image = Module1.ConvertStringToImage(array2[1]);
											this.MyDrawImage(image, Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]));
											image.Dispose();
											goto IL_13C2;
										}
										if (Operators.CompareString(left, "i2", false) == 0)
										{
											Image image;
											if (Versioned.IsNumeric(array2[1]))
											{
												memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
												image = Image.FromStream(memoryStream, true, true);
											}
											else
											{
												image = Module1.ConvertStringToImage(array2[1]);
											}
											this.MyDrawImage(image, Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]), Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]));
											image.Dispose();
											if (memoryStream != null)
											{
												memoryStream.Dispose();
											}
											memoryStream = null;
											goto IL_13C2;
										}
										if (Operators.CompareString(left, "DrawImageUnscaledAndClipped", false) == 0)
										{
											Image image;
											if (Versioned.IsNumeric(array2[1]))
											{
												memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
												image = Image.FromStream(memoryStream, true, true);
											}
											else
											{
												image = Module1.ConvertStringToImage(array2[1]);
											}
											this.MyDrawImageUnscaledAndClipped(image, array2[2]);
											image.Dispose();
											if (memoryStream != null)
											{
												memoryStream.Dispose();
											}
											memoryStream = null;
											goto IL_13C2;
										}
										if (Operators.CompareString(left, "DrawImageUnscaled", false) == 0)
										{
											Image image;
											if (Versioned.IsNumeric(array2[1]))
											{
												memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
												image = Image.FromStream(memoryStream, true, true);
											}
											else
											{
												image = Module1.ConvertStringToImage(array2[1]);
											}
											this.MyDrawImageUnscaled(image, array2[2]);
											image.Dispose();
											if (memoryStream != null)
											{
												memoryStream.Dispose();
											}
											memoryStream = null;
											goto IL_13C2;
										}
										StringAlignment myHalg;
										StringAlignment myValg;
										if (Operators.CompareString(left, "t", false) != 0)
										{
											if (Operators.CompareString(left, "t2", false) != 0)
											{
												if (Operators.CompareString(left, "th", false) == 0)
												{
													if (Operators.CompareString(array2[7], "2", false) == 0)
													{
														myHalg = StringAlignment.Center;
													}
													else if (Operators.CompareString(array2[7], "3", false) == 0)
													{
														myHalg = StringAlignment.Far;
													}
													else
													{
														myHalg = StringAlignment.Near;
													}
													if (Operators.CompareString(array2[8], "2", false) == 0)
													{
														myValg = StringAlignment.Center;
													}
													else if (Operators.CompareString(array2[8], "3", false) == 0)
													{
														myValg = StringAlignment.Far;
													}
													else
													{
														myValg = StringAlignment.Near;
													}
													if (array2.Length > 11)
													{
														float x6 = Conversions.ToSingle(array2[1]);
														float y6 = Conversions.ToSingle(array2[2]);
														float mywidth2 = Conversions.ToSingle(array2[3]);
														float myheight2 = Conversions.ToSingle(array2[4]);
														string s = array2[5];
														object obj5 = colorConverter.ConvertFromString(array2[6]);
														this.MydrawtextHollow(x6, y6, mywidth2, myheight2, s, (obj5 != null) ? ((Color)obj5) : color, myHalg, myValg, Conversions.ToBoolean(array2[9]), Conversions.ToBoolean(array2[10]), Conversions.ToBoolean(array2[11]), Conversions.ToBoolean(array2[12]), Convert.ToSingle(Conversions.ToDecimal(array2[13])));
														goto IL_13C2;
													}
													float x7 = Conversions.ToSingle(array2[1]);
													float y7 = Conversions.ToSingle(array2[2]);
													float mywidth3 = Conversions.ToSingle(array2[3]);
													float myheight3 = Conversions.ToSingle(array2[4]);
													string s2 = array2[5];
													object obj6 = colorConverter.ConvertFromString(array2[6]);
													this.MydrawtextHollow(x7, y7, mywidth3, myheight3, s2, (obj6 != null) ? ((Color)obj6) : color, myHalg, myValg, (StringFormatFlags)Conversions.ToInteger(array2[9]), Convert.ToSingle(Conversions.ToDecimal(array2[10])));
													goto IL_13C2;
												}
												else
												{
													if (Operators.CompareString(left, "mydrawmargin", false) == 0)
													{
														this.MyDrawMargin();
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "rf", false) == 0)
													{
														float x8 = Conversions.ToSingle(array2[1]);
														float y8 = Conversions.ToSingle(array2[2]);
														float mywidth4 = Conversions.ToSingle(array2[3]);
														float myheight4 = Conversions.ToSingle(array2[4]);
														object obj7 = colorConverter.ConvertFromString(array2[5]);
														this.MyDrawFillRect(x8, y8, mywidth4, myheight4, (obj7 != null) ? ((Color)obj7) : color);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "arc", false) == 0)
													{
														float x9 = Conversions.ToSingle(array2[1]);
														float y9 = Conversions.ToSingle(array2[2]);
														float mywidth5 = Conversions.ToSingle(array2[3]);
														float myheight5 = Conversions.ToSingle(array2[4]);
														object obj8 = colorConverter.ConvertFromString(array2[5]);
														this.MyDrawArc(x9, y9, mywidth5, myheight5, (obj8 != null) ? ((Color)obj8) : color, Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]), Conversions.ToSingle(array2[8]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "arc2", false) == 0)
													{
														this.MyDrawArc2(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5], Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "bezier", false) == 0)
													{
														this.MyDrawBezier(array2[1], Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]), Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]), Conversions.ToSingle(array2[8]), Conversions.ToSingle(array2[9]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "beziers", false) == 0)
													{
														this.MyDrawBeziers(array2[1], array2[2]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "de", false) == 0)
													{
														float x10 = Conversions.ToSingle(array2[1]);
														float y10 = Conversions.ToSingle(array2[2]);
														float mywidth6 = Conversions.ToSingle(array2[3]);
														float myheight6 = Conversions.ToSingle(array2[4]);
														object obj9 = colorConverter.ConvertFromString(array2[5]);
														this.MyDrawEllipse(x10, y10, mywidth6, myheight6, (obj9 != null) ? ((Color)obj9) : color, Conversions.ToSingle(array2[6]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "ellipse", false) == 0)
													{
														this.MyDrawEllipse(array2[1], array2[2]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "dfe", false) == 0)
													{
														float x11 = Conversions.ToSingle(array2[1]);
														float y11 = Conversions.ToSingle(array2[2]);
														float mywidth7 = Conversions.ToSingle(array2[3]);
														float myheight7 = Conversions.ToSingle(array2[4]);
														object obj10 = colorConverter.ConvertFromString(array2[5]);
														this.MyDrawFillEllipse(x11, y11, mywidth7, myheight7, (obj10 != null) ? ((Color)obj10) : color);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "fellipse", false) == 0)
													{
														this.MyDrawFillEllipse(array2[1], array2[2]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "rtf", false) == 0)
													{
														this.MyDrawRTF(this.W_myrtfC[Conversions.ToInteger(array2[1])].mypi, Conversions.ToInteger(array2[2]), Conversions.ToInteger(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]), Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]), Conversions.ToSingle(array2[8]), Conversions.ToSingle(array2[9]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "pie", false) == 0)
													{
														this.MyDrawPie(array2[1], array2[2], array2[3], array2[4]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "fpie", false) == 0)
													{
														this.MyDrawFillPie(array2[1], array2[2], array2[3], array2[4]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "dp", false) == 0)
													{
														this.myDrawPath(array2[1], array2[2], array2[3]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "fp", false) == 0)
													{
														try
														{
															GraphicsPath graphicsPath = VB2008Print.RestoreGraphicsPath(array2[1], array2[2]);
															if (graphicsPath == null)
															{
																return;
															}
															Brush brush = VB2008Print.RestoreBrush(array2[3]);
															if (brush == null)
															{
																graphicsPath.Dispose();
															}
															else
															{
																this.myDrawFillPath(graphicsPath, brush);
																brush.Dispose();
																graphicsPath.Dispose();
															}
															goto IL_13C2;
														}
														catch (Exception ex2)
														{
															goto IL_13C2;
														}
													}
													if (Operators.CompareString(left, "resetrotate", false) == 0)
													{
														this.MyResetRotate();
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "rotate", false) == 0)
													{
														this.MyRotate(Conversions.ToDouble(array2[1]), Conversions.ToDouble(array2[2]), Conversions.ToDouble(array2[3]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "ttf", false) == 0)
													{
														this.myTranslateTransform(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "ttf2", false) == 0)
													{
														this.myTranslateTransform(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), (MatrixOrder)Conversions.ToInteger(array2[3]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "rtff", false) == 0)
													{
														this.myRotateTransform(Conversions.ToSingle(array2[1]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "rtff2", false) == 0)
													{
														this.myRotateTransform(Conversions.ToSingle(array2[1]), (MatrixOrder)Conversions.ToInteger(array2[2]));
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "drawmetaimage", false) == 0)
													{
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "drawchartlet", false) == 0)
													{
														this.MyDrawChartlet(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "drawexpress", false) == 0)
													{
														this.MyDrawExpression(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "setclip", false) == 0)
													{
														this.mySetClip(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "setclip2", false) == 0)
													{
														this.mySetClip(array2[1], array2[2], array2[3]);
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "resetclip", false) == 0)
													{
														this.myResetClip();
														goto IL_13C2;
													}
													if (Operators.CompareString(left, "i3", false) == 0)
													{
														Image image;
														if (Versioned.IsNumeric(array2[1]))
														{
															memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
															image = Image.FromStream(memoryStream, true, true);
														}
														else
														{
															image = Module1.ConvertStringToImage(array2[1]);
														}
														this.MyDrawImage(image, array2[2], Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]), Conversions.ToSingle(array2[6]), Conversions.ToInteger(array2[7]));
														image.Dispose();
														if (memoryStream != null)
														{
															memoryStream.Dispose();
															goto IL_13C2;
														}
														goto IL_13C2;
													}
													else if (Operators.CompareString(left, "i4", false) == 0)
													{
														Image image;
														if (Versioned.IsNumeric(array2[1]))
														{
															memoryStream = new MemoryStream(this.mypicture[Conversions.ToInteger(array2[1])].mypi);
															image = Image.FromStream(memoryStream, true, true);
														}
														else
														{
															image = Module1.ConvertStringToImage(array2[1]);
														}
														this.MyDrawImage(image, Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), Conversions.ToSingle(array2[5]), Conversions.ToSingle(array2[6]), Conversions.ToSingle(array2[7]), Conversions.ToInteger(array2[8]));
														image.Dispose();
														if (memoryStream != null)
														{
															memoryStream.Dispose();
															goto IL_13C2;
														}
														goto IL_13C2;
													}
													else if (Operators.CompareString(left, "drawicon", false) == 0)
													{
														Icon icon = Module1.ConvertStringToIcon(array2[3]);
														if (icon != null)
														{
															this.myDrawIcon(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), icon);
															goto IL_13C2;
														}
														goto IL_13C2;
													}
													else if (Operators.CompareString(left, "drawicon2", false) == 0)
													{
														Icon icon2 = Module1.ConvertStringToIcon(array2[2]);
														if (icon2 != null)
														{
															this.myDrawIcon(array2[1], icon2);
															goto IL_13C2;
														}
														goto IL_13C2;
													}
													else
													{
														if (Operators.CompareString(left, "shape", false) == 0)
														{
															this.MyDrawShape(array2[1], array2[2], Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]));
															goto IL_13C2;
														}
														goto IL_13C2;
													}
												}
											}
										}
										if (Operators.CompareString(array2[7], "2", false) == 0)
										{
											myHalg = StringAlignment.Center;
										}
										else if (Operators.CompareString(array2[7], "3", false) == 0)
										{
											myHalg = StringAlignment.Far;
										}
										else
										{
											myHalg = StringAlignment.Near;
										}
										if (Operators.CompareString(array2[8], "2", false) == 0)
										{
											myValg = StringAlignment.Center;
										}
										else if (Operators.CompareString(array2[8], "3", false) == 0)
										{
											myValg = StringAlignment.Far;
										}
										else
										{
											myValg = StringAlignment.Near;
										}
										if (Operators.CompareString(array2[0], "t2", false) == 0)
										{
											if (array2.Length > 10)
											{
												this.MyDrawText2(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5], array2[6], myHalg, myValg, Conversions.ToBoolean(array2[9]), Conversions.ToBoolean(array2[10]), Conversions.ToBoolean(array2[11]), Conversions.ToBoolean(array2[12]));
												goto IL_13C2;
											}
											this.MyDrawText2(Conversions.ToSingle(array2[1]), Conversions.ToSingle(array2[2]), Conversions.ToSingle(array2[3]), Conversions.ToSingle(array2[4]), array2[5], array2[6], myHalg, myValg, (StringFormatFlags)Conversions.ToInteger(array2[9]));
											goto IL_13C2;
										}
										else
										{
											if (array2.Length > 10)
											{
												float x12 = Conversions.ToSingle(array2[1]);
												float y12 = Conversions.ToSingle(array2[2]);
												float mywidth8 = Conversions.ToSingle(array2[3]);
												float myheight8 = Conversions.ToSingle(array2[4]);
												string s3 = array2[5];
												object obj11 = colorConverter.ConvertFromString(array2[6]);
												this.MyDrawText(x12, y12, mywidth8, myheight8, s3, (obj11 != null) ? ((Color)obj11) : color, myHalg, myValg, Conversions.ToBoolean(array2[9]), Conversions.ToBoolean(array2[10]), Conversions.ToBoolean(array2[11]), Conversions.ToBoolean(array2[12]));
												goto IL_13C2;
											}
											float x13 = Conversions.ToSingle(array2[1]);
											float y13 = Conversions.ToSingle(array2[2]);
											float mywidth9 = Conversions.ToSingle(array2[3]);
											float myheight9 = Conversions.ToSingle(array2[4]);
											string s4 = array2[5];
											object obj12 = colorConverter.ConvertFromString(array2[6]);
											this.MyDrawText(x13, y13, mywidth9, myheight9, s4, (obj12 != null) ? ((Color)obj12) : color, myHalg, myValg, (StringFormatFlags)Conversions.ToInteger(array2[9]));
											goto IL_13C2;
										}
									}
								}
							}
						}
					}
					try
					{
						fontConverter = null;
						array = null;
						colorConverter = null;
						memoryStream = null;
					}
					catch (Exception ex3)
					{
					}
				}
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0009C0D4 File Offset: 0x0009A2D4
		private void SetPages(int num)
		{
			if (this.GetPages() > 0 && num > 0)
			{
				if (this.mytype1.Checked)
				{
					this.cpage.Enabled = false;
					this.fpage.Enabled = false;
					this.ppage.Enabled = false;
					this.npage.Enabled = false;
					this.lpage.Enabled = false;
					this.PrintPreviewControl1.Columns = num;
					this.PrintPreviewControl1.Rows = checked((int)Math.Round(Math.Ceiling((double)this.GetPages() / (double)num)));
				}
				else if (this.GetPages() > 0)
				{
					this.cpage.Enabled = true;
					this.PrintPreviewControl1.Columns = num;
					this.PrintPreviewControl1.Rows = 1;
					string left = Conversions.ToString(this.cpage.SelectedItem);
					if (Operators.CompareString(left, "", false) == 0)
					{
						this.cpage.SelectedIndex = 0;
					}
					this.cpage_SelectedIndexChanged(null, null);
				}
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
		private void SetPages()
		{
			if (this.ToolStripMenuItem_7.Checked)
			{
				this.SetPages(1);
			}
			else if (this.ToolStripMenuItem_8.Checked)
			{
				this.SetPages(2);
			}
			else if (this.ToolStripMenuItem_9.Checked)
			{
				this.SetPages(3);
			}
			else if (this.ToolStripMenuItem_10.Checked)
			{
				this.SetPages(4);
			}
			else if (this.ToolStripMenuItem_11.Checked)
			{
				this.SetPages(5);
			}
			else if (this.ToolStripMenuItem_12.Checked)
			{
				this.SetPages(6);
			}
			else if (this.ToolStripMenuItem_13.Checked)
			{
				this.SetPages(8);
			}
			else if (this.ToolStripMenuItem_14.Checked)
			{
				this.SetPages(10);
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0009C298 File Offset: 0x0009A498
		private float PrintDGVOut(DataGridView mymstoprint, int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, bool autoformat, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
		{
			float result;
			if (Module1.G_CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(mymstoprint, this.myms);
				if (autoformat)
				{
					this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
					this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
				}
				result = this.PrintDGVOut(colsnum, thecol, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, autoresizewidth, autoresizerowheight, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, mytitleheight, myoneline1height, mysubtitleheight, myoneline2height, mytopheight, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, CanAddEmptyRow, mybottomheight, printwidth);
			}
			return result;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0009C334 File Offset: 0x0009A534
		private float PrintDGVOut(int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
		{
			StringFormat stringFormat;
			StringFormat stringFormat2;
			int num5;
			int[] array;
			int[] array3;
			int[] array4;
			float[] array5;
			float num14;
			float num15;
			float num16;
			float num17;
			mytree mytree;
			float[] array7;
			float result;
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.myms.ColumnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						int num3 = 0;
						int num4 = this.myms.RowCount - 1;
						for (int j = num3; j <= num4; j++)
						{
							string left = Conversions.ToString(this.myms.Rows[j].Cells[i].Tag);
							if (Operators.CompareString(left, "水平合并", false) != 0 & Operators.CompareString(left, "垂直合并", false) != 0 & Operators.CompareString(left, "合并", false) != 0 & Operators.CompareString(left, "不合并", false) != 0 & Operators.CompareString(left, "上合并", false) != 0 & Operators.CompareString(left, "下合并", false) != 0 & Operators.CompareString(left, "左合并", false) != 0 & Operators.CompareString(left, "右合并", false) != 0 & Operators.CompareString(left, "左上合并", false) != 0 & Operators.CompareString(left, "左下合并", false) != 0 & Operators.CompareString(left, "右上合并", false) != 0 & Operators.CompareString(left, "右下合并", false) != 0 & Operators.CompareString(left, "上边合并", false) != 0 & Operators.CompareString(left, "下边合并", false) != 0 & Operators.CompareString(left, "左边合并", false) != 0 & Operators.CompareString(left, "右边合并", false) != 0)
							{
								if (Operators.CompareString(Conversions.ToString(this.myms.Columns[i].Tag), "合并", false) == 0)
								{
									if (Operators.CompareString(Conversions.ToString(this.myms.Rows[j].Tag), "合并", false) == 0)
									{
										this.myms.Rows[j].Cells[i].Tag = "合并";
									}
									else
									{
										this.myms.Rows[j].Cells[i].Tag = "垂直合并";
									}
								}
								else if (Operators.CompareString(Conversions.ToString(this.myms.Rows[j].Tag), "合并", false) == 0)
								{
									this.myms.Rows[j].Cells[i].Tag = "水平合并";
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
				if (titleFont == null)
				{
					titleFont = new Font("黑体", 18f, FontStyle.Bold);
				}
				if (subtitlefont == null)
				{
					subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
				}
				if (topfont == null)
				{
					topfont = new Font("宋体", 10f, FontStyle.Regular);
				}
				if (bottomfont == null)
				{
					bottomfont = new Font("宋体", 10f, FontStyle.Regular);
				}
				stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				if (colsnum == 0)
				{
					num5 = this.myms.ColumnCount;
				}
				else
				{
					num5 = colsnum;
				}
				array = new int[num5 - 1 + 1];
				if (colsnum == 0)
				{
					thecol = new int[num5 - 1 + 1];
					int num6 = 0;
					int num7 = num5 - 1;
					for (int k = num6; k <= num7; k++)
					{
						thecol[k] = k;
					}
				}
				if (fromrow > torow)
				{
					fromrow = 0;
				}
				if (fromrow <= 0)
				{
					fromrow = 1;
				}
				if (torow <= 0)
				{
					torow = this.myms.RowCount;
				}
				fromrow--;
				torow--;
				int[] array2 = new int[num5 - 1 + 1];
				int num8 = 0;
				int num9 = num5 - 1;
				for (int k = num8; k <= num9; k++)
				{
					array[k] = thecol[k];
					array2[k] = this.myms.Columns[thecol[k]].DisplayIndex;
				}
				Array.Sort<int, int>(array2, array);
				array3 = new int[num5 + 1];
				array4 = new int[this.myms.RowCount + 1];
				int num10 = 0;
				int num11 = num5 - 1;
				for (int k = num10; k <= num11; k++)
				{
					array3[k] = this.myms.Columns[thecol[k]].Width;
				}
				array4[0] = Conversions.ToInteger(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0));
				int num12 = fromrow;
				int num13 = torow;
				for (int k = num12; k <= num13; k++)
				{
					array4[k + 1] = this.myms.Rows[k].Height;
				}
				array5 = new float[num5 - 1 + 1];
				int[] array6 = new int[num5 - 1 + 1];
				num14 = 0f;
				num15 = this.Currentx;
				num16 = num15;
				if (printwidth <= 0f)
				{
					num17 = unchecked(this.PaperPrintWidth - num16);
				}
				else
				{
					num17 = printwidth;
				}
				int num18 = 0;
				int num19 = num5 - 1;
				for (int k = num18; k <= num19; k++)
				{
					unchecked
					{
						if (this.myms.Columns[array[k]].Visible)
						{
							DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[k]];
							float num20 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
							array6[k] = dataGridViewColumn.Width;
							num14 += num20;
							array5[k] = num20;
						}
					}
				}
				mytree = new mytree(columnheadertree, this.myms);
				if (mytree.GetColumns() != this.myms.ColumnCount)
				{
					columnheadertree = null;
				}
				if (mytitleheight != 0f)
				{
					int columnHeadersHeight = this.myms.ColumnHeadersHeight;
					this.myms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
					this.myms.ColumnHeadersHeight = columnHeadersHeight;
				}
				else if (columnheadertree != null)
				{
				}
				array7 = new float[this.myms.ColumnCount - 1 + 1];
				if (autoresizewidth)
				{
					if (num14 == 0f)
					{
						if (this.IsShowErrorMSG)
						{
							Interaction.MsgBox("不能打印DatGridView表格，当前没有可供打印的列数据", MsgBoxStyle.OkOnly, "提示信息");
						}
						return 0f;
					}
					float num21 = num17 / num14;
					int num22 = 0;
					int num23 = num5 - 1;
					for (int k = num22; k <= num23; k++)
					{
						unchecked
						{
							array5[k] *= num21;
						}
						this.myms.Columns[array[k]].Width = (int)Math.Round((double)(unchecked((float)array6[k] * num21)));
						array7[array[k]] = array5[k];
					}
					num14 = 0f;
					int num24 = 0;
					int num25 = num5 - 1;
					for (int k = num24; k <= num25; k++)
					{
						unchecked
						{
							num14 += array5[k];
						}
					}
					if (autoresizerowheight)
					{
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
				}
				else
				{
					int num26 = 0;
					int num27 = num5 - 1;
					for (int k = num26; k <= num27; k++)
					{
						array7[array[k]] = array5[k];
					}
				}
				result = num14;
			}
			if (alignment == StringAlignment.Center)
			{
				float num28 = num17 - num14;
				num15 = num16 + num28 / 2f;
			}
			else if (alignment == StringAlignment.Far)
			{
				num15 = num16 + num17 - num14;
			}
			int currentPage = this.GetCurrentPage();
			float num29 = 0f;
			num29 = this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
			stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
			StringAlignment myHalg = StringAlignment.Near;
			string text = "";
			bool flag = false;
			StringAlignment myHalg2 = StringAlignment.Near;
			string text2 = "";
			bool flag2 = false;
			if (flag = VB2008Print.CanSpanPrint(lefttitle, middletitle, righttitle, ref text, ref myHalg))
			{
				if (Operators.CompareString(lefttitle, "", false) != 0)
				{
					myHalg = TableTopLeftTitleAlign;
				}
				else if (Operators.CompareString(middletitle, "", false) != 0)
				{
					myHalg = TableTopMiddleTitleAlign;
				}
				else if (Operators.CompareString(righttitle, "", false) != 0)
				{
					myHalg = TableTopRightTitleAlign;
				}
			}
			if (flag2 = VB2008Print.CanSpanPrint(bl, bm, br, ref text2, ref myHalg2))
			{
				if (Operators.CompareString(bl, "", false) != 0)
				{
					myHalg2 = TableBottomLeftTitleAlign;
				}
				else if (Operators.CompareString(bm, "", false) != 0)
				{
					myHalg2 = TableBottomMiddleTitleAlign;
				}
				else if (Operators.CompareString(br, "", false) != 0)
				{
					myHalg2 = TableBottomRightTitleAlign;
				}
			}
			float num30;
			float num31;
			float num32;
			float num33;
			float num34;
			float num35;
			if (mytitleheight == 0f)
			{
				if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
				{
					num30 = 0f;
					flag = false;
				}
				else if (flag)
				{
					num30 = this.MeasureCell(text, topfont, num17, stringFormat).Height;
				}
				else
				{
					SizeF sizeF = this.MeasureCell(lefttitle, topfont, num17 / 3f, stringFormat);
					SizeF sizeF2 = this.MeasureCell(middletitle, topfont, num17 / 3f, stringFormat);
					num30 = sizeF.Height;
					float height = sizeF2.Height;
					if (num30 < height)
					{
						num30 = height;
					}
					height = this.MeasureCell(righttitle, topfont, num17 / 3f, stringFormat).Height;
					if (num30 < height)
					{
						num30 = height;
					}
				}
				num31 = this.MeasureText(title, titleFont, num17, stringFormat).Height;
				if (num31 == 0f)
				{
					num32 = 0f;
				}
				else
				{
					num32 = (float)((double)this.MeasureText("游", titleFont, num14, stringFormat).Height / 2.5);
				}
				num33 = this.MeasureText(subtitle, subtitlefont, num17, stringFormat).Height;
				if (num33 == 0f)
				{
					num34 = 0f;
				}
				else
				{
					num34 = (float)((double)this.MeasureText("平", subtitlefont, num14, stringFormat).Height / 2.5);
				}
				if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(br, "", false) == 0 & Operators.CompareString(bm, "", false) == 0)
				{
					num35 = 0f;
					flag2 = false;
				}
				else
				{
					if (flag2)
					{
						num35 = this.MeasureCell(text2, bottomfont, num17, stringFormat).Height;
					}
					else
					{
						SizeF sizeF = this.MeasureCell(bl, bottomfont, num17 / 3f, stringFormat);
						SizeF sizeF2 = this.MeasureCell(bm, bottomfont, num17 / 3f, stringFormat);
						num35 = sizeF.Height;
						float height = sizeF2.Height;
						if (num35 < height)
						{
							num35 = height;
						}
						height = this.MeasureCell(br, bottomfont, num17 / 3f, stringFormat).Height;
						if (num35 < height)
						{
							num35 = height;
						}
					}
					num35 += this.MeasureText("测试", new Font("宋体", 12f)).Height / 8f;
				}
				if (this.OuterBorder)
				{
					num30 = num30 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
					num35 = num35 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
				}
				else if (this.IsUseDoubleLine)
				{
					num30 += this.DoubleLineSpace / 2f;
					num35 += this.DoubleLineSpace / 2f;
				}
			}
			else
			{
				num31 = mytitleheight;
				num33 = mysubtitleheight;
				num32 = myoneline1height;
				num34 = myoneline2height;
				num30 = mytopheight;
				num35 = mybottomheight;
			}
			int num36 = -1;
			int num37 = 0;
			checked
			{
				int num38 = this.myms.RowCount - 1;
				int k = num37;
				while (k <= num38)
				{
					if (!this.myms.Rows[k].Visible)
					{
						k++;
					}
					else
					{
						num36 = k;
					IL_B68:
						mytree mytree2;
						float doubleLineSpace;
						float num42;
						bool flag3;
						float[] array8;
						float currenty;
						Color textforecolor=new Color();
						bool mulline;
						unchecked
						{
							if (num36 == -1)
							{
								this.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false), true);
							}
							else
							{
								if (this.Currenty > 0f)
								{
									this.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num36].Height, false), true);
								}
								if (num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num36].Height, false) > this.PaperPrintHeight)
								{
									try
									{
										this.myms.Rows[num36].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - (num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false))), false)));
									}
									catch (Exception ex2)
									{
									}
								}
							}
							currentPage = this.GetCurrentPage();
							mytree2 = new mytree(columnheadertree, this.myms, array7);
							float num39 = 0f;
							float num40 = 0f;
							doubleLineSpace = this.DoubleLineSpace;
							float num41 = this.ConvFromDisplay((float)this.myms.ColumnHeadersHeight, false);
							num42 = 0f;
							flag3 = true;
							array8 = new float[4];
							array8 = VB2008Print.ParaseBorder(myborder);
							int num43 = fromrow;
							int num44 = torow;
							k = num43;
							while (k <= num44 && !this.CancelDocument)
							{
								this.Currentx = num15;
								if (!(currentPage != this.GetCurrentPage() | k == fromrow))
								{
									goto IL_2085;
								}
								currentPage = this.GetCurrentPage();
								flag3 = true;
								if (k == 0 || reppagetitle)
								{
									if (Operators.CompareString(title, "", false) != 0)
									{
										this.Currentx = num16;
										this.DrawText(title, num17, num31, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
										this.NewRow(num31 + num32);
									}
									this.Currentx = num16;
									if (Operators.CompareString(subtitle, "", false) != 0)
									{
										this.DrawText(subtitle, num17, num33, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
										this.NewRow(num33 + num34);
									}
									if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
									{
										this.NewRow(num30);
									}
									else if (flag)
									{
										this.Currentx = num16;
										this.DrawText(text, num17, num30, topfont, myHalg, StringAlignment.Near, true, false, false, false, 0f, 0);
										this.NewRow(num30);
									}
									else
									{
										this.Currentx = num16;
										this.DrawText(lefttitle, num17 / 3f, num30, topfont, TableTopLeftTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
										this.DrawText(middletitle, num17 / 3f, num30, topfont, TableTopMiddleTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
										this.DrawText(righttitle, num17 / 3f, num30, topfont, TableTopRightTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
										this.NewRow(num30);
									}
								}
								this.Currentx = num15;
								currenty = this.Currenty;
								num42 = 0f;
								if (this.myms.ColumnHeadersVisible)
								{
									checked
									{
										if (columnheadertree == null)
										{
											bool flag4 = true;
											int num45 = 0;
											int num46 = num5 - 1;
											for (int l = num45; l <= num46; l++)
											{
												DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
												unchecked
												{
													if (dataGridViewColumn.Visible)
													{
														if (this.IsUseDoubleLine)
														{
															if (flag4)
															{
																this.Currentx += doubleLineSpace / 2f;
															}
															else
															{
																this.Currentx += doubleLineSpace;
															}
															this.Currenty = currenty + doubleLineSpace / 2f;
															this.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l] - doubleLineSpace, num41 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
														}
														else
														{
															this.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l], num41, myborder, PrintBackColor, minfontsize);
														}
														flag4 = false;
														num42 += array5[l];
													}
												}
											}
										}
										else
										{
											int leves = mytree2.GetLeves();
											int num47 = 0;
											int num48 = num5 - 1;
											for (int l = num47; l <= num48; l++)
											{
												unchecked
												{
													if (this.myms.Columns[array[l]].Visible)
													{
														num42 += array5[l];
													}
												}
											}
											int num49 = 1;
											int num50 = leves;
											for (int m = num49; m <= num50; m++)
											{
												this.Currentx = num15;
												int num51;
												unchecked
												{
													if (this.IsUseDoubleLine)
													{
														this.Currentx = num15 + doubleLineSpace / 2f;
													}
													this.Currenty = currenty + num29 / (float)leves * (float)(checked(m - 1));
													if (this.IsUseDoubleLine)
													{
														this.Currenty += doubleLineSpace / 2f;
													}
													num51 = 0;
												}
												int num52 = num5 - 1;
												for (int l = num51; l <= num52; l++)
												{
													DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
													unchecked
													{
														if (dataGridViewColumn.Visible)
														{
															float num53 = mytree2.GetCellHeight(array[l], m);
															float cellWidth = mytree2.GetCellWidth(array[l], m);
															num53 = this.ConvFromDisplay(num53, false);
															string nodeText = mytree2.GetNodeText(array[l], m);
															if (num53 == 0f | cellWidth == 0f)
															{
																this.Currentx += array5[l];
															}
															else if (dataGridViewColumn.Visible)
															{
																Font font = mytree2.GetNodeFont(array[l], m);
																if (font == null)
																{
																	font = Module1.GetDGVHeaderFont(dataGridViewColumn);
																}
																textforecolor = mytree2.GetNodeForeColor(array[l], m);
																if (textforecolor.IsEmpty)
																{
																	textforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
																}
																mulline = Module1.GetDGVHeaderMulline(dataGridViewColumn);
																Color backcolor = mytree2.GetNodeBackColor(array[l], m);
																if (backcolor.IsEmpty)
																{
																	backcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
																}
																mulline = true;
																if (this.IsUseDoubleLine)
																{
																	if (!PrintBackColor)
																	{
																		this.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
																	}
																	else
																	{
																		this.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
																	}
																	this.Currentx = this.Currentx + array5[l] + doubleLineSpace - cellWidth;
																}
																else
																{
																	if (!PrintBackColor)
																	{
																		this.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
																	}
																	else
																	{
																		this.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
																	}
																	this.Currentx = this.Currentx + array5[l] - cellWidth;
																}
															}
														}
													}
												}
											}
										}
									}
									if (this.IsUseDoubleLine)
									{
										this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num41);
										this.DrawLine(new Pen(this.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
										this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num41);
									}
									if (this.OuterBorder)
									{
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num41);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num41);
									}
									flag3 = false;
								}
								this.Currentx = num15;
								this.Currenty = currenty + num29;
								if (this.Currenty + this.ConvFromDisplay((float)this.myms.Rows[k].Height, false) > this.PaperPrintHeight)
								{
									try
									{
										this.myms.Rows[k].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - this.Currenty), false)));
										goto IL_2085;
									}
									catch (Exception ex3)
									{
										goto IL_2085;
									}
									goto IL_162A;
								}
								goto IL_2085;
							IL_207A:
								DataGridViewRow dataGridViewRow;
								checked
								{
									k++;
									continue;
								IL_162A:
									dataGridViewRow = this.myms.Rows[k];
									bool flag4 = true;
									currenty = this.Currenty;
									num42 = 0f;
									int num54 = 0;
									int num55 = num5 - 1;
									for (int l = num54; l <= num55; l++)
									{
										if (Module1.G_CancelDocument)
										{
											goto IL_278C;
										}
										DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
										unchecked
										{
											if (dataGridViewColumn.Visible)
											{
												num40 = array5[l];
												num42 += num40;
												num39 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
												string left2 = Conversions.ToString(dataGridViewRow.Cells[array[l]].Tag);
												if (Operators.CompareString(left2, "垂直合并", false) == 0)
												{
													goto IL_185F;
												}
												if (Operators.CompareString(left2, "上合并", false) == 0)
												{
													goto IL_185F;
												}
												if (Operators.CompareString(left2, "下合并", false) == 0)
												{
													goto IL_185F;
												}
												if (Operators.CompareString(left2, "水平合并", false) != 0)
												{
													if (Operators.CompareString(left2, "左合并", false) != 0)
													{
														if (Operators.CompareString(left2, "右合并", false) != 0)
														{
															if (Operators.CompareString(left2, "合并", false) != 0)
															{
																if (Operators.CompareString(left2, "左上合并", false) != 0)
																{
																	if (Operators.CompareString(left2, "左下合并", false) != 0)
																	{
																		if (Operators.CompareString(left2, "右上合并", false) != 0)
																		{
																			if (Operators.CompareString(left2, "右下合并", false) != 0)
																			{
																				if (Operators.CompareString(left2, "上边合并", false) != 0)
																				{
																					if (Operators.CompareString(left2, "下边合并", false) != 0)
																					{
																						if (Operators.CompareString(left2, "左边合并", false) != 0)
																						{
																							if (Operators.CompareString(left2, "右边合并", false) != 0)
																							{
																								if (Operators.CompareString(left2, "#*已水平合并*#", false) == 0)
																								{
																									goto IL_1942;
																								}
																								if (Operators.CompareString(left2, "#*已垂直合并*#", false) == 0)
																								{
																									this.Currentx += array5[l];
																									goto IL_1942;
																								}
																								goto IL_1878;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
															this.GetHVMergeWidthAndHeight(this.myms, num5, l, k, array, array5, torow, ref num40, ref num39);
															goto IL_1878;
														}
													}
												}
												int num56;
												num40 = VB2008Print.GetHMergeWidth(this.myms, num5, l, k, array, array5, ref num56, true);
											IL_1878:
												if (this.IsUseDoubleLine)
												{
													if (flag4)
													{
														this.Currentx += doubleLineSpace / 2f;
													}
													else
													{
														this.Currentx += doubleLineSpace;
													}
													if (flag3)
													{
														this.Currenty = currenty + doubleLineSpace / 2f;
													}
													else
													{
														this.Currenty = currenty + doubleLineSpace / 2f;
													}
													this.MyDrawDGVCell(this.myms.Rows[k].Cells[array[l]], num40 - doubleLineSpace, num39 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
												}
												else
												{
													this.MyDrawDGVCell(this.myms.Rows[k].Cells[array[l]], num40, num39, myborder, PrintBackColor, minfontsize);
												}
												flag4 = false;
												goto IL_1942;
											IL_185F:
												num39 = this.GetVMergeHeight(this.myms, l, k, array, torow, ref num56, true);
												goto IL_1878;
											}
										IL_1942:;
										}
									}
								}
								if (this.IsUseDoubleLine)
								{
									if (flag3)
									{
										this.DrawLine(new Pen(this.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
										this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num39);
										this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
									}
									else
									{
										this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
										this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
									}
								}
								if (this.OuterBorder)
								{
									if (flag3)
									{
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num39);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num39);
									}
									else
									{
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
									}
								}
								if (flag3)
								{
									flag3 = false;
								}
								this.Currenty = currenty + this.ConvFromDisplay((float)dataGridViewRow.Height, false);
								currenty = this.Currenty;
								if (k == torow)
								{
									break;
								}
								dataGridViewRow = this.myms.Rows[checked(k + 1)];
								float num57 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
								if (this.IsDrawTableFooterEveryPage && this.IsNewPage(num57 + num35))
								{
									if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(bm, "", false) == 0 & Operators.CompareString(br, "", false) == 0)
									{
										this.Currenty += num35;
									}
									else
									{
										bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
										this.IsNeedCheckNewPage = false;
										if (flag2)
										{
											this.Currentx = num16;
											this.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
											this.NewRow(num35);
										}
										else
										{
											this.Currentx = num16;
											this.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
											this.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
											this.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
											this.NewRow(num35);
										}
										this.IsNeedCheckNewPage = isNeedCheckNewPage;
										this.Currenty += num35;
									}
								}
								if (!(this.IsUseDoubleLine | this.OuterBorder))
								{
									this.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
									goto IL_207A;
								}
								if (this.IsUseDoubleLine)
								{
									if (this.IsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0))))
									{
										this.DrawLine(new Pen(this.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
										this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
										this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
										if (this.OuterBorder)
										{
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
										}
										this.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
										goto IL_207A;
									}
									goto IL_207A;
								}
								else
								{
									if (this.OuterBorder && this.IsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0))))
									{
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
										this.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
										goto IL_207A;
									}
									goto IL_207A;
								}
							IL_278C:
								return 0f;
							IL_2085:
								if (!this.myms.Rows[k].Visible)
								{
									goto IL_207A;
								}
								goto IL_162A;
							}
						}
						if (this.IsAutoAddEmptyRow && CanAddEmptyRow)
						{
							int num58;
							try
							{
								num58 = (int)Math.Round(Math.Floor((double)(unchecked(this.PaperPrintHeight - this.Currenty - num35) / this.ConvFromDisplay((float)this.myms.Rows[torow].Height, false))));
							}
							catch (Exception ex4)
							{
								num58 = 0;
							}
							if (Module1.G_CancelDocument)
							{
								return 0f;
							}
							DataGridViewRow dataGridViewRow = this.myms.Rows[torow];
							float num39 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
							num42 = 0f;
							int num59 = 1;
							int num60 = num58;
							for (int n = num59; n <= num60; n++)
							{
								this.Currentx = num15;
								currenty = this.Currenty;
								bool flag4 = true;
								num42 = 0f;
								int num61 = 0;
								int num62 = num5 - 1;
								for (int l = num61; l <= num62; l++)
								{
									DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
									unchecked
									{
										if (dataGridViewColumn.Visible)
										{
											float num40 = array5[l];
											num42 += num40;
											Color backcolor = Color.White;
											if (this.IsUseDoubleLine)
											{
												if (flag4)
												{
													this.Currentx += doubleLineSpace / 2f;
												}
												else
												{
													this.Currentx += doubleLineSpace;
												}
												if (flag3)
												{
													this.Currenty = currenty + doubleLineSpace / 2f;
												}
												else
												{
													this.Currenty = currenty + doubleLineSpace / 2f;
												}
												if (!PrintBackColor)
												{
													this.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
												}
												else
												{
													this.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
												}
											}
											else if (!PrintBackColor)
											{
												this.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
											}
											else
											{
												this.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
											}
											flag4 = false;
										}
									}
								}
								unchecked
								{
									if (this.IsUseDoubleLine)
									{
										this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
										this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
									}
									if (this.OuterBorder)
									{
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
										this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
									}
									this.Currenty = currenty + num39;
									currenty = this.Currenty;
								}
							}
						}
						int num63;
						unchecked
						{
							if (this.IsUseDoubleLine)
							{
								this.DrawLine(new Pen(this.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
								this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
								this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
							}
							if (this.OuterBorder)
							{
								this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
								this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
								this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
							}
							if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(bm, "", false) == 0 & Operators.CompareString(br, "", false) == 0)
							{
								this.NewRow(num35);
							}
							else
							{
								this.MyIsNewPage(num35, true);
								if (flag2)
								{
									this.Currentx = num16;
									this.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
									this.NewRow(num35);
								}
								else
								{
									this.Currentx = num16;
									this.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
									this.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
									this.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
									this.NewRow(num35);
								}
							}
							this.Currentx = 0f;
							if (Module1.G_CancelDocument)
							{
								return 0f;
							}
							num63 = 0;
						}
						int num64 = num5 - 1;
						for (k = num63; k <= num64; k++)
						{
							this.myms.Columns[thecol[k]].Width = array3[k];
						}
						try
						{
							if (array4[0] != 0)
							{
								this.myms.ColumnHeadersHeight = array4[0];
							}
						}
						catch (Exception ex5)
						{
						}
						int num65 = fromrow;
						int num66 = torow;
						for (k = num65; k <= num66; k++)
						{
							this.myms.Rows[k].Height = array4[k + 1];
						}
						try
						{
							mytree2.Dispose();
							mytree2 = null;
							mytree.Dispose();
							mytree = null;
							stringFormat.Dispose();
							stringFormat = null;
							stringFormat2.Dispose();
							stringFormat2 = null;
							array = null;
							array3 = null;
							array4 = null;
							array5 = null;
							array7 = null;
							return result;
						}
						catch (Exception ex6)
						{
							return result;
						}
						goto IL_278C;
					}
				}
				goto IL_B68;
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0009EB6C File Offset: 0x0009CD6C
		private static float GetHMergeWidth(DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, ref int colsmerged, bool dobz = true)
		{
			DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
			float num = cellwidth[curcol];
			checked
			{
				try
				{
					if (Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "水平合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
					{
						colsmerged = 1;
						return num;
					}
					if (curcol == cols - 1)
					{
						colsmerged = 1;
						return num;
					}
					int num2 = curcol + 1;
					int num3 = cols - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (ms.Columns[mycol[i]].Visible)
						{
							DataGridViewCell dataGridViewCell2 = ms.Rows[currow].Cells[mycol[i]];
							if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "水平合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
							{
								unchecked
								{
									num += cellwidth[i];
								}
								if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) == 0))
								{
									if (dobz)
									{
										ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
										goto IL_331;
									}
									goto IL_331;
								}
								else
								{
									if (dobz)
									{
										ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
									}
									i++;
								}
							}
						IL_36B:
							colsmerged = i - curcol;
							goto IL_385;
						}
					IL_331:;
					}
					goto IL_36B;
				}
				catch (Exception ex)
				{
					colsmerged = 1;
				}
			IL_385:
				return num;
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0009EF20 File Offset: 0x0009D120
		private float GetVMergeHeight(DataGridView ms, int curcol, int currow, int[] mycol, int torow, ref int rowsmerged, bool dobz = true)
		{
			DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
			float num = this.ConvFromDisplay((float)ms.Rows[currow].Height, false);
			checked
			{
				try
				{
					if (Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "垂直合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
					{
						rowsmerged = 1;
						return num;
					}
					if (currow == torow)
					{
						rowsmerged = 1;
						return num;
					}
					for (int i = currow + 1; i <= torow; i++)
					{
						if (ms.Rows[i].Visible)
						{
							DataGridViewCell dataGridViewCell2 = ms.Rows[i].Cells[mycol[curcol]];
							if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "垂直合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
							{
								float num2 = this.ConvFromDisplay((float)ms.Rows[i].Height, false);
								if (!this.MyIsNewPage(unchecked(num + num2), false))
								{
									unchecked
									{
										num += num2;
									}
									if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) == 0))
									{
										if (dobz)
										{
											ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
											goto IL_36A;
										}
										goto IL_36A;
									}
									else
									{
										if (dobz)
										{
											ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
										}
										i++;
									}
								}
							}
						IL_3A4:
							rowsmerged = i - currow;
							goto IL_3BE;
						}
					IL_36A:;
					}
					goto IL_3A4;
				}
				catch (Exception ex)
				{
					rowsmerged = 1;
				}
			IL_3BE:
				return num;
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0009F30C File Offset: 0x0009D50C
		private void GetHVMergeWidthAndHeight(DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, int torow, ref float mywidth, ref float myheight)
		{
			int num;
			myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, false);
			checked
			{
				if (num == 1)
				{
					int num2;
					mywidth = VB2008Print.GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, true);
				}
				else
				{
					int num2;
					mywidth = VB2008Print.GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, false);
					if (num2 == 1)
					{
						myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
					}
					else
					{
						mywidth = cellwidth[curcol];
						int i = 1;
						while (i <= num - 1)
						{
							if (ms.Rows[i].Visible)
							{
								if (Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "下边合并", false) != 0)
								{
									return;
								}
								i++;
							}
						}
						myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
						int num3 = curcol + 1;
						int num4 = curcol + num2 - 1;
						for (int j = num3; j <= num4; j++)
						{
							unchecked
							{
								if (ms.Columns[mycol[j]].Visible)
								{
									int num5;
									this.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, false);
									if (num5 < num | (Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "下边合并", false) != 0))
									{
										break;
									}
									mywidth += cellwidth[j];
									this.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, true);
									if (Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) == 0)
									{
										ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
										break;
									}
									ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0009F874 File Offset: 0x0009DA74
		private void DrawPageBackGroundImage()
		{
			if (this.mypagebackgroundimage != null)
			{
				try
				{
					this.DrawImage(this.mypagebackgroundimage, 0f, 0f, this.PaperPrintWidth, this.PaperPrintHeight, true, StringAlignment.Center, StringAlignment.Center);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		private bool CheckPrinter(bool showmsg)
		{
			bool result;
			if (PrinterSettings.InstalledPrinters != null && PrinterSettings.InstalledPrinters.Count > 0)
			{
				this.hasprinterinstalled = true;
				result = true;
			}
			else
			{
				if (showmsg)
				{
					string text = "检测到您的计算机上未安装任何打印机，因此无法进行打印预览和打印操作。";
					text += "\r\n\r\n";
					text += "注意：您的计算机上必须安装有打印机驱动程序（不一定要连接真实的打印机），才能进行打印预览及打印操作。";
					Interaction.MsgBox(text, MsgBoxStyle.Exclamation, "提示信息");
				}
				this.hasprinterinstalled = false;
				result = false;
			}
			return result;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0009F938 File Offset: 0x0009DB38
		private void Pd_BeginPrint(object sender, PrintEventArgs e)
		{
			if (!this.w_end)
			{
				if (!this.CheckPrinter(false))
				{
					e.Cancel = true;
				}
				else
				{
					this.hasshowpapersizeerror = false;
					this.hasshowpapersizeerror2 = false;
					bool flag = false;
					if (this.GetPages() > 0)
					{
						VB2008Print.BeginPrintEventHandler beginPrintEvent = this.BeginPrintEvent;
						if (beginPrintEvent != null)
						{
							beginPrintEvent(this.isprinttoprinter, ref flag);
						}
						if (flag)
						{
							e.Cancel = true;
						}
					}
				}
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0009F99C File Offset: 0x0009DB9C
		private void Pd_EndPrint(object sender, PrintEventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(this.MyEndThread));
			thread.Start();
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0009F9C4 File Offset: 0x0009DBC4
		private void Pd_PrintPage(object sender, PrintPageEventArgs e)
		{
			if (this.isstarting)
			{
				e.HasMorePages = false;
			}
			else if (this.w_end)
			{
				e.HasMorePages = false;
			}
			else
			{
				try
				{
					IntPtr hdc = e.Graphics.GetHdc();
					this.unprintablex = (float)VB2008Print.GetDeviceCaps((int)hdc, 112);
					this.unprintabley = (float)VB2008Print.GetDeviceCaps((int)hdc, 113);
					e.Graphics.ReleaseHdc(hdc);
					this.unprintablex = this.unprintablex / e.Graphics.DpiX * 100f;
					this.unprintabley = this.unprintabley / e.Graphics.DpiY * 100f;
				}
				catch (Exception ex)
				{
					this.unprintablex = this.Pd.DefaultPageSettings.HardMarginX;
					this.unprintabley = this.Pd.DefaultPageSettings.HardMarginY;
				}
				try
				{
					if (this.myg != null)
					{
						this.myg.Dispose();
						this.myg = null;
					}
				}
				catch (Exception ex2)
				{
				}
				this.myg = e.Graphics;
				this.myg.TextRenderingHint = TextRenderingHint.AntiAlias;
				if (this.isprinttoprinter)
				{
					this.myg.PageScale = this.PageScale;
				}
				checked
				{
					if (this.mypages == null)
					{
						e.HasMorePages = false;
						this.RestoreEndCS();
					}
					else if (this.GetPages() <= 0 | this.currentpage > this.GetPages())
					{
						e.HasMorePages = false;
						this.RestoreEndCS();
					}
					else if (this.isprinttoprinter && Module1.G_CancelPrint)
					{
						e.Cancel = true;
						e.HasMorePages = false;
						this.RestoreEndCS();
					}
					else
					{
						if (this.Pd.PrinterSettings.PrintRange == PrintRange.SomePages)
						{
							if (this.currentpage >= this.Pd.PrinterSettings.FromPage & this.currentpage <= this.Pd.PrinterSettings.ToPage)
							{
								this.MyParasePage(this.currentpage);
								if (this.currentpage == this.Pd.PrinterSettings.ToPage)
								{
									e.HasMorePages = false;
									this.RestoreEndCS();
									this.Pd.PrinterSettings.PrintRange = PrintRange.AllPages;
								}
								else
								{
									e.HasMorePages = true;
									this.currentpage++;
								}
								this.SetStatusNew(string.Concat(new string[]
								{
									"打印处理中，正在打印第【",
									Conversions.ToString(this.currentpage - this.Pd.PrinterSettings.FromPage + 1),
									"】页，共【",
									Conversions.ToString(this.Pd.PrinterSettings.ToPage - this.Pd.PrinterSettings.FromPage + 1),
									"】页需要打印"
								}));
								return;
							}
						}
						else if (this.Pd.PrinterSettings.PrintRange == PrintRange.Selection)
						{
							if (this.currentpage >= this.w_duplexfrom & this.currentpage <= this.w_duplexto)
							{
								if (this.w_myprintrange == VB2008Print.MyPrintPageRange.PageRange_JS)
								{
									if (this.currentpage % 2 == 1)
									{
										this.MyParasePage(this.currentpage);
										if (this.currentpage + 1 >= this.w_duplexto)
										{
											e.HasMorePages = false;
											this.RestoreEndCS();
											this.Pd.PrinterSettings.PrintRange = PrintRange.AllPages;
										}
										else
										{
											e.HasMorePages = true;
											this.currentpage += 2;
										}
										this.SetStatusNew(string.Concat(new string[]
										{
											"打印处理中，正在打印第【",
											Conversions.ToString(this.currentpage - this.w_duplexfrom + 1),
											"】页，共【",
											Conversions.ToString(this.w_duplexto - this.w_duplexfrom + 1),
											"】页需要打印（本次只打印其中的奇数页)"
										}));
										return;
									}
								}
								else if (this.currentpage % 2 == 0)
								{
									unchecked
									{
										this.unprintablex += this.w_CE;
										this.MyParasePage(this.currentpage);
									}
									if (this.currentpage + 1 >= this.w_duplexto)
									{
										e.HasMorePages = false;
										this.RestoreEndCS();
										this.Pd.PrinterSettings.PrintRange = PrintRange.AllPages;
									}
									else
									{
										e.HasMorePages = true;
										this.currentpage += 2;
									}
									this.SetStatusNew(string.Concat(new string[]
									{
										"打印处理中，正在打印第【",
										Conversions.ToString(this.currentpage - this.w_duplexfrom + 1),
										"】页，共【",
										Conversions.ToString(this.w_duplexto - this.w_duplexfrom + 1),
										"】页需要打印（本次只打印其中的偶数页)"
									}));
									return;
								}
							}
						}
						else
						{
							this.MyParasePage(this.currentpage);
							this.SetStatusNew(string.Concat(new string[]
							{
								"打印处理中，正在打印第【",
								Conversions.ToString(this.currentpage),
								"】页，共【",
								Conversions.ToString(this.GetPages()),
								"】页需要打印"
							}));
						}
						if (this.currentpage == this.GetPages())
						{
							e.HasMorePages = false;
							this.RestoreEndCS();
						}
						else
						{
							e.HasMorePages = true;
						}
						this.currentpage++;
					}
				}
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0009FF1C File Offset: 0x0009E11C
		private void Pd_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			checked
			{
				if (!this.w_end && !(this.pages <= 0 & this.currentpage <= 0) && !this.isstarting)
				{
					this.GetPageAndPaperSettings(this.currentpage);
					PaperSize paperSize = this.mypagesetting.PaperSize;
					this.SavePaperHeightAndWidth(paperSize);
					e.PageSettings.Landscape = this.mypagesetting.Landscape;
					if (this.PaperSize.Kind != PaperKind.Custom)
					{
						e.PageSettings.PaperSize = this.mypagesetting.PaperSize;
					}
					else
					{
						string paperName = this.PaperSize.PaperName;
						int height = this.PaperSize.Height;
						int width = this.PaperSize.Width;
						try
						{
							if (Operators.CompareString(this.PaperSize.PaperName, "", false) == 0)
							{
								this.PaperSize.PaperName = "用户自定义(空名称)";
							}
						}
						catch (Exception ex)
						{
						}
						PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
						if (printForm == null)
						{
							definepaper.SetPrintForm(this.GetCurrentPrinterName(), paperName, (float)((int)Math.Round(unchecked((double)width * 2.54) / 10.0)), (float)((int)Math.Round(unchecked((double)height * 2.54) / 10.0)));
						}
						else if (printForm.Width != this.PaperSize.Width | printForm.Height != this.PaperSize.Height)
						{
							definepaper.SetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName, (float)((int)Math.Round(unchecked((double)width * 2.54) / 10.0)), (float)((int)Math.Round(unchecked((double)height * 2.54) / 10.0)));
						}
						printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
						if (printForm == null & this.isprinttoprinter)
						{
							try
							{
								definepaper.SetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName, (float)((int)Math.Round(unchecked((double)height * 2.54) / 10.0)), (float)((int)Math.Round(unchecked((double)width * 2.54) / 10.0)));
								if (PrinterSet.FormSameSize(this.GetCurrentPrinterName(), this.PaperSize.PaperName, new decimal((int)Math.Round(unchecked((double)height * 2.54) / 10.0)), new decimal((int)Math.Round(unchecked((double)width * 2.54) / 10.0))))
								{
									printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
									if (printForm != null)
									{
										e.PageSettings.Landscape = !this.mypagesetting.Landscape;
										if (!this.hasshowpapersizeerror2 & this.IsShowMessageIfPrinterNotSupportPaper)
										{
											this.hasshowpapersizeerror2 = true;
											if (this.IsShowErrorMSG)
											{
												Interaction.MsgBox(string.Concat(new string[]
												{
													"当前使用的打印机【",
													this.GetCurrentPrinterName(),
													"】不支持 纸张〖",
													this.PaperSize.PaperName,
													" 宽：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Width * 2.54) / 10.0)),
													"毫米，高：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Height * 2.54) / 10.0)),
													"毫米 〗\r\n为解决该问题，控件自动将纸张的宽度与高度调换，并调整打印方向，请注意进纸方向。\r\n注意：若不想出现此提示窗口，请将控件的IsShowMessageIfPrinterNotSupportPaper属性设置为false"
												}), MsgBoxStyle.OkOnly, "提示信息");
											}
										}
									}
								}
							}
							catch (Exception ex2)
							{
							}
						}
						if (printForm == null)
						{
							if (this.isprinttoprinter)
							{
								if (definepaper.GetPrintForm(this.GetCurrentPrinterName(), "A3") == null)
								{
									if (!this.hasshowpapersizeerror & this.IsShowMessageIfPrinterNotSupportPaper)
									{
										this.hasshowpapersizeerror = true;
										if (this.IsShowErrorMSG)
										{
											Interaction.MsgBox(string.Concat(new string[]
											{
												"当前使用的打印机【",
												this.GetCurrentPrinterName(),
												"】不支持 纸张 〖",
												this.PaperSize.PaperName,
												" 宽：",
												Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Width * 2.54) / 10.0)),
												"毫米，高：",
												Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Height * 2.54) / 10.0)),
												"毫米〗，将使用A4纸进行输出，在此情况下，只要实际纸张大小不小于当前预览所用纸张（且当前预览纸张不大于A4纸），依然可以按当前预览结果的版式进行打印，但如果是使用连续进纸的链式纸张，则可能会有换页进纸不正常现象。\r\n注意：若不想出现此提示窗口，请将控件的IsShowMessageIfPrinterNotSupportPaper属性设置为false"
											}), MsgBoxStyle.OkOnly, "提示信息");
										}
									}
									e.PageSettings.PaperSize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), PaperKind.A4);
								}
								else
								{
									PaperSize printForm2 = definepaper.GetPrintForm(this.GetCurrentPrinterName(), PaperKind.A4);
									if (printForm2.Width >= this.PaperSize.Width & printForm2.Height >= this.PaperSize.Height)
									{
										if (!this.hasshowpapersizeerror & this.IsShowMessageIfPrinterNotSupportPaper)
										{
											this.hasshowpapersizeerror = true;
											if (this.IsShowErrorMSG)
											{
												Interaction.MsgBox(string.Concat(new string[]
												{
													"当前使用的打印机【",
													this.GetCurrentPrinterName(),
													"】不支持 纸张 〖",
													this.PaperSize.PaperName,
													" 宽：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Width * 2.54) / 10.0)),
													"毫米，高：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Height * 2.54) / 10.0)),
													"毫米〗，将使用A4纸进行输出，在此情况下，只要实际纸张大小不小于当前预览所用纸张（且当前预览纸张不大于A4纸），依然可以按当前预览结果的版式进行打印，但如果是使用连续进纸的链式纸张，则可能会有换页进纸不正常现象。"
												}), MsgBoxStyle.OkOnly, "提示信息");
											}
										}
										e.PageSettings.PaperSize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), PaperKind.A4);
									}
									else
									{
										if (!this.hasshowpapersizeerror & this.IsShowMessageIfPrinterNotSupportPaper)
										{
											this.hasshowpapersizeerror = true;
											if (this.IsShowErrorMSG)
											{
												Interaction.MsgBox(string.Concat(new string[]
												{
													"当前使用的打印机【",
													this.GetCurrentPrinterName(),
													"】不支持 纸张 〖",
													this.PaperSize.PaperName,
													" 宽：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Width * 2.54) / 10.0)),
													"毫米，高：",
													Conversions.ToString((int)Math.Round(unchecked((double)this.PaperSize.Height * 2.54) / 10.0)),
													"毫米〗，将使用A3纸进行输出，在此情况下，只要实际纸张大小不小于当前预览所用纸张（且当前预览纸张不大于A3纸），依然可以按当前预览结果的版式进行打印，但如果是使用连续进纸的链式纸张，则可能会有换页进纸不正常现象。"
												}), MsgBoxStyle.OkOnly, "提示信息");
											}
										}
										e.PageSettings.PaperSize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), PaperKind.A3);
									}
								}
							}
							else
							{
								e.PageSettings.PaperSize = this.mypagesetting.PaperSize;
							}
						}
						else
						{
							e.PageSettings.PaperSize = printForm;
						}
					}
					e.PageSettings.Margins.Left = this.mypagesetting.Margins.Left;
					e.PageSettings.Margins.Bottom = this.mypagesetting.Margins.Bottom;
					e.PageSettings.Margins.Right = this.mypagesetting.Margins.Right;
					e.PageSettings.Margins.Top = this.mypagesetting.Margins.Top;
					this.w_CE = 0f;
					if (this.Pd.PrinterSettings.PrintRange == PrintRange.Selection && (this.currentpage % 2 == 0 & this.isprinttoprinter))
					{
						this.w_CE = (float)(this.mypagesetting.Margins.Left - this.mypagesetting.Margins.Right);
					}
				}
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000A07AC File Offset: 0x0009E9AC
		private void mysave_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存报表文件，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.SaveFileDialog1.FileName;
				if (this.SaveReport(fileName, true, "", false))
				{
					Interaction.MsgBox("报表文件保存成功", MsgBoxStyle.OkOnly, "提示信息");
				}
				else
				{
					Interaction.MsgBox("报表文件保存失败", MsgBoxStyle.OkOnly, "提示信息");
				}
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000A0824 File Offset: 0x0009EA24
		private void ToolStripMenuItem_15_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存报表文件，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.SaveFileDialog1.FileName;
				savemmdialog savemmdialog = new savemmdialog();
				if (savemmdialog.ShowDialog() == DialogResult.OK)
				{
					if (this.SaveReport(fileName, true, savemmdialog.TextBox1.Text, false))
					{
						Interaction.MsgBox("报表文件保存成功", MsgBoxStyle.OkOnly, "提示信息");
					}
					else
					{
						Interaction.MsgBox("报表文件保存失败", MsgBoxStyle.OkOnly, "提示信息");
					}
				}
				savemmdialog.Dispose();
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x000A08B8 File Offset: 0x0009EAB8
		private void myopen_Click(object sender, EventArgs e)
		{
			if (!this.mycanopenreport)
			{
				Interaction.MsgBox("抱歉，当前设置不允许打开报表文件", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				this.isprinttoprinter = false;
				if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string fileName = this.OpenFileDialog1.FileName;
					if (!this.OpenReport(fileName))
					{
						Interaction.MsgBox("报表文件打开失败，请检查报表文件是否为本控件生成，是否被损坏", MsgBoxStyle.OkOnly, "提示信息");
					}
					else
					{
						this.IsOpenReporting = true;
					}
				}
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000A0924 File Offset: 0x0009EB24
		private void pagesetup_Click(object sender, EventArgs e)
		{
			if (this.IsOpenReporting)
			{
				Interaction.MsgBox("当前显示的是打开的报表文件，或者是用NewDoc创建的打印作业，不能进行页面设置\r\n注意：对于打开的报表文件或调用NewDoc创建的打印作业，其页面设置无法更改。", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
				this.Pd.DefaultPageSettings = this.mypagesetting;
				this.PageSetupDialog1.PageSettings = this.mypagesetting;
				this.PageSetupDialog1.PrinterSettings.DefaultPageSettings.PaperSize = this.mypagesetting.PaperSize;
				try
				{
				}
				catch (Exception ex)
				{
				}
				if (!this.IsUseAPIprintDialog)
				{
					switch (this.ShowDefaultPageSetupDialog())
					{
						case -1:
							switch (this.ShowAPIPageSetupDialog())
							{
								case 1:
									this.isstarting = true;
									this.isfrompageset = true;
									this.StartPrePreview();
									break;
							}
							break;
						case 1:
							this.isstarting = true;
							this.isfrompageset = true;
							this.StartPrePreview();
							break;
					}
				}
				else
				{
					switch (this.ShowAPIPageSetupDialog())
					{
						case -1:
							switch (this.ShowDefaultPageSetupDialog())
							{
								case 1:
									this.isstarting = true;
									this.isfrompageset = true;
									this.StartPrePreview();
									break;
							}
							break;
						case 1:
							this.isstarting = true;
							this.isfrompageset = true;
							this.StartPrePreview();
							break;
					}
				}
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000A0A98 File Offset: 0x0009EC98
		private int ShowDefaultPageSetupDialog()
		{
			Stopwatch stopwatch = new Stopwatch();
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
			printDocument.DefaultPageSettings = this.mypagesetting;
			printDocument.PrinterSettings.DefaultPageSettings.PaperSize = this.mypagesetting.PaperSize;
			this.PageSetupDialog1.Document = printDocument;
			this.PageSetupDialog1.PrinterSettings.DefaultPageSettings.PaperSize = this.mypagesetting.PaperSize;
			stopwatch.Start();
			int num;
			if (this.PageSetupDialog1.ShowDialog() == DialogResult.OK)
			{
				this.Pd.DefaultPageSettings = this.PageSetupDialog1.PageSettings;
				this.Pd.PrinterSettings.PrinterName = this.PageSetupDialog1.PrinterSettings.PrinterName;
				this.mypagesetting = this.Pd.DefaultPageSettings;
				num = 1;
			}
			else
			{
				num = 0;
			}
			stopwatch.Stop();
			if (num == 0 && stopwatch.ElapsedMilliseconds <= 100L)
			{
				num = -1;
			}
			printDocument.Dispose();
			return num;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000A0BA0 File Offset: 0x0009EDA0
		private int ShowAPIPageSetupDialog()
		{
			bool flag = false;
			this.PageSetupDialog1.PageSettings.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
			PageSetupDialog pageSetupDialog = this.PageSetupDialog1;
			PageSettings pageSettings = pageSetupDialog.PageSettings;
			bool flag2 = pageset.ShowPageSet(ref pageSettings, this.Handle, ref flag);
			pageSetupDialog.PageSettings = pageSettings;
			int result;
			if (flag2)
			{
				this.Pd.DefaultPageSettings = this.PageSetupDialog1.PageSettings;
				this.mypagesetting = this.Pd.DefaultPageSettings;
				this.Pd.PrinterSettings.PrinterName = this.PageSetupDialog1.PageSettings.PrinterSettings.PrinterName;
				this.PageSetupDialog1.PrinterSettings.PrinterName = this.PageSetupDialog1.PageSettings.PrinterSettings.PrinterName;
				result = 1;
			}
			else if (flag)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000A0C74 File Offset: 0x0009EE74
		private void printd_DropDownOpening(object sender, EventArgs e)
		{
			if (this.isstarting)
			{
				this.dy1.Enabled = false;
				this.dy2.Enabled = false;
				this.dy3.Enabled = false;
				this.dy4.Enabled = false;
				this.dy5.Enabled = false;
				this.cgprint.Enabled = false;
			}
			else
			{
				this.dy1.Enabled = true;
				this.dy2.Enabled = true;
				this.dy3.Enabled = true;
				this.dy4.Enabled = true;
				this.dy5.Enabled = true;
				if (this.EnablePrintDraft)
				{
					this.cgprint.Enabled = true;
				}
				else
				{
					this.cgprint.Enabled = false;
				}
				if (this.GetPages() <= 0)
				{
					this.dy1.Enabled = false;
					this.dy2.Enabled = false;
					this.dy3.Enabled = false;
					this.dy4.Enabled = false;
					this.dy5.Enabled = false;
					this.cgprint.Enabled = false;
				}
				if (this.mytype1.Checked | !this.ToolStripMenuItem_7.Checked)
				{
					this.dy3.Enabled = false;
				}
				this.dy3.ToolTipText = "用打印机〖" + this.GetCurrentPrinterName() + "〗打印当前页";
				this.dy2.ToolTipText = "用打印机〖" + this.GetCurrentPrinterName() + "〗打印当前文档(全部页)";
				this.dy5.ToolTipText = "用打印机〖" + this.GetCurrentPrinterName() + "〗打印当前文档全部页（手动双面打印）";
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00007229 File Offset: 0x00005429
		private void printd_ButtonClick(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能打印，当前打印的作业内容是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				this.Print(true);
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000A0E10 File Offset: 0x0009F010
		private void dy1_ButtonClick(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能打印，当前打印的作业内容是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else
			{
				bool isUseAPIprintDialog = this.IsUseAPIprintDialog;
				if (this.IsUseAPIprintDialog)
				{
					this.IsUseAPIprintDialog = false;
				}
				else
				{
					this.IsUseAPIprintDialog = true;
				}
				try
				{
					this.Print(true);
				}
				catch (Exception ex)
				{
				}
				this.IsUseAPIprintDialog = isUseAPIprintDialog;
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000A0E88 File Offset: 0x0009F088
		private void ToolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.SetPages(1);
			this.ToolStripMenuItem_7.Checked = true;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000A0EFC File Offset: 0x0009F0FC
		private void ToolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			this.SetPages(2);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = true;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000A0F70 File Offset: 0x0009F170
		private void ToolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			this.SetPages(3);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = true;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000A0FE4 File Offset: 0x0009F1E4
		private void ToolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			this.SetPages(4);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = true;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000A1058 File Offset: 0x0009F258
		private void ToolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			this.SetPages(5);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = true;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000A10CC File Offset: 0x0009F2CC
		private void ToolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			this.SetPages(6);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = true;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000A1140 File Offset: 0x0009F340
		private void ToolStripMenuItem_13_Click(object sender, EventArgs e)
		{
			this.SetPages(8);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = true;
			this.ToolStripMenuItem_14.Checked = false;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000A11B4 File Offset: 0x0009F3B4
		private void ToolStripMenuItem_14_Click(object sender, EventArgs e)
		{
			this.SetPages(10);
			this.ToolStripMenuItem_7.Checked = false;
			this.ToolStripMenuItem_8.Checked = false;
			this.ToolStripMenuItem_9.Checked = false;
			this.ToolStripMenuItem_10.Checked = false;
			this.ToolStripMenuItem_11.Checked = false;
			this.ToolStripMenuItem_12.Checked = false;
			this.ToolStripMenuItem_13.Checked = false;
			this.ToolStripMenuItem_14.Checked = true;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000A122C File Offset: 0x0009F42C
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 1.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = true;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000A12F8 File Offset: 0x0009F4F8
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 1.25;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = true;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = true;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x000A13D0 File Offset: 0x0009F5D0
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 1.5;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = true;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = true;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x000A14A8 File Offset: 0x0009F6A8
		private void ToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 0.1;
			this.ToolStripMenuItem11.Checked = true;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000A1580 File Offset: 0x0009F780
		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 0.25;
			this.ToolStripMenuItem.Checked = true;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x000A1658 File Offset: 0x0009F858
		private void ToolStripMenuItem0_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 0.5;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = true;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x000A1730 File Offset: 0x0009F930
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 0.75;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = true;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000A1808 File Offset: 0x0009FA08
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 2.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = true;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x000A18E0 File Offset: 0x0009FAE0
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 2.5;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = true;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x000A19B8 File Offset: 0x0009FBB8
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 3.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = true;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000A1A90 File Offset: 0x0009FC90
		private void ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 4.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = true;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000A1B68 File Offset: 0x0009FD68
		private void ToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 5.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = true;
			this.ToolStripMenuItem10.Checked = false;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = false;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000A1C40 File Offset: 0x0009FE40
		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			this.PrintPreviewControl1.Zoom = 1.0;
			this.ToolStripMenuItem.Checked = false;
			this.ToolStripMenuItem0.Checked = false;
			this.ToolStripMenuItem1.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem2.Checked = false;
			this.ToolStripMenuItem3.Checked = false;
			this.ToolStripMenuItem4.Checked = false;
			this.ToolStripMenuItem5.Checked = false;
			this.ToolStripMenuItem6.Checked = false;
			this.ToolStripMenuItem7.Checked = false;
			this.ToolStripMenuItem8.Checked = false;
			this.ToolStripMenuItem9.Checked = false;
			this.ToolStripMenuItem10.Checked = true;
			this.ToolStripMenuItem11.Checked = false;
			this.PrintPreviewControl1.AutoZoom = true;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0000724E File Offset: 0x0000544E
		private void mytype1_Click(object sender, EventArgs e)
		{
			this.mytype1.Checked = true;
			this.mytype2.Checked = false;
			this.cpage.Enabled = false;
			this.SetPages();
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0000727A File Offset: 0x0000547A
		private void mytype2_Click(object sender, EventArgs e)
		{
			this.mytype1.Checked = false;
			this.mytype2.Checked = true;
			this.SetPages();
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x000A1D18 File Offset: 0x0009FF18
		private void cpage_SelectedIndexChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.GetPages() > 0)
				{
					string text = Conversions.ToString(this.cpage.SelectedItem);
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = "第1页";
						this.cpage.SelectedIndex = 0;
					}
					text = Strings.Mid(text, 2, Strings.Len(text) - 1);
					text = Strings.Left(text, Strings.Len(text) - 1);
					this.currentpage = (int)Math.Round(Conversion.Val(text));
					this.PrintPreviewControl1.StartPage = (int)Math.Round(Conversion.Val(text)) - 1;
					if (this.GetPages() <= 1)
					{
						this.fpage.Enabled = false;
						this.ppage.Enabled = false;
						this.npage.Enabled = false;
						this.lpage.Enabled = false;
					}
					else
					{
						this.fpage.Enabled = true;
						this.ppage.Enabled = true;
						this.npage.Enabled = true;
						this.lpage.Enabled = true;
						if (this.currentpage == 1)
						{
							this.fpage.Enabled = false;
							this.ppage.Enabled = false;
						}
						if (this.currentpage == this.GetPages())
						{
							this.lpage.Enabled = false;
							this.npage.Enabled = false;
						}
					}
				}
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000A1E60 File Offset: 0x000A0060
		private void cpage_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (Strings.Asc(e.KeyChar) == 16)
				{
					if (Control.ModifierKeys == Keys.Control)
					{
						if (this.GetPages() > 0)
						{
							if (this.EnabledPrint)
							{
								this.Print(true);
							}
						}
					}
					else if (Control.ModifierKeys == (Keys.Shift | Keys.Control))
					{
						if (this.GetPages() > 0)
						{
							if (this.EnabledPrint)
							{
								this.Print(false);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000A1EEC File Offset: 0x000A00EC
		private void PrintPreviewControl1_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (Strings.Asc(e.KeyChar) == 16)
				{
					if (Control.ModifierKeys == Keys.Control)
					{
						if (this.GetPages() > 0)
						{
							if (this.EnabledPrint)
							{
								this.Print(true);
							}
						}
					}
					else if (Control.ModifierKeys == (Keys.Shift | Keys.Control))
					{
						if (this.GetPages() > 0)
						{
							if (this.EnabledPrint)
							{
								this.Print(false);
							}
						}
					}
				}
				else if (Control.ModifierKeys == (Keys.Shift | Keys.Control) && Strings.Asc(e.KeyChar) == 1)
				{
					MyProject.Forms.AboutBox1.ShowDialog();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		private void PrintPreviewControl1_KeyUp(object sender, KeyEventArgs e)
		{
			checked
			{
				if (e.Modifiers == Keys.ControlKey | e.Modifiers == Keys.Control)
				{
					if (e.KeyCode == Keys.Home)
					{
						try
						{
							this.cpage.Text = "第1页";
							return;
						}
						catch (Exception ex)
						{
							return;
						}
					}
					if (e.KeyCode == Keys.End)
					{
						try
						{
							this.cpage.Text = "第" + Conversions.ToString(this.GetPages()) + "页";
							return;
						}
						catch (Exception ex2)
						{
							return;
						}
					}
					int currentPage;
					if (e.KeyCode == Keys.Up)
					{
						currentPage = this.GetCurrentPage();
						if (currentPage <= 1)
						{
							return;
						}
						try
						{
							this.cpage.Text = "第" + Conversions.ToString(currentPage - 1) + "页";
							return;
						}
						catch (Exception ex3)
						{
							return;
						}
					}
					if (e.KeyCode != Keys.Down)
					{
						return;
					}
					currentPage = this.GetCurrentPage();
					if (currentPage >= this.GetPages())
					{
						return;
					}
					try
					{
						this.cpage.Text = "第" + Conversions.ToString(currentPage + 1) + "页";
						return;
					}
					catch (Exception ex4)
					{
						return;
					}
				}
				if (e.KeyCode == Keys.Next | e.KeyCode == Keys.Down)
				{
					int currentPage = this.GetCurrentPage();
					if (currentPage >= this.GetPages())
					{
						return;
					}
					try
					{
						this.cpage.Text = "第" + Conversions.ToString(currentPage + 1) + "页";
						return;
					}
					catch (Exception ex5)
					{
						return;
					}
				}
				if (e.KeyCode == Keys.Prior | e.KeyCode == Keys.Up)
				{
					int currentPage = this.GetCurrentPage();
					if (currentPage > 1)
					{
						try
						{
							this.cpage.Text = "第" + Conversions.ToString(currentPage - 1) + "页";
						}
						catch (Exception ex6)
						{
						}
					}
				}
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000A21E8 File Offset: 0x000A03E8
		private void PrintPreviewControl1_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintPreviewControl1.Select();
				this.PrintPreviewControl1.Focus();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0000729A File Offset: 0x0000549A
		private void PrintPreviewControl1_DoubleClick(object sender, EventArgs e)
		{
			this.Zoom = 1.0;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000A222C File Offset: 0x000A042C
		private void PrintPreviewControl1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.isMouseDown = true;
				this.startPosition = new Point(e.X, e.Y);
				object value = this.m_Position.GetValue(this.PrintPreviewControl1);
				Point point=new Point();
				this.curPos = ((value != null) ? ((Point)value) : point);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000A22A0 File Offset: 0x000A04A0
		private void PrintPreviewControl1_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.isMouseDown = false;
				this.endPosition = new Point(e.X, e.Y);
				MethodBase setPositionMethod = this.m_SetPositionMethod;
				object printPreviewControl = this.PrintPreviewControl1;
				object[] array = new object[1];
				object[] array2 = array;
				int num = 0;
				Point point = checked(new Point(this.curPos.X + (this.startPosition.X - this.endPosition.X), this.curPos.Y + (this.startPosition.Y - this.endPosition.Y)));
				array2[num] = point;
				setPositionMethod.Invoke(printPreviewControl, array);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000A235C File Offset: 0x000A055C
		private void PrintPreviewControl1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.isMouseDown)
				{
					this.endPosition = new Point(e.X, e.Y);
					MethodBase setPositionMethod = this.m_SetPositionMethod;
					object printPreviewControl = this.PrintPreviewControl1;
					object[] array = new object[1];
					object[] array2 = array;
					int num = 0;
					Point point = checked(new Point(this.curPos.X + (this.startPosition.X - this.endPosition.X), this.curPos.Y + (this.startPosition.Y - this.endPosition.Y)));
					array2[num] = point;
					setPositionMethod.Invoke(printPreviewControl, array);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000A241C File Offset: 0x000A061C
		private void PrintPreviewControl1_MouseWheel(object sender, MouseEventArgs e)
		{
			try
			{
				if (SystemInformation.MouseWheelPresent)
				{
					float num = (float)((double)Math.Abs(e.Delta) / (double)SystemInformation.MouseWheelScrollDelta);
					num *= (float)SystemInformation.MouseWheelScrollLines;
					num *= 12f;
					num = (float)((double)num * this.PrintPreviewControl1.Zoom);
					int num2;
					checked
					{
						if (e.Delta < 0)
						{
							num2 = (int)Math.Round((double)num);
						}
						else
						{
							num2 = 0 - (int)Math.Round((double)num);
						}
					}
					if (Control.ModifierKeys == Keys.Control)
					{
						this.Zoom += 0.0 - (double)num2 / 100.0;
					}
					else
					{
						object value = this.m_Position.GetValue(this.PrintPreviewControl1);
						Point point2;
						Point point = (value != null) ? ((Point)value) : point2;
						MethodBase setPositionMethod = this.m_SetPositionMethod;
						object printPreviewControl = this.PrintPreviewControl1;
						object[] array = new object[1];
						object[] array2 = array;
						int num3 = 0;
						Point point3 = checked(new Point(point.X + 0, point.Y + num2));
						array2[num3] = point3;
						setPositionMethod.Invoke(printPreviewControl, array);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000A2540 File Offset: 0x000A0740
		private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			if (this.isstarting)
			{
				this.ToolStripMenuItem_2.Enabled = false;
				this.ToolStripMenuItem_1.Enabled = false;
				this.ToolStripMenuItem_5.Enabled = false;
				this.ToolStripMenuItem_0.Enabled = false;
				this.ToolStripMenuItem_3.Enabled = false;
				this.ToolStripMenuItem_4.Enabled = false;
				this.ToolStripMenuItem_6.Enabled = false;
			}
			else
			{
				this.ToolStripMenuItem_2.Visible = true;
				this.ToolStripMenuItem_1.Visible = true;
				this.ToolStripMenuItem_5.Visible = true;
				this.ToolStripMenuItem_0.Visible = true;
				this.ToolStripMenuItem_3.Visible = true;
				this.ToolStripMenuItem_4.Visible = true;
				this.ToolStripMenuItem_2.Enabled = true;
				this.ToolStripMenuItem_1.Enabled = true;
				this.ToolStripMenuItem_5.Enabled = true;
				this.ToolStripMenuItem_0.Enabled = true;
				this.ToolStripMenuItem_3.Enabled = true;
				this.ToolStripMenuItem_4.Enabled = true;
				this.ToolStripMenuItem_6.Enabled = true;
				if (!this.EnabledPageSetting | this.IsOpenReporting)
				{
					this.ToolStripMenuItem_2.Enabled = false;
					this.ToolStripMenuItem_2.Visible = false;
				}
				if (this.GetPages() <= 0)
				{
					this.ToolStripMenuItem_1.Enabled = false;
					this.ToolStripMenuItem_5.Enabled = false;
					this.ToolStripMenuItem_0.Enabled = false;
					this.ToolStripMenuItem_3.Enabled = false;
					this.ToolStripMenuItem_1.Visible = false;
					this.ToolStripMenuItem_5.Visible = false;
					this.ToolStripMenuItem_0.Visible = false;
					this.ToolStripMenuItem_3.Visible = false;
				}
				if (!this.CanSaveReport)
				{
					this.ToolStripMenuItem_3.Enabled = false;
					this.ToolStripMenuItem_3.Visible = false;
				}
				if (!this.CanOpenReport)
				{
					this.ToolStripMenuItem_4.Enabled = false;
					this.ToolStripMenuItem_4.Visible = false;
				}
				if (this.mytype1.Checked | !this.ToolStripMenuItem_7.Checked)
				{
					this.ToolStripMenuItem_5.Enabled = false;
					this.ToolStripMenuItem_5.Visible = false;
				}
				if (!this.EnabledPrint)
				{
					this.ToolStripMenuItem_1.Enabled = false;
					this.ToolStripMenuItem_5.Enabled = false;
					this.ToolStripMenuItem_0.Enabled = false;
					this.ToolStripMenuItem_1.Visible = false;
					this.ToolStripMenuItem_5.Visible = false;
					this.ToolStripMenuItem_0.Visible = false;
				}
				this.ToolStripMenuItem_5.ToolTipText = "用打印机〖" + this.GetCurrentPrinterName() + "〗打印当前页";
				this.ToolStripMenuItem_0.ToolTipText = "用打印机〖" + this.GetCurrentPrinterName() + "〗打印当前文档(全部页)";
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000072AB File Offset: 0x000054AB
		private void dy2_Click(object sender, EventArgs e)
		{
			this.Print(false);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000A27E4 File Offset: 0x000A09E4
		private void dy3_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string text = Conversions.ToString(this.cpage.SelectedItem);
					text = Strings.Mid(text, 2, Strings.Len(text) - 1);
					text = Strings.Left(text, Strings.Len(text) - 1);
					this.currentpage = (int)Math.Round(Conversion.Val(text));
					this.Print(this.currentpage, this.currentpage, 1);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000072B4 File Offset: 0x000054B4
		private void ToolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.Print(true);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000072BD File Offset: 0x000054BD
		private void ToolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.pagesetup_Click(null, null);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000072C7 File Offset: 0x000054C7
		private void ToolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.mysave_Click(null, null);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000072D1 File Offset: 0x000054D1
		private void ToolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.myopen_Click(null, null);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000072DB File Offset: 0x000054DB
		private void ToolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			MyProject.Forms.AboutBox1.ShowDialog();
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000A2868 File Offset: 0x000A0A68
		private void zdybutton_Click(object sender, EventArgs e)
		{
			VB2008Print.ZDYButtonClickEventHandler zdybuttonClickEvent = this.ZDYButtonClickEvent;
			if (zdybuttonClickEvent != null)
			{
				zdybuttonClickEvent();
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000A2888 File Offset: 0x000A0A88
		private void zdybutton2_Click(object sender, EventArgs e)
		{
			VB2008Print.ZDYButton2ClickEventHandler zdybutton2ClickEvent = this.ZDYButton2ClickEvent;
			if (zdybutton2ClickEvent != null)
			{
				zdybutton2ClickEvent();
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000A28A8 File Offset: 0x000A0AA8
		private void BeforePreviewD_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				if (this.myg != null)
				{
					this.myg.Dispose();
					this.myg = null;
				}
			}
			catch (Exception ex)
			{
			}
			this.myg = e.Graphics;
			this.myg.TextRenderingHint = TextRenderingHint.AntiAlias;
			if (this.UseAntiAlias)
			{
				this.myg.SmoothingMode = SmoothingMode.AntiAlias;
			}
			if (!this.isfrompageset)
			{
				bool paperLandscape = this.PaperLandscape;
				PaperSize paperSize = this.PaperSize;
				Margins paperMargins = this.PaperMargins;
				this.isstarting = true;
				VB2008Print.QueryDefaultPageSettingsEventHandler queryDefaultPageSettingsEvent = this.QueryDefaultPageSettingsEvent;
				if (queryDefaultPageSettingsEvent != null)
				{
					queryDefaultPageSettingsEvent(ref paperSize, ref paperMargins, ref paperLandscape);
				}
				this.isstarting = false;
				if (paperSize == null)
				{
					paperSize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), "A4");
				}
				this.PaperSize = paperSize;
				this.PaperMargins = paperMargins;
				this.PaperLandscape = paperLandscape;
				this.isstarting = true;
			}
			this.myNewDoc();
			VB2008Print.PrintDocumentEventHandler printDocumentEvent = this.PrintDocumentEvent;
			if (printDocumentEvent != null)
			{
				printDocumentEvent();
			}
			this.myEndDoc();
			e.HasMorePages = false;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000072ED File Offset: 0x000054ED
		private void BeforePreviewD_BeginPrint(object sender, PrintEventArgs e)
		{
			if (!this.CheckPrinter(this.IsShowErrorMSG))
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000A29B8 File Offset: 0x000A0BB8
		public VB2008Print()
		{
			base.Disposed += this.VB2008Print_Disposed;
			this.tempcellmargin = new Margins(0, 0, 0, 0);
			this.hasshownewpageerror = false;
			this.hasprinterinstalled = true;
			this.IsOpenReporting = false;
			this.currentpage = 0;
			this.pages = 0;
			this.w_end = false;
			this.W_myrtfnum = 0;
			this.isfrompageset = false;
			this.isstarting = false;
			this.isprinttoprinter = false;
			this.hasshowpapersizeerror = false;
			this.hasshowpapersizeerror2 = false;
			this.myDocumentName = ".NET打印控件";
			this.unprintablex = 0f;
			this.unprintabley = 0f;
			this.w_CE = 0f;
			this.myisusedoubleline = false;
			this.myouterborder = false;
			this.myouterbordercolor = Color.Black;
			this.myouterborderwidth = 2f;
			this.thedoublelinespace = 4f;
			this.myisneedchecknewpage = true;
			this.myforecolor = Color.Black;
			this.myfont = new Font("宋体", 9f);
			this.mypagesetting = new PageSettings();
			this.myCellmargin = new Margins(0, 0, 0, 0);
			this.myenabledpagesetting = true;
			this.myenabledprint = true;
			this.mycanopenreport = true;
			this.mycansavereport = true;
			this.myisdrawmargin = false;
			this.myishowprintstatusdialog = true;
			this.mywatermarktext = "";
			this.mywatermarkfont = new Font("华文行楷", 80f, FontStyle.Bold);
			this.mywatermarkopacity = 128;
			this.mywatermarklandscape = true;
			this.mywatermarkcolor = Color.Red;
			this.myshapedepth = 8;
			this.myiszdybuttonvisible = false;
			this.myiszdybutton2visible = false;
			this.myIsDGVCellValignmentCenter = true;
			this.myisendpreview = false;
			this.myisimmediateprintnotpreview = false;
			this.myIsImmediatePrintNotPreviewShowPrintDialog = false;
			this.myisshowprogress = true;
			this.myisuseAPIprintDialog = true;
			this.myIsShowMessageIfPrinterNotSupportPaper = true;
			this.mypagebackgroundimage = null;
			this.myistoolbarvisible = true;
			this.myisshowcontextmenu = true;
			this.myisdrawpageheaderline = false;
			this.myisdrawpagefooterline = false;
			this.myisusedgvpadding = true;
			this.myisshowerrormsg = true;
			this.mypageunits = VB2008Print.PageExportUnit.Inch;
			this.myisautoaddemptyrow = false;
			this.myisdrawtablefootereverypage = false;
			this.myisshowpagecontinues = false;
			this.myisneedprintpageheaderandfooter = true;
			this.myPYx = 0f;
			this.myPYy = 0f;
			this.myisautoadjustprintermargin = true;
			this.myenablesaveaspdf = true;
			this.myenablesaveasimage = true;
			this.myenablecgprint = true;
			this._printcopys = 1;
			this.mypagescale = 1f;
			this.myZDXtext = "装订线";
			this.myZDXfont = new Font("宋体", 9f);
			this.myZDXtextcolor = Color.Black;
			this.myZDXlinecolor = Color.Black;
			this.myZDXlinestyle = DashStyle.Dash;
			this.myZDXposition = 0f;
			this.myZDXtype = VB2008Print.TheZDXTYPE.LEFT;
			this.myisdrawZDX = false;
			this.InitializeComponent();
			this.PIXELSPERINCHX = this.CreateGraphics().DpiX;
			this.PIXELSPERINCHY = this.CreateGraphics().DpiY;
			Type typeFromHandle = typeof(PrintPreviewControl);
			this.m_Position = typeFromHandle.GetField("_position", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
			this.m_SetPositionMethod = typeFromHandle.GetMethod("SetPositionNoInvalidate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000A2CD8 File Offset: 0x000A0ED8
		public bool SaveReport(string myfilename, bool isoverrite)
		{
			return this.SaveReport(myfilename, isoverrite, "", false);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000A2CF4 File Offset: 0x000A0EF4
		public bool SaveReport(string myfilename, bool isoverrite, string mm)
		{
			return this.SaveReport(myfilename, isoverrite, mm, false);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000A2D0C File Offset: 0x000A0F0C
		private bool SaveReport(string myfilename, bool isoverrite, string mm, bool isoldversion)
		{
			if (MyProject.Computer.FileSystem.FileExists(myfilename))
			{
				if (!isoverrite)
				{
					return false;
				}
				try
				{
					MyProject.Computer.FileSystem.DeleteFile(myfilename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
				}
				catch (Exception ex)
				{
					return false;
				}
			}
			checked
			{
				bool result;
				if (this.GetPages() <= 0)
				{
					result = false;
				}
				else
				{
					UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
					FileStream fileStream = new FileStream(myfilename, FileMode.CreateNew, FileAccess.Write);
					string text = Conversions.ToString(this.mypages.Length);
					int num = 1;
					int num2 = this.mypages.Length;
					byte[] bytes;
					for (int i = num; i <= num2; i++)
					{
						bytes = unicodeEncoding.GetBytes(this.mypages[i - 1].ToString());
						text = text + "\0" + Conversions.ToString(bytes.Length);
					}
					text = text + "\0" + Conversions.ToString(this.mypictures);
					int num3 = 1;
					int num4 = this.mypictures;
					for (int i = num3; i <= num4; i++)
					{
						text = text + "\0" + Conversions.ToString(this.mypicture[i - 1].mypi.Length);
					}
					text = text + "\0" + Conversions.ToString(this.W_myrtfnum);
					int num5 = 1;
					int w_myrtfnum = this.W_myrtfnum;
					for (int i = num5; i <= w_myrtfnum; i++)
					{
						text = text + "\0" + Conversions.ToString(this.W_myrtfC[i - 1].mypi.Length);
					}
					if (Operators.CompareString(mm, "", false) != 0)
					{
						text = text + "\0" + Module1.EncryptionString(mm);
					}
					if (!isoldversion)
					{
						fileStream.WriteByte(86);
						fileStream.WriteByte(83);
						fileStream.WriteByte(48);
						fileStream.WriteByte(49);
					}
					bytes = unicodeEncoding.GetBytes(text);
					if (Strings.Len(Conversions.ToString(bytes.Length)) >= 10)
					{
						fileStream.WriteByte((byte)Strings.Asc(Conversions.ToString(Strings.Len(Conversions.ToString(bytes.Length))).Substring(0, 1)));
						fileStream.WriteByte((byte)Strings.Asc(Conversions.ToString(Strings.Len(Conversions.ToString(bytes.Length))).Substring(1, 1)));
					}
					else
					{
						fileStream.WriteByte(48);
						fileStream.WriteByte((byte)Strings.Asc(Conversions.ToString(Strings.Len(Conversions.ToString(bytes.Length)))));
					}
					int num6 = 1;
					int num7 = Strings.Len(Conversions.ToString(bytes.Length));
					for (int i = num6; i <= num7; i++)
					{
						fileStream.WriteByte((byte)Strings.Asc(Conversions.ToString(bytes.Length).Substring(i - 1, 1)));
					}
					fileStream.Write(bytes, 0, bytes.Length);
					int num8 = 1;
					int num9 = this.mypages.Length;
					for (int i = num8; i <= num9; i++)
					{
						bytes = unicodeEncoding.GetBytes(this.mypages[i - 1].ToString());
						fileStream.Write(bytes, 0, bytes.Length);
					}
					int num10 = 1;
					int num11 = this.mypictures;
					for (int i = num10; i <= num11; i++)
					{
						fileStream.Write(this.mypicture[i - 1].mypi, 0, this.mypicture[i - 1].mypi.Length);
					}
					int num12 = 1;
					int w_myrtfnum2 = this.W_myrtfnum;
					for (int i = num12; i <= w_myrtfnum2; i++)
					{
						fileStream.Write(this.W_myrtfC[i - 1].mypi, 0, this.W_myrtfC[i - 1].mypi.Length);
					}
					fileStream.Close();
					fileStream.Dispose();
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000A3080 File Offset: 0x000A1280
		public string SaveReportAsString()
		{
			string result;
			if (this.GetPages() <= 0)
			{
				result = "";
			}
			else
			{
				string tempFileName = MyProject.Computer.FileSystem.GetTempFileName();
				if (!this.SaveReport(tempFileName, true))
				{
					MyProject.Computer.FileSystem.DeleteFile(tempFileName);
					result = "";
				}
				else
				{
					byte[] array = new byte[checked((int)(MyProject.Computer.FileSystem.GetFileInfo(tempFileName).Length - 1L) + 1)];
					FileStream fileStream = new FileStream(tempFileName, FileMode.Open, FileAccess.Read);
					fileStream.Read(array, 0, array.Length);
					fileStream.Close();
					string text = Convert.ToBase64String(array);
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(tempFileName);
					}
					catch (Exception ex)
					{
					}
					fileStream.Dispose();
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000A315C File Offset: 0x000A135C
		public bool OpenReportByString(string reportstring)
		{
			return this.OpenReportByString(reportstring, true);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000A3174 File Offset: 0x000A1374
		public bool OpenReportByString(string reportstring, bool isneedraisePrintHeaderFooterEvent)
		{
			bool result;
			if (this.w_end)
			{
				result = false;
			}
			else
			{
				this.CloseStatus();
				if (Operators.CompareString(reportstring, "", false) == 0)
				{
					result = false;
				}
				else
				{
					string tempFileName = MyProject.Computer.FileSystem.GetTempFileName();
					byte[] array = Convert.FromBase64String(reportstring);
					FileStream fileStream = new FileStream(tempFileName, FileMode.Create, FileAccess.Write);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
					fileStream.Dispose();
					if (this.OpenReport(tempFileName, isneedraisePrintHeaderFooterEvent))
					{
						try
						{
							MyProject.Computer.FileSystem.DeleteFile(tempFileName);
						}
						catch (Exception ex)
						{
						}
						result = true;
					}
					else
					{
						try
						{
							MyProject.Computer.FileSystem.DeleteFile(tempFileName);
						}
						catch (Exception ex2)
						{
						}
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x000A3254 File Offset: 0x000A1454
		public bool OpenReport(string myfilename)
		{
			return this.OpenReport(myfilename, false);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x000A326C File Offset: 0x000A146C
		public bool OpenReport(string myfilename, string mm)
		{
			return this.MyOpenReport(myfilename, false, true, mm);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000A3284 File Offset: 0x000A1484
		public bool OpenReport(string myfilename, bool IsRaisePrintFooterHeaderEvent)
		{
			return this.MyOpenReport(myfilename, IsRaisePrintFooterHeaderEvent, true, "");
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000A32A0 File Offset: 0x000A14A0
		private bool MyOpenReport(string myfilename, bool IsRaisePrintFooterHeaderEvent, bool isshow, string mm = "")
		{
			checked
			{
				bool result;
				if (this.w_end)
				{
					result = false;
				}
				else if (!MyProject.Computer.FileSystem.FileExists(myfilename))
				{
					result = false;
				}
				else
				{
					FileStream fileStream = new FileStream(myfilename, FileMode.Open, FileAccess.Read);
					UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
					try
					{
						string text = Conversions.ToString(Strings.Chr(fileStream.ReadByte())) + Conversions.ToString(Strings.Chr(fileStream.ReadByte()));
						int num;
						if (Operators.CompareString(text, "VS", false) == 0)
						{
							text = Conversions.ToString(Strings.Chr(fileStream.ReadByte())) + Conversions.ToString(Strings.Chr(fileStream.ReadByte()));
							num = Conversions.ToInteger(Conversions.ToString(Strings.Chr(fileStream.ReadByte())) + Conversions.ToString(Strings.Chr(fileStream.ReadByte())));
						}
						else
						{
							num = Conversions.ToInteger(text);
						}
						string text2 = "";
						int num2 = 1;
						int num3 = num;
						for (int i = num2; i <= num3; i++)
						{
							text2 += Conversions.ToString(Strings.Chr(fileStream.ReadByte()));
						}
						num = Conversions.ToInteger(text2);
						byte[] array = new byte[num - 1 + 1];
						fileStream.Read(array, 0, num);
						text2 = unicodeEncoding.GetString(array);
						string[] array2 = Strings.Split(text2, "\0", -1, CompareMethod.Binary);
						num = Conversions.ToInteger(array2[0]);
						int[] array3 = new int[num - 1 + 1];
						int num4 = 1;
						int num5 = num;
						for (int i = num4; i <= num5; i++)
						{
							array3[i - 1] = Conversions.ToInteger(array2[i]);
						}
						this.mypictures = Conversions.ToInteger(array2[num + 1]);
						int[] array4 = new int[this.mypictures - 1 + 1];
						int num6 = 1;
						int num7 = this.mypictures;
						for (int i = num6; i <= num7; i++)
						{
							array4[i - 1] = Conversions.ToInteger(array2[num + 1 + i]);
						}
						try
						{
							this.W_myrtfnum = Conversions.ToInteger(array2[num + this.mypictures + 2]);
						}
						catch (Exception ex)
						{
							this.W_myrtfnum = 0;
						}
						int[] array5 = new int[this.W_myrtfnum - 1 + 1];
						try
						{
							int num8 = 1;
							int w_myrtfnum = this.W_myrtfnum;
							for (int i = num8; i <= w_myrtfnum; i++)
							{
								array5[i - 1] = Conversions.ToInteger(array2[num + this.mypictures + 2 + i]);
							}
						}
						catch (Exception ex2)
						{
						}
						try
						{
							if (array2.Length > num + this.mypictures + this.W_myrtfnum + 3 && Operators.CompareString(array2[num + this.mypictures + this.W_myrtfnum + 3], "", false) != 0)
							{
								if (Operators.CompareString(mm, "", false) == 0)
								{
									OpenmmDialog openmmDialog = new OpenmmDialog();
									openmmDialog.Label2.Text = "报表文件【" + MyProject.Computer.FileSystem.GetName(myfilename) + "】是加密的，请输入密码";
									if (openmmDialog.ShowDialog() != DialogResult.OK)
									{
										openmmDialog.Dispose();
										return false;
									}
									if (Operators.CompareString(Module1.DecryptionString(array2[num + this.mypictures + this.W_myrtfnum + 3]), openmmDialog.TextBox1.Text, false) != 0)
									{
										Interaction.MsgBox("打开报表文件【" + myfilename + "】失败，密码不正确", MsgBoxStyle.OkOnly, "提示信息");
										openmmDialog.Dispose();
										return false;
									}
									openmmDialog.Dispose();
								}
								else if (Operators.CompareString(Module1.DecryptionString(array2[num + this.mypictures + this.W_myrtfnum + 3]), mm, false) != 0)
								{
									Interaction.MsgBox("打开报表文件【" + myfilename + "】失败，密码不正确", MsgBoxStyle.OkOnly, "提示信息");
									return false;
								}
							}
						}
						catch (Exception ex3)
						{
						}
						this.W_myrtfC = null;
						this.mypicture = null;
						this.myPaperHeight = null;
						this.myPaperWidth = null;
						this.DelMypages();
						GC.Collect();
						this.mypicture = new VB2008Print.mypic[this.mypictures - 1 + 1];
						int num9 = 1;
						int num10 = num;
						for (int i = num9; i <= num10; i++)
						{
							array = new byte[array3[i - 1] - 1 + 1];
							fileStream.Read(array, 0, array3[i - 1]);
							text2 = unicodeEncoding.GetString(array);
							this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[i - 1 + 1]);
							this.mypages[i - 1] = new StringBuilder();
							this.mypages[i - 1].Append(text2);
						}
						int num11 = 1;
						int num12 = this.mypictures;
						for (int i = num11; i <= num12; i++)
						{
							this.mypicture[i - 1].mypi = new byte[array4[i - 1] - 1 + 1];
							fileStream.Read(this.mypicture[i - 1].mypi, 0, array4[i - 1]);
						}
						this.W_myrtfC = new VB2008Print.mypic[this.W_myrtfnum - 1 + 1];
						try
						{
							int num13 = 1;
							int w_myrtfnum2 = this.W_myrtfnum;
							for (int i = num13; i <= w_myrtfnum2; i++)
							{
								this.W_myrtfC[i - 1].mypi = new byte[array5[i - 1] - 1 + 1];
								fileStream.Read(this.W_myrtfC[i - 1].mypi, 0, array5[i - 1]);
							}
						}
						catch (Exception ex4)
						{
						}
						if (isshow)
						{
							this.cpage.Items.Clear();
							int num14 = 1;
							int num15 = this.GetPages();
							for (int i = num14; i <= num15; i++)
							{
								this.cpage.Items.Add("第" + Conversions.ToString(i) + "页");
							}
							this.SaveCS();
							if (IsRaisePrintFooterHeaderEvent)
							{
								try
								{
									if (this.myg != null)
									{
										this.myg.Dispose();
										this.myg = null;
									}
								}
								catch (Exception ex5)
								{
								}
								this.myg = this.Pd.PrinterSettings.CreateMeasurementGraphics();
								int num16 = 1;
								int num17 = this.GetPages();
								for (int j = num16; j <= num17; j++)
								{
									this.SetCurrentPage(j);
									PaperSize paperSize = this.mypagesetting.PaperSize;
									this.SavePaperHeightAndWidth(paperSize);
									VB2008Print.HeaderFooterOutEventHandler headerFooterOutEvent = this.HeaderFooterOutEvent;
									if (headerFooterOutEvent != null)
									{
										headerFooterOutEvent(this.GetPages(), j);
									}
									this.SetCurrentPage(j);
									float num18 = 1f;
									float num19 = 10f;
									if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
									{
										num18 = (float)((double)num18 / 2.54);
										num19 = (float)((double)num19 / 2.54);
									}
									unchecked
									{
										if (this.IsDrawPageHeaderLine)
										{
											this.DrawLine(0f, 0f - num19, this.PaperPrintWidth, 0f - num19, Color.Black, num18);
										}
										if (this.IsDrawPageFooterLine)
										{
											this.DrawLine(0f, this.PaperPrintHeight + num19, this.PaperPrintWidth, this.PaperPrintHeight + num19, Color.Black, num18);
										}
									}
								}
							}
							int num20 = 1;
							int num21 = this.GetPages();
							for (int k = num20; k <= num21; k++)
							{
								this.GetPageAndPaperSettings(k);
								this.currentpage = k;
								PaperSize paperSize2 = this.mypagesetting.PaperSize;
								this.SavePaperHeightAndWidth(paperSize2);
							}
							this.currentpage = 1;
							this.MyShow();
						}
						if (!isshow)
						{
							int num22 = 1;
							int num23 = this.GetPages();
							for (int l = num22; l <= num23; l++)
							{
								this.GetPageAndPaperSettings(l);
								this.currentpage = l;
								PaperSize paperSize3 = this.mypagesetting.PaperSize;
								this.SavePaperHeightAndWidth(paperSize3);
							}
							this.currentpage = 1;
						}
						result = true;
					}
					catch (Exception ex6)
					{
						result = false;
					}
					finally
					{
						fileStream.Close();
						fileStream.Dispose();
						fileStream = null;
						string[] array2 = null;
						unicodeEncoding = null;
					}
				}
				return result;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00007304 File Offset: 0x00005504
		public void AddReport(string filename)
		{
			if (MyProject.Computer.FileSystem.FileExists(filename))
			{
				this.MyAddReport(filename);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000A3B1C File Offset: 0x000A1D1C
		public void AddReportByString(string reportstring)
		{
			if (Operators.CompareString(reportstring, "", false) != 0)
			{
				string tempFileName = MyProject.Computer.FileSystem.GetTempFileName();
				byte[] array = Convert.FromBase64String(reportstring);
				FileStream fileStream = new FileStream(tempFileName, FileMode.Create, FileAccess.Write);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
				fileStream.Dispose();
				this.AddReport(tempFileName);
				try
				{
					MyProject.Computer.FileSystem.DeleteFile(tempFileName);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000A3BAC File Offset: 0x000A1DAC
		private void MyAddReport(string filename)
		{
			VB2008Print.mypic[] s_picture = null;
			StringBuilder[] array = null;
			VB2008Print.mypic[] s_myrtfc = null;
			float[] s_paperwidth = null;
			float[] s_paperheight = null;
			int w_myrtfnum = this.W_myrtfnum;
			int num = this.mypictures;
			VB2008Print.MyCopyReportSS(this.mypicture, this.W_myrtfC, this.mypages, ref s_picture, ref s_myrtfc, ref array, this.myPaperWidth, ref s_paperwidth, this.myPaperHeight, ref s_paperheight);
			checked
			{
				if (this.MyOpenReport(filename, false, false, ""))
				{
					VB2008Print.mypic[] array2 = null;
					StringBuilder[] array3 = null;
					VB2008Print.mypic[] array4 = null;
					float[] array5 = null;
					float[] array6 = null;
					int num2 = this.mypictures;
					if (this.mypictures > 0 && num > 0)
					{
						int num3 = 1;
						int num4 = this.mypages.Length - 1;
						for (int i = num3; i <= num4; i++)
						{
							string value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "i", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
							value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "i2", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
							value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "i3", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
							value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "i4", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
							value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "DrawImageUnscaledAndClipped", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
							value = VB2008Print.MyReplaceReport(this.mypages[i].ToString(), "DrawImageUnscaled", num, this.mypictures);
							this.mypages[i].Length = 0;
							this.mypages[i].Append(value);
						}
					}
					VB2008Print.MyCopyReportSS(this.mypicture, this.W_myrtfC, this.mypages, ref array2, ref array4, ref array3, this.myPaperWidth, ref array5, this.myPaperHeight, ref array6);
					this.mypicture = null;
					this.W_myrtfC = null;
					this.mypages = null;
					this.myPaperHeight = null;
					this.myPaperWidth = null;
					VB2008Print.MyCopyReportSS(s_picture, s_myrtfc, array, ref this.mypicture, ref this.W_myrtfC, ref this.mypages, s_paperwidth, ref this.myPaperWidth, s_paperheight, ref this.myPaperHeight);
					this.W_myrtfnum = w_myrtfnum;
					this.mypictures = num + num2;
					this.mypicture = (VB2008Print.mypic[])Utils.CopyArray((Array)this.mypicture, new VB2008Print.mypic[this.mypictures - 1 + 1]);
					int num5 = num;
					int num6 = this.mypictures - 1;
					for (int j = num5; j <= num6; j++)
					{
						this.mypicture[j].mypi = (byte[])array2[j - num].mypi.Clone();
					}
					int num7 = array.Length + array3.Length - 1;
					this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[num7 - 1 + 1]);
					int num8 = array.Length;
					int num9 = num7 - 1;
					for (int k = num8; k <= num9; k++)
					{
						this.mypages[k] = new StringBuilder();
						this.mypages[k].Append(array3[k - array.Length + 1].ToString());
					}
					string[] array7 = Strings.Split(array3[0].ToString(), "\u0002\u0004", -1, CompareMethod.Binary);
					int num10 = 1;
					int num11 = array7.Length - 1;
					for (int l = num10; l <= num11; l++)
					{
						this.mypages[0].Append("\u0002\u0004");
						this.mypages[0].Append(array7[l]);
					}
					int num12 = this.myPaperHeight.Length + array6.Length - 2;
					int num13 = this.myPaperHeight.Length;
					this.myPaperWidth = (float[])Utils.CopyArray((Array)this.myPaperWidth, new float[num12 + 1]);
					this.myPaperHeight = (float[])Utils.CopyArray((Array)this.myPaperHeight, new float[num12 + 1]);
					int num14 = num13;
					int num15 = num12;
					for (int m = num14; m <= num15; m++)
					{
						this.myPaperWidth[m] = array5[m - num13 + 1];
						this.myPaperHeight[m] = array6[m - num13 + 1];
					}
					array6 = null;
					array5 = null;
					array2 = null;
					array4 = null;
					array3 = null;
					this.SetCurrentPage(this.GetPages());
					this.GetPageAndPaperSettings(this.GetPages());
				}
				else
				{
					this.W_myrtfnum = w_myrtfnum;
					this.mypictures = num;
					VB2008Print.MyCopyReportSS(s_picture, s_myrtfc, array, ref this.mypicture, ref this.W_myrtfC, ref this.mypages, s_paperwidth, ref this.myPaperWidth, s_paperheight, ref this.myPaperHeight);
				}
				s_picture = null;
				s_myrtfc = null;
				array = null;
				s_paperheight = null;
				s_paperwidth = null;
				GC.Collect();
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000A40C8 File Offset: 0x000A22C8
		private static void MyCopyReportSS(VB2008Print.mypic[] s_picture, VB2008Print.mypic[] s_myrtfc, StringBuilder[] s_mypages, ref VB2008Print.mypic[] d_picture, ref VB2008Print.mypic[] d_myrtfc, ref StringBuilder[] d_mypages, float[] s_paperwidth, ref float[] d_paperwidth, float[] s_paperheight, ref float[] d_paperheight)
		{
			checked
			{
				if (s_picture != null)
				{
					d_picture = new VB2008Print.mypic[s_picture.Length - 1 + 1];
					int num = 0;
					int num2 = s_picture.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						d_picture[i].mypi = (byte[])s_picture[i].mypi.Clone();
					}
				}
				else
				{
					d_picture = null;
				}
				if (s_myrtfc != null)
				{
					d_myrtfc = new VB2008Print.mypic[s_myrtfc.Length - 1 + 1];
					int num3 = 0;
					int num4 = s_myrtfc.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						d_myrtfc[j].mypi = (byte[])s_myrtfc[j].mypi.Clone();
					}
				}
				else
				{
					d_myrtfc = null;
				}
				if (s_mypages != null)
				{
					d_mypages = new StringBuilder[s_mypages.Length - 1 + 1];
					int num5 = 0;
					int num6 = s_mypages.Length - 1;
					for (int k = num5; k <= num6; k++)
					{
						d_mypages[k] = new StringBuilder();
						d_mypages[k].Append(s_mypages[k].ToString());
					}
				}
				else
				{
					d_mypages = null;
				}
				if (s_paperwidth != null)
				{
					d_paperwidth = new float[s_paperwidth.Length - 1 + 1];
					int num7 = 0;
					int num8 = s_paperwidth.Length - 1;
					for (int l = num7; l <= num8; l++)
					{
						d_paperwidth[l] = s_paperwidth[l];
					}
				}
				else
				{
					d_paperwidth = null;
				}
				if (s_paperheight != null)
				{
					d_paperheight = new float[s_paperheight.Length - 1 + 1];
					int num9 = 0;
					int num10 = s_paperheight.Length - 1;
					for (int m = num9; m <= num10; m++)
					{
						d_paperheight[m] = s_paperheight[m];
					}
				}
				else
				{
					d_paperheight = null;
				}
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000A4234 File Offset: 0x000A2434
		private static string MyReplaceReport(string ss, string bz, int @base, int maxpics)
		{
			string str = "\u0001\u0003" + bz + "\0";
			int num = 0;
			checked
			{
				int num2 = maxpics - 1;
				for (int i = num; i <= num2; i++)
				{
					string text = str + Conversions.ToString(i) + "\0";
					if (Strings.InStr(ss, text, CompareMethod.Binary) > 0)
					{
						string replacement = str + Conversions.ToString(i + @base) + "\0";
						ss = Strings.Replace(ss, text, replacement, 1, -1, CompareMethod.Binary);
					}
				}
				return ss;
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000A42AC File Offset: 0x000A24AC
		public bool SaveReport(string myfilename)
		{
			return this.SaveReport(myfilename, true);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000A42C4 File Offset: 0x000A24C4
		

		// Token: 0x06001455 RID: 5205 RVA: 0x0000736B File Offset: 0x0000556B
		public void InvalidatePreview()
		{
			this.isfrompageset = false;
			if (!this.isstarting)
			{
				this.StartPrePreview();
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00007382 File Offset: 0x00005582
		private void StartPrePreview()
		{
			this.myisendpreview = false;
			this.isstarting = true;
			this.StartBeforePreviewDo();
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00007398 File Offset: 0x00005598
		private void StartBeforePreviewDo()
		{
			PreviewController.StartDo(this.BeforePreviewD);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000A48B4 File Offset: 0x000A2AB4
		public void NewDoc()
		{
			if (this.CheckPrinter(this.IsShowErrorMSG))
			{
				this.isstarting = true;
				this.isfrompageset = false;
				this.myisendpreview = false;
				try
				{
					if (this.myg != null)
					{
						this.myg.Dispose();
						this.myg = null;
					}
				}
				catch (Exception ex)
				{
				}
				this.myg = this.Pd.PrinterSettings.CreateMeasurementGraphics();
				this.myNewDoc();
				this.IsOpenReporting = true;
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000073A5 File Offset: 0x000055A5
		public void EndDoc()
		{
			this.myEndDoc();
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x000A4944 File Offset: 0x000A2B44
		public void EndDoc(string windowtitle)
		{
			this.EndDoc();
			if (!this.IsImmediatePrintNotPreview)
			{
				PrintView printView = new PrintView();
				try
				{
					printView.Text = windowtitle;
					printView.myp.DocumentName = this.DocumentName;
					printView.myp.IsDrawmargin = this.IsDrawmargin;
					printView.myp.EnabledPrint = this.EnabledPrint;
					printView.myp.IsShowContextMenu = this.IsShowContextMenu;
					printView.myp.IsShowMessageIfPrinterNotSupportPaper = this.IsShowMessageIfPrinterNotSupportPaper;
					printView.myp.IsShowPrintStatusDialog = this.IsShowPrintStatusDialog;
					printView.myp.IsUseAPIprintDialog = this.IsUseAPIprintDialog;
					printView.myp.IsShowProgess = this.IsShowProgess;
					printView.myp.EnablePrintDraft = this.EnablePrintDraft;
					printView.myp.BackColor = this.BackColor;
					printView.myp.ForeColor = this.ForeColor;
					printView.myp.EnableSaveAsImage = this.EnableSaveAsImage;
					printView.myp.EnableSaveAsPDF = this.EnableSaveAsPDF;
					printView.myp.IsAutoAdjustPrinterMargin = this.IsAutoAdjustPrinterMargin;
					printView.myp.CanOpenReport = this.CanOpenReport;
					printView.myp.PageUnits = this.PageUnits;
					printView.myp.OffsetX = this.OffsetX;
					printView.myp.OffsetY = this.OffsetY;
					printView.myp.OpenReportByString(this.SaveReportAsString());
					printView.WindowState = FormWindowState.Maximized;
					printView.ShowDialog();
				}
				catch (Exception ex)
				{
				}
				finally
				{
					printView.Dispose();
					printView = null;
				}
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000A4B10 File Offset: 0x000A2D10
		private static int GetDGVColIndexByColDisplayIndex(DataGridView dgv, int DisplayIndex)
		{
			checked
			{
				int result;
				if (dgv == null)
				{
					result = -1;
				}
				else if (DisplayIndex < 0)
				{
					result = -1;
				}
				else
				{
					try
					{
						int num = 0;
						int num2 = dgv.ColumnCount - 1;
						for (int i = num; i <= num2; i++)
						{
							if (dgv.Columns[i].DisplayIndex == DisplayIndex)
							{
								return i;
							}
						}
					}
					catch (Exception ex)
					{
						return -1;
					}
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000A4B80 File Offset: 0x000A2D80
		public float DrawDGVHeaderCell(DataGridView dgv, int coldisplayindex, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else
			{
				int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
				if (dgvcolIndexByColDisplayIndex < 0)
				{
					result = 0f;
				}
				else
				{
					DataGridViewColumn mycolumn;
					try
					{
						mycolumn = dgv.Columns[dgvcolIndexByColDisplayIndex];
					}
					catch (Exception ex)
					{
						return 0f;
					}
					result = this.DrawDGVHeaderCell(dgv, mycolumn, PrintBackColor, myborder, minfontsize);
				}
			}
			return result;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		public float DrawDGVHeaderCell(DataGridView dgv, DataGridViewColumn mycolumn, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (mycolumn == null)
			{
				result = 0f;
			}
			else if (dgv == null)
			{
				result = 0f;
			}
			else
			{
				float colwidth = this.ConvFromDisplay((float)mycolumn.Width, true);
				float colheight = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
				result = this.DrawDGVHeaderCell(dgv, mycolumn, colwidth, colheight, PrintBackColor, myborder, minfontsize);
			}
			return result;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000A4C44 File Offset: 0x000A2E44
		public float DrawDGVHeaderCell(DataGridView dgv, int coldisplayindex, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else
			{
				int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
				if (dgvcolIndexByColDisplayIndex < 0)
				{
					result = 0f;
				}
				else
				{
					DataGridViewColumn dataGridViewColumn = dgv.Columns[dgvcolIndexByColDisplayIndex];
					float num = this.DrawDGVHeaderCell(dgv, dataGridViewColumn, colwidth, colheight, PrintBackColor, myborder, minfontsize);
					try
					{
						dataGridViewColumn.Dispose();
					}
					catch (Exception ex)
					{
					}
					result = num;
				}
			}
			return result;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000A4CBC File Offset: 0x000A2EBC
		public float DrawDGVHeaderCell(DataGridView dgv, DataGridViewColumn mycolumn, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else if (mycolumn == null)
			{
				result = 0f;
			}
			else if (!mycolumn.Visible)
			{
				result = 0f;
			}
			else
			{
				bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
				this.IsNeedCheckNewPage = false;
				this.MyDrawDGVHeaderCell(mycolumn, colwidth, colheight, myborder, PrintBackColor, (float)minfontsize);
				this.IsNeedCheckNewPage = isNeedCheckNewPage;
				result = colwidth;
			}
			return result;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000A4D18 File Offset: 0x000A2F18
		public float DrawDGVContentCell(DataGridView dgv, int rowindex, int coldisplayindex, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
			float result;
			if (dgvcolIndexByColDisplayIndex < 0)
			{
				result = 0f;
			}
			else
			{
				try
				{
					result = this.DrawDGVContentCell(dgv, dgv.Rows[rowindex].Cells[dgvcolIndexByColDisplayIndex], PrintBackColor, myborder, minfontsize);
				}
				catch (Exception ex)
				{
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000A4D88 File Offset: 0x000A2F88
		public float DrawDGVContentCell(DataGridView dgv, DataGridViewCell dgvcell, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else if (dgvcell == null)
			{
				result = 0f;
			}
			else if (dgv == null)
			{
				result = 0f;
			}
			else
			{
				float colwidth = this.ConvFromDisplay((float)dgv.Columns[dgvcell.ColumnIndex].Width, true);
				float colheight = this.ConvFromDisplay((float)dgv.Rows[dgvcell.RowIndex].Height, false);
				result = this.DrawDGVContentCell(dgv, dgvcell, colwidth, colheight, PrintBackColor, myborder, minfontsize);
			}
			return result;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000A4E08 File Offset: 0x000A3008
		public float DrawDGVContentCell(DataGridView dgv, int rowindex, int coldisplayindex, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
			float result;
			if (dgvcolIndexByColDisplayIndex < 0)
			{
				result = 0f;
			}
			else
			{
				DataGridViewCell dgvcell;
				try
				{
					dgvcell = dgv.Rows[rowindex].Cells[dgvcolIndexByColDisplayIndex];
				}
				catch (Exception ex)
				{
					return 0f;
				}
				result = this.DrawDGVContentCell(dgv, dgvcell, colwidth, colheight, PrintBackColor, myborder, minfontsize);
			}
			return result;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000A4E7C File Offset: 0x000A307C
		public float DrawDGVContentCell(DataGridView dgv, DataGridViewCell dgvcell, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else if (dgvcell == null)
			{
				result = 0f;
			}
			else
			{
				DataGridViewRow dataGridViewRow;
				DataGridViewColumn dataGridViewColumn;
				try
				{
					dataGridViewRow = dgv.Rows[dgvcell.RowIndex];
					dataGridViewColumn = dgv.Columns[dgvcell.ColumnIndex];
				}
				catch (Exception ex)
				{
					return 0f;
				}
				if (!dataGridViewColumn.Visible)
				{
					result = 0f;
				}
				else if (!dataGridViewRow.Visible)
				{
					result = 0f;
				}
				else
				{
					bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
					this.IsNeedCheckNewPage = false;
					this.MyDrawDGVCell(dgvcell, colwidth, colheight, myborder, PrintBackColor, (float)minfontsize);
					this.IsNeedCheckNewPage = isNeedCheckNewPage;
					result = colwidth;
				}
			}
			return result;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000A4F38 File Offset: 0x000A3138
		public void DrawDGVRowForEmpty(DataGridView dgv, int rowid, string myborder = "1111", int minfontsize = 0)
		{
			float rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
			this.DrawDGVRowForEmpty(dgv, rowid, rowheight, false, true, myborder, minfontsize);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000073AD File Offset: 0x000055AD
		public void DrawDGVRowForEmpty(DataGridView dgv, int rowid, float rowheight, string myborder = "1111", int minfontsize = 0)
		{
			this.DrawDGVRowForEmpty(dgv, rowid, rowheight, false, true, myborder, minfontsize);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000A4F70 File Offset: 0x000A3170
		public void DrawDGVRowForEmpty(DataGridView dgv, int rowid, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
			this.DrawDGVRowForEmpty(dgv, rowid, rowheight, ZoomToPaperWidth, PrintBackColor, myborder, minfontsize);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000A4FA8 File Offset: 0x000A31A8
		public void DrawDGVRowForEmpty(DataGridView dgv, int rowid, float rowheight, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0 && dgv.RowCount > 0 && rowid < dgv.RowCount)
				{
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
					}
					int[] array3 = new int[columnCount - 1 + 1];
					int num3 = 0;
					int num4 = columnCount - 1;
					for (int i = num3; i <= num4; i++)
					{
						array2[i] = array[i];
						array3[i] = dgv.Columns[array[i]].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array2);
					float[] array4 = new float[columnCount - 1 + 1];
					float num5 = 0f;
					float currentx = this.Currentx;
					int num6 = 0;
					int num7 = columnCount - 1;
					for (int i = num6; i <= num7; i++)
					{
						unchecked
						{
							if (dgv.Columns[array2[i]].Visible)
							{
								DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[i]];
								float num8 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
								num5 += num8;
								array4[i] = num8;
							}
						}
					}
					if (num5 != 0f)
					{
						if (ZoomToPaperWidth)
						{
							float num9 = unchecked(this.PaperPrintWidth - currentx) / num5;
							int num10 = 0;
							int num11 = columnCount - 1;
							for (int i = num10; i <= num11; i++)
							{
								unchecked
								{
									array4[i] *= num9;
								}
							}
							num5 = 0f;
							int num12 = 0;
							int num13 = columnCount - 1;
							for (int i = num12; i <= num13; i++)
							{
								unchecked
								{
									num5 += array4[i];
								}
							}
						}
						if (rowheight <= 0f)
						{
							rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
						}
						int num14 = 0;
						int num15 = columnCount - 1;
						for (int j = num14; j <= num15; j++)
						{
							DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[j]];
							this.DrawDGVContentCellForEmpty(dgv, dgv.Rows[rowid].Cells[array2[j]], array4[j], rowheight, PrintBackColor, myborder, minfontsize);
						}
						this.Currentx = currentx;
						unchecked
						{
							this.Currenty += rowheight;
						}
					}
				}
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000A51C0 File Offset: 0x000A33C0
		public float DrawDGVContentCellForEmpty(DataGridView dgv, int rowindex, int coldisplayindex, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
			float result;
			if (dgvcolIndexByColDisplayIndex < 0)
			{
				result = 0f;
			}
			else
			{
				try
				{
					result = this.DrawDGVContentCellForEmpty(dgv, dgv.Rows[rowindex].Cells[dgvcolIndexByColDisplayIndex], PrintBackColor, myborder, minfontsize);
				}
				catch (Exception ex)
				{
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x000A5230 File Offset: 0x000A3430
		public float DrawDGVContentCellForEmpty(DataGridView dgv, DataGridViewCell dgvcell, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else if (dgvcell == null)
			{
				result = 0f;
			}
			else if (dgv == null)
			{
				result = 0f;
			}
			else
			{
				float colwidth = this.ConvFromDisplay((float)dgv.Columns[dgvcell.ColumnIndex].Width, true);
				float colheight = this.ConvFromDisplay((float)dgv.Rows[dgvcell.RowIndex].Height, false);
				result = this.DrawDGVContentCellForEmpty(dgv, dgvcell, colwidth, colheight, PrintBackColor, myborder, minfontsize);
			}
			return result;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000A52B0 File Offset: 0x000A34B0
		public float DrawDGVContentCellForEmpty(DataGridView dgv, int rowindex, int coldisplayindex, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			int dgvcolIndexByColDisplayIndex = VB2008Print.GetDGVColIndexByColDisplayIndex(dgv, coldisplayindex);
			float result;
			if (dgvcolIndexByColDisplayIndex < 0)
			{
				result = 0f;
			}
			else
			{
				DataGridViewCell dgvcell;
				try
				{
					dgvcell = dgv.Rows[rowindex].Cells[dgvcolIndexByColDisplayIndex];
				}
				catch (Exception ex)
				{
					return 0f;
				}
				result = this.DrawDGVContentCellForEmpty(dgv, dgvcell, colwidth, colheight, PrintBackColor, myborder, minfontsize);
			}
			return result;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000A5324 File Offset: 0x000A3524
		public float DrawDGVContentCellForEmpty(DataGridView dgv, DataGridViewCell dgvcell, float colwidth, float colheight, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			float result;
			if (dgv == null)
			{
				result = 0f;
			}
			else if (dgvcell == null)
			{
				result = 0f;
			}
			else
			{
				DataGridViewColumn dataGridViewColumn;
				try
				{
					DataGridViewRow dataGridViewRow = dgv.Rows[dgvcell.RowIndex];
					dataGridViewColumn = dgv.Columns[dgvcell.ColumnIndex];
				}
				catch (Exception ex)
				{
					return 0f;
				}
				if (!dataGridViewColumn.Visible)
				{
					result = 0f;
				}
				else
				{
					Font myf = new Font("宋体", 12f);
					Color black = Color.Black;
					bool mulline = true;
					Color dgvcellBackColor = Module1.GetDGVCellBackColor(dgvcell);
					string s = "";
					bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
					this.IsNeedCheckNewPage = false;
					if (!PrintBackColor)
					{
						this.DrawCell(s, colwidth, colheight, myf, black, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, (float)minfontsize, Color.White, dgv.GridColor, 0);
					}
					else
					{
						this.DrawCell(s, colwidth, colheight, myf, black, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, (float)minfontsize, dgvcellBackColor, dgv.GridColor, 0);
					}
					this.IsNeedCheckNewPage = isNeedCheckNewPage;
					dataGridViewColumn = null;
					result = colwidth;
				}
			}
			return result;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000A5444 File Offset: 0x000A3644
		public void DrawDGVHeader(DataGridView dgv, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float colheaderheight = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
				this.DrawDGVHeader(dgv, colheaderheight, false, true, myborder, minfontsize);
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000073BE File Offset: 0x000055BE
		public void DrawDGVHeader(DataGridView dgv, float colheaderheight, string myborder = "1111", int minfontsize = 0)
		{
			this.DrawDGVHeader(dgv, colheaderheight, false, true, myborder, minfontsize);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x000A5470 File Offset: 0x000A3670
		public void DrawDGVHeader(DataGridView dgv, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float colheaderheight = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
				this.DrawDGVHeader(dgv, colheaderheight, ZoomToPaperWidth, PrintBackColor, myborder, minfontsize);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000A54A0 File Offset: 0x000A36A0
		public void DrawDGVHeader(DataGridView dgv, float colheaderheight, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0)
				{
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
					}
					int[] array3 = new int[columnCount - 1 + 1];
					int num3 = 0;
					int num4 = columnCount - 1;
					for (int i = num3; i <= num4; i++)
					{
						array2[i] = array[i];
						array3[i] = dgv.Columns[array[i]].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array2);
					float[] array4 = new float[columnCount - 1 + 1];
					float num5 = 0f;
					float currentx = this.Currentx;
					int num6 = 0;
					int num7 = columnCount - 1;
					for (int i = num6; i <= num7; i++)
					{
						unchecked
						{
							if (dgv.Columns[array2[i]].Visible)
							{
								DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[i]];
								float num8 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
								num5 += num8;
								array4[i] = num8;
							}
						}
					}
					if (num5 != 0f)
					{
						if (ZoomToPaperWidth)
						{
							float num9 = unchecked(this.PaperPrintWidth - currentx) / num5;
							int num10 = 0;
							int num11 = columnCount - 1;
							for (int i = num10; i <= num11; i++)
							{
								unchecked
								{
									array4[i] *= num9;
								}
							}
							num5 = 0f;
							int num12 = 0;
							int num13 = columnCount - 1;
							for (int i = num12; i <= num13; i++)
							{
								unchecked
								{
									num5 += array4[i];
								}
							}
						}
						float num14 = colheaderheight;
						if (num14 <= 0f)
						{
							num14 = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
						}
						int num15 = 0;
						int num16 = columnCount - 1;
						for (int j = num15; j <= num16; j++)
						{
							DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[j]];
							this.DrawDGVHeaderCell(dgv, dataGridViewColumn, array4[j], num14, PrintBackColor, myborder, minfontsize);
						}
						this.Currentx = currentx;
						unchecked
						{
							this.Currenty += num14;
						}
					}
				}
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000A5680 File Offset: 0x000A3880
		public void DrawDGVHeaderEx(DataGridView dgv, TreeView mulheadertreeview, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float colheaderheight = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
				this.DrawDGVHeaderEx(dgv, colheaderheight, false, true, mulheadertreeview, myborder, minfontsize);
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000073CD File Offset: 0x000055CD
		public void DrawDGVHeaderEx(DataGridView dgv, float colheaderheight, TreeView mulheadertreeview, string myborder = "1111", int minfontsize = 0)
		{
			this.DrawDGVHeaderEx(dgv, colheaderheight, false, true, mulheadertreeview, myborder, minfontsize);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000A56B0 File Offset: 0x000A38B0
		public void DrawDGVHeaderEx(DataGridView dgv, bool ZoomToPaperWidth, bool PrintBackColor, TreeView mulheadertreeview, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float colheaderheight = this.ConvFromDisplay((float)dgv.ColumnHeadersHeight, false);
				this.DrawDGVHeaderEx(dgv, colheaderheight, ZoomToPaperWidth, PrintBackColor, mulheadertreeview, myborder, minfontsize);
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000A56E0 File Offset: 0x000A38E0
		public void DrawDGVHeaderEx(DataGridView dgv, float colheaderheight, bool ZoomToPaperWidth, bool PrintBackColor, TreeView mulheadertreeview, string myborder = "1111", int minfontsize = 0)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0)
				{
					if (mulheadertreeview == null)
					{
						this.DrawDGVHeader(dgv, colheaderheight, ZoomToPaperWidth, PrintBackColor, myborder, minfontsize);
					}
					else
					{
						mytree mytree = new mytree(mulheadertreeview, dgv);
						if (mytree.GetColumns() != dgv.ColumnCount)
						{
							this.DrawDGVHeader(dgv, colheaderheight, ZoomToPaperWidth, PrintBackColor, myborder, minfontsize);
							mytree = null;
							mytree.Dispose();
						}
						else
						{
							mytree.Dispose();
							int columnCount = dgv.ColumnCount;
							int[] array = new int[columnCount - 1 + 1];
							int[] array2 = new int[columnCount - 1 + 1];
							int num = 0;
							int num2 = columnCount - 1;
							for (int i = num; i <= num2; i++)
							{
								array[i] = i;
							}
							int[] array3 = new int[columnCount - 1 + 1];
							int num3 = 0;
							int num4 = columnCount - 1;
							for (int i = num3; i <= num4; i++)
							{
								array2[i] = array[i];
								array3[i] = dgv.Columns[array[i]].DisplayIndex;
							}
							Array.Sort<int, int>(array3, array2);
							float[] array4 = new float[columnCount - 1 + 1];
							float num5 = 0f;
							float currentx = this.Currentx;
							int num6 = 0;
							int num7 = columnCount - 1;
							for (int i = num6; i <= num7; i++)
							{
								unchecked
								{
									if (dgv.Columns[array2[i]].Visible)
									{
										DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[i]];
										float num8 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
										num5 += num8;
										array4[i] = num8;
									}
								}
							}
							if (num5 != 0f)
							{
								float[] array5 = new float[dgv.ColumnCount - 1 + 1];
								if (ZoomToPaperWidth)
								{
									float num9 = unchecked(this.PaperPrintWidth - currentx) / num5;
									int num10 = 0;
									int num11 = columnCount - 1;
									for (int i = num10; i <= num11; i++)
									{
										unchecked
										{
											array4[i] *= num9;
											array5[array2[i]] = array4[i];
										}
									}
									num5 = 0f;
									int num12 = 0;
									int num13 = columnCount - 1;
									for (int i = num12; i <= num13; i++)
									{
										unchecked
										{
											num5 += array4[i];
										}
									}
								}
								else
								{
									int num14 = 0;
									int num15 = columnCount - 1;
									for (int i = num14; i <= num15; i++)
									{
										array5[array2[i]] = array4[i];
									}
								}
								mytree mytree2 = new mytree(mulheadertreeview, dgv, array5, (int)Math.Round((double)this.ConvToDisplay(colheaderheight, false)));
								int leves = mytree2.GetLeves();
								float num16 = 0f;
								int num17 = 0;
								int num18 = columnCount - 1;
								for (int j = num17; j <= num18; j++)
								{
									unchecked
									{
										if (dgv.Columns[array2[j]].Visible)
										{
											num16 += array4[j];
										}
									}
								}
								float currenty = this.Currenty;
								int num19 = 1;
								int num20 = leves;
								for (int k = num19; k <= num20; k++)
								{
									this.Currentx = currentx;
									this.Currenty = unchecked(currenty + colheaderheight / (float)leves * (float)(checked(k - 1)));
									int num21 = 0;
									int num22 = columnCount - 1;
									for (int l = num21; l <= num22; l++)
									{
										DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[l]];
										unchecked
										{
											if (dataGridViewColumn.Visible)
											{
												float num23 = mytree2.GetCellHeight(array2[l], k);
												float cellWidth = mytree2.GetCellWidth(array2[l], k);
												num23 = this.ConvFromDisplay(num23, false);
												string nodeText = mytree2.GetNodeText(array2[l], k);
												if (num23 == 0f | cellWidth == 0f)
												{
													this.Currentx += array4[l];
												}
												else if (dataGridViewColumn.Visible)
												{
													Font font = mytree2.GetNodeFont(array2[l], k);
													if (font == null)
													{
														font = Module1.GetDGVHeaderFont(dataGridViewColumn);
													}
													Color textforecolor = mytree2.GetNodeForeColor(array2[l], k);
													if (textforecolor.IsEmpty)
													{
														textforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
													}
													bool mulline = Module1.GetDGVHeaderMulline(dataGridViewColumn);
													Color backcolor = mytree2.GetNodeBackColor(array2[l], k);
													if (backcolor.IsEmpty)
													{
														backcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
													}
													mulline = true;
													if (!PrintBackColor)
													{
														this.DrawCell(nodeText, cellWidth, num23, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, (float)minfontsize, Color.White, dgv.GridColor, 0);
													}
													else
													{
														this.DrawCell(nodeText, cellWidth, num23, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, (float)minfontsize, backcolor, dgv.GridColor, 0);
													}
													this.Currentx = this.Currentx + array4[l] - cellWidth;
												}
											}
										}
									}
								}
								mytree2.Dispose();
								this.Currentx = currentx;
								this.Currenty = unchecked(currenty + colheaderheight);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000A5B58 File Offset: 0x000A3D58
		public void DrawDGVRow(DataGridView dgv, int rowid, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
				this.DrawDGVRow(dgv, rowid, rowheight, false, true, myborder, minfontsize);
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000073DE File Offset: 0x000055DE
		public void DrawDGVRow(DataGridView dgv, int rowid, float rowheight, string myborder = "1111", int minfontsize = 0)
		{
			this.DrawDGVRow(dgv, rowid, rowheight, false, true, myborder, minfontsize);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000A5B90 File Offset: 0x000A3D90
		public void DrawDGVRow(DataGridView dgv, int rowid, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			if (dgv != null)
			{
				float rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
				this.DrawDGVRow(dgv, rowid, rowheight, ZoomToPaperWidth, PrintBackColor, myborder, minfontsize);
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000A5BCC File Offset: 0x000A3DCC
		public void DrawDGVRow(DataGridView dgv, int rowid, float rowheight, bool ZoomToPaperWidth, bool PrintBackColor, string myborder = "1111", int minfontsize = 0)
		{
			checked
			{
				if (dgv != null && dgv.ColumnCount > 0 && dgv.RowCount > 0 && rowid < dgv.RowCount && rowid >= 0)
				{
					try
					{
						if (!dgv.Rows[rowid].Visible)
						{
							return;
						}
					}
					catch (Exception ex)
					{
					}
					int columnCount = dgv.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = i;
					}
					int[] array3 = new int[columnCount - 1 + 1];
					int num3 = 0;
					int num4 = columnCount - 1;
					for (int i = num3; i <= num4; i++)
					{
						array2[i] = array[i];
						array3[i] = dgv.Columns[array[i]].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array2);
					float[] array4 = new float[columnCount - 1 + 1];
					float num5 = 0f;
					float currentx = this.Currentx;
					int num6 = 0;
					int num7 = columnCount - 1;
					for (int i = num6; i <= num7; i++)
					{
						unchecked
						{
							if (dgv.Columns[array2[i]].Visible)
							{
								DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[i]];
								float num8 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
								num5 += num8;
								array4[i] = num8;
							}
						}
					}
					if (num5 != 0f)
					{
						if (ZoomToPaperWidth)
						{
							float num9 = unchecked(this.PaperPrintWidth - currentx) / num5;
							int num10 = 0;
							int num11 = columnCount - 1;
							for (int i = num10; i <= num11; i++)
							{
								unchecked
								{
									array4[i] *= num9;
								}
							}
							num5 = 0f;
							int num12 = 0;
							int num13 = columnCount - 1;
							for (int i = num12; i <= num13; i++)
							{
								unchecked
								{
									num5 += array4[i];
								}
							}
						}
						if (rowheight <= 0f)
						{
							rowheight = this.ConvFromDisplay((float)dgv.Rows[rowid].Height, false);
						}
						float mycellheight = rowheight;
						object[] array5 = new object[columnCount - 1 + 1];
						int num14 = 0;
						int num15 = columnCount - 1;
						for (int j = num14; j <= num15; j++)
						{
							array5[j] = RuntimeHelpers.GetObjectValue(dgv.Rows[rowid].Cells[j].Tag);
						}
						try
						{
							int num16 = 0;
							int num17 = dgv.ColumnCount - 1;
							for (int k = num16; k <= num17; k++)
							{
								string left = Conversions.ToString(dgv.Rows[rowid].Cells[k].Tag);
								if ((Operators.CompareString(left, "水平合并", false) != 0 & Operators.CompareString(left, "垂直合并", false) != 0 & Operators.CompareString(left, "合并", false) != 0 & Operators.CompareString(left, "不合并", false) != 0 & Operators.CompareString(left, "上合并", false) != 0 & Operators.CompareString(left, "下合并", false) != 0 & Operators.CompareString(left, "左合并", false) != 0 & Operators.CompareString(left, "右合并", false) != 0 & Operators.CompareString(left, "左上合并", false) != 0 & Operators.CompareString(left, "左下合并", false) != 0 & Operators.CompareString(left, "右上合并", false) != 0 & Operators.CompareString(left, "右下合并", false) != 0 & Operators.CompareString(left, "下边合并", false) != 0 & Operators.CompareString(left, "上边合并", false) != 0 & Operators.CompareString(left, "左边合并", false) != 0 & Operators.CompareString(left, "右边合并", false) != 0) && Operators.CompareString(Conversions.ToString(dgv.Rows[rowid].Tag), "合并", false) == 0)
								{
									dgv.Rows[rowid].Cells[k].Tag = "水平合并";
								}
							}
						}
						catch (Exception ex2)
						{
						}
						int num18 = 0;
						int num19 = columnCount - 1;
						int l = num18;
						while (l <= num19)
						{
							DataGridViewColumn dataGridViewColumn = dgv.Columns[array2[l]];
							float mycellwidth = array4[l];
							string left2 = Conversions.ToString(dgv.Rows[rowid].Cells[array2[l]].Tag);
							if (Operators.CompareString(left2, "水平合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "右合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "右上合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "右下合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "上边合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "下边合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "左边合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "右边合并", false) == 0)
							{
								goto IL_4EF;
							}
							if (Operators.CompareString(left2, "#*已水平合并*#", false) != 0)
							{
								goto IL_501;
							}
						IL_52D:
							l++;
							continue;
						IL_501:
							this.MyDrawDGVCell(dgv.Rows[rowid].Cells[array2[l]], mycellwidth, mycellheight, myborder, PrintBackColor, (float)minfontsize);
							goto IL_52D;
						IL_4EF:
							int num20;
							mycellwidth = VB2008Print.GetHMergeWidth(dgv, columnCount, l, rowid, array2, array4, ref num20, true);
							goto IL_501;
						}
						this.Currentx = currentx;
						int num21;
						unchecked
						{
							this.Currenty += rowheight;
							array2 = null;
							num21 = 0;
						}
						int num22 = columnCount - 1;
						for (int m = num21; m <= num22; m++)
						{
							dgv.Rows[rowid].Cells[m].Tag = RuntimeHelpers.GetObjectValue(array5[m]);
						}
						array5 = null;
					}
				}
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000A61AC File Offset: 0x000A43AC
		public void PrintFooter(string myleft, string mymiddle, string myright, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				Font font = (Font)this.tempfont.Clone();
				this.PrintFooter(myleft, mymiddle, myright, font, textoutstyle);
				try
				{
					font.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000073EF File Offset: 0x000055EF
		public void PrintFooter(string myleft, string mymiddle, string myright, Font myf, int textoutstyle = 0)
		{
			this.PrintFooter(myleft, mymiddle, myright, myf, this.TextColor, textoutstyle);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000A6208 File Offset: 0x000A4408
		public void PrintFooter(string myleft, string mymiddle, string myright, Font myf, Color mycolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.r_font = null;
				this.Currentx = 0f;
				this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
				this.mycurrenty += 10f;
				StringAlignment myHalg = StringAlignment.Near;
				string s = "";
				if (VB2008Print.CanSpanPrint(myleft, mymiddle, myright, ref s, ref myHalg))
				{
					this.DrawString(s, this.PaperPrintWidth, (float)this.PaperMargins.Bottom, myf, mycolor, "", myHalg, StringAlignment.Near, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
				}
				else
				{
					this.DrawString(myleft, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Bottom, myf, mycolor, "", StringAlignment.Near, StringAlignment.Near, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = this.PaperPrintWidth / 3f;
					this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
					this.mycurrenty += 10f;
					this.DrawString(mymiddle, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Bottom, myf, mycolor, "", StringAlignment.Center, StringAlignment.Near, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = this.PaperPrintWidth / 3f * 2f;
					this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
					this.mycurrenty += 10f;
					this.DrawString(myright, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Bottom, myf, mycolor, "", StringAlignment.Far, StringAlignment.Near, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
				}
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000A641C File Offset: 0x000A461C
		public void PrintFooter(Image myleft, Image mymiddle, Image myright)
		{
			if (!this.CancelDocument)
			{
				float num = this.PaperPrintWidth / 3f;
				this.Currentx = 0f;
				this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
				this.mycurrenty += 15f;
				float num2;
				if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
				{
					num2 = 15f;
				}
				else
				{
					num2 = 38.1f;
				}
				this.DrawImage(myleft, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Bottom - 2f * num2, false, StringAlignment.Near, StringAlignment.Near);
				this.Currentx = num;
				this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
				this.mycurrenty += 10f;
				this.DrawImage(mymiddle, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Bottom - 2f * num2, false, StringAlignment.Center, StringAlignment.Near);
				this.Currentx = num * 2f;
				this.Currenty = this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
				this.mycurrenty += 10f;
				this.DrawImage(myright, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Bottom - 2f * num2, false, StringAlignment.Far, StringAlignment.Near);
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000A65A0 File Offset: 0x000A47A0
		public void PrintHeader(string myleft, string mymiddle, string myright, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				Font font = (Font)this.tempfont.Clone();
				this.PrintHeader(myleft, mymiddle, myright, font, textoutstyle);
				try
				{
					font.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00007404 File Offset: 0x00005604
		public void PrintHeader(string myleft, string mymiddle, string myright, Font myf, int textoutstyle = 0)
		{
			this.PrintHeader(myleft, mymiddle, myright, myf, this.TextColor, textoutstyle);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000A65FC File Offset: 0x000A47FC
		public void PrintHeader(string myleft, string mymiddle, string myright, Font myf, Color mycolor, int textoutstyle = 0)
		{
			checked
			{
				if (!this.CancelDocument)
				{
					this.r_font = null;
					this.Currentx = 0f;
					this.Currenty = (float)(0 - this.PaperMargins.Top);
					StringAlignment myHalg = StringAlignment.Near;
					string text = "";
					if (VB2008Print.CanSpanPrint(myleft, mymiddle, myright, ref text, ref myHalg))
					{
						this.DrawString(text, this.PaperPrintWidth, (float)this.PaperMargins.Top, myf, mycolor, "", myHalg, StringAlignment.Center, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
						try
						{
							float num = this.MeasureText(text, myf, this.PaperPrintWidth).Height;
							if (num > (float)this.PaperMargins.Top)
							{
								num = (float)this.PaperMargins.Top;
							}
							if (this.myheaderlineposition == 0f)
							{
								this.myheaderlineposition = num;
							}
							else if (num > this.myheaderlineposition)
							{
								this.myheaderlineposition = num;
							}
							return;
						}
						catch (Exception ex)
						{
							return;
						}
					}
					this.DrawString(myleft, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Top, myf, mycolor, "", StringAlignment.Near, StringAlignment.Center, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = this.PaperPrintWidth / 3f;
					this.Currenty = (float)(0 - this.PaperMargins.Top);
					this.DrawString(mymiddle, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Top, myf, mycolor, "", StringAlignment.Center, StringAlignment.Center, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = unchecked(this.PaperPrintWidth / 3f * 2f);
					this.Currenty = (float)(0 - this.PaperMargins.Top);
					this.DrawString(myright, this.PaperPrintWidth / 3f, (float)this.PaperMargins.Top, myf, mycolor, "", StringAlignment.Far, StringAlignment.Center, true, true, false, false, 0f, false, Color.White, Color.Black, textoutstyle);
					try
					{
						if (!(Operators.CompareString(myleft, "", false) == 0 & Operators.CompareString(mymiddle, "", false) == 0 & Operators.CompareString(myright, "", false) == 0))
						{
							float num2 = this.MeasureText(myleft, myf, this.PaperPrintWidth / 3f).Height;
							if (num2 > (float)this.PaperMargins.Top)
							{
								num2 = (float)this.PaperMargins.Top;
							}
							float num3 = this.MeasureText(mymiddle, myf, this.PaperPrintWidth / 3f).Height;
							if (num3 > (float)this.PaperMargins.Top)
							{
								num3 = (float)this.PaperMargins.Top;
							}
							if (num2 < num3)
							{
								num2 = num3;
							}
							num3 = this.MeasureText(myright, myf, this.PaperPrintWidth / 3f).Height;
							if (num3 > (float)this.PaperMargins.Top)
							{
								num3 = (float)this.PaperMargins.Top;
							}
							if (num2 < num3)
							{
								num2 = num3;
							}
							if (this.myheaderlineposition == 0f)
							{
								this.myheaderlineposition = num2;
							}
							else if (num2 > this.myheaderlineposition)
							{
								this.myheaderlineposition = num2;
							}
						}
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000A6990 File Offset: 0x000A4B90
		public void PrintHeader(Image myleft, Image mymiddle, Image myright)
		{
			if (!this.CancelDocument)
			{
				float num = this.PaperPrintWidth / 3f;
				float num2;
				if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
				{
					num2 = 18f;
				}
				else
				{
					num2 = 45.72f;
				}
				this.Currentx = 0f;
				this.Currenty = (float)(checked(0 - this.PaperMargins.Top)) + num2;
				this.DrawImage(myleft, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Top - num2 * 2f, false, StringAlignment.Near, StringAlignment.Center);
				this.Currentx = num;
				this.Currenty = (float)(checked(0 - this.PaperMargins.Top)) + num2;
				this.DrawImage(mymiddle, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Top - num2 * 2f, false, StringAlignment.Center, StringAlignment.Center);
				this.Currentx = num * 2f;
				this.Currenty = (float)(checked(0 - this.PaperMargins.Top)) + num2;
				this.DrawImage(myright, this.Currentx, this.Currenty, num, (float)this.PaperMargins.Top - num2 * 2f, false, StringAlignment.Far, StringAlignment.Center);
				try
				{
					float num3 = 0f;
					float num4 = (float)this.PaperMargins.Top - num2 * 2f;
					if (myleft != null)
					{
						num3 = this.ConvFromDisplay((float)myleft.Height, false);
						if (num3 > num4)
						{
							num3 = num4;
						}
					}
					if (mymiddle != null)
					{
						float num5 = this.ConvFromDisplay((float)mymiddle.Height, false);
						if (num5 > num4)
						{
							num5 = num4;
						}
						if (num3 < num5)
						{
							num3 = num5;
						}
					}
					if (myright != null)
					{
						float num5 = this.ConvFromDisplay((float)myright.Height, false);
						if (num5 > num4)
						{
							num5 = num4;
						}
						if (num3 < num5)
						{
							num3 = num5;
						}
					}
					if (this.myheaderlineposition == 0f)
					{
						this.myheaderlineposition = num3;
					}
					else if (num3 > this.myheaderlineposition)
					{
						this.myheaderlineposition = num3;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000A6B70 File Offset: 0x000A4D70
		public void PrintLeft(string mytop, string mymiddle, string mybottom, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				Font font = (Font)this.tempfont.Clone();
				this.PrintLeft(mytop, mymiddle, mybottom, font, textoutstyle);
				try
				{
					font.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00007419 File Offset: 0x00005619
		public void PrintLeft(string mytop, string mymiddle, string mybottom, Font myf, int textoutstyle = 0)
		{
			this.PrintLeft(mytop, mymiddle, mybottom, myf, this.TextColor, textoutstyle);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000A6BCC File Offset: 0x000A4DCC
		public void PrintLeft(string mytop, string mymiddle, string mybottom, Font myf, Color mycolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.r_font = null;
				this.GetPageAndPaperSettings(this.currentpage);
				checked
				{
					this.Currentx = (float)(0 - this.PaperMargins.Left);
					this.Currenty = 0f;
					this.DrawString(mytop, (float)this.PaperMargins.Left, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Near, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = (float)(0 - this.PaperMargins.Left);
					this.Currenty = this.PaperPrintHeight / 3f;
					this.DrawString(mymiddle, (float)this.PaperMargins.Left, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Center, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
					this.Currentx = (float)(0 - this.PaperMargins.Left);
				}
				this.Currenty = this.PaperPrintHeight / 3f * 2f;
				this.DrawString(mybottom, (float)this.PaperMargins.Left, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Far, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000A6D28 File Offset: 0x000A4F28
		public void PrintLeft(Image mytop, Image mymiddle, Image mybottom)
		{
			if (!this.CancelDocument)
			{
				this.GetPageAndPaperSettings(this.currentpage);
				float num = this.PaperPrintHeight / 3f;
				float num2;
				if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
				{
					num2 = 10f;
				}
				else
				{
					num2 = 25.4f;
				}
				this.Currenty = 0f;
				this.Currentx = (float)(checked(0 - this.PaperMargins.Left)) + num2;
				this.DrawImage(mytop, this.Currentx, this.Currenty, (float)this.PaperMargins.Left - num2 * 2f, num, false, StringAlignment.Center, StringAlignment.Near);
				this.Currenty = num;
				this.Currentx = (float)(checked(0 - this.PaperMargins.Left)) + num2;
				this.DrawImage(mymiddle, this.Currentx, this.Currenty, (float)this.PaperMargins.Left - num2 * 2f, num, false, StringAlignment.Center, StringAlignment.Center);
				this.Currenty = num * 2f;
				this.Currentx = (float)(checked(0 - this.PaperMargins.Left)) + num2;
				this.DrawImage(mybottom, this.Currentx, this.Currenty, (float)this.PaperMargins.Left - num2 * 2f, num, false, StringAlignment.Center, StringAlignment.Far);
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000A6E54 File Offset: 0x000A5054
		public void PrintRight(string mytop, string mymiddle, string mybottom, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				Font font = (Font)this.tempfont.Clone();
				this.PrintRight(mytop, mymiddle, mybottom, font, textoutstyle);
				try
				{
					font.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000742E File Offset: 0x0000562E
		public void PrintRight(string mytop, string mymiddle, string mybottom, Font myf, int textoutstyle = 0)
		{
			this.PrintRight(mytop, mymiddle, mybottom, myf, this.TextColor, textoutstyle);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000A6EB0 File Offset: 0x000A50B0
		public void PrintRight(string mytop, string mymiddle, string mybottom, Font myf, Color mycolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.r_font = null;
				this.GetPageAndPaperSettings(this.currentpage);
				this.Currenty = 0f;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.DrawString(mytop, (float)this.PaperMargins.Right, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Near, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
				this.Currenty = this.PaperPrintHeight / 3f;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.DrawString(mymiddle, (float)this.PaperMargins.Right, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Center, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
				this.Currenty = this.PaperPrintHeight / 3f * 2f;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.DrawString(mybottom, (float)this.PaperMargins.Right, this.PaperPrintHeight / 3f, myf, mycolor, "", StringAlignment.Far, StringAlignment.Center, true, true, false, true, 0f, false, Color.White, Color.Black, textoutstyle);
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000A7044 File Offset: 0x000A5244
		public void PrintRight(Image mytop, Image mymiddle, Image mybottom)
		{
			if (!this.CancelDocument)
			{
				this.GetPageAndPaperSettings(this.currentpage);
				float num = this.PaperPrintHeight / 3f;
				this.Currenty = 0f;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.mycurrentx += 10f;
				float num2;
				if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
				{
					num2 = 10f;
				}
				else
				{
					num2 = 25.4f;
				}
				this.DrawImage(mytop, this.Currentx, this.Currenty, (float)this.PaperMargins.Right - 2f * num2, num, false, StringAlignment.Center, StringAlignment.Near);
				this.Currenty = num;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.mycurrentx += 10f;
				this.DrawImage(mymiddle, this.Currentx, this.Currenty, (float)this.PaperMargins.Right - 2f * num2, num, false, StringAlignment.Center, StringAlignment.Center);
				this.Currenty = num * 2f;
				this.Currentx = this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
				this.mycurrentx += 10f;
				this.DrawImage(mybottom, this.Currentx, this.Currenty, (float)this.PaperMargins.Right - 2f * num2, num, false, StringAlignment.Center, StringAlignment.Far);
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000A71D4 File Offset: 0x000A53D4
		public void DrawLine(float x1, float y1, float x2, float y2, Color mycolor, float mywidth)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("l", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(x2)), Conversions.ToString(this.MyConvTo(y2)), colorConverter.ConvertToString(mycolor), Conversions.ToString(this.MyConvTo(mywidth)));
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00007443 File Offset: 0x00005643
		public void DrawLine(float x1, float y1, float x2, float y2)
		{
			this.DrawLine(x1, y1, x2, y2, Color.Black, 1f);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000A7248 File Offset: 0x000A5448
		private void MyDrawline(float x1, float y1, float x2, float y2, Color mycolor, float mywidth)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawLine(new Pen(mycolor, mywidth), x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top, x2 + (float)this.mypagesetting.Margins.Left, y2 + (float)this.mypagesetting.Margins.Top);
			this.myg.Transform = transform;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000A72DC File Offset: 0x000A54DC
		public void DrawLine(Pen mypen, float x1, float y1, float x2, float y2)
		{
			PointF pointF = new PointF(x1, y1);
			PointF point = pointF;
			PointF point2 = new PointF(x2, y2);
			this.DrawLine(mypen, point, point2);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000A7308 File Offset: 0x000A5508
		public void DrawLine(Pen mypen, PointF point1, PointF point2)
		{
			if (!this.CancelDocument && mypen != null)
			{
				PointF[] array = new PointF[2];
				array[0] = new PointF(point1.X, point1.Y);
				array[1] = new PointF(point2.X, point2.Y);
				this.MyWrite("lines", this.SavePenAsString(mypen), this.ConvertPointsToString(array));
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0000745A File Offset: 0x0000565A
		public void DrawLines(Pen mypen, PointF[] points)
		{
			if (!this.CancelDocument && points != null && mypen != null)
			{
				this.MyWrite("lines", this.SavePenAsString(mypen), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000A7374 File Offset: 0x000A5574
		private void MyDrawLines(string penstring, string pointstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawLines(pen, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000A73EC File Offset: 0x000A55EC
		public void DrawDashLine(float x1, float y1, float x2, float y2, Color mycolor, float mywidth, DashStyle dashstyle)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("dl", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(x2)), Conversions.ToString(this.MyConvTo(y2)), colorConverter.ConvertToString(mycolor), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString((int)dashstyle), "");
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00007483 File Offset: 0x00005683
		public void DrawDashLine(float x1, float y1, float x2, float y2, DashStyle dashstyle)
		{
			this.DrawDashLine(x1, y1, x2, y2, Color.Black, 1f, dashstyle);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000A746C File Offset: 0x000A566C
		private void MyDrawDashline(float x1, float y1, float x2, float y2, Color mycolor, float mywidth, DashStyle dashstyle)
		{
			Pen pen = new Pen(mycolor, mywidth);
			try
			{
				pen.DashStyle = dashstyle;
			}
			catch (Exception ex)
			{
			}
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawLine(pen, x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top, x2 + (float)this.mypagesetting.Margins.Left, y2 + (float)this.mypagesetting.Margins.Top);
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x000A7530 File Offset: 0x000A5730
		public void DrawPie(Pen mypen, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawPie(mypen, myrect, startAngle, sweepAngle);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0000749C File Offset: 0x0000569C
		public void DrawPie(Pen mypen, RectangleF myrect, float startAngle, float sweepAngle)
		{
			if (!this.CancelDocument && mypen != null)
			{
				this.MyWrite("pie", this.SavePenAsString(mypen), this.ConvertRectToString(myrect), Conversions.ToString(startAngle), Conversions.ToString(sweepAngle));
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000A7558 File Offset: 0x000A5758
		private void MyDrawPie(string penstring, string rectstring, string startangle, string sweepangle)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			RectangleF rect = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawPie(pen, rect, Conversions.ToSingle(startangle), Conversions.ToSingle(sweepangle));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000A75DC File Offset: 0x000A57DC
		public void DrawFillPie(Brush mybrush, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawFillPie(mybrush, myrect, startAngle, sweepAngle);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000074CF File Offset: 0x000056CF
		public void DrawFillPie(Brush mybrush, RectangleF myrect, float startAngle, float sweepAngle)
		{
			if (!this.CancelDocument && mybrush != null)
			{
				this.MyWrite("fpie", this.SaveBrush(mybrush), this.ConvertRectToString(myrect), Conversions.ToString(startAngle), Conversions.ToString(sweepAngle));
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000A7604 File Offset: 0x000A5804
		private void MyDrawFillPie(string brushstring, string rectstring, string startangle, string sweepangle)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			RectangleF rectangleF = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillPie(brush, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height, Conversions.ToSingle(startangle), Conversions.ToSingle(sweepangle));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00007502 File Offset: 0x00005702
		public void DrawPolygon(Pen mypen, PointF[] points)
		{
			if (!this.CancelDocument && points != null && mypen != null)
			{
				this.MyWrite("polygon", this.SavePenAsString(mypen), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000A76A4 File Offset: 0x000A58A4
		private void MyDrawPolygon(string penstring, string pointstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawPolygon(pen, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000752B File Offset: 0x0000572B
		public void DrawFillPolygon(Brush mybrush, PointF[] points, FillMode fillMode)
		{
			if (!this.CancelDocument && mybrush != null && points != null && points.Length > 0)
			{
				this.MyWrite("fpolygon", this.SaveBrush(mybrush), this.ConvertPointsToString(points), Conversions.ToString((int)fillMode));
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00007560 File Offset: 0x00005760
		public void DrawFillPolygon(Brush mybrush, PointF[] points)
		{
			if (!this.CancelDocument && mybrush != null && points != null && points.Length > 0)
			{
				this.MyWrite("fpolygon", this.SaveBrush(mybrush), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000A771C File Offset: 0x000A591C
		private void MyDrawFillPolygon(string brushstring, string pointstring, string fillMode)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillPolygon(brush, points, (FillMode)Conversions.ToInteger(fillMode));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000A779C File Offset: 0x000A599C
		private void MyDrawFillPolygon(string brushstring, string pointstring)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillPolygon(brush, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000A7814 File Offset: 0x000A5A14
		public void DrawRect(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("r", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), colorConverter.ConvertToString(mycolor), Conversions.ToString(this.MyConvTo(linewidth)));
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000A7888 File Offset: 0x000A5A88
		public void DrawRectangle(Pen mypen, float x, float y, float width, float height)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawRectangle(mypen, myrect);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0000758F File Offset: 0x0000578F
		public void DrawRectangle(Pen mypen, RectangleF myrect)
		{
			if (!this.CancelDocument && mypen != null)
			{
				this.MyWrite("rect", this.SavePenAsString(mypen), this.ConvertRectToString(myrect));
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000A78AC File Offset: 0x000A5AAC
		private void MyDrawRect(string penstring, string rectstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			RectangleF rectangleF = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000A793C File Offset: 0x000A5B3C
		private void MyDrawRect(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawRectangle(new Pen(mycolor, linewidth), x1 + (float)this.mypagesetting.Margins.Left, (float)this.mypagesetting.Margins.Top + y1, mywidth, myheight);
			this.myg.Transform = transform;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000075B5 File Offset: 0x000057B5
		public void DrawRectangles(Pen mypen, RectangleF[] myrect)
		{
			if (!this.CancelDocument && myrect != null && myrect.Length > 0 && mypen != null)
			{
				this.MyWrite("rects", this.SavePenAsString(mypen), this.ConvertRectSToString(myrect));
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000A79AC File Offset: 0x000A5BAC
		private void MyDrawRectangles(string penstring, string rectstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			RectangleF[] rects = this.ConvertStringToRectS(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawRectangles(pen, rects);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000075E4 File Offset: 0x000057E4
		public void DrawFillRectangles(Brush mybrush, RectangleF[] myrect)
		{
			if (!this.CancelDocument && mybrush != null)
			{
				this.MyWrite("frects", this.SaveBrush(mybrush), this.ConvertRectSToString(myrect));
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000A7A24 File Offset: 0x000A5C24
		private void MyDrawFillRectangles(string brushstring, string rectstring)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			RectangleF[] rects = this.ConvertStringToRectS(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillRectangles(brush, rects);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000A7A9C File Offset: 0x000A5C9C
		public void DrawFillRectangle(Brush mybrush, float x, float y, float width, float height)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawFillRectangle(mybrush, myrect);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0000760A File Offset: 0x0000580A
		public void DrawFillRectangle(Brush mybrush, RectangleF myrect)
		{
			if (!this.CancelDocument && mybrush != null)
			{
				this.MyWrite("frect", this.SaveBrush(mybrush), this.ConvertRectToString(myrect));
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
		private void MyDrawFillRect(string brushstring, string rectstring)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			RectangleF rect = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillRectangle(brush, rect);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00007630 File Offset: 0x00005830
		public void DrawFillRect(RectangleF myrect, Color mycolor)
		{
			this.DrawFillRect(myrect.X, myrect.Y, myrect.Width, myrect.Height, mycolor);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000A7B38 File Offset: 0x000A5D38
		public void DrawFillRect(float x1, float y1, float mywidth, float myheight, Color mycolor)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("rf", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), colorConverter.ConvertToString(mycolor));
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000A7BA0 File Offset: 0x000A5DA0
		private void MyDrawFillRect(float x1, float y1, float mywidth, float myheight, Color mycolor)
		{
			SolidBrush solidBrush = new SolidBrush(mycolor);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.FillRectangle(solidBrush, x1 + (float)this.mypagesetting.Margins.Left, (float)this.mypagesetting.Margins.Top + y1, mywidth, myheight);
			this.myg.Transform = transform;
			solidBrush.Dispose();
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000A7C18 File Offset: 0x000A5E18
		public void DrawArc(Pen mypen, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawArc(myrect, mypen, startAngle, sweepAngle);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000A7C40 File Offset: 0x000A5E40
		public void DrawArc(RectangleF myrect, Pen mypen, float startangle = 0f, float sweepAngle = 360f)
		{
			if (!this.CancelDocument && mypen != null)
			{
				this.MyWrite("arc2", Conversions.ToString(this.MyConvTo(myrect.X)), Conversions.ToString(this.MyConvTo(myrect.Y)), Conversions.ToString(this.MyConvTo(myrect.Width)), Conversions.ToString(this.MyConvTo(myrect.Height)), this.SavePenAsString(mypen), Conversions.ToString(startangle), Conversions.ToString(sweepAngle));
			}
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		public void DrawArc(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth, float startangle = 0f, float sweepAngle = 360f)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("arc", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), colorConverter.ConvertToString(mycolor), Conversions.ToString(this.MyConvTo(linewidth)), Conversions.ToString(startangle), Conversions.ToString(sweepAngle));
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x000A7D44 File Offset: 0x000A5F44
		private void MyDrawArc2(float x1, float y1, float mywidth, float myheight, string penstring, float startangle, float sweepAngle)
		{
			if (!this.CancelDocument)
			{
				Pen pen = VB2008Print.RestorePenFromString(penstring);
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				this.myg.DrawArc(pen, x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top, mywidth, myheight, startangle, sweepAngle);
				this.myg.Transform = transform;
				pen.Dispose();
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000A7DC8 File Offset: 0x000A5FC8
		private void MyDrawArc(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth, float startangle, float sweepAngle)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawArc(new Pen(mycolor, linewidth), x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top, mywidth, myheight, startangle, sweepAngle);
			this.myg.Transform = transform;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000A7E3C File Offset: 0x000A603C
		public void DrawBezier(Pen mypen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			PointF pointF = new PointF(x1, y1);
			PointF mypoint = pointF;
			PointF pointF2 = new PointF(x2, y2);
			PointF mypoint2 = pointF2;
			PointF pointF3 = new PointF(x3, y3);
			PointF mypoint3 = pointF3;
			PointF mypoint4 = new PointF(x4, y4);
			this.DrawBezier(mypen, mypoint, mypoint2, mypoint3, mypoint4);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000A7E80 File Offset: 0x000A6080
		public void DrawBezier(Pen mypen, PointF mypoint1, PointF mypoint2, PointF mypoint3, PointF mypoint4)
		{
			if (!this.CancelDocument && mypen != null)
			{
				this.MyWrite("bezier", this.SavePenAsString(mypen), Conversions.ToString(this.MyConvTo(mypoint1.X)), Conversions.ToString(this.MyConvTo(mypoint1.Y)), Conversions.ToString(this.MyConvTo(mypoint2.X)), Conversions.ToString(this.MyConvTo(mypoint2.Y)), Conversions.ToString(this.MyConvTo(mypoint3.X)), Conversions.ToString(this.MyConvTo(mypoint3.Y)), Conversions.ToString(this.MyConvTo(mypoint4.X)), Conversions.ToString(this.MyConvTo(mypoint4.Y)));
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000A7F40 File Offset: 0x000A6140
		private void MyDrawBezier(string penstring, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				Graphics graphics = this.myg;
				Pen pen2 = pen;
				PointF pointF = new PointF(x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top);
				PointF pt = pointF;
				PointF pointF2 = new PointF(x2 + (float)this.mypagesetting.Margins.Left, y2 + (float)this.mypagesetting.Margins.Top);
				PointF pt2 = pointF2;
				PointF pointF3 = new PointF(x3 + (float)this.mypagesetting.Margins.Left, y3 + (float)this.mypagesetting.Margins.Top);
				PointF pt3 = pointF3;
				PointF pt4 = new PointF(x4 + (float)this.mypagesetting.Margins.Left, y4 + (float)this.mypagesetting.Margins.Top);
				graphics.DrawBezier(pen2, pt, pt2, pt3, pt4);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00007655 File Offset: 0x00005855
		public void DrawBeziers(Pen mypen, PointF[] points)
		{
			if (mypen != null && !this.CancelDocument && points != null)
			{
				this.MyWrite("beziers", this.SavePenAsString(mypen), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000A8070 File Offset: 0x000A6270
		private void MyDrawBeziers(string penstring, string pointstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawBeziers(pen, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000A80E8 File Offset: 0x000A62E8
		

		// Token: 0x060014BF RID: 5311 RVA: 0x0000767E File Offset: 0x0000587E
		public void DrawCurve(Pen mypen, PointF[] points)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				this.MyWrite("curve", this.SavePenAsString(mypen), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000076A7 File Offset: 0x000058A7
		public void DrawCurve(Pen mypen, PointF[] points, float tension)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				this.MyWrite("curve", this.SavePenAsString(mypen), this.ConvertPointsToString(points), Conversions.ToString(tension));
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000076D6 File Offset: 0x000058D6
		public void DrawCurve(Pen mypen, PointF[] points, int offset, int numberOfSegments)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				this.MyWrite("curve", this.SavePenAsString(mypen), this.ConvertPointsToString(points), Conversions.ToString(offset), Conversions.ToString(numberOfSegments));
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0000770C File Offset: 0x0000590C
		public void DrawCurve(Pen mypen, PointF[] points, int offset, int numberOfSegments, float tension)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				this.MyWrite("curve", this.SavePenAsString(mypen), this.ConvertPointsToString(points), Conversions.ToString(offset), Conversions.ToString(numberOfSegments), Conversions.ToString(tension));
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x000A856C File Offset: 0x000A676C
		private void MyDrawCurve(string penstring, string pointstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawCurve(pen, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x000A85E4 File Offset: 0x000A67E4
		private void MyDrawCurve(string penstring, string pointstring, string tension)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawCurve(pen, points, Conversions.ToSingle(tension));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x000A8664 File Offset: 0x000A6864
		private void MyDrawCurve(string penstring, string pointstring, string offset, string numberOfSegments)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawCurve(pen, points, Conversions.ToInteger(offset), Conversions.ToInteger(numberOfSegments));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000A86E8 File Offset: 0x000A68E8
		private void MyDrawCurve(string penstring, string pointstring, string offset, string numberOfSegments, string tension)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawCurve(pen, points, Conversions.ToInteger(offset), Conversions.ToInteger(numberOfSegments), Conversions.ToSingle(tension));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000A8774 File Offset: 0x000A6974
		public void DrawClosedCurve(Pen mypen, PointF[] points, float tension, FillMode fillmode)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				if (tension < 0f)
				{
					tension = 0f;
				}
				this.MyWrite("closedcurve", this.SavePenAsString(mypen), this.ConvertPointsToString(points), Conversions.ToString(tension), Conversions.ToString((int)fillmode));
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00007749 File Offset: 0x00005949
		public void DrawClosedCurve(Pen mypen, PointF[] points)
		{
			if (!this.CancelDocument && mypen != null && points != null)
			{
				this.MyWrite("closedcurve", this.SavePenAsString(mypen), this.ConvertPointsToString(points));
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000A87C4 File Offset: 0x000A69C4
		private void MyDrawClosedCurve(string penstring, string pointstring, string tension, string fillmode)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawClosedCurve(pen, points, Conversions.ToSingle(tension), (FillMode)Conversions.ToInteger(fillmode));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000A8848 File Offset: 0x000A6A48
		private void MyDrawClosedCurve(string penstring, string pointstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawClosedCurve(pen, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00007772 File Offset: 0x00005972
		public void DrawFillClosedCurve(Brush mybrush, PointF[] mypoints, FillMode myfillmode, float tension)
		{
			if (!this.CancelDocument && mybrush != null && mypoints != null)
			{
				this.MyWrite("fclosedcurve", this.SaveBrush(mybrush), this.ConvertPointsToString(mypoints), Conversions.ToString((int)myfillmode), Conversions.ToString(tension));
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000077A8 File Offset: 0x000059A8
		public void DrawFillClosedCurve(Brush mybrush, PointF[] mypoints, FillMode myfillmode)
		{
			if (!this.CancelDocument && mybrush != null && mypoints != null)
			{
				this.MyWrite("fclosedcurve", this.SaveBrush(mybrush), this.ConvertPointsToString(mypoints), Conversions.ToString((int)myfillmode));
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000077D7 File Offset: 0x000059D7
		public void DrawFillClosedCurve(Brush mybrush, PointF[] mypoints)
		{
			if (!this.CancelDocument && mybrush != null && mypoints != null)
			{
				this.MyWrite("fclosedcurve", this.SaveBrush(mybrush), this.ConvertPointsToString(mypoints));
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000A88C0 File Offset: 0x000A6AC0
		private void MyDrawFillClosedCurve(string brushstring, string pointstring, string fillmode, string tension)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillClosedCurve(brush, points, (FillMode)Conversions.ToInteger(fillmode), Conversions.ToSingle(tension));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000A8944 File Offset: 0x000A6B44
		private void MyDrawFillClosedCurve(string brushstring, string pointstring, string fillmode)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillClosedCurve(brush, points, (FillMode)Conversions.ToInteger(fillmode));
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000A89C4 File Offset: 0x000A6BC4
		private void MyDrawFillClosedCurve(string brushstring, string pointstring)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			PointF[] points = this.ConvertStringToPoints(pointstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillClosedCurve(brush, points);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000A8A3C File Offset: 0x000A6C3C
		public void DrawEllipse(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("de", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), colorConverter.ConvertToString(mycolor), Conversions.ToString(this.MyConvTo(linewidth)));
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000A8AB0 File Offset: 0x000A6CB0
		public void DrawEllipse(Pen mypen, float x, float y, float width, float height)
		{
			RectangleF rect = new RectangleF(x, y, width, height);
			this.DrawEllipse(mypen, rect);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00007800 File Offset: 0x00005A00
		public void DrawEllipse(Pen mypen, RectangleF rect)
		{
			if (!this.CancelDocument && mypen != null)
			{
				this.MyWrite("ellipse", this.SavePenAsString(mypen), this.ConvertRectToString(rect));
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000A8AD4 File Offset: 0x000A6CD4
		private void MyDrawEllipse(string penstring, string rectstring)
		{
			Pen pen = VB2008Print.RestorePenFromString(penstring);
			RectangleF rect = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawEllipse(pen, rect);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			pen.Dispose();
			pen = null;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000A8B4C File Offset: 0x000A6D4C
		private void MyDrawEllipse(float x1, float y1, float mywidth, float myheight, Color mycolor, float linewidth)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.DrawEllipse(new Pen(mycolor, linewidth), x1 + (float)this.mypagesetting.Margins.Left, y1 + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
			this.myg.Transform = transform;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000A8BBC File Offset: 0x000A6DBC
		public void DrawFillEllipse(float x1, float y1, float mywidth, float myheight, Color mycolor)
		{
			if (!this.CancelDocument)
			{
				ColorConverter colorConverter = new ColorConverter();
				this.MyWrite("dfe", Conversions.ToString(this.MyConvTo(x1)), Conversions.ToString(this.MyConvTo(y1)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), colorConverter.ConvertToString(mycolor));
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000A8C24 File Offset: 0x000A6E24
		private void MyDrawFillEllipse(float x1, float y1, float mywidth, float myheight, Color mycolor)
		{
			SolidBrush solidBrush = new SolidBrush(mycolor);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.FillEllipse(solidBrush, x1 + (float)this.mypagesetting.Margins.Left, (float)this.mypagesetting.Margins.Top + y1, mywidth, myheight);
			this.myg.Transform = transform;
			solidBrush.Dispose();
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000A8C9C File Offset: 0x000A6E9C
		public void DrawFillEllipse(Brush mybrush, float x, float y, float width, float height)
		{
			RectangleF myrect = new RectangleF(x, y, width, height);
			this.DrawFillEllipse(mybrush, myrect);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00007826 File Offset: 0x00005A26
		public void DrawFillEllipse(Brush mybrush, RectangleF myrect)
		{
			if (!this.CancelDocument && mybrush != null)
			{
				this.MyWrite("fellipse", this.SaveBrush(mybrush), this.ConvertRectToString(myrect));
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
		private void MyDrawFillEllipse(string brushstring, string rectstring)
		{
			Brush brush = VB2008Print.RestoreBrush(brushstring);
			RectangleF rect = this.ConvertStringToRect(rectstring);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillEllipse(brush, rect);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			rect = default(RectangleF);
			brush.Dispose();
			brush = null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000A8D40 File Offset: 0x000A6F40
		public void DrawFiveStar(PointF center, float radius, Pen mypen)
		{
			PointF[] array = new PointF[10];
			array[0] = new PointF(center.X, center.Y - radius);
			array[1] = VB2008Print.RotateTheta(array[0], center, 36.0);
			double num = (double)radius * Math.Sin(0.3141592653589793) / Math.Sin(2.199114857512855);
			array[1].X = (float)((double)center.X + num * (double)(array[1].X - center.X) / (double)radius);
			array[1].Y = (float)((double)center.Y + num * (double)(array[1].Y - center.Y) / (double)radius);
			int num2 = 1;
			checked
			{
				do
				{
					array[2 * num2] = VB2008Print.RotateTheta(array[2 * (num2 - 1)], center, 72.0);
					array[2 * num2 + 1] = VB2008Print.RotateTheta(array[2 * num2 - 1], center, 72.0);
					num2++;
				}
				while (num2 <= 4);
				this.DrawPolygon(mypen, array);
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000A8E8C File Offset: 0x000A708C
		public void DrawFillFiveStar(PointF center, float radius, Brush mybrush)
		{
			PointF[] array = new PointF[10];
			array[0] = new PointF(center.X, center.Y - radius);
			array[1] = VB2008Print.RotateTheta(array[0], center, 36.0);
			double num = (double)radius * Math.Sin(0.3141592653589793) / Math.Sin(2.199114857512855);
			array[1].X = (float)((double)center.X + num * (double)(array[1].X - center.X) / (double)radius);
			array[1].Y = (float)((double)center.Y + num * (double)(array[1].Y - center.Y) / (double)radius);
			int num2 = 1;
			checked
			{
				do
				{
					array[2 * num2] = VB2008Print.RotateTheta(array[2 * (num2 - 1)], center, 72.0);
					array[2 * num2 + 1] = VB2008Print.RotateTheta(array[2 * num2 - 1], center, 72.0);
					num2++;
				}
				while (num2 <= 4);
				this.DrawFillPolygon(mybrush, array);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000A8FD8 File Offset: 0x000A71D8
		private static PointF RotateTheta(PointF pt, PointF center, double theta)
		{
			float x = (float)((double)center.X + (double)(pt.X - center.X) * Math.Cos(theta * 3.141592653589793 / 180.0) - (double)(pt.Y - center.Y) * Math.Sin(theta * 3.141592653589793 / 180.0));
			float y = (float)((double)center.Y + (double)(pt.X - center.X) * Math.Sin(theta * 3.141592653589793 / 180.0) + (double)(pt.Y - center.Y) * Math.Cos(theta * 3.141592653589793 / 180.0));
			PointF result = new PointF(x, y);
			return result;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000A90B8 File Offset: 0x000A72B8
		public SizeF MeasureText(string txt)
		{
			return this.MeasureString(txt, false);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000A90D0 File Offset: 0x000A72D0
		public SizeF MeasureText(string txt, Font myf)
		{
			return this.MeasureString(txt, myf, false);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000A90E8 File Offset: 0x000A72E8
		public SizeF MeasureText(string txt, Font myf, SizeF mysize)
		{
			return this.MeasureString(txt, myf, mysize, false);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x000A9104 File Offset: 0x000A7304
		public SizeF MeasureText(string txt, Font myf, float mywidth)
		{
			return this.MeasureString(txt, myf, mywidth, false);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000A9120 File Offset: 0x000A7320
		public SizeF MeasureText(string txt, Font myf, float mywidth, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, mywidth, myformat, false);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000A913C File Offset: 0x000A733C
		public SizeF MeasureText(string txt, Font myf, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, myformat, false);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000A9158 File Offset: 0x000A7358
		public SizeF MeasureText(string txt, Font myf, SizeF mysize, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, mysize, myformat, false);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000A9174 File Offset: 0x000A7374
		public SizeF MeasureText(string txt, Font myf, SizeF mysize, StringFormat myformat, ref int charactersFitted, ref int linesFilled)
		{
			return this.MeasureString(txt, myf, mysize, myformat, ref charactersFitted, ref linesFilled, false);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x000A9194 File Offset: 0x000A7394
		public SizeF MeasureCell(string txt)
		{
			return this.MeasureString(txt, true);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000A91AC File Offset: 0x000A73AC
		public SizeF MeasureCell(string txt, Font myf)
		{
			return this.MeasureString(txt, myf, true);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000A91C4 File Offset: 0x000A73C4
		public SizeF MeasureCell(string txt, Font myf, SizeF mysize)
		{
			return this.MeasureString(txt, myf, mysize, true);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000A91E0 File Offset: 0x000A73E0
		public SizeF MeasureCell(string txt, Font myf, float mywidth)
		{
			return this.MeasureString(txt, myf, mywidth, true);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000A91FC File Offset: 0x000A73FC
		public SizeF MeasureCell(string txt, Font myf, float mywidth, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, mywidth, myformat, true);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000A9218 File Offset: 0x000A7418
		public SizeF MeasureCell(string txt, Font myf, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, myformat, true);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000A9234 File Offset: 0x000A7434
		public SizeF MeasureCell(string txt, Font myf, SizeF mysize, StringFormat myformat)
		{
			return this.MeasureString(txt, myf, mysize, myformat, true);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000A9250 File Offset: 0x000A7450
		public SizeF MeasureCell(string txt, Font myf, SizeF mysize, StringFormat myformat, ref int charactersFitted, ref int linesFilled)
		{
			return this.MeasureString(txt, myf, mysize, myformat, ref charactersFitted, ref linesFilled, true);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000A9270 File Offset: 0x000A7470
		public void DrawCell(string text, Font myf, Color textforecolor, StringFormat myformat, string myborder, int textoutstyle = 0)
		{
			this.DrawString(text, myf, textforecolor, myformat, myborder, true, Color.White, this.myforecolor, textoutstyle);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000A9298 File Offset: 0x000A7498
		public void DrawCell(string text, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, int textoutstyle = 0)
		{
			this.DrawString(text, myf, textforecolor, myformat, myborder, true, Color.White, linecolor, textoutstyle);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0000784C File Offset: 0x00005A4C
		public void DrawCell(string text, float mywidth, string myborder, Color linecolor, int textoutstyle = 0)
		{
			this.DrawCell(text, mywidth, this.myfont, myborder, linecolor, textoutstyle);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00007861 File Offset: 0x00005A61
		public void DrawCell(string text, float mywidth, Font myf, string myborder, Color linecolor, int textoutstyle = 0)
		{
			this.DrawCell(text, mywidth, myf, this.TextColor, myborder, linecolor, textoutstyle);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00007878 File Offset: 0x00005A78
		public void DrawCell(string text, float mywidth, Color textforecolor, string myborder, Color linecolor, int textoutstyle = 0)
		{
			this.DrawCell(text, mywidth, this.myfont, textforecolor, myborder, linecolor, textoutstyle);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000A92BC File Offset: 0x000A74BC
		public void DrawCell(string text, float mywidth, Font myf, Color textforecolor, string myborder, Color linecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawCell(text, mywidth, myf, textforecolor, stringFormat, myborder, linecolor, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000A9308 File Offset: 0x000A7508
		public void DrawCell(string text, float mywidth, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, int textoutstyle = 0)
		{
			this.DrawString(text, mywidth, myf, textforecolor, myformat, myborder, true, Color.White, linecolor, textoutstyle);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000A9330 File Offset: 0x000A7530
		public void DrawCell(string s, float mywidth, float myheight, Font myf, Color textforecolor, string myborder, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, Color backcolor, Color linecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, textforecolor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, true, backcolor, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000A9394 File Offset: 0x000A7594
		public void DrawCell(string s, float mywidth, float myheight, Font myf, Color textforecolor, string myborder, Color linecolor, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = true, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, textforecolor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, true, Color.White, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000A93FC File Offset: 0x000A75FC
		public void DrawCell(string s, float mywidth, float myheight, Font myf, string myborder, Color linecolor, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = false, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, true, Color.White, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000A9468 File Offset: 0x000A7668
		public void DrawCell(string s, float mywidth, float myheight, string myborder, Color linecolor, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = false, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, this.myfont, myborder, this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, true, Color.White, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000A94D8 File Offset: 0x000A76D8
		public void DrawCell(string text, RectangleF myrect, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawCell(text, myrect, this.myfont, textforecolor, myformat, myborder, linecolor, minfontsize, textoutstyle);
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000A9508 File Offset: 0x000A7708
		public void DrawCell(string text, RectangleF myrect, Color textforecolor, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawCell(text, myrect, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000A9554 File Offset: 0x000A7754
		public void DrawCell(string text, RectangleF myrect, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawCell(text, myrect, this.TextColor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000A95A4 File Offset: 0x000A77A4
		public void DrawCell(string text, RectangleF myrect, Font myf, Brush textbrush, StringFormat myformat, string myborder, Color linecolor, float minfontsize = 0f)
		{
			if (!this.CancelDocument && myrect.Height > 0f)
			{
				if (myformat == null)
				{
					myformat = new StringFormat(StringFormat.GenericTypographic);
				}
				this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, myborder, textbrush, myformat, minfontsize, true, Color.White, linecolor);
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000A960C File Offset: 0x000A780C
		public void DrawCell(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myrect.Height > 0f)
			{
				this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, myborder, textforecolor, myformat, minfontsize, true, Color.White, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000A966C File Offset: 0x000A786C
		public void DrawCell(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, Color backcolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myrect.Height > 0f)
			{
				this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, myborder, textforecolor, myformat, minfontsize, true, backcolor, linecolor, textoutstyle, 0f);
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000A96C8 File Offset: 0x000A78C8
		public void DrawCell(string text, RectangleF myrect, Font myf, Color textforecolor, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawCell(text, myrect, myf, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000A9718 File Offset: 0x000A7918
		public void DrawCell(string text, RectangleF myrect, Font myf, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawCell(text, myrect, myf, this.TextColor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000A976C File Offset: 0x000A796C
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, float mywidth, float myheight, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (this.IsNeedCheckNewPage)
			{
				this.MyIsNewPage(myheight, true);
			}
			RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, mywidth, myheight);
			this.DrawMultiCell(text, number, Hdirection, rowcolalignmentleft, myrect, myf, textforecolor, myformat, myborder, linecolor, minfontsize, textoutstyle);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000A97BC File Offset: 0x000A79BC
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				if (number <= 0L)
				{
					number = (long)Strings.Len(text);
				}
				checked
				{
					if (number != 0L)
					{
						StringFormat stringFormat;
						if (myformat != null)
						{
							stringFormat = (StringFormat)myformat.Clone();
						}
						else
						{
							stringFormat = new StringFormat(StringFormat.GenericTypographic);
						}
						stringFormat.FormatFlags |= StringFormatFlags.NoWrap;
						if (number != unchecked((long)Strings.Len(text)))
						{
							if (rowcolalignmentleft)
							{
								if (number > unchecked((long)Strings.Len(text)))
								{
									text += Strings.Space((int)(number - unchecked((long)Strings.Len(text))));
								}
								else
								{
									text = Strings.Left(text, (int)number);
								}
							}
							else if (number > unchecked((long)Strings.Len(text)))
							{
								text = Strings.Space((int)(number - unchecked((long)Strings.Len(text)))) + text;
							}
							else
							{
								text = Strings.Right(text, (int)number);
							}
						}
						float x = myrect.X;
						float y = myrect.Y;
						RectangleF myrect2;
						if (!Hdirection)
						{
							myrect2 = new RectangleF(x, y, myrect.Width, myrect.Height / (float)number);
						}
						else
						{
							myrect2 = new RectangleF(x, y, myrect.Width / (float)number, myrect.Height);
						}
						long num = 1L;
						long num2 = number;
						for (long num3 = num; num3 <= num2; num3 += 1L)
						{
							this.DrawCell(Strings.Mid(text, (int)num3, 1), myrect2, myf, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
							unchecked
							{
								if (!Hdirection)
								{
									myrect2 = new RectangleF(x, y + myrect.Height / (float)number * (float)num3, myrect.Width, myrect.Height / (float)number);
								}
								else
								{
									myrect2 = new RectangleF(x + myrect.Width / (float)number * (float)num3, y, myrect.Width / (float)number, myrect.Height);
								}
							}
						}
						this.mylastdrawtextheight = this.MyConvTo(myrect.Height);
						this.mylastdrawtextwidth = this.MyConvTo(myrect.Width);
						try
						{
							stringFormat.Dispose();
							myrect2 = default(RectangleF);
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000A99CC File Offset: 0x000A7BCC
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, float mywidth, float myheight, Font myf, Color textforecolor, string myborder, Color linecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, mywidth, myheight);
				this.DrawMultiCell(text, number, Hdirection, rowcolalignmentleft, myrect, myf, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000A9A58 File Offset: 0x000A7C58
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, RectangleF myrect, Font myf, Color textforecolor, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				this.DrawMultiCell(text, number, Hdirection, rowcolalignmentleft, myrect, myf, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000A9ABC File Offset: 0x000A7CBC
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, RectangleF myrect, Font myf, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			this.DrawMultiCell(text, number, Hdirection, rowcolalignmentleft, myrect, myf, this.TextColor, linecolor, myborder, minfontsize, textoutstyle);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000A9AE8 File Offset: 0x000A7CE8
		public void DrawMultiCell(string text, long number, bool Hdirection, bool rowcolalignmentleft, RectangleF myrect, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			this.DrawMultiCell(text, number, Hdirection, rowcolalignmentleft, myrect, this.myfont, this.TextColor, linecolor, myborder, minfontsize, textoutstyle);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000A9B18 File Offset: 0x000A7D18
		public void DrawMultiCell(string text, bool Hdirection, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			this.DrawMultiCell(text, 0L, Hdirection, true, myrect, myf, textforecolor, myformat, myborder, linecolor, minfontsize, textoutstyle);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000A9B48 File Offset: 0x000A7D48
		public void DrawMultiCell(string text, bool Hdirection, RectangleF myrect, Font myf, Color textforecolor, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				this.DrawMultiCell(text, 0L, Hdirection, true, myrect, myf, textforecolor, stringFormat, myborder, linecolor, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000A9BB0 File Offset: 0x000A7DB0
		public void DrawMultiCell(string text, bool Hdirection, RectangleF myrect, Font myf, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			this.DrawMultiCell(text, Hdirection, myrect, myf, this.TextColor, linecolor, myborder, minfontsize, textoutstyle);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x000A9BD8 File Offset: 0x000A7DD8
		public void DrawMultiCell(string text, bool Hdirection, RectangleF myrect, Color linecolor, string myborder = "1111", float minfontsize = 0f, int textoutstyle = 0)
		{
			this.DrawMultiCell(text, Hdirection, myrect, this.myfont, linecolor, myborder, minfontsize, textoutstyle);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000A9BFC File Offset: 0x000A7DFC
		public void DrawTitle(string text, Font myf, Color textforecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				this.Currentx = 0f;
				this.DrawText(text, this.PaperPrintWidth, myf, textforecolor, stringFormat, textoutstyle);
				stringFormat.Dispose();
				this.Currentx = 0f;
				this.Currenty += this.LastDrawTextHeight;
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000A9C80 File Offset: 0x000A7E80
		public void DrawTitle(string text, RectangleF myrect, Font myf, Color textforecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				this.DrawText(text, myrect, myf, textforecolor, stringFormat, minfontsize, textoutstyle);
				stringFormat.Dispose();
				this.Currentx = 0f;
				this.Currenty += this.LastDrawTextHeight;
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000A9CF8 File Offset: 0x000A7EF8
		public void DrawTitleEx(string s, Font myfont, Brush mybrush, float linespace, float charspace)
		{
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				float height = this.MeasureString("测", myfont, false).Height;
				if (linespace < 0f)
				{
					linespace = height * Math.Abs(linespace);
				}
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", myfont, false).Width * Math.Abs(charspace);
				}
				float paperPrintWidth = this.PaperPrintWidth;
				string[] array = this.SplitTitleEx(s, paperPrintWidth, myfont, charspace);
				int num = 0;
				checked
				{
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						float num3 = this.MeasureTextExWidth(array[i], myfont, charspace);
						this.MyIsNewPage(height, true);
						unchecked
						{
							this.Currentx = (paperPrintWidth - num3) / 2f;
							this.DrawTextEx(array[i], myfont, mybrush, 0f, charspace);
							this.Currenty += height;
							if (i != checked(array.Length - 1))
							{
								this.Currenty += linespace;
							}
						}
					}
					this.Currentx = 0f;
				}
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000A9E28 File Offset: 0x000A8028
		public void DrawTitleEx(string s, RectangleF myrect, Font myfont, Brush mybrush, float linespace, float charspace)
		{
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				float width = myrect.Width;
				float height = this.MeasureText("测试", myfont).Height;
				if (linespace < 0f)
				{
					linespace = height * Math.Abs(linespace);
				}
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", myfont, false).Width * Math.Abs(charspace);
				}
				string[] array = this.SplitTitleEx(s, myrect.Width, myfont, charspace);
				float num = this.MeasureTextExHeight(s, myfont, myrect.Width, linespace, charspace);
				this.Currenty = (myrect.Height - num) / 2f + this.Currenty;
				int num2 = 0;
				checked
				{
					int num3 = array.Length - 1;
					for (int i = num2; i <= num3; i++)
					{
						float num4 = this.MeasureTextExWidth(array[i], myfont, charspace);
						unchecked
						{
							this.Currentx = (width - num4) / 2f + myrect.X;
							this.MyDrawSingleLineTextEx(array[i], myfont, mybrush, charspace);
							this.Currenty += height;
							if (i != checked(array.Length - 1))
							{
								this.Currenty += linespace;
							}
						}
					}
					this.Currentx = 0f;
				}
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000A9F88 File Offset: 0x000A8188
		private void MyDrawSingleLineTextEx(string s, Font font, Brush brush, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			s = Strings.Replace(s, "\r", "", 1, -1, CompareMethod.Binary);
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				StringFormat stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
				stringFormat2.FormatFlags = (stringFormat2.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				SizeF sizeF = default(SizeF);
				string text = Strings.Mid(s, 1, 1);
				sizeF = this.MeasureString(text, font, stringFormat2, false);
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", font, false).Width * Math.Abs(charspace);
				}
				if (this.Currentx + sizeF.Width > this.PaperPrintWidth)
				{
					this.NewRow(this.LastDrawTextHeight);
				}
				int num = 1;
				checked
				{
					int num2 = s.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						if (this.CancelDocument)
						{
							return;
						}
						this.DrawTextExSingleChar(text, font, brush);
						text = Strings.Mid(s, i + 1, 1);
						sizeF = this.MeasureString(text, font, stringFormat2, false);
						unchecked
						{
							this.Currentx += charspace;
						}
					}
					this.DrawTextExSingleChar(text, font, brush);
				}
				this.Currentx += charspace;
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000AA134 File Offset: 0x000A8334
		private string[] SplitTitleEx(string s, float mywidth, Font font, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			checked
			{
				string[] result;
				if (mywidth <= 0f)
				{
					result = null;
				}
				else
				{
					if (font == null)
					{
						font = this.myfont;
					}
					if (font == null)
					{
						font = new Font("宋体", 12f, FontStyle.Regular);
					}
					StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
					stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
					SizeF sizeF = default(SizeF);
					string text = Strings.Mid(s, 1, 1);
					sizeF = this.MeasureString(text, font, stringFormat, false);
					if (mywidth < sizeF.Width)
					{
						result = null;
					}
					else
					{
						float num = sizeF.Width;
						int num2 = 1;
						string[] array = (string[])Utils.CopyArray((Array)array, new string[1]);
						int num3 = 1;
						int num4 = s.Length - 1;
						for (int i = num3; i <= num4; i++)
						{
							if (Operators.CompareString(text, "", false) != 0)
							{
								array[num2 - 1] = array[num2 - 1] + text;
							}
							text = Strings.Mid(s, i + 1, 1);
							sizeF = this.MeasureString(text, font, stringFormat, false);
							unchecked
							{
								if (num + sizeF.Width + charspace > mywidth | Strings.Asc(text) == 13)
								{
									checked
									{
										num2++;
										array = (string[])Utils.CopyArray((Array)array, new string[num2 - 1 + 1]);
										if (Strings.Asc(text) != 13)
										{
											num = sizeF.Width;
										}
										else
										{
											num = 0f;
										}
									}
								}
								else
								{
									num += sizeF.Width;
									num += charspace;
								}
								if (Strings.Asc(text) == 13)
								{
									text = "";
									num -= charspace;
								}
							}
						}
						array[num2 - 1] = array[num2 - 1] + text;
						stringFormat.Dispose();
						result = array;
					}
				}
				return result;
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000788F File Offset: 0x00005A8F
		public void DrawText(string text)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, this.myfont, 0);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000078A7 File Offset: 0x00005AA7
		public void DrawText(string text, int textoutstyle)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, this.myfont, textoutstyle);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000AA304 File Offset: 0x000A8504
		public void DrawText(string text, Font myf, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myf, this.TextColor, stringFormat, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000AA350 File Offset: 0x000A8550
		public void DrawText(string text, Font myf, Color textforecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myf, textforecolor, stringFormat, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000078BF File Offset: 0x00005ABF
		public void DrawText(string text, Font myf, StringFormat myformat, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, myf, this.TextColor, myformat, textoutstyle);
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000AA398 File Offset: 0x000A8598
		public void DrawText(string text, Font myf, Color textforecolor, StringFormat myformat, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				if (myf == null)
				{
					myf = this.myfont;
				}
				if (myf == null)
				{
					myf = new Font("宋体", 12f, FontStyle.Regular);
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					this.mylastdrawtextheight = 0f;
					this.mylastdrawtextwidth = 0f;
				}
				else if (this.Currentx == 0f)
				{
					if (this.MeasureString(text, myf, myformat, false).Width < this.PaperPrintWidth)
					{
						this.DrawText(text, this.MeasureString(text, myf, myformat, false).Width, myf, textforecolor, myformat, textoutstyle);
					}
					else
					{
						this.DrawText(text, this.PaperPrintWidth, myf, textforecolor, myformat, textoutstyle);
					}
				}
				else
				{
					float height = this.MeasureString("测试", myf, false).Height;
					if (this.MyIsNewPage(height, true))
					{
						if (this.MeasureString(text, myf, false).Width < this.PaperPrintWidth)
						{
							this.DrawText(text, this.MeasureString(text, myf, false).Width, myf, textforecolor, myformat, textoutstyle);
						}
						else
						{
							this.DrawText(text, this.PaperPrintWidth, myf, textforecolor, myformat, textoutstyle);
						}
					}
					else
					{
						SizeF mysize = default(SizeF);
						mysize = this.MeasureString("测试", myf, false);
						mysize.Width = this.PaperPrintWidth - this.Currentx;
						SizeF sizeF = default(SizeF);
						int num;
						int num2;
						sizeF = this.MeasureString(text, myf, mysize, myformat, ref num, ref num2, false);
						string text2 = Strings.Mid(text, 1, num);
						if (sizeF.Width > this.PaperPrintWidth - this.Currentx)
						{
							this.DrawText(text2, this.PaperPrintWidth - this.Currentx, myf, textforecolor, myformat, textoutstyle);
						}
						else
						{
							this.DrawText(text2, sizeF.Width, myf, textforecolor, myformat, textoutstyle);
						}
						text = Strings.Mid(text, checked(num + 1));
						if (Operators.CompareString(text, "", false) != 0)
						{
							this.Currentx = 0f;
							this.Currenty += sizeF.Height;
							this.DrawText(text, this.PaperPrintWidth, myf, textforecolor, myformat, textoutstyle);
						}
					}
				}
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000078DA File Offset: 0x00005ADA
		public void DrawText(string text, float mywidth, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, mywidth, this.myfont, textoutstyle);
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000078F3 File Offset: 0x00005AF3
		public void DrawText(string text, float mywidth, Font myf, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, mywidth, myf, this.TextColor, textoutstyle);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0000790E File Offset: 0x00005B0E
		public void DrawText(string text, float mywidth, Color textforecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, mywidth, this.myfont, textforecolor, textoutstyle);
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000AA5BC File Offset: 0x000A87BC
		public void DrawText(string text, float mywidth, Font myf, Color textforecolor, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, mywidth, myf, textforecolor, stringFormat, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000AA604 File Offset: 0x000A8804
		public void DrawText(string text, float mywidth, Font myf, Color textforecolor, StringFormat myformat, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawString(text, mywidth, myf, textforecolor, myformat, "", false, Color.White, Color.White, textoutstyle);
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000AA638 File Offset: 0x000A8838
		public void DrawText(string s, float mywidth, float myheight, Font myf, Color textforecolor, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = false, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, "", textforecolor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, false, Color.White, Color.White, textoutstyle, 0f);
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		public void DrawText(string s, float mywidth, float myheight, Font myf, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = false, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, "", this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, false, Color.White, Color.White, textoutstyle, 0f);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000AA714 File Offset: 0x000A8914
		public void DrawText(string s, float mywidth, float myheight, StringAlignment myHalg = StringAlignment.Near, StringAlignment myValg = StringAlignment.Center, bool mulline = true, bool overflow = false, bool directrighttoleft = false, bool directionVertical = false, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myheight > 0f)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.MyIsNewPage(myheight, true);
				}
				this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, this.myfont, "", this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, false, Color.White, Color.White, textoutstyle, 0f);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00007929 File Offset: 0x00005B29
		public void DrawText(string text, RectangleF myrect, Color textforecolor, StringFormat myformat, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				this.DrawText(text, myrect, this.myfont, textforecolor, myformat, minfontsize, textoutstyle);
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000AA788 File Offset: 0x000A8988
		public void DrawText(string text, RectangleF myrect, Color textforecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myrect, textforecolor, stringFormat, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000AA7D0 File Offset: 0x000A89D0
		public void DrawText(string text, RectangleF myrect, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myrect, this.TextColor, stringFormat, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000AA81C File Offset: 0x000A8A1C
		public void DrawText(string text, RectangleF myrect, Font myf, Brush textbrush, StringFormat myformat, float minfontsize = 0f)
		{
			if (!this.CancelDocument && myrect.Height > 0f)
			{
				this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, "", textbrush, myformat, minfontsize, false, Color.White, Color.White);
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000AA87C File Offset: 0x000A8A7C
		public void DrawText(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument && myrect.Height > 0f)
			{
				this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, "", textforecolor, myformat, minfontsize, false, Color.White, Color.White, textoutstyle, 0f);
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		public void DrawText(string text, RectangleF myrect, Font myf, Color textforecolor, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myrect, myf, textforecolor, stringFormat, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000AA92C File Offset: 0x000A8B2C
		public void DrawText(string text, RectangleF myrect, Font myf, float minfontsize = 0f, int textoutstyle = 0)
		{
			if (!this.CancelDocument)
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
				this.DrawText(text, myrect, myf, this.TextColor, stringFormat, minfontsize, textoutstyle);
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000AA97C File Offset: 0x000A8B7C
		public void DrawImage(Image myimage)
		{
			if (!this.CancelDocument && myimage != null)
			{
				float mywidth = this.ConvFromDisplay((float)myimage.Width, true);
				float myheight = this.ConvFromDisplay((float)myimage.Height, false);
				this.DrawImage(myimage, this.Currentx, this.Currenty, mywidth, myheight, true, StringAlignment.Center, StringAlignment.Center);
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000AA9CC File Offset: 0x000A8BCC
		public void DrawImage(Image myimage, float x, float y)
		{
			if (!this.CancelDocument && myimage != null)
			{
				float mywidth = this.ConvFromDisplay((float)myimage.Width, true);
				float myheight = this.ConvFromDisplay((float)myimage.Height, false);
				this.DrawImage(myimage, x, y, mywidth, myheight, true, StringAlignment.Center, StringAlignment.Center);
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000AAA10 File Offset: 0x000A8C10
		public void DrawCellImage(Image myimage, float x, float y, float mywidth, float myheight, string myborder = "1111", bool autoscaled = true, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			this.DrawCellImage(myimage, x, y, mywidth, myheight, this.myforecolor, myborder, autoscaled, Halignment, Valignment);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000AAA38 File Offset: 0x000A8C38
		public void DrawCellImage(Image myimage, float x, float y, float mywidth, float myheight, Color linecolor, string myborder = "1111", bool autoscaled = true, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument)
			{
				this.DrawImage(myimage, x + (float)this.CellMargin.Left, y + (float)this.CellMargin.Top, mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right, myheight - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom, autoscaled, Halignment, Valignment);
				string text = "";
				RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
				this.DrawCell(text, myrect, this.myforecolor, myborder, linecolor, 0f, 0);
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000AAADC File Offset: 0x000A8CDC
		public void DrawCellImage(Image myimage, float x, float y, float mywidth, float myheight, Color linecolor, string myborder, DataGridViewImageCellLayout imageCellLayout, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument)
			{
				if (myimage == null)
				{
					string text = "";
					RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
					this.DrawCell(text, myrect, this.myforecolor, myborder, linecolor, 0f, 0);
				}
				else
				{
					switch (imageCellLayout)
					{
						case DataGridViewImageCellLayout.NotSet:
						case DataGridViewImageCellLayout.Normal:
							{
								RectangleF destRect=new RectangleF();
								destRect.X = x + (float)this.CellMargin.Left;
								destRect.Y = y + (float)this.CellMargin.Top;
								destRect.Width = mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right;
								destRect.Height = myheight - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom;
								RectangleF srcRect=new RectangleF();
								switch (Halignment)
								{
									case StringAlignment.Near:
										switch (Valignment)
										{
											case StringAlignment.Near:
												{
													float num = mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right;
													float num2 = myheight - (float)this.CellMargin.Bottom - (float)this.CellMargin.Top;
													this.DrawImage(myimage, x + (float)this.CellMargin.Left, y + (float)this.CellMargin.Top, num, num2, num, num2);
													goto IL_50C;
												}
											case StringAlignment.Far:
												srcRect.Y = (float)myimage.Height - this.ConvToDisplay(destRect.Height, false);
												srcRect.Height = this.ConvToDisplay(destRect.Height, false);
												srcRect.Width = this.ConvToDisplay(destRect.Width, true);
												srcRect.X = 0f;
												this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
												goto IL_50C;
										}
										srcRect.Y = ((float)myimage.Height - this.ConvToDisplay(destRect.Height, false)) / 2f;
										srcRect.Height = this.ConvToDisplay(destRect.Height, false);
										srcRect.Width = this.ConvToDisplay(destRect.Width, true);
										srcRect.X = 0f;
										this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
										goto IL_50C;
									case StringAlignment.Far:
										switch (Valignment)
										{
											case StringAlignment.Near:
												srcRect.Y = 0f;
												srcRect.Height = this.ConvToDisplay(destRect.Height, false);
												srcRect.Width = this.ConvToDisplay(destRect.Width, true);
												srcRect.X = (float)myimage.Width - this.ConvToDisplay(destRect.Width, true);
												this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
												goto IL_50C;
											case StringAlignment.Far:
												srcRect.Y = (float)myimage.Height - this.ConvToDisplay(destRect.Height, false);
												srcRect.Height = this.ConvToDisplay(destRect.Height, false);
												srcRect.Width = this.ConvToDisplay(destRect.Width, true);
												srcRect.X = (float)myimage.Width - this.ConvToDisplay(destRect.Width, true);
												this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
												goto IL_50C;
										}
										srcRect.Y = ((float)myimage.Height - this.ConvToDisplay(destRect.Height, false)) / 2f;
										srcRect.Height = this.ConvToDisplay(destRect.Height, false);
										srcRect.Width = this.ConvToDisplay(destRect.Width, true);
										srcRect.X = (float)myimage.Width - this.ConvToDisplay(destRect.Width, true);
										this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
										goto IL_50C;
								}
								switch (Valignment)
								{
									case StringAlignment.Near:
										srcRect.Y = 0f;
										srcRect.Height = this.ConvToDisplay(destRect.Height, false);
										srcRect.Width = this.ConvToDisplay(destRect.Width, true);
										srcRect.X = ((float)myimage.Width - this.ConvToDisplay(destRect.Width, true)) / 2f;
										this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
										goto IL_50C;
									case StringAlignment.Far:
										srcRect.Y = (float)myimage.Height - this.ConvToDisplay(destRect.Height, false);
										srcRect.Height = this.ConvToDisplay(destRect.Height, false);
										srcRect.Width = this.ConvToDisplay(destRect.Width, true);
										srcRect.X = ((float)myimage.Width - this.ConvToDisplay(destRect.Width, true)) / 2f;
										this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
										goto IL_50C;
								}
								srcRect.Y = ((float)myimage.Height - this.ConvToDisplay(destRect.Height, false)) / 2f;
								srcRect.Height = this.ConvToDisplay(destRect.Height, false);
								srcRect.Width = this.ConvToDisplay(destRect.Width, true);
								srcRect.X = ((float)myimage.Width - this.ConvToDisplay(destRect.Width, true)) / 2f;
								this.DrawImage(myimage, destRect, srcRect, GraphicsUnit.Pixel);
							IL_50C:
								string text2 = "";
								RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
								this.DrawCell(text2, myrect, this.myforecolor, myborder, linecolor, 0f, 0);
								return;
							}
						case DataGridViewImageCellLayout.Zoom:
							{
								float num3 = this.ConvFromDisplay((float)myimage.Width, true);
								float num4 = this.ConvFromDisplay((float)myimage.Height, false);
								float num5 = (mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right) / num3;
								float num6 = (myheight - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom) / num4;
								float num7;
								float num8;
								if (num5 > num6)
								{
									num7 = myheight - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom;
									num8 = num7 * (num3 / num4);
								}
								else
								{
									num8 = mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right;
									num7 = num8 * (num4 / num3);
								}
								float x2=0;
								switch (Halignment)
								{
									case StringAlignment.Near:
										x2 = x + (float)this.CellMargin.Left;
										break;
									case StringAlignment.Center:
										x2 = x + (float)this.CellMargin.Left + (mywidth - (float)this.CellMargin.Left - (float)this.CellMargin.Right - num8) / 2f;
										break;
									case StringAlignment.Far:
										x2 = x + mywidth - num8 - (float)this.CellMargin.Right;
										break;
								}
								float y2=0;
								switch (Valignment)
								{
									case StringAlignment.Near:
										y2 = y + (float)this.CellMargin.Top;
										break;
									case StringAlignment.Center:
										y2 = y + (float)this.CellMargin.Top + (myheight - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom - num7) / 2f;
										break;
									case StringAlignment.Far:
										y2 = y + myheight - num7 - (float)this.CellMargin.Bottom;
										break;
								}
								this.DrawImage(myimage, x2, y2, num8, num7, true, Halignment, Valignment);
								string text3 = "";
								RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
								this.DrawCell(text3, myrect, this.myforecolor, myborder, linecolor, 0f, 0);
								return;
							}
					}
					this.DrawCellImage(myimage, x, y, mywidth, myheight, linecolor, myborder, Conversions.ToBoolean(Interaction.IIf(imageCellLayout == DataGridViewImageCellLayout.Stretch, true, false)), StringAlignment.Center, StringAlignment.Center);
				}
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000AB230 File Offset: 0x000A9430
		public void DrawImage(Image myimage, float x, float y, float mywidth, float myheight, bool autoscaled = true, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (!autoscaled)
				{
					float num = this.ConvFromDisplay((float)myimage.Width, true);
					float num2 = this.ConvFromDisplay((float)myimage.Height, false);
					if (num >= mywidth)
					{
						num = mywidth;
					}
					if (num2 >= myheight)
					{
						num2 = myheight;
					}
					switch (Halignment)
					{
						case StringAlignment.Center:
							x += (mywidth - num) / 2f;
							break;
						case StringAlignment.Far:
							x = x + mywidth - num;
							break;
					}
					switch (Valignment)
					{
						case StringAlignment.Center:
							y += (myheight - num2) / 2f;
							break;
						case StringAlignment.Far:
							y = y + myheight - num2;
							break;
					}
					mywidth = num;
					myheight = num2;
				}
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					this.MyWrite("i", Module1.ConvertImageToString(myimage), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)));
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					this.MyWrite("i", Conversions.ToString(value), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)));
				}
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000AB388 File Offset: 0x000A9588
		private void DrawImageForTreeView(Image myimage, float x, float y, float mywidth, float myheight, bool autoscaled = true, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument && myimage != null)
			{
				string t = Module1.ConvertImageToString(myimage);
				if (!autoscaled)
				{
					float num = this.ConvFromDisplay((float)myimage.Width, true);
					float num2 = this.ConvFromDisplay((float)myimage.Height, false);
					if (num >= mywidth)
					{
						num = mywidth;
					}
					if (num2 >= myheight)
					{
						num2 = myheight;
					}
					switch (Halignment)
					{
						case StringAlignment.Center:
							x += (mywidth - num) / 2f;
							break;
						case StringAlignment.Far:
							x = x + mywidth - num;
							break;
					}
					switch (Valignment)
					{
						case StringAlignment.Center:
							y += (myheight - num2) / 2f;
							break;
						case StringAlignment.Far:
							y = y + myheight - num2;
							break;
					}
					mywidth = num;
					myheight = num2;
				}
				this.MyWrite("p", t, Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)));
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00007948 File Offset: 0x00005B48
		public void DrawImage(Image myimage, RectangleF myrectf)
		{
			this.DrawImage(myimage, myrectf, true, StringAlignment.Center, StringAlignment.Center);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000AB480 File Offset: 0x000A9680
		public void DrawImage(Image myimage, RectangleF myrectf, bool autoscaled, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument && myimage != null)
			{
				this.DrawImage(myimage, myrectf.X, myrectf.Y, myrectf.Width, myrectf.Height, autoscaled, Halignment, Valignment);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		public void DrawImage(Image myimage, Rectangle myrect, bool autoscaled = true, StringAlignment Halignment = StringAlignment.Center, StringAlignment Valignment = StringAlignment.Center)
		{
			if (!this.CancelDocument && myimage != null)
			{
				this.DrawImage(myimage, (float)myrect.X, (float)myrect.Y, (float)myrect.Width, (float)myrect.Height, autoscaled, Halignment, Valignment);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000AB504 File Offset: 0x000A9704
		public void DrawImage(Image myimage, float x, float y, float mywidth, float myheight, float srcwidth, float srcheight)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					this.MyWrite("i2", Module1.ConvertImageToString(myimage), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), Conversions.ToString(this.MyConvTo(srcwidth)), Conversions.ToString(this.MyConvTo(srcheight)), "");
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					this.MyWrite("i2", Conversions.ToString(value), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(this.MyConvTo(mywidth)), Conversions.ToString(this.MyConvTo(myheight)), Conversions.ToString(this.MyConvTo(srcwidth)), Conversions.ToString(this.MyConvTo(srcheight)), "");
				}
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000AB604 File Offset: 0x000A9804
		private void MyDrawImage(Image myimage, float x, float y, float mywidth, float myheight, float picwidth, float picheight)
		{
			if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
			{
				picwidth = this.ConvertInchToCm(picwidth);
				picheight = this.ConvertInchToCm(picheight);
			}
			picwidth = this.ConvToDisplay(picwidth, true);
			picheight = this.ConvToDisplay(picheight, false);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			Graphics graphics = this.myg;
			Rectangle destRect = checked(new Rectangle((int)Math.Round((double)(unchecked(x + (float)this.mypagesetting.Margins.Left))), (int)Math.Round((double)(unchecked(y + (float)this.mypagesetting.Margins.Top))), (int)Math.Round((double)mywidth), (int)Math.Round((double)myheight)));
			graphics.DrawImage(myimage, destRect, 0f, 0f, picwidth, picheight, GraphicsUnit.Pixel);
			this.myg.Transform = transform;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000AB6D4 File Offset: 0x000A98D4
		private int MySaveAndGetImageIndex(Image myimage)
		{
			checked
			{
				if (myimage != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					myimage.Save(memoryStream, ImageFormat.Png);
					memoryStream.Position = 0L;
					byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
					memoryStream.Read(array, 0, array.Length);
					bool flag = false;
					int num = 0;
					int num2 = this.mypictures - 1;
					for (int i = num; i <= num2; i++)
					{
						if (array.Length == this.mypicture[i].mypi.Length)
						{
							int num3 = 0;
							int num4 = array.Length - 1;
							int j;
							for (j = num3; j <= num4; j++)
							{
								if (array[j] != this.mypicture[i].mypi[j])
								{
									break;
								}
							}
							if (j == array.Length)
							{
								flag = true;
							IL_C1:
								int result;
								if (flag)
								{
									result = i;
								}
								else
								{
									this.mypicture = (VB2008Print.mypic[])Utils.CopyArray((Array)this.mypicture, new VB2008Print.mypic[this.mypictures + 1]);
									this.mypicture[this.mypictures].mypi = array;
									result = this.mypictures;
									this.mypictures++;
								}
								try
								{
									memoryStream.Close();
									memoryStream.Dispose();
								}
								catch (Exception ex)
								{
								}
								return result;
							}
						}
					}
					goto IL_C1;
				}
				return 0;
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000AB838 File Offset: 0x000A9A38
		private void MyDrawImage(Image myimage, float x, float y, float mywidth, float myheight)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			Graphics graphics = this.myg;
			RectangleF rect = new RectangleF(x + (float)this.mypagesetting.Margins.Left, y + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
			graphics.DrawImage(myimage, rect);
			this.myg.Transform = transform;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		public void DrawImageUnscaledAndClipped(Image myimage, RectangleF rect)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					this.MyWrite("DrawImageUnscaledAndClipped", Module1.ConvertImageToString(myimage), this.ConvertRectToString(rect));
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					this.MyWrite("DrawImageUnscaledAndClipped", Conversions.ToString(value), this.ConvertRectToString(rect));
				}
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000AB910 File Offset: 0x000A9B10
		private void MyDrawImageUnscaledAndClipped(Image myimage, string rectstring)
		{
			if (myimage != null)
			{
				RectangleF rectangleF = this.ConvertStringToRect(rectstring);
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				try
				{
					Graphics graphics = this.myg;
					Image image = myimage;
					Rectangle rect = checked(new Rectangle((int)Math.Round((double)rectangleF.X), (int)Math.Round((double)rectangleF.Y), (int)Math.Round((double)rectangleF.Width), (int)Math.Round((double)rectangleF.Height)));
					graphics.DrawImageUnscaledAndClipped(image, rect);
				}
				catch (Exception ex)
				{
				}
				this.myg.Transform = transform;
				myimage.Dispose();
				myimage = null;
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000AB9C4 File Offset: 0x000A9BC4
		public void DrawImage(Image myimage, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					this.MyWrite("i3", Module1.ConvertImageToString(myimage), this.ConvertRectToString(destRect), Conversions.ToString(srcRect.X), Conversions.ToString(srcRect.Y), Conversions.ToString(srcRect.Width), Conversions.ToString(srcRect.Height), Conversions.ToString((int)srcUnit));
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					this.MyWrite("i3", Conversions.ToString(value), this.ConvertRectToString(destRect), Conversions.ToString(srcRect.X), Conversions.ToString(srcRect.Y), Conversions.ToString(srcRect.Width), Conversions.ToString(srcRect.Height), Conversions.ToString((int)srcUnit));
				}
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		public void DrawImage(Image myimage, float x, float y, RectangleF srcRect, GraphicsUnit srcUnit)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					this.MyWrite("i4", Module1.ConvertImageToString(myimage), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(srcRect.X), Conversions.ToString(srcRect.Y), Conversions.ToString(srcRect.Width), Conversions.ToString(srcRect.Height), Conversions.ToString((int)srcUnit));
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					this.MyWrite("i4", Conversions.ToString(value), Conversions.ToString(this.MyConvTo(x)), Conversions.ToString(this.MyConvTo(y)), Conversions.ToString(srcRect.X), Conversions.ToString(srcRect.Y), Conversions.ToString(srcRect.Width), Conversions.ToString(srcRect.Height), Conversions.ToString((int)srcUnit));
				}
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000ABB9C File Offset: 0x000A9D9C
		private void MyDrawImage(Image myimage, float sx, float sy, float x, float y, float width, float height, int srcUnit)
		{
			if (myimage != null)
			{
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				try
				{
					Graphics graphics = this.myg;
					Image image = myimage;
					float x2 = sx + (float)this.mypagesetting.Margins.Left;
					float y2 = sy + (float)this.mypagesetting.Margins.Top;
					RectangleF srcRect = new RectangleF(x, y, width, height);
					graphics.DrawImage(image, x2, y2, srcRect, (GraphicsUnit)srcUnit);
					myimage.Dispose();
				}
				catch (Exception ex)
				{
				}
				this.myg.Transform = transform;
				myimage = null;
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000ABC40 File Offset: 0x000A9E40
		private void MyDrawImage(Image myimage, string rectstring, float x, float y, float width, float height, int srcUnit)
		{
			if (myimage != null)
			{
				RectangleF rectangleF = this.ConvertStringToRect(rectstring);
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				try
				{
					Graphics graphics = this.myg;
					Image image = myimage;
					RectangleF destRect = rectangleF;
					RectangleF srcRect = new RectangleF(x, y, width, height);
					graphics.DrawImage(image, destRect, srcRect, (GraphicsUnit)srcUnit);
					myimage.Dispose();
				}
				catch (Exception ex)
				{
				}
				this.myg.Transform = transform;
				myimage = null;
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000ABCC4 File Offset: 0x000A9EC4
		public void DrawImageUnscaled(Image myimage, float x, float y)
		{
			if (!this.CancelDocument && myimage != null)
			{
				if (checked(myimage.Height * myimage.Width) <= 16384)
				{
					string t = "DrawImageUnscaled";
					string t2 = Module1.ConvertImageToString(myimage);
					PointF point = new PointF(x, y);
					this.MyWrite(t, t2, this.ConvertPointToString(point));
				}
				else
				{
					int value = this.MySaveAndGetImageIndex(myimage);
					string t3 = "DrawImageUnscaled";
					string t4 = Conversions.ToString(value);
					PointF point = new PointF(x, y);
					this.MyWrite(t3, t4, this.ConvertPointToString(point));
				}
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000ABD3C File Offset: 0x000A9F3C
		private void MyDrawImageUnscaled(Image myimage, string pointstring)
		{
			checked
			{
				if (myimage != null)
				{
					PointF pointF = this.ConvertStringToPoint(pointstring);
					Matrix transform = this.myg.Transform;
					this.PY(this.myg);
					try
					{
						this.myg.DrawImageUnscaled(myimage, (int)Math.Round((double)pointF.X), (int)Math.Round((double)pointF.Y));
					}
					catch (Exception ex)
					{
					}
					this.myg.Transform = transform;
					myimage.Dispose();
					myimage = null;
				}
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00007955 File Offset: 0x00005B55
		[Description("开始打印")]
		public void Print(int startpage, int endpage)
		{
			this.Print(startpage, endpage, (int)this._printcopys);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00007965 File Offset: 0x00005B65
		[Description("开始打印")]
		public void Print(int startpage, int endpage, int copys)
		{
			this.Print(startpage, endpage, copys, false);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000ABDCC File Offset: 0x000A9FCC
		[Description("开始打印")]
		public void Print(int startpage, int endpage, int copys, bool isduplex)
		{
			checked
			{
				if (this.GetPages() > 0 && copys >= 1 && startpage <= endpage && startpage <= this.GetPages())
				{
					if (!this.isstarting)
					{
						while (!this.IsEndPreview)
						{
							Thread.Sleep(100);
							Application.DoEvents();
						}
						if (endpage > this.GetPages())
						{
							endpage = this.GetPages();
						}
						if (endpage - startpage == 0)
						{
							isduplex = false;
						}
						this.isprinttoprinter = true;
						this.Pd.PrinterSettings.Copies = (short)copys;
						this.Pd.PrinterSettings.PrintRange = PrintRange.SomePages;
						this.Pd.PrinterSettings.FromPage = startpage;
						this.Pd.PrinterSettings.ToPage = endpage;
						Module1.G_CancelPrint = false;
						this.Pd.DocumentName = this.DocumentName;
						this.HideDefaultPrintDialog();
						this.ShowPrintProgressDialog();
						if (!isduplex)
						{
							if ((int)this.Pd.PrinterSettings.Copies > this.Pd.PrinterSettings.MaximumCopies)
							{
								int num = 1;
								int copies = (int)this.Pd.PrinterSettings.Copies;
								int i = num;
								while (i <= copies)
								{
									this.isprinttoprinter = true;
									this.Pd.PrinterSettings.PrintRange = PrintRange.SomePages;
									this.Pd.PrinterSettings.FromPage = startpage;
									this.Pd.PrinterSettings.ToPage = endpage;
									this.Pd.DefaultPageSettings = this.mypagesetting;
									this.currentpage = startpage;
									this.SaveCS();
									try
									{
										this.Pd.Print();
									}
									catch (Exception ex)
									{
									}
									try
									{
										this.RestoreCS();
										goto IL_1AA;
									}
									catch (Exception ex2)
									{
										goto IL_1AA;
									}
								IL_1A1:
									i++;
									continue;
								IL_1AA:
									if (Module1.G_CancelPrint)
									{
										break;
									}
									goto IL_1A1;
								}
								goto IL_368;
							}
							this.Pd.DefaultPageSettings = this.mypagesetting;
							this.currentpage = startpage;
							this.SaveCS();
							try
							{
								this.Pd.Print();
							}
							catch (Exception ex3)
							{
							}
							try
							{
								this.RestoreCS();
								goto IL_368;
							}
							catch (Exception ex4)
							{
								goto IL_368;
							}
						}
						this.Pd.PrinterSettings.Copies = 1;
						this.Pd.DefaultPageSettings = this.mypagesetting;
						this.currentpage = startpage;
						this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
						this.w_duplexfrom = startpage;
						this.w_duplexto = endpage;
						if (startpage % 2 == 0)
						{
							this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_OS;
						}
						else
						{
							this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_JS;
						}
						this.SaveCS();
						try
						{
							this.Pd.Print();
						}
						catch (Exception ex5)
						{
						}
						try
						{
							this.RestoreCS();
						}
						catch (Exception ex6)
						{
						}
						if (startpage % 2 == 0)
						{
							Interaction.MsgBox("偶数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印奇数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
						}
						else
						{
							Interaction.MsgBox("奇数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印偶数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
						}
						this.isprinttoprinter = true;
						this.Pd.PrinterSettings.Copies = 1;
						this.Pd.DefaultPageSettings = this.mypagesetting;
						this.currentpage = startpage + 1;
						this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
						this.w_duplexfrom = startpage;
						this.w_duplexto = endpage;
						if (startpage % 2 == 0)
						{
							this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_JS;
						}
						else
						{
							this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_OS;
						}
						this.SaveCS();
						try
						{
							this.Pd.Print();
						}
						catch (Exception ex7)
						{
						}
						try
						{
							this.RestoreCS();
						}
						catch (Exception ex8)
						{
						}
					IL_368:
						Module1.G_CancelPrint = false;
						this.ClosePrintProgressDialog();
						VB2008Print.EndPrintToPrinterEventHandler endPrintToPrinterEvent = this.EndPrintToPrinterEvent;
						if (endPrintToPrinterEvent != null)
						{
							endPrintToPrinterEvent();
						}
						this.currentpage = 1;
						this.Pd.PrinterSettings.Copies = 1;
					}
				}
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000072AB File Offset: 0x000054AB
		[Description("开始打印")]
		public void Print()
		{
			this.Print(false);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00007971 File Offset: 0x00005B71
		[Description("开始打印")]
		public void Print(bool showdialog)
		{
			this.Print(showdialog, false);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x000AC1DC File Offset: 0x000AA3DC
		[Description("开始打印")]
		public void Print(bool showdialog, bool isDuplex)
		{
			this.Pd.PrinterSettings.Copies = this._printcopys;
			checked
			{
				if (this.GetPages() > 0)
				{
					if (!this.isstarting)
					{
						while (!this.IsEndPreview)
						{
							Thread.Sleep(100);
							Application.DoEvents();
						}
						if (showdialog)
						{
							bool flag = false;
							if (!this.IsUseAPIprintDialog)
							{
								switch (this.ShowDefaultPrinterDialog(false, this._printcopys))
								{
									case -1:
										switch (this.ShowDefaultPrinterDialog(true, this._printcopys))
										{
											case -1:
												switch (this.ShowAPIPrinterDialog(this._printcopys))
												{
													case -1:
														flag = true;
														break;
													case 0:
														flag = true;
														break;
													case 1:
														flag = false;
														break;
												}
												break;
											case 0:
												flag = true;
												break;
											case 1:
												flag = false;
												break;
										}
										break;
									case 0:
										flag = true;
										break;
									case 1:
										flag = false;
										break;
								}
							}
							else
							{
								switch (this.ShowAPIPrinterDialog(this._printcopys))
								{
									case -1:
										switch (this.ShowDefaultPrinterDialog(false, this._printcopys))
										{
											case -1:
												switch (this.ShowDefaultPrinterDialog(true, this._printcopys))
												{
													case -1:
														flag = true;
														break;
													case 0:
														flag = true;
														break;
													case 1:
														flag = false;
														break;
												}
												break;
											case 0:
												flag = true;
												break;
											case 1:
												flag = false;
												break;
										}
										break;
									case 0:
										flag = true;
										break;
									case 1:
										flag = false;
										break;
								}
							}
							if (!flag)
							{
								this.isprinttoprinter = true;
								Module1.G_CancelPrint = false;
								this.Pd.DocumentName = this.DocumentName;
								this.HideDefaultPrintDialog();
								this.ShowPrintProgressDialog();
								this.MyParasePage(0);
								if (!isDuplex)
								{
									if ((int)this.Pd.PrinterSettings.Copies > this.Pd.PrinterSettings.MaximumCopies)
									{
										int copies = (int)this.Pd.PrinterSettings.Copies;
										PrintRange printRange = this.Pd.PrinterSettings.PrintRange;
										int fromPage = this.Pd.PrinterSettings.FromPage;
										int toPage = this.Pd.PrinterSettings.ToPage;
										int num = 1;
										int num2 = copies;
										for (int i = num; i <= num2; i++)
										{
											this.isprinttoprinter = true;
											this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
											this.Pd.DefaultPageSettings = this.mypagesetting;
											if (printRange == PrintRange.SomePages)
											{
												this.currentpage = fromPage;
												this.Pd.PrinterSettings.PrintRange = printRange;
												this.Pd.PrinterSettings.FromPage = fromPage;
												this.Pd.PrinterSettings.ToPage = toPage;
											}
											else
											{
												this.currentpage = 1;
											}
											this.SaveCS();
											this.Pd.Print();
											this.RestoreCS();
											if (Module1.G_CancelPrint)
											{
												break;
											}
										}
									}
									else
									{
										this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
										this.Pd.DefaultPageSettings = this.mypagesetting;
										if (this.Pd.PrinterSettings.PrintRange == PrintRange.SomePages)
										{
											this.currentpage = this.Pd.PrinterSettings.FromPage;
										}
										else
										{
											this.currentpage = 1;
										}
										this.SaveCS();
										try
										{
											this.Pd.Print();
										}
										catch (Exception ex)
										{
										}
										this.RestoreCS();
									}
								}
								else
								{
									this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
									this.Pd.PrinterSettings.Copies = 1;
									this.Pd.DefaultPageSettings = this.mypagesetting;
									int num3;
									int toPage2;
									if (this.Pd.PrinterSettings.PrintRange == PrintRange.SomePages)
									{
										num3 = this.Pd.PrinterSettings.FromPage;
										toPage2 = this.Pd.PrinterSettings.ToPage;
									}
									else
									{
										num3 = 1;
										toPage2 = this.GetPages();
									}
									this.currentpage = num3;
									this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
									this.w_duplexfrom = num3;
									this.w_duplexto = toPage2;
									if (num3 % 2 == 0)
									{
										this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_OS;
									}
									else
									{
										this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_JS;
									}
									this.SaveCS();
									try
									{
										this.Pd.Print();
									}
									catch (Exception ex2)
									{
									}
									try
									{
										this.RestoreCS();
									}
									catch (Exception ex3)
									{
									}
									if (toPage2 - num3 >= 1)
									{
										if (num3 % 2 == 0)
										{
											Interaction.MsgBox("偶数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印奇数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
										}
										else
										{
											Interaction.MsgBox("奇数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印偶数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
										}
										this.Pd.PrinterSettings.Copies = 1;
										this.isprinttoprinter = true;
										this.Pd.DefaultPageSettings = this.mypagesetting;
										this.currentpage = num3 + 1;
										this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
										this.w_duplexfrom = num3;
										this.w_duplexto = toPage2;
										if (num3 % 2 == 0)
										{
											this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_JS;
										}
										else
										{
											this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_OS;
										}
										this.SaveCS();
										try
										{
											this.Pd.Print();
										}
										catch (Exception ex4)
										{
										}
										try
										{
											this.RestoreCS();
										}
										catch (Exception ex5)
										{
										}
									}
								}
								Module1.G_CancelPrint = false;
								this.ClosePrintProgressDialog();
								VB2008Print.EndPrintToPrinterEventHandler endPrintToPrinterEvent = this.EndPrintToPrinterEvent;
								if (endPrintToPrinterEvent != null)
								{
									endPrintToPrinterEvent();
								}
								this.currentpage = 1;
								this.Pd.PrinterSettings.Copies = 1;
							}
							else
							{
								VB2008Print.EndPrintToPrinterEventHandler endPrintToPrinterEvent = this.EndPrintToPrinterEvent;
								if (endPrintToPrinterEvent != null)
								{
									endPrintToPrinterEvent();
								}
							}
						}
						else
						{
							this.SaveCS();
							this.Print(1, this.GetPages());
							try
							{
								this.RestoreCS();
							}
							catch (Exception ex6)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x000AC7CC File Offset: 0x000AA9CC
		private int ShowDefaultPrinterDialog(bool myUseExDialog, short copys)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
			printDocument.PrinterSettings.FromPage = 1;
			printDocument.PrinterSettings.ToPage = this.GetPages();
			printDocument.PrinterSettings.MaximumPage = this.GetPages();
			printDocument.PrinterSettings.MinimumPage = 1;
			printDocument.PrinterSettings.PrintRange = PrintRange.AllPages;
			printDocument.PrinterSettings.PrintToFile = false;
			printDocument.PrinterSettings.Copies = copys;
			this.PrintDialog1.UseEXDialog = myUseExDialog;
			this.PrintDialog1.Document = printDocument;
			int num;
			if (this.PrintDialog1.ShowDialog() == DialogResult.OK)
			{
				this.Pd.PrinterSettings.PrinterName = printDocument.PrinterSettings.PrinterName;
				this.Pd.DefaultPageSettings.PrinterSettings.PrinterName = printDocument.PrinterSettings.PrinterName;
				this.Pd.PrinterSettings.Copies = printDocument.PrinterSettings.Copies;
				this.Pd.PrinterSettings.FromPage = printDocument.PrinterSettings.FromPage;
				this.Pd.PrinterSettings.ToPage = printDocument.PrinterSettings.ToPage;
				this.Pd.PrinterSettings.PrintRange = printDocument.PrinterSettings.PrintRange;
				this.Pd.PrinterSettings.PrintToFile = printDocument.PrinterSettings.PrintToFile;
				num = 1;
			}
			else
			{
				num = 0;
			}
			stopwatch.Stop();
			printDocument.Dispose();
			if (num == 0 && stopwatch.ElapsedMilliseconds <= 100L)
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000AC974 File Offset: 0x000AAB74
		private int ShowAPIPrinterDialog(short copies)
		{
			PageSettings pageSettings = new PageSettings((PrinterSettings)this.mypagesetting.PrinterSettings.Clone());
			pageSettings.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
			pageSettings.PrinterSettings.DefaultPageSettings.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
			pageSettings.PrinterSettings.Copies = copies;
			bool flag;
			int result;
			if (pageset.ShowPrinter(ref pageSettings, this.Handle, (long)this.GetPages(), copies, ref flag))
			{
				this.Pd.PrinterSettings.PrinterName = pageSettings.PrinterSettings.PrinterName;
				this.Pd.DefaultPageSettings.PrinterSettings.PrinterName = pageSettings.PrinterSettings.PrinterName;
				this.Pd.PrinterSettings.Copies = pageSettings.PrinterSettings.Copies;
				this.Pd.PrinterSettings.FromPage = pageSettings.PrinterSettings.FromPage;
				this.Pd.PrinterSettings.ToPage = pageSettings.PrinterSettings.ToPage;
				this.Pd.PrinterSettings.PrintRange = pageSettings.PrinterSettings.PrintRange;
				this.Pd.PrinterSettings.PrintToFile = pageSettings.PrinterSettings.PrintToFile;
				result = 1;
			}
			else if (flag)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000ACAC4 File Offset: 0x000AACC4
		private void HideDefaultPrintDialog()
		{
			PrintController printController = new StandardPrintController();
			this.Pd.PrintController = printController;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0000797B File Offset: 0x00005B7B
		private void ShowPrintProgressDialog()
		{
			if (this.IsShowPrintStatusDialog)
			{
				this.ShowStatus();
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0000798B File Offset: 0x00005B8B
		private void ClosePrintProgressDialog()
		{
			this.CloseStatus();
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00007993 File Offset: 0x00005B93
		public void SetDoucumentName(string tt)
		{
			this.DocumentName = tt;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000ACAE4 File Offset: 0x000AACE4
		public float ConvFromDisplay(float myw, bool isX)
		{
			float num;
			if (isX)
			{
				num = this.PIXELSPERINCHX;
			}
			else
			{
				num = this.PIXELSPERINCHY;
			}
			return this.MyConvFrom(myw / num * 100f);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000ACB18 File Offset: 0x000AAD18
		public float ConvToDisplay(float myw, bool isx)
		{
			float num = this.MyConvTo(myw);
			float num2;
			if (isx)
			{
				num2 = this.PIXELSPERINCHX;
			}
			else
			{
				num2 = this.PIXELSPERINCHY;
			}
			num2 = num * num2 / 100f;
			return num2;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0000799C File Offset: 0x00005B9C
		public void PrintDGVEx(DataGridView dgv, DGVprint dgvcs, TreeView columnheadertree)
		{
			this.PrintDGVEx(dgv, dgvcs, 0f, columnheadertree);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000ACB50 File Offset: 0x000AAD50
		public void PrintDGVEx(DataGridView dgv, DGVprint dgvcs, float printwidth, TreeView columnheadertree)
		{
			if (dgv != null && dgvcs != null)
			{
				float currentx = this.Currentx;
				DGVprint.mytype printtype;
				if (printwidth > 0f)
				{
					printtype = DGVprint.mytype.GeneralPrint;
				}
				else
				{
					printtype = dgvcs.PrintType;
				}
				DataGridView dataGridView = new DataGridView();
				Module1.CopyDataGridViewByDGVCS(dgv, dataGridView, dgvcs);
				try
				{
					if (dgvcs.RowHeight != 0f)
					{
						float num = this.ConvToDisplay(dgvcs.RowHeight * 10f, false);
						if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
						{
							num = (float)((double)num / 2.54);
						}
						int num2 = 0;
						checked
						{
							int num3 = dataGridView.RowCount - 1;
							for (int i = num2; i <= num3; i++)
							{
								if (num < 0f)
								{
									dataGridView.Rows[i].MinimumHeight = (int)Math.Round((double)Math.Abs(num));
								}
								else if (num > 0f)
								{
									dataGridView.Rows[i].Height = (int)Math.Round((double)num);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				bool zoomtopaperwidth = dgvcs.ZoomToPaperWidth;
				if (printwidth <= 0f)
				{
					if (Operators.CompareString(dgvcs.ReportHeaderText, "", false) != 0)
					{
						stringFormat.Alignment = dgvcs.ReportHeaderAlignment;
						this.DrawText(dgvcs.ReportHeaderText, dgvcs.ReportHeaderFont, dgvcs.ReportHeaderForeColor, stringFormat, 0);
						this.NewRow(this.LastDrawTextHeight);
						if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
						{
							this.Currenty += (float)((double)dgvcs.ReportHeaderSpace / 2.54);
						}
						else
						{
							this.Currenty += dgvcs.ReportHeaderSpace;
						}
						this.IsNewPage(0f, true);
					}
				}
				else
				{
					zoomtopaperwidth = true;
				}
				bool mysorttype = dgvcs.SortMode == ListSortDirection.Ascending;
				Color outerBorderColor = this.OuterBorderColor;
				float outerBorderWidth = this.OuterBorderWidth;
				bool outerBorder = this.OuterBorder;
				bool isUseDoubleLine = this.IsUseDoubleLine;
				float doubleLineSpace = this.DoubleLineSpace;
				bool isDrawTableFooterEveryPage = this.IsDrawTableFooterEveryPage;
				bool isAutoAddEmptyRow = this.IsAutoAddEmptyRow;
				this.OuterBorderColor = dgvcs.OuterBorderColor;
				this.OuterBorder = dgvcs.OuterBorder;
				this.IsUseDoubleLine = dgvcs.IsUseDoubleLine;
				this.IsAutoAddEmptyRow = dgvcs.IsAutoAddEmptyRow;
				this.IsDrawTableFooterEveryPage = dgvcs.IsDrawTableFooterEveryPage;
				float columnspace;
				float linespace;
				if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
				{
					columnspace = dgvcs.ColumnSpace;
					linespace = dgvcs.LineSpace;
					this.DoubleLineSpace = dgvcs.DoubleLineSpace;
					this.OuterBorderWidth = dgvcs.OuterBorderWidth;
				}
				else
				{
					columnspace = (float)((double)dgvcs.ColumnSpace / 2.54);
					linespace = (float)((double)dgvcs.LineSpace / 2.54);
					this.DoubleLineSpace = (float)((double)dgvcs.DoubleLineSpace / 2.54);
					this.OuterBorderWidth = (float)((double)dgvcs.OuterBorderWidth / 2.54);
				}
				this.Currentx = currentx;
				this.StartDo(dataGridView, dgvcs.SortColumn, mysorttype, dgvcs.GroupColumn, dgvcs.SumColumns, dgvcs.IsGroupNewRowID, dgvcs.GroupNewPage, dgvcs.SumFont, dgvcs.SumForeColor, dgvcs.SumBackColor, dgvcs.AutoFormat, (int)printtype, dgvcs.MainTitle, dgvcs.MainTitleFont, dgvcs.SubTitle, dgvcs.SubTitleFont, dgvcs.Alignment, dgvcs.Border, zoomtopaperwidth, dgvcs.AutoResizeRowHeight, dgvcs.TableHeaderFont, dgvcs.TableHeaderLeft, dgvcs.TableHeaderMiddle, dgvcs.TableHeaderRight, dgvcs.TableFooterFont, dgvcs.TableFooterLeft, dgvcs.TableFooterMiddle, dgvcs.TableFooterRight, dgvcs.MinFontSize, dgvcs.PrintTitlePerPage, dgvcs.PrintBackColor, dgvcs.TitleTextStyle, dgvcs.SubTitleStyle, dgvcs.FixedCols, dgvcs.IsAddRowID, dgvcs.Columns, columnspace, dgvcs.LastPageMode, linespace, dgvcs.PrintZero, columnheadertree, dgvcs.TableTopLeftTitleAlign, dgvcs.TableTopMiddleTitleAlign, dgvcs.TableTopRightTitleAlign, dgvcs.TableBottomLeftTitleAlign, dgvcs.TableBottomMiddleTitleAlign, dgvcs.TableBottomRightTitleAlign, dgvcs.SumNumberAlign, dgvcs.AutoWrap, printwidth);
				this.Currentx = currentx;
				this.OuterBorderColor = outerBorderColor;
				this.OuterBorderWidth = outerBorderWidth;
				this.OuterBorder = outerBorder;
				this.IsUseDoubleLine = isUseDoubleLine;
				this.DoubleLineSpace = doubleLineSpace;
				this.IsAutoAddEmptyRow = isAutoAddEmptyRow;
				this.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage;
				if (printwidth <= 0f && Operators.CompareString(dgvcs.ReportFooterText, "", false) != 0)
				{
					this.Currenty += dgvcs.ReportFooterSpace;
					stringFormat.Alignment = dgvcs.ReportFooterAlignment;
					this.DrawText(dgvcs.ReportFooterText, dgvcs.ReportFooterFont, dgvcs.ReportFooterForeColor, stringFormat, 0);
				}
				this.Currentx = 0f;
				dataGridView.Dispose();
				dataGridView = null;
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		public void PrintDGVEx(string title, Font titlefont, float spacewidth, DataGridView dgv1, DGVprint dgvcs1, float dgv1printwidth, DataGridView dgv2, DGVprint dgvcs2, float dgv2printwidth)
		{
			this.PrintDGVEx(title, titlefont, spacewidth, dgv1, dgvcs1, dgv1printwidth, null, dgv2, dgvcs2, dgv2printwidth, null);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000AD008 File Offset: 0x000AB208
		public void PrintDGVEx(string title, Font titlefont, float spacewidth, DataGridView dgv1, DGVprint dgvcs1, float dgv1printwidth, TreeView colheadertreeview1, DataGridView dgv2, DGVprint dgvcs2, float dgv2printwidth, TreeView colheadertreeview2)
		{
			if (dgv1 != null && dgv2 != null && dgvcs1 != null && dgvcs2 != null)
			{
				float currentx = this.Currentx;
				float mywidth = dgv1printwidth + dgv2printwidth + spacewidth;
				float height = this.MeasureText(title, titlefont, mywidth).Height;
				if (Operators.CompareString(title, "", false) != 0)
				{
					this.DrawText(title, mywidth, height, titlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, 0);
					this.NewRow(height + (float)((double)height / 2.5));
				}
				int currentPage = this.GetCurrentPage();
				this.Currentx = currentx;
				float currenty = this.Currenty;
				this.PrintDGVEx(dgv1, dgvcs1, dgv1printwidth, colheadertreeview1);
				int currentPage2 = this.GetCurrentPage();
				float currenty2 = this.Currenty;
				this.SetCurrentPage(currentPage);
				this.Currentx = currentx + spacewidth + dgv1printwidth;
				this.Currenty = currenty;
				this.PrintDGVEx(dgv2, dgvcs2, dgv2printwidth, colheadertreeview2);
				if (this.GetCurrentPage() < currentPage2)
				{
					this.SetCurrentPage(currentPage2);
					this.Currenty = currenty2;
				}
				else if (this.GetCurrentPage() == currentPage2 && this.Currenty < currenty2)
				{
					this.Currenty = currenty2;
				}
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000AD128 File Offset: 0x000AB328
		public void CreateFa(string myfile, DataGridView dgvtoprint)
		{
			if (dgvtoprint != null)
			{
				if (MyProject.Computer.FileSystem.FileExists(myfile))
				{
					MyProject.Computer.FileSystem.DeleteFile(myfile);
				}
				string section = "页面设置";
				Module1.WriteINI(section, "新页[0-1]", "0", myfile);
				Module1.WriteINI(section, "创建方案[0-1]", "0", myfile);
				Module1.WriteINI(section, "纸张", Conversions.ToString((int)this.PaperKind), myfile);
				if (this.PaperKind <= PaperKind.Custom)
				{
					PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
					if (printForm != null)
					{
						Module1.WriteINI(section, "纸张名称", printForm.PaperName, myfile);
						Module1.WriteINI(section, "纸张宽度", Conversions.ToString((double)printForm.Width * 2.54 / 10.0), myfile);
						Module1.WriteINI(section, "纸张高度", Conversions.ToString((double)printForm.Height * 2.54 / 10.0), myfile);
					}
					else
					{
						Module1.WriteINI(section, "纸张名称", "", myfile);
						Module1.WriteINI(section, "纸张宽度", "0", myfile);
						Module1.WriteINI(section, "纸张高度", "0", myfile);
					}
				}
				else
				{
					PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
					if (printForm != null)
					{
						Module1.WriteINI(section, "纸张名称", printForm.PaperName, myfile);
						Module1.WriteINI(section, "纸张宽度", Conversions.ToString((double)printForm.Width * 2.54 / 10.0), myfile);
						Module1.WriteINI(section, "纸张高度", Conversions.ToString((double)printForm.Height * 2.54 / 10.0), myfile);
					}
					else
					{
						Module1.WriteINI(section, "纸张名称", "", myfile);
						Module1.WriteINI(section, "纸张宽度", "0", myfile);
						Module1.WriteINI(section, "纸张高度", "0", myfile);
					}
				}
				Module1.WriteINI(section, "方向", Conversions.ToString(Interaction.IIf(this.PaperLandscape, "横向", "纵向")), myfile);
				decimal num;
				decimal num2;
				decimal num3;
				decimal num4;
				if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
				{
					num = new decimal((double)this.PaperMargins.Top / 10.0);
					num2 = new decimal((double)this.PaperMargins.Bottom / 10.0);
					num3 = new decimal((double)this.PaperMargins.Left / 10.0);
					num4 = new decimal((double)this.PaperMargins.Right / 10.0);
				}
				else
				{
					num = new decimal((double)this.PaperMargins.Top / 10.0 * 2.54);
					num2 = new decimal((double)this.PaperMargins.Bottom / 10.0 * 2.54);
					num3 = new decimal((double)this.PaperMargins.Left / 10.0 * 2.54);
					num4 = new decimal((double)this.PaperMargins.Right / 10.0 * 2.54);
				}
				num = Math.Round(num, 2);
				num2 = Math.Round(num2, 2);
				num4 = Math.Round(num4, 2);
				num3 = Math.Round(num3, 2);
				Module1.WriteINI(section, "上边距", Conversions.ToString(num), myfile);
				Module1.WriteINI(section, "下边距", Conversions.ToString(num2), myfile);
				Module1.WriteINI(section, "左边距", Conversions.ToString(num3), myfile);
				Module1.WriteINI(section, "右边距", Conversions.ToString(num4), myfile);
				section = "水印设置";
				Module1.WriteINI(section, "内容", "", myfile);
				Module1.WriteINI(section, "方向", "水平", myfile);
				Module1.WriteINI(section, "透明度", "128", myfile);
				Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(Color.Red), myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("华文行楷", 80f, FontStyle.Bold)), myfile);
				section = "表格打印格式";
				Module1.WriteINI(section, "表格打印样式[1-4]", "1", myfile);
				Module1.WriteINI(section, "表格对齐", "居中对齐", myfile);
				Module1.WriteINI(section, "表格边框", "表格线", myfile);
				Module1.WriteINI(section, "适合纸张宽度[0-1]", "1", myfile);
				Module1.WriteINI(section, "自动调整行高[0-1]", "1", myfile);
				Module1.WriteINI(section, "最小字号", "5", myfile);
				Module1.WriteINI(section, "标题行重复打印[0-1]", "1", myfile);
				Module1.WriteINI(section, "打印表格背景颜色[0-1]", "1", myfile);
				Module1.WriteINI(section, "自动调整行高与列宽[0-1]", "1", myfile);
				Module1.WriteINI(section, "工资条间距", "100", myfile);
				Module1.WriteINI(section, "工资条打印零值[0-1]", "0", myfile);
				Module1.WriteINI(section, "多栏打印的栏数", "2", myfile);
				Module1.WriteINI(section, "多栏打印的栏间距", "50", myfile);
				Module1.WriteINI(section, "多栏打印最后一页风格[0-1]", "1", myfile);
				Module1.WriteINI(section, "跨页打印的固定列数", "1", myfile);
				Module1.WriteINI(section, "表格线颜色", Module1.ConvertColorToString(dgvtoprint.GridColor), myfile);
				Module1.WriteINI(section, "补白打印[0-1]", "0", myfile);
				section = "打印标题设置";
				Module1.WriteINI(section, "主标题", "表格主标题", myfile);
				Module1.WriteINI(section, "主标题字体", Module1.ConvertFontToString(new Font("黑体", 18f, FontStyle.Bold)), myfile);
				Module1.WriteINI(section, "主标题前景颜色", Module1.ConvertColorToString(Color.Black), myfile);
				Module1.WriteINI(section, "主标题文字风格[0-6]", "0", myfile);
				Module1.WriteINI(section, "辅标题", "表格的辅标题", myfile);
				Module1.WriteINI(section, "辅标题字体", Module1.ConvertFontToString(new Font("宋体", 14f)), myfile);
				Module1.WriteINI(section, "辅标题文字风格[0-6]", "0", myfile);
				Module1.WriteINI(section, "标题特效时的深度", "18", myfile);
				section = "表格页眉";
				Module1.WriteINI(section, "左边", "", myfile);
				Module1.WriteINI(section, "左边对齐[0-2]", Conversions.ToString(0), myfile);
				Module1.WriteINI(section, "中间", "", myfile);
				Module1.WriteINI(section, "中间对齐[0-2]", Conversions.ToString(1), myfile);
				Module1.WriteINI(section, "右边", "", myfile);
				Module1.WriteINI(section, "右边对齐[0-2]", Conversions.ToString(2), myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("宋体", 10f)), myfile);
				section = "表格页脚";
				Module1.WriteINI(section, "左边", "", myfile);
				Module1.WriteINI(section, "左边对齐[0-2]", Conversions.ToString(0), myfile);
				Module1.WriteINI(section, "中间", "", myfile);
				Module1.WriteINI(section, "中间对齐[0-2]", Conversions.ToString(1), myfile);
				Module1.WriteINI(section, "右边", "", myfile);
				Module1.WriteINI(section, "右边对齐[0-2]", Conversions.ToString(2), myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("宋体", 10f)), myfile);
				section = "页面页眉";
				Module1.WriteINI(section, "左边", "", myfile);
				Module1.WriteINI(section, "中间", "", myfile);
				Module1.WriteINI(section, "右边", "", myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("宋体", 9f)), myfile);
				Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(Color.Black), myfile);
				section = "页面页脚";
				Module1.WriteINI(section, "左边", "", myfile);
				Module1.WriteINI(section, "中间", "第 [页码] 页 共 [总页数] 页", myfile);
				Module1.WriteINI(section, "右边", "", myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("宋体", 9f)), myfile);
				Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(Color.Black), myfile);
				section = "页面右边";
				Module1.WriteINI(section, "上边", "", myfile);
				Module1.WriteINI(section, "中间", "[页码]", myfile);
				Module1.WriteINI(section, "下边", "", myfile);
				Module1.WriteINI(section, "字体", Module1.ConvertFontToString(new Font("宋体", 9f)), myfile);
				Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(Color.Red), myfile);
				section = "表格默认设置";
				Module1.WriteINI(section, "标题字段名默认字体", Module1.ConvertFontToString(dgvtoprint.ColumnHeadersDefaultCellStyle.Font), myfile);
				Module1.WriteINI(section, "标题字段名认前景颜色", Module1.ConvertColorToString(dgvtoprint.ColumnHeadersDefaultCellStyle.ForeColor), myfile);
				Module1.WriteINI(section, "标题字段名默认背景颜色", Module1.ConvertColorToString(dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor), myfile);
				Module1.WriteINI(section, "单元格默认字体", Module1.ConvertFontToString(dgvtoprint.DefaultCellStyle.Font), myfile);
				Module1.WriteINI(section, "单元格默认前景颜色", Module1.ConvertColorToString(dgvtoprint.DefaultCellStyle.ForeColor), myfile);
				Module1.WriteINI(section, "单元格默认背景颜色", Module1.ConvertColorToString(dgvtoprint.DefaultCellStyle.BackColor), myfile);
				Module1.WriteINI(section, "表格总列数", Conversions.ToString(dgvtoprint.ColumnCount), myfile);
				Module1.WriteINI(section, "奇数行默认前景颜色", Module1.ConvertColorToString(dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor), myfile);
				Module1.WriteINI(section, "奇数行默认背景颜色", Module1.ConvertColorToString(dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor), myfile);
				section = "分组汇总排序设置";
				Module1.WriteINI(section, "要汇总的列", "", myfile);
				Module1.WriteINI(section, "汇总行字体", Module1.ConvertFontToString(new Font("黑体", dgvtoprint.DefaultCellStyle.Font.Size, FontStyle.Bold)), myfile);
				Module1.WriteINI(section, "汇总行前景颜色", Module1.ConvertColorToString(dgvtoprint.DefaultCellStyle.ForeColor), myfile);
				Module1.WriteINI(section, "汇总行背景颜色", Module1.ConvertColorToString(dgvtoprint.DefaultCellStyle.BackColor), myfile);
				Module1.WriteINI(section, "汇总行数字对齐方式[0-2]", Conversions.ToString(1), myfile);
				string lpDefault = "";
				string lpDefault2 = "";
				Module1.WriteINI(section, "要排序的列", lpDefault, myfile);
				Module1.WriteINI(section, "升序排序", "1", myfile);
				Module1.WriteINI(section, "要分组列", lpDefault2, myfile);
				Module1.WriteINI(section, "每组换新页打印", "0", myfile);
				Module1.WriteINI(section, "第一列前添加行号", "1", myfile);
				Module1.WriteINI(section, "每组行号重新编号", "0", myfile);
				string lpDefault3 = "";
				checked
				{
					int[] array = new int[dgvtoprint.ColumnCount - 1 + 1];
					int[] array2 = new int[dgvtoprint.ColumnCount - 1 + 1];
					int num5 = 0;
					int num6 = dgvtoprint.ColumnCount - 1;
					int i;
					for (i = num5; i <= num6; i++)
					{
						array[i] = i;
						array2[i] = dgvtoprint.Columns[i].DisplayIndex;
					}
					Array.Sort<int, int>(array2, array);
					int num7 = 0;
					int num8 = dgvtoprint.ColumnCount - 1;
					i = num7;
					while (i <= num8)
					{
						section = "第" + Conversions.ToString(i + 1) + "列";
						string headerText = dgvtoprint.Columns[array[i]].HeaderText;
						string name = dgvtoprint.Columns[array[i]].Name;
						Module1.WriteINI(section, "名称", name, myfile);
						Module1.WriteINI(section, "显示的文本", headerText, myfile);
						Module1.WriteINI(section, "是否打印[0-1]", dgvtoprint.Columns[array[i]].Visible ? "1" : "0", myfile);
						Module1.WriteINI(section, "默认字体", Module1.ConvertFontToString(dgvtoprint.Columns[array[i]].DefaultCellStyle.Font), myfile);
						Module1.WriteINI(section, "默认前景色", Module1.ConvertColorToString(dgvtoprint.Columns[array[i]].DefaultCellStyle.ForeColor), myfile);
						Module1.WriteINI(section, "默认背景色", Module1.ConvertColorToString(dgvtoprint.Columns[array[i]].DefaultCellStyle.BackColor), myfile);
						DataGridViewContentAlignment alignment = dgvtoprint.Columns[name].DefaultCellStyle.Alignment;
						if (alignment == DataGridViewContentAlignment.BottomCenter)
						{
							goto IL_D34;
						}
						if (alignment == DataGridViewContentAlignment.MiddleCenter)
						{
							goto IL_D34;
						}
						if (alignment == DataGridViewContentAlignment.TopCenter)
						{
							goto IL_D34;
						}
						if (alignment != DataGridViewContentAlignment.BottomLeft)
						{
							if (alignment != DataGridViewContentAlignment.MiddleLeft)
							{
								if (alignment != DataGridViewContentAlignment.TopLeft)
								{
									if (alignment == DataGridViewContentAlignment.NotSet)
									{
										lpDefault3 = "未设置";
										goto IL_D3B;
									}
									if (alignment != DataGridViewContentAlignment.BottomRight)
									{
										if (alignment != DataGridViewContentAlignment.MiddleRight)
										{
											if (alignment != DataGridViewContentAlignment.TopRight)
											{
												goto IL_D3B;
											}
										}
									}
									lpDefault3 = "右对齐";
									goto IL_D3B;
								}
							}
						}
						lpDefault3 = "左对齐";
					IL_D3B:
						Module1.WriteINI(section, "文本对齐方式", lpDefault3, myfile);
						switch (dgvtoprint.Columns[name].DefaultCellStyle.WrapMode)
						{
							case DataGridViewTriState.NotSet:
								lpDefault3 = "未设置";
								break;
							case DataGridViewTriState.True:
								lpDefault3 = "允许";
								break;
							case DataGridViewTriState.False:
								lpDefault3 = "不允许";
								break;
						}
						Module1.WriteINI(section, "文本允许换行", lpDefault3, myfile);
						lpDefault3 = Conversions.ToString(this.ConvFromDisplayToMM((float)dgvtoprint.Columns[name].Width));
						Module1.WriteINI(section, "列宽(毫米)", lpDefault3, myfile);
						i++;
						continue;
					IL_D34:
						lpDefault3 = "居中对齐";
						goto IL_D3B;
					}
				}
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000ADF10 File Offset: 0x000AC110
		public float PrintDGVFa(DataGridView mydgvToPrint, byte[] schemebyte, TreeView columnheadertree = null)
		{
			string tempFileName = MyProject.Computer.FileSystem.GetTempFileName();
			FileStream fileStream = new FileStream(tempFileName, FileMode.Create);
			fileStream.Write(schemebyte, 0, schemebyte.Length);
			fileStream.Flush();
			fileStream.Close();
			try
			{
				fileStream.Dispose();
			}
			catch (Exception ex)
			{
			}
			float result = this.PrintDGVFa(mydgvToPrint, tempFileName, false, columnheadertree);
			try
			{
				MyProject.Computer.FileSystem.DeleteFile(tempFileName, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
			}
			catch (Exception ex2)
			{
			}
			return result;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000ADFB0 File Offset: 0x000AC1B0
		public float PrintDGVFa(DataGridView mydgvToPrint, string schemefilename, bool AutoCreateIfFileNotExist = true, TreeView columnheadertree = null)
		{
			DataGridView dataGridView = new DataGridView();
			Module1.CopyDataGridView(mydgvToPrint, dataGridView);
			if (!MyProject.Computer.FileSystem.FileExists(schemefilename))
			{
				if (!AutoCreateIfFileNotExist)
				{
					if (this.IsShowErrorMSG)
					{
						Interaction.MsgBox("直接使用打印方案文件打印输出表格失败，方案文件【" + schemefilename + "】不存在，因此没能将表格打印输出，如有疑问，请与程序员联系", MsgBoxStyle.OkOnly, "提示信息");
					}
					return 0f;
				}
				if (MyProject.Computer.FileSystem.DirectoryExists(schemefilename))
				{
					if (this.IsShowErrorMSG)
					{
						Interaction.MsgBox("直接使用打印方案文件打印输出表格失败，方案文件【" + schemefilename + "】不存在，且指定的方案文件不是有效的文件，而是路径，故没法自动用该文件名创建方案文件，因此没能将表格打印输出，如有疑问，请与程序员联系", MsgBoxStyle.OkOnly, "提示信息");
					}
					return 0f;
				}
				try
				{
					this.CreateFa(schemefilename, dataGridView);
				}
				catch (Exception ex)
				{
				}
			}
			Color color = this.myforecolor;
			int num = this.myshapedepth;
			int num2 = 1;
			string ztitle = "";
			string ftitle = "";
			Font ztitlefont = new Font("黑体", 18f, FontStyle.Bold);
			Font ftitlefont = new Font("宋体", 12f, FontStyle.Bold);
			bool zoomtopaperwidth = true;
			bool autoresizerowheight = true;
			float minfontsize = 0f;
			bool reppagetitle = true;
			bool printbackcolor = true;
			string myborder = "1111";
			float num3 = 100f;
			bool printzero = false;
			bool gzwrap = false;
			int mycolumns = 0;
			float num4 = 50f;
			bool lastpagemode = true;
			int fixedcols = 1;
			bool autoformat = false;
			string tablel = "";
			string tablem = "";
			string tabler = "";
			string tableleft = "";
			string tablemiddle = "";
			string tableright = "";
			Font topfont = new Font("宋体", 10f, FontStyle.Bold);
			Font bottomfont = new Font("宋体", 10f, FontStyle.Bold);
			Color color2 = Color.Black;
			int num5 = 0;
			int num6 = 0;
			string myhzcolumns = "";
			Font myhzfont = null;
			string mygroupcolumn = "";
			string mysortcolumn = "";
			bool mysorttype = true;
			StringAlignment tableTopLeftTitleAlign = StringAlignment.Near;
			StringAlignment tableTopMiddleTitleAlign = StringAlignment.Center;
			StringAlignment tableTopRightTitleAlign = StringAlignment.Far;
			StringAlignment tableBottomLeftTitleAlign = StringAlignment.Near;
			StringAlignment tableBottomMiddleTitleAlign = StringAlignment.Center;
			StringAlignment tableBottomRightTitleAlign = StringAlignment.Far;
			StringAlignment sumNumberAlign = StringAlignment.Center;
			bool isDrawTableFooterEveryPage = false;
			string section = "页面设置";
			string text = Module1.GetINI(section, "创建方案[0-1]", "0", schemefilename);
			if (Operators.CompareString(text, "1", false) == 0)
			{
				this.CreateFa(schemefilename, dataGridView);
			}
			text = Module1.GetINI(section, "新页[0-1]", "0", schemefilename);
			StringAlignment bgalignment;
			bool isAutoAddEmptyRow;
			bool isUseDoubleLine;
			float num10;
			bool outerBorder;
			float num11;
			Color outerBorderColor;
			bool myaddrowid;
			Color myhzforecolor;
			Color myhzbackcolor;
			bool mygroupnewpage;
			bool myaddrownew;
			try
			{
				if (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0)
				{
					text = Module1.GetINI(section, "纸张", "9", schemefilename);
					int num7 = Conversions.ToInteger(text);
					string text2 = "";
					int num8;
					int num9;
					if (num7 <= 0)
					{
						try
						{
							text = Module1.GetINI(section, "纸张名称", "", schemefilename);
							text2 = text.Trim();
							text = Module1.GetINI(section, "纸张宽度", "0", schemefilename);
							checked
							{
								num8 = (int)Math.Round(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(text), 10m)) / 2.54);
								text = Module1.GetINI(section, "纸张高度", "0", schemefilename);
								num9 = (int)Math.Round(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(text), 10m)) / 2.54);
							}
							if (Operators.CompareString(text2, "", false) != 0 & Operators.CompareString(text2, "[自定义纸张]", false) != 0)
							{
								PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), text2);
								if (printForm != null)
								{
									if (num8 <= 0 | num9 <= 0)
									{
										num8 = printForm.Width;
										num9 = printForm.Height;
									}
									else if (checked(Math.Abs(printForm.Width - num8) > 1 | Math.Abs(printForm.Height - num9) > 1))
									{
										definepaper.SetPrintForm(this.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
									}
								}
								else
								{
									definepaper.SetPrintForm(this.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
								}
							}
						}
						catch (Exception ex2)
						{
						}
						if (Operators.CompareString(text2, "[自定义纸张]", false) == 0)
						{
							definepaper.SetPrintForm(this.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
						}
						else
						{
							PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), text2);
							if (printForm != null)
							{
								if (num8 <= 0 | num9 <= 0)
								{
									num8 = printForm.Width;
									num9 = printForm.Height;
								}
								else if (checked(Math.Abs(printForm.Width - num8) > 1 | Math.Abs(printForm.Height - num9) > 1))
								{
									text2 = "[自定义纸张]";
									definepaper.SetPrintForm(this.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
								}
							}
							else
							{
								text2 = "[自定义纸张]";
								definepaper.SetPrintForm(this.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
							}
						}
					}
					text = Module1.GetINI(section, "方向", "纵向", schemefilename);
					bool isPaperLandscape = Operators.CompareString(text, "横向", false) == 0;
					Margins margins = new Margins();
					text = Module1.GetINI(section, "上边距", "25.4", schemefilename);
					margins.Top = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
					text = Module1.GetINI(section, "下边距", "25.4", schemefilename);
					margins.Bottom = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
					text = Module1.GetINI(section, "左边距", "25.4", schemefilename);
					margins.Left = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
					text = Module1.GetINI(section, "右边距", "25.4", schemefilename);
					margins.Right = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
					checked
					{
						if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
						{
							margins.Top = (int)Math.Round((double)margins.Top / 2.54);
							margins.Bottom = (int)Math.Round((double)margins.Bottom / 2.54);
							margins.Left = (int)Math.Round((double)margins.Left / 2.54);
							margins.Right = (int)Math.Round((double)margins.Right / 2.54);
						}
						if (num7 > 0)
						{
							this.NewPage((PaperKind)num7, margins, isPaperLandscape);
						}
						else
						{
							PaperSize newpapersize = new PaperSize(text2, num8, num9);
							this.NewPage(newpapersize, margins, isPaperLandscape);
						}
					}
				}
				section = "表格打印格式";
				text = Module1.GetINI(section, "表格打印样式[1-4]", "1", schemefilename);
				num2 = Conversions.ToInteger(text);
				if (num2 > 4 | num2 < 1)
				{
					num2 = 1;
				}
				text = Module1.GetINI(section, "表格对齐", "居中对齐", schemefilename);
				string left = text;
				if (Operators.CompareString(left, "居中对齐", false) == 0)
				{
					bgalignment = StringAlignment.Center;
				}
				else if (Operators.CompareString(left, "左对齐", false) == 0)
				{
					bgalignment = StringAlignment.Near;
				}
				else if (Operators.CompareString(left, "右对齐", false) == 0)
				{
					bgalignment = StringAlignment.Far;
				}
				else
				{
					bgalignment = StringAlignment.Center;
				}
				text = Module1.GetINI(section, "表格边框", "表格线", schemefilename);
				string left2 = text;
				if (Operators.CompareString(left2, "表格线", false) == 0)
				{
					myborder = "1111";
				}
				else if (Operators.CompareString(left2, "仅横线", false) == 0)
				{
					myborder = "0101";
				}
				else if (Operators.CompareString(left2, "仅竖线", false) == 0)
				{
					myborder = "1010";
				}
				else if (Operators.CompareString(left2, "无线", false) == 0)
				{
					myborder = "0000";
				}
				else if (Strings.Len(text) != 4 | !Versioned.IsNumeric(text))
				{
					myborder = "1111";
				}
				else
				{
					myborder = text;
				}
				text = Module1.GetINI(section, "适合纸张宽度[0-1]", "1", schemefilename);
				zoomtopaperwidth = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "自动调整行高[0-1]", "1", schemefilename);
				autoresizerowheight = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "最小字号", "6", schemefilename);
				minfontsize = Conversions.ToSingle(text);
				text = Module1.GetINI(section, "标题行重复打印[0-1]", "1", schemefilename);
				reppagetitle = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "打印表格背景颜色[0-1]", "1", schemefilename);
				printbackcolor = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "自动调整行高与列宽[0-1]", "1", schemefilename);
				autoformat = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "工资条间距", "100", schemefilename);
				num3 = Conversions.ToSingle(text);
				text = Module1.GetINI(section, "工资条打印零值[0-1]", "0", schemefilename);
				printzero = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "工资条自动换行打印[0-1]", "0", schemefilename);
				gzwrap = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "多栏打印的栏数", "2", schemefilename);
				mycolumns = Conversions.ToInteger(text);
				text = Module1.GetINI(section, "多栏打印的栏间距", "50", schemefilename);
				num4 = Conversions.ToSingle(text);
				text = Module1.GetINI(section, "多栏打印最后一页风格[0-1]", "1", schemefilename);
				lastpagemode = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "跨页打印的固定列数", "2", schemefilename);
				fixedcols = Conversions.ToInteger(text);
				text = Module1.GetINI(section, "表格线颜色", "", schemefilename);
				dataGridView.GridColor = Module1.ConvertStringToColor(text);
				text = Module1.GetINI(section, "补白打印[0-1]", "0", schemefilename);
				isAutoAddEmptyRow = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "表格页脚每页重复打印[0-1]", "0", schemefilename);
				isDrawTableFooterEveryPage = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "双表格线[0-1]", "0", schemefilename);
				isUseDoubleLine = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "双表格线间距(1/100厘米)", "10", schemefilename);
				num10 = (float)Conversion.Val(text);
				text = Module1.GetINI(section, "表格外边框[0-1]", "0", schemefilename);
				outerBorder = (Operators.CompareString(text, "1", false) == 0);
				text = Module1.GetINI(section, "表格外边框线宽(1/100厘米)", "5", schemefilename);
				num11 = (float)Conversion.Val(text);
				text = Module1.GetINI(section, "表格外边框颜色", Module1.ConvertColorToString(Color.Black), schemefilename);
				outerBorderColor = Module1.ConvertStringToColor(text);
				section = "单元格默认边距";
				text = Module1.GetINI(section, "左边距(毫米)", "-1", schemefilename);
				float num12;
				if (Operators.CompareString(text, "-1", false) != 0)
				{
					num12 = (float)Conversion.Val(text);
				}
				text = Module1.GetINI(section, "右边距(毫米)", "-1", schemefilename);
				float num13;
				if (Operators.CompareString(text, "-1", false) != 0)
				{
					num13 = (float)Conversion.Val(text);
				}
				text = Module1.GetINI(section, "上边距(毫米)", "-1", schemefilename);
				float num14;
				if (Operators.CompareString(text, "-1", false) != 0)
				{
					num14 = (float)Conversion.Val(text);
				}
				text = Module1.GetINI(section, "下边距(毫米)", "-1", schemefilename);
				float num15;
				if (Operators.CompareString(text, "-1", false) != 0)
				{
					num15 = (float)Conversion.Val(text);
				}
				if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
				{
					num12 = this.ConvToDisplay(num12 * 10f, true);
					num13 = this.ConvToDisplay(num13 * 10f, true);
					num14 = this.ConvToDisplay(num14 * 10f, false);
					num15 = this.ConvToDisplay(num15 * 10f, false);
				}
				else
				{
					num12 = this.ConvToDisplay(this.ConvertMmToInch(num12) * 100f, true);
					num13 = this.ConvToDisplay(this.ConvertMmToInch(num13) * 100f, true);
					num14 = this.ConvToDisplay(this.ConvertMmToInch(num14) * 100f, false);
					num15 = this.ConvToDisplay(this.ConvertMmToInch(num15) * 100f, false);
				}
				DataGridViewCellStyle defaultCellStyle = dataGridView.DefaultCellStyle;
				checked
				{
					Padding padding = new Padding((int)Math.Round((double)num12), (int)Math.Round((double)num14), (int)Math.Round((double)num13), (int)Math.Round((double)num15));
					defaultCellStyle.Padding = padding;
					section = "打印标题设置";
					text = Module1.GetINI(section, "主标题", "", schemefilename);
					ztitle = text;
					text = Module1.GetINI(section, "主标题字体", "", schemefilename);
					Font font = Module1.ConvertStringToFont(text);
					if (font != null)
					{
						ztitlefont = font;
					}
					text = Module1.GetINI(section, "主标题前景颜色", "", schemefilename);
					Color color3 = Module1.ConvertStringToColor(text);
					color2 = color3;
					this.myforecolor = color2;
					text = Module1.GetINI(section, "主标题文字风格[0-6]", "0", schemefilename);
					num5 = Conversions.ToInteger(text);
					if (num5 > 6 | num5 < 0)
					{
						num5 = 0;
					}
					text = Module1.GetINI(section, "辅标题", "", schemefilename);
					ftitle = text;
					text = Module1.GetINI(section, "辅标题字体", "", schemefilename);
					font = Module1.ConvertStringToFont(text);
					if (font != null)
					{
						ftitlefont = font;
					}
					text = Module1.GetINI(section, "辅标题文字风格[0-6]", "0", schemefilename);
					num6 = Conversions.ToInteger(text);
					if (num6 > 6 | num6 < 0)
					{
						num6 = 0;
					}
					text = Module1.GetINI(section, "标题特效时的深度", "8", schemefilename);
					if (this.PageUnits == VB2008Print.PageExportUnit.Inch)
					{
						this.ShapeDepth = (int)Math.Round((double)Conversions.ToInteger(text) / 2.54);
					}
					else
					{
						this.ShapeDepth = Conversions.ToInteger(text);
					}
					section = "表格页眉";
					text = Module1.GetINI(section, "左边", "", schemefilename);
					tablel = text;
					text = Module1.GetINI(section, "左边对齐[0-2]", "0", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "0";
					}
					tableTopLeftTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "中间", "", schemefilename);
					tablem = text;
					text = Module1.GetINI(section, "中间对齐[0-2]", "1", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "1";
					}
					tableTopMiddleTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "右边", "", schemefilename);
					tabler = text;
					text = Module1.GetINI(section, "右边对齐[0-2]", "2", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "2";
					}
					tableTopRightTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "字体", "", schemefilename);
					font = Module1.ConvertStringToFont(text);
					if (font != null)
					{
						topfont = font;
					}
					section = "表格页脚";
					text = Module1.GetINI(section, "左边", "", schemefilename);
					tableleft = text;
					text = Module1.GetINI(section, "左边对齐[0-2]", "0", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "0";
					}
					tableBottomLeftTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "中间", "", schemefilename);
					tablemiddle = text;
					text = Module1.GetINI(section, "中间对齐[0-2]", "1", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "1";
					}
					tableBottomMiddleTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "右边", "", schemefilename);
					tableright = text;
					text = Module1.GetINI(section, "右边对齐[0-2]", "2", schemefilename);
					if (!Versioned.IsNumeric(text))
					{
						text = "2";
					}
					tableBottomRightTitleAlign = (StringAlignment)Conversions.ToInteger(text);
					text = Module1.GetINI(section, "字体", "", schemefilename);
					font = Module1.ConvertStringToFont(text);
					if (font != null)
					{
						bottomfont = font;
					}
					section = "表格默认设置";
					text = Module1.GetINI(section, "表格总列数", "0", schemefilename);
					int num16 = Conversions.ToInteger(text);
					if (num16 != 0)
					{
						text = Module1.GetINI(section, "标题字段名默认字体", "", schemefilename);
						font = Module1.ConvertStringToFont(text);
						if (font != null)
						{
							dataGridView.ColumnHeadersDefaultCellStyle.Font = font;
						}
						text = Module1.GetINI(section, "标题字段名认前景颜色", "", schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = color3;
						text = Module1.GetINI(section, "标题字段名默认背景颜色", Module1.ConvertColorToString(Color.White), schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						dataGridView.ColumnHeadersDefaultCellStyle.BackColor = color3;
						text = Module1.GetINI(section, "单元格默认字体", "", schemefilename);
						font = Module1.ConvertStringToFont(text);
						if (font != null)
						{
							dataGridView.DefaultCellStyle.Font = font;
						}
						text = Module1.GetINI(section, "单元格默认前景颜色", "", schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						dataGridView.DefaultCellStyle.ForeColor = color3;
						text = Module1.GetINI(section, "单元格默认背景颜色", Module1.ConvertColorToString(Color.White), schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						dataGridView.DefaultCellStyle.BackColor = color3;
						text = Module1.GetINI(section, "默认行高[毫米]", "0", schemefilename);
						if (Versioned.IsNumeric(text))
						{
							float num17 = Conversions.ToSingle(text);
							try
							{
								if (num17 != 0f)
								{
									float num18 = this.ConvToDisplay(unchecked(num17 * 10f), false);
									int num19 = 0;
									int num20 = dataGridView.RowCount - 1;
									for (int i = num19; i <= num20; i++)
									{
										if (num18 < 0f)
										{
											dataGridView.Rows[i].MinimumHeight = (int)Math.Round((double)Math.Abs(num18));
										}
										else if (num18 > 0f)
										{
											dataGridView.Rows[i].Height = (int)Math.Round((double)num18);
										}
									}
								}
							}
							catch (Exception ex3)
							{
							}
						}
						text = Module1.GetINI(section, "奇数行默认前景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						Color color4;
						if (color3.ToArgb() == 0)
						{
							dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = color4;
						}
						else
						{
							dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = color3;
						}
						text = Module1.GetINI(section, "奇数行默认背景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), schemefilename);
						color3 = Module1.ConvertStringToColor(text);
						if (color3.ToArgb() == 0)
						{
							dataGridView.AlternatingRowsDefaultCellStyle.BackColor = color4;
						}
						else
						{
							dataGridView.AlternatingRowsDefaultCellStyle.BackColor = color3;
						}
						text = Strings.Trim(Module1.GetINI("分组汇总排序设置", "第一列前添加行号", "", schemefilename));
						myaddrowid = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
						if (num16 != dataGridView.ColumnCount)
						{
							if (this.IsShowErrorMSG)
							{
								Interaction.MsgBox(string.Concat(new string[]
								{
									"无法应用方案文件中的表格各列详细设置参数（除此之外的其余参数都成功应用了），原因是当前要打印的表格有【",
									Conversions.ToString(dataGridView.ColumnCount),
									"列】而方案文件中保存的表格有〖",
									Conversions.ToString(num16),
									"列〗，两者数不一致，不能使用。\r\n如果您只需要应用方案文件中除要表格各列详细参数设置外的其他参数，您应该将方案文件中的<表格总列数>设为0，或者在保存方案时就不保存表格参数设置"
								}), MsgBoxStyle.OkOnly, "提示信息");
							}
						}
						else
						{
							string[] array = new string[num16 - 1 + 1];
							string[] array2 = new string[num16 - 1 + 1];
							int num21 = 1;
							int num22 = num16;
							for (int j = num21; j <= num22; j++)
							{
								section = "第" + Conversions.ToString(j) + "列";
								array2[j - 1] = Module1.GetINI(section, "名称", "", schemefilename);
								array[j - 1] = Module1.GetINI(section, "显示的文本", "", schemefilename);
							}
							bool flag = false;
							int num23 = 0;
							int num24 = num16 - 1;
							int k = num23;
						IL_14BF:
							while (k <= num24)
							{
								int num25 = k + 1;
								int num26 = num16 - 1;
								int l = num25;
								while (l <= num26)
								{
									if (Operators.CompareString(array2[k], array2[l], false) == 0)
									{
										flag = true;
									IL_14B5:
										if (!flag)
										{
											k++;
											goto IL_14BF;
										}
										goto IL_14C5;
									}
									else
									{
										l++;
									}
								}
								goto IL_14B5;
							}
						IL_14C5:
							if (flag)
							{
								if (this.IsShowErrorMSG)
								{
									Interaction.MsgBox(string.Concat(new string[]
									{
										"当前打印所用方案文件〖",
										schemefilename,
										"〗存在问题，列名称为【",
										array2[k],
										"】的有多列，本控件要求列名称必须唯一，请修改该方案再使用。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
									}), MsgBoxStyle.OkOnly, "提示信息");
								}
							}
							else
							{
								flag = false;
								int num27 = 0;
								int num28 = num16 - 1;
								k = num27;
							IL_1567:
								while (k <= num28)
								{
									int num29 = k + 1;
									int num30 = num16 - 1;
									int m = num29;
									while (m <= num30)
									{
										if (Operators.CompareString(array[k], array[m], false) == 0)
										{
											flag = true;
										IL_155D:
											if (!flag)
											{
												k++;
												goto IL_1567;
											}
											goto IL_156D;
										}
										else
										{
											m++;
										}
									}
									goto IL_155D;
								}
							IL_156D:
								if (flag)
								{
									if (this.IsShowErrorMSG)
									{
										Interaction.MsgBox(string.Concat(new string[]
										{
											"当前打印所用方案文件〖",
											schemefilename,
											"〗存在问题，列显示名称为【",
											array2[k],
											"】的有多列，本控件要求列的显示名称必须唯一，否则会产生问题，请修改该方案再使用。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
										}), MsgBoxStyle.OkOnly, "提示信息");
									}
								}
								else
								{
									int num31 = 0;
									int num32 = num16 - 1;
									int j = num31;
								IL_1621:
									while (j <= num32)
									{
										flag = false;
										text = array2[j];
										int num33 = 0;
										int num34 = num16 - 1;
										k = num33;
										while (k <= num34)
										{
											if (Operators.CompareString(text, dataGridView.Columns[k].Name, false) == 0)
											{
												flag = true;
											IL_1614:
												if (flag)
												{
													j++;
													goto IL_1621;
												}
												if (this.IsShowErrorMSG)
												{
													Interaction.MsgBox(string.Concat(new string[]
													{
														"当前打印所用方案文件〖",
														schemefilename,
														"〗存在问题，方案文件中保存的列名称为【",
														array2[j],
														"】的列在当前要打印的DataGridView表格中不存在，因此该打印方案与当前打印的表格不兼容，不能使用方案中的列详细设置参数。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
													}), MsgBoxStyle.OkOnly, "提示信息");
												}
												goto IL_1C53;
											}
											else
											{
												k++;
											}
										}
										goto IL_1614;
									}
									int num35 = 0;
									int num36 = dataGridView.ColumnCount - 1;
									for (j = num35; j <= num36; j++)
									{
										section = "第" + Conversions.ToString(j + 1) + "列";
										string ini = Module1.GetINI(section, "名称", "", schemefilename);
										string ini2 = Module1.GetINI(section, "显示的文本", "", schemefilename);
										dataGridView.Columns[ini].HeaderText = ini2;
										dataGridView.Columns[ini].DisplayIndex = j;
										text = Module1.GetINI(section, "是否打印[0-1]", "1", schemefilename);
										if (Operators.CompareString(text, "1", false) == 0)
										{
											dataGridView.Columns[ini].Visible = true;
										}
										else
										{
											dataGridView.Columns[ini].Visible = false;
										}
										text = Module1.GetINI(section, "默认字体", "", schemefilename);
										font = Module1.ConvertStringToFont(text);
										if (font != null)
										{
											dataGridView.Columns[ini].DefaultCellStyle.Font = font;
										}
										text = Module1.GetINI(section, "默认前景色", "", schemefilename);
										color3 = Module1.ConvertStringToColor(text);
										dataGridView.Columns[ini].DefaultCellStyle.ForeColor = color3;
										text = Module1.GetINI(section, "默认背景色", Module1.ConvertColorToString(Color.White), schemefilename);
										color3 = Module1.ConvertStringToColor(text);
										dataGridView.Columns[ini].DefaultCellStyle.BackColor = color3;
										text = Module1.GetINI(section, "文本对齐方式", "", schemefilename);
										string left3 = text;
										if (Operators.CompareString(left3, "居中对齐", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
										}
										else if (Operators.CompareString(left3, "左对齐", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
										}
										else if (Operators.CompareString(left3, "未设置", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
										}
										else if (Operators.CompareString(left3, "右对齐", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
										}
										else
										{
											dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
										}
										text = Module1.GetINI(section, "文本允许换行", "", schemefilename);
										string left4 = text;
										if (Operators.CompareString(left4, "未设置", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
										}
										else if (Operators.CompareString(left4, "允许", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
										}
										else if (Operators.CompareString(left4, "不允许", false) == 0)
										{
											dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
										}
										text = Module1.GetINI(section, "列宽(毫米)", "", schemefilename);
										if (Versioned.IsNumeric(text))
										{
											try
											{
												dataGridView.Columns[ini].Width = (int)Math.Round((double)this.ConvFromMMToDisplay(Convert.ToSingle(Conversions.ToDecimal(text))));
											}
											catch (Exception ex4)
											{
											}
										}
									}
									section = "分组汇总排序设置";
									myhzcolumns = Module1.GetINI(section, "要汇总的列", "", schemefilename);
									text = Module1.GetINI(section, "汇总行字体", "", schemefilename);
									font = Module1.ConvertStringToFont(text);
									if (font == null)
									{
										font = new Font("黑体", dataGridView.DefaultCellStyle.Font.Size, FontStyle.Bold);
									}
									myhzfont = font;
									text = Module1.GetINI(section, "汇总行前景颜色", "", schemefilename);
									color3 = Module1.ConvertStringToColor(text);
									if (color3.ToArgb() == 0)
									{
										color3 = dataGridView.DefaultCellStyle.ForeColor;
									}
									myhzforecolor = color3;
									text = Module1.GetINI(section, "汇总行背景颜色", "", schemefilename);
									color3 = Module1.ConvertStringToColor(text);
									if (color3.ToArgb() == 0)
									{
										color3 = dataGridView.DefaultCellStyle.BackColor;
									}
									myhzbackcolor = color3;
									text = Module1.GetINI(section, "汇总行数字对齐方式[0-2]", "1", schemefilename);
									if (!Versioned.IsNumeric(text))
									{
										text = "1";
									}
									sumNumberAlign = (StringAlignment)Conversions.ToInteger(text);
									mysortcolumn = Module1.GetINI(section, "要排序的列", "", schemefilename);
									text = Strings.Trim(Module1.GetINI(section, "升序排序", "", schemefilename));
									mysorttype = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
									mygroupcolumn = Module1.GetINI(section, "要分组列", "", schemefilename);
									text = Strings.Trim(Module1.GetINI(section, "每组换新页打印", "", schemefilename));
									mygroupnewpage = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
									text = Strings.Trim(Module1.GetINI(section, "第一列前添加行号", "", schemefilename));
									myaddrowid = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
									text = Strings.Trim(Module1.GetINI(section, "每组行号重新编号", "", schemefilename));
									myaddrownew = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
								}
							}
						}
					}
				}
			}
			catch (Exception ex5)
			{
				if (this.IsShowErrorMSG)
				{
					Interaction.MsgBox("使用方案文件【" + schemefilename + "】进行打印输出时，读方案文件时出现异常，可能与当前要打印的表格不兼容，将采用默认的设置进行打印输出", MsgBoxStyle.OkOnly, "提示信息");
				}
			}
		IL_1C53:
			if (this.PageUnits != VB2008Print.PageExportUnit.CentiMeter)
			{
				num3 = (float)((double)num3 / 2.54);
				num4 = (float)((double)num4 / 2.54);
				num10 = (float)((double)num10 / 2.54);
				num11 = (float)((double)num11 / 2.54);
			}
			bool isAutoAddEmptyRow2 = this.IsAutoAddEmptyRow;
			this.IsAutoAddEmptyRow = isAutoAddEmptyRow;
			bool isDrawTableFooterEveryPage2 = this.IsDrawTableFooterEveryPage;
			this.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage;
			this.IsUseDoubleLine = isUseDoubleLine;
			this.DoubleLineSpace = num10;
			this.OuterBorder = outerBorder;
			this.OuterBorderColor = outerBorderColor;
			this.OuterBorderWidth = num11;
			float result = this.StartDo(dataGridView, mysortcolumn, mysorttype, mygroupcolumn, myhzcolumns, myaddrownew, mygroupnewpage, myhzfont, myhzforecolor, myhzbackcolor, autoformat, num2, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, num5, num6, fixedcols, myaddrowid, mycolumns, num4, lastpagemode, num3, printzero, columnheadertree, tableTopLeftTitleAlign, tableTopMiddleTitleAlign, tableTopRightTitleAlign, tableBottomLeftTitleAlign, tableBottomMiddleTitleAlign, tableBottomRightTitleAlign, sumNumberAlign, gzwrap, 0f);
			dataGridView.Dispose();
			this.IsAutoAddEmptyRow = isAutoAddEmptyRow2;
			this.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage2;
			bool isUseDoubleLine2;
			this.IsUseDoubleLine = isUseDoubleLine2;
			float doubleLineSpace;
			this.DoubleLineSpace = doubleLineSpace;
			bool outerBorder2;
			this.OuterBorder = outerBorder2;
			Color outerBorderColor2;
			this.OuterBorderColor = outerBorderColor2;
			float outerBorderWidth;
			this.OuterBorderWidth = outerBorderWidth;
			this.myforecolor = color;
			this.myshapedepth = num;
			return result;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000AFDE0 File Offset: 0x000ADFE0
		public float StartDo(DataGridView dgvtoprint, string mysortcolumn, bool mysorttype, string mygroupcolumn, string myhzcolumns, bool myaddrownew, bool mygroupnewpage, Font myhzfont, Color myhzforecolor, Color myhzbackcolor, bool autoformat, int printtype, string ztitle, Font ztitlefont, string ftitle, Font ftitlefont, StringAlignment bgalignment, string myborder, bool zoomtopaperwidth, bool autoresizerowheight, Font topfont, string tablel, string tablem, string tabler, Font bottomfont, string tableleft, string tablemiddle, string tableright, float minfontsize, bool reppagetitle, bool printbackcolor, int mytitletextstyle, int mysubtitlestyle, int fixedcols, bool myaddrowid, int mycolumns, float columnspace, bool lastpagemode, float linespace, bool printzero, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, StringAlignment SumNumberAlign, bool gzwrap, float printwidth = 0f)
		{
			if (ztitlefont == null)
			{
				ztitlefont = new Font("黑体", 18f, FontStyle.Bold);
			}
			if (ftitlefont == null)
			{
				ftitlefont = new Font("隶书", 15f, FontStyle.Regular);
			}
			if (topfont == null)
			{
				topfont = new Font("宋体", 10f, FontStyle.Regular);
			}
			if (bottomfont == null)
			{
				bottomfont = new Font("宋体", 10f, FontStyle.Regular);
			}
			if (Operators.CompareString(mysortcolumn + "", "", false) != 0)
			{
				try
				{
					if (mysorttype)
					{
						dgvtoprint.Sort(dgvtoprint.Columns[mysortcolumn], ListSortDirection.Ascending);
					}
					else
					{
						dgvtoprint.Sort(dgvtoprint.Columns[mysortcolumn], ListSortDirection.Descending);
					}
				}
				catch (Exception ex)
				{
				}
			}
			checked
			{
				float result;
				if (dgvtoprint.Rows.Count <= 0)
				{
					result = 0f;
				}
				else if (Module1.GetDGVVisibleRows(dgvtoprint) <= 0)
				{
					result = 0f;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = dgvtoprint.Columns.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (dgvtoprint.Columns[i].Visible)
						{
							num++;
						}
					}
					if (num == 0)
					{
						result = 0f;
					}
					else
					{
						TreeView columnheadertree2 = new TreeView();
						if (columnheadertree != null)
						{
							if (myaddrowid)
							{
								Module1.CopyTreeView(columnheadertree, ref columnheadertree2, true);
							}
							else
							{
								Module1.CopyTreeView(columnheadertree, ref columnheadertree2, false);
							}
						}
						else
						{
							columnheadertree2 = null;
						}
						int fromrow = 0;
						if (Operators.CompareString(mygroupcolumn, "", false) != 0)
						{
							try
							{
								Conversions.ToString(dgvtoprint.Columns[mygroupcolumn].Width);
							}
							catch (Exception ex2)
							{
								mygroupcolumn = "";
							}
						}
						float num4;
						if (Operators.CompareString(mygroupcolumn, "", false) == 0)
						{
							if (myaddrowid)
							{
								Module1.AddDGVRowID(dgvtoprint);
							}
							Module1.CreateHz(dgvtoprint, dgvtoprint.RowCount, myhzcolumns, myhzfont, myhzforecolor, myhzbackcolor, SumNumberAlign);
							num4 = this.BeginDo(dgvtoprint, autoformat, printtype, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, fixedcols, myaddrowid, mycolumns, columnspace, lastpagemode, linespace, printzero, columnheadertree2, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, gzwrap, printwidth);
						}
						else
						{
							string ss = ztitle;
							string ss2 = ftitle;
							string ss3 = tablel;
							string ss4 = tablem;
							string ss5 = tabler;
							string ss6 = tableleft;
							string ss7 = tablemiddle;
							string ss8 = tableright;
							string dgvfirstColumnName = Module1.GetDGVFirstColumnName(dgvtoprint);
							Module1.CreateHz(dgvtoprint, dgvtoprint.RowCount, myhzcolumns, myhzfont, myhzforecolor, myhzbackcolor, SumNumberAlign);
							Module1.CreateFzHz(dgvtoprint, mygroupcolumn, myhzcolumns, myhzfont, myhzforecolor, myhzbackcolor, myaddrowid, myaddrownew, SumNumberAlign);
							if (mygroupnewpage)
							{
								if (Operators.CompareString(myhzcolumns + "", "", false) != 0)
								{
									dgvtoprint.Rows.Remove(dgvtoprint.Rows[dgvtoprint.RowCount - 1]);
								}
								bool flag = true;
								int num5 = 0;
								int num6 = dgvtoprint.RowCount - 1;
								for (int j = num5; j <= num6; j++)
								{
									if (Operators.CompareString(Conversions.ToString(dgvtoprint.Rows[j].Tag) + "", "分组", false) == 0)
									{
										int torow = j;
										string groupcontent = Conversions.ToString(dgvtoprint.Rows[j].Cells[mygroupcolumn].FormattedValue);
										Module1.CopyDataGridView(dgvtoprint, this.mydgv2, fromrow, torow, false);
										if (Module1.GetDGVVisibleRows(this.mydgv2) > 0)
										{
											if (flag)
											{
												flag = false;
											}
											else
											{
												this.MyNewPage();
											}
											ztitle = VB2008Print.ReplaceGroup(ss, groupcontent);
											ftitle = VB2008Print.ReplaceGroup(ss2, groupcontent);
											tablel = VB2008Print.ReplaceGroup(ss3, groupcontent);
											tablem = VB2008Print.ReplaceGroup(ss4, groupcontent);
											tabler = VB2008Print.ReplaceGroup(ss5, groupcontent);
											tableleft = VB2008Print.ReplaceGroup(ss6, groupcontent);
											tablemiddle = VB2008Print.ReplaceGroup(ss7, groupcontent);
											tableright = VB2008Print.ReplaceGroup(ss8, groupcontent);
											num4 = this.BeginDo(this.mydgv2, autoformat, printtype, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, fixedcols, myaddrowid, mycolumns, columnspace, lastpagemode, linespace, printzero, columnheadertree2, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, gzwrap, printwidth);
										}
										fromrow = j + 1;
									}
								}
							}
							else if (Operators.CompareString(myhzcolumns + "", "", false) != 0)
							{
								if (myaddrowid)
								{
									dgvtoprint.Rows[dgvtoprint.RowCount - 1].Cells[0].Value = "总计";
									dgvtoprint.Rows[dgvtoprint.RowCount - 1].Cells[dgvfirstColumnName].Value = "";
								}
								num4 = this.BeginDo(dgvtoprint, autoformat, printtype, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, fixedcols, myaddrowid, mycolumns, columnspace, lastpagemode, linespace, printzero, columnheadertree2, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, gzwrap, printwidth);
							}
							else
							{
								bool flag2 = true;
								int num7 = 0;
								int num8 = dgvtoprint.RowCount - 1;
								for (int k = num7; k <= num8; k++)
								{
									if (Operators.CompareString(Conversions.ToString(dgvtoprint.Rows[k].Tag) + "", "分组", false) == 0)
									{
										int torow = k;
										string groupcontent = Conversions.ToString(dgvtoprint.Rows[k].Cells[mygroupcolumn].FormattedValue);
										Module1.CopyDataGridView(dgvtoprint, this.mydgv2, fromrow, torow, false);
										if (Module1.GetDGVVisibleRows(this.mydgv2) > 0)
										{
											if (flag2)
											{
												flag2 = false;
											}
											else
											{
												this.NewRow(this.MeasureText("测试", new Font("宋体", 12f)).Height);
											}
											ztitle = VB2008Print.ReplaceGroup(ss, groupcontent);
											ftitle = VB2008Print.ReplaceGroup(ss2, groupcontent);
											tablel = VB2008Print.ReplaceGroup(ss3, groupcontent);
											tablem = VB2008Print.ReplaceGroup(ss4, groupcontent);
											tabler = VB2008Print.ReplaceGroup(ss5, groupcontent);
											tableleft = VB2008Print.ReplaceGroup(ss6, groupcontent);
											tablemiddle = VB2008Print.ReplaceGroup(ss7, groupcontent);
											tableright = VB2008Print.ReplaceGroup(ss8, groupcontent);
											num4 = this.BeginDo(this.mydgv2, autoformat, printtype, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, fixedcols, myaddrowid, mycolumns, columnspace, lastpagemode, linespace, printzero, columnheadertree2, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, gzwrap, printwidth);
										}
										fromrow = k + 1;
									}
								}
							}
						}
						result = num4;
					}
				}
				return result;
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000B0484 File Offset: 0x000AE684
		private static string ReplaceGroup(string ss, string groupcontent)
		{
			string find = "$组名$";
			return Strings.Replace(ss, find, groupcontent, 1, -1, CompareMethod.Binary);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000B04A8 File Offset: 0x000AE6A8
		private float BeginDo(DataGridView myprintdgv, bool autoformat, int printtype, string ztitle, Font ztitlefont, string ftitle, Font ftitlefont, StringAlignment bgalignment, string myborder, bool zoomtopaperwidth, bool autoresizerowheight, Font topfont, string tablel, string tablem, string tabler, Font bottomfont, string tableleft, string tablemiddle, string tableright, float minfontsize, bool reppagetitle, bool printbackcolor, int mytitletextstyle, int mysubtitlestyle, int fixedcols, bool myaddrowid, int mycolumns, float columnspace, bool lastpagemode, float linespace, bool printzero, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool gzwrap, float printwidth)
		{
			if (autoformat)
			{
				myprintdgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
				myprintdgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
			}
			checked
			{
				float result=0;
				switch (printtype)
				{
					case 1:
						if (printwidth <= 0f)
						{
							result = this.PrintDGV(myprintdgv, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, false, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign);
						}
						else
						{
							result = this.PrintDGVFixedWidth(myprintdgv, printwidth, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, false, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign);
						}
						break;
					case 2:
						result = this.PrintDGVColS(myprintdgv, mycolumns, ztitle, ztitlefont, ftitle, ftitlefont, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, 0f, columnspace, myborder, minfontsize, reppagetitle, lastpagemode, printbackcolor, autoresizerowheight, mytitletextstyle, mysubtitlestyle, false, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign);
						break;
					case 3:
						{
							int num = fixedcols;
							if (myaddrowid)
							{
								fixedcols++;
							}
							result = this.PrintDGVPages(myprintdgv, fixedcols, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, mytitletextstyle, mysubtitlestyle, false, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign);
							fixedcols = num;
							break;
						}
					case 4:
						if (!gzwrap)
						{
							result = this.PrintDGVgzt(myprintdgv, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, minfontsize, reppagetitle, linespace, printzero, printbackcolor, mytitletextstyle, mysubtitlestyle, false, columnheadertree);
						}
						else
						{
							result = this.PrintDGVgzt2(myprintdgv, ztitle, ztitlefont, ftitle, ftitlefont, myborder, minfontsize, reppagetitle, linespace, printzero, printbackcolor, mytitletextstyle, mysubtitlestyle, false);
						}
						break;
				}
				return result;
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000B0670 File Offset: 0x000AE870
		public float PrintDGV(DataGridView dgvToPrint, string title, Font titleFont, StringAlignment alignment, TreeView columnheadertree = null)
		{
			return this.PrintDGV(dgvToPrint, title, titleFont, alignment, "1111", 0f, true, true, 0, 0, false, columnheadertree);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000B069C File Offset: 0x000AE89C
		public float PrintDGV(DataGridView dgvToPrint, string title, Font titleFont, StringAlignment alignment, string myborder, float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGV(dgvToPrint, title, titleFont, "", this.TextFont, alignment, myborder, false, false, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000B0704 File Offset: 0x000AE904
		public float PrintDGV(DataGridView dgvToPrint, string title, Font titleFont, StringAlignment alignment, string myborder, bool zoomtopaperwidth, bool autoresizerowheight, float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGV(dgvToPrint, title, titleFont, "", this.TextFont, alignment, myborder, zoomtopaperwidth, autoresizerowheight, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000B0770 File Offset: 0x000AE970
		public float PrintDGV(DataGridView dgvToPrint, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomtopaperwidth, bool autoresizerowheight, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far)
		{
			int[] thecol = new int[201];
			return this.PrintDGVOut(dgvToPrint, 0, thecol, 0, 0, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomtopaperwidth, autoresizerowheight, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, 0f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, 0f, 0f);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000B07F4 File Offset: 0x000AE9F4
		public float PrintDGV(DataGridView dgvToPrint, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomtopaperwidth, bool autoresizerowheight, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, Font mysumfont, Color mysumforecolor, Color mysumbackcolor, string mysumcolumns = "", bool myaddrowid = false, bool myaddrowmode = false, string mysortcolumn = "", ListSortDirection mysortmode = ListSortDirection.Ascending, string mygroupcolumn = "", bool mygroupnewpage = false, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, bool autoformat = true, int titletextstyle = 0, int subtitlestyle = 0, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far, StringAlignment SumNumberAlign = StringAlignment.Center)
		{
			float result;
			if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(dgvToPrint, this.tempdgv);
				bool mysorttype = mysortmode == ListSortDirection.Ascending;
				float columnspace = 10f;
				float linespace = 10f;
				float num = this.StartDo(this.tempdgv, mysortcolumn, mysorttype, mygroupcolumn, mysumcolumns, myaddrowmode, mygroupnewpage, mysumfont, mysumforecolor, mysumbackcolor, autoformat, 1, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, 0, myaddrowid, 1, columnspace, true, linespace, true, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, SumNumberAlign, false, 0f);
				result = num;
			}
			return result;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000B08AC File Offset: 0x000AEAAC
		public float PrintDGVFixedWidth(DataGridView dgvToPrint, string title, Font titleFont, TreeView columnheadertree = null)
		{
			return this.PrintDGVFixedWidth(dgvToPrint, title, titleFont, "1111", 0f, true, true, 0, columnheadertree);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000B08D4 File Offset: 0x000AEAD4
		public float PrintDGVFixedWidth(DataGridView dgvToPrint, string title, Font titleFont, string myborder, float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, TreeView columnheadertree = null)
		{
			checked
			{
				float result;
				if (dgvToPrint == null)
				{
					result = 0f;
				}
				else
				{
					float num = 0f;
					int num2 = 0;
					int num3 = dgvToPrint.ColumnCount - 1;
					for (int i = num2; i <= num3; i++)
					{
						DataGridViewColumn dataGridViewColumn = dgvToPrint.Columns[i];
						unchecked
						{
							if (dataGridViewColumn.Visible && Operators.ConditionalCompareObjectNotEqual(dataGridViewColumn.Tag, "不打印", false))
							{
								num += (float)dataGridViewColumn.Width;
							}
						}
					}
					num = this.ConvFromDisplay(num, true);
					result = this.PrintDGVFixedWidth(dgvToPrint, num, title, titleFont, "", this.TextFont, StringAlignment.Center, myborder, false, false, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, reppagetitle, PrintBackColor, titletextstyle, 0, false, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
				}
				return result;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000B09A4 File Offset: 0x000AEBA4
		public float PrintDGVFixedWidth(DataGridView dgvToPrint, float printwidth, string title, Font titleFont, StringAlignment alignment, string myborder, bool zoomtoFixedwidth, bool autoresizerowheight, float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGVFixedWidth(dgvToPrint, printwidth, title, titleFont, "", this.TextFont, alignment, myborder, zoomtoFixedwidth, autoresizerowheight, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, reppagetitle, PrintBackColor, titletextstyle, 0, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000B0A10 File Offset: 0x000AEC10
		public float PrintDGVFixedWidth(DataGridView dgvToPrint, float printwidth, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomtofixedwidth, bool autoresizerowheight, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far)
		{
			int[] thecol = new int[201];
			return this.PrintDGVOut(dgvToPrint, 0, thecol, 0, 0, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomtofixedwidth, autoresizerowheight, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, 0f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, 0f, printwidth);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000B0A90 File Offset: 0x000AEC90
		public float PrintDGVFixedWidth(DataGridView dgvToPrint, float printwidth, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomtoFixedwidth, bool autoresizerowheight, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, Font mysumfont, Color mysumforecolor, Color mysumbackcolor, string mysumcolumns = "", bool myaddrowid = false, bool myaddrowmode = false, string mysortcolumn = "", ListSortDirection mysortmode = ListSortDirection.Ascending, string mygroupcolumn = "", bool mygroupnewpage = false, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, bool autoformat = true, int titletextstyle = 0, int subtitlestyle = 0, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far, StringAlignment SumNumberAlign = StringAlignment.Center)
		{
			float result;
			if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(dgvToPrint, this.tempdgv);
				bool mysorttype = mysortmode == ListSortDirection.Ascending;
				float columnspace = 10f;
				float linespace = 10f;
				float num = this.StartDo(this.tempdgv, mysortcolumn, mysorttype, mygroupcolumn, mysumcolumns, myaddrowmode, mygroupnewpage, mysumfont, mysumforecolor, mysumbackcolor, autoformat, 1, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomtoFixedwidth, autoresizerowheight, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, 0, myaddrowid, 1, columnspace, true, linespace, true, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, SumNumberAlign, false, printwidth);
				result = num;
			}
			return result;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000B0B44 File Offset: 0x000AED44
		public float PrintDGVColS(DataGridView DGVtoprint, int columns, string title, Font titleFont, float columnwidth = 0f, float columnspace = 0f, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, bool LastPageMode = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGVColS(DGVtoprint, columns, title, titleFont, "", this.TextFont, columnwidth, columnspace, myborder, minfontsize, reppagetitle, LastPageMode, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000B0B80 File Offset: 0x000AED80
		public float PrintDGVColS(DataGridView DGVtoprint, int columns, string title, Font titleFont, string subtitle, Font subtitlefont, float columnwidth = 0f, float columnspace = 0f, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, bool LastPageMode = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			string lefttitle = "";
			string middletitle = "";
			string righttitle = "";
			Font textFont = this.TextFont;
			string bl = "";
			string bm = "";
			string br = "";
			Font textFont2 = this.TextFont;
			return this.PrintDGVColS(DGVtoprint, columns, title, titleFont, subtitle, subtitlefont, textFont, lefttitle, middletitle, righttitle, textFont2, bl, bm, br, columnwidth, columnspace, myborder, minfontsize, reppagetitle, LastPageMode, PrintBackColor, true, titletextstyle, subtitlestyle, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000B0C00 File Offset: 0x000AEE00
		public float PrintDGVColS(DataGridView DGVtoprint, int columns, string title, Font titleFont, string subtitle, Font subtitlefont, Font topfont, string lefttitle, string middletitle, string righttitle, float columnwidth = 0f, float columnspace = 0f, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, bool LastPageMode = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			string bl = "";
			string bm = "";
			string br = "";
			Font textFont = this.TextFont;
			return this.PrintDGVColS(DGVtoprint, columns, title, titleFont, subtitle, subtitlefont, topfont, lefttitle, middletitle, righttitle, textFont, bl, bm, br, columnwidth, columnspace, myborder, minfontsize, reppagetitle, LastPageMode, PrintBackColor, true, titletextstyle, subtitlestyle, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000B0C64 File Offset: 0x000AEE64
		public float PrintDGVColS(DataGridView DGVtoprint, int columns, string title, Font titleFont, string subtitle, Font subtitlefont, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, Font mysumfont, Color mysumforecolor, Color mysumbackcolor, string mysumcolumns = "", bool myaddrowid = false, bool myaddrowmode = false, string mysortcolumn = "", ListSortDirection mysortmode = ListSortDirection.Ascending, string mygroupcolumn = "", bool mygroupnewpage = false, string bl = "", string bm = "", string br = "", float columnspace = 0f, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, bool LastPageMode = false, bool PrintBackColor = false, bool autoresizerowheight = true, bool autoformat = true, int titletextstyle = 0, int subtitlestyle = 0, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far, StringAlignment SumNumberAlign = StringAlignment.Center)
		{
			float result;
			if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(DGVtoprint, this.tempdgv);
				bool mysorttype = mysortmode == ListSortDirection.Ascending;
				float linespace = 10f;
				float num = this.StartDo(this.tempdgv, mysortcolumn, mysorttype, mygroupcolumn, mysumcolumns, myaddrowmode, mygroupnewpage, mysumfont, mysumforecolor, mysumbackcolor, autoformat, 2, title, titleFont, subtitle, subtitlefont, StringAlignment.Center, myborder, false, autoresizerowheight, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, 0, myaddrowid, columns, columnspace, LastPageMode, linespace, true, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, SumNumberAlign, false, 0f);
				result = num;
			}
			return result;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000B0D14 File Offset: 0x000AEF14
		public float PrintDGVColS(DataGridView DGVtoprint, int columns, string title, Font titleFont, string subtitle, Font subtitlefont, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl = "", string bm = "", string br = "", float columnwidth = 0f, float columnspace = 0f, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, bool LastPageMode = false, bool PrintBackColor = false, bool autoresizerowheight = true, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far)
		{
			checked
			{
				float result;
				if (this.CancelDocument)
				{
					result = 0f;
				}
				else
				{
					if (titleFont == null)
					{
						titleFont = new Font("黑体", 18f, FontStyle.Bold);
					}
					if (subtitlefont == null)
					{
						subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
					}
					if (topfont == null)
					{
						topfont = new Font("宋体", 10f, FontStyle.Regular);
					}
					if (bottomfont == null)
					{
						bottomfont = new Font("宋体", 10f, FontStyle.Regular);
					}
					mytree mytree = new mytree(columnheadertree, DGVtoprint);
					if (mytree.GetColumns() != DGVtoprint.ColumnCount)
					{
						columnheadertree = null;
					}
					Module1.CopyDataGridView(DGVtoprint, this.myms);
					if (columnheadertree != null)
					{
					}
					if (autoformat)
					{
						this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
					StringAlignment stringAlignment = StringAlignment.Center;
					float num = 0f;
					int columnCount = this.myms.ColumnCount;
					int[] array = new int[columnCount + 1];
					int[] array2 = new int[this.myms.RowCount + 1];
					int num2 = 0;
					int num3 = columnCount - 1;
					for (int i = num2; i <= num3; i++)
					{
						array[i] = this.myms.Columns[i].Width;
					}
					array2[0] = Conversions.ToInteger(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0));
					int num4 = 0;
					int num5 = this.myms.RowCount - 1;
					for (int i = num4; i <= num5; i++)
					{
						array2[i] = this.myms.Rows[i].Height;
					}
					if (columns <= 0)
					{
						columns = 1;
					}
					if (columnwidth == 0f)
					{
						columnwidth = unchecked(this.PaperPrintWidth - columnspace * (float)(checked(columns - 1))) / (float)columns;
					}
					float[] array3 = new float[columnCount - 1 + 1];
					int[] array4 = new int[columnCount - 1 + 1];
					int num6 = 0;
					int num7 = columnCount - 1;
					for (int i = num6; i <= num7; i++)
					{
						unchecked
						{
							if (this.myms.Columns[i].Visible)
							{
								DataGridViewColumn dataGridViewColumn = this.myms.Columns[i];
								float num8 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
								array4[i] = dataGridViewColumn.Width;
								num += num8;
								array3[i] = num8;
							}
						}
					}
					float num9 = columnwidth / num;
					int num10 = 0;
					int num11 = columnCount - 1;
					for (int i = num10; i <= num11; i++)
					{
						unchecked
						{
							array3[i] *= num9;
						}
						this.myms.Columns[i].Width = (int)Math.Round((double)(unchecked((float)array4[i] * num9)));
					}
					if (autoresizerowheight)
					{
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
					this.Currentx = 0f;
					if (columns > 1)
					{
						StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
						num = 0f;
						float num12 = this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
						stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
						int num13 = 0;
						int num14 = columnCount - 1;
						for (int i = num13; i <= num14; i++)
						{
							unchecked
							{
								if (this.myms.Columns[i].Visible)
								{
									num += this.ConvFromDisplay((float)this.myms.Columns[i].Width, true);
								}
							}
						}
						string text = "";
						StringAlignment myHalg = StringAlignment.Near;
						bool flag = VB2008Print.CanSpanPrint(lefttitle, middletitle, righttitle, ref text, ref myHalg);
						float num15;
						if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
						{
							num15 = 0f;
							flag = false;
						}
						else if (flag)
						{
							num15 = this.MeasureCell(text, topfont, this.PaperPrintWidth, stringFormat).Height;
							if (Operators.CompareString(lefttitle, "", false) != 0)
							{
								myHalg = TableTopLeftTitleAlign;
							}
							else if (Operators.CompareString(middletitle, "", false) != 0)
							{
								myHalg = TableTopMiddleTitleAlign;
							}
							else if (Operators.CompareString(righttitle, "", false) != 0)
							{
								myHalg = TableTopRightTitleAlign;
							}
						}
						else
						{
							SizeF sizeF = this.MeasureCell(lefttitle, topfont, this.PaperPrintWidth / 3f, stringFormat);
							SizeF sizeF2 = this.MeasureCell(middletitle, topfont, this.PaperPrintWidth / 3f, stringFormat);
							num15 = sizeF.Height;
							float height = sizeF2.Height;
							if (num15 < height)
							{
								num15 = height;
							}
							height = this.MeasureCell(righttitle, topfont, this.PaperPrintWidth / 3f, stringFormat).Height;
							if (num15 < height)
							{
								num15 = height;
							}
						}
						float height2 = this.MeasureText(title, titleFont, this.PaperPrintWidth, stringFormat).Height;
						float num16;
						if (height2 == 0f)
						{
							num16 = 0f;
						}
						else
						{
							num16 = (float)((double)this.MeasureText("游", titleFont, num, stringFormat).Height / 2.5);
						}
						float height3 = this.MeasureText(subtitle, subtitlefont, this.PaperPrintWidth, stringFormat).Height;
						float num17;
						if (height3 == 0f)
						{
							num17 = 0f;
						}
						else
						{
							num17 = (float)((double)this.MeasureText("平", subtitlefont, this.PaperPrintWidth, stringFormat).Height / 2.5);
						}
						string text2 = "";
						StringAlignment myHalg2 = StringAlignment.Near;
						bool flag2 = VB2008Print.CanSpanPrint(bl, bm, br, ref text2, ref myHalg2);
						float num18;
						float num19;
						int num20;
						int num21;
						unchecked
						{
							if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(br, "", false) == 0 & Operators.CompareString(bm, "", false) == 0)
							{
								num18 = 0f;
								flag2 = false;
							}
							else
							{
								if (flag2)
								{
									num18 = this.MeasureCell(text2, bottomfont, this.PaperPrintWidth, stringFormat).Height;
									if (Operators.CompareString(bl, "", false) != 0)
									{
										myHalg2 = TableBottomLeftTitleAlign;
									}
									else if (Operators.CompareString(bm, "", false) != 0)
									{
										myHalg2 = TableBottomMiddleTitleAlign;
									}
									else if (Operators.CompareString(br, "", false) != 0)
									{
										myHalg2 = TableBottomRightTitleAlign;
									}
								}
								else
								{
									SizeF sizeF = this.MeasureCell(bl, bottomfont, this.PaperPrintWidth / 3f, stringFormat);
									SizeF sizeF2 = this.MeasureCell(bm, bottomfont, this.PaperPrintWidth / 3f, stringFormat);
									num18 = sizeF.Height;
									float height = sizeF2.Height;
									if (num18 < height)
									{
										num18 = height;
									}
									height = this.MeasureCell(br, bottomfont, this.PaperPrintWidth / 3f, stringFormat).Height;
									if (num18 < height)
									{
										num18 = height;
									}
								}
								num18 += this.MeasureText("测试", new Font("宋体", 12f)).Height / 8f;
							}
							if (this.OuterBorder)
							{
								num15 = num15 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
								num18 = num18 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
							}
							else if (this.IsUseDoubleLine)
							{
								num15 += this.DoubleLineSpace / 2f;
								num18 += this.DoubleLineSpace / 2f;
							}
							num19 = height2 + num16 + height3 + num17 + num15 + Conversions.ToSingle(Interaction.IIf(LastPageMode & this.IsDrawTableFooterEveryPage, num18, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0))));
							num20 = -1;
							num21 = 0;
						}
						int num22 = this.myms.RowCount - 1;
						for (int i = num21; i <= num22; i++)
						{
							if (this.myms.Rows[i].Visible)
							{
								num20 = i;
							IL_85C:
								unchecked
								{
									if (num20 == -1)
									{
										this.MyIsNewPage(num19 + num12, true);
									}
									else
									{
										if (this.Currenty > 0f)
										{
											this.MyIsNewPage(num19 + num12 + this.ConvFromDisplay((float)this.myms.Rows[num20].Height, false), true);
										}
										if (num19 + num12 + this.ConvFromDisplay((float)this.myms.Rows[num20].Height, false) > this.PaperPrintHeight)
										{
											this.myms.Rows[num20].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - num19 - num12), false)));
										}
									}
								}
								int[,] array5 = new int[10001, columns - 1 + 1];
								float num23 = 0f;
								float num24 = num;
								num = 0f;
								int num25 = 0;
								int num26 = 0;
								int num27 = 0;
								int num28 = this.myms.RowCount - 1;
								for (i = num27; i <= num28; i++)
								{
									if (this.myms.Rows[i].Visible)
									{
										unchecked
										{
											num23 += this.ConvFromDisplay((float)this.myms.Rows[i].Height, false);
											if (num26 == 0)
											{
												num = this.Currenty + num19 + num12 + num23;
											}
											else if (reppagetitle)
											{
												num = num19 + num12 + num23;
											}
											else
											{
												num = num12 + num23 + Conversions.ToSingle(Interaction.IIf(LastPageMode & this.IsDrawTableFooterEveryPage, num18, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0))));
											}
										}
										if (num > this.PaperPrintHeight)
										{
											array5[num26, num25] = i - 1;
											num25++;
											if (num25 >= columns)
											{
												num26++;
												num25 = 0;
											}
											num23 = this.ConvFromDisplay((float)this.myms.Rows[i].Height, false);
										}
									}
								}
								array5[num26, num25] = this.myms.RowCount - 1;
								num26++;
								num25++;
								float num29 = 0f;
								if (LastPageMode)
								{
									int num30;
									int num31;
									if (num26 == 1)
									{
										num30 = 0;
										num31 = this.myms.RowCount - 1;
									}
									else
									{
										num30 = array5[num26 - 2, columns - 1] + 1;
										num31 = this.myms.RowCount - 1;
									}
									float num32 = 0f;
									int num33 = num30;
									int num34 = num31;
									for (i = num33; i <= num34; i++)
									{
										unchecked
										{
											num32 += (float)this.myms.Rows[i].Height;
										}
									}
									float num35 = num32 / (float)columns;
									num32 = 0f;
									num25 = 0;
									int num36 = num30;
									int num37 = num31;
									for (i = num36; i <= num37; i++)
									{
										unchecked
										{
											num32 += (float)this.myms.Rows[i].Height;
										}
										if (num32 >= num35)
										{
											array5[num26 - 1, num25] = i;
											num25++;
											if (num32 > num29)
											{
												num29 = num32;
											}
											num32 = 0f;
										}
									}
									if (num25 >= columns)
									{
										array5[num26 - 1, columns - 1] = num31;
									}
									else
									{
										array5[num26 - 1, num25] = num31;
									}
									if (num32 != 0f)
									{
										num25++;
									}
									num29 = this.ConvFromDisplay(num29, false);
								}
								int[] thecol = new int[1001];
								num = this.PaperPrintWidth;
								int num38 = -1;
								float currenty = this.Currenty;
								num = num24;
								int num39 = 0;
								int num40 = num26 - 1;
								i = num39;
								while (i <= num40 && !this.CancelDocument)
								{
									float currenty2;
									unchecked
									{
										if (i == 0 || reppagetitle)
										{
											if (Operators.CompareString(title, "", false) != 0)
											{
												this.DrawText(title, this.PaperPrintWidth, height2, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
												this.NewRow(height2 + num16);
											}
											this.Currentx = 0f;
											if (Operators.CompareString(subtitle, "", false) != 0)
											{
												this.DrawText(subtitle, this.PaperPrintWidth, height3, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
												this.NewRow(height3 + num17);
											}
											if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
											{
												this.NewRow(num15);
											}
											else
											{
												this.Currentx = 0f;
												if (flag)
												{
													this.DrawText(text, this.PaperPrintWidth, num15, topfont, myHalg, StringAlignment.Near, true, false, false, false, 0f, 0);
												}
												else
												{
													this.DrawText(lefttitle, this.PaperPrintWidth / 3f, num15, topfont, TableTopLeftTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
													this.DrawText(middletitle, this.PaperPrintWidth / 3f, num15, topfont, TableTopMiddleTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
													this.DrawText(righttitle, this.PaperPrintWidth / 3f, num15, topfont, TableTopRightTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
												}
												this.NewRow(num15);
											}
										}
										this.Currentx = 0f;
										currenty2 = this.Currenty;
									}
									int num41 = num38 + 1;
									int j;
									if (i == num26 - 1 & num25 < columns)
									{
										int num42 = 0;
										int num43 = num25 - 1;
										for (j = num42; j <= num43; j++)
										{
											if (this.CancelDocument)
											{
												break;
											}
											unchecked
											{
												if (stringAlignment == StringAlignment.Near)
												{
													this.Currentx = (float)j * columnwidth;
												}
												else if (stringAlignment == StringAlignment.Center)
												{
													this.Currentx = (float)j * columnwidth + (columnwidth - num) / 2f + Conversions.ToSingle(Interaction.IIf(j == 0, 0, (this.PaperPrintWidth - columnwidth * (float)columns) / (float)(checked(columns - 1)) * (float)j));
												}
												else
												{
													this.Currentx = (float)j * columnwidth + columnwidth - num;
												}
												this.Currenty = currenty2;
												num38 = array5[i, j];
											}
											if (LastPageMode | (!LastPageMode & j == num25 - 1))
											{
												this.PrintDGVOut(0, thecol, num41 + 1, num38 + 1, "", titleFont, "", subtitlefont, StringAlignment.Near, myborder, false, false, reppagetitle, topfont, "", "", "", bottomfont, "", "", "", minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, Conversions.ToSingle(Interaction.IIf(this.IsAutoAddEmptyRow, num18, 0)), 0f);
											}
											else
											{
												this.PrintDGVOut(0, thecol, num41 + 1, num38 + 1, "", titleFont, "", subtitlefont, StringAlignment.Near, myborder, false, false, reppagetitle, topfont, "", "", "", bottomfont, "", "", "", minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, 0f, 0f);
											}
											num41 = num38 + 1;
										}
									}
									else
									{
										int num44 = 0;
										int num45 = columns - 1;
										for (j = num44; j <= num45; j++)
										{
											unchecked
											{
												if (stringAlignment == StringAlignment.Near)
												{
													this.Currentx = (float)j * columnwidth;
												}
												else if (stringAlignment == StringAlignment.Center)
												{
													this.Currentx = (float)j * columnwidth + (columnwidth - num) / 2f + Conversions.ToSingle(Interaction.IIf(j == 0, 0, (this.PaperPrintWidth - columnwidth * (float)columns) / (float)(checked(columns - 1)) * (float)j));
												}
												else
												{
													this.Currentx = (float)j * columnwidth + columnwidth - num;
												}
												this.Currenty = currenty2;
												num38 = array5[i, j];
											}
											if (i == num26 - 1 & (LastPageMode | (!LastPageMode & j == num25 - 1)))
											{
												this.PrintDGVOut(0, thecol, num41 + 1, num38 + 1, "", titleFont, "", subtitlefont, StringAlignment.Near, myborder, false, false, reppagetitle, topfont, "", "", "", bottomfont, "", "", "", minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, Conversions.ToSingle(Interaction.IIf(this.IsAutoAddEmptyRow, num18, 0)), 0f);
											}
											else
											{
												this.PrintDGVOut(0, thecol, num41 + 1, num38 + 1, "", titleFont, "", subtitlefont, StringAlignment.Near, myborder, false, false, reppagetitle, topfont, "", "", "", bottomfont, "", "", "", minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, 0f, 0f);
											}
											num41 = num38 + 1;
										}
									}
									unchecked
									{
										if (i == checked(num26 - 1))
										{
											if (!(Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(bm, "", false) == 0 & Operators.CompareString(br, "", false) == 0) && LastPageMode)
											{
												if (this.IsAutoAddEmptyRow)
												{
													this.Currenty = this.PaperPrintHeight - num18;
												}
												else
												{
													if (reppagetitle)
													{
														this.Currenty = num19 + num29 + num12;
														if (LastPageMode & this.IsDrawTableFooterEveryPage)
														{
															this.Currenty -= num18;
														}
														else if (this.OuterBorder)
														{
															this.Currenty = this.Currenty - this.DoubleLineSpace - this.OuterBorderWidth / 2f;
														}
													}
													else
													{
														this.Currenty = num29 + num12;
													}
													if (num26 == 1)
													{
														this.Currenty += currenty;
													}
												}
												bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
												this.IsNeedCheckNewPage = false;
												this.Currentx = 0f;
												if (flag2)
												{
													this.DrawText(text2, this.PaperPrintWidth, num18, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
												}
												else
												{
													this.DrawText(bl, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
													this.DrawText(bm, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
													this.DrawText(br, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
												}
												this.IsNeedCheckNewPage = isNeedCheckNewPage;
												this.Currentx = 0f;
												this.Currenty += num18;
											}
											this.Currentx = columnwidth * (float)(checked(j - 1)) + columnspace * (float)(checked(j - 1));
										}
										else
										{
											if (this.IsDrawTableFooterEveryPage && LastPageMode)
											{
												this.Currenty = this.PaperPrintHeight - num18;
												bool isNeedCheckNewPage2 = this.IsNeedCheckNewPage;
												this.IsNeedCheckNewPage = false;
												this.Currentx = 0f;
												if (flag2)
												{
													this.DrawText(text2, this.PaperPrintWidth, num18, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
												}
												else
												{
													this.DrawText(bl, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
													this.DrawText(bm, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
													this.DrawText(br, this.PaperPrintWidth / 3f, num18, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
												}
												this.IsNeedCheckNewPage = isNeedCheckNewPage2;
											}
											this.MyNewPage();
										}
									}
									i++;
								}
								int num46;
								unchecked
								{
									if (LastPageMode)
									{
										this.Currentx = 0f;
										if (reppagetitle)
										{
											if (this.IsDrawTableFooterEveryPage)
											{
												this.Currenty = num19 + num29 + num12;
											}
											else
											{
												this.Currenty = num19 + num29 + num12 + num18;
												if (this.OuterBorder)
												{
													this.Currenty = this.Currenty - this.OuterBorderWidth / 2f - this.DoubleLineSpace;
												}
											}
										}
										else
										{
											this.Currenty = num29 + num12 + num18;
										}
										if (num26 == 1)
										{
											this.Currenty += currenty;
										}
									}
									if (this.IsAutoAddEmptyRow)
									{
										this.Currenty = this.PaperPrintHeight;
									}
									num46 = 0;
								}
								int num47 = columnCount - 1;
								for (i = num46; i <= num47; i++)
								{
									this.myms.Columns[i].Width = array[i];
								}
								try
								{
									this.myms.ColumnHeadersHeight = array2[0];
								}
								catch (Exception ex)
								{
								}
								int num48 = 0;
								int num49 = this.myms.RowCount - 1;
								for (i = num48; i <= num49; i++)
								{
									this.myms.Rows[i].Height = array2[i];
								}
								try
								{
									mytree.Dispose();
									mytree = null;
									stringFormat.Dispose();
									stringFormat = null;
									array2 = null;
								}
								catch (Exception ex2)
								{
								}
								return num;
							}
						}
						goto IL_85C;
					}
					int[] thecol2 = new int[201];
					result = this.PrintDGVOut(this.myms, 0, thecol2, 0, 0, title, titleFont, subtitle, subtitlefont, StringAlignment.Center, myborder, false, autoresizerowheight, reppagetitle, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, 0f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, false, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, 0f, 0f);
				}
				return result;
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000B22C0 File Offset: 0x000B04C0
		public float PrintDGVPages(DataGridView dgvToPrint, int fixedcols, string title, Font titleFont, StringAlignment alignment, string myborder, bool zoomwidthtopage, float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGVPages(dgvToPrint, fixedcols, title, titleFont, "", this.TextFont, alignment, myborder, zoomwidthtopage, this.TextFont, "", "", "", this.TextFont, "", "", "", minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, autoformat, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000B232C File Offset: 0x000B052C
		public float PrintDGVPages(DataGridView dgvToPrint, int fixedcols, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomwidthtopage, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, Font mysumfont, Color mysumforecolor, Color mysumbackcolor, string mysumcolumns = "", bool myaddrowid = false, bool myaddrowmode = false, string mysortcolumn = "", ListSortDirection mysortmode = ListSortDirection.Ascending, string mygroupcolumn = "", bool mygroupnewpage = false, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, bool autoformat = true, int titletextstyle = 0, int subtitlestyle = 0, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far, StringAlignment SumNumberAlign = StringAlignment.Center)
		{
			float result;
			if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(dgvToPrint, this.tempdgv);
				bool mysorttype = mysortmode == ListSortDirection.Ascending;
				float columnspace = 10f;
				float linespace = 10f;
				float num = this.StartDo(this.tempdgv, mysortcolumn, mysorttype, mygroupcolumn, mysumcolumns, myaddrowmode, mygroupnewpage, mysumfont, mysumforecolor, mysumbackcolor, autoformat, 3, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, reppagetitle, PrintBackColor, titletextstyle, subtitlestyle, fixedcols, myaddrowid, 1, columnspace, true, linespace, true, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, SumNumberAlign, false, 0f);
				result = num;
			}
			return result;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000B23E4 File Offset: 0x000B05E4
		public float PrintDGVPages(DataGridView dgvToPrint, int fixedcols, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool zoomwidthtopage, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl = "", string bm = "", string br = "", float minfontsize = 0f, bool reppagetitle = false, bool PrintBackColor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null, StringAlignment TableTopLeftTitleAlign = StringAlignment.Near, StringAlignment TableTopMiddleTitleAlign = StringAlignment.Center, StringAlignment TableTopRightTitleAlign = StringAlignment.Far, StringAlignment TableBottomLeftTitleAlign = StringAlignment.Near, StringAlignment TableBottomMiddleTitleAlign = StringAlignment.Center, StringAlignment TableBottomRightTitleAlign = StringAlignment.Far)
		{
			checked
			{
				float result;
				if (this.CancelDocument)
				{
					result = 0f;
				}
				else
				{
					if (titleFont == null)
					{
						titleFont = new Font("黑体", 18f, FontStyle.Bold);
					}
					if (subtitlefont == null)
					{
						subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
					}
					if (topfont == null)
					{
						topfont = new Font("宋体", 10f, FontStyle.Regular);
					}
					if (bottomfont == null)
					{
						bottomfont = new Font("宋体", 10f, FontStyle.Regular);
					}
					mytree mytree = new mytree(columnheadertree, dgvToPrint);
					if (mytree.GetColumns() != dgvToPrint.ColumnCount)
					{
						columnheadertree = null;
					}
					Module1.CopyDataGridView(dgvToPrint, this.myms);
					if (columnheadertree != null)
					{
					}
					if (autoformat)
					{
						this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
					StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
					if (fixedcols < 0)
					{
						fixedcols = 0;
					}
					else if (fixedcols > VB2008Print.GetDGVVisibleCols(this.myms))
					{
						fixedcols = VB2008Print.GetDGVVisibleCols(this.myms);
					}
					int[] array = new int[fixedcols + 1];
					int i = 0;
					int columnCount = this.myms.ColumnCount;
					int[] array2 = new int[columnCount - 1 + 1];
					int[] array3 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int j = num; j <= num2; j++)
					{
						array2[j] = j;
						array3[j] = this.myms.Columns[j].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array2);
					int num5;
					if (fixedcols != 0)
					{
						int num3 = 0;
						int num4 = this.myms.Columns.Count - 1;
						for (int j = num3; j <= num4; j++)
						{
							if (this.myms.Columns[array2[j]].Visible)
							{
								array[i] = array2[j];
								i++;
								if (i == fixedcols)
								{
									num5 = j + 1;
									break;
								}
							}
						}
					}
					float num6 = 0f;
					int num7 = 0;
					int num8 = fixedcols - 1;
					for (int j = num7; j <= num8; j++)
					{
						unchecked
						{
							num6 += (float)this.myms.Columns[array[j]].Width;
						}
					}
					float num9 = this.ConvFromDisplay(num6, true);
					if (num9 < this.PaperPrintWidth)
					{
						int[] array4 = new int[this.myms.ColumnCount + 1];
						int num10 = 0;
						int num11 = fixedcols - 1;
						for (int j = num10; j <= num11; j++)
						{
							array4[j] = array[j];
						}
						float num12 = this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
						float num13;
						float num14;
						float num15;
						float num16;
						float num17;
						float height2;
						float num18;
						float num19;
						int num20;
						int num21;
						unchecked
						{
							if (this.Currentx == 0f && zoomwidthtopage)
							{
								num13 = this.PaperPrintWidth;
							}
							else
							{
								num13 = this.PaperPrintWidth - this.Currentx;
							}
							stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
							string txt = "";
							StringAlignment stringAlignment = StringAlignment.Near;
							string txt2 = "";
							StringAlignment stringAlignment2 = StringAlignment.Near;
							bool flag = VB2008Print.CanSpanPrint(bl, bm, br, ref txt2, ref stringAlignment2);
							if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(br, "", false) == 0 & Operators.CompareString(bm, "", false) == 0)
							{
								num14 = 0f;
							}
							else
							{
								if (flag)
								{
									num14 = this.MeasureCell(txt2, bottomfont, num13, stringFormat).Height;
								}
								else
								{
									SizeF sizeF = this.MeasureCell(bl, bottomfont, num13 / 3f, stringFormat);
									SizeF sizeF2 = this.MeasureCell(bm, bottomfont, num13 / 3f, stringFormat);
									num14 = sizeF.Height;
									float height = sizeF2.Height;
									if (num14 < height)
									{
										num14 = height;
									}
									height = this.MeasureCell(br, bottomfont, num13 / 3f, stringFormat).Height;
									if (num14 < height)
									{
										num14 = height;
									}
								}
								num14 += this.MeasureText("测试", new Font("宋体", 12f)).Height / 8f;
							}
							bool flag2 = VB2008Print.CanSpanPrint(lefttitle, middletitle, righttitle, ref txt, ref stringAlignment);
							if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
							{
								num15 = 0f;
							}
							else if (flag2)
							{
								num15 = this.MeasureCell(txt, topfont, num13, stringFormat).Height;
							}
							else
							{
								SizeF sizeF = this.MeasureCell(lefttitle, topfont, num13 / 3f, stringFormat);
								SizeF sizeF2 = this.MeasureCell(middletitle, topfont, num13 / 3f, stringFormat);
								num15 = sizeF.Height;
								float height = sizeF2.Height;
								if (num15 < height)
								{
									num15 = height;
								}
								height = this.MeasureCell(righttitle, topfont, num13 / 3f, stringFormat).Height;
								if (num15 < height)
								{
									num15 = height;
								}
							}
							num16 = this.MeasureText(title, titleFont, num13, stringFormat).Height;
							if (num16 == 0f)
							{
								num17 = 0f;
							}
							else
							{
								num17 = (float)((double)this.MeasureText("游", titleFont, num13, stringFormat).Height / 2.5);
							}
							height2 = this.MeasureText(subtitle, subtitlefont, num13, stringFormat).Height;
							if (height2 == 0f)
							{
								num18 = 0f;
							}
							else
							{
								num18 = (float)((double)this.MeasureText("平", subtitlefont, num13, stringFormat).Height / 2.5);
							}
							if (this.OuterBorder)
							{
								num15 = num15 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
								num14 = num14 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
							}
							else if (this.IsUseDoubleLine)
							{
								num15 += this.DoubleLineSpace / 2f;
								num14 += this.DoubleLineSpace / 2f;
							}
							num19 = num16 + num17 + height2 + num18 + num15 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num14, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0))));
							num20 = -1;
							num21 = 0;
						}
						int num22 = this.myms.RowCount - 1;
						for (int j = num21; j <= num22; j++)
						{
							if (this.myms.Rows[j].Visible)
							{
								num20 = j;
							IL_68E:
								float currenty;
								int[] array5;
								int[,] array6;
								int num23;
								float num24;
								int num25;
								unchecked
								{
									if (num20 == -1)
									{
										this.MyIsNewPage(num19 + num12, true);
									}
									else
									{
										if (this.Currenty > 0f)
										{
											this.MyIsNewPage(num19 + num12 + this.ConvFromDisplay((float)this.myms.Rows[num20].Height, false), true);
										}
										if (num19 + num12 + this.ConvFromDisplay((float)this.myms.Rows[num20].Height, false) > this.PaperPrintHeight)
										{
											this.myms.Rows[num20].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - num19 - num12), false)));
										}
									}
									currenty = this.Currenty;
									array5 = new int[10001];
									array6 = new int[501, 10001];
									num23 = 0;
									num24 = 0f;
									num25 = 0;
								}
								int num26 = this.myms.RowCount - 1;
								for (j = num25; j <= num26; j++)
								{
									if (this.myms.Rows[j].Visible)
									{
										unchecked
										{
											num24 += this.ConvFromDisplay((float)this.myms.Rows[j].Height, false);
											if (num23 == 0)
											{
												num13 = this.Currenty + num19 + num12 + num24;
											}
											else if (reppagetitle)
											{
												num13 = num19 + num12 + num24;
											}
											else
											{
												num13 = num12 + num24 + Conversions.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num14, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0))));
											}
										}
										if (num13 > this.PaperPrintHeight)
										{
											array5[num23] = j - 1;
											num23++;
											num24 = this.ConvFromDisplay((float)this.myms.Rows[j].Height, false);
										}
									}
								}
								array5[num23] = this.myms.RowCount - 1;
								num23++;
								int num27 = 0;
								columnCount = this.myms.ColumnCount;
								int num28 = 0;
								int num29 = columnCount - 1;
								for (j = num28; j <= num29; j++)
								{
									array2[j] = j;
									array3[j] = this.myms.Columns[j].DisplayIndex;
								}
								Array.Sort<int, int>(array3, array2);
								int k = 0;
								int[] array7 = new int[1001];
								num24 = 0f;
								int num30 = num5;
								int num31 = columnCount - 1;
								for (j = num30; j <= num31; j++)
								{
									if (this.myms.Columns[array2[j]].Visible)
									{
										unchecked
										{
											num24 += this.ConvFromDisplay((float)this.myms.Columns[array2[j]].Width, true);
											if (num27 == 0)
											{
												num13 = this.Currentx + num9 + num24;
											}
											else
											{
												num13 = num9 + num24;
											}
										}
										if (num13 > this.PaperPrintWidth & k > 0)
										{
											array7[num27] = k;
											num27++;
											array6[num27, 0] = array2[j];
											k = 1;
											num24 = this.ConvFromDisplay((float)this.myms.Columns[array2[j]].Width, true);
										}
										else
										{
											array6[num27, k] = array2[j];
											k++;
										}
									}
								}
								array6[num27, k] = array2[columnCount - 1];
								array7[num27] = k;
								num27++;
								this.Currenty = currenty;
								int[] array8 = new int[this.myms.ColumnCount - 1 + 1];
								bool[] array9 = new bool[this.myms.ColumnCount - 1 + 1];
								int num32 = 0;
								int num33 = this.myms.ColumnCount - 1;
								for (j = num32; j <= num33; j++)
								{
									if (this.myms.Columns[j].Visible)
									{
										array9[j] = true;
									}
									else
									{
										array9[j] = false;
									}
								}
								if (num16 == 0f)
								{
									num16 = 0.001f;
								}
								int num34 = 0;
								int num35 = num23 - 1;
								for (j = num34; j <= num35; j++)
								{
									int num36 = 0;
									int num37 = num27 - 1;
									int num38 = num36;
									while (num38 <= num37 && !this.CancelDocument)
									{
										int num39 = 0;
										int num40 = this.myms.ColumnCount - 1;
										for (int l = num39; l <= num40; l++)
										{
											this.myms.Columns[l].Visible = false;
										}
										int num41 = 0;
										int num42 = fixedcols - 1;
										for (i = num41; i <= num42; i++)
										{
											array8[i] = array[i];
											if (array9[array[i]])
											{
												this.myms.Columns[array[i]].Visible = true;
											}
										}
										int num43 = 0;
										int num44 = array7[num38] - 1;
										for (k = num43; k <= num44; k++)
										{
											array8[fixedcols + k] = array6[num38, k];
											if (array9[array6[num38, k]])
											{
												this.myms.Columns[array6[num38, k]].Visible = true;
											}
										}
										k = fixedcols + array7[num38];
										int fromrow;
										if (j == 0)
										{
											fromrow = 1;
										}
										else
										{
											fromrow = array5[j - 1] + 1 + 1;
										}
										int torow = array5[j] + 1;
										if (num23 == 1)
										{
											this.PrintDGVOut(k, array8, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, num16, num17, height2, num18, num15, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, num14, 0f);
										}
										else if (j == num23 - 1)
										{
											if (reppagetitle)
											{
												this.PrintDGVOut(k, array8, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, num16, num17, height2, num18, num15, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, num14, 0f);
											}
											else
											{
												this.PrintDGVOut(k, array8, fromrow, torow, "", titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, "", "", "", bottomfont, bl, bm, br, minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, true, num14, 0f);
											}
										}
										else if (j == 0 || reppagetitle)
										{
											if (!this.IsDrawTableFooterEveryPage)
											{
												this.PrintDGVOut(k, array8, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, "", "", "", minfontsize, num16, num17, height2, num18, num15, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, 0f, 0f);
											}
											else
											{
												this.PrintDGVOut(k, array8, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, num16, num17, height2, num18, num15, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, num14, 0f);
											}
										}
										else if (!this.IsDrawTableFooterEveryPage)
										{
											this.PrintDGVOut(k, array8, fromrow, torow, "", titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, "", "", "", bottomfont, "", "", "", minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, 0f, 0f);
										}
										else
										{
											this.PrintDGVOut(k, array8, fromrow, torow, "", titleFont, subtitle, subtitlefont, alignment, myborder, zoomwidthtopage, false, reppagetitle, topfont, "", "", "", bottomfont, bl, bm, br, minfontsize, 0.001f, 0f, 0f, 0f, 0f, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, false, num14, 0f);
										}
										if (num38 < num27 - 1)
										{
											this.MyNewPage();
											if (j == 0)
											{
												this.Currenty = currenty;
											}
										}
										num38++;
									}
									if (j < num23 - 1)
									{
										this.MyNewPage();
									}
								}
								try
								{
									mytree.Dispose();
									stringFormat.Dispose();
								}
								catch (Exception ex)
								{
								}
								return num13;
							}
						}
						goto IL_68E;
					}
					if (this.IsShowErrorMSG)
					{
						Interaction.MsgBox("不能横向跨页打印,每页的固定列宽大于页面宽度,可能是固定列太多或太宽", MsgBoxStyle.OkOnly, "提示信息");
					}
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000B3360 File Offset: 0x000B1560
		public float PrintDGVgzt(DataGridView dgvToPrint, string title, Font titleFont, StringAlignment alignment = StringAlignment.Near, string myborder = "1111", bool zoomtopaperwidth = false, bool autoresizerowheight = false, float minfontsize = 0f, bool reppagetitle = false, float linespace = 30f, bool printzero = false, bool printbackcolor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			return this.PrintDGVgzt(dgvToPrint, title, titleFont, "", this.TextFont, alignment, myborder, zoomtopaperwidth, autoresizerowheight, minfontsize, reppagetitle, linespace, printzero, printbackcolor, titletextstyle, subtitlestyle, autoformat, columnheadertree);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000B33A0 File Offset: 0x000B15A0
		public float PrintDGVgzt(DataGridView dgvToPrint, string title, Font titleFont, string subtitle, Font subtitlefont, Font mysumfont, Color mysumforecolor, Color mysumbackcolor, string mysumcolumns = "", bool myaddrowid = false, bool myaddrowmode = false, string mysortcolumn = "", ListSortDirection mysortmode = ListSortDirection.Ascending, string mygroupcolumn = "", bool mygroupnewpage = false, StringAlignment alignment = StringAlignment.Near, string myborder = "1111", bool zoomtopaperwidth = false, bool autoresizerowheight = false, float minfontsize = 0f, bool reppagetitle = false, float linespace = 30f, bool printzero = false, bool printbackcolor = false, bool autoformat = true, int titletextstyle = 0, int subtitlestyle = 0, TreeView columnheadertree = null, StringAlignment SumNumberAlign = StringAlignment.Center)
		{
			float result;
			if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				Module1.CopyDataGridView(dgvToPrint, this.tempdgv);
				bool mysorttype = mysortmode == ListSortDirection.Ascending;
				float columnspace = 10f;
				float num = this.StartDo(this.tempdgv, mysortcolumn, mysorttype, mygroupcolumn, mysumcolumns, myaddrowmode, mygroupnewpage, mysumfont, mysumforecolor, mysumbackcolor, autoformat, 4, title, titleFont, subtitle, subtitlefont, alignment, myborder, zoomtopaperwidth, autoresizerowheight, null, "", "", "", null, "", "", "", minfontsize, reppagetitle, printbackcolor, titletextstyle, subtitlestyle, 0, myaddrowid, 1, columnspace, true, linespace, printzero, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, SumNumberAlign, false, 0f);
				result = num;
			}
			return result;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000B345C File Offset: 0x000B165C
		public float PrintDGVgzt(DataGridView dgvToPrint, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment = StringAlignment.Near, string myborder = "1111", bool zoomtopaperwidth = false, bool autoresizerowheight = false, float minfontsize = 0f, bool reppagetitle = false, float linespace = 30f, bool printzero = false, bool printbackcolor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true, TreeView columnheadertree = null)
		{
			checked
			{
				float result;
				if (!this.CancelDocument)
				{
					if (titleFont == null)
					{
						titleFont = new Font("黑体", 18f, FontStyle.Bold);
					}
					if (subtitlefont == null)
					{
						subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
					}
					mytree mytree = new mytree(columnheadertree, dgvToPrint);
					if (mytree.GetColumns() != dgvToPrint.ColumnCount)
					{
						columnheadertree = null;
					}
					Module1.CopyDataGridView(dgvToPrint, this.myms);
					if (columnheadertree != null)
					{
					}
					if (autoformat)
					{
						this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
					StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
					StringFormat stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
					stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
					int columnCount = this.myms.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array2[i] = i;
					}
					int[] array3 = new int[columnCount - 1 + 1];
					int num3 = 0;
					int num4 = columnCount - 1;
					for (int i = num3; i <= num4; i++)
					{
						array[i] = array2[i];
						array3[i] = this.myms.Columns[array2[i]].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array);
					int[] array4 = new int[columnCount + 1];
					int[] array5 = new int[this.myms.RowCount + 1];
					int num5 = 0;
					int num6 = columnCount - 1;
					for (int i = num5; i <= num6; i++)
					{
						array4[i] = this.myms.Columns[array2[i]].Width;
					}
					array5[0] = Conversions.ToInteger(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0));
					int num7 = 0;
					int num8 = this.myms.RowCount - 1;
					for (int i = num7; i <= num8; i++)
					{
						array5[i + 1] = this.myms.Rows[i].Height;
					}
					float[] array6 = new float[columnCount - 1 + 1];
					int[] array7 = new int[columnCount - 1 + 1];
					float num9 = 0f;
					float num10 = this.Currentx;
					int num11 = 0;
					int num12 = columnCount - 1;
					for (int i = num11; i <= num12; i++)
					{
						unchecked
						{
							if (this.myms.Columns[array[i]].Visible)
							{
								DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[i]];
								float num13 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
								array7[i] = dataGridViewColumn.Width;
								num9 += num13;
								array6[i] = num13;
							}
						}
					}
					float[] array8 = new float[this.myms.ColumnCount - 1 + 1];
					if (zoomtopaperwidth)
					{
						if (num9 == 0f)
						{
							if (this.IsShowErrorMSG)
							{
								Interaction.MsgBox("不能打印DatGridView表格，当前没有可供打印的列数据", MsgBoxStyle.OkOnly, "提示信息");
							}
							return 0f;
						}
						float num14 = unchecked(this.PaperPrintWidth - num10) / num9;
						int num15 = 0;
						int num16 = columnCount - 1;
						for (int i = num15; i <= num16; i++)
						{
							unchecked
							{
								array6[i] *= num14;
							}
							this.myms.Columns[array[i]].Width = (int)Math.Round((double)(unchecked((float)array7[i] * num14)));
							array8[array[i]] = array6[i];
						}
						num9 = 0f;
						int num17 = 0;
						int num18 = columnCount - 1;
						for (int i = num17; i <= num18; i++)
						{
							unchecked
							{
								num9 += array6[i];
							}
						}
						if (autoresizerowheight)
						{
							this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
						}
					}
					else
					{
						int num19 = 0;
						int num20 = columnCount - 1;
						for (int i = num19; i <= num20; i++)
						{
							array8[array[i]] = array6[i];
						}
					}
					result = num9;
					float num21 = num10;
					float num23;
					float height;
					float num24;
					float height2;
					float num25;
					int num26;
					int num27;
					unchecked
					{
						if (alignment == StringAlignment.Center)
						{
							float num22 = this.PaperPrintWidth - num9;
							num10 = num22 / 2f;
						}
						else if (alignment == StringAlignment.Far)
						{
							num10 = this.PaperPrintWidth - num9;
						}
						int currentPage = this.GetCurrentPage();
						num23 = this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
						stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
						height = this.MeasureText(title, titleFont, this.PaperPrintWidth - this.Currentx, stringFormat).Height;
						if (height == 0f)
						{
							num24 = 0f;
						}
						else
						{
							num24 = (float)((double)this.MeasureText("游", titleFont, num9, stringFormat).Height / 2.5);
						}
						height2 = this.MeasureText(subtitle, subtitlefont, this.PaperPrintWidth - this.Currentx, stringFormat).Height;
						if (height2 == 0f)
						{
							num25 = 0f;
						}
						else
						{
							num25 = (float)((double)this.MeasureText("平", subtitlefont, num9, stringFormat).Height / 2.5);
						}
						num26 = -1;
						num27 = 0;
					}
					int num28 = this.myms.RowCount - 1;
					for (int i = num27; i <= num28; i++)
					{
						if (this.myms.Rows[i].Visible)
						{
							num26 = i;
						IL_534:
							int currentPage;
							mytree mytree2;
							float doubleLineSpace;
							float num29;
							float[] array9;
							int num30;
							unchecked
							{
								if (num26 == -1)
								{
									this.MyIsNewPage(height + num24 + height2 + num25 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false), true);
								}
								else
								{
									if (this.Currenty > 0f)
									{
										this.MyIsNewPage(height + num24 + height2 + num25 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num26].Height, false), true);
									}
									if (height + num24 + height2 + num25 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num26].Height, false) > this.PaperPrintHeight)
									{
										this.myms.Rows[num26].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - (height + num24 + height2 + num25 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false))), false)));
									}
								}
								currentPage = this.GetCurrentPage();
								mytree2 = new mytree(columnheadertree, this.myms, array8);
								doubleLineSpace = this.DoubleLineSpace;
								num29 = this.ConvFromDisplay((float)this.myms.ColumnHeadersHeight, false);
								array9 = new float[4];
								array9 = VB2008Print.ParaseBorder(myborder);
								num30 = 0;
							}
							int num31 = this.myms.RowCount - 1;
							for (i = num30; i <= num31; i++)
							{
								bool flag = true;
								if (this.CancelDocument)
								{
									break;
								}
								this.Currentx = num10;
								unchecked
								{
									if (currentPage != this.GetCurrentPage() | i == 0)
									{
										currentPage = this.GetCurrentPage();
										flag = true;
										if (i == 0 || reppagetitle)
										{
											if (Operators.CompareString(title, "", false) != 0)
											{
												this.Currentx = num21;
												this.DrawText(title, this.PaperPrintWidth - num21, height, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
												this.NewRow(height + num24);
											}
											this.Currentx = num21;
											if (Operators.CompareString(subtitle, "", false) != 0)
											{
												this.DrawText(subtitle, this.PaperPrintWidth - num21, height2, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
												this.NewRow(height2 + num25);
											}
										}
									}
									this.Currentx = num10;
									float currenty = this.Currenty;
									DataGridViewRow dataGridViewRow = this.myms.Rows[i];
									if (this.myms.Rows[i].Visible)
									{
										float num32 = 0f;
										bool flag2;
										if (this.myms.ColumnHeadersVisible)
										{
											checked
											{
												if (columnheadertree == null)
												{
													flag2 = true;
													int num33 = 0;
													int num34 = columnCount - 1;
													for (int j = num33; j <= num34; j++)
													{
														DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[j]];
														unchecked
														{
															if (dataGridViewColumn.Visible)
															{
																string left;
																if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
																{
																	if (dataGridViewRow.Cells[array[j]].FormattedValue == null)
																	{
																		left = "";
																	}
																	else
																	{
																		left = "11";
																	}
																}
																else
																{
																	left = Conversions.ToString(dataGridViewRow.Cells[array[j]].FormattedValue) + "";
																}
																if (printzero | (!printzero & Operators.CompareString(left, "", false) != 0 & Operators.CompareString(left, "0", false) != 0 & Operators.CompareString(left, "0.00", false) != 0))
																{
																	if (this.IsUseDoubleLine)
																	{
																		if (flag2)
																		{
																			this.Currentx += doubleLineSpace / 2f;
																		}
																		else
																		{
																			this.Currentx += doubleLineSpace;
																		}
																		this.Currenty = currenty + doubleLineSpace / 2f;
																		this.MyDrawDGVHeaderCell(dataGridViewColumn, array6[j] - doubleLineSpace, num29 - doubleLineSpace, myborder, printbackcolor, minfontsize);
																	}
																	else
																	{
																		this.MyDrawDGVHeaderCell(dataGridViewColumn, array6[j], num29, myborder, printbackcolor, minfontsize);
																	}
																	flag2 = false;
																	num32 += array6[j];
																}
															}
														}
													}
												}
												else
												{
													printzero = true;
													int leves = mytree2.GetLeves();
													int num35 = 0;
													int num36 = columnCount - 1;
													for (int j = num35; j <= num36; j++)
													{
														unchecked
														{
															if (this.myms.Columns[array[j]].Visible)
															{
																num32 += array6[j];
															}
														}
													}
													int num37 = 1;
													int num38 = leves;
													for (int k = num37; k <= num38; k++)
													{
														this.Currentx = num10;
														int num39;
														unchecked
														{
															if (this.IsUseDoubleLine)
															{
																this.Currentx = num10 + doubleLineSpace / 2f;
															}
															this.Currenty = currenty + num23 / (float)leves * (float)(checked(k - 1));
															if (this.IsUseDoubleLine)
															{
																this.Currenty += doubleLineSpace / 2f;
															}
															num39 = 0;
														}
														int num40 = columnCount - 1;
														for (int j = num39; j <= num40; j++)
														{
															DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[j]];
															unchecked
															{
																if (dataGridViewColumn.Visible)
																{
																	float num41 = mytree2.GetCellHeight(array[j], k);
																	float cellWidth = mytree2.GetCellWidth(array[j], k);
																	num41 = this.ConvFromDisplay(num41, false);
																	string nodeText = mytree2.GetNodeText(array[j], k);
																	if (num41 == 0f | cellWidth == 0f)
																	{
																		this.Currentx += array6[j];
																	}
																	else if (dataGridViewColumn.Visible)
																	{
																		Font font = mytree2.GetNodeFont(array[j], k);
																		if (font == null)
																		{
																			font = Module1.GetDGVHeaderFont(dataGridViewColumn);
																		}
																		Color textforecolor = mytree2.GetNodeForeColor(array[j], k);
																		if (textforecolor.IsEmpty)
																		{
																			textforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
																		}
																		bool mulline = Module1.GetDGVHeaderMulline(dataGridViewColumn);
																		Color backcolor = mytree2.GetNodeBackColor(array[j], k);
																		if (backcolor.IsEmpty)
																		{
																			backcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
																		}
																		mulline = true;
																		if (this.IsUseDoubleLine)
																		{
																			if (!printbackcolor)
																			{
																				this.DrawCell(nodeText, cellWidth - doubleLineSpace, num41 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
																			}
																			else
																			{
																				this.DrawCell(nodeText, cellWidth - doubleLineSpace, num41 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
																			}
																			this.Currentx = this.Currentx + array6[j] + doubleLineSpace - cellWidth;
																		}
																		else
																		{
																			if (!printbackcolor)
																			{
																				this.DrawCell(nodeText, cellWidth, num41, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
																			}
																			else
																			{
																				this.DrawCell(nodeText, cellWidth, num41, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
																			}
																			this.Currentx = this.Currentx + array6[j] - cellWidth;
																		}
																	}
																}
															}
														}
													}
												}
											}
											if (this.IsUseDoubleLine)
											{
												this.DrawLine(new Pen(this.myms.GridColor, array9[0]), num10 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 - doubleLineSpace / 2f, currenty + num29);
												this.DrawLine(new Pen(this.myms.GridColor, array9[1]), num10 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 + num32 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
												this.DrawLine(new Pen(this.myms.GridColor, array9[2]), num10 + num32 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 + num32 + doubleLineSpace / 2f, currenty + num29);
											}
											if (this.OuterBorder)
											{
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace, currenty - doubleLineSpace, num10 - doubleLineSpace, currenty + num29);
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num10 + num32 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 + num32 + doubleLineSpace, currenty - doubleLineSpace, num10 + num32 + doubleLineSpace, currenty + num29);
											}
											flag = false;
										}
										this.Currentx = num10;
										this.Currenty = currenty + num23;
										if (this.Currenty + this.ConvFromDisplay((float)dataGridViewRow.Height, false) > this.PaperPrintHeight)
										{
											dataGridViewRow.Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - this.Currenty), false)));
										}
										flag2 = true;
										currenty = this.Currenty;
										num32 = 0f;
										int num42 = 0;
										float num45;
										checked
										{
											int num43 = columnCount - 1;
											for (int j = num42; j <= num43; j++)
											{
												DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[j]];
												unchecked
												{
													if (dataGridViewColumn.Visible)
													{
														float num44 = array6[j];
														num45 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
														string left;
														if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
														{
															if (dataGridViewRow.Cells[array[j]].FormattedValue == null)
															{
																left = "";
															}
															else
															{
																left = "11";
															}
														}
														else
														{
															left = Conversions.ToString(dataGridViewRow.Cells[array[j]].FormattedValue) + "";
														}
														if (printzero | (!printzero & Operators.CompareString(left, "", false) != 0 & Operators.CompareString(left, "0", false) != 0 & Operators.CompareString(left, "0.00", false) != 0))
														{
															if (this.IsUseDoubleLine)
															{
																if (flag2)
																{
																	this.Currentx += doubleLineSpace / 2f;
																}
																else
																{
																	this.Currentx += doubleLineSpace;
																}
																if (flag)
																{
																	this.Currenty = currenty + doubleLineSpace / 2f;
																}
																else
																{
																	this.Currenty = currenty + doubleLineSpace / 2f;
																}
																this.MyDrawDGVCell(this.myms.Rows[i].Cells[array[j]], num44 - doubleLineSpace, num45 - doubleLineSpace, myborder, printbackcolor, minfontsize);
															}
															else
															{
																this.MyDrawDGVCell(this.myms.Rows[i].Cells[array[j]], num44, num45, myborder, printbackcolor, minfontsize);
															}
															num32 += num44;
															flag2 = false;
														}
													}
												}
											}
										}
										if (this.IsUseDoubleLine)
										{
											if (flag)
											{
												this.DrawLine(new Pen(this.myms.GridColor, array9[1]), num10 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 + num32 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
												this.DrawLine(new Pen(this.myms.GridColor, array9[0]), num10 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 - doubleLineSpace / 2f, currenty + num45);
												this.DrawLine(new Pen(this.myms.GridColor, array9[2]), num10 + num32 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num10 + num32 + doubleLineSpace / 2f, currenty + num45);
											}
											else
											{
												this.DrawLine(new Pen(this.myms.GridColor, array9[0]), num10 - doubleLineSpace / 2f, currenty, num10 - doubleLineSpace / 2f, currenty + num45);
												this.DrawLine(new Pen(this.myms.GridColor, array9[2]), num10 + num32 + doubleLineSpace / 2f, currenty, num10 + num32 + doubleLineSpace / 2f, currenty + num45);
											}
										}
										if (this.OuterBorder)
										{
											if (flag)
											{
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num10 + num32 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace, currenty - doubleLineSpace, num10 - doubleLineSpace, currenty + num45);
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 + num32 + doubleLineSpace, currenty - doubleLineSpace, num10 + num32 + doubleLineSpace, currenty + num45);
											}
											else
											{
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace, currenty, num10 - doubleLineSpace, currenty + num45);
												this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 + num32 + doubleLineSpace, currenty, num10 + num32 + doubleLineSpace, currenty + num45);
											}
										}
										if (flag)
										{
										}
										this.Currenty = currenty + this.ConvFromDisplay((float)dataGridViewRow.Height, false);
										currenty = this.Currenty;
										if (this.IsUseDoubleLine)
										{
											this.DrawLine(new Pen(this.myms.GridColor, array9[3]), num10 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num10 + num32 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
											this.DrawLine(new Pen(this.myms.GridColor, array9[0]), num10 - doubleLineSpace / 2f, currenty, num10 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
											this.DrawLine(new Pen(this.myms.GridColor, array9[2]), num10 + num32 + doubleLineSpace / 2f, currenty, num10 + num32 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
										}
										if (this.OuterBorder)
										{
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num10 + num32 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 - doubleLineSpace, currenty, num10 - doubleLineSpace, currenty + doubleLineSpace);
											this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num10 + num32 + doubleLineSpace, currenty, num10 + num32 + doubleLineSpace, currenty + doubleLineSpace);
										}
										checked
										{
											if (i == this.myms.RowCount - 1)
											{
												break;
											}
											dataGridViewRow = this.myms.Rows[i + 1];
										}
										float theheight = this.ConvFromDisplay((float)dataGridViewRow.Height, false) + num23 + linespace;
										if (!this.MyIsNewPage(theheight, true))
										{
											this.Currenty += linespace;
										}
									}
								}
							}
							this.Currentx = 0f;
							int num46 = 0;
							int num47 = columnCount - 1;
							for (i = num46; i <= num47; i++)
							{
								this.myms.Columns[array2[i]].Width = array4[i];
							}
							try
							{
								if (array5[0] != 0)
								{
									this.myms.ColumnHeadersHeight = array5[0];
								}
							}
							catch (Exception ex)
							{
							}
							int num48 = 0;
							int num49 = this.myms.RowCount - 1;
							for (i = num48; i <= num49; i++)
							{
								this.myms.Rows[i].Height = array5[i + 1];
							}
							try
							{
								mytree2.Dispose();
								mytree.Dispose();
								mytree2 = null;
								mytree = null;
								stringFormat.Dispose();
								stringFormat2.Dispose();
								stringFormat = null;
								stringFormat2 = null;
								array5 = null;
							}
							catch (Exception ex2)
							{
							}
							return result;
						}
					}
					goto IL_534;
				}
				result = 0f;
				return result;
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000B4A1C File Offset: 0x000B2C1C
		public float PrintDGVgzt2(DataGridView dgvToPrint, string title, Font titleFont, string subtitle, Font subtitlefont, string myborder = "1111", float minfontsize = 0f, bool reppagetitle = false, float linespace = 30f, bool printzero = false, bool printbackcolor = false, int titletextstyle = 0, int subtitlestyle = 0, bool autoformat = true)
		{
			checked
			{
				float result;
				if (!this.CancelDocument)
				{
					if (titleFont == null)
					{
						titleFont = new Font("黑体", 18f, FontStyle.Bold);
					}
					if (subtitlefont == null)
					{
						subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
					}
					Module1.CopyDataGridView(dgvToPrint, this.myms);
					if (autoformat)
					{
						this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
						this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
					}
					StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
					StringFormat stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
					stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
					int columnCount = this.myms.ColumnCount;
					int[] array = new int[columnCount - 1 + 1];
					int[] array2 = new int[columnCount - 1 + 1];
					int num = 0;
					int num2 = columnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						array2[i] = i;
					}
					int[] array3 = new int[columnCount - 1 + 1];
					int num3 = 0;
					int num4 = columnCount - 1;
					for (int i = num3; i <= num4; i++)
					{
						array[i] = array2[i];
						array3[i] = this.myms.Columns[array2[i]].DisplayIndex;
					}
					Array.Sort<int, int>(array3, array);
					int[] array4 = new int[columnCount + 1];
					int[] array5 = new int[this.myms.RowCount + 1];
					int num5 = 0;
					int num6 = columnCount - 1;
					for (int i = num5; i <= num6; i++)
					{
						array4[i] = this.myms.Columns[array2[i]].Width;
					}
					array5[0] = Conversions.ToInteger(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0));
					int num7 = 0;
					int num8 = this.myms.RowCount - 1;
					for (int i = num7; i <= num8; i++)
					{
						array5[i + 1] = this.myms.Rows[i].Height;
					}
					float[] array6 = new float[columnCount - 1 + 1];
					int[] array7 = new int[columnCount - 1 + 1];
					float currentx = this.Currentx;
					int num9 = 0;
					int num10 = columnCount - 1;
					for (int i = num9; i <= num10; i++)
					{
						if (this.myms.Columns[array[i]].Visible)
						{
							DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[i]];
							float num11 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
							array7[i] = dataGridViewColumn.Width;
							array6[i] = num11;
						}
					}
					result = 0f;
					float num12 = currentx;
					float num13 = this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
					stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
					float height;
					float num14;
					float height2;
					float num15;
					int num16;
					int num17;
					unchecked
					{
						height = this.MeasureText(title, titleFont, this.PaperPrintWidth - this.Currentx, stringFormat).Height;
						if (height == 0f)
						{
							num14 = 0f;
						}
						else
						{
							num14 = (float)((double)this.MeasureText("游", titleFont, this.PaperPrintWidth, stringFormat).Height / 2.5);
						}
						height2 = this.MeasureText(subtitle, subtitlefont, this.PaperPrintWidth - this.Currentx, stringFormat).Height;
						if (height2 == 0f)
						{
							num15 = 0f;
						}
						else
						{
							num15 = (float)((double)this.MeasureText("平", subtitlefont, this.PaperPrintWidth, stringFormat).Height / 2.5);
						}
						num16 = -1;
						num17 = 0;
					}
					int num18 = this.myms.RowCount - 1;
					for (int i = num17; i <= num18; i++)
					{
						if (this.myms.Rows[i].Visible)
						{
							num16 = i;
						IL_3D5:
							float mycellheight;
							int num19;
							unchecked
							{
								if (num16 == -1)
								{
									this.MyIsNewPage(height + num14 + height2 + num15 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false), true);
								}
								else
								{
									if (this.Currenty > 0f)
									{
										this.MyIsNewPage(height + num14 + height2 + num15 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num16].Height, false), true);
									}
									if (height + num14 + height2 + num15 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num16].Height, false) > this.PaperPrintHeight)
									{
										this.myms.Rows[num16].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - (height + num14 + height2 + num15 + this.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false))), false)));
									}
								}
								mycellheight = this.ConvFromDisplay((float)this.myms.ColumnHeadersHeight, false);
								VB2008Print.ParaseBorder(myborder);
								if (Operators.CompareString(title, "", false) != 0)
								{
									this.Currentx = num12;
									this.DrawText(title, this.PaperPrintWidth - num12, height, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
									this.NewRow(height + num14);
								}
								this.Currentx = num12;
								if (Operators.CompareString(subtitle, "", false) != 0)
								{
									this.DrawText(subtitle, this.PaperPrintWidth - num12, height2, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
									this.NewRow(height2 + num15);
								}
								num19 = 0;
							}
							int num20 = this.myms.RowCount - 1;
							i = num19;
							while (i <= num20 && !this.CancelDocument)
							{
								this.Currentx = currentx;
								float currenty = this.Currenty;
								DataGridViewRow dataGridViewRow = this.myms.Rows[i];
								if (this.myms.Rows[i].Visible)
								{
									float num21 = 0f;
									float num22 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
									int num23 = 0;
									int num24 = columnCount - 1;
									for (int j = num23; j <= num24; j++)
									{
										DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[j]];
										unchecked
										{
											if (dataGridViewColumn.Visible)
											{
												string left;
												if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
												{
													if (dataGridViewRow.Cells[array[j]].FormattedValue == null)
													{
														left = "";
													}
													else
													{
														left = "11";
													}
												}
												else
												{
													left = Conversions.ToString(dataGridViewRow.Cells[array[j]].FormattedValue) + "";
												}
												if (printzero | (!printzero & Operators.CompareString(left, "", false) != 0 & Operators.CompareString(left, "0", false) != 0 & Operators.CompareString(left, "0.00", false) != 0))
												{
													if (this.Currentx + array6[j] > this.PaperPrintWidth)
													{
														this.Currenty = currenty + num13 + num22;
														currenty = this.Currenty;
														this.Currentx = currentx;
														if (this.MyIsNewPage(num13 + num22, true))
														{
															if (reppagetitle)
															{
																if (Operators.CompareString(title, "", false) != 0)
																{
																	this.Currentx = num12;
																	this.DrawText(title, this.PaperPrintWidth - num12, height, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
																	this.NewRow(height + num14);
																}
																this.Currentx = num12;
																if (Operators.CompareString(subtitle, "", false) != 0)
																{
																	this.DrawText(subtitle, this.PaperPrintWidth - num12, height2, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
																	this.NewRow(height2 + num15);
																}
															}
															currenty = this.Currenty;
														}
													}
													if (this.myms.ColumnHeadersVisible)
													{
														float currentx2 = this.Currentx;
														this.Currenty = currenty;
														this.MyDrawDGVHeaderCell(dataGridViewColumn, array6[j], mycellheight, myborder, printbackcolor, minfontsize);
														this.Currentx = currentx2;
														this.Currenty = currenty + num13;
													}
													this.MyDrawDGVCell(this.myms.Rows[i].Cells[array[j]], array6[j], num22, myborder, printbackcolor, minfontsize);
													num21 += array6[j];
												}
											}
										}
									}
									this.Currenty = unchecked(currenty + num13 + num22);
									if (i == this.myms.RowCount - 1)
									{
										break;
									}
									dataGridViewRow = this.myms.Rows[i + 1];
									unchecked
									{
										float theheight = this.ConvFromDisplay((float)dataGridViewRow.Height, false) + num13 + linespace;
										if (this.MyIsNewPage(theheight, true))
										{
											if (reppagetitle)
											{
												if (Operators.CompareString(title, "", false) != 0)
												{
													this.Currentx = num12;
													this.DrawText(title, this.PaperPrintWidth - num12, height, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
													this.NewRow(height + num14);
												}
												this.Currentx = num12;
												if (Operators.CompareString(subtitle, "", false) != 0)
												{
													this.DrawText(subtitle, this.PaperPrintWidth - num12, height2, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
													this.NewRow(height2 + num15);
												}
											}
											currenty = this.Currenty;
										}
										else
										{
											this.Currenty += linespace;
											currenty = this.Currenty;
										}
									}
								}
								i++;
							}
							this.Currentx = 0f;
							int num25 = 0;
							int num26 = columnCount - 1;
							for (i = num25; i <= num26; i++)
							{
								this.myms.Columns[array2[i]].Width = array4[i];
							}
							try
							{
								if (array5[0] != 0)
								{
									this.myms.ColumnHeadersHeight = array5[0];
								}
							}
							catch (Exception ex)
							{
							}
							int num27 = 0;
							int num28 = this.myms.RowCount - 1;
							for (i = num27; i <= num28; i++)
							{
								this.myms.Rows[i].Height = array5[i + 1];
							}
							try
							{
								stringFormat.Dispose();
								stringFormat2.Dispose();
								stringFormat = null;
								stringFormat2 = null;
								array5 = null;
							}
							catch (Exception ex2)
							{
							}
							return result;
						}
					}
					goto IL_3D5;
				}
				result = 0f;
				return result;
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000B5514 File Offset: 0x000B3714
		public DataGridView ConvertDataGridToDGV(DataGridView myd)
		{
			DataGridView result;
			if (myd == null)
			{
				result = null;
			}
			else
			{
				result = Module1.ConvertDataGridToDGV(myd, true, true);
			}
			return result;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000B5534 File Offset: 0x000B3734
		private void DrawTextHollow(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, float angle = 0f, float minfontsize = 0f)
		{
			this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, "", textforecolor, myformat, minfontsize, false, Color.White, Color.Black, 1, angle);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000B5580 File Offset: 0x000B3780
		private void MydrawtextHollow(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float angle)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			if (!mulline)
			{
				stringFormatFlags |= StringFormatFlags.NoWrap;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoWrap;
			}
			if (overflow)
			{
				stringFormatFlags |= StringFormatFlags.NoClip;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoClip;
			}
			if (directrighttoleft)
			{
				stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
			}
			if (directionVertical)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			this.MydrawtextHollow(x, y, mywidth, myheight, s, color, myHalg, myValg, stringFormatFlags, angle);
			stringFormat.Dispose();
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000B5608 File Offset: 0x000B3808
		private void MydrawtextHollow(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags, float angle)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags = (myflags & ~StringFormatFlags.LineLimit);
			stringFormat.Alignment = myHalg;
			stringFormat.LineAlignment = myValg;
			RectangleF layoutRect = new RectangleF(x + (float)this.mypagesetting.Margins.Left, y + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddString(s, this.myfont.FontFamily, (int)this.myfont.Style, (float)((double)this.myfont.Size * 1.38), layoutRect, stringFormat);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			this.myg.RotateTransform(angle);
			this.myg.DrawPath(new Pen(color), graphicsPath);
			this.myg.RotateTransform(0f - angle);
			this.myg.Transform = transform;
			stringFormat.Dispose();
			graphicsPath.Dispose();
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000B5714 File Offset: 0x000B3914
		private void MydrawtextShape(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, int depth)
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags &= ~StringFormatFlags.LineLimit;
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			stringFormat.Alignment = myHalg;
			stringFormat.LineAlignment = myValg;
			if (!mulline)
			{
				stringFormatFlags |= StringFormatFlags.NoWrap;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoWrap;
			}
			if (overflow)
			{
				stringFormatFlags |= StringFormatFlags.NoClip;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoClip;
			}
			if (directrighttoleft)
			{
				stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
			}
			if (directionVertical)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			stringFormat.FormatFlags = stringFormatFlags;
			RectangleF layoutRect = new RectangleF(x + (float)this.mypagesetting.Margins.Left, y + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddString(s, this.myfont.FontFamily, (int)this.myfont.Style, (float)((double)this.myfont.Size * 1.4), layoutRect, stringFormat);
			stringFormat.Dispose();
			graphicsPath.Dispose();
			layoutRect = default(RectangleF);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000B582C File Offset: 0x000B3A2C
		public string GetCurrentPrinterName()
		{
			return this.Pd.PrinterSettings.PrinterName;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000B584C File Offset: 0x000B3A4C
		public void SetCurrentPrinterName(string printername)
		{
			printername = printername.Trim();
			if (Module1.IsValidPrinterName(printername) && Operators.CompareString(this.Pd.PrinterSettings.PrinterName.ToLower(), printername.ToLower(), false) != 0)
			{
				this.Pd.PrinterSettings.PrinterName = printername;
				this.mypagesetting.PrinterSettings.PrinterName = printername;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000079AC File Offset: 0x00005BAC
		public void CreatePaper(string papername, int width, int height)
		{
			Module1.CreatePaper(this.GetCurrentPrinterName(), papername, width, height);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000B58B0 File Offset: 0x000B3AB0
		public bool IsValidPaper(string papername)
		{
			return Module1.IsValidPaper(this.GetCurrentPrinterName(), papername);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000B58CC File Offset: 0x000B3ACC
		public PaperSize GetPaperSize(string papername)
		{
			return definepaper.GetPrintForm(this.GetCurrentPrinterName(), papername);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000B58E8 File Offset: 0x000B3AE8
		public PaperSize GetPaperSize(PaperKind paperkind)
		{
			return definepaper.GetPrintForm(this.GetCurrentPrinterName(), paperkind);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000B5904 File Offset: 0x000B3B04
		public float ConvertInchToCm(float xx)
		{
			return Module1.ConvertInchToCm(xx);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000B591C File Offset: 0x000B3B1C
		public float ConvertInchToMm(float xx)
		{
			return Module1.ConvertInchToMm(xx);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x000B5934 File Offset: 0x000B3B34
		public float ConvertCmToInch(float xx)
		{
			return Module1.ConvertCmToInch(xx);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000B594C File Offset: 0x000B3B4C
		public float ConvertMmToInch(float xx)
		{
			return Module1.ConvertMmToInch(xx);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000B5964 File Offset: 0x000B3B64
		public void SetPageBackGroundImage(string imagefilename)
		{
			if (!MyProject.Computer.FileSystem.FileExists(imagefilename))
			{
				this.mypagebackgroundimage = null;
			}
			else
			{
				try
				{
					this.mypagebackgroundimage = Image.FromFile(imagefilename);
				}
				catch (Exception ex)
				{
					this.mypagebackgroundimage = null;
				}
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000079BC File Offset: 0x00005BBC
		public void SetPageBackGroundImage(Image img)
		{
			this.mypagebackgroundimage = img;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000B59C0 File Offset: 0x000B3BC0
		public bool ExportDGVToExcel2(DataGridView dgv, string title)
		{
			return this.ExportDGVToExcel2(dgv, title, "", true);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000B59DC File Offset: 0x000B3BDC
		public bool ExportDGVToExcel2(DataGridView dgv, string title, string filename, bool isopenfile)
		{
			return this.ExportDGVToExcel2(dgv, title, filename, "", "", isopenfile);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000B5A00 File Offset: 0x000B3C00
		public bool ExportDGVToExcel2(DataGridView dgv, string title, string filename, string TableHeader, string TableFooter, bool isopenfile)
		{
			return DGVToExcelFile.myNewDGVtoExcel(dgv, filename, title, TableHeader, TableFooter, isopenfile);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000B5A1C File Offset: 0x000B3C1C
		public bool ExportDGVToExcel(DataGridView dgv)
		{
			return DGVtoExcel.DGVToExcel(dgv, "", "", "", "", "", true);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000B5A4C File Offset: 0x000B3C4C
		public bool ExportDGVToExcel(DataGridView dgv, string title)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, "", "", "", "", true);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000B5A78 File Offset: 0x000B3C78
		public bool ExportDGVToExcel(DataGridView dgv, string title, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, "", TableHeader, TableFooter, "", true);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000B5A9C File Offset: 0x000B3C9C
		public bool ExportDGVToExcel(DataGridView dgv, string title, string filename)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, filename, "", "", "", true);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000B5AC4 File Offset: 0x000B3CC4
		public bool ExportDGVToExcel(DataGridView dgv, string title, string filename, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, filename, TableHeader, TableFooter, "", true);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x000B5AE4 File Offset: 0x000B3CE4
		public bool ExportDGVToExcel(DataGridView dgv, string title, string filename, string TableHeader, string TableFooter, string sheetname)
		{
			return DGVtoExcel.DGVToExcel(dgv, title, filename, TableHeader, TableFooter, sheetname, true);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000B5B00 File Offset: 0x000B3D00
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, "", "", "", true);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000B5B28 File Offset: 0x000B3D28
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, "", TableHeader, TableFooter, true);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000B5B48 File Offset: 0x000B3D48
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string filename)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, filename, "", "", true);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000B5B6C File Offset: 0x000B3D6C
		public bool ExportDGVToExcel(DataGridView dgv, string title, TreeView columnheadertreeview, string filename, string TableHeader, string TableFooter)
		{
			return DGVtoExcel.DGVToExcel(dgv, columnheadertreeview, title, filename, TableHeader, TableFooter, true);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000B5B88 File Offset: 0x000B3D88
		public bool ImportExcelToDGV(string filename, DataGridView dgv)
		{
			bool result;
			if (dgv == null)
			{
				result = false;
			}
			else
			{
				bool allowUserToAddRows = dgv.AllowUserToAddRows;
				dgv.AllowUserToAddRows = false;
				bool flag;
				if (dgv.ColumnCount <= 0)
				{
					flag = ExcelToDGV.ImportExcelToDGV(filename, dgv, true, false);
				}
				else
				{
					flag = ExcelToDGV.ImportExcelToDGV(filename, dgv, false, true);
				}
				dgv.AllowUserToAddRows = allowUserToAddRows;
				result = flag;
			}
			return result;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x000079C5 File Offset: 0x00005BC5
		public void CopyDataGridView(DataGridView sdv, DataGridView ddv, bool IsAddRowHeaderColumn = false)
		{
			Module1.CopyDataGridView(sdv, ddv, IsAddRowHeaderColumn);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00003741 File Offset: 0x00001941
		public void CopyDataGridView(DataGridView sdv, DataGridView ddv, int fromrow, int torow)
		{
			Module1.CopyDataGridView(sdv, ddv, fromrow, torow, false);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000B5BD4 File Offset: 0x000B3DD4
		public void CopyDataGridViewSelectedRange(DataGridView sdv, DataGridView ddv, VB2008Print.DGVCopyRange copyrange)
		{
			if (sdv != null && ddv != null)
			{
				try
				{
					switch (copyrange)
					{
						case VB2008Print.DGVCopyRange.SelectedRows:
							Module1.CopyDataGridView(sdv, ddv, Module1.GetDGVSelectedMinRowIndex(sdv), Module1.GetDGVSelectedMaxRowIndex(sdv), false);
							Module1.SetDGVSelectedRowsVisible(sdv, ddv, Module1.GetDGVSelectedMinRowIndex(sdv));
							break;
						case VB2008Print.DGVCopyRange.SelectedColumns:
							Module1.CopyDataGridView(sdv, ddv, false);
							Module1.SetDGVSelectedColumnsVisible(sdv, ddv);
							break;
						case VB2008Print.DGVCopyRange.SelectedRowsAndColumns:
							Module1.CopyDataGridView(sdv, ddv, Module1.GetDGVSelectedMinRowIndex(sdv), Module1.GetDGVSelectedMaxRowIndex(sdv), false);
							Module1.SetDGVSelectedRowsAndColumnsVisible(sdv, ddv, Module1.GetDGVSelectedMinRowIndex(sdv));
							break;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x000079CF File Offset: 0x00005BCF
		public void PrintTreeView(TreeView trv, int level)
		{
			this.PrintTreeView(trv, "", null, this.TextColor, 0, level);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000079E6 File Offset: 0x00005BE6
		public void PrintTreeView(TreeView trv)
		{
			this.PrintTreeView(trv, "");
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000079F4 File Offset: 0x00005BF4
		public void PrintTreeView(TreeView trv, string title)
		{
			this.PrintTreeView(trv, title, null, this.TextColor, 0);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00007A06 File Offset: 0x00005C06
		public void PrintTreeView(TreeView trv, string title, Font titlefont)
		{
			this.PrintTreeView(trv, title, titlefont, this.TextColor, 0);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00007A18 File Offset: 0x00005C18
		public void PrintTreeView(TreeView trv, string title, Font titlefont, Color titlecolor, int titlestyle)
		{
			this.PrintTreeView(trv, title, titlefont, titlecolor, titlestyle, 0);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00007A28 File Offset: 0x00005C28
		public void PrintTreeView(TreeView trv, string title, int level)
		{
			this.PrintTreeView(trv, title, null, this.TextColor, 0, level);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x000B5C70 File Offset: 0x000B3E70
		public void PrintTreeView(TreeView trv, string title, Font titlefont, Color titlecolor, int titlestyle, int level)
		{
			if (!this.CancelDocument && trv != null && trv.Nodes.Count > 0)
			{
				TreeView treeView = new TreeView();
				Module1.CopyTreeView(trv, ref treeView, false);
				if (titlefont == null)
				{
					titlefont = new Font("黑体", 18f, FontStyle.Bold);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (Operators.CompareString(title, "", false) != 0)
				{
					this.DrawText(title, this.PaperPrintWidth, titlefont, titlecolor, stringFormat, titlestyle);
					this.NewRow((float)((double)this.LastDrawTextHeight * 1.8));
				}
				this.PrintNode(this.Currentx, this.Currenty, treeView, treeView.Nodes[0], level);
				this.Currentx = 0f;
				stringFormat.Dispose();
				treeView.Dispose();
				treeView = null;
			}
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000B5D4C File Offset: 0x000B3F4C
		private void PrintNode(float x, float y, TreeView tv, TreeNode node, int level)
		{
			if (!this.CancelDocument && !(level != 0 & checked(node.Level + 1) > level))
			{
				Image minusbox = Resources.minusbox;
				float height = this.MeasureCell("游平阳艳华", tv.Font).Height;
				float num = height / 3f * 2f;
				this.Currenty = y;
				float num2 = height - num;
				float num3 = height / 5f;
				if (this.MyIsNewPage(height, true))
				{
					y = 0f;
				}
				float num4;
				if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
				{
					num4 = 20f;
				}
				else
				{
					num4 = this.ConvertMmToInch(2f) * 100f;
				}
				string text = node.Text;
				Font font;
				if (node.NodeFont == null)
				{
					font = tv.Font;
				}
				else
				{
					font = node.NodeFont;
				}
				Color foreColor;
				if (node.ForeColor.Equals(Color.Empty))
				{
					foreColor = tv.ForeColor;
				}
				else
				{
					foreColor = node.ForeColor;
				}
				Image stateImage = VB2008Print.GetStateImage(tv, node);
				Image image = this.GetImage(tv, node);
				this.Currentx = x;
				if (node.Nodes.Count > 0)
				{
					this.DrawImage(minusbox, this.Currentx, y, height, height, false, StringAlignment.Center, StringAlignment.Center);
					this.Currentx = x + height;
					this.DrawDashLine(this.Currentx, y + height / 2f, this.Currentx + num4, y + height / 2f, tv.LineColor, 1f, DashStyle.Dot);
				}
				else
				{
					this.DrawDashLine(this.Currentx + height / 2f, y + height / 2f, this.Currentx + height + num4, y + height / 2f, tv.LineColor, 1f, DashStyle.Dot);
				}
				this.Currentx = x + height + num4;
				if (stateImage != null)
				{
					this.DrawImageForTreeView(stateImage, this.Currentx, y, height, height, false, StringAlignment.Center, StringAlignment.Center);
					this.Currentx += height;
				}
				if (image != null)
				{
					this.DrawImageForTreeView(image, this.Currentx, y, height, height, false, StringAlignment.Center, StringAlignment.Center);
					this.Currentx += height;
				}
				this.Currentx += num2;
				this.Currenty = y;
				float width = this.MeasureCell(text, font).Width;
				Color backcolor;
				if (node.BackColor.Equals(Color.Empty))
				{
					backcolor = Color.White;
				}
				else
				{
					backcolor = node.BackColor;
				}
				this.DrawCell(text, width, height, font, foreColor, "0000", StringAlignment.Center, StringAlignment.Center, false, true, false, false, font.Size, backcolor, Color.Black, 0);
				this.Currenty = this.Currenty + height + num3;
				node.Tag = Conversions.ToString(x + height / 2f);
				if (node.NextNode != null)
				{
					if (node.Nodes.Count > 0)
					{
						this.DrawDashLine(x + height / 2f, y + height, x + height / 2f, y + height + height / 2f + num3, tv.LineColor, 1f, DashStyle.Dot);
					}
					else
					{
						this.DrawDashLine(x + height / 2f, y + height / 2f, x + height / 2f, y + height + height / 2f + num3, tv.LineColor, 1f, DashStyle.Dot);
					}
				}
				this.PrintBrotherLine(y + height / 2f, node.Parent, height + num3, tv);
				if (node.Nodes.Count > 0)
				{
					float num5;
					if (stateImage != null | image != null)
					{
						num5 = x + height + num4;
					}
					else
					{
						num5 = x + height + num2;
					}
					this.DrawDashLine(num5 + height / 2f, y + height, num5 + height / 2f, this.Currenty + height / 2f, tv.LineColor, 1f, DashStyle.Dot);
					this.PrintNode(num5, this.Currenty, tv, node.Nodes[0], level);
				}
				if (node.NextNode != null)
				{
					this.PrintNode(x, this.Currenty, tv, node.NextNode, level);
				}
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000B6180 File Offset: 0x000B4380
		private void PrintBrotherLine(float y, TreeNode node, float lineheight, TreeView tv)
		{
			if (!this.CancelDocument && node != null)
			{
				try
				{
					float num = Conversions.ToSingle(node.Tag);
					if (node.NextNode != null)
					{
						this.DrawDashLine(num, y, num, y + lineheight, tv.LineColor, 1f, DashStyle.Dot);
					}
				}
				catch (Exception ex)
				{
				}
				this.PrintBrotherLine(y, node.Parent, lineheight, tv);
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000B61F8 File Offset: 0x000B43F8
		private static Image GetStateImage(TreeView tv, TreeNode node)
		{
			Image result;
			if (tv.CheckBoxes)
			{
				if (node.Checked)
				{
					result = Resources.check;
				}
				else
				{
					result = Resources.uncheck;
				}
			}
			else if (tv.StateImageList == null)
			{
				result = null;
			}
			else
			{
				Image image;
				if (node.StateImageIndex >= 0)
				{
					try
					{
						image = tv.StateImageList.Images[node.StateImageIndex];
						goto IL_87;
					}
					catch (Exception ex)
					{
						image = null;
						goto IL_87;
					}
				}
				try
				{
					image = tv.StateImageList.Images[node.StateImageKey];
				}
				catch (Exception ex2)
				{
					image = null;
				}
			IL_87:
				result = image;
			}
			return result;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x000B62AC File Offset: 0x000B44AC
		private Image GetImage(TreeView tv, TreeNode node)
		{
			Image result;
			if (tv.ImageList == null)
			{
				result = null;
			}
			else
			{
				Image image;
				if (node.ImageIndex >= 0)
				{
					try
					{
						image = tv.ImageList.Images[node.ImageIndex];
						goto IL_6A;
					}
					catch (Exception ex)
					{
						image = null;
						goto IL_6A;
					}
				}
				try
				{
					image = tv.ImageList.Images[node.ImageKey];
				}
				catch (Exception ex2)
				{
					image = null;
				}
			IL_6A:
				if (image == null)
				{
					if (tv.ImageIndex >= 0)
					{
						try
						{
							image = tv.ImageList.Images[tv.ImageIndex];
							goto IL_C8;
						}
						catch (Exception ex3)
						{
							image = null;
							goto IL_C8;
						}
					}
					try
					{
						image = tv.ImageList.Images[tv.ImageKey];
					}
					catch (Exception ex4)
					{
						image = null;
					}
				}
			IL_C8:
				result = image;
			}
			return result;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000B63B8 File Offset: 0x000B45B8
		public DataGridView ConvertListViewToDGV(ListView lv)
		{
			return Module1.ConvertListViewToDGV(lv);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000B63D0 File Offset: 0x000B45D0
		public string SmallToBig(ref decimal ad_number)
		{
			string[] array = new string[16];
			string[] array2 = new string[16];
			array[1] = "分";
			array[2] = "角";
			array[3] = "";
			array[4] = "元";
			array[5] = "拾";
			array[6] = "佰";
			array[7] = "仟";
			array[8] = "万";
			array[9] = "拾";
			array[10] = "佰";
			array[11] = "仟";
			array[12] = "亿";
			array[13] = "拾";
			array[14] = "佰";
			array[15] = "仟";
			array2[1] = "壹";
			array2[2] = "贰";
			array2[3] = "叁";
			array2[4] = "肆";
			array2[5] = "伍";
			array2[6] = "陆";
			array2[7] = "柒";
			array2[8] = "捌";
			array2[9] = "玖";
			array2[10] = "零";
			checked
			{
				string result;
				if (decimal.Compare(ad_number, 0m) == 0)
				{
					result = "零元整";
				}
				else
				{
					string text = Strings.Format(ad_number, "############0.00");
					if (Strings.Len(text) > 15)
					{
						result = "";
						if (this.IsShowErrorMSG)
						{
							Interaction.MsgBox("大写金额转换时出错,本程序允许的最大可转换金额为9仟亿,超过此金额时不能转换", MsgBoxStyle.OkOnly, "提示信息");
						}
					}
					else
					{
						if (Strings.Len(text) <= 15)
						{
							text = " " + text;
						}
						string text2;
						if (Operators.CompareString(Strings.Right(text, 1), "0", false) == 0)
						{
							text2 = "整";
						}
						else
						{
							text2 = "";
						}
						for (; ; )
						{
							int num;
							num++;
							int num2 = Strings.Len(text);
							string text3 = Strings.Right(text, 1);
							text = Strings.Left(text, num2 - 1);
							if (Operators.CompareString(text3, " ", false) == 0 | (Operators.CompareString(text, " ", false) == 0 & Operators.CompareString(text3, "0", false) == 0))
							{
								break;
							}
							if (Operators.CompareString(text3, ".", false) != 0)
							{
								if (Operators.CompareString(text3, "-", false) == 0)
								{
									text2 = "负" + text2;
								}
								else if (Operators.CompareString(text3, "0", false) != 0)
								{
									text2 = array2[Conversions.ToInteger(text3)] + array[num] + text2;
									bool flag = true;
								}
								else
								{
									bool flag;
									if (flag)
									{
										if ((num != 4 & num != 2) | Conversions.ToSingle(text) != 0f)
										{
											text2 = "零" + text2;
										}
										flag = false;
									}
									if ((num == 12 | num == 8) && Operators.CompareString(Strings.Right(text, 3), "000", false) != 0)
									{
										text2 = array[num] + text2;
									}
									if (num == 4 && Conversions.ToSingle(text) != 0f)
									{
										text2 = array[num] + text2;
									}
								}
							}
						}
						result = text2;
					}
				}
				return result;
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000B66C4 File Offset: 0x000B48C4
		public SizeF GetQRBarSize(string txt, string character)
		{
			if (Operators.CompareString(character, "", false) == 0)
			{
				character = "UTF-8";
			}
			SizeF result;
			if (Operators.CompareString(txt, "", false) == 0)
			{
				SizeF sizeF = new SizeF(0f, 0f);
				result = sizeF;
			}
			else
			{
				MultiFormatWriter multiFormatWriter = new MultiFormatWriter();
				BitMatrix bitMatrix = multiFormatWriter.encode(txt, (ZXing.BarcodeFormat)2048, 1, 1, new Dictionary<EncodeHintType, object>
				{
					{
						(EncodeHintType)4,
						character
					}
				});
				int width = bitMatrix.Width;
				int height = bitMatrix.Height;
				SizeF sizeF = new SizeF((float)Math.Ceiling((double)this.ConvFromDisplay((float)width, true)), (float)Math.Ceiling((double)this.ConvFromDisplay((float)height, false)));
				result = sizeF;
			}
			return result;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000B6774 File Offset: 0x000B4974
		public SizeF GetQRBarSize(string txt)
		{
			return this.GetQRBarSize(txt, "");
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00007A3B File Offset: 0x00005C3B
		public void DrawQRBarZxing(string txt, float thewidth)
		{
			this.DrawQRBarZxing(txt, thewidth, Color.Black, Color.White, "");
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000B6790 File Offset: 0x000B4990
		public void DrawQRBarZxing(string txt, float thewidth, Color forecolor, Color backcolor, string character)
		{
			if (thewidth <= 0f)
			{
				thewidth = this.GetQRBarSize(txt).Width;
			}
			int num = checked((int)Math.Round(Math.Ceiling((double)this.ConvToDisplay(thewidth, true))));
			if (Operators.CompareString(character, "", false) == 0)
			{
				character = "UTF-8";
			}
			MultiFormatWriter multiFormatWriter = new MultiFormatWriter();
			BitMatrix matrix = multiFormatWriter.encode(txt, (ZXing.BarcodeFormat)2048, num, num, new Dictionary<EncodeHintType, object>
			{
				{
					(EncodeHintType)4,
					character
				}
			});
			Bitmap bitmap = this.toBitmap(matrix, forecolor, backcolor);
			if (bitmap != null)
			{
				this.DrawImageUnscaled(bitmap, this.Currentx, this.Currenty);
			}
			if (bitmap != null)
			{
				bitmap.Dispose();
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000B6838 File Offset: 0x000B4A38
		private Bitmap toBitmap(BitMatrix matrix, Color forcolor, Color bkcolor)
		{
			int width = matrix.Width;
			int height = matrix.Height;
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			int num = 0;
			checked
			{
				int num2 = width - 1;
				for (int i = num; i <= num2; i++)
				{
					int num3 = 0;
					int num4 = height - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (matrix[i, j])
						{
							bitmap.SetPixel(i, j, forcolor);
						}
						else
						{
							bitmap.SetPixel(i, j, bkcolor);
						}
					}
				}
				return bitmap;
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000B68B4 File Offset: 0x000B4AB4
		public void DrawBarZxing(string txt, VB2008Print.BarcodeFormat bartype, float width, float height)
		{
			this.DrawBarZxing(txt, bartype, width, height, Color.Black, Color.White, 4, "");
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000B68DC File Offset: 0x000B4ADC
		public void DrawBarZxing(string txt, VB2008Print.BarcodeFormat bartype, float width, float height, Color forecolor, Color backcolor, int margin)
		{
			this.DrawBarZxing(txt, bartype, width, height, forecolor, backcolor, margin, "");
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000B6900 File Offset: 0x000B4B00
		public void DrawBarZxing(string txt, VB2008Print.BarcodeFormat bartype, float width, float height, Color forecolor, Color backcolor, int margin, string character)
		{
			checked
			{
				int num = (int)Math.Round((double)this.ConvToDisplay(width, true));
				int num2 = (int)Math.Round((double)this.ConvToDisplay(height, true));
				if (!(num <= 0 | num2 <= 0))
				{
					Bitmap qrbmp = ZXingBarCode.GetQRbmp(txt, num, num2, forecolor, backcolor, (int)bartype, margin, character);
					if (qrbmp != null)
					{
						this.DrawImage(qrbmp, this.Currentx, this.Currenty, width, height, true, StringAlignment.Center, StringAlignment.Center);
					}
					if (qrbmp != null)
					{
						qrbmp.Dispose();
					}
				}
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00007A54 File Offset: 0x00005C54
		public void DrawQRCode(string txt, float width, float height, int margin = 2)
		{
			this.DrawQRCode(txt, width, height, Color.Black, Color.White, margin, "UTF-8");
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000B697C File Offset: 0x000B4B7C
		public void DrawQRCode(string txt, float width, float height, Color forecolor, Color backcolor, int margin, string character)
		{
			checked
			{
				int num = (int)Math.Round((double)this.ConvToDisplay(width, true));
				int num2 = (int)Math.Round((double)this.ConvToDisplay(height, true));
				if (!(num <= 0 | num2 <= 0))
				{
					Bitmap qrbmp = ZXingBarCode.GetQRbmp(txt, num, num2, forecolor, backcolor, 2048, margin, character);
					if (qrbmp != null)
					{
						this.DrawImage(qrbmp, this.Currentx, this.Currenty, width, height, true, StringAlignment.Center, StringAlignment.Center);
					}
					if (qrbmp != null)
					{
						qrbmp.Dispose();
					}
				}
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00007A70 File Offset: 0x00005C70
		public void DrawBar(VB2008Print.BarCode barType, string code, float width, float height, Font tfont, Color theforecolor)
		{
			this.DrawBar(barType, code, width, height, tfont, theforecolor, true);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000B69F8 File Offset: 0x000B4BF8
		public void DrawBar(VB2008Print.BarCode barType, string code, float width, float height, Font tfont, Color theforecolor, bool IsPrintText)
		{
			float currentx = this.Currentx;
			float currenty = this.Currenty;
			switch (barType)
			{
				case VB2008Print.BarCode.EAN13:
					this.DrawBarCodeEAN13(code, width, height, tfont, theforecolor, IsPrintText);
					goto IL_2B9;
				case VB2008Print.BarCode.ENA8:
					this.DrawBarCodeEAN8(code, width, height, tfont, theforecolor, IsPrintText);
					goto IL_2B9;
				case VB2008Print.BarCode.Code39:
					this.DrawBarCode39(code, width, height, tfont, theforecolor, IsPrintText);
					goto IL_2B9;
				case VB2008Print.BarCode.Code128:
					{
						Code128New code128New = new Code128New(code);
						try
						{
							this.DrawBar(code, code128New.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
							goto IL_2B9;
						}
						catch (Exception ex)
						{
							goto IL_2B9;
						}
						break;
					}
				case VB2008Print.BarCode.Code128A:
					break;
				case VB2008Print.BarCode.Code128B:
					goto IL_103;
				case VB2008Print.BarCode.Code128C:
					goto IL_142;
				case VB2008Print.BarCode.Codabar:
					goto IL_181;
				case VB2008Print.BarCode.Code11:
					goto IL_1BC;
				case VB2008Print.BarCode.Code25:
					goto IL_1FA;
				case VB2008Print.BarCode.Code25_Stand:
					{
						Code_stand25 code_stand = new Code_stand25(code);
						try
						{
							this.DrawBar(code_stand.RawData, code_stand.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
							goto IL_2B9;
						}
						catch (Exception ex2)
						{
							goto IL_2B9;
						}
						goto IL_247;
					}
				case VB2008Print.BarCode.ISBN:
					goto IL_247;
				case VB2008Print.BarCode.CODE39Extended:
					goto IL_283;
				default:
					goto IL_2B9;
			}
			Code128 code2 = new Code128(code, Code128.Code128Type.A);
			try
			{
				this.DrawBar(code2.RawData, code2.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex3)
			{
				goto IL_2B9;
			}
		IL_103:
			Code128 code3 = new Code128(code, Code128.Code128Type.B);
			try
			{
				this.DrawBar(code3.RawData, code3.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex4)
			{
				goto IL_2B9;
			}
		IL_142:
			Code128 code4 = new Code128(code, Code128.Code128Type.C);
			try
			{
				this.DrawBar(code4.RawData, code4.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex5)
			{
				goto IL_2B9;
			}
		IL_181:
			Codabar codabar = new Codabar(code);
			try
			{
				this.DrawBar(codabar.RawData, codabar.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex6)
			{
				goto IL_2B9;
			}
		IL_1BC:
			Code11 code5 = new Code11(code);
			try
			{
				this.DrawBar(code5.RawData, code5.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex7)
			{
				goto IL_2B9;
			}
		IL_1FA:
			this.DrawBarCode25(code, width, height, tfont, theforecolor, IsPrintText);
			goto IL_2B9;
		IL_247:
			ISBN isbn = new ISBN(code);
			try
			{
				string encoded_Value = isbn.Encoded_Value;
				this.DrawBar(isbn.RawData, encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
				goto IL_2B9;
			}
			catch (Exception ex8)
			{
				goto IL_2B9;
			}
		IL_283:
			CODE39Extended code39Extended = new CODE39Extended(code, true);
			try
			{
				this.DrawBar(code39Extended.RawData, code39Extended.Encoded_Value, width, height, tfont, Color.Transparent, theforecolor, IsPrintText);
			}
			catch (Exception ex9)
			{
			}
		IL_2B9:
			this.Currentx = currentx;
			this.Currenty = currenty;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000B6D3C File Offset: 0x000B4F3C
		private void DrawBarCode39(string code, float width, float height, Font tfont, Color theforecolor, bool IsPrintText = true)
		{
			string[,] array = new string[45, 3];
			int num = checked((code.Length - 1) * 2 + 15 * code.Length + 30 + 20);
			float num2 = width / (float)num;
			code = code.Trim();
			code = code.ToUpper();
			float num3 = this.Currentx;
			float currenty = this.Currenty;
			float num4 = height / 5f;
			if (!IsPrintText)
			{
				num4 = 0f;
			}
			height -= num4;
			array[0, 0] = "0";
			array[0, 1] = "101001101101";
			array[1, 0] = "1";
			array[1, 1] = "110100101011";
			array[2, 0] = "2";
			array[2, 1] = "101100101011";
			array[3, 0] = "3";
			array[3, 1] = "110110010101";
			array[4, 0] = "4";
			array[4, 1] = "101001101011";
			array[5, 0] = "5";
			array[5, 1] = "110100110101";
			array[6, 0] = "6";
			array[6, 1] = "101100110101";
			array[7, 0] = "7";
			array[7, 1] = "101001011011";
			array[8, 0] = "8";
			array[8, 1] = "110100101101";
			array[9, 0] = "9";
			array[9, 1] = "101100101101";
			array[10, 0] = "A";
			array[10, 1] = "110101001011";
			array[11, 0] = "B";
			array[11, 1] = "101101001011";
			array[12, 0] = "C";
			array[12, 1] = "110110100101";
			array[13, 0] = "D";
			array[13, 1] = "101011001011";
			array[14, 0] = "E";
			array[14, 1] = "110101100101";
			array[15, 0] = "F";
			array[15, 1] = "101101100101";
			array[16, 0] = "G";
			array[16, 1] = "101010011011";
			array[17, 0] = "H";
			array[17, 1] = "110101001101";
			array[18, 0] = "I";
			array[18, 1] = "101101001101";
			array[19, 0] = "J";
			array[19, 1] = "101011001101";
			array[20, 0] = "K";
			array[20, 1] = "110101010011";
			array[21, 0] = "L";
			array[21, 1] = "101101010011";
			array[22, 0] = "M";
			array[22, 1] = "110110101001";
			array[23, 0] = "N";
			array[23, 1] = "101011010011";
			array[24, 0] = "O";
			array[24, 1] = "110101101001";
			array[25, 0] = "P";
			array[25, 1] = "101101101001";
			array[26, 0] = "Q";
			array[26, 1] = "101010110011";
			array[27, 0] = "R";
			array[27, 1] = "110101011001";
			array[28, 0] = "S";
			array[28, 1] = "101101011001";
			array[29, 0] = "T";
			array[29, 1] = "101011011001";
			array[30, 0] = "U";
			array[30, 1] = "110010101011";
			array[31, 0] = "V";
			array[31, 1] = "100110101011";
			array[32, 0] = "W";
			array[32, 1] = "110011010101";
			array[33, 0] = "X";
			array[33, 1] = "100101101011";
			array[34, 0] = "Y";
			array[34, 1] = "110010110101";
			array[35, 0] = "Z";
			array[35, 1] = "100110110101";
			array[36, 0] = "-";
			array[36, 1] = "100101011011";
			array[37, 0] = ".";
			array[37, 1] = "110010101101";
			array[38, 0] = " ";
			array[38, 1] = "100110101101 ";
			array[39, 0] = "*";
			array[39, 1] = "100101101101";
			array[40, 0] = "$";
			array[40, 1] = "100100100101";
			array[41, 0] = "/";
			array[41, 1] = "100100101001";
			array[42, 0] = "+";
			array[42, 1] = "100101001001";
			array[43, 0] = "%";
			array[43, 1] = "101001001001";
			string text = "0000000000";
			text += array[39, 1];
			text += "0";
			int num5 = 0;
			checked
			{
				int num6 = code.Length - 1;
				int i = num5;
			IL_5A7:
				while (i <= num6)
				{
					int num7 = 0;
					while (array[num7, 0][0] != code[i])
					{
						num7++;
						if (num7 > 43)
						{
						IL_58C:
							if (num7 < 44)
							{
								text += "0";
								i++;
								goto IL_5A7;
							}
							return;
						}
					}
					text += array[num7, 1];
					goto IL_58C;
				}
				text += array[39, 1];
				text += "0000000000";
				RectangleF myrect = unchecked(new RectangleF(num3 + num2 * 8f, currenty + height, num2 * (float)(checked(text.Length - 16)), num4));
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (IsPrintText)
				{
					this.DrawText(code, myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				int num8 = 0;
				int num9 = text.Length - 1;
				for (int j = num8; j <= num9; j++)
				{
					RectangleF myrect2 = new RectangleF(num3, currenty, num2, height);
					if (Operators.CompareString(Conversions.ToString(text[j]), "1", false) == 0)
					{
						this.DrawFillRect(myrect2, theforecolor);
					}
					unchecked
					{
						num3 += num2;
					}
				}
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000B73B8 File Offset: 0x000B55B8
		private void DrawBarCodeEAN13(string Code, float width, float height, Font tfont, Color theforecolor, bool IsPrintText = true)
		{
			float num = this.Currentx;
			float currenty = this.Currenty;
			float num2 = height / 5f;
			if (!IsPrintText)
			{
				num2 = 0f;
			}
			height -= num2;
			Code = Code.Trim();
			try
			{
				Convert.ToDouble(Code);
			}
			catch (Exception ex)
			{
				return;
			}
			if (!(Code.Length < 12 | Code.Length > 13))
			{
				if (Code.Length == 13)
				{
					if (Code[12] != VB2008Print.ENA13_J(Code)[0])
					{
						return;
					}
				}
				else
				{
					Code += VB2008Print.ENA13_J(Code);
				}
				width -= this.ConvFromDisplay(3f, true);
				float num3 = 1f;
				width *= num3;
				string[] array = new string[11];
				array[0] = "0001101";
				array[1] = "0011001";
				array[2] = "0010011";
				array[3] = "0111101";
				array[4] = "0100011";
				array[5] = "0110001";
				array[6] = "0101111";
				array[7] = "0111011";
				array[8] = "0110111";
				array[9] = "0001011";
				string[] array2 = new string[11];
				array2[0] = "0100111";
				array2[1] = "0110011";
				array2[2] = "0011011";
				array2[3] = "0100001";
				array2[4] = "0011101";
				array2[5] = "0111001";
				array2[6] = "0000101";
				array2[7] = "0010001";
				array2[8] = "0001001";
				array2[9] = "0010111";
				string[] array3 = new string[11];
				array3[0] = "1110010";
				array3[1] = "1100110";
				array3[2] = "1101100";
				array3[3] = "1000010";
				array3[4] = "1011100";
				array3[5] = "1001110";
				array3[6] = "1010000";
				array3[7] = "1000100";
				array3[8] = "1001000";
				array3[9] = "1110100";
				string[] array4 = new string[]
				{
					"AAAAAA",
					"AABABB",
					"AABBAB",
					"AABBBA",
					"ABAABB",
					"ABBAAB",
					"ABBBAA",
					"ABABAB",
					"ABABBA",
					"ABBABA"
				};
				string text = "000000000";
				text += "101";
				int num4 = Convert.ToInt32(Convert.ToString(Code[0]));
				int num5 = 1;
				float num7;
				checked
				{
					do
					{
						if (num5 < 7)
						{
							int num6 = Convert.ToInt32(Convert.ToString(Code[num5]));
							if (Operators.CompareString(Conversions.ToString(array4[num4][num5 - 1]), "A", false) == 0)
							{
								text += array[num6];
							}
							else
							{
								text += array2[num6];
							}
						}
						else
						{
							if (num5 == 7)
							{
								text += "01010";
							}
							text += array3[Convert.ToInt32(Convert.ToString(Code[num5]))];
						}
						num5++;
					}
					while (num5 <= 12);
					text += "101";
					text += "000000000";
					num7 = width / 113f;
				}
				RectangleF myrect = new RectangleF(num + num7 * 12f, currenty + height, num7 * 43f, num2);
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (IsPrintText)
				{
					this.DrawText(Code.Substring(1, 6), myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				myrect = new RectangleF(num + num7 * 59f, currenty + height, num7 * 43f, num2);
				if (IsPrintText)
				{
					this.DrawText(Code.Substring(7, 6), myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				stringFormat.Alignment = StringAlignment.Far;
				myrect = new RectangleF(num + num7 * 0f, currenty + height, num7 * 9f, num2);
				if (IsPrintText)
				{
					this.DrawText(Code.Substring(0, 1), myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				int[] array5 = new int[]
				{
					9,
					10,
					11,
					54,
					55,
					56,
					57,
					58,
					101,
					102,
					103
				};
				int num8 = 0;
				do
				{
					RectangleF myrect2 = new RectangleF(num, currenty, num7, height);
					int num9 = 0;
					do
					{
						if (array5[num9] == num8)
						{
							myrect2 = new RectangleF(num, currenty, num7, height + num2);
						}
						checked
						{
							num9++;
						}
					}
					while (num9 <= 10);
					if (Operators.CompareString(Conversions.ToString(text[num8]), "1", false) == 0)
					{
						this.DrawFillRect(myrect2, theforecolor);
					}
					num += num7;
					checked
					{
						num8++;
					}
				}
				while (num8 <= 112);
				try
				{
					stringFormat.Dispose();
					myrect = default(RectangleF);
					RectangleF myrect2 = default(RectangleF);
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000B78F8 File Offset: 0x000B5AF8
		private void DrawBarCodeEAN8(string Code, float width, float height, Font tfont, Color theforecolor, bool IsPrintText = true)
		{
			float num = this.Currentx;
			float currenty = this.Currenty;
			float num2 = height / 5f;
			if (!IsPrintText)
			{
				num2 = 0f;
			}
			height -= num2;
			Code = Code.Trim();
			try
			{
				Convert.ToDouble(Code);
			}
			catch (Exception ex)
			{
				return;
			}
			if (!(Code.Length < 7 | Code.Length > 8))
			{
				if (Code.Length == 8)
				{
					if (Code[7] != VB2008Print.ENA8_J(Code)[0])
					{
						return;
					}
				}
				else
				{
					Code += VB2008Print.ENA8_J(Code);
				}
				width -= this.ConvFromDisplay(3f, true);
				float num3 = 1f;
				width *= num3;
				string[] array = new string[11];
				array[0] = "0001101";
				array[1] = "0011001";
				array[2] = "0010011";
				array[3] = "0111101";
				array[4] = "0100011";
				array[5] = "0110001";
				array[6] = "0101111";
				array[7] = "0111011";
				array[8] = "0110111";
				array[9] = "0001011";
				string[] array2 = new string[11];
				array2[0] = "0100111";
				array2[1] = "0110011";
				array2[2] = "0011011";
				array2[3] = "0100001";
				array2[4] = "0011101";
				array2[5] = "0111001";
				array2[6] = "0000101";
				array2[7] = "0010001";
				array2[8] = "0001001";
				array2[9] = "0010111";
				string[] array3 = new string[11];
				array3[0] = "1110010";
				array3[1] = "1100110";
				array3[2] = "1101100";
				array3[3] = "1000010";
				array3[4] = "1011100";
				array3[5] = "1001110";
				array3[6] = "1010000";
				array3[7] = "1000100";
				array3[8] = "1001000";
				array3[9] = "1110100";
				string text = "0000000";
				text += "101";
				int num4 = 0;
				float num6;
				checked
				{
					do
					{
						if (num4 < 4)
						{
							int num5 = Convert.ToInt32(Convert.ToString(Code[num4]));
							text += array[num5];
						}
						else
						{
							if (num4 == 4)
							{
								text += "01010";
							}
							text += array3[Convert.ToInt32(Convert.ToString(Code[num4]))];
						}
						num4++;
					}
					while (num4 <= 7);
					text += "101";
					text += "0000000";
					num6 = width / 81f;
				}
				RectangleF myrect = new RectangleF(num + num6 * 10f, currenty + height, num6 * 28f, num2);
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (IsPrintText)
				{
					this.DrawText(Code.Substring(0, 4), myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				myrect = new RectangleF(num + num6 * 43f, currenty + height, num6 * 28f, num2);
				if (IsPrintText)
				{
					this.DrawText(Code.Substring(4, 4), myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				int[] array4 = new int[]
				{
					7,
					8,
					9,
					38,
					39,
					40,
					41,
					42,
					71,
					72,
					73
				};
				int num7 = 0;
				do
				{
					RectangleF myrect2 = new RectangleF(num, currenty, num6, height);
					int num8 = 0;
					do
					{
						if (array4[num8] == num7)
						{
							myrect2 = new RectangleF(num, currenty, num6, height + num2);
						}
						checked
						{
							num8++;
						}
					}
					while (num8 <= 10);
					if (Operators.CompareString(Conversions.ToString(text[num7]), "1", false) == 0)
					{
						this.DrawFillRect(myrect2, theforecolor);
					}
					num += num6;
					checked
					{
						num7++;
					}
				}
				while (num7 <= 80);
				try
				{
					stringFormat.Dispose();
					myrect = default(RectangleF);
					RectangleF myrect2 = default(RectangleF);
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000B7D28 File Offset: 0x000B5F28
		private void DrawBarCode25(string Code, float width, float height, Font tfont, Color theforecolor, bool IsPrintText = true)
		{
			string[,] array = new string[21, 3];
			float num = this.Currentx;
			float currenty = this.Currenty;
			float num2 = height / 5f;
			if (!IsPrintText)
			{
				num2 = 0f;
			}
			height -= num2;
			Code = Code.Trim();
			try
			{
				Convert.ToDouble(Code);
			}
			catch (Exception ex)
			{
				return;
			}
			array[0, 0] = "0";
			array[0, 1] = "00110";
			array[1, 0] = "1";
			array[1, 1] = "10001";
			array[2, 0] = "2";
			array[2, 1] = "01001";
			array[3, 0] = "3";
			array[3, 1] = "11000";
			array[4, 0] = "4";
			array[4, 1] = "00101";
			array[5, 0] = "5";
			array[5, 1] = "10100";
			array[6, 0] = "6";
			array[6, 1] = "01100";
			array[7, 0] = "7";
			array[7, 1] = "00011";
			array[8, 0] = "8";
			array[8, 1] = "10010";
			array[9, 0] = "9";
			array[9, 1] = "01010";
			string text = "";
			string text2 = "";
			string text3 = "0000000000";
			text3 += "1010";
			string text4 = Code;
			if (Code.Length % 2 != 0)
			{
				Code = "0" + Code;
			}
			int num3 = 0;
			checked
			{
				int num4 = Code.Length - 1;
				for (int i = num3; i <= num4; i += 2)
				{
					int num5 = 0;
					do
					{
						if (array[num5, 0][0] == Code[i])
						{
							text = array[num5, 1];
						}
						if (array[num5, 0][0] == Code[i + 1])
						{
							text2 = array[num5, 1];
						}
						num5++;
					}
					while (num5 <= 9);
					int num6 = 0;
					int num7 = text.Length - 1;
					for (int j = num6; j <= num7; j++)
					{
						if (Operators.CompareString(Conversions.ToString(text[j]), "0", false) == 0)
						{
							text3 += "1";
						}
						else
						{
							text3 += "111";
						}
						if (Operators.CompareString(Conversions.ToString(text2[j]), "0", false) == 0)
						{
							text3 += "0";
						}
						else
						{
							text3 += "000";
						}
					}
				}
				text3 += "11101";
				text3 += "0000000000";
				float num8 = width / (float)text3.Length;
				RectangleF myrect = unchecked(new RectangleF(num + num8 * 8f, currenty + height, num8 * (float)(checked(text3.Length - 16)), num2));
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (IsPrintText)
				{
					this.DrawText(text4, myrect, tfont, theforecolor, stringFormat, 5f, 0);
				}
				int num9 = 0;
				int num10 = text3.Length - 1;
				for (int k = num9; k <= num10; k++)
				{
					RectangleF myrect2 = new RectangleF(num, currenty, num8, height);
					if (Operators.CompareString(Conversions.ToString(text3[k]), "1", false) == 0)
					{
						this.DrawFillRect(myrect2, theforecolor);
					}
					unchecked
					{
						num += num8;
					}
				}
				try
				{
					array = null;
					stringFormat.Dispose();
					myrect = default(RectangleF);
					RectangleF myrect2 = default(RectangleF);
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000B80E8 File Offset: 0x000B62E8
		private static string ENA13_J(string Code)
		{
			checked
			{
				int num = VB2008Print.CtoInt(Code[1]) + VB2008Print.CtoInt(Code[3]) + VB2008Print.CtoInt(Code[5]) + VB2008Print.CtoInt(Code[7]) + VB2008Print.CtoInt(Code[9]) + VB2008Print.CtoInt(Code[11]);
				num *= 3;
				int num2 = VB2008Print.CtoInt(Code[2]) + VB2008Print.CtoInt(Code[4]) + VB2008Print.CtoInt(Code[6]) + VB2008Print.CtoInt(Code[8]) + VB2008Print.CtoInt(Code[10]) + VB2008Print.CtoInt(Code[0]);
				string text = Convert.ToString(num + num2);
				text = text.Trim();
				string text2 = Convert.ToString(10 - VB2008Print.CtoInt(text[text.Length - 1]));
				string result;
				if (text2.Length > 1)
				{
					result = "0";
				}
				else
				{
					result = text2;
				}
				return result;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000B81DC File Offset: 0x000B63DC
		private static string ENA8_J(string Code)
		{
			checked
			{
				int num = VB2008Print.CtoInt(Code[0]) + VB2008Print.CtoInt(Code[2]) + VB2008Print.CtoInt(Code[4]) + VB2008Print.CtoInt(Code[6]);
				num *= 3;
				int num2 = VB2008Print.CtoInt(Code[1]) + VB2008Print.CtoInt(Code[3]) + VB2008Print.CtoInt(Code[5]);
				string text = Convert.ToString(num + num2);
				text = text.Trim();
				string text2 = Convert.ToString(10 - VB2008Print.CtoInt(text[text.Length - 1]));
				string result;
				if (text2.Length > 1)
				{
					result = "0";
				}
				else
				{
					result = text2;
				}
				return result;
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000B828C File Offset: 0x000B648C
		private static int CtoInt(char Cr)
		{
			return Convert.ToInt32(Convert.ToString(Cr));
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000B82A8 File Offset: 0x000B64A8
		private void DrawBar(string rawvalue, string Encoded_Value, float width, float height, Font tfont, Color bkcolor, Color forecolor, bool IsPrintText)
		{
			if (Encoded_Value != null && Encoded_Value.Length > 0)
			{
				string str = Encoded_Value;
				Encoded_Value = "00000" + Encoded_Value + "00000";
				float num = width / (float)Encoded_Value.Length;
				if (this.ConvToDisplay(num, true) < 1f)
				{
					Encoded_Value = "0" + str + "0";
					num = width / (float)Encoded_Value.Length;
					if (this.ConvToDisplay(num, true) < 1f)
					{
						throw new Exception("EGENERATE_IMAGE-2: 条形码尺寸太小，小于1像素");
					}
				}
				RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, width, height);
				this.DrawFillRect(myrect, bkcolor);
				Pen pen = new Pen(forecolor);
				pen.Alignment = PenAlignment.Right;
				RectangleF myrect2 = default(RectangleF);
				float currentx = this.Currentx;
				float num2 = this.Currentx;
				myrect2.Y = this.Currenty;
				float num3 = height / 5f;
				if (!IsPrintText)
				{
					num3 = 0f;
				}
				height -= num3;
				int num4 = 0;
				checked
				{
					int num5 = Encoded_Value.Length - 1;
					for (int i = num4; i <= num5; i++)
					{
						if (Operators.CompareString(Conversions.ToString(Encoded_Value[i]), "1", false) == 0)
						{
							myrect2.X = num2;
							myrect2.Width = num;
							myrect2.Height = height;
							this.DrawFillRect(myrect2, forecolor);
						}
						unchecked
						{
							num2 += num;
						}
					}
					this.Currentx = currentx;
				}
				this.Currenty += height;
				myrect2.X = this.Currentx;
				myrect2.Y = this.Currenty;
				myrect2.Width = width;
				myrect2.Height = num3;
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				if (IsPrintText)
				{
					this.DrawText(rawvalue, myrect2, tfont, forecolor, stringFormat, 5f, 0);
				}
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000B8470 File Offset: 0x000B6670
		public void PrintReportMb(string rptfilename, DataTable dt, Hashtable cs, bool istd)
		{
			DataGridView dataGridView = new DataGridView();
			try
			{
				dataGridView.DataSource = dt;
			}
			catch (Exception ex)
			{
				dataGridView = null;
			}
			this.PrintReportMb(rptfilename, dataGridView, cs, istd);
			try
			{
				dataGridView.Dispose();
				dataGridView = null;
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000B84DC File Offset: 0x000B66DC
		public void PrintReportMb(string rptfilename, DataGridView dgv, Hashtable cs, bool istd)
		{
			if (MyProject.Computer.FileSystem.FileExists(rptfilename))
			{
				EasyReport easyReport = new EasyReport();
				easyReport.SetReportDataSource(dgv);
				easyReport.SetReportFile(rptfilename);
				easyReport.SetReportVar(cs);
				string reportString = easyReport.GetReportString(istd);
				if (reportString != null)
				{
					this.OpenReportByString(reportString, false);
					try
					{
						easyReport.Dispose();
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00007A82 File Offset: 0x00005C82
		public void DrawButton(Button bt)
		{
			this.DrawButton(bt, this.Currentx, this.Currenty);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00007A97 File Offset: 0x00005C97
		public void DrawButton(Button bt, float x, float y)
		{
			if (bt != null)
			{
				this.DrawButton(bt, x, y, this.ConvFromDisplay((float)bt.Width, true), this.ConvFromDisplay((float)bt.Height, false));
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000B8558 File Offset: 0x000B6758
		public void DrawButton(Button bt, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && bt != null)
			{
				Bitmap bitmap = new Bitmap(bt.Width, bt.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				bt.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00007AC1 File Offset: 0x00005CC1
		public void DrawCheckBox(CheckBox cb)
		{
			this.DrawCheckBox(cb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00007AD6 File Offset: 0x00005CD6
		public void DrawCheckBox(CheckBox cb, float x, float y)
		{
			if (cb != null)
			{
				this.DrawCheckBox(cb, x, y, this.ConvFromDisplay((float)cb.Width, true), this.ConvFromDisplay((float)cb.Height, false));
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000B85B8 File Offset: 0x000B67B8
		public void DrawCheckBox(CheckBox cb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && cb != null)
			{
				Bitmap bitmap = new Bitmap(cb.Width, cb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				cb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00007B00 File Offset: 0x00005D00
		public void DrawComboBox(ComboBox cb)
		{
			this.DrawComboBox(cb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00007B15 File Offset: 0x00005D15
		public void DrawComboBox(ComboBox cb, float x, float y)
		{
			if (cb != null)
			{
				this.DrawComboBox(cb, x, y, this.ConvFromDisplay((float)cb.Width, true), this.ConvFromDisplay((float)cb.Height, false));
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000B8618 File Offset: 0x000B6818
		public void DrawComboBox(ComboBox cb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && cb != null)
			{
				Bitmap bitmap = new Bitmap(cb.Width, cb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				cb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00007B3F File Offset: 0x00005D3F
		public void DrawRadioButton(RadioButton rb)
		{
			this.DrawRadioButton(rb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00007B54 File Offset: 0x00005D54
		public void DrawRadioButton(RadioButton rb, float x, float y)
		{
			if (rb != null)
			{
				this.DrawRadioButton(rb, x, y, this.ConvFromDisplay((float)rb.Width, true), this.ConvFromDisplay((float)rb.Height, false));
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000B8678 File Offset: 0x000B6878
		public void DrawRadioButton(RadioButton rb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && rb != null)
			{
				Bitmap bitmap = new Bitmap(rb.Width, rb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				rb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00007B7E File Offset: 0x00005D7E
		public void DrawGroupBoxControl(GroupBox gb)
		{
			this.DrawGroupBoxControl(gb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00007B93 File Offset: 0x00005D93
		public void DrawGroupBoxControl(GroupBox gb, float x, float y)
		{
			if (gb != null)
			{
				this.DrawGroupBoxControl(gb, x, y, this.ConvFromDisplay((float)gb.Width, true), this.ConvFromDisplay((float)gb.Height, false));
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000B86D8 File Offset: 0x000B68D8
		public void DrawGroupBoxControl(GroupBox gb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && gb != null)
			{
				Bitmap bitmap = new Bitmap(gb.Width, gb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				gb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00007BBD File Offset: 0x00005DBD
		public void DrawLabelControl(Label lb)
		{
			this.DrawLabelControl(lb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00007BD2 File Offset: 0x00005DD2
		public void DrawLabelControl(Label lb, float x, float y)
		{
			if (lb != null)
			{
				this.DrawLabelControl(lb, x, y, this.ConvFromDisplay((float)lb.Width, true), this.ConvFromDisplay((float)lb.Height, false));
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000B8738 File Offset: 0x000B6938
		public void DrawLabelControl(Label lb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && lb != null)
			{
				Bitmap bitmap = new Bitmap(lb.Width, lb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				lb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00007BFC File Offset: 0x00005DFC
		public void DrawTextBoxControl(TextBox tb)
		{
			this.DrawTextBoxControl(tb, this.Currentx, this.Currenty);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00007C11 File Offset: 0x00005E11
		public void DrawTextBoxControl(TextBox tb, float x, float y)
		{
			if (tb != null)
			{
				this.DrawTextBoxControl(tb, x, y, this.ConvFromDisplay((float)tb.Width, true), this.ConvFromDisplay((float)tb.Height, false));
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000B8798 File Offset: 0x000B6998
		public void DrawTextBoxControl(TextBox tb, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && tb != null)
			{
				Bitmap bitmap = new Bitmap(tb.Width, tb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				tb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00007C3B File Offset: 0x00005E3B
		public void DrawControl(Control cl)
		{
			this.DrawControl(cl, this.Currentx, this.Currenty);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00007C50 File Offset: 0x00005E50
		public void DrawControl(Control cl, float x, float y)
		{
			if (cl != null)
			{
				this.DrawControl(cl, x, y, this.ConvFromDisplay((float)cl.Width, true), this.ConvFromDisplay((float)cl.Height, false));
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000B87F8 File Offset: 0x000B69F8
		public void DrawControl(Control cl, float x, float y, float width, float height)
		{
			if (!this.CancelDocument && cl != null)
			{
				Bitmap bitmap = new Bitmap(cl.Width, cl.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				cl.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, width, height, true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000B8858 File Offset: 0x000B6A58
		public void DrawHTML(string shtml)
		{
			if (!this.CancelDocument)
			{
				if (Operators.CompareString(shtml, "", false) != 0)
				{
					string text = HtmlAndRtf.HTML_To_RTF(shtml);
					if (Operators.CompareString(text, "", false) != 0)
					{
						this.DrawRichTextBox(text);
					}
				}
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000B88A0 File Offset: 0x000B6AA0
		public void DrawXML(string sxml)
		{
			if (!this.CancelDocument)
			{
				if (Operators.CompareString(sxml, "", false) != 0)
				{
					string text = XMLtoRTF.XML2RTF(sxml);
					if (Operators.CompareString(text, "", false) != 0)
					{
						this.DrawRichTextBox(text);
					}
				}
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000B88E8 File Offset: 0x000B6AE8
		public void DrawRichTextBoxAsBMP(RichTextBox rtb)
		{
			if (!this.CancelDocument)
			{
				float num = this.PaperPrintWidth + (float)this.PaperMargins.Left + (float)this.PaperMargins.Right;
				float num2 = this.PaperPrintHeight + (float)this.PaperMargins.Top + (float)this.PaperMargins.Bottom;
				if (rtb.TextLength > 0)
				{
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num /= 10f;
						num2 /= 10f;
					}
					else
					{
						num = this.ConvertInchToMm(num / 100f);
						num2 = this.ConvertInchToMm(num2 / 100f);
					}
					float num3 = this.Currenty;
					float num4 = this.Currentx;
					float num5 = (float)this.PaperMargins.Left;
					float num6 = (float)this.PaperMargins.Right;
					float num7 = (float)this.PaperMargins.Top;
					float num8 = (float)this.PaperMargins.Bottom;
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num5 /= 10f;
						num6 /= 10f;
						num7 /= 10f;
						num8 /= 10f;
						num3 /= 10f;
						num4 /= 10f;
					}
					else
					{
						num5 = this.ConvertInchToMm(num5 / 100f);
						num6 = this.ConvertInchToMm(num6 / 100f);
						num7 = this.ConvertInchToMm(num7 / 100f);
						num8 = this.ConvertInchToMm(num8 / 100f);
						num3 = this.ConvertInchToMm(num3 / 100f);
						num4 = this.ConvertInchToMm(num4 / 100f);
					}
					int i = 0;
					float num9;
					checked
					{
						Margins papermargin = new Margins((int)Math.Round((double)(unchecked((num5 + num4) * 10f))), (int)Math.Round((double)(unchecked(num6 * 10f))), (int)Math.Round((double)(unchecked((num7 + num3) * 10f))), (int)Math.Round((double)(unchecked(num8 * 10f))));
						Image image = RichBoxPrint.RTBFormatRange(rtb, false, num, num2, papermargin, 0, rtb.TextLength, ref i, this.PIXELSPERINCHX, this.PIXELSPERINCHY, ref num9);
						if (image != null)
						{
							this.DrawImage(image);
							image.Dispose();
						}
						if (i < rtb.TextLength)
						{
							papermargin = new Margins((int)Math.Round((double)(unchecked(num5 * 10f))), (int)Math.Round((double)(unchecked(num6 * 10f))), (int)Math.Round((double)(unchecked(num7 * 10f))), (int)Math.Round((double)(unchecked(num8 * 10f))));
							while (i < rtb.TextLength)
							{
								this.MyNewPage();
								int charFrom = i;
								image = RichBoxPrint.RTBFormatRange(rtb, false, num, num2, papermargin, charFrom, rtb.TextLength, ref i, this.PIXELSPERINCHX, this.PIXELSPERINCHY, ref num9);
								if (image != null)
								{
									this.DrawImage(image);
									image.Dispose();
								}
							}
						}
						RichBoxPrint.RTBFormatRangeDone(rtb);
						this.Currentx = 0f;
					}
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num9 *= 10f;
					}
					else
					{
						num9 = this.ConvertMmToInch(num9 * 100f);
					}
					this.Currenty += num9;
				}
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000B8BDC File Offset: 0x000B6DDC
		public void DrawRichTextBoxAsBMP(string rtf)
		{
			if (!this.CancelDocument)
			{
				RichTextBox richTextBox = new RichTextBox();
				try
				{
					richTextBox.Rtf = rtf;
				}
				catch (Exception ex)
				{
					richTextBox.Dispose();
					return;
				}
				this.DrawRichTextBoxAsBMP(richTextBox);
				richTextBox.Dispose();
				richTextBox = null;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x000B8C34 File Offset: 0x000B6E34
		public void DrawRichTextBox(RichTextBox rtb)
		{
			if (!this.CancelDocument && rtb != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				rtb.SaveFile(memoryStream, RichTextBoxStreamType.RichText);
				memoryStream.Position = 0L;
				checked
				{
					byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
					memoryStream.Read(array, 0, array.Length);
					this.W_myrtfC = (VB2008Print.mypic[])Utils.CopyArray((Array)this.W_myrtfC, new VB2008Print.mypic[this.W_myrtfnum + 1]);
					this.W_myrtfC[this.W_myrtfnum].mypi = array;
				}
				float num = this.PaperPrintWidth + (float)this.PaperMargins.Left + (float)this.PaperMargins.Right;
				float num2 = this.PaperPrintHeight + (float)this.PaperMargins.Top + (float)this.PaperMargins.Bottom;
				if (rtb.TextLength > 0)
				{
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num /= 10f;
						num2 /= 10f;
					}
					else
					{
						num = this.ConvertInchToMm(num / 100f);
						num2 = this.ConvertInchToMm(num2 / 100f);
					}
					num = (float)Math.Round((double)num, 2);
					num2 = (float)Math.Round((double)num2, 2);
					float num3 = this.Currenty;
					float num4 = this.Currentx;
					float num5 = (float)this.PaperMargins.Left;
					float num6 = (float)this.PaperMargins.Right;
					float num7 = (float)this.PaperMargins.Top;
					float num8 = (float)this.PaperMargins.Bottom;
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num5 /= 10f;
						num6 /= 10f;
						num7 /= 10f;
						num8 /= 10f;
						num3 /= 10f;
						num4 /= 10f;
					}
					else
					{
						num5 = this.ConvertInchToMm(num5 / 100f);
						num6 = this.ConvertInchToMm(num6 / 100f);
						num7 = this.ConvertInchToMm(num7 / 100f);
						num8 = this.ConvertInchToMm(num8 / 100f);
						num3 = this.ConvertInchToMm(num3 / 100f);
						num4 = this.ConvertInchToMm(num4 / 100f);
					}
					num5 = (float)Math.Round((double)num5, 1);
					num6 = (float)Math.Round((double)num6, 1);
					num7 = (float)Math.Round((double)num7, 1);
					num8 = (float)Math.Round((double)num8, 1);
					num4 = (float)Math.Round((double)num4, 1);
					num3 = (float)Math.Round((double)num3, 1);
					int num9 = 0;
					Margins papermargin = checked(new Margins((int)Math.Round((double)(unchecked((num5 + num4) * 10f))), (int)Math.Round((double)(unchecked(num6 * 10f))), (int)Math.Round((double)(unchecked((num7 + num3) * 10f))), (int)Math.Round((double)(unchecked(num8 * 10f)))));
					float num10 = RichBoxPrint.DrawRTF(rtb, this.myg, false, num, num2, papermargin, 0, rtb.TextLength, ref num9);
					this.MyWrite("rtf", Conversions.ToString(this.W_myrtfnum), Conversions.ToString(0), Conversions.ToString(num9), Conversions.ToString(num), Conversions.ToString(num2), Conversions.ToString((num5 + num4) * 10f), Conversions.ToString(num6 * 10f), Conversions.ToString((num7 + num3) * 10f), Conversions.ToString(num8 * 10f));
					if (num9 < rtb.TextLength)
					{
						papermargin = checked(new Margins((int)Math.Round((double)(unchecked(num5 * 10f))), (int)Math.Round((double)(unchecked(num6 * 10f))), (int)Math.Round((double)(unchecked(num7 * 10f))), (int)Math.Round((double)(unchecked(num8 * 10f)))));
						while (num9 < rtb.TextLength && !this.CancelDocument)
						{
							this.MyNewPage();
							int num11 = num9;
							num10 = RichBoxPrint.DrawRTF(rtb, this.myg, false, num, num2, papermargin, num11, rtb.TextLength, ref num9);
							this.MyWrite("rtf", Conversions.ToString(this.W_myrtfnum), Conversions.ToString(num11), Conversions.ToString(num9), Conversions.ToString(num), Conversions.ToString(num2), Conversions.ToString(num5 * 10f), Conversions.ToString(num6 * 10f), Conversions.ToString(num7 * 10f), Conversions.ToString(num8 * 10f));
						}
					}
					RichBoxPrint.RTBFormatRangeDone(rtb);
					this.Currentx = 0f;
					if (this.PageUnits == VB2008Print.PageExportUnit.CentiMeter)
					{
						num10 *= 10f;
					}
					else
					{
						num10 = this.ConvertMmToInch(num10 * 100f);
					}
					this.Currenty += num10;
					checked
					{
						this.W_myrtfnum++;
						try
						{
							memoryStream.Close();
							memoryStream.Dispose();
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000B90FC File Offset: 0x000B72FC
		public void DrawRichTextBox(string rtf)
		{
			if (!this.CancelDocument)
			{
				RichTextBox richTextBox = new RichTextBox();
				try
				{
					richTextBox.Rtf = rtf;
				}
				catch (Exception ex)
				{
					richTextBox.Dispose();
					return;
				}
				this.DrawRichTextBox(richTextBox);
				richTextBox.Dispose();
				richTextBox = null;
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000B9154 File Offset: 0x000B7354
		private void MyDrawRTF(byte[] rtf, int fromchar, int tochar, float myw, float myh, float lmargin, float rmargin, float tmargin, float bmargin)
		{
			MemoryStream memoryStream = new MemoryStream(rtf);
			RichTextBox richTextBox = new RichTextBox();
			richTextBox.LoadFile(memoryStream, RichTextBoxStreamType.RichText);
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			checked
			{
				int i;
				RichBoxPrint.DrawRTF(richTextBox, this.myg, true, myw, myh, new Margins((int)Math.Round((double)lmargin), (int)Math.Round((double)rmargin), (int)Math.Round((double)tmargin), (int)Math.Round((double)bmargin)), fromchar, tochar, ref i);
				while (i < tochar)
				{
					unchecked
					{
						myh += 2f;
					}
					RichBoxPrint.DrawRTF(richTextBox, this.myg, true, myw, myh, new Margins((int)Math.Round((double)lmargin), (int)Math.Round((double)rmargin), (int)Math.Round((double)tmargin), (int)Math.Round((double)bmargin)), fromchar, tochar, ref i);
				}
				RichBoxPrint.DrawRTF(richTextBox, this.myg, false, myw, myh, new Margins((int)Math.Round((double)lmargin), (int)Math.Round((double)rmargin), (int)Math.Round((double)tmargin), (int)Math.Round((double)bmargin)), fromchar, tochar, ref i);
				RichBoxPrint.RTBFormatRangeDone(richTextBox);
				this.myg.Transform = transform;
				richTextBox.Dispose();
				try
				{
					memoryStream.Close();
					memoryStream.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00007C7A File Offset: 0x00005E7A
		public void DrawPanel(Control controlContainer)
		{
			this.DrawPanel(controlContainer, true, false);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00007C85 File Offset: 0x00005E85
		public void DrawPanel(Control controlContainer, bool isdrawContainer)
		{
			this.DrawPanel(controlContainer, true, isdrawContainer);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00007C90 File Offset: 0x00005E90
		public void DrawPanel(Control controlContainer, bool includechildcontrols, bool isdrawContainer)
		{
			this.DrawPanel(controlContainer, includechildcontrols, isdrawContainer, true, true, true, StringAlignment.Near);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000B92A4 File Offset: 0x000B74A4
		public void DrawPanel(Control controlContainer, bool includechildcontrols, bool isdrawContainer, bool isDrawForeColor, bool isDrawBkcolor, bool cannewpage, StringAlignment Alg)
		{
			this.DrawPanel(controlContainer, this.Currentx, this.Currenty, includechildcontrols, isdrawContainer, isDrawForeColor, isDrawBkcolor, cannewpage, Alg);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000B92D0 File Offset: 0x000B74D0
		public void DrawPanel(Control controlContainer, float x, float y, bool includechildcontrols, bool isdrawContainer, bool isDrawForeColor, bool isDrawBkcolor, bool cannewpage, StringAlignment Alg)
		{
			if (!this.CancelDocument && controlContainer != null && controlContainer.Controls.Count > 0)
			{
				float num = this.ConvFromDisplay((float)controlContainer.Width, true);
				this.Currenty = y;
				bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
				this.IsNeedCheckNewPage = false;
				switch (Alg)
				{
					case StringAlignment.Center:
						this.Currentx = x + (this.PaperPrintWidth - x - num) / 2f;
						break;
					case StringAlignment.Far:
						this.Currentx = this.PaperPrintWidth - num;
						break;
					default:
						this.Currentx = x;
						break;
				}
				Margins margins = (Margins)this.CellMargin.Clone();
				this.CellMargin = new Margins(0, 0, 0, 0);
				float basex = 0f;
				float num2 = 0f;
				this.Currenty = this.MyDrawPanel(controlContainer, basex, ref num2, includechildcontrols, isdrawContainer, isDrawForeColor, isDrawBkcolor, cannewpage);
				this.Currentx = 0f;
				this.CellMargin = (Margins)margins.Clone();
				this.IsNeedCheckNewPage = isNeedCheckNewPage;
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000B93D0 File Offset: 0x000B75D0
		private float MyDrawPanel(Control pl, float basex, ref float basey, bool includechildcontrols, bool isdrawContainer, bool isDrawForeColor, bool isDrawBkcolor, bool cannewpage)
		{
			float result;
			if (pl == null)
			{
				result = this.Currenty;
			}
			else
			{
				float currentx = this.Currentx;
				float num = this.Currenty;
				bool flag = false;
				if (isdrawContainer && !this.MyIsNewPage(this.ConvFromDisplay((float)pl.Height, false), false))
				{
					this.MyDrawContainerFrame(pl, currentx, isDrawBkcolor, isDrawForeColor);
					flag = true;
				}
				if (pl.Controls.Count <= 0)
				{
					result = this.Currenty;
				}
				else
				{
					List<Control> list = new List<Control>();
					int num2 = 0;
					Control control;
					float num9;
					checked
					{
						int num3 = pl.Controls.Count - 1;
						for (int i = num2; i <= num3; i++)
						{
							list.Add(pl.Controls[i]);
						}
						VB2008Print.MyComparer comparer = new VB2008Print.MyComparer();
						list.Sort(comparer);
						Color textforecolor = Color.Black;
						Color backcolor = Color.Transparent;
						control = null;
						Control control2 = null;
						int num4 = 0;
						int num5 = 0;
						int num6 = list.Count - 1;
						int num7 = num5;
						while (num7 <= num6 && !this.CancelDocument)
						{
							Control control3 = list[num7];
							unchecked
							{
								if (control3.Visible & Operators.CompareString(Conversions.ToString(control3.Tag), "不打印", false) != 0)
								{
									float currentx2 = currentx + this.ConvFromDisplay(basex + (float)control3.Location.X, true);
									float currenty = num + this.ConvFromDisplay(basey + (float)control3.Location.Y, false);
									float mywidth = this.ConvFromDisplay((float)control3.Width, true);
									float num8 = this.ConvFromDisplay((float)control3.Height, false);
									if (Operators.CompareString(Versioned.TypeName(control3).ToLower(), "panel", false) != 0 & Operators.CompareString(Versioned.TypeName(control3).ToLower(), "groupbox", false) != 0 & Operators.CompareString(Versioned.TypeName(control3).ToLower(), "tablelayoutpanel", false) != 0 & Operators.CompareString(Versioned.TypeName(control3).ToLower(), "splitcontainer", false) != 0)
									{
										checked
										{
											num4++;
										}
										if (cannewpage)
										{
											this.Currenty = num;
											if (this.IsNewPage(this.ConvFromDisplay(basey + (float)control3.Location.Y, false) + num8))
											{
												if (this.GetCurrentPage() < this.GetPages())
												{
													this.SetCurrentPage(checked(this.GetCurrentPage() + 1));
													num = 0f;
													if (control2 != null)
													{
														basey = (float)(checked(0 - control3.Location.Y + (control3.Location.Y - control2.Location.Y)));
														num9 = 0f;
														control = null;
														currenty = num + this.ConvFromDisplay(basey + (float)control3.Location.Y, false);
													}
													else
													{
														basey = (float)(checked(0 - control3.Location.Y));
														num9 = 0f;
														control = null;
														currenty = num + this.ConvFromDisplay(basey + (float)control3.Location.Y, false);
													}
												}
												else
												{
													this.MyNewPage();
													num = 0f;
													basey = (float)(checked(0 - control3.Location.Y));
													if (num4 == 1)
													{
														basey += (float)control3.Location.Y;
														if (!flag)
														{
															flag = true;
															this.MyDrawContainerFrame(pl, currentx, isDrawBkcolor, isDrawForeColor);
														}
													}
													num9 = 0f;
													control = null;
													currenty = num + this.ConvFromDisplay(basey + (float)control3.Location.Y, false);
												}
											}
										}
									}
									this.Currenty = currenty;
									this.Currentx = currentx2;
									if (isDrawBkcolor)
									{
										backcolor = control3.BackColor;
									}
									else
									{
										backcolor = Color.Transparent;
									}
									if (isDrawForeColor)
									{
										textforecolor = control3.ForeColor;
									}
									else
									{
										textforecolor = Color.Black;
									}
									if (num9 < this.Currenty + num8)
									{
										num9 = this.Currenty + num8;
										control = control3;
									}
									string left = Versioned.TypeName(control3).ToLower();
									if (Operators.CompareString(left, "textbox", false) == 0)
									{
										TextBox textBox = (TextBox)control3;
										StringAlignment myHalg;
										switch (textBox.TextAlign)
										{
											case HorizontalAlignment.Right:
												myHalg = StringAlignment.Far;
												break;
											case HorizontalAlignment.Center:
												myHalg = StringAlignment.Center;
												break;
											default:
												myHalg = StringAlignment.Near;
												break;
										}
										this.DrawCell(textBox.Text, mywidth, num8, textBox.Font, textforecolor, "0000", myHalg, StringAlignment.Center, textBox.WordWrap, true, false, false, 20f, backcolor, Color.Black, 0);
									}
									else if (Operators.CompareString(left, "label", false) == 0)
									{
										Label label = (Label)control3;
										if (label.Image != null)
										{
											this.DrawImage(label.Image, this.Currentx, this.Currenty, mywidth, num8, false, mbsjmodule.GetHalign(label.ImageAlign), mbsjmodule.GetValign(label.ImageAlign));
										}
										StringAlignment valign = mbsjmodule.GetValign(label.TextAlign);
										StringAlignment myHalg = mbsjmodule.GetHalign(label.TextAlign);
										this.DrawCell(label.Text, mywidth, num8, label.Font, textforecolor, Conversions.ToString(Interaction.IIf(label.BorderStyle == BorderStyle.None, "0000", "1111")), myHalg, valign, Conversions.ToBoolean(Interaction.IIf(label.AutoSize, false, true)), true, false, false, 20f, backcolor, Color.Black, 0);
									}
									else
									{
										if (Operators.CompareString(left, "groupbox", false) != 0)
										{
											if (Operators.CompareString(left, "panel", false) != 0)
											{
												if (Operators.CompareString(left, "tablelayoutpanel", false) != 0)
												{
													if (Operators.CompareString(left, "splitcontainer", false) != 0)
													{
														Control control4 = control3;
														Color foreColor = control4.ForeColor;
														Color backColor = control4.BackColor;
														if (!isDrawBkcolor)
														{
															control4.BackColor = Color.White;
														}
														if (!isDrawForeColor)
														{
															control4.ForeColor = Color.Black;
														}
														this.DrawControl(control4, this.Currentx, this.Currenty);
														if (!isDrawBkcolor)
														{
															control4.BackColor = backColor;
														}
														if (!isDrawForeColor)
														{
															control4.ForeColor = foreColor;
														}
														goto IL_61C;
													}
												}
											}
										}
										if (includechildcontrols)
										{
											int currentPage = this.GetCurrentPage();
											control2 = control3;
											Control pl2 = control3;
											float basex2 = 0f;
											float num10 = 0f;
											this.MyDrawPanel(pl2, basex2, ref num10, includechildcontrols, isdrawContainer, isDrawForeColor, isDrawBkcolor, cannewpage);
											this.SetCurrentPage(currentPage);
										}
									}
								}
							IL_61C:;
							}
							num7++;
						}
						this.Currentx = currentx;
						this.Currenty = num;
						try
						{
							int num11 = 0;
							int num12 = list.Count - 1;
							for (int j = num11; j <= num12; j++)
							{
								list.RemoveAt(0);
							}
						}
						catch (Exception ex)
						{
						}
					}
					if (control != null)
					{
						num9 += (float)(checked(pl.Height - control.Location.Y - control.Height));
						control = null;
					}
					result = num9;
				}
			}
			return result;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000B9A90 File Offset: 0x000B7C90
		private void MyDrawContainerFrame(Control pl, float cx, bool isDrawBkcolor, bool isDrawForecolor)
		{
			if (!this.CancelDocument)
			{
				float currentx = this.Currentx;
				this.Currentx = cx;
				if (Operators.CompareString(Versioned.TypeName(pl).ToLower(), "panel", false) == 0)
				{
					Panel panel = new Panel();
					if (!isDrawBkcolor)
					{
						panel.BackColor = Color.White;
					}
					else
					{
						panel.BackColor = ((Panel)pl).BackColor;
					}
					panel.BackgroundImageLayout = ((Panel)pl).BackgroundImageLayout;
					panel.BackgroundImage = ((Panel)pl).BackgroundImage;
					panel.Font = (Font)((Panel)pl).Font.Clone();
					if (isDrawForecolor)
					{
						panel.ForeColor = ((Panel)pl).ForeColor;
					}
					else
					{
						panel.ForeColor = Color.Black;
					}
					panel.Width = ((Panel)pl).Width;
					panel.Height = ((Panel)pl).Height;
					this.DrawControl(panel, this.Currentx, this.Currenty);
					panel.Dispose();
				}
				else if (Operators.CompareString(Versioned.TypeName(pl).ToLower(), "groupbox", false) == 0)
				{
					GroupBox groupBox = new GroupBox();
					if (!isDrawBkcolor)
					{
						groupBox.BackColor = Color.White;
					}
					else
					{
						groupBox.BackColor = ((GroupBox)pl).BackColor;
					}
					groupBox.BackgroundImageLayout = ((GroupBox)pl).BackgroundImageLayout;
					groupBox.BackgroundImage = ((GroupBox)pl).BackgroundImage;
					groupBox.Text = ((GroupBox)pl).Text;
					groupBox.Font = (Font)((GroupBox)pl).Font.Clone();
					if (isDrawForecolor)
					{
						groupBox.ForeColor = ((GroupBox)pl).ForeColor;
					}
					else
					{
						groupBox.ForeColor = Color.Black;
					}
					groupBox.Width = ((GroupBox)pl).Width;
					groupBox.Height = ((GroupBox)pl).Height;
					this.DrawControl(groupBox, this.Currentx, this.Currenty);
					groupBox.Dispose();
				}
				this.Currentx = currentx;
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000B9C94 File Offset: 0x000B7E94
		private void VB2008Print_Disposed(object sender, EventArgs e)
		{
			try
			{
				Module1.G_CancelDocument = true;
				this.w_end = true;
				this.mypicture = null;
				this.W_myrtfC = null;
				this.myPaperHeight = null;
				this.myPaperWidth = null;
				if (this.g_pp != null)
				{
					this.g_pp.Dispose();
					this.g_pp = null;
				}
				this.DelMypages();
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
				this.tempfont = null;
				this.tempfontwater = null;
				this.tempcellmargin = null;
				this.r_font = null;
				this.mypagesetting = null;
				this.myCellmargin = null;
				try
				{
					if (this.myprogresswait != null)
					{
						this.myprogresswait.Dispose();
						this.myprogresswait = null;
					}
				}
				catch (Exception ex)
				{
				}
				GC.Collect();
			}
			catch (Exception ex2)
			{
				GC.Collect();
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000B9DB0 File Offset: 0x000B7FB0
		private void DelMypages()
		{
			checked
			{
				try
				{
					if (this.mypages != null)
					{
						int num = 0;
						int num2 = this.mypages.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							this.mypages[i] = null;
						}
					}
				}
				catch (Exception ex)
				{
				}
				try
				{
					this.mypages = null;
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000B9E28 File Offset: 0x000B8028
		public void DrawFillPath(GraphicsPath gp, LinearGradientBrush tb, LinearGradientMode myLinearGradientMode)
		{
			if (!this.CancelDocument)
			{
				string t = "";
				string t2 = "";
				this.SaveGraphicsPath(gp, ref t, ref t2);
				string t3 = this.SaveBrush(tb, myLinearGradientMode);
				this.MyWrite("fp", t, t2, t3);
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000B9E6C File Offset: 0x000B806C
		public void DrawFillPath(GraphicsPath gp, LinearGradientBrush tb, float myangle)
		{
			if (!this.CancelDocument)
			{
				string t = "";
				string t2 = "";
				this.SaveGraphicsPath(gp, ref t, ref t2);
				string t3 = this.SaveBrush(tb, myangle);
				this.MyWrite("fp", t, t2, t3);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000B9EB0 File Offset: 0x000B80B0
		public void DrawFillPath(GraphicsPath gp, TextureBrush tb)
		{
			if (!this.CancelDocument)
			{
				string t = "";
				string t2 = "";
				this.SaveGraphicsPath(gp, ref t, ref t2);
				string t3 = this.SaveBrush(tb);
				this.MyWrite("fp", t, t2, t3);
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000B9EF4 File Offset: 0x000B80F4
		public void DrawFillPath(GraphicsPath gp, Color mycolor)
		{
			if (!this.CancelDocument)
			{
				string t = "";
				string t2 = "";
				this.SaveGraphicsPath(gp, ref t, ref t2);
				string t3 = this.SaveBrush(new SolidBrush(mycolor));
				this.MyWrite("fp", t, t2, t3);
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000B9F3C File Offset: 0x000B813C
		private void myDrawFillPath(GraphicsPath gp, Brush bs)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.FillPath(bs, gp);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000B9F9C File Offset: 0x000B819C
		public void DrawPath(GraphicsPath gp, Pen mypen)
		{
			if (!this.CancelDocument)
			{
				string t = "";
				string t2 = "";
				this.SaveGraphicsPath(gp, ref t, ref t2);
				string t3 = this.SavePenAsString(mypen);
				this.MyWrite("dp", t, t2, t3);
			}
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000B9FE0 File Offset: 0x000B81E0
		private void myDrawPath(string pathtype, string pathpoint, string penstring)
		{
			GraphicsPath graphicsPath = VB2008Print.RestoreGraphicsPath(pathtype, pathpoint);
			if (graphicsPath != null)
			{
				Pen pen = VB2008Print.RestorePenFromString(penstring);
				if (pen != null)
				{
					this.myDrawPath(graphicsPath, pen);
				}
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x000BA00C File Offset: 0x000B820C
		private void myDrawPath(GraphicsPath gp, Pen mypen)
		{
			Matrix transform = this.myg.Transform;
			this.PY(this.myg);
			try
			{
				this.myg.DrawPath(mypen, gp);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00007C9F File Offset: 0x00005E9F
		public void ResetTransform()
		{
			this.MyWrite("resetrotate", "");
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000BA06C File Offset: 0x000B826C
		public void Rotate(double degrees, float x, float y)
		{
			PointF point = new PointF(x, y);
			this.Rotate(degrees, point);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00007CB1 File Offset: 0x00005EB1
		public void Rotate(double degrees, PointF point)
		{
			this.MyWrite("rotate", Conversions.ToString(degrees), Conversions.ToString(this.MyConvTo(point.X)), Conversions.ToString(this.MyConvTo(point.Y)));
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000BA08C File Offset: 0x000B828C
		private void MyRotate(double degrees, double x, double y)
		{
			Matrix matrix = new Matrix();
			Matrix matrix2 = matrix;
			float angle = (float)degrees;
			PointF point = new PointF((float)((double)this.mypagesetting.Margins.Left + x + (double)this.GetPYx()), (float)((double)this.mypagesetting.Margins.Top + y + (double)this.GetPYy()));
			matrix2.RotateAt(angle, point);
			this.myg.Transform = matrix;
			matrix.Dispose();
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00007CE8 File Offset: 0x00005EE8
		private void MyResetRotate()
		{
			this.myg.ResetTransform();
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00007CF5 File Offset: 0x00005EF5
		public void TranslateTransform(float dx, float dy)
		{
			this.MyWrite("ttf", Conversions.ToString(this.MyConvTo(dx)), Conversions.ToString(this.MyConvTo(dy)));
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00007D1A File Offset: 0x00005F1A
		public void TranslateTransform(float dx, float dy, MatrixOrder order)
		{
			this.MyWrite("ttf2", Conversions.ToString(this.MyConvTo(dx)), Conversions.ToString(this.MyConvTo(dy)), Conversions.ToString((int)order));
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00007D45 File Offset: 0x00005F45
		private void myTranslateTransform(float dx, float dy)
		{
			this.myg.TranslateTransform(dx, dy);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00007D54 File Offset: 0x00005F54
		private void myTranslateTransform(float dx, float dy, MatrixOrder order)
		{
			this.myg.TranslateTransform(dx, dy, order);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00007D64 File Offset: 0x00005F64
		public void RotateTransform(float angle)
		{
			this.MyWrite("rtff", Conversions.ToString(angle));
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00007D77 File Offset: 0x00005F77
		public void RotateTransform(float angle, MatrixOrder order)
		{
			this.MyWrite("rtff2", Conversions.ToString(angle), Conversions.ToString((int)order));
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00007D90 File Offset: 0x00005F90
		private void myRotateTransform(float angle, MatrixOrder order)
		{
			if (this.myg != null)
			{
				this.myg.RotateTransform(angle, order);
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00007DA7 File Offset: 0x00005FA7
		private void myRotateTransform(float angle)
		{
			if (this.myg != null)
			{
				this.myg.RotateTransform(angle);
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00007DBD File Offset: 0x00005FBD
		public void DrawCircleText(string txt, Font txtfont, float r, PointF cPointf, float txtspace, Brush myBrush)
		{
			this.DrawEllipseText(txt, txtfont, r, r, cPointf, txtspace, myBrush);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000BA0FC File Offset: 0x000B82FC
		public void DrawEllipseText(string txt, Font txtfont, float rx, float ry, PointF cPointf, float txtspace, Brush myBrush)
		{
			int length = txt.Length;
			checked
			{
				string[] array = new string[length + 1];
				for (int i = 0; i < length; i++)
				{
					array[i] = txt.Substring(i, 1);
				}
				SizeF sizeF = this.MeasureString(array[0], txtfont, true);
				RectangleF rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.Alignment = StringAlignment.Center;
				if (length % 2 == 0)
				{
					int i = 0;
					while ((double)i < (double)length / 2.0)
					{
						unchecked
						{
							float num = (float)(((double)length / 2.0 - (double)i - 0.5) * (double)txtspace);
							sizeF = this.MeasureString(array[i], txtfont, true);
							rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
							float x = (float)((double)cPointf.X - (double)rx * Math.Sin((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Width / 2f) * Math.Cos((double)num * 3.141592653589793 / 180.0));
							float y = (float)((double)cPointf.Y - (double)ry * Math.Cos((double)num * 3.141592653589793 / 180.0) + (double)(sizeF.Height / 2f) * Math.Sin((double)num * 3.141592653589793 / 180.0));
							double degrees = (double)(num * -1f);
							PointF point = new PointF(x, y);
							this.Rotate(degrees, point);
							string text = array[i];
							RectangleF myrect = new RectangleF(x, y, rectangleF.Width, rectangleF.Height);
							this.DrawText(text, myrect, txtfont, myBrush, stringFormat, 0f);
							this.ResetTransform();
						}
						i++;
					}
					while (i < length)
					{
						unchecked
						{
							float num = (float)(((double)i - (double)length / 2.0 + 0.5) * (double)txtspace);
							float x = (float)((double)cPointf.X + (double)rx * Math.Sin((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Width / 2f) * Math.Cos((double)num * 3.141592653589793 / 180.0));
							float y = (float)((double)cPointf.Y - (double)ry * Math.Cos((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Height / 2f) * Math.Sin((double)num * 3.141592653589793 / 180.0));
							sizeF = this.MeasureString(array[i], txtfont, true);
							rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
							double degrees2 = (double)num;
							PointF point = new PointF(x, y);
							this.Rotate(degrees2, point);
							string text2 = array[i];
							RectangleF myrect = new RectangleF(x, y, rectangleF.Width, rectangleF.Height);
							this.DrawText(text2, myrect, txtfont, myBrush, stringFormat, 0f);
							this.ResetTransform();
						}
						i++;
					}
				}
				else
				{
					int i = 0;
					while ((double)i < (double)(length + 1) / 2.0)
					{
						unchecked
						{
							float num = (float)(((double)(checked(length - 1)) / 2.0 - (double)i) * (double)txtspace);
							sizeF = this.MeasureString(array[i], txtfont, true);
							rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
							float x = (float)((double)cPointf.X - (double)rx * Math.Sin((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Width / 2f) * Math.Cos((double)num * 3.141592653589793 / 180.0));
							float y = (float)((double)cPointf.Y - (double)ry * Math.Cos((double)num * 3.141592653589793 / 180.0) + (double)(sizeF.Height / 2f) * Math.Sin((double)num * 3.141592653589793 / 180.0));
							double degrees3 = (double)(num * -1f);
							PointF point = new PointF(x, y);
							this.Rotate(degrees3, point);
							string text3 = array[i];
							RectangleF myrect = new RectangleF(x, y, rectangleF.Width, rectangleF.Height);
							this.DrawText(text3, myrect, txtfont, myBrush, stringFormat, 0f);
							this.ResetTransform();
						}
						i++;
					}
					while (i < length)
					{
						unchecked
						{
							float num = (float)(((double)i - (double)(checked(length - 1)) / 2.0) * (double)txtspace);
							float x = (float)((double)cPointf.X + (double)rx * Math.Sin((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Width / 2f) * Math.Cos((double)num * 3.141592653589793 / 180.0));
							float y = (float)((double)cPointf.Y - (double)ry * Math.Cos((double)num * 3.141592653589793 / 180.0) - (double)(sizeF.Height / 2f) * Math.Sin((double)num * 3.141592653589793 / 180.0));
							sizeF = this.MeasureString(array[i], txtfont, true);
							rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
							double degrees4 = (double)num;
							PointF point = new PointF(x, y);
							this.Rotate(degrees4, point);
							string text4 = array[i];
							RectangleF myrect = new RectangleF(x, y, rectangleF.Width, rectangleF.Height);
							this.DrawText(text4, myrect, txtfont, myBrush, stringFormat, 0f);
							this.ResetTransform();
						}
						i++;
					}
				}
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000BA6E0 File Offset: 0x000B88E0
		private static float[] ParaseBorder(string myborder)
		{
			float[] array = new float[4];
			string[] array2 = Strings.Split(myborder, ",", -1, CompareMethod.Binary);
			try
			{
				if (array2.Length == 1)
				{
					if (Versioned.IsNumeric(myborder) & Strings.Len(myborder) == 4 & Strings.InStr(myborder, ".", CompareMethod.Binary) <= 0)
					{
						array[0] = (float)Conversion.Val(Strings.Mid(myborder, 1, 1));
						array[1] = (float)Conversion.Val(Strings.Mid(myborder, 2, 1));
						array[2] = (float)Conversion.Val(Strings.Mid(myborder, 3, 1));
						array[3] = (float)Conversion.Val(Strings.Mid(myborder, 4, 1));
					}
					else if (Versioned.IsNumeric(myborder))
					{
						array[0] = (float)Conversion.Val(myborder);
						array[1] = (float)Conversion.Val(myborder);
						array[2] = (float)Conversion.Val(myborder);
						array[3] = (float)Conversion.Val(myborder);
					}
					else
					{
						array[0] = 0f;
						array[1] = 0f;
						array[2] = 0f;
						array[3] = 0f;
					}
				}
				else if (array2.Length == 4)
				{
					array[0] = (float)Conversion.Val(array2[0]);
					array[1] = (float)Conversion.Val(array2[1]);
					array[2] = (float)Conversion.Val(array2[2]);
					array[3] = (float)Conversion.Val(array2[3]);
				}
				else
				{
					array[0] = 0f;
					array[1] = 0f;
					array[2] = 0f;
					array[3] = 0f;
				}
			}
			catch (Exception ex)
			{
				array[0] = 0f;
				array[1] = 0f;
				array[2] = 0f;
				array[3] = 0f;
			}
			return array;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000BA874 File Offset: 0x000B8A74
		private string SavePenAsString(Pen pp)
		{
			string str = "\u0001\u0005";
			string str2 = Conversions.ToString((int)pp.Alignment);
			str2 = str2 + str + this.SaveBrush(pp.Brush);
			str2 = str2 + str + Conversions.ToString(this.MyConvTo(pp.Width));
			str2 = str2 + str + Conversions.ToString((int)pp.DashCap);
			str2 = str2 + str + Conversions.ToString(pp.DashOffset);
			str2 = str2 + str + Conversions.ToString((int)pp.DashStyle);
			str2 = str2 + str + Conversions.ToString((int)pp.EndCap);
			return str2 + str + Conversions.ToString((int)pp.StartCap);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000BA928 File Offset: 0x000B8B28
		private static Pen RestorePenFromString(string ss)
		{
			string delimiter = "\u0001\u0005";
			Pen result;
			try
			{
				string[] array = Strings.Split(ss, delimiter, -1, CompareMethod.Binary);
				result = new Pen(VB2008Print.RestoreBrush(array[1]), Conversions.ToSingle(array[2]))
				{
					Alignment = (PenAlignment)Conversions.ToInteger(array[0]),
					DashCap = (DashCap)Conversions.ToInteger(array[3]),
					DashOffset = Conversions.ToSingle(array[4]),
					DashStyle = (DashStyle)Conversions.ToInteger(array[5]),
					EndCap = (LineCap)Conversions.ToInteger(array[6]),
					StartCap = (LineCap)Conversions.ToInteger(array[7])
				};
			}
			catch (Exception ex)
			{
				result = new Pen(Brushes.Black);
			}
			return result;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000BA9E0 File Offset: 0x000B8BE0
		private void SaveGraphicsPath(GraphicsPath pp, ref string pathtype, ref string pathpoint)
		{
			checked
			{
				if (pp == null)
				{
					pathtype = "";
					pathpoint = "";
				}
				else
				{
					byte[] pathTypes = pp.PathTypes;
					string text = Convert.ToBase64String(pathTypes);
					string text2 = "";
					int num = 0;
					int num2 = pp.PathPoints.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						unchecked
						{
							if (i == 0)
							{
								text2 = Conversions.ToString((float)this.mypagesetting.Margins.Left + this.MyConvTo(pp.PathPoints[i].X)) + "," + Conversions.ToString((float)this.mypagesetting.Margins.Top + this.MyConvTo(pp.PathPoints[i].Y));
							}
							else
							{
								text2 = string.Concat(new string[]
								{
									text2,
									";",
									Conversions.ToString((float)this.mypagesetting.Margins.Left + this.MyConvTo(pp.PathPoints[i].X)),
									",",
									Conversions.ToString((float)this.mypagesetting.Margins.Top + this.MyConvTo(pp.PathPoints[i].Y))
								});
							}
						}
					}
					pathtype = text;
					pathpoint = text2;
				}
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000BAB40 File Offset: 0x000B8D40
		private static GraphicsPath RestoreGraphicsPath(string pathtype, string pathpoint)
		{
			checked
			{
				GraphicsPath result;
				if (Operators.CompareString(pathtype, "", false) == 0)
				{
					result = null;
				}
				else if (Operators.CompareString(pathpoint, "", false) == 0)
				{
					result = null;
				}
				else
				{
					byte[] types = Convert.FromBase64String(pathtype);
					string[] array = Strings.Split(pathpoint, ";", -1, CompareMethod.Binary);
					if (array == null)
					{
						result = null;
					}
					else if (array.Length <= 0)
					{
						result = null;
					}
					else
					{
						PointF[] array2 = new PointF[array.Length - 1 + 1];
						try
						{
							int num = 0;
							int num2 = array.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								string[] array3 = Strings.Split(array[i], ",", -1, CompareMethod.Binary);
								array2[i].X = Conversions.ToSingle(array3[0]);
								array2[i].Y = Conversions.ToSingle(array3[1]);
							}
						}
						catch (Exception ex)
						{
							return null;
						}
						GraphicsPath graphicsPath;
						try
						{
							graphicsPath = new GraphicsPath(array2, types);
						}
						catch (Exception ex2)
						{
							graphicsPath = null;
						}
						try
						{
						}
						catch (Exception ex3)
						{
						}
						result = graphicsPath;
					}
				}
				return result;
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000BAC7C File Offset: 0x000B8E7C
		private static Brush RestoreBrush(string ss)
		{
			Brush result;
			if (Operators.CompareString(ss, "", false) == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					string[] array = Strings.Split(ss, "\u0003\u0005", -1, CompareMethod.Binary);
					string left = array[0];
					if (Operators.CompareString(left, "1", false) == 0)
					{
						result = VB2008Print.RestoreSolidBrushFromString(array[1]);
					}
					else if (Operators.CompareString(left, "2", false) == 0)
					{
						result = VB2008Print.RestoreTexttureBrushFromString(array[1]);
					}
					else if (Operators.CompareString(left, "3", false) == 0)
					{
						result = VB2008Print.RestoreLinearGradientBrushFromString1(array[1]);
					}
					else if (Operators.CompareString(left, "4", false) == 0)
					{
						result = VB2008Print.RestoreLinearGradientBrushFromString2(array[1]);
					}
					else if (Operators.CompareString(left, "5", false) == 0)
					{
						result = VB2008Print.RestoreHatchBrushFromString(array[1]);
					}
					else
					{
						result = VB2008Print.RestoreSolidBrushFromString(array[1]);
					}
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x000BAD64 File Offset: 0x000B8F64
		private string SaveBrush(Brush sb, LinearGradientMode mylineargradientmode)
		{
			string result;
			if (sb is TextureBrush)
			{
				result = "2\u0003\u0005" + VB2008Print.SaveTexttureBrush((TextureBrush)sb);
			}
			else if (sb is LinearGradientBrush)
			{
				result = "4\u0003\u0005" + this.SaveLinearGradientBrushAsString2((LinearGradientBrush)sb, mylineargradientmode);
			}
			else if (sb is HatchBrush)
			{
				result = "5\u0003\u0005" + VB2008Print.SaveHatchBrushAsString((HatchBrush)sb);
			}
			else
			{
				result = "1\u0003\u0005" + VB2008Print.SaveSolidBrushAsString((SolidBrush)sb);
			}
			return result;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x000BADEC File Offset: 0x000B8FEC
		private string SaveBrush(Brush sb)
		{
			return this.SaveBrush(sb, LinearGradientMode.Horizontal);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000BAE04 File Offset: 0x000B9004
		private string SaveBrush(Brush sb, float myangle)
		{
			string result;
			if (sb is TextureBrush)
			{
				result = "2\u0003\u0005" + VB2008Print.SaveTexttureBrush((TextureBrush)sb);
			}
			else if (sb is LinearGradientBrush)
			{
				result = "3\u0003\u0005" + this.SaveLinearGradientBrushAsString1((LinearGradientBrush)sb, myangle);
			}
			else
			{
				result = "1\u0003\u0005" + VB2008Print.SaveSolidBrushAsString((SolidBrush)sb);
			}
			return result;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000BAE6C File Offset: 0x000B906C
		private static string SaveSolidBrushAsString(SolidBrush sb)
		{
			string result;
			if (sb == null)
			{
				result = "";
			}
			else
			{
				string text = Module1.ConvertColorToString(sb.Color);
				result = text;
			}
			return result;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000BAE9C File Offset: 0x000B909C
		private static SolidBrush RestoreSolidBrushFromString(string ss)
		{
			SolidBrush result;
			try
			{
				result = new SolidBrush(Module1.ConvertStringToColor(ss));
			}
			catch (Exception ex)
			{
				result = new SolidBrush(Color.Black);
			}
			return result;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000BAEE4 File Offset: 0x000B90E4
		private static string SaveHatchBrushAsString(HatchBrush sb)
		{
			string result;
			if (sb == null)
			{
				result = "";
			}
			else
			{
				string text = Module1.ConvertColorToString(sb.BackgroundColor);
				text = text + "\u0002\u0005" + Module1.ConvertColorToString(sb.ForegroundColor);
				text = text + "\u0002\u0005" + Conversions.ToString((int)sb.HatchStyle);
				result = text;
			}
			return result;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000BAF40 File Offset: 0x000B9140
		private static HatchBrush RestoreHatchBrushFromString(string ss)
		{
			string[] array = Strings.Split(ss, "\u0002\u0005", -1, CompareMethod.Binary);
			HatchBrush result;
			try
			{
				result = new HatchBrush((HatchStyle)Conversions.ToInteger(array[2]), Module1.ConvertStringToColor(array[1]), Module1.ConvertStringToColor(array[0]));
			}
			catch (Exception ex)
			{
				result = new HatchBrush(HatchStyle.DashedHorizontal, Color.Black);
			}
			return result;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000BAFAC File Offset: 0x000B91AC
		private static string SaveTexttureBrush(TextureBrush sb)
		{
			string result;
			if (sb == null)
			{
				result = "";
			}
			else
			{
				string text = Module1.ConvertImageToString(sb.Image);
				text = text + "\u0002\u0005" + Conversions.ToString((int)sb.WrapMode);
				result = text;
			}
			return result;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000BAFF0 File Offset: 0x000B91F0
		private static TextureBrush RestoreTexttureBrushFromString(string ss)
		{
			string[] array = Strings.Split(ss, "\u0002\u0005", -1, CompareMethod.Binary);
			TextureBrush result;
			try
			{
				result = new TextureBrush(Module1.ConvertStringToImage(array[0]), (WrapMode)Conversions.ToInteger(array[1]));
			}
			catch (Exception ex)
			{
				result = new TextureBrush(null, (WrapMode)Conversions.ToInteger(array[1]));
			}
			return result;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000BB054 File Offset: 0x000B9254
		private string SaveLinearGradientBrushAsString2(LinearGradientBrush sb, LinearGradientMode mymode)
		{
			string result;
			if (sb == null)
			{
				result = "";
			}
			else
			{
				string text = sb.GammaCorrection ? "1" : "0";
				text = text + "\u0002\u0005" + Module1.ConvertColorToString(sb.LinearColors[0]);
				text = text + "\u0002\u0005" + Module1.ConvertColorToString(sb.LinearColors[1]);
				text = text + "\u0002\u0005" + Conversions.ToString((float)this.mypagesetting.Margins.Left + this.MyConvTo(sb.Rectangle.X));
				text = text + "\u0002\u0005" + Conversions.ToString(this.MyConvTo(sb.Rectangle.Width));
				text = text + "\u0002\u0005" + Conversions.ToString((float)this.mypagesetting.Margins.Top + this.MyConvTo(sb.Rectangle.Y));
				text = text + "\u0002\u0005" + Conversions.ToString(this.MyConvTo(sb.Rectangle.Height));
				text = text + "\u0002\u0005" + Conversions.ToString((int)sb.WrapMode);
				text = text + "\u0002\u0005" + Conversions.ToString((int)mymode);
				text = text + "\u0002\u0005" + VB2008Print.SaveArrayAsString(sb.Blend.Factors);
				text = text + "\u0002\u0005" + VB2008Print.SaveArrayAsString(sb.Blend.Positions);
				result = text;
			}
			return result;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000BB1EC File Offset: 0x000B93EC
		private static LinearGradientBrush RestoreLinearGradientBrushFromString2(string ss)
		{
			string[] array = Strings.Split(ss, "\u0002\u0005", -1, CompareMethod.Binary);
			Color color = Color.Black;
			Color color2 = Color.Black;
			color = Module1.ConvertStringToColor(array[1]);
			color2 = Module1.ConvertStringToColor(array[2]);
			RectangleF rect=new RectangleF();
			rect.X = Conversions.ToSingle(array[3]);
			rect.Width = Conversions.ToSingle(array[4]);
			rect.Y = Conversions.ToSingle(array[5]);
			rect.Height = Conversions.ToSingle(array[6]);
			LinearGradientBrush linearGradientBrush;
			try
			{
				linearGradientBrush = new LinearGradientBrush(rect, color, color2, (LinearGradientMode)Conversions.ToInteger(array[8]));
				linearGradientBrush.GammaCorrection = Conversions.ToBoolean(array[0]);
				linearGradientBrush.WrapMode = (WrapMode)Conversions.ToInteger(array[7]);
				linearGradientBrush.Blend = new Blend
				{
					Factors = VB2008Print.RestoreArrayFromString(array[9]),
					Positions = VB2008Print.RestoreArrayFromString(array[10])
				};
			}
			catch (Exception ex)
			{
				try
				{
					linearGradientBrush = new LinearGradientBrush(rect, color, color2, LinearGradientMode.Horizontal);
					linearGradientBrush.GammaCorrection = Conversions.ToBoolean(array[0]);
					linearGradientBrush.WrapMode = (WrapMode)Conversions.ToInteger(array[7]);
				}
				catch (Exception ex2)
				{
					linearGradientBrush = null;
				}
			}
			return linearGradientBrush;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000BB330 File Offset: 0x000B9530
		private string SaveLinearGradientBrushAsString1(LinearGradientBrush sb, float myangle)
		{
			string result;
			if (sb == null)
			{
				result = "";
			}
			else
			{
				string text = sb.GammaCorrection ? "1" : "0";
				text = text + "\u0002\u0005" + Module1.ConvertColorToString(sb.LinearColors[0]);
				text = text + "\u0002\u0005" + Module1.ConvertColorToString(sb.LinearColors[1]);
				text = text + "\u0002\u0005" + Conversions.ToString((float)this.mypagesetting.Margins.Left + this.MyConvTo(sb.Rectangle.X));
				text = text + "\u0002\u0005" + Conversions.ToString(this.MyConvTo(sb.Rectangle.Width));
				text = text + "\u0002\u0005" + Conversions.ToString((float)this.mypagesetting.Margins.Top + this.MyConvTo(sb.Rectangle.Y));
				text = text + "\u0002\u0005" + Conversions.ToString(this.MyConvTo(sb.Rectangle.Height));
				text = text + "\u0002\u0005" + Conversions.ToString((int)sb.WrapMode);
				text = text + "\u0002\u0005" + Conversions.ToString(myangle);
				text = text + "\u0002\u0005" + VB2008Print.SaveArrayAsString(sb.Blend.Factors);
				text = text + "\u0002\u0005" + VB2008Print.SaveArrayAsString(sb.Blend.Positions);
				result = text;
			}
			return result;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000BB4C8 File Offset: 0x000B96C8
		private static LinearGradientBrush RestoreLinearGradientBrushFromString1(string ss)
		{
			string[] array = Strings.Split(ss, "\u0002\u0005", -1, CompareMethod.Binary);
			Color color = Color.Black;
			Color color2 = Color.Black;
			color = Module1.ConvertStringToColor(array[1]);
			color2 = Module1.ConvertStringToColor(array[2]);
			RectangleF rect=new RectangleF();
			rect.X = Conversions.ToSingle(array[3]);
			rect.Width = Conversions.ToSingle(array[4]);
			rect.Y = Conversions.ToSingle(array[5]);
			rect.Height = Conversions.ToSingle(array[6]);
			LinearGradientBrush linearGradientBrush;
			try
			{
				linearGradientBrush = new LinearGradientBrush(rect, color, color2, Conversions.ToSingle(array[8]));
				linearGradientBrush.GammaCorrection = Conversions.ToBoolean(array[0]);
				linearGradientBrush.WrapMode = (WrapMode)Conversions.ToInteger(array[7]);
				linearGradientBrush.Blend = new Blend
				{
					Factors = VB2008Print.RestoreArrayFromString(array[9]),
					Positions = VB2008Print.RestoreArrayFromString(array[10])
				};
			}
			catch (Exception ex)
			{
				try
				{
					linearGradientBrush = new LinearGradientBrush(rect, color, color2, LinearGradientMode.Horizontal);
					linearGradientBrush.GammaCorrection = Conversions.ToBoolean(array[0]);
					linearGradientBrush.WrapMode = (WrapMode)Conversions.ToInteger(array[7]);
				}
				catch (Exception ex2)
				{
					linearGradientBrush = null;
				}
			}
			return linearGradientBrush;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000BB60C File Offset: 0x000B980C
		private static string SaveArrayAsString(float[] pp)
		{
			checked
			{
				string result;
				if (pp == null)
				{
					result = "";
				}
				else if (pp.Length <= 0)
				{
					result = "";
				}
				else
				{
					string text = Conversions.ToString(pp[0]);
					int num = 1;
					int num2 = pp.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = text + "," + Conversions.ToString(pp[i]);
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000BB66C File Offset: 0x000B986C
		private static float[] RestoreArrayFromString(string ss)
		{
			checked
			{
				float[] result;
				if (Operators.CompareString(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					string[] array = Strings.Split(ss, ",", -1, CompareMethod.Binary);
					float[] array2 = new float[array.Length - 1 + 1];
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						array2[i] = Conversions.ToSingle(array[i]);
					}
					result = array2;
				}
				return result;
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000BB6CC File Offset: 0x000B98CC
		public void DrawTextEx(string s, Font font, Brush brush, float linespace)
		{
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				if (Operators.CompareString(s, "", false) == 0)
				{
					this.mylastdrawtextheight = 0f;
					this.mylastdrawtextwidth = 0f;
				}
				else
				{
					StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
					stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
					float height = this.MeasureString("测试", font, false).Height;
					if (linespace < 0f)
					{
						linespace = height * Math.Abs(linespace);
					}
					this.MyIsNewPage(height, true);
					SizeF mysize = default(SizeF);
					mysize = this.MeasureString("测试", font, false);
					mysize.Width = this.PaperPrintWidth - this.Currentx;
					SizeF sizeF = default(SizeF);
					int num;
					int num2;
					sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
					string text = Strings.Mid(s, 1, num);
					s = Strings.Mid(s, checked(num + 1));
					while (!this.CancelDocument)
					{
						string text2 = text;
						RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, sizeF.Width, sizeF.Height);
						this.DrawText(text2, myrect, font, brush, stringFormat, font.Size);
						if (Operators.CompareString(s, "", false) == 0)
						{
							stringFormat.Dispose();
							break;
						}
						this.Currenty = this.Currenty + height + linespace;
						this.Currentx = 0f;
						this.MyIsNewPage(height, true);
						mysize.Height = height;
						mysize.Width = this.PaperPrintWidth;
						sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
						text = Strings.Mid(s, 1, num);
						s = Strings.Mid(s, checked(num + 1));
					}
				}
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000BB8CC File Offset: 0x000B9ACC
		public void DrawTextEx(string s, float mywidth, Font font, Brush brush, float linespace)
		{
			if (mywidth > 0f)
			{
				if (Operators.CompareString(s, "", false) == 0)
				{
					this.mylastdrawtextheight = 0f;
					this.mylastdrawtextwidth = 0f;
				}
				else if (!this.CancelDocument)
				{
					if (font == null)
					{
						font = this.myfont;
					}
					if (font == null)
					{
						font = new Font("宋体", 12f, FontStyle.Regular);
					}
					if (Operators.CompareString(s, "", false) == 0)
					{
						this.mylastdrawtextheight = 0f;
						this.mylastdrawtextwidth = 0f;
					}
					else
					{
						StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
						stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
						float height = this.MeasureString("测试", font, false).Height;
						if (linespace < 0f)
						{
							linespace = height * Math.Abs(linespace);
						}
						float currentx = this.Currentx;
						this.MyIsNewPage(height, true);
						SizeF mysize = default(SizeF);
						mysize = this.MeasureString("测试", font, false);
						mysize.Width = mywidth;
						SizeF sizeF = default(SizeF);
						int num;
						int num2;
						sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
						string text = Strings.Mid(s, 1, num);
						s = Strings.Mid(s, checked(num + 1));
						while (!this.CancelDocument)
						{
							string text2 = text;
							RectangleF myrect = new RectangleF(currentx, this.Currenty, sizeF.Width, sizeF.Height);
							this.DrawText(text2, myrect, font, brush, stringFormat, font.Size);
							if (Operators.CompareString(s, "", false) == 0)
							{
								stringFormat.Dispose();
								break;
							}
							this.Currenty = this.Currenty + height + linespace;
							this.Currentx = currentx;
							this.MyIsNewPage(height, true);
							mysize.Height = height;
							mysize.Width = mywidth;
							sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
							text = Strings.Mid(s, 1, num);
							s = Strings.Mid(s, checked(num + 1));
						}
					}
				}
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000BBAC8 File Offset: 0x000B9CC8
		public void DrawTextEx(string s, Font font, Brush brush, float linespace, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				float height = this.MeasureString("测试", font, false).Height;
				if (linespace < 0f)
				{
					linespace = height * Math.Abs(linespace);
				}
				this.MyIsNewPage(height, true);
				StringFormat stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
				stringFormat2.FormatFlags = (stringFormat2.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				SizeF sizeF = default(SizeF);
				string text = Strings.Mid(s, 1, 1);
				sizeF = this.MeasureString(text, font, stringFormat2, false);
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", font, false).Width * Math.Abs(charspace);
				}
				if (this.Currentx + sizeF.Width > this.PaperPrintWidth)
				{
					this.NewRow(this.LastDrawTextHeight);
				}
				this.MyIsNewPage(height, true);
				int num = 1;
				checked
				{
					int num2 = s.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						if (this.CancelDocument)
						{
							return;
						}
						this.DrawTextExSingleChar(text, font, brush);
						text = Strings.Mid(s, i + 1, 1);
						sizeF = this.MeasureString(text, font, stringFormat2, false);
						unchecked
						{
							if (this.Currentx + sizeF.Width + charspace > this.PaperPrintWidth | Strings.Asc(text) == 13)
							{
								this.Currenty = this.Currenty + height + linespace;
								this.Currentx = 0f;
								this.MyIsNewPage(height, true);
							}
							else
							{
								this.Currentx += charspace;
							}
							if (Strings.Asc(text) == 13)
							{
								text = "";
								this.Currentx -= charspace;
							}
						}
					}
					this.DrawTextEx(text, font, brush, linespace);
				}
				this.Currentx += charspace;
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000BBD14 File Offset: 0x000B9F14
		public void DrawTextEx(string s, float mywidth, Font font, Brush brush, float linespace, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			if (mywidth > 0f)
			{
				if (Operators.CompareString(s, "", false) == 0)
				{
					this.mylastdrawtextheight = 0f;
					this.mylastdrawtextwidth = 0f;
				}
				else if (!this.CancelDocument)
				{
					if (font == null)
					{
						font = this.myfont;
					}
					if (font == null)
					{
						font = new Font("宋体", 12f, FontStyle.Regular);
					}
					if (Operators.CompareString(s, "", false) == 0)
					{
						this.mylastdrawtextheight = 0f;
						this.mylastdrawtextwidth = 0f;
					}
					else
					{
						StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
						stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
						float height = this.MeasureString("测试", font, false).Height;
						if (linespace < 0f)
						{
							linespace = height * Math.Abs(linespace);
						}
						float currentx = this.Currentx;
						this.MyIsNewPage(height, true);
						SizeF sizeF = default(SizeF);
						string text = Strings.Mid(s, 1, 1);
						sizeF = this.MeasureString(text, font, stringFormat, false);
						if (mywidth >= sizeF.Width)
						{
							if (charspace < 0f)
							{
								charspace = this.MeasureString("测", font, false).Width * Math.Abs(charspace);
							}
							this.MyIsNewPage(height, true);
							float num = sizeF.Width;
							int num2 = 1;
							checked
							{
								int num3 = s.Length - 1;
								for (int i = num2; i <= num3; i++)
								{
									if (this.CancelDocument)
									{
										return;
									}
									if (Operators.CompareString(text, "", false) != 0)
									{
										this.DrawTextExSingleChar(text, font, brush);
									}
									text = Strings.Mid(s, i + 1, 1);
									sizeF = this.MeasureString(text, font, stringFormat, false);
									unchecked
									{
										if (num + sizeF.Width + charspace > mywidth | Strings.Asc(text) == 13)
										{
											this.Currenty = this.Currenty + height + linespace;
											this.MyIsNewPage(height, true);
											this.Currentx = currentx;
											if (Strings.Asc(text) != 13)
											{
												num = sizeF.Width;
											}
											else
											{
												num = 0f;
											}
										}
										else
										{
											num += sizeF.Width;
											num += charspace;
											this.Currentx += charspace;
										}
										if (Strings.Asc(text) == 13)
										{
											text = "";
											this.Currentx -= charspace;
											num -= charspace;
										}
									}
								}
								this.DrawTextEx(text, font, brush, linespace);
							}
							this.Currentx += charspace;
							stringFormat.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		public float MeasureTextExHeight(string s, Font font, float mywidth, float linespace)
		{
			float result;
			if (mywidth <= 0f)
			{
				result = -1f;
			}
			else if (Operators.CompareString(s, "", false) == 0)
			{
				result = 0f;
			}
			else if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				float height = this.MeasureString("测试", font, false).Height;
				if (linespace < 0f)
				{
					linespace = height * Math.Abs(linespace);
				}
				SizeF mysize = default(SizeF);
				mysize = this.MeasureString("测试", font, false);
				mysize.Width = mywidth;
				SizeF sizeF = default(SizeF);
				int num;
				int num2;
				sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
				s = Strings.Mid(s, checked(num + 1));
				float num3 = height;
				while (Operators.CompareString(s, "", false) != 0)
				{
					num3 = num3 + height + linespace;
					mysize.Height = height;
					mysize.Width = mywidth;
					sizeF = this.MeasureString(s, font, mysize, stringFormat, ref num, ref num2, false);
					s = Strings.Mid(s, checked(num + 1));
				}
				stringFormat.Dispose();
				result = num3;
			}
			return result;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000BC110 File Offset: 0x000BA310
		public float MeasureTextExHeight(string s, Font font, float width, float linespace, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			float result;
			if (width <= 0f)
			{
				result = -1f;
			}
			else
			{
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				if (Operators.CompareString(s, "", false) == 0)
				{
					result = 0f;
				}
				else if (this.CancelDocument)
				{
					result = 0f;
				}
				else
				{
					if (font == null)
					{
						font = this.myfont;
					}
					if (font == null)
					{
						font = new Font("宋体", 12f, FontStyle.Regular);
					}
					float height = this.MeasureString("测试", font, false).Height;
					if (linespace < 0f)
					{
						linespace = height * Math.Abs(linespace);
					}
					SizeF sizeF = default(SizeF);
					string text = Strings.Mid(s, 1, 1);
					sizeF = this.MeasureString(text, font, stringFormat, false);
					if (charspace < 0f)
					{
						charspace = this.MeasureString("测", font, false).Width * Math.Abs(charspace);
					}
					checked
					{
						if (width < this.MeasureString("测", font, false).Width)
						{
							result = -1f;
						}
						else
						{
							float num = sizeF.Width;
							float num2 = height;
							int num3 = 1;
							int num4 = s.Length - 1;
							for (int i = num3; i <= num4; i++)
							{
								text = Strings.Mid(s, i + 1, 1);
								sizeF = this.MeasureString(text, font, stringFormat, false);
								unchecked
								{
									if (num + sizeF.Width + charspace > width | Strings.Asc(text) == 13)
									{
										num2 = num2 + linespace + height;
										if (Strings.Asc(text) != 13)
										{
											num = sizeF.Width;
										}
										else
										{
											num = 0f;
										}
									}
									else
									{
										num += sizeF.Width;
										num += charspace;
									}
									if (Strings.Asc(text) == 13)
									{
										num -= charspace;
									}
								}
							}
							stringFormat.Dispose();
							result = num2;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000BC31C File Offset: 0x000BA51C
		public float MeasureTextExWidth(string s, Font font, float height, float linespace)
		{
			float result;
			if (height <= 0f)
			{
				result = -1f;
			}
			else if (Operators.CompareString(s, "", false) == 0)
			{
				result = 0f;
			}
			else if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				float height2 = this.MeasureString("测试", font, false).Height;
				if (linespace < 0f)
				{
					linespace = height2 * Math.Abs(linespace);
				}
				if (height < height2)
				{
					result = -1f;
				}
				else
				{
					float width = this.MeasureString("B", font, false).Width;
					float num = this.MeasureString("测", font, false).Width;
					int num2 = s.Split(new char[]
					{
						'\r'
					}).Length;
					if ((float)num2 * height2 + (float)(checked(num2 - 1)) * linespace > height)
					{
						result = -1f;
					}
					else
					{
						while (this.MeasureTextExHeight(s, font, num, linespace) > height)
						{
							num += width;
						}
						result = num;
					}
				}
			}
			return result;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000BC438 File Offset: 0x000BA638
		public float MeasureTextExWidth(string s, Font font, float height, float linespace, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			float result;
			if (height <= 0f)
			{
				result = -1f;
			}
			else if (Operators.CompareString(s, "", false) == 0)
			{
				result = 0f;
			}
			else if (this.CancelDocument)
			{
				result = 0f;
			}
			else
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				float height2 = this.MeasureString("测试", font, false).Height;
				if (linespace < 0f)
				{
					linespace = height2 * Math.Abs(linespace);
				}
				if (height < height2)
				{
					result = -1f;
				}
				else
				{
					float width = this.MeasureString("B", font, false).Width;
					float num = this.MeasureString("测", font, false).Width;
					SizeF sizeF = default(SizeF);
					string txt = Strings.Mid(s, 1, 1);
					sizeF = this.MeasureString(txt, font, false);
					if (charspace < 0f)
					{
						charspace = this.MeasureString("测", font, false).Width * Math.Abs(charspace);
					}
					int num2 = s.Split(new char[]
					{
						'\r'
					}).Length;
					if ((float)num2 * height2 + (float)(checked(num2 - 1)) * linespace > height)
					{
						result = -1f;
					}
					else
					{
						while (this.MeasureTextExHeight(s, font, num, linespace, charspace) > height)
						{
							num += width;
						}
						result = num;
					}
				}
			}
			return result;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000BC5B8 File Offset: 0x000BA7B8
		public float MeasureTextExWidth(string s, Font thefont, float charspace)
		{
			s = Strings.Replace(s, "\n", "", 1, -1, CompareMethod.Binary);
			float result;
			if (Operators.CompareString(s, "", false) == 0)
			{
				result = 0f;
			}
			else
			{
				string[] array = Strings.Split(s, "\r", -1, CompareMethod.Binary);
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", thefont, false).Width * Math.Abs(charspace);
				}
				float num = -1f;
				int num2 = 0;
				checked
				{
					int num3 = array.Length - 1;
					for (int i = num2; i <= num3; i++)
					{
						float num4 = this.MeasureTextExWidthSingleLine(array[i], thefont, charspace);
						if (num < num4)
						{
							num = num4;
						}
					}
					result = num;
				}
			}
			return result;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000BC65C File Offset: 0x000BA85C
		private float MeasureTextExWidthSingleLine(string s, Font thefont, float charspace)
		{
			float result;
			if (Operators.CompareString(s, "", false) == 0)
			{
				result = 0f;
			}
			else
			{
				if (charspace < 0f)
				{
					charspace = this.MeasureString("测", thefont, false).Width * Math.Abs(charspace);
				}
				float num = 0f;
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				int num2 = 0;
				checked
				{
					int num3 = s.Length - 1;
					for (int i = num2; i <= num3; i++)
					{
						unchecked
						{
							num += this.MeasureString(Strings.Mid(s, checked(i + 1), 1), thefont, stringFormat, false).Width;
							num += charspace;
						}
					}
				}
				num -= charspace;
				stringFormat.Dispose();
				result = num;
			}
			return result;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000BC71C File Offset: 0x000BA91C
		private void DrawTextExSingleChar(string s, Font font, Brush brush)
		{
			if (Operators.CompareString(s, "", false) == 0)
			{
				this.mylastdrawtextheight = 0f;
				this.mylastdrawtextwidth = 0f;
			}
			else if (!this.CancelDocument)
			{
				if (font == null)
				{
					font = this.myfont;
				}
				if (font == null)
				{
					font = new Font("宋体", 12f, FontStyle.Regular);
				}
				StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
				stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
				SizeF sizeF = default(SizeF);
				sizeF = this.MeasureString(s, font, stringFormat, false);
				RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, sizeF.Width, sizeF.Height);
				this.DrawText(s, myrect, font, brush, stringFormat, font.Size);
				stringFormat.Dispose();
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000BC7F0 File Offset: 0x000BA9F0
		public void DrawChartPie(PointF cpointf, float r, float[] data)
		{
			checked
			{
				if (data != null)
				{
					Brush[] array = new Brush[data.Length - 1 + 1];
					int num = 0;
					int num2 = data.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = new SolidBrush(VB2008Print.RandColor());
					}
					this.DrawChartPie(cpointf, r, data, array);
				}
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000BC838 File Offset: 0x000BAA38
		public void DrawChartPie(PointF cpointf, float r, float[] data, Brush[] databrush)
		{
			if (databrush != null && data != null)
			{
				if (data.Length == databrush.Length)
				{
					Pen mypen = new Pen(Color.Black);
					RectangleF rectangleF = new RectangleF(cpointf.X - r, cpointf.Y - r, 2f * r, 2f * r);
					this.DrawEllipse(mypen, rectangleF);
					checked
					{
						float[] array = new float[data.Length - 1 + 1];
						float num = 0f;
						int num2 = 0;
						int num3 = data.Length - 1;
						for (int i = num2; i <= num3; i++)
						{
							unchecked
							{
								num += data[i];
							}
						}
						if (num != 0f)
						{
							int num4 = 0;
							int num5 = data.Length - 1;
							for (int j = num4; j <= num5; j++)
							{
								array[j] = unchecked(data[j] / num * 360f);
							}
							float num6 = unchecked(VBMath.Rnd() * 360f);
							num = num6;
							int num7 = 0;
							int num8 = data.Length - 1;
							for (int k = num7; k <= num8; k++)
							{
								this.DrawFillPie(databrush[k], rectangleF, num6, array[k]);
								unchecked
								{
									num += array[k];
									num6 = num;
									if (num6 >= 360f)
									{
										num6 %= 360f;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000BC968 File Offset: 0x000BAB68
		public static Color RandColor()
		{
			checked
			{
				int red = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				int green = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				int blue = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				return Color.FromArgb(red, green, blue);
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000BC9DC File Offset: 0x000BABDC
		public static Color RandColor(int alpha)
		{
			checked
			{
				int red = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				int green = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				int blue = (int)Math.Round((double)Conversion.Int(unchecked(256f * VBMath.Rnd() + 0f)));
				return Color.FromArgb(alpha, red, green, blue);
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00007DCF File Offset: 0x00005FCF
		public void SetClip(RectangleF rect)
		{
			this.SetClip(rect, CombineMode.Replace);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000BCA50 File Offset: 0x000BAC50
		public void SetClip(RectangleF rect, CombineMode combineMode)
		{
			this.MyWrite("setclip", Conversions.ToString((float)this.mypagesetting.Margins.Left + this.MyConvTo(rect.X)), Conversions.ToString((float)this.mypagesetting.Margins.Top + this.MyConvTo(rect.Y)), Conversions.ToString(this.MyConvTo(rect.Width)), Conversions.ToString(this.MyConvTo(rect.Height)), Conversions.ToString((int)combineMode));
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00007DD9 File Offset: 0x00005FD9
		public void SetClip(GraphicsPath path)
		{
			this.SetClip(path, CombineMode.Replace);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000BCADC File Offset: 0x000BACDC
		public void SetClip(GraphicsPath path, CombineMode combineMode)
		{
			string t = "";
			string t2 = "";
			this.SaveGraphicsPath(path, ref t, ref t2);
			this.MyWrite("setclip2", t, t2, Conversions.ToString((int)combineMode));
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000BCB14 File Offset: 0x000BAD14
		private void mySetClip(float x, float y, float mywidth, float myheight, string tt)
		{
			if (this.myg != null)
			{
				Graphics graphics = this.myg;
				RectangleF rect = new RectangleF(x, y, mywidth, myheight);
				graphics.SetClip(rect, (CombineMode)Conversions.ToInteger(tt));
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000BCB48 File Offset: 0x000BAD48
		private void mySetClip(string s1, string s2, string tt)
		{
			GraphicsPath graphicsPath = VB2008Print.RestoreGraphicsPath(s1, s2);
			if (graphicsPath != null && this.myg != null)
			{
				this.myg.SetClip(graphicsPath, (CombineMode)Conversions.ToInteger(tt));
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00007DE3 File Offset: 0x00005FE3
		public void ResetClip()
		{
			this.MyWrite("resetclip", "");
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00007DF5 File Offset: 0x00005FF5
		private void myResetClip()
		{
			if (this.myg != null)
			{
				this.myg.ResetClip();
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000BCB7C File Offset: 0x000BAD7C
		public void DrawExpression(ExpressionDrawer myExpression, RectangleF rect)
		{
			if (myExpression != null)
			{
				string text = myExpression.GetDataString();
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				byte[] bytes = unicodeEncoding.GetBytes(text);
				text = Convert.ToBase64String(bytes);
				this.MyWrite("drawexpress", Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Left + rect.Left)), Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Top + rect.Top)), Conversions.ToString(this.MyConvTo(rect.Width)), Conversions.ToString(this.MyConvTo(rect.Height)), text);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000BCC1C File Offset: 0x000BAE1C
		private void MyDrawExpression(float x, float y, float mywidth, float myheight, string ss)
		{
			byte[] bytes = Convert.FromBase64String(ss);
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			ss = unicodeEncoding.GetString(bytes);
			ExpressionDrawer expressionDrawer = new ExpressionDrawer();
			expressionDrawer.ParaseString(ss);
			RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
			Matrix transform = this.myg.Transform;
			try
			{
				expressionDrawer.Render(this.myg, myrect);
			}
			catch (Exception ex)
			{
			}
			this.myg.Transform = transform;
			transform = null;
			expressionDrawer.Dispose();
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000BCCAC File Offset: 0x000BAEAC
		public void DrawChart(Chartlet chartlet, float x, float y)
		{
			if (chartlet != null)
			{
				RectangleF rect = new RectangleF(x, y, this.ConvFromDisplay((float)chartlet.Width, true), this.ConvFromDisplay((float)chartlet.Height, false));
				this.DrawChart(chartlet, rect);
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000BCCEC File Offset: 0x000BAEEC
		public void DrawChart(Chartlet mychartlet, RectangleF rect)
		{
			if (mychartlet != null)
			{
				string text = mychartlet.GetDataString();
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				byte[] bytes = unicodeEncoding.GetBytes(text);
				text = Convert.ToBase64String(bytes);
				this.MyWrite("drawchartlet", Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Left + rect.Left)), Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Top + rect.Top)), Conversions.ToString(this.MyConvTo(rect.Width)), Conversions.ToString(this.MyConvTo(rect.Height)), text);
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000BCD8C File Offset: 0x000BAF8C
		private void MyDrawChartlet(float x, float y, float mywidth, float myheight, string ss)
		{
			byte[] bytes = Convert.FromBase64String(ss);
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			ss = unicodeEncoding.GetString(bytes);
			checked
			{
				Chartlet chartlet = new Chartlet((int)Math.Round((double)mywidth), (int)Math.Round((double)myheight));
				chartlet.ParaseDataString(ss);
				Rectangle rect = new Rectangle((int)Math.Round((double)x), (int)Math.Round((double)y), (int)Math.Round((double)mywidth), (int)Math.Round((double)myheight));
				Matrix transform = this.myg.Transform;
				try
				{
					chartlet.Render(this.myg, rect);
				}
				catch (Exception ex)
				{
				}
				this.myg.Transform = transform;
				transform = null;
				chartlet.Dispose();
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000BCE48 File Offset: 0x000BB048
		private void fpage_Click(object sender, EventArgs e)
		{
			try
			{
				this.cpage.Text = "第1页";
			}
			catch (Exception ex)
			{
			}
			this.cpage_SelectedIndexChanged(null, null);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000BCE90 File Offset: 0x000BB090
		private void ppage_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = (int)Math.Round(Conversion.Val(Strings.Mid(this.cpage.Text, 2)));
					num--;
					if (num >= 1)
					{
						this.cpage.Text = "第" + Conversions.ToString(num) + "页";
					}
					else
					{
						this.cpage.Text = "第1页";
					}
				}
				catch (Exception ex)
				{
				}
				this.cpage_SelectedIndexChanged(null, null);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000BCF1C File Offset: 0x000BB11C
		private void npage_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = (int)Math.Round(Conversion.Val(Strings.Mid(this.cpage.Text, 2)));
					num++;
					if (num <= this.GetPages())
					{
						this.cpage.Text = "第" + Conversions.ToString(num) + "页";
					}
					else
					{
						this.cpage.Text = "第" + Conversions.ToString(this.GetPages()) + "页";
					}
				}
				catch (Exception ex)
				{
				}
				this.cpage_SelectedIndexChanged(null, null);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000BCFC4 File Offset: 0x000BB1C4
		private void lpage_Click(object sender, EventArgs e)
		{
			try
			{
				this.cpage.Text = "第" + Conversions.ToString(this.GetPages()) + "页";
			}
			catch (Exception ex)
			{
			}
			this.cpage_SelectedIndexChanged(null, null);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000BD020 File Offset: 0x000BB220
		public void DrawIcon(Icon myicon, float x, float y)
		{
			if (myicon != null && !this.CancelDocument)
			{
				string t = Module1.ConvertIcoToString(myicon);
				this.MyWrite("drawicon", Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Left + x)), Conversions.ToString(this.MyConvTo((float)this.PaperMargins.Top + y)), t);
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000BD080 File Offset: 0x000BB280
		public void DrawIcon(Icon myicon, RectangleF targetRect)
		{
			if (myicon != null && !this.CancelDocument)
			{
				string t = Module1.ConvertIcoToString(myicon);
				this.MyWrite("drawicon2", this.ConvertRectToString(targetRect), t);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000BD0B4 File Offset: 0x000BB2B4
		private void myDrawIcon(float x, float y, Icon ico)
		{
			if (ico != null && this.myg != null)
			{
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				Graphics graphics = this.myg;
				Image image = ico.ToBitmap();
				PointF point = new PointF(x, y);
				graphics.DrawImage(image, point);
				this.myg.Transform = transform;
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000BD10C File Offset: 0x000BB30C
		private void myDrawIcon(string ss, Icon ico)
		{
			if (ico != null && this.myg != null)
			{
				RectangleF rectangleF = this.ConvertStringToRect(ss);
				Matrix transform = this.myg.Transform;
				this.PY(this.myg);
				Graphics graphics = this.myg;
				Image image = ico.ToBitmap();
				Rectangle rect = checked(new Rectangle((int)Math.Round((double)rectangleF.Left), (int)Math.Round((double)rectangleF.Top), (int)Math.Round((double)rectangleF.Width), (int)Math.Round((double)rectangleF.Height)));
				graphics.DrawImage(image, rect);
				this.myg.Transform = transform;
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000BD1A4 File Offset: 0x000BB3A4
		private void ShowStatus()
		{
			if (this.myprogresswait != null)
			{
				try
				{
					this.myprogresswait.Dispose();
					this.myprogresswait = null;
				}
				catch (Exception ex)
				{
				}
			}
			this.myprogresswait = new progress();
			this.myprogresswait.Show(this.ParentForm);
			try
			{
				if (this.isprinttoprinter)
				{
					if (this.myprogresswait != null)
					{
						this.myprogresswait.Button1.Text = "取消打印";
					}
				}
				else if (this.myprogresswait != null)
				{
					this.myprogresswait.Button1.Text = "取消预览";
				}
			}
			catch (Exception ex2)
			{
			}
			Application.DoEvents();
			this.SetStatus("正在处理中，请稍侯……");
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000BD278 File Offset: 0x000BB478
		private void SetStatusNew(string ss)
		{
			try
			{
				if (this.myprogresswait != null)
				{
					this.myprogresswait.SetStatus(ss);
				}
			}
			catch (Exception ex)
			{
			}
			Application.DoEvents();
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000BD2C0 File Offset: 0x000BB4C0
		private void CloseStatus()
		{
			try
			{
				if (this.myprogresswait != null)
				{
					this.myprogresswait.Dispose();
					this.myprogresswait = null;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000BD308 File Offset: 0x000BB508
		public void DrawBiasCell1(string rowheadertext, string colheadertext, float w, float h, Font rowheaderfont, Font colheaderfont, Color mycolor, Pen mypen, Brush mybrush)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.IsNewPage(h, true);
				}
				float currentx = this.Currentx;
				float currenty = this.Currenty;
				RectangleF myrect = new RectangleF(currentx, currenty, w, h);
				this.DrawFillRectangle(mybrush, myrect);
				this.DrawRectangle(mypen, myrect);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h);
				float num = (float)Math.Sqrt((double)(h / 2f * h / 2f + w * w));
				float num2 = (float)(Math.Asin((double)(h / 2f / num)) * 180.0 / 3.141592653589793);
				this.Currentx = currentx;
				float height = this.MeasureText("测试", rowheaderfont).Height;
				this.Currenty = currenty - height / 2f;
				double degrees = (double)num2;
				PointF point = new PointF(currentx, currenty);
				this.Rotate(degrees, point);
				this.DrawText(rowheadertext, num, height, rowheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w * w));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont).Height;
				this.Currentx = currentx;
				this.Currenty = currenty + height / 6f;
				double degrees2 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees2, point);
				this.DrawText(colheadertext, num, height, colheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				this.mylastdrawtextheight = this.MyConvTo(h);
				this.mylastdrawtextwidth = this.MyConvTo(w);
				this.Currentx = currentx + w;
				this.Currenty = currenty;
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000BD4E0 File Offset: 0x000BB6E0
		public void DrawBiasCell2(string rowheadertext, string dataheadertext, string colheadertext, float w, float h, Font rowheaderfont, Font dataheaderfont, Font colheaderfont, Color mycolor, Pen mypen, Brush mybrush)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.IsNewPage(h, true);
				}
				float currentx = this.Currentx;
				float currenty = this.Currenty;
				RectangleF myrect = new RectangleF(currentx, currenty, w, h);
				this.DrawFillRectangle(mybrush, myrect);
				this.DrawRectangle(mypen, myrect);
				this.DrawLine(mypen, currentx + w / 2f, currenty, currentx + w, currenty + h);
				this.DrawLine(mypen, currentx, currenty + h / 2f, currentx + w, currenty + h);
				float num = (float)Math.Sqrt((double)(h * h + w / 2f * w / 2f));
				float num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				this.Currentx = currentx + w / 2f;
				float height = this.MeasureText("测试", rowheaderfont).Height;
				this.Currenty = currenty - height;
				double degrees = (double)num2;
				PointF point = new PointF(currentx + w / 2f, currenty);
				this.Rotate(degrees, point);
				this.DrawText(rowheadertext, num, height, rowheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w * w));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", dataheaderfont).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees2 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees2, point);
				this.DrawText(dataheadertext, num, height, dataheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h / 2f * h / 2f + w * w));
				num2 = (float)(Math.Asin((double)(h / 2f / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont).Height;
				this.Currenty = currenty + h / 2f;
				this.Currentx = currentx;
				double degrees3 = (double)num2;
				point = new PointF(currentx, currenty + h / 2f);
				this.Rotate(degrees3, point);
				this.DrawText(colheadertext, num, height, colheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				this.Currentx = currentx + w;
				this.Currenty = currenty;
				this.mylastdrawtextheight = this.MyConvTo(h);
				this.mylastdrawtextwidth = this.MyConvTo(w);
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000BD790 File Offset: 0x000BB990
		public void DrawBiasCell3(string rowheadertext1, string rowheadertext2, string colheadertext, float w, float h, Font rowheaderfont1, Font rowheaderfont2, Font colheaderfont, Color mycolor, Pen mypen, Brush mybrush)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.IsNewPage(h, true);
				}
				float currentx = this.Currentx;
				float currenty = this.Currenty;
				RectangleF myrect = new RectangleF(currentx, currenty, w, h);
				this.DrawFillRectangle(mybrush, myrect);
				this.DrawRectangle(mypen, myrect);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h / 2f);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h);
				float num = (float)Math.Sqrt((double)(h / 2f * h / 2f + w * w));
				float num2 = (float)(Math.Asin((double)(h / 2f / num)) * 180.0 / 3.141592653589793);
				this.Currentx = currentx;
				float height = this.MeasureText("测试", rowheaderfont1).Height;
				this.Currenty = currenty - height;
				double degrees = (double)num2;
				PointF point = new PointF(currentx, currenty);
				this.Rotate(degrees, point);
				this.DrawText(rowheadertext1, num, height, rowheaderfont1, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * 3f / 4f * h * 3f / 4f + w * w));
				num2 = (float)(Math.Asin((double)(h * 3f / 4f / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", rowheaderfont2).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees2 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees2, point);
				this.DrawText(rowheadertext2, num, height, rowheaderfont2, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w / 2f * w / 2f));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees3 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees3, point);
				this.DrawText(colheadertext, num, height, colheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				this.Currentx = currentx + w;
				this.Currenty = currenty;
				this.mylastdrawtextheight = this.MyConvTo(h);
				this.mylastdrawtextwidth = this.MyConvTo(w);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000BDA40 File Offset: 0x000BBC40
		public void DrawBiasCell4(string rowheadertext, string colheadertext1, string colheadertext2, float w, float h, Font rowheaderfont, Font colheaderfont1, Font colheaderfont2, Color mycolor, Pen mypen, Brush mybrush)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.IsNewPage(h, true);
				}
				float currentx = this.Currentx;
				float currenty = this.Currenty;
				RectangleF myrect = new RectangleF(currentx, currenty, w, h);
				this.DrawFillRectangle(mybrush, myrect);
				this.DrawRectangle(mypen, myrect);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h);
				this.DrawLine(mypen, currentx, currenty, currentx + w / 2f, currenty + h);
				float num = (float)Math.Sqrt((double)(h / 2f * h / 2f + w * w));
				float num2 = (float)(Math.Asin((double)(h / 2f / num)) * 180.0 / 3.141592653589793);
				this.Currentx = currentx;
				float height = this.MeasureText("测试", rowheaderfont).Height;
				this.Currenty = currenty - height / 2f;
				double degrees = (double)num2;
				PointF point = new PointF(currentx, currenty);
				this.Rotate(degrees, point);
				this.DrawText(rowheadertext, num, height, rowheaderfont, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w * 3f / 4f * w * 3f / 4f));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont1).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees2 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees2, point);
				this.DrawText(colheadertext1, num, height, colheaderfont1, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w / 2f * w / 2f));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont2).Height;
				this.Currenty = currenty + height / 6f;
				this.Currentx = currentx;
				double degrees3 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees3, point);
				this.DrawText(colheadertext2, num, height, colheaderfont2, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				this.Currentx = currentx + w;
				this.Currenty = currenty;
				this.mylastdrawtextheight = this.MyConvTo(h);
				this.mylastdrawtextwidth = this.MyConvTo(w);
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000BDCEC File Offset: 0x000BBEEC
		public void DrawBiasCell5(string rowheadertext1, string rowheadertext2, string colheadertext1, string colheadertext2, float w, float h, Font rowheaderfont1, Font rowheaderfont2, Font colheaderfont1, Font colheaderfont2, Color mycolor, Pen mypen, Brush mybrush)
		{
			if (!this.CancelDocument)
			{
				if (this.IsNeedCheckNewPage)
				{
					this.IsNewPage(h, true);
				}
				float currentx = this.Currentx;
				float currenty = this.Currenty;
				RectangleF myrect = new RectangleF(currentx, currenty, w, h);
				this.DrawFillRectangle(mybrush, myrect);
				this.DrawRectangle(mypen, myrect);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h / 2f);
				this.DrawLine(mypen, currentx, currenty, currentx + w, currenty + h);
				this.DrawLine(mypen, currentx, currenty, currentx + w / 2f, currenty + h);
				float num = (float)Math.Sqrt((double)(h / 2f * h / 2f + w * w));
				float num2 = (float)(Math.Asin((double)(h / 2f / num)) * 180.0 / 3.141592653589793);
				this.Currentx = currentx;
				float height = this.MeasureText("测试", rowheaderfont1).Height;
				this.Currenty = currenty - height;
				double degrees = (double)num2;
				PointF point = new PointF(currentx, currenty);
				this.Rotate(degrees, point);
				this.DrawText(rowheadertext1, num, height, rowheaderfont1, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * 3f / 4f * h * 3f / 4f + w * w));
				num2 = (float)(Math.Asin((double)(h * 3f / 4f / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", rowheaderfont2).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees2 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees2, point);
				this.DrawText(rowheadertext2, num, height, rowheaderfont2, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				num = (float)Math.Sqrt((double)(h * h + w * 3f / 4f * w * 3f / 4f));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont1).Height;
				this.Currenty = currenty - height / 2f;
				this.Currentx = currentx;
				double degrees3 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees3, point);
				this.DrawText(colheadertext1, num, height, colheaderfont1, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				num = (float)Math.Sqrt((double)(h * h + w / 2f * w / 2f));
				num2 = (float)(Math.Asin((double)(h / num)) * 180.0 / 3.141592653589793);
				height = this.MeasureText("测试", colheaderfont2).Height;
				this.Currenty = currenty + height / 6f;
				this.Currentx = currentx;
				double degrees4 = (double)num2;
				point = new PointF(currentx, currenty);
				this.Rotate(degrees4, point);
				this.DrawText(colheadertext2, num, height, colheaderfont2, mycolor, StringAlignment.Center, StringAlignment.Center, false, true, false, false, 6f, 0);
				this.ResetTransform();
				this.Currentx = currentx + w;
				this.Currenty = currenty;
				this.mylastdrawtextheight = this.MyConvTo(h);
				this.mylastdrawtextwidth = this.MyConvTo(w);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00007E0A File Offset: 0x0000600A
		public void PrintSimpleReport(string csfilename, SimpleReport sp)
		{
			this.PrintSimpleReport(csfilename, sp, "");
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000BE05C File Offset: 0x000BC25C
		public void PrintSimpleReport(string csfilename, SimpleReport sp, string defaultschemename)
		{
			if (sp != null)
			{
				sp.IsOnlyGetReportString = true;
				string reportstring;
				if (MyProject.Computer.FileSystem.FileExists(csfilename))
				{
					reportstring = MyProject.Computer.FileSystem.ReadAllText(csfilename);
				}
				else
				{
					reportstring = "";
				}
				sp.Print2(ref reportstring, false, false, false, defaultschemename);
				this.AddReportByString(reportstring);
				reportstring = null;
				sp.IsOnlyGetReportString = false;
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00007E19 File Offset: 0x00006019
		public void PrintSimpleReport2(string cs, SimpleReport sp)
		{
			this.PrintSimpleReport2(cs, sp, "");
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00007E28 File Offset: 0x00006028
		public void PrintSimpleReport2(string cs, SimpleReport sp, string defaultschemename)
		{
			if (sp != null)
			{
				sp.IsOnlyGetReportString = true;
				sp.Print2(ref cs, false, false, false, defaultschemename);
				this.AddReportByString(cs);
				sp.IsOnlyGetReportString = false;
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000BE0BC File Offset: 0x000BC2BC
		public void PrintEasyReport(EasyReport myrep)
		{
			bool isShowProgess = myrep.IsShowProgess;
			myrep.IsShowProgess = false;
			string reportString = myrep.GetReportString(false);
			this.AddReportByString(reportString);
			myrep.IsShowProgess = isShowProgess;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		public void PrintEasyReport(EasyReport myrep, bool isTD)
		{
			bool isShowProgess = myrep.IsShowProgess;
			myrep.IsShowProgess = false;
			string reportString = myrep.GetReportString(isTD);
			this.AddReportByString(reportString);
			myrep.IsShowProgess = isShowProgess;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000BE124 File Offset: 0x000BC324
		private void ToolStripMenuItem_16_Click(object sender, EventArgs e)
		{
			PrintZoomSet printZoomSet = new PrintZoomSet();
			printZoomSet.NumericUpDown1.Value = new decimal(this.PageScale * 100f);
			if (printZoomSet.ShowDialog(this) == DialogResult.OK)
			{
				this.PageScale = Convert.ToSingle(Math.Round(decimal.Divide(printZoomSet.NumericUpDown1.Value, 100m), 2));
			}
			printZoomSet.Dispose();
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00007E4E File Offset: 0x0000604E
		private void ToolStripMenuItem16_Click_1(object sender, EventArgs e)
		{
			this.Print(true, true);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00007E58 File Offset: 0x00006058
		private void dy5_Click(object sender, EventArgs e)
		{
			this.Print(1, this.GetPages(), 1, true);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x000BE194 File Offset: 0x000BC394
		private void ToolStripMenuItem_17_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveAsImage(this.GetCurrentPage(), ""))
			{
				Interaction.MsgBox("保存成功", MsgBoxStyle.OkOnly, "提示信息");
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x000BE1E4 File Offset: 0x000BC3E4
		public bool SaveAsImage(int pagenumber, string filename)
		{
			checked
			{
				bool result;
				if (pagenumber <= 0 | pagenumber > this.GetPages())
				{
					result = false;
				}
				else
				{
					if (Operators.CompareString(filename, "", false) == 0)
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog();
						saveFileDialog.Title = "请选择要保存的图像文件名";
						saveFileDialog.Filter = "png图片文件(*.png)|*.png|jpg图片文件(*.jpg)|*.jpg|bmp图片文件(*.bmp)|*.bmp|Tiff图片文件(*.tiff)|*.tiff|Gif图片文件(*.gif)|*.gif|wmf文件(*.wmf)|*.wmf|emf文件(*.emf)|*.emf";
						saveFileDialog.DefaultExt = "png";
						saveFileDialog.FileName = Strings.Format(DateAndTime.Today, "yyyy-M-dd");
						if (saveFileDialog.ShowDialog() != DialogResult.OK)
						{
							saveFileDialog.Dispose();
							return false;
						}
						filename = saveFileDialog.FileName;
						saveFileDialog.Dispose();
					}
					Type typeFromHandle = typeof(PrintPreviewControl);
					this.m_mypageinfo = typeFromHandle.GetField("pageInfo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
					PreviewPageInfo[] array = (PreviewPageInfo[])this.m_mypageinfo.GetValue(this.PrintPreviewControl1);
					string left = Strings.UCase(Path.GetExtension(filename));
					if (Operators.CompareString(left, ".JPEG", false) != 0)
					{
						if (Operators.CompareString(left, ".JPG", false) != 0)
						{
							if (Operators.CompareString(left, ".BMP", false) != 0)
							{
								if (Operators.CompareString(left, ".GIF", false) != 0)
								{
									if (Operators.CompareString(left, ".TIFF", false) == 0)
									{
										array[pagenumber - 1].Image.Save(filename, ImageFormat.Tiff);
										goto IL_2AC;
									}
									if (Operators.CompareString(left, ".WMF", false) == 0)
									{
										array[pagenumber - 1].Image.Save(filename, ImageFormat.Wmf);
										goto IL_2AC;
									}
									if (Operators.CompareString(left, ".EMF", false) == 0)
									{
										array[pagenumber - 1].Image.Save(filename, ImageFormat.Emf);
										goto IL_2AC;
									}
									array[pagenumber - 1].Image.Save(filename, ImageFormat.Png);
									goto IL_2AC;
								}
							}
						}
					}
					Bitmap bitmap = new Bitmap(array[pagenumber - 1].Image.Width, array[pagenumber - 1].Image.Height);
					Graphics graphics = Graphics.FromImage(bitmap);
					graphics.Clear(Color.White);
					graphics.DrawImage(array[pagenumber - 1].Image, 0, 0, bitmap.Width, bitmap.Height);
					string left2 = Strings.UCase(Path.GetExtension(filename));
					if (Operators.CompareString(left2, ".JPEG", false) != 0)
					{
						if (Operators.CompareString(left2, ".JPG", false) != 0)
						{
							if (Operators.CompareString(left2, ".BMP", false) == 0)
							{
								bitmap.Save(filename, ImageFormat.Bmp);
								goto IL_298;
							}
							if (Operators.CompareString(left2, ".GIF", false) == 0)
							{
								bitmap.Save(filename, ImageFormat.Gif);
								goto IL_298;
							}
							goto IL_298;
						}
					}
					bitmap.Save(filename, ImageFormat.Jpeg);
				IL_298:
					graphics.Dispose();
					bitmap.Dispose();
				IL_2AC:
					this.m_mypageinfo = null;
					result = true;
				}
				return result;
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		public MemoryStream SaveAsMemoryStream(int pagenumber)
		{
			MemoryStream result;
			if (pagenumber <= 0 | pagenumber > this.GetPages())
			{
				result = null;
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream();
				Type typeFromHandle = typeof(PrintPreviewControl);
				this.m_mypageinfo = typeFromHandle.GetField("pageInfo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
				PreviewPageInfo[] array = (PreviewPageInfo[])this.m_mypageinfo.GetValue(this.PrintPreviewControl1);
				array[checked(pagenumber - 1)].Image.Save(memoryStream, ImageFormat.Png);
				this.m_mypageinfo = null;
				result = memoryStream;
			}
			return result;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000BE530 File Offset: 0x000BC730
		public Image SaveAsImage(int pagenumber)
		{
			Image result;
			if (pagenumber <= 0 | pagenumber > this.GetPages())
			{
				result = null;
			}
			else
			{
				MemoryStream stream = this.SaveAsMemoryStream(pagenumber);
				result = Image.FromStream(stream);
			}
			return result;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000BE564 File Offset: 0x000BC764
		public bool SaveAsImage(string filepath)
		{
			checked
			{
				bool result;
				if (this.GetPages() <= 0)
				{
					result = false;
				}
				else
				{
					if (Operators.CompareString(filepath, "", false) == 0)
					{
						FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
						folderBrowserDialog.Description = "请选择要保存的文件夹";
						folderBrowserDialog.SelectedPath = "";
						if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
						{
							return false;
						}
						filepath = folderBrowserDialog.SelectedPath;
					}
					progressexcel progressexcel = new progressexcel();
					Module1.G_CancelExportDGVToExcel = false;
					progressexcel.Text = "保存为图像文件";
					progressexcel.ProgressBar1.Value = 0;
					progressexcel.ProgressBar1.Maximum = this.GetPages();
					progressexcel.Show(this.ParentForm);
					int num = 0;
					int num2 = this.GetPages() - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Module1.G_CancelExportDGVToExcel)
						{
							progressexcel.Dispose();
							return false;
						}
						progressexcel.Label1.Text = string.Concat(new string[]
						{
							"正在保存第〖",
							Conversions.ToString(i + 1),
							"〗页，共〖",
							Conversions.ToString(this.GetPages()),
							"〗页，已完成〖",
							Strings.Format((double)i / (double)this.GetPages(), "###.##%"),
							"〗"
						});
						Application.DoEvents();
						progressexcel.ProgressBar1.Value = i;
						this.SaveAsImage(i + 1, MyProject.Computer.FileSystem.CombinePath(filepath, "第" + Conversions.ToString(i + 1) + "页.png"));
					}
					progressexcel.Label1.Text = "保存完成";
					progressexcel.ProgressBar1.Value = this.GetPages();
					progressexcel.Dispose();
					result = true;
				}
				return result;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000BE720 File Offset: 0x000BC920
		public void DrawPictureBox(PictureBox pb, float x, float y)
		{
			if (!this.CancelDocument && pb != null)
			{
				Bitmap bitmap = new Bitmap(pb.Width, pb.Height);
				Bitmap bitmap2 = bitmap;
				Rectangle targetBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
				pb.DrawToBitmap(bitmap2, targetBounds);
				this.DrawImage(bitmap, x, y, this.ConvFromDisplay((float)pb.Width, true), this.ConvFromDisplay((float)pb.Height, false), true, StringAlignment.Center, StringAlignment.Center);
				bitmap.Dispose();
				if (pb.BorderStyle != BorderStyle.None)
				{
					float linewidth = this.ConvFromDisplay(1f, true);
					this.DrawRect(x, y, this.ConvFromDisplay((float)pb.Width, true), this.ConvFromDisplay((float)pb.Height, false), Color.Black, linewidth);
				}
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00007E69 File Offset: 0x00006069
		private void ToolStripMenuItem_18_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveAsImage(""))
			{
				Interaction.MsgBox("保存成功", MsgBoxStyle.OkOnly, "提示信息");
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00007EA5 File Offset: 0x000060A5
		private void saveaspdfcur_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveAsPdf("", true))
			{
				Interaction.MsgBox("保存成功", MsgBoxStyle.OkOnly, "提示信息");
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00007EE2 File Offset: 0x000060E2
		private void saveaspdfall_Click(object sender, EventArgs e)
		{
			if (this.GetPages() <= 0)
			{
				Interaction.MsgBox("不能保存，原因是当前打印作业是空的", MsgBoxStyle.OkOnly, "提示信息");
			}
			else if (this.SaveAsPdf("", false))
			{
				Interaction.MsgBox("保存成功", MsgBoxStyle.OkOnly, "提示信息");
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000BE7E0 File Offset: 0x000BC9E0
	

		// Token: 0x06001642 RID: 5698 RVA: 0x000BEA50 File Offset: 0x000BCC50
		

		// Token: 0x06001643 RID: 5699 RVA: 0x000BEC24 File Offset: 0x000BCE24
		private void mysave_DropDownOpening(object sender, EventArgs e)
		{
			this.saveaspdfcur.Enabled = true;
			this.ToolStripMenuItem_17.Enabled = true;
			this.saveaspdfall.Enabled = true;
			this.ToolStripMenuItem_18.Enabled = true;
			if (!this.myenablesaveaspdf)
			{
				this.saveaspdfcur.Enabled = false;
				this.saveaspdfall.Enabled = false;
			}
			if (!this.myenablesaveasimage)
			{
				this.ToolStripMenuItem_17.Enabled = false;
				this.ToolStripMenuItem_18.Enabled = false;
			}
			if (this.mytype1.Checked | !this.ToolStripMenuItem_7.Checked)
			{
				this.saveaspdfcur.Enabled = false;
				this.ToolStripMenuItem_17.Enabled = false;
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000BECD8 File Offset: 0x000BCED8
		public int GetPdfPages(string pdffile)
		{
			int result;
			if (!MyProject.Computer.FileSystem.FileExists(pdffile))
			{
				result = 0;
			}
			else
			{
				Assembly assembly;
				try
				{
					assembly = Assembly.LoadFrom(Application.StartupPath + "\\O2S.Components.PDFRender4NET.dll");
				}
				catch (Exception ex)
				{
					result = 0;
					return 0;
				}
				Type type = assembly.GetType("O2S.Components.PDFRender4NET.PDFFile");
				MethodInfo method = type.GetMethod("Open", new Type[]
				{
					Type.GetType("System.String")
				});
				if (method != null)
				{
					string[] parameters = new string[]
					{
						pdffile
					};
					object obj;
					try
					{
						obj = RuntimeHelpers.GetObjectValue(method.Invoke(null, parameters));
					}
					catch (Exception ex2)
					{
						result = 0;
						obj = null;
						return result;
					}
					PropertyInfo property = type.GetProperty("PageCount");
					int num = Conversions.ToInteger(property.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
					result = num;
					obj = null;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x000BEDE0 File Offset: 0x000BCFE0
		public Image ConvertPdfToImage(string pdffile, int PageNum)
		{
			Image result;
			if (!MyProject.Computer.FileSystem.FileExists(pdffile))
			{
				result = null;
			}
			else
			{
				Assembly assembly;
				try
				{
					assembly = Assembly.LoadFrom(Application.StartupPath + "\\O2S.Components.PDFRender4NET.dll");
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("错误，无法加载转换PDF格式文件为图片的动态连接库文件【O2S.Components.PDFRender4NET.dll】，请确保该文件与DotNetPrint.dll文件处于同一文件夹下。", MsgBoxStyle.OkOnly, "提示信息");
					return null;
				}
				Type type = assembly.GetType("O2S.Components.PDFRender4NET.PDFFile");
				MethodInfo method = type.GetMethod("Open", new Type[]
				{
					Type.GetType("System.String")
				});
				if (method != null)
				{
					string[] parameters = new string[]
					{
						pdffile
					};
					object obj;
					try
					{
						obj = RuntimeHelpers.GetObjectValue(method.Invoke(null, parameters));
					}
					catch (Exception ex2)
					{
						result = null;
						obj = null;
						return result;
					}
					if (PageNum <= 0)
					{
						PageNum = 1;
					}
					PropertyInfo property = type.GetProperty("PageCount");
					int num = Conversions.ToInteger(property.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
					if (PageNum > num)
					{
						result = null;
					}
					else
					{
						method = type.GetMethod("GetPageImage", new Type[]
						{
							Type.GetType("System.Int32"),
							Type.GetType("System.Single")
						});
						object[] array = new object[2];
						Bitmap bitmap = null;
						try
						{
							array[0] = checked(PageNum - 1);
							array[1] = 560;
							bitmap = (Bitmap)method.Invoke(RuntimeHelpers.GetObjectValue(obj), array);
						}
						catch (Exception ex3)
						{
							result = null;
							Interaction.MsgBox("PDF文件转换为图片失败，可能是不识别的PDF文件格式，或者PDF文件有密码或进行了加密", MsgBoxStyle.OkOnly, "提示信息");
						}
						finally
						{
							obj = null;
						}
						result = bitmap;
					}
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00007F1F File Offset: 0x0000611F
		public void PrintPDF(string pdffile)
		{
			this.PrintPDF(pdffile, 1, 0);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000BEFB8 File Offset: 0x000BD1B8
		public void PrintPDF(string pdffile, int frompage, int topage)
		{
			checked
			{
				if (MyProject.Computer.FileSystem.FileExists(pdffile))
				{
					int pdfPages = this.GetPdfPages(pdffile);
					if (pdfPages > 0)
					{
						if (frompage <= 0)
						{
							frompage = 1;
						}
						if (topage > pdfPages)
						{
							topage = pdfPages;
						}
						if (topage <= 0)
						{
							topage = pdfPages;
						}
						if (frompage <= topage)
						{
							int num = frompage;
							int num2 = topage;
							for (int i = num; i <= num2; i++)
							{
								Image image = this.ConvertPdfToImage(pdffile, i);
								if (image.Width > image.Height)
								{
									this.MyNewPage(true);
								}
								else
								{
									this.MyNewPage(false);
								}
								this.DrawImage(image, (float)(0 - this.PaperMargins.Left), (float)(0 - this.PaperMargins.Top), this.PaperWidth, this.PaperHeight, true, StringAlignment.Center, StringAlignment.Center);
								image.Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00007F2A File Offset: 0x0000612A
		private void cgprint_Click(object sender, EventArgs e)
		{
			this.PrintDraft();
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000BF074 File Offset: 0x000BD274
		public void PrintDraft()
		{
			int num = this.GetPages();
			if (num <= 0)
			{
				Module1.MyMsgBox("没有可打印内容，不能打印。");
			}
			else
			{
				if (this.g_pp == null)
				{
					this.g_pp = new draftset();
					this.g_pp.fx.Text = "纵向";
				}
				this.g_pp.RadioButton5.Checked = true;
				this.g_pp.RadioButton6.Checked = false;
				this.g_pp.fpage.Enabled = false;
				this.g_pp.tpage.Enabled = false;
				this.g_pp.fpage.Maximum = new decimal(this.GetPages());
				this.g_pp.tpage.Maximum = new decimal(this.GetPages());
				this.g_pp.fpage.Value = 1m;
				this.g_pp.tpage.Value = new decimal(this.GetPages());
				DialogResult dialogResult = this.g_pp.ShowDialog(this);
				int num2;
				if (this.g_pp.RadioButton1.Checked)
				{
					num2 = 1;
				}
				else if (this.g_pp.RadioButton2.Checked)
				{
					num2 = 2;
				}
				else if (this.g_pp.RadioButton3.Checked)
				{
					num2 = 3;
				}
				else if (this.g_pp.RadioButton4.Checked)
				{
					num2 = 4;
				}
				else
				{
					num2 = 1;
				}
				int frompage;
				int topage;
				if (this.g_pp.RadioButton5.Checked)
				{
					frompage = 1;
					topage = this.GetPages();
				}
				else
				{
					frompage = Convert.ToInt32(this.g_pp.fpage.Value);
					topage = Convert.ToInt32(this.g_pp.tpage.Value);
				}
				bool fx = Operators.CompareString(Conversions.ToString(this.g_pp.fx.SelectedItem), "横向", false) == 0;
				PaperSize paperSize;
				if (this.g_pp.paperkind > PaperKind.Custom)
				{
					paperSize = definepaper.GetPrintForm(Conversions.ToString(this.g_pp.printername.SelectedItem), this.g_pp.paperkind);
				}
				else if (decimal.Compare(this.g_pp.mypaperwidth, 0m) > 0 & decimal.Compare(this.g_pp.mypaperheight, 0m) > 0)
				{
					paperSize = null;
				}
				else
				{
					paperSize = definepaper.GetPrintForm(Conversions.ToString(this.g_pp.printername.SelectedItem), this.g_pp.papername);
				}
				PaperSize paper;
				if (paperSize == null)
				{
					if (Operators.CompareString(Strings.Trim(this.g_pp.papername), "", false) == 0)
					{
						this.g_pp.papername = "[自定义纸张]";
					}
					paper = checked(new PaperSize(this.g_pp.papername, (int)Math.Round((double)this.ConvertCmToInch(Convert.ToSingle(decimal.Divide(decimal.Multiply(this.g_pp.mypaperwidth, 100m), 10m)))), (int)Math.Round((double)this.ConvertCmToInch(Convert.ToSingle(decimal.Divide(decimal.Multiply(this.g_pp.mypaperheight, 100m), 10m))))));
				}
				else
				{
					paper = paperSize;
				}
				switch (dialogResult)
				{
					case DialogResult.OK:
						this.myPrintDraft(paper, fx, frompage, topage, num2, Conversions.ToString(this.g_pp.printername.SelectedItem), this.g_pp.CheckBox1.Checked, false);
						break;
					case DialogResult.Yes:
						this.myPrintDraft(paper, fx, frompage, topage, num2, Conversions.ToString(this.g_pp.printername.SelectedItem), this.g_pp.CheckBox1.Checked, true);
						break;
				}
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000BF440 File Offset: 0x000BD640
		public void PrintDraft(PaperSize paper, bool fx, int frompage, int topage, int pages, string printername, bool drawline)
		{
			this.myPrintDraft(paper, fx, frompage, topage, pages, printername, drawline, false);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000BF460 File Offset: 0x000BD660
		private void myPrintDraft(PaperSize paper, bool fx, int frompage, int topage, int pages, string printername, bool drawline, bool ispreview)
		{
			int num = this.GetPages();
			checked
			{
				if (num <= 0)
				{
					Module1.MyMsgBox("没有可打印内容，不能打印。");
				}
				else
				{
					if (frompage <= 0)
					{
						frompage = 1;
					}
					if (topage <= 0)
					{
						topage = this.GetPages();
					}
					if (topage >= frompage)
					{
						VB2008Print vb2008Print = new VB2008Print();
						vb2008Print.EnablePrintDraft = false;
						vb2008Print.SetCurrentPrinterName(printername);
						vb2008Print.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
						vb2008Print.PaperLandscape = fx;
						vb2008Print.PaperSize = paper;
						vb2008Print.PaperMargins = new Margins(0, 0, 0, 0);
						vb2008Print.IsShowProgess = true;
						if (ispreview)
						{
							vb2008Print.IsImmediatePrintNotPreview = false;
						}
						else
						{
							vb2008Print.IsImmediatePrintNotPreview = true;
						}
						vb2008Print.IsImmediatePrintNotPreviewShowPrintDialog = false;
						vb2008Print.IsShowMessageIfPrinterNotSupportPaper = this.IsShowMessageIfPrinterNotSupportPaper;
						vb2008Print.DocumentName = this.DocumentName;
						vb2008Print.IsDrawmargin = false;
						vb2008Print.EnabledPrint = this.EnabledPrint;
						vb2008Print.IsShowContextMenu = this.IsShowContextMenu;
						vb2008Print.IsShowPrintStatusDialog = this.IsShowPrintStatusDialog;
						vb2008Print.IsUseAPIprintDialog = this.IsUseAPIprintDialog;
						vb2008Print.IsShowProgess = this.IsShowProgess;
						vb2008Print.BackColor = this.BackColor;
						vb2008Print.ForeColor = this.ForeColor;
						vb2008Print.EnableSaveAsImage = this.EnableSaveAsImage;
						vb2008Print.EnableSaveAsPDF = this.EnableSaveAsPDF;
						vb2008Print.IsAutoAdjustPrinterMargin = this.IsAutoAdjustPrinterMargin;
						vb2008Print.CanOpenReport = false;
						vb2008Print.NewDoc();
						bool flag = vb2008Print.PaperHeight >= vb2008Print.PaperWidth;
						switch (pages)
						{
							case 1:
								{
									int num2 = frompage;
									int num3 = topage;
									for (int i = num2; i <= num3; i++)
									{
										Image image = this.SaveAsImage(i);
										vb2008Print.NewPage();
										VB2008Print vb2008Print2 = vb2008Print;
										Image myimage = image;
										RectangleF myrectf = new RectangleF(0f, 0f, vb2008Print.PaperWidth, vb2008Print.PaperHeight);
										vb2008Print2.DrawImage(myimage, myrectf);
										image.Dispose();
									}
									break;
								}
							case 2:
								{
									int num4 = frompage;
									int num5 = topage;
									for (int j = num4; j <= num5; j += 2)
									{
										float num6 = 0f;
										float num7 = 0f;
										float num8;
										float num9;
										if (flag)
										{
											num8 = vb2008Print.PaperWidth;
											num9 = vb2008Print.PaperHeight / 2f;
										}
										else
										{
											num8 = vb2008Print.PaperWidth / 2f;
											num9 = vb2008Print.PaperHeight;
										}
										Image image = this.SaveAsImage(j);
										vb2008Print.NewPage();
										VB2008Print vb2008Print3 = vb2008Print;
										Image myimage2 = image;
										RectangleF myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print3.DrawImage(myimage2, myrectf);
										image.Dispose();
										if (flag)
										{
											num6 = 0f;
											num7 = vb2008Print.PaperHeight / 2f;
										}
										else
										{
											num6 = vb2008Print.PaperWidth / 2f;
											num7 = 0f;
										}
										if (drawline)
										{
											vb2008Print.DrawLine(Pens.Black, num6, num7, num8, num9);
										}
										if (j + 1 > topage)
										{
											break;
										}
										image = this.SaveAsImage(j + 1);
										VB2008Print vb2008Print4 = vb2008Print;
										Image myimage3 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print4.DrawImage(myimage3, myrectf);
										image.Dispose();
									}
									break;
								}
							case 3:
								{
									int num10 = frompage;
									int num11 = topage;
									for (int k = num10; k <= num11; k += 3)
									{
										float num6 = 0f;
										float num7 = 0f;
										float num8;
										float num9;
										if (flag)
										{
											num8 = vb2008Print.PaperWidth;
											num9 = vb2008Print.PaperHeight / 3f;
										}
										else
										{
											num8 = vb2008Print.PaperWidth / 3f;
											num9 = vb2008Print.PaperHeight;
										}
										Image image = this.SaveAsImage(k);
										vb2008Print.NewPage();
										VB2008Print vb2008Print5 = vb2008Print;
										Image myimage4 = image;
										RectangleF myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print5.DrawImage(myimage4, myrectf);
										image.Dispose();
										if (flag)
										{
											num6 = 0f;
											num7 = vb2008Print.PaperHeight / 3f;
										}
										else
										{
											num6 = vb2008Print.PaperWidth / 3f;
											num7 = 0f;
										}
										if (drawline)
										{
											vb2008Print.DrawLine(Pens.Black, num6, num7, num8, num9);
										}
										if (k + 1 > topage)
										{
											break;
										}
										image = this.SaveAsImage(k + 1);
										VB2008Print vb2008Print6 = vb2008Print;
										Image myimage5 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print6.DrawImage(myimage5, myrectf);
										image.Dispose();
										unchecked
										{
											if (flag)
											{
												num6 = 0f;
												num7 = vb2008Print.PaperHeight / 3f * 2f;
											}
											else
											{
												num6 = vb2008Print.PaperWidth / 3f * 2f;
												num7 = 0f;
											}
											if (drawline)
											{
												vb2008Print.DrawLine(Pens.Black, num6, num7, num8 * 2f, num9 * 2f);
											}
										}
										if (k + 2 > topage)
										{
											break;
										}
										image = this.SaveAsImage(k + 2);
										VB2008Print vb2008Print7 = vb2008Print;
										Image myimage6 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print7.DrawImage(myimage6, myrectf);
										image.Dispose();
									}
									break;
								}
							case 4:
								{
									int num12 = frompage;
									int num13 = topage;
									for (int l = num12; l <= num13; l += 4)
									{
										float num6 = 0f;
										float num7 = 0f;
										float num8 = vb2008Print.PaperWidth / 2f;
										float num9 = vb2008Print.PaperHeight / 2f;
										Image image = this.SaveAsImage(l);
										vb2008Print.NewPage();
										VB2008Print vb2008Print8 = vb2008Print;
										Image myimage7 = image;
										RectangleF myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print8.DrawImage(myimage7, myrectf);
										image.Dispose();
										num6 = vb2008Print.PaperWidth / 2f;
										num7 = 0f;
										if (drawline)
										{
											vb2008Print.DrawLine(Pens.Black, num6, num7, num8, num9);
											vb2008Print.DrawLine(Pens.Black, 0f, num9, num8, num9);
										}
										if (l + 1 > topage)
										{
											break;
										}
										image = this.SaveAsImage(l + 1);
										VB2008Print vb2008Print9 = vb2008Print;
										Image myimage8 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print9.DrawImage(myimage8, myrectf);
										image.Dispose();
										if (drawline)
										{
											vb2008Print.DrawLine(Pens.Black, num8, num9, unchecked(num8 * 2f), num9);
										}
										num6 = 0f;
										num7 = vb2008Print.PaperHeight / 2f;
										if (l + 2 > topage)
										{
											break;
										}
										image = this.SaveAsImage(l + 2);
										VB2008Print vb2008Print10 = vb2008Print;
										Image myimage9 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print10.DrawImage(myimage9, myrectf);
										image.Dispose();
										num6 = num8;
										num7 = num9;
										if (drawline)
										{
											vb2008Print.DrawLine(Pens.Black, num6, num7, num8, unchecked(num9 * 2f));
										}
										if (l + 3 > topage)
										{
											break;
										}
										image = this.SaveAsImage(l + 3);
										VB2008Print vb2008Print11 = vb2008Print;
										Image myimage10 = image;
										myrectf = new RectangleF(num6, num7, num8, num9);
										vb2008Print11.DrawImage(myimage10, myrectf);
										image.Dispose();
									}
									break;
								}
						}
						if (ispreview)
						{
							vb2008Print.EndDoc("草稿打印预览");
						}
						else
						{
							vb2008Print.EndDoc();
						}
						vb2008Print.Dispose();
					}
				}
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000BFAF0 File Offset: 0x000BDCF0
		public void DrawShape(LcdDigital sp, float x, float y, float width, float height)
		{
			string t = sp.SaveAsString();
			this.TranslateTransform(x + (float)this.PaperMargins.Left, y + (float)this.PaperMargins.Top);
			this.MyWrite("shape", "LcdDigital", t, Conversions.ToString(this.MyConvTo(width)), Conversions.ToString(this.MyConvTo(height)));
			this.ResetTransform();
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000BFB58 File Offset: 0x000BDD58
		private void MyDrawShape(string thename, string ss, float width, float height)
		{
			Shape shape = null;
			if (Operators.CompareString(thename, "LcdDigital", false) == 0)
			{
				shape = new LcdDigital();
			}
			checked
			{
				if (shape != null)
				{
					shape.RestoreFromString(ss);
					shape.Draw(this.myg, (int)Math.Round((double)width), (int)Math.Round((double)height));
				}
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00007F32 File Offset: 0x00006132
		public void PrintXml(string xmlfilename)
		{
			this.PrintXml(xmlfilename, null, null);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000BFBA8 File Offset: 0x000BDDA8
		public void PrintXml(string xmlfilename, Hashtable hashablecs, Hashtable dgvhashtable)
		{
			xmlfilename = Path.GetFullPath(xmlfilename);
			if (File.Exists(xmlfilename))
			{
				XmlNode xmlNode = XmlParserBase.SelectRootNode(xmlfilename);
				if (xmlNode == null)
				{
					Module1.MyMsgBox("文件【" + xmlfilename + "】不是有效的XML文件");
				}
				else
				{
					this.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
					XmlPageSetup xmlPageSetup = new XmlPageSetup(xmlNode);
					xmlPageSetup.Parse();
					float num;
					if (Operators.CompareString(xmlPageSetup.PageWidth, "", false) == 0)
					{
						num = 0f;
					}
					else
					{
						num = float.Parse(xmlPageSetup.PageWidth);
					}
					float num2;
					if (Operators.CompareString(xmlPageSetup.PageHeight, "", false) == 0)
					{
						num2 = 0f;
					}
					else
					{
						num2 = float.Parse(xmlPageSetup.PageHeight);
					}
					if (Operators.CompareString(xmlPageSetup.PrinterName, "", false) != 0)
					{
						this.SetCurrentPrinterName(xmlPageSetup.PrinterName);
					}
					string text = xmlPageSetup.PaperName;
					if (Operators.CompareString(text, "", false) == 0 & num2 == 0f & num == 0f)
					{
						text = "A4";
					}
					else if (Operators.CompareString(text, "", false) == 0)
					{
						text = "[自定义纸张]";
					}
					if (Operators.CompareString(xmlPageSetup.DocumentName, "", false) != 0)
					{
						this.DocumentName = xmlPageSetup.DocumentName;
					}
					else
					{
						this.DocumentName = xmlfilename;
					}
					this.PaperSize = checked(new PaperSize(text, (int)Math.Round((double)(unchecked(this.ConvertCmToInch(num) * 10f))), (int)Math.Round((double)(unchecked(this.ConvertCmToInch(num2) * 10f)))));
					if (Operators.CompareString(xmlPageSetup.PaperLandscape.ToLower(), "true", false) == 0 | Operators.CompareString(xmlPageSetup.PaperLandscape, "1", false) == 0)
					{
						this.PaperLandscape = true;
					}
					else
					{
						this.PaperLandscape = false;
					}
					float num3;
					if (Operators.CompareString(xmlPageSetup.LeftMargin, "", false) != 0)
					{
						num3 = float.Parse(xmlPageSetup.LeftMargin) * 10f;
					}
					else
					{
						num3 = 150f;
					}
					float num4;
					if (Operators.CompareString(xmlPageSetup.RightMargin, "", false) != 0)
					{
						num4 = float.Parse(xmlPageSetup.RightMargin) * 10f;
					}
					else
					{
						num4 = 150f;
					}
					float num5;
					if (Operators.CompareString(xmlPageSetup.TopMargin, "", false) != 0)
					{
						num5 = float.Parse(xmlPageSetup.TopMargin) * 10f;
					}
					else
					{
						num5 = 150f;
					}
					float num6;
					if (Operators.CompareString(xmlPageSetup.BottomMargin, "", false) != 0)
					{
						num6 = float.Parse(xmlPageSetup.BottomMargin) * 10f;
					}
					else
					{
						num6 = 150f;
					}
					this.PaperMargins = checked(new Margins((int)Math.Round((double)num3), (int)Math.Round((double)num4), (int)Math.Round((double)num5), (int)Math.Round((double)num6)));
					this.NewDoc();
					this.DrawXmlElements(xmlNode, hashablecs, dgvhashtable);
					this.EndDoc();
				}
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000BFE60 File Offset: 0x000BE060
		private void DrawXmlElements(XmlNode elementsNode, Hashtable hashablecs, Hashtable dgvhashtable)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			Color mycolor = Color.Black;
			Font myf = null;
			string text4 = "";
			string text5 = "";
			string text6 = "";
			Color mycolor2 = Color.Black;
			Font myf2 = null;
			try
			{
				foreach (object obj in elementsNode)
				{
					XmlNode xmlNode = (XmlNode)obj;
					string text7 = xmlNode.Name.ToLower();
					string left = text7;
					if (Operators.CompareString(left, "page", false) == 0)
					{
						this.xmlDrawNewpage(xmlNode);
					}
					else if (Operators.CompareString(left, "rectangle", false) == 0)
					{
						this.xmlDrawRectangle(xmlNode);
					}
					else if (Operators.CompareString(left, "pageheader", false) == 0)
					{
						XmlPageHeaderAndFooter xmlPageHeaderAndFooter = new XmlPageHeaderAndFooter(xmlNode);
						xmlPageHeaderAndFooter.Parse();
						myf = (Font)xmlPageHeaderAndFooter.TextFormat.GetFont().Clone();
						text = xmlPageHeaderAndFooter.LeftText;
						text3 = xmlPageHeaderAndFooter.MiddleText;
						text2 = xmlPageHeaderAndFooter.RightText;
						if (Operators.CompareString(xmlPageHeaderAndFooter.TextFormat.ForeColor, "", false) != 0)
						{
							mycolor = XmlParserBase.GetColorFrom(xmlPageHeaderAndFooter.TextFormat.ForeColor);
						}
					}
					else if (Operators.CompareString(left, "pagefooter", false) == 0)
					{
						XmlPageHeaderAndFooter xmlPageHeaderAndFooter2 = new XmlPageHeaderAndFooter(xmlNode);
						xmlPageHeaderAndFooter2.Parse();
						myf2 = (Font)xmlPageHeaderAndFooter2.TextFormat.GetFont().Clone();
						text4 = xmlPageHeaderAndFooter2.LeftText;
						text6 = xmlPageHeaderAndFooter2.MiddleText;
						text5 = xmlPageHeaderAndFooter2.RightText;
						if (Operators.CompareString(xmlPageHeaderAndFooter2.TextFormat.ForeColor, "", false) != 0)
						{
							mycolor2 = XmlParserBase.GetColorFrom(xmlPageHeaderAndFooter2.TextFormat.ForeColor);
						}
					}
					else if (Operators.CompareString(left, "dot", false) == 0)
					{
						this.xmlDrawDot(xmlNode);
					}
					else if (Operators.CompareString(left, "line", false) == 0)
					{
						this.xmlDrawLine(xmlNode);
					}
					else if (Operators.CompareString(left, "ellipse", false) == 0)
					{
						this.xmlDrawellipse(xmlNode);
					}
					else if (Operators.CompareString(left, "circle", false) == 0)
					{
						this.xmlDrawCircle(xmlNode);
					}
					else if (Operators.CompareString(left, "text", false) == 0)
					{
						this.xmlDraweText(xmlNode, hashablecs, dgvhashtable);
					}
					else if (Operators.CompareString(left, "textex", false) == 0)
					{
						this.xmlDraweTextEx(xmlNode, hashablecs, dgvhashtable);
					}
					else if (Operators.CompareString(left, "table", false) == 0)
					{
						XmlTable xmlTable = new XmlTable(xmlNode);
						xmlTable.Parse();
						xmlTable.GetDataTable();
					}
					else if (Operators.CompareString(left, "cell", false) == 0)
					{
						this.xmlDrawCell(xmlNode, hashablecs, dgvhashtable);
					}
					else if (Operators.CompareString(left, "embedtable", false) == 0)
					{
						this.xmlDraweEmbedTable(xmlNode, hashablecs, dgvhashtable);
					}
					else
					{
						if (Operators.CompareString(left, "datatext", false) == 0)
						{
							break;
						}
						if (Operators.CompareString(left, "ellipsetextbox", false) == 0)
						{
							break;
						}
						if (Operators.CompareString(left, "cylinder", false) == 0)
						{
							break;
						}
						if (Operators.CompareString(left, "table", false) == 0)
						{
							break;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			checked
			{
				if (Operators.CompareString(text, "", false) != 0 | Operators.CompareString(text3, "", false) != 0 | Operators.CompareString(text2, "", false) != 0 | Operators.CompareString(text4, "", false) != 0 | Operators.CompareString(text6, "", false) != 0 | Operators.CompareString(text5, "", false) != 0)
				{
					int num = 1;
					int num2 = this.GetPages();
					for (int i = num; i <= num2; i++)
					{
						this.SetCurrentPage(i);
						string myleft = this.myxmlreplace(text, hashablecs, dgvhashtable);
						string mymiddle = this.myxmlreplace(text3, hashablecs, dgvhashtable);
						string myright = this.myxmlreplace(text2, hashablecs, dgvhashtable);
						string myleft2 = this.myxmlreplace(text4, hashablecs, dgvhashtable);
						string mymiddle2 = this.myxmlreplace(text6, hashablecs, dgvhashtable);
						string myright2 = this.myxmlreplace(text5, hashablecs, dgvhashtable);
						this.PrintHeader(myleft, mymiddle, myright, myf, mycolor, 0);
						this.PrintFooter(myleft2, mymiddle2, myright2, myf2, mycolor2, 0);
					}
				}
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000C02C8 File Offset: 0x000BE4C8
		private string myxmlreplace(string mytxtvalue, Hashtable myhas, Hashtable dgvhastable)
		{
			string result;
			if (mytxtvalue == null)
			{
				result = "";
			}
			else if (mytxtvalue.IndexOf("[") < 0 | mytxtvalue.IndexOf("]") < 0)
			{
				result = mytxtvalue;
			}
			else
			{
				DictionaryEntry dictionaryEntry2;
				if (dgvhastable != null && dgvhastable.Count > 0)
				{
					try
					{
						foreach (object obj in dgvhastable)
						{
							DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
							if (dictionaryEntry.Value is DataGridView && ((DataGridView)dictionaryEntry.Value).RowCount > 0)
							{
								mytxtvalue = Conversions.ToString(this.MyxmlReplace2(mytxtvalue, Conversions.ToString(dictionaryEntry.Key), (DataGridView)dictionaryEntry.Value, 0));
							}
						}
					}
					catch (Exception ex)
					{
					}
				}
				if (myhas != null && myhas.Count > 0)
				{
					int count = myhas.Count;
					foreach (object obj2 in myhas)
					{
						DictionaryEntry dictionaryEntry3 = (obj2 != null) ? ((DictionaryEntry)obj2) : dictionaryEntry2;
						string text = Conversions.ToString(dictionaryEntry3.Key);
						string text2 = Conversions.ToString(dictionaryEntry3.Value);
						if (text2 != null)
						{
							text = "[" + text + "]";
							mytxtvalue = Strings.Replace(mytxtvalue, text, text2, 1, -1, CompareMethod.Binary);
						}
					}
				}
				mytxtvalue = Strings.Replace(mytxtvalue, "[总页数]", Conversions.ToString(this.GetPages()), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[页码]", Conversions.ToString(this.GetCurrentPage()), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期]", Strings.Format(DateAndTime.Today, "yyyy-M-d"), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期2]", Strings.Format(DateAndTime.Today, "yyyy年M月d日"), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前年]", Conversions.ToString(DateAndTime.Today.Year), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前月]", Conversions.ToString(DateAndTime.Today.Month), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前日]", Conversions.ToString(DateAndTime.Today.Day), 1, -1, CompareMethod.Binary);
				mytxtvalue = Strings.Replace(mytxtvalue, "[当前时间]", Strings.Format(DateAndTime.Now, "H:m:s"), 1, -1, CompareMethod.Binary);
				result = mytxtvalue;
			}
			return result;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000C0544 File Offset: 0x000BE744
		private object MyxmlReplace2(string mytxtvalue, string dgvname, DataGridView dgv, int currow)
		{
			checked
			{
				object result;
				if (mytxtvalue == null)
				{
					result = "";
				}
				else if (mytxtvalue.IndexOf("[") < 0 | mytxtvalue.IndexOf("]") < 0)
				{
					result = mytxtvalue;
				}
				else
				{
					int columnCount = dgv.ColumnCount;
					try
					{
						if (currow >= 0 & currow < dgv.RowCount)
						{
							int num = 0;
							int num2 = columnCount - 1;
							for (int i = num; i <= num2; i++)
							{
								string name = dgv.Columns[i].Name;
								if (Strings.InStr(mytxtvalue, "[" + name + "]", CompareMethod.Binary) > 0 | Strings.InStr(mytxtvalue, string.Concat(new string[]
								{
									"[",
									dgvname,
									".",
									name,
									"]"
								}), CompareMethod.Binary) > 0)
								{
									string text;
									if (dgv.Columns[i] is DataGridViewImageColumn)
									{
										Image image;
										try
										{
											image = (Image)VB2008Print.GetFieldValue(dgv, name, currow);
											goto IL_1C1;
										}
										catch (Exception ex)
										{
											image = null;
											goto IL_1C1;
										}
									IL_10E:
										text = "";
										goto IL_127;
									IL_1C1:
										if (image != null)
										{
											return image;
										}
										goto IL_10E;
									}
									else
									{
										text = Conversions.ToString(VB2008Print.GetFieldValue(dgv, name, currow));
									}
								IL_127:
									if (text != null)
									{
										try
										{
											if (Strings.InStr(mytxtvalue, "[" + name + "]", CompareMethod.Binary) > 0)
											{
												mytxtvalue = Strings.Replace(mytxtvalue, "[" + name + "]", text, 1, -1, CompareMethod.Binary);
											}
											else
											{
												mytxtvalue = Strings.Replace(mytxtvalue, string.Concat(new string[]
												{
													"[",
													dgvname,
													".",
													name,
													"]"
												}), text, 1, -1, CompareMethod.Binary);
											}
										}
										catch (Exception ex2)
										{
										}
									}
								}
							}
						}
					}
					catch (Exception ex3)
					{
					}
					result = mytxtvalue;
				}
				return result;
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000C0780 File Offset: 0x000BE980
		private static object GetFieldValue(DataGridView dgv, string cc, int currow)
		{
			object result;
			if (dgv == null)
			{
				result = null;
			}
			else if (currow >= dgv.RowCount | currow < 0)
			{
				result = null;
			}
			else if (VB2008Print.HasColumname(cc, dgv))
			{
				if (dgv.Columns[cc] is DataGridViewImageColumn)
				{
					result = dgv.Rows[currow].Cells[cc].FormattedValue;
				}
				else
				{
					result = Conversions.ToString(dgv.Rows[currow].Cells[cc].Value);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000C0810 File Offset: 0x000BEA10
		private static bool HasColumname(string columnname, DataGridView dgv)
		{
			checked
			{
				bool result;
				if (dgv == null)
				{
					result = false;
				}
				else
				{
					try
					{
						int num = 0;
						int num2 = dgv.ColumnCount - 1;
						for (int i = num; i <= num2; i++)
						{
							if (Operators.CompareString(Strings.Trim(columnname.ToUpper()), Strings.Trim(dgv.Columns[i].Name.ToUpper()), false) == 0)
							{
								return true;
							}
						}
						result = false;
					}
					catch (Exception ex)
					{
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000C0894 File Offset: 0x000BEA94
		private void xmlDrawRectangle(XmlNode node)
		{
			XmlRectangle xmlRectangle = new XmlRectangle(node);
			xmlRectangle.Parse();
			float num;
			if (Operators.CompareString(xmlRectangle.X, "", false) != 0)
			{
				num = float.Parse(xmlRectangle.X) * 10f;
			}
			else
			{
				num = this.Currentx;
			}
			float num2;
			if (Operators.CompareString(xmlRectangle.Y, "", false) != 0)
			{
				num2 = float.Parse(xmlRectangle.Y) * 10f;
			}
			else
			{
				num2 = this.Currenty;
			}
			float num3 = float.Parse(xmlRectangle.Width) * 10f;
			float num4 = float.Parse(xmlRectangle.Height) * 10f;
			Color lineColor = xmlRectangle.LineColor;
			Pen mypen = new Pen(lineColor, xmlRectangle.LineWidth * 10f);
			RectangleF myrect = new RectangleF(num, num2, num3, num4);
			this.DrawRectangle(mypen, myrect);
			BorderFormat borderFormat = new BorderFormat(xmlRectangle.BorderFormat);
			float num5 = xmlRectangle.LineWidth * 10f;
			if (!borderFormat.BackColor.IsEmpty)
			{
				this.DrawFillRect(num + num5 / 2f, num2 + num5 / 2f, num3 - num5, num4 - num5, borderFormat.BackColor);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000C09C4 File Offset: 0x000BEBC4
		private void xmlDrawNewpage(XmlNode node)
		{
			XmlPageSetup xmlPageSetup = new XmlPageSetup(node);
			xmlPageSetup.Parse();
			PaperSize paperSize;
			if ((Operators.CompareString(xmlPageSetup.PageHeight, "", false) == 0 | Operators.CompareString(xmlPageSetup.PageWidth, "", false) == 0) & Operators.CompareString(xmlPageSetup.PaperName, "", false) == 0)
			{
				paperSize = null;
			}
			else
			{
				float num;
				if (Operators.CompareString(xmlPageSetup.PageWidth, "", false) == 0)
				{
					num = 0f;
				}
				else
				{
					num = float.Parse(xmlPageSetup.PageWidth);
				}
				float num2;
				if (Operators.CompareString(xmlPageSetup.PageHeight, "", false) == 0)
				{
					num2 = 0f;
				}
				else
				{
					num2 = float.Parse(xmlPageSetup.PageHeight);
				}
				string text = xmlPageSetup.PaperName;
				if (Operators.CompareString(text, "", false) == 0 & num2 == 0f & num == 0f)
				{
					text = "A4";
				}
				else if (Operators.CompareString(text, "", false) == 0)
				{
					text = "[自定义纸张]";
				}
				paperSize = checked(new PaperSize(text, (int)Math.Round((double)(unchecked(this.ConvertCmToInch(num) * 10f))), (int)Math.Round((double)(unchecked(this.ConvertCmToInch(num2) * 10f)))));
			}
			float num3;
			if (Operators.CompareString(xmlPageSetup.LeftMargin, "", false) != 0)
			{
				num3 = float.Parse(xmlPageSetup.LeftMargin) * 10f;
			}
			else
			{
				num3 = (float)this.PaperMargins.Left;
			}
			float num4;
			if (Operators.CompareString(xmlPageSetup.RightMargin, "", false) != 0)
			{
				num4 = float.Parse(xmlPageSetup.RightMargin) * 10f;
			}
			else
			{
				num4 = (float)this.PaperMargins.Right;
			}
			float num5;
			if (Operators.CompareString(xmlPageSetup.TopMargin, "", false) != 0)
			{
				num5 = float.Parse(xmlPageSetup.TopMargin) * 10f;
			}
			else
			{
				num5 = (float)this.PaperMargins.Top;
			}
			float num6;
			if (Operators.CompareString(xmlPageSetup.BottomMargin, "", false) != 0)
			{
				num6 = float.Parse(xmlPageSetup.BottomMargin) * 10f;
			}
			else
			{
				num6 = (float)this.PaperMargins.Bottom;
			}
			Margins thePaperMargin = checked(new Margins((int)Math.Round((double)num3), (int)Math.Round((double)num4), (int)Math.Round((double)num5), (int)Math.Round((double)num6)));
			if (Operators.CompareString(xmlPageSetup.PaperLandscape, "", false) == 0)
			{
				if (paperSize == null)
				{
					this.NewPage(thePaperMargin);
				}
				else
				{
					this.NewPage(paperSize, thePaperMargin);
				}
			}
			else
			{
				bool isPaperLandscape = Operators.CompareString(xmlPageSetup.PaperLandscape.ToLower(), "true", false) == 0 | Operators.CompareString(xmlPageSetup.PaperLandscape, "1", false) == 0;
				if (paperSize == null)
				{
					this.NewPage(thePaperMargin, isPaperLandscape);
				}
				else
				{
					this.NewPage(paperSize, thePaperMargin, isPaperLandscape);
				}
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000C0C7C File Offset: 0x000BEE7C
		private void xmlDrawDot(XmlNode node)
		{
			XmlDot xmlDot = new XmlDot(node);
			xmlDot.Parse();
			float num;
			if (Operators.CompareString(xmlDot.X, "", false) != 0)
			{
				num = float.Parse(xmlDot.X) * 10f;
			}
			else
			{
				num = this.Currentx;
			}
			float num2;
			if (Operators.CompareString(xmlDot.Y, "", false) != 0)
			{
				num2 = float.Parse(xmlDot.Y) * 10f;
			}
			else
			{
				num2 = this.Currenty;
			}
			float num3;
			if (Operators.CompareString(xmlDot.Width, "-1", false) == 0 | Operators.CompareString(xmlDot.Width, "", false) == 0)
			{
				num3 = 5f;
			}
			else
			{
				num3 = float.Parse(xmlDot.Width) * 10f;
			}
			Color lineColor = xmlDot.LineColor;
			this.DrawFillEllipse(new SolidBrush(lineColor), num - num3 / 2f, num2 - num3 / 2f, num3, num3);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000C0D64 File Offset: 0x000BEF64
		private void xmlDrawLine(XmlNode node)
		{
			XmlLine xmlLine = new XmlLine(node);
			xmlLine.Parse();
			LineFormat lineFormat = new LineFormat(xmlLine.LineFormat);
			float num;
			if (Operators.CompareString(xmlLine.X, "", false) != 0)
			{
				num = float.Parse(xmlLine.X) * 10f;
			}
			else
			{
				num = this.Currentx;
			}
			float num2;
			if (Operators.CompareString(xmlLine.Y, "", false) != 0)
			{
				num2 = float.Parse(xmlLine.Y) * 10f;
			}
			else
			{
				num2 = this.Currenty;
			}
			float num3;
			if (Operators.CompareString(xmlLine.X2, "", false) != 0)
			{
				num3 = float.Parse(xmlLine.X2) * 10f;
			}
			else
			{
				num3 = this.Currentx;
			}
			float num4;
			if (Operators.CompareString(xmlLine.Y2, "", false) != 0)
			{
				num4 = float.Parse(xmlLine.Y2) * 10f;
			}
			else
			{
				num4 = this.Currenty;
			}
			LineFormat lineFormat2 = lineFormat;
			PointF pointF = new PointF(num, num2);
			PointF start = pointF;
			PointF end = new PointF(num3, num4);
			Pen pen = lineFormat2.CreatePenByProperty(start, end);
			pen.Width *= 10f;
			this.DrawLine(pen, num, num2, num3, num4);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000C0E90 File Offset: 0x000BF090
		private void xmlDrawellipse(XmlNode node)
		{
			XmlEllipse xmlEllipse = new XmlEllipse(node);
			xmlEllipse.Parse();
			float num;
			if (Operators.CompareString(xmlEllipse.X, "", false) != 0)
			{
				num = float.Parse(xmlEllipse.X) * 10f;
			}
			else
			{
				num = this.Currentx;
			}
			float num2;
			if (Operators.CompareString(xmlEllipse.Y, "", false) != 0)
			{
				num2 = float.Parse(xmlEllipse.Y) * 10f;
			}
			else
			{
				num2 = this.Currenty;
			}
			float num3 = float.Parse(xmlEllipse.Width) * 10f;
			float num4 = float.Parse(xmlEllipse.Height) * 10f;
			Color lineColor = xmlEllipse.LineColor;
			Pen mypen = new Pen(lineColor, xmlEllipse.LineWidth * 10f);
			RectangleF rect = new RectangleF(num, num2, num3, num4);
			this.DrawEllipse(mypen, rect);
			BorderFormat borderFormat = new BorderFormat(xmlEllipse.BorderFormat);
			float num5 = xmlEllipse.LineWidth * 10f;
			if (!borderFormat.BackColor.IsEmpty)
			{
				this.DrawFillEllipse(num + num5 / 2f, num2 + num5 / 2f, num3 - num5, num4 - num5, borderFormat.BackColor);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000C0FC0 File Offset: 0x000BF1C0
		private void xmlDrawCircle(XmlNode node)
		{
			XmlEllipse xmlEllipse = new XmlEllipse(node);
			xmlEllipse.Parse();
			float num;
			if (Operators.CompareString(xmlEllipse.X, "", false) != 0)
			{
				num = float.Parse(xmlEllipse.X) * 10f;
			}
			else
			{
				num = this.Currentx;
			}
			float num2;
			if (Operators.CompareString(xmlEllipse.Y, "", false) != 0)
			{
				num2 = float.Parse(xmlEllipse.Y) * 10f;
			}
			else
			{
				num2 = this.Currenty;
			}
			float num3 = float.Parse(xmlEllipse.Width) * 10f;
			float num4 = num3;
			Color lineColor = xmlEllipse.LineColor;
			Pen mypen = new Pen(lineColor, xmlEllipse.LineWidth * 10f);
			RectangleF rect = new RectangleF(num, num2, num3, num4);
			this.DrawEllipse(mypen, rect);
			BorderFormat borderFormat = new BorderFormat(xmlEllipse.BorderFormat);
			float num5 = xmlEllipse.LineWidth * 10f;
			if (!borderFormat.BackColor.IsEmpty)
			{
				this.DrawFillEllipse(num + num5 / 2f, num2 + num5 / 2f, num3 - num5, num4 - num5, borderFormat.BackColor);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000C10E0 File Offset: 0x000BF2E0
		private void xmlDraweText(XmlNode node, Hashtable myhash, Hashtable dgvhashtable)
		{
			XmlTextLabel xmlTextLabel = new XmlTextLabel(node);
			xmlTextLabel.Parse();
			if (Operators.CompareString(xmlTextLabel.X, "", false) != 0)
			{
				float num = float.Parse(xmlTextLabel.X) * 10f;
			}
			else
			{
				float currentx = this.Currentx;
			}
			if (Operators.CompareString(xmlTextLabel.Y, "", false) != 0)
			{
				float num2 = float.Parse(xmlTextLabel.Y) * 10f;
			}
			else
			{
				float currenty = this.Currenty;
			}
			Color textforecolor = Color.Black;
			string text = xmlTextLabel.Text;
			text = this.myxmlreplace(text, myhash, dgvhashtable);
			TextFormat textFormat = new TextFormat(xmlTextLabel.TextFormat);
			StringFormat stringFormat = textFormat.GetStringFormat();
			Font font = textFormat.Font;
			textforecolor = textFormat.ForeColor;
			this.DrawText(text, font, textforecolor, stringFormat, 0);
			this.NewRow(this.LastDrawTextHeight);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000C11B4 File Offset: 0x000BF3B4
		private void xmlDraweTextEx(XmlNode node, Hashtable myhash, Hashtable dgvhashtable)
		{
			XmlTextLabel xmlTextLabel = new XmlTextLabel(node);
			xmlTextLabel.Parse();
			if (Operators.CompareString(xmlTextLabel.X, "", false) != 0)
			{
				float num = float.Parse(xmlTextLabel.X) * 10f;
			}
			else
			{
				float currentx = this.Currentx;
			}
			if (Operators.CompareString(xmlTextLabel.Y, "", false) != 0)
			{
				float num2 = float.Parse(xmlTextLabel.Y) * 10f;
			}
			else
			{
				float currenty = this.Currenty;
			}
			Color color = Color.Black;
			string text = xmlTextLabel.Text;
			text = this.myxmlreplace(text, myhash, dgvhashtable);
			TextFormat textFormat = new TextFormat(xmlTextLabel.TextFormat);
			textFormat.GetStringFormat();
			Font font = textFormat.Font;
			color = textFormat.ForeColor;
			float linespace;
			if (Operators.CompareString(xmlTextLabel.LineSpace, "", false) == 0)
			{
				linespace = 0f;
			}
			else
			{
				linespace = float.Parse(xmlTextLabel.LineSpace);
			}
			float charspace;
			if (Operators.CompareString(xmlTextLabel.CharSpace, "", false) == 0)
			{
				charspace = 0f;
			}
			else
			{
				charspace = float.Parse(xmlTextLabel.CharSpace);
			}
			this.DrawTextEx(text, font, new SolidBrush(color), linespace, charspace);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x000C12DC File Offset: 0x000BF4DC
		private void xmlDrawCell(XmlNode node, Hashtable myhash, Hashtable dgvhashtable)
		{
			XmlTextBox xmlTextBox = new XmlTextBox(node);
			xmlTextBox.Parse();
			float x;
			if (Operators.CompareString(xmlTextBox.X, "", false) != 0)
			{
				x = float.Parse(xmlTextBox.X) * 10f;
			}
			else
			{
				x = this.Currentx;
			}
			float y;
			if (Operators.CompareString(xmlTextBox.Y, "", false) != 0)
			{
				y = float.Parse(xmlTextBox.Y) * 10f;
			}
			else
			{
				y = this.Currenty;
			}
			float num = float.Parse(xmlTextBox.Width) * 10f;
			float num2 = float.Parse(xmlTextBox.Height) * 10f;
			Color textforecolor = Color.Black;
			string text = xmlTextBox.Text;
			text = this.myxmlreplace(text, myhash, dgvhashtable);
			TextFormat textFormat = new TextFormat(xmlTextBox.TextFormat);
			StringFormat stringFormat = textFormat.GetStringFormat();
			Font font = textFormat.Font;
			textforecolor = textFormat.ForeColor;
			Color linecolor;
			if (Operators.CompareString(xmlTextBox.LineColor, "", false) == 0)
			{
				linecolor = Color.Black;
			}
			else
			{
				linecolor = XmlParserBase.GetColorFrom(xmlTextBox.LineColor);
			}
			BorderFormat borderFormat = new BorderFormat(xmlTextBox.BorderFormat);
			Color backColor = borderFormat.BackColor;
			checked
			{
				string text2;
				if (Operators.CompareString(xmlTextBox.Border, "", false) != 0)
				{
					string[] array = Strings.Split(xmlTextBox.Border, ",", -1, CompareMethod.Binary);
					text2 = "";
					int num3 = 0;
					int num4 = array.Length - 1;
					for (int i = num3; i <= num4; i++)
					{
						unchecked
						{
							if (Operators.CompareString(text2, "", false) == 0)
							{
								text2 = Conversions.ToString(float.Parse(array[i]) * 10f);
							}
							else
							{
								text2 = text2 + "," + Conversions.ToString(float.Parse(array[i]) * 10f);
							}
						}
					}
				}
				else
				{
					text2 = "";
				}
				RectangleF myrect = new RectangleF(x, y, (float)this.Width, (float)this.Height);
				PaddingStyle paddingStyle = new PaddingStyle(xmlTextBox.padding);
				Margins cellMargin = new Margins();
				cellMargin = this.CellMargin;
				this.CellMargin = new Margins((int)Math.Round((double)(unchecked(paddingStyle.Left * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Right * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Top * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Bottom * 10f))));
				this.DrawCell(text, myrect, font, textforecolor, stringFormat, text2, linecolor, backColor, 0f, 0);
				this.CellMargin = cellMargin;
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000C1558 File Offset: 0x000BF758
		private void xmlDraweEmbedTable(XmlNode node, Hashtable myhash, Hashtable dgvhashtable)
		{
			if (dgvhashtable != null && dgvhashtable.Count > 0)
			{
				XmlEmbedTable xmlEmbedTable = new XmlEmbedTable(node);
				xmlEmbedTable.Parse();
				string text = xmlEmbedTable.Title;
				text = this.myxmlreplace(text, myhash, dgvhashtable);
				Font titleFont = xmlEmbedTable.TitleFont;
				DataGridView dataGridView = null;
				if (Operators.CompareString(xmlEmbedTable.src, "", false) != 0)
				{
					try
					{
						dataGridView = (DataGridView)dgvhashtable[xmlEmbedTable.src];
						goto IL_92;
					}
					catch (Exception ex)
					{
						return;
					}
				}
				dataGridView = (DataGridView)dgvhashtable[0];
			IL_92:
				string text2;
				Margins cellMargin;
				bool isUseDGVPadding;
				string text3;
				string text4;
				string text5;
				string text6;
				string tableleft;
				string tablemiddle;
				string tableright;
				bool isDrawTableFooterEveryPage;
				Color gridColor;
				TreeView columnheadertree;
				checked
				{
					if (Operators.CompareString(xmlEmbedTable.Border, "", false) != 0)
					{
						string[] array = Strings.Split(xmlEmbedTable.Border, ",", -1, CompareMethod.Binary);
						text2 = "";
						int num = 0;
						int num2 = array.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							unchecked
							{
								if (Operators.CompareString(text2, "", false) == 0)
								{
									text2 = Conversions.ToString(float.Parse(array[i]) * 10f);
								}
								else
								{
									text2 = text2 + "," + Conversions.ToString(float.Parse(array[i]) * 10f);
								}
							}
						}
					}
					else
					{
						text2 = "";
					}
					PaddingStyle paddingStyle = new PaddingStyle(xmlEmbedTable.padding);
					cellMargin = new Margins();
					cellMargin = this.CellMargin;
					this.CellMargin = new Margins((int)Math.Round((double)(unchecked(paddingStyle.Left * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Right * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Top * 10f))), (int)Math.Round((double)(unchecked(paddingStyle.Bottom * 10f))));
					isUseDGVPadding = this.IsUseDGVPadding;
					if (xmlEmbedTable.IsUseDgvPadding)
					{
						this.IsUseDGVPadding = true;
					}
					else
					{
						this.IsUseDGVPadding = false;
					}
					text3 = xmlEmbedTable.SubTitle;
					text3 = this.myxmlreplace(text3, myhash, dgvhashtable);
					text4 = xmlEmbedTable.TableHeaderL;
					text4 = this.myxmlreplace(text4, myhash, dgvhashtable);
					text5 = xmlEmbedTable.TableHeaderM;
					text5 = this.myxmlreplace(text5, myhash, dgvhashtable);
					text6 = xmlEmbedTable.TableHeaderR;
					text6 = this.myxmlreplace(text6, myhash, dgvhashtable);
					tableleft = xmlEmbedTable.TableFooterL;
					tableleft = this.myxmlreplace(text4, myhash, dgvhashtable);
					tablemiddle = xmlEmbedTable.TableFooterM;
					tablemiddle = this.myxmlreplace(text5, myhash, dgvhashtable);
					tableright = xmlEmbedTable.TableFooterR;
					tableright = this.myxmlreplace(text6, myhash, dgvhashtable);
					isDrawTableFooterEveryPage = this.IsDrawTableFooterEveryPage;
					this.IsDrawTableFooterEveryPage = xmlEmbedTable.DrawTableFooterEveryPage;
					gridColor = dataGridView.GridColor;
					if (Operators.CompareString(xmlEmbedTable.LineColor, "", false) != 0)
					{
						Color colorFrom = XmlParserBase.GetColorFrom(xmlEmbedTable.LineColor);
						if (!colorFrom.IsEmpty)
						{
							dataGridView.GridColor = colorFrom;
						}
					}
					if (dataGridView is MulHeaderDataGridView)
					{
						columnheadertree = ((MulHeaderDataGridView)dataGridView).ColHeaderTreeView;
					}
					else
					{
						columnheadertree = null;
					}
					Module1.CopyDataGridView(dataGridView, this.myms);
				}
				Color color;
				this.StartDo(this.myms, xmlEmbedTable.SortColumn, xmlEmbedTable.SortType, xmlEmbedTable.GroupColumn, "", xmlEmbedTable.AddRowId, false, null, color, color, xmlEmbedTable.AutoFormat, xmlEmbedTable.PrintType, text, titleFont, text3, xmlEmbedTable.SubTitleFont, xmlEmbedTable.Alignemnt, text2, xmlEmbedTable.ZoomToPaperWidth, xmlEmbedTable.AutoResizeRowHeight, xmlEmbedTable.TableHeaderFont, text4, text5, text6, xmlEmbedTable.TableFooterFont, tableleft, tablemiddle, tableright, xmlEmbedTable.MinFontSize, xmlEmbedTable.RepPageTitle, xmlEmbedTable.PrintBackColor, 0, 0, xmlEmbedTable.FixedCols, xmlEmbedTable.AddRowId, xmlEmbedTable.Columns, xmlEmbedTable.ColumnSpace * 10f, xmlEmbedTable.LastPageMode, xmlEmbedTable.Linespace * 10f, xmlEmbedTable.PrintZero, columnheadertree, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Near, StringAlignment.Center, StringAlignment.Far, StringAlignment.Center, xmlEmbedTable.AutoWrap, 0f);
				this.CellMargin = cellMargin;
				this.IsUseDGVPadding = isUseDGVPadding;
				this.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage;
				dataGridView.GridColor = gridColor;
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000C194C File Offset: 0x000BFB4C
		public void ClearDoc()
		{
			bool flag = this.myisimmediateprintnotpreview;
			bool isShowProgess = this.myisshowprogress;
			this.myisimmediateprintnotpreview = false;
			this.IsShowProgess = false;
			this.NewDoc();
			this.NewPage();
			this.EndDoc();
			this.DelMypages();
			this.mystatus.Text = "共【0】页";
			this.cpage.Enabled = false;
			this.cpage.Items.Clear();
			this.myisimmediateprintnotpreview = flag;
			this.IsShowProgess = isShowProgess;
		}

		// Token: 0x0400099A RID: 2458
		private IContainer components;

		// Token: 0x0400099B RID: 2459
		[AccessedThroughProperty("Pd")]
		private PrintDocument _Pd;

		// Token: 0x0400099C RID: 2460
		[AccessedThroughProperty("PageSetupDialog1")]
		private PageSetupDialog _PageSetupDialog1;

		// Token: 0x0400099D RID: 2461
		[AccessedThroughProperty("PrintDialog1")]
		private PrintDialog _PrintDialog1;

		// Token: 0x0400099E RID: 2462
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x0400099F RID: 2463
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040009A0 RID: 2464
		[AccessedThroughProperty("PrintPreviewControl1")]
		private PrintPreviewControl _PrintPreviewControl1;

		// Token: 0x040009A1 RID: 2465
		[AccessedThroughProperty("ColorDialog1")]
		private ColorDialog _ColorDialog1;

		// Token: 0x040009A2 RID: 2466
		[AccessedThroughProperty("myms")]
		private DataGridView _myms;

		// Token: 0x040009A3 RID: 2467
		[AccessedThroughProperty("mydgv2")]
		private DataGridView _mydgv2;

		// Token: 0x040009A4 RID: 2468
		[AccessedThroughProperty("tempdgv")]
		private DataGridView _tempdgv;

		// Token: 0x040009A5 RID: 2469
		[AccessedThroughProperty("BeforePreviewD")]
		private PrintDocument _BeforePreviewD;

		// Token: 0x040009A6 RID: 2470
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040009A7 RID: 2471
		[AccessedThroughProperty("打印全部")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040009A8 RID: 2472
		[AccessedThroughProperty("打印")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040009A9 RID: 2473
		[AccessedThroughProperty("页面设置")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x040009AA RID: 2474
		[AccessedThroughProperty("保存为报表文件")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x040009AB RID: 2475
		[AccessedThroughProperty("打开报表文件")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x040009AC RID: 2476
		[AccessedThroughProperty("打印当前页")]
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x040009AD RID: 2477
		[AccessedThroughProperty("ToolStripMenuItem13")]
		private ToolStripSeparator _ToolStripMenuItem13;

		// Token: 0x040009AE RID: 2478
		[AccessedThroughProperty("ToolStripMenuItem14")]
		private ToolStripSeparator _ToolStripMenuItem14;

		// Token: 0x040009AF RID: 2479
		[AccessedThroughProperty("ToolStripMenuItem12")]
		private ToolStripSeparator _ToolStripMenuItem12;

		// Token: 0x040009B0 RID: 2480
		[AccessedThroughProperty("关于")]
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x040009B1 RID: 2481
		[AccessedThroughProperty("pagesetup")]
		private ToolStripButton _pagesetup;

		// Token: 0x040009B2 RID: 2482
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040009B3 RID: 2483
		[AccessedThroughProperty("myopen")]
		private ToolStripButton _myopen;

		// Token: 0x040009B4 RID: 2484
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040009B5 RID: 2485
		[AccessedThroughProperty("mybl")]
		private ToolStripDropDownButton _mybl;

		// Token: 0x040009B6 RID: 2486
		[AccessedThroughProperty("ToolStripMenuItem11")]
		private ToolStripMenuItem _ToolStripMenuItem11;

		// Token: 0x040009B7 RID: 2487
		[AccessedThroughProperty("ToolStripMenuItem")]
		private ToolStripMenuItem _ToolStripMenuItem;

		// Token: 0x040009B8 RID: 2488
		[AccessedThroughProperty("ToolStripMenuItem0")]
		private ToolStripMenuItem _ToolStripMenuItem0;

		// Token: 0x040009B9 RID: 2489
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040009BA RID: 2490
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x040009BB RID: 2491
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x040009BC RID: 2492
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x040009BD RID: 2493
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem _ToolStripMenuItem5;

		// Token: 0x040009BE RID: 2494
		[AccessedThroughProperty("ToolStripMenuItem6")]
		private ToolStripMenuItem _ToolStripMenuItem6;

		// Token: 0x040009BF RID: 2495
		[AccessedThroughProperty("ToolStripMenuItem7")]
		private ToolStripMenuItem _ToolStripMenuItem7;

		// Token: 0x040009C0 RID: 2496
		[AccessedThroughProperty("ToolStripMenuItem8")]
		private ToolStripMenuItem _ToolStripMenuItem8;

		// Token: 0x040009C1 RID: 2497
		[AccessedThroughProperty("ToolStripMenuItem9")]
		private ToolStripMenuItem _ToolStripMenuItem9;

		// Token: 0x040009C2 RID: 2498
		[AccessedThroughProperty("ToolStripMenuItem10")]
		private ToolStripMenuItem _ToolStripMenuItem10;

		// Token: 0x040009C3 RID: 2499
		[AccessedThroughProperty("mycolsperpage")]
		private ToolStripDropDownButton _mycolsperpage;

		// Token: 0x040009C4 RID: 2500
		[AccessedThroughProperty("页ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x040009C5 RID: 2501
		[AccessedThroughProperty("页ToolStripMenuItem1")]
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x040009C6 RID: 2502
		[AccessedThroughProperty("页ToolStripMenuItem2")]
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x040009C7 RID: 2503
		[AccessedThroughProperty("页ToolStripMenuItem3")]
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x040009C8 RID: 2504
		[AccessedThroughProperty("页ToolStripMenuItem4")]
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x040009C9 RID: 2505
		[AccessedThroughProperty("页ToolStripMenuItem5")]
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x040009CA RID: 2506
		[AccessedThroughProperty("页ToolStripMenuItem6")]
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x040009CB RID: 2507
		[AccessedThroughProperty("页ToolStripMenuItem7")]
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x040009CC RID: 2508
		[AccessedThroughProperty("myshowtype")]
		private ToolStripDropDownButton _myshowtype;

		// Token: 0x040009CD RID: 2509
		[AccessedThroughProperty("mytype1")]
		private ToolStripMenuItem _mytype1;

		// Token: 0x040009CE RID: 2510
		[AccessedThroughProperty("mytype2")]
		private ToolStripMenuItem _mytype2;

		// Token: 0x040009CF RID: 2511
		[AccessedThroughProperty("cpage")]
		private ToolStripComboBox _cpage;

		// Token: 0x040009D0 RID: 2512
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040009D1 RID: 2513
		[AccessedThroughProperty("mystatus")]
		private ToolStripLabel _mystatus;

		// Token: 0x040009D2 RID: 2514
		[AccessedThroughProperty("ToolStripSeparator6")]
		private ToolStripSeparator _ToolStripSeparator6;

		// Token: 0x040009D3 RID: 2515
		[AccessedThroughProperty("fpage")]
		private ToolStripButton _fpage;

		// Token: 0x040009D4 RID: 2516
		[AccessedThroughProperty("ppage")]
		private ToolStripButton _ppage;

		// Token: 0x040009D5 RID: 2517
		[AccessedThroughProperty("npage")]
		private ToolStripButton _npage;

		// Token: 0x040009D6 RID: 2518
		[AccessedThroughProperty("lpage")]
		private ToolStripButton _lpage;

		// Token: 0x040009D7 RID: 2519
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x040009D8 RID: 2520
		[AccessedThroughProperty("zdybutton")]
		private ToolStripButton _zdybutton;

		// Token: 0x040009D9 RID: 2521
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		// Token: 0x040009DA RID: 2522
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x040009DB RID: 2523
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x040009DC RID: 2524
		[AccessedThroughProperty("ZDYButton2")]
		private ToolStripButton _ZDYButton2;

		// Token: 0x040009DD RID: 2525
		[AccessedThroughProperty("printd")]
		private ToolStripSplitButton _printd;

		// Token: 0x040009DE RID: 2526
		[AccessedThroughProperty("dy1")]
		private ToolStripMenuItem _dy1;

		// Token: 0x040009DF RID: 2527
		[AccessedThroughProperty("dy2")]
		private ToolStripMenuItem _dy2;

		// Token: 0x040009E0 RID: 2528
		[AccessedThroughProperty("dy3")]
		private ToolStripMenuItem _dy3;

		// Token: 0x040009E1 RID: 2529
		[AccessedThroughProperty("mysave")]
		private ToolStripSplitButton _mysave;

		// Token: 0x040009E2 RID: 2530
		[AccessedThroughProperty("加密保存ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x040009E3 RID: 2531
		[AccessedThroughProperty("ToolStripMenuItem15")]
		private ToolStripMenuItem _ToolStripMenuItem15;

		// Token: 0x040009E4 RID: 2532
		[AccessedThroughProperty("测试ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x040009E5 RID: 2533
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040009E6 RID: 2534
		[AccessedThroughProperty("ToolStripMenuItem17")]
		private ToolStripSeparator _ToolStripMenuItem17;

		// Token: 0x040009E7 RID: 2535
		[AccessedThroughProperty("dy5")]
		private ToolStripMenuItem _dy5;

		// Token: 0x040009E8 RID: 2536
		[AccessedThroughProperty("dy4")]
		private ToolStripMenuItem _dy4;

		// Token: 0x040009E9 RID: 2537
		[AccessedThroughProperty("savepdf")]
		private ToolStripSeparator _savepdf;

		// Token: 0x040009EA RID: 2538
		[AccessedThroughProperty("保存为图像仅当前页ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x040009EB RID: 2539
		[AccessedThroughProperty("保存为图像全部页ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x040009EC RID: 2540
		[AccessedThroughProperty("saveaspdfcur")]
		private ToolStripMenuItem _saveaspdfcur;

		// Token: 0x040009ED RID: 2541
		[AccessedThroughProperty("saveaspdfall")]
		private ToolStripMenuItem _saveaspdfall;

		// Token: 0x040009EE RID: 2542
		[AccessedThroughProperty("ToolStripSeparator7")]
		private ToolStripSeparator _ToolStripSeparator7;

		// Token: 0x040009EF RID: 2543
		[AccessedThroughProperty("ToolStripMenuItem16")]
		private ToolStripSeparator _ToolStripMenuItem16;

		// Token: 0x040009F0 RID: 2544
		[AccessedThroughProperty("cgprint")]
		private ToolStripMenuItem _cgprint;

		// Token: 0x040009F1 RID: 2545
		private Font tempfont;

		// Token: 0x040009F2 RID: 2546
		private Font tempfontwater;

		// Token: 0x040009F3 RID: 2547
		private Color tempforecolor;

		// Token: 0x040009F4 RID: 2548
		private Color tempforecolorwater;

		// Token: 0x040009F5 RID: 2549
		private bool templandscapewater;

		// Token: 0x040009F6 RID: 2550
		private byte tempopacitywater;

		// Token: 0x040009F7 RID: 2551
		private Margins tempcellmargin;

		// Token: 0x040009F8 RID: 2552
		private int tempshapedepth;

		// Token: 0x040009F9 RID: 2553
		private bool templandscape;

		// Token: 0x040009FA RID: 2554
		private PaperKind temppaperkind;

		// Token: 0x040009FB RID: 2555
		private VB2008Print.PageExportUnit temppageunits;

		// Token: 0x040009FC RID: 2556
		private int tempmargintleft;

		// Token: 0x040009FD RID: 2557
		private int tempmargintright;

		// Token: 0x040009FE RID: 2558
		private int tempmarginttop;

		// Token: 0x040009FF RID: 2559
		private int tempmargintbottom;

		// Token: 0x04000A00 RID: 2560
		private PaperSize temppapersize;

		// Token: 0x04000A01 RID: 2561
		private bool tempisdrawtableeverypage;

		// Token: 0x04000A02 RID: 2562
		private bool tempisautoaddemptyrow;

		// Token: 0x04000A03 RID: 2563
		private bool tempisneedchecknewpage;

		// Token: 0x04000A04 RID: 2564
		private bool tempouterborder;

		// Token: 0x04000A05 RID: 2565
		private float tempouterborderwidth;

		// Token: 0x04000A06 RID: 2566
		private Color tempouterbordercolor;

		// Token: 0x04000A07 RID: 2567
		private bool tempisusedoubleline;

		// Token: 0x04000A08 RID: 2568
		private float tempdoublelinespace;

		// Token: 0x04000A09 RID: 2569
		private bool tempIsDGVCellValignmentCenter;

		// Token: 0x04000A0A RID: 2570
		private bool tempIsDrawPageFooterLine;

		// Token: 0x04000A0B RID: 2571
		private bool tempIsDrawPageHeaderLine;

		// Token: 0x04000A0C RID: 2572
		private bool tempIsUseDGVPadding;

		// Token: 0x04000A0D RID: 2573
		private float tempoffsetx;

		// Token: 0x04000A0E RID: 2574
		private float tempoffsety;

		// Token: 0x04000A0F RID: 2575
		private bool hasshownewpageerror;

		// Token: 0x04000A10 RID: 2576
		private bool hasprinterinstalled;

		// Token: 0x04000A11 RID: 2577
		private progress myprogresswait;

		// Token: 0x04000A12 RID: 2578
		private float PIXELSPERINCHX;

		// Token: 0x04000A13 RID: 2579
		private float PIXELSPERINCHY;

		// Token: 0x04000A14 RID: 2580
		private bool IsOpenReporting;

		// Token: 0x04000A15 RID: 2581
		private int currentpage;

		// Token: 0x04000A16 RID: 2582
		private int pages;

		// Token: 0x04000A17 RID: 2583
		private bool w_end;

		// Token: 0x04000A18 RID: 2584
		private VB2008Print.mypic[] mypicture;

		// Token: 0x04000A19 RID: 2585
		private int mypictures;

		// Token: 0x04000A1A RID: 2586
		private StringBuilder[] mypages;

		// Token: 0x04000A1B RID: 2587
		private int W_myrtfnum;

		// Token: 0x04000A1C RID: 2588
		private VB2008Print.mypic[] W_myrtfC;

		// Token: 0x04000A1D RID: 2589
		private const string MYSEPARATOR = "\0";

		// Token: 0x04000A1E RID: 2590
		private const string LINESeparator = "\u0001\u0003";

		// Token: 0x04000A1F RID: 2591
		private const string SEPARATOR2 = "\u0002\u0004";

		// Token: 0x04000A20 RID: 2592
		private const string SEPARATOR3 = "\u0006";

		// Token: 0x04000A21 RID: 2593
		private const string SEPARATORPen = "\u0003\u0005";

		// Token: 0x04000A22 RID: 2594
		private const string SEPARATORPen2 = "\u0002\u0005";

		// Token: 0x04000A23 RID: 2595
		private const string SEPARATORPen3 = "\u0001\u0005";

		// Token: 0x04000A24 RID: 2596
		private Graphics myg;

		// Token: 0x04000A25 RID: 2597
		private bool isfrompageset;

		// Token: 0x04000A26 RID: 2598
		private Font r_font;

		// Token: 0x04000A27 RID: 2599
		private bool isstarting;

		// Token: 0x04000A28 RID: 2600
		private bool isprinttoprinter;

		// Token: 0x04000A29 RID: 2601
		private bool hasshowpapersizeerror;

		// Token: 0x04000A2A RID: 2602
		private bool hasshowpapersizeerror2;

		// Token: 0x04000A2B RID: 2603
		private string myDocumentName;

		// Token: 0x04000A2C RID: 2604
		private float[] myPaperWidth;

		// Token: 0x04000A2D RID: 2605
		private float[] myPaperHeight;

		// Token: 0x04000A2E RID: 2606
		private const int PHYSICALOFFSETX = 112;

		// Token: 0x04000A2F RID: 2607
		private const int PHYSICALOFFSETY = 113;

		// Token: 0x04000A30 RID: 2608
		private float unprintablex;

		// Token: 0x04000A31 RID: 2609
		private float unprintabley;

		// Token: 0x04000A32 RID: 2610
		private float w_CE;

		// Token: 0x04000A33 RID: 2611
		private VB2008Print.MyPrintPageRange w_myprintrange;

		// Token: 0x04000A34 RID: 2612
		private int w_duplexfrom;

		// Token: 0x04000A35 RID: 2613
		private int w_duplexto;

		// Token: 0x04000A36 RID: 2614
		private bool myisusedoubleline;

		// Token: 0x04000A37 RID: 2615
		private bool myouterborder;

		// Token: 0x04000A38 RID: 2616
		private Color myouterbordercolor;

		// Token: 0x04000A39 RID: 2617
		private float myouterborderwidth;

		// Token: 0x04000A3A RID: 2618
		private float thedoublelinespace;

		// Token: 0x04000A3B RID: 2619
		private bool myisneedchecknewpage;

		// Token: 0x04000A3C RID: 2620
		private Color myforecolor;

		// Token: 0x04000A3D RID: 2621
		private Font myfont;

		// Token: 0x04000A3E RID: 2622
		private float mycurrentx;

		// Token: 0x04000A3F RID: 2623
		private float mycurrenty;

		// Token: 0x04000A40 RID: 2624
		private PageSettings mypagesetting;

		// Token: 0x04000A41 RID: 2625
		private Margins myCellmargin;

		// Token: 0x04000A42 RID: 2626
		private bool myenabledpagesetting;

		// Token: 0x04000A43 RID: 2627
		private bool myenabledprint;

		// Token: 0x04000A44 RID: 2628
		private bool mycanopenreport;

		// Token: 0x04000A45 RID: 2629
		private bool mycansavereport;

		// Token: 0x04000A46 RID: 2630
		private float mylastdrawtextheight;

		// Token: 0x04000A47 RID: 2631
		private float mylastdrawtextwidth;

		// Token: 0x04000A48 RID: 2632
		private bool myisdrawmargin;

		// Token: 0x04000A49 RID: 2633
		private bool myishowprintstatusdialog;

		// Token: 0x04000A4A RID: 2634
		private string mywatermarktext;

		// Token: 0x04000A4B RID: 2635
		private Font mywatermarkfont;

		// Token: 0x04000A4C RID: 2636
		private byte mywatermarkopacity;

		// Token: 0x04000A4D RID: 2637
		private bool mywatermarklandscape;

		// Token: 0x04000A4E RID: 2638
		private Color mywatermarkcolor;

		// Token: 0x04000A4F RID: 2639
		private int myshapedepth;

		// Token: 0x04000A50 RID: 2640
		private bool myiszdybuttonvisible;

		// Token: 0x04000A51 RID: 2641
		private bool myiszdybutton2visible;

		// Token: 0x04000A52 RID: 2642
		private bool myIsDGVCellValignmentCenter;

		// Token: 0x04000A53 RID: 2643
		private bool myisendpreview;

		// Token: 0x04000A54 RID: 2644
		private bool myisimmediateprintnotpreview;

		// Token: 0x04000A55 RID: 2645
		private bool myIsImmediatePrintNotPreviewShowPrintDialog;

		// Token: 0x04000A56 RID: 2646
		private bool myisshowprogress;

		// Token: 0x04000A57 RID: 2647
		private bool myisuseAPIprintDialog;

		// Token: 0x04000A58 RID: 2648
		private bool myIsShowMessageIfPrinterNotSupportPaper;

		// Token: 0x04000A59 RID: 2649
		private Image mypagebackgroundimage;

		// Token: 0x04000A5A RID: 2650
		private bool myistoolbarvisible;

		// Token: 0x04000A5B RID: 2651
		private bool myisshowcontextmenu;

		// Token: 0x04000A5C RID: 2652
		private bool myisdrawpageheaderline;

		// Token: 0x04000A5D RID: 2653
		private bool myisdrawpagefooterline;

		// Token: 0x04000A5E RID: 2654
		private bool myisusedgvpadding;

		// Token: 0x04000A5F RID: 2655
		private bool myisshowerrormsg;

		// Token: 0x04000A60 RID: 2656
		private float myheaderlineposition;

		// Token: 0x04000A61 RID: 2657
		public PageExportUnit mypageunits;

		// Token: 0x04000A62 RID: 2658
		private bool myisautoaddemptyrow;

		// Token: 0x04000A63 RID: 2659
		private bool myisdrawtablefootereverypage;

		// Token: 0x04000A64 RID: 2660
		private bool myisshowpagecontinues;

		// Token: 0x04000A65 RID: 2661
		private bool myisneedprintpageheaderandfooter;

		// Token: 0x04000A66 RID: 2662
		private float myPYx;

		// Token: 0x04000A67 RID: 2663
		private float myPYy;

		// Token: 0x04000A68 RID: 2664
		private bool myisautoadjustprintermargin;

		// Token: 0x04000A69 RID: 2665
		private bool myenablesaveaspdf;

		// Token: 0x04000A6A RID: 2666
		private bool myenablesaveasimage;

		// Token: 0x04000A6B RID: 2667
		private bool myenablecgprint;

		// Token: 0x04000A6C RID: 2668
		private short _printcopys;

		// Token: 0x04000A6D RID: 2669
		private draftset g_pp;

		// Token: 0x04000A76 RID: 2678
		private float mypagescale;

		// Token: 0x04000A77 RID: 2679
		private string myZDXtext;

		// Token: 0x04000A78 RID: 2680
		private Font myZDXfont;

		// Token: 0x04000A79 RID: 2681
		private Color myZDXtextcolor;

		// Token: 0x04000A7A RID: 2682
		private Color myZDXlinecolor;

		// Token: 0x04000A7B RID: 2683
		private DashStyle myZDXlinestyle;

		// Token: 0x04000A7C RID: 2684
		private float myZDXposition;

		// Token: 0x04000A7D RID: 2685
		private VB2008Print.TheZDXTYPE myZDXtype;

		// Token: 0x04000A7E RID: 2686
		private bool myisdrawZDX;

		// Token: 0x04000A7F RID: 2687
		private FieldInfo m_Position;

		// Token: 0x04000A80 RID: 2688
		private FieldInfo m_mypageinfo;

		// Token: 0x04000A81 RID: 2689
		private MethodInfo m_SetPositionMethod;

		// Token: 0x04000A82 RID: 2690
		private bool isMouseDown;

		// Token: 0x04000A83 RID: 2691
		private Point startPosition;

		// Token: 0x04000A84 RID: 2692
		private Point endPosition;

		// Token: 0x04000A85 RID: 2693
		private Point curPos;

		// Token: 0x02000090 RID: 144
		private enum MyPrintPageRange
		{
			// Token: 0x04000A87 RID: 2695
			PageRange_JS = 1,
			// Token: 0x04000A88 RID: 2696
			PageRange_OS
		}

		// Token: 0x02000091 RID: 145
		public enum BarcodeFormat
		{
			// Token: 0x04000A8A RID: 2698
			AZTEC = 1,
			// Token: 0x04000A8B RID: 2699
			CODABAR,
			// Token: 0x04000A8C RID: 2700
			CODE_39 = 4,
			// Token: 0x04000A8D RID: 2701
			CODE_93 = 8,
			// Token: 0x04000A8E RID: 2702
			CODE_128 = 16,
			// Token: 0x04000A8F RID: 2703
			CODE_128B,
			// Token: 0x04000A90 RID: 2704
			DATA_MATRIX = 32,
			// Token: 0x04000A91 RID: 2705
			EAN_8 = 64,
			// Token: 0x04000A92 RID: 2706
			EAN_13 = 128,
			// Token: 0x04000A93 RID: 2707
			ITF = 256,
			// Token: 0x04000A94 RID: 2708
			MAXICODE = 512,
			// Token: 0x04000A95 RID: 2709
			PDF_417 = 1024,
			// Token: 0x04000A96 RID: 2710
			QR_CODE = 2048
		}

		// Token: 0x02000092 RID: 146
		public enum BarCode
		{
			// Token: 0x04000A98 RID: 2712
			EAN13,
			// Token: 0x04000A99 RID: 2713
			ENA8,
			// Token: 0x04000A9A RID: 2714
			Code39,
			// Token: 0x04000A9B RID: 2715
			Code128,
			// Token: 0x04000A9C RID: 2716
			Code128A,
			// Token: 0x04000A9D RID: 2717
			Code128B,
			// Token: 0x04000A9E RID: 2718
			Code128C,
			// Token: 0x04000A9F RID: 2719
			Codabar,
			// Token: 0x04000AA0 RID: 2720
			Code11,
			// Token: 0x04000AA1 RID: 2721
			Code25,
			// Token: 0x04000AA2 RID: 2722
			Code25_Stand,
			// Token: 0x04000AA3 RID: 2723
			ISBN,
			// Token: 0x04000AA4 RID: 2724
			CODE39Extended
		}

		// Token: 0x02000093 RID: 147
		public enum PageExportUnit
		{
			// Token: 0x04000AA6 RID: 2726
			CentiMeter,
			// Token: 0x04000AA7 RID: 2727
			Inch = 3
		}

		// Token: 0x02000094 RID: 148
		private struct mypic
		{
			// Token: 0x04000AA8 RID: 2728
			public byte[] mypi;
		}

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06001663 RID: 5731
		public delegate void QueryDefaultPageSettingsEventHandler(ref PaperSize mypapesize, ref Margins thePaperMargin, ref bool isPaperLandscape);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06001667 RID: 5735
		public delegate void PrintDocumentEventHandler();

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600166B RID: 5739
		public delegate void HeaderFooterOutEventHandler(int pages, int curpage);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600166F RID: 5743
		public delegate void EndPrintToPrinterEventHandler();

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06001673 RID: 5747
		public delegate void BeginPrintEventHandler(bool isprintToPrinter, ref bool cancel);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06001677 RID: 5751
		public delegate void EndPreViewEventHandler();

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600167B RID: 5755
		public delegate void ZDYButtonClickEventHandler();

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600167F RID: 5759
		public delegate void ZDYButton2ClickEventHandler();

		// Token: 0x0200009D RID: 157
		public enum TheZDXTYPE
		{
			// Token: 0x04000AAA RID: 2730
			LEFT,
			// Token: 0x04000AAB RID: 2731
			TOP,
			// Token: 0x04000AAC RID: 2732
			RIGHT,
			// Token: 0x04000AAD RID: 2733
			BOTTOM
		}

		// Token: 0x0200009E RID: 158
		public enum DGVCopyRange
		{
			// Token: 0x04000AAF RID: 2735
			SelectedRows,
			// Token: 0x04000AB0 RID: 2736
			SelectedColumns,
			// Token: 0x04000AB1 RID: 2737
			SelectedRowsAndColumns
		}

		// Token: 0x0200009F RID: 159
		private class MyComparer : IComparer<Control>
		{
			// Token: 0x06001681 RID: 5761 RVA: 0x000C19C8 File Offset: 0x000BFBC8
			public int Compare(Control x, Control y)
			{
				int result;
				if (x.Location.Y < y.Location.Y)
				{
					result = -1;
				}
				else if (x.Location.Y > y.Location.Y)
				{
					result = 1;
				}
				else if (x.Height > y.Height)
				{
					result = -1;
				}
				else if (x.Height < y.Height)
				{
					result = 1;
				}
				else if (x.Location.X < y.Location.X)
				{
					result = -1;
				}
				else if (x.Location.X > y.Location.X)
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}
	}
}
