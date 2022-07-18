using System;
using System.Collections;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000163 RID: 355
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class EAN13 : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E72 RID: 7794 RVA: 0x000FC808 File Offset: 0x000FAA08
		public EAN13(string input)
		{
			this.EAN_CodeA = new string[]
			{
				"0001101",
				"0011001",
				"0010011",
				"0111101",
				"0100011",
				"0110001",
				"0101111",
				"0111011",
				"0110111",
				"0001011"
			};
			this.EAN_CodeB = new string[]
			{
				"0100111",
				"0110011",
				"0011011",
				"0100001",
				"0011101",
				"0111001",
				"0000101",
				"0010001",
				"0001001",
				"0010111"
			};
			this.EAN_CodeC = new string[]
			{
				"1110010",
				"1100110",
				"1101100",
				"1000010",
				"1011100",
				"1001110",
				"1010000",
				"1000100",
				"1001000",
				"1110100"
			};
			this.EAN_Pattern = new string[]
			{
				"aaaaaa",
				"aababb",
				"aabbab",
				"aabbba",
				"abaabb",
				"abbaab",
				"abbbaa",
				"ababab",
				"ababba",
				"abbaba"
			};
			this.CountryCodes = new Hashtable();
			this._Country_Assigning_Manufacturer_Code = "N/A";
			this.Raw_Data = input;
			this.CheckDigit();
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000FC9C0 File Offset: 0x000FABC0
		private string Encode_EAN13()
		{
			if (this.Raw_Data.Length < 12 | this.Raw_Data.Length > 13)
			{
				throw new Exception("EEAN13-1: 数字长度不正确，必须是12位或13位长");
			}
			if (!barmodule.CheckNumericOnly(this.Raw_Data))
			{
				throw new Exception("EEAN13-2: 只允许有数字");
			}
			string text = this.EAN_Pattern[int.Parse(this.Raw_Data[0].ToString())];
			string text2 = "101";
			checked
			{
				for (int i = 0; i < 6; i++)
				{
					if (String.Compare(Convert.ToString(text[i]), "a", false) == 0)
					{
						text2 += this.EAN_CodeA[int.Parse(this.Raw_Data[i + 1].ToString())];
					}
					if (String.Compare(Convert.ToString(text[i]), "b", false) == 0)
					{
						text2 += this.EAN_CodeB[int.Parse(this.Raw_Data[i + 1].ToString())];
					}
				}
				text2 += "01010";
				for (int i = 1; i <= 5; i++)
				{
					text2 += this.EAN_CodeC[int.Parse(this.Raw_Data[i + 6].ToString())];
				}
				int num = int.Parse(this.Raw_Data[this.Raw_Data.Length - 1].ToString());
				text2 += this.EAN_CodeC[num];
				text2 += "101";
				this.init_CountryCodes();
				this._Country_Assigning_Manufacturer_Code = "N/A";
				string key = this.Raw_Data.Substring(0, 2);
				string key2 = this.Raw_Data.Substring(0, 3);
				try
				{
					this._Country_Assigning_Manufacturer_Code = this.CountryCodes[key2].ToString();
				}
				catch (Exception ex)
				{
					try
					{
						this._Country_Assigning_Manufacturer_Code = this.CountryCodes[key].ToString();
					}
					catch (Exception ex2)
					{
						throw new Exception("EEAN13-3: Country assigning manufacturer code not found.");
					}
				}
				finally
				{
					this.CountryCodes.Clear();
				}
				return text2;
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000FCC1C File Offset: 0x000FAE1C
		private void init_CountryCodes()
		{
			this.CountryCodes.Clear();
			this.CountryCodes.Add("00", "US / CANADA");
			this.CountryCodes.Add("01", "US / CANADA");
			this.CountryCodes.Add("02", "US / CANADA");
			this.CountryCodes.Add("03", "US / CANADA");
			this.CountryCodes.Add("04", "US / CANADA");
			this.CountryCodes.Add("05", "US / CANADA");
			this.CountryCodes.Add("06", "US / CANADA");
			this.CountryCodes.Add("07", "US / CANADA");
			this.CountryCodes.Add("08", "US / CANADA");
			this.CountryCodes.Add("09", "US / CANADA");
			this.CountryCodes.Add("10", "US / CANADA");
			this.CountryCodes.Add("11", "US / CANADA");
			this.CountryCodes.Add("12", "US / CANADA");
			this.CountryCodes.Add("13", "US / CANADA");
			this.CountryCodes.Add("20", "IN STORE");
			this.CountryCodes.Add("21", "IN STORE");
			this.CountryCodes.Add("22", "IN STORE");
			this.CountryCodes.Add("23", "IN STORE");
			this.CountryCodes.Add("24", "IN STORE");
			this.CountryCodes.Add("25", "IN STORE");
			this.CountryCodes.Add("26", "IN STORE");
			this.CountryCodes.Add("27", "IN STORE");
			this.CountryCodes.Add("28", "IN STORE");
			this.CountryCodes.Add("29", "IN STORE");
			this.CountryCodes.Add("30", "FRANCE");
			this.CountryCodes.Add("31", "FRANCE");
			this.CountryCodes.Add("32", "FRANCE");
			this.CountryCodes.Add("33", "FRANCE");
			this.CountryCodes.Add("34", "FRANCE");
			this.CountryCodes.Add("35", "FRANCE");
			this.CountryCodes.Add("36", "FRANCE");
			this.CountryCodes.Add("37", "FRANCE");
			this.CountryCodes.Add("40", "GERMANY");
			this.CountryCodes.Add("41", "GERMANY");
			this.CountryCodes.Add("42", "GERMANY");
			this.CountryCodes.Add("43", "GERMANY");
			this.CountryCodes.Add("44", "GERMANY");
			this.CountryCodes.Add("45", "JAPAN");
			this.CountryCodes.Add("46", "RUSSIAN FEDERATION");
			this.CountryCodes.Add("49", "JAPAN (JAN-13)");
			this.CountryCodes.Add("50", "UNITED KINGDOM");
			this.CountryCodes.Add("54", "BELGIUM / LUXEMBOURG");
			this.CountryCodes.Add("57", "DENMARK");
			this.CountryCodes.Add("64", "FINLAND");
			this.CountryCodes.Add("70", "NORWAY");
			this.CountryCodes.Add("73", "SWEDEN");
			this.CountryCodes.Add("76", "SWITZERLAND");
			this.CountryCodes.Add("80", "ITALY");
			this.CountryCodes.Add("81", "ITALY");
			this.CountryCodes.Add("82", "ITALY");
			this.CountryCodes.Add("83", "ITALY");
			this.CountryCodes.Add("84", "SPAIN");
			this.CountryCodes.Add("87", "NETHERLANDS");
			this.CountryCodes.Add("90", "AUSTRIA");
			this.CountryCodes.Add("91", "AUSTRIA");
			this.CountryCodes.Add("93", "AUSTRALIA");
			this.CountryCodes.Add("94", "NEW ZEALAND");
			this.CountryCodes.Add("99", "COUPONS");
			this.CountryCodes.Add("380", "BULGARIA");
			this.CountryCodes.Add("383", "SLOVENIJA");
			this.CountryCodes.Add("385", "CROATIA");
			this.CountryCodes.Add("387", "BOSNIA-HERZEGOVINA");
			this.CountryCodes.Add("460", "RUSSIA");
			this.CountryCodes.Add("461", "RUSSIA");
			this.CountryCodes.Add("462", "RUSSIA");
			this.CountryCodes.Add("463", "RUSSIA");
			this.CountryCodes.Add("464", "RUSSIA");
			this.CountryCodes.Add("465", "RUSSIA");
			this.CountryCodes.Add("466", "RUSSIA");
			this.CountryCodes.Add("467", "RUSSIA");
			this.CountryCodes.Add("468", "RUSSIA");
			this.CountryCodes.Add("469", "RUSSIA");
			this.CountryCodes.Add("471", "TAIWAN");
			this.CountryCodes.Add("474", "ESTONIA");
			this.CountryCodes.Add("475", "LATVIA");
			this.CountryCodes.Add("477", "LITHUANIA");
			this.CountryCodes.Add("479", "SRI LANKA");
			this.CountryCodes.Add("480", "PHILIPPINES");
			this.CountryCodes.Add("482", "UKRAINE");
			this.CountryCodes.Add("484", "MOLDOVA");
			this.CountryCodes.Add("485", "ARMENIA");
			this.CountryCodes.Add("486", "GEORGIA");
			this.CountryCodes.Add("487", "KAZAKHSTAN");
			this.CountryCodes.Add("489", "HONG KONG");
			this.CountryCodes.Add("520", "GREECE");
			this.CountryCodes.Add("528", "LEBANON");
			this.CountryCodes.Add("529", "CYPRUS");
			this.CountryCodes.Add("531", "MACEDONIA");
			this.CountryCodes.Add("535", "MALTA");
			this.CountryCodes.Add("539", "IRELAND");
			this.CountryCodes.Add("560", "PORTUGAL");
			this.CountryCodes.Add("569", "ICELAND");
			this.CountryCodes.Add("590", "POLAND");
			this.CountryCodes.Add("594", "ROMANIA");
			this.CountryCodes.Add("599", "HUNGARY");
			this.CountryCodes.Add("600", "SOUTH AFRICA");
			this.CountryCodes.Add("601", "SOUTH AFRICA");
			this.CountryCodes.Add("609", "MAURITIUS");
			this.CountryCodes.Add("611", "MOROCCO");
			this.CountryCodes.Add("613", "ALGERIA");
			this.CountryCodes.Add("619", "TUNISIA");
			this.CountryCodes.Add("622", "EGYPT");
			this.CountryCodes.Add("625", "JORDAN");
			this.CountryCodes.Add("626", "IRAN");
			this.CountryCodes.Add("627", "KUWAIT");
			this.CountryCodes.Add("628", "SAUDI ARABIA");
			this.CountryCodes.Add("629", "EMIRATES");
			this.CountryCodes.Add("690", "CHINA");
			this.CountryCodes.Add("691", "CHINA");
			this.CountryCodes.Add("692", "CHINA");
			this.CountryCodes.Add("693", "CHINA");
			this.CountryCodes.Add("694", "CHINA");
			this.CountryCodes.Add("695", "CHINA");
			this.CountryCodes.Add("729", "ISRAEL");
			this.CountryCodes.Add("740", "GUATEMALA");
			this.CountryCodes.Add("741", "EL SALVADOR");
			this.CountryCodes.Add("742", "HONDURAS");
			this.CountryCodes.Add("743", "NICARAGUA");
			this.CountryCodes.Add("744", "COSTA RICA");
			this.CountryCodes.Add("746", "DOMINICAN REPUBLIC");
			this.CountryCodes.Add("750", "MEXICO");
			this.CountryCodes.Add("759", "VENEZUELA");
			this.CountryCodes.Add("770", "COLOMBIA");
			this.CountryCodes.Add("773", "URUGUAY");
			this.CountryCodes.Add("775", "PERU");
			this.CountryCodes.Add("777", "BOLIVIA");
			this.CountryCodes.Add("779", "ARGENTINA");
			this.CountryCodes.Add("780", "CHILE");
			this.CountryCodes.Add("784", "PARAGUAY");
			this.CountryCodes.Add("785", "PERU");
			this.CountryCodes.Add("786", "ECUADOR");
			this.CountryCodes.Add("789", "BRAZIL");
			this.CountryCodes.Add("850", "CUBA");
			this.CountryCodes.Add("858", "SLOVAKIA");
			this.CountryCodes.Add("859", "CZECH REPUBLIC");
			this.CountryCodes.Add("860", "YUGLOSLAVIA");
			this.CountryCodes.Add("867", "NORTH KOREA");
			this.CountryCodes.Add("869", "TURKEY");
			this.CountryCodes.Add("880", "SOUTH KOREA");
			this.CountryCodes.Add("885", "THAILAND");
			this.CountryCodes.Add("888", "SINGAPORE");
			this.CountryCodes.Add("890", "INDIA");
			this.CountryCodes.Add("893", "VIETNAM");
			this.CountryCodes.Add("899", "INDONESIA");
			this.CountryCodes.Add("955", "MALAYSIA");
			this.CountryCodes.Add("958", "MACAU");
			this.CountryCodes.Add("977", "INTERNATIONAL STANDARD SERIAL NUMBER FOR PERIODICALS (ISSN)");
			this.CountryCodes.Add("978", "INTERNATIONAL STANDARD BOOK NUMBERING (ISBN)");
			this.CountryCodes.Add("979", "INTERNATIONAL STANDARD MUSIC NUMBER (ISMN)");
			this.CountryCodes.Add("980", "REFUND RECEIPTS");
			this.CountryCodes.Add("981", "COMMON CURRENCY COUPONS");
			this.CountryCodes.Add("982", "COMMON CURRENCY COUPONS");
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000FD8AC File Offset: 0x000FBAAC
		private void CheckDigit()
		{
			checked
			{
				if (this.Raw_Data.Length == 12)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					do
					{
						num2 += int.Parse(this.Raw_Data.Substring(num3, 1));
						num3 += 2;
					}
					while (num3 <= 10);
					int num4 = 1;
					do
					{
						num += int.Parse(this.Raw_Data.Substring(num4, 1)) * 3;
						num4 += 2;
					}
					while (num4 <= 11);
					int num5 = num + num2;
					int num6 = num5 % 10;
					num6 = 10 - num6;
					if (num6 == 10)
					{
						num6 = 0;
					}
					this.Raw_Data += num6.ToString();
				}
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x000FD948 File Offset: 0x000FBB48
		public string Encoded_Value
		{
			get
			{
				return this.Encode_EAN13();
			}
		}

		// Token: 0x04001076 RID: 4214
		private string[] EAN_CodeA;

		// Token: 0x04001077 RID: 4215
		private string[] EAN_CodeB;

		// Token: 0x04001078 RID: 4216
		private string[] EAN_CodeC;

		// Token: 0x04001079 RID: 4217
		private string[] EAN_Pattern;

		// Token: 0x0400107A RID: 4218
		private Hashtable CountryCodes;

		// Token: 0x0400107B RID: 4219
		private string _Country_Assigning_Manufacturer_Code;
	}
}
