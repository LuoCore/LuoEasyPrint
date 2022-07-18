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
	// Token: 0x0200006E RID: 110
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class SetNumberFormat : Form
	{
		// Token: 0x06000DCD RID: 3533 RVA: 0x00005A6D File Offset: 0x00003C6D
		public SetNumberFormat()
		{
			base.Load += this.SetNumberFormat_Load;
			this.FormatString = "";
			this.sp_col = "~";
			this.InitializeComponent();
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0006F374 File Offset: 0x0006D574
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0006F38C File Offset: 0x0006D58C
		internal virtual RadioButton r1
		{
			get
			{
				return this._r1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.r3_CheckedChanged);
				if (this._r1 != null)
				{
					this._r1.CheckedChanged -= value2;
				}
				this._r1 = value;
				if (this._r1 != null)
				{
					this._r1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0006F3F0 File Offset: 0x0006D5F0
		internal virtual RadioButton r2
		{
			get
			{
				return this._r2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.r3_CheckedChanged);
				if (this._r2 != null)
				{
					this._r2.CheckedChanged -= value2;
				}
				this._r2 = value;
				if (this._r2 != null)
				{
					this._r2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0006F43C File Offset: 0x0006D63C
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0006F454 File Offset: 0x0006D654
		internal virtual RadioButton r3
		{
			get
			{
				return this._r3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.r3_CheckedChanged);
				if (this._r3 != null)
				{
					this._r3.CheckedChanged -= value2;
				}
				this._r3 = value;
				if (this._r3 != null)
				{
					this._r3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0006F4A0 File Offset: 0x0006D6A0
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00005AA4 File Offset: 0x00003CA4
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0006F4B8 File Offset: 0x0006D6B8
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00005AAD File Offset: 0x00003CAD
		internal virtual GroupBox GroupBox9
		{
			get
			{
				return this._GroupBox9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox9 = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0006F4D0 File Offset: 0x0006D6D0
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00005AB6 File Offset: 0x00003CB6
		internal virtual TextBox xg
		{
			get
			{
				return this._xg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._xg = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0006F4E8 File Offset: 0x0006D6E8
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00005ABF File Offset: 0x00003CBF
		internal virtual Label Label16
		{
			get
			{
				return this._Label16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0006F500 File Offset: 0x0006D700
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0006F518 File Offset: 0x0006D718
		internal virtual TextBox comptxt
		{
			get
			{
				return this._comptxt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.comptxt_TextChanged);
				if (this._comptxt != null)
				{
					this._comptxt.TextChanged -= value2;
				}
				this._comptxt = value;
				if (this._comptxt != null)
				{
					this._comptxt.TextChanged += value2;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0006F564 File Offset: 0x0006D764
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00005AC8 File Offset: 0x00003CC8
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0006F57C File Offset: 0x0006D77C
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00005AD1 File Offset: 0x00003CD1
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0006F594 File Offset: 0x0006D794
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0006F5AC File Offset: 0x0006D7AC
		internal virtual NumericUpDown NumericUpDown1
		{
			get
			{
				return this._NumericUpDown1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NumericUpDown1_ValueChanged);
				if (this._NumericUpDown1 != null)
				{
					this._NumericUpDown1.ValueChanged -= value2;
				}
				this._NumericUpDown1 = value;
				if (this._NumericUpDown1 != null)
				{
					this._NumericUpDown1.ValueChanged += value2;
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0006F5F8 File Offset: 0x0006D7F8
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0006F610 File Offset: 0x0006D810
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0006F65C File Offset: 0x0006D85C
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x00005ADA File Offset: 0x00003CDA
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0006F674 File Offset: 0x0006D874
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x0006F68C File Offset: 0x0006D88C
		internal virtual ComboBox ComboBox1
		{
			get
			{
				return this._ComboBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox1_TextChanged);
				if (this._ComboBox1 != null)
				{
					this._ComboBox1.TextChanged -= value2;
				}
				this._ComboBox1 = value;
				if (this._ComboBox1 != null)
				{
					this._ComboBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00005AE3 File Offset: 0x00003CE3
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0006F6F0 File Offset: 0x0006D8F0
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0006F708 File Offset: 0x0006D908
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged -= value2;
				}
				this._TextBox1 = value;
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0006F754 File Offset: 0x0006D954
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0006F76C File Offset: 0x0006D96C
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0006F7B8 File Offset: 0x0006D9B8
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00005AEC File Offset: 0x00003CEC
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

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00005AF5 File Offset: 0x00003CF5
		private void Button1_Click(object sender, EventArgs e)
		{
			this.sformatstring = this.SaveFormat();
			this.FormatString = this.TextBox1.Text;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0006F7D0 File Offset: 0x0006D9D0
		private string GetFormat()
		{
			string result;
			if (this.r3.Checked)
			{
				result = "";
			}
			else
			{
				string text = Strings.Space(Convert.ToInt32(this.NumericUpDown1.Value));
				text = Strings.Replace(text, " ", "0", 1, -1, CompareMethod.Binary);
				if (String.Compare(text, "", false) != 0)
				{
					text = "##0." + text;
				}
				else
				{
					text = "##0";
				}
				if (this.CheckBox1.Checked)
				{
					text = "#," + text;
				}
				text = this.ComboBox1.Text + text;
				if (!this.r1.Checked)
				{
					text += "%";
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0006F890 File Offset: 0x0006DA90
		private void SetNumberFormat_Load(object sender, EventArgs e)
		{
			if (String.Compare(this.sformatstring, "", false) == 0)
			{
				this.r3.Checked = true;
			}
			else
			{
				string[] array = Strings.Split(this.sformatstring, this.sp_col, -1, CompareMethod.Binary);
				if (array.Length == 5)
				{
					if (String.Compare(array[4], this.FormatString, false) != 0)
					{
						this.r3.Checked = true;
					}
					else
					{
						string left = array[0];
						if (String.Compare(left, "0", false) == 0)
						{
							this.r1.Checked = true;
						}
						else if (String.Compare(left, "1", false) == 0)
						{
							this.r2.Checked = true;
						}
						else
						{
							this.r3.Checked = true;
						}
						if (Versioned.IsNumeric(array[1]))
						{
							this.NumericUpDown1.Value = new decimal(Convert.ToInt32(array[1]));
						}
						if (String.Compare(array[2], "1", false) == 0)
						{
							this.CheckBox1.Checked = true;
						}
						else
						{
							this.CheckBox1.Checked = false;
						}
						this.ComboBox1.Text = array[3];
					}
				}
				else
				{
					this.r3.Checked = true;
				}
			}
			this.TextBox1.Text = this.FormatString;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
		private void r3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.r1.Checked | this.r2.Checked)
			{
				this.NumericUpDown1.Enabled = true;
				this.CheckBox1.Enabled = true;
				this.ComboBox1.Enabled = true;
				this.TextBox1.Enabled = false;
				this.TextBox1.Text = this.GetFormat();
			}
			else
			{
				this.NumericUpDown1.Enabled = false;
				this.CheckBox1.Enabled = false;
				this.ComboBox1.Enabled = false;
				this.TextBox1.Enabled = true;
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0006FA64 File Offset: 0x0006DC64
		public string SaveFormat()
		{
			string str;
			if (this.r1.Checked)
			{
				str = "0";
			}
			else if (this.r2.Checked)
			{
				str = "1";
			}
			else
			{
				str = "2";
			}
			str += this.sp_col;
			str += Convert.ToString(this.NumericUpDown1.Value);
			str += this.sp_col;
			if (this.CheckBox1.Checked)
			{
				str += "1";
			}
			else
			{
				str += "0";
			}
			str = str + this.sp_col + this.ComboBox1.Text;
			return str + this.sp_col + this.TextBox1.Text;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00005B14 File Offset: 0x00003D14
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.xg.Text = this.GetFormatValue(this.comptxt.Text, this.TextBox1.Text);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0006FB34 File Offset: 0x0006DD34
		public string GetFormatValue(string value, string valueformat)
		{
			string result;
			if (!Versioned.IsNumeric(value))
			{
				result = value;
			}
			else
			{
				try
				{
					result = Strings.Format(Convert.ToDecimal(value), valueformat);
				}
				catch (Exception ex)
				{
					result = value;
				}
			}
			return result;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00005B14 File Offset: 0x00003D14
		private void comptxt_TextChanged(object sender, EventArgs e)
		{
			this.xg.Text = this.GetFormatValue(this.comptxt.Text, this.TextBox1.Text);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00005B3D File Offset: 0x00003D3D
		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.TextBox1.Text = this.GetFormat();
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00005B3D File Offset: 0x00003D3D
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.TextBox1.Text = this.GetFormat();
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00005B3D File Offset: 0x00003D3D
		private void ComboBox1_TextChanged(object sender, EventArgs e)
		{
			this.TextBox1.Text = this.GetFormat();
		}

		// Token: 0x04000702 RID: 1794
		[AccessedThroughProperty("r1")]
		private RadioButton _r1;

		// Token: 0x04000703 RID: 1795
		[AccessedThroughProperty("r2")]
		private RadioButton _r2;

		// Token: 0x04000704 RID: 1796
		[AccessedThroughProperty("r3")]
		private RadioButton _r3;

		// Token: 0x04000705 RID: 1797
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000706 RID: 1798
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04000707 RID: 1799
		[AccessedThroughProperty("xg")]
		private TextBox _xg;

		// Token: 0x04000708 RID: 1800
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000709 RID: 1801
		[AccessedThroughProperty("comptxt")]
		private TextBox _comptxt;

		// Token: 0x0400070A RID: 1802
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400070B RID: 1803
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400070C RID: 1804
		[AccessedThroughProperty("NumericUpDown1")]
		private NumericUpDown _NumericUpDown1;

		// Token: 0x0400070D RID: 1805
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x0400070E RID: 1806
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400070F RID: 1807
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000710 RID: 1808
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000711 RID: 1809
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000712 RID: 1810
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000713 RID: 1811
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000714 RID: 1812
		public string FormatString;

		// Token: 0x04000715 RID: 1813
		public string sformatstring;

		// Token: 0x04000716 RID: 1814
		private string sp_col;
	}
}
