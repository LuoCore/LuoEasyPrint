using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LuoEasyPrint
{
    // Token: 0x02000038 RID: 56
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ReportWizard : Form
    {
        // Token: 0x060008AB RID: 2219 RVA: 0x000506DC File Offset: 0x0004E8DC
        public ReportWizard()
        {
            base.Disposed += this.ReportWizard_Disposed;
            base.Load += this.ReportWizard_Load;
            this.curitem = "";
            this.mypp = new CommomPaperSize();
            this.myp = new Ruler();
            this.InitializeComponent();
        }

        // Token: 0x170002E7 RID: 743
        // (get) Token: 0x060008AE RID: 2222 RVA: 0x00053D44 File Offset: 0x00051F44
        // (set) Token: 0x060008AF RID: 2223 RVA: 0x00004473 File Offset: 0x00002673
        internal virtual TabControl TabControl1
        {
            get
            {
                return this._TabControl1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabControl1 = value;
            }
        }

        // Token: 0x170002E8 RID: 744
        // (get) Token: 0x060008B0 RID: 2224 RVA: 0x00053D5C File Offset: 0x00051F5C
        // (set) Token: 0x060008B1 RID: 2225 RVA: 0x0000447C File Offset: 0x0000267C
        internal virtual TabPage TabPage1
        {
            get
            {
                return this._TabPage1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage1 = value;
            }
        }

        // Token: 0x170002E9 RID: 745
        // (get) Token: 0x060008B2 RID: 2226 RVA: 0x00053D74 File Offset: 0x00051F74
        // (set) Token: 0x060008B3 RID: 2227 RVA: 0x00004485 File Offset: 0x00002685
        internal virtual TabPage TabPage2
        {
            get
            {
                return this._TabPage2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage2 = value;
            }
        }

        // Token: 0x170002EA RID: 746
        // (get) Token: 0x060008B4 RID: 2228 RVA: 0x00053D8C File Offset: 0x00051F8C
        // (set) Token: 0x060008B5 RID: 2229 RVA: 0x0000448E File Offset: 0x0000268E
        internal virtual TabPage TabPage3
        {
            get
            {
                return this._TabPage3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage3 = value;
            }
        }

        // Token: 0x170002EB RID: 747
        // (get) Token: 0x060008B6 RID: 2230 RVA: 0x00053DA4 File Offset: 0x00051FA4
        // (set) Token: 0x060008B7 RID: 2231 RVA: 0x00053DBC File Offset: 0x00051FBC
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

        // Token: 0x170002EC RID: 748
        // (get) Token: 0x060008B8 RID: 2232 RVA: 0x00053E08 File Offset: 0x00052008
        // (set) Token: 0x060008B9 RID: 2233 RVA: 0x00053E20 File Offset: 0x00052020
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

        // Token: 0x170002ED RID: 749
        // (get) Token: 0x060008BA RID: 2234 RVA: 0x00053E6C File Offset: 0x0005206C
        // (set) Token: 0x060008BB RID: 2235 RVA: 0x00004497 File Offset: 0x00002697
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

        // Token: 0x170002EE RID: 750
        // (get) Token: 0x060008BC RID: 2236 RVA: 0x00053E84 File Offset: 0x00052084
        // (set) Token: 0x060008BD RID: 2237 RVA: 0x000044A0 File Offset: 0x000026A0
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

        // Token: 0x170002EF RID: 751
        // (get) Token: 0x060008BE RID: 2238 RVA: 0x00053E9C File Offset: 0x0005209C
        // (set) Token: 0x060008BF RID: 2239 RVA: 0x000044A9 File Offset: 0x000026A9
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

        // Token: 0x170002F0 RID: 752
        // (get) Token: 0x060008C0 RID: 2240 RVA: 0x00053EB4 File Offset: 0x000520B4
        // (set) Token: 0x060008C1 RID: 2241 RVA: 0x000044B2 File Offset: 0x000026B2
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

        // Token: 0x170002F1 RID: 753
        // (get) Token: 0x060008C2 RID: 2242 RVA: 0x00053ECC File Offset: 0x000520CC
        // (set) Token: 0x060008C3 RID: 2243 RVA: 0x000044BB File Offset: 0x000026BB
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

        // Token: 0x170002F2 RID: 754
        // (get) Token: 0x060008C4 RID: 2244 RVA: 0x00053EE4 File Offset: 0x000520E4
        // (set) Token: 0x060008C5 RID: 2245 RVA: 0x000044C4 File Offset: 0x000026C4
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

        // Token: 0x170002F3 RID: 755
        // (get) Token: 0x060008C6 RID: 2246 RVA: 0x00053EFC File Offset: 0x000520FC
        // (set) Token: 0x060008C7 RID: 2247 RVA: 0x000044CD File Offset: 0x000026CD
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

        // Token: 0x170002F4 RID: 756
        // (get) Token: 0x060008C8 RID: 2248 RVA: 0x00053F14 File Offset: 0x00052114
        // (set) Token: 0x060008C9 RID: 2249 RVA: 0x000044D6 File Offset: 0x000026D6
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

        // Token: 0x170002F5 RID: 757
        // (get) Token: 0x060008CA RID: 2250 RVA: 0x00053F2C File Offset: 0x0005212C
        // (set) Token: 0x060008CB RID: 2251 RVA: 0x000044DF File Offset: 0x000026DF
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

        // Token: 0x170002F6 RID: 758
        // (get) Token: 0x060008CC RID: 2252 RVA: 0x00053F44 File Offset: 0x00052144
        // (set) Token: 0x060008CD RID: 2253 RVA: 0x000044E8 File Offset: 0x000026E8
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

        // Token: 0x170002F7 RID: 759
        // (get) Token: 0x060008CE RID: 2254 RVA: 0x00053F5C File Offset: 0x0005215C
        // (set) Token: 0x060008CF RID: 2255 RVA: 0x000044F1 File Offset: 0x000026F1
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

        // Token: 0x170002F8 RID: 760
        // (get) Token: 0x060008D0 RID: 2256 RVA: 0x00053F74 File Offset: 0x00052174
        // (set) Token: 0x060008D1 RID: 2257 RVA: 0x000044FA File Offset: 0x000026FA
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

        // Token: 0x170002F9 RID: 761
        // (get) Token: 0x060008D2 RID: 2258 RVA: 0x00053F8C File Offset: 0x0005218C
        // (set) Token: 0x060008D3 RID: 2259 RVA: 0x00004503 File Offset: 0x00002703
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

        // Token: 0x170002FA RID: 762
        // (get) Token: 0x060008D4 RID: 2260 RVA: 0x00053FA4 File Offset: 0x000521A4
        // (set) Token: 0x060008D5 RID: 2261 RVA: 0x0000450C File Offset: 0x0000270C
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

        // Token: 0x170002FB RID: 763
        // (get) Token: 0x060008D6 RID: 2262 RVA: 0x00053FBC File Offset: 0x000521BC
        // (set) Token: 0x060008D7 RID: 2263 RVA: 0x00004515 File Offset: 0x00002715
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

        // Token: 0x170002FC RID: 764
        // (get) Token: 0x060008D8 RID: 2264 RVA: 0x00053FD4 File Offset: 0x000521D4
        // (set) Token: 0x060008D9 RID: 2265 RVA: 0x0000451E File Offset: 0x0000271E
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

        // Token: 0x170002FD RID: 765
        // (get) Token: 0x060008DA RID: 2266 RVA: 0x00053FEC File Offset: 0x000521EC
        // (set) Token: 0x060008DB RID: 2267 RVA: 0x00004527 File Offset: 0x00002727
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

        // Token: 0x170002FE RID: 766
        // (get) Token: 0x060008DC RID: 2268 RVA: 0x00054004 File Offset: 0x00052204
        // (set) Token: 0x060008DD RID: 2269 RVA: 0x00004530 File Offset: 0x00002730
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

        // Token: 0x170002FF RID: 767
        // (get) Token: 0x060008DE RID: 2270 RVA: 0x0005401C File Offset: 0x0005221C
        // (set) Token: 0x060008DF RID: 2271 RVA: 0x00054034 File Offset: 0x00052234
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

        // Token: 0x17000300 RID: 768
        // (get) Token: 0x060008E0 RID: 2272 RVA: 0x00054080 File Offset: 0x00052280
        // (set) Token: 0x060008E1 RID: 2273 RVA: 0x00004539 File Offset: 0x00002739
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

        // Token: 0x17000301 RID: 769
        // (get) Token: 0x060008E2 RID: 2274 RVA: 0x00054098 File Offset: 0x00052298
        // (set) Token: 0x060008E3 RID: 2275 RVA: 0x00004542 File Offset: 0x00002742
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

        // Token: 0x17000302 RID: 770
        // (get) Token: 0x060008E4 RID: 2276 RVA: 0x000540B0 File Offset: 0x000522B0
        // (set) Token: 0x060008E5 RID: 2277 RVA: 0x0000454B File Offset: 0x0000274B
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

        // Token: 0x17000303 RID: 771
        // (get) Token: 0x060008E6 RID: 2278 RVA: 0x000540C8 File Offset: 0x000522C8
        // (set) Token: 0x060008E7 RID: 2279 RVA: 0x00004554 File Offset: 0x00002754
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

        // Token: 0x17000304 RID: 772
        // (get) Token: 0x060008E8 RID: 2280 RVA: 0x000540E0 File Offset: 0x000522E0
        // (set) Token: 0x060008E9 RID: 2281 RVA: 0x000540F8 File Offset: 0x000522F8
        internal virtual CheckedListBox C1
        {
            get
            {
                return this._C1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.C1_SelectedIndexChanged);
                ItemCheckEventHandler value3 = new ItemCheckEventHandler(this.C1_ItemCheck);
                if (this._C1 != null)
                {
                    this._C1.SelectedIndexChanged -= value2;
                    this._C1.ItemCheck -= value3;
                }
                this._C1 = value;
                if (this._C1 != null)
                {
                    this._C1.SelectedIndexChanged += value2;
                    this._C1.ItemCheck += value3;
                }
            }
        }

        // Token: 0x17000305 RID: 773
        // (get) Token: 0x060008EA RID: 2282 RVA: 0x00054168 File Offset: 0x00052368
        // (set) Token: 0x060008EB RID: 2283 RVA: 0x0000455D File Offset: 0x0000275D
        internal virtual GroupBox GroupBox10
        {
            get
            {
                return this._GroupBox10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox10 = value;
            }
        }

        // Token: 0x17000306 RID: 774
        // (get) Token: 0x060008EC RID: 2284 RVA: 0x00054180 File Offset: 0x00052380
        // (set) Token: 0x060008ED RID: 2285 RVA: 0x00054198 File Offset: 0x00052398
        internal virtual Button Button16
        {
            get
            {
                return this._Button16;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button16_Click);
                if (this._Button16 != null)
                {
                    this._Button16.Click -= value2;
                }
                this._Button16 = value;
                if (this._Button16 != null)
                {
                    this._Button16.Click += value2;
                }
            }
        }

        // Token: 0x17000307 RID: 775
        // (get) Token: 0x060008EE RID: 2286 RVA: 0x000541E4 File Offset: 0x000523E4
        // (set) Token: 0x060008EF RID: 2287 RVA: 0x000541FC File Offset: 0x000523FC
        internal virtual Button Button17
        {
            get
            {
                return this._Button17;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button17_Click);
                if (this._Button17 != null)
                {
                    this._Button17.Click -= value2;
                }
                this._Button17 = value;
                if (this._Button17 != null)
                {
                    this._Button17.Click += value2;
                }
            }
        }

        // Token: 0x17000308 RID: 776
        // (get) Token: 0x060008F0 RID: 2288 RVA: 0x00054248 File Offset: 0x00052448
        // (set) Token: 0x060008F1 RID: 2289 RVA: 0x00004566 File Offset: 0x00002766
        internal virtual Label headerfont
        {
            get
            {
                return this._headerfont;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._headerfont = value;
            }
        }

        // Token: 0x17000309 RID: 777
        // (get) Token: 0x060008F2 RID: 2290 RVA: 0x00054260 File Offset: 0x00052460
        // (set) Token: 0x060008F3 RID: 2291 RVA: 0x00054278 File Offset: 0x00052478
        internal virtual Button Button11
        {
            get
            {
                return this._Button11;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button11_Click);
                if (this._Button11 != null)
                {
                    this._Button11.Click -= value2;
                }
                this._Button11 = value;
                if (this._Button11 != null)
                {
                    this._Button11.Click += value2;
                }
            }
        }

        // Token: 0x1700030A RID: 778
        // (get) Token: 0x060008F4 RID: 2292 RVA: 0x000542C4 File Offset: 0x000524C4
        // (set) Token: 0x060008F5 RID: 2293 RVA: 0x0000456F File Offset: 0x0000276F
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

        // Token: 0x1700030B RID: 779
        // (get) Token: 0x060008F6 RID: 2294 RVA: 0x000542DC File Offset: 0x000524DC
        // (set) Token: 0x060008F7 RID: 2295 RVA: 0x000542F4 File Offset: 0x000524F4
        internal virtual Button Button30
        {
            get
            {
                return this._Button30;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button30_Click);
                if (this._Button30 != null)
                {
                    this._Button30.Click -= value2;
                }
                this._Button30 = value;
                if (this._Button30 != null)
                {
                    this._Button30.Click += value2;
                }
            }
        }

        // Token: 0x1700030C RID: 780
        // (get) Token: 0x060008F8 RID: 2296 RVA: 0x00054340 File Offset: 0x00052540
        // (set) Token: 0x060008F9 RID: 2297 RVA: 0x00004578 File Offset: 0x00002778
        internal virtual GroupBox GroupBox13
        {
            get
            {
                return this._GroupBox13;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox13 = value;
            }
        }

        // Token: 0x1700030D RID: 781
        // (get) Token: 0x060008FA RID: 2298 RVA: 0x00054358 File Offset: 0x00052558
        // (set) Token: 0x060008FB RID: 2299 RVA: 0x00054370 File Offset: 0x00052570
        internal virtual Button Button19
        {
            get
            {
                return this._Button19;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button19_Click);
                if (this._Button19 != null)
                {
                    this._Button19.Click -= value2;
                }
                this._Button19 = value;
                if (this._Button19 != null)
                {
                    this._Button19.Click += value2;
                }
            }
        }

        // Token: 0x1700030E RID: 782
        // (get) Token: 0x060008FC RID: 2300 RVA: 0x000543BC File Offset: 0x000525BC
        // (set) Token: 0x060008FD RID: 2301 RVA: 0x000543D4 File Offset: 0x000525D4
        internal virtual Button Button18
        {
            get
            {
                return this._Button18;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button18_Click);
                if (this._Button18 != null)
                {
                    this._Button18.Click -= value2;
                }
                this._Button18 = value;
                if (this._Button18 != null)
                {
                    this._Button18.Click += value2;
                }
            }
        }

        // Token: 0x1700030F RID: 783
        // (get) Token: 0x060008FE RID: 2302 RVA: 0x00054420 File Offset: 0x00052620
        // (set) Token: 0x060008FF RID: 2303 RVA: 0x00054438 File Offset: 0x00052638
        internal virtual Button Button13
        {
            get
            {
                return this._Button13;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button13_Click);
                if (this._Button13 != null)
                {
                    this._Button13.Click -= value2;
                }
                this._Button13 = value;
                if (this._Button13 != null)
                {
                    this._Button13.Click += value2;
                }
            }
        }

        // Token: 0x17000310 RID: 784
        // (get) Token: 0x06000900 RID: 2304 RVA: 0x00054484 File Offset: 0x00052684
        // (set) Token: 0x06000901 RID: 2305 RVA: 0x0005449C File Offset: 0x0005269C
        internal virtual Button Button12
        {
            get
            {
                return this._Button12;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button12_Click);
                if (this._Button12 != null)
                {
                    this._Button12.Click -= value2;
                }
                this._Button12 = value;
                if (this._Button12 != null)
                {
                    this._Button12.Click += value2;
                }
            }
        }

        // Token: 0x17000311 RID: 785
        // (get) Token: 0x06000902 RID: 2306 RVA: 0x000544E8 File Offset: 0x000526E8
        // (set) Token: 0x06000903 RID: 2307 RVA: 0x00004581 File Offset: 0x00002781
        internal virtual Label columnfont
        {
            get
            {
                return this._columnfont;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._columnfont = value;
            }
        }

        // Token: 0x17000312 RID: 786
        // (get) Token: 0x06000904 RID: 2308 RVA: 0x00054500 File Offset: 0x00052700
        // (set) Token: 0x06000905 RID: 2309 RVA: 0x00054518 File Offset: 0x00052718
        internal virtual Button Button9
        {
            get
            {
                return this._Button9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button9_Click);
                if (this._Button9 != null)
                {
                    this._Button9.Click -= value2;
                }
                this._Button9 = value;
                if (this._Button9 != null)
                {
                    this._Button9.Click += value2;
                }
            }
        }

        // Token: 0x17000313 RID: 787
        // (get) Token: 0x06000906 RID: 2310 RVA: 0x00054564 File Offset: 0x00052764
        // (set) Token: 0x06000907 RID: 2311 RVA: 0x0005457C File Offset: 0x0005277C
        internal virtual ComboBox ml
        {
            get
            {
                return this._ml;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ml_SelectedIndexChanged);
                if (this._ml != null)
                {
                    this._ml.SelectedIndexChanged -= value2;
                }
                this._ml = value;
                if (this._ml != null)
                {
                    this._ml.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000314 RID: 788
        // (get) Token: 0x06000908 RID: 2312 RVA: 0x000545C8 File Offset: 0x000527C8
        // (set) Token: 0x06000909 RID: 2313 RVA: 0x000545E0 File Offset: 0x000527E0
        internal virtual ComboBox ldq
        {
            get
            {
                return this._ldq;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ldq_SelectedIndexChanged);
                if (this._ldq != null)
                {
                    this._ldq.SelectedIndexChanged -= value2;
                }
                this._ldq = value;
                if (this._ldq != null)
                {
                    this._ldq.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000315 RID: 789
        // (get) Token: 0x0600090A RID: 2314 RVA: 0x0005462C File Offset: 0x0005282C
        // (set) Token: 0x0600090B RID: 2315 RVA: 0x0000458A File Offset: 0x0000278A
        internal virtual Label Label27
        {
            get
            {
                return this._Label27;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label27 = value;
            }
        }

        // Token: 0x17000316 RID: 790
        // (get) Token: 0x0600090C RID: 2316 RVA: 0x00054644 File Offset: 0x00052844
        // (set) Token: 0x0600090D RID: 2317 RVA: 0x00004593 File Offset: 0x00002793
        internal virtual Label Label28
        {
            get
            {
                return this._Label28;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label28 = value;
            }
        }

        // Token: 0x17000317 RID: 791
        // (get) Token: 0x0600090E RID: 2318 RVA: 0x0005465C File Offset: 0x0005285C
        // (set) Token: 0x0600090F RID: 2319 RVA: 0x0000459C File Offset: 0x0000279C
        internal virtual ColorDialog ColorDialog1
        {
            get
            {
                return this._ColorDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ColorDialog1 = value;
            }
        }

        // Token: 0x17000318 RID: 792
        // (get) Token: 0x06000910 RID: 2320 RVA: 0x00054674 File Offset: 0x00052874
        // (set) Token: 0x06000911 RID: 2321 RVA: 0x000045A5 File Offset: 0x000027A5
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

        // Token: 0x17000319 RID: 793
        // (get) Token: 0x06000912 RID: 2322 RVA: 0x0005468C File Offset: 0x0005288C
        // (set) Token: 0x06000913 RID: 2323 RVA: 0x000546A4 File Offset: 0x000528A4
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

        // Token: 0x1700031A RID: 794
        // (get) Token: 0x06000914 RID: 2324 RVA: 0x000546F0 File Offset: 0x000528F0
        // (set) Token: 0x06000915 RID: 2325 RVA: 0x000045AE File Offset: 0x000027AE
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

        // Token: 0x1700031B RID: 795
        // (get) Token: 0x06000916 RID: 2326 RVA: 0x00054708 File Offset: 0x00052908
        // (set) Token: 0x06000917 RID: 2327 RVA: 0x000045B7 File Offset: 0x000027B7
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

        // Token: 0x1700031C RID: 796
        // (get) Token: 0x06000918 RID: 2328 RVA: 0x00054720 File Offset: 0x00052920
        // (set) Token: 0x06000919 RID: 2329 RVA: 0x000045C0 File Offset: 0x000027C0
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

        // Token: 0x1700031D RID: 797
        // (get) Token: 0x0600091A RID: 2330 RVA: 0x00054738 File Offset: 0x00052938
        // (set) Token: 0x0600091B RID: 2331 RVA: 0x000045C9 File Offset: 0x000027C9
        internal virtual NumericUpDown rowheight
        {
            get
            {
                return this._rowheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rowheight = value;
            }
        }

        // Token: 0x1700031E RID: 798
        // (get) Token: 0x0600091C RID: 2332 RVA: 0x00054750 File Offset: 0x00052950
        // (set) Token: 0x0600091D RID: 2333 RVA: 0x000045D2 File Offset: 0x000027D2
        internal virtual NumericUpDown colheaderheight
        {
            get
            {
                return this._colheaderheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._colheaderheight = value;
            }
        }

        // Token: 0x1700031F RID: 799
        // (get) Token: 0x0600091E RID: 2334 RVA: 0x00054768 File Offset: 0x00052968
        // (set) Token: 0x0600091F RID: 2335 RVA: 0x000045DB File Offset: 0x000027DB
        internal virtual Label Label7
        {
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        // Token: 0x17000320 RID: 800
        // (get) Token: 0x06000920 RID: 2336 RVA: 0x00054780 File Offset: 0x00052980
        // (set) Token: 0x06000921 RID: 2337 RVA: 0x000045E4 File Offset: 0x000027E4
        internal virtual Label Label8
        {
            get
            {
                return this._Label8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label8 = value;
            }
        }

        // Token: 0x17000321 RID: 801
        // (get) Token: 0x06000922 RID: 2338 RVA: 0x00054798 File Offset: 0x00052998
        // (set) Token: 0x06000923 RID: 2339 RVA: 0x000045ED File Offset: 0x000027ED
        internal virtual GroupBox GroupBox5
        {
            get
            {
                return this._GroupBox5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox5 = value;
            }
        }

        // Token: 0x17000322 RID: 802
        // (get) Token: 0x06000924 RID: 2340 RVA: 0x000547B0 File Offset: 0x000529B0
        // (set) Token: 0x06000925 RID: 2341 RVA: 0x000045F6 File Offset: 0x000027F6
        internal virtual GroupBox GroupBox14
        {
            get
            {
                return this._GroupBox14;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox14 = value;
            }
        }

        // Token: 0x17000323 RID: 803
        // (get) Token: 0x06000926 RID: 2342 RVA: 0x000547C8 File Offset: 0x000529C8
        // (set) Token: 0x06000927 RID: 2343 RVA: 0x000045FF File Offset: 0x000027FF
        internal virtual GroupBox GroupBox7
        {
            get
            {
                return this._GroupBox7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox7 = value;
            }
        }

        // Token: 0x17000324 RID: 804
        // (get) Token: 0x06000928 RID: 2344 RVA: 0x000547E0 File Offset: 0x000529E0
        // (set) Token: 0x06000929 RID: 2345 RVA: 0x00004608 File Offset: 0x00002808
        internal virtual GroupBox GroupBox6
        {
            get
            {
                return this._GroupBox6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox6 = value;
            }
        }

        // Token: 0x17000325 RID: 805
        // (get) Token: 0x0600092A RID: 2346 RVA: 0x000547F8 File Offset: 0x000529F8
        // (set) Token: 0x0600092B RID: 2347 RVA: 0x00004611 File Offset: 0x00002811
        internal virtual Label Label9
        {
            get
            {
                return this._Label9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label9 = value;
            }
        }

        // Token: 0x17000326 RID: 806
        // (get) Token: 0x0600092C RID: 2348 RVA: 0x00054810 File Offset: 0x00052A10
        // (set) Token: 0x0600092D RID: 2349 RVA: 0x0000461A File Offset: 0x0000281A
        internal virtual TextBox t3
        {
            get
            {
                return this._t3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._t3 = value;
            }
        }

        // Token: 0x17000327 RID: 807
        // (get) Token: 0x0600092E RID: 2350 RVA: 0x00054828 File Offset: 0x00052A28
        // (set) Token: 0x0600092F RID: 2351 RVA: 0x00004623 File Offset: 0x00002823
        internal virtual TextBox t2
        {
            get
            {
                return this._t2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._t2 = value;
            }
        }

        // Token: 0x17000328 RID: 808
        // (get) Token: 0x06000930 RID: 2352 RVA: 0x00054840 File Offset: 0x00052A40
        // (set) Token: 0x06000931 RID: 2353 RVA: 0x0000462C File Offset: 0x0000282C
        internal virtual TextBox t1
        {
            get
            {
                return this._t1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._t1 = value;
            }
        }

        // Token: 0x17000329 RID: 809
        // (get) Token: 0x06000932 RID: 2354 RVA: 0x00054858 File Offset: 0x00052A58
        // (set) Token: 0x06000933 RID: 2355 RVA: 0x00004635 File Offset: 0x00002835
        internal virtual GroupBox GroupBox8
        {
            get
            {
                return this._GroupBox8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox8 = value;
            }
        }

        // Token: 0x1700032A RID: 810
        // (get) Token: 0x06000934 RID: 2356 RVA: 0x00054870 File Offset: 0x00052A70
        // (set) Token: 0x06000935 RID: 2357 RVA: 0x0000463E File Offset: 0x0000283E
        internal virtual NumericUpDown NumericUpDown2
        {
            get
            {
                return this._NumericUpDown2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._NumericUpDown2 = value;
            }
        }

        // Token: 0x1700032B RID: 811
        // (get) Token: 0x06000936 RID: 2358 RVA: 0x00054888 File Offset: 0x00052A88
        // (set) Token: 0x06000937 RID: 2359 RVA: 0x00004647 File Offset: 0x00002847
        internal virtual CheckBox emptyrow
        {
            get
            {
                return this._emptyrow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._emptyrow = value;
            }
        }

        // Token: 0x1700032C RID: 812
        // (get) Token: 0x06000938 RID: 2360 RVA: 0x000548A0 File Offset: 0x00052AA0
        // (set) Token: 0x06000939 RID: 2361 RVA: 0x00004650 File Offset: 0x00002850
        internal virtual Label Label10
        {
            get
            {
                return this._Label10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label10 = value;
            }
        }

        // Token: 0x1700032D RID: 813
        // (get) Token: 0x0600093A RID: 2362 RVA: 0x000548B8 File Offset: 0x00052AB8
        // (set) Token: 0x0600093B RID: 2363 RVA: 0x00004659 File Offset: 0x00002859
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

        // Token: 0x1700032E RID: 814
        // (get) Token: 0x0600093C RID: 2364 RVA: 0x000548D0 File Offset: 0x00052AD0
        // (set) Token: 0x0600093D RID: 2365 RVA: 0x00004662 File Offset: 0x00002862
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

        // Token: 0x1700032F RID: 815
        // (get) Token: 0x0600093E RID: 2366 RVA: 0x000548E8 File Offset: 0x00052AE8
        // (set) Token: 0x0600093F RID: 2367 RVA: 0x0000466B File Offset: 0x0000286B
        internal virtual NumericUpDown jj
        {
            get
            {
                return this._jj;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._jj = value;
            }
        }

        // Token: 0x17000330 RID: 816
        // (get) Token: 0x06000940 RID: 2368 RVA: 0x00054900 File Offset: 0x00052B00
        // (set) Token: 0x06000941 RID: 2369 RVA: 0x00004674 File Offset: 0x00002874
        internal virtual Label Label15
        {
            get
            {
                return this._Label15;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label15 = value;
            }
        }

        // Token: 0x17000331 RID: 817
        // (get) Token: 0x06000942 RID: 2370 RVA: 0x00054918 File Offset: 0x00052B18
        // (set) Token: 0x06000943 RID: 2371 RVA: 0x0000467D File Offset: 0x0000287D
        internal virtual CheckBox zoomtopaper
        {
            get
            {
                return this._zoomtopaper;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zoomtopaper = value;
            }
        }

        // Token: 0x17000332 RID: 818
        // (get) Token: 0x06000944 RID: 2372 RVA: 0x00054930 File Offset: 0x00052B30
        // (set) Token: 0x06000945 RID: 2373 RVA: 0x00004686 File Offset: 0x00002886
        internal virtual GroupBox GroupBox11
        {
            get
            {
                return this._GroupBox11;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox11 = value;
            }
        }

        // Token: 0x17000333 RID: 819
        // (get) Token: 0x06000946 RID: 2374 RVA: 0x00054948 File Offset: 0x00052B48
        // (set) Token: 0x06000947 RID: 2375 RVA: 0x0000468F File Offset: 0x0000288F
        internal virtual TextBox pagetitle
        {
            get
            {
                return this._pagetitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagetitle = value;
            }
        }

        // Token: 0x17000334 RID: 820
        // (get) Token: 0x06000948 RID: 2376 RVA: 0x00054960 File Offset: 0x00052B60
        // (set) Token: 0x06000949 RID: 2377 RVA: 0x00004698 File Offset: 0x00002898
        internal virtual GroupBox GroupBox12
        {
            get
            {
                return this._GroupBox12;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox12 = value;
            }
        }

        // Token: 0x17000335 RID: 821
        // (get) Token: 0x0600094A RID: 2378 RVA: 0x00054978 File Offset: 0x00052B78
        // (set) Token: 0x0600094B RID: 2379 RVA: 0x00054990 File Offset: 0x00052B90
        internal virtual CheckBox rowidadd
        {
            get
            {
                return this._rowidadd;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.rowidadd_CheckedChanged);
                if (this._rowidadd != null)
                {
                    this._rowidadd.CheckedChanged -= value2;
                }
                this._rowidadd = value;
                if (this._rowidadd != null)
                {
                    this._rowidadd.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000336 RID: 822
        // (get) Token: 0x0600094C RID: 2380 RVA: 0x000549DC File Offset: 0x00052BDC
        // (set) Token: 0x0600094D RID: 2381 RVA: 0x000549F4 File Offset: 0x00052BF4
        internal virtual NumericUpDown rowid
        {
            get
            {
                return this._rowid;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.rowid_ValueChanged);
                if (this._rowid != null)
                {
                    this._rowid.ValueChanged -= value2;
                }
                this._rowid = value;
                if (this._rowid != null)
                {
                    this._rowid.ValueChanged += value2;
                }
            }
        }

        // Token: 0x17000337 RID: 823
        // (get) Token: 0x0600094E RID: 2382 RVA: 0x00054A40 File Offset: 0x00052C40
        // (set) Token: 0x0600094F RID: 2383 RVA: 0x000046A1 File Offset: 0x000028A1
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

        // Token: 0x17000338 RID: 824
        // (get) Token: 0x06000950 RID: 2384 RVA: 0x00054A58 File Offset: 0x00052C58
        // (set) Token: 0x06000951 RID: 2385 RVA: 0x000046AA File Offset: 0x000028AA
        internal virtual CheckBox rowidaddnewpage
        {
            get
            {
                return this._rowidaddnewpage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rowidaddnewpage = value;
            }
        }

        // Token: 0x06000952 RID: 2386 RVA: 0x00054A70 File Offset: 0x00052C70
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.myh.Text = Convert.ToString(this.mypp.GetPaperHeightMM(this.ComboBox1.Text));
            this.myw.Text = Convert.ToString(this.mypp.GetPaperWidthMM(this.ComboBox1.Text));
            if (String.Compare(this.ComboBox1.Text, "[自定义纸张]", false) == 0)
            {
                this.myh.ReadOnly = false;
                this.myw.ReadOnly = false;
                this.myh.Value = 297m;
                this.myw.Value = 210m;
            }
            else
            {
                this.myh.ReadOnly = true;
                this.myw.ReadOnly = true;
            }
        }

        // Token: 0x06000953 RID: 2387 RVA: 0x00054B48 File Offset: 0x00052D48
        private void C1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.C1.SelectedIndex >= 0)
            {
                this.curitem = this.GetItemName(Convert.ToString(this.C1.SelectedItem));
                ContentAlignment dgvcolumnAlignment = Module1.GetDGVColumnAlignment(this.dgvtoprint, this.curitem);
                if (dgvcolumnAlignment != ContentAlignment.BottomLeft)
                {
                    if (dgvcolumnAlignment != ContentAlignment.MiddleLeft)
                    {
                        if (dgvcolumnAlignment != ContentAlignment.TopLeft)
                        {
                            if (dgvcolumnAlignment != ContentAlignment.BottomCenter)
                            {
                                if (dgvcolumnAlignment != ContentAlignment.MiddleCenter)
                                {
                                    if (dgvcolumnAlignment != ContentAlignment.TopCenter)
                                    {
                                        if (dgvcolumnAlignment != ContentAlignment.BottomRight)
                                        {
                                            if (dgvcolumnAlignment != ContentAlignment.MiddleRight)
                                            {
                                                if (dgvcolumnAlignment != ContentAlignment.TopRight)
                                                {
                                                    goto IL_B0;
                                                }
                                            }
                                        }
                                        this.ldq.Text = "右对齐";
                                        goto IL_B0;
                                    }
                                }
                            }
                            this.ldq.Text = "居中对齐";
                            goto IL_B0;
                        }
                    }
                }
                this.ldq.Text = "左对齐";
            IL_B0:
                if (Module1.GetDGVColumnMulLine(this.dgvtoprint, this.curitem))
                {
                    this.ml.Text = "允许";
                }
                else
                {
                    this.ml.Text = "不允许";
                }
                Font font = Module1.GetDGVColumnFont(this.dgvtoprint, this.curitem);
                if (font == null)
                {
                    this.columnfont.Font = (Font)font.Clone();
                }
                this.columnfont.ForeColor = Module1.GetDGVColumnForeColor(this.dgvtoprint, this.curitem);
                this.columnfont.BackColor = Module1.GetDGVColumnBackColor(this.dgvtoprint, this.curitem);
                font = Module1.GetDGVColumnHeaderFont(this.dgvtoprint, this.curitem);
                if (font == null)
                {
                    this.headerfont.Font = (Font)font.Clone();
                }
                this.headerfont.ForeColor = Module1.GetDGVColumnHeaderForeColor(this.dgvtoprint, this.curitem);
                this.headerfont.BackColor = Module1.GetDGVColumnHeaderBackColor(this.dgvtoprint, this.curitem);
                try
                {
                    this.NumericUpDown1.Value = new decimal(this.myp.ConvertToMM((float)this.dgvtoprint.Columns[this.curitem].Width, true));
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x06000954 RID: 2388 RVA: 0x00054D58 File Offset: 0x00052F58
        private string GetItemName(string tt)
        {
            string result = "";
            int num = 0;
            checked
            {
                int num2 = this.colcount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.dgvtoprint.Columns[i].HeaderText, tt, false) == 0)
                    {
                        result = this.dgvtoprint.Columns[i].Name;
                        return result;
                    }
                }
                return result;
            }
        }

        // Token: 0x06000955 RID: 2389 RVA: 0x00054DC0 File Offset: 0x00052FC0
        private void SetFieldToComb()
        {
            this.C1.Items.Clear();
            this.colcount = this.dgvtoprint.ColumnCount;
            checked
            {
                if (this.colcount > 0)
                {
                    int[] array = new int[this.colcount - 1 + 1];
                    int[] array2 = new int[this.colcount - 1 + 1];
                    int num = 0;
                    int num2 = this.colcount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        array[i] = i;
                        array2[i] = this.dgvtoprint.Columns[i].DisplayIndex;
                    }
                    Array.Sort<int, int>(array2, array);
                    int num3 = 0;
                    int num4 = this.colcount - 1;
                    for (int i = num3; i <= num4; i++)
                    {
                        this.C1.Items.Add(this.dgvtoprint.Columns[array[i]].HeaderText, this.dgvtoprint.Columns[array[i]].Visible);
                    }
                    try
                    {
                        this.C1.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        // Token: 0x06000956 RID: 2390 RVA: 0x00054EDC File Offset: 0x000530DC
        private void ReportWizard_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.dgvtoprint = null;
                this.mycs = null;
                this.myp.Dispose();
                this.myp = null;
                this.mypp.Dispose();
                this.mypp = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000957 RID: 2391 RVA: 0x00054F3C File Offset: 0x0005313C
        private void ReportWizard_Load(object sender, EventArgs e)
        {
            int num = 0;
            checked
            {
                int num2 = this.mypp.fpagerSizestr.GetLength(0) - 1;
                for (int i = num; i <= num2; i++)
                {
                    this.ComboBox1.Items.Add(this.mypp.fpagerSizestr[i, 0]);
                }
                this.ComboBox1.Text = "A4";
                this.colheaderheight.Value = new decimal(this.myp.ConvertToMM((float)this.dgvtoprint.ColumnHeadersHeight, false));
                this.colcount = this.dgvtoprint.ColumnCount;
                if (this.dgvtoprint.RowsDefaultCellStyle.Font != null)
                {
                    int num3 = 0;
                    int num4 = this.colcount - 1;
                    for (int j = num3; j <= num4; j++)
                    {
                        this.dgvtoprint.Columns[j].DefaultCellStyle.Font = Module1.GetDGVColumnFont(this.dgvtoprint, this.dgvtoprint.Columns[j].Name);
                    }
                    this.dgvtoprint.RowsDefaultCellStyle = null;
                }
                if (this.dgvtoprint.RowsDefaultCellStyle.ForeColor.ToArgb() != 0)
                {
                    int num5 = 0;
                    int num6 = this.colcount - 1;
                    for (int k = num5; k <= num6; k++)
                    {
                        this.dgvtoprint.Columns[k].DefaultCellStyle.ForeColor = Module1.GetDGVColumnForeColor(this.dgvtoprint, this.dgvtoprint.Columns[k].Name);
                    }
                    this.dgvtoprint.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0);
                }
                if (this.dgvtoprint.RowsDefaultCellStyle.BackColor.ToArgb() != 0)
                {
                    int num7 = 0;
                    int num8 = this.colcount - 1;
                    for (int l = num7; l <= num8; l++)
                    {
                        this.dgvtoprint.Columns[l].DefaultCellStyle.BackColor = Module1.GetDGVColumnBackColor(this.dgvtoprint, this.dgvtoprint.Columns[l].Name);
                    }
                    this.dgvtoprint.RowsDefaultCellStyle.BackColor = Color.FromArgb(0);
                }
                if (this.dgvtoprint.RowsDefaultCellStyle.Alignment != DataGridViewContentAlignment.NotSet)
                {
                    int num9 = 0;
                    int num10 = this.colcount - 1;
                    for (int m = num9; m <= num10; m++)
                    {
                        this.dgvtoprint.Columns[m].DefaultCellStyle.Alignment = (DataGridViewContentAlignment)Module1.GetDGVColumnAlignment(this.dgvtoprint, this.dgvtoprint.Columns[m].Name);
                    }
                    this.dgvtoprint.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                }
                if (this.dgvtoprint.RowsDefaultCellStyle.WrapMode != DataGridViewTriState.NotSet)
                {
                    int num11 = 0;
                    int num12 = this.colcount - 1;
                    for (int n = num11; n <= num12; n++)
                    {
                        if (Module1.GetDGVColumnMulLine(this.dgvtoprint, this.dgvtoprint.Columns[n].Name))
                        {
                            this.dgvtoprint.Columns[n].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        }
                        else
                        {
                            this.dgvtoprint.Columns[n].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                        }
                    }
                    this.dgvtoprint.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
                }
                this.SetFieldToComb();
            }
        }

        // Token: 0x06000958 RID: 2392 RVA: 0x00055278 File Offset: 0x00053478
        private void Button18_Click(object sender, EventArgs e)
        {
            checked
            {
                if (String.Compare(this.curitem, "", false) != 0)
                {
                    if (this.C1.SelectedIndex >= 0)
                    {
                        if (this.C1.SelectedIndex == 0)
                        {
                            Interaction.MsgBox("该列已经是第一列了，不能再上移了", MsgBoxStyle.OkOnly, "提示信息");
                        }
                        else
                        {
                            string columnName = this.curitem;
                            bool itemChecked = this.C1.GetItemChecked(this.C1.SelectedIndex);
                            string value = Convert.ToString(this.C1.SelectedItem);
                            int selectedIndex = this.C1.SelectedIndex;
                            string text = Convert.ToString(this.C1.Items[selectedIndex - 1]);
                            bool itemChecked2 = this.C1.GetItemChecked(selectedIndex - 1);
                            string itemName = this.GetItemName(text);
                            this.C1.Items[selectedIndex - 1] = value;
                            this.C1.SetItemChecked(selectedIndex - 1, itemChecked);
                            this.C1.Items[selectedIndex] = text;
                            this.C1.SetItemChecked(selectedIndex, itemChecked2);
                            int displayIndex = this.dgvtoprint.Columns[columnName].DisplayIndex;
                            this.dgvtoprint.Columns[columnName].DisplayIndex = this.dgvtoprint.Columns[itemName].DisplayIndex;
                            this.dgvtoprint.Columns[itemName].DisplayIndex = displayIndex;
                            this.C1.SelectedIndex = selectedIndex - 1;
                        }
                    }
                }
            }
        }

        // Token: 0x06000959 RID: 2393 RVA: 0x000553F8 File Offset: 0x000535F8
        private void Button19_Click(object sender, EventArgs e)
        {
            checked
            {
                if (String.Compare(this.curitem, "", false) != 0)
                {
                    if (this.C1.SelectedIndex >= 0)
                    {
                        if (this.C1.SelectedIndex == this.C1.Items.Count - 1)
                        {
                            Interaction.MsgBox("该列已经是最后一列了，不能再下移了", MsgBoxStyle.OkOnly, "提示信息");
                        }
                        else
                        {
                            string columnName = this.curitem;
                            bool itemChecked = this.C1.GetItemChecked(this.C1.SelectedIndex);
                            string value = Convert.ToString(this.C1.SelectedItem);
                            int selectedIndex = this.C1.SelectedIndex;
                            string text = Convert.ToString(this.C1.Items[selectedIndex + 1]);
                            bool itemChecked2 = this.C1.GetItemChecked(selectedIndex + 1);
                            string itemName = this.GetItemName(text);
                            this.C1.Items[selectedIndex + 1] = value;
                            this.C1.SetItemChecked(selectedIndex + 1, itemChecked);
                            this.C1.Items[selectedIndex] = text;
                            this.C1.SetItemChecked(selectedIndex, itemChecked2);
                            int displayIndex = this.dgvtoprint.Columns[columnName].DisplayIndex;
                            this.dgvtoprint.Columns[columnName].DisplayIndex = this.dgvtoprint.Columns[itemName].DisplayIndex;
                            this.dgvtoprint.Columns[itemName].DisplayIndex = displayIndex;
                            this.C1.SelectedIndex = selectedIndex + 1;
                        }
                    }
                }
            }
        }

        // Token: 0x0600095A RID: 2394 RVA: 0x0005558C File Offset: 0x0005378C
        private void ldq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                string text = this.ldq.Text;
                DataGridViewContentAlignment alignment = DataGridViewContentAlignment.NotSet;
                if (String.Compare(text, "居中对齐", false) == 0)
                {
                    alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else if (String.Compare(text, "左对齐", false) == 0)
                {
                    alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else if (String.Compare(text, "右对齐", false) == 0)
                {
                    alignment = DataGridViewContentAlignment.MiddleRight;
                }
                this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Alignment = alignment;
            }
        }

        // Token: 0x0600095B RID: 2395 RVA: 0x00055618 File Offset: 0x00053818
        private void ml_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                string text = this.ml.Text;
                if (String.Compare(text, "允许", false) == 0)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else if (String.Compare(text, "不允许", false) == 0)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                }
            }
        }

        // Token: 0x0600095C RID: 2396 RVA: 0x000556AC File Offset: 0x000538AC
        private void Button30_Click(object sender, EventArgs e)
        {
            checked
            {
                if (String.Compare(this.curitem, "", false) != 0)
                {
                    string text = Convert.ToString(this.C1.SelectedItem);
                    string text2 = Interaction.InputBox("请输入该列要打印的新列标题名称，该列的原打印标题为【" + text + "】，注意，请确保存列标题名称在该表格中唯一的，没有重复", "更改列标题名称", text, -1, -1);
                    text2 = Strings.Trim(text2);
                    if (!(String.Compare(text2, text, false) == 0 | String.Compare(text2, "", false) == 0))
                    {
                        bool flag = false;
                        int num = 0;
                        int num2 = this.dgvtoprint.ColumnCount - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            if (String.Compare(this.dgvtoprint.Columns[i].Name, this.curitem, false) != 0)
                            {
                                if (String.Compare(this.dgvtoprint.Columns[i].HeaderText, text2, false) == 0)
                                {
                                    flag = true;
                                IL_DA:
                                    if (flag)
                                    {
                                        Interaction.MsgBox("列标题名称为【" + text2 + "】已经存在，此向导要求列标题名称唯一，因此更改列标题名称失败", MsgBoxStyle.OkOnly, "提示信息");
                                        return;
                                    }
                                    this.dgvtoprint.Columns[this.curitem].HeaderText = text2;
                                    this.C1.Items[this.C1.SelectedIndex] = text2;
                                    return;
                                }
                            }
                        }

                    }
                }
            }
        }

        // Token: 0x0600095D RID: 2397 RVA: 0x000557EC File Offset: 0x000539EC
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                DataGridViewColumn dataGridViewColumn;
                try
                {
                    dataGridViewColumn = this.dgvtoprint.Columns[this.curitem];
                }
                catch (Exception ex)
                {
                    return;
                }
                if (dataGridViewColumn != null && DataTypeConversion.IsNumeric(this.NumericUpDown1.Value) && decimal.Compare(this.NumericUpDown1.Value, 0m) >= 0)
                {
                    try
                    {
                        dataGridViewColumn.Width = checked((int)Math.Round((double)this.myp.ConvertFromMM(Convert.ToSingle(this.NumericUpDown1.Value), true)));
                    }
                    catch (Exception ex2)
                    {
                    }
                    this.ComputerWidth();
                }
            }
        }

        // Token: 0x0600095E RID: 2398 RVA: 0x000558C8 File Offset: 0x00053AC8
        private void Button9_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.FontDialog1.Font = (Font)this.columnfont.Font.Clone();
                if (this.FontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.columnfont.Font = (Font)this.FontDialog1.Font.Clone();
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font = (Font)this.FontDialog1.Font.Clone();
                }
            }
        }

        // Token: 0x0600095F RID: 2399 RVA: 0x00055974 File Offset: 0x00053B74
        private void Button17_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.ColorDialog1.Color = this.headerfont.ForeColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].HeaderCell.Style.ForeColor = this.ColorDialog1.Color;
                    this.headerfont.ForeColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x06000960 RID: 2400 RVA: 0x00055A04 File Offset: 0x00053C04
        private void Button16_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.ColorDialog1.Color = this.headerfont.BackColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].HeaderCell.Style.BackColor = this.ColorDialog1.Color;
                    this.headerfont.BackColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x06000961 RID: 2401 RVA: 0x00055A94 File Offset: 0x00053C94
        private void Button13_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.ColorDialog1.Color = this.columnfont.BackColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor = this.ColorDialog1.Color;
                    this.columnfont.BackColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x06000962 RID: 2402 RVA: 0x00055B1C File Offset: 0x00053D1C
        private void Button12_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.ColorDialog1.Color = this.columnfont.ForeColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor = this.ColorDialog1.Color;
                    this.columnfont.ForeColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x06000963 RID: 2403 RVA: 0x00055BA4 File Offset: 0x00053DA4
        private void Button11_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                this.FontDialog1.Font = (Font)this.headerfont.Font.Clone();
                if (this.FontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.headerfont.Font = (Font)this.FontDialog1.Font.Clone();
                    this.dgvtoprint.Columns[this.curitem].HeaderCell.Style.Font = (Font)this.FontDialog1.Font.Clone();
                }
            }
        }

        // Token: 0x06000964 RID: 2404 RVA: 0x000025D6 File Offset: 0x000007D6
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x06000965 RID: 2405 RVA: 0x00055C54 File Offset: 0x00053E54
        private void Button1_Click(object sender, EventArgs e)
        {
            float num = 1f;
            if (this.zoomtopaper.Checked)
            {
                decimal d;
                if (this.fx1.Checked)
                {
                    d = decimal.Subtract(decimal.Subtract(this.myw.Value, this.printl.Value), this.printr.Value);
                }
                else
                {
                    d = decimal.Subtract(decimal.Subtract(this.myh.Value, this.printl.Value), this.printr.Value);
                }
                if (decimal.Compare(this.GetPrintColumnSumWidth(), 0m) > 0)
                {
                    num = Convert.ToSingle(decimal.Divide(d, this.GetPrintColumnSumWidth()));
                }
            }
            FormDsgn formDsgn = new FormDsgn();
            formDsgn.dgv1 = this.dgvtoprint;
            formDsgn.mycs = this.mycs;
            formDsgn.MbToOpen = this.mbname;
            formDsgn.cd.NewMB(this.dgvtoprint, this.mbname);
            mywait mywait = new mywait();
            mywait.Show();
            Application.DoEvents();
            U_Text u_Text = null;
            U_Field u_Field = null;
            float num2;
            if (String.Compare(Strings.Trim(this.pagetitle.Text), "", false) == 0)
            {
                num2 = 0f;
            }
            else
            {
                num2 = (float)((double)this.pagetitle.Height * 1.4);
            }
            float num3 = Convert.ToSingle(this.colheaderheight.Value);
            float thewidth;
            float num7;
            checked
            {
                if (this.RadioButton1.Checked)
                {
                    formDsgn.cd.SplitContainer3.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.myp.ConvertFromMM(num3, false) + num2)));
                    formDsgn.cd.SplitContainer4.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.myp.ConvertFromMM(Convert.ToSingle(this.rowheight.Value), false) + 1f)));
                }
                else
                {
                    formDsgn.cd.SplitContainer3.SplitterDistance = (int)Math.Round((double)(unchecked(20f + num2)));
                    formDsgn.cd.SplitContainer4.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.myp.ConvertFromMM(Convert.ToSingle(this.jj.Value), false) + this.myp.ConvertFromMM(num3, false) + this.myp.ConvertFromMM(Convert.ToSingle(this.rowheight.Value), false))));
                }
                formDsgn.cd.SplitContainer1.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.myp.ConvertFromMM(Convert.ToSingle(this.printt.Value), false))));
                formDsgn.cd.SplitContainer8.SplitterDistance = (int)Math.Round((double)(unchecked(20f + this.myp.ConvertFromMM(Convert.ToSingle(this.printb.Value), false))));
                formDsgn.cd.SplitContainer5.SplitterDistance = 20;
                formDsgn.cd.SplitContainer6.SplitterDistance = 20;
                formDsgn.cd.SplitContainer7.SplitterDistance = 20;
                if (decimal.Compare(this.NumericUpDown2.Value, 0m) >= 0)
                {
                    formDsgn.cd.myp4.FixedRows = Convert.ToInt32(this.NumericUpDown2.Value);
                }
                formDsgn.cd.myp4.AddEmptyRows = this.emptyrow.Checked;
                float num4 = 0f;
                if (this.rowidadd.Checked)
                {
                    U_Text u_Text2 = new U_Text();
                    u_Text2.Width = (int)Math.Round((double)(unchecked(this.myp.ConvertFromMM(Convert.ToSingle(this.rowid.Value), true) * num)));
                    u_Text2.EHeight = num3;
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextColor = Color.Black;
                    u_Text2.FilledColor = Color.Transparent;
                    u_Text2.TextFont = new Font("宋体", 9f);
                    u_Text2.TextValue = "行号";
                    u_Text2.LeftBorder = true;
                    u_Text2.TopBorder = true;
                    u_Text2.BottomBorder = true;
                    u_Text2.RightBorder = false;
                    u_Text2.Left = (int)Math.Round((double)num4);
                    if (this.RadioButton1.Checked)
                    {
                        u_Text2.Top = (int)Math.Round((double)num2);
                        formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P3, false);
                    }
                    else
                    {
                        u_Text2.Top = 0;
                        formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P4, false);
                    }
                    u_Text2 = new U_Text();
                    u_Text2.Width = (int)Math.Round((double)(unchecked(this.myp.ConvertFromMM(Convert.ToSingle(this.rowid.Value), true) * num)));
                    u_Text2.EHeight = Convert.ToSingle(this.rowheight.Value);
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextColor = Color.Black;
                    u_Text2.FilledColor = Color.Transparent;
                    u_Text2.TextFont = new Font("宋体", 9f);
                    u_Text2.TextValue = Convert.ToString(Interaction.IIf(this.rowidaddnewpage.Checked, "[页行号]", "[行号]"));
                    u_Text2.Mulline = false;
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.LeftBorder = true;
                    u_Text2.RightBorder = false;
                    u_Text2.BottomBorder = true;
                    u_Text2.TopBorder = false;
                    u_Text2.Left = (int)Math.Round((double)num4);
                    if (this.RadioButton1.Checked)
                    {
                        u_Text2.Top = 0;
                    }
                    else
                    {
                        u_Text2.Top = (int)Math.Round((double)this.myp.ConvertFromMM(num3, false));
                    }
                    formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P4, false);
                    u_Text = u_Text2;
                    unchecked
                    {
                        num4 += (float)u_Text2.Width;
                    }
                }
                int num5 = 0;
                int num6 = this.C1.Items.Count - 1;
                for (int i = num5; i <= num6; i++)
                {
                    if (this.C1.GetItemChecked(i))
                    {
                        string itemName = this.GetItemName(Convert.ToString(this.C1.Items[i]));
                        U_Text u_Text2 = new U_Text();
                        u_Text2.Width = (int)Math.Round((double)(unchecked((float)this.dgvtoprint.Columns[itemName].Width * num)));
                        u_Text2.EHeight = num3;
                        u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                        u_Text2.TextColor = Module1.GetDGVColumnHeaderForeColor(this.dgvtoprint, itemName);
                        u_Text2.FilledColor = Module1.GetDGVColumnHeaderBackColor(this.dgvtoprint, itemName);
                        u_Text2.TextFont = Module1.GetDGVColumnHeaderFont(this.dgvtoprint, itemName);
                        u_Text2.TextValue = this.dgvtoprint.Columns[itemName].HeaderText;
                        u_Text2.LeftBorder = true;
                        u_Text2.TopBorder = true;
                        u_Text2.BottomBorder = true;
                        u_Text2.RightBorder = false;
                        u_Text2.Left = (int)Math.Round((double)num4);
                        if (this.RadioButton1.Checked)
                        {
                            u_Text2.Top = (int)Math.Round((double)num2);
                            formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P3, false);
                        }
                        else
                        {
                            u_Text2.Top = 0;
                            formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P4, false);
                        }
                        u_Text = u_Text2;
                        U_Field u_Field2 = new U_Field();
                        u_Field2.Width = (int)Math.Round((double)(unchecked((float)this.dgvtoprint.Columns[itemName].Width * num)));
                        u_Field2.EHeight = Convert.ToSingle(this.rowheight.Value);
                        u_Field2.TextAlign = Module1.GetDGVColumnAlignment(this.dgvtoprint, itemName);
                        u_Field2.TextColor = Module1.GetDGVColumnForeColor(this.dgvtoprint, itemName);
                        u_Field2.FilledColor = Module1.GetDGVColumnBackColor(this.dgvtoprint, itemName);
                        u_Field2.TextFont = Module1.GetDGVColumnFont(this.dgvtoprint, itemName);
                        u_Field2.TextValue = itemName;
                        u_Field2.Mulline = Module1.GetDGVColumnMulLine(this.dgvtoprint, itemName);
                        u_Field2.TextAlign = Module1.GetDGVColumnAlignment(this.dgvtoprint, itemName);
                        u_Field2.LeftBorder = true;
                        u_Field2.RightBorder = false;
                        u_Field2.BottomBorder = true;
                        u_Field2.TopBorder = false;
                        u_Field2.Left = (int)Math.Round((double)num4);
                        if (this.RadioButton1.Checked)
                        {
                            u_Field2.Top = 0;
                        }
                        else
                        {
                            u_Field2.Top = (int)Math.Round((double)this.myp.ConvertFromMM(num3, false));
                        }
                        formDsgn.cd.CS.AddControl(u_Field2, formDsgn.cd.P4, false);
                        u_Field = u_Field2;
                        unchecked
                        {
                            num4 += (float)u_Text2.Width;
                        }
                    }
                }
                if (u_Text != null)
                {
                    u_Text.RightBorder = true;
                }
                if (u_Field != null)
                {
                    u_Field.RightBorder = true;
                }
                if (this.dq1.Checked)
                {
                    formDsgn.cd.MyPage.Align = StringAlignment.Near;
                }
                else if (this.dq2.Checked)
                {
                    formDsgn.cd.MyPage.Align = StringAlignment.Center;
                }
                else if (this.dq3.Checked)
                {
                    formDsgn.cd.MyPage.Align = StringAlignment.Far;
                }
                formDsgn.cd.MyPage.PaperLandScape = this.fx2.Checked;
                formDsgn.cd.MyPage.LeftMargin = Convert.ToSingle(this.printl.Value);
                formDsgn.cd.MyPage.RightMargin = Convert.ToSingle(this.printr.Value);
                formDsgn.cd.MyPage.TopMargin = Convert.ToSingle(this.printt.Value);
                formDsgn.cd.MyPage.BottomMargin = Convert.ToSingle(this.printb.Value);
                formDsgn.cd.MyPage.PaperWidth = Convert.ToSingle(this.myw.Value);
                formDsgn.cd.MyPage.PaperHeight = Convert.ToSingle(this.myh.Value);
                formDsgn.cd.MyPage.PaperName = this.ComboBox1.Text;
                if (String.Compare(this.t1.Text, "", false) != 0)
                {
                    U_Text u_Text2 = new U_Text();
                    u_Text2.Width = (int)Math.Round((double)num4);
                    u_Text2.Height = (int)Math.Round(unchecked((double)formDsgn.cd.P1.Height / 3.0 * 2.0));
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextValue = this.t1.Text;
                    u_Text2.LeftBorder = false;
                    u_Text2.TopBorder = false;
                    u_Text2.BottomBorder = false;
                    u_Text2.RightBorder = false;
                    u_Text2.TextFont = (Font)this.t1.Font.Clone();
                    u_Text2.Left = 0;
                    try
                    {
                        u_Text2.Top = (int)Math.Round((double)(formDsgn.cd.P1.Height - u_Text2.Height) / 2.0);
                    }
                    catch (Exception ex)
                    {
                        u_Text2.Top = 0;
                    }
                    formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P1, false);
                }
                if (String.Compare(this.t2.Text, "", false) != 0)
                {
                    U_Text u_Text2 = new U_Text();
                    formDsgn.cd.SplitContainer2.SplitterDistance = (int)Math.Round(Math.Ceiling(unchecked(20.0 + 1.5 * (double)u_Text2.Height)));
                    u_Text2.Width = (int)Math.Round((double)num4);
                    u_Text2.Height = (int)Math.Round(unchecked((double)formDsgn.cd.P2.Height / 4.0 * 3.0));
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextValue = this.t2.Text;
                    u_Text2.LeftBorder = false;
                    u_Text2.TopBorder = false;
                    u_Text2.BottomBorder = false;
                    u_Text2.RightBorder = false;
                    u_Text2.TextFont = (Font)this.t2.Font.Clone();
                    u_Text2.Left = 0;
                    u_Text2.Top = 0;
                    formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P2, false);
                }
                else
                {
                    formDsgn.cd.SplitContainer2.SplitterDistance = 20;
                }
                if (String.Compare(Strings.Trim(this.pagetitle.Text), "", false) != 0)
                {
                    U_Text u_Text2 = new U_Text();
                    u_Text2.Width = (int)Math.Round((double)num4);
                    u_Text2.Height = this.pagetitle.Height;
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextValue = this.pagetitle.Text;
                    u_Text2.LeftBorder = false;
                    u_Text2.TopBorder = false;
                    u_Text2.BottomBorder = false;
                    u_Text2.RightBorder = false;
                    u_Text2.TextFont = (Font)this.pagetitle.Font.Clone();
                    u_Text2.Left = 0;
                    u_Text2.Top = 0;
                    formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P3, false);
                }
                if (String.Compare(this.t3.Text, "", false) != 0)
                {
                    U_Text u_Text2 = new U_Text();
                    u_Text2.Width = (int)Math.Round((double)num4);
                    u_Text2.TextAlign = ContentAlignment.MiddleCenter;
                    u_Text2.TextValue = this.t3.Text;
                    u_Text2.LeftBorder = false;
                    u_Text2.TopBorder = false;
                    u_Text2.BottomBorder = false;
                    u_Text2.RightBorder = false;
                    u_Text2.TextFont = (Font)this.t3.Font.Clone();
                    u_Text2.Left = 0;
                    u_Text2.Height = (int)Math.Round(unchecked((double)formDsgn.cd.P8.Height / 3.0 * 2.0));
                    try
                    {
                        u_Text2.Top = (int)Math.Round((double)(formDsgn.cd.P8.Height - u_Text2.Height) / 2.0);
                    }
                    catch (Exception ex2)
                    {
                        u_Text2.Top = 0;
                    }
                    formDsgn.cd.CS.AddControl(u_Text2, formDsgn.cd.P8, false);
                }
                thewidth = this.myp.ConvertToMM(unchecked(num4 + 2f), true);
                num7 = (float)(formDsgn.cd.P1.Height + formDsgn.cd.P2.Height + formDsgn.cd.P3.Height + formDsgn.cd.P4.Height);
            }
            num7 = num7 + (float)formDsgn.cd.p5.Height + (float)formDsgn.cd.P6.Height + (float)formDsgn.cd.p7.Height + (float)formDsgn.cd.P8.Height;
            num7 = this.myp.ConvertToMM(num7, false);
            formDsgn.cd.SetMbWidthHeight(thewidth, num7);
            mywait.Close();
            try
            {
                mywait.Dispose();
            }
            catch (Exception ex3)
            {
            }
            string text = formDsgn.cd.SaveMb();
            if (String.Compare(text, "", false) == 0)
            {
                formDsgn.Dispose();
                this.Close();
            }
            else
            {
                formDsgn.Dispose();
                this.Visible = false;
                this.Close();
                FormDsgn formDsgn2 = new FormDsgn();
                formDsgn2.dgv1 = this.dgvtoprint;
                formDsgn2.mycs = this.mycs;
                formDsgn2.MbToOpen = text;
                formDsgn2.ShowDialog(this.ParentForm);
                formDsgn2.Dispose();
            }
        }

        // Token: 0x06000966 RID: 2406 RVA: 0x00056C8C File Offset: 0x00054E8C
        private void ComputerWidth()
        {
            string text = Strings.Format(this.GetPrintColumnSumWidth(), "#,###,###.##");
            text = "表格打印所需要的总宽度【" + text + "毫米】";
            this.Label7.Text = text;
        }

        // Token: 0x06000967 RID: 2407 RVA: 0x00056CCC File Offset: 0x00054ECC
        private decimal GetPrintColumnSumWidth()
        {
            int num = 0;
            checked
            {
                if (this.dgvtoprint != null)
                {
                    try
                    {
                        int num2 = 0;
                        int num3 = this.dgvtoprint.ColumnCount - 1;
                        for (int i = num2; i <= num3; i++)
                        {
                            if (this.dgvtoprint.Columns[i].Visible)
                            {
                                num += this.dgvtoprint.Columns[i].Width;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            decimal result;
            if (this.rowidadd.Checked)
            {
                result = new decimal(this.myp.ConvertToMM((float)num, true) + Convert.ToSingle(this.rowid.Value));
            }
            else
            {
                result = new decimal(this.myp.ConvertToMM((float)num, true));
            }
            return result;
        }

        // Token: 0x06000968 RID: 2408 RVA: 0x00056D9C File Offset: 0x00054F9C
        private void C1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string text = "";
            int num = 0;
            checked
            {
                int num2 = this.colcount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.dgvtoprint.Columns[i].HeaderText, Convert.ToString(this.C1.SelectedItem), false) == 0)
                    {
                        text = this.dgvtoprint.Columns[i].Name;
                    IL_65:
                        if (String.Compare(text, "", false) != 0)
                        {
                            if (e.NewValue == CheckState.Checked)
                            {
                                this.dgvtoprint.Columns[text].Visible = true;
                            }
                            else
                            {
                                this.dgvtoprint.Columns[text].Visible = false;
                            }
                            this.ComputerWidth();
                        }
                        return;
                    }
                }

            }
        }

        // Token: 0x06000969 RID: 2409 RVA: 0x000046B3 File Offset: 0x000028B3
        private void rowid_ValueChanged(object sender, EventArgs e)
        {
            this.ComputerWidth();
        }

        // Token: 0x0600096A RID: 2410 RVA: 0x000046B3 File Offset: 0x000028B3
        private void rowidadd_CheckedChanged(object sender, EventArgs e)
        {
            this.ComputerWidth();
        }

        // Token: 0x040004C9 RID: 1225
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;

        // Token: 0x040004CA RID: 1226
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;

        // Token: 0x040004CB RID: 1227
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;

        // Token: 0x040004CC RID: 1228
        [AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;

        // Token: 0x040004CD RID: 1229
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x040004CE RID: 1230
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x040004CF RID: 1231
        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        // Token: 0x040004D0 RID: 1232
        [AccessedThroughProperty("printb")]
        private NumericUpDown _printb;

        // Token: 0x040004D1 RID: 1233
        [AccessedThroughProperty("printr")]
        private NumericUpDown _printr;

        // Token: 0x040004D2 RID: 1234
        [AccessedThroughProperty("Label14")]
        private Label _Label14;

        // Token: 0x040004D3 RID: 1235
        [AccessedThroughProperty("printt")]
        private NumericUpDown _printt;

        // Token: 0x040004D4 RID: 1236
        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        // Token: 0x040004D5 RID: 1237
        [AccessedThroughProperty("printl")]
        private NumericUpDown _printl;

        // Token: 0x040004D6 RID: 1238
        [AccessedThroughProperty("Label13")]
        private Label _Label13;

        // Token: 0x040004D7 RID: 1239
        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        // Token: 0x040004D8 RID: 1240
        [AccessedThroughProperty("GroupBox4")]
        private GroupBox _GroupBox4;

        // Token: 0x040004D9 RID: 1241
        [AccessedThroughProperty("dq3")]
        private RadioButton _dq3;

        // Token: 0x040004DA RID: 1242
        [AccessedThroughProperty("dq2")]
        private RadioButton _dq2;

        // Token: 0x040004DB RID: 1243
        [AccessedThroughProperty("dq1")]
        private RadioButton _dq1;

        // Token: 0x040004DC RID: 1244
        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        // Token: 0x040004DD RID: 1245
        [AccessedThroughProperty("fx2")]
        private RadioButton _fx2;

        // Token: 0x040004DE RID: 1246
        [AccessedThroughProperty("fx1")]
        private RadioButton _fx1;

        // Token: 0x040004DF RID: 1247
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        // Token: 0x040004E0 RID: 1248
        [AccessedThroughProperty("myh")]
        private NumericUpDown _myh;

        // Token: 0x040004E1 RID: 1249
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;

        // Token: 0x040004E2 RID: 1250
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x040004E3 RID: 1251
        [AccessedThroughProperty("myw")]
        private NumericUpDown _myw;

        // Token: 0x040004E4 RID: 1252
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x040004E5 RID: 1253
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x040004E6 RID: 1254
        [AccessedThroughProperty("C1")]
        private CheckedListBox _C1;

        // Token: 0x040004E7 RID: 1255
        [AccessedThroughProperty("GroupBox10")]
        private GroupBox _GroupBox10;

        // Token: 0x040004E8 RID: 1256
        [AccessedThroughProperty("Button16")]
        private Button _Button16;

        // Token: 0x040004E9 RID: 1257
        [AccessedThroughProperty("Button17")]
        private Button _Button17;

        // Token: 0x040004EA RID: 1258
        [AccessedThroughProperty("headerfont")]
        private Label _headerfont;

        // Token: 0x040004EB RID: 1259
        [AccessedThroughProperty("Button11")]
        private Button _Button11;

        // Token: 0x040004EC RID: 1260
        [AccessedThroughProperty("GroupBox9")]
        private GroupBox _GroupBox9;

        // Token: 0x040004ED RID: 1261
        [AccessedThroughProperty("Button30")]
        private Button _Button30;

        // Token: 0x040004EE RID: 1262
        [AccessedThroughProperty("GroupBox13")]
        private GroupBox _GroupBox13;

        // Token: 0x040004EF RID: 1263
        [AccessedThroughProperty("Button19")]
        private Button _Button19;

        // Token: 0x040004F0 RID: 1264
        [AccessedThroughProperty("Button18")]
        private Button _Button18;

        // Token: 0x040004F1 RID: 1265
        [AccessedThroughProperty("Button13")]
        private Button _Button13;

        // Token: 0x040004F2 RID: 1266
        [AccessedThroughProperty("Button12")]
        private Button _Button12;

        // Token: 0x040004F3 RID: 1267
        [AccessedThroughProperty("columnfont")]
        private Label _columnfont;

        // Token: 0x040004F4 RID: 1268
        [AccessedThroughProperty("Button9")]
        private Button _Button9;

        // Token: 0x040004F5 RID: 1269
        [AccessedThroughProperty("ml")]
        private ComboBox _ml;

        // Token: 0x040004F6 RID: 1270
        [AccessedThroughProperty("ldq")]
        private ComboBox _ldq;

        // Token: 0x040004F7 RID: 1271
        [AccessedThroughProperty("Label27")]
        private Label _Label27;

        // Token: 0x040004F8 RID: 1272
        [AccessedThroughProperty("Label28")]
        private Label _Label28;

        // Token: 0x040004F9 RID: 1273
        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _ColorDialog1;

        // Token: 0x040004FA RID: 1274
        [AccessedThroughProperty("FontDialog1")]
        private FontDialog _FontDialog1;

        // Token: 0x040004FB RID: 1275
        [AccessedThroughProperty("NumericUpDown1")]
        private NumericUpDown _NumericUpDown1;

        // Token: 0x040004FC RID: 1276
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x040004FD RID: 1277
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x040004FE RID: 1278
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x040004FF RID: 1279
        [AccessedThroughProperty("rowheight")]
        private NumericUpDown _rowheight;

        // Token: 0x04000500 RID: 1280
        [AccessedThroughProperty("colheaderheight")]
        private NumericUpDown _colheaderheight;

        // Token: 0x04000501 RID: 1281
        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        // Token: 0x04000502 RID: 1282
        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        // Token: 0x04000503 RID: 1283
        [AccessedThroughProperty("GroupBox5")]
        private GroupBox _GroupBox5;

        // Token: 0x04000504 RID: 1284
        [AccessedThroughProperty("GroupBox14")]
        private GroupBox _GroupBox14;

        // Token: 0x04000505 RID: 1285
        [AccessedThroughProperty("GroupBox7")]
        private GroupBox _GroupBox7;

        // Token: 0x04000506 RID: 1286
        [AccessedThroughProperty("GroupBox6")]
        private GroupBox _GroupBox6;

        // Token: 0x04000507 RID: 1287
        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        // Token: 0x04000508 RID: 1288
        [AccessedThroughProperty("t3")]
        private TextBox _t3;

        // Token: 0x04000509 RID: 1289
        [AccessedThroughProperty("t2")]
        private TextBox _t2;

        // Token: 0x0400050A RID: 1290
        [AccessedThroughProperty("t1")]
        private TextBox _t1;

        // Token: 0x0400050B RID: 1291
        [AccessedThroughProperty("GroupBox8")]
        private GroupBox _GroupBox8;

        // Token: 0x0400050C RID: 1292
        [AccessedThroughProperty("NumericUpDown2")]
        private NumericUpDown _NumericUpDown2;

        // Token: 0x0400050D RID: 1293
        [AccessedThroughProperty("emptyrow")]
        private CheckBox _emptyrow;

        // Token: 0x0400050E RID: 1294
        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        // Token: 0x0400050F RID: 1295
        [AccessedThroughProperty("RadioButton2")]
        private RadioButton _RadioButton2;

        // Token: 0x04000510 RID: 1296
        [AccessedThroughProperty("RadioButton1")]
        private RadioButton _RadioButton1;

        // Token: 0x04000511 RID: 1297
        [AccessedThroughProperty("jj")]
        private NumericUpDown _jj;

        // Token: 0x04000512 RID: 1298
        [AccessedThroughProperty("Label15")]
        private Label _Label15;

        // Token: 0x04000513 RID: 1299
        [AccessedThroughProperty("zoomtopaper")]
        private CheckBox _zoomtopaper;

        // Token: 0x04000514 RID: 1300
        [AccessedThroughProperty("GroupBox11")]
        private GroupBox _GroupBox11;

        // Token: 0x04000515 RID: 1301
        [AccessedThroughProperty("pagetitle")]
        private TextBox _pagetitle;

        // Token: 0x04000516 RID: 1302
        [AccessedThroughProperty("GroupBox12")]
        private GroupBox _GroupBox12;

        // Token: 0x04000517 RID: 1303
        [AccessedThroughProperty("rowidadd")]
        private CheckBox _rowidadd;

        // Token: 0x04000518 RID: 1304
        [AccessedThroughProperty("rowid")]
        private NumericUpDown _rowid;

        // Token: 0x04000519 RID: 1305
        [AccessedThroughProperty("Label16")]
        private Label _Label16;

        // Token: 0x0400051A RID: 1306
        [AccessedThroughProperty("rowidaddnewpage")]
        private CheckBox _rowidaddnewpage;

        // Token: 0x0400051B RID: 1307
        public DataGridView dgvtoprint;

        // Token: 0x0400051C RID: 1308
        public Hashtable mycs;

        // Token: 0x0400051D RID: 1309
        public string mbname;

        // Token: 0x0400051E RID: 1310
        private string curitem;

        // Token: 0x04000520 RID: 1312
        private int colcount;

        // Token: 0x04000521 RID: 1313
        private Ruler myp;
    }
}
