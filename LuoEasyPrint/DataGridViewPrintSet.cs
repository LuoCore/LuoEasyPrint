using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;


namespace LuoEasyPrint
{
    // Token: 0x02000010 RID: 16
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerGenerated]
    public partial class DataGridViewPrintSet : Form
    {
        // Token: 0x17000071 RID: 113
        // (get) Token: 0x06000157 RID: 343 RVA: 0x0001EC0C File Offset: 0x0001CE0C
        // (set) Token: 0x06000158 RID: 344 RVA: 0x00002984 File Offset: 0x00000B84
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

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x06000159 RID: 345 RVA: 0x0001EC24 File Offset: 0x0001CE24
        // (set) Token: 0x0600015A RID: 346 RVA: 0x0001EC3C File Offset: 0x0001CE3C
        internal virtual RadioButton R4
        {
            get
            {
                return this._R4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R4_CheckedChanged);
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

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x0600015B RID: 347 RVA: 0x0001EC88 File Offset: 0x0001CE88
        // (set) Token: 0x0600015C RID: 348 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
        internal virtual RadioButton R3
        {
            get
            {
                return this._R3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R3_CheckedChanged);
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

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x0600015D RID: 349 RVA: 0x0001ECEC File Offset: 0x0001CEEC
        // (set) Token: 0x0600015E RID: 350 RVA: 0x0001ED04 File Offset: 0x0001CF04
        internal virtual RadioButton R2
        {
            get
            {
                return this._R2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.R2_CheckedChanged);
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

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x0600015F RID: 351 RVA: 0x0001ED50 File Offset: 0x0001CF50
        // (set) Token: 0x06000160 RID: 352 RVA: 0x0001ED68 File Offset: 0x0001CF68
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

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x06000161 RID: 353 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
        // (set) Token: 0x06000162 RID: 354 RVA: 0x0000298D File Offset: 0x00000B8D
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

        // Token: 0x17000077 RID: 119
        // (get) Token: 0x06000163 RID: 355 RVA: 0x0001EDCC File Offset: 0x0001CFCC
        // (set) Token: 0x06000164 RID: 356 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
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

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x06000165 RID: 357 RVA: 0x0001EE30 File Offset: 0x0001D030
        // (set) Token: 0x06000166 RID: 358 RVA: 0x00002996 File Offset: 0x00000B96
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

        // Token: 0x17000079 RID: 121
        // (get) Token: 0x06000167 RID: 359 RVA: 0x0001EE48 File Offset: 0x0001D048
        // (set) Token: 0x06000168 RID: 360 RVA: 0x0000299F File Offset: 0x00000B9F
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

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x06000169 RID: 361 RVA: 0x0001EE60 File Offset: 0x0001D060
        // (set) Token: 0x0600016A RID: 362 RVA: 0x000029A8 File Offset: 0x00000BA8
        internal virtual ComboBox dq
        {
            get
            {
                return this._dq;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._dq = value;
            }
        }

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x0600016B RID: 363 RVA: 0x0001EE78 File Offset: 0x0001D078
        // (set) Token: 0x0600016C RID: 364 RVA: 0x000029B1 File Offset: 0x00000BB1
        internal virtual ComboBox bk
        {
            get
            {
                return this._bk;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._bk = value;
            }
        }

        // Token: 0x1700007C RID: 124
        // (get) Token: 0x0600016D RID: 365 RVA: 0x0001EE90 File Offset: 0x0001D090
        // (set) Token: 0x0600016E RID: 366 RVA: 0x000029BA File Offset: 0x00000BBA
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

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x0600016F RID: 367 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
        // (set) Token: 0x06000170 RID: 368 RVA: 0x000029C3 File Offset: 0x00000BC3
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

        // Token: 0x1700007E RID: 126
        // (get) Token: 0x06000171 RID: 369 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
        // (set) Token: 0x06000172 RID: 370 RVA: 0x000029CC File Offset: 0x00000BCC
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

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x06000173 RID: 371 RVA: 0x0001EED8 File Offset: 0x0001D0D8
        // (set) Token: 0x06000174 RID: 372 RVA: 0x000029D5 File Offset: 0x00000BD5
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

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x06000175 RID: 373 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
        // (set) Token: 0x06000176 RID: 374 RVA: 0x000029DE File Offset: 0x00000BDE
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

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x06000177 RID: 375 RVA: 0x0001EF08 File Offset: 0x0001D108
        // (set) Token: 0x06000178 RID: 376 RVA: 0x000029E7 File Offset: 0x00000BE7
        internal virtual CheckBox bj
        {
            get
            {
                return this._bj;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._bj = value;
            }
        }

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x06000179 RID: 377 RVA: 0x0001EF20 File Offset: 0x0001D120
        // (set) Token: 0x0600017A RID: 378 RVA: 0x000029F0 File Offset: 0x00000BF0
        internal virtual CheckBox bt
        {
            get
            {
                return this._bt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._bt = value;
            }
        }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x0600017B RID: 379 RVA: 0x0001EF38 File Offset: 0x0001D138
        // (set) Token: 0x0600017C RID: 380 RVA: 0x000029F9 File Offset: 0x00000BF9
        internal virtual CheckBox gd
        {
            get
            {
                return this._gd;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gd = value;
            }
        }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x0600017D RID: 381 RVA: 0x0001EF50 File Offset: 0x0001D150
        // (set) Token: 0x0600017E RID: 382 RVA: 0x0001EF68 File Offset: 0x0001D168
        internal virtual CheckBox kd
        {
            get
            {
                return this._kd;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.kd_CheckedChanged);
                if (this._kd != null)
                {
                    this._kd.CheckedChanged -= value2;
                }
                this._kd = value;
                if (this._kd != null)
                {
                    this._kd.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000085 RID: 133
        // (get) Token: 0x0600017F RID: 383 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
        // (set) Token: 0x06000180 RID: 384 RVA: 0x00002A02 File Offset: 0x00000C02
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

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x06000181 RID: 385 RVA: 0x0001EFCC File Offset: 0x0001D1CC
        // (set) Token: 0x06000182 RID: 386 RVA: 0x00002A0B File Offset: 0x00000C0B
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

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x06000183 RID: 387 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
        // (set) Token: 0x06000184 RID: 388 RVA: 0x00002A14 File Offset: 0x00000C14
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

        // Token: 0x17000088 RID: 136
        // (get) Token: 0x06000185 RID: 389 RVA: 0x0001EFFC File Offset: 0x0001D1FC
        // (set) Token: 0x06000186 RID: 390 RVA: 0x00002A1D File Offset: 0x00000C1D
        internal virtual CheckBox lz
        {
            get
            {
                return this._lz;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lz = value;
            }
        }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x06000187 RID: 391 RVA: 0x0001F014 File Offset: 0x0001D214
        // (set) Token: 0x06000188 RID: 392 RVA: 0x00002A26 File Offset: 0x00000C26
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

        // Token: 0x1700008A RID: 138
        // (get) Token: 0x06000189 RID: 393 RVA: 0x0001F02C File Offset: 0x0001D22C
        // (set) Token: 0x0600018A RID: 394 RVA: 0x00002A2F File Offset: 0x00000C2F
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

        // Token: 0x1700008B RID: 139
        // (get) Token: 0x0600018B RID: 395 RVA: 0x0001F044 File Offset: 0x0001D244
        // (set) Token: 0x0600018C RID: 396 RVA: 0x00002A38 File Offset: 0x00000C38
        internal virtual CheckBox zh
        {
            get
            {
                return this._zh;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zh = value;
            }
        }

        // Token: 0x1700008C RID: 140
        // (get) Token: 0x0600018D RID: 397 RVA: 0x0001F05C File Offset: 0x0001D25C
        // (set) Token: 0x0600018E RID: 398 RVA: 0x00002A41 File Offset: 0x00000C41
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

        // Token: 0x1700008D RID: 141
        // (get) Token: 0x0600018F RID: 399 RVA: 0x0001F074 File Offset: 0x0001D274
        // (set) Token: 0x06000190 RID: 400 RVA: 0x00002A4A File Offset: 0x00000C4A
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

        // Token: 0x1700008E RID: 142
        // (get) Token: 0x06000191 RID: 401 RVA: 0x0001F08C File Offset: 0x0001D28C
        // (set) Token: 0x06000192 RID: 402 RVA: 0x00002A53 File Offset: 0x00000C53
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

        // Token: 0x1700008F RID: 143
        // (get) Token: 0x06000193 RID: 403 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
        // (set) Token: 0x06000194 RID: 404 RVA: 0x00002A5C File Offset: 0x00000C5C
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

        // Token: 0x17000090 RID: 144
        // (get) Token: 0x06000195 RID: 405 RVA: 0x0001F0BC File Offset: 0x0001D2BC
        // (set) Token: 0x06000196 RID: 406 RVA: 0x00002A65 File Offset: 0x00000C65
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

        // Token: 0x17000091 RID: 145
        // (get) Token: 0x06000197 RID: 407 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
        // (set) Token: 0x06000198 RID: 408 RVA: 0x00002A6E File Offset: 0x00000C6E
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

        // Token: 0x17000092 RID: 146
        // (get) Token: 0x06000199 RID: 409 RVA: 0x0001F0EC File Offset: 0x0001D2EC
        // (set) Token: 0x0600019A RID: 410 RVA: 0x00002A77 File Offset: 0x00000C77
        internal virtual DataGridView dgvtoprint
        {
            get
            {
                return this._dgvtoprint;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._dgvtoprint = value;
            }
        }

        // Token: 0x17000093 RID: 147
        // (get) Token: 0x0600019B RID: 411 RVA: 0x0001F104 File Offset: 0x0001D304
        // (set) Token: 0x0600019C RID: 412 RVA: 0x00002A80 File Offset: 0x00000C80
        internal virtual CheckBox gsf
        {
            get
            {
                return this._gsf;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gsf = value;
            }
        }

        // Token: 0x17000094 RID: 148
        // (get) Token: 0x0600019D RID: 413 RVA: 0x0001F11C File Offset: 0x0001D31C
        // (set) Token: 0x0600019E RID: 414 RVA: 0x00002A89 File Offset: 0x00000C89
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

        // Token: 0x17000095 RID: 149
        // (get) Token: 0x0600019F RID: 415 RVA: 0x0001F134 File Offset: 0x0001D334
        // (set) Token: 0x060001A0 RID: 416 RVA: 0x0001F14C File Offset: 0x0001D34C
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

        // Token: 0x17000096 RID: 150
        // (get) Token: 0x060001A1 RID: 417 RVA: 0x0001F198 File Offset: 0x0001D398
        // (set) Token: 0x060001A2 RID: 418 RVA: 0x00002A92 File Offset: 0x00000C92
        internal virtual TextBox pageright
        {
            get
            {
                return this._pageright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pageright = value;
            }
        }

        // Token: 0x17000097 RID: 151
        // (get) Token: 0x060001A3 RID: 419 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
        // (set) Token: 0x060001A4 RID: 420 RVA: 0x00002A9B File Offset: 0x00000C9B
        internal virtual TextBox pagemiddle
        {
            get
            {
                return this._pagemiddle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagemiddle = value;
            }
        }

        // Token: 0x17000098 RID: 152
        // (get) Token: 0x060001A5 RID: 421 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
        // (set) Token: 0x060001A6 RID: 422 RVA: 0x00002AA4 File Offset: 0x00000CA4
        internal virtual TextBox pageleft
        {
            get
            {
                return this._pageleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pageleft = value;
            }
        }

        // Token: 0x17000099 RID: 153
        // (get) Token: 0x060001A7 RID: 423 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
        // (set) Token: 0x060001A8 RID: 424 RVA: 0x00002AAD File Offset: 0x00000CAD
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

        // Token: 0x1700009A RID: 154
        // (get) Token: 0x060001A9 RID: 425 RVA: 0x0001F1F8 File Offset: 0x0001D3F8
        // (set) Token: 0x060001AA RID: 426 RVA: 0x00002AB6 File Offset: 0x00000CB6
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

        // Token: 0x1700009B RID: 155
        // (get) Token: 0x060001AB RID: 427 RVA: 0x0001F210 File Offset: 0x0001D410
        // (set) Token: 0x060001AC RID: 428 RVA: 0x00002ABF File Offset: 0x00000CBF
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

        // Token: 0x1700009C RID: 156
        // (get) Token: 0x060001AD RID: 429 RVA: 0x0001F228 File Offset: 0x0001D428
        // (set) Token: 0x060001AE RID: 430 RVA: 0x00002AC8 File Offset: 0x00000CC8
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

        // Token: 0x1700009D RID: 157
        // (get) Token: 0x060001AF RID: 431 RVA: 0x0001F240 File Offset: 0x0001D440
        // (set) Token: 0x060001B0 RID: 432 RVA: 0x0001F258 File Offset: 0x0001D458
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

        // Token: 0x1700009E RID: 158
        // (get) Token: 0x060001B1 RID: 433 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
        // (set) Token: 0x060001B2 RID: 434 RVA: 0x00002AD1 File Offset: 0x00000CD1
        internal virtual TextBox pager
        {
            get
            {
                return this._pager;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pager = value;
            }
        }

        // Token: 0x1700009F RID: 159
        // (get) Token: 0x060001B3 RID: 435 RVA: 0x0001F2BC File Offset: 0x0001D4BC
        // (set) Token: 0x060001B4 RID: 436 RVA: 0x00002ADA File Offset: 0x00000CDA
        internal virtual TextBox pagem
        {
            get
            {
                return this._pagem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagem = value;
            }
        }

        // Token: 0x170000A0 RID: 160
        // (get) Token: 0x060001B5 RID: 437 RVA: 0x0001F2D4 File Offset: 0x0001D4D4
        // (set) Token: 0x060001B6 RID: 438 RVA: 0x00002AE3 File Offset: 0x00000CE3
        internal virtual TextBox pagel
        {
            get
            {
                return this._pagel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pagel = value;
            }
        }

        // Token: 0x170000A1 RID: 161
        // (get) Token: 0x060001B7 RID: 439 RVA: 0x0001F2EC File Offset: 0x0001D4EC
        // (set) Token: 0x060001B8 RID: 440 RVA: 0x00002AEC File Offset: 0x00000CEC
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

        // Token: 0x170000A2 RID: 162
        // (get) Token: 0x060001B9 RID: 441 RVA: 0x0001F304 File Offset: 0x0001D504
        // (set) Token: 0x060001BA RID: 442 RVA: 0x00002AF5 File Offset: 0x00000CF5
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

        // Token: 0x170000A3 RID: 163
        // (get) Token: 0x060001BB RID: 443 RVA: 0x0001F31C File Offset: 0x0001D51C
        // (set) Token: 0x060001BC RID: 444 RVA: 0x00002AFE File Offset: 0x00000CFE
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

        // Token: 0x170000A4 RID: 164
        // (get) Token: 0x060001BD RID: 445 RVA: 0x0001F334 File Offset: 0x0001D534
        // (set) Token: 0x060001BE RID: 446 RVA: 0x00002B07 File Offset: 0x00000D07
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

        // Token: 0x170000A5 RID: 165
        // (get) Token: 0x060001BF RID: 447 RVA: 0x0001F34C File Offset: 0x0001D54C
        // (set) Token: 0x060001C0 RID: 448 RVA: 0x00002B10 File Offset: 0x00000D10
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

        // Token: 0x170000A6 RID: 166
        // (get) Token: 0x060001C1 RID: 449 RVA: 0x0001F364 File Offset: 0x0001D564
        // (set) Token: 0x060001C2 RID: 450 RVA: 0x00002B19 File Offset: 0x00000D19
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

        // Token: 0x170000A7 RID: 167
        // (get) Token: 0x060001C3 RID: 451 RVA: 0x0001F37C File Offset: 0x0001D57C
        // (set) Token: 0x060001C4 RID: 452 RVA: 0x00002B22 File Offset: 0x00000D22
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

        // Token: 0x170000A8 RID: 168
        // (get) Token: 0x060001C5 RID: 453 RVA: 0x0001F394 File Offset: 0x0001D594
        // (set) Token: 0x060001C6 RID: 454 RVA: 0x00002B2B File Offset: 0x00000D2B
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

        // Token: 0x170000A9 RID: 169
        // (get) Token: 0x060001C7 RID: 455 RVA: 0x0001F3AC File Offset: 0x0001D5AC
        // (set) Token: 0x060001C8 RID: 456 RVA: 0x00002B34 File Offset: 0x00000D34
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

        // Token: 0x170000AA RID: 170
        // (get) Token: 0x060001C9 RID: 457 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
        // (set) Token: 0x060001CA RID: 458 RVA: 0x0001F3DC File Offset: 0x0001D5DC
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

        // Token: 0x170000AB RID: 171
        // (get) Token: 0x060001CB RID: 459 RVA: 0x0001F428 File Offset: 0x0001D628
        // (set) Token: 0x060001CC RID: 460 RVA: 0x0001F440 File Offset: 0x0001D640
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

        // Token: 0x170000AC RID: 172
        // (get) Token: 0x060001CD RID: 461 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
        // (set) Token: 0x060001CE RID: 462 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
        internal virtual Label fontshow
        {
            get
            {
                return this._fontshow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.fontshow_ForeColorChanged);
                EventHandler value3 = new EventHandler(this.fontshow_BackColorChanged);
                if (this._fontshow != null)
                {
                    this._fontshow.ForeColorChanged -= value2;
                    this._fontshow.BackColorChanged -= value3;
                }
                this._fontshow = value;
                if (this._fontshow != null)
                {
                    this._fontshow.ForeColorChanged += value2;
                    this._fontshow.BackColorChanged += value3;
                }
            }
        }

        // Token: 0x170000AD RID: 173
        // (get) Token: 0x060001CF RID: 463 RVA: 0x0001F538 File Offset: 0x0001D738
        // (set) Token: 0x060001D0 RID: 464 RVA: 0x00002B3D File Offset: 0x00000D3D
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

        // Token: 0x170000AE RID: 174
        // (get) Token: 0x060001D1 RID: 465 RVA: 0x0001F550 File Offset: 0x0001D750
        // (set) Token: 0x060001D2 RID: 466 RVA: 0x00002B46 File Offset: 0x00000D46
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

        // Token: 0x170000AF RID: 175
        // (get) Token: 0x060001D3 RID: 467 RVA: 0x0001F568 File Offset: 0x0001D768
        // (set) Token: 0x060001D4 RID: 468 RVA: 0x00002B4F File Offset: 0x00000D4F
        internal virtual GroupBox GroupBoxxx1
        {
            get
            {
                return this._GroupBoxxx1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxxx1 = value;
            }
        }

        // Token: 0x170000B0 RID: 176
        // (get) Token: 0x060001D5 RID: 469 RVA: 0x0001F580 File Offset: 0x0001D780
        // (set) Token: 0x060001D6 RID: 470 RVA: 0x0001F598 File Offset: 0x0001D798
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

        // Token: 0x170000B1 RID: 177
        // (get) Token: 0x060001D7 RID: 471 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
        // (set) Token: 0x060001D8 RID: 472 RVA: 0x0001F5FC File Offset: 0x0001D7FC
        internal virtual ComboBox ldq
        {
            get
            {
                return this._ldq;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.dq_SelectedIndexChanged_1);
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

        // Token: 0x170000B2 RID: 178
        // (get) Token: 0x060001D9 RID: 473 RVA: 0x0001F648 File Offset: 0x0001D848
        // (set) Token: 0x060001DA RID: 474 RVA: 0x0001F660 File Offset: 0x0001D860
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

        // Token: 0x170000B3 RID: 179
        // (get) Token: 0x060001DB RID: 475 RVA: 0x0001F6AC File Offset: 0x0001D8AC
        // (set) Token: 0x060001DC RID: 476 RVA: 0x00002B58 File Offset: 0x00000D58
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

        // Token: 0x170000B4 RID: 180
        // (get) Token: 0x060001DD RID: 477 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
        // (set) Token: 0x060001DE RID: 478 RVA: 0x00002B61 File Offset: 0x00000D61
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

        // Token: 0x170000B5 RID: 181
        // (get) Token: 0x060001DF RID: 479 RVA: 0x0001F6DC File Offset: 0x0001D8DC
        // (set) Token: 0x060001E0 RID: 480 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
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

        // Token: 0x170000B6 RID: 182
        // (get) Token: 0x060001E1 RID: 481 RVA: 0x0001F740 File Offset: 0x0001D940
        // (set) Token: 0x060001E2 RID: 482 RVA: 0x00002B6A File Offset: 0x00000D6A
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

        // Token: 0x170000B7 RID: 183
        // (get) Token: 0x060001E3 RID: 483 RVA: 0x0001F758 File Offset: 0x0001D958
        // (set) Token: 0x060001E4 RID: 484 RVA: 0x0001F770 File Offset: 0x0001D970
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

        // Token: 0x170000B8 RID: 184
        // (get) Token: 0x060001E5 RID: 485 RVA: 0x0001F7BC File Offset: 0x0001D9BC
        // (set) Token: 0x060001E6 RID: 486 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
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

        // Token: 0x170000B9 RID: 185
        // (get) Token: 0x060001E7 RID: 487 RVA: 0x0001F820 File Offset: 0x0001DA20
        // (set) Token: 0x060001E8 RID: 488 RVA: 0x0001F838 File Offset: 0x0001DA38
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

        // Token: 0x170000BA RID: 186
        // (get) Token: 0x060001E9 RID: 489 RVA: 0x0001F884 File Offset: 0x0001DA84
        // (set) Token: 0x060001EA RID: 490 RVA: 0x00002B73 File Offset: 0x00000D73
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

        // Token: 0x170000BB RID: 187
        // (get) Token: 0x060001EB RID: 491 RVA: 0x0001F89C File Offset: 0x0001DA9C
        // (set) Token: 0x060001EC RID: 492 RVA: 0x00002B7C File Offset: 0x00000D7C
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

        // Token: 0x170000BC RID: 188
        // (get) Token: 0x060001ED RID: 493 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
        // (set) Token: 0x060001EE RID: 494 RVA: 0x0001F8CC File Offset: 0x0001DACC
        internal virtual Button Button14
        {
            get
            {
                return this._Button14;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button14_Click);
                if (this._Button14 != null)
                {
                    this._Button14.Click -= value2;
                }
                this._Button14 = value;
                if (this._Button14 != null)
                {
                    this._Button14.Click += value2;
                }
            }
        }

        // Token: 0x170000BD RID: 189
        // (get) Token: 0x060001EF RID: 495 RVA: 0x0001F918 File Offset: 0x0001DB18
        // (set) Token: 0x060001F0 RID: 496 RVA: 0x00002B85 File Offset: 0x00000D85
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

        // Token: 0x170000BE RID: 190
        // (get) Token: 0x060001F1 RID: 497 RVA: 0x0001F930 File Offset: 0x0001DB30
        // (set) Token: 0x060001F2 RID: 498 RVA: 0x0001F948 File Offset: 0x0001DB48
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

        // Token: 0x170000BF RID: 191
        // (get) Token: 0x060001F3 RID: 499 RVA: 0x0001F994 File Offset: 0x0001DB94
        // (set) Token: 0x060001F4 RID: 500 RVA: 0x0001F9AC File Offset: 0x0001DBAC
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

        // Token: 0x170000C0 RID: 192
        // (get) Token: 0x060001F5 RID: 501 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
        // (set) Token: 0x060001F6 RID: 502 RVA: 0x0001FA10 File Offset: 0x0001DC10
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

        // Token: 0x170000C1 RID: 193
        // (get) Token: 0x060001F7 RID: 503 RVA: 0x0001FA5C File Offset: 0x0001DC5C
        // (set) Token: 0x060001F8 RID: 504 RVA: 0x00002B8E File Offset: 0x00000D8E
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

        // Token: 0x170000C2 RID: 194
        // (get) Token: 0x060001F9 RID: 505 RVA: 0x0001FA74 File Offset: 0x0001DC74
        // (set) Token: 0x060001FA RID: 506 RVA: 0x0001FA8C File Offset: 0x0001DC8C
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

        // Token: 0x170000C3 RID: 195
        // (get) Token: 0x060001FB RID: 507 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
        // (set) Token: 0x060001FC RID: 508 RVA: 0x0001FAF0 File Offset: 0x0001DCF0
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

        // Token: 0x170000C4 RID: 196
        // (get) Token: 0x060001FD RID: 509 RVA: 0x0001FB3C File Offset: 0x0001DD3C
        // (set) Token: 0x060001FE RID: 510 RVA: 0x0001FB54 File Offset: 0x0001DD54
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

        // Token: 0x170000C5 RID: 197
        // (get) Token: 0x060001FF RID: 511 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
        // (set) Token: 0x06000200 RID: 512 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
        internal virtual Button Button21
        {
            get
            {
                return this._Button21;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button21_Click);
                if (this._Button21 != null)
                {
                    this._Button21.Click -= value2;
                }
                this._Button21 = value;
                if (this._Button21 != null)
                {
                    this._Button21.Click += value2;
                }
            }
        }

        // Token: 0x170000C6 RID: 198
        // (get) Token: 0x06000201 RID: 513 RVA: 0x0001FC04 File Offset: 0x0001DE04
        // (set) Token: 0x06000202 RID: 514 RVA: 0x0001FC1C File Offset: 0x0001DE1C
        internal virtual Button Button23
        {
            get
            {
                return this._Button23;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button23_Click);
                if (this._Button23 != null)
                {
                    this._Button23.Click -= value2;
                }
                this._Button23 = value;
                if (this._Button23 != null)
                {
                    this._Button23.Click += value2;
                }
            }
        }

        // Token: 0x170000C7 RID: 199
        // (get) Token: 0x06000203 RID: 515 RVA: 0x0001FC68 File Offset: 0x0001DE68
        // (set) Token: 0x06000204 RID: 516 RVA: 0x0001FC80 File Offset: 0x0001DE80
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

        // Token: 0x170000C8 RID: 200
        // (get) Token: 0x06000205 RID: 517 RVA: 0x0001FCCC File Offset: 0x0001DECC
        // (set) Token: 0x06000206 RID: 518 RVA: 0x00002B97 File Offset: 0x00000D97
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

        // Token: 0x170000C9 RID: 201
        // (get) Token: 0x06000207 RID: 519 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
        // (set) Token: 0x06000208 RID: 520 RVA: 0x00002BA0 File Offset: 0x00000DA0
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

        // Token: 0x170000CA RID: 202
        // (get) Token: 0x06000209 RID: 521 RVA: 0x0001FCFC File Offset: 0x0001DEFC
        // (set) Token: 0x0600020A RID: 522 RVA: 0x0001FD14 File Offset: 0x0001DF14
        internal virtual TextBox pagemarginl
        {
            get
            {
                return this._pagemarginl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._pagemarginl != null)
                {
                    this._pagemarginl.KeyPress -= value2;
                }
                this._pagemarginl = value;
                if (this._pagemarginl != null)
                {
                    this._pagemarginl.KeyPress += value2;
                }
            }
        }

        // Token: 0x170000CB RID: 203
        // (get) Token: 0x0600020B RID: 523 RVA: 0x0001FD60 File Offset: 0x0001DF60
        // (set) Token: 0x0600020C RID: 524 RVA: 0x00002BA9 File Offset: 0x00000DA9
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

        // Token: 0x170000CC RID: 204
        // (get) Token: 0x0600020D RID: 525 RVA: 0x0001FD78 File Offset: 0x0001DF78
        // (set) Token: 0x0600020E RID: 526 RVA: 0x0001FD90 File Offset: 0x0001DF90
        internal virtual TextBox pagemarginb
        {
            get
            {
                return this._pagemarginb;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._pagemarginb != null)
                {
                    this._pagemarginb.KeyPress -= value2;
                }
                this._pagemarginb = value;
                if (this._pagemarginb != null)
                {
                    this._pagemarginb.KeyPress += value2;
                }
            }
        }

        // Token: 0x170000CD RID: 205
        // (get) Token: 0x0600020F RID: 527 RVA: 0x0001FDDC File Offset: 0x0001DFDC
        // (set) Token: 0x06000210 RID: 528 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
        internal virtual TextBox pagemargint
        {
            get
            {
                return this._pagemargint;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._pagemargint != null)
                {
                    this._pagemargint.KeyPress -= value2;
                }
                this._pagemargint = value;
                if (this._pagemargint != null)
                {
                    this._pagemargint.KeyPress += value2;
                }
            }
        }

        // Token: 0x170000CE RID: 206
        // (get) Token: 0x06000211 RID: 529 RVA: 0x0001FE40 File Offset: 0x0001E040
        // (set) Token: 0x06000212 RID: 530 RVA: 0x00002BB2 File Offset: 0x00000DB2
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

        // Token: 0x170000CF RID: 207
        // (get) Token: 0x06000213 RID: 531 RVA: 0x0001FE58 File Offset: 0x0001E058
        // (set) Token: 0x06000214 RID: 532 RVA: 0x0001FE70 File Offset: 0x0001E070
        internal virtual TextBox pagemarginr
        {
            get
            {
                return this._pagemarginr;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._pagemarginr != null)
                {
                    this._pagemarginr.KeyPress -= value2;
                }
                this._pagemarginr = value;
                if (this._pagemarginr != null)
                {
                    this._pagemarginr.KeyPress += value2;
                }
            }
        }

        // Token: 0x170000D0 RID: 208
        // (get) Token: 0x06000215 RID: 533 RVA: 0x0001FEBC File Offset: 0x0001E0BC
        // (set) Token: 0x06000216 RID: 534 RVA: 0x00002BBB File Offset: 0x00000DBB
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

        // Token: 0x170000D1 RID: 209
        // (get) Token: 0x06000217 RID: 535 RVA: 0x0001FED4 File Offset: 0x0001E0D4
        // (set) Token: 0x06000218 RID: 536 RVA: 0x00002BC4 File Offset: 0x00000DC4
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

        // Token: 0x170000D2 RID: 210
        // (get) Token: 0x06000219 RID: 537 RVA: 0x0001FEEC File Offset: 0x0001E0EC
        // (set) Token: 0x0600021A RID: 538 RVA: 0x0001FF04 File Offset: 0x0001E104
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

        // Token: 0x170000D3 RID: 211
        // (get) Token: 0x0600021B RID: 539 RVA: 0x0001FF50 File Offset: 0x0001E150
        // (set) Token: 0x0600021C RID: 540 RVA: 0x0001FF68 File Offset: 0x0001E168
        internal virtual Button Button25
        {
            get
            {
                return this._Button25;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button25_Click);
                if (this._Button25 != null)
                {
                    this._Button25.Click -= value2;
                }
                this._Button25 = value;
                if (this._Button25 != null)
                {
                    this._Button25.Click += value2;
                }
            }
        }

        // Token: 0x170000D4 RID: 212
        // (get) Token: 0x0600021D RID: 541 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
        // (set) Token: 0x0600021E RID: 542 RVA: 0x00002BCD File Offset: 0x00000DCD
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

        // Token: 0x170000D5 RID: 213
        // (get) Token: 0x0600021F RID: 543 RVA: 0x0001FFCC File Offset: 0x0001E1CC
        // (set) Token: 0x06000220 RID: 544 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
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

        // Token: 0x170000D6 RID: 214
        // (get) Token: 0x06000221 RID: 545 RVA: 0x00020030 File Offset: 0x0001E230
        // (set) Token: 0x06000222 RID: 546 RVA: 0x00020048 File Offset: 0x0001E248
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

        // Token: 0x170000D7 RID: 215
        // (get) Token: 0x06000223 RID: 547 RVA: 0x00020094 File Offset: 0x0001E294
        // (set) Token: 0x06000224 RID: 548 RVA: 0x000200AC File Offset: 0x0001E2AC
        internal virtual Button Button22
        {
            get
            {
                return this._Button22;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button22_Click);
                if (this._Button22 != null)
                {
                    this._Button22.Click -= value2;
                }
                this._Button22 = value;
                if (this._Button22 != null)
                {
                    this._Button22.Click += value2;
                }
            }
        }

        // Token: 0x170000D8 RID: 216
        // (get) Token: 0x06000225 RID: 549 RVA: 0x000200F8 File Offset: 0x0001E2F8
        // (set) Token: 0x06000226 RID: 550 RVA: 0x00002BD6 File Offset: 0x00000DD6
        internal virtual TextBox subtitle
        {
            get
            {
                return this._subtitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._subtitle = value;
            }
        }

        // Token: 0x170000D9 RID: 217
        // (get) Token: 0x06000227 RID: 551 RVA: 0x00020110 File Offset: 0x0001E310
        // (set) Token: 0x06000228 RID: 552 RVA: 0x00002BDF File Offset: 0x00000DDF
        internal virtual TextBox maintitle
        {
            get
            {
                return this._maintitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._maintitle = value;
            }
        }

        // Token: 0x170000DA RID: 218
        // (get) Token: 0x06000229 RID: 553 RVA: 0x00020128 File Offset: 0x0001E328
        // (set) Token: 0x0600022A RID: 554 RVA: 0x00002BE8 File Offset: 0x00000DE8
        internal virtual GroupBox GroupBoxtitle3
        {
            get
            {
                return this._GroupBoxtitle3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxtitle3 = value;
            }
        }

        // Token: 0x170000DB RID: 219
        // (get) Token: 0x0600022B RID: 555 RVA: 0x00020140 File Offset: 0x0001E340
        // (set) Token: 0x0600022C RID: 556 RVA: 0x00020158 File Offset: 0x0001E358
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

        // Token: 0x170000DC RID: 220
        // (get) Token: 0x0600022D RID: 557 RVA: 0x000201A4 File Offset: 0x0001E3A4
        // (set) Token: 0x0600022E RID: 558 RVA: 0x00002BF1 File Offset: 0x00000DF1
        internal virtual TextBox tabler
        {
            get
            {
                return this._tabler;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabler = value;
            }
        }

        // Token: 0x170000DD RID: 221
        // (get) Token: 0x0600022F RID: 559 RVA: 0x000201BC File Offset: 0x0001E3BC
        // (set) Token: 0x06000230 RID: 560 RVA: 0x00002BFA File Offset: 0x00000DFA
        internal virtual TextBox tablem
        {
            get
            {
                return this._tablem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tablem = value;
            }
        }

        // Token: 0x170000DE RID: 222
        // (get) Token: 0x06000231 RID: 561 RVA: 0x000201D4 File Offset: 0x0001E3D4
        // (set) Token: 0x06000232 RID: 562 RVA: 0x00002C03 File Offset: 0x00000E03
        internal virtual TextBox tablel
        {
            get
            {
                return this._tablel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tablel = value;
            }
        }

        // Token: 0x170000DF RID: 223
        // (get) Token: 0x06000233 RID: 563 RVA: 0x000201EC File Offset: 0x0001E3EC
        // (set) Token: 0x06000234 RID: 564 RVA: 0x00002C0C File Offset: 0x00000E0C
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

        // Token: 0x170000E0 RID: 224
        // (get) Token: 0x06000235 RID: 565 RVA: 0x00020204 File Offset: 0x0001E404
        // (set) Token: 0x06000236 RID: 566 RVA: 0x00002C15 File Offset: 0x00000E15
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

        // Token: 0x170000E1 RID: 225
        // (get) Token: 0x06000237 RID: 567 RVA: 0x0002021C File Offset: 0x0001E41C
        // (set) Token: 0x06000238 RID: 568 RVA: 0x00002C1E File Offset: 0x00000E1E
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

        // Token: 0x170000E2 RID: 226
        // (get) Token: 0x06000239 RID: 569 RVA: 0x00020234 File Offset: 0x0001E434
        // (set) Token: 0x0600023A RID: 570 RVA: 0x00002C27 File Offset: 0x00000E27
        internal virtual GroupBox GroupBoxtitle4
        {
            get
            {
                return this._GroupBoxtitle4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxtitle4 = value;
            }
        }

        // Token: 0x170000E3 RID: 227
        // (get) Token: 0x0600023B RID: 571 RVA: 0x0002024C File Offset: 0x0001E44C
        // (set) Token: 0x0600023C RID: 572 RVA: 0x00020264 File Offset: 0x0001E464
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

        // Token: 0x170000E4 RID: 228
        // (get) Token: 0x0600023D RID: 573 RVA: 0x000202B0 File Offset: 0x0001E4B0
        // (set) Token: 0x0600023E RID: 574 RVA: 0x00002C30 File Offset: 0x00000E30
        internal virtual TextBox tableright
        {
            get
            {
                return this._tableright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tableright = value;
            }
        }

        // Token: 0x170000E5 RID: 229
        // (get) Token: 0x0600023F RID: 575 RVA: 0x000202C8 File Offset: 0x0001E4C8
        // (set) Token: 0x06000240 RID: 576 RVA: 0x00002C39 File Offset: 0x00000E39
        internal virtual TextBox tablemiddle
        {
            get
            {
                return this._tablemiddle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tablemiddle = value;
            }
        }

        // Token: 0x170000E6 RID: 230
        // (get) Token: 0x06000241 RID: 577 RVA: 0x000202E0 File Offset: 0x0001E4E0
        // (set) Token: 0x06000242 RID: 578 RVA: 0x00002C42 File Offset: 0x00000E42
        internal virtual TextBox tableleft
        {
            get
            {
                return this._tableleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tableleft = value;
            }
        }

        // Token: 0x170000E7 RID: 231
        // (get) Token: 0x06000243 RID: 579 RVA: 0x000202F8 File Offset: 0x0001E4F8
        // (set) Token: 0x06000244 RID: 580 RVA: 0x00002C4B File Offset: 0x00000E4B
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

        // Token: 0x170000E8 RID: 232
        // (get) Token: 0x06000245 RID: 581 RVA: 0x00020310 File Offset: 0x0001E510
        // (set) Token: 0x06000246 RID: 582 RVA: 0x00002C54 File Offset: 0x00000E54
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

        // Token: 0x170000E9 RID: 233
        // (get) Token: 0x06000247 RID: 583 RVA: 0x00020328 File Offset: 0x0001E528
        // (set) Token: 0x06000248 RID: 584 RVA: 0x00002C5D File Offset: 0x00000E5D
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

        // Token: 0x170000EA RID: 234
        // (get) Token: 0x06000249 RID: 585 RVA: 0x00020340 File Offset: 0x0001E540
        // (set) Token: 0x0600024A RID: 586 RVA: 0x00002C66 File Offset: 0x00000E66
        internal virtual ComboBox zys
        {
            get
            {
                return this._zys;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zys = value;
            }
        }

        // Token: 0x170000EB RID: 235
        // (get) Token: 0x0600024B RID: 587 RVA: 0x00020358 File Offset: 0x0001E558
        // (set) Token: 0x0600024C RID: 588 RVA: 0x00002C6F File Offset: 0x00000E6F
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

        // Token: 0x170000EC RID: 236
        // (get) Token: 0x0600024D RID: 589 RVA: 0x00020370 File Offset: 0x0001E570
        // (set) Token: 0x0600024E RID: 590 RVA: 0x00002C78 File Offset: 0x00000E78
        internal virtual ComboBox fys
        {
            get
            {
                return this._fys;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._fys = value;
            }
        }

        // Token: 0x170000ED RID: 237
        // (get) Token: 0x0600024F RID: 591 RVA: 0x00020388 File Offset: 0x0001E588
        // (set) Token: 0x06000250 RID: 592 RVA: 0x00002C81 File Offset: 0x00000E81
        internal virtual Label Label55
        {
            get
            {
                return this._Label55;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label55 = value;
            }
        }

        // Token: 0x170000EE RID: 238
        // (get) Token: 0x06000251 RID: 593 RVA: 0x000203A0 File Offset: 0x0001E5A0
        // (set) Token: 0x06000252 RID: 594 RVA: 0x00002C8A File Offset: 0x00000E8A
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

        // Token: 0x170000EF RID: 239
        // (get) Token: 0x06000253 RID: 595 RVA: 0x000203B8 File Offset: 0x0001E5B8
        // (set) Token: 0x06000254 RID: 596 RVA: 0x000203D0 File Offset: 0x0001E5D0
        internal virtual Button Button28
        {
            get
            {
                return this._Button28;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button28_Click);
                if (this._Button28 != null)
                {
                    this._Button28.Click -= value2;
                }
                this._Button28 = value;
                if (this._Button28 != null)
                {
                    this._Button28.Click += value2;
                }
            }
        }

        // Token: 0x170000F0 RID: 240
        // (get) Token: 0x06000255 RID: 597 RVA: 0x0002041C File Offset: 0x0001E61C
        // (set) Token: 0x06000256 RID: 598 RVA: 0x00020434 File Offset: 0x0001E634
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

        // Token: 0x170000F1 RID: 241
        // (get) Token: 0x06000257 RID: 599 RVA: 0x00020480 File Offset: 0x0001E680
        // (set) Token: 0x06000258 RID: 600 RVA: 0x00002C93 File Offset: 0x00000E93
        internal virtual TextBox rightb
        {
            get
            {
                return this._rightb;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rightb = value;
            }
        }

        // Token: 0x170000F2 RID: 242
        // (get) Token: 0x06000259 RID: 601 RVA: 0x00020498 File Offset: 0x0001E698
        // (set) Token: 0x0600025A RID: 602 RVA: 0x00002C9C File Offset: 0x00000E9C
        internal virtual TextBox rightm
        {
            get
            {
                return this._rightm;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rightm = value;
            }
        }

        // Token: 0x170000F3 RID: 243
        // (get) Token: 0x0600025B RID: 603 RVA: 0x000204B0 File Offset: 0x0001E6B0
        // (set) Token: 0x0600025C RID: 604 RVA: 0x00002CA5 File Offset: 0x00000EA5
        internal virtual TextBox rightt
        {
            get
            {
                return this._rightt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rightt = value;
            }
        }

        // Token: 0x170000F4 RID: 244
        // (get) Token: 0x0600025D RID: 605 RVA: 0x000204C8 File Offset: 0x0001E6C8
        // (set) Token: 0x0600025E RID: 606 RVA: 0x00002CAE File Offset: 0x00000EAE
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

        // Token: 0x170000F5 RID: 245
        // (get) Token: 0x0600025F RID: 607 RVA: 0x000204E0 File Offset: 0x0001E6E0
        // (set) Token: 0x06000260 RID: 608 RVA: 0x00002CB7 File Offset: 0x00000EB7
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

        // Token: 0x170000F6 RID: 246
        // (get) Token: 0x06000261 RID: 609 RVA: 0x000204F8 File Offset: 0x0001E6F8
        // (set) Token: 0x06000262 RID: 610 RVA: 0x00002CC0 File Offset: 0x00000EC0
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

        // Token: 0x170000F7 RID: 247
        // (get) Token: 0x06000263 RID: 611 RVA: 0x00020510 File Offset: 0x0001E710
        // (set) Token: 0x06000264 RID: 612 RVA: 0x00020528 File Offset: 0x0001E728
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

        // Token: 0x170000F8 RID: 248
        // (get) Token: 0x06000265 RID: 613 RVA: 0x00020574 File Offset: 0x0001E774
        // (set) Token: 0x06000266 RID: 614 RVA: 0x00002CC9 File Offset: 0x00000EC9
        internal virtual OpenFileDialog OpenFileDialog1
        {
            get
            {
                return this._OpenFileDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OpenFileDialog1 = value;
            }
        }

        // Token: 0x170000F9 RID: 249
        // (get) Token: 0x06000267 RID: 615 RVA: 0x0002058C File Offset: 0x0001E78C
        // (set) Token: 0x06000268 RID: 616 RVA: 0x00002CD2 File Offset: 0x00000ED2
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

        // Token: 0x170000FA RID: 250
        // (get) Token: 0x06000269 RID: 617 RVA: 0x000205A4 File Offset: 0x0001E7A4
        // (set) Token: 0x0600026A RID: 618 RVA: 0x000205BC File Offset: 0x0001E7BC
        internal virtual Button exportexcel
        {
            get
            {
                return this._exportexcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button31_Click);
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

        // Token: 0x170000FB RID: 251
        // (get) Token: 0x0600026B RID: 619 RVA: 0x00020608 File Offset: 0x0001E808
        // (set) Token: 0x0600026C RID: 620 RVA: 0x00002CDB File Offset: 0x00000EDB
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

        // Token: 0x170000FC RID: 252
        // (get) Token: 0x0600026D RID: 621 RVA: 0x00020620 File Offset: 0x0001E820
        // (set) Token: 0x0600026E RID: 622 RVA: 0x00002CE4 File Offset: 0x00000EE4
        internal virtual TabPage TabPage6
        {
            get
            {
                return this._TabPage6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TabPage6 = value;
            }
        }

        // Token: 0x170000FD RID: 253
        // (get) Token: 0x0600026F RID: 623 RVA: 0x00020638 File Offset: 0x0001E838
        // (set) Token: 0x06000270 RID: 624 RVA: 0x00002CED File Offset: 0x00000EED
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

        // Token: 0x170000FE RID: 254
        // (get) Token: 0x06000271 RID: 625 RVA: 0x00020650 File Offset: 0x0001E850
        // (set) Token: 0x06000272 RID: 626 RVA: 0x00020668 File Offset: 0x0001E868
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

        // Token: 0x170000FF RID: 255
        // (get) Token: 0x06000273 RID: 627 RVA: 0x000206B4 File Offset: 0x0001E8B4
        // (set) Token: 0x06000274 RID: 628 RVA: 0x00002CF6 File Offset: 0x00000EF6
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

        // Token: 0x17000100 RID: 256
        // (get) Token: 0x06000275 RID: 629 RVA: 0x000206CC File Offset: 0x0001E8CC
        // (set) Token: 0x06000276 RID: 630 RVA: 0x000206E4 File Offset: 0x0001E8E4
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

        // Token: 0x17000101 RID: 257
        // (get) Token: 0x06000277 RID: 631 RVA: 0x00020730 File Offset: 0x0001E930
        // (set) Token: 0x06000278 RID: 632 RVA: 0x00020748 File Offset: 0x0001E948
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

        // Token: 0x17000102 RID: 258
        // (get) Token: 0x06000279 RID: 633 RVA: 0x00020794 File Offset: 0x0001E994
        // (set) Token: 0x0600027A RID: 634 RVA: 0x000207AC File Offset: 0x0001E9AC
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

        // Token: 0x17000103 RID: 259
        // (get) Token: 0x0600027B RID: 635 RVA: 0x000207F8 File Offset: 0x0001E9F8
        // (set) Token: 0x0600027C RID: 636 RVA: 0x00002CFF File Offset: 0x00000EFF
        internal virtual CheckedListBox hz
        {
            get
            {
                return this._hz;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hz = value;
            }
        }

        // Token: 0x17000104 RID: 260
        // (get) Token: 0x0600027D RID: 637 RVA: 0x00020810 File Offset: 0x0001EA10
        // (set) Token: 0x0600027E RID: 638 RVA: 0x00002D08 File Offset: 0x00000F08
        internal virtual GroupBox GroupBox18
        {
            get
            {
                return this._GroupBox18;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox18 = value;
            }
        }

        // Token: 0x17000105 RID: 261
        // (get) Token: 0x0600027F RID: 639 RVA: 0x00020828 File Offset: 0x0001EA28
        // (set) Token: 0x06000280 RID: 640 RVA: 0x00020840 File Offset: 0x0001EA40
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

        // Token: 0x17000106 RID: 262
        // (get) Token: 0x06000281 RID: 641 RVA: 0x0002088C File Offset: 0x0001EA8C
        // (set) Token: 0x06000282 RID: 642 RVA: 0x00002D11 File Offset: 0x00000F11
        internal virtual Label hzfontshow
        {
            get
            {
                return this._hzfontshow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hzfontshow = value;
            }
        }

        // Token: 0x17000107 RID: 263
        // (get) Token: 0x06000283 RID: 643 RVA: 0x000208A4 File Offset: 0x0001EAA4
        // (set) Token: 0x06000284 RID: 644 RVA: 0x000208BC File Offset: 0x0001EABC
        internal virtual Button Button34
        {
            get
            {
                return this._Button34;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button34_Click);
                if (this._Button34 != null)
                {
                    this._Button34.Click -= value2;
                }
                this._Button34 = value;
                if (this._Button34 != null)
                {
                    this._Button34.Click += value2;
                }
            }
        }

        // Token: 0x17000108 RID: 264
        // (get) Token: 0x06000285 RID: 645 RVA: 0x00020908 File Offset: 0x0001EB08
        // (set) Token: 0x06000286 RID: 646 RVA: 0x00020920 File Offset: 0x0001EB20
        internal virtual Button Button35
        {
            get
            {
                return this._Button35;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button35_Click);
                if (this._Button35 != null)
                {
                    this._Button35.Click -= value2;
                }
                this._Button35 = value;
                if (this._Button35 != null)
                {
                    this._Button35.Click += value2;
                }
            }
        }

        // Token: 0x17000109 RID: 265
        // (get) Token: 0x06000287 RID: 647 RVA: 0x0002096C File Offset: 0x0001EB6C
        // (set) Token: 0x06000288 RID: 648 RVA: 0x00002D1A File Offset: 0x00000F1A
        internal virtual GroupBox GroupBoxhz
        {
            get
            {
                return this._GroupBoxhz;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxhz = value;
            }
        }

        // Token: 0x1700010A RID: 266
        // (get) Token: 0x06000289 RID: 649 RVA: 0x00020984 File Offset: 0x0001EB84
        // (set) Token: 0x0600028A RID: 650 RVA: 0x00002D23 File Offset: 0x00000F23
        internal virtual GroupBox GroupBoxgroup
        {
            get
            {
                return this._GroupBoxgroup;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBoxgroup = value;
            }
        }

        // Token: 0x1700010B RID: 267
        // (get) Token: 0x0600028B RID: 651 RVA: 0x0002099C File Offset: 0x0001EB9C
        // (set) Token: 0x0600028C RID: 652 RVA: 0x00002D2C File Offset: 0x00000F2C
        internal virtual GroupBox GroupBox21
        {
            get
            {
                return this._GroupBox21;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox21 = value;
            }
        }

        // Token: 0x1700010C RID: 268
        // (get) Token: 0x0600028D RID: 653 RVA: 0x000209B4 File Offset: 0x0001EBB4
        // (set) Token: 0x0600028E RID: 654 RVA: 0x00002D35 File Offset: 0x00000F35
        internal virtual Label Label61
        {
            get
            {
                return this._Label61;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label61 = value;
            }
        }

        // Token: 0x1700010D RID: 269
        // (get) Token: 0x0600028F RID: 655 RVA: 0x000209CC File Offset: 0x0001EBCC
        // (set) Token: 0x06000290 RID: 656 RVA: 0x00002D3E File Offset: 0x00000F3E
        internal virtual Label Label59
        {
            get
            {
                return this._Label59;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label59 = value;
            }
        }

        // Token: 0x1700010E RID: 270
        // (get) Token: 0x06000291 RID: 657 RVA: 0x000209E4 File Offset: 0x0001EBE4
        // (set) Token: 0x06000292 RID: 658 RVA: 0x00002D47 File Offset: 0x00000F47
        internal virtual GroupBox GroupBox23
        {
            get
            {
                return this._GroupBox23;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox23 = value;
            }
        }

        // Token: 0x1700010F RID: 271
        // (get) Token: 0x06000293 RID: 659 RVA: 0x000209FC File Offset: 0x0001EBFC
        // (set) Token: 0x06000294 RID: 660 RVA: 0x00020A14 File Offset: 0x0001EC14
        internal virtual ComboBox groupcolumn
        {
            get
            {
                return this._groupcolumn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.groupcolumn_SelectedIndexChanged);
                if (this._groupcolumn != null)
                {
                    this._groupcolumn.SelectedIndexChanged -= value2;
                }
                this._groupcolumn = value;
                if (this._groupcolumn != null)
                {
                    this._groupcolumn.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000110 RID: 272
        // (get) Token: 0x06000295 RID: 661 RVA: 0x00020A60 File Offset: 0x0001EC60
        // (set) Token: 0x06000296 RID: 662 RVA: 0x00002D50 File Offset: 0x00000F50
        internal virtual GroupBox GroupBox22
        {
            get
            {
                return this._GroupBox22;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox22 = value;
            }
        }

        // Token: 0x17000111 RID: 273
        // (get) Token: 0x06000297 RID: 663 RVA: 0x00020A78 File Offset: 0x0001EC78
        // (set) Token: 0x06000298 RID: 664 RVA: 0x00002D59 File Offset: 0x00000F59
        internal virtual RadioButton sortd
        {
            get
            {
                return this._sortd;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sortd = value;
            }
        }

        // Token: 0x17000112 RID: 274
        // (get) Token: 0x06000299 RID: 665 RVA: 0x00020A90 File Offset: 0x0001EC90
        // (set) Token: 0x0600029A RID: 666 RVA: 0x00002D62 File Offset: 0x00000F62
        internal virtual RadioButton sorta
        {
            get
            {
                return this._sorta;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sorta = value;
            }
        }

        // Token: 0x17000113 RID: 275
        // (get) Token: 0x0600029B RID: 667 RVA: 0x00020AA8 File Offset: 0x0001ECA8
        // (set) Token: 0x0600029C RID: 668 RVA: 0x00002D6B File Offset: 0x00000F6B
        internal virtual ComboBox sortcolumn
        {
            get
            {
                return this._sortcolumn;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sortcolumn = value;
            }
        }

        // Token: 0x17000114 RID: 276
        // (get) Token: 0x0600029D RID: 669 RVA: 0x00020AC0 File Offset: 0x0001ECC0
        // (set) Token: 0x0600029E RID: 670 RVA: 0x00002D74 File Offset: 0x00000F74
        internal virtual CheckBox addrownew
        {
            get
            {
                return this._addrownew;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._addrownew = value;
            }
        }

        // Token: 0x17000115 RID: 277
        // (get) Token: 0x0600029F RID: 671 RVA: 0x00020AD8 File Offset: 0x0001ECD8
        // (set) Token: 0x060002A0 RID: 672 RVA: 0x00002D7D File Offset: 0x00000F7D
        internal virtual CheckBox addrowid
        {
            get
            {
                return this._addrowid;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._addrowid = value;
            }
        }

        // Token: 0x17000116 RID: 278
        // (get) Token: 0x060002A1 RID: 673 RVA: 0x00020AF0 File Offset: 0x0001ECF0
        // (set) Token: 0x060002A2 RID: 674 RVA: 0x00002D86 File Offset: 0x00000F86
        internal virtual CheckBox groupnewpage
        {
            get
            {
                return this._groupnewpage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._groupnewpage = value;
            }
        }

        // Token: 0x17000117 RID: 279
        // (get) Token: 0x060002A3 RID: 675 RVA: 0x00020B08 File Offset: 0x0001ED08
        // (set) Token: 0x060002A4 RID: 676 RVA: 0x00002D8F File Offset: 0x00000F8F
        internal virtual Label Label64
        {
            get
            {
                return this._Label64;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label64 = value;
            }
        }

        // Token: 0x17000118 RID: 280
        // (get) Token: 0x060002A5 RID: 677 RVA: 0x00020B20 File Offset: 0x0001ED20
        // (set) Token: 0x060002A6 RID: 678 RVA: 0x00020B38 File Offset: 0x0001ED38
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

        // Token: 0x17000119 RID: 281
        // (get) Token: 0x060002A7 RID: 679 RVA: 0x00020B84 File Offset: 0x0001ED84
        // (set) Token: 0x060002A8 RID: 680 RVA: 0x00002D98 File Offset: 0x00000F98
        internal virtual ComboBox sumalign
        {
            get
            {
                return this._sumalign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sumalign = value;
            }
        }

        // Token: 0x1700011A RID: 282
        // (get) Token: 0x060002A9 RID: 681 RVA: 0x00020B9C File Offset: 0x0001ED9C
        // (set) Token: 0x060002AA RID: 682 RVA: 0x00002DA1 File Offset: 0x00000FA1
        internal virtual Label Label66
        {
            get
            {
                return this._Label66;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label66 = value;
            }
        }

        // Token: 0x1700011B RID: 283
        // (get) Token: 0x060002AB RID: 683 RVA: 0x00020BB4 File Offset: 0x0001EDB4
        // (set) Token: 0x060002AC RID: 684 RVA: 0x00020BCC File Offset: 0x0001EDCC
        internal virtual ComboBox tabletopleftalign
        {
            get
            {
                return this._tabletopleftalign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tabletopleftalign_SelectedIndexChanged);
                if (this._tabletopleftalign != null)
                {
                    this._tabletopleftalign.SelectedIndexChanged -= value2;
                }
                this._tabletopleftalign = value;
                if (this._tabletopleftalign != null)
                {
                    this._tabletopleftalign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x1700011C RID: 284
        // (get) Token: 0x060002AD RID: 685 RVA: 0x00020C18 File Offset: 0x0001EE18
        // (set) Token: 0x060002AE RID: 686 RVA: 0x00002DAA File Offset: 0x00000FAA
        internal virtual Label Label67
        {
            get
            {
                return this._Label67;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label67 = value;
            }
        }

        // Token: 0x1700011D RID: 285
        // (get) Token: 0x060002AF RID: 687 RVA: 0x00020C30 File Offset: 0x0001EE30
        // (set) Token: 0x060002B0 RID: 688 RVA: 0x00020C48 File Offset: 0x0001EE48
        internal virtual ComboBox tablebottomleftalign
        {
            get
            {
                return this._tablebottomleftalign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tablebottomleftalign_SelectedIndexChanged);
                if (this._tablebottomleftalign != null)
                {
                    this._tablebottomleftalign.SelectedIndexChanged -= value2;
                }
                this._tablebottomleftalign = value;
                if (this._tablebottomleftalign != null)
                {
                    this._tablebottomleftalign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x1700011E RID: 286
        // (get) Token: 0x060002B1 RID: 689 RVA: 0x00020C94 File Offset: 0x0001EE94
        // (set) Token: 0x060002B2 RID: 690 RVA: 0x00002DB3 File Offset: 0x00000FB3
        internal virtual Label Label68
        {
            get
            {
                return this._Label68;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label68 = value;
            }
        }

        // Token: 0x1700011F RID: 287
        // (get) Token: 0x060002B3 RID: 691 RVA: 0x00020CAC File Offset: 0x0001EEAC
        // (set) Token: 0x060002B4 RID: 692 RVA: 0x00020CC4 File Offset: 0x0001EEC4
        internal virtual ComboBox tabletoprightalign
        {
            get
            {
                return this._tabletoprightalign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tabletoprightalign_SelectedIndexChanged);
                if (this._tabletoprightalign != null)
                {
                    this._tabletoprightalign.SelectedIndexChanged -= value2;
                }
                this._tabletoprightalign = value;
                if (this._tabletoprightalign != null)
                {
                    this._tabletoprightalign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000120 RID: 288
        // (get) Token: 0x060002B5 RID: 693 RVA: 0x00020D10 File Offset: 0x0001EF10
        // (set) Token: 0x060002B6 RID: 694 RVA: 0x00020D28 File Offset: 0x0001EF28
        internal virtual ComboBox tabletopmiddlealign
        {
            get
            {
                return this._tabletopmiddlealign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tabletopmiddlealign_SelectedIndexChanged);
                if (this._tabletopmiddlealign != null)
                {
                    this._tabletopmiddlealign.SelectedIndexChanged -= value2;
                }
                this._tabletopmiddlealign = value;
                if (this._tabletopmiddlealign != null)
                {
                    this._tabletopmiddlealign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000121 RID: 289
        // (get) Token: 0x060002B7 RID: 695 RVA: 0x00020D74 File Offset: 0x0001EF74
        // (set) Token: 0x060002B8 RID: 696 RVA: 0x00020D8C File Offset: 0x0001EF8C
        internal virtual ComboBox tablebottomrightalign
        {
            get
            {
                return this._tablebottomrightalign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tablebottomrightalign_SelectedIndexChanged);
                if (this._tablebottomrightalign != null)
                {
                    this._tablebottomrightalign.SelectedIndexChanged -= value2;
                }
                this._tablebottomrightalign = value;
                if (this._tablebottomrightalign != null)
                {
                    this._tablebottomrightalign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000122 RID: 290
        // (get) Token: 0x060002B9 RID: 697 RVA: 0x00020DD8 File Offset: 0x0001EFD8
        // (set) Token: 0x060002BA RID: 698 RVA: 0x00020DF0 File Offset: 0x0001EFF0
        internal virtual ComboBox tablebottommiddlealign
        {
            get
            {
                return this._tablebottommiddlealign;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.tablebottommiddlealign_SelectedIndexChanged);
                if (this._tablebottommiddlealign != null)
                {
                    this._tablebottommiddlealign.SelectedIndexChanged -= value2;
                }
                this._tablebottommiddlealign = value;
                if (this._tablebottommiddlealign != null)
                {
                    this._tablebottommiddlealign.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000123 RID: 291
        // (get) Token: 0x060002BB RID: 699 RVA: 0x00020E3C File Offset: 0x0001F03C
        // (set) Token: 0x060002BC RID: 700 RVA: 0x00002DBC File Offset: 0x00000FBC
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

        // Token: 0x17000124 RID: 292
        // (get) Token: 0x060002BD RID: 701 RVA: 0x00020E54 File Offset: 0x0001F054
        // (set) Token: 0x060002BE RID: 702 RVA: 0x00002DC5 File Offset: 0x00000FC5
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

        // Token: 0x17000125 RID: 293
        // (get) Token: 0x060002BF RID: 703 RVA: 0x00020E6C File Offset: 0x0001F06C
        // (set) Token: 0x060002C0 RID: 704 RVA: 0x00002DCE File Offset: 0x00000FCE
        internal virtual CheckBox autoaddrow
        {
            get
            {
                return this._autoaddrow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._autoaddrow = value;
            }
        }

        // Token: 0x17000126 RID: 294
        // (get) Token: 0x060002C1 RID: 705 RVA: 0x00020E84 File Offset: 0x0001F084
        // (set) Token: 0x060002C2 RID: 706 RVA: 0x00002DD7 File Offset: 0x00000FD7
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

        // Token: 0x17000127 RID: 295
        // (get) Token: 0x060002C3 RID: 707 RVA: 0x00020E9C File Offset: 0x0001F09C
        // (set) Token: 0x060002C4 RID: 708 RVA: 0x00020EB4 File Offset: 0x0001F0B4
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

        // Token: 0x17000128 RID: 296
        // (get) Token: 0x060002C5 RID: 709 RVA: 0x00020F00 File Offset: 0x0001F100
        // (set) Token: 0x060002C6 RID: 710 RVA: 0x00002DE0 File Offset: 0x00000FE0
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

        // Token: 0x17000129 RID: 297
        // (get) Token: 0x060002C7 RID: 711 RVA: 0x00020F18 File Offset: 0x0001F118
        // (set) Token: 0x060002C8 RID: 712 RVA: 0x00002DE9 File Offset: 0x00000FE9
        internal virtual Label Label79
        {
            get
            {
                return this._Label79;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label79 = value;
            }
        }

        // Token: 0x1700012A RID: 298
        // (get) Token: 0x060002C9 RID: 713 RVA: 0x00020F30 File Offset: 0x0001F130
        // (set) Token: 0x060002CA RID: 714 RVA: 0x00002DF2 File Offset: 0x00000FF2
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

        // Token: 0x1700012B RID: 299
        // (get) Token: 0x060002CB RID: 715 RVA: 0x00020F48 File Offset: 0x0001F148
        // (set) Token: 0x060002CC RID: 716 RVA: 0x00002DFB File Offset: 0x00000FFB
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

        // Token: 0x1700012C RID: 300
        // (get) Token: 0x060002CD RID: 717 RVA: 0x00020F60 File Offset: 0x0001F160
        // (set) Token: 0x060002CE RID: 718 RVA: 0x00002E04 File Offset: 0x00001004
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

        // Token: 0x1700012D RID: 301
        // (get) Token: 0x060002CF RID: 719 RVA: 0x00020F78 File Offset: 0x0001F178
        // (set) Token: 0x060002D0 RID: 720 RVA: 0x00002E0D File Offset: 0x0000100D
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

        // Token: 0x1700012E RID: 302
        // (get) Token: 0x060002D1 RID: 721 RVA: 0x00020F90 File Offset: 0x0001F190
        // (set) Token: 0x060002D2 RID: 722 RVA: 0x00002E16 File Offset: 0x00001016
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

        // Token: 0x1700012F RID: 303
        // (get) Token: 0x060002D3 RID: 723 RVA: 0x00020FA8 File Offset: 0x0001F1A8
        // (set) Token: 0x060002D4 RID: 724 RVA: 0x00002E1F File Offset: 0x0000101F
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

        // Token: 0x17000130 RID: 304
        // (get) Token: 0x060002D5 RID: 725 RVA: 0x00020FC0 File Offset: 0x0001F1C0
        // (set) Token: 0x060002D6 RID: 726 RVA: 0x00020FD8 File Offset: 0x0001F1D8
        internal virtual Button Button36
        {
            get
            {
                return this._Button36;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button36_Click);
                if (this._Button36 != null)
                {
                    this._Button36.Click -= value2;
                }
                this._Button36 = value;
                if (this._Button36 != null)
                {
                    this._Button36.Click += value2;
                }
            }
        }

        // Token: 0x17000131 RID: 305
        // (get) Token: 0x060002D7 RID: 727 RVA: 0x00021024 File Offset: 0x0001F224
        // (set) Token: 0x060002D8 RID: 728 RVA: 0x0002103C File Offset: 0x0001F23C
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

        // Token: 0x17000132 RID: 306
        // (get) Token: 0x060002D9 RID: 729 RVA: 0x00021088 File Offset: 0x0001F288
        // (set) Token: 0x060002DA RID: 730 RVA: 0x000210A0 File Offset: 0x0001F2A0
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

        // Token: 0x17000133 RID: 307
        // (get) Token: 0x060002DB RID: 731 RVA: 0x000210EC File Offset: 0x0001F2EC
        // (set) Token: 0x060002DC RID: 732 RVA: 0x00002E28 File Offset: 0x00001028
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

        // Token: 0x17000134 RID: 308
        // (get) Token: 0x060002DD RID: 733 RVA: 0x00021104 File Offset: 0x0001F304
        // (set) Token: 0x060002DE RID: 734 RVA: 0x0002111C File Offset: 0x0001F31C
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

        // Token: 0x17000135 RID: 309
        // (get) Token: 0x060002DF RID: 735 RVA: 0x00021168 File Offset: 0x0001F368
        // (set) Token: 0x060002E0 RID: 736 RVA: 0x00002E31 File Offset: 0x00001031
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

        // Token: 0x17000136 RID: 310
        // (get) Token: 0x060002E1 RID: 737 RVA: 0x00021180 File Offset: 0x0001F380
        // (set) Token: 0x060002E2 RID: 738 RVA: 0x00002E3A File Offset: 0x0000103A
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

        // Token: 0x17000137 RID: 311
        // (get) Token: 0x060002E3 RID: 739 RVA: 0x00021198 File Offset: 0x0001F398
        // (set) Token: 0x060002E4 RID: 740 RVA: 0x000211B0 File Offset: 0x0001F3B0
        internal virtual Button Button26
        {
            get
            {
                return this._Button26;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button26_Click);
                if (this._Button26 != null)
                {
                    this._Button26.Click -= value2;
                }
                this._Button26 = value;
                if (this._Button26 != null)
                {
                    this._Button26.Click += value2;
                }
            }
        }

        // Token: 0x17000138 RID: 312
        // (get) Token: 0x060002E5 RID: 741 RVA: 0x000211FC File Offset: 0x0001F3FC
        // (set) Token: 0x060002E6 RID: 742 RVA: 0x00021214 File Offset: 0x0001F414
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

        // Token: 0x17000139 RID: 313
        // (get) Token: 0x060002E7 RID: 743 RVA: 0x00021260 File Offset: 0x0001F460
        // (set) Token: 0x060002E8 RID: 744 RVA: 0x00002E43 File Offset: 0x00001043
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

        // Token: 0x1700013A RID: 314
        // (get) Token: 0x060002E9 RID: 745 RVA: 0x00021278 File Offset: 0x0001F478
        // (set) Token: 0x060002EA RID: 746 RVA: 0x00002E4C File Offset: 0x0000104C
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

        // Token: 0x1700013B RID: 315
        // (get) Token: 0x060002EB RID: 747 RVA: 0x00021290 File Offset: 0x0001F490
        // (set) Token: 0x060002EC RID: 748 RVA: 0x00002E55 File Offset: 0x00001055
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

        // Token: 0x1700013C RID: 316
        // (get) Token: 0x060002ED RID: 749 RVA: 0x000212A8 File Offset: 0x0001F4A8
        // (set) Token: 0x060002EE RID: 750 RVA: 0x00002E5E File Offset: 0x0000105E
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

        // Token: 0x1700013D RID: 317
        // (get) Token: 0x060002EF RID: 751 RVA: 0x000212C0 File Offset: 0x0001F4C0
        // (set) Token: 0x060002F0 RID: 752 RVA: 0x00002E67 File Offset: 0x00001067
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

        // Token: 0x1700013E RID: 318
        // (get) Token: 0x060002F1 RID: 753 RVA: 0x000212D8 File Offset: 0x0001F4D8
        // (set) Token: 0x060002F2 RID: 754 RVA: 0x00002E70 File Offset: 0x00001070
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

        // Token: 0x1700013F RID: 319
        // (get) Token: 0x060002F3 RID: 755 RVA: 0x000212F0 File Offset: 0x0001F4F0
        // (set) Token: 0x060002F4 RID: 756 RVA: 0x00002E79 File Offset: 0x00001079
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

        // Token: 0x17000140 RID: 320
        // (get) Token: 0x060002F5 RID: 757 RVA: 0x00021308 File Offset: 0x0001F508
        // (set) Token: 0x060002F6 RID: 758 RVA: 0x00002E82 File Offset: 0x00001082
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

        // Token: 0x17000141 RID: 321
        // (get) Token: 0x060002F7 RID: 759 RVA: 0x00021320 File Offset: 0x0001F520
        // (set) Token: 0x060002F8 RID: 760 RVA: 0x00002E8B File Offset: 0x0000108B
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

        // Token: 0x17000142 RID: 322
        // (get) Token: 0x060002F9 RID: 761 RVA: 0x00021338 File Offset: 0x0001F538
        // (set) Token: 0x060002FA RID: 762 RVA: 0x00002E94 File Offset: 0x00001094
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

        // Token: 0x17000143 RID: 323
        // (get) Token: 0x060002FB RID: 763 RVA: 0x00021350 File Offset: 0x0001F550
        // (set) Token: 0x060002FC RID: 764 RVA: 0x00002E9D File Offset: 0x0000109D
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

        // Token: 0x17000144 RID: 324
        // (get) Token: 0x060002FD RID: 765 RVA: 0x00021368 File Offset: 0x0001F568
        // (set) Token: 0x060002FE RID: 766 RVA: 0x00002EA6 File Offset: 0x000010A6
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

        // Token: 0x17000145 RID: 325
        // (get) Token: 0x060002FF RID: 767 RVA: 0x00021380 File Offset: 0x0001F580
        // (set) Token: 0x06000300 RID: 768 RVA: 0x00002EAF File Offset: 0x000010AF
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

        // Token: 0x17000146 RID: 326
        // (get) Token: 0x06000301 RID: 769 RVA: 0x00021398 File Offset: 0x0001F598
        // (set) Token: 0x06000302 RID: 770 RVA: 0x00002EB8 File Offset: 0x000010B8
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

        // Token: 0x17000147 RID: 327
        // (get) Token: 0x06000303 RID: 771 RVA: 0x000213B0 File Offset: 0x0001F5B0
        // (set) Token: 0x06000304 RID: 772 RVA: 0x00002EC1 File Offset: 0x000010C1
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

        // Token: 0x17000148 RID: 328
        // (get) Token: 0x06000305 RID: 773 RVA: 0x000213C8 File Offset: 0x0001F5C8
        // (set) Token: 0x06000306 RID: 774 RVA: 0x00002ECA File Offset: 0x000010CA
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

        // Token: 0x17000149 RID: 329
        // (get) Token: 0x06000307 RID: 775 RVA: 0x000213E0 File Offset: 0x0001F5E0
        // (set) Token: 0x06000308 RID: 776 RVA: 0x00002ED3 File Offset: 0x000010D3
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

        // Token: 0x1700014A RID: 330
        // (get) Token: 0x06000309 RID: 777 RVA: 0x000213F8 File Offset: 0x0001F5F8
        // (set) Token: 0x0600030A RID: 778 RVA: 0x00002EDC File Offset: 0x000010DC
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

        // Token: 0x1700014B RID: 331
        // (get) Token: 0x0600030B RID: 779 RVA: 0x00021410 File Offset: 0x0001F610
        // (set) Token: 0x0600030C RID: 780 RVA: 0x00002EE5 File Offset: 0x000010E5
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

        // Token: 0x1700014C RID: 332
        // (get) Token: 0x0600030D RID: 781 RVA: 0x00021428 File Offset: 0x0001F628
        // (set) Token: 0x0600030E RID: 782 RVA: 0x00021440 File Offset: 0x0001F640
        internal virtual TextBox zdxposition
        {
            get
            {
                return this._zdxposition;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._zdxposition != null)
                {
                    this._zdxposition.KeyPress -= value2;
                }
                this._zdxposition = value;
                if (this._zdxposition != null)
                {
                    this._zdxposition.KeyPress += value2;
                }
            }
        }

        // Token: 0x1700014D RID: 333
        // (get) Token: 0x0600030F RID: 783 RVA: 0x0002148C File Offset: 0x0001F68C
        // (set) Token: 0x06000310 RID: 784 RVA: 0x000214A4 File Offset: 0x0001F6A4
        internal virtual NumericUpDown rowheight
        {
            get
            {
                return this._rowheight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.NumericUpDown1_ValueChanged);
                if (this._rowheight != null)
                {
                    this._rowheight.ValueChanged -= value2;
                }
                this._rowheight = value;
                if (this._rowheight != null)
                {
                    this._rowheight.ValueChanged += value2;
                }
            }
        }

        // Token: 0x1700014E RID: 334
        // (get) Token: 0x06000311 RID: 785 RVA: 0x000214F0 File Offset: 0x0001F6F0
        // (set) Token: 0x06000312 RID: 786 RVA: 0x00002EEE File Offset: 0x000010EE
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

        // Token: 0x1700014F RID: 335
        // (get) Token: 0x06000313 RID: 787 RVA: 0x00021508 File Offset: 0x0001F708
        // (set) Token: 0x06000314 RID: 788 RVA: 0x00021520 File Offset: 0x0001F720
        internal virtual Button Button39
        {
            get
            {
                return this._Button39;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button39_Click);
                if (this._Button39 != null)
                {
                    this._Button39.Click -= value2;
                }
                this._Button39 = value;
                if (this._Button39 != null)
                {
                    this._Button39.Click += value2;
                }
            }
        }

        // Token: 0x17000150 RID: 336
        // (get) Token: 0x06000315 RID: 789 RVA: 0x0002156C File Offset: 0x0001F76C
        // (set) Token: 0x06000316 RID: 790 RVA: 0x00021584 File Offset: 0x0001F784
        internal virtual TextBox gwxouterborderwidth
        {
            get
            {
                return this._gwxouterborderwidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._gwxouterborderwidth != null)
                {
                    this._gwxouterborderwidth.KeyPress -= value2;
                }
                this._gwxouterborderwidth = value;
                if (this._gwxouterborderwidth != null)
                {
                    this._gwxouterborderwidth.KeyPress += value2;
                }
            }
        }

        // Token: 0x17000151 RID: 337
        // (get) Token: 0x06000317 RID: 791 RVA: 0x000215D0 File Offset: 0x0001F7D0
        // (set) Token: 0x06000318 RID: 792 RVA: 0x000215E8 File Offset: 0x0001F7E8
        internal virtual TextBox gwxdoublinespace
        {
            get
            {
                return this._gwxdoublinespace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._gwxdoublinespace != null)
                {
                    this._gwxdoublinespace.KeyPress -= value2;
                }
                this._gwxdoublinespace = value;
                if (this._gwxdoublinespace != null)
                {
                    this._gwxdoublinespace.KeyPress += value2;
                }
            }
        }

        // Token: 0x17000152 RID: 338
        // (get) Token: 0x06000319 RID: 793 RVA: 0x00021634 File Offset: 0x0001F834
        // (set) Token: 0x0600031A RID: 794 RVA: 0x00002EF7 File Offset: 0x000010F7
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

        // Token: 0x17000153 RID: 339
        // (get) Token: 0x0600031B RID: 795 RVA: 0x0002164C File Offset: 0x0001F84C
        // (set) Token: 0x0600031C RID: 796 RVA: 0x00002F00 File Offset: 0x00001100
        internal virtual Label Label85
        {
            get
            {
                return this._Label85;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label85 = value;
            }
        }

        // Token: 0x17000154 RID: 340
        // (get) Token: 0x0600031D RID: 797 RVA: 0x00021664 File Offset: 0x0001F864
        // (set) Token: 0x0600031E RID: 798 RVA: 0x00002F09 File Offset: 0x00001109
        internal virtual CheckBox gwxdoubleline
        {
            get
            {
                return this._gwxdoubleline;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gwxdoubleline = value;
            }
        }

        // Token: 0x17000155 RID: 341
        // (get) Token: 0x0600031F RID: 799 RVA: 0x0002167C File Offset: 0x0001F87C
        // (set) Token: 0x06000320 RID: 800 RVA: 0x00021694 File Offset: 0x0001F894
        internal virtual CheckBox gwxouterborder
        {
            get
            {
                return this._gwxouterborder;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.gwxouterborder_CheckedChanged);
                if (this._gwxouterborder != null)
                {
                    this._gwxouterborder.CheckedChanged -= value2;
                }
                this._gwxouterborder = value;
                if (this._gwxouterborder != null)
                {
                    this._gwxouterborder.CheckedChanged += value2;
                }
            }
        }

        // Token: 0x17000156 RID: 342
        // (get) Token: 0x06000321 RID: 801 RVA: 0x000216E0 File Offset: 0x0001F8E0
        // (set) Token: 0x06000322 RID: 802 RVA: 0x00002F12 File Offset: 0x00001112
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

        // Token: 0x17000157 RID: 343
        // (get) Token: 0x06000323 RID: 803 RVA: 0x000216F8 File Offset: 0x0001F8F8
        // (set) Token: 0x06000324 RID: 804 RVA: 0x00002F1B File Offset: 0x0000111B
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

        // Token: 0x17000158 RID: 344
        // (get) Token: 0x06000325 RID: 805 RVA: 0x00021710 File Offset: 0x0001F910
        // (set) Token: 0x06000326 RID: 806 RVA: 0x00002F24 File Offset: 0x00001124
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

        // Token: 0x17000159 RID: 345
        // (get) Token: 0x06000327 RID: 807 RVA: 0x00021728 File Offset: 0x0001F928
        // (set) Token: 0x06000328 RID: 808 RVA: 0x00002F2D File Offset: 0x0000112D
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

        // Token: 0x1700015A RID: 346
        // (get) Token: 0x06000329 RID: 809 RVA: 0x00021740 File Offset: 0x0001F940
        // (set) Token: 0x0600032A RID: 810 RVA: 0x00002F36 File Offset: 0x00001136
        internal virtual CheckBox yj
        {
            get
            {
                return this._yj;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._yj = value;
            }
        }

        // Token: 0x1700015B RID: 347
        // (get) Token: 0x0600032B RID: 811 RVA: 0x00021758 File Offset: 0x0001F958
        // (set) Token: 0x0600032C RID: 812 RVA: 0x00002F3F File Offset: 0x0000113F
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

        // Token: 0x1700015C RID: 348
        // (get) Token: 0x0600032D RID: 813 RVA: 0x00021770 File Offset: 0x0001F970
        // (set) Token: 0x0600032E RID: 814 RVA: 0x00002F48 File Offset: 0x00001148
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

        // Token: 0x1700015D RID: 349
        // (get) Token: 0x0600032F RID: 815 RVA: 0x00021788 File Offset: 0x0001F988
        // (set) Token: 0x06000330 RID: 816 RVA: 0x000217A0 File Offset: 0x0001F9A0
        internal virtual TextBox cbottom
        {
            get
            {
                return this._cbottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._cbottom != null)
                {
                    this._cbottom.KeyPress -= value2;
                }
                this._cbottom = value;
                if (this._cbottom != null)
                {
                    this._cbottom.KeyPress += value2;
                }
            }
        }

        // Token: 0x1700015E RID: 350
        // (get) Token: 0x06000331 RID: 817 RVA: 0x000217EC File Offset: 0x0001F9EC
        // (set) Token: 0x06000332 RID: 818 RVA: 0x00021804 File Offset: 0x0001FA04
        internal virtual TextBox ctop
        {
            get
            {
                return this._ctop;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._ctop != null)
                {
                    this._ctop.KeyPress -= value2;
                }
                this._ctop = value;
                if (this._ctop != null)
                {
                    this._ctop.KeyPress += value2;
                }
            }
        }

        // Token: 0x1700015F RID: 351
        // (get) Token: 0x06000333 RID: 819 RVA: 0x00021850 File Offset: 0x0001FA50
        // (set) Token: 0x06000334 RID: 820 RVA: 0x00002F51 File Offset: 0x00001151
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

        // Token: 0x17000160 RID: 352
        // (get) Token: 0x06000335 RID: 821 RVA: 0x00021868 File Offset: 0x0001FA68
        // (set) Token: 0x06000336 RID: 822 RVA: 0x00021880 File Offset: 0x0001FA80
        internal virtual TextBox cright
        {
            get
            {
                return this._cright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._cright != null)
                {
                    this._cright.KeyPress -= value2;
                }
                this._cright = value;
                if (this._cright != null)
                {
                    this._cright.KeyPress += value2;
                }
            }
        }

        // Token: 0x17000161 RID: 353
        // (get) Token: 0x06000337 RID: 823 RVA: 0x000218CC File Offset: 0x0001FACC
        // (set) Token: 0x06000338 RID: 824 RVA: 0x00002F5A File Offset: 0x0000115A
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

        // Token: 0x17000162 RID: 354
        // (get) Token: 0x06000339 RID: 825 RVA: 0x000218E4 File Offset: 0x0001FAE4
        // (set) Token: 0x0600033A RID: 826 RVA: 0x000218FC File Offset: 0x0001FAFC
        internal virtual TextBox cleft
        {
            get
            {
                return this._cleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler value2 = new KeyPressEventHandler(this.zdxposition_KeyPress);
                if (this._cleft != null)
                {
                    this._cleft.KeyPress -= value2;
                }
                this._cleft = value;
                if (this._cleft != null)
                {
                    this._cleft.KeyPress += value2;
                }
            }
        }

        // Token: 0x17000163 RID: 355
        // (get) Token: 0x0600033B RID: 827 RVA: 0x00021948 File Offset: 0x0001FB48
        // (set) Token: 0x0600033C RID: 828 RVA: 0x00002F63 File Offset: 0x00001163
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

        // Token: 0x17000164 RID: 356
        // (get) Token: 0x0600033D RID: 829 RVA: 0x00021960 File Offset: 0x0001FB60
        // (set) Token: 0x0600033E RID: 830 RVA: 0x00002F6C File Offset: 0x0000116C
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

        // Token: 0x17000165 RID: 357
        // (get) Token: 0x0600033F RID: 831 RVA: 0x00021978 File Offset: 0x0001FB78
        // (set) Token: 0x06000340 RID: 832 RVA: 0x00021990 File Offset: 0x0001FB90
        internal virtual Button savefangan
        {
            get
            {
                return this._savefangan;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.savefangan_Click);
                if (this._savefangan != null)
                {
                    this._savefangan.Click -= value2;
                }
                this._savefangan = value;
                if (this._savefangan != null)
                {
                    this._savefangan.Click += value2;
                }
            }
        }

        // Token: 0x17000166 RID: 358
        // (get) Token: 0x06000341 RID: 833 RVA: 0x000219DC File Offset: 0x0001FBDC
        // (set) Token: 0x06000342 RID: 834 RVA: 0x00002F75 File Offset: 0x00001175
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

        // Token: 0x17000167 RID: 359
        // (get) Token: 0x06000343 RID: 835 RVA: 0x000219F4 File Offset: 0x0001FBF4
        // (set) Token: 0x06000344 RID: 836 RVA: 0x00002F7E File Offset: 0x0000117E
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

        // Token: 0x17000168 RID: 360
        // (get) Token: 0x06000345 RID: 837 RVA: 0x00021A0C File Offset: 0x0001FC0C
        // (set) Token: 0x06000346 RID: 838 RVA: 0x00002F87 File Offset: 0x00001187
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

        // Token: 0x17000169 RID: 361
        // (get) Token: 0x06000347 RID: 839 RVA: 0x00021A24 File Offset: 0x0001FC24
        // (set) Token: 0x06000348 RID: 840 RVA: 0x00002F90 File Offset: 0x00001190
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

        // Token: 0x1700016A RID: 362
        // (get) Token: 0x06000349 RID: 841 RVA: 0x00021A3C File Offset: 0x0001FC3C
        // (set) Token: 0x0600034A RID: 842 RVA: 0x00002F99 File Offset: 0x00001199
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

        // Token: 0x1700016B RID: 363
        // (get) Token: 0x0600034B RID: 843 RVA: 0x00021A54 File Offset: 0x0001FC54
        // (set) Token: 0x0600034C RID: 844 RVA: 0x00002FA2 File Offset: 0x000011A2
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

        // Token: 0x1700016C RID: 364
        // (get) Token: 0x0600034D RID: 845 RVA: 0x00021A6C File Offset: 0x0001FC6C
        // (set) Token: 0x0600034E RID: 846 RVA: 0x00002FAB File Offset: 0x000011AB
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

        // Token: 0x1700016D RID: 365
        // (get) Token: 0x0600034F RID: 847 RVA: 0x00021A84 File Offset: 0x0001FC84
        // (set) Token: 0x06000350 RID: 848 RVA: 0x00002FB4 File Offset: 0x000011B4
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

        // Token: 0x1700016E RID: 366
        // (get) Token: 0x06000351 RID: 849 RVA: 0x00021A9C File Offset: 0x0001FC9C
        // (set) Token: 0x06000352 RID: 850 RVA: 0x00002FBD File Offset: 0x000011BD
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

        // Token: 0x1700016F RID: 367
        // (get) Token: 0x06000353 RID: 851 RVA: 0x00021AB4 File Offset: 0x0001FCB4
        // (set) Token: 0x06000354 RID: 852 RVA: 0x00021ACC File Offset: 0x0001FCCC
        internal virtual Button reportfootercolor
        {
            get
            {
                return this._reportfootercolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportfootercolor_Click);
                if (this._reportfootercolor != null)
                {
                    this._reportfootercolor.Click -= value2;
                }
                this._reportfootercolor = value;
                if (this._reportfootercolor != null)
                {
                    this._reportfootercolor.Click += value2;
                }
            }
        }

        // Token: 0x17000170 RID: 368
        // (get) Token: 0x06000355 RID: 853 RVA: 0x00021B18 File Offset: 0x0001FD18
        // (set) Token: 0x06000356 RID: 854 RVA: 0x00021B30 File Offset: 0x0001FD30
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

        // Token: 0x17000171 RID: 369
        // (get) Token: 0x06000357 RID: 855 RVA: 0x00021B7C File Offset: 0x0001FD7C
        // (set) Token: 0x06000358 RID: 856 RVA: 0x00002FC6 File Offset: 0x000011C6
        internal virtual TextBox reportfootertext
        {
            get
            {
                return this._reportfootertext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._reportfootertext = value;
            }
        }

        // Token: 0x17000172 RID: 370
        // (get) Token: 0x06000359 RID: 857 RVA: 0x00021B94 File Offset: 0x0001FD94
        // (set) Token: 0x0600035A RID: 858 RVA: 0x00002FCF File Offset: 0x000011CF
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

        // Token: 0x17000173 RID: 371
        // (get) Token: 0x0600035B RID: 859 RVA: 0x00021BAC File Offset: 0x0001FDAC
        // (set) Token: 0x0600035C RID: 860 RVA: 0x00002FD8 File Offset: 0x000011D8
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

        // Token: 0x17000174 RID: 372
        // (get) Token: 0x0600035D RID: 861 RVA: 0x00021BC4 File Offset: 0x0001FDC4
        // (set) Token: 0x0600035E RID: 862 RVA: 0x00002FE1 File Offset: 0x000011E1
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

        // Token: 0x17000175 RID: 373
        // (get) Token: 0x0600035F RID: 863 RVA: 0x00021BDC File Offset: 0x0001FDDC
        // (set) Token: 0x06000360 RID: 864 RVA: 0x00021BF4 File Offset: 0x0001FDF4
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

        // Token: 0x17000176 RID: 374
        // (get) Token: 0x06000361 RID: 865 RVA: 0x00021C40 File Offset: 0x0001FE40
        // (set) Token: 0x06000362 RID: 866 RVA: 0x00002FEA File Offset: 0x000011EA
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

        // Token: 0x17000177 RID: 375
        // (get) Token: 0x06000363 RID: 867 RVA: 0x00021C58 File Offset: 0x0001FE58
        // (set) Token: 0x06000364 RID: 868 RVA: 0x00002FF3 File Offset: 0x000011F3
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

        // Token: 0x17000178 RID: 376
        // (get) Token: 0x06000365 RID: 869 RVA: 0x00021C70 File Offset: 0x0001FE70
        // (set) Token: 0x06000366 RID: 870 RVA: 0x00021C88 File Offset: 0x0001FE88
        internal virtual Button reportheadercolor
        {
            get
            {
                return this._reportheadercolor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.reportheadercolor_Click);
                if (this._reportheadercolor != null)
                {
                    this._reportheadercolor.Click -= value2;
                }
                this._reportheadercolor = value;
                if (this._reportheadercolor != null)
                {
                    this._reportheadercolor.Click += value2;
                }
            }
        }

        // Token: 0x17000179 RID: 377
        // (get) Token: 0x06000367 RID: 871 RVA: 0x00021CD4 File Offset: 0x0001FED4
        // (set) Token: 0x06000368 RID: 872 RVA: 0x00021CEC File Offset: 0x0001FEEC
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

        // Token: 0x1700017A RID: 378
        // (get) Token: 0x06000369 RID: 873 RVA: 0x00021D38 File Offset: 0x0001FF38
        // (set) Token: 0x0600036A RID: 874 RVA: 0x00002FFC File Offset: 0x000011FC
        internal virtual TextBox reportheadertext
        {
            get
            {
                return this._reportheadertext;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._reportheadertext = value;
            }
        }

        // Token: 0x1700017B RID: 379
        // (get) Token: 0x0600036B RID: 875 RVA: 0x00021D50 File Offset: 0x0001FF50
        // (set) Token: 0x0600036C RID: 876 RVA: 0x00003005 File Offset: 0x00001205
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

        // Token: 0x1700017C RID: 380
        // (get) Token: 0x0600036D RID: 877 RVA: 0x00021D68 File Offset: 0x0001FF68
        // (set) Token: 0x0600036E RID: 878 RVA: 0x0000300E File Offset: 0x0000120E
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

        // Token: 0x1700017D RID: 381
        // (get) Token: 0x0600036F RID: 879 RVA: 0x00021D80 File Offset: 0x0001FF80
        // (set) Token: 0x06000370 RID: 880 RVA: 0x00003017 File Offset: 0x00001217
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

        // Token: 0x1700017E RID: 382
        // (get) Token: 0x06000371 RID: 881 RVA: 0x00021D98 File Offset: 0x0001FF98
        // (set) Token: 0x06000372 RID: 882 RVA: 0x00021DB0 File Offset: 0x0001FFB0
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

        // Token: 0x1700017F RID: 383
        // (get) Token: 0x06000373 RID: 883 RVA: 0x00021DFC File Offset: 0x0001FFFC
        // (set) Token: 0x06000374 RID: 884 RVA: 0x00003020 File Offset: 0x00001220
        internal virtual Label Label39
        {
            get
            {
                return this._Label39;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label39 = value;
            }
        }

        // Token: 0x17000180 RID: 384
        // (get) Token: 0x06000375 RID: 885 RVA: 0x00021E14 File Offset: 0x00020014
        // (set) Token: 0x06000376 RID: 886 RVA: 0x00003029 File Offset: 0x00001229
        internal virtual CheckBox gzwrap
        {
            get
            {
                return this._gzwrap;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gzwrap = value;
            }
        }

        // Token: 0x17000181 RID: 385
        // (get) Token: 0x06000377 RID: 887 RVA: 0x00021E2C File Offset: 0x0002002C
        // (set) Token: 0x06000378 RID: 888 RVA: 0x00021E44 File Offset: 0x00020044
        internal virtual Button exporthtml
        {
            get
            {
                return this._exporthtml;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button41_Click);
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

        // Token: 0x17000182 RID: 386
        // (get) Token: 0x06000379 RID: 889 RVA: 0x00021E90 File Offset: 0x00020090
        // (set) Token: 0x0600037A RID: 890 RVA: 0x00021EA8 File Offset: 0x000200A8
        internal virtual Button exportrtf
        {
            get
            {
                return this._exportrtf;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button40_Click);
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

        // Token: 0x17000183 RID: 387
        // (get) Token: 0x0600037B RID: 891 RVA: 0x00021EF4 File Offset: 0x000200F4
        // (set) Token: 0x0600037C RID: 892 RVA: 0x00021F0C File Offset: 0x0002010C
        internal virtual Button exportpdf
        {
            get
            {
                return this._exportpdf;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button42_Click);
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

        // Token: 0x17000184 RID: 388
        // (get) Token: 0x0600037D RID: 893 RVA: 0x00021F58 File Offset: 0x00020158
        // (set) Token: 0x0600037E RID: 894 RVA: 0x00021F70 File Offset: 0x00020170
        internal virtual Button exportexcel2
        {
            get
            {
                return this._exportexcel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.exportexcel2_Click);
                if (this._exportexcel2 != null)
                {
                    this._exportexcel2.Click -= value2;
                }
                this._exportexcel2 = value;
                if (this._exportexcel2 != null)
                {
                    this._exportexcel2.Click += value2;
                }
            }
        }

        // Token: 0x0600037F RID: 895 RVA: 0x00021FBC File Offset: 0x000201BC
        private void Button1_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.maintitle.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.maintitle.Font = this.FontDialog1.Font;
                this.ztitlefont = this.FontDialog1.Font;
            }
        }

        // Token: 0x06000380 RID: 896 RVA: 0x00022014 File Offset: 0x00020214
        private void Button2_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.subtitle.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.subtitle.Font = this.FontDialog1.Font;
                this.ftitlefont = this.FontDialog1.Font;
            }
        }

        // Token: 0x06000381 RID: 897 RVA: 0x0002206C File Offset: 0x0002026C
        public void SetPrintCS()
        {
            this.papertype.Items.Clear();
            PrinterSettings printerSettings = new PrinterSettings();
            if (String.Compare(this.currentprintname, "", false) != 0 && Module1.IsValidPrinterName(this.currentprintname))
            {
                printerSettings.PrinterName = this.currentprintname;
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
                            text = Convert.ToString((int)paperSizes[i].Kind);
                        }
                        else
                        {
                            text = text + "," + Convert.ToString((int)paperSizes[i].Kind);
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
                            PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.papername);
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
                this.pagemarginl.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Left / 10.0, 3));
                this.pagemarginr.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Right / 10.0, 3));
                this.pagemargint.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Top / 10.0, 3));
                this.pagemarginb.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Bottom / 10.0, 3));
                if (this.PaperLandscape)
                {
                    this.fx.Text = "横向";
                }
                else
                {
                    this.fx.Text = "纵向";
                }
            }
        }

        // Token: 0x06000382 RID: 898 RVA: 0x00003032 File Offset: 0x00001232
        private void DataGridViewPrintSet_Load(object sender, EventArgs e)
        {
            this.MyLoad();
        }

        // Token: 0x06000383 RID: 899 RVA: 0x000223F0 File Offset: 0x000205F0
        public void MyLoad()
        {
            int num = 0;
            checked
            {
                int num2 = this.dgvtoprint.ColumnCount - 1;
                int i;
                for (i = num; i <= num2; i++)
                {
                    int num3 = i + 1;
                    int num4 = this.dgvtoprint.ColumnCount - 1;
                    for (int j = num3; j <= num4; j++)
                    {
                        if (String.Compare(this.dgvtoprint.Columns[i].Name, this.dgvtoprint.Columns[j].Name, false) == 0)
                        {
                            this.dgvtoprint.Columns[j].Name = "第" + Convert.ToString(j) + "列名称";
                        }
                    }
                }
                bool flag = false;
                int num5 = 0;
                int num6 = this.dgvtoprint.ColumnCount - 1;
                i = num5;
            IL_117:
                while (i <= num6)
                {
                    int num7 = i + 1;
                    int num8 = this.dgvtoprint.ColumnCount - 1;
                    int j = num7;
                    while (j <= num8)
                    {
                        if (String.Compare(this.dgvtoprint.Columns[i].HeaderText, this.dgvtoprint.Columns[j].HeaderText, false) == 0)
                        {
                            flag = true;
                        IL_110:
                            if (!flag)
                            {
                                i++;
                                goto IL_117;
                            }
                            goto IL_11C;
                        }
                        else
                        {
                            j++;
                        }
                    }

                }
            IL_11C:
                if (flag)
                {
                    Interaction.MsgBox("DataGridView控件中存在表头字段显示名称HeaderText值为【" + this.dgvtoprint.Columns[i].HeaderText + "】的有多列，本控件要求列显示名称必须唯一，否则会产生问题，请修改。", MsgBoxStyle.OkOnly, "提示信息");
                }
                this.SetPrintCS();
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
                this.maintitle.Text = this.ztitle;
                if (this.ztitlefont != null)
                {
                    this.maintitle.Font = (Font)this.ztitlefont.Clone();
                }
                this.subtitle.Text = this.ftitle;
                if (this.ftitlefont != null)
                {
                    this.subtitle.Font = (Font)this.ftitlefont.Clone();
                }
                switch (this.bgalignment)
                {
                    case StringAlignment.Near:
                        this.dq.Text = "左对齐";
                        break;
                    case StringAlignment.Center:
                        this.dq.Text = "居中对齐";
                        break;
                    case StringAlignment.Far:
                        this.dq.Text = "右对齐";
                        break;
                }
                if (this.zoomtopaperwidth)
                {
                    this.kd.Checked = true;
                }
                else
                {
                    this.kd.Checked = false;
                }
                if (this.autoresizerowheight)
                {
                    this.gd.Checked = true;
                }
                else
                {
                    this.gd.Checked = false;
                }
                this.minsize.Text = Convert.ToString(this.minfontsize);
                if (this.reppagetitle)
                {
                    this.bt.Checked = true;
                }
                else
                {
                    this.bt.Checked = false;
                }
                if (this.printbackcolor)
                {
                    this.bj.Checked = true;
                }
                else
                {
                    this.bj.Checked = false;
                }
                string left = this.myborder;
                if (String.Compare(left, "1111", false) == 0)
                {
                    this.bk.Text = "表格线";
                }
                else if (String.Compare(left, "0101", false) == 0)
                {
                    this.bk.Text = "仅横线";
                }
                else if (String.Compare(left, "1010", false) == 0)
                {
                    this.bk.Text = "仅竖线";
                }
                else if (String.Compare(left, "0000", false) == 0)
                {
                    this.bk.Text = "无线";
                }
                else
                {
                    this.bk.Text = this.myborder;
                }
                this.gzjj.Value = new decimal(this.linespace);
                if (this.printzero)
                {
                    this.lz.Checked = true;
                }
                else
                {
                    this.lz.Checked = false;
                }
                if (this.autowrap)
                {
                    this.gzwrap.Checked = true;
                }
                else
                {
                    this.gzwrap.Checked = false;
                }
                this.ls.Text = Convert.ToString(this.mycolumns);
                this.ljj.Value = new decimal(this.columnspace);
                if (this.lastpagemode)
                {
                    this.zh.Checked = true;
                }
                else
                {
                    this.zh.Checked = false;
                }
                this.columns.Text = Convert.ToString(this.fixedcols);
                if (this.autoformat)
                {
                    this.gsf.Checked = true;
                }
                else
                {
                    this.gsf.Checked = false;
                }
                this.SetTS();
                this.colcount = this.dgvtoprint.ColumnCount;
                this.SetFieldToComb();
                this.rowheight.Value = new decimal(this.myrowheight);
                if (this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor.ToArgb() == 0)
                {
                    this.Cforecolor.Checked = true;
                    this.bforecolor.Enabled = false;
                    this.jsh.ForeColor = this.dgvtoprint.DefaultCellStyle.ForeColor;
                }
                else
                {
                    this.Cforecolor.Checked = false;
                    this.bforecolor.Enabled = true;
                    this.jsh.ForeColor = this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor;
                }
                if (this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor.ToArgb() == 0)
                {
                    this.Cbackcolor.Checked = true;
                    this.bbackcolor.Enabled = false;
                    this.jsh.BackColor = this.dgvtoprint.DefaultCellStyle.BackColor;
                }
                else
                {
                    this.Cbackcolor.Checked = false;
                    this.bbackcolor.Enabled = true;
                    this.jsh.BackColor = this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor;
                }
                try
                {
                    this.fontshow.Font = (Font)this.dgvtoprint.DefaultCellStyle.Font.Clone();
                }
                catch (Exception ex)
                {
                }
                this.fontshow.ForeColor = this.dgvtoprint.DefaultCellStyle.ForeColor;
                this.fontshow.BackColor = this.dgvtoprint.DefaultCellStyle.BackColor;
                try
                {
                    this.headerfont.Font = (Font)this.dgvtoprint.ColumnHeadersDefaultCellStyle.Font.Clone();
                }
                catch (Exception ex2)
                {
                }
                this.headerfont.ForeColor = this.dgvtoprint.ColumnHeadersDefaultCellStyle.ForeColor;
                this.headerfont.BackColor = this.dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor;
                if (this.myhzfont == null)
                {
                    this.myhzfont = new Font("黑体", this.dgvtoprint.DefaultCellStyle.Font.Size, FontStyle.Bold);
                }
                if (this.myhzforecolor.ToArgb() == 0)
                {
                    this.myhzforecolor = this.dgvtoprint.DefaultCellStyle.ForeColor;
                }
                if (this.myhzbackcolor.ToArgb() == 0)
                {
                    this.myhzbackcolor = this.dgvtoprint.DefaultCellStyle.BackColor;
                }
                this.hzfontshow.Font = this.myhzfont;
                this.hzfontshow.ForeColor = this.myhzforecolor;
                this.hzfontshow.BackColor = this.myhzbackcolor;
                this.pagel.Text = this.mypagel;
                this.pagem.Text = this.mypagem;
                this.pager.Text = this.mypager;
                this.pageleft.Text = this.mypageleft;
                this.pageright.Text = this.mypageright;
                this.pagemiddle.Text = this.mypagemiddle;
                this.tablel.Text = this.mytablel;
                this.tablem.Text = this.mytablem;
                this.tabler.Text = this.mytabler;
                this.tableleft.Text = this.mytableleft;
                this.tablemiddle.Text = this.mytablemiddle;
                this.tableright.Text = this.mytableright;
                try
                {
                    this.pageleft.Font = this.myfooterfont;
                    this.pageright.Font = this.myfooterfont;
                }
                catch (Exception ex3)
                {
                }
                try
                {
                    this.pagel.Font = this.myheaderfont;
                    this.pager.Font = this.myheaderfont;
                    this.pagem.Font = this.myheaderfont;
                }
                catch (Exception ex4)
                {
                }
                try
                {
                    this.tablel.Font = this.mytopfont;
                    this.tablem.Font = this.mytopfont;
                    this.tabler.Font = this.mytopfont;
                }
                catch (Exception ex5)
                {
                }
                try
                {
                    this.tableleft.Font = this.mybottomfont;
                    this.tablemiddle.Font = this.mybottomfont;
                    this.tableright.Font = this.mybottomfont;
                }
                catch (Exception ex6)
                {
                }
                this.pageleft.ForeColor = this.myfootercolor;
                this.pagemiddle.ForeColor = this.myfootercolor;
                this.pageright.ForeColor = this.myfootercolor;
                this.pagel.ForeColor = this.myheadercolor;
                this.pagem.ForeColor = this.myheadercolor;
                this.pager.ForeColor = this.myheadercolor;
                this.maintitle.ForeColor = this.mydefaultcolor;
                this.subtitle.ForeColor = this.mydefaultcolor;
                this.tablel.ForeColor = this.mydefaultcolor;
                this.tablem.ForeColor = this.mydefaultcolor;
                this.tabler.ForeColor = this.mydefaultcolor;
                this.tableleft.ForeColor = this.mydefaultcolor;
                this.tableright.ForeColor = this.mydefaultcolor;
                this.tablemiddle.ForeColor = this.mydefaultcolor;
                this.rightt.Text = this.myrightt;
                this.rightm.Text = this.myrightm;
                this.rightb.Text = this.myrightb;
                this.rightt.Font = this.myrightfont;
                this.rightm.Font = this.myrightfont;
                this.rightb.Font = this.myrightfont;
                this.rightt.ForeColor = this.myrightcolor;
                this.rightm.ForeColor = this.myrightcolor;
                this.rightb.ForeColor = this.myrightcolor;
                this.Button23.ForeColor = this.dgvtoprint.GridColor;
                if (this.mywatermarklandscape)
                {
                    this.syfx.Text = "水平";
                }
                else
                {
                    this.syfx.Text = "垂直";
                }
                this.sytm.Value = new decimal((int)this.mywatermarkopacity);
                this.sytext.Text = this.mywatermarktext;
                if (this.mytitletextstyle < 0 | this.mytitletextstyle > 6)
                {
                    this.mytitletextstyle = 0;
                }
                this.zys.SelectedIndex = this.mytitletextstyle;
                if (this.mysubtitlestyle < 0 | this.mysubtitlestyle > 6)
                {
                    this.mysubtitlestyle = 0;
                }
                this.fys.SelectedIndex = this.mysubtitlestyle;
                this.sytext.ForeColor = this.mywatermarkcolor;
                this.sytext.Font = this.mywatermarkfont;
                this.SetGroup();
                this.SetAlign();
                this.yj.Checked = this.myisdrawtablefootereverypage;
                this.gwxdoubleline.Checked = this.myisusedoubleline;
                this.gwxouterborder.Checked = this.myouterborder;
                this.gwxouterborderwidth.Text = Convert.ToString(this.myouterborderwidth);
                this.gwxdoublinespace.Text = Convert.ToString(this.thedoublelinespace);
                this.Button39.ForeColor = this.myouterbordercolor;
                this.cleft.Text = Convert.ToString(Math.Round((double)this.myp.ConvertToMM((float)this.dgvtoprint.DefaultCellStyle.Padding.Left, true), 2));
                this.cright.Text = Convert.ToString(Math.Round((double)this.myp.ConvertToMM((float)this.dgvtoprint.DefaultCellStyle.Padding.Right, true), 2));
                this.ctop.Text = Convert.ToString(Math.Round((double)this.myp.ConvertToMM((float)this.dgvtoprint.DefaultCellStyle.Padding.Top, true), 2));
                this.cbottom.Text = Convert.ToString(Math.Round((double)this.myp.ConvertToMM((float)this.dgvtoprint.DefaultCellStyle.Padding.Bottom, true), 2));
                if (MyProject.Computer.FileSystem.FileExists(this.schemefilename) && this.NeedReadFangAn)
                {
                    this.RestoreFa(this.schemefilename);
                }
                this.drawheader.Checked = this.myisdrawpageheaderline;
                this.drawfooter.Checked = this.myisdrawpagefooterline;
                this.autoaddrow.Checked = this.myisautoaddemptyrow;
                this.GroupBoxpaper.Enabled = this.myEnableChangePageSettings;
                this.GroupBoxtablestyle.Enabled = this.myEnableChangeTableStyle;
                this.GroupBoxtitle1.Enabled = this.myEnableChangeTitle;
                this.GroupBoxtitle2.Enabled = this.myEnableChangeTitle;
                this.GroupBoxtitle3.Enabled = this.myEnableChangeTitle;
                this.GroupBoxtitle4.Enabled = this.myEnableChangeTitle;
                this.GroupBoxheader1.Enabled = this.myEnableChangeHeaderAndFooter;
                this.GroupBoxheader2.Enabled = this.myEnableChangeHeaderAndFooter;
                this.GroupBoxheader3.Enabled = this.myEnableChangeHeaderAndFooter;
                this.GroupBoxxx1.Enabled = this.myEnableChangeTableSettings;
                this.GroupBoxxx2.Enabled = this.myEnableChangeTableSettings;
                this.GroupBoxxx3.Enabled = this.myEnableChangeTableSettings;
                this.GroupBox17.Enabled = this.myEnableChangeTableSettings;
                this.GroupBoxhz.Enabled = this.myEnableChangeSum;
                this.GroupBoxgroup.Enabled = this.myEnableChangeGroup;
                this.GroupBoxZDX.Enabled = this.myEnableChangeZDX;
                this.GroupBoxwater.Enabled = this.myEnableChangeWaterMark;
                if (this.myisdrawZDX)
                {
                    this.isdrawzdx.Checked = true;
                    this.GroupBoxzdx1.Enabled = true;
                    this.GroupBoxzdx2.Enabled = true;
                    this.GroupBoxzdx3.Enabled = true;
                }
                else
                {
                    this.isdrawzdx.Checked = false;
                    this.GroupBoxzdx1.Enabled = false;
                    this.GroupBoxzdx2.Enabled = false;
                    this.GroupBoxzdx3.Enabled = false;
                }
                this.zdxtext.Text = this.myZDXtext;
                this.zdxtext.ForeColor = this.myZDXtextcolor;
                this.zdxtext.Font = this.myZDXfont;
                this.zdxlinecolor.ForeColor = this.myZDXlinecolor;
                this.zdxposition.Text = Convert.ToString(this.myZDXposition);
                this.SetZDXTypeAndLineType();
                if (this.myisshowaboutpage)
                {
                }
                this.s_schemefilename = Strings.Trim(this.schemefilename);
                if (String.Compare(this.s_schemefilename, "", false) == 0)
                {
                    this.savefangan.Enabled = false;
                }
                else
                {
                    this.savefangan.Enabled = this.myEnableChangeScheme;
                    if (!MyProject.Computer.FileSystem.FileExists(this.s_schemefilename))
                    {
                        try
                        {
                            this.SaveFa(this.s_schemefilename, true);
                        }
                        catch (Exception ex7)
                        {
                        }
                    }
                }
                this.reportheadertext.Text = this.myreportheadertext;
                if (this.myreportheaderfont != null)
                {
                    this.reportheadertext.Font = (Font)this.myreportheaderfont.Clone();
                }
                this.reportheadertext.ForeColor = this.myreportheadercolor;
                this.reportheaderspace.Value = new decimal(this.myreportheaderspace);
                switch (this.myreportheaderalignment)
                {
                    case StringAlignment.Center:
                        this.reportheaderalignment.Text = "居中对齐";
                        this.reportheadertext.TextAlign = HorizontalAlignment.Center;
                        break;
                    case StringAlignment.Far:
                        this.reportheaderalignment.Text = "右对齐";
                        this.reportheadertext.TextAlign = HorizontalAlignment.Right;
                        break;
                    default:
                        this.reportheaderalignment.Text = "左对齐";
                        this.reportheadertext.TextAlign = HorizontalAlignment.Left;
                        break;
                }
                this.reportfootertext.Text = this.myreportfootertext;
                if (this.myreportfooterfont != null)
                {
                    this.reportfootertext.Font = (Font)this.myreportfooterfont.Clone();
                }
                this.reportfootertext.ForeColor = this.myreportfootercolor;
                this.reportfooterspace.Value = new decimal(this.myreportfooterspace);
                switch (this.myreportfooteralignment)
                {
                    case StringAlignment.Center:
                        this.reportfooteralignment.Text = "居中对齐";
                        this.reportfootertext.TextAlign = HorizontalAlignment.Center;
                        break;
                    case StringAlignment.Far:
                        this.reportfooteralignment.Text = "右对齐";
                        this.reportfootertext.TextAlign = HorizontalAlignment.Right;
                        break;
                    default:
                        this.reportfooteralignment.Text = "左对齐";
                        this.reportfootertext.TextAlign = HorizontalAlignment.Left;
                        break;
                }
                this.exportexcel.Enabled = this.myenableexportexcel;
                this.exportexcel2.Enabled = this.myenableexportexcel;
                this.exportpdf.Enabled = this.myenableexportpdf;
                this.exporthtml.Enabled = this.myenableexporthtml;
                this.exportrtf.Enabled = this.myenableexportrtf;
            }
        }

        // Token: 0x06000384 RID: 900 RVA: 0x00023694 File Offset: 0x00021894
        private void GetAlign()
        {
            string text = this.sumalign.Text;
            StringAlignment stringAlignment = StringAlignment.Near;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.mySumNumberAlign = stringAlignment;
            string text2 = this.tabletopleftalign.Text;
            if (String.Compare(text2, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text2, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text2, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableTopLeftTitleAlign = stringAlignment;
            string text3 = this.tabletopmiddlealign.Text;
            if (String.Compare(text3, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text3, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text3, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableTopMiddleTitleAlign = stringAlignment;
            string text4 = this.tabletoprightalign.Text;
            if (String.Compare(text4, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text4, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text4, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableTopRightTitleAlign = stringAlignment;
            string text5 = this.tablebottomleftalign.Text;
            if (String.Compare(text5, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text5, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text5, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableBottomLeftTitleAlign = stringAlignment;
            string text6 = this.tablebottommiddlealign.Text;
            if (String.Compare(text6, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text6, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text6, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableBottomMiddleTitleAlign = stringAlignment;
            string text7 = this.tablebottomrightalign.Text;
            if (String.Compare(text7, "居中对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Center;
            }
            else if (String.Compare(text7, "左对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Near;
            }
            else if (String.Compare(text7, "右对齐", false) == 0)
            {
                stringAlignment = StringAlignment.Far;
            }
            this.myTableBottomRightTitleAlign = stringAlignment;
        }

        // Token: 0x06000385 RID: 901 RVA: 0x000238B8 File Offset: 0x00021AB8
        private void SetAlign()
        {
            switch (this.mySumNumberAlign)
            {
                case StringAlignment.Near:
                    this.sumalign.Text = "左对齐";
                    break;
                case StringAlignment.Center:
                    this.sumalign.Text = "居中对齐";
                    break;
                case StringAlignment.Far:
                    this.sumalign.Text = "右对齐";
                    break;
            }
            switch (this.myTableTopLeftTitleAlign)
            {
                case StringAlignment.Near:
                    this.tabletopleftalign.Text = "左对齐";
                    this.tablel.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tabletopleftalign.Text = "居中对齐";
                    this.tablel.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tabletopleftalign.Text = "右对齐";
                    this.tablel.TextAlign = HorizontalAlignment.Right;
                    break;
            }
            switch (this.myTableTopMiddleTitleAlign)
            {
                case StringAlignment.Near:
                    this.tabletopmiddlealign.Text = "左对齐";
                    this.tablem.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tabletopmiddlealign.Text = "居中对齐";
                    this.tablem.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tabletopmiddlealign.Text = "右对齐";
                    this.tablem.TextAlign = HorizontalAlignment.Right;
                    break;
            }
            switch (this.myTableTopRightTitleAlign)
            {
                case StringAlignment.Near:
                    this.tabletoprightalign.Text = "左对齐";
                    this.tabler.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tabletoprightalign.Text = "居中对齐";
                    this.tabler.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tabletoprightalign.Text = "右对齐";
                    this.tabler.TextAlign = HorizontalAlignment.Right;
                    break;
            }
            switch (this.myTableBottomLeftTitleAlign)
            {
                case StringAlignment.Near:
                    this.tablebottomleftalign.Text = "左对齐";
                    this.tableleft.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tablebottomleftalign.Text = "居中对齐";
                    this.tableleft.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tablebottomleftalign.Text = "右对齐";
                    this.tableleft.TextAlign = HorizontalAlignment.Right;
                    break;
            }
            switch (this.myTableBottomMiddleTitleAlign)
            {
                case StringAlignment.Near:
                    this.tablebottommiddlealign.Text = "左对齐";
                    this.tablemiddle.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tablebottommiddlealign.Text = "居中对齐";
                    this.tablemiddle.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tablebottommiddlealign.Text = "右对齐";
                    this.tablemiddle.TextAlign = HorizontalAlignment.Right;
                    break;
            }
            switch (this.myTableBottomRightTitleAlign)
            {
                case StringAlignment.Near:
                    this.tablebottomrightalign.Text = "左对齐";
                    this.tableright.TextAlign = HorizontalAlignment.Left;
                    break;
                case StringAlignment.Center:
                    this.tablebottomrightalign.Text = "居中对齐";
                    this.tableright.TextAlign = HorizontalAlignment.Center;
                    break;
                case StringAlignment.Far:
                    this.tablebottomrightalign.Text = "右对齐";
                    this.tableright.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        // Token: 0x06000386 RID: 902 RVA: 0x00023BB8 File Offset: 0x00021DB8
        private void SetGroup()
        {
            if (String.Compare(this.mysortcolumn + "", "", false) != 0)
            {
                try
                {
                    this.sortcolumn.SelectedItem = this.dgvtoprint.Columns[this.mysortcolumn].HeaderText;
                    goto IL_6C;
                }
                catch (Exception ex)
                {
                    this.sortcolumn.SelectedIndex = -1;
                    goto IL_6C;
                }
            }
            this.sortcolumn.SelectedIndex = -1;
        IL_6C:
            if (this.mysorttype)
            {
                this.sorta.Checked = true;
                this.sortd.Checked = false;
            }
            else
            {
                this.sorta.Checked = false;
                this.sortd.Checked = true;
            }
            if (String.Compare(this.mygroupcolumne + "", "", false) != 0)
            {
                try
                {
                    this.groupcolumn.SelectedItem = this.dgvtoprint.Columns[this.mygroupcolumne].HeaderText;
                    goto IL_112;
                }
                catch (Exception ex2)
                {
                    this.groupcolumn.SelectedIndex = -1;
                    goto IL_112;
                }
            }
            this.groupcolumn.SelectedIndex = -1;
        IL_112:
            if (this.mygroupnewpage)
            {
                this.groupnewpage.Checked = true;
            }
            else
            {
                this.groupnewpage.Checked = false;
            }
            if (this.myaddrowid)
            {
                this.addrowid.Checked = true;
            }
            else
            {
                this.addrowid.Checked = false;
            }
            if (this.myaddrownew)
            {
                this.addrownew.Checked = true;
            }
            else
            {
                this.addrownew.Checked = false;
            }
        }

        // Token: 0x06000387 RID: 903 RVA: 0x00023D5C File Offset: 0x00021F5C
        private void SetFieldToComb()
        {
            this.C1.Items.Clear();
            this.colcount = this.dgvtoprint.ColumnCount;
            checked
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
                this.hz.Items.Clear();
                int num5 = 0;
                int num6 = this.colcount - 1;
                for (int i = num5; i <= num6; i++)
                {
                    this.hz.Items.Add(this.dgvtoprint.Columns[array[i]].HeaderText, Module1.IsHzColumn(this.myhzcolumns, this.dgvtoprint.Columns[array[i]].Name));
                }
                try
                {
                    this.hz.SelectedIndex = 0;
                }
                catch (Exception ex2)
                {
                }
                this.sortcolumn.Items.Clear();
                this.groupcolumn.Items.Clear();
                this.sortcolumn.Items.Add("");
                this.groupcolumn.Items.Add("");
                int num7 = 0;
                int num8 = this.colcount - 1;
                for (int i = num7; i <= num8; i++)
                {
                    this.sortcolumn.Items.Add(this.dgvtoprint.Columns[array[i]].HeaderText);
                    this.groupcolumn.Items.Add(this.dgvtoprint.Columns[array[i]].HeaderText);
                }
            }
        }

        // Token: 0x06000388 RID: 904 RVA: 0x00023FBC File Offset: 0x000221BC
        private void SetTS()
        {
            switch (this.printtype)
            {
                case 1:
                    this.gz.Visible = false;
                    this.fl.Visible = false;
                    this.fy.Visible = false;
                    this.pt.Visible = true;
                    this.R1.Checked = true;
                    break;
                case 2:
                    this.fl.Visible = true;
                    this.gz.Visible = false;
                    this.fy.Visible = false;
                    this.pt.Visible = false;
                    this.R2.Checked = true;
                    break;
                case 3:
                    this.fl.Visible = false;
                    this.gz.Visible = false;
                    this.fy.Visible = true;
                    this.pt.Visible = false;
                    this.R3.Checked = true;
                    break;
                case 4:
                    this.fl.Visible = false;
                    this.gz.Visible = true;
                    this.fy.Visible = false;
                    this.pt.Visible = false;
                    this.R4.Checked = true;
                    break;
            }
        }

        // Token: 0x06000389 RID: 905 RVA: 0x000240E4 File Offset: 0x000222E4
        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.R1.Checked)
            {
                this.printtype = 1;
            }
            else if (this.R2.Checked)
            {
                this.printtype = 2;
            }
            else if (this.R3.Checked)
            {
                this.printtype = 3;
            }
            else if (this.R4.Checked)
            {
                this.printtype = 4;
            }
            this.SetTS();
        }

        // Token: 0x0600038A RID: 906 RVA: 0x000240E4 File Offset: 0x000222E4
        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.R1.Checked)
            {
                this.printtype = 1;
            }
            else if (this.R2.Checked)
            {
                this.printtype = 2;
            }
            else if (this.R3.Checked)
            {
                this.printtype = 3;
            }
            else if (this.R4.Checked)
            {
                this.printtype = 4;
            }
            this.SetTS();
        }

        // Token: 0x0600038B RID: 907 RVA: 0x000240E4 File Offset: 0x000222E4
        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.R1.Checked)
            {
                this.printtype = 1;
            }
            else if (this.R2.Checked)
            {
                this.printtype = 2;
            }
            else if (this.R3.Checked)
            {
                this.printtype = 3;
            }
            else if (this.R4.Checked)
            {
                this.printtype = 4;
            }
            this.SetTS();
        }

        // Token: 0x0600038C RID: 908 RVA: 0x000240E4 File Offset: 0x000222E4
        private void R4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.R1.Checked)
            {
                this.printtype = 1;
            }
            else if (this.R2.Checked)
            {
                this.printtype = 2;
            }
            else if (this.R3.Checked)
            {
                this.printtype = 3;
            }
            else if (this.R4.Checked)
            {
                this.printtype = 4;
            }
            this.SetTS();
        }

        // Token: 0x0600038D RID: 909 RVA: 0x0000303A File Offset: 0x0000123A
        public void start()
        {
            this.Button3_Click(null, null);
        }

        // Token: 0x0600038E RID: 910 RVA: 0x00024150 File Offset: 0x00022350
        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.isfirsttimeshow)
            {
                this.Close();
            }
            else
            {
                this.Visible = false;
                Module1.myshowpreview.needrefresh = false;
                try
                {
                    if (!Module1.myshowpreview.Modal)
                    {
                        Module1.myshowpreview.ShowDialog();
                    }
                    else
                    {
                        Module1.myshowpreview.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Module1.myshowpreview.Visible = true;
                }
            }
        }

        // Token: 0x0600038F RID: 911 RVA: 0x000241D0 File Offset: 0x000223D0
        private void Button3_Click(object sender, EventArgs e)
        {
            if (!Versioned.IsNumeric(this.pagemarginl.Text))
            {
                Interaction.MsgBox("页面左边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.pagemarginl.Focus();
            }
            else if (!Versioned.IsNumeric(this.pagemarginr.Text))
            {
                Interaction.MsgBox("页面右边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.pagemarginr.Focus();
            }
            else if (!Versioned.IsNumeric(this.pagemargint.Text))
            {
                Interaction.MsgBox("页面上边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.pagemargint.Focus();
            }
            else if (!Versioned.IsNumeric(this.pagemarginb.Text))
            {
                Interaction.MsgBox("页面下边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.pagemarginb.Focus();
            }
            else if (!Versioned.IsNumeric(this.cleft.Text))
            {
                Interaction.MsgBox("单元格默认边距中的左边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.cleft.Focus();
            }
            else if (!Versioned.IsNumeric(this.cright.Text))
            {
                Interaction.MsgBox("单元格默认边距中的右边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.cright.Focus();
            }
            else if (!Versioned.IsNumeric(this.ctop.Text))
            {
                Interaction.MsgBox("单元格默认边距中的上边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.ctop.Focus();
            }
            else if (!Versioned.IsNumeric(this.cbottom.Text))
            {
                Interaction.MsgBox("单元格默认边距中的下边距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.cbottom.Focus();
            }
            else if (!Versioned.IsNumeric(this.zdxposition.Text))
            {
                Interaction.MsgBox("装订线打印位置设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.TabControl1.SelectedTab = this.TabControl1.TabPages[5];
                this.zdxposition.Focus();
            }
            else if (!Versioned.IsNumeric(this.gwxdoublinespace.Text))
            {
                Interaction.MsgBox("双线间距设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.TabControl1.SelectedTab = this.TabControl1.TabPages[0];
                this.gwxdoublinespace.Focus();
            }
            else if (!Versioned.IsNumeric(this.gwxouterborderwidth.Text))
            {
                Interaction.MsgBox("表格线外边框线宽设置不正确，必须是有效的数字", MsgBoxStyle.OkOnly, "提示信息");
                this.TabControl1.SelectedTab = this.TabControl1.TabPages[0];
                this.gwxouterborderwidth.Focus();
            }
            else
            {
                this.myrowheight = Convert.ToSingle(this.rowheight.Value);
                this.mypapermarign.Left = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(this.pagemarginl.Text), 10m));
                this.mypapermarign.Right = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(this.pagemarginr.Text), 10m));
                this.mypapermarign.Top = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(this.pagemargint.Text), 10m));
                this.mypapermarign.Bottom = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(this.pagemarginb.Text), 10m));
                this.mypagel = this.pagel.Text;
                this.mypagem = this.pagem.Text;
                this.mypager = this.pager.Text;
                this.mypageleft = this.pageleft.Text;
                this.mypageright = this.pageright.Text;
                this.mypagemiddle = this.pagemiddle.Text;
                this.mytablel = this.tablel.Text;
                this.mytablem = this.tablem.Text;
                this.mytabler = this.tabler.Text;
                this.mytableleft = this.tableleft.Text;
                this.mytablemiddle = this.tablemiddle.Text;
                this.mytableright = this.tableright.Text;
                if (this.gsf.Checked)
                {
                    this.autoformat = true;
                }
                else
                {
                    this.autoformat = false;
                }
                Module1.myshowpreview.printtype = this.printtype;
                Module1.myshowpreview.mywindowtext = this.mywindowtext;
                Module1.myshowpreview.ztitle = this.maintitle.Text;
                this.ztitle = this.maintitle.Text;
                Module1.myshowpreview.ztitlefont = (Font)this.maintitle.Font.Clone();
                this.ParaPaperType();
                Module1.myshowpreview.myIsDGVCellValignmentCenter = this.myIsDGVCellValignmentCenter;
                Module1.myshowpreview.paperkind = this.paperkind;
                Module1.myshowpreview.mypapermargin = this.mypapermarign;
                Module1.myshowpreview.papername = this.papername;
                Module1.myshowpreview.mypaperheight = this.mypaperheight;
                Module1.myshowpreview.mypaperwidth = this.mypaperwidth;
                Module1.myshowpreview.ftitle = this.subtitle.Text;
                this.ftitle = this.subtitle.Text;
                Module1.myshowpreview.ftitlefont = (Font)this.subtitle.Font.Clone();
                if (String.Compare(this.fx.Text, "横向", false) == 0)
                {
                    Module1.myshowpreview.PaperLandscape = true;
                    this.PaperLandscape = true;
                }
                else
                {
                    Module1.myshowpreview.PaperLandscape = false;
                    this.PaperLandscape = false;
                }
                string text = this.dq.Text;
                if (String.Compare(text, "居中对齐", false) == 0)
                {
                    Module1.myshowpreview.bgalignment = StringAlignment.Center;
                    this.bgalignment = StringAlignment.Center;
                }
                else if (String.Compare(text, "左对齐", false) == 0)
                {
                    Module1.myshowpreview.bgalignment = StringAlignment.Near;
                    this.bgalignment = StringAlignment.Near;
                }
                else if (String.Compare(text, "右对齐", false) == 0)
                {
                    Module1.myshowpreview.bgalignment = StringAlignment.Far;
                    this.bgalignment = StringAlignment.Far;
                }
                if (this.kd.Checked)
                {
                    Module1.myshowpreview.zoomtopaperwidth = true;
                    this.zoomtopaperwidth = true;
                }
                else
                {
                    Module1.myshowpreview.zoomtopaperwidth = false;
                    this.zoomtopaperwidth = false;
                }
                if (this.gd.Checked)
                {
                    Module1.myshowpreview.autoresizerowheight = true;
                    this.autoresizerowheight = true;
                }
                else
                {
                    Module1.myshowpreview.autoresizerowheight = false;
                    this.autoresizerowheight = false;
                }
                Module1.myshowpreview.minfontsize = (float)Convert.ToInt32(this.minsize.Text);
                this.minfontsize = (float)Convert.ToInt32(this.minsize.Text);
                if (this.bt.Checked)
                {
                    Module1.myshowpreview.reppagetitle = true;
                    this.reppagetitle = true;
                }
                else
                {
                    Module1.myshowpreview.reppagetitle = false;
                    this.reppagetitle = false;
                }
                if (this.bj.Checked)
                {
                    this.printbackcolor = true;
                    Module1.myshowpreview.printbackcolor = true;
                }
                else
                {
                    this.printbackcolor = false;
                    Module1.myshowpreview.printbackcolor = false;
                }
                string text2 = this.bk.Text;
                if (String.Compare(text2, "表格线", false) == 0)
                {
                    Module1.myshowpreview.myborder = "1111";
                    this.myborder = "1111";
                }
                else if (String.Compare(text2, "仅横线", false) == 0)
                {
                    Module1.myshowpreview.myborder = "0101";
                    this.myborder = "0101";
                }
                else if (String.Compare(text2, "仅竖线", false) == 0)
                {
                    Module1.myshowpreview.myborder = "1010";
                    this.myborder = "1010";
                }
                else if (String.Compare(text2, "无线", false) == 0)
                {
                    Module1.myshowpreview.myborder = "0000";
                    this.myborder = "0000";
                }
                else
                {
                    if (Strings.Len(this.bk.Text) != 4 | !Versioned.IsNumeric(this.bk.Text))
                    {
                        this.myborder = "1111";
                    }
                    else
                    {
                        this.myborder = this.bk.Text;
                    }
                    Module1.myshowpreview.myborder = this.myborder;
                }
                Module1.myshowpreview.linespace = Convert.ToSingle(this.gzjj.Value);
                this.linespace = Convert.ToSingle(this.gzjj.Value);
                if (this.lz.Checked)
                {
                    Module1.myshowpreview.printzero = true;
                    this.printzero = true;
                }
                else
                {
                    Module1.myshowpreview.printzero = false;
                    this.printzero = false;
                }
                if (this.gzwrap.Checked)
                {
                    Module1.myshowpreview.autowrap = true;
                    this.autowrap = true;
                }
                else
                {
                    Module1.myshowpreview.autowrap = false;
                    this.autowrap = false;
                }
                Module1.myshowpreview.mycolumns = Convert.ToInt32(this.ls.Text);
                this.mycolumns = Convert.ToInt32(this.ls.Text);
                Module1.myshowpreview.columnspace = Convert.ToSingle(this.ljj.Value);
                this.columnspace = Convert.ToSingle(this.ljj.Value);
                if (this.zh.Checked)
                {
                    Module1.myshowpreview.lastpagemode = true;
                    this.lastpagemode = true;
                }
                else
                {
                    Module1.myshowpreview.lastpagemode = false;
                    this.lastpagemode = false;
                }
                Module1.myshowpreview.fixedcols = Convert.ToInt32(this.columns.Text);
                this.fixedcols = Convert.ToInt32(this.columns.Text);
                if (String.Compare(Convert.ToString(this.sortcolumn.SelectedItem), "", false) == 0)
                {
                    this.mysortcolumn = "";
                }
                else
                {
                    this.mysortcolumn = this.GetItemName(Convert.ToString(this.sortcolumn.SelectedItem) + "");
                }
                if (String.Compare(Convert.ToString(this.groupcolumn.SelectedItem), "", false) == 0)
                {
                    this.mygroupcolumne = "";
                }
                else
                {
                    this.mygroupcolumne = this.GetItemName(Convert.ToString(this.groupcolumn.SelectedItem) + "");
                }
                if (String.Compare(this.mysortcolumn + "", "", false) != 0)
                {
                    if (this.sorta.Checked)
                    {
                        this.dgvtoprint.Sort(this.dgvtoprint.Columns[this.mysortcolumn], ListSortDirection.Ascending);
                    }
                    else
                    {
                        this.dgvtoprint.Sort(this.dgvtoprint.Columns[this.mysortcolumn], ListSortDirection.Descending);
                    }
                }
                float num = this.myp.ConvertFromMM((float)Conversion.Val(this.cleft.Text), true);
                float num2 = this.myp.ConvertFromMM((float)Conversion.Val(this.cright.Text), true);
                float num3 = this.myp.ConvertFromMM((float)Conversion.Val(this.ctop.Text), false);
                float num4 = this.myp.ConvertFromMM((float)Conversion.Val(this.cbottom.Text), false);
                DataGridViewCellStyle defaultCellStyle = this.dgvtoprint.DefaultCellStyle;
                Padding padding = checked(new Padding((int)Math.Round((double)num), (int)Math.Round((double)num3), (int)Math.Round((double)num2), (int)Math.Round((double)num4)));
                defaultCellStyle.Padding = padding;
                Module1.myshowpreview.dgvtoprint = this.dgvtoprint;
                Module1.myshowpreview.documentname = this.documentname;
                Module1.myshowpreview.pagel = this.mypagel;
                Module1.myshowpreview.pagem = this.mypagem;
                Module1.myshowpreview.pager = this.mypager;
                Module1.myshowpreview.pageleft = this.mypageleft;
                Module1.myshowpreview.pageright = this.mypageright;
                Module1.myshowpreview.pagemiddle = this.mypagemiddle;
                Module1.myshowpreview.tablel = this.mytablel;
                Module1.myshowpreview.tablem = this.mytablem;
                Module1.myshowpreview.tabler = this.mytabler;
                Module1.myshowpreview.tableleft = this.mytableleft;
                Module1.myshowpreview.tablemiddle = this.mytablemiddle;
                Module1.myshowpreview.tableright = this.mytableright;
                Module1.myshowpreview.footerfont = this.myfooterfont;
                Module1.myshowpreview.headerfont = this.myheaderfont;
                Module1.myshowpreview.topfont = this.mytopfont;
                Module1.myshowpreview.bottomfont = this.mybottomfont;
                Module1.myshowpreview.footercolor = this.myfootercolor;
                Module1.myshowpreview.headercolor = this.myheadercolor;
                Module1.myshowpreview.defaultcolor = this.mydefaultcolor;
                Module1.myshowpreview._printcopys = this._printcopys;
                Module1.myshowpreview.myisshowprogress = this.myisshowprogress;
                if (String.Compare(this.syfx.Text, "垂直", false) == 0)
                {
                    this.mywatermarklandscape = false;
                }
                else
                {
                    this.mywatermarklandscape = true;
                }
                if (decimal.Compare(this.sytm.Value, 256m) > 0 | decimal.Compare(this.sytm.Value, 0m) < 0)
                {
                    this.mywatermarkopacity = 128;
                }
                else
                {
                    this.mywatermarkopacity = Convert.ToByte(this.sytm.Value);
                }
                this.mywatermarktext = this.sytext.Text;
                this.mytitletextstyle = this.zys.SelectedIndex;
                this.mysubtitlestyle = this.fys.SelectedIndex;
                if (this.mytitletextstyle < 0 | this.mytitletextstyle > 6)
                {
                    this.mytitletextstyle = 0;
                }
                if (this.mysubtitlestyle < 0 | this.mysubtitlestyle > 6)
                {
                    this.mysubtitlestyle = 0;
                }
                Module1.myshowpreview.mywatermarkcolor = this.mywatermarkcolor;
                Module1.myshowpreview.mywatermarkfont = this.mywatermarkfont;
                Module1.myshowpreview.mywatermarklandscape = this.mywatermarklandscape;
                Module1.myshowpreview.mywatermarkopacity = this.mywatermarkopacity;
                Module1.myshowpreview.mywatermarktext = this.mywatermarktext;
                Module1.myshowpreview.myshapedepth = this.myshapedepth;
                Module1.myshowpreview.mytitletextstyle = this.mytitletextstyle;
                Module1.myshowpreview.mysubtitlestyle = this.mysubtitlestyle;
                this.myrightt = this.rightt.Text;
                this.myrightm = this.rightm.Text;
                this.myrightb = this.rightb.Text;
                Module1.myshowpreview.myrightt = this.myrightt;
                Module1.myshowpreview.myrightm = this.myrightm;
                Module1.myshowpreview.myrightb = this.myrightb;
                Module1.myshowpreview.myrightfont = this.myrightfont;
                Module1.myshowpreview.myrightcolor = this.myrightcolor;
                this.GethzColumns();
                Module1.myshowpreview.myhzcolumns = this.myhzcolumns;
                Module1.myshowpreview.myhzfont = this.myhzfont;
                Module1.myshowpreview.myhzforecolor = this.myhzforecolor;
                Module1.myshowpreview.myhzbackcolor = this.myhzbackcolor;
                Module1.myshowpreview.myheader = this.myheader;
                if (this.sorta.Checked)
                {
                    this.mysorttype = true;
                }
                else
                {
                    this.mysorttype = false;
                }
                if (this.groupnewpage.Checked)
                {
                    this.mygroupnewpage = true;
                }
                else
                {
                    this.mygroupnewpage = false;
                }
                if (this.addrowid.Checked)
                {
                    this.myaddrowid = true;
                }
                else
                {
                    this.myaddrowid = false;
                }
                if (this.addrownew.Checked)
                {
                    this.myaddrownew = true;
                }
                else
                {
                    this.myaddrownew = false;
                }
                Module1.myshowpreview.mygroupcolumne = this.mygroupcolumne;
                Module1.myshowpreview.mygroupnewpage = this.mygroupnewpage;
                Module1.myshowpreview.myaddrowid = this.myaddrowid;
                Module1.myshowpreview.myaddrownew = this.myaddrownew;
                Module1.myshowpreview.myIsImmediatePrintNotPreviewShowPrintDialog = this.myIsImmediatePrintNotPreviewShowPrintDialog;
                Module1.myshowpreview.myIsShowMessageIfPrinterNotSupportPaper = this.myIsShowMessageIfPrinterNotSupportPaper;
                Module1.myshowpreview.myisimmediateprint = this.myisimmediateprint;
                this.Visible = false;
                Module1.myshowpreview.currentprintername = this.currentprintname;
                Module1.myshowpreview.autoformat = this.autoformat;
                Module1.myshowpreview.myisuseAPIprintDialog = this.myisuseAPIprintDialog;
                this.GetAlign();
                Module1.myshowpreview.myTableTopLeftTitleAlign = this.myTableTopLeftTitleAlign;
                Module1.myshowpreview.myTableTopMiddleTitleAlign = this.myTableTopMiddleTitleAlign;
                Module1.myshowpreview.myTableTopRightTitleAlign = this.myTableTopRightTitleAlign;
                Module1.myshowpreview.myTableBottomLeftTitleAlign = this.myTableBottomLeftTitleAlign;
                Module1.myshowpreview.myTableBottomMiddleTitleAlign = this.myTableBottomMiddleTitleAlign;
                Module1.myshowpreview.myTableBottomRightTitleAlign = this.myTableBottomRightTitleAlign;
                Module1.myshowpreview.mySumNumberAlign = this.mySumNumberAlign;
                Module1.myshowpreview.mypagebackgroundimage = this.mypagebackgroundimage;
                this.myisdrawpagefooterline = this.drawfooter.Checked;
                this.myisdrawpageheaderline = this.drawheader.Checked;
                Module1.myshowpreview.myisdrawpagefooterline = this.myisdrawpagefooterline;
                Module1.myshowpreview.myisdrawpageheaderline = this.myisdrawpageheaderline;
                Module1.myshowpreview.myisdrawmargin = this.myisdrawmargin;
                Module1.myshowpreview.myenablesaveasimage = this.myenablesaveasimage;
                Module1.myshowpreview.myenablesaveaspdf = this.myenablesaveaspdf;
                if (this.autoaddrow.Checked)
                {
                    this.myisautoaddemptyrow = true;
                }
                else
                {
                    this.myisautoaddemptyrow = false;
                }
                Module1.myshowpreview.myisautoaddemptyrow = this.myisautoaddemptyrow;
                Module1.myshowpreview.mycaneditprintsettings = this.mycaneditprintsettings;
                if (this.yj.Checked)
                {
                    this.myisdrawtablefootereverypage = true;
                }
                else
                {
                    this.myisdrawtablefootereverypage = false;
                }
                if (this.gwxdoubleline.Checked)
                {
                    this.myisusedoubleline = true;
                }
                else
                {
                    this.myisusedoubleline = false;
                }
                if (this.gwxouterborder.Checked)
                {
                    this.myouterborder = true;
                }
                else
                {
                    this.myouterborder = false;
                }
                this.thedoublelinespace = (float)Conversion.Val(this.gwxdoublinespace.Text);
                this.myouterborderwidth = (float)Conversion.Val(this.gwxouterborderwidth.Text);
                if (this.isdrawzdx.Checked)
                {
                    this.myisdrawZDX = true;
                }
                else
                {
                    this.myisdrawZDX = false;
                }
                this.GetZDXTypeAndLineType();
                this.myZDXposition = Convert.ToSingle(this.zdxposition.Text);
                this.myZDXtext = this.zdxtext.Text;
                Module1.myshowpreview.myisdrawZDX = this.myisdrawZDX;
                Module1.myshowpreview.myZDXfont = this.myZDXfont;
                Module1.myshowpreview.myZDXlinecolor = this.myZDXlinecolor;
                Module1.myshowpreview.myZDXlinestyle = this.myZDXlinestyle;
                Module1.myshowpreview.myZDXposition = this.myZDXposition;
                Module1.myshowpreview.myZDXtext = this.myZDXtext;
                Module1.myshowpreview.myZDXtextcolor = this.myZDXtextcolor;
                Module1.myshowpreview.myZDXtype = (showpreview.TheZDXTYPE)this.myZDXtype;
                Module1.myshowpreview.myisdrawtablefootereverypage = this.myisdrawtablefootereverypage;
                Module1.myshowpreview.myisusedoubleline = this.myisusedoubleline;
                Module1.myshowpreview.thedoublelinespace = this.thedoublelinespace;
                Module1.myshowpreview.myouterborder = this.myouterborder;
                Module1.myshowpreview.myouterbordercolor = this.myouterbordercolor;
                Module1.myshowpreview.myouterborderwidth = this.myouterborderwidth;
                Module1.myshowpreview.myenabledprint = this.myenabledprint;
                Module1.myshowpreview.myrowheight = this.myrowheight;
                this.myreportheaderspace = Convert.ToSingle(this.reportheaderspace.Value);
                this.myreportheadertext = this.reportheadertext.Text;
                Module1.myshowpreview.myreportheaderalignment = this.myreportheaderalignment;
                Module1.myshowpreview.myreportheadercolor = this.myreportheadercolor;
                Module1.myshowpreview.myreportheaderfont = (Font)this.myreportheaderfont.Clone();
                Module1.myshowpreview.myreportheaderspace = this.myreportheaderspace;
                Module1.myshowpreview.myreportheadertext = this.myreportheadertext;
                this.myreportfooterspace = Convert.ToSingle(this.reportfooterspace.Value);
                this.myreportfootertext = this.reportfootertext.Text;
                Module1.myshowpreview.myreportfooteralignment = this.myreportfooteralignment;
                Module1.myshowpreview.myreportfootercolor = this.myreportfootercolor;
                Module1.myshowpreview.myreportfooterfont = (Font)this.myreportfooterfont.Clone();
                Module1.myshowpreview.myreportfooterspace = this.myreportfooterspace;
                Module1.myshowpreview.myreportfootertext = this.myreportfootertext;
                Module1.myshowpreview.needrefresh = true;
                if (Module1.myshowpreview.Visible)
                {
                    Module1.myshowpreview.Show();
                    Module1.myshowpreview.TopMost = true;
                    Module1.myshowpreview.DataGridViewPrint1.InvalidatePreview();
                }
                else
                {
                    try
                    {
                        if (!Module1.myshowpreview.Modal)
                        {
                            Module1.myshowpreview.ShowDialog();
                        }
                        else
                        {
                            Module1.myshowpreview.Visible = true;
                            Module1.myshowpreview.MyRefresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        Module1.myshowpreview.Visible = true;
                        Module1.myshowpreview.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000390 RID: 912 RVA: 0x000256B8 File Offset: 0x000238B8
        private void SetZDXTypeAndLineType()
        {
            switch (this.myZDXlinestyle)
            {
                case DashStyle.Solid:
                    this.zdx_solid.Checked = true;
                    goto IL_65;
                case DashStyle.Dot:
                    this.zdx_dot.Checked = true;
                    goto IL_65;
                case DashStyle.DashDot:
                    this.zdx_dashdot.Checked = true;
                    goto IL_65;
                case DashStyle.DashDotDot:
                    this.zdx_dashdotdot.Checked = true;
                    goto IL_65;
            }
            this.zdx_dash.Checked = true;
        IL_65:
            switch (this.myZDXtype)
            {
                case DataGridViewPrintSet.TheZDXTYPE.TOP:
                    this.zdxtype_top.Checked = true;
                    break;
                case DataGridViewPrintSet.TheZDXTYPE.RIGHT:
                    this.zdxtype_right.Checked = true;
                    break;
                case DataGridViewPrintSet.TheZDXTYPE.BOTTOM:
                    this.zdxtype_bottom.Checked = true;
                    break;
                default:
                    this.zdxtype_left.Checked = true;
                    break;
            }
        }

        // Token: 0x06000391 RID: 913 RVA: 0x0002577C File Offset: 0x0002397C
        private void GetZDXTypeAndLineType()
        {
            if (this.zdx_dashdot.Checked)
            {
                this.myZDXlinestyle = DashStyle.DashDot;
            }
            else if (this.zdx_dashdotdot.Checked)
            {
                this.myZDXlinestyle = DashStyle.DashDotDot;
            }
            else if (this.zdx_dot.Checked)
            {
                this.myZDXlinestyle = DashStyle.Dot;
            }
            else if (this.zdx_solid.Checked)
            {
                this.myZDXlinestyle = DashStyle.Solid;
            }
            else
            {
                this.myZDXlinestyle = DashStyle.Dash;
            }
            if (this.zdxtype_bottom.Checked)
            {
                this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.BOTTOM;
            }
            else if (this.zdxtype_right.Checked)
            {
                this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.RIGHT;
            }
            else if (this.zdxtype_top.Checked)
            {
                this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.TOP;
            }
            else
            {
                this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.LEFT;
            }
        }

        // Token: 0x06000392 RID: 914 RVA: 0x00025834 File Offset: 0x00023A34
        private void GethzColumns()
        {
            this.myhzcolumns = "";
            int num = 0;
            checked
            {
                int num2 = this.hz.Items.Count - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (this.hz.GetItemChecked(i))
                    {
                        if (String.Compare(this.myhzcolumns, "", false) == 0)
                        {
                            this.myhzcolumns = this.GetItemName(Convert.ToString(this.hz.Items[i]));
                        }
                        else
                        {
                            this.myhzcolumns = this.myhzcolumns + ";" + this.GetItemName(Convert.ToString(this.hz.Items[i]));
                        }
                    }
                }
            }
        }

        // Token: 0x06000393 RID: 915 RVA: 0x000258E4 File Offset: 0x00023AE4
        private void ParaPaperType()
        {
            if (String.Compare(Convert.ToString(this.papertype.SelectedItem), "", false) != 0)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                if (String.Compare(this.currentprintname, "", false) != 0 && Module1.IsValidPrinterName(this.currentprintname))
                {
                    printerSettings.PrinterName = this.currentprintname;
                }
                if (String.Compare(Convert.ToString(this.papertype.SelectedItem), "[自定义纸张]", false) == 0)
                {
                    this.paperkind = PaperKind.Custom;
                    this.papername = "[自定义纸张]";
                    this.mypaperwidth = this.myw.Value;
                    this.mypaperheight = this.myh.Value;
                }
                else
                {
                    PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, Convert.ToString(this.papertype.SelectedItem));
                    if (printForm.Kind == PaperKind.Custom)
                    {
                        this.paperkind = PaperKind.Custom;
                        this.papername = printForm.PaperName;
                    }
                    else
                    {
                        this.papername = Convert.ToString(this.papertype.SelectedItem);
                        this.paperkind = printForm.Kind;
                    }
                }
            }
        }

        // Token: 0x06000394 RID: 916 RVA: 0x000259F8 File Offset: 0x00023BF8
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

        // Token: 0x06000395 RID: 917 RVA: 0x00025ABC File Offset: 0x00023CBC
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

        // Token: 0x06000396 RID: 918 RVA: 0x00025B24 File Offset: 0x00023D24
        private void C1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.C1.SelectedIndex >= 0)
            {
                this.curitem = this.GetItemName(Convert.ToString(this.C1.SelectedItem));
                DataGridViewContentAlignment alignment = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Alignment;
                if (alignment != DataGridViewContentAlignment.BottomCenter)
                {
                    if (alignment != DataGridViewContentAlignment.MiddleCenter)
                    {
                        if (alignment != DataGridViewContentAlignment.TopCenter)
                        {
                            if (alignment != DataGridViewContentAlignment.BottomLeft)
                            {
                                if (alignment != DataGridViewContentAlignment.MiddleLeft)
                                {
                                    if (alignment != DataGridViewContentAlignment.TopLeft)
                                    {
                                        if (alignment == DataGridViewContentAlignment.NotSet)
                                        {
                                            this.ldq.Text = "未设置";
                                            goto IL_D5;
                                        }
                                        if (alignment != DataGridViewContentAlignment.BottomRight)
                                        {
                                            if (alignment != DataGridViewContentAlignment.MiddleRight)
                                            {
                                                if (alignment != DataGridViewContentAlignment.TopRight)
                                                {
                                                    goto IL_D5;
                                                }
                                            }
                                        }
                                        this.ldq.Text = "右对齐";
                                        goto IL_D5;
                                    }
                                }
                            }
                            this.ldq.Text = "左对齐";
                            goto IL_D5;
                        }
                    }
                }
                this.ldq.Text = "居中对齐";
            IL_D5:
                switch (this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode)
                {
                    case DataGridViewTriState.NotSet:
                        this.ml.Text = "未设置";
                        break;
                    case DataGridViewTriState.True:
                        this.ml.Text = "允许";
                        break;
                    case DataGridViewTriState.False:
                        this.ml.Text = "不允许";
                        break;
                }
                if (this.dgvtoprint.Columns[this.curitem].HasDefaultCellStyle)
                {
                    try
                    {
                        this.columnfont.Font = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font;
                        this.columnfont.ForeColor = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor;
                        this.columnfont.BackColor = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                try
                {
                    this.NumericUpDown1.Value = new decimal(this.myp.ConvertToMM((float)this.dgvtoprint.Columns[this.curitem].Width, true));
                }
                catch (Exception ex2)
                {
                }
            }
        }

        // Token: 0x06000397 RID: 919 RVA: 0x00025D84 File Offset: 0x00023F84
        private void dq_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                string text = this.ldq.Text;
                DataGridViewContentAlignment alignment = DataGridViewContentAlignment.NotSet;
                if (String.Compare(text, "未设置", false) == 0)
                {
                    alignment = DataGridViewContentAlignment.NotSet;
                }
                else if (String.Compare(text, "居中对齐", false) == 0)
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

        // Token: 0x06000398 RID: 920 RVA: 0x00025E24 File Offset: 0x00024024
        private void Button10_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.fontshow.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fontshow.Font = this.FontDialog1.Font;
                this.dgvtoprint.DefaultCellStyle.Font = this.FontDialog1.Font;
            }
        }

        // Token: 0x06000399 RID: 921 RVA: 0x00025E88 File Offset: 0x00024088
        private void Button11_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.headerfont.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.headerfont.Font = this.FontDialog1.Font;
                this.dgvtoprint.ColumnHeadersDefaultCellStyle.Font = this.FontDialog1.Font;
            }
        }

        // Token: 0x0600039A RID: 922 RVA: 0x00025EEC File Offset: 0x000240EC
        private void Button9_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                if (this.dgvtoprint.Columns[this.curitem].HasDefaultCellStyle)
                {
                    try
                    {
                        this.FontDialog1.Font = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (this.FontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.columnfont.Font = this.FontDialog1.Font;
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font = this.FontDialog1.Font;
                }
            }
        }

        // Token: 0x0600039B RID: 923 RVA: 0x00025FCC File Offset: 0x000241CC
        private void ml_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                string text = this.ml.Text;
                if (String.Compare(text, "未设置", false) == 0)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
                }
                else if (String.Compare(text, "允许", false) == 0)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else if (String.Compare(text, "不允许", false) == 0)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                }
            }
        }

        // Token: 0x0600039C RID: 924 RVA: 0x00026094 File Offset: 0x00024294
        private void Button12_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                if (this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor.IsEmpty)
                {
                    this.ColorDialog1.Color = Color.Black;
                }
                else
                {
                    this.ColorDialog1.Color = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor;
                }
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor = this.ColorDialog1.Color;
                    this.columnfont.ForeColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x0600039D RID: 925 RVA: 0x00026170 File Offset: 0x00024370
        private void Button13_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.curitem, "", false) != 0)
            {
                if (this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor.IsEmpty)
                {
                    this.ColorDialog1.Color = Color.Transparent;
                }
                else
                {
                    this.ColorDialog1.Color = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor;
                }
                if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor = this.ColorDialog1.Color;
                    this.columnfont.BackColor = this.ColorDialog1.Color;
                }
            }
        }

        // Token: 0x0600039E RID: 926 RVA: 0x0002624C File Offset: 0x0002444C
        private void Button17_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.dgvtoprint.ColumnHeadersDefaultCellStyle.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.ColumnHeadersDefaultCellStyle.ForeColor = this.ColorDialog1.Color;
                this.headerfont.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x0600039F RID: 927 RVA: 0x000262B4 File Offset: 0x000244B4
        private void Button16_Click(object sender, EventArgs e)
        {
            if (this.dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor.IsEmpty)
            {
                this.ColorDialog1.Color = Color.Transparent;
            }
            else
            {
                this.ColorDialog1.Color = this.dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor;
            }
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor = this.ColorDialog1.Color;
                this.headerfont.BackColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003A0 RID: 928 RVA: 0x00026348 File Offset: 0x00024548
        private void Button14_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.dgvtoprint.DefaultCellStyle.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.DefaultCellStyle.ForeColor = this.ColorDialog1.Color;
                this.fontshow.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003A1 RID: 929 RVA: 0x000263B0 File Offset: 0x000245B0
        private void Button15_Click(object sender, EventArgs e)
        {
            if (this.dgvtoprint.DefaultCellStyle.BackColor.IsEmpty)
            {
                this.ColorDialog1.Color = Color.Transparent;
            }
            else
            {
                this.ColorDialog1.Color = this.dgvtoprint.DefaultCellStyle.BackColor;
            }
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.DefaultCellStyle.BackColor = this.ColorDialog1.Color;
                this.fontshow.BackColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003A2 RID: 930 RVA: 0x00026444 File Offset: 0x00024644
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

        // Token: 0x060003A3 RID: 931 RVA: 0x000265C4 File Offset: 0x000247C4
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

        // Token: 0x060003A4 RID: 932 RVA: 0x00026758 File Offset: 0x00024958
        private void Button5_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.mytopfont;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.mytopfont = this.FontDialog1.Font;
                this.tablel.Font = this.mytopfont;
                this.tablem.Font = this.mytopfont;
                this.tabler.Font = this.mytopfont;
            }
        }

        // Token: 0x060003A5 RID: 933 RVA: 0x000267C8 File Offset: 0x000249C8
        private void Button6_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.mybottomfont;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.mybottomfont = this.FontDialog1.Font;
                this.tableleft.Font = this.mybottomfont;
                this.tablemiddle.Font = this.mybottomfont;
                this.tableright.Font = this.mybottomfont;
            }
        }

        // Token: 0x060003A6 RID: 934 RVA: 0x00026838 File Offset: 0x00024A38
        private void Button8_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.myheaderfont;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myheaderfont = this.FontDialog1.Font;
                this.pagel.Font = this.myheaderfont;
                this.pager.Font = this.myheaderfont;
                this.pagem.Font = this.myheaderfont;
            }
        }

        // Token: 0x060003A7 RID: 935 RVA: 0x000268A8 File Offset: 0x00024AA8
        private void Button7_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.myfooterfont;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myfooterfont = this.FontDialog1.Font;
                this.pageleft.Font = this.myfooterfont;
                this.pageright.Font = this.myfooterfont;
                this.pagemiddle.Font = this.myfooterfont;
            }
        }

        // Token: 0x060003A8 RID: 936 RVA: 0x00026918 File Offset: 0x00024B18
        private void Button21_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myheadercolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myheadercolor = this.ColorDialog1.Color;
                this.pagel.ForeColor = this.myheadercolor;
                this.pagem.ForeColor = this.myheadercolor;
                this.pager.ForeColor = this.myheadercolor;
            }
        }

        // Token: 0x060003A9 RID: 937 RVA: 0x00026988 File Offset: 0x00024B88
        private void Button20_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myfootercolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myfootercolor = this.ColorDialog1.Color;
                this.pageleft.ForeColor = this.myfootercolor;
                this.pagemiddle.ForeColor = this.myfootercolor;
                this.pageright.ForeColor = this.myfootercolor;
            }
        }

        // Token: 0x060003AA RID: 938 RVA: 0x000269F8 File Offset: 0x00024BF8
        private void Button22_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.mydefaultcolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.mydefaultcolor = this.ColorDialog1.Color;
                this.maintitle.ForeColor = this.mydefaultcolor;
                this.subtitle.ForeColor = this.mydefaultcolor;
                this.tablel.ForeColor = this.mydefaultcolor;
                this.tablem.ForeColor = this.mydefaultcolor;
                this.tabler.ForeColor = this.mydefaultcolor;
                this.tableleft.ForeColor = this.mydefaultcolor;
                this.tableright.ForeColor = this.mydefaultcolor;
                this.tablemiddle.ForeColor = this.mydefaultcolor;
            }
        }

        // Token: 0x060003AB RID: 939 RVA: 0x00026AC0 File Offset: 0x00024CC0
        private void Button23_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.dgvtoprint.GridColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.GridColor = this.ColorDialog1.Color;
                this.Button23.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003AC RID: 940 RVA: 0x00026B20 File Offset: 0x00024D20
        private void Button24_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.schemefilename, "", false) == 0 & String.Compare(this.SaveFileDialog1.FileName, "", false) == 0)
            {
                this.SaveFileDialog1.FileName = this.dgvtoprint.Name;
            }
            else if (String.Compare(this.SaveFileDialog1.FileName, "", false) == 0)
            {
                try
                {
                    this.SaveFileDialog1.InitialDirectory = MyProject.Computer.FileSystem.GetParentPath(this.schemefilename);
                    this.SaveFileDialog1.FileName = MyProject.Computer.FileSystem.GetName(this.schemefilename);
                }
                catch (Exception ex)
                {
                    this.SaveFileDialog1.FileName = this.schemefilename;
                }
            }
            if (String.Compare(this.SaveFileDialog1.InitialDirectory, "", false) == 0)
            {
                this.SaveFileDialog1.InitialDirectory = Application.StartupPath;
            }
            if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (MyProject.Computer.FileSystem.FileExists(this.SaveFileDialog1.FileName))
                {
                    MyProject.Computer.FileSystem.DeleteFile(this.SaveFileDialog1.FileName);
                }
                this.GetAlign();
                this.SaveFa(this.SaveFileDialog1.FileName, this.CheckBox1.Checked);
                Interaction.MsgBox("打印方案保存成功", MsgBoxStyle.OkOnly, "提示信息");
            }
        }

        // Token: 0x060003AD RID: 941 RVA: 0x00026CA0 File Offset: 0x00024EA0
        private void SaveFa(string myfile, bool issaveDGVsetting)
        {
            string section = "页面设置";
            this.ParaPaperType();
            Module1.WriteINI(section, "新页[0-1]", "0", myfile);
            Module1.WriteINI(section, "创建方案[0-1]", "0", myfile);
            Module1.WriteINI(section, "纸张", Convert.ToString((int)this.paperkind), myfile);
            if (this.paperkind <= PaperKind.Custom)
            {
                if (String.Compare(this.papername, "[自定义纸张]", false) == 0)
                {
                    Module1.WriteINI(section, "纸张名称", "", myfile);
                    Module1.WriteINI(section, "纸张宽度", Convert.ToString(this.mypaperwidth), myfile);
                    Module1.WriteINI(section, "纸张高度", Convert.ToString(this.mypaperheight), myfile);
                }
                else
                {
                    PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.papername);
                    if (printForm != null)
                    {
                        Module1.WriteINI(section, "纸张名称", this.papername, myfile);
                        Module1.WriteINI(section, "纸张宽度", Convert.ToString((double)printForm.Width * 2.54 / 10.0), myfile);
                        Module1.WriteINI(section, "纸张高度", Convert.ToString((double)printForm.Height * 2.54 / 10.0), myfile);
                    }
                    else
                    {
                        Module1.WriteINI(section, "纸张名称", "", myfile);
                        Module1.WriteINI(section, "纸张宽度", "0", myfile);
                        Module1.WriteINI(section, "纸张高度", "0", myfile);
                    }
                }
            }
            else
            {
                PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.paperkind);
                if (printForm != null)
                {
                    Module1.WriteINI(section, "纸张名称", printForm.PaperName, myfile);
                    Module1.WriteINI(section, "纸张宽度", Convert.ToString((double)printForm.Width * 2.54 / 10.0), myfile);
                    Module1.WriteINI(section, "纸张高度", Convert.ToString((double)printForm.Height * 2.54 / 10.0), myfile);
                }
                else
                {
                    Module1.WriteINI(section, "纸张名称", "", myfile);
                    Module1.WriteINI(section, "纸张宽度", "0", myfile);
                    Module1.WriteINI(section, "纸张高度", "0", myfile);
                }
            }
            Module1.WriteINI(section, "方向", this.fx.Text, myfile);
            Module1.WriteINI(section, "上边距", this.pagemargint.Text, myfile);
            Module1.WriteINI(section, "下边距", this.pagemarginb.Text, myfile);
            Module1.WriteINI(section, "左边距", this.pagemarginl.Text, myfile);
            Module1.WriteINI(section, "右边距", this.pagemarginr.Text, myfile);
            section = "水印设置";
            Module1.WriteINI(section, "内容", this.sytext.Text, myfile);
            Module1.WriteINI(section, "方向", this.syfx.Text, myfile);
            Module1.WriteINI(section, "透明度", Convert.ToString(this.sytm.Value), myfile);
            Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(this.sytext.ForeColor), myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.sytext.Font), myfile);
            section = "装订线";
            this.GetZDXTypeAndLineType();
            Module1.WriteINI(section, "打印装订线[0-1]", Convert.ToString(Interaction.IIf(this.isdrawzdx.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "装订类型[0-3]", Convert.ToString((int)this.myZDXtype), myfile);
            Module1.WriteINI(section, "装订线边距(1/100厘米)", this.zdxposition.Text, myfile);
            Module1.WriteINI(section, "装订线字体", Module1.ConvertFontToString(this.myZDXfont), myfile);
            Module1.WriteINI(section, "装订线文字", this.zdxtext.Text, myfile);
            Module1.WriteINI(section, "装订线文字颜色", Module1.ConvertColorToString(this.myZDXtextcolor), myfile);
            Module1.WriteINI(section, "装订线线型[0-4]", Convert.ToString((int)this.myZDXlinestyle), myfile);
            Module1.WriteINI(section, "装订线颜色", Module1.ConvertColorToString(this.myZDXlinecolor), myfile);
            section = "表格打印格式";
            Module1.WriteINI(section, "表格打印样式[1-4]", Convert.ToString(this.printtype), myfile);
            Module1.WriteINI(section, "表格对齐", this.dq.Text, myfile);
            Module1.WriteINI(section, "表格边框", this.bk.Text, myfile);
            Module1.WriteINI(section, "适合纸张宽度[0-1]", Convert.ToString(Interaction.IIf(this.kd.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "自动调整行高[0-1]", Convert.ToString(Interaction.IIf(this.gd.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "最小字号", this.minsize.Text, myfile);
            Module1.WriteINI(section, "标题行重复打印[0-1]", Convert.ToString(Interaction.IIf(this.bt.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "打印表格背景颜色[0-1]", Convert.ToString(Interaction.IIf(this.bj.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "自动调整行高与列宽[0-1]", Convert.ToString(Interaction.IIf(this.gsf.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "工资条间距", Convert.ToString(this.gzjj.Value), myfile);
            Module1.WriteINI(section, "工资条打印零值[0-1]", Convert.ToString(Interaction.IIf(this.lz.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "工资条自动换行打印[0-1]", Convert.ToString(Interaction.IIf(this.gzwrap.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "多栏打印的栏数", this.ls.Text, myfile);
            Module1.WriteINI(section, "多栏打印的栏间距", this.ljj.Text, myfile);
            Module1.WriteINI(section, "多栏打印最后一页风格[0-1]", Convert.ToString(Interaction.IIf(this.zh.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "跨页打印的固定列数", this.columns.Text, myfile);
            Module1.WriteINI(section, "表格线颜色", Module1.ConvertColorToString(this.dgvtoprint.GridColor), myfile);
            Module1.WriteINI(section, "补白打印[0-1]", Convert.ToString(Interaction.IIf(this.autoaddrow.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "表格页脚每页重复打印[0-1]", Convert.ToString(Interaction.IIf(this.yj.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "双表格线[0-1]", Convert.ToString(Interaction.IIf(this.gwxdoubleline.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "双表格线间距(1/100厘米)", this.gwxdoublinespace.Text, myfile);
            Module1.WriteINI(section, "表格外边框[0-1]", Convert.ToString(Interaction.IIf(this.gwxouterborder.Checked, "1", "0")), myfile);
            Module1.WriteINI(section, "表格外边框线宽(1/100厘米)", this.gwxouterborderwidth.Text, myfile);
            Module1.WriteINI(section, "表格外边框颜色", Module1.ConvertColorToString(this.myouterbordercolor), myfile);
            section = "单元格默认边距";
            Module1.WriteINI(section, "左边距(毫米)", this.cleft.Text, myfile);
            Module1.WriteINI(section, "右边距(毫米)", this.cright.Text, myfile);
            Module1.WriteINI(section, "上边距(毫米)", this.ctop.Text, myfile);
            Module1.WriteINI(section, "下边距(毫米)", this.cbottom.Text, myfile);
            section = "打印标题设置";
            Module1.WriteINI(section, "主标题", this.maintitle.Text, myfile);
            Module1.WriteINI(section, "主标题字体", Module1.ConvertFontToString(this.maintitle.Font), myfile);
            Module1.WriteINI(section, "主标题前景颜色", Module1.ConvertColorToString(this.maintitle.ForeColor), myfile);
            Module1.WriteINI(section, "主标题文字风格[0-6]", Convert.ToString(this.zys.SelectedIndex), myfile);
            Module1.WriteINI(section, "辅标题", this.subtitle.Text, myfile);
            Module1.WriteINI(section, "辅标题字体", Module1.ConvertFontToString(this.subtitle.Font), myfile);
            Module1.WriteINI(section, "辅标题文字风格[0-6]", Convert.ToString(this.fys.SelectedIndex), myfile);
            Module1.WriteINI(section, "标题特效时的深度", Convert.ToString(this.myshapedepth), myfile);
            section = "表格页眉";
            Module1.WriteINI(section, "左边", this.tablel.Text, myfile);
            Module1.WriteINI(section, "左边对齐[0-2]", Convert.ToString((int)this.myTableTopLeftTitleAlign), myfile);
            Module1.WriteINI(section, "中间", this.tablem.Text, myfile);
            Module1.WriteINI(section, "中间对齐[0-2]", Convert.ToString((int)this.myTableTopMiddleTitleAlign), myfile);
            Module1.WriteINI(section, "右边", this.tabler.Text, myfile);
            Module1.WriteINI(section, "右边对齐[0-2]", Convert.ToString((int)this.myTableTopRightTitleAlign), myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.tablel.Font), myfile);
            Module1.WriteINI(section, "打印页眉横线[0-1]", Convert.ToString(Interaction.IIf(this.drawheader.Checked, "1", "0")), myfile);
            section = "表格页脚";
            Module1.WriteINI(section, "左边", this.tableleft.Text, myfile);
            Module1.WriteINI(section, "左边对齐[0-2]", Convert.ToString((int)this.myTableBottomLeftTitleAlign), myfile);
            Module1.WriteINI(section, "中间", this.tablemiddle.Text, myfile);
            Module1.WriteINI(section, "中间对齐[0-2]", Convert.ToString((int)this.myTableBottomMiddleTitleAlign), myfile);
            Module1.WriteINI(section, "右边", this.tableright.Text, myfile);
            Module1.WriteINI(section, "右边对齐[0-2]", Convert.ToString((int)this.myTableBottomRightTitleAlign), myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.tableleft.Font), myfile);
            Module1.WriteINI(section, "打印页脚横线[0-1]", Convert.ToString(Interaction.IIf(this.drawfooter.Checked, "1", "0")), myfile);
            section = "页面页眉";
            Module1.WriteINI(section, "左边", this.pagel.Text, myfile);
            Module1.WriteINI(section, "中间", this.pagem.Text, myfile);
            Module1.WriteINI(section, "右边", this.pager.Text, myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.pagel.Font), myfile);
            Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(this.pagel.ForeColor), myfile);
            section = "页面页脚";
            Module1.WriteINI(section, "左边", this.pageleft.Text, myfile);
            Module1.WriteINI(section, "中间", this.pagemiddle.Text, myfile);
            Module1.WriteINI(section, "右边", this.pageright.Text, myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.pageleft.Font), myfile);
            Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(this.pageleft.ForeColor), myfile);
            section = "页面右边";
            Module1.WriteINI(section, "上边", this.rightt.Text, myfile);
            Module1.WriteINI(section, "中间", this.rightm.Text, myfile);
            Module1.WriteINI(section, "下边", this.rightb.Text, myfile);
            Module1.WriteINI(section, "字体", Module1.ConvertFontToString(this.rightt.Font), myfile);
            Module1.WriteINI(section, "前景颜色", Module1.ConvertColorToString(this.rightt.ForeColor), myfile);
            checked
            {
                if (issaveDGVsetting)
                {
                    section = "表格默认设置";
                    Module1.WriteINI(section, "标题字段名默认字体", Module1.ConvertFontToString(this.headerfont.Font), myfile);
                    Module1.WriteINI(section, "标题字段名认前景颜色", Module1.ConvertColorToString(this.headerfont.ForeColor), myfile);
                    Module1.WriteINI(section, "标题字段名默认背景颜色", Module1.ConvertColorToString(this.headerfont.BackColor), myfile);
                    Module1.WriteINI(section, "单元格默认字体", Module1.ConvertFontToString(this.fontshow.Font), myfile);
                    Module1.WriteINI(section, "单元格默认前景颜色", Module1.ConvertColorToString(this.fontshow.ForeColor), myfile);
                    Module1.WriteINI(section, "单元格默认背景颜色", Module1.ConvertColorToString(this.fontshow.BackColor), myfile);
                    Module1.WriteINI(section, "表格总列数", Convert.ToString(this.dgvtoprint.ColumnCount), myfile);
                    Module1.WriteINI(section, "奇数行默认前景颜色", Module1.ConvertColorToString(this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor), myfile);
                    Module1.WriteINI(section, "奇数行默认背景颜色", Module1.ConvertColorToString(this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor), myfile);
                    Module1.WriteINI(section, "默认行高[毫米]", Convert.ToString(this.rowheight.Value), myfile);
                    section = "分组汇总排序设置";
                    this.GethzColumns();
                    Module1.WriteINI(section, "要汇总的列", this.myhzcolumns, myfile);
                    Module1.WriteINI(section, "汇总行字体", Module1.ConvertFontToString(this.hzfontshow.Font), myfile);
                    Module1.WriteINI(section, "汇总行前景颜色", Module1.ConvertColorToString(this.hzfontshow.ForeColor), myfile);
                    Module1.WriteINI(section, "汇总行背景颜色", Module1.ConvertColorToString(this.hzfontshow.BackColor), myfile);
                    Module1.WriteINI(section, "汇总行数字对齐方式[0-2]", Convert.ToString((int)this.mySumNumberAlign), myfile);
                    string itemName = this.GetItemName(Convert.ToString(this.sortcolumn.SelectedItem) + "");
                    string itemName2 = this.GetItemName(Convert.ToString(this.groupcolumn.SelectedItem) + "");
                    Module1.WriteINI(section, "要排序的列", itemName, myfile);
                    Module1.WriteINI(section, "升序排序", Convert.ToString(Interaction.IIf(this.sorta.Checked, "1", "0")), myfile);
                    Module1.WriteINI(section, "要分组列", itemName2, myfile);
                    Module1.WriteINI(section, "每组换新页打印", Convert.ToString(Interaction.IIf(this.groupnewpage.Checked, "1", "0")), myfile);
                    Module1.WriteINI(section, "第一列前添加行号", Convert.ToString(Interaction.IIf(this.addrowid.Checked, "1", "0")), myfile);
                    Module1.WriteINI(section, "每组行号重新编号", Convert.ToString(Interaction.IIf(this.addrownew.Checked, "1", "0")), myfile);
                    string lpDefault = "";
                    int num = 0;
                    int num2 = this.C1.Items.Count - 1;
                    int i = num;
                    while (i <= num2)
                    {
                        section = "第" + Convert.ToString(i + 1) + "列";
                        string text = Convert.ToString(this.C1.Items[i]);
                        string itemName3 = this.GetItemName(text);
                        Module1.WriteINI(section, "名称", itemName3, myfile);
                        Module1.WriteINI(section, "显示的文本", text, myfile);
                        Module1.WriteINI(section, "是否打印[0-1]", this.C1.GetItemChecked(i) ? "1" : "0", myfile);
                        Module1.WriteINI(section, "默认字体", Module1.ConvertFontToString(this.dgvtoprint.Columns[itemName3].DefaultCellStyle.Font), myfile);
                        Module1.WriteINI(section, "默认前景色", Module1.ConvertColorToString(this.dgvtoprint.Columns[itemName3].DefaultCellStyle.ForeColor), myfile);
                        Module1.WriteINI(section, "默认背景色", Module1.ConvertColorToString(this.dgvtoprint.Columns[itemName3].DefaultCellStyle.BackColor), myfile);
                        DataGridViewContentAlignment alignment = this.dgvtoprint.Columns[itemName3].DefaultCellStyle.Alignment;
                        if (alignment == DataGridViewContentAlignment.BottomCenter)
                        {
                            goto IL_10FE;
                        }
                        if (alignment == DataGridViewContentAlignment.MiddleCenter)
                        {
                            goto IL_10FE;
                        }
                        if (alignment == DataGridViewContentAlignment.TopCenter)
                        {
                            goto IL_10FE;
                        }
                        if (alignment != DataGridViewContentAlignment.BottomLeft)
                        {
                            if (alignment != DataGridViewContentAlignment.MiddleLeft)
                            {
                                if (alignment != DataGridViewContentAlignment.TopLeft)
                                {
                                    if (alignment == DataGridViewContentAlignment.NotSet)
                                    {
                                        lpDefault = "未设置";
                                        goto IL_1104;
                                    }
                                    if (alignment != DataGridViewContentAlignment.BottomRight)
                                    {
                                        if (alignment != DataGridViewContentAlignment.MiddleRight)
                                        {
                                            if (alignment != DataGridViewContentAlignment.TopRight)
                                            {
                                                goto IL_1104;
                                            }
                                        }
                                    }
                                    lpDefault = "右对齐";
                                    goto IL_1104;
                                }
                            }
                        }
                        lpDefault = "左对齐";
                    IL_1104:
                        Module1.WriteINI(section, "文本对齐方式", lpDefault, myfile);
                        switch (this.dgvtoprint.Columns[itemName3].DefaultCellStyle.WrapMode)
                        {
                            case DataGridViewTriState.NotSet:
                                lpDefault = "未设置";
                                break;
                            case DataGridViewTriState.True:
                                lpDefault = "允许";
                                break;
                            case DataGridViewTriState.False:
                                lpDefault = "不允许";
                                break;
                        }
                        Module1.WriteINI(section, "文本允许换行", lpDefault, myfile);
                        lpDefault = Convert.ToString(this.ConvFromDisplayToMM((float)this.dgvtoprint.Columns[itemName3].Width));
                        Module1.WriteINI(section, "列宽(毫米)", lpDefault, myfile);
                        i++;
                        continue;
                    IL_10FE:
                        lpDefault = "居中对齐";
                        goto IL_1104;
                    }
                }
            }
        }

        // Token: 0x060003AE RID: 942 RVA: 0x00027E54 File Offset: 0x00026054
        private bool RestoreFa(string myfile)
        {
            checked
            {
                bool result;
                try
                {
                    string section = "页面设置";
                    string text = Module1.GetINI(section, "纸张", "0", myfile);
                    this.paperkind = (PaperKind)Convert.ToInt32(text);
                    if (this.paperkind <= PaperKind.Custom | definepaper.GetPrintForm(this.currentprintname, this.paperkind.ToString()) == null)
                    {
                        decimal num = 0;
                        decimal num2 = 0;
                        try
                        {
                            text = Module1.GetINI(section, "纸张名称", "", myfile);
                            this.papername = text.Trim();
                            text = Module1.GetINI(section, "纸张宽度", "0", myfile);
                            num = Convert.ToDecimal(text);
                            text = Module1.GetINI(section, "纸张高度", "0", myfile);
                            num2 = Convert.ToDecimal(text);
                            this.mypaperwidth = num;
                            this.mypaperheight = num2;
                            if (String.Compare(this.papername, "", false) != 0 & String.Compare(this.papername, "[自定义纸张]", false) != 0)
                            {
                                PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.papername);
                                if (printForm != null)
                                {
                                    if (!(decimal.Compare(this.mypaperheight, 0m) <= 0 | decimal.Compare(this.mypaperwidth, 0m) <= 0) && (Math.Abs(printForm.Width - (int)Math.Round(Convert.ToDouble(decimal.Multiply(num, 10m)) / 2.54)) > 1 | Math.Abs(printForm.Height - (int)Math.Round(Convert.ToDouble(decimal.Multiply(num2, 10m)) / 2.54)) > 1))
                                    {
                                        definepaper.SetPrintForm(this.currentprintname, this.papername, Convert.ToSingle(num), Convert.ToSingle(num2));
                                    }
                                }
                                else
                                {
                                    definepaper.SetPrintForm(this.currentprintname, this.papername, Convert.ToSingle(num), Convert.ToSingle(num2));
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        if (String.Compare(this.papername, "[自定义纸张]", false) != 0)
                        {
                            PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.papername);
                            if (printForm != null)
                            {
                                if (!(decimal.Compare(this.mypaperheight, 0m) <= 0 | decimal.Compare(this.mypaperwidth, 0m) <= 0) && (Math.Abs(printForm.Width - (int)Math.Round(Convert.ToDouble(decimal.Multiply(num, 10m)) / 2.54)) > 1 | Math.Abs(printForm.Height - (int)Math.Round(Convert.ToDouble(decimal.Multiply(num2, 10m)) / 2.54)) > 1))
                                {
                                    this.papername = "[自定义纸张]";
                                }
                            }
                            else
                            {
                                this.papername = "[自定义纸张]";
                            }
                        }
                    }
                    this.SetPrintCS();
                    text = Module1.GetINI(section, "方向", "纵向", myfile);
                    if (String.Compare(text, "横向", false) == 0)
                    {
                        this.PaperLandscape = true;
                        this.fx.Text = "横向";
                    }
                    else
                    {
                        this.PaperLandscape = false;
                        this.fx.Text = "纵向";
                    }
                    text = Module1.GetINI(section, "上边距", "25.4", myfile);
                    this.mypapermarign.Top = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "下边距", "25.4", myfile);
                    this.mypapermarign.Bottom = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "左边距", "25.4", myfile);
                    this.mypapermarign.Left = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "右边距", "25.4", myfile);
                    this.mypapermarign.Right = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    this.pagemarginl.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Left / 10.0, 3));
                    this.pagemarginr.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Right / 10.0, 3));
                    this.pagemargint.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Top / 10.0, 3));
                    this.pagemarginb.Text = Convert.ToString(Math.Round((double)this.mypapermarign.Bottom / 10.0, 3));
                    section = "水印设置";
                    text = Module1.GetINI(section, "内容", "", myfile);
                    this.mywatermarktext = text;
                    this.sytext.Text = this.mywatermarktext;
                    text = Module1.GetINI(section, "方向", "水平", myfile);
                    if (String.Compare(text, "垂直", false) == 0)
                    {
                        this.mywatermarklandscape = false;
                    }
                    else
                    {
                        this.mywatermarklandscape = true;
                    }
                    if (this.mywatermarklandscape)
                    {
                        this.syfx.Text = "水平";
                    }
                    else
                    {
                        this.syfx.Text = "垂直";
                    }
                    text = Module1.GetINI(section, "透明度", "128", myfile);
                    this.mywatermarkopacity = Convert.ToByte(text);
                    this.sytm.Value = new decimal((int)this.mywatermarkopacity);
                    text = Module1.GetINI(section, "前景颜色", "", myfile);
                    this.mywatermarkcolor = Module1.ConvertStringToColor(text);
                    this.sytext.ForeColor = this.mywatermarkcolor;
                    text = Module1.GetINI(section, "字体", "", myfile);
                    Font font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.mywatermarkfont = font;
                    }
                    this.sytext.Font = this.mywatermarkfont;
                    section = "装订线";
                    this.GetZDXTypeAndLineType();
                    text = Module1.GetINI(section, "打印装订线[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.myisdrawZDX = true;
                        this.isdrawzdx.Checked = true;
                    }
                    else
                    {
                        this.myisdrawZDX = false;
                        this.isdrawzdx.Checked = false;
                    }
                    text = Module1.GetINI(section, "装订类型[0-3]", "0", myfile);
                    string left = Strings.Trim(text);
                    if (String.Compare(left, "1", false) == 0)
                    {
                        this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.TOP;
                    }
                    else if (String.Compare(left, "2", false) == 0)
                    {
                        this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.RIGHT;
                    }
                    else if (String.Compare(left, "3", false) == 0)
                    {
                        this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.BOTTOM;
                    }
                    else
                    {
                        this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.LEFT;
                    }
                    text = Module1.GetINI(section, "装订线边距(1/100厘米)", "0", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "0";
                    }
                    this.myZDXposition = Convert.ToSingle(text);
                    this.zdxposition.Text = text;
                    text = Module1.GetINI(section, "装订线字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.myZDXfont = font;
                        this.zdxtext.Font = font;
                    }
                    text = Module1.GetINI(section, "装订线文字", "", myfile);
                    this.myZDXtext = text;
                    this.zdxtext.Text = text;
                    text = Module1.GetINI(section, "装订线文字颜色", "", myfile);
                    this.myZDXtextcolor = Module1.ConvertStringToColor(text);
                    this.zdxtext.ForeColor = this.myZDXtextcolor;
                    text = Module1.GetINI(section, "装订线线型[0-4]", "1", myfile);
                    string left2 = Strings.Trim(text);
                    if (String.Compare(left2, "0", false) == 0)
                    {
                        this.myZDXlinestyle = DashStyle.Solid;
                    }
                    else if (String.Compare(left2, "2", false) == 0)
                    {
                        this.myZDXlinestyle = DashStyle.Dot;
                    }
                    else if (String.Compare(left2, "3", false) == 0)
                    {
                        this.myZDXlinestyle = DashStyle.DashDot;
                    }
                    else if (String.Compare(left2, "4", false) == 0)
                    {
                        this.myZDXlinestyle = DashStyle.DashDotDot;
                    }
                    else
                    {
                        this.myZDXlinestyle = DashStyle.Dash;
                    }
                    text = Module1.GetINI(section, "装订线颜色", "", myfile);
                    this.myZDXlinecolor = Module1.ConvertStringToColor(text);
                    this.zdxlinecolor.ForeColor = this.myZDXlinecolor;
                    this.SetZDXTypeAndLineType();
                    section = "表格打印格式";
                    text = Module1.GetINI(section, "表格打印样式[1-4]", "1", myfile);
                    this.printtype = Convert.ToInt32(text);
                    if (this.printtype > 4 | this.printtype < 1)
                    {
                        this.printtype = 1;
                    }
                    switch (this.printtype)
                    {
                        case 1:
                            this.R1.Checked = true;
                            break;
                        case 2:
                            this.R2.Checked = true;
                            break;
                        case 3:
                            this.R3.Checked = true;
                            break;
                        case 4:
                            this.R4.Checked = true;
                            break;
                        default:
                            this.R1.Checked = true;
                            break;
                    }
                    this.SetTS();
                    text = Module1.GetINI(section, "表格对齐", "居中对齐", myfile);
                    string left3 = text;
                    if (String.Compare(left3, "居中对齐", false) == 0)
                    {
                        this.bgalignment = StringAlignment.Center;
                    }
                    else if (String.Compare(left3, "左对齐", false) == 0)
                    {
                        this.bgalignment = StringAlignment.Near;
                    }
                    else if (String.Compare(left3, "右对齐", false) == 0)
                    {
                        this.bgalignment = StringAlignment.Far;
                    }
                    else
                    {
                        this.bgalignment = StringAlignment.Center;
                    }
                    switch (this.bgalignment)
                    {
                        case StringAlignment.Near:
                            this.dq.Text = "左对齐";
                            break;
                        case StringAlignment.Center:
                            this.dq.Text = "居中对齐";
                            break;
                        case StringAlignment.Far:
                            this.dq.Text = "右对齐";
                            break;
                    }
                    text = Module1.GetINI(section, "表格边框", "表格线", myfile);
                    string left4 = text;
                    if (String.Compare(left4, "表格线", false) == 0)
                    {
                        this.myborder = "1111";
                    }
                    else if (String.Compare(left4, "仅横线", false) == 0)
                    {
                        this.myborder = "0101";
                    }
                    else if (String.Compare(left4, "仅竖线", false) == 0)
                    {
                        this.myborder = "1010";
                    }
                    else if (String.Compare(left4, "无线", false) == 0)
                    {
                        this.myborder = "0000";
                    }
                    else if (Strings.Len(text) != 4 | !Versioned.IsNumeric(text))
                    {
                        this.myborder = "1111";
                        text = "表格线";
                    }
                    else
                    {
                        this.myborder = text;
                    }
                    this.bk.Text = text;
                    text = Module1.GetINI(section, "适合纸张宽度[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.zoomtopaperwidth = true;
                    }
                    else
                    {
                        this.zoomtopaperwidth = false;
                    }
                    if (this.zoomtopaperwidth)
                    {
                        this.kd.Checked = true;
                    }
                    else
                    {
                        this.kd.Checked = false;
                    }
                    text = Module1.GetINI(section, "自动调整行高[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.autoresizerowheight = true;
                    }
                    else
                    {
                        this.autoresizerowheight = false;
                    }
                    if (this.autoresizerowheight)
                    {
                        this.gd.Checked = true;
                    }
                    else
                    {
                        this.gd.Checked = false;
                    }
                    text = Module1.GetINI(section, "最小字号", "6", myfile);
                    this.minfontsize = Convert.ToSingle(text);
                    this.minsize.Text = Convert.ToString(this.minfontsize);
                    text = Module1.GetINI(section, "标题行重复打印[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.reppagetitle = true;
                    }
                    else
                    {
                        this.reppagetitle = false;
                    }
                    if (this.reppagetitle)
                    {
                        this.bt.Checked = true;
                    }
                    else
                    {
                        this.bt.Checked = false;
                    }
                    text = Module1.GetINI(section, "打印表格背景颜色[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.printbackcolor = true;
                    }
                    else
                    {
                        this.printbackcolor = false;
                    }
                    if (this.printbackcolor)
                    {
                        this.bj.Checked = true;
                    }
                    else
                    {
                        this.bj.Checked = false;
                    }
                    text = Module1.GetINI(section, "自动调整行高与列宽[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.autoformat = true;
                    }
                    else
                    {
                        this.autoformat = false;
                    }
                    if (this.autoformat)
                    {
                        this.gsf.Checked = true;
                    }
                    else
                    {
                        this.gsf.Checked = false;
                    }
                    text = Module1.GetINI(section, "工资条间距", "100", myfile);
                    this.linespace = Convert.ToSingle(text);
                    this.gzjj.Value = new decimal(this.linespace);
                    text = Module1.GetINI(section, "工资条打印零值[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.printzero = true;
                    }
                    else
                    {
                        this.printzero = false;
                    }
                    if (this.printzero)
                    {
                        this.lz.Checked = true;
                    }
                    else
                    {
                        this.lz.Checked = false;
                    }
                    text = Module1.GetINI(section, "工资条自动换行打印[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.autowrap = true;
                    }
                    else
                    {
                        this.autowrap = false;
                    }
                    if (this.autowrap)
                    {
                        this.gzwrap.Checked = true;
                    }
                    else
                    {
                        this.gzwrap.Checked = false;
                    }
                    text = Module1.GetINI(section, "多栏打印的栏数", "2", myfile);
                    this.mycolumns = Convert.ToInt32(text);
                    this.ls.Text = Convert.ToString(this.mycolumns);
                    text = Module1.GetINI(section, "多栏打印的栏间距", "50", myfile);
                    this.columnspace = (float)Conversion.Val(text);
                    this.ljj.Value = new decimal(this.columnspace);
                    text = Module1.GetINI(section, "多栏打印最后一页风格[0-1]", "1", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.lastpagemode = true;
                    }
                    else
                    {
                        this.lastpagemode = false;
                    }
                    if (this.lastpagemode)
                    {
                        this.zh.Checked = true;
                    }
                    else
                    {
                        this.zh.Checked = false;
                    }
                    text = Module1.GetINI(section, "跨页打印的固定列数", "2", myfile);
                    this.fixedcols = Convert.ToInt32(text);
                    this.columns.Text = Convert.ToString(this.fixedcols);
                    text = Module1.GetINI(section, "表格线颜色", "", myfile);
                    try
                    {
                        this.dgvtoprint.GridColor = Module1.ConvertStringToColor(text);
                        this.Button23.ForeColor = this.dgvtoprint.GridColor;
                    }
                    catch (Exception ex2)
                    {
                    }
                    text = Module1.GetINI(section, "补白打印[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.myisautoaddemptyrow = true;
                        this.autoaddrow.Checked = true;
                    }
                    else
                    {
                        this.myisautoaddemptyrow = false;
                        this.autoaddrow.Checked = false;
                    }
                    text = Module1.GetINI(section, "表格页脚每页重复打印[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.myisdrawtablefootereverypage = true;
                        this.yj.Checked = true;
                    }
                    else
                    {
                        this.myisdrawtablefootereverypage = false;
                        this.yj.Checked = false;
                    }
                    text = Module1.GetINI(section, "双表格线[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.myisusedoubleline = true;
                        this.gwxdoubleline.Checked = true;
                    }
                    else
                    {
                        this.myisusedoubleline = false;
                        this.gwxdoubleline.Checked = false;
                    }
                    text = Module1.GetINI(section, "双表格线间距(1/100厘米)", "10", myfile);
                    this.thedoublelinespace = (float)Conversion.Val(text);
                    this.gwxdoublinespace.Text = Convert.ToString(this.thedoublelinespace);
                    text = Module1.GetINI(section, "表格外边框[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.myouterborder = true;
                        this.gwxouterborder.Checked = true;
                    }
                    else
                    {
                        this.myouterborder = false;
                        this.gwxouterborder.Checked = false;
                    }
                    text = Module1.GetINI(section, "表格外边框线宽(1/100厘米)", "5", myfile);
                    this.myouterborderwidth = (float)Conversion.Val(text);
                    this.gwxouterborderwidth.Text = Convert.ToString(this.myouterborderwidth);
                    text = Module1.GetINI(section, "表格外边框颜色", Module1.ConvertColorToString(Color.Black), myfile);
                    this.myouterbordercolor = Module1.ConvertStringToColor(text);
                    this.Button39.ForeColor = this.myouterbordercolor;
                    section = "单元格默认边距";
                    text = Module1.GetINI(section, "左边距(毫米)", "-1", myfile);
                    if (String.Compare(text, "-1", false) != 0)
                    {
                        this.cleft.Text = Convert.ToString(Conversion.Val(text));
                    }
                    text = Module1.GetINI(section, "右边距(毫米)", "-1", myfile);
                    if (String.Compare(text, "-1", false) != 0)
                    {
                        this.cright.Text = Convert.ToString(Conversion.Val(text));
                    }
                    text = Module1.GetINI(section, "上边距(毫米)", "-1", myfile);
                    if (String.Compare(text, "-1", false) != 0)
                    {
                        this.ctop.Text = Convert.ToString(Conversion.Val(text));
                    }
                    text = Module1.GetINI(section, "下边距(毫米)", "-1", myfile);
                    if (String.Compare(text, "-1", false) != 0)
                    {
                        this.cbottom.Text = Convert.ToString(Conversion.Val(text));
                    }
                    section = "打印标题设置";
                    text = Module1.GetINI(section, "主标题", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.ztitle = text;
                        this.maintitle.Text = text;
                    }
                    text = Module1.GetINI(section, "主标题字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.maintitle.Font = (Font)font.Clone();
                        this.ztitlefont = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "主标题前景颜色", "", myfile);
                    Color color = Module1.ConvertStringToColor(text);
                    if (color.ToArgb() == 0)
                    {
                        color = Color.Black;
                    }
                    this.maintitle.ForeColor = color;
                    this.mydefaultcolor = color;
                    this.maintitle.ForeColor = this.mydefaultcolor;
                    this.subtitle.ForeColor = this.mydefaultcolor;
                    this.tablel.ForeColor = this.mydefaultcolor;
                    this.tablem.ForeColor = this.mydefaultcolor;
                    this.tabler.ForeColor = this.mydefaultcolor;
                    this.tableleft.ForeColor = this.mydefaultcolor;
                    this.tableright.ForeColor = this.mydefaultcolor;
                    this.tablemiddle.ForeColor = this.mydefaultcolor;
                    text = Module1.GetINI(section, "主标题文字风格[0-6]", "0", myfile);
                    this.mytitletextstyle = Convert.ToInt32(text);
                    if (this.mytitletextstyle > 6 | this.mytitletextstyle < 0)
                    {
                        this.mytitletextstyle = 0;
                    }
                    this.zys.SelectedIndex = this.mytitletextstyle;
                    text = Module1.GetINI(section, "辅标题", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.ftitle = text;
                        this.subtitle.Text = text;
                    }
                    text = Module1.GetINI(section, "辅标题字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.subtitle.Font = (Font)font.Clone();
                        this.ftitlefont = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "辅标题文字风格[0-6]", "0", myfile);
                    this.mysubtitlestyle = Convert.ToInt32(text);
                    if (this.mysubtitlestyle > 6 | this.mysubtitlestyle < 0)
                    {
                        this.mysubtitlestyle = 0;
                    }
                    this.fys.SelectedIndex = this.mysubtitlestyle;
                    this.myshapedepth = Convert.ToInt32(Module1.GetINI(section, "标题特效时的深度", "8", myfile));
                    section = "表格页眉";
                    text = Module1.GetINI(section, "左边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tablel.Text = text;
                        this.mytablel = text;
                    }
                    text = Module1.GetINI(section, "左边对齐[0-2]", "0", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "0";
                    }
                    this.myTableTopLeftTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "中间", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tablem.Text = text;
                        this.mytablem = text;
                    }
                    text = Module1.GetINI(section, "中间对齐[0-2]", "1", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "1";
                    }
                    this.myTableTopMiddleTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "右边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tabler.Text = text;
                        this.mytabler = text;
                    }
                    text = Module1.GetINI(section, "右边对齐[0-2]", "2", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "2";
                    }
                    this.myTableTopRightTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.mytopfont = (Font)font.Clone();
                        this.tablel.Font = (Font)font.Clone();
                        this.tablem.Font = (Font)font.Clone();
                        this.tabler.Font = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "打印页眉横线[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.drawheader.Checked = true;
                        this.myisdrawpageheaderline = true;
                    }
                    else
                    {
                        this.drawheader.Checked = false;
                        this.myisdrawpageheaderline = false;
                    }
                    section = "表格页脚";
                    text = Module1.GetINI(section, "左边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tableleft.Text = text;
                        this.mytableleft = text;
                    }
                    text = Module1.GetINI(section, "左边对齐[0-2]", "0", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "0";
                    }
                    this.myTableBottomLeftTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "中间", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tablemiddle.Text = text;
                        this.mytablemiddle = text;
                    }
                    text = Module1.GetINI(section, "中间对齐[0-2]", "1", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "1";
                    }
                    this.myTableBottomMiddleTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "右边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.tableright.Text = text;
                        this.mytableright = text;
                    }
                    text = Module1.GetINI(section, "右边对齐[0-2]", "2", myfile);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "2";
                    }
                    this.myTableBottomRightTitleAlign = (StringAlignment)Convert.ToInt32(text);
                    text = Module1.GetINI(section, "字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.mybottomfont = (Font)font.Clone();
                        this.tableleft.Font = (Font)font.Clone();
                        this.tablemiddle.Font = (Font)font.Clone();
                        this.tableright.Font = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "打印页脚横线[0-1]", "0", myfile);
                    if (String.Compare(text, "1", false) == 0)
                    {
                        this.drawfooter.Checked = true;
                        this.myisdrawpagefooterline = true;
                    }
                    else
                    {
                        this.drawfooter.Checked = false;
                        this.myisdrawpagefooterline = false;
                    }
                    this.SetAlign();
                    section = "页面页眉";
                    text = Module1.GetINI(section, "左边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pagel.Text = text;
                        this.mypagel = text;
                    }
                    text = Module1.GetINI(section, "中间", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pagem.Text = text;
                        this.mypagem = text;
                    }
                    text = Module1.GetINI(section, "右边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pager.Text = text;
                        this.mypager = text;
                    }
                    text = Module1.GetINI(section, "字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.myheaderfont = (Font)font.Clone();
                        this.pagel.Font = (Font)font.Clone();
                        this.pagem.Font = (Font)font.Clone();
                        this.pager.Font = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "前景颜色", "", myfile);
                    color = Module1.ConvertStringToColor(text);
                    this.myheadercolor = color;
                    this.pagel.ForeColor = color;
                    this.pagem.ForeColor = color;
                    this.pager.ForeColor = color;
                    section = "页面页脚";
                    text = Module1.GetINI(section, "左边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pageleft.Text = text;
                        this.mypageleft = text;
                    }
                    text = Module1.GetINI(section, "中间", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pagemiddle.Text = text;
                        this.mypagemiddle = text;
                    }
                    text = Module1.GetINI(section, "右边", "", myfile);
                    if (String.Compare(text, "", false) != 0)
                    {
                        this.pageright.Text = text;
                        this.mypageright = text;
                    }
                    text = Module1.GetINI(section, "字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.myfooterfont = (Font)font.Clone();
                        this.pageleft.Font = (Font)font.Clone();
                        this.pagemiddle.Font = (Font)font.Clone();
                        this.pageright.Font = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "前景颜色", "", myfile);
                    color = Module1.ConvertStringToColor(text);
                    this.myfootercolor = color;
                    this.pageleft.ForeColor = color;
                    this.pagemiddle.ForeColor = color;
                    this.pageright.ForeColor = color;
                    section = "页面右边";
                    text = Module1.GetINI(section, "上边", "", myfile);
                    this.rightt.Text = text;
                    text = Module1.GetINI(section, "中间", "", myfile);
                    this.rightm.Text = text;
                    text = Module1.GetINI(section, "下边", "", myfile);
                    this.rightb.Text = text;
                    text = Module1.GetINI(section, "字体", "", myfile);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        this.rightt.Font = (Font)font.Clone();
                        this.rightm.Font = (Font)font.Clone();
                        this.rightb.Font = (Font)font.Clone();
                    }
                    text = Module1.GetINI(section, "前景颜色", "", myfile);
                    color = Module1.ConvertStringToColor(text);
                    this.rightt.ForeColor = color;
                    this.rightm.ForeColor = color;
                    this.rightb.ForeColor = color;
                    section = "表格默认设置";
                    text = Module1.GetINI(section, "表格总列数", "0", myfile);
                    int num3 = Convert.ToInt32(text);
                    if (num3 == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        text = Module1.GetINI(section, "标题字段名默认字体", "", myfile);
                        font = Module1.ConvertStringToFont(text);
                        if (font != null)
                        {
                            this.headerfont.Font = font;
                            this.dgvtoprint.ColumnHeadersDefaultCellStyle.Font = (Font)font.Clone();
                        }
                        text = Module1.GetINI(section, "标题字段名认前景颜色", "", myfile);
                        color = Module1.ConvertStringToColor(text);
                        this.headerfont.ForeColor = color;
                        this.dgvtoprint.ColumnHeadersDefaultCellStyle.ForeColor = color;
                        text = Module1.GetINI(section, "标题字段名默认背景颜色", Module1.ConvertColorToString(Color.White), myfile);
                        color = Module1.ConvertStringToColor(text);
                        this.headerfont.BackColor = color;
                        this.dgvtoprint.ColumnHeadersDefaultCellStyle.BackColor = color;
                        text = Module1.GetINI(section, "单元格默认字体", "", myfile);
                        font = Module1.ConvertStringToFont(text);
                        if (font != null)
                        {
                            this.fontshow.Font = font;
                            this.dgvtoprint.DefaultCellStyle.Font = (Font)font.Clone();
                        }
                        text = Module1.GetINI(section, "单元格默认前景颜色", "", myfile);
                        color = Module1.ConvertStringToColor(text);
                        this.fontshow.ForeColor = color;
                        this.dgvtoprint.DefaultCellStyle.ForeColor = color;
                        text = Module1.GetINI(section, "单元格默认背景颜色", Module1.ConvertColorToString(Color.White), myfile);
                        color = Module1.ConvertStringToColor(text);
                        this.fontshow.BackColor = color;
                        this.dgvtoprint.DefaultCellStyle.BackColor = color;
                        text = Module1.GetINI(section, "默认行高[毫米]", "0", myfile);
                        try
                        {
                            this.myrowheight = Convert.ToSingle(text);
                            this.rowheight.Value = Convert.ToDecimal(text);
                        }
                        catch (Exception ex3)
                        {
                        }
                        text = Module1.GetINI(section, "奇数行默认前景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), myfile);
                        color = Module1.ConvertStringToColor(text);
                        Color color2 = new Color();
                        if (color.ToArgb() == 0)
                        {
                            this.Cforecolor.Checked = true;
                            this.bforecolor.Enabled = false;
                            this.jsh.ForeColor = this.fontshow.ForeColor;
                            this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor = color2;
                        }
                        else
                        {
                            this.Cforecolor.Checked = false;
                            this.bforecolor.Enabled = true;
                            this.jsh.ForeColor = color;
                            this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor = color;
                        }
                        text = Module1.GetINI(section, "奇数行默认背景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), myfile);
                        color = Module1.ConvertStringToColor(text);
                        if (color.ToArgb() == 0)
                        {
                            this.Cbackcolor.Checked = true;
                            this.bbackcolor.Enabled = false;
                            this.jsh.BackColor = this.fontshow.BackColor;
                            this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor = color2;
                        }
                        else
                        {
                            this.Cbackcolor.Checked = false;
                            this.bbackcolor.Enabled = true;
                            this.jsh.BackColor = color;
                            this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor = color;
                        }
                        text = Strings.Trim(Module1.GetINI("分组汇总排序设置", "第一列前添加行号", "", myfile));
                        if (String.Compare(text, "1", false) == 0 | String.Compare(text, "是", false) == 0)
                        {
                            this.myaddrowid = true;
                            this.addrowid.Checked = true;
                        }
                        else
                        {
                            this.myaddrowid = false;
                            this.addrowid.Checked = false;
                        }
                        if (num3 != this.dgvtoprint.ColumnCount)
                        {
                            Interaction.MsgBox(string.Concat(new string[]
                            {
                                "无法应用方案文件【",
                                myfile,
                                "】中的表格各列详细设置参数（除此之外的其余参数都成功应用了），原因是当前要打印的表格有【",
                                Convert.ToString(this.dgvtoprint.ColumnCount),
                                "列】而方案文件中保存的表格有〖",
                                Convert.ToString(num3),
                                "列〗，两者数不一致，不能使用。\r\n如果您只需要读取方案文件中除要表格各列详细参数设置外的其他参数，您应该将方案文件中的<表格总列数>设为0，或者在保存方案时就不保存表格参数设置"
                            }), MsgBoxStyle.OkOnly, "提示信息");
                            result = false;
                        }
                        else
                        {
                            string[] array = new string[num3 - 1 + 1];
                            string[] array2 = new string[num3 - 1 + 1];
                            int num4 = 1;
                            int num5 = num3;
                            for (int i = num4; i <= num5; i++)
                            {
                                section = "第" + Convert.ToString(i) + "列";
                                array2[i - 1] = Module1.GetINI(section, "名称", "", myfile);
                                array[i - 1] = Module1.GetINI(section, "显示的文本", "", myfile);
                            }
                            bool flag = false;
                            int num6 = 0;
                            int num7 = num3 - 1;
                            int j = num6;
                            while (j <= num7)
                            {
                                int num8 = j + 1;
                                int num9 = num3 - 1;
                                int k = num8;
                                while (k <= num9)
                                {
                                    if (String.Compare(array2[j], array2[k], false) == 0)
                                    {
                                        flag = true;
                                    IL_211E:
                                        if (!flag)
                                        {
                                            j++;
                                        }
                                    }
                                    else
                                    {
                                        k++;
                                    }
                                }
                            }

                            if (flag)
                            {
                                Interaction.MsgBox(string.Concat(new string[]
                                {
                                    "您当前读取的方案文件【",
                                    myfile,
                                    "】存在问题，列名称为【",
                                    array2[j],
                                    "】的有多列，本控件要求列名称必须唯一，请修改该方案再读取。\r\n本次读取打印方案除列详细设置读取失败外，其他参数已成功应用"
                                }), MsgBoxStyle.OkOnly, "提示信息");
                                result = false;
                            }
                            else
                            {
                                flag = false;
                                int num10 = 0;
                                int num11 = num3 - 1;
                                j = num10;

                                while (j <= num11)
                                {
                                    int num12 = j + 1;
                                    int num13 = num3 - 1;
                                    int l = num12;
                                    while (l <= num13)
                                    {
                                        if (String.Compare(array[j], array[l], false) == 0)
                                        {
                                            flag = true;

                                            if (!flag)
                                            {
                                                j++;

                                            }

                                        }
                                        else
                                        {
                                            l++;
                                        }
                                    }

                                }

                                if (flag)
                                {
                                    Interaction.MsgBox(string.Concat(new string[]
                                    {
                                        "您当前读取的方案文件【",
                                        myfile,
                                        "】存在问题，列显示名称为【",
                                        array2[j],
                                        "】的有多列，本控件要求列的显示名称必须唯一，否则会产生问题，请修改该方案再读取。\r\n本次读取打印方案除列详细设置读取失败外，其他参数已成功应用"
                                    }), MsgBoxStyle.OkOnly, "提示信息");
                                    result = false;
                                }
                                else
                                {
                                    int num14 = 0;
                                    int num15 = num3 - 1;
                                    int i = num14;
                                IL_2272:
                                    while (i <= num15)
                                    {
                                        flag = false;
                                        text = array2[i];
                                        int num16 = 0;
                                        int num17 = num3 - 1;
                                        j = num16;
                                        while (j <= num17)
                                        {
                                            if (String.Compare(text, this.dgvtoprint.Columns[j].Name, false) == 0)
                                            {
                                                flag = true;
                                            IL_2268:
                                                if (flag)
                                                {
                                                    i++;
                                                    goto IL_2272;
                                                }
                                                Interaction.MsgBox(string.Concat(new string[]
                                                {
                                                    "您当前读取的方案文件【",
                                                    myfile,
                                                    "】存在问题，方案文件中保存的列名称为【",
                                                    array2[i],
                                                    "】的列在当前要打印的DataGridView表格中不存在，因此该方案与当前打印的表格不兼容，不能使用方案中的列详细设置参数。\r\n本次读取打印方案除列详细设置读取失败外，其他参数已成功应用"
                                                }), MsgBoxStyle.OkOnly, "提示信息");
                                                return false;
                                            }
                                            else
                                            {
                                                j++;
                                            }
                                        }

                                    }
                                    int num18 = 0;
                                    int num19 = this.C1.Items.Count - 1;
                                    for (i = num18; i <= num19; i++)
                                    {
                                        section = "第" + Convert.ToString(i + 1) + "列";
                                        string ini = Module1.GetINI(section, "名称", "", myfile);
                                        string ini2 = Module1.GetINI(section, "显示的文本", "", myfile);
                                        this.dgvtoprint.Columns[ini].HeaderText = ini2;
                                        this.dgvtoprint.Columns[ini].DisplayIndex = i;
                                        text = Module1.GetINI(section, "是否打印[0-1]", "1", myfile);
                                        if (String.Compare(text, "1", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].Visible = true;
                                        }
                                        else
                                        {
                                            this.dgvtoprint.Columns[ini].Visible = false;
                                        }
                                        text = Module1.GetINI(section, "默认字体", "", myfile);
                                        font = Module1.ConvertStringToFont(text);
                                        if (font != null)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Font = (Font)font.Clone();
                                        }
                                        text = Module1.GetINI(section, "默认前景色", "", myfile);
                                        color = Module1.ConvertStringToColor(text);
                                        this.dgvtoprint.Columns[ini].DefaultCellStyle.ForeColor = color;
                                        text = Module1.GetINI(section, "默认背景色", Module1.ConvertColorToString(Color.White), myfile);
                                        color = Module1.ConvertStringToColor(text);
                                        this.dgvtoprint.Columns[ini].DefaultCellStyle.BackColor = color;
                                        text = Module1.GetINI(section, "文本对齐方式", "", myfile);
                                        string left5 = text;
                                        if (String.Compare(left5, "居中对齐", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        }
                                        else if (String.Compare(left5, "左对齐", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                        }
                                        else if (String.Compare(left5, "未设置", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                                        }
                                        else if (String.Compare(left5, "右对齐", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                        }
                                        else
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                                        }
                                        text = Module1.GetINI(section, "文本允许换行", "", myfile);
                                        string left6 = text;
                                        if (String.Compare(left6, "未设置", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
                                        }
                                        else if (String.Compare(left6, "允许", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                                        }
                                        else if (String.Compare(left6, "不允许", false) == 0)
                                        {
                                            this.dgvtoprint.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                                        }
                                        if (this.dgvtoprint.Columns[this.curitem].HasDefaultCellStyle)
                                        {
                                            try
                                            {
                                                if (this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font != null)
                                                {
                                                    this.columnfont.Font = (Font)this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.Font.Clone();
                                                }
                                                goto IL_26A5;
                                            }
                                            catch (Exception ex4)
                                            {
                                                goto IL_26A5;
                                            }
                                            goto IL_263F;
                                        IL_26A5:
                                            this.columnfont.ForeColor = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.ForeColor;
                                            this.columnfont.BackColor = this.dgvtoprint.Columns[this.curitem].DefaultCellStyle.BackColor;
                                        }
                                    IL_263F:
                                        text = Module1.GetINI(section, "列宽(毫米)", "", myfile);
                                        if (Versioned.IsNumeric(text))
                                        {
                                            try
                                            {
                                                this.dgvtoprint.Columns[ini].Width = (int)Math.Round((double)this.ConvFromMMToDisplay(Convert.ToSingle(Convert.ToDecimal(text))));
                                            }
                                            catch (Exception ex5)
                                            {
                                            }
                                        }
                                    }
                                    section = "分组汇总排序设置";
                                    this.myhzcolumns = Module1.GetINI(section, "要汇总的列", "", myfile);
                                    text = Module1.GetINI(section, "汇总行字体", "", myfile);
                                    font = Module1.ConvertStringToFont(text);
                                    if (font == null)
                                    {
                                        font = new Font("黑体", this.fontshow.Font.Size, FontStyle.Bold);
                                    }
                                    this.myhzfont = font;
                                    this.hzfontshow.Font = font;
                                    text = Module1.GetINI(section, "汇总行前景颜色", "", myfile);
                                    color = Module1.ConvertStringToColor(text);
                                    if (color.ToArgb() == 0)
                                    {
                                        color = this.fontshow.ForeColor;
                                    }
                                    this.myhzforecolor = color;
                                    text = Module1.GetINI(section, "汇总行背景颜色", "", myfile);
                                    color = Module1.ConvertStringToColor(text);
                                    if (color.ToArgb() == 0)
                                    {
                                        color = this.fontshow.BackColor;
                                    }
                                    this.myhzbackcolor = color;
                                    this.hzfontshow.ForeColor = this.myhzforecolor;
                                    this.hzfontshow.BackColor = this.myhzbackcolor;
                                    text = Module1.GetINI(section, "汇总行数字对齐方式[0-2]", "1", myfile);
                                    if (!Versioned.IsNumeric(text))
                                    {
                                        text = "1";
                                    }
                                    this.mySumNumberAlign = (StringAlignment)Convert.ToInt32(text);
                                    this.SetAlign();
                                    this.mysortcolumn = Module1.GetINI(section, "要排序的列", "", myfile);
                                    text = Strings.Trim(Module1.GetINI(section, "升序排序", "", myfile));
                                    if (String.Compare(text, "1", false) == 0 | String.Compare(text, "是", false) == 0)
                                    {
                                        this.mysorttype = true;
                                    }
                                    else
                                    {
                                        this.mysorttype = false;
                                    }
                                    this.mygroupcolumne = Module1.GetINI(section, "要分组列", "", myfile);
                                    text = Strings.Trim(Module1.GetINI(section, "每组换新页打印", "", myfile));
                                    if (String.Compare(text, "1", false) == 0 | String.Compare(text, "是", false) == 0)
                                    {
                                        this.mygroupnewpage = true;
                                    }
                                    else
                                    {
                                        this.mygroupnewpage = false;
                                    }
                                    text = Strings.Trim(Module1.GetINI(section, "第一列前添加行号", "", myfile));
                                    if (String.Compare(text, "1", false) == 0 | String.Compare(text, "是", false) == 0)
                                    {
                                        this.myaddrowid = true;
                                    }
                                    else
                                    {
                                        this.myaddrowid = false;
                                    }
                                    text = Strings.Trim(Module1.GetINI(section, "每组行号重新编号", "", myfile));
                                    if (String.Compare(text, "1", false) == 0 | String.Compare(text, "是", false) == 0)
                                    {
                                        this.myaddrownew = true;
                                    }
                                    else
                                    {
                                        this.myaddrownew = false;
                                    }
                                    this.SetFieldToComb();
                                    this.SetGroup();
                                    result = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex6)
                {
                    result = false;
                }
                return result;
            }
        }

        // Token: 0x060003AF RID: 943 RVA: 0x0002A900 File Offset: 0x00028B00
        private void Button25_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.OpenFileDialog1.InitialDirectory, "", false) == 0)
            {
                this.OpenFileDialog1.InitialDirectory = Application.StartupPath;
            }
            if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Compare(this.OpenFileDialog1.FileName, "", false) == 0 & String.Compare(this.schemefilename, "", false) == 0)
                {
                    this.OpenFileDialog1.FileName = this.dgvtoprint.Name;
                }
                else if (String.Compare(this.OpenFileDialog1.FileName, "", false) == 0)
                {
                    this.OpenFileDialog1.FileName = this.schemefilename;
                }
                if (!MyProject.Computer.FileSystem.FileExists(this.OpenFileDialog1.FileName))
                {
                    Interaction.MsgBox("打印方案文件【" + this.OpenFileDialog1.FileName + "】不存在", MsgBoxStyle.OkOnly, "提示信息");
                }
                else if (this.RestoreFa(this.OpenFileDialog1.FileName))
                {
                    Interaction.MsgBox("从文件中读取打印方案成功", MsgBoxStyle.OkOnly, "提示信息");
                }
                else
                {
                    Interaction.MsgBox("从文件中读取打印方案失败或者部分内容失败", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x060003B0 RID: 944 RVA: 0x0002AA34 File Offset: 0x00028C34
        private void Button26_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.mywatermarkcolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.mywatermarkcolor = this.ColorDialog1.Color;
                this.sytext.ForeColor = this.mywatermarkcolor;
            }
        }

        // Token: 0x060003B1 RID: 945 RVA: 0x0002AA84 File Offset: 0x00028C84
        private void Button27_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.sytext.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.sytext.Font = this.FontDialog1.Font;
                this.mywatermarkfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003B2 RID: 946 RVA: 0x0002AADC File Offset: 0x00028CDC
        private void Button29_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.rightt.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.rightt.Font = this.FontDialog1.Font;
                this.rightm.Font = this.FontDialog1.Font;
                this.rightb.Font = this.FontDialog1.Font;
                this.myrightfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003B3 RID: 947 RVA: 0x0002AB60 File Offset: 0x00028D60
        private void Button28_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.rightt.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.rightt.ForeColor = this.ColorDialog1.Color;
                this.rightm.ForeColor = this.ColorDialog1.Color;
                this.rightb.ForeColor = this.ColorDialog1.Color;
                this.myrightcolor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003B4 RID: 948 RVA: 0x0002ABE4 File Offset: 0x00028DE4
        private void Button30_Click(object sender, EventArgs e)
        {
            checked
            {
                if (String.Compare(this.curitem, "", false) != 0)
                {
                    string text = Convert.ToString(this.C1.SelectedItem);
                    string text2 = Interaction.InputBox("请输入该列要打印的新列标题名称，该列的原打印标题为【" + text + "】，注意，请确保存列标题名称在该表格是中唯一的", "更改列标题名称", text, -1, -1);
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
                                        Interaction.MsgBox("列标题名称为【" + text2 + "】的列已经存在，本版控件要求列标题名称唯一，因此更改列标题名称失败", MsgBoxStyle.OkOnly, "提示信息");
                                        return;
                                    }
                                    this.dgvtoprint.Columns[this.curitem].HeaderText = text2;
                                    this.C1.Items[this.C1.SelectedIndex] = text2;
                                    int num3 = 0;
                                    int num4 = this.hz.Items.Count - 1;
                                    for (i = num3; i <= num4; i++)
                                    {
                                        if (String.Compare(Convert.ToString(this.hz.Items[i]), text, false) == 0)
                                        {
                                            this.hz.Items[i] = text2;
                                        IL_18D:
                                            int num5 = 0;
                                            int num6 = this.sortcolumn.Items.Count - 1;
                                            for (i = num5; i <= num6; i++)
                                            {
                                                if (String.Compare(Convert.ToString(this.sortcolumn.Items[i]), text, false) == 0)
                                                {
                                                    this.sortcolumn.Items[i] = text2;
                                                IL_1E4:
                                                    int num7 = 0;
                                                    int num8 = this.groupcolumn.Items.Count - 1;
                                                    for (i = num7; i <= num8; i++)
                                                    {
                                                        if (String.Compare(Convert.ToString(this.groupcolumn.Items[i]), text, false) == 0)
                                                        {
                                                            this.groupcolumn.Items[i] = text2;
                                                            break;
                                                        }
                                                    }
                                                    return;
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }

                    }
                }
            }
        }

        // Token: 0x060003B5 RID: 949 RVA: 0x0002AE2C File Offset: 0x0002902C
        private void Button31_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            string text = "";
            string text2 = "";
            if (String.Compare(this.tablel.Text, "", false) != 0)
            {
                text = this.tablel.Text;
            }
            if (String.Compare(this.tablem.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tablem.Text;
                }
                else
                {
                    text = text + "       " + this.tablem.Text;
                }
            }
            if (String.Compare(this.tabler.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tabler.Text;
                }
                else
                {
                    text = text + "       " + this.tabler.Text;
                }
            }
            if (String.Compare(this.tableleft.Text, "", false) != 0)
            {
                text2 = this.tableleft.Text;
            }
            if (String.Compare(this.tablemiddle.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tablemiddle.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tablemiddle.Text;
                }
            }
            if (String.Compare(this.tableright.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tableright.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tableright.Text;
                }
            }
            new ExportDataGridView
            {
                TableHeader = text,
                TableFooter = text2,
                FileName = "",
                OpenFile = true,
                Title = this.maintitle.Text,
                TitleFont = (Font)this.ztitlefont.Clone(),
                TableHeaderFont = (Font)this.mytopfont.Clone(),
                TableFooterFont = (Font)this.mybottomfont.Clone()
            }.ExportDGV(this.dgvtoprint, this.myheader, ExportDataGridView.ExportDataGridViewType.Excel);
            this.UseWaitCursor = false;
        }

        // Token: 0x060003B6 RID: 950 RVA: 0x00003044 File Offset: 0x00001244
        private void Button32_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this.Parent, "打印控件帮助文档.chm", "syy.htm");
        }

        // Token: 0x060003B7 RID: 951 RVA: 0x0002B060 File Offset: 0x00029260
        private void Cforecolor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cforecolor.Checked)
            {
                this.bforecolor.Enabled = false;
                Color foreColor = new Color();
                this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor = foreColor;
                this.jsh.ForeColor = this.fontshow.ForeColor;
            }
            else
            {
                this.bforecolor.Enabled = true;
                this.jsh.ForeColor = this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor;
                if (this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor.ToArgb() == 0)
                {
                    this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor = this.fontshow.ForeColor;
                    this.jsh.ForeColor = this.fontshow.ForeColor;
                }
            }
        }

        // Token: 0x060003B8 RID: 952 RVA: 0x0002B124 File Offset: 0x00029324
        private void Cbackcolor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbackcolor.Checked)
            {
                Color backColor = new Color();
                this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor = backColor;
                this.bbackcolor.Enabled = false;
                this.jsh.BackColor = this.fontshow.BackColor;
            }
            else
            {
                this.bbackcolor.Enabled = true;
                this.jsh.BackColor = this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor;
                if (this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor.ToArgb() == 0)
                {
                    this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor = this.fontshow.BackColor;
                    this.jsh.BackColor = this.fontshow.BackColor;
                }
            }
        }

        // Token: 0x060003B9 RID: 953 RVA: 0x0002B1E8 File Offset: 0x000293E8
        private void bforecolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.AlternatingRowsDefaultCellStyle.ForeColor = this.ColorDialog1.Color;
                this.jsh.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003BA RID: 954 RVA: 0x0002B250 File Offset: 0x00029450
        private void bbackcolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgvtoprint.AlternatingRowsDefaultCellStyle.BackColor = this.ColorDialog1.Color;
                this.jsh.BackColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003BB RID: 955 RVA: 0x0002B2B8 File Offset: 0x000294B8
        private void fontshow_BackColorChanged(object sender, EventArgs e)
        {
            if (this.Cbackcolor.Checked)
            {
                this.jsh.BackColor = this.fontshow.BackColor;
            }
        }

        // Token: 0x060003BC RID: 956 RVA: 0x0002B2E8 File Offset: 0x000294E8
        private void fontshow_ForeColorChanged(object sender, EventArgs e)
        {
            if (this.Cforecolor.Checked)
            {
                this.jsh.ForeColor = this.fontshow.ForeColor;
            }
        }

        // Token: 0x060003BD RID: 957 RVA: 0x0002B318 File Offset: 0x00029518
        private void Button34_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.hzfontshow.ForeColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.hzfontshow.ForeColor = this.ColorDialog1.Color;
                this.myhzforecolor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003BE RID: 958 RVA: 0x0002B370 File Offset: 0x00029570
        private void Button35_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.hzfontshow.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.hzfontshow.Font = this.FontDialog1.Font;
                this.myhzfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003BF RID: 959 RVA: 0x0002B3C8 File Offset: 0x000295C8
        private void Button33_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.hzfontshow.BackColor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.hzfontshow.BackColor = this.ColorDialog1.Color;
                this.myhzbackcolor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003C0 RID: 960 RVA: 0x0002B420 File Offset: 0x00029620
        private void groupcolumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(Convert.ToString(this.groupcolumn.SelectedItem) + "", "", false) != 0)
            {
                string columnName = Convert.ToString(this.groupcolumn.SelectedItem) + "";
                if (String.Compare(Versioned.TypeName(this.dgvtoprint.Columns[columnName]), "DataGridViewImageColumn", false) == 0)
                {
                    Interaction.MsgBox("错误，图像列不能作为分组列", MsgBoxStyle.OkOnly, "提示信息");
                    this.groupcolumn.SelectedIndex = -1;
                }
            }
        }

        // Token: 0x060003C1 RID: 961 RVA: 0x0002B4B4 File Offset: 0x000296B4
        private void tabletopleftalign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tabletopleftalign.Text;
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
            this.tablel.TextAlign = textAlign;
        }

        // Token: 0x060003C2 RID: 962 RVA: 0x0002B510 File Offset: 0x00029710
        private void tabletopmiddlealign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tabletopmiddlealign.Text;
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
            this.tablem.TextAlign = textAlign;
        }

        // Token: 0x060003C3 RID: 963 RVA: 0x0002B56C File Offset: 0x0002976C
        private void tabletoprightalign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tabletoprightalign.Text;
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
            this.tabler.TextAlign = textAlign;
        }

        // Token: 0x060003C4 RID: 964 RVA: 0x0002B5C8 File Offset: 0x000297C8
        private void tablebottomleftalign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tablebottomleftalign.Text;
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
            this.tableleft.TextAlign = textAlign;
        }

        // Token: 0x060003C5 RID: 965 RVA: 0x0002B624 File Offset: 0x00029824
        private void tablebottommiddlealign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tablebottommiddlealign.Text;
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
            this.tablemiddle.TextAlign = textAlign;
        }

        // Token: 0x060003C6 RID: 966 RVA: 0x0002B680 File Offset: 0x00029880
        private void tablebottomrightalign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.tablebottomrightalign.Text;
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
            this.tableright.TextAlign = textAlign;
        }

        // Token: 0x060003C7 RID: 967 RVA: 0x0002B6DC File Offset: 0x000298DC
        private float ConvFromDisplayToMM(float myw)
        {
            float pixelsperinchx = this.PIXELSPERINCHX;
            return (float)((double)(myw / pixelsperinchx) * 2.54 * 10.0);
        }

        // Token: 0x060003C8 RID: 968 RVA: 0x0002B710 File Offset: 0x00029910
        private float ConvFromMMToDisplay(float myw)
        {
            float num = (float)((double)(myw / 10f) / 2.54);
            float num2 = this.PIXELSPERINCHX;
            num2 = num * num2;
            return (float)Math.Floor((double)num2);
        }

        // Token: 0x060003C9 RID: 969 RVA: 0x0002B748 File Offset: 0x00029948
        public DataGridViewPrintSet()
        {
            base.Load += this.DataGridViewPrintSet_Load;
            this.PaperLandscape = false;
            this.ztitle = "";
            this.ftitle = "";
            this.ztitlefont = null;
            this.ftitlefont = null;
            this.printtype = 1;
            this.zoomtopaperwidth = true;
            this.minfontsize = 6f;
            this.reppagetitle = false;
            this.printbackcolor = false;
            this.myborder = "1111";
            this.linespace = 30f;
            this.printzero = false;
            this.autowrap = false;
            this.mycolumns = 2;
            this.columnspace = 30f;
            this.lastpagemode = true;
            this.fixedcols = 1;
            this.mypapermarign = new Margins(254, 254, 254, 254);
            this.isfirsttimeshow = true;
            this.mywatermarktext = "";
            this.mywatermarkfont = new Font("华文行楷", 80f, FontStyle.Bold);
            this.mywatermarkopacity = 128;
            this.mywatermarklandscape = true;
            this.mywatermarkcolor = Color.Red;
            this.myshapedepth = 8;
            this.myrightt = "";
            this.myrightm = "";
            this.myrightb = "";
            this.myrightfont = new Font("宋体", 10f);
            this.myrightcolor = Color.Black;
            this.myhzcolumns = "";
            this.myhzfont = null;
            this.myhzforecolor = default(Color);
            this.myhzbackcolor = default(Color);
            this.datarowcount = 0;
            this.mywindowtext = "";
            this.currentprintname = "";
            this.mysortcolumn = "";
            this.mysorttype = true;
            this.mygroupcolumne = "";
            this.mygroupnewpage = false;
            this.myaddrowid = false;
            this.myaddrownew = false;
            this.myIsImmediatePrintNotPreviewShowPrintDialog = false;
            this.myIsShowMessageIfPrinterNotSupportPaper = false;
            this.mypaperwidth = 0m;
            this.mypaperheight = 0m;
            this.myTableTopLeftTitleAlign = StringAlignment.Near;
            this.myTableTopMiddleTitleAlign = StringAlignment.Center;
            this.myTableTopRightTitleAlign = StringAlignment.Far;
            this.myTableBottomLeftTitleAlign = StringAlignment.Near;
            this.myTableBottomMiddleTitleAlign = StringAlignment.Center;
            this.myTableBottomRightTitleAlign = StringAlignment.Far;
            this.mySumNumberAlign = StringAlignment.Center;
            this.mypagebackgroundimage = null;
            this.myisshowaboutpage = true;
            this.myisdrawpageheaderline = false;
            this.myisdrawpagefooterline = false;
            this.myisdrawmargin = false;
            this.myisautoaddemptyrow = false;
            this.myenabledprint = true;
            this.myisdrawtablefootereverypage = false;
            this.myp = new Ruler();
            this.myisusedoubleline = false;
            this.myouterborder = false;
            this.myouterbordercolor = Color.Black;
            this.myouterborderwidth = 1f;
            this.thedoublelinespace = 3f;
            this.myZDXtext = "装订线";
            this.myZDXfont = new Font("宋体", 9f);
            this.myZDXtextcolor = Color.Black;
            this.myZDXlinecolor = Color.Black;
            this.myZDXlinestyle = DashStyle.Dash;
            this.myZDXposition = 0f;
            this.myrowheight = 0f;
            this.myEnableChangeScheme = true;
            this.NeedReadFangAn = true;
            this.myenablesaveaspdf = true;
            this.myenablesaveasimage = true;
            this.myenableexportpdf = true;
            this.myenableexportexcel = true;
            this.myenableexportrtf = true;
            this.myenableexporthtml = true;
            this._printcopys = 1;
            this.myisshowprogress = true;
            this.myZDXtype = DataGridViewPrintSet.TheZDXTYPE.LEFT;
            this.myisdrawZDX = false;
            this.myEnableChangePageSettings = true;
            this.myEnableChangeTitle = true;
            this.myEnableChangeTableStyle = true;
            this.myEnableChangeTableSettings = true;
            this.myEnableChangeHeaderAndFooter = true;
            this.myEnableChangeGroup = true;
            this.myEnableChangeSum = true;
            this.myEnableChangeZDX = true;
            this.myEnableChangeWaterMark = true;
            this.InitializeComponent();
            this.PIXELSPERINCHX = this.CreateGraphics().DpiX;
        }

        // Token: 0x060003CA RID: 970 RVA: 0x0002BAF0 File Offset: 0x00029CF0
        private void ComputerWidth()
        {
            try
            {
                string text = Strings.Format(this.GetPrintColumnSumWidth(), "#,###,###.#");
                text = "要打印的列的总宽度【" + text + "毫米】（在不自动缩放及调整的情况下）";
                this.Label79.Text = text;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x060003CB RID: 971 RVA: 0x0002BB50 File Offset: 0x00029D50
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
                return new decimal(this.myp.ConvertToMM((float)num, true));
            }
        }

        // Token: 0x060003CC RID: 972 RVA: 0x0002BBEC File Offset: 0x00029DEC
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
                if (dataGridViewColumn != null && Versioned.IsNumeric(this.NumericUpDown1.Value) && decimal.Compare(this.NumericUpDown1.Value, 0m) >= 0)
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

        // Token: 0x060003CD RID: 973 RVA: 0x0002BCC8 File Offset: 0x00029EC8
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
                PaperSize printForm = definepaper.GetPrintForm(this.currentprintname, this.papertype.Text);
                this.myw.Value = new decimal((double)printForm.Width * 2.54 / 10.0);
                this.myh.Value = new decimal((double)printForm.Height * 2.54 / 10.0);
                this.mypaperheight = this.myh.Value;
                this.mypaperwidth = this.myw.Value;
            }
        }

        // Token: 0x060003CE RID: 974 RVA: 0x0002BDD8 File Offset: 0x00029FD8
        private void Button37_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.zdxtext.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.zdxtext.Font = this.FontDialog1.Font;
                this.myZDXfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003CF RID: 975 RVA: 0x0002BE30 File Offset: 0x0002A030
        private void Button36_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myZDXtextcolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myZDXtextcolor = this.ColorDialog1.Color;
                this.zdxtext.ForeColor = this.myZDXtextcolor;
            }
        }

        // Token: 0x060003D0 RID: 976 RVA: 0x0002BE80 File Offset: 0x0002A080
        private void zdxlinecolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myZDXlinecolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myZDXlinecolor = this.ColorDialog1.Color;
                this.zdxlinecolor.ForeColor = this.myZDXlinecolor;
            }
        }

        // Token: 0x060003D1 RID: 977 RVA: 0x0002BED0 File Offset: 0x0002A0D0
        private void Button39_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myouterbordercolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myouterbordercolor = this.ColorDialog1.Color;
                this.Button39.ForeColor = this.ColorDialog1.Color;
            }
        }

        // Token: 0x060003D2 RID: 978 RVA: 0x0002BF24 File Offset: 0x0002A124
        private void zdxposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                if (Strings.Asc(e.KeyChar) != 8)
                {
                    if (String.Compare(Convert.ToString(e.KeyChar), ".", false) == 0)
                    {
                        if (Strings.InStr(((TextBox)sender).Text, ".", CompareMethod.Binary) > 0)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // Token: 0x060003D3 RID: 979 RVA: 0x0002BFAC File Offset: 0x0002A1AC
        private void gwxouterborder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.gwxouterborder.Checked)
            {
                this.Button39.Enabled = true;
                this.gwxouterborderwidth.Enabled = true;
            }
            else
            {
                this.Button39.Enabled = false;
                this.gwxouterborderwidth.Enabled = false;
            }
        }

        // Token: 0x060003D4 RID: 980 RVA: 0x0000305B File Offset: 0x0000125B
        private void kd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.kd.Checked)
            {
                this.dq.Enabled = false;
            }
            else
            {
                this.dq.Enabled = true;
            }
        }

        // Token: 0x060003D5 RID: 981 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
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

        // Token: 0x060003D6 RID: 982 RVA: 0x0002C05C File Offset: 0x0002A25C
        private void savefangan_Click(object sender, EventArgs e)
        {
            if (MyProject.Computer.FileSystem.FileExists(this.s_schemefilename))
            {
                if (Interaction.MsgBox("您确定要将当前打印设置保存到当前使用的打印方案文件【" + this.s_schemefilename + "】中？\r\n\r\n注意，这会将当前打印设置覆盖打印方案文件中原来的打印设置", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息") != MsgBoxResult.Yes)
                {
                    return;
                }
                MyProject.Computer.FileSystem.DeleteFile(this.s_schemefilename);
            }
            this.GetAlign();
            this.SaveFa(this.s_schemefilename, true);
            Interaction.MsgBox("打印方案保存成功", MsgBoxStyle.OkOnly, "提示信息");
        }

        // Token: 0x060003D7 RID: 983 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
        private void reportheaderalignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.reportheaderalignment.Text;
            HorizontalAlignment textAlign = HorizontalAlignment.Left;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Center;
                this.myreportheaderalignment = StringAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Left;
                this.myreportheaderalignment = StringAlignment.Near;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Right;
                this.myreportheaderalignment = StringAlignment.Far;
            }
            this.reportheadertext.TextAlign = textAlign;
        }

        // Token: 0x060003D8 RID: 984 RVA: 0x0002C154 File Offset: 0x0002A354
        private void reportfooteralignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.reportfooteralignment.Text;
            HorizontalAlignment textAlign = HorizontalAlignment.Left;
            if (String.Compare(text, "居中对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Center;
                this.myreportfooteralignment = StringAlignment.Center;
            }
            else if (String.Compare(text, "左对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Left;
                this.myreportfooteralignment = StringAlignment.Near;
            }
            else if (String.Compare(text, "右对齐", false) == 0)
            {
                textAlign = HorizontalAlignment.Right;
                this.myreportfooteralignment = StringAlignment.Far;
            }
            this.reportfootertext.TextAlign = textAlign;
        }

        // Token: 0x060003D9 RID: 985 RVA: 0x0002C1C8 File Offset: 0x0002A3C8
        private void reportheaderfont_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.reportheadertext.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.reportheadertext.Font = this.FontDialog1.Font;
                this.myreportheaderfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003DA RID: 986 RVA: 0x0002C220 File Offset: 0x0002A420
        private void reportfooterfont_Click(object sender, EventArgs e)
        {
            this.FontDialog1.Font = this.reportfootertext.Font;
            if (this.FontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.reportfootertext.Font = this.FontDialog1.Font;
                this.myreportfooterfont = this.FontDialog1.Font;
            }
        }

        // Token: 0x060003DB RID: 987 RVA: 0x0002C278 File Offset: 0x0002A478
        private void reportheadercolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myreportheadercolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myreportheadercolor = this.ColorDialog1.Color;
                this.reportheadertext.ForeColor = this.myreportheadercolor;
            }
        }

        // Token: 0x060003DC RID: 988 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
        private void reportfootercolor_Click(object sender, EventArgs e)
        {
            this.ColorDialog1.Color = this.myreportfootercolor;
            if (this.ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myreportfootercolor = this.ColorDialog1.Color;
                this.reportfootertext.ForeColor = this.myreportfootercolor;
            }
        }

        // Token: 0x060003DD RID: 989 RVA: 0x0002C318 File Offset: 0x0002A518
        private void Button40_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            string text = "";
            string text2 = "";
            if (String.Compare(this.tablel.Text, "", false) != 0)
            {
                text = this.tablel.Text;
            }
            if (String.Compare(this.tablem.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tablem.Text;
                }
                else
                {
                    text = text + "       " + this.tablem.Text;
                }
            }
            if (String.Compare(this.tabler.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tabler.Text;
                }
                else
                {
                    text = text + "       " + this.tabler.Text;
                }
            }
            if (String.Compare(this.tableleft.Text, "", false) != 0)
            {
                text2 = this.tableleft.Text;
            }
            if (String.Compare(this.tablemiddle.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tablemiddle.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tablemiddle.Text;
                }
            }
            if (String.Compare(this.tableright.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tableright.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tableright.Text;
                }
            }
            new ExportDataGridView
            {
                TableHeader = text,
                TableFooter = text2,
                OpenFile = true,
                FileName = "",
                Title = this.maintitle.Text,
                TitleFont = (Font)this.ztitlefont.Clone(),
                TableHeaderFont = (Font)this.mytopfont.Clone(),
                TableFooterFont = (Font)this.mybottomfont.Clone()
            }.ExportDGV(this.dgvtoprint, this.myheader, ExportDataGridView.ExportDataGridViewType.RTF);
            this.UseWaitCursor = false;
        }

        // Token: 0x060003DE RID: 990 RVA: 0x0002C54C File Offset: 0x0002A74C
        private void Button41_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            string text = "";
            string text2 = "";
            if (String.Compare(this.tablel.Text, "", false) != 0)
            {
                text = this.tablel.Text;
            }
            if (String.Compare(this.tablem.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tablem.Text;
                }
                else
                {
                    text = text + "       " + this.tablem.Text;
                }
            }
            if (String.Compare(this.tabler.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tabler.Text;
                }
                else
                {
                    text = text + "       " + this.tabler.Text;
                }
            }
            if (String.Compare(this.tableleft.Text, "", false) != 0)
            {
                text2 = this.tableleft.Text;
            }
            if (String.Compare(this.tablemiddle.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tablemiddle.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tablemiddle.Text;
                }
            }
            if (String.Compare(this.tableright.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tableright.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tableright.Text;
                }
            }
            new ExportDataGridView
            {
                TableHeader = text,
                TableFooter = text2,
                FileName = "",
                OpenFile = true,
                Title = this.maintitle.Text,
                TitleFont = (Font)this.ztitlefont.Clone(),
                TableHeaderFont = (Font)this.mytopfont.Clone(),
                TableFooterFont = (Font)this.mybottomfont.Clone()
            }.ExportDGV(this.dgvtoprint, this.myheader, ExportDataGridView.ExportDataGridViewType.HTML);
            this.UseWaitCursor = false;
        }

        // Token: 0x060003DF RID: 991 RVA: 0x0002C780 File Offset: 0x0002A980
        private void Button42_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            string text = "";
            string text2 = "";
            if (String.Compare(this.tablel.Text, "", false) != 0)
            {
                text = this.tablel.Text;
            }
            if (String.Compare(this.tablem.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tablem.Text;
                }
                else
                {
                    text = text + "       " + this.tablem.Text;
                }
            }
            if (String.Compare(this.tabler.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tabler.Text;
                }
                else
                {
                    text = text + "       " + this.tabler.Text;
                }
            }
            if (String.Compare(this.tableleft.Text, "", false) != 0)
            {
                text2 = this.tableleft.Text;
            }
            if (String.Compare(this.tablemiddle.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tablemiddle.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tablemiddle.Text;
                }
            }
            if (String.Compare(this.tableright.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tableright.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tableright.Text;
                }
            }
            ExportDataGridView exportDGV = new ExportDataGridView();
            exportDGV.TableHeader = text;
            exportDGV.TableFooter = text2;
            exportDGV.FileName = "";
            exportDGV.OpenFile = true;
            exportDGV.Title = this.maintitle.Text;
            exportDGV.TitleFont = (Font)this.ztitlefont.Clone();
            exportDGV.TableHeaderFont = (Font)this.mytopfont.Clone();
            exportDGV.TableFooterFont = (Font)this.mybottomfont.Clone();
            exportDGV.PaperHeight = Convert.ToSingle(this.myh.Value);
            exportDGV.PaperWidth = Convert.ToSingle(this.myw.Value);
            exportDGV.PaperMargin = new Margins(Convert.ToInt32(this.pagemarginl.Text), Convert.ToInt32(this.pagemarginr.Text), Convert.ToInt32(this.pagemargint.Text), Convert.ToInt32(this.pagemarginb.Text));
            if (String.Compare(this.fx.Text, "纵向", false) == 0)
            {
                exportDGV.PaperLandScape = false;
            }
            else
            {
                exportDGV.PaperLandScape = true;
            }
            exportDGV.ExportDGV(this.dgvtoprint, this.myheader,  ExportDataGridView.ExportDataGridViewType.PDF);
            this.UseWaitCursor = false;
        }

        // Token: 0x060003E0 RID: 992 RVA: 0x0002CA54 File Offset: 0x0002AC54
        private void exportexcel2_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            string text = "";
            string text2 = "";
            if (String.Compare(this.tablel.Text, "", false) != 0)
            {
                text = this.tablel.Text;
            }
            if (String.Compare(this.tablem.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tablem.Text;
                }
                else
                {
                    text = text + "       " + this.tablem.Text;
                }
            }
            if (String.Compare(this.tabler.Text, "", false) != 0)
            {
                if (String.Compare(text, "", false) == 0)
                {
                    text = this.tabler.Text;
                }
                else
                {
                    text = text + "       " + this.tabler.Text;
                }
            }
            if (String.Compare(this.tableleft.Text, "", false) != 0)
            {
                text2 = this.tableleft.Text;
            }
            if (String.Compare(this.tablemiddle.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tablemiddle.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tablemiddle.Text;
                }
            }
            if (String.Compare(this.tableright.Text, "", false) != 0)
            {
                if (String.Compare(text2, "", false) == 0)
                {
                    text2 = this.tableright.Text;
                }
                else
                {
                    text2 = text2 + "       " + this.tableright.Text;
                }
            }
            new ExportDataGridView
            {
                TableHeader = text,
                TableFooter = text2,
                FileName = "",
                OpenFile = true,
                Title = this.maintitle.Text,
                TitleFont = (Font)this.ztitlefont.Clone(),
                TableHeaderFont = (Font)this.mytopfont.Clone(),
                TableFooterFont = (Font)this.mybottomfont.Clone()
            }.ExportDGV(this.dgvtoprint, this.myheader, ExportDataGridView.ExportDataGridViewType.Excel2007);
            this.UseWaitCursor = false;
        }

        // Token: 0x04000110 RID: 272
        [AccessedThroughProperty("GroupBoxtablestyle")]
        private GroupBox _GroupBoxtablestyle;

        // Token: 0x04000111 RID: 273
        [AccessedThroughProperty("R4")]
        private RadioButton _R4;

        // Token: 0x04000112 RID: 274
        [AccessedThroughProperty("R3")]
        private RadioButton _R3;

        // Token: 0x04000113 RID: 275
        [AccessedThroughProperty("R2")]
        private RadioButton _R2;

        // Token: 0x04000114 RID: 276
        [AccessedThroughProperty("R1")]
        private RadioButton _R1;

        // Token: 0x04000115 RID: 277
        [AccessedThroughProperty("FontDialog1")]
        private FontDialog _FontDialog1;

        // Token: 0x04000116 RID: 278
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000117 RID: 279
        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        // Token: 0x04000118 RID: 280
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000119 RID: 281
        [AccessedThroughProperty("dq")]
        private ComboBox _dq;

        // Token: 0x0400011A RID: 282
        [AccessedThroughProperty("bk")]
        private ComboBox _bk;

        // Token: 0x0400011B RID: 283
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x0400011C RID: 284
        [AccessedThroughProperty("fx")]
        private ComboBox _fx;

        // Token: 0x0400011D RID: 285
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x0400011E RID: 286
        [AccessedThroughProperty("minsize")]
        private ComboBox _minsize;

        // Token: 0x0400011F RID: 287
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x04000120 RID: 288
        [AccessedThroughProperty("bj")]
        private CheckBox _bj;

        // Token: 0x04000121 RID: 289
        [AccessedThroughProperty("bt")]
        private CheckBox _bt;

        // Token: 0x04000122 RID: 290
        [AccessedThroughProperty("gd")]
        private CheckBox _gd;

        // Token: 0x04000123 RID: 291
        [AccessedThroughProperty("kd")]
        private CheckBox _kd;

        // Token: 0x04000124 RID: 292
        [AccessedThroughProperty("gz")]
        private GroupBox _gz;

        // Token: 0x04000125 RID: 293
        [AccessedThroughProperty("fl")]
        private GroupBox _fl;

        // Token: 0x04000126 RID: 294
        [AccessedThroughProperty("gzjj")]
        private NumericUpDown _gzjj;

        // Token: 0x04000127 RID: 295
        [AccessedThroughProperty("lz")]
        private CheckBox _lz;

        // Token: 0x04000128 RID: 296
        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        // Token: 0x04000129 RID: 297
        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        // Token: 0x0400012A RID: 298
        [AccessedThroughProperty("zh")]
        private CheckBox _zh;

        // Token: 0x0400012B RID: 299
        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        // Token: 0x0400012C RID: 300
        [AccessedThroughProperty("ljj")]
        private NumericUpDown _ljj;

        // Token: 0x0400012D RID: 301
        [AccessedThroughProperty("ls")]
        private ComboBox _ls;

        // Token: 0x0400012E RID: 302
        [AccessedThroughProperty("fy")]
        private GroupBox _fy;

        // Token: 0x0400012F RID: 303
        [AccessedThroughProperty("columns")]
        private ComboBox _columns;

        // Token: 0x04000130 RID: 304
        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        // Token: 0x04000131 RID: 305
        [AccessedThroughProperty("dgvtoprint")]
        private DataGridView _dgvtoprint;

        // Token: 0x04000132 RID: 306
        [AccessedThroughProperty("gsf")]
        private CheckBox _gsf;

        // Token: 0x04000133 RID: 307
        [AccessedThroughProperty("GroupBoxheader2")]
        private GroupBox _GroupBoxheader2;

        // Token: 0x04000134 RID: 308
        [AccessedThroughProperty("Button7")]
        private Button _Button7;

        // Token: 0x04000135 RID: 309
        [AccessedThroughProperty("pageright")]
        private TextBox _pageright;

        // Token: 0x04000136 RID: 310
        [AccessedThroughProperty("pagemiddle")]
        private TextBox _pagemiddle;

        // Token: 0x04000137 RID: 311
        [AccessedThroughProperty("pageleft")]
        private TextBox _pageleft;

        // Token: 0x04000138 RID: 312
        [AccessedThroughProperty("Label17")]
        private Label _Label17;

        // Token: 0x04000139 RID: 313
        [AccessedThroughProperty("Label18")]
        private Label _Label18;

        // Token: 0x0400013A RID: 314
        [AccessedThroughProperty("Label19")]
        private Label _Label19;

        // Token: 0x0400013B RID: 315
        [AccessedThroughProperty("GroupBoxheader1")]
        private GroupBox _GroupBoxheader1;

        // Token: 0x0400013C RID: 316
        [AccessedThroughProperty("Button8")]
        private Button _Button8;

        // Token: 0x0400013D RID: 317
        [AccessedThroughProperty("pager")]
        private TextBox _pager;

        // Token: 0x0400013E RID: 318
        [AccessedThroughProperty("pagem")]
        private TextBox _pagem;

        // Token: 0x0400013F RID: 319
        [AccessedThroughProperty("pagel")]
        private TextBox _pagel;

        // Token: 0x04000140 RID: 320
        [AccessedThroughProperty("Label20")]
        private Label _Label20;

        // Token: 0x04000141 RID: 321
        [AccessedThroughProperty("Label21")]
        private Label _Label21;

        // Token: 0x04000142 RID: 322
        [AccessedThroughProperty("Label22")]
        private Label _Label22;

        // Token: 0x04000143 RID: 323
        [AccessedThroughProperty("pt")]
        private GroupBox _pt;

        // Token: 0x04000144 RID: 324
        [AccessedThroughProperty("Label23")]
        private Label _Label23;

        // Token: 0x04000145 RID: 325
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;

        // Token: 0x04000146 RID: 326
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;

        // Token: 0x04000147 RID: 327
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;

        // Token: 0x04000148 RID: 328
        [AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;

        // Token: 0x04000149 RID: 329
        [AccessedThroughProperty("Button9")]
        private Button _Button9;

        // Token: 0x0400014A RID: 330
        [AccessedThroughProperty("C1")]
        private CheckedListBox _C1;

        // Token: 0x0400014B RID: 331
        [AccessedThroughProperty("fontshow")]
        private Label _fontshow;

        // Token: 0x0400014C RID: 332
        [AccessedThroughProperty("headerfont")]
        private Label _headerfont;

        // Token: 0x0400014D RID: 333
        [AccessedThroughProperty("Label26")]
        private Label _Label26;

        // Token: 0x0400014E RID: 334
        [AccessedThroughProperty("GroupBoxxx1")]
        private GroupBox _GroupBoxxx1;

        // Token: 0x0400014F RID: 335
        [AccessedThroughProperty("ml")]
        private ComboBox _ml;

        // Token: 0x04000150 RID: 336
        [AccessedThroughProperty("ldq")]
        private ComboBox _ldq;

        // Token: 0x04000151 RID: 337
        [AccessedThroughProperty("Button10")]
        private Button _Button10;

        // Token: 0x04000152 RID: 338
        [AccessedThroughProperty("Label27")]
        private Label _Label27;

        // Token: 0x04000153 RID: 339
        [AccessedThroughProperty("Label28")]
        private Label _Label28;

        // Token: 0x04000154 RID: 340
        [AccessedThroughProperty("Button11")]
        private Button _Button11;

        // Token: 0x04000155 RID: 341
        [AccessedThroughProperty("columnfont")]
        private Label _columnfont;

        // Token: 0x04000156 RID: 342
        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        // Token: 0x04000157 RID: 343
        [AccessedThroughProperty("Button13")]
        private Button _Button13;

        // Token: 0x04000158 RID: 344
        [AccessedThroughProperty("Button12")]
        private Button _Button12;

        // Token: 0x04000159 RID: 345
        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _ColorDialog1;

        // Token: 0x0400015A RID: 346
        [AccessedThroughProperty("GroupBoxxx3")]
        private GroupBox _GroupBoxxx3;

        // Token: 0x0400015B RID: 347
        [AccessedThroughProperty("Button14")]
        private Button _Button14;

        // Token: 0x0400015C RID: 348
        [AccessedThroughProperty("GroupBoxxx2")]
        private GroupBox _GroupBoxxx2;

        // Token: 0x0400015D RID: 349
        [AccessedThroughProperty("Button15")]
        private Button _Button15;

        // Token: 0x0400015E RID: 350
        [AccessedThroughProperty("Button16")]
        private Button _Button16;

        // Token: 0x0400015F RID: 351
        [AccessedThroughProperty("Button17")]
        private Button _Button17;

        // Token: 0x04000160 RID: 352
        [AccessedThroughProperty("GroupBox13")]
        private GroupBox _GroupBox13;

        // Token: 0x04000161 RID: 353
        [AccessedThroughProperty("Button19")]
        private Button _Button19;

        // Token: 0x04000162 RID: 354
        [AccessedThroughProperty("Button18")]
        private Button _Button18;

        // Token: 0x04000163 RID: 355
        [AccessedThroughProperty("Button20")]
        private Button _Button20;

        // Token: 0x04000164 RID: 356
        [AccessedThroughProperty("Button21")]
        private Button _Button21;

        // Token: 0x04000165 RID: 357
        [AccessedThroughProperty("Button23")]
        private Button _Button23;

        // Token: 0x04000166 RID: 358
        [AccessedThroughProperty("papertype")]
        private ComboBox _papertype;

        // Token: 0x04000167 RID: 359
        [AccessedThroughProperty("Label46")]
        private Label _Label46;

        // Token: 0x04000168 RID: 360
        [AccessedThroughProperty("GroupBox14")]
        private GroupBox _GroupBox14;

        // Token: 0x04000169 RID: 361
        [AccessedThroughProperty("pagemarginl")]
        private TextBox _pagemarginl;

        // Token: 0x0400016A RID: 362
        [AccessedThroughProperty("Label47")]
        private Label _Label47;

        // Token: 0x0400016B RID: 363
        [AccessedThroughProperty("pagemarginb")]
        private TextBox _pagemarginb;

        // Token: 0x0400016C RID: 364
        [AccessedThroughProperty("pagemargint")]
        private TextBox _pagemargint;

        // Token: 0x0400016D RID: 365
        [AccessedThroughProperty("Label50")]
        private Label _Label50;

        // Token: 0x0400016E RID: 366
        [AccessedThroughProperty("pagemarginr")]
        private TextBox _pagemarginr;

        // Token: 0x0400016F RID: 367
        [AccessedThroughProperty("Label49")]
        private Label _Label49;

        // Token: 0x04000170 RID: 368
        [AccessedThroughProperty("Label48")]
        private Label _Label48;

        // Token: 0x04000171 RID: 369
        [AccessedThroughProperty("Button24")]
        private Button _Button24;

        // Token: 0x04000172 RID: 370
        [AccessedThroughProperty("Button25")]
        private Button _Button25;

        // Token: 0x04000173 RID: 371
        [AccessedThroughProperty("TabPage5")]
        private TabPage _TabPage5;

        // Token: 0x04000174 RID: 372
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000175 RID: 373
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000176 RID: 374
        [AccessedThroughProperty("Button22")]
        private Button _Button22;

        // Token: 0x04000177 RID: 375
        [AccessedThroughProperty("subtitle")]
        private TextBox _subtitle;

        // Token: 0x04000178 RID: 376
        [AccessedThroughProperty("maintitle")]
        private TextBox _maintitle;

        // Token: 0x04000179 RID: 377
        [AccessedThroughProperty("GroupBoxtitle3")]
        private GroupBox _GroupBoxtitle3;

        // Token: 0x0400017A RID: 378
        [AccessedThroughProperty("Button5")]
        private Button _Button5;

        // Token: 0x0400017B RID: 379
        [AccessedThroughProperty("tabler")]
        private TextBox _tabler;

        // Token: 0x0400017C RID: 380
        [AccessedThroughProperty("tablem")]
        private TextBox _tablem;

        // Token: 0x0400017D RID: 381
        [AccessedThroughProperty("tablel")]
        private TextBox _tablel;

        // Token: 0x0400017E RID: 382
        [AccessedThroughProperty("Label13")]
        private Label _Label13;

        // Token: 0x0400017F RID: 383
        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        // Token: 0x04000180 RID: 384
        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        // Token: 0x04000181 RID: 385
        [AccessedThroughProperty("GroupBoxtitle4")]
        private GroupBox _GroupBoxtitle4;

        // Token: 0x04000182 RID: 386
        [AccessedThroughProperty("Button6")]
        private Button _Button6;

        // Token: 0x04000183 RID: 387
        [AccessedThroughProperty("tableright")]
        private TextBox _tableright;

        // Token: 0x04000184 RID: 388
        [AccessedThroughProperty("tablemiddle")]
        private TextBox _tablemiddle;

        // Token: 0x04000185 RID: 389
        [AccessedThroughProperty("tableleft")]
        private TextBox _tableleft;

        // Token: 0x04000186 RID: 390
        [AccessedThroughProperty("Label14")]
        private Label _Label14;

        // Token: 0x04000187 RID: 391
        [AccessedThroughProperty("Label15")]
        private Label _Label15;

        // Token: 0x04000188 RID: 392
        [AccessedThroughProperty("Label16")]
        private Label _Label16;

        // Token: 0x04000189 RID: 393
        [AccessedThroughProperty("zys")]
        private ComboBox _zys;

        // Token: 0x0400018A RID: 394
        [AccessedThroughProperty("Label54")]
        private Label _Label54;

        // Token: 0x0400018B RID: 395
        [AccessedThroughProperty("fys")]
        private ComboBox _fys;

        // Token: 0x0400018C RID: 396
        [AccessedThroughProperty("Label55")]
        private Label _Label55;

        // Token: 0x0400018D RID: 397
        [AccessedThroughProperty("GroupBoxheader3")]
        private GroupBox _GroupBoxheader3;

        // Token: 0x0400018E RID: 398
        [AccessedThroughProperty("Button28")]
        private Button _Button28;

        // Token: 0x0400018F RID: 399
        [AccessedThroughProperty("Button29")]
        private Button _Button29;

        // Token: 0x04000190 RID: 400
        [AccessedThroughProperty("rightb")]
        private TextBox _rightb;

        // Token: 0x04000191 RID: 401
        [AccessedThroughProperty("rightm")]
        private TextBox _rightm;

        // Token: 0x04000192 RID: 402
        [AccessedThroughProperty("rightt")]
        private TextBox _rightt;

        // Token: 0x04000193 RID: 403
        [AccessedThroughProperty("Label56")]
        private Label _Label56;

        // Token: 0x04000194 RID: 404
        [AccessedThroughProperty("Label57")]
        private Label _Label57;

        // Token: 0x04000195 RID: 405
        [AccessedThroughProperty("Label58")]
        private Label _Label58;

        // Token: 0x04000196 RID: 406
        [AccessedThroughProperty("Button30")]
        private Button _Button30;

        // Token: 0x04000197 RID: 407
        [AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;

        // Token: 0x04000198 RID: 408
        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;

        // Token: 0x04000199 RID: 409
        [AccessedThroughProperty("exportexcel")]
        private Button _exportexcel;

        // Token: 0x0400019A RID: 410
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;

        // Token: 0x0400019B RID: 411
        [AccessedThroughProperty("TabPage6")]
        private TabPage _TabPage6;

        // Token: 0x0400019C RID: 412
        [AccessedThroughProperty("GroupBox17")]
        private GroupBox _GroupBox17;

        // Token: 0x0400019D RID: 413
        [AccessedThroughProperty("bbackcolor")]
        private Button _bbackcolor;

        // Token: 0x0400019E RID: 414
        [AccessedThroughProperty("jsh")]
        private Label _jsh;

        // Token: 0x0400019F RID: 415
        [AccessedThroughProperty("bforecolor")]
        private Button _bforecolor;

        // Token: 0x040001A0 RID: 416
        [AccessedThroughProperty("Cbackcolor")]
        private CheckBox _Cbackcolor;

        // Token: 0x040001A1 RID: 417
        [AccessedThroughProperty("Cforecolor")]
        private CheckBox _Cforecolor;

        // Token: 0x040001A2 RID: 418
        [AccessedThroughProperty("hz")]
        private CheckedListBox _hz;

        // Token: 0x040001A3 RID: 419
        [AccessedThroughProperty("GroupBox18")]
        private GroupBox _GroupBox18;

        // Token: 0x040001A4 RID: 420
        [AccessedThroughProperty("Button33")]
        private Button _Button33;

        // Token: 0x040001A5 RID: 421
        [AccessedThroughProperty("hzfontshow")]
        private Label _hzfontshow;

        // Token: 0x040001A6 RID: 422
        [AccessedThroughProperty("Button34")]
        private Button _Button34;

        // Token: 0x040001A7 RID: 423
        [AccessedThroughProperty("Button35")]
        private Button _Button35;

        // Token: 0x040001A8 RID: 424
        [AccessedThroughProperty("GroupBoxhz")]
        private GroupBox _GroupBoxhz;

        // Token: 0x040001A9 RID: 425
        [AccessedThroughProperty("GroupBoxgroup")]
        private GroupBox _GroupBoxgroup;

        // Token: 0x040001AA RID: 426
        [AccessedThroughProperty("GroupBox21")]
        private GroupBox _GroupBox21;

        // Token: 0x040001AB RID: 427
        [AccessedThroughProperty("Label61")]
        private Label _Label61;

        // Token: 0x040001AC RID: 428
        [AccessedThroughProperty("Label59")]
        private Label _Label59;

        // Token: 0x040001AD RID: 429
        [AccessedThroughProperty("GroupBox23")]
        private GroupBox _GroupBox23;

        // Token: 0x040001AE RID: 430
        [AccessedThroughProperty("groupcolumn")]
        private ComboBox _groupcolumn;

        // Token: 0x040001AF RID: 431
        [AccessedThroughProperty("GroupBox22")]
        private GroupBox _GroupBox22;

        // Token: 0x040001B0 RID: 432
        [AccessedThroughProperty("sortd")]
        private RadioButton _sortd;

        // Token: 0x040001B1 RID: 433
        [AccessedThroughProperty("sorta")]
        private RadioButton _sorta;

        // Token: 0x040001B2 RID: 434
        [AccessedThroughProperty("sortcolumn")]
        private ComboBox _sortcolumn;

        // Token: 0x040001B3 RID: 435
        [AccessedThroughProperty("addrownew")]
        private CheckBox _addrownew;

        // Token: 0x040001B4 RID: 436
        [AccessedThroughProperty("addrowid")]
        private CheckBox _addrowid;

        // Token: 0x040001B5 RID: 437
        [AccessedThroughProperty("groupnewpage")]
        private CheckBox _groupnewpage;

        // Token: 0x040001B6 RID: 438
        [AccessedThroughProperty("Label64")]
        private Label _Label64;

        // Token: 0x040001B7 RID: 439
        [AccessedThroughProperty("Button32")]
        private Button _Button32;

        // Token: 0x040001B8 RID: 440
        [AccessedThroughProperty("sumalign")]
        private ComboBox _sumalign;

        // Token: 0x040001B9 RID: 441
        [AccessedThroughProperty("Label66")]
        private Label _Label66;

        // Token: 0x040001BA RID: 442
        [AccessedThroughProperty("tabletopleftalign")]
        private ComboBox _tabletopleftalign;

        // Token: 0x040001BB RID: 443
        [AccessedThroughProperty("Label67")]
        private Label _Label67;

        // Token: 0x040001BC RID: 444
        [AccessedThroughProperty("tablebottomleftalign")]
        private ComboBox _tablebottomleftalign;

        // Token: 0x040001BD RID: 445
        [AccessedThroughProperty("Label68")]
        private Label _Label68;

        // Token: 0x040001BE RID: 446
        [AccessedThroughProperty("tabletoprightalign")]
        private ComboBox _tabletoprightalign;

        // Token: 0x040001BF RID: 447
        [AccessedThroughProperty("tabletopmiddlealign")]
        private ComboBox _tabletopmiddlealign;

        // Token: 0x040001C0 RID: 448
        [AccessedThroughProperty("tablebottomrightalign")]
        private ComboBox _tablebottomrightalign;

        // Token: 0x040001C1 RID: 449
        [AccessedThroughProperty("tablebottommiddlealign")]
        private ComboBox _tablebottommiddlealign;

        // Token: 0x040001C2 RID: 450
        [AccessedThroughProperty("drawfooter")]
        private CheckBox _drawfooter;

        // Token: 0x040001C3 RID: 451
        [AccessedThroughProperty("drawheader")]
        private CheckBox _drawheader;

        // Token: 0x040001C4 RID: 452
        [AccessedThroughProperty("autoaddrow")]
        private CheckBox _autoaddrow;

        // Token: 0x040001C5 RID: 453
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;

        // Token: 0x040001C6 RID: 454
        [AccessedThroughProperty("NumericUpDown1")]
        private NumericUpDown _NumericUpDown1;

        // Token: 0x040001C7 RID: 455
        [AccessedThroughProperty("Label78")]
        private Label _Label78;

        // Token: 0x040001C8 RID: 456
        [AccessedThroughProperty("Label79")]
        private Label _Label79;

        // Token: 0x040001C9 RID: 457
        [AccessedThroughProperty("GroupBox24")]
        private GroupBox _GroupBox24;

        // Token: 0x040001CA RID: 458
        [AccessedThroughProperty("myh")]
        private NumericUpDown _myh;

        // Token: 0x040001CB RID: 459
        [AccessedThroughProperty("Label81")]
        private Label _Label81;

        // Token: 0x040001CC RID: 460
        [AccessedThroughProperty("myw")]
        private NumericUpDown _myw;

        // Token: 0x040001CD RID: 461
        [AccessedThroughProperty("Label82")]
        private Label _Label82;

        // Token: 0x040001CE RID: 462
        [AccessedThroughProperty("TabPage7")]
        private TabPage _TabPage7;

        // Token: 0x040001CF RID: 463
        [AccessedThroughProperty("Button36")]
        private Button _Button36;

        // Token: 0x040001D0 RID: 464
        [AccessedThroughProperty("Button37")]
        private Button _Button37;

        // Token: 0x040001D1 RID: 465
        [AccessedThroughProperty("isdrawzdx")]
        private CheckBox _isdrawzdx;

        // Token: 0x040001D2 RID: 466
        [AccessedThroughProperty("Label83")]
        private Label _Label83;

        // Token: 0x040001D3 RID: 467
        [AccessedThroughProperty("zdxlinecolor")]
        private Button _zdxlinecolor;

        // Token: 0x040001D4 RID: 468
        [AccessedThroughProperty("GroupBoxwater")]
        private GroupBox _GroupBoxwater;

        // Token: 0x040001D5 RID: 469
        [AccessedThroughProperty("sytm")]
        private NumericUpDown _sytm;

        // Token: 0x040001D6 RID: 470
        [AccessedThroughProperty("Button26")]
        private Button _Button26;

        // Token: 0x040001D7 RID: 471
        [AccessedThroughProperty("Button27")]
        private Button _Button27;

        // Token: 0x040001D8 RID: 472
        [AccessedThroughProperty("syfx")]
        private ComboBox _syfx;

        // Token: 0x040001D9 RID: 473
        [AccessedThroughProperty("sytext")]
        private TextBox _sytext;

        // Token: 0x040001DA RID: 474
        [AccessedThroughProperty("Label53")]
        private Label _Label53;

        // Token: 0x040001DB RID: 475
        [AccessedThroughProperty("Label52")]
        private Label _Label52;

        // Token: 0x040001DC RID: 476
        [AccessedThroughProperty("GroupBoxZDX")]
        private GroupBox _GroupBoxZDX;

        // Token: 0x040001DD RID: 477
        [AccessedThroughProperty("GroupBoxzdx1")]
        private GroupBox _GroupBoxzdx1;

        // Token: 0x040001DE RID: 478
        [AccessedThroughProperty("Label88")]
        private Label _Label88;

        // Token: 0x040001DF RID: 479
        [AccessedThroughProperty("GroupBoxzdx3")]
        private GroupBox _GroupBoxzdx3;

        // Token: 0x040001E0 RID: 480
        [AccessedThroughProperty("GroupBoxzdx2")]
        private GroupBox _GroupBoxzdx2;

        // Token: 0x040001E1 RID: 481
        [AccessedThroughProperty("zdxtext")]
        private TextBox _zdxtext;

        // Token: 0x040001E2 RID: 482
        [AccessedThroughProperty("zdxtype_bottom")]
        private RadioButton _zdxtype_bottom;

        // Token: 0x040001E3 RID: 483
        [AccessedThroughProperty("zdxtype_right")]
        private RadioButton _zdxtype_right;

        // Token: 0x040001E4 RID: 484
        [AccessedThroughProperty("zdxtype_top")]
        private RadioButton _zdxtype_top;

        // Token: 0x040001E5 RID: 485
        [AccessedThroughProperty("zdxtype_left")]
        private RadioButton _zdxtype_left;

        // Token: 0x040001E6 RID: 486
        [AccessedThroughProperty("zdx_dashdotdot")]
        private RadioButton _zdx_dashdotdot;

        // Token: 0x040001E7 RID: 487
        [AccessedThroughProperty("zdx_dashdot")]
        private RadioButton _zdx_dashdot;

        // Token: 0x040001E8 RID: 488
        [AccessedThroughProperty("zdx_dot")]
        private RadioButton _zdx_dot;

        // Token: 0x040001E9 RID: 489
        [AccessedThroughProperty("zdx_dash")]
        private RadioButton _zdx_dash;

        // Token: 0x040001EA RID: 490
        [AccessedThroughProperty("zdx_solid")]
        private RadioButton _zdx_solid;

        // Token: 0x040001EB RID: 491
        [AccessedThroughProperty("zdxposition")]
        private TextBox _zdxposition;

        // Token: 0x040001EC RID: 492
        [AccessedThroughProperty("rowheight")]
        private NumericUpDown _rowheight;

        // Token: 0x040001ED RID: 493
        [AccessedThroughProperty("Label24")]
        private Label _Label24;

        // Token: 0x040001EE RID: 494
        [AccessedThroughProperty("Button39")]
        private Button _Button39;

        // Token: 0x040001EF RID: 495
        [AccessedThroughProperty("gwxouterborderwidth")]
        private TextBox _gwxouterborderwidth;

        // Token: 0x040001F0 RID: 496
        [AccessedThroughProperty("gwxdoublinespace")]
        private TextBox _gwxdoublinespace;

        // Token: 0x040001F1 RID: 497
        [AccessedThroughProperty("Label89")]
        private Label _Label89;

        // Token: 0x040001F2 RID: 498
        [AccessedThroughProperty("Label85")]
        private Label _Label85;

        // Token: 0x040001F3 RID: 499
        [AccessedThroughProperty("gwxdoubleline")]
        private CheckBox _gwxdoubleline;

        // Token: 0x040001F4 RID: 500
        [AccessedThroughProperty("gwxouterborder")]
        private CheckBox _gwxouterborder;

        // Token: 0x040001F5 RID: 501
        [AccessedThroughProperty("Label90")]
        private Label _Label90;

        // Token: 0x040001F6 RID: 502
        [AccessedThroughProperty("GroupBoxtitle2")]
        private GroupBox _GroupBoxtitle2;

        // Token: 0x040001F7 RID: 503
        [AccessedThroughProperty("GroupBoxtitle1")]
        private GroupBox _GroupBoxtitle1;

        // Token: 0x040001F8 RID: 504
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x040001F9 RID: 505
        [AccessedThroughProperty("yj")]
        private CheckBox _yj;

        // Token: 0x040001FA RID: 506
        [AccessedThroughProperty("GroupBox31")]
        private GroupBox _GroupBox31;

        // Token: 0x040001FB RID: 507
        [AccessedThroughProperty("GroupBox11")]
        private GroupBox _GroupBox11;

        // Token: 0x040001FC RID: 508
        [AccessedThroughProperty("cbottom")]
        private TextBox _cbottom;

        // Token: 0x040001FD RID: 509
        [AccessedThroughProperty("ctop")]
        private TextBox _ctop;

        // Token: 0x040001FE RID: 510
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x040001FF RID: 511
        [AccessedThroughProperty("cright")]
        private TextBox _cright;

        // Token: 0x04000200 RID: 512
        [AccessedThroughProperty("Label25")]
        private Label _Label25;

        // Token: 0x04000201 RID: 513
        [AccessedThroughProperty("cleft")]
        private TextBox _cleft;

        // Token: 0x04000202 RID: 514
        [AccessedThroughProperty("Label29")]
        private Label _Label29;

        // Token: 0x04000203 RID: 515
        [AccessedThroughProperty("Label30")]
        private Label _Label30;

        // Token: 0x04000204 RID: 516
        [AccessedThroughProperty("savefangan")]
        private Button _savefangan;

        // Token: 0x04000205 RID: 517
        [AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;

        // Token: 0x04000206 RID: 518
        [AccessedThroughProperty("SplitContainer1")]
        private SplitContainer _SplitContainer1;

        // Token: 0x04000207 RID: 519
        [AccessedThroughProperty("GroupBoxpaper")]
        private GroupBox _GroupBoxpaper;

        // Token: 0x04000208 RID: 520
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        // Token: 0x04000209 RID: 521
        [AccessedThroughProperty("TabPage8")]
        private TabPage _TabPage8;

        // Token: 0x0400020A RID: 522
        [AccessedThroughProperty("GroupBox4")]
        private GroupBox _GroupBox4;

        // Token: 0x0400020B RID: 523
        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        // Token: 0x0400020C RID: 524
        [AccessedThroughProperty("reportfooterspace")]
        private NumericUpDown _reportfooterspace;

        // Token: 0x0400020D RID: 525
        [AccessedThroughProperty("Label35")]
        private Label _Label35;

        // Token: 0x0400020E RID: 526
        [AccessedThroughProperty("reportfootercolor")]
        private Button _reportfootercolor;

        // Token: 0x0400020F RID: 527
        [AccessedThroughProperty("reportfooterfont")]
        private Button _reportfooterfont;

        // Token: 0x04000210 RID: 528
        [AccessedThroughProperty("reportfootertext")]
        private TextBox _reportfootertext;

        // Token: 0x04000211 RID: 529
        [AccessedThroughProperty("Label36")]
        private Label _Label36;

        // Token: 0x04000212 RID: 530
        [AccessedThroughProperty("Label37")]
        private Label _Label37;

        // Token: 0x04000213 RID: 531
        [AccessedThroughProperty("Label38")]
        private Label _Label38;

        // Token: 0x04000214 RID: 532
        [AccessedThroughProperty("reportfooteralignment")]
        private ComboBox _reportfooteralignment;

        // Token: 0x04000215 RID: 533
        [AccessedThroughProperty("reportheaderspace")]
        private NumericUpDown _reportheaderspace;

        // Token: 0x04000216 RID: 534
        [AccessedThroughProperty("Label34")]
        private Label _Label34;

        // Token: 0x04000217 RID: 535
        [AccessedThroughProperty("reportheadercolor")]
        private Button _reportheadercolor;

        // Token: 0x04000218 RID: 536
        [AccessedThroughProperty("reportheaderfont")]
        private Button _reportheaderfont;

        // Token: 0x04000219 RID: 537
        [AccessedThroughProperty("reportheadertext")]
        private TextBox _reportheadertext;

        // Token: 0x0400021A RID: 538
        [AccessedThroughProperty("Label33")]
        private Label _Label33;

        // Token: 0x0400021B RID: 539
        [AccessedThroughProperty("Label32")]
        private Label _Label32;

        // Token: 0x0400021C RID: 540
        [AccessedThroughProperty("Label31")]
        private Label _Label31;

        // Token: 0x0400021D RID: 541
        [AccessedThroughProperty("reportheaderalignment")]
        private ComboBox _reportheaderalignment;

        // Token: 0x0400021E RID: 542
        [AccessedThroughProperty("Label39")]
        private Label _Label39;

        // Token: 0x0400021F RID: 543
        [AccessedThroughProperty("gzwrap")]
        private CheckBox _gzwrap;

        // Token: 0x04000220 RID: 544
        [AccessedThroughProperty("exporthtml")]
        private Button _exporthtml;

        // Token: 0x04000221 RID: 545
        [AccessedThroughProperty("exportrtf")]
        private Button _exportrtf;

        // Token: 0x04000222 RID: 546
        [AccessedThroughProperty("exportpdf")]
        private Button _exportpdf;

        // Token: 0x04000223 RID: 547
        [AccessedThroughProperty("exportexcel2")]
        private Button _exportexcel2;

        // Token: 0x04000224 RID: 548
        private float PIXELSPERINCHX;

        // Token: 0x04000225 RID: 549
        public bool PaperLandscape;

        // Token: 0x04000226 RID: 550
        public string ztitle;

        // Token: 0x04000227 RID: 551
        public string ftitle;

        // Token: 0x04000228 RID: 552
        public Font ztitlefont;

        // Token: 0x04000229 RID: 553
        public Font ftitlefont;

        // Token: 0x0400022A RID: 554
        public int printtype;

        // Token: 0x0400022B RID: 555
        public StringAlignment bgalignment;

        // Token: 0x0400022C RID: 556
        public bool zoomtopaperwidth;

        // Token: 0x0400022D RID: 557
        public bool autoresizerowheight;

        // Token: 0x0400022E RID: 558
        public float minfontsize;

        // Token: 0x0400022F RID: 559
        public bool reppagetitle;

        // Token: 0x04000230 RID: 560
        public bool printbackcolor;

        // Token: 0x04000231 RID: 561
        public string myborder;

        // Token: 0x04000232 RID: 562
        public float linespace;

        // Token: 0x04000233 RID: 563
        public bool printzero;

        // Token: 0x04000234 RID: 564
        public bool autowrap;

        // Token: 0x04000235 RID: 565
        public int mycolumns;

        // Token: 0x04000236 RID: 566
        public float columnspace;

        // Token: 0x04000237 RID: 567
        public bool lastpagemode;

        // Token: 0x04000238 RID: 568
        public int fixedcols;

        // Token: 0x04000239 RID: 569
        public string documentname;

        // Token: 0x0400023A RID: 570
        public PaperKind paperkind;

        // Token: 0x0400023B RID: 571
        public Margins mypapermarign;

        // Token: 0x0400023C RID: 572
        public bool autoformat;

        // Token: 0x0400023D RID: 573
        private int colcount;

        // Token: 0x0400023E RID: 574
        private string curitem;

        // Token: 0x0400023F RID: 575
        public bool isfirsttimeshow;

        // Token: 0x04000240 RID: 576
        public string mypagel;

        // Token: 0x04000241 RID: 577
        public string mypagem;

        // Token: 0x04000242 RID: 578
        public string mypager;

        // Token: 0x04000243 RID: 579
        public string mypageleft;

        // Token: 0x04000244 RID: 580
        public string mypageright;

        // Token: 0x04000245 RID: 581
        public string mypagemiddle;

        // Token: 0x04000246 RID: 582
        public string mytablel;

        // Token: 0x04000247 RID: 583
        public string mytablem;

        // Token: 0x04000248 RID: 584
        public string mytabler;

        // Token: 0x04000249 RID: 585
        public string mytableleft;

        // Token: 0x0400024A RID: 586
        public string mytablemiddle;

        // Token: 0x0400024B RID: 587
        public string mytableright;

        // Token: 0x0400024C RID: 588
        public Font myfooterfont;

        // Token: 0x0400024D RID: 589
        public Font myheaderfont;

        // Token: 0x0400024E RID: 590
        public Font mytopfont;

        // Token: 0x0400024F RID: 591
        public Font mybottomfont;

        // Token: 0x04000250 RID: 592
        public Color myfootercolor;

        // Token: 0x04000251 RID: 593
        public Color myheadercolor;

        // Token: 0x04000252 RID: 594
        public Color mydefaultcolor;

        // Token: 0x04000253 RID: 595
        public string mywatermarktext;

        // Token: 0x04000255 RID: 597
        public byte mywatermarkopacity;

        // Token: 0x04000256 RID: 598
        public bool mywatermarklandscape;

        // Token: 0x04000257 RID: 599
        public Color mywatermarkcolor;

        // Token: 0x04000258 RID: 600
        public int myshapedepth;

        // Token: 0x04000259 RID: 601
        public int mytitletextstyle;

        // Token: 0x0400025A RID: 602
        public int mysubtitlestyle;

        // Token: 0x0400025B RID: 603
        public string schemefilename;

        // Token: 0x0400025C RID: 604
        public string myrightt;

        // Token: 0x0400025D RID: 605
        public string myrightm;

        // Token: 0x0400025E RID: 606
        public string myrightb;

        // Token: 0x04000260 RID: 608
        public Color myrightcolor;

        // Token: 0x04000261 RID: 609
        public string myhzcolumns;

        // Token: 0x04000263 RID: 611
        public Color myhzforecolor;

        // Token: 0x04000264 RID: 612
        public Color myhzbackcolor;

        // Token: 0x04000265 RID: 613
        public int datarowcount;

        // Token: 0x04000266 RID: 614
        public bool myisimmediateprint;

        // Token: 0x04000267 RID: 615
        public string mywindowtext;

        // Token: 0x04000268 RID: 616
        public string currentprintname;

        // Token: 0x04000269 RID: 617
        public bool myIsDGVCellValignmentCenter;

        // Token: 0x0400026A RID: 618
        public string mysortcolumn;

        // Token: 0x0400026B RID: 619
        public bool mysorttype;

        // Token: 0x0400026C RID: 620
        public string mygroupcolumne;

        // Token: 0x0400026D RID: 621
        public bool mygroupnewpage;

        // Token: 0x0400026E RID: 622
        public bool myaddrowid;

        // Token: 0x0400026F RID: 623
        public bool myaddrownew;

        // Token: 0x04000270 RID: 624
        public bool myIsImmediatePrintNotPreviewShowPrintDialog;

        // Token: 0x04000271 RID: 625
        public bool myIsShowMessageIfPrinterNotSupportPaper;

        // Token: 0x04000272 RID: 626
        public TreeView myheader;

        // Token: 0x04000273 RID: 627
        public string papername;

        // Token: 0x04000274 RID: 628
        public decimal mypaperwidth;

        // Token: 0x04000275 RID: 629
        public decimal mypaperheight;

        // Token: 0x04000276 RID: 630
        public bool myisuseAPIprintDialog;

        // Token: 0x04000277 RID: 631
        public StringAlignment myTableTopLeftTitleAlign;

        // Token: 0x04000278 RID: 632
        public StringAlignment myTableTopMiddleTitleAlign;

        // Token: 0x04000279 RID: 633
        public StringAlignment myTableTopRightTitleAlign;

        // Token: 0x0400027A RID: 634
        public StringAlignment myTableBottomLeftTitleAlign;

        // Token: 0x0400027B RID: 635
        public StringAlignment myTableBottomMiddleTitleAlign;

        // Token: 0x0400027C RID: 636
        public StringAlignment myTableBottomRightTitleAlign;

        // Token: 0x0400027D RID: 637
        public StringAlignment mySumNumberAlign;

        // Token: 0x0400027E RID: 638
        public Image mypagebackgroundimage;

        // Token: 0x0400027F RID: 639
        public bool myisshowaboutpage;

        // Token: 0x04000280 RID: 640
        public bool myisdrawpageheaderline;

        // Token: 0x04000281 RID: 641
        public bool myisdrawpagefooterline;

        // Token: 0x04000282 RID: 642
        public bool myisdrawmargin;

        // Token: 0x04000283 RID: 643
        public bool myisautoaddemptyrow;

        // Token: 0x04000284 RID: 644
        public bool mycaneditprintsettings;

        // Token: 0x04000285 RID: 645
        public bool myenabledprint;

        // Token: 0x04000286 RID: 646
        public bool myisdrawtablefootereverypage;

        // Token: 0x04000287 RID: 647
        private Ruler myp;

        // Token: 0x04000288 RID: 648
        public bool myisusedoubleline;

        // Token: 0x04000289 RID: 649
        public bool myouterborder;

        // Token: 0x0400028A RID: 650
        public Color myouterbordercolor;

        // Token: 0x0400028B RID: 651
        public float myouterborderwidth;

        // Token: 0x0400028C RID: 652
        public float thedoublelinespace;

        // Token: 0x0400028D RID: 653
        public string myZDXtext;

        // Token: 0x0400028F RID: 655
        public Color myZDXtextcolor;

        // Token: 0x04000290 RID: 656
        public Color myZDXlinecolor;

        // Token: 0x04000291 RID: 657
        public DashStyle myZDXlinestyle;

        // Token: 0x04000292 RID: 658
        public float myZDXposition;

        // Token: 0x04000293 RID: 659
        public float myrowheight;

        // Token: 0x04000294 RID: 660
        public bool myEnableChangeScheme;

        // Token: 0x04000295 RID: 661
        private string s_schemefilename;

        // Token: 0x04000296 RID: 662
        public bool NeedReadFangAn;

        // Token: 0x04000297 RID: 663
        public bool myenablesaveaspdf;

        // Token: 0x04000298 RID: 664
        public bool myenablesaveasimage;

        // Token: 0x04000299 RID: 665
        public bool myenableexportpdf;

        // Token: 0x0400029A RID: 666
        public bool myenableexportexcel;

        // Token: 0x0400029B RID: 667
        public bool myenableexportrtf;

        // Token: 0x0400029C RID: 668
        public bool myenableexporthtml;

        // Token: 0x0400029D RID: 669
        public short _printcopys;

        // Token: 0x0400029E RID: 670
        public bool myisshowprogress;

        // Token: 0x0400029F RID: 671
        public DataGridViewPrintSet.TheZDXTYPE myZDXtype;

        // Token: 0x040002A0 RID: 672
        public bool myisdrawZDX;

        // Token: 0x040002A1 RID: 673
        public bool myEnableChangePageSettings;

        // Token: 0x040002A2 RID: 674
        public bool myEnableChangeTitle;

        // Token: 0x040002A3 RID: 675
        public bool myEnableChangeTableStyle;

        // Token: 0x040002A4 RID: 676
        public bool myEnableChangeTableSettings;

        // Token: 0x040002A5 RID: 677
        public bool myEnableChangeHeaderAndFooter;

        // Token: 0x040002A6 RID: 678
        public bool myEnableChangeGroup;

        // Token: 0x040002A7 RID: 679
        public bool myEnableChangeSum;

        // Token: 0x040002A8 RID: 680
        public bool myEnableChangeZDX;

        // Token: 0x040002A9 RID: 681
        public bool myEnableChangeWaterMark;

        // Token: 0x040002AA RID: 682
        public string myreportheadertext;

        // Token: 0x040002AB RID: 683
        public StringAlignment myreportheaderalignment;

        // Token: 0x040002AC RID: 684
        public Font myreportheaderfont;

        // Token: 0x040002AD RID: 685
        public Color myreportheadercolor;

        // Token: 0x040002AE RID: 686
        public float myreportheaderspace;

        // Token: 0x040002AF RID: 687
        public string myreportfootertext;

        // Token: 0x040002B0 RID: 688
        public StringAlignment myreportfooteralignment;

        // Token: 0x040002B1 RID: 689
        public Font myreportfooterfont;

        // Token: 0x040002B2 RID: 690
        public Color myreportfootercolor;

        // Token: 0x040002B3 RID: 691
        public float myreportfooterspace;

        // Token: 0x02000011 RID: 17
        public enum TheZDXTYPE
        {
            // Token: 0x040002B5 RID: 693
            LEFT,
            // Token: 0x040002B6 RID: 694
            TOP,
            // Token: 0x040002B7 RID: 695
            RIGHT,
            // Token: 0x040002B8 RID: 696
            BOTTOM
        }
    }
}
