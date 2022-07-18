using System;
using System.Collections;

namespace LuoEasyPrint
{
	// Token: 0x020000BD RID: 189
	public class XmlTableCellCollection : CollectionBase
	{
		// Token: 0x0600181D RID: 6173 RVA: 0x000C8264 File Offset: 0x000C6464
		public int Add(XmlTableCell item)
		{
			return base.InnerList.Add(item);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0000842D File Offset: 0x0000662D
		public void Insert(int index, XmlTableCell item)
		{
			base.InnerList.Insert(index, item);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0000843C File Offset: 0x0000663C
		public void Remove(XmlTableCell item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000779 RID: 1913
		public XmlTableCell this[int index]
		{
			get
			{
				return (XmlTableCell)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
