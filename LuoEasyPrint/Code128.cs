﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200015E RID: 350
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Code128 : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x000F831C File Offset: 0x000F651C
		public Code128(string input)
		{
			this.C128_Code = new DataTable("C128");
			this._FormattedData = new List<string>();
			this._EncodedData = new List<string>();
			this.StartCharacter = null;
			this.mytype = Code128.Code128Type.A;
			this.Raw_Data = input;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000F836C File Offset: 0x000F656C
		public Code128(string input, Code128.Code128Type thetype)
		{
			this.C128_Code = new DataTable("C128");
			this._FormattedData = new List<string>();
			this._EncodedData = new List<string>();
			this.StartCharacter = null;
			this.mytype = Code128.Code128Type.A;
			this.Raw_Data = input;
			this.mytype = thetype;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000F83C4 File Offset: 0x000F65C4
		private string Encode_Code128()
		{
			this.init_Code128();
			return this.GetEncoding();
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000F83E0 File Offset: 0x000F65E0
		private void init_Code128()
		{
			this.C128_Code.CaseSensitive = true;
			this.C128_Code.Columns.Add("Value", typeof(string));
			this.C128_Code.Columns.Add("A", typeof(string));
			this.C128_Code.Columns.Add("B", typeof(string));
			this.C128_Code.Columns.Add("C", typeof(string));
			this.C128_Code.Columns.Add("Encoding", typeof(string));
			this.C128_Code.Rows.Add(new object[]
			{
				"0",
				" ",
				" ",
				"00",
				"11011001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"1",
				"!",
				"!",
				"01",
				"11001101100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"2",
				"\"",
				"\"",
				"02",
				"11001100110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"3",
				"#",
				"#",
				"03",
				"10010011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"4",
				"$",
				"$",
				"04",
				"10010001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"5",
				"%",
				"%",
				"05",
				"10001001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"6",
				"&",
				"&",
				"06",
				"10011001000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"7",
				"'",
				"'",
				"07",
				"10011000100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"8",
				"(",
				"(",
				"08",
				"10001100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"9",
				")",
				")",
				"09",
				"11001001000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"10",
				"*",
				"*",
				"10",
				"11001000100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"11",
				"+",
				"+",
				"11",
				"11000100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"12",
				",",
				",",
				"12",
				"10110011100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"13",
				"-",
				"-",
				"13",
				"10011011100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"14",
				".",
				".",
				"14",
				"10011001110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"15",
				"/",
				"/",
				"15",
				"10111001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"16",
				"0",
				"0",
				"16",
				"10011101100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"17",
				"1",
				"1",
				"17",
				"10011100110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"18",
				"2",
				"2",
				"18",
				"11001110010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"19",
				"3",
				"3",
				"19",
				"11001011100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"20",
				"4",
				"4",
				"20",
				"11001001110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"21",
				"5",
				"5",
				"21",
				"11011100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"22",
				"6",
				"6",
				"22",
				"11001110100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"23",
				"7",
				"7",
				"23",
				"11101101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"24",
				"8",
				"8",
				"24",
				"11101001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"25",
				"9",
				"9",
				"25",
				"11100101100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"26",
				":",
				":",
				"26",
				"11100100110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"27",
				";",
				";",
				"27",
				"11101100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"28",
				"<",
				"<",
				"28",
				"11100110100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"29",
				"=",
				"=",
				"29",
				"11100110010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"30",
				">",
				">",
				"30",
				"11011011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"31",
				"?",
				"?",
				"31",
				"11011000110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"32",
				"@",
				"@",
				"32",
				"11000110110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"33",
				"A",
				"A",
				"33",
				"10100011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"34",
				"B",
				"B",
				"34",
				"10001011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"35",
				"C",
				"C",
				"35",
				"10001000110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"36",
				"D",
				"D",
				"36",
				"10110001000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"37",
				"E",
				"E",
				"37",
				"10001101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"38",
				"F",
				"F",
				"38",
				"10001100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"39",
				"G",
				"G",
				"39",
				"11010001000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"40",
				"H",
				"H",
				"40",
				"11000101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"41",
				"I",
				"I",
				"41",
				"11000100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"42",
				"J",
				"J",
				"42",
				"10110111000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"43",
				"K",
				"K",
				"43",
				"10110001110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"44",
				"L",
				"L",
				"44",
				"10001101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"45",
				"M",
				"M",
				"45",
				"10111011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"46",
				"N",
				"N",
				"46",
				"10111000110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"47",
				"O",
				"O",
				"47",
				"10001110110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"48",
				"P",
				"P",
				"48",
				"11101110110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"49",
				"Q",
				"Q",
				"49",
				"11010001110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"50",
				"R",
				"R",
				"50",
				"11000101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"51",
				"S",
				"S",
				"51",
				"11011101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"52",
				"T",
				"T",
				"52",
				"11011100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"53",
				"U",
				"U",
				"53",
				"11011101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"54",
				"V",
				"V",
				"54",
				"11101011000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"55",
				"W",
				"W",
				"55",
				"11101000110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"56",
				"X",
				"X",
				"56",
				"11100010110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"57",
				"Y",
				"Y",
				"57",
				"11101101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"58",
				"Z",
				"Z",
				"58",
				"11101100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"59",
				"[",
				"[",
				"59",
				"11100011010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"60",
				"\\",
				"\\",
				"60",
				"11101111010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"61",
				"]",
				"]",
				"61",
				"11001000010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"62",
				"^",
				"^",
				"62",
				"11110001010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"63",
				"_",
				"_",
				"63",
				"10100110000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"64",
				"NUL",
				"`",
				"64",
				"10100001100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"65",
				"SOH",
				"a",
				"65",
				"10010110000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"66",
				"STX",
				"b",
				"66",
				"10010000110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"67",
				"ETX",
				"c",
				"67",
				"10000101100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"68",
				"EOT",
				"d",
				"68",
				"10000100110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"69",
				"ENQ",
				"e",
				"69",
				"10110010000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"70",
				"ACK",
				"f",
				"70",
				"10110000100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"71",
				"BEL",
				"g",
				"71",
				"10011010000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"72",
				"BS",
				"h",
				"72",
				"10011000010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"73",
				"HT",
				"i",
				"73",
				"10000110100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"74",
				"LF",
				"j",
				"74",
				"10000110010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"75",
				"VT",
				"k",
				"75",
				"11000010010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"76",
				"FF",
				"l",
				"76",
				"11001010000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"77",
				"CR",
				"m",
				"77",
				"11110111010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"78",
				"SO",
				"n",
				"78",
				"11000010100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"79",
				"SI",
				"o",
				"79",
				"10001111010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"80",
				"DLE",
				"p",
				"80",
				"10100111100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"81",
				"DC1",
				"q",
				"81",
				"10010111100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"82",
				"DC2",
				"r",
				"82",
				"10010011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"83",
				"DC3",
				"s",
				"83",
				"10111100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"84",
				"DC4",
				"t",
				"84",
				"10011110100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"85",
				"NAK",
				"u",
				"85",
				"10011110010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"86",
				"SYN",
				"v",
				"86",
				"11110100100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"87",
				"ETB",
				"w",
				"87",
				"11110010100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"88",
				"CAN",
				"x",
				"88",
				"11110010010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"89",
				"EM",
				"y",
				"89",
				"11011011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"90",
				"SUB",
				"z",
				"90",
				"11011110110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"91",
				"ESC",
				"{",
				"91",
				"11110110110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"92",
				"FS",
				"|",
				"92",
				"10101111000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"93",
				"GS",
				"}",
				"93",
				"10100011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"94",
				"RS",
				"~",
				"94",
				"10001011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"95",
				"US",
				"DEL",
				"95",
				"10111101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"96",
				"FNC3",
				"FNC3",
				"96",
				"10111100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"97",
				"FNC2",
				"FNC2",
				"97",
				"11110101000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"98",
				"SHIFT",
				"SHIFT",
				"98",
				"11110100010"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"99",
				"CODEC",
				"CODEC",
				"99",
				"10111011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"100",
				"CODEB",
				"FNC4",
				"CODEB",
				"10111101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"101",
				"FNC4",
				"CODEA",
				"CODEA",
				"11101011110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"102",
				"FNC1",
				"FNC1",
				"FNC1",
				"11110101110"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"103",
				"START_A",
				"START_A",
				"START_A",
				"11010000100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"104",
				"START_B",
				"START_B",
				"START_B",
				"11010010000"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"105",
				"START_C",
				"START_C",
				"START_C",
				"11010011100"
			});
			this.C128_Code.Rows.Add(new object[]
			{
				"",
				"STOP",
				"STOP",
				"STOP",
				"1100011101011"
			});
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000F9FC4 File Offset: 0x000F81C4
		private List<DataRow> FindStartorCodeCharacter(string s, ref int col)
		{
			List<DataRow> list = new List<DataRow>();
			if (s.Length > 1 && char.IsNumber(s[0]) && char.IsNumber(s[1]))
			{
				if (this.StartCharacter == null)
				{
					this.StartCharacter = this.C128_Code.Select("A = 'START_C'")[0];
					list.Add(this.StartCharacter);
				}
				else
				{
					list.Add(this.C128_Code.Select("A = 'CODE_C'")[0]);
				}
				col = 1;
			}
			else
			{
				bool flag = false;
				bool flag2 = false;
				try
				{
					foreach (object obj in this.C128_Code.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						try
						{
							if (!flag & String.Compare(s, dataRow["A"].ToString(), false) == 0)
							{
								flag = true;
								col = 2;
								if (this.StartCharacter == null)
								{
									this.StartCharacter = this.C128_Code.Select("A = 'START_A'")[0];
									list.Add(this.StartCharacter);
								}
								else
								{
									list.Add(this.C128_Code.Select("B = 'CODE_A'")[0]);
								}
							}
							else if (!flag2 & String.Compare(s, dataRow["B"].ToString(), false) == 0)
							{
								flag2 = true;
								col = 1;
								if (this.StartCharacter == null)
								{
									this.StartCharacter = this.C128_Code.Select("A = 'START_B'")[0];
									list.Add(this.StartCharacter);
								}
								else
								{
									list.Add(this.C128_Code.Select("A = 'CODE_B'")[0]);
								}
							}
							else if (flag && flag2)
							{
								break;
							}
						}
						catch (Exception ex)
						{
							throw new Exception("EC128-1: " + ex.Message);
						}
					}
				}
				finally
				{
					
				}
				if (list.Count <= 0)
				{
					throw new Exception("EC128-2: 无法确定开始字符");
				}
			}
			return list;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000FA1EC File Offset: 0x000F83EC
		private string CalculateCheckDigit()
		{
			uint num = 0U;
			string left = this._FormattedData[0];
			checked
			{
				if (String.Compare(left, "START_C", false) == 0)
				{
					uint num2 = 0U;
					uint num3 = (uint)(this._FormattedData.Count - 1);
					for (uint num4 = num2; num4 <= num3; num4 += 1U)
					{
						string str = this._FormattedData[(int)num4].Replace("'", "''");
						DataRow[] array = this.C128_Code.Select("A = '" + str + "'");
						if (array.Length <= 0)
						{
							array = this.C128_Code.Select("B = '" + str + "'");
						}
						if (array.Length <= 0)
						{
							array = this.C128_Code.Select("C = '" + str + "'");
						}
						uint num5 = uint.Parse(array[0]["Value"].ToString());
						uint num6 = num5 * Convert.ToUInt32(Interaction.IIf(unchecked((ulong)num4) == 0UL, 1, num4));
						num += num6;
					}
				}
				else if (String.Compare(left, "START_A", false) == 0 || String.Compare(left, "START_B", false) == 0)
				{
					if (String.Compare(this._FormattedData[0], "START_A", false) == 0)
					{
						num = 103U;
					}
					else
					{
						num = 104U;
					}
					int num7 = 0;
					int num8 = this.RawData.Length - 1;
					for (int i = num7; i <= num8; i++)
					{
						string text = Strings.Mid(this.RawData, i + 1, 1);
						text = text.Replace("'", "''");
						DataRow[] array2 = this.C128_Code.Select("A = '" + text + "'");
						if (array2.Length <= 0)
						{
							array2 = this.C128_Code.Select("B = '" + text + "'");
						}
						if (array2.Length <= 0)
						{
							array2 = this.C128_Code.Select("C = '" + text + "'");
						}
						uint num9 = uint.Parse(array2[0]["Value"].ToString());
						uint num10 = num9 * (uint)(i + 1);
						num += num10;
					}
				}
				uint num11 = (uint)(unchecked((ulong)num) % 103UL);
				DataRow[] array3 = this.C128_Code.Select("Value = '" + num11.ToString() + "'");
				return array3[0]["Encoding"].ToString();
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000FA480 File Offset: 0x000F8680
		private void BreakUpDataForEncoding()
		{
			string text = "";
			string text2 = this.Raw_Data;
			if (this.mytype == Code128.Code128Type.C & this.Raw_Data.Length % 2 > 0)
			{
				text2 = "0" + this.Raw_Data;
			}
			string text3 = text2;
			int i = 0;
			int length = text3.Length;
			checked
			{
				while (i < length)
				{
					char c = text3[i];
					if (char.IsNumber(c))
					{
						if (String.Compare(text, "", false) == 0)
						{
							text += Convert.ToString(c);
						}
						else
						{
							text += Convert.ToString(c);
							this._FormattedData.Add(text);
							text = "";
						}
					}
					else
					{
						if (String.Compare(text, "", false) != 0)
						{
							this._FormattedData.Add(text);
							text = "";
						}
						this._FormattedData.Add(c.ToString());
					}
					i++;
				}
				if (String.Compare(text, "", false) != 0)
				{
					this._FormattedData.Add(text);
				}
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000FA58C File Offset: 0x000F878C
		private void InsertStartandCodeCharacters()
		{
			switch (this.mytype)
			{
			case Code128.Code128Type.A:
				this._FormattedData.Insert(0, "START_A");
				break;
			case Code128.Code128Type.B:
				this._FormattedData.Insert(0, "START_B");
				break;
			case Code128.Code128Type.C:
				this._FormattedData.Insert(0, "START_C");
				break;
			default:
				throw new Exception("EC128-4: 未知的开始字符");
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000FA5F4 File Offset: 0x000F87F4
		private string GetEncoding()
		{
			this.BreakUpDataForEncoding();
			this.InsertStartandCodeCharacters();
			this.CalculateCheckDigit();
			string text = "";
			string left = this._FormattedData[0];
			checked
			{
				if (String.Compare(left, "START_C", false) == 0)
				{
					try
					{
						foreach (string text2 in this._FormattedData)
						{
							string str = text2.Replace("'", "''");
							DataRow[] array = this.C128_Code.Select("A = '" + str + "'");
							if (array.Length <= 0)
							{
								array = this.C128_Code.Select("B = '" + str + "'");
								if (array.Length <= 0)
								{
									array = this.C128_Code.Select("C = '" + str + "'");
								}
							}
							if (array.Length <= 0)
							{
								throw new Exception("EC128-3: Could not find encoding of a value( " + str + " ) in the formatted data.");
							}
							text += array[0]["Encoding"].ToString();
							this._EncodedData.Add(array[0]["Encoding"].ToString());
						}
					}
					finally
					{
						List<string>.Enumerator enumerator=new List<string>.Enumerator();
						((IDisposable)enumerator).Dispose();
					}
					text += this.CalculateCheckDigit();
					this._EncodedData.Add(this.CalculateCheckDigit());
					text += this.C128_Code.Select("A = 'STOP'")[0]["Encoding"].ToString();
					this._EncodedData.Add(this.C128_Code.Select("A = 'STOP'")[0]["Encoding"].ToString());
				}
				else if (String.Compare(left, "START_A", false) == 0 || String.Compare(left, "START_B", false) == 0)
				{
					text += this.C128_Code.Select("A = '" + this._FormattedData[0] + "'")[0]["Encoding"].ToString();
					this._EncodedData.Add(this.C128_Code.Select("A = '" + this._FormattedData[0] + "'")[0]["Encoding"].ToString());
					string rawData = this.RawData;
					int i = 0;
					int length = rawData.Length;
					while (i < length)
					{
						string text3 = Convert.ToString(rawData[i]);
						string str2 = text3.Replace("'", "''");
						DataRow[] array2 = this.C128_Code.Select("A = '" + str2 + "'");
						if (array2.Length <= 0)
						{
							array2 = this.C128_Code.Select("B = '" + str2 + "'");
							if (array2.Length <= 0)
							{
								array2 = this.C128_Code.Select("C = '" + str2 + "'");
							}
						}
						if (array2.Length <= 0)
						{
							throw new Exception("EC128-3: Could not find encoding of a value( " + str2 + " ) in the formatted data.");
						}
						text += array2[0]["Encoding"].ToString();
						this._EncodedData.Add(array2[0]["Encoding"].ToString());
						i++;
					}
					text += this.CalculateCheckDigit();
					this._EncodedData.Add(this.CalculateCheckDigit());
					text += this.C128_Code.Select("A = 'STOP'")[0]["Encoding"].ToString();
					this._EncodedData.Add(this.C128_Code.Select("A = 'STOP'")[0]["Encoding"].ToString());
				}
				return text;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000FA9E8 File Offset: 0x000F8BE8
		public string Encoded_Value
		{
			get
			{
				return this.Encode_Code128();
			}
		}

		// Token: 0x04001060 RID: 4192
		private DataTable C128_Code;

		// Token: 0x04001061 RID: 4193
		private List<string> _FormattedData;

		// Token: 0x04001062 RID: 4194
		private List<string> _EncodedData;

		// Token: 0x04001063 RID: 4195
		private DataRow StartCharacter;

		// Token: 0x04001064 RID: 4196
		private Code128.Code128Type mytype;

		// Token: 0x0200015F RID: 351
		public enum Code128Type
		{
			// Token: 0x04001066 RID: 4198
			A,
			// Token: 0x04001067 RID: 4199
			B,
			// Token: 0x04001068 RID: 4200
			C
		}
	}
}
