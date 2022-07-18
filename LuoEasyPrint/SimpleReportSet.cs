using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;


namespace LuoEasyPrint
{
    // Token: 0x02000075 RID: 117
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class SimpleReportSet : Form
    {
        // Token: 0x06000EFB RID: 3835 RVA: 0x00078A14 File Offset: 0x00076C14
        public SimpleReportSet()
        {
            base.Disposed += this.SimpleReportSet_Disposed;
            base.Load += this.SimpleReportSet_Load;
            this.CurCol = new ParaseTag();
            this.sp_row = "\u0001\u0005";
            this.sp_col = "\u0003";
            this.myprintername = "";
            this.lastDownTime = DateTime.Now;
            this.InitializeComponent();
        }

        // Token: 0x170004F0 RID: 1264
        // (get) Token: 0x06000EFE RID: 3838 RVA: 0x00082B14 File Offset: 0x00080D14
        // (set) Token: 0x06000EFF RID: 3839 RVA: 0x00005EEA File Offset: 0x000040EA
        internal virtual SplitContainer SplitContainer1
        {
            get
            {
                return this._SplitContainer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SplitContainer1 = value;
            }
        }

        // Token: 0x170004F1 RID: 1265
        // (get) Token: 0x06000F00 RID: 3840 RVA: 0x00082B2C File Offset: 0x00080D2C
        // (set) Token: 0x06000F01 RID: 3841 RVA: 0x00005EF3 File Offset: 0x000040F3
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

        // Token: 0x170004F2 RID: 1266
        // (get) Token: 0x06000F02 RID: 3842 RVA: 0x00082B44 File Offset: 0x00080D44
        // (set) Token: 0x06000F03 RID: 3843 RVA: 0x00005EFC File Offset: 0x000040FC
        internal virtual TabPage TabPage4
        {
            get
            {
                return this._TabPage4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage4 = value;
            }
        }

        // Token: 0x170004F3 RID: 1267
        // (get) Token: 0x06000F04 RID: 3844 RVA: 0x00082B5C File Offset: 0x00080D5C
        // (set) Token: 0x06000F05 RID: 3845 RVA: 0x00005F05 File Offset: 0x00004105
        internal virtual GroupBox GroupBoxpaper
        {
            get
            {
                return this._GroupBoxpaper;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxpaper = value;
            }
        }

        // Token: 0x170004F4 RID: 1268
        // (get) Token: 0x06000F06 RID: 3846 RVA: 0x00082B74 File Offset: 0x00080D74
        // (set) Token: 0x06000F07 RID: 3847 RVA: 0x00005F0E File Offset: 0x0000410E
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

        // Token: 0x170004F5 RID: 1269
        // (get) Token: 0x06000F08 RID: 3848 RVA: 0x00082B8C File Offset: 0x00080D8C
        // (set) Token: 0x06000F09 RID: 3849 RVA: 0x00005F17 File Offset: 0x00004117
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

        // Token: 0x170004F6 RID: 1270
        // (get) Token: 0x06000F0A RID: 3850 RVA: 0x00082BA4 File Offset: 0x00080DA4
        // (set) Token: 0x06000F0B RID: 3851 RVA: 0x00005F20 File Offset: 0x00004120
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

        // Token: 0x170004F7 RID: 1271
        // (get) Token: 0x06000F0C RID: 3852 RVA: 0x00082BBC File Offset: 0x00080DBC
        // (set) Token: 0x06000F0D RID: 3853 RVA: 0x00005F29 File Offset: 0x00004129
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

        // Token: 0x170004F8 RID: 1272
        // (get) Token: 0x06000F0E RID: 3854 RVA: 0x00082BD4 File Offset: 0x00080DD4
        // (set) Token: 0x06000F0F RID: 3855 RVA: 0x00005F32 File Offset: 0x00004132
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

        // Token: 0x170004F9 RID: 1273
        // (get) Token: 0x06000F10 RID: 3856 RVA: 0x00082BEC File Offset: 0x00080DEC
        // (set) Token: 0x06000F11 RID: 3857 RVA: 0x00005F3B File Offset: 0x0000413B
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

        // Token: 0x170004FA RID: 1274
        // (get) Token: 0x06000F12 RID: 3858 RVA: 0x00082C04 File Offset: 0x00080E04
        // (set) Token: 0x06000F13 RID: 3859 RVA: 0x00005F44 File Offset: 0x00004144
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

        // Token: 0x170004FB RID: 1275
        // (get) Token: 0x06000F14 RID: 3860 RVA: 0x00082C1C File Offset: 0x00080E1C
        // (set) Token: 0x06000F15 RID: 3861 RVA: 0x00082C34 File Offset: 0x00080E34
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

        // Token: 0x170004FC RID: 1276
        // (get) Token: 0x06000F16 RID: 3862 RVA: 0x00082C80 File Offset: 0x00080E80
        // (set) Token: 0x06000F17 RID: 3863 RVA: 0x00005F4D File Offset: 0x0000414D
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

        // Token: 0x170004FD RID: 1277
        // (get) Token: 0x06000F18 RID: 3864 RVA: 0x00082C98 File Offset: 0x00080E98
        // (set) Token: 0x06000F19 RID: 3865 RVA: 0x00005F56 File Offset: 0x00004156
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

        // Token: 0x170004FE RID: 1278
        // (get) Token: 0x06000F1A RID: 3866 RVA: 0x00082CB0 File Offset: 0x00080EB0
        // (set) Token: 0x06000F1B RID: 3867 RVA: 0x00005F5F File Offset: 0x0000415F
        internal virtual Label Label50
        {
            get
            {
                return this._Label50;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label50 = value;
            }
        }

        // Token: 0x170004FF RID: 1279
        // (get) Token: 0x06000F1C RID: 3868 RVA: 0x00082CC8 File Offset: 0x00080EC8
        // (set) Token: 0x06000F1D RID: 3869 RVA: 0x00005F68 File Offset: 0x00004168
        internal virtual Label Label49
        {
            get
            {
                return this._Label49;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label49 = value;
            }
        }

        // Token: 0x17000500 RID: 1280
        // (get) Token: 0x06000F1E RID: 3870 RVA: 0x00082CE0 File Offset: 0x00080EE0
        // (set) Token: 0x06000F1F RID: 3871 RVA: 0x00005F71 File Offset: 0x00004171
        internal virtual Label Label48
        {
            get
            {
                return this._Label48;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label48 = value;
            }
        }

        // Token: 0x17000501 RID: 1281
        // (get) Token: 0x06000F20 RID: 3872 RVA: 0x00082CF8 File Offset: 0x00080EF8
        // (set) Token: 0x06000F21 RID: 3873 RVA: 0x00005F7A File Offset: 0x0000417A
        internal virtual Label Label47
        {
            get
            {
                return this._Label47;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label47 = value;
            }
        }

        // Token: 0x17000502 RID: 1282
        // (get) Token: 0x06000F22 RID: 3874 RVA: 0x00082D10 File Offset: 0x00080F10
        // (set) Token: 0x06000F23 RID: 3875 RVA: 0x00005F83 File Offset: 0x00004183
        internal virtual GroupBox GroupBoxwater
        {
            get
            {
                return this._GroupBoxwater;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxwater = value;
            }
        }

        // Token: 0x17000503 RID: 1283
        // (get) Token: 0x06000F24 RID: 3876 RVA: 0x00082D28 File Offset: 0x00080F28
        // (set) Token: 0x06000F25 RID: 3877 RVA: 0x00005F8C File Offset: 0x0000418C
        internal virtual NumericUpDown sytm
        {
            get
            {
                return this._sytm;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sytm = value;
            }
        }

        // Token: 0x17000504 RID: 1284
        // (get) Token: 0x06000F26 RID: 3878 RVA: 0x00082D40 File Offset: 0x00080F40
        // (set) Token: 0x06000F27 RID: 3879 RVA: 0x00082D58 File Offset: 0x00080F58
        internal virtual Button Button27
        {
            get
            {
                return this._Button27;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button27_Click);
                if (this._Button27 != null)
                {
                    this._Button27.Click -= value2;
                }
                this._Button27 = value;
                if (this._Button27 != null)
                {
                    this._Button27.Click += value2;
                }
            }
        }

        // Token: 0x17000505 RID: 1285
        // (get) Token: 0x06000F28 RID: 3880 RVA: 0x00082DA4 File Offset: 0x00080FA4
        // (set) Token: 0x06000F29 RID: 3881 RVA: 0x00005F95 File Offset: 0x00004195
        internal virtual ComboBox syfx
        {
            get
            {
                return this._syfx;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._syfx = value;
            }
        }

        // Token: 0x17000506 RID: 1286
        // (get) Token: 0x06000F2A RID: 3882 RVA: 0x00082DBC File Offset: 0x00080FBC
        // (set) Token: 0x06000F2B RID: 3883 RVA: 0x00005F9E File Offset: 0x0000419E
        internal virtual TextBox sytext
        {
            get
            {
                return this._sytext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sytext = value;
            }
        }

        // Token: 0x17000507 RID: 1287
        // (get) Token: 0x06000F2C RID: 3884 RVA: 0x00082DD4 File Offset: 0x00080FD4
        // (set) Token: 0x06000F2D RID: 3885 RVA: 0x00005FA7 File Offset: 0x000041A7
        internal virtual Label Label52
        {
            get
            {
                return this._Label52;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label52 = value;
            }
        }

        // Token: 0x17000508 RID: 1288
        // (get) Token: 0x06000F2E RID: 3886 RVA: 0x00082DEC File Offset: 0x00080FEC
        // (set) Token: 0x06000F2F RID: 3887 RVA: 0x00005FB0 File Offset: 0x000041B0
        internal virtual Label Label53
        {
            get
            {
                return this._Label53;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label53 = value;
            }
        }

        // Token: 0x17000509 RID: 1289
        // (get) Token: 0x06000F30 RID: 3888 RVA: 0x00082E04 File Offset: 0x00081004
        // (set) Token: 0x06000F31 RID: 3889 RVA: 0x00005FB9 File Offset: 0x000041B9
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

        // Token: 0x1700050A RID: 1290
        // (get) Token: 0x06000F32 RID: 3890 RVA: 0x00082E1C File Offset: 0x0008101C
        // (set) Token: 0x06000F33 RID: 3891 RVA: 0x00005FC2 File Offset: 0x000041C2
        internal virtual GroupBox GroupBox31
        {
            get
            {
                return this._GroupBox31;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox31 = value;
            }
        }

        // Token: 0x1700050B RID: 1291
        // (get) Token: 0x06000F34 RID: 3892 RVA: 0x00082E34 File Offset: 0x00081034
        // (set) Token: 0x06000F35 RID: 3893 RVA: 0x00082E4C File Offset: 0x0008104C
        internal virtual Button linecolor
        {
            get
            {
                return this._linecolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.linecolor_Click);
                if (this._linecolor != null)
                {
                    this._linecolor.Click -= value2;
                }
                this._linecolor = value;
                if (this._linecolor != null)
                {
                    this._linecolor.Click += value2;
                }
            }
        }

        // Token: 0x1700050C RID: 1292
        // (get) Token: 0x06000F36 RID: 3894 RVA: 0x00082E98 File Offset: 0x00081098
        // (set) Token: 0x06000F37 RID: 3895 RVA: 0x00005FCB File Offset: 0x000041CB
        internal virtual Label Label89
        {
            get
            {
                return this._Label89;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label89 = value;
            }
        }

        // Token: 0x1700050D RID: 1293
        // (get) Token: 0x06000F38 RID: 3896 RVA: 0x00082EB0 File Offset: 0x000810B0
        // (set) Token: 0x06000F39 RID: 3897 RVA: 0x00005FD4 File Offset: 0x000041D4
        internal virtual CheckBox gwxouterborder
        {
            get
            {
                return this._gwxouterborder;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gwxouterborder = value;
            }
        }

        // Token: 0x1700050E RID: 1294
        // (get) Token: 0x06000F3A RID: 3898 RVA: 0x00082EC8 File Offset: 0x000810C8
        // (set) Token: 0x06000F3B RID: 3899 RVA: 0x00005FDD File Offset: 0x000041DD
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

        // Token: 0x1700050F RID: 1295
        // (get) Token: 0x06000F3C RID: 3900 RVA: 0x00082EE0 File Offset: 0x000810E0
        // (set) Token: 0x06000F3D RID: 3901 RVA: 0x00005FE6 File Offset: 0x000041E6
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

        // Token: 0x17000510 RID: 1296
        // (get) Token: 0x06000F3E RID: 3902 RVA: 0x00082EF8 File Offset: 0x000810F8
        // (set) Token: 0x06000F3F RID: 3903 RVA: 0x00005FEF File Offset: 0x000041EF
        internal virtual Label Label30
        {
            get
            {
                return this._Label30;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label30 = value;
            }
        }

        // Token: 0x17000511 RID: 1297
        // (get) Token: 0x06000F40 RID: 3904 RVA: 0x00082F10 File Offset: 0x00081110
        // (set) Token: 0x06000F41 RID: 3905 RVA: 0x00005FF8 File Offset: 0x000041F8
        internal virtual Label Label29
        {
            get
            {
                return this._Label29;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label29 = value;
            }
        }

        // Token: 0x17000512 RID: 1298
        // (get) Token: 0x06000F42 RID: 3906 RVA: 0x00082F28 File Offset: 0x00081128
        // (set) Token: 0x06000F43 RID: 3907 RVA: 0x00006001 File Offset: 0x00004201
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

        // Token: 0x17000513 RID: 1299
        // (get) Token: 0x06000F44 RID: 3908 RVA: 0x00082F40 File Offset: 0x00081140
        // (set) Token: 0x06000F45 RID: 3909 RVA: 0x0000600A File Offset: 0x0000420A
        internal virtual Label Label25
        {
            get
            {
                return this._Label25;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label25 = value;
            }
        }

        // Token: 0x17000514 RID: 1300
        // (get) Token: 0x06000F46 RID: 3910 RVA: 0x00082F58 File Offset: 0x00081158
        // (set) Token: 0x06000F47 RID: 3911 RVA: 0x00006013 File Offset: 0x00004213
        internal virtual CheckBox addemptyrow
        {
            get
            {
                return this._addemptyrow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._addemptyrow = value;
            }
        }

        // Token: 0x17000515 RID: 1301
        // (get) Token: 0x06000F48 RID: 3912 RVA: 0x00082F70 File Offset: 0x00081170
        // (set) Token: 0x06000F49 RID: 3913 RVA: 0x0000601C File Offset: 0x0000421C
        internal virtual ComboBox minsize
        {
            get
            {
                return this._minsize;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._minsize = value;
            }
        }

        // Token: 0x17000516 RID: 1302
        // (get) Token: 0x06000F4A RID: 3914 RVA: 0x00082F88 File Offset: 0x00081188
        // (set) Token: 0x06000F4B RID: 3915 RVA: 0x00006025 File Offset: 0x00004225
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

        // Token: 0x17000517 RID: 1303
        // (get) Token: 0x06000F4C RID: 3916 RVA: 0x00082FA0 File Offset: 0x000811A0
        // (set) Token: 0x06000F4D RID: 3917 RVA: 0x0000602E File Offset: 0x0000422E
        internal virtual GroupBox GroupBoxtablestyle
        {
            get
            {
                return this._GroupBoxtablestyle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxtablestyle = value;
            }
        }

        // Token: 0x17000518 RID: 1304
        // (get) Token: 0x06000F4E RID: 3918 RVA: 0x00082FB8 File Offset: 0x000811B8
        // (set) Token: 0x06000F4F RID: 3919 RVA: 0x00006037 File Offset: 0x00004237
        internal virtual GroupBox gz
        {
            get
            {
                return this._gz;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gz = value;
            }
        }

        // Token: 0x17000519 RID: 1305
        // (get) Token: 0x06000F50 RID: 3920 RVA: 0x00082FD0 File Offset: 0x000811D0
        // (set) Token: 0x06000F51 RID: 3921 RVA: 0x00006040 File Offset: 0x00004240
        internal virtual NumericUpDown gzjj
        {
            get
            {
                return this._gzjj;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gzjj = value;
            }
        }

        // Token: 0x1700051A RID: 1306
        // (get) Token: 0x06000F52 RID: 3922 RVA: 0x00082FE8 File Offset: 0x000811E8
        // (set) Token: 0x06000F53 RID: 3923 RVA: 0x00083000 File Offset: 0x00081200
        internal virtual CheckBox gzwrap
        {
            get
            {
                return this._gzwrap;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.gzwrap_CheckedChanged);
                if (this._gzwrap != null)
                {
                    this._gzwrap.CheckedChanged -= value2;
                }
                this._gzwrap = value;
                if (this._gzwrap != null)
                {
                    this._gzwrap.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700051B RID: 1307
        // (get) Token: 0x06000F54 RID: 3924 RVA: 0x0008304C File Offset: 0x0008124C
        // (set) Token: 0x06000F55 RID: 3925 RVA: 0x00083064 File Offset: 0x00081264
        internal virtual CheckBox lz
        {
            get
            {
                return this._lz;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.lz_CheckedChanged);
                if (this._lz != null)
                {
                    this._lz.CheckedChanged -= value2;
                }
                this._lz = value;
                if (this._lz != null)
                {
                    this._lz.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700051C RID: 1308
        // (get) Token: 0x06000F56 RID: 3926 RVA: 0x000830B0 File Offset: 0x000812B0
        // (set) Token: 0x06000F57 RID: 3927 RVA: 0x00006049 File Offset: 0x00004249
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

        // Token: 0x1700051D RID: 1309
        // (get) Token: 0x06000F58 RID: 3928 RVA: 0x000830C8 File Offset: 0x000812C8
        // (set) Token: 0x06000F59 RID: 3929 RVA: 0x000830E0 File Offset: 0x000812E0
        internal virtual RadioButton R4
        {
            get
            {
                return this._R4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R1_CheckedChanged);
                if (this._R4 != null)
                {
                    this._R4.CheckedChanged -= value2;
                }
                this._R4 = value;
                if (this._R4 != null)
                {
                    this._R4.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700051E RID: 1310
        // (get) Token: 0x06000F5A RID: 3930 RVA: 0x0008312C File Offset: 0x0008132C
        // (set) Token: 0x06000F5B RID: 3931 RVA: 0x00083144 File Offset: 0x00081344
        internal virtual RadioButton R3
        {
            get
            {
                return this._R3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R1_CheckedChanged);
                if (this._R3 != null)
                {
                    this._R3.CheckedChanged -= value2;
                }
                this._R3 = value;
                if (this._R3 != null)
                {
                    this._R3.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700051F RID: 1311
        // (get) Token: 0x06000F5C RID: 3932 RVA: 0x00083190 File Offset: 0x00081390
        // (set) Token: 0x06000F5D RID: 3933 RVA: 0x00006052 File Offset: 0x00004252
        internal virtual GroupBox fy
        {
            get
            {
                return this._fy;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._fy = value;
            }
        }

        // Token: 0x17000520 RID: 1312
        // (get) Token: 0x06000F5E RID: 3934 RVA: 0x000831A8 File Offset: 0x000813A8
        // (set) Token: 0x06000F5F RID: 3935 RVA: 0x0000605B File Offset: 0x0000425B
        internal virtual ComboBox columns
        {
            get
            {
                return this._columns;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._columns = value;
            }
        }

        // Token: 0x17000521 RID: 1313
        // (get) Token: 0x06000F60 RID: 3936 RVA: 0x000831C0 File Offset: 0x000813C0
        // (set) Token: 0x06000F61 RID: 3937 RVA: 0x00006064 File Offset: 0x00004264
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

        // Token: 0x17000522 RID: 1314
        // (get) Token: 0x06000F62 RID: 3938 RVA: 0x000831D8 File Offset: 0x000813D8
        // (set) Token: 0x06000F63 RID: 3939 RVA: 0x000831F0 File Offset: 0x000813F0
        internal virtual RadioButton R2
        {
            get
            {
                return this._R2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R1_CheckedChanged);
                if (this._R2 != null)
                {
                    this._R2.CheckedChanged -= value2;
                }
                this._R2 = value;
                if (this._R2 != null)
                {
                    this._R2.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000523 RID: 1315
        // (get) Token: 0x06000F64 RID: 3940 RVA: 0x0008323C File Offset: 0x0008143C
        // (set) Token: 0x06000F65 RID: 3941 RVA: 0x0000606D File Offset: 0x0000426D
        internal virtual GroupBox fl
        {
            get
            {
                return this._fl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._fl = value;
            }
        }

        // Token: 0x17000524 RID: 1316
        // (get) Token: 0x06000F66 RID: 3942 RVA: 0x00083254 File Offset: 0x00081454
        // (set) Token: 0x06000F67 RID: 3943 RVA: 0x00006076 File Offset: 0x00004276
        internal virtual NumericUpDown ljj
        {
            get
            {
                return this._ljj;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ljj = value;
            }
        }

        // Token: 0x17000525 RID: 1317
        // (get) Token: 0x06000F68 RID: 3944 RVA: 0x0008326C File Offset: 0x0008146C
        // (set) Token: 0x06000F69 RID: 3945 RVA: 0x0000607F File Offset: 0x0000427F
        internal virtual ComboBox ls
        {
            get
            {
                return this._ls;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ls = value;
            }
        }

        // Token: 0x17000526 RID: 1318
        // (get) Token: 0x06000F6A RID: 3946 RVA: 0x00083284 File Offset: 0x00081484
        // (set) Token: 0x06000F6B RID: 3947 RVA: 0x00006088 File Offset: 0x00004288
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

        // Token: 0x17000527 RID: 1319
        // (get) Token: 0x06000F6C RID: 3948 RVA: 0x0008329C File Offset: 0x0008149C
        // (set) Token: 0x06000F6D RID: 3949 RVA: 0x00006091 File Offset: 0x00004291
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

        // Token: 0x17000528 RID: 1320
        // (get) Token: 0x06000F6E RID: 3950 RVA: 0x000832B4 File Offset: 0x000814B4
        // (set) Token: 0x06000F6F RID: 3951 RVA: 0x0000609A File Offset: 0x0000429A
        internal virtual GroupBox pt
        {
            get
            {
                return this._pt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pt = value;
            }
        }

        // Token: 0x17000529 RID: 1321
        // (get) Token: 0x06000F70 RID: 3952 RVA: 0x000832CC File Offset: 0x000814CC
        // (set) Token: 0x06000F71 RID: 3953 RVA: 0x000832E4 File Offset: 0x000814E4
        internal virtual RadioButton R1
        {
            get
            {
                return this._R1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R1_CheckedChanged);
                if (this._R1 != null)
                {
                    this._R1.CheckedChanged -= value2;
                }
                this._R1 = value;
                if (this._R1 != null)
                {
                    this._R1.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700052A RID: 1322
        // (get) Token: 0x06000F72 RID: 3954 RVA: 0x00083330 File Offset: 0x00081530
        // (set) Token: 0x06000F73 RID: 3955 RVA: 0x000060A3 File Offset: 0x000042A3
        internal virtual TabPage TabPage5
        {
            get
            {
                return this._TabPage5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage5 = value;
            }
        }

        // Token: 0x1700052B RID: 1323
        // (get) Token: 0x06000F74 RID: 3956 RVA: 0x00083348 File Offset: 0x00081548
        // (set) Token: 0x06000F75 RID: 3957 RVA: 0x000060AC File Offset: 0x000042AC
        internal virtual GroupBox GroupBoxtitle2
        {
            get
            {
                return this._GroupBoxtitle2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxtitle2 = value;
            }
        }

        // Token: 0x1700052C RID: 1324
        // (get) Token: 0x06000F76 RID: 3958 RVA: 0x00083360 File Offset: 0x00081560
        // (set) Token: 0x06000F77 RID: 3959 RVA: 0x000060B5 File Offset: 0x000042B5
        internal virtual GroupBox GroupBoxtitle1
        {
            get
            {
                return this._GroupBoxtitle1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxtitle1 = value;
            }
        }

        // Token: 0x1700052D RID: 1325
        // (get) Token: 0x06000F78 RID: 3960 RVA: 0x00083378 File Offset: 0x00081578
        // (set) Token: 0x06000F79 RID: 3961 RVA: 0x00083390 File Offset: 0x00081590
        internal virtual TextBox maintitle
        {
            get
            {
                return this._maintitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._maintitle != null)
                {
                    this._maintitle.DoubleClick -= value2;
                }
                this._maintitle = value;
                if (this._maintitle != null)
                {
                    this._maintitle.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700052E RID: 1326
        // (get) Token: 0x06000F7A RID: 3962 RVA: 0x000833DC File Offset: 0x000815DC
        // (set) Token: 0x06000F7B RID: 3963 RVA: 0x000060BE File Offset: 0x000042BE
        internal virtual Label Label54
        {
            get
            {
                return this._Label54;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label54 = value;
            }
        }

        // Token: 0x1700052F RID: 1327
        // (get) Token: 0x06000F7C RID: 3964 RVA: 0x000833F4 File Offset: 0x000815F4
        // (set) Token: 0x06000F7D RID: 3965 RVA: 0x0008340C File Offset: 0x0008160C
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

        // Token: 0x17000530 RID: 1328
        // (get) Token: 0x06000F7E RID: 3966 RVA: 0x00083458 File Offset: 0x00081658
        // (set) Token: 0x06000F7F RID: 3967 RVA: 0x000060C7 File Offset: 0x000042C7
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

        // Token: 0x17000531 RID: 1329
        // (get) Token: 0x06000F80 RID: 3968 RVA: 0x00083470 File Offset: 0x00081670
        // (set) Token: 0x06000F81 RID: 3969 RVA: 0x000060D0 File Offset: 0x000042D0
        internal virtual Label Label90
        {
            get
            {
                return this._Label90;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label90 = value;
            }
        }

        // Token: 0x17000532 RID: 1330
        // (get) Token: 0x06000F82 RID: 3970 RVA: 0x00083488 File Offset: 0x00081688
        // (set) Token: 0x06000F83 RID: 3971 RVA: 0x000060D9 File Offset: 0x000042D9
        internal virtual Label Label88
        {
            get
            {
                return this._Label88;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label88 = value;
            }
        }

        // Token: 0x17000533 RID: 1331
        // (get) Token: 0x06000F84 RID: 3972 RVA: 0x000834A0 File Offset: 0x000816A0
        // (set) Token: 0x06000F85 RID: 3973 RVA: 0x000060E2 File Offset: 0x000042E2
        internal virtual GroupBox GroupBoxheader3
        {
            get
            {
                return this._GroupBoxheader3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxheader3 = value;
            }
        }

        // Token: 0x17000534 RID: 1332
        // (get) Token: 0x06000F86 RID: 3974 RVA: 0x000834B8 File Offset: 0x000816B8
        // (set) Token: 0x06000F87 RID: 3975 RVA: 0x000834D0 File Offset: 0x000816D0
        internal virtual Button Button29
        {
            get
            {
                return this._Button29;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button29_Click);
                if (this._Button29 != null)
                {
                    this._Button29.Click -= value2;
                }
                this._Button29 = value;
                if (this._Button29 != null)
                {
                    this._Button29.Click += value2;
                }
            }
        }

        // Token: 0x17000535 RID: 1333
        // (get) Token: 0x06000F88 RID: 3976 RVA: 0x0008351C File Offset: 0x0008171C
        // (set) Token: 0x06000F89 RID: 3977 RVA: 0x00083534 File Offset: 0x00081734
        internal virtual TextBox rightb
        {
            get
            {
                return this._rightb;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._rightb != null)
                {
                    this._rightb.DoubleClick -= value2;
                }
                this._rightb = value;
                if (this._rightb != null)
                {
                    this._rightb.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000536 RID: 1334
        // (get) Token: 0x06000F8A RID: 3978 RVA: 0x00083580 File Offset: 0x00081780
        // (set) Token: 0x06000F8B RID: 3979 RVA: 0x00083598 File Offset: 0x00081798
        internal virtual TextBox rightm
        {
            get
            {
                return this._rightm;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._rightm != null)
                {
                    this._rightm.DoubleClick -= value2;
                }
                this._rightm = value;
                if (this._rightm != null)
                {
                    this._rightm.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000537 RID: 1335
        // (get) Token: 0x06000F8C RID: 3980 RVA: 0x000835E4 File Offset: 0x000817E4
        // (set) Token: 0x06000F8D RID: 3981 RVA: 0x000835FC File Offset: 0x000817FC
        internal virtual TextBox rightt
        {
            get
            {
                return this._rightt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._rightt != null)
                {
                    this._rightt.DoubleClick -= value2;
                }
                this._rightt = value;
                if (this._rightt != null)
                {
                    this._rightt.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000538 RID: 1336
        // (get) Token: 0x06000F8E RID: 3982 RVA: 0x00083648 File Offset: 0x00081848
        // (set) Token: 0x06000F8F RID: 3983 RVA: 0x000060EB File Offset: 0x000042EB
        internal virtual Label Label56
        {
            get
            {
                return this._Label56;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label56 = value;
            }
        }

        // Token: 0x17000539 RID: 1337
        // (get) Token: 0x06000F90 RID: 3984 RVA: 0x00083660 File Offset: 0x00081860
        // (set) Token: 0x06000F91 RID: 3985 RVA: 0x000060F4 File Offset: 0x000042F4
        internal virtual Label Label57
        {
            get
            {
                return this._Label57;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label57 = value;
            }
        }

        // Token: 0x1700053A RID: 1338
        // (get) Token: 0x06000F92 RID: 3986 RVA: 0x00083678 File Offset: 0x00081878
        // (set) Token: 0x06000F93 RID: 3987 RVA: 0x000060FD File Offset: 0x000042FD
        internal virtual Label Label58
        {
            get
            {
                return this._Label58;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label58 = value;
            }
        }

        // Token: 0x1700053B RID: 1339
        // (get) Token: 0x06000F94 RID: 3988 RVA: 0x00083690 File Offset: 0x00081890
        // (set) Token: 0x06000F95 RID: 3989 RVA: 0x00006106 File Offset: 0x00004306
        internal virtual GroupBox GroupBoxheader2
        {
            get
            {
                return this._GroupBoxheader2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxheader2 = value;
            }
        }

        // Token: 0x1700053C RID: 1340
        // (get) Token: 0x06000F96 RID: 3990 RVA: 0x000836A8 File Offset: 0x000818A8
        // (set) Token: 0x06000F97 RID: 3991 RVA: 0x0000610F File Offset: 0x0000430F
        internal virtual CheckBox drawfooter
        {
            get
            {
                return this._drawfooter;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._drawfooter = value;
            }
        }

        // Token: 0x1700053D RID: 1341
        // (get) Token: 0x06000F98 RID: 3992 RVA: 0x000836C0 File Offset: 0x000818C0
        // (set) Token: 0x06000F99 RID: 3993 RVA: 0x000836D8 File Offset: 0x000818D8
        internal virtual Button Button7
        {
            get
            {
                return this._Button7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button7_Click);
                if (this._Button7 != null)
                {
                    this._Button7.Click -= value2;
                }
                this._Button7 = value;
                if (this._Button7 != null)
                {
                    this._Button7.Click += value2;
                }
            }
        }

        // Token: 0x1700053E RID: 1342
        // (get) Token: 0x06000F9A RID: 3994 RVA: 0x00083724 File Offset: 0x00081924
        // (set) Token: 0x06000F9B RID: 3995 RVA: 0x0008373C File Offset: 0x0008193C
        internal virtual TextBox pageright
        {
            get
            {
                return this._pageright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pageright != null)
                {
                    this._pageright.DoubleClick -= value2;
                }
                this._pageright = value;
                if (this._pageright != null)
                {
                    this._pageright.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700053F RID: 1343
        // (get) Token: 0x06000F9C RID: 3996 RVA: 0x00083788 File Offset: 0x00081988
        // (set) Token: 0x06000F9D RID: 3997 RVA: 0x000837A0 File Offset: 0x000819A0
        internal virtual TextBox pagemiddle
        {
            get
            {
                return this._pagemiddle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pagemiddle != null)
                {
                    this._pagemiddle.DoubleClick -= value2;
                }
                this._pagemiddle = value;
                if (this._pagemiddle != null)
                {
                    this._pagemiddle.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000540 RID: 1344
        // (get) Token: 0x06000F9E RID: 3998 RVA: 0x000837EC File Offset: 0x000819EC
        // (set) Token: 0x06000F9F RID: 3999 RVA: 0x00083804 File Offset: 0x00081A04
        internal virtual TextBox pageleft
        {
            get
            {
                return this._pageleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pageleft != null)
                {
                    this._pageleft.DoubleClick -= value2;
                }
                this._pageleft = value;
                if (this._pageleft != null)
                {
                    this._pageleft.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000541 RID: 1345
        // (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00083850 File Offset: 0x00081A50
        // (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00006118 File Offset: 0x00004318
        internal virtual Label Label17
        {
            get
            {
                return this._Label17;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label17 = value;
            }
        }

        // Token: 0x17000542 RID: 1346
        // (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00083868 File Offset: 0x00081A68
        // (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00006121 File Offset: 0x00004321
        internal virtual Label Label18
        {
            get
            {
                return this._Label18;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label18 = value;
            }
        }

        // Token: 0x17000543 RID: 1347
        // (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00083880 File Offset: 0x00081A80
        // (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0000612A File Offset: 0x0000432A
        internal virtual Label Label19
        {
            get
            {
                return this._Label19;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label19 = value;
            }
        }

        // Token: 0x17000544 RID: 1348
        // (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00083898 File Offset: 0x00081A98
        // (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00006133 File Offset: 0x00004333
        internal virtual GroupBox GroupBoxheader1
        {
            get
            {
                return this._GroupBoxheader1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxheader1 = value;
            }
        }

        // Token: 0x17000545 RID: 1349
        // (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000838B0 File Offset: 0x00081AB0
        // (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0000613C File Offset: 0x0000433C
        internal virtual CheckBox drawheader
        {
            get
            {
                return this._drawheader;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._drawheader = value;
            }
        }

        // Token: 0x17000546 RID: 1350
        // (get) Token: 0x06000FAA RID: 4010 RVA: 0x000838C8 File Offset: 0x00081AC8
        // (set) Token: 0x06000FAB RID: 4011 RVA: 0x000838E0 File Offset: 0x00081AE0
        internal virtual Button Button8
        {
            get
            {
                return this._Button8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button8_Click);
                if (this._Button8 != null)
                {
                    this._Button8.Click -= value2;
                }
                this._Button8 = value;
                if (this._Button8 != null)
                {
                    this._Button8.Click += value2;
                }
            }
        }

        // Token: 0x17000547 RID: 1351
        // (get) Token: 0x06000FAC RID: 4012 RVA: 0x0008392C File Offset: 0x00081B2C
        // (set) Token: 0x06000FAD RID: 4013 RVA: 0x00083944 File Offset: 0x00081B44
        internal virtual TextBox pager
        {
            get
            {
                return this._pager;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pager != null)
                {
                    this._pager.DoubleClick -= value2;
                }
                this._pager = value;
                if (this._pager != null)
                {
                    this._pager.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000548 RID: 1352
        // (get) Token: 0x06000FAE RID: 4014 RVA: 0x00083990 File Offset: 0x00081B90
        // (set) Token: 0x06000FAF RID: 4015 RVA: 0x000839A8 File Offset: 0x00081BA8
        internal virtual TextBox pagem
        {
            get
            {
                return this._pagem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pagem != null)
                {
                    this._pagem.DoubleClick -= value2;
                }
                this._pagem = value;
                if (this._pagem != null)
                {
                    this._pagem.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000549 RID: 1353
        // (get) Token: 0x06000FB0 RID: 4016 RVA: 0x000839F4 File Offset: 0x00081BF4
        // (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00083A0C File Offset: 0x00081C0C
        internal virtual TextBox pagel
        {
            get
            {
                return this._pagel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._pagel != null)
                {
                    this._pagel.DoubleClick -= value2;
                }
                this._pagel = value;
                if (this._pagel != null)
                {
                    this._pagel.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700054A RID: 1354
        // (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00083A58 File Offset: 0x00081C58
        // (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00006145 File Offset: 0x00004345
        internal virtual Label Label20
        {
            get
            {
                return this._Label20;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label20 = value;
            }
        }

        // Token: 0x1700054B RID: 1355
        // (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00083A70 File Offset: 0x00081C70
        // (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0000614E File Offset: 0x0000434E
        internal virtual Label Label21
        {
            get
            {
                return this._Label21;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label21 = value;
            }
        }

        // Token: 0x1700054C RID: 1356
        // (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00083A88 File Offset: 0x00081C88
        // (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00006157 File Offset: 0x00004357
        internal virtual Label Label22
        {
            get
            {
                return this._Label22;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label22 = value;
            }
        }

        // Token: 0x1700054D RID: 1357
        // (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00083AA0 File Offset: 0x00081CA0
        // (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00006160 File Offset: 0x00004360
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

        // Token: 0x1700054E RID: 1358
        // (get) Token: 0x06000FBA RID: 4026 RVA: 0x00083AB8 File Offset: 0x00081CB8
        // (set) Token: 0x06000FBB RID: 4027 RVA: 0x00006169 File Offset: 0x00004369
        internal virtual GroupBox GroupBox17
        {
            get
            {
                return this._GroupBox17;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox17 = value;
            }
        }

        // Token: 0x1700054F RID: 1359
        // (get) Token: 0x06000FBC RID: 4028 RVA: 0x00083AD0 File Offset: 0x00081CD0
        // (set) Token: 0x06000FBD RID: 4029 RVA: 0x00083AE8 File Offset: 0x00081CE8
        internal virtual CheckBox Cbackcolor
        {
            get
            {
                return this._Cbackcolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Cbackcolor_CheckedChanged);
                if (this._Cbackcolor != null)
                {
                    this._Cbackcolor.CheckedChanged -= value2;
                }
                this._Cbackcolor = value;
                if (this._Cbackcolor != null)
                {
                    this._Cbackcolor.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000550 RID: 1360
        // (get) Token: 0x06000FBE RID: 4030 RVA: 0x00083B34 File Offset: 0x00081D34
        // (set) Token: 0x06000FBF RID: 4031 RVA: 0x00083B4C File Offset: 0x00081D4C
        internal virtual CheckBox Cforecolor
        {
            get
            {
                return this._Cforecolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Cforecolor_CheckedChanged);
                if (this._Cforecolor != null)
                {
                    this._Cforecolor.CheckedChanged -= value2;
                }
                this._Cforecolor = value;
                if (this._Cforecolor != null)
                {
                    this._Cforecolor.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000551 RID: 1361
        // (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00083B98 File Offset: 0x00081D98
        // (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00083BB0 File Offset: 0x00081DB0
        internal virtual Button bbackcolor
        {
            get
            {
                return this._bbackcolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.bbackcolor_Click);
                if (this._bbackcolor != null)
                {
                    this._bbackcolor.Click -= value2;
                }
                this._bbackcolor = value;
                if (this._bbackcolor != null)
                {
                    this._bbackcolor.Click += value2;
                }
            }
        }

        // Token: 0x17000552 RID: 1362
        // (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00083BFC File Offset: 0x00081DFC
        // (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00006172 File Offset: 0x00004372
        internal virtual Label jsh
        {
            get
            {
                return this._jsh;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._jsh = value;
            }
        }

        // Token: 0x17000553 RID: 1363
        // (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00083C14 File Offset: 0x00081E14
        // (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00083C2C File Offset: 0x00081E2C
        internal virtual Button bforecolor
        {
            get
            {
                return this._bforecolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.bforecolor_Click);
                if (this._bforecolor != null)
                {
                    this._bforecolor.Click -= value2;
                }
                this._bforecolor = value;
                if (this._bforecolor != null)
                {
                    this._bforecolor.Click += value2;
                }
            }
        }

        // Token: 0x17000554 RID: 1364
        // (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00083C78 File Offset: 0x00081E78
        // (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0000617B File Offset: 0x0000437B
        internal virtual GroupBox GroupBoxxx2
        {
            get
            {
                return this._GroupBoxxx2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxxx2 = value;
            }
        }

        // Token: 0x17000555 RID: 1365
        // (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00083C90 File Offset: 0x00081E90
        // (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00083CA8 File Offset: 0x00081EA8
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

        // Token: 0x17000556 RID: 1366
        // (get) Token: 0x06000FCA RID: 4042 RVA: 0x00083CF4 File Offset: 0x00081EF4
        // (set) Token: 0x06000FCB RID: 4043 RVA: 0x00006184 File Offset: 0x00004384
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

        // Token: 0x17000557 RID: 1367
        // (get) Token: 0x06000FCC RID: 4044 RVA: 0x00083D0C File Offset: 0x00081F0C
        // (set) Token: 0x06000FCD RID: 4045 RVA: 0x00083D24 File Offset: 0x00081F24
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

        // Token: 0x17000558 RID: 1368
        // (get) Token: 0x06000FCE RID: 4046 RVA: 0x00083D70 File Offset: 0x00081F70
        // (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000618D File Offset: 0x0000438D
        internal virtual GroupBox GroupBoxxx3
        {
            get
            {
                return this._GroupBoxxx3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxxx3 = value;
            }
        }

        // Token: 0x17000559 RID: 1369
        // (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00083D88 File Offset: 0x00081F88
        // (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00083DA0 File Offset: 0x00081FA0
        internal virtual Button Button15
        {
            get
            {
                return this._Button15;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button15_Click);
                if (this._Button15 != null)
                {
                    this._Button15.Click -= value2;
                }
                this._Button15 = value;
                if (this._Button15 != null)
                {
                    this._Button15.Click += value2;
                }
            }
        }

        // Token: 0x1700055A RID: 1370
        // (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00083DEC File Offset: 0x00081FEC
        // (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00006196 File Offset: 0x00004396
        internal virtual Label cellfont
        {
            get
            {
                return this._cellfont;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cellfont = value;
            }
        }

        // Token: 0x1700055B RID: 1371
        // (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00083E04 File Offset: 0x00082004
        // (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00083E1C File Offset: 0x0008201C
        internal virtual Button Button10
        {
            get
            {
                return this._Button10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button10_Click);
                if (this._Button10 != null)
                {
                    this._Button10.Click -= value2;
                }
                this._Button10 = value;
                if (this._Button10 != null)
                {
                    this._Button10.Click += value2;
                }
            }
        }

        // Token: 0x1700055C RID: 1372
        // (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00083E68 File Offset: 0x00082068
        // (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0000619F File Offset: 0x0000439F
        internal virtual GroupBox GroupBoxformat
        {
            get
            {
                return this._GroupBoxformat;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxformat = value;
            }
        }

        // Token: 0x1700055D RID: 1373
        // (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00083E80 File Offset: 0x00082080
        // (set) Token: 0x06000FD9 RID: 4057 RVA: 0x000061A8 File Offset: 0x000043A8
        internal virtual NumericUpDown colwidth
        {
            get
            {
                return this._colwidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._colwidth = value;
            }
        }

        // Token: 0x1700055E RID: 1374
        // (get) Token: 0x06000FDA RID: 4058 RVA: 0x00083E98 File Offset: 0x00082098
        // (set) Token: 0x06000FDB RID: 4059 RVA: 0x000061B1 File Offset: 0x000043B1
        internal virtual Label Label78
        {
            get
            {
                return this._Label78;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label78 = value;
            }
        }

        // Token: 0x1700055F RID: 1375
        // (get) Token: 0x06000FDC RID: 4060 RVA: 0x00083EB0 File Offset: 0x000820B0
        // (set) Token: 0x06000FDD RID: 4061 RVA: 0x000061BA File Offset: 0x000043BA
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

        // Token: 0x17000560 RID: 1376
        // (get) Token: 0x06000FDE RID: 4062 RVA: 0x00083EC8 File Offset: 0x000820C8
        // (set) Token: 0x06000FDF RID: 4063 RVA: 0x00083EE0 File Offset: 0x000820E0
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

        // Token: 0x17000561 RID: 1377
        // (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00083F2C File Offset: 0x0008212C
        // (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00083F44 File Offset: 0x00082144
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

        // Token: 0x17000562 RID: 1378
        // (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00083F90 File Offset: 0x00082190
        // (set) Token: 0x06000FE3 RID: 4067 RVA: 0x000061C3 File Offset: 0x000043C3
        internal virtual ComboBox halg
        {
            get
            {
                return this._halg;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._halg = value;
            }
        }

        // Token: 0x17000563 RID: 1379
        // (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00083FA8 File Offset: 0x000821A8
        // (set) Token: 0x06000FE5 RID: 4069 RVA: 0x000061CC File Offset: 0x000043CC
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

        // Token: 0x17000564 RID: 1380
        // (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00083FC0 File Offset: 0x000821C0
        // (set) Token: 0x06000FE7 RID: 4071 RVA: 0x000061D5 File Offset: 0x000043D5
        internal virtual TabPage TabPage8
        {
            get
            {
                return this._TabPage8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage8 = value;
            }
        }

        // Token: 0x17000565 RID: 1381
        // (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00083FD8 File Offset: 0x000821D8
        // (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000061DE File Offset: 0x000043DE
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

        // Token: 0x17000566 RID: 1382
        // (get) Token: 0x06000FEA RID: 4074 RVA: 0x00083FF0 File Offset: 0x000821F0
        // (set) Token: 0x06000FEB RID: 4075 RVA: 0x000061E7 File Offset: 0x000043E7
        internal virtual NumericUpDown reportfooterspace
        {
            get
            {
                return this._reportfooterspace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._reportfooterspace = value;
            }
        }

        // Token: 0x17000567 RID: 1383
        // (get) Token: 0x06000FEC RID: 4076 RVA: 0x00084008 File Offset: 0x00082208
        // (set) Token: 0x06000FED RID: 4077 RVA: 0x000061F0 File Offset: 0x000043F0
        internal virtual Label Label35
        {
            get
            {
                return this._Label35;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label35 = value;
            }
        }

        // Token: 0x17000568 RID: 1384
        // (get) Token: 0x06000FEE RID: 4078 RVA: 0x00084020 File Offset: 0x00082220
        // (set) Token: 0x06000FEF RID: 4079 RVA: 0x00084038 File Offset: 0x00082238
        internal virtual Button reportfooterfont
        {
            get
            {
                return this._reportfooterfont;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportfooterfont_Click);
                if (this._reportfooterfont != null)
                {
                    this._reportfooterfont.Click -= value2;
                }
                this._reportfooterfont = value;
                if (this._reportfooterfont != null)
                {
                    this._reportfooterfont.Click += value2;
                }
            }
        }

        // Token: 0x17000569 RID: 1385
        // (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00084084 File Offset: 0x00082284
        // (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0008409C File Offset: 0x0008229C
        internal virtual TextBox reportfootertext
        {
            get
            {
                return this._reportfootertext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._reportfootertext != null)
                {
                    this._reportfootertext.DoubleClick -= value2;
                }
                this._reportfootertext = value;
                if (this._reportfootertext != null)
                {
                    this._reportfootertext.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700056A RID: 1386
        // (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000840E8 File Offset: 0x000822E8
        // (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000061F9 File Offset: 0x000043F9
        internal virtual Label Label36
        {
            get
            {
                return this._Label36;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label36 = value;
            }
        }

        // Token: 0x1700056B RID: 1387
        // (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00084100 File Offset: 0x00082300
        // (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00006202 File Offset: 0x00004402
        internal virtual Label Label37
        {
            get
            {
                return this._Label37;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label37 = value;
            }
        }

        // Token: 0x1700056C RID: 1388
        // (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00084118 File Offset: 0x00082318
        // (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0000620B File Offset: 0x0000440B
        internal virtual Label Label38
        {
            get
            {
                return this._Label38;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label38 = value;
            }
        }

        // Token: 0x1700056D RID: 1389
        // (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00084130 File Offset: 0x00082330
        // (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00084148 File Offset: 0x00082348
        internal virtual ComboBox reportfooteralignment
        {
            get
            {
                return this._reportfooteralignment;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportfooteralignment_SelectedIndexChanged);
                if (this._reportfooteralignment != null)
                {
                    this._reportfooteralignment.SelectedIndexChanged -= value2;
                }
                this._reportfooteralignment = value;
                if (this._reportfooteralignment != null)
                {
                    this._reportfooteralignment.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x1700056E RID: 1390
        // (get) Token: 0x06000FFA RID: 4090 RVA: 0x00084194 File Offset: 0x00082394
        // (set) Token: 0x06000FFB RID: 4091 RVA: 0x00006214 File Offset: 0x00004414
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

        // Token: 0x1700056F RID: 1391
        // (get) Token: 0x06000FFC RID: 4092 RVA: 0x000841AC File Offset: 0x000823AC
        // (set) Token: 0x06000FFD RID: 4093 RVA: 0x0000621D File Offset: 0x0000441D
        internal virtual NumericUpDown reportheaderspace
        {
            get
            {
                return this._reportheaderspace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._reportheaderspace = value;
            }
        }

        // Token: 0x17000570 RID: 1392
        // (get) Token: 0x06000FFE RID: 4094 RVA: 0x000841C4 File Offset: 0x000823C4
        // (set) Token: 0x06000FFF RID: 4095 RVA: 0x00006226 File Offset: 0x00004426
        internal virtual Label Label34
        {
            get
            {
                return this._Label34;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label34 = value;
            }
        }

        // Token: 0x17000571 RID: 1393
        // (get) Token: 0x06001000 RID: 4096 RVA: 0x000841DC File Offset: 0x000823DC
        // (set) Token: 0x06001001 RID: 4097 RVA: 0x000841F4 File Offset: 0x000823F4
        internal virtual Button reportheaderfont
        {
            get
            {
                return this._reportheaderfont;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheaderfont_Click);
                if (this._reportheaderfont != null)
                {
                    this._reportheaderfont.Click -= value2;
                }
                this._reportheaderfont = value;
                if (this._reportheaderfont != null)
                {
                    this._reportheaderfont.Click += value2;
                }
            }
        }

        // Token: 0x17000572 RID: 1394
        // (get) Token: 0x06001002 RID: 4098 RVA: 0x00084240 File Offset: 0x00082440
        // (set) Token: 0x06001003 RID: 4099 RVA: 0x00084258 File Offset: 0x00082458
        internal virtual TextBox reportheadertext
        {
            get
            {
                return this._reportheadertext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._reportheadertext != null)
                {
                    this._reportheadertext.DoubleClick -= value2;
                }
                this._reportheadertext = value;
                if (this._reportheadertext != null)
                {
                    this._reportheadertext.DoubleClick += value2;
                }
            }
        }

        // Token: 0x17000573 RID: 1395
        // (get) Token: 0x06001004 RID: 4100 RVA: 0x000842A4 File Offset: 0x000824A4
        // (set) Token: 0x06001005 RID: 4101 RVA: 0x0000622F File Offset: 0x0000442F
        internal virtual Label Label33
        {
            get
            {
                return this._Label33;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label33 = value;
            }
        }

        // Token: 0x17000574 RID: 1396
        // (get) Token: 0x06001006 RID: 4102 RVA: 0x000842BC File Offset: 0x000824BC
        // (set) Token: 0x06001007 RID: 4103 RVA: 0x00006238 File Offset: 0x00004438
        internal virtual Label Label32
        {
            get
            {
                return this._Label32;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label32 = value;
            }
        }

        // Token: 0x17000575 RID: 1397
        // (get) Token: 0x06001008 RID: 4104 RVA: 0x000842D4 File Offset: 0x000824D4
        // (set) Token: 0x06001009 RID: 4105 RVA: 0x00006241 File Offset: 0x00004441
        internal virtual Label Label31
        {
            get
            {
                return this._Label31;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label31 = value;
            }
        }

        // Token: 0x17000576 RID: 1398
        // (get) Token: 0x0600100A RID: 4106 RVA: 0x000842EC File Offset: 0x000824EC
        // (set) Token: 0x0600100B RID: 4107 RVA: 0x00084304 File Offset: 0x00082504
        internal virtual ComboBox reportheaderalignment
        {
            get
            {
                return this._reportheaderalignment;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheaderalignment_SelectedIndexChanged);
                if (this._reportheaderalignment != null)
                {
                    this._reportheaderalignment.SelectedIndexChanged -= value2;
                }
                this._reportheaderalignment = value;
                if (this._reportheaderalignment != null)
                {
                    this._reportheaderalignment.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000577 RID: 1399
        // (get) Token: 0x0600100C RID: 4108 RVA: 0x00084350 File Offset: 0x00082550
        // (set) Token: 0x0600100D RID: 4109 RVA: 0x0000624A File Offset: 0x0000444A
        internal virtual TabPage TabPage7
        {
            get
            {
                return this._TabPage7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage7 = value;
            }
        }

        // Token: 0x17000578 RID: 1400
        // (get) Token: 0x0600100E RID: 4110 RVA: 0x00084368 File Offset: 0x00082568
        // (set) Token: 0x0600100F RID: 4111 RVA: 0x00006253 File Offset: 0x00004453
        internal virtual GroupBox GroupBoxZDX
        {
            get
            {
                return this._GroupBoxZDX;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxZDX = value;
            }
        }

        // Token: 0x17000579 RID: 1401
        // (get) Token: 0x06001010 RID: 4112 RVA: 0x00084380 File Offset: 0x00082580
        // (set) Token: 0x06001011 RID: 4113 RVA: 0x0000625C File Offset: 0x0000445C
        internal virtual GroupBox GroupBoxzdx3
        {
            get
            {
                return this._GroupBoxzdx3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxzdx3 = value;
            }
        }

        // Token: 0x1700057A RID: 1402
        // (get) Token: 0x06001012 RID: 4114 RVA: 0x00084398 File Offset: 0x00082598
        // (set) Token: 0x06001013 RID: 4115 RVA: 0x000843B0 File Offset: 0x000825B0
        internal virtual Button zdxlinecolor
        {
            get
            {
                return this._zdxlinecolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.zdxlinecolor_Click);
                if (this._zdxlinecolor != null)
                {
                    this._zdxlinecolor.Click -= value2;
                }
                this._zdxlinecolor = value;
                if (this._zdxlinecolor != null)
                {
                    this._zdxlinecolor.Click += value2;
                }
            }
        }

        // Token: 0x1700057B RID: 1403
        // (get) Token: 0x06001014 RID: 4116 RVA: 0x000843FC File Offset: 0x000825FC
        // (set) Token: 0x06001015 RID: 4117 RVA: 0x00006265 File Offset: 0x00004465
        internal virtual RadioButton zdx_dashdotdot
        {
            get
            {
                return this._zdx_dashdotdot;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdx_dashdotdot = value;
            }
        }

        // Token: 0x1700057C RID: 1404
        // (get) Token: 0x06001016 RID: 4118 RVA: 0x00084414 File Offset: 0x00082614
        // (set) Token: 0x06001017 RID: 4119 RVA: 0x0000626E File Offset: 0x0000446E
        internal virtual RadioButton zdx_dashdot
        {
            get
            {
                return this._zdx_dashdot;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdx_dashdot = value;
            }
        }

        // Token: 0x1700057D RID: 1405
        // (get) Token: 0x06001018 RID: 4120 RVA: 0x0008442C File Offset: 0x0008262C
        // (set) Token: 0x06001019 RID: 4121 RVA: 0x00006277 File Offset: 0x00004477
        internal virtual RadioButton zdx_dot
        {
            get
            {
                return this._zdx_dot;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdx_dot = value;
            }
        }

        // Token: 0x1700057E RID: 1406
        // (get) Token: 0x0600101A RID: 4122 RVA: 0x00084444 File Offset: 0x00082644
        // (set) Token: 0x0600101B RID: 4123 RVA: 0x00006280 File Offset: 0x00004480
        internal virtual RadioButton zdx_dash
        {
            get
            {
                return this._zdx_dash;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdx_dash = value;
            }
        }

        // Token: 0x1700057F RID: 1407
        // (get) Token: 0x0600101C RID: 4124 RVA: 0x0008445C File Offset: 0x0008265C
        // (set) Token: 0x0600101D RID: 4125 RVA: 0x00006289 File Offset: 0x00004489
        internal virtual RadioButton zdx_solid
        {
            get
            {
                return this._zdx_solid;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdx_solid = value;
            }
        }

        // Token: 0x17000580 RID: 1408
        // (get) Token: 0x0600101E RID: 4126 RVA: 0x00084474 File Offset: 0x00082674
        // (set) Token: 0x0600101F RID: 4127 RVA: 0x00006292 File Offset: 0x00004492
        internal virtual GroupBox GroupBoxzdx2
        {
            get
            {
                return this._GroupBoxzdx2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxzdx2 = value;
            }
        }

        // Token: 0x17000581 RID: 1409
        // (get) Token: 0x06001020 RID: 4128 RVA: 0x0008448C File Offset: 0x0008268C
        // (set) Token: 0x06001021 RID: 4129 RVA: 0x0000629B File Offset: 0x0000449B
        internal virtual TextBox zdxtext
        {
            get
            {
                return this._zdxtext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxtext = value;
            }
        }

        // Token: 0x17000582 RID: 1410
        // (get) Token: 0x06001022 RID: 4130 RVA: 0x000844A4 File Offset: 0x000826A4
        // (set) Token: 0x06001023 RID: 4131 RVA: 0x000844BC File Offset: 0x000826BC
        internal virtual Button Button37
        {
            get
            {
                return this._Button37;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button37_Click);
                if (this._Button37 != null)
                {
                    this._Button37.Click -= value2;
                }
                this._Button37 = value;
                if (this._Button37 != null)
                {
                    this._Button37.Click += value2;
                }
            }
        }

        // Token: 0x17000583 RID: 1411
        // (get) Token: 0x06001024 RID: 4132 RVA: 0x00084508 File Offset: 0x00082708
        // (set) Token: 0x06001025 RID: 4133 RVA: 0x000062A4 File Offset: 0x000044A4
        internal virtual GroupBox GroupBoxzdx1
        {
            get
            {
                return this._GroupBoxzdx1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxzdx1 = value;
            }
        }

        // Token: 0x17000584 RID: 1412
        // (get) Token: 0x06001026 RID: 4134 RVA: 0x00084520 File Offset: 0x00082720
        // (set) Token: 0x06001027 RID: 4135 RVA: 0x000062AD File Offset: 0x000044AD
        internal virtual RadioButton zdxtype_bottom
        {
            get
            {
                return this._zdxtype_bottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxtype_bottom = value;
            }
        }

        // Token: 0x17000585 RID: 1413
        // (get) Token: 0x06001028 RID: 4136 RVA: 0x00084538 File Offset: 0x00082738
        // (set) Token: 0x06001029 RID: 4137 RVA: 0x000062B6 File Offset: 0x000044B6
        internal virtual RadioButton zdxtype_right
        {
            get
            {
                return this._zdxtype_right;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxtype_right = value;
            }
        }

        // Token: 0x17000586 RID: 1414
        // (get) Token: 0x0600102A RID: 4138 RVA: 0x00084550 File Offset: 0x00082750
        // (set) Token: 0x0600102B RID: 4139 RVA: 0x000062BF File Offset: 0x000044BF
        internal virtual RadioButton zdxtype_top
        {
            get
            {
                return this._zdxtype_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxtype_top = value;
            }
        }

        // Token: 0x17000587 RID: 1415
        // (get) Token: 0x0600102C RID: 4140 RVA: 0x00084568 File Offset: 0x00082768
        // (set) Token: 0x0600102D RID: 4141 RVA: 0x000062C8 File Offset: 0x000044C8
        internal virtual RadioButton zdxtype_left
        {
            get
            {
                return this._zdxtype_left;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxtype_left = value;
            }
        }

        // Token: 0x17000588 RID: 1416
        // (get) Token: 0x0600102E RID: 4142 RVA: 0x00084580 File Offset: 0x00082780
        // (set) Token: 0x0600102F RID: 4143 RVA: 0x000062D1 File Offset: 0x000044D1
        internal virtual Label Label83
        {
            get
            {
                return this._Label83;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label83 = value;
            }
        }

        // Token: 0x17000589 RID: 1417
        // (get) Token: 0x06001030 RID: 4144 RVA: 0x00084598 File Offset: 0x00082798
        // (set) Token: 0x06001031 RID: 4145 RVA: 0x000845B0 File Offset: 0x000827B0
        internal virtual CheckBox isdrawzdx
        {
            get
            {
                return this._isdrawzdx;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.isdrawzdx_CheckedChanged);
                if (this._isdrawzdx != null)
                {
                    this._isdrawzdx.CheckedChanged -= value2;
                }
                this._isdrawzdx = value;
                if (this._isdrawzdx != null)
                {
                    this._isdrawzdx.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x1700058A RID: 1418
        // (get) Token: 0x06001032 RID: 4146 RVA: 0x000845FC File Offset: 0x000827FC
        // (set) Token: 0x06001033 RID: 4147 RVA: 0x000062DA File Offset: 0x000044DA
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

        // Token: 0x1700058B RID: 1419
        // (get) Token: 0x06001034 RID: 4148 RVA: 0x00084614 File Offset: 0x00082814
        // (set) Token: 0x06001035 RID: 4149 RVA: 0x000062E3 File Offset: 0x000044E3
        internal virtual NumericUpDown tablefooterheight
        {
            get
            {
                return this._tablefooterheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tablefooterheight = value;
            }
        }

        // Token: 0x1700058C RID: 1420
        // (get) Token: 0x06001036 RID: 4150 RVA: 0x0008462C File Offset: 0x0008282C
        // (set) Token: 0x06001037 RID: 4151 RVA: 0x000062EC File Offset: 0x000044EC
        internal virtual Label Label11
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

        // Token: 0x1700058D RID: 1421
        // (get) Token: 0x06001038 RID: 4152 RVA: 0x00084644 File Offset: 0x00082844
        // (set) Token: 0x06001039 RID: 4153 RVA: 0x0008465C File Offset: 0x0008285C
        internal virtual DataGridView d2
        {
            get
            {
                return this._d2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.d2_DoubleClick);
                if (this._d2 != null)
                {
                    this._d2.DoubleClick -= value2;
                }
                this._d2 = value;
                if (this._d2 != null)
                {
                    this._d2.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700058E RID: 1422
        // (get) Token: 0x0600103A RID: 4154 RVA: 0x000846A8 File Offset: 0x000828A8
        // (set) Token: 0x0600103B RID: 4155 RVA: 0x000062F5 File Offset: 0x000044F5
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
        {
            get
            {
                return this._DataGridViewTextBoxColumn1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn1 = value;
            }
        }

        // Token: 0x1700058F RID: 1423
        // (get) Token: 0x0600103C RID: 4156 RVA: 0x000846C0 File Offset: 0x000828C0
        // (set) Token: 0x0600103D RID: 4157 RVA: 0x000062FE File Offset: 0x000044FE
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
        {
            get
            {
                return this._DataGridViewTextBoxColumn2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn2 = value;
            }
        }

        // Token: 0x17000590 RID: 1424
        // (get) Token: 0x0600103E RID: 4158 RVA: 0x000846D8 File Offset: 0x000828D8
        // (set) Token: 0x0600103F RID: 4159 RVA: 0x00006307 File Offset: 0x00004507
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
        {
            get
            {
                return this._DataGridViewTextBoxColumn3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn3 = value;
            }
        }

        // Token: 0x17000591 RID: 1425
        // (get) Token: 0x06001040 RID: 4160 RVA: 0x000846F0 File Offset: 0x000828F0
        // (set) Token: 0x06001041 RID: 4161 RVA: 0x00006310 File Offset: 0x00004510
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
        {
            get
            {
                return this._DataGridViewTextBoxColumn4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn4 = value;
            }
        }

        // Token: 0x17000592 RID: 1426
        // (get) Token: 0x06001042 RID: 4162 RVA: 0x00084708 File Offset: 0x00082908
        // (set) Token: 0x06001043 RID: 4163 RVA: 0x00006319 File Offset: 0x00004519
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
        {
            get
            {
                return this._DataGridViewTextBoxColumn5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn5 = value;
            }
        }

        // Token: 0x17000593 RID: 1427
        // (get) Token: 0x06001044 RID: 4164 RVA: 0x00084720 File Offset: 0x00082920
        // (set) Token: 0x06001045 RID: 4165 RVA: 0x00006322 File Offset: 0x00004522
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
        {
            get
            {
                return this._DataGridViewTextBoxColumn6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn6 = value;
            }
        }

        // Token: 0x17000594 RID: 1428
        // (get) Token: 0x06001046 RID: 4166 RVA: 0x00084738 File Offset: 0x00082938
        // (set) Token: 0x06001047 RID: 4167 RVA: 0x0000632B File Offset: 0x0000452B
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
        {
            get
            {
                return this._DataGridViewTextBoxColumn7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._DataGridViewTextBoxColumn7 = value;
            }
        }

        // Token: 0x17000595 RID: 1429
        // (get) Token: 0x06001048 RID: 4168 RVA: 0x00084750 File Offset: 0x00082950
        // (set) Token: 0x06001049 RID: 4169 RVA: 0x00006334 File Offset: 0x00004534
        internal virtual CheckBox tablefooterprinteverypage
        {
            get
            {
                return this._tablefooterprinteverypage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tablefooterprinteverypage = value;
            }
        }

        // Token: 0x17000596 RID: 1430
        // (get) Token: 0x0600104A RID: 4170 RVA: 0x00084768 File Offset: 0x00082968
        // (set) Token: 0x0600104B RID: 4171 RVA: 0x00084780 File Offset: 0x00082980
        internal virtual Button Button5
        {
            get
            {
                return this._Button5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button5_Click);
                if (this._Button5 != null)
                {
                    this._Button5.Click -= value2;
                }
                this._Button5 = value;
                if (this._Button5 != null)
                {
                    this._Button5.Click += value2;
                }
            }
        }

        // Token: 0x17000597 RID: 1431
        // (get) Token: 0x0600104C RID: 4172 RVA: 0x000847CC File Offset: 0x000829CC
        // (set) Token: 0x0600104D RID: 4173 RVA: 0x000847E4 File Offset: 0x000829E4
        internal virtual Button Button6
        {
            get
            {
                return this._Button6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button6_Click);
                if (this._Button6 != null)
                {
                    this._Button6.Click -= value2;
                }
                this._Button6 = value;
                if (this._Button6 != null)
                {
                    this._Button6.Click += value2;
                }
            }
        }

        // Token: 0x17000598 RID: 1432
        // (get) Token: 0x0600104E RID: 4174 RVA: 0x00084830 File Offset: 0x00082A30
        // (set) Token: 0x0600104F RID: 4175 RVA: 0x00084848 File Offset: 0x00082A48
        internal virtual Button Button24
        {
            get
            {
                return this._Button24;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button24_Click);
                if (this._Button24 != null)
                {
                    this._Button24.Click -= value2;
                }
                this._Button24 = value;
                if (this._Button24 != null)
                {
                    this._Button24.Click += value2;
                }
            }
        }

        // Token: 0x17000599 RID: 1433
        // (get) Token: 0x06001050 RID: 4176 RVA: 0x00084894 File Offset: 0x00082A94
        // (set) Token: 0x06001051 RID: 4177 RVA: 0x0000633D File Offset: 0x0000453D
        internal virtual NumericUpDown subtitleheight
        {
            get
            {
                return this._subtitleheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._subtitleheight = value;
            }
        }

        // Token: 0x1700059A RID: 1434
        // (get) Token: 0x06001052 RID: 4178 RVA: 0x000848AC File Offset: 0x00082AAC
        // (set) Token: 0x06001053 RID: 4179 RVA: 0x00006346 File Offset: 0x00004546
        internal virtual Label Label41
        {
            get
            {
                return this._Label41;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label41 = value;
            }
        }

        // Token: 0x1700059B RID: 1435
        // (get) Token: 0x06001054 RID: 4180 RVA: 0x000848C4 File Offset: 0x00082AC4
        // (set) Token: 0x06001055 RID: 4181 RVA: 0x000848DC File Offset: 0x00082ADC
        internal virtual DataGridView d1
        {
            get
            {
                return this._d1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.d1_DoubleClick);
                if (this._d1 != null)
                {
                    this._d1.DoubleClick -= value2;
                }
                this._d1 = value;
                if (this._d1 != null)
                {
                    this._d1.DoubleClick += value2;
                }
            }
        }

        // Token: 0x1700059C RID: 1436
        // (get) Token: 0x06001056 RID: 4182 RVA: 0x00084928 File Offset: 0x00082B28
        // (set) Token: 0x06001057 RID: 4183 RVA: 0x0000634F File Offset: 0x0000454F
        internal virtual CheckBox subtitlepritneverypage
        {
            get
            {
                return this._subtitlepritneverypage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._subtitlepritneverypage = value;
            }
        }

        // Token: 0x1700059D RID: 1437
        // (get) Token: 0x06001058 RID: 4184 RVA: 0x00084940 File Offset: 0x00082B40
        // (set) Token: 0x06001059 RID: 4185 RVA: 0x00084958 File Offset: 0x00082B58
        internal virtual Button Button4
        {
            get
            {
                return this._Button4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button4_Click);
                if (this._Button4 != null)
                {
                    this._Button4.Click -= value2;
                }
                this._Button4 = value;
                if (this._Button4 != null)
                {
                    this._Button4.Click += value2;
                }
            }
        }

        // Token: 0x1700059E RID: 1438
        // (get) Token: 0x0600105A RID: 4186 RVA: 0x000849A4 File Offset: 0x00082BA4
        // (set) Token: 0x0600105B RID: 4187 RVA: 0x000849BC File Offset: 0x00082BBC
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

        // Token: 0x1700059F RID: 1439
        // (get) Token: 0x0600105C RID: 4188 RVA: 0x00084A08 File Offset: 0x00082C08
        // (set) Token: 0x0600105D RID: 4189 RVA: 0x00084A20 File Offset: 0x00082C20
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

        // Token: 0x170005A0 RID: 1440
        // (get) Token: 0x0600105E RID: 4190 RVA: 0x00084A6C File Offset: 0x00082C6C
        // (set) Token: 0x0600105F RID: 4191 RVA: 0x00006358 File Offset: 0x00004558
        internal virtual NumericUpDown maintitleheight
        {
            get
            {
                return this._maintitleheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._maintitleheight = value;
            }
        }

        // Token: 0x170005A1 RID: 1441
        // (get) Token: 0x06001060 RID: 4192 RVA: 0x00084A84 File Offset: 0x00082C84
        // (set) Token: 0x06001061 RID: 4193 RVA: 0x00006361 File Offset: 0x00004561
        internal virtual Label Label40
        {
            get
            {
                return this._Label40;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label40 = value;
            }
        }

        // Token: 0x170005A2 RID: 1442
        // (get) Token: 0x06001062 RID: 4194 RVA: 0x00084A9C File Offset: 0x00082C9C
        // (set) Token: 0x06001063 RID: 4195 RVA: 0x0000636A File Offset: 0x0000456A
        internal virtual CheckBox maintitleprinteverpage
        {
            get
            {
                return this._maintitleprinteverpage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._maintitleprinteverpage = value;
            }
        }

        // Token: 0x170005A3 RID: 1443
        // (get) Token: 0x06001064 RID: 4196 RVA: 0x00084AB4 File Offset: 0x00082CB4
        // (set) Token: 0x06001065 RID: 4197 RVA: 0x00084ACC File Offset: 0x00082CCC
        internal virtual ComboBox maintitlealign
        {
            get
            {
                return this._maintitlealign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.maintitlealign_SelectedIndexChanged);
                if (this._maintitlealign != null)
                {
                    this._maintitlealign.SelectedIndexChanged -= value2;
                }
                this._maintitlealign = value;
                if (this._maintitlealign != null)
                {
                    this._maintitlealign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x170005A4 RID: 1444
        // (get) Token: 0x06001066 RID: 4198 RVA: 0x00084B18 File Offset: 0x00082D18
        // (set) Token: 0x06001067 RID: 4199 RVA: 0x00084B30 File Offset: 0x00082D30
        internal virtual Button Button33
        {
            get
            {
                return this._Button33;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button33_Click);
                if (this._Button33 != null)
                {
                    this._Button33.Click -= value2;
                }
                this._Button33 = value;
                if (this._Button33 != null)
                {
                    this._Button33.Click += value2;
                }
            }
        }

        // Token: 0x170005A5 RID: 1445
        // (get) Token: 0x06001068 RID: 4200 RVA: 0x00084B7C File Offset: 0x00082D7C
        // (set) Token: 0x06001069 RID: 4201 RVA: 0x00084B94 File Offset: 0x00082D94
        internal virtual Button Button32
        {
            get
            {
                return this._Button32;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button32_Click);
                if (this._Button32 != null)
                {
                    this._Button32.Click -= value2;
                }
                this._Button32 = value;
                if (this._Button32 != null)
                {
                    this._Button32.Click += value2;
                }
            }
        }

        // Token: 0x170005A6 RID: 1446
        // (get) Token: 0x0600106A RID: 4202 RVA: 0x00084BE0 File Offset: 0x00082DE0
        // (set) Token: 0x0600106B RID: 4203 RVA: 0x00084BF8 File Offset: 0x00082DF8
        internal virtual Button Button31
        {
            get
            {
                return this._Button31;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button31_Click);
                if (this._Button31 != null)
                {
                    this._Button31.Click -= value2;
                }
                this._Button31 = value;
                if (this._Button31 != null)
                {
                    this._Button31.Click += value2;
                }
            }
        }

        // Token: 0x170005A7 RID: 1447
        // (get) Token: 0x0600106C RID: 4204 RVA: 0x00084C44 File Offset: 0x00082E44
        // (set) Token: 0x0600106D RID: 4205 RVA: 0x00084C5C File Offset: 0x00082E5C
        internal virtual TreeView t1
        {
            get
            {
                return this._t1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                TreeViewCancelEventHandler value2 = new TreeViewCancelEventHandler(this.t1_BeforeSelect);
                TreeViewEventHandler value3 = new TreeViewEventHandler(this.t1_AfterSelect);
                if (this._t1 != null)
                {
                    this._t1.BeforeSelect -= value2;
                    this._t1.AfterSelect -= value3;
                }
                this._t1 = value;
                if (this._t1 != null)
                {
                    this._t1.BeforeSelect += value2;
                    this._t1.AfterSelect += value3;
                }
            }
        }

        // Token: 0x170005A8 RID: 1448
        // (get) Token: 0x0600106E RID: 4206 RVA: 0x00084CCC File Offset: 0x00082ECC
        // (set) Token: 0x0600106F RID: 4207 RVA: 0x00006373 File Offset: 0x00004573
        internal virtual CheckBox isprint
        {
            get
            {
                return this._isprint;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._isprint = value;
            }
        }

        // Token: 0x170005A9 RID: 1449
        // (get) Token: 0x06001070 RID: 4208 RVA: 0x00084CE4 File Offset: 0x00082EE4
        // (set) Token: 0x06001071 RID: 4209 RVA: 0x00084CFC File Offset: 0x00082EFC
        internal virtual CheckBox iscomp
        {
            get
            {
                return this._iscomp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.iscomp_CheckedChanged);
                if (this._iscomp != null)
                {
                    this._iscomp.CheckedChanged -= value2;
                }
                this._iscomp = value;
                if (this._iscomp != null)
                {
                    this._iscomp.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x170005AA RID: 1450
        // (get) Token: 0x06001072 RID: 4210 RVA: 0x00084D48 File Offset: 0x00082F48
        // (set) Token: 0x06001073 RID: 4211 RVA: 0x00084D60 File Offset: 0x00082F60
        internal virtual TextBox fieldtitle
        {
            get
            {
                return this._fieldtitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.fieldtitle_TextChanged);
                EventHandler value3 = new EventHandler(this.reportheadertext_DoubleClick);
                if (this._fieldtitle != null)
                {
                    this._fieldtitle.TextChanged -= value2;
                    this._fieldtitle.DoubleClick -= value3;
                }
                this._fieldtitle = value;
                if (this._fieldtitle != null)
                {
                    this._fieldtitle.TextChanged += value2;
                    this._fieldtitle.DoubleClick += value3;
                }
            }
        }

        // Token: 0x170005AB RID: 1451
        // (get) Token: 0x06001074 RID: 4212 RVA: 0x00084DD0 File Offset: 0x00082FD0
        // (set) Token: 0x06001075 RID: 4213 RVA: 0x00084DE8 File Offset: 0x00082FE8
        internal virtual ComboBox fieldname
        {
            get
            {
                return this._fieldname;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.fieldname_Click);
                if (this._fieldname != null)
                {
                    this._fieldname.Click -= value2;
                }
                this._fieldname = value;
                if (this._fieldname != null)
                {
                    this._fieldname.Click += value2;
                }
            }
        }

        // Token: 0x170005AC RID: 1452
        // (get) Token: 0x06001076 RID: 4214 RVA: 0x00084E34 File Offset: 0x00083034
        // (set) Token: 0x06001077 RID: 4215 RVA: 0x0000637C File Offset: 0x0000457C
        internal virtual Label Label13
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

        // Token: 0x170005AD RID: 1453
        // (get) Token: 0x06001078 RID: 4216 RVA: 0x00084E4C File Offset: 0x0008304C
        // (set) Token: 0x06001079 RID: 4217 RVA: 0x00006385 File Offset: 0x00004585
        internal virtual Label Label12
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

        // Token: 0x170005AE RID: 1454
        // (get) Token: 0x0600107A RID: 4218 RVA: 0x00084E64 File Offset: 0x00083064
        // (set) Token: 0x0600107B RID: 4219 RVA: 0x0000638E File Offset: 0x0000458E
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

        // Token: 0x170005AF RID: 1455
        // (get) Token: 0x0600107C RID: 4220 RVA: 0x00084E7C File Offset: 0x0008307C
        // (set) Token: 0x0600107D RID: 4221 RVA: 0x00006397 File Offset: 0x00004597
        internal virtual ComboBox valg
        {
            get
            {
                return this._valg;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._valg = value;
            }
        }

        // Token: 0x170005B0 RID: 1456
        // (get) Token: 0x0600107E RID: 4222 RVA: 0x00084E94 File Offset: 0x00083094
        // (set) Token: 0x0600107F RID: 4223 RVA: 0x000063A0 File Offset: 0x000045A0
        internal virtual SaveFileDialog SaveFileDialog1
        {
            get
            {
                return this._SaveFileDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SaveFileDialog1 = value;
            }
        }

        // Token: 0x170005B1 RID: 1457
        // (get) Token: 0x06001080 RID: 4224 RVA: 0x00084EAC File Offset: 0x000830AC
        // (set) Token: 0x06001081 RID: 4225 RVA: 0x000063A9 File Offset: 0x000045A9
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

        // Token: 0x170005B2 RID: 1458
        // (get) Token: 0x06001082 RID: 4226 RVA: 0x00084EC4 File Offset: 0x000830C4
        // (set) Token: 0x06001083 RID: 4227 RVA: 0x000063B2 File Offset: 0x000045B2
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

        // Token: 0x170005B3 RID: 1459
        // (get) Token: 0x06001084 RID: 4228 RVA: 0x00084EDC File Offset: 0x000830DC
        // (set) Token: 0x06001085 RID: 4229 RVA: 0x00084EF4 File Offset: 0x000830F4
        internal virtual ListBox coltype
        {
            get
            {
                return this._coltype;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.coltype_SelectedIndexChanged);
                if (this._coltype != null)
                {
                    this._coltype.SelectedIndexChanged -= value2;
                }
                this._coltype = value;
                if (this._coltype != null)
                {
                    this._coltype.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x170005B4 RID: 1460
        // (get) Token: 0x06001086 RID: 4230 RVA: 0x00084F40 File Offset: 0x00083140
        // (set) Token: 0x06001087 RID: 4231 RVA: 0x00084F58 File Offset: 0x00083158
        internal virtual TextBox colformat
        {
            get
            {
                return this._colformat;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.colformat_TextChanged);
                if (this._colformat != null)
                {
                    this._colformat.TextChanged -= value2;
                }
                this._colformat = value;
                if (this._colformat != null)
                {
                    this._colformat.TextChanged += value2;
                }
            }
        }

        // Token: 0x170005B5 RID: 1461
        // (get) Token: 0x06001088 RID: 4232 RVA: 0x00084FA4 File Offset: 0x000831A4
        // (set) Token: 0x06001089 RID: 4233 RVA: 0x000063BB File Offset: 0x000045BB
        internal virtual CheckBox ml
        {
            get
            {
                return this._ml;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ml = value;
            }
        }

        // Token: 0x170005B6 RID: 1462
        // (get) Token: 0x0600108A RID: 4234 RVA: 0x00084FBC File Offset: 0x000831BC
        // (set) Token: 0x0600108B RID: 4235 RVA: 0x000063C4 File Offset: 0x000045C4
        internal virtual CheckBox printzero
        {
            get
            {
                return this._printzero;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._printzero = value;
            }
        }

        // Token: 0x170005B7 RID: 1463
        // (get) Token: 0x0600108C RID: 4236 RVA: 0x00084FD4 File Offset: 0x000831D4
        // (set) Token: 0x0600108D RID: 4237 RVA: 0x000063CD File Offset: 0x000045CD
        internal virtual NumericUpDown pagemarginr
        {
            get
            {
                return this._pagemarginr;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagemarginr = value;
            }
        }

        // Token: 0x170005B8 RID: 1464
        // (get) Token: 0x0600108E RID: 4238 RVA: 0x00084FEC File Offset: 0x000831EC
        // (set) Token: 0x0600108F RID: 4239 RVA: 0x000063D6 File Offset: 0x000045D6
        internal virtual NumericUpDown pagemarginl
        {
            get
            {
                return this._pagemarginl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagemarginl = value;
            }
        }

        // Token: 0x170005B9 RID: 1465
        // (get) Token: 0x06001090 RID: 4240 RVA: 0x00085004 File Offset: 0x00083204
        // (set) Token: 0x06001091 RID: 4241 RVA: 0x000063DF File Offset: 0x000045DF
        internal virtual NumericUpDown pagemarginb
        {
            get
            {
                return this._pagemarginb;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagemarginb = value;
            }
        }

        // Token: 0x170005BA RID: 1466
        // (get) Token: 0x06001092 RID: 4242 RVA: 0x0008501C File Offset: 0x0008321C
        // (set) Token: 0x06001093 RID: 4243 RVA: 0x000063E8 File Offset: 0x000045E8
        internal virtual NumericUpDown pagemargint
        {
            get
            {
                return this._pagemargint;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagemargint = value;
            }
        }

        // Token: 0x170005BB RID: 1467
        // (get) Token: 0x06001094 RID: 4244 RVA: 0x00085034 File Offset: 0x00083234
        // (set) Token: 0x06001095 RID: 4245 RVA: 0x000063F1 File Offset: 0x000045F1
        internal virtual NumericUpDown zdxposition
        {
            get
            {
                return this._zdxposition;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zdxposition = value;
            }
        }

        // Token: 0x170005BC RID: 1468
        // (get) Token: 0x06001096 RID: 4246 RVA: 0x0008504C File Offset: 0x0008324C
        // (set) Token: 0x06001097 RID: 4247 RVA: 0x000063FA File Offset: 0x000045FA
        internal virtual NumericUpDown fixedrows
        {
            get
            {
                return this._fixedrows;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._fixedrows = value;
            }
        }

        // Token: 0x170005BD RID: 1469
        // (get) Token: 0x06001098 RID: 4248 RVA: 0x00085064 File Offset: 0x00083264
        // (set) Token: 0x06001099 RID: 4249 RVA: 0x00006403 File Offset: 0x00004603
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

        // Token: 0x170005BE RID: 1470
        // (get) Token: 0x0600109A RID: 4250 RVA: 0x0008507C File Offset: 0x0008327C
        // (set) Token: 0x0600109B RID: 4251 RVA: 0x0000640C File Offset: 0x0000460C
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

        // Token: 0x170005BF RID: 1471
        // (get) Token: 0x0600109C RID: 4252 RVA: 0x00085094 File Offset: 0x00083294
        // (set) Token: 0x0600109D RID: 4253 RVA: 0x00006415 File Offset: 0x00004615
        internal virtual Label Label24
        {
            get
            {
                return this._Label24;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label24 = value;
            }
        }

        // Token: 0x170005C0 RID: 1472
        // (get) Token: 0x0600109E RID: 4254 RVA: 0x000850AC File Offset: 0x000832AC
        // (set) Token: 0x0600109F RID: 4255 RVA: 0x0000641E File Offset: 0x0000461E
        internal virtual NumericUpDown linewidth
        {
            get
            {
                return this._linewidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._linewidth = value;
            }
        }

        // Token: 0x170005C1 RID: 1473
        // (get) Token: 0x060010A0 RID: 4256 RVA: 0x000850C4 File Offset: 0x000832C4
        // (set) Token: 0x060010A1 RID: 4257 RVA: 0x00006427 File Offset: 0x00004627
        internal virtual NumericUpDown cbottom
        {
            get
            {
                return this._cbottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbottom = value;
            }
        }

        // Token: 0x170005C2 RID: 1474
        // (get) Token: 0x060010A2 RID: 4258 RVA: 0x000850DC File Offset: 0x000832DC
        // (set) Token: 0x060010A3 RID: 4259 RVA: 0x00006430 File Offset: 0x00004630
        internal virtual NumericUpDown ctop
        {
            get
            {
                return this._ctop;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ctop = value;
            }
        }

        // Token: 0x170005C3 RID: 1475
        // (get) Token: 0x060010A4 RID: 4260 RVA: 0x000850F4 File Offset: 0x000832F4
        // (set) Token: 0x060010A5 RID: 4261 RVA: 0x00006439 File Offset: 0x00004639
        internal virtual NumericUpDown cright
        {
            get
            {
                return this._cright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cright = value;
            }
        }

        // Token: 0x170005C4 RID: 1476
        // (get) Token: 0x060010A6 RID: 4262 RVA: 0x0008510C File Offset: 0x0008330C
        // (set) Token: 0x060010A7 RID: 4263 RVA: 0x00006442 File Offset: 0x00004642
        internal virtual NumericUpDown cleft
        {
            get
            {
                return this._cleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cleft = value;
            }
        }

        // Token: 0x170005C5 RID: 1477
        // (get) Token: 0x060010A8 RID: 4264 RVA: 0x00085124 File Offset: 0x00083324
        // (set) Token: 0x060010A9 RID: 4265 RVA: 0x0008513C File Offset: 0x0008333C
        internal virtual Button Button20
        {
            get
            {
                return this._Button20;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button20_Click);
                if (this._Button20 != null)
                {
                    this._Button20.Click -= value2;
                }
                this._Button20 = value;
                if (this._Button20 != null)
                {
                    this._Button20.Click += value2;
                }
            }
        }

        // Token: 0x170005C6 RID: 1478
        // (get) Token: 0x060010AA RID: 4266 RVA: 0x00085188 File Offset: 0x00083388
        // (set) Token: 0x060010AB RID: 4267 RVA: 0x000851A0 File Offset: 0x000833A0
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

        // Token: 0x170005C7 RID: 1479
        // (get) Token: 0x060010AC RID: 4268 RVA: 0x000851EC File Offset: 0x000833EC
        // (set) Token: 0x060010AD RID: 4269 RVA: 0x0000644B File Offset: 0x0000464B
        internal virtual NumericUpDown fieldheight
        {
            get
            {
                return this._fieldheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._fieldheight = value;
            }
        }

        // Token: 0x170005C8 RID: 1480
        // (get) Token: 0x060010AE RID: 4270 RVA: 0x00085204 File Offset: 0x00083404
        // (set) Token: 0x060010AF RID: 4271 RVA: 0x00006454 File Offset: 0x00004654
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

        // Token: 0x170005C9 RID: 1481
        // (get) Token: 0x060010B0 RID: 4272 RVA: 0x0008521C File Offset: 0x0008341C
        // (set) Token: 0x060010B1 RID: 4273 RVA: 0x0000645D File Offset: 0x0000465D
        internal virtual ComboBox bordertype
        {
            get
            {
                return this._bordertype;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._bordertype = value;
            }
        }

        // Token: 0x170005CA RID: 1482
        // (get) Token: 0x060010B2 RID: 4274 RVA: 0x00085234 File Offset: 0x00083434
        // (set) Token: 0x060010B3 RID: 4275 RVA: 0x00006466 File Offset: 0x00004666
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

        // Token: 0x170005CB RID: 1483
        // (get) Token: 0x060010B4 RID: 4276 RVA: 0x0008524C File Offset: 0x0008344C
        // (set) Token: 0x060010B5 RID: 4277 RVA: 0x0000646F File Offset: 0x0000466F
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

        // Token: 0x170005CC RID: 1484
        // (get) Token: 0x060010B6 RID: 4278 RVA: 0x00085264 File Offset: 0x00083464
        // (set) Token: 0x060010B7 RID: 4279 RVA: 0x00006478 File Offset: 0x00004678
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

        // Token: 0x170005CD RID: 1485
        // (get) Token: 0x060010B8 RID: 4280 RVA: 0x0008527C File Offset: 0x0008347C
        // (set) Token: 0x060010B9 RID: 4281 RVA: 0x00006481 File Offset: 0x00004681
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

        // Token: 0x170005CE RID: 1486
        // (get) Token: 0x060010BA RID: 4282 RVA: 0x00085294 File Offset: 0x00083494
        // (set) Token: 0x060010BB RID: 4283 RVA: 0x0000648A File Offset: 0x0000468A
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

        // Token: 0x170005CF RID: 1487
        // (get) Token: 0x060010BC RID: 4284 RVA: 0x000852AC File Offset: 0x000834AC
        // (set) Token: 0x060010BD RID: 4285 RVA: 0x00006493 File Offset: 0x00004693
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

        // Token: 0x170005D0 RID: 1488
        // (get) Token: 0x060010BE RID: 4286 RVA: 0x000852C4 File Offset: 0x000834C4
        // (set) Token: 0x060010BF RID: 4287 RVA: 0x0000649C File Offset: 0x0000469C
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

        // Token: 0x170005D1 RID: 1489
        // (get) Token: 0x060010C0 RID: 4288 RVA: 0x000852DC File Offset: 0x000834DC
        // (set) Token: 0x060010C1 RID: 4289 RVA: 0x000852F4 File Offset: 0x000834F4
        internal virtual TextBox comptxt
        {
            get
            {
                return this._comptxt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TextBox2_TextChanged);
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

        // Token: 0x170005D2 RID: 1490
        // (get) Token: 0x060010C2 RID: 4290 RVA: 0x00085340 File Offset: 0x00083540
        // (set) Token: 0x060010C3 RID: 4291 RVA: 0x000064A5 File Offset: 0x000046A5
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

        // Token: 0x170005D3 RID: 1491
        // (get) Token: 0x060010C4 RID: 4292 RVA: 0x00085358 File Offset: 0x00083558
        // (set) Token: 0x060010C5 RID: 4293 RVA: 0x000064AE File Offset: 0x000046AE
        internal virtual Label Label23
        {
            get
            {
                return this._Label23;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label23 = value;
            }
        }

        // Token: 0x170005D4 RID: 1492
        // (get) Token: 0x060010C6 RID: 4294 RVA: 0x00085370 File Offset: 0x00083570
        // (set) Token: 0x060010C7 RID: 4295 RVA: 0x000064B7 File Offset: 0x000046B7
        internal virtual Label Label26
        {
            get
            {
                return this._Label26;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label26 = value;
            }
        }

        // Token: 0x170005D5 RID: 1493
        // (get) Token: 0x060010C8 RID: 4296 RVA: 0x00085388 File Offset: 0x00083588
        // (set) Token: 0x060010C9 RID: 4297 RVA: 0x000064C0 File Offset: 0x000046C0
        internal virtual CheckBox zoomtopaperwidth
        {
            get
            {
                return this._zoomtopaperwidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zoomtopaperwidth = value;
            }
        }

        // Token: 0x170005D6 RID: 1494
        // (get) Token: 0x060010CA RID: 4298 RVA: 0x000853A0 File Offset: 0x000835A0
        // (set) Token: 0x060010CB RID: 4299 RVA: 0x000064C9 File Offset: 0x000046C9
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

        // Token: 0x170005D7 RID: 1495
        // (get) Token: 0x060010CC RID: 4300 RVA: 0x000853B8 File Offset: 0x000835B8
        // (set) Token: 0x060010CD RID: 4301 RVA: 0x000853D0 File Offset: 0x000835D0
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

        // Token: 0x170005D8 RID: 1496
        // (get) Token: 0x060010CE RID: 4302 RVA: 0x0008541C File Offset: 0x0008361C
        // (set) Token: 0x060010CF RID: 4303 RVA: 0x00085434 File Offset: 0x00083634
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

        // Token: 0x170005D9 RID: 1497
        // (get) Token: 0x060010D0 RID: 4304 RVA: 0x00085480 File Offset: 0x00083680
        // (set) Token: 0x060010D1 RID: 4305 RVA: 0x000064D2 File Offset: 0x000046D2
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_0
        {
            get
            {
                return this.dataGridViewTextBoxColumn_0;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_0 = value;
            }
        }

        // Token: 0x170005DA RID: 1498
        // (get) Token: 0x060010D2 RID: 4306 RVA: 0x00085498 File Offset: 0x00083698
        // (set) Token: 0x060010D3 RID: 4307 RVA: 0x000064DB File Offset: 0x000046DB
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_1
        {
            get
            {
                return this.dataGridViewTextBoxColumn_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_1 = value;
            }
        }

        // Token: 0x170005DB RID: 1499
        // (get) Token: 0x060010D4 RID: 4308 RVA: 0x000854B0 File Offset: 0x000836B0
        // (set) Token: 0x060010D5 RID: 4309 RVA: 0x000064E4 File Offset: 0x000046E4
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_2
        {
            get
            {
                return this.dataGridViewTextBoxColumn_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_2 = value;
            }
        }

        // Token: 0x170005DC RID: 1500
        // (get) Token: 0x060010D6 RID: 4310 RVA: 0x000854C8 File Offset: 0x000836C8
        // (set) Token: 0x060010D7 RID: 4311 RVA: 0x000064ED File Offset: 0x000046ED
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_3
        {
            get
            {
                return this.dataGridViewTextBoxColumn_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_3 = value;
            }
        }

        // Token: 0x170005DD RID: 1501
        // (get) Token: 0x060010D8 RID: 4312 RVA: 0x000854E0 File Offset: 0x000836E0
        // (set) Token: 0x060010D9 RID: 4313 RVA: 0x000064F6 File Offset: 0x000046F6
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_4
        {
            get
            {
                return this.dataGridViewTextBoxColumn_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_4 = value;
            }
        }

        // Token: 0x170005DE RID: 1502
        // (get) Token: 0x060010DA RID: 4314 RVA: 0x000854F8 File Offset: 0x000836F8
        // (set) Token: 0x060010DB RID: 4315 RVA: 0x000064FF File Offset: 0x000046FF
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_5
        {
            get
            {
                return this.dataGridViewTextBoxColumn_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_5 = value;
            }
        }

        // Token: 0x170005DF RID: 1503
        // (get) Token: 0x060010DC RID: 4316 RVA: 0x00085510 File Offset: 0x00083710
        // (set) Token: 0x060010DD RID: 4317 RVA: 0x00006508 File Offset: 0x00004708
        internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_6
        {
            get
            {
                return this.dataGridViewTextBoxColumn_6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.dataGridViewTextBoxColumn_6 = value;
            }
        }

        // Token: 0x170005E0 RID: 1504
        // (get) Token: 0x060010DE RID: 4318 RVA: 0x00085528 File Offset: 0x00083728
        // (set) Token: 0x060010DF RID: 4319 RVA: 0x00006511 File Offset: 0x00004711
        internal virtual ImageList ImageList1
        {
            get
            {
                return this._ImageList1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ImageList1 = value;
            }
        }

        // Token: 0x170005E1 RID: 1505
        // (get) Token: 0x060010E0 RID: 4320 RVA: 0x00085540 File Offset: 0x00083740
        // (set) Token: 0x060010E1 RID: 4321 RVA: 0x0000651A File Offset: 0x0000471A
        internal virtual Label Label14
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

        // Token: 0x170005E2 RID: 1506
        // (get) Token: 0x060010E2 RID: 4322 RVA: 0x00085558 File Offset: 0x00083758
        // (set) Token: 0x060010E3 RID: 4323 RVA: 0x00085570 File Offset: 0x00083770
        internal virtual Button formatbotton
        {
            get
            {
                return this._formatbotton;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.formatbotton_Click);
                if (this._formatbotton != null)
                {
                    this._formatbotton.Click -= value2;
                }
                this._formatbotton = value;
                if (this._formatbotton != null)
                {
                    this._formatbotton.Click += value2;
                }
            }
        }

        // Token: 0x170005E3 RID: 1507
        // (get) Token: 0x060010E4 RID: 4324 RVA: 0x000855BC File Offset: 0x000837BC
        // (set) Token: 0x060010E5 RID: 4325 RVA: 0x00006523 File Offset: 0x00004723
        internal virtual ToolTip ToolTip1
        {
            get
            {
                return this._ToolTip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolTip1 = value;
            }
        }

        // Token: 0x170005E4 RID: 1508
        // (get) Token: 0x060010E6 RID: 4326 RVA: 0x000855D4 File Offset: 0x000837D4
        // (set) Token: 0x060010E7 RID: 4327 RVA: 0x0000652C File Offset: 0x0000472C
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

        // Token: 0x170005E5 RID: 1509
        // (get) Token: 0x060010E8 RID: 4328 RVA: 0x000855EC File Offset: 0x000837EC
        // (set) Token: 0x060010E9 RID: 4329 RVA: 0x00006535 File Offset: 0x00004735
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

        // Token: 0x170005E6 RID: 1510
        // (get) Token: 0x060010EA RID: 4330 RVA: 0x00085604 File Offset: 0x00083804
        // (set) Token: 0x060010EB RID: 4331 RVA: 0x0000653E File Offset: 0x0000473E
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

        // Token: 0x170005E7 RID: 1511
        // (get) Token: 0x060010EC RID: 4332 RVA: 0x0008561C File Offset: 0x0008381C
        // (set) Token: 0x060010ED RID: 4333 RVA: 0x00006547 File Offset: 0x00004747
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

        // Token: 0x060010EE RID: 4334 RVA: 0x00085634 File Offset: 0x00083834
        public void MyLoadDGVDefaultSettings(DataGridView dgv)
        {
            checked
            {
                if (dgv != null)
                {
                    if (dgv.ColumnCount > 0)
                    {
                        while (this.t1.Nodes.Count > 0)
                        {
                            this.t1.Nodes[0].Remove();
                        }
                        Ruler ruler = new Ruler();
                        int columnCount = dgv.ColumnCount;
                        int[] array = new int[columnCount - 1 + 1];
                        int[] array2 = new int[columnCount - 1 + 1];
                        int num = 0;
                        int num2 = columnCount - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            array[i] = i;
                            array2[i] = dgv.Columns[i].DisplayIndex;
                        }
                        Array.Sort<int, int>(array2, array);
                        int num3 = 0;
                        int num4 = dgv.ColumnCount - 1;
                        int j = num3;
                        while (j <= num4)
                        {
                            DataGridViewColumn dataGridViewColumn = dgv.Columns[array[j]];
                            TreeNode treeNode = this.t1.Nodes.Add(dataGridViewColumn.HeaderText);
                            this.CurCol.Cellcomputer = "";
                            this.CurCol.Cellbackcolor = Color.Transparent;
                            this.CurCol.Cellfield = "[" + dataGridViewColumn.Name + "]";
                            if (dgv.Columns[j].HasDefaultCellStyle)
                            {
                                try
                                {
                                    this.CurCol.Cellfont = (Font)dgv.Columns[j].DefaultCellStyle.Font.Clone();
                                    goto IL_43B;
                                }
                                catch (Exception ex)
                                {
                                    this.CurCol.Cellfont = (Font)dgv.DefaultCellStyle.Font.Clone();
                                    goto IL_43B;
                                }
                                goto IL_18E;
                            }
                            goto IL_18E;
                        IL_43B:
                            this.CurCol.Cellforecolor = dgv.DefaultCellStyle.ForeColor;
                            this.CurCol.CellFormat = "";
                            this.CurCol.CellHalign = StringAlignment.Near;
                            this.CurCol.CellMul = true;
                            if (dataGridViewColumn.ValueType == null)
                            {
                                if (dataGridViewColumn is DataGridViewImageColumn)
                                {
                                    this.CurCol.CellType = "图像";
                                }
                                else
                                {
                                    this.CurCol.CellType = "文本";
                                }
                            }
                            else
                            {
                                string left = Strings.Left(Strings.UCase(dataGridViewColumn.ValueType.Name), 3);
                                if (String.Compare(left, "INT", false) == 0)
                                {
                                    this.CurCol.CellType = "数值";
                                    this.CurCol.CellMul = false;
                                }
                                else if (String.Compare(left, "STR", false) == 0)
                                {
                                    this.CurCol.CellType = "文本";
                                }
                                else
                                {
                                    if (String.Compare(left, "DEC", false) != 0)
                                    {
                                        if (String.Compare(left, "FLO", false) != 0)
                                        {
                                            if (String.Compare(left, "CUR", false) != 0)
                                            {
                                                if (String.Compare(left, "DOU", false) != 0)
                                                {
                                                    if (String.Compare(left, "BOO", false) == 0)
                                                    {
                                                        this.CurCol.CellType = "逻辑";
                                                        goto IL_336;
                                                    }
                                                    if (String.Compare(left, "DAT", false) == 0)
                                                    {
                                                        this.CurCol.CellType = "日期";
                                                        goto IL_336;
                                                    }
                                                    if (String.Compare(left, "IMA", false) == 0)
                                                    {
                                                        this.CurCol.CellType = "图像";
                                                        goto IL_336;
                                                    }
                                                    this.CurCol.CellType = "文本";
                                                    goto IL_336;
                                                }
                                            }
                                        }
                                    }
                                    this.CurCol.CellType = "数值";
                                    this.CurCol.CellMul = false;
                                }
                            }
                        IL_336:
                            this.CurCol.Fieldbackcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
                            this.CurCol.Fieldfont = Module1.GetDGVHeaderFont(dataGridViewColumn);
                            this.CurCol.Fieldforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
                            this.CurCol.IsComputer = false;
                            this.CurCol.IsPrint = dataGridViewColumn.Visible;
                            this.CurCol.IsPrintZero = true;
                            this.CurCol.ColWidth = new decimal(ruler.ConvertToMM((float)dataGridViewColumn.Width, true));
                            if (dataGridViewColumn.HasDefaultCellStyle)
                            {
                                DataGridViewContentAlignment alignment = dataGridViewColumn.DefaultCellStyle.Alignment;
                                if (alignment != DataGridViewContentAlignment.BottomCenter)
                                {
                                    if (alignment != DataGridViewContentAlignment.MiddleCenter)
                                    {
                                        if (alignment != DataGridViewContentAlignment.TopCenter)
                                        {
                                            if (alignment != DataGridViewContentAlignment.BottomRight)
                                            {
                                                if (alignment != DataGridViewContentAlignment.MiddleRight)
                                                {
                                                    if (alignment != DataGridViewContentAlignment.TopRight)
                                                    {
                                                        this.CurCol.CellHalign = StringAlignment.Near;
                                                        goto IL_41E;
                                                    }
                                                }
                                            }
                                            this.CurCol.CellHalign = StringAlignment.Far;
                                            goto IL_41E;
                                        }
                                    }
                                }
                                this.CurCol.CellHalign = StringAlignment.Center;
                            }
                        IL_41E:
                            treeNode.Tag = this.CurCol.SaveTags();
                            j++;
                            continue;
                        IL_18E:
                            this.CurCol.Cellfont = (Font)dgv.DefaultCellStyle.Font.Clone();
                            goto IL_43B;
                        }
                        array = null;
                        ruler.Dispose();
                        ruler = null;
                    }
                }
            }
        }

        // Token: 0x060010EF RID: 4335 RVA: 0x00085AE8 File Offset: 0x00083CE8
        private void Button31_Click(object sender, EventArgs e)
        {
            if (this.t1.Nodes.Count <= 0)
            {
                TreeNode selectedNode = this.t1.Nodes.Add("根结点");
                this.t1.SelectedNode = selectedNode;
                this.iscomp.Checked = false;
                this.fieldname.Text = "";
                this.t1.Select();
            }
            else if (this.t1.SelectedNode != null)
            {
                TreeNode selectedNode2;
                if (this.t1.SelectedNode.Parent == null)
                {
                    selectedNode2 = this.t1.Nodes.Add("同级增加");
                }
                else
                {
                    selectedNode2 = this.t1.SelectedNode.Parent.Nodes.Add("同级增加");
                }
                this.t1.SelectedNode = selectedNode2;
                this.iscomp.Checked = false;
                this.fieldname.Text = "";
                this.t1.Select();
            }
        }

        // Token: 0x060010F0 RID: 4336 RVA: 0x00085BE0 File Offset: 0x00083DE0
        private void Button32_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                TreeNode selectedNode = this.t1.SelectedNode.Nodes.Add("子结点");
                this.t1.SelectedNode = selectedNode;
                this.iscomp.Checked = false;
                this.t1.Select();
            }
        }

        // Token: 0x060010F1 RID: 4337 RVA: 0x00006550 File Offset: 0x00004750
        private void Button33_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.t1.Nodes.Remove(this.t1.SelectedNode);
            }
        }

        // Token: 0x060010F2 RID: 4338 RVA: 0x00085C38 File Offset: 0x00083E38
        private void Button18_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null && this.t1.SelectedNode.PrevNode != null)
            {
                TreeNode prevNode = this.t1.SelectedNode.PrevNode;
                TreeNode treeNode = (TreeNode)this.t1.SelectedNode.Clone();
                if (this.t1.SelectedNode.Parent == null)
                {
                    this.t1.SelectedNode.Remove();
                    this.t1.Nodes.Insert(prevNode.Index, treeNode);
                }
                else
                {
                    TreeNode parent = this.t1.SelectedNode.Parent;
                    this.t1.SelectedNode.Remove();
                    parent.Nodes.Insert(prevNode.Index, treeNode);
                }
                this.t1.SelectedNode = treeNode;
                this.t1.Select();
            }
        }

        // Token: 0x060010F3 RID: 4339 RVA: 0x00085D18 File Offset: 0x00083F18
        private void Button19_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null && this.t1.SelectedNode.NextNode != null)
            {
                TreeNode node = (TreeNode)this.t1.SelectedNode.NextNode.Clone();
                TreeNode selectedNode = this.t1.SelectedNode;
                if (this.t1.SelectedNode.NextNode.Parent == null)
                {
                    this.t1.SelectedNode.NextNode.Remove();
                    this.t1.Nodes.Insert(selectedNode.Index, node);
                }
                else
                {
                    TreeNode parent = this.t1.SelectedNode.NextNode.Parent;
                    this.t1.SelectedNode.NextNode.Remove();
                    parent.Nodes.Insert(selectedNode.Index, node);
                }
                this.t1.Select();
            }
        }

        // Token: 0x060010F4 RID: 4340 RVA: 0x00085E00 File Offset: 0x00084000
        private void SaveCurrentNodeTag()
        {
            if (this.t1.SelectedNode != null)
            {
                this.CurCol.ColWidth = this.colwidth.Value;
                this.CurCol.IsPrint = this.isprint.Checked;
                this.CurCol.IsComputer = this.iscomp.Checked;
                this.CurCol.Cellcomputer = this.comptxt.Text;
                this.CurCol.Cellfield = this.fieldname.Text;
                if (this.RadioButton1.Checked)
                {
                    this.CurCol.ImageType = DataGridViewImageCellLayout.Stretch;
                }
                else if (this.RadioButton2.Checked)
                {
                    this.CurCol.ImageType = DataGridViewImageCellLayout.Zoom;
                }
                else
                {
                    this.CurCol.ImageType = DataGridViewImageCellLayout.Normal;
                }
                if (this.coltype.SelectedIndex < 0)
                {
                    this.CurCol.CellType = "常规";
                }
                else
                {
                    this.CurCol.CellType = Convert.ToString(this.coltype.SelectedItem);
                }
                this.CurCol.CellFormat = this.colformat.Text;
                string text = this.halg.Text;
                if (String.Compare(text, "右对齐", false) == 0)
                {
                    this.CurCol.CellHalign = StringAlignment.Far;
                }
                else if (String.Compare(text, "居中对齐", false) == 0)
                {
                    this.CurCol.CellHalign = StringAlignment.Center;
                }
                else
                {
                    this.CurCol.CellHalign = StringAlignment.Near;
                }
                string text2 = this.valg.Text;
                if (String.Compare(text2, "上对齐", false) == 0)
                {
                    this.CurCol.CellValign = StringAlignment.Near;
                }
                else if (String.Compare(text2, "下对齐", false) == 0)
                {
                    this.CurCol.CellValign = StringAlignment.Far;
                }
                else
                {
                    this.CurCol.CellValign = StringAlignment.Center;
                }
                this.CurCol.CellMul = this.ml.Checked;
                this.CurCol.IsPrintZero = this.printzero.Checked;
                this.CurCol.Fieldfont = this.headerfont.Font;
                this.CurCol.Fieldforecolor = this.headerfont.ForeColor;
                this.CurCol.Fieldbackcolor = this.headerfont.BackColor;
                this.CurCol.Cellfont = this.cellfont.Font;
                this.CurCol.Cellforecolor = this.cellfont.ForeColor;
                this.CurCol.Cellbackcolor = this.cellfont.BackColor;
                this.t1.SelectedNode.Tag = this.CurCol.SaveTags();
                TreeNode treeNode = this.t1.SelectedNode;
                while (treeNode.Parent != null)
                {
                    treeNode = treeNode.Parent;
                    this.CurCol.RestoreTags(Convert.ToString(treeNode.Tag));
                    this.CurCol.ColWidth = SimpleReportModule.GetTreeViewColWidth(treeNode);
                    this.CurCol.IsPrint = SimpleReportModule.GetTreeViewColPrint(treeNode);
                    treeNode.Tag = this.CurCol.SaveTags();
                }
            }
        }

        // Token: 0x060010F5 RID: 4341 RVA: 0x000860F4 File Offset: 0x000842F4
        private void ShowTag(TreeNode n)
        {
            if (n != null)
            {
                this.CurCol.RestoreTags(Convert.ToString(n.Tag));
                if (n.Tag != null)
                {
                    this.colwidth.Value = this.CurCol.ColWidth;
                }
                this.isprint.Checked = this.CurCol.IsPrint;
                this.iscomp.Checked = this.CurCol.IsComputer;
                this.comptxt.Text = this.CurCol.Cellcomputer;
                this.fieldname.Text = this.CurCol.Cellfield;
                switch (this.CurCol.ImageType)
                {
                    case DataGridViewImageCellLayout.Stretch:
                        this.RadioButton1.Checked = true;
                        break;
                    case DataGridViewImageCellLayout.Zoom:
                        this.RadioButton2.Checked = true;
                        break;
                    default:
                        this.RadioButton3.Checked = true;
                        break;
                }
                if (String.Compare(this.CurCol.CellType, "", false) == 0)
                {
                    this.coltype.SelectedItem = "常规";
                }
                else
                {
                    this.coltype.Text = this.CurCol.CellType;
                }
                this.colformat.Text = this.CurCol.CellFormat;
                switch (this.CurCol.CellHalign)
                {
                    case StringAlignment.Center:
                        this.halg.SelectedItem = "居中对齐";
                        break;
                    case StringAlignment.Far:
                        this.halg.SelectedItem = "右对齐";
                        break;
                    default:
                        this.halg.SelectedItem = "左对齐";
                        break;
                }
                switch (this.CurCol.CellValign)
                {
                    case StringAlignment.Near:
                        this.valg.Text = "上对齐";
                        goto IL_1CB;
                    case StringAlignment.Far:
                        this.valg.Text = "下对齐";
                        goto IL_1CB;
                }
                this.valg.Text = "居中对齐";
            IL_1CB:
                this.ml.Checked = this.CurCol.CellMul;
                this.printzero.Checked = this.CurCol.IsPrintZero;
                this.headerfont.Font = (Font)this.CurCol.Fieldfont.Clone();
                this.headerfont.ForeColor = this.CurCol.Fieldforecolor;
                this.headerfont.BackColor = this.CurCol.Fieldbackcolor;
                this.cellfont.Font = this.CurCol.Cellfont;
                this.cellfont.ForeColor = this.CurCol.Cellforecolor;
                this.cellfont.BackColor = this.CurCol.Cellbackcolor;
                this.fieldtitle.Text = n.Text;
                if (n.GetNodeCount(false) > 0)
                {
                    this.isprint.Enabled = false;
                    this.printzero.Visible = false;
                    this.fieldname.Visible = false;
                    this.iscomp.Visible = false;
                    this.comptxt.Visible = false;
                    this.coltype.Visible = false;
                    this.colformat.Visible = false;
                    this.GroupBoxxx3.Visible = false;
                    this.colwidth.Enabled = false;
                    this.GroupBoxformat.Visible = false;
                }
                else
                {
                    this.isprint.Enabled = true;
                    this.printzero.Visible = true;
                    this.fieldname.Visible = true;
                    this.iscomp.Visible = true;
                    this.comptxt.Visible = true;
                    this.coltype.Visible = true;
                    this.colformat.Visible = true;
                    this.GroupBoxxx3.Visible = true;
                    this.colwidth.Enabled = true;
                    this.GroupBoxformat.Visible = true;
                }
                if (String.Compare(this.coltype.Text, "逻辑", false) == 0)
                {
                    this.Label26.Visible = true;
                }
                else
                {
                    this.Label26.Visible = false;
                }
                if (String.Compare(this.coltype.Text, "图像", false) == 0)
                {
                    this.Label23.Visible = false;
                    this.colformat.Visible = false;
                    this.GroupBox11.Visible = true;
                }
                else
                {
                    this.Label23.Visible = true;
                    this.colformat.Visible = true;
                    this.GroupBox11.Visible = false;
                }
            }
        }

        // Token: 0x060010F6 RID: 4342 RVA: 0x0000657A File Offset: 0x0000477A
        private void t1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.ShowTag(e.Node);
        }

        // Token: 0x060010F7 RID: 4343 RVA: 0x00006588 File Offset: 0x00004788
        private void t1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.SaveCurrentNodeTag();
            }
        }

        // Token: 0x060010F8 RID: 4344 RVA: 0x0008652C File Offset: 0x0008472C
        private void fieldtitle_TextChanged(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                if (String.Compare(this.fieldtitle.Text, "", false) != 0)
                {
                    this.t1.SelectedNode.Text = this.fieldtitle.Text;
                }
            }
        }

        // Token: 0x060010F9 RID: 4345 RVA: 0x0008657C File Offset: 0x0008477C
        private void Button11_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.FontDialog1.ShowColor = true;
                this.FontDialog1.Font = this.headerfont.Font;
                this.FontDialog1.Color = this.headerfont.ForeColor;
                if (this.FontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.headerfont.Font = this.FontDialog1.Font;
                    this.headerfont.ForeColor = this.FontDialog1.Color;
                }
            }
        }

        // Token: 0x060010FA RID: 4346 RVA: 0x00086608 File Offset: 0x00084808
        private void Button16_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.ColorDialog1.Color = this.headerfont.BackColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.headerfont.BackColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x060010FB RID: 4347 RVA: 0x0008665C File Offset: 0x0008485C
        private void Button10_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.FontDialog1.ShowColor = true;
                this.FontDialog1.Font = this.cellfont.Font;
                this.FontDialog1.Color = this.cellfont.ForeColor;
                if (this.FontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.cellfont.Font = this.FontDialog1.Font;
                    this.cellfont.ForeColor = this.FontDialog1.Color;
                }
            }
        }

        // Token: 0x060010FC RID: 4348 RVA: 0x000866E8 File Offset: 0x000848E8
        private void Button15_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null)
            {
                this.ColorDialog1.Color = this.cellfont.BackColor;
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.cellfont.BackColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x060010FD RID: 4349 RVA: 0x0008673C File Offset: 0x0008493C
        private void iscomp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.iscomp.Checked)
            {
                this.comptxt.Visible = true;
                this.comptxt.Enabled = true;
            }
            else
            {
                this.comptxt.Visible = false;
                this.comptxt.Enabled = false;
            }
        }

        // Token: 0x060010FE RID: 4350 RVA: 0x0000659D File Offset: 0x0000479D
        private void Button2_Click(object sender, EventArgs e)
        {
            this.MyAdd(this.d1);
        }

        // Token: 0x060010FF RID: 4351 RVA: 0x000065AB File Offset: 0x000047AB
        private void Button4_Click(object sender, EventArgs e)
        {
            this.MyEidt(this.d1);
        }

        // Token: 0x06001100 RID: 4352 RVA: 0x000065B9 File Offset: 0x000047B9
        private void Button3_Click(object sender, EventArgs e)
        {
            SimpleReportSet.MyDel(this.d1);
        }

        // Token: 0x06001101 RID: 4353 RVA: 0x000065C6 File Offset: 0x000047C6
        private static void MyDel(DataGridView dd)
        {
            if (dd.CurrentRow != null && Interaction.MsgBox("确实要删除当前行？", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "提示") == MsgBoxResult.Yes)
            {
                dd.Rows.Remove(dd.CurrentRow);
            }
        }

        // Token: 0x06001102 RID: 4354 RVA: 0x00086788 File Offset: 0x00084988
        private void MyAdd(DataGridView dd)
        {
            MyProject.Forms.SimpleReportAddHeader.txt.Text = "";
            MyProject.Forms.SimpleReportAddHeader.jc.Value = 1m;
            MyProject.Forms.SimpleReportAddHeader.dq.Text = "左对齐";
            MyProject.Forms.SimpleReportAddHeader.txt.Font = new Font("宋体", 10f);
            MyProject.Forms.SimpleReportAddHeader.txt.ForeColor = Color.Black;
            MyProject.Forms.SimpleReportAddHeader.kd.Value = 0m;
            MyProject.Forms.SimpleReportAddHeader.gd.Value = 1m;
            MyProject.Forms.SimpleReportAddHeader.thefieldstring = this.TheFieldstring;
            MyProject.Forms.SimpleReportAddHeader.zdyarray = this.ZdyArray;
            if (dd == this.d1)
            {
                MyProject.Forms.SimpleReportAddHeader.Text = "表格页眉设置";
            }
            else if (dd == this.d2)
            {
                MyProject.Forms.SimpleReportAddHeader.Text = "表格尾注设置";
            }
            checked
            {
                if (MyProject.Forms.SimpleReportAddHeader.ShowDialog(this) == DialogResult.OK)
                {
                    dd.RowCount++;
                    int index = dd.RowCount - 1;
                    dd.Rows[index].Cells[0].Value = MyProject.Forms.SimpleReportAddHeader.txt.Text;
                    dd.Rows[index].Cells[1].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.jc.Value) + "";
                    dd.Rows[index].Cells[2].Value = MyProject.Forms.SimpleReportAddHeader.dq.Text;
                    dd.Rows[index].Cells[3].Value = Module1.ConvertFontToString(MyProject.Forms.SimpleReportAddHeader.txt.Font);
                    dd.Rows[index].Cells[4].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.gd.Value) + "行高";
                    dd.Rows[index].Cells[5].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.kd.Value) + "毫米";
                    dd.Rows[index].Cells[6].Value = Module1.ConvertColorToString(MyProject.Forms.SimpleReportAddHeader.txt.ForeColor);
                }
                dd.Sort(dd.Columns[1], ListSortDirection.Ascending);
            }
        }

        // Token: 0x06001103 RID: 4355 RVA: 0x00086A7C File Offset: 0x00084C7C
        private void MyEidt(DataGridView dd)
        {
            if (dd.CurrentRow != null)
            {
                int index = dd.CurrentRow.Index;
                MyProject.Forms.SimpleReportAddHeader.txt.Text = Convert.ToString(dd.CurrentRow.Cells[0].Value);
                MyProject.Forms.SimpleReportAddHeader.jc.Value = Convert.ToDecimal(dd.CurrentRow.Cells[1].Value);
                MyProject.Forms.SimpleReportAddHeader.dq.Text = Convert.ToString(dd.CurrentRow.Cells[2].Value);
                MyProject.Forms.SimpleReportAddHeader.txt.Font = Module1.ConvertStringToFont(Convert.ToString(dd.CurrentRow.Cells[3].Value));
                MyProject.Forms.SimpleReportAddHeader.txt.ForeColor = Module1.ConvertStringToColor(Convert.ToString(dd.CurrentRow.Cells[6].Value));
                MyProject.Forms.SimpleReportAddHeader.kd.Value = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dd.CurrentRow.Cells[5].Value)));
                MyProject.Forms.SimpleReportAddHeader.gd.Value = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dd.CurrentRow.Cells[4].Value)));
                MyProject.Forms.SimpleReportAddHeader.thefieldstring = this.TheFieldstring;
                MyProject.Forms.SimpleReportAddHeader.zdyarray = this.ZdyArray;
                if (dd == this.d1)
                {
                    MyProject.Forms.SimpleReportAddHeader.Text = "表格页眉设置";
                }
                else if (dd == this.d2)
                {
                    MyProject.Forms.SimpleReportAddHeader.Text = "表格尾注设置";
                }
                if (MyProject.Forms.SimpleReportAddHeader.ShowDialog() == DialogResult.OK)
                {
                    dd.Rows[index].Cells[0].Value = MyProject.Forms.SimpleReportAddHeader.txt.Text;
                    dd.Rows[index].Cells[1].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.jc.Value) + "";
                    dd.Rows[index].Cells[2].Value = MyProject.Forms.SimpleReportAddHeader.dq.Text;
                    dd.Rows[index].Cells[3].Value = Module1.ConvertFontToString(MyProject.Forms.SimpleReportAddHeader.txt.Font);
                    dd.Rows[index].Cells[4].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.gd.Value) + "行高";
                    dd.Rows[index].Cells[5].Value = Convert.ToString(MyProject.Forms.SimpleReportAddHeader.kd.Value) + "毫米";
                    dd.Rows[index].Cells[6].Value = Module1.ConvertColorToString(MyProject.Forms.SimpleReportAddHeader.txt.ForeColor);
                }
                dd.Sort(dd.Columns[1], ListSortDirection.Ascending);
            }
        }

        // Token: 0x06001104 RID: 4356 RVA: 0x00086E1C File Offset: 0x0008501C
        public void SetPrintCS()
        {
            string text = Convert.ToString(this.papertype.SelectedItem);
            this.papertype.Items.Clear();
            PrinterSettings printerSettings = new PrinterSettings();
            if (String.Compare(this.myprintername, "", false) != 0 && Module1.IsValidPrinterName(this.myprintername))
            {
                printerSettings.PrinterName = this.myprintername;
            }
            PrinterSettings.PaperSizeCollection paperSizes = printerSettings.PaperSizes;
            string text2 = "";
            int num = 0;
            checked
            {
                int num2 = paperSizes.Count - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(paperSizes[i].PaperName, "[自定义纸张]", false) != 0)
                    {
                        this.papertype.Items.Add(paperSizes[i].PaperName);
                        if (i == 0)
                        {
                            text2 = Convert.ToString((int)paperSizes[i].Kind);
                        }
                        else
                        {
                            text2 = text2 + "," + Convert.ToString((int)paperSizes[i].Kind);
                        }
                    }
                }
                this.papertype.Items.Add("[自定义纸张]");
                text2 += ",0";
                this.papertype.Tag = text2;
                try
                {
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.papertype.SelectedItem = text;
                    }
                    else
                    {
                        this.papertype.SelectedItem = "A4";
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x06001105 RID: 4357 RVA: 0x00086F94 File Offset: 0x00085194
        private string SavePaper()
        {
            string str;
            if (String.Compare(Convert.ToString(this.papertype.SelectedItem), "", false) == 0)
            {
                str = "0" + this.sp_col + "[自定义纸张]";
                str = str + this.sp_col + Convert.ToString(this.myw.Value);
                str = str + this.sp_col + Convert.ToString(this.myh.Value);
            }
            else if (String.Compare(Convert.ToString(this.papertype.SelectedItem), "[自定义纸张]", false) == 0)
            {
                str = "0" + this.sp_col + "[自定义纸张]";
                str = str + this.sp_col + Convert.ToString(this.myw.Value);
                str = str + this.sp_col + Convert.ToString(this.myh.Value);
            }
            else
            {
                PaperSize printForm = definepaper.GetPrintForm(this.myprintername, Convert.ToString(this.papertype.SelectedItem));
                str = Convert.ToString((int)printForm.Kind) + this.sp_col + Convert.ToString(this.papertype.SelectedItem);
                str = str + this.sp_col + Convert.ToString(this.myw.Value);
                str = str + this.sp_col + Convert.ToString(this.myh.Value);
            }
            str = str + this.sp_col + this.fx.Text;
            str = str + this.sp_col + Convert.ToString(this.pagemargint.Value);
            str = str + this.sp_col + Convert.ToString(this.pagemarginb.Value);
            str = str + this.sp_col + Convert.ToString(this.pagemarginl.Value);
            return str + this.sp_col + Convert.ToString(this.pagemarginr.Value);
        }

        // Token: 0x06001106 RID: 4358 RVA: 0x00087198 File Offset: 0x00085398
        private void RestorePaper(string ss)
        {
            this.SetPrintCS();
            if (String.Compare(ss, "", false) == 0)
            {
                try
                {
                    this.papertype.Text = "A4";
                    return;
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
            if (String.Compare(array[0], "0", false) == 0)
            {
                this.myw.ReadOnly = false;
                this.myh.ReadOnly = false;
                if (this.papertype.Items.IndexOf(array[1]) >= 0)
                {
                    this.papertype.Text = array[1];
                }
                else
                {
                    this.papertype.Text = "[自定义纸张]";
                }
                this.myw.Value = Convert.ToDecimal(array[2]);
                this.myh.Value = Convert.ToDecimal(array[3]);
            }
            else
            {
                if (this.papertype.Items.IndexOf(array[1]) >= 0)
                {
                    this.myw.ReadOnly = true;
                    this.myh.ReadOnly = true;
                    this.myw.Value = Convert.ToDecimal(array[2]);
                    this.myh.Value = Convert.ToDecimal(array[3]);
                    try
                    {
                        this.papertype.Text = array[1];
                        goto IL_194;
                    }
                    catch (Exception ex2)
                    {
                        goto IL_194;
                    }
                }
                this.myw.ReadOnly = false;
                this.myh.ReadOnly = false;
                this.papertype.Text = "[自定义纸张]";
                this.myw.Value = Convert.ToDecimal(array[2]);
                this.myh.Value = Convert.ToDecimal(array[3]);
            }
        IL_194:
            this.fx.Text = array[4];
            this.pagemargint.Value = Convert.ToDecimal(array[5]);
            this.pagemarginb.Value = Convert.ToDecimal(array[6]);
            this.pagemarginl.Value = Convert.ToDecimal(array[7]);
            this.pagemarginr.Value = Convert.ToDecimal(array[8]);
            array = null;
        }

        // Token: 0x06001107 RID: 4359 RVA: 0x000873B4 File Offset: 0x000855B4
        public string SaveWater()
        {
            string str = this.sytext.Text;
            str = str + this.sp_col + this.syfx.Text;
            str = str + this.sp_col + Convert.ToString(this.sytm.Value);
            str = str + this.sp_col + Module1.ConvertColorToString(this.sytext.ForeColor);
            return str + this.sp_col + Module1.ConvertFontToString(this.sytext.Font);
        }

        // Token: 0x06001108 RID: 4360 RVA: 0x00087448 File Offset: 0x00085648
        public void RestoreWater(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                this.sytext.Text = array[0];
                this.syfx.Text = array[1];
                this.sytm.Value = new decimal(Convert.ToInt32(array[2]));
                this.sytext.ForeColor = Module1.ConvertStringToColor(array[3]);
                this.sytext.Font = Module1.ConvertStringToFont(array[4]);
            }
        }

        // Token: 0x06001109 RID: 4361 RVA: 0x000874D4 File Offset: 0x000856D4
        private string SaveZDX()
        {
            string text;
            if (this.isdrawzdx.Checked)
            {
                text = "1";
            }
            else
            {
                text = "0";
            }
            if (this.zdxtype_top.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else if (this.zdxtype_left.Checked)
            {
                text = text + this.sp_col + "2";
            }
            else if (this.zdxtype_right.Checked)
            {
                text = text + this.sp_col + "3";
            }
            else
            {
                text = text + this.sp_col + "4";
            }
            text = text + this.sp_col + Convert.ToString(this.zdxposition.Value);
            text = text + this.sp_col + this.zdxtext.Text;
            text = text + this.sp_col + Module1.ConvertFontToString(this.zdxtext.Font);
            text = text + this.sp_col + Module1.ConvertColorToString(this.zdxtext.ForeColor);
            text = text + this.sp_col + Module1.ConvertColorToString(this.zdxlinecolor.ForeColor);
            if (this.zdx_solid.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else if (this.zdx_dash.Checked)
            {
                text = text + this.sp_col + "2";
            }
            else if (this.zdx_dashdot.Checked)
            {
                text = text + this.sp_col + "3";
            }
            else if (this.zdx_dashdotdot.Checked)
            {
                text = text + this.sp_col + "4";
            }
            else
            {
                text = text + this.sp_col + "5";
            }
            return text;
        }

        // Token: 0x0600110A RID: 4362 RVA: 0x0008769C File Offset: 0x0008589C
        private void RestoreZDX(string ss)
        {
            string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
            if (String.Compare(array[0], "1", false) == 0)
            {
                this.isdrawzdx.Checked = true;
            }
            else
            {
                this.isdrawzdx.Checked = false;
            }
            string left = array[1];
            if (String.Compare(left, "1", false) == 0)
            {
                this.zdxtype_top.Checked = true;
            }
            else if (String.Compare(left, "2", false) == 0)
            {
                this.zdxtype_left.Checked = true;
            }
            else if (String.Compare(left, "3", false) == 0)
            {
                this.zdxtype_right.Checked = true;
            }
            else
            {
                this.zdxtype_bottom.Checked = true;
            }
            this.zdxposition.Value = Convert.ToDecimal(array[2]);
            this.zdxtext.Text = array[3];
            this.zdxtext.Font = Module1.ConvertStringToFont(array[4]);
            this.zdxtext.ForeColor = Module1.ConvertStringToColor(array[5]);
            this.zdxlinecolor.ForeColor = Module1.ConvertStringToColor(array[6]);
            string left2 = array[7];
            if (String.Compare(left2, "1", false) == 0)
            {
                this.zdx_solid.Checked = true;
            }
            else if (String.Compare(left2, "2", false) == 0)
            {
                this.zdx_dash.Checked = true;
            }
            else if (String.Compare(left2, "3", false) == 0)
            {
                this.zdx_dashdot.Checked = true;
            }
            else if (String.Compare(left2, "4", false) == 0)
            {
                this.zdx_dashdotdot.Checked = true;
            }
            else
            {
                this.zdx_dot.Checked = true;
            }
        }

        // Token: 0x0600110B RID: 4363 RVA: 0x0008782C File Offset: 0x00085A2C
        private string SaveTableStyle()
        {
            string text;
            if (this.R1.Checked)
            {
                text = "1";
            }
            else if (this.R2.Checked)
            {
                text = "2";
            }
            else if (this.R3.Checked)
            {
                text = "3";
            }
            else
            {
                text = "4";
            }
            text = text + this.sp_col + Convert.ToString(this.gzjj.Value);
            if (this.lz.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else
            {
                text = text + this.sp_col + "0";
            }
            if (this.gzwrap.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else
            {
                text = text + this.sp_col + "0";
            }
            text = text + this.sp_col + this.ls.Text;
            text = text + this.sp_col + Convert.ToString(this.ljj.Value);
            text = text + this.sp_col + this.columns.Text;
            text = text + this.sp_col + this.minsize.Text;
            text = text + this.sp_col + Convert.ToString(this.linewidth.Value);
            text = text + this.sp_col + Module1.ConvertColorToString(this.linecolor.ForeColor);
            if (this.gwxouterborder.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else
            {
                text = text + this.sp_col + "0";
            }
            text = text + this.sp_col + Convert.ToString(this.rowheight.Value);
            text = text + this.sp_col + Convert.ToString(this.fixedrows.Value);
            if (this.addemptyrow.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else
            {
                text = text + this.sp_col + "0";
            }
            text = text + this.sp_col + Convert.ToString(this.cleft.Value);
            text = text + this.sp_col + Convert.ToString(this.cright.Value);
            text = text + this.sp_col + Convert.ToString(this.ctop.Value);
            text = text + this.sp_col + Convert.ToString(this.cbottom.Value);
            text = text + this.sp_col + Convert.ToString(this.fieldheight.Value);
            text = text + this.sp_col + this.bordertype.Text;
            if (this.zoomtopaperwidth.Checked)
            {
                text = text + this.sp_col + "1";
            }
            else
            {
                text = text + this.sp_col + "0";
            }
            return text;
        }

        // Token: 0x0600110C RID: 4364 RVA: 0x00087B28 File Offset: 0x00085D28
        private void RestoreTableStyle(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                string left = array[0];
                if (String.Compare(left, "4", false) == 0)
                {
                    this.R4.Checked = true;
                }
                else if (String.Compare(left, "3", false) == 0)
                {
                    this.R3.Checked = true;
                }
                else if (String.Compare(left, "2", false) == 0)
                {
                    this.R2.Checked = true;
                }
                else
                {
                    this.R1.Checked = true;
                }
                this.gzjj.Value = Convert.ToDecimal(array[1]);
                if (String.Compare(array[2], "1", false) == 0)
                {
                    this.lz.Checked = true;
                }
                else
                {
                    this.lz.Checked = false;
                }
                if (String.Compare(array[3], "1", false) == 0)
                {
                    this.gzwrap.Checked = true;
                }
                else
                {
                    this.gzwrap.Checked = false;
                }
                this.ls.Text = array[4];
                this.ljj.Value = Convert.ToDecimal(array[5]);
                this.columns.Text = array[6];
                this.minsize.Text = array[7];
                this.linewidth.Value = Convert.ToDecimal(array[8]);
                this.linecolor.ForeColor = Module1.ConvertStringToColor(array[9]);
                if (String.Compare(array[10], "1", false) == 0)
                {
                    this.gwxouterborder.Checked = true;
                }
                else
                {
                    this.gwxouterborder.Checked = false;
                }
                this.rowheight.Value = Convert.ToDecimal(array[11]);
                this.fixedrows.Value = new decimal(Convert.ToInt32(array[12]));
                if (String.Compare(array[13], "1", false) == 0)
                {
                    this.addemptyrow.Checked = true;
                }
                else
                {
                    this.addemptyrow.Checked = false;
                }
                this.cleft.Value = Convert.ToDecimal(array[14]);
                this.cright.Value = Convert.ToDecimal(array[15]);
                this.ctop.Value = Convert.ToDecimal(array[16]);
                this.cbottom.Value = Convert.ToDecimal(array[17]);
                this.fieldheight.Value = Convert.ToDecimal(array[18]);
                this.bordertype.SelectedItem = array[19];
                if (String.Compare(array[20], "1", false) == 0)
                {
                    this.zoomtopaperwidth.Checked = true;
                }
                else
                {
                    this.zoomtopaperwidth.Checked = false;
                }
            }
        }

        // Token: 0x0600110D RID: 4365 RVA: 0x00087DB4 File Offset: 0x00085FB4
        private string SaveTitle()
        {
            string str = this.maintitle.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.maintitle.Font);
            str = str + this.sp_col + Module1.ConvertColorToString(this.maintitle.ForeColor);
            str = str + this.sp_col + this.maintitlealign.Text;
            str = str + this.sp_col + Convert.ToString(this.maintitleheight.Value);
            if (this.maintitleprinteverpage.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            str = str + this.sp_col + SimpleReportModule.ConvertDGVtoString(this.d1);
            str = str + this.sp_col + SimpleReportModule.ConvertDGVtoString(this.d2);
            if (this.subtitlepritneverypage.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            str = str + this.sp_col + Convert.ToString(this.subtitleheight.Value);
            if (this.tablefooterprinteverypage.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            return str + this.sp_col + Convert.ToString(this.tablefooterheight.Value);
        }

        // Token: 0x0600110E RID: 4366 RVA: 0x00087F48 File Offset: 0x00086148
        private void RestoreTitle(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                this.maintitle.Text = array[0];
                this.maintitle.Font = Module1.ConvertStringToFont(array[1]);
                this.maintitle.ForeColor = Module1.ConvertStringToColor(array[2]);
                this.maintitlealign.Text = array[3];
                this.maintitleheight.Value = Convert.ToDecimal(array[4]);
                if (String.Compare(array[5], "1", false) == 0)
                {
                    this.maintitleprinteverpage.Checked = true;
                }
                else
                {
                    this.maintitleprinteverpage.Checked = false;
                }
                SimpleReportModule.ConvertStringToDGV(array[6], this.d1);
                SimpleReportModule.ConvertStringToDGV(array[7], this.d2);
                if (String.Compare(array[8], "1", false) == 0)
                {
                    this.subtitlepritneverypage.Checked = true;
                }
                else
                {
                    this.subtitlepritneverypage.Checked = false;
                }
                this.subtitleheight.Value = Convert.ToDecimal(array[9]);
                if (String.Compare(array[10], "1", false) == 0)
                {
                    this.tablefooterprinteverypage.Checked = true;
                }
                else
                {
                    this.tablefooterprinteverypage.Checked = false;
                }
                this.tablefooterheight.Value = Convert.ToDecimal(array[11]);
            }
        }

        // Token: 0x0600110F RID: 4367 RVA: 0x00088098 File Offset: 0x00086298
        public string SaveHeaderFooter()
        {
            string str = this.pagel.Text;
            str = str + this.sp_col + this.pagem.Text;
            str = str + this.sp_col + this.pager.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.pagel.Font);
            str = str + this.sp_col + Module1.ConvertColorToString(this.pagel.ForeColor);
            if (this.drawheader.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            str = str + this.sp_col + this.pageleft.Text;
            str = str + this.sp_col + this.pagemiddle.Text;
            str = str + this.sp_col + this.pageright.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.pageleft.Font);
            str = str + this.sp_col + Module1.ConvertColorToString(this.pageleft.ForeColor);
            if (this.drawfooter.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            str = str + this.sp_col + this.rightt.Text;
            str = str + this.sp_col + this.rightm.Text;
            str = str + this.sp_col + this.rightb.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.rightt.Font);
            return str + this.sp_col + Module1.ConvertColorToString(this.rightt.ForeColor);
        }

        // Token: 0x06001110 RID: 4368 RVA: 0x00088290 File Offset: 0x00086490
        public void RestoreHeaderFooter(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                this.pagel.Text = array[0];
                this.pagem.Text = array[1];
                this.pager.Text = array[2];
                this.pagel.Font = Module1.ConvertStringToFont(array[3]);
                this.pagel.ForeColor = Module1.ConvertStringToColor(array[4]);
                this.pagem.Font = this.pagel.Font;
                this.pager.Font = this.pagel.Font;
                this.pagem.ForeColor = this.pagel.ForeColor;
                this.pager.ForeColor = this.pagel.ForeColor;
                if (String.Compare(array[5], "1", false) == 0)
                {
                    this.drawheader.Checked = true;
                }
                else
                {
                    this.drawheader.Checked = false;
                }
                this.pageleft.Text = array[6];
                this.pagemiddle.Text = array[7];
                this.pageright.Text = array[8];
                this.pageleft.Font = Module1.ConvertStringToFont(array[9]);
                this.pageleft.ForeColor = Module1.ConvertStringToColor(array[10]);
                this.pagemiddle.Font = this.pageleft.Font;
                this.pageright.Font = this.pageleft.Font;
                this.pagemiddle.ForeColor = this.pageleft.ForeColor;
                this.pageright.ForeColor = this.pageleft.ForeColor;
                if (String.Compare(array[11], "1", false) == 0)
                {
                    this.drawfooter.Checked = true;
                }
                else
                {
                    this.drawfooter.Checked = false;
                }
                this.rightt.Text = array[12];
                this.rightm.Text = array[13];
                this.rightb.Text = array[14];
                this.rightt.Font = Module1.ConvertStringToFont(array[15]);
                this.rightt.ForeColor = Module1.ConvertStringToColor(array[16]);
                this.rightm.ForeColor = this.rightt.ForeColor;
                this.rightb.ForeColor = this.rightt.ForeColor;
                this.rightm.Font = this.rightt.Font;
                this.rightb.Font = this.rightt.Font;
            }
        }

        // Token: 0x06001111 RID: 4369 RVA: 0x00088518 File Offset: 0x00086718
        private string SaveTable()
        {
            if (this.t1.SelectedNode != null)
            {
                this.SaveCurrentNodeTag();
            }
            string str = SimpleReportModule.ConvertTreeViewToString(this.t1, false);
            if (this.Cforecolor.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            if (this.Cbackcolor.Checked)
            {
                str = str + this.sp_col + "1";
            }
            else
            {
                str = str + this.sp_col + "0";
            }
            str = str + this.sp_col + Module1.ConvertColorToString(this.jsh.ForeColor);
            return str + this.sp_col + Module1.ConvertColorToString(this.jsh.BackColor);
        }

        // Token: 0x06001112 RID: 4370 RVA: 0x000885F0 File Offset: 0x000867F0
        private void RestoreTable(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                this.t1.HideSelection = false;
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                SimpleReportModule.ConvertStringToTreeView(array[0], this.t1);
                if (String.Compare(array[1], "1", false) == 0)
                {
                    this.Cforecolor.Checked = true;
                }
                else
                {
                    this.Cforecolor.Checked = false;
                }
                if (String.Compare(array[2], "1", false) == 0)
                {
                    this.Cbackcolor.Checked = true;
                }
                else
                {
                    this.Cbackcolor.Checked = false;
                }
                this.jsh.ForeColor = Module1.ConvertStringToColor(array[3]);
                this.jsh.BackColor = Module1.ConvertStringToColor(array[4]);
                if (this.t1.Nodes.Count > 0)
                {
                    this.t1.SelectedNode = this.t1.Nodes[0];
                    this.ShowTag(this.t1.Nodes[0]);
                }
            }
        }

        // Token: 0x06001113 RID: 4371 RVA: 0x00088700 File Offset: 0x00086900
        private string SaveReportHeaderAndFooter()
        {
            string str = this.reportheadertext.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.reportheadertext.Font);
            str = str + this.sp_col + Module1.ConvertColorToString(this.reportheadertext.ForeColor);
            str = str + this.sp_col + this.reportheaderalignment.Text;
            str = str + this.sp_col + Convert.ToString(this.reportheaderspace.Value);
            str = str + this.sp_col + this.reportfootertext.Text;
            str = str + this.sp_col + Module1.ConvertFontToString(this.reportfootertext.Font);
            str = str + this.sp_col + Module1.ConvertColorToString(this.reportfootertext.ForeColor);
            str = str + this.sp_col + this.reportfooteralignment.Text;
            return str + this.sp_col + Convert.ToString(this.reportfooterspace.Value);
        }

        // Token: 0x06001114 RID: 4372 RVA: 0x00088818 File Offset: 0x00086A18
        private void RestoreReportHeaderAndFooter(string ss)
        {
            if (String.Compare(ss, "", false) != 0)
            {
                string[] array = Strings.Split(ss, this.sp_col, -1, CompareMethod.Binary);
                this.reportheadertext.Text = array[0];
                this.reportheadertext.Font = Module1.ConvertStringToFont(array[1]);
                this.reportheadertext.ForeColor = Module1.ConvertStringToColor(array[2]);
                this.reportheaderalignment.Text = array[3];
                this.reportheaderspace.Value = Convert.ToDecimal(array[4]);
                this.reportfootertext.Text = array[5];
                this.reportfootertext.Font = Module1.ConvertStringToFont(array[6]);
                this.reportfootertext.ForeColor = Module1.ConvertStringToColor(array[7]);
                this.reportfooteralignment.Text = array[8];
                this.reportfooterspace.Value = Convert.ToDecimal(array[9]);
            }
        }

        // Token: 0x06001115 RID: 4373 RVA: 0x000888F8 File Offset: 0x00086AF8
        public string SaveFa()
        {
            string text = this.SavePaper() + this.sp_row + this.SaveWater();
            text = string.Concat(new string[]
            {
                text,
                this.sp_row,
                this.SaveTableStyle(),
                this.sp_row,
                this.SaveTitle()
            });
            text = string.Concat(new string[]
            {
                text,
                this.sp_row,
                this.SaveHeaderFooter(),
                this.sp_row,
                this.SaveTable()
            });
            return string.Concat(new string[]
            {
                text,
                this.sp_row,
                this.SaveReportHeaderAndFooter(),
                this.sp_row,
                this.SaveZDX()
            });
        }

        // Token: 0x06001116 RID: 4374 RVA: 0x000889C8 File Offset: 0x00086BC8
        public void RestoreFa(string ss)
        {
            string[] array = Strings.Split(ss, this.sp_row, -1, CompareMethod.Binary);
            this.RestorePaper(array[0]);
            this.RestoreWater(array[1]);
            this.RestoreTableStyle(array[2]);
            this.RestoreTitle(array[3]);
            this.RestoreHeaderFooter(array[4]);
            this.RestoreTable(array[5]);
            this.RestoreReportHeaderAndFooter(array[6]);
            this.RestoreZDX(array[7]);
        }

        // Token: 0x06001117 RID: 4375 RVA: 0x00088A2C File Offset: 0x00086C2C
        private void papertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(this.papertype.Text, "[自定义纸张]", false) == 0)
            {
                this.myh.ReadOnly = false;
                this.myw.ReadOnly = false;
            }
            else
            {
                this.myh.ReadOnly = true;
                this.myw.ReadOnly = true;
                PaperSize printForm = definepaper.GetPrintForm(this.myprintername, this.papertype.Text);
                this.myw.Value = new decimal((double)printForm.Width * 2.54 / 10.0);
                this.myh.Value = new decimal((double)printForm.Height * 2.54 / 10.0);
            }
        }

        // Token: 0x06001118 RID: 4376 RVA: 0x00088AF8 File Offset: 0x00086CF8
        private void SimpleReportSet_Disposed(object sender, EventArgs e)
        {
            try
            {
                if (this.TheFieldstring != null)
                {
                    this.TheFieldstring = null;
                }
                if (this.ZdyArray != null)
                {
                    this.ZdyArray = null;
                }
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06001119 RID: 4377 RVA: 0x00088B44 File Offset: 0x00086D44
        private void SimpleReportSet_Load(object sender, EventArgs e)
        {
            this.fl.Left = this.gz.Left;
            this.fl.Top = this.gz.Top;
            this.fl.Width = this.gz.Width;
            this.fl.Height = this.gz.Height;
            this.pt.Left = this.gz.Left;
            this.pt.Top = this.gz.Top;
            this.pt.Height = this.gz.Height;
            this.pt.Width = this.gz.Width;
            this.fy.Left = this.gz.Left;
            this.fy.Top = this.gz.Top;
            this.fy.Width = this.gz.Width;
            this.fy.Height = this.gz.Height;
            this.SetPrintCS();
            this.fieldname.Items.Clear();
            checked
            {
                if (this.dgvtoprint != null)
                {
                    this.TheFieldstring = new string[this.dgvtoprint.ColumnCount - 1 + 1];
                    int num = 0;
                    int num2 = this.dgvtoprint.ColumnCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.TheFieldstring[i] = this.dgvtoprint.Columns[i].Name;
                    }
                    Array.Sort<string>(this.TheFieldstring);
                }
                if (this.TheFieldstring != null)
                {
                    int num3 = 0;
                    int num4 = this.TheFieldstring.Length - 1;
                    for (int j = num3; j <= num4; j++)
                    {
                        this.fieldname.Items.Add("[" + this.TheFieldstring[j] + "]");
                    }
                }
            }
        }

        // Token: 0x0600111A RID: 4378 RVA: 0x00088D1C File Offset: 0x00086F1C
        public void LoaDDefaultValues()
        {
            this.ls.Text = "2";
            this.columns.Text = "0";
            this.reportfooteralignment.Text = "左对齐";
            this.reportheaderalignment.Text = "左对齐";
            this.maintitlealign.Text = "左对齐";
            this.minsize.Text = "0";
            this.SetPrintCS();
            try
            {
                this.papertype.SelectedItem = "A4";
            }
            catch (Exception ex)
            {
            }
            try
            {
                this.syfx.Text = "水平";
                this.fx.Text = "纵向";
            }
            catch (Exception ex2)
            {
            }
            this.maintitlealign.Text = "居中对齐";
            this.bordertype.SelectedItem = "表格线";
        }

        // Token: 0x0600111B RID: 4379 RVA: 0x00088E1C File Offset: 0x0008701C
        private void Button27_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.sytext.Font;
            this.FontDialog1.Color = this.sytext.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.sytext.Font = this.FontDialog1.Font;
                this.sytext.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x0600111C RID: 4380 RVA: 0x00088E9C File Offset: 0x0008709C
        private void SetTS()
        {
            this.zoomtopaperwidth.Enabled = true;
            if (this.R1.Checked)
            {
                this.gz.Visible = false;
                this.fl.Visible = false;
                this.fy.Visible = false;
                this.pt.Visible = true;
                this.R1.Checked = true;
            }
            else if (this.R2.Checked)
            {
                this.fl.Visible = true;
                this.gz.Visible = false;
                this.fy.Visible = false;
                this.pt.Visible = false;
                this.R2.Checked = true;
            }
            else if (this.R3.Checked)
            {
                this.fl.Visible = false;
                this.gz.Visible = false;
                this.fy.Visible = true;
                this.pt.Visible = false;
                this.R3.Checked = true;
            }
            else if (this.R4.Checked)
            {
                this.fl.Visible = false;
                this.gz.Visible = true;
                this.fy.Visible = false;
                this.pt.Visible = false;
                this.R4.Checked = true;
                if (this.gzwrap.Checked | !this.lz.Checked)
                {
                    this.zoomtopaperwidth.Enabled = false;
                }
            }
        }

        // Token: 0x0600111D RID: 4381 RVA: 0x000065F5 File Offset: 0x000047F5
        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            this.SetTS();
        }

        // Token: 0x0600111E RID: 4382 RVA: 0x00089010 File Offset: 0x00087210
        private void linecolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.linecolor.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.linecolor.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x0600111F RID: 4383 RVA: 0x00089058 File Offset: 0x00087258
        private void Button1_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.maintitle.Font;
            this.FontDialog1.Color = this.maintitle.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.maintitle.Font = this.FontDialog1.Font;
                this.maintitle.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001120 RID: 4384 RVA: 0x000890D8 File Offset: 0x000872D8
        private void Button8_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.pagel.Font;
            this.FontDialog1.Color = this.pagel.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pagel.Font = this.FontDialog1.Font;
                this.pager.Font = this.FontDialog1.Font;
                this.pagem.Font = this.FontDialog1.Font;
                this.pagel.ForeColor = this.FontDialog1.Color;
                this.pager.ForeColor = this.FontDialog1.Color;
                this.pagem.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001121 RID: 4385 RVA: 0x000891B4 File Offset: 0x000873B4
        private void Button7_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.pageleft.Font;
            this.FontDialog1.Color = this.pageleft.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pageleft.Font = this.FontDialog1.Font;
                this.pageright.Font = this.FontDialog1.Font;
                this.pagemiddle.Font = this.FontDialog1.Font;
                this.pageleft.ForeColor = this.FontDialog1.Color;
                this.pageright.ForeColor = this.FontDialog1.Color;
                this.pagemiddle.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001122 RID: 4386 RVA: 0x00089290 File Offset: 0x00087490
        private void Button29_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.rightt.Font;
            this.FontDialog1.Color = this.rightt.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.rightt.Font = this.FontDialog1.Font;
                this.rightb.Font = this.FontDialog1.Font;
                this.rightm.Font = this.FontDialog1.Font;
                this.rightt.ForeColor = this.FontDialog1.Color;
                this.rightb.ForeColor = this.FontDialog1.Color;
                this.rightm.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001123 RID: 4387 RVA: 0x0008936C File Offset: 0x0008756C
        private void bforecolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.jsh.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.jsh.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x06001124 RID: 4388 RVA: 0x000893B4 File Offset: 0x000875B4
        private void bbackcolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.jsh.BackColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.jsh.BackColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x06001125 RID: 4389 RVA: 0x000065FD File Offset: 0x000047FD
        private void Cbackcolor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbackcolor.Checked)
            {
                this.bbackcolor.Enabled = false;
            }
            else
            {
                this.bbackcolor.Enabled = true;
            }
        }

        // Token: 0x06001126 RID: 4390 RVA: 0x00006626 File Offset: 0x00004826
        private void Cforecolor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cforecolor.Checked)
            {
                this.bforecolor.Enabled = false;
            }
            else
            {
                this.bforecolor.Enabled = true;
            }
        }

        // Token: 0x06001127 RID: 4391 RVA: 0x000893FC File Offset: 0x000875FC
        private void reportheaderfont_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.reportheadertext.Font;
            this.FontDialog1.Color = this.reportheadertext.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.reportheadertext.Font = this.FontDialog1.Font;
                this.reportheadertext.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001128 RID: 4392 RVA: 0x0008947C File Offset: 0x0008767C
        private void reportfooterfont_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.reportfootertext.Font;
            this.FontDialog1.Color = this.reportfootertext.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.reportfootertext.Font = this.FontDialog1.Font;
                this.reportfootertext.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x06001129 RID: 4393 RVA: 0x000894FC File Offset: 0x000876FC
        private void isdrawzdx_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isdrawzdx.Checked)
            {
                this.GroupBoxzdx1.Enabled = true;
                this.GroupBoxzdx2.Enabled = true;
                this.GroupBoxzdx3.Enabled = true;
            }
            else
            {
                this.GroupBoxzdx1.Enabled = false;
                this.GroupBoxzdx2.Enabled = false;
                this.GroupBoxzdx3.Enabled = false;
            }
        }

        // Token: 0x0600112A RID: 4394 RVA: 0x00089560 File Offset: 0x00087760
        private void zdxlinecolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.zdxlinecolor.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.zdxlinecolor.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x0600112B RID: 4395 RVA: 0x000895A8 File Offset: 0x000877A8
        private void Button37_Click(object sender, EventArgs e)
        {
            this.FontDialog1.ShowColor = true;
            this.FontDialog1.Font = this.zdxtext.Font;
            this.FontDialog1.Color = this.zdxtext.ForeColor;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.zdxtext.Font = this.FontDialog1.Font;
                this.zdxtext.ForeColor = this.FontDialog1.Color;
            }
        }

        // Token: 0x0600112C RID: 4396 RVA: 0x00004894 File Offset: 0x00002A94
        private void Button17_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Token: 0x0600112D RID: 4397 RVA: 0x000048A3 File Offset: 0x00002AA3
        private void Button20_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Token: 0x0600112E RID: 4398 RVA: 0x00089628 File Offset: 0x00087828
        private void maintitlealign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.maintitlealign.Text;
            HorizontalAlignment textAlign = HorizontalAlignment.Left;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Left;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Right;
            }
            this.maintitle.TextAlign = textAlign;
        }

        // Token: 0x0600112F RID: 4399 RVA: 0x0000664F File Offset: 0x0000484F
        private void Button24_Click(object sender, EventArgs e)
        {
            this.MyAdd(this.d2);
        }

        // Token: 0x06001130 RID: 4400 RVA: 0x0000665D File Offset: 0x0000485D
        private void Button6_Click(object sender, EventArgs e)
        {
            SimpleReportSet.MyDel(this.d2);
        }

        // Token: 0x06001131 RID: 4401 RVA: 0x0000666A File Offset: 0x0000486A
        private void Button5_Click(object sender, EventArgs e)
        {
            this.MyEidt(this.d2);
        }

        // Token: 0x06001132 RID: 4402 RVA: 0x00089684 File Offset: 0x00087884
        private void reportheaderalignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.reportheaderalignment.Text;
            HorizontalAlignment textAlign = HorizontalAlignment.Left;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Left;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Right;
            }
            this.reportheadertext.TextAlign = textAlign;
        }

        // Token: 0x06001133 RID: 4403 RVA: 0x000896E0 File Offset: 0x000878E0
        private void reportfooteralignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.reportfooteralignment.Text;
            HorizontalAlignment textAlign = HorizontalAlignment.Left;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Left;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Right;
            }
            this.reportfootertext.TextAlign = textAlign;
        }

        // Token: 0x06001134 RID: 4404 RVA: 0x0008973C File Offset: 0x0008793C
        private void gzwrap_CheckedChanged(object sender, EventArgs e)
        {
            if (this.gzwrap.Checked)
            {
                this.lz.Enabled = false;
                this.lz.Checked = true;
            }
            else
            {
                this.lz.Enabled = true;
            }
            if (this.R4.Checked)
            {
                if (this.gzwrap.Checked)
                {
                    this.zoomtopaperwidth.Enabled = false;
                }
                else
                {
                    this.zoomtopaperwidth.Enabled = true;
                }
            }
        }

        // Token: 0x06001135 RID: 4405 RVA: 0x00006678 File Offset: 0x00004878
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.xg.Text = SimpleReportModule.GetFormatValue(this.comptxt.Text, this.coltype.Text, this.colformat.Text);
        }

        // Token: 0x06001136 RID: 4406 RVA: 0x000066AB File Offset: 0x000048AB
        private void colformat_TextChanged(object sender, EventArgs e)
        {
            this.TextBox2_TextChanged(null, null);
        }

        // Token: 0x06001137 RID: 4407 RVA: 0x000897B0 File Offset: 0x000879B0
        private void coltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Label26.Visible = false;
            this.colformat.Visible = true;
            this.Label23.Visible = true;
            this.GroupBox9.Visible = true;
            this.GroupBox11.Visible = false;
            if (String.Compare(this.coltype.Text, "逻辑", false) == 0)
            {
                this.Label26.Visible = true;
            }
            else if (String.Compare(this.coltype.Text, "图像", false) == 0)
            {
                this.colformat.Visible = false;
                this.Label23.Visible = false;
                this.GroupBox9.Visible = false;
                this.GroupBox11.Visible = true;
            }
            if (String.Compare(this.coltype.Text, "数值", false) == 0)
            {
                this.formatbotton.Visible = true;
            }
            else
            {
                this.formatbotton.Visible = false;
            }
        }

        // Token: 0x06001138 RID: 4408 RVA: 0x0008989C File Offset: 0x00087A9C
        private void lz_CheckedChanged(object sender, EventArgs e)
        {
            if (this.R4.Checked && !this.gzwrap.Checked)
            {
                if (this.lz.Checked)
                {
                    this.zoomtopaperwidth.Enabled = true;
                }
                else
                {
                    this.zoomtopaperwidth.Enabled = false;
                }
            }
        }

        // Token: 0x06001139 RID: 4409 RVA: 0x000065AB File Offset: 0x000047AB
        private void d1_DoubleClick(object sender, EventArgs e)
        {
            this.MyEidt(this.d1);
        }

        // Token: 0x0600113A RID: 4410 RVA: 0x0000666A File Offset: 0x0000486A
        private void d2_DoubleClick(object sender, EventArgs e)
        {
            this.MyEidt(this.d2);
        }

        // Token: 0x0600113B RID: 4411 RVA: 0x000898EC File Offset: 0x00087AEC
        private void reportheadertext_DoubleClick(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                try
                {
                    TextBox textBox = (TextBox)sender;
                    textBox.Text = SimpleReportModule.ShowSimpleReportText(textBox.Text, this.TheFieldstring, this.ZdyArray);
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x0600113C RID: 4412 RVA: 0x00089948 File Offset: 0x00087B48
        private void fieldname_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - this.lastDownTime;
            this.lastDownTime = DateTime.Now;
            if (timeSpan.Milliseconds <= SystemInformation.DoubleClickTime & timeSpan.Minutes <= 0 & timeSpan.Seconds <= 0 & timeSpan.Hours <= 0 & timeSpan.Days <= 0)
            {
                this.fieldname.Text = SimpleReportModule.ShowSimpleReportText(this.fieldname.Text, this.TheFieldstring, this.ZdyArray);
            }
        }

        // Token: 0x0600113D RID: 4413 RVA: 0x000899E4 File Offset: 0x00087BE4
        private void Button12_Click(object sender, EventArgs e)
        {
            checked
            {
                if (this.t1.SelectedNode != null)
                {
                    TreeNode selectedNode = this.t1.SelectedNode;
                    if (selectedNode.Parent != null)
                    {
                        TreeNode parent = selectedNode.Parent;
                        parent.Nodes.Remove(selectedNode);
                        if (parent.Parent == null)
                        {
                            this.t1.Nodes.Insert(parent.Index + 1, selectedNode);
                        }
                        else
                        {
                            TreeNode parent2 = parent.Parent;
                            parent2.Nodes.Insert(parent.Index + 1, selectedNode);
                        }
                        this.t1.SelectedNode = selectedNode;
                        this.t1.Select();
                    }
                }
            }
        }

        // Token: 0x0600113E RID: 4414 RVA: 0x00089A7C File Offset: 0x00087C7C
        private void Button9_Click(object sender, EventArgs e)
        {
            if (this.t1.SelectedNode != null && this.t1.SelectedNode.PrevNode != null)
            {
                TreeNode prevNode = this.t1.SelectedNode.PrevNode;
                TreeNode selectedNode = this.t1.SelectedNode;
                TreeNode parent = selectedNode.Parent;
                if (parent == null)
                {
                    this.t1.Nodes.Remove(selectedNode);
                }
                else
                {
                    parent.Nodes.Remove(selectedNode);
                }
                prevNode.Nodes.Add(selectedNode);
                this.t1.SelectedNode = selectedNode;
                this.t1.Select();
            }
        }

        // Token: 0x0600113F RID: 4415 RVA: 0x00089B14 File Offset: 0x00087D14
        private void formatbotton_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.coltype.Text, "数值", false) == 0)
            {
                if (this.CurCol != null)
                {
                    SetNumberFormat setNumberFormat = new SetNumberFormat();
                    setNumberFormat.FormatString = this.colformat.Text;
                    setNumberFormat.sformatstring = this.CurCol.CellformatEx;
                    if (setNumberFormat.ShowDialog(this) == DialogResult.OK)
                    {
                        this.colformat.Text = setNumberFormat.FormatString;
                        this.CurCol.CellformatEx = setNumberFormat.sformatstring;
                        this.CurCol.CellFormat = setNumberFormat.FormatString;
                    }
                    setNumberFormat.Dispose();
                }
            }
        }

        // Token: 0x0400078A RID: 1930
        [AccessedThroughProperty("SplitContainer1")]
        private SplitContainer _SplitContainer1;

        // Token: 0x0400078B RID: 1931
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;

        // Token: 0x0400078C RID: 1932
        [AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;

        // Token: 0x0400078D RID: 1933
        [AccessedThroughProperty("GroupBoxpaper")]
        private GroupBox _GroupBoxpaper;

        // Token: 0x0400078E RID: 1934
        [AccessedThroughProperty("GroupBox24")]
        private GroupBox _GroupBox24;

        // Token: 0x0400078F RID: 1935
        [AccessedThroughProperty("myh")]
        private NumericUpDown _myh;

        // Token: 0x04000790 RID: 1936
        [AccessedThroughProperty("Label81")]
        private Label _Label81;

        // Token: 0x04000791 RID: 1937
        [AccessedThroughProperty("fx")]
        private ComboBox _fx;

        // Token: 0x04000792 RID: 1938
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x04000793 RID: 1939
        [AccessedThroughProperty("myw")]
        private NumericUpDown _myw;

        // Token: 0x04000794 RID: 1940
        [AccessedThroughProperty("Label82")]
        private Label _Label82;

        // Token: 0x04000795 RID: 1941
        [AccessedThroughProperty("papertype")]
        private ComboBox _papertype;

        // Token: 0x04000796 RID: 1942
        [AccessedThroughProperty("Label46")]
        private Label _Label46;

        // Token: 0x04000797 RID: 1943
        [AccessedThroughProperty("GroupBox14")]
        private GroupBox _GroupBox14;

        // Token: 0x04000798 RID: 1944
        [AccessedThroughProperty("Label50")]
        private Label _Label50;

        // Token: 0x04000799 RID: 1945
        [AccessedThroughProperty("Label49")]
        private Label _Label49;

        // Token: 0x0400079A RID: 1946
        [AccessedThroughProperty("Label48")]
        private Label _Label48;

        // Token: 0x0400079B RID: 1947
        [AccessedThroughProperty("Label47")]
        private Label _Label47;

        // Token: 0x0400079C RID: 1948
        [AccessedThroughProperty("GroupBoxwater")]
        private GroupBox _GroupBoxwater;

        // Token: 0x0400079D RID: 1949
        [AccessedThroughProperty("sytm")]
        private NumericUpDown _sytm;

        // Token: 0x0400079E RID: 1950
        [AccessedThroughProperty("Button27")]
        private Button _Button27;

        // Token: 0x0400079F RID: 1951
        [AccessedThroughProperty("syfx")]
        private ComboBox _syfx;

        // Token: 0x040007A0 RID: 1952
        [AccessedThroughProperty("sytext")]
        private TextBox _sytext;

        // Token: 0x040007A1 RID: 1953
        [AccessedThroughProperty("Label52")]
        private Label _Label52;

        // Token: 0x040007A2 RID: 1954
        [AccessedThroughProperty("Label53")]
        private Label _Label53;

        // Token: 0x040007A3 RID: 1955
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;

        // Token: 0x040007A4 RID: 1956
        [AccessedThroughProperty("GroupBox31")]
        private GroupBox _GroupBox31;

        // Token: 0x040007A5 RID: 1957
        [AccessedThroughProperty("linecolor")]
        private Button _linecolor;

        // Token: 0x040007A6 RID: 1958
        [AccessedThroughProperty("Label89")]
        private Label _Label89;

        // Token: 0x040007A7 RID: 1959
        [AccessedThroughProperty("gwxouterborder")]
        private CheckBox _gwxouterborder;

        // Token: 0x040007A8 RID: 1960
        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        // Token: 0x040007A9 RID: 1961
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        // Token: 0x040007AA RID: 1962
        [AccessedThroughProperty("Label30")]
        private Label _Label30;

        // Token: 0x040007AB RID: 1963
        [AccessedThroughProperty("Label29")]
        private Label _Label29;

        // Token: 0x040007AC RID: 1964
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x040007AD RID: 1965
        [AccessedThroughProperty("Label25")]
        private Label _Label25;

        // Token: 0x040007AE RID: 1966
        [AccessedThroughProperty("addemptyrow")]
        private CheckBox _addemptyrow;

        // Token: 0x040007AF RID: 1967
        [AccessedThroughProperty("minsize")]
        private ComboBox _minsize;

        // Token: 0x040007B0 RID: 1968
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x040007B1 RID: 1969
        [AccessedThroughProperty("GroupBoxtablestyle")]
        private GroupBox _GroupBoxtablestyle;

        // Token: 0x040007B2 RID: 1970
        [AccessedThroughProperty("gz")]
        private GroupBox _gz;

        // Token: 0x040007B3 RID: 1971
        [AccessedThroughProperty("gzjj")]
        private NumericUpDown _gzjj;

        // Token: 0x040007B4 RID: 1972
        [AccessedThroughProperty("gzwrap")]
        private CheckBox _gzwrap;

        // Token: 0x040007B5 RID: 1973
        [AccessedThroughProperty("lz")]
        private CheckBox _lz;

        // Token: 0x040007B6 RID: 1974
        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        // Token: 0x040007B7 RID: 1975
        [AccessedThroughProperty("R4")]
        private RadioButton _R4;

        // Token: 0x040007B8 RID: 1976
        [AccessedThroughProperty("R3")]
        private RadioButton _R3;

        // Token: 0x040007B9 RID: 1977
        [AccessedThroughProperty("fy")]
        private GroupBox _fy;

        // Token: 0x040007BA RID: 1978
        [AccessedThroughProperty("columns")]
        private ComboBox _columns;

        // Token: 0x040007BB RID: 1979
        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        // Token: 0x040007BC RID: 1980
        [AccessedThroughProperty("R2")]
        private RadioButton _R2;

        // Token: 0x040007BD RID: 1981
        [AccessedThroughProperty("fl")]
        private GroupBox _fl;

        // Token: 0x040007BE RID: 1982
        [AccessedThroughProperty("ljj")]
        private NumericUpDown _ljj;

        // Token: 0x040007BF RID: 1983
        [AccessedThroughProperty("ls")]
        private ComboBox _ls;

        // Token: 0x040007C0 RID: 1984
        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        // Token: 0x040007C1 RID: 1985
        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        // Token: 0x040007C2 RID: 1986
        [AccessedThroughProperty("pt")]
        private GroupBox _pt;

        // Token: 0x040007C3 RID: 1987
        [AccessedThroughProperty("R1")]
        private RadioButton _R1;

        // Token: 0x040007C4 RID: 1988
        [AccessedThroughProperty("TabPage5")]
        private TabPage _TabPage5;

        // Token: 0x040007C5 RID: 1989
        [AccessedThroughProperty("GroupBoxtitle2")]
        private GroupBox _GroupBoxtitle2;

        // Token: 0x040007C6 RID: 1990
        [AccessedThroughProperty("GroupBoxtitle1")]
        private GroupBox _GroupBoxtitle1;

        // Token: 0x040007C7 RID: 1991
        [AccessedThroughProperty("maintitle")]
        private TextBox _maintitle;

        // Token: 0x040007C8 RID: 1992
        [AccessedThroughProperty("Label54")]
        private Label _Label54;

        // Token: 0x040007C9 RID: 1993
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x040007CA RID: 1994
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;

        // Token: 0x040007CB RID: 1995
        [AccessedThroughProperty("Label90")]
        private Label _Label90;

        // Token: 0x040007CC RID: 1996
        [AccessedThroughProperty("Label88")]
        private Label _Label88;

        // Token: 0x040007CD RID: 1997
        [AccessedThroughProperty("GroupBoxheader3")]
        private GroupBox _GroupBoxheader3;

        // Token: 0x040007CE RID: 1998
        [AccessedThroughProperty("Button29")]
        private Button _Button29;

        // Token: 0x040007CF RID: 1999
        [AccessedThroughProperty("rightb")]
        private TextBox _rightb;

        // Token: 0x040007D0 RID: 2000
        [AccessedThroughProperty("rightm")]
        private TextBox _rightm;

        // Token: 0x040007D1 RID: 2001
        [AccessedThroughProperty("rightt")]
        private TextBox _rightt;

        // Token: 0x040007D2 RID: 2002
        [AccessedThroughProperty("Label56")]
        private Label _Label56;

        // Token: 0x040007D3 RID: 2003
        [AccessedThroughProperty("Label57")]
        private Label _Label57;

        // Token: 0x040007D4 RID: 2004
        [AccessedThroughProperty("Label58")]
        private Label _Label58;

        // Token: 0x040007D5 RID: 2005
        [AccessedThroughProperty("GroupBoxheader2")]
        private GroupBox _GroupBoxheader2;

        // Token: 0x040007D6 RID: 2006
        [AccessedThroughProperty("drawfooter")]
        private CheckBox _drawfooter;

        // Token: 0x040007D7 RID: 2007
        [AccessedThroughProperty("Button7")]
        private Button _Button7;

        // Token: 0x040007D8 RID: 2008
        [AccessedThroughProperty("pageright")]
        private TextBox _pageright;

        // Token: 0x040007D9 RID: 2009
        [AccessedThroughProperty("pagemiddle")]
        private TextBox _pagemiddle;

        // Token: 0x040007DA RID: 2010
        [AccessedThroughProperty("pageleft")]
        private TextBox _pageleft;

        // Token: 0x040007DB RID: 2011
        [AccessedThroughProperty("Label17")]
        private Label _Label17;

        // Token: 0x040007DC RID: 2012
        [AccessedThroughProperty("Label18")]
        private Label _Label18;

        // Token: 0x040007DD RID: 2013
        [AccessedThroughProperty("Label19")]
        private Label _Label19;

        // Token: 0x040007DE RID: 2014
        [AccessedThroughProperty("GroupBoxheader1")]
        private GroupBox _GroupBoxheader1;

        // Token: 0x040007DF RID: 2015
        [AccessedThroughProperty("drawheader")]
        private CheckBox _drawheader;

        // Token: 0x040007E0 RID: 2016
        [AccessedThroughProperty("Button8")]
        private Button _Button8;

        // Token: 0x040007E1 RID: 2017
        [AccessedThroughProperty("pager")]
        private TextBox _pager;

        // Token: 0x040007E2 RID: 2018
        [AccessedThroughProperty("pagem")]
        private TextBox _pagem;

        // Token: 0x040007E3 RID: 2019
        [AccessedThroughProperty("pagel")]
        private TextBox _pagel;

        // Token: 0x040007E4 RID: 2020
        [AccessedThroughProperty("Label20")]
        private Label _Label20;

        // Token: 0x040007E5 RID: 2021
        [AccessedThroughProperty("Label21")]
        private Label _Label21;

        // Token: 0x040007E6 RID: 2022
        [AccessedThroughProperty("Label22")]
        private Label _Label22;

        // Token: 0x040007E7 RID: 2023
        [AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;

        // Token: 0x040007E8 RID: 2024
        [AccessedThroughProperty("GroupBox17")]
        private GroupBox _GroupBox17;

        // Token: 0x040007E9 RID: 2025
        [AccessedThroughProperty("Cbackcolor")]
        private CheckBox _Cbackcolor;

        // Token: 0x040007EA RID: 2026
        [AccessedThroughProperty("Cforecolor")]
        private CheckBox _Cforecolor;

        // Token: 0x040007EB RID: 2027
        [AccessedThroughProperty("bbackcolor")]
        private Button _bbackcolor;

        // Token: 0x040007EC RID: 2028
        [AccessedThroughProperty("jsh")]
        private Label _jsh;

        // Token: 0x040007ED RID: 2029
        [AccessedThroughProperty("bforecolor")]
        private Button _bforecolor;

        // Token: 0x040007EE RID: 2030
        [AccessedThroughProperty("GroupBoxxx2")]
        private GroupBox _GroupBoxxx2;

        // Token: 0x040007EF RID: 2031
        [AccessedThroughProperty("Button16")]
        private Button _Button16;

        // Token: 0x040007F0 RID: 2032
        [AccessedThroughProperty("headerfont")]
        private Label _headerfont;

        // Token: 0x040007F1 RID: 2033
        [AccessedThroughProperty("Button11")]
        private Button _Button11;

        // Token: 0x040007F2 RID: 2034
        [AccessedThroughProperty("GroupBoxxx3")]
        private GroupBox _GroupBoxxx3;

        // Token: 0x040007F3 RID: 2035
        [AccessedThroughProperty("Button15")]
        private Button _Button15;

        // Token: 0x040007F4 RID: 2036
        [AccessedThroughProperty("cellfont")]
        private Label _cellfont;

        // Token: 0x040007F5 RID: 2037
        [AccessedThroughProperty("Button10")]
        private Button _Button10;

        // Token: 0x040007F6 RID: 2038
        [AccessedThroughProperty("GroupBoxformat")]
        private GroupBox _GroupBoxformat;

        // Token: 0x040007F7 RID: 2039
        [AccessedThroughProperty("colwidth")]
        private NumericUpDown _colwidth;

        // Token: 0x040007F8 RID: 2040
        [AccessedThroughProperty("Label78")]
        private Label _Label78;

        // Token: 0x040007F9 RID: 2041
        [AccessedThroughProperty("GroupBox13")]
        private GroupBox _GroupBox13;

        // Token: 0x040007FA RID: 2042
        [AccessedThroughProperty("Button19")]
        private Button _Button19;

        // Token: 0x040007FB RID: 2043
        [AccessedThroughProperty("Button18")]
        private Button _Button18;

        // Token: 0x040007FC RID: 2044
        [AccessedThroughProperty("halg")]
        private ComboBox _halg;

        // Token: 0x040007FD RID: 2045
        [AccessedThroughProperty("Label28")]
        private Label _Label28;

        // Token: 0x040007FE RID: 2046
        [AccessedThroughProperty("TabPage8")]
        private TabPage _TabPage8;

        // Token: 0x040007FF RID: 2047
        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        // Token: 0x04000800 RID: 2048
        [AccessedThroughProperty("reportfooterspace")]
        private NumericUpDown _reportfooterspace;

        // Token: 0x04000801 RID: 2049
        [AccessedThroughProperty("Label35")]
        private Label _Label35;

        // Token: 0x04000802 RID: 2050
        [AccessedThroughProperty("reportfooterfont")]
        private Button _reportfooterfont;

        // Token: 0x04000803 RID: 2051
        [AccessedThroughProperty("reportfootertext")]
        private TextBox _reportfootertext;

        // Token: 0x04000804 RID: 2052
        [AccessedThroughProperty("Label36")]
        private Label _Label36;

        // Token: 0x04000805 RID: 2053
        [AccessedThroughProperty("Label37")]
        private Label _Label37;

        // Token: 0x04000806 RID: 2054
        [AccessedThroughProperty("Label38")]
        private Label _Label38;

        // Token: 0x04000807 RID: 2055
        [AccessedThroughProperty("reportfooteralignment")]
        private ComboBox _reportfooteralignment;

        // Token: 0x04000808 RID: 2056
        [AccessedThroughProperty("GroupBox4")]
        private GroupBox _GroupBox4;

        // Token: 0x04000809 RID: 2057
        [AccessedThroughProperty("reportheaderspace")]
        private NumericUpDown _reportheaderspace;

        // Token: 0x0400080A RID: 2058
        [AccessedThroughProperty("Label34")]
        private Label _Label34;

        // Token: 0x0400080B RID: 2059
        [AccessedThroughProperty("reportheaderfont")]
        private Button _reportheaderfont;

        // Token: 0x0400080C RID: 2060
        [AccessedThroughProperty("reportheadertext")]
        private TextBox _reportheadertext;

        // Token: 0x0400080D RID: 2061
        [AccessedThroughProperty("Label33")]
        private Label _Label33;

        // Token: 0x0400080E RID: 2062
        [AccessedThroughProperty("Label32")]
        private Label _Label32;

        // Token: 0x0400080F RID: 2063
        [AccessedThroughProperty("Label31")]
        private Label _Label31;

        // Token: 0x04000810 RID: 2064
        [AccessedThroughProperty("reportheaderalignment")]
        private ComboBox _reportheaderalignment;

        // Token: 0x04000811 RID: 2065
        [AccessedThroughProperty("TabPage7")]
        private TabPage _TabPage7;

        // Token: 0x04000812 RID: 2066
        [AccessedThroughProperty("GroupBoxZDX")]
        private GroupBox _GroupBoxZDX;

        // Token: 0x04000813 RID: 2067
        [AccessedThroughProperty("GroupBoxzdx3")]
        private GroupBox _GroupBoxzdx3;

        // Token: 0x04000814 RID: 2068
        [AccessedThroughProperty("zdxlinecolor")]
        private Button _zdxlinecolor;

        // Token: 0x04000815 RID: 2069
        [AccessedThroughProperty("zdx_dashdotdot")]
        private RadioButton _zdx_dashdotdot;

        // Token: 0x04000816 RID: 2070
        [AccessedThroughProperty("zdx_dashdot")]
        private RadioButton _zdx_dashdot;

        // Token: 0x04000817 RID: 2071
        [AccessedThroughProperty("zdx_dot")]
        private RadioButton _zdx_dot;

        // Token: 0x04000818 RID: 2072
        [AccessedThroughProperty("zdx_dash")]
        private RadioButton _zdx_dash;

        // Token: 0x04000819 RID: 2073
        [AccessedThroughProperty("zdx_solid")]
        private RadioButton _zdx_solid;

        // Token: 0x0400081A RID: 2074
        [AccessedThroughProperty("GroupBoxzdx2")]
        private GroupBox _GroupBoxzdx2;

        // Token: 0x0400081B RID: 2075
        [AccessedThroughProperty("zdxtext")]
        private TextBox _zdxtext;

        // Token: 0x0400081C RID: 2076
        [AccessedThroughProperty("Button37")]
        private Button _Button37;

        // Token: 0x0400081D RID: 2077
        [AccessedThroughProperty("GroupBoxzdx1")]
        private GroupBox _GroupBoxzdx1;

        // Token: 0x0400081E RID: 2078
        [AccessedThroughProperty("zdxtype_bottom")]
        private RadioButton _zdxtype_bottom;

        // Token: 0x0400081F RID: 2079
        [AccessedThroughProperty("zdxtype_right")]
        private RadioButton _zdxtype_right;

        // Token: 0x04000820 RID: 2080
        [AccessedThroughProperty("zdxtype_top")]
        private RadioButton _zdxtype_top;

        // Token: 0x04000821 RID: 2081
        [AccessedThroughProperty("zdxtype_left")]
        private RadioButton _zdxtype_left;

        // Token: 0x04000822 RID: 2082
        [AccessedThroughProperty("Label83")]
        private Label _Label83;

        // Token: 0x04000823 RID: 2083
        [AccessedThroughProperty("isdrawzdx")]
        private CheckBox _isdrawzdx;

        // Token: 0x04000824 RID: 2084
        [AccessedThroughProperty("GroupBox5")]
        private GroupBox _GroupBox5;

        // Token: 0x04000825 RID: 2085
        [AccessedThroughProperty("tablefooterheight")]
        private NumericUpDown _tablefooterheight;

        // Token: 0x04000826 RID: 2086
        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        // Token: 0x04000827 RID: 2087
        [AccessedThroughProperty("d2")]
        private DataGridView _d2;

        // Token: 0x04000828 RID: 2088
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x04000829 RID: 2089
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

        // Token: 0x0400082A RID: 2090
        [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

        // Token: 0x0400082B RID: 2091
        [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

        // Token: 0x0400082C RID: 2092
        [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

        // Token: 0x0400082D RID: 2093
        [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

        // Token: 0x0400082E RID: 2094
        [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

        // Token: 0x0400082F RID: 2095
        [AccessedThroughProperty("tablefooterprinteverypage")]
        private CheckBox _tablefooterprinteverypage;

        // Token: 0x04000830 RID: 2096
        [AccessedThroughProperty("Button5")]
        private Button _Button5;

        // Token: 0x04000831 RID: 2097
        [AccessedThroughProperty("Button6")]
        private Button _Button6;

        // Token: 0x04000832 RID: 2098
        [AccessedThroughProperty("Button24")]
        private Button _Button24;

        // Token: 0x04000833 RID: 2099
        [AccessedThroughProperty("subtitleheight")]
        private NumericUpDown _subtitleheight;

        // Token: 0x04000834 RID: 2100
        [AccessedThroughProperty("Label41")]
        private Label _Label41;

        // Token: 0x04000835 RID: 2101
        [AccessedThroughProperty("d1")]
        private DataGridView _d1;

        // Token: 0x04000836 RID: 2102
        [AccessedThroughProperty("subtitlepritneverypage")]
        private CheckBox _subtitlepritneverypage;

        // Token: 0x04000837 RID: 2103
        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        // Token: 0x04000838 RID: 2104
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000839 RID: 2105
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x0400083A RID: 2106
        [AccessedThroughProperty("maintitleheight")]
        private NumericUpDown _maintitleheight;

        // Token: 0x0400083B RID: 2107
        [AccessedThroughProperty("Label40")]
        private Label _Label40;

        // Token: 0x0400083C RID: 2108
        [AccessedThroughProperty("maintitleprinteverpage")]
        private CheckBox _maintitleprinteverpage;

        // Token: 0x0400083D RID: 2109
        [AccessedThroughProperty("maintitlealign")]
        private ComboBox _maintitlealign;

        // Token: 0x0400083E RID: 2110
        [AccessedThroughProperty("Button33")]
        private Button _Button33;

        // Token: 0x0400083F RID: 2111
        [AccessedThroughProperty("Button32")]
        private Button _Button32;

        // Token: 0x04000840 RID: 2112
        [AccessedThroughProperty("Button31")]
        private Button _Button31;

        // Token: 0x04000841 RID: 2113
        [AccessedThroughProperty("t1")]
        private TreeView _t1;

        // Token: 0x04000842 RID: 2114
        [AccessedThroughProperty("isprint")]
        private CheckBox _isprint;

        // Token: 0x04000843 RID: 2115
        [AccessedThroughProperty("iscomp")]
        private CheckBox _iscomp;

        // Token: 0x04000844 RID: 2116
        [AccessedThroughProperty("fieldtitle")]
        private TextBox _fieldtitle;

        // Token: 0x04000845 RID: 2117
        [AccessedThroughProperty("fieldname")]
        private ComboBox _fieldname;

        // Token: 0x04000846 RID: 2118
        [AccessedThroughProperty("Label13")]
        private Label _Label13;

        // Token: 0x04000847 RID: 2119
        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        // Token: 0x04000848 RID: 2120
        [AccessedThroughProperty("Label15")]
        private Label _Label15;

        // Token: 0x04000849 RID: 2121
        [AccessedThroughProperty("valg")]
        private ComboBox _valg;

        // Token: 0x0400084A RID: 2122
        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;

        // Token: 0x0400084B RID: 2123
        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _ColorDialog1;

        // Token: 0x0400084C RID: 2124
        [AccessedThroughProperty("FontDialog1")]
        private FontDialog _FontDialog1;

        // Token: 0x0400084D RID: 2125
        [AccessedThroughProperty("coltype")]
        private ListBox _coltype;

        // Token: 0x0400084E RID: 2126
        [AccessedThroughProperty("colformat")]
        private TextBox _colformat;

        // Token: 0x0400084F RID: 2127
        [AccessedThroughProperty("ml")]
        private CheckBox _ml;

        // Token: 0x04000850 RID: 2128
        [AccessedThroughProperty("printzero")]
        private CheckBox _printzero;

        // Token: 0x04000851 RID: 2129
        [AccessedThroughProperty("pagemarginr")]
        private NumericUpDown _pagemarginr;

        // Token: 0x04000852 RID: 2130
        [AccessedThroughProperty("pagemarginl")]
        private NumericUpDown _pagemarginl;

        // Token: 0x04000853 RID: 2131
        [AccessedThroughProperty("pagemarginb")]
        private NumericUpDown _pagemarginb;

        // Token: 0x04000854 RID: 2132
        [AccessedThroughProperty("pagemargint")]
        private NumericUpDown _pagemargint;

        // Token: 0x04000855 RID: 2133
        [AccessedThroughProperty("zdxposition")]
        private NumericUpDown _zdxposition;

        // Token: 0x04000856 RID: 2134
        [AccessedThroughProperty("fixedrows")]
        private NumericUpDown _fixedrows;

        // Token: 0x04000857 RID: 2135
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000858 RID: 2136
        [AccessedThroughProperty("rowheight")]
        private NumericUpDown _rowheight;

        // Token: 0x04000859 RID: 2137
        [AccessedThroughProperty("Label24")]
        private Label _Label24;

        // Token: 0x0400085A RID: 2138
        [AccessedThroughProperty("linewidth")]
        private NumericUpDown _linewidth;

        // Token: 0x0400085B RID: 2139
        [AccessedThroughProperty("cbottom")]
        private NumericUpDown _cbottom;

        // Token: 0x0400085C RID: 2140
        [AccessedThroughProperty("ctop")]
        private NumericUpDown _ctop;

        // Token: 0x0400085D RID: 2141
        [AccessedThroughProperty("cright")]
        private NumericUpDown _cright;

        // Token: 0x0400085E RID: 2142
        [AccessedThroughProperty("cleft")]
        private NumericUpDown _cleft;

        // Token: 0x0400085F RID: 2143
        [AccessedThroughProperty("Button20")]
        private Button _Button20;

        // Token: 0x04000860 RID: 2144
        [AccessedThroughProperty("Button17")]
        private Button _Button17;

        // Token: 0x04000861 RID: 2145
        [AccessedThroughProperty("fieldheight")]
        private NumericUpDown _fieldheight;

        // Token: 0x04000862 RID: 2146
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000863 RID: 2147
        [AccessedThroughProperty("bordertype")]
        private ComboBox _bordertype;

        // Token: 0x04000864 RID: 2148
        [AccessedThroughProperty("Label27")]
        private Label _Label27;

        // Token: 0x04000865 RID: 2149
        [AccessedThroughProperty("GroupBox8")]
        private GroupBox _GroupBox8;

        // Token: 0x04000866 RID: 2150
        [AccessedThroughProperty("GroupBox6")]
        private GroupBox _GroupBox6;

        // Token: 0x04000867 RID: 2151
        [AccessedThroughProperty("GroupBox7")]
        private GroupBox _GroupBox7;

        // Token: 0x04000868 RID: 2152
        [AccessedThroughProperty("GroupBox9")]
        private GroupBox _GroupBox9;

        // Token: 0x04000869 RID: 2153
        [AccessedThroughProperty("xg")]
        private TextBox _xg;

        // Token: 0x0400086A RID: 2154
        [AccessedThroughProperty("Label16")]
        private Label _Label16;

        // Token: 0x0400086B RID: 2155
        [AccessedThroughProperty("comptxt")]
        private TextBox _comptxt;

        // Token: 0x0400086C RID: 2156
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x0400086D RID: 2157
        [AccessedThroughProperty("Label23")]
        private Label _Label23;

        // Token: 0x0400086E RID: 2158
        [AccessedThroughProperty("Label26")]
        private Label _Label26;

        // Token: 0x0400086F RID: 2159
        [AccessedThroughProperty("zoomtopaperwidth")]
        private CheckBox _zoomtopaperwidth;

        // Token: 0x04000870 RID: 2160
        [AccessedThroughProperty("GroupBox10")]
        private GroupBox _GroupBox10;

        // Token: 0x04000871 RID: 2161
        [AccessedThroughProperty("Button9")]
        private Button _Button9;

        // Token: 0x04000872 RID: 2162
        [AccessedThroughProperty("Button12")]
        private Button _Button12;

        // Token: 0x04000873 RID: 2163
        [AccessedThroughProperty("打印内容")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

        // Token: 0x04000874 RID: 2164
        [AccessedThroughProperty("打印级次")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

        // Token: 0x04000875 RID: 2165
        [AccessedThroughProperty("对齐方式")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

        // Token: 0x04000876 RID: 2166
        [AccessedThroughProperty("字体字号")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

        // Token: 0x04000877 RID: 2167
        [AccessedThroughProperty("打印高度")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

        // Token: 0x04000878 RID: 2168
        [AccessedThroughProperty("打印宽度")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

        // Token: 0x04000879 RID: 2169
        [AccessedThroughProperty("前景颜色")]
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

        // Token: 0x0400087A RID: 2170
        [AccessedThroughProperty("ImageList1")]
        private ImageList _ImageList1;

        // Token: 0x0400087B RID: 2171
        [AccessedThroughProperty("Label14")]
        private Label _Label14;

        // Token: 0x0400087C RID: 2172
        [AccessedThroughProperty("formatbotton")]
        private Button _formatbotton;

        // Token: 0x0400087D RID: 2173
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;

        // Token: 0x0400087E RID: 2174
        [AccessedThroughProperty("GroupBox11")]
        private GroupBox _GroupBox11;

        // Token: 0x0400087F RID: 2175
        [AccessedThroughProperty("RadioButton3")]
        private RadioButton _RadioButton3;

        // Token: 0x04000880 RID: 2176
        [AccessedThroughProperty("RadioButton2")]
        private RadioButton _RadioButton2;

        // Token: 0x04000881 RID: 2177
        [AccessedThroughProperty("RadioButton1")]
        private RadioButton _RadioButton1;

        // Token: 0x04000883 RID: 2179
        private string sp_row;

        // Token: 0x04000884 RID: 2180
        private string sp_col;

        // Token: 0x04000885 RID: 2181
        public DataGridView dgvtoprint;

        // Token: 0x04000886 RID: 2182
        public string[] TheFieldstring;

        // Token: 0x04000887 RID: 2183
        public string[] ZdyArray;

        // Token: 0x04000888 RID: 2184
        public string myprintername;

        // Token: 0x04000889 RID: 2185
        private DateTime lastDownTime;
    }
}
