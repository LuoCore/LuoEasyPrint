using System;
using System.Collections;

namespace LuoEasyPrint
{
	// Token: 0x020000C1 RID: 193
	public class XmlTableRowCollection : CollectionBase
	{
		// Token: 0x0600184B RID: 6219 RVA: 0x000C86D8 File Offset: 0x000C68D8
		public int Add(XmlTableRow item)
		{
			return base.InnerList.Add(item);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0000842D File Offset: 0x0000662D
		public void Insert(int index, XmlTableRow item)
		{
			base.InnerList.Insert(index, item);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0000843C File Offset: 0x0000663C
		public void Remove(XmlTableRow item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000789 RID: 1929
		public XmlTableRow this[int index]
		{
			get
			{
				return (XmlTableRow)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
