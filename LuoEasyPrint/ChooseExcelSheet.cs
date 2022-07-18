using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000118 RID: 280
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class ChooseExcelSheet : Form
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x0000A0A7 File Offset: 0x000082A7
		public ChooseExcelSheet()
		{
			this.InitializeComponent();
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x000E1758 File Offset: 0x000DF958
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0000A0B5 File Offset: 0x000082B5
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x000E1770 File Offset: 0x000DF970
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0000A0BE File Offset: 0x000082BE
		internal virtual ComboBox ComboBox1
		{
			get
			{
				return this._ComboBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x000E1788 File Offset: 0x000DF988
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0000A0C7 File Offset: 0x000082C7
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

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x000E17A0 File Offset: 0x000DF9A0
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0000A0D0 File Offset: 0x000082D0
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button2 = value;
			}
		}

		// Token: 0x04000E18 RID: 3608
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000E19 RID: 3609
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000E1A RID: 3610
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000E1B RID: 3611
		[AccessedThroughProperty("Button2")]
		private Button _Button2;
	}
}
