using System;
using System.Collections;

namespace LuoEasyPrint
{
	// Token: 0x020000BE RID: 190
	public class XmlTableCollection : CollectionBase
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x000C82A0 File Offset: 0x000C64A0
		public int Add(XmlTable item)
		{
			return base.InnerList.Add(item);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0000842D File Offset: 0x0000662D
		public void Insert(int index, XmlTable item)
		{
			base.InnerList.Insert(index, item);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0000843C File Offset: 0x0000663C
		public void Remove(XmlTable item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x1700077A RID: 1914
		public XmlTable this[int index]
		{
			get
			{
				return (XmlTable)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
