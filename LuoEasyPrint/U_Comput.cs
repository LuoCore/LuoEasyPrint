using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000043 RID: 67
	[DesignerGenerated]
	[Browsable(false)]
	[ToolboxItem(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class U_Comput : UserControl, IControl, ICustomTypeDescriptor
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x0005D44C File Offset: 0x0005B64C
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

		// Token: 0x06000A85 RID: 2693 RVA: 0x0005D49C File Offset: 0x0005B69C
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
			this.Name = "U_Comput";
			Size size = new Size(169, 37);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0005D514 File Offset: 0x0005B714
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

		// Token: 0x06000A87 RID: 2695 RVA: 0x0005D574 File Offset: 0x0005B774
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

		// Token: 0x06000A88 RID: 2696 RVA: 0x0005D5C8 File Offset: 0x0005B7C8
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

		// Token: 0x06000A89 RID: 2697 RVA: 0x0005D634 File Offset: 0x0005B834
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0005D6A0 File Offset: 0x0005B8A0
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Description("以套打模式打印或预览时，是否打印该控件的背景颜色（填充颜色）")]
		[Category("行为")]
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

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0005D6B4 File Offset: 0x0005B8B4
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00004BC9 File Offset: 0x00002DC9
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0005D6C8 File Offset: 0x0005B8C8
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00004BD2 File Offset: 0x00002DD2
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

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0005D6DC File Offset: 0x0005B8DC
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00004BDB File Offset: 0x00002DDB
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0005D6FC File Offset: 0x0005B8FC
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00004BF2 File Offset: 0x00002DF2
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0005D71C File Offset: 0x0005B91C
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00004C09 File Offset: 0x00002E09
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0005D73C File Offset: 0x0005B93C
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00004C20 File Offset: 0x00002E20
		[Category("布局")]
		[Description("控件的高度,以毫米为计量单位")]
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0005D75C File Offset: 0x0005B95C
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00004C37 File Offset: 0x00002E37
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0005D774 File Offset: 0x0005B974
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00004C55 File Offset: 0x00002E55
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0005D78C File Offset: 0x0005B98C
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00004C64 File Offset: 0x00002E64
		[Category("外观")]
		[Description("文本背景颜色")]
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00004C73 File Offset: 0x00002E73
		[Description("文本对齐方式")]
		[Category("外观")]
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0005D7BC File Offset: 0x0005B9BC
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00004C82 File Offset: 0x00002E82
		[TypeConverter(typeof(mbsjmodule.StrChoice2))]
		[Description("计算公式数据源")]
		[Category("数据")]
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0005D7D4 File Offset: 0x0005B9D4
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00004C91 File Offset: 0x00002E91
		[Description("计算公式类型")]
		[Category("数据")]
		public U_Comput.Compute_Type TextType
		{
			get
			{
				return this.thetexttype;
			}
			set
			{
				this.thetexttype = value;
				this.Invalidate();
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0005D7EC File Offset: 0x0005B9EC
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[Category("外观")]
		[Description("文本字体")]
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0005D804 File Offset: 0x0005BA04
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00004CBC File Offset: 0x00002EBC
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0005D81C File Offset: 0x0005BA1C
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00004CCB File Offset: 0x00002ECB
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0005D834 File Offset: 0x0005BA34
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00004CE1 File Offset: 0x00002EE1
		[Description("文本是否允许自动换行打印)")]
		[Category("外观")]
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

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0005D848 File Offset: 0x0005BA48
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00004CF0 File Offset: 0x00002EF0
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0005D85C File Offset: 0x0005BA5C
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00004CFF File Offset: 0x00002EFF
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0005D870 File Offset: 0x0005BA70
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00004D0E File Offset: 0x00002F0E
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0005D884 File Offset: 0x0005BA84
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00004D1D File Offset: 0x00002F1D
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0005D898 File Offset: 0x0005BA98
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00004D2C File Offset: 0x00002F2C
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00004D3B File Offset: 0x00002F3B
		[Category("外观")]
		[Description("列内容前缀字符,打印在该列内容的前面")]
		public string BeforeText
		{
			get
			{
				return this.thebeforetext;
			}
			set
			{
				this.thebeforetext = value;
				this.Invalidate();
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0005D8C8 File Offset: 0x0005BAC8
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00004D4A File Offset: 0x00002F4A
		[Category("外观")]
		[Description("该计算公式结果的格式,设计时不应用,打印或预览时才应用格式")]
		public string Format
		{
			get
			{
				return this.theformat;
			}
			set
			{
				this.theformat = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0005D8E0 File Offset: 0x0005BAE0
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00004D53 File Offset: 0x00002F53
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

		// Token: 0x06000ABC RID: 2748 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
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
			if (this.Direction)
			{
				stringFormatFlags |= StringFormatFlags.DirectionVertical;
			}
			else
			{
				stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
			}
			stringFormatFlags |= StringFormatFlags.NoClip;
			stringFormat.FormatFlags = stringFormatFlags;
			stringFormat.Alignment = mbsjmodule.GetHalign(this.TextAlign);
			stringFormat.LineAlignment = mbsjmodule.GetValign(this.TextAlign);
			string text = "";
			switch (this.TextType)
			{
			case U_Comput.Compute_Type.const_0:
				text = "求和";
				break;
			case U_Comput.Compute_Type.const_1:
				text = "计数";
				break;
			case U_Comput.Compute_Type.const_2:
				text = "平均值";
				break;
			case U_Comput.Compute_Type.const_3:
				text = "最大值";
				break;
			case U_Comput.Compute_Type.const_4:
				text = "最小值";
				break;
			}
			text = string.Concat(new string[]
			{
				this.BeforeText,
				text,
				"(",
				this.TextValue,
				")"
			});
			Graphics graphics = e.Graphics;
			string s = text;
			Font textFont = this.TextFont;
			Brush brush = new SolidBrush(this.TextColor);
			RectangleF layoutRectangle = new RectangleF(this.ConvertFromMM((float)this.Margins.Left, true), this.ConvertFromMM((float)this.Margins.Top, false), (float)this.Width - this.ConvertFromMM((float)(checked(this.Margins.Left + this.Margins.Right)), true), (float)this.Height - this.ConvertFromMM((float)(checked(this.Margins.Top + this.Margins.Bottom)), false));
			graphics.DrawString(s, textFont, brush, layoutRectangle, stringFormat);
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

		// Token: 0x06000ABD RID: 2749 RVA: 0x00004AE3 File Offset: 0x00002CE3
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
		public U_Comput()
		{
			base.Disposed += this.U_Comput_Disposed;
			this.theisprint = true;
			this.thelinewidth = 0.2f;
			this.thelinecolor = Color.Black;
			this.thefilledcolor = Color.Transparent;
			this.thetextalign = ContentAlignment.MiddleLeft;
			this.thetext = "无";
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
			this.thebeforetext = "";
			this.theformat = "";
			this.thetexttype = U_Comput.Compute_Type.const_0;
			this.theistdborder = false;
			this.theistdbackcolor = false;
			this.DefineProperty = new string[3, 2];
			this.InitializeComponent();
			this.MYX = this.CreateGraphics().DpiX;
			this.MYY = this.CreateGraphics().DpiY;
			this.DefineProperty = new string[25, 2];
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
			this.DefineProperty[9, 1] = "数据字段";
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
			this.DefineProperty[20, 0] = "BeforeText";
			this.DefineProperty[20, 1] = "打印前缀";
			this.DefineProperty[21, 0] = "Format";
			this.DefineProperty[21, 1] = "显示格式";
			this.DefineProperty[22, 0] = "TextType";
			this.DefineProperty[22, 1] = "公式类型";
			this.DefineProperty[23, 0] = "IsTdBorder";
			this.DefineProperty[23, 1] = "套打边框";
			this.DefineProperty[24, 0] = "IsTdBackColor";
			this.DefineProperty[24, 1] = "套打背景颜色";
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0005E174 File Offset: 0x0005C374
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0005E18C File Offset: 0x0005C38C
		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0005E1A4 File Offset: 0x0005C3A4
		public string GetComponentName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0005E1BC File Offset: 0x0005C3BC
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0005E1D4 File Offset: 0x0005C3D4
		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0005E1EC File Offset: 0x0005C3EC
		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0005E204 File Offset: 0x0005C404
		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0005E21C File Offset: 0x0005C41C
		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0005E234 File Offset: 0x0005C434
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0005E24C File Offset: 0x0005C44C
		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0005E264 File Offset: 0x0005C464
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
							array[i] = new U_Comput.XpropDescriptor(this, this.DefineProperty[i, 1], attributes);
							i++;
							goto IL_9D;
						}
					}
				
				}
				return new PropertyDescriptorCollection(array);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0005E320 File Offset: 0x0005C520
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0005E330 File Offset: 0x0005C530
		private void U_Comput_Disposed(object sender, EventArgs e)
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

		// Token: 0x06000ACC RID: 2764 RVA: 0x0005E36C File Offset: 0x0005C56C
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
			this.FilledColor = Module1.ConvertStringToColor(array[11]);
			this.TextAlign = (ContentAlignment)Convert.ToInt32(array[12]);
			this.TextFont = Module1.ConvertStringToFont(array[13]);
			this.TextColor = Module1.ConvertStringToColor(array[14]);
			this.Cols = Convert.ToInt32(array[15]);
			this.Mulline = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[16], "1", false) == 0, true, false));
			this.Margins = new Margins(Convert.ToInt32(array[17]), Convert.ToInt32(array[18]), Convert.ToInt32(array[19]), Convert.ToInt32(array[20]));
			this.TextValue = array[21];
			this.BeforeText = array[22];
			this.Format = array[23];
			this.TextType = (U_Comput.Compute_Type)Convert.ToInt32(array[24]);
			this.Direction = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[25], "1", false) == 0, true, false));
			this.IsTdBorder = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[26], "1", false) == 0, true, false));
			this.IsTdBackColor = DataTypeConversion.ToBoolean(Interaction.IIf(String.Compare(array[27], "1", false) == 0, true, false));
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0005E614 File Offset: 0x0005C814
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
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.BeforeText;
			str = str + mbsjmodule.G_MB_Spetator_Proper + this.Format;
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString((int)this.TextType);
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.Direction, "1", "0"));
			str = str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBorder, "1", "0"));
			return str + mbsjmodule.G_MB_Spetator_Proper + Convert.ToString(Interaction.IIf(this.IsTdBackColor, "1", "0"));
		}

		// Token: 0x04000596 RID: 1430
		private IContainer components;

		// Token: 0x04000597 RID: 1431
		private float MYX;

		// Token: 0x04000598 RID: 1432
		private float MYY;

		// Token: 0x04000599 RID: 1433
		private bool theisprint;

		// Token: 0x0400059A RID: 1434
		private float thelinewidth;

		// Token: 0x0400059B RID: 1435
		private Color thelinecolor;

		// Token: 0x0400059C RID: 1436
		private Color thefilledcolor;

		// Token: 0x0400059D RID: 1437
		private ContentAlignment thetextalign;

		// Token: 0x0400059E RID: 1438
		private string thetext;

		// Token: 0x0400059F RID: 1439
		private Font thetextfont;

		// Token: 0x040005A0 RID: 1440
		private Color thetextcolor;

		// Token: 0x040005A1 RID: 1441
		private int thecols;

		// Token: 0x040005A2 RID: 1442
		private bool themulline;

		// Token: 0x040005A3 RID: 1443
		private bool theleftborder;

		// Token: 0x040005A4 RID: 1444
		private bool thetopborder;

		// Token: 0x040005A5 RID: 1445
		private bool therightborder;

		// Token: 0x040005A6 RID: 1446
		private bool thebottomborder;

		// Token: 0x040005A7 RID: 1447
		private Margins themargins;

		// Token: 0x040005A8 RID: 1448
		private bool thedirection;

		// Token: 0x040005A9 RID: 1449
		private string thebeforetext;

		// Token: 0x040005AA RID: 1450
		private string theformat;

		// Token: 0x040005AB RID: 1451
		private U_Comput.Compute_Type thetexttype;

		// Token: 0x040005AC RID: 1452
		private bool theistdborder;

		// Token: 0x040005AD RID: 1453
		private bool theistdbackcolor;

		// Token: 0x040005AE RID: 1454
		private string[,] DefineProperty;

		// Token: 0x02000044 RID: 68
		public enum Compute_Type
		{
			// Token: 0x040005B0 RID: 1456
			const_0,
			// Token: 0x040005B1 RID: 1457
			const_1,
			// Token: 0x040005B2 RID: 1458
			const_2,
			// Token: 0x040005B3 RID: 1459
			const_3,
			// Token: 0x040005B4 RID: 1460
			const_4
		}

		// Token: 0x02000045 RID: 69
		private class XpropDescriptor : PropertyDescriptor
		{
			// Token: 0x06000ACE RID: 2766 RVA: 0x00004D62 File Offset: 0x00002F62
			public XpropDescriptor(U_Comput cc, string prop, Attribute[] attrs) : base(prop, attrs)
			{
				this.theProp = cc.GetPropertyEnglishName(prop);
				this.mycc = cc;
			}

			// Token: 0x06000ACF RID: 2767 RVA: 0x0005E92C File Offset: 0x0005CB2C
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0005E93C File Offset: 0x0005CB3C
			public override Type ComponentType
			{
				get
				{
					return this.GetType();
				}
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x0005E954 File Offset: 0x0005CB54
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
				else if (String.Compare(left, "beforetext", false) == 0)
				{
					result = this.mycc.BeforeText;
				}
				else if (String.Compare(left, "format", false) == 0)
				{
					result = this.mycc.Format;
				}
				else if (String.Compare(left, "texttype", false) == 0)
				{
					result = this.mycc.TextType;
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

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0005ED08 File Offset: 0x0005CF08
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0005ED18 File Offset: 0x0005CF18
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
					else if (String.Compare(left, "beforetext", false) == 0)
					{
						result = this.mycc.BeforeText.GetType();
					}
					else if (String.Compare(left, "format", false) == 0)
					{
						result = this.mycc.Format.GetType();
					}
					else if (String.Compare(left, "texttype", false) == 0)
					{
						result = this.mycc.TextType.GetType();
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

			// Token: 0x06000AD4 RID: 2772 RVA: 0x00002590 File Offset: 0x00000790
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000AD5 RID: 2773 RVA: 0x0005F14C File Offset: 0x0005D34C
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
				else if (String.Compare(left, "beforetext", false) == 0)
				{
					this.mycc.BeforeText = Convert.ToString(value);
				}
				else if (String.Compare(left, "format", false) == 0)
				{
					this.mycc.Format = Convert.ToString(value);
				}
				else if (String.Compare(left, "texttype", false) == 0)
				{
					this.mycc.TextType = (U_Comput.Compute_Type)Convert.ToInt32(value);
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

			// Token: 0x06000AD6 RID: 2774 RVA: 0x0005F53C File Offset: 0x0005D73C
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x040005B5 RID: 1461
			private string theProp;

			// Token: 0x040005B6 RID: 1462
			private U_Comput mycc;
		}
	}
}
