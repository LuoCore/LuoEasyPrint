using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000078 RID: 120
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class draftset : Form
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000067BD File Offset: 0x000049BD
		public draftset()
		{
			base.Load += this.draftset_Load;
			this.papername = "";
			this.paperkind = PaperKind.A4;
			this.InitializeComponent();
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0008CAC4 File Offset: 0x0008ACC4
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x000067F1 File Offset: 0x000049F1
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0008CADC File Offset: 0x0008ACDC
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x0008CAF4 File Offset: 0x0008ACF4
		internal virtual ComboBox printername
		{
			get
			{
				return this._printername;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.printername_SelectedIndexChanged);
				if (this._printername != null)
				{
					this._printername.SelectedIndexChanged -= value2;
				}
				this._printername = value;
				if (this._printername != null)
				{
					this._printername.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x0008CB40 File Offset: 0x0008AD40
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x000067FA File Offset: 0x000049FA
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0008CB58 File Offset: 0x0008AD58
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00006803 File Offset: 0x00004A03
		internal virtual RadioButton RadioButton4
		{
			get
			{
				return this._RadioButton4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton4 = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0008CB70 File Offset: 0x0008AD70
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x0000680C File Offset: 0x00004A0C
		internal virtual RadioButton RadioButton3
		{
			get
			{
				return this._RadioButton3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton3 = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0008CB88 File Offset: 0x0008AD88
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00006815 File Offset: 0x00004A15
		internal virtual RadioButton RadioButton2
		{
			get
			{
				return this._RadioButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton2 = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0008CBA0 File Offset: 0x0008ADA0
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000681E File Offset: 0x00004A1E
		internal virtual RadioButton RadioButton1
		{
			get
			{
				return this._RadioButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton1 = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0008CBB8 File Offset: 0x0008ADB8
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00006827 File Offset: 0x00004A27
		internal virtual GroupBox GroupBox24
		{
			get
			{
				return this._GroupBox24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox24 = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0008CBD0 File Offset: 0x0008ADD0
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00006830 File Offset: 0x00004A30
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0008CBE8 File Offset: 0x0008ADE8
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00006839 File Offset: 0x00004A39
		internal virtual Label Label81
		{
			get
			{
				return this._Label81;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label81 = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0008CC00 File Offset: 0x0008AE00
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00006842 File Offset: 0x00004A42
		internal virtual ComboBox fx
		{
			get
			{
				return this._fx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fx = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0008CC18 File Offset: 0x0008AE18
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0000684B File Offset: 0x00004A4B
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0008CC30 File Offset: 0x0008AE30
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00006854 File Offset: 0x00004A54
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0008CC48 File Offset: 0x0008AE48
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0000685D File Offset: 0x00004A5D
		internal virtual Label Label82
		{
			get
			{
				return this._Label82;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label82 = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0008CC60 File Offset: 0x0008AE60
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x0008CC78 File Offset: 0x0008AE78
		internal virtual ComboBox papertype
		{
			get
			{
				return this._papertype;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.papertype_SelectedIndexChanged);
				if (this._papertype != null)
				{
					this._papertype.SelectedIndexChanged -= value2;
				}
				this._papertype = value;
				if (this._papertype != null)
				{
					this._papertype.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0008CCC4 File Offset: 0x0008AEC4
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00006866 File Offset: 0x00004A66
		internal virtual Label Label46
		{
			get
			{
				return this._Label46;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0008CCDC File Offset: 0x0008AEDC
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0008CCF4 File Offset: 0x0008AEF4
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

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0008CD40 File Offset: 0x0008AF40
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x0000686F File Offset: 0x00004A6F
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

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0008CD58 File Offset: 0x0008AF58
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00006878 File Offset: 0x00004A78
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0008CD70 File Offset: 0x0008AF70
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x0008CD88 File Offset: 0x0008AF88
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0008CDD4 File Offset: 0x0008AFD4
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00006881 File Offset: 0x00004A81
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

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0008CDEC File Offset: 0x0008AFEC
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0008CE04 File Offset: 0x0008B004
		internal virtual RadioButton RadioButton6
		{
			get
			{
				return this._RadioButton6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton5_CheckedChanged);
				if (this._RadioButton6 != null)
				{
					this._RadioButton6.CheckedChanged -= value2;
				}
				this._RadioButton6 = value;
				if (this._RadioButton6 != null)
				{
					this._RadioButton6.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0008CE50 File Offset: 0x0008B050
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0008CE68 File Offset: 0x0008B068
		internal virtual RadioButton RadioButton5
		{
			get
			{
				return this._RadioButton5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton5_CheckedChanged);
				if (this._RadioButton5 != null)
				{
					this._RadioButton5.CheckedChanged -= value2;
				}
				this._RadioButton5 = value;
				if (this._RadioButton5 != null)
				{
					this._RadioButton5.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0008CEB4 File Offset: 0x0008B0B4
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000688A File Offset: 0x00004A8A
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0008CECC File Offset: 0x0008B0CC
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00006893 File Offset: 0x00004A93
		internal virtual NumericUpDown fpage
		{
			get
			{
				return this._fpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fpage = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0008CEE4 File Offset: 0x0008B0E4
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000689C File Offset: 0x00004A9C
		internal virtual NumericUpDown tpage
		{
			get
			{
				return this._tpage;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tpage = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0008CEFC File Offset: 0x0008B0FC
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x000068A5 File Offset: 0x00004AA5
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0008CF14 File Offset: 0x0008B114
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x000068AE File Offset: 0x00004AAE
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

		// Token: 0x060011C8 RID: 4552 RVA: 0x0008CF2C File Offset: 0x0008B12C
		[EditorBrowsable(EditorBrowsableState.Never)]
		private void papertype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (String.Compare(this.papertype.Text, "[自定义纸张]", false) == 0)
			{
				this.myh.ReadOnly = false;
				this.myw.ReadOnly = false;
				this.myh.Value = this.mypaperheight;
				this.myw.Value = this.mypaperwidth;
			}
			else
			{
				this.myh.ReadOnly = true;
				this.myw.ReadOnly = true;
				PaperSize printForm = definepaper.GetPrintForm(this.curprinter, this.papertype.Text);
				this.myw.Value = new decimal((double)printForm.Width * 2.54 / 10.0);
				this.myh.Value = new decimal((double)printForm.Height * 2.54 / 10.0);
				this.mypaperheight = this.myh.Value;
				this.mypaperwidth = this.myw.Value;
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000068B7 File Offset: 0x00004AB7
		private void draftset_Load(object sender, EventArgs e)
		{
			this.AddPrinter();
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0008D03C File Offset: 0x0008B23C
		private void AddPrinter()
		{
			this.printername.Items.Clear();
			this.papertype.Items.Clear();
			PrinterSettings.StringCollection installedPrinters = PrinterSettings.InstalledPrinters;
			int num = 0;
			checked
			{
				int num2 = installedPrinters.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					this.printername.Items.Add(installedPrinters[i]);
				}
				PrintDocument printDocument = new PrintDocument();
				this.curprinter = printDocument.PrinterSettings.PrinterName;
				printDocument.Dispose();
				int num3 = 0;
				int num4 = this.printername.Items.Count - 1;
				for (int j = num3; j <= num4; j++)
				{
					if (String.Compare(Conversions.ToString(this.printername.Items[j]), this.curprinter, false) == 0)
					{
						this.printername.SelectedIndex = j;
						IL_C8:
						this.curprinter = Conversions.ToString(this.printername.SelectedItem);
						this.AddPaper();
						return;
					}
				}
				
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0008D134 File Offset: 0x0008B334
		private void AddPaper()
		{
			this.papertype.Items.Clear();
			PrinterSettings printerSettings = new PrinterSettings();
			if (String.Compare(this.curprinter, "", false) != 0 && Module1.IsValidPrinterName(this.curprinter))
			{
				printerSettings.PrinterName = this.curprinter;
			}
			PrinterSettings.PaperSizeCollection paperSizes = printerSettings.PaperSizes;
			bool flag = false;
			string text = "";
			int num = 0;
			checked
			{
				int num2 = paperSizes.Count - 1;
				int selectedIndex;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(paperSizes[i].PaperName, "[自定义纸张]", false) != 0)
					{
						selectedIndex = this.papertype.Items.Add(paperSizes[i].PaperName);
						if (i == 0)
						{
							text = Conversions.ToString((int)paperSizes[i].Kind);
						}
						else
						{
							text = text + "," + Conversions.ToString((int)paperSizes[i].Kind);
						}
						if (this.paperkind != PaperKind.Custom)
						{
							if (this.paperkind == paperSizes[i].Kind)
							{
								flag = true;
								this.papertype.SelectedIndex = selectedIndex;
							}
						}
						else if (String.Compare(this.papername.ToLower(), paperSizes[i].PaperName.ToLower(), false) == 0)
						{
							PaperSize printForm = definepaper.GetPrintForm(this.curprinter, this.papername);
							if (decimal.Compare(this.mypaperheight, 0m) <= 0 | decimal.Compare(this.mypaperwidth, 0m) <= 0)
							{
								flag = true;
								this.papertype.SelectedIndex = selectedIndex;
							}
							else if (unchecked(Math.Abs((double)printForm.Width * 2.54 / 10.0 - Convert.ToDouble(this.mypaperwidth)) <= 1.0 & Math.Abs((double)printForm.Height * 2.54 / 10.0 - Convert.ToDouble(this.mypaperheight)) <= 1.0))
							{
								flag = true;
								this.papertype.SelectedIndex = selectedIndex;
							}
						}
					}
				}
				selectedIndex = this.papertype.Items.Add("[自定义纸张]");
				text += ",0";
				if (this.paperkind == PaperKind.Custom && String.Compare(this.papername, "[自定义纸张]", false) == 0)
				{
					flag = true;
					this.papertype.SelectedIndex = selectedIndex;
				}
				this.papertype.Tag = text;
				if (!flag)
				{
					this.papername = "[自定义纸张]";
					this.papertype.SelectedIndex = selectedIndex;
				}
				if (this.paperlandscape)
				{
					this.fx.Text = "横向";
				}
				else
				{
					this.fx.Text = "纵向";
				}
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000068BF File Offset: 0x00004ABF
		private void printername_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.curprinter = Conversions.ToString(this.printername.SelectedItem);
			this.AddPaper();
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0008D408 File Offset: 0x0008B608
		private void RadioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton5.Checked)
			{
				this.fpage.Enabled = false;
				this.tpage.Enabled = false;
			}
			else
			{
				this.fpage.Enabled = true;
				this.tpage.Enabled = true;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0008D454 File Offset: 0x0008B654
		private void Button3_Click(object sender, EventArgs e)
		{
			if (String.Compare(Conversions.ToString(this.papertype.SelectedItem), "", false) == 0)
			{
				Module1.MyMsgBox("请先选择纸张");
			}
			else if (Convert.ToInt32(this.tpage.Value) < Convert.ToInt32(this.fpage.Value))
			{
				Interaction.MsgBox("打印的起始页码不正确，结束页必须大于等于起始页", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.ParaPaperType();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		private void Button1_Click(object sender, EventArgs e)
		{
			if (String.Compare(Conversions.ToString(this.papertype.SelectedItem), "", false) == 0)
			{
				Module1.MyMsgBox("请先选择纸张");
			}
			else if (Convert.ToInt32(this.tpage.Value) < Convert.ToInt32(this.fpage.Value))
			{
				Interaction.MsgBox("打印的起始页码不正确，结束页必须大于等于起始页", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.ParaPaperType();
				this.DialogResult = DialogResult.Yes;
				this.Close();
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0008D54C File Offset: 0x0008B74C
		private void ParaPaperType()
		{
			if (String.Compare(Conversions.ToString(this.papertype.SelectedItem), "", false) != 0)
			{
				PrinterSettings printerSettings = new PrinterSettings();
				if (String.Compare(this.curprinter, "", false) != 0 && Module1.IsValidPrinterName(this.curprinter))
				{
					printerSettings.PrinterName = this.curprinter;
				}
				if (String.Compare(Conversions.ToString(this.papertype.SelectedItem), "[自定义纸张]", false) == 0)
				{
					this.paperkind = PaperKind.Custom;
					this.papername = "[自定义纸张]";
					this.mypaperwidth = this.myw.Value;
					this.mypaperheight = this.myh.Value;
				}
				else
				{
					PaperSize printForm = definepaper.GetPrintForm(this.curprinter, Conversions.ToString(this.papertype.SelectedItem));
					if (printForm.Kind == PaperKind.Custom)
					{
						this.paperkind = PaperKind.Custom;
						this.papername = printForm.PaperName;
					}
					else
					{
						this.papername = Conversions.ToString(this.papertype.SelectedItem);
						this.paperkind = printForm.Kind;
					}
				}
			}
		}

		// Token: 0x040008AE RID: 2222
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008AF RID: 2223
		[AccessedThroughProperty("printername")]
		private ComboBox _printername;

		// Token: 0x040008B0 RID: 2224
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040008B1 RID: 2225
		[AccessedThroughProperty("RadioButton4")]
		private RadioButton _RadioButton4;

		// Token: 0x040008B2 RID: 2226
		[AccessedThroughProperty("RadioButton3")]
		private RadioButton _RadioButton3;

		// Token: 0x040008B3 RID: 2227
		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		// Token: 0x040008B4 RID: 2228
		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		// Token: 0x040008B5 RID: 2229
		[AccessedThroughProperty("GroupBox24")]
		private GroupBox _GroupBox24;

		// Token: 0x040008B6 RID: 2230
		[AccessedThroughProperty("myh")]
		private NumericUpDown _myh;

		// Token: 0x040008B7 RID: 2231
		[AccessedThroughProperty("Label81")]
		private Label _Label81;

		// Token: 0x040008B8 RID: 2232
		[AccessedThroughProperty("fx")]
		private ComboBox _fx;

		// Token: 0x040008B9 RID: 2233
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040008BA RID: 2234
		[AccessedThroughProperty("myw")]
		private NumericUpDown _myw;

		// Token: 0x040008BB RID: 2235
		[AccessedThroughProperty("Label82")]
		private Label _Label82;

		// Token: 0x040008BC RID: 2236
		[AccessedThroughProperty("papertype")]
		private ComboBox _papertype;

		// Token: 0x040008BD RID: 2237
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x040008BE RID: 2238
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040008BF RID: 2239
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040008C0 RID: 2240
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x040008C1 RID: 2241
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040008C2 RID: 2242
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040008C3 RID: 2243
		[AccessedThroughProperty("RadioButton6")]
		private RadioButton _RadioButton6;

		// Token: 0x040008C4 RID: 2244
		[AccessedThroughProperty("RadioButton5")]
		private RadioButton _RadioButton5;

		// Token: 0x040008C5 RID: 2245
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008C6 RID: 2246
		[AccessedThroughProperty("fpage")]
		private NumericUpDown _fpage;

		// Token: 0x040008C7 RID: 2247
		[AccessedThroughProperty("tpage")]
		private NumericUpDown _tpage;

		// Token: 0x040008C8 RID: 2248
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040008C9 RID: 2249
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040008CA RID: 2250
		public string curprinter;

		// Token: 0x040008CB RID: 2251
		public decimal mypaperwidth;

		// Token: 0x040008CC RID: 2252
		public decimal mypaperheight;

		// Token: 0x040008CD RID: 2253
		public string papername;

		// Token: 0x040008CE RID: 2254
		public PaperKind paperkind;

		// Token: 0x040008CF RID: 2255
		public bool paperlandscape;
	}
}
