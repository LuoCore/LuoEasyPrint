using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000BF RID: 191
	public sealed class XmlTableFormat : XmlParserBase
	{
		// Token: 0x06001828 RID: 6184 RVA: 0x0000881C File Offset: 0x00006A1C
		public XmlTableFormat()
		{
			this._CellPadding = "0";
			this._CellSpacing = "0";
			this._defaultRowHeight = "-1";
			this._defaultColWidth = "75";
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00008850 File Offset: 0x00006A50
		public XmlTableFormat(XmlNode format)
		{
			this._CellPadding = "0";
			this._CellSpacing = "0";
			this._defaultRowHeight = "-1";
			this._defaultColWidth = "75";
			base.XmlNode = format;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000C82DC File Offset: 0x000C64DC
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000C82F4 File Offset: 0x000C64F4
		private void ParseXmlNode()
		{
			XmlNode xmlNode = base.XmlNode;
			this._GridLines = this.GetXmlNodeAttributeValue("GridLines");
			this._MergeFlag = this.GetXmlNodeAttributeValue("MergeFlag");
			string text = this.GetXmlNodeAttributeValue("CellPadding").Trim();
			string text2 = this.GetXmlNodeAttributeValue("CellSpacing").Trim();
			if (String.Compare(text, "", false) != 0)
			{
				this._CellPadding = text;
			}
			if (String.Compare(text2, "", false) != 0)
			{
				this._CellSpacing = text2;
			}
			string text3 = this.GetXmlNodeAttributeValue("DefaultRowHeight").Trim();
			string left = this.GetXmlNodeAttributeValue("DefaultColWidth").Trim();
			if (String.Compare(text3, "", false) != 0)
			{
				this._defaultRowHeight = text3;
			}
			if (String.Compare(left, "", false) != 0)
			{
				this._defaultColWidth = this._defaultColWidth;
			}
			XmlTextFormat xmlTextFormat = new XmlTextFormat(xmlNode);
			xmlTextFormat.Parse();
			if (String.Compare(xmlTextFormat.Valign, "", false) == 0)
			{
				xmlTextFormat.Valign = "Middle";
			}
			this.TextFormat = xmlTextFormat;
			XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(xmlNode);
			xmlBorderFormat.Parse();
			this.BorderFormat = xmlBorderFormat;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x000C841C File Offset: 0x000C661C
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0000888B File Offset: 0x00006A8B
		public string Align
		{
			get
			{
				return this._TextFormat.Align;
			}
			set
			{
				this._TextFormat.Align = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x000C8438 File Offset: 0x000C6638
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x00008899 File Offset: 0x00006A99
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

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x000C8450 File Offset: 0x000C6650
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x000088A2 File Offset: 0x00006AA2
		public string CellPadding
		{
			get
			{
				return this._CellPadding;
			}
			set
			{
				this._CellPadding = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000C8468 File Offset: 0x000C6668
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x000088AB File Offset: 0x00006AAB
		public string CellSpacing
		{
			get
			{
				return this._CellSpacing;
			}
			set
			{
				this._CellSpacing = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x000C8480 File Offset: 0x000C6680
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x000088B4 File Offset: 0x00006AB4
		public string DefaultColWidth
		{
			get
			{
				return this._defaultColWidth;
			}
			set
			{
				this._defaultColWidth = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x000C8498 File Offset: 0x000C6698
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x000088BD File Offset: 0x00006ABD
		public string DefaultRowHeight
		{
			get
			{
				return this._defaultRowHeight;
			}
			set
			{
				this._defaultRowHeight = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x000C84B0 File Offset: 0x000C66B0
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x000088C6 File Offset: 0x00006AC6
		public string GridLines
		{
			get
			{
				return this._GridLines;
			}
			set
			{
				this._GridLines = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x000C84C8 File Offset: 0x000C66C8
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x000088CF File Offset: 0x00006ACF
		public string MergeFlag
		{
			get
			{
				return this._MergeFlag;
			}
			set
			{
				this._MergeFlag = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000C84E0 File Offset: 0x000C66E0
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x000088D8 File Offset: 0x00006AD8
		public XmlTextFormat TextFormat
		{
			get
			{
				return this._TextFormat;
			}
			set
			{
				this._TextFormat = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000C84F8 File Offset: 0x000C66F8
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x000088E1 File Offset: 0x00006AE1
		public string VAlign
		{
			get
			{
				return this._TextFormat.Valign;
			}
			set
			{
				this._TextFormat.Valign = value;
			}
		}

		// Token: 0x04000B49 RID: 2889
		private XmlBorderFormat _BorderFormat;

		// Token: 0x04000B4A RID: 2890
		private string _CellPadding;

		// Token: 0x04000B4B RID: 2891
		private string _CellSpacing;

		// Token: 0x04000B4C RID: 2892
		private string _defaultColWidth;

		// Token: 0x04000B4D RID: 2893
		private string _defaultRowHeight;

		// Token: 0x04000B4E RID: 2894
		private string _GridLines;

		// Token: 0x04000B4F RID: 2895
		private string _MergeFlag;

		// Token: 0x04000B50 RID: 2896
		private XmlTextFormat _TextFormat;
	}
}
