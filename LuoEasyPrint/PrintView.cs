using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000084 RID: 132
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class PrintView : Form
	{
		// Token: 0x060011F5 RID: 4597 RVA: 0x0000697E File Offset: 0x00004B7E
		public PrintView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0008E88C File Offset: 0x0008CA8C
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000698C File Offset: 0x00004B8C
		

		internal virtual VB2008Print myp
		{
			get
			{
				return this._myp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._myp = value;
			}
		}

		// Token: 0x04000954 RID: 2388
		[AccessedThroughProperty("myp")]
		private VB2008Print _myp;
	}
}
