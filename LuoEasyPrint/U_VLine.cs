using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;

namespace LuoEasyPrint
{
	// Token: 0x0200005B RID: 91
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[ToolboxItem(false)]
	[DesignerGenerated]
	public class U_VLine : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x0006B308 File Offset: 0x00069508
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

		// Token: 0x06000D17 RID: 3351 RVA: 0x0006B348 File Offset: 0x00069548
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			this.Name = "VLine";
			Size size = new Size(169, 37);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0006B3B0 File Offset: 0x000695B0
		private float GetX
		{
			get
			{
				return this.MYX;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0006B3C8 File Offset: 0x000695C8
		private float GetY
		{
			get
			{
				return this.MYY;
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0006B3E0 File Offset: 0x000695E0
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

		// Token: 0x06000D1B RID: 3355 RVA: 0x0006B440 File Offset: 0x00069640
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x0006B494 File Offset: 0x00069694
		public string GetPropertyEnglishName(string cname)
		{
			bool flag = false;
			int num = 0;
			string result=String.Empty;
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

		// Token: 0x06000D1D RID: 3357 RVA: 0x0006B500 File Offset: 0x00069700
		public string GetPropertyChineseName(string ename)
		{
			bool flag = false;
			int num = 0;
			string result=String.Empty;
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0006B56C File Offset: 0x0006976C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000057D1 File Offset: 0x000039D1
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0006B580 File Offset: 0x00069780
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000057DA File Offset: 0x000039DA
		[Category("布局")]
		[Description("控件所处的X位置,以十分之一毫米为计量单位")]
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0006B5A0 File Offset: 0x000697A0
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x000057F1 File Offset: 0x000039F1
		[Description("控件所处的Y位置,以十分之一毫米为计量单位")]
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0006B5C0 File Offset: 0x000697C0
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00005808 File Offset: 0x00003A08
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0006B5E0 File Offset: 0x000697E0
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0000581F File Offset: 0x00003A1F
		[Description("直线的线宽,不是直线的长度,以毫米为计量单位,最小必须为0.15")]
		[Category("外观")]
		public float LineWidth
		{
			get
			{
				return this.thelinewidth;
			}
			set
			{
				if ((double)value < 0.15)
				{
					value = 0.15f;
				}
				this.thelinewidth = value;
				this.Width = checked((int)Math.Round((double)this.ConvertFromMM(value, true)));
				this.Invalidate();
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0006B5F8 File Offset: 0x000697F8
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00005857 File Offset: 0x00003A57
		[Description("线条颜色")]
		[Category("外观")]
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

		// Token: 0x06000D2A RID: 3370 RVA: 0x0006B610 File Offset: 0x00069810
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			float num = this.ConvertFromMM(this.LineWidth, true);
			Pen pen = new Pen(this.LineColor, num);
			e.Graphics.DrawLine(pen, num / 2f, 0f, num / 2f, (float)this.Height);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0006B668 File Offset: 0x00069868
		public U_VLine()
		{
			base.Disposed += this.VLine_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0.25f;
			this.thelinecolor = Color.Black;
			this.DefineProperty = new string[3, 2];
			this.InitializeComponent();
			this.MYX = this.CreateGraphics().DpiX;
			this.MYY = this.CreateGraphics().DpiY;
			this.DefineProperty = new string[6, 2];
			this.DefineProperty[0, 0] = "IsPrint";
			this.DefineProperty[0, 1] = "是否套打";
			this.DefineProperty[1, 0] = "X";
			this.DefineProperty[1, 1] = "X位置";
			this.DefineProperty[2, 0] = "Y";
			this.DefineProperty[2, 1] = "Y位置";
			this.DefineProperty[3, 0] = "EHeight";
			this.DefineProperty[3, 1] = "高度";
			this.DefineProperty[4, 0] = "LineWidth";
			this.DefineProperty[4, 1] = "线宽";
			this.DefineProperty[5, 0] = "LineColor";
			this.DefineProperty[5, 1] = "线条颜色";
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0006B7C8 File Offset: 0x000699C8
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0006B7E0 File Offset: 0x000699E0
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0006B7F8 File Offset: 0x000699F8
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0006B810 File Offset: 0x00069A10
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0006B828 File Offset: 0x00069A28
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0006B840 File Offset: 0x00069A40
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0006B858 File Offset: 0x00069A58
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0006B870 File Offset: 0x00069A70
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0006B888 File Offset: 0x00069A88
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0006B8A0 File Offset: 0x00069AA0
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0006B8B8 File Offset: 0x00069AB8
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
							array[i] = new U_VLine.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0006B974 File Offset: 0x00069B74
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0006B984 File Offset: 0x00069B84
		private void VLine_Disposed(object sender, EventArgs e)
		{
			try
			{
				this.DefineProperty = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0006B9B8 File Offset: 0x00069BB8
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
			this.EHeight = Convert.ToSingle(array[3]);
			this.LineWidth = Convert.ToSingle(array[4]);
			this.LineColor = Module1.ConvertStringToColor(array[5]);
			this.Tag = "竖线";
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0006BA48 File Offset: 0x00069C48
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.EHeight);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.LineWidth);
			return str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.LineColor);
		}

		// Token: 0x0400065D RID: 1629
		private IContainer components;

		// Token: 0x0400065E RID: 1630
		private float MYX;

		// Token: 0x0400065F RID: 1631
		private float MYY;

		// Token: 0x04000660 RID: 1632
		private bool theisprint;

		// Token: 0x04000661 RID: 1633
		private float thelinewidth;

		// Token: 0x04000662 RID: 1634
		private Color thelinecolor;

		// Token: 0x04000663 RID: 1635
		public string[,] DefineProperty;

		// Token: 0x0200005C RID: 92
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000D3C RID: 3388 RVA: 0x00005866 File Offset: 0x00003A66
			public XpropDescriptor(U_VLine cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x0006BAE8 File Offset: 0x00069CE8
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0006BAF8 File Offset: 0x00069CF8
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x0006BB10 File Offset: 0x00069D10
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
					Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
					result = null;
				}
				return result;
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0006BC20 File Offset: 0x00069E20
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0006BC30 File Offset: 0x00069E30
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
						Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
						result = null;
					}
					return result;
				}
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x0006BD5C File Offset: 0x00069F5C
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
					Color color=new Color();
					this.mycc.LineColor = ((value != null) ? ((Color)value) : color);
				}
				else
				{
					Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
				}
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x0006BE74 File Offset: 0x0006A074
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000664 RID: 1636
			private string theProp;

			// Token: 0x04000665 RID: 1637
			private U_VLine mycc;
		}
	}
}
