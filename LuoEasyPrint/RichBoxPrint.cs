using Microsoft.VisualBasic.CompilerServices;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace LuoEasyPrint
{
    // Token: 0x02000088 RID: 136
    [StandardModule]
    internal sealed class RichBoxPrint
    {
        // Token: 0x06001226 RID: 4646
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

        // Token: 0x06001227 RID: 4647 RVA: 0x0008F78C File Offset: 0x0008D98C
        public static Image RTBFormatRange(RichTextBox rch, bool measureOnly, float paperwidth, float paperheight, Margins papermargin, int charFrom, int charTo, ref int lastchar, float PIXELSPERINCHX, float PIXELSPERINCHY, ref float printheight)
        {
            RichBoxPrint.STRUCT_CHARRANGE chrg;
            chrg.cpMin = charFrom;
            chrg.cpMax = charTo;
            checked
            {
                RichBoxPrint.STRUCT_RECT rc;
                rc.top = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)((double)papermargin.Top / 10.0)));
                rc.bottom = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)(unchecked((double)paperheight - (double)papermargin.Bottom / 10.0))));
                rc.left = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)((double)papermargin.Left / 10.0)));
                rc.right = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)(unchecked((double)paperwidth - (double)papermargin.Right / 10.0))));
                RichBoxPrint.STRUCT_RECT rcPage;
                rcPage.top = 0;
                rcPage.bottom = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips(paperheight));
                rcPage.left = 0;
                rcPage.right = (int)Math.Round((double)RichBoxPrint.ConvertMMToTwips(paperwidth));
                Bitmap bitmap = new Bitmap((int)Math.Round((double)RichBoxPrint.ConvertFromMM(paperwidth, PIXELSPERINCHX)), (int)Math.Round((double)RichBoxPrint.ConvertFromMM(paperheight, PIXELSPERINCHY)));
                Graphics graphics = Graphics.FromImage(bitmap);
                Graphics graphics2 = graphics;
                Brush brush = new SolidBrush(Color.White);
                Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                graphics2.FillRectangle(brush, rect);
                IntPtr hdc = graphics.GetHdc();
                RichBoxPrint.STRUCT_FORMATRANGE struct_FORMATRANGE;
                struct_FORMATRANGE.chrg = chrg;
                struct_FORMATRANGE.hdc = hdc;
                struct_FORMATRANGE.hdcTarget = hdc;
                struct_FORMATRANGE.rc = rc;
                struct_FORMATRANGE.rcPage = rcPage;
                int wParam;
                if (measureOnly)
                {
                    wParam = 0;
                }
                else
                {
                    wParam = 1;
                }
                IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_FORMATRANGE));
                Marshal.StructureToPtr(struct_FORMATRANGE, intPtr, false);
                int num = RichBoxPrint.SendMessage(rch.Handle, 1081, wParam, intPtr);
                object obj = Marshal.PtrToStructure(intPtr, typeof(RichBoxPrint.STRUCT_FORMATRANGE));
                RichBoxPrint.STRUCT_FORMATRANGE struct_FORMATRANGE2 = new STRUCT_FORMATRANGE();
                struct_FORMATRANGE = ((obj != null) ? ((RichBoxPrint.STRUCT_FORMATRANGE)obj) : struct_FORMATRANGE2);
                printheight = (float)(struct_FORMATRANGE.rc.bottom - struct_FORMATRANGE.rc.top);
                printheight = RichBoxPrint.ConvertTwipsToMM(printheight);
                Marshal.FreeCoTaskMem(intPtr);
                graphics.ReleaseHdc(hdc);
                lastchar = num;
                Image result;
                if (measureOnly)
                {
                    bitmap.Dispose();
                    result = null;
                }
                else
                {
                    Bitmap bitmap2 = new Bitmap((int)Math.Round((double)RichBoxPrint.ConvertFromMM((float)(unchecked((double)paperwidth - (double)papermargin.Left / 10.0 - (double)papermargin.Right / 10.0)), PIXELSPERINCHX)), (int)Math.Round((double)RichBoxPrint.ConvertFromMM((float)(unchecked((double)paperheight - (double)papermargin.Top / 10.0 - (double)papermargin.Bottom / 10.0)), PIXELSPERINCHY)));
                    Graphics graphics3 = Graphics.FromImage(bitmap2);
                    Rectangle srcRect = unchecked(new Rectangle(Convert.ToInt32(RichBoxPrint.ConvertFromMM((float)((double)papermargin.Left / 10.0), PIXELSPERINCHX)), Convert.ToInt32(RichBoxPrint.ConvertFromMM((float)((double)papermargin.Top / 10.0), PIXELSPERINCHY)), Convert.ToInt32(RichBoxPrint.ConvertFromMM((float)((double)paperwidth - (double)papermargin.Left / 10.0 - (double)papermargin.Right / 10.0), PIXELSPERINCHX)), Convert.ToInt32(RichBoxPrint.ConvertFromMM((float)((double)paperheight - (double)papermargin.Top / 10.0 - (double)papermargin.Bottom / 10.0), PIXELSPERINCHY))));
                    graphics3.DrawImage(bitmap, 0, 0, srcRect, GraphicsUnit.Pixel);
                    bitmap.Dispose();
                    result = bitmap2;
                }
                return result;
            }
        }

        // Token: 0x06001228 RID: 4648 RVA: 0x0008FB00 File Offset: 0x0008DD00
        private static int HundredthInchToTwips(float n)
        {
            return Convert.ToInt32((double)n * 14.4);
        }

        // Token: 0x06001229 RID: 4649 RVA: 0x0008FB20 File Offset: 0x0008DD20
        private static float ConvertMMToTwips(float n)
        {
            return (float)RichBoxPrint.HundredthInchToTwips((float)Math.Round((double)(Module1.ConvertMmToInch(n) * 100f), 0));
        }

        // Token: 0x0600122A RID: 4650 RVA: 0x0008FB4C File Offset: 0x0008DD4C
        private static float ConvertTwipsToMM(float n)
        {
            float xx = (float)((double)n / 14.4);
            return Module1.ConvertInchToMm(xx) / 100f;
        }

        // Token: 0x0600122B RID: 4651 RVA: 0x0008FB78 File Offset: 0x0008DD78
        public static void RTBFormatRangeDone(RichTextBox rch)
        {
            IntPtr lParam = new IntPtr(0);
            RichBoxPrint.SendMessage(rch.Handle, 1081, 0, lParam);
        }

        // Token: 0x0600122C RID: 4652 RVA: 0x0008FBA0 File Offset: 0x0008DDA0
        private static float ConvertFromMM(float myw, float PIXELSPERINCH)
        {
            float num = (float)((double)(myw / 10f) / 2.54);
            float num2 = num * PIXELSPERINCH;
            return (float)Math.Floor((double)num2);
        }

        // Token: 0x0600122D RID: 4653 RVA: 0x0008FBD4 File Offset: 0x0008DDD4
        public static float DrawRTF(RichTextBox rch, Graphics g, bool measureOnly, float paperwidth, float paperheight, Margins papermargin, int charFrom, int charTo, ref int lastchar)
        {
            RichBoxPrint.STRUCT_CHARRANGE chrg;
            chrg.cpMin = charFrom;
            chrg.cpMax = charTo;
            checked
            {
                RichBoxPrint.STRUCT_RECT rc;
                rc.top = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)((double)papermargin.Top / 10.0)), 0));
                rc.bottom = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)(unchecked((double)paperheight - (double)papermargin.Bottom / 10.0))), 0));
                rc.left = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)((double)papermargin.Left / 10.0)), 0));
                rc.right = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips((float)(unchecked((double)paperwidth - (double)papermargin.Right / 10.0))), 0));
                RichBoxPrint.STRUCT_RECT rcPage;
                rcPage.top = 0;
                rcPage.bottom = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips(paperheight), 0));
                rcPage.left = 0;
                rcPage.right = (int)Math.Round(Math.Round((double)RichBoxPrint.ConvertMMToTwips(paperwidth), 0));
                IntPtr hdc = g.GetHdc();
                RichBoxPrint.STRUCT_FORMATRANGE struct_FORMATRANGE;
                struct_FORMATRANGE.chrg = chrg;
                struct_FORMATRANGE.hdc = hdc;
                struct_FORMATRANGE.hdcTarget = hdc;
                struct_FORMATRANGE.rc = rc;
                struct_FORMATRANGE.rcPage = rcPage;
                int wParam;
                if (measureOnly)
                {
                    wParam = 0;
                }
                else
                {
                    wParam = 1;
                }
                IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_FORMATRANGE));
                Marshal.StructureToPtr(struct_FORMATRANGE, intPtr, false);
                int num = RichBoxPrint.SendMessage(rch.Handle, 1081, wParam, intPtr);
                object obj = Marshal.PtrToStructure(intPtr, typeof(RichBoxPrint.STRUCT_FORMATRANGE));
                RichBoxPrint.STRUCT_FORMATRANGE struct_FORMATRANGE2=new STRUCT_FORMATRANGE();
                struct_FORMATRANGE = ((obj != null) ? ((RichBoxPrint.STRUCT_FORMATRANGE)obj) : struct_FORMATRANGE2);
                float num2 = (float)(struct_FORMATRANGE.rc.bottom - struct_FORMATRANGE.rc.top);
                num2 = RichBoxPrint.ConvertTwipsToMM(num2);
                Marshal.FreeCoTaskMem(intPtr);
                g.ReleaseHdc(hdc);
                lastchar = num;
                return num2;
            }
        }

        // Token: 0x04000966 RID: 2406
        private const int WM_USER = 1024;

        // Token: 0x04000967 RID: 2407
        private const int EM_FORMATRANGE = 1081;

        // Token: 0x04000968 RID: 2408
        private const int EM_GETCHARFORMAT = 1082;

        // Token: 0x04000969 RID: 2409
        private const int EM_SETCHARFORMAT = 1092;

        // Token: 0x0400096A RID: 2410
        private const long CFM_BOLD = 1L;

        // Token: 0x0400096B RID: 2411
        private const long CFM_ITALIC = 2L;

        // Token: 0x0400096C RID: 2412
        private const long CFM_UNDERLINE = 4L;

        // Token: 0x0400096D RID: 2413
        private const long CFM_STRIKEOUT = 8L;

        // Token: 0x0400096E RID: 2414
        private const long CFM_PROTECTED = 16L;

        // Token: 0x0400096F RID: 2415
        private const long CFM_LINK = 32L;

        // Token: 0x04000970 RID: 2416
        private const long CFM_SIZE = 2147483648L;

        // Token: 0x04000971 RID: 2417
        private const long CFM_COLOR = 1073741824L;

        // Token: 0x04000972 RID: 2418
        private const long CFM_FACE = 536870912L;

        // Token: 0x04000973 RID: 2419
        private const long CFM_OFFSET = 268435456L;

        // Token: 0x04000974 RID: 2420
        private const long CFM_CHARSET = 134217728L;

        // Token: 0x04000975 RID: 2421
        private const long CFE_BOLD = 1L;

        // Token: 0x04000976 RID: 2422
        private const long CFE_ITALIC = 2L;

        // Token: 0x04000977 RID: 2423
        private const long CFE_UNDERLINE = 4L;

        // Token: 0x04000978 RID: 2424
        private const long CFE_STRIKEOUT = 8L;

        // Token: 0x04000979 RID: 2425
        private const long CFE_PROTECTED = 16L;

        // Token: 0x0400097A RID: 2426
        private const long CFE_LINK = 32L;

        // Token: 0x0400097B RID: 2427
        private const long CFE_AUTOCOLOR = 1073741824L;

        // Token: 0x02000089 RID: 137
        private struct STRUCT_RECT
        {
            // Token: 0x0400097C RID: 2428
            public int left;

            // Token: 0x0400097D RID: 2429
            public int top;

            // Token: 0x0400097E RID: 2430
            public int right;

            // Token: 0x0400097F RID: 2431
            public int bottom;
        }

        // Token: 0x0200008A RID: 138
        private struct STRUCT_CHARRANGE
        {
            // Token: 0x04000980 RID: 2432
            public int cpMin;

            // Token: 0x04000981 RID: 2433
            public int cpMax;
        }

        // Token: 0x0200008B RID: 139
        private struct STRUCT_FORMATRANGE
        {
            // Token: 0x04000982 RID: 2434
            public IntPtr hdc;

            // Token: 0x04000983 RID: 2435
            public IntPtr hdcTarget;

            // Token: 0x04000984 RID: 2436
            public RichBoxPrint.STRUCT_RECT rc;

            // Token: 0x04000985 RID: 2437
            public RichBoxPrint.STRUCT_RECT rcPage;

            // Token: 0x04000986 RID: 2438
            public RichBoxPrint.STRUCT_CHARRANGE chrg;
        }

        // Token: 0x0200008C RID: 140
        private struct STRUCT_CHARFORMAT
        {
            // Token: 0x04000987 RID: 2439
            public int cbSize;

            // Token: 0x04000988 RID: 2440
            public uint dwMask;

            // Token: 0x04000989 RID: 2441
            public uint dwEffects;

            // Token: 0x0400098A RID: 2442
            public int yHeight;

            // Token: 0x0400098B RID: 2443
            public int yOffset;

            // Token: 0x0400098C RID: 2444
            public int crTextColor;

            // Token: 0x0400098D RID: 2445
            public byte bCharSet;

            // Token: 0x0400098E RID: 2446
            public byte bPitchAndFamily;

            // Token: 0x0400098F RID: 2447
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szFaceName;
        }
    }
}
