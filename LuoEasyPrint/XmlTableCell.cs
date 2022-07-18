using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000BC RID: 188
	public class XmlTableCell : XmlGoldPrinterElement
	{
		// Token: 0x06001810 RID: 6160 RVA: 0x000087D2 File Offset: 0x000069D2
		internal XmlTableCell(XmlTableRow row)
		{
			this._Row = null;
			this._Row = row;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000087E8 File Offset: 0x000069E8
		public XmlTableCell(XmlNode cell, XmlTableRow row) : this(row)
		{
			base.XmlNode = cell;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000C8084 File Offset: 0x000C6284
		protected override void ParseMySelf()
		{
			if (base.XmlNode != null)
			{
				this._Text = this.GetXmlNodeAttributeValue("Text");
				if (String.Compare(this._Text, "", false) == 0)
				{
					this._Text = this.GetXmlNodeChildNodeValue("Text");
				}
				XmlNode xmlNode = base.XmlNode;
				XmlTextFormat xmlTextFormat = new XmlTextFormat(xmlNode);
				xmlTextFormat.Parse();
				this.TextFormat = xmlTextFormat;
				XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(xmlNode);
				xmlBorderFormat.Parse();
				this.BorderFormat = xmlBorderFormat;
				if (this.TextFormat.IsEmpty)
				{
					this._TextFormat = (XmlTextFormat)this._Row.TextFormat.Clone();
				}
				else
				{
					this._TextFormat = (XmlTextFormat)this._Row.TextFormat.CloneNoEmpty(this._TextFormat);
				}
				if (this.BorderFormat.IsEmpty)
				{
					this._BorderFormat = (XmlBorderFormat)this._Row.BorderFormat.Clone();
				}
				else
				{
					this._BorderFormat = (XmlBorderFormat)this._Row.BorderFormat.CloneNoEmpty(this._BorderFormat);
				}
				XmlNode xmlNodeChildNodeByName = base.GetXmlNodeChildNodeByName("GoldPrinterElement");
				if (xmlNodeChildNodeByName != null)
				{
					this._Child = XmlGoldPrinterElementFactory.Create(xmlNodeChildNodeByName);
				}
				else if (String.Compare(this._Text, "", false) == 0)
				{
					this._Text = this.GetXmlNodeText();
				}
			}
			else
			{
				this.TextFormat = this._Row.TextFormat;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000C81EC File Offset: 0x000C63EC
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x000087F8 File Offset: 0x000069F8
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

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000C8204 File Offset: 0x000C6404
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x00008801 File Offset: 0x00006A01
		public XmlGoldPrinterElement Child
		{
			get
			{
				return this._Child;
			}
			set
			{
				this._Child = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000C821C File Offset: 0x000C641C
		public XmlTableRow Row
		{
			get
			{
				return this._Row;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000C8234 File Offset: 0x000C6434
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0000880A File Offset: 0x00006A0A
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000C824C File Offset: 0x000C644C
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00008813 File Offset: 0x00006A13
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

		// Token: 0x04000B44 RID: 2884
		private XmlBorderFormat _BorderFormat;

		// Token: 0x04000B45 RID: 2885
		private XmlGoldPrinterElement _Child;

		// Token: 0x04000B46 RID: 2886
		private XmlTableRow _Row;

		// Token: 0x04000B47 RID: 2887
		private string _Text;

		// Token: 0x04000B48 RID: 2888
		private XmlTextFormat _TextFormat;
	}
}
