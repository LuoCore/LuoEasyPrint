using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x02000164 RID: 356
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IBarcode
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001E77 RID: 7799
		string Encoded_Value { get; }
	}
}
