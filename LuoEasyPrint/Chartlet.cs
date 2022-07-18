using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000145 RID: 325
	[Description("在开源的Chartlet图表组件上进行更改以适合在VB2008Print组件中打印图表的图表组件")]
	[ToolboxBitmap(typeof(Chartlet), "Chartlet.bmp")]
	public class Chartlet : Component
	{
		// Token: 0x06001D53 RID: 7507 RVA: 0x000EBA04 File Offset: 0x000E9C04
		public Chartlet()
		{
			this.myIsRightAngle = false;
			this.dx = 0;
			this.dy = 0;
			this._Width = 600;
			this._Height = 400;
			this._ChartType = Chartlet.ChartTypes.Bar;
			this._MutipleBars = 0;
			this._MaxValueY = 0.0;
			this._BaseLineX = -0.830213;
			this._MinValueY = 0.0;
			this._RoundRectangle = false;
			this._RoundRadius = 2;
			this._LineConnectionType = Chartlet.LineConnectionTypes.Round;
			this._LineConnectionRadius = 10;
			this._AppearanceStyle = Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_NoBorder;
			this._Dimension = Chartlet.ChartDimensions.Chart2D;
			this._Depth3D = 10;
			this._Alpha3D = byte.MaxValue;
			this._AutoBarWidth = true;
			this._Colorful = true;
			this._ShowErrorInfo = true;
			this._ShowCopyright = false;
			this._CopyrightText = "Provided by Chartlet.cn";
			this._InflateRight = 0;
			this._InflateBottom = 0;
			this._InflateTop = 0;
			this._InflateLeft = 0;
			this.MaxData = 100f;
			this.MinData = 0f;
			this.BaseLineXInt = 0f;
			this.MinCount = 0;
			this.MaxCount = 0;
			this.DataBound = false;
			this.InitializeDataString = "";
			this.Separator1 = "\a\u0001";
			this.Separator2 = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(2));
			this.Separator3 = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(3));
			this.Separator = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(4));
			this.BarBrushColor = new Color[]
			{
				Color.FromArgb(255, 214, 166, 231),
				Color.FromArgb(255, 127, 184, 210),
				Color.FromArgb(255, 231, 216, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 181, 231, 166),
				Color.FromArgb(255, 231, 166, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 198, 231, 166),
				Color.FromArgb(255, 231, 166, 226),
				Color.FromArgb(255, 205, 181, 157),
				Color.FromArgb(255, 157, 205, 200),
				Color.FromArgb(255, 222, 222, 222)
			};
			this.BarPenColor = new Color[]
			{
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136)
			};
			this.Breeze = new Color[]
			{
				Color.FromArgb(255, 214, 166, 231),
				Color.FromArgb(255, 127, 184, 210),
				Color.FromArgb(255, 231, 216, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 181, 231, 166),
				Color.FromArgb(255, 231, 166, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 198, 231, 166),
				Color.FromArgb(255, 231, 166, 226),
				Color.FromArgb(255, 205, 181, 157),
				Color.FromArgb(255, 157, 205, 200),
				Color.FromArgb(255, 222, 222, 222)
			};
			this.Aurora = new Color[]
			{
				Color.FromArgb(255, 25, 202, 45),
				Color.FromArgb(255, 244, 32, 32),
				Color.FromArgb(255, 37, 32, 242),
				Color.FromArgb(255, 240, 32, 242),
				Color.FromArgb(255, 240, 242, 32),
				Color.FromArgb(255, 32, 242, 235),
				Color.FromArgb(255, 242, 151, 32),
				Color.FromArgb(255, 146, 242, 32),
				Color.FromArgb(255, 146, 32, 242),
				Color.FromArgb(255, 32, 131, 242),
				Color.FromArgb(255, 242, 101, 32),
				Color.FromArgb(255, 22, 153, 245)
			};
			this.StarryNight = new Color[]
			{
				Color.FromArgb(255, 87, 14, 78),
				Color.FromArgb(255, 87, 55, 14),
				Color.FromArgb(255, 14, 60, 87),
				Color.FromArgb(255, 87, 35, 14),
				Color.FromArgb(255, 41, 87, 14),
				Color.FromArgb(255, 60, 14, 87),
				Color.FromArgb(255, 87, 14, 14),
				Color.FromArgb(255, 43, 14, 87),
				Color.FromArgb(255, 14, 86, 87),
				Color.FromArgb(255, 62, 87, 14),
				Color.FromArgb(255, 61, 3, 56),
				Color.FromArgb(255, 3, 33, 61)
			};
			this.StrBarL = "";
			this.StrBarW = "";
			this.StrBarT = "";
			this.StrBarH = "";
			this.StrBarV = "";
			this.Width = 600;
			this.Height = 400;
			this.Breeze.CopyTo(this.BarBrushColor, 0);
			this.ChartTitle.Text = "Chartlet图表";
			this.ChartTitle.Font = new Font("Arial", 16f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.ChartTitle.ForeColor = Color.DarkBlue;
			this.XLabels.UnitText = "XLabelsUnit";
			this.BaseLineX = 0.0;
			this.YLabels.UnitText = "YLabelsUnit";
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000EC4B8 File Offset: 0x000EA6B8
		public Chartlet(int width, int height)
		{
			this.myIsRightAngle = false;
			this.dx = 0;
			this.dy = 0;
			this._Width = 600;
			this._Height = 400;
			this._ChartType = Chartlet.ChartTypes.Bar;
			this._MutipleBars = 0;
			this._MaxValueY = 0.0;
			this._BaseLineX = -0.830213;
			this._MinValueY = 0.0;
			this._RoundRectangle = false;
			this._RoundRadius = 2;
			this._LineConnectionType = Chartlet.LineConnectionTypes.Round;
			this._LineConnectionRadius = 10;
			this._AppearanceStyle = Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_NoBorder;
			this._Dimension = Chartlet.ChartDimensions.Chart2D;
			this._Depth3D = 10;
			this._Alpha3D = byte.MaxValue;
			this._AutoBarWidth = true;
			this._Colorful = true;
			this._ShowErrorInfo = true;
			this._ShowCopyright = false;
			this._CopyrightText = "Provided by Chartlet.cn";
			this._InflateRight = 0;
			this._InflateBottom = 0;
			this._InflateTop = 0;
			this._InflateLeft = 0;
			this.MaxData = 100f;
			this.MinData = 0f;
			this.BaseLineXInt = 0f;
			this.MinCount = 0;
			this.MaxCount = 0;
			this.DataBound = false;
			this.InitializeDataString = "";
			this.Separator1 = "\a\u0001";
			this.Separator2 = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(2));
			this.Separator3 = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(3));
			this.Separator = Convert.ToString(Convert.ToChar(7)) + Convert.ToString(Convert.ToChar(4));
			this.BarBrushColor = new Color[]
			{
				Color.FromArgb(255, 214, 166, 231),
				Color.FromArgb(255, 127, 184, 210),
				Color.FromArgb(255, 231, 216, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 181, 231, 166),
				Color.FromArgb(255, 231, 166, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 198, 231, 166),
				Color.FromArgb(255, 231, 166, 226),
				Color.FromArgb(255, 205, 181, 157),
				Color.FromArgb(255, 157, 205, 200),
				Color.FromArgb(255, 222, 222, 222)
			};
			this.BarPenColor = new Color[]
			{
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136),
				Color.FromArgb(255, 120, 135, 136)
			};
			this.Breeze = new Color[]
			{
				Color.FromArgb(255, 214, 166, 231),
				Color.FromArgb(255, 127, 184, 210),
				Color.FromArgb(255, 231, 216, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 181, 231, 166),
				Color.FromArgb(255, 231, 166, 166),
				Color.FromArgb(255, 180, 166, 231),
				Color.FromArgb(255, 198, 231, 166),
				Color.FromArgb(255, 231, 166, 226),
				Color.FromArgb(255, 205, 181, 157),
				Color.FromArgb(255, 157, 205, 200),
				Color.FromArgb(255, 222, 222, 222)
			};
			this.Aurora = new Color[]
			{
				Color.FromArgb(255, 25, 202, 45),
				Color.FromArgb(255, 244, 32, 32),
				Color.FromArgb(255, 37, 32, 242),
				Color.FromArgb(255, 240, 32, 242),
				Color.FromArgb(255, 240, 242, 32),
				Color.FromArgb(255, 32, 242, 235),
				Color.FromArgb(255, 242, 151, 32),
				Color.FromArgb(255, 146, 242, 32),
				Color.FromArgb(255, 146, 32, 242),
				Color.FromArgb(255, 32, 131, 242),
				Color.FromArgb(255, 242, 101, 32),
				Color.FromArgb(255, 22, 153, 245)
			};
			this.StarryNight = new Color[]
			{
				Color.FromArgb(255, 87, 14, 78),
				Color.FromArgb(255, 87, 55, 14),
				Color.FromArgb(255, 14, 60, 87),
				Color.FromArgb(255, 87, 35, 14),
				Color.FromArgb(255, 41, 87, 14),
				Color.FromArgb(255, 60, 14, 87),
				Color.FromArgb(255, 87, 14, 14),
				Color.FromArgb(255, 43, 14, 87),
				Color.FromArgb(255, 14, 86, 87),
				Color.FromArgb(255, 62, 87, 14),
				Color.FromArgb(255, 61, 3, 56),
				Color.FromArgb(255, 3, 33, 61)
			};
			this.StrBarL = "";
			this.StrBarW = "";
			this.StrBarT = "";
			this.StrBarH = "";
			this.StrBarV = "";
			this.BaseLineX = 0.0;
			this.Width = width;
			this.Height = height;
			this.Breeze.CopyTo(this.BarBrushColor, 0);
			this.ChartTitle.Text = "FanG Chartlet";
			this.ChartTitle.Font = new Font("Arial", 16f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.ChartTitle.ForeColor = Color.DarkBlue;
			this.XLabels.UnitText = "XLabelsUnit";
			this.YLabels.UnitText = "YLabelsUnit";
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000ECF64 File Offset: 0x000EB164
		public void Render(Graphics g)
		{
			Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
			this.Render(g, rect);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000ECF90 File Offset: 0x000EB190
		public void Render(Graphics g, Rectangle rect)
		{
			Matrix transform = g.Transform;
			int width = this.Width;
			int height = this.Height;
			this.Width = rect.Width;
			this.Height = rect.Height;
			checked
			{
				int num = this.Height + this.InflateBottom + this.InflateTop;
				int num2 = 60;
				int num3 = num - 60 - 40 - this.InflateBottom - this.InflateTop;
				if (!this.ChartTitle.Show)
				{
					num3 += num2 - 27;
				}
				if (this.MaxValueY != 0.0)
				{
					this.MaxData = (float)this.MaxValueY;
				}
				else
				{
					int groupSize = this.GroupSize;
					float[] array = new float[groupSize - 1 + 1];
					int num4 = 0;
					int num5 = groupSize - 1;
					for (int i = num4; i <= num5; i++)
					{
						array[i] = Chartlet.GetMax(this.RawDatas[i]);
					}
					this.MaxData = Chartlet.GetMax(array);
					this.MaxData = Chartlet.GetBond(this.MaxData);
				}
				if (this.MaxData == 0f)
				{
					this.MaxData = 1f;
				}
				int groupSize2 = this.GroupSize;
				float[] array2 = new float[groupSize2 - 1 + 1];
				int num6 = 0;
				int num7 = groupSize2 - 1;
				for (int j = num6; j <= num7; j++)
				{
					array2[j] = Chartlet.GetMin(this.RawDatas[j]);
				}
				this.MinData = Chartlet.GetMin(array2);
				this.MinData = Chartlet.GetBond(this.MinData);
				if (this.MinValueY != 0.0 || this.MinValueY < (double)this.MinData)
				{
					this.MinData = (float)this.MinValueY;
				}
				if (this.BaseLineX == -0.830213)
				{
					this.BaseLineX = (double)this.MinData;
				}
				this.BaseLineXInt = unchecked(((float)this.BaseLineX - this.MinData) * (float)num3 / (this.MaxData - this.MinData));
				if (this.RawDatas != null && this.RawDatas.Length > 0)
				{
					this.IntDatas = new float[this.RawDatas.Length - 1 + 1][];
					int num8 = 0;
					int num9 = this.RawDatas.Length - 1;
					for (int k = num8; k <= num9; k++)
					{
						this.IntDatas[k] = new float[this.RawDatas[k].Length - 1 + 1];
						int num10 = 0;
						int num11 = this.RawDatas[k].Length - 1;
						for (int l = num10; l <= num11; l++)
						{
							this.IntDatas[k][l] = unchecked((Convert.ToSingle(this.RawDatas[k][l]) - this.MinData) * (float)num3 / (this.MaxData - this.MinData));
						}
					}
				}
				if (this.MaxCount != 0 || !this.ShowErrorInfo)
				{
				}
				this.DataBound = true;
				this.ShiftColor(this.Fill.ShiftStep, "Fill");
				this.ShiftColor(this.Stroke.ShiftStep, "Stroke");
				double baseLineX = this.BaseLineX;
				this.dx = rect.Left;
				this.dy = rect.Top;
				GraphicsUnit pageUnit = g.PageUnit;
				g.TranslateTransform((float)rect.Left, (float)rect.Top);
				switch (this.ChartType)
				{
				case Chartlet.ChartTypes.Bar:
					this.DrawBarsChart(g);
					break;
				case Chartlet.ChartTypes.Line:
					this.DrawLineChart(g);
					break;
				case Chartlet.ChartTypes.Pie:
					if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
					{
						this.DrawPieChart(g);
					}
					else
					{
						this.DrawPieChart3D(g);
					}
					break;
				case Chartlet.ChartTypes.Stack:
					this.DrawStackChart(g);
					break;
				case Chartlet.ChartTypes.HBar:
					this.DrawHBarChart(g);
					break;
				case Chartlet.ChartTypes.Trend:
					this.DrawTrendChart(g);
					break;
				default:
					this.DrawPieChart(g);
					break;
				}
				g.PageUnit = pageUnit;
				g.ResetTransform();
				g.ResetClip();
				g.Transform = transform;
				this.BaseLineX = baseLineX;
				this.Width = width;
				this.Height = height;
			}
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x000ED370 File Offset: 0x000EB570
		private static float GetMax(float[] Datas)
		{
			float num = 0f;
			int num2 = 0;
			checked
			{
				int num3 = Datas.Length - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (Datas[i] > num)
					{
						num = Datas[i];
					}
				}
				return num;
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x000ED3A4 File Offset: 0x000EB5A4
		private static float GetMax(decimal[] Datas)
		{
			float num = 0f;
			int num2 = 0;
			checked
			{
				int num3 = Datas.Length - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (Convert.ToSingle(Datas[i]) > num)
					{
						num = Convert.ToSingle(Datas[i]);
					}
				}
				return num;
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000ED3F4 File Offset: 0x000EB5F4
		private static float GetMin(float[] Datas)
		{
			checked
			{
				float result;
				if (Datas.Length <= 0)
				{
					result = 0f;
				}
				else
				{
					float num = Datas[0];
					int num2 = 0;
					int num3 = Datas.Length - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Datas[i] < num)
						{
							num = Datas[i];
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000ED434 File Offset: 0x000EB634
		private static float GetMin(decimal[] Datas)
		{
			checked
			{
				float result;
				if (Datas.Length <= 0)
				{
					result = 0f;
				}
				else
				{
					float num = Convert.ToSingle(Datas[0]);
					int num2 = 0;
					int num3 = Datas.Length - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Convert.ToSingle(Datas[i]) < num)
						{
							num = Convert.ToSingle(Datas[i]);
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000ED49C File Offset: 0x000EB69C
		private static float GetSum(float[] Datas)
		{
			float num = 0f;
			int num2 = 0;
			checked
			{
				int num3 = Datas.Length - 1;
				for (int i = num2; i <= num3; i++)
				{
					unchecked
					{
						num += Datas[i];
					}
				}
				return num;
			}
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000ED4CC File Offset: 0x000EB6CC
		private static float GetSum(decimal[] Datas)
		{
			float num = 0f;
			int num2 = 0;
			checked
			{
				int num3 = Datas.Length - 1;
				for (int i = num2; i <= num3; i++)
				{
					unchecked
					{
						num += Convert.ToSingle(Datas[i]);
					}
				}
				return num;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000ED508 File Offset: 0x000EB708
		private static float GetBond(float DataIn)
		{
			checked
			{
				int num = (int)Math.Round(Math.Truncate(Math.Floor((double)(DataIn / 10f))));
				float result;
				if (num > 0)
				{
					if (unchecked(DataIn - (float)(checked(num * 10))) > 5f)
					{
						num = (num + 1) * 10;
					}
					else if (unchecked(DataIn - (float)(checked(num * 10)) < 5f && DataIn - (float)(checked(num * 10)) > 0f))
					{
						num = num * 10 + 5;
					}
					else
					{
						num = (int)Math.Round(Math.Truncate((double)DataIn));
					}
					result = (float)num;
				}
				else
				{
					result = DataIn;
				}
				return result;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000ED584 File Offset: 0x000EB784
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000A380 File Offset: 0x00008580
		public bool IsRightAngle
		{
			get
			{
				return this.myIsRightAngle;
			}
			set
			{
				this.myIsRightAngle = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000ED598 File Offset: 0x000EB798
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0000A389 File Offset: 0x00008589
		public int Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				this._Width = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000ED5B0 File Offset: 0x000EB7B0
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0000A392 File Offset: 0x00008592
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000ED5C8 File Offset: 0x000EB7C8
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000A39B File Offset: 0x0000859B
		[Description("3D 在图形上显示Chartlet.cn")]
		[Category("Chartlet")]
		public bool ShowCopyright
		{
			get
			{
				return this._ShowCopyright;
			}
			set
			{
				this._ShowCopyright = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000ED5DC File Offset: 0x000EB7DC
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000A3A4 File Offset: 0x000085A4
		[Description("3D 在图形上显示Chartlet.cn")]
		[Category("Chartlet")]
		public string CopyrightText
		{
			get
			{
				return this._CopyrightText;
			}
			set
			{
				this._CopyrightText = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000ED5F4 File Offset: 0x000EB7F4
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000A3AD File Offset: 0x000085AD
		[Category("Chartlet")]
		[Description("设定基线值，如果数值小于基线，则图形向着Y负方向增长")]
		public double BaseLineX
		{
			get
			{
				return this._BaseLineX;
			}
			set
			{
				this._BaseLineX = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000ED60C File Offset: 0x000EB80C
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000A3B6 File Offset: 0x000085B6
		[Category("Chartlet")]
		[Description("增大背景宽度，保持图形大小不变,可以为负数(缩小)")]
		public int InflateRight
		{
			get
			{
				return this._InflateRight;
			}
			set
			{
				this._InflateRight = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000ED624 File Offset: 0x000EB824
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000A3BF File Offset: 0x000085BF
		[Category("Chartlet")]
		[Description("增大背景高度，保持图形大小不变,可以为负数(缩小)")]
		public int InflateBottom
		{
			get
			{
				return this._InflateBottom;
			}
			set
			{
				this._InflateBottom = value;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000ED63C File Offset: 0x000EB83C
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Description("增大背景高度，保持图形大小不变,可以为负数(缩小)")]
		[Category("Chartlet")]
		public int InflateTop
		{
			get
			{
				return this._InflateTop;
			}
			set
			{
				this._InflateTop = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000ED654 File Offset: 0x000EB854
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0000A3D1 File Offset: 0x000085D1
		[Description("增大背景宽度，保持图形大小不变,可以为负数(缩小)")]
		[Category("Chartlet")]
		public int InflateLeft
		{
			get
			{
				return this._InflateLeft;
			}
			set
			{
				this._InflateLeft = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x000ED66C File Offset: 0x000EB86C
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0000A3DA File Offset: 0x000085DA
		[Category("Chartlet")]
		[Description("是否显示错误信息")]
		public bool ShowErrorInfo
		{
			get
			{
				return this._ShowErrorInfo;
			}
			set
			{
				this._ShowErrorInfo = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x000ED680 File Offset: 0x000EB880
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0000A3E3 File Offset: 0x000085E3
		[Category("Chartlet")]
		[Description(" 只有一组数据的时候，是否使用多种颜色")]
		public bool Colorful
		{
			get
			{
				return this._Colorful;
			}
			set
			{
				this._Colorful = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000ED694 File Offset: 0x000EB894
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000A3EC File Offset: 0x000085EC
		[Category("Chartlet")]
		[Description("3D 自动计算柱子宽度，如果数据很少请设为false,否则柱子会很宽")]
		public bool AutoBarWidth
		{
			get
			{
				return this._AutoBarWidth;
			}
			set
			{
				this._AutoBarWidth = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000ED6A8 File Offset: 0x000EB8A8
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000A3F5 File Offset: 0x000085F5
		[Description("3D 图形的透明度，0表示完全透明，255表示完全不透明")]
		[Category("Chartlet")]
		public byte Alpha3D
		{
			get
			{
				return this._Alpha3D;
			}
			set
			{
				this._Alpha3D = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000ED6C0 File Offset: 0x000EB8C0
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000A3FE File Offset: 0x000085FE
		[Category("Chartlet")]
		[Description("3D 效果的纵向深度")]
		public int Depth3D
		{
			get
			{
				return this._Depth3D;
			}
			set
			{
				this._Depth3D = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000ED6D8 File Offset: 0x000EB8D8
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000A407 File Offset: 0x00008607
		[Category("Chartlet")]
		[Description("图形维数2D/3D")]
		public Chartlet.ChartDimensions Dimension
		{
			get
			{
				return this._Dimension;
			}
			set
			{
				this._Dimension = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000ED6F0 File Offset: 0x000EB8F0
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000A410 File Offset: 0x00008610
		[Category("Chartlet")]
		[Description("统计图的类型(如 折线图:Line)")]
		public Chartlet.ChartTypes ChartType
		{
			get
			{
				return this._ChartType;
			}
			set
			{
				this._ChartType = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000ED708 File Offset: 0x000EB908
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000A419 File Offset: 0x00008619
		[Description("柱状图中每个元素包含的柱子的数量")]
		[Category("Chartlet")]
		public int GroupSize
		{
			get
			{
				return this._MutipleBars;
			}
			set
			{
				this._MutipleBars = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000ED720 File Offset: 0x000EB920
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000A422 File Offset: 0x00008622
		[Description("自定义纵坐标的最大值，用来统一调整柱子的高度")]
		[Category("Chartlet")]
		public double MaxValueY
		{
			get
			{
				return this._MaxValueY;
			}
			set
			{
				if (value != 0.0)
				{
					this._MaxValueY = value;
				}
				else
				{
					this._MaxValueY = 0.0;
				}
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000ED738 File Offset: 0x000EB938
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000A448 File Offset: 0x00008648
		[Category("Chartlet")]
		[Description("自定义纵坐标的最小值，用来统一调整柱子的高度")]
		public double MinValueY
		{
			get
			{
				return this._MinValueY;
			}
			set
			{
				this._MinValueY = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000ED750 File Offset: 0x000EB950
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000A451 File Offset: 0x00008651
		[Description("使用圆角矩形（针对Bar-Chart）")]
		[Category("Chartlet")]
		public bool RoundRectangle
		{
			get
			{
				return this._RoundRectangle;
			}
			set
			{
				this._RoundRectangle = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000ED764 File Offset: 0x000EB964
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000A45A File Offset: 0x0000865A
		[Category("Chartlet")]
		[Description("圆角半径（针对Bar-Chart）")]
		public int RoundRadius
		{
			get
			{
				return this._RoundRadius;
			}
			set
			{
				this._RoundRadius = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000ED77C File Offset: 0x000EB97C
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000A463 File Offset: 0x00008663
		[Description("线条连接点的样式（针对 折线图）")]
		[Category("Chartlet")]
		public Chartlet.LineConnectionTypes LineConnectionType
		{
			get
			{
				return this._LineConnectionType;
			}
			set
			{
				this._LineConnectionType = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000ED794 File Offset: 0x000EB994
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000A46C File Offset: 0x0000866C
		[Description("线条连接点的半径(宽度)（针对 折线图）")]
		[Category("Chartlet")]
		public int LineConnectionRadius
		{
			get
			{
				return this._LineConnectionRadius;
			}
			set
			{
				this._LineConnectionRadius = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000ED7AC File Offset: 0x000EB9AC
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0000A475 File Offset: 0x00008675
		[Category("Chartlet")]
		[Description("图表的外观样式,这是一个图表基本样式的快捷设置\\n注意,这个属性和本控件的其他图表外观属性如ChartType等的效果是一样的,设置该属性会影响其他属性的值,如果同时进行设置,则后面设置的起作用")]
		public Chartlet.AppearanceStyles AppearanceStyle
		{
			get
			{
				return this._AppearanceStyle;
			}
			set
			{
				this._AppearanceStyle = value;
				this.SetAppearance();
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000ED7C4 File Offset: 0x000EB9C4
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0000A484 File Offset: 0x00008684
		[Description("水晶效果属性集合")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Chartlet")]
		public CrystalAttributes Crystal
		{
			get
			{
				if (this._Crystal == null)
				{
					this._Crystal = new CrystalAttributes();
				}
				return this._Crystal;
			}
			set
			{
				this._Crystal = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000ED7EC File Offset: 0x000EB9EC
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0000A48D File Offset: 0x0000868D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("颜色图例的属性集合")]
		[Category("Chartlet")]
		public Attributes ColorGuider
		{
			get
			{
				if (this._ColorGuider == null)
				{
					this._ColorGuider = new Attributes();
				}
				return this._ColorGuider;
			}
			set
			{
				this._ColorGuider = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x000ED814 File Offset: 0x000EBA14
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000A496 File Offset: 0x00008696
		[Category("Chartlet")]
		[Description("数值标签的属性集合")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Attributes Tips
		{
			get
			{
				if (this._Tips == null)
				{
					this._Tips = new Attributes();
				}
				return this._Tips;
			}
			set
			{
				this._Tips = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000ED83C File Offset: 0x000EBA3C
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000A49F File Offset: 0x0000869F
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Chartlet")]
		[Description("Y坐标属性集合")]
		public LabelsAttributes YLabels
		{
			get
			{
				if (this._YLabels == null)
				{
					this._YLabels = new LabelsAttributes();
				}
				return this._YLabels;
			}
			set
			{
				this._YLabels = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000ED864 File Offset: 0x000EBA64
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000A4A8 File Offset: 0x000086A8
		[Category("Chartlet")]
		[Description("X坐标属性集合")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public XLabelsAttributes XLabels
		{
			get
			{
				if (this._XLabels == null)
				{
					this._XLabels = new XLabelsAttributes();
				}
				return this._XLabels;
			}
			set
			{
				this._XLabels = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000ED88C File Offset: 0x000EBA8C
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000A4B1 File Offset: 0x000086B1
		[Description("Chart title\n图表标题属性集合")]
		[Category("Chartlet")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TextAttributes ChartTitle
		{
			get
			{
				if (this._ChartTitle == null)
				{
					this._ChartTitle = new TextAttributes();
				}
				return this._ChartTitle;
			}
			set
			{
				this._ChartTitle = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000ED8B4 File Offset: 0x000EBAB4
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000A4BA File Offset: 0x000086BA
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Chartlet")]
		[Description("填充属性集合")]
		public Painting Fill
		{
			get
			{
				if (this._Fill == null)
				{
					this._Fill = new Painting();
				}
				return this._Fill;
			}
			set
			{
				this._Fill = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000ED8DC File Offset: 0x000EBADC
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000A4C3 File Offset: 0x000086C3
		[Category("Chartlet")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Fill Style\n填充属性集合")]
		public StrokeStyle Stroke
		{
			get
			{
				if (this._Stroke == null)
				{
					this._Stroke = new StrokeStyle();
				}
				return this._Stroke;
			}
			set
			{
				this._Stroke = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000ED904 File Offset: 0x000EBB04
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0000A4CC File Offset: 0x000086CC
		[Description("图形背景属性集合")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Chartlet")]
		public BackgroundAttributes Background
		{
			get
			{
				if (this._Background == null)
				{
					this._Background = new BackgroundAttributes();
				}
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000ED92C File Offset: 0x000EBB2C
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0000A4D5 File Offset: 0x000086D5
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Chartlet")]
		[Description("趋势图的特殊属性集合")]
		public TrendAttributes Trend
		{
			get
			{
				if (this._Trend == null)
				{
					this._Trend = new TrendAttributes();
				}
				return this._Trend;
			}
			set
			{
				this._Trend = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000ED954 File Offset: 0x000EBB54
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0000A4DE File Offset: 0x000086DE
		[Description("Spec Line的属性集合")]
		[Category("Chartlet")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public SpecLineAttributes SpecLine
		{
			get
			{
				if (this._SpecLine == null)
				{
					this._SpecLine = new SpecLineAttributes();
				}
				return this._SpecLine;
			}
			set
			{
				this._SpecLine = value;
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000ED97C File Offset: 0x000EBB7C
		public static GraphicsPath GetRoundRect(float x, float y, float width, float height, float roundRadius, bool halfRound)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(x, y, roundRadius * 2f, roundRadius * 2f, 180f, 90f);
			graphicsPath.AddLine(x + roundRadius, y, x + width - roundRadius, y);
			graphicsPath.AddArc(x + width - roundRadius * 2f, y, roundRadius * 2f, roundRadius * 2f, 270f, 90f);
			if (halfRound)
			{
				graphicsPath.AddLine(x + width, y + roundRadius, x + width, y + height);
				graphicsPath.AddLine(x + width, y + height, x, y + height);
				graphicsPath.AddLine(x, y + height, x, y + roundRadius);
			}
			else
			{
				graphicsPath.AddLine(x + width, y + roundRadius, x + width, y + height - roundRadius);
				graphicsPath.AddArc(x + width - roundRadius * 2f, y + height - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 0f, 90f);
				graphicsPath.AddLine(x + roundRadius, y + height, x + width - roundRadius, y + height);
				graphicsPath.AddArc(x, y + height - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 90f, 90f);
				graphicsPath.AddLine(x, y + roundRadius, x, y + height - roundRadius);
			}
			return graphicsPath;
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000EDAD4 File Offset: 0x000EBCD4
		public static GraphicsPath GetRoundRect(Rectangle r, float roundRadius, bool halfRound)
		{
			float num = (float)r.Left;
			float num2 = (float)r.Top;
			float num3 = (float)r.Width;
			float num4 = (float)r.Height;
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(num, num2, roundRadius * 2f, roundRadius * 2f, 180f, 90f);
			graphicsPath.AddLine(num + roundRadius, num2, num + num3 - roundRadius, num2);
			graphicsPath.AddArc(num + num3 - roundRadius * 2f, num2, roundRadius * 2f, roundRadius * 2f, 270f, 90f);
			if (halfRound)
			{
				graphicsPath.AddLine(num + num3, num2 + roundRadius, num + num3, num2 + num4);
				graphicsPath.AddLine(num + num3, num2 + num4, num, num2 + num4);
				graphicsPath.AddLine(num, num2 + num4, num, num2 + roundRadius);
			}
			else
			{
				graphicsPath.AddLine(num + num3, num2 + roundRadius, num + num3, num2 + num4 - roundRadius);
				graphicsPath.AddArc(num + num3 - roundRadius * 2f, num2 + num4 - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 0f, 90f);
				graphicsPath.AddLine(num + roundRadius, num2 + num4, num + num3 - roundRadius, num2 + num4);
				graphicsPath.AddArc(num, num2 + num4 - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 90f, 90f);
				graphicsPath.AddLine(num, num2 + roundRadius, num, num2 + num4 - roundRadius);
			}
			return graphicsPath;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000EDC5C File Offset: 0x000EBE5C
		public static GraphicsPath GetRoundRect(float x, float y, float width, float height, float roundRadius, string action)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(x, y, roundRadius * 2f, roundRadius * 2f, 180f, 90f);
			if (String.Compare(action, "Quad", false) == 0)
			{
				graphicsPath.AddLine(x + roundRadius, y, x + width, y);
				graphicsPath.AddLine(x + width, y, x + width, y + height);
			}
			else
			{
				graphicsPath.AddLine(x + roundRadius, y, x + width - roundRadius, y);
				graphicsPath.AddArc(x + width - roundRadius * 2f, y, roundRadius * 2f, roundRadius * 2f, 270f, 90f);
			}
			if (String.Compare(action, "Half", false) != 0)
			{
				if (String.Compare(action, "Quad", false) != 0)
				{
					graphicsPath.AddLine(x + width, y + roundRadius, x + width, y + height - roundRadius);
					graphicsPath.AddArc(x + width - roundRadius * 2f, y + height - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 0f, 90f);
					graphicsPath.AddLine(x + roundRadius, y + height, x + width - roundRadius, y + height);
					graphicsPath.AddArc(x, y + height - 2f * roundRadius, roundRadius * 2f, roundRadius * 2f, 90f, 90f);
					graphicsPath.AddLine(x, y + roundRadius, x, y + height - roundRadius);
					return graphicsPath;
				}
			}
			graphicsPath.AddLine(x + width, y + roundRadius, x + width, y + height);
			graphicsPath.AddLine(x + width, y + height, x, y + height);
			graphicsPath.AddLine(x, y + height, x, y + roundRadius);
			return graphicsPath;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000EDE04 File Offset: 0x000EC004
		public string GetDataString()
		{
			return this.InitializeDataString + this.Separator + this.GetCS();
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000EDE2C File Offset: 0x000EC02C
		private string GetCS()
		{
			string separator = this.Separator1;
			string str = Convert.ToString((int)this.AppearanceStyle);
			str = str + separator + Convert.ToString(this.Alpha3D);
			str = str + separator + Convert.ToString(Interaction.IIf(this.AutoBarWidth, "1", "0"));
			str = str + separator + Module2.SaveArrayAsString2(this.AxisX);
			str = str + separator + Module1.ConvertColorToString(this.Background.Highlight);
			str = str + separator + Module1.ConvertColorToString(this.Background.Lowlight);
			str = str + separator + Module1.ConvertColorToString(this.Background.Paper);
			str = str + separator + Convert.ToString(this.BaseLineX);
			str = str + separator + this.ChartTitle.Text;
			str = str + separator + Module1.ConvertColorToString(this.ChartTitle.BackColor);
			str = str + separator + Module1.ConvertColorToString(this.ChartTitle.ForeColor);
			str = str + separator + Module1.ConvertFontToString(this.ChartTitle.Font);
			str = str + separator + Convert.ToString(this.ChartTitle.OffsetY);
			str = str + separator + this.ChartTitle.Text;
			str = str + separator + Convert.ToString(Interaction.IIf(this.ChartTitle.Show, "1", "0"));
			str = str + separator + Convert.ToString((int)this.ChartType);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Colorful, "1", "0"));
			str = str + separator + Module1.ConvertColorToString(this.ColorGuider.BackColor);
			str = str + separator + Module1.ConvertColorToString(this.ColorGuider.ForeColor);
			str = str + separator + Module1.ConvertFontToString(this.ColorGuider.Font);
			str = str + separator + Convert.ToString(Interaction.IIf(this.ColorGuider.Show, "1", "0"));
			str = str + separator + this.CopyrightText;
			str = str + separator + Convert.ToString(Interaction.IIf(this.ShowCopyright, "1", "0"));
			str = str + separator + Convert.ToString(this.Crystal.Contraction);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Crystal.CoverFull, "1", "0"));
			str = str + separator + Convert.ToString((int)this.Crystal.Direction);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Crystal.Enable, "1", "0"));
			str = str + separator + Convert.ToString(this.Depth3D);
			str = str + separator + Convert.ToString((int)this.Dimension);
			str = str + separator + Module1.ConvertColorToString(this.Fill.Color1);
			str = str + separator + Module1.ConvertColorToString(this.Fill.Color2);
			str = str + separator + Module1.ConvertColorToString(this.Fill.Color3);
			str = str + separator + Convert.ToString((int)this.Fill.ColorStyle);
			str = str + separator + Convert.ToString(this.Fill.ShiftStep);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Fill.TextureEnable, "1", "0"));
			str = str + separator + Convert.ToString((int)this.Fill.TextureStyle);
			str = str + separator + Convert.ToString(this.GroupSize);
			str = str + separator + Convert.ToString(this.InflateBottom);
			str = str + separator + Convert.ToString(this.InflateLeft);
			str = str + separator + Convert.ToString(this.InflateRight);
			str = str + separator + Convert.ToString(this.InflateTop);
			str = str + separator + Convert.ToString(this.LineConnectionRadius);
			str = str + separator + Convert.ToString((int)this.LineConnectionType);
			str = str + separator + Convert.ToString(this.MaxValueY);
			str = str + separator + Convert.ToString(this.MinValueY);
			str = str + separator + Convert.ToString(this.RoundRadius);
			str = str + separator + Convert.ToString(Interaction.IIf(this.RoundRectangle, "1", "0"));
			str = str + separator + Convert.ToString(Interaction.IIf(this.ShowErrorInfo, "1", "0"));
			str = str + separator + Module1.ConvertColorToString(this.SpecLine.Color);
			str = str + separator + Convert.ToString(Interaction.IIf(this.SpecLine.EnableTexture, "1", "0"));
			str = str + separator + Convert.ToString(this.SpecLine.HighLimit);
			str = str + separator + Convert.ToString(this.SpecLine.LowLimit);
			str = str + separator + Convert.ToString(Interaction.IIf(this.SpecLine.Show, "1", "0"));
			str = str + separator + Convert.ToString(this.SpecLine.Width);
			str = str + separator + Convert.ToString((int)this.SpecLine.TextureStyle);
			str = str + separator + Module1.ConvertColorToString(this.Stroke.Color1);
			str = str + separator + Module1.ConvertColorToString(this.Stroke.Color2);
			str = str + separator + Module1.ConvertColorToString(this.Stroke.Color3);
			str = str + separator + Convert.ToString((int)this.Stroke.ColorStyle);
			str = str + separator + Convert.ToString(this.Stroke.ShiftStep);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Stroke.TextureEnable, "1", "0"));
			str = str + separator + Convert.ToString((int)this.Stroke.TextureStyle);
			str = str + separator + Convert.ToString(this.Stroke.Width);
			str = str + separator + Module1.ConvertColorToString(this.Tips.BackColor);
			str = str + separator + Module1.ConvertColorToString(this.Tips.ForeColor);
			str = str + separator + Module1.ConvertFontToString(this.Tips.Font);
			str = str + separator + Convert.ToString(Interaction.IIf(this.Tips.Show, "1", "0"));
			str = str + separator + this.Trend.EndString;
			str = str + separator + this.Trend.StartString;
			str = str + separator + Convert.ToString((int)this.Trend.TimeSpan);
			str = str + separator + this.Trend.ValueFormat;
			str = str + separator + Module1.ConvertColorToString(this.XLabels.BackColor);
			str = str + separator + Module1.ConvertColorToString(this.XLabels.ForeColor);
			str = str + separator + Module1.ConvertFontToString(this.XLabels.Font);
			str = str + separator + Module1.ConvertFontToString(this.XLabels.UnitFont);
			str = str + separator + Convert.ToString(this.XLabels.LabelCount);
			str = str + separator + Convert.ToString(this.XLabels.RotateAngle);
			str = str + separator + Convert.ToString(this.XLabels.SampleSize);
			str = str + separator + Convert.ToString(Interaction.IIf(this.XLabels.Show, "1", "0"));
			str = str + separator + this.XLabels.UnitText;
			str = str + separator + this.XLabels.ValueFormat;
			str = str + separator + Module1.ConvertColorToString(this.YLabels.BackColor);
			str = str + separator + Module1.ConvertColorToString(this.YLabels.ForeColor);
			str = str + separator + Module1.ConvertFontToString(this.YLabels.Font);
			str = str + separator + Module1.ConvertFontToString(this.YLabels.UnitFont);
			str = str + separator + Convert.ToString(this.YLabels.LabelCount);
			str = str + separator + Convert.ToString(Interaction.IIf(this.YLabels.Show, "1", "0"));
			str = str + separator + this.YLabels.UnitText;
			str = str + separator + this.YLabels.ValueFormat;
			str = str + separator + Module2.SaveArrayAsString2(this.GroupTitle);
			str = str + separator + Module2.SaveArrayAsString3(this.Breeze);
			str = str + separator + Module2.SaveArrayAsString3(this.Aurora);
			str = str + separator + Module2.SaveArrayAsString3(this.StarryNight);
			str = str + separator + Module2.SaveArrayAsString3(this.BarBrushColor);
			str = str + separator + Module2.SaveArrayAsString3(this.BarPenColor);
			return str + separator + Convert.ToString(Interaction.IIf(this.IsRightAngle, "1", "0"));
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000EE77C File Offset: 0x000EC97C
		public void ParaseDataString(string ss)
		{
			string[] array = Strings.Split(ss, this.Separator, -1, CompareMethod.Binary);
			if (array.Length == 2)
			{
				this.ParaseData(array[0]);
				this.ParaseCS(array[1]);
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000EE7B4 File Offset: 0x000EC9B4
		private void ParaseData(string ss)
		{
			checked
			{
				if (ss != null)
				{
					try
					{
						string[] array = Strings.Split(ss, this.Separator3, -1, CompareMethod.Binary);
						ArrayList arrayList = new ArrayList();
						ArrayList arrayList2 = new ArrayList();
						string[] array2 = Strings.Split(array[0], this.Separator2, -1, CompareMethod.Binary);
						ArrayList[] array3 = new ArrayList[array2.Length - 1 + 1];
						int num = 0;
						int num2 = array3.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							array3[i] = new ArrayList();
						}
						int num3 = 0;
						int num4 = array2.Length - 1;
						for (int j = num3; j <= num4; j++)
						{
							string[] array4 = Strings.Split(array2[j], this.Separator1, -1, CompareMethod.Binary);
							int num5 = 0;
							int num6 = array4.Length - 1;
							for (int k = num5; k <= num6; k++)
							{
								array3[j].Add(array4[k]);
							}
						}
						array2 = Strings.Split(array[1], this.Separator1, -1, CompareMethod.Binary);
						int num7 = 0;
						int num8 = array2.Length - 1;
						for (int l = num7; l <= num8; l++)
						{
							arrayList.Add(array2[l]);
						}
						array2 = Strings.Split(array[2], this.Separator1, -1, CompareMethod.Binary);
						int num9 = 0;
						int num10 = array2.Length - 1;
						for (int m = num9; m <= num10; m++)
						{
							arrayList2.Add(array2[m]);
						}
						this.InitializeData(array3, arrayList, arrayList2);
						int num11 = 0;
						int num12 = array3.Length - 1;
						for (int n = num11; n <= num12; n++)
						{
							array3[n] = null;
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000EE93C File Offset: 0x000ECB3C
		private void ParaseCS(string ss)
		{
			string separator = this.Separator1;
			string[] array = Strings.Split(ss, separator, -1, CompareMethod.Binary);
			this.AppearanceStyle = (Chartlet.AppearanceStyles)Convert.ToInt32(array[0]);
			this.Alpha3D = Convert.ToByte(array[1]);
			this.AutoBarWidth = Convert.ToBoolean(array[2]);
			this.AxisX = Module2.RestoreArrayFromString2(array[3]);
			this.Background.Highlight = Module1.ConvertStringToColor(array[4]);
			this.Background.Lowlight = Module1.ConvertStringToColor(array[5]);
			this.Background.Paper = Module1.ConvertStringToColor(array[6]);
			this.BaseLineX = Convert.ToDouble(array[7]);
			this.ChartTitle.Text = array[8];
			this.ChartTitle.BackColor = Module1.ConvertStringToColor(array[9]);
			this.ChartTitle.ForeColor = Module1.ConvertStringToColor(array[10]);
			this.ChartTitle.Font = Module1.ConvertStringToFont(array[11]);
			this.ChartTitle.OffsetY = Convert.ToInt32(array[12]);
			this.ChartTitle.Text = array[13];
			this.ChartTitle.Show = Convert.ToBoolean(array[14]);
			this.ChartType = (Chartlet.ChartTypes)Convert.ToInt32(array[15]);
			this.Colorful = Convert.ToBoolean(array[16]);
			this.ColorGuider.BackColor = Module1.ConvertStringToColor(array[17]);
			this.ColorGuider.ForeColor = Module1.ConvertStringToColor(array[18]);
			this.ColorGuider.Font = Module1.ConvertStringToFont(array[19]);
			this.ColorGuider.Show = Convert.ToBoolean(array[20]);
			this.CopyrightText = array[21];
			this.ShowCopyright = Convert.ToBoolean(array[22]);
			this.Crystal.Contraction = Convert.ToInt32(array[23]);
			this.Crystal.CoverFull = Convert.ToBoolean(array[24]);
			this.Crystal.Direction = (Chartlet.Direction)Convert.ToInt32(array[25]);
			this.Crystal.Enable = Convert.ToBoolean(array[26]);
			this.Depth3D = Convert.ToInt32(array[27]);
			this.Dimension = (Chartlet.ChartDimensions)Convert.ToInt32(array[28]);
			this.Fill.Color1 = Module1.ConvertStringToColor(array[29]);
			this.Fill.Color2 = Module1.ConvertStringToColor(array[30]);
			this.Fill.Color3 = Module1.ConvertStringToColor(array[31]);
			this.Fill.ColorStyle = (Chartlet.ColorStyles)Convert.ToInt32(array[32]);
			this.Fill.ShiftStep = Convert.ToInt32(array[33]);
			this.Fill.TextureEnable = Convert.ToBoolean(array[34]);
			this.Fill.TextureStyle = (HatchStyle)Convert.ToInt32(array[35]);
			this.GroupSize = Convert.ToInt32(array[36]);
			this.InflateBottom = Convert.ToInt32(array[37]);
			this.InflateLeft = Convert.ToInt32(array[38]);
			this.InflateRight = Convert.ToInt32(array[39]);
			this.InflateTop = Convert.ToInt32(array[40]);
			this.LineConnectionRadius = Convert.ToInt32(array[41]);
			this.LineConnectionType = (Chartlet.LineConnectionTypes)Convert.ToInt32(array[42]);
			this.MaxValueY = Convert.ToDouble(array[43]);
			this.MinValueY = Convert.ToDouble(array[44]);
			this.RoundRadius = Convert.ToInt32(array[45]);
			this.RoundRectangle = Convert.ToBoolean(array[46]);
			this.ShowErrorInfo = Convert.ToBoolean(array[47]);
			this.SpecLine.Color = Module1.ConvertStringToColor(array[48]);
			this.SpecLine.EnableTexture = Convert.ToBoolean(array[49]);
			this.SpecLine.HighLimit = Convert.ToInt32(array[50]);
			this.SpecLine.LowLimit = Convert.ToInt32(array[51]);
			this.SpecLine.Show = Convert.ToBoolean(array[52]);
			this.SpecLine.Width = Convert.ToInt32(array[53]);
			this.SpecLine.TextureStyle = (HatchStyle)Convert.ToInt32(array[54]);
			this.Stroke.Color1 = Module1.ConvertStringToColor(array[55]);
			this.Stroke.Color2 = Module1.ConvertStringToColor(array[56]);
			this.Stroke.Color3 = Module1.ConvertStringToColor(array[57]);
			this.Stroke.ColorStyle = (Chartlet.ColorStyles)Convert.ToInt32(array[58]);
			this.Stroke.ShiftStep = Convert.ToInt32(array[59]);
			this.Stroke.TextureEnable = Convert.ToBoolean(array[60]);
			this.Stroke.TextureStyle = (HatchStyle)Convert.ToInt32(array[61]);
			this.Stroke.Width = Convert.ToInt32(array[62]);
			this.Tips.BackColor = Module1.ConvertStringToColor(array[63]);
			this.Tips.ForeColor = Module1.ConvertStringToColor(array[64]);
			this.Tips.Font = Module1.ConvertStringToFont(array[65]);
			this.Tips.Show = Convert.ToBoolean(array[66]);
			this.Trend.EndString = array[67];
			this.Trend.StartString = array[68];
			this.Trend.TimeSpan = (Chartlet.TimeSpanTypes)Convert.ToInt32(array[69]);
			this.Trend.ValueFormat = array[70];
			this.XLabels.BackColor = Module1.ConvertStringToColor(array[71]);
			this.XLabels.ForeColor = Module1.ConvertStringToColor(array[72]);
			this.XLabels.Font = Module1.ConvertStringToFont(array[73]);
			this.XLabels.UnitFont = Module1.ConvertStringToFont(array[74]);
			this.XLabels.LabelCount = Convert.ToInt32(array[75]);
			this.XLabels.RotateAngle = Convert.ToSingle(array[76]);
			this.XLabels.SampleSize = Convert.ToInt32(array[77]);
			this.XLabels.Show = Convert.ToBoolean(array[78]);
			this.XLabels.UnitText = array[79];
			this.XLabels.ValueFormat = array[80];
			this.YLabels.BackColor = Module1.ConvertStringToColor(array[81]);
			this.YLabels.ForeColor = Module1.ConvertStringToColor(array[82]);
			this.YLabels.Font = Module1.ConvertStringToFont(array[83]);
			this.YLabels.UnitFont = Module1.ConvertStringToFont(array[84]);
			this.YLabels.LabelCount = Convert.ToInt32(array[85]);
			this.YLabels.Show = Convert.ToBoolean(array[86]);
			this.YLabels.UnitText = array[87];
			this.YLabels.ValueFormat = array[88];
			this.GroupTitle = Module2.RestoreArrayFromString2(array[89]);
			this.Breeze = Module2.RestoreArrayFromString3(array[90]);
			this.Aurora = Module2.RestoreArrayFromString3(array[91]);
			this.StarryNight = Module2.RestoreArrayFromString3(array[92]);
			this.BarBrushColor = Module2.RestoreArrayFromString3(array[93]);
			this.BarPenColor = Module2.RestoreArrayFromString3(array[94]);
			try
			{
				this.IsRightAngle = Convert.ToBoolean(array[95]);
			}
			catch (Exception ex)
			{
				this.IsRightAngle = false;
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000EF034 File Offset: 0x000ED234
		public void InitializeData(ArrayList[] ChartData, ArrayList XLabel, ArrayList ColorGuider)
		{
			this.InitializeDataString = "";
			checked
			{
				if (ChartData != null)
				{
					int num = 0;
					int num2 = ChartData.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i != 0)
						{
							this.InitializeDataString += this.Separator2;
						}
						int num3 = 0;
						int num4 = ChartData[i].Count - 1;
						for (int j = num3; j <= num4; j++)
						{
							if (j == 0)
							{
								this.InitializeDataString += ChartData[i][j].ToString();
							}
							else
							{
								this.InitializeDataString = this.InitializeDataString + this.Separator1 + ChartData[i][j].ToString();
							}
						}
					}
				}
				else
				{
					this.InitializeDataString = "";
				}
				this.InitializeDataString += this.Separator3;
				if (XLabel != null)
				{
					int num5 = 0;
					int num6 = XLabel.Count - 1;
					for (int k = num5; k <= num6; k++)
					{
						if (k == 0)
						{
							this.InitializeDataString += XLabel[k].ToString();
						}
						else
						{
							this.InitializeDataString = this.InitializeDataString + this.Separator1 + XLabel[k].ToString();
						}
					}
				}
				this.InitializeDataString += this.Separator3;
				if (ColorGuider != null)
				{
					int num7 = 0;
					int num8 = ColorGuider.Count - 1;
					for (int l = num7; l <= num8; l++)
					{
						if (l == 0)
						{
							this.InitializeDataString += ColorGuider[l].ToString();
						}
						else
						{
							this.InitializeDataString = this.InitializeDataString + this.Separator1 + ColorGuider[l].ToString();
						}
					}
				}
				try
				{
					switch (this.Fill.ColorStyle)
					{
					case Chartlet.ColorStyles.Breeze:
						this.Breeze.CopyTo(this.BarBrushColor, 0);
						break;
					case Chartlet.ColorStyles.Aurora:
						this.Aurora.CopyTo(this.BarBrushColor, 0);
						break;
					case Chartlet.ColorStyles.StarryNight:
						this.StarryNight.CopyTo(this.BarBrushColor, 0);
						break;
					}
					switch (this.Stroke.ColorStyle)
					{
					case Chartlet.ColorStyles.Breeze:
						this.Breeze.CopyTo(this.BarPenColor, 0);
						break;
					case Chartlet.ColorStyles.Aurora:
						this.Aurora.CopyTo(this.BarPenColor, 0);
						break;
					case Chartlet.ColorStyles.StarryNight:
						this.StarryNight.CopyTo(this.BarPenColor, 0);
						break;
					}
				}
				catch (Exception ex)
				{
				}
				if (!this.Fill.Color1.IsEmpty)
				{
					this.BarBrushColor[0] = this.Fill.Color1;
				}
				if (!this.Fill.Color2.IsEmpty)
				{
					this.BarBrushColor[1] = this.Fill.Color2;
				}
				if (!this.Fill.Color3.IsEmpty)
				{
					this.BarBrushColor[2] = this.Fill.Color3;
				}
				if (!this.Stroke.Color1.IsEmpty)
				{
					this.BarPenColor[0] = this.Stroke.Color1;
				}
				if (!this.Stroke.Color2.IsEmpty)
				{
					this.BarPenColor[1] = this.Stroke.Color2;
				}
				if (!this.Stroke.Color3.IsEmpty)
				{
					this.BarPenColor[2] = this.Stroke.Color3;
				}
				if (ChartData != null)
				{
					int num9 = ChartData.Length;
					this.GroupSize = num9;
					float[] array = new float[num9 - 1 + 1];
					int num10 = 0;
					int num11 = num9 - 1;
					for (int m = num10; m <= num11; m++)
					{
						array[m] = (float)ChartData[m].Count;
					}
					this.MaxCount = (int)Math.Round(Math.Truncate((double)Chartlet.GetMax(array)));
					this.MinCount = (int)Math.Round(Math.Truncate((double)Chartlet.GetMin(array)));
					this.RawDatas = new decimal[num9 - 1 + 1][];
					int num12 = 0;
					int num13 = num9 - 1;
					for (int n = num12; n <= num13; n++)
					{
						this.RawDatas[n] = new decimal[this.MaxCount - 1 + 1];
						int num14 = 0;
						int num15 = this.MaxCount - 1;
						int num16 = num14;
						while (num16 <= num15)
						{
							if (ChartData[n] != null)
							{
								try
								{
									this.RawDatas[n][num16] = decimal.Parse(ChartData[n][num16].ToString());
									goto IL_510;
								}
								catch (Exception ex2)
								{
									this.RawDatas[n][num16] = -0.830213m;
									goto IL_510;
								}
								goto IL_4D0;
							}
							goto IL_4D0;
							IL_510:
							num16++;
							continue;
							IL_4D0:
							this.RawDatas[n][num16] = -0.830213m;
							goto IL_510;
						}
					}
					this.AxisX = new string[this.MaxCount - 1 + 1];
					if (XLabel != null)
					{
						int num17 = 0;
						int num18 = this.MaxCount - 1;
						for (int num19 = num17; num19 <= num18; num19++)
						{
							if (num19 >= XLabel.Count)
							{
								this.AxisX[num19] = "null";
							}
							else
							{
								this.AxisX[num19] = XLabel[num19].ToString();
							}
						}
					}
					else
					{
						int num20 = 0;
						int num21 = this.MaxCount - 1;
						for (int num22 = num20; num22 <= num21; num22++)
						{
							this.AxisX[num22] = (num22 + 1).ToString();
						}
					}
					if (ColorGuider != null)
					{
						this.GroupTitle = new string[this.GroupSize - 1 + 1];
						int num23 = 0;
						int num24 = this.GroupSize - 1;
						for (int num25 = num23; num25 <= num24; num25++)
						{
							if (num25 >= ColorGuider.Count)
							{
								this.GroupTitle[num25] = "null";
							}
							else
							{
								this.GroupTitle[num25] = ColorGuider[num25].ToString();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000EF674 File Offset: 0x000ED874
		public void BindChartData(DataGridView dgv)
		{
			checked
			{
				if (dgv != null)
				{
					int num = 0;
					if (dgv.RowCount > 0)
					{
						if (dgv.Rows[dgv.RowCount - 1].IsNewRow)
						{
							num = dgv.RowCount - 1;
						}
						else if (Module1.IsNullLastRow(dgv))
						{
							num = dgv.RowCount - 1;
						}
						else
						{
							num = dgv.RowCount;
						}
					}
					if (dgv != null)
					{
						ArrayList[] array = new ArrayList[dgv.Columns.Count - 2 + 1];
						ArrayList arrayList = new ArrayList();
						ArrayList arrayList2 = new ArrayList();
						if (String.Compare(this.XLabels.UnitText, "XLabelsUnit", false) == 0)
						{
							this.XLabels.UnitText = dgv.Columns[0].HeaderText;
						}
						int num2 = 0;
						int num3 = num - 1;
						for (int i = num2; i <= num3; i++)
						{
							arrayList.Add(dgv.Rows[i].Cells[0].Value.ToString());
						}
						int num4 = 0;
						int num5 = dgv.Columns.Count - 2;
						for (int j = num4; j <= num5; j++)
						{
							array[j] = new ArrayList();
							int num6 = 0;
							int num7 = num - 1;
							for (int k = num6; k <= num7; k++)
							{
								array[j].Add(dgv.Rows[k].Cells[j + 1].Value.ToString());
							}
							arrayList2.Add(dgv.Columns[j + 1].HeaderText);
						}
						this.InitializeData(array, arrayList, arrayList2);
					}
				}
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000EF800 File Offset: 0x000EDA00
		public void BindChartData(DataView DataSource)
		{
			checked
			{
				if (DataSource != null)
				{
					ArrayList[] array = new ArrayList[DataSource.Table.Columns.Count - 2 + 1];
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					if (String.Compare(this.XLabels.UnitText, "XLabelsUnit", false) == 0)
					{
						this.XLabels.UnitText = DataSource.Table.Columns[0].ColumnName;
					}
					int num = 0;
					int num2 = DataSource.Table.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						arrayList.Add(DataSource[i][0].ToString());
					}
					int num3 = 0;
					int num4 = DataSource.Table.Columns.Count - 2;
					for (int j = num3; j <= num4; j++)
					{
						array[j] = new ArrayList();
						int num5 = 0;
						int num6 = DataSource.Table.Rows.Count - 1;
						for (int k = num5; k <= num6; k++)
						{
							array[j].Add(DataSource[k][j + 1].ToString());
						}
						arrayList2.Add(DataSource.Table.Columns[j + 1].ColumnName);
					}
					this.InitializeData(array, arrayList, arrayList2);
				}
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000EF94C File Offset: 0x000EDB4C
		public void BindChartData(DataTable DataSource)
		{
			checked
			{
				if (DataSource != null)
				{
					ArrayList[] array = new ArrayList[DataSource.Columns.Count - 2 + 1];
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					if (String.Compare(this.XLabels.UnitText, "XLabelsUnit", false) == 0)
					{
						this.XLabels.UnitText = DataSource.Columns[0].ColumnName;
					}
					int num = 0;
					int num2 = DataSource.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						arrayList.Add(DataSource.Rows[i][0].ToString());
					}
					int num3 = 0;
					int num4 = DataSource.Columns.Count - 2;
					for (int j = num3; j <= num4; j++)
					{
						array[j] = new ArrayList();
						int num5 = 0;
						int num6 = DataSource.Rows.Count - 1;
						for (int k = num5; k <= num6; k++)
						{
							array[j].Add(DataSource.Rows[k][j + 1].ToString());
						}
						arrayList2.Add(DataSource.Columns[j + 1].ColumnName);
					}
					this.InitializeData(array, arrayList, arrayList2);
				}
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000A4E7 File Offset: 0x000086E7
		public void BindChartData(DataSet DataSource)
		{
			if (DataSource != null)
			{
				this.BindChartData(DataSource.Tables[0]);
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000EFA84 File Offset: 0x000EDC84
		private void SetAppearance()
		{
			string[] array = this.AppearanceStyle.ToString().Split(new char[]
			{
				'_'
			});
			if (this.Stroke.Color1.Equals(Color.White))
			{
				this.Stroke.Color1 = Color.Empty;
			}
			string left = array[0];
			if (String.Compare(left, "Bar", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.Bar;
			}
			else if (String.Compare(left, "Line", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.Line;
				this.Depth3D = 20;
			}
			else if (String.Compare(left, "Pie", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.Pie;
				this.Stroke.Color1 = Color.White;
			}
			else if (String.Compare(left, "Stack", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.Stack;
			}
			else if (String.Compare(left, "HBar", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.HBar;
			}
			else if (String.Compare(left, "Trend", false) == 0)
			{
				this.ChartType = Chartlet.ChartTypes.Trend;
				this.Tips.Show = false;
				this.Depth3D = 20;
			}
			string left2 = array[1];
			if (String.Compare(left2, "2D", false) == 0)
			{
				this.Dimension = Chartlet.ChartDimensions.Chart2D;
			}
			else if (String.Compare(left2, "3D", false) == 0)
			{
				this.Dimension = Chartlet.ChartDimensions.Chart3D;
			}
			string left3 = array[2];
			if (String.Compare(left3, "Breeze", false) == 0)
			{
				this.Fill.ColorStyle = Chartlet.ColorStyles.Breeze;
				if (this.Breeze != null)
				{
					this.Breeze.CopyTo(this.BarBrushColor, 0);
				}
				if (this.ChartType != Chartlet.ChartTypes.Line && this.ChartType != Chartlet.ChartTypes.Trend)
				{
					goto IL_2D2;
				}
				this.Stroke.ColorStyle = Chartlet.ColorStyles.Breeze;
				try
				{
					this.Breeze.CopyTo(this.BarPenColor, 0);
					goto IL_2D2;
				}
				catch (Exception ex)
				{
					goto IL_2D2;
				}
			}
			if (String.Compare(left3, "Aurora", false) == 0)
			{
				this.Fill.ColorStyle = Chartlet.ColorStyles.Aurora;
				if (this.Aurora != null)
				{
					this.Aurora.CopyTo(this.BarBrushColor, 0);
				}
				if (this.ChartType != Chartlet.ChartTypes.Line && this.ChartType != Chartlet.ChartTypes.Trend)
				{
					goto IL_2D2;
				}
				this.Stroke.ColorStyle = Chartlet.ColorStyles.Aurora;
				try
				{
					this.Aurora.CopyTo(this.BarPenColor, 0);
					goto IL_2D2;
				}
				catch (Exception ex2)
				{
					goto IL_2D2;
				}
			}
			if (String.Compare(left3, "StarryNight", false) == 0)
			{
				if (this.StarryNight != null)
				{
					this.StarryNight.CopyTo(this.BarBrushColor, 0);
				}
				this.Fill.ColorStyle = Chartlet.ColorStyles.StarryNight;
				if (this.ChartType == Chartlet.ChartTypes.Line || this.ChartType == Chartlet.ChartTypes.Trend)
				{
					this.Stroke.ColorStyle = Chartlet.ColorStyles.StarryNight;
					try
					{
						this.StarryNight.CopyTo(this.BarPenColor, 0);
					}
					catch (Exception ex3)
					{
					}
				}
			}
			IL_2D2:
			string left4 = array[3];
			checked
			{
				if (String.Compare(left4, "NoCrystal", false) == 0)
				{
					this.Crystal.Enable = false;
					if (this.ChartType == Chartlet.ChartTypes.Pie)
					{
						this.Stroke.Width = 3;
					}
					if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
					{
						this.Alpha3D = 160;
					}
				}
				else if (String.Compare(left4, "FlatCrystal", false) == 0)
				{
					this.Crystal.Enable = true;
					this.Crystal.CoverFull = true;
					this.Crystal.Direction = Chartlet.Direction.TopBottom;
					if (this.ChartType == Chartlet.ChartTypes.HBar)
					{
						this.Crystal.Direction = Chartlet.Direction.RightLeft;
					}
					switch (this.Fill.ColorStyle)
					{
					case Chartlet.ColorStyles.Breeze:
						this.Crystal.Contraction = 1;
						break;
					case Chartlet.ColorStyles.Aurora:
						this.Crystal.Contraction = 1;
						break;
					case Chartlet.ColorStyles.StarryNight:
						this.Crystal.Contraction = 3;
						break;
					}
					if (this.ChartType == Chartlet.ChartTypes.Pie)
					{
						this.Stroke.Width = 0;
					}
					if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
					{
						this.Alpha3D = 200;
						this.Crystal.Direction = Chartlet.Direction.BottomTop;
						this.Crystal.Contraction = 1;
					}
				}
				else if (String.Compare(left4, "GlassCrystal", false) == 0)
				{
					this.Crystal.Enable = true;
					this.Crystal.CoverFull = false;
					this.Crystal.Direction = Chartlet.Direction.LeftRight;
					if (this.ChartType == Chartlet.ChartTypes.HBar)
					{
						this.Crystal.Direction = Chartlet.Direction.TopBottom;
					}
					if (this.Fill.ColorStyle == Chartlet.ColorStyles.Aurora)
					{
						this.RoundRectangle = false;
					}
					else
					{
						this.RoundRectangle = true;
					}
					this.RoundRadius = 3;
					int num = 0;
					int num2 = this.GroupSize - 1;
					for (int i = num; i <= num2; i++)
					{
						this.BarPenColor[i % 12] = ColorTranslator.FromHtml("");
					}
					if (this.ChartType == Chartlet.ChartTypes.Pie)
					{
						this.Stroke.Width = 0;
					}
				}
				else if (String.Compare(left4, "ThickRound", false) == 0)
				{
					this.Stroke.Width = 8;
					this.LineConnectionRadius = 18;
					this.LineConnectionType = Chartlet.LineConnectionTypes.Round;
				}
				else if (String.Compare(left4, "ThickSquare", false) == 0)
				{
					this.Stroke.Width = 8;
					this.LineConnectionRadius = 18;
					this.LineConnectionType = Chartlet.LineConnectionTypes.Square;
				}
				else if (String.Compare(left4, "ThinRound", false) == 0)
				{
					this.Stroke.Width = 2;
					this.LineConnectionRadius = 8;
					this.LineConnectionType = Chartlet.LineConnectionTypes.Round;
				}
				else if (String.Compare(left4, "ThinSquare", false) == 0)
				{
					this.Stroke.Width = 2;
					this.LineConnectionRadius = 8;
					this.LineConnectionType = Chartlet.LineConnectionTypes.Square;
				}
				if ((this.ChartType == Chartlet.ChartTypes.Line || this.ChartType == Chartlet.ChartTypes.Trend) && this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					this.Stroke.Width = 1;
					this.Alpha3D = 100;
					if (array[3].IndexOf("NoCrystal") > -1)
					{
						this.Crystal.Enable = false;
					}
					if (array[3].IndexOf("FlatCrystal") > -1)
					{
						this.Crystal.Enable = true;
						this.Crystal.CoverFull = true;
						this.Crystal.Direction = Chartlet.Direction.LeftRight;
					}
					if (array[3].IndexOf("GlassCrystal") > -1)
					{
						this.Crystal.Enable = true;
						this.Crystal.CoverFull = true;
						this.Crystal.Direction = Chartlet.Direction.TopBottom;
					}
					if (array[3].IndexOf("None") > -1)
					{
						this.LineConnectionType = Chartlet.LineConnectionTypes.None;
						this.LineConnectionRadius = 0;
					}
					if (array[3].IndexOf("Round") > -1)
					{
						this.LineConnectionType = Chartlet.LineConnectionTypes.Round;
						this.LineConnectionRadius = 6;
						this.Stroke.Width = 2;
					}
					if (array[3].IndexOf("Square") > -1)
					{
						this.LineConnectionType = Chartlet.LineConnectionTypes.Square;
						this.LineConnectionRadius = 10;
					}
				}
				if (String.Compare(array[4], "NoBorder", false) != 0 && String.Compare(array[4], "None", false) != 0)
				{
					int num3 = 0;
					do
					{
						this.BarPenColor[num3 % 12] = Color.White;
						num3++;
					}
					while (num3 <= 11);
				}
				string left5 = array[4];
				if (String.Compare(left5, "NoBorder", false) == 0)
				{
					if (this.ChartType != Chartlet.ChartTypes.Line && this.ChartType != Chartlet.ChartTypes.Trend)
					{
						this.Stroke.Width = 0;
					}
					if (this.ChartType == Chartlet.ChartTypes.Bar && this.Dimension == Chartlet.ChartDimensions.Chart3D)
					{
						this.Stroke.Width = 1;
						this.Stroke.ColorStyle = this.Fill.ColorStyle;
					}
				}
				else if (String.Compare(left5, "WhiteBorder", false) == 0)
				{
					switch (this.ChartType)
					{
					case Chartlet.ChartTypes.Bar:
						if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
						{
							this.Stroke.Width = 4;
							this.Crystal.Contraction = 3;
							this.RoundRectangle = true;
						}
						else
						{
							this.Stroke.Width = 1;
							this.Crystal.Contraction = 3;
						}
						break;
					case Chartlet.ChartTypes.Pie:
						this.Stroke.Width = 6;
						break;
					}
				}
				else if (String.Compare(left5, "TextureBorder", false) == 0)
				{
					Chartlet.ChartTypes chartType = this.ChartType;
					if (chartType == Chartlet.ChartTypes.Bar)
					{
						this.Stroke.Width = 4;
						this.Crystal.Contraction = 0;
						this.RoundRectangle = false;
						this.Stroke.TextureEnable = true;
					}
				}
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000F02D8 File Offset: 0x000EE4D8
		private void DrawBarBase2D(Graphics g, SolidBrush BarBrush, Pen BarPen, int BarLeft, int BarTop, int BarW, int BarH)
		{
			if (this.RoundRectangle)
			{
				g.SmoothingMode = SmoothingMode.AntiAlias;
				if (this.RoundRadius < 1)
				{
					this.RoundRadius = 1;
				}
				if (this.ChartType == Chartlet.ChartTypes.HBar)
				{
					g.FillPath(BarBrush, Chartlet.GetRoundRect((float)BarLeft, (float)BarTop, (float)BarW, (float)BarH, (float)this.RoundRadius, false));
				}
				else
				{
					g.FillPath(BarBrush, Chartlet.GetRoundRect((float)BarLeft, (float)BarTop, (float)BarW, (float)BarH, (float)this.RoundRadius, true));
				}
				if (this.Stroke.Width > 0)
				{
					if (this.ChartType == Chartlet.ChartTypes.HBar)
					{
						g.DrawPath(BarPen, Chartlet.GetRoundRect((float)BarLeft, (float)BarTop, (float)BarW, (float)BarH, (float)this.RoundRadius, false));
					}
					else
					{
						g.DrawPath(BarPen, Chartlet.GetRoundRect((float)BarLeft, (float)BarTop, (float)BarW, (float)BarH, (float)this.RoundRadius, true));
					}
				}
				g.SmoothingMode = SmoothingMode.None;
			}
			else
			{
				g.FillRectangle(BarBrush, BarLeft, BarTop, BarW, BarH);
				if (this.Stroke.Width > 0)
				{
					g.DrawRectangle(BarPen, BarLeft, BarTop, BarW, BarH);
				}
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000F03E0 File Offset: 0x000EE5E0
		private void DrawBarBase3D(Graphics g, SolidBrush BarBrush, Pen BarPen, int BarLeft, int BarTop, int BarW, int BarH, int Depth)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			checked
			{
				graphicsPath.AddLine(BarLeft, BarTop, BarLeft - Depth, BarTop + Depth);
				graphicsPath.AddLine(BarLeft - Depth, BarTop + Depth, BarLeft - Depth + BarW, BarTop + Depth);
				graphicsPath.AddLine(BarLeft - Depth + BarW, BarTop + Depth, BarLeft + BarW, BarTop);
				graphicsPath.AddLine(BarLeft + BarW, BarTop, BarLeft, BarTop);
				g.FillPath(BarBrush, graphicsPath);
				g.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), graphicsPath);
				if (this.Stroke.Width > 0)
				{
					g.DrawPath(BarPen, graphicsPath);
				}
				graphicsPath.Reset();
				graphicsPath.StartFigure();
				graphicsPath.AddLine(BarLeft + BarW, BarTop, BarLeft + BarW - Depth, BarTop + Depth);
				graphicsPath.AddLine(BarLeft + BarW - Depth, BarTop + Depth, BarLeft + BarW - Depth, BarTop + Depth + BarH);
				graphicsPath.AddLine(BarLeft + BarW - Depth, BarTop + Depth + BarH, BarLeft + BarW, BarTop + BarH);
				graphicsPath.AddLine(BarLeft + BarW, BarTop + BarH, BarLeft + BarW, BarTop);
				g.FillPath(BarBrush, graphicsPath);
				g.FillPath(new SolidBrush(Color.FromArgb(40, Color.Black)), graphicsPath);
				if (this.Stroke.Width > 0)
				{
					g.DrawPath(BarPen, graphicsPath);
				}
				graphicsPath.Reset();
				graphicsPath.StartFigure();
				graphicsPath.AddLine(BarLeft - Depth, BarTop + Depth, BarLeft - Depth, BarTop + Depth + BarH);
				graphicsPath.AddLine(BarLeft - Depth, BarTop + Depth + BarH, BarLeft - Depth + BarW, BarTop + Depth + BarH);
				graphicsPath.AddLine(BarLeft - Depth + BarW, BarTop + Depth + BarH, BarLeft - Depth + BarW, BarTop + Depth);
				graphicsPath.AddLine(BarLeft - Depth + BarW, BarTop + Depth, BarLeft - Depth, BarTop + Depth);
				g.FillPath(BarBrush, graphicsPath);
				if (this.Stroke.Width > 0)
				{
					g.DrawPath(BarPen, graphicsPath);
				}
				graphicsPath.Dispose();
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000F05F4 File Offset: 0x000EE7F4
		private void DrawBarCrystal(Graphics g, int BarLeft, int BarTop, int BarW, int BarH, int Depth)
		{
			checked
			{
				Rectangle rectangle = new Rectangle(BarLeft - Depth, BarTop + Depth, BarW, BarH);
				rectangle.Inflate(-1 * this.Crystal.Contraction, -1 * this.Crystal.Contraction);
				if (!this.Crystal.CoverFull)
				{
					Rectangle rect = new Rectangle(BarLeft - Depth, BarTop + Depth, BarW / 2 + 1, BarH);
					if (this.ChartType == Chartlet.ChartTypes.HBar)
					{
						rect = new Rectangle(BarLeft - Depth, BarTop + Depth, BarW, BarH / 2 + 1);
					}
					rectangle.Intersect(rect);
				}
				Point point;
				Point point2;
				switch (this.Crystal.Direction)
				{
				case Chartlet.Direction.LeftRight:
					point = new Point(rectangle.Left, 0);
					point2 = new Point(rectangle.Left + rectangle.Width + 1, 0);
					break;
				case Chartlet.Direction.TopBottom:
					point = new Point(0, rectangle.Top - 1);
					point2 = new Point(0, rectangle.Top + rectangle.Height);
					break;
				case Chartlet.Direction.RightLeft:
					point = new Point(rectangle.Left + rectangle.Width, 0);
					point2 = new Point(rectangle.Left - 1, 0);
					break;
				case Chartlet.Direction.BottomTop:
					point = new Point(0, rectangle.Top + rectangle.Height);
					point2 = new Point(0, rectangle.Top - 1);
					break;
				default:
					point = new Point(rectangle.Left, 0);
					point2 = new Point(rectangle.Left + rectangle.Width / 2, 0);
					break;
				}
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point, point2, Color.FromArgb(178, Color.White), Color.FromArgb(25, Color.White));
				if (this.RoundRectangle)
				{
					int num = this.RoundRadius - 2;
					if (num < 1)
					{
						num = 1;
					}
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.FillPath(linearGradientBrush, Chartlet.GetRoundRect((float)rectangle.Left, (float)rectangle.Top, (float)rectangle.Width, (float)rectangle.Height, (float)num, "Full"));
					g.SmoothingMode = SmoothingMode.None;
				}
				else
				{
					g.FillRectangle(linearGradientBrush, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
				}
				linearGradientBrush.Dispose();
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000F0820 File Offset: 0x000EEA20
		private void DrawTips(Graphics g, string tip, int BarLeft, int BarTop, int BarW, int BarH, bool BelowX)
		{
			if (BelowX)
			{
				BarTop = checked(BarTop + BarH + 15);
			}
			SizeF sizeF = g.MeasureString(tip, this.Tips.Font);
			float x;
			if ((float)BarW >= sizeF.Width)
			{
				x = (float)BarLeft + ((float)BarW - sizeF.Width) / 2f;
			}
			else
			{
				x = (float)(checked(BarLeft + BarW)) - sizeF.Width;
			}
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			if (this.ChartType == Chartlet.ChartTypes.Stack)
			{
				string s = tip.ToString();
				Font font = this.Tips.Font;
				Brush brush = new SolidBrush(this.Tips.ForeColor);
				RectangleF layoutRectangle = new RectangleF(x, (float)BarTop, sizeF.Width, sizeF.Height);
				g.DrawString(s, font, brush, layoutRectangle, stringFormat);
			}
			else
			{
				string s2 = tip.ToString();
				Font font2 = this.Tips.Font;
				Brush brush2 = new SolidBrush(this.Tips.ForeColor);
				RectangleF layoutRectangle = new RectangleF(x, (float)(checked(BarTop - 14)), sizeF.Width, sizeF.Height);
				g.DrawString(s2, font2, brush2, layoutRectangle, stringFormat);
			}
			stringFormat.Dispose();
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x000F0924 File Offset: 0x000EEB24
		private static void DrawXLine(Graphics g, Pen BackPen, int DP3, int ChartTop, int ChartH, int XPos, int XWidth)
		{
			g.SmoothingMode = SmoothingMode.AntiAlias;
			checked
			{
				g.DrawLine(BackPen, XPos, ChartTop + ChartH, XPos, ChartTop);
				g.DrawLine(BackPen, XPos - DP3, ChartTop + ChartH + DP3, XPos, ChartTop + ChartH);
				g.SmoothingMode = SmoothingMode.None;
				g.DrawLine(Pens.Black, XPos - DP3, ChartTop + ChartH - 1 + DP3, XPos - DP3, ChartTop + ChartH + 2 + DP3);
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x000F098C File Offset: 0x000EEB8C
		private void DrawXText(Graphics g, Pen BackPen, string XText, int DP3, int ChartTop, int ChartH, int XPos, int XWidth)
		{
			StringFormat stringFormat = new StringFormat();
			g.TextRenderingHint = TextRenderingHint.AntiAlias;
			checked
			{
				if (this.XLabels.RotateAngle > 0f)
				{
					stringFormat.Alignment = StringAlignment.Near;
					g.TranslateTransform((float)(XPos - DP3), (float)(ChartTop + ChartH + 1 + DP3));
					g.RotateTransform(this.XLabels.RotateAngle);
					g.DrawString(XText, this.XLabels.Font, new SolidBrush(this.XLabels.ForeColor), 0f, 0f, stringFormat);
					g.ResetTransform();
					g.TranslateTransform((float)this.dx, (float)this.dy);
				}
				else
				{
					stringFormat.Alignment = StringAlignment.Center;
					Font font = this.XLabels.Font;
					Brush brush = new SolidBrush(this.XLabels.ForeColor);
					Rectangle r = new Rectangle(XPos - XWidth / 2 - DP3, ChartTop + DP3 + ChartH + 1, XWidth + 1, (int)Math.Round(Math.Truncate((double)g.MeasureString(XText, this.XLabels.Font).Width)));
					g.DrawString(XText, font, brush, r, stringFormat);
				}
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000F0AAC File Offset: 0x000EECAC
		private void DrawAxisUnit(Graphics g, int ChartLeft, int ChartTop, int ChartW, int ChartH)
		{
			g.TextRenderingHint = TextRenderingHint.AntiAlias;
			checked
			{
				if (this.XLabels.UnitText != null && this.XLabels.Show)
				{
					g.DrawString(this.XLabels.UnitText, this.XLabels.UnitFont, new SolidBrush(this.XLabels.ForeColor), (float)(ChartW + ChartLeft), (float)(ChartH + ChartTop));
				}
				if (this.YLabels.UnitText != null && this.YLabels.Show)
				{
					g.DrawString(this.YLabels.UnitText, this.YLabels.UnitFont, new SolidBrush(this.YLabels.ForeColor), 2f, (float)(ChartTop - 25));
				}
			}
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000F0B60 File Offset: 0x000EED60
		private void DrawYLine(Graphics g, Pen BackPen, string Text, int DP3, int ChartLeft, int ChartTop, int ChartW, int YPos, int YHeight)
		{
			StringFormat stringFormat = new StringFormat();
			g.TextRenderingHint = TextRenderingHint.AntiAlias;
			checked
			{
				g.DrawLine(new Pen(Color.FromArgb(255, 220, 220, 220)), ChartLeft, YPos, ChartLeft + ChartW, YPos);
				g.DrawLine(Pens.Black, ChartLeft - 3, YPos, ChartLeft, YPos);
				if (this.YLabels.Show)
				{
					Font font = this.YLabels.Font;
					Brush brush = new SolidBrush(this.YLabels.ForeColor);
					Rectangle r = new Rectangle(0, YPos - 10, ChartLeft - 4, 20);
					g.DrawString(Text, font, brush, r, stringFormat);
				}
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000F0C10 File Offset: 0x000EEE10
		private static void DrawLine2D(Graphics g, Pen LinePen, float x1, float y1, float x2, float y2)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(x1, y1, x2, y2);
			g.DrawPath(LinePen, graphicsPath);
			graphicsPath.Dispose();
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000F0C40 File Offset: 0x000EEE40
		private void DrawLineConnection3D(Graphics g, Pen LinePen, SolidBrush LineBrush, int Depth, float halfRadius, float x, float y, int pos)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			if (this.LineConnectionType == Chartlet.LineConnectionTypes.Square)
			{
				graphicsPath.Reset();
				graphicsPath.StartFigure();
				graphicsPath.AddLine(x - halfRadius, y - halfRadius, x - halfRadius - (float)Depth, y - halfRadius + (float)Depth);
				graphicsPath.AddLine(x - halfRadius - (float)Depth, y - halfRadius + (float)Depth, x + halfRadius - (float)Depth, y - halfRadius + (float)Depth);
				graphicsPath.AddLine(x + halfRadius - (float)Depth, y - halfRadius + (float)Depth, x + halfRadius, y - halfRadius);
				graphicsPath.AddLine(x + halfRadius, y - halfRadius, x - halfRadius, y - halfRadius);
				graphicsPath.StartFigure();
				graphicsPath.AddLine(x - halfRadius - (float)Depth, y - halfRadius + (float)Depth, x + halfRadius - (float)Depth, y - halfRadius + (float)Depth);
				graphicsPath.AddLine(x + halfRadius - (float)Depth, y - halfRadius + (float)Depth, x + halfRadius - (float)Depth, y + halfRadius + (float)Depth);
				graphicsPath.AddLine(x + halfRadius - (float)Depth, y + halfRadius + (float)Depth, x - halfRadius - (float)Depth, y + halfRadius + (float)Depth);
				graphicsPath.AddLine(x - halfRadius - (float)Depth, y + halfRadius + (float)Depth, x - halfRadius - (float)Depth, y - halfRadius + (float)Depth);
				graphicsPath.StartFigure();
				graphicsPath.AddLine(x + halfRadius - (float)Depth, y - halfRadius + (float)Depth, x + halfRadius, y - halfRadius);
				graphicsPath.AddLine(x + halfRadius, y - halfRadius, x + halfRadius, y + halfRadius);
				graphicsPath.AddLine(x + halfRadius, y + halfRadius, x + halfRadius - (float)Depth, y + halfRadius + (float)Depth);
				graphicsPath.AddLine(x + halfRadius - (float)Depth, y + halfRadius + (float)Depth, x + halfRadius - (float)Depth, y - halfRadius + (float)Depth);
				g.FillPath(LineBrush, graphicsPath);
				g.DrawPath(LinePen, graphicsPath);
			}
			else if (this.LineConnectionType == Chartlet.LineConnectionTypes.Round)
			{
				graphicsPath.Reset();
				checked
				{
					graphicsPath.AddArc((int)Math.Round(Math.Truncate((double)(unchecked(x - halfRadius)))), (int)Math.Round(Math.Truncate((double)(unchecked(y - halfRadius)))), this.LineConnectionRadius, this.LineConnectionRadius, 225f, 180f);
					PointF pointF = graphicsPath.PathPoints[0];
					PointF pointF2 = graphicsPath.PathPoints[graphicsPath.PathPoints.Length - 1];
					PointF pt = pointF;
					SizeF sz = new SizeF((float)(-1 * Depth), (float)Depth);
					PointF pt2 = pt + sz;
					PointF pt3 = pointF2;
					sz = new SizeF((float)(-1 * Depth), (float)Depth);
					PointF pt4 = pt3 + sz;
					Color[] colors = new Color[]
					{
						this.BarPenColor[pos % 12],
						Color.White,
						this.BarPenColor[pos % 12]
					};
					float[] positions = new float[]
					{
						0f,
						0.3f,
						1f
					};
					ColorBlend colorBlend = new ColorBlend();
					colorBlend.Colors = colors;
					colorBlend.Positions = positions;
					LinearGradientBrush linearGradientBrush = new LinearGradientBrush(pointF, pointF2, Color.Red, Color.Red);
					linearGradientBrush.InterpolationColors = colorBlend;
					graphicsPath.Reset();
					graphicsPath.StartFigure();
					graphicsPath.AddArc((int)Math.Round(Math.Truncate((double)(unchecked(x - halfRadius)))), (int)Math.Round(Math.Truncate((double)(unchecked(y - halfRadius)))), this.LineConnectionRadius, this.LineConnectionRadius, 225f, 180f);
					graphicsPath.AddLine(pointF2, pt4);
					graphicsPath.AddArc((int)Math.Round(Math.Truncate((double)(unchecked(x - halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y - halfRadius + (float)Depth)))), this.LineConnectionRadius, this.LineConnectionRadius, 225f, 180f);
					graphicsPath.AddLine(pt2, pointF);
					g.FillPath(linearGradientBrush, graphicsPath);
					g.DrawPath(LinePen, graphicsPath);
					linearGradientBrush.Dispose();
					graphicsPath.Reset();
					graphicsPath.StartFigure();
					graphicsPath.AddEllipse((int)Math.Round(Math.Truncate((double)(unchecked(x - halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y - halfRadius + (float)Depth)))), this.LineConnectionRadius, this.LineConnectionRadius);
					g.FillPath(new SolidBrush(Color.FromArgb(255, this.BarPenColor[pos % 12])), graphicsPath);
					g.DrawPath(LinePen, graphicsPath);
				}
			}
			g.DrawPath(LinePen, graphicsPath);
			graphicsPath.Dispose();
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000F10F4 File Offset: 0x000EF2F4
		private void DrawLineSurface3D(Graphics g, Pen LinePen, SolidBrush LineBrush, int Depth, float halfRadius, float x1, float y1, float x2, float y2)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.Reset();
			graphicsPath.AddLine(x1 + halfRadius, y1, x1 + halfRadius - (float)Depth, y1 + (float)Depth);
			graphicsPath.AddLine(x1 + halfRadius - (float)Depth, y1 + (float)Depth, x2 - halfRadius - (float)Depth, y2 + (float)Depth);
			graphicsPath.AddLine(x2 - halfRadius - (float)Depth, y2 + (float)Depth, x2 - halfRadius, y2);
			graphicsPath.AddLine(x2 - halfRadius, y2, x1 + halfRadius, y1);
			g.FillPath(LineBrush, graphicsPath);
			if (this.Crystal.Enable)
			{
				this.DrawLineSurfaceCrystal3D(g, graphicsPath, Depth, halfRadius, x1, y1, x2, y2);
			}
			g.DrawPath(LinePen, graphicsPath);
			graphicsPath.Dispose();
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x000F11B4 File Offset: 0x000EF3B4
		private void DrawLineSurfaceCrystal3D(Graphics g, GraphicsPath gpls, int Depth, float halfRadius, float x1, float y1, float x2, float y2)
		{
			checked
			{
				Point point;
				Point point2;
				if (this.Crystal.Direction == Chartlet.Direction.LeftRight)
				{
					point = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y1 + (float)Depth)))));
					point2 = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x2 - halfRadius)))), (int)Math.Round(Math.Truncate((double)y2)));
				}
				else if (this.Crystal.Direction == Chartlet.Direction.RightLeft)
				{
					point2 = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y1 + (float)Depth)))));
					point = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x2 - halfRadius)))), (int)Math.Round(Math.Truncate((double)y2)));
				}
				else if (this.Crystal.Direction == Chartlet.Direction.TopBottom)
				{
					point = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius)))), (int)Math.Round(Math.Truncate((double)y1)));
					point2 = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y1 + (float)Depth)))));
				}
				else
				{
					point2 = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius)))), (int)Math.Round(Math.Truncate((double)y1)));
					point = new Point((int)Math.Round(Math.Truncate((double)(unchecked(x1 + halfRadius - (float)Depth)))), (int)Math.Round(Math.Truncate((double)(unchecked(y1 + (float)Depth)))));
				}
				LinearGradientBrush brush = new LinearGradientBrush(point, point2, Color.FromArgb(178, Color.White), Color.FromArgb(25, Color.White));
				g.FillPath(brush, gpls);
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000F136C File Offset: 0x000EF56C
		private void WriteSrcipt(float x, float y, decimal value)
		{
			if (String.Compare(this.StrBarL, "", false) == 0)
			{
				this.StrBarL = "" + Convert.ToString(x - (float)(checked(this.LineConnectionRadius + 4) / 2));
				this.StrBarW = "" + Convert.ToString(checked(this.LineConnectionRadius + 4));
				this.StrBarT = "" + Convert.ToString(y - (float)(checked(this.LineConnectionRadius + 4) / 2));
				this.StrBarH = "" + Convert.ToString(checked(this.LineConnectionRadius + 4));
				this.StrBarV = "" + Convert.ToString(value);
			}
			else
			{
				this.StrBarL = this.StrBarL + "," + Convert.ToString(x - (float)(checked(this.LineConnectionRadius + 4) / 2));
				this.StrBarW = this.StrBarW + "," + Convert.ToString(checked(this.LineConnectionRadius + 4));
				this.StrBarT = this.StrBarT + "," + Convert.ToString(y - (float)(checked(this.LineConnectionRadius + 4) / 2));
				this.StrBarH = this.StrBarH + "," + Convert.ToString(checked(this.LineConnectionRadius + 4));
				this.StrBarV = this.StrBarV + "," + Convert.ToString(value);
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x000F14DC File Offset: 0x000EF6DC
		private void ShiftColor(int ShiftSteps, string FillorStroke)
		{
			Color[] array = new Color[12];
			if (String.Compare(FillorStroke, "Fill", false) == 0)
			{
				array = this.BarBrushColor;
			}
			else if (String.Compare(FillorStroke, "Stroke", false) == 0)
			{
				array = this.BarPenColor;
			}
			ShiftSteps %= 12;
			int num = 0;
			checked
			{
				int num2 = ShiftSteps - 1;
				for (int i = num; i <= num2; i++)
				{
					Color color = array[0];
					int num3 = 0;
					int num4 = array.Length - 2;
					for (int j = num3; j <= num4; j++)
					{
						array[j] = array[j + 1];
					}
					array[array.Length - 1] = color;
				}
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000F1584 File Offset: 0x000EF784
		private void PaintBackground(Graphics g, int ChartLeft, int ChartTop, int ChartW, int ChartH)
		{
			int width = this.Width;
			int height = this.Height;
			checked
			{
				g.FillRectangle(new SolidBrush(this.Background.Paper), 0, 0, width + this.InflateRight + this.InflateLeft, height + this.InflateBottom + this.InflateTop);
				g.TextRenderingHint = TextRenderingHint.AntiAlias;
				if (this.ShowCopyright)
				{
					g.DrawString(this.CopyrightText, new Font("Arial", 12f, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Gray, (float)(width - 130), 0f);
				}
				Color highlight = this.Background.Highlight;
				Color lowlight = this.Background.Lowlight;
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Far;
				stringFormat.LineAlignment = StringAlignment.Center;
				if (this.ChartType != Chartlet.ChartTypes.HBar)
				{
					int num = 0;
					int num2 = this.YLabels.LabelCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i % 2 == 0)
						{
							g.FillRectangle(new SolidBrush(highlight), ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount, ChartW, ChartH / this.YLabels.LabelCount);
							g.DrawRectangle(new Pen(lowlight), ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount, ChartW - 1, ChartH / this.YLabels.LabelCount - 1);
						}
					}
					int num3 = 0;
					int labelCount = this.YLabels.LabelCount;
					for (int j = num3; j <= labelCount; j++)
					{
						if (this.YLabels.Show)
						{
							string s = (unchecked(this.MinData + (this.MaxData - this.MinData) * (float)(checked(this.YLabels.LabelCount - j)) / (float)this.YLabels.LabelCount)).ToString(this.YLabels.ValueFormat);
							Font font = this.YLabels.Font;
							Brush brush = new SolidBrush(this.YLabels.ForeColor);
							Rectangle r = new Rectangle(0, ChartTop + ChartH * j / this.YLabels.LabelCount - 10, ChartLeft - 4, 20);
							g.DrawString(s, font, brush, r, stringFormat);
						}
						if (j > 0)
						{
							g.DrawLine(Pens.Black, ChartLeft - 3, ChartTop + ChartH * j / this.YLabels.LabelCount, ChartLeft, ChartTop + ChartH * j / this.YLabels.LabelCount);
						}
					}
					if (this.SpecLine.Show)
					{
						Brush brush2;
						if (this.SpecLine.EnableTexture)
						{
							brush2 = new HatchBrush(this.SpecLine.TextureStyle, this.SpecLine.Color);
						}
						else
						{
							brush2 = new SolidBrush(this.SpecLine.Color);
						}
						Pen pen = new Pen(brush2, (float)this.SpecLine.Width);
						g.DrawLine(pen, (float)(ChartLeft - 3), unchecked((float)(checked(ChartTop + ChartH)) - (float)(checked(ChartH * this.SpecLine.LowLimit)) / (this.MaxData - this.MinData)), (float)(ChartLeft + ChartW), unchecked((float)(checked(ChartTop + ChartH)) - (float)(checked(ChartH * this.SpecLine.LowLimit)) / (this.MaxData - this.MinData)));
						g.DrawLine(pen, (float)(ChartLeft - 3), unchecked((float)(checked(ChartTop + ChartH)) - (float)(checked(ChartH * this.SpecLine.HighLimit)) / (this.MaxData - this.MinData)), (float)(ChartLeft + ChartW), unchecked((float)(checked(ChartTop + ChartH)) - (float)(checked(ChartH * this.SpecLine.HighLimit)) / (this.MaxData - this.MinData)));
					}
				}
				if (this.ChartTitle.Show)
				{
					stringFormat.Alignment = StringAlignment.Center;
					string text = this.ChartTitle.Text;
					Font font2 = this.ChartTitle.Font;
					Brush brush3 = new SolidBrush(this.ChartTitle.ForeColor);
					Rectangle r = new Rectangle(ChartLeft, ChartTop - 2 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.ChartTitle.Text, this.ChartTitle.Font).Height)) + this.ChartTitle.OffsetY, ChartW, (int)Math.Round(Math.Truncate((double)g.MeasureString(this.ChartTitle.Text, this.ChartTitle.Font).Height)));
					g.DrawString(text, font2, brush3, r, stringFormat);
				}
				if (this.GroupTitle != null && this.ColorGuider.Show)
				{
					int num4 = 0;
					int num5 = this.GroupTitle.Length - 1;
					for (int k = num4; k <= num5; k++)
					{
						SolidBrush solidBrush;
						switch (this.ChartType)
						{
						case Chartlet.ChartTypes.Bar:
							solidBrush = new SolidBrush(this.BarBrushColor[k % 12]);
							break;
						case Chartlet.ChartTypes.Line:
							solidBrush = new SolidBrush(this.BarPenColor[k % 12]);
							break;
						default:
							solidBrush = new SolidBrush(this.BarBrushColor[k % 12]);
							break;
						}
						switch (this.ChartType)
						{
						case Chartlet.ChartTypes.Bar:
							g.FillRectangle(solidBrush, ChartLeft + ChartW + 6, ChartTop + 14 * k + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, ChartLeft + ChartW + 6, ChartTop + 4 + 14 * k, 17, 7);
							break;
						case Chartlet.ChartTypes.Line:
							g.DrawLine(new Pen(solidBrush), ChartLeft + ChartW + 6, ChartTop + 14 * k + 8, ChartLeft + ChartW + 24, ChartTop + 14 * k + 8);
							if (this.LineConnectionType == Chartlet.LineConnectionTypes.Square)
							{
								g.FillRectangle(solidBrush, ChartLeft + ChartW + 11, ChartTop + 14 * k + 4, 8, 8);
							}
							else if (this.LineConnectionType == Chartlet.LineConnectionTypes.Round)
							{
								g.SmoothingMode = SmoothingMode.AntiAlias;
								g.FillEllipse(solidBrush, ChartLeft + ChartW + 11, ChartTop + 14 * k + 4, 8, 8);
							}
							break;
						default:
							g.FillRectangle(solidBrush, ChartLeft + ChartW + 6, ChartTop + 14 * k + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, ChartLeft + ChartW + 6, ChartTop + 4 + 14 * k, 17, 7);
							break;
						}
						g.TextRenderingHint = TextRenderingHint.AntiAlias;
						g.DrawString(this.GroupTitle[k], this.ColorGuider.Font, new SolidBrush(this.ColorGuider.ForeColor), (float)(ChartLeft + ChartW + 28), (float)(ChartTop + 1 + 14 * k));
						solidBrush.Dispose();
					}
				}
				stringFormat.Dispose();
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000F1BB0 File Offset: 0x000EFDB0
		private void PaintBackground3D(Graphics g, int ChartLeft, int ChartTop, int ChartW, int ChartH)
		{
			int width = this.Width;
			int height = this.Height;
			checked
			{
				g.FillRectangle(new SolidBrush(this.Background.Paper), 0, 0, width + this.InflateRight + this.InflateLeft, height + this.InflateBottom + this.InflateTop);
				g.TextRenderingHint = TextRenderingHint.AntiAlias;
				if (this.ShowCopyright)
				{
					g.DrawString(this.CopyrightText, new Font("Arial", 12f, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Gray, (float)(width - 130), 0f);
				}
				Rectangle rectangle = new Rectangle(ChartLeft, ChartTop, ChartW, ChartH);
				Rectangle rectangle2 = rectangle;
				int depth3D = this.Depth3D;
				rectangle2.Offset(0 - depth3D, depth3D);
				SolidBrush solidBrush = new SolidBrush(this.Background.Highlight);
				Pen pen = new Pen(this.Background.Lowlight);
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.Reset();
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Far;
				stringFormat.LineAlignment = StringAlignment.Center;
				if (this.ChartType != Chartlet.ChartTypes.HBar)
				{
					int num = 0;
					int num2 = this.YLabels.LabelCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i % 2 == 0)
						{
							g.FillRectangle(solidBrush, ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount, ChartW, ChartH / this.YLabels.LabelCount);
							g.DrawRectangle(pen, ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount, ChartW, ChartH / this.YLabels.LabelCount);
							graphicsPath.StartFigure();
							graphicsPath.AddLine(ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount, ChartLeft - depth3D, ChartTop + ChartH * i / this.YLabels.LabelCount + depth3D);
							graphicsPath.AddLine(ChartLeft - depth3D, ChartTop + ChartH * i / this.YLabels.LabelCount + depth3D, ChartLeft - depth3D, ChartTop + ChartH * i / this.YLabels.LabelCount + depth3D + ChartH / this.YLabels.LabelCount);
							graphicsPath.AddLine(ChartLeft - depth3D, ChartTop + ChartH * i / this.YLabels.LabelCount + depth3D + ChartH / this.YLabels.LabelCount, ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount + ChartH / this.YLabels.LabelCount);
							graphicsPath.AddLine(ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount + ChartH / this.YLabels.LabelCount, ChartLeft, ChartTop + ChartH * i / this.YLabels.LabelCount);
						}
					}
					g.FillPath(solidBrush, graphicsPath);
					g.DrawPath(pen, graphicsPath);
					int num3 = 0;
					int labelCount = this.YLabels.LabelCount;
					for (int j = num3; j <= labelCount; j++)
					{
						if (this.YLabels.Show)
						{
							string s = (unchecked(this.MinData + (this.MaxData - this.MinData) * (float)(checked(this.YLabels.LabelCount - j)) / (float)this.YLabels.LabelCount)).ToString(this.YLabels.ValueFormat);
							Font font = this.YLabels.Font;
							Brush brush = new SolidBrush(this.YLabels.ForeColor);
							Rectangle r = new Rectangle(0 - depth3D, ChartTop + ChartH * j / this.YLabels.LabelCount - 10 + depth3D, ChartLeft - 4, 20);
							g.DrawString(s, font, brush, r, stringFormat);
						}
						g.DrawLine(Pens.Black, rectangle2.Left - 3, rectangle2.Top + ChartH * j / this.YLabels.LabelCount, rectangle2.Left, rectangle2.Top + ChartH * j / this.YLabels.LabelCount);
					}
				}
				if (this.ChartTitle.Show)
				{
					stringFormat.Alignment = StringAlignment.Center;
					string text = this.ChartTitle.Text;
					Font font2 = this.ChartTitle.Font;
					Brush brush2 = new SolidBrush(this.ChartTitle.ForeColor);
					Rectangle r = new Rectangle(ChartLeft, ChartTop - 2 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.ChartTitle.Text, this.ChartTitle.Font).Height)) + this.ChartTitle.OffsetY, ChartW, (int)Math.Round(Math.Truncate((double)g.MeasureString(this.ChartTitle.Text, this.ChartTitle.Font).Height)));
					g.DrawString(text, font2, brush2, r, stringFormat);
				}
				if (this.GroupTitle != null && this.ColorGuider.Show)
				{
					int num4 = 0;
					int num5 = this.GroupTitle.Length - 1;
					for (int k = num4; k <= num5; k++)
					{
						SolidBrush solidBrush2;
						switch (this.ChartType)
						{
						case Chartlet.ChartTypes.Bar:
							solidBrush2 = new SolidBrush(this.BarBrushColor[k % 12]);
							break;
						case Chartlet.ChartTypes.Line:
							solidBrush2 = new SolidBrush(this.BarPenColor[k % 12]);
							break;
						default:
							solidBrush2 = new SolidBrush(this.BarBrushColor[k % 12]);
							break;
						}
						switch (this.ChartType)
						{
						case Chartlet.ChartTypes.Bar:
							g.FillRectangle(solidBrush2, ChartLeft + ChartW + 6, ChartTop + 14 * k + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, ChartLeft + ChartW + 6, ChartTop + 4 + 14 * k, 17, 7);
							break;
						case Chartlet.ChartTypes.Line:
							g.DrawLine(new Pen(solidBrush2), ChartLeft + ChartW + 6, ChartTop + 14 * k + 8, ChartLeft + ChartW + 24, ChartTop + 14 * k + 8);
							if (this.LineConnectionType == Chartlet.LineConnectionTypes.Square)
							{
								g.FillRectangle(solidBrush2, ChartLeft + ChartW + 11, ChartTop + 14 * k + 4, 8, 8);
							}
							else if (this.LineConnectionType == Chartlet.LineConnectionTypes.Round)
							{
								g.SmoothingMode = SmoothingMode.AntiAlias;
								g.FillEllipse(solidBrush2, ChartLeft + ChartW + 11, ChartTop + 14 * k + 4, 8, 8);
							}
							break;
						default:
							g.FillRectangle(solidBrush2, ChartLeft + ChartW + 6, ChartTop + 14 * k + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, ChartLeft + ChartW + 6, ChartTop + 4 + 14 * k, 17, 7);
							break;
						}
						g.TextRenderingHint = TextRenderingHint.AntiAlias;
						g.DrawString(this.GroupTitle[k], this.ColorGuider.Font, new SolidBrush(this.ColorGuider.ForeColor), (float)(ChartLeft + ChartW + 28), (float)(ChartTop + 1 + 14 * k));
						solidBrush2.Dispose();
					}
				}
				stringFormat.Dispose();
				g.DrawRectangle(Pens.Gray, rectangle);
				graphicsPath.Reset();
				graphicsPath.StartFigure();
				graphicsPath.AddLine(rectangle.Left, rectangle.Top, rectangle2.Left, rectangle2.Top);
				graphicsPath.AddLine(rectangle2.Left, rectangle2.Top, rectangle2.Left, rectangle2.Top + rectangle2.Height);
				graphicsPath.AddLine(rectangle2.Left, rectangle2.Top + rectangle2.Height, rectangle.Left, rectangle.Top + rectangle.Height);
				graphicsPath.AddLine(rectangle.Left, rectangle.Top + rectangle.Height, rectangle.Left, rectangle.Top);
				graphicsPath.StartFigure();
				graphicsPath.AddLine(rectangle.Left, rectangle.Top + rectangle.Height, rectangle2.Left, rectangle2.Top + rectangle2.Height);
				graphicsPath.AddLine(rectangle2.Left, rectangle2.Top + rectangle2.Height, rectangle2.Left + rectangle2.Width, rectangle2.Top + rectangle2.Height);
				graphicsPath.AddLine(rectangle2.Left + rectangle2.Width, rectangle2.Top + rectangle2.Height, rectangle.Left + rectangle.Width, rectangle.Top + rectangle.Height);
				graphicsPath.AddLine(rectangle.Left + rectangle.Width, rectangle.Top + rectangle.Height, rectangle.Left, rectangle.Top + rectangle.Height);
				g.DrawPath(Pens.Gray, graphicsPath);
				graphicsPath.Dispose();
				solidBrush.Dispose();
				pen.Dispose();
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000F2418 File Offset: 0x000F0618
		private void DrawPieChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				g.FillRectangle(new SolidBrush(this.Background.Paper), 0, 0, num + this.InflateRight, num2 + this.InflateBottom);
				g.TextRenderingHint = TextRenderingHint.AntiAlias;
				if (this.ShowCopyright)
				{
					g.DrawString(this.CopyrightText, new Font("Arial", 12f, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Gray, (float)(num - 130), 0f);
				}
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请先用BindChartData函数绑定数据源!";
				}
				StringFormat stringFormat = new StringFormat();
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Center;
				if (this.ChartTitle.Show)
				{
					string text = this.ChartTitle.Text;
					Font font = this.ChartTitle.Font;
					Brush brush = new SolidBrush(this.ChartTitle.ForeColor);
					Rectangle rectangle = new Rectangle(num3 + num7 / 2 - 160, num4 - 40, 300, 40);
					g.DrawString(text, font, brush, rectangle, stringFormat);
				}
				if (this.DataBound)
				{
					if (this.AxisX != null && this.ColorGuider.Show)
					{
						int num9 = 0;
						int num10 = this.MinCount - 1;
						for (int i = num9; i <= num10; i++)
						{
							SolidBrush solidBrush = new SolidBrush(this.BarBrushColor[i % 12]);
							g.FillRectangle(solidBrush, num3 + num7 + 6 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2))), num4 + 14 * i + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, num3 + num7 + 6 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2))), num4 + 4 + 14 * i, 17, 7);
							g.TextRenderingHint = TextRenderingHint.AntiAlias;
							g.DrawString(this.AxisX[i], this.ColorGuider.Font, new SolidBrush(this.ColorGuider.ForeColor), (float)(num3 + num7 + 28 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2)))), (float)(num4 + 1 + 14 * i));
							solidBrush.Dispose();
						}
					}
					float sum = Chartlet.GetSum(this.RawDatas[0]);
					int num11 = 0;
					int num12 = this.RawDatas[0].Length - 1;
					for (int j = num11; j <= num12; j++)
					{
						this.IntDatas[0][j] = Convert.ToSingle(this.RawDatas[0][j]) / sum;
					}
					g.SmoothingMode = SmoothingMode.AntiAlias;
					int num13;
					int num14;
					int num15;
					int num16;
					if (num7 > num8)
					{
						num13 = num8;
						num14 = num13;
						num15 = num3 + (num7 - num8) / 2;
						num16 = num4;
					}
					else
					{
						num13 = num7;
						num14 = num13;
						num15 = num3;
						num16 = num4 + (num8 - num7) / 2;
					}
					Rectangle rect = new Rectangle(num15, num16, num13, num14);
					rect.Inflate(-10, -10);
					float num17 = (float)(num15 + num13 / 2);
					float num18 = (float)(num16 + num14 / 2);
					float num19 = (float)num16;
					float num20 = (float)num15;
					float num21 = (float)num16;
					float num22 = 0f;
					int num23 = 0;
					if (this.Tips.Show)
					{
						num23 = 10;
					}
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					int num24 = 0;
					int num25 = this.IntDatas[0].Length - 1;
					for (int k = num24; k <= num25; k++)
					{
						g.SmoothingMode = SmoothingMode.AntiAlias;
						SolidBrush solidBrush2 = new SolidBrush(this.BarBrushColor[k % 12]);
						Pen pen;
						if (this.Stroke.TextureEnable)
						{
							HatchStyle textureStyle = this.Stroke.TextureStyle;
							pen = new Pen(new HatchBrush(textureStyle, this.BarPenColor[0], Color.Black), (float)this.Stroke.Width);
						}
						else
						{
							pen = new Pen(this.BarPenColor[0], (float)this.Stroke.Width);
						}
						unchecked
						{
							g.FillPie(solidBrush2, rect, num22, this.IntDatas[0][k] * 360f);
							if (this.Stroke.Width > 0)
							{
								g.DrawPie(pen, rect, num22, this.IntDatas[0][k] * 360f);
							}
							float num26 = num18 + (float)Math.Sin((double)(num22 + this.IntDatas[0][k] * 180f) * 3.1415926535897931 / 180.0) * (float)rect.Width / 2f;
							float num27 = num26;
							float num28 = num17 + (float)Math.Cos((double)(num22 + this.IntDatas[0][k] * 180f) * 3.1415926535897931 / 180.0) * (float)rect.Width / 2f;
							float num29;
							if (num22 + this.IntDatas[0][k] * 180f > 90f && num22 + this.IntDatas[0][k] * 180f < 270f)
							{
								num29 = (float)(checked(num15 - 40 - 50));
								if ((Math.Abs(num26 - num19) < (float)(checked(16 + num23)) || Math.Abs(num27 - num21) < (float)(checked(16 + num23))) && Math.Abs(num29 - num20) < (float)(num7 / 2))
								{
									num26 = num19 - 16f + (float)num23;
								}
								if (this.IntDatas[0][k] * 180f < 360f)
								{
									g.DrawLine(Pens.Gray, num28 - 2f, num27, num29 + 85f, num26);
								}
							}
							else
							{
								num29 = (float)(checked(num15 + num13 + 10));
								if ((Math.Abs(num26 - num19) < (float)(checked(16 + num23)) || Math.Abs(num27 - num21) < (float)(checked(16 + num23))) && Math.Abs(num29 - num20) < (float)(num7 / 2))
								{
									num26 = num19 + 16f + (float)num23;
								}
								if (this.IntDatas[0][k] * 180f < 360f)
								{
									g.DrawLine(Pens.Gray, num28 + 2f, num27, num29 - 2f, num26);
								}
							}
							g.TextRenderingHint = TextRenderingHint.AntiAlias;
							string text2 = "";
							if (this.Tips.Show)
							{
								text2 = this.AxisX[k] + "\n" + Convert.ToString(this.RawDatas[0][k]) + " ";
							}
							text2 = text2 + (this.IntDatas[0][k] * 100f).ToString("0.00") + "%";
							if (this.IntDatas[0][k] * 180f < 360f)
							{
								g.DrawString(text2, this.Tips.Font, new SolidBrush(this.Tips.ForeColor), num29, num26 - 6f - 5f);
							}
							else
							{
								g.DrawString(text2, this.Tips.Font, new SolidBrush(this.Tips.ForeColor), num28 - 50f - (float)num23, num27 - 6f - 5f);
							}
							num19 = num26;
							num20 = num29;
							num21 = num27;
							num22 += this.IntDatas[0][k] * 360f;
							pen.Dispose();
							solidBrush2.Dispose();
						}
					}
					if (this.Crystal.Enable)
					{
						g.SmoothingMode = SmoothingMode.AntiAlias;
						if (this.Crystal.CoverFull)
						{
							g.SmoothingMode = SmoothingMode.AntiAlias;
							Rectangle rect2 = new Rectangle(rect.Left - rect.Width / 4, rect.Top - rect.Height / 4, rect.Width, rect.Height);
							GraphicsPath graphicsPath = new GraphicsPath();
							graphicsPath.AddEllipse(rect2);
							PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
							pathGradientBrush.CenterColor = Color.FromArgb(165, Color.White);
							pathGradientBrush.SurroundColors = new Color[]
							{
								Color.FromArgb(0, Color.White)
							};
							Region region = new Region(graphicsPath);
							g.SetClip(region, CombineMode.Intersect);
							graphicsPath = new GraphicsPath();
							graphicsPath.AddEllipse(rect);
							region = new Region(graphicsPath);
							g.SetClip(region, CombineMode.Intersect);
							g.FillEllipse(pathGradientBrush, rect2);
							pathGradientBrush.Dispose();
							region.Dispose();
							graphicsPath.Dispose();
							g.SmoothingMode = SmoothingMode.None;
						}
						else
						{
							Rectangle rect3 = new Rectangle(rect.Left + rect.Width / 6, rect.Top + 3, rect.Width * 2 / 3, rect.Height / 2 - 3);
							Point point = new Point(rect3.Left, rect3.Top);
							Point point2 = point;
							Point point3 = new Point(rect3.Left, rect3.Top + rect3.Height + 1);
							LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point2, point3, Color.FromArgb(230, Color.White), Color.FromArgb(0, Color.White));
							g.FillEllipse(linearGradientBrush, rect3);
							linearGradientBrush.Dispose();
							Rectangle rect4 = new Rectangle(rect.Left, rect.Top + rect.Height / 2 + 1, rect.Width, rect.Height / 2 + 1);
							point3 = new Point(rect4.Left, rect4.Top + rect4.Height);
							Point point4 = point3;
							point = new Point(rect4.Left, rect4.Top);
							LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(point4, point, Color.FromArgb(230, Color.White), Color.FromArgb(0, Color.White));
							GraphicsPath graphicsPath2 = new GraphicsPath();
							rect.Inflate(1, 1);
							graphicsPath2.AddEllipse(rect);
							Region region2 = new Region(graphicsPath2);
							g.SetClip(region2, CombineMode.Replace);
							g.FillRectangle(linearGradientBrush2, rect4);
							Rectangle rectangle = new Rectangle(0, 0, num, num2);
							g.SetClip(rectangle);
							graphicsPath2.Dispose();
							region2.Dispose();
							linearGradientBrush2.Dispose();
						}
						g.SmoothingMode = SmoothingMode.None;
					}
				}
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000F2ED4 File Offset: 0x000F10D4
		private void DrawBarsChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.YLabels.Show)
				{
					num7 += 48;
					num3 -= 48;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请先用BindChartData绑定数据源!";
				}
				int num9 = 0;
				int alpha;
				if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					num9 = (int)Math.Round(Math.Truncate(unchecked((double)this.Depth3D * 0.85)));
					this.PaintBackground3D(g, num3, num4, num7, num8);
					alpha = (int)this.Alpha3D;
				}
				else
				{
					this.PaintBackground(g, num3, num4, num7, num8);
					alpha = 255;
				}
				if (this.DataBound)
				{
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					Pen pen = new Pen(Color.FromArgb(255, 220, 220, 220));
					int groupSize = this.GroupSize;
					int maxCount = this.MaxCount;
					if (maxCount > 0)
					{
						int num10;
						int num11;
						if (!this.AutoBarWidth && maxCount * groupSize < 12)
						{
							num10 = num7 / 4 / 16;
							num11 = 5 * num10;
						}
						else
						{
							num11 = (int)Math.Round(Math.Truncate((double)(num7 / maxCount) / unchecked(0.25 + (double)groupSize)));
							num10 = (int)Math.Round(Math.Truncate(unchecked(0.25 * (double)num11)));
						}
						int num12 = 0;
						int num13 = maxCount - 1;
						for (int i = num12; i <= num13; i++)
						{
							int num14 = i;
							int num15 = num3 + num11 * num14 * this.GroupSize + num10 * (num14 + 1);
							int dp = (int)Math.Round(Math.Truncate((double)num9 / 0.85));
							Chartlet.DrawXLine(g, pen, dp, num4, num8, num15 + num11 * groupSize / 2, num11 * groupSize + num10);
							if (this.XLabels.Show && i % this.XLabels.SampleSize == 0)
							{
								this.DrawXText(g, pen, this.AxisX[i], dp, num4, num8, num15 + num11 * groupSize / 2, num11 * groupSize + num10);
							}
							int num16 = 0;
							int num17 = groupSize - 1;
							for (int j = num16; j <= num17; j++)
							{
								if (decimal.Compare(this.RawDatas[j][i], -0.830213m) != 0)
								{
									int num18 = (int)Math.Round(Math.Truncate((double)(unchecked(this.IntDatas[j][i] - this.BaseLineXInt - 1f))));
									int num19;
									bool belowX;
									if (num18 < 0)
									{
										num18 = -1 * num18;
										num19 = num4 + num8 - (int)Math.Round(Math.Truncate((double)this.BaseLineXInt));
										belowX = true;
									}
									else
									{
										num19 = num4 + num8 - num18 - (int)Math.Round(Math.Truncate((double)this.BaseLineXInt));
										belowX = false;
									}
									SolidBrush barBrush;
									if (groupSize == 1 && this.Colorful)
									{
										if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
										{
											barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[i % 12]));
										}
										else
										{
											barBrush = new SolidBrush(this.BarBrushColor[i % 12]);
										}
									}
									else if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
									{
										barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[j % 12]));
									}
									else
									{
										barBrush = new SolidBrush(this.BarBrushColor[j % 12]);
									}
									Pen pen2;
									if (this.Stroke.TextureEnable)
									{
										HatchStyle textureStyle = this.Stroke.TextureStyle;
										pen2 = new Pen(new HatchBrush(textureStyle, this.BarPenColor[j % 12], Color.Gray), (float)this.Stroke.Width);
									}
									else
									{
										pen2 = new Pen(this.BarPenColor[j % 12], (float)this.Stroke.Width);
									}
									pen2.Alignment = PenAlignment.Inset;
									if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
									{
										this.DrawBarBase3D(g, barBrush, pen2, num15, num19, num11, num18, num9);
									}
									else
									{
										this.DrawBarBase2D(g, barBrush, pen2, num15, num19, num11, num18);
									}
									if (this.Crystal.Enable && num18 - this.Crystal.Contraction * 2 > 2 && num11 - this.Crystal.Contraction * 2 > 2)
									{
										this.DrawBarCrystal(g, num15, num19, num11, num18, num9);
									}
									if (this.Tips.Show)
									{
										this.DrawTips(g, this.RawDatas[j][i].ToString(), num15, num19, num11, num18, belowX);
									}
									if (String.Compare(this.StrBarL, "", false) == 0)
									{
										this.StrBarL = "" + Convert.ToString(num15 - num9);
										this.StrBarW = "" + Convert.ToString(num11);
										this.StrBarT = "" + Convert.ToString(num19 + num9);
										this.StrBarH = "" + Convert.ToString(num18);
										this.StrBarV = "" + Convert.ToString(this.RawDatas[j][i]);
									}
									else
									{
										this.StrBarL = this.StrBarL + "," + Convert.ToString(num15 - num9);
										this.StrBarW = this.StrBarW + "," + Convert.ToString(num11);
										this.StrBarT = this.StrBarT + "," + Convert.ToString(num19 + num9);
										this.StrBarH = this.StrBarH + "," + Convert.ToString(num18);
										this.StrBarV = this.StrBarV + "," + Convert.ToString(this.RawDatas[j][i]);
									}
									num15 += num11;
								}
							}
						}
					}
					pen.Dispose();
				}
				if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
				{
					g.DrawRectangle(Pens.Gray, num3, num4, num7, num8);
					g.DrawLine(Pens.Black, (float)(num3 - 4), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt), (float)(num3 + num7 - 1), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt));
					g.DrawLine(Pens.Black, num3, num4, num3, num4 + num8 + 2);
				}
				this.DrawAxisUnit(g, num3, num4, num7, num8);
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x000F35FC File Offset: 0x000F17FC
		private void DrawStackChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				int groupSize = this.GroupSize;
				int maxCount = this.MaxCount;
				decimal[] array = new decimal[maxCount - 1 + 1];
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.YLabels.Show)
				{
					num7 += 48;
					num3 -= 48;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请先用BindChartData()绑定数据源！";
				}
				else if (this.MinData < 0f)
				{
					this.DataBound = false;
					if (this.ShowErrorInfo)
					{
						this.ChartTitle.Text = "StackBar can not accept value < 0";
					}
				}
				if (this.DataBound)
				{
					int num9 = 0;
					int num10 = this.MaxCount - 1;
					for (int i = num9; i <= num10; i++)
					{
						array[i] = 0m;
						int num11 = 0;
						int num12 = groupSize - 1;
						for (int j = num11; j <= num12; j++)
						{
							decimal[] array2 = array;
							decimal[] array3 = array2;
							int num13 = i;
							array3[num13] = decimal.Add(array2[num13], this.RawDatas[j][i]);
						}
					}
					this.MaxData = Chartlet.GetBond(Chartlet.GetMax(array));
					if (this.MaxValueY != 0.0)
					{
						this.MaxData = (float)this.MaxValueY;
					}
					int num14 = 0;
					int num15 = this.MaxCount - 1;
					for (int k = num14; k <= num15; k++)
					{
						int num16 = 0;
						int num17 = groupSize - 1;
						for (int l = num16; l <= num17; l++)
						{
							this.IntDatas[l][k] = unchecked((Convert.ToSingle(this.RawDatas[l][k]) - (float)this.MinValueY) * (float)num8 / (this.MaxData - (float)this.MinValueY));
						}
					}
				}
				int num18 = 0;
				int alpha;
				if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					num18 = (int)Math.Round(Math.Truncate(unchecked((double)this.Depth3D * 0.85)));
					this.PaintBackground3D(g, num3, num4, num7, num8);
					alpha = (int)this.Alpha3D;
				}
				else
				{
					this.PaintBackground(g, num3, num4, num7, num8);
					alpha = 255;
				}
				if (this.DataBound)
				{
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					Pen pen = new Pen(Color.FromArgb(255, 220, 220, 220));
					groupSize = this.GroupSize;
					maxCount = this.MaxCount;
					if (maxCount > 0)
					{
						int num19;
						int num20;
						if (!this.AutoBarWidth && maxCount < 12)
						{
							num19 = num7 / 4 / 16;
							num20 = 5 * num19;
						}
						else
						{
							num20 = (int)Math.Round(Math.Truncate((double)(num7 / maxCount) / 1.25));
							num19 = (int)Math.Round(Math.Truncate(unchecked((double)num20 * 0.25)));
						}
						int num21 = 0;
						int num22 = maxCount - 1;
						for (int m = num21; m <= num22; m++)
						{
							int num23 = m;
							int num24 = num3 + num20 * num23 + num19 * (num23 + 1);
							int num25 = 0;
							int num26 = (int)Math.Round(Math.Truncate((double)num18 / 0.85));
							g.SmoothingMode = SmoothingMode.AntiAlias;
							Chartlet.DrawXLine(g, pen, num26, num4, num8, num24 + num20 / 2, num20 + num19);
							if (this.XLabels.Show && m % this.XLabels.SampleSize == 0)
							{
								this.DrawXText(g, pen, this.AxisX[m], num26, num4, num8, num24 + num20 / 2, num20 + num19);
							}
							int num27 = 0;
							int num28 = groupSize - 1;
							for (int n = num27; n <= num28; n++)
							{
								if (decimal.Compare(this.RawDatas[n][m], -0.830213m) != 0)
								{
									int num29 = (int)Math.Round(Math.Truncate((double)this.IntDatas[n][m])) - 1;
									int num30 = num4 + num8 - num29 - num25;
									SolidBrush barBrush;
									if (groupSize == 1 && this.Colorful)
									{
										barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[m % 12]));
									}
									else
									{
										barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[n % 12]));
									}
									Pen pen2;
									if (this.Stroke.TextureEnable)
									{
										HatchStyle textureStyle = this.Stroke.TextureStyle;
										pen2 = new Pen(new HatchBrush(textureStyle, this.BarPenColor[n % 12], Color.Gray), (float)this.Stroke.Width);
									}
									else
									{
										pen2 = new Pen(this.BarPenColor[n % 12], (float)this.Stroke.Width);
									}
									pen2.Alignment = PenAlignment.Inset;
									if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
									{
										this.DrawBarBase3D(g, barBrush, pen2, num24, num30, num20, num29, num18);
									}
									else
									{
										this.DrawBarBase2D(g, barBrush, pen2, num24, num30, num20, num29);
									}
									num25 += num29;
									if (this.Crystal.Enable && num29 - this.Crystal.Contraction * 2 > 2 && num20 - this.Crystal.Contraction * 2 > 2)
									{
										this.DrawBarCrystal(g, num24, num30, num20, num29, num18);
									}
									if (this.Tips.Show)
									{
										this.DrawTips(g, this.RawDatas[n][m].ToString(), num24 - num26, num30 + num26, num20, num29, false);
									}
									if (String.Compare(this.StrBarL, "", false) == 0)
									{
										this.StrBarL = "" + Convert.ToString(num24 - num18);
										this.StrBarW = "" + Convert.ToString(num20);
										this.StrBarT = "" + Convert.ToString(num30 + num18);
										this.StrBarH = "" + Convert.ToString(num29);
										this.StrBarV = "" + Convert.ToString(this.RawDatas[n][m]);
									}
									else
									{
										this.StrBarL = this.StrBarL + "," + Convert.ToString(num24 - num18);
										this.StrBarW = this.StrBarW + "," + Convert.ToString(num20);
										this.StrBarT = this.StrBarT + "," + Convert.ToString(num30 + num18);
										this.StrBarH = this.StrBarH + "," + Convert.ToString(num29);
										this.StrBarV = this.StrBarV + "," + Convert.ToString(this.RawDatas[n][m]);
									}
								}
							}
							num24 += num20;
						}
					}
					pen.Dispose();
				}
				if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
				{
					g.DrawRectangle(Pens.Gray, num3, num4, num7, num8);
					g.DrawLine(Pens.Black, num3 - 4, num4 + num8 - 1, num3 + num7 - 1, num4 + num8 - 1);
					g.DrawLine(Pens.Black, num3, num4, num3, num4 + num8 + 2);
				}
				this.DrawAxisUnit(g, num3, num4, num7, num8);
			}
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x000F3DF4 File Offset: 0x000F1FF4
		private void DrawLineChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.YLabels.Show)
				{
					num7 += 48;
					num3 -= 48;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请先用BindChartData()函数绑定数据源!";
				}
				int num9 = 0;
				int dp = 0;
				int alpha;
				if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					num9 = (int)Math.Round(Math.Truncate(unchecked((double)this.Depth3D * 0.85)));
					dp = this.Depth3D;
					this.PaintBackground3D(g, num3, num4, num7, num8);
					alpha = (int)this.Alpha3D;
				}
				else
				{
					this.PaintBackground(g, num3, num4, num7, num8);
					alpha = 255;
				}
				Pen backPen = new Pen(Color.FromArgb(255, 220, 220, 220));
				if (this.DataBound)
				{
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					int groupSize = this.GroupSize;
					int maxCount = this.MaxCount;
					if (maxCount > 0)
					{
						int num10 = num7 / maxCount;
						int num11 = 0;
						int num12 = groupSize - 1;
						for (int i = num11; i <= num12; i++)
						{
							SolidBrush solidBrush = new SolidBrush(Color.FromArgb(alpha, this.BarPenColor[i % 12]));
							Pen pen;
							if (this.Stroke.TextureEnable)
							{
								HatchStyle textureStyle = this.Stroke.TextureStyle;
								pen = new Pen(new HatchBrush(textureStyle, this.BarPenColor[i % 12], Color.Black), (float)this.Stroke.Width);
							}
							else
							{
								pen = new Pen(this.BarPenColor[i % 12], (float)this.Stroke.Width);
							}
							GraphicsPath graphicsPath = new GraphicsPath();
							int num13 = num10 / 2;
							num13 += num3;
							int num14 = 0;
							int num15 = maxCount - 2;
							int j;
							for (j = num14; j <= num15; j++)
							{
								if (i == 0)
								{
									Chartlet.DrawXLine(g, backPen, dp, num4, num8, num13, num10);
									if (this.XLabels.Show && j % this.XLabels.SampleSize == 0)
									{
										this.DrawXText(g, backPen, this.AxisX[j], dp, num4, num8, num13, num10);
									}
								}
								if (decimal.Compare(this.RawDatas[i][j], -0.830213m) != 0)
								{
									g.SmoothingMode = SmoothingMode.AntiAlias;
									if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
									{
										if (decimal.Compare(this.RawDatas[i][j + 1], -0.830213m) != 0)
										{
											unchecked
											{
												if (!this.IsRightAngle)
												{
													Chartlet.DrawLine2D(g, pen, (float)num13, (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][checked(j + 1)]);
												}
												else
												{
													Chartlet.DrawLine2D(g, pen, (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][checked(j + 1)]);
													Chartlet.DrawLine2D(g, pen, (float)num13, (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][j]);
												}
											}
										}
									}
									else
									{
										float halfRadius = (float)(this.LineConnectionRadius / 2);
										if (this.LineConnectionType == Chartlet.LineConnectionTypes.None)
										{
											halfRadius = 0f;
										}
										unchecked
										{
											this.DrawLineConnection3D(g, pen, solidBrush, num9, halfRadius, (float)num13, (float)(checked(num4 + num8)) - this.IntDatas[i][j], i);
											if (decimal.Compare(this.RawDatas[i][checked(j + 1)], -0.830213m) != 0)
											{
												if (!this.IsRightAngle)
												{
													this.DrawLineSurface3D(g, pen, solidBrush, num9, halfRadius, (float)num13, (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][checked(j + 1)]);
												}
												else
												{
													this.DrawLineSurface3D(g, pen, solidBrush, num9, halfRadius, (float)num13, (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][j]);
													this.DrawLineSurface3D(g, pen, solidBrush, num9, halfRadius, (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][j], (float)(checked(num13 + num10)), (float)(checked(num4 + num8)) - this.IntDatas[i][checked(j + 1)]);
												}
											}
										}
										if (this.Tips.Show && decimal.Compare(this.RawDatas[i][j], -0.830213m) != 0)
										{
											this.DrawTips(g, this.RawDatas[i][j].ToString(), num13 - num10 / 2, (int)Math.Round(Math.Truncate((double)(unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][j] - (float)(this.LineConnectionRadius / 2))))), num10, (int)Math.Round(Math.Truncate((double)this.IntDatas[i][j])), false);
										}
										this.WriteSrcipt((float)(num13 - num9), unchecked((float)(checked(num4 + num9 + num8)) - this.IntDatas[i][j]), this.RawDatas[i][j]);
									}
								}
								num13 += num10;
							}
							if (i == 0 && i == 0)
							{
								Chartlet.DrawXLine(g, backPen, dp, num4, num8, num13, num10);
								if (this.XLabels.Show && j % this.XLabels.SampleSize == 0)
								{
									this.DrawXText(g, backPen, this.AxisX[j], dp, num4, num8, num13, num10);
								}
							}
							if (this.Dimension == Chartlet.ChartDimensions.Chart3D && decimal.Compare(this.RawDatas[i][j], -0.830213m) != 0)
							{
								float halfRadius2 = (float)(this.LineConnectionRadius / 2);
								if (this.LineConnectionType == Chartlet.LineConnectionTypes.None)
								{
									halfRadius2 = 0f;
								}
								this.DrawLineConnection3D(g, pen, solidBrush, num9, halfRadius2, (float)num13, unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][j]), i);
								if (this.Tips.Show)
								{
									this.DrawTips(g, this.RawDatas[i][j].ToString(), num13 - num10 / 2, (int)Math.Round(Math.Truncate((double)(unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][j] - (float)(this.LineConnectionRadius / 2))))), num10, (int)Math.Round(Math.Truncate((double)this.IntDatas[i][j])), false);
								}
								this.WriteSrcipt((float)(num13 - num9), unchecked((float)(checked(num4 + num9 + num8)) - this.IntDatas[i][j]), this.RawDatas[i][j]);
							}
							pen.Dispose();
							graphicsPath.Dispose();
							if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
							{
								num13 = num10 / 2 + num3;
								Chartlet.LineConnectionTypes lineConnectionType = this.LineConnectionType;
								int lineConnectionRadius = this.LineConnectionRadius;
								if (lineConnectionType == Chartlet.LineConnectionTypes.Round)
								{
									g.SmoothingMode = SmoothingMode.AntiAlias;
								}
								else if (lineConnectionType == Chartlet.LineConnectionTypes.Square)
								{
									g.SmoothingMode = SmoothingMode.None;
								}
								int num16 = 0;
								int num17 = maxCount - 1;
								for (int k = num16; k <= num17; k++)
								{
									if (decimal.Compare(this.RawDatas[i][k], -0.830213m) != 0)
									{
										if (lineConnectionType == Chartlet.LineConnectionTypes.Round)
										{
											g.FillEllipse(solidBrush, (float)(num13 - lineConnectionRadius / 2), unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][k] - (float)(lineConnectionRadius / 2)), (float)lineConnectionRadius, (float)lineConnectionRadius);
										}
										else if (lineConnectionType == Chartlet.LineConnectionTypes.Square)
										{
											g.FillRectangle(solidBrush, (float)(num13 - lineConnectionRadius / 2), unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][k] - (float)(lineConnectionRadius / 2)), (float)lineConnectionRadius, (float)lineConnectionRadius);
										}
										if (this.Tips.Show)
										{
											this.DrawTips(g, this.RawDatas[i][k].ToString(), num13 - num10 / 2, (int)Math.Round(Math.Truncate((double)(unchecked((float)(checked(num4 + num8)) - this.IntDatas[i][k] - (float)(this.LineConnectionRadius / 2))))), num10, (int)Math.Round(Math.Truncate((double)this.IntDatas[i][j])), false);
										}
										this.WriteSrcipt((float)num13, unchecked((float)(checked(num4 + num9 + num8)) - this.IntDatas[i][k]), this.RawDatas[i][k]);
									}
									num13 += num10;
								}
								g.SmoothingMode = SmoothingMode.AntiAlias;
							}
						}
					}
				}
				if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
				{
					g.DrawRectangle(Pens.Gray, num3, num4, num7, num8);
					g.DrawLine(Pens.Black, (float)(num3 - 4), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt), (float)(num3 + num7 - 1), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt));
					g.DrawLine(Pens.Black, num3, num4, num3, num4 + num8 + 2);
				}
				this.DrawAxisUnit(g, num3, num4, num7, num8);
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x000F4830 File Offset: 0x000F2A30
		private void DrawPieChart3D(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				g.FillRectangle(new SolidBrush(this.Background.Paper), 0, 0, num + this.InflateRight, num2 + this.InflateBottom);
				g.TextRenderingHint = TextRenderingHint.AntiAlias;
				if (this.ShowCopyright)
				{
					g.DrawString(this.CopyrightText, new Font("Arial", 12f, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Gray, (float)(num - 130), 0f);
				}
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请先用BindChartData()函数绑定数据源!";
				}
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Far;
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Center;
				if (this.ChartTitle.Show)
				{
					string text = this.ChartTitle.Text;
					Font font = this.ChartTitle.Font;
					Brush brush = new SolidBrush(this.ChartTitle.ForeColor);
					Rectangle r = new Rectangle(num3, -30 + this.ChartTitle.OffsetY, num7, 100);
					g.DrawString(text, font, brush, r, stringFormat);
				}
				if (this.DataBound)
				{
					float sum = Chartlet.GetSum(this.RawDatas[0]);
					if (sum > 0f)
					{
						int num9 = 0;
						int num10 = this.RawDatas[0].Length - 1;
						for (int i = num9; i <= num10; i++)
						{
							this.IntDatas[0][i] = Convert.ToSingle(this.RawDatas[0][i]) / sum;
						}
					}
					else
					{
						int num11 = 0;
						int num12 = this.RawDatas[0].Length - 1;
						for (int j = num11; j <= num12; j++)
						{
							this.IntDatas[0][j] = 0f;
						}
					}
					if (this.AxisX != null && this.ColorGuider.Show)
					{
						int num13 = 0;
						int num14 = this.MinCount - 1;
						for (int k = num13; k <= num14; k++)
						{
							SolidBrush solidBrush = new SolidBrush(this.BarBrushColor[k % 12]);
							g.FillRectangle(solidBrush, num3 + num7 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2))), num4 + 14 * k + 4, 18, 8);
							g.DrawRectangle(Pens.Gray, num3 + num7 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2))), num4 + 4 + 14 * k, 17, 7);
							g.TextRenderingHint = TextRenderingHint.AntiAlias;
							if (sum > 0f && this.IntDatas[0][k] > 0f)
							{
								g.DrawString(this.AxisX[k], this.ColorGuider.Font, new SolidBrush(this.ColorGuider.ForeColor), (float)(num3 + num7 + 22 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2)))), (float)(num4 + 1 + 14 * k));
							}
							else
							{
								g.DrawString(this.AxisX[k] + "(0)", this.ColorGuider.Font, new SolidBrush(this.ColorGuider.ForeColor), (float)(num3 + num7 + 22 + (int)Math.Round(Math.Truncate(unchecked((double)(checked(num - num7)) * 0.2)))), (float)(num4 + 1 + 14 * k));
							}
							solidBrush.Dispose();
						}
					}
					g.SmoothingMode = SmoothingMode.AntiAlias;
					int num15 = 30;
					PointF[] array = new PointF[this.IntDatas[0].Length - 1 + 1];
					PointF[] array2 = new PointF[this.IntDatas[0].Length - 1 + 1];
					float[] array3 = new float[this.IntDatas[0].Length - 1 + 1];
					Rectangle rectangle = new Rectangle(num3, num4, num7, num8);
					rectangle.Inflate((int)Math.Round(Math.Truncate(unchecked((double)(checked(-1 * num7)) * 0.1))), (int)Math.Round(Math.Truncate(unchecked((double)(checked(-1 * num8)) * 0.0))));
					rectangle.Offset((int)Math.Round(Math.Truncate(unchecked((double)(checked(-1 * num7)) * 0.1) / 2.0)), 0);
					Rectangle rect = rectangle;
					rect.Offset(0, 30);
					float num16 = (float)(rectangle.Left + rectangle.Width / 2);
					float num17 = (float)(rectangle.Top + rectangle.Height / 2);
					g.DrawEllipse(Pens.Silver, rect);
					GraphicsPath graphicsPath = new GraphicsPath();
					GraphicsPath graphicsPath2 = new GraphicsPath();
					float num18 = 0f;
					if (sum > 0f)
					{
						int num19 = 0;
						int num20 = this.IntDatas[0].Length - 1;
						for (int l = num19; l <= num20; l++)
						{
							array3[l] = num18;
							if (this.IntDatas[0][l] > 0f)
							{
								graphicsPath.AddArc(rectangle, num18, unchecked(this.IntDatas[0][l] * 360f));
								array[l] = graphicsPath.PathPoints[0];
							}
							else
							{
								if (l != 0)
								{
									if (l != this.IntDatas[0].Length - 1)
									{
										if (this.IntDatas[0][l + 1] > 0f)
										{
											graphicsPath.AddArc(rectangle, num18, unchecked(this.IntDatas[0][checked(l + 1)] * 360f));
											array[l] = graphicsPath.PathPoints[0];
											goto IL_662;
										}
										array[l] = array[l - 1];
										goto IL_662;
									}
								}
								array[l] = new PointF((float)(rectangle.Left + rectangle.Width), (float)(rectangle.Top + rectangle.Height / 2));
							}
							IL_662:
							unchecked
							{
								num18 += this.IntDatas[0][l] * 360f;
								if (array3[l] >= 0f && array3[l] <= 180f)
								{
									graphicsPath2.AddLine(num16, num17, num16, num17 + (float)num15);
									graphicsPath2.AddLine(num16, num17 + (float)num15, array[l].X, array[l].Y + (float)num15);
									graphicsPath2.AddLine(array[l].X, array[l].Y + (float)num15, array[l].X, array[l].Y);
									graphicsPath2.AddLine(array[l].X, array[l].Y, num16, num17);
									g.FillPath(new SolidBrush(Color.FromArgb(200, this.BarBrushColor[l % 12])), graphicsPath2);
									graphicsPath2.Reset();
								}
								graphicsPath.Reset();
							}
						}
						num18 = 0f;
						int num21 = 0;
						int num22 = this.IntDatas[0].Length - 1;
						for (int m = num21; m <= num22; m++)
						{
							array3[m] = num18;
							if (this.IntDatas[0][m] > 0f)
							{
								graphicsPath.AddArc(rectangle, num18, unchecked(this.IntDatas[0][m] * 360f) / 2f);
								array2[m] = graphicsPath.PathPoints[graphicsPath.PathPoints.Length - 1];
							}
							else
							{
								if (m != 0)
								{
									if (m != this.IntDatas[0].Length - 1)
									{
										if (this.IntDatas[0][m + 1] > 0f)
										{
											graphicsPath.AddArc(rectangle, num18, unchecked(this.IntDatas[0][checked(m + 1)] * 360f) / 2f);
											array2[m] = graphicsPath.PathPoints[graphicsPath.PathPoints.Length - 1];
											goto IL_8E3;
										}
										array2[m] = array2[m - 1];
										goto IL_8E3;
									}
								}
								array2[m] = new PointF((float)(rectangle.Left + rectangle.Width), (float)(rectangle.Top + rectangle.Height / 2));
							}
							IL_8E3:
							unchecked
							{
								num18 += this.IntDatas[0][m] * 360f;
								graphicsPath.Reset();
							}
						}
					}
					if (sum > 0f)
					{
						int num23 = 0;
						int num24 = this.IntDatas[0].Length - 1;
						for (int n = num23; n <= num24; n++)
						{
							if (this.IntDatas[0][n] > 0f)
							{
								byte alpha = byte.MaxValue;
								if (n < this.IntDatas[0].Length - 1 && array3[n + 1] <= 180f)
								{
									alpha = 200;
								}
								unchecked
								{
									g.FillPie(new SolidBrush(Color.FromArgb((int)alpha, this.BarBrushColor[n % 12])), rectangle, array3[n], this.IntDatas[0][n] * 360f);
									if (this.Crystal.Enable && this.Crystal.CoverFull && this.IntDatas[0][n] * 360f > 30f && this.IntDatas[0][n] * 360f <= 180f)
									{
										if (n < checked(this.IntDatas[0].Length - 1))
										{
											g.FillPie(new LinearGradientBrush(array[n], array[checked(n + 1)], Color.FromArgb(178, Color.White), Color.FromArgb(25, Color.White)), rectangle, array3[n], this.IntDatas[0][n] * 360f);
										}
										else
										{
											g.FillPie(new LinearGradientBrush(array[n], array[0], Color.FromArgb(128, Color.White), Color.FromArgb(0, Color.White)), rectangle, array3[n], this.IntDatas[0][n] * 360f);
										}
									}
								}
							}
						}
					}
					else
					{
						g.FillPie(new SolidBrush(Color.FromArgb(200, this.BarBrushColor[0])), rectangle, 0f, 360f);
					}
					if (sum > 0f)
					{
						int num25 = 0;
						int num26 = this.IntDatas[0].Length - 1;
						for (int num27 = num25; num27 <= num26; num27++)
						{
							if (this.IntDatas[0][num27] > 0f && array3[num27] < 180f)
							{
								float num28;
								float num29;
								float sweepAngle;
								if (num27 < this.IntDatas[0].Length - 1)
								{
									if (array3[num27 + 1] <= 180f)
									{
										num28 = array[num27 + 1].X;
										num29 = array[num27 + 1].Y;
										sweepAngle = unchecked(array3[checked(num27 + 1)] - array3[num27]);
									}
									else
									{
										num28 = (float)rectangle.Left;
										num29 = (float)(rectangle.Top + rectangle.Height / 2);
										sweepAngle = unchecked(180f - array3[num27]);
									}
								}
								else
								{
									num28 = (float)rectangle.Left;
									num29 = (float)(rectangle.Top + rectangle.Height / 2);
									sweepAngle = unchecked(180f - array3[num27]);
								}
								graphicsPath2.AddArc(rectangle, array3[num27], sweepAngle);
								unchecked
								{
									graphicsPath2.AddLine(num28, num29, num28, num29 + (float)num15);
									graphicsPath2.AddArc(rect, array3[num27], sweepAngle);
									graphicsPath2.AddLine(array[num27].X, array[num27].Y + (float)num15, array[num27].X, array[num27].Y);
									g.FillPath(new SolidBrush(Color.FromArgb(220, this.BarBrushColor[num27 % 12])), graphicsPath2);
									graphicsPath2.Reset();
								}
							}
						}
					}
					else
					{
						graphicsPath2.AddArc(rectangle, 0f, 180f);
						graphicsPath2.AddLine(rectangle.X, rectangle.Y + rectangle.Height / 2, rectangle.X, rectangle.Y + rectangle.Height / 2 + num15);
						graphicsPath2.AddArc(rect, 0f, 180f);
						graphicsPath2.AddLine(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2 + num15, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2);
						g.FillPath(new SolidBrush(Color.FromArgb(220, this.BarBrushColor[0])), graphicsPath2);
						graphicsPath2.Reset();
					}
					Point point = new Point(rectangle.Left, 0);
					Point point2 = new Point(rectangle.Left + rectangle.Width, 0);
					Color[] colors = new Color[]
					{
						Color.FromArgb(180, Color.Black),
						Color.FromArgb(100, Color.White),
						Color.FromArgb(180, Color.Black)
					};
					float[] positions = new float[]
					{
						0f,
						0.7f,
						1f
					};
					ColorBlend colorBlend = new ColorBlend();
					colorBlend.Colors = colors;
					colorBlend.Positions = positions;
					LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point, point2, Color.Red, Color.Red);
					linearGradientBrush.InterpolationColors = colorBlend;
					GraphicsPath graphicsPath3 = new GraphicsPath();
					graphicsPath3.AddArc(rectangle, 0f, 180f);
					graphicsPath3.AddLine(rectangle.Left, rectangle.Top + rectangle.Height / 2, rect.Left, rect.Top + rect.Height / 2);
					graphicsPath3.AddArc(rect, 0f, 180f);
					graphicsPath3.AddLine(rect.Left + rect.Width, rect.Top + rect.Height / 2, rectangle.Left + rectangle.Width, rectangle.Top + rectangle.Height / 2);
					g.FillPath(linearGradientBrush, graphicsPath3);
					float num30 = (float)(rectangle.Left + rectangle.Width + 20);
					float num31 = 0f;
					float num32 = 0f;
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					int num33 = 0;
					int num34 = this.IntDatas[0].Length - 1;
					for (int num35 = num33; num35 <= num34; num35++)
					{
						unchecked
						{
							if (this.IntDatas[0][num35] > 0f)
							{
								float num36 = (num16 + array2[num35].X) / 2f;
								float num37 = (num17 + array2[num35].Y) / 2f;
								string text2 = "";
								if (this.IntDatas[0][num35] * 360f >= 20f)
								{
									if (this.Tips.Show)
									{
										text2 = this.AxisX[num35] + "\n" + this.RawDatas[0][num35].ToString() + "\n";
									}
									text2 = text2 + (this.IntDatas[0][num35] * 100f).ToString("0.0") + "%";
									g.DrawString(text2, this.Tips.Font, new SolidBrush(this.Tips.ForeColor), num36 - 10f, num37 - 4f);
								}
								else
								{
									float num38;
									if (array3[num35] < 180f)
									{
										if (num31 == 0f)
										{
											num31 = (float)(checked(rectangle.Top + rectangle.Height / 2));
										}
										else
										{
											num31 += 16f;
											if (this.Tips.Show)
											{
												num31 += 12f;
											}
										}
										num38 = num31;
									}
									else
									{
										if (num32 == 0f)
										{
											num32 = (float)(checked(rectangle.Top - (rectangle.Top - num4) / 4));
										}
										else
										{
											num32 += 16f;
											if (this.Tips.Show)
											{
												num32 += 12f;
											}
										}
										num38 = num32;
									}
									if (this.Tips.Show)
									{
										text2 = this.AxisX[num35] + "\n" + this.RawDatas[0][num35].ToString() + "  ";
									}
									text2 = text2 + (this.IntDatas[0][num35] * 100f).ToString("0.0") + "%";
									g.DrawString(text2, this.Tips.Font, new SolidBrush(this.Tips.ForeColor), num30, num38);
									g.DrawLine(Pens.Gray, num30, num38 + 6f, array2[num35].X, array2[num35].Y);
								}
							}
						}
					}
					graphicsPath.Dispose();
					graphicsPath2.Dispose();
					g.DrawEllipse(Pens.Silver, rectangle);
				}
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000F5A40 File Offset: 0x000F3C40
		private void DrawHBarChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.YLabels.Show)
				{
					num7 += 48;
					num3 -= 48;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				if (this.ShowErrorInfo)
				{
					if (!this.DataBound)
					{
						this.ChartTitle.Text = "请先用BindChartData()绑定数据源!";
					}
					else if (this.MinData < 0f)
					{
						this.ChartTitle.Text = "HBar类型的图表值不能小于0";
						this.DataBound = false;
					}
				}
				int num9 = 0;
				int alpha;
				if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					num9 = (int)Math.Round(Math.Truncate(unchecked((double)this.Depth3D * 0.85)));
					this.PaintBackground3D(g, num3, num4, num7, num8);
					alpha = (int)this.Alpha3D;
				}
				else
				{
					this.PaintBackground(g, num3, num4, num7, num8);
					alpha = 255;
				}
				int num10 = 0;
				int labelCount = this.YLabels.LabelCount;
				for (int i = num10; i <= labelCount; i++)
				{
					Chartlet.DrawXLine(g, new Pen(Color.FromArgb(255, 220, 220, 220)), (int)Math.Round(Math.Truncate((double)num9 / 0.85)), num4, num8, num3 + num7 * i / this.YLabels.LabelCount, num7 / this.YLabels.LabelCount);
					if (this.XLabels.Show)
					{
						this.DrawXText(g, new Pen(Color.FromArgb(255, 220, 220, 220)), (unchecked(this.MinData + (this.MaxData - this.MinData) * (float)(checked(this.YLabels.LabelCount - i)) / (float)this.YLabels.LabelCount)).ToString(this.YLabels.ValueFormat), (int)Math.Round(Math.Truncate((double)num9 / 0.85)), num4, num8, num3 + num7 * (this.YLabels.LabelCount - i) / this.YLabels.LabelCount, num7 / this.YLabels.LabelCount);
					}
				}
				if (this.DataBound)
				{
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					Pen pen = new Pen(Color.FromArgb(255, 220, 220, 220));
					int groupSize = this.GroupSize;
					int maxCount = this.MaxCount;
					if (maxCount > 0)
					{
						int num11;
						int num12;
						if (!this.AutoBarWidth && maxCount * groupSize < 12)
						{
							num11 = num8 / 4 / 16;
							num12 = 5 * num11;
						}
						else
						{
							num12 = (int)Math.Round(Math.Truncate((double)(num8 / maxCount) / unchecked(0.25 + (double)groupSize)));
							num11 = (int)Math.Round(Math.Truncate(unchecked(0.25 * (double)num12)));
						}
						int num13 = 0;
						int num14 = maxCount - 1;
						for (int j = num13; j <= num14; j++)
						{
							int num15 = j;
							int num16 = num3;
							int num17 = num4 + num12 * num15 * this.GroupSize + num11 * (num15 + 1);
							int dp = (int)Math.Round(Math.Truncate((double)num9 / 0.85));
							this.DrawYLine(g, pen, this.AxisX[j], dp, num3, num4, num7, num17 + num12 * groupSize / 2, num12);
							bool belowX = false;
							int num18 = 0;
							int num19 = groupSize - 1;
							for (int k = num18; k <= num19; k++)
							{
								if (decimal.Compare(this.RawDatas[k][j], -0.830213m) != 0)
								{
									int num20 = (int)Math.Round(Math.Truncate((double)(unchecked(this.IntDatas[k][j] * (float)num7 / (float)num8 - this.BaseLineXInt - 1f))));
									SolidBrush barBrush;
									if (groupSize == 1 && this.Colorful)
									{
										if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
										{
											barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[j % 12]));
										}
										else
										{
											barBrush = new SolidBrush(this.BarBrushColor[j % 12]);
										}
									}
									else if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
									{
										barBrush = new SolidBrush(Color.FromArgb(alpha, this.BarBrushColor[k % 12]));
									}
									else
									{
										barBrush = new SolidBrush(this.BarBrushColor[k % 12]);
									}
									Pen pen2;
									if (this.Stroke.TextureEnable)
									{
										HatchStyle textureStyle = this.Stroke.TextureStyle;
										pen2 = new Pen(new HatchBrush(textureStyle, this.BarPenColor[k % 12], Color.Gray), (float)this.Stroke.Width);
									}
									else
									{
										pen2 = new Pen(this.BarPenColor[k % 12], (float)this.Stroke.Width);
									}
									pen2.Alignment = PenAlignment.Inset;
									if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
									{
										this.DrawBarBase3D(g, barBrush, pen2, num16, num17, num20, num12, num9);
									}
									else
									{
										this.DrawBarBase2D(g, barBrush, pen2, num16, num17, num20, num12);
									}
									if (this.Crystal.Enable && num12 - this.Crystal.Contraction * 2 > 2 && num20 - this.Crystal.Contraction * 2 > 2)
									{
										this.DrawBarCrystal(g, num16, num17, num20, num12, num9);
									}
									if (this.Tips.Show)
									{
										this.DrawTips(g, this.RawDatas[k][j].ToString(), num16, num17 + 15, num20, num12, belowX);
									}
									if (String.Compare(this.StrBarL, "", false) == 0)
									{
										this.StrBarL = "" + Convert.ToString(num16 - num9);
										this.StrBarW = "" + Convert.ToString(num20);
										this.StrBarT = "" + Convert.ToString(num17 + num9);
										this.StrBarH = "" + Convert.ToString(num12);
										this.StrBarV = "" + Convert.ToString(this.RawDatas[k][j]);
									}
									else
									{
										this.StrBarL = this.StrBarL + "," + Convert.ToString(num16 - num9);
										this.StrBarW = this.StrBarW + "," + Convert.ToString(num20);
										this.StrBarT = this.StrBarT + "," + Convert.ToString(num17 + num9);
										this.StrBarH = this.StrBarH + "," + Convert.ToString(num12);
										this.StrBarV = this.StrBarV + "," + Convert.ToString(this.RawDatas[k][j]);
									}
									num17 += num12;
								}
							}
						}
					}
					pen.Dispose();
				}
				if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
				{
					g.DrawRectangle(Pens.Gray, num3, num4, num7, num8);
					g.DrawLine(Pens.Black, (float)(num3 - 4), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt), (float)(num3 + num7 - 1), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt));
					g.DrawLine(Pens.Black, num3, num4, num3, num4 + num8 + 2);
				}
				string unitText = this.YLabels.UnitText;
				this.YLabels.UnitText = this.XLabels.UnitText;
				this.XLabels.UnitText = unitText;
				this.DrawAxisUnit(g, num3, num4, num7 + 10, num8);
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000F628C File Offset: 0x000F448C
		private void DrawTrendChart(Graphics g)
		{
			checked
			{
				int num = this.Width + this.InflateRight + this.InflateLeft;
				int num2 = this.Height + this.InflateBottom + this.InflateTop;
				int num3 = 50 + this.InflateLeft;
				int num4 = 60 + this.InflateTop;
				int num5 = 100 + this.InflateRight;
				int num6 = 40 + this.InflateBottom;
				int num7 = num - num3 - num5;
				int num8 = num2 - num4 - num6;
				if (!this.DataBound && this.ShowErrorInfo)
				{
					this.ChartTitle.Text = "请用BindChartData函数绑定数据";
				}
				DateTime[] array = new DateTime[this.AxisX.Length - 1 + 1];
				int num9 = 0;
				int num10 = this.AxisX.Length - 1;
				for (int i = num9; i <= num10; i++)
				{
					try
					{
						array[i] = DateTime.Parse(this.AxisX[i]);
					}
					catch (Exception ex)
					{
						this.ChartTitle.Text = "对TrendChart图表,您的第一个列数据必须是DateTime类型!";
						this.DataBound = false;
					}
				}
				int num11 = 0;
				DateTime dateTime = this.Trend.Start;
				while (DateTime.Compare(dateTime, this.Trend.End) <= 0)
				{
					switch (this.Trend.TimeSpan)
					{
					case Chartlet.TimeSpanTypes.Year:
						dateTime = dateTime.AddYears(1);
						break;
					case Chartlet.TimeSpanTypes.Month:
						dateTime = dateTime.AddMonths(1);
						break;
					case Chartlet.TimeSpanTypes.Day:
						dateTime = dateTime.AddDays(1.0);
						break;
					case Chartlet.TimeSpanTypes.Hour:
						dateTime = dateTime.AddHours(1.0);
						break;
					case Chartlet.TimeSpanTypes.Minute:
						dateTime = dateTime.AddMinutes(1.0);
						break;
					case Chartlet.TimeSpanTypes.Second:
						dateTime = dateTime.AddSeconds(1.0);
						break;
					case Chartlet.TimeSpanTypes.Millisecond:
						dateTime = dateTime.AddMilliseconds(1.0);
						break;
					default:
						dateTime = dateTime.AddDays(1.0);
						break;
					}
					num11++;
				}
				if (num11 == 0)
				{
					this.DataBound = false;
					this.ChartTitle.Text = "对TrendChart图表,请设置Chartlet.Trend的属性";
				}
				if (!this.ColorGuider.Show)
				{
					num7 += 98 - (int)Math.Round(Math.Truncate((double)g.MeasureString(this.XLabels.UnitText, this.XLabels.UnitFont).Width));
					num5 -= 98;
				}
				if (!this.YLabels.Show)
				{
					num7 += 48;
					num3 -= 48;
				}
				if (!this.ChartTitle.Show)
				{
					num8 += 33;
					num4 -= 33;
				}
				int num12 = 0;
				int dp = 0;
				int alpha;
				if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
				{
					num12 = (int)Math.Round(Math.Truncate(unchecked((double)this.Depth3D * 0.85)));
					dp = this.Depth3D;
					this.PaintBackground3D(g, num3, num4, num7, num8);
					alpha = (int)this.Alpha3D;
				}
				else
				{
					this.PaintBackground(g, num3, num4, num7, num8);
					alpha = 255;
				}
				Pen backPen = new Pen(Color.FromArgb(255, 220, 220, 220));
				if (this.DataBound)
				{
					DateTime[] array2 = new DateTime[num11 + 1];
					num11 = 0;
					dateTime = this.Trend.Start;
					while (DateTime.Compare(dateTime, this.Trend.End) < 0)
					{
						array2[num11] = dateTime;
						switch (this.Trend.TimeSpan)
						{
						case Chartlet.TimeSpanTypes.Year:
							dateTime = dateTime.AddYears(1);
							break;
						case Chartlet.TimeSpanTypes.Month:
							dateTime = dateTime.AddMonths(1);
							break;
						case Chartlet.TimeSpanTypes.Day:
							dateTime = dateTime.AddDays(1.0);
							break;
						case Chartlet.TimeSpanTypes.Hour:
							dateTime = dateTime.AddHours(1.0);
							break;
						case Chartlet.TimeSpanTypes.Minute:
							dateTime = dateTime.AddMinutes(1.0);
							break;
						case Chartlet.TimeSpanTypes.Second:
							dateTime = dateTime.AddSeconds(1.0);
							break;
						case Chartlet.TimeSpanTypes.Millisecond:
							dateTime = dateTime.AddMilliseconds(1.0);
							break;
						default:
							dateTime = dateTime.AddDays(1.0);
							break;
						}
						num11++;
					}
					array2[num11] = this.Trend.End;
					int num13 = num7 / num11;
					int num14 = 0;
					int num15 = num11;
					for (int j = num14; j <= num15; j++)
					{
						if (j != 0 && j != num11)
						{
							Chartlet.DrawXLine(g, backPen, dp, num4, num8, num3 + j * num13, num13);
						}
						this.DrawXText(g, backPen, array2[j].ToString(this.Trend.ValueFormat), dp, num4, num8, num3 + j * num13, num13);
					}
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.TextRenderingHint = TextRenderingHint.AntiAlias;
					int groupSize = this.GroupSize;
					int maxCount = this.MaxCount;
					if (maxCount > 0)
					{
						int num16 = 0;
						int num17 = groupSize - 1;
						for (int k = num16; k <= num17; k++)
						{
							int num18 = num3;
							SolidBrush solidBrush = new SolidBrush(Color.FromArgb(alpha, this.BarPenColor[k % 12]));
							Pen pen;
							if (this.Stroke.TextureEnable)
							{
								HatchStyle textureStyle = this.Stroke.TextureStyle;
								pen = new Pen(new HatchBrush(textureStyle, this.BarPenColor[k % 12], Color.Black), (float)this.Stroke.Width);
							}
							else
							{
								pen = new Pen(this.BarPenColor[k % 12], (float)this.Stroke.Width);
							}
							GraphicsPath graphicsPath = new GraphicsPath();
							int num19 = 0;
							int num20 = maxCount - 1;
							for (int l = num19; l <= num20; l++)
							{
								int num21 = num3;
								switch (this.Trend.TimeSpan)
								{
								case Chartlet.TimeSpanTypes.Day:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalHours / (this.Trend.End - this.Trend.Start).TotalHours * (double)num7));
									break;
								case Chartlet.TimeSpanTypes.Hour:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalMinutes / (this.Trend.End - this.Trend.Start).TotalMinutes * (double)num7));
									break;
								case Chartlet.TimeSpanTypes.Minute:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalSeconds / (this.Trend.End - this.Trend.Start).TotalSeconds * (double)num7));
									break;
								case Chartlet.TimeSpanTypes.Second:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalMilliseconds / (this.Trend.End - this.Trend.Start).TotalMilliseconds * (double)num7));
									break;
								case Chartlet.TimeSpanTypes.Millisecond:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalMilliseconds / (this.Trend.End - this.Trend.Start).TotalMilliseconds * (double)num7));
									break;
								default:
									num21 += (int)Math.Round(unchecked((array[l] - this.Trend.Start).TotalDays / (this.Trend.End - this.Trend.Start).TotalDays * (double)num7));
									break;
								}
								if (decimal.Compare(this.RawDatas[k][l], -0.830213m) != 0 && DateTime.Compare(array[l], this.Trend.End) <= 0)
								{
									unchecked
									{
										if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
										{
											g.SmoothingMode = SmoothingMode.AntiAlias;
											if (l > 0 && num21 >= num18 && decimal.Compare(this.RawDatas[k][checked(l - 1)], -0.830213m) != 0)
											{
												Chartlet.DrawLine2D(g, pen, (float)num18, (float)(checked(num4 + num8)) - this.IntDatas[k][checked(l - 1)], (float)num21, (float)(checked(num4 + num8)) - this.IntDatas[k][l]);
											}
											g.SmoothingMode = SmoothingMode.None;
											Chartlet.LineConnectionTypes lineConnectionType = this.LineConnectionType;
											int lineConnectionRadius = this.LineConnectionRadius;
											if (lineConnectionType == Chartlet.LineConnectionTypes.Round)
											{
												g.FillEllipse(solidBrush, (float)(checked(num21 - lineConnectionRadius / 2)), (float)(checked(num4 + num8)) - this.IntDatas[k][l] - (float)(lineConnectionRadius / 2), (float)lineConnectionRadius, (float)lineConnectionRadius);
											}
											else if (lineConnectionType == Chartlet.LineConnectionTypes.Square)
											{
												g.FillRectangle(solidBrush, (float)(checked(num21 - lineConnectionRadius / 2)), (float)(checked(num4 + num8)) - this.IntDatas[k][l] - (float)(lineConnectionRadius / 2), (float)lineConnectionRadius, (float)lineConnectionRadius);
											}
										}
										else if (this.Dimension == Chartlet.ChartDimensions.Chart3D)
										{
											g.SmoothingMode = SmoothingMode.AntiAlias;
											float halfRadius = (float)(this.LineConnectionRadius / 2);
											if (this.LineConnectionType == Chartlet.LineConnectionTypes.None)
											{
												halfRadius = 0f;
											}
											this.DrawLineConnection3D(g, pen, solidBrush, num12, halfRadius, (float)num21, (float)(checked(num4 + num8)) - this.IntDatas[k][l], k);
											if (l > 0 && num21 >= num18 && decimal.Compare(this.RawDatas[k][checked(l - 1)], -0.830213m) != 0)
											{
												this.DrawLineSurface3D(g, pen, solidBrush, num12, halfRadius, (float)num18, (float)(checked(num4 + num8)) - this.IntDatas[k][checked(l - 1)], (float)num21, (float)(checked(num4 + num8)) - this.IntDatas[k][l]);
											}
										}
									}
									if (this.Tips.Show)
									{
										this.DrawTips(g, this.RawDatas[k][l].ToString(), num21, (int)Math.Round(Math.Truncate((double)(unchecked((float)(checked(num4 + num8)) - this.IntDatas[k][l] - (float)(this.LineConnectionRadius / 2))))), num21 - num18, (int)Math.Round(Math.Truncate((double)this.IntDatas[k][l])), false);
									}
									this.WriteSrcipt((float)(num21 - num12), unchecked((float)(checked(num4 + num12 + num8)) - this.IntDatas[k][l]), this.RawDatas[k][l]);
								}
								num18 = num21;
							}
							pen.Dispose();
							graphicsPath.Dispose();
						}
					}
				}
				if (this.Dimension == Chartlet.ChartDimensions.Chart2D)
				{
					g.DrawRectangle(Pens.Gray, num3, num4, num7, num8);
					g.DrawLine(Pens.Black, (float)(num3 - 4), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt), (float)(num3 + num7 - 1), unchecked((float)(checked(num4 + num8)) - this.BaseLineXInt));
					g.DrawLine(Pens.Black, num3, num4, num3, num4 + num8 + 2);
				}
				this.DrawAxisUnit(g, num3, num4, num7, num8);
			}
		}

		// Token: 0x04000F30 RID: 3888
		private bool myIsRightAngle;

		// Token: 0x04000F31 RID: 3889
		private int dx;

		// Token: 0x04000F32 RID: 3890
		private int dy;

		// Token: 0x04000F33 RID: 3891
		private int _Width;

		// Token: 0x04000F34 RID: 3892
		private int _Height;

		// Token: 0x04000F35 RID: 3893
		private Chartlet.ChartTypes _ChartType;

		// Token: 0x04000F36 RID: 3894
		private int _MutipleBars;

		// Token: 0x04000F37 RID: 3895
		private double _MaxValueY;

		// Token: 0x04000F38 RID: 3896
		private double _BaseLineX;

		// Token: 0x04000F39 RID: 3897
		private double _MinValueY;

		// Token: 0x04000F3A RID: 3898
		private bool _RoundRectangle;

		// Token: 0x04000F3B RID: 3899
		private int _RoundRadius;

		// Token: 0x04000F3C RID: 3900
		private Chartlet.LineConnectionTypes _LineConnectionType;

		// Token: 0x04000F3D RID: 3901
		private int _LineConnectionRadius;

		// Token: 0x04000F3E RID: 3902
		private Chartlet.AppearanceStyles _AppearanceStyle;

		// Token: 0x04000F3F RID: 3903
		private Chartlet.ChartDimensions _Dimension;

		// Token: 0x04000F40 RID: 3904
		private int _Depth3D;

		// Token: 0x04000F41 RID: 3905
		private byte _Alpha3D;

		// Token: 0x04000F42 RID: 3906
		private bool _AutoBarWidth;

		// Token: 0x04000F43 RID: 3907
		private bool _Colorful;

		// Token: 0x04000F44 RID: 3908
		private bool _ShowErrorInfo;

		// Token: 0x04000F45 RID: 3909
		private bool _ShowCopyright;

		// Token: 0x04000F46 RID: 3910
		private string _CopyrightText;

		// Token: 0x04000F47 RID: 3911
		private int _InflateRight;

		// Token: 0x04000F48 RID: 3912
		private int _InflateBottom;

		// Token: 0x04000F49 RID: 3913
		private int _InflateTop;

		// Token: 0x04000F4A RID: 3914
		private int _InflateLeft;

		// Token: 0x04000F4B RID: 3915
		private CrystalAttributes _Crystal;

		// Token: 0x04000F4C RID: 3916
		private Attributes _ColorGuider;

		// Token: 0x04000F4D RID: 3917
		private Attributes _Tips;

		// Token: 0x04000F4E RID: 3918
		private LabelsAttributes _YLabels;

		// Token: 0x04000F4F RID: 3919
		private XLabelsAttributes _XLabels;

		// Token: 0x04000F50 RID: 3920
		private TextAttributes _ChartTitle;

		// Token: 0x04000F51 RID: 3921
		private Painting _Fill;

		// Token: 0x04000F52 RID: 3922
		private StrokeStyle _Stroke;

		// Token: 0x04000F53 RID: 3923
		private BackgroundAttributes _Background;

		// Token: 0x04000F54 RID: 3924
		private TrendAttributes _Trend;

		// Token: 0x04000F55 RID: 3925
		private SpecLineAttributes _SpecLine;

		// Token: 0x04000F56 RID: 3926
		private decimal[][] RawDatas;

		// Token: 0x04000F57 RID: 3927
		private float[][] IntDatas;

		// Token: 0x04000F58 RID: 3928
		private float MaxData;

		// Token: 0x04000F59 RID: 3929
		private float MinData;

		// Token: 0x04000F5A RID: 3930
		private float BaseLineXInt;

		// Token: 0x04000F5B RID: 3931
		private int MinCount;

		// Token: 0x04000F5C RID: 3932
		private int MaxCount;

		// Token: 0x04000F5D RID: 3933
		public string[] AxisX;

		// Token: 0x04000F5E RID: 3934
		private bool DataBound;

		// Token: 0x04000F5F RID: 3935
		public string[] GroupTitle;

		// Token: 0x04000F60 RID: 3936
		private string InitializeDataString;

		// Token: 0x04000F61 RID: 3937
		private string Separator1;

		// Token: 0x04000F62 RID: 3938
		private string Separator2;

		// Token: 0x04000F63 RID: 3939
		private string Separator3;

		// Token: 0x04000F64 RID: 3940
		private string Separator;

		// Token: 0x04000F65 RID: 3941
		private Color[] BarBrushColor;

		// Token: 0x04000F66 RID: 3942
		private Color[] BarPenColor;

		// Token: 0x04000F67 RID: 3943
		public Color[] Breeze;

		// Token: 0x04000F68 RID: 3944
		public Color[] Aurora;

		// Token: 0x04000F69 RID: 3945
		public Color[] StarryNight;

		// Token: 0x04000F6A RID: 3946
		private string StrBarL;

		// Token: 0x04000F6B RID: 3947
		private string StrBarW;

		// Token: 0x04000F6C RID: 3948
		private string StrBarT;

		// Token: 0x04000F6D RID: 3949
		private string StrBarH;

		// Token: 0x04000F6E RID: 3950
		private string StrBarV;

		// Token: 0x02000152 RID: 338
		public enum TimeSpanTypes
		{
			// Token: 0x04000F9D RID: 3997
			Year,
			// Token: 0x04000F9E RID: 3998
			Month,
			// Token: 0x04000F9F RID: 3999
			Day,
			// Token: 0x04000FA0 RID: 4000
			Hour,
			// Token: 0x04000FA1 RID: 4001
			Minute,
			// Token: 0x04000FA2 RID: 4002
			Second,
			// Token: 0x04000FA3 RID: 4003
			Millisecond
		}

		// Token: 0x02000153 RID: 339
		public enum ChartTypes
		{
			// Token: 0x04000FA5 RID: 4005
			Bar,
			// Token: 0x04000FA6 RID: 4006
			Line,
			// Token: 0x04000FA7 RID: 4007
			Pie,
			// Token: 0x04000FA8 RID: 4008
			Stack,
			// Token: 0x04000FA9 RID: 4009
			HBar,
			// Token: 0x04000FAA RID: 4010
			Trend,
			// Token: 0x04000FAB RID: 4011
			Bubble,
			// Token: 0x04000FAC RID: 4012
			FloatBar,
			// Token: 0x04000FAD RID: 4013
			Linear,
			// Token: 0x04000FAE RID: 4014
			Histogram,
			// Token: 0x04000FAF RID: 4015
			BoxPlot
		}

		// Token: 0x02000154 RID: 340
		public enum LineConnectionTypes
		{
			// Token: 0x04000FB1 RID: 4017
			Round,
			// Token: 0x04000FB2 RID: 4018
			Square,
			// Token: 0x04000FB3 RID: 4019
			None
		}

		// Token: 0x02000155 RID: 341
		public enum Direction
		{
			// Token: 0x04000FB5 RID: 4021
			LeftRight,
			// Token: 0x04000FB6 RID: 4022
			TopBottom,
			// Token: 0x04000FB7 RID: 4023
			RightLeft,
			// Token: 0x04000FB8 RID: 4024
			BottomTop
		}

		// Token: 0x02000156 RID: 342
		public enum ColorStyles
		{
			// Token: 0x04000FBA RID: 4026
			None,
			// Token: 0x04000FBB RID: 4027
			Breeze,
			// Token: 0x04000FBC RID: 4028
			Aurora,
			// Token: 0x04000FBD RID: 4029
			StarryNight
		}

		// Token: 0x02000157 RID: 343
		public enum ChartDimensions
		{
			// Token: 0x04000FBF RID: 4031
			Chart2D,
			// Token: 0x04000FC0 RID: 4032
			Chart3D
		}

		// Token: 0x02000158 RID: 344
		public enum AppearanceStyles
		{
			// Token: 0x04000FC2 RID: 4034
			None_None_None_None_None_None,
			// Token: 0x04000FC3 RID: 4035
			Bar_2D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04000FC4 RID: 4036
			Bar_2D_Breeze_NoCrystal_WhiteBorder,
			// Token: 0x04000FC5 RID: 4037
			Bar_2D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04000FC6 RID: 4038
			Bar_2D_Breeze_FlatCrystal_WhiteBorder,
			// Token: 0x04000FC7 RID: 4039
			Bar_2D_Breeze_FlatCrystal_TextureBorder,
			// Token: 0x04000FC8 RID: 4040
			Bar_2D_Aurora_NoCrystal_NoBorder,
			// Token: 0x04000FC9 RID: 4041
			Bar_2D_Aurora_NoCrystal_WhiteBorder,
			// Token: 0x04000FCA RID: 4042
			Bar_2D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04000FCB RID: 4043
			Bar_2D_Aurora_FlatCrystal_WhiteBorder,
			// Token: 0x04000FCC RID: 4044
			Bar_2D_Aurora_FlatCrystal_TextureBorder,
			// Token: 0x04000FCD RID: 4045
			Bar_2D_Aurora_GlassCrystal_NoBorder,
			// Token: 0x04000FCE RID: 4046
			Bar_2D_Aurora_GlassCrystal_WhiteBorder,
			// Token: 0x04000FCF RID: 4047
			Bar_2D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04000FD0 RID: 4048
			Bar_2D_StarryNight_FlatCrystal_WhiteBorder,
			// Token: 0x04000FD1 RID: 4049
			Bar_2D_StarryNight_FlatCrystal_TextureBorder,
			// Token: 0x04000FD2 RID: 4050
			Bar_2D_StarryNight_GlassCrystal_NoBorder,
			// Token: 0x04000FD3 RID: 4051
			Bar_3D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04000FD4 RID: 4052
			Bar_3D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04000FD5 RID: 4053
			Bar_3D_Aurora_NoCrystal_NoBorder,
			// Token: 0x04000FD6 RID: 4054
			Bar_3D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04000FD7 RID: 4055
			Bar_3D_StarryNight_NoCrystal_NoBorder,
			// Token: 0x04000FD8 RID: 4056
			Bar_3D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04000FD9 RID: 4057
			Line_2D_Aurora_ThickRound_NoBorder,
			// Token: 0x04000FDA RID: 4058
			Line_2D_Aurora_ThickSquare_NoBorder,
			// Token: 0x04000FDB RID: 4059
			Line_2D_Aurora_ThinRound_NoBorder,
			// Token: 0x04000FDC RID: 4060
			Line_2D_Aurora_ThinSquare_NoBorder,
			// Token: 0x04000FDD RID: 4061
			Line_2D_StarryNight_ThickRound_NoBorder,
			// Token: 0x04000FDE RID: 4062
			Line_2D_StarryNight_ThickSquare_NoBorder,
			// Token: 0x04000FDF RID: 4063
			Line_2D_StarryNight_ThinRound_NoBorder,
			// Token: 0x04000FE0 RID: 4064
			Line_2D_StarryNight_ThinSquare_NoBorder,
			// Token: 0x04000FE1 RID: 4065
			Line_3D_Breeze_NoCrystalNone_NoBorder,
			// Token: 0x04000FE2 RID: 4066
			Line_3D_Breeze_NoCrystalRound_NoBorder,
			// Token: 0x04000FE3 RID: 4067
			Line_3D_Breeze_NoCrystalSquare_NoBorder,
			// Token: 0x04000FE4 RID: 4068
			Line_3D_Breeze_FlatCrystalNone_NoBorder,
			// Token: 0x04000FE5 RID: 4069
			Line_3D_Breeze_FlatCrystalRound_NoBorder,
			// Token: 0x04000FE6 RID: 4070
			Line_3D_Breeze_FlatCrystalSquare_NoBorder,
			// Token: 0x04000FE7 RID: 4071
			Line_3D_Breeze_GlassCrystalNone_NoBorder,
			// Token: 0x04000FE8 RID: 4072
			Line_3D_Breeze_GlassCrystalRound_NoBorder,
			// Token: 0x04000FE9 RID: 4073
			Line_3D_Breeze_GlassCrystalSquare_NoBorder,
			// Token: 0x04000FEA RID: 4074
			Line_3D_Aurora_NoCrystalNone_NoBorder,
			// Token: 0x04000FEB RID: 4075
			Line_3D_Aurora_NoCrystalRound_NoBorder,
			// Token: 0x04000FEC RID: 4076
			Line_3D_Aurora_NoCrystalSquare_NoBorder,
			// Token: 0x04000FED RID: 4077
			Line_3D_Aurora_FlatCrystalNone_NoBorder,
			// Token: 0x04000FEE RID: 4078
			Line_3D_Aurora_FlatCrystalRound_NoBorder,
			// Token: 0x04000FEF RID: 4079
			Line_3D_Aurora_FlatCrystalSquare_NoBorder,
			// Token: 0x04000FF0 RID: 4080
			Line_3D_Aurora_GlassCrystalNone_NoBorder,
			// Token: 0x04000FF1 RID: 4081
			Line_3D_Aurora_GlassCrystalRound_NoBorder,
			// Token: 0x04000FF2 RID: 4082
			Line_3D_Aurora_GlassCrystalSquare_NoBorder,
			// Token: 0x04000FF3 RID: 4083
			Line_3D_StarryNight_NoCrystalNone_NoBorder,
			// Token: 0x04000FF4 RID: 4084
			Line_3D_StarryNight_NoCrystalRound_NoBorder,
			// Token: 0x04000FF5 RID: 4085
			Line_3D_StarryNight_NoCrystalSquare_NoBorder,
			// Token: 0x04000FF6 RID: 4086
			Line_3D_StarryNight_FlatCrystalNone_NoBorder,
			// Token: 0x04000FF7 RID: 4087
			Line_3D_StarryNight_FlatCrystalRound_NoBorder,
			// Token: 0x04000FF8 RID: 4088
			Line_3D_StarryNight_FlatCrystalSquare_NoBorder,
			// Token: 0x04000FF9 RID: 4089
			Line_3D_StarryNight_GlassCrystalNone_NoBorder,
			// Token: 0x04000FFA RID: 4090
			Line_3D_StarryNight_GlassCrystalRound_NoBorder,
			// Token: 0x04000FFB RID: 4091
			Line_3D_StarryNight_GlassCrystalSquare_NoBorder,
			// Token: 0x04000FFC RID: 4092
			Pie_2D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04000FFD RID: 4093
			Pie_2D_Breeze_NoCrystal_WhiteBorder,
			// Token: 0x04000FFE RID: 4094
			Pie_2D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04000FFF RID: 4095
			Pie_2D_Breeze_FlatCrystal_WhiteBorder,
			// Token: 0x04001000 RID: 4096
			Pie_2D_Breeze_GlassCrystal_NoBorder,
			// Token: 0x04001001 RID: 4097
			Pie_2D_Breeze_GlassCrystal_WhiteBorder,
			// Token: 0x04001002 RID: 4098
			Pie_2D_Aurora_NoCrystal_NoBorder,
			// Token: 0x04001003 RID: 4099
			Pie_2D_Aurora_NoCrystal_WhiteBorder,
			// Token: 0x04001004 RID: 4100
			Pie_2D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04001005 RID: 4101
			Pie_2D_Aurora_FlatCrystal_WhiteBorder,
			// Token: 0x04001006 RID: 4102
			Pie_2D_Aurora_GlassCrystal_NoBorder,
			// Token: 0x04001007 RID: 4103
			Pie_2D_Aurora_GlassCrystal_WhiteBorder,
			// Token: 0x04001008 RID: 4104
			Pie_2D_StarryNight_NoCrystal_NoBorder,
			// Token: 0x04001009 RID: 4105
			Pie_2D_StarryNight_NoCrystal_WhiteBorder,
			// Token: 0x0400100A RID: 4106
			Pie_2D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x0400100B RID: 4107
			Pie_2D_StarryNight_FlatCrystal_WhiteBorder,
			// Token: 0x0400100C RID: 4108
			Pie_2D_StarryNight_GlassCrystal_NoBorder,
			// Token: 0x0400100D RID: 4109
			Pie_2D_StarryNight_GlassCrystal_WhiteBorder,
			// Token: 0x0400100E RID: 4110
			Pie_3D_Aurora_NoCrystal_NoBorder,
			// Token: 0x0400100F RID: 4111
			Pie_3D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04001010 RID: 4112
			Pie_3D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04001011 RID: 4113
			Pie_3D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04001012 RID: 4114
			Pie_3D_StarryNight_NoCrystal_NoBorder,
			// Token: 0x04001013 RID: 4115
			Pie_3D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04001014 RID: 4116
			Stack_2D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04001015 RID: 4117
			Stack_2D_Breeze_NoCrystal_WhiteBorder,
			// Token: 0x04001016 RID: 4118
			Stack_2D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04001017 RID: 4119
			Stack_2D_Breeze_FlatCrystal_WhiteBorder,
			// Token: 0x04001018 RID: 4120
			Stack_2D_Breeze_FlatCrystal_TextureBorder,
			// Token: 0x04001019 RID: 4121
			Stack_2D_Aurora_NoCrystal_WhiteBorder,
			// Token: 0x0400101A RID: 4122
			Stack_2D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x0400101B RID: 4123
			Stack_2D_Aurora_FlatCrystal_WhiteBorder,
			// Token: 0x0400101C RID: 4124
			Stack_2D_Aurora_FlatCrystal_TextureBorder,
			// Token: 0x0400101D RID: 4125
			Stack_2D_Aurora_GlassCrystal_NoBorder,
			// Token: 0x0400101E RID: 4126
			Stack_2D_Aurora_GlassCrystal_WhiteBorder,
			// Token: 0x0400101F RID: 4127
			Stack_2D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04001020 RID: 4128
			Stack_2D_StarryNight_FlatCrystal_WhiteBorder,
			// Token: 0x04001021 RID: 4129
			Stack_2D_StarryNight_FlatCrystal_TextureBorder,
			// Token: 0x04001022 RID: 4130
			Stack_2D_StarryNight_GlassCrystal_NoBorder,
			// Token: 0x04001023 RID: 4131
			Stack_3D_Breeze_NoCrystal_NoBorder,
			// Token: 0x04001024 RID: 4132
			Stack_3D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x04001025 RID: 4133
			Stack_3D_Aurora_NoCrystal_NoBorder,
			// Token: 0x04001026 RID: 4134
			Stack_3D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04001027 RID: 4135
			Stack_3D_StarryNight_NoCrystal_NoBorder,
			// Token: 0x04001028 RID: 4136
			Stack_3D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04001029 RID: 4137
			HBar_2D_Breeze_NoCrystal_NoBorder,
			// Token: 0x0400102A RID: 4138
			HBar_2D_Breeze_NoCrystal_WhiteBorder,
			// Token: 0x0400102B RID: 4139
			HBar_2D_Breeze_FlatCrystal_NoBorder,
			// Token: 0x0400102C RID: 4140
			HBar_2D_Breeze_FlatCrystal_WhiteBorder,
			// Token: 0x0400102D RID: 4141
			HBar_2D_Breeze_FlatCrystal_TextureBorder,
			// Token: 0x0400102E RID: 4142
			HBar_2D_Aurora_NoCrystal_NoBorder,
			// Token: 0x0400102F RID: 4143
			HBar_2D_Aurora_NoCrystal_WhiteBorder,
			// Token: 0x04001030 RID: 4144
			HBar_2D_Aurora_FlatCrystal_NoBorder,
			// Token: 0x04001031 RID: 4145
			HBar_2D_Aurora_FlatCrystal_WhiteBorder,
			// Token: 0x04001032 RID: 4146
			HBar_2D_Aurora_FlatCrystal_TextureBorder,
			// Token: 0x04001033 RID: 4147
			HBar_2D_Aurora_GlassCrystal_NoBorder,
			// Token: 0x04001034 RID: 4148
			HBar_2D_Aurora_GlassCrystal_WhiteBorder,
			// Token: 0x04001035 RID: 4149
			HBar_2D_StarryNight_FlatCrystal_NoBorder,
			// Token: 0x04001036 RID: 4150
			HBar_2D_StarryNight_FlatCrystal_WhiteBorder,
			// Token: 0x04001037 RID: 4151
			HBar_2D_StarryNight_FlatCrystal_TextureBorder,
			// Token: 0x04001038 RID: 4152
			HBar_2D_StarryNight_GlassCrystal_NoBorder,
			// Token: 0x04001039 RID: 4153
			Trend_2D_Aurora_ThickRound_NoBorder,
			// Token: 0x0400103A RID: 4154
			Trend_2D_Aurora_ThickSquare_NoBorder,
			// Token: 0x0400103B RID: 4155
			Trend_2D_Aurora_ThinRound_NoBorder,
			// Token: 0x0400103C RID: 4156
			Trend_2D_Aurora_ThinSquare_NoBorder,
			// Token: 0x0400103D RID: 4157
			Trend_2D_StarryNight_ThickRound_NoBorder,
			// Token: 0x0400103E RID: 4158
			Trend_2D_StarryNight_ThickSquare_NoBorder,
			// Token: 0x0400103F RID: 4159
			Trend_2D_StarryNight_ThinRound_NoBorder,
			// Token: 0x04001040 RID: 4160
			Trend_2D_StarryNight_ThinSquare_NoBorder,
			// Token: 0x04001041 RID: 4161
			Trend_3D_Breeze_NoCrystalNone_NoBorder,
			// Token: 0x04001042 RID: 4162
			Trend_3D_Breeze_NoCrystalRound_NoBorder,
			// Token: 0x04001043 RID: 4163
			Trend_3D_Breeze_NoCrystalSquare_NoBorder,
			// Token: 0x04001044 RID: 4164
			Trend_3D_Breeze_FlatCrystalNone_NoBorder,
			// Token: 0x04001045 RID: 4165
			Trend_3D_Breeze_FlatCrystalRound_NoBorder,
			// Token: 0x04001046 RID: 4166
			Trend_3D_Breeze_FlatCrystalSquare_NoBorder,
			// Token: 0x04001047 RID: 4167
			Trend_3D_Breeze_GlassCrystalNone_NoBorder,
			// Token: 0x04001048 RID: 4168
			Trend_3D_Breeze_GlassCrystalRound_NoBorder,
			// Token: 0x04001049 RID: 4169
			Trend_3D_Breeze_GlassCrystalSquare_NoBorder,
			// Token: 0x0400104A RID: 4170
			Trend_3D_Aurora_NoCrystalNone_NoBorder,
			// Token: 0x0400104B RID: 4171
			Trend_3D_Aurora_NoCrystalRound_NoBorder,
			// Token: 0x0400104C RID: 4172
			Trend_3D_Aurora_NoCrystalSquare_NoBorder,
			// Token: 0x0400104D RID: 4173
			Trend_3D_Aurora_FlatCrystalNone_NoBorder,
			// Token: 0x0400104E RID: 4174
			Trend_3D_Aurora_FlatCrystalRound_NoBorder,
			// Token: 0x0400104F RID: 4175
			Trend_3D_Aurora_FlatCrystalSquare_NoBorder,
			// Token: 0x04001050 RID: 4176
			Trend_3D_Aurora_GlassCrystalNone_NoBorder,
			// Token: 0x04001051 RID: 4177
			Trend_3D_Aurora_GlassCrystalRound_NoBorder,
			// Token: 0x04001052 RID: 4178
			Trend_3D_Aurora_GlassCrystalSquare_NoBorder,
			// Token: 0x04001053 RID: 4179
			Trend_3D_StarryNight_NoCrystalNone_NoBorder,
			// Token: 0x04001054 RID: 4180
			Trend_3D_StarryNight_NoCrystalRound_NoBorder,
			// Token: 0x04001055 RID: 4181
			Trend_3D_StarryNight_NoCrystalSquare_NoBorder,
			// Token: 0x04001056 RID: 4182
			Trend_3D_StarryNight_FlatCrystalNone_NoBorder,
			// Token: 0x04001057 RID: 4183
			Trend_3D_StarryNight_FlatCrystalRound_NoBorder,
			// Token: 0x04001058 RID: 4184
			Trend_3D_StarryNight_FlatCrystalSquare_NoBorder,
			// Token: 0x04001059 RID: 4185
			Trend_3D_StarryNight_GlassCrystalNone_NoBorder,
			// Token: 0x0400105A RID: 4186
			Trend_3D_StarryNight_GlassCrystalRound_NoBorder,
			// Token: 0x0400105B RID: 4187
			Trend_3D_StarryNight_GlassCrystalSquare_NoBorder
		}
	}
}
