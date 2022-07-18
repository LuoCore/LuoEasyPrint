using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;

namespace LuoEasyPrint
{
	// Token: 0x0200016A RID: 362
	[ToolboxBitmap(typeof(ExpressionDrawer), "graph.bmp")]
	[Description("适合简单表达式绘图的组件")]
	[Guid("607880ED-68DE-4FD5-A0F7-FE90FC0D9E59")]
	public class ExpressionDrawer : Component
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		[DebuggerNonUserCode]
		public ExpressionDrawer(IContainer container) : this()
		{
			if (container != null)
			{
				container.Add(this);
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000FF48C File Offset: 0x000FD68C
		[DebuggerNonUserCode]
		public ExpressionDrawer()
		{
			this.bDisplayText = true;
			this.bGrids = false;
			this.dForwardX = 0.0;
			this.dForwardY = 0.0;
			this.dScaleX = 10.0;
			this.dScaleY = 10.0;
			this.mygraphMode = GraphMode.Rectangular;
			this.iDivisionsX = 5;
			this.iDivisionsY = 5;
			this.iPenWidth = 1;
			this.iPolarSensitivity = 100;
			this.iPrintStepX = 1;
			this.iPrintStepY = 1;
			this.myscalefont = new Font("宋体", 8f);
			this.myexpressiontextfont = new Font("宋体", 10f);
			this.Separator1 = "\a\u0001";
			this.Separator = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(4));
			this.expressions = new List<ExpressionDrawer.Expression>();
			this.expColors = new List<Color>();
			this.InitializeComponent();
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000FF590 File Offset: 0x000FD790
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				this.expColors.Clear();
				this.expColors = null;
				this.expressions.Clear();
				this.expressions = null;
				this.myscalefont.Dispose();
				this.myexpressiontextfont.Dispose();
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0000AAF2 File Offset: 0x00008CF2
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000FF608 File Offset: 0x000FD808
		public string GetDataString()
		{
			string separator = this.Separator1;
			string str = Convert.ToString(this.DivisionsX);
			str = str + separator + Convert.ToString(this.DivisionsY);
			str = str + separator + Convert.ToString(this.ScaleX);
			str = str + separator + Convert.ToString(this.ScaleY);
			str = str + separator + Convert.ToString(this.ForwardX);
			str = str + separator + Convert.ToString(this.ForwardY);
			str = str + separator + Convert.ToString(this.PrintStepX);
			str = str + separator + Convert.ToString(this.PrintStepY);
			str = str + separator + Convert.ToString(this.PolarSensitivity);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Grids, "1", "0"));
			str = str + separator + Convert.ToString(Interaction.IIf(this.DisplayText, "1", "0"));
			str = str + separator + Convert.ToString((int)this.GraphMode);
			str = str + separator + Convert.ToString(this.PenWidth);
			str = str + separator + Module1.ConvertFontToString(this.ScaleFont);
			str = str + separator + Module1.ConvertFontToString(this.ExpressionTextFont);
			string text = "";
			str += this.Separator;
			int num = 0;
			checked
			{
				int num2 = this.expColors.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (i == 0)
					{
						text = Module1.ConvertColorToString(this.expColors[i]);
					}
					else
					{
						text = text + separator + Module1.ConvertColorToString(this.expColors[i]);
					}
				}
				str += text;
				text = "";
				str += this.Separator;
				int num3 = 0;
				int num4 = this.expressions.Count - 1;
				for (int j = num3; j <= num4; j++)
				{
					if (j == 0)
					{
						text = this.expressions[j].ExpressionText;
					}
					else
					{
						text = text + separator + this.expressions[j].ExpressionText;
					}
				}
				return str + text;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000FF838 File Offset: 0x000FDA38
		public void ParaseString(string ss)
		{
			string[] array = Strings.Split(ss, this.Separator, -1, CompareMethod.Binary);
			string separator = this.Separator1;
			string[] array2 = Strings.Split(array[0], separator, -1, CompareMethod.Binary);
			this.DivisionsX = Convert.ToInt32(array2[0]);
			this.DivisionsY = Convert.ToInt32(array2[1]);
			this.ScaleX = Convert.ToDouble(array2[2]);
			this.ScaleY = Convert.ToDouble(array2[3]);
			this.ForwardX = Convert.ToDouble(array2[4]);
			this.ForwardY = Convert.ToDouble(array2[5]);
			this.PrintStepX = Convert.ToInt32(array2[6]);
			this.PrintStepY = Convert.ToInt32(array2[7]);
			this.PolarSensitivity = Convert.ToInt32(array2[8]);
			this.Grids = Convert.ToBoolean(Interaction.IIf(String.Compare(array2[9], "1", false) == 0, true, false));
			this.DisplayText = Convert.ToBoolean(Interaction.IIf(String.Compare(array2[10], "1", false) == 0, true, false));
			this.GraphMode = (GraphMode)Convert.ToInt32(array2[11]);
			this.PenWidth = Convert.ToInt32(array2[12]);
			this.ScaleFont = Module1.ConvertStringToFont(array2[13]);
			this.ExpressionTextFont = Module1.ConvertStringToFont(array2[14]);
			array2 = Strings.Split(array[1], separator, -1, CompareMethod.Binary);
			this.RemoveAllExpressions();
			string[] array3 = Strings.Split(array[2], separator, -1, CompareMethod.Binary);
			int num = 0;
			checked
			{
				int num2 = array2.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					this.AddExpression(array3[i], Module1.ConvertStringToColor(array2[i]));
				}
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000FF9C8 File Offset: 0x000FDBC8
		public void Render(Graphics g, RectangleF myrect)
		{
			this.UpdateVariables(myrect);
			g.TranslateTransform(myrect.Left, myrect.Top);
			checked
			{
				this.iOriginX = (int)Math.Round((double)(unchecked((float)this.iOriginX - myrect.Left)));
				this.iOriginY = (int)Math.Round((double)(unchecked((float)this.iOriginY - myrect.Top)));
				this.PlotGraph(g);
				g.ResetTransform();
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000FFA38 File Offset: 0x000FDC38
		private void UpdateVariables(RectangleF myrectf)
		{
			checked
			{
				this.iLengthScale = (int)Math.Round((double)myrectf.Width / 2.25);
				this.iOriginX = (int)Math.Round((double)(unchecked(myrectf.Left + myrectf.Width / 2f)));
				this.iOriginY = (int)Math.Round((double)(unchecked(myrectf.Top + myrectf.Height / 2f)));
				if (this.bGrids)
				{
					this.iLengthBox = this.iLengthScale;
				}
				else
				{
					this.iLengthBox = (int)Math.Round(unchecked((double)this.iLengthScale * 0.025));
				}
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000FFADC File Offset: 0x000FDCDC
		private void UpdateVariables(float mywidth, float myheight)
		{
			checked
			{
				this.iLengthScale = (int)Math.Round((double)myheight / 2.25);
				this.iOriginX = (int)Math.Round((double)(mywidth / 2f));
				this.iOriginY = (int)Math.Round((double)(myheight / 2f));
				if (this.bGrids)
				{
					this.iLengthBox = this.iLengthScale;
				}
				else
				{
					this.iLengthBox = (int)Math.Round(unchecked((double)this.iLengthScale * 0.025));
				}
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x000FFB60 File Offset: 0x000FDD60
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0000AAFF File Offset: 0x00008CFF
		[Description("轴座标标签字体设置")]
		public Font ScaleFont
		{
			get
			{
				return this.myscalefont;
			}
			set
			{
				if (value != null)
				{
					this.myscalefont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000FFB78 File Offset: 0x000FDD78
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0000AB15 File Offset: 0x00008D15
		[Description("表达式标签字体设置")]
		public Font ExpressionTextFont
		{
			get
			{
				return this.myexpressiontextfont;
			}
			set
			{
				if (value != null)
				{
					this.myexpressiontextfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x000FFB90 File Offset: 0x000FDD90
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0000AB2B File Offset: 0x00008D2B
		[Description("X轴等份数,指X轴单边的等份数")]
		public int DivisionsX
		{
			get
			{
				return this.iDivisionsX;
			}
			set
			{
				if (value > 0)
				{
					this.iDivisionsX = value;
				}
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x000FFBA8 File Offset: 0x000FDDA8
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0000AB38 File Offset: 0x00008D38
		[Description("Y轴等份数,指Y轴单边的等份数")]
		public int DivisionsY
		{
			get
			{
				return this.iDivisionsY;
			}
			set
			{
				if (value > 0)
				{
					this.iDivisionsY = value;
				}
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x000FFBC0 File Offset: 0x000FDDC0
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000AB45 File Offset: 0x00008D45
		[Description("指定X轴单方向座标大小")]
		public double ScaleX
		{
			get
			{
				return this.dScaleX;
			}
			set
			{
				if (value != 0.0)
				{
					this.dScaleX = value;
				}
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000FFBD8 File Offset: 0x000FDDD8
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x0000AB5A File Offset: 0x00008D5A
		[Description("指定Y轴单方向座标大小")]
		public double ScaleY
		{
			get
			{
				return this.dScaleY;
			}
			set
			{
				if (value != 0.0)
				{
					this.dScaleY = value;
				}
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x000FFBF0 File Offset: 0x000FDDF0
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0000AB6F File Offset: 0x00008D6F
		[Description("X轴座标圆点偏移值")]
		public double ForwardX
		{
			get
			{
				return this.dForwardX;
			}
			set
			{
				this.dForwardX = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x000FFC08 File Offset: 0x000FDE08
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Description("Y轴座标圆点偏移值")]
		public double ForwardY
		{
			get
			{
				return this.dForwardY;
			}
			set
			{
				this.dForwardY = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x000FFC20 File Offset: 0x000FDE20
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0000AB81 File Offset: 0x00008D81
		[Description("X轴标签打印步进值,必须大于0,默认为1")]
		public int PrintStepX
		{
			get
			{
				return this.iPrintStepX;
			}
			set
			{
				if (value > 0)
				{
					this.iPrintStepX = value;
				}
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000FFC38 File Offset: 0x000FDE38
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000AB8E File Offset: 0x00008D8E
		[Description("Y轴标签打印步进值,必须大于0,默认为1")]
		public int PrintStepY
		{
			get
			{
				return this.iPrintStepY;
			}
			set
			{
				if (value > 0)
				{
					this.iPrintStepY = value;
				}
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x000FFC50 File Offset: 0x000FDE50
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000AB9B File Offset: 0x00008D9B
		[Description("仅对 GraphMode为Polar(极座标)时有效,调整极坐标图形的灵敏度。取值越大，极坐标图形越精确")]
		public int PolarSensitivity
		{
			get
			{
				return this.iPolarSensitivity;
			}
			set
			{
				if (value > 0)
				{
					this.iPolarSensitivity = value;
				}
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000FFC68 File Offset: 0x000FDE68
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Description("是否显示表格线")]
		public bool Grids
		{
			get
			{
				return this.bGrids;
			}
			set
			{
				this.bGrids = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x000FFC7C File Offset: 0x000FDE7C
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0000ABB1 File Offset: 0x00008DB1
		[Description("是否显示表达式文本")]
		public bool DisplayText
		{
			get
			{
				return this.bDisplayText;
			}
			set
			{
				this.bDisplayText = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x000FFC90 File Offset: 0x000FDE90
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x0000ABBA File Offset: 0x00008DBA
		[Description("座标模式(极座标或直角坐标)")]
		public GraphMode GraphMode
		{
			get
			{
				return this.mygraphMode;
			}
			set
			{
				this.mygraphMode = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x000FFCA8 File Offset: 0x000FDEA8
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x0000ABC3 File Offset: 0x00008DC3
		[Description("绘图画笔宽度")]
		public int PenWidth
		{
			get
			{
				return this.iPenWidth;
			}
			set
			{
				this.iPenWidth = value;
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x000FFCC0 File Offset: 0x000FDEC0
		private void PlotGraph(Graphics g)
		{
			this.DisplayScale(g);
			if (this.bDisplayText)
			{
				this.DisplayExpressionsText(g);
			}
			float x = 0f;
			float y = 0f;
			bool flag = false;
			double num = this.dScaleX / (double)this.iLengthScale;
			double num2 = this.dScaleY / (double)this.iLengthScale;
			double num3;
			double num4;
			double num5;
			if (this.GraphMode == GraphMode.Polar)
			{
				num3 = -3.1415926535897931;
				num4 = 3.1415926535897931;
				num5 = this.dScaleX / (double)this.iPolarSensitivity;
			}
			else
			{
				num5 = num;
				num3 = -this.dScaleX + this.dForwardX;
				num4 = this.dScaleX + this.dForwardX;
			}
			int num6 = 0;
			checked
			{
				int num7 = this.expressions.Count - 1;
				for (int i = num6; i <= num7; i++)
				{
					unchecked
					{
						if (this.expressions[i].IsValid)
						{
							flag = false;
							for (double num8 = num3; num8 != num4; num8 += num5)
							{
								if (this.dScaleX < 0.0 && num8 < num4)
								{
									break;
								}
								if (this.dScaleX > 0.0)
								{
									if (num8 > num4)
									{
										break;
									}
								}
								try
								{
									double num9 = this.expressions[i].Evaluate(num8);
									if (double.IsNaN(num9))
									{
										flag = false;
									}
									else
									{
										double num10;
										double num11;
										if (this.GraphMode == GraphMode.Polar)
										{
											num10 = num9 * Math.Cos(num8) / num;
											num11 = num9 * Math.Sin(num8) / num2;
										}
										else
										{
											num10 = num8 / num;
											num11 = num9 / num2;
										}
										if ((double)this.iOriginY - num11 + this.dForwardY / num2 >= (double)(checked(this.iOriginY - this.iLengthScale)) && (double)this.iOriginY - num11 + this.dForwardY / num2 <= (double)(checked(this.iOriginY + this.iLengthScale)) && (double)this.iOriginX + num10 - this.dForwardX / num >= (double)(checked(this.iOriginX - this.iLengthScale)) && (double)this.iOriginX + num10 - this.dForwardX / num <= (double)(checked(this.iOriginX + this.iLengthScale)))
										{
											float num12 = (float)((double)this.iOriginX + num10 - this.dForwardX / num);
											float num13 = (float)((double)this.iOriginY - num11 + this.dForwardY / num2);
											if (!flag)
											{
												x = num12;
												y = num13;
												flag = true;
											}
											Pen pen = new Pen(this.expColors[i], (float)this.iPenWidth);
											PointF pointF = new PointF(x, y);
											PointF pt = pointF;
											PointF pt2 = new PointF(num12, num13);
											g.DrawLine(pen, pt, pt2);
											x = num12;
											y = num13;
										}
										else
										{
											flag = false;
										}
									}
									goto IL_29F;
								}
								catch (Exception ex)
								{
									flag = false;
									goto IL_29F;
								}
								break;
								IL_29F:;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000FFF94 File Offset: 0x000FE194
		private void DisplayScale(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 1f);
			checked
			{
				Point point = new Point(this.iOriginX - this.iLengthScale, this.iOriginY);
				Point pt = point;
				Point point2 = new Point(this.iOriginX + this.iLengthScale, this.iOriginY);
				g.DrawLine(pen, pt, point2);
				Pen pen2 = new Pen(Color.Black, 1f);
				point2 = new Point(this.iOriginX, this.iOriginY - this.iLengthScale);
				Point pt2 = point2;
				point = new Point(this.iOriginX, this.iOriginY + this.iLengthScale);
				g.DrawLine(pen2, pt2, point);
				double num = unchecked(-this.dScaleX + this.dForwardX);
				for (int i = 0 - this.iDivisionsX; i <= this.iDivisionsX; i++)
				{
					Pen pen3 = new Pen(Color.Gray, 1f);
					PointF pointF = new PointF((float)(unchecked((double)this.iOriginX + (num - this.dForwardX) * (double)this.iLengthScale / this.dScaleX)), (float)(this.iOriginY - this.iLengthBox));
					PointF pt3 = pointF;
					PointF pointF2 = new PointF((float)(unchecked((double)this.iOriginX + (num - this.dForwardX) * (double)this.iLengthScale / this.dScaleX)), (float)(this.iOriginY + this.iLengthBox));
					g.DrawLine(pen3, pt3, pointF2);
					if (i % this.iPrintStepX == 0 && i != 0)
					{
						string text = Math.Round(num, 3).ToString();
						float x = (float)(unchecked((double)this.iOriginX + (num - this.dForwardX) * (double)this.iLengthScale / this.dScaleX - 6.0 - (double)(checked((text.Length - 2) * 5))));
						float num2 = (float)(this.iOriginY + 10);
						g.DrawString(text, this.ScaleFont, new SolidBrush(Color.Black), x, num2);
					}
					unchecked
					{
						num += this.dScaleX / (double)this.iDivisionsX;
					}
				}
				num = unchecked(-this.dScaleY + this.dForwardY);
				for (int i = 0 - this.iDivisionsY; i <= this.iDivisionsY; i++)
				{
					Pen pen4 = new Pen(Color.Gray, 1f);
					PointF pointF2 = new PointF((float)(this.iOriginX - this.iLengthBox), (float)(unchecked((double)this.iOriginY + (num - this.dForwardY) * (double)this.iLengthScale / this.dScaleY)));
					PointF pt4 = pointF2;
					PointF pointF = new PointF((float)(this.iOriginX + this.iLengthBox), (float)(unchecked((double)this.iOriginY + (num - this.dForwardY) * (double)this.iLengthScale / this.dScaleY)));
					g.DrawLine(pen4, pt4, pointF);
					unchecked
					{
						if (i % this.iPrintStepY == 0 && i != 0)
						{
							string text = Math.Round(num, 3).ToString();
							float x = (float)(checked(this.iOriginX - 20 - text.Length * 4));
							float num2 = (float)((double)this.iOriginY - (num - this.dForwardY) * (double)this.iLengthScale / this.dScaleY - 7.0);
							if (this.iLengthBox == this.iLengthScale)
							{
								num2 += 6f;
							}
							g.DrawString(text, this.ScaleFont, new SolidBrush(Color.Black), x, num2);
						}
						num += this.dScaleY / (double)this.iDivisionsY;
					}
				}
			}
			if (this.GraphMode == GraphMode.Polar)
			{
				g.DrawEllipse(new Pen(Color.Black, 1f), (float)(checked(this.iOriginX - this.iLengthScale)), (float)this.iOriginY - (float)((double)this.iLengthScale * this.dScaleX / this.dScaleY), (float)(checked(this.iLengthScale * 2)), (float)((double)this.iLengthScale * this.dScaleX / this.dScaleY) * 2f);
				for (double num = 0.0; num <= 6.2831853071795862; num += 0.52359877559829882)
				{
					Pen pen5 = new Pen(Color.Gray, 1f);
					Point point2 = new Point(this.iOriginX, this.iOriginY);
					PointF pt5 = point2;
					PointF pointF2 = new PointF((float)((double)this.iOriginX + (double)this.iLengthScale * Math.Cos(num)), (float)((double)this.iOriginY + (double)this.iLengthScale * Math.Sin(num)));
					g.DrawLine(pen5, pt5, pointF2);
				}
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x001003D0 File Offset: 0x000FE5D0
		private void DisplayExpressionsText(Graphics g)
		{
			float num = 10f;
			int num2 = 0;
			checked
			{
				int num3 = this.expressions.Count - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (this.expressions[i].IsValid)
					{
						g.DrawString(this.expressions[i].ExpressionText, this.ExpressionTextFont, new SolidBrush(this.expColors[i]), 10f, num);
					}
					else
					{
						g.DrawString("错误: " + this.expressions[i].ExpressionText, this.ExpressionTextFont, new SolidBrush(this.expColors[i]), 10f, num);
					}
					unchecked
					{
						num += g.MeasureString(this.expressions[i].ExpressionText, this.ExpressionTextFont).Height;
					}
				}
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x001004B4 File Offset: 0x000FE6B4
		public void AddExpression(string myexpression, Color color)
		{
			ExpressionDrawer.Expression item = new ExpressionDrawer.Expression(myexpression);
			this.expressions.Add(item);
			this.expColors.Add(color);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x001004E4 File Offset: 0x000FE6E4
		public bool RemoveExpression(string myexpression)
		{
			bool flag = false;
			int num = 0;
			bool result=false;
			checked
			{
				int num2 = this.expressions.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(this.expressions[i].ExpressionText, myexpression, false) == 0)
					{
						flag = true;
					
						
						if (flag)
						{
							this.expressions.RemoveAt(i);
							this.expColors.RemoveAt(i);
							result = true;
						}
						else
						{
							result = false;
						}
}
}
				return result;
			}
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public void RemoveAllExpressions()
		{
			this.expressions.Clear();
			this.expColors.Clear();
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00100550 File Offset: 0x000FE750
		public void RemoveExpressionAt(int index)
		{
			try
			{
				this.expressions.RemoveAt(index);
				this.expColors.RemoveAt(index);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00100598 File Offset: 0x000FE798
		public string GetExpression(int index)
		{
			string result;
			if (index < 0 | index >= this.expressions.Count)
			{
				result = "";
			}
			else
			{
				result = this.expressions[index].ExpressionText;
			}
			return result;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x001005D8 File Offset: 0x000FE7D8
		public Color GetExpressionColor(int index)
		{
			Color result=new Color();
			if (index < 0 | index >= this.expColors.Count)
			{
				Color color=new Color();
				result = color;
			}
			else
			{
				result = this.expColors[index];
			}
			return result;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00100610 File Offset: 0x000FE810
		public void SetExpression(int index, string myexpression)
		{
			if (!(index >= this.expressions.Count | index < 0))
			{
				ExpressionDrawer.Expression value = new ExpressionDrawer.Expression(myexpression);
				this.expressions[index] = value;
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0010064C File Offset: 0x000FE84C
		public void SetExpressionColor(int index, Color color)
		{
			if (!(index >= this.expColors.Count | index < 0))
			{
				this.expColors[index] = color;
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public void SetRangeX(double startX, double endX)
		{
			this.dScaleX = (endX - startX) / 2.0;
			this.dForwardX = (endX + startX) / 2.0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0000AC0C File Offset: 0x00008E0C
		public void SetRangeY(double startY, double endY)
		{
			this.dScaleY = (endY - startY) / 2.0;
			this.dForwardY = (endY + startY) / 2.0;
		}

		// Token: 0x0400108D RID: 4237
		private IContainer components;

		// Token: 0x0400108E RID: 4238
		private bool bDisplayText;

		// Token: 0x0400108F RID: 4239
		private bool bGrids;

		// Token: 0x04001090 RID: 4240
		private double dForwardX;

		// Token: 0x04001091 RID: 4241
		private double dForwardY;

		// Token: 0x04001092 RID: 4242
		private double dScaleX;

		// Token: 0x04001093 RID: 4243
		private double dScaleY;

		// Token: 0x04001094 RID: 4244
		private List<Color> expColors;

		// Token: 0x04001095 RID: 4245
		private List<ExpressionDrawer.Expression> expressions;

		// Token: 0x04001096 RID: 4246
		private GraphMode mygraphMode;

		// Token: 0x04001097 RID: 4247
		private int iDivisionsX;

		// Token: 0x04001098 RID: 4248
		private int iDivisionsY;

		// Token: 0x04001099 RID: 4249
		private int iLengthBox;

		// Token: 0x0400109A RID: 4250
		private int iLengthScale;

		// Token: 0x0400109B RID: 4251
		private int iOriginX;

		// Token: 0x0400109C RID: 4252
		private int iOriginY;

		// Token: 0x0400109D RID: 4253
		private int iPenWidth;

		// Token: 0x0400109E RID: 4254
		private int iPolarSensitivity;

		// Token: 0x0400109F RID: 4255
		private int iPrintStepX;

		// Token: 0x040010A0 RID: 4256
		private int iPrintStepY;

		// Token: 0x040010A1 RID: 4257
		private Font myscalefont;

		// Token: 0x040010A2 RID: 4258
		private Font myexpressiontextfont;

		// Token: 0x040010A3 RID: 4259
		private string Separator1;

		// Token: 0x040010A4 RID: 4260
		private string Separator;

		// Token: 0x0200016B RID: 363
		private class Expression : IEvaluatable
		{
			// Token: 0x06001EDB RID: 7899 RVA: 0x00100680 File Offset: 0x000FE880
			public Expression(string expressionText)
			{
				this.text = "";
				this.textInternal = "";
				this.myisValid = false;
				this.charX = 'x';
				this.constants = new Dictionary<string, double>();
				this.constants.Add("pi", 3.1415926535897931);
				this.constants.Add("e", 2.7182818284590451);
				this.ExpressionText = expressionText;
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06001EDC RID: 7900 RVA: 0x001006FC File Offset: 0x000FE8FC
			// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0000AC34 File Offset: 0x00008E34
			public string ExpressionText
			{
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
					this.textInternal = "(" + value + ")";
					this.textInternal = this.InsertPrecedenceBrackets().Trim();
					this.Validate();
				}
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00100714 File Offset: 0x000FE914
			public bool IsValid
			{
				get
				{
					return this.myisValid;
				}
			}

			// Token: 0x06001EDF RID: 7903 RVA: 0x00100728 File Offset: 0x000FE928
			public double Evaluate(double dvalueX)
			{
				double result=0;
				if (!this.myisValid)
				{
					result = double.NaN;
				}
				else
				{
					int num=0;
					result = this.EvaluateInternal(dvalueX, 0, ref num);
				}
				return result;
			}

			// Token: 0x06001EE0 RID: 7904 RVA: 0x00100758 File Offset: 0x000FE958
			private void Validate()
			{
				try
				{
					int num=0;
					this.EvaluateInternal(1.0, 0, ref num);
					this.myisValid = true;
				}
				catch (System.FormatException ex)
				{
					this.myisValid = false;
				}
				catch (KeyNotFoundException ex2)
				{
					this.myisValid = false;
				}
			}

			// Token: 0x06001EE1 RID: 7905 RVA: 0x001007C8 File Offset: 0x000FE9C8
			private static bool IsOperator(char character)
			{
				if (character != '+')
				{
					if (character != '-')
					{
						if (character != '*')
						{
							if (character != '/')
							{
								if (character != '^')
								{
									if (character != '%')
									{
										return false;
									}
								}
							}
						}
					}
				}
				return true;
			}

			// Token: 0x06001EE2 RID: 7906 RVA: 0x00100800 File Offset: 0x000FEA00
			public double EvaluateInternal(double dvalueX, int startIndex, ref int endIndex)
			{
				double num = 0.0;
				double num2 = 0.0;
				char chOperator = '+';
				checked
				{
					int num3 = startIndex + 1;
					int num4 = this.textInternal.Length - 1;
					int i = num3;
					while (i <= num4)
					{
						startIndex = i;
						char c = this.textInternal[startIndex];
						if (char.IsDigit(c))
						{
							while (char.IsDigit(this.textInternal[i]) || this.textInternal[i] == '.')
							{
								i++;
							}
							num2 = Convert.ToDouble(this.textInternal.Substring(startIndex, i - startIndex));
							i--;
						}
						else if (ExpressionDrawer.Expression.IsOperator(c))
						{
							num = ExpressionDrawer.Expression.DoOperation(num, num2, chOperator);
							chOperator = c;
						}
						else if (char.ToLower(c) == this.charX)
						{
							num2 = dvalueX;
						}
						else if (c == '(')
						{
							num2 = this.EvaluateInternal(dvalueX, i, ref endIndex);
							i = endIndex;
						}
						else
						{
							if (c == ')')
							{
								num = ExpressionDrawer.Expression.DoOperation(num, num2, chOperator);
								endIndex = i;
								return num;
							}
							while (char.IsLetter(this.textInternal[i]))
							{
								i++;
							}
							if (this.textInternal[i] == '(')
							{
								string strOperator = this.textInternal.Substring(startIndex, i - startIndex).ToLower();
								num2 = this.EvaluateInternal(dvalueX, i, ref endIndex);
								i = endIndex;
								num2 = ExpressionDrawer.Expression.DoAngleOperation(num2, strOperator);
							}
							else
							{
								num2 = this.constants[this.textInternal.Substring(startIndex, i - startIndex).ToLower()];
								i--;
							}
						}
						if (!double.IsNaN(num) && !double.IsNaN(num2))
						{
							i++;
							continue;
						}
						endIndex = i;
						return double.NaN;
					}
					endIndex = this.textInternal.Length;
					return 0.0;
				}
			}

			// Token: 0x06001EE3 RID: 7907 RVA: 0x001009D0 File Offset: 0x000FEBD0
			private static double DoAngleOperation(double dOperand, string strOperator)
			{
				strOperator = strOperator.ToLower();
				string left = strOperator;
				double result;
				if (String.Compare(left, "abs", false) == 0)
				{
					result = Math.Abs(dOperand);
				}
				else if (String.Compare(left, "sin", false) == 0)
				{
					result = Math.Sin(dOperand);
				}
				else if (String.Compare(left, "cos", false) == 0)
				{
					result = Math.Cos(dOperand);
				}
				else if (String.Compare(left, "tan", false) == 0)
				{
					result = Math.Tan(dOperand);
				}
				else if (String.Compare(left, "sec", false) == 0)
				{
					result = 1.0 / Math.Cos(dOperand);
				}
				else if (String.Compare(left, "cosec", false) == 0)
				{
					result = 1.0 / Math.Sin(dOperand);
				}
				else if (String.Compare(left, "cot", false) == 0)
				{
					result = 1.0 / Math.Tan(dOperand);
				}
				else if (String.Compare(left, "arcsin", false) == 0)
				{
					result = Math.Asin(dOperand);
				}
				else if (String.Compare(left, "arccos", false) == 0)
				{
					result = Math.Acos(dOperand);
				}
				else if (String.Compare(left, "arctan", false) == 0)
				{
					result = Math.Atan(dOperand);
				}
				else if (String.Compare(left, "exp", false) == 0)
				{
					result = Math.Exp(dOperand);
				}
				else if (String.Compare(left, "ln", false) == 0)
				{
					result = Math.Log(dOperand);
				}
				else if (String.Compare(left, "log", false) == 0)
				{
					result = Math.Log10(dOperand);
				}
				else if (String.Compare(left, "antilog", false) == 0)
				{
					result = Math.Pow(10.0, dOperand);
				}
				else if (String.Compare(left, "sqrt", false) == 0)
				{
					result = Math.Sqrt(dOperand);
				}
				else if (String.Compare(left, "sinh", false) == 0)
				{
					result = Math.Sinh(dOperand);
				}
				else if (String.Compare(left, "cosh", false) == 0)
				{
					result = Math.Cosh(dOperand);
				}
				else if (String.Compare(left, "tanh", false) == 0)
				{
					result = Math.Tanh(dOperand);
				}
				else if (String.Compare(left, "arcsinh", false) == 0)
				{
					result = Math.Log(dOperand + Math.Sqrt(dOperand * dOperand + 1.0));
				}
				else if (String.Compare(left, "arccosh", false) == 0)
				{
					result = Math.Log(dOperand + Math.Sqrt(dOperand * dOperand - 1.0));
				}
				else if (String.Compare(left, "arctanh", false) == 0)
				{
					result = Math.Log((1.0 + dOperand) / (1.0 - dOperand)) / 2.0;
				}
				else
				{
					result = double.NaN;
				}
				return result;
			}

			// Token: 0x06001EE4 RID: 7908 RVA: 0x00100C90 File Offset: 0x000FEE90
			private static double DoOperation(double dOperand1, double dOperand2, char chOperator)
			{
				double result;
				if (chOperator == '*')
				{
					result = dOperand1 * dOperand2;
				}
				else if (chOperator == '+')
				{
					result = dOperand1 + dOperand2;
				}
				else if (chOperator == '-')
				{
					result = dOperand1 - dOperand2;
				}
				else if (chOperator == '/')
				{
					result = dOperand1 / dOperand2;
				}
				else if (chOperator == '^')
				{
					result = Math.Pow(dOperand1, dOperand2);
				}
				else if (chOperator == '%')
				{
					result = dOperand1 % dOperand2;
				}
				else
				{
					result = double.NaN;
				}
				return result;
			}

			// Token: 0x06001EE5 RID: 7909 RVA: 0x00100CF0 File Offset: 0x000FEEF0
			private string InsertPrecedenceBrackets()
			{
				int num = 0;
				bool flag = false;
				string text = this.textInternal;
				int i = 1;
				int length = text.Length;
				checked
				{
					while (i <= length)
					{
						if (String.Compare(text.Substring(-1 + i, 1), "*", false) == 0 || String.Compare(text.Substring(-1 + i, 1), "/", false) == 0)
						{
							int j = i - 1;
							while (j > 0)
							{
								if (String.Compare(text.Substring(-1 + j, 1), ")", false) == 0)
								{
									num++;
								}
								if (String.Compare(text.Substring(-1 + j, 1), "(", false) == 0)
								{
									num--;
								}
								if (num >= 0)
								{
									if (num == 0)
									{
										if (String.Compare(text.Substring(-1 + j, 1), "+", false) != 0)
										{
											if (String.Compare(text.Substring(-1 + j, 1), "-", false) != 0)
											{
												goto IL_DB;
											}
										}
										text = text.Substring(0, j) + "(" + text.Substring(-1 + j + 1);
										flag = true;
										i++;
										break;
									}
									IL_DB:
									j--;
									continue;
								}
								IL_10F:
								num = 0;
								j = i;
								i++;
								while (flag)
								{
									j++;
									if (String.Compare(text.Substring(-1 + j, 1), "(", false) == 0)
									{
										num++;
									}
									if (String.Compare(text.Substring(-1 + j, 1), ")", false) == 0)
									{
										if (num == 0)
										{
											text = text.Substring(0, j - 1) + ")" + text.Substring(-1 + j);
											flag = false;
											i++;
											break;
										}
										num--;
									}
									if (String.Compare(text.Substring(-1 + j, 1), "+", false) != 0)
									{
										if (String.Compare(text.Substring(-1 + j, 1), "-", false) != 0)
										{
											continue;
										}
									}
									text = text.Substring(0, j - 1) + ")" + text.Substring(-1 + j);
									flag = false;
									i++;
									break;
								}
								goto IL_1EC;
							}
							
						}
						IL_1EC:
						length = text.Length;
						i++;
					}
					i = 1;
					length = text.Length;
					while (i <= length)
					{
						if (String.Compare(text.Substring(-1 + i, 1), "^", false) == 0 || String.Compare(text.Substring(-1 + i, 1), "%", false) == 0)
						{
							int j = i - 1;
							while (j > 0)
							{
								if (String.Compare(text.Substring(-1 + j, 1), ")", false) == 0)
								{
									num++;
								}
								if (String.Compare(text.Substring(-1 + j, 1), "(", false) == 0)
								{
									num--;
								}
								if (num >= 0)
								{
									if (num == 0)
									{
										if (String.Compare(text.Substring(-1 + j, 1), "+", false) != 0)
										{
											if (String.Compare(text.Substring(-1 + j, 1), "-", false) != 0)
											{
												if (String.Compare(text.Substring(-1 + j, 1), "*", false) != 0)
												{
													if (String.Compare(text.Substring(-1 + j, 1), "/", false) != 0)
													{
														goto IL_304;
													}
												}
											}
										}
										text = text.Substring(0, j) + "(" + text.Substring(-1 + j + 1);
										flag = true;
										i++;
										break;
									}
									IL_304:
									j--;
									continue;
								}
								IL_338:
								num = 0;
								j = i;
								i++;
								while (flag)
								{
									j++;
									if (String.Compare(text.Substring(-1 + j, 1), "(", false) == 0)
									{
										num++;
									}
									if (String.Compare(text.Substring(-1 + j, 1), ")", false) == 0)
									{
										if (num == 0)
										{
											text = text.Substring(0, j - 1) + ")" + text.Substring(-1 + j);
											flag = false;
											i++;
											break;
										}
										num--;
									}
									if (String.Compare(text.Substring(-1 + j, 1), "+", false) != 0)
									{
										if (String.Compare(text.Substring(-1 + j, 1), "-", false) != 0)
										{
											if (String.Compare(text.Substring(-1 + j, 1), "*", false) != 0)
											{
												if (String.Compare(text.Substring(-1 + j, 1), "/", false) != 0)
												{
													continue;
												}
											}
										}
									}
									text = text.Substring(0, j - 1) + ")" + text.Substring(-1 + j);
									flag = false;
									i++;
									break;
								}
								goto IL_454;
							}
							
						}
						IL_454:
						length = text.Length;
						i++;
					}
					return text;
				}
			}

			// Token: 0x06001EE6 RID: 7910 RVA: 0x0010116C File Offset: 0x000FF36C
			private static double GetR(double X, double Y)
			{
				return Math.Sqrt(X * X + Y * Y);
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x00101188 File Offset: 0x000FF388
			private static double GetTheta(double X, double Y)
			{
				double num;
				if (X == 0.0)
				{
					if (Y > 0.0)
					{
						num = 1.5707963267948966;
					}
					else
					{
						num = -1.5707963267948966;
					}
				}
				else
				{
					num = Math.Atan(Y / X);
				}
				if (X < 0.0)
				{
					num += 3.1415926535897931;
				}
				else if (Y < 0.0)
				{
					num += 6.2831853071795862;
				}
				return num;
			}

			// Token: 0x040010A5 RID: 4261
			private string text;

			// Token: 0x040010A6 RID: 4262
			private string textInternal;

			// Token: 0x040010A7 RID: 4263
			private bool myisValid;

			// Token: 0x040010A8 RID: 4264
			private char charX;

			// Token: 0x040010A9 RID: 4265
			private Dictionary<string, double> constants;
		}
	}
}
