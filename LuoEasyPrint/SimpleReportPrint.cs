using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace LuoEasyPrint
{
    // Token: 0x02000072 RID: 114
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class SimpleReportPrint : Form
    {
        // Token: 0x06000E6D RID: 3693 RVA: 0x000717CC File Offset: 0x0006F9CC
        public SimpleReportPrint()
        {
            base.Disposed += this.SimpleReportPrint_Disposed;
            base.Load += this.SimpleReportPrint_Load;
            this.myset = new SimpleReportSet();
            this.IsChanged = false;
            this.W_canedit = true;
            this.W_canadd = true;
            this.W_canddel = true;
            this.W_IsNeedTry = true;
            this.documentname = "";
            this.myprintername = "";
            this.myisdrawmargin = false;
            this.IsRedrawCell = false;
            this.myenablesaveaspdf = true;
            this.myenablesaveasimage = true;
            this.myenableexportpdf = true;
            this.myenableexportexcel = true;
            this.myenableexportrtf = true;
            this.myenableexporthtml = true;
            this.myisshowcontextmenu = true;
            this.myistoolbarvisible = true;
            this.myispreviewtoolbarvisible = true;
            this.myenabledprint = true;
            this.myenablecgprint = true;
            this._printcopys = 1;
            this.myisshowpagecontinues = false;
            this.myisshowprogress = true;
            this.myschemenametoprint = "";
            this.ispreview = false;
            this.InitializeComponent();
        }

        // Token: 0x170004D5 RID: 1237
        // (get) Token: 0x06000E70 RID: 3696 RVA: 0x000725B4 File Offset: 0x000707B4
        // (set) Token: 0x06000E71 RID: 3697 RVA: 0x000725CC File Offset: 0x000707CC
        internal virtual VB2008Print myp
        {
            get
            {
                return this._myp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                VB2008Print.HeaderFooterOutEventHandler value2 = new VB2008Print.HeaderFooterOutEventHandler(this.myp_HeaderFooterOut);
                VB2008Print.PrintDocumentEventHandler value3 = new VB2008Print.PrintDocumentEventHandler(this.myp_PrintDocument);
                if (this._myp != null)
                {
                    this._myp.HeaderFooterOut -= value2;
                    this._myp.PrintDocument -= value3;
                }
                this._myp = value;
                if (this._myp != null)
                {
                    this._myp.HeaderFooterOut += value2;
                    this._myp.PrintDocument += value3;
                }
            }
        }

        // Token: 0x170004D6 RID: 1238
        // (get) Token: 0x06000E72 RID: 3698 RVA: 0x0007263C File Offset: 0x0007083C
        // (set) Token: 0x06000E73 RID: 3699 RVA: 0x00005D4F File Offset: 0x00003F4F
        internal virtual ToolStrip ToolStrip1
        {
            get
            {
                return this._ToolStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStrip1 = value;
            }
        }

        // Token: 0x170004D7 RID: 1239
        // (get) Token: 0x06000E74 RID: 3700 RVA: 0x00072654 File Offset: 0x00070854
        // (set) Token: 0x06000E75 RID: 3701 RVA: 0x00005D58 File Offset: 0x00003F58
        internal virtual ToolStripLabel ToolStripButton1
        {
            get
            {
                return this._ToolStripButton1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripButton1 = value;
            }
        }

        // Token: 0x170004D8 RID: 1240
        // (get) Token: 0x06000E76 RID: 3702 RVA: 0x0007266C File Offset: 0x0007086C
        // (set) Token: 0x06000E77 RID: 3703 RVA: 0x00072684 File Offset: 0x00070884
        internal virtual ToolStripComboBox fa
        {
            get
            {
                return this._fa;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.fa_SelectedIndexChanged);
                if (this._fa != null)
                {
                    this._fa.SelectedIndexChanged -= value2;
                }
                this._fa = value;
                if (this._fa != null)
                {
                    this._fa.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x170004D9 RID: 1241
        // (get) Token: 0x06000E78 RID: 3704 RVA: 0x000726D0 File Offset: 0x000708D0
        // (set) Token: 0x06000E79 RID: 3705 RVA: 0x000726E8 File Offset: 0x000708E8
        internal virtual ToolStripButton myedit
        {
            get
            {
                return this._myedit;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.myedit_Click);
                if (this._myedit != null)
                {
                    this._myedit.Click -= value2;
                }
                this._myedit = value;
                if (this._myedit != null)
                {
                    this._myedit.Click += value2;
                }
            }
        }

        // Token: 0x170004DA RID: 1242
        // (get) Token: 0x06000E7A RID: 3706 RVA: 0x00072734 File Offset: 0x00070934
        // (set) Token: 0x06000E7B RID: 3707 RVA: 0x0007274C File Offset: 0x0007094C
        internal virtual ToolStripButton mysaveas
        {
            get
            {
                return this._mysaveas;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.mysaveas_Click);
                if (this._mysaveas != null)
                {
                    this._mysaveas.Click -= value2;
                }
                this._mysaveas = value;
                if (this._mysaveas != null)
                {
                    this._mysaveas.Click += value2;
                }
            }
        }

        // Token: 0x170004DB RID: 1243
        // (get) Token: 0x06000E7C RID: 3708 RVA: 0x00072798 File Offset: 0x00070998
        // (set) Token: 0x06000E7D RID: 3709 RVA: 0x000727B0 File Offset: 0x000709B0
        internal virtual ToolStripButton myadd
        {
            get
            {
                return this._myadd;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.myadd_Click);
                if (this._myadd != null)
                {
                    this._myadd.Click -= value2;
                }
                this._myadd = value;
                if (this._myadd != null)
                {
                    this._myadd.Click += value2;
                }
            }
        }

        // Token: 0x170004DC RID: 1244
        // (get) Token: 0x06000E7E RID: 3710 RVA: 0x000727FC File Offset: 0x000709FC
        // (set) Token: 0x06000E7F RID: 3711 RVA: 0x00072814 File Offset: 0x00070A14
        internal virtual ToolStripButton mydel
        {
            get
            {
                return this._mydel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.mydel_Click);
                if (this._mydel != null)
                {
                    this._mydel.Click -= value2;
                }
                this._mydel = value;
                if (this._mydel != null)
                {
                    this._mydel.Click += value2;
                }
            }
        }

        // Token: 0x170004DD RID: 1245
        // (get) Token: 0x06000E80 RID: 3712 RVA: 0x00072860 File Offset: 0x00070A60
        // (set) Token: 0x06000E81 RID: 3713 RVA: 0x00072878 File Offset: 0x00070A78
        internal virtual ToolStripButton ToolStripButton2
        {
            get
            {
                return this._ToolStripButton2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton2_Click);
                if (this._ToolStripButton2 != null)
                {
                    this._ToolStripButton2.Click -= value2;
                }
                this._ToolStripButton2 = value;
                if (this._ToolStripButton2 != null)
                {
                    this._ToolStripButton2.Click += value2;
                }
            }
        }

        // Token: 0x170004DE RID: 1246
        // (get) Token: 0x06000E82 RID: 3714 RVA: 0x000728C4 File Offset: 0x00070AC4
        // (set) Token: 0x06000E83 RID: 3715 RVA: 0x000728DC File Offset: 0x00070ADC
        internal virtual ToolStripButton ToolStripButton3
        {
            get
            {
                return this._ToolStripButton3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton3_Click);
                if (this._ToolStripButton3 != null)
                {
                    this._ToolStripButton3.Click -= value2;
                }
                this._ToolStripButton3 = value;
                if (this._ToolStripButton3 != null)
                {
                    this._ToolStripButton3.Click += value2;
                }
            }
        }

        // Token: 0x170004DF RID: 1247
        // (get) Token: 0x06000E84 RID: 3716 RVA: 0x00072928 File Offset: 0x00070B28
        // (set) Token: 0x06000E85 RID: 3717 RVA: 0x00005D61 File Offset: 0x00003F61
        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            get
            {
                return this._ToolStripSeparator1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator1 = value;
            }
        }

        // Token: 0x170004E0 RID: 1248
        // (get) Token: 0x06000E86 RID: 3718 RVA: 0x00072940 File Offset: 0x00070B40
        // (set) Token: 0x06000E87 RID: 3719 RVA: 0x00005D6A File Offset: 0x00003F6A
        internal virtual ToolStripLabel l_default
        {
            get
            {
                return this._l_default;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._l_default = value;
            }
        }

        // Token: 0x170004E1 RID: 1249
        // (get) Token: 0x06000E88 RID: 3720 RVA: 0x00072958 File Offset: 0x00070B58
        // (set) Token: 0x06000E89 RID: 3721 RVA: 0x00005D73 File Offset: 0x00003F73
        internal virtual ToolStripDropDownButton ToolStripButton4
        {
            get
            {
                return this._ToolStripButton4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripButton4 = value;
            }
        }

        // Token: 0x170004E2 RID: 1250
        // (get) Token: 0x06000E8A RID: 3722 RVA: 0x00072970 File Offset: 0x00070B70
        // (set) Token: 0x06000E8B RID: 3723 RVA: 0x00072988 File Offset: 0x00070B88
        internal virtual ToolStripMenuItem exportexcel
        {
            get
            {
                return this._exportexcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.exportexcel_Click);
                if (this._exportexcel != null)
                {
                    this._exportexcel.Click -= value2;
                }
                this._exportexcel = value;
                if (this._exportexcel != null)
                {
                    this._exportexcel.Click += value2;
                }
            }
        }

        // Token: 0x170004E3 RID: 1251
        // (get) Token: 0x06000E8C RID: 3724 RVA: 0x000729D4 File Offset: 0x00070BD4
        // (set) Token: 0x06000E8D RID: 3725 RVA: 0x000729EC File Offset: 0x00070BEC
        internal virtual ToolStripMenuItem exportrtf
        {
            get
            {
                return this._exportrtf;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.exportrtf_Click);
                if (this._exportrtf != null)
                {
                    this._exportrtf.Click -= value2;
                }
                this._exportrtf = value;
                if (this._exportrtf != null)
                {
                    this._exportrtf.Click += value2;
                }
            }
        }

        // Token: 0x170004E4 RID: 1252
        // (get) Token: 0x06000E8E RID: 3726 RVA: 0x00072A38 File Offset: 0x00070C38
        // (set) Token: 0x06000E8F RID: 3727 RVA: 0x00072A50 File Offset: 0x00070C50
        internal virtual ToolStripMenuItem exporthtml
        {
            get
            {
                return this._exporthtml;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.exporthtml_Click);
                if (this._exporthtml != null)
                {
                    this._exporthtml.Click -= value2;
                }
                this._exporthtml = value;
                if (this._exporthtml != null)
                {
                    this._exporthtml.Click += value2;
                }
            }
        }

        // Token: 0x170004E5 RID: 1253
        // (get) Token: 0x06000E90 RID: 3728 RVA: 0x00072A9C File Offset: 0x00070C9C
        // (set) Token: 0x06000E91 RID: 3729 RVA: 0x00072AB4 File Offset: 0x00070CB4
        internal virtual ToolStripMenuItem exportpdf
        {
            get
            {
                return this._exportpdf;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.exportpdf_Click);
                if (this._exportpdf != null)
                {
                    this._exportpdf.Click -= value2;
                }
                this._exportpdf = value;
                if (this._exportpdf != null)
                {
                    this._exportpdf.Click += value2;
                }
            }
        }

        // Token: 0x06000E92 RID: 3730 RVA: 0x00072B00 File Offset: 0x00070D00
        private void SimpleReportPrint_Disposed(object sender, EventArgs e)
        {
            this.myset.Dispose();
            this.myset = null;
            try
            {
                if (this.tmpdgv != null)
                {
                    this.tmpdgv.Dispose();
                }
                this.tmptreeview.Dispose();
                this.tmpdgv = null;
                this.tmptreeview = null;
                this.mycols = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000E93 RID: 3731 RVA: 0x00005D7C File Offset: 0x00003F7C
        private void SimpleReportPrint_Load(object sender, EventArgs e)
        {
            this.MyLoad();
        }

        // Token: 0x06000E94 RID: 3732 RVA: 0x00072B74 File Offset: 0x00070D74
        public void MyLoad()
        {
            this.myp.IsShowPageContinues = this.myisshowpagecontinues;
            if (this.myistoolbarvisible)
            {
                this.ToolStrip1.Visible = true;
            }
            else
            {
                this.ToolStrip1.Visible = false;
            }
            this.myp.IsShowContextMenu = this.myisshowcontextmenu;
            this.myp.ToolBarVisible = this.myispreviewtoolbarvisible;
            this.myp.EnabledPrint = this.myenabledprint;
            this.myp.EnablePrintDraft = this.myenablecgprint;
            this.exportexcel.Enabled = this.myenableexportexcel;
            this.exportpdf.Enabled = this.myenableexportpdf;
            this.exporthtml.Enabled = this.myenableexporthtml;
            this.exportrtf.Enabled = this.myenableexportrtf;
            this.myp.PrintCopys = this._printcopys;
            this.myp.DocumentName = this.documentname;
            this.myp.IsDrawmargin = this.myisdrawmargin;
            this.myp.EnableSaveAsImage = this.myenablesaveasimage;
            this.myp.EnableSaveAsPDF = this.myenablesaveaspdf;
            this.myp.SetCurrentPrinterName(this.myprintername);
            if (String.Compare(this.w_Settings, "", false) == 0)
            {
                this.myschemes = new SimpleReportSchemes("新打印方案", this.w_dgv, "主标题");
                this.myschemes.DefaultScheme = "新打印方案";
                this.IsChanged = true;
            }
            else
            {
                this.myschemes = new SimpleReportSchemes(this.w_Settings);
                this.IsChanged = false;
            }
            string[] schemeName = this.myschemes.GetSchemeName();
            this.fa.Items.Clear();
            checked
            {
                if (schemeName != null)
                {
                    int num = 0;
                    int num2 = schemeName.Length - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.fa.Items.Add(schemeName[i]);
                    }
                }
                if (this.W_canedit)
                {
                    this.myedit.Enabled = true;
                }
                else
                {
                    this.myedit.Enabled = false;
                }
                if (this.W_canddel)
                {
                    this.mydel.Enabled = true;
                }
                else
                {
                    this.mydel.Enabled = false;
                }
                if (this.W_canadd)
                {
                    this.mysaveas.Enabled = true;
                    this.myadd.Enabled = true;
                }
                else
                {
                    this.mysaveas.Enabled = false;
                    this.myadd.Enabled = false;
                }
                try
                {
                    if (String.Compare(this.myschemenametoprint, "", false) != 0)
                    {
                        if (this.fa.Items.Contains(this.myschemenametoprint))
                        {
                            this.fa.Text = this.myschemenametoprint;
                        }
                        else
                        {
                            this.fa.Text = this.myschemes.DefaultScheme;
                        }
                    }
                    else
                    {
                        this.fa.Text = this.myschemes.DefaultScheme;
                    }
                }
                catch (Exception ex)
                {
                }
                this.myset.dgvtoprint = this.w_dgv;
                int num3;
                if (this.W_variable == null)
                {
                    num3 = 0;
                }
                else
                {
                    num3 = this.W_variable.Count;
                }
                if (num3 <= 0)
                {
                    this.myset.ZdyArray = null;
                }
                else
                {
                    this.myset.ZdyArray = new string[num3 - 1 + 1];
                    int num4 = 0;
                    foreach (object obj in this.W_variable)
                    {
                        DictionaryEntry dictionaryEntry2 = new DictionaryEntry();
                        DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
                        this.myset.ZdyArray[num4] = Convert.ToString(dictionaryEntry.Key);
                        num4++;
                    }
                    Array.Sort<string>(this.myset.ZdyArray);
                }
            }
        }

        // Token: 0x06000E95 RID: 3733 RVA: 0x00072F0C File Offset: 0x0007110C
        public string GetSchemetxt()
        {
            string result;
            if (this.myschemes != null)
            {
                result = this.myschemes.Save();
            }
            else
            {
                result = "";
            }
            return result;
        }

        // Token: 0x06000E96 RID: 3734 RVA: 0x00072F38 File Offset: 0x00071138
        private float GetReportHeaderHeight()
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags = ((stringFormat.FormatFlags | StringFormatFlags.MeasureTrailingSpaces) & ~StringFormatFlags.NoWrap);
            stringFormat.LineAlignment = StringAlignment.Near;
            string text = this.myset.reportheaderalignment.Text;
            if (String.Compare(text, "左对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Near;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Far;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }
            string text2 = this.myset.reportheadertext.Text;
            text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, -1));
            float num = this.myp.MeasureText(text2, this.myset.reportheadertext.Font, this.myp.PaperPrintWidth, stringFormat).Height;
            num += Convert.ToSingle(decimal.Multiply(this.myset.reportheaderspace.Value, 10m));
            stringFormat.Dispose();
            return num;
        }

        // Token: 0x06000E97 RID: 3735 RVA: 0x00073050 File Offset: 0x00071250
        private void PrintReportHeader()
        {
            float reportHeaderHeight = this.GetReportHeaderHeight();
            if (reportHeaderHeight <= 0f | String.Compare(this.myset.reportheadertext.Text, "", false) == 0)
            {
                this.myp.Currentx = 0f;
                this.myp.Currenty = this.myp.Currenty + Convert.ToSingle(decimal.Multiply(this.myset.reportheaderspace.Value, 10m));
            }
            else
            {
                StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.FormatFlags = ((stringFormat.FormatFlags | StringFormatFlags.MeasureTrailingSpaces) & ~StringFormatFlags.NoWrap);
                stringFormat.LineAlignment = StringAlignment.Near;
                string text = this.myset.reportheaderalignment.Text;
                if (String.Compare(text, "左对齐", false) == 0)
                {
                    stringFormat.Alignment = StringAlignment.Near;
                }
                else if (String.Compare(text, "右对齐", false) == 0)
                {
                    stringFormat.Alignment = StringAlignment.Far;
                }
                else
                {
                    stringFormat.Alignment = StringAlignment.Center;
                }
                RectangleF rectangleF = new RectangleF(this.myp.Currentx, this.myp.Currenty, this.myp.PaperPrintWidth, reportHeaderHeight);
                string text2 = this.myset.reportheadertext.Text;
                text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, 0));
                this.myp.DrawText(text2, this.myp.PaperPrintWidth, this.myset.reportheadertext.Font, this.myset.reportheadertext.ForeColor, stringFormat, 0);
                stringFormat.Dispose();
                this.myp.Currentx = 0f;
                this.myp.Currenty = this.myp.Currenty + this.myp.LastDrawTextHeight + Convert.ToSingle(decimal.Multiply(this.myset.reportheaderspace.Value, 10m));
            }
        }

        // Token: 0x06000E98 RID: 3736 RVA: 0x00073244 File Offset: 0x00071444
        private float GetReportFooterHeight()
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags = ((stringFormat.FormatFlags | StringFormatFlags.MeasureTrailingSpaces) & ~StringFormatFlags.NoWrap);
            stringFormat.LineAlignment = StringAlignment.Far;
            string text = this.myset.reportfooteralignment.Text;
            if (String.Compare(text, "左对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Near;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Far;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }
            string text2 = this.myset.reportfootertext.Text;
            text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, -1));
            float num = this.myp.MeasureText(text2, this.myset.reportfootertext.Font, this.myp.PaperPrintWidth, stringFormat).Height;
            num += Convert.ToSingle(decimal.Multiply(this.myset.reportfooterspace.Value, 10m));
            stringFormat.Dispose();
            return num;
        }

        // Token: 0x06000E99 RID: 3737 RVA: 0x0007335C File Offset: 0x0007155C
        private void PrintReportFooter()
        {
            float num = this.GetReportFooterHeight() - Convert.ToSingle(decimal.Multiply(this.myset.reportfooterspace.Value, 10m));
            if (num > 0f)
            {
                if (String.Compare(this.myset.reportfootertext.Text, "", false) != 0)
                {
                    StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                    stringFormat.FormatFlags = ((stringFormat.FormatFlags | StringFormatFlags.MeasureTrailingSpaces) & ~StringFormatFlags.NoWrap);
                    stringFormat.LineAlignment = StringAlignment.Near;
                    string text = this.myset.reportfooteralignment.Text;
                    if (String.Compare(text, "左对齐", false) == 0)
                    {
                        stringFormat.Alignment = StringAlignment.Near;
                    }
                    else if (String.Compare(text, "右对齐", false) == 0)
                    {
                        stringFormat.Alignment = StringAlignment.Far;
                    }
                    else
                    {
                        stringFormat.Alignment = StringAlignment.Center;
                    }
                    string text2 = this.myset.reportfootertext.Text;
                    text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, 0));
                    this.myp.Currenty = this.myp.Currenty + Convert.ToSingle(decimal.Multiply(this.myset.reportfooterspace.Value, 10m));
                    this.myp.DrawText(text2, this.myp.PaperPrintWidth, this.myset.reportfootertext.Font, this.myset.reportfootertext.ForeColor, stringFormat, 0);
                    stringFormat.Dispose();
                }
            }
        }

        // Token: 0x06000E9A RID: 3738 RVA: 0x000734DC File Offset: 0x000716DC
        private float GetMainTitleHeight()
        {
            return Convert.ToSingle(decimal.Multiply(this.myset.maintitleheight.Value, 10m));
        }

        // Token: 0x06000E9B RID: 3739 RVA: 0x00073514 File Offset: 0x00071714
        private void PrintMainTitle(bool forcedprint = false)
        {
            float currenty = this.myp.Currenty;
            if ((this.myp.GetCurrentPage() == 1 | this.myset.maintitleprinteverpage.Checked) || forcedprint)
            {
                float mainTitleHeight = this.GetMainTitleHeight();
                if (!(mainTitleHeight <= 0f | String.Compare(this.myset.maintitle.Text, "", false) == 0))
                {
                    StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                    stringFormat.LineAlignment = StringAlignment.Near;
                    string text = this.myset.maintitle.Text;
                    text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
                    string text2 = this.myset.maintitlealign.Text;
                    if (String.Compare(text2, "左对齐", false) == 0)
                    {
                        stringFormat.Alignment = StringAlignment.Near;
                    }
                    else if (String.Compare(text2, "右对齐", false) == 0)
                    {
                        stringFormat.Alignment = StringAlignment.Far;
                    }
                    else
                    {
                        stringFormat.Alignment = StringAlignment.Center;
                    }
                    RectangleF myrect = new RectangleF(this.myp.Currentx, this.myp.Currenty, this.myp.PaperPrintWidth, mainTitleHeight);
                    this.myp.DrawText(text, myrect, this.myset.maintitle.Font, this.myset.maintitle.ForeColor, stringFormat, 0f, 0);
                    stringFormat.Dispose();
                    this.myp.Currentx = 0f;
                    this.myp.Currenty = currenty + mainTitleHeight;
                }
            }
        }

        // Token: 0x06000E9C RID: 3740 RVA: 0x00073694 File Offset: 0x00071894
        private float GetSubTitleHeight()
        {
            checked
            {
                float result;
                if (this.myset.d1.RowCount <= 0)
                {
                    result = 0f;
                }
                else
                {
                    float num = Convert.ToSingle(decimal.Multiply(this.myset.subtitleheight.Value, 10m));
                    float num2 = 0f;
                    int num3 = 0;
                    int num4 = this.myset.d1.RowCount - 1;
                    for (int i = num3; i <= num4; i++)
                    {
                        float num5 = (float)(unchecked((double)((float)(checked(Convert.ToInt32(this.myset.d1.Rows[i].Cells[1].Value) - 1)) * num) + (double)num * Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d1.Rows[i].Cells[4].Value))));
                        if (num5 > num2)
                        {
                            num2 = num5;
                        }
                    }
                    result = num2;
                }
                return result;
            }
        }

        // Token: 0x06000E9D RID: 3741 RVA: 0x0007378C File Offset: 0x0007198C
        private void PrintSubTitle(bool forcedprint = false)
        {
            float currenty = this.myp.Currenty;
            if ((this.myp.GetCurrentPage() == 1 | this.myset.subtitlepritneverypage.Checked) || forcedprint)
            {
                float subTitleHeight = this.GetSubTitleHeight();
                if (subTitleHeight > 0f)
                {
                    int num = 0;
                    checked
                    {
                        int num2 = this.myset.d1.RowCount - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            this.PrintSubTitleLine(i);
                        }
                        this.myp.Currentx = 0f;
                    }
                    this.myp.Currenty = currenty + subTitleHeight;
                }
            }
        }

        // Token: 0x06000E9E RID: 3742 RVA: 0x0007381C File Offset: 0x00071A1C
        private void PrintSubTitleLine(int i)
        {
            float currentx = this.myp.Currentx;
            float currenty = this.myp.Currenty;
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.LineAlignment = StringAlignment.Center;
            string text = Convert.ToString(this.myset.d1.Rows[i].Cells[0].Value);
            text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
            string left = Convert.ToString(this.myset.d1.Rows[i].Cells[2].Value);
            if (String.Compare(left, "左对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Near;
            }
            else if (String.Compare(left, "右对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Far;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }
            float height = (float)(Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d1.Rows[i].Cells[4].Value)) * Convert.ToDouble(this.myset.subtitleheight.Value) * 10.0);
            float num = 0;
            float x = 0;
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d1.Rows[i].Cells[5].Value)) == 0.0)
            {
                num = this.myp.PaperPrintWidth;
                x = 0f;
            }
            else
            {
                num = (float)(Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d1.Rows[i].Cells[5].Value)) * 10.0);
                switch (stringFormat.Alignment)
                {
                    case StringAlignment.Near:
                        x = 0f;
                        break;
                    case StringAlignment.Center:
                        x = (this.myp.PaperPrintWidth - num) / 2f;
                        break;
                    case StringAlignment.Far:
                        x = this.myp.PaperPrintWidth - num;
                        break;
                }
            }
            float y = currenty + Convert.ToSingle(decimal.Multiply(decimal.Multiply(new decimal(checked(Convert.ToInt32(this.myset.d1.Rows[i].Cells[1].Value) - 1)), this.myset.subtitleheight.Value), 10m));
            RectangleF myrect = new RectangleF(x, y, num, height);
            this.myp.DrawText(text, myrect, Module1.ConvertStringToFont(Convert.ToString(this.myset.d1.Rows[i].Cells[3].Value)), Module1.ConvertStringToColor(Convert.ToString(this.myset.d1.Rows[i].Cells[6].Value)), stringFormat, 0f, 0);
            this.myp.Currentx = currentx;
            this.myp.Currenty = currenty;
            stringFormat.Dispose();
        }

        // Token: 0x06000E9F RID: 3743 RVA: 0x00073B30 File Offset: 0x00071D30
        private float GetTableFooterHeight()
        {
            checked
            {
                float result;
                if (this.myset.d2.RowCount <= 0)
                {
                    result = 0f;
                }
                else
                {
                    float num = Convert.ToSingle(decimal.Multiply(this.myset.tablefooterheight.Value, 10m));
                    float num2 = 0f;
                    int num3 = 0;
                    int num4 = this.myset.d2.RowCount - 1;
                    for (int i = num3; i <= num4; i++)
                    {
                        float num5 = (float)(unchecked((double)((float)(checked(Convert.ToInt32(this.myset.d2.Rows[i].Cells[1].Value) - 1)) * num) + (double)num * Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d2.Rows[i].Cells[4].Value))));
                        if (num5 > num2)
                        {
                            num2 = num5;
                        }
                    }
                    result = num2;
                }
                return result;
            }
        }

        // Token: 0x06000EA0 RID: 3744 RVA: 0x00073C28 File Offset: 0x00071E28
        private void PrintTableFooter(bool islastpage)
        {
            float currenty = this.myp.Currenty;
            if (this.myset.tablefooterprinteverypage.Checked || islastpage)
            {
                float tableFooterHeight = this.GetTableFooterHeight();
                if (tableFooterHeight > 0f)
                {
                    int num = 0;
                    checked
                    {
                        int num2 = this.myset.d2.RowCount - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            this.PrintTableFooterLine(i);
                        }
                        this.myp.Currentx = 0f;
                    }
                    this.myp.Currenty = currenty + tableFooterHeight;
                }
            }
        }

        // Token: 0x06000EA1 RID: 3745 RVA: 0x00073CA8 File Offset: 0x00071EA8
        private void PrintTableFooterLine(int i)
        {
            float currentx = this.myp.Currentx;
            float currenty = this.myp.Currenty;
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.LineAlignment = StringAlignment.Center;
            string text = Convert.ToString(this.myset.d2.Rows[i].Cells[0].Value);
            text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
            string left = Convert.ToString(this.myset.d2.Rows[i].Cells[2].Value);
            if (String.Compare(left, "左对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Near;
            }
            else if (String.Compare(left, "右对齐", false) == 0)
            {
                stringFormat.Alignment = StringAlignment.Far;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }
            float height = (float)(Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d2.Rows[i].Cells[4].Value)) * Convert.ToDouble(this.myset.tablefooterheight.Value) * 10.0);
            float num = 0;
            float x = 0;
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d2.Rows[i].Cells[5].Value)) == 0.0)
            {
                num = this.myp.PaperPrintWidth;
                x = 0f;
            }
            else
            {
                num = (float)(Conversion.Val(RuntimeHelpers.GetObjectValue(this.myset.d2.Rows[i].Cells[5].Value)) * 10.0);
                switch (stringFormat.Alignment)
                {
                    case StringAlignment.Near:
                        x = 0f;
                        break;
                    case StringAlignment.Center:
                        x = (this.myp.PaperPrintWidth - num) / 2f;
                        break;
                    case StringAlignment.Far:
                        x = this.myp.PaperPrintWidth - num;
                        break;
                }
            }
            float y = currenty + Convert.ToSingle(decimal.Multiply(decimal.Multiply(new decimal(checked(Convert.ToInt32(this.myset.d2.Rows[i].Cells[1].Value) - 1)), this.myset.tablefooterheight.Value), 10m));
            RectangleF myrect = new RectangleF(x, y, num, height);
            this.myp.DrawText(text, myrect, Module1.ConvertStringToFont(Convert.ToString(this.myset.d2.Rows[i].Cells[3].Value)), Module1.ConvertStringToColor(Convert.ToString(this.myset.d2.Rows[i].Cells[6].Value)), stringFormat, 0f, 0);
            this.myp.Currentx = currentx;
            this.myp.Currenty = currenty;
            stringFormat.Dispose();
        }

        // Token: 0x06000EA2 RID: 3746 RVA: 0x00073FBC File Offset: 0x000721BC
        private void PrintZDX()
        {
            if (this.myset.isdrawzdx.Checked)
            {
                this.myp.IsDrawZDX = true;
                if (this.myset.zdxtype_bottom.Checked)
                {
                    this.myp.ZDXType = VB2008Print.TheZDXTYPE.BOTTOM;
                }
                else if (this.myset.zdxtype_right.Checked)
                {
                    this.myp.ZDXType = VB2008Print.TheZDXTYPE.RIGHT;
                }
                else if (this.myset.zdxtype_top.Checked)
                {
                    this.myp.ZDXType = VB2008Print.TheZDXTYPE.TOP;
                }
                else
                {
                    this.myp.ZDXType = VB2008Print.TheZDXTYPE.LEFT;
                }
                this.myp.ZDXPosition = Convert.ToSingle(decimal.Multiply(this.myset.zdxposition.Value, 10m));
                this.myp.ZDXText = Convert.ToString(this.MyReplace(this.myset.zdxtext.Text, this.w_dgv, -1));
                this.myp.ZDXFont = this.myset.zdxtext.Font;
                this.myp.ZDXTextColor = this.myset.zdxtext.ForeColor;
                if (this.myset.zdx_dashdot.Checked)
                {
                    this.myp.ZDXLineStyle = DashStyle.DashDot;
                }
                else if (this.myset.zdx_dashdotdot.Checked)
                {
                    this.myp.ZDXLineStyle = DashStyle.DashDotDot;
                }
                else if (this.myset.zdx_dot.Checked)
                {
                    this.myp.ZDXLineStyle = DashStyle.Dot;
                }
                else if (this.myset.zdx_solid.Checked)
                {
                    this.myp.ZDXLineStyle = DashStyle.Solid;
                }
                else
                {
                    this.myp.ZDXLineStyle = DashStyle.Dash;
                }
                this.myp.ZDXLinecoLor = this.myset.zdxlinecolor.ForeColor;
            }
            else
            {
                this.myp.IsDrawZDX = false;
            }
        }

        // Token: 0x06000EA3 RID: 3747 RVA: 0x000741A4 File Offset: 0x000723A4
        private void PrintWater()
        {
            this.myp.WaterMarkText = Convert.ToString(this.MyReplace(this.myset.sytext.Text, this.w_dgv, -1));
            this.myp.WaterMarkColor = this.myset.sytext.ForeColor;
            this.myp.WaterMarkFont = this.myset.sytext.Font;
            if (String.Compare(this.myset.syfx.Text, "水平", false) == 0)
            {
                this.myp.WaterMarkLandscape = true;
            }
            else
            {
                this.myp.WaterMarkLandscape = false;
            }
            this.myp.WaterMarkOpacity = Convert.ToByte(this.myset.sytm.Value);
        }

        // Token: 0x06000EA4 RID: 3748 RVA: 0x0007426C File Offset: 0x0007246C
        private void SetPageSettings()
        {
            checked
            {
                if (String.Compare(Convert.ToString(this.myset.papertype.SelectedItem), "", false) == 0 | String.Compare(Convert.ToString(this.myset.papertype.SelectedItem), "[自定义纸张]", false) == 0)
                {
                    this.myp.PaperKind = PaperKind.Custom;
                    float num = Convert.ToSingle(this.myset.myw.Value);
                    float num2 = Convert.ToSingle(this.myset.myh.Value);
                    this.myp.PaperSize = new PaperSize("[自定义纸张]", (int)Math.Round((double)Module1.ConvertCmToInch(unchecked(num * 100f) / 10f)), (int)Math.Round((double)Module1.ConvertCmToInch(unchecked(num2 * 100f) / 10f)));
                }
                else
                {
                    PaperSize printForm = definepaper.GetPrintForm("", Convert.ToString(this.myset.papertype.SelectedItem));
                    if (printForm == null)
                    {
                        float num3 = Convert.ToSingle(this.myset.myw.Value);
                        float num4 = Convert.ToSingle(this.myset.myh.Value);
                        this.myp.PaperSize = new PaperSize("[自定义纸张]", (int)Math.Round((double)Module1.ConvertCmToInch(unchecked(num3 * 100f) / 10f)), (int)Math.Round((double)Module1.ConvertCmToInch(unchecked(num4 * 100f) / 10f)));
                    }
                    else
                    {
                        this.myp.PaperSize = printForm;
                    }
                }
                if (String.Compare(this.myset.fx.Text, "横向", false) == 0)
                {
                    this.myp.PaperLandscape = true;
                }
                else
                {
                    this.myp.PaperLandscape = false;
                }
                this.myp.PaperMargins = new Margins(Convert.ToInt32(decimal.Multiply(this.myset.pagemarginl.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.pagemarginr.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.pagemargint.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.pagemarginb.Value, 10m)));
            }
        }

        // Token: 0x06000EA5 RID: 3749 RVA: 0x000744D8 File Offset: 0x000726D8
        private object MyReplace(string mytxtvalue, DataGridView dgv, int currow)
        {
            checked
            {
                object result;
                if (mytxtvalue == null)
                {
                    result = "";
                }
                else if (mytxtvalue.IndexOf("[") < 0 | mytxtvalue.IndexOf("]") < 0)
                {
                    result = mytxtvalue;
                }
                else
                {
                    int num = dgv.ColumnCount;
                    try
                    {
                        if (currow >= 0 & currow < dgv.RowCount)
                        {
                            int num2 = 0;
                            int num3 = num - 1;
                            for (int i = num2; i <= num3; i++)
                            {
                                string name = dgv.Columns[i].Name;
                                if (Strings.InStr(mytxtvalue, "[" + name + "]", CompareMethod.Binary) > 0)
                                {
                                    string text;
                                    if (dgv.Columns[i] is DataGridViewImageColumn)
                                    {
                                        Image image;
                                        try
                                        {
                                            image = (Image)SimpleReportPrint.GetFieldValue(dgv, name, currow);
                                            goto IL_113;
                                        }
                                        catch (Exception ex)
                                        {
                                            image = null;
                                            goto IL_113;
                                        }
                                    IL_C1:
                                        text = "";
                                        goto IL_D9;
                                    IL_113:
                                        if (image != null)
                                        {
                                            return image;
                                        }
                                        goto IL_C1;
                                    }
                                    else
                                    {
                                        text = Convert.ToString(SimpleReportPrint.GetFieldValue(dgv, name, currow));
                                    }
                                IL_D9:
                                    if (text != null)
                                    {
                                        try
                                        {
                                            mytxtvalue = Strings.Replace(mytxtvalue, "[" + name + "]", text, 1, -1, CompareMethod.Binary);
                                        }
                                        catch (Exception ex2)
                                        {
                                        }
                                    }
                                }
                            }
                        }
                        if (this.W_variable != null && this.W_variable.Count > 0)
                        {
                            num = this.W_variable.Count;
                            foreach (object obj in this.W_variable)
                            {
                                DictionaryEntry dictionaryEntry2 = new DictionaryEntry();
                                DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
                                string text2 = Convert.ToString(dictionaryEntry.Key);
                                string text3 = Convert.ToString(dictionaryEntry.Value);
                                if (text3 != null)
                                {
                                    text2 = "[" + text2 + "]";
                                    mytxtvalue = Strings.Replace(mytxtvalue, text2, text3, 1, -1, CompareMethod.Binary);
                                }
                            }
                        }
                        mytxtvalue = Strings.Replace(mytxtvalue, "[页码]", Convert.ToString(this.myp.GetCurrentPage()), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[总页数]", Convert.ToString(this.w_pages), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期]", Strings.Format(DateAndTime.Today, "yyyy-M-d"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期2]", Strings.Format(DateAndTime.Today, "yyyy年M月d日"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前年]", Convert.ToString(DateAndTime.Today.Year), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前月]", Convert.ToString(DateAndTime.Today.Month), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日]", Convert.ToString(DateAndTime.Today.Day), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前时间]", Strings.Format(DateAndTime.Now, "H:m:s"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[行号]", Convert.ToString(this.w_currow), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[页行号]", Convert.ToString(this.w_curpagerow), 1, -1, CompareMethod.Binary);
                    }
                    catch (Exception ex3)
                    {
                    }
                    result = mytxtvalue;
                }
                return result;
            }
        }

        // Token: 0x06000EA6 RID: 3750 RVA: 0x00074848 File Offset: 0x00072A48
        private static object GetFieldValue(DataGridView dgv, string cc, int currow)
        {
            object result;
            if (dgv == null)
            {
                result = null;
            }
            else if (currow >= dgv.RowCount | currow < 0)
            {
                result = null;
            }
            else if (SimpleReportPrint.HasColumname(cc, dgv))
            {
                if (dgv.Columns[cc] is DataGridViewImageColumn)
                {
                    result = dgv.Rows[currow].Cells[cc].FormattedValue;
                }
                else
                {
                    result = Convert.ToString(dgv.Rows[currow].Cells[cc].Value);
                }
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000EA7 RID: 3751 RVA: 0x000748D8 File Offset: 0x00072AD8
        private static bool HasColumname(string columnname, DataGridView dgv)
        {
            checked
            {
                bool result;
                if (dgv == null)
                {
                    result = false;
                }
                else
                {
                    try
                    {
                        int num = 0;
                        int num2 = dgv.ColumnCount - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            if (String.Compare(Strings.Trim(columnname.ToUpper()), Strings.Trim(dgv.Columns[i].Name.ToUpper()), false) == 0)
                            {
                                return true;
                            }
                        }
                        result = false;
                    }
                    catch (Exception ex)
                    {
                        result = false;
                    }
                }
                return result;
            }
        }

        // Token: 0x06000EA8 RID: 3752 RVA: 0x0007495C File Offset: 0x00072B5C
        private void myp_HeaderFooterOut(int pages, int curpage)
        {
            string text = this.myset.pagel.Text;
            string text2 = this.myset.pagem.Text;
            string text3 = this.myset.pager.Text;
            text = Strings.Replace(text, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
            text2 = Strings.Replace(text2, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, 0));
            text3 = Strings.Replace(text3, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text3 = Convert.ToString(this.MyReplace(text3, this.w_dgv, 0));
            this.myp.PrintHeader(text, text2, text3, this.myset.pagel.Font, this.myset.pagel.ForeColor, 0);
            text = this.myset.pageleft.Text;
            text2 = this.myset.pagemiddle.Text;
            text3 = this.myset.pageright.Text;
            text = Strings.Replace(text, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
            text2 = Strings.Replace(text2, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, 0));
            text3 = Strings.Replace(text3, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text3 = Convert.ToString(this.MyReplace(text3, this.w_dgv, 0));
            this.myp.PrintFooter(text, text2, text3, this.myset.pageleft.Font, this.myset.pageleft.ForeColor, 0);
            text = this.myset.rightt.Text;
            text2 = this.myset.rightm.Text;
            text3 = this.myset.rightb.Text;
            text = Strings.Replace(text, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
            text2 = Strings.Replace(text2, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text2 = Convert.ToString(this.MyReplace(text2, this.w_dgv, 0));
            text3 = Strings.Replace(text3, "[总页数]", Convert.ToString(pages), 1, -1, CompareMethod.Binary);
            text3 = Convert.ToString(this.MyReplace(text3, this.w_dgv, 0));
            this.myp.PrintRight(text, text2, text3, this.myset.rightt.Font, this.myset.rightt.ForeColor, 0);
        }

        // Token: 0x06000EA9 RID: 3753 RVA: 0x00074C00 File Offset: 0x00072E00
        private void PrintField()
        {
            if (this.tmpdgv != null)
            {
                float currentx = this.myp.Currentx;
                float currenty = this.myp.Currenty;
                string myborder = this.mycellborder;
                this.myp.DrawDGVHeaderEx(this.tmpdgv, this.GetFieldHeight(), this.tmptreeview, myborder, checked((int)Math.Round(Conversion.Val(this.myset.minsize.Text))));
                if (this.tmpdgv.ColumnCount <= 0)
                {
                    this.myp.Currentx = 0f;
                    this.myp.Currenty = currenty + this.GetFieldHeight();
                }
                else
                {
                    if (this.myset.gwxouterborder.Checked & decimal.Compare(this.myset.linewidth.Value, 0m) > 0)
                    {
                        float num = 0f;
                        int num2 = 0;
                        float mywidth;
                        checked
                        {
                            int num3 = this.tmpdgv.ColumnCount - 1;
                            for (int i = num2; i <= num3; i++)
                            {
                                unchecked
                                {
                                    if (this.tmpdgv.Columns[i].Visible)
                                    {
                                        num += this.myp.ConvFromDisplay((float)this.tmpdgv.Columns[i].Width, true);
                                    }
                                }
                            }
                            mywidth = Convert.ToSingle(decimal.Multiply(decimal.Multiply(this.myset.linewidth.Value, 10m), 2m));
                        }
                        if (String.Compare(this.myset.bordertype.Text, "仅横线", false) != 0)
                        {
                            if (this.tmpdgv.Columns[0].Visible)
                            {
                                this.myp.DrawLine(currentx, currenty, currentx, currenty + this.GetFieldHeight(), this.myset.linecolor.ForeColor, mywidth);
                            }
                            if (this.tmpdgv.Columns[checked(this.tmpdgv.ColumnCount - 1)].Visible)
                            {
                                this.myp.DrawLine(currentx + num, currenty, currentx + num, currenty + this.GetFieldHeight(), this.myset.linecolor.ForeColor, mywidth);
                            }
                        }
                        if (String.Compare(this.myset.bordertype.Text, "仅竖线", false) != 0)
                        {
                            this.myp.DrawLine(currentx, currenty, currentx + num, currenty, this.myset.linecolor.ForeColor, mywidth);
                        }
                    }
                    this.myp.Currentx = 0f;
                    this.myp.Currenty = currenty + this.GetFieldHeight();
                }
            }
        }

        // Token: 0x06000EAA RID: 3754 RVA: 0x00074E94 File Offset: 0x00073094
        private void DrawRow(int currow)
        {
            float currenty;
            checked
            {
                this.w_currow = currow + 1;
                currenty = this.myp.Currenty;
                int num = 0;
                int num2 = this.tmpdgv.ColumnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (this.tmpdgv.Columns[i].Visible)
                    {
                        this.DrawCell(currow, this.mycols[i], i);
                    }
                }
                this.myp.Currentx = 0f;
            }
            this.myp.Currenty = currenty + this.rowheight;
        }

        // Token: 0x06000EAB RID: 3755 RVA: 0x00074F1C File Offset: 0x0007311C
        private void DrawCell(int rowindex, ParaseTag colformat, int colindex)
        {
            if (!this.ispreview)
            {
                float mywidth = this.myp.ConvFromDisplay((float)this.tmpdgv.Columns[colindex].Width, true);
                Color rowBackColor = this.GetRowBackColor(rowindex, colformat);
                Color rowForeColor = this.GetRowForeColor(rowindex, colformat);
                object objectValue = RuntimeHelpers.GetObjectValue(this.GetCellValue(rowindex, colformat));
                if (objectValue == null)
                {
                    this.myp.DrawCell("", mywidth, this.rowheight, colformat.Cellfont, rowForeColor, this.GetCellBorder(this.tmpdgv, rowindex, colindex), colformat.CellHalign, colformat.CellValign, colformat.CellMul, false, false, false, (float)Conversion.Val(this.myset.minsize.Text), rowBackColor, this.myset.linecolor.ForeColor, 0);
                }
                else
                {
                    if (String.Compare(Strings.UCase(Versioned.TypeName(RuntimeHelpers.GetObjectValue(objectValue))), "STRING", false) != 0)
                    {
                        this.myp.DrawCellImage((Image)objectValue, this.myp.Currentx, this.myp.Currenty, mywidth, this.rowheight, this.myset.linecolor.ForeColor, this.GetCellBorder(this.tmpdgv, rowindex, colindex), colformat.ImageType, colformat.CellHalign, colformat.CellValign);
                        try
                        {
                            if (rowindex == 0)
                            {
                                int width = this.tmpdgv.Columns[colindex].Width;
                                this.tmpdgv.Columns.RemoveAt(colindex);
                                this.tmpdgv.Columns.Insert(colindex, new DataGridViewImageColumn());
                                this.tmpdgv.Columns[colindex].Width = width;
                                this.tmpdgv.Rows[rowindex].Cells[colindex].Value = (Image)objectValue;
                            }
                            else
                            {
                                this.tmpdgv.Rows[rowindex].Cells[colindex].Value = (Image)objectValue;
                            }
                            return;
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                    this.myp.DrawCell(Convert.ToString(objectValue), mywidth, this.rowheight, colformat.Cellfont, rowForeColor, this.GetCellBorder(this.tmpdgv, rowindex, colindex), colformat.CellHalign, colformat.CellValign, colformat.CellMul, false, false, false, (float)Conversion.Val(this.myset.minsize.Text), rowBackColor, this.myset.linecolor.ForeColor, 0);
                    this.tmpdgv.Rows[rowindex].Cells[colindex].Value = Convert.ToString(objectValue);
                    DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleLeft;
                    switch (colformat.CellHalign)
                    {
                        case StringAlignment.Near:
                            switch (colformat.CellValign)
                            {
                                case StringAlignment.Near:
                                    alignment = DataGridViewContentAlignment.TopLeft;
                                    break;
                                case StringAlignment.Center:
                                    alignment = DataGridViewContentAlignment.MiddleLeft;
                                    break;
                                case StringAlignment.Far:
                                    alignment = DataGridViewContentAlignment.BottomLeft;
                                    break;
                            }
                            break;
                        case StringAlignment.Center:
                            switch (colformat.CellValign)
                            {
                                case StringAlignment.Near:
                                    alignment = DataGridViewContentAlignment.TopCenter;
                                    break;
                                case StringAlignment.Center:
                                    alignment = DataGridViewContentAlignment.MiddleCenter;
                                    break;
                                case StringAlignment.Far:
                                    alignment = DataGridViewContentAlignment.BottomCenter;
                                    break;
                            }
                            break;
                        case StringAlignment.Far:
                            switch (colformat.CellValign)
                            {
                                case StringAlignment.Near:
                                    alignment = DataGridViewContentAlignment.TopRight;
                                    break;
                                case StringAlignment.Center:
                                    alignment = DataGridViewContentAlignment.MiddleRight;
                                    break;
                                case StringAlignment.Far:
                                    alignment = DataGridViewContentAlignment.BottomRight;
                                    break;
                            }
                            break;
                    }
                    this.tmpdgv.Rows[rowindex].Cells[colindex].Style.Alignment = alignment;
                    this.tmpdgv.Rows[rowindex].Cells[colindex].Style.ForeColor = rowForeColor;
                    this.tmpdgv.Rows[rowindex].Cells[colindex].Style.BackColor = rowBackColor;
                    this.tmpdgv.Rows[rowindex].Cells[colindex].Style.Font = colformat.Cellfont;
                }
            }
        }

        // Token: 0x06000EAC RID: 3756 RVA: 0x00075314 File Offset: 0x00073514
        private object GetCellValue(int rowindex, ParaseTag colformat)
        {
            string text = "";
            object objectValue = RuntimeHelpers.GetObjectValue(this.MyReplace(colformat.Cellfield, this.w_dgv, rowindex));
            object result;
            if (String.Compare(Strings.UCase(Versioned.TypeName(RuntimeHelpers.GetObjectValue(objectValue))), "STRING", false) != 0)
            {
                result = objectValue;
            }
            else
            {
                text = Convert.ToString(objectValue);
                if (!colformat.IsPrintZero && (String.Compare(text, "0", false) == 0 | String.Compare(text, "0.00", false) == 0 | String.Compare(text, ".00", false) == 0 | String.Compare(text, "0.0", false) == 0))
                {
                    text = "";
                    result = text;
                }
                else
                {
                    if (!colformat.IsComputer)
                    {
                        text = SimpleReportModule.GetFormatValue(text, colformat.CellType, colformat.CellFormat);
                    }
                    else
                    {
                        if (String.Compare(Strings.Trim(text), "", false) != 0)
                        {
                            string text2 = SimpleComputer.ComputeSimple(text);
                            if (String.Compare(text2, "", false) == 0)
                            {
                                SourceComp sourceComp = new SourceComp();
                                try
                                {
                                    string text3 = sourceComp.GetExpressionValue(text).ToString();
                                    text = text3;
                                    goto IL_118;
                                }
                                catch (Exception ex)
                                {
                                    goto IL_118;
                                }
                            }
                            text = text2;
                        }
                    IL_118:
                        if (!colformat.IsPrintZero && (String.Compare(text, "0", false) == 0 | String.Compare(text, "0.00", false) == 0 | String.Compare(text, ".00", false) == 0 | String.Compare(text, "0.0", false) == 0))
                        {
                            text = "";
                            return text;
                        }
                        text = SimpleReportModule.GetFormatValue(text, colformat.CellType, colformat.CellFormat);
                    }
                    if (!colformat.IsPrintZero && (String.Compare(text, "0", false) == 0 | String.Compare(text, "0.00", false) == 0 | String.Compare(text, ".00", false) == 0 | String.Compare(text, "0.0", false) == 0))
                    {
                        text = "";
                    }
                    result = text;
                }
            }
            return result;
        }

        // Token: 0x06000EAD RID: 3757 RVA: 0x00075504 File Offset: 0x00073704
        private void DrawRowEmpty(int currow, bool islastrow, bool isdrawbackcolor)
        {
            float currenty;
            checked
            {
                this.w_currow = currow + 1;
                currenty = this.myp.Currenty;
                int num = 0;
                int num2 = this.tmpdgv.ColumnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (this.tmpdgv.Columns[i].Visible)
                    {
                        this.DrawCellEmpty(currow, this.mycols[i], i, islastrow, isdrawbackcolor);
                    }
                }
                this.myp.Currentx = 0f;
            }
            this.myp.Currenty = currenty + this.rowheight;
        }

        // Token: 0x06000EAE RID: 3758 RVA: 0x00075590 File Offset: 0x00073790
        private void DrawCellEmpty(int rowindex, ParaseTag colformat, int colindex, bool islastrow, bool isdrawbackcolor)
        {
            float mywidth = this.myp.ConvFromDisplay((float)this.tmpdgv.Columns[colindex].Width, true);
            Color backcolor;
            if (isdrawbackcolor)
            {
                backcolor = this.GetRowBackColor(rowindex, colformat);
            }
            else
            {
                backcolor = Color.Empty;
            }
            Color rowForeColor = this.GetRowForeColor(rowindex, colformat);
            this.myp.DrawCell("", mywidth, this.rowheight, colformat.Cellfont, rowForeColor, this.GetEmptyCellBorder(this.tmpdgv, islastrow, colindex), colformat.CellHalign, colformat.CellValign, colformat.CellMul, false, false, false, (float)Conversion.Val(this.myset.minsize.Text), backcolor, this.myset.linecolor.ForeColor, 0);
        }

        // Token: 0x06000EAF RID: 3759 RVA: 0x0007564C File Offset: 0x0007384C
        private float GetFieldHeight()
        {
            return Convert.ToSingle(decimal.Multiply(this.myset.fieldheight.Value, 10m));
        }

        // Token: 0x06000EB0 RID: 3760 RVA: 0x00075684 File Offset: 0x00073884
        private Color GetRowBackColor(int rowindex, ParaseTag colformat)
        {
            Color result;
            if (!this.myset.Cbackcolor.Checked)
            {
                if (checked(rowindex + 1) % 2 == 0)
                {
                    result = this.myset.jsh.BackColor;
                }
                else
                {
                    result = colformat.Cellbackcolor;
                }
            }
            else
            {
                result = colformat.Cellbackcolor;
            }
            return result;
        }

        // Token: 0x06000EB1 RID: 3761 RVA: 0x000756D0 File Offset: 0x000738D0
        private Color GetRowForeColor(int rowindex, ParaseTag colformat)
        {
            Color result;
            if (!this.myset.Cforecolor.Checked)
            {
                if (checked(rowindex + 1) % 2 == 0)
                {
                    result = this.myset.jsh.ForeColor;
                }
                else
                {
                    result = colformat.Cellforecolor;
                }
            }
            else
            {
                result = colformat.Cellforecolor;
            }
            return result;
        }

        // Token: 0x06000EB2 RID: 3762 RVA: 0x0007571C File Offset: 0x0007391C
        private string GetDefaultCellBorder()
        {
            string text = Convert.ToString(decimal.Multiply(this.myset.linewidth.Value, 10m));
            string result;
            if (String.Compare(this.myset.bordertype.Text, "仅横线", false) == 0)
            {
                result = "0," + text + ",0," + text;
            }
            else if (String.Compare(this.myset.bordertype.Text, "仅竖线", false) == 0)
            {
                result = text + ",0," + text + ",0";
            }
            else
            {
                result = string.Concat(new string[]
                {
                    text,
                    ",",
                    text,
                    ",",
                    text,
                    ",",
                    text
                });
            }
            return result;
        }

        // Token: 0x06000EB3 RID: 3763 RVA: 0x000757F0 File Offset: 0x000739F0
        private string GetCellBorder(DataGridView dgv, int rowindex, int colindex)
        {
            checked
            {
                string result;
                if (!this.myset.gwxouterborder.Checked)
                {
                    result = this.mycellborder;
                }
                else if (String.Compare(this.mycellborder, "", false) == 0)
                {
                    result = this.mycellborder;
                }
                else
                {
                    string[] array = Strings.Split(this.mycellborder, ",", -1, CompareMethod.Binary);
                    string text = array[0];
                    string text2 = array[1];
                    string text3 = array[2];
                    string text4 = array[3];
                    if (dgv == null)
                    {
                        result = this.mycellborder;
                    }
                    else
                    {
                        if (rowindex < 0)
                        {
                            text2 = Convert.ToString(Convert.ToInt32(text2) * 2);
                        }
                        if (colindex == 0)
                        {
                            text = Convert.ToString(Convert.ToInt32(text) * 2);
                        }
                        if (colindex == dgv.ColumnCount - 1)
                        {
                            text3 = Convert.ToString(Convert.ToInt32(text3) * 2);
                        }
                        if (rowindex == this.w_dgv.RowCount - 1 & !this.myset.addemptyrow.Checked)
                        {
                            text4 = Convert.ToString(Convert.ToInt32(text4) * 2);
                        }
                        result = string.Concat(new string[]
                        {
                            text,
                            ",",
                            text2,
                            ",",
                            text3,
                            ",",
                            text4
                        });
                    }
                }
                return result;
            }
        }

        // Token: 0x06000EB4 RID: 3764 RVA: 0x0007592C File Offset: 0x00073B2C
        private string GetEmptyCellBorder(DataGridView dgv, bool islastrow, int colindex)
        {
            checked
            {
                string result;
                if (!this.myset.gwxouterborder.Checked)
                {
                    result = this.mycellborder;
                }
                else if (String.Compare(this.mycellborder, "", false) == 0)
                {
                    result = this.mycellborder;
                }
                else
                {
                    string[] array = Strings.Split(this.mycellborder, ",", -1, CompareMethod.Binary);
                    string text = array[0];
                    string text2 = array[1];
                    string text3 = array[2];
                    string text4 = array[3];
                    if (dgv == null)
                    {
                        result = this.mycellborder;
                    }
                    else
                    {
                        if (colindex == 0)
                        {
                            text = Convert.ToString(Convert.ToInt32(text) * 2);
                        }
                        if (colindex == dgv.ColumnCount - 1)
                        {
                            text3 = Convert.ToString(Convert.ToInt32(text3) * 2);
                        }
                        if (islastrow)
                        {
                            text4 = Convert.ToString(Convert.ToInt32(text4) * 2);
                        }
                        result = string.Concat(new string[]
                        {
                            text,
                            ",",
                            text2,
                            ",",
                            text3,
                            ",",
                            text4
                        });
                    }
                }
                return result;
            }
        }

        // Token: 0x06000EB5 RID: 3765 RVA: 0x00075A2C File Offset: 0x00073C2C
        private void PrintTableCommon()
        {
            float tableFooterHeight = this.GetTableFooterHeight();
            this.myp.NewPage();
            this.PrintReportHeader();
            this.w_curpagerow = 1;
            if (decimal.Compare(this.myset.fixedrows.Value, 0m) <= 0)
            {
                float num = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight + this.GetFieldHeight();
                if (this.myset.tablefooterprinteverypage.Checked)
                {
                    num += this.GetTableFooterHeight();
                }
                bool flag;
                if (this.myp.IsNewPage(num))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    this.PrintMainTitle(false);
                    this.PrintSubTitle(false);
                    this.PrintField();
                }
                int num2 = 0;
                checked
                {
                    int num3 = this.w_dgv.RowCount - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        this.w_currow = i + 1;
                        if (flag)
                        {
                            flag = false;
                            this.myp.NewPage();
                            this.w_curpagerow = 1;
                            this.PrintMainTitle(false);
                            this.PrintSubTitle(false);
                            this.PrintField();
                        }
                        this.DrawRow(i);
                        if (i == this.w_dgv.RowCount - 1)
                        {
                            break;
                        }
                        if (this.myset.tablefooterprinteverypage.Checked)
                        {
                            if (this.myp.IsNewPage(unchecked(tableFooterHeight + this.rowheight)))
                            {
                                this.PrintTableFooter(true);
                                flag = true;
                            }
                        }
                        else if (this.myp.IsNewPage(this.rowheight))
                        {
                            flag = true;
                        }
                        this.w_curpagerow++;
                    }
                    if (this.myset.addemptyrow.Checked)
                    {
                        int num4 = (int)Math.Round(Math.Floor((double)(unchecked(this.myp.PaperPrintHeight - this.myp.Currenty - this.GetTableFooterHeight() - this.GetReportFooterHeight()) / this.rowheight)));
                        if (num4 == 0 & this.myset.gwxouterborder.Checked)
                        {
                            this.myp.Currentx = 0f;
                            this.myp.Currenty = unchecked(this.myp.Currenty - this.rowheight);
                            this.DrawRowEmpty(this.w_dgv.RowCount - 1, true, false);
                        }
                        else if (this.w_dgv.RowCount % 2 == 1)
                        {
                            int num5 = 1;
                            int num6 = num4;
                            for (int j = num5; j <= num6; j++)
                            {
                                this.DrawRowEmpty(j, Convert.ToBoolean(Interaction.IIf(j == num4, true, false)), true);
                            }
                        }
                        else
                        {
                            int num7 = 0;
                            int num8 = num4 - 1;
                            for (int k = num7; k <= num8; k++)
                            {
                                this.DrawRowEmpty(k, Convert.ToBoolean(Interaction.IIf(k == num4 - 1, true, false)), true);
                            }
                        }
                    }
                    this.PrintTableFooter(true);
                    this.PrintReportFooter();
                }
            }
            else
            {
                int num9 = Convert.ToInt32(this.myset.fixedrows.Value);
                float num = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight * (float)num9 + this.GetFieldHeight();
                if (this.myset.tablefooterprinteverypage.Checked)
                {
                    num += this.GetTableFooterHeight();
                }
                bool flag;
                if (this.myp.IsNewPage(num))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    this.PrintMainTitle(false);
                    this.PrintSubTitle(false);
                    this.PrintField();
                }
                int num10 = 0;
                checked
                {
                    int num11 = this.w_dgv.RowCount - 1;
                    for (int l = num10; l <= num11; l++)
                    {
                        this.w_currow = l + 1;
                        if (flag)
                        {
                            flag = false;
                            this.myp.NewPage();
                            this.w_curpagerow = 1;
                            this.PrintMainTitle(false);
                            this.PrintSubTitle(false);
                            this.PrintField();
                        }
                        this.DrawRow(l);
                        if (l == this.w_dgv.RowCount - 1)
                        {
                            break;
                        }
                        if (this.w_curpagerow == num9)
                        {
                            flag = true;
                            this.PrintTableFooter(true);
                        }
                        this.w_curpagerow++;
                    }
                    if (this.myset.addemptyrow.Checked)
                    {
                        int num12 = num9 - this.w_curpagerow;
                        if (num12 == 0 & this.myset.gwxouterborder.Checked)
                        {
                            this.myp.Currentx = 0f;
                            this.myp.Currenty = unchecked(this.myp.Currenty - this.rowheight);
                            this.DrawRowEmpty(this.w_dgv.RowCount - 1, true, false);
                        }
                        else if (this.w_dgv.RowCount % 2 == 1)
                        {
                            int num13 = 1;
                            int num14 = num12;
                            for (int m = num13; m <= num14; m++)
                            {
                                this.DrawRowEmpty(m, Convert.ToBoolean(Interaction.IIf(m == num12, true, false)), true);
                            }
                        }
                        else
                        {
                            int num15 = 0;
                            int num16 = num12 - 1;
                            for (int n = num15; n <= num16; n++)
                            {
                                this.DrawRowEmpty(n, Convert.ToBoolean(Interaction.IIf(n == num12 - 1, true, false)), true);
                            }
                        }
                    }
                    this.PrintTableFooter(true);
                    this.PrintReportFooter();
                }
            }
        }

        // Token: 0x06000EB6 RID: 3766 RVA: 0x00075F10 File Offset: 0x00074110
        private string[] SplitPages(DataGridView dgv, int fixedcols)
        {
            string[] array = new string[1];
            float num = 0f;
            int num2 = 0;
            checked
            {
                int num3 = fixedcols - 1;
                for (int i = num2; i <= num3; i++)
                {
                    unchecked
                    {
                        num += Convert.ToSingle(decimal.Multiply(this.mycols[i].ColWidth, 10m));
                    }
                }
                string[] result;
                if (num >= this.myp.PaperPrintWidth)
                {
                    Interaction.MsgBox("无法以跨页形式打印，原因是固定列的宽度大于页面可打印宽度", MsgBoxStyle.Exclamation, "提示信息");
                    result = null;
                }
                else
                {
                    string text = "";
                    int num4 = 0;
                    int num5 = fixedcols - 1;
                    for (int j = num4; j <= num5; j++)
                    {
                        if (String.Compare(text, "", false) == 0)
                        {
                            text = Convert.ToString(j);
                        }
                        else
                        {
                            text = text + "," + Convert.ToString(j);
                        }
                    }
                    float paperPrintWidth = this.myp.PaperPrintWidth;
                    float num6 = num;
                    string text2 = text;
                    int num7 = 0;
                    int num8 = dgv.ColumnCount - 1;
                    for (int k = fixedcols; k <= num8; k++)
                    {
                        float num9 = Convert.ToSingle(decimal.Multiply(this.mycols[k].ColWidth, 10m));
                        unchecked
                        {
                            if (num6 + num9 > paperPrintWidth)
                            {
                                array = (string[])Utils.CopyArray((Array)array, new string[checked(num7 + 1)]);
                                array[num7] = text2;
                                text2 = text;
                                num6 = num;
                                if (String.Compare(text2, "", false) == 0)
                                {
                                    text2 = Convert.ToString(k);
                                }
                                else
                                {
                                    text2 = text2 + "," + Convert.ToString(k);
                                }
                                num6 += num9;
                                checked
                                {
                                    num7++;
                                }
                            }
                            else
                            {
                                if (String.Compare(text2, "", false) == 0)
                                {
                                    text2 = Convert.ToString(k);
                                }
                                else
                                {
                                    text2 = text2 + "," + Convert.ToString(k);
                                }
                                num6 += num9;
                            }
                        }
                    }
                    array = (string[])Utils.CopyArray((Array)array, new string[num7 + 1]);
                    array[num7] = text2;
                    result = array;
                }
                return result;
            }
        }

        // Token: 0x06000EB7 RID: 3767 RVA: 0x0007610C File Offset: 0x0007430C
        private static void ParasePage(DataGridView dgv, string ss)
        {
            string[] array = Strings.Split(ss, ",", -1, CompareMethod.Binary);
            checked
            {
                for (int i = dgv.ColumnCount - 1; i >= 0; i += -1)
                {
                    dgv.Columns[i].Visible = false;
                }
                int num = 0;
                int num2 = array.Length - 1;
                for (int j = num; j <= num2; j++)
                {
                    dgv.Columns[Convert.ToInt32(array[j])].Visible = true;
                }
            }
        }

        // Token: 0x06000EB8 RID: 3768 RVA: 0x00076178 File Offset: 0x00074378
        private void PrintTableMulPage()
        {
            int fixedcols = checked((int)Math.Round(Conversion.Val(this.myset.columns.Text)));
            string[] array = this.SplitPages(this.tmpdgv, fixedcols);
            if (array != null)
            {
                float tableFooterHeight = this.GetTableFooterHeight();
                this.myp.NewPage();
                this.PrintReportHeader();
                float currenty = this.myp.Currenty;
                int i = 0;
                this.w_curpagerow = 1;
                float num = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight + this.GetFieldHeight();
                if (this.myset.tablefooterprinteverypage.Checked)
                {
                    num += this.GetTableFooterHeight();
                }
                bool flag;
                if (this.myp.IsNewPage(num))
                {
                    flag = true;
                    currenty = 0f;
                }
                else
                {
                    flag = false;
                }
                checked
                {
                    while (i <= this.w_dgv.RowCount - 1)
                    {
                        int num2 = 0;
                        int num3 = array.Length - 1;
                        int j = num2;
                    IL_221:
                        int k = 0;
                        while (j <= num3)
                        {
                            if (flag)
                            {
                                this.myp.NewPage();
                                flag = false;
                            }
                            if (i == 0)
                            {
                                this.myp.Currenty = currenty;
                            }
                            SimpleReportPrint.ParasePage(this.tmpdgv, array[j]);
                            if (this.myset.zoomtopaperwidth.Checked)
                            {
                                this.ZoomDGVtoWidth(this.tmpdgv, this.myp.PaperPrintWidth);
                            }
                            if (i == 0)
                            {
                                this.PrintMainTitle(true);
                                this.PrintSubTitle(true);
                            }
                            else
                            {
                                this.PrintMainTitle(false);
                                this.PrintSubTitle(false);
                            }
                            this.PrintField();
                            this.w_curpagerow = 1;
                            int num4 = i;
                            int num5 = this.w_dgv.RowCount - 1;
                            k = num4;
                            while (k <= num5)
                            {
                                this.w_currow = k + 1;
                                this.DrawRow(k);
                                if (k != this.w_dgv.RowCount - 1)
                                {
                                    if (this.myset.tablefooterprinteverypage.Checked)
                                    {
                                        if (this.myp.IsNewPage(unchecked(tableFooterHeight + this.rowheight)))
                                        {
                                            this.PrintTableFooter(true);
                                            flag = true;
                                            break;
                                        }
                                    }
                                    else if (this.myp.IsNewPage(this.rowheight))
                                    {
                                        flag = true;
                                        break;
                                    }
                                    this.w_curpagerow++;
                                    k++;
                                    continue;
                                }
                                flag = true;
                            IL_204:
                                if (k == this.w_dgv.RowCount - 1)
                                {
                                    this.PrintTableFooter(true);
                                }
                                j++;
                                goto IL_221;
                            }

                        }
                        i = k + 1;
                    }
                    this.PrintReportFooter();
                }
            }
        }

        // Token: 0x06000EB9 RID: 3769 RVA: 0x000763D0 File Offset: 0x000745D0
        private void PrintTableCols()
        {
            float tableFooterHeight = this.GetTableFooterHeight();
            this.myp.NewPage();
            this.PrintReportHeader();
            this.w_curpagerow = 1;
            int num = checked((int)Math.Round(Conversion.Val(this.myset.ls.Text)));
            float num2 = Convert.ToSingle(this.myset.ljj.Value);
            float num3 = (this.myp.PaperPrintWidth - num2 * (float)(checked(num - 1))) / (float)num;
            if (this.myset.zoomtopaperwidth.Checked)
            {
                this.ZoomDGVtoWidth(this.tmpdgv, num3);
            }
            float num4 = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight + this.GetFieldHeight();
            if (this.myset.tablefooterprinteverypage.Checked)
            {
                num4 += this.GetTableFooterHeight();
            }
            checked
            {
                bool flag;
                if (this.myp.IsNewPage(num4))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    this.PrintMainTitle(false);
                    this.PrintSubTitle(false);
                    float currenty = this.myp.Currenty;
                    int num5 = 0;
                    int num6 = num - 1;
                    for (int i = num5; i <= num6; i++)
                    {
                        this.myp.Currenty = currenty;
                        this.myp.Currentx = unchecked(num3 * (float)i + num2 * (float)i);
                        this.PrintField();
                    }
                }
                int num7 = 0;
                int num8 = this.w_dgv.RowCount - 1;
                int num9 = num;
                int num10 = num7;
                while ((num9 >> 31 ^ num10) <= (num9 >> 31 ^ num8))
                {
                    this.w_currow = num10 + 1;
                    float currenty;
                    if (flag)
                    {
                        flag = false;
                        this.myp.NewPage();
                        this.w_curpagerow = 1;
                        this.PrintMainTitle(false);
                        this.PrintSubTitle(false);
                        currenty = this.myp.Currenty;
                        int num11 = 0;
                        int num12 = num - 1;
                        for (int j = num11; j <= num12; j++)
                        {
                            this.myp.Currenty = currenty;
                            this.myp.Currentx = unchecked(num3 * (float)j + num2 * (float)j);
                            this.PrintField();
                        }
                    }
                    currenty = this.myp.Currenty;
                    int num13 = 0;
                    int num14 = num - 1;
                    for (int k = num13; k <= num14; k++)
                    {
                        this.myp.Currenty = currenty;
                        this.myp.Currentx = unchecked(num3 * (float)k + num2 * (float)k);
                        this.w_currow = num10 + 1 + k;
                        this.DrawRow(num10 + k);
                        if (num10 + k >= this.w_dgv.RowCount - 1)
                        {
                            break;
                        }
                    }
                    if (num10 + num - 1 >= this.w_dgv.RowCount - 1)
                    {
                        break;
                    }
                    if (this.myset.tablefooterprinteverypage.Checked)
                    {
                        if (this.myp.IsNewPage(unchecked(tableFooterHeight + this.rowheight)))
                        {
                            this.PrintTableFooter(true);
                            flag = true;
                        }
                    }
                    else if (this.myp.IsNewPage(this.rowheight))
                    {
                        flag = true;
                    }
                    this.w_curpagerow++;
                    num10 += num9;
                }
                this.PrintTableFooter(true);
                this.PrintReportFooter();
            }
        }

        // Token: 0x06000EBA RID: 3770 RVA: 0x000766B4 File Offset: 0x000748B4
        private void PrintTableGZ1()
        {
            string[] array = this.SplitPages(this.tmpdgv, 0);
            if (array != null)
            {
                float tableFooterHeight = this.GetTableFooterHeight();
                this.myp.NewPage();
                this.PrintReportHeader();
                float num = Convert.ToSingle(decimal.Multiply(this.myset.gzjj.Value, 10m));
                this.w_curpagerow = 1;
                float fieldHeight = this.GetFieldHeight();
                float num2 = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight + fieldHeight;
                if (this.myset.tablefooterprinteverypage.Checked)
                {
                    num2 += this.GetTableFooterHeight();
                }
                bool flag;
                if (this.myp.IsNewPage(num2))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    this.PrintMainTitle(false);
                    this.PrintSubTitle(false);
                }
                this.w_curpagerow = 1;
                int num3 = 0;
                checked
                {
                    int num4 = this.w_dgv.RowCount - 1;
                    int i = num3;
                IL_237:
                    while (i <= num4)
                    {
                        this.w_currow = i + 1;
                        int num5 = 0;
                        int num6 = array.Length - 1;
                        int j = num5;
                        while (j <= num6)
                        {
                            SimpleReportPrint.ParasePage(this.tmpdgv, array[j]);
                            if (flag)
                            {
                                this.myp.NewPage();
                                this.PrintMainTitle(false);
                                this.PrintSubTitle(false);
                                this.w_curpagerow = 1;
                                flag = false;
                            }
                            this.PrintField();
                            this.DrawRow(i);
                            this.w_curpagerow++;
                            if (j != array.Length - 1)
                            {
                                unchecked
                                {
                                    if (this.myset.tablefooterprinteverypage.Checked)
                                    {
                                        if (this.myp.IsNewPage(tableFooterHeight + this.rowheight + fieldHeight))
                                        {
                                            this.PrintTableFooter(true);
                                            flag = true;
                                            break;
                                        }
                                    }
                                    else if (this.myp.IsNewPage(this.rowheight + fieldHeight))
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                                j++;
                                continue;
                            }
                        IL_1B7:
                            if (i == this.w_dgv.RowCount - 1)
                            {
                                goto IL_23F;
                            }
                            unchecked
                            {
                                if (this.myset.tablefooterprinteverypage.Checked)
                                {
                                    if (this.myp.IsNewPage(tableFooterHeight + this.rowheight + fieldHeight + num))
                                    {
                                        this.PrintTableFooter(true);
                                        flag = true;
                                    }
                                }
                                else if (this.myp.IsNewPage(this.rowheight + fieldHeight + num))
                                {
                                    flag = true;
                                }
                                this.myp.Currenty = this.myp.Currenty + num;
                            }
                            i++;
                            goto IL_237;
                        }

                    }
                IL_23F:
                    this.PrintTableFooter(true);
                    this.PrintReportFooter();
                }
            }
        }

        // Token: 0x06000EBB RID: 3771 RVA: 0x00005D84 File Offset: 0x00003F84
        private void DrawRowGz(int currow)
        {
            if (this.myset.lz.Checked)
            {
                this.PrintField();
                this.DrawRow(currow);
            }
            else
            {
                this.ComputeVisibleColumnsForGZ(this.tmpdgv, currow);
                this.PrintField();
                this.DrawRow(currow);
            }
        }

        // Token: 0x06000EBC RID: 3772 RVA: 0x00076910 File Offset: 0x00074B10
        private void ComputeVisibleColumnsForGZ(DataGridView dgv, int currow)
        {
            checked
            {
                if (dgv != null)
                {
                    int num = 0;
                    int num2 = dgv.ColumnCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (this.IsNullValueGZ(currow, i))
                        {
                            dgv.Columns[i].Visible = false;
                        }
                        else
                        {
                            dgv.Columns[i].Visible = true;
                        }
                    }
                }
            }
        }

        // Token: 0x06000EBD RID: 3773 RVA: 0x00076968 File Offset: 0x00074B68
        private bool IsNullValueGZ(int currow, int colindex)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(this.GetCellValue(currow, this.mycols[colindex]));
            bool result;
            if (String.Compare(Strings.UCase(Versioned.TypeName(RuntimeHelpers.GetObjectValue(objectValue))), "STRING", false) != 0)
            {
                result = false;
            }
            else
            {
                string left = Strings.Trim(Convert.ToString(objectValue));
                result = (String.Compare(left, "", false) == 0 | String.Compare(left, "0", false) == 0 | String.Compare(left, "0.0", false) == 0 | String.Compare(left, "0.00", false) == 0);
            }
            return result;
        }

        // Token: 0x06000EBE RID: 3774 RVA: 0x00076A00 File Offset: 0x00074C00
        private void PrintTableGZ2()
        {
            float tableFooterHeight = this.GetTableFooterHeight();
            this.myp.NewPage();
            this.PrintReportHeader();
            float num = Convert.ToSingle(decimal.Multiply(this.myset.gzjj.Value, 10m));
            this.w_curpagerow = 1;
            float fieldHeight = this.GetFieldHeight();
            float num2 = this.GetMainTitleHeight() + this.GetSubTitleHeight() + this.rowheight + fieldHeight;
            if (this.myset.tablefooterprinteverypage.Checked)
            {
                num2 += this.GetTableFooterHeight();
            }
            bool flag;
            if (this.myp.IsNewPage(num2))
            {
                flag = true;
            }
            else
            {
                flag = false;
                this.PrintMainTitle(false);
                this.PrintSubTitle(false);
            }
            this.w_curpagerow = 1;
            int num3 = 0;
            checked
            {
                int num4 = this.w_dgv.RowCount - 1;
                for (int i = num3; i <= num4; i++)
                {
                    this.w_currow = i + 1;
                    if (flag)
                    {
                        this.myp.NewPage();
                        this.PrintMainTitle(false);
                        this.PrintSubTitle(false);
                        this.w_curpagerow = 1;
                        flag = false;
                    }
                    this.DrawRowGz(i);
                    this.w_curpagerow++;
                    unchecked
                    {
                        if (this.myset.tablefooterprinteverypage.Checked)
                        {
                            if (this.myp.IsNewPage(tableFooterHeight + this.rowheight + fieldHeight + num))
                            {
                                this.PrintTableFooter(true);
                                flag = true;
                            }
                        }
                        else if (this.myp.IsNewPage(this.rowheight + fieldHeight + num))
                        {
                            flag = true;
                        }
                        this.myp.Currenty = this.myp.Currenty + num;
                    }
                }
                this.PrintTableFooter(true);
                this.PrintReportFooter();
            }
        }

        // Token: 0x06000EBF RID: 3775 RVA: 0x00076BA4 File Offset: 0x00074DA4
        private void myp_PrintDocument()
        {
            if (this.myset.R1.Checked)
            {
                if (this.myset.zoomtopaperwidth.Checked)
                {
                    this.ZoomDGVtoWidth(this.tmpdgv, this.myp.PaperPrintWidth);
                }
                this.PrintTableCommon();
            }
            else if (this.myset.R3.Checked)
            {
                this.PrintTableMulPage();
            }
            else if (this.myset.R2.Checked)
            {
                this.PrintTableCols();
            }
            else if (this.myset.R4.Checked)
            {
                if (this.myset.gzwrap.Checked)
                {
                    this.PrintTableGZ1();
                }
                else
                {
                    if (this.myset.lz.Checked && this.myset.zoomtopaperwidth.Checked)
                    {
                        this.ZoomDGVtoWidth(this.tmpdgv, this.myp.PaperPrintWidth);
                    }
                    this.PrintTableGZ2();
                }
            }
        }

        // Token: 0x06000EC0 RID: 3776 RVA: 0x00076C9C File Offset: 0x00074E9C
        private void MyRefResh()
        {
            if (this.IsNeedPreView())
            {
                bool isImmediatePrintNotPreview = this.myp.IsImmediatePrintNotPreview;
                this.myp.IsImmediatePrintNotPreview = false;
                this.ispreview = true;
                this.myp.IsShowProgess = false;
                this.MyStart();
                this.w_pages = this.myp.GetPages();
                this.myp.IsImmediatePrintNotPreview = isImmediatePrintNotPreview;
            }
            this.ispreview = false;
            this.myp.IsShowProgess = true;
            this.MyStart();
        }

        // Token: 0x06000EC1 RID: 3777 RVA: 0x00076D18 File Offset: 0x00074F18
        private void MyStart()
        {
            this.myp.PageUnits = VB2008Print.PageExportUnit.CentiMeter;
            if (this.mycols != null)
            {
                this.mycols = null;
            }
            this.myp.CellMargin = new Margins(Convert.ToInt32(decimal.Multiply(this.myset.cleft.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.cright.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.ctop.Value, 10m)), Convert.ToInt32(decimal.Multiply(this.myset.cright.Value, 10m)));
            this.myp.IsNeedCheckNewPage = false;
            this.SetPageSettings();
            if (this.myset.drawheader.Checked)
            {
                this.myp.IsDrawPageHeaderLine = true;
            }
            else
            {
                this.myp.IsDrawPageHeaderLine = false;
            }
            if (this.myset.drawfooter.Checked)
            {
                this.myp.IsDrawPageFooterLine = true;
            }
            else
            {
                this.myp.IsDrawPageFooterLine = false;
            }
            this.PrintZDX();
            this.PrintWater();
            this.Init();
            this.w_currow = 1;
            this.w_curpagerow = 1;
            this.mycellborder = this.GetDefaultCellBorder();
            this.rowheight = Convert.ToSingle(decimal.Multiply(this.myset.rowheight.Value, 10m));
            checked
            {
                int num = (int)Math.Round(Math.Floor((double)this.myp.ConvToDisplay(this.rowheight, false)));
                int num2 = 0;
                int num3 = this.tmpdgv.RowCount - 1;
                for (int i = num2; i <= num3; i++)
                {
                    this.tmpdgv.Rows[i].Height = num;
                }
                num = (int)Math.Round(Math.Floor((double)this.myp.ConvToDisplay(Convert.ToSingle(decimal.Multiply(this.myset.fieldheight.Value, 10m)), false)));
                this.tmpdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                this.tmpdgv.ColumnHeadersHeight = num;
                this.myp.IsShowProgess = this.myisshowprogress;
                this.myp.InvalidatePreview();
            }
        }

        // Token: 0x06000EC2 RID: 3778 RVA: 0x00076F7C File Offset: 0x0007517C
        private bool IsNeedPreView()
        {
            string @string = "[总页数]";
            checked
            {
                bool result;
                if (this.myset == null)
                {
                    result = false;
                }
                else if (Strings.InStr(this.myset.maintitle.Text, @string, CompareMethod.Binary) > 0)
                {
                    result = true;
                }
                else if (Strings.InStr(this.myset.reportheadertext.Text, @string, CompareMethod.Binary) > 0)
                {
                    result = true;
                }
                else if (Strings.InStr(this.myset.reportfootertext.Text, @string, CompareMethod.Binary) > 0)
                {
                    result = true;
                }
                else
                {
                    int num = 0;
                    int num2 = this.myset.d1.RowCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (Strings.InStr(Convert.ToString(this.myset.d1.Rows[i].Cells[0].Value), @string, CompareMethod.Binary) > 0)
                        {
                            return true;
                        }
                    }
                    int num3 = 0;
                    int num4 = this.myset.d2.RowCount - 1;
                    for (int j = num3; j <= num4; j++)
                    {
                        if (Strings.InStr(Convert.ToString(this.myset.d2.Rows[j].Cells[0].Value), @string, CompareMethod.Binary) > 0)
                        {
                            return true;
                        }
                    }
                    result = false;
                }
                return result;
            }
        }

        // Token: 0x06000EC3 RID: 3779 RVA: 0x000770B8 File Offset: 0x000752B8
        private void Init()
        {
            if (this.tmptreeview != null)
            {
                this.tmptreeview.Dispose();
                this.tmptreeview = null;
            }
            if (this.tmpdgv != null)
            {
                this.tmpdgv.Dispose();
                this.tmpdgv = null;
            }
            checked
            {
                if (this.myset.t1.GetNodeCount(true) <= 0)
                {
                    this.tmpdgv = new DataGridView();
                }
                else
                {
                    string ss = SimpleReportModule.ConvertTreeViewToString(this.myset.t1, false);
                    this.tmptreeview = new TreeView();
                    SimpleReportModule.ConvertStringToTreeView(ss, this.tmptreeview);
                    for (int i = this.tmptreeview.Nodes.Count - 1; i >= 0; i += -1)
                    {
                        this.InitTreeView(this.tmptreeview.Nodes[i]);
                    }
                    this.tmpdgv = new DataGridView();
                    int num = 0;
                    int num2 = this.tmptreeview.Nodes.Count - 1;
                    for (int j = num; j <= num2; j++)
                    {
                        this.InitDGV(this.tmptreeview.Nodes[j], this.tmpdgv);
                    }
                    this.tmpdgv.GridColor = this.myset.linecolor.ForeColor;
                    this.tmpdgv.RowCount = this.w_dgv.RowCount;
                }
            }
        }

        // Token: 0x06000EC4 RID: 3780 RVA: 0x000771F4 File Offset: 0x000753F4
        private void ZoomDGVtoWidth(DataGridView dgv, float thewidth)
        {
            checked
            {
                if (dgv != null && dgv.ColumnCount > 0)
                {
                    float num = 0f;
                    int num2 = 0;
                    int num3 = dgv.ColumnCount - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        unchecked
                        {
                            if (dgv.Columns[i].Visible)
                            {
                                num += this.myp.ConvFromDisplay((float)dgv.Columns[i].Width, true);
                            }
                        }
                    }
                    if (num > 0f)
                    {
                        float num4 = thewidth / num;
                        int num5 = 0;
                        int num6 = dgv.ColumnCount - 1;
                        for (int j = num5; j <= num6; j++)
                        {
                            if (dgv.Columns[j].Visible)
                            {
                                dgv.Columns[j].Width = (int)Math.Round((double)(unchecked((float)dgv.Columns[j].Width * num4)));
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x06000EC5 RID: 3781 RVA: 0x000772C8 File Offset: 0x000754C8
        private void InitDGV(TreeNode node, DataGridView dgv)
        {
            checked
            {
                if (node.Nodes.Count <= 0)
                {
                    ParaseTag paraseTag = new ParaseTag();
                    paraseTag.RestoreTags(Convert.ToString(node.Tag));
                    dgv.ColumnCount++;
                    dgv.Columns[dgv.ColumnCount - 1].Width = (int)Math.Round((double)this.myp.ConvToDisplay(Convert.ToSingle(decimal.Multiply(paraseTag.ColWidth, 10m)), true));
                    this.mycols = (ParaseTag[])Utils.CopyArray((Array)this.mycols, new ParaseTag[dgv.ColumnCount - 1 + 1]);
                    this.mycols[dgv.ColumnCount - 1] = new ParaseTag();
                    this.mycols[dgv.ColumnCount - 1].RestoreTags(Convert.ToString(node.Tag));
                }
                else
                {
                    int num = 0;
                    int num2 = node.Nodes.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.InitDGV(node.Nodes[i], dgv);
                    }
                }
            }
        }

        // Token: 0x06000EC6 RID: 3782 RVA: 0x000773E0 File Offset: 0x000755E0
        private void InitTreeView(TreeNode node)
        {
            ParaseTag paraseTag = new ParaseTag();
            paraseTag.RestoreTags(Convert.ToString(node.Tag));
            checked
            {
                if (decimal.Compare(paraseTag.ColWidth, 0m) == 0 | !paraseTag.IsPrint)
                {
                    node.Remove();
                }
                else if (node.Nodes.Count > 0)
                {
                    node.NodeFont = paraseTag.Fieldfont;
                    node.ForeColor = paraseTag.Fieldforecolor;
                    node.BackColor = paraseTag.Fieldbackcolor;
                    node.Text = Convert.ToString(this.MyReplace(node.Text, this.w_dgv, 0));
                    for (int i = node.Nodes.Count - 1; i >= 0; i += -1)
                    {
                        this.InitTreeView(node.Nodes[i]);
                    }
                }
                else
                {
                    node.NodeFont = paraseTag.Fieldfont;
                    node.ForeColor = paraseTag.Fieldforecolor;
                    node.BackColor = paraseTag.Fieldbackcolor;
                    node.Text = Convert.ToString(this.MyReplace(node.Text, this.w_dgv, 0));
                }
            }
        }

        // Token: 0x06000EC7 RID: 3783 RVA: 0x000774EC File Offset: 0x000756EC
        private void fa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.W_IsNeedTry)
            {
                if (String.Compare(this.fa.Text, "", false) != 0 && this.myschemes != null)
                {
                    if (String.Compare(this.myp.DocumentName, "", false) == 0)
                    {
                        this.myp.DocumentName = this.fa.Text;
                    }
                    string schemeRawText = this.myschemes.GetSchemeRawText(this.fa.Text);
                    SimpleReportScheme simpleReportScheme = new SimpleReportScheme(schemeRawText);
                    if (simpleReportScheme.EnableChange & this.W_canedit)
                    {
                        this.myedit.Enabled = true;
                        this.ToolStripButton3.Enabled = true;
                    }
                    else
                    {
                        this.myedit.Enabled = false;
                        this.ToolStripButton3.Enabled = false;
                    }
                    if (simpleReportScheme.EnableDel & this.W_canddel)
                    {
                        this.mydel.Enabled = true;
                    }
                    else
                    {
                        this.mydel.Enabled = false;
                    }
                    if (String.Compare(schemeRawText, "", false) != 0)
                    {
                        this.myset.RestoreFa(simpleReportScheme.SchemeContent);
                        if (this.IsRedrawCell & String.Compare(this.fa.Text, this.myschemes.DefaultScheme, false) == 0)
                        {
                            this.myset.MyLoadDGVDefaultSettings(this.w_dgv);
                        }
                        this.MyRefResh();
                    }
                }
                this.ShowDefaultFa();
            }
        }

        // Token: 0x06000EC8 RID: 3784 RVA: 0x0007764C File Offset: 0x0007584C
        private void myedit_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.fa.Text, "", false) != 0 && this.myschemes != null && this.myschemes.IsExists(this.fa.Text))
            {
                string schemeRawText = this.myschemes.GetSchemeRawText(this.fa.Text);
                if (String.Compare(schemeRawText, "", false) != 0)
                {
                    SimpleReportScheme simpleReportScheme = new SimpleReportScheme(schemeRawText);
                    this.myset.Text = "修改打印方案【" + this.fa.Text + "】";
                    this.myset.myprintername = this.myprintername;
                    this.myset.RestoreFa(simpleReportScheme.SchemeContent);
                    if (this.IsRedrawCell & String.Compare(this.fa.Text, this.myschemes.DefaultScheme, false) == 0)
                    {
                        this.myset.MyLoadDGVDefaultSettings(this.w_dgv);
                        this.myset.GroupBox6.Enabled = false;
                        this.myset.GroupBox8.Enabled = false;
                        this.myset.GroupBoxformat.Enabled = false;
                        this.myset.GroupBoxxx2.Enabled = false;
                        this.myset.GroupBoxxx3.Enabled = false;
                        this.myset.isprint.Visible = false;
                    }
                    else
                    {
                        this.myset.GroupBox6.Enabled = true;
                        this.myset.GroupBox8.Enabled = true;
                        this.myset.GroupBoxformat.Enabled = true;
                        this.myset.GroupBoxxx2.Enabled = true;
                        this.myset.GroupBoxxx3.Enabled = true;
                        this.myset.isprint.Visible = true;
                    }
                    if (this.myset.ShowDialog(this) == DialogResult.OK)
                    {
                        this.IsChanged = true;
                        simpleReportScheme.SchemeContent = this.myset.SaveFa();
                        this.myschemes.ChangeScheme(this.fa.Text, simpleReportScheme.GetRawSchemeText());
                        this.MyRefResh();
                    }
                }
            }
        }

        // Token: 0x06000EC9 RID: 3785 RVA: 0x00077868 File Offset: 0x00075A68
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.fa.Text, "", false) != 0 && this.myschemes != null && this.myschemes.IsExists(this.fa.Text))
            {
                this.myschemes.DefaultScheme = this.fa.Text;
                this.IsChanged = true;
                this.ShowDefaultFa();
                Interaction.MsgBox("默认方案设置成功", MsgBoxStyle.OkOnly, "提示信息");
            }
        }

        // Token: 0x06000ECA RID: 3786 RVA: 0x00005DC1 File Offset: 0x00003FC1
        private void ShowDefaultFa()
        {
            this.l_default.Text = "默认打印方案：【" + this.myschemes.DefaultScheme + "】 ";
        }

        // Token: 0x06000ECB RID: 3787 RVA: 0x000778E4 File Offset: 0x00075AE4
        private void mydel_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.fa.Text, "", false) != 0 && this.myschemes != null && this.myschemes.IsExists(this.fa.Text))
            {
                if (String.Compare(this.myschemes.DefaultScheme, this.fa.Text, false) == 0)
                {
                    Interaction.MsgBox("不能删除默认打印方案，请先将其他打印方案设置为默认打印方案，才能删除此打印方案", MsgBoxStyle.Exclamation, "提示信息");
                }
                else if (this.myschemes.GetSchemeCount() <= 1)
                {
                    Interaction.MsgBox("不能删除，这是当前唯一的一个打印方案", MsgBoxStyle.OkOnly, "提示信息");
                }
                else if (Interaction.MsgBox("确定要删除打印方案【" + this.fa.Text + "】吗？", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "提示信息") != MsgBoxResult.No)
                {
                    this.myschemes.DeleteScheme(this.fa.Text);
                    this.IsChanged = true;
                    Interaction.MsgBox("打印方案【" + this.fa.Text + "】已成功删除，请选择其他打印方案进行打印预览。", MsgBoxStyle.OkOnly, "提示信息");
                    this.fa.Items.Remove(this.fa.Text);
                }
            }
        }

        // Token: 0x06000ECC RID: 3788 RVA: 0x00077A18 File Offset: 0x00075C18
        private void mysaveas_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.fa.Text, "", false) != 0)
            {
                if (this.myschemes != null && this.myschemes.IsExists(this.fa.Text))
                {
                    string faName = this.GetFaName("另存打印方案", "");
                    if (String.Compare(faName, "", false) != 0)
                    {
                        if (this.myschemes != null)
                        {
                            SimpleReportScheme simpleReportScheme = new SimpleReportScheme(this.myschemes.GetSchemeRawText(this.fa.Text));
                            simpleReportScheme.SchemeName = faName;
                            simpleReportScheme.EnableChange = true;
                            simpleReportScheme.EnableDel = true;
                            this.myschemes.AddScheme(simpleReportScheme);
                            this.fa.Items.Add(faName);
                            this.IsChanged = true;
                            Interaction.MsgBox("打印方案另存成功", MsgBoxStyle.OkOnly, "提示信息");
                            this.W_IsNeedTry = false;
                            this.fa.Text = faName;
                            this.W_IsNeedTry = true;
                        }
                    }
                }
            }
        }

        // Token: 0x06000ECD RID: 3789 RVA: 0x00077B1C File Offset: 0x00075D1C
        private string GetFaName(string titlename, string defaultvalue = "")
        {
            string text = Interaction.InputBox("请输入打印方案名称：", titlename, defaultvalue, -1, -1);
            string result;
            if (String.Compare(text, "", false) == 0)
            {
                result = "";
            }
            else if (this.myschemes != null)
            {
                if (this.myschemes.IsExists(text))
                {
                    Interaction.MsgBox("抱歉，名称【" + text + "】的打印方案已经存在，操作未成功", MsgBoxStyle.OkOnly, "提示信息");
                    result = "";
                }
                else
                {
                    result = text;
                }
            }
            else
            {
                result = "";
            }
            return result;
        }

        // Token: 0x06000ECE RID: 3790 RVA: 0x00077B9C File Offset: 0x00075D9C
        private void myadd_Click(object sender, EventArgs e)
        {
            string faName = this.GetFaName("新增打印方案", "");
            if (String.Compare(faName, "", false) != 0)
            {
                if (this.myschemes != null)
                {
                    SimpleReportScheme thescheme = new SimpleReportScheme(faName, this.w_dgv, this.myset.maintitle.Text);
                    this.myschemes.AddScheme(thescheme);
                    this.fa.Items.Add(faName);
                    this.IsChanged = true;
                    Interaction.MsgBox("打印方案新增成功", MsgBoxStyle.OkOnly, "提示信息");
                    this.fa.Text = faName;
                }
            }
        }

        // Token: 0x06000ECF RID: 3791 RVA: 0x00077C34 File Offset: 0x00075E34
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.fa.Text, "", false) != 0)
            {
                if (this.myschemes != null && this.myschemes.IsExists(this.fa.Text))
                {
                    string faName = this.GetFaName("重命名打印方案", this.fa.Text);
                    if (String.Compare(faName, "", false) != 0)
                    {
                        if (this.myschemes.RenameSchemeName(this.fa.Text, faName))
                        {
                            this.IsChanged = true;
                            this.W_IsNeedTry = false;
                            this.fa.Items[this.fa.SelectedIndex] = faName;
                            this.ShowDefaultFa();
                            this.W_IsNeedTry = true;
                            Interaction.MsgBox("打印方案重命名成功", MsgBoxStyle.OkOnly, "提示信息");
                        }
                    }
                }
            }
        }

        // Token: 0x06000ED0 RID: 3792 RVA: 0x00077D10 File Offset: 0x00075F10
        private void exportexcel_Click(object sender, EventArgs e)
        {
            string text = this.myset.maintitle.Text;
            int columnCount = this.tmpdgv.ColumnCount;
            int num = 0;
            checked
            {
                int num2 = columnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    this.tmpdgv.Columns[i].Visible = true;
                }
                text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
                this.UseWaitCursor = true;
                new ExportDataGridView
                {
                    FileName = "",
                    OpenFile = true,
                    Title = text,
                    TitleFont = (Font)this.myset.maintitle.Font.Clone()
                }.ExportDGV(this.tmpdgv, this.tmptreeview, ExportDataGridView.ExportDataGridViewType.Excel);
                this.UseWaitCursor = false;
            }
        }

        // Token: 0x06000ED1 RID: 3793 RVA: 0x00077DD8 File Offset: 0x00075FD8
        private void exportrtf_Click(object sender, EventArgs e)
        {
            string text = this.myset.maintitle.Text;
            int columnCount = this.tmpdgv.ColumnCount;
            int num = 0;
            checked
            {
                int num2 = columnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    this.tmpdgv.Columns[i].Visible = true;
                }
                text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
                this.UseWaitCursor = true;
                new ExportDataGridView
                {
                    FileName = "",
                    OpenFile = true,
                    Title = text,
                    TitleFont = (Font)this.myset.maintitle.Font.Clone()
                }.ExportDGV(this.tmpdgv, this.tmptreeview, ExportDataGridView.ExportDataGridViewType.RTF);
                this.UseWaitCursor = false;
            }
        }

        // Token: 0x06000ED2 RID: 3794 RVA: 0x00077EA0 File Offset: 0x000760A0
        private void exporthtml_Click(object sender, EventArgs e)
        {
            string text = this.myset.maintitle.Text;
            int columnCount = this.tmpdgv.ColumnCount;
            int num = 0;
            checked
            {
                int num2 = columnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    this.tmpdgv.Columns[i].Visible = true;
                }
                text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
                this.UseWaitCursor = true;
                new ExportDataGridView
                {
                    FileName = "",
                    OpenFile = true,
                    Title = text,
                    TitleFont = (Font)this.myset.maintitle.Font.Clone()
                }.ExportDGV(this.tmpdgv, this.tmptreeview, ExportDataGridView.ExportDataGridViewType.HTML);
                this.UseWaitCursor = false;
            }
        }

        // Token: 0x06000ED3 RID: 3795 RVA: 0x00077F68 File Offset: 0x00076168
        private void exportpdf_Click(object sender, EventArgs e)
        {
            string text = this.myset.maintitle.Text;
            int columnCount = this.tmpdgv.ColumnCount;
            int num = 0;
            checked
            {
                int num2 = columnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    this.tmpdgv.Columns[i].Visible = true;
                }
                text = Convert.ToString(this.MyReplace(text, this.w_dgv, 0));
                this.UseWaitCursor = true;
                ExportDataGridView exportDGV = new ExportDataGridView();
                exportDGV.FileName = "";
                exportDGV.OpenFile = true;
                exportDGV.Title = text;
                exportDGV.TitleFont = (Font)this.myset.maintitle.Font.Clone();
                exportDGV.PaperHeight = Convert.ToSingle(this.myset.myh.Value);
                exportDGV.PaperWidth = Convert.ToSingle(this.myset.myw.Value);
                exportDGV.PaperMargin = new Margins(Convert.ToInt32(this.myset.pagemarginl.Text), Convert.ToInt32(this.myset.pagemarginr.Text), Convert.ToInt32(this.myset.pagemargint.Text), Convert.ToInt32(this.myset.pagemarginb.Text));
                if (String.Compare(this.myset.fx.Text, "纵向", false) == 0)
                {
                    exportDGV.PaperLandScape = false;
                }
                else
                {
                    exportDGV.PaperLandScape = true;
                }
                exportDGV.ExportDGV(this.tmpdgv, this.tmptreeview, ExportDataGridView.ExportDataGridViewType.PDF);
                this.UseWaitCursor = false;
            }
        }

        // Token: 0x04000744 RID: 1860
        [AccessedThroughProperty("myp")]
        private VB2008Print _myp;

        // Token: 0x04000745 RID: 1861
        [AccessedThroughProperty("ToolStrip1")]
        private ToolStrip _ToolStrip1;

        // Token: 0x04000746 RID: 1862
        [AccessedThroughProperty("ToolStripButton1")]
        private ToolStripLabel _ToolStripButton1;

        // Token: 0x04000747 RID: 1863
        [AccessedThroughProperty("fa")]
        private ToolStripComboBox _fa;

        // Token: 0x04000748 RID: 1864
        [AccessedThroughProperty("myedit")]
        private ToolStripButton _myedit;

        // Token: 0x04000749 RID: 1865
        [AccessedThroughProperty("mysaveas")]
        private ToolStripButton _mysaveas;

        // Token: 0x0400074A RID: 1866
        [AccessedThroughProperty("myadd")]
        private ToolStripButton _myadd;

        // Token: 0x0400074B RID: 1867
        [AccessedThroughProperty("mydel")]
        private ToolStripButton _mydel;

        // Token: 0x0400074C RID: 1868
        [AccessedThroughProperty("ToolStripButton2")]
        private ToolStripButton _ToolStripButton2;

        // Token: 0x0400074D RID: 1869
        [AccessedThroughProperty("ToolStripButton3")]
        private ToolStripButton _ToolStripButton3;

        // Token: 0x0400074E RID: 1870
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;

        // Token: 0x0400074F RID: 1871
        [AccessedThroughProperty("l_default")]
        private ToolStripLabel _l_default;

        // Token: 0x04000750 RID: 1872
        [AccessedThroughProperty("ToolStripButton4")]
        private ToolStripDropDownButton _ToolStripButton4;

        // Token: 0x04000751 RID: 1873
        [AccessedThroughProperty("exportexcel")]
        private ToolStripMenuItem _exportexcel;

        // Token: 0x04000752 RID: 1874
        [AccessedThroughProperty("exportrtf")]
        private ToolStripMenuItem _exportrtf;

        // Token: 0x04000753 RID: 1875
        [AccessedThroughProperty("exporthtml")]
        private ToolStripMenuItem _exporthtml;

        // Token: 0x04000754 RID: 1876
        [AccessedThroughProperty("exportpdf")]
        private ToolStripMenuItem _exportpdf;

        // Token: 0x04000755 RID: 1877
        private SimpleReportSet myset;

        // Token: 0x04000757 RID: 1879
        public DataGridView w_dgv;

        // Token: 0x04000758 RID: 1880
        public string w_Settings;

        // Token: 0x04000759 RID: 1881
        public bool IsChanged;

        // Token: 0x0400075A RID: 1882
        public bool W_canedit;

        // Token: 0x0400075B RID: 1883
        public bool W_canadd;

        // Token: 0x0400075C RID: 1884
        public bool W_canddel;

        // Token: 0x0400075D RID: 1885
        public Hashtable W_variable;

        // Token: 0x0400075E RID: 1886
        private bool W_IsNeedTry;

        // Token: 0x0400075F RID: 1887
        private int w_pages;

        // Token: 0x04000760 RID: 1888
        private int w_currow;

        // Token: 0x04000761 RID: 1889
        private int w_curpagerow;

        // Token: 0x04000762 RID: 1890
        private DataGridView tmpdgv;

        // Token: 0x04000763 RID: 1891
        private TreeView tmptreeview;

        // Token: 0x04000764 RID: 1892
        private ParaseTag[] mycols;

        // Token: 0x04000765 RID: 1893
        private string mycellborder;

        // Token: 0x04000766 RID: 1894
        private float rowheight;

        // Token: 0x04000767 RID: 1895
        public string documentname;

        // Token: 0x04000768 RID: 1896
        public string myprintername;

        // Token: 0x04000769 RID: 1897
        public bool myisdrawmargin;

        // Token: 0x0400076A RID: 1898
        public bool IsRedrawCell;

        // Token: 0x0400076B RID: 1899
        public bool myenablesaveaspdf;

        // Token: 0x0400076C RID: 1900
        public bool myenablesaveasimage;

        // Token: 0x0400076D RID: 1901
        public bool myenableexportpdf;

        // Token: 0x0400076E RID: 1902
        public bool myenableexportexcel;

        // Token: 0x0400076F RID: 1903
        public bool myenableexportrtf;

        // Token: 0x04000770 RID: 1904
        public bool myenableexporthtml;

        // Token: 0x04000771 RID: 1905
        public bool myisshowcontextmenu;

        // Token: 0x04000772 RID: 1906
        public bool myistoolbarvisible;

        // Token: 0x04000773 RID: 1907
        public bool myispreviewtoolbarvisible;

        // Token: 0x04000774 RID: 1908
        public bool myenabledprint;

        // Token: 0x04000775 RID: 1909
        public bool myenablecgprint;

        // Token: 0x04000776 RID: 1910
        public short _printcopys;

        // Token: 0x04000777 RID: 1911
        public bool myisshowpagecontinues;

        // Token: 0x04000778 RID: 1912
        public bool myisshowprogress;

        // Token: 0x04000779 RID: 1913
        public string myschemenametoprint;

        // Token: 0x0400077A RID: 1914
        private bool ispreview;
    }
}
