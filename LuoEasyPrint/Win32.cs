using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000061 RID: 97
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	public class Win32
	{
		// Token: 0x06000DAF RID: 3503 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
		public static void ChangeByteOrder(byte[] charArray)
		{
			checked
			{
				for (int i = 0; i < charArray.Length; i += 2)
				{
					byte b = charArray[i];
					charArray[i] = charArray[i + 1];
					charArray[i + 1] = b;
				}
			}
		}

		// Token: 0x06000DB0 RID: 3504
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hObject);

		// Token: 0x06000DB1 RID: 3505
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		// Token: 0x06000DB2 RID: 3506
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref Win32.SendCmdInParams lpInBuffer, uint nInBufferSize, ref Win32.SendCmdOutParams lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, [Out] IntPtr lpOverlapped);

		// Token: 0x06000DB3 RID: 3507
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, ref Win32.GetVersionOutParams lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, [Out] IntPtr lpOverlapped);

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0006DC08 File Offset: 0x0006BE08
		private static Win32.Platform GetCurrentPlatform()
		{
			OperatingSystem osversion = Environment.OSVersion;
			Win32.Platform result;
			switch (osversion.Platform)
			{
			case PlatformID.Win32Windows:
			{
				int minor = osversion.Version.Minor;
				if (minor == 0)
				{
					result = Win32.Platform.Windows95;
				}
				else if (minor == 10)
				{
					if (String.Compare(osversion.Version.Revision.ToString(), "2222A", false) == 0)
					{
						result = Win32.Platform.Windows982ndEdition;
					}
					else
					{
						result = Win32.Platform.Windows98;
					}
				}
				else if (minor == 90)
				{
					result = Win32.Platform.WindowsME;
				}
				else
				{
					result = Win32.Platform.UnKnown;
				}
				break;
			}
			case PlatformID.Win32NT:
				switch (osversion.Version.Major)
				{
				case 3:
					result = Win32.Platform.WindowsNT351;
					break;
				case 4:
					result = Win32.Platform.WindowsNT40;
					break;
				case 5:
					if (osversion.Version.Minor == 0)
					{
						result = Win32.Platform.Windows2000;
					}
					else if (osversion.Version.Minor == 1)
					{
						result = Win32.Platform.WindowsXP;
					}
					else if (osversion.Version.Minor == 2)
					{
						result = Win32.Platform.Windows2003;
					}
					else
					{
						result = Win32.Platform.UnKnown;
					}
					break;
				default:
					result = Win32.Platform.UnKnown;
					break;
				}
				break;
			case PlatformID.WinCE:
				result = Win32.Platform.WindowsCE;
				break;
			default:
				result = Win32.Platform.UnKnown;
				break;
			}
			return result;
		}

		// Token: 0x06000DB5 RID: 3509
		[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern int GetDeviceCaps(HandleRef hDC, int nIndex);

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0006DCFC File Offset: 0x0006BEFC
		private static Win32.HDiskInfo GetHardDiskInfo(Win32.IdSector phdinfo)
		{
			return checked(new Win32.HDiskInfo
			{
				ModuleNumber = Encoding.ASCII.GetString(phdinfo.sModelNumber).Trim(),
				Firmware = Encoding.ASCII.GetString(phdinfo.sFirmwareRev).Trim(),
				SerialNumber = Encoding.ASCII.GetString(phdinfo.sSerialNumber).Trim(),
				Capacity = (uint)Math.Round(phdinfo.ulTotalAddressableSectors / 2.0 / 1024.0),
				BufferSize = (int)Math.Round((double)phdinfo.wBufferSize / 1024.0)
			});
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
		private static Win32.HDiskInfo GetHddInfo9X(byte driveIndex)
		{
			Win32.GetVersionOutParams getVersionOutParams = default(Win32.GetVersionOutParams);
			Win32.SendCmdInParams sendCmdInParams = default(Win32.SendCmdInParams);
			Win32.SendCmdOutParams sendCmdOutParams = default(Win32.SendCmdOutParams);
			uint num = 0U;
			IntPtr intPtr = Win32.CreateFile("\\\\.\\Smartvsd", 0U, 0U, IntPtr.Zero, 1U, 0U, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				throw new UnauthorizedAccessException("打开 smartvsd.vxd 文件失败。");
			}
			int num2 = 0;
			IntPtr hDevice = intPtr;
			uint dwIoControlCode = 475264U;
			IntPtr zero = IntPtr.Zero;
			uint nInBufferSize = 0U;
			Win32.GetVersionOutParams getVersionOutParams2 = getVersionOutParams;
			uint nOutBufferSize = checked((uint)Marshal.SizeOf(getVersionOutParams));
			uint num3 = num;
			if (num2 == Win32.DeviceIoControl(hDevice, dwIoControlCode, zero, nInBufferSize, ref getVersionOutParams2, nOutBufferSize, ref num3, IntPtr.Zero))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException(string.Format("Properties.Resources.Win32_DeviceIoControlErr", "SMART_GET_VERSION"));
			}
			if (0UL == ((ulong)getVersionOutParams.fCapabilities & 1UL))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException("Properties.Resources.Win32_DeviceIoControlNotSupport");
			}
			if (0 != (driveIndex & 1))
			{
				sendCmdInParams.irDriveRegs.bDriveHeadReg = 176;
			}
			else
			{
				sendCmdInParams.irDriveRegs.bDriveHeadReg = 160;
			}
			if (0UL != ((ulong)getVersionOutParams.fCapabilities & (ulong)((long)(16 >> (int)driveIndex))))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException("Properties.Resources.Win32_DeviceIoControlNotSupport");
			}
			sendCmdInParams.irDriveRegs.bCommandReg = 236;
			sendCmdInParams.bDriveNumber = driveIndex;
			sendCmdInParams.irDriveRegs.bSectorCountReg = 1;
			sendCmdInParams.irDriveRegs.bSectorNumberReg = 1;
			sendCmdInParams.cBufferSize = 512U;
			int num4 = 0;
			IntPtr hDevice2 = intPtr;
			uint dwIoControlCode2 = 508040U;
			Win32.SendCmdInParams sendCmdInParams2 = sendCmdInParams;
			checked
			{
				uint nInBufferSize2 = (uint)Marshal.SizeOf(sendCmdInParams);
				Win32.SendCmdOutParams sendCmdOutParams2 = sendCmdOutParams;
				uint nOutBufferSize2 = (uint)Marshal.SizeOf(sendCmdOutParams);
				num3 = num;
				if (num4 == Win32.DeviceIoControl(hDevice2, dwIoControlCode2, ref sendCmdInParams2, nInBufferSize2, ref sendCmdOutParams2, nOutBufferSize2, ref num3, IntPtr.Zero))
				{
					Win32.CloseHandle(intPtr);
					throw new IOException(string.Format("Properties.Resources.Win32_DeviceIoControlErr", "SMART_RCV_DRIVE_DATA"));
				}
				Win32.CloseHandle(intPtr);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sModelNumber);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sSerialNumber);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sFirmwareRev);
				return Win32.GetHardDiskInfo(sendCmdOutParams.bBuffer);
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
		private static Win32.HDiskInfo GetHddInfoNT(byte driveIndex)
		{
			Win32.GetVersionOutParams getVersionOutParams = default(Win32.GetVersionOutParams);
			Win32.SendCmdInParams sendCmdInParams = default(Win32.SendCmdInParams);
			Win32.SendCmdOutParams sendCmdOutParams = default(Win32.SendCmdOutParams);
			uint num = 0U;
			IntPtr intPtr = Win32.CreateFile(string.Format("\\\\.\\PhysicalDrive{0}", driveIndex), 3221225472U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				throw new UnauthorizedAccessException("执行 Win32 API 函数 CreateFile 失败。");
			}
			int num2 = 0;
			IntPtr hDevice = intPtr;
			uint dwIoControlCode = 475264U;
			IntPtr zero = IntPtr.Zero;
			uint nInBufferSize = 0U;
			Win32.GetVersionOutParams getVersionOutParams2 = getVersionOutParams;
			uint nOutBufferSize = checked((uint)Marshal.SizeOf(getVersionOutParams));
			uint num3 = num;
			if (num2 == Win32.DeviceIoControl(hDevice, dwIoControlCode, zero, nInBufferSize, ref getVersionOutParams2, nOutBufferSize, ref num3, IntPtr.Zero))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException(string.Format("Properties.Resources.Win32_DeviceIoControlErr", "SMART_GET_VERSION"));
			}
			if (0UL == ((ulong)getVersionOutParams.fCapabilities & 1UL))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException("Properties.Resources.Win32_DeviceIoControlNotSupport");
			}
			if (0 != (driveIndex & 1))
			{
				sendCmdInParams.irDriveRegs.bDriveHeadReg = 176;
			}
			else
			{
				sendCmdInParams.irDriveRegs.bDriveHeadReg = 160;
			}
			if (0UL != ((ulong)getVersionOutParams.fCapabilities & (ulong)((long)(16 >> (int)driveIndex))))
			{
				Win32.CloseHandle(intPtr);
				throw new IOException("Properties.Resources.Win32_DeviceIoControlNotSupport");
			}
			sendCmdInParams.irDriveRegs.bCommandReg = 236;
			sendCmdInParams.bDriveNumber = driveIndex;
			sendCmdInParams.irDriveRegs.bSectorCountReg = 1;
			sendCmdInParams.irDriveRegs.bSectorNumberReg = 1;
			sendCmdInParams.cBufferSize = 512U;
			int num4 = 0;
			IntPtr hDevice2 = intPtr;
			uint dwIoControlCode2 = 508040U;
			Win32.SendCmdInParams sendCmdInParams2 = sendCmdInParams;
			checked
			{
				uint nInBufferSize2 = (uint)Marshal.SizeOf(sendCmdInParams);
				Win32.SendCmdOutParams sendCmdOutParams2 = sendCmdOutParams;
				uint nOutBufferSize2 = (uint)Marshal.SizeOf(sendCmdOutParams);
				num3 = num;
				if (num4 == Win32.DeviceIoControl(hDevice2, dwIoControlCode2, ref sendCmdInParams2, nInBufferSize2, ref sendCmdOutParams2, nOutBufferSize2, ref num3, IntPtr.Zero))
				{
					Win32.CloseHandle(intPtr);
					throw new IOException(string.Format("Properties.Resources.Win32_DeviceIoControlErr", "SMART_RCV_DRIVE_DATA"));
				}
				Win32.CloseHandle(intPtr);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sModelNumber);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sSerialNumber);
				Win32.ChangeByteOrder(sendCmdOutParams.bBuffer.sFirmwareRev);
				return Win32.GetHardDiskInfo(sendCmdOutParams.bBuffer);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public static Win32.HDiskInfo GetHddInformation()
		{
			switch (Win32.currentOs)
			{
			case Win32.Platform.Windows982ndEdition:
			case Win32.Platform.WindowsME:
				return Win32.GetHddInfo9X(0);
			case Win32.Platform.Windows2000:
			case Win32.Platform.WindowsXP:
			case Win32.Platform.Windows2003:
				return Win32.GetHddInfoNT(0);
			case Win32.Platform.UnKnown:
				throw new PlatformNotSupportedException("当前操作系统平台未知");
			}
			throw new PlatformNotSupportedException(string.Format("不支持当前操作系统平台", Win32.currentOs.ToString()));
		}

		// Token: 0x06000DBA RID: 3514
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetMenuItemCount(IntPtr hMenu);

		// Token: 0x06000DBB RID: 3515
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetSystemMenu(IntPtr hwnd, bool bRevert);

		// Token: 0x06000DBC RID: 3516 RVA: 0x0006E258 File Offset: 0x0006C458
		public static int HIWORD(int n)
		{
			return n >> 16 & 65535;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0006E274 File Offset: 0x0006C474
		public static int HIWORD(IntPtr n)
		{
			return Win32.HIWORD(checked((int)((long)n)));
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0006E290 File Offset: 0x0006C490
		public static int LOWORD(int n)
		{
			return n & 65535;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0006E2A8 File Offset: 0x0006C4A8
		public static int LOWORD(IntPtr n)
		{
			return Win32.LOWORD(checked((int)((long)n)));
		}

		// Token: 0x06000DC0 RID: 3520
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int RemoveMenu(IntPtr hMenu, int uPosition, int uFlags);

		// Token: 0x06000DC1 RID: 3521
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern bool ScrollWindow(HandleRef hWnd, int nXAmount, int nYAmount, ref Win32.RECT rectScrollRegion, ref Win32.RECT rectClip);

		// Token: 0x06000DC2 RID: 3522
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern int SetScrollInfo(HandleRef hWnd, int fnBar, Win32.SCROLLINFO si, bool redraw);

		// Token: 0x06000DC3 RID: 3523
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern int SetScrollPos(HandleRef hWnd, int nBar, int nPos, bool bRedraw);

		// Token: 0x0400067F RID: 1663
		private const uint BUFFER_SIZE = 512U;

		// Token: 0x04000680 RID: 1664
		private const uint CREATE_NEW = 1U;

		// Token: 0x04000681 RID: 1665
		private static readonly Win32.Platform currentOs = Win32.GetCurrentPlatform();

		// Token: 0x04000682 RID: 1666
		private const uint FILE_SHARE_DELETE = 4U;

		// Token: 0x04000683 RID: 1667
		private const uint FILE_SHARE_READ = 1U;

		// Token: 0x04000684 RID: 1668
		private const uint FILE_SHARE_WRITE = 2U;

		// Token: 0x04000685 RID: 1669
		private const uint GENERIC_READ = 2147483648U;

		// Token: 0x04000686 RID: 1670
		private const uint GENERIC_WRITE = 1073741824U;

		// Token: 0x04000687 RID: 1671
		private const int MF_BYPOSITION = 1024;

		// Token: 0x04000688 RID: 1672
		private const uint OPEN_EXISTING = 3U;

		// Token: 0x04000689 RID: 1673
		private const uint SMART_GET_VERSION = 475264U;

		// Token: 0x0400068A RID: 1674
		private const uint SMART_RCV_DRIVE_DATA = 508040U;

		// Token: 0x0400068B RID: 1675
		private const uint SMART_SEND_DRIVE_COMMAND = 508036U;

		// Token: 0x02000062 RID: 98
		private enum DriverError : byte
		{
			// Token: 0x0400068D RID: 1677
			SMART_ERROR_NO_MEM = 7,
			// Token: 0x0400068E RID: 1678
			SMART_IDE_ERROR = 1,
			// Token: 0x0400068F RID: 1679
			SMART_INVALID_BUFFER = 4,
			// Token: 0x04000690 RID: 1680
			SMART_INVALID_COMMAND = 3,
			// Token: 0x04000691 RID: 1681
			SMART_INVALID_DRIVE = 5,
			// Token: 0x04000692 RID: 1682
			SMART_INVALID_FLAG = 2,
			// Token: 0x04000693 RID: 1683
			SMART_INVALID_IOCTL = 6,
			// Token: 0x04000694 RID: 1684
			SMART_INVALID_REGISTER = 8,
			// Token: 0x04000695 RID: 1685
			SMART_NO_ERROR = 0,
			// Token: 0x04000696 RID: 1686
			SMART_NO_IDE_DEVICE = 10,
			// Token: 0x04000697 RID: 1687
			SMART_NOT_SUPPORTED = 9
		}

		// Token: 0x02000063 RID: 99
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct DriverStatus
		{
			// Token: 0x04000698 RID: 1688
			public byte bDriverError;

			// Token: 0x04000699 RID: 1689
			public byte bIDEStatus;

			// Token: 0x0400069A RID: 1690
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] bReserved;

			// Token: 0x0400069B RID: 1691
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public uint[] dwReserved;
		}

		// Token: 0x02000064 RID: 100
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct GetVersionOutParams
		{
			// Token: 0x0400069C RID: 1692
			public byte bVersion;

			// Token: 0x0400069D RID: 1693
			public byte bRevision;

			// Token: 0x0400069E RID: 1694
			public byte bReserved;

			// Token: 0x0400069F RID: 1695
			public byte bIDEDeviceMap;

			// Token: 0x040006A0 RID: 1696
			public uint fCapabilities;

			// Token: 0x040006A1 RID: 1697
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public uint[] dwReserved;
		}

		// Token: 0x02000065 RID: 101
		[Serializable]
		public struct HDiskInfo
		{
			// Token: 0x040006A2 RID: 1698
			public string ModuleNumber;

			// Token: 0x040006A3 RID: 1699
			public string Firmware;

			// Token: 0x040006A4 RID: 1700
			public string SerialNumber;

			// Token: 0x040006A5 RID: 1701
			public uint Capacity;

			// Token: 0x040006A6 RID: 1702
			public int BufferSize;
		}

		// Token: 0x02000066 RID: 102
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct IdeRegs
		{
			// Token: 0x040006A7 RID: 1703
			public byte bFeaturesReg;

			// Token: 0x040006A8 RID: 1704
			public byte bSectorCountReg;

			// Token: 0x040006A9 RID: 1705
			public byte bSectorNumberReg;

			// Token: 0x040006AA RID: 1706
			public byte bCylLowReg;

			// Token: 0x040006AB RID: 1707
			public byte bCylHighReg;

			// Token: 0x040006AC RID: 1708
			public byte bDriveHeadReg;

			// Token: 0x040006AD RID: 1709
			public byte bCommandReg;

			// Token: 0x040006AE RID: 1710
			public byte bReserved;
		}

		// Token: 0x02000067 RID: 103
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 512)]
		private struct IdSector
		{
			// Token: 0x040006AF RID: 1711
			public ushort wGenConfig;

			// Token: 0x040006B0 RID: 1712
			public ushort wNumCyls;

			// Token: 0x040006B1 RID: 1713
			public ushort wReserved;

			// Token: 0x040006B2 RID: 1714
			public ushort wNumHeads;

			// Token: 0x040006B3 RID: 1715
			public ushort wBytesPerTrack;

			// Token: 0x040006B4 RID: 1716
			public ushort wBytesPerSector;

			// Token: 0x040006B5 RID: 1717
			public ushort wSectorsPerTrack;

			// Token: 0x040006B6 RID: 1718
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public ushort[] wVendorUnique;

			// Token: 0x040006B7 RID: 1719
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
			public byte[] sSerialNumber;

			// Token: 0x040006B8 RID: 1720
			public ushort wBufferType;

			// Token: 0x040006B9 RID: 1721
			public ushort wBufferSize;

			// Token: 0x040006BA RID: 1722
			public ushort wECCSize;

			// Token: 0x040006BB RID: 1723
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] sFirmwareRev;

			// Token: 0x040006BC RID: 1724
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
			public byte[] sModelNumber;

			// Token: 0x040006BD RID: 1725
			public ushort wMoreVendorUnique;

			// Token: 0x040006BE RID: 1726
			public ushort wDoubleWordIO;

			// Token: 0x040006BF RID: 1727
			public ushort wCapabilities;

			// Token: 0x040006C0 RID: 1728
			public ushort wReserved1;

			// Token: 0x040006C1 RID: 1729
			public ushort wPIOTiming;

			// Token: 0x040006C2 RID: 1730
			public ushort wDMATiming;

			// Token: 0x040006C3 RID: 1731
			public ushort wBS;

			// Token: 0x040006C4 RID: 1732
			public ushort wNumCurrentCyls;

			// Token: 0x040006C5 RID: 1733
			public ushort wNumCurrentHeads;

			// Token: 0x040006C6 RID: 1734
			public ushort wNumCurrentSectorsPerTrack;

			// Token: 0x040006C7 RID: 1735
			public uint ulCurrentSectorCapacity;

			// Token: 0x040006C8 RID: 1736
			public ushort wMultSectorStuff;

			// Token: 0x040006C9 RID: 1737
			public uint ulTotalAddressableSectors;

			// Token: 0x040006CA RID: 1738
			public ushort wSingleWordDMA;

			// Token: 0x040006CB RID: 1739
			public ushort wMultiWordDMA;

			// Token: 0x040006CC RID: 1740
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
			public byte[] bReserved;
		}

		// Token: 0x02000068 RID: 104
		private enum Platform : byte
		{
			// Token: 0x040006CE RID: 1742
			UnKnown = 10,
			// Token: 0x040006CF RID: 1743
			Windows2000 = 6,
			// Token: 0x040006D0 RID: 1744
			Windows2003 = 8,
			// Token: 0x040006D1 RID: 1745
			Windows95 = 0,
			// Token: 0x040006D2 RID: 1746
			Windows98,
			// Token: 0x040006D3 RID: 1747
			Windows982ndEdition,
			// Token: 0x040006D4 RID: 1748
			WindowsCE = 9,
			// Token: 0x040006D5 RID: 1749
			WindowsME = 3,
			// Token: 0x040006D6 RID: 1750
			WindowsNT351,
			// Token: 0x040006D7 RID: 1751
			WindowsNT40,
			// Token: 0x040006D8 RID: 1752
			WindowsXP = 7
		}

		// Token: 0x02000069 RID: 105
		public struct RECT
		{
			// Token: 0x06000DC4 RID: 3524 RVA: 0x000059ED File Offset: 0x00003BED
			public RECT(int left, int top, int right, int bottom)
			{
				this = default(Win32.RECT);
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			// Token: 0x06000DC5 RID: 3525 RVA: 0x00005A13 File Offset: 0x00003C13
			public RECT(Rectangle r)
			{
				this = default(Win32.RECT);
				this.left = r.Left;
				this.top = r.Top;
				this.right = r.Right;
				this.bottom = r.Bottom;
			}

			// Token: 0x06000DC6 RID: 3526 RVA: 0x0006E2C4 File Offset: 0x0006C4C4
			public static Win32.RECT FromXYWH(int x, int y, int width, int height)
			{
				Win32.RECT result = checked(new Win32.RECT(x, y, x + width, y + height));
				return result;
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0006E2E4 File Offset: 0x0006C4E4
			public Size Size
			{
				get
				{
					Size result = checked(new Size(this.right - this.left, this.bottom - this.top));
					return result;
				}
			}

			// Token: 0x040006D9 RID: 1753
			public int left;

			// Token: 0x040006DA RID: 1754
			public int top;

			// Token: 0x040006DB RID: 1755
			public int right;

			// Token: 0x040006DC RID: 1756
			public int bottom;
		}

		// Token: 0x0200006A RID: 106
		[StructLayout(LayoutKind.Sequential)]
		public sealed class SCROLLINFO
		{
			// Token: 0x06000DC8 RID: 3528 RVA: 0x00005A50 File Offset: 0x00003C50
			public SCROLLINFO()
			{
				this.cbSize = Marshal.SizeOf(typeof(Win32.SCROLLINFO));
			}

			// Token: 0x06000DC9 RID: 3529 RVA: 0x0006E318 File Offset: 0x0006C518
			public SCROLLINFO(int mask, int min, int max, int page, int pos)
			{
				this.cbSize = Marshal.SizeOf(typeof(Win32.SCROLLINFO));
				this.fMask = mask;
				this.nMin = min;
				this.nMax = max;
				this.nPage = page;
				this.nPos = pos;
			}

			// Token: 0x040006DD RID: 1757
			public int cbSize;

			// Token: 0x040006DE RID: 1758
			public int fMask;

			// Token: 0x040006DF RID: 1759
			public int nMin;

			// Token: 0x040006E0 RID: 1760
			public int nMax;

			// Token: 0x040006E1 RID: 1761
			public int nPage;

			// Token: 0x040006E2 RID: 1762
			public int nPos;

			// Token: 0x040006E3 RID: 1763
			public int nTrackPos;
		}

		// Token: 0x0200006B RID: 107
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SendCmdInParams
		{
			// Token: 0x040006E4 RID: 1764
			public uint cBufferSize;

			// Token: 0x040006E5 RID: 1765
			public Win32.IdeRegs irDriveRegs;

			// Token: 0x040006E6 RID: 1766
			public byte bDriveNumber;

			// Token: 0x040006E7 RID: 1767
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public byte[] bReserved;

			// Token: 0x040006E8 RID: 1768
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public uint[] dwReserved;

			// Token: 0x040006E9 RID: 1769
			public byte bBuffer;
		}

		// Token: 0x0200006C RID: 108
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SendCmdOutParams
		{
			// Token: 0x040006EA RID: 1770
			public uint cBufferSize;

			// Token: 0x040006EB RID: 1771
			public Win32.DriverStatus DriverStatus;

			// Token: 0x040006EC RID: 1772
			public Win32.IdSector bBuffer;
		}
	}
}
