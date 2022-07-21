using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
    public static class VB2008Print_Save
    {
        public static void SavePageCS(this VB2008Print print)
        {
            PaperSize paperSize = print.mypagesetting.PaperSize;
            print.SavePaperHeightAndWidth(paperSize);
            print.mypages[0].Append("\u0002\u0004");
            print.TheWrite(0, "papersize", Conversions.ToString((int)paperSize.Kind));
            if (paperSize.Kind == PaperKind.Custom)
            {
                print.TheWrite(0, "paperzdy", string.Concat(new string[]
                {
                    paperSize.PaperName,
                    "\u0006",
                    Conversions.ToString(paperSize.Width),
                    "\u0006",
                    Conversions.ToString(paperSize.Height)
                }));
            }
            else
            {
                print.TheWrite(0, "paperzdy", string.Concat(new string[]
                {
                    "[",
                    paperSize.PaperName,
                    "]\u0006",
                    Conversions.ToString(paperSize.Width),
                    "\u0006",
                    Conversions.ToString(paperSize.Height)
                }));
            }
            print.TheWrite(0, "orientation", Conversions.ToString(Interaction.IIf(print.mypagesetting.Landscape, "1", "0")));
            print.TheWrite(0, "leftmargin", Conversions.ToString(print.mypagesetting.Margins.Left));
            print.TheWrite(0, "topmargin", Conversions.ToString(print.mypagesetting.Margins.Top));
            print.TheWrite(0, "bottommargin", Conversions.ToString(print.mypagesetting.Margins.Bottom));
            print.TheWrite(0, "rightmargin", Conversions.ToString(print.mypagesetting.Margins.Right));
        }


        public static void SavePaperHeightAndWidth(this VB2008Print print, PaperSize tt)
        {
            checked
            {
                if (!(print.currentpage > print.GetPages() | print.currentpage < 0))
                {
                    if (print.myPaperHeight == null | print.myPaperWidth == null)
                    {
                        print.myPaperHeight = (float[])Utils.CopyArray((Array)print.myPaperHeight, new float[print.GetPages() + 1]);
                        print.myPaperWidth = (float[])Utils.CopyArray((Array)print.myPaperWidth, new float[print.GetPages() + 1]);
                    }
                    else if (print.myPaperHeight.Length <= print.GetPages())
                    {
                        print.myPaperHeight = (float[])Utils.CopyArray((Array)print.myPaperHeight, new float[print.GetPages() + 1]);
                        print.myPaperWidth = (float[])Utils.CopyArray((Array)print.myPaperWidth, new float[print.GetPages() + 1]);
                    }
                    print.myPaperHeight[print.currentpage] = (float)tt.Height;
                    print.myPaperWidth[print.currentpage] = (float)tt.Width;
                }
            }
        }


        public static void SetStatus(this VB2008Print print, string tt)
        {
            if (Strings.InStr(tt, "页眉", CompareMethod.Binary) > 0)
            {
                print.mystatus.Text = string.Concat(new string[]
                {
                    "共[",
                    print.GetPages().ToString(),
                    "]页,生成页眉页脚〖",
                    Conversions.ToString(print.currentpage),
                    "〗"
                });
            }
            else
            {
                print.mystatus.Text = "共[" + print.GetPages().ToString() + "]页 ";
            }
            try
            {
                print.SetStatusNew(tt);
            }
            catch (Exception ex)
            {
            }
        }

        public static void DrawPageBackGroundImage(this VB2008Print print)
        {
            if (print.mypagebackgroundimage != null)
            {
                try
                {
                    print.DrawImage(print.mypagebackgroundimage, 0f, 0f, print.PaperPrintWidth, print.PaperPrintHeight, true, StringAlignment.Center, StringAlignment.Center);
                }
                catch (Exception ex)
                {
                }
            }
        }
        public static void DrawMargin(this VB2008Print print)
        {
            print.MyWrite("mydrawmargin", "");
        }


        // Token: 0x060013BD RID: 5053 RVA: 0x000971D0 File Offset: 0x000953D0
        public static bool SaveFont(this VB2008Print print,Font newfont, Font sourcefont)
        {
            FontConverter fontConverter = new FontConverter();
            bool result;
            if (sourcefont == null)
            {
                string text = fontConverter.ConvertToString(newfont);
                print.MyWrite("f", text);
                result = true;
            }
            else
            {
                string right = fontConverter.ConvertToString(sourcefont);
                string text = fontConverter.ConvertToString(newfont);
                if (Operators.CompareString(text, right, false) != 0)
                {
                    print.MyWrite("f", text);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        // Token: 0x060013BE RID: 5054 RVA: 0x00097234 File Offset: 0x00095434
        public static void SaveCS(this VB2008Print print)
        {
            print.templandscape = print.PaperLandscape;
            print.temppaperkind = print.PaperKind;
            print.temppapersize = definepaper.GetPrintForm(print.GetCurrentPrinterName(), print.PaperSize.PaperName);
            print.temppageunits = print.PageUnits;
            print.tempmargintleft = print.mypagesetting.Margins.Left;
            print.tempmargintright = print.mypagesetting.Margins.Right;
            print.tempmarginttop = print.mypagesetting.Margins.Top;
            print.tempmargintbottom = print.mypagesetting.Margins.Bottom;
            print.tempforecolor = print.TextColor;
            print.tempfont = (Font)print.TextFont.Clone();
            print.tempfontwater = (Font)print.WaterMarkFont.Clone();
            print.tempforecolorwater = print.WaterMarkColor;
            print.templandscapewater = print.WaterMarkLandscape;
            print.tempopacitywater = print.mywatermarkopacity;
            print.tempshapedepth = print.myshapedepth;
            print.tempcellmargin = print.myCellmargin;
            print.tempisdrawtableeverypage = print.IsDrawTableFooterEveryPage;
            print.tempisautoaddemptyrow = print.IsAutoAddEmptyRow;
            print.tempisneedchecknewpage = print.IsNeedCheckNewPage;
            print.tempouterborder = print.myouterborder;
            print.tempouterborderwidth = print.myouterborderwidth;
            print.tempouterbordercolor = print.myouterbordercolor;
            print.tempisusedoubleline = print.myisusedoubleline;
            print.tempdoublelinespace = print.thedoublelinespace;
            print.tempIsDGVCellValignmentCenter = print.myIsDGVCellValignmentCenter;
            print.tempIsDrawPageFooterLine = print.myisdrawpagefooterline;
            print.tempIsDrawPageHeaderLine = print.myisdrawpageheaderline;
            print.tempIsUseDGVPadding = print.myisusedgvpadding;
            print.tempoffsetx = print.myPYx;
            print.tempoffsety = print.myPYy;
        }
    }
}
