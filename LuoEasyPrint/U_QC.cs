using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;



namespace LuoEasyPrint
{
	// Token: 0x02000054 RID: 84
	[ToolboxItem(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerGenerated]
	public class U_QC : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000C53 RID: 3155 RVA: 0x00067124 File Offset: 0x00065324
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
					if (this.thetextfont != null)
					{
						this.thetextfont.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00067174 File Offset: 0x00065374
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.BackgroundImage = Properties.Resources.barcode_2d;
			this.BackgroundImageLayout = ImageLayout.Zoom;
			Padding margin = new Padding(0);
			this.Margin = margin;
			this.Name = "U_QC";
			Size size = new Size(82, 49);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000671F8 File Offset: 0x000653F8
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

		// Token: 0x06000C56 RID: 3158 RVA: 0x00067258 File Offset: 0x00065458
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

		// Token: 0x06000C57 RID: 3159 RVA: 0x000672AC File Offset: 0x000654AC
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

		// Token: 0x06000C58 RID: 3160 RVA: 0x00067318 File Offset: 0x00065518
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00067384 File Offset: 0x00065584
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00005425 File Offset: 0x00003625
		[Category("外观")]
		[Description("二维码周围的空白大小，以像素为计量单位，必须大于等于0")]
		public int Margins
		{
			get
			{
				return this.mymargins;
			}
			set
			{
				if (value >= 0)
				{
					this.mymargins = value;
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0006739C File Offset: 0x0006559C
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00005432 File Offset: 0x00003632
		[Category("外观")]
		[Description("要打印的条码类型)")]
		public U_QC.BarcodeFormat BarType
		{
			get
			{
				return this.mybartype;
			}
			set
			{
				this.mybartype = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000673B4 File Offset: 0x000655B4
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x0000543B File Offset: 0x0000363B
		[Category("行为")]
		[Description("以套打模式打印或预览时，是否打印该控件的内容")]
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000673C8 File Offset: 0x000655C8
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00005444 File Offset: 0x00003644
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000673E8 File Offset: 0x000655E8
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x0000545B File Offset: 0x0000365B
		[Description("控件所处的Y位置,以毫米为计量单位")]
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00067408 File Offset: 0x00065608
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00005472 File Offset: 0x00003672
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00067428 File Offset: 0x00065628
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00005489 File Offset: 0x00003689
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00067448 File Offset: 0x00065648
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x000054A0 File Offset: 0x000036A0
		[Category("外观")]
		[Description("边框线宽度,不是条形码线条的宽度,以毫米为计量单位, 必须大于等于0")]
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00067460 File Offset: 0x00065660
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x000054BE File Offset: 0x000036BE
		[Category("外观")]
		[Description("边框线条颜色")]
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00067478 File Offset: 0x00065678
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000054CD File Offset: 0x000036CD
		[Description("条形码文字及线条颜色")]
		[Category("外观")]
		public Color TextColor
		{
			get
			{
				return this.thetextcolor;
			}
			set
			{
				this.thetextcolor = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00067490 File Offset: 0x00065690
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x000054DC File Offset: 0x000036DC
		[Category("外观")]
		[Description("条码填充背景颜色")]
		public Color FilledColor
		{
			get
			{
				return this.thefilledcolor;
			}
			set
			{
				this.thefilledcolor = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000674A8 File Offset: 0x000656A8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000054EB File Offset: 0x000036EB
		[Category("外观")]
		[Description("条码字体，指打印在条码下方的条码文本的字体")]
		[Browsable(false)]
		public Font TextFont
		{
			get
			{
				return this.thetextfont;
			}
			set
			{
				if (value != null)
				{
					this.thetextfont = (Font)value.Clone();
					this.Invalidate();
				}
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000674C0 File Offset: 0x000656C0
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00005507 File Offset: 0x00003707
		[Editor(typeof(U_Editor), typeof(UITypeEditor))]
		[Description("要打印的条码内容，可以包含纯文本、系统变量、自定义变量和字段变量的组合。但是，不同的条码是有字符范围限制的，如果字符超出条码范围，则该条码不会被打印")]
		[Category("外观")]
		public string TextValue
		{
			get
			{
				return this.thetext;
			}
			set
			{
				this.thetext = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000674D8 File Offset: 0x000656D8
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00005516 File Offset: 0x00003716
		[Description("要打印的二维码的字符编码，比如UTF-8,可以为空，表示默认)")]
		[Category("外观")]
		public string CharType
		{
			get
			{
				return this.mychartype;
			}
			set
			{
				this.mychartype = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000674F0 File Offset: 0x000656F0
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0000551F File Offset: 0x0000371F
		[Description("是否显示左边框")]
		[Category("边框")]
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00067504 File Offset: 0x00065704
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x0000552E File Offset: 0x0000372E
		[Category("边框")]
		[Description("是否显示右边框")]
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00067518 File Offset: 0x00065718
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x0000553D File Offset: 0x0000373D
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0006752C File Offset: 0x0006572C
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x0000554C File Offset: 0x0000374C
		[Category("边框")]
		[Description("是否显示下边框")]
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

		// Token: 0x06000C7D RID: 3197 RVA: 0x00067540 File Offset: 0x00065740
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			float num = this.ConvertFromMM(this.LineWidth, true);
			Pen pen = new Pen(this.LineColor, num);
			this.BackColor = this.FilledColor;
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
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			stringFormatFlags |= StringFormatFlags.NoWrap;
			stringFormatFlags |= StringFormatFlags.NoClip;
			stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			stringFormat.FormatFlags = stringFormatFlags;
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Near;
			Graphics graphics = e.Graphics;
			string textValue = this.TextValue;
			Font textFont = this.TextFont;
			Brush brush = new SolidBrush(this.TextColor);
			RectangleF layoutRectangle = new RectangleF(0f, 0f, (float)this.Width, (float)this.Height);
			graphics.DrawString(textValue, textFont, brush, layoutRectangle, stringFormat);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000676FC File Offset: 0x000658FC
		public U_QC()
		{
			base.Disposed += this.U_QC_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0f;
			this.thelinecolor = Color.Black;
			this.thefilledcolor = Color.Transparent;
			this.thetextfont = new Font("宋体", 9f);
			this.thetextcolor = Color.Black;
			this.thetext = "二维码";
			this.theleftborder = false;
			this.thetopborder = false;
			this.therightborder = false;
			this.thebottomborder = false;
			this.mychartype = "";
			this.mymargins = 4;
			this.mybartype = U_QC.BarcodeFormat.QR_CODE;
			this.DefineProperty = new string[3, 2];
			this.InitializeComponent();
			this.MYX = this.CreateGraphics().DpiX;
			this.MYY = this.CreateGraphics().DpiY;
			this.DefineProperty = new string[18, 2];
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
			this.DefineProperty[7, 0] = "FilledColor";
			this.DefineProperty[7, 1] = "填充颜色";
			this.DefineProperty[8, 0] = "TextValue";
			this.DefineProperty[8, 1] = "条码文本";
			this.DefineProperty[9, 0] = "CharType";
			this.DefineProperty[9, 1] = "字符编码";
			this.DefineProperty[10, 0] = "LeftBorder";
			this.DefineProperty[10, 1] = "左边框";
			this.DefineProperty[11, 0] = "RightBorder";
			this.DefineProperty[11, 1] = "右边框";
			this.DefineProperty[12, 0] = "TopBorder";
			this.DefineProperty[12, 1] = "上边框";
			this.DefineProperty[13, 0] = "BottomBorder";
			this.DefineProperty[13, 1] = "下边框";
			this.DefineProperty[14, 0] = "Margins";
			this.DefineProperty[14, 1] = "边界空白";
			this.DefineProperty[15, 0] = "TextFont";
			this.DefineProperty[15, 1] = "字体";
			this.DefineProperty[16, 0] = "TextColor";
			this.DefineProperty[16, 1] = "前景颜色";
			this.DefineProperty[17, 0] = "BarType";
			this.DefineProperty[17, 1] = "条码类型";
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00067A8C File Offset: 0x00065C8C
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00067AA4 File Offset: 0x00065CA4
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00067ABC File Offset: 0x00065CBC
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00067AD4 File Offset: 0x00065CD4
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00067AEC File Offset: 0x00065CEC
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00067B04 File Offset: 0x00065D04
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00067B1C File Offset: 0x00065D1C
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00067B34 File Offset: 0x00065D34
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00067B4C File Offset: 0x00065D4C
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00067B64 File Offset: 0x00065D64
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00067B7C File Offset: 0x00065D7C
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
					
							array[i] = new U_QC.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00067C38 File Offset: 0x00065E38
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00067C48 File Offset: 0x00065E48
		private void U_QC_Disposed(object sender, EventArgs e)
		{
			try
			{
				this.DefineProperty = null;
				this.thetextfont = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00067C84 File Offset: 0x00065E84
		public void RestoreFromString(string ss)
		{
			string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_Proper, -1, CompareMethod.Binary);
			Encoding.GetEncodings();
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
			this.LeftBorder = Convert.ToBoolean(array[7]);
			this.RightBorder = Convert.ToBoolean(array[8]);
			this.TopBorder = Convert.ToBoolean(array[9]);
			this.BottomBorder = Convert.ToBoolean(array[10]);
			this.FilledColor = Module1.ConvertStringToColor(array[11]);
			this.CharType = array[12];
			this.TextFont = Module1.ConvertStringToFont(array[13]);
			this.TextValue = array[14];
			this.TextColor = Module1.ConvertStringToColor(array[15]);
			this.Margins = Convert.ToInt32(array[16]);
			this.BarType = (U_QC.BarcodeFormat)Convert.ToInt32(array[17]);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00067DB8 File Offset: 0x00065FB8
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.FilledColor);
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.CharType;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertFontToString(this.TextFont);
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.TextValue;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.TextColor);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins);
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.BarType);
		}

		// Token: 0x04000619 RID: 1561
		private IContainer components;

		// Token: 0x0400061A RID: 1562
		private float MYX;

		// Token: 0x0400061B RID: 1563
		private float MYY;

		// Token: 0x0400061C RID: 1564
		private bool theisprint;

		// Token: 0x0400061D RID: 1565
		private float thelinewidth;

		// Token: 0x0400061E RID: 1566
		private Color thelinecolor;

		// Token: 0x0400061F RID: 1567
		private Color thefilledcolor;

		// Token: 0x04000620 RID: 1568
		private Font thetextfont;

		// Token: 0x04000621 RID: 1569
		private Color thetextcolor;

		// Token: 0x04000622 RID: 1570
		private string thetext;

		// Token: 0x04000623 RID: 1571
		private bool theleftborder;

		// Token: 0x04000624 RID: 1572
		private bool thetopborder;

		// Token: 0x04000625 RID: 1573
		private bool therightborder;

		// Token: 0x04000626 RID: 1574
		private bool thebottomborder;

		// Token: 0x04000627 RID: 1575
		private string mychartype;

		// Token: 0x04000628 RID: 1576
		private int mymargins;

		// Token: 0x04000629 RID: 1577
		private U_QC.BarcodeFormat mybartype;

		// Token: 0x0400062A RID: 1578
		public string[,] DefineProperty;

		// Token: 0x02000055 RID: 85
		public enum BarcodeFormat
		{
			// Token: 0x0400062C RID: 1580
			AZTEC = 1,
			// Token: 0x0400062D RID: 1581
			CODABAR,
			// Token: 0x0400062E RID: 1582
			CODE_39 = 4,
			// Token: 0x0400062F RID: 1583
			CODE_93 = 8,
			// Token: 0x04000630 RID: 1584
			CODE_128 = 16,
			// Token: 0x04000631 RID: 1585
			CODE_128B,
			// Token: 0x04000632 RID: 1586
			DATA_MATRIX = 32,
			// Token: 0x04000633 RID: 1587
			EAN_8 = 64,
			// Token: 0x04000634 RID: 1588
			EAN_13 = 128,
			// Token: 0x04000635 RID: 1589
			ITF = 256,
			// Token: 0x04000636 RID: 1590
			MAXICODE = 512,
			// Token: 0x04000637 RID: 1591
			PDF_417 = 1024,
			// Token: 0x04000638 RID: 1592
			QR_CODE = 2048
		}

		// Token: 0x02000056 RID: 86
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000C8F RID: 3215 RVA: 0x0000555B File Offset: 0x0000375B
			public XpropDescriptor(U_QC cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00067FA0 File Offset: 0x000661A0
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00067FB0 File Offset: 0x000661B0
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00067FC8 File Offset: 0x000661C8
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
				else if (String.Compare(left, "filledcolor", false) == 0)
				{
					result = this.mycc.FilledColor;
				}
				else if (String.Compare(left, "textvalue", false) == 0)
				{
					result = this.mycc.TextValue;
				}
				else if (String.Compare(left, "chartype", false) == 0)
				{
					result = this.mycc.CharType;
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
				else if (String.Compare(left, "textfont", false) == 0)
				{
					result = this.mycc.TextFont;
				}
				else if (String.Compare(left, "textcolor", false) == 0)
				{
					result = this.mycc.TextColor;
				}
				else if (String.Compare(left, "margins", false) == 0)
				{
					result = this.mycc.Margins;
				}
				else if (String.Compare(left, "bartype", false) == 0)
				{
					result = this.mycc.BarType;
				}
				else
				{
					Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
					result = null;
				}
				return result;
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00068288 File Offset: 0x00066488
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00068298 File Offset: 0x00066498
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
					else if (String.Compare(left, "filledcolor", false) == 0)
					{
						result = this.mycc.FilledColor.GetType();
					}
					else if (String.Compare(left, "textvalue", false) == 0)
					{
						result = this.mycc.TextValue.GetType();
					}
					else if (String.Compare(left, "chartype", false) == 0)
					{
						result = this.mycc.CharType.GetType();
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
					else if (String.Compare(left, "textfont", false) == 0)
					{
						result = this.mycc.TextFont.GetType();
					}
					else if (String.Compare(left, "textcolor", false) == 0)
					{
						result = this.mycc.TextColor.GetType();
					}
					else if (String.Compare(left, "margins", false) == 0)
					{
						result = this.mycc.Margins.GetType();
					}
					else if (String.Compare(left, "bartype", false) == 0)
					{
						result = this.mycc.BarType.GetType();
					}
					else
					{
						Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
						result = null;
					}
					return result;
				}
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x000685B4 File Offset: 0x000667B4
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
				else if (String.Compare(left, "filledcolor", false) == 0)
				{
					Color color = new Color();
					this.mycc.FilledColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "textvalue", false) == 0)
				{
					this.mycc.TextValue = Convert.ToString(value);
				}
				else if (String.Compare(left, "chartype", false) == 0)
				{
					this.mycc.CharType = Convert.ToString(value);
				}
				else if (String.Compare(left, "leftborder", false) == 0)
				{
					this.mycc.LeftBorder = Convert.ToBoolean(value);
				}
				else if (String.Compare(left, "rightborder", false) == 0)
				{
					this.mycc.RightBorder = Convert.ToBoolean(value);
				}
				else if (String.Compare(left, "topborder", false) == 0)
				{
					this.mycc.TopBorder = Convert.ToBoolean(value);
				}
				else if (String.Compare(left, "bottomborder", false) == 0)
				{
					this.mycc.BottomBorder = Convert.ToBoolean(value);
				}
				else if (String.Compare(left, "textfont", false) == 0)
				{
					this.mycc.TextFont = (Font)value;
				}
				else if (String.Compare(left, "textcolor", false) == 0)
				{
					Color color = new Color();
					this.mycc.TextColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "margins", false) == 0)
				{
					this.mycc.Margins = Convert.ToInt32(value);
				}
				else if (String.Compare(left, "bartype", false) == 0)
				{
					this.mycc.BarType = (U_QC.BarcodeFormat)Convert.ToInt32(value);
				}
				else
				{
					Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
				}
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x000688A4 File Offset: 0x00066AA4
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x04000639 RID: 1593
			private string theProp;

			// Token: 0x0400063A RID: 1594
			private U_QC mycc;
		}
	}
}
