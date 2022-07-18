using System;
using System.Collections;

namespace LuoEasyPrint
{
	// Token: 0x020000B1 RID: 177
	public class XmlGoldPrinterElementCollection : CollectionBase
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x000C6658 File Offset: 0x000C4858
		public int Add(XmlGoldPrinterElement item)
		{
			return base.InnerList.Add(item);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0000842D File Offset: 0x0000662D
		public void Insert(int index, XmlGoldPrinterElement item)
		{
			base.InnerList.Insert(index, item);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0000843C File Offset: 0x0000663C
		public void Remove(XmlGoldPrinterElement item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000744 RID: 1860
		public XmlGoldPrinterElement this[int index]
		{
			get
			{
				return (XmlGoldPrinterElement)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
