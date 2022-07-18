using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000135 RID: 309
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class progressexcel : Form
	{
		// Token: 0x06001CE4 RID: 7396 RVA: 0x0000A187 File Offset: 0x00008387
		public progressexcel()
		{
			base.Load += this.progressexcel_Load;
			this.InitializeComponent();
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x000E7CFC File Offset: 0x000E5EFC
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0000A1A8 File Offset: 0x000083A8
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

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x000E7D14 File Offset: 0x000E5F14
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x000E7D2C File Offset: 0x000E5F2C
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

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000E7D78 File Offset: 0x000E5F78
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0000A1B1 File Offset: 0x000083B1
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000E7D90 File Offset: 0x000E5F90
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0000A1BA File Offset: 0x000083BA
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

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000E7DA8 File Offset: 0x000E5FA8
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0000A1C3 File Offset: 0x000083C3
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x000E7DC0 File Offset: 0x000E5FC0
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000A1CC File Offset: 0x000083CC
		internal virtual ProgressBar ProgressBar1
		{
			get
			{
				return this._ProgressBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0000A1D5 File Offset: 0x000083D5
		public void SetStatus(string tt)
		{
			this.Label1.Text = tt;
			Application.DoEvents();
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0000A1E8 File Offset: 0x000083E8
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Module1.G_CancelExportDGVToExcel = true;
			this.Close();
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0000A1FD File Offset: 0x000083FD
		private void progressexcel_Load(object sender, EventArgs e)
		{
			this.Button1.Visible = true;
		}

		// Token: 0x04000EA5 RID: 3749
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000EA6 RID: 3750
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000EA7 RID: 3751
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x04000EA8 RID: 3752
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000EA9 RID: 3753
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000EAA RID: 3754
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;
	}
}
