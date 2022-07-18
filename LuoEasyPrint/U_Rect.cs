using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuoEasyPrint
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ToolboxItem(false)]
    [Browsable(false)]
    public partial class U_Rect : UserControl, IControl, ICustomTypeDescriptor
    {
        private float MYX;
        private float MYY;
        private bool theisprint;
        private float thelinewidth;
        private Color thelinecolor;
        private Color thefilledcolor;
        public string[,] DefineProperty;
        public U_Rect()
        {
            this.theisprint = true;
            this.thelinewidth = 0.26f;
            this.thelinecolor = Color.Black;
            this.thefilledcolor = Color.Transparent;
            this.DefineProperty = new string[3, 2];
            InitializeComponent();
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
            this.Disposed += U_Rect_Disposed;
        }

        private void U_Rect_Disposed(object? sender, EventArgs e)
        {
            try
            {
                this.DefineProperty = null;
            }
            catch (Exception ex)
            {
            }
        }

        public void RestoreFromString(string ss)
        {
            string[] array = ss.Split(mbsjmodule.G_MB_Spetator_Proper, -1, StringSplitOptions.RemoveEmptyEntries);
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
            this.Tag = "矩形";
        }
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
        [Category("外观")]
        [Description("矩形的填充颜色")]
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float num = this.ConvertFromMM(this.LineWidth, true);
            Pen pen = new Pen(this.LineColor, num);
            e.Graphics.FillRectangle(new SolidBrush(this.FilledColor), 0, 0, this.Width, this.Height);
            e.Graphics.DrawRectangle(pen, num / 2f, num / 2f, (float)this.Width - num - 1f, (float)this.Height - num - 1f);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string? GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public string? GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor? GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor? GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object? GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[]? attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[]? attributes)
        {
            checked
            {
                PropertyDescriptor[] array = new PropertyDescriptor[this.DefineProperty.GetLength(0) - 1 + 1];
                int num = 0;
                int num2 = array.Length - 1;
                int i = num;
           
                while (i <= num2)
                {
                    Type type = this.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo propertyInfo in properties)
                    {
                        if (String.Compare(propertyInfo.Name.ToUpper(), this.DefineProperty[i, 0].ToUpper(), false) == 0)
                        {
                            attributes = Attribute.GetCustomAttributes(propertyInfo);
                            array[i] = new U_Rect.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            break;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        public object? GetPropertyOwner(PropertyDescriptor? pd)
        {
            return this;
        }


        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000CC0 RID: 3264 RVA: 0x0000561A File Offset: 0x0000381A
            public XpropDescriptor(U_Rect cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000CC1 RID: 3265 RVA: 0x0006917C File Offset: 0x0006737C
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x17000436 RID: 1078
            // (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0006918C File Offset: 0x0006738C
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000CC3 RID: 3267 RVA: 0x000691A4 File Offset: 0x000673A4
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
                    MessageBox.Show("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到");
                   
                    result = null;
                }
                return result;
            }

            // Token: 0x17000437 RID: 1079
            // (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000692FC File Offset: 0x000674FC
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x17000438 RID: 1080
            // (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0006930C File Offset: 0x0006750C
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
                        MessageBox.Show("Property过程编程错误,属性名称[" + this.theProp + "]未找到");
                    
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x06000CC6 RID: 3270 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000CC7 RID: 3271 RVA: 0x0006948C File Offset: 0x0006768C
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
                else
                {
                    MessageBox.Show("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到");
                }
            }

            // Token: 0x06000CC8 RID: 3272 RVA: 0x000695FC File Offset: 0x000677FC
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000643 RID: 1603
            private string theProp;

            // Token: 0x04000644 RID: 1604
            private U_Rect mycc;
        }
    }
}
