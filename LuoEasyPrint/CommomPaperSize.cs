using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200001A RID: 26
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CommomPaperSize : IDisposable
	{
		// Token: 0x06000566 RID: 1382 RVA: 0x00037834 File Offset: 0x00035A34
		public CommomPaperSize()
		{
			this.fpagerSizestr = new string[170, 3];
			this.fpagerSizestr[0, 0] = "Letter";
			this.fpagerSizestr[0, 1] = "1100";
			this.fpagerSizestr[0, 2] = "850";
			this.fpagerSizestr[1, 0] = "Letter Small";
			this.fpagerSizestr[1, 1] = "1100";
			this.fpagerSizestr[1, 2] = "850";
			this.fpagerSizestr[2, 0] = "Tabloid";
			this.fpagerSizestr[2, 1] = "1700";
			this.fpagerSizestr[2, 2] = "1100";
			this.fpagerSizestr[3, 0] = "Ledger";
			this.fpagerSizestr[3, 1] = "1100";
			this.fpagerSizestr[3, 2] = "1700";
			this.fpagerSizestr[4, 0] = "Legal";
			this.fpagerSizestr[4, 1] = "1400";
			this.fpagerSizestr[4, 2] = "850";
			this.fpagerSizestr[5, 0] = "Statement";
			this.fpagerSizestr[5, 1] = "850";
			this.fpagerSizestr[5, 2] = "550";
			this.fpagerSizestr[6, 0] = "Executive";
			this.fpagerSizestr[6, 1] = "1050";
			this.fpagerSizestr[6, 2] = "725";
			this.fpagerSizestr[7, 0] = "A3";
			this.fpagerSizestr[7, 1] = "1654";
			this.fpagerSizestr[7, 2] = "1169";
			this.fpagerSizestr[8, 0] = "A4";
			this.fpagerSizestr[8, 1] = "1169";
			this.fpagerSizestr[8, 2] = "827";
			this.fpagerSizestr[9, 0] = "A4 Small";
			this.fpagerSizestr[9, 1] = "1169";
			this.fpagerSizestr[9, 2] = "827";
			this.fpagerSizestr[10, 0] = "A5";
			this.fpagerSizestr[10, 1] = "827";
			this.fpagerSizestr[10, 2] = "583";
			this.fpagerSizestr[11, 0] = "B4 (JIS)";
			this.fpagerSizestr[11, 1] = "1433";
			this.fpagerSizestr[11, 2] = "1012";
			this.fpagerSizestr[12, 0] = "B5 (JIS)";
			this.fpagerSizestr[12, 1] = "1012";
			this.fpagerSizestr[12, 2] = "717";
			this.fpagerSizestr[13, 0] = "Folio";
			this.fpagerSizestr[13, 1] = "1300";
			this.fpagerSizestr[13, 2] = "850";
			this.fpagerSizestr[14, 0] = "Quarto";
			this.fpagerSizestr[14, 1] = "1083";
			this.fpagerSizestr[14, 2] = "846";
			this.fpagerSizestr[15, 0] = "10x14";
			this.fpagerSizestr[15, 1] = "1400";
			this.fpagerSizestr[15, 2] = "1000";
			this.fpagerSizestr[16, 0] = "11x17";
			this.fpagerSizestr[16, 1] = "1700";
			this.fpagerSizestr[16, 2] = "1100";
			this.fpagerSizestr[17, 0] = "Note";
			this.fpagerSizestr[17, 1] = "1100";
			this.fpagerSizestr[17, 2] = "850";
			this.fpagerSizestr[18, 0] = "Envelope #9";
			this.fpagerSizestr[18, 1] = "887";
			this.fpagerSizestr[18, 2] = "387";
			this.fpagerSizestr[19, 0] = "Envelope #10";
			this.fpagerSizestr[19, 1] = "950";
			this.fpagerSizestr[19, 2] = "413";
			this.fpagerSizestr[20, 0] = "Envelope #11";
			this.fpagerSizestr[20, 1] = "1037";
			this.fpagerSizestr[20, 2] = "450";
			this.fpagerSizestr[21, 0] = "Envelope #12";
			this.fpagerSizestr[21, 1] = "1100";
			this.fpagerSizestr[21, 2] = "475";
			this.fpagerSizestr[22, 0] = "Envelope #14";
			this.fpagerSizestr[22, 1] = "1150";
			this.fpagerSizestr[22, 2] = "500";
			this.fpagerSizestr[23, 0] = "C size sheet";
			this.fpagerSizestr[23, 1] = "2200";
			this.fpagerSizestr[23, 2] = "1700";
			this.fpagerSizestr[24, 0] = "D size sheet";
			this.fpagerSizestr[24, 1] = "3400";
			this.fpagerSizestr[24, 2] = "2200";
			this.fpagerSizestr[25, 0] = "E size sheet";
			this.fpagerSizestr[25, 1] = "4400";
			this.fpagerSizestr[25, 2] = "3400";
			this.fpagerSizestr[26, 0] = "Envelope DL";
			this.fpagerSizestr[26, 1] = "866";
			this.fpagerSizestr[26, 2] = "433";
			this.fpagerSizestr[27, 0] = "Envelope C5";
			this.fpagerSizestr[27, 1] = "902";
			this.fpagerSizestr[27, 2] = "638";
			this.fpagerSizestr[28, 0] = "Envelope C3";
			this.fpagerSizestr[28, 1] = "1803";
			this.fpagerSizestr[28, 2] = "1276";
			this.fpagerSizestr[29, 0] = "Envelope C4";
			this.fpagerSizestr[29, 1] = "1276";
			this.fpagerSizestr[29, 2] = "902";
			this.fpagerSizestr[30, 0] = "Envelope C6";
			this.fpagerSizestr[30, 1] = "638";
			this.fpagerSizestr[30, 2] = "449";
			this.fpagerSizestr[31, 0] = "Envelope C65";
			this.fpagerSizestr[31, 1] = "902";
			this.fpagerSizestr[31, 2] = "449";
			this.fpagerSizestr[32, 0] = "Envelope B4";
			this.fpagerSizestr[32, 1] = "1390";
			this.fpagerSizestr[32, 2] = "984";
			this.fpagerSizestr[33, 0] = "Envelope B5";
			this.fpagerSizestr[33, 1] = "984";
			this.fpagerSizestr[33, 2] = "693";
			this.fpagerSizestr[34, 0] = "Envelope B6";
			this.fpagerSizestr[34, 1] = "492";
			this.fpagerSizestr[34, 2] = "693";
			this.fpagerSizestr[35, 0] = "Envelope";
			this.fpagerSizestr[35, 1] = "906";
			this.fpagerSizestr[35, 2] = "433";
			this.fpagerSizestr[36, 0] = "Envelope Monarch";
			this.fpagerSizestr[36, 1] = "750";
			this.fpagerSizestr[36, 2] = "387";
			this.fpagerSizestr[37, 0] = "6 3/4 Envelope";
			this.fpagerSizestr[37, 1] = "650";
			this.fpagerSizestr[37, 2] = "363";
			this.fpagerSizestr[38, 0] = "US Std Fanfold";
			this.fpagerSizestr[38, 1] = "1100";
			this.fpagerSizestr[38, 2] = "1487";
			this.fpagerSizestr[39, 0] = "German Std Fanfold";
			this.fpagerSizestr[39, 1] = "1200";
			this.fpagerSizestr[39, 2] = "850";
			this.fpagerSizestr[40, 0] = "German Legal Fanfold";
			this.fpagerSizestr[40, 1] = "1300";
			this.fpagerSizestr[40, 2] = "850";
			this.fpagerSizestr[41, 0] = "B4 (ISO)";
			this.fpagerSizestr[41, 1] = "1390";
			this.fpagerSizestr[41, 2] = "984";
			this.fpagerSizestr[42, 0] = "Japanese Postcard";
			this.fpagerSizestr[42, 1] = "583";
			this.fpagerSizestr[42, 2] = "394";
			this.fpagerSizestr[43, 0] = "9x11";
			this.fpagerSizestr[43, 1] = "1100";
			this.fpagerSizestr[43, 2] = "900";
			this.fpagerSizestr[44, 0] = "10x11";
			this.fpagerSizestr[44, 1] = "1100";
			this.fpagerSizestr[44, 2] = "1000";
			this.fpagerSizestr[45, 0] = "15x11";
			this.fpagerSizestr[45, 1] = "1100";
			this.fpagerSizestr[45, 2] = "1500";
			this.fpagerSizestr[46, 0] = "Envelope Invite";
			this.fpagerSizestr[46, 1] = "866";
			this.fpagerSizestr[46, 2] = "866";
			this.fpagerSizestr[47, 0] = "Reserved48";
			this.fpagerSizestr[47, 1] = "0";
			this.fpagerSizestr[47, 2] = "0";
			this.fpagerSizestr[48, 0] = "Reserved49";
			this.fpagerSizestr[48, 1] = "0";
			this.fpagerSizestr[48, 2] = "0";
			this.fpagerSizestr[49, 0] = "Letter Extra";
			this.fpagerSizestr[49, 1] = "1200";
			this.fpagerSizestr[49, 2] = "950";
			this.fpagerSizestr[50, 0] = "Legal Extra";
			this.fpagerSizestr[50, 1] = "1500";
			this.fpagerSizestr[50, 2] = "950";
			this.fpagerSizestr[51, 0] = "Tabloid Extra";
			this.fpagerSizestr[51, 1] = "1800";
			this.fpagerSizestr[51, 2] = "1200";
			this.fpagerSizestr[52, 0] = "A4 Extra";
			this.fpagerSizestr[52, 1] = "1269";
			this.fpagerSizestr[52, 2] = "927";
			this.fpagerSizestr[53, 0] = "Letter Transverse";
			this.fpagerSizestr[53, 1] = "1100";
			this.fpagerSizestr[53, 2] = "850";
			this.fpagerSizestr[54, 0] = "A4 Transverse";
			this.fpagerSizestr[54, 1] = "1169";
			this.fpagerSizestr[54, 2] = "827";
			this.fpagerSizestr[55, 0] = "Letter Extra Transverse";
			this.fpagerSizestr[55, 1] = "1200";
			this.fpagerSizestr[55, 2] = "950";
			this.fpagerSizestr[56, 0] = "Super A";
			this.fpagerSizestr[56, 1] = "1402";
			this.fpagerSizestr[56, 2] = "894";
			this.fpagerSizestr[57, 0] = "Super B";
			this.fpagerSizestr[57, 1] = "1917";
			this.fpagerSizestr[57, 2] = "1201";
			this.fpagerSizestr[58, 0] = "Letter Plus";
			this.fpagerSizestr[58, 1] = "1269";
			this.fpagerSizestr[58, 2] = "850";
			this.fpagerSizestr[59, 0] = "A4 Plus";
			this.fpagerSizestr[59, 1] = "1299";
			this.fpagerSizestr[59, 2] = "827";
			this.fpagerSizestr[60, 0] = "A5 Transverse";
			this.fpagerSizestr[60, 1] = "827";
			this.fpagerSizestr[60, 2] = "583";
			this.fpagerSizestr[61, 0] = "B5 (JIS) Transverse";
			this.fpagerSizestr[61, 1] = "1012";
			this.fpagerSizestr[61, 2] = "717";
			this.fpagerSizestr[62, 0] = "A3 Extra";
			this.fpagerSizestr[62, 1] = "1752";
			this.fpagerSizestr[62, 2] = "1268";
			this.fpagerSizestr[63, 0] = "A5 Extra";
			this.fpagerSizestr[63, 1] = "925";
			this.fpagerSizestr[63, 2] = "685";
			this.fpagerSizestr[64, 0] = "B5 (ISO) Extra";
			this.fpagerSizestr[64, 1] = "1087";
			this.fpagerSizestr[64, 2] = "791";
			this.fpagerSizestr[65, 0] = "A2";
			this.fpagerSizestr[65, 1] = "2339";
			this.fpagerSizestr[65, 2] = "1654";
			this.fpagerSizestr[66, 0] = "A3 Transverse";
			this.fpagerSizestr[66, 1] = "1654";
			this.fpagerSizestr[66, 2] = "1169";
			this.fpagerSizestr[67, 0] = "A3 Extra Transverse";
			this.fpagerSizestr[67, 1] = "1752";
			this.fpagerSizestr[67, 2] = "1268";
			this.fpagerSizestr[68, 0] = "Japanese Double Postcard";
			this.fpagerSizestr[68, 1] = "583";
			this.fpagerSizestr[68, 2] = "787";
			this.fpagerSizestr[69, 0] = "A6";
			this.fpagerSizestr[69, 1] = "583";
			this.fpagerSizestr[69, 2] = "413";
			this.fpagerSizestr[70, 0] = "Japanese Envelope Kaku #2";
			this.fpagerSizestr[70, 1] = "1307";
			this.fpagerSizestr[70, 2] = "945";
			this.fpagerSizestr[71, 0] = "Japanese Envelope Kaku #3";
			this.fpagerSizestr[71, 1] = "1091";
			this.fpagerSizestr[71, 2] = "850";
			this.fpagerSizestr[72, 0] = "Japanese Envelope Chou #3";
			this.fpagerSizestr[72, 1] = "925";
			this.fpagerSizestr[72, 2] = "472";
			this.fpagerSizestr[73, 0] = "Japanese Envelope Chou #4";
			this.fpagerSizestr[73, 1] = "807";
			this.fpagerSizestr[73, 2] = "354";
			this.fpagerSizestr[74, 0] = "Letter Rotated";
			this.fpagerSizestr[74, 1] = "850";
			this.fpagerSizestr[74, 2] = "1100";
			this.fpagerSizestr[75, 0] = "A3 Rotated";
			this.fpagerSizestr[75, 1] = "1169";
			this.fpagerSizestr[75, 2] = "1654";
			this.fpagerSizestr[76, 0] = "A4 Rotated";
			this.fpagerSizestr[76, 1] = "827";
			this.fpagerSizestr[76, 2] = "1169";
			this.fpagerSizestr[77, 0] = "A5 Rotated";
			this.fpagerSizestr[77, 1] = "583";
			this.fpagerSizestr[77, 2] = "827";
			this.fpagerSizestr[78, 0] = "B4 (JIS) Rotated";
			this.fpagerSizestr[78, 1] = "1012";
			this.fpagerSizestr[78, 2] = "1433";
			this.fpagerSizestr[79, 0] = "B5 (JIS) Rotated";
			this.fpagerSizestr[79, 1] = "717";
			this.fpagerSizestr[79, 2] = "1012";
			this.fpagerSizestr[80, 0] = "Japanese Postcard Rotated";
			this.fpagerSizestr[80, 1] = "394";
			this.fpagerSizestr[80, 2] = "583";
			this.fpagerSizestr[81, 0] = "Double Japan Postcard Rotated";
			this.fpagerSizestr[81, 1] = "787";
			this.fpagerSizestr[81, 2] = "583";
			this.fpagerSizestr[82, 0] = "A6 Rotated";
			this.fpagerSizestr[82, 1] = "413";
			this.fpagerSizestr[82, 2] = "583";
			this.fpagerSizestr[83, 0] = "Japan Envelope Kaku #2 Rotated";
			this.fpagerSizestr[83, 1] = "945";
			this.fpagerSizestr[83, 2] = "1307";
			this.fpagerSizestr[84, 0] = "Japan Envelope Kaku #3 Rotated";
			this.fpagerSizestr[84, 1] = "850";
			this.fpagerSizestr[84, 2] = "1091";
			this.fpagerSizestr[85, 0] = "Japan Envelope Chou #3 Rotated";
			this.fpagerSizestr[85, 1] = "472";
			this.fpagerSizestr[85, 2] = "925";
			this.fpagerSizestr[86, 0] = "Japan Envelope Chou #4 Rotated";
			this.fpagerSizestr[86, 1] = "354";
			this.fpagerSizestr[86, 2] = "807";
			this.fpagerSizestr[87, 0] = "B6 (JIS)";
			this.fpagerSizestr[87, 1] = "717";
			this.fpagerSizestr[87, 2] = "504";
			this.fpagerSizestr[88, 0] = "B6 (JIS) Rotated";
			this.fpagerSizestr[88, 1] = "504";
			this.fpagerSizestr[88, 2] = "717";
			this.fpagerSizestr[89, 0] = "12x11";
			this.fpagerSizestr[89, 1] = "1100";
			this.fpagerSizestr[89, 2] = "1200";
			this.fpagerSizestr[90, 0] = "Japan Envelope You #4";
			this.fpagerSizestr[90, 1] = "925";
			this.fpagerSizestr[90, 2] = "413";
			this.fpagerSizestr[91, 0] = "Japan Envelope You #4 Rotated";
			this.fpagerSizestr[91, 1] = "413";
			this.fpagerSizestr[91, 2] = "925";
			this.fpagerSizestr[92, 0] = "PRC 16K";
			this.fpagerSizestr[92, 1] = "1024";
			this.fpagerSizestr[92, 2] = "740";
			this.fpagerSizestr[93, 0] = "PRC 32K";
			this.fpagerSizestr[93, 1] = "724";
			this.fpagerSizestr[93, 2] = "512";
			this.fpagerSizestr[94, 0] = "PRC 32K(Big)";
			this.fpagerSizestr[94, 1] = "799";
			this.fpagerSizestr[94, 2] = "551";
			this.fpagerSizestr[95, 0] = "PRC Envelope #1";
			this.fpagerSizestr[95, 1] = "650";
			this.fpagerSizestr[95, 2] = "402";
			this.fpagerSizestr[96, 0] = "PRC Envelope #2";
			this.fpagerSizestr[96, 1] = "693";
			this.fpagerSizestr[96, 2] = "402";
			this.fpagerSizestr[97, 0] = "PRC Envelope #3";
			this.fpagerSizestr[97, 1] = "693";
			this.fpagerSizestr[97, 2] = "492";
			this.fpagerSizestr[98, 0] = "PRC Envelope #4";
			this.fpagerSizestr[98, 1] = "819";
			this.fpagerSizestr[98, 2] = "433";
			this.fpagerSizestr[99, 0] = "PRC Envelope #5";
			this.fpagerSizestr[99, 1] = "866";
			this.fpagerSizestr[99, 2] = "433";
			this.fpagerSizestr[100, 0] = "PRC Envelope #6";
			this.fpagerSizestr[100, 1] = "906";
			this.fpagerSizestr[100, 2] = "472";
			this.fpagerSizestr[101, 0] = "PRC Envelope #7";
			this.fpagerSizestr[101, 1] = "906";
			this.fpagerSizestr[101, 2] = "630";
			this.fpagerSizestr[102, 0] = "PRC Envelope #8";
			this.fpagerSizestr[102, 1] = "1217";
			this.fpagerSizestr[102, 2] = "472";
			this.fpagerSizestr[103, 0] = "PRC Envelope #9";
			this.fpagerSizestr[103, 1] = "1276";
			this.fpagerSizestr[103, 2] = "902";
			this.fpagerSizestr[104, 0] = "PRC Envelope #10";
			this.fpagerSizestr[104, 1] = "1803";
			this.fpagerSizestr[104, 2] = "1276";
			this.fpagerSizestr[105, 0] = "PRC 16K Rotated";
			this.fpagerSizestr[105, 1] = "740";
			this.fpagerSizestr[105, 2] = "1024";
			this.fpagerSizestr[106, 0] = "PRC 32K Rotated";
			this.fpagerSizestr[106, 1] = "512";
			this.fpagerSizestr[106, 2] = "724";
			this.fpagerSizestr[107, 0] = "PRC 32K(Big) Rotated";
			this.fpagerSizestr[107, 1] = "551";
			this.fpagerSizestr[107, 2] = "799";
			this.fpagerSizestr[108, 0] = "PRC Envelope #1 Rotated";
			this.fpagerSizestr[108, 1] = "402";
			this.fpagerSizestr[108, 2] = "650";
			this.fpagerSizestr[109, 0] = "PRC Envelope #2 Rotated";
			this.fpagerSizestr[109, 1] = "402";
			this.fpagerSizestr[109, 2] = "693";
			this.fpagerSizestr[110, 0] = "PRC Envelope #3 Rotated";
			this.fpagerSizestr[110, 1] = "492";
			this.fpagerSizestr[110, 2] = "693";
			this.fpagerSizestr[111, 0] = "PRC Envelope #4 Rotated";
			this.fpagerSizestr[111, 1] = "433";
			this.fpagerSizestr[111, 2] = "819";
			this.fpagerSizestr[112, 0] = "PRC Envelope #5 Rotated";
			this.fpagerSizestr[112, 1] = "433";
			this.fpagerSizestr[112, 2] = "866";
			this.fpagerSizestr[113, 0] = "PRC Envelope #6 Rotated";
			this.fpagerSizestr[113, 1] = "472";
			this.fpagerSizestr[113, 2] = "906";
			this.fpagerSizestr[114, 0] = "PRC Envelope #7 Rotated";
			this.fpagerSizestr[114, 1] = "630";
			this.fpagerSizestr[114, 2] = "906";
			this.fpagerSizestr[115, 0] = "PRC Envelope #8 Rotated";
			this.fpagerSizestr[115, 1] = "472";
			this.fpagerSizestr[115, 2] = "1217";
			this.fpagerSizestr[116, 0] = "PRC Envelope #9 Rotated";
			this.fpagerSizestr[116, 1] = "902";
			this.fpagerSizestr[116, 2] = "1276";
			this.fpagerSizestr[117, 0] = "PRC Envelope #10 Rotated";
			this.fpagerSizestr[117, 1] = "1276";
			this.fpagerSizestr[117, 2] = "1803";
			this.fpagerSizestr[118, 0] = "LARGE";
			this.fpagerSizestr[118, 1] = "2700";
			this.fpagerSizestr[118, 2] = "1400";
			this.fpagerSizestr[119, 0] = "B5";
			this.fpagerSizestr[119, 1] = "1013";
			this.fpagerSizestr[119, 2] = "717";
			this.fpagerSizestr[120, 0] = "Letter.Transverse";
			this.fpagerSizestr[120, 1] = "1100";
			this.fpagerSizestr[120, 2] = "850";
			this.fpagerSizestr[121, 0] = "Legal.Transverse";
			this.fpagerSizestr[121, 1] = "1400";
			this.fpagerSizestr[121, 2] = "850";
			this.fpagerSizestr[122, 0] = "A4.Transverse";
			this.fpagerSizestr[122, 1] = "1169";
			this.fpagerSizestr[122, 2] = "828";
			this.fpagerSizestr[123, 0] = "A5.Transverse";
			this.fpagerSizestr[123, 1] = "828";
			this.fpagerSizestr[123, 2] = "583";
			this.fpagerSizestr[124, 0] = "B5.Transverse";
			this.fpagerSizestr[124, 1] = "1013";
			this.fpagerSizestr[124, 2] = "717";
			this.fpagerSizestr[125, 0] = "2x3 in";
			this.fpagerSizestr[125, 1] = "300";
			this.fpagerSizestr[125, 2] = "200";
			this.fpagerSizestr[126, 0] = "50x75 mm";
			this.fpagerSizestr[126, 1] = "295";
			this.fpagerSizestr[126, 2] = "197";
			this.fpagerSizestr[127, 0] = "4x6 in";
			this.fpagerSizestr[127, 1] = "600";
			this.fpagerSizestr[127, 2] = "400";
			this.fpagerSizestr[128, 0] = "100x150 mm";
			this.fpagerSizestr[128, 1] = "591";
			this.fpagerSizestr[128, 2] = "394";
			this.fpagerSizestr[129, 0] = "3x4 in";
			this.fpagerSizestr[129, 1] = "400";
			this.fpagerSizestr[129, 2] = "300";
			this.fpagerSizestr[130, 0] = "75x100 mm";
			this.fpagerSizestr[130, 1] = "394";
			this.fpagerSizestr[130, 2] = "295";
			this.fpagerSizestr[131, 0] = "6x8 in";
			this.fpagerSizestr[131, 1] = "800";
			this.fpagerSizestr[131, 2] = "600";
			this.fpagerSizestr[132, 0] = "150x200 mm";
			this.fpagerSizestr[132, 1] = "787";
			this.fpagerSizestr[132, 2] = "591";
			this.fpagerSizestr[133, 0] = "Ansi-E  34 x 44 in";
			this.fpagerSizestr[133, 1] = "4400";
			this.fpagerSizestr[133, 2] = "3400";
			this.fpagerSizestr[134, 0] = "Ansi-D  22 x 34 in";
			this.fpagerSizestr[134, 1] = "3400";
			this.fpagerSizestr[134, 2] = "2200";
			this.fpagerSizestr[135, 0] = "Ansi-C  17 x 22 in";
			this.fpagerSizestr[135, 1] = "2200";
			this.fpagerSizestr[135, 2] = "1700";
			this.fpagerSizestr[136, 0] = "Ansi-B  11 x 17 in";
			this.fpagerSizestr[136, 1] = "1700";
			this.fpagerSizestr[136, 2] = "1100";
			this.fpagerSizestr[137, 0] = "Ansi-A  8.5 x 11 in";
			this.fpagerSizestr[137, 1] = "1100";
			this.fpagerSizestr[137, 2] = "850";
			this.fpagerSizestr[138, 0] = "ISO A0  841 x 1189 mm";
			this.fpagerSizestr[138, 1] = "4681";
			this.fpagerSizestr[138, 2] = "3311";
			this.fpagerSizestr[139, 0] = "ISO A1  594 x  841 mm";
			this.fpagerSizestr[139, 1] = "3311";
			this.fpagerSizestr[139, 2] = "2339";
			this.fpagerSizestr[140, 0] = "ISO A2  420 x  594 mm";
			this.fpagerSizestr[140, 1] = "2339";
			this.fpagerSizestr[140, 2] = "1654";
			this.fpagerSizestr[141, 0] = "ISO A3  297 x  420 mm";
			this.fpagerSizestr[141, 1] = "1654";
			this.fpagerSizestr[141, 2] = "1169";
			this.fpagerSizestr[142, 0] = "ISO A4  210 x  297 mm";
			this.fpagerSizestr[142, 1] = "1169";
			this.fpagerSizestr[142, 2] = "827";
			this.fpagerSizestr[143, 0] = "ISO A5  148 x  210 mm";
			this.fpagerSizestr[143, 1] = "827";
			this.fpagerSizestr[143, 2] = "585";
			this.fpagerSizestr[144, 0] = "DIN A0  880 x 1230 mm";
			this.fpagerSizestr[144, 1] = "4843";
			this.fpagerSizestr[144, 2] = "3465";
			this.fpagerSizestr[145, 0] = "DIN A1  625 x  880 mm";
			this.fpagerSizestr[145, 1] = "3465";
			this.fpagerSizestr[145, 2] = "2461";
			this.fpagerSizestr[146, 0] = "DIN A2  450 x  625 mm";
			this.fpagerSizestr[146, 1] = "2461";
			this.fpagerSizestr[146, 2] = "1772";
			this.fpagerSizestr[147, 0] = "DIN A3  330 x  450 mm";
			this.fpagerSizestr[147, 1] = "1772";
			this.fpagerSizestr[147, 2] = "1299";
			this.fpagerSizestr[148, 0] = "DIN A4  240 x  330 mm";
			this.fpagerSizestr[148, 1] = "1299";
			this.fpagerSizestr[148, 2] = "945";
			this.fpagerSizestr[149, 0] = "ISO OS A0  900 x 1245 mm";
			this.fpagerSizestr[149, 1] = "4902";
			this.fpagerSizestr[149, 2] = "3543";
			this.fpagerSizestr[150, 0] = "ISO OS A1  625 x  900 mm";
			this.fpagerSizestr[150, 1] = "3543";
			this.fpagerSizestr[150, 2] = "2461";
			this.fpagerSizestr[151, 0] = "ISO OS A2  480 x  625 mm";
			this.fpagerSizestr[151, 1] = "2461";
			this.fpagerSizestr[151, 2] = "1890";
			this.fpagerSizestr[152, 0] = "Arch-E  36 x 48 in";
			this.fpagerSizestr[152, 1] = "4800";
			this.fpagerSizestr[152, 2] = "3600";
			this.fpagerSizestr[153, 0] = "Arch-E  30 x 42 in";
			this.fpagerSizestr[153, 1] = "4200";
			this.fpagerSizestr[153, 2] = "3000";
			this.fpagerSizestr[154, 0] = "Arch-D  24 x 36 in";
			this.fpagerSizestr[154, 1] = "3600";
			this.fpagerSizestr[154, 2] = "2400";
			this.fpagerSizestr[155, 0] = "Arch-C  18 x 24 in";
			this.fpagerSizestr[155, 1] = "2400";
			this.fpagerSizestr[155, 2] = "1800";
			this.fpagerSizestr[156, 0] = "Arch-B  12 x 18 in";
			this.fpagerSizestr[156, 1] = "1800";
			this.fpagerSizestr[156, 2] = "1200";
			this.fpagerSizestr[157, 0] = "Arch-A  9 x 12 in";
			this.fpagerSizestr[157, 1] = "1200";
			this.fpagerSizestr[157, 2] = "900";
			this.fpagerSizestr[158, 0] = "ISO B1   707 x 1000 mm";
			this.fpagerSizestr[158, 1] = "3937";
			this.fpagerSizestr[158, 2] = "2783";
			this.fpagerSizestr[159, 0] = "ISO B2   500 x  707 mm";
			this.fpagerSizestr[159, 1] = "2783";
			this.fpagerSizestr[159, 2] = "1969";
			this.fpagerSizestr[160, 0] = "ISO B3   353 x  500 mm";
			this.fpagerSizestr[160, 1] = "1969";
			this.fpagerSizestr[160, 2] = "1390";
			this.fpagerSizestr[161, 0] = "ISO B4   250 x  353 mm";
			this.fpagerSizestr[161, 1] = "1390";
			this.fpagerSizestr[161, 2] = "984";
			this.fpagerSizestr[162, 0] = "ISO B5   176 x  250 mm";
			this.fpagerSizestr[162, 1] = "984";
			this.fpagerSizestr[162, 2] = "693";
			this.fpagerSizestr[163, 0] = "Folio  8.5 x 13 in";
			this.fpagerSizestr[163, 1] = "1100";
			this.fpagerSizestr[163, 2] = "850";
			this.fpagerSizestr[164, 0] = "Letter  8.5 x 11 in";
			this.fpagerSizestr[164, 1] = "1100";
			this.fpagerSizestr[164, 2] = "850";
			this.fpagerSizestr[165, 0] = "Legal  8.5 x 14 in";
			this.fpagerSizestr[165, 1] = "1400";
			this.fpagerSizestr[165, 2] = "850";
			this.fpagerSizestr[166, 0] = "Ledger  11 x 17 in";
			this.fpagerSizestr[166, 1] = "1700";
			this.fpagerSizestr[166, 2] = "1100";
			this.fpagerSizestr[167, 0] = "Tabloid  11 x 17 in";
			this.fpagerSizestr[167, 1] = "1700";
			this.fpagerSizestr[167, 2] = "1100";
			this.fpagerSizestr[168, 0] = "Quarto  215 x 275 mm";
			this.fpagerSizestr[168, 1] = "1083";
			this.fpagerSizestr[168, 2] = "846";
			this.fpagerSizestr[169, 0] = "自定义大小";
			this.fpagerSizestr[169, 1] = "1100";
			this.fpagerSizestr[169, 2] = "850";
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00039F94 File Offset: 0x00038194
		public float GetPaperWidthInch(string papername)
		{
			int num = 0;
			checked
			{
				int num2 = this.fpagerSizestr.GetLength(0) - 1;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(Strings.Trim(papername.ToUpper()), Strings.Trim(this.fpagerSizestr[i, 0].ToUpper()), false) == 0)
					{
						return Convert.ToSingle(this.fpagerSizestr[i, 2]);
					}
				}
				return 0f;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0003A008 File Offset: 0x00038208
		public float GetPaperHeightInch(string papername)
		{
			int num = 0;
			checked
			{
				int num2 = this.fpagerSizestr.GetLength(0) - 1;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(Strings.Trim(papername.ToUpper()), Strings.Trim(this.fpagerSizestr[i, 0].ToUpper()), false) == 0)
					{
						return Convert.ToSingle(this.fpagerSizestr[i, 1]);
					}
				}
				return 0f;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0003A07C File Offset: 0x0003827C
		public float GetPaperWidthMM(string papername)
		{
			return (float)((double)(this.GetPaperWidthInch(papername) / 100f) * 2.54 * 10.0);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0003A0B0 File Offset: 0x000382B0
		public float GetPaperHeightMM(string papername)
		{
			return (float)((double)(this.GetPaperHeightInch(papername) / 100f) * 2.54 * 10.0);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00003858 File Offset: 0x00001A58
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				this.fpagerSizestr = null;
			}
			this.disposedValue = true;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00003873 File Offset: 0x00001A73
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000391 RID: 913
		[Description("纸张尺寸，0为纸张名称，1为纸张高度，2为纸张宽度，以1/100英寸为计量单位")]
		public string[,] fpagerSizestr;

		// Token: 0x04000392 RID: 914
		private bool disposedValue;
	}
}
