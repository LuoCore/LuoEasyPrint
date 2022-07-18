using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	// Token: 0x02000169 RID: 361
	public abstract class Shape : IShape
	{
		// Token: 0x06001EA3 RID: 7843 RVA: 0x0000AAC2 File Offset: 0x00008CC2
		protected Shape()
		{
			this._split1 = "\u0003\a";
			this._split2 = "\u0004\a";
		}

		// Token: 0x06001EA4 RID: 7844
		public abstract void Draw(Graphics g, int width, int height);

		// Token: 0x06001EA5 RID: 7845
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public abstract void RestoreFromString(string ss);

		// Token: 0x06001EA6 RID: 7846
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public abstract string SaveAsString();

		// Token: 0x0400108B RID: 4235
		internal string _split1;

		// Token: 0x0400108C RID: 4236
		internal string _split2;
	}
}
