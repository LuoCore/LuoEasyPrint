using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000160 RID: 352
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Code128New
	{
		// Token: 0x06001E63 RID: 7779 RVA: 0x000FAA00 File Offset: 0x000F8C00
		private static int GetCodeValue(string m_Code)
		{
			int result = 0;
			if (String.Compare(m_Code, "!", false) == 0)
			{
				result = 1;
			}
			else if (String.Compare(m_Code, "/", false) == 0)
			{
				result = 2;
			}
			else if (String.Compare(m_Code, "#", false) == 0)
			{
				result = 3;
			}
			else if (String.Compare(m_Code, "$", false) == 0)
			{
				result = 4;
			}
			else if (String.Compare(m_Code, "%", false) == 0)
			{
				result = 5;
			}
			else if (String.Compare(m_Code, "&", false) == 0)
			{
				result = 6;
			}
			else if (String.Compare(m_Code, "'", false) == 0)
			{
				result = 7;
			}
			else if (String.Compare(m_Code, "(", false) == 0)
			{
				result = 8;
			}
			else if (String.Compare(m_Code, ")", false) == 0)
			{
				result = 9;
			}
			else if (String.Compare(m_Code, "*", false) == 0)
			{
				result = 10;
			}
			else if (String.Compare(m_Code, "+", false) == 0)
			{
				result = 11;
			}
			else if (String.Compare(m_Code, ",", false) == 0)
			{
				result = 12;
			}
			else if (String.Compare(m_Code, "-", false) == 0)
			{
				result = 13;
			}
			else if (String.Compare(m_Code, ".", false) == 0)
			{
				result = 14;
			}
			else if (String.Compare(m_Code, "\\", false) == 0)
			{
				result = 15;
			}
			else if (String.Compare(m_Code, "0", false) == 0)
			{
				result = 16;
			}
			else if (String.Compare(m_Code, "1", false) == 0)
			{
				result = 17;
			}
			else if (String.Compare(m_Code, "2", false) == 0)
			{
				result = 18;
			}
			else if (String.Compare(m_Code, "3", false) == 0)
			{
				result = 19;
			}
			else if (String.Compare(m_Code, "4", false) == 0)
			{
				result = 20;
			}
			else if (String.Compare(m_Code, "5", false) == 0)
			{
				result = 21;
			}
			else if (String.Compare(m_Code, "6", false) == 0)
			{
				result = 22;
			}
			else if (String.Compare(m_Code, "7", false) == 0)
			{
				result = 23;
			}
			else if (String.Compare(m_Code, "8", false) == 0)
			{
				result = 24;
			}
			else if (String.Compare(m_Code, "9", false) == 0)
			{
				result = 25;
			}
			else if (String.Compare(m_Code, "A", false) == 0)
			{
				result = 33;
			}
			else if (String.Compare(m_Code, "B", false) == 0)
			{
				result = 34;
			}
			else if (String.Compare(m_Code, "C", false) == 0)
			{
				result = 35;
			}
			else if (String.Compare(m_Code, "D", false) == 0)
			{
				result = 36;
			}
			else if (String.Compare(m_Code, "E", false) == 0)
			{
				result = 37;
			}
			else if (String.Compare(m_Code, "F", false) == 0)
			{
				result = 38;
			}
			else if (String.Compare(m_Code, "G", false) == 0)
			{
				result = 39;
			}
			else if (String.Compare(m_Code, "H", false) == 0)
			{
				result = 40;
			}
			else if (String.Compare(m_Code, "I", false) == 0)
			{
				result = 41;
			}
			else if (String.Compare(m_Code, "J", false) == 0)
			{
				result = 42;
			}
			else if (String.Compare(m_Code, "K", false) == 0)
			{
				result = 43;
			}
			else if (String.Compare(m_Code, "L", false) == 0)
			{
				result = 44;
			}
			else if (String.Compare(m_Code, "M", false) == 0)
			{
				result = 45;
			}
			else if (String.Compare(m_Code, "N", false) == 0)
			{
				result = 46;
			}
			else if (String.Compare(m_Code, "O", false) == 0)
			{
				result = 47;
			}
			else if (String.Compare(m_Code, "P", false) == 0)
			{
				result = 48;
			}
			else if (String.Compare(m_Code, "Q", false) == 0)
			{
				result = 49;
			}
			else if (String.Compare(m_Code, "R", false) == 0)
			{
				result = 50;
			}
			else if (String.Compare(m_Code, "S", false) == 0)
			{
				result = 51;
			}
			else if (String.Compare(m_Code, "T", false) == 0)
			{
				result = 52;
			}
			else if (String.Compare(m_Code, "U", false) == 0)
			{
				result = 53;
			}
			else if (String.Compare(m_Code, "V", false) == 0)
			{
				result = 54;
			}
			else if (String.Compare(m_Code, "W", false) == 0)
			{
				result = 55;
			}
			else if (String.Compare(m_Code, "X", false) == 0)
			{
				result = 56;
			}
			else if (String.Compare(m_Code, "Y", false) == 0)
			{
				result = 57;
			}
			else if (String.Compare(m_Code, "Z", false) == 0)
			{
				result = 58;
			}
			else if (String.Compare(m_Code, "[", false) == 0)
			{
				result = 59;
			}
			else if (String.Compare(m_Code, "//", false) == 0)
			{
				result = 60;
			}
			else if (String.Compare(m_Code, "]", false) == 0)
			{
				result = 61;
			}
			else if (String.Compare(m_Code, "^", false) == 0)
			{
				result = 62;
			}
			else if (String.Compare(m_Code, "_", false) == 0)
			{
				result = 63;
			}
			else if (String.Compare(m_Code, "`", false) == 0)
			{
				result = 64;
			}
			else if (String.Compare(m_Code, "a", false) == 0)
			{
				result = 65;
			}
			else if (String.Compare(m_Code, "b", false) == 0)
			{
				result = 66;
			}
			else if (String.Compare(m_Code, "c", false) == 0)
			{
				result = 67;
			}
			else if (String.Compare(m_Code, "d", false) == 0)
			{
				result = 68;
			}
			else if (String.Compare(m_Code, "e", false) == 0)
			{
				result = 69;
			}
			else if (String.Compare(m_Code, "f", false) == 0)
			{
				result = 70;
			}
			else if (String.Compare(m_Code, "g", false) == 0)
			{
				result = 71;
			}
			else if (String.Compare(m_Code, "h", false) == 0)
			{
				result = 72;
			}
			else if (String.Compare(m_Code, "i", false) == 0)
			{
				result = 73;
			}
			else if (String.Compare(m_Code, "j", false) == 0)
			{
				result = 74;
			}
			else if (String.Compare(m_Code, "k", false) == 0)
			{
				result = 75;
			}
			else if (String.Compare(m_Code, "l", false) == 0)
			{
				result = 76;
			}
			else if (String.Compare(m_Code, "m", false) == 0)
			{
				result = 77;
			}
			else if (String.Compare(m_Code, "n", false) == 0)
			{
				result = 78;
			}
			else if (String.Compare(m_Code, "o", false) == 0)
			{
				result = 79;
			}
			else if (String.Compare(m_Code, "p", false) == 0)
			{
				result = 80;
			}
			else if (String.Compare(m_Code, "q", false) == 0)
			{
				result = 81;
			}
			else if (String.Compare(m_Code, "r", false) == 0)
			{
				result = 82;
			}
			else if (String.Compare(m_Code, "s", false) == 0)
			{
				result = 83;
			}
			else if (String.Compare(m_Code, "t", false) == 0)
			{
				result = 84;
			}
			else if (String.Compare(m_Code, "u", false) == 0)
			{
				result = 85;
			}
			else if (String.Compare(m_Code, "v", false) == 0)
			{
				result = 86;
			}
			else if (String.Compare(m_Code, "w", false) == 0)
			{
				result = 87;
			}
			else if (String.Compare(m_Code, "x", false) == 0)
			{
				result = 88;
			}
			else if (String.Compare(m_Code, "y", false) == 0)
			{
				result = 89;
			}
			else if (String.Compare(m_Code, "z", false) == 0)
			{
				result = 90;
			}
			else if (String.Compare(m_Code, "{", false) == 0)
			{
				result = 91;
			}
			else if (String.Compare(m_Code, "|", false) == 0)
			{
				result = 92;
			}
			else if (String.Compare(m_Code, "}", false) == 0)
			{
				result = 93;
			}
			else if (String.Compare(m_Code, "~", false) == 0)
			{
				result = 94;
			}
			return result;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000FB1C8 File Offset: 0x000F93C8
		public string Encoded_Value
		{
			get
			{
				return this.GenerateCodingString(this.Raw_Data);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000FB1E4 File Offset: 0x000F93E4
		public Code128New(string input)
		{
			this.START_A = "11010000100";
			this.START_B = "11010010000";
			this.START_C = "11010011100";
			this.MySTOP = "1100011101011";
			this.SWITCH_B_TO_C = "10111011110";
			this.SWITCH_C_TO_B = "10111101110";
			this.mCurrCode = string.Empty;
			this.CodePaterm = new string[]
			{
				"11011001100",
				"11001101100",
				"11001100110",
				"10010011000",
				"10010001100",
				"10001001100",
				"10011001000",
				"10011000100",
				"10001100100",
				"11001001000",
				"11001000100",
				"11000100100",
				"10110011100",
				"10011011100",
				"10011001110",
				"10111001100",
				"10011101100",
				"10011100110",
				"11001110010",
				"11001011100",
				"11001001110",
				"11011100100",
				"11001110100",
				"11101101110",
				"11101001100",
				"11100101100",
				"11100100110",
				"11101100100",
				"11100110100",
				"11100110010",
				"11011011000",
				"11011000110",
				"11000110110",
				"10100011000",
				"10001011000",
				"10001000110",
				"10110001000",
				"10001101000",
				"10001100010",
				"11010001000",
				"11000101000",
				"11000100010",
				"10110111000",
				"10110001110",
				"10001101110",
				"10111011000",
				"10111000110",
				"10001110110",
				"11101110110",
				"11010001110",
				"11000101110",
				"11011101000",
				"11011100010",
				"11011101110",
				"11101011000",
				"11101000110",
				"11100010110",
				"11101101000",
				"11101100010",
				"11100011010",
				"11101111010",
				"11001000010",
				"11110001010",
				"10100110000",
				"10100001100",
				"10010110000",
				"10010000110",
				"10000101100",
				"10000100110",
				"10110010000",
				"10110000100",
				"10011010000",
				"10011000010",
				"10000110100",
				"10000110010",
				"11000010010",
				"11001010000",
				"11110111010",
				"11000010100",
				"10001111010",
				"10100111100",
				"10010111100",
				"10010011110",
				"10111100100",
				"10011110100",
				"10011110010",
				"11110100100",
				"11110010100",
				"11110010010",
				"11011011110",
				"11011110110",
				"11110110110",
				"10101111000",
				"10100011110",
				"10001011110",
				"10111101000",
				"10111100010",
				"11110101000",
				"11110100010",
				"10111011110",
				"10111101110",
				"11101011110",
				"11110101110",
				"11010000100",
				"11010010000",
				"11010011100",
				"1100011101011"
			};
			this.Raw_Data = input;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x000FB614 File Offset: 0x000F9814
		private string GenerateCodingString(string strCode)
		{
			string text = strCode;
			string text2 = string.Empty;
			int num = 1;
			StringBuilder stringBuilder = new StringBuilder();
			long num2;
			if (Code128New.GetNumberStringLen(text) > 3)
			{
				this.mCurrCode = this.START_C;
				num2 = 105L;
			}
			else
			{
				this.mCurrCode = this.START_B;
				num2 = 104L;
			}
			stringBuilder.Append(this.mCurrCode);
			checked
			{
				while (String.Compare(text, string.Empty, false) != 0)
				{
					int numberStringLen = Code128New.GetNumberStringLen(text);
					if (numberStringLen < 2)
					{
						if (String.Compare(this.mCurrCode, this.START_B, false) != 0 & String.Compare(this.mCurrCode, this.SWITCH_C_TO_B, false) != 0)
						{
							stringBuilder.Append(this.SWITCH_C_TO_B);
							this.mCurrCode = this.SWITCH_C_TO_B;
							num2 += unchecked((long)(checked(num * 100)));
							num++;
						}
					}
					else if (numberStringLen > 3 && (String.Compare(this.mCurrCode, this.START_C, false) != 0 & String.Compare(this.mCurrCode, this.SWITCH_B_TO_C, false) != 0))
					{
						stringBuilder.Append(this.SWITCH_B_TO_C);
						this.mCurrCode = this.SWITCH_B_TO_C;
						num2 += unchecked((long)(checked(num * 99)));
						num++;
					}
					int num3;
					if (String.Compare(this.mCurrCode, this.START_B, false) == 0 | String.Compare(this.mCurrCode, this.SWITCH_C_TO_B, false) == 0)
					{
						text2 = text.Substring(0, 1);
						text = text.Substring(1);
						num3 = Code128New.GetCodeValue(text2);
						stringBuilder.Append(this.CodePaterm[num3]);
					}
					else
					{
						text2 = text.Substring(0, 2);
						text = text.Substring(2);
						num3 = Convert.ToInt32(text2);
						stringBuilder.Append(this.CodePaterm[num3]);
					}
					num2 += unchecked((long)(checked(num * num3)));
					num++;
				}
				long num4 = num2 % 103L;
				stringBuilder.Append(this.CodePaterm[(int)num4]);
				stringBuilder.Append(this.MySTOP);
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000FB84C File Offset: 0x000F9A4C
		private static int GetNumberStringLen(string strCode)
		{
			int num = 0;
			checked
			{
				int num2 = strCode.Length - 1;
				int num3 = num;
				while (num3 <= num2 && char.IsNumber(strCode, num3))
				{
					num3++;
				}
				return num3;
			}
		}

		// Token: 0x04001069 RID: 4201
		private string START_A;

		// Token: 0x0400106A RID: 4202
		private string START_B;

		// Token: 0x0400106B RID: 4203
		private string START_C;

		// Token: 0x0400106C RID: 4204
		private string MySTOP;

		// Token: 0x0400106D RID: 4205
		private string SWITCH_B_TO_C;

		// Token: 0x0400106E RID: 4206
		private string SWITCH_C_TO_B;

		// Token: 0x0400106F RID: 4207
		private string mCurrCode;

		// Token: 0x04001070 RID: 4208
		private string Raw_Data;

		// Token: 0x04001071 RID: 4209
		private string[] CodePaterm;
	}
}
