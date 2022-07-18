using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A3 RID: 163
	[StandardModule]
	internal sealed class XMLtoRTF
	{
		// Token: 0x06001694 RID: 5780 RVA: 0x000C1EAC File Offset: 0x000C00AC
		public static string XML2RTF(string s_xml)
		{
			XmlTranslator xmlTranslator = new XmlTranslator(s_xml);
			string result = xmlTranslator.ToRtfDocument().ToString();
			xmlTranslator.Dispose();
			return result;
		}
	}
}
