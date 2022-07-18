using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;

namespace LuoEasyPrint
{
	// Token: 0x02000027 RID: 39
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class mbclassp5 : mbclass, IDisposable, ICustomTypeDescriptor
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00046BF4 File Offset: 0x00044DF4
		public mbclassp5(ControlDesign pp)
		{
			this.mygroupfield = "";
			this.mygroupnewpage = false;
			this.DefineProperty = new string[1, 2];
			this.DefineProperty = new string[3, 2];
			this.DefineProperty[0, 0] = "Height";
			this.DefineProperty[0, 1] = "组区域高度";
			this.DefineProperty[1, 0] = "GroupField";
			this.DefineProperty[1, 1] = "分组打印";
			this.DefineProperty[2, 0] = "GroupNewpage";
			this.DefineProperty[2, 1] = "每组换页";
			this.mypp = pp;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00046CA8 File Offset: 0x00044EA8
		public override void ReadString(string ss)
		{
			string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
			this.GroupField = array[1];
			if (String.Compare(array[2], "1", false) == 0)
			{
				this.GroupNewPage = true;
			}
			else
			{
				this.GroupNewPage = false;
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00046CF4 File Offset: 0x00044EF4
		public override string SaveString()
		{
			string str = "";
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.GroupField;
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.GroupNewPage, "1", "0"));
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00046D44 File Offset: 0x00044F44
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00003FCF File Offset: 0x000021CF
		[Description("分组区域高度，以毫米为单位（注意，如果没有分组，或者不需要在分组区域中打印内容，请将该区域的高度设置为0）")]
		public float Height
		{
			get
			{
				return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.p5.Height, false), 1);
			}
			set
			{
				this.mypp.SplitContainer5.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00046D80 File Offset: 0x00044F80
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00003FFD File Offset: 0x000021FD
		[Description("在分组打印的情况下，是否每组换新页打印")]
		public bool GroupNewPage
		{
			get
			{
				return this.mygroupnewpage;
			}
			set
			{
				this.mygroupnewpage = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00046D94 File Offset: 0x00044F94
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00004006 File Offset: 0x00002206
		[Description("要分组的列，若为空，则表示不分组打印")]
		[TypeConverter(typeof(mbsjmodule.StrChoice))]
		public string GroupField
		{
			get
			{
				return this.mygroupfield;
			}
			set
			{
				this.mygroupfield = value;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00046DAC File Offset: 0x00044FAC
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00046DC4 File Offset: 0x00044FC4
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00046DDC File Offset: 0x00044FDC
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00046DF4 File Offset: 0x00044FF4
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00046E0C File Offset: 0x0004500C
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00046E24 File Offset: 0x00045024
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00046E3C File Offset: 0x0004503C
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00046E54 File Offset: 0x00045054
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00046E6C File Offset: 0x0004506C
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00046E84 File Offset: 0x00045084
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00046E9C File Offset: 0x0004509C
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
							array[i] = new mbclassp5.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00046F58 File Offset: 0x00045158
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00046F68 File Offset: 0x00045168
		public string GetPropertyEnglishName(string cname)
		{
			bool flag = false;
			int num = 0;
			checked
			{
				string result="";
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

		// Token: 0x0600077C RID: 1916 RVA: 0x00046FD4 File Offset: 0x000451D4
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

		// Token: 0x0600077D RID: 1917 RVA: 0x0000400F File Offset: 0x0000220F
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				this.DefineProperty = null;
				this.DefineProperty = null;
			}
			this.disposedValue = true;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00004031 File Offset: 0x00002231
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000452 RID: 1106
		private ControlDesign mypp;

		// Token: 0x04000453 RID: 1107
		private string mygroupfield;

		// Token: 0x04000454 RID: 1108
		private bool mygroupnewpage;

		// Token: 0x04000455 RID: 1109
		private string[,] DefineProperty;

		// Token: 0x04000456 RID: 1110
		private bool disposedValue;

		// Token: 0x02000028 RID: 40
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x0600077F RID: 1919 RVA: 0x00004040 File Offset: 0x00002240
			public XpropDescriptor(mbclassp5 cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x00047040 File Offset: 0x00045240
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000781 RID: 1921 RVA: 0x00047050 File Offset: 0x00045250
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x00047068 File Offset: 0x00045268
			public override object GetValue(object component)
			{
				string left = this.theProp.ToLower();
				object result;
				if (String.Compare(left, "groupfield", false) == 0)
				{
					result = this.mycc.GroupField;
				}
				else if (String.Compare(left, "groupnewpage", false) == 0)
				{
					result = this.mycc.GroupNewPage;
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

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000783 RID: 1923 RVA: 0x00047104 File Offset: 0x00045304
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000784 RID: 1924 RVA: 0x00047114 File Offset: 0x00045314
			public override Type PropertyType
			{
				get
				{
					string left = this.theProp.ToLower();
					Type result;
					if (String.Compare(left, "groupfield", false) == 0)
					{
						result = this.mycc.GroupField.GetType();
					}
					else if (String.Compare(left, "groupnewpage", false) == 0)
					{
						result = this.mycc.GroupNewPage.GetType();
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

			// Token: 0x06000785 RID: 1925 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x000471C0 File Offset: 0x000453C0
			public override void SetValue(object component, object value)
			{
				string left = this.theProp.ToLower();
				if (String.Compare(left, "groupfield", false) == 0)
				{
					this.mycc.GroupField = Convert.ToString(value);
				}
				else if (String.Compare(left, "groupnewpage", false) == 0)
				{
					this.mycc.GroupNewPage = Convert.ToBoolean(value);
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

			// Token: 0x06000787 RID: 1927 RVA: 0x0004725C File Offset: 0x0004545C
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000457 RID: 1111
			private string theProp;

			// Token: 0x04000458 RID: 1112
			private mbclassp5 mycc;
		}
	}
}
