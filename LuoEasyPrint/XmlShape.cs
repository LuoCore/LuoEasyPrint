using System;
using System.Xml;

namespace LuoEasyPrint
{ 
	// Token: 0x020000BA RID: 186
	public class XmlShape : XmlGoldPrinterElement
	{
		// Token: 0x060017F1 RID: 6129 RVA: 0x000086FE File Offset: 0x000068FE
		public XmlShape()
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00008706 File Offset: 0x00006906
		public XmlShape(XmlNode shape)
		{
			base.XmlNode = shape;
			this.Parse();
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0000871C File Offset: 0x0000691C
		protected override void ParseMySelf()
		{
			this._Color = this.GetXmlNodeAttributeValue("Color");
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x000C7C44 File Offset: 0x000C5E44
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000872F File Offset: 0x0000692F
		public virtual string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				this._Color = value;
			}
		}

		// Token: 0x04000B41 RID: 2881
		private string _Color;
	}
}
