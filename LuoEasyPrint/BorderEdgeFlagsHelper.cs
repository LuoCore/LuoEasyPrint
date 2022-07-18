using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000C8 RID: 200
	internal sealed class BorderEdgeFlagsHelper
	{
		// Token: 0x0600189D RID: 6301 RVA: 0x000024B1 File Offset: 0x000006B1
		private BorderEdgeFlagsHelper()
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000CA03C File Offset: 0x000C823C
		public static BorderEdgeFlags ConvertFrom(string[] edges)
		{
			BorderEdgeFlags borderEdgeFlags = BorderEdgeFlags.None;
			if (edges.Length > 0)
			{
				borderEdgeFlags = BorderEdgeFlagsHelper.ConvertFrom(edges[0]);
			}
			checked
			{
				if (edges.Length > 1)
				{
					int num = 1;
					int num2 = edges.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						borderEdgeFlags |= BorderEdgeFlagsHelper.ConvertFrom(edges[i]);
					}
				}
				return borderEdgeFlags;
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000CA080 File Offset: 0x000C8280
		public static BorderEdgeFlags ConvertFrom(string edge)
		{
			string text = edge.ToUpper();
			BorderEdgeFlags borderEdgeFlags = BorderEdgeFlags.None;
			string left = text;
			BorderEdgeFlags result;
			if (String.Compare(left, "LEFT", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "Left");
			}
			else if (String.Compare(left, "RIGHT", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "Right");
			}
			else if (String.Compare(left, "TOP", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "Top");
			}
			else if (String.Compare(left, "BOTTOM", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "Bottom");
			}
			else if (String.Compare(left, "HorizontalCenter", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "HorizontalCenter");
			}
			else if (String.Compare(left, "VerticalCenter", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "VerticalCenter");
			}
			else if (String.Compare(left, "DIAGONALDOWN", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "DiagonalDown");
			}
			else if (String.Compare(left, "DIAGONALUP", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "DiagonalUp");
			}
			else if (String.Compare(left, "ELLIPSE", false) == 0)
			{
				result = (BorderEdgeFlags)Enum.Parse(typeof(BorderEdgeFlags), "Ellipse");
			}
			else
			{
				result = borderEdgeFlags;
			}
			return result;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000CA260 File Offset: 0x000C8460
		public static bool IsIncludedBottom(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.Bottom) == BorderEdgeFlags.Bottom;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000CA278 File Offset: 0x000C8478
		public static bool IsIncludedDiagonalDown(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.DiagonalDown) == BorderEdgeFlags.DiagonalDown;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000CA294 File Offset: 0x000C8494
		public static bool IsIncludedDiagonalUp(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.DiagonalUp) == BorderEdgeFlags.DiagonalUp;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000CA2B0 File Offset: 0x000C84B0
		public static bool IsIncludedEllipse(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.Ellipse) == BorderEdgeFlags.Ellipse;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000CA2CC File Offset: 0x000C84CC
		public static bool IsIncludedHorizontalCenter(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.HorizontalCenter) == BorderEdgeFlags.HorizontalCenter;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000CA2E4 File Offset: 0x000C84E4
		public static bool IsIncludedLeft(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.Left) == BorderEdgeFlags.Left;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000CA2F8 File Offset: 0x000C84F8
		public static bool IsIncludedNone(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.None) == BorderEdgeFlags.None;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000CA30C File Offset: 0x000C850C
		public static bool IsIncludedRight(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.Right) == BorderEdgeFlags.Right;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000CA320 File Offset: 0x000C8520
		public static bool IsIncludedTop(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.Top) == BorderEdgeFlags.Top;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000CA334 File Offset: 0x000C8534
		public static bool IsIncludedVerticalCenter(BorderEdgeFlags flags)
		{
			return (flags & BorderEdgeFlags.VerticalCenter) == BorderEdgeFlags.VerticalCenter;
		}
	}
}
