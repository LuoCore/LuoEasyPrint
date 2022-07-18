using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace LuoEasyPrint
{
    // Token: 0x0200000C RID: 12
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class PivotTableView : Form
    {
        // Token: 0x06000093 RID: 147 RVA: 0x0000C760 File Offset: 0x0000A960
        public PivotTableView()
        {
            base.Disposed += this.PivotTableView_Disposed;
            base.Load += this.PivotTableView_Load;
            this.lastrow = null;
            this.islastrowremoved = false;
            this.hasaddsumrow = false;
            this.iscancel = false;
            this.myXaxis = null;
            this.myYaxis = null;
            this.myZaxis = null;
            this.myzalign = null;
            this.myzformat = null;
            this.myzvaluetype = null;
            this.myztitle = null;
            this.myzformats = null;
            this.sourcedgv = new DataGridView();
            this.mytitle = "";
            this.xy = "";
            this.f_xh = 0;
            this.InitializeComponent();
        }

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x06000096 RID: 150 RVA: 0x0000E580 File Offset: 0x0000C780
        // (set) Token: 0x06000097 RID: 151 RVA: 0x0000E598 File Offset: 0x0000C798
        internal virtual MulHeaderDataGridView d1
        {
            get
            {
                return this._d1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.d1_CellDoubleClick);
                DataGridViewRowPostPaintEventHandler value3 = new DataGridViewRowPostPaintEventHandler(this.d1_RowPostPaint);
                DataGridViewCellMouseEventHandler value4 = new DataGridViewCellMouseEventHandler(this.d1_CellMouseClick);
                EventHandler value5 = new EventHandler(this.d1_Sorted);
                if (this._d1 != null)
                {
                    this._d1.CellDoubleClick -= value2;
                    this._d1.RowPostPaint -= value3;
                    this._d1.CellMouseClick -= value4;
                    this._d1.Sorted -= value5;
                }
                this._d1 = value;
                if (this._d1 != null)
                {
                    this._d1.CellDoubleClick += value2;
                    this._d1.RowPostPaint += value3;
                    this._d1.CellMouseClick += value4;
                    this._d1.Sorted += value5;
                }
            }
        }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x06000098 RID: 152 RVA: 0x0000E654 File Offset: 0x0000C854
        // (set) Token: 0x06000099 RID: 153 RVA: 0x00002632 File Offset: 0x00000832
        internal virtual TreeView tv1
        {
            get
            {
                return this._tv1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tv1 = value;
            }
        }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x0600009A RID: 154 RVA: 0x0000E66C File Offset: 0x0000C86C
        // (set) Token: 0x0600009B RID: 155 RVA: 0x0000263B File Offset: 0x0000083B
        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            get
            {
                return this._ContextMenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ContextMenuStrip1 = value;
            }
        }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x0600009C RID: 156 RVA: 0x0000E684 File Offset: 0x0000C884
        // (set) Token: 0x0600009D RID: 157 RVA: 0x0000E69C File Offset: 0x0000C89C
        internal virtual ToolStripMenuItem ToolStripMenuItem_0
        {
            get
            {
                return this.toolStripMenuItem_0;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripMenuItem_0_Click);
                if (this.toolStripMenuItem_0 != null)
                {
                    this.toolStripMenuItem_0.Click -= value2;
                }
                this.toolStripMenuItem_0 = value;
                if (this.toolStripMenuItem_0 != null)
                {
                    this.toolStripMenuItem_0.Click += value2;
                }
            }
        }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x0600009E RID: 158 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
        // (set) Token: 0x0600009F RID: 159 RVA: 0x0000E700 File Offset: 0x0000C900
        internal virtual ToolStripMenuItem ToolStripMenuItem_1
        {
            get
            {
                return this.toolStripMenuItem_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripMenuItem_1_Click);
                if (this.toolStripMenuItem_1 != null)
                {
                    this.toolStripMenuItem_1.Click -= value2;
                }
                this.toolStripMenuItem_1 = value;
                if (this.toolStripMenuItem_1 != null)
                {
                    this.toolStripMenuItem_1.Click += value2;
                }
            }
        }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060000A0 RID: 160 RVA: 0x0000E74C File Offset: 0x0000C94C
        // (set) Token: 0x060000A1 RID: 161 RVA: 0x00002644 File Offset: 0x00000844
        internal virtual ToolStripSeparator ToolStripMenuItem1
        {
            get
            {
                return this._ToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripMenuItem1 = value;
            }
        }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060000A2 RID: 162 RVA: 0x0000E764 File Offset: 0x0000C964
        // (set) Token: 0x060000A3 RID: 163 RVA: 0x0000E77C File Offset: 0x0000C97C
        internal virtual ToolStripMenuItem ToolStripMenuItem_2
        {
            get
            {
                return this.toolStripMenuItem_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripMenuItem_2_Click);
                if (this.toolStripMenuItem_2 != null)
                {
                    this.toolStripMenuItem_2.Click -= value2;
                }
                this.toolStripMenuItem_2 = value;
                if (this.toolStripMenuItem_2 != null)
                {
                    this.toolStripMenuItem_2.Click += value2;
                }
            }
        }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060000A4 RID: 164 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
        // (set) Token: 0x060000A5 RID: 165 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
        internal virtual ToolStripMenuItem ToolStripMenuItem_3
        {
            get
            {
                return this.toolStripMenuItem_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripMenuItem_3_Click);
                if (this.toolStripMenuItem_3 != null)
                {
                    this.toolStripMenuItem_3.Click -= value2;
                }
                this.toolStripMenuItem_3 = value;
                if (this.toolStripMenuItem_3 != null)
                {
                    this.toolStripMenuItem_3.Click += value2;
                }
            }
        }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060000A6 RID: 166 RVA: 0x0000E82C File Offset: 0x0000CA2C
        // (set) Token: 0x060000A7 RID: 167 RVA: 0x0000264D File Offset: 0x0000084D
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

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060000A8 RID: 168 RVA: 0x0000E844 File Offset: 0x0000CA44
        // (set) Token: 0x060000A9 RID: 169 RVA: 0x0000E85C File Offset: 0x0000CA5C
        internal virtual ToolStripButton ToolStripButton1
        {
            get
            {
                return this._ToolStripButton1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton1_Click);
                if (this._ToolStripButton1 != null)
                {
                    this._ToolStripButton1.Click -= value2;
                }
                this._ToolStripButton1 = value;
                if (this._ToolStripButton1 != null)
                {
                    this._ToolStripButton1.Click += value2;
                }
            }
        }

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060000AA RID: 170 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
        // (set) Token: 0x060000AB RID: 171 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
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

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060000AC RID: 172 RVA: 0x0000E90C File Offset: 0x0000CB0C
        // (set) Token: 0x060000AD RID: 173 RVA: 0x00002656 File Offset: 0x00000856
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

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060000AE RID: 174 RVA: 0x0000E924 File Offset: 0x0000CB24
        // (set) Token: 0x060000AF RID: 175 RVA: 0x0000E93C File Offset: 0x0000CB3C
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

        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060000B0 RID: 176 RVA: 0x0000E988 File Offset: 0x0000CB88
        // (set) Token: 0x060000B1 RID: 177 RVA: 0x0000265F File Offset: 0x0000085F
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

        // Token: 0x17000046 RID: 70
        // (get) Token: 0x060000B2 RID: 178 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
        // (set) Token: 0x060000B3 RID: 179 RVA: 0x00002668 File Offset: 0x00000868
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

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x060000B4 RID: 180 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
        // (set) Token: 0x060000B5 RID: 181 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
        internal virtual ListBox ListBox4
        {
            get
            {
                return this._ListBox4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DragEventHandler value2 = new DragEventHandler(this.ListBox4_DragDrop);
                DragEventHandler value3 = new DragEventHandler(this.ListBox3_DragOver);
                EventHandler value4 = new EventHandler(this.ListBox4_SelectedIndexChanged);
                if (this._ListBox4 != null)
                {
                    this._ListBox4.DragDrop -= value2;
                    this._ListBox4.DragOver -= value3;
                    this._ListBox4.SelectedIndexChanged -= value4;
                }
                this._ListBox4 = value;
                if (this._ListBox4 != null)
                {
                    this._ListBox4.DragDrop += value2;
                    this._ListBox4.DragOver += value3;
                    this._ListBox4.SelectedIndexChanged += value4;
                }
            }
        }

        // Token: 0x17000048 RID: 72
        // (get) Token: 0x060000B6 RID: 182 RVA: 0x0000EA68 File Offset: 0x0000CC68
        // (set) Token: 0x060000B7 RID: 183 RVA: 0x0000EA80 File Offset: 0x0000CC80
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

        // Token: 0x17000049 RID: 73
        // (get) Token: 0x060000B8 RID: 184 RVA: 0x0000EACC File Offset: 0x0000CCCC
        // (set) Token: 0x060000B9 RID: 185 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
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

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x060000BA RID: 186 RVA: 0x0000EB30 File Offset: 0x0000CD30
        // (set) Token: 0x060000BB RID: 187 RVA: 0x0000EB48 File Offset: 0x0000CD48
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

        // Token: 0x1700004B RID: 75
        // (get) Token: 0x060000BC RID: 188 RVA: 0x0000EB94 File Offset: 0x0000CD94
        // (set) Token: 0x060000BD RID: 189 RVA: 0x00002671 File Offset: 0x00000871
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

        // Token: 0x1700004C RID: 76
        // (get) Token: 0x060000BE RID: 190 RVA: 0x0000EBAC File Offset: 0x0000CDAC
        // (set) Token: 0x060000BF RID: 191 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
        internal virtual ListBox ListBox3
        {
            get
            {
                return this._ListBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DragEventHandler value2 = new DragEventHandler(this.ListBox3_DragDrop);
                DragEventHandler value3 = new DragEventHandler(this.ListBox3_DragOver);
                if (this._ListBox3 != null)
                {
                    this._ListBox3.DragDrop -= value2;
                    this._ListBox3.DragOver -= value3;
                }
                this._ListBox3 = value;
                if (this._ListBox3 != null)
                {
                    this._ListBox3.DragDrop += value2;
                    this._ListBox3.DragOver += value3;
                }
            }
        }

        // Token: 0x1700004D RID: 77
        // (get) Token: 0x060000C0 RID: 192 RVA: 0x0000EC34 File Offset: 0x0000CE34
        // (set) Token: 0x060000C1 RID: 193 RVA: 0x0000EC4C File Offset: 0x0000CE4C
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

        // Token: 0x1700004E RID: 78
        // (get) Token: 0x060000C2 RID: 194 RVA: 0x0000EC98 File Offset: 0x0000CE98
        // (set) Token: 0x060000C3 RID: 195 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
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

        // Token: 0x1700004F RID: 79
        // (get) Token: 0x060000C4 RID: 196 RVA: 0x0000ECFC File Offset: 0x0000CEFC
        // (set) Token: 0x060000C5 RID: 197 RVA: 0x0000ED14 File Offset: 0x0000CF14
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

        // Token: 0x17000050 RID: 80
        // (get) Token: 0x060000C6 RID: 198 RVA: 0x0000ED60 File Offset: 0x0000CF60
        // (set) Token: 0x060000C7 RID: 199 RVA: 0x0000267A File Offset: 0x0000087A
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

        // Token: 0x17000051 RID: 81
        // (get) Token: 0x060000C8 RID: 200 RVA: 0x0000ED78 File Offset: 0x0000CF78
        // (set) Token: 0x060000C9 RID: 201 RVA: 0x0000ED90 File Offset: 0x0000CF90
        internal virtual ListBox ListBox2
        {
            get
            {
                return this._ListBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DragEventHandler value2 = new DragEventHandler(this.ListBox2_DragDrop);
                DragEventHandler value3 = new DragEventHandler(this.ListBox3_DragOver);
                if (this._ListBox2 != null)
                {
                    this._ListBox2.DragDrop -= value2;
                    this._ListBox2.DragOver -= value3;
                }
                this._ListBox2 = value;
                if (this._ListBox2 != null)
                {
                    this._ListBox2.DragDrop += value2;
                    this._ListBox2.DragOver += value3;
                }
            }
        }

        // Token: 0x17000052 RID: 82
        // (get) Token: 0x060000CA RID: 202 RVA: 0x0000EE00 File Offset: 0x0000D000
        // (set) Token: 0x060000CB RID: 203 RVA: 0x0000EE18 File Offset: 0x0000D018
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

        // Token: 0x17000053 RID: 83
        // (get) Token: 0x060000CC RID: 204 RVA: 0x0000EE64 File Offset: 0x0000D064
        // (set) Token: 0x060000CD RID: 205 RVA: 0x0000EE7C File Offset: 0x0000D07C
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

        // Token: 0x17000054 RID: 84
        // (get) Token: 0x060000CE RID: 206 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
        // (set) Token: 0x060000CF RID: 207 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
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

        // Token: 0x17000055 RID: 85
        // (get) Token: 0x060000D0 RID: 208 RVA: 0x0000EF2C File Offset: 0x0000D12C
        // (set) Token: 0x060000D1 RID: 209 RVA: 0x00002683 File Offset: 0x00000883
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

        // Token: 0x17000056 RID: 86
        // (get) Token: 0x060000D2 RID: 210 RVA: 0x0000EF44 File Offset: 0x0000D144
        // (set) Token: 0x060000D3 RID: 211 RVA: 0x0000EF5C File Offset: 0x0000D15C
        internal virtual ListBox ListBox1
        {
            get
            {
                return this._ListBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                MouseEventHandler value2 = new MouseEventHandler(this.ListBox1_MouseDown);
                if (this._ListBox1 != null)
                {
                    this._ListBox1.MouseDown -= value2;
                }
                this._ListBox1 = value;
                if (this._ListBox1 != null)
                {
                    this._ListBox1.MouseDown += value2;
                }
            }
        }

        // Token: 0x17000057 RID: 87
        // (get) Token: 0x060000D4 RID: 212 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
        // (set) Token: 0x060000D5 RID: 213 RVA: 0x0000268C File Offset: 0x0000088C
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

        // Token: 0x17000058 RID: 88
        // (get) Token: 0x060000D6 RID: 214 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
        // (set) Token: 0x060000D7 RID: 215 RVA: 0x00002695 File Offset: 0x00000895
        internal virtual CheckBox c1
        {
            get
            {
                return this._c1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._c1 = value;
            }
        }

        // Token: 0x17000059 RID: 89
        // (get) Token: 0x060000D8 RID: 216 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
        // (set) Token: 0x060000D9 RID: 217 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
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

        // Token: 0x1700005A RID: 90
        // (get) Token: 0x060000DA RID: 218 RVA: 0x0000F03C File Offset: 0x0000D23C
        // (set) Token: 0x060000DB RID: 219 RVA: 0x0000F054 File Offset: 0x0000D254
        internal virtual TextBox TextBox1
        {
            get
            {
                return this._TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TextBox1_Leave);
                if (this._TextBox1 != null)
                {
                    this._TextBox1.Leave -= value2;
                }
                this._TextBox1 = value;
                if (this._TextBox1 != null)
                {
                    this._TextBox1.Leave += value2;
                }
            }
        }

        // Token: 0x1700005B RID: 91
        // (get) Token: 0x060000DC RID: 220 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
        // (set) Token: 0x060000DD RID: 221 RVA: 0x0000269E File Offset: 0x0000089E
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

        // Token: 0x1700005C RID: 92
        // (get) Token: 0x060000DE RID: 222 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
        // (set) Token: 0x060000DF RID: 223 RVA: 0x000026A7 File Offset: 0x000008A7
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

        // Token: 0x1700005D RID: 93
        // (get) Token: 0x060000E0 RID: 224 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
        // (set) Token: 0x060000E1 RID: 225 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
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

        // Token: 0x1700005E RID: 94
        // (get) Token: 0x060000E2 RID: 226 RVA: 0x0000F134 File Offset: 0x0000D334
        // (set) Token: 0x060000E3 RID: 227 RVA: 0x0000F14C File Offset: 0x0000D34C
        internal virtual ToolStripButton ToolStripButton4
        {
            get
            {
                return this._ToolStripButton4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton4_Click);
                if (this._ToolStripButton4 != null)
                {
                    this._ToolStripButton4.Click -= value2;
                }
                this._ToolStripButton4 = value;
                if (this._ToolStripButton4 != null)
                {
                    this._ToolStripButton4.Click += value2;
                }
            }
        }

        // Token: 0x1700005F RID: 95
        // (get) Token: 0x060000E4 RID: 228 RVA: 0x0000F198 File Offset: 0x0000D398
        // (set) Token: 0x060000E5 RID: 229 RVA: 0x000026B0 File Offset: 0x000008B0
        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            get
            {
                return this._ToolStripSeparator2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator2 = value;
            }
        }

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x060000E6 RID: 230 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
        // (set) Token: 0x060000E7 RID: 231 RVA: 0x000026B9 File Offset: 0x000008B9
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

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x060000E8 RID: 232 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
        // (set) Token: 0x060000E9 RID: 233 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
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

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x060000EA RID: 234 RVA: 0x0000F22C File Offset: 0x0000D42C
        // (set) Token: 0x060000EB RID: 235 RVA: 0x000026C2 File Offset: 0x000008C2
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

        // Token: 0x17000063 RID: 99
        // (get) Token: 0x060000EC RID: 236 RVA: 0x0000F244 File Offset: 0x0000D444
        // (set) Token: 0x060000ED RID: 237 RVA: 0x0000F25C File Offset: 0x0000D45C
        internal virtual ComboBox ComboBox2
        {
            get
            {
                return this._ComboBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ComboBox2_SelectedIndexChanged);
                if (this._ComboBox2 != null)
                {
                    this._ComboBox2.SelectedIndexChanged -= value2;
                }
                this._ComboBox2 = value;
                if (this._ComboBox2 != null)
                {
                    this._ComboBox2.SelectedIndexChanged += value2;
                }
            }
        }

        // Token: 0x17000064 RID: 100
        // (get) Token: 0x060000EE RID: 238 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
        // (set) Token: 0x060000EF RID: 239 RVA: 0x000026CB File Offset: 0x000008CB
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

        // Token: 0x17000065 RID: 101
        // (get) Token: 0x060000F0 RID: 240 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
        // (set) Token: 0x060000F1 RID: 241 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
        internal virtual TextBox TextBox2
        {
            get
            {
                return this._TextBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TextBox2_Leave);
                if (this._TextBox2 != null)
                {
                    this._TextBox2.Leave -= value2;
                }
                this._TextBox2 = value;
                if (this._TextBox2 != null)
                {
                    this._TextBox2.Leave += value2;
                }
            }
        }

        // Token: 0x17000066 RID: 102
        // (get) Token: 0x060000F2 RID: 242 RVA: 0x0000F324 File Offset: 0x0000D524
        // (set) Token: 0x060000F3 RID: 243 RVA: 0x000026D4 File Offset: 0x000008D4
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

        // Token: 0x17000067 RID: 103
        // (get) Token: 0x060000F4 RID: 244 RVA: 0x0000F33C File Offset: 0x0000D53C
        // (set) Token: 0x060000F5 RID: 245 RVA: 0x0000F354 File Offset: 0x0000D554
        internal virtual ToolStripButton ToolStripButton5
        {
            get
            {
                return this._ToolStripButton5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton5_Click);
                if (this._ToolStripButton5 != null)
                {
                    this._ToolStripButton5.Click -= value2;
                }
                this._ToolStripButton5 = value;
                if (this._ToolStripButton5 != null)
                {
                    this._ToolStripButton5.Click += value2;
                }
            }
        }

        // Token: 0x17000068 RID: 104
        // (get) Token: 0x060000F6 RID: 246 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
        // (set) Token: 0x060000F7 RID: 247 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
        internal virtual ToolStripButton ToolStripButton6
        {
            get
            {
                return this._ToolStripButton6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToolStripButton6_Click);
                if (this._ToolStripButton6 != null)
                {
                    this._ToolStripButton6.Click -= value2;
                }
                this._ToolStripButton6 = value;
                if (this._ToolStripButton6 != null)
                {
                    this._ToolStripButton6.Click += value2;
                }
            }
        }

        // Token: 0x17000069 RID: 105
        // (get) Token: 0x060000F8 RID: 248 RVA: 0x0000F404 File Offset: 0x0000D604
        // (set) Token: 0x060000F9 RID: 249 RVA: 0x000026DD File Offset: 0x000008DD
        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            get
            {
                return this._ToolStripSeparator3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator3 = value;
            }
        }

        // Token: 0x1700006A RID: 106
        // (get) Token: 0x060000FA RID: 250 RVA: 0x0000F41C File Offset: 0x0000D61C
        // (set) Token: 0x060000FB RID: 251 RVA: 0x000026E6 File Offset: 0x000008E6
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

        // Token: 0x1700006B RID: 107
        // (get) Token: 0x060000FC RID: 252 RVA: 0x0000F434 File Offset: 0x0000D634
        // (set) Token: 0x060000FD RID: 253 RVA: 0x000026EF File Offset: 0x000008EF
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

        // Token: 0x1700006C RID: 108
        // (get) Token: 0x060000FE RID: 254 RVA: 0x0000F44C File Offset: 0x0000D64C
        // (set) Token: 0x060000FF RID: 255 RVA: 0x000026F8 File Offset: 0x000008F8
        internal virtual Label zt
        {
            get
            {
                return this._zt;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._zt = value;
            }
        }

        // Token: 0x1700006D RID: 109
        // (get) Token: 0x06000100 RID: 256 RVA: 0x0000F464 File Offset: 0x0000D664
        // (set) Token: 0x06000101 RID: 257 RVA: 0x0000F47C File Offset: 0x0000D67C
        internal virtual Button cc
        {
            get
            {
                return this._cc;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cc_Click);
                if (this._cc != null)
                {
                    this._cc.Click -= value2;
                }
                this._cc = value;
                if (this._cc != null)
                {
                    this._cc.Click += value2;
                }
            }
        }

        // Token: 0x06000102 RID: 258 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
        private void CopyDGVToCLipBoard(DataGridView dgv)
        {
            if (dgv.RowCount > 0)
            {
                try
                {
                    Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(dgv.GetClipboardContent().GetData(DataFormats.Text)));
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x06000103 RID: 259 RVA: 0x0000F518 File Offset: 0x0000D718
        private void SumDGVSelection(DataGridView mydgv)
        {
            checked
            {
                if (mydgv.SelectedCells.Count <= 0)
                {
                    Interaction.MsgBox("当前没有任何选中的内容", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    decimal num = 0m;
                    int num2 = 0;
                    int num3 = mydgv.SelectedCells.Count - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        try
                        {
                            string text = Convert.ToString(Operators.ConcatenateObject(mydgv.SelectedCells[i].Value, ""));
                            if (Versioned.IsNumeric(text))
                            {
                                num = decimal.Add(num, Convert.ToDecimal(text));
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    Interaction.MsgBox("选中内容求和的结果是：" + Strings.Format(num, "#,###,###,###,###.##"), MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000104 RID: 260 RVA: 0x00002701 File Offset: 0x00000901
        private void ToolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.CopyDGVToCLipBoard(this.d1);
        }

        // Token: 0x06000105 RID: 261 RVA: 0x0000270F File Offset: 0x0000090F
        private void ToolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            this.SumDGVSelection(this.d1);
        }

        // Token: 0x06000106 RID: 262 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
        private void d1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                if (!(this.myXaxis == null & this.myYaxis == null) && e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    if (e.ColumnIndex >= 0)
                    {
                        int columnIndex = e.ColumnIndex;
                        string[] array = null;
                        string[] array2 = null;
                        if (this.myaddtotalrow && rowIndex == this.d1.RowCount - 1)
                        {
                            if (this.myXaxis != null)
                            {
                                if (!(this.myYaxis == null | (this.myYaxis != null && columnIndex > this.myYaxis.Length - 1)))
                                {
                                    return;
                                }
                                array = new string[this.myXaxis.Length - 1 + 1];
                                array2 = new string[this.myXaxis.Length - 1 + 1];
                                string[] array3 = Strings.Split(Convert.ToString(this.d1.Columns[columnIndex].Tag), "\0", -1, CompareMethod.Binary);
                                int num = 0;
                                int num2 = array3.Length - 1;
                                for (int i = num; i <= num2; i++)
                                {
                                    array[i] = this.myXaxis[i];
                                    array2[i] = array3[i];
                                }
                            }
                        }
                        else
                        {
                            if (this.myYaxis != null)
                            {
                                array = new string[this.myYaxis.Length - 1 + 1];
                                array2 = new string[this.myYaxis.Length - 1 + 1];
                                int num3 = 0;
                                int num4 = this.myYaxis.Length - 1;
                                for (int j = num3; j <= num4; j++)
                                {
                                    array[j] = this.myYaxis[j];
                                    array2[j] = Convert.ToString(Operators.ConcatenateObject(this.d1.Rows[rowIndex].Cells[j].Value, ""));
                                }
                            }
                            if (this.myXaxis != null & (this.myYaxis == null | (this.myYaxis != null && columnIndex > this.myYaxis.Length - 1)))
                            {
                                int num5;
                                if (array == null)
                                {
                                    num5 = 0;
                                }
                                else
                                {
                                    num5 = array.Length;
                                }
                                array = (string[])Utils.CopyArray((Array)array, new string[num5 + this.myXaxis.Length - 1 + 1]);
                                array2 = (string[])Utils.CopyArray((Array)array2, new string[num5 + this.myXaxis.Length - 1 + 1]);
                                string[] array4 = Strings.Split(Convert.ToString(this.d1.Columns[columnIndex].Tag), "\0", -1, CompareMethod.Binary);
                                int num6 = 0;
                                int num7 = array4.Length - 1;
                                for (int k = num6; k <= num7; k++)
                                {
                                    array[num5 + k] = this.myXaxis[k];
                                    array2[num5 + k] = array4[k];
                                }
                            }
                        }
                        PivotTableDetail pivotTableDetail = new PivotTableDetail();
                        DGVprint dgvprint = new DGVprint();
                        dgvprint.CopyDataGridView(this.sourcedgv, pivotTableDetail.d1, 0, this.sourcedgv.RowCount - 1);
                        dgvprint.Dispose();
                        int rowCount = pivotTableDetail.d1.RowCount;
                        if (array != null & array2 != null)
                        {
                            int l = rowCount - 1;
                        IL_36D:
                            while (l >= 0)
                            {
                                int num8 = 0;
                                int num9 = array.Length - 1;
                                for (int m = num8; m <= num9; m++)
                                {
                                    if (!Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(pivotTableDetail.d1.Rows[l].Cells[array[m]].FormattedValue, ""), array2[m], false))
                                    {
                                        pivotTableDetail.d1.Rows.RemoveAt(l);
                                    IL_367:
                                        l += -1;
                                        goto IL_36D;
                                    }
                                }

                            }
                        }
                        pivotTableDetail.d1.AutoResizeColumns();
                        pivotTableDetail.ShowDialog();
                    }
                }
            }
        }

        // Token: 0x06000107 RID: 263 RVA: 0x0000F978 File Offset: 0x0000DB78
        private void PivotTableView_Disposed(object sender, EventArgs e)
        {
            if (this.myXaxis == null)
            {
                this.myXaxis = null;
                this.myXaxis = null;
            }
            if (this.myYaxis == null)
            {
                this.myYaxis = null;
                this.myYaxis = null;
            }
            if (this.myZaxis == null)
            {
                this.myZaxis = null;
                this.myZaxis = null;
            }
            if (this.myzalign == null)
            {
                this.myzalign = null;
                this.myzalign = null;
            }
            if (this.myzformat == null)
            {
                this.myzformat = null;
                this.myzformat = null;
            }
            if (this.sourcedgv != null)
            {
                this.sourcedgv = null;
            }
        }

        // Token: 0x06000108 RID: 264 RVA: 0x0000FA04 File Offset: 0x0000DC04
        public void Start(DataGridView dgv)
        {
            Application.DoEvents();
            this.f_xh = 0;
            checked
            {
                if (dgv != null && this.myZaxis != null && this.myZaxis.Length >= 1 && this.CheckColumns(this.myXaxis, dgv, false) && this.CheckColumns(this.myYaxis, dgv, false) && this.CheckColumns(this.myZaxis, dgv, true))
                {
                    TreeView tv = this.tv1;
                    this.d1.ColHeaderTreeView = null;
                    MulHeaderDataGridView d = this.d1;
                    if (this.myYaxis != null)
                    {
                        int num = 0;
                        int num2 = this.myYaxis.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            DataGridViewColumn dataGridViewColumn = dgv.Columns[this.myYaxis[i]];
                            TreeNode treeNode = tv.Nodes.Add(dataGridViewColumn.HeaderText);
                            treeNode.Tag = dataGridViewColumn.Name;
                        }
                        d.ColumnCount = this.myYaxis.Length;
                        int num3 = 0;
                        int num4 = this.myYaxis.Length - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            d.Columns[j].HeaderText = dgv.Columns[this.myYaxis[j]].HeaderText;
                            d.Columns[j].Name = this.myYaxis[j];
                        }
                        int num5 = 0;
                        int num6 = dgv.RowCount - 1;
                        for (int k = num5; k <= num6; k++)
                        {
                            bool flag = false;
                            Application.DoEvents();
                            if (this.iscancel)
                            {
                                return;
                            }
                            if (d.RowCount >= 1)
                            {
                                int num7 = 0;
                                int num8 = d.Rows.Count - 1;
                                for (int l = num7; l <= num8; l++)
                                {
                                    Application.DoEvents();
                                    if (this.iscancel)
                                    {
                                        return;
                                    }
                                    int num9 = 0;
                                    int num10 = this.myYaxis.Length - 1;
                                    int num11 = num9;
                                    while (num11 <= num10 && Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(d.Rows[l].Cells[num11].FormattedValue, ""), Operators.ConcatenateObject(dgv.Rows[k].Cells[this.myYaxis[num11]].FormattedValue, ""), false))
                                    {
                                        num11++;
                                    }
                                    if (num11 > this.myYaxis.Length - 1)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                flag = false;
                            }
                            if (!flag)
                            {
                                d.RowCount++;
                                int index = d.RowCount - 1;
                                int num12 = 0;
                                int num13 = this.myYaxis.Length - 1;
                                for (int m = num12; m <= num13; m++)
                                {
                                    d.Rows[index].Cells[m].Value = Operators.ConcatenateObject(dgv.Rows[k].Cells[this.myYaxis[m]].FormattedValue, "");
                                }
                            }
                        }
                    }
                    else
                    {
                        d.RowCount = 1;
                    }
                    Application.DoEvents();
                    if (!this.iscancel)
                    {
                        int num14;
                        if (this.myYaxis == null)
                        {
                            num14 = 0;
                        }
                        else
                        {
                            num14 = this.myYaxis.Length;
                        }
                        if (this.myXaxis != null)
                        {
                            this.Myadd(null, 0, tv, dgv, d);
                            if (this.iscancel)
                            {
                                return;
                            }
                            if (this.myYaxis == null)
                            {
                                d.Columns.RemoveAt(0);
                            }
                        }
                        else
                        {
                            d.ColumnCount += this.myZaxis.Length;
                            if (this.myYaxis == null)
                            {
                                d.ColumnCount--;
                            }
                            int num15 = 0;
                            int num16 = this.myZaxis.Length - 1;
                            for (int n = num15; n <= num16; n++)
                            {
                                if (String.Compare(Strings.UCase(this.myZaxis[n]), "$COUNT$", false) == 0)
                                {
                                    d.Columns[num14 + n].HeaderText = "行数";
                                    d.Columns[num14 + n].Tag = "";
                                    tv.Nodes.Add("行数");
                                }
                                else
                                {
                                    string ztitle = this.GetZTitle(dgv, n);
                                    d.Columns[num14 + n].HeaderText = ztitle;
                                    tv.Nodes.Add(ztitle);
                                }
                                d.Columns[num14 + n].DefaultCellStyle.Alignment = this.GetZAlign(n);
                                d.Columns[num14 + n].DefaultCellStyle.Format = this.GetZFormat(n);
                            }
                            int num17 = 0;
                            int num18 = d.RowCount - 1;
                            for (int num19 = num17; num19 <= num18; num19++)
                            {
                                Application.DoEvents();
                                this.zt.Text = string.Concat(new string[]
                                {
                                    "正在处理第【",
                                    Convert.ToString(num19 + 1),
                                    "】行，共【",
                                    Convert.ToString(d.RowCount),
                                    "】行，已完成【",
                                    Strings.Format((double)(num19 + 1) / (double)d.RowCount, "#,###.##%"),
                                    "】"
                                });
                                if (this.iscancel)
                                {
                                    return;
                                }
                                int num20 = 0;
                                int num21 = this.myZaxis.Length - 1;
                                for (int num22 = num20; num22 <= num21; num22++)
                                {
                                    if (this.iscancel)
                                    {
                                        return;
                                    }
                                    string sumValue = this.GetSumValue(null, this.myZaxis[num22], num22, dgv, d, num19, num14 + num22);
                                    if (String.Compare(sumValue, "", false) == 0)
                                    {
                                        d.Rows[num19].Cells[num14 + num22].Value = "";
                                    }
                                    else
                                    {
                                        d.Rows[num19].Cells[num14 + num22].Value = Convert.ToDecimal(sumValue);
                                    }
                                }
                            }
                        }
                        if (!this.iscancel)
                        {
                            if (this.myaddtotalrow)
                            {
                                d.RowCount++;
                                decimal num23 = 0m;
                                int num24;
                                if (this.myYaxis == null)
                                {
                                    num24 = 0;
                                }
                                else
                                {
                                    num24 = this.myYaxis.Length;
                                    int num25 = 0;
                                    int num26 = num24 - 1;
                                    for (int num27 = num25; num27 <= num26; num27++)
                                    {
                                        d.Rows[d.RowCount - 1].Cells[num27].Value = "合 计";
                                        d.Rows[d.RowCount - 1].Cells[num27].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        d.Rows[d.RowCount - 1].Cells[num27].Style.ForeColor = Color.Red;
                                        d.Rows[d.RowCount - 1].Cells[num27].Style.Font = new Font("黑体", 9f, FontStyle.Bold);
                                    }
                                    d.MergeCell(d.RowCount - 1, d.RowCount - 1, 0, num24 - 1);
                                }
                                int num28 = num24;
                                int num29 = d.ColumnCount - 1;
                                for (int num30 = num28; num30 <= num29; num30++)
                                {
                                    num23 = 0m;
                                    string left = this.myzvaluetype[(num30 - num24) % this.myZaxis.Length];
                                    if (String.Compare(left, "最大值", false) == 0)
                                    {
                                        bool flag2 = true;
                                        int num31 = 0;
                                        int num32 = d.RowCount - 1;
                                        for (int num33 = num31; num33 <= num32; num33++)
                                        {
                                            if (String.Compare(Convert.ToString(d.Rows[num33].Cells[num30].Value), "", false) != 0)
                                            {
                                                if (flag2)
                                                {
                                                    num23 = Convert.ToDecimal(d.Rows[num33].Cells[num30].Value);
                                                    flag2 = false;
                                                }
                                                else if (decimal.Compare(num23, Convert.ToDecimal(d.Rows[num33].Cells[num30].Value)) < 0)
                                                {
                                                    num23 = Convert.ToDecimal(d.Rows[num33].Cells[num30].Value);
                                                }
                                            }
                                        }
                                    }
                                    else if (String.Compare(left, "最小值", false) == 0)
                                    {
                                        bool flag3 = true;
                                        int num34 = 0;
                                        int num35 = d.RowCount - 1;
                                        for (int num36 = num34; num36 <= num35; num36++)
                                        {
                                            if (String.Compare(Convert.ToString(d.Rows[num36].Cells[num30].Value), "", false) != 0)
                                            {
                                                if (flag3)
                                                {
                                                    num23 = Convert.ToDecimal(d.Rows[num36].Cells[num30].Value);
                                                    flag3 = false;
                                                }
                                                else if (decimal.Compare(num23, Convert.ToDecimal(d.Rows[num36].Cells[num30].Value)) > 0)
                                                {
                                                    num23 = Convert.ToDecimal(d.Rows[num36].Cells[num30].Value);
                                                }
                                            }
                                        }
                                    }
                                    else if (String.Compare(left, "平均值", false) == 0)
                                    {
                                        decimal num37 = 0m;
                                        int num38 = 0;
                                        int num39 = d.RowCount - 1;
                                        for (int num40 = num38; num40 <= num39; num40++)
                                        {
                                            if (String.Compare(Convert.ToString(d.Rows[num40].Cells[num30].Value), "", false) != 0)
                                            {
                                                num37 = decimal.Add(num37, Convert.ToDecimal(d.Rows[num40].Cells[num30].Tag));
                                                num23 = decimal.Add(num23, decimal.Multiply(Convert.ToDecimal(d.Rows[num40].Cells[num30].Tag), Convert.ToDecimal(d.Rows[num40].Cells[num30].Value)));
                                            }
                                        }
                                        if (decimal.Compare(num37, 0m) == 0)
                                        {
                                            num23 = 0m;
                                        }
                                        else
                                        {
                                            num23 = decimal.Divide(num23, num37);
                                        }
                                    }
                                    else
                                    {
                                        int num41 = 0;
                                        int num42 = d.RowCount - 1;
                                        for (int num43 = num41; num43 <= num42; num43++)
                                        {
                                            if (String.Compare(Convert.ToString(d.Rows[num43].Cells[num30].Value), "", false) != 0)
                                            {
                                                num23 = decimal.Add(num23, Convert.ToDecimal(d.Rows[num43].Cells[num30].Value));
                                            }
                                        }
                                    }
                                    d.Rows[d.RowCount - 1].Cells[num30].Value = num23;
                                    d.Rows[d.RowCount - 1].Cells[num30].Style.Font = new Font("黑体", 9f, FontStyle.Bold);
                                    d.Rows[d.RowCount - 1].Cells[num30].Style.ForeColor = Color.Red;
                                }
                                this.hasaddsumrow = true;
                            }
                            this.d1.ColHeaderTreeView = this.tv1;
                            int columnHeadersHeight = this.d1.ColumnHeadersHeight;
                            this.d1.ColumnHeadersHeight = 23;
                            this.d1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            this.d1.ColumnHeadersHeight = columnHeadersHeight;
                        }
                    }
                }
            }
        }

        // Token: 0x06000109 RID: 265 RVA: 0x000105B0 File Offset: 0x0000E7B0
        private DataGridViewContentAlignment GetZAlign(int num)
        {
            DataGridViewContentAlignment result;
            if (this.myzalign == null)
            {
                result = DataGridViewContentAlignment.MiddleRight;
            }
            else if (num >= this.myzalign.Length)
            {
                result = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                switch (this.myzalign[num])
                {
                    case StringAlignment.Near:
                        result = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case StringAlignment.Center:
                        result = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        result = DataGridViewContentAlignment.MiddleRight;
                        break;
                }
            }
            return result;
        }

        // Token: 0x0600010A RID: 266 RVA: 0x00010600 File Offset: 0x0000E800
        private string GetZFormat(int num)
        {
            string result;
            if (this.myzformat == null)
            {
                result = "#,###.##";
            }
            else if (num >= this.myzformat.Length)
            {
                result = "#,###.##";
            }
            else
            {
                if (this.myzformat[num] != null)
                {
                    if (String.Compare(this.myzformat[num], "", false) != 0)
                    {
                        return this.myzformat[num];
                    }
                }
                result = "#,###.##";
            }
            return result;
        }

        // Token: 0x0600010B RID: 267 RVA: 0x00010664 File Offset: 0x0000E864
        private void Myadd(TreeNode parentnode, int num, TreeView tv, DataGridView sdgv, DataGridView ddgv)
        {
            string[] distinctValue = this.GetDistinctValue(parentnode, this.myXaxis[num], sdgv);
            string text;
            if (num == 0)
            {
                this.xy = "";
                text = "";
            }
            else
            {
                text = this.xy;
            }
            int num2 = 0;
            checked
            {
                int num3 = distinctValue.Length - 1;
                for (int i = num2; i <= num3; i++)
                {
                    string text2;
                    if (num == 0)
                    {
                        this.xy = string.Concat(new string[]
                        {
                            "正在处理第【",
                            Convert.ToString(num + 1),
                            "层",
                            Convert.ToString(i + 1),
                            "/",
                            Convert.ToString(distinctValue.Length),
                            "列】"
                        });
                        text2 = this.xy;
                    }
                    else
                    {
                        this.xy = string.Concat(new string[]
                        {
                            text,
                            ",【",
                            Convert.ToString(num + 1),
                            "层",
                            Convert.ToString(i + 1),
                            "/",
                            Convert.ToString(distinctValue.Length),
                            "列】"
                        });
                        text2 = this.xy;
                    }
                    TreeNode treeNode;
                    if (parentnode == null)
                    {
                        treeNode = tv.Nodes.Add(distinctValue[i]);
                        treeNode.Name = this.myXaxis[num];
                        treeNode.Text = distinctValue[i];
                        treeNode.Tag = this.myXaxis[num];
                    }
                    else
                    {
                        treeNode = parentnode.Nodes.Add(distinctValue[i]);
                        treeNode.Name = this.myXaxis[num];
                        treeNode.Text = distinctValue[i];
                        treeNode.Tag = this.myXaxis[num];
                    }
                    if (num == this.myXaxis.Length - 1)
                    {
                        int columnCount = ddgv.ColumnCount;
                        ddgv.ColumnCount += this.myZaxis.Length;
                        int num4 = 0;
                        int num5 = this.myZaxis.Length - 1;
                        for (int j = num4; j <= num5; j++)
                        {
                            if (String.Compare(Strings.UCase(this.myZaxis[j]), "$COUNT$", false) == 0)
                            {
                                treeNode.Nodes.Add("行数");
                                ddgv.Columns[columnCount + j].HeaderText = "行数" + Convert.ToString(this.f_xh);
                            }
                            else
                            {
                                string ztitle = this.GetZTitle(sdgv, j);
                                treeNode.Nodes.Add(ztitle);
                                ddgv.Columns[columnCount + j].HeaderText = ztitle + Convert.ToString(this.f_xh);
                            }
                            ddgv.Columns[columnCount + j].DefaultCellStyle.Alignment = this.GetZAlign(j);
                            ddgv.Columns[columnCount + j].DefaultCellStyle.Format = this.GetZFormat(j);
                            ddgv.Columns[columnCount + j].Tag = this.GetTaginfo(treeNode);
                        }
                        this.f_xh++;
                        int num6 = 0;
                        int num7 = ddgv.RowCount - 1;
                        for (int k = num6; k <= num7; k++)
                        {
                            Application.DoEvents();
                            this.zt.Text = string.Concat(new string[]
                            {
                                text2,
                                ",【",
                                Convert.ToString(k + 1),
                                "行/",
                                Convert.ToString(ddgv.RowCount),
                                "行】"
                            });
                            if (this.iscancel)
                            {
                                return;
                            }
                            int num8 = 0;
                            int num9 = this.myZaxis.Length - 1;
                            for (int l = num8; l <= num9; l++)
                            {
                                string sumValue = this.GetSumValue(treeNode, this.myZaxis[l], l, sdgv, ddgv, k, columnCount + l);
                                if (String.Compare(sumValue, "", false) == 0)
                                {
                                    ddgv.Rows[k].Cells[columnCount + l].Value = "";
                                }
                                else
                                {
                                    ddgv.Rows[k].Cells[columnCount + l].Value = Convert.ToDecimal(sumValue);
                                }
                            }
                        }
                        if (this.iscancel)
                        {
                            break;
                        }
                    }
                    else
                    {
                        this.Myadd(treeNode, num + 1, tv, sdgv, ddgv);
                        if (this.iscancel)
                        {
                            break;
                        }
                    }
                }
            }
        }

        // Token: 0x0600010C RID: 268 RVA: 0x00010ABC File Offset: 0x0000ECBC
        private string GetZTitle(DataGridView dgv, int t)
        {
            string text;
            if (String.Compare(this.myztitle[t], "", false) == 0)
            {
                text = dgv.Columns[this.myZaxis[t]].HeaderText;
                string left = this.myzvaluetype[t];
                if (String.Compare(left, "计数", false) == 0)
                {
                    text += "(计数)";
                }
                else if (String.Compare(left, "最大值", false) == 0)
                {
                    text += "(最大值)";
                }
                else if (String.Compare(left, "最小值", false) == 0)
                {
                    text += "(最小值)";
                }
                else if (String.Compare(left, "平均值", false) == 0)
                {
                    text += "(平均值)";
                }
            }
            else
            {
                text = this.myztitle[t];
            }
            return text;
        }

        // Token: 0x0600010D RID: 269 RVA: 0x00010B84 File Offset: 0x0000ED84
        private string GetTaginfo(TreeNode node)
        {
            string text = "";
            string result;
            if (node == null)
            {
                result = "";
            }
            else
            {
                while (node != null)
                {
                    if (String.Compare(text, "", false) == 0)
                    {
                        text = node.Text;
                    }
                    else
                    {
                        text = node.Text + "\0" + text;
                    }
                    node = node.Parent;
                }
                result = text;
            }
            return result;
        }

        // Token: 0x0600010E RID: 270 RVA: 0x00010BDC File Offset: 0x0000EDDC
        private string GetSumValue(TreeNode node, string hzl, int index, DataGridView sdgv, DataGridView ddgv, int rowindex, int colindex)
        {
            decimal num = 0m;
            bool flag = true;
            int num2 = 0;
            bool flag2 = false;
            int num3 = 0;
            checked
            {
                int num4 = sdgv.RowCount - 1;
                int i = num3;
            IL_1F4:
                decimal num8 = 0;
                decimal num9 = 0;
                while (i <= num4)
                {
                    bool flag3 = true;
                    for (TreeNode treeNode = node; treeNode != null; treeNode = treeNode.Parent)
                    {
                        if (Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(sdgv.Rows[i].Cells[Convert.ToString(treeNode.Tag)].FormattedValue, ""), treeNode.Text, false))
                        {
                            flag3 = false;
                        IL_85:
                            if (flag3 && this.myYaxis != null)
                            {
                                int num5 = 0;
                                int num6 = this.myYaxis.Length - 1;
                                for (int j = num5; j <= num6; j++)
                                {
                                    if (Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(sdgv.Rows[i].Cells[this.myYaxis[j]].FormattedValue, ""), Operators.ConcatenateObject(ddgv.Rows[rowindex].Cells[j].FormattedValue, ""), false))
                                    {
                                        flag3 = false;
                                        break;
                                    }
                                }
                            }
                            if (flag3)
                            {
                                num2++;
                                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sdgv.Rows[i].Cells[hzl].Value)) && Versioned.IsNumeric(Operators.ConcatenateObject(sdgv.Rows[i].Cells[hzl].Value, "")))
                                {
                                    decimal num7 = Convert.ToDecimal(Operators.ConcatenateObject(sdgv.Rows[i].Cells[hzl].Value, ""));
                                    num = decimal.Add(num, num7);
                                    if (flag)
                                    {
                                        num8 = num7;
                                        num9 = num7;
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (decimal.Compare(num8, num7) > 0)
                                        {
                                            num8 = num7;
                                        }
                                        if (decimal.Compare(num9, num7) < 0)
                                        {
                                            num9 = num7;
                                        }
                                    }
                                }
                            }
                            if (flag3)
                            {
                                flag2 = true;
                            }
                            i++;
                            goto IL_1F4;
                        }
                    }

                }
                string result;
                if (flag2)
                {
                    string left = this.myzvaluetype[index];
                    if (String.Compare(left, "计数", false) == 0)
                    {
                        result = Convert.ToString(num2);
                    }
                    else if (String.Compare(left, "最大值", false) == 0)
                    {
                        result = Convert.ToString(num9);
                    }
                    else if (String.Compare(left, "最小值", false) == 0)
                    {
                        result = Convert.ToString(num8);
                    }
                    else if (String.Compare(left, "平均值", false) == 0)
                    {
                        ddgv.Rows[rowindex].Cells[colindex].Tag = Convert.ToString(num2);
                        if (num2 != 0)
                        {
                            result = Convert.ToString(decimal.Divide(num, new decimal(num2)));
                        }
                        else
                        {
                            result = "";
                        }
                    }
                    else
                    {
                        result = Convert.ToString(num);
                    }
                }
                else
                {
                    result = "";
                }
                return result;
            }
        }

        // Token: 0x0600010F RID: 271 RVA: 0x00010EB4 File Offset: 0x0000F0B4
        private string[] GetDistinctValue(TreeNode node, string ss, DataGridView dgv)
        {
            string[] array = null;
            int num = 0;
            checked
            {
                int num2 = dgv.RowCount - 1;
                int i = num;
            IL_11A:
                while (i <= num2)
                {
                    TreeNode treeNode = node;
                    bool flag = true;
                    bool flag2 = true;
                    string text = Convert.ToString(Operators.ConcatenateObject(dgv.Rows[i].Cells[ss].FormattedValue, ""));
                    while (treeNode != null)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(dgv.Rows[i].Cells[treeNode.Name].FormattedValue, ""), treeNode.Text, false))
                        {
                            flag = false;
                        IL_9F:
                            if (flag)
                            {
                                if (array != null)
                                {
                                    int num3 = 0;
                                    int num4 = array.Length - 1;
                                    int j = num3;
                                    while (j <= num4)
                                    {
                                        if (String.Compare(text, array[j], false) == 0)
                                        {
                                            flag2 = true;
                                        IL_D6:
                                            if (j > array.Length - 1)
                                            {
                                                flag2 = false;
                                                goto IL_E1;
                                            }
                                            goto IL_E1;
                                        }
                                        else
                                        {
                                            j++;
                                        }
                                    }

                                }
                                flag2 = false;
                            }
                        IL_E1:
                            if (!flag2)
                            {
                                if (array == null)
                                {
                                    array = new string[1];
                                }
                                else
                                {
                                    array = (string[])Utils.CopyArray((Array)array, new string[array.Length + 1]);
                                }
                                array[array.Length - 1] = text;
                            }
                            i++;
                            goto IL_11A;
                        }
                        treeNode = treeNode.Parent;
                    }

                }
                return array;
            }
        }

        // Token: 0x06000110 RID: 272 RVA: 0x00010FE8 File Offset: 0x0000F1E8
        private bool CheckColumns(string[] ss, DataGridView dgv, bool allowcount)
        {
            checked
            {
                bool result;
                if (ss == null)
                {
                    result = true;
                }
                else
                {
                    int num = 0;
                    int num2 = ss.Length - 1;
                    int i = num;
                IL_71:
                    while (i <= num2)
                    {
                        bool flag = false;
                        int num3 = 0;
                        int num4 = dgv.ColumnCount - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            if (String.Compare(dgv.Columns[j].Name, ss[i], false) == 0)
                            {
                                flag = true;
                            IL_51:
                                if (!flag)
                                {
                                    if (!allowcount)
                                    {
                                        Interaction.MsgBox("无法进行汇总，列【" + ss[i] + "】在数据源表中未找到", MsgBoxStyle.OkOnly, null);
                                        return false;
                                    }
                                    if (String.Compare(Strings.UCase(ss[i]), "$COUNT$", false) != 0)
                                    {
                                        Interaction.MsgBox("无法进行汇总，列【" + ss[i] + "】在数据源表中未找到", MsgBoxStyle.OkOnly, null);
                                        return false;
                                    }
                                }
                                i++;
                                goto IL_71;
                            }
                        }

                    }
                    result = true;
                }
                return result;
            }
        }

        // Token: 0x06000111 RID: 273 RVA: 0x000110AC File Offset: 0x0000F2AC
        private void PivotTableView_Load(object sender, EventArgs e)
        {
            if (String.Compare(this.mytitle, "", false) != 0)
            {
                this.Text = this.mytitle;
            }
            this.c1.Checked = false;
            int num = 0;
            checked
            {
                int num2 = this.sourcedgv.Columns.Count - 1;
                for (int i = num; i <= num2; i++)
                {
                    if ((this.sourcedgv.Columns[i].Visible & String.Compare(Convert.ToString(this.sourcedgv.Columns[i].Tag), "不显示", false) != 0) && !(this.sourcedgv.Columns[i] is DataGridViewImageColumn))
                    {
                        this.ListBox1.Items.Add(this.sourcedgv.Columns[i].HeaderText);
                    }
                }
                this.Myinit();
                this.MyRefresh();
                this.c1.Checked = true;
            }
        }

        // Token: 0x06000112 RID: 274 RVA: 0x000111A8 File Offset: 0x0000F3A8
        private void Myinit()
        {
            bool flag = false;
            int num = 0;
            checked
            {
                int num2 = this.sourcedgv.ColumnCount - 1;
                int i = num;
            IL_77:
                while (i <= num2)
                {
                    int num3 = i + 1;
                    int num4 = this.sourcedgv.ColumnCount - 1;
                    int j = num3;
                    while (j <= num4)
                    {
                        if (String.Compare(this.sourcedgv.Columns[i].HeaderText, this.sourcedgv.Columns[j].HeaderText, false) == 0)
                        {
                            flag = true;
                        IL_70:
                            if (!flag)
                            {
                                i++;
                                goto IL_77;
                            }
                            goto IL_7C;
                        }
                        else
                        {
                            j++;
                        }
                    }

                }
            IL_7C:
                if (flag)
                {
                    Interaction.MsgBox("DataGridView控件中存在表头字段显示名称HeaderText值为【" + this.sourcedgv.Columns[i].HeaderText + "】的有多列，本控件要求列显示名称必须唯一，否则会产生问题，请修改。", MsgBoxStyle.OkOnly, "提示信息");
                }
                if (this.myXaxis != null)
                {
                    int num5 = 0;
                    int num6 = this.myXaxis.Length - 1;
                    for (int k = num5; k <= num6; k++)
                    {
                        this.ListBox2.Items.Add(this.GetDGVColumnHeaderText(this.myXaxis[k]));
                    }
                }
                if (this.myYaxis != null)
                {
                    int num7 = 0;
                    int num8 = this.myYaxis.Length - 1;
                    for (int l = num7; l <= num8; l++)
                    {
                        this.ListBox3.Items.Add(this.GetDGVColumnHeaderText(this.myYaxis[l]));
                    }
                }
                if (this.myZaxis != null)
                {
                    int num9 = 0;
                    int num10 = this.myZaxis.Length - 1;
                    for (int m = num9; m <= num10; m++)
                    {
                        this.ListBox4.Items.Add(this.GetDGVColumnHeaderText(this.myZaxis[m]));
                    }
                }
                if (this.myZaxis != null)
                {
                    if (this.myzalign == null)
                    {
                        this.myzalign = new StringAlignment[this.myZaxis.Length - 1 + 1];
                        int num11 = 0;
                        int num12 = this.myZaxis.Length - 1;
                        for (int n = num11; n <= num12; n++)
                        {
                            this.myzalign[n] = StringAlignment.Far;
                        }
                    }
                    else
                    {
                        int num13 = this.myzalign.Length;
                        this.myzalign = (StringAlignment[])Utils.CopyArray((Array)this.myzalign, new StringAlignment[this.myZaxis.Length - 1 + 1]);
                        int num14 = num13;
                        int num15 = this.myZaxis.Length - 1;
                        for (int num16 = num14; num16 <= num15; num16++)
                        {
                            this.myzalign[num16] = StringAlignment.Far;
                        }
                    }
                    if (this.myzformat == null)
                    {
                        this.myzformat = new string[this.myZaxis.Length - 1 + 1];
                        this.myzformats = new string[this.myZaxis.Length - 1 + 1];
                    }
                    else
                    {
                        this.myzformat = (string[])Utils.CopyArray((Array)this.myzformat, new string[this.myZaxis.Length - 1 + 1]);
                        this.myzformats = new string[this.myZaxis.Length - 1 + 1];
                    }
                    if (this.myzvaluetype == null)
                    {
                        this.myzvaluetype = new string[this.myZaxis.Length - 1 + 1];
                        int num17 = 0;
                        int num18 = this.myZaxis.Length - 1;
                        for (int num19 = num17; num19 <= num18; num19++)
                        {
                            this.myzvaluetype[num19] = "求和";
                        }
                    }
                    else
                    {
                        int num20 = this.myzalign.Length;
                        this.myzvaluetype = (string[])Utils.CopyArray((Array)this.myzvaluetype, new string[this.myZaxis.Length - 1 + 1]);
                        int num21 = num20;
                        int num22 = this.myZaxis.Length - 1;
                        for (int num23 = num21; num23 <= num22; num23++)
                        {
                            this.myzvaluetype[num23] = "求和";
                        }
                    }
                    if (this.myztitle == null)
                    {
                        this.myztitle = new string[this.myZaxis.Length - 1 + 1];
                    }
                    else
                    {
                        this.myztitle = (string[])Utils.CopyArray((Array)this.myztitle, new string[this.myZaxis.Length - 1 + 1]);
                    }
                }
            }
        }

        // Token: 0x06000113 RID: 275 RVA: 0x00011558 File Offset: 0x0000F758
        private string GetDGVColumnHeaderText(string columname)
        {
            int num = 0;
            checked
            {
                int num2 = this.sourcedgv.ColumnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.sourcedgv.Columns[i].Name, columname, false) == 0)
                    {
                        return this.sourcedgv.Columns[i].HeaderText;
                    }
                }
                return "";
            }
        }

        // Token: 0x06000114 RID: 276 RVA: 0x000115C4 File Offset: 0x0000F7C4
        private string GetDGVColumnName(string headertext)
        {
            int num = 0;
            checked
            {
                int num2 = this.sourcedgv.ColumnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.sourcedgv.Columns[i].HeaderText, headertext, false) == 0)
                    {
                        return this.sourcedgv.Columns[i].Name;
                    }
                }
                return "";
            }
        }

        // Token: 0x06000115 RID: 277 RVA: 0x00011630 File Offset: 0x0000F830
        private void MyRefresh()
        {
            this.tv1.Nodes.Clear();
            this.d1.Columns.Clear();
            this.d1.ReadOnly = true;
            this.lastrow = null;
            this.hasaddsumrow = false;
            checked
            {
                if (this.myZaxis != null && this.myZaxis.Length >= 1)
                {
                    this.lastrow = null;
                    this.zt.Text = "正在处理，请稍侯...";
                    this.zt.Visible = true;
                    this.d1.Visible = false;
                    int num;
                    if (this.myXaxis == null)
                    {
                        num = 0;
                    }
                    else
                    {
                        num = this.myXaxis.Length;
                    }
                    this.d1.ColumnHeadersHeight = (num + 1) * 23;
                    this.iscancel = false;
                    this.cc.Enabled = true;
                    this.Start(this.sourcedgv);
                    this.cc.Enabled = false;
                    this.d1.Visible = true;
                    if (!this.myaddtotalrow)
                    {
                        int num2 = 0;
                        int num3 = this.d1.ColumnCount - 1;
                        for (int i = num2; i <= num3; i++)
                        {
                            this.d1.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                        }
                    }
                    this.zt.Visible = false;
                    this.islastrowremoved = false;
                    if (this.d1.Rows.Count >= 1)
                    {
                        this.lastrow = this.d1.Rows[this.d1.RowCount - 1];
                    }
                }
            }
        }

        // Token: 0x06000116 RID: 278 RVA: 0x0000271D File Offset: 0x0000091D
        private void Button11_Click(object sender, EventArgs e)
        {
            this.d1.Visible = false;
            this.MyRefresh();
            this.sourcedgv.Visible = true;
        }

        // Token: 0x06000117 RID: 279 RVA: 0x000117A0 File Offset: 0x0000F9A0
        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.ListBox4.SelectedIndex;
            if (selectedIndex < 0)
            {
                this.ComboBox1.Text = "";
                this.ComboBox2.Text = "";
                this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.ComboBox1.Enabled = false;
                this.ComboBox2.Enabled = false;
                this.TextBox1.Enabled = false;
                this.TextBox2.Enabled = false;
                this.formatbotton.Enabled = false;
            }
            else
            {
                this.ComboBox1.Enabled = true;
                this.ComboBox2.Enabled = true;
                this.TextBox1.Enabled = true;
                this.TextBox2.Enabled = true;
                this.formatbotton.Enabled = true;
                switch (this.myzalign[selectedIndex])
                {
                    case StringAlignment.Near:
                        this.ComboBox1.Text = "左对齐";
                        break;
                    case StringAlignment.Center:
                        this.ComboBox1.Text = "居中对齐";
                        break;
                    case StringAlignment.Far:
                        this.ComboBox1.Text = "右对齐";
                        break;
                    default:
                        this.ComboBox1.Text = "";
                        break;
                }
                this.TextBox1.Text = this.myzformat[selectedIndex];
                this.ComboBox2.Text = this.myzvaluetype[selectedIndex];
                this.TextBox2.Text = this.myztitle[selectedIndex];
            }
        }

        // Token: 0x06000118 RID: 280 RVA: 0x00011918 File Offset: 0x0000FB18
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                string left = Convert.ToString(this.ComboBox1.SelectedItem);
                if (String.Compare(left, "", false) != 0)
                {
                    if (String.Compare(left, "右对齐", false) != 0)
                    {
                        if (String.Compare(left, "左对齐", false) == 0)
                        {
                            this.myzalign[this.ListBox4.SelectedIndex] = StringAlignment.Near;
                            return;
                        }
                        if (String.Compare(left, "居中对齐", false) == 0)
                        {
                            this.myzalign[this.ListBox4.SelectedIndex] = StringAlignment.Center;
                            return;
                        }
                        return;
                    }
                }
                this.myzalign[this.ListBox4.SelectedIndex] = StringAlignment.Far;
            }
        }

        // Token: 0x06000119 RID: 281 RVA: 0x0000273D File Offset: 0x0000093D
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                this.myzformat[this.ListBox4.SelectedIndex] = this.TextBox1.Text;
            }
        }

        // Token: 0x0600011A RID: 282 RVA: 0x0000276A File Offset: 0x0000096A
        private void MyDeleteListItem(ListBox li)
        {
            if (li.SelectedIndex >= 0)
            {
                li.Items.RemoveAt(li.SelectedIndex);
                if (this.c1.Checked)
                {
                    this.MyRefresh();
                }
            }
        }

        // Token: 0x0600011B RID: 283 RVA: 0x000119C4 File Offset: 0x0000FBC4
        private void MyRemoveArrary(ref string[] ss, int index)
        {
            checked
            {
                if (ss != null && index < ss.Length)
                {
                    if (ss.Length == 1)
                    {
                        ss = null;
                    }
                    else
                    {
                        int num = ss.Length - 2;
                        for (int i = index; i <= num; i++)
                        {
                            ss[index] = ss[index + 1];
                        }
                        ss = (string[])Utils.CopyArray((Array)ss, new string[ss.Length - 2 + 1]);
                    }
                }
            }
        }

        // Token: 0x0600011C RID: 284 RVA: 0x00011A28 File Offset: 0x0000FC28
        private void MyRemoveArrary(ref StringAlignment[] ss, int index)
        {
            checked
            {
                if (ss != null && index < ss.Length)
                {
                    if (ss.Length == 1)
                    {
                        ss = null;
                    }
                    else
                    {
                        int num = ss.Length - 2;
                        for (int i = index; i <= num; i++)
                        {
                            ss[index] = ss[index + 1];
                        }
                        ss = (StringAlignment[])Utils.CopyArray((Array)ss, new StringAlignment[ss.Length - 2 + 1]);
                    }
                }
            }
        }

        // Token: 0x0600011D RID: 285 RVA: 0x00002799 File Offset: 0x00000999
        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.ListBox3.SelectedIndex >= 0)
            {
                this.MyRemoveArrary(ref this.myYaxis, this.ListBox3.SelectedIndex);
                this.MyDeleteListItem(this.ListBox3);
            }
        }

        // Token: 0x0600011E RID: 286 RVA: 0x000027CC File Offset: 0x000009CC
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.ListBox2.SelectedIndex >= 0)
            {
                this.MyRemoveArrary(ref this.myXaxis, this.ListBox2.SelectedIndex);
                this.MyDeleteListItem(this.ListBox2);
            }
        }

        // Token: 0x0600011F RID: 287 RVA: 0x00011A8C File Offset: 0x0000FC8C
        private void Button9_Click(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                this.MyRemoveArrary(ref this.myZaxis, this.ListBox4.SelectedIndex);
                this.MyRemoveArrary(ref this.myzalign, this.ListBox4.SelectedIndex);
                this.MyRemoveArrary(ref this.myzformat, this.ListBox4.SelectedIndex);
                this.MyRemoveArrary(ref this.myzformats, this.ListBox4.SelectedIndex);
                this.MyRemoveArrary(ref this.myzvaluetype, this.ListBox4.SelectedIndex);
                this.MyRemoveArrary(ref this.myztitle, this.ListBox4.SelectedIndex);
                this.MyDeleteListItem(this.ListBox4);
                if (this.ListBox4.Items.Count <= 0)
                {
                    this.d1.Columns.Clear();
                }
            }
        }

        // Token: 0x06000120 RID: 288 RVA: 0x00011B64 File Offset: 0x0000FD64
        private void ListBoxMove(ListBox li, int num)
        {
            checked
            {
                if (li.SelectedIndex >= 0)
                {
                    int selectedIndex = li.SelectedIndex;
                    string item = Convert.ToString(li.SelectedItem);
                    li.Items.RemoveAt(selectedIndex);
                    li.Items.Insert(selectedIndex + num, item);
                    li.SelectedIndex = selectedIndex + num;
                }
            }
        }

        // Token: 0x06000121 RID: 289 RVA: 0x00011BB4 File Offset: 0x0000FDB4
        private void MoveArrary(ref string[] ss, int curindex, int num)
        {
            string text = ss[curindex];
            checked
            {
                ss[curindex] = ss[curindex + num];
                ss[curindex + num] = text;
            }
        }

        // Token: 0x06000122 RID: 290 RVA: 0x00011BD8 File Offset: 0x0000FDD8
        private void MoveArrary(ref StringAlignment[] ss, int curindex, int num)
        {
            StringAlignment stringAlignment = ss[curindex];
            checked
            {
                ss[curindex] = ss[curindex + num];
                ss[curindex + num] = stringAlignment;
            }
        }

        // Token: 0x06000123 RID: 291 RVA: 0x00011BFC File Offset: 0x0000FDFC
        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.ListBox3.SelectedIndex >= 0)
            {
                if (this.ListBox3.SelectedIndex != 0)
                {
                    this.MoveArrary(ref this.myYaxis, this.ListBox3.SelectedIndex, -1);
                    this.ListBoxMove(this.ListBox3, -1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000124 RID: 292 RVA: 0x00011C60 File Offset: 0x0000FE60
        private void Button5_Click(object sender, EventArgs e)
        {
            if (this.ListBox3.SelectedIndex >= 0)
            {
                if (this.ListBox3.SelectedIndex != checked(this.ListBox3.Items.Count - 1))
                {
                    this.MoveArrary(ref this.myYaxis, this.ListBox3.SelectedIndex, 1);
                    this.ListBoxMove(this.ListBox3, 1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000125 RID: 293 RVA: 0x00011CD4 File Offset: 0x0000FED4
        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.ListBox2.SelectedIndex >= 0)
            {
                if (this.ListBox2.SelectedIndex != 0)
                {
                    this.MoveArrary(ref this.myXaxis, this.ListBox2.SelectedIndex, -1);
                    this.ListBoxMove(this.ListBox2, -1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000126 RID: 294 RVA: 0x00011D38 File Offset: 0x0000FF38
        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.ListBox2.SelectedIndex >= 0)
            {
                if (this.ListBox2.SelectedIndex != checked(this.ListBox2.Items.Count - 1))
                {
                    this.MoveArrary(ref this.myXaxis, this.ListBox2.SelectedIndex, 1);
                    this.ListBoxMove(this.ListBox2, 1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000127 RID: 295 RVA: 0x00011DAC File Offset: 0x0000FFAC
        private void Button7_Click(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                if (this.ListBox4.SelectedIndex != 0)
                {
                    this.MoveArrary(ref this.myZaxis, this.ListBox4.SelectedIndex, -1);
                    this.MoveArrary(ref this.myzalign, this.ListBox4.SelectedIndex, -1);
                    this.MoveArrary(ref this.myzformat, this.ListBox4.SelectedIndex, -1);
                    this.MoveArrary(ref this.myzformats, this.ListBox4.SelectedIndex, -1);
                    this.MoveArrary(ref this.myzvaluetype, this.ListBox4.SelectedIndex, -1);
                    this.MoveArrary(ref this.myztitle, this.ListBox4.SelectedIndex, -1);
                    this.ListBoxMove(this.ListBox4, -1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000128 RID: 296 RVA: 0x00011E90 File Offset: 0x00010090
        private void Button8_Click(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                if (this.ListBox4.SelectedIndex != checked(this.ListBox4.Items.Count - 1))
                {
                    this.MoveArrary(ref this.myZaxis, this.ListBox4.SelectedIndex, 1);
                    this.MoveArrary(ref this.myzalign, this.ListBox4.SelectedIndex, 1);
                    this.MoveArrary(ref this.myzformat, this.ListBox4.SelectedIndex, 1);
                    this.MoveArrary(ref this.myzformats, this.ListBox4.SelectedIndex, 1);
                    this.MoveArrary(ref this.myzvaluetype, this.ListBox4.SelectedIndex, 1);
                    this.MoveArrary(ref this.myztitle, this.ListBox4.SelectedIndex, 1);
                    this.ListBoxMove(this.ListBox4, 1);
                    if (this.c1.Checked)
                    {
                        this.MyRefresh();
                    }
                }
            }
        }

        // Token: 0x06000129 RID: 297 RVA: 0x00011F84 File Offset: 0x00010184
        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.ListBox1.Items.Count != 0)
            {
                int num = this.ListBox1.IndexFromPoint(e.X, e.Y);
                if (num >= 0)
                {
                    string data = this.ListBox1.Items[num].ToString();
                    this.DoDragDrop(data, DragDropEffects.All);
                }
            }
        }

        // Token: 0x0600012A RID: 298 RVA: 0x000027FF File Offset: 0x000009FF
        private void ListBox3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        // Token: 0x0600012B RID: 299 RVA: 0x0000280C File Offset: 0x00000A0C
        private void MyAddArrary(ref string[] ss, string thevalue)
        {
            checked
            {
                if (ss == null)
                {
                    ss = new string[1];
                    ss[0] = thevalue;
                }
                else
                {
                    ss = (string[])Utils.CopyArray((Array)ss, new string[ss.Length + 1]);
                    ss[ss.Length - 1] = thevalue;
                }
            }
        }

        // Token: 0x0600012C RID: 300 RVA: 0x00002849 File Offset: 0x00000A49
        private void MyAddArrary(ref StringAlignment[] ss, StringAlignment thevalue)
        {
            checked
            {
                if (ss == null)
                {
                    ss = new StringAlignment[1];
                    ss[0] = thevalue;
                }
                else
                {
                    ss = (StringAlignment[])Utils.CopyArray((Array)ss, new StringAlignment[ss.Length + 1]);
                    ss[ss.Length - 1] = thevalue;
                }
            }
        }

        // Token: 0x0600012D RID: 301 RVA: 0x00011FE8 File Offset: 0x000101E8
        private void ListBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string text = Convert.ToString(e.Data.GetData(DataFormats.StringFormat));
                this.ListBox3.Items.Add(text);
                this.MyAddArrary(ref this.myYaxis, this.GetDGVColumnName(text));
                if (this.c1.Checked)
                {
                    this.MyRefresh();
                }
            }
        }

        // Token: 0x0600012E RID: 302 RVA: 0x00012058 File Offset: 0x00010258
        private void ListBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string text = Convert.ToString(e.Data.GetData(DataFormats.StringFormat));
                this.ListBox2.Items.Add(text);
                this.MyAddArrary(ref this.myXaxis, this.GetDGVColumnName(text));
                if (this.c1.Checked)
                {
                    this.MyRefresh();
                }
            }
        }

        // Token: 0x0600012F RID: 303 RVA: 0x000120C8 File Offset: 0x000102C8
        private void ListBox4_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string text = Convert.ToString(e.Data.GetData(DataFormats.StringFormat));
                this.ListBox4.Items.Add(text);
                this.MyAddArrary(ref this.myZaxis, this.GetDGVColumnName(text));
                this.MyAddArrary(ref this.myzalign, StringAlignment.Far);
                this.MyAddArrary(ref this.myzformat, "");
                this.MyAddArrary(ref this.myzformats, "");
                this.MyAddArrary(ref this.myzvaluetype, "求和");
                this.MyAddArrary(ref this.myztitle, "");
                if (this.c1.Checked)
                {
                    this.MyRefresh();
                }
            }
        }

        // Token: 0x06000130 RID: 304 RVA: 0x000025D6 File Offset: 0x000007D6
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x06000131 RID: 305 RVA: 0x00002886 File Offset: 0x00000A86
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.SplitContainer1.SplitterDistance < 30)
            {
                this.SplitContainer1.SplitterDistance = 200;
            }
            else
            {
                this.SplitContainer1.SplitterDistance = 1;
            }
        }

        // Token: 0x06000132 RID: 306 RVA: 0x0001218C File Offset: 0x0001038C
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (!(this.d1.RowCount <= 0 | this.d1.ColumnCount <= 0))
            {
                DGVprint dgvprint = new DGVprint();
                dgvprint.MainTitle = this.Text;
                dgvprint.Print(this.d1, true, this.d1.ColHeaderTreeView);
                dgvprint.Dispose();
            }
        }

        // Token: 0x06000133 RID: 307 RVA: 0x000028B5 File Offset: 0x00000AB5
        private void ToolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            this.ToolStripButton1_Click(null, null);
        }

        // Token: 0x06000134 RID: 308 RVA: 0x000121F0 File Offset: 0x000103F0
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (!(this.d1.RowCount <= 0 | this.d1.ColumnCount <= 0))
            {
                ExportDataGridView exportDGV = new ExportDataGridView();
                exportDGV.Title = this.Text;
                exportDGV.OpenFile = true;
                exportDGV.ExportDGV(this.d1);
                exportDGV.Dispose();
            }
        }

        // Token: 0x06000135 RID: 309 RVA: 0x000028BF File Offset: 0x00000ABF
        private void ToolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            this.ToolStripButton2_Click(null, null);
        }

        // Token: 0x06000136 RID: 310 RVA: 0x00012250 File Offset: 0x00010450
        private void formatbotton_Click(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                SetNumberFormat setNumberFormat = new SetNumberFormat();
                setNumberFormat.FormatString = this.TextBox1.Text;
                setNumberFormat.sformatstring = this.myzformats[this.ListBox4.SelectedIndex];
                if (setNumberFormat.ShowDialog(this) == DialogResult.OK)
                {
                    this.TextBox1.Text = setNumberFormat.FormatString;
                    this.myzformats[this.ListBox4.SelectedIndex] = setNumberFormat.sformatstring;
                    this.myzformat[this.ListBox4.SelectedIndex] = setNumberFormat.FormatString;
                }
                setNumberFormat.Dispose();
                if (this.c1.Checked)
                {
                    this.MyRefresh();
                }
            }
        }

        // Token: 0x06000137 RID: 311 RVA: 0x000028C9 File Offset: 0x00000AC9
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                this.myzvaluetype[this.ListBox4.SelectedIndex] = Convert.ToString(this.ComboBox2.SelectedItem);
            }
        }

        // Token: 0x06000138 RID: 312 RVA: 0x000028FB File Offset: 0x00000AFB
        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (this.ListBox4.SelectedIndex >= 0)
            {
                this.myztitle[this.ListBox4.SelectedIndex] = this.TextBox2.Text;
            }
        }

        // Token: 0x06000139 RID: 313 RVA: 0x00012304 File Offset: 0x00010504
        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            checked
            {
                if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = this.SaveFileDialog1.FileName;
                    string str = "\u0003\a\u0005";
                    string text = Module2.SaveArrayAsString2(this.myXaxis);
                    text = text + str + Module2.SaveArrayAsString2(this.myYaxis);
                    text = text + str + Module2.SaveArrayAsString2(this.myZaxis);
                    text = text + str + Module2.SaveArrayAsString2(this.myzformat);
                    text = text + str + Module2.SaveArrayAsString2(this.myzformats);
                    text = text + str + Module2.SaveArrayAsString2(this.myzvaluetype);
                    text = text + str + Module2.SaveArrayAsString2(this.myztitle);
                    if (this.myzalign == null)
                    {
                        text = text + str + Module2.SaveArrayAsString2(null);
                    }
                    else
                    {
                        string[] array = new string[this.myzalign.Length - 1 + 1];
                        int num = 0;
                        int num2 = this.myzalign.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            array[i] = Convert.ToString((int)this.myzalign[i]);
                        }
                        text = text + str + Module2.SaveArrayAsString2(array);
                    }
                    if (MyProject.Computer.FileSystem.FileExists(fileName))
                    {
                        MyProject.Computer.FileSystem.DeleteFile(fileName);
                    }
                    MyProject.Computer.FileSystem.WriteAllText(fileName, text, false);
                    Interaction.MsgBox("汇总方案保存成功", MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x0600013A RID: 314 RVA: 0x00012460 File Offset: 0x00010660
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            checked
            {
                if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = this.OpenFileDialog1.FileName;
                    string delimiter = "\u0003\a\u0005";
                    string expression = MyProject.Computer.FileSystem.ReadAllText(fileName);
                    try
                    {
                        string[] array = Strings.Split(expression, delimiter, -1, CompareMethod.Binary);
                        this.myXaxis = Module2.RestoreArrayFromString2(array[0]);
                        this.myYaxis = Module2.RestoreArrayFromString2(array[1]);
                        this.myZaxis = Module2.RestoreArrayFromString2(array[2]);
                        this.myzformat = Module2.RestoreArrayFromString2(array[3]);
                        this.myzformats = Module2.RestoreArrayFromString2(array[4]);
                        this.myzvaluetype = Module2.RestoreArrayFromString2(array[5]);
                        this.myztitle = Module2.RestoreArrayFromString2(array[6]);
                        string[] array2 = Module2.RestoreArrayFromString2(array[7]);
                        if (array2 == null)
                        {
                            this.myzalign = null;
                        }
                        else
                        {
                            this.myzalign = new StringAlignment[array2.Length - 1 + 1];
                            int num = 0;
                            int num2 = array2.Length - 1;
                            for (int i = num; i <= num2; i++)
                            {
                                this.myzalign[i] = (StringAlignment)Convert.ToInt32(array2[i]);
                            }
                        }
                        this.ListBox2.Items.Clear();
                        this.ListBox3.Items.Clear();
                        this.ListBox4.Items.Clear();
                        this.Myinit();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        // Token: 0x0600013B RID: 315 RVA: 0x000125BC File Offset: 0x000107BC
        private void d1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Color color = this.d1.RowHeadersDefaultCellStyle.ForeColor;
            if (this.d1.Rows[e.RowIndex].Selected)
            {
                color = this.d1.RowHeadersDefaultCellStyle.SelectionForeColor;
            }
            else
            {
                color = this.d1.RowHeadersDefaultCellStyle.ForeColor;
            }
            SolidBrush brush = new SolidBrush(color);
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            checked
            {
                Rectangle r = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.d1.RowHeadersWidth - 4, e.RowBounds.Height);
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, r, stringFormat);
            }
        }

        // Token: 0x0600013C RID: 316 RVA: 0x00002928 File Offset: 0x00000B28
        private void cc_Click(object sender, EventArgs e)
        {
            this.iscancel = true;
        }

        // Token: 0x0600013D RID: 317 RVA: 0x00002931 File Offset: 0x00000B31
        private void d1_Sorted(object sender, EventArgs e)
        {
            if (this.hasaddsumrow && this.lastrow != null && this.islastrowremoved)
            {
                this.d1.Rows.Add(this.lastrow);
            }
        }

        // Token: 0x0600013E RID: 318 RVA: 0x000126C0 File Offset: 0x000108C0
        private void d1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.hasaddsumrow)
            {
                if (e.RowIndex >= 0)
                {
                    this.islastrowremoved = false;
                }
                else if (this.lastrow != null)
                {
                    this.d1.Rows.Remove(this.lastrow);
                    this.islastrowremoved = true;
                }
            }
        }

        // Token: 0x04000047 RID: 71
        [AccessedThroughProperty("d1")]
        private MulHeaderDataGridView _d1;

        // Token: 0x04000048 RID: 72
        [AccessedThroughProperty("tv1")]
        private TreeView _tv1;

        // Token: 0x04000049 RID: 73
        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;

        // Token: 0x0400004A RID: 74
        [AccessedThroughProperty("复制选中内容ToolStripMenuItem")]
        private ToolStripMenuItem toolStripMenuItem_0;

        // Token: 0x0400004B RID: 75
        [AccessedThroughProperty("选中内容求和ToolStripMenuItem")]
        private ToolStripMenuItem toolStripMenuItem_1;

        // Token: 0x0400004C RID: 76
        [AccessedThroughProperty("ToolStripMenuItem1")]
        private ToolStripSeparator _ToolStripMenuItem1;

        // Token: 0x0400004D RID: 77
        [AccessedThroughProperty("数据导出ToolStripMenuItem")]
        private ToolStripMenuItem toolStripMenuItem_2;

        // Token: 0x0400004E RID: 78
        [AccessedThroughProperty("打印ToolStripMenuItem")]
        private ToolStripMenuItem toolStripMenuItem_3;

        // Token: 0x0400004F RID: 79
        [AccessedThroughProperty("ToolStrip1")]
        private ToolStrip _ToolStrip1;

        // Token: 0x04000050 RID: 80
        [AccessedThroughProperty("ToolStripButton1")]
        private ToolStripButton _ToolStripButton1;

        // Token: 0x04000051 RID: 81
        [AccessedThroughProperty("ToolStripButton2")]
        private ToolStripButton _ToolStripButton2;

        // Token: 0x04000052 RID: 82
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;

        // Token: 0x04000053 RID: 83
        [AccessedThroughProperty("ToolStripButton3")]
        private ToolStripButton _ToolStripButton3;

        // Token: 0x04000054 RID: 84
        [AccessedThroughProperty("SplitContainer1")]
        private SplitContainer _SplitContainer1;

        // Token: 0x04000055 RID: 85
        [AccessedThroughProperty("GroupBox4")]
        private GroupBox _GroupBox4;

        // Token: 0x04000056 RID: 86
        [AccessedThroughProperty("ListBox4")]
        private ListBox _ListBox4;

        // Token: 0x04000057 RID: 87
        [AccessedThroughProperty("Button7")]
        private Button _Button7;

        // Token: 0x04000058 RID: 88
        [AccessedThroughProperty("Button8")]
        private Button _Button8;

        // Token: 0x04000059 RID: 89
        [AccessedThroughProperty("Button9")]
        private Button _Button9;

        // Token: 0x0400005A RID: 90
        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        // Token: 0x0400005B RID: 91
        [AccessedThroughProperty("ListBox3")]
        private ListBox _ListBox3;

        // Token: 0x0400005C RID: 92
        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        // Token: 0x0400005D RID: 93
        [AccessedThroughProperty("Button5")]
        private Button _Button5;

        // Token: 0x0400005E RID: 94
        [AccessedThroughProperty("Button6")]
        private Button _Button6;

        // Token: 0x0400005F RID: 95
        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        // Token: 0x04000060 RID: 96
        [AccessedThroughProperty("ListBox2")]
        private ListBox _ListBox2;

        // Token: 0x04000061 RID: 97
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000062 RID: 98
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000063 RID: 99
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000064 RID: 100
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        // Token: 0x04000065 RID: 101
        [AccessedThroughProperty("ListBox1")]
        private ListBox _ListBox1;

        // Token: 0x04000066 RID: 102
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;

        // Token: 0x04000067 RID: 103
        [AccessedThroughProperty("c1")]
        private CheckBox _c1;

        // Token: 0x04000068 RID: 104
        [AccessedThroughProperty("Button11")]
        private Button _Button11;

        // Token: 0x04000069 RID: 105
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;

        // Token: 0x0400006A RID: 106
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x0400006B RID: 107
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x0400006C RID: 108
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;

        // Token: 0x0400006D RID: 109
        [AccessedThroughProperty("ToolStripButton4")]
        private ToolStripButton _ToolStripButton4;

        // Token: 0x0400006E RID: 110
        [AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator _ToolStripSeparator2;

        // Token: 0x0400006F RID: 111
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x04000070 RID: 112
        [AccessedThroughProperty("formatbotton")]
        private Button _formatbotton;

        // Token: 0x04000071 RID: 113
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x04000072 RID: 114
        [AccessedThroughProperty("ComboBox2")]
        private ComboBox _ComboBox2;

        // Token: 0x04000073 RID: 115
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000074 RID: 116
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;

        // Token: 0x04000075 RID: 117
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x04000076 RID: 118
        [AccessedThroughProperty("ToolStripButton5")]
        private ToolStripButton _ToolStripButton5;

        // Token: 0x04000077 RID: 119
        [AccessedThroughProperty("ToolStripButton6")]
        private ToolStripButton _ToolStripButton6;

        // Token: 0x04000078 RID: 120
        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;

        // Token: 0x04000079 RID: 121
        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;

        // Token: 0x0400007A RID: 122
        [AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;

        // Token: 0x0400007B RID: 123
        [AccessedThroughProperty("zt")]
        private Label _zt;

        // Token: 0x0400007C RID: 124
        [AccessedThroughProperty("cc")]
        private Button _cc;

        // Token: 0x0400007D RID: 125
        private DataGridViewRow lastrow;

        // Token: 0x0400007E RID: 126
        private bool islastrowremoved;

        // Token: 0x0400007F RID: 127
        private bool hasaddsumrow;

        // Token: 0x04000080 RID: 128
        private bool iscancel;

        // Token: 0x04000081 RID: 129
        public bool myaddtotalrow;

        // Token: 0x04000082 RID: 130
        public string[] myXaxis;

        // Token: 0x04000083 RID: 131
        public string[] myYaxis;

        // Token: 0x04000084 RID: 132
        public string[] myZaxis;

        // Token: 0x04000085 RID: 133
        public StringAlignment[] myzalign;

        // Token: 0x04000086 RID: 134
        public string[] myzformat;

        // Token: 0x04000087 RID: 135
        public string[] myzvaluetype;

        // Token: 0x04000088 RID: 136
        public string[] myztitle;

        // Token: 0x04000089 RID: 137
        private string[] myzformats;

        // Token: 0x0400008A RID: 138
        public DataGridView sourcedgv;

        // Token: 0x0400008B RID: 139
        public string mytitle;

        // Token: 0x0400008C RID: 140
        private string xy;

        // Token: 0x0400008D RID: 141
        private int f_xh;
    }
}
