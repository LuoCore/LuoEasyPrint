using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x02000052 RID: 82
	[DesignerGenerated]
	[ToolboxItem(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class U_Image : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x00065B1C File Offset: 0x00063D1C
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x00065B5C File Offset: 0x00063D5C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			this.BackgroundImage = Properties.Resources.delete;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.DoubleBuffered = true;
			Padding margin = new Padding(0);
			this.Margin = margin;
			this.Name = "U_Image";
			Size size = new Size(169, 37);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00065BEC File Offset: 0x00063DEC
		private float GetX
		{
			get
			{
				return this.MYX;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00065C04 File Offset: 0x00063E04
		private float GetY
		{
			get
			{
				return this.MYY;
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00065C1C File Offset: 0x00063E1C
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

		// Token: 0x06000C15 RID: 3093 RVA: 0x00065C7C File Offset: 0x00063E7C
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x00065CD0 File Offset: 0x00063ED0
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

		// Token: 0x06000C17 RID: 3095 RVA: 0x00065D3C File Offset: 0x00063F3C
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00065DA8 File Offset: 0x00063FA8
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0000530F File Offset: 0x0000350F
		[Category("布局")]
		[Description("图片垂直对齐方式，打印时有效")]
		public StringAlignment Valign
		{
			get
			{
				return this.thevalign;
			}
			set
			{
				this.thevalign = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00065DC0 File Offset: 0x00063FC0
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00005318 File Offset: 0x00003518
		[Description("图片水平对齐方式，打印时有效")]
		[Category("布局")]
		public StringAlignment Halign
		{
			get
			{
				return this.thehalign;
			}
			set
			{
				this.thehalign = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00065DD8 File Offset: 0x00063FD8
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00065DF0 File Offset: 0x00063FF0
		[Category("布局")]
		[Description("图片缩放设置")]
		public DataGridViewImageCellLayout LayerOut
		{
			get
			{
				return this.thelayout;
			}
			set
			{
				this.thelayout = value;
				switch (value)
				{
				case DataGridViewImageCellLayout.Stretch:
					this.BackgroundImageLayout = ImageLayout.Stretch;
					break;
				case DataGridViewImageCellLayout.Zoom:
					this.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				default:
					if (this.Valign == StringAlignment.Center & this.Halign == StringAlignment.Center)
					{
						this.BackgroundImageLayout = ImageLayout.Center;
					}
					else
					{
						this.BackgroundImageLayout = ImageLayout.None;
					}
					break;
				}
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00065E4C File Offset: 0x0006404C
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00005321 File Offset: 0x00003521
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00065E60 File Offset: 0x00064060
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000532A File Offset: 0x0000352A
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00065E80 File Offset: 0x00064080
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00005341 File Offset: 0x00003541
		[Category("布局")]
		[Description("控件所处的Y位置,以毫米为计量单位")]
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00065EA0 File Offset: 0x000640A0
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00005358 File Offset: 0x00003558
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00065EC0 File Offset: 0x000640C0
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0000536F File Offset: 0x0000356F
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00065EE0 File Offset: 0x000640E0
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x00005386 File Offset: 0x00003586
		[Description("边线宽度,不是直线的长度,以毫米为计量单位, 必须大于等于0")]
		[Category("外观")]
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00065EF8 File Offset: 0x000640F8
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000053A4 File Offset: 0x000035A4
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

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00065F10 File Offset: 0x00064110
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000053B3 File Offset: 0x000035B3
		[Category("边框")]
		[Description("是否显示左边框")]
		public bool LeftBorder
		{
			get
			{
				return this.theleftborder;
			}
			set
			{
				this.theleftborder = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00065F24 File Offset: 0x00064124
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x000053C2 File Offset: 0x000035C2
		[Description("是否显示右边框")]
		[Category("边框")]
		public bool RightBorder
		{
			get
			{
				return this.therightborder;
			}
			set
			{
				this.therightborder = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00065F38 File Offset: 0x00064138
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x000053D1 File Offset: 0x000035D1
		[Description("是否显示上边框")]
		[Category("边框")]
		public bool TopBorder
		{
			get
			{
				return this.thetopborder;
			}
			set
			{
				this.thetopborder = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00065F4C File Offset: 0x0006414C
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x000053E0 File Offset: 0x000035E0
		[Description("是否显示下边框")]
		[Category("边框")]
		public bool BottomBorder
		{
			get
			{
				return this.thebottomborder;
			}
			set
			{
				this.thebottomborder = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00065F60 File Offset: 0x00064160
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x000053EF File Offset: 0x000035EF
		[Category("外观")]
		[Description("要显示的图片（注意，如果设置了PictureVar属性且是合法的图片，则会忽略此属性而使用PictureVar属性指定的图片）")]
		public Image Img
		{
			get
			{
				return this.BackgroundImage;
			}
			set
			{
				this.BackgroundImage = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00065F78 File Offset: 0x00064178
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x000053FE File Offset: 0x000035FE
		[Description("要显示的图片自定义变量（可以是图片路径字符串变量，也可以是以字符串形式表示的图片的自定义变量）")]
		[Editor(typeof(U_Editor), typeof(UITypeEditor))]
		[Category("外观")]
		public string PictureVar
		{
			get
			{
				return this.thepicturevar;
			}
			set
			{
				this.thepicturevar = value;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00065F90 File Offset: 0x00064190
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			float num = this.ConvertFromMM(this.LineWidth, true);
			Pen pen = new Pen(this.LineColor, num);
			if (this.LeftBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, num / 2f, num / 2f, (float)this.Height - num - 1f);
			}
			if (this.RightBorder)
			{
				e.Graphics.DrawLine(pen, (float)this.Width - num - 1f, num / 2f, (float)this.Width - num - 1f, (float)this.Height - num - 1f);
			}
			if (this.TopBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, num / 2f, (float)this.Width - num - 1f, num / 2f);
			}
			if (this.BottomBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, (float)this.Height - num - 1f, (float)this.Width - num - 1f, (float)this.Height - num - 1f);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000660C0 File Offset: 0x000642C0
		public U_Image()
		{
			base.Disposed += this.U_Image_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0f;
			this.thelinecolor = Color.Black;
			this.theleftborder = true;
			this.thetopborder = true;
			this.therightborder = true;
			this.thebottomborder = true;
			this.thepicturevar = "";
			this.thevalign = StringAlignment.Center;
			this.thehalign = StringAlignment.Center;
			this.thelayout = DataGridViewImageCellLayout.Stretch;
			this.DefineProperty = new string[3, 2];
			this.InitializeComponent();
			this.MYX = this.CreateGraphics().DpiX;
			this.MYY = this.CreateGraphics().DpiY;
			this.DefineProperty = new string[16, 2];
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
			this.DefineProperty[7, 0] = "LeftBorder";
			this.DefineProperty[7, 1] = "左边框";
			this.DefineProperty[8, 0] = "RightBorder";
			this.DefineProperty[8, 1] = "右边框";
			this.DefineProperty[9, 0] = "TopBorder";
			this.DefineProperty[9, 1] = "上边框";
			this.DefineProperty[10, 0] = "BottomBorder";
			this.DefineProperty[10, 1] = "下边框";
			this.DefineProperty[11, 0] = "Img";
			this.DefineProperty[11, 1] = "图片内容";
			this.DefineProperty[12, 0] = "PictureVar";
			this.DefineProperty[12, 1] = "图片变量";
			this.DefineProperty[13, 0] = "LayerOut";
			this.DefineProperty[13, 1] = "图片布局";
			this.DefineProperty[14, 0] = "Valign";
			this.DefineProperty[14, 1] = "垂直对齐";
			this.DefineProperty[15, 0] = "Halign";
			this.DefineProperty[15, 1] = "水平对齐";
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000663D0 File Offset: 0x000645D0
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000663E8 File Offset: 0x000645E8
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00066400 File Offset: 0x00064600
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00066418 File Offset: 0x00064618
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00066430 File Offset: 0x00064630
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00066448 File Offset: 0x00064648
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00066460 File Offset: 0x00064660
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00066478 File Offset: 0x00064678
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00066490 File Offset: 0x00064690
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000664A8 File Offset: 0x000646A8
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000664C0 File Offset: 0x000646C0
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
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
					
							array[i] = new U_Image.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							break;
						}
					}
				
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0006657C File Offset: 0x0006477C
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0006658C File Offset: 0x0006478C
		private void U_Image_Disposed(object sender, EventArgs e)
		{
			try
			{
				this.DefineProperty = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000665C0 File Offset: 0x000647C0
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
			this.EWidth = Convert.ToSingle(array[3]);
			this.LineWidth = Convert.ToSingle(array[4]);
			this.LineColor = Module1.ConvertStringToColor(array[5]);
			this.EHeight = Convert.ToSingle(array[6]);
			this.LeftBorder = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[7], "1", false) == 0, true, false));
			this.RightBorder = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[8], "1", false) == 0, true, false));
			this.TopBorder = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[9], "1", false) == 0, true, false));
			this.BottomBorder = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[10], "1", false) == 0, true, false));
			this.Img = Module1.ConvertStringToImage(array[11]);
			if (array.Length >= 13)
			{
				this.PictureVar = array[12];
			}
			if (array.Length >= 16)
			{
				this.LayerOut = (DataGridViewImageCellLayout)Convert.ToInt32(array[13]);
				this.Halign = (StringAlignment)Convert.ToInt32(array[14]);
				this.Valign = (StringAlignment)Convert.ToInt32(array[15]);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0006675C File Offset: 0x0006495C
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.LeftBorder, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.RightBorder, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.TopBorder, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.BottomBorder, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertImageToString(this.Img);
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.PictureVar;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.LayerOut);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.Halign);
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.Valign);
		}

		// Token: 0x04000608 RID: 1544
		private IContainer components;

		// Token: 0x04000609 RID: 1545
		private float MYX;

		// Token: 0x0400060A RID: 1546
		private float MYY;

		// Token: 0x0400060B RID: 1547
		private bool theisprint;

		// Token: 0x0400060C RID: 1548
		private float thelinewidth;

		// Token: 0x0400060D RID: 1549
		private Color thelinecolor;

		// Token: 0x0400060E RID: 1550
		private bool theleftborder;

		// Token: 0x0400060F RID: 1551
		private bool thetopborder;

		// Token: 0x04000610 RID: 1552
		private bool therightborder;

		// Token: 0x04000611 RID: 1553
		private bool thebottomborder;

		// Token: 0x04000612 RID: 1554
		private string thepicturevar;

		// Token: 0x04000613 RID: 1555
		private StringAlignment thevalign;

		// Token: 0x04000614 RID: 1556
		private StringAlignment thehalign;

		// Token: 0x04000615 RID: 1557
		private DataGridViewImageCellLayout thelayout;

		// Token: 0x04000616 RID: 1558
		private string[,] DefineProperty;

		// Token: 0x02000053 RID: 83
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000C4A RID: 3146 RVA: 0x00005407 File Offset: 0x00003607
			public XpropDescriptor(U_Image cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x00066918 File Offset: 0x00064B18
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00066928 File Offset: 0x00064B28
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x00066940 File Offset: 0x00064B40
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
				else if (String.Compare(left, "leftborder", false) == 0)
				{
					result = this.mycc.LeftBorder;
				}
				else if (String.Compare(left, "rightborder", false) == 0)
				{
					result = this.mycc.RightBorder;
				}
				else if (String.Compare(left, "topborder", false) == 0)
				{
					result = this.mycc.TopBorder;
				}
				else if (String.Compare(left, "bottomborder", false) == 0)
				{
					result = this.mycc.BottomBorder;
				}
				else if (String.Compare(left, "img", false) == 0)
				{
					result = this.mycc.Img;
				}
				else if (String.Compare(left, "picturevar", false) == 0)
				{
					result = this.mycc.PictureVar;
				}
				else if (String.Compare(left, "layerout", false) == 0)
				{
					result = this.mycc.LayerOut;
				}
				else if (String.Compare(left, "valign", false) == 0)
				{
					result = this.mycc.Valign;
				}
				else if (String.Compare(left, "halign", false) == 0)
				{
					result = this.mycc.Halign;
				}
				else
				{
					Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
					result = null;
				}
				return result;
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00066BB8 File Offset: 0x00064DB8
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00066BC8 File Offset: 0x00064DC8
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
					else if (String.Compare(left, "leftborder", false) == 0)
					{
						result = this.mycc.LeftBorder.GetType();
					}
					else if (String.Compare(left, "rightborder", false) == 0)
					{
						result = this.mycc.RightBorder.GetType();
					}
					else if (String.Compare(left, "topborder", false) == 0)
					{
						result = this.mycc.TopBorder.GetType();
					}
					else if (String.Compare(left, "bottomborder", false) == 0)
					{
						result = this.mycc.BottomBorder.GetType();
					}
					else if (String.Compare(left, "img", false) == 0)
					{
						result = typeof(Image);
					}
					else if (String.Compare(left, "picturevar", false) == 0)
					{
						result = this.mycc.PictureVar.GetType();
					}
					else if (String.Compare(left, "layerout", false) == 0)
					{
						result = this.mycc.LayerOut.GetType();
					}
					else if (String.Compare(left, "valign", false) == 0)
					{
						result = this.mycc.Valign.GetType();
					}
					else if (String.Compare(left, "halign", false) == 0)
					{
						result = this.mycc.Halign.GetType();
					}
					else
					{
						Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
						result = null;
					}
					return result;
				}
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x00066E88 File Offset: 0x00065088
			public override void SetValue(object component, object value)
			{
				string left = this.theProp.ToLower();
				if (String.Compare(left, "isprint", false) == 0)
				{
					this.mycc.IsPrint = DataTypeConversion.ToBoolean(value);
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
					Color color=new Color();
					this.mycc.LineColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "leftborder", false) == 0)
				{
					this.mycc.LeftBorder = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "rightborder", false) == 0)
				{
					this.mycc.RightBorder = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "topborder", false) == 0)
				{
					this.mycc.TopBorder = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "bottomborder", false) == 0)
				{
					this.mycc.BottomBorder = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "img", false) == 0)
				{
					this.mycc.Img = (Image)value;
				}
				else if (String.Compare(left, "picturevar", false) == 0)
				{
					this.mycc.PictureVar = Convert.ToString(value);
				}
				else if (String.Compare(left, "layerout", false) == 0)
				{
					this.mycc.LayerOut = (DataGridViewImageCellLayout)Convert.ToInt32(value);
				}
				else if (String.Compare(left, "valign", false) == 0)
				{
					this.mycc.Valign = (StringAlignment)Convert.ToInt32(value);
				}
				else if (String.Compare(left, "halign", false) == 0)
				{
					this.mycc.Halign = (StringAlignment)Convert.ToInt32(value);
				}
				else
				{
					Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
				}
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x00067114 File Offset: 0x00065314
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000617 RID: 1559
			private string theProp;

			// Token: 0x04000618 RID: 1560
			private U_Image mycc;
		}
	}
}
