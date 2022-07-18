using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200003C RID: 60
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class TextEdit : Form
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x00004822 File Offset: 0x00002A22
		public TextEdit()
		{
			base.Load += this.TextEdit_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0005928C File Offset: 0x0005748C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00004843 File Offset: 0x00002A43
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000592A4 File Offset: 0x000574A4
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000592BC File Offset: 0x000574BC
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00059308 File Offset: 0x00057508
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00059320 File Offset: 0x00057520
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0005936C File Offset: 0x0005756C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0000484C File Offset: 0x00002A4C
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00059384 File Offset: 0x00057584
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00004855 File Offset: 0x00002A55
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0005939C File Offset: 0x0005759C
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000593B4 File Offset: 0x000575B4
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00059400 File Offset: 0x00057600
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0000485E File Offset: 0x00002A5E
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00059418 File Offset: 0x00057618
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00059430 File Offset: 0x00057630
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0005947C File Offset: 0x0005767C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00059494 File Offset: 0x00057694
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000594E0 File Offset: 0x000576E0
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000594F8 File Offset: 0x000576F8
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00059544 File Offset: 0x00057744
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0005955C File Offset: 0x0005775C
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000595A8 File Offset: 0x000577A8
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000595C0 File Offset: 0x000577C0
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0005960C File Offset: 0x0005780C
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00059624 File Offset: 0x00057824
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00059670 File Offset: 0x00057870
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00059688 File Offset: 0x00057888
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000596D4 File Offset: 0x000578D4
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000596EC File Offset: 0x000578EC
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00059738 File Offset: 0x00057938
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00059750 File Offset: 0x00057950
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0005979C File Offset: 0x0005799C
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000597B4 File Offset: 0x000579B4
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00059800 File Offset: 0x00057A00
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00059818 File Offset: 0x00057A18
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00059864 File Offset: 0x00057A64
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00004867 File Offset: 0x00002A67
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0005987C File Offset: 0x00057A7C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00004870 File Offset: 0x00002A70
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00059894 File Offset: 0x00057A94
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000598AC File Offset: 0x00057AAC
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000598F8 File Offset: 0x00057AF8
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00004879 File Offset: 0x00002A79
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00059910 File Offset: 0x00057B10
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00004882 File Offset: 0x00002A82
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00059928 File Offset: 0x00057B28
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000488B File Offset: 0x00002A8B
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

		// Token: 0x060009CD RID: 2509 RVA: 0x00004894 File Offset: 0x00002A94
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000048B2 File Offset: 0x00002AB2
		private void Button1_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip1.Show((Control)sender, 0, 0);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00059940 File Offset: 0x00057B40
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			string text = ((ToolStripMenuItem)sender).Text;
			text = "[" + text + "]";
			this.TextBox1.Paste(text);
			this.TextBox1.Focus();
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000048C7 File Offset: 0x00002AC7
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip2.Show((Control)sender, 0, 0);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00059984 File Offset: 0x00057B84
		private void TextEdit_Load(object sender, EventArgs e)
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
					string[] array = new string[mbsjmodule.FieldsString2.GetLength(0) - 1 + 1];
					int num = 0;
					int num2 = mbsjmodule.FieldsString2.GetLength(0) - 1;
					for (int i = num; i <= num2; i++)
					{
						array[i] = mbsjmodule.FieldsString2[i, 0];
					}
					Array.Sort<string>(array);
					int num3 = 0;
					int num4 = array.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (String.Compare(array[j], "", false) != 0)
						{
							ToolStripItem toolStripItem = this.ContextMenuStrip2.Items.Add(array[j]);
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
					Array.Sort<string>(mbsjmodule.FieldsString);
					int num5 = 0;
					int num6 = mbsjmodule.FieldsString.Length - 1;
					for (int k = num5; k <= num6; k++)
					{
						ToolStripItem toolStripItem2 = this.ContextMenuStrip3.Items.Add(mbsjmodule.FieldsString[k]);
						toolStripItem2.Click += this.ToolStripMenuItem5_Click;
					}
				}
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000048DC File Offset: 0x00002ADC
		private void Button3_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip3.Show((Control)sender, 0, 0);
		}

		// Token: 0x04000539 RID: 1337
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400053A RID: 1338
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400053B RID: 1339
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400053C RID: 1340
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400053D RID: 1341
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400053E RID: 1342
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400053F RID: 1343
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000540 RID: 1344
		[AccessedThroughProperty("页码ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000541 RID: 1345
		[AccessedThroughProperty("总页数ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000542 RID: 1346
		[AccessedThroughProperty("当前日期ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000543 RID: 1347
		[AccessedThroughProperty("当前日期2ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000544 RID: 1348
		[AccessedThroughProperty("当前年ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000545 RID: 1349
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000546 RID: 1350
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x04000547 RID: 1351
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x04000548 RID: 1352
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x04000549 RID: 1353
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem _ToolStripMenuItem5;

		// Token: 0x0400054A RID: 1354
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400054B RID: 1355
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x0400054C RID: 1356
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x0400054D RID: 1357
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400054E RID: 1358
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x0400054F RID: 1359
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000550 RID: 1360
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
