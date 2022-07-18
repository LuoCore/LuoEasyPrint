using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x0200004E RID: 78
    [Browsable(false)]
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ToolboxItem(false)]
    public class U_Field : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000B8E RID: 2958 RVA: 0x00062FF8 File Offset: 0x000611F8
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
                if (this.thetextfont != null)
                {
                    this.thetextfont.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Token: 0x06000B8F RID: 2959 RVA: 0x00063048 File Offset: 0x00061248
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.SuspendLayout();
            SizeF autoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Transparent;
            Padding margin = new Padding(0);
            this.Margin = margin;
            this.Name = "U_Field";
            Size size = new Size(169, 37);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x170003DD RID: 989
        // (get) Token: 0x06000B90 RID: 2960 RVA: 0x000630C0 File Offset: 0x000612C0
        private float GetX
        {
            get
            {
                return this.MYX;
            }
        }

        // Token: 0x170003DE RID: 990
        // (get) Token: 0x06000B91 RID: 2961 RVA: 0x000630D8 File Offset: 0x000612D8
        private float GetY
        {
            get
            {
                return this.MYY;
            }
        }

        // Token: 0x06000B92 RID: 2962 RVA: 0x000630F0 File Offset: 0x000612F0
        public float ConvertToMM(float tt, bool isX)
        {
            float result;
            if (isX)
            {
                result = (float)Math.Round((double)(tt / this.MYX) * 2.54 * 10.0, 2);
            }
            else
            {
                result = (float)Math.Round((double)(tt / this.MYY) * 2.54 * 10.0, 2);
            }
            return result;
        }

        // Token: 0x06000B93 RID: 2963 RVA: 0x00063150 File Offset: 0x00061350
        public float ConvertFromMM(float tt, bool isx)
        {
            float result;
            if (isx)
            {
                result = (float)((double)(tt * this.MYX) / 2.54 / 10.0);
            }
            else
            {
                result = (float)((double)(tt * this.MYY) / 2.54 / 10.0);
            }
            return result;
        }

        // Token: 0x06000B94 RID: 2964 RVA: 0x000631A4 File Offset: 0x000613A4
        public string GetPropertyEnglishName(string cname)
        {
            bool flag = false;
            int num = 0;
            checked
            {
                string result = "";
                int num2 = this.DefineProperty.GetLength(0) - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.DefineProperty[i, 1].ToUpper(), cname.ToUpper(), false) == 0)
                    {
                        flag = true;

                        if (flag)
                        {
                            result = this.DefineProperty[i, 0];
                        }
                        else
                        {
                            result = cname;
                        }

                    }
                }
                return result;
            }
        }

        // Token: 0x06000B95 RID: 2965 RVA: 0x00063210 File Offset: 0x00061410
        public string GetPropertyChineseName(string ename)
        {
            bool flag = false;
            int num = 0;
            string result = "";
            checked
            {
                int num2 = this.DefineProperty.GetLength(0) - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.DefineProperty[i, 0].ToUpper(), ename.ToUpper(), false) == 0)
                    {
                        flag = true;
                    IL_46:

                        if (flag)
                        {
                            result = this.DefineProperty[i, 1];
                        }
                        else
                        {
                            result = ename;
                        }

                    }
                }
                return result;

            }
        }

        // Token: 0x170003DF RID: 991
        // (get) Token: 0x06000B96 RID: 2966 RVA: 0x0006327C File Offset: 0x0006147C
        // (set) Token: 0x06000B97 RID: 2967 RVA: 0x000050A2 File Offset: 0x000032A2
        [Category("行为")]
        [Description("以套打模式打印或预览时，是否打印该控件的背景颜色（填充颜色）")]
        public bool IsTdBackColor
        {
            get
            {
                return this.theistdbackcolor;
            }
            set
            {
                this.theistdbackcolor = value;
            }
        }

        // Token: 0x170003E0 RID: 992
        // (get) Token: 0x06000B98 RID: 2968 RVA: 0x00063290 File Offset: 0x00061490
        // (set) Token: 0x06000B99 RID: 2969 RVA: 0x000050AB File Offset: 0x000032AB
        [Description("以套打模式打印或预览时，是否打印该控件的边框（如果设置为显示边框的话）")]
        [Category("行为")]
        public bool IsTdBorder
        {
            get
            {
                return this.theistdborder;
            }
            set
            {
                this.theistdborder = value;
            }
        }

        // Token: 0x170003E1 RID: 993
        // (get) Token: 0x06000B9A RID: 2970 RVA: 0x000632A4 File Offset: 0x000614A4
        // (set) Token: 0x06000B9B RID: 2971 RVA: 0x000050B4 File Offset: 0x000032B4
        [Category("行为")]
        [Description("以套打模式打印或预览时，是否打印该控件的内容")]
        public bool IsPrint
        {
            get
            {
                return this.theisprint;
            }
            set
            {
                this.theisprint = value;
            }
        }

        // Token: 0x170003E2 RID: 994
        // (get) Token: 0x06000B9C RID: 2972 RVA: 0x000632B8 File Offset: 0x000614B8
        // (set) Token: 0x06000B9D RID: 2973 RVA: 0x000050BD File Offset: 0x000032BD
        [Category("布局")]
        [Description("控件所处的X位置,以毫米为计量单位")]
        public float X
        {
            get
            {
                return this.ConvertToMM((float)this.Left, true);
            }
            set
            {
                this.Left = checked((int)Math.Round((double)this.ConvertFromMM(value, true)));
            }
        }

        // Token: 0x170003E3 RID: 995
        // (get) Token: 0x06000B9E RID: 2974 RVA: 0x000632D8 File Offset: 0x000614D8
        // (set) Token: 0x06000B9F RID: 2975 RVA: 0x000050D4 File Offset: 0x000032D4
        [Description("控件所处的Y位置,以毫米为计量单位")]
        [Category("布局")]
        public float Y
        {
            get
            {
                return this.ConvertToMM((float)this.Top, false);
            }
            set
            {
                this.Top = checked((int)Math.Round((double)this.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x170003E4 RID: 996
        // (get) Token: 0x06000BA0 RID: 2976 RVA: 0x000632F8 File Offset: 0x000614F8
        // (set) Token: 0x06000BA1 RID: 2977 RVA: 0x000050EB File Offset: 0x000032EB
        [Description("控件的宽度,以毫米为计量单位")]
        [Category("布局")]
        public float EWidth
        {
            get
            {
                return this.ConvertToMM((float)this.Width, true);
            }
            set
            {
                this.Width = checked((int)Math.Round((double)this.ConvertFromMM(value, true)));
            }
        }

        // Token: 0x170003E5 RID: 997
        // (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00063318 File Offset: 0x00061518
        // (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00005102 File Offset: 0x00003302
        [Category("布局")]
        [Description("控件的高度,以毫米为计量单位")]
        public float EHeight
        {
            get
            {
                return this.ConvertToMM((float)this.Height, false);
            }
            set
            {
                this.Height = checked((int)Math.Round((double)this.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x170003E6 RID: 998
        // (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00063338 File Offset: 0x00061538
        // (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00005119 File Offset: 0x00003319
        [Category("外观")]
        [Description("边线宽度,不是直线的长度,以毫米为计量单位, 必须大于等于0")]
        public float LineWidth
        {
            get
            {
                return this.thelinewidth;
            }
            set
            {
                if (value < 0f)
                {
                    value = 0f;
                }
                this.thelinewidth = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003E7 RID: 999
        // (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00063350 File Offset: 0x00061550
        // (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00005137 File Offset: 0x00003337
        [Category("外观")]
        [Description("线条颜色")]
        public Color LineColor
        {
            get
            {
                return this.thelinecolor;
            }
            set
            {
                this.thelinecolor = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003E8 RID: 1000
        // (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00063368 File Offset: 0x00061568
        // (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00005146 File Offset: 0x00003346
        [Description("文本背景颜色")]
        [Category("外观")]
        public Color FilledColor
        {
            get
            {
                return this.thefilledcolor;
            }
            set
            {
                this.thefilledcolor = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003E9 RID: 1001
        // (get) Token: 0x06000BAA RID: 2986 RVA: 0x00063380 File Offset: 0x00061580
        // (set) Token: 0x06000BAB RID: 2987 RVA: 0x00005155 File Offset: 0x00003355
        [Category("外观")]
        [Description("数据对齐方式")]
        public ContentAlignment TextAlign
        {
            get
            {
                return this.thetextalign;
            }
            set
            {
                this.thetextalign = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003EA RID: 1002
        // (get) Token: 0x06000BAC RID: 2988 RVA: 0x00063398 File Offset: 0x00061598
        // (set) Token: 0x06000BAD RID: 2989 RVA: 0x00005164 File Offset: 0x00003364
        [Description("列的数据源")]
        [TypeConverter(typeof(mbsjmodule.StrChoice))]
        [Category("数据")]
        public string TextValue
        {
            get
            {
                return this.thetext;
            }
            set
            {
                this.thetext = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003EB RID: 1003
        // (get) Token: 0x06000BAE RID: 2990 RVA: 0x000633B0 File Offset: 0x000615B0
        // (set) Token: 0x06000BAF RID: 2991 RVA: 0x00005173 File Offset: 0x00003373
        [Category("外观")]
        [Description("文本字体")]
        public Font TextFont
        {
            get
            {
                return this.thetextfont;
            }
            set
            {
                if (value != null)
                {
                    this.thetextfont = (Font)value.Clone();
                    this.Invalidate();
                }
            }
        }

        // Token: 0x170003EC RID: 1004
        // (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000633C8 File Offset: 0x000615C8
        // (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0000518F File Offset: 0x0000338F
        [Description("文本前景颜色")]
        [Category("外观")]
        public Color TextColor
        {
            get
            {
                return this.thetextcolor;
            }
            set
            {
                this.thetextcolor = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003ED RID: 1005
        // (get) Token: 0x06000BB2 RID: 2994 RVA: 0x000633E0 File Offset: 0x000615E0
        // (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0000519E File Offset: 0x0000339E
        [Description("分散打印的列数(为1表示普通打印)")]
        [Category("外观")]
        public int Cols
        {
            get
            {
                return this.thecols;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                this.thecols = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003EE RID: 1006
        // (get) Token: 0x06000BB4 RID: 2996 RVA: 0x000633F8 File Offset: 0x000615F8
        // (set) Token: 0x06000BB5 RID: 2997 RVA: 0x000051B4 File Offset: 0x000033B4
        [Category("外观")]
        [Description("文本是否允许自动换行打印。若该列为图像列，则为True表示对图像进行拉伸，为False表示对图像进行缩放)")]
        public bool Mulline
        {
            get
            {
                return this.themulline;
            }
            set
            {
                this.themulline = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003EF RID: 1007
        // (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0006340C File Offset: 0x0006160C
        // (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000051C3 File Offset: 0x000033C3
        [Category("边框")]
        [Description("是否显示左边框")]
        public bool LeftBorder
        {
            get
            {
                return this.theleftborder;
            }
            set
            {
                this.theleftborder = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F0 RID: 1008
        // (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00063420 File Offset: 0x00061620
        // (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000051D2 File Offset: 0x000033D2
        [Description("是否显示右边框")]
        [Category("边框")]
        public bool RightBorder
        {
            get
            {
                return this.therightborder;
            }
            set
            {
                this.therightborder = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F1 RID: 1009
        // (get) Token: 0x06000BBA RID: 3002 RVA: 0x00063434 File Offset: 0x00061634
        // (set) Token: 0x06000BBB RID: 3003 RVA: 0x000051E1 File Offset: 0x000033E1
        [Description("是否显示上边框")]
        [Category("边框")]
        public bool TopBorder
        {
            get
            {
                return this.thetopborder;
            }
            set
            {
                this.thetopborder = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F2 RID: 1010
        // (get) Token: 0x06000BBC RID: 3004 RVA: 0x00063448 File Offset: 0x00061648
        // (set) Token: 0x06000BBD RID: 3005 RVA: 0x000051F0 File Offset: 0x000033F0
        [Category("边框")]
        [Description("是否显示下边框")]
        public bool BottomBorder
        {
            get
            {
                return this.thebottomborder;
            }
            set
            {
                this.thebottomborder = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F3 RID: 1011
        // (get) Token: 0x06000BBE RID: 3006 RVA: 0x0006345C File Offset: 0x0006165C
        // (set) Token: 0x06000BBF RID: 3007 RVA: 0x000051FF File Offset: 0x000033FF
        [Category("外观")]
        [Description("单元格文本与边框的间距,计量单位为毫米,且必须是整数")]
        public Margins Margins
        {
            get
            {
                return this.themargins;
            }
            set
            {
                this.themargins = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F4 RID: 1012
        // (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00063474 File Offset: 0x00061674
        // (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0000520E File Offset: 0x0000340E
        [Description("列内容前缀字符,打印在该列内容的前面")]
        [Category("外观")]
        public string BeforeText
        {
            get
            {
                return this.thebeforetext;
            }
            set
            {
                this.thebeforetext = value;
                this.Invalidate();
            }
        }

        // Token: 0x170003F5 RID: 1013
        // (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0006348C File Offset: 0x0006168C
        // (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000521D File Offset: 0x0000341D
        [Description("列的显示格式,设计时不应用,打印或预览时才应用格式，仅对日期和数字两种数据格式有效")]
        [Category("格式")]
        public string Format
        {
            get
            {
                return this.theformat;
            }
            set
            {
                this.theformat = value;
            }
        }

        // Token: 0x170003F6 RID: 1014
        // (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000634A4 File Offset: 0x000616A4
        // (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00005226 File Offset: 0x00003426
        [TypeConverter(typeof(mbsjmodule.StrChoice3))]
        [Description("列的数据类型，该属性用于 显示格式 属性。")]
        [Category("格式")]
        public string ColumnType
        {
            get
            {
                return this.thecolumntype;
            }
            set
            {
                this.thecolumntype = value;
            }
        }

        // Token: 0x170003F7 RID: 1015
        // (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000634BC File Offset: 0x000616BC
        // (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0000522F File Offset: 0x0000342F
        [Category("外观")]
        [Description("文本的打印方向,为False表示是从左至右的方向,为True表示从上至下的打印方向")]
        public bool Direction
        {
            get
            {
                return this.thedirection;
            }
            set
            {
                this.thedirection = value;
                this.Invalidate();
            }
        }

        // Token: 0x06000BC8 RID: 3016 RVA: 0x000634D0 File Offset: 0x000616D0
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.FillRectangle(new SolidBrush(this.FilledColor), 0, 0, this.Width, this.Height);
            if (this.LeftBorder)
            {
                e.Graphics.DrawLine(pen, num / 2f, num / 2f, num / 2f, (float)this.Height - num);
            }
            if (this.RightBorder)
            {
                e.Graphics.DrawLine(pen, (float)this.Width - num, num / 2f, (float)this.Width - num, (float)this.Height - num / 2f);
            }
            if (this.TopBorder)
            {
                e.Graphics.DrawLine(pen, num / 2f, num / 2f, (float)this.Width - num, num / 2f);
            }
            if (this.BottomBorder)
            {
                e.Graphics.DrawLine(pen, num / 2f, (float)this.Height - num, (float)this.Width - num, (float)this.Height - num);
            }
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
            if (!this.Mulline)
            {
                stringFormatFlags |= StringFormatFlags.NoWrap;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.NoWrap;
            }
            if (this.Direction)
            {
                stringFormatFlags |= StringFormatFlags.DirectionVertical;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
            }
            stringFormatFlags |= StringFormatFlags.NoClip;
            stringFormat.FormatFlags = stringFormatFlags;
            stringFormat.Alignment = mbsjmodule.GetHalign(this.TextAlign);
            stringFormat.LineAlignment = mbsjmodule.GetValign(this.TextAlign);
            Graphics graphics = e.Graphics;
            string s = this.BeforeText + this.TextValue;
            Font textFont = this.TextFont;
            Brush brush = new SolidBrush(this.TextColor);
            RectangleF layoutRectangle = new RectangleF(this.ConvertFromMM((float)this.Margins.Left, true), this.ConvertFromMM((float)this.Margins.Top, false), (float)this.Width - this.ConvertFromMM((float)(checked(this.Margins.Left + this.Margins.Right)), true), (float)this.Height - this.ConvertFromMM((float)(checked(this.Margins.Top + this.Margins.Bottom)), false));
            graphics.DrawString(s, textFont, brush, layoutRectangle, stringFormat);
            float num2 = (float)((double)this.Width / (double)this.Cols);
            float num3 = (float)((double)this.Height / (double)this.Cols);
            checked
            {
                if (this.Direction)
                {
                    int num4 = 1;
                    int num5 = this.Cols - 1;
                    for (int i = num4; i <= num5; i++)
                    {
                        unchecked
                        {
                            float num6 = num3 * (float)i;
                            e.Graphics.DrawLine(pen, num / 2f, num6 + num / 2f, (float)this.Width, num6 + num / 2f);
                        }
                    }
                }
                else
                {
                    int num7 = 1;
                    int num8 = this.Cols - 1;
                    for (int j = num7; j <= num8; j++)
                    {
                        unchecked
                        {
                            float num9 = num2 * (float)j;
                            e.Graphics.DrawLine(pen, num9 + num / 2f, 0f, num9 + num / 2f, (float)this.Height);
                        }
                    }
                }
            }
        }

        // Token: 0x06000BC9 RID: 3017 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000BCA RID: 3018 RVA: 0x000637FC File Offset: 0x000619FC
        public U_Field()
        {
            base.Disposed += this.U_Field_Disposed;
            this.theisprint = true;
            this.thelinewidth = 0.2f;
            this.thelinecolor = Color.Black;
            this.thefilledcolor = Color.Transparent;
            this.thetextalign = ContentAlignment.MiddleLeft;
            this.thetext = "未设置数据源";
            this.thetextfont = new Font("宋体", 9f);
            this.thetextcolor = Color.Black;
            this.thecols = 1;
            this.themulline = true;
            this.theleftborder = false;
            this.thetopborder = false;
            this.therightborder = false;
            this.thebottomborder = false;
            this.themargins = new Margins(1, 1, 0, 0);
            this.thedirection = false;
            this.thebeforetext = "";
            this.theformat = "";
            this.theistdborder = false;
            this.theistdbackcolor = false;
            this.thecolumntype = "";
            this.DefineProperty = new string[3, 2];
            this.InitializeComponent();
            this.MYX = this.CreateGraphics().DpiX;
            this.MYY = this.CreateGraphics().DpiY;
            this.DefineProperty = new string[25, 2];
            this.DefineProperty[0, 0] = "IsPrint";
            this.DefineProperty[0, 1] = "是否套打";
            this.DefineProperty[1, 0] = "X";
            this.DefineProperty[1, 1] = "X位置";
            this.DefineProperty[2, 0] = "Y";
            this.DefineProperty[2, 1] = "Y位置";
            this.DefineProperty[3, 0] = "EWidth";
            this.DefineProperty[3, 1] = "宽度";
            this.DefineProperty[4, 0] = "LineWidth";
            this.DefineProperty[4, 1] = "线宽";
            this.DefineProperty[5, 0] = "LineColor";
            this.DefineProperty[5, 1] = "线条颜色";
            this.DefineProperty[6, 0] = "EHeight";
            this.DefineProperty[6, 1] = "高度";
            this.DefineProperty[7, 0] = "FilledColor";
            this.DefineProperty[7, 1] = "填充颜色";
            this.DefineProperty[8, 0] = "TextAlign";
            this.DefineProperty[8, 1] = "文本对齐方式";
            this.DefineProperty[9, 0] = "TextValue";
            this.DefineProperty[9, 1] = "数据字段";
            this.DefineProperty[10, 0] = "TextFont";
            this.DefineProperty[10, 1] = "字体";
            this.DefineProperty[11, 0] = "TextColor";
            this.DefineProperty[11, 1] = "文本颜色";
            this.DefineProperty[12, 0] = "Cols";
            this.DefineProperty[12, 1] = "分列打印";
            this.DefineProperty[13, 0] = "Mulline";
            this.DefineProperty[13, 1] = "自动换行";
            this.DefineProperty[14, 0] = "LeftBorder";
            this.DefineProperty[14, 1] = "左边框";
            this.DefineProperty[15, 0] = "RightBorder";
            this.DefineProperty[15, 1] = "右边框";
            this.DefineProperty[16, 0] = "TopBorder";
            this.DefineProperty[16, 1] = "上边框";
            this.DefineProperty[17, 0] = "BottomBorder";
            this.DefineProperty[17, 1] = "下边框";
            this.DefineProperty[18, 0] = "Margins";
            this.DefineProperty[18, 1] = "边距";
            this.DefineProperty[19, 0] = "Direction";
            this.DefineProperty[19, 1] = "文本方向";
            this.DefineProperty[20, 0] = "BeforeText";
            this.DefineProperty[20, 1] = "打印前缀";
            this.DefineProperty[21, 0] = "Format";
            this.DefineProperty[21, 1] = "显示格式";
            this.DefineProperty[22, 0] = "IsTdBorder";
            this.DefineProperty[22, 1] = "套打边框";
            this.DefineProperty[23, 0] = "IsTdBackColor";
            this.DefineProperty[23, 1] = "套打背景颜色";
            this.DefineProperty[24, 0] = "ColumnType";
            this.DefineProperty[24, 1] = "列数据类型";
        }

        // Token: 0x06000BCB RID: 3019 RVA: 0x00063CD4 File Offset: 0x00061ED4
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000BCC RID: 3020 RVA: 0x00063CEC File Offset: 0x00061EEC
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000BCD RID: 3021 RVA: 0x00063D04 File Offset: 0x00061F04
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000BCE RID: 3022 RVA: 0x00063D1C File Offset: 0x00061F1C
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000BCF RID: 3023 RVA: 0x00063D34 File Offset: 0x00061F34
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000BD0 RID: 3024 RVA: 0x00063D4C File Offset: 0x00061F4C
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000BD1 RID: 3025 RVA: 0x00063D64 File Offset: 0x00061F64
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000BD2 RID: 3026 RVA: 0x00063D7C File Offset: 0x00061F7C
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000BD3 RID: 3027 RVA: 0x00063D94 File Offset: 0x00061F94
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000BD4 RID: 3028 RVA: 0x00063DAC File Offset: 0x00061FAC
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000BD5 RID: 3029 RVA: 0x00063DC4 File Offset: 0x00061FC4
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            checked
            {
                PropertyDescriptor[] array = new PropertyDescriptor[this.DefineProperty.GetLength(0) - 1 + 1];
                int num = 0;
                int num2 = array.Length - 1;
                int i = num;
            IL_9D:
                while (i <= num2)
                {
                    Type type = this.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo propertyInfo in properties)
                    {
                        if (String.Compare(propertyInfo.Name.ToUpper(), this.DefineProperty[i, 0].ToUpper(), false) == 0)
                        {
                            attributes = Attribute.GetCustomAttributes(propertyInfo);
                        IL_82:
                            array[i] = new U_Field.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000BD6 RID: 3030 RVA: 0x00063E80 File Offset: 0x00062080
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000BD7 RID: 3031 RVA: 0x00063E90 File Offset: 0x00062090
        private void U_Field_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
                this.thetextfont = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000BD8 RID: 3032 RVA: 0x00063ECC File Offset: 0x000620CC
        public void RestoreFromString(string ss)
        {
            string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
            if (String.Compare(array[0], "1", false) == 0)
            {
                this.IsPrint = true;
            }
            else
            {
                this.IsPrint = false;
            }
            this.X = Convert.ToSingle(array[1]);
            this.Y = Convert.ToSingle(array[2]);
            this.EWidth = Convert.ToSingle(array[3]);
            this.LineWidth = Convert.ToSingle(array[4]);
            this.LineColor = Module1.ConvertStringToColor(array[5]);
            this.EHeight = Convert.ToSingle(array[6]);
            this.LeftBorder = Convert.ToBoolean(array[7]);
            this.RightBorder = Convert.ToBoolean(array[8]);
            this.TopBorder = Convert.ToBoolean(array[9]);
            this.BottomBorder = (String.Compare(array[10], "1", false) == 0);
            this.FilledColor = Module1.ConvertStringToColor(array[11]);
            this.TextAlign = (ContentAlignment)Convert.ToInt32(array[12]);
            this.TextFont = Module1.ConvertStringToFont(array[13]);
            this.TextColor = Module1.ConvertStringToColor(array[14]);
            this.Cols = Convert.ToInt32(array[15]);
            this.Mulline = Convert.ToBoolean(array[16]);
            this.Margins = new Margins(Convert.ToInt32(array[17]), Convert.ToInt32(array[18]), Convert.ToInt32(array[19]), Convert.ToInt32(array[20]));
            this.TextValue = array[21];
            this.BeforeText = array[22];
            this.Format = array[23];
            this.Direction = Convert.ToBoolean(array[24]);
            this.IsTdBorder = Convert.ToBoolean(array[25]);
            this.IsTdBackColor = Convert.ToBoolean(array[26]);
            try
            {
                if (array.Length == 28)
                {
                    this.ColumnType = array[27];
                }
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000BD9 RID: 3033 RVA: 0x000640A8 File Offset: 0x000622A8
        public string SaveAsString()
        {
            string str;
            if (this.IsPrint)
            {
                str = "1";
            }
            else
            {
                str = "0";
            }
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.X);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Y);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.EWidth);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.LineWidth);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.LineColor);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.EHeight);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.LeftBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.RightBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.TopBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.BottomBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.FilledColor);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.TextAlign);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertFontToString(this.TextFont);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.TextColor);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Cols);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Mulline, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Left);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Right);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Top);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Bottom);
            str = str + mbsjmodule.G_MB_Spetator_Proper + this.TextValue;
            str = str + mbsjmodule.G_MB_Spetator_Proper + this.BeforeText;
            str = str + mbsjmodule.G_MB_Spetator_Proper + this.Format;
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Direction, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBackColor, "1", "0"));
            return str + mbsjmodule.G_MB_Spetator_Proper + this.ColumnType;
        }

        // Token: 0x040005E4 RID: 1508
        private IContainer components;

        // Token: 0x040005E5 RID: 1509
        private float MYX;

        // Token: 0x040005E6 RID: 1510
        private float MYY;

        // Token: 0x040005E7 RID: 1511
        private bool theisprint;

        // Token: 0x040005E8 RID: 1512
        private float thelinewidth;

        // Token: 0x040005E9 RID: 1513
        private Color thelinecolor;

        // Token: 0x040005EA RID: 1514
        private Color thefilledcolor;

        // Token: 0x040005EB RID: 1515
        private ContentAlignment thetextalign;

        // Token: 0x040005EC RID: 1516
        private string thetext;

        // Token: 0x040005ED RID: 1517
        private Font thetextfont;

        // Token: 0x040005EE RID: 1518
        private Color thetextcolor;

        // Token: 0x040005EF RID: 1519
        private int thecols;

        // Token: 0x040005F0 RID: 1520
        private bool themulline;

        // Token: 0x040005F1 RID: 1521
        private bool theleftborder;

        // Token: 0x040005F2 RID: 1522
        private bool thetopborder;

        // Token: 0x040005F3 RID: 1523
        private bool therightborder;

        // Token: 0x040005F4 RID: 1524
        private bool thebottomborder;

        // Token: 0x040005F5 RID: 1525
        private Margins themargins;

        // Token: 0x040005F6 RID: 1526
        private bool thedirection;

        // Token: 0x040005F7 RID: 1527
        private string thebeforetext;

        // Token: 0x040005F8 RID: 1528
        private string theformat;

        // Token: 0x040005F9 RID: 1529
        private bool theistdborder;

        // Token: 0x040005FA RID: 1530
        private bool theistdbackcolor;

        // Token: 0x040005FB RID: 1531
        private string thecolumntype;

        // Token: 0x040005FC RID: 1532
        private string[,] DefineProperty;

        // Token: 0x0200004F RID: 79
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000BDA RID: 3034 RVA: 0x0000523E File Offset: 0x0000343E
            public XpropDescriptor(U_Field cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000BDB RID: 3035 RVA: 0x000643BC File Offset: 0x000625BC
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170003F8 RID: 1016
            // (get) Token: 0x06000BDC RID: 3036 RVA: 0x000643CC File Offset: 0x000625CC
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000BDD RID: 3037 RVA: 0x000643E4 File Offset: 0x000625E4
            public override object GetValue(object component)
            {
                string left = this.theProp.ToLower();
                object result;
                if (String.Compare(left, "isprint", false) == 0)
                {
                    result = this.mycc.IsPrint;
                }
                else if (String.Compare(left, "x", false) == 0)
                {
                    result = this.mycc.X;
                }
                else if (String.Compare(left, "y", false) == 0)
                {
                    result = this.mycc.Y;
                }
                else if (String.Compare(left, "ewidth", false) == 0)
                {
                    result = this.mycc.EWidth;
                }
                else if (String.Compare(left, "eheight", false) == 0)
                {
                    result = this.mycc.EHeight;
                }
                else if (String.Compare(left, "linewidth", false) == 0)
                {
                    result = this.mycc.LineWidth;
                }
                else if (String.Compare(left, "linecolor", false) == 0)
                {
                    result = this.mycc.LineColor;
                }
                else if (String.Compare(left, "filledcolor", false) == 0)
                {
                    result = this.mycc.FilledColor;
                }
                else if (String.Compare(left, "textalign", false) == 0)
                {
                    result = this.mycc.TextAlign;
                }
                else if (String.Compare(left, "textvalue", false) == 0)
                {
                    result = this.mycc.TextValue;
                }
                else if (String.Compare(left, "textfont", false) == 0)
                {
                    result = this.mycc.TextFont;
                }
                else if (String.Compare(left, "textcolor", false) == 0)
                {
                    result = this.mycc.TextColor;
                }
                else if (String.Compare(left, "cols", false) == 0)
                {
                    result = this.mycc.Cols;
                }
                else if (String.Compare(left, "mulline", false) == 0)
                {
                    result = this.mycc.Mulline;
                }
                else if (String.Compare(left, "leftborder", false) == 0)
                {
                    result = this.mycc.LeftBorder;
                }
                else if (String.Compare(left, "rightborder", false) == 0)
                {
                    result = this.mycc.RightBorder;
                }
                else if (String.Compare(left, "topborder", false) == 0)
                {
                    result = this.mycc.TopBorder;
                }
                else if (String.Compare(left, "bottomborder", false) == 0)
                {
                    result = this.mycc.BottomBorder;
                }
                else if (String.Compare(left, "margins", false) == 0)
                {
                    result = this.mycc.Margins;
                }
                else if (String.Compare(left, "direction", false) == 0)
                {
                    result = this.mycc.Direction;
                }
                else if (String.Compare(left, "beforetext", false) == 0)
                {
                    result = this.mycc.BeforeText;
                }
                else if (String.Compare(left, "format", false) == 0)
                {
                    result = this.mycc.Format;
                }
                else if (String.Compare(left, "istdborder", false) == 0)
                {
                    result = this.mycc.IsTdBorder;
                }
                else if (String.Compare(left, "istdbackcolor", false) == 0)
                {
                    result = this.mycc.IsTdBackColor;
                }
                else if (String.Compare(left, "columntype", false) == 0)
                {
                    result = this.mycc.ColumnType;
                }
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x170003F9 RID: 1017
            // (get) Token: 0x06000BDE RID: 3038 RVA: 0x00064794 File Offset: 0x00062994
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170003FA RID: 1018
            // (get) Token: 0x06000BDF RID: 3039 RVA: 0x000647A4 File Offset: 0x000629A4
            public override Type PropertyType
            {
                get
                {
                    string left = this.theProp.ToLower();
                    Type result;
                    if (String.Compare(left, "isprint", false) == 0)
                    {
                        result = this.mycc.IsPrint.GetType();
                    }
                    else if (String.Compare(left, "x", false) == 0)
                    {
                        result = this.mycc.X.GetType();
                    }
                    else if (String.Compare(left, "y", false) == 0)
                    {
                        result = this.mycc.Y.GetType();
                    }
                    else if (String.Compare(left, "ewidth", false) == 0)
                    {
                        result = this.mycc.EWidth.GetType();
                    }
                    else if (String.Compare(left, "eheight", false) == 0)
                    {
                        result = this.mycc.EHeight.GetType();
                    }
                    else if (String.Compare(left, "linewidth", false) == 0)
                    {
                        result = this.mycc.LineWidth.GetType();
                    }
                    else if (String.Compare(left, "linecolor", false) == 0)
                    {
                        result = this.mycc.LineColor.GetType();
                    }
                    else if (String.Compare(left, "filledcolor", false) == 0)
                    {
                        result = this.mycc.FilledColor.GetType();
                    }
                    else if (String.Compare(left, "textalign", false) == 0)
                    {
                        result = this.mycc.TextAlign.GetType();
                    }
                    else if (String.Compare(left, "textvalue", false) == 0)
                    {
                        result = this.mycc.TextValue.GetType();
                    }
                    else if (String.Compare(left, "textfont", false) == 0)
                    {
                        result = this.mycc.TextFont.GetType();
                    }
                    else if (String.Compare(left, "textcolor", false) == 0)
                    {
                        result = this.mycc.TextColor.GetType();
                    }
                    else if (String.Compare(left, "cols", false) == 0)
                    {
                        result = this.mycc.Cols.GetType();
                    }
                    else if (String.Compare(left, "mulline", false) == 0)
                    {
                        result = this.mycc.Mulline.GetType();
                    }
                    else if (String.Compare(left, "leftborder", false) == 0)
                    {
                        result = this.mycc.LeftBorder.GetType();
                    }
                    else if (String.Compare(left, "rightborder", false) == 0)
                    {
                        result = this.mycc.RightBorder.GetType();
                    }
                    else if (String.Compare(left, "topborder", false) == 0)
                    {
                        result = this.mycc.TopBorder.GetType();
                    }
                    else if (String.Compare(left, "bottomborder", false) == 0)
                    {
                        result = this.mycc.BottomBorder.GetType();
                    }
                    else if (String.Compare(left, "margins", false) == 0)
                    {
                        result = this.mycc.Margins.GetType();
                    }
                    else if (String.Compare(left, "direction", false) == 0)
                    {
                        result = this.mycc.Direction.GetType();
                    }
                    else if (String.Compare(left, "beforetext", false) == 0)
                    {
                        result = this.mycc.BeforeText.GetType();
                    }
                    else if (String.Compare(left, "format", false) == 0)
                    {
                        result = this.mycc.Format.GetType();
                    }
                    else if (String.Compare(left, "istdborder", false) == 0)
                    {
                        result = this.mycc.IsTdBorder.GetType();
                    }
                    else if (String.Compare(left, "istdbackcolor", false) == 0)
                    {
                        result = this.mycc.IsTdBackColor.GetType();
                    }
                    else if (String.Compare(left, "columntype", false) == 0)
                    {
                        result = this.mycc.ColumnType.GetType();
                    }
                    else
                    {
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x06000BE0 RID: 3040 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000BE1 RID: 3041 RVA: 0x00064BD0 File Offset: 0x00062DD0
            public override void SetValue(object component, object value)
            {
                string left = this.theProp.ToLower();
                if (String.Compare(left, "isprint", false) == 0)
                {
                    this.mycc.IsPrint = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "x", false) == 0)
                {
                    this.mycc.X = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "y", false) == 0)
                {
                    this.mycc.Y = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "ewidth", false) == 0)
                {
                    this.mycc.EWidth = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "eheight", false) == 0)
                {
                    this.mycc.EHeight = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "linewidth", false) == 0)
                {
                    this.mycc.LineWidth = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "linecolor", false) == 0)
                {
                    Color color = new Color();
                    this.mycc.LineColor = ((value != null) ? ((Color)value) : color);
                }
                else if (String.Compare(left, "filledcolor", false) == 0)
                {
                    Color color = new Color();
                    this.mycc.FilledColor = ((value != null) ? ((Color)value) : color);
                }
                else if (String.Compare(left, "textalign", false) == 0)
                {
                    this.mycc.TextAlign = (ContentAlignment)Convert.ToInt32(value);
                }
                else if (String.Compare(left, "textvalue", false) == 0)
                {
                    this.mycc.TextValue = Convert.ToString(value);
                }
                else if (String.Compare(left, "textfont", false) == 0)
                {
                    this.mycc.TextFont = (Font)value;
                }
                else if (String.Compare(left, "textcolor", false) == 0)
                {
                    Color color = new Color();
                    this.mycc.TextColor = ((value != null) ? ((Color)value) : color);
                }
                else if (String.Compare(left, "cols", false) == 0)
                {
                    this.mycc.Cols = Convert.ToInt32(value);
                }
                else if (String.Compare(left, "mulline", false) == 0)
                {
                    this.mycc.Mulline = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "leftborder", false) == 0)
                {
                    this.mycc.LeftBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "rightborder", false) == 0)
                {
                    this.mycc.RightBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "topborder", false) == 0)
                {
                    this.mycc.TopBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "bottomborder", false) == 0)
                {
                    this.mycc.BottomBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "margins", false) == 0)
                {
                    this.mycc.Margins = (Margins)value;
                }
                else if (String.Compare(left, "direction", false) == 0)
                {
                    this.mycc.Direction = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "beforetext", false) == 0)
                {
                    this.mycc.BeforeText = Convert.ToString(value);
                }
                else if (String.Compare(left, "format", false) == 0)
                {
                    this.mycc.Format = Convert.ToString(value);
                }
                else if (String.Compare(left, "istdborder", false) == 0)
                {
                    this.mycc.IsTdBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "istdbackcolor", false) == 0)
                {
                    this.mycc.IsTdBackColor = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "columntype", false) == 0)
                {
                    this.mycc.ColumnType = Convert.ToString(value);
                }
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x06000BE2 RID: 3042 RVA: 0x00064FC0 File Offset: 0x000631C0
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x040005FD RID: 1533
            private string theProp;

            // Token: 0x040005FE RID: 1534
            private U_Field mycc;
        }
    }
}
