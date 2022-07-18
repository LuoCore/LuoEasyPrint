using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000B0 RID: 176
	public abstract class XmlGoldPrinterElement : XmlParserBase
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x000083A2 File Offset: 0x000065A2
		public XmlGoldPrinterElement()
		{
			this.Init();
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000083B0 File Offset: 0x000065B0
		public XmlGoldPrinterElement(XmlNode element) : this()
		{
			this._XmlNode = element;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000083BF File Offset: 0x000065BF
		protected virtual void Init()
		{
			this._ID = "";
			this._X = "-1";
			this._Y = "-1";
			this._Width = "-1";
			this._Height = "-1";
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000C64A8 File Offset: 0x000C46A8
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			this.ParseMySelf();
			return this;
		}

		// Token: 0x0600175B RID: 5979
		protected abstract void ParseMySelf();

		// Token: 0x0600175C RID: 5980 RVA: 0x000C64C4 File Offset: 0x000C46C4
		private void ParseXmlNode()
		{
			string text = this.GetXmlNodeAttributeValue("id").Trim();
			string text2 = this.GetXmlNodeAttributeValue("X").Trim();
			string text3 = this.GetXmlNodeAttributeValue("Y").Trim();
			string width = this.GetXmlNodeAttributeValue("Width").Trim();
			string height = this.GetXmlNodeAttributeValue("Height").Trim();
			if (String.Compare(text, "", false) != 0)
			{
				this._ID = text;
			}
			else
			{
				text = this.GetXmlNodeAttributeValue("Name").Trim();
				if (String.Compare(text, "", false) != 0)
				{
					this._ID = text;
				}
			}
			if (String.Compare(text2, "", false) != 0)
			{
				this._X = text2;
			}
			else
			{
				text2 = this.GetXmlNodeAttributeValue("Left").Trim();
				this._X = text2;
			}
			if (String.Compare(text3, "", false) != 0)
			{
				this._Y = text3;
			}
			else
			{
				text3 = this.GetXmlNodeAttributeValue("Top").Trim();
				this._Y = text3;
			}
			this._Width = width;
			this._Height = height;
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000C65E0 File Offset: 0x000C47E0
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x000083F8 File Offset: 0x000065F8
		public string Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x000C65F8 File Offset: 0x000C47F8
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x00008401 File Offset: 0x00006601
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x000C6610 File Offset: 0x000C4810
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0000840A File Offset: 0x0000660A
		public string Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				this._Width = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x000C6628 File Offset: 0x000C4828
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00008413 File Offset: 0x00006613
		public string X
		{
			get
			{
				return this._X;
			}
			set
			{
				this._X = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000C6640 File Offset: 0x000C4840
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000841C File Offset: 0x0000661C
		public string Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				this._Y = value;
			}
		}

		// Token: 0x04000B12 RID: 2834
		private string _Height;

		// Token: 0x04000B13 RID: 2835
		private string _ID;

		// Token: 0x04000B14 RID: 2836
		private string _Width;

		// Token: 0x04000B15 RID: 2837
		private string _X;

		// Token: 0x04000B16 RID: 2838
		private string _Y;
	}
}
