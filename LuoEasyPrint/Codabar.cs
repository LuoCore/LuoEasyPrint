using System;
using System.Collections;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200015C RID: 348
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Codabar : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E52 RID: 7762 RVA: 0x0000A98F File Offset: 0x00008B8F
		public Codabar(string input)
		{
			this.Codabar_Code = new Hashtable();
			this.Raw_Data = input;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000F7CA4 File Offset: 0x000F5EA4
		private string Encode_Codabar()
		{
			if (this.Raw_Data.Length < 2)
			{
				throw new Exception("ECODABAR-1: 数据格式不正确. (长度不正确，必须大于等于2)");
			}
			string left = this.Raw_Data[0].ToString().ToUpper().Trim();
			if (String.Compare(left, "A", false) != 0)
			{
				if (String.Compare(left, "B", false) != 0)
				{
					if (String.Compare(left, "C", false) != 0)
					{
						if (String.Compare(left, "D", false) != 0)
						{
							throw new Exception("ECODABAR-2: 数据格式不正确. (不正确的开始字符)");
						}
					}
				}
			}
			checked
			{
				string left2 = this.Raw_Data[this.Raw_Data.Trim().Length - 1].ToString().ToUpper().Trim();
				if (String.Compare(left2, "A", false) != 0)
				{
					if (String.Compare(left2, "B", false) != 0)
					{
						if (String.Compare(left2, "C", false) != 0)
						{
							if (String.Compare(left2, "D", false) != 0)
							{
								throw new Exception("ECODABAR-3: 数据格式不正确. (不正确的结束字符)");
							}
						}
					}
				}
				string text = "";
				this.init_Codabar();
				string raw_Data = this.Raw_Data;
				int i = 0;
				int length = raw_Data.Length;
				while (i < length)
				{
					char c = raw_Data[i];
					text += this.Codabar_Code[c.ToString()].ToString();
					text += "0";
					i++;
				}
				text = text.Remove(text.Length - 1);
				this.Codabar_Code.Clear();
				return text;
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000F7E44 File Offset: 0x000F6044
		private void init_Codabar()
		{
			this.Codabar_Code.Clear();
			this.Codabar_Code.Add("0", "101010011");
			this.Codabar_Code.Add("1", "101011001");
			this.Codabar_Code.Add("2", "101001011");
			this.Codabar_Code.Add("3", "110010101");
			this.Codabar_Code.Add("4", "101101001");
			this.Codabar_Code.Add("5", "110101001");
			this.Codabar_Code.Add("6", "100101011");
			this.Codabar_Code.Add("7", "100101101");
			this.Codabar_Code.Add("8", "100110101");
			this.Codabar_Code.Add("9", "110100101");
			this.Codabar_Code.Add("-", "101001101");
			this.Codabar_Code.Add("$", "101100101");
			this.Codabar_Code.Add(":", "1101011011");
			this.Codabar_Code.Add("/", "1101101011");
			this.Codabar_Code.Add(".", "1101101101");
			this.Codabar_Code.Add("+", "101100110011");
			this.Codabar_Code.Add("A", "1011001001");
			this.Codabar_Code.Add("B", "1010010011");
			this.Codabar_Code.Add("C", "1001001011");
			this.Codabar_Code.Add("D", "1010011001");
			this.Codabar_Code.Add("a", "1011001001");
			this.Codabar_Code.Add("b", "1010010011");
			this.Codabar_Code.Add("c", "1001001011");
			this.Codabar_Code.Add("d", "1010011001");
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000F8054 File Offset: 0x000F6254
		public string Encoded_Value
		{
			get
			{
				return this.Encode_Codabar();
			}
		}

		// Token: 0x0400105E RID: 4190
		private Hashtable Codabar_Code;
	}
}
