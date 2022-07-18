using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Reflection;

namespace LuoEasyPrint
{
    // Token: 0x0200002D RID: 45
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class mbclassp8 : mbclass, IDisposable, ICustomTypeDescriptor
    {
        // Token: 0x060007C4 RID: 1988 RVA: 0x00047BDC File Offset: 0x00045DDC
        public mbclassp8(ControlDesign pp)
        {
            this.DefineProperty = new string[1, 2];
            this.DefineProperty = new string[1, 2];
            this.DefineProperty[0, 0] = "Height";
            this.DefineProperty[0, 1] = "区域高度";
            this.mypp = pp;
        }

        // Token: 0x060007C5 RID: 1989 RVA: 0x00047C34 File Offset: 0x00045E34
        public override void ReadString(string ss)
        {
            Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
        }

        // Token: 0x060007C6 RID: 1990 RVA: 0x00047C50 File Offset: 0x00045E50
        public override string SaveString()
        {
            return "";
        }

        // Token: 0x170002BD RID: 701
        // (get) Token: 0x060007C7 RID: 1991 RVA: 0x00047C68 File Offset: 0x00045E68
        // (set) Token: 0x060007C8 RID: 1992 RVA: 0x00004158 File Offset: 0x00002358
        [Description("报表页面页脚区域高度，以毫米为单位")]
        public float Height
        {
            get
            {
                return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P8.Height, false), 1);
            }
            set
            {
                this.mypp.SplitContainer8.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
            }
        }

        // Token: 0x060007C9 RID: 1993 RVA: 0x00047CA4 File Offset: 0x00045EA4
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        // Token: 0x060007CA RID: 1994 RVA: 0x00047CBC File Offset: 0x00045EBC
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x060007CB RID: 1995 RVA: 0x00047CD4 File Offset: 0x00045ED4
        public string GetComponentName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        // Token: 0x060007CC RID: 1996 RVA: 0x00047CEC File Offset: 0x00045EEC
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        // Token: 0x060007CD RID: 1997 RVA: 0x00047D04 File Offset: 0x00045F04
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        // Token: 0x060007CE RID: 1998 RVA: 0x00047D1C File Offset: 0x00045F1C
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        // Token: 0x060007CF RID: 1999 RVA: 0x00047D34 File Offset: 0x00045F34
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        // Token: 0x060007D0 RID: 2000 RVA: 0x00047D4C File Offset: 0x00045F4C
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        // Token: 0x060007D1 RID: 2001 RVA: 0x00047D64 File Offset: 0x00045F64
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        // Token: 0x060007D2 RID: 2002 RVA: 0x00047D7C File Offset: 0x00045F7C
        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        // Token: 0x060007D3 RID: 2003 RVA: 0x00047D94 File Offset: 0x00045F94
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
                            array[i] = new mbclassp8.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
                            i++;
                            goto IL_9D;
                        }
                    }

                }
                return new PropertyDescriptorCollection(array);
            }
        }

        // Token: 0x060007D4 RID: 2004 RVA: 0x00047E50 File Offset: 0x00046050
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        // Token: 0x060007D5 RID: 2005 RVA: 0x00047E60 File Offset: 0x00046060
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

        // Token: 0x060007D6 RID: 2006 RVA: 0x00047ECC File Offset: 0x000460CC
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

        // Token: 0x060007D7 RID: 2007 RVA: 0x00004186 File Offset: 0x00002386
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue && disposing)
            {
                this.DefineProperty = null;
                this.DefineProperty = null;
            }
            this.disposedValue = true;
        }

        // Token: 0x060007D8 RID: 2008 RVA: 0x000041A8 File Offset: 0x000023A8
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x04000463 RID: 1123
        private ControlDesign mypp;

        // Token: 0x04000464 RID: 1124
        private string[,] DefineProperty;

        // Token: 0x04000465 RID: 1125
        private bool disposedValue;

        // Token: 0x0200002E RID: 46
        private class XpropDescriptor : PropertyDescriptor
        {
            // Token: 0x060007D9 RID: 2009 RVA: 0x000041B7 File Offset: 0x000023B7
            public XpropDescriptor(mbclassp8 cc, string prop, Attribute[] attrs) : base(prop, attrs)
            {
                this.theProp = cc.GetPropertyEnglishName(prop);
                this.mycc = cc;
            }

            // Token: 0x060007DA RID: 2010 RVA: 0x00047F38 File Offset: 0x00046138
            public override bool CanResetValue(object component)
            {
                return false;
            }

            // Token: 0x170002BE RID: 702
            // (get) Token: 0x060007DB RID: 2011 RVA: 0x00047F48 File Offset: 0x00046148
            public override Type ComponentType
            {
                get
                {
                    return this.GetType();
                }
            }

            // Token: 0x060007DC RID: 2012 RVA: 0x00047F60 File Offset: 0x00046160
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

            // Token: 0x170002BF RID: 703
            // (get) Token: 0x060007DD RID: 2013 RVA: 0x00047FBC File Offset: 0x000461BC
            public override bool IsReadOnly
            {
                get
                {
                    return false;
                }
            }

            // Token: 0x170002C0 RID: 704
            // (get) Token: 0x060007DE RID: 2014 RVA: 0x00047FCC File Offset: 0x000461CC
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

            // Token: 0x060007DF RID: 2015 RVA: 0x00002590 File Offset: 0x00000790
            public override void ResetValue(object component)
            {
            }

            // Token: 0x060007E0 RID: 2016 RVA: 0x0004802C File Offset: 0x0004622C
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

            // Token: 0x060007E1 RID: 2017 RVA: 0x00048084 File Offset: 0x00046284
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            // Token: 0x04000466 RID: 1126
            private string theProp;

            // Token: 0x04000467 RID: 1127
            private mbclassp8 mycc;
        }
    }
}
