using System;
using System.Configuration;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000C3 RID: 195
	public sealed class XmlTextFormat : XmlParserBase, ICloneable
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x000C8980 File Offset: 0x000C6B80
		static XmlTextFormat()
		{
			string text = ConfigurationManager.AppSettings["DefaultFontName"];
			string text2 = ConfigurationManager.AppSettings["DefaultFontSize"];
			string text3 = ConfigurationManager.AppSettings["DefaultFontColor"];
			if (text != null && String.Compare(text.Trim(), "", false) != 0)
			{
				XmlTextFormat.DefaultFontName = text.Trim();
			}
			if (text2 != null && String.Compare(text2.Trim(), "", false) != 0)
			{
				XmlTextFormat.DefaultFontSize = float.Parse(text2.Trim());
			}
			if (text3 != null && String.Compare(text3.Trim(), "", false) != 0)
			{
				XmlTextFormat.DefaultFontColor = text3.Trim();
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00008969 File Offset: 0x00006B69
		public XmlTextFormat()
		{
			this.Init();
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00008977 File Offset: 0x00006B77
		public XmlTextFormat(XmlNode format) : this()
		{
			this._XmlNode = format;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000C8A58 File Offset: 0x000C6C58
		public object Clone()
		{
			return new XmlTextFormat
			{
				ForeColor = this._ForeColor,
				Wrap = this._Wrap,
				DirectionVertical = this._DirectionVertical,
				Align = this._Align,
				Valign = this._Valign,
				FontBold = this._FontBold,
				FontItalic = this._FontItalic,
				FontName = this._FontName,
				FontNames = this._FontNames,
				FontOverline = this._FontOverline,
				FontSize = this._FontSize,
				FontStrikeout = this._FontStrikeout,
				FontUnderline = this._FontUnderline
			};
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000C8B0C File Offset: 0x000C6D0C
		public object CloneNoEmpty(XmlTextFormat relative)
		{
			XmlTextFormat xmlTextFormat = new XmlTextFormat();
			if (String.Compare(relative.ForeColor, "", false) == 0)
			{
				xmlTextFormat.ForeColor = this._ForeColor;
			}
			else
			{
				xmlTextFormat.ForeColor = relative.ForeColor;
			}
			if (String.Compare(relative.Wrap, "", false) == 0)
			{
				xmlTextFormat.Wrap = this._Wrap;
			}
			else
			{
				xmlTextFormat.ForeColor = relative.Wrap;
			}
			if (String.Compare(relative.DirectionVertical, "", false) == 0)
			{
				xmlTextFormat.DirectionVertical = this._DirectionVertical;
			}
			else
			{
				xmlTextFormat.DirectionVertical = relative.DirectionVertical;
			}
			if (String.Compare(relative.Align, "", false) == 0)
			{
				xmlTextFormat.Align = this._Align;
			}
			else
			{
				xmlTextFormat.Align = relative.Align;
			}
			if (String.Compare(relative.Valign, "", false) == 0)
			{
				xmlTextFormat.Valign = this._Valign;
			}
			else
			{
				xmlTextFormat.Valign = relative.Valign;
			}
			if (String.Compare(relative.FontBold, "", false) == 0)
			{
				xmlTextFormat.FontBold = this._FontBold;
			}
			else
			{
				xmlTextFormat.FontBold = relative.FontBold;
			}
			if (String.Compare(relative.FontItalic, "", false) == 0)
			{
				xmlTextFormat.FontItalic = this._FontItalic;
			}
			else
			{
				xmlTextFormat.FontItalic = relative.FontItalic;
			}
			if (String.Compare(relative.FontName, "", false) == 0)
			{
				xmlTextFormat.FontName = this._FontName;
			}
			else
			{
				xmlTextFormat.FontName = relative.FontName;
			}
			if (String.Compare(relative.FontNames, "", false) == 0)
			{
				xmlTextFormat.FontNames = this._FontNames;
			}
			else
			{
				xmlTextFormat.FontNames = relative.FontNames;
			}
			if (String.Compare(relative.FontOverline, "", false) == 0)
			{
				xmlTextFormat.FontOverline = this._FontOverline;
			}
			else
			{
				xmlTextFormat.FontOverline = relative.FontOverline;
			}
			if (String.Compare(relative.FontSize, "", false) == 0)
			{
				xmlTextFormat.FontSize = this._FontSize;
			}
			else
			{
				xmlTextFormat.FontSize = relative.FontSize;
			}
			if (String.Compare(relative.FontStrikeout, "", false) == 0)
			{
				xmlTextFormat.FontStrikeout = this._FontStrikeout;
			}
			else
			{
				xmlTextFormat.FontStrikeout = relative.FontStrikeout;
			}
			object result;
			if (String.Compare(relative.FontUnderline, "", false) == 0)
			{
				xmlTextFormat.FontUnderline = this._FontUnderline;
				result = xmlTextFormat;
			}
			else
			{
				xmlTextFormat.FontUnderline = relative.FontUnderline;
				result = xmlTextFormat;
			}
			return result;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000C8D7C File Offset: 0x000C6F7C
		public Font GetFont()
		{
			return this.GetFontFromThis();
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000C8D94 File Offset: 0x000C6F94
		private Font GetFontFromThis()
		{
			FontStyle fontStyle = this.GetFontStyle();
			string familyName = XmlTextFormat.DefaultFontName;
			if (this._FontName != null && String.Compare(this._FontName.Trim(), "", false) != 0)
			{
				familyName = this._FontName.Trim();
			}
			float emSize = XmlTextFormat.DefaultFontSize;
			if (this._FontSize != null && String.Compare(this._FontSize.Trim(), "", false) != 0)
			{
				emSize = float.Parse(this._FontSize.Trim());
			}
			return new Font(familyName, emSize, fontStyle);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000C8E20 File Offset: 0x000C7020
		private Font GetFontFromThisbak(string fontName, float fontSize)
		{
			FontStyle fontStyle = this.GetFontStyle();
			string familyName = fontName;
			if (this._FontName != null && String.Compare(this._FontName.Trim(), "", false) != 0)
			{
				familyName = this._FontName.Trim();
			}
			float emSize = fontSize;
			if (this._FontSize != null && String.Compare(this._FontSize.Trim(), "", false) != 0)
			{
				emSize = float.Parse(this._FontSize.Trim());
			}
			return new Font(familyName, emSize, fontStyle);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000C8EA4 File Offset: 0x000C70A4
		public FontStyle GetFontStyle()
		{
			FontStyle fontStyle = FontStyle.Regular;
			if (this._FontBold != null && (String.Compare(this._FontBold.Trim().ToLower(), "true", false) == 0 || String.Compare(this._FontBold.Trim(), "1", false) == 0))
			{
				fontStyle |= FontStyle.Bold;
			}
			if (this._FontItalic != null && (String.Compare(this._FontItalic.Trim().ToLower(), "true", false) == 0 || String.Compare(this._FontItalic.Trim(), "1", false) == 0))
			{
				fontStyle |= FontStyle.Italic;
			}
			if (this._FontStrikeout != null && (String.Compare(this._FontStrikeout.Trim().ToLower(), "true", false) == 0 || String.Compare(this._FontStrikeout.Trim(), "1", false) == 0))
			{
				fontStyle |= FontStyle.Strikeout;
			}
			if (this._FontUnderline != null)
			{
				if (String.Compare(this._FontUnderline.Trim().ToLower(), "true", false) == 0 || String.Compare(this._FontUnderline.Trim(), "1", false) == 0)
				{
					return fontStyle | FontStyle.Underline;
				}
			}
			return fontStyle;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000C8FC8 File Offset: 0x000C71C8
		private string GetXmlNodeCompatibleNodeValue(ref string existValue, XmlNode parentNode, string sonNodeName)
		{
			string result;
			if (existValue != null && String.Compare(existValue, "", false) != 0)
			{
				result = "";
			}
			else
			{
				existValue = XmlParserBase.GetXmlNodeChildNodeValue(parentNode, sonNodeName);
				result = existValue;
			}
			return result;
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00002590 File Offset: 0x00000790
		private void Init()
		{
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000C9000 File Offset: 0x000C7200
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000C9018 File Offset: 0x000C7218
		private void ParseXmlNode()
		{
			string[] array = new string[5];
			string[] array2 = array;
			int num = 0;
			string foreColor = this._ForeColor;
			array2[num] = base.GetXmlNodeCompatibleAttributeValue(ref foreColor, "ForeColor");
			string[] array3 = array;
			int num2 = 1;
			string text = this._ForeColor;
			array3[num2] = base.GetXmlNodeCompatibleAttributeValue(ref text, "Color");
			string[] array4 = array;
			int num3 = 2;
			string text2 = this._ForeColor;
			array4[num3] = base.GetXmlNodeCompatibleAttributeValue(ref text2, "FontColor");
			string[] array5 = array;
			int num4 = 3;
			string text3 = this._ForeColor;
			array5[num4] = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Color");
			string[] array6 = array;
			int num5 = 4;
			string text4 = this._ForeColor;
			array6[num5] = base.GetXmlNodeCompatibleAttributeValue(ref text4, "TextColor");
			this._ForeColor = string.Concat(array);
			text4 = this._Wrap;
			this._Wrap = base.GetXmlNodeCompatibleAttributeValue(ref text4, "Wrap");
			text4 = this._DirectionVertical;
			this._DirectionVertical = base.GetXmlNodeCompatibleAttributeValue(ref text4, "DirectionVertical");
			text = this._Align;
			string xmlNodeCompatibleAttributeValue = base.GetXmlNodeCompatibleAttributeValue(ref text, "Align");
			text2 = this._Align;
			string xmlNodeCompatibleAttributeValue2 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "HorizontalAlign");
			text3 = this._Align;
			string xmlNodeCompatibleAttributeValue3 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "TextAlign");
			text4 = this._Align;
			this._Align = xmlNodeCompatibleAttributeValue + xmlNodeCompatibleAttributeValue2 + xmlNodeCompatibleAttributeValue3 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "Halign");
			text4 = this._Valign;
			string xmlNodeCompatibleAttributeValue4 = base.GetXmlNodeCompatibleAttributeValue(ref text4, "Valign");
			text3 = this._Valign;
			this._Valign = xmlNodeCompatibleAttributeValue4 + base.GetXmlNodeCompatibleAttributeValue(ref text3, "VerticalAlign");
			text2 = this._FontBold;
			string xmlNodeCompatibleAttributeValue5 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "FontBold");
			text3 = this._FontBold;
			string xmlNodeCompatibleAttributeValue6 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Bold");
			text4 = this._FontBold;
			this._FontBold = xmlNodeCompatibleAttributeValue5 + xmlNodeCompatibleAttributeValue6 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "B");
			text2 = this._FontItalic;
			string xmlNodeCompatibleAttributeValue7 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "FontItalic");
			text3 = this._FontItalic;
			string xmlNodeCompatibleAttributeValue8 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Italic");
			text4 = this._FontBold;
			this._FontItalic = xmlNodeCompatibleAttributeValue7 + xmlNodeCompatibleAttributeValue8 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "I");
			text = this._FontName;
			string xmlNodeCompatibleAttributeValue9 = base.GetXmlNodeCompatibleAttributeValue(ref text, "FontName");
			text2 = this._FontName;
			string xmlNodeCompatibleAttributeValue10 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "Font-Name");
			text3 = this._FontName;
			string xmlNodeCompatibleAttributeValue11 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font");
			text4 = this._FontName;
			this._FontName = xmlNodeCompatibleAttributeValue9 + xmlNodeCompatibleAttributeValue10 + xmlNodeCompatibleAttributeValue11 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "FontFamily");
			text = this._FontNames;
			string xmlNodeCompatibleAttributeValue12 = base.GetXmlNodeCompatibleAttributeValue(ref text, "FontNames");
			text2 = this._FontNames;
			string xmlNodeCompatibleAttributeValue13 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "Font-Names");
			text3 = this._FontName;
			string xmlNodeCompatibleAttributeValue14 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font");
			text4 = this._FontNames;
			this._FontNames = xmlNodeCompatibleAttributeValue12 + xmlNodeCompatibleAttributeValue13 + xmlNodeCompatibleAttributeValue14 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "FontFamily");
			text4 = this._FontOverline;
			string xmlNodeCompatibleAttributeValue15 = base.GetXmlNodeCompatibleAttributeValue(ref text4, "FontOverline");
			text3 = this._FontOverline;
			this._FontOverline = xmlNodeCompatibleAttributeValue15 + base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Overline");
			text4 = this._FontSize;
			string xmlNodeCompatibleAttributeValue16 = base.GetXmlNodeCompatibleAttributeValue(ref text4, "FontSize");
			text3 = this._FontSize;
			this._FontSize = xmlNodeCompatibleAttributeValue16 + base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Size");
			text4 = this._FontStrikeout;
			string xmlNodeCompatibleAttributeValue17 = base.GetXmlNodeCompatibleAttributeValue(ref text4, "FontStrikeout");
			text3 = this._FontStrikeout;
			this._FontStrikeout = xmlNodeCompatibleAttributeValue17 + base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Strikeout");
			text2 = this._FontUnderline;
			string xmlNodeCompatibleAttributeValue18 = base.GetXmlNodeCompatibleAttributeValue(ref text2, "FontUnderline");
			text3 = this._FontUnderline;
			string xmlNodeCompatibleAttributeValue19 = base.GetXmlNodeCompatibleAttributeValue(ref text3, "Font-Underline");
			text4 = this._FontBold;
			this._FontUnderline = xmlNodeCompatibleAttributeValue18 + xmlNodeCompatibleAttributeValue19 + base.GetXmlNodeCompatibleAttributeValue(ref text4, "U");
			XmlNode xmlNode = base.GetXmlNodeStyleChildNode();
			if (xmlNode != null)
			{
				XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(xmlNode, "TextFormat");
				if (xmlNodeChildNodeByName != null)
				{
					xmlNode = xmlNodeChildNodeByName;
				}
				string foreColor2 = this._ForeColor;
				text3 = this._ForeColor;
				string xmlNodeCompatibleNodeValue = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "ForeColor");
				text4 = this._ForeColor;
				this._ForeColor = foreColor2 + xmlNodeCompatibleNodeValue + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "Color");
				string wrap = this._Wrap;
				text4 = this._Wrap;
				this._Wrap = wrap + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "Wrap");
				string directionVertical = this._DirectionVertical;
				text4 = this._DirectionVertical;
				this._DirectionVertical = directionVertical + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "DirectionVertical");
				string align = this._Align;
				text3 = this._Align;
				string xmlNodeCompatibleNodeValue2 = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "Align");
				text4 = this._Align;
				this._Align = align + xmlNodeCompatibleNodeValue2 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "TextAlign");
				string valign = this._Valign;
				text3 = this._Valign;
				string xmlNodeCompatibleNodeValue3 = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "Valign");
				text4 = this._Valign;
				this._Valign = valign + xmlNodeCompatibleNodeValue3 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "VerticalAlign");
				string fontBold = this._FontBold;
				text4 = this._FontBold;
				this._FontBold = fontBold + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontBold");
				string fontItalic = this._FontItalic;
				text4 = this._FontItalic;
				this._FontItalic = fontItalic + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontItalic");
				string fontName = this._FontName;
				text3 = this._FontName;
				string xmlNodeCompatibleNodeValue4 = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "FontName");
				text4 = this._FontName;
				this._FontName = fontName + xmlNodeCompatibleNodeValue4 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontFamily");
				string fontNames = this._FontNames;
				text3 = this._FontNames;
				string xmlNodeCompatibleNodeValue5 = this.GetXmlNodeCompatibleNodeValue(ref text3, xmlNode, "FontNames");
				text4 = this._FontName;
				this._FontNames = fontNames + xmlNodeCompatibleNodeValue5 + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontFamily");
				string fontOverline = this._FontOverline;
				text4 = this._FontOverline;
				this._FontOverline = fontOverline + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontOverline");
				string fontSize = this._FontSize;
				text4 = this._FontSize;
				this._FontSize = fontSize + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontSize");
				string fontStrikeout = this._FontStrikeout;
				text4 = this._FontStrikeout;
				this._FontStrikeout = fontStrikeout + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontStrikeout");
				string fontUnderline = this._FontUnderline;
				text4 = this._FontUnderline;
				this._FontUnderline = fontUnderline + this.GetXmlNodeCompatibleNodeValue(ref text4, xmlNode, "FontUnderline");
			}
			this.ProcessStyleAttribute();
			this.ProcessrUnitSymbol();
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000C964C File Offset: 0x000C784C
		private void ProcessrUnitSymbol()
		{
			if (String.Compare(this._FontSize, "", false) != 0)
			{
				int num = this._FontSize.LastIndexOf("px");
				if (num > -1)
				{
					this._FontSize = this._FontSize.Substring(0, num);
				}
				num = this._FontSize.LastIndexOf("pt");
				if (num > -1)
				{
					this._FontSize = this._FontSize.Substring(0, num);
				}
				num = this._FontSize.LastIndexOf("mm");
				if (num > -1)
				{
					this._FontSize = this._FontSize.Substring(0, num);
				}
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000C96E8 File Offset: 0x000C78E8
		private void ProcessStyleAttribute()
		{
			string xmlNodeStyleAttributeValue = base.GetXmlNodeStyleAttributeValue();
			if (String.Compare(xmlNodeStyleAttributeValue, "", false) != 0)
			{
				string xmlNodeStyleAttributeValue2 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "color");
				string xmlNodeStyleAttributeValue3 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "Wrap");
				string xmlNodeStyleAttributeValue4 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "text-align");
				string xmlNodeStyleAttributeValue5 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "text-valign");
				string xmlNodeStyleAttributeValue6 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "text-valign");
				string xmlNodeStyleAttributeValue7 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "text-valign");
				string xmlNodeStyleAttributeValue8 = base.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, "font-size");
				this._ForeColor = ((String.Compare(xmlNodeStyleAttributeValue2, "", false) != 0) ? xmlNodeStyleAttributeValue2 : this._ForeColor);
				this._Wrap = ((String.Compare(xmlNodeStyleAttributeValue3, "", false) != 0) ? xmlNodeStyleAttributeValue3 : this._Wrap);
				this._Align = ((String.Compare(xmlNodeStyleAttributeValue4, "", false) != 0) ? xmlNodeStyleAttributeValue4 : this._Align);
				this._Valign = ((String.Compare(xmlNodeStyleAttributeValue5, "", false) != 0) ? xmlNodeStyleAttributeValue5 : this._Valign);
				this._FontName = ((String.Compare(xmlNodeStyleAttributeValue6, "", false) != 0) ? xmlNodeStyleAttributeValue6 : this._FontName);
				this._FontNames = ((String.Compare(xmlNodeStyleAttributeValue7, "", false) != 0) ? xmlNodeStyleAttributeValue7 : this._FontNames);
				this._FontSize = ((String.Compare(xmlNodeStyleAttributeValue8, "", false) != 0) ? xmlNodeStyleAttributeValue8 : this._FontSize);
				string text = xmlNodeStyleAttributeValue.ToLower();
				if (text.IndexOf("bold") > -1)
				{
					this._FontBold = "true";
				}
				if (text.IndexOf("italic") > -1)
				{
					this._FontItalic = "true";
				}
				if (text.IndexOf("overline") > -1)
				{
					this._FontOverline = "true";
				}
				if (text.IndexOf("line-through") > -1)
				{
					this._FontStrikeout = "true";
				}
				if (text.IndexOf("underline") > -1)
				{
					this._FontUnderline = "true";
				}
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x000C98D8 File Offset: 0x000C7AD8
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x00008986 File Offset: 0x00006B86
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x000C98F0 File Offset: 0x000C7AF0
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000898F File Offset: 0x00006B8F
		public string DirectionVertical
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000C9908 File Offset: 0x000C7B08
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00008998 File Offset: 0x00006B98
		public string FontBold
		{
			get
			{
				return this._FontBold;
			}
			set
			{
				this._FontBold = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000C9920 File Offset: 0x000C7B20
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x000089A1 File Offset: 0x00006BA1
		public string FontItalic
		{
			get
			{
				return this._FontItalic;
			}
			set
			{
				this._FontItalic = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x000C9938 File Offset: 0x000C7B38
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x000089AA File Offset: 0x00006BAA
		public string FontName
		{
			get
			{
				return this._FontName;
			}
			set
			{
				this._FontName = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x000C9950 File Offset: 0x000C7B50
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x000089B3 File Offset: 0x00006BB3
		public string FontNames
		{
			get
			{
				return this._FontNames;
			}
			set
			{
				this._FontNames = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000C9968 File Offset: 0x000C7B68
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x000089BC File Offset: 0x00006BBC
		public string FontOverline
		{
			get
			{
				return this._FontOverline;
			}
			set
			{
				this._FontOverline = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000C9980 File Offset: 0x000C7B80
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x000089C5 File Offset: 0x00006BC5
		public string FontSize
		{
			get
			{
				return this._FontSize;
			}
			set
			{
				this._FontSize = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x000C9998 File Offset: 0x000C7B98
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x000089CE File Offset: 0x00006BCE
		public string FontStrikeout
		{
			get
			{
				return this._FontStrikeout;
			}
			set
			{
				this._FontStrikeout = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000C99B0 File Offset: 0x000C7BB0
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x000089D7 File Offset: 0x00006BD7
		public string FontUnderline
		{
			get
			{
				return this._FontUnderline;
			}
			set
			{
				this._FontUnderline = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000C99C8 File Offset: 0x000C7BC8
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x000089E0 File Offset: 0x00006BE0
		public string ForeColor
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

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000C99E0 File Offset: 0x000C7BE0
		public bool IsEmpty
		{
			get
			{
				if (String.Compare(this._FontName, "", false) != 0)
				{
					bool flag = String.Compare(this._FontName, XmlTextFormat.DefaultFontName, false) == 0;
				}
				if (this._FontName != null && String.Compare(this._FontName, "", false) == 0 && (String.Compare(this._FontName, "", false) == 0 || String.Compare(this._FontName, XmlTextFormat.DefaultFontName, false) == 0) && this._FontSize != null && String.Compare(this._FontSize, "", false) == 0 && (String.Compare(this._FontSize, "", false) == 0 || String.Compare(this._FontSize, XmlTextFormat.DefaultFontSize.ToString(), false) == 0) && this._ForeColor != null && String.Compare(this._ForeColor, "", false) == 0 && (String.Compare(this._ForeColor, "", false) == 0 || String.Compare(this._ForeColor, XmlTextFormat.DefaultFontColor, false) == 0) && this._FontBold != null && String.Compare(this._FontBold, "", false) == 0 && this._FontItalic != null && String.Compare(this._FontItalic, "", false) == 0 && this._FontOverline != null && String.Compare(this._FontOverline, "", false) == 0 && this._FontStrikeout != null && String.Compare(this._FontStrikeout, "", false) == 0 && this._FontUnderline != null && String.Compare(this._FontUnderline, "", false) == 0 && this._Align != null && String.Compare(this._Align, "", false) == 0 && this._Valign != null && String.Compare(this._Valign, "", false) == 0 && this._Wrap != null && String.Compare(this._Wrap, "", false) == 0 && this._DirectionVertical != null && String.Compare(this._DirectionVertical, "", false) == 0 && this._FontNames != null)
				{
					if (String.Compare(this._FontNames, "", false) == 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x000C9C54 File Offset: 0x000C7E54
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x000089E9 File Offset: 0x00006BE9
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x000C9C6C File Offset: 0x000C7E6C
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x000089F2 File Offset: 0x00006BF2
		public string Wrap
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

		// Token: 0x04000B59 RID: 2905
		private string _Align;

		// Token: 0x04000B5A RID: 2906
		private string _DirectionVertical;

		// Token: 0x04000B5B RID: 2907
		private string _FontBold;

		// Token: 0x04000B5C RID: 2908
		private string _FontItalic;

		// Token: 0x04000B5D RID: 2909
		private string _FontName;

		// Token: 0x04000B5E RID: 2910
		private string _FontNames;

		// Token: 0x04000B5F RID: 2911
		private string _FontOverline;

		// Token: 0x04000B60 RID: 2912
		private string _FontSize;

		// Token: 0x04000B61 RID: 2913
		private string _FontStrikeout;

		// Token: 0x04000B62 RID: 2914
		private string _FontUnderline;

		// Token: 0x04000B63 RID: 2915
		private string _ForeColor;

		// Token: 0x04000B64 RID: 2916
		private string _Valign;

		// Token: 0x04000B65 RID: 2917
		private string _Wrap;

		// Token: 0x04000B66 RID: 2918
		public static string DefaultFontColor = "Black";

		// Token: 0x04000B67 RID: 2919
		public static string DefaultFontName = "宋体";

		// Token: 0x04000B68 RID: 2920
		public static float DefaultFontSize = 12f;
	}
}
