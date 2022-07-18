using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000037 RID: 55
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class ReportPageSetup : Form
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x0004EB58 File Offset: 0x0004CD58
		public ReportPageSetup()
		{
			base.Disposed += this.ReportPageSetup_Disposed;
			base.Load += this.ReportPageSetup_Load;
			this.myprintername = "";
			this.mypp = new CommomPaperSize();
			this.InitializeComponent();
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0004FEE0 File Offset: 0x0004E0E0
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00004399 File Offset: 0x00002599
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x000043A2 File Offset: 0x000025A2
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0004FF10 File Offset: 0x0004E110
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x000043AB File Offset: 0x000025AB
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0004FF28 File Offset: 0x0004E128
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0004FF40 File Offset: 0x0004E140
		internal virtual ComboBox ComboBox1
		{
			get
			{
				return this._ComboBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				if (this._ComboBox1 != null)
				{
					this._ComboBox1.SelectedIndexChanged -= value2;
				}
				this._ComboBox1 = value;
				if (this._ComboBox1 != null)
				{
					this._ComboBox1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0004FF8C File Offset: 0x0004E18C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000043B4 File Offset: 0x000025B4
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000043BD File Offset: 0x000025BD
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0004FFBC File Offset: 0x0004E1BC
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000043C6 File Offset: 0x000025C6
		internal virtual RadioButton fx2
		{
			get
			{
				return this._fx2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fx2 = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0004FFD4 File Offset: 0x0004E1D4
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000043CF File Offset: 0x000025CF
		internal virtual RadioButton fx1
		{
			get
			{
				return this._fx1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fx1 = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0004FFEC File Offset: 0x0004E1EC
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x000043D8 File Offset: 0x000025D8
		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00050004 File Offset: 0x0004E204
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000043E1 File Offset: 0x000025E1
		internal virtual NumericUpDown printb
		{
			get
			{
				return this._printb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._printb = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0005001C File Offset: 0x0004E21C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x000043EA File Offset: 0x000025EA
		internal virtual NumericUpDown printr
		{
			get
			{
				return this._printr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._printr = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00050034 File Offset: 0x0004E234
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x000043F3 File Offset: 0x000025F3
		public virtual Label Label14
		{
			get
			{
				return this._Label14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0005004C File Offset: 0x0004E24C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000043FC File Offset: 0x000025FC
		internal virtual NumericUpDown printt
		{
			get
			{
				return this._printt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._printt = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00050064 File Offset: 0x0004E264
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00004405 File Offset: 0x00002605
		public virtual Label Label12
		{
			get
			{
				return this._Label12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0005007C File Offset: 0x0004E27C
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0000440E File Offset: 0x0000260E
		internal virtual NumericUpDown printl
		{
			get
			{
				return this._printl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._printl = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00050094 File Offset: 0x0004E294
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00004417 File Offset: 0x00002617
		public virtual Label Label13
		{
			get
			{
				return this._Label13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000500AC File Offset: 0x0004E2AC
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00004420 File Offset: 0x00002620
		public virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000500C4 File Offset: 0x0004E2C4
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00004429 File Offset: 0x00002629
		internal virtual GroupBox GroupBox4
		{
			get
			{
				return this._GroupBox4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000500DC File Offset: 0x0004E2DC
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00004432 File Offset: 0x00002632
		internal virtual RadioButton dq3
		{
			get
			{
				return this._dq3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dq3 = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000500F4 File Offset: 0x0004E2F4
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0000443B File Offset: 0x0000263B
		internal virtual RadioButton dq2
		{
			get
			{
				return this._dq2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dq2 = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0005010C File Offset: 0x0004E30C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00004444 File Offset: 0x00002644
		internal virtual RadioButton dq1
		{
			get
			{
				return this._dq1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dq1 = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00050124 File Offset: 0x0004E324
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x0005013C File Offset: 0x0004E33C
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00050188 File Offset: 0x0004E388
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x000501A0 File Offset: 0x0004E3A0
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000501EC File Offset: 0x0004E3EC
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0000444D File Offset: 0x0000264D
		internal virtual NumericUpDown myh
		{
			get
			{
				return this._myh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._myh = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00050204 File Offset: 0x0004E404
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00004456 File Offset: 0x00002656
		internal virtual NumericUpDown myw
		{
			get
			{
				return this._myw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._myw = value;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0000445F File Offset: 0x0000265F
		private void ReportPageSetup_Disposed(object sender, EventArgs e)
		{
			this.mypp.Dispose();
			this.mypp = null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0005021C File Offset: 0x0004E41C
		private void ReportPageSetup_Load(object sender, EventArgs e)
		{
			this.ComboBox1.Items.Clear();
			PrinterSettings printerSettings = new PrinterSettings();
			if (String.Compare(this.myprintername, "", false) != 0 && Module1.IsValidPrinterName(this.myprintername))
			{
				printerSettings.PrinterName = this.myprintername;
			}
			PrinterSettings.PaperSizeCollection paperSizes = printerSettings.PaperSizes;
			string text = "";
			int num = 0;
			checked
			{
				int num2 = paperSizes.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(paperSizes[i].PaperName, "[自定义纸张]", false) != 0)
					{
						this.ComboBox1.Items.Add(paperSizes[i].PaperName);
						if (i == 0)
						{
							text = Convert.ToString((int)paperSizes[i].Kind);
						}
						else
						{
							text = text + "," + Convert.ToString((int)paperSizes[i].Kind);
						}
					}
				}
				this.ComboBox1.Items.Add("[自定义纸张]");
				text += ",0";
				this.ComboBox1.Tag = text;
				try
				{
					if (String.Compare(this.w_papername, "[自定义纸张]", false) == 0)
					{
						this.ComboBox1.SelectedItem = this.w_papername;
						this.myw.Value = new decimal(this.w_paperwidth);
						this.myh.Value = new decimal(this.w_paperheight);
					}
					else if (this.ComboBox1.Items.IndexOf(this.w_papername) >= 0)
					{
						this.ComboBox1.SelectedItem = this.w_papername;
					}
					else
					{
						this.myw.ReadOnly = false;
						this.myh.ReadOnly = false;
						this.ComboBox1.Text = "[自定义纸张]";
						this.myw.Value = new decimal(this.w_paperwidth);
						this.myh.Value = new decimal(this.w_paperheight);
					}
				}
				catch (Exception ex)
				{
				}
				if (this.w_paperlandscape)
				{
					this.fx2.Checked = true;
				}
				else
				{
					this.fx1.Checked = true;
				}
				this.printl.Value = new decimal(this.w_leftmargin);
				this.printr.Value = new decimal(this.w_rightmargin);
				this.printt.Value = new decimal(this.w_topmargin);
				this.printb.Value = new decimal(this.w_bottommargin);
				switch (this.w_tablealign)
				{
				case StringAlignment.Center:
					this.dq2.Checked = true;
					break;
				case StringAlignment.Far:
					this.dq3.Checked = true;
					break;
				default:
					this.dq1.Checked = true;
					break;
				}
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000504D8 File Offset: 0x0004E6D8
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (String.Compare(this.ComboBox1.Text, "[自定义纸张]", false) == 0)
			{
				this.myh.ReadOnly = false;
				this.myw.ReadOnly = false;
			}
			else
			{
				this.myh.ReadOnly = true;
				this.myw.ReadOnly = true;
				PaperSize printForm = definepaper.GetPrintForm(this.myprintername, this.ComboBox1.Text);
				if (printForm != null)
				{
					this.myw.Value = new decimal((double)printForm.Width * 2.54 / 10.0);
					this.myh.Value = new decimal((double)printForm.Height * 2.54 / 10.0);
				}
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000505A8 File Offset: 0x0004E7A8
		private void Button1_Click(object sender, EventArgs e)
		{
			this.w_leftmargin = Convert.ToSingle(this.printl.Value);
			this.w_rightmargin = Convert.ToSingle(this.printr.Value);
			this.w_topmargin = Convert.ToSingle(this.printt.Value);
			this.w_bottommargin = Convert.ToSingle(this.printb.Value);
			this.w_papername = this.ComboBox1.Text;
			try
			{
				this.w_paperwidth = Convert.ToSingle(this.myw.Value);
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.w_paperheight = Convert.ToSingle(this.myh.Value);
			}
			catch (Exception ex2)
			{
			}
			if (this.fx1.Checked)
			{
				this.w_paperlandscape = false;
			}
			else
			{
				this.w_paperlandscape = true;
			}
			if (this.dq3.Checked)
			{
				this.w_tablealign = StringAlignment.Far;
			}
			else if (this.dq2.Checked)
			{
				this.w_tablealign = StringAlignment.Center;
			}
			else
			{
				this.w_tablealign = StringAlignment.Near;
			}
			this.Close();
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000025D6 File Offset: 0x000007D6
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x040004A4 RID: 1188
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040004A5 RID: 1189
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040004A6 RID: 1190
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040004A7 RID: 1191
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x040004A8 RID: 1192
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040004A9 RID: 1193
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040004AA RID: 1194
		[AccessedThroughProperty("fx2")]
		private RadioButton _fx2;

		// Token: 0x040004AB RID: 1195
		[AccessedThroughProperty("fx1")]
		private RadioButton _fx1;

		// Token: 0x040004AC RID: 1196
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040004AD RID: 1197
		[AccessedThroughProperty("printb")]
		private NumericUpDown _printb;

		// Token: 0x040004AE RID: 1198
		[AccessedThroughProperty("printr")]
		private NumericUpDown _printr;

		// Token: 0x040004AF RID: 1199
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040004B0 RID: 1200
		[AccessedThroughProperty("printt")]
		private NumericUpDown _printt;

		// Token: 0x040004B1 RID: 1201
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040004B2 RID: 1202
		[AccessedThroughProperty("printl")]
		private NumericUpDown _printl;

		// Token: 0x040004B3 RID: 1203
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040004B4 RID: 1204
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040004B5 RID: 1205
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040004B6 RID: 1206
		[AccessedThroughProperty("dq3")]
		private RadioButton _dq3;

		// Token: 0x040004B7 RID: 1207
		[AccessedThroughProperty("dq2")]
		private RadioButton _dq2;

		// Token: 0x040004B8 RID: 1208
		[AccessedThroughProperty("dq1")]
		private RadioButton _dq1;

		// Token: 0x040004B9 RID: 1209
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040004BA RID: 1210
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040004BB RID: 1211
		[AccessedThroughProperty("myh")]
		private NumericUpDown _myh;

		// Token: 0x040004BC RID: 1212
		[AccessedThroughProperty("myw")]
		private NumericUpDown _myw;

		// Token: 0x040004BD RID: 1213
		public string w_papername;

		// Token: 0x040004BE RID: 1214
		public float w_paperwidth;

		// Token: 0x040004BF RID: 1215
		public float w_paperheight;

		// Token: 0x040004C0 RID: 1216
		public float w_leftmargin;

		// Token: 0x040004C1 RID: 1217
		public float w_rightmargin;

		// Token: 0x040004C2 RID: 1218
		public float w_topmargin;

		// Token: 0x040004C3 RID: 1219
		public float w_bottommargin;

		// Token: 0x040004C4 RID: 1220
		public bool w_paperlandscape;

		// Token: 0x040004C5 RID: 1221
		public StringAlignment w_tablealign;

		// Token: 0x040004C6 RID: 1222
		public string myprintername;
	}
}
