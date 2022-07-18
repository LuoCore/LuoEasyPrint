using System;
using System.Xml;

namespace LuoEasyPrint
{
	// Token: 0x020000A9 RID: 169
	public interface IXmlParser
	{
		// Token: 0x060016FF RID: 5887
		IXmlParser Parse();

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001700 RID: 5888
		// (set) Token: 0x06001701 RID: 5889
		XmlNode XmlNode { get; set; }
	}
}
