using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000076 RID: 118
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class SimpleReportTextEdit : Form
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x000066B5 File Offset: 0x000048B5
		public SimpleReportTextEdit()
		{
			base.Load += this.SimpleReportTextEdit_Load;
			this.InitializeComponent();
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0008A724 File Offset: 0x00088924
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x000066D6 File Offset: 0x000048D6
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0008A73C File Offset: 0x0008893C
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0008A754 File Offset: 0x00088954
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0008A7A0 File Offset: 0x000889A0
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0008A7B8 File Offset: 0x000889B8
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0008A804 File Offset: 0x00088A04
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x000066DF File Offset: 0x000048DF
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0008A81C File Offset: 0x00088A1C
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x000066E8 File Offset: 0x000048E8
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

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0008A834 File Offset: 0x00088A34
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x0008A84C File Offset: 0x00088A4C
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0008A898 File Offset: 0x00088A98
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000066F1 File Offset: 0x000048F1
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0008A8B0 File Offset: 0x00088AB0
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0008A8C8 File Offset: 0x00088AC8
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0008A914 File Offset: 0x00088B14
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0008A92C File Offset: 0x00088B2C
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0008A978 File Offset: 0x00088B78
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0008A990 File Offset: 0x00088B90
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0008A9DC File Offset: 0x00088BDC
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0008A9F4 File Offset: 0x00088BF4
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0008AA40 File Offset: 0x00088C40
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0008AA58 File Offset: 0x00088C58
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0008AAA4 File Offset: 0x00088CA4
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0008AABC File Offset: 0x00088CBC
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0008AB08 File Offset: 0x00088D08
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0008AB20 File Offset: 0x00088D20
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0008AB6C File Offset: 0x00088D6C
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0008AB84 File Offset: 0x00088D84
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0008ABD0 File Offset: 0x00088DD0
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0008ABE8 File Offset: 0x00088DE8
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0008AC34 File Offset: 0x00088E34
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0008AC4C File Offset: 0x00088E4C
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0008AC98 File Offset: 0x00088E98
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0008ACB0 File Offset: 0x00088EB0
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0008ACFC File Offset: 0x00088EFC
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x000066FA File Offset: 0x000048FA
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0008AD14 File Offset: 0x00088F14
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x00006703 File Offset: 0x00004903
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0008AD2C File Offset: 0x00088F2C
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0008AD44 File Offset: 0x00088F44
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0008AD90 File Offset: 0x00088F90
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0000670C File Offset: 0x0000490C
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0008ADA8 File Offset: 0x00088FA8
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00006715 File Offset: 0x00004915
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0008ADC0 File Offset: 0x00088FC0
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0000671E File Offset: 0x0000491E
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

		// Token: 0x06001173 RID: 4467 RVA: 0x00004894 File Offset: 0x00002A94
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00006727 File Offset: 0x00004927
		private void Button1_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip1.Show((Control)sender, 0, 0);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0008ADD8 File Offset: 0x00088FD8
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			string text = ((ToolStripMenuItem)sender).Text;
			text = "[" + text + "]";
			this.TextBox1.Paste(text);
			this.TextBox1.Focus();
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000673C File Offset: 0x0000493C
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip2.Show((Control)sender, 0, 0);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0008AE1C File Offset: 0x0008901C
		private void SimpleReportTextEdit_Load(object sender, EventArgs e)
		{
			checked
			{
				if (this.zdyarray == null)
				{
					this.Button2.Enabled = false;
				}
				else if (this.zdyarray.GetLength(0) < 0)
				{
					this.Button2.Enabled = false;
				}
				else
				{
					this.Button2.Enabled = true;
					int num = 0;
					int num2 = this.zdyarray.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						if (String.Compare(this.zdyarray[i], "", false) != 0)
						{
							ToolStripItem toolStripItem = this.ContextMenuStrip2.Items.Add(this.zdyarray[i]);
							toolStripItem.Click += this.ToolStripMenuItem5_Click;
						}
					}
					if (this.ContextMenuStrip2.Items.Count <= 0)
					{
						this.Button2.Enabled = false;
					}
				}
				if (this.myfield == null)
				{
					this.Button3.Enabled = false;
				}
				else if (this.myfield.Length < 0)
				{
					this.Button3.Enabled = false;
				}
				else
				{
					this.Button3.Enabled = true;
					int num3 = 0;
					int num4 = this.myfield.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						ToolStripItem toolStripItem2 = this.ContextMenuStrip3.Items.Add(this.myfield[j]);
						toolStripItem2.Click += this.ToolStripMenuItem5_Click;
					}
				}
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00006751 File Offset: 0x00004951
		private void Button3_Click(object sender, EventArgs e)
		{
			this.ContextMenuStrip3.Show((Control)sender, 0, 0);
		}

		// Token: 0x0400088B RID: 2187
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400088C RID: 2188
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400088D RID: 2189
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400088E RID: 2190
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400088F RID: 2191
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000890 RID: 2192
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000891 RID: 2193
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000892 RID: 2194
		[AccessedThroughProperty("页码ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000893 RID: 2195
		[AccessedThroughProperty("总页数ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000894 RID: 2196
		[AccessedThroughProperty("当前日期ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000895 RID: 2197
		[AccessedThroughProperty("当前日期2ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000896 RID: 2198
		[AccessedThroughProperty("当前年ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000897 RID: 2199
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000898 RID: 2200
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x04000899 RID: 2201
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x0400089A RID: 2202
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x0400089B RID: 2203
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem _ToolStripMenuItem5;

		// Token: 0x0400089C RID: 2204
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400089D RID: 2205
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x0400089E RID: 2206
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x0400089F RID: 2207
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040008A0 RID: 2208
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x040008A1 RID: 2209
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008A2 RID: 2210
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008A3 RID: 2211
		public string[] myfield;

		// Token: 0x040008A4 RID: 2212
		public string[] zdyarray;
	}
}
