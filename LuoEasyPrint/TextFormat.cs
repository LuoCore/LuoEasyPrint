using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x020000A8 RID: 168
	public sealed class TextFormat : IDisposable
	{
		// Token: 0x060016EC RID: 5868 RVA: 0x000081D9 File Offset: 0x000063D9
		public TextFormat()
		{
			this._Wrap = false;
			this._DirectionVertical = false;
			this._Align = HAlignFlag.Left;
			this._VAlign = VAlignFlag.Top;
			this._Font = new Font("宋体", 10f);
			this.Init();
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00008218 File Offset: 0x00006418
		public TextFormat(XmlTextFormat xmlStyle) : this()
		{
			this.ParseFormat(xmlStyle);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000C464C File Offset: 0x000C284C
		public TextFormat(XmlNode style) : this()
		{
			XmlTextFormat xmlTextFormat = new XmlTextFormat(style);
			xmlTextFormat.Parse();
			this.ParseFormat(xmlTextFormat);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00008227 File Offset: 0x00006427
		public void Dispose()
		{
			if (this._Font != null)
			{
				this._Font.Dispose();
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000C4674 File Offset: 0x000C2874
		public StringFormat GetStringFormat()
		{
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.FormatFlags = (stringFormat.FormatFlags | StringFormatFlags.LineLimit | StringFormatFlags.MeasureTrailingSpaces);
			stringFormat.Trimming = StringTrimming.None;
			if (!this._Wrap)
			{
				stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			}
			if (this._DirectionVertical)
			{
				stringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
				stringFormat.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
			}
			switch (this._Align)
			{
			case HAlignFlag.Left:
				stringFormat.Alignment = StringAlignment.Near;
				break;
			case HAlignFlag.Center:
				stringFormat.Alignment = StringAlignment.Center;
				break;
			case HAlignFlag.Right:
				stringFormat.Alignment = StringAlignment.Far;
				break;
			}
			StringFormat result;
			switch (this._VAlign)
			{
			case VAlignFlag.Top:
				stringFormat.LineAlignment = StringAlignment.Near;
				result = stringFormat;
				break;
			case VAlignFlag.Middle:
				stringFormat.LineAlignment = StringAlignment.Center;
				result = stringFormat;
				break;
			case VAlignFlag.Bottom:
				stringFormat.LineAlignment = StringAlignment.Far;
				result = stringFormat;
				break;
			default:
				result = stringFormat;
				break;
			}
			return result;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0000823C File Offset: 0x0000643C
		private void Init()
		{
			this._ForeColor = Color.Black;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000C4750 File Offset: 0x000C2950
		private void ParseFormat(XmlTextFormat xmlStyle)
		{
			if (xmlStyle.ForeColor != null && String.Compare(xmlStyle.ForeColor.Trim(), "", false) != 0)
			{
				this._ForeColor = XmlParserBase.GetColorFrom(xmlStyle.ForeColor);
			}
			else
			{
				this._ForeColor = Color.Black;
			}
			this._Font = xmlStyle.GetFont();
			if (String.Compare(xmlStyle.Wrap.Trim().ToLower(), "true", false) != 0)
			{
				if (String.Compare(xmlStyle.Wrap.Trim(), "1", false) != 0)
				{
					if (String.Compare(xmlStyle.Wrap.Trim(), "", false) != 0)
					{
						goto IL_A4;
					}
				}
			}
			this.Wrap = true;
			IL_A4:
			if (String.Compare(xmlStyle.DirectionVertical.Trim().ToLower(), "true", false) == 0 || String.Compare(xmlStyle.DirectionVertical.Trim(), "1", false) == 0)
			{
				this.DirectionVertical = true;
			}
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
			else
			{
				this.Align = HAlignFlag.Left;
			}
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
			else
			{
				this.VAlign = VAlignFlag.Top;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x000C4900 File Offset: 0x000C2B00
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x00008249 File Offset: 0x00006449
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000C4918 File Offset: 0x000C2B18
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00008252 File Offset: 0x00006452
		public bool DirectionVertical
		{
			get
			{
				return this._DirectionVertical;
			}
			set
			{
				this._DirectionVertical = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x000C492C File Offset: 0x000C2B2C
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0000825B File Offset: 0x0000645B
		public Font Font
		{
			get
			{
				return this._Font;
			}
			set
			{
				this._Font = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000C4944 File Offset: 0x000C2B44
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x00008264 File Offset: 0x00006464
		public Color ForeColor
		{
			get
			{
				return this._ForeColor;
			}
			set
			{
				this._ForeColor = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x000C495C File Offset: 0x000C2B5C
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000826D File Offset: 0x0000646D
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

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000C4974 File Offset: 0x000C2B74
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00008276 File Offset: 0x00006476
		public bool Wrap
		{
			get
			{
				return this._Wrap;
			}
			set
			{
				this._Wrap = value;
			}
		}

		// Token: 0x04000ADE RID: 2782
		private HAlignFlag _Align;

		// Token: 0x04000ADF RID: 2783
		private bool _DirectionVertical;

		// Token: 0x04000AE0 RID: 2784
		private Font _Font;

		// Token: 0x04000AE1 RID: 2785
		private Color _ForeColor;

		// Token: 0x04000AE2 RID: 2786
		private VAlignFlag _VAlign;

		// Token: 0x04000AE3 RID: 2787
		private bool _Wrap;
	}
}
