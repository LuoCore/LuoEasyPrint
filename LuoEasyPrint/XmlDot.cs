using System;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000AD RID: 173
	public class XmlDot : XmlShape
	{
		// Token: 0x06001726 RID: 5926 RVA: 0x00008346 File Offset: 0x00006546
		public XmlDot()
		{
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0000834E File Offset: 0x0000654E
		public XmlDot(XmlNode dot)
		{
			base.XmlNode = dot;
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000C57B4 File Offset: 0x000C39B4
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000835D File Offset: 0x0000655D
		public override string Color
		{
			get
			{
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000C57CC File Offset: 0x000C39CC
		public Color LineColor
		{
			get
			{
				Color result;
				if (String.Compare(base.Color, "", false) == 0)
				{
					result = System.Drawing.Color.Black;
				}
				else
				{
					Color colorFrom = XmlParserBase.GetColorFrom(base.Color);
					if (colorFrom.IsEmpty)
					{
						result = System.Drawing.Color.Black;
					}
					else
					{
						result = colorFrom;
					}
				}
				return result;
			}
		}
	}
}
