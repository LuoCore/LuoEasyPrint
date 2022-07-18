using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000087 RID: 135
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class progress2 : Form
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x00006A60 File Offset: 0x00004C60
		public progress2()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0008F774 File Offset: 0x0008D974
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00006A6E File Offset: 0x00004C6E
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

		// Token: 0x04000965 RID: 2405
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
