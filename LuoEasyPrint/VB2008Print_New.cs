using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
    public static class VB2008Print_New
    {
        public static void MyNewPage(this VB2008Print print)
        {
            checked
            {
                if (!Module1.G_CancelDocument)
                {
                    if (print.currentpage + 1 <= print.GetPages())
                    {
                        print.currentpage++;
                        print.Currentx = 0f;
                        print.Currenty = 0f;
                        print.SaveFont(print.r_font, null);
                    }
                    else
                    {
                        print.currentpage = print.GetPages() + 1;
                        print.Currentx = 0f;
                        print.Currenty = 0f;
                        print.mypages = (StringBuilder[])Utils.CopyArray((Array)print.mypages, new StringBuilder[print.currentpage + 1]);
                        print.mypages[print.currentpage] = new StringBuilder("   ");
                        print.NewPageAfter();
                    }
                }
            }
        }
        public static void MyNewPage(this VB2008Print print, bool paperLandscape)
        {
            print.mypagesetting.Landscape = paperLandscape;
            print.Pd.DefaultPageSettings = print.mypagesetting;
            MyNewPage(print);
        }
        public static bool IsNewPage(this VB2008Print print, float theheight)
        {
            return print.IsNewPage(theheight, false, false);
        }
        public static bool IsNewPage(this VB2008Print print, float theheight, bool autonewpage)
        {
            return print.IsNewPage(theheight, autonewpage, true);
        }
        public static bool IsNewPage(this VB2008Print print,float theheight, bool autonewpage, bool newpageUsePriorPageset)
        {
            bool flag = theheight + print.Currenty > print.PaperPrintHeight;
            if (flag && autonewpage)
            {
                if (newpageUsePriorPageset)
                {
                    MyNewPage(print);
                }
                else
                {
                    NewPage(print);
                }
            }
            return flag;
        }
        public static bool MyIsNewPage(this VB2008Print print, float theheight, bool autonewpage)
        {
            bool flag = theheight + print.Currenty > print.PaperPrintHeight;
            if (flag && autonewpage)
            {
                MyNewPage(print);
            }
            return flag;
        }
        public static void NewPage(this VB2008Print print)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                NewPageAfter(print);
            }
        }

      
        public static void NewPage(this VB2008Print print, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }

       
        public static void NewPage(this VB2008Print print, PaperKind mypaperkind, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                try
                {
                    foreach (object obj in print.Pd.PrinterSettings.PaperSizes)
                    {
                        PaperSize paperSize = (PaperSize)obj;
                        if (paperSize.Kind == mypaperkind)
                        {
                            print.mypagesetting.PaperSize = paperSize;
                        }
                    }
                }
                finally
                {
                   
                }
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }

    
        public static void NewPage(this VB2008Print print, PaperKind mypaperkind)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                try
                {
                    foreach (object obj in print.Pd.PrinterSettings.PaperSizes)
                    {
                        PaperSize paperSize = (PaperSize)obj;
                        if (paperSize.Kind == mypaperkind)
                        {
                            print.mypagesetting.PaperSize = paperSize;
                        }
                    }
                }
                finally
                {
                
                }
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, PaperKind mypaperkind, Margins thePaperMargin, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                try
                {
                    foreach (object obj in print.Pd.PrinterSettings.PaperSizes)
                    {
                        PaperSize paperSize = (PaperSize)obj;
                        if (paperSize.Kind == mypaperkind)
                        {
                            print.mypagesetting.PaperSize = paperSize;
                        }
                    }
                }
                finally
                {
                  
                }
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, PaperKind mypaperkind, Margins thePaperMargin)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                try
                {
                    foreach (object obj in print.Pd.PrinterSettings.PaperSizes)
                    {
                        PaperSize paperSize = (PaperSize)obj;
                        if (paperSize.Kind == mypaperkind)
                        {
                            print.mypagesetting.PaperSize = paperSize;
                        }
                    }
                }
                finally
                {
                    
                }
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, Margins thePaperMargin, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, Margins thePaperMargin)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPageBefore(this VB2008Print print)
        {
            checked
            {
                if (print.hasprinterinstalled)
                {
                    print.currentpage = print.GetPages() + 1;
                    print.Currentx = 0f;
                    print.Currenty = 0f;
                    print.mypages = (StringBuilder[])Utils.CopyArray((Array)print.mypages, new StringBuilder[print.currentpage + 1]);
                    print.mypages[print.currentpage] = new StringBuilder("   ");
                    print.GetPageAndPaperSettings(0);
                }
            }
        }
        public static void NewPageAfter(this VB2008Print print)
        {
            if (print.hasprinterinstalled)
            {
                print.SavePageCS();
                print.SaveFont(print.r_font, null);
                print.DrawMargin();
                print.DrawPageBackGroundImage();
                print.SetStatus("预处理，正在处理第〖" + Conversions.ToString(print.currentpage) + "〗页");
                Application.DoEvents();
            }
        }
        public static void NewPage(this VB2008Print print,PaperSize newpapersize, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                print.PaperSize = newpapersize;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, PaperSize newpapersize)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperSize = newpapersize;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, PaperSize newpapersize, Margins thePaperMargin, bool isPaperLandscape)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperLandscape = isPaperLandscape;
                print.PaperSize = newpapersize;
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }
        public static void NewPage(this VB2008Print print, PaperSize newpapersize, Margins thePaperMargin)
        {
            if (!print.CancelDocument)
            {
                NewPageBefore(print);
                bool flag = print.isstarting;
                print.isstarting = false;
                print.PaperSize = newpapersize;
                print.PaperMargins = thePaperMargin;
                print.isstarting = flag;
                NewPageAfter(print);
            }
        }

       
        public static void NewRow(this VB2008Print print, float currentrowheight)
        {
            if (!Module1.G_CancelDocument)
            {
                print.Currentx = 0f;
                print.Currenty += currentrowheight;
                if (print.Currenty > print.PaperPrintHeight)
                {
                    MyNewPage(print);
                }
            }
        }


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
    }
}
