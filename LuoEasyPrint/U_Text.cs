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
	// Token: 0x02000059 RID: 89
	[ToolboxItem(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerGenerated]
	public class U_Text : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x0006960C File Offset: 0x0006780C
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

		// Token: 0x06000CCA RID: 3274 RVA: 0x0006965C File Offset: 0x0006785C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			Padding margin = new Padding(0);
			this.Margin = margin;
			this.Name = "U_Text";
			Size size = new Size(169, 37);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000696D4 File Offset: 0x000678D4
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

		// Token: 0x06000CCC RID: 3276 RVA: 0x00069734 File Offset: 0x00067934
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

		// Token: 0x06000CCD RID: 3277 RVA: 0x00069788 File Offset: 0x00067988
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

		// Token: 0x06000CCE RID: 3278 RVA: 0x000697F4 File Offset: 0x000679F4
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00069860 File Offset: 0x00067A60
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00005638 File Offset: 0x00003838
		[Category("行为")]
		[Description("以套打模式打印或预览时，是否打印该控件的背景颜色（填充颜色）")]
		public bool IsTdBackColor
		{
			get
			{
				return this.theistdbackcolor;
			}
			set
			{
				this.theistdbackcolor = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00069874 File Offset: 0x00067A74
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00005641 File Offset: 0x00003841
		[Description("以套打模式打印或预览时，是否打印该控件的边框（如果设置为显示边框的话）")]
		[Category("行为")]
		public bool IsTdBorder
		{
			get
			{
				return this.theistdborder;
			}
			set
			{
				this.theistdborder = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00069888 File Offset: 0x00067A88
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x0000564A File Offset: 0x0000384A
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0006989C File Offset: 0x00067A9C
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00005653 File Offset: 0x00003853
		[Category("布局")]
		[Description("控件所处的X位置,以毫米为计量单位")]
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000698BC File Offset: 0x00067ABC
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x0000566A File Offset: 0x0000386A
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

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000698DC File Offset: 0x00067ADC
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00005681 File Offset: 0x00003881
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000698FC File Offset: 0x00067AFC
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00005698 File Offset: 0x00003898
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

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0006991C File Offset: 0x00067B1C
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000056AF File Offset: 0x000038AF
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00069934 File Offset: 0x00067B34
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x000056CD File Offset: 0x000038CD
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

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0006994C File Offset: 0x00067B4C
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000056DC File Offset: 0x000038DC
		[Description("文本背景颜色")]
		[Category("外观")]
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00069964 File Offset: 0x00067B64
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x000056EB File Offset: 0x000038EB
		[Category("外观")]
		[Description("文本对齐方式")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.thetextalign;
			}
			set
			{
				this.thetextalign = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0006997C File Offset: 0x00067B7C
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x000056FA File Offset: 0x000038FA
		[Description("要打印的文本内容，可以包含纯文本、系统变量、自定义变量和字段变量的组合")]
		[Editor(typeof(U_Editor), typeof(UITypeEditor))]
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00069994 File Offset: 0x00067B94
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00005709 File Offset: 0x00003909
		[Description("文本字体")]
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000699AC File Offset: 0x00067BAC
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00005725 File Offset: 0x00003925
		[Category("外观")]
		[Description("文本前景颜色")]
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000699C4 File Offset: 0x00067BC4
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00005734 File Offset: 0x00003934
		[Category("外观")]
		[Description("分散打印的列数(为1表示普通打印)")]
		public int Cols
		{
			get
			{
				return this.thecols;
			}
			set
			{
				if (value <= 0)
				{
					value = 1;
				}
				this.thecols = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x000699DC File Offset: 0x00067BDC
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0000574A File Offset: 0x0000394A
		[Category("外观")]
		[Description("文本是否允许自动换行打印)")]
		public bool Mulline
		{
			get
			{
				return this.themulline;
			}
			set
			{
				this.themulline = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000699F0 File Offset: 0x00067BF0
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00005759 File Offset: 0x00003959
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00069A04 File Offset: 0x00067C04
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00005768 File Offset: 0x00003968
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00069A18 File Offset: 0x00067C18
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00005777 File Offset: 0x00003977
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00069A2C File Offset: 0x00067C2C
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00005786 File Offset: 0x00003986
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00069A40 File Offset: 0x00067C40
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00005795 File Offset: 0x00003995
		[Category("外观")]
		[Description("单元格文本与边框的间距,计量单位为毫米,且必须是整数")]
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00069A58 File Offset: 0x00067C58
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000057A4 File Offset: 0x000039A4
		[Description("文本的打印方向,为False表示是从左至右的方向,为True表示从上至下的打印方向")]
		[Category("外观")]
		public bool Direction
		{
			get
			{
				return this.thedirection;
			}
			set
			{
				this.thedirection = value;
				this.Invalidate();
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00069A6C File Offset: 0x00067C6C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			float num = this.ConvertFromMM(this.LineWidth, true);
			Pen pen = new Pen(this.LineColor, num);
			e.Graphics.FillRectangle(new SolidBrush(this.FilledColor), 0, 0, this.Width, this.Height);
			if (this.LeftBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, num / 2f, num / 2f, (float)this.Height - num);
			}
			if (this.RightBorder)
			{
				e.Graphics.DrawLine(pen, (float)this.Width - num, num / 2f, (float)this.Width - num, (float)this.Height - num / 2f);
			}
			if (this.TopBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, num / 2f, (float)this.Width - num, num / 2f);
			}
			if (this.BottomBorder)
			{
				e.Graphics.DrawLine(pen, num / 2f, (float)this.Height - num, (float)this.Width - num, (float)this.Height - num);
			}
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
			if (!this.Mulline)
			{
				stringFormatFlags |= StringFormatFlags.NoWrap;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.NoWrap;
			}
			stringFormatFlags |= StringFormatFlags.NoClip;
			if (this.Direction)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			stringFormat.FormatFlags = stringFormatFlags;
			stringFormat.Alignment = mbsjmodule.GetHalign(this.TextAlign);
			stringFormat.LineAlignment = mbsjmodule.GetValign(this.TextAlign);
			Graphics graphics = e.Graphics;
			string textValue = this.TextValue;
			Font textFont = this.TextFont;
			Brush brush = new SolidBrush(this.TextColor);
			RectangleF layoutRectangle = new RectangleF(this.ConvertFromMM((float)this.Margins.Left, true), this.ConvertFromMM((float)this.Margins.Top, false), (float)this.Width - this.ConvertFromMM((float)(checked(this.Margins.Left + this.Margins.Right)), true), (float)this.Height - this.ConvertFromMM((float)(checked(this.Margins.Top + this.Margins.Bottom)), false));
			graphics.DrawString(textValue, textFont, brush, layoutRectangle, stringFormat);
			float num2 = (float)((double)this.Width / (double)this.Cols);
			float num3 = (float)((double)this.Height / (double)this.Cols);
			checked
			{
				if (this.Direction)
				{
					int num4 = 1;
					int num5 = this.Cols - 1;
					for (int i = num4; i <= num5; i++)
					{
						unchecked
						{
							float num6 = num3 * (float)i;
							e.Graphics.DrawLine(pen, num / 2f, num6 + num / 2f, (float)this.Width, num6 + num / 2f);
						}
					}
				}
				else
				{
					int num7 = 1;
					int num8 = this.Cols - 1;
					for (int j = num7; j <= num8; j++)
					{
						unchecked
						{
							float num9 = num2 * (float)j;
							e.Graphics.DrawLine(pen, num9 + num / 2f, 0f, num9 + num / 2f, (float)this.Height);
						}
					}
				}
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00069D8C File Offset: 0x00067F8C
		public U_Text()
		{
			base.Disposed += this.U_Text_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0.2f;
			this.thelinecolor = Color.Black;
			this.thefilledcolor = Color.Transparent;
			this.thetextalign = ContentAlignment.MiddleLeft;
			this.thetext = "文本控件";
			this.thetextfont = new Font("宋体", 9f);
			this.thetextcolor = Color.Black;
			this.thecols = 1;
			this.themulline = true;
			this.theleftborder = false;
			this.thetopborder = false;
			this.therightborder = false;
			this.thebottomborder = false;
			this.themargins = new Margins(1, 1, 0, 0);
			this.thedirection = false;
			this.theistdborder = false;
			this.theistdbackcolor = false;
			this.DefineProperty = new string[3, 2];
			this.InitializeComponent();
			this.MYX = this.CreateGraphics().DpiX;
			this.MYY = this.CreateGraphics().DpiY;
			this.DefineProperty = new string[22, 2];
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
			this.DefineProperty[8, 0] = "TextAlign";
			this.DefineProperty[8, 1] = "文本对齐方式";
			this.DefineProperty[9, 0] = "TextValue";
			this.DefineProperty[9, 1] = "文本";
			this.DefineProperty[10, 0] = "TextFont";
			this.DefineProperty[10, 1] = "字体";
			this.DefineProperty[11, 0] = "TextColor";
			this.DefineProperty[11, 1] = "文本颜色";
			this.DefineProperty[12, 0] = "Cols";
			this.DefineProperty[12, 1] = "分列打印";
			this.DefineProperty[13, 0] = "Mulline";
			this.DefineProperty[13, 1] = "自动换行";
			this.DefineProperty[14, 0] = "LeftBorder";
			this.DefineProperty[14, 1] = "左边框";
			this.DefineProperty[15, 0] = "RightBorder";
			this.DefineProperty[15, 1] = "右边框";
			this.DefineProperty[16, 0] = "TopBorder";
			this.DefineProperty[16, 1] = "上边框";
			this.DefineProperty[17, 0] = "BottomBorder";
			this.DefineProperty[17, 1] = "下边框";
			this.DefineProperty[18, 0] = "Margins";
			this.DefineProperty[18, 1] = "边距";
			this.DefineProperty[19, 0] = "Direction";
			this.DefineProperty[19, 1] = "文本方向";
			this.DefineProperty[20, 0] = "IsTdBorder";
			this.DefineProperty[20, 1] = "套打边框";
			this.DefineProperty[21, 0] = "IsTdBackColor";
			this.DefineProperty[21, 1] = "套打背景颜色";
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0006A1D0 File Offset: 0x000683D0
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0006A1E8 File Offset: 0x000683E8
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0006A200 File Offset: 0x00068400
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0006A218 File Offset: 0x00068418
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0006A230 File Offset: 0x00068430
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0006A248 File Offset: 0x00068448
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0006A260 File Offset: 0x00068460
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0006A278 File Offset: 0x00068478
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0006A290 File Offset: 0x00068490
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0006A2A8 File Offset: 0x000684A8
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0006A2C0 File Offset: 0x000684C0
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
							array[i] = new U_Text.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
					
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0006A37C File Offset: 0x0006857C
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0006A38C File Offset: 0x0006858C
		private void U_Text_Disposed(object sender, EventArgs e)
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

		// Token: 0x06000D0B RID: 3339 RVA: 0x0006A3C8 File Offset: 0x000685C8
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
			//this.LeftBorder = DataTypeConversion.ToBoolean(array[7]);
			this.LeftBorder =DataTypeConversion.ToBoolean(array[7]);
			this.RightBorder = DataTypeConversion.ToBoolean(array[8]);
			this.TopBorder = DataTypeConversion.ToBoolean(array[9]);
			this.BottomBorder = DataTypeConversion.ToBoolean(array[10]);
			this.FilledColor = Module1.ConvertStringToColor(array[11]);
			this.TextAlign = (ContentAlignment)Convert.ToInt32(array[12]);
			this.TextFont = Module1.ConvertStringToFont(array[13]);
			this.TextColor = Module1.ConvertStringToColor(array[14]);
			this.Cols = Convert.ToInt32(array[15]);
			this.Mulline = DataTypeConversion.ToBoolean(array[16]);
			this.Margins = new Margins(Convert.ToInt32(array[17]), Convert.ToInt32(array[18]), Convert.ToInt32(array[19]), Convert.ToInt32(array[20]));
			this.TextValue = array[21];
			this.Direction = DataTypeConversion.ToBoolean(array[22]);
			this.IsTdBorder = DataTypeConversion.ToBoolean(array[23]);
			this.IsTdBackColor = DataTypeConversion.ToBoolean(array[24]);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0006A554 File Offset: 0x00068754
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.TextAlign);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertFontToString(this.TextFont);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Module1.ConvertColorToString(this.TextColor);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Cols);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Mulline, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Left);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Right);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Top);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(this.Margins.Bottom);
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.TextValue;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Direction, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBorder, "1", "0"));
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBackColor, "1", "0"));
		}

		// Token: 0x04000645 RID: 1605
		private IContainer components;

		// Token: 0x04000646 RID: 1606
		private float MYX;

		// Token: 0x04000647 RID: 1607
		private float MYY;

		// Token: 0x04000648 RID: 1608
		private bool theisprint;

		// Token: 0x04000649 RID: 1609
		private float thelinewidth;

		// Token: 0x0400064A RID: 1610
		private Color thelinecolor;

		// Token: 0x0400064B RID: 1611
		private Color thefilledcolor;

		// Token: 0x0400064C RID: 1612
		private ContentAlignment thetextalign;

		// Token: 0x0400064D RID: 1613
		private string thetext;

		// Token: 0x0400064E RID: 1614
		private Font thetextfont;

		// Token: 0x0400064F RID: 1615
		private Color thetextcolor;

		// Token: 0x04000650 RID: 1616
		private int thecols;

		// Token: 0x04000651 RID: 1617
		private bool themulline;

		// Token: 0x04000652 RID: 1618
		private bool theleftborder;

		// Token: 0x04000653 RID: 1619
		private bool thetopborder;

		// Token: 0x04000654 RID: 1620
		private bool therightborder;

		// Token: 0x04000655 RID: 1621
		private bool thebottomborder;

		// Token: 0x04000656 RID: 1622
		private Margins themargins;

		// Token: 0x04000657 RID: 1623
		private bool thedirection;

		// Token: 0x04000658 RID: 1624
		private bool theistdborder;

		// Token: 0x04000659 RID: 1625
		private bool theistdbackcolor;

		// Token: 0x0400065A RID: 1626
		public string[,] DefineProperty;

		// Token: 0x0200005A RID: 90
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000D0D RID: 3341 RVA: 0x000057B3 File Offset: 0x000039B3
			public XpropDescriptor(U_Text cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x0006A830 File Offset: 0x00068A30
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0006A840 File Offset: 0x00068A40
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x0006A858 File Offset: 0x00068A58
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
				else if (String.Compare(left, "textalign", false) == 0)
				{
					result = this.mycc.TextAlign;
				}
				else if (String.Compare(left, "textvalue", false) == 0)
				{
					result = this.mycc.TextValue;
				}
				else if (String.Compare(left, "textfont", false) == 0)
				{
					result = this.mycc.TextFont;
				}
				else if (String.Compare(left, "textcolor", false) == 0)
				{
					result = this.mycc.TextColor;
				}
				else if (String.Compare(left, "cols", false) == 0)
				{
					result = this.mycc.Cols;
				}
				else if (String.Compare(left, "mulline", false) == 0)
				{
					result = this.mycc.Mulline;
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
				else if (String.Compare(left, "direction", false) == 0)
				{
					result = this.mycc.Direction;
				}
				else if (String.Compare(left, "istdborder", false) == 0)
				{
					result = this.mycc.IsTdBorder;
				}
				else if (String.Compare(left, "istdbackcolor", false) == 0)
				{
					result = this.mycc.IsTdBackColor;
				}
				else
				{
					Interaction.MsgBox("GetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
					result = null;
				}
				return result;
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0006ABA8 File Offset: 0x00068DA8
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0006ABB8 File Offset: 0x00068DB8
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
					else if (String.Compare(left, "textalign", false) == 0)
					{
						result = this.mycc.TextAlign.GetType();
					}
					else if (String.Compare(left, "textvalue", false) == 0)
					{
						result = this.mycc.TextValue.GetType();
					}
					else if (String.Compare(left, "textfont", false) == 0)
					{
						result = this.mycc.TextFont.GetType();
					}
					else if (String.Compare(left, "textcolor", false) == 0)
					{
						result = this.mycc.TextColor.GetType();
					}
					else if (String.Compare(left, "cols", false) == 0)
					{
						result = this.mycc.Cols.GetType();
					}
					else if (String.Compare(left, "mulline", false) == 0)
					{
						result = this.mycc.Mulline.GetType();
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
					else if (String.Compare(left, "direction", false) == 0)
					{
						result = this.mycc.Direction.GetType();
					}
					else if (String.Compare(left, "istdborder", false) == 0)
					{
						result = this.mycc.IsTdBorder.GetType();
					}
					else if (String.Compare(left, "istdbackcolor", false) == 0)
					{
						result = this.mycc.IsTdBackColor.GetType();
					}
					else
					{
						Interaction.MsgBox("Property过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
						result = null;
					}
					return result;
				}
			}

			// Token: 0x06000D13 RID: 3347 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x0006AF78 File Offset: 0x00069178
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
					Color color = new Color();
					this.mycc.LineColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "filledcolor", false) == 0)
				{
					Color color = new Color();
					this.mycc.FilledColor = ((value != null) ? ((Color)value) : color);
				}
				else if (String.Compare(left, "textalign", false) == 0)
				{
					this.mycc.TextAlign = (ContentAlignment)Convert.ToInt32(value);
				}
				else if (String.Compare(left, "textvalue", false) == 0)
				{
					this.mycc.TextValue = Convert.ToString(value);
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
				else if (String.Compare(left, "cols", false) == 0)
				{
					this.mycc.Cols = Convert.ToInt32(value);
				}
				else if (String.Compare(left, "mulline", false) == 0)
				{
					this.mycc.Mulline = DataTypeConversion.ToBoolean(value);
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
				else if (String.Compare(left, "direction", false) == 0)
				{
					this.mycc.Direction = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "istdborder", false) == 0)
				{
					this.mycc.IsTdBorder = DataTypeConversion.ToBoolean(value);
				}
				else if (String.Compare(left, "istdbackcolor", false) == 0)
				{
					this.mycc.IsTdBackColor = DataTypeConversion.ToBoolean(value);
				}
				else
				{
					Interaction.MsgBox("SetValue过程编程错误,属性名称[" + this.theProp + "]未找到", MsgBoxStyle.OkOnly, null);
				}
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x0006B2F8 File Offset: 0x000694F8
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x0400065B RID: 1627
			private string theProp;

			// Token: 0x0400065C RID: 1628
			private U_Text mycc;
		}
	}
}
