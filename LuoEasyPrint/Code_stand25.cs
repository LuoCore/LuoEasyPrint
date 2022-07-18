using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x02000162 RID: 354
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Code_stand25 : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E6F RID: 7791 RVA: 0x000FC6F8 File Offset: 0x000FA8F8
		public Code_stand25(string input)
		{
			this.S25_Code = new string[]
			{
				"11101010101110",
				"10111010101110",
				"11101110101010",
				"10101110101110",
				"11101011101010",
				"10111011101010",
				"10101011101110",
				"10101110111010",
				"11101010111010",
				"10111010111010"
			};
			this.Raw_Data = input;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000FC774 File Offset: 0x000FA974
		private string Encode_Standard2of5()
		{
			if (!barmodule.CheckNumericOnly(this.Raw_Data))
			{
				throw new Exception("ES25-1: 标准25码仅允许是数字");
			}
			string str = "11011010";
			string raw_Data = this.Raw_Data;
			int i = 0;
			int length = raw_Data.Length;
			checked
			{
				while (i < length)
				{
					char c = raw_Data[i];
					str += this.S25_Code[int.Parse(c.ToString())];
					i++;
				}
				return str + "1101011";
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000FC7F0 File Offset: 0x000FA9F0
		public string Encoded_Value
		{
			get
			{
				return this.Encode_Standard2of5();
			}
		}

		// Token: 0x04001075 RID: 4213
		private string[] S25_Code;
	}
}
