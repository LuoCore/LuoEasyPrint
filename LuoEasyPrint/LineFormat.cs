using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A6 RID: 166
	public sealed class LineFormat
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x000080CA File Offset: 0x000062CA
		public LineFormat()
		{
			this._BorderLine = true;
			this.Init();
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000080DF File Offset: 0x000062DF
		public LineFormat(XmlLineFormat xmlStyle) : this()
		{
			this.ParseFormat(xmlStyle);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000C3EF8 File Offset: 0x000C20F8
		public LineFormat(XmlNode style) : this()
		{
			XmlLineFormat xmlLineFormat = new XmlLineFormat(style);
			xmlLineFormat.Parse();
			this.ParseFormat(xmlLineFormat);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000C3F20 File Offset: 0x000C2120
		public Pen CreatePenByProperty()
		{
			PointF pointF = new PointF(0f, 0f);
			PointF start = pointF;
			PointF end = new PointF(0f, 0f);
			return this.CreatePenByProperty(start, end, false);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000C3F5C File Offset: 0x000C215C
		public Pen CreatePenByProperty(PointF start, PointF end)
		{
			return this.CreatePenByProperty(start, end, true);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000C3F74 File Offset: 0x000C2174
		private Pen CreatePenByProperty(PointF start, PointF end, bool checkLinear)
		{
			LinearGradientBrush linearGradientBrush = null;
			if ((!this._LinearColor.IsEmpty || this._LinearColor == this._LineColor) && checkLinear)
			{
				Color color = this._LineColor;
				if (color.IsEmpty)
				{
					color = Color.Black;
				}
				linearGradientBrush = new LinearGradientBrush(start, end, color, this._LinearColor);
				if (this._LinearColorCenter)
				{
					float[] factors = new float[]
					{
						0.2f,
						0.4f,
						0.8f,
						0.8f,
						0.4f,
						0.2f
					};
					float[] positions = new float[]
					{
						0f,
						0.2f,
						0.4f,
						0.6f,
						0.8f,
						1f
					};
					linearGradientBrush.Blend = new Blend
					{
						Factors = factors,
						Positions = positions
					};
				}
			}
			Pen pen;
			if (linearGradientBrush == null)
			{
				pen = new Pen(this._LineColor);
			}
			else
			{
				pen = new Pen(linearGradientBrush);
			}
			pen.Width = this._LineWidth;
			if (this._CustomLineStyle != null && this._CustomLineStyle.Length > 0)
			{
				pen.DashPattern = this._CustomLineStyle;
			}
			else if (this._LineStyle != DashStyle.Solid)
			{
				pen.DashStyle = this._LineStyle;
			}
			if (this._StartCap != LineCap.Flat)
			{
				pen.StartCap = this._StartCap;
			}
			if (this._EndCap != LineCap.Flat)
			{
				pen.EndCap = this._EndCap;
			}
			return pen;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000C410C File Offset: 0x000C230C
		private void Init()
		{
			this._LineColor = Color.Black;
			this._LinearColorCenter = false;
			this._LineWidth = 1f;
			this._LineLength = -1;
			this._Align = HAlignFlag.Center;
			this._VAlign = VAlignFlag.Middle;
			this._StartCap = LineCap.Flat;
			this._EndCap = LineCap.Flat;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000C415C File Offset: 0x000C235C
		private void ParseFormat(XmlLineFormat xmlStyle)
		{
			this._LineColor = XmlParserBase.GetColorFrom(xmlStyle.LineColor);
			if (String.Compare(xmlStyle.LinearColorCenter.Trim().ToLower(), "true", false) == 0 || String.Compare(xmlStyle.LinearColorCenter.Trim(), "1", false) == 0)
			{
				this._LinearColorCenter = true;
			}
			if (String.Compare(xmlStyle.LinearColor, "", false) == 0)
			{
				this._LinearColor = default(Color);
			}
			else
			{
				this._LinearColor = XmlParserBase.GetColorFrom(xmlStyle.LinearColor);
			}
			if (String.Compare(xmlStyle.LineLength.Trim(), "", false) != 0)
			{
				this._LineLength = int.Parse(xmlStyle.LineLength);
			}
			if (String.Compare(xmlStyle.LineWidth.Trim(), "", false) != 0)
			{
				this._LineWidth = (float)int.Parse(xmlStyle.LineWidth);
			}
			if (String.Compare(xmlStyle.Align.Trim(), "", false) != 0)
			{
				string left = xmlStyle.Align.Trim().ToLower();
				if (String.Compare(left, "left", false) == 0)
				{
					this.Align = HAlignFlag.Left;
				}
				else if (String.Compare(left, "center", false) == 0)
				{
					this.Align = HAlignFlag.Center;
				}
				else if (String.Compare(left, "right", false) == 0)
				{
					this.Align = HAlignFlag.Right;
				}
			}
			if (String.Compare(xmlStyle.Align.Trim(), "", false) != 0)
			{
				string left2 = xmlStyle.Valign.Trim().ToLower();
				if (String.Compare(left2, "top", false) == 0)
				{
					this.VAlign = VAlignFlag.Top;
				}
				else if (String.Compare(left2, "middle", false) == 0)
				{
					this.VAlign = VAlignFlag.Middle;
				}
				else if (String.Compare(left2, "bottom", false) == 0)
				{
					this.VAlign = VAlignFlag.Bottom;
				}
			}
			string left3 = xmlStyle.LineStyle.Trim().ToLower();
			if (String.Compare(left3, "solid", false) == 0)
			{
				this._LineStyle = DashStyle.Solid;
			}
			else if (String.Compare(left3, "custom", false) == 0)
			{
				this._LineStyle = DashStyle.Custom;
			}
			else
			{
				if (String.Compare(left3, "dash", false) != 0)
				{
					if (String.Compare(left3, "dashed", false) != 0)
					{
						if (String.Compare(left3, "dot", false) != 0)
						{
							if (String.Compare(left3, "dotted", false) != 0)
							{
								if (String.Compare(left3, "dashdot", false) == 0)
								{
									this._LineStyle = DashStyle.DashDot;
									return;
								}
								if (String.Compare(left3, "dashdotdot", false) == 0)
								{
									this._LineStyle = DashStyle.DashDotDot;
									return;
								}
								this._LineStyle = DashStyle.Solid;
								return;
							}
						}
						this._LineStyle = DashStyle.Dot;
						return;
					}
				}
				this._LineStyle = DashStyle.Dash;
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000080EE File Offset: 0x000062EE
		public void SetLinearColor(Color linearColor, bool linearColorCenter)
		{
			this._LinearColor = linearColor;
			this._LinearColorCenter = linearColorCenter;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x000C43F0 File Offset: 0x000C25F0
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x000080FE File Offset: 0x000062FE
		public HAlignFlag Align
		{
			get
			{
				return this._Align;
			}
			set
			{
				this._Align = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000C4408 File Offset: 0x000C2608
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00008107 File Offset: 0x00006307
		public bool BorderLine
		{
			get
			{
				return this._BorderLine;
			}
			set
			{
				this._BorderLine = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000C441C File Offset: 0x000C261C
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00008110 File Offset: 0x00006310
		public float[] CustomLineStyle
		{
			get
			{
				this._LineStyle = DashStyle.Custom;
				return this._CustomLineStyle;
			}
			set
			{
				this._CustomLineStyle = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000C4438 File Offset: 0x000C2638
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00008119 File Offset: 0x00006319
		public LineCap EndCap
		{
			get
			{
				return this._EndCap;
			}
			set
			{
				this._EndCap = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000C4450 File Offset: 0x000C2650
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00008122 File Offset: 0x00006322
		public Color LinearColor
		{
			get
			{
				return this._LinearColor;
			}
			set
			{
				this._LinearColor = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000C4468 File Offset: 0x000C2668
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0000812B File Offset: 0x0000632B
		public bool LinearColorCenter
		{
			get
			{
				return this._LinearColorCenter;
			}
			set
			{
				this._LinearColorCenter = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000C447C File Offset: 0x000C267C
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00008134 File Offset: 0x00006334
		public Color LineColor
		{
			get
			{
				return this._LineColor;
			}
			set
			{
				this._LineColor = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000C4494 File Offset: 0x000C2694
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0000813D File Offset: 0x0000633D
		public int LineLength
		{
			get
			{
				return this._LineLength;
			}
			set
			{
				this._LineLength = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000C44AC File Offset: 0x000C26AC
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00008146 File Offset: 0x00006346
		public DashStyle LineStyle
		{
			get
			{
				return this._LineStyle;
			}
			set
			{
				this._LineStyle = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000C44C4 File Offset: 0x000C26C4
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0000814F File Offset: 0x0000634F
		public float LineWidth
		{
			get
			{
				return this._LineWidth;
			}
			set
			{
				this._LineWidth = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x000C44DC File Offset: 0x000C26DC
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00008158 File Offset: 0x00006358
		public LineCap StartCap
		{
			get
			{
				return this._StartCap;
			}
			set
			{
				this._StartCap = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000C44F4 File Offset: 0x000C26F4
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00008161 File Offset: 0x00006361
		public VAlignFlag VAlign
		{
			get
			{
				return this._VAlign;
			}
			set
			{
				this._VAlign = value;
			}
		}

		// Token: 0x04000ACE RID: 2766
		private HAlignFlag _Align;

		// Token: 0x04000ACF RID: 2767
		private bool _BorderLine;

		// Token: 0x04000AD0 RID: 2768
		private float[] _CustomLineStyle;

		// Token: 0x04000AD1 RID: 2769
		private LineCap _EndCap;

		// Token: 0x04000AD2 RID: 2770
		private Color _LinearColor;

		// Token: 0x04000AD3 RID: 2771
		private bool _LinearColorCenter;

		// Token: 0x04000AD4 RID: 2772
		private Color _LineColor;

		// Token: 0x04000AD5 RID: 2773
		private int _LineLength;

		// Token: 0x04000AD6 RID: 2774
		private DashStyle _LineStyle;

		// Token: 0x04000AD7 RID: 2775
		private float _LineWidth;

		// Token: 0x04000AD8 RID: 2776
		private LineCap _StartCap;

		// Token: 0x04000AD9 RID: 2777
		private VAlignFlag _VAlign;
	}
}
