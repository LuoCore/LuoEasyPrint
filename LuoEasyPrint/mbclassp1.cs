using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200001F RID: 31
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class mbclassp1 : mbclass, IDisposable, ICustomTypeDescriptor
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x000451BC File Offset: 0x000433BC
		public mbclassp1(ControlDesign pp)
		{
			this.DefineProperty = new string[1, 2];
			this.DefineProperty = new string[1, 2];
			this.DefineProperty[0, 0] = "Height";
			this.DefineProperty[0, 1] = "区域高度";
			this.mypp = pp;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00045214 File Offset: 0x00043414
		public override void ReadString(string ss)
		{
			Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00045230 File Offset: 0x00043430
		public override string SaveString()
		{
			return "";
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00045248 File Offset: 0x00043448
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00003CE1 File Offset: 0x00001EE1
		[Description("报表页面页眉区域高度，以毫米为单位")]
		public float Height
		{
			get
			{
				return (float)Math.Round((double)this.mypp.rv.ConvertToMM((float)this.mypp.P1.Height, false), 1);
			}
			set
			{
				this.mypp.SplitContainer1.SplitterDistance = checked(20 + (int)Math.Round((double)this.mypp.rv.ConvertFromMM(value, false)));
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00045284 File Offset: 0x00043484
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0004529C File Offset: 0x0004349C
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000452B4 File Offset: 0x000434B4
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000452CC File Offset: 0x000434CC
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000452E4 File Offset: 0x000434E4
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000452FC File Offset: 0x000434FC
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00045314 File Offset: 0x00043514
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0004532C File Offset: 0x0004352C
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00045344 File Offset: 0x00043544
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0004535C File Offset: 0x0004355C
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00045374 File Offset: 0x00043574
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
							array[i] = new mbclassp1.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00045430 File Offset: 0x00043630
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00045440 File Offset: 0x00043640
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

		// Token: 0x060006F0 RID: 1776 RVA: 0x000454AC File Offset: 0x000436AC
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x00003D0F File Offset: 0x00001F0F
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				this.DefineProperty = null;
				this.DefineProperty = null;
			}
			this.disposedValue = true;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00003D31 File Offset: 0x00001F31
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000436 RID: 1078
		private ControlDesign mypp;

		// Token: 0x04000437 RID: 1079
		private string[,] DefineProperty;

		// Token: 0x04000438 RID: 1080
		private bool disposedValue;

		// Token: 0x02000020 RID: 32
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x060006F3 RID: 1779 RVA: 0x00003D40 File Offset: 0x00001F40
			public XpropDescriptor(mbclassp1 cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00045518 File Offset: 0x00043718
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00045528 File Offset: 0x00043728
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x00045540 File Offset: 0x00043740
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

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0004559C File Offset: 0x0004379C
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000455AC File Offset: 0x000437AC
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

			// Token: 0x060006F9 RID: 1785 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x0004560C File Offset: 0x0004380C
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

			// Token: 0x060006FB RID: 1787 RVA: 0x00045664 File Offset: 0x00043864
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000439 RID: 1081
			private string theProp;

			// Token: 0x0400043A RID: 1082
			private mbclassp1 mycc;
		}
	}
}
