using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A0 RID: 160
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RtfColorTable : IDisposable
	{
		// Token: 0x06001682 RID: 5762 RVA: 0x00007F3D File Offset: 0x0000613D
		public RtfColorTable()
		{
			this.numberOfColors = 0;
			this.loadedColors = new Hashtable();
			this.colortbl = "{\\colortbl;";
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000C1A88 File Offset: 0x000BFC88
		public int UseColor(Color key)
		{
			checked
			{
				int result;
				if (this.loadedColors.ContainsKey(key))
				{
					result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.loadedColors[key]));
				}
				else
				{
					this.colortbl = string.Concat(new string[]
					{
						this.colortbl,
						"\\red",
						Convert.ToString(key.R),
						"\\green",
						Convert.ToString(key.G),
						"\\blue",
						Convert.ToString(key.B),
						";"
					});
					this.numberOfColors++;
					this.loadedColors.Add(key, this.numberOfColors);
					result = this.numberOfColors;
				}
				return result;
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000C1B64 File Offset: 0x000BFD64
		public override string ToString()
		{
			return this.colortbl + "}";
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000C1B84 File Offset: 0x000BFD84
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				try
				{
					this.colortbl = null;
					this.loadedColors.Clear();
					this.loadedColors = null;
				}
				catch (Exception ex)
				{
				}
			}
			this.disposedValue = true;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00007F62 File Offset: 0x00006162
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000AB2 RID: 2738
		private int numberOfColors;

		// Token: 0x04000AB3 RID: 2739
		private string colortbl;

		// Token: 0x04000AB4 RID: 2740
		private Hashtable loadedColors;

		// Token: 0x04000AB5 RID: 2741
		private bool disposedValue;
	}
}
