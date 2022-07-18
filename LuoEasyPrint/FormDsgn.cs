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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class FormDsgn : Form
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00041E88 File Offset: 0x00040088
		public FormDsgn()
		{
			this.InitializeComponent();
			base.Load += this.FormDsgn_Load;
			base.KeyDown += this.Form1_KeyDown;
			base.KeyUp += this.Form1_KeyUp;
			base.FormClosing += this.FormDsgn_FormClosing;
			this.MbToOpen = "";
			this.dgv1 = null;
			this.mycs = new Hashtable();
			this.w_windowtext = "报表打印模板设计";
			
		}

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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000439E8 File Offset: 0x00041BE8
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00003A82 File Offset: 0x00001C82
		internal virtual ControlDesign cd
		{
			get
			{
				return this._cd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cd = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00043A00 File Offset: 0x00041C00
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00003A8B File Offset: 0x00001C8B
		internal virtual MenuStrip MenuStrip1
		{
			get
			{
				return this._MenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00043A18 File Offset: 0x00041C18
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00003A94 File Offset: 0x00001C94
		internal virtual ToolStripContainer ToolStripContainer1
		{
			get
			{
				return this._ToolStripContainer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripContainer1 = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00043A30 File Offset: 0x00041C30
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00003A9D File Offset: 0x00001C9D
		internal virtual StatusStrip StatusStrip1
		{
			get
			{
				return this._StatusStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00043A48 File Offset: 0x00041C48
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00003AA6 File Offset: 0x00001CA6
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00043A60 File Offset: 0x00041C60
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00003AAF File Offset: 0x00001CAF
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			get
			{
				return this.toolStripMenuItem_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.toolStripMenuItem_0 = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00043A78 File Offset: 0x00041C78
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00003AB8 File Offset: 0x00001CB8
		internal virtual ToolStripMenuItem ToolStripMenuItem_1
		{
			get
			{
				return this.toolStripMenuItem_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.toolStripMenuItem_1 = value;
			}
		}

		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel1 = value;
			}
		}
		internal virtual ToolStripMenuItem ToolStripMenuItem_2
		{
			get
			{
				return this.toolStripMenuItem_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.toolStripMenuItem_2 = value;
			}
		}

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

		internal virtual ToolStripMenuItem ToolStripMenuItem_5
		{
			get
			{
				return this.toolStripMenuItem_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_5_Click);
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00043BEC File Offset: 0x00041DEC
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00003AD3 File Offset: 0x00001CD3
		internal virtual ToolStripSeparator ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00043C04 File Offset: 0x00041E04
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00043C1C File Offset: 0x00041E1C
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00043C68 File Offset: 0x00041E68
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00043C80 File Offset: 0x00041E80
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00043CCC File Offset: 0x00041ECC
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00043CE4 File Offset: 0x00041EE4
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00043D30 File Offset: 0x00041F30
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00003ADC File Offset: 0x00001CDC
		internal virtual ToolStripMenuItem ToolStripMenuItem_9
		{
			get
			{
				return this.toolStripMenuItem_9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.toolStripMenuItem_9 = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00043D48 File Offset: 0x00041F48
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00043D60 File Offset: 0x00041F60
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00043DAC File Offset: 0x00041FAC
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00043DC4 File Offset: 0x00041FC4
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00043E10 File Offset: 0x00042010
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00043E28 File Offset: 0x00042028
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00043E74 File Offset: 0x00042074
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00043E8C File Offset: 0x0004208C
		internal virtual ToolStripMenuItem ToolStripMenuItem_13
		{
			get
			{
				return this.toolStripMenuItem_13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton14_Click);
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00043ED8 File Offset: 0x000420D8
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00043EF0 File Offset: 0x000420F0
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00043F3C File Offset: 0x0004213C
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00003AE5 File Offset: 0x00001CE5
		internal virtual ToolStripSeparator ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem3 = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00043F54 File Offset: 0x00042154
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00043F6C File Offset: 0x0004216C
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00043FB8 File Offset: 0x000421B8
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00043FD0 File Offset: 0x000421D0
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0004401C File Offset: 0x0004221C
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00044034 File Offset: 0x00042234
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00044080 File Offset: 0x00042280
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00003AEE File Offset: 0x00001CEE
		internal virtual ToolStripMenuItem ToolStripMenuItem7
		{
			get
			{
				return this._ToolStripMenuItem7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem7 = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00044098 File Offset: 0x00042298
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000440B0 File Offset: 0x000422B0
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000440FC File Offset: 0x000422FC
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00044114 File Offset: 0x00042314
		internal virtual ToolStripMenuItem ToolStripMenuItem_19
		{
			get
			{
				return this.toolStripMenuItem_19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_19_Click);
				if (this.toolStripMenuItem_19 != null)
				{
					this.toolStripMenuItem_19.Click -= value2;
				}
				this.toolStripMenuItem_19 = value;
				if (this.toolStripMenuItem_19 != null)
				{
					this.toolStripMenuItem_19.Click += value2;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00044160 File Offset: 0x00042360
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00044178 File Offset: 0x00042378
		internal virtual ToolStripMenuItem ToolStripMenuItem_20
		{
			get
			{
				return this.toolStripMenuItem_20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_20_Click);
				if (this.toolStripMenuItem_20 != null)
				{
					this.toolStripMenuItem_20.Click -= value2;
				}
				this.toolStripMenuItem_20 = value;
				if (this.toolStripMenuItem_20 != null)
				{
					this.toolStripMenuItem_20.Click += value2;
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000441C4 File Offset: 0x000423C4
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000441DC File Offset: 0x000423DC
		internal virtual ToolStripMenuItem ToolStripMenuItem_21
		{
			get
			{
				return this.toolStripMenuItem_21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_21_Click);
				if (this.toolStripMenuItem_21 != null)
				{
					this.toolStripMenuItem_21.Click -= value2;
				}
				this.toolStripMenuItem_21 = value;
				if (this.toolStripMenuItem_21 != null)
				{
					this.toolStripMenuItem_21.Click += value2;
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00044228 File Offset: 0x00042428
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00044240 File Offset: 0x00042440
		internal virtual ToolStripButton ToolStripButton1
		{
			get
			{
				return this._ToolStripButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton1_Click);
				if (this._ToolStripButton1 != null)
				{
					this._ToolStripButton1.Click -= value2;
				}
				this._ToolStripButton1 = value;
				if (this._ToolStripButton1 != null)
				{
					this._ToolStripButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0004428C File Offset: 0x0004248C
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000442A4 File Offset: 0x000424A4
		internal virtual ToolStripButton ToolStripButton2
		{
			get
			{
				return this._ToolStripButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton2_Click);
				if (this._ToolStripButton2 != null)
				{
					this._ToolStripButton2.Click -= value2;
				}
				this._ToolStripButton2 = value;
				if (this._ToolStripButton2 != null)
				{
					this._ToolStripButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x000442F0 File Offset: 0x000424F0
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00044308 File Offset: 0x00042508
		internal virtual ToolStripButton ToolStripButton3
		{
			get
			{
				return this._ToolStripButton3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton3_Click);
				if (this._ToolStripButton3 != null)
				{
					this._ToolStripButton3.Click -= value2;
				}
				this._ToolStripButton3 = value;
				if (this._ToolStripButton3 != null)
				{
					this._ToolStripButton3.Click += value2;
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00044354 File Offset: 0x00042554
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00003AF7 File Offset: 0x00001CF7
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0004436C File Offset: 0x0004256C
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00044384 File Offset: 0x00042584
		internal virtual ToolStripButton ToolStripButton4
		{
			get
			{
				return this._ToolStripButton4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton4_Click);
				if (this._ToolStripButton4 != null)
				{
					this._ToolStripButton4.Click -= value2;
				}
				this._ToolStripButton4 = value;
				if (this._ToolStripButton4 != null)
				{
					this._ToolStripButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x000443D0 File Offset: 0x000425D0
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x000443E8 File Offset: 0x000425E8
		internal virtual ToolStripButton ToolStripButton5
		{
			get
			{
				return this._ToolStripButton5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton5_Click);
				if (this._ToolStripButton5 != null)
				{
					this._ToolStripButton5.Click -= value2;
				}
				this._ToolStripButton5 = value;
				if (this._ToolStripButton5 != null)
				{
					this._ToolStripButton5.Click += value2;
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00044434 File Offset: 0x00042634
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0004444C File Offset: 0x0004264C
		internal virtual ToolStripButton ToolStripButton6
		{
			get
			{
				return this._ToolStripButton6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton6_Click);
				if (this._ToolStripButton6 != null)
				{
					this._ToolStripButton6.Click -= value2;
				}
				this._ToolStripButton6 = value;
				if (this._ToolStripButton6 != null)
				{
					this._ToolStripButton6.Click += value2;
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00044498 File Offset: 0x00042698
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00003B00 File Offset: 0x00001D00
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000444B0 File Offset: 0x000426B0
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000444C8 File Offset: 0x000426C8
		internal virtual ToolStripButton ToolStripButton7
		{
			get
			{
				return this._ToolStripButton7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton7_Click);
				if (this._ToolStripButton7 != null)
				{
					this._ToolStripButton7.Click -= value2;
				}
				this._ToolStripButton7 = value;
				if (this._ToolStripButton7 != null)
				{
					this._ToolStripButton7.Click += value2;
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00044514 File Offset: 0x00042714
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0004452C File Offset: 0x0004272C
		internal virtual ToolStripButton ToolStripButton8
		{
			get
			{
				return this._ToolStripButton8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton8_Click);
				if (this._ToolStripButton8 != null)
				{
					this._ToolStripButton8.Click -= value2;
				}
				this._ToolStripButton8 = value;
				if (this._ToolStripButton8 != null)
				{
					this._ToolStripButton8.Click += value2;
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00044578 File Offset: 0x00042778
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00044590 File Offset: 0x00042790
		internal virtual ToolStripButton ToolStripButton9
		{
			get
			{
				return this._ToolStripButton9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton9_Click);
				if (this._ToolStripButton9 != null)
				{
					this._ToolStripButton9.Click -= value2;
				}
				this._ToolStripButton9 = value;
				if (this._ToolStripButton9 != null)
				{
					this._ToolStripButton9.Click += value2;
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000445DC File Offset: 0x000427DC
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00003B09 File Offset: 0x00001D09
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x000445F4 File Offset: 0x000427F4
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00003B12 File Offset: 0x00001D12
		internal virtual ToolStripButton ToolStripButton11
		{
			get
			{
				return this._ToolStripButton11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripButton11 = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0004460C File Offset: 0x0004280C
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00044624 File Offset: 0x00042824
		internal virtual ToolStripButton ToolStripButton12
		{
			get
			{
				return this._ToolStripButton12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton12_Click);
				if (this._ToolStripButton12 != null)
				{
					this._ToolStripButton12.Click -= value2;
				}
				this._ToolStripButton12 = value;
				if (this._ToolStripButton12 != null)
				{
					this._ToolStripButton12.Click += value2;
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00044670 File Offset: 0x00042870
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00003B1B File Offset: 0x00001D1B
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00044688 File Offset: 0x00042888
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000446A0 File Offset: 0x000428A0
		internal virtual ToolStripButton ToolStripButton13
		{
			get
			{
				return this._ToolStripButton13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton13_Click);
				if (this._ToolStripButton13 != null)
				{
					this._ToolStripButton13.Click -= value2;
				}
				this._ToolStripButton13 = value;
				if (this._ToolStripButton13 != null)
				{
					this._ToolStripButton13.Click += value2;
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000446EC File Offset: 0x000428EC
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00044704 File Offset: 0x00042904
		internal virtual ToolStripButton ToolStripButton_0
		{
			get
			{
				return this.toolStripButton_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton_0_Click);
				if (this.toolStripButton_0 != null)
				{
					this.toolStripButton_0.Click -= value2;
				}
				this.toolStripButton_0 = value;
				if (this.toolStripButton_0 != null)
				{
					this.toolStripButton_0.Click += value2;
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00044750 File Offset: 0x00042950
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00003B24 File Offset: 0x00001D24
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00044768 File Offset: 0x00042968
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00044780 File Offset: 0x00042980
		internal virtual ToolStripButton ToolStripButton14
		{
			get
			{
				return this._ToolStripButton14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton14_Click);
				if (this._ToolStripButton14 != null)
				{
					this._ToolStripButton14.Click -= value2;
				}
				this._ToolStripButton14 = value;
				if (this._ToolStripButton14 != null)
				{
					this._ToolStripButton14.Click += value2;
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000447CC File Offset: 0x000429CC
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x000447E4 File Offset: 0x000429E4
		internal virtual ToolStripMenuItem ToolStripMenuItem_22
		{
			get
			{
				return this.toolStripMenuItem_22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_22_Click);
				if (this.toolStripMenuItem_22 != null)
				{
					this.toolStripMenuItem_22.Click -= value2;
				}
				this.toolStripMenuItem_22 = value;
				if (this.toolStripMenuItem_22 != null)
				{
					this.toolStripMenuItem_22.Click += value2;
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00044830 File Offset: 0x00042A30
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00003B2D File Offset: 0x00001D2D
		internal virtual ToolStripSeparator ToolStripMenuItem9
		{
			get
			{
				return this._ToolStripMenuItem9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem9 = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00044848 File Offset: 0x00042A48
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00003B36 File Offset: 0x00001D36
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00044860 File Offset: 0x00042A60
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00044878 File Offset: 0x00042A78
		internal virtual ToolStripMenuItem ToolStripMenuItem_23
		{
			get
			{
				return this.toolStripMenuItem_23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_23_Click);
				if (this.toolStripMenuItem_23 != null)
				{
					this.toolStripMenuItem_23.Click -= value2;
				}
				this.toolStripMenuItem_23 = value;
				if (this.toolStripMenuItem_23 != null)
				{
					this.toolStripMenuItem_23.Click += value2;
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000448C4 File Offset: 0x00042AC4
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00003B3F File Offset: 0x00001D3F
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000448DC File Offset: 0x00042ADC
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x000448F4 File Offset: 0x00042AF4
		internal virtual ToolStripButton ToolStripButton10
		{
			get
			{
				return this._ToolStripButton10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton10_Click);
				if (this._ToolStripButton10 != null)
				{
					this._ToolStripButton10.Click -= value2;
				}
				this._ToolStripButton10 = value;
				if (this._ToolStripButton10 != null)
				{
					this._ToolStripButton10.Click += value2;
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00044940 File Offset: 0x00042B40
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00003B48 File Offset: 0x00001D48
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00044958 File Offset: 0x00042B58
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00044970 File Offset: 0x00042B70
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x000449BC File Offset: 0x00042BBC
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x000449D4 File Offset: 0x00042BD4
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00044A20 File Offset: 0x00042C20
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00044A38 File Offset: 0x00042C38
		internal virtual ToolStripSeparator ToolStripSeparator_0
		{
			get
			{
				return this.toolStripSeparator_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripSeparator_0_Click);
				if (this.toolStripSeparator_0 != null)
				{
					this.toolStripSeparator_0.Click -= value2;
				}
				this.toolStripSeparator_0 = value;
				if (this.toolStripSeparator_0 != null)
				{
					this.toolStripSeparator_0.Click += value2;
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00044A84 File Offset: 0x00042C84
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00003B51 File Offset: 0x00001D51
		internal virtual ToolStripSeparator ToolStripMenuItem5
		{
			get
			{
				return this._ToolStripMenuItem5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem5 = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00044A9C File Offset: 0x00042C9C
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00044AB4 File Offset: 0x00042CB4
		internal virtual ToolStripMenuItem ToolStripMenuItem_24
		{
			get
			{
				return this.toolStripMenuItem_24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_24_Click);
				if (this.toolStripMenuItem_24 != null)
				{
					this.toolStripMenuItem_24.Click -= value2;
				}
				this.toolStripMenuItem_24 = value;
				if (this.toolStripMenuItem_24 != null)
				{
					this.toolStripMenuItem_24.Click += value2;
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00044B00 File Offset: 0x00042D00
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00044B18 File Offset: 0x00042D18
		internal virtual ToolStripMenuItem ToolStripMenuItem_25
		{
			get
			{
				return this.toolStripMenuItem_25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_25_Click);
				if (this.toolStripMenuItem_25 != null)
				{
					this.toolStripMenuItem_25.Click -= value2;
				}
				this.toolStripMenuItem_25 = value;
				if (this.toolStripMenuItem_25 != null)
				{
					this.toolStripMenuItem_25.Click += value2;
				}
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00044B64 File Offset: 0x00042D64
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 17)
			{
				this.cd.CS._IsCtrlKey = true;
			}
			if (e.KeyValue == 16)
			{
				this.cd.CS._IsShitKey = true;
			}
			if (e.Control & e.KeyCode == Keys.S)
			{
				this.ToolStripButton14_Click(null, e);
			}
			if (e.Control & e.KeyCode == Keys.P)
			{
				this.ToolStripMenuItem2_Click(null, e);
			}
			if (e.Control & e.KeyCode == Keys.T)
			{
				this.ToolStripMenuItem4_Click(null, e);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00003B5A File Offset: 0x00001D5A
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 17)
			{
				this.cd.CS._IsCtrlKey = false;
			}
			if (e.KeyValue == 16)
			{
				this.cd.CS._IsShitKey = false;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00003B92 File Offset: 0x00001D92
		private void ToolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentLeft();
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00003BA4 File Offset: 0x00001DA4
		private void ToolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentCenter();
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00003BB6 File Offset: 0x00001DB6
		private void ToolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentRight();
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00003BC8 File Offset: 0x00001DC8
		private void ToolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentTop();
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00003BDA File Offset: 0x00001DDA
		private void ToolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentMiddle();
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00003BEC File Offset: 0x00001DEC
		private void ToolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentBottom();
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00003BFE File Offset: 0x00001DFE
		private void ToolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeHeight();
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00003C10 File Offset: 0x00001E10
		private void ToolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeWidth();
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00003C22 File Offset: 0x00001E22
		private void ToolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeAll();
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00003C34 File Offset: 0x00001E34
		private void ToolStripMenuItem_15_Click(object sender, EventArgs e)
		{
			this.cd.CS.SelectedAll();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003C46 File Offset: 0x00001E46
		private void ToolStripMenuItem_16_Click(object sender, EventArgs e)
		{
			this.cd.CS.CancelAllSelected();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00044BF8 File Offset: 0x00042DF8
		private void FormDsgn_Load(object sender, EventArgs e)
		{
			this.cd.StatusLabel = this.ToolStripStatusLabel1;
			this.Visible = true;
			Application.DoEvents();
			mbsjmodule.ShowWaitWindow();
			Application.DoEvents();
			Application.UseWaitCursor = true;
			this.cd.myvar = this.mycs;
			this.Cursor = Cursors.WaitCursor;
			if (String.Compare(this.MbToOpen, "", false) == 0 | !MyProject.Computer.FileSystem.FileExists(this.MbToOpen))
			{
				this.cd.NewMB(this.dgv1, this.MbToOpen);
			}
			else
			{
				Application.UseWaitCursor = true;
				this.cd.Visible = false;
				this.cd.OpenMb(this.dgv1, this.MbToOpen, false);
				this.cd.Visible = true;
				Application.UseWaitCursor = false;
			}
			this.SetWindowTitle(this.MbToOpen);
			this.Cursor = Cursors.Default;
			Application.UseWaitCursor = false;
			mbsjmodule.CloseWaitWindow();
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00044CF8 File Offset: 0x00042EF8
		private void ToolStripButton14_Click(object sender, EventArgs e)
		{
			Application.UseWaitCursor = true;
			this.cd.ismbsavedsuccessfull = false;
			string text = this.cd.SaveMb();
			Application.UseWaitCursor = false;
			this.MbToOpen = text;
			this.SetWindowTitle(text);
			if (String.Compare(text, "", false) != 0 & this.cd.ismbsavedsuccessfull)
			{
				this.ToolStripStatusLabel1.Text = "打印模板已成功保存，最后保存时间[" + Convert.ToString(DateAndTime.Now) + "]";
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00044D7C File Offset: 0x00042F7C
		private void ToolStripMenuItem_14_Click(object sender, EventArgs e)
		{
			if (this.cd.IsNeedSave())
			{
				switch (Interaction.MsgBox("当前打印模板内容已更改，但尚未保存到文件中，新建模板前是否要保存对当前模板所做的修改？", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息"))
				{
				case MsgBoxResult.Cancel:
					return;
				case MsgBoxResult.Yes:
					if (String.Compare(this.cd.SaveMb(), "", false) == 0)
					{
						return;
					}
					break;
				}
			}
			this.cd.NewMB();
			this.SetWindowTitle("");
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00044DF8 File Offset: 0x00042FF8
		private void ToolStripMenuItem_17_Click(object sender, EventArgs e)
		{
			Application.UseWaitCursor = true;
			this.cd.ismbsavedsuccessfull = false;
			string text = this.cd.SaveMbAs("");
			Application.UseWaitCursor = false;
			this.MbToOpen = text;
			if (String.Compare(text, "", false) != 0)
			{
				this.SetWindowTitle(text);
			}
			if (String.Compare(text, "", false) != 0 & this.cd.ismbsavedsuccessfull)
			{
				Interaction.MsgBox("打印模板已成功另存", MsgBoxStyle.OkOnly, "提示信息");
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00044E7C File Offset: 0x0004307C
		private void SetWindowTitle(string tt)
		{
			if (String.Compare(tt, "", false) == 0)
			{
				this.Text = this.w_windowtext + "〖未命名〗";
			}
			else
			{
				this.Text = this.w_windowtext + "〖" + tt + "〗";
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00044ECC File Offset: 0x000430CC
		private void FormDsgn_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.cd.IsNeedSave())
			{
				switch (Interaction.MsgBox("当前模板已经修改，但尚未保存，退出打印模板设计器前，您是否要保存对当前模板所做的修改？", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息"))
				{
				case MsgBoxResult.Cancel:
					e.Cancel = true;
					return;
				case MsgBoxResult.Yes:
					if (String.Compare(this.cd.SaveMb(), "", false) == 0 | !this.cd.ismbsavedsuccessfull)
					{
						e.Cancel = true;
						return;
					}
					break;
				}
			}
			e.Cancel = false;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00003C58 File Offset: 0x00001E58
		private void ToolStripMenuItem_18_Click(object sender, EventArgs e)
		{
			this.cd.CS.ZJRight();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00003C6A File Offset: 0x00001E6A
		private void ToolStripMenuItem_19_Click(object sender, EventArgs e)
		{
			this.cd.CS.ZJBottom();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00003C7C File Offset: 0x00001E7C
		private void ToolStripMenuItem_20_Click(object sender, EventArgs e)
		{
			this.cd.CS.ZJLeft();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00003C8E File Offset: 0x00001E8E
		private void ToolStripMenuItem_21_Click(object sender, EventArgs e)
		{
			this.cd.CS.ZJTop();
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00003B92 File Offset: 0x00001D92
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentLeft();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00003BA4 File Offset: 0x00001DA4
		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentCenter();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00003BB6 File Offset: 0x00001DB6
		private void ToolStripButton3_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentRight();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00003BC8 File Offset: 0x00001DC8
		private void ToolStripButton4_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentTop();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00003BDA File Offset: 0x00001DDA
		private void ToolStripButton5_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentMiddle();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00003BEC File Offset: 0x00001DEC
		private void ToolStripButton6_Click(object sender, EventArgs e)
		{
			this.cd.CS.AlignmentBottom();
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00003C10 File Offset: 0x00001E10
		private void ToolStripButton7_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeWidth();
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00003BFE File Offset: 0x00001DFE
		private void ToolStripButton8_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeHeight();
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00003C22 File Offset: 0x00001E22
		private void ToolStripButton9_Click(object sender, EventArgs e)
		{
			this.cd.CS.SizeAll();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00003CA0 File Offset: 0x00001EA0
		private void ToolStripButton12_Click(object sender, EventArgs e)
		{
			this.cd.DelSelectedControl();
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00003CAD File Offset: 0x00001EAD
		private void ToolStripButton13_Click(object sender, EventArgs e)
		{
			mbsjmodule.MyShowHelp("mbsj.htm");
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000025D6 File Offset: 0x000007D6
		private void ToolStripSeparator_0_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000025D6 File Offset: 0x000007D6
		private void ToolStripButton_0_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00044F58 File Offset: 0x00043158
		private void ToolStripMenuItem_22_Click(object sender, EventArgs e)
		{
			if (this.cd.IsNeedSave())
			{
				switch (Interaction.MsgBox("当前打印模板内容已更改，但尚未保存到文件中，打开模板前是否要保存对当前模板所做的修改？", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息"))
				{
				case MsgBoxResult.Cancel:
					return;
				case MsgBoxResult.Yes:
					if (String.Compare(this.cd.SaveMb(), "", false) == 0)
					{
						return;
					}
					break;
				}
			}
			if (this.o2.ShowDialog() == DialogResult.OK)
			{
				if (!this.cd.OpenMb(this.o2.FileName, false))
				{
					this.SetWindowTitle("");
					this.MbToOpen = "";
				}
				else
				{
					this.MbToOpen = this.o2.FileName;
					this.SetWindowTitle(this.MbToOpen);
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00003CB9 File Offset: 0x00001EB9
		private void ToolStripMenuItem_23_Click(object sender, EventArgs e)
		{
			this.cd.ShowPageSetup();
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00003CC6 File Offset: 0x00001EC6
		private void ToolStripButton10_Click(object sender, EventArgs e)
		{
			this.ToolStripMenuItem_23_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00045018 File Offset: 0x00043218
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.cd.MyPage.TopMargin = this.cd.rv.ConvertToMM((float)this.cd.P1.Height, false);
			this.cd.MyPage.BottomMargin = this.cd.rv.ConvertToMM((float)this.cd.P8.Height, false);
			reportprint reportprint = new reportprint();
			reportprint.reportname = this.MbToOpen;
			reportprint.dgv1 = this.dgv1;
			reportprint.myvar = this.mycs;
			reportprint.IsTd = false;
			reportprint.CanEditReport = false;
			reportprint.cd = this.cd;
			reportprint.ShowDialog();
			reportprint.Dispose();
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000450DC File Offset: 0x000432DC
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.cd.MyPage.TopMargin = this.cd.rv.ConvertToMM((float)this.cd.P1.Height, false);
			this.cd.MyPage.BottomMargin = this.cd.rv.ConvertToMM((float)this.cd.P8.Height, false);
			reportprint reportprint = new reportprint();
			reportprint.reportname = this.MbToOpen;
			reportprint.dgv1 = this.dgv1;
			reportprint.myvar = this.mycs;
			reportprint.IsTd = true;
			reportprint.CanEditReport = false;
			reportprint.cd = this.cd;
			reportprint.ShowDialog();
			reportprint.Dispose();
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000451A0 File Offset: 0x000433A0
		private void ToolStripMenuItem_25_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox = new AboutBox1();
			aboutBox.ShowDialog();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00003CD5 File Offset: 0x00001ED5
		private void ToolStripMenuItem_24_Click(object sender, EventArgs e)
		{
			mbsjmodule.MyShowHelp("");
		}

		// Token: 0x040003F2 RID: 1010
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040003F3 RID: 1011
		[AccessedThroughProperty("cd")]
		private ControlDesign _cd;

		// Token: 0x040003F4 RID: 1012
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040003F5 RID: 1013
		[AccessedThroughProperty("ToolStripContainer1")]
		private ToolStripContainer _ToolStripContainer1;

		// Token: 0x040003F6 RID: 1014
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x040003F7 RID: 1015
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x040003F8 RID: 1016
		[AccessedThroughProperty("文件ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040003F9 RID: 1017
		[AccessedThroughProperty("增加控件ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040003FA RID: 1018
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		// Token: 0x040003FB RID: 1019
		[AccessedThroughProperty("控件对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x040003FC RID: 1020
		[AccessedThroughProperty("水平左对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x040003FD RID: 1021
		[AccessedThroughProperty("水平居中对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x040003FE RID: 1022
		[AccessedThroughProperty("水平右对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x040003FF RID: 1023
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripSeparator _ToolStripMenuItem1;

		// Token: 0x04000400 RID: 1024
		[AccessedThroughProperty("垂直靠上对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000401 RID: 1025
		[AccessedThroughProperty("垂直居中对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04000402 RID: 1026
		[AccessedThroughProperty("垂直靠下对齐ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04000403 RID: 1027
		[AccessedThroughProperty("统一大小ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04000404 RID: 1028
		[AccessedThroughProperty("控件高度相同ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x04000405 RID: 1029
		[AccessedThroughProperty("控件宽度相同ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04000406 RID: 1030
		[AccessedThroughProperty("高宽都相同ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x04000407 RID: 1031
		[AccessedThroughProperty("保存模板ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x04000408 RID: 1032
		[AccessedThroughProperty("新建模板ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x04000409 RID: 1033
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripSeparator _ToolStripMenuItem3;

		// Token: 0x0400040A RID: 1034
		[AccessedThroughProperty("选择所有控件ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x0400040B RID: 1035
		[AccessedThroughProperty("取消选择所有控件ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x0400040C RID: 1036
		[AccessedThroughProperty("模板另存ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x0400040D RID: 1037
		[AccessedThroughProperty("ToolStripMenuItem7")]
		private ToolStripMenuItem _ToolStripMenuItem7;

		// Token: 0x0400040E RID: 1038
		[AccessedThroughProperty("靠基准控件右边粘接ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x0400040F RID: 1039
		[AccessedThroughProperty("靠基准控件下边粘接ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x04000410 RID: 1040
		[AccessedThroughProperty("靠基准控件左边粘接ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x04000411 RID: 1041
		[AccessedThroughProperty("靠基准控件下边粘接ToolStripMenuItem1")]
		private ToolStripMenuItem toolStripMenuItem_21;

		// Token: 0x04000412 RID: 1042
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		// Token: 0x04000413 RID: 1043
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		// Token: 0x04000414 RID: 1044
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton _ToolStripButton3;

		// Token: 0x04000415 RID: 1045
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000416 RID: 1046
		[AccessedThroughProperty("ToolStripButton4")]
		private ToolStripButton _ToolStripButton4;

		// Token: 0x04000417 RID: 1047
		[AccessedThroughProperty("ToolStripButton5")]
		private ToolStripButton _ToolStripButton5;

		// Token: 0x04000418 RID: 1048
		[AccessedThroughProperty("ToolStripButton6")]
		private ToolStripButton _ToolStripButton6;

		// Token: 0x04000419 RID: 1049
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x0400041A RID: 1050
		[AccessedThroughProperty("ToolStripButton7")]
		private ToolStripButton _ToolStripButton7;

		// Token: 0x0400041B RID: 1051
		[AccessedThroughProperty("ToolStripButton8")]
		private ToolStripButton _ToolStripButton8;

		// Token: 0x0400041C RID: 1052
		[AccessedThroughProperty("ToolStripButton9")]
		private ToolStripButton _ToolStripButton9;

		// Token: 0x0400041D RID: 1053
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x0400041E RID: 1054
		[AccessedThroughProperty("ToolStripButton11")]
		private ToolStripButton _ToolStripButton11;

		// Token: 0x0400041F RID: 1055
		[AccessedThroughProperty("ToolStripButton12")]
		private ToolStripButton _ToolStripButton12;

		// Token: 0x04000420 RID: 1056
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x04000421 RID: 1057
		[AccessedThroughProperty("ToolStripButton13")]
		private ToolStripButton _ToolStripButton13;

		// Token: 0x04000422 RID: 1058
		[AccessedThroughProperty("选项设置")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04000423 RID: 1059
		[AccessedThroughProperty("ToolStripSeparator6")]
		private ToolStripSeparator _ToolStripSeparator6;

		// Token: 0x04000424 RID: 1060
		[AccessedThroughProperty("ToolStripButton14")]
		private ToolStripButton _ToolStripButton14;

		// Token: 0x04000425 RID: 1061
		[AccessedThroughProperty("打开模板ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_22;

		// Token: 0x04000426 RID: 1062
		[AccessedThroughProperty("ToolStripMenuItem9")]
		private ToolStripSeparator _ToolStripMenuItem9;

		// Token: 0x04000427 RID: 1063
		[AccessedThroughProperty("o2")]
		private OpenFileDialog _o2;

		// Token: 0x04000428 RID: 1064
		[AccessedThroughProperty("页面设置")]
		private ToolStripMenuItem toolStripMenuItem_23;

		// Token: 0x04000429 RID: 1065
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x0400042A RID: 1066
		[AccessedThroughProperty("ToolStripButton10")]
		private ToolStripButton _ToolStripButton10;

		// Token: 0x0400042B RID: 1067
		[AccessedThroughProperty("ToolStripSeparator7")]
		private ToolStripSeparator _ToolStripSeparator7;

		// Token: 0x0400042C RID: 1068
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x0400042D RID: 1069
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x0400042E RID: 1070
		[AccessedThroughProperty("退出ToolStripMenuItem")]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x0400042F RID: 1071
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripSeparator _ToolStripMenuItem5;

		// Token: 0x04000430 RID: 1072
		[AccessedThroughProperty("帮助ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_24;

		// Token: 0x04000431 RID: 1073
		[AccessedThroughProperty("关于ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_25;

		// Token: 0x04000432 RID: 1074
		public string MbToOpen;

		// Token: 0x04000433 RID: 1075
		public DataGridView dgv1;

		// Token: 0x04000434 RID: 1076
		public Hashtable mycs;

		// Token: 0x04000435 RID: 1077
		private string w_windowtext;
	}
}
