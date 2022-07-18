using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x02000041 RID: 65
    [Browsable(false)]
    [ToolboxItem(false)]
    [DesignerGenerated]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class U_Bias : UserControl, IControl, ICustomTypeDescriptor
    {
        // Token: 0x06000A55 RID: 2645 RVA: 0x0005C7F8 File Offset: 0x0005A9F8
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

        // Token: 0x06000A56 RID: 2646 RVA: 0x0005C838 File Offset: 0x0005AA38
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
            this.Name = "U_Bias";
            Size size = new Size(156, 33);
            this.Size = size;
            this.ResumeLayout(false);
        }

        // Token: 0x06000A57 RID: 2647 RVA: 0x0005C8B0 File Offset: 0x0005AAB0
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

        // Token: 0x06000A58 RID: 2648 RVA: 0x0005C910 File Offset: 0x0005AB10
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

        // Token: 0x06000A59 RID: 2649 RVA: 0x0005C964 File Offset: 0x0005AB64
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

        // Token: 0x06000A5A RID: 2650 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
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

        // Token: 0x17000387 RID: 903
        // (get) Token: 0x06000A5B RID: 2651 RVA: 0x0005CA3C File Offset: 0x0005AC3C
        // (set) Token: 0x06000A5C RID: 2652 RVA: 0x00004B10 File Offset: 0x00002D10
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

        // Token: 0x17000388 RID: 904
        // (get) Token: 0x06000A5D RID: 2653 RVA: 0x0005CA50 File Offset: 0x0005AC50
        // (set) Token: 0x06000A5E RID: 2654 RVA: 0x00004B19 File Offset: 0x00002D19
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

        // Token: 0x17000389 RID: 905
        // (get) Token: 0x06000A5F RID: 2655 RVA: 0x0005CA70 File Offset: 0x0005AC70
        // (set) Token: 0x06000A60 RID: 2656 RVA: 0x00004B30 File Offset: 0x00002D30
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

        // Token: 0x1700038A RID: 906
        // (get) Token: 0x06000A61 RID: 2657 RVA: 0x0005CA90 File Offset: 0x0005AC90
        // (set) Token: 0x06000A62 RID: 2658 RVA: 0x00004B47 File Offset: 0x00002D47
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

        // Token: 0x1700038B RID: 907
        // (get) Token: 0x06000A63 RID: 2659 RVA: 0x0005CAB0 File Offset: 0x0005ACB0
        // (set) Token: 0x06000A64 RID: 2660 RVA: 0x00004B5E File Offset: 0x00002D5E
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

        // Token: 0x1700038C RID: 908
        // (get) Token: 0x06000A65 RID: 2661 RVA: 0x0005CAD0 File Offset: 0x0005ACD0
        // (set) Token: 0x06000A66 RID: 2662 RVA: 0x00004B75 File Offset: 0x00002D75
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

        // Token: 0x1700038D RID: 909
        // (get) Token: 0x06000A67 RID: 2663 RVA: 0x0005CAE8 File Offset: 0x0005ACE8
        // (set) Token: 0x06000A68 RID: 2664 RVA: 0x00004B93 File Offset: 0x00002D93
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

        // Token: 0x06000A69 RID: 2665 RVA: 0x0005CB00 File Offset: 0x0005AD00
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.DrawLine(pen, num / 2f, num / 2f, (float)this.Width - num / 2f, (float)this.Height - num / 2f);
        }

        // Token: 0x06000A6A RID: 2666 RVA: 0x00004AE3 File Offset: 0x00002CE3
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        // Token: 0x06000A6B RID: 2667 RVA: 0x0005CB68 File Offset: 0x0005AD68
        public U_Bias()
        {
            base.Disposed += this.U_Bias_Disposed;
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

        // Token: 0x06000A6C RID: 2668 RVA: 0x0005CCEC File Offset: 0x0005AEEC
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000A6D RID: 2669 RVA: 0x0005CD04 File Offset: 0x0005AF04
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000A6E RID: 2670 RVA: 0x0005CD1C File Offset: 0x0005AF1C
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000A6F RID: 2671 RVA: 0x0005CD34 File Offset: 0x0005AF34
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000A70 RID: 2672 RVA: 0x0005CD4C File Offset: 0x0005AF4C
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000A71 RID: 2673 RVA: 0x0005CD64 File Offset: 0x0005AF64
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000A72 RID: 2674 RVA: 0x0005CD7C File Offset: 0x0005AF7C
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000A73 RID: 2675 RVA: 0x0005CD94 File Offset: 0x0005AF94
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000A74 RID: 2676 RVA: 0x0005CDAC File Offset: 0x0005AFAC
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000A75 RID: 2677 RVA: 0x0005CDC4 File Offset: 0x0005AFC4
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000A76 RID: 2678 RVA: 0x0005CDDC File Offset: 0x0005AFDC
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
                            array[i] = new U_Bias.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000A77 RID: 2679 RVA: 0x0005CE98 File Offset: 0x0005B098
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000A78 RID: 2680 RVA: 0x0005CEA8 File Offset: 0x0005B0A8
        private void U_Bias_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x06000A79 RID: 2681 RVA: 0x0005CEDC File Offset: 0x0005B0DC
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
            this.Tag = "斜线";
        }

        // Token: 0x06000A7A RID: 2682 RVA: 0x0005CF7C File Offset: 0x0005B17C
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

        // Token: 0x0400058D RID: 1421
        private IContainer components;

        // Token: 0x0400058E RID: 1422
        private float MYX;

        // Token: 0x0400058F RID: 1423
        private float MYY;

        // Token: 0x04000590 RID: 1424
        private bool theisprint;

        // Token: 0x04000591 RID: 1425
        private float thelinewidth;

        // Token: 0x04000592 RID: 1426
        private Color thelinecolor;

        // Token: 0x04000593 RID: 1427
        private string[,] DefineProperty;

        // Token: 0x02000042 RID: 66
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000A7B RID: 2683 RVA: 0x00004BA2 File Offset: 0x00002DA2
            public XpropDescriptor(U_Bias cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000A7C RID: 2684 RVA: 0x0005D034 File Offset: 0x0005B234
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x1700038E RID: 910
            // (get) Token: 0x06000A7D RID: 2685 RVA: 0x0005D044 File Offset: 0x0005B244
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000A7E RID: 2686 RVA: 0x0005D05C File Offset: 0x0005B25C
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
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
                    result = null;
                }
                return result;
            }

            // Token: 0x1700038F RID: 911
            // (get) Token: 0x06000A7F RID: 2687 RVA: 0x0005D194 File Offset: 0x0005B394
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x17000390 RID: 912
            // (get) Token: 0x06000A80 RID: 2688 RVA: 0x0005D1A4 File Offset: 0x0005B3A4
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
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x06000A81 RID: 2689 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000A82 RID: 2690 RVA: 0x0005D300 File Offset: 0x0005B500
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
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x06000A83 RID: 2691 RVA: 0x0005D43C File Offset: 0x0005B63C
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000594 RID: 1428
            private string theProp;

            // Token: 0x04000595 RID: 1429
            private U_Bias mycc;
        }
    }
}
