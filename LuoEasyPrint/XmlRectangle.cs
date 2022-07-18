using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000B9 RID: 185
	public class XmlRectangle : XmlShape
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x000086BF File Offset: 0x000068BF
		public XmlRectangle()
		{
			this._linewidth = 0.5f;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000086D2 File Offset: 0x000068D2
		public XmlRectangle(XmlNode rectangle)
		{
			this._linewidth = 0.5f;
			base.XmlNode = rectangle;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000C7B1C File Offset: 0x000C5D1C
		protected override void ParseMySelf()
		{
			base.ParseMySelf();
			XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(base.XmlNode);
			xmlBorderFormat.Parse();
			this.BorderFormat = xmlBorderFormat;
			if (String.Compare(this.BorderFormat.BorderColor.Trim(), "", false) == 0 && String.Compare(this.Color.Trim(), "", false) != 0)
			{
				this.BorderFormat.BorderColor = this.Color;
			}
			string xmlNodeAttributeValue = this.GetXmlNodeAttributeValue("linewidth");
			if (String.Compare(xmlNodeAttributeValue, "", false) == 0)
			{
				this.LineWidth = 0.5f;
			}
			else
			{
				this.LineWidth = float.Parse(xmlNodeAttributeValue);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x000C7BC8 File Offset: 0x000C5DC8
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x000086EC File Offset: 0x000068EC
		public float LineWidth
		{
			get
			{
				return this._linewidth;
			}
			set
			{
				this._linewidth = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x000C7BE0 File Offset: 0x000C5DE0
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x000C7C2C File Offset: 0x000C5E2C
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000086F5 File Offset: 0x000068F5
		public XmlBorderFormat BorderFormat
		{
			get
			{
				return this._BorderFormat;
			}
			set
			{
				this._BorderFormat = value;
			}
		}

		// Token: 0x04000B3F RID: 2879
		private float _linewidth;

		// Token: 0x04000B40 RID: 2880
		private XmlBorderFormat _BorderFormat;
	}
}
