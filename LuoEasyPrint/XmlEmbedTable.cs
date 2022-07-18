using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000AF RID: 175
	public class XmlEmbedTable : XmlGoldPrinterElement
	{
		// Token: 0x0600172D RID: 5933 RVA: 0x0000837D File Offset: 0x0000657D
		public XmlEmbedTable()
		{
			this._title = new XmlTitle();
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000C5818 File Offset: 0x000C3A18
		public XmlEmbedTable(XmlNode shape)
		{
			base.XmlNode = shape;
			this._title = new XmlTitle(XmlParserBase.GetXmlNodeChildNodeByName(shape, "title"));
			this._title.Parse();
			this._subtitle = new XmlTitle(XmlParserBase.GetXmlNodeChildNodeByName(shape, "subtitle"));
			this._subtitle.Parse();
			this._tableheader = new XmlPageHeaderAndFooter(XmlParserBase.GetXmlNodeChildNodeByName(shape, "tableheader"));
			this._tableheader.Parse();
			this._tablefooter = new XmlPageHeaderAndFooter(XmlParserBase.GetXmlNodeChildNodeByName(shape, "tablefooter"));
			this._tablefooter.Parse();
			this.Parse();
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000C58C4 File Offset: 0x000C3AC4
		protected override void ParseMySelf()
		{
			this._src = this.GetXmlNodeAttributeValue("SRC") + this.GetXmlNodeAttributeValue("Source");
			this._border = this.GetXmlNodeAttributeValue("Border");
			if (String.Compare(this._border, "", false) == 0)
			{
				string text = this.GetXmlNodeAttributeValue("leftborder");
				string text2 = this.GetXmlNodeAttributeValue("topborder");
				string text3 = this.GetXmlNodeAttributeValue("rightborder");
				string text4 = this.GetXmlNodeAttributeValue("bottomborder");
				if (String.Compare(text, "", false) == 0 & String.Compare(text2, "", false) == 0 & String.Compare(text3, "", false) == 0 & String.Compare(text4, "", false) == 0)
				{
					this._border = "0,0,0,0";
				}
				else
				{
					if (String.Compare(text, "", false) == 0)
					{
						text = "0";
					}
					if (String.Compare(text3, "", false) == 0)
					{
						text3 = "0";
					}
					if (String.Compare(text2, "", false) == 0)
					{
						text2 = "0";
					}
					if (String.Compare(text4, "", false) == 0)
					{
						text4 = "0";
					}
					this._border = string.Concat(new string[]
					{
						text,
						",",
						text2,
						",",
						text3,
						",",
						text4
					});
				}
			}
			else if (Strings.InStr(this._border, ",", CompareMethod.Binary) <= 0)
			{
				string border = this._border;
				this._border = string.Concat(new string[]
				{
					border,
					",",
					border,
					",",
					border,
					",",
					border
				});
			}
			this._alignment = this.GetXmlNodeAttributeValue("Align");
			XmlPaddingStyle xmlPaddingStyle = new XmlPaddingStyle(base.XmlNode);
			xmlPaddingStyle.Parse();
			this._padding = xmlPaddingStyle;
			this._reppagetitle = this.GetXmlNodeAttributeValue("RepeatTitle");
			this._zoomtopaperwidth = this.GetXmlNodeAttributeValue("ZoomToPaperWidth");
			this._autoresizerowheight = this.GetXmlNodeAttributeValue("AutoResizeRowHeight");
			this._printbackcolor = this.GetXmlNodeAttributeValue("PrintBackColor");
			this._minfontsize = this.GetXmlNodeAttributeValue("minfontsize");
			this._autoformat = this.GetXmlNodeAttributeValue("autoformat");
			this._isDrawTableFooterEveryPage = this.GetXmlNodeAttributeValue("DrawTableFooterEveryPage");
			this._isusedgvpadding = this.GetXmlNodeAttributeValue("IsUseDgvPadding");
			this._linecolor = this.GetXmlNodeAttributeValue("Linecolor");
			this._sortcolumn = this.GetXmlNodeAttributeValue("SortColumn");
			this._sorttype = this.GetXmlNodeAttributeValue("SortType");
			this._groupcolumn = this.GetXmlNodeAttributeValue("GroupColumn");
			this._printtype = this.GetXmlNodeAttributeValue("PrintType");
			this._addrowid = this.GetXmlNodeAttributeValue("AddrowId");
			this._columns = this.GetXmlNodeAttributeValue("Columns");
			this._columnspace = this.GetXmlNodeAttributeValue("ColumnSpace");
			this._lastpagemode = this.GetXmlNodeAttributeValue("LastPageMode");
			this._linespace = this.GetXmlNodeAttributeValue("LineSpace");
			this._printzero = this.GetXmlNodeAttributeValue("PrintZero");
			this._autowrap = this.GetXmlNodeAttributeValue("AutoWrap");
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x000C5C20 File Offset: 0x000C3E20
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00008390 File Offset: 0x00006590
		public virtual string src
		{
			get
			{
				return this._src;
			}
			set
			{
				this._src = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000C5C38 File Offset: 0x000C3E38
		public string TableHeaderL
		{
			get
			{
				string result;
				if (this._tableheader == null)
				{
					result = "";
				}
				else
				{
					result = this._tableheader.LeftText;
				}
				return result;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x000C5C64 File Offset: 0x000C3E64
		public string TableHeaderM
		{
			get
			{
				string result;
				if (this._tableheader == null)
				{
					result = "";
				}
				else
				{
					result = this._tableheader.MiddleText;
				}
				return result;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x000C5C90 File Offset: 0x000C3E90
		public string TableHeaderR
		{
			get
			{
				string result;
				if (this._tableheader == null)
				{
					result = "";
				}
				else
				{
					result = this._tableheader.RightText;
				}
				return result;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x000C5CBC File Offset: 0x000C3EBC
		public Font TableHeaderFont
		{
			get
			{
				Font result;
				if (this._tableheader == null)
				{
					result = null;
				}
				else
				{
					TextFormat textFormat = new TextFormat(this._tableheader.TextFormat);
					result = textFormat.Font;
				}
				return result;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000C5CF0 File Offset: 0x000C3EF0
		public string TableFooterL
		{
			get
			{
				string result;
				if (this._tablefooter == null)
				{
					result = "";
				}
				else
				{
					result = this._tablefooter.LeftText;
				}
				return result;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x000C5D1C File Offset: 0x000C3F1C
		public string TableFooterM
		{
			get
			{
				string result;
				if (this._tablefooter == null)
				{
					result = "";
				}
				else
				{
					result = this._tablefooter.MiddleText;
				}
				return result;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000C5D48 File Offset: 0x000C3F48
		public string TableFooterR
		{
			get
			{
				string result;
				if (this._tablefooter == null)
				{
					result = "";
				}
				else
				{
					result = this._tablefooter.RightText;
				}
				return result;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000C5D74 File Offset: 0x000C3F74
		public Font TableFooterFont
		{
			get
			{
				Font result;
				if (this._tablefooter == null)
				{
					result = null;
				}
				else
				{
					TextFormat textFormat = new TextFormat(this._tablefooter.TextFormat);
					result = textFormat.Font;
				}
				return result;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x000C5DA8 File Offset: 0x000C3FA8
		public string Title
		{
			get
			{
				string result;
				if (this._title == null)
				{
					result = "";
				}
				else
				{
					result = this._title.Text;
				}
				return result;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000C5DD4 File Offset: 0x000C3FD4
		public Font TitleFont
		{
			get
			{
				Font result;
				if (this._title == null)
				{
					result = null;
				}
				else
				{
					TextFormat textFormat = new TextFormat(this._title.TextFormat);
					result = textFormat.Font;
				}
				return result;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x000C5E08 File Offset: 0x000C4008
		public string SubTitle
		{
			get
			{
				string result;
				if (this._subtitle == null)
				{
					result = "";
				}
				else
				{
					result = this._subtitle.Text;
				}
				return result;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000C5E34 File Offset: 0x000C4034
		public Font SubTitleFont
		{
			get
			{
				Font result;
				if (this._subtitle == null)
				{
					result = null;
				}
				else
				{
					TextFormat textFormat = new TextFormat(this._subtitle.TextFormat);
					result = textFormat.Font;
				}
				return result;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x000C5E68 File Offset: 0x000C4068
		public string Border
		{
			get
			{
				return this._border;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x000C5E80 File Offset: 0x000C4080
		public StringAlignment Alignemnt
		{
			get
			{
				StringAlignment result;
				if (String.Compare(this._alignment.ToLower(), "left", false) == 0)
				{
					result = StringAlignment.Near;
				}
				else if (String.Compare(this._alignment.ToLower(), "right", false) == 0)
				{
					result = StringAlignment.Far;
				}
				else if (String.Compare(this._alignment, "center", false) == 0 | String.Compare(this._alignment, "middle", false) == 0)
				{
					result = StringAlignment.Center;
				}
				else
				{
					result = StringAlignment.Near;
				}
				return result;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000C5EFC File Offset: 0x000C40FC
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00008399 File Offset: 0x00006599
		public XmlPaddingStyle padding
		{
			get
			{
				return this._padding;
			}
			set
			{
				this._padding = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000C5F14 File Offset: 0x000C4114
		public bool RepPageTitle
		{
			get
			{
				return String.Compare(this._reppagetitle.ToLower(), "true", false) == 0 | String.Compare(this._reppagetitle, "1", false) == 0;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000C5F58 File Offset: 0x000C4158
		public bool AutoFormat
		{
			get
			{
				return String.Compare(this._autoformat.ToLower(), "true", false) == 0 | String.Compare(this._autoformat, "1", false) == 0;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000C5F9C File Offset: 0x000C419C
		public bool PrintBackColor
		{
			get
			{
				return String.Compare(this._printbackcolor.ToLower(), "true", false) == 0 | String.Compare(this._printbackcolor, "1", false) == 0;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000C5FE0 File Offset: 0x000C41E0
		public bool ZoomToPaperWidth
		{
			get
			{
				return String.Compare(this._zoomtopaperwidth.ToLower(), "true", false) == 0 | String.Compare(this._zoomtopaperwidth, "1", false) == 0;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000C6024 File Offset: 0x000C4224
		public bool AutoResizeRowHeight
		{
			get
			{
				return String.Compare(this._autoresizerowheight.ToLower(), "true", false) == 0 | String.Compare(this._autoresizerowheight, "1", false) == 0;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000C6068 File Offset: 0x000C4268
		public float MinFontSize
		{
			get
			{
				float result;
				if (String.Compare(this._minfontsize, "", false) == 0)
				{
					result = 0f;
				}
				else if (Versioned.IsNumeric(this._minfontsize))
				{
					result = Conversions.ToSingle(this._minfontsize);
				}
				else
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x000C60B4 File Offset: 0x000C42B4
		public bool DrawTableFooterEveryPage
		{
			get
			{
				return String.Compare(this._isDrawTableFooterEveryPage.ToLower(), "true", false) == 0 | String.Compare(this._isDrawTableFooterEveryPage, "1", false) == 0;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x000C60F8 File Offset: 0x000C42F8
		public bool IsUseDgvPadding
		{
			get
			{
				return String.Compare(this._isusedgvpadding.ToLower(), "true", false) == 0 | String.Compare(this._isusedgvpadding, "1", false) == 0;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000C613C File Offset: 0x000C433C
		public string LineColor
		{
			get
			{
				return this._linecolor;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000C6154 File Offset: 0x000C4354
		public string SortColumn
		{
			get
			{
				return this._sortcolumn;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000C616C File Offset: 0x000C436C
		public bool SortType
		{
			get
			{
				return String.Compare(this._sorttype, "", false) == 0 | String.Compare(this._sorttype.ToLower(), "ascending", false) == 0;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000C61B0 File Offset: 0x000C43B0
		public string GroupColumn
		{
			get
			{
				return this._groupcolumn;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000C61C8 File Offset: 0x000C43C8
		public int PrintType
		{
			get
			{
				string left = this._printtype.ToLower();
				if (String.Compare(left, "mulcolumn", false) != 0)
				{
					if (String.Compare(left, "2", false) != 0)
					{
						if (String.Compare(left, "mc", false) != 0)
						{
							if (String.Compare(left, "crosspage", false) != 0)
							{
								if (String.Compare(left, "3", false) != 0)
								{
									if (String.Compare(left, "cp", false) != 0)
									{
										if (String.Compare(left, "mp", false) != 0)
										{
											if (String.Compare(left, "gzt", false) != 0)
											{
												if (String.Compare(left, "4", false) != 0)
												{
													if (String.Compare(left, "gz", false) != 0)
													{
														return 1;
													}
												}
											}
											return 4;
										}
									}
								}
							}
							return 3;
						}
					}
				}
				return 2;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000C629C File Offset: 0x000C449C
		public bool AddRowId
		{
			get
			{
				return String.Compare(this._addrowid.ToLower(), "true", false) == 0 | String.Compare(this._addrowid, "1", false) == 0;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000C62E0 File Offset: 0x000C44E0
		public int Columns
		{
			get
			{
				int result;
				if (String.Compare(this._columns, "", false) == 0)
				{
					result = 1;
				}
				else if (String.Compare(this._columns, " ", false) == 0)
				{
					result = 1;
				}
				else if (!Versioned.IsNumeric(this._columns))
				{
					result = 1;
				}
				else if (Conversions.ToInteger(this._columns) <= 0)
				{
					result = 1;
				}
				else
				{
					result = Conversions.ToInteger(this._columns);
				}
				return result;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000C6350 File Offset: 0x000C4550
		public float ColumnSpace
		{
			get
			{
				float result;
				if (!Versioned.IsNumeric(this._columnspace))
				{
					result = 0f;
				}
				else
				{
					result = Conversions.ToSingle(this._columnspace);
				}
				return result;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x000C6380 File Offset: 0x000C4580
		public bool LastPageMode
		{
			get
			{
				return String.Compare(this._lastpagemode.ToLower(), "true", false) == 0 | String.Compare(this._lastpagemode, "1", false) == 0;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x000C63C4 File Offset: 0x000C45C4
		public float Linespace
		{
			get
			{
				float result;
				if (!Versioned.IsNumeric(this._linespace))
				{
					result = 0f;
				}
				else
				{
					result = Conversions.ToSingle(this._linespace);
				}
				return result;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000C63F4 File Offset: 0x000C45F4
		public bool PrintZero
		{
			get
			{
				return String.Compare(this._printzero.ToLower(), "true", false) == 0 | String.Compare(this._printzero, "1", false) == 0;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x000C6438 File Offset: 0x000C4638
		public int FixedCols
		{
			get
			{
				int result;
				if (!Versioned.IsNumeric(this._fixedcols))
				{
					result = 0;
				}
				else
				{
					result = Conversions.ToInteger(this._fixedcols);
				}
				return result;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000C6464 File Offset: 0x000C4664
		public bool AutoWrap
		{
			get
			{
				return String.Compare(this._autowrap.ToLower(), "true", false) == 0 | String.Compare(this._autowrap, "1", false) == 0;
			}
		}

		// Token: 0x04000AF4 RID: 2804
		private string _alignment;

		// Token: 0x04000AF5 RID: 2805
		private string _border;

		// Token: 0x04000AF6 RID: 2806
		private Font _font;

		// Token: 0x04000AF7 RID: 2807
		private string _src;

		// Token: 0x04000AF8 RID: 2808
		private XmlTitle _title;

		// Token: 0x04000AF9 RID: 2809
		private XmlPaddingStyle _padding;

		// Token: 0x04000AFA RID: 2810
		private string _reppagetitle;

		// Token: 0x04000AFB RID: 2811
		private string _printbackcolor;

		// Token: 0x04000AFC RID: 2812
		private string _zoomtopaperwidth;

		// Token: 0x04000AFD RID: 2813
		private string _autoresizerowheight;

		// Token: 0x04000AFE RID: 2814
		private XmlTitle _subtitle;

		// Token: 0x04000AFF RID: 2815
		private XmlPageHeaderAndFooter _tableheader;

		// Token: 0x04000B00 RID: 2816
		private XmlPageHeaderAndFooter _tablefooter;

		// Token: 0x04000B01 RID: 2817
		private string _minfontsize;

		// Token: 0x04000B02 RID: 2818
		private string _autoformat;

		// Token: 0x04000B03 RID: 2819
		private string _isDrawTableFooterEveryPage;

		// Token: 0x04000B04 RID: 2820
		private string _isusedgvpadding;

		// Token: 0x04000B05 RID: 2821
		private string _linecolor;

		// Token: 0x04000B06 RID: 2822
		private string _sortcolumn;

		// Token: 0x04000B07 RID: 2823
		private string _sorttype;

		// Token: 0x04000B08 RID: 2824
		private string _groupcolumn;

		// Token: 0x04000B09 RID: 2825
		private string _printtype;

		// Token: 0x04000B0A RID: 2826
		private string _addrowid;

		// Token: 0x04000B0B RID: 2827
		private string _columns;

		// Token: 0x04000B0C RID: 2828
		private string _columnspace;

		// Token: 0x04000B0D RID: 2829
		private string _lastpagemode;

		// Token: 0x04000B0E RID: 2830
		private string _linespace;

		// Token: 0x04000B0F RID: 2831
		private string _printzero;

		// Token: 0x04000B10 RID: 2832
		private string _fixedcols;

		// Token: 0x04000B11 RID: 2833
		private string _autowrap;
	}
}
