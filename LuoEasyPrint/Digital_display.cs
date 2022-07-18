using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace LuoEasyPrint
{
	// Token: 0x02000166 RID: 358
	public class Digital_display : UserControl
	{
		// Token: 0x06001E7B RID: 7803 RVA: 0x000FDAA8 File Offset: 0x000FBCA8
		public Digital_display()
		{
			this.tip = new ToolTip();
			this.Background_Color_temp = Color.White;
			this.Character_length_temp = 2;
			this.components = null;
			this.Digital_Color_fales_temp = Color.Transparent;
			this.Digital_Color_true_temp = Color.Green;
			this.Scalesdecimal_digits_temp = 0;
			this.shuzhi = 0.0;
			this._tips = "";
			this.InitializeComponent();
			this.tip.InitialDelay = 200;
			this.tip.AutoPopDelay = 10000;
			this.tip.ReshowDelay = 200;
			this.tip.ShowAlways = true;
			this.tip.IsBalloon = true;
			this.tip.SetToolTip(this, this._tips);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000FDB98 File Offset: 0x000FBD98
		private void dian(Graphics g, int x, int y, int width, int height, bool sc)
		{
			checked
			{
				int num = (int)Math.Round((double)height / 10.0);
				int num2 = (int)Math.Round((double)num / 5.0);
				Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
				LinearGradientBrush brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
				if (sc)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillRectangle(brush, x + num2, y + height - num, num, num);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillRectangle(brush, x + num2, y + height - num, num, num);
				}
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000FDC48 File Offset: 0x000FBE48
		public void Draw(Graphics g, int thewidth, int theheight)
		{
			checked
			{
				int num = (int)Math.Round((double)theheight / 30.0);
				int num2 = thewidth - num * 2;
				int num3 = theheight - num * 2;
				Point point = default(Point);
				point.X = num;
				point.Y = num;
				int num4 = (int)Math.Round(unchecked((double)num3 / 10.0 + (double)num3 / 25.0));
				int num5 = (int)Math.Round((double)(num2 - (this.Character_length_temp - 1) * num4) / (double)this.Character_length_temp);
				if (this.Scalesdecimal_digits_temp > this.Character_length_temp - 1)
				{
					this.Scalesdecimal_digits_temp = this.Character_length_temp - 1;
				}
				Point point2 = default(Point);
				point2.X = (int)Math.Round((double)thewidth / 2.0);
				point2.Y = (int)Math.Round((double)theheight / 2.0);
				Point point3 = default(Point);
				point3.X = 0;
				point3.Y = 0;
				Point point4 = default(Point);
				point4.X = 0;
				point4.Y = theheight - 2;
				Point point5 = default(Point);
				point5.X = thewidth - 2;
				point5.Y = 0;
				Point point6 = default(Point);
				point6.X = thewidth - 2;
				point6.Y = theheight - 2;
				Rectangle rect = new Rectangle(0, 0, thewidth, theheight);
				LinearGradientBrush brush = new LinearGradientBrush(rect, this.Background_Color, this.Background_Color, LinearGradientMode.Vertical);
				g.FillRectangle(brush, point3.X, point3.Y, thewidth, theheight);
				new Pen(Brushes.Black);
				char[] array = this.shuzhi.ToString("N", new NumberFormatInfo
				{
					NumberDecimalDigits = this.Scalesdecimal_digits_temp
				}).ToCharArray();
				char[] array2 = new char[this.Character_length_temp - 1 + 1];
				int num6 = array.Length;
				if (this.Scalesdecimal_digits_temp > 0)
				{
					num6--;
				}
				int num7 = 0;
				int num8 = array.Length - 1;
				for (int i = num7; i <= num8; i++)
				{
					if (array[i] == ',')
					{
						num6--;
					}
				}
				if (this.shuzhi >= 0.0)
				{
					if (num6 <= this.Character_length_temp)
					{
						int num9 = 0;
						int num10 = 0;
						int num11 = num6 - 1;
						for (int i = num10; i <= num11; i++)
						{
							if (array[num9] == '.' || array[num9] == ',')
							{
								num9++;
							}
							array2[i + this.Character_length_temp - num6] = array[num9];
							num9++;
						}
					}
					else
					{
						for (int i = 0; i < this.Character_length_temp; i++)
						{
							array2[i] = '-';
						}
					}
				}
				else if (num6 <= this.Character_length_temp)
				{
					int num9 = 0;
					array2[0] = '-';
					int num12 = 0;
					int num13 = num6 - 1;
					for (int i = num12; i <= num13; i++)
					{
						if (array[num9] == '.' || array[num9] == ',')
						{
							num9++;
						}
						if (i != 0)
						{
							array2[i + this.Character_length_temp - num6] = array[num9];
						}
						num9++;
					}
				}
				else
				{
					int num14 = 0;
					int num15 = this.Character_length_temp - 1;
					for (int i = num14; i <= num15; i++)
					{
						array2[i] = '-';
					}
				}
				int num16 = 0;
				int num17 = this.Character_length_temp - 1;
				for (int i = num16; i <= num17; i++)
				{
					if (i != 0)
					{
						this.zifu(g, point.X + i * num5 + i * num4, point.Y, num5, num3, array2[i], thewidth, theheight);
					}
					if (i == 0)
					{
						this.zifu(g, point.X, point.Y, num5, num3, array2[i], thewidth, theheight);
					}
					if (i != this.Character_length_temp - 1)
					{
						if (this.Scalesdecimal_digits_temp == this.Character_length_temp - i - 1)
						{
							this.dian(g, point.X + (i + 1) * num5 + i * num4, point.Y, num4, num3, true);
						}
						else
						{
							this.dian(g, point.X + (i + 1) * num5 + i * num4, point.Y, num4, num3, false);
						}
					}
				}
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000FE030 File Offset: 0x000FC230
		private void Digital_display_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round((double)base.Height / 30.0);
				int num2 = base.Width - num * 2;
				int num3 = base.Height - num * 2;
				Point point = default(Point);
				point.X = num;
				point.Y = num;
				int num4 = (int)Math.Round(unchecked((double)num3 / 10.0 + (double)num3 / 25.0));
				int num5 = (int)Math.Round((double)(num2 - (this.Character_length_temp - 1) * num4) / (double)this.Character_length_temp);
				if (this.Scalesdecimal_digits_temp > this.Character_length_temp - 1)
				{
					this.Scalesdecimal_digits_temp = this.Character_length_temp - 1;
				}
				Point point2 = default(Point);
				point2.X = (int)Math.Round((double)base.Width / 2.0);
				point2.Y = (int)Math.Round((double)base.Height / 2.0);
				Point point3 = default(Point);
				point3.X = 0;
				point3.Y = 0;
				Point point4 = default(Point);
				point4.X = 0;
				point4.Y = base.Height - 2;
				Point point5 = default(Point);
				point5.X = base.Width - 2;
				point5.Y = 0;
				Point point6 = default(Point);
				point6.X = base.Width - 2;
				point6.Y = base.Height - 2;
				Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
				LinearGradientBrush brush = new LinearGradientBrush(rect, this.Background_Color, this.Background_Color, LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(brush, point3.X, point3.Y, base.Width, base.Height);
				new Pen(Brushes.Black);
				char[] array = this.shuzhi.ToString("N", new NumberFormatInfo
				{
					NumberDecimalDigits = this.Scalesdecimal_digits_temp
				}).ToCharArray();
				char[] array2 = new char[this.Character_length_temp - 1 + 1];
				int num6 = array.Length;
				if (this.Scalesdecimal_digits_temp > 0)
				{
					num6--;
				}
				int num7 = 0;
				int num8 = array.Length - 1;
				for (int i = num7; i <= num8; i++)
				{
					if (array[i] == ',')
					{
						num6--;
					}
				}
				if (this.shuzhi >= 0.0)
				{
					if (num6 <= this.Character_length_temp)
					{
						int num9 = 0;
						int num10 = 0;
						int num11 = num6 - 1;
						for (int i = num10; i <= num11; i++)
						{
							if (array[num9] == '.' || array[num9] == ',')
							{
								num9++;
							}
							array2[i + this.Character_length_temp - num6] = array[num9];
							num9++;
						}
					}
					else
					{
						for (int i = 0; i < this.Character_length_temp; i++)
						{
							array2[i] = '-';
						}
					}
				}
				else if (num6 <= this.Character_length_temp)
				{
					int num9 = 0;
					array2[0] = '-';
					int num12 = 0;
					int num13 = num6 - 1;
					for (int i = num12; i <= num13; i++)
					{
						if (array[num9] == '.' || array[num9] == ',')
						{
							num9++;
						}
						if (i != 0)
						{
							array2[i + this.Character_length_temp - num6] = array[num9];
						}
						num9++;
					}
				}
				else
				{
					int num14 = 0;
					int num15 = this.Character_length_temp - 1;
					for (int i = num14; i <= num15; i++)
					{
						array2[i] = '-';
					}
				}
				int num16 = 0;
				int num17 = this.Character_length_temp - 1;
				for (int i = num16; i <= num17; i++)
				{
					if (i != 0)
					{
						this.zifu(e.Graphics, point.X + i * num5 + i * num4, point.Y, num5, num3, array2[i], base.Width, base.Height);
					}
					if (i == 0)
					{
						this.zifu(e.Graphics, point.X, point.Y, num5, num3, array2[i], base.Width, base.Height);
					}
					if (i != this.Character_length_temp - 1)
					{
						if (this.Scalesdecimal_digits_temp == this.Character_length_temp - i - 1)
						{
							this.dian(e.Graphics, point.X + (i + 1) * num5 + i * num4, point.Y, num4, num3, true);
						}
						else
						{
							this.dian(e.Graphics, point.X + (i + 1) * num5 + i * num4, point.Y, num4, num3, false);
						}
					}
				}
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000FE488 File Offset: 0x000FC688
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			try
			{
				this.tip.Dispose();
				this.tip = null;
			}
			catch (Exception ex)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000FE4E4 File Offset: 0x000FC6E4
		private void InitializeComponent()
		{
			base.SuspendLayout();
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "Digital_display";
			Size size = new Size(363, 65);
			base.Size = size;
			base.Paint += this.Digital_display_Paint;
			base.ResumeLayout(false);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000FE550 File Offset: 0x000FC750
		private void zifu(Graphics g, int x, int y, int width, int height, char zi, int controlwidth, int controlheight)
		{
			checked
			{
				int num = (int)Math.Round((double)height / 10.0);
				int num2 = (int)Math.Round((double)width / 40.0);
				Point[] array = new Point[4];
				array[0].X = x + num2;
				array[0].Y = y;
				array[1].X = x + num + num2;
				array[1].Y = y + num;
				array[2].X = x + width - num - num2;
				array[2].Y = y + num;
				array[3].X = x + width - num2;
				array[3].Y = y;
				Point[] array2 = new Point[4];
				array2[0].X = x + num + num2;
				array2[0].Y = y + height - num;
				array2[1].X = x + num2;
				array2[1].Y = y + height;
				array2[2].X = x + width - num2;
				array2[2].Y = y + height;
				array2[3].X = x + width - num - num2;
				array2[3].Y = y + height - num;
				Point[] array3 = new Point[5];
				array3[0].X = x;
				array3[0].Y = y + num2;
				array3[1].X = x;
				array3[1].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num2 - (double)num / 2.0));
				array3[2].X = (int)Math.Round(unchecked((double)x + (double)num / 2.0));
				array3[2].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num2));
				array3[3].X = x + num;
				array3[3].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num2 - (double)num / 2.0));
				array3[4].X = x + num;
				array3[4].Y = y + num + num2;
				Point[] array4 = new Point[5];
				array4[0].X = x;
				array4[0].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0 + (double)num2));
				array4[1].X = x;
				array4[1].Y = y + height;
				array4[2].X = x + num;
				array4[2].Y = y + height - num - num2;
				array4[3].X = x + num;
				array4[3].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0 + (double)num2));
				array4[4].X = (int)Math.Round(unchecked((double)x + (double)num / 2.0));
				array4[4].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num2));
				Point[] array5 = new Point[5];
				array5[0].X = x + width - num;
				array5[0].Y = y + num + num2;
				array5[1].X = x + width - num;
				array5[1].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num / 2.0 - (double)num2));
				array5[2].X = (int)Math.Round(unchecked((double)(checked(x + width - num)) + (double)num / 2.0));
				array5[2].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num2));
				array5[3].X = x + width;
				array5[3].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num / 2.0 - (double)num2));
				array5[4].X = x + width;
				array5[4].Y = y + num2;
				Point[] array6 = new Point[5];
				array6[0].X = x + width - num;
				array6[0].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0 + (double)num2));
				array6[1].X = x + width - num;
				array6[1].Y = y + height - num - num2;
				array6[2].X = x + width;
				array6[2].Y = y + height - num2;
				array6[3].X = x + width;
				array6[3].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0 + (double)num2));
				array6[4].X = (int)Math.Round(unchecked((double)(checked(x + width - num)) + (double)num / 2.0));
				array6[4].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num2));
				Point[] array7 = new Point[6];
				array7[0].X = (int)Math.Round(unchecked((double)x + (double)num / 2.0));
				array7[0].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0));
				array7[1].X = x + num;
				array7[1].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0));
				array7[2].X = x + width - num;
				array7[2].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 + (double)num / 2.0));
				array7[3].X = (int)Math.Round(unchecked((double)(checked(x + width - num)) + (double)num / 2.0));
				array7[3].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0));
				array7[4].X = x + width - num;
				array7[4].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num / 2.0));
				array7[5].X = x + num;
				array7[5].Y = (int)Math.Round(unchecked((double)y + (double)height / 2.0 - (double)num / 2.0));
				new Pen(Brushes.Black);
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				switch (zi)
				{
				case ' ':
					flag = false;
					flag2 = false;
					flag3 = false;
					flag4 = false;
					flag5 = false;
					flag6 = false;
					flag7 = false;
					goto IL_A19;
				case '-':
					flag = false;
					flag2 = false;
					flag3 = false;
					flag4 = false;
					flag5 = true;
					flag6 = false;
					flag7 = false;
					goto IL_A19;
				case '0':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = false;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '1':
					flag = false;
					flag2 = false;
					flag3 = false;
					flag4 = false;
					flag5 = false;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '2':
					flag = true;
					flag2 = true;
					flag3 = false;
					flag4 = true;
					flag5 = true;
					flag6 = true;
					flag7 = false;
					goto IL_A19;
				case '3':
					flag = true;
					flag2 = true;
					flag3 = false;
					flag4 = false;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '4':
					flag = false;
					flag2 = false;
					flag3 = true;
					flag4 = false;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '5':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = false;
					flag5 = true;
					flag6 = false;
					flag7 = true;
					goto IL_A19;
				case '6':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = false;
					flag7 = true;
					goto IL_A19;
				case '7':
					flag = true;
					flag2 = false;
					flag3 = false;
					flag4 = false;
					flag5 = false;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '8':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case '9':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = false;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case 'A':
					flag = true;
					flag2 = false;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case 'B':
					flag = false;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = false;
					flag7 = true;
					goto IL_A19;
				case 'C':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = false;
					flag6 = false;
					flag7 = false;
					goto IL_A19;
				case 'D':
					flag = false;
					flag2 = true;
					flag3 = false;
					flag4 = true;
					flag5 = true;
					flag6 = true;
					flag7 = true;
					goto IL_A19;
				case 'E':
					flag = true;
					flag2 = true;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = false;
					flag7 = false;
					goto IL_A19;
				case 'F':
					flag = true;
					flag2 = false;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = false;
					flag7 = false;
					goto IL_A19;
				}
				flag = false;
				flag2 = false;
				flag3 = false;
				flag4 = false;
				flag5 = false;
				flag6 = false;
				flag7 = false;
				IL_A19:
				Rectangle rect = new Rectangle(0, 0, controlwidth, controlheight);
				LinearGradientBrush brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
				if (flag)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array);
				}
				if (flag2)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array2);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array2);
				}
				if (flag3)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array3);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array3);
				}
				if (flag4)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array4);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array4);
				}
				if (flag6)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array5);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array5);
				}
				if (flag7)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array6);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array6);
				}
				if (flag5)
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_true_temp, this.Digital_Color_true_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array7);
				}
				else
				{
					brush = new LinearGradientBrush(rect, this.Digital_Color_fales_temp, this.Digital_Color_fales_temp, LinearGradientMode.Vertical);
					g.FillPolygon(brush, array7);
				}
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x000FF164 File Offset: 0x000FD364
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x0000AA17 File Offset: 0x00008C17
		[Description("背景颜色")]
		[Category("杂项")]
		public Color Background_Color
		{
			get
			{
				return this.Background_Color_temp;
			}
			set
			{
				this.Background_Color_temp = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000FF17C File Offset: 0x000FD37C
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0000AA26 File Offset: 0x00008C26
		[Description("字符串长度")]
		[Category("杂项")]
		public int Character_length
		{
			get
			{
				return this.Character_length_temp;
			}
			set
			{
				this.Character_length_temp = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000FF194 File Offset: 0x000FD394
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0000AA35 File Offset: 0x00008C35
		[Description("数字暗时颜色,建议使用透明色或与背景颜色相同")]
		[Category("杂项")]
		public Color Digital_Color_fales
		{
			get
			{
				return this.Digital_Color_fales_temp;
			}
			set
			{
				this.Digital_Color_fales_temp = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000FF1AC File Offset: 0x000FD3AC
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0000AA44 File Offset: 0x00008C44
		[Description("鼠标放到上面显示的提示文字")]
		[Category("杂项")]
		public string Tips
		{
			get
			{
				return this._tips;
			}
			set
			{
				this._tips = value;
				this.tip.SetToolTip(this, this._tips);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000FF1C4 File Offset: 0x000FD3C4
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0000AA5F File Offset: 0x00008C5F
		[Category("杂项")]
		[Description("数字亮时颜色")]
		public Color Digital_Color_true
		{
			get
			{
				return this.Digital_Color_true_temp;
			}
			set
			{
				this.Digital_Color_true_temp = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000FF1DC File Offset: 0x000FD3DC
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0000AA6E File Offset: 0x00008C6E
		[Description("小数位数")]
		[Category("杂项")]
		public int Scalesdecimal_digits
		{
			get
			{
				return this.Scalesdecimal_digits_temp;
			}
			set
			{
				this.Scalesdecimal_digits_temp = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000FF1F4 File Offset: 0x000FD3F4
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0000AA7D File Offset: 0x00008C7D
		[Description("要显示的值")]
		[Category("杂项")]
		public double value
		{
			get
			{
				return this.shuzhi;
			}
			set
			{
				this.shuzhi = value;
				base.Invalidate();
			}
		}

		// Token: 0x0400107C RID: 4220
		private ToolTip tip;

		// Token: 0x0400107D RID: 4221
		private Color Background_Color_temp;

		// Token: 0x0400107E RID: 4222
		private int Character_length_temp;

		// Token: 0x0400107F RID: 4223
		private IContainer components;

		// Token: 0x04001080 RID: 4224
		private Color Digital_Color_fales_temp;

		// Token: 0x04001081 RID: 4225
		private Color Digital_Color_true_temp;

		// Token: 0x04001082 RID: 4226
		private int Scalesdecimal_digits_temp;

		// Token: 0x04001083 RID: 4227
		private double shuzhi;

		// Token: 0x04001084 RID: 4228
		private string _tips;
	}
}
