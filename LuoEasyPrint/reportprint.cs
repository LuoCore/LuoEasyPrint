using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;


namespace LuoEasyPrint
{
    // Token: 0x02000017 RID: 23
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerGenerated]
    public partial class reportprint : Form
    {
        // Token: 0x06000533 RID: 1331 RVA: 0x0002F8EC File Offset: 0x0002DAEC
        public reportprint()
        {
            base.Disposed += this.reportprint_Disposed;
            base.Load += this.reportprint_Load;
            this.myvar = new Hashtable();
            this.cd = null;
            this.basex = 0f;
            this.hasgroup = false;
            this.groupcolumn = "";
            this.ColumnsNumber = 1;
            this.ColumnsNumberBT = 1;
            this.IsImmediatePrint = false;
            this.IsImmediatePrintShowPrinter = true;
            this.myisshowprogress = true;
            this.myisshowprintstatusdialog = true;
            this.myprintername = "";
            this.IsUseAPIprintDialog = true;
            this.isresetpagemargin = false;
            this.leftmargin = 20f;
            this.rightmargin = 20f;
            this.topmargin = 20f;
            this.bottommargin = 20f;
            this.myisdrawmargin = false;
            this.myenablesaveaspdf = true;
            this.myenablesaveasimage = true;
            this.myPYx = 0f;
            this.myPYy = 0f;
            this._printcopys = 1;
            this.w_pages = 0;
            this.addemptyrows = false;
            this.InitializeComponent();
        }

        // Token: 0x17000212 RID: 530
        // (get) Token: 0x06000536 RID: 1334 RVA: 0x0002FF64 File Offset: 0x0002E164
        // (set) Token: 0x06000537 RID: 1335 RVA: 0x0002FF7C File Offset: 0x0002E17C
        internal virtual VB2008Print p
        {
            get
            {
                return this._p;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                VB2008Print.ZDYButton2ClickEventHandler value2 = new VB2008Print.ZDYButton2ClickEventHandler(this.p_ZDYButton2Click);
                VB2008Print.EndPrintToPrinterEventHandler value3 = new VB2008Print.EndPrintToPrinterEventHandler(this.p_EndPrintToPrinter);
                VB2008Print.ZDYButtonClickEventHandler value4 = new VB2008Print.ZDYButtonClickEventHandler(this.p_ZDYButtonClick);
                VB2008Print.PrintDocumentEventHandler value5 = new VB2008Print.PrintDocumentEventHandler(this.p_PrintDocument);
                if (this._p != null)
                {
                    this._p.ZDYButton2Click -= value2;
                    this._p.EndPrintToPrinter -= value3;
                    this._p.ZDYButtonClick -= value4;
                    this._p.PrintDocument -= value5;
                }
                this._p = value;
                if (this._p != null)
                {
                    this._p.ZDYButton2Click += value2;
                    this._p.EndPrintToPrinter += value3;
                    this._p.ZDYButtonClick += value4;
                    this._p.PrintDocument += value5;
                }
            }
        }

        // Token: 0x06000538 RID: 1336 RVA: 0x00030038 File Offset: 0x0002E238
        private void reportprint_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.mypapersize = null;
                this.mypapermargin = null;
                this.w_startrow = null;
                this.w_endrow = null;
                this.w_groupstartrow = null;
                this.w_groupendrow = null;
            }
            catch (Exception ex)
            {
            }
            GC.Collect();
        }

        // Token: 0x06000539 RID: 1337 RVA: 0x00030094 File Offset: 0x0002E294
        private void p_PrintDocument()
        {
            float num = 0f;
            float num2 = this.p1 + this.p3 + this.p6 + this.p8;
            if (this.dgv1 != null && this.dgv1.RowCount <= 0)
            {
                this.dgv1 = null;
            }
            if (this.dgv1 == null)
            {
                this.w_pages = 1;
                this.hasgroup = false;
                this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                this.w_curpage = 1;
                num = 0f - this.cd.MyPage.TopMargin * 10f;
                this.PrintBand(this.cd.P1, num, -1, -1, -1, -1, -1);
                num = 0f;
                if (!this.IsTd && this.cd.P2.BackgroundImage != null)
                {
                    if (this.cd.myp2.BackPictureMode)
                    {
                        this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.mbwidth, this.p2);
                    }
                    else
                    {
                        this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Height, false));
                    }
                }
                this.PrintBand(this.cd.P2, num, -1, -1, -1, -1, -1);
                num += this.p2;
                if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                {
                    if (this.cd.myp3.BackPictureMode)
                    {
                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                    }
                    else
                    {
                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                    }
                }
                this.PrintBand(this.cd.P3, num, -1, -1, -1, -1, -1);
                num += this.p3;
                this.PrintBand(this.cd.P4, num, -1, -1, -1, -1, -1);
                num += this.p4;
                this.PrintBand(this.cd.P6, num, -1, -1, -1, -1, -1);
                num += this.p6;
                this.PrintBand(this.cd.p7, num, -1, -1, -1, -1, -1);
                num = (this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f;
                this.PrintBand(this.cd.P8, num, -1, -1, -1, -1, -1);
            }
            else
            {
                this.w_pages = 0;
                int num3 = 0;
                float num4 = num2 + this.p2;
                checked
                {
                    if (!this.hasgroup)
                    {
                        if (this.rowsperpage > 0)
                        {
                            if (this.dgv1.RowCount <= this.rowsperpage)
                            {
                                num4 = (float)(unchecked((double)num4 + Math.Ceiling((double)this.dgv1.RowCount / (double)this.ColumnsNumber) * (double)this.p4));
                            }
                            else
                            {
                                int num5 = (int)Math.Round(Math.Ceiling((double)this.dgv1.RowCount / (double)this.rowsperpage));
                                num3 = 0;
                                int num6 = 0;
                                int num7 = num5 - 2;
                                for (int i = num6; i <= num7; i++)
                                {
                                    this.w_pages = i;
                                    this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                    this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                    this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                    this.w_startrow[this.w_pages] = num3;
                                    this.w_endrow[this.w_pages] = num3 + this.rowsperpage - 1;
                                    num3 += this.rowsperpage;
                                }
                                this.w_pages++;
                                num4 = unchecked(num2 + (float)(Math.Ceiling((double)(checked(this.dgv1.RowCount - num3)) / (double)this.ColumnsNumber) * (double)this.p4));
                            }
                        }
                        else
                        {
                            int num8 = 0;
                            int num9 = this.dgv1.RowCount - 1;
                            int columnsNumber = this.ColumnsNumber;
                            int num10 = num8;
                            while ((columnsNumber >> 31 ^ num10) <= (columnsNumber >> 31 ^ num9))
                            {
                                unchecked
                                {
                                    num4 += this.p4;
                                    bool flag = this.rowsperpage != 0 && (num10 > 0 & num10 % this.rowsperpage == 0);
                                    if (num4 > this.cd.MyPage.GetPaperHeight() * 10f || flag)
                                    {
                                        checked
                                        {
                                            this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                            this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                            this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                            this.w_startrow[this.w_pages] = num3;
                                            this.w_endrow[this.w_pages] = num10 - 1;
                                            this.w_pages++;
                                            num3 = num10;
                                            num4 = num2;
                                        }
                                        num4 += this.p4;
                                    }
                                }
                                num10 += columnsNumber;
                            }
                        }
                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                        this.w_startrow[this.w_pages] = num3;
                        this.w_endrow[this.w_pages] = this.dgv1.RowCount - 1;
                        this.w_pages++;
                        int num11 = this.w_pages;
                        if (unchecked(num4 + this.p7 > this.cd.MyPage.GetPaperHeight() * 10f))
                        {
                            this.w_pages++;
                        }
                        float num12 = this.basex;
                        int num13 = 0;
                        int num14 = num11 - 1;
                        for (int j = num13; j <= num14; j++)
                        {
                            if (this.p.CancelDocument)
                            {
                                return;
                            }
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            this.w_curpage = j + 1;
                            float num15;
                            int num16;
                            unchecked
                            {
                                num = 0f - this.cd.MyPage.TopMargin * 10f;
                                this.basex = num12;
                                this.PrintBand(this.cd.P1, num, this.w_startrow[j], this.w_startrow[j], this.w_endrow[j], -1, -1);
                                num = 0f;
                                if (j == 0)
                                {
                                    if (!this.IsTd && this.cd.P2.BackgroundImage != null)
                                    {
                                        if (this.cd.myp2.BackPictureMode)
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.mbwidth, this.p2);
                                        }
                                        else
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Height, false));
                                        }
                                    }
                                    this.PrintBand(this.cd.P2, num, 0, 0, checked(this.dgv1.RowCount - 1), 0, this.dgv1.RowCount);
                                    num += this.p2;
                                }
                                if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                                {
                                    if (this.cd.myp3.BackPictureMode)
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                    }
                                    else
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                    }
                                }
                                if (this.ColumnsNumberBT > 1)
                                {
                                    this.basex = 0f;
                                }
                                num15 = this.basex;
                                num16 = 0;
                            }
                            int num17 = this.ColumnsNumberBT - 1;
                            for (int k = num16; k <= num17; k++)
                            {
                                this.basex = unchecked(num15 + this.p.PaperPrintWidth / (float)this.ColumnsNumberBT * (float)k);
                                this.PrintBand(this.cd.P3, num, this.w_startrow[j], this.w_startrow[j], this.w_endrow[j], -1, -1);
                            }
                            this.basex = num12;
                            int num19;
                            int columnsNumber2;
                            int num20;
                            unchecked
                            {
                                num += this.p3;
                                if (this.ColumnsNumber > 1)
                                {
                                    this.basex = 0f;
                                }
                                num15 = this.basex;
                                int num18 = this.w_startrow[j];
                                num19 = this.w_endrow[j];
                                columnsNumber2 = this.ColumnsNumber;
                                num20 = num18;
                            }
                            while ((columnsNumber2 >> 31 ^ num20) <= (columnsNumber2 >> 31 ^ num19))
                            {
                                if (this.p.CancelDocument)
                                {
                                    return;
                                }
                                int num21 = 0;
                                int num22 = this.ColumnsNumber - 1;
                                for (int l = num21; l <= num22; l++)
                                {
                                    this.basex = unchecked(num15 + this.p.PaperPrintWidth / (float)this.ColumnsNumber * (float)l);
                                    this.w_curpagerow = num20 - this.w_startrow[j] + 1 + l;
                                    if (num20 + l < this.dgv1.RowCount & num20 + l <= this.w_endrow[j])
                                    {
                                        this.PrintBand(this.cd.P4, num, num20 + l, this.w_startrow[j], this.w_endrow[j], -1, -1);
                                    }
                                    else if (this.addemptyrows & (this.rowsperpage == 0 | (this.rowsperpage > 0 & j == num11 - 1)))
                                    {
                                        if (this.rowsperpage == 0)
                                        {
                                            this.PrintBandEmpty(this.cd.P4, num, 0, this.w_startrow[j], this.w_endrow[j], -1, -1);
                                        }
                                        else if (num20 + l - this.w_startrow[j] < this.rowsperpage)
                                        {
                                            this.PrintBandEmpty(this.cd.P4, num, 0, this.w_startrow[j], this.w_endrow[j], -1, -1);
                                        }
                                    }
                                }
                                unchecked
                                {
                                    num += this.p4;
                                }
                                num20 += columnsNumber2;
                            }
                            this.basex = num12;
                            if ((this.rowsperpage > 0 & this.addemptyrows) && j == num11 - 1)
                            {
                                int num23 = (int)Math.Round(unchecked(Math.Ceiling((double)this.rowsperpage / (double)this.ColumnsNumber) - Math.Ceiling((double)(checked(this.w_endrow[j] - this.w_startrow[j] + 1)) / (double)this.ColumnsNumber)));
                                int num24 = 1;
                                int num25 = num23;
                                for (int m = num24; m <= num25; m++)
                                {
                                    int num26 = 0;
                                    int num27 = this.ColumnsNumber - 1;
                                    for (int n = num26; n <= num27; n++)
                                    {
                                        unchecked
                                        {
                                            this.basex = num15 + this.p.PaperPrintWidth / (float)this.ColumnsNumber * (float)n;
                                            if (Math.Ceiling((double)(checked(this.w_endrow[j] - this.w_startrow[j] + 1)) / (double)this.ColumnsNumber) * (double)this.ColumnsNumber + (double)(checked((m - 1) * this.ColumnsNumber)) + (double)n + 1.0 <= (double)this.rowsperpage)
                                            {
                                                this.PrintBandEmpty(this.cd.P4, num, 0, this.w_startrow[j], this.w_endrow[j], -1, -1);
                                            }
                                        }
                                    }
                                    unchecked
                                    {
                                        num += this.p4;
                                    }
                                }
                            }
                            this.basex = num12;
                            this.PrintBand(this.cd.P6, num, this.w_endrow[j], this.w_startrow[j], this.w_endrow[j], -1, -1);
                            unchecked
                            {
                                num += this.p6;
                                if (checked(j != num11 - 1 | (j == num11 - 1 & this.w_pages != num11)))
                                {
                                    num = (this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f;
                                    this.PrintBand(this.cd.P8, num, this.w_endrow[j], this.w_startrow[j], this.w_endrow[j], -1, -1);
                                }
                            }
                        }
                        if (this.w_pages == num11)
                        {
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.w_endrow[num11 - 1], this.w_startrow[num11 - 1], this.w_endrow[num11 - 1], 0, 0);
                        }
                        else
                        {
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            this.w_curpage++;
                            num = unchecked(0f - this.cd.MyPage.TopMargin * 10f);
                            this.PrintBand(this.cd.P1, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            num = 0f;
                            if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                            {
                                if (this.cd.myp3.BackPictureMode)
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                }
                                else
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                }
                            }
                            this.PrintBand(this.cd.P3, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            unchecked
                            {
                                num += this.p3;
                            }
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                        }
                    }
                    else if (!this.groupnewpage)
                    {
                        DataGridView dataGridView = new DataGridView();
                        int[] array = new int[1];
                        int[] array2 = new int[1];
                        int num28 = 0;
                        Module1.CopyDataGridView(this.dgv1, dataGridView);
                        dataGridView.RowCount++;
                        Module1.CreateFzHz(dataGridView, this.groupcolumn, this.groupcolumn, new Font("宋体", 12f), Color.Blue, Color.White, false, false, StringAlignment.Center);
                        dataGridView.RowCount--;
                        int num29 = -1;
                        int num30 = 0;
                        int num31 = dataGridView.RowCount - 1;
                        for (int num32 = num30; num32 <= num31; num32++)
                        {
                            unchecked
                            {
                                bool flag2;
                                if (String.Compare(Conversions.ToString(dataGridView.Rows[num32].Tag), "分组", false) == 0)
                                {
                                    num4 += this.p5;
                                    flag2 = true;
                                }
                                else
                                {
                                    num4 += this.p4;
                                    flag2 = false;
                                    checked
                                    {
                                        num29++;
                                    }
                                }
                                if (num4 > this.cd.MyPage.GetPaperHeight() * 10f)
                                {
                                    checked
                                    {
                                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                        array = (int[])Utils.CopyArray((Array)array, new int[this.w_pages + 1]);
                                        array2 = (int[])Utils.CopyArray((Array)array2, new int[this.w_pages + 1]);
                                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                        this.w_startrow[this.w_pages] = num3;
                                        if (!flag2)
                                        {
                                            this.w_endrow[this.w_pages] = num29 - 1;
                                        }
                                        else
                                        {
                                            this.w_endrow[this.w_pages] = num29;
                                        }
                                        array[this.w_pages] = num28;
                                        array2[this.w_pages] = num32 - 1;
                                        num28 = num32;
                                        this.w_pages++;
                                        if (!flag2)
                                        {
                                            num3 = num29;
                                        }
                                        else
                                        {
                                            num3 = num29 + 1;
                                        }
                                    }
                                    if (flag2)
                                    {
                                        num4 = num2 + this.p5;
                                    }
                                    else
                                    {
                                        num4 = num2 + this.p4;
                                    }
                                }
                            }
                        }
                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                        this.w_startrow[this.w_pages] = num3;
                        this.w_endrow[this.w_pages] = this.dgv1.RowCount - 1;
                        array = (int[])Utils.CopyArray((Array)array, new int[this.w_pages + 1]);
                        array2 = (int[])Utils.CopyArray((Array)array2, new int[this.w_pages + 1]);
                        array[this.w_pages] = num28;
                        array2[this.w_pages] = dataGridView.RowCount - 1;
                        this.w_pages++;
                        int num33 = this.w_pages;
                        if (unchecked(num4 + this.p7 > this.cd.MyPage.GetPaperHeight() * 10f))
                        {
                            this.w_pages++;
                        }
                        int num34 = 0;
                        int num35 = 0;
                        num3 = 0;
                        num29 = 0;
                        int num36 = 0;
                        int num37 = dataGridView.RowCount - 1;
                        for (int num38 = num36; num38 <= num37; num38++)
                        {
                            if (String.Compare(Conversions.ToString(dataGridView.Rows[num38].Tag), "分组", false) == 0)
                            {
                                this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[num35 + 1]);
                                this.w_groupendrow = (int[])Utils.CopyArray((Array)this.w_groupendrow, new int[num35 + 1]);
                                this.w_groupstartrow[num35] = num3;
                                this.w_groupendrow[num35] = num29 - 1;
                                num35++;
                                num3 = num29;
                            }
                            else
                            {
                                num29++;
                            }
                        }
                        int num39 = 0;
                        int num40 = num33 - 1;
                        for (int num41 = num39; num41 <= num40; num41++)
                        {
                            if (this.p.CancelDocument)
                            {
                                return;
                            }
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            this.w_curpage = num41 + 1;
                            int num42;
                            int num43;
                            int num44;
                            unchecked
                            {
                                num = 0f - this.cd.MyPage.TopMargin * 10f;
                                this.PrintBand(this.cd.P1, num, this.w_startrow[num41], this.w_startrow[num41], this.w_endrow[num41], -1, -1);
                                num = 0f;
                                if (num41 == 0)
                                {
                                    if (!this.IsTd && this.cd.P2.BackgroundImage != null)
                                    {
                                        if (this.cd.myp2.BackPictureMode)
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.mbwidth, this.p2);
                                        }
                                        else
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Height, false));
                                        }
                                    }
                                    this.PrintBand(this.cd.P2, num, 0, 0, checked(this.dgv1.RowCount - 1), 0, this.dgv1.RowCount);
                                    num += this.p2;
                                }
                                if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                                {
                                    if (this.cd.myp3.BackPictureMode)
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                    }
                                    else
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                    }
                                }
                                this.PrintBand(this.cd.P3, num, this.w_startrow[num41], this.w_startrow[num41], this.w_endrow[num41], -1, -1);
                                num += this.p3;
                                num42 = this.w_startrow[num41];
                                this.w_curpagerow = 1;
                                num43 = array[num41];
                                num44 = array2[num41];
                            }
                            for (int num45 = num43; num45 <= num44; num45++)
                            {
                                if (this.p.CancelDocument)
                                {
                                    return;
                                }
                                if (String.Compare(Conversions.ToString(dataGridView.Rows[num45].Tag), "分组", false) == 0)
                                {
                                    this.PrintBand(this.cd.p5, num, this.w_groupstartrow[num34], this.w_groupstartrow[num34], this.w_groupendrow[num34], this.w_groupstartrow[num34], this.w_groupendrow[num34]);
                                    unchecked
                                    {
                                        num += this.p5;
                                    }
                                    num34++;
                                }
                                else
                                {
                                    this.PrintBand(this.cd.P4, num, num42, this.w_startrow[num41], this.w_endrow[num41], -1, -1);
                                    num42++;
                                    unchecked
                                    {
                                        num += this.p4;
                                    }
                                    this.w_curpagerow++;
                                }
                            }
                            this.PrintBand(this.cd.P6, num, this.w_endrow[num41], this.w_startrow[num41], this.w_endrow[num41], -1, -1);
                            unchecked
                            {
                                num += this.p6;
                                if (checked(num41 != num33 - 1 | (num41 == num33 - 1 & this.w_pages != num33)))
                                {
                                    num = (this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f;
                                    this.PrintBand(this.cd.P8, num, this.w_endrow[num41], this.w_startrow[num41], this.w_endrow[num41], -1, -1);
                                }
                            }
                        }
                        if (this.w_pages == num33)
                        {
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.w_endrow[num33 - 1], this.w_startrow[num33 - 1], this.w_endrow[num33 - 1], 0, 0);
                        }
                        else
                        {
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            this.w_curpage++;
                            num = unchecked(0f - this.cd.MyPage.TopMargin * 10f);
                            this.PrintBand(this.cd.P1, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            num = 0f;
                            if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                            {
                                if (this.cd.myp3.BackPictureMode)
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                }
                                else
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                }
                            }
                            this.PrintBand(this.cd.P3, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            unchecked
                            {
                                num += this.p3;
                            }
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                        }
                    }
                    else if (this.groupnewpage)
                    {
                        DataGridView dataGridView2 = new DataGridView();
                        int[] array3 = new int[1];
                        int[] array4 = new int[1];
                        int num46 = 0;
                        Module1.CopyDataGridView(this.dgv1, dataGridView2);
                        dataGridView2.RowCount++;
                        Module1.CreateFzHz(dataGridView2, this.groupcolumn, this.groupcolumn, new Font("宋体", 12f), Color.Blue, Color.White, false, false, StringAlignment.Center);
                        dataGridView2.RowCount--;
                        int num47 = -1;
                        int num48 = 0;
                        int num49 = dataGridView2.RowCount - 1;
                        for (int num50 = num48; num50 <= num49; num50++)
                        {
                            unchecked
                            {
                                bool flag3;
                                if (String.Compare(Conversions.ToString(dataGridView2.Rows[num50].Tag), "分组", false) == 0)
                                {
                                    num4 += this.p5;
                                    flag3 = true;
                                }
                                else
                                {
                                    num4 += this.p4;
                                    flag3 = false;
                                    checked
                                    {
                                        num47++;
                                    }
                                }
                                if (num4 > this.cd.MyPage.GetPaperHeight() * 10f && flag3)
                                {
                                    checked
                                    {
                                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                        array3 = (int[])Utils.CopyArray((Array)array3, new int[this.w_pages + 1]);
                                        array4 = (int[])Utils.CopyArray((Array)array4, new int[this.w_pages + 1]);
                                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                        this.w_startrow[this.w_pages] = num3;
                                        this.w_endrow[this.w_pages] = num47;
                                        array3[this.w_pages] = num46;
                                        array4[this.w_pages] = num50 - 1;
                                        num46 = num50;
                                        this.w_pages++;
                                        num3 = num47 + 1;
                                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                        array3 = (int[])Utils.CopyArray((Array)array3, new int[this.w_pages + 1]);
                                        array4 = (int[])Utils.CopyArray((Array)array4, new int[this.w_pages + 1]);
                                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                        this.w_startrow[this.w_pages] = -1;
                                        this.w_endrow[this.w_pages] = -1;
                                        array3[this.w_pages] = num46;
                                        array4[this.w_pages] = num50;
                                        num46 = num50 + 1;
                                        this.w_pages++;
                                    }
                                    num4 = num2 + 0f;
                                }
                                else if (num4 > this.cd.MyPage.GetPaperHeight() * 10f)
                                {
                                    checked
                                    {
                                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                        array3 = (int[])Utils.CopyArray((Array)array3, new int[this.w_pages + 1]);
                                        array4 = (int[])Utils.CopyArray((Array)array4, new int[this.w_pages + 1]);
                                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                        this.w_startrow[this.w_pages] = num3;
                                        if (!flag3)
                                        {
                                            this.w_endrow[this.w_pages] = num47 - 1;
                                        }
                                        else
                                        {
                                            this.w_endrow[this.w_pages] = num47;
                                        }
                                        array3[this.w_pages] = num46;
                                        array4[this.w_pages] = num50 - 1;
                                        num46 = num50;
                                        this.w_pages++;
                                        if (!flag3)
                                        {
                                            num3 = num47;
                                        }
                                        else
                                        {
                                            num3 = num47 + 1;
                                        }
                                    }
                                    if (flag3)
                                    {
                                        num4 = num2 + this.p5;
                                    }
                                    else
                                    {
                                        num4 = num2 + this.p4;
                                    }
                                }
                                else if (flag3)
                                {
                                    checked
                                    {
                                        this.w_startrow = (int[])Utils.CopyArray((Array)this.w_startrow, new int[this.w_pages + 1]);
                                        this.w_endrow = (int[])Utils.CopyArray((Array)this.w_endrow, new int[this.w_pages + 1]);
                                        array3 = (int[])Utils.CopyArray((Array)array3, new int[this.w_pages + 1]);
                                        array4 = (int[])Utils.CopyArray((Array)array4, new int[this.w_pages + 1]);
                                        this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[this.w_pages + 1]);
                                        this.w_startrow[this.w_pages] = num3;
                                        this.w_endrow[this.w_pages] = num47;
                                        array3[this.w_pages] = num46;
                                        array4[this.w_pages] = num50;
                                        num46 = num50 + 1;
                                        this.w_pages++;
                                        num3 = num47 + 1;
                                    }
                                    num4 = num2 + 0f;
                                }
                            }
                        }
                        int num51 = this.w_pages;
                        if (unchecked(num4 + this.p7 > this.cd.MyPage.GetPaperHeight() * 10f))
                        {
                            this.w_pages++;
                        }
                        int num52 = 0;
                        int num53 = 0;
                        num3 = 0;
                        num47 = 0;
                        int num54 = 0;
                        int num55 = dataGridView2.RowCount - 1;
                        for (int num56 = num54; num56 <= num55; num56++)
                        {
                            if (String.Compare(Conversions.ToString(dataGridView2.Rows[num56].Tag), "分组", false) == 0)
                            {
                                this.w_groupstartrow = (int[])Utils.CopyArray((Array)this.w_groupstartrow, new int[num53 + 1]);
                                this.w_groupendrow = (int[])Utils.CopyArray((Array)this.w_groupendrow, new int[num53 + 1]);
                                this.w_groupstartrow[num53] = num3;
                                this.w_groupendrow[num53] = num47 - 1;
                                num53++;
                                num3 = num47;
                            }
                            else
                            {
                                num47++;
                            }
                        }
                        int num57 = 0;
                        int num58 = num51 - 1;
                        for (int num59 = num57; num59 <= num58; num59++)
                        {
                            if (this.p.CancelDocument)
                            {
                                return;
                            }
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            this.w_curpage = num59 + 1;
                            int num60;
                            int num61;
                            int num62;
                            unchecked
                            {
                                num = 0f - this.cd.MyPage.TopMargin * 10f;
                                this.PrintBand(this.cd.P1, num, this.w_startrow[num59], this.w_startrow[num59], this.w_endrow[num59], -1, -1);
                                num = 0f;
                                if (num59 == 0)
                                {
                                    if (!this.IsTd && this.cd.P2.BackgroundImage != null)
                                    {
                                        if (this.cd.myp2.BackPictureMode)
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.mbwidth, this.p2);
                                        }
                                        else
                                        {
                                            this.p.DrawImage(this.cd.P2.BackgroundImage, this.basex, num, this.mbwidth, this.p2, this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P2.BackgroundImage.Height, false));
                                        }
                                    }
                                    this.PrintBand(this.cd.P2, num, 0, 0, checked(this.dgv1.RowCount - 1), 0, this.dgv1.RowCount);
                                    num += this.p2;
                                }
                                if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                                {
                                    if (this.cd.myp3.BackPictureMode)
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                    }
                                    else
                                    {
                                        this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                    }
                                }
                                this.PrintBand(this.cd.P3, num, this.w_startrow[num59], this.w_startrow[num59], this.w_endrow[num59], -1, -1);
                                num += this.p3;
                                num60 = this.w_startrow[num59];
                                this.w_curpagerow = 1;
                                num61 = array3[num59];
                                num62 = array4[num59];
                            }
                            for (int num63 = num61; num63 <= num62; num63++)
                            {
                                if (this.p.CancelDocument)
                                {
                                    return;
                                }
                                if (String.Compare(Conversions.ToString(dataGridView2.Rows[num63].Tag), "分组", false) == 0)
                                {
                                    this.PrintBand(this.cd.p5, num, this.w_groupstartrow[num52], this.w_groupstartrow[num52], this.w_groupendrow[num52], this.w_groupstartrow[num52], this.w_groupendrow[num52]);
                                    unchecked
                                    {
                                        num += this.p5;
                                    }
                                    num52++;
                                }
                                else
                                {
                                    this.PrintBand(this.cd.P4, num, num60, this.w_startrow[num59], this.w_endrow[num59], -1, -1);
                                    num60++;
                                    unchecked
                                    {
                                        num += this.p4;
                                    }
                                    this.w_curpagerow++;
                                }
                            }
                            this.PrintBand(this.cd.P6, num, this.w_endrow[num59], this.w_startrow[num59], this.w_endrow[num59], -1, -1);
                            unchecked
                            {
                                num += this.p6;
                                if (num59 != checked(num51 - 1))
                                {
                                    num = (this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f;
                                    this.PrintBand(this.cd.P8, num, this.w_endrow[num59], this.w_startrow[num59], this.w_endrow[num59], -1, -1);
                                }
                            }
                        }
                        if (this.w_pages == num51)
                        {
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.w_endrow[num51 - 1], this.w_startrow[num51 - 1], this.w_endrow[num51 - 1], 0, 0);
                        }
                        else
                        {
                            this.p.NewPage(this.mypapersize, this.mypapermargin, this.cd.MyPage.PaperLandScape);
                            num = unchecked(0f - this.cd.MyPage.TopMargin * 10f);
                            this.PrintBand(this.cd.P1, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            num = 0f;
                            if (!this.IsTd && this.cd.P3.BackgroundImage != null)
                            {
                                if (this.cd.myp3.BackPictureMode)
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.mbwidth, this.p3);
                                }
                                else
                                {
                                    this.p.DrawImage(this.cd.P3.BackgroundImage, this.basex, num, this.mbwidth, this.p3, this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Width, true), this.p.ConvFromDisplay((float)this.cd.P3.BackgroundImage.Height, false));
                                }
                            }
                            this.PrintBand(this.cd.P3, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                            unchecked
                            {
                                num += this.p3;
                            }
                            this.PrintBand(this.cd.p7, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1);
                            num = unchecked((this.cd.MyPage.GetPaperHeight() - this.cd.MyPage.TopMargin - this.cd.MyPage.BottomMargin) * 10f);
                            this.PrintBand(this.cd.P8, num, this.dgv1.RowCount - 1, 0, this.dgv1.RowCount - 1, -1, -1);
                        }
                    }
                }
            }
        }

        // Token: 0x0600053A RID: 1338 RVA: 0x00032BE4 File Offset: 0x00030DE4
        public void MyStart()
        {
            if (String.Compare(this.myprintername, "", false) != 0)
            {
                this.p.SetCurrentPrinterName(this.myprintername);
            }
            this.p.ZDYButtonVisible = true;
            if (this.IsTd)
            {
                this.SetModel(true);
            }
            else
            {
                this.SetModel(false);
            }
            this.Text = this.Text + "【" + this.reportname + "】";
            if (this.isresetpagemargin)
            {
                if (this.leftmargin >= 0f)
                {
                    this.cd.MyPage.LeftMargin = this.leftmargin;
                }
                if (this.topmargin >= 0f)
                {
                    this.cd.MyPage.TopMargin = this.topmargin;
                }
                if (this.bottommargin >= 0f)
                {
                    this.cd.MyPage.BottomMargin = this.bottommargin;
                }
                if (this.rightmargin >= 0f)
                {
                    this.cd.MyPage.RightMargin = this.rightmargin;
                }
            }
            this.p.IsNeedCheckNewPage = false;
            this.p.IsShowProgess = this.myisshowprogress;
            this.p.IsShowPrintStatusDialog = this.myisshowprintstatusdialog;
            this.p.IsUseAPIprintDialog = this.IsUseAPIprintDialog;
            this.p.IsDrawmargin = this.myisdrawmargin;
            this.p.EnableSaveAsPDF = this.myenablesaveaspdf;
            this.p.EnableSaveAsImage = this.myenablesaveasimage;
            this.p.OffsetX = this.myPYx;
            this.p.OffsetY = this.myPYy;
            this.p.PrintCopys = this._printcopys;
            if (this.CanEditReport)
            {
                this.p.ZDYButtonVisible = true;
            }
            else
            {
                this.p.ZDYButtonVisible = false;
            }
            this.p1 = this.p.ConvFromDisplay((float)this.cd.P1.Height, false);
            this.p2 = this.p.ConvFromDisplay((float)this.cd.P2.Height, false);
            this.p3 = this.p.ConvFromDisplay((float)this.cd.P3.Height, false);
            this.p4 = this.p.ConvFromDisplay((float)this.cd.P4.Height, false);
            this.p5 = this.p.ConvFromDisplay((float)this.cd.p5.Height, false);
            this.p6 = this.p.ConvFromDisplay((float)this.cd.P6.Height, false);
            this.p7 = this.p.ConvFromDisplay((float)this.cd.p7.Height, false);
            this.p8 = this.p.ConvFromDisplay((float)this.cd.P8.Height, false);
            if (String.Compare(this.cd.myp5.GroupField, "", false) == 0 | !reportprint.HasColumname(this.cd.myp5.GroupField, this.dgv1))
            {
                this.groupcolumn = "";
                this.hasgroup = false;
                this.p5 = 0f;
            }
            else
            {
                this.groupcolumn = Strings.Trim(this.cd.myp5.GroupField);
                this.hasgroup = true;
                if (this.cd.myp5.GroupNewPage)
                {
                    this.groupnewpage = true;
                }
                else
                {
                    this.groupnewpage = false;
                }
            }
            this.addemptyrows = this.cd.myp4.AddEmptyRows;
            this.p.DocumentName = MyProject.Computer.FileSystem.GetName(this.reportname);
            if (String.Compare(this.p.DocumentName, "", false) == 0)
            {
                this.p.DocumentName = "报表打印";
            }
            this.mbwidth = this.p.ConvFromDisplay((float)this.cd.SplitContainer1.Width, true);
            if (this.cd.MyPage.Align == StringAlignment.Near)
            {
                this.basex = 0f;
            }
            else if (this.cd.MyPage.Align == StringAlignment.Center)
            {
                this.basex = ((this.cd.MyPage.GetPaperWidth() - this.cd.MyPage.LeftMargin - this.cd.MyPage.RightMargin) * 10f - this.p.ConvFromDisplay((float)this.cd.SplitContainer1.Width, true)) / 2f;
            }
            else
            {
                this.basex = (this.cd.MyPage.GetPaperWidth() - this.cd.MyPage.LeftMargin - this.cd.MyPage.RightMargin) * 10f - this.p.ConvFromDisplay((float)this.cd.SplitContainer1.Width, true);
            }
            checked
            {
                if (String.Compare(this.cd.MyPage.PaperName, "[自定义纸张]", false) == 0)
                {
                    this.mypapersize = new PaperSize("自定义", (int)Math.Round(unchecked((double)this.cd.MyPage.PaperWidth / 25.4 * 100.0)), (int)Math.Round(unchecked((double)this.cd.MyPage.PaperHeight / 25.4 * 100.0)));
                }
                else if (this.p.IsValidPaper(this.cd.MyPage.PaperName))
                {
                    this.mypapersize = new PaperSize(this.cd.MyPage.PaperName, 0, 0);
                }
                else
                {
                    this.mypapersize = new PaperSize(this.cd.MyPage.PaperName, (int)Math.Round(unchecked((double)this.cd.MyPage.PaperWidth / 25.4 * 100.0)), (int)Math.Round(unchecked((double)this.cd.MyPage.PaperHeight / 25.4 * 100.0)));
                }
                this.mypapermargin = new Margins((int)Math.Round((double)(unchecked(this.cd.MyPage.LeftMargin * 10f))), (int)Math.Round((double)(unchecked(this.cd.MyPage.RightMargin * 10f))), (int)Math.Round((double)(unchecked(this.cd.MyPage.TopMargin * 10f))), (int)Math.Round((double)(unchecked(this.cd.MyPage.BottomMargin * 10f))));
                this.rowsperpage = this.cd.myp4.FixedRows;
                this.ColumnsNumberBT = this.cd.myp3.Columns;
                if (this.ColumnsNumberBT <= 0)
                {
                    this.ColumnsNumberBT = 1;
                }
                this.ColumnsNumber = this.cd.myp4.Columns;
                if (this.ColumnsNumber <= 0)
                {
                    this.ColumnsNumber = 1;
                }
                if (this.IsImmediatePrint)
                {
                    this.p.IsImmediatePrintNotPreview = true;
                    this.p.IsImmediatePrintNotPreviewShowPrintDialog = this.IsImmediatePrintShowPrinter;
                    this.Visible = false;
                }
                else if (this.IsGetReoprtString)
                {
                    this.p.IsImmediatePrintNotPreview = false;
                    this.p.IsImmediatePrintNotPreviewShowPrintDialog = this.IsImmediatePrintShowPrinter;
                    this.Visible = false;
                }
                else
                {
                    this.Visible = true;
                    this.p.IsImmediatePrintNotPreview = false;
                    this.p.IsImmediatePrintNotPreviewShowPrintDialog = this.IsImmediatePrintShowPrinter;
                }
                this.p.InvalidatePreview();
            }
        }

        // Token: 0x0600053B RID: 1339 RVA: 0x00003834 File Offset: 0x00001A34
        private void reportprint_Load(object sender, EventArgs e)
        {
            this.p.IsNeedPrintPageHeaderAndFooter = false;
            this.MyStart();
        }

        // Token: 0x0600053C RID: 1340 RVA: 0x00033394 File Offset: 0x00031594
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

        // Token: 0x0600053D RID: 1341 RVA: 0x00033418 File Offset: 0x00031618
        private void PrintHline(U_HLine myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                this.p.DrawLine(this.basex + myline.X * 10f, basey + myline.Y * 10f, this.basex + myline.X * 10f + myline.EWidth * 10f, basey + myline.Y * 10f, myline.LineColor, myline.LineWidth * 10f);
            }
        }

        // Token: 0x0600053E RID: 1342 RVA: 0x000334A4 File Offset: 0x000316A4
        private void PrintVline(U_VLine myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                this.p.DrawLine(this.basex + myline.X * 10f, basey + myline.Y * 10f, this.basex + myline.X * 10f, basey + myline.Y * 10f + myline.EHeight * 10f, myline.LineColor, myline.LineWidth * 10f);
            }
        }

        // Token: 0x0600053F RID: 1343 RVA: 0x00033530 File Offset: 0x00031730
        private void PrintBias(U_Bias myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint) && (!this.IsTd || myline.IsPrint))
            {
                this.p.DrawLine(this.basex + myline.X * 10f, basey + myline.Y * 10f, this.basex + myline.X * 10f + myline.EWidth * 10f, basey + myline.Y * 10f + myline.EHeight * 10f, myline.LineColor, myline.LineWidth * 10f);
            }
        }

        // Token: 0x06000540 RID: 1344 RVA: 0x000335E0 File Offset: 0x000317E0
        private void PrintfBias(U_fBias myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint) && (!this.IsTd || myline.IsPrint))
            {
                this.p.DrawLine(this.basex + myline.X * 10f, basey + myline.Y * 10f + myline.EHeight * 10f, this.basex + myline.X * 10f + myline.EWidth * 10f, basey + myline.Y * 10f, myline.LineColor, myline.LineWidth * 10f);
            }
        }

        // Token: 0x06000541 RID: 1345 RVA: 0x00033690 File Offset: 0x00031890
        private void PrintRect(U_Rect myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float x = this.basex + myline.X * 10f;
                float y = basey + myline.Y * 10f;
                float mywidth = myline.EWidth * 10f;
                float myheight = myline.EHeight * 10f;
                if (myline.FilledColor == Color.Transparent)
                {
                    this.p.DrawRect(x, y, mywidth, myheight, myline.LineColor, myline.LineWidth * 10f);
                }
                else
                {
                    this.p.DrawFillRect(x, y, mywidth, myheight, myline.FilledColor);
                    this.p.DrawRect(x, y, mywidth, myheight, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000542 RID: 1346 RVA: 0x00033760 File Offset: 0x00031960
        private void PrintEllipse(U_Ellipse myline, float basey)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float x = this.basex + myline.X * 10f;
                float y = basey + myline.Y * 10f;
                float mywidth = myline.EWidth * 10f;
                float myheight = myline.EHeight * 10f;
                if (myline.FilledColor == Color.Transparent)
                {
                    this.p.DrawEllipse(x, y, mywidth, myheight, myline.LineColor, myline.LineWidth * 10f);
                }
                else
                {
                    this.p.DrawFillEllipse(x, y, mywidth, myheight, myline.FilledColor);
                    this.p.DrawEllipse(x, y, mywidth, myheight, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000543 RID: 1347 RVA: 0x00033830 File Offset: 0x00031A30
        private void PrintImage(U_Image myline, float basey, int currow = -1)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                Image image = null;
                if (String.Compare(myline.PictureVar, "", false) != 0)
                {
                    string text = myline.PictureVar;
                    text = Strings.Replace(text, "[", "", 1, -1, CompareMethod.Binary);
                    text = Strings.Replace(text, "]", "", 1, -1, CompareMethod.Binary);
                    if (reportprint.HasColumname(text, this.dgv1))
                    {
                        try
                        {
                            if (this.dgv1.Columns[text] is DataGridViewImageColumn)
                            {
                                image = (Image)((Image)this.dgv1.Rows[currow].Cells[text].FormattedValue).Clone();
                            }
                        }
                        catch (Exception ex)
                        {
                            image = null;
                        }
                    }
                    if (image == null)
                    {
                        text = myline.PictureVar;
                        text = this.MyReplace(text, null, 0);
                        image = Module1.ConvertStringToImage(text);
                        if (image == null && MyProject.Computer.FileSystem.FileExists(text))
                        {
                            try
                            {
                                image = Image.FromFile(text);
                            }
                            catch (Exception ex2)
                            {
                                image = null;
                            }
                        }
                    }
                }
                if (image == null)
                {
                    this.p.DrawCellImage(myline.Img, num, num2, num3, num4, Color.Black, "0000", myline.LayerOut, myline.Halign, myline.Valign);
                }
                else
                {
                    this.p.DrawCellImage(image, num, num2, num3, num4, Color.Black, "0000", myline.LayerOut, myline.Halign, myline.Valign);
                    image.Dispose();
                }
                if (myline.TopBorder)
                {
                    this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.LeftBorder)
                {
                    this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.RightBorder)
                {
                    this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.BottomBorder)
                {
                    this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000544 RID: 1348 RVA: 0x00033AE0 File Offset: 0x00031CE0
        private void PrintQC(DataGridView dgv, U_QC myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                string text = myline.TextValue;
                text = this.MyReplace(text, dgv, currow);
                this.p.Currentx = num;
                this.p.Currenty = num2;
                this.p.DrawBarZxing(text, (VB2008Print.BarcodeFormat)myline.BarType, num3, num4, myline.TextColor, myline.FilledColor, myline.Margins, myline.CharType);
                if (myline.TopBorder)
                {
                    this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.LeftBorder)
                {
                    this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.RightBorder)
                {
                    this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.BottomBorder)
                {
                    this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000545 RID: 1349 RVA: 0x00033C58 File Offset: 0x00031E58
        private void PrintQCForEmpty(DataGridView dgv, U_QC myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.TopBorder)
                {
                    this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.LeftBorder)
                {
                    this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.RightBorder)
                {
                    this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.BottomBorder)
                {
                    this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000546 RID: 1350 RVA: 0x00033D70 File Offset: 0x00031F70
        private void PrintBar(DataGridView dgv, U_Bar myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent)
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (myline.TopBorder)
                {
                    this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.LeftBorder)
                {
                    this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.RightBorder)
                {
                    this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.BottomBorder)
                {
                    this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                Margins cellMargin = this.p.CellMargin;
                this.p.CellMargin = checked(new Margins(myline.Margins.Left * 10, myline.Margins.Right * 10, myline.Margins.Top * 10, myline.Margins.Bottom * 10));
                this.p.Currentx = num + (float)(checked(myline.Margins.Left * 10));
                this.p.Currenty = num2 + (float)(checked(myline.Margins.Top * 10));
                num3 -= (float)(checked((myline.Margins.Left + myline.Margins.Right) * 10));
                num4 -= (float)(checked((myline.Margins.Top + myline.Margins.Bottom) * 10));
                string text = myline.TextValue;
                text = this.MyReplace(text, dgv, currow);
                this.p.DrawBar((VB2008Print.BarCode)myline.BarType, text, num3, num4, myline.TextFont, myline.TextColor, myline.IsPrintLabel);
                this.p.CellMargin = cellMargin;
            }
        }

        // Token: 0x06000547 RID: 1351 RVA: 0x00033FC8 File Offset: 0x000321C8
        private void PrintBarEmpty(DataGridView dgv, U_Bar myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent)
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (myline.TopBorder)
                {
                    this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.LeftBorder)
                {
                    this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.RightBorder)
                {
                    this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
                if (myline.BottomBorder)
                {
                    this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                }
            }
        }

        // Token: 0x06000548 RID: 1352 RVA: 0x00034108 File Offset: 0x00032308
        private void PrintText(DataGridView dgv, U_Text myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                Margins cellMargin = this.p.CellMargin;
                checked
                {
                    this.p.CellMargin = new Margins(myline.Margins.Left * 10, myline.Margins.Right * 10, myline.Margins.Top * 10, myline.Margins.Bottom * 10);
                    this.p.Currentx = num;
                    this.p.Currenty = num2;
                    string text = myline.TextValue;
                    text = this.MyReplace(text, dgv, currow);
                    if (myline.Cols > 1)
                    {
                        this.p.CellMargin = new Margins(0, 0, 0, 0);
                        this.p.DrawMultiCell(text, unchecked((long)myline.Cols), Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                        if (!this.IsTd)
                        {
                            float num5 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num6 = 1;
                                int num7 = myline.Cols - 1;
                                for (int i = num6; i <= num7; i++)
                                {
                                    unchecked
                                    {
                                        float num8 = num5 * (float)i;
                                        this.p.DrawLine(num, num2 + num8, num + num3, num2 + num8, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num9 = num3 / (float)myline.Cols;
                                int num10 = 1;
                                int num11 = myline.Cols - 1;
                                for (int j = num10; j <= num11; j++)
                                {
                                    unchecked
                                    {
                                        float num12 = num9 * (float)j;
                                        this.p.DrawLine(num + num12, num2, num + num12, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.p.DrawCell(text, num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign), myline.Mulline, true, false, myline.Direction, 6f, 0);
                    }
                    this.p.CellMargin = cellMargin;
                }
            }
        }

        // Token: 0x06000549 RID: 1353 RVA: 0x000344BC File Offset: 0x000326BC
        private void PrintTextEmpty(DataGridView dgv, U_Text myline, float basey, int currow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                string text = "";
                this.p.Currentx = num;
                this.p.Currenty = num2;
                if (myline.Cols > 1)
                {
                    this.p.CellMargin = new Margins(0, 0, 0, 0);
                    this.p.DrawMultiCell(text, (long)myline.Cols, Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                    checked
                    {
                        if (!this.IsTd)
                        {
                            float num5 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num6 = 1;
                                int num7 = myline.Cols - 1;
                                for (int i = num6; i <= num7; i++)
                                {
                                    unchecked
                                    {
                                        float num8 = num5 * (float)i;
                                        this.p.DrawLine(num, num2 + num8, num + num3, num2 + num8, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num9 = num3 / (float)myline.Cols;
                                int num10 = 1;
                                int num11 = myline.Cols - 1;
                                for (int j = num10; j <= num11; j++)
                                {
                                    unchecked
                                    {
                                        float num12 = num9 * (float)j;
                                        this.p.DrawLine(num + num12, num2, num + num12, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x0600054A RID: 1354 RVA: 0x000347B0 File Offset: 0x000329B0
        private void PrintExpress(DataGridView dgv, U_Express myline, float basey, int currow, int fromrow, int torow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                Margins cellMargin = this.p.CellMargin;
                checked
                {
                    this.p.CellMargin = new Margins(myline.Margins.Left * 10, myline.Margins.Right * 10, myline.Margins.Top * 10, myline.Margins.Bottom * 10);
                    this.p.Currentx = num;
                    this.p.Currenty = num2;
                    string text = myline.TextValue;
                    text = this.MyReplace(text, dgv, currow);
                    try
                    {
                        if (mbsjmodule.FieldsString != null && mbsjmodule.FieldsString.Length >= 0)
                        {
                            int num5 = mbsjmodule.FieldsString.Length;
                            int num6 = 0;
                            int num7 = num5 - 1;
                            int i = num6;
                            while (i <= num7)
                            {
                                string text2 = mbsjmodule.FieldsString[i];
                                if (Strings.InStr(text, "#" + text2 + "#", CompareMethod.Binary) <= 0 || !reportprint.HasColumname(mbsjmodule.FieldsString[i], dgv))
                                {
                                    goto IL_3F3;
                                }
                                string text3 = Conversions.ToString(reportprint.GetSum(dgv, text2, fromrow, torow));
                                if (text3 != null)
                                {
                                    try
                                    {
                                        text = Strings.Replace(text, "#" + text2 + "#", text3, 1, -1, CompareMethod.Binary);
                                        goto IL_3F3;
                                    }
                                    catch (Exception ex)
                                    {
                                        goto IL_3F3;
                                    }
                                    goto IL_2A9;
                                }
                                goto IL_3F3;
                            IL_30A:
                                if (Strings.InStr(text, "~" + text2 + "~", CompareMethod.Binary) > 0 && reportprint.HasColumname(mbsjmodule.FieldsString[i], dgv))
                                {
                                    string text4 = Conversions.ToString(reportprint.GetMax(dgv, text2, fromrow, torow));
                                    if (text4 != null)
                                    {
                                        try
                                        {
                                            text = Strings.Replace(text, "~" + text2 + "~", text4, 1, -1, CompareMethod.Binary);
                                        }
                                        catch (Exception ex2)
                                        {
                                        }
                                    }
                                }
                                if (Strings.InStr(text, "^" + text2 + "^", CompareMethod.Binary) > 0 && reportprint.HasColumname(mbsjmodule.FieldsString[i], dgv))
                                {
                                    string text5 = Conversions.ToString(reportprint.GetMin(dgv, text2, fromrow, torow));
                                    if (text5 != null)
                                    {
                                        try
                                        {
                                            text = Strings.Replace(text, "^" + text2 + "^", text5, 1, -1, CompareMethod.Binary);
                                        }
                                        catch (Exception ex3)
                                        {
                                        }
                                    }
                                }
                                i++;
                                continue;
                            IL_2A9:
                                if (reportprint.HasColumname(mbsjmodule.FieldsString[i], dgv))
                                {
                                    try
                                    {
                                        string replacement = Conversions.ToString(decimal.Divide(reportprint.GetSum(dgv, text2, fromrow, torow), new decimal(torow - fromrow + 1)));
                                        text = Strings.Replace(text, "$" + text2 + "$", replacement, 1, -1, CompareMethod.Binary);
                                    }
                                    catch (Exception ex4)
                                    {
                                    }
                                    goto IL_30A;
                                }
                                goto IL_30A;
                            IL_3F3:
                                if (Strings.InStr(text, "$" + text2 + "$", CompareMethod.Binary) > 0)
                                {
                                    goto IL_2A9;
                                }
                                goto IL_30A;
                            }
                        }
                    }
                    catch (Exception ex5)
                    {
                    }
                    if (String.Compare(Strings.Trim(text), "", false) != 0)
                    {
                        string text6 = SimpleComputer.ComputeSimple(text);
                        if (String.Compare(text6, "", false) == 0)
                        {
                            SourceComp sourceComp = new SourceComp();
                            try
                            {
                                string text7 = sourceComp.GetExpressionValue(text).ToString();
                                text = text7;
                                goto IL_47E;
                            }
                            catch (Exception ex6)
                            {
                                goto IL_47E;
                            }
                        }
                        text = text6;
                    }
                IL_47E:
                    string text8 = text;
                    if (String.Compare(text8, "", false) != 0 & String.Compare(myline.Format, "", false) != 0)
                    {
                        string columnType = myline.ColumnType;
                        if (String.Compare(columnType, "数字", false) == 0)
                        {
                            try
                            {
                                if (DataTypeConversion.IsNumeric(text8))
                                {
                                    text8 = Strings.Format(Conversions.ToDecimal(text8), myline.Format);
                                    text = text8;
                                }
                                goto IL_5A5;
                            }
                            catch (Exception ex7)
                            {
                                goto IL_5A5;
                            }
                        }
                        if (String.Compare(columnType, "日期时间", false) == 0)
                        {
                            try
                            {
                                if (Information.IsDate(text8))
                                {
                                    text8 = Strings.Format(Conversions.ToDate(text8), myline.Format);
                                    text = text8;
                                }
                                goto IL_5A5;
                            }
                            catch (Exception ex8)
                            {
                                goto IL_5A5;
                            }
                        }
                        try
                        {
                            if (DataTypeConversion.IsNumeric(text8))
                            {
                                text8 = Strings.Format(Conversions.ToDecimal(text8), myline.Format);
                                text = text8;
                            }
                            else if (Information.IsDate(text8))
                            {
                                text8 = Strings.Format(Conversions.ToDate(text8), myline.Format);
                                text = text8;
                            }
                        }
                        catch (Exception ex9)
                        {
                        }
                    }
                IL_5A5:
                    if (myline.Cols > 1)
                    {
                        this.p.CellMargin = new Margins(0, 0, 0, 0);
                        this.p.DrawMultiCell(text, unchecked((long)myline.Cols), Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                        if (!this.IsTd)
                        {
                            float num8 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num9 = 1;
                                int num10 = myline.Cols - 1;
                                for (int j = num9; j <= num10; j++)
                                {
                                    unchecked
                                    {
                                        float num11 = num8 * (float)j;
                                        this.p.DrawLine(num, num2 + num11, num + num3, num2 + num11, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num12 = num3 / (float)myline.Cols;
                                int num13 = 1;
                                int num14 = myline.Cols - 1;
                                for (int k = num13; k <= num14; k++)
                                {
                                    unchecked
                                    {
                                        float num15 = num12 * (float)k;
                                        this.p.DrawLine(num + num15, num2, num + num15, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.p.DrawCell(text, num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign), myline.Mulline, true, false, myline.Direction, 6f, 0);
                    }
                    this.p.CellMargin = cellMargin;
                }
            }
        }

        // Token: 0x0600054B RID: 1355 RVA: 0x00034FF8 File Offset: 0x000331F8
        private void PrintExpressEmpty(DataGridView dgv, U_Express myline, float basey, int currow, int fromrow, int torow)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                this.p.Currentx = num;
                this.p.Currenty = num2;
                string text = "";
                if (myline.Cols > 1)
                {
                    this.p.CellMargin = new Margins(0, 0, 0, 0);
                    this.p.DrawMultiCell(text, (long)myline.Cols, Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                    checked
                    {
                        if (!this.IsTd)
                        {
                            float num5 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num6 = 1;
                                int num7 = myline.Cols - 1;
                                for (int i = num6; i <= num7; i++)
                                {
                                    unchecked
                                    {
                                        float num8 = num5 * (float)i;
                                        this.p.DrawLine(num, num2 + num8, num + num3, num2 + num8, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num9 = num3 / (float)myline.Cols;
                                int num10 = 1;
                                int num11 = myline.Cols - 1;
                                for (int j = num10; j <= num11; j++)
                                {
                                    unchecked
                                    {
                                        float num12 = num9 * (float)j;
                                        this.p.DrawLine(num + num12, num2, num + num12, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x0600054C RID: 1356 RVA: 0x000352EC File Offset: 0x000334EC
        private string MyReplace(string mytxtvalue, DataGridView dgv, int currow)
        {
            checked
            {
                string result;
                if (mytxtvalue.IndexOf("[") < 0 | mytxtvalue.IndexOf("]") < 0)
                {
                    result = mytxtvalue;
                }
                else
                {
                    try
                    {
                        if (mbsjmodule.FieldsString != null && mbsjmodule.FieldsString.Length >= 0)
                        {
                            int num = mbsjmodule.FieldsString.Length;
                            int num2 = 0;
                            int num3 = num - 1;
                            for (int i = num2; i <= num3; i++)
                            {
                                string text = mbsjmodule.FieldsString[i];
                                if (Strings.InStr(mytxtvalue, "[" + text + "]", CompareMethod.Binary) > 0 && reportprint.HasColumname(mbsjmodule.FieldsString[i], dgv))
                                {
                                    string fieldValue = reportprint.GetFieldValue(dgv, text, currow);
                                    if (fieldValue != null)
                                    {
                                        try
                                        {
                                            mytxtvalue = Strings.Replace(mytxtvalue, "[" + text + "]", fieldValue, 1, -1, CompareMethod.Binary);
                                        }
                                        catch (Exception ex)
                                        {
                                        }
                                    }
                                }
                            }
                        }
                        if (mbsjmodule.FieldsString2 != null && mbsjmodule.FieldsString2.GetLength(0) >= 0)
                        {
                            int length = mbsjmodule.FieldsString2.GetLength(0);
                            int num4 = 0;
                            int num5 = length - 1;
                            for (int j = num4; j <= num5; j++)
                            {
                                try
                                {
                                    string text2 = mbsjmodule.FieldsString2[j, 0];
                                    string text3 = mbsjmodule.FieldsString2[j, 1];
                                    if (text3 != null)
                                    {
                                        text2 = "[" + text2 + "]";
                                        mytxtvalue = Strings.Replace(mytxtvalue, text2, text3, 1, -1, CompareMethod.Binary);
                                    }
                                }
                                catch (Exception ex2)
                                {
                                }
                            }
                        }
                        mytxtvalue = Strings.Replace(mytxtvalue, "[页码]", Conversions.ToString(this.w_curpage), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[总页数]", Conversions.ToString(this.w_pages), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期]", Strings.Format(DateAndTime.Today, "yyyy-M-d"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日期2]", Strings.Format(DateAndTime.Today, "yyyy年M月d日"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前年]", Conversions.ToString(DateAndTime.Today.Year), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前月]", Conversions.ToString(DateAndTime.Today.Month), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前日]", Conversions.ToString(DateAndTime.Today.Day), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[当前时间]", Strings.Format(DateAndTime.Now, "H:m:s"), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[行号]", Conversions.ToString(this.w_currow), 1, -1, CompareMethod.Binary);
                        mytxtvalue = Strings.Replace(mytxtvalue, "[页行号]", Conversions.ToString(this.w_curpagerow), 1, -1, CompareMethod.Binary);
                    }
                    catch (Exception ex3)
                    {
                    }
                    result = mytxtvalue;
                }
                return result;
            }
        }

        // Token: 0x0600054D RID: 1357 RVA: 0x000355EC File Offset: 0x000337EC
        private DataGridViewImageCellLayout GetDGVImageLayout(DataGridView dgv, string colname, int currow)
        {
            DataGridViewImageCellLayout result;
            if (dgv == null)
            {
                result = DataGridViewImageCellLayout.NotSet;
            }
            else if (currow >= dgv.RowCount | currow < 0)
            {
                result = DataGridViewImageCellLayout.NotSet;
            }
            else if (reportprint.HasColumname(colname, dgv))
            {
                if (dgv.Columns[colname] is DataGridViewImageColumn)
                {
                    try
                    {
                        return ((DataGridViewImageCell)dgv.Rows[currow].Cells[colname]).ImageLayout;
                    }
                    catch (Exception ex)
                    {
                        return DataGridViewImageCellLayout.NotSet;
                    }
                }
                result = DataGridViewImageCellLayout.NotSet;
            }
            else
            {
                result = DataGridViewImageCellLayout.NotSet;
            }
            return result;
        }

        // Token: 0x0600054E RID: 1358 RVA: 0x00035680 File Offset: 0x00033880
        private void PrintField(U_Field myline, float basey, object txt, int currow = 0)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                Margins cellMargin = this.p.CellMargin;
                this.p.CellMargin = checked(new Margins(myline.Margins.Left * 10, myline.Margins.Right * 10, myline.Margins.Top * 10, myline.Margins.Bottom * 10));
                this.p.Currentx = num;
                this.p.Currenty = num2;
                if (myline.Cols > 1)
                {
                    this.p.CellMargin = new Margins(0, 0, 0, 0);
                    if (txt is Image)
                    {
                        this.p.DrawCellImage((Image)txt, num, num2 + myline.LineWidth * 10f, num3, num4 - myline.LineWidth * 10f * 2f, Color.Transparent, "0000", this.GetDGVImageLayout(this.dgv1, myline.TextValue, currow), mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign));
                    }
                    else
                    {
                        this.p.DrawMultiCell(Conversions.ToString(txt), (long)myline.Cols, Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                    }
                    checked
                    {
                        if (!this.IsTd)
                        {
                            float num5 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num6 = 1;
                                int num7 = myline.Cols - 1;
                                for (int i = num6; i <= num7; i++)
                                {
                                    unchecked
                                    {
                                        float num8 = num5 * (float)i;
                                        this.p.DrawLine(num, num2 + num8, num + num3, num2 + num8, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num9 = num3 / (float)myline.Cols;
                                int num10 = 1;
                                int num11 = myline.Cols - 1;
                                for (int j = num10; j <= num11; j++)
                                {
                                    unchecked
                                    {
                                        float num12 = num9 * (float)j;
                                        this.p.DrawLine(num + num12, num2, num + num12, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (txt is Image)
                {
                    this.p.DrawCellImage((Image)txt, num, num2 + myline.LineWidth * 10f, num3, num4 - myline.LineWidth * 10f * 2f, Color.Transparent, "0000", this.GetDGVImageLayout(this.dgv1, myline.TextValue, currow), mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign));
                }
                else
                {
                    this.p.DrawCell(Conversions.ToString(txt), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign), myline.Mulline, true, false, myline.Direction, 6f, 0);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                this.p.CellMargin = cellMargin;
            }
        }

        // Token: 0x0600054F RID: 1359 RVA: 0x00035B08 File Offset: 0x00033D08
        private void PrintComp(U_Comput myline, float basey, string textvalue)
        {
            if (myline != null && (!this.IsTd || myline.IsPrint))
            {
                float num = this.basex + myline.X * 10f;
                float num2 = basey + myline.Y * 10f;
                float num3 = myline.EWidth * 10f;
                float num4 = myline.EHeight * 10f;
                if (myline.FilledColor != Color.Transparent & (!this.IsTd | (this.IsTd & myline.IsTdBackColor)))
                {
                    this.p.DrawFillRect(num, num2, num3, num4, myline.FilledColor);
                }
                if (!this.IsTd | (this.IsTd & myline.IsTdBorder))
                {
                    if (myline.TopBorder)
                    {
                        this.p.DrawLine(num, num2, num + num3, num2, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.LeftBorder)
                    {
                        this.p.DrawLine(num, num2, num, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.RightBorder)
                    {
                        this.p.DrawLine(num + num3, num2, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                    if (myline.BottomBorder)
                    {
                        this.p.DrawLine(num, num2 + num4, num + num3, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                    }
                }
                Margins cellMargin = this.p.CellMargin;
                checked
                {
                    this.p.CellMargin = new Margins(myline.Margins.Left * 10, myline.Margins.Right * 10, myline.Margins.Top * 10, myline.Margins.Bottom * 10);
                    this.p.Currentx = num;
                    this.p.Currenty = num2;
                    if (myline.Cols > 1)
                    {
                        this.p.CellMargin = new Margins(0, 0, 0, 0);
                        this.p.DrawMultiCell(textvalue, unchecked((long)myline.Cols), Conversions.ToBoolean(Interaction.IIf(myline.Direction, false, true)), Conversions.ToBoolean(Interaction.IIf(mbsjmodule.GetHalign(myline.TextAlign) == StringAlignment.Far, false, true)), num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, 6f, 0);
                        if (!this.IsTd)
                        {
                            float num5 = num4 / (float)myline.Cols;
                            if (myline.Direction)
                            {
                                int num6 = 1;
                                int num7 = myline.Cols - 1;
                                for (int i = num6; i <= num7; i++)
                                {
                                    unchecked
                                    {
                                        float num8 = num5 * (float)i;
                                        this.p.DrawLine(num, num2 + num8, num + num3, num2 + num8, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                            else
                            {
                                float num9 = num3 / (float)myline.Cols;
                                int num10 = 1;
                                int num11 = myline.Cols - 1;
                                for (int j = num10; j <= num11; j++)
                                {
                                    unchecked
                                    {
                                        float num12 = num9 * (float)j;
                                        this.p.DrawLine(num + num12, num2, num + num12, num2 + num4, myline.LineColor, myline.LineWidth * 10f);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.p.DrawCell(textvalue, num3, num4, myline.TextFont, myline.TextColor, "0000", Color.White, mbsjmodule.GetHalign(myline.TextAlign), mbsjmodule.GetValign(myline.TextAlign), myline.Mulline, true, false, myline.Direction, 6f, 0);
                    }
                    this.p.CellMargin = cellMargin;
                }
            }
        }

        // Token: 0x06000550 RID: 1360 RVA: 0x00035EAC File Offset: 0x000340AC
        private void PrintBand(PictureBox band, float basey, int currow, int pagefromrow, int pagetorow, int groupfromrow, int grouptorow)
        {
            checked
            {
                this.w_currow = currow + 1;
                if (band.Height != 0)
                {
                    int num = 0;
                    int maxControlCount = this.cd.CS.GetMaxControlCount();
                    for (int i = num; i <= maxControlCount; i++)
                    {
                        if (this.cd.CS.GetControl(i) != null && this.cd.CS.GetControl(i).Parent == band)
                        {
                            Control control = this.cd.CS.GetControl(i);
                            if (control is U_VLine)
                            {
                                this.PrintVline((U_VLine)control, basey);
                            }
                            else if (control is U_HLine)
                            {
                                this.PrintHline((U_HLine)control, basey);
                            }
                            else if (control is U_Rect)
                            {
                                this.PrintRect((U_Rect)control, basey);
                            }
                            else if (control is U_Ellipse)
                            {
                                this.PrintEllipse((U_Ellipse)control, basey);
                            }
                            else if (control is U_Bias)
                            {
                                this.PrintBias((U_Bias)control, basey);
                            }
                            else if (control is U_Image)
                            {
                                this.PrintImage((U_Image)control, basey, currow);
                            }
                            else if (control is U_Text)
                            {
                                this.PrintText(this.dgv1, (U_Text)control, basey, currow);
                            }
                            else if (control is U_Express)
                            {
                                this.PrintExpress(this.dgv1, (U_Express)control, basey, currow, pagefromrow, pagetorow);
                            }
                            else if (control is U_Field)
                            {
                                U_Field u_Field = (U_Field)control;
                                object objectValue = RuntimeHelpers.GetObjectValue(this.GetFieldValue(this.dgv1, u_Field, currow, false));
                                this.PrintField(u_Field, basey, RuntimeHelpers.GetObjectValue(objectValue), currow);
                                if (reportprint.HasColumname(u_Field.TextValue, this.dgv1) && this.dgv1.Columns[u_Field.TextValue] is DataGridViewButtonColumn)
                                {
                                    objectValue = RuntimeHelpers.GetObjectValue(this.GetFieldValue(this.dgv1, u_Field, currow, true));
                                    this.PrintField(u_Field, basey, RuntimeHelpers.GetObjectValue(objectValue), currow);
                                }
                            }
                            else if (control is U_Comput)
                            {
                                U_Comput u_Comput = (U_Comput)control;
                                string computeValue = this.GetComputeValue(this.dgv1, u_Comput, pagefromrow, pagetorow);
                                this.PrintComp(u_Comput, basey, computeValue);
                            }
                            else if (control is U_Bar)
                            {
                                this.PrintBar(this.dgv1, (U_Bar)control, basey, currow);
                            }
                            else if (control is U_fBias)
                            {
                                this.PrintfBias((U_fBias)control, basey);
                            }
                            else if (control is U_QC)
                            {
                                this.PrintQC(this.dgv1, (U_QC)control, basey, currow);
                            }
                            else
                            {
                                Module1.MyMsgBox("控件未找到");
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x06000551 RID: 1361 RVA: 0x00036140 File Offset: 0x00034340
        private void PrintBandEmpty(PictureBox band, float basey, int currow, int pagefromrow, int pagetorow, int groupfromrow, int grouptorow)
        {
            checked
            {
                if (band.Height != 0)
                {
                    int num = 0;
                    int maxControlCount = this.cd.CS.GetMaxControlCount();
                    for (int i = num; i <= maxControlCount; i++)
                    {
                        if (this.cd.CS.GetControl(i) != null && this.cd.CS.GetControl(i).Parent == band)
                        {
                            Control control = this.cd.CS.GetControl(i);
                            if (control is U_VLine)
                            {
                                this.PrintVline((U_VLine)control, basey);
                            }
                            else if (control is U_HLine)
                            {
                                this.PrintHline((U_HLine)control, basey);
                            }
                            else if (control is U_Rect)
                            {
                                this.PrintRect((U_Rect)control, basey);
                            }
                            else if (control is U_Ellipse)
                            {
                                this.PrintEllipse((U_Ellipse)control, basey);
                            }
                            else if (control is U_Bias)
                            {
                                this.PrintBias((U_Bias)control, basey);
                            }
                            else if (control is U_Image)
                            {
                                this.PrintImage((U_Image)control, basey, -1);
                            }
                            else if (control is U_Text)
                            {
                                this.PrintTextEmpty(this.dgv1, (U_Text)control, basey, currow);
                            }
                            else if (control is U_Express)
                            {
                                this.PrintExpressEmpty(this.dgv1, (U_Express)control, basey, currow, pagefromrow, pagetorow);
                            }
                            else if (control is U_Field)
                            {
                                U_Field u_Field = (U_Field)control;
                                object obj = "";
                                this.PrintField(u_Field, basey, RuntimeHelpers.GetObjectValue(obj), 0);
                                if (reportprint.HasColumname(u_Field.TextValue, this.dgv1) && this.dgv1.Columns[u_Field.TextValue] is DataGridViewButtonColumn)
                                {
                                    obj = "";
                                    this.PrintField(u_Field, basey, RuntimeHelpers.GetObjectValue(obj), 0);
                                }
                            }
                            else if (control is U_Comput)
                            {
                                U_Comput myline = (U_Comput)control;
                                string textvalue = "";
                                this.PrintComp(myline, basey, textvalue);
                            }
                            else if (control is U_Bar)
                            {
                                this.PrintBarEmpty(this.dgv1, (U_Bar)control, basey, currow);
                            }
                            else if (control is U_QC)
                            {
                                this.PrintQCForEmpty(this.dgv1, (U_QC)control, basey, currow);
                            }
                            else
                            {
                                Module1.MyMsgBox("控件未找到");
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x06000552 RID: 1362 RVA: 0x00036384 File Offset: 0x00034584
        private void p_ZDYButtonClick()
        {
            string text = MyProject.Computer.FileSystem.ReadAllText(this.reportname);
            EasyReport easyReport = new EasyReport();
            easyReport.SetReportFile(this.reportname);
            easyReport.SetReportDataSource(this.dgv1);
            easyReport.SetReportVar(this.myvar);
            easyReport.EditReport();
            if (!text.Equals(MyProject.Computer.FileSystem.ReadAllText(this.reportname)))
            {
                this.cd.OpenMb(this.dgv1, this.reportname, false);
                this.reportprint_Load(null, null);
            }
        }

        // Token: 0x06000553 RID: 1363 RVA: 0x00036418 File Offset: 0x00034618
        private static string GetFieldValue(DataGridView dgv, string cc, int currow)
        {
            string result;
            if (dgv == null)
            {
                result = null;
            }
            else if (currow >= dgv.RowCount)
            {
                result = null;
            }
            else if (reportprint.HasColumname(cc, dgv))
            {
                if (dgv.Columns[cc] is DataGridViewImageColumn)
                {
                    result = null;
                }
                else
                {
                    result = Conversions.ToString(dgv.Rows[currow].Cells[cc].Value);
                }
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000554 RID: 1364 RVA: 0x00036480 File Offset: 0x00034680
        private object GetFieldValue(DataGridView dgv, U_Field cc, int currow, bool isbuttoncolumngettext = false)
        {
            checked
            {
                object result;
                if (dgv == null)
                {
                    result = cc.BeforeText;
                }
                else if (currow >= dgv.RowCount)
                {
                    result = cc.BeforeText;
                }
                else if (currow < 0)
                {
                    result = cc.BeforeText;
                }
                else if (reportprint.HasColumname(cc.TextValue, dgv))
                {
                    object obj;
                    try
                    {
                        obj = RuntimeHelpers.GetObjectValue(dgv.Rows[currow].Cells[cc.TextValue].Value);
                        if (dgv.Columns[cc.TextValue] is DataGridViewImageColumn)
                        {
                            obj = RuntimeHelpers.GetObjectValue(dgv.Rows[currow].Cells[cc.TextValue].FormattedValue);
                            return obj;
                        }
                        if (dgv.Columns[cc.TextValue] is DataGridViewCheckBoxColumn)
                        {
                            Bitmap bitmap = null;
                            CheckBox checkBox = new CheckBox();
                            Control control = checkBox;
                            Size size = new Size(14, 14);
                            control.Size = size;
                            switch (Convert.ToInt32(dgv.Rows[currow].Cells[cc.TextValue].FormattedValue))
                            {
                                case 0:
                                    checkBox.Checked = false;
                                    break;
                                case 1:
                                    checkBox.Checked = true;
                                    break;
                                default:
                                    checkBox.CheckState = CheckState.Indeterminate;
                                    break;
                            }
                            if (bitmap != null)
                            {
                                try
                                {
                                    bitmap.Dispose();
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            try
                            {
                                bitmap = new Bitmap((int)Math.Round((double)this.p.ConvToDisplay(unchecked(cc.EWidth * 10f), true)), (int)Math.Round((double)this.p.ConvToDisplay(unchecked(cc.EHeight * 10f), false)));
                                Graphics graphics = Graphics.FromImage(bitmap);
                                Graphics graphics2 = graphics;
                                object obj2 = Interaction.IIf(cc.FilledColor == Color.Transparent, Color.White, cc.FilledColor);
                                Color color = new Color();
                                Brush brush = new SolidBrush((obj2 != null) ? ((Color)obj2) : color);
                                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                                graphics2.FillRectangle(brush, rectangle);
                                Control control2 = checkBox;
                                Bitmap bitmap2 = bitmap;
                                rectangle = new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height);
                                control2.DrawToBitmap(bitmap2, rectangle);
                            }
                            catch (Exception ex2)
                            {
                            }
                            return bitmap;
                        }
                        if (dgv.Columns[cc.TextValue] is DataGridViewButtonColumn & !isbuttoncolumngettext)
                        {
                            Bitmap bitmap3 = null;
                            Button button = new Button();
                            button.AutoSize = false;
                            Control control3 = button;
                            Size size = new Size((int)Math.Round((double)this.p.ConvToDisplay(unchecked(cc.EWidth * 10f), true)), (int)Math.Round((double)this.p.ConvToDisplay(unchecked(cc.EHeight * 10f), false)));
                            control3.Size = size;
                            button.Text = "";
                            if (cc.FilledColor == Color.Transparent)
                            {
                                button.BackColor = Color.White;
                            }
                            else
                            {
                                button.BackColor = cc.FilledColor;
                            }
                            if (bitmap3 != null)
                            {
                                try
                                {
                                    bitmap3.Dispose();
                                }
                                catch (Exception ex3)
                                {
                                }
                            }
                            try
                            {
                                bitmap3 = new Bitmap(button.Width, cc.Height);
                                Control control4 = button;
                                Bitmap bitmap4 = bitmap3;
                                Rectangle rectangle = new Rectangle(0, 0, button.Width, (int)Math.Round((double)this.p.ConvToDisplay(unchecked(cc.EHeight * 10f), false)));
                                control4.DrawToBitmap(bitmap4, rectangle);
                            }
                            catch (Exception ex4)
                            {
                            }
                            return bitmap3;
                        }
                        if (obj == null)
                        {
                            return cc.BeforeText;
                        }
                        if (String.Compare(Conversions.ToString(obj), "", false) != 0 & String.Compare(cc.Format, "", false) != 0)
                        {
                            string columnType = cc.ColumnType;
                            if (String.Compare(columnType, "数字", false) == 0)
                            {
                                try
                                {
                                    if (DataTypeConversion.IsNumeric(RuntimeHelpers.GetObjectValue(obj)))
                                    {
                                        obj = Strings.Format(Conversions.ToDecimal(obj), cc.Format);
                                    }
                                    goto IL_505;
                                }
                                catch (Exception ex5)
                                {
                                    goto IL_505;
                                }
                            }
                            if (String.Compare(columnType, "日期时间", false) == 0)
                            {
                                try
                                {
                                    if (Information.IsDate(RuntimeHelpers.GetObjectValue(obj)))
                                    {
                                        obj = Strings.Format(Conversions.ToDate(obj), cc.Format);
                                    }
                                    goto IL_505;
                                }
                                catch (Exception ex6)
                                {
                                    goto IL_505;
                                }
                            }
                            try
                            {
                                if (DataTypeConversion.IsNumeric(RuntimeHelpers.GetObjectValue(obj)))
                                {
                                    obj = Strings.Format(Conversions.ToDecimal(obj), cc.Format);
                                }
                                else if (Information.IsDate(RuntimeHelpers.GetObjectValue(obj)))
                                {
                                    obj = Strings.Format(Conversions.ToDate(obj), cc.Format);
                                }
                            }
                            catch (Exception ex7)
                            {
                                obj = RuntimeHelpers.GetObjectValue(dgv.Rows[currow].Cells[cc.TextValue].Value);
                            }
                        }
                    IL_505:;
                    }
                    catch (Exception ex8)
                    {
                        return cc.BeforeText;
                    }
                    result = cc.BeforeText + Conversions.ToString(obj);
                }
                else
                {
                    result = cc.BeforeText;
                }
                return result;
            }
        }

        // Token: 0x06000555 RID: 1365 RVA: 0x00036A8C File Offset: 0x00034C8C
        private string GetComputeValue(DataGridView dgv, U_Comput cc, int fromrow, int torow)
        {
            checked
            {
                string result;
                if (dgv == null)
                {
                    result = cc.BeforeText;
                }
                else if (!reportprint.HasColumname(cc.TextValue, dgv))
                {
                    result = cc.BeforeText;
                }
                else if (dgv.RowCount <= 0)
                {
                    result = cc.BeforeText;
                }
                else if (torow < fromrow)
                {
                    result = cc.BeforeText;
                }
                else if (torow < 0)
                {
                    result = cc.BeforeText;
                }
                else
                {
                    if (fromrow < 0)
                    {
                        fromrow = 0;
                    }
                    if (torow > dgv.RowCount - 1)
                    {
                        torow = dgv.RowCount - 1;
                    }
                    decimal num = 0;
                    switch (cc.TextType)
                    {
                        case U_Comput.Compute_Type.const_0:
                            num = reportprint.GetSum(dgv, cc.TextValue, fromrow, torow);
                            break;
                        case U_Comput.Compute_Type.const_1:
                            num = new decimal(torow - fromrow + 1);
                            break;
                        case U_Comput.Compute_Type.const_2:
                            if (torow - fromrow + 1 != 0)
                            {
                                num = decimal.Divide(reportprint.GetSum(dgv, cc.TextValue, fromrow, torow), new decimal(torow - fromrow + 1));
                            }
                            else
                            {
                                num = 0m;
                            }
                            break;
                        case U_Comput.Compute_Type.const_3:
                            num = reportprint.GetMax(dgv, cc.TextValue, fromrow, torow);
                            break;
                        case U_Comput.Compute_Type.const_4:
                            num = reportprint.GetMin(dgv, cc.TextValue, fromrow, torow);
                            break;
                    }
                    string text = "";
                    if (String.Compare(cc.Format, "", false) != 0)
                    {
                        try
                        {
                            text = Strings.Format(num, cc.Format);
                            text = cc.BeforeText + text;
                            goto IL_194;
                        }
                        catch (Exception ex)
                        {
                            goto IL_194;
                        }
                    }
                    if (cc.TextType == U_Comput.Compute_Type.const_1)
                    {
                        text = Strings.Format(num, "##########");
                    }
                    else
                    {
                        text = Conversions.ToString(Math.Round(num, 2));
                    }
                    text = cc.BeforeText + text;
                IL_194:
                    result = text;
                }
                return result;
            }
        }

        // Token: 0x06000556 RID: 1366 RVA: 0x00036C40 File Offset: 0x00034E40
        private static decimal GetSum(DataGridView dgv, string colname, int fromrow, int torow)
        {
            checked
            {
                decimal result;
                if (!reportprint.HasColumname(colname, dgv))
                {
                    result = 0m;
                }
                else if (fromrow < 0)
                {
                    result = 0m;
                }
                else
                {
                    decimal num = 0m;
                    for (int i = fromrow; i <= torow; i++)
                    {
                        try
                        {
                            string text = Conversions.ToString(dgv.Rows[i].Cells[colname].Value);
                            if (DataTypeConversion.IsNumeric(text))
                            {
                                num = decimal.Add(num, Conversions.ToDecimal(text));
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x06000557 RID: 1367 RVA: 0x00036CDC File Offset: 0x00034EDC
        private static decimal GetMax(DataGridView dgv, string colname, int fromrow, int torow)
        {
            decimal num = 0m;
            checked
            {
                decimal result;
                if (!reportprint.HasColumname(colname, dgv))
                {
                    result = 0m;
                }
                else if (fromrow < 0)
                {
                    result = 0m;
                }
                else
                {
                    try
                    {
                        num = Conversions.ToDecimal(dgv.Rows[fromrow].Cells[colname].Value);
                    }
                    catch (Exception ex)
                    {
                    }
                    for (int i = fromrow; i <= torow; i++)
                    {
                        try
                        {
                            string text = Conversions.ToString(dgv.Rows[i].Cells[colname].Value);
                            if (DataTypeConversion.IsNumeric(text))
                            {
                                decimal num2 = Conversions.ToDecimal(text);
                                if (decimal.Compare(num2, num) > 0)
                                {
                                    num = num2;
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x06000558 RID: 1368 RVA: 0x00036DC8 File Offset: 0x00034FC8
        private static decimal GetMin(DataGridView dgv, string colname, int fromrow, int torow)
        {
            checked
            {
                decimal result;
                if (!reportprint.HasColumname(colname, dgv))
                {
                    result = 0m;
                }
                else if (fromrow < 0)
                {
                    result = 0m;
                }
                else
                {
                    decimal num = 0m;
                    try
                    {
                        num = Conversions.ToDecimal(dgv.Rows[fromrow].Cells[colname].Value);
                    }
                    catch (Exception ex)
                    {
                    }
                    for (int i = fromrow; i <= torow; i++)
                    {
                        try
                        {
                            string text = Conversions.ToString(dgv.Rows[i].Cells[colname].Value);
                            if (DataTypeConversion.IsNumeric(text))
                            {
                                decimal num2 = Conversions.ToDecimal(text);
                                if (decimal.Compare(num2, num) < 0)
                                {
                                    num = num2;
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x06000559 RID: 1369 RVA: 0x00003848 File Offset: 0x00001A48
        private void p_EndPrintToPrinter()
        {
            if (this.IsImmediatePrint)
            {
                this.MyClose();
            }
        }

        // Token: 0x0600055A RID: 1370 RVA: 0x00036EB4 File Offset: 0x000350B4
        private void MyClose()
        {
            if (this.InvokeRequired)
            {
                reportprint.MyCl method = new reportprint.MyCl(this.MyClose);
                this.Invoke(method);
            }
            else
            {
                this.Close();
            }
        }

        // Token: 0x0600055B RID: 1371 RVA: 0x00036EE8 File Offset: 0x000350E8
        private void SetModel(bool tdmodel)
        {
            if (tdmodel)
            {
                this.Text = "套打预览";
                this.p.ZDYButton2Text = "普通预览";
                this.p.ZDYButton2ToolTipText = "转换成普通打印预览结果模式";
            }
            else
            {
                this.Text = "打印预览";
                this.p.ZDYButton2Text = "套打预览";
                this.p.ZDYButton2ToolTipText = "转换成套打印预览结果模式";
            }
        }

        // Token: 0x0600055C RID: 1372 RVA: 0x00036F50 File Offset: 0x00035150
        private void p_ZDYButton2Click()
        {
            if (String.Compare(this.p.ZDYButton2Text, "普通预览", false) == 0)
            {
                this.IsTd = false;
                this.SetModel(false);
            }
            else
            {
                this.IsTd = true;
                this.SetModel(true);
            }
            this.p.InvalidatePreview();
        }

        // Token: 0x0400035D RID: 861
        [AccessedThroughProperty("p")]
        private VB2008Print _p;

        // Token: 0x0400035E RID: 862
        public string reportname;

        // Token: 0x0400035F RID: 863
        public DataGridView dgv1;

        // Token: 0x04000360 RID: 864
        public Hashtable myvar;

        // Token: 0x04000361 RID: 865
        public bool IsTd;

        // Token: 0x04000362 RID: 866
        public bool CanEditReport;

        // Token: 0x04000363 RID: 867
        public ControlDesign cd;

        // Token: 0x04000364 RID: 868
        private float basex;

        // Token: 0x04000365 RID: 869
        private bool hasgroup;

        // Token: 0x04000366 RID: 870
        private string groupcolumn;

        // Token: 0x04000367 RID: 871
        private bool groupnewpage;

        // Token: 0x04000368 RID: 872
        private int rowsperpage;

        // Token: 0x04000369 RID: 873
        private int ColumnsNumber;

        // Token: 0x0400036A RID: 874
        private int ColumnsNumberBT;

        // Token: 0x0400036B RID: 875
        public bool IsGetReoprtString;

        // Token: 0x0400036C RID: 876
        public bool IsImmediatePrint;

        // Token: 0x0400036D RID: 877
        public bool IsImmediatePrintShowPrinter;

        // Token: 0x0400036E RID: 878
        public bool myisshowprogress;

        // Token: 0x0400036F RID: 879
        public bool myisshowprintstatusdialog;

        // Token: 0x04000370 RID: 880
        public string myprintername;

        // Token: 0x04000371 RID: 881
        public bool IsUseAPIprintDialog;

        // Token: 0x04000372 RID: 882
        public bool isresetpagemargin;

        // Token: 0x04000373 RID: 883
        public float leftmargin;

        // Token: 0x04000374 RID: 884
        public float rightmargin;

        // Token: 0x04000375 RID: 885
        public float topmargin;

        // Token: 0x04000376 RID: 886
        public float bottommargin;

        // Token: 0x04000377 RID: 887
        public bool myisdrawmargin;

        // Token: 0x04000378 RID: 888
        public bool myenablesaveaspdf;

        // Token: 0x04000379 RID: 889
        public bool myenablesaveasimage;

        // Token: 0x0400037A RID: 890
        public float myPYx;

        // Token: 0x0400037B RID: 891
        public float myPYy;

        // Token: 0x0400037C RID: 892
        public short _printcopys;

        // Token: 0x0400037D RID: 893
        private float p1;

        // Token: 0x0400037E RID: 894
        private float p2;

        // Token: 0x0400037F RID: 895
        private float p3;

        // Token: 0x04000380 RID: 896
        private float p4;

        // Token: 0x04000381 RID: 897
        private float p5;

        // Token: 0x04000382 RID: 898
        private float p6;

        // Token: 0x04000383 RID: 899
        private float p7;

        // Token: 0x04000384 RID: 900
        private float p8;

        // Token: 0x04000385 RID: 901
        private float mbwidth;

        // Token: 0x04000386 RID: 902
        private PaperSize mypapersize;

        // Token: 0x04000387 RID: 903
        private Margins mypapermargin;

        // Token: 0x04000388 RID: 904
        private int[] w_startrow;

        // Token: 0x04000389 RID: 905
        private int[] w_endrow;

        // Token: 0x0400038A RID: 906
        private int[] w_groupstartrow;

        // Token: 0x0400038B RID: 907
        private int[] w_groupendrow;

        // Token: 0x0400038C RID: 908
        private int w_pages;

        // Token: 0x0400038D RID: 909
        private int w_curpage;

        // Token: 0x0400038E RID: 910
        private int w_currow;

        // Token: 0x0400038F RID: 911
        private int w_curpagerow;

        // Token: 0x04000390 RID: 912
        private bool addemptyrows;

        // Token: 0x02000018 RID: 24
        // (Invoke) Token: 0x06000560 RID: 1376
        public delegate void MyCl();
    }
}
