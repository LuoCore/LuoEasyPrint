using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000070 RID: 112
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class SimpleReportAddHeader : Form
	{
		// Token: 0x06000E3C RID: 3644 RVA: 0x00005CAC File Offset: 0x00003EAC
		public SimpleReportAddHeader()
		{
			this.InitializeComponent();
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00070B70 File Offset: 0x0006ED70
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00005CBA File Offset: 0x00003EBA
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00070B88 File Offset: 0x0006ED88
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		internal virtual TextBox txt
		{
			get
			{
				return this._txt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_DoubleClick);
				if (this._txt != null)
				{
					this._txt.DoubleClick -= value2;
				}
				this._txt = value;
				if (this._txt != null)
				{
					this._txt.DoubleClick += value2;
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00070BEC File Offset: 0x0006EDEC
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00005CC3 File Offset: 0x00003EC3
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00070C04 File Offset: 0x0006EE04
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00005CCC File Offset: 0x00003ECC
		internal virtual NumericUpDown jc
		{
			get
			{
				return this._jc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._jc = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00070C1C File Offset: 0x0006EE1C
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00005CD5 File Offset: 0x00003ED5
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00070C34 File Offset: 0x0006EE34
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00005CDE File Offset: 0x00003EDE
		internal virtual ComboBox dq
		{
			get
			{
				return this._dq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dq = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00070C4C File Offset: 0x0006EE4C
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00005CE7 File Offset: 0x00003EE7
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00070C64 File Offset: 0x0006EE64
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00005CF0 File Offset: 0x00003EF0
		internal virtual NumericUpDown gd
		{
			get
			{
				return this._gd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gd = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00070C7C File Offset: 0x0006EE7C
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00005CF9 File Offset: 0x00003EF9
		internal virtual FontDialog FontDialog1
		{
			get
			{
				return this._FontDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FontDialog1 = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00070C94 File Offset: 0x0006EE94
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00070CAC File Offset: 0x0006EEAC
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00005D02 File Offset: 0x00003F02
		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00070D10 File Offset: 0x0006EF10
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00005D0B File Offset: 0x00003F0B
		internal virtual NumericUpDown kd
		{
			get
			{
				return this._kd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._kd = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00070D28 File Offset: 0x0006EF28
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00005D14 File Offset: 0x00003F14
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button3 = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00070D40 File Offset: 0x0006EF40
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00005D1D File Offset: 0x00003F1D
		internal virtual Button Button4
		{
			get
			{
				return this._Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button4 = value;
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00070D58 File Offset: 0x0006EF58
		private void Button1_Click(object sender, EventArgs e)
		{
			this.FontDialog1.Font = this.txt.Font;
			this.FontDialog1.ShowColor = true;
			this.FontDialog1.Color = this.txt.ForeColor;
			if (this.FontDialog1.ShowDialog() == DialogResult.OK)
			{
				this.txt.Font = this.FontDialog1.Font;
				this.txt.ForeColor = this.FontDialog1.Color;
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00005D26 File Offset: 0x00003F26
		private void txt_DoubleClick(object sender, EventArgs e)
		{
			this.txt.Text = SimpleReportModule.ShowSimpleReportText(this.txt.Text, this.thefieldstring, this.zdyarray);
		}

		// Token: 0x04000733 RID: 1843
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000734 RID: 1844
		[AccessedThroughProperty("txt")]
		private TextBox _txt;

		// Token: 0x04000735 RID: 1845
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000736 RID: 1846
		[AccessedThroughProperty("jc")]
		private NumericUpDown _jc;

		// Token: 0x04000737 RID: 1847
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000738 RID: 1848
		[AccessedThroughProperty("dq")]
		private ComboBox _dq;

		// Token: 0x04000739 RID: 1849
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400073A RID: 1850
		[AccessedThroughProperty("gd")]
		private NumericUpDown _gd;

		// Token: 0x0400073B RID: 1851
		[AccessedThroughProperty("FontDialog1")]
		private FontDialog _FontDialog1;

		// Token: 0x0400073C RID: 1852
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400073D RID: 1853
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400073E RID: 1854
		[AccessedThroughProperty("kd")]
		private NumericUpDown _kd;

		// Token: 0x0400073F RID: 1855
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000740 RID: 1856
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000741 RID: 1857
		public string[] thefieldstring;

		// Token: 0x04000742 RID: 1858
		public string[] zdyarray;
	}
}
