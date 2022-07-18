using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x02000050 RID: 80
    [Browsable(false)]
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ToolboxItem(false)]
    public class U_HLine : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000BE3 RID: 3043 RVA: 0x00064FD0 File Offset: 0x000631D0
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

        // Token: 0x06000BE4 RID: 3044 RVA: 0x00065010 File Offset: 0x00063210
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.SuspendLayout();
            SizeF autoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Name = "Hline";
            Size size = new Size(169, 37);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x06000BE5 RID: 3045 RVA: 0x00065078 File Offset: 0x00063278
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

        // Token: 0x06000BE6 RID: 3046 RVA: 0x000650D8 File Offset: 0x000632D8
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

        // Token: 0x06000BE7 RID: 3047 RVA: 0x0006512C File Offset: 0x0006332C
        public string GetPropertyEnglishName(string cname)
        {
            bool flag = false;
            int num = 0;
            string result = String.Empty; ;
            checked
            {
                int num2 = this.DefineProperty.GetLength(0) - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (String.Compare(this.DefineProperty[i, 1].ToUpper(), cname.ToUpper(), false) == 0)
                    {
                        flag = true;
                    IL_46:

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

        // Token: 0x06000BE8 RID: 3048 RVA: 0x00065198 File Offset: 0x00063398
        public string GetPropertyChineseName(string ename)
        {
            bool flag = false;
            int num = 0;
            string result = String.Empty;
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

        // Token: 0x170003FB RID: 1019
        // (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00065204 File Offset: 0x00063404
        // (set) Token: 0x06000BEA RID: 3050 RVA: 0x0000525C File Offset: 0x0000345C
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

        // Token: 0x170003FC RID: 1020
        // (get) Token: 0x06000BEB RID: 3051 RVA: 0x00065218 File Offset: 0x00063418
        // (set) Token: 0x06000BEC RID: 3052 RVA: 0x00005265 File Offset: 0x00003465
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

        // Token: 0x170003FD RID: 1021
        // (get) Token: 0x06000BED RID: 3053 RVA: 0x00065238 File Offset: 0x00063438
        // (set) Token: 0x06000BEE RID: 3054 RVA: 0x0000527C File Offset: 0x0000347C
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

        // Token: 0x170003FE RID: 1022
        // (get) Token: 0x06000BEF RID: 3055 RVA: 0x00065258 File Offset: 0x00063458
        // (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00005293 File Offset: 0x00003493
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

        // Token: 0x170003FF RID: 1023
        // (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00065278 File Offset: 0x00063478
        // (set) Token: 0x06000BF2 RID: 3058 RVA: 0x000052AA File Offset: 0x000034AA
        [Category("外观")]
        [Description("直线的线宽,不是直线的长度,以毫米为计量单位,最小必须为0.15毫米")]
        public float LineWidth
        {
            get
            {
                return this.thelinewidth;
            }
            set
            {
                if ((double)value < 0.15)
                {
                    value = 0.15f;
                }
                this.thelinewidth = value;
                this.Height = checked((int)Math.Round((double)this.ConvertFromMM(value, true)));
                this.Invalidate();
            }
        }

        // Token: 0x17000400 RID: 1024
        // (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00065290 File Offset: 0x00063490
        // (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000052E2 File Offset: 0x000034E2
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

        // Token: 0x06000BF5 RID: 3061 RVA: 0x000652A8 File Offset: 0x000634A8
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.DrawLine(pen, 0f, num / 2f, (float)this.Width, num / 2f);
        }

        // Token: 0x06000BF6 RID: 3062 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000BF7 RID: 3063 RVA: 0x00065300 File Offset: 0x00063500
        public U_HLine()
        {
            base.Disposed += this.Hline_Disposed;
            this.theisprint = true;
            this.thelinewidth = 0.26f;
            this.thelinecolor = Color.Black;
            this.DefineProperty = new string[3, 2];
            this.InitializeComponent();
            this.MYX = this.CreateGraphics().DpiX;
            this.MYY = this.CreateGraphics().DpiY;
            this.DefineProperty = new string[6, 2];
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
        }

        // Token: 0x06000BF8 RID: 3064 RVA: 0x00065460 File Offset: 0x00063660
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000BF9 RID: 3065 RVA: 0x00065478 File Offset: 0x00063678
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000BFA RID: 3066 RVA: 0x00065490 File Offset: 0x00063690
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000BFB RID: 3067 RVA: 0x000654A8 File Offset: 0x000636A8
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000BFC RID: 3068 RVA: 0x000654C0 File Offset: 0x000636C0
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000BFD RID: 3069 RVA: 0x000654D8 File Offset: 0x000636D8
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000BFE RID: 3070 RVA: 0x000654F0 File Offset: 0x000636F0
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000BFF RID: 3071 RVA: 0x00065508 File Offset: 0x00063708
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000C00 RID: 3072 RVA: 0x00065520 File Offset: 0x00063720
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000C01 RID: 3073 RVA: 0x00065538 File Offset: 0x00063738
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000C02 RID: 3074 RVA: 0x00065550 File Offset: 0x00063750
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
                            array[i] = new U_HLine.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000C03 RID: 3075 RVA: 0x0006560C File Offset: 0x0006380C
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000C04 RID: 3076 RVA: 0x0006561C File Offset: 0x0006381C
        private void Hline_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000C05 RID: 3077 RVA: 0x00065650 File Offset: 0x00063850
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
            this.Tag = "横线";
        }

        // Token: 0x06000C06 RID: 3078 RVA: 0x000656E0 File Offset: 0x000638E0
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
            return str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.LineColor);
        }

        // Token: 0x040005FF RID: 1535
        private IContainer components;

        // Token: 0x04000600 RID: 1536
        private float MYX;

        // Token: 0x04000601 RID: 1537
        private float MYY;

        // Token: 0x04000602 RID: 1538
        private bool theisprint;

        // Token: 0x04000603 RID: 1539
        private float thelinewidth;

        // Token: 0x04000604 RID: 1540
        private Color thelinecolor;

        // Token: 0x04000605 RID: 1541
        private string[,] DefineProperty;

        // Token: 0x02000051 RID: 81
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000C07 RID: 3079 RVA: 0x000052F1 File Offset: 0x000034F1
            public XpropDescriptor(U_HLine cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000C08 RID: 3080 RVA: 0x00065780 File Offset: 0x00063980
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x17000401 RID: 1025
            // (get) Token: 0x06000C09 RID: 3081 RVA: 0x00065790 File Offset: 0x00063990
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000C0A RID: 3082 RVA: 0x000657A8 File Offset: 0x000639A8
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

            // Token: 0x17000402 RID: 1026
            // (get) Token: 0x06000C0B RID: 3083 RVA: 0x000658B8 File Offset: 0x00063AB8
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x17000403 RID: 1027
            // (get) Token: 0x06000C0C RID: 3084 RVA: 0x000658C8 File Offset: 0x00063AC8
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

            // Token: 0x06000C0D RID: 3085 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000C0E RID: 3086 RVA: 0x000659F4 File Offset: 0x00063BF4
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

            // Token: 0x06000C0F RID: 3087 RVA: 0x00065B0C File Offset: 0x00063D0C
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000606 RID: 1542
            private string theProp;

            // Token: 0x04000607 RID: 1543
            private U_HLine mycc;
        }
    }
}
