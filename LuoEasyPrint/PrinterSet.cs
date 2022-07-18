using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000139 RID: 313
	public class PrinterSet
	{
		// Token: 0x06001D2F RID: 7471 RVA: 0x000024B1 File Offset: 0x000006B1
		private PrinterSet()
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000EAAF4 File Offset: 0x000E8CF4
		public static void AddCustomPaperSize(string PrinterName, string PaperName, float WidthInMm, float HeightInMm)
		{
			checked
			{
				if (PlatformID.Win32NT == Environment.OSVersion.Platform)
				{
					PrinterSet.structPrinterDefaults structPrinterDefaults = default(PrinterSet.structPrinterDefaults);
					structPrinterDefaults.pDatatype = null;
					structPrinterDefaults.pDevMode = IntPtr.Zero;
					structPrinterDefaults.DesiredAccess = 12;
					IntPtr zero = IntPtr.Zero;
					if (!PrinterSet.OpenPrinter(PrinterName, out zero, ref structPrinterDefaults))
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.AppendFormat("无法打开打印机:{0}, 错误代号: {1}", PrinterName, PrinterSet.GetLastError());
						throw new ApplicationException(stringBuilder.ToString());
					}
					try
					{
						PrinterSet.DeleteForm(zero, PaperName);
						PrinterSet.FormInfo1 formInfo = default(PrinterSet.FormInfo1);
						formInfo.Flags = 0U;
						formInfo.pName = PaperName;
						formInfo.Size.width = (int)Math.Round((double)(unchecked(WidthInMm * 1000f)));
						formInfo.Size.height = (int)Math.Round((double)(unchecked(HeightInMm * 1000f)));
						formInfo.ImageableArea.left = 0;
						formInfo.ImageableArea.right = formInfo.Size.width;
						formInfo.ImageableArea.top = 0;
						formInfo.ImageableArea.bottom = formInfo.Size.height;
						IntPtr phPrinter = zero;
						int level = 1;
						PrinterSet.FormInfo1 formInfo2 = formInfo;
						if (!PrinterSet.AddFormW(phPrinter, level, ref formInfo2))
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.AppendFormat("向打印机 {1} 添加自定义纸张 {0} 失败！错误代号:{2}", PaperName, PrinterName, PrinterSet.GetLastError());
							throw new ApplicationException(stringBuilder.ToString());
						}
						PrinterSet.structDevMode structDevMode = default(PrinterSet.structDevMode);
						PrinterSet.PRINTER_INFO_9 printer_INFO_;
						printer_INFO_.pDevMode = IntPtr.Zero;
						int num = PrinterSet.DocumentPropertiesA(IntPtr.Zero, zero, PrinterName, IntPtr.Zero, IntPtr.Zero, 0);
						if (num < 0)
						{
							throw new ApplicationException("无法取得DEVMODE结构的大小！");
						}
						IntPtr intPtr = Marshal.AllocCoTaskMem(num + 100);
						if (PrinterSet.DocumentPropertiesA(IntPtr.Zero, zero, PrinterName, intPtr, IntPtr.Zero, 2) < 0)
						{
							throw new ApplicationException("无法获得DEVMODE结构！");
						}
						structDevMode = (PrinterSet.structDevMode)Marshal.PtrToStructure(intPtr, structDevMode.GetType());
						structDevMode.dmFields = 65536;
						structDevMode.dmFormName = PaperName;
						Marshal.StructureToPtr(structDevMode, intPtr, true);
						if (PrinterSet.DocumentPropertiesA(IntPtr.Zero, zero, PrinterName, printer_INFO_.pDevMode, printer_INFO_.pDevMode, 10) < 0)
						{
							throw new ApplicationException("无法为打印机设定打印方向！");
						}
						int num2;
						PrinterSet.GetPrinterA(zero, 9, IntPtr.Zero, 0, out num2);
						if (num2 == 0)
						{
							throw new ApplicationException("调用GetPrinter方法失败！");
						}
						IntPtr intPtr2 = Marshal.AllocCoTaskMem(num2 + 100);
						int num3;
						if (!PrinterSet.GetPrinterA(zero, 9, intPtr2, num2, out num3))
						{
							throw new ApplicationException("调用GetPrinter方法失败！");
						}
						printer_INFO_ = (PrinterSet.PRINTER_INFO_9)Marshal.PtrToStructure(intPtr2, printer_INFO_.GetType());
						printer_INFO_.pDevMode = intPtr;
						Marshal.StructureToPtr(printer_INFO_, intPtr2, true);
						if (!PrinterSet.SetPrinterA(zero, 9, intPtr2, 0))
						{
							throw new Win32Exception(Marshal.GetLastWin32Error(), "调用SetPrinter方法失败，无法进行打印机设置！");
						}
						IntPtr windowHandle = new IntPtr(65535);
						IntPtr intPtr3;
						PrinterSet.SendMessageTimeout(windowHandle, 26U, IntPtr.Zero, IntPtr.Zero, PrinterSet.SendMessageTimeoutFlags.SMTO_NORMAL, 1000U, out intPtr3);
						return;
					}
					finally
					{
						PrinterSet.ClosePrinter(zero);
					}
				}
				PrinterSet.structDevMode structDevMode2 = default(PrinterSet.structDevMode);
				IntPtr intPtr4 = PrinterSet.CreateDC(null, PrinterName, null, ref structDevMode2);
				if (intPtr4 != IntPtr.Zero)
				{
					structDevMode2.dmFields = 14;
					structDevMode2.dmPaperSize = 256;
					structDevMode2.dmPaperWidth = (short)Math.Round((double)(unchecked(WidthInMm * 1000f)));
					structDevMode2.dmPaperLength = (short)Math.Round((double)(unchecked(HeightInMm * 1000f)));
					PrinterSet.ResetDC(intPtr4, ref structDevMode2);
					PrinterSet.DeleteDC(intPtr4);
				}
			}
		}

		// Token: 0x06001D31 RID: 7473
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool AddFormW(IntPtr phPrinter, [MarshalAs(UnmanagedType.I4)] int level, ref PrinterSet.FormInfo1 form);

		// Token: 0x06001D32 RID: 7474
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool ClosePrinter(IntPtr phPrinter);

		// Token: 0x06001D33 RID: 7475
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr CreateDC([MarshalAs(UnmanagedType.LPTStr)] string pDrive, [MarshalAs(UnmanagedType.LPTStr)] string pName, [MarshalAs(UnmanagedType.LPTStr)] string pOutput, ref PrinterSet.structDevMode pDevMode);

		// Token: 0x06001D34 RID: 7476 RVA: 0x000EAE80 File Offset: 0x000E9080
		public static void DeleteCustomPaperSize(string PrinterName, string PaperName)
		{
			PrinterSet.structPrinterDefaults structPrinterDefaults = default(PrinterSet.structPrinterDefaults);
			structPrinterDefaults.pDatatype = null;
			structPrinterDefaults.pDevMode = IntPtr.Zero;
			structPrinterDefaults.DesiredAccess = 12;
			IntPtr zero = IntPtr.Zero;
			if (PrinterSet.OpenPrinter(PrinterName, out zero, ref structPrinterDefaults))
			{
				try
				{
					PrinterSet.DeleteForm(zero, PaperName);
					PrinterSet.ClosePrinter(zero);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001D35 RID: 7477
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool DeleteDC(IntPtr hDC);

		// Token: 0x06001D36 RID: 7478
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool DeleteForm(IntPtr phPrinter, [MarshalAs(UnmanagedType.LPTStr)] string pName);

		// Token: 0x06001D37 RID: 7479
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern int DocumentPropertiesA(IntPtr hwnd, IntPtr hPrinter, [MarshalAs(UnmanagedType.LPStr)] string pDeviceName, IntPtr pDevModeOutput, IntPtr pDevModeInput, int fMode);

		// Token: 0x06001D38 RID: 7480
		[DllImport("winspool.drv")]
		internal static extern int EnumForms(IntPtr hPrinter, int Level, ref byte pForm, int cbBuf, ref int pcbNeeded, ref int pcReturned);

		// Token: 0x06001D39 RID: 7481
		[DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool EnumPrinters(PrinterSet.PrinterEnumFlags Flags, string Name, uint Level, IntPtr pPrinterEnum, uint cbBuf, ref uint pcbNeeded, ref uint pcReturned);

		// Token: 0x06001D3A RID: 7482 RVA: 0x000EAEF4 File Offset: 0x000E90F4
		internal static PrinterSet.PRINTER_INFO_2[] EnumPrintersByFlag(PrinterSet.PrinterEnumFlags Flags)
		{
			uint num = 0U;
			uint num2 = 0U;
			PrinterSet.EnumPrinters(PrinterSet.PrinterEnumFlags.PRINTER_ENUM_LOCAL, null, 2U, IntPtr.Zero, 0U, ref num, ref num2);
			checked
			{
				IntPtr intPtr = Marshal.AllocHGlobal((int)num);
				PrinterSet.PRINTER_INFO_2[] result;
				if (PrinterSet.EnumPrinters(PrinterSet.PrinterEnumFlags.PRINTER_ENUM_LOCAL, null, 2U, intPtr, num, ref num, ref num2))
				{
					PrinterSet.PRINTER_INFO_2[] array = new PrinterSet.PRINTER_INFO_2[(int)(unchecked((ulong)num2) - 1UL) + 1];
					int num3 = intPtr.ToInt32();
					int num4 = 0;
					int num5 = (int)(unchecked((ulong)num2) - 1UL);
					for (int i = num4; i <= num5; i++)
					{
						PrinterSet.PRINTER_INFO_2[] array2 = array;
						int num6 = i;
						IntPtr ptr = new IntPtr(num3);
						array2[num6].pServerName = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array3 = array;
						int num7 = i;
						ptr = new IntPtr(num3);
						array3[num7].pPrinterName = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array4 = array;
						int num8 = i;
						ptr = new IntPtr(num3);
						array4[num8].pShareName = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array5 = array;
						int num9 = i;
						ptr = new IntPtr(num3);
						array5[num9].pPortName = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array6 = array;
						int num10 = i;
						ptr = new IntPtr(num3);
						array6[num10].pDriverName = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array7 = array;
						int num11 = i;
						ptr = new IntPtr(num3);
						array7[num11].pComment = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array8 = array;
						int num12 = i;
						ptr = new IntPtr(num3);
						array8[num12].pLocation = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array9 = array;
						int num13 = i;
						ptr = new IntPtr(num3);
						array9[num13].pDevMode = Marshal.ReadIntPtr(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array10 = array;
						int num14 = i;
						ptr = new IntPtr(num3);
						array10[num14].pSepFile = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array11 = array;
						int num15 = i;
						ptr = new IntPtr(num3);
						array11[num15].pPrintProcessor = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array12 = array;
						int num16 = i;
						ptr = new IntPtr(num3);
						array12[num16].pDatatype = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array13 = array;
						int num17 = i;
						ptr = new IntPtr(num3);
						array13[num17].pParameters = Marshal.PtrToStringAuto(Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array14 = array;
						int num18 = i;
						ptr = new IntPtr(num3);
						array14[num18].pSecurityDescriptor = Marshal.ReadIntPtr(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array15 = array;
						int num19 = i;
						ptr = new IntPtr(num3);
						array15[num19].Attributes = (uint)((int)Marshal.ReadIntPtr(ptr));
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array16 = array;
						int num20 = i;
						ptr = new IntPtr(num3);
						array16[num20].Priority = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array17 = array;
						int num21 = i;
						ptr = new IntPtr(num3);
						array17[num21].DefaultPriority = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array18 = array;
						int num22 = i;
						ptr = new IntPtr(num3);
						array18[num22].StartTime = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array19 = array;
						int num23 = i;
						ptr = new IntPtr(num3);
						array19[num23].UntilTime = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array20 = array;
						int num24 = i;
						ptr = new IntPtr(num3);
						array20[num24].Status = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array21 = array;
						int num25 = i;
						ptr = new IntPtr(num3);
						array21[num25].cJobs = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
						PrinterSet.PRINTER_INFO_2[] array22 = array;
						int num26 = i;
						ptr = new IntPtr(num3);
						array22[num26].AveragePPM = (uint)Marshal.ReadInt32(ptr);
						num3 += 4;
					}
					Marshal.FreeHGlobal(intPtr);
					result = array;
				}
				else
				{
					result = new PrinterSet.PRINTER_INFO_2[0];
				}
				return result;
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000EB2C4 File Offset: 0x000E94C4
		public static bool FormInPrinter(string PrinterName, string PaperName)
		{
			bool result = false;
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = PrinterName;
			try
			{
				foreach (object obj in printDocument.PrinterSettings.PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (String.Compare(paperSize.PaperName, PaperName, false) == 0)
					{
						result = true;
						break;
					}
				}
			}
			finally
			{
				
			}
			printDocument.Dispose();
			return result;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000EB354 File Offset: 0x000E9554
		public static bool FormSameSize(string PrinterName, string FormName, decimal Width, decimal Height)
		{
			bool result = false;
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = PrinterName;
			try
			{
				foreach (object obj in printDocument.PrinterSettings.PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (String.Compare(paperSize.PaperName, FormName, false) == 0)
					{
						decimal d = decimal.Multiply(PrinterSet.FromInchToCM(Convert.ToDecimal(paperSize.Width)), 10m);
						decimal d2 = decimal.Multiply(PrinterSet.FromInchToCM(Convert.ToDecimal(paperSize.Height)), 10m);
						if (decimal.Compare(Math.Round(d, 0), Math.Round(Width, 0)) == 0 && decimal.Compare(Math.Round(d2, 0), Math.Round(Height, 0)) == 0)
						{
							result = true;
						}
						break;
					}
				}
			}
			finally
			{
			}
			printDocument.Dispose();
			return result;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x000EB45C File Offset: 0x000E965C
		private static decimal FromInchToCM(decimal inch)
		{
			return Math.Round(decimal.Multiply(Convert.ToDecimal(decimal.Divide(inch, 100m)), Convert.ToDecimal(2.54)), 2);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000EB4A0 File Offset: 0x000E96A0
		public static string GetDeaultPrinterName()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int capacity = stringBuilder.Capacity;
			StringBuilder pszBuffer = stringBuilder;
			int num = capacity;
			string result;
			if (PrinterSet.GetDefaultPrinter(pszBuffer, ref num))
			{
				result = stringBuilder.ToString();
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06001D3F RID: 7487
		[DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool GetDefaultPrinter(StringBuilder pszBuffer, ref int size);

		// Token: 0x06001D40 RID: 7488
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
		internal static extern int GetLastError();

		// Token: 0x06001D41 RID: 7489
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern bool GetPrinterA(IntPtr hPrinter, int dwLevel, IntPtr pPrinter, int dwBuf, out int dwNeeded);

		// Token: 0x06001D42 RID: 7490 RVA: 0x000EB4DC File Offset: 0x000E96DC
		public static ArrayList GetPrinterList()
		{
			ArrayList arrayList = new ArrayList();
			PrinterSet.PRINTER_INFO_2[] array = PrinterSet.EnumPrintersByFlag(PrinterSet.PrinterEnumFlags.PRINTER_ENUM_LOCAL);
			int num = 0;
			checked
			{
				int num2 = array.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					arrayList.Add(array[i].pPrinterName);
				}
				return arrayList;
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000EB520 File Offset: 0x000E9720
		public static string GetPrinterStatus(string PrinterName)
		{
			int printerStatusInt = PrinterSet.GetPrinterStatusInt(PrinterName);
			int num = printerStatusInt;
			string result;
			if (num == 32)
			{
				result = "手工送纸（Manual Feed）";
			}
			else if (num == 64)
			{
				result = "纸张问题（Page Problem）";
			}
			else if (num == 128)
			{
				result = "脱机（Off Line）";
			}
			else if (num == 0)
			{
				result = "准备就绪（Ready）";
			}
			else if (num == 1)
			{
				result = "暂停（Paused）";
			}
			else if (num == 2)
			{
				result = "错误(Printer Error）";
			}
			else if (num == 4)
			{
				result = "正在删除（Pending Deletion）";
			}
			else if (num == 8)
			{
				result = "塞纸（Paper Jam）";
			}
			else if (num == 16)
			{
				result = "打印纸用完（Paper Out）";
			}
			else if (num == 256)
			{
				result = "正在输入或输出（I/O Active）";
			}
			else if (num == 512)
			{
				result = "忙(Busy）";
			}
			else if (num == 1024)
			{
				result = "正在打印（Printing）";
			}
			else if (num == 2048)
			{
				result = "输出口已满（Output Bin Full）";
			}
			else if (num == 4096)
			{
				result = "不可用（Not Available）";
			}
			else if (num == 65536)
			{
				result = "正在准备（Warming Up）";
			}
			else if (num == 131072)
			{
				result = "墨粉不足（Toner Low）";
			}
			else if (num == 262144)
			{
				result = "无墨粉（No Toner）";
			}
			else if (num == 16384)
			{
				result = "正在处理（Processing）";
			}
			else if (num == 32768)
			{
				result = "正在初始化(Initializing）";
			}
			else if (num == 524288)
			{
				result = "当前页无法打印（Page Punt）";
			}
			else if (num == 1048576)
			{
				result = "需要用户干预（User Intervention）";
			}
			else if (num == 2097152)
			{
				result = "内存溢出（Out of Memory）";
			}
			else if (num == 4194304)
			{
				result = "门被打开（Printer Door Open）";
			}
			else if (num == 536870912)
			{
				result = "等待（Waiting）";
			}
			else
			{
				result = "未知状态（Unknown Status）";
			}
			return result;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000EB6D0 File Offset: 0x000E98D0
		internal static int GetPrinterStatusInt(string PrinterName)
		{
			int result = 0;
			PrinterSet.structPrinterDefaults structPrinterDefaults = default(PrinterSet.structPrinterDefaults);
			IntPtr intPtr;
			if (PrinterSet.OpenPrinter(PrinterName, out intPtr, ref structPrinterDefaults))
			{
				int num = 0;
				PrinterSet.GetPrinterA(intPtr, 2, IntPtr.Zero, 0, out num);
				if (num > 0)
				{
					IntPtr intPtr2 = Marshal.AllocHGlobal(num);
					if (PrinterSet.GetPrinterA(intPtr, 2, intPtr2, num, out num))
					{
						PrinterSet.PRINTER_INFO_2 printer_INFO_ = default(PrinterSet.PRINTER_INFO_2);
						printer_INFO_ = (PrinterSet.PRINTER_INFO_2)Marshal.PtrToStructure(intPtr2, typeof(PrinterSet.PRINTER_INFO_2));
						result = Convert.ToInt32(printer_INFO_.Status);
					}
					Marshal.FreeHGlobal(intPtr2);
				}
				PrinterSet.ClosePrinter(intPtr);
			}
			return result;
		}

		// Token: 0x06001D45 RID: 7493
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPTStr)] string printerName, out IntPtr phPrinter, ref PrinterSet.structPrinterDefaults pd);

		// Token: 0x06001D46 RID: 7494 RVA: 0x000EB768 File Offset: 0x000E9968
		public static bool PrinterInList(string PrinterName)
		{
			bool result = false;
			ArrayList printerList = PrinterSet.GetPrinterList();
			int num = 0;
			checked
			{
				int num2 = printerList.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (String.Compare(PrinterName, printerList[i].ToString(), false) == 0)
					{
						result = true;
						
						printerList.Clear();
						
					}
				}
				return result;
			}
		}

		// Token: 0x06001D47 RID: 7495
		[SuppressUnmanagedCodeSecurity]
		[DllImport("GDI32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr ResetDC(IntPtr hDC, ref PrinterSet.structDevMode pDevMode);

		// Token: 0x06001D48 RID: 7496
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr SendMessageTimeout(IntPtr windowHandle, uint Msg, IntPtr wParam, IntPtr lParam, PrinterSet.SendMessageTimeoutFlags flags, uint timeout, out IntPtr result);

		// Token: 0x06001D49 RID: 7497
		[DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern bool SetDefaultPrinter(string Name);

		// Token: 0x06001D4A RID: 7498
		[SuppressUnmanagedCodeSecurity]
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		internal static extern bool SetPrinterA(IntPtr hPrinter, [MarshalAs(UnmanagedType.I4)] int level, IntPtr pPrinter, [MarshalAs(UnmanagedType.I4)] int command);

		// Token: 0x06001D4B RID: 7499 RVA: 0x0000A34A File Offset: 0x0000854A
		public static void SetPrinterToDefault(string PrinterName)
		{
			PrinterSet.SetDefaultPrinter(PrinterName);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000EB7BC File Offset: 0x000E99BC
		public static bool IsValidPrinterName(string printername)
		{
			bool result = false;
			try
			{
				foreach (object value in PrinterSettings.InstalledPrinters)
				{
					string text = Convert.ToString(value);
					text = text;
					if (String.Compare(printername, text, false) == 0)
					{
						result = true;
						break;
					}
				}
			}
			finally
			{
				
			}
			return result;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000EB828 File Offset: 0x000E9A28
		public static ArrayList GetPrinterPaperNames(string printername)
		{
			ArrayList result;
			if (!PrinterSet.IsValidPrinterName(printername))
			{
				result = null;
			}
			else
			{
				ArrayList arrayList = new ArrayList();
				PrintDocument printDocument = new PrintDocument();
				printDocument.PrinterSettings.PrinterName = printername;
				try
				{
					foreach (object obj in printDocument.PrinterSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						arrayList.Add(paperSize.PaperName);
					}
				}
				finally
				{
					
				}
				printDocument.Dispose();
				printDocument = null;
				result = arrayList;
			}
			return result;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000EB8C4 File Offset: 0x000E9AC4
		public static Size GetPrinterPaperSize(string printername, string papername)
		{
			Size result = new Size(0, 0);
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = printername;
			try
			{
				foreach (object obj in printDocument.PrinterSettings.PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (String.Compare(paperSize.PaperName, papername, false) == 0)
					{
						decimal value = decimal.Multiply(PrinterSet.FromInchToCM(Convert.ToDecimal(paperSize.Width)), 10m);
						decimal value2 = decimal.Multiply(PrinterSet.FromInchToCM(Convert.ToDecimal(paperSize.Height)), 10m);
						result.Width = Convert.ToInt32(value);
						result.Height = Convert.ToInt32(value2);
						break;
					}
				}
			}
			finally
			{
				
			}
			printDocument.Dispose();
			return result;
		}

		// Token: 0x04000EB8 RID: 3768
		private const int HWND_BROADCAST = 65535;

		// Token: 0x04000EB9 RID: 3769
		private const int WM_SETTINGCHANGE = 26;

		// Token: 0x0200013A RID: 314
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		internal struct FormInfo1
		{
			// Token: 0x04000EBA RID: 3770
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.I4)]
			public uint Flags;

			// Token: 0x04000EBB RID: 3771
			[FieldOffset(16)]
			public PrinterSet.structRect ImageableArea;

			// Token: 0x04000EBC RID: 3772
			[FieldOffset(4)]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pName;

			// Token: 0x04000EBD RID: 3773
			[FieldOffset(8)]
			public PrinterSet.structSize Size;
		}

		// Token: 0x0200013B RID: 315
		internal struct PRINTER_INFO_2
		{
			// Token: 0x04000EBE RID: 3774
			public string pServerName;

			// Token: 0x04000EBF RID: 3775
			public string pPrinterName;

			// Token: 0x04000EC0 RID: 3776
			public string pShareName;

			// Token: 0x04000EC1 RID: 3777
			public string pPortName;

			// Token: 0x04000EC2 RID: 3778
			public string pDriverName;

			// Token: 0x04000EC3 RID: 3779
			public string pComment;

			// Token: 0x04000EC4 RID: 3780
			public string pLocation;

			// Token: 0x04000EC5 RID: 3781
			public IntPtr pDevMode;

			// Token: 0x04000EC6 RID: 3782
			public string pSepFile;

			// Token: 0x04000EC7 RID: 3783
			public string pPrintProcessor;

			// Token: 0x04000EC8 RID: 3784
			public string pDatatype;

			// Token: 0x04000EC9 RID: 3785
			public string pParameters;

			// Token: 0x04000ECA RID: 3786
			public IntPtr pSecurityDescriptor;

			// Token: 0x04000ECB RID: 3787
			public uint Attributes;

			// Token: 0x04000ECC RID: 3788
			public uint Priority;

			// Token: 0x04000ECD RID: 3789
			public uint DefaultPriority;

			// Token: 0x04000ECE RID: 3790
			public uint StartTime;

			// Token: 0x04000ECF RID: 3791
			public uint UntilTime;

			// Token: 0x04000ED0 RID: 3792
			public uint Status;

			// Token: 0x04000ED1 RID: 3793
			public uint cJobs;

			// Token: 0x04000ED2 RID: 3794
			public uint AveragePPM;
		}

		// Token: 0x0200013C RID: 316
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct PRINTER_INFO_9
		{
			// Token: 0x04000ED3 RID: 3795
			public IntPtr pDevMode;
		}

		// Token: 0x0200013D RID: 317
		[Flags]
		internal enum PrinterEnumFlags
		{
			// Token: 0x04000ED5 RID: 3797
			PRINTER_ENUM_CONNECTIONS = 4,
			// Token: 0x04000ED6 RID: 3798
			PRINTER_ENUM_CONTAINER = 32768,
			// Token: 0x04000ED7 RID: 3799
			PRINTER_ENUM_DEFAULT = 1,
			// Token: 0x04000ED8 RID: 3800
			PRINTER_ENUM_EXPAND = 16384,
			// Token: 0x04000ED9 RID: 3801
			PRINTER_ENUM_FAVORITE = 4,
			// Token: 0x04000EDA RID: 3802
			PRINTER_ENUM_HIDE = 16777216,
			// Token: 0x04000EDB RID: 3803
			PRINTER_ENUM_ICON1 = 65536,
			// Token: 0x04000EDC RID: 3804
			PRINTER_ENUM_ICON2 = 131072,
			// Token: 0x04000EDD RID: 3805
			PRINTER_ENUM_ICON3 = 262144,
			// Token: 0x04000EDE RID: 3806
			PRINTER_ENUM_ICON4 = 524288,
			// Token: 0x04000EDF RID: 3807
			PRINTER_ENUM_ICON5 = 1048576,
			// Token: 0x04000EE0 RID: 3808
			PRINTER_ENUM_ICON6 = 2097152,
			// Token: 0x04000EE1 RID: 3809
			PRINTER_ENUM_ICON7 = 4194304,
			// Token: 0x04000EE2 RID: 3810
			PRINTER_ENUM_ICON8 = 8388608,
			// Token: 0x04000EE3 RID: 3811
			PRINTER_ENUM_ICONMASK = 16711680,
			// Token: 0x04000EE4 RID: 3812
			PRINTER_ENUM_LOCAL = 2,
			// Token: 0x04000EE5 RID: 3813
			PRINTER_ENUM_NAME = 8,
			// Token: 0x04000EE6 RID: 3814
			PRINTER_ENUM_NETWORK = 64,
			// Token: 0x04000EE7 RID: 3815
			PRINTER_ENUM_REMOTE = 16,
			// Token: 0x04000EE8 RID: 3816
			PRINTER_ENUM_SHARED = 32
		}

		// Token: 0x0200013E RID: 318
		[Flags]
		internal enum PrinterStatus
		{
			// Token: 0x04000EEA RID: 3818
			PRINTER_STATUS_BUSY = 512,
			// Token: 0x04000EEB RID: 3819
			PRINTER_STATUS_DOOR_OPEN = 4194304,
			// Token: 0x04000EEC RID: 3820
			PRINTER_STATUS_ERROR = 2,
			// Token: 0x04000EED RID: 3821
			PRINTER_STATUS_INITIALIZING = 32768,
			// Token: 0x04000EEE RID: 3822
			PRINTER_STATUS_IO_ACTIVE = 256,
			// Token: 0x04000EEF RID: 3823
			PRINTER_STATUS_MANUAL_FEED = 32,
			// Token: 0x04000EF0 RID: 3824
			PRINTER_STATUS_NO_TONER = 262144,
			// Token: 0x04000EF1 RID: 3825
			PRINTER_STATUS_NOT_AVAILABLE = 4096,
			// Token: 0x04000EF2 RID: 3826
			PRINTER_STATUS_OFFLINE = 128,
			// Token: 0x04000EF3 RID: 3827
			PRINTER_STATUS_OUT_OF_MEMORY = 2097152,
			// Token: 0x04000EF4 RID: 3828
			PRINTER_STATUS_OUTPUT_BIN_FULL = 2048,
			// Token: 0x04000EF5 RID: 3829
			PRINTER_STATUS_PAGE_PUNT = 524288,
			// Token: 0x04000EF6 RID: 3830
			PRINTER_STATUS_PAPER_JAM = 8,
			// Token: 0x04000EF7 RID: 3831
			PRINTER_STATUS_PAPER_OUT = 16,
			// Token: 0x04000EF8 RID: 3832
			PRINTER_STATUS_PAPER_PROBLEM = 64,
			// Token: 0x04000EF9 RID: 3833
			PRINTER_STATUS_PAUSED = 1,
			// Token: 0x04000EFA RID: 3834
			PRINTER_STATUS_PENDING_DELETION = 4,
			// Token: 0x04000EFB RID: 3835
			PRINTER_STATUS_PRINTING = 1024,
			// Token: 0x04000EFC RID: 3836
			PRINTER_STATUS_PROCESSING = 16384,
			// Token: 0x04000EFD RID: 3837
			PRINTER_STATUS_TONER_LOW = 131072,
			// Token: 0x04000EFE RID: 3838
			PRINTER_STATUS_USER_INTERVENTION = 1048576,
			// Token: 0x04000EFF RID: 3839
			PRINTER_STATUS_WAITING = 536870912,
			// Token: 0x04000F00 RID: 3840
			PRINTER_STATUS_WARMING_UP = 65536
		}

		// Token: 0x0200013F RID: 319
		[Flags]
		internal enum SendMessageTimeoutFlags : uint
		{
			// Token: 0x04000F02 RID: 3842
			SMTO_ABORTIFHUNG = 2U,
			// Token: 0x04000F03 RID: 3843
			SMTO_BLOCK = 1U,
			// Token: 0x04000F04 RID: 3844
			SMTO_NORMAL = 0U,
			// Token: 0x04000F05 RID: 3845
			SMTO_NOTIMEOUTIFNOTHUNG = 8U
		}

		// Token: 0x02000140 RID: 320
		internal struct structDevMode
		{
			// Token: 0x04000F06 RID: 3846
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmDeviceName;

			// Token: 0x04000F07 RID: 3847
			[MarshalAs(UnmanagedType.U2)]
			public short dmSpecVersion;

			// Token: 0x04000F08 RID: 3848
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverVersion;

			// Token: 0x04000F09 RID: 3849
			[MarshalAs(UnmanagedType.U2)]
			public short dmSize;

			// Token: 0x04000F0A RID: 3850
			[MarshalAs(UnmanagedType.U2)]
			public short dmDriverExtra;

			// Token: 0x04000F0B RID: 3851
			[MarshalAs(UnmanagedType.U4)]
			public int dmFields;

			// Token: 0x04000F0C RID: 3852
			[MarshalAs(UnmanagedType.I2)]
			public short dmOrientation;

			// Token: 0x04000F0D RID: 3853
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperSize;

			// Token: 0x04000F0E RID: 3854
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperLength;

			// Token: 0x04000F0F RID: 3855
			[MarshalAs(UnmanagedType.I2)]
			public short dmPaperWidth;

			// Token: 0x04000F10 RID: 3856
			[MarshalAs(UnmanagedType.I2)]
			public short dmScale;

			// Token: 0x04000F11 RID: 3857
			[MarshalAs(UnmanagedType.I2)]
			public short dmCopies;

			// Token: 0x04000F12 RID: 3858
			[MarshalAs(UnmanagedType.I2)]
			public short dmDefaultSource;

			// Token: 0x04000F13 RID: 3859
			[MarshalAs(UnmanagedType.I2)]
			public short dmPrintQuality;

			// Token: 0x04000F14 RID: 3860
			[MarshalAs(UnmanagedType.I2)]
			public short dmColor;

			// Token: 0x04000F15 RID: 3861
			[MarshalAs(UnmanagedType.I2)]
			public short dmDuplex;

			// Token: 0x04000F16 RID: 3862
			[MarshalAs(UnmanagedType.I2)]
			public short dmYResolution;

			// Token: 0x04000F17 RID: 3863
			[MarshalAs(UnmanagedType.I2)]
			public short dmTTOption;

			// Token: 0x04000F18 RID: 3864
			[MarshalAs(UnmanagedType.I2)]
			public short dmCollate;

			// Token: 0x04000F19 RID: 3865
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmFormName;

			// Token: 0x04000F1A RID: 3866
			[MarshalAs(UnmanagedType.U2)]
			public short dmLogPixels;

			// Token: 0x04000F1B RID: 3867
			[MarshalAs(UnmanagedType.U4)]
			public int dmBitsPerPel;

			// Token: 0x04000F1C RID: 3868
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsWidth;

			// Token: 0x04000F1D RID: 3869
			[MarshalAs(UnmanagedType.U4)]
			public int dmPelsHeight;

			// Token: 0x04000F1E RID: 3870
			[MarshalAs(UnmanagedType.U4)]
			public int dmNup;

			// Token: 0x04000F1F RID: 3871
			[MarshalAs(UnmanagedType.U4)]
			public int dmDisplayFrequency;

			// Token: 0x04000F20 RID: 3872
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMMethod;

			// Token: 0x04000F21 RID: 3873
			[MarshalAs(UnmanagedType.U4)]
			public int dmICMIntent;

			// Token: 0x04000F22 RID: 3874
			[MarshalAs(UnmanagedType.U4)]
			public int dmMediaType;

			// Token: 0x04000F23 RID: 3875
			[MarshalAs(UnmanagedType.U4)]
			public int dmDitherType;

			// Token: 0x04000F24 RID: 3876
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved1;

			// Token: 0x04000F25 RID: 3877
			[MarshalAs(UnmanagedType.U4)]
			public int dmReserved2;
		}

		// Token: 0x02000141 RID: 321
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct structPrinterDefaults
		{
			// Token: 0x04000F26 RID: 3878
			[MarshalAs(UnmanagedType.LPTStr)]
			public string pDatatype;

			// Token: 0x04000F27 RID: 3879
			public IntPtr pDevMode;

			// Token: 0x04000F28 RID: 3880
			[MarshalAs(UnmanagedType.I4)]
			public int DesiredAccess;
		}

		// Token: 0x02000142 RID: 322
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct structRect
		{
			// Token: 0x04000F29 RID: 3881
			public int left;

			// Token: 0x04000F2A RID: 3882
			public int top;

			// Token: 0x04000F2B RID: 3883
			public int right;

			// Token: 0x04000F2C RID: 3884
			public int bottom;
		}

		// Token: 0x02000143 RID: 323
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct structSize
		{
			// Token: 0x04000F2D RID: 3885
			public int width;

			// Token: 0x04000F2E RID: 3886
			public int height;
		}
	}
}
