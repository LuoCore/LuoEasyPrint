using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	// Token: 0x02000167 RID: 359
	public interface IShape
	{
		// Token: 0x06001E90 RID: 7824
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		string SaveAsString();

		// Token: 0x06001E91 RID: 7825
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		void RestoreFromString(string ss);

		// Token: 0x06001E92 RID: 7826
		void Draw(Graphics g, int width, int height);
	}
}
