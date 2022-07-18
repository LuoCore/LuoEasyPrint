using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x0200002B RID: 43
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class mbclassp7 : mbclass, IDisposable, ICustomTypeDescriptor
    {
        // Token: 0x060007A6 RID: 1958 RVA: 0x00047724 File Offset: 0x00045924
        public mbclassp7(ControlDesign pp)
        {
            this.DefineProperty = new string[1, 2];
            this.DefineProperty = new string[1, 2];
            this.DefineProperty[0, 0] = "Height";
            this.DefineProperty[0, 1] = "区域高度";
            this.mypp = pp;
        }

        // Token: 0x060007A7 RID: 1959 RVA: 0x0004777C File Offset: 0x0004597C
        public override void ReadString(string ss)
        {
            Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
        }

        // Token: 0x060007A8 RID: 1960 RVA: 0x00047798 File Offset: 0x00045998
        public override string SaveString()
        {
            return "";
        }

        // Token: 0x170002B9 RID: 697
        // (get) Token: 0x060007A9 RID: 1961 RVA: 0x000477B0 File Offset: 0x000459B0
        // (set) Token: 0x060007AA RID: 1962 RVA: 0x000040DB File Offset: 0x000022DB
        [Description("报表尾区域高度，以毫米为单位")]
        public float Height
        {
            get
            {
                return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.p7.Height, false), 1);
            }
            set
            {
                this.mypp.SplitContainer7.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x060007AB RID: 1963 RVA: 0x000477EC File Offset: 0x000459EC
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x060007AC RID: 1964 RVA: 0x00047804 File Offset: 0x00045A04
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x060007AD RID: 1965 RVA: 0x0004781C File Offset: 0x00045A1C
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x060007AE RID: 1966 RVA: 0x00047834 File Offset: 0x00045A34
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x060007AF RID: 1967 RVA: 0x0004784C File Offset: 0x00045A4C
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x060007B0 RID: 1968 RVA: 0x00047864 File Offset: 0x00045A64
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x060007B1 RID: 1969 RVA: 0x0004787C File Offset: 0x00045A7C
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x060007B2 RID: 1970 RVA: 0x00047894 File Offset: 0x00045A94
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x060007B3 RID: 1971 RVA: 0x000478AC File Offset: 0x00045AAC
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x060007B4 RID: 1972 RVA: 0x000478C4 File Offset: 0x00045AC4
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x060007B5 RID: 1973 RVA: 0x000478DC File Offset: 0x00045ADC
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
                            array[i] = new mbclassp7.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x060007B6 RID: 1974 RVA: 0x00047998 File Offset: 0x00045B98
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x060007B7 RID: 1975 RVA: 0x000479A8 File Offset: 0x00045BA8
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

        // Token: 0x060007B8 RID: 1976 RVA: 0x00047A14 File Offset: 0x00045C14
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

        // Token: 0x060007B9 RID: 1977 RVA: 0x00004109 File Offset: 0x00002309
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue && disposing)
            {
                this.DefineProperty = null;
                this.DefineProperty = null;
            }
            this.disposedValue = true;
        }

        // Token: 0x060007BA RID: 1978 RVA: 0x0000412B File Offset: 0x0000232B
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x0400045E RID: 1118
        private ControlDesign mypp;

        // Token: 0x0400045F RID: 1119
        private string[,] DefineProperty;

        // Token: 0x04000460 RID: 1120
        private bool disposedValue;

        // Token: 0x0200002C RID: 44
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x060007BB RID: 1979 RVA: 0x0000413A File Offset: 0x0000233A
            public XpropDescriptor(mbclassp7 cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x060007BC RID: 1980 RVA: 0x00047A80 File Offset: 0x00045C80
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170002BA RID: 698
            // (get) Token: 0x060007BD RID: 1981 RVA: 0x00047A90 File Offset: 0x00045C90
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x060007BE RID: 1982 RVA: 0x00047AA8 File Offset: 0x00045CA8
            public override object GetValue(object component)
            {
                string left = this.theProp.ToLower();
                object result;
                if (String.Compare(left, "height", false) == 0)
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

            // Token: 0x170002BB RID: 699
            // (get) Token: 0x060007BF RID: 1983 RVA: 0x00047B04 File Offset: 0x00045D04
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170002BC RID: 700
            // (get) Token: 0x060007C0 RID: 1984 RVA: 0x00047B14 File Offset: 0x00045D14
            public override Type PropertyType
            {
                get
                {
                    string left = this.theProp.ToLower();
                    Type result;
                    if (String.Compare(left, "height", false) == 0)
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

            // Token: 0x060007C1 RID: 1985 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x060007C2 RID: 1986 RVA: 0x00047B74 File Offset: 0x00045D74
            public override void SetValue(object component, object value)
            {
                string left = this.theProp.ToLower();
                if (String.Compare(left, "height", false) == 0)
                {
                    this.mycc.Height = Convert.ToSingle(value);
                }
                else
                {
                    Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
                }
            }

            // Token: 0x060007C3 RID: 1987 RVA: 0x00047BCC File Offset: 0x00045DCC
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000461 RID: 1121
            private string theProp;

            // Token: 0x04000462 RID: 1122
            private mbclassp7 mycc;
        }
    }
}
