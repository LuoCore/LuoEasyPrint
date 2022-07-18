using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x02000048 RID: 72
    [ToolboxItem(false)]
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public class U_Ellipse : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000ADD RID: 2781 RVA: 0x0005F69C File Offset: 0x0005D89C
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

        // Token: 0x06000ADE RID: 2782 RVA: 0x0005F6DC File Offset: 0x0005D8DC
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
            this.Name = "U_Ellipse";
            Size size = new Size(169, 37);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x06000ADF RID: 2783 RVA: 0x0005F754 File Offset: 0x0005D954
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

        // Token: 0x06000AE0 RID: 2784 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
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

        // Token: 0x06000AE1 RID: 2785 RVA: 0x0005F808 File Offset: 0x0005DA08
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

        // Token: 0x06000AE2 RID: 2786 RVA: 0x0005F874 File Offset: 0x0005DA74
        public string GetPropertyChineseName(string ename)
        {
            bool flag = false;
            int num = 0;
            checked
            {
                string result = "";
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

        // Token: 0x170003AD RID: 941
        // (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
        // (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00004D88 File Offset: 0x00002F88
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

        // Token: 0x170003AE RID: 942
        // (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
        // (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00004D91 File Offset: 0x00002F91
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

        // Token: 0x170003AF RID: 943
        // (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0005F914 File Offset: 0x0005DB14
        // (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00004DA8 File Offset: 0x00002FA8
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

        // Token: 0x170003B0 RID: 944
        // (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0005F934 File Offset: 0x0005DB34
        // (set) Token: 0x06000AEA RID: 2794 RVA: 0x00004DBF File Offset: 0x00002FBF
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

        // Token: 0x170003B1 RID: 945
        // (get) Token: 0x06000AEB RID: 2795 RVA: 0x0005F954 File Offset: 0x0005DB54
        // (set) Token: 0x06000AEC RID: 2796 RVA: 0x00004DD6 File Offset: 0x00002FD6
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

        // Token: 0x170003B2 RID: 946
        // (get) Token: 0x06000AED RID: 2797 RVA: 0x0005F974 File Offset: 0x0005DB74
        // (set) Token: 0x06000AEE RID: 2798 RVA: 0x00004DED File Offset: 0x00002FED
        [Category("外观")]
        [Description("边线宽度,不是直线的长度,以毫米为计量单位,必须大于等于0")]
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

        // Token: 0x170003B3 RID: 947
        // (get) Token: 0x06000AEF RID: 2799 RVA: 0x0005F98C File Offset: 0x0005DB8C
        // (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00004E0B File Offset: 0x0000300B
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

        // Token: 0x170003B4 RID: 948
        // (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
        // (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00004E1A File Offset: 0x0000301A
        [Description("矩形的填充颜色")]
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

        // Token: 0x06000AF3 RID: 2803 RVA: 0x0005F9BC File Offset: 0x0005DBBC
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.FillEllipse(new SolidBrush(this.FilledColor), 0, 0, this.Width, this.Height);
            e.Graphics.DrawEllipse(pen, num / 2f, num / 2f, (float)this.Width - num - 1f, (float)this.Height - num - 1f);
        }

        // Token: 0x06000AF4 RID: 2804 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000AF5 RID: 2805 RVA: 0x0005FA48 File Offset: 0x0005DC48
        public U_Ellipse()
        {
            base.Disposed += this.U_Ellipse_Disposed;
            this.theisprint = true;
            this.thelinewidth = 0.26f;
            this.thelinecolor = Color.Black;
            this.thefilledcolor = Color.Transparent;
            this.DefineProperty = new string[3, 2];
            this.InitializeComponent();
            this.MYX = this.CreateGraphics().DpiX;
            this.MYY = this.CreateGraphics().DpiY;
            this.DefineProperty = new string[8, 2];
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
        }

        // Token: 0x06000AF6 RID: 2806 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000AF7 RID: 2807 RVA: 0x0005FC10 File Offset: 0x0005DE10
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000AF8 RID: 2808 RVA: 0x0005FC28 File Offset: 0x0005DE28
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000AF9 RID: 2809 RVA: 0x0005FC40 File Offset: 0x0005DE40
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000AFA RID: 2810 RVA: 0x0005FC58 File Offset: 0x0005DE58
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000AFB RID: 2811 RVA: 0x0005FC70 File Offset: 0x0005DE70
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000AFC RID: 2812 RVA: 0x0005FC88 File Offset: 0x0005DE88
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000AFD RID: 2813 RVA: 0x0005FCA0 File Offset: 0x0005DEA0
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000AFE RID: 2814 RVA: 0x0005FCB8 File Offset: 0x0005DEB8
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000AFF RID: 2815 RVA: 0x0005FCD0 File Offset: 0x0005DED0
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000B00 RID: 2816 RVA: 0x0005FCE8 File Offset: 0x0005DEE8
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
                            array[i] = new U_Ellipse.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000B01 RID: 2817 RVA: 0x0005FDA4 File Offset: 0x0005DFA4
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000B02 RID: 2818 RVA: 0x0005FDB4 File Offset: 0x0005DFB4
        private void U_Ellipse_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000B03 RID: 2819 RVA: 0x0005FDE8 File Offset: 0x0005DFE8
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
            this.FilledColor = Module1.ConvertStringToColor(array[7]);
            this.Tag = "椭圆";
        }

        // Token: 0x06000B04 RID: 2820 RVA: 0x0005FE94 File Offset: 0x0005E094
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
            return str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.FilledColor);
        }

        // Token: 0x040005B7 RID: 1463
        private IContainer components;

        // Token: 0x040005B8 RID: 1464
        private float MYX;

        // Token: 0x040005B9 RID: 1465
        private float MYY;

        // Token: 0x040005BA RID: 1466
        private bool theisprint;

        // Token: 0x040005BB RID: 1467
        private float thelinewidth;

        // Token: 0x040005BC RID: 1468
        private Color thelinecolor;

        // Token: 0x040005BD RID: 1469
        private Color thefilledcolor;

        // Token: 0x040005BE RID: 1470
        private string[,] DefineProperty;

        // Token: 0x02000049 RID: 73
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000B05 RID: 2821 RVA: 0x00004E29 File Offset: 0x00003029
            public XpropDescriptor(U_Ellipse cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000B06 RID: 2822 RVA: 0x0005FF64 File Offset: 0x0005E164
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170003B5 RID: 949
            // (get) Token: 0x06000B07 RID: 2823 RVA: 0x0005FF74 File Offset: 0x0005E174
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000B08 RID: 2824 RVA: 0x0005FF8C File Offset: 0x0005E18C
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
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x170003B6 RID: 950
            // (get) Token: 0x06000B09 RID: 2825 RVA: 0x000600E4 File Offset: 0x0005E2E4
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170003B7 RID: 951
            // (get) Token: 0x06000B0A RID: 2826 RVA: 0x000600F4 File Offset: 0x0005E2F4
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
                    else
                    {
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x06000B0B RID: 2827 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000B0C RID: 2828 RVA: 0x00060274 File Offset: 0x0005E474
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
                    Color color=new Color();
                    this.mycc.LineColor = ((value != null) ? ((Color)value) : color);
                }
                else if (String.Compare(left, "filledcolor", false) == 0)
                {
                    Color color = new Color();
                    this.mycc.FilledColor = ((value != null) ? ((Color)value) : color);
                }
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x06000B0D RID: 2829 RVA: 0x000603E4 File Offset: 0x0005E5E4
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x040005BF RID: 1471
            private string theProp;

            // Token: 0x040005C0 RID: 1472
            private U_Ellipse mycc;
        }
    }
}
