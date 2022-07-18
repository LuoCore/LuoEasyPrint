using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200016F RID: 367
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class definepaper
	{
		// Token: 0x06001EEE RID: 7918
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int OpenPrinter([MarshalAs(UnmanagedType.LPTStr)] string printername, ref IntPtr phPrinter, ref definepaper.structPrinterDefaults pd);

		// Token: 0x06001EEF RID: 7919
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int ClosePrinter(IntPtr phPrinter);

		// Token: 0x06001EF0 RID: 7920
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int AddForm(IntPtr hPrinter, [MarshalAs(UnmanagedType.I4)] int Level, ref definepaper.structFormInfo1 pForm);

		// Token: 0x06001EF1 RID: 7921
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int DeleteForm(IntPtr hPrinter, [MarshalAs(UnmanagedType.LPTStr)] string pFormName);

		// Token: 0x06001EF2 RID: 7922
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int SetForm(IntPtr hPrinter, [MarshalAs(UnmanagedType.LPTStr)] string pFormName, [MarshalAs(UnmanagedType.I4)] int Level, ref definepaper.structFormInfo1 pForm);

		// Token: 0x06001EF3 RID: 7923
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int GetLastError();

		// Token: 0x06001EF4 RID: 7924
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern IntPtr CreateDC([MarshalAs(UnmanagedType.LPTStr)] string lpDriverName, [MarshalAs(UnmanagedType.LPTStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPTStr)] string lpOutput, ref definepaper.structDevMode lpInitData);

		// Token: 0x06001EF5 RID: 7925
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern IntPtr ResetDC(IntPtr hdc, ref definepaper.structDevMode lpInitData);

		// Token: 0x06001EF6 RID: 7926
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int DeleteDC(IntPtr hdc);

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00101204 File Offset: 0x000FF404
		public static PaperSize GetPrintForm(string printerName, PaperKind paperkind)
		{
			PaperSize result = null;
			PrinterSettings printerSettings = new PrinterSettings();
			printerSettings.PrinterName = printerName;
			try
			{
				foreach (object obj in printerSettings.PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (paperSize.Kind == paperkind)
					{
						result = paperSize;
						break;
					}
				}
			}
			finally
			{
				
			}
			return result;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00101280 File Offset: 0x000FF480
		public static PaperSize GetPrintForm(string printerName, string paperName)
		{
			PaperSize result = null;
			PrinterSettings printerSettings = new PrinterSettings();
			if (Module1.IsValidPrinterName(printerName))
			{
				printerSettings.PrinterName = printerName;
			}
			try
			{
				foreach (object obj in printerSettings.PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (String.Compare(paperSize.PaperName.ToLower(), paperName.ToLower(), false) == 0)
					{
						result = paperSize;
						break;
					}
				}
			}
			finally
			{
				
			}
			return result;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00101314 File Offset: 0x000FF514
		public static void SetPrintForm(string printerName, string paperName, float width, float height)
		{
			if (!Module1.IsValidPrinterName(printerName))
			{
				PrinterSettings printerSettings = new PrinterSettings();
				printerName = printerSettings.PrinterName;
			}
			paperName = Strings.Trim(paperName);
			if (PlatformID.Win32NT == Environment.OSVersion.Platform)
			{
				definepaper.structPrinterDefaults structPrinterDefaults = default(definepaper.structPrinterDefaults);
				structPrinterDefaults.pDatatype = null;
				structPrinterDefaults.pDevMode = IntPtr.Zero;
				structPrinterDefaults.DesiredAccess = 12;
				IntPtr zero = IntPtr.Zero;
				long num = (long)definepaper.OpenPrinter(printerName, ref zero, ref structPrinterDefaults);
				checked
				{
					if (num != 0L)
					{
						try
						{
							definepaper.structFormInfo1 structFormInfo = default(definepaper.structFormInfo1);
							structFormInfo.Flags = 0;
							structFormInfo.pName = paperName;
							structFormInfo.size.width = (int)Math.Round((double)(unchecked(width * 1000f)));
							structFormInfo.size.height = (int)Math.Round((double)(unchecked(height * 1000f)));
							structFormInfo.ImageableArea.left = 0;
							structFormInfo.ImageableArea.right = structFormInfo.size.width;
							structFormInfo.ImageableArea.top = 0;
							structFormInfo.ImageableArea.bottom = structFormInfo.size.height;
							bool flag;
							if (definepaper.GetPrintForm(printerName, paperName) != null)
							{
								flag = (definepaper.SetForm(zero, paperName, 1, ref structFormInfo) != 0);
							}
							else
							{
								definepaper.AddCustomPaperSize(printerName, paperName, width, height);
								flag = true;
							}
							if (!flag)
							{
								StringBuilder stringBuilder = new StringBuilder();
								stringBuilder.AppendFormat("添加纸张{0}时发生错误!, 系统错误号: {1}", paperName, definepaper.GetLastError());
								MessageBox.Show(stringBuilder.ToString());
							}
						}
						finally
						{
							definepaper.ClosePrinter(zero);
						}
					}
				}
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x001014A0 File Offset: 0x000FF6A0
		public static void AddCustomPaperSize(string printerName, string paperName, float width, float height)
		{
			checked
			{
				if (PlatformID.Win32NT == Environment.OSVersion.Platform)
				{
					definepaper.structPrinterDefaults structPrinterDefaults = default(definepaper.structPrinterDefaults);
					structPrinterDefaults.pDatatype = null;
					structPrinterDefaults.pDevMode = IntPtr.Zero;
					structPrinterDefaults.DesiredAccess = 12;
					IntPtr zero = IntPtr.Zero;
					if (definepaper.OpenPrinter(printerName, ref zero, ref structPrinterDefaults) != 0)
					{
						try
						{
							definepaper.DeleteForm(zero, paperName);
							definepaper.structFormInfo1 structFormInfo = default(definepaper.structFormInfo1);
							structFormInfo.Flags = 0;
							structFormInfo.pName = paperName;
							structFormInfo.size.width = (int)Math.Round(unchecked((double)width * 1000.0));
							structFormInfo.size.height = (int)Math.Round(unchecked((double)height * 1000.0));
							structFormInfo.ImageableArea.left = 0;
							structFormInfo.ImageableArea.right = structFormInfo.size.width;
							structFormInfo.ImageableArea.top = 0;
							structFormInfo.ImageableArea.bottom = structFormInfo.size.height;
							try
							{
								if (definepaper.AddForm(zero, 1, ref structFormInfo) == 0)
								{
									StringBuilder stringBuilder = new StringBuilder();
									stringBuilder.AppendFormat("添加纸张{0}时发生错误!, 系统错误号: {1}", paperName, definepaper.GetLastError());
									throw new ApplicationException(stringBuilder.ToString());
								}
							}
							catch (Exception ex)
							{
							}
							return;
						}
						finally
						{
							definepaper.ClosePrinter(zero);
						}
					}
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.AppendFormat("打开打印机{0} 时出现异常!, 系统错误号: {1}", printerName, definepaper.GetLastError());
					throw new ApplicationException(stringBuilder2.ToString());
				}
				definepaper.structDevMode structDevMode = default(definepaper.structDevMode);
				IntPtr intPtr = definepaper.CreateDC(null, printerName, null, ref structDevMode);
				if (intPtr != IntPtr.Zero)
				{
					structDevMode.dmFields = 14;
					structDevMode.dmPaperSize = 256;
					structDevMode.dmPaperWidth = (short)Math.Round(unchecked((double)width * 2.54 * 1000.0));
					structDevMode.dmPaperLength = (short)Math.Round(unchecked((double)height * 2.54 * 1000.0));
					definepaper.ResetDC(intPtr, ref structDevMode);
					definepaper.DeleteDC(intPtr);
				}
			}
		}

		// Token: 0x02000170 RID: 368
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct structPrinterDefaults
		{
			// Token: 0x040010AF RID: 4271
			[MarshalAs(UnmanagedType.LPTStr)]
			public string pDatatype;

			// Token: 0x040010B0 RID: 4272
			public IntPtr pDevMode;

			// Token: 0x040010B1 RID: 4273
			[MarshalAs(UnmanagedType.I4)]
			public int DesiredAccess;
		}

		// Token: 0x02000171 RID: 369
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct structSize
		{
			// Token: 0x040010B2 RID: 4274
			public int width;

			// Token: 0x040010B3 RID: 4275
			public int height;
		}

		// Token: 0x02000172 RID: 370
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct structRect
		{
			// Token: 0x040010B4 RID: 4276
			public int left;

			// Token: 0x040010B5 RID: 4277
			public int top;

			// Token: 0x040010B6 RID: 4278
			public int right;

			// Token: 0x040010B7 RID: 4279
			public int bottom;
		}

		// Token: 0x02000173 RID: 371
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct structFormInfo1
		{
			// Token: 0x040010B8 RID: 4280
			[MarshalAs(UnmanagedType.I4)]
			public int Flags;

			// Token: 0x040010B9 RID: 4281
			[MarshalAs(UnmanagedType.LPTStr)]
			public string pName;

			// Token: 0x040010BA RID: 4282
			public definepaper.structSize size;

			// Token: 0x040010BB RID: 4283
			public definepaper.structRect ImageableArea;
		}

		// Token: 0x02000174 RID: 372
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct structDevMode
		{
			// Token: 0x040010BC RID: 4284
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmDeviceName;

			// Token: 0x040010BD RID: 4285
			[MarshalAs(UnmanagedType.U2)]
			public short dmSpecVersion;

			// Token: 0x040010BE RID: 4286
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverVersion;

			// Token: 0x040010BF RID: 4287
			[MarshalAs(UnmanagedType.U2)]
			public short dmSize;

			// Token: 0x040010C0 RID: 4288
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverExtra;

			// Token: 0x040010C1 RID: 4289
			[MarshalAs(UnmanagedType.U4)]
			public int dmFields;

			// Token: 0x040010C2 RID: 4290
			[MarshalAs(UnmanagedType.I2)]
			public short dmOrientation;

			// Token: 0x040010C3 RID: 4291
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperSize;

			// Token: 0x040010C4 RID: 4292
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperLength;

			// Token: 0x040010C5 RID: 4293
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperWidth;

			// Token: 0x040010C6 RID: 4294
			[MarshalAs(UnmanagedType.I2)]
			public short dmScale;

			// Token: 0x040010C7 RID: 4295
			[MarshalAs(UnmanagedType.I2)]
			public short dmCopies;

			// Token: 0x040010C8 RID: 4296
			[MarshalAs(UnmanagedType.I2)]
			public short dmDefaultSource;

			// Token: 0x040010C9 RID: 4297
			[MarshalAs(UnmanagedType.I2)]
			public short dmPrintQuality;

			// Token: 0x040010CA RID: 4298
			[MarshalAs(UnmanagedType.I2)]
			public short dmColor;

			// Token: 0x040010CB RID: 4299
			[MarshalAs(UnmanagedType.I2)]
			public short dmDuplex;

			// Token: 0x040010CC RID: 4300
			[MarshalAs(UnmanagedType.I2)]
			public short dmYResolution;

			// Token: 0x040010CD RID: 4301
			[MarshalAs(UnmanagedType.I2)]
			public short dmTTOption;

			// Token: 0x040010CE RID: 4302
			[MarshalAs(UnmanagedType.I2)]
			public short dmCollate;

			// Token: 0x040010CF RID: 4303
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmFormName;

			// Token: 0x040010D0 RID: 4304
			[MarshalAs(UnmanagedType.U2)]
			public short dmLogPixels;

			// Token: 0x040010D1 RID: 4305
			[MarshalAs(UnmanagedType.U4)]
			public int dmBitsPerPel;

			// Token: 0x040010D2 RID: 4306
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsWidth;

			// Token: 0x040010D3 RID: 4307
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsHeight;

			// Token: 0x040010D4 RID: 4308
			[MarshalAs(UnmanagedType.U4)]
			public int dmNup;

			// Token: 0x040010D5 RID: 4309
			[MarshalAs(UnmanagedType.U4)]
			public int dmDisplayFrequency;

			// Token: 0x040010D6 RID: 4310
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMMethod;

			// Token: 0x040010D7 RID: 4311
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMIntent;

			// Token: 0x040010D8 RID: 4312
			[MarshalAs(UnmanagedType.U4)]
			public int dmMediaType;

			// Token: 0x040010D9 RID: 4313
			[MarshalAs(UnmanagedType.U4)]
			public int dmDitherType;

			// Token: 0x040010DA RID: 4314
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved1;

			// Token: 0x040010DB RID: 4315
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved2;
		}
	}
}
