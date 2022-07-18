using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000C5 RID: 197
	public class XmlTitle : XmlGoldPrinterElement
	{
		// Token: 0x06001891 RID: 6289 RVA: 0x000086FE File Offset: 0x000068FE
		public XmlTitle()
		{
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x000089FB File Offset: 0x00006BFB
		public XmlTitle(XmlNode mytext)
		{
			base.XmlNode = mytext;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x000C9E60 File Offset: 0x000C8060
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

		// Token: 0x06001894 RID: 6292 RVA: 0x000C9F00 File Offset: 0x000C8100
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

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x000C9FDC File Offset: 0x000C81DC
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00008A2E File Offset: 0x00006C2E
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

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x000C9FF4 File Offset: 0x000C81F4
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x00008A37 File Offset: 0x00006C37
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

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x000CA00C File Offset: 0x000C820C
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00008A40 File Offset: 0x00006C40
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

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x000CA024 File Offset: 0x000C8224
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x00008A49 File Offset: 0x00006C49
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

		// Token: 0x04000B6D RID: 2925
		private string _linespace;

		// Token: 0x04000B6E RID: 2926
		private string _charspace;

		// Token: 0x04000B6F RID: 2927
		private string _Text;

		// Token: 0x04000B70 RID: 2928
		private XmlTextFormat _TextFormat;
	}
}
