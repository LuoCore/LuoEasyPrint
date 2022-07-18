using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000B3 RID: 179
	public class XmlLine : XmlShape
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x00008459 File Offset: 0x00006659
		public XmlLine()
		{
			this._linewidth = 0.5f;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0000846C File Offset: 0x0000666C
		public XmlLine(XmlNode line)
		{
			this._linewidth = 0.5f;
			base.XmlNode = line;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000C68EC File Offset: 0x000C4AEC
		protected override void ParseMySelf()
		{
			base.ParseMySelf();
			XmlLineFormat xmlLineFormat = new XmlLineFormat(base.XmlNode);
			xmlLineFormat.Parse();
			this.LineFormat = xmlLineFormat;
			if (String.Compare(this._LineFormat.LineColor.Trim(), "", false) == 0 && String.Compare(this.Color.Trim(), "", false) != 0)
			{
				this._LineFormat.LineColor = this.Color;
			}
			this._X2 = this.GetXmlNodeAttributeValue("X2");
			this._Y2 = this.GetXmlNodeAttributeValue("Y2");
			if (String.Compare(this._LineFormat.LineWidth, "", false) == 0)
			{
				this._linewidth = 0.5f;
			}
			else
			{
				this._linewidth = float.Parse(this._LineFormat.LineWidth);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x000C69C0 File Offset: 0x000C4BC0
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00008486 File Offset: 0x00006686
		public XmlLineFormat LineFormat
		{
			get
			{
				return this._LineFormat;
			}
			set
			{
				this._LineFormat = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x000C69D8 File Offset: 0x000C4BD8
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x0000848F File Offset: 0x0000668F
		public string X2
		{
			get
			{
				return this._X2;
			}
			set
			{
				this._X2 = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000C69F0 File Offset: 0x000C4BF0
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x00008498 File Offset: 0x00006698
		public string Y2
		{
			get
			{
				return this._Y2;
			}
			set
			{
				this._Y2 = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000C6A08 File Offset: 0x000C4C08
		public float LineWidth
		{
			get
			{
				return this._linewidth;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x000C6A20 File Offset: 0x000C4C20
		public Color LineColor
		{
			get
			{
				Color result;
				if (String.Compare(base.Color, "", false) == 0)
				{
					result = System.Drawing.Color.Black;
				}
				else
				{
					Color colorFrom = XmlParserBase.GetColorFrom(base.Color);
					if (colorFrom.IsEmpty)
					{
						result = System.Drawing.Color.Black;
					}
					else
					{
						result = colorFrom;
					}
				}
				return result;
			}
		}

		// Token: 0x04000B17 RID: 2839
		private float _linewidth;

		// Token: 0x04000B18 RID: 2840
		private XmlLineFormat _LineFormat;

		// Token: 0x04000B19 RID: 2841
		private string _X2;

		// Token: 0x04000B1A RID: 2842
		private string _Y2;
	}
}
