using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x02000029 RID: 41
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class mbclassp6 : mbclass, IDisposable, ICustomTypeDescriptor
    {
        // Token: 0x06000788 RID: 1928 RVA: 0x0004726C File Offset: 0x0004546C
        public mbclassp6(ControlDesign pp)
        {
            this.DefineProperty = new string[1, 2];
            this.DefineProperty = new string[1, 2];
            this.DefineProperty[0, 0] = "Height";
            this.DefineProperty[0, 1] = "区域高度";
            this.mypp = pp;
        }

        // Token: 0x06000789 RID: 1929 RVA: 0x000472C4 File Offset: 0x000454C4
        public override void ReadString(string ss)
        {
            Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
        }

        // Token: 0x0600078A RID: 1930 RVA: 0x000472E0 File Offset: 0x000454E0
        public override string SaveString()
        {
            return "";
        }

        // Token: 0x170002B5 RID: 693
        // (get) Token: 0x0600078B RID: 1931 RVA: 0x000472F8 File Offset: 0x000454F8
        // (set) Token: 0x0600078C RID: 1932 RVA: 0x0000405E File Offset: 0x0000225E
        [Description("页表尾区域高度，以毫米为单位")]
        public float Height
        {
            get
            {
                return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P6.Height, false), 1);
            }
            set
            {
                this.mypp.SplitContainer6.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x0600078D RID: 1933 RVA: 0x00047334 File Offset: 0x00045534
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x0600078E RID: 1934 RVA: 0x0004734C File Offset: 0x0004554C
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x0600078F RID: 1935 RVA: 0x00047364 File Offset: 0x00045564
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x06000790 RID: 1936 RVA: 0x0004737C File Offset: 0x0004557C
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x06000791 RID: 1937 RVA: 0x00047394 File Offset: 0x00045594
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x06000792 RID: 1938 RVA: 0x000473AC File Offset: 0x000455AC
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x06000793 RID: 1939 RVA: 0x000473C4 File Offset: 0x000455C4
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x06000794 RID: 1940 RVA: 0x000473DC File Offset: 0x000455DC
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x06000795 RID: 1941 RVA: 0x000473F4 File Offset: 0x000455F4
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x06000796 RID: 1942 RVA: 0x0004740C File Offset: 0x0004560C
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x06000797 RID: 1943 RVA: 0x00047424 File Offset: 0x00045624
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
                            array[i] = new mbclassp6.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x06000798 RID: 1944 RVA: 0x000474E0 File Offset: 0x000456E0
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x06000799 RID: 1945 RVA: 0x000474F0 File Offset: 0x000456F0
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

        // Token: 0x0600079A RID: 1946 RVA: 0x0004755C File Offset: 0x0004575C
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

        // Token: 0x0600079B RID: 1947 RVA: 0x0000408C File Offset: 0x0000228C
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue && disposing)
            {
                this.DefineProperty = null;
                this.DefineProperty = null;
            }
            this.disposedValue = true;
        }

        // Token: 0x0600079C RID: 1948 RVA: 0x000040AE File Offset: 0x000022AE
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x04000459 RID: 1113
        private ControlDesign mypp;

        // Token: 0x0400045A RID: 1114
        private string[,] DefineProperty;

        // Token: 0x0400045B RID: 1115
        private bool disposedValue;

        // Token: 0x0200002A RID: 42
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x0600079D RID: 1949 RVA: 0x000040BD File Offset: 0x000022BD
            public XpropDescriptor(mbclassp6 cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x0600079E RID: 1950 RVA: 0x000475C8 File Offset: 0x000457C8
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170002B6 RID: 694
            // (get) Token: 0x0600079F RID: 1951 RVA: 0x000475D8 File Offset: 0x000457D8
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x060007A0 RID: 1952 RVA: 0x000475F0 File Offset: 0x000457F0
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

            // Token: 0x170002B7 RID: 695
            // (get) Token: 0x060007A1 RID: 1953 RVA: 0x0004764C File Offset: 0x0004584C
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170002B8 RID: 696
            // (get) Token: 0x060007A2 RID: 1954 RVA: 0x0004765C File Offset: 0x0004585C
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

            // Token: 0x060007A3 RID: 1955 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x060007A4 RID: 1956 RVA: 0x000476BC File Offset: 0x000458BC
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

            // Token: 0x060007A5 RID: 1957 RVA: 0x00047714 File Offset: 0x00045914
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x0400045C RID: 1116
            private string theProp;

            // Token: 0x0400045D RID: 1117
            private mbclassp6 mycc;
        }
    }
}
