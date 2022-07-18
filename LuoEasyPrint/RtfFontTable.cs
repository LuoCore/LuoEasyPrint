using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A2 RID: 162
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RtfFontTable : IDisposable
	{
		// Token: 0x0600168E RID: 5774 RVA: 0x000C1CD0 File Offset: 0x000BFED0
		public string GetMyString(string tt)
		{
			checked
			{
				string result;
				if (String.Compare(tt, "", false) == 0)
				{
					result = "";
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder("");
					int num = 0;
					int num2 = tt.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						string text = Strings.Mid(tt, i + 1, 1);
						string text2;
						if (Strings.Asc(text) < 0)
						{
							text = Conversion.Hex(Strings.Asc(text) + 65536).ToLower();
							text2 = "\\'" + Strings.Left(text, 2);
							text2 = text2 + "\\'" + Strings.Right(text, 2);
						}
						else
						{
							text2 = text;
						}
						stringBuilder.Append(text2);
					}
					result = stringBuilder.ToString();
				}
				return result;
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00007FC3 File Offset: 0x000061C3
		public RtfFontTable()
		{
			this.numberOfFonts = 0;
			this.loadedFonts = new Hashtable();
			this.fonttbl = "{\\fonttbl{\\f0\\fmodern\\fprq6\\fcharset134" + this.GetMyString("宋体") + ";}";
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000C1D84 File Offset: 0x000BFF84
		public int UseFont(string fontName)
		{
			fontName = this.GetMyString(fontName);
			checked
			{
				int result;
				if (this.loadedFonts.Contains(fontName))
				{
					result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.loadedFonts[fontName]));
				}
				else
				{
					this.numberOfFonts++;
					this.fonttbl = string.Concat(new string[]
					{
						this.fonttbl,
						"{\\f",
						Convert.ToString(this.numberOfFonts),
						"\\fnil ",
						fontName,
						";}"
					});
					this.loadedFonts.Add(fontName, this.numberOfFonts);
					result = this.numberOfFonts;
				}
				return result;
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000C1E34 File Offset: 0x000C0034
		public override string ToString()
		{
			return this.fonttbl + "}";
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000C1E54 File Offset: 0x000C0054
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				try
				{
					this.fonttbl = null;
					this.loadedFonts.Clear();
					this.loadedFonts = null;
				}
				catch (Exception ex)
				{
				}
			}
			this.disposedValue = true;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00007FFD File Offset: 0x000061FD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000ABB RID: 2747
		private int numberOfFonts;

		// Token: 0x04000ABC RID: 2748
		private string fonttbl;

		// Token: 0x04000ABD RID: 2749
		private Hashtable loadedFonts;

		// Token: 0x04000ABE RID: 2750
		private bool disposedValue;
	}
}
