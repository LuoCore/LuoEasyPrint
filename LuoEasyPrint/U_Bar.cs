using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x0200003E RID: 62
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	[Browsable(false)]
	[ToolboxItem(false)]
	public class U_Bar : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x0005AF60 File Offset: 0x00059160
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

		// Token: 0x06000A11 RID: 2577 RVA: 0x0005AFB0 File Offset: 0x000591B0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.BackgroundImage = Properties.Resources.BarCode;
			this.BackgroundImageLayout = ImageLayout.Zoom;
			Padding margin = new Padding(0);
			this.Margin = margin;
			this.Name = "U_bar";
			Size size = new Size(82, 49);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0005B034 File Offset: 0x00059234
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

		// Token: 0x06000A13 RID: 2579 RVA: 0x0005B094 File Offset: 0x00059294
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

		// Token: 0x06000A14 RID: 2580 RVA: 0x0005B0E8 File Offset: 0x000592E8
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

		// Token: 0x06000A15 RID: 2581 RVA: 0x0005B154 File Offset: 0x00059354
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0005B1C0 File Offset: 0x000593C0
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x000049AB File Offset: 0x00002BAB
		[Description("指示是否在条形码的下方打印条形码内容的文本标签，为True表示要打印，为False表示不打印")]
		[Category("行为")]
		public bool IsPrintLabel
		{
			get
			{
				return this.myisprintlabel;
			}
			set
			{
				this.myisprintlabel = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0005B1D4 File Offset: 0x000593D4
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x000049B4 File Offset: 0x00002BB4
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0005B1E8 File Offset: 0x000593E8
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000049BD File Offset: 0x00002BBD
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0005B208 File Offset: 0x00059408
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000049D4 File Offset: 0x00002BD4
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0005B228 File Offset: 0x00059428
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000049EB File Offset: 0x00002BEB
		[Description("控件的宽度,以毫米为计量单位")]
		[Category("布局")]
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0005B248 File Offset: 0x00059448
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00004A02 File Offset: 0x00002C02
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0005B268 File Offset: 0x00059468
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00004A19 File Offset: 0x00002C19
		[Category("外观")]
		[Description("边线宽度,不是直线的长度,以毫米为计量单位, 必须大于等于0")]
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0005B280 File Offset: 0x00059480
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00004A37 File Offset: 0x00002C37
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0005B298 File Offset: 0x00059498
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00004A46 File Offset: 0x00002C46
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0005B2B0 File Offset: 0x000594B0
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00004A55 File Offset: 0x00002C55
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0005B2C8 File Offset: 0x000594C8
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00004A64 File Offset: 0x00002C64
		[Description("条码字体，指打印在条码下方的条码文本的字体")]
		[Category("外观")]
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0005B2E0 File Offset: 0x000594E0
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00004A80 File Offset: 0x00002C80
		[Editor(typeof(U_Editor), typeof(UITypeEditor))]
		[Category("外观")]
		[Description("要打印的条码内容，可以包含纯文本、系统变量、自定义变量和字段变量的组合。但是，不同的条码是有字符范围限制的，如果字符超出条码范围，则该条码不会被打印")]
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0005B2F8 File Offset: 0x000594F8
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00004A8F File Offset: 0x00002C8F
		[Description("要打印的条码类型)")]
		[Category("外观")]
		public U_Bar.BarCode BarType
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0005B310 File Offset: 0x00059510
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00004A98 File Offset: 0x00002C98
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0005B324 File Offset: 0x00059524
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00004AA7 File Offset: 0x00002CA7
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0005B338 File Offset: 0x00059538
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00004AB6 File Offset: 0x00002CB6
		[Category("边框")]
		[Description("是否显示上边框")]
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0005B34C File Offset: 0x0005954C
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00004AC5 File Offset: 0x00002CC5
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0005B360 File Offset: 0x00059560
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00004AD4 File Offset: 0x00002CD4
		[Description("单元格文本与边框的间距,计量单位为毫米,且必须是整数")]
		[Category("外观")]
		public Margins Margins
		{
			get
			{
				return this.themargins;
			}
			set
			{
				this.themargins = value;
				this.Invalidate();
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0005B378 File Offset: 0x00059578
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
			RectangleF layoutRectangle = new RectangleF(this.ConvertFromMM((float)this.Margins.Left, true), this.ConvertFromMM((float)this.Margins.Top, false), (float)this.Width - this.ConvertFromMM((float)(checked(this.Margins.Left + this.Margins.Right)), true), (float)this.Height - this.ConvertFromMM((float)(checked(this.Margins.Top + this.Margins.Bottom)), false));
			graphics.DrawString(textValue, textFont, brush, layoutRectangle, stringFormat);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0005B590 File Offset: 0x00059790
		public U_Bar()
		{
			base.Disposed += this.U_Bar_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0f;
			this.thelinecolor = Color.Black;
			this.thefilledcolor = Color.Transparent;
			this.thetextfont = new Font("宋体", 9f);
			this.thetextcolor = Color.Black;
			this.thetext = "条码控件";
			this.theleftborder = false;
			this.thetopborder = false;
			this.therightborder = false;
			this.thebottomborder = false;
			this.themargins = new Margins(1, 0, 0, 0);
			this.mybartype = U_Bar.BarCode.Code39;
			this.myisprintlabel = true;
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
			this.DefineProperty[9, 0] = "BarType";
			this.DefineProperty[9, 1] = "条码类型";
			this.DefineProperty[10, 0] = "LeftBorder";
			this.DefineProperty[10, 1] = "左边框";
			this.DefineProperty[11, 0] = "RightBorder";
			this.DefineProperty[11, 1] = "右边框";
			this.DefineProperty[12, 0] = "TopBorder";
			this.DefineProperty[12, 1] = "上边框";
			this.DefineProperty[13, 0] = "BottomBorder";
			this.DefineProperty[13, 1] = "下边框";
			this.DefineProperty[14, 0] = "Margins";
			this.DefineProperty[14, 1] = "边距";
			this.DefineProperty[15, 0] = "TextFont";
			this.DefineProperty[15, 1] = "字体";
			this.DefineProperty[16, 0] = "TextColor";
			this.DefineProperty[16, 1] = "前景颜色";
			this.DefineProperty[17, 0] = "IsPrintLabel";
			this.DefineProperty[17, 1] = "打印标签";
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0005B920 File Offset: 0x00059B20
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0005B938 File Offset: 0x00059B38
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0005B950 File Offset: 0x00059B50
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0005B968 File Offset: 0x00059B68
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0005B980 File Offset: 0x00059B80
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0005B998 File Offset: 0x00059B98
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0005B9B0 File Offset: 0x00059BB0
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0005B9E0 File Offset: 0x00059BE0
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0005BA10 File Offset: 0x00059C10
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
							array[i] = new U_Bar.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0005BACC File Offset: 0x00059CCC
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0005BADC File Offset: 0x00059CDC
		private void U_Bar_Disposed(object sender, EventArgs e)
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

		// Token: 0x06000A4A RID: 2634 RVA: 0x0005BB18 File Offset: 0x00059D18
		public void RestoreFromString(string ss)
		{
			string[] array = ss.Split(mbsjmodule.G_MB_Spetator_Proper,StringSplitOptions.RemoveEmptyEntries);
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
			this.LeftBorder = DataTypeConversion.ToBoolean(array[7]);
			this.RightBorder = DataTypeConversion.ToBoolean(array[8]);
			this.TopBorder = DataTypeConversion.ToBoolean(array[9]);
			this.BottomBorder = DataTypeConversion.ToBoolean(array[10]);
			this.FilledColor = Module1.ConvertStringToColor(array[11]);
			this.BarType = (U_Bar.BarCode)Convert.ToInt32(array[12]);
			this.TextFont = Module1.ConvertStringToFont(array[13]);
			this.Margins = new Margins(Convert.ToInt32(array[14]), Convert.ToInt32(array[15]), Convert.ToInt32(array[16]), Convert.ToInt32(array[17]));
			this.TextValue = array[18];
			this.TextColor = Module1.ConvertStringToColor(array[19]);
			try
			{
				this.IsPrintLabel = DataTypeConversion.ToBoolean(array[20]);
			}
			catch (Exception ex)
			{
				this.IsPrintLabel = true;
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0005BC90 File Offset: 0x00059E90
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.BarType);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertFontToString(this.TextFont);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Left);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Right);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Top);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Bottom);
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.TextValue;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.TextColor);
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsPrintLabel, "1", "0"));
		}

		// Token: 0x0400056B RID: 1387
		private IContainer components;

		// Token: 0x0400056C RID: 1388
		private float MYX;

		// Token: 0x0400056D RID: 1389
		private float MYY;

		// Token: 0x0400056E RID: 1390
		private bool theisprint;

		// Token: 0x0400056F RID: 1391
		private float thelinewidth;

		// Token: 0x04000570 RID: 1392
		private Color thelinecolor;

		// Token: 0x04000571 RID: 1393
		private Color thefilledcolor;

		// Token: 0x04000572 RID: 1394
		private Font thetextfont;

		// Token: 0x04000573 RID: 1395
		private Color thetextcolor;

		// Token: 0x04000574 RID: 1396
		private string thetext;

		// Token: 0x04000575 RID: 1397
		private bool theleftborder;

		// Token: 0x04000576 RID: 1398
		private bool thetopborder;

		// Token: 0x04000577 RID: 1399
		private bool therightborder;

		// Token: 0x04000578 RID: 1400
		private bool thebottomborder;

		// Token: 0x04000579 RID: 1401
		private Margins themargins;

		// Token: 0x0400057A RID: 1402
		private U_Bar.BarCode mybartype;

		// Token: 0x0400057B RID: 1403
		private bool myisprintlabel;

		// Token: 0x0400057C RID: 1404
		private string[,] DefineProperty;

		// Token: 0x0200003F RID: 63
		public enum BarCode
		{
			// Token: 0x0400057E RID: 1406
			EAN13,
			// Token: 0x0400057F RID: 1407
			ENA8,
			// Token: 0x04000580 RID: 1408
			Code39,
			// Token: 0x04000581 RID: 1409
			Code128,
			// Token: 0x04000582 RID: 1410
			Code128A,
			// Token: 0x04000583 RID: 1411
			Code128B,
			// Token: 0x04000584 RID: 1412
			Code128C,
			// Token: 0x04000585 RID: 1413
			Codabar,
			// Token: 0x04000586 RID: 1414
			Code11,
			// Token: 0x04000587 RID: 1415
			Code25,
			// Token: 0x04000588 RID: 1416
			Code25_Stand,
			// Token: 0x04000589 RID: 1417
			ISBN,
			// Token: 0x0400058A RID: 1418
			CODE39Extended
		}

		// Token: 0x02000040 RID: 64
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000A4C RID: 2636 RVA: 0x00004AF2 File Offset: 0x00002CF2
			public XpropDescriptor(U_Bar cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000A4D RID: 2637 RVA: 0x0005BEE4 File Offset: 0x0005A0E4
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0005BEF4 File Offset: 0x0005A0F4
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000A4F RID: 2639 RVA: 0x0005BF0C File Offset: 0x0005A10C
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
				else if (String.Compare(left, "bartype", false) == 0)
				{
					result = this.mycc.BarType;
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
				else if (String.Compare(left, "margins", false) == 0)
				{
					result = this.mycc.Margins;
				}
				else if (String.Compare(left, "textfont", false) == 0)
				{
					result = this.mycc.TextFont;
				}
				else if (String.Compare(left, "textcolor", false) == 0)
				{
					result = this.mycc.TextColor;
				}
				else if (String.Compare(left, "isprintlabel", false) == 0)
				{
					result = this.mycc.IsPrintLabel;
				}
				else
				{
					Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
					result = null;
				}
				return result;
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0005C1CC File Offset: 0x0005A3CC
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0005C1DC File Offset: 0x0005A3DC
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
					else if (String.Compare(left, "bartype", false) == 0)
					{
						result = this.mycc.BarType.GetType();
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
					else if (String.Compare(left, "margins", false) == 0)
					{
						result = this.mycc.Margins.GetType();
					}
					else if (String.Compare(left, "textfont", false) == 0)
					{
						result = this.mycc.TextFont.GetType();
					}
					else if (String.Compare(left, "textcolor", false) == 0)
					{
						result = this.mycc.TextColor.GetType();
					}
					else if (String.Compare(left, "isprintlabel", false) == 0)
					{
						result = this.mycc.IsPrintLabel.GetType();
					}
					else
					{
						Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
						result = null;
					}
					return result;
				}
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
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
				else if (String.Compare(left, "filledcolor", false) == 0)
				{
					Color color = new Color();
					this.mycc.FilledColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "textvalue", false) == 0)
				{
					this.mycc.TextValue = Convert.ToString(value);
				}
				else if (String.Compare(left, "bartype", false) == 0)
				{
					this.mycc.BarType = (U_Bar.BarCode)Convert.ToInt32(value);
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
				else if (String.Compare(left, "margins", false) == 0)
				{
					this.mycc.Margins = (Margins)value;
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
				else if (String.Compare(left, "isprintlabel", false) == 0)
				{
					this.mycc.IsPrintLabel = DataTypeConversion.ToBoolean(value);
				}
				else
				{
					Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, "提示信息");
				}
			}

			// Token: 0x06000A54 RID: 2644 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x0400058B RID: 1419
			private string theProp;

			// Token: 0x0400058C RID: 1420
			private U_Bar mycc;
		}
	}
}
