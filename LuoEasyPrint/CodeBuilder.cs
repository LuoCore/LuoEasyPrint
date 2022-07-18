using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;

namespace LuoEasyPrint
{
	// Token: 0x0200003B RID: 59
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CodeBuilder
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x00004790 File Offset: 0x00002990
		public CodeBuilder()
		{
			this._StringBuilder = new StringBuilder();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000047A3 File Offset: 0x000029A3
		public void AppendCode()
		{
			this._StringBuilder.AppendFormat("{0}{1}\r\n", Strings.Space(0), Strings.Space(0));
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000047C2 File Offset: 0x000029C2
		public void AppendCode(string CodeString)
		{
			this._StringBuilder.AppendFormat("{0}{1}\r\n", Strings.Space(0), CodeString);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000047DC File Offset: 0x000029DC
		public void AppendCode(int CodeFloor, string CodeString)
		{
			this._StringBuilder.AppendFormat("{0}{1}\r\n", Strings.Space(checked(CodeFloor * 4)), CodeString);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000586A8 File Offset: 0x000568A8
		public void AppendFromFile(string FileName)
		{
			if (File.Exists(FileName))
			{
				FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
				string text = streamReader.ReadToEnd();
				text = "\r\n" + text + "\r\n\r\n";
				streamReader.Close();
				fileStream.Close();
				this._StringBuilder.Append(text);
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00058704 File Offset: 0x00056904
		public override string ToString()
		{
			return this._StringBuilder.ToString();
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000047F8 File Offset: 0x000029F8
		public void Clear()
		{
			if (this._StringBuilder.Length > 0)
			{
				this._StringBuilder.Remove(0, checked(this._StringBuilder.Length - 1));
			}
		}

		// Token: 0x04000536 RID: 1334
		private StringBuilder _StringBuilder;

		// Token: 0x04000537 RID: 1335
		private const string CodeFormat = "{0}{1}\r\n";
	}
}
