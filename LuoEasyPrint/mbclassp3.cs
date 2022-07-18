using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;

namespace LuoEasyPrint
{
    // Token: 0x02000023 RID: 35
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class mbclassp3 : mbclass, IDisposable, ICustomTypeDescriptor
    {
        // Token: 0x0600071E RID: 1822 RVA: 0x00045CF4 File Offset: 0x00043EF4
        public mbclassp3(ControlDesign pp)
        {
            this.mypicture = null;
            this.myBackPictureMode = true;
            this.mycolumns = 1;
            this.DefineProperty = new string[1, 2];
            this.DefineProperty = new string[4, 2];
            this.DefineProperty[0, 0] = "Height";
            this.DefineProperty[0, 1] = "页表头高度";
            this.DefineProperty[1, 0] = "BackGroundPicture";
            this.DefineProperty[1, 1] = "背景图片";
            this.DefineProperty[2, 0] = "BackPictureMode";
            this.DefineProperty[2, 1] = "原始大小打印";
            this.DefineProperty[3, 0] = "Columns";
            this.DefineProperty[3, 1] = "栏数";
            this.mypp = pp;
        }

        // Token: 0x0600071F RID: 1823 RVA: 0x00045DD0 File Offset: 0x00043FD0
        public override void ReadString(string ss)
        {
            string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
            this.BackGroundPicture = Module1.ConvertStringToImage(array[1]);
            if (String.Compare(array[2], "1", false) == 0)
            {
                this.BackPictureMode = true;
            }
            else
            {
                this.BackPictureMode = false;
            }
            if (array.Length >= 4)
            {
                this.Columns = Convert.ToInt32(array[3]);
            }
            else
            {
                this.Columns = 1;
            }
        }

        // Token: 0x06000720 RID: 1824 RVA: 0x00045E3C File Offset: 0x0004403C
        public override string SaveString()
        {
            string str = "";
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertImageToString(this.mypicture);
            str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.BackPictureMode, "1", "0"));
            return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Columns);
        }

        // Token: 0x170002A1 RID: 673
        // (get) Token: 0x06000721 RID: 1825 RVA: 0x00045EA8 File Offset: 0x000440A8
        // (set) Token: 0x06000722 RID: 1826 RVA: 0x00003E3F File Offset: 0x0000203F
        [Description("页表头分栏打印的栏数，对分组打印无效。一般应与表格详细内容中设置的栏数一致。")]
        public int Columns
        {
            get
            {
                if (this.mycolumns <= 0)
                {
                    this.mycolumns = 1;
                }
                return this.mycolumns;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                this.mycolumns = value;
            }
        }

        // Token: 0x170002A2 RID: 674
        // (get) Token: 0x06000723 RID: 1827 RVA: 0x00045ED0 File Offset: 0x000440D0
        // (set) Token: 0x06000724 RID: 1828 RVA: 0x00003E4F File Offset: 0x0000204F
        [Description("页表头区域高度，以毫米为单位")]
        public float Height
        {
            get
            {
                return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P3.Height, false), 1);
            }
            set
            {
                this.mypp.SplitContainer3.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x170002A3 RID: 675
        // (get) Token: 0x06000725 RID: 1829 RVA: 0x00045F0C File Offset: 0x0004410C
        // (set) Token: 0x06000726 RID: 1830 RVA: 0x00003E7D File Offset: 0x0000207D
        [Description("是否按背景图片的原始大小打印，为true表示按背景图片的实际大小打印，为false表示自动缩放到报表头区域大小打印")]
        public bool BackPictureMode
        {
            get
            {
                return this.myBackPictureMode;
            }
            set
            {
                this.myBackPictureMode = value;
                if (value)
                {
                    this.mypp.P3.BackgroundImageLayout = ImageLayout.None;
                }
                else
                {
                    this.mypp.P3.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        // Token: 0x170002A4 RID: 676
        // (get) Token: 0x06000727 RID: 1831 RVA: 0x00045F20 File Offset: 0x00044120
        // (set) Token: 0x06000728 RID: 1832 RVA: 0x00003EAD File Offset: 0x000020AD
        [Description("报表头背景图片设置")]
        public Image BackGroundPicture
        {
            get
            {
                Image result;
                if (this.mypicture == null)
                {
                    result = null;
                }
                else
                {
                    result = this.mypicture;
                }
                return result;
            }
            set
            {
                this.mypicture = value;
                this.mypp.P3.BackgroundImage = value;
            }
        }

        // Token: 0x06000729 RID: 1833 RVA: 0x00045F44 File Offset: 0x00044144
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x0600072A RID: 1834 RVA: 0x00045F5C File Offset: 0x0004415C
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x0600072B RID: 1835 RVA: 0x00045F74 File Offset: 0x00044174
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x0600072C RID: 1836 RVA: 0x00045F8C File Offset: 0x0004418C
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x0600072D RID: 1837 RVA: 0x00045FA4 File Offset: 0x000441A4
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x0600072E RID: 1838 RVA: 0x00045FBC File Offset: 0x000441BC
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x0600072F RID: 1839 RVA: 0x00045FD4 File Offset: 0x000441D4
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000730 RID: 1840 RVA: 0x00045FEC File Offset: 0x000441EC
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000731 RID: 1841 RVA: 0x00046004 File Offset: 0x00044204
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000732 RID: 1842 RVA: 0x0004601C File Offset: 0x0004421C
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000733 RID: 1843 RVA: 0x00046034 File Offset: 0x00044234
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
                            array[i] = new mbclassp3.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }
                    
                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000734 RID: 1844 RVA: 0x000460F0 File Offset: 0x000442F0
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000735 RID: 1845 RVA: 0x00046100 File Offset: 0x00044300
        public string GetPropertyEnglishName(string cname)
        {
            bool flag = false;
            int num = 0;
            string result="";
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

        // Token: 0x06000736 RID: 1846 RVA: 0x0004616C File Offset: 0x0004436C
        public string GetPropertyChineseName(string ename)
        {
            bool flag = false;
            int num = 0;
            string result="";
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

        // Token: 0x06000737 RID: 1847 RVA: 0x00003EC7 File Offset: 0x000020C7
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue && disposing)
            {
                if (this.mypicture != null)
                {
                    this.mypicture.Dispose();
                    this.mypicture = null;
                }
                this.DefineProperty = null;
                this.DefineProperty = null;
            }
            this.disposedValue = true;
        }

        // Token: 0x06000738 RID: 1848 RVA: 0x00003F03 File Offset: 0x00002103
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x04000442 RID: 1090
        private ControlDesign mypp;

        // Token: 0x04000443 RID: 1091
        private Image mypicture;

        // Token: 0x04000444 RID: 1092
        private bool myBackPictureMode;

        // Token: 0x04000445 RID: 1093
        private int mycolumns;

        // Token: 0x04000446 RID: 1094
        private string[,] DefineProperty;

        // Token: 0x04000447 RID: 1095
        private bool disposedValue;

        // Token: 0x02000024 RID: 36
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000739 RID: 1849 RVA: 0x00003F12 File Offset: 0x00002112
            public XpropDescriptor(mbclassp3 cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x0600073A RID: 1850 RVA: 0x000461D8 File Offset: 0x000443D8
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170002A5 RID: 677
            // (get) Token: 0x0600073B RID: 1851 RVA: 0x000461E8 File Offset: 0x000443E8
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x0600073C RID: 1852 RVA: 0x00046200 File Offset: 0x00044400
            public override object GetValue(object component)
            {
                string left = this.theProp.ToLower();
                object result;
                if (String.Compare(left, "backgroundpicture", false) == 0)
                {
                    result = this.mycc.BackGroundPicture;
                }
                else if (String.Compare(left, "backpicturemode", false) == 0)
                {
                    result = this.mycc.BackPictureMode;
                }
                else if (String.Compare(left, "height", false) == 0)
                {
                    result = this.mycc.Height;
                }
                else if (String.Compare(left, "columns", false) == 0)
                {
                    result = this.mycc.Columns;
                }
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x170002A6 RID: 678
            // (get) Token: 0x0600073D RID: 1853 RVA: 0x000462C0 File Offset: 0x000444C0
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170002A7 RID: 679
            // (get) Token: 0x0600073E RID: 1854 RVA: 0x000462D0 File Offset: 0x000444D0
            public override Type PropertyType
            {
                get
                {
                    string left = this.theProp.ToLower();
                    Type result;
                    if (String.Compare(left, "backgroundpicture", false) == 0)
                    {
                        result = typeof(Image);
                    }
                    else if (String.Compare(left, "backpicturemode", false) == 0)
                    {
                        result = this.mycc.BackPictureMode.GetType();
                    }
                    else if (String.Compare(left, "height", false) == 0)
                    {
                        result = this.mycc.Height.GetType();
                    }
                    else if (String.Compare(left, "columns", false) == 0)
                    {
                        result = this.mycc.Columns.GetType();
                    }
                    else
                    {
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x0600073F RID: 1855 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x06000740 RID: 1856 RVA: 0x000463A0 File Offset: 0x000445A0
            public override void SetValue(object component, object value)
            {
                string left = this.theProp.ToLower();
                if (String.Compare(left, "backgroundpicture", false) == 0)
                {
                    this.mycc.BackGroundPicture = (Image)value;
                }
                else if (String.Compare(left, "backpicturemode", false) == 0)
                {
                    this.mycc.BackPictureMode = DataTypeConversion.ToBoolean(value);
                }
                else if (String.Compare(left, "height", false) == 0)
                {
                    this.mycc.Height = Convert.ToSingle(value);
                }
                else if (String.Compare(left, "columns", false) == 0)
                {
                    this.mycc.Columns = Convert.ToInt32(value);
                }
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x06000741 RID: 1857 RVA: 0x00046464 File Offset: 0x00044664
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000448 RID: 1096
            private string theProp;

            // Token: 0x04000449 RID: 1097
            private mbclassp3 mycc;
        }
    }
}
