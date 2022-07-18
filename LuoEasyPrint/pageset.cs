using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200007A RID: 122
	[StandardModule]
	internal sealed class pageset
	{
		// Token: 0x060011E7 RID: 4583
		[SuppressUnmanagedCodeSecurity]
		[DllImport("comdlg32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int PageSetupDlg([In] [Out] ref pageset.S_PageSetupDlg pPagesetupdlg);


		// Token: 0x02000082 RID: 130
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct S_PageSetupDlg
		{
			// Token: 0x04000945 RID: 2373
			[MarshalAs(UnmanagedType.U4)]
			public int lStructSize;

			// Token: 0x04000946 RID: 2374
			public IntPtr hwndOwner;

			// Token: 0x04000947 RID: 2375
			public IntPtr hDevMode;

			// Token: 0x04000948 RID: 2376
			public IntPtr hDevNames;

			// Token: 0x04000949 RID: 2377
			[MarshalAs(UnmanagedType.U4)]
			public int FLAGS;

			// Token: 0x0400094A RID: 2378
			public pageset.POINTAPI ptPaperSize;

			// Token: 0x0400094B RID: 2379
			public pageset.Rect rtMinMargin;

			// Token: 0x0400094C RID: 2380
			public pageset.Rect rtMargin;

			// Token: 0x0400094D RID: 2381
			[MarshalAs(UnmanagedType.U4)]
			public int hInstance;

			// Token: 0x0400094E RID: 2382
			[MarshalAs(UnmanagedType.U4)]
			public int lCustData;

			// Token: 0x0400094F RID: 2383
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnPageSetupHook;

			// Token: 0x04000950 RID: 2384
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnPagePaintHook;

			// Token: 0x04000951 RID: 2385
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpPageSetupTemplateName;

			// Token: 0x04000952 RID: 2386
			[MarshalAs(UnmanagedType.U4)]
			public int hPageSetupTemplate;
		}

		// Token: 0x060011E8 RID: 4584
		[SuppressUnmanagedCodeSecurity]
		[DllImport("comdlg32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int PrintDlg([In] [Out] ref pageset.PRINTDLG_TYPE pPrintdlg);

		// Token: 0x060011E9 RID: 4585
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern void RtlMoveMemory(ref pageset.structDevMode hpvDest, IntPtr hpvSource, int cbCopy);

		// Token: 0x060011EA RID: 4586
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.U4)]
		private static extern int GlobalLock([MarshalAs(UnmanagedType.U4)] int hMem);

		// Token: 0x060011EB RID: 4587
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.U4)]
		private static extern int GlobalUnlock([MarshalAs(UnmanagedType.U4)] int hMem);

		// Token: 0x060011EC RID: 4588
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.U4)]
		private static extern int GlobalAlloc([MarshalAs(UnmanagedType.U4)] int wFlags, [MarshalAs(UnmanagedType.U4)] int dwBytes);

		// Token: 0x060011ED RID: 4589
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.U4)]
		private static extern int GlobalFree([MarshalAs(UnmanagedType.U4)] int hMem);

		// Token: 0x060011EE RID: 4590 RVA: 0x0008DD38 File Offset: 0x0008BF38
		public static bool ShowPageSet(ref PageSettings mypage, IntPtr owner, ref bool haserror)
		{
			haserror = false;
			bool flag = false;
			pageset.S_PageSetupDlg pageSetupDlg = default(pageset.S_PageSetupDlg);
			pageSetupDlg.lStructSize = Marshal.SizeOf(pageSetupDlg);
			pageSetupDlg.hwndOwner = owner;
			pageSetupDlg.FLAGS = 10;
			checked
			{
				pageSetupDlg.rtMargin.bottom = (int)Math.Round(unchecked((double)mypage.Margins.Bottom * 2.54 * 10.0));
				pageSetupDlg.rtMargin.top = (int)Math.Round(unchecked((double)mypage.Margins.Top * 2.54 * 10.0));
				pageSetupDlg.rtMargin.left = (int)Math.Round(unchecked((double)mypage.Margins.Left * 2.54 * 10.0));
				pageSetupDlg.rtMargin.right = (int)Math.Round(unchecked((double)mypage.Margins.Right * 2.54 * 10.0));
				pageSetupDlg.ptPaperSize.X = (int)Math.Round(unchecked((double)mypage.PaperSize.Width * 2.54 * 10.0));
				pageSetupDlg.ptPaperSize.Y = (int)Math.Round(unchecked((double)mypage.PaperSize.Height * 2.54 * 10.0));
				pageSetupDlg.hDevNames = mypage.PrinterSettings.GetHdevnames();
				pageset.structDevMode structDevMode = default(pageset.structDevMode);
				structDevMode.dmDeviceName = mypage.PrinterSettings.PrinterName;
				structDevMode.dmSize = (short)Marshal.SizeOf(structDevMode);
				structDevMode.dmFields = 65537;
				structDevMode.dmOrientation = Conversions.ToShort(Interaction.IIf(mypage.Landscape, 2, 1));
				structDevMode.dmFormName = mypage.PaperSize.PaperName;
				bool result;
				try
				{
					pageSetupDlg.hDevMode = Marshal.AllocHGlobal(Marshal.SizeOf(structDevMode));
					Marshal.StructureToPtr(structDevMode, pageSetupDlg.hDevMode, false);
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					long num = unchecked((long)pageset.PageSetupDlg(ref pageSetupDlg));
					stopwatch.Stop();
					if (num == 0L)
					{
						if (stopwatch.ElapsedMilliseconds <= 100L)
						{
							haserror = true;
						}
						return false;
					}
					IntPtr hpvSource = (IntPtr)pageset.GlobalLock((int)pageSetupDlg.hDevMode);
					pageset.RtlMoveMemory(ref structDevMode, hpvSource, Marshal.SizeOf(structDevMode));
					pageset.GlobalUnlock((int)pageSetupDlg.hDevMode);
					mypage.Margins.Left = (int)Math.Round((double)pageSetupDlg.rtMargin.left / 2.54 / 10.0);
					mypage.Margins.Right = (int)Math.Round((double)pageSetupDlg.rtMargin.right / 2.54 / 10.0);
					mypage.Margins.Top = (int)Math.Round((double)pageSetupDlg.rtMargin.top / 2.54 / 10.0);
					mypage.Margins.Bottom = (int)Math.Round((double)pageSetupDlg.rtMargin.bottom / 2.54 / 10.0);
					mypage.PrinterSettings.SetHdevnames(pageSetupDlg.hDevNames);
					mypage.PrinterSettings.DefaultPageSettings.PrinterSettings.SetHdevnames(pageSetupDlg.hDevNames);
					mypage.PaperSize = definepaper.GetPrintForm(mypage.PrinterSettings.PrinterName, structDevMode.dmFormName);
					if (structDevMode.dmOrientation == 2)
					{
						mypage.Landscape = true;
					}
					else
					{
						mypage.Landscape = false;
					}
					result = !flag;
				}
				catch (Exception ex)
				{
					result = false;
				}
				finally
				{
					Marshal.FreeHGlobal(pageSetupDlg.hDevMode);
				}
				if (String.Compare(mypage.PrinterSettings.DefaultPageSettings.PaperSize.PaperName, mypage.PaperSize.PaperName, false) != 0)
				{
					mypage.PrinterSettings.DefaultPageSettings.PaperSize = mypage.PaperSize;
				}
				return result;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0008E1B4 File Offset: 0x0008C3B4
		public static bool ShowPrinter(ref PageSettings mypage, IntPtr owner, long maxpages, short ncopys, ref bool haserror)
		{
			haserror = false;
			pageset.PRINTDLG_TYPE printdlg_TYPE = default(pageset.PRINTDLG_TYPE);
			printdlg_TYPE.lStructSize = Marshal.SizeOf(printdlg_TYPE);
			printdlg_TYPE.hwndOwner = owner;
			pageset.FLAGS = (pageset.PrinterConstants)524292;
			printdlg_TYPE.FLAGS = (int)pageset.FLAGS;
			printdlg_TYPE.nMinPage = 1;
			printdlg_TYPE.nFromPage = 1;
			printdlg_TYPE.nCopies = ncopys;
			Stopwatch stopwatch;
			checked
			{
				printdlg_TYPE.nToPage = (short)maxpages;
				printdlg_TYPE.nMaxPage = (short)maxpages;
				printdlg_TYPE.hDevNames = (int)mypage.PrinterSettings.GetHdevnames();
				mypage.PrinterSettings.Copies = ncopys;
				printdlg_TYPE.hDevMode = (int)mypage.PrinterSettings.GetHdevmode();
				stopwatch = new Stopwatch();
				stopwatch.Start();
			}
			long num = (long)pageset.PrintDlg(ref printdlg_TYPE);
			stopwatch.Stop();
			bool flag;
			if (num != 0L)
			{
				flag = false;
				mypage.PrinterSettings.SetHdevnames((IntPtr)printdlg_TYPE.hDevNames);
				mypage.PrinterSettings.DefaultPageSettings.PrinterSettings.SetHdevnames((IntPtr)printdlg_TYPE.hDevNames);
				mypage.PrinterSettings.SetHdevmode((IntPtr)printdlg_TYPE.hDevMode);
				mypage.PrinterSettings.DefaultPageSettings.PrinterSettings.SetHdevmode((IntPtr)printdlg_TYPE.hDevMode);
				mypage.PrinterSettings.FromPage = (int)printdlg_TYPE.nFromPage;
				mypage.PrinterSettings.ToPage = (int)printdlg_TYPE.nToPage;
				mypage.PrinterSettings.Copies = printdlg_TYPE.nCopies;
				if ((printdlg_TYPE.FLAGS & 2) == 2)
				{
					mypage.PrinterSettings.PrintRange = PrintRange.SomePages;
				}
				else
				{
					mypage.PrinterSettings.PrintRange = PrintRange.AllPages;
				}
			}
			else
			{
				flag = true;
				if (stopwatch.ElapsedMilliseconds <= 100L)
				{
					haserror = true;
				}
			}
			return !flag;
		}

		// Token: 0x040008D8 RID: 2264
		private const long DM_FORMNAME = 65536L;

		// Token: 0x040008D9 RID: 2265
		private const short CCHFORMNAME = 32;

		// Token: 0x040008DA RID: 2266
		private const int GMEM_FIXED = 0;

		// Token: 0x040008DB RID: 2267
		private const int GMEM_MOVEABLE = 2;

		// Token: 0x040008DC RID: 2268
		private const int GMEM_ZEROINIT = 64;

		// Token: 0x040008DD RID: 2269
		private const int DM_DUPLEX = 4096;

		// Token: 0x040008DE RID: 2270
		private const int DM_ORIENTATION = 1;

		// Token: 0x040008DF RID: 2271
		private const int DM_PAPERSIZE = 2;

		// Token: 0x040008E0 RID: 2272
		private const int PSD_MARGINS = 2;

		// Token: 0x040008E1 RID: 2273
		private const int PSD_INHUNDREDTHSOFMILLIMETERS = 8;

		// Token: 0x040008E2 RID: 2274
		public static pageset.PrinterConstants FLAGS = pageset.PrinterConstants.PD_ALLPAGES;

		// Token: 0x0200007B RID: 123
		[ComVisible(false)]
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
		private struct PRINTDLG_TYPE
		{
			// Token: 0x040008E3 RID: 2275
			[MarshalAs(UnmanagedType.U4)]
			public int lStructSize;

			// Token: 0x040008E4 RID: 2276
			public IntPtr hwndOwner;

			// Token: 0x040008E5 RID: 2277
			[MarshalAs(UnmanagedType.U4)]
			public int hDevMode;

			// Token: 0x040008E6 RID: 2278
			[MarshalAs(UnmanagedType.U4)]
			public int hDevNames;

			// Token: 0x040008E7 RID: 2279
			[MarshalAs(UnmanagedType.U4)]
			public int hdc;

			// Token: 0x040008E8 RID: 2280
			[MarshalAs(UnmanagedType.U4)]
			public int FLAGS;

			// Token: 0x040008E9 RID: 2281
			[MarshalAs(UnmanagedType.U2)]
			public short nFromPage;

			// Token: 0x040008EA RID: 2282
			[MarshalAs(UnmanagedType.U2)]
			public short nToPage;

			// Token: 0x040008EB RID: 2283
			[MarshalAs(UnmanagedType.U2)]
			public short nMinPage;

			// Token: 0x040008EC RID: 2284
			[MarshalAs(UnmanagedType.U2)]
			public short nMaxPage;

			// Token: 0x040008ED RID: 2285
			[MarshalAs(UnmanagedType.U2)]
			public short nCopies;

			// Token: 0x040008EE RID: 2286
			[MarshalAs(UnmanagedType.U4)]
			public int hInstance;

			// Token: 0x040008EF RID: 2287
			[MarshalAs(UnmanagedType.U4)]
			public int lCustData;

			// Token: 0x040008F0 RID: 2288
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnPrintHook;

			// Token: 0x040008F1 RID: 2289
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnSetupHook;

			// Token: 0x040008F2 RID: 2290
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpPrintTemplateName;

			// Token: 0x040008F3 RID: 2291
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpSetupTemplateName;

			// Token: 0x040008F4 RID: 2292
			[MarshalAs(UnmanagedType.U4)]
			public int hPrintTemplate;

			// Token: 0x040008F5 RID: 2293
			[MarshalAs(UnmanagedType.U4)]
			public int hSetupTemplate;
		}

		// Token: 0x0200007C RID: 124
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct PAGESETUPDLG_TYPE
		{
			// Token: 0x040008F6 RID: 2294
			[MarshalAs(UnmanagedType.U4)]
			public int lStructSize;

			// Token: 0x040008F7 RID: 2295
			public IntPtr hwndOwner;

			// Token: 0x040008F8 RID: 2296
			[MarshalAs(UnmanagedType.U4)]
			public int hDevMode;

			// Token: 0x040008F9 RID: 2297
			[MarshalAs(UnmanagedType.U4)]
			public int hDevNames;

			// Token: 0x040008FA RID: 2298
			[MarshalAs(UnmanagedType.U4)]
			public int FLAGS;

			// Token: 0x040008FB RID: 2299
			public pageset.POINTAPI prpapersize;

			// Token: 0x040008FC RID: 2300
			public pageset.Rect rtminmargin;

			// Token: 0x040008FD RID: 2301
			public pageset.Rect rtmargin;

			// Token: 0x040008FE RID: 2302
			[MarshalAs(UnmanagedType.U4)]
			public int hInstance;

			// Token: 0x040008FF RID: 2303
			[MarshalAs(UnmanagedType.U4)]
			public int lCustData;

			// Token: 0x04000900 RID: 2304
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnPageSetupHook;

			// Token: 0x04000901 RID: 2305
			[MarshalAs(UnmanagedType.U4)]
			public int lpfnPagePaintHook;

			// Token: 0x04000902 RID: 2306
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpPageSetupTemplateName;

			// Token: 0x04000903 RID: 2307
			[MarshalAs(UnmanagedType.LPTStr)]
			public string hPageSetupTemplate;
		}

		// Token: 0x0200007D RID: 125
		public enum PrinterConstants
		{
			// Token: 0x04000905 RID: 2309
			PD_ALLPAGES,
			// Token: 0x04000906 RID: 2310
			PD_COLLATE = 16,
			// Token: 0x04000907 RID: 2311
			PD_DISABLEPRINTTOFILE = 524288,
			// Token: 0x04000908 RID: 2312
			PD_ENABLEPRINTHOOK = 4096,
			// Token: 0x04000909 RID: 2313
			PD_ENABLEPRINTTEMPLATE = 16384,
			// Token: 0x0400090A RID: 2314
			PD_ENABLEPRINTTEMPLATEHANDLE = 65536,
			// Token: 0x0400090B RID: 2315
			PD_ENABLESETUPHOOK = 8192,
			// Token: 0x0400090C RID: 2316
			PD_ENABLESETUPTEMPLATE = 32768,
			// Token: 0x0400090D RID: 2317
			PD_ENABLESETUPTEMPLATEHANDLE = 131072,
			// Token: 0x0400090E RID: 2318
			PD_HIDEPRINTTOFILE = 1048576,
			// Token: 0x0400090F RID: 2319
			PD_NONETWORKBUTTON = 2097152,
			// Token: 0x04000910 RID: 2320
			PD_NOPAGENUMS = 8,
			// Token: 0x04000911 RID: 2321
			PD_NOSELECTION = 4,
			// Token: 0x04000912 RID: 2322
			PD_NOWARNING = 128,
			// Token: 0x04000913 RID: 2323
			PD_PAGENUMS = 2,
			// Token: 0x04000914 RID: 2324
			PD_PRINTSETUP = 64,
			// Token: 0x04000915 RID: 2325
			PD_PRINTTOFILE = 32,
			// Token: 0x04000916 RID: 2326
			PD_RETURNDC = 256,
			// Token: 0x04000917 RID: 2327
			PD_RETURNDEFAULT = 1024,
			// Token: 0x04000918 RID: 2328
			PD_RETURNIC = 512,
			// Token: 0x04000919 RID: 2329
			PD_SELECTION = 1,
			// Token: 0x0400091A RID: 2330
			PD_SHOWHELP = 2048,
			// Token: 0x0400091B RID: 2331
			PD_USEDEVMODECOPIES = 262144,
			// Token: 0x0400091C RID: 2332
			PD_USEDEVMODECOPIESANDCOLLATE = 262144
		}

		// Token: 0x0200007E RID: 126
		public enum ErrorConstants
		{
			// Token: 0x0400091E RID: 2334
			cdlCancel = 32755
		}

		// Token: 0x0200007F RID: 127
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct Rect
		{
			// Token: 0x0400091F RID: 2335
			public int left;

			// Token: 0x04000920 RID: 2336
			public int top;

			// Token: 0x04000921 RID: 2337
			public int right;

			// Token: 0x04000922 RID: 2338
			public int bottom;
		}

		// Token: 0x02000080 RID: 128
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
		private struct structDevMode
		{
			// Token: 0x04000923 RID: 2339
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmDeviceName;

			// Token: 0x04000924 RID: 2340
			[MarshalAs(UnmanagedType.U2)]
			public short dmSpecVersion;

			// Token: 0x04000925 RID: 2341
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverVersion;

			// Token: 0x04000926 RID: 2342
			[MarshalAs(UnmanagedType.U2)]
			public short dmSize;

			// Token: 0x04000927 RID: 2343
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverExtra;

			// Token: 0x04000928 RID: 2344
			[MarshalAs(UnmanagedType.U4)]
			public int dmFields;

			// Token: 0x04000929 RID: 2345
			[MarshalAs(UnmanagedType.I2)]
			public short dmOrientation;

			// Token: 0x0400092A RID: 2346
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperSize;

			// Token: 0x0400092B RID: 2347
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperLength;

			// Token: 0x0400092C RID: 2348
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperWidth;

			// Token: 0x0400092D RID: 2349
			[MarshalAs(UnmanagedType.I2)]
			public short dmScale;

			// Token: 0x0400092E RID: 2350
			[MarshalAs(UnmanagedType.I2)]
			public short dmCopies;

			// Token: 0x0400092F RID: 2351
			[MarshalAs(UnmanagedType.I2)]
			public short dmDefaultSource;

			// Token: 0x04000930 RID: 2352
			[MarshalAs(UnmanagedType.I2)]
			public short dmPrintQuality;

			// Token: 0x04000931 RID: 2353
			[MarshalAs(UnmanagedType.I2)]
			public short dmColor;

			// Token: 0x04000932 RID: 2354
			[MarshalAs(UnmanagedType.I2)]
			public short dmDuplex;

			// Token: 0x04000933 RID: 2355
			[MarshalAs(UnmanagedType.I2)]
			public short dmYResolution;

			// Token: 0x04000934 RID: 2356
			[MarshalAs(UnmanagedType.I2)]
			public short dmTTOption;

			// Token: 0x04000935 RID: 2357
			[MarshalAs(UnmanagedType.I2)]
			public short dmCollate;

			// Token: 0x04000936 RID: 2358
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmFormName;

			// Token: 0x04000937 RID: 2359
			[MarshalAs(UnmanagedType.U2)]
			public short dmLogPixels;

			// Token: 0x04000938 RID: 2360
			[MarshalAs(UnmanagedType.U4)]
			public int dmBitsPerPel;

			// Token: 0x04000939 RID: 2361
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsWidth;

			// Token: 0x0400093A RID: 2362
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsHeight;

			// Token: 0x0400093B RID: 2363
			[MarshalAs(UnmanagedType.U4)]
			public int dmNup;

			// Token: 0x0400093C RID: 2364
			[MarshalAs(UnmanagedType.U4)]
			public int dmDisplayFrequency;

			// Token: 0x0400093D RID: 2365
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMMethod;

			// Token: 0x0400093E RID: 2366
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMIntent;

			// Token: 0x0400093F RID: 2367
			[MarshalAs(UnmanagedType.U4)]
			public int dmMediaType;

			// Token: 0x04000940 RID: 2368
			[MarshalAs(UnmanagedType.U4)]
			public int dmDitherType;

			// Token: 0x04000941 RID: 2369
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved1;

			// Token: 0x04000942 RID: 2370
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved2;
		}

		// Token: 0x02000081 RID: 129
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct POINTAPI
		{
			// Token: 0x04000943 RID: 2371
			[MarshalAs(UnmanagedType.U4)]
			public int X;

			// Token: 0x04000944 RID: 2372
			[MarshalAs(UnmanagedType.U4)]
			public int Y;
		}

	
	}
}
