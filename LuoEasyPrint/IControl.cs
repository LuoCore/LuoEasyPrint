using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x0200001D RID: 29
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IControl
	{
		// Token: 0x060006D9 RID: 1753
		string SaveAsString();

		// Token: 0x060006DA RID: 1754
		void RestoreFromString(string ss);
	}
}
