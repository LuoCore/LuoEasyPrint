using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000B5 RID: 181
	public sealed class XmlPaddingStyle : XmlParserBase
	{
		// Token: 0x0600179A RID: 6042 RVA: 0x00008521 File Offset: 0x00006721
		public XmlPaddingStyle()
		{
			this.Init();
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0000852F File Offset: 0x0000672F
		public XmlPaddingStyle(XmlNode format) : this()
		{
			this._XmlNode = format;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0000853E File Offset: 0x0000673E
		private void Init()
		{
			this._Left = "0";
			this._Right = "0";
			this._Top = "0";
			this._Bottom = "0";
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000C6E00 File Offset: 0x000C5000
		public override IXmlParser Parse()
		{
			this.ParseXmlNode();
			return this;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000C6E18 File Offset: 0x000C5018
		private void ParseXmlNode()
		{
			if (String.Compare(this.GetXmlNodeAttributeValue("Padding"), "", false) == 0)
			{
				this._Left = this.GetXmlNodeAttributeValue("PaddingLeft");
				this._Right = this.GetXmlNodeAttributeValue("PaddingRight");
				this._Top = this.GetXmlNodeAttributeValue("PaddingTop");
				this._Bottom = this.GetXmlNodeAttributeValue("PaddingBottom");
			}
			else
			{
				this._Left = this.GetXmlNodeAttributeValue("Padding");
				this._Right = this.GetXmlNodeAttributeValue("Padding");
				this._Top = this.GetXmlNodeAttributeValue("Padding");
				this._Bottom = this.GetXmlNodeAttributeValue("Padding");
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x000C6EC8 File Offset: 0x000C50C8
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000856C File Offset: 0x0000676C
		public string Bottom
		{
			get
			{
				return this._Bottom;
			}
			set
			{
				this._Bottom = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x000C6EE0 File Offset: 0x000C50E0
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x00008575 File Offset: 0x00006775
		public string Left
		{
			get
			{
				return this._Left;
			}
			set
			{
				this._Left = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000C6EF8 File Offset: 0x000C50F8
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000857E File Offset: 0x0000677E
		public string Right
		{
			get
			{
				return this._Right;
			}
			set
			{
				this._Right = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000C6F10 File Offset: 0x000C5110
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x00008587 File Offset: 0x00006787
		public string Top
		{
			get
			{
				return this._Top;
			}
			set
			{
				this._Top = value;
			}
		}

		// Token: 0x04000B26 RID: 2854
		private string _Bottom;

		// Token: 0x04000B27 RID: 2855
		private string _Left;

		// Token: 0x04000B28 RID: 2856
		private string _Right;

		// Token: 0x04000B29 RID: 2857
		private string _Top;
	}
}
