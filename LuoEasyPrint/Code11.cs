using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200015D RID: 349
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Code11 : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E56 RID: 7766 RVA: 0x000F806C File Offset: 0x000F626C
		public Code11(string input)
		{
			this.C11_Code = new string[]
			{
				"101011",
				"1101011",
				"1001011",
				"1100101",
				"1011011",
				"1101101",
				"1001101",
				"1010011",
				"1101001",
				"110101",
				"101101",
				"1011001"
			};
			this.Raw_Data = input;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000F80F8 File Offset: 0x000F62F8
		private string Encode_Code11()
		{
			if (!barmodule.CheckNumericOnly(this.Raw_Data.Replace("-", "")))
			{
				throw new Exception("EC11-1: 仅容许使用数字和'-' 符号");
			}
			int num = 1;
			int num2 = 0;
			string text = this.Raw_Data;
			checked
			{
				for (int i = this.Raw_Data.Length - 1; i >= 0; i += -1)
				{
					if (num == 10)
					{
						num = 1;
					}
					if (String.Compare(Convert.ToString(this.Raw_Data[i]), "-", false) != 0)
					{
						num2 += int.Parse(this.Raw_Data[i].ToString()) * num;
						num++;
					}
					else
					{
						num2 += 10 * num;
						num++;
					}
				}
				text += (num2 % 11).ToString();
				if (this.Raw_Data.Length >= 1)
				{
					num = 1;
					int num3 = 0;
					for (int j = text.Length - 1; j >= 0; j += -1)
					{
						if (num == 9)
						{
							num = 1;
						}
						if (String.Compare(Convert.ToString(text[j]), "-", false) != 0)
						{
							num3 += int.Parse(text[j].ToString()) * num;
							num++;
						}
						else
						{
							num3 += 10 * num;
							num++;
						}
					}
					text += (num3 % 11).ToString();
				}
				string str = "0";
				string str2 = this.C11_Code[11] + str;
				string text2 = text;
				int k = 0;
				int length = text2.Length;
				while (k < length)
				{
					char c = text2[k];
					int num4;
					if (String.Compare(c.ToString(), "-", false) == 0)
					{
						num4 = 10;
					}
					else
					{
						num4 = int.Parse(c.ToString());
					}
					str2 += this.C11_Code[num4];
					str2 += str;
					k++;
				}
				return str2 + this.C11_Code[11];
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000F8304 File Offset: 0x000F6504
		public string Encoded_Value
		{
			get
			{
				return this.Encode_Code11();
			}
		}

		// Token: 0x0400105F RID: 4191
		private string[] C11_Code;
	}
}
