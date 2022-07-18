using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000039 RID: 57
	[Description("绘制标尺的控件")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerGenerated]
	[ToolboxItem(false)]
	public class Ruler : UserControl
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x00056E60 File Offset: 0x00055060
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

		// Token: 0x0600096C RID: 2412 RVA: 0x00056EA0 File Offset: 0x000550A0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new Label();
			this.SuspendLayout();
			this.Label1.BackColor = Color.FromArgb(192, 255, 192);
			this.Label1.BorderStyle = BorderStyle.FixedSingle;
			this.Label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Label1.ForeColor = Color.FromArgb(0, 0, 192);
			Control label = this.Label1;
			Point location = new Point(64, -2);
			label.Location = location;
			this.Label1.Name = "Label1";
			Control label2 = this.Label1;
			Size size = new Size(100, 23);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			this.Label1.Visible = false;
			SizeF autoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			this.BorderStyle = BorderStyle.Fixed3D;
			this.Controls.Add(this.Label1);
			this.Cursor = Cursors.Default;
			this.DoubleBuffered = true;
			this.Name = "Ruler";
			size = new Size(263, 31);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00057004 File Offset: 0x00055204
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000046BB File Offset: 0x000028BB
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0005701C File Offset: 0x0005521C
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000046C4 File Offset: 0x000028C4
		public bool IsUserCentimeter
		{
			get
			{
				return this.myIsUserCentimeter;
			}
			set
			{
				this.myIsUserCentimeter = value;
				this.ReDrawLable();
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00057030 File Offset: 0x00055230
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x000046D3 File Offset: 0x000028D3
		public bool Direction
		{
			get
			{
				return this.myDirection;
			}
			set
			{
				this.myDirection = value;
				if (value)
				{
					this.Label1.TextAlign = ContentAlignment.TopCenter;
				}
				else
				{
					this.Label1.TextAlign = ContentAlignment.MiddleLeft;
				}
				this.Refresh();
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00057044 File Offset: 0x00055244
		public float GetX
		{
			get
			{
				return this.myx;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0005705C File Offset: 0x0005525C
		public float GetY
		{
			get
			{
				return this.myy;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00057074 File Offset: 0x00055274
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00004700 File Offset: 0x00002900
		public Color LineColor
		{
			get
			{
				return this.myLineColor;
			}
			set
			{
				this.myLineColor = value;
				this.Refresh();
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0005708C File Offset: 0x0005528C
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0000470F File Offset: 0x0000290F
		public Color TextColor
		{
			get
			{
				return this.myTextColor;
			}
			set
			{
				this.myTextColor = value;
				this.Refresh();
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000570A4 File Offset: 0x000552A4
		public float ConvertToMM(float tt, bool isX)
		{
			float result;
			if (isX)
			{
				result = (float)((double)(tt / this.myx) * 2.54 * 10.0);
			}
			else
			{
				result = (float)((double)(tt / this.myy) * 2.54 * 10.0);
			}
			return result;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000570F8 File Offset: 0x000552F8
		public float ConvertToPoint(float tt, bool isx)
		{
			float num = this.ConvertToMM(tt, isx);
			return (float)((double)(num * 72f) / 25.4);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00057124 File Offset: 0x00055324
		public float ConvertToPointFromMM(float tt)
		{
			return (float)((double)(tt * 72f) / 25.4);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00057148 File Offset: 0x00055348
		public float ConvertFromMM(float tt, bool isx)
		{
			float result;
			if (isx)
			{
				result = (float)((double)(tt * this.myx) / 2.54 / 10.0);
			}
			else
			{
				result = (float)((double)(tt * this.myy) / 2.54 / 10.0);
			}
			return result;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000471E File Offset: 0x0000291E
		private void Ruler_Load(object sender, EventArgs e)
		{
			if (this.Controls.Count >= 5)
			{
				this.ReDrawLable();
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0005719C File Offset: 0x0005539C
		private void ReDrawLable()
		{
			checked
			{
				try
				{
					if (this.IsUserCentimeter)
					{
						int num = 0;
						int num2 = (int)Math.Round((double)this.MaxWidth / 10.0);
						for (int i = num; i <= num2; i++)
						{
							Label label = (Label)this.Controls["t" + Convert.ToString(i)];
							label.Text = Convert.ToString(i);
						}
					}
					else
					{
						int num3 = 0;
						int num4 = (int)Math.Round((double)this.MaxWidth / 10.0);
						for (int i = num3; i <= num4; i++)
						{
							Label label = (Label)this.Controls["t" + Convert.ToString(i)];
							label.Text = Convert.ToString(i * 10);
						}
					}
					this.MyRefresh();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00057284 File Offset: 0x00055484
		private void Ruler_Resize(object sender, EventArgs e)
		{
			checked
			{
				if (this.Direction)
				{
					this.Label1.Height = (int)Math.Round(unchecked((double)this.Height / 3.0 * 1.5));
					this.Label1.Top = this.Height - this.Label1.Height;
				}
				else
				{
					this.Label1.Width = (int)Math.Round(unchecked((double)this.Width / 3.0 * 1.5));
					this.Label1.Left = this.Width - this.Label1.Width;
				}
				if (this.Controls.Count >= 5)
				{
					this.MyRefresh();
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00057344 File Offset: 0x00055544
		public void MyRefresh()
		{
			int num = 0;
			Label label = null;
			this.Visible = false;
			num = 0;
			Label label2 = null;
			label = null;
			checked
			{
				try
				{
					if (this.myDirection)
					{
						label = (Label)this.Controls["t0"];
						label.Left = (int)Math.Round((double)this.ConvertFromMM((float)num, true));
						label.Top = 0;
						label.ForeColor = this.TextColor;
						label.Visible = true;
						label.BringToFront();
						label2 = (Label)this.Controls["l0"];
						label2.SetBounds(0, 0, 1, this.Height);
						label2.Visible = true;
						label2.BringToFront();
						int num2 = this.mystep;
						int maxWidth = this.MaxWidth;
						int num3 = this.mystep;
						num = num2;
						while ((num3 >> 31 ^ num) <= (num3 >> 31 ^ maxWidth))
						{
							label2 = (Label)this.Controls["l" + Convert.ToString(num)];
							label2.Width = 1;
							if (num % 10 != 0)
							{
								goto IL_187;
							}
							label2.SetBounds((int)Math.Round((double)this.ConvertFromMM((float)num, true)), 0, 1, this.Height);
							label = (Label)this.Controls["t" + Convert.ToString((double)num / 10.0)];
							label.Left = (int)Math.Round((double)this.ConvertFromMM((float)num, true));
							label.Top = 0;
							label.ForeColor = this.TextColor;
							try
							{
								label.Visible = true;
								goto IL_25A;
							}
							catch (Exception ex)
							{
								goto IL_25A;
							}
							goto IL_187;
							IL_25A:
							label.BringToFront();
							IL_243:
							label2.Visible = true;
							label2.BringToFront();
							num += num3;
							continue;
							IL_187:
							if (num % 5 == 0)
							{
								label2.SetBounds((int)Math.Round((double)this.ConvertFromMM((float)num, true)), (int)Math.Round((double)(unchecked((float)this.Height - (float)((double)this.Height / 3.0 * 2.0)))), 1, (int)Math.Round(unchecked((double)this.Height / 3.0 * 2.0)));
								goto IL_243;
							}
							label2.SetBounds((int)Math.Round((double)this.ConvertFromMM((float)num, true)), (int)Math.Round((double)(unchecked((float)this.Height - (float)((double)this.Height / 3.0)))), 1, (int)Math.Round((double)this.Height / 3.0));
							goto IL_243;
						}
					}
					else
					{
						label = (Label)this.Controls["t0"];
						label.Top = (int)Math.Round((double)this.ConvertFromMM((float)num, false));
						label.Left = 0;
						label.ForeColor = this.TextColor;
						label.Visible = true;
						label.BringToFront();
						label2 = (Label)this.Controls["l0"];
						label2.BringToFront();
						label2.SetBounds(0, 0, this.Width, 1);
						label2.Visible = true;
						int num4 = this.mystep;
						int maxWidth2 = this.MaxWidth;
						int num5 = this.mystep;
						num = num4;
						while ((num5 >> 31 ^ num) <= (num5 >> 31 ^ maxWidth2))
						{
							label2 = (Label)this.Controls["l" + Convert.ToString(num)];
							if (num % 10 == 0)
							{
								label2.SetBounds(0, (int)Math.Round((double)this.ConvertFromMM((float)num, true)), this.Width, 1);
								label = (Label)this.Controls["t" + Convert.ToString((double)num / 10.0)];
								label.Top = (int)Math.Round((double)this.ConvertFromMM((float)num, false));
								label.Left = 0;
								label.ForeColor = this.TextColor;
								label.Visible = true;
								label.BringToFront();
							}
							else if (num % 5 == 0)
							{
								label2.SetBounds((int)Math.Round(unchecked((double)this.Width - (double)this.Width / 3.0 * 2.0)), (int)Math.Round((double)this.ConvertFromMM((float)num, true)), (int)Math.Round(unchecked((double)this.Width / 3.0 * 2.0)), 1);
							}
							else
							{
								label2.SetBounds((int)Math.Round(unchecked((double)this.Width - (double)this.Width / 3.0)), (int)Math.Round((double)this.ConvertFromMM((float)num, true)), (int)Math.Round((double)this.Width / 3.0), 1);
							}
							label2.Visible = true;
							label2.BringToFront();
							num += num5;
						}
					}
				}
				catch (Exception ex2)
				{
				}
				this.Visible = true;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00004734 File Offset: 0x00002934
		public void SetLableVisible(bool isvisible)
		{
			this.Label1.Visible = isvisible;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00057824 File Offset: 0x00055A24
		public void SetLabelPos(float xory, int widthorheight, bool iswidth, float baseheight)
		{
			checked
			{
				if (this.Direction)
				{
					this.Label1.SetBounds((int)Math.Round((double)xory), this.Label1.Top, widthorheight, this.Label1.Height);
				}
				else
				{
					this.Label1.SetBounds(this.Label1.Left, (int)Math.Round((double)(unchecked(baseheight + xory))), this.Label1.Width, widthorheight);
				}
				try
				{
					this.Label1.Refresh();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000578C0 File Offset: 0x00055AC0
		public Ruler()
		{
			base.Load += this.Ruler_Load;
			base.Resize += this.Ruler_Resize;
			this.myDirection = true;
			this.myTextColor = Color.Red;
			this.myLineColor = Color.Blue;
			this.MaxWidth = 500;
			this.myIsUserCentimeter = true;
			this.mystep = 10;
			this.InitializeComponent();
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.UpdateStyles();
			this.myx = this.CreateGraphics().DpiX;
			this.myy = this.CreateGraphics().DpiY;
			this.Label1.SendToBack();
			int num = 0;
			int maxWidth = this.MaxWidth;
			int num2 = this.mystep;
			int i = num;
			checked
			{
				while ((num2 >> 31 ^ i) <= (num2 >> 31 ^ maxWidth))
				{
					Label label = new Label();
					label.Visible = false;
					label.SetBounds(0, 10, 1, 1);
					label.Text = "";
					label.Name = "l" + Convert.ToString(i);
					label.BorderStyle = BorderStyle.FixedSingle;
					this.Controls.Add(label);
					label.BringToFront();
					i += num2;
				}
				int num3 = 0;
				int num4 = (int)Math.Round((double)this.MaxWidth / 10.0);
				for (i = num3; i <= num4; i++)
				{
					Label label2 = new Label();
					label2.Visible = false;
					label2.Left = 0;
					label2.AutoSize = true;
					label2.Text = Convert.ToString(i);
					label2.Name = "t" + Convert.ToString(i);
					label2.BorderStyle = BorderStyle.None;
					this.Controls.Add(label2);
				}
				try
				{
					this.MyRefresh();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x04000522 RID: 1314
		private IContainer components;

		// Token: 0x04000523 RID: 1315
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000524 RID: 1316
		private bool myDirection;

		// Token: 0x04000525 RID: 1317
		private float myx;

		// Token: 0x04000526 RID: 1318
		private float myy;

		// Token: 0x04000527 RID: 1319
		private Color myTextColor;

		// Token: 0x04000528 RID: 1320
		private Color myLineColor;

		// Token: 0x04000529 RID: 1321
		private int MaxWidth;

		// Token: 0x0400052A RID: 1322
		private bool myIsUserCentimeter;

		// Token: 0x0400052B RID: 1323
		private int mystep;
	}
}
