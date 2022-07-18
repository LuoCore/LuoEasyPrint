using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000C4 RID: 196
	public class XmlTextLabel : XmlGoldPrinterElement
	{
		// Token: 0x06001885 RID: 6277 RVA: 0x000086FE File Offset: 0x000068FE
		public XmlTextLabel()
		{
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000089FB File Offset: 0x00006BFB
		public XmlTextLabel(XmlNode mytext)
		{
			base.XmlNode = mytext;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000C9C84 File Offset: 0x000C7E84
		protected override void ParseMySelf()
		{
			this._Text = this.GetXmlNodeText();
			if (String.Compare(this._Text, "", false) == 0)
			{
				this._Text = this.GetXmlNodeAttributeValue("Text");
			}
			XmlTextFormat xmlTextFormat = new XmlTextFormat(base.XmlNode);
			xmlTextFormat.Parse();
			this._TextFormat = xmlTextFormat;
			if (String.Compare(this._Text, "", false) != 0)
			{
				this._Text = this.ReplaceFunction(this._Text);
			}
			this._linespace = this.GetXmlNodeAttributeValue("LineSpace");
			this._charspace = this.GetXmlNodeAttributeValue("CharSpace");
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000C9D24 File Offset: 0x000C7F24
		protected string ReplaceFunction(string old)
		{
			string text = old;
			if (text.IndexOf("\\") > -1)
			{
				text = text.Replace("\\n", "\r\n");
			}
			if (text.IndexOf("[") > -1)
			{
				text = text.Replace("[NewLine]", "\r\n").Replace("[Now]", DateTime.Now.ToString()).Replace("[Year]", DateTime.Now.Year.ToString()).Replace("[Month]", DateTime.Now.Month.ToString()).Replace("[Day]", DateTime.Now.Day.ToString());
			}
			return text.Replace("VbCrLf", "\r\n");
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000C9E00 File Offset: 0x000C8000
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00008A0A File Offset: 0x00006C0A
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000C9E18 File Offset: 0x000C8018
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x00008A13 File Offset: 0x00006C13
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x000C9E30 File Offset: 0x000C8030
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x00008A1C File Offset: 0x00006C1C
		public string LineSpace
		{
			get
			{
				return this._linespace;
			}
			set
			{
				this._linespace = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x000C9E48 File Offset: 0x000C8048
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x00008A25 File Offset: 0x00006C25
		public string CharSpace
		{
			get
			{
				return this._charspace;
			}
			set
			{
				this._charspace = value;
			}
		}

		// Token: 0x04000B69 RID: 2921
		private string _linespace;

		// Token: 0x04000B6A RID: 2922
		private string _charspace;

		// Token: 0x04000B6B RID: 2923
		private string _Text;

		// Token: 0x04000B6C RID: 2924
		private XmlTextFormat _TextFormat;
	}
}
