using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000086 RID: 134
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class progress : Form
	{
		// Token: 0x0600120D RID: 4621 RVA: 0x000069D0 File Offset: 0x00004BD0
		public progress()
		{
			base.Load += this.progress_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0008F49C File Offset: 0x0008D69C
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000069F1 File Offset: 0x00004BF1
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0008F4B4 File Offset: 0x0008D6B4
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x0008F4CC File Offset: 0x0008D6CC
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

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0008F518 File Offset: 0x0008D718
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000069FA File Offset: 0x00004BFA
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0008F530 File Offset: 0x0008D730
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x00006A03 File Offset: 0x00004C03
		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0008F548 File Offset: 0x0008D748
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00006A0C File Offset: 0x00004C0C
		internal virtual Panel Panel3
		{
			get
			{
				return this._Panel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel3 = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x0008F560 File Offset: 0x0008D760
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0008F578 File Offset: 0x0008D778
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

		// Token: 0x0600121C RID: 4636 RVA: 0x00006A15 File Offset: 0x00004C15
		public void SetStatus(string tt)
		{
			this.Label1.Text = tt;
			Application.DoEvents();
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00006A28 File Offset: 0x00004C28
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Module1.G_CancelDocument = true;
			Module1.G_CancelPrint = true;
			this.Close();
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00006A43 File Offset: 0x00004C43
		private void progress_Load(object sender, EventArgs e)
		{
			this.Button1.Visible = true;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00006A51 File Offset: 0x00004C51
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			this.Close();
		}

		// Token: 0x0400095E RID: 2398
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400095F RID: 2399
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000960 RID: 2400
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x04000961 RID: 2401
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000962 RID: 2402
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		// Token: 0x04000963 RID: 2403
		[AccessedThroughProperty("Button2")]
		private Button _Button2;
	}
}
