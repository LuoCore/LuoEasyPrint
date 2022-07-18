using System;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000AE RID: 174
	public class XmlEllipse : XmlCircle
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x00008366 File Offset: 0x00006566
		public XmlEllipse()
		{
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0000836E File Offset: 0x0000656E
		public XmlEllipse(XmlNode ellipse)
		{
			base.XmlNode = ellipse;
		}
	}
}
