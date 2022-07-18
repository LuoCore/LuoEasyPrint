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
	// Token: 0x02000079 RID: 121
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class OpenmmDialog : Form
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x000068DD File Offset: 0x00004ADD
		public OpenmmDialog()
		{
			base.Load += this.OpenmmDialog_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0008DB58 File Offset: 0x0008BD58
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x000068FE File Offset: 0x00004AFE
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0008DB70 File Offset: 0x0008BD70
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0008DB88 File Offset: 0x0008BD88
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0008DBD4 File Offset: 0x0008BDD4
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0008DBEC File Offset: 0x0008BDEC
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

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0008DC38 File Offset: 0x0008BE38
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x00006907 File Offset: 0x00004B07
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

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0008DC50 File Offset: 0x0008BE50
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00006910 File Offset: 0x00004B10
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

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0008DC68 File Offset: 0x0008BE68
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0008DC80 File Offset: 0x0008BE80
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0008DCCC File Offset: 0x0008BECC
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00006919 File Offset: 0x00004B19
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

		// Token: 0x060011E2 RID: 4578 RVA: 0x0008DCE4 File Offset: 0x0008BEE4
		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (String.Compare(this.TextBox1.Text, "", false) == 0)
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

		// Token: 0x060011E3 RID: 4579 RVA: 0x000048A3 File Offset: 0x00002AA3
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00006922 File Offset: 0x00004B22
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBox1.Checked)
			{
				this.TextBox1.PasswordChar = '\0';
			}
			else
			{
				this.TextBox1.PasswordChar = '*';
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0000694C File Offset: 0x00004B4C
		private void OpenmmDialog_Load(object sender, EventArgs e)
		{
			this.TextBox1.Focus();
		}

		// Token: 0x040008D1 RID: 2257
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040008D2 RID: 2258
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040008D3 RID: 2259
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040008D4 RID: 2260
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008D5 RID: 2261
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040008D6 RID: 2262
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x040008D7 RID: 2263
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
