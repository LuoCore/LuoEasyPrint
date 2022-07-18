using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000025 RID: 37
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class mbclassp4 : mbclass, IDisposable, ICustomTypeDescriptor
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x00046474 File Offset: 0x00044674
		public mbclassp4(ControlDesign pp)
		{
			this.myfixedrows = 0;
			this.myaddemptyrows = false;
			this.mycolumns = 1;
			this.DefineProperty = new string[1, 2];
			this.DefineProperty = new string[4, 2];
			this.DefineProperty[0, 0] = "Height";
			this.DefineProperty[0, 1] = "区域高度";
			this.DefineProperty[1, 0] = "FixedRows";
			this.DefineProperty[1, 1] = "打印固定行";
			this.DefineProperty[2, 0] = "AddEmptyRows";
			this.DefineProperty[2, 1] = "加空行补足";
			this.DefineProperty[3, 0] = "Columns";
			this.DefineProperty[3, 1] = "栏数";
			this.mypp = pp;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00046550 File Offset: 0x00044750
		public override void ReadString(string ss)
		{
			string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
			this.FixedRows = Convert.ToInt32(array[1]);
			if (String.Compare(array[2], "1", false) == 0)
			{
				this.AddEmptyRows = true;
			}
			else
			{
				this.AddEmptyRows = false;
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

		// Token: 0x06000744 RID: 1860 RVA: 0x000465BC File Offset: 0x000447BC
		public override string SaveString()
		{
			string str = "";
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.FixedRows);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.AddEmptyRows, "1", "0"));
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Columns);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00046628 File Offset: 0x00044828
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00003F30 File Offset: 0x00002130
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00046650 File Offset: 0x00044850
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00003F40 File Offset: 0x00002140
		[Description("表格详细内容区域高度，以毫米为单位")]
		public float Height
		{
			get
			{
				return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P4.Height, false), 1);
			}
			set
			{
				this.mypp.SplitContainer4.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0004668C File Offset: 0x0004488C
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00003F6E File Offset: 0x0000216E
		[Description("是否在表格尾部添加空行补足固定行数（仅当每页打印固定行的情况下有效）")]
		public bool AddEmptyRows
		{
			get
			{
				return this.myaddemptyrows;
			}
			set
			{
				this.myaddemptyrows = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x000466A0 File Offset: 0x000448A0
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00003F77 File Offset: 0x00002177
		[Description("每页打印固定的行数(为0表示根据纸张高度自动确定),对分组打印无效")]
		public int FixedRows
		{
			get
			{
				return this.myfixedrows;
			}
			set
			{
				this.myfixedrows = value;
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000466B8 File Offset: 0x000448B8
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000466D0 File Offset: 0x000448D0
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000466E8 File Offset: 0x000448E8
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00046700 File Offset: 0x00044900
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00046718 File Offset: 0x00044918
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00046730 File Offset: 0x00044930
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00046748 File Offset: 0x00044948
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00046760 File Offset: 0x00044960
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00046778 File Offset: 0x00044978
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00046790 File Offset: 0x00044990
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000467A8 File Offset: 0x000449A8
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
							array[i] = new mbclassp4.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00046864 File Offset: 0x00044A64
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00046874 File Offset: 0x00044A74
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

		// Token: 0x0600075A RID: 1882 RVA: 0x000468E0 File Offset: 0x00044AE0
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

		// Token: 0x0600075B RID: 1883 RVA: 0x00003F80 File Offset: 0x00002180
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				this.DefineProperty = null;
				this.DefineProperty = null;
			}
			this.disposedValue = true;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00003FA2 File Offset: 0x000021A2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400044A RID: 1098
		private ControlDesign mypp;

		// Token: 0x0400044B RID: 1099
		private int myfixedrows;

		// Token: 0x0400044C RID: 1100
		private bool myaddemptyrows;

		// Token: 0x0400044D RID: 1101
		private int mycolumns;

		// Token: 0x0400044E RID: 1102
		private string[,] DefineProperty;

		// Token: 0x0400044F RID: 1103
		private bool disposedValue;

		// Token: 0x02000026 RID: 38
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x0600075D RID: 1885 RVA: 0x00003FB1 File Offset: 0x000021B1
			public XpropDescriptor(mbclassp4 cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x0004694C File Offset: 0x00044B4C
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x0600075F RID: 1887 RVA: 0x0004695C File Offset: 0x00044B5C
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x00046974 File Offset: 0x00044B74
			public override object GetValue(object component)
			{
				string left = this.theProp.ToLower();
				object result;
				if (String.Compare(left, "fixedrows", false) == 0)
				{
					result = this.mycc.FixedRows;
				}
				else if (String.Compare(left, "addemptyrows", false) == 0)
				{
					result = this.mycc.AddEmptyRows;
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

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000761 RID: 1889 RVA: 0x00046A38 File Offset: 0x00044C38
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000762 RID: 1890 RVA: 0x00046A48 File Offset: 0x00044C48
			public override Type PropertyType
			{
				get
				{
					string left = this.theProp.ToLower();
					Type result;
					if (String.Compare(left, "fixedrows", false) == 0)
					{
						result = this.mycc.FixedRows.GetType();
					}
					else if (String.Compare(left, "addemptyrows", false) == 0)
					{
						result = this.mycc.AddEmptyRows.GetType();
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

			// Token: 0x06000763 RID: 1891 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x00046B20 File Offset: 0x00044D20
			public override void SetValue(object component, object value)
			{
				string left = this.theProp.ToLower();
				if (String.Compare(left, "fixedrows", false) == 0)
				{
					this.mycc.FixedRows = Convert.ToInt32(value);
				}
				else if (String.Compare(left, "addemptyrows", false) == 0)
				{
					this.mycc.AddEmptyRows = Convert.ToBoolean(value);
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

			// Token: 0x06000765 RID: 1893 RVA: 0x00046BE4 File Offset: 0x00044DE4
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000450 RID: 1104
			private string theProp;

			// Token: 0x04000451 RID: 1105
			private mbclassp4 mycc;
		}
	}
}
