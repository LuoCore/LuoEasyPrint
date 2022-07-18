using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000085 RID: 133
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class PrintZoomSet : Form
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x00006995 File Offset: 0x00004B95
		public PrintZoomSet()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0008EEB4 File Offset: 0x0008D0B4
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x000069A3 File Offset: 0x00004BA3
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0008EECC File Offset: 0x0008D0CC
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x0008EEE4 File Offset: 0x0008D0E4
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0008EF30 File Offset: 0x0008D130
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0008EF48 File Offset: 0x0008D148
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

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0008EF94 File Offset: 0x0008D194
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x000069AC File Offset: 0x00004BAC
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0008EFAC File Offset: 0x0008D1AC
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x000069B5 File Offset: 0x00004BB5
		internal virtual NumericUpDown NumericUpDown1
		{
			get
			{
				return this._NumericUpDown1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown1 = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x000069BE File Offset: 0x00004BBE
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

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0008EFDC File Offset: 0x0008D1DC
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x000069C7 File Offset: 0x00004BC7
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

		// Token: 0x0600120B RID: 4619 RVA: 0x00004894 File Offset: 0x00002A94
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000956 RID: 2390
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000957 RID: 2391
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000958 RID: 2392
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x04000959 RID: 2393
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400095A RID: 2394
		[AccessedThroughProperty("NumericUpDown1")]
		private NumericUpDown _NumericUpDown1;

		// Token: 0x0400095B RID: 2395
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400095C RID: 2396
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
	}
}
