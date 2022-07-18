using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200008E RID: 142
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class tempform : Form
	{
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000905F0 File Offset: 0x0008E7F0
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00006AF3 File Offset: 0x00004CF3
		internal virtual DataGridView dd
		{
			get
			{
				return this._dd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dd = value;
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00006AFC File Offset: 0x00004CFC
		public tempform()
		{
			this.InitializeComponent();
		}

		// Token: 0x04000999 RID: 2457
		[AccessedThroughProperty("dd")]
		private DataGridView _dd;
	}
}
