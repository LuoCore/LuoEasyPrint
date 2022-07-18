using System;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000B7 RID: 183
	public sealed class XmlPageSetup : XmlParserBase
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x0000860D File Offset: 0x0000680D
		public XmlPageSetup()
		{
			this._papername = "";
			this.Init();
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00008626 File Offset: 0x00006826
		public XmlPageSetup(XmlNode format) : this()
		{
			this._XmlNode = format;
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000C7130 File Offset: 0x000C5330
		private void Init()
		{
			this._LeftMargin = "15";
			this._RightMargin = "15";
			this._TopMargin = "15";
			this._BottomMargin = "15";
			this._PageWidth = "210";
			this._PageHeight = "297";
			this._documentname = "";
			this._papername = "A4";
			this._Landscape = "false";
			this._printername = "";
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000C71AC File Offset: 0x000C53AC
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000C71C4 File Offset: 0x000C53C4
		private void ParseXmlNode()
		{
			this._papername = this.GetXmlNodeAttributeValue("PaperName");
			this._Landscape = this.GetXmlNodeAttributeValue("Landscape");
			this._PageWidth = this.GetXmlNodeAttributeValue("PaperWidth");
			this._PageHeight = this.GetXmlNodeAttributeValue("PaperHeight");
			this._LeftMargin = this.GetXmlNodeAttributeValue("LeftMargin");
			this._RightMargin = this.GetXmlNodeAttributeValue("RightMargin");
			this._TopMargin = this.GetXmlNodeAttributeValue("TopMargin");
			this._BottomMargin = this.GetXmlNodeAttributeValue("BottomMargin");
			this._documentname = this.GetXmlNodeAttributeValue("DocumentName");
			this._printername = this.GetXmlNodeAttributeValue("PrinterName");
			this._Landscape = this.GetXmlNodeAttributeValue("PaperLandScape");
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000C728C File Offset: 0x000C548C
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00008635 File Offset: 0x00006835
		public string BottomMargin
		{
			get
			{
				return this._BottomMargin;
			}
			set
			{
				this._BottomMargin = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x000C72A4 File Offset: 0x000C54A4
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000863E File Offset: 0x0000683E
		public string PaperLandscape
		{
			get
			{
				return this._Landscape;
			}
			set
			{
				this._Landscape = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x000C72BC File Offset: 0x000C54BC
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x00008647 File Offset: 0x00006847
		public string LeftMargin
		{
			get
			{
				return this._LeftMargin;
			}
			set
			{
				this._LeftMargin = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x000C72D4 File Offset: 0x000C54D4
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x00008650 File Offset: 0x00006850
		public string PageHeight
		{
			get
			{
				return this._PageHeight;
			}
			set
			{
				this._PageHeight = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000C72EC File Offset: 0x000C54EC
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00008659 File Offset: 0x00006859
		public string PageWidth
		{
			get
			{
				return this._PageWidth;
			}
			set
			{
				this._PageWidth = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000C7304 File Offset: 0x000C5504
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00008662 File Offset: 0x00006862
		public string RightMargin
		{
			get
			{
				return this._RightMargin;
			}
			set
			{
				this._RightMargin = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000C731C File Offset: 0x000C551C
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000866B File Offset: 0x0000686B
		public string TopMargin
		{
			get
			{
				return this._TopMargin;
			}
			set
			{
				this._TopMargin = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x000C7334 File Offset: 0x000C5534
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00008674 File Offset: 0x00006874
		public string PaperName
		{
			get
			{
				return this._papername;
			}
			set
			{
				this._papername = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000C734C File Offset: 0x000C554C
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000867D File Offset: 0x0000687D
		public string DocumentName
		{
			get
			{
				return this._documentname;
			}
			set
			{
				this._documentname = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000C7364 File Offset: 0x000C5564
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00008686 File Offset: 0x00006886
		public string PrinterName
		{
			get
			{
				return this._printername;
			}
			set
			{
				this._printername = value;
			}
		}

		// Token: 0x04000B2E RID: 2862
		private string _papername;

		// Token: 0x04000B2F RID: 2863
		private string _PageHeight;

		// Token: 0x04000B30 RID: 2864
		private string _PageWidth;

		// Token: 0x04000B31 RID: 2865
		private string _Landscape;

		// Token: 0x04000B32 RID: 2866
		private string _LeftMargin;

		// Token: 0x04000B33 RID: 2867
		private string _RightMargin;

		// Token: 0x04000B34 RID: 2868
		private string _TopMargin;

		// Token: 0x04000B35 RID: 2869
		private string _BottomMargin;

		// Token: 0x04000B36 RID: 2870
		private string _documentname;

		// Token: 0x04000B37 RID: 2871
		private string _printername;

		// Token: 0x04000B38 RID: 2872
		private string _pageheaderleft;

		// Token: 0x04000B39 RID: 2873
		private string _pageheadermiddle;

		// Token: 0x04000B3A RID: 2874
		private string _pageheaderright;

		// Token: 0x04000B3B RID: 2875
		private string _pageheadercolor;

		// Token: 0x04000B3C RID: 2876
		private string _pageheaderfontname;
	}
}
