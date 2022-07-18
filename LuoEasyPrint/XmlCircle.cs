using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000AC RID: 172
	public class XmlCircle : XmlShape
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x000082F1 File Offset: 0x000064F1
		public XmlCircle()
		{
			this._linewidth = 0.5f;
			this._DotCenter = "False";
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0000830F File Offset: 0x0000650F
		public XmlCircle(XmlNode shape)
		{
			this._linewidth = 0.5f;
			this._DotCenter = "False";
			base.XmlNode = shape;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000C563C File Offset: 0x000C383C
		protected override void ParseMySelf()
		{
			base.ParseMySelf();
			this._DotCenter = this.GetXmlNodeAttributeValue("DotCenter");
			if (String.Compare(this._DotCenter.Trim(), "", false) == 0)
			{
				this._DotCenter = this.GetXmlNodeChildNodeValue("DotCenter");
			}
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
				this._linewidth = 0.5f;
			}
			else
			{
				this._linewidth = float.Parse(xmlNodeAttributeValue);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000C5720 File Offset: 0x000C3920
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00008334 File Offset: 0x00006534
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000C5738 File Offset: 0x000C3938
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000833D File Offset: 0x0000653D
		public string DotCenter
		{
			get
			{
				return this._DotCenter;
			}
			set
			{
				this._DotCenter = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000C5750 File Offset: 0x000C3950
		public float LineWidth
		{
			get
			{
				return this._linewidth;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x000C5768 File Offset: 0x000C3968
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

		// Token: 0x04000AF1 RID: 2801
		private float _linewidth;

		// Token: 0x04000AF2 RID: 2802
		private XmlBorderFormat _BorderFormat;

		// Token: 0x04000AF3 RID: 2803
		private string _DotCenter;
	}
}
