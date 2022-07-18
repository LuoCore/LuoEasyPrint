using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x0200004A RID: 74
    [ToolboxItem(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerGenerated]
    public class U_Express : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000B0E RID: 2830 RVA: 0x000603F4 File Offset: 0x0005E5F4
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                    if (this.thetextfont != null)
                    {
                        this.thetextfont.Dispose();
                    }
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Token: 0x06000B0F RID: 2831 RVA: 0x00060444 File Offset: 0x0005E644
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
            this.Name = "U_Express";
            Size size = new Size(169, 37);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x06000B10 RID: 2832 RVA: 0x000604BC File Offset: 0x0005E6BC
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

        // Token: 0x06000B11 RID: 2833 RVA: 0x0006051C File Offset: 0x0005E71C
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

        // Token: 0x06000B12 RID: 2834 RVA: 0x00060570 File Offset: 0x0005E770
        public string GetPropertyEnglishName(string cname)
        {
            bool flag = false;
            int num = 0;
            checked
            {
                string result="";
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

        // Token: 0x06000B13 RID: 2835 RVA: 0x000605DC File Offset: 0x0005E7DC
        public string GetPropertyChineseName(string ename)
        {
            bool flag = false;
            int num = 0;
            checked
            {
                string result="";
                int num2 = this.DefineProperty.GetLength(0) - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.DefineProperty[i, 0].ToUpper(), ename.ToUpper(), false) == 0)
                    {
                        flag = true;
                   
                      
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

        // Token: 0x170003B8 RID: 952
        // (get) Token: 0x06000B14 RID: 2836 RVA: 0x00060648 File Offset: 0x0005E848
        // (set) Token: 0x06000B15 RID: 2837 RVA: 0x00004E47 File Offset: 0x00003047
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

        // Token: 0x170003B9 RID: 953
        // (get) Token: 0x06000B16 RID: 2838 RVA: 0x0006065C File Offset: 0x0005E85C
        // (set) Token: 0x06000B17 RID: 2839 RVA: 0x00004E50 File Offset: 0x00003050
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

        // Token: 0x170003BA RID: 954
        // (get) Token: 0x06000B18 RID: 2840 RVA: 0x00060670 File Offset: 0x0005E870
        // (set) Token: 0x06000B19 RID: 2841 RVA: 0x00004E59 File Offset: 0x00003059
        [Description("以套打模式打印或预览时，是否打印该控件的内容")]
        [Category("行为")]
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

        // Token: 0x170003BB RID: 955
        // (get) Token: 0x06000B1A RID: 2842 RVA: 0x00060684 File Offset: 0x0005E884
        // (set) Token: 0x06000B1B RID: 2843 RVA: 0x00004E62 File Offset: 0x00003062
        [Description("控件所处的X位置,以毫米为计量单位")]
        [Category("布局")]
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

        // Token: 0x170003BC RID: 956
        // (get) Token: 0x06000B1C RID: 2844 RVA: 0x000606A4 File Offset: 0x0005E8A4
        // (set) Token: 0x06000B1D RID: 2845 RVA: 0x00004E79 File Offset: 0x00003079
        [Category("布局")]
        [Description("控件所处的Y位置,以毫米为计量单位")]
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

        // Token: 0x170003BD RID: 957
        // (get) Token: 0x06000B1E RID: 2846 RVA: 0x000606C4 File Offset: 0x0005E8C4
        // (set) Token: 0x06000B1F RID: 2847 RVA: 0x00004E90 File Offset: 0x00003090
        [Category("布局")]
        [Description("控件的宽度,以毫米为计量单位")]
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

        // Token: 0x170003BE RID: 958
        // (get) Token: 0x06000B20 RID: 2848 RVA: 0x000606E4 File Offset: 0x0005E8E4
        // (set) Token: 0x06000B21 RID: 2849 RVA: 0x00004EA7 File Offset: 0x000030A7
        [Description("控件的高度,以毫米为计量单位")]
        [Category("布局")]
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

        // Token: 0x170003BF RID: 959
        // (get) Token: 0x06000B22 RID: 2850 RVA: 0x00060704 File Offset: 0x0005E904
        // (set) Token: 0x06000B23 RID: 2851 RVA: 0x00004EBE File Offset: 0x000030BE
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

        // Token: 0x170003C0 RID: 960
        // (get) Token: 0x06000B24 RID: 2852 RVA: 0x0006071C File Offset: 0x0005E91C
        // (set) Token: 0x06000B25 RID: 2853 RVA: 0x00004EDC File Offset: 0x000030DC
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

        // Token: 0x170003C1 RID: 961
        // (get) Token: 0x06000B26 RID: 2854 RVA: 0x00060734 File Offset: 0x0005E934
        // (set) Token: 0x06000B27 RID: 2855 RVA: 0x00004EEB File Offset: 0x000030EB
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

        // Token: 0x170003C2 RID: 962
        // (get) Token: 0x06000B28 RID: 2856 RVA: 0x0006074C File Offset: 0x0005E94C
        // (set) Token: 0x06000B29 RID: 2857 RVA: 0x00004EFA File Offset: 0x000030FA
        [Category("外观")]
        [Description("文本对齐方式")]
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

        // Token: 0x170003C3 RID: 963
        // (get) Token: 0x06000B2A RID: 2858 RVA: 0x00060764 File Offset: 0x0005E964
        // (set) Token: 0x06000B2B RID: 2859 RVA: 0x00004F09 File Offset: 0x00003109
        [Editor(typeof(U_Editor_express), typeof(UITypeEditor))]
        [Category("外观")]
        [Description("要打印的文本内容，可以包含纯文本、系统变量、自定义变量和字段变量的组合，并可对表达式进行计算")]
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

        // Token: 0x170003C4 RID: 964
        // (get) Token: 0x06000B2C RID: 2860 RVA: 0x0006077C File Offset: 0x0005E97C
        // (set) Token: 0x06000B2D RID: 2861 RVA: 0x00004F18 File Offset: 0x00003118
        [Description("文本字体")]
        [Category("外观")]
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

        // Token: 0x170003C5 RID: 965
        // (get) Token: 0x06000B2E RID: 2862 RVA: 0x00060794 File Offset: 0x0005E994
        // (set) Token: 0x06000B2F RID: 2863 RVA: 0x00004F34 File Offset: 0x00003134
        [Category("外观")]
        [Description("文本前景颜色")]
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

        // Token: 0x170003C6 RID: 966
        // (get) Token: 0x06000B30 RID: 2864 RVA: 0x000607AC File Offset: 0x0005E9AC
        // (set) Token: 0x06000B31 RID: 2865 RVA: 0x00004F43 File Offset: 0x00003143
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

        // Token: 0x170003C7 RID: 967
        // (get) Token: 0x06000B32 RID: 2866 RVA: 0x000607C4 File Offset: 0x0005E9C4
        // (set) Token: 0x06000B33 RID: 2867 RVA: 0x00004F59 File Offset: 0x00003159
        [Description("文本是否允许自动换行打印)")]
        [Category("外观")]
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

        // Token: 0x170003C8 RID: 968
        // (get) Token: 0x06000B34 RID: 2868 RVA: 0x000607D8 File Offset: 0x0005E9D8
        // (set) Token: 0x06000B35 RID: 2869 RVA: 0x00004F68 File Offset: 0x00003168
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

        // Token: 0x170003C9 RID: 969
        // (get) Token: 0x06000B36 RID: 2870 RVA: 0x000607EC File Offset: 0x0005E9EC
        // (set) Token: 0x06000B37 RID: 2871 RVA: 0x00004F77 File Offset: 0x00003177
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

        // Token: 0x170003CA RID: 970
        // (get) Token: 0x06000B38 RID: 2872 RVA: 0x00060800 File Offset: 0x0005EA00
        // (set) Token: 0x06000B39 RID: 2873 RVA: 0x00004F86 File Offset: 0x00003186
        [Category("边框")]
        [Description("是否显示上边框")]
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

        // Token: 0x170003CB RID: 971
        // (get) Token: 0x06000B3A RID: 2874 RVA: 0x00060814 File Offset: 0x0005EA14
        // (set) Token: 0x06000B3B RID: 2875 RVA: 0x00004F95 File Offset: 0x00003195
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

        // Token: 0x170003CC RID: 972
        // (get) Token: 0x06000B3C RID: 2876 RVA: 0x00060828 File Offset: 0x0005EA28
        // (set) Token: 0x06000B3D RID: 2877 RVA: 0x00004FA4 File Offset: 0x000031A4
        [Description("单元格文本与边框的间距,计量单位为毫米,且必须是整数")]
        [Category("外观")]
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

        // Token: 0x170003CD RID: 973
        // (get) Token: 0x06000B3E RID: 2878 RVA: 0x00060840 File Offset: 0x0005EA40
        // (set) Token: 0x06000B3F RID: 2879 RVA: 0x00004FB3 File Offset: 0x000031B3
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

        // Token: 0x170003CE RID: 974
        // (get) Token: 0x06000B40 RID: 2880 RVA: 0x00060854 File Offset: 0x0005EA54
        // (set) Token: 0x06000B41 RID: 2881 RVA: 0x00004FC2 File Offset: 0x000031C2
        [Description("表达式结果的显示格式,设计时不应用,打印或预览时才应用格式，仅对日期和数字两种数据格式有效")]
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

        // Token: 0x170003CF RID: 975
        // (get) Token: 0x06000B42 RID: 2882 RVA: 0x0006086C File Offset: 0x0005EA6C
        // (set) Token: 0x06000B43 RID: 2883 RVA: 0x00004FCB File Offset: 0x000031CB
        [Category("格式")]
        [TypeConverter(typeof(mbsjmodule.StrChoice3))]
        [Description("表达式结果的数据类型，该属性用于 显示格式 属性。")]
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

        // Token: 0x06000B44 RID: 2884 RVA: 0x00060884 File Offset: 0x0005EA84
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
            stringFormatFlags |= StringFormatFlags.NoClip;
            if (this.Direction)
            {
                stringFormatFlags |= StringFormatFlags.DirectionVertical;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
            }
            stringFormat.FormatFlags = stringFormatFlags;
            stringFormat.Alignment = mbsjmodule.GetHalign(this.TextAlign);
            stringFormat.LineAlignment = mbsjmodule.GetValign(this.TextAlign);
            Graphics graphics = e.Graphics;
            string textValue = this.TextValue;
            Font textFont = this.TextFont;
            Brush brush = new SolidBrush(this.TextColor);
            RectangleF layoutRectangle = new RectangleF(this.ConvertFromMM((float)this.Margins.Left, true), this.ConvertFromMM((float)this.Margins.Top, false), (float)this.Width - this.ConvertFromMM((float)(checked(this.Margins.Left + this.Margins.Right)), true), (float)this.Height - this.ConvertFromMM((float)(checked(this.Margins.Top + this.Margins.Bottom)), false));
            graphics.DrawString(textValue, textFont, brush, layoutRectangle, stringFormat);
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

        // Token: 0x06000B45 RID: 2885 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000B46 RID: 2886 RVA: 0x00060BA4 File Offset: 0x0005EDA4
        public U_Express()
        {
            base.Disposed += this.U_Express_Disposed;
            this.theisprint = true;
            this.thelinewidth = 0.2f;
            this.thelinecolor = Color.Black;
            this.thefilledcolor = Color.Transparent;
            this.thetextalign = ContentAlignment.MiddleLeft;
            this.thetext = "表达式";
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
            this.theistdborder = false;
            this.theistdbackcolor = false;
            this.thecolumntype = "";
            this.theformat = "";
            this.DefineProperty = new string[3, 2];
            this.InitializeComponent();
            this.MYX = this.CreateGraphics().DpiX;
            this.MYY = this.CreateGraphics().DpiY;
            this.DefineProperty = new string[24, 2];
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
            this.DefineProperty[9, 1] = "表达式";
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
            this.DefineProperty[20, 0] = "IsTdBorder";
            this.DefineProperty[20, 1] = "套打边框";
            this.DefineProperty[21, 0] = "IsTdBackColor";
            this.DefineProperty[21, 1] = "套打背景颜色";
            this.DefineProperty[22, 0] = "Format";
            this.DefineProperty[22, 1] = "显示格式";
            this.DefineProperty[23, 0] = "ColumnType";
            this.DefineProperty[23, 1] = "数据类型";
        }

        // Token: 0x06000B47 RID: 2887 RVA: 0x0006104C File Offset: 0x0005F24C
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000B48 RID: 2888 RVA: 0x00061064 File Offset: 0x0005F264
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000B49 RID: 2889 RVA: 0x0006107C File Offset: 0x0005F27C
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000B4A RID: 2890 RVA: 0x00061094 File Offset: 0x0005F294
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000B4B RID: 2891 RVA: 0x000610AC File Offset: 0x0005F2AC
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000B4C RID: 2892 RVA: 0x000610C4 File Offset: 0x0005F2C4
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000B4D RID: 2893 RVA: 0x000610DC File Offset: 0x0005F2DC
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000B4E RID: 2894 RVA: 0x000610F4 File Offset: 0x0005F2F4
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000B4F RID: 2895 RVA: 0x0006110C File Offset: 0x0005F30C
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000B50 RID: 2896 RVA: 0x00061124 File Offset: 0x0005F324
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000B51 RID: 2897 RVA: 0x0006113C File Offset: 0x0005F33C
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
                            array[i] = new U_Express.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000B52 RID: 2898 RVA: 0x000611F8 File Offset: 0x0005F3F8
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000B53 RID: 2899 RVA: 0x00061208 File Offset: 0x0005F408
        private void U_Express_Disposed(object sender, EventArgs e)
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

        // Token: 0x06000B54 RID: 2900 RVA: 0x00061244 File Offset: 0x0005F444
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
            this.LeftBorder = Convert.ToBoolean(Interaction.IIf(String.Compare(array[7], "1", false) == 0, true, false));
            this.RightBorder = Convert.ToBoolean(Interaction.IIf(String.Compare(array[8], "1", false) == 0, true, false));
            this.TopBorder = Convert.ToBoolean(Interaction.IIf(String.Compare(array[9], "1", false) == 0, true, false));
            this.BottomBorder = Convert.ToBoolean(Interaction.IIf(String.Compare(array[10], "1", false) == 0, true, false));
            this.FilledColor = Module1.ConvertStringToColor(array[11]);
            this.TextAlign = (ContentAlignment)Convert.ToInt32(array[12]);
            this.TextFont = Module1.ConvertStringToFont(array[13]);
            this.TextColor = Module1.ConvertStringToColor(array[14]);
            this.Cols = Convert.ToInt32(array[15]);
            this.Mulline = Convert.ToBoolean(Interaction.IIf(String.Compare(array[16], "1", false) == 0, true, false));
            this.Margins = new Margins(Convert.ToInt32(array[17]), Convert.ToInt32(array[18]), Convert.ToInt32(array[19]), Convert.ToInt32(array[20]));
            this.TextValue = array[21];
            this.Direction = Convert.ToBoolean(Interaction.IIf(String.Compare(array[22], "1", false) == 0, true, false));
            this.IsTdBorder = Convert.ToBoolean(Interaction.IIf(String.Compare(array[23], "1", false) == 0, true, false));
            this.IsTdBackColor = Convert.ToBoolean(Interaction.IIf(String.Compare(array[24], "1", false) == 0, true, false));
            try
            {
                if (array.Length == 27)
                {
                    this.Format = array[25];
                    this.ColumnType = array[26];
                }
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000B55 RID: 2901 RVA: 0x00061504 File Offset: 0x0005F704
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
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Direction, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBorder, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBackColor, "1", "0"));
            str = str + mbsjmodule.G_MB_Spetator_Proper + this.Format;
            return str + mbsjmodule.G_MB_Spetator_Proper + this.ColumnType;
        }

        // Token: 0x040005C1 RID: 1473
        private IContainer components;

        // Token: 0x040005C2 RID: 1474
        private float MYX;

        // Token: 0x040005C3 RID: 1475
        private float MYY;

        // Token: 0x040005C4 RID: 1476
        private bool theisprint;

        // Token: 0x040005C5 RID: 1477
        private float thelinewidth;

        // Token: 0x040005C6 RID: 1478
        private Color thelinecolor;

        // Token: 0x040005C7 RID: 1479
        private Color thefilledcolor;

        // Token: 0x040005C8 RID: 1480
        private ContentAlignment thetextalign;

        // Token: 0x040005C9 RID: 1481
        private string thetext;

        // Token: 0x040005CA RID: 1482
        private Font thetextfont;

        // Token: 0x040005CB RID: 1483
        private Color thetextcolor;

        // Token: 0x040005CC RID: 1484
        private int thecols;

        // Token: 0x040005CD RID: 1485
        private bool themulline;

        // Token: 0x040005CE RID: 1486
        private bool theleftborder;

        // Token: 0x040005CF RID: 1487
        private bool thetopborder;

        // Token: 0x040005D0 RID: 1488
        private bool therightborder;

        // Token: 0x040005D1 RID: 1489
        private bool thebottomborder;

        // Token: 0x040005D2 RID: 1490
        private Margins themargins;

        // Token: 0x040005D3 RID: 1491
        private bool thedirection;

        // Token: 0x040005D4 RID: 1492
        private bool theistdborder;

        // Token: 0x040005D5 RID: 1493
        private bool theistdbackcolor;

        // Token: 0x040005D6 RID: 1494
        private string thecolumntype;

        // Token: 0x040005D7 RID: 1495
        private string theformat;

        // Token: 0x040005D8 RID: 1496
        private string[,] DefineProperty;

        // Token: 0x0200004B RID: 75
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000B56 RID: 2902 RVA: 0x00004FD4 File Offset: 0x000031D4
            public XpropDescriptor(U_Express cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000B57 RID: 2903 RVA: 0x00061804 File Offset: 0x0005FA04
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170003D0 RID: 976
            // (get) Token: 0x06000B58 RID: 2904 RVA: 0x00061814 File Offset: 0x0005FA14
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000B59 RID: 2905 RVA: 0x0006182C File Offset: 0x0005FA2C
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
                else if (String.Compare(left, "format", false) == 0)
                {
                    result = this.mycc.Format;
                }
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x170003D1 RID: 977
            // (get) Token: 0x06000B5A RID: 2906 RVA: 0x00061BB8 File Offset: 0x0005FDB8
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170003D2 RID: 978
            // (get) Token: 0x06000B5B RID: 2907 RVA: 0x00061BC8 File Offset: 0x0005FDC8
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
                    else if (String.Compare(left, "istdborder", false) == 0)
                    {
                        result = this.mycc.IsTdBorder.GetType();
                    }
                    else if (String.Compare(left, "istdbackcolor", false) == 0)
                    {
                        result = this.mycc.IsTdBackColor.GetType();
                    }
                    else if (String.Compare(left, "format", false) == 0)
                    {
                        result = this.mycc.Format.GetType();
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

            // Token: 0x06000B5C RID: 2908 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000B5D RID: 2909 RVA: 0x00061FD0 File Offset: 0x000601D0
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
                else if (String.Compare(left, "istdborder", false) == 0)
                {
                    this.mycc.IsTdBorder = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "istdbackcolor", false) == 0)
                {
                    this.mycc.IsTdBackColor = Convert.ToBoolean(value);
                }
                else if (String.Compare(left, "format", false) == 0)
                {
                    this.mycc.Format = Convert.ToString(value);
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

            // Token: 0x06000B5E RID: 2910 RVA: 0x0006239C File Offset: 0x0006059C
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x040005D9 RID: 1497
            private string theProp;

            // Token: 0x040005DA RID: 1498
            private U_Express mycc;
        }
    }
}
