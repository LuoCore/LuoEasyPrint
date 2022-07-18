using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000AB RID: 171
	public sealed class XmlBorderFormat : XmlParserBase, ICloneable
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x0000827F File Offset: 0x0000647F
		public XmlBorderFormat()
		{
			this.Init();
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0000828D File Offset: 0x0000648D
		public XmlBorderFormat(XmlNode format) : this()
		{
			this._XmlNode = format;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000C4988 File Offset: 0x000C2B88
		public object Clone()
		{
			return new XmlBorderFormat
			{
				BackColor = this._BackColor,
				Background = this._Background,
				BorderColor = this._BorderColor,
				BorderStyle = this._BorderStyle,
				BorderWidth = this._BorderWidth,
				BorderColorLight = this._BorderColorLight,
				BorderColorDark = this._BorderColorDark,
				BorderColorFocus = this._BorderColorFocus
			};
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000C4A00 File Offset: 0x000C2C00
		public object CloneNoEmpty(XmlBorderFormat relative)
		{
			XmlBorderFormat xmlBorderFormat = new XmlBorderFormat();
			if (relative.BackColor == null || String.Compare(relative.BackColor, "", false) == 0)
			{
				xmlBorderFormat.BackColor = this._BackColor;
			}
			if (relative.Background == null || String.Compare(relative.Background, "", false) == 0)
			{
				xmlBorderFormat.Background = this._Background;
			}
			if (relative.BorderColor == null || String.Compare(relative.BorderColor, "", false) == 0)
			{
				xmlBorderFormat.BorderColor = this._BorderColor;
			}
			if (relative.BorderStyle == null || String.Compare(relative.BorderStyle, "", false) == 0)
			{
				xmlBorderFormat.BorderStyle = this._BorderStyle;
			}
			if (relative.BorderWidth == null || String.Compare(relative.BorderWidth, "", false) == 0)
			{
				xmlBorderFormat.BorderWidth = this._BorderWidth;
			}
			if (relative.BorderColorLight == null || String.Compare(relative.BorderColorLight, "", false) == 0)
			{
				xmlBorderFormat.BorderColorLight = this._BorderColorLight;
			}
			if (relative.BorderColorDark == null || String.Compare(relative.BorderColorDark, "", false) == 0)
			{
				xmlBorderFormat.BorderColorDark = this._BorderColorDark;
			}
			if (relative.BorderColorFocus == null || String.Compare(relative.BorderColorFocus, "", false) == 0)
			{
				xmlBorderFormat.BorderColorFocus = this._BorderColorFocus;
			}
			return xmlBorderFormat;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000C4B58 File Offset: 0x000C2D58
		private string GetXmlNodeCompatibleNodeValue(ref string existValue, XmlNode parentNode, string sonNodeName, string sonChildNodeName)
		{
			string result;
			if (existValue != null && String.Compare(existValue, "", false) != 0)
			{
				result = "";
			}
			else
			{
				if (sonChildNodeName != null)
				{
					if (String.Compare(sonChildNodeName, "", false) != 0)
					{
						string xmlNodeChildNodeValue = XmlParserBase.GetXmlNodeChildNodeValue(parentNode, sonNodeName);
						if (String.Compare(xmlNodeChildNodeValue, "", false) != 0)
						{
							existValue = xmlNodeChildNodeValue;
							return xmlNodeChildNodeValue;
						}
						existValue = this.GetXmlNodeChildNodeValue(parentNode, sonNodeName, sonChildNodeName);
						return existValue;
					}
				}
				existValue = XmlParserBase.GetXmlNodeChildNodeValue(parentNode, sonNodeName);
				result = existValue;
			}
			return result;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0000829C File Offset: 0x0000649C
		private void Init()
		{
			this._BorderColorFocus = "";
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000C4BDC File Offset: 0x000C2DDC
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000C4BF4 File Offset: 0x000C2DF4
		private void ParseXmlNode()
		{
			switch (this._ReportDesigner)
			{
			case ReportDesigner.HtmlDesigner:
				this._BackColor = this.GetXmlNodeAttributeValue("bgcolor");
				this._Background = this.GetXmlNodeAttributeValue("background");
				this._BorderStyle = this.GetXmlNodeAttributeValue("borderstyle");
				this._BorderWidth = this.GetXmlNodeAttributeValue("border");
				this._BorderColor = this.GetXmlNodeAttributeValue("bordercolor");
				this._BorderColorLight = this.GetXmlNodeAttributeValue("bordercolorlight");
				this._BorderColorDark = this.GetXmlNodeAttributeValue("bordercolordark");
				this._BorderColorFocus = this.GetXmlNodeAttributeValue("BorderColorFocus");
				break;
			case ReportDesigner.VS2003WebDesigner:
				this._BackColor = this.GetXmlNodeAttributeValue("BackColor");
				this._Background = this.GetXmlNodeAttributeValue("BackImageUrl");
				this._BorderStyle = this.GetXmlNodeAttributeValue("BorderStyle");
				this._BorderWidth = this.GetXmlNodeAttributeValue("BorderWidth");
				this._BorderColor = this.GetXmlNodeAttributeValue("BorderColor");
				this._BorderColorLight = this.GetXmlNodeAttributeValue("BorderColorLight");
				this._BorderColorDark = this.GetXmlNodeAttributeValue("BorderColorDark");
				break;
			case ReportDesigner.VS2005ReportDesigner:
			{
				XmlNode xmlNodeStyleChildNode = base.GetXmlNodeStyleChildNode();
				if (xmlNodeStyleChildNode != null)
				{
					this._BackColor = XmlParserBase.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BackgroundColor");
					this._Background = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BackgroundImage", "Value");
					this._BorderStyle = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BorderStyle", "Default");
					this._BorderWidth = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BorderWidth", "Default");
					this._BorderColor = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BorderColor", "Default");
					this._BorderColorLight = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BorderColor", "Left");
					this._BorderColorDark = this.GetXmlNodeChildNodeValue(xmlNodeStyleChildNode, "BorderColor", "Bottom");
				}
				break;
			}
			default:
			{
				string text = this._BackColor;
				string xmlNodeCompatibleAttributeValue = base.GetXmlNodeCompatibleAttributeValue(ref text, "bgcolor");
				string text2 = this._BackColor;
				string xmlNodeCompatibleAttributeValue2 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "BackColor");
				string text3 = this._BackColor;
				this._BackColor = xmlNodeCompatibleAttributeValue + xmlNodeCompatibleAttributeValue2 + base.GetXmlNodeCompatibleAttributeValue(ref text3, "BackgroundColor");
				text3 = this._Background;
				string xmlNodeCompatibleAttributeValue3 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "background");
				text2 = this._Background;
				string xmlNodeCompatibleAttributeValue4 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "BackImageUrl");
				text = this._Background;
				this._Background = xmlNodeCompatibleAttributeValue3 + xmlNodeCompatibleAttributeValue4 + base.GetXmlNodeCompatibleAttributeValue(ref text, "BackgroundImage");
				text = this._BorderStyle;
				this._BorderStyle = base.GetXmlNodeCompatibleAttributeValue(ref text, "borderstyle");
				text = this._BorderWidth;
				string xmlNodeCompatibleAttributeValue5 = base.GetXmlNodeCompatibleAttributeValue(ref text, "Border");
				text2 = this._BorderWidth;
				this._BorderWidth = xmlNodeCompatibleAttributeValue5 + base.GetXmlNodeCompatibleAttributeValue(ref text2, "BorderWidth");
				text = this._BorderColor;
				this._BorderColor = base.GetXmlNodeCompatibleAttributeValue(ref text, "bordercolor");
				text = this._BorderColorLight;
				this._BorderColorLight = base.GetXmlNodeCompatibleAttributeValue(ref text, "bordercolorlight");
				text = this._BorderColorDark;
				this._BorderColorDark = base.GetXmlNodeCompatibleAttributeValue(ref text, "bordercolordark");
				text = this._BorderColorFocus;
				this._BorderColorDark = base.GetXmlNodeCompatibleAttributeValue(ref text, "BorderColorFocus");
				XmlNode xmlNode = base.GetXmlNodeStyleChildNode();
				if (xmlNode != null)
				{
					XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(xmlNode, "BorderFormat");
					if (xmlNodeChildNodeByName != null)
					{
						xmlNode = xmlNodeChildNodeByName;
					}
					string backColor = this._BackColor;
					string[] array = new string[5];
					array[0] = backColor;
					string[] array2 = array;
					int num = 1;
					text = this._BackColor;
					array2[num] = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BackColor", null);
					string[] array3 = array;
					int num2 = 2;
					text2 = this._BackColor;
					array3[num2] = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BackgroundColor", null);
					string[] array4 = array;
					int num3 = 3;
					text3 = this._BackColor;
					array4[num3] = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "BackgroundColor", "Default");
					string[] array5 = array;
					int num4 = 4;
					string text4 = this._BackColor;
					array5[num4] = this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BackgroundColor", "Value");
					this._BackColor = string.Concat(array);
					string background = this._Background;
					array = new string[5];
					array[0] = background;
					string[] array6 = array;
					int num5 = 1;
					text4 = this._Background;
					array6[num5] = this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "Background", null);
					string[] array7 = array;
					int num6 = 2;
					text = this._Background;
					array7[num6] = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BackgroundImage", null);
					string[] array8 = array;
					int num7 = 3;
					text2 = this._Background;
					array8[num7] = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BackgroundImage", "Value");
					string[] array9 = array;
					int num8 = 4;
					text3 = this._Background;
					array9[num8] = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "BackgroundImage", "Default");
					this._Background = string.Concat(array);
					string borderStyle = this._BorderStyle;
					text2 = this._BorderStyle;
					string xmlNodeCompatibleNodeValue = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BorderStyle", null);
					text = this._BorderStyle;
					string xmlNodeCompatibleNodeValue2 = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BorderStyle", "Default");
					text4 = this._BorderStyle;
					this._BorderStyle = borderStyle + xmlNodeCompatibleNodeValue + xmlNodeCompatibleNodeValue2 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderStyle", "Value");
					string borderWidth = this._BorderWidth;
					text2 = this._BorderWidth;
					string xmlNodeCompatibleNodeValue3 = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BorderWidth", null);
					text = this._BorderWidth;
					string xmlNodeCompatibleNodeValue4 = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BorderWidth", "Default");
					text4 = this._BorderWidth;
					this._BorderWidth = borderWidth + xmlNodeCompatibleNodeValue3 + xmlNodeCompatibleNodeValue4 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderWidth", "Value");
					string borderColor = this._BorderColor;
					text2 = this._BorderColor;
					string xmlNodeCompatibleNodeValue5 = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BorderColor", null);
					text = this._BorderColor;
					string xmlNodeCompatibleNodeValue6 = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BorderColor", "Default");
					text4 = this._BorderColor;
					this._BorderColor = borderColor + xmlNodeCompatibleNodeValue5 + xmlNodeCompatibleNodeValue6 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderColor", "Value");
					string borderColorLight = this._BorderColorLight;
					text2 = this._BorderColorLight;
					string xmlNodeCompatibleNodeValue7 = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BorderColorLight", null);
					text = this._BorderColorLight;
					string xmlNodeCompatibleNodeValue8 = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BorderColor", "Left");
					text4 = this._BorderColorLight;
					this._BorderColorLight = borderColorLight + xmlNodeCompatibleNodeValue7 + xmlNodeCompatibleNodeValue8 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderColor", "Value");
					string borderColorDark = this._BorderColorDark;
					text2 = this._BorderColorDark;
					string xmlNodeCompatibleNodeValue9 = this.GetXmlNodeCompatibleNodeValue(ref text2, xmlNode, "BorderColorDark", null);
					text = this._BorderColorDark;
					string xmlNodeCompatibleNodeValue10 = this.GetXmlNodeCompatibleNodeValue(ref text, xmlNode, "BorderColor", "Bottom");
					text4 = this._BorderColorDark;
					this._BorderColorDark = borderColorDark + xmlNodeCompatibleNodeValue9 + xmlNodeCompatibleNodeValue10 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderColor", "Value");
					string borderColorFocus = this._BorderColorFocus;
					text4 = this._BorderColorFocus;
					this._BorderColorFocus = borderColorFocus + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "BorderColorFocus", null);
				}
				break;
			}
			}
			this.ProcessStyleAttribute();
			this.ProcessrUnitSymbol();
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000C5278 File Offset: 0x000C3478
		private void ProcessrUnitSymbol()
		{
			if (String.Compare(this._BorderWidth, "", false) != 0)
			{
				int num = this._BorderWidth.LastIndexOf("px");
				if (num > -1)
				{
					this._BorderWidth = this._BorderWidth.Substring(0, num);
				}
				num = this._BorderWidth.LastIndexOf("pt");
				if (num > -1)
				{
					this._BorderWidth = this._BorderWidth.Substring(0, num);
				}
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000C52EC File Offset: 0x000C34EC
		private void ProcessStyleAttribute()
		{
			string xmlNodeStyleAttributeValue = base.GetXmlNodeStyleAttributeValue();
			if (String.Compare(xmlNodeStyleAttributeValue, "", false) != 0)
			{
				string xmlNodeStyleAttributeValue2 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "background-color");
				string xmlNodeStyleAttributeValue3 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "background-image");
				string xmlNodeStyleAttributeValue4 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "border-style");
				string xmlNodeStyleAttributeValue5 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "border-width");
				string xmlNodeStyleAttributeValue6 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "border-color");
				string text = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "color-light") + base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "bordercolor-light");
				string text2 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "color-dark") + base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "bordercolor-dark");
				this._BackColor = ((String.Compare(xmlNodeStyleAttributeValue2, "", false) != 0) ? xmlNodeStyleAttributeValue2 : this._BackColor);
				this._Background = ((String.Compare(xmlNodeStyleAttributeValue3, "", false) != 0) ? xmlNodeStyleAttributeValue3 : this._Background);
				this._BorderStyle = ((String.Compare(xmlNodeStyleAttributeValue4, "", false) != 0) ? xmlNodeStyleAttributeValue4 : this._BorderStyle);
				this._BorderWidth = ((String.Compare(xmlNodeStyleAttributeValue5, "", false) != 0) ? xmlNodeStyleAttributeValue5 : this._BorderWidth);
				this._BorderColor = ((String.Compare(xmlNodeStyleAttributeValue6, "", false) != 0) ? xmlNodeStyleAttributeValue6 : this._BorderColor);
				this._BorderColorLight = ((String.Compare(text, "", false) != 0) ? text : this._BorderColorLight);
				this._BorderColorDark = ((String.Compare(text2, "", false) != 0) ? text2 : this._BorderColorDark);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000C5474 File Offset: 0x000C3674
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x000082A9 File Offset: 0x000064A9
		public string BackColor
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x000C548C File Offset: 0x000C368C
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x000082B2 File Offset: 0x000064B2
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000C54A4 File Offset: 0x000C36A4
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x000082BB File Offset: 0x000064BB
		public string BorderColor
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000C54BC File Offset: 0x000C36BC
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x000082C4 File Offset: 0x000064C4
		public string BorderColorDark
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000C54D4 File Offset: 0x000C36D4
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x000082CD File Offset: 0x000064CD
		public string BorderColorFocus
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000C54EC File Offset: 0x000C36EC
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x000082D6 File Offset: 0x000064D6
		public string BorderColorLight
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000C5504 File Offset: 0x000C3704
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x000082DF File Offset: 0x000064DF
		public string BorderStyle
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000C551C File Offset: 0x000C371C
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x000082E8 File Offset: 0x000064E8
		public string BorderWidth
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x000C5534 File Offset: 0x000C3734
		public bool IsEmpty
		{
			get
			{
				if (this._BorderColor != null && String.Compare(this._BorderColor, "", false) == 0 && this._BorderWidth != null && String.Compare(this._BorderWidth, "", false) == 0 && this._BorderStyle != null && String.Compare(this._BorderStyle, "", false) == 0 && this._BackColor != null && String.Compare(this._BackColor, "", false) == 0 && this._Background != null && String.Compare(this._Background, "", false) == 0 && this._BorderColorLight != null && String.Compare(this._BorderColorLight, "", false) == 0 && this._BorderColorDark != null && String.Compare(this._BorderColorDark, "", false) == 0 && this._BorderColorFocus != null)
				{
					if (String.Compare(this._BorderColorFocus, "", false) == 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x04000AE9 RID: 2793
		private string _BackColor;

		// Token: 0x04000AEA RID: 2794
		private string _Background;

		// Token: 0x04000AEB RID: 2795
		private string _BorderColor;

		// Token: 0x04000AEC RID: 2796
		private string _BorderColorDark;

		// Token: 0x04000AED RID: 2797
		private string _BorderColorFocus;

		// Token: 0x04000AEE RID: 2798
		private string _BorderColorLight;

		// Token: 0x04000AEF RID: 2799
		private string _BorderStyle;

		// Token: 0x04000AF0 RID: 2800
		private string _BorderWidth;
	}
}
