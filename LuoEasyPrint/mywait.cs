using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	internal partial class mywait : Form
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x000042CF File Offset: 0x000024CF
		[DebuggerNonUserCode]
		public mywait()
		{
			base.Load += this.mywait_Load;
			this.InitializeComponent();
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0004E640 File Offset: 0x0004C840
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x0000430F File Offset: 0x0000250F
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

		// Token: 0x06000858 RID: 2136 RVA: 0x00004318 File Offset: 0x00002518
		private void mywait_Load(object sender, EventArgs e)
		{
			this.Visible = true;
		}

		// Token: 0x04000498 RID: 1176
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
