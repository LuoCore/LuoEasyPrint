using System;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000B4 RID: 180
	public sealed class XmlLineFormat : XmlParserBase
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x000084A1 File Offset: 0x000066A1
		public XmlLineFormat()
		{
			this.Init();
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000084AF File Offset: 0x000066AF
		public XmlLineFormat(XmlNode format) : this()
		{
			this._XmlNode = format;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002590 File Offset: 0x00000790
		private void Init()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000C6A6C File Offset: 0x000C4C6C
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000C6A84 File Offset: 0x000C4C84
		private void ParseXmlNode()
		{
			this._LineColor = this.GetXmlNodeAttributeValue("LineColor");
			this._LinearColor = this.GetXmlNodeAttributeValue("LinearColor");
			this._LinearColorCenter = this.GetXmlNodeAttributeValue("LinearColorCenter");
			this._LineLength = this.GetXmlNodeAttributeValue("LineLength");
			this._LineWidth = this.GetXmlNodeAttributeValue("LineWidth");
			string text = this._Align;
			string xmlNodeCompatibleAttributeValue = base.GetXmlNodeCompatibleAttributeValue(ref text, "Align");
			string text2 = this._Align;
			string xmlNodeCompatibleAttributeValue2 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "HorizontalAlign");
			string align = this._Align;
			this._Align = xmlNodeCompatibleAttributeValue + xmlNodeCompatibleAttributeValue2 + base.GetXmlNodeCompatibleAttributeValue(ref align, "Halign");
			text = this._Valign;
			string xmlNodeCompatibleAttributeValue3 = base.GetXmlNodeCompatibleAttributeValue(ref text, "Valign");
			text2 = this._Valign;
			this._Valign = xmlNodeCompatibleAttributeValue3 + base.GetXmlNodeCompatibleAttributeValue(ref text2, "VerticalAlign");
			this._LineStyle = this.GetXmlNodeAttributeValue("Style");
			this._CustomLineStyle = this.GetXmlNodeAttributeValue("CustomLineStyle");
			this._StartCap = this.GetXmlNodeAttributeValue("StartCap");
			this._EndCap = this.GetXmlNodeAttributeValue("EndCap");
			XmlNode xmlNode = base.GetXmlNodeStyleChildNode();
			if (xmlNode != null)
			{
				XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(xmlNode, "LineFormat");
				if (xmlNodeChildNodeByName != null)
				{
					xmlNode = xmlNodeChildNodeByName;
				}
				this._LineColor += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LineColor");
				this._LinearColor += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LinearColor");
				this._LinearColorCenter += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LinearColorCenter");
				this._LineLength += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LineLength");
				this._LineWidth += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LineWidth");
				this._Align += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "Align");
				this._Valign += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "Valign");
				this._LineStyle += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "LineStyle");
				this._CustomLineStyle += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "CustomLineStyle");
				this._StartCap += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "StartShape");
				this._EndCap += XmlParserBase.GetXmlNodeChildNodeValue(xmlNode, "EndShape");
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000C6CF8 File Offset: 0x000C4EF8
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x000084BE File Offset: 0x000066BE
		public string Align
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x000C6D10 File Offset: 0x000C4F10
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x000084C7 File Offset: 0x000066C7
		public string CustomLineStyle
		{
			get
			{
				return this._CustomLineStyle;
			}
			set
			{
				this._CustomLineStyle = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x000C6D28 File Offset: 0x000C4F28
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x000084D0 File Offset: 0x000066D0
		public string EndShape
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000C6D40 File Offset: 0x000C4F40
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x000084D9 File Offset: 0x000066D9
		public string LinearColor
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

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000C6D58 File Offset: 0x000C4F58
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x000084E2 File Offset: 0x000066E2
		public string LinearColorCenter
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x000C6D70 File Offset: 0x000C4F70
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x000084EB File Offset: 0x000066EB
		public string LineColor
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

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x000C6D88 File Offset: 0x000C4F88
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x000084F4 File Offset: 0x000066F4
		public string LineLength
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

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x000C6DA0 File Offset: 0x000C4FA0
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x000084FD File Offset: 0x000066FD
		public string LineStyle
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

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x000C6DB8 File Offset: 0x000C4FB8
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x00008506 File Offset: 0x00006706
		public string LineWidth
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x000C6DD0 File Offset: 0x000C4FD0
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0000850F File Offset: 0x0000670F
		public string StartShape
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x000C6DE8 File Offset: 0x000C4FE8
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x00008518 File Offset: 0x00006718
		public string Valign
		{
			get
			{
				return this._Valign;
			}
			set
			{
				this._Valign = value;
			}
		}

		// Token: 0x04000B1B RID: 2843
		private string _Align;

		// Token: 0x04000B1C RID: 2844
		private string _CustomLineStyle;

		// Token: 0x04000B1D RID: 2845
		private string _EndCap;

		// Token: 0x04000B1E RID: 2846
		private string _LinearColor;

		// Token: 0x04000B1F RID: 2847
		private string _LinearColorCenter;

		// Token: 0x04000B20 RID: 2848
		private string _LineColor;

		// Token: 0x04000B21 RID: 2849
		private string _LineLength;

		// Token: 0x04000B22 RID: 2850
		private string _LineStyle;

		// Token: 0x04000B23 RID: 2851
		private string _LineWidth;

		// Token: 0x04000B24 RID: 2852
		private string _StartCap;

		// Token: 0x04000B25 RID: 2853
		private string _Valign;
	}
}
