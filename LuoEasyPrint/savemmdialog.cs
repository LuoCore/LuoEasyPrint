using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200008D RID: 141
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class savemmdialog : Form
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x00006A77 File Offset: 0x00004C77
		public savemmdialog()
		{
			base.Load += this.savemmdialog_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000902B4 File Offset: 0x0008E4B4
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00006A98 File Offset: 0x00004C98
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000902CC File Offset: 0x0008E4CC
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x000902E4 File Offset: 0x0008E4E4
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00090330 File Offset: 0x0008E530
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x00090348 File Offset: 0x0008E548
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00090394 File Offset: 0x0008E594
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00006AA1 File Offset: 0x00004CA1
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000903AC File Offset: 0x0008E5AC
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00006AAA File Offset: 0x00004CAA
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000903C4 File Offset: 0x0008E5C4
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00006AB3 File Offset: 0x00004CB3
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000903DC File Offset: 0x0008E5DC
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x00006ABC File Offset: 0x00004CBC
		internal virtual TextBox TextBox2
		{
			get
			{
				return this._TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000903F4 File Offset: 0x0008E5F4
		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (String.Compare(this.TextBox1.Text, this.TextBox2.Text, false) != 0)
			{
				Interaction.MsgBox("前后2次密码不一致，请重输", MsgBoxStyle.OkOnly, "提示信息");
				this.TextBox1.Focus();
			}
			else if (String.Compare(this.TextBox1.Text, "", false) == 0)
			{
				Interaction.MsgBox("密码不能为空", MsgBoxStyle.OkOnly, "提示信息");
				this.TextBox1.Focus();
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00006AC5 File Offset: 0x00004CC5
		private void savemmdialog_Load(object sender, EventArgs e)
		{
			this.TextBox1.Focus();
			this.TextBox1.Text = "";
			this.TextBox2.Text = "";
		}

		// Token: 0x04000991 RID: 2449
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000992 RID: 2450
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000993 RID: 2451
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x04000994 RID: 2452
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000995 RID: 2453
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000996 RID: 2454
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000997 RID: 2455
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;
	}
}
