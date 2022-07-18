using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000B6 RID: 182
	public class XmlPageHeaderAndFooter : XmlGoldPrinterElement
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x00008590 File Offset: 0x00006790
		public XmlPageHeaderAndFooter()
		{
			this._left = "";
			this._right = "";
			this._middle = "";
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000085B9 File Offset: 0x000067B9
		public XmlPageHeaderAndFooter(XmlNode mytext)
		{
			this._left = "";
			this._right = "";
			this._middle = "";
			base.XmlNode = mytext;
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000C6F28 File Offset: 0x000C5128
		protected override void ParseMySelf()
		{
			this._left = this.GetXmlNodeAttributeValue("LeftText");
			this._middle = this.GetXmlNodeAttributeValue("MiddleText");
			this._right = this.GetXmlNodeAttributeValue("RightText");
			XmlTextFormat xmlTextFormat = new XmlTextFormat(base.XmlNode);
			xmlTextFormat.Parse();
			this._TextFormat = xmlTextFormat;
			if (String.Compare(this._left, "", false) != 0)
			{
				this._left = this.ReplaceFunction(this._left);
			}
			if (String.Compare(this._middle, "", false) != 0)
			{
				this._middle = this.ReplaceFunction(this._middle);
			}
			if (String.Compare(this._right, "", false) != 0)
			{
				this._right = this.ReplaceFunction(this._right);
			}
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000C6FF4 File Offset: 0x000C51F4
		protected string ReplaceFunction(string old)
		{
			string text = old;
			if (text.IndexOf("\\") > -1)
			{
				text = text.Replace("\\n", "\n");
			}
			if (text.IndexOf("[@") > -1)
			{
				text = text.Replace("[@NewLine]", "\n").Replace("[@Now]", DateTime.Now.ToString()).Replace("[@Year]", DateTime.Now.Year.ToString()).Replace("[@Month]", DateTime.Now.Month.ToString()).Replace("[@Day]", DateTime.Now.Day.ToString());
			}
			return text.Replace("VbCrLf", "\n");
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000C70D0 File Offset: 0x000C52D0
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x000085E9 File Offset: 0x000067E9
		public string LeftText
		{
			get
			{
				return this._left;
			}
			set
			{
				this._left = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000C70E8 File Offset: 0x000C52E8
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x000085F2 File Offset: 0x000067F2
		public string MiddleText
		{
			get
			{
				return this._middle;
			}
			set
			{
				this._middle = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x000C7100 File Offset: 0x000C5300
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x000085FB File Offset: 0x000067FB
		public string RightText
		{
			get
			{
				return this._right;
			}
			set
			{
				this._right = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000C7118 File Offset: 0x000C5318
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00008604 File Offset: 0x00006804
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

		// Token: 0x04000B2A RID: 2858
		private string _left;

		// Token: 0x04000B2B RID: 2859
		private string _right;

		// Token: 0x04000B2C RID: 2860
		private string _middle;

		// Token: 0x04000B2D RID: 2861
		private XmlTextFormat _TextFormat;
	}
}
