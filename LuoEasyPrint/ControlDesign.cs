using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;



namespace LuoEasyPrint
{
	// Token: 0x0200001B RID: 27
	[Browsable(false)]
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ToolboxItem(false)]
	public class ControlDesign : UserControl
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x0003A0E4 File Offset: 0x000382E4
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				if (this.CS != null)
				{
					this.CS.Dispose();
				}
				this.myp3.Dispose();
				this.myp1.Dispose();
				this.myp2.Dispose();
				this.myp4.Dispose();
				this.myp5.Dispose();
				this.myp6.Dispose();
				this.myp7.Dispose();
				this.myp8.Dispose();
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0003A18C File Offset: 0x0003838C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.sv = new VScrollBar();
			this.sh = new HScrollBar();
			this.Button1 = new Button();
			this.l2 = new Label();
			this.SplitContainer1 = new SplitContainer();
			this.Panel1 = new Panel();
			this.P1 = new PictureBox();
			this.Label1 = new Label();
			this.SplitContainer2 = new SplitContainer();
			this.Button5 = new Button();
			this.P2 = new PictureBox();
			this.ContextMenuStrip2 = new ContextMenuStrip(this.components);
			this.ToolStripMenuItem_1 = new ToolStripMenuItem();
			this.Label2 = new Label();
			this.SplitContainer3 = new SplitContainer();
			this.Button7 = new Button();
			this.P3 = new PictureBox();
			this.ContextMenuStrip3 = new ContextMenuStrip(this.components);
			this.ToolStripMenuItem_2 = new ToolStripMenuItem();
			this.Label3 = new Label();
			this.SplitContainer4 = new SplitContainer();
			this.P4 = new PictureBox();
			this.Label4 = new Label();
			this.SplitContainer5 = new SplitContainer();
			this.p5 = new PictureBox();
			this.Label5 = new Label();
			this.SplitContainer6 = new SplitContainer();
			this.P6 = new PictureBox();
			this.Label6 = new Label();
			this.SplitContainer7 = new SplitContainer();
			this.p7 = new PictureBox();
			this.Label7 = new Label();
			this.SplitContainer8 = new SplitContainer();
			this.P8 = new PictureBox();
			this.Label8 = new Label();
			this.Button2 = new Button();
			this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
			this.ToolStripMenuItem_0 = new ToolStripMenuItem();
			this.pp = new SplitContainer();
			this.shape1 = new Label();
			this.L1 = new Label();
			this.rh = new Ruler();
			this.rv = new Ruler();
			this.SplitContainer9 = new SplitContainer();
			this.SplitContainer10 = new SplitContainer();
			this.Button3 = new Button();
			this.Button31 = new Button();
			this.Button22 = new Button();
			this.Button23 = new Button();
			this.Button21 = new Button();
			this.Button29 = new Button();
			this.Button20 = new Button();
			this.Button4 = new Button();
			this.Button25 = new Button();
			this.Button30 = new Button();
			this.Button28 = new Button();
			this.Button26 = new Button();
			this.Button24 = new Button();
			this.Button27 = new Button();
			this.Label11 = new Label();
			this.PropertyGrid1 = new PropertyGrid();
			this.sx = new Label();
			this.o1 = new OpenFileDialog();
			this.s2 = new SaveFileDialog();
			this.o2 = new OpenFileDialog();
			this.ToolTip1 = new ToolTip(this.components);
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((ISupportInitialize)this.P1).BeginInit();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			((ISupportInitialize)this.P2).BeginInit();
			this.ContextMenuStrip2.SuspendLayout();
			this.SplitContainer3.Panel1.SuspendLayout();
			this.SplitContainer3.Panel2.SuspendLayout();
			this.SplitContainer3.SuspendLayout();
			((ISupportInitialize)this.P3).BeginInit();
			this.ContextMenuStrip3.SuspendLayout();
			this.SplitContainer4.Panel1.SuspendLayout();
			this.SplitContainer4.Panel2.SuspendLayout();
			this.SplitContainer4.SuspendLayout();
			((ISupportInitialize)this.P4).BeginInit();
			this.SplitContainer5.Panel1.SuspendLayout();
			this.SplitContainer5.Panel2.SuspendLayout();
			this.SplitContainer5.SuspendLayout();
			((ISupportInitialize)this.p5).BeginInit();
			this.SplitContainer6.Panel1.SuspendLayout();
			this.SplitContainer6.Panel2.SuspendLayout();
			this.SplitContainer6.SuspendLayout();
			((ISupportInitialize)this.P6).BeginInit();
			this.SplitContainer7.Panel1.SuspendLayout();
			this.SplitContainer7.Panel2.SuspendLayout();
			this.SplitContainer7.SuspendLayout();
			((ISupportInitialize)this.p7).BeginInit();
			this.SplitContainer8.Panel1.SuspendLayout();
			this.SplitContainer8.SuspendLayout();
			((ISupportInitialize)this.P8).BeginInit();
			this.ContextMenuStrip1.SuspendLayout();
			this.pp.Panel1.SuspendLayout();
			this.pp.Panel2.SuspendLayout();
			this.pp.SuspendLayout();
			this.SplitContainer9.Panel1.SuspendLayout();
			this.SplitContainer9.Panel2.SuspendLayout();
			this.SplitContainer9.SuspendLayout();
			this.SplitContainer10.Panel1.SuspendLayout();
			this.SplitContainer10.Panel2.SuspendLayout();
			this.SplitContainer10.SuspendLayout();
			this.SuspendLayout();
			this.sv.LargeChange = 30;
			Control sv = this.sv;
			Point location = new Point(69, 122);
			sv.Location = location;
			this.sv.Name = "sv";
			Control sv2 = this.sv;
			Size size = new Size(16, 148);
			sv2.Size = size;
			this.sv.TabIndex = 2;
			this.sh.LargeChange = 30;
			Control sh = this.sh;
			location = new Point(11, 53);
			sh.Location = location;
			this.sh.Name = "sh";
			Control sh2 = this.sh;
			size = new Size(235, 16);
			sh2.Size = size;
			this.sh.TabIndex = 3;
			this.Button1.Enabled = false;
			Control button = this.Button1;
			location = new Point(9, 212);
			button.Location = location;
			this.Button1.Name = "Button1";
			Control button2 = this.Button1;
			size = new Size(28, 28);
			button2.Size = size;
			this.Button1.TabIndex = 5;
			this.Button1.UseVisualStyleBackColor = true;
			this.l2.BackColor = Color.Red;
			this.l2.Cursor = Cursors.SizeWE;
			Control l = this.l2;
			location = new Point(32, 14);
			l.Location = location;
			this.l2.Name = "l2";
			Control l2 = this.l2;
			size = new Size(5, 15);
			l2.Size = size;
			this.l2.TabIndex = 8;
			this.ToolTip1.SetToolTip(this.l2, "左右拖动可以改变模板的设计宽度");
			this.SplitContainer1.BackColor = Color.Lime;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel1;
			Control splitContainer = this.SplitContainer1;
			location = new Point(118, 14);
			splitContainer.Location = location;
			Control splitContainer2 = this.SplitContainer1;
			Padding margin = new Padding(0);
			splitContainer2.Margin = margin;
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel1.Controls.Add(this.Panel1);
			this.SplitContainer1.Panel1.Controls.Add(this.Label1);
			this.SplitContainer1.Panel1MinSize = 20;
			this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
			this.SplitContainer1.Panel2MinSize = 140;
			Control splitContainer3 = this.SplitContainer1;
			size = new Size(560, 770);
			splitContainer3.Size = size;
			this.SplitContainer1.SplitterDistance = 79;
			this.SplitContainer1.SplitterWidth = 1;
			this.SplitContainer1.TabIndex = 9;
			this.Panel1.Controls.Add(this.P1);
			this.Panel1.Dock = DockStyle.Fill;
			Control panel = this.Panel1;
			location = new Point(0, 20);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			Control panel2 = this.Panel1;
			size = new Size(560, 59);
			panel2.Size = size;
			this.Panel1.TabIndex = 1;
			this.P1.BackColor = Color.White;
			this.P1.Dock = DockStyle.Fill;
			Control p = this.P1;
			location = new Point(0, 0);
			p.Location = location;
			Control p2 = this.P1;
			margin = new Padding(0);
			p2.Margin = margin;
			this.P1.Name = "P1";
			Control p3 = this.P1;
			size = new Size(560, 59);
			p3.Size = size;
			this.P1.TabIndex = 1;
			this.P1.TabStop = false;
			this.Label1.BackColor = SystemColors.ControlDark;
			this.Label1.Dock = DockStyle.Top;
			Control label = this.Label1;
			location = new Point(0, 0);
			label.Location = location;
			this.Label1.Name = "Label1";
			Control label2 = this.Label1;
			size = new Size(560, 20);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "▼页面页眉（每页重复打印）";
			this.Label1.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer2.BackColor = Color.Lime;
			this.SplitContainer2.Dock = DockStyle.Fill;
			this.SplitContainer2.FixedPanel = FixedPanel.Panel1;
			Control splitContainer4 = this.SplitContainer2;
			location = new Point(0, 0);
			splitContainer4.Location = location;
			Control splitContainer5 = this.SplitContainer2;
			margin = new Padding(0);
			splitContainer5.Margin = margin;
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = Orientation.Horizontal;
			this.SplitContainer2.Panel1.Controls.Add(this.Button5);
			this.SplitContainer2.Panel1.Controls.Add(this.P2);
			this.SplitContainer2.Panel1.Controls.Add(this.Label2);
			this.SplitContainer2.Panel1MinSize = 20;
			this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer3);
			this.SplitContainer2.Panel2MinSize = 120;
			Control splitContainer6 = this.SplitContainer2;
			size = new Size(560, 690);
			splitContainer6.Size = size;
			this.SplitContainer2.SplitterDistance = 69;
			this.SplitContainer2.SplitterWidth = 1;
			this.SplitContainer2.TabIndex = 0;
			this.Button5.BackColor = SystemColors.ButtonFace;
			Control button3 = this.Button5;
			location = new Point(142, 0);
			button3.Location = location;
			this.Button5.Name = "Button5";
			Control button4 = this.Button5;
			size = new Size(87, 20);
			button4.Size = size;
			this.Button5.TabIndex = 8;
			this.Button5.Text = "清除背景图片";
			this.Button5.UseVisualStyleBackColor = false;
			this.Button5.Visible = false;
			this.P2.BackColor = Color.White;
			this.P2.BackgroundImageLayout = ImageLayout.Stretch;
			this.P2.ContextMenuStrip = this.ContextMenuStrip2;
			this.P2.Dock = DockStyle.Fill;
			Control p4 = this.P2;
			location = new Point(0, 20);
			p4.Location = location;
			Control p5 = this.P2;
			margin = new Padding(0);
			p5.Margin = margin;
			this.P2.Name = "P2";
			Control p6 = this.P2;
			size = new Size(560, 49);
			p6.Size = size;
			this.P2.TabIndex = 2;
			this.P2.TabStop = false;
			this.ContextMenuStrip2.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem_1
			});
			this.ContextMenuStrip2.Name = "ContextMenuStrip2";
			Control contextMenuStrip = this.ContextMenuStrip2;
			size = new Size(147, 26);
			contextMenuStrip.Size = size;
			this.ToolStripMenuItem_1.Name = "清除背景图片ToolStripMenuItem";
			ToolStripItem toolStripItem = this.ToolStripMenuItem_1;
			size = new Size(146, 22);
			toolStripItem.Size = size;
			this.ToolStripMenuItem_1.Text = "清除背景图片";
			this.Label2.BackColor = SystemColors.ControlDark;
			this.Label2.Dock = DockStyle.Top;
			Control label3 = this.Label2;
			location = new Point(0, 0);
			label3.Location = location;
			this.Label2.Name = "Label2";
			Control label4 = this.Label2;
			size = new Size(560, 20);
			label4.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "▼报表头（仅第一页打印）";
			this.Label2.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer3.BackColor = Color.Lime;
			this.SplitContainer3.Dock = DockStyle.Fill;
			this.SplitContainer3.FixedPanel = FixedPanel.Panel1;
			Control splitContainer7 = this.SplitContainer3;
			location = new Point(0, 0);
			splitContainer7.Location = location;
			Control splitContainer8 = this.SplitContainer3;
			margin = new Padding(0);
			splitContainer8.Margin = margin;
			this.SplitContainer3.Name = "SplitContainer3";
			this.SplitContainer3.Orientation = Orientation.Horizontal;
			this.SplitContainer3.Panel1.Controls.Add(this.Button7);
			this.SplitContainer3.Panel1.Controls.Add(this.P3);
			this.SplitContainer3.Panel1.Controls.Add(this.Label3);
			this.SplitContainer3.Panel1MinSize = 20;
			this.SplitContainer3.Panel2.Controls.Add(this.SplitContainer4);
			this.SplitContainer3.Panel2.Controls.Add(this.Button2);
			this.SplitContainer3.Panel2MinSize = 100;
			Control splitContainer9 = this.SplitContainer3;
			size = new Size(560, 620);
			splitContainer9.Size = size;
			this.SplitContainer3.SplitterDistance = 61;
			this.SplitContainer3.SplitterWidth = 1;
			this.SplitContainer3.TabIndex = 0;
			this.Button7.BackColor = SystemColors.ButtonFace;
			Control button5 = this.Button7;
			location = new Point(141, 0);
			button5.Location = location;
			this.Button7.Name = "Button7";
			Control button6 = this.Button7;
			size = new Size(87, 20);
			button6.Size = size;
			this.Button7.TabIndex = 11;
			this.Button7.Text = "清除背景图片";
			this.Button7.UseVisualStyleBackColor = false;
			this.Button7.Visible = false;
			this.P3.BackColor = Color.White;
			this.P3.ContextMenuStrip = this.ContextMenuStrip3;
			this.P3.Dock = DockStyle.Fill;
			Control p7 = this.P3;
			location = new Point(0, 20);
			p7.Location = location;
			Control p8 = this.P3;
			margin = new Padding(0);
			p8.Margin = margin;
			this.P3.Name = "P3";
			Control p9 = this.P3;
			size = new Size(560, 41);
			p9.Size = size;
			this.P3.TabIndex = 3;
			this.P3.TabStop = false;
			this.ContextMenuStrip3.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem_2
			});
			this.ContextMenuStrip3.Name = "ContextMenuStrip3";
			Control contextMenuStrip2 = this.ContextMenuStrip3;
			size = new Size(147, 26);
			contextMenuStrip2.Size = size;
			this.ToolStripMenuItem_2.Name = "清除背景图片ToolStripMenuItem1";
			ToolStripItem toolStripItem2 = this.ToolStripMenuItem_2;
			size = new Size(146, 22);
			toolStripItem2.Size = size;
			this.ToolStripMenuItem_2.Text = "清除背景图片";
			this.Label3.BackColor = SystemColors.ControlDark;
			this.Label3.Dock = DockStyle.Top;
			Control label5 = this.Label3;
			location = new Point(0, 0);
			label5.Location = location;
			this.Label3.Name = "Label3";
			Control label6 = this.Label3;
			size = new Size(560, 20);
			label6.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "▼页表头（每页重复打印）";
			this.Label3.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer4.BackColor = Color.Lime;
			this.SplitContainer4.Dock = DockStyle.Fill;
			this.SplitContainer4.FixedPanel = FixedPanel.Panel1;
			Control splitContainer10 = this.SplitContainer4;
			location = new Point(0, 0);
			splitContainer10.Location = location;
			Control splitContainer11 = this.SplitContainer4;
			margin = new Padding(0);
			splitContainer11.Margin = margin;
			this.SplitContainer4.Name = "SplitContainer4";
			this.SplitContainer4.Orientation = Orientation.Horizontal;
			this.SplitContainer4.Panel1.Controls.Add(this.P4);
			this.SplitContainer4.Panel1.Controls.Add(this.Label4);
			this.SplitContainer4.Panel1MinSize = 20;
			this.SplitContainer4.Panel2.Controls.Add(this.SplitContainer5);
			this.SplitContainer4.Panel2MinSize = 80;
			Control splitContainer12 = this.SplitContainer4;
			size = new Size(560, 558);
			splitContainer12.Size = size;
			this.SplitContainer4.SplitterWidth = 1;
			this.SplitContainer4.TabIndex = 4;
			this.P4.BackColor = Color.White;
			this.P4.Dock = DockStyle.Fill;
			Control p10 = this.P4;
			location = new Point(0, 20);
			p10.Location = location;
			Control p11 = this.P4;
			margin = new Padding(0);
			p11.Margin = margin;
			this.P4.Name = "P4";
			Control p12 = this.P4;
			size = new Size(560, 30);
			p12.Size = size;
			this.P4.TabIndex = 7;
			this.P4.TabStop = false;
			this.Label4.BackColor = SystemColors.ControlDark;
			this.Label4.Dock = DockStyle.Top;
			Control label7 = this.Label4;
			location = new Point(0, 0);
			label7.Location = location;
			this.Label4.Name = "Label4";
			Control label8 = this.Label4;
			size = new Size(560, 20);
			label8.Size = size;
			this.Label4.TabIndex = 6;
			this.Label4.Text = "▼表格详细内容";
			this.Label4.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer5.BackColor = Color.Lime;
			this.SplitContainer5.Dock = DockStyle.Fill;
			this.SplitContainer5.FixedPanel = FixedPanel.Panel1;
			Control splitContainer13 = this.SplitContainer5;
			location = new Point(0, 0);
			splitContainer13.Location = location;
			Control splitContainer14 = this.SplitContainer5;
			margin = new Padding(0);
			splitContainer14.Margin = margin;
			this.SplitContainer5.Name = "SplitContainer5";
			this.SplitContainer5.Orientation = Orientation.Horizontal;
			this.SplitContainer5.Panel1.Controls.Add(this.p5);
			this.SplitContainer5.Panel1.Controls.Add(this.Label5);
			this.SplitContainer5.Panel1MinSize = 20;
			this.SplitContainer5.Panel2.Controls.Add(this.SplitContainer6);
			this.SplitContainer5.Panel2MinSize = 60;
			Control splitContainer15 = this.SplitContainer5;
			size = new Size(560, 507);
			splitContainer15.Size = size;
			this.SplitContainer5.SplitterDistance = 60;
			this.SplitContainer5.SplitterWidth = 1;
			this.SplitContainer5.TabIndex = 4;
			this.p5.BackColor = Color.White;
			this.p5.Dock = DockStyle.Fill;
			Control p13 = this.p5;
			location = new Point(0, 20);
			p13.Location = location;
			this.p5.Name = "p5";
			Control p14 = this.p5;
			size = new Size(560, 40);
			p14.Size = size;
			this.p5.TabIndex = 10;
			this.p5.TabStop = false;
			this.Label5.BackColor = SystemColors.ControlDark;
			this.Label5.Dock = DockStyle.Top;
			Control label9 = this.Label5;
			location = new Point(0, 0);
			label9.Location = location;
			this.Label5.Name = "Label5";
			Control label10 = this.Label5;
			size = new Size(560, 20);
			label10.Size = size;
			this.Label5.TabIndex = 6;
			this.Label5.Text = "▼分组打印内容";
			this.Label5.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer6.BackColor = Color.Lime;
			this.SplitContainer6.Dock = DockStyle.Fill;
			this.SplitContainer6.FixedPanel = FixedPanel.Panel1;
			Control splitContainer16 = this.SplitContainer6;
			location = new Point(0, 0);
			splitContainer16.Location = location;
			Control splitContainer17 = this.SplitContainer6;
			margin = new Padding(0);
			splitContainer17.Margin = margin;
			this.SplitContainer6.Name = "SplitContainer6";
			this.SplitContainer6.Orientation = Orientation.Horizontal;
			this.SplitContainer6.Panel1.Controls.Add(this.P6);
			this.SplitContainer6.Panel1.Controls.Add(this.Label6);
			this.SplitContainer6.Panel1MinSize = 20;
			this.SplitContainer6.Panel2.Controls.Add(this.SplitContainer7);
			this.SplitContainer6.Panel2MinSize = 40;
			Control splitContainer18 = this.SplitContainer6;
			size = new Size(560, 446);
			splitContainer18.Size = size;
			this.SplitContainer6.SplitterDistance = 58;
			this.SplitContainer6.SplitterWidth = 1;
			this.SplitContainer6.TabIndex = 4;
			this.P6.BackColor = Color.White;
			this.P6.Dock = DockStyle.Fill;
			Control p15 = this.P6;
			location = new Point(0, 20);
			p15.Location = location;
			Control p16 = this.P6;
			margin = new Padding(0);
			p16.Margin = margin;
			this.P6.Name = "P6";
			Control p17 = this.P6;
			size = new Size(560, 38);
			p17.Size = size;
			this.P6.TabIndex = 9;
			this.P6.TabStop = false;
			this.Label6.BackColor = SystemColors.ControlDark;
			this.Label6.Dock = DockStyle.Top;
			Control label11 = this.Label6;
			location = new Point(0, 0);
			label11.Location = location;
			this.Label6.Name = "Label6";
			Control label12 = this.Label6;
			size = new Size(560, 20);
			label12.Size = size;
			this.Label6.TabIndex = 8;
			this.Label6.Text = "▼页表尾（打印在每页的表格下面，每页重复打印）";
			this.Label6.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer7.BackColor = Color.Lime;
			this.SplitContainer7.Dock = DockStyle.Fill;
			this.SplitContainer7.FixedPanel = FixedPanel.Panel1;
			Control splitContainer19 = this.SplitContainer7;
			location = new Point(0, 0);
			splitContainer19.Location = location;
			Control splitContainer20 = this.SplitContainer7;
			margin = new Padding(0);
			splitContainer20.Margin = margin;
			this.SplitContainer7.Name = "SplitContainer7";
			this.SplitContainer7.Orientation = Orientation.Horizontal;
			this.SplitContainer7.Panel1.Controls.Add(this.p7);
			this.SplitContainer7.Panel1.Controls.Add(this.Label7);
			this.SplitContainer7.Panel1MinSize = 20;
			this.SplitContainer7.Panel2.BackColor = SystemColors.ButtonFace;
			this.SplitContainer7.Panel2.Controls.Add(this.SplitContainer8);
			this.SplitContainer7.Panel2MinSize = 20;
			Control splitContainer21 = this.SplitContainer7;
			size = new Size(560, 387);
			splitContainer21.Size = size;
			this.SplitContainer7.SplitterDistance = 65;
			this.SplitContainer7.SplitterWidth = 1;
			this.SplitContainer7.TabIndex = 0;
			this.p7.BackColor = Color.White;
			this.p7.Dock = DockStyle.Fill;
			Control p18 = this.p7;
			location = new Point(0, 20);
			p18.Location = location;
			Control p19 = this.p7;
			margin = new Padding(0);
			p19.Margin = margin;
			this.p7.Name = "p7";
			Control p20 = this.p7;
			size = new Size(560, 45);
			p20.Size = size;
			this.p7.TabIndex = 9;
			this.p7.TabStop = false;
			this.Label7.BackColor = SystemColors.ControlDark;
			this.Label7.Dock = DockStyle.Top;
			Control label13 = this.Label7;
			location = new Point(0, 0);
			label13.Location = location;
			this.Label7.Name = "Label7";
			Control label14 = this.Label7;
			size = new Size(560, 20);
			label14.Size = size;
			this.Label7.TabIndex = 8;
			this.Label7.Text = "▼报表尾（打印在整个表格的最后一页，仅打印一次）";
			this.Label7.TextAlign = ContentAlignment.MiddleLeft;
			this.SplitContainer8.BackColor = Color.Lime;
			this.SplitContainer8.Dock = DockStyle.Fill;
			this.SplitContainer8.FixedPanel = FixedPanel.Panel1;
			Control splitContainer22 = this.SplitContainer8;
			location = new Point(0, 0);
			splitContainer22.Location = location;
			Control splitContainer23 = this.SplitContainer8;
			margin = new Padding(0);
			splitContainer23.Margin = margin;
			this.SplitContainer8.Name = "SplitContainer8";
			this.SplitContainer8.Orientation = Orientation.Horizontal;
			this.SplitContainer8.Panel1.Controls.Add(this.P8);
			this.SplitContainer8.Panel1.Controls.Add(this.Label8);
			this.SplitContainer8.Panel1MinSize = 20;
			this.SplitContainer8.Panel2.BackColor = SystemColors.ButtonFace;
			this.SplitContainer8.Panel2MinSize = 0;
			Control splitContainer24 = this.SplitContainer8;
			size = new Size(560, 321);
			splitContainer24.Size = size;
			this.SplitContainer8.SplitterDistance = 101;
			this.SplitContainer8.SplitterWidth = 1;
			this.SplitContainer8.TabIndex = 0;
			this.P8.BackColor = Color.White;
			this.P8.Dock = DockStyle.Fill;
			Control p21 = this.P8;
			location = new Point(0, 20);
			p21.Location = location;
			Control p22 = this.P8;
			margin = new Padding(0);
			p22.Margin = margin;
			this.P8.Name = "P8";
			Control p23 = this.P8;
			size = new Size(560, 81);
			p23.Size = size;
			this.P8.TabIndex = 13;
			this.P8.TabStop = false;
			this.Label8.BackColor = SystemColors.ControlDark;
			this.Label8.Dock = DockStyle.Top;
			Control label15 = this.Label8;
			location = new Point(0, 0);
			label15.Location = location;
			this.Label8.Name = "Label8";
			Control label16 = this.Label8;
			size = new Size(560, 20);
			label16.Size = size;
			this.Label8.TabIndex = 12;
			this.Label8.Text = "▼页面页脚（每页重复打印）";
			this.Label8.TextAlign = ContentAlignment.MiddleLeft;
			Control button7 = this.Button2;
			location = new Point(195, 39);
			button7.Location = location;
			this.Button2.Name = "Button2";
			Control button8 = this.Button2;
			size = new Size(75, 23);
			button8.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem_0
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			Control contextMenuStrip3 = this.ContextMenuStrip1;
			size = new Size(123, 26);
			contextMenuStrip3.Size = size;
			this.ToolStripMenuItem_0.Name = "清除图片ToolStripMenuItem";
			ToolStripItem toolStripItem3 = this.ToolStripMenuItem_0;
			size = new Size(122, 22);
			toolStripItem3.Size = size;
			this.ToolStripMenuItem_0.Text = "清除图片";
			this.pp.Dock = DockStyle.Fill;
			this.pp.FixedPanel = FixedPanel.Panel2;
			Control pp = this.pp;
			location = new Point(0, 0);
			pp.Location = location;
			Control pp2 = this.pp;
			margin = new Padding(0);
			pp2.Margin = margin;
			this.pp.Name = "pp";
			this.pp.Panel1.BackColor = SystemColors.ButtonFace;
			this.pp.Panel1.Controls.Add(this.sh);
			this.pp.Panel1.Controls.Add(this.sv);
			this.pp.Panel1.Controls.Add(this.shape1);
			this.pp.Panel1.Controls.Add(this.L1);
			this.pp.Panel1.Controls.Add(this.l2);
			this.pp.Panel1.Controls.Add(this.rh);
			this.pp.Panel1.Controls.Add(this.rv);
			this.pp.Panel1.Controls.Add(this.SplitContainer1);
			this.pp.Panel1.Controls.Add(this.Button1);
			this.pp.Panel2.Controls.Add(this.SplitContainer9);
			Control pp3 = this.pp;
			size = new Size(889, 620);
			pp3.Size = size;
			this.pp.SplitterDistance = 709;
			this.pp.TabIndex = 10;
			this.shape1.BackColor = Color.Red;
			this.shape1.BorderStyle = BorderStyle.FixedSingle;
			Control shape = this.shape1;
			location = new Point(25, 75);
			shape.Location = location;
			this.shape1.Name = "shape1";
			Control shape2 = this.shape1;
			size = new Size(60, 41);
			shape2.Size = size;
			this.shape1.TabIndex = 10;
			this.shape1.Visible = false;
			this.L1.BackColor = Color.Red;
			this.L1.Cursor = Cursors.SizeNS;
			Control l3 = this.L1;
			location = new Point(23, 48);
			l3.Location = location;
			this.L1.Name = "L1";
			Control l4 = this.L1;
			size = new Size(16, 5);
			l4.Size = size;
			this.L1.TabIndex = 8;
			this.L1.Visible = false;
			this.rh.BackColor = Color.White;
			this.rh.BorderStyle = BorderStyle.Fixed3D;
			this.rh.Cursor = Cursors.Default;
			this.rh.Direction = true;
			this.rh.IsUserCentimeter = false;
			this.rh.LineColor = Color.Blue;
			Control rh = this.rh;
			location = new Point(3, 175);
			rh.Location = location;
			this.rh.Name = "rh";
			Control rh2 = this.rh;
			size = new Size(282, 30);
			rh2.Size = size;
			this.rh.TabIndex = 0;
			this.rh.TextColor = Color.Red;
			this.rv.BackColor = Color.White;
			this.rv.BorderStyle = BorderStyle.Fixed3D;
			this.rv.Cursor = Cursors.Default;
			this.rv.Direction = false;
			this.rv.IsUserCentimeter = false;
			this.rv.LineColor = Color.Blue;
			Control rv = this.rv;
			location = new Point(11, 219);
			rv.Location = location;
			this.rv.Name = "rv";
			Control rv2 = this.rv;
			size = new Size(26, 242);
			rv2.Size = size;
			this.rv.TabIndex = 1;
			this.rv.TextColor = Color.Red;
			this.SplitContainer9.Dock = DockStyle.Fill;
			this.SplitContainer9.FixedPanel = FixedPanel.Panel1;
			Control splitContainer25 = this.SplitContainer9;
			location = new Point(0, 0);
			splitContainer25.Location = location;
			this.SplitContainer9.Name = "SplitContainer9";
			this.SplitContainer9.Orientation = Orientation.Horizontal;
			this.SplitContainer9.Panel1.Controls.Add(this.SplitContainer10);
			this.SplitContainer9.Panel1.Controls.Add(this.Label11);
			this.SplitContainer9.Panel2.Controls.Add(this.PropertyGrid1);
			this.SplitContainer9.Panel2.Controls.Add(this.sx);
			Control splitContainer26 = this.SplitContainer9;
			size = new Size(176, 620);
			splitContainer26.Size = size;
			this.SplitContainer9.SplitterDistance = 184;
			this.SplitContainer9.TabIndex = 1;
			this.SplitContainer10.Dock = DockStyle.Fill;
			this.SplitContainer10.ForeColor = SystemColors.ControlText;
			Control splitContainer27 = this.SplitContainer10;
			location = new Point(0, 23);
			splitContainer27.Location = location;
			this.SplitContainer10.Name = "SplitContainer10";
			this.SplitContainer10.Panel1.Controls.Add(this.Button3);
			this.SplitContainer10.Panel1.Controls.Add(this.Button31);
			this.SplitContainer10.Panel1.Controls.Add(this.Button22);
			this.SplitContainer10.Panel1.Controls.Add(this.Button23);
			this.SplitContainer10.Panel1.Controls.Add(this.Button21);
			this.SplitContainer10.Panel1.Controls.Add(this.Button29);
			this.SplitContainer10.Panel1.Controls.Add(this.Button20);
			this.SplitContainer10.Panel2.Controls.Add(this.Button4);
			this.SplitContainer10.Panel2.Controls.Add(this.Button25);
			this.SplitContainer10.Panel2.Controls.Add(this.Button30);
			this.SplitContainer10.Panel2.Controls.Add(this.Button28);
			this.SplitContainer10.Panel2.Controls.Add(this.Button26);
			this.SplitContainer10.Panel2.Controls.Add(this.Button24);
			this.SplitContainer10.Panel2.Controls.Add(this.Button27);
			Control splitContainer28 = this.SplitContainer10;
			size = new Size(176, 161);
			splitContainer28.Size = size;
			this.SplitContainer10.SplitterDistance = 86;
			this.SplitContainer10.SplitterWidth = 2;
			this.SplitContainer10.TabIndex = 3;
			this.Button3.Dock = DockStyle.Top;
			this.Button3.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button3.Image = Properties.Resources.fbias;
			Control button9 = this.Button3;
			location = new Point(0, 138);
			button9.Location = location;
			this.Button3.Name = "Button3";
			Control button10 = this.Button3;
			size = new Size(86, 23);
			button10.Size = size;
			this.Button3.TabIndex = 3;
			this.Button3.Text = "反斜线";
			this.Button3.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button3.UseVisualStyleBackColor = true;
			this.Button31.Dock = DockStyle.Top;
			this.Button31.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button31.Image = Properties.Resources.ellipse;
			Control button11 = this.Button31;
			location = new Point(0, 115);
			button11.Location = location;
			this.Button31.Name = "Button31";
			Control button12 = this.Button31;
			size = new Size(86, 23);
			button12.Size = size;
			this.Button31.TabIndex = 2;
			this.Button31.Text = "椭圆";
			this.Button31.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button31.UseVisualStyleBackColor = true;
			this.Button22.Dock = DockStyle.Top;
			this.Button22.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button22.Image = Properties.Resources.LINE2;
			Control button13 = this.Button22;
			location = new Point(0, 92);
			button13.Location = location;
			this.Button22.Name = "Button22";
			Control button14 = this.Button22;
			size = new Size(86, 23);
			button14.Size = size;
			this.Button22.TabIndex = 1;
			this.Button22.Text = "竖线";
			this.Button22.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button22.UseVisualStyleBackColor = true;
			this.Button23.Dock = DockStyle.Top;
			this.Button23.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button23.Image = Properties.Resources.rect1;
			Control button15 = this.Button23;
			location = new Point(0, 69);
			button15.Location = location;
			this.Button23.Name = "Button23";
			Control button16 = this.Button23;
			size = new Size(86, 23);
			button16.Size = size;
			this.Button23.TabIndex = 1;
			this.Button23.Text = "矩形";
			this.Button23.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button23.UseVisualStyleBackColor = true;
			this.Button21.Dock = DockStyle.Top;
			this.Button21.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button21.Image = Properties.Resources.LINE1;
			Control button17 = this.Button21;
			location = new Point(0, 46);
			button17.Location = location;
			this.Button21.Name = "Button21";
			Control button18 = this.Button21;
			size = new Size(86, 23);
			button18.Size = size;
			this.Button21.TabIndex = 1;
			this.Button21.Text = "横线";
			this.Button21.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button21.UseVisualStyleBackColor = true;
			this.Button29.Dock = DockStyle.Top;
			this.Button29.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button29.Image = Properties.Resources.bias;
			Control button19 = this.Button29;
			location = new Point(0, 23);
			button19.Location = location;
			this.Button29.Name = "Button29";
			Control button20 = this.Button29;
			size = new Size(86, 23);
			button20.Size = size;
			this.Button29.TabIndex = 1;
			this.Button29.Text = "斜线";
			this.Button29.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button29.UseVisualStyleBackColor = true;
			this.Button20.Dock = DockStyle.Top;
			this.Button20.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button20.Image = Properties.Resources.Pointer;
			Control button21 = this.Button20;
			location = new Point(0, 0);
			button21.Location = location;
			this.Button20.Name = "Button20";
			Control button22 = this.Button20;
			size = new Size(86, 23);
			button22.Size = size;
			this.Button20.TabIndex = 1;
			this.Button20.Text = "指针";
			this.Button20.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button20.UseVisualStyleBackColor = true;
			this.Button4.Dock = DockStyle.Top;
			this.Button4.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button4.Image = Properties.Resources.barcode_2d;
			Control button23 = this.Button4;
			location = new Point(0, 138);
			button23.Location = location;
			this.Button4.Name = "Button4";
			Control button24 = this.Button4;
			size = new Size(88, 23);
			button24.Size = size;
			this.Button4.TabIndex = 3;
			this.Button4.Text = "二维码";
			this.Button4.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button4.UseVisualStyleBackColor = true;
			this.Button25.Dock = DockStyle.Top;
			this.Button25.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button25.Image = Properties.Resources.DBText;
			Control button25 = this.Button25;
			location = new Point(0, 115);
			button25.Location = location;
			this.Button25.Name = "Button25";
			Control button26 = this.Button25;
			size = new Size(88, 23);
			button26.Size = size;
			this.Button25.TabIndex = 1;
			this.Button25.Text = "数据字段";
			this.Button25.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.ToolTip1.SetToolTip(this.Button25, "与DataGridView中的某列绑定，自动根据该列取数（如果该列为图片则会自动打印图片，如果该列为复选框，则自动打印筛选框）");
			this.Button25.UseVisualStyleBackColor = true;
			this.Button30.Dock = DockStyle.Top;
			this.Button30.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button30.Image = Properties.Resources.ExpressionLabel;
			Control button27 = this.Button30;
			location = new Point(0, 92);
			button27.Location = location;
			this.Button30.Name = "Button30";
			Control button28 = this.Button30;
			size = new Size(88, 23);
			button28.Size = size;
			this.Button30.TabIndex = 2;
			this.Button30.Text = "表达式";
			this.Button30.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.ToolTip1.SetToolTip(this.Button30, "可以包含数据字段、自定义变量、系统变量及.NET常用系统函数的计算表达式。\r\n此控件功能强大，请注意，表达式控件的内容是在生成报表数据时动态编译计算的，因此速度比较慢。\r\n但是,控件4.8版对此控件进行了优化,如果表达式内是简单的四则运算及带括号运行,速度会非常快。");
			this.Button30.UseVisualStyleBackColor = true;
			this.Button28.Dock = DockStyle.Top;
			this.Button28.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button28.Image = Properties.Resources.BarCode;
			Control button29 = this.Button28;
			location = new Point(0, 69);
			button29.Location = location;
			this.Button28.Name = "Button28";
			Control button30 = this.Button28;
			size = new Size(88, 23);
			button30.Size = size;
			this.Button28.TabIndex = 1;
			this.Button28.Text = "条形码";
			this.Button28.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button28.UseVisualStyleBackColor = true;
			this.Button26.Dock = DockStyle.Top;
			this.Button26.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button26.Image = Properties.Resources.Image;
			Control button31 = this.Button26;
			location = new Point(0, 46);
			button31.Location = location;
			this.Button26.Name = "Button26";
			Control button32 = this.Button26;
			size = new Size(88, 23);
			button32.Size = size;
			this.Button26.TabIndex = 1;
			this.Button26.Text = "图片";
			this.Button26.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button26.UseVisualStyleBackColor = true;
			this.Button24.Dock = DockStyle.Top;
			this.Button24.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button24.Image = Properties.Resources.Label;
			Control button33 = this.Button24;
			location = new Point(0, 23);
			button33.Location = location;
			this.Button24.Name = "Button24";
			Control button34 = this.Button24;
			size = new Size(88, 23);
			button34.Size = size;
			this.Button24.TabIndex = 1;
			this.Button24.Text = "文本";
			this.Button24.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.ToolTip1.SetToolTip(this.Button24, "可以由文本、系统变量、自定义变量和数据字段自由组合");
			this.Button24.UseVisualStyleBackColor = true;
			this.Button27.Dock = DockStyle.Top;
			this.Button27.FlatAppearance.MouseDownBackColor = Color.Blue;
			this.Button27.Image = Properties.Resources.ExpressionLabel;
			Control button35 = this.Button27;
			location = new Point(0, 0);
			button35.Location = location;
			this.Button27.Name = "Button27";
			Control button36 = this.Button27;
			size = new Size(88, 23);
			button36.Size = size;
			this.Button27.TabIndex = 1;
			this.Button27.Text = "计算公式";
			this.Button27.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.ToolTip1.SetToolTip(this.Button27, "可对固定字段进行求和、求最大值、求最小值及平均值等功能表达式");
			this.Button27.UseVisualStyleBackColor = true;
			this.Label11.BackColor = Color.FromArgb(128, 255, 128);
			this.Label11.BorderStyle = BorderStyle.FixedSingle;
			this.Label11.Dock = DockStyle.Top;
			Control label17 = this.Label11;
			location = new Point(0, 0);
			label17.Location = location;
			this.Label11.Name = "Label11";
			Control label18 = this.Label11;
			size = new Size(176, 23);
			label18.Size = size;
			this.Label11.TabIndex = 0;
			this.Label11.Text = "控件工具栏";
			this.Label11.TextAlign = ContentAlignment.MiddleCenter;
			this.PropertyGrid1.CommandsVisibleIfAvailable = false;
			this.PropertyGrid1.Dock = DockStyle.Fill;
			Control propertyGrid = this.PropertyGrid1;
			location = new Point(0, 25);
			propertyGrid.Location = location;
			this.PropertyGrid1.Name = "PropertyGrid1";
			Control propertyGrid2 = this.PropertyGrid1;
			size = new Size(176, 407);
			propertyGrid2.Size = size;
			this.PropertyGrid1.TabIndex = 0;
			this.sx.BackColor = Color.FromArgb(128, 255, 128);
			this.sx.BorderStyle = BorderStyle.Fixed3D;
			this.sx.Dock = DockStyle.Top;
			Control sx = this.sx;
			location = new Point(0, 0);
			sx.Location = location;
			this.sx.Name = "sx";
			Control sx2 = this.sx;
			size = new Size(176, 25);
			sx2.Size = size;
			this.sx.TabIndex = 1;
			this.sx.Text = "控件属性：";
			this.sx.TextAlign = ContentAlignment.MiddleLeft;
			this.o1.FileName = "OpenFileDialog1";
			this.o1.Filter = "图片文件(*.bmp,*.jpg,*.gif)|*.bmp;*.jpg;*.gif";
			this.o1.Title = "选择背景图片";
			this.s2.Filter = " 打印模板文件(*.mb)|*.mb";
			this.s2.Title = "选择要保存的模板文件名";
			this.o2.FileName = "o2";
			this.o2.Filter = "打印模板文件(*.mb)|*.mb";
			this.o2.Title = "选择要打开的模板文件";
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.pp);
			this.DoubleBuffered = true;
			this.Name = "ControlDesign";
			size = new Size(889, 620);
			this.Size = size;
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			((ISupportInitialize)this.P1).EndInit();
			this.SplitContainer2.Panel1.ResumeLayout(false);
			this.SplitContainer2.Panel2.ResumeLayout(false);
			this.SplitContainer2.ResumeLayout(false);
			((ISupportInitialize)this.P2).EndInit();
			this.ContextMenuStrip2.ResumeLayout(false);
			this.SplitContainer3.Panel1.ResumeLayout(false);
			this.SplitContainer3.Panel2.ResumeLayout(false);
			this.SplitContainer3.ResumeLayout(false);
			((ISupportInitialize)this.P3).EndInit();
			this.ContextMenuStrip3.ResumeLayout(false);
			this.SplitContainer4.Panel1.ResumeLayout(false);
			this.SplitContainer4.Panel2.ResumeLayout(false);
			this.SplitContainer4.ResumeLayout(false);
			((ISupportInitialize)this.P4).EndInit();
			this.SplitContainer5.Panel1.ResumeLayout(false);
			this.SplitContainer5.Panel2.ResumeLayout(false);
			this.SplitContainer5.ResumeLayout(false);
			((ISupportInitialize)this.p5).EndInit();
			this.SplitContainer6.Panel1.ResumeLayout(false);
			this.SplitContainer6.Panel2.ResumeLayout(false);
			this.SplitContainer6.ResumeLayout(false);
			((ISupportInitialize)this.P6).EndInit();
			this.SplitContainer7.Panel1.ResumeLayout(false);
			this.SplitContainer7.Panel2.ResumeLayout(false);
			this.SplitContainer7.ResumeLayout(false);
			((ISupportInitialize)this.p7).EndInit();
			this.SplitContainer8.Panel1.ResumeLayout(false);
			this.SplitContainer8.ResumeLayout(false);
			((ISupportInitialize)this.P8).EndInit();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.pp.Panel1.ResumeLayout(false);
			this.pp.Panel2.ResumeLayout(false);
			this.pp.ResumeLayout(false);
			this.SplitContainer9.Panel1.ResumeLayout(false);
			this.SplitContainer9.Panel2.ResumeLayout(false);
			this.SplitContainer9.ResumeLayout(false);
			this.SplitContainer10.Panel1.ResumeLayout(false);
			this.SplitContainer10.Panel2.ResumeLayout(false);
			this.SplitContainer10.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0003D2B4 File Offset: 0x0003B4B4
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00003882 File Offset: 0x00001A82
		internal virtual Ruler rh
		{
			get
			{
				return this._rh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rh = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000388B File Offset: 0x00001A8B
		internal virtual Ruler rv
		{
			get
			{
				return this._rv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rv = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0003D2E4 File Offset: 0x0003B4E4
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0003D2FC File Offset: 0x0003B4FC
		internal virtual VScrollBar sv
		{
			get
			{
				return this._sv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sv_ValueChanged);
				if (this._sv != null)
				{
					this._sv.ValueChanged -= value2;
				}
				this._sv = value;
				if (this._sv != null)
				{
					this._sv.ValueChanged += value2;
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0003D348 File Offset: 0x0003B548
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0003D360 File Offset: 0x0003B560
		internal virtual HScrollBar sh
		{
			get
			{
				return this._sh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sh_ValueChanged);
				if (this._sh != null)
				{
					this._sh.ValueChanged -= value2;
				}
				this._sh = value;
				if (this._sh != null)
				{
					this._sh.ValueChanged += value2;
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0003D410 File Offset: 0x0003B610
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0003D428 File Offset: 0x0003B628
		internal virtual Label l2
		{
			get
			{
				return this._l2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.l2_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.l2_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.l2_MouseDown);
				if (this._l2 != null)
				{
					this._l2.MouseUp -= value2;
					this._l2.MouseMove -= value3;
					this._l2.MouseDown -= value4;
				}
				this._l2 = value;
				if (this._l2 != null)
				{
					this._l2.MouseUp += value2;
					this._l2.MouseMove += value3;
					this._l2.MouseDown += value4;
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0003D4C0 File Offset: 0x0003B6C0
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		internal virtual SplitContainer SplitContainer1
		{
			get
			{
				return this._SplitContainer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer1 != null)
				{
					this._SplitContainer1.SplitterMoved -= value2;
				}
				this._SplitContainer1 = value;
				if (this._SplitContainer1 != null)
				{
					this._SplitContainer1.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0003D524 File Offset: 0x0003B724
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0003D53C File Offset: 0x0003B73C
		internal virtual PictureBox P1
		{
			get
			{
				return this._P1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P1 != null)
				{
					this._P1.MouseUp -= value2;
					this._P1.MouseMove -= value3;
					this._P1.MouseDown -= value4;
					this._P1.MouseClick -= value5;
					this._P1.Click -= value6;
				}
				this._P1 = value;
				if (this._P1 != null)
				{
					this._P1.MouseUp += value2;
					this._P1.MouseMove += value3;
					this._P1.MouseDown += value4;
					this._P1.MouseClick += value5;
					this._P1.Click += value6;
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0003D624 File Offset: 0x0003B824
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0003D63C File Offset: 0x0003B83C
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label1 != null)
				{
					this._Label1.Click -= value2;
				}
				this._Label1 = value;
				if (this._Label1 != null)
				{
					this._Label1.Click += value2;
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0003D688 File Offset: 0x0003B888
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0003D6A0 File Offset: 0x0003B8A0
		internal virtual SplitContainer SplitContainer2
		{
			get
			{
				return this._SplitContainer2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer2 != null)
				{
					this._SplitContainer2.SplitterMoved -= value2;
				}
				this._SplitContainer2 = value;
				if (this._SplitContainer2 != null)
				{
					this._SplitContainer2.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0003D6EC File Offset: 0x0003B8EC
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0003D704 File Offset: 0x0003B904
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label2 != null)
				{
					this._Label2.Click -= value2;
				}
				this._Label2 = value;
				if (this._Label2 != null)
				{
					this._Label2.Click += value2;
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0003D750 File Offset: 0x0003B950
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0003D768 File Offset: 0x0003B968
		internal virtual SplitContainer SplitContainer3
		{
			get
			{
				return this._SplitContainer3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer3 != null)
				{
					this._SplitContainer3.SplitterMoved -= value2;
				}
				this._SplitContainer3 = value;
				if (this._SplitContainer3 != null)
				{
					this._SplitContainer3.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0003D7CC File Offset: 0x0003B9CC
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label3 != null)
				{
					this._Label3.Click -= value2;
				}
				this._Label3 = value;
				if (this._Label3 != null)
				{
					this._Label3.Click += value2;
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0003D818 File Offset: 0x0003BA18
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0003D830 File Offset: 0x0003BA30
		internal virtual PictureBox P2
		{
			get
			{
				return this._P2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P2 != null)
				{
					this._P2.MouseUp -= value2;
					this._P2.MouseMove -= value3;
					this._P2.MouseDown -= value4;
					this._P2.MouseClick -= value5;
					this._P2.Click -= value6;
				}
				this._P2 = value;
				if (this._P2 != null)
				{
					this._P2.MouseUp += value2;
					this._P2.MouseMove += value3;
					this._P2.MouseDown += value4;
					this._P2.MouseClick += value5;
					this._P2.Click += value6;
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0003D918 File Offset: 0x0003BB18
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0003D930 File Offset: 0x0003BB30
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0003D97C File Offset: 0x0003BB7C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0003D994 File Offset: 0x0003BB94
		internal virtual PictureBox P3
		{
			get
			{
				return this._P3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P3 != null)
				{
					this._P3.MouseUp -= value2;
					this._P3.MouseMove -= value3;
					this._P3.MouseDown -= value4;
					this._P3.MouseClick -= value5;
					this._P3.Click -= value6;
				}
				this._P3 = value;
				if (this._P3 != null)
				{
					this._P3.MouseUp += value2;
					this._P3.MouseMove += value3;
					this._P3.MouseDown += value4;
					this._P3.MouseClick += value5;
					this._P3.Click += value6;
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0003DA94 File Offset: 0x0003BC94
		internal virtual SplitContainer SplitContainer4
		{
			get
			{
				return this._SplitContainer4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer4 != null)
				{
					this._SplitContainer4.SplitterMoved -= value2;
				}
				this._SplitContainer4 = value;
				if (this._SplitContainer4 != null)
				{
					this._SplitContainer4.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0003DAF8 File Offset: 0x0003BCF8
		internal virtual SplitContainer SplitContainer5
		{
			get
			{
				return this._SplitContainer5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer5 != null)
				{
					this._SplitContainer5.SplitterMoved -= value2;
				}
				this._SplitContainer5 = value;
				if (this._SplitContainer5 != null)
				{
					this._SplitContainer5.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0003DB44 File Offset: 0x0003BD44
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0003DB5C File Offset: 0x0003BD5C
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label5 != null)
				{
					this._Label5.Click -= value2;
				}
				this._Label5 = value;
				if (this._Label5 != null)
				{
					this._Label5.Click += value2;
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
		internal virtual SplitContainer SplitContainer6
		{
			get
			{
				return this._SplitContainer6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer6 != null)
				{
					this._SplitContainer6.SplitterMoved -= value2;
				}
				this._SplitContainer6 = value;
				if (this._SplitContainer6 != null)
				{
					this._SplitContainer6.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0003DC0C File Offset: 0x0003BE0C
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0003DC24 File Offset: 0x0003BE24
		internal virtual PictureBox P6
		{
			get
			{
				return this._P6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P6 != null)
				{
					this._P6.MouseUp -= value2;
					this._P6.MouseMove -= value3;
					this._P6.MouseDown -= value4;
					this._P6.MouseClick -= value5;
					this._P6.Click -= value6;
				}
				this._P6 = value;
				if (this._P6 != null)
				{
					this._P6.MouseUp += value2;
					this._P6.MouseMove += value3;
					this._P6.MouseDown += value4;
					this._P6.MouseClick += value5;
					this._P6.Click += value6;
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0003DD24 File Offset: 0x0003BF24
		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label6 != null)
				{
					this._Label6.Click -= value2;
				}
				this._Label6 = value;
				if (this._Label6 != null)
				{
					this._Label6.Click += value2;
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0003DD70 File Offset: 0x0003BF70
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0003DD88 File Offset: 0x0003BF88
		internal virtual SplitContainer pp
		{
			get
			{
				return this._pp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				EventHandler value5 = new EventHandler(this.p_Click);
				EventHandler value6 = new EventHandler(this.ControlDesign_Resize);
				if (this._pp != null)
				{
					this._pp.Panel1.MouseUp -= value2;
					this._pp.Panel1.MouseMove -= value3;
					this._pp.Panel1.MouseDown -= value4;
					this._pp.Panel1.Click -= value5;
					this._pp.Panel1.Resize -= value6;
				}
				this._pp = value;
				if (this._pp != null)
				{
					this._pp.Panel1.MouseUp += value2;
					this._pp.Panel1.MouseMove += value3;
					this._pp.Panel1.MouseDown += value4;
					this._pp.Panel1.Click += value5;
					this._pp.Panel1.Resize += value6;
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0003DEA0 File Offset: 0x0003C0A0
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		internal virtual PropertyGrid PropertyGrid1
		{
			get
			{
				return this._PropertyGrid1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectedGridItemChangedEventHandler value2 = new SelectedGridItemChangedEventHandler(this.PropertyGrid1_SelectedGridItemChanged);
				if (this._PropertyGrid1 != null)
				{
					this._PropertyGrid1.SelectedGridItemChanged -= value2;
				}
				this._PropertyGrid1 = value;
				if (this._PropertyGrid1 != null)
				{
					this._PropertyGrid1.SelectedGridItemChanged += value2;
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0003DF04 File Offset: 0x0003C104
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00003894 File Offset: 0x00001A94
		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0003DF1C File Offset: 0x0003C11C
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0003DF34 File Offset: 0x0003C134
		internal virtual SplitContainer SplitContainer7
		{
			get
			{
				return this._SplitContainer7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				if (this._SplitContainer7 != null)
				{
					this._SplitContainer7.SplitterMoved -= value2;
				}
				this._SplitContainer7 = value;
				if (this._SplitContainer7 != null)
				{
					this._SplitContainer7.SplitterMoved += value2;
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0003DF80 File Offset: 0x0003C180
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000389D File Offset: 0x00001A9D
		internal virtual Label shape1
		{
			get
			{
				return this._shape1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._shape1 = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0003DF98 File Offset: 0x0003C198
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		internal virtual SplitContainer SplitContainer8
		{
			get
			{
				return this._SplitContainer8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SplitterEventHandler value2 = new SplitterEventHandler(this.SplitContainer1_SplitterMoved);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseDown);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._SplitContainer8 != null)
				{
					this._SplitContainer8.SplitterMoved -= value2;
					this._SplitContainer8.Panel2.MouseUp -= value3;
					this._SplitContainer8.Panel2.MouseMove -= value4;
					this._SplitContainer8.Panel2.MouseDown -= value5;
					this._SplitContainer8.Panel2.Click -= value6;
				}
				this._SplitContainer8 = value;
				if (this._SplitContainer8 != null)
				{
					this._SplitContainer8.SplitterMoved += value2;
					this._SplitContainer8.Panel2.MouseUp += value3;
					this._SplitContainer8.Panel2.MouseMove += value4;
					this._SplitContainer8.Panel2.MouseDown += value5;
					this._SplitContainer8.Panel2.Click += value6;
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		internal virtual PictureBox P4
		{
			get
			{
				return this._P4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P4 != null)
				{
					this._P4.MouseUp -= value2;
					this._P4.MouseMove -= value3;
					this._P4.MouseDown -= value4;
					this._P4.MouseClick -= value5;
					this._P4.Click -= value6;
				}
				this._P4 = value;
				if (this._P4 != null)
				{
					this._P4.MouseUp += value2;
					this._P4.MouseMove += value3;
					this._P4.MouseDown += value4;
					this._P4.MouseClick += value5;
					this._P4.Click += value6;
				}
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label4 != null)
				{
					this._Label4.Click -= value2;
				}
				this._Label4 = value;
				if (this._Label4 != null)
				{
					this._Label4.Click += value2;
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0003E224 File Offset: 0x0003C424
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0003E23C File Offset: 0x0003C43C
		internal virtual PictureBox p7
		{
			get
			{
				return this._p7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._p7 != null)
				{
					this._p7.MouseUp -= value2;
					this._p7.MouseMove -= value3;
					this._p7.MouseDown -= value4;
					this._p7.MouseClick -= value5;
					this._p7.Click -= value6;
				}
				this._p7 = value;
				if (this._p7 != null)
				{
					this._p7.MouseUp += value2;
					this._p7.MouseMove += value3;
					this._p7.MouseDown += value4;
					this._p7.MouseClick += value5;
					this._p7.Click += value6;
				}
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0003E324 File Offset: 0x0003C524
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0003E33C File Offset: 0x0003C53C
		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label7 != null)
				{
					this._Label7.Click -= value2;
				}
				this._Label7 = value;
				if (this._Label7 != null)
				{
					this._Label7.Click += value2;
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0003E388 File Offset: 0x0003C588
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0003E3A0 File Offset: 0x0003C5A0
		internal virtual PictureBox P8
		{
			get
			{
				return this._P8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._P8 != null)
				{
					this._P8.MouseUp -= value2;
					this._P8.MouseMove -= value3;
					this._P8.MouseDown -= value4;
					this._P8.MouseClick -= value5;
					this._P8.Click -= value6;
				}
				this._P8 = value;
				if (this._P8 != null)
				{
					this._P8.MouseUp += value2;
					this._P8.MouseMove += value3;
					this._P8.MouseDown += value4;
					this._P8.MouseClick += value5;
					this._P8.Click += value6;
				}
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0003E488 File Offset: 0x0003C688
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				if (this._Label8 != null)
				{
					this._Label8.Click -= value2;
				}
				this._Label8 = value;
				if (this._Label8 != null)
				{
					this._Label8.Click += value2;
				}
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0003E4EC File Offset: 0x0003C6EC
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0003E504 File Offset: 0x0003C704
		internal virtual Label L1
		{
			get
			{
				return this._L1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.L1_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.L1_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.l1_MouseDown);
				if (this._L1 != null)
				{
					this._L1.MouseUp -= value2;
					this._L1.MouseMove -= value3;
					this._L1.MouseDown -= value4;
				}
				this._L1 = value;
				if (this._L1 != null)
				{
					this._L1.MouseUp += value2;
					this._L1.MouseMove += value3;
					this._L1.MouseDown += value4;
				}
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0003E59C File Offset: 0x0003C79C
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0003E5B4 File Offset: 0x0003C7B4
		internal virtual Button Button5
		{
			get
			{
				return this._Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				if (this._Button5 != null)
				{
					this._Button5.Click -= value2;
				}
				this._Button5 = value;
				if (this._Button5 != null)
				{
					this._Button5.Click += value2;
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0003E600 File Offset: 0x0003C800
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000038A6 File Offset: 0x00001AA6
		internal virtual OpenFileDialog o1
		{
			get
			{
				return this._o1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._o1 = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0003E618 File Offset: 0x0003C818
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x000038AF File Offset: 0x00001AAF
		internal virtual SaveFileDialog s2
		{
			get
			{
				return this._s2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._s2 = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0003E630 File Offset: 0x0003C830
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000038B8 File Offset: 0x00001AB8
		internal virtual OpenFileDialog o2
		{
			get
			{
				return this._o2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._o2 = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0003E648 File Offset: 0x0003C848
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0003E660 File Offset: 0x0003C860
		internal virtual Button Button7
		{
			get
			{
				return this._Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button7_Click);
				if (this._Button7 != null)
				{
					this._Button7.Click -= value2;
				}
				this._Button7 = value;
				if (this._Button7 != null)
				{
					this._Button7.Click += value2;
				}
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0003E6AC File Offset: 0x0003C8AC
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000038C1 File Offset: 0x00001AC1
		internal virtual SplitContainer SplitContainer9
		{
			get
			{
				return this._SplitContainer9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer9 = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000038CA File Offset: 0x00001ACA
		internal virtual Label sx
		{
			get
			{
				return this._sx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._sx = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0003E6DC File Offset: 0x0003C8DC
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
		internal virtual Button Button20
		{
			get
			{
				return this._Button20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button20 != null)
				{
					this._Button20.Click -= value2;
				}
				this._Button20 = value;
				if (this._Button20 != null)
				{
					this._Button20.Click += value2;
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0003E740 File Offset: 0x0003C940
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x000038D3 File Offset: 0x00001AD3
		internal virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0003E758 File Offset: 0x0003C958
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0003E770 File Offset: 0x0003C970
		internal virtual Button Button26
		{
			get
			{
				return this._Button26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button26 != null)
				{
					this._Button26.Click -= value2;
				}
				this._Button26 = value;
				if (this._Button26 != null)
				{
					this._Button26.Click += value2;
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0003E7BC File Offset: 0x0003C9BC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0003E7D4 File Offset: 0x0003C9D4
		internal virtual Button Button25
		{
			get
			{
				return this._Button25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button25 != null)
				{
					this._Button25.Click -= value2;
				}
				this._Button25 = value;
				if (this._Button25 != null)
				{
					this._Button25.Click += value2;
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0003E820 File Offset: 0x0003CA20
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0003E838 File Offset: 0x0003CA38
		internal virtual Button Button24
		{
			get
			{
				return this._Button24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button24 != null)
				{
					this._Button24.Click -= value2;
				}
				this._Button24 = value;
				if (this._Button24 != null)
				{
					this._Button24.Click += value2;
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0003E884 File Offset: 0x0003CA84
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0003E89C File Offset: 0x0003CA9C
		internal virtual Button Button23
		{
			get
			{
				return this._Button23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button23 != null)
				{
					this._Button23.Click -= value2;
				}
				this._Button23 = value;
				if (this._Button23 != null)
				{
					this._Button23.Click += value2;
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0003E900 File Offset: 0x0003CB00
		internal virtual Button Button22
		{
			get
			{
				return this._Button22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button22 != null)
				{
					this._Button22.Click -= value2;
				}
				this._Button22 = value;
				if (this._Button22 != null)
				{
					this._Button22.Click += value2;
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0003E94C File Offset: 0x0003CB4C
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0003E964 File Offset: 0x0003CB64
		internal virtual Button Button21
		{
			get
			{
				return this._Button21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button21 != null)
				{
					this._Button21.Click -= value2;
				}
				this._Button21 = value;
				if (this._Button21 != null)
				{
					this._Button21.Click += value2;
				}
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0003E9B0 File Offset: 0x0003CBB0
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		internal virtual Button Button29
		{
			get
			{
				return this._Button29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button29 != null)
				{
					this._Button29.Click -= value2;
				}
				this._Button29 = value;
				if (this._Button29 != null)
				{
					this._Button29.Click += value2;
				}
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0003EA14 File Offset: 0x0003CC14
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x0003EA2C File Offset: 0x0003CC2C
		internal virtual Button Button28
		{
			get
			{
				return this._Button28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button28 != null)
				{
					this._Button28.Click -= value2;
				}
				this._Button28 = value;
				if (this._Button28 != null)
				{
					this._Button28.Click += value2;
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0003EA78 File Offset: 0x0003CC78
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0003EA90 File Offset: 0x0003CC90
		internal virtual Button Button27
		{
			get
			{
				return this._Button27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button27 != null)
				{
					this._Button27.Click -= value2;
				}
				this._Button27 = value;
				if (this._Button27 != null)
				{
					this._Button27.Click += value2;
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0003EADC File Offset: 0x0003CCDC
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x000038DC File Offset: 0x00001ADC
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x0003EB0C File Offset: 0x0003CD0C
		internal virtual Button Button30
		{
			get
			{
				return this._Button30;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button30 != null)
				{
					this._Button30.Click -= value2;
				}
				this._Button30 = value;
				if (this._Button30 != null)
				{
					this._Button30.Click += value2;
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0003EB58 File Offset: 0x0003CD58
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000038E5 File Offset: 0x00001AE5
		internal virtual SplitContainer SplitContainer10
		{
			get
			{
				return this._SplitContainer10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer10 = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0003EB70 File Offset: 0x0003CD70
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x0003EB88 File Offset: 0x0003CD88
		internal virtual Button Button31
		{
			get
			{
				return this._Button31;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button31 != null)
				{
					this._Button31.Click -= value2;
				}
				this._Button31 = value;
				if (this._Button31 != null)
				{
					this._Button31.Click += value2;
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0003EBD4 File Offset: 0x0003CDD4
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x0003EBEC File Offset: 0x0003CDEC
		internal virtual PictureBox p5
		{
			get
			{
				return this._p5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.p_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.p_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseClick);
				EventHandler value6 = new EventHandler(this.p_Click);
				if (this._p5 != null)
				{
					this._p5.MouseUp -= value2;
					this._p5.MouseMove -= value3;
					this._p5.MouseDown -= value4;
					this._p5.MouseClick -= value5;
					this._p5.Click -= value6;
				}
				this._p5 = value;
				if (this._p5 != null)
				{
					this._p5.MouseUp += value2;
					this._p5.MouseMove += value3;
					this._p5.MouseDown += value4;
					this._p5.MouseClick += value5;
					this._p5.Click += value6;
				}
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0003ECD4 File Offset: 0x0003CED4
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0003ED38 File Offset: 0x0003CF38
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000038EE File Offset: 0x00001AEE
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this._ContextMenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0003ED50 File Offset: 0x0003CF50
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0003ED68 File Offset: 0x0003CF68
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			get
			{
				return this.toolStripMenuItem_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_0_Click);
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0003EDCC File Offset: 0x0003CFCC
		internal virtual ContextMenuStrip ContextMenuStrip2
		{
			get
			{
				return this._ContextMenuStrip2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.ContextMenuStrip2_Opening);
				if (this._ContextMenuStrip2 != null)
				{
					this._ContextMenuStrip2.Opening -= value2;
				}
				this._ContextMenuStrip2 = value;
				if (this._ContextMenuStrip2 != null)
				{
					this._ContextMenuStrip2.Opening += value2;
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0003EE18 File Offset: 0x0003D018
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0003EE30 File Offset: 0x0003D030
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0003EE7C File Offset: 0x0003D07C
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0003EE94 File Offset: 0x0003D094
		internal virtual ContextMenuStrip ContextMenuStrip3
		{
			get
			{
				return this._ContextMenuStrip3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.ContextMenuStrip3_Opening);
				if (this._ContextMenuStrip3 != null)
				{
					this._ContextMenuStrip3.Opening -= value2;
				}
				this._ContextMenuStrip3 = value;
				if (this._ContextMenuStrip3 != null)
				{
					this._ContextMenuStrip3.Opening += value2;
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0003EEE0 File Offset: 0x0003D0E0
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0003EEF8 File Offset: 0x0003D0F8
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0003EF44 File Offset: 0x0003D144
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0003EF5C File Offset: 0x0003D15C
		internal virtual Button Button4
		{
			get
			{
				return this._Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				if (this._Button4 != null)
				{
					this._Button4.Click -= value2;
				}
				this._Button4 = value;
				if (this._Button4 != null)
				{
					this._Button4.Click += value2;
				}
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		private void ControlDesign_Disposed(object sender, EventArgs e)
		{
			try
			{
				this.CS.Dispose();
				this.myvar = null;
				this.preRect = default(Rectangle);
				this.s_mbcontent = null;
				this.curparent = null;
				this.MyPage = null;
				this.myp1.Dispose();
				this.myp1 = null;
				this.myp2.Dispose();
				this.myp2 = null;
				this.myp3.Dispose();
				this.myp3 = null;
				this.myp4.Dispose();
				this.myp4 = null;
				this.myp5.Dispose();
				this.myp5 = null;
				this.myp6.Dispose();
				this.myp6 = null;
				this.myp7.Dispose();
				this.myp7 = null;
				this.myp8.Dispose();
				this.myp8 = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0003F098 File Offset: 0x0003D298
		public void SetDefaultPosition()
		{
			this.MyPage.LeftMargin = 20f;
			this.MyPage.RightMargin = 20f;
			this.MyPage.TopMargin = 20f;
			this.MyPage.BottomMargin = 20f;
			this.MyPage.PaperName = "A4";
			this.MyPage.Align = StringAlignment.Center;
			this.MyPage.PaperLandScape = false;
			checked
			{
				this.SplitContainer1.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(this.MyPage.TopMargin, false));
				this.SplitContainer2.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer3.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer4.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer5.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer6.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer7.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(10f, false));
				this.SplitContainer8.SplitterDistance = 20 + (int)Math.Round((double)this.rv.ConvertFromMM(this.MyPage.BottomMargin, false));
				this.myp2.BackPictureMode = true;
				this.myp3.BackPictureMode = true;
				this.myp2.BackGroundPicture = null;
				this.myp3.BackGroundPicture = null;
				this.P2.BackgroundImage = null;
				this.P3.BackgroundImage = null;
				this.myp4.Columns = 1;
				this.myp4.AddEmptyRows = false;
				this.myp4.FixedRows = 0;
				this.myp3.Columns = 1;
				this.myp5.GroupNewPage = false;
				this.myp5.GroupField = "";
				this.w_paperwidth = mbsjmodule.G_MB_Default_Width;
				this.SetMbWidthHeight(this.w_paperwidth, this.w_paperheight);
				this.s_width = this.w_paperwidth;
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0003F308 File Offset: 0x0003D508
		public bool IsNeedSave()
		{
			bool result;
			if (this.s_width != this.w_paperwidth)
			{
				result = true;
			}
			else
			{
				string mbcontentAll = this.GetMBContentAll();
				result = (!this.s_mbcontent.Equals(mbcontentAll) && Strings.Len(this.s_mbcontent) != Strings.Len(mbcontentAll));
			}
			return result;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0003F35C File Offset: 0x0003D55C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000038F7 File Offset: 0x00001AF7
		public bool IsCanChangeProperty
		{
			get
			{
				return this.myIsCanChangeProperty;
			}
			set
			{
				this.myIsCanChangeProperty = value;
				if (this.myIsCanChangeProperty)
				{
					this.SplitContainer1.Enabled = true;
				}
				else
				{
					this.SplitContainer1.Enabled = false;
				}
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0003F370 File Offset: 0x0003D570
		public void NewMB(DataGridView dgv1, string mbfilename)
		{
			this.NewMB();
			checked
			{
				if (dgv1 != null && dgv1.ColumnCount > 0)
				{
					mbsjmodule.FieldsString = new string[dgv1.ColumnCount - 1 + 1];
					int num = 0;
					int num2 = dgv1.ColumnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						mbsjmodule.FieldsString[i] = dgv1.Columns[i].Name;
					}
				}
				if (this.myvar != null)
				{
					mbsjmodule.FieldsString2 = mbsjmodule.ParaseVar(this.myvar);
				}
				this.w_mbname = mbfilename;
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		public void NewMB()
		{
			this.CS.Clear();
			this.w_mbname = "";
			this.w_paperwidth = mbsjmodule.G_MB_Default_Width;
			this.w_paperheight = 500f;
			this.myp2.BackGroundPicture = null;
			this.myp3.BackGroundPicture = null;
			this.SetDefaultPosition();
			this.s_mbcontent = this.GetMBContentAll();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0003F454 File Offset: 0x0003D654
		public string SaveMbAs(string newmbname)
		{
			this.ismbsavedsuccessfull = false;
			if (String.Compare(newmbname, "", false) == 0)
			{
				Application.UseWaitCursor = false;
				if (this.s2.ShowDialog() != DialogResult.OK)
				{
					return "";
				}
				newmbname = this.s2.FileName;
				if (String.Compare(newmbname, "", false) == 0)
				{
					return "";
				}
				Application.UseWaitCursor = true;
				if (MyProject.Computer.FileSystem.FileExists(newmbname))
				{
					MyProject.Computer.FileSystem.DeleteFile(newmbname);
				}
			}
			this.w_mbname = newmbname;
			return this.SaveMb();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0003F4F0 File Offset: 0x0003D6F0
		public string SaveMb()
		{
			float num = this.rv.ConvertToMM((float)(checked(this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height + this.p5.Height + this.P6.Height + this.p7.Height + this.P8.Height)), false);
			if (!this.MyPage.PaperLandScape)
			{
				if (num > this.MyPage.PaperHeight)
				{
					Interaction.MsgBox(string.Concat(new string[]
					{
						"警告：打印纸张的高度〖",
						Convert.ToString(Math.Round((double)this.MyPage.PaperHeight, 2)),
						"〗毫米小于打印模板定义的高度〖",
						Convert.ToString(Math.Round((double)num, 2)),
						"〗毫米，因此该打印模板有可能无法进行打印或打印预览，您可能需要调整打印模板的高度或在页面设置中调整打印纸张。"
					}), MsgBoxStyle.OkOnly, "提示信息");
				}
			}
			else if (num > this.MyPage.PaperWidth)
			{
				Interaction.MsgBox(string.Concat(new string[]
				{
					"警告：打印纸张的高度〖",
					Convert.ToString(Math.Round((double)this.MyPage.PaperWidth, 2)),
					"〗毫米小于打印模板定义的高度〖",
					Convert.ToString(Math.Round((double)num, 2)),
					"〗毫米，因此该打印模板有可能无法进行打印或打印预览，您可能需要调整打印模板的高度或在页面设置中调整打印纸张。"
				}), MsgBoxStyle.OkOnly, "提示信息");
			}
			if (String.Compare(this.w_mbname, "", false) == 0)
			{
				Application.UseWaitCursor = false;
				if (this.s2.ShowDialog() != DialogResult.OK)
				{
					return "";
				}
				this.w_mbname = this.s2.FileName;
				if (String.Compare(this.w_mbname, "", false) == 0)
				{
					return "";
				}
				Application.UseWaitCursor = true;
				if (MyProject.Computer.FileSystem.FileExists(this.w_mbname))
				{
					MyProject.Computer.FileSystem.DeleteFile(this.w_mbname);
				}
			}
			string mbcontentAll = this.GetMBContentAll();
			MyProject.Computer.FileSystem.WriteAllText(this.w_mbname, mbcontentAll, false);
			this.s_mbcontent = mbcontentAll;
			this.s_width = this.w_paperwidth;
			this.ismbsavedsuccessfull = true;
			Application.UseWaitCursor = false;
			return this.w_mbname;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0003F72C File Offset: 0x0003D92C
		private string GetMBContentAll()
		{
			string str = Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer1.Width, true));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer1.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer2.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer3.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer4.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer5.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer6.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer7.SplitterDistance, false));
			str = str + mbsjmodule.G_MB_Spetator_Line + Convert.ToString(this.rv.ConvertToMM((float)this.SplitContainer8.SplitterDistance, false));
			string text = "";
			checked
			{
				if (mbsjmodule.FieldsString != null)
				{
					int num = 0;
					int num2 = mbsjmodule.FieldsString.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i == 0)
						{
							text = mbsjmodule.FieldsString[i];
						}
						else
						{
							text = text + mbsjmodule.G_MB_Spetator_Proper + mbsjmodule.FieldsString[i];
						}
					}
				}
				str = str + mbsjmodule.G_MB_Spetator_Line + text;
				text = "";
				if (mbsjmodule.FieldsString2 != null)
				{
					int num3 = 0;
					int num4 = mbsjmodule.FieldsString2.GetLength(0) - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (j == 0)
						{
							text = mbsjmodule.FieldsString2[j, 0];
						}
						else
						{
							text = text + mbsjmodule.G_MB_Spetator_Proper + mbsjmodule.FieldsString2[j, 0];
						}
					}
				}
				str = str + mbsjmodule.G_MB_Spetator_Line + text;
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P1);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P2);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P3);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P4);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.p5);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P6);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.p7);
				str = str + mbsjmodule.G_MB_Spetator_Band + this.GetMBContent(this.P8);
				this.MyPage.TopMargin = this.rv.ConvertToMM((float)this.P1.Height, false);
				this.MyPage.BottomMargin = this.rv.ConvertToMM((float)this.P8.Height, false);
				return str + mbsjmodule.G_MB_Spetator_Band + this.MyPage.SaveCS();
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0003FA80 File Offset: 0x0003DC80
		private string GetMBContent(PictureBox pp)
		{
			string str = Convert.ToString(this.rv.ConvertToMM((float)pp.Height, false));
			if (pp == this.P2)
			{
				str = this.myp2.SaveString();
			}
			else if (pp == this.P3)
			{
				str = this.myp3.SaveString();
			}
			else if (pp == this.P4)
			{
				str = this.myp4.SaveString();
			}
			else if (pp == this.p5)
			{
				str = this.myp5.SaveString();
			}
			string text = "";
			int maxControlCount = this.CS.GetMaxControlCount();
			int num = 0;
			checked
			{
				int num2 = maxControlCount - 1;
				for (int i = num; i <= num2; i++)
				{
					Control control = this.CS.GetControl(i);
					if (control != null && control.Parent == pp && (control.Left >= pp.Width | control.Top >= pp.Height))
					{
						control = null;
						this.CS.DeleteControl(i);
					}
					if (control != null && control.Parent == pp)
					{
						string text2 = mbsjmodule.SaveControl(control);
						if (String.Compare(text, "", false) == 0)
						{
							text = text2;
						}
						else
						{
							text = text + mbsjmodule.G_MB_Spetator_Line + text2;
						}
					}
				}
				return str + mbsjmodule.G_MB_Spetator_BandContent + text;
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0003FBD4 File Offset: 0x0003DDD4
		public bool OpenMb(DataGridView dgv1, string mbname, bool onlyforprint = false)
		{
			checked
			{
				bool result;
				if (!this.OpenMb(mbname, onlyforprint))
				{
					result = false;
				}
				else
				{
					if (dgv1 != null && dgv1.ColumnCount > 0)
					{
						mbsjmodule.FieldsString = new string[dgv1.ColumnCount - 1 + 1];
						int num = 0;
						int num2 = dgv1.ColumnCount - 1;
						for (int i = num; i <= num2; i++)
						{
							mbsjmodule.FieldsString[i] = dgv1.Columns[i].Name;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0003FC40 File Offset: 0x0003DE40
		public bool OpenMb(string mbname, bool onlyforprint = false)
		{
			this.w_mbname = "";
			this.CS.Clear();
			this.SetDefaultPosition();
			checked
			{
				bool result;
				if (!MyProject.Computer.FileSystem.FileExists(mbname))
				{
					result = false;
				}
				else
				{
					try
					{
						this.w_mbname = mbname;
						string expression = MyProject.Computer.FileSystem.ReadAllText(this.w_mbname);
						this.s_mbcontent = expression;
						string[] array = Strings.Split(expression, mbsjmodule.G_MB_Spetator_Band, -1, CompareMethod.Binary);
						string[] array2 = Strings.Split(array[0], mbsjmodule.G_MB_Spetator_Line, -1, CompareMethod.Binary);
						this.w_paperwidth = Convert.ToSingle(array2[0]);
						this.SplitContainer1.Height = (int)Math.Round((double)this.rv.ConvertFromMM(500f, false));
						this.SplitContainer1.Width = (int)Math.Round((double)this.rv.ConvertFromMM(this.w_paperwidth, true));
						this.s_width = this.w_paperwidth;
						this.SplitContainer1.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[1]), false));
						this.SplitContainer2.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[2]), false));
						this.SplitContainer3.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[3]), false));
						this.SplitContainer4.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[4]), false));
						this.SplitContainer5.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[5]), false));
						this.SplitContainer6.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[6]), false));
						this.SplitContainer7.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[7]), false));
						this.SplitContainer8.SplitterDistance = (int)Math.Round((double)this.rv.ConvertFromMM(Convert.ToSingle(array2[8]), false));
						if (String.Compare(array2[9], "", false) != 0)
						{
							mbsjmodule.FieldsString = Strings.Split(array2[9], mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
						}
						else
						{
							mbsjmodule.FieldsString = null;
						}
						if (String.Compare(array2[10], "", false) != 0)
						{
							string[] array3 = Strings.Split(array2[10], mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
							mbsjmodule.FieldsString2 = new string[array3.Length - 1 + 1, 2];
							int num = 0;
							int num2 = array3.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								mbsjmodule.FieldsString2[i, 0] = array3[i];
								mbsjmodule.FieldsString2[i, 1] = null;
							}
						}
						else
						{
							mbsjmodule.FieldsString2 = null;
						}
						this.ParaseBand(array[1], this.P1, onlyforprint);
						this.ParaseBand(array[2], this.P2, onlyforprint);
						this.ParaseBand(array[3], this.P3, onlyforprint);
						this.ParaseBand(array[4], this.P4, onlyforprint);
						this.ParaseBand(array[5], this.p5, onlyforprint);
						this.ParaseBand(array[6], this.P6, onlyforprint);
						this.ParaseBand(array[7], this.p7, onlyforprint);
						this.ParaseBand(array[8], this.P8, onlyforprint);
						this.MyPage.RestoreCS(array[9]);
						try
						{
							this.CS.CancelAllSelected();
						}
						catch (Exception ex)
						{
						}
						this.SetMbWidthHeight(this.w_paperwidth, this.w_paperheight);
						if (this.myvar != null)
						{
							mbsjmodule.FieldsString2 = mbsjmodule.ParaseVar(this.myvar);
						}
						result = true;
					}
					catch (Exception ex2)
					{
						Interaction.MsgBox("报表打印模板文件〖" + this.w_mbname + "〗打开失败，可能是不正确的模板文件格式，或者文件被损坏，或者模板文件是高版本控件创建的", MsgBoxStyle.OkOnly, "提示信息");
						this.w_mbname = "";
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0004004C File Offset: 0x0003E24C
		private void ParaseBand(string ss, PictureBox pp, bool onlyforprint = false)
		{
			string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_BandContent, -1, CompareMethod.Binary);
			string[] array2 = Strings.Split(array[0], mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
			if (pp == this.P2)
			{
				this.myp2.ReadString(array[0]);
			}
			else if (pp == this.P3)
			{
				this.myp3.ReadString(array[0]);
			}
			else if (pp == this.P4)
			{
				this.myp4.ReadString(array[0]);
			}
			else if (pp == this.p5)
			{
				this.myp5.ReadString(array[0]);
			}
			array2 = Strings.Split(array[1], mbsjmodule.G_MB_Spetator_Line, -1, CompareMethod.Binary);
			int num = 0;
			checked
			{
				int num2 = array2.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					this.CS.AddControl(mbsjmodule.RestoreControl(array2[i]), pp, onlyforprint);
				}
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00003922 File Offset: 0x00001B22
		public void SetMbWidthHeight(float thewidth, float theheight)
		{
			this.w_paperwidth = thewidth;
			this.w_paperheight = theheight;
			this.ControlDesign_Resize(null, null);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00040110 File Offset: 0x0003E310
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0000393A File Offset: 0x00001B3A
		public bool IsRulerUseCentimeter
		{
			get
			{
				return this.rv.IsUserCentimeter;
			}
			set
			{
				this.rv.IsUserCentimeter = value;
				this.rh.IsUserCentimeter = value;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00040128 File Offset: 0x0003E328
		private void ControlDesign_Resize(object sender, EventArgs e)
		{
			checked
			{
				int num = (int)Math.Round((double)(unchecked(this.rh.ConvertFromMM(this.w_paperwidth, true) - (float)(checked(this.pp.Panel1.Width - this.rv.Width * 2 - this.sv.Width)))));
				if (num > 0)
				{
					if (this.sh.Value > num)
					{
						this.sh.Value = num;
					}
					this.sh.Maximum = num + 10;
					this.sh.Visible = true;
				}
				else
				{
					this.sh.Visible = false;
					this.sh.Value = 0;
					this.sh.Maximum = 0;
				}
				num = this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height + this.p5.Height + this.P6.Height + this.p7.Height + this.P8.Height + 160 - (this.pp.Panel1.Height - this.rh.Height * 2 - this.sh.Height);
				if (num > 0)
				{
					if (this.sv.Value > num)
					{
						this.sv.Value = num;
					}
					this.sv.Maximum = num + 10;
					this.sv.Visible = true;
				}
				else
				{
					this.sv.Visible = false;
					this.sv.Value = 0;
					this.sv.Maximum = 0;
				}
				this.rh.Left = this.rv.Width - this.sh.Value;
				this.rh.Top = 0;
				this.rv.Left = 0;
				this.rv.Top = this.rh.Height - this.sv.Value;
				this.sh.Left = this.rv.Width;
				this.sh.Top = this.pp.Panel1.Height - this.sh.Height;
				this.sv.Left = this.pp.Panel1.Width - this.sv.Width;
				this.sv.Top = this.rh.Height;
				try
				{
					this.SplitContainer1.Left = this.rv.Width - this.sh.Value;
					this.SplitContainer1.Top = this.rh.Height - this.sv.Value;
				}
				catch (Exception ex)
				{
				}
				try
				{
					this.sh.Width = this.pp.Panel1.Width - this.rv.Width - this.sv.Width;
				}
				catch (Exception ex2)
				{
				}
				try
				{
					this.sv.Height = this.pp.Panel1.Height - this.rh.Height - this.sh.Height;
				}
				catch (Exception ex3)
				{
				}
				this.SplitContainer1.Width = (int)Math.Round((double)this.rh.ConvertFromMM(this.w_paperwidth, true));
				this.SplitContainer1.Height = (int)Math.Round((double)this.rh.ConvertFromMM(this.w_paperheight, false));
				this.l2.Left = (int)Math.Round(unchecked((double)(checked(this.SplitContainer1.Left + this.SplitContainer1.Width)) - (double)this.l2.Width / 2.0));
				this.l2.Top = this.rh.Top;
				this.l2.Height = this.rh.Height;
				this.L1.Left = this.rv.Left;
				this.L1.Width = this.rv.Width;
				this.L1.Top = (int)Math.Round(unchecked((double)(checked(this.SplitContainer1.Top + this.SplitContainer1.Height)) - (double)this.L1.Height / 2.0));
				if (!this.IsCanChangeProperty)
				{
					this.l2.Visible = false;
					this.L1.Visible = false;
				}
				else
				{
					this.l2.Visible = true;
					this.L1.Visible = true;
				}
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00003954 File Offset: 0x00001B54
		private void ControlDesign_Load(object sender, EventArgs e)
		{
			this.CS.parentcontrol = this;
			this.SetDefaultPosition();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00003968 File Offset: 0x00001B68
		private void MyShowStatus(string tt, Control myc)
		{
			if (this.StatusLabel != null)
			{
				this.StatusLabel.Text = tt;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000397E File Offset: 0x00001B7E
		private void sh_ValueChanged(object sender, EventArgs e)
		{
			this.ControlDesign_Resize(null, null);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000397E File Offset: 0x00001B7E
		private void sv_ValueChanged(object sender, EventArgs e)
		{
			this.ControlDesign_Resize(null, null);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00040600 File Offset: 0x0003E800
		private void p_Click(object sender, EventArgs e)
		{
			if (!this.CS._IsCtrlKey)
			{
				this.CS.CancelAllSelected();
				try
				{
					this.StatusLabel.Text = "";
				}
				catch (Exception ex)
				{
				}
			}
			this.Label2_Click(RuntimeHelpers.GetObjectValue(sender), null);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00040664 File Offset: 0x0003E864
		private void p_MouseClick(object sender, MouseEventArgs e)
		{
			if (!this.CS._IsCtrlKey | e.Button != MouseButtons.Left)
			{
				this.CS.CancelAllSelected();
			}
			this.curparent = (PictureBox)sender;
			if (this.Cursor == Cursors.Cross)
			{
				if (this.Button26.FlatStyle == FlatStyle.Flat)
				{
					U_Image u_Image = new U_Image();
					u_Image.Tag = "图片";
					u_Image.IsPrint = false;
					u_Image.Top = e.Y;
					u_Image.Left = e.X;
					u_Image.LineWidth = 0.2f;
					u_Image.EWidth = 15f;
					u_Image.EHeight = 6f;
					this.CS.AddControl(u_Image, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button25.FlatStyle == FlatStyle.Flat)
				{
					U_Field u_Field = new U_Field();
					u_Field.Top = e.Y;
					u_Field.Left = e.X;
					u_Field.EWidth = 25f;
					u_Field.EHeight = 6f;
					u_Field.IsPrint = true;
					u_Field.Cols = 1;
					this.CS.AddControl(u_Field, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button23.FlatStyle == FlatStyle.Flat)
				{
					U_Rect u_Rect = new U_Rect();
					u_Rect.Tag = "矩形";
					u_Rect.IsPrint = false;
					u_Rect.Top = e.Y;
					u_Rect.Left = e.X;
					u_Rect.FilledColor = Color.Transparent;
					u_Rect.LineWidth = 0.2f;
					u_Rect.EWidth = 15f;
					u_Rect.EHeight = 6f;
					this.CS.AddControl(u_Rect, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button21.FlatStyle == FlatStyle.Flat)
				{
					U_HLine u_HLine = new U_HLine();
					u_HLine.LineColor = Color.Black;
					u_HLine.LineWidth = 0.2f;
					u_HLine.EWidth = 15f;
					u_HLine.IsPrint = false;
					u_HLine.Top = e.Y;
					u_HLine.Left = e.X;
					u_HLine.Tag = "横线";
					this.CS.AddControl(u_HLine, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button22.FlatStyle == FlatStyle.Flat)
				{
					U_VLine u_VLine = new U_VLine();
					u_VLine.LineColor = Color.Black;
					u_VLine.LineWidth = 0.2f;
					u_VLine.EHeight = 10f;
					u_VLine.IsPrint = false;
					u_VLine.Top = e.Y;
					u_VLine.Left = e.X;
					u_VLine.Tag = "竖线";
					this.CS.AddControl(u_VLine, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button24.FlatStyle == FlatStyle.Flat)
				{
					U_Text u_Text = new U_Text();
					u_Text.Top = e.Y;
					u_Text.Left = e.X;
					u_Text.EWidth = 20f;
					u_Text.EHeight = 6f;
					u_Text.IsPrint = false;
					u_Text.TextValue = "新文本";
					u_Text.Cols = 1;
					this.CS.AddControl(u_Text, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button27.FlatStyle == FlatStyle.Flat)
				{
					U_Comput u_Comput = new U_Comput();
					u_Comput.Top = e.Y;
					u_Comput.Left = e.X;
					u_Comput.EWidth = 25f;
					u_Comput.EHeight = 6f;
					u_Comput.IsPrint = true;
					u_Comput.Cols = 1;
					this.CS.AddControl(u_Comput, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button28.FlatStyle == FlatStyle.Flat)
				{
					U_Bar u_Bar = new U_Bar();
					u_Bar.Top = e.Y;
					u_Bar.Left = e.X;
					u_Bar.EWidth = 20f;
					u_Bar.EHeight = 6f;
					u_Bar.IsPrint = true;
					u_Bar.TextValue = "条码";
					this.CS.AddControl(u_Bar, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button29.FlatStyle == FlatStyle.Flat)
				{
					U_Bias u_Bias = new U_Bias();
					u_Bias.Tag = "斜线";
					u_Bias.IsPrint = false;
					u_Bias.BackColor = Color.Transparent;
					u_Bias.Top = e.Y;
					u_Bias.Left = e.X;
					u_Bias.LineWidth = 0.2f;
					u_Bias.EWidth = 15f;
					u_Bias.EHeight = 6f;
					this.CS.AddControl(u_Bias, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button30.FlatStyle == FlatStyle.Flat)
				{
					U_Express u_Express = new U_Express();
					u_Express.Top = e.Y;
					u_Express.Left = e.X;
					u_Express.EWidth = 20f;
					u_Express.EHeight = 6f;
					u_Express.IsPrint = false;
					u_Express.Cols = 1;
					this.CS.AddControl(u_Express, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button31.FlatStyle == FlatStyle.Flat)
				{
					U_Ellipse u_Ellipse = new U_Ellipse();
					u_Ellipse.Tag = "椭圆";
					u_Ellipse.IsPrint = false;
					u_Ellipse.Top = e.Y;
					u_Ellipse.Left = e.X;
					u_Ellipse.FilledColor = Color.Transparent;
					u_Ellipse.LineWidth = 0.2f;
					u_Ellipse.EWidth = 15f;
					u_Ellipse.EHeight = 6f;
					this.CS.AddControl(u_Ellipse, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button3.FlatStyle == FlatStyle.Flat)
				{
					U_fBias u_fBias = new U_fBias();
					u_fBias.Tag = "反斜线";
					u_fBias.IsPrint = false;
					u_fBias.Top = e.Y;
					u_fBias.Left = e.X;
					u_fBias.LineWidth = 0.2f;
					u_fBias.EWidth = 15f;
					u_fBias.EHeight = 6f;
					this.CS.AddControl(u_fBias, this.curparent, false);
					this.isaddcontrol = true;
				}
				else if (this.Button4.FlatStyle == FlatStyle.Flat)
				{
					U_QC u_QC = new U_QC();
					u_QC.Tag = "二维码";
					u_QC.IsPrint = true;
					u_QC.Top = e.Y;
					u_QC.Left = e.X;
					u_QC.EWidth = 20f;
					u_QC.EHeight = 6f;
					this.CS.AddControl(u_QC, this.curparent, false);
					this.isaddcontrol = true;
				}
			}
			else
			{
				this.Label2_Click(RuntimeHelpers.GetObjectValue(sender), null);
			}
			this.Cursor = Cursors.Default;
			this.CancelAllItem();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00003988 File Offset: 0x00001B88
		private void Button1_Click(object sender, EventArgs e)
		{
			this.CS.CancelAllSelected();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00040D70 File Offset: 0x0003EF70
		private void p_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.mouse_x = (float)e.Location.X;
				this.mouse_y = (float)e.Location.Y;
				this.shape1.Width = 0;
				this.shape1.Height = 0;
				this.shape1.Visible = false;
				this.shape1.SendToBack();
				if (!this.CS._IsCtrlKey)
				{
					this.CS.CancelAllSelected();
				}
				this.preRect = Rectangle.Empty;
				this.ismousedown = true;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00040E10 File Offset: 0x0003F010
		private void p_MouseMove(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			checked
			{
				if (e.Button == MouseButtons.Left & this.ismousedown)
				{
					this.shape1.Width = (int)Math.Round((double)Math.Abs(unchecked((float)e.Location.X - this.mouse_x)));
					this.shape1.Height = (int)Math.Round((double)Math.Abs(unchecked((float)e.Location.Y - this.mouse_y)));
					if ((float)e.Location.X > this.mouse_x)
					{
						this.shape1.Left = (int)Math.Round((double)this.mouse_x);
					}
					else
					{
						this.shape1.Left = e.Location.X;
					}
					if ((float)e.Location.Y > this.mouse_y)
					{
						this.shape1.Top = (int)Math.Round((double)this.mouse_y);
					}
					else
					{
						this.shape1.Top = e.Location.Y;
					}
					Rectangle newrect = new Rectangle(this.shape1.Left, this.shape1.Top, this.shape1.Width, this.shape1.Height);
					this.MyDraw(this.preRect, newrect, control);
					this.preRect = newrect;
					if (this.CS._IsCtrlKey)
					{
						this.SelectShapeControl(true, control);
					}
					else
					{
						this.SelectShapeControl(false, control);
					}
				}
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00040F94 File Offset: 0x0003F194
		private void p_MouseUp(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			if (e.Button == MouseButtons.Left & this.ismousedown)
			{
				this.MyDraw(this.preRect, Rectangle.Empty, control);
			}
			this.ismousedown = false;
			if (this.isaddcontrol)
			{
				this.isaddcontrol = false;
			}
			else
			{
				if (e.Button == MouseButtons.Left)
				{
					if (this.CS._IsCtrlKey)
					{
						this.SelectShapeControl(true, control);
					}
					else
					{
						this.SelectShapeControl(false, control);
					}
				}
				this.preRect = Rectangle.Empty;
				this.shape1.Width = 0;
				this.shape1.Height = 0;
				this.shape1.Visible = false;
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00041044 File Offset: 0x0003F244
		public void SelectShapeControl(bool isadd, Control curp)
		{
			Rectangle r = new Rectangle(this.shape1.Left, this.shape1.Top, this.shape1.Width, this.shape1.Height);
			r = curp.RectangleToScreen(r);
			bool flag = false;
			int num = 0;
			int maxControlCount = this.CS.GetMaxControlCount();
			checked
			{
				for (int i = num; i <= maxControlCount; i++)
				{
					Control control = this.CS.GetControl(i);
					if (control != null)
					{
						Rectangle rectangle = control.ClientRectangle;
						rectangle = control.RectangleToScreen(rectangle);
						if (r.Contains(rectangle))
						{
							if (!flag)
							{
								flag = true;
								if (!this.CS.IsControlCurrentSelected(control))
								{
									this.CS.SetControlCurrentSelected(control, true);
								}
							}
							else if (!this.CS.IsControlSelected(control))
							{
								this.CS.SetControlSelected(control, true);
							}
						}
						else if (!isadd && this.CS.IsControlSelected(control))
						{
							this.CS.SetControlSelected(control, false);
						}
					}
				}
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00041138 File Offset: 0x0003F338
		private void MyDraw(Rectangle sourrect, Rectangle newrect, Control sender)
		{
			if (!sourrect.IsEmpty)
			{
				Rectangle rectangle = sender.RectangleToScreen(sourrect);
				ControlPaint.DrawReversibleFrame(rectangle, Color.White, FrameStyle.Dashed);
			}
			if (!newrect.IsEmpty)
			{
				Rectangle rectangle = sender.RectangleToScreen(newrect);
				ControlPaint.DrawReversibleFrame(rectangle, Color.White, FrameStyle.Dashed);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00041180 File Offset: 0x0003F380
		public ControlDesign()
		{
			base.Disposed += this.ControlDesign_Disposed;
			base.Resize += this.ControlDesign_Resize;
			base.Load += this.ControlDesign_Load;
			base.Click += this.ControlDesign_Click;
			this.myIsCanChangeProperty = true;
			this.myvar = new Hashtable();
			this.CS = new MoveControl();
			this.isaddcontrol = false;
			this.ismousedown = false;
			this.w_paperwidth = mbsjmodule.G_MB_Default_Width;
			this.w_paperheight = 500f;
			this.s_mbcontent = "";
			this.s_width = mbsjmodule.G_MB_Default_Width;
			this.curparent = null;
			this.MyPage = new PrintReportOptions();
			this.myp1 = new mbclassp1(this);
			this.myp2 = new mbclassp2(this);
			this.myp3 = new mbclassp3(this);
			this.myp4 = new mbclassp4(this);
			this.myp5 = new mbclassp5(this);
			this.myp6 = new mbclassp6(this);
			this.myp7 = new mbclassp7(this);
			this.myp8 = new mbclassp8(this);
			this.InitializeComponent();
			checked
			{
				this.rh.Width = (int)Math.Round((double)this.rh.ConvertFromMM(500f, true));
				this.rv.Height = (int)Math.Round((double)this.rh.ConvertFromMM(1500f, false));
				this.Button1.Left = 0;
				this.Button1.Width = this.rv.Width;
				this.Button1.Top = 0;
				this.Button1.Height = this.rh.Height;
				this.ControlDesign_Resize(null, null);
				this.CS.Rh = this.rh;
				this.CS.Rv = this.rv;
				this.CS.pg = this.PropertyGrid1;
				this.CS.pgs = this.sx;
				this.CS.ShowStatus += this.MyShowStatus;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003995 File Offset: 0x00001B95
		public void DelSelectedControl()
		{
			this.CS.DeleteSelectedControl();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0004139C File Offset: 0x0003F59C
		private void ControlDesign_Click(object sender, EventArgs e)
		{
			this.CS.CancelAllSelected();
			try
			{
				this.StatusLabel.Text = "";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000039A2 File Offset: 0x00001BA2
		private void l2_MouseDown(object sender, MouseEventArgs e)
		{
			this.source_x = e.X;
			this.source_y = e.Y;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000413E4 File Offset: 0x0003F5E4
		private void l2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.l2.Visible = false;
				this.SplitContainer1.Width = checked(this.SplitContainer1.Width + e.X - this.source_x);
				this.source_x = e.X;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0004143C File Offset: 0x0003F63C
		private void l2_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.w_paperwidth = this.rh.ConvertToMM((float)this.SplitContainer1.Width, true);
				this.ControlDesign_Resize(null, null);
				this.l2.Visible = true;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000039BC File Offset: 0x00001BBC
		private void Button2_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox(this.P1.Height, MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00041488 File Offset: 0x0003F688
		private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{
			PictureBox pp = null;
			SplitContainer splitContainer = (SplitContainer)sender;
			if (splitContainer == this.SplitContainer1)
			{
				pp = this.P1;
			}
			else if (splitContainer == this.SplitContainer2)
			{
				pp = this.P2;
			}
			else if (splitContainer == this.SplitContainer3)
			{
				pp = this.P3;
			}
			else if (splitContainer == this.SplitContainer4)
			{
				pp = this.P4;
			}
			else if (splitContainer == this.SplitContainer5)
			{
				pp = this.p5;
			}
			else if (splitContainer == this.SplitContainer6)
			{
				pp = this.P6;
			}
			else if (splitContainer == this.SplitContainer7)
			{
				pp = this.p7;
			}
			else if (splitContainer == this.SplitContainer8)
			{
				pp = this.P8;
			}
			float num = this.GetBandMimHeight(pp) + 20f;
			if ((float)e.SplitY < num)
			{
				splitContainer.SplitterDistance = checked((int)Math.Round((double)num));
			}
			this.ControlDesign_Resize(null, null);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0004155C File Offset: 0x0003F75C
		private float GetBandMimHeight(PictureBox pp)
		{
			float num = 0f;
			int num2 = 0;
			int maxControlCount = this.CS.GetMaxControlCount();
			checked
			{
				for (int i = num2; i <= maxControlCount; i++)
				{
					Control control = this.CS.GetControl(i);
					if (control != null && control.Parent == pp && num < (float)(control.Top + control.Height))
					{
						num = (float)(control.Top + control.Height);
					}
				}
				return num;
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000415C8 File Offset: 0x0003F7C8
		public float GetBaseHeight(PictureBox tt)
		{
			float result = 0f;
			float num = 1f;
			string left = tt.Name.ToUpper();
			if (String.Compare(left, "P1", false) == 0)
			{
				result = 20f;
			}
			else if (String.Compare(left, "P2", false) == 0)
			{
				result = (float)(checked(40 + this.P1.Height)) + num * 1f;
			}
			else if (String.Compare(left, "P3", false) == 0)
			{
				result = (float)(checked(60 + this.P1.Height + this.P2.Height)) + num * 2f;
			}
			else if (String.Compare(left, "P4", false) == 0)
			{
				result = (float)(checked(80 + this.P1.Height + this.P2.Height + this.P3.Height)) + num * 3f;
			}
			else if (String.Compare(left, "P5", false) == 0)
			{
				result = (float)(checked(100 + this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height)) + num * 4f;
			}
			else if (String.Compare(left, "P6", false) == 0)
			{
				result = (float)(checked(120 + this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height + this.p5.Height)) + num * 5f;
			}
			else if (String.Compare(left, "P7", false) == 0)
			{
				result = (float)(checked(140 + this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height + this.p5.Height + this.P6.Height)) + num * 6f;
			}
			else if (String.Compare(left, "P8", false) == 0)
			{
				result = (float)(checked(160 + this.P1.Height + this.P2.Height + this.P3.Height + this.P4.Height + this.p5.Height + this.P6.Height + this.p7.Height)) + num * 7f;
			}
			return result;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000039A2 File Offset: 0x00001BA2
		private void l1_MouseDown(object sender, MouseEventArgs e)
		{
			this.source_x = e.X;
			this.source_y = e.Y;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00041838 File Offset: 0x0003FA38
		private void L1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.L1.Visible = false;
				this.SplitContainer1.Height = checked(this.SplitContainer1.Height + e.Y - this.source_y);
				this.source_y = e.Y;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00041890 File Offset: 0x0003FA90
		private void L1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.w_paperheight = this.rh.ConvertToMM((float)this.SplitContainer1.Height, true);
				this.ControlDesign_Resize(null, null);
				this.L1.Visible = true;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000039D6 File Offset: 0x00001BD6
		private void Button5_Click(object sender, EventArgs e)
		{
			this.myp2.BackGroundPicture = null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000039E4 File Offset: 0x00001BE4
		private void Button7_Click(object sender, EventArgs e)
		{
			this.myp3.BackGroundPicture = null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000418DC File Offset: 0x0003FADC
		public void ShowPageSetup()
		{
			this.MyPage.TopMargin = this.rv.ConvertToMM((float)this.P1.Height, false);
			this.MyPage.BottomMargin = this.rv.ConvertToMM((float)this.P8.Height, false);
			checked
			{
				if (this.MyPage.ShowPageSetup())
				{
					this.SplitContainer1.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.rv.ConvertFromMM(this.MyPage.TopMargin, false))));
					this.SplitContainer8.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.rv.ConvertFromMM(this.MyPage.BottomMargin, false))));
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0004199C File Offset: 0x0003FB9C
		private void CancelAllItem()
		{
			this.Button20.FlatStyle = FlatStyle.Standard;
			this.Button20.BackColor = SystemColors.Control;
			this.Button21.FlatStyle = FlatStyle.Standard;
			this.Button21.BackColor = SystemColors.Control;
			this.Button22.FlatStyle = FlatStyle.Standard;
			this.Button22.BackColor = SystemColors.Control;
			this.Button23.FlatStyle = FlatStyle.Standard;
			this.Button23.BackColor = SystemColors.Control;
			this.Button24.FlatStyle = FlatStyle.Standard;
			this.Button24.BackColor = SystemColors.Control;
			this.Button25.FlatStyle = FlatStyle.Standard;
			this.Button25.BackColor = SystemColors.Control;
			this.Button26.FlatStyle = FlatStyle.Standard;
			this.Button26.BackColor = SystemColors.Control;
			this.Button27.FlatStyle = FlatStyle.Standard;
			this.Button27.BackColor = SystemColors.Control;
			this.Button28.FlatStyle = FlatStyle.Standard;
			this.Button28.BackColor = SystemColors.Control;
			this.Button29.FlatStyle = FlatStyle.Standard;
			this.Button29.BackColor = SystemColors.Control;
			this.Button30.FlatStyle = FlatStyle.Standard;
			this.Button30.BackColor = SystemColors.Control;
			this.Button31.FlatStyle = FlatStyle.Standard;
			this.Button31.BackColor = SystemColors.Control;
			this.Button3.FlatStyle = FlatStyle.Standard;
			this.Button3.BackColor = SystemColors.Control;
			this.Button4.FlatStyle = FlatStyle.Standard;
			this.Button4.BackColor = SystemColors.Control;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00041B34 File Offset: 0x0003FD34
		private void SetButtonItem(Button bt)
		{
			if (bt.FlatStyle == FlatStyle.Standard)
			{
				this.CancelAllItem();
				bt.FlatStyle = FlatStyle.Flat;
				bt.BackColor = Color.Pink;
				if (bt == this.Button20)
				{
					this.Cursor = Cursors.Default;
				}
				else
				{
					this.Cursor = Cursors.Cross;
				}
			}
			else
			{
				this.CancelAllItem();
				bt.FlatStyle = FlatStyle.Standard;
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000039F2 File Offset: 0x00001BF2
		private void Button20_Click(object sender, EventArgs e)
		{
			this.SetButtonItem((Button)sender);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00041BA0 File Offset: 0x0003FDA0
		private void Label2_Click(object sender, EventArgs e)
		{
			if (sender != null && !(sender is PictureBox))
			{
				this.CS.CancelAllSelected();
			}
			if (sender == this.Label2 | sender == this.P2)
			{
				this.PropertyGrid1.SelectedObject = this.myp2;
				this.sx.Text = "报表属性：▼报表头";
				this.StatusLabel.Text = "报表头：仅第一页打印";
			}
			else if (sender == this.Label3 | sender == this.P3)
			{
				this.PropertyGrid1.SelectedObject = this.myp3;
				this.sx.Text = "报表属性：▼页表头";
				this.StatusLabel.Text = "页表头：每页重复打印";
			}
			else if (sender == this.Label4 | sender == this.P4)
			{
				this.PropertyGrid1.SelectedObject = this.myp4;
				this.sx.Text = "报表属性：▼表格详细内容";
				this.StatusLabel.Text = "表格详细内容：每页根据表格行数重复打印";
			}
			else if (sender == this.Label5 | sender == this.p5)
			{
				this.PropertyGrid1.SelectedObject = this.myp5;
				this.sx.Text = "报表属性：▼分组打印";
				this.StatusLabel.Text = "分组打印：分组属性";
			}
			else if (sender == this.Label1 | sender == this.P1)
			{
				this.PropertyGrid1.SelectedObject = this.myp1;
				this.sx.Text = "报表属性：▼页面页眉";
				this.StatusLabel.Text = "页面页眉：打印在每页的开头，每页重复打印";
			}
			else if (sender == this.Label6 | sender == this.P6)
			{
				this.PropertyGrid1.SelectedObject = this.myp6;
				this.sx.Text = "报表属性：▼页表尾";
				this.StatusLabel.Text = "页表尾：打印在每页表格下面，每页重复打印";
			}
			else if (sender == this.Label7 | sender == this.p7)
			{
				this.PropertyGrid1.SelectedObject = this.myp7;
				this.sx.Text = "报表属性：▼报表尾";
				this.StatusLabel.Text = "报表尾：打印在整个表格最后，仅最后一页打印";
			}
			else if (sender == this.Label8 | sender == this.P8)
			{
				this.PropertyGrid1.SelectedObject = this.myp8;
				this.sx.Text = "报表属性：▼页面页脚";
				this.StatusLabel.Text = "页面页脚：打印在每页的末尾，每页重复打印";
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003A00 File Offset: 0x00001C00
		private void PropertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
		{
			if (e.NewSelection != null)
			{
				if (e.NewSelection.Value is Image)
				{
					this.PropertyGrid1.ContextMenuStrip = this.ContextMenuStrip1;
				}
				else
				{
					this.PropertyGrid1.ContextMenuStrip = null;
				}
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00041E14 File Offset: 0x00040014
		private void ToolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.PropertyGrid1.SelectedGridItem != null && this.PropertyGrid1.SelectedGridItem.Value is Image)
			{
				if (this.PropertyGrid1.SelectedObject == this.myp2)
				{
					this.myp2.BackGroundPicture = null;
				}
				else if (this.PropertyGrid1.SelectedObject == this.myp3)
				{
					this.myp3.BackGroundPicture = null;
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00003A3B File Offset: 0x00001C3B
		private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
		{
			if (this.myp2.BackGroundPicture != null)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000039D6 File Offset: 0x00001BD6
		private void ToolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.myp2.BackGroundPicture = null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000039E4 File Offset: 0x00001BE4
		private void ToolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.myp3.BackGroundPicture = null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003A5A File Offset: 0x00001C5A
		private void ContextMenuStrip3_Opening(object sender, CancelEventArgs e)
		{
			if (this.myp3.BackGroundPicture != null)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000393 RID: 915
		private IContainer components;

		// Token: 0x04000394 RID: 916
		[AccessedThroughProperty("rh")]
		private Ruler _rh;

		// Token: 0x04000395 RID: 917
		[AccessedThroughProperty("rv")]
		private Ruler _rv;

		// Token: 0x04000396 RID: 918
		[AccessedThroughProperty("sv")]
		private VScrollBar _sv;

		// Token: 0x04000397 RID: 919
		[AccessedThroughProperty("sh")]
		private HScrollBar _sh;

		// Token: 0x04000398 RID: 920
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000399 RID: 921
		[AccessedThroughProperty("l2")]
		private Label _l2;

		// Token: 0x0400039A RID: 922
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		// Token: 0x0400039B RID: 923
		[AccessedThroughProperty("P1")]
		private PictureBox _P1;

		// Token: 0x0400039C RID: 924
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400039D RID: 925
		[AccessedThroughProperty("SplitContainer2")]
		private SplitContainer _SplitContainer2;

		// Token: 0x0400039E RID: 926
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400039F RID: 927
		[AccessedThroughProperty("SplitContainer3")]
		private SplitContainer _SplitContainer3;

		// Token: 0x040003A0 RID: 928
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003A1 RID: 929
		[AccessedThroughProperty("P2")]
		private PictureBox _P2;

		// Token: 0x040003A2 RID: 930
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040003A3 RID: 931
		[AccessedThroughProperty("P3")]
		private PictureBox _P3;

		// Token: 0x040003A4 RID: 932
		[AccessedThroughProperty("SplitContainer4")]
		private SplitContainer _SplitContainer4;

		// Token: 0x040003A5 RID: 933
		[AccessedThroughProperty("SplitContainer5")]
		private SplitContainer _SplitContainer5;

		// Token: 0x040003A6 RID: 934
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040003A7 RID: 935
		[AccessedThroughProperty("SplitContainer6")]
		private SplitContainer _SplitContainer6;

		// Token: 0x040003A8 RID: 936
		[AccessedThroughProperty("P6")]
		private PictureBox _P6;

		// Token: 0x040003A9 RID: 937
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040003AA RID: 938
		[AccessedThroughProperty("pp")]
		private SplitContainer _pp;

		// Token: 0x040003AB RID: 939
		[AccessedThroughProperty("PropertyGrid1")]
		private PropertyGrid _PropertyGrid1;

		// Token: 0x040003AC RID: 940
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040003AD RID: 941
		[AccessedThroughProperty("SplitContainer7")]
		private SplitContainer _SplitContainer7;

		// Token: 0x040003AE RID: 942
		[AccessedThroughProperty("shape1")]
		private Label _shape1;

		// Token: 0x040003AF RID: 943
		[AccessedThroughProperty("SplitContainer8")]
		private SplitContainer _SplitContainer8;

		// Token: 0x040003B0 RID: 944
		[AccessedThroughProperty("P4")]
		private PictureBox _P4;

		// Token: 0x040003B1 RID: 945
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040003B2 RID: 946
		[AccessedThroughProperty("p7")]
		private PictureBox _p7;

		// Token: 0x040003B3 RID: 947
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040003B4 RID: 948
		[AccessedThroughProperty("P8")]
		private PictureBox _P8;

		// Token: 0x040003B5 RID: 949
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040003B6 RID: 950
		[AccessedThroughProperty("L1")]
		private Label _L1;

		// Token: 0x040003B7 RID: 951
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x040003B8 RID: 952
		[AccessedThroughProperty("o1")]
		private OpenFileDialog _o1;

		// Token: 0x040003B9 RID: 953
		[AccessedThroughProperty("s2")]
		private SaveFileDialog _s2;

		// Token: 0x040003BA RID: 954
		[AccessedThroughProperty("o2")]
		private OpenFileDialog _o2;

		// Token: 0x040003BB RID: 955
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x040003BC RID: 956
		[AccessedThroughProperty("SplitContainer9")]
		private SplitContainer _SplitContainer9;

		// Token: 0x040003BD RID: 957
		[AccessedThroughProperty("sx")]
		private Label _sx;

		// Token: 0x040003BE RID: 958
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		// Token: 0x040003BF RID: 959
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040003C0 RID: 960
		[AccessedThroughProperty("Button26")]
		private Button _Button26;

		// Token: 0x040003C1 RID: 961
		[AccessedThroughProperty("Button25")]
		private Button _Button25;

		// Token: 0x040003C2 RID: 962
		[AccessedThroughProperty("Button24")]
		private Button _Button24;

		// Token: 0x040003C3 RID: 963
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		// Token: 0x040003C4 RID: 964
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		// Token: 0x040003C5 RID: 965
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		// Token: 0x040003C6 RID: 966
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		// Token: 0x040003C7 RID: 967
		[AccessedThroughProperty("Button28")]
		private Button _Button28;

		// Token: 0x040003C8 RID: 968
		[AccessedThroughProperty("Button27")]
		private Button _Button27;

		// Token: 0x040003C9 RID: 969
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x040003CA RID: 970
		[AccessedThroughProperty("Button30")]
		private Button _Button30;

		// Token: 0x040003CB RID: 971
		[AccessedThroughProperty("SplitContainer10")]
		private SplitContainer _SplitContainer10;

		// Token: 0x040003CC RID: 972
		[AccessedThroughProperty("Button31")]
		private Button _Button31;

		// Token: 0x040003CD RID: 973
		[AccessedThroughProperty("p5")]
		private PictureBox _p5;

		// Token: 0x040003CE RID: 974
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040003CF RID: 975
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040003D0 RID: 976
		[AccessedThroughProperty("清除图片ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040003D1 RID: 977
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x040003D2 RID: 978
		[AccessedThroughProperty("清除背景图片ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040003D3 RID: 979
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x040003D4 RID: 980
		[AccessedThroughProperty("清除背景图片ToolStripMenuItem1")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x040003D5 RID: 981
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040003D6 RID: 982
		public bool myIsCanChangeProperty;

		// Token: 0x040003D7 RID: 983
		public Hashtable myvar;

		// Token: 0x040003D8 RID: 984
		public MoveControl CS;

		// Token: 0x040003D9 RID: 985
		private float mouse_x;

		// Token: 0x040003DA RID: 986
		private float mouse_y;

		// Token: 0x040003DB RID: 987
		private Rectangle preRect;

		// Token: 0x040003DC RID: 988
		public bool isaddcontrol;

		// Token: 0x040003DD RID: 989
		private bool ismousedown;

		// Token: 0x040003DE RID: 990
		public ToolStripStatusLabel StatusLabel;

		// Token: 0x040003DF RID: 991
		private string w_mbname;

		// Token: 0x040003E0 RID: 992
		private float w_paperwidth;

		// Token: 0x040003E1 RID: 993
		private float w_paperheight;

		// Token: 0x040003E2 RID: 994
		private string s_mbcontent;

		// Token: 0x040003E3 RID: 995
		private float s_width;

		// Token: 0x040003E4 RID: 996
		private int source_x;

		// Token: 0x040003E5 RID: 997
		private int source_y;

		// Token: 0x040003E6 RID: 998
		public PictureBox curparent;

		// Token: 0x040003E7 RID: 999
		public bool ismbsavedsuccessfull;

		// Token: 0x040003E8 RID: 1000
		public PrintReportOptions MyPage;

		// Token: 0x040003E9 RID: 1001
		public mbclassp1 myp1;

		// Token: 0x040003EA RID: 1002
		public mbclassp2 myp2;

		// Token: 0x040003EB RID: 1003
		public mbclassp3 myp3;

		// Token: 0x040003EC RID: 1004
		public mbclassp4 myp4;

		// Token: 0x040003ED RID: 1005
		public mbclassp5 myp5;

		// Token: 0x040003EE RID: 1006
		public mbclassp6 myp6;

		// Token: 0x040003EF RID: 1007
		public mbclassp7 myp7;

		// Token: 0x040003F0 RID: 1008
		public mbclassp8 myp8;
	}
}
