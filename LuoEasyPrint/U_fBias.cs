using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x0200004C RID: 76
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ToolboxItem(false)]
    [DesignerGenerated]
    public class U_fBias : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000B5F RID: 2911 RVA: 0x000623AC File Offset: 0x000605AC
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Token: 0x06000B60 RID: 2912 RVA: 0x000623EC File Offset: 0x000605EC
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
            this.Name = "U_fBias";
            Size size = new Size(156, 33);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x06000B61 RID: 2913 RVA: 0x00062464 File Offset: 0x00060664
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

        // Token: 0x06000B62 RID: 2914 RVA: 0x000624C4 File Offset: 0x000606C4
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

        // Token: 0x06000B63 RID: 2915 RVA: 0x00062518 File Offset: 0x00060718
        public string GetPropertyEnglishName(string cname)
        {
            bool flag = false;
            int num = 0;
            string result = "";
            checked
            {
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

        // Token: 0x06000B64 RID: 2916 RVA: 0x00062584 File Offset: 0x00060784
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

        // Token: 0x170003D3 RID: 979
        // (get) Token: 0x06000B65 RID: 2917 RVA: 0x000625F0 File Offset: 0x000607F0
        // (set) Token: 0x06000B66 RID: 2918 RVA: 0x00004FF2 File Offset: 0x000031F2
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

        // Token: 0x170003D4 RID: 980
        // (get) Token: 0x06000B67 RID: 2919 RVA: 0x00062604 File Offset: 0x00060804
        // (set) Token: 0x06000B68 RID: 2920 RVA: 0x00004FFB File Offset: 0x000031FB
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

        // Token: 0x170003D5 RID: 981
        // (get) Token: 0x06000B69 RID: 2921 RVA: 0x00062624 File Offset: 0x00060824
        // (set) Token: 0x06000B6A RID: 2922 RVA: 0x00005012 File Offset: 0x00003212
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

        // Token: 0x170003D6 RID: 982
        // (get) Token: 0x06000B6B RID: 2923 RVA: 0x00062644 File Offset: 0x00060844
        // (set) Token: 0x06000B6C RID: 2924 RVA: 0x00005029 File Offset: 0x00003229
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

        // Token: 0x170003D7 RID: 983
        // (get) Token: 0x06000B6D RID: 2925 RVA: 0x00062664 File Offset: 0x00060864
        // (set) Token: 0x06000B6E RID: 2926 RVA: 0x00005040 File Offset: 0x00003240
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

        // Token: 0x170003D8 RID: 984
        // (get) Token: 0x06000B6F RID: 2927 RVA: 0x00062684 File Offset: 0x00060884
        // (set) Token: 0x06000B70 RID: 2928 RVA: 0x00005057 File Offset: 0x00003257
        [Description("边线宽度,不是直线的长度,以毫米为计量单位,必须大于等于0")]
        [Category("外观")]
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

        // Token: 0x170003D9 RID: 985
        // (get) Token: 0x06000B71 RID: 2929 RVA: 0x0006269C File Offset: 0x0006089C
        // (set) Token: 0x06000B72 RID: 2930 RVA: 0x00005075 File Offset: 0x00003275
        [Description("线条颜色")]
        [Category("外观")]
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

        // Token: 0x06000B73 RID: 2931 RVA: 0x000626B4 File Offset: 0x000608B4
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.DrawLine(pen, num / 2f, (float)this.Height - num / 2f, (float)this.Width - num / 2f, num / 2f);
        }

        // Token: 0x06000B74 RID: 2932 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000B75 RID: 2933 RVA: 0x0006271C File Offset: 0x0006091C
        public U_fBias()
        {
            base.Disposed += this.U_fBias_Disposed;
            this.theisprint = true;
            this.thelinewidth = 0.26f;
            this.thelinecolor = Color.Black;
            this.DefineProperty = new string[3, 2];
            this.InitializeComponent();
            this.MYX = this.CreateGraphics().DpiX;
            this.MYY = this.CreateGraphics().DpiY;
            this.DefineProperty = new string[7, 2];
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
        }

        // Token: 0x06000B76 RID: 2934 RVA: 0x000628A0 File Offset: 0x00060AA0
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000B77 RID: 2935 RVA: 0x000628B8 File Offset: 0x00060AB8
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000B78 RID: 2936 RVA: 0x000628D0 File Offset: 0x00060AD0
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000B79 RID: 2937 RVA: 0x000628E8 File Offset: 0x00060AE8
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000B7A RID: 2938 RVA: 0x00062900 File Offset: 0x00060B00
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000B7B RID: 2939 RVA: 0x00062918 File Offset: 0x00060B18
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000B7C RID: 2940 RVA: 0x00062930 File Offset: 0x00060B30
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000B7D RID: 2941 RVA: 0x00062948 File Offset: 0x00060B48
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000B7E RID: 2942 RVA: 0x00062960 File Offset: 0x00060B60
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000B7F RID: 2943 RVA: 0x00062978 File Offset: 0x00060B78
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000B80 RID: 2944 RVA: 0x00062990 File Offset: 0x00060B90
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
                            array[i] = new U_fBias.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000B81 RID: 2945 RVA: 0x00062A4C File Offset: 0x00060C4C
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000B82 RID: 2946 RVA: 0x00062A5C File Offset: 0x00060C5C
        private void U_fBias_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000B83 RID: 2947 RVA: 0x00062A90 File Offset: 0x00060C90
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
            this.Tag = "反斜线";
        }

        // Token: 0x06000B84 RID: 2948 RVA: 0x00062B30 File Offset: 0x00060D30
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
            return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.EHeight);
        }

        // Token: 0x040005DB RID: 1499
        private IContainer components;

        // Token: 0x040005DC RID: 1500
        private float MYX;

        // Token: 0x040005DD RID: 1501
        private float MYY;

        // Token: 0x040005DE RID: 1502
        private bool theisprint;

        // Token: 0x040005DF RID: 1503
        private float thelinewidth;

        // Token: 0x040005E0 RID: 1504
        private Color thelinecolor;

        // Token: 0x040005E1 RID: 1505
        private string[,] DefineProperty;

        // Token: 0x0200004D RID: 77
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000B85 RID: 2949 RVA: 0x00005084 File Offset: 0x00003284
            public XpropDescriptor(U_fBias cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000B86 RID: 2950 RVA: 0x00062BE8 File Offset: 0x00060DE8
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170003DA RID: 986
            // (get) Token: 0x06000B87 RID: 2951 RVA: 0x00062BF8 File Offset: 0x00060DF8
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000B88 RID: 2952 RVA: 0x00062C10 File Offset: 0x00060E10
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
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x170003DB RID: 987
            // (get) Token: 0x06000B89 RID: 2953 RVA: 0x00062D44 File Offset: 0x00060F44
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170003DC RID: 988
            // (get) Token: 0x06000B8A RID: 2954 RVA: 0x00062D54 File Offset: 0x00060F54
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
                    else
                    {
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x06000B8B RID: 2955 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000B8C RID: 2956 RVA: 0x00062EAC File Offset: 0x000610AC
            public override void SetValue(object component, object value)
            {
                string left = this.theProp.ToLower();
                if (String.Compare(left, "isprint", false) == 0)
                {
                    this.mycc.IsPrint = DataTypeConversion.ToBoolean(value);
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
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x06000B8D RID: 2957 RVA: 0x00062FE8 File Offset: 0x000611E8
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x040005E2 RID: 1506
            private string theProp;

            // Token: 0x040005E3 RID: 1507
            private U_fBias mycc;
        }
    }
}
