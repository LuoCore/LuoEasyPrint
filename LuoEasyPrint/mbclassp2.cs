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
    // Token: 0x02000021 RID: 33
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class mbclassp2 : mbclass, IDisposable, ICustomTypeDescriptor
    {
        // Token: 0x060006FC RID: 1788 RVA: 0x00045674 File Offset: 0x00043874
        public mbclassp2(ControlDesign pp)
        {
            this.mypicture = null;
            this.myBackPictureMode = true;
            this.DefineProperty = new string[1, 2];
            this.DefineProperty = new string[3, 2];
            this.DefineProperty[0, 0] = "Height";
            this.DefineProperty[0, 1] = "报表头高度";
            this.DefineProperty[1, 0] = "BackGroundPicture";
            this.DefineProperty[1, 1] = "背景图片";
            this.DefineProperty[2, 0] = "BackPictureMode";
            this.DefineProperty[2, 1] = "原始大小打印";
            this.mypp = pp;
        }

        // Token: 0x060006FD RID: 1789 RVA: 0x00045724 File Offset: 0x00043924
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
        }

        // Token: 0x060006FE RID: 1790 RVA: 0x00045774 File Offset: 0x00043974
        public override string SaveString()
        {
            string str = "";
            str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertImageToString(this.mypicture);
            return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.BackPictureMode, "1", "0"));
        }

        // Token: 0x1700029B RID: 667
        // (get) Token: 0x060006FF RID: 1791 RVA: 0x000457C8 File Offset: 0x000439C8
        // (set) Token: 0x06000700 RID: 1792 RVA: 0x00003D5E File Offset: 0x00001F5E
        [Description("报表头高度，以毫米为单位")]
        public float Height
        {
            get
            {
                return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P2.Height, false), 1);
            }
            set
            {
                this.mypp.SplitContainer2.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x1700029C RID: 668
        // (get) Token: 0x06000701 RID: 1793 RVA: 0x00045804 File Offset: 0x00043A04
        // (set) Token: 0x06000702 RID: 1794 RVA: 0x00003D8C File Offset: 0x00001F8C
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
                    this.mypp.P2.BackgroundImageLayout = ImageLayout.None;
                }
                else
                {
                    this.mypp.P2.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        // Token: 0x1700029D RID: 669
        // (get) Token: 0x06000703 RID: 1795 RVA: 0x00045818 File Offset: 0x00043A18
        // (set) Token: 0x06000704 RID: 1796 RVA: 0x00003DBC File Offset: 0x00001FBC
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
                this.mypp.P2.BackgroundImage = value;
            }
        }

        // Token: 0x06000705 RID: 1797 RVA: 0x0004583C File Offset: 0x00043A3C
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x06000706 RID: 1798 RVA: 0x00045854 File Offset: 0x00043A54
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000707 RID: 1799 RVA: 0x0004586C File Offset: 0x00043A6C
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000708 RID: 1800 RVA: 0x00045884 File Offset: 0x00043A84
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000709 RID: 1801 RVA: 0x0004589C File Offset: 0x00043A9C
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x0600070A RID: 1802 RVA: 0x000458B4 File Offset: 0x00043AB4
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x0600070B RID: 1803 RVA: 0x000458CC File Offset: 0x00043ACC
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x0600070C RID: 1804 RVA: 0x000458E4 File Offset: 0x00043AE4
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x0600070D RID: 1805 RVA: 0x000458FC File Offset: 0x00043AFC
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x0600070E RID: 1806 RVA: 0x00045914 File Offset: 0x00043B14
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x0600070F RID: 1807 RVA: 0x0004592C File Offset: 0x00043B2C
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
                            array[i] = new mbclassp2.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }
                    
                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000710 RID: 1808 RVA: 0x000459E8 File Offset: 0x00043BE8
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000711 RID: 1809 RVA: 0x000459F8 File Offset: 0x00043BF8
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

        // Token: 0x06000712 RID: 1810 RVA: 0x00045A64 File Offset: 0x00043C64
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

        // Token: 0x06000713 RID: 1811 RVA: 0x00003DD6 File Offset: 0x00001FD6
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

        // Token: 0x06000714 RID: 1812 RVA: 0x00003E12 File Offset: 0x00002012
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x0400043B RID: 1083
        private ControlDesign mypp;

        // Token: 0x0400043C RID: 1084
        private Image mypicture;

        // Token: 0x0400043D RID: 1085
        private bool myBackPictureMode;

        // Token: 0x0400043E RID: 1086
        private string[,] DefineProperty;

        // Token: 0x0400043F RID: 1087
        private bool disposedValue;

        // Token: 0x02000022 RID: 34
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x06000715 RID: 1813 RVA: 0x00003E21 File Offset: 0x00002021
            public XpropDescriptor(mbclassp2 cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x06000716 RID: 1814 RVA: 0x00045AD0 File Offset: 0x00043CD0
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x1700029E RID: 670
            // (get) Token: 0x06000717 RID: 1815 RVA: 0x00045AE0 File Offset: 0x00043CE0
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x06000718 RID: 1816 RVA: 0x00045AF8 File Offset: 0x00043CF8
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
                else
                {
                    Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                    result = null;
                }
                return result;
            }

            // Token: 0x1700029F RID: 671
            // (get) Token: 0x06000719 RID: 1817 RVA: 0x00045B94 File Offset: 0x00043D94
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170002A0 RID: 672
            // (get) Token: 0x0600071A RID: 1818 RVA: 0x00045BA4 File Offset: 0x00043DA4
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
                    else
                    {
                        Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                        result = null;
                    }
                    return result;
                }
            }

            // Token: 0x0600071B RID: 1819 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x0600071C RID: 1820 RVA: 0x00045C48 File Offset: 0x00043E48
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
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x0600071D RID: 1821 RVA: 0x00045CE4 File Offset: 0x00043EE4
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000440 RID: 1088
            private string theProp;

            // Token: 0x04000441 RID: 1089
            private mbclassp2 mycc;
        }
    }
}
