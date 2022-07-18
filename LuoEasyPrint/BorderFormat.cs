using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x020000A5 RID: 165
	public sealed class BorderFormat
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x0000802E File Offset: 0x0000622E
		public BorderFormat()
		{
			this.Init();
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000803C File Offset: 0x0000623C
		public BorderFormat(XmlBorderFormat xmlStyle) : this()
		{
			this.ParseFormat(xmlStyle);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000C3C38 File Offset: 0x000C1E38
		public BorderFormat(XmlNode style) : this()
		{
			XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(style);
			xmlBorderFormat.Parse();
			this.ParseFormat(xmlBorderFormat);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0000804B File Offset: 0x0000624B
		private void Init()
		{
			this._BorderWidth = 1f;
			this._borderEdge = (BorderEdgeFlags.Bottom | BorderEdgeFlags.Left | BorderEdgeFlags.Right | BorderEdgeFlags.Top);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000C3C60 File Offset: 0x000C1E60
		private void ParseFormat(XmlBorderFormat xmlStyle)
		{
			if (String.Compare(xmlStyle.BackColor, "", false) == 0)
			{
				this._BackColor = default(Color);
			}
			else
			{
				this._BackColor = XmlParserBase.GetColorFrom(xmlStyle.BackColor);
			}
			this._Background = xmlStyle.Background;
			this._BorderColor = XmlParserBase.GetColorFrom(xmlStyle.BorderColor);
			this._BorderColorDark = XmlParserBase.GetColorFrom(xmlStyle.BorderColorDark);
			this._BorderColorLight = XmlParserBase.GetColorFrom(xmlStyle.BorderColorLight);
			this._BorderColorFocus = XmlParserBase.GetColorFrom(xmlStyle.BorderColorFocus);
			string left = xmlStyle.BorderStyle.Trim().ToLower();
			if (String.Compare(left, "solid", false) == 0)
			{
				this._BorderStyle = DashStyle.Solid;
			}
			else if (String.Compare(left, "custom", false) == 0)
			{
				this._BorderStyle = DashStyle.Custom;
			}
			else
			{
				if (String.Compare(left, "dash", false) != 0)
				{
					if (String.Compare(left, "dashed", false) != 0)
					{
						if (String.Compare(left, "dot", false) != 0)
						{
							if (String.Compare(left, "dotted", false) != 0)
							{
								if (String.Compare(left, "dashdot", false) == 0)
								{
									this._BorderStyle = DashStyle.DashDot;
									goto IL_153;
								}
								if (String.Compare(left, "dashdotdot", false) == 0)
								{
									this._BorderStyle = DashStyle.DashDotDot;
									goto IL_153;
								}
								this._BorderStyle = DashStyle.Solid;
								goto IL_153;
							}
						}
						this._BorderStyle = DashStyle.Dot;
						goto IL_153;
					}
				}
				this._BorderStyle = DashStyle.Dash;
			}
			IL_153:
			if (String.Compare(xmlStyle.BorderWidth.Trim(), "", false) != 0)
			{
				this._BorderWidth = float.Parse(xmlStyle.BorderWidth.Trim());
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x000C3DF0 File Offset: 0x000C1FF0
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x00008060 File Offset: 0x00006260
		public Color BackColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				this._BackColor = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x000C3E08 File Offset: 0x000C2008
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00008069 File Offset: 0x00006269
		public string Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x000C3E20 File Offset: 0x000C2020
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00008072 File Offset: 0x00006272
		public Color BorderColor
		{
			get
			{
				return this._BorderColor;
			}
			set
			{
				this._BorderColor = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x000C3E38 File Offset: 0x000C2038
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000807B File Offset: 0x0000627B
		public Color BorderColorDark
		{
			get
			{
				return this._BorderColorDark;
			}
			set
			{
				this._BorderColorDark = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x000C3E50 File Offset: 0x000C2050
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x00008084 File Offset: 0x00006284
		public Color BorderColorFocus
		{
			get
			{
				return this._BorderColorFocus;
			}
			set
			{
				this._BorderColorFocus = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x000C3E68 File Offset: 0x000C2068
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0000808D File Offset: 0x0000628D
		public Color BorderColorLight
		{
			get
			{
				return this._BorderColorLight;
			}
			set
			{
				this._BorderColorLight = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x000C3E80 File Offset: 0x000C2080
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x00008096 File Offset: 0x00006296
		public LineJoin BorderJoin
		{
			get
			{
				return this._BorderJoin;
			}
			set
			{
				this._BorderJoin = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x000C3E98 File Offset: 0x000C2098
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000809F File Offset: 0x0000629F
		public BorderEdgeFlags BordersEdge
		{
			get
			{
				return this._borderEdge;
			}
			set
			{
				this._borderEdge = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000C3EB0 File Offset: 0x000C20B0
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x000080A8 File Offset: 0x000062A8
		public DashStyle BorderStyle
		{
			get
			{
				return this._BorderStyle;
			}
			set
			{
				this._BorderStyle = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000C3EC8 File Offset: 0x000C20C8
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x000080B1 File Offset: 0x000062B1
		public float BorderWidth
		{
			get
			{
				return this._BorderWidth;
			}
			set
			{
				this._BorderWidth = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000C3EE0 File Offset: 0x000C20E0
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x000080BA File Offset: 0x000062BA
		public float[] CustomBorderStyle
		{
			get
			{
				return this._CustomBorderStyle;
			}
			set
			{
				this._BorderStyle = DashStyle.Custom;
				this._CustomBorderStyle = value;
			}
		}

		// Token: 0x04000AC3 RID: 2755
		private Color _BackColor;

		// Token: 0x04000AC4 RID: 2756
		private string _Background;

		// Token: 0x04000AC5 RID: 2757
		private Color _BorderColor;

		// Token: 0x04000AC6 RID: 2758
		private Color _BorderColorDark;

		// Token: 0x04000AC7 RID: 2759
		private Color _BorderColorFocus;

		// Token: 0x04000AC8 RID: 2760
		private Color _BorderColorLight;

		// Token: 0x04000AC9 RID: 2761
		private BorderEdgeFlags _borderEdge;

		// Token: 0x04000ACA RID: 2762
		private LineJoin _BorderJoin;

		// Token: 0x04000ACB RID: 2763
		private DashStyle _BorderStyle;

		// Token: 0x04000ACC RID: 2764
		private float _BorderWidth;

		// Token: 0x04000ACD RID: 2765
		private float[] _CustomBorderStyle;
	}
}
