using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200003D RID: 61
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class TextEdit_Express : Form
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x000048F1 File Offset: 0x00002AF1
		public TextEdit_Express()
		{
			base.Load += this.TextEdit_Express_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0005A6FC File Offset: 0x000588FC
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00004912 File Offset: 0x00002B12
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get
			{
				return this._TableLayoutPanel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0005A714 File Offset: 0x00058914
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0005A72C File Offset: 0x0005892C
		internal virtual Button OK_Button
		{
			get
			{
				return this._OK_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Button_Click);
				if (this._OK_Button != null)
				{
					this._OK_Button.Click -= value2;
				}
				this._OK_Button = value;
				if (this._OK_Button != null)
				{
					this._OK_Button.Click += value2;
				}
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0005A778 File Offset: 0x00058978
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0005A790 File Offset: 0x00058990
		internal virtual Button Cancel_Button
		{
			get
			{
				return this._Cancel_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Button_Click);
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click -= value2;
				}
				this._Cancel_Button = value;
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click += value2;
				}
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0005A7DC File Offset: 0x000589DC
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0000491B File Offset: 0x00002B1B
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0005A7F4 File Offset: 0x000589F4
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00004924 File Offset: 0x00002B24
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0005A80C File Offset: 0x00058A0C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x0005A824 File Offset: 0x00058A24
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0005A870 File Offset: 0x00058A70
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x0000492D File Offset: 0x00002B2D
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0005A888 File Offset: 0x00058A88
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			get
			{
				return this.toolStripMenuItem_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0005A8EC File Offset: 0x00058AEC
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0005A904 File Offset: 0x00058B04
		internal virtual ToolStripMenuItem ToolStripMenuItem_1
		{
			get
			{
				return this.toolStripMenuItem_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0005A950 File Offset: 0x00058B50
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0005A968 File Offset: 0x00058B68
		internal virtual ToolStripMenuItem ToolStripMenuItem_2
		{
			get
			{
				return this.toolStripMenuItem_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0005A9B4 File Offset: 0x00058BB4
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0005A9CC File Offset: 0x00058BCC
		internal virtual ToolStripMenuItem ToolStripMenuItem_3
		{
			get
			{
				return this.toolStripMenuItem_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0005AA18 File Offset: 0x00058C18
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x0005AA30 File Offset: 0x00058C30
		internal virtual ToolStripMenuItem ToolStripMenuItem_4
		{
			get
			{
				return this.toolStripMenuItem_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0005AA7C File Offset: 0x00058C7C
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0005AA94 File Offset: 0x00058C94
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0005AAE0 File Offset: 0x00058CE0
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			get
			{
				return this._ToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0005AB44 File Offset: 0x00058D44
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0005AB5C File Offset: 0x00058D5C
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0005ABA8 File Offset: 0x00058DA8
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		internal virtual ToolStripMenuItem ToolStripMenuItem4
		{
			get
			{
				return this._ToolStripMenuItem4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0005AC0C File Offset: 0x00058E0C
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x0005AC24 File Offset: 0x00058E24
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0005AC70 File Offset: 0x00058E70
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x0005AC88 File Offset: 0x00058E88
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004936 File Offset: 0x00002B36
		internal virtual ContextMenuStrip ContextMenuStrip2
		{
			get
			{
				return this._ContextMenuStrip2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip2 = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0005ACEC File Offset: 0x00058EEC
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0000493F File Offset: 0x00002B3F
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0005AD04 File Offset: 0x00058F04
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0005AD1C File Offset: 0x00058F1C
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0005AD68 File Offset: 0x00058F68
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004948 File Offset: 0x00002B48
		internal virtual ContextMenuStrip ContextMenuStrip3
		{
			get
			{
				return this._ContextMenuStrip3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip3 = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0005AD80 File Offset: 0x00058F80
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004951 File Offset: 0x00002B51
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0005AD98 File Offset: 0x00058F98
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000495A File Offset: 0x00002B5A
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00004963 File Offset: 0x00002B63
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00004894 File Offset: 0x00002A94
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0000496C File Offset: 0x00002B6C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip1.Show((Control)sender, 0, 0);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			string text = ((ToolStripMenuItem)sender).Text;
			text = "[" + text + "]";
			this.TextBox1.Paste(text);
			this.TextBox1.Focus();
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00004981 File Offset: 0x00002B81
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip2.Show((Control)sender, 0, 0);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0005AE0C File Offset: 0x0005900C
		private void TextEdit_Express_Load(object sender, EventArgs e)
		{
			checked
			{
				if (mbsjmodule.FieldsString2 == null)
				{
					this.Button2.Enabled = false;
				}
				else if (mbsjmodule.FieldsString2.GetLength(0) < 0)
				{
					this.Button2.Enabled = false;
				}
				else
				{
					this.Button2.Enabled = true;
					int num = 0;
					int num2 = mbsjmodule.FieldsString2.GetLength(0) - 1;
					for (int i = num; i <= num2; i++)
					{
						if (String.Compare(mbsjmodule.FieldsString2[i, 0], "", false) != 0)
						{
							ToolStripItem toolStripItem = this.ContextMenuStrip2.Items.Add(mbsjmodule.FieldsString2[i, 0]);
							toolStripItem.Click += this.ToolStripMenuItem5_Click;
						}
					}
					if (this.ContextMenuStrip2.Items.Count <= 0)
					{
						this.Button2.Enabled = false;
					}
				}
				if (mbsjmodule.FieldsString == null)
				{
					this.Button3.Enabled = false;
				}
				else if (mbsjmodule.FieldsString.Length < 0)
				{
					this.Button3.Enabled = false;
				}
				else
				{
					this.Button3.Enabled = true;
					int num3 = 0;
					int num4 = mbsjmodule.FieldsString.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						ToolStripItem toolStripItem2 = this.ContextMenuStrip3.Items.Add(mbsjmodule.FieldsString[j]);
						toolStripItem2.Click += this.ToolStripMenuItem5_Click;
					}
				}
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00004996 File Offset: 0x00002B96
		private void Button3_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip3.Show((Control)sender, 0, 0);
		}

		// Token: 0x04000552 RID: 1362
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000553 RID: 1363
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000554 RID: 1364
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x04000555 RID: 1365
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000556 RID: 1366
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000557 RID: 1367
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000558 RID: 1368
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000559 RID: 1369
		[AccessedThroughProperty("页码ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400055A RID: 1370
		[AccessedThroughProperty("总页数ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x0400055B RID: 1371
		[AccessedThroughProperty("当前日期ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x0400055C RID: 1372
		[AccessedThroughProperty("当前日期2ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x0400055D RID: 1373
		[AccessedThroughProperty("当前年ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x0400055E RID: 1374
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x0400055F RID: 1375
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x04000560 RID: 1376
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x04000561 RID: 1377
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x04000562 RID: 1378
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem _ToolStripMenuItem5;

		// Token: 0x04000563 RID: 1379
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000564 RID: 1380
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x04000565 RID: 1381
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000566 RID: 1382
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000567 RID: 1383
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x04000568 RID: 1384
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000569 RID: 1385
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400056A RID: 1386
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
	}
}
