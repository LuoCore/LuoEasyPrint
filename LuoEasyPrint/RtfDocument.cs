using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace LuoEasyPrint
{
	// Token: 0x020000A1 RID: 161
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RtfDocument : IDisposable
	{
		// Token: 0x06001687 RID: 5767 RVA: 0x00007F71 File Offset: 0x00006171
		public RtfDocument()
		{
			this.document = new StringBuilder();
			this.header = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052";
			this.fonttbl = new RtfFontTable();
			this.colortbl = new RtfColorTable();
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000C1BDC File Offset: 0x000BFDDC
		public override string ToString()
		{
			this.header = this.header + this.fonttbl.ToString() + this.colortbl.ToString();
			return this.header + "{" + this.document.ToString() + "}}";
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00007FA5 File Offset: 0x000061A5
		public void AppendText(string text)
		{
			this.document.Append(text);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000C1C34 File Offset: 0x000BFE34
		public int UseFont(string fontName)
		{
			return this.fonttbl.UseFont(fontName);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000C1C50 File Offset: 0x000BFE50
		public int UseColor(Color fromArgb)
		{
			return this.colortbl.UseColor(fromArgb);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000C1C6C File Offset: 0x000BFE6C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				try
				{
					this.document = null;
					this.header = null;
					this.colortbl.Dispose();
					this.fonttbl.Dispose();
				}
				catch (Exception ex)
				{
				}
			}
			this.disposedValue = true;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00007FB4 File Offset: 0x000061B4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000AB6 RID: 2742
		private RtfFontTable fonttbl;

		// Token: 0x04000AB7 RID: 2743
		private RtfColorTable colortbl;

		// Token: 0x04000AB8 RID: 2744
		private string header;

		// Token: 0x04000AB9 RID: 2745
		private StringBuilder document;

		// Token: 0x04000ABA RID: 2746
		private bool disposedValue;
	}
}
