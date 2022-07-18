using System;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000C2 RID: 194
	public class XmlTextBox : XmlTextLabel
	{
		// Token: 0x06001850 RID: 6224 RVA: 0x0000892E File Offset: 0x00006B2E
		public XmlTextBox()
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00008936 File Offset: 0x00006B36
		public XmlTextBox(XmlNode textBox)
		{
			base.XmlNode = textBox;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000C8714 File Offset: 0x000C6914
		protected override void ParseMySelf()
		{
			base.ParseMySelf();
			this._LineColor = this.GetXmlNodeAttributeValue("LineColor");
			this._Border = this.GetXmlNodeAttributeValue("Border");
			if (String.Compare(this._Border, "", false) == 0)
			{
				string text = this.GetXmlNodeAttributeValue("leftborder");
				string text2 = this.GetXmlNodeAttributeValue("topborder");
				string text3 = this.GetXmlNodeAttributeValue("rightborder");
				string text4 = this.GetXmlNodeAttributeValue("bottomborder");
				if (String.Compare(text, "", false) == 0 & String.Compare(text2, "", false) == 0 & String.Compare(text3, "", false) == 0 & String.Compare(text4, "", false) == 0)
				{
					this._Border = "0,0,0,0";
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
					this._Border = string.Concat(new string[]
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
			else if (Strings.InStr(this._Border, ",", CompareMethod.Binary) <= 0)
			{
				string border = this._Border;
				this._Border = string.Concat(new string[]
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
			XmlBorderFormat xmlBorderFormat = new XmlBorderFormat(base.XmlNode);
			xmlBorderFormat.Parse();
			this._BorderFormat = xmlBorderFormat;
			XmlPaddingStyle xmlPaddingStyle = new XmlPaddingStyle(base.XmlNode);
			xmlPaddingStyle.Parse();
			this._padding = xmlPaddingStyle;
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x000C8920 File Offset: 0x000C6B20
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00008945 File Offset: 0x00006B45
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

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x000C8938 File Offset: 0x000C6B38
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000894E File Offset: 0x00006B4E
		public string Border
		{
			get
			{
				return this._Border;
			}
			set
			{
				this._Border = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x000C8950 File Offset: 0x000C6B50
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00008957 File Offset: 0x00006B57
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

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x000C8968 File Offset: 0x000C6B68
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x00008960 File Offset: 0x00006B60
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

		// Token: 0x04000B55 RID: 2901
		private XmlBorderFormat _BorderFormat;

		// Token: 0x04000B56 RID: 2902
		private string _Border;

		// Token: 0x04000B57 RID: 2903
		private string _LineColor;

		// Token: 0x04000B58 RID: 2904
		private XmlPaddingStyle _padding;
	}
}
