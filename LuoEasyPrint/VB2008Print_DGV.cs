using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
    public static class VB2008Print_DGV
    {
        public static float PrintDGVFa(this VB2008Print print, DataGridView mydgvToPrint, string schemefilename, bool AutoCreateIfFileNotExist = true, TreeView columnheadertree = null)
        {
            DataGridView dataGridView = new DataGridView();
            Module1.CopyDataGridView(mydgvToPrint, dataGridView);
            if (!MyProject.Computer.FileSystem.FileExists(schemefilename))
            {
                if (!AutoCreateIfFileNotExist)
                {
                    if (print.IsShowErrorMSG)
                    {
                        MessageBox.Show("直接使用打印方案文件打印输出表格失败，方案文件【" + schemefilename + "】不存在，因此没能将表格打印输出，如有疑问，请与程序员联系", "提示信息");
                    }
                    return 0f;
                }
                if (MyProject.Computer.FileSystem.DirectoryExists(schemefilename))
                {
                    if (print.IsShowErrorMSG)
                    {
                        MessageBox.Show("直接使用打印方案文件打印输出表格失败，方案文件【" + schemefilename + "】不存在，且指定的方案文件不是有效的文件，而是路径，故没法自动用该文件名创建方案文件，因此没能将表格打印输出，如有疑问，请与程序员联系", "提示信息");

                    }
                    return 0f;
                }
                try
                {
                    print.CreateFa(schemefilename, dataGridView);
                }
                catch (Exception ex)
                {
                }
            }
            Color color = print.myforecolor;
            int num = print.myshapedepth;
            int num2 = 1;
            string ztitle = "";
            string ftitle = "";
            Font ztitlefont = new Font("黑体", 18f, FontStyle.Bold);
            Font ftitlefont = new Font("宋体", 12f, FontStyle.Bold);
            bool zoomtopaperwidth = true;
            bool autoresizerowheight = true;
            float minfontsize = 0f;
            bool reppagetitle = true;
            bool printbackcolor = true;
            string myborder = "1111";
            float num3 = 100f;
            bool printzero = false;
            bool gzwrap = false;
            int mycolumns = 0;
            float num4 = 50f;
            bool lastpagemode = true;
            int fixedcols = 1;
            bool autoformat = false;
            string tablel = "";
            string tablem = "";
            string tabler = "";
            string tableleft = "";
            string tablemiddle = "";
            string tableright = "";
            Font topfont = new Font("宋体", 10f, FontStyle.Bold);
            Font bottomfont = new Font("宋体", 10f, FontStyle.Bold);
            Color color2 = Color.Black;
            int num5 = 0;
            int num6 = 0;
            string myhzcolumns = "";
            Font myhzfont = null;
            string mygroupcolumn = "";
            string mysortcolumn = "";
            bool mysorttype = true;
            StringAlignment tableTopLeftTitleAlign = StringAlignment.Near;
            StringAlignment tableTopMiddleTitleAlign = StringAlignment.Center;
            StringAlignment tableTopRightTitleAlign = StringAlignment.Far;
            StringAlignment tableBottomLeftTitleAlign = StringAlignment.Near;
            StringAlignment tableBottomMiddleTitleAlign = StringAlignment.Center;
            StringAlignment tableBottomRightTitleAlign = StringAlignment.Far;
            StringAlignment sumNumberAlign = StringAlignment.Center;
            bool isDrawTableFooterEveryPage = false;
            string section = "页面设置";
            string text = Module1.GetINI(section, "创建方案[0-1]", "0", schemefilename);
            if (Operators.CompareString(text, "1", false) == 0)
            {
                print.CreateFa(schemefilename, dataGridView);
            }
            text = Module1.GetINI(section, "新页[0-1]", "0", schemefilename);
            StringAlignment bgalignment = StringAlignment.Near;
            bool isAutoAddEmptyRow = false;
            bool isUseDoubleLine = false;
            float num10 = 0;
            bool outerBorder = false;
            float num11 = 0;
            Color outerBorderColor = new Color();
            bool myaddrowid = false;
            Color myhzforecolor = new Color();
            Color myhzbackcolor = new Color();
            bool mygroupnewpage = false;
            bool myaddrownew = false;
            try
            {
                if (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0)
                {
                    text = Module1.GetINI(section, "纸张", "9", schemefilename);
                    int num7 = Conversions.ToInteger(text);
                    string text2 = "";
                    int num8 = 0;
                    int num9 = 0;
                    if (num7 <= 0)
                    {
                        try
                        {
                            text = Module1.GetINI(section, "纸张名称", "", schemefilename);
                            text2 = text.Trim();
                            text = Module1.GetINI(section, "纸张宽度", "0", schemefilename);
                            checked
                            {
                                num8 = (int)Math.Round(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(text), 10m)) / 2.54);
                                text = Module1.GetINI(section, "纸张高度", "0", schemefilename);
                                num9 = (int)Math.Round(Convert.ToDouble(decimal.Multiply(Conversions.ToDecimal(text), 10m)) / 2.54);
                            }
                            if (Operators.CompareString(text2, "", false) != 0 & Operators.CompareString(text2, "[自定义纸张]", false) != 0)
                            {
                                PaperSize printForm = definepaper.GetPrintForm(print.GetCurrentPrinterName(), text2);
                                if (printForm != null)
                                {
                                    if (num8 <= 0 | num9 <= 0)
                                    {
                                        num8 = printForm.Width;
                                        num9 = printForm.Height;
                                    }
                                    else if (checked(Math.Abs(printForm.Width - num8) > 1 | Math.Abs(printForm.Height - num9) > 1))
                                    {
                                        definepaper.SetPrintForm(print.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
                                    }
                                }
                                else
                                {
                                    definepaper.SetPrintForm(print.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                        }
                        if (Operators.CompareString(text2, "[自定义纸张]", false) == 0)
                        {
                            definepaper.SetPrintForm(print.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
                        }
                        else
                        {
                            PaperSize printForm = definepaper.GetPrintForm(print.GetCurrentPrinterName(), text2);
                            if (printForm != null)
                            {
                                if (num8 <= 0 | num9 <= 0)
                                {
                                    num8 = printForm.Width;
                                    num9 = printForm.Height;
                                }
                                else if (checked(Math.Abs(printForm.Width - num8) > 1 | Math.Abs(printForm.Height - num9) > 1))
                                {
                                    text2 = "[自定义纸张]";
                                    definepaper.SetPrintForm(print.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
                                }
                            }
                            else
                            {
                                text2 = "[自定义纸张]";
                                definepaper.SetPrintForm(print.GetCurrentPrinterName(), text2, (float)((double)num8 * 2.54 / 10.0), (float)((double)num9 * 2.54 / 10.0));
                            }
                        }
                    }
                    text = Module1.GetINI(section, "方向", "纵向", schemefilename);
                    bool isPaperLandscape = Operators.CompareString(text, "横向", false) == 0;
                    Margins margins = new Margins();
                    text = Module1.GetINI(section, "上边距", "25.4", schemefilename);
                    margins.Top = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "下边距", "25.4", schemefilename);
                    margins.Bottom = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "左边距", "25.4", schemefilename);
                    margins.Left = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    text = Module1.GetINI(section, "右边距", "25.4", schemefilename);
                    margins.Right = Convert.ToInt32(decimal.Multiply(Convert.ToDecimal(text), 10m));
                    checked
                    {
                        if (print.PageUnits == VB2008Print_EnumType.PageExportUnit.Inch)
                        {
                            margins.Top = (int)Math.Round((double)margins.Top / 2.54);
                            margins.Bottom = (int)Math.Round((double)margins.Bottom / 2.54);
                            margins.Left = (int)Math.Round((double)margins.Left / 2.54);
                            margins.Right = (int)Math.Round((double)margins.Right / 2.54);
                        }
                        if (num7 > 0)
                        {
                            print.NewPage((PaperKind)num7, margins, isPaperLandscape);
                        }
                        else
                        {
                            PaperSize newpapersize = new PaperSize(text2, num8, num9);
                            print.NewPage(newpapersize, margins, isPaperLandscape);
                        }
                    }
                }
                section = "表格打印格式";
                text = Module1.GetINI(section, "表格打印样式[1-4]", "1", schemefilename);
                num2 = Conversions.ToInteger(text);
                if (num2 > 4 | num2 < 1)
                {
                    num2 = 1;
                }
                text = Module1.GetINI(section, "表格对齐", "居中对齐", schemefilename);
                string left = text;
                if (Operators.CompareString(left, "居中对齐", false) == 0)
                {
                    bgalignment = StringAlignment.Center;
                }
                else if (Operators.CompareString(left, "左对齐", false) == 0)
                {
                    bgalignment = StringAlignment.Near;
                }
                else if (Operators.CompareString(left, "右对齐", false) == 0)
                {
                    bgalignment = StringAlignment.Far;
                }
                else
                {
                    bgalignment = StringAlignment.Center;
                }
                text = Module1.GetINI(section, "表格边框", "表格线", schemefilename);
                string left2 = text;
                if (Operators.CompareString(left2, "表格线", false) == 0)
                {
                    myborder = "1111";
                }
                else if (Operators.CompareString(left2, "仅横线", false) == 0)
                {
                    myborder = "0101";
                }
                else if (Operators.CompareString(left2, "仅竖线", false) == 0)
                {
                    myborder = "1010";
                }
                else if (Operators.CompareString(left2, "无线", false) == 0)
                {
                    myborder = "0000";
                }
                else if (Strings.Len(text) != 4 | !Versioned.IsNumeric(text))
                {
                    myborder = "1111";
                }
                else
                {
                    myborder = text;
                }
                text = Module1.GetINI(section, "适合纸张宽度[0-1]", "1", schemefilename);
                zoomtopaperwidth = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "自动调整行高[0-1]", "1", schemefilename);
                autoresizerowheight = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "最小字号", "6", schemefilename);
                minfontsize = Conversions.ToSingle(text);
                text = Module1.GetINI(section, "标题行重复打印[0-1]", "1", schemefilename);
                reppagetitle = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "打印表格背景颜色[0-1]", "1", schemefilename);
                printbackcolor = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "自动调整行高与列宽[0-1]", "1", schemefilename);
                autoformat = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "工资条间距", "100", schemefilename);
                num3 = Conversions.ToSingle(text);
                text = Module1.GetINI(section, "工资条打印零值[0-1]", "0", schemefilename);
                printzero = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "工资条自动换行打印[0-1]", "0", schemefilename);
                gzwrap = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "多栏打印的栏数", "2", schemefilename);
                mycolumns = Conversions.ToInteger(text);
                text = Module1.GetINI(section, "多栏打印的栏间距", "50", schemefilename);
                num4 = Conversions.ToSingle(text);
                text = Module1.GetINI(section, "多栏打印最后一页风格[0-1]", "1", schemefilename);
                lastpagemode = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "跨页打印的固定列数", "2", schemefilename);
                fixedcols = Conversions.ToInteger(text);
                text = Module1.GetINI(section, "表格线颜色", "", schemefilename);
                dataGridView.GridColor = Module1.ConvertStringToColor(text);
                text = Module1.GetINI(section, "补白打印[0-1]", "0", schemefilename);
                isAutoAddEmptyRow = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "表格页脚每页重复打印[0-1]", "0", schemefilename);
                isDrawTableFooterEveryPage = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "双表格线[0-1]", "0", schemefilename);
                isUseDoubleLine = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "双表格线间距(1/100厘米)", "10", schemefilename);
                num10 = (float)Conversion.Val(text);
                text = Module1.GetINI(section, "表格外边框[0-1]", "0", schemefilename);
                outerBorder = (Operators.CompareString(text, "1", false) == 0);
                text = Module1.GetINI(section, "表格外边框线宽(1/100厘米)", "5", schemefilename);
                num11 = (float)Conversion.Val(text);
                text = Module1.GetINI(section, "表格外边框颜色", Module1.ConvertColorToString(Color.Black), schemefilename);
                outerBorderColor = Module1.ConvertStringToColor(text);
                section = "单元格默认边距";
                text = Module1.GetINI(section, "左边距(毫米)", "-1", schemefilename);
                float num12 = 0;
                if (Operators.CompareString(text, "-1", false) != 0)
                {
                    num12 = (float)Conversion.Val(text);
                }
                text = Module1.GetINI(section, "右边距(毫米)", "-1", schemefilename);
                float num13 = 0;
                if (Operators.CompareString(text, "-1", false) != 0)
                {
                    num13 = (float)Conversion.Val(text);
                }
                text = Module1.GetINI(section, "上边距(毫米)", "-1", schemefilename);
                float num14 = 0;
                if (Operators.CompareString(text, "-1", false) != 0)
                {
                    num14 = (float)Conversion.Val(text);
                }
                text = Module1.GetINI(section, "下边距(毫米)", "-1", schemefilename);
                float num15 = 0;
                if (Operators.CompareString(text, "-1", false) != 0)
                {
                    num15 = (float)Conversion.Val(text);
                }
                if (print.PageUnits == VB2008Print_EnumType.PageExportUnit.CentiMeter)
                {
                    num12 = print.ConvToDisplay(num12 * 10f, true);
                    num13 = print.ConvToDisplay(num13 * 10f, true);
                    num14 = print.ConvToDisplay(num14 * 10f, false);
                    num15 = print.ConvToDisplay(num15 * 10f, false);
                }
                else
                {
                    num12 = print.ConvToDisplay(print.ConvertMmToInch(num12) * 100f, true);
                    num13 = print.ConvToDisplay(print.ConvertMmToInch(num13) * 100f, true);
                    num14 = print.ConvToDisplay(print.ConvertMmToInch(num14) * 100f, false);
                    num15 = print.ConvToDisplay(print.ConvertMmToInch(num15) * 100f, false);
                }
                DataGridViewCellStyle defaultCellStyle = dataGridView.DefaultCellStyle;
                checked
                {
                    Padding padding = new Padding((int)Math.Round((double)num12), (int)Math.Round((double)num14), (int)Math.Round((double)num13), (int)Math.Round((double)num15));
                    defaultCellStyle.Padding = padding;
                    section = "打印标题设置";
                    text = Module1.GetINI(section, "主标题", "", schemefilename);
                    ztitle = text;
                    text = Module1.GetINI(section, "主标题字体", "", schemefilename);
                    Font font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        ztitlefont = font;
                    }
                    text = Module1.GetINI(section, "主标题前景颜色", "", schemefilename);
                    Color color3 = Module1.ConvertStringToColor(text);
                    color2 = color3;
                    print.myforecolor = color2;
                    text = Module1.GetINI(section, "主标题文字风格[0-6]", "0", schemefilename);
                    num5 = Conversions.ToInteger(text);
                    if (num5 > 6 | num5 < 0)
                    {
                        num5 = 0;
                    }
                    text = Module1.GetINI(section, "辅标题", "", schemefilename);
                    ftitle = text;
                    text = Module1.GetINI(section, "辅标题字体", "", schemefilename);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        ftitlefont = font;
                    }
                    text = Module1.GetINI(section, "辅标题文字风格[0-6]", "0", schemefilename);
                    num6 = Conversions.ToInteger(text);
                    if (num6 > 6 | num6 < 0)
                    {
                        num6 = 0;
                    }
                    text = Module1.GetINI(section, "标题特效时的深度", "8", schemefilename);
                    if (print.PageUnits == VB2008Print_EnumType.PageExportUnit.Inch)
                    {
                        print.ShapeDepth = (int)Math.Round((double)Conversions.ToInteger(text) / 2.54);
                    }
                    else
                    {
                        print.ShapeDepth = Conversions.ToInteger(text);
                    }
                    section = "表格页眉";
                    text = Module1.GetINI(section, "左边", "", schemefilename);
                    tablel = text;
                    text = Module1.GetINI(section, "左边对齐[0-2]", "0", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "0";
                    }
                    tableTopLeftTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "中间", "", schemefilename);
                    tablem = text;
                    text = Module1.GetINI(section, "中间对齐[0-2]", "1", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "1";
                    }
                    tableTopMiddleTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "右边", "", schemefilename);
                    tabler = text;
                    text = Module1.GetINI(section, "右边对齐[0-2]", "2", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "2";
                    }
                    tableTopRightTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "字体", "", schemefilename);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        topfont = font;
                    }
                    section = "表格页脚";
                    text = Module1.GetINI(section, "左边", "", schemefilename);
                    tableleft = text;
                    text = Module1.GetINI(section, "左边对齐[0-2]", "0", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "0";
                    }
                    tableBottomLeftTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "中间", "", schemefilename);
                    tablemiddle = text;
                    text = Module1.GetINI(section, "中间对齐[0-2]", "1", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "1";
                    }
                    tableBottomMiddleTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "右边", "", schemefilename);
                    tableright = text;
                    text = Module1.GetINI(section, "右边对齐[0-2]", "2", schemefilename);
                    if (!Versioned.IsNumeric(text))
                    {
                        text = "2";
                    }
                    tableBottomRightTitleAlign = (StringAlignment)Conversions.ToInteger(text);
                    text = Module1.GetINI(section, "字体", "", schemefilename);
                    font = Module1.ConvertStringToFont(text);
                    if (font != null)
                    {
                        bottomfont = font;
                    }
                    section = "表格默认设置";
                    text = Module1.GetINI(section, "表格总列数", "0", schemefilename);
                    int num16 = Conversions.ToInteger(text);
                    if (num16 != 0)
                    {
                        text = Module1.GetINI(section, "标题字段名默认字体", "", schemefilename);
                        font = Module1.ConvertStringToFont(text);
                        if (font != null)
                        {
                            dataGridView.ColumnHeadersDefaultCellStyle.Font = font;
                        }
                        text = Module1.GetINI(section, "标题字段名认前景颜色", "", schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = color3;
                        text = Module1.GetINI(section, "标题字段名默认背景颜色", Module1.ConvertColorToString(Color.White), schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = color3;
                        text = Module1.GetINI(section, "单元格默认字体", "", schemefilename);
                        font = Module1.ConvertStringToFont(text);
                        if (font != null)
                        {
                            dataGridView.DefaultCellStyle.Font = font;
                        }
                        text = Module1.GetINI(section, "单元格默认前景颜色", "", schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        dataGridView.DefaultCellStyle.ForeColor = color3;
                        text = Module1.GetINI(section, "单元格默认背景颜色", Module1.ConvertColorToString(Color.White), schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        dataGridView.DefaultCellStyle.BackColor = color3;
                        text = Module1.GetINI(section, "默认行高[毫米]", "0", schemefilename);
                        if (Versioned.IsNumeric(text))
                        {
                            float num17 = Conversions.ToSingle(text);
                            try
                            {
                                if (num17 != 0f)
                                {
                                    float num18 = print.ConvToDisplay(unchecked(num17 * 10f), false);
                                    int num19 = 0;
                                    int num20 = dataGridView.RowCount - 1;
                                    for (int i = num19; i <= num20; i++)
                                    {
                                        if (num18 < 0f)
                                        {
                                            dataGridView.Rows[i].MinimumHeight = (int)Math.Round((double)Math.Abs(num18));
                                        }
                                        else if (num18 > 0f)
                                        {
                                            dataGridView.Rows[i].Height = (int)Math.Round((double)num18);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex3)
                            {
                            }
                        }
                        text = Module1.GetINI(section, "奇数行默认前景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        Color color4 = new Color();
                        if (color3.ToArgb() == 0)
                        {
                            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = color4;
                        }
                        else
                        {
                            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = color3;
                        }
                        text = Module1.GetINI(section, "奇数行默认背景颜色", Module1.ConvertColorToString(Color.FromArgb(0)), schemefilename);
                        color3 = Module1.ConvertStringToColor(text);
                        if (color3.ToArgb() == 0)
                        {
                            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = color4;
                        }
                        else
                        {
                            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = color3;
                        }
                        text = Strings.Trim(Module1.GetINI("分组汇总排序设置", "第一列前添加行号", "", schemefilename));
                        myaddrowid = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
                        if (num16 != dataGridView.ColumnCount)
                        {
                            if (print.IsShowErrorMSG)
                            {
                                Interaction.MsgBox(string.Concat(new string[]
                                {
                                    "无法应用方案文件中的表格各列详细设置参数（除此之外的其余参数都成功应用了），原因是当前要打印的表格有【",
                                    Conversions.ToString(dataGridView.ColumnCount),
                                    "列】而方案文件中保存的表格有〖",
                                    Conversions.ToString(num16),
                                    "列〗，两者数不一致，不能使用。\r\n如果您只需要应用方案文件中除要表格各列详细参数设置外的其他参数，您应该将方案文件中的<表格总列数>设为0，或者在保存方案时就不保存表格参数设置"
                                }), MsgBoxStyle.OkOnly, "提示信息");
                            }
                        }
                        else
                        {
                            string[] array = new string[num16 - 1 + 1];
                            string[] array2 = new string[num16 - 1 + 1];
                            int num21 = 1;
                            int num22 = num16;
                            for (int j = num21; j <= num22; j++)
                            {
                                section = "第" + Conversions.ToString(j) + "列";
                                array2[j - 1] = Module1.GetINI(section, "名称", "", schemefilename);
                                array[j - 1] = Module1.GetINI(section, "显示的文本", "", schemefilename);
                            }
                            bool flag = false;
                            int num23 = 0;
                            int num24 = num16 - 1;
                            int k = num23;
                        IL_14BF:
                            while (k <= num24)
                            {
                                int num25 = k + 1;
                                int num26 = num16 - 1;
                                int l = num25;
                                while (l <= num26)
                                {
                                    if (Operators.CompareString(array2[k], array2[l], false) == 0)
                                    {
                                        flag = true;

                                        if (!flag)
                                        {
                                            k++;
                                            goto IL_14BF;
                                        }
                                        goto IL_14C5;
                                    }
                                    else
                                    {
                                        l++;
                                    }
                                }

                            }
                        IL_14C5:
                            if (flag)
                            {
                                if (print.IsShowErrorMSG)
                                {
                                    Interaction.MsgBox(string.Concat(new string[]
                                    {
                                        "当前打印所用方案文件〖",
                                        schemefilename,
                                        "〗存在问题，列名称为【",
                                        array2[k],
                                        "】的有多列，本控件要求列名称必须唯一，请修改该方案再使用。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
                                    }), MsgBoxStyle.OkOnly, "提示信息");
                                }
                            }
                            else
                            {
                                flag = false;
                                int num27 = 0;
                                int num28 = num16 - 1;
                                k = num27;
                            IL_1567:
                                while (k <= num28)
                                {
                                    int num29 = k + 1;
                                    int num30 = num16 - 1;
                                    int m = num29;
                                    while (m <= num30)
                                    {
                                        if (Operators.CompareString(array[k], array[m], false) == 0)
                                        {
                                            flag = true;
                                        IL_155D:
                                            if (!flag)
                                            {
                                                k++;
                                                goto IL_1567;
                                            }
                                            goto IL_156D;
                                        }
                                        else
                                        {
                                            m++;
                                        }
                                    }

                                }
                            IL_156D:
                                if (flag)
                                {
                                    if (print.IsShowErrorMSG)
                                    {
                                        Interaction.MsgBox(string.Concat(new string[]
                                        {
                                            "当前打印所用方案文件〖",
                                            schemefilename,
                                            "〗存在问题，列显示名称为【",
                                            array2[k],
                                            "】的有多列，本控件要求列的显示名称必须唯一，否则会产生问题，请修改该方案再使用。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
                                        }), MsgBoxStyle.OkOnly, "提示信息");
                                    }
                                }
                                else
                                {
                                    int num31 = 0;
                                    int num32 = num16 - 1;
                                    int j = num31;
                                IL_1621:
                                    while (j <= num32)
                                    {
                                        flag = false;
                                        text = array2[j];
                                        int num33 = 0;
                                        int num34 = num16 - 1;
                                        k = num33;
                                        while (k <= num34)
                                        {
                                            if (Operators.CompareString(text, dataGridView.Columns[k].Name, false) == 0)
                                            {
                                                flag = true;
                                            IL_1614:
                                                if (flag)
                                                {
                                                    j++;
                                                    goto IL_1621;
                                                }
                                                if (print.IsShowErrorMSG)
                                                {
                                                    Interaction.MsgBox(string.Concat(new string[]
                                                    {
                                                        "当前打印所用方案文件〖",
                                                        schemefilename,
                                                        "〗存在问题，方案文件中保存的列名称为【",
                                                        array2[j],
                                                        "】的列在当前要打印的DataGridView表格中不存在，因此该打印方案与当前打印的表格不兼容，不能使用方案中的列详细设置参数。\r\n本次使用打印方案除列详细设置应用失败外，其他参数已成功应用"
                                                    }), MsgBoxStyle.OkOnly, "提示信息");
                                                }
                                                goto IL_1C53;
                                            }
                                            else
                                            {
                                                k++;
                                            }
                                        }
                                    }
                                    int num35 = 0;
                                    int num36 = dataGridView.ColumnCount - 1;
                                    for (j = num35; j <= num36; j++)
                                    {
                                        section = "第" + Conversions.ToString(j + 1) + "列";
                                        string ini = Module1.GetINI(section, "名称", "", schemefilename);
                                        string ini2 = Module1.GetINI(section, "显示的文本", "", schemefilename);
                                        dataGridView.Columns[ini].HeaderText = ini2;
                                        dataGridView.Columns[ini].DisplayIndex = j;
                                        text = Module1.GetINI(section, "是否打印[0-1]", "1", schemefilename);
                                        if (Operators.CompareString(text, "1", false) == 0)
                                        {
                                            dataGridView.Columns[ini].Visible = true;
                                        }
                                        else
                                        {
                                            dataGridView.Columns[ini].Visible = false;
                                        }
                                        text = Module1.GetINI(section, "默认字体", "", schemefilename);
                                        font = Module1.ConvertStringToFont(text);
                                        if (font != null)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Font = font;
                                        }
                                        text = Module1.GetINI(section, "默认前景色", "", schemefilename);
                                        color3 = Module1.ConvertStringToColor(text);
                                        dataGridView.Columns[ini].DefaultCellStyle.ForeColor = color3;
                                        text = Module1.GetINI(section, "默认背景色", Module1.ConvertColorToString(Color.White), schemefilename);
                                        color3 = Module1.ConvertStringToColor(text);
                                        dataGridView.Columns[ini].DefaultCellStyle.BackColor = color3;
                                        text = Module1.GetINI(section, "文本对齐方式", "", schemefilename);
                                        string left3 = text;
                                        if (Operators.CompareString(left3, "居中对齐", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        }
                                        else if (Operators.CompareString(left3, "左对齐", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                        }
                                        else if (Operators.CompareString(left3, "未设置", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                                        }
                                        else if (Operators.CompareString(left3, "右对齐", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                        }
                                        else
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                                        }
                                        text = Module1.GetINI(section, "文本允许换行", "", schemefilename);
                                        string left4 = text;
                                        if (Operators.CompareString(left4, "未设置", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
                                        }
                                        else if (Operators.CompareString(left4, "允许", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                                        }
                                        else if (Operators.CompareString(left4, "不允许", false) == 0)
                                        {
                                            dataGridView.Columns[ini].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                                        }
                                        text = Module1.GetINI(section, "列宽(毫米)", "", schemefilename);
                                        if (Versioned.IsNumeric(text))
                                        {
                                            try
                                            {
                                                dataGridView.Columns[ini].Width = (int)Math.Round((double)print.ConvFromMMToDisplay(Convert.ToSingle(Conversions.ToDecimal(text))));
                                            }
                                            catch (Exception ex4)
                                            {
                                            }
                                        }
                                    }
                                    section = "分组汇总排序设置";
                                    myhzcolumns = Module1.GetINI(section, "要汇总的列", "", schemefilename);
                                    text = Module1.GetINI(section, "汇总行字体", "", schemefilename);
                                    font = Module1.ConvertStringToFont(text);
                                    if (font == null)
                                    {
                                        font = new Font("黑体", dataGridView.DefaultCellStyle.Font.Size, FontStyle.Bold);
                                    }
                                    myhzfont = font;
                                    text = Module1.GetINI(section, "汇总行前景颜色", "", schemefilename);
                                    color3 = Module1.ConvertStringToColor(text);
                                    if (color3.ToArgb() == 0)
                                    {
                                        color3 = dataGridView.DefaultCellStyle.ForeColor;
                                    }
                                    myhzforecolor = color3;
                                    text = Module1.GetINI(section, "汇总行背景颜色", "", schemefilename);
                                    color3 = Module1.ConvertStringToColor(text);
                                    if (color3.ToArgb() == 0)
                                    {
                                        color3 = dataGridView.DefaultCellStyle.BackColor;
                                    }
                                    myhzbackcolor = color3;
                                    text = Module1.GetINI(section, "汇总行数字对齐方式[0-2]", "1", schemefilename);
                                    if (!Versioned.IsNumeric(text))
                                    {
                                        text = "1";
                                    }
                                    sumNumberAlign = (StringAlignment)Conversions.ToInteger(text);
                                    mysortcolumn = Module1.GetINI(section, "要排序的列", "", schemefilename);
                                    text = Strings.Trim(Module1.GetINI(section, "升序排序", "", schemefilename));
                                    mysorttype = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
                                    mygroupcolumn = Module1.GetINI(section, "要分组列", "", schemefilename);
                                    text = Strings.Trim(Module1.GetINI(section, "每组换新页打印", "", schemefilename));
                                    mygroupnewpage = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
                                    text = Strings.Trim(Module1.GetINI(section, "第一列前添加行号", "", schemefilename));
                                    myaddrowid = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
                                    text = Strings.Trim(Module1.GetINI(section, "每组行号重新编号", "", schemefilename));
                                    myaddrownew = (Operators.CompareString(text, "1", false) == 0 | Operators.CompareString(text, "是", false) == 0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex5)
            {
                if (print.IsShowErrorMSG)
                {
                    Interaction.MsgBox("使用方案文件【" + schemefilename + "】进行打印输出时，读方案文件时出现异常，可能与当前要打印的表格不兼容，将采用默认的设置进行打印输出", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        IL_1C53:
            if (print.PageUnits != VB2008Print_EnumType.PageExportUnit.CentiMeter)
            {
                num3 = (float)((double)num3 / 2.54);
                num4 = (float)((double)num4 / 2.54);
                num10 = (float)((double)num10 / 2.54);
                num11 = (float)((double)num11 / 2.54);
            }
            bool isAutoAddEmptyRow2 = print.IsAutoAddEmptyRow;
            print.IsAutoAddEmptyRow = isAutoAddEmptyRow;
            bool isDrawTableFooterEveryPage2 = print.IsDrawTableFooterEveryPage;
            print.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage;
            print.IsUseDoubleLine = isUseDoubleLine;
            print.DoubleLineSpace = num10;
            print.OuterBorder = outerBorder;
            print.OuterBorderColor = outerBorderColor;
            print.OuterBorderWidth = num11;
            float result = print.StartDo(dataGridView, mysortcolumn, mysorttype, mygroupcolumn, myhzcolumns, myaddrownew, mygroupnewpage, myhzfont, myhzforecolor, myhzbackcolor, autoformat, num2, ztitle, ztitlefont, ftitle, ftitlefont, bgalignment, myborder, zoomtopaperwidth, autoresizerowheight, topfont, tablel, tablem, tabler, bottomfont, tableleft, tablemiddle, tableright, minfontsize, reppagetitle, printbackcolor, num5, num6, fixedcols, myaddrowid, mycolumns, num4, lastpagemode, num3, printzero, columnheadertree, tableTopLeftTitleAlign, tableTopMiddleTitleAlign, tableTopRightTitleAlign, tableBottomLeftTitleAlign, tableBottomMiddleTitleAlign, tableBottomRightTitleAlign, sumNumberAlign, gzwrap, 0f);
            dataGridView.Dispose();
            print.IsAutoAddEmptyRow = isAutoAddEmptyRow2;
            print.IsDrawTableFooterEveryPage = isDrawTableFooterEveryPage2;
            bool isUseDoubleLine2 = false;
            print.IsUseDoubleLine = isUseDoubleLine2;
            float doubleLineSpace = 0;
            print.DoubleLineSpace = doubleLineSpace;
            bool outerBorder2 = false;
            print.OuterBorder = outerBorder2;
            Color outerBorderColor2 = new Color();
            print.OuterBorderColor = outerBorderColor2;
            float outerBorderWidth = 0;
            print.OuterBorderWidth = outerBorderWidth;
            print.myforecolor = color;
            print.myshapedepth = num;
            return result;
        }


        public static float PrintDGVOut(this VB2008Print print, DataGridView mymstoprint, int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, bool autoformat, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
        {
            float result;
            if (Module1.G_CancelDocument)
            {
                result = 0f;
            }
            else
            {
                Module1.CopyDataGridView(mymstoprint, print.myms);
                if (autoformat)
                {
                    print.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    print.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
                result = print.PrintDGVOut(colsnum, thecol, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, autoresizewidth, autoresizerowheight, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, mytitleheight, myoneline1height, mysubtitleheight, myoneline2height, mytopheight, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, CanAddEmptyRow, mybottomheight, printwidth);
            }
            return result;
        }


        public static float PrintDGVOut(this VB2008Print print, int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
        {
            StringFormat stringFormat;
            StringFormat stringFormat2;
            int num5;
            int[] array;
            int[] array3;
            int[] array4;
            float[] array5;
            float num14;
            float num15;
            float num16;
            float num17;
            mytree mytree;
            float[] array7;
            float result;
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = print.myms.ColumnCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        int num3 = 0;
                        int num4 = print.myms.RowCount - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            string left = Conversions.ToString(print.myms.Rows[j].Cells[i].Tag);
                            if (Operators.CompareString(left, "水平合并", false) != 0 & Operators.CompareString(left, "垂直合并", false) != 0 & Operators.CompareString(left, "合并", false) != 0 & Operators.CompareString(left, "不合并", false) != 0 & Operators.CompareString(left, "上合并", false) != 0 & Operators.CompareString(left, "下合并", false) != 0 & Operators.CompareString(left, "左合并", false) != 0 & Operators.CompareString(left, "右合并", false) != 0 & Operators.CompareString(left, "左上合并", false) != 0 & Operators.CompareString(left, "左下合并", false) != 0 & Operators.CompareString(left, "右上合并", false) != 0 & Operators.CompareString(left, "右下合并", false) != 0 & Operators.CompareString(left, "上边合并", false) != 0 & Operators.CompareString(left, "下边合并", false) != 0 & Operators.CompareString(left, "左边合并", false) != 0 & Operators.CompareString(left, "右边合并", false) != 0)
                            {
                                if (Operators.CompareString(Conversions.ToString(print.myms.Columns[i].Tag), "合并", false) == 0)
                                {
                                    if (Operators.CompareString(Conversions.ToString(print.myms.Rows[j].Tag), "合并", false) == 0)
                                    {
                                        print.myms.Rows[j].Cells[i].Tag = "合并";
                                    }
                                    else
                                    {
                                        print.myms.Rows[j].Cells[i].Tag = "垂直合并";
                                    }
                                }
                                else if (Operators.CompareString(Conversions.ToString(print.myms.Rows[j].Tag), "合并", false) == 0)
                                {
                                    print.myms.Rows[j].Cells[i].Tag = "水平合并";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                if (titleFont == null)
                {
                    titleFont = new Font("黑体", 18f, FontStyle.Bold);
                }
                if (subtitlefont == null)
                {
                    subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
                }
                if (topfont == null)
                {
                    topfont = new Font("宋体", 10f, FontStyle.Regular);
                }
                if (bottomfont == null)
                {
                    bottomfont = new Font("宋体", 10f, FontStyle.Regular);
                }
                stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
                if (colsnum == 0)
                {
                    num5 = print.myms.ColumnCount;
                }
                else
                {
                    num5 = colsnum;
                }
                array = new int[num5 - 1 + 1];
                if (colsnum == 0)
                {
                    thecol = new int[num5 - 1 + 1];
                    int num6 = 0;
                    int num7 = num5 - 1;
                    for (int k = num6; k <= num7; k++)
                    {
                        thecol[k] = k;
                    }
                }
                if (fromrow > torow)
                {
                    fromrow = 0;
                }
                if (fromrow <= 0)
                {
                    fromrow = 1;
                }
                if (torow <= 0)
                {
                    torow = print.myms.RowCount;
                }
                fromrow--;
                torow--;
                int[] array2 = new int[num5 - 1 + 1];
                int num8 = 0;
                int num9 = num5 - 1;
                for (int k = num8; k <= num9; k++)
                {
                    array[k] = thecol[k];
                    array2[k] = print.myms.Columns[thecol[k]].DisplayIndex;
                }
                Array.Sort<int, int>(array2, array);
                array3 = new int[num5 + 1];
                array4 = new int[print.myms.RowCount + 1];
                int num10 = 0;
                int num11 = num5 - 1;
                for (int k = num10; k <= num11; k++)
                {
                    array3[k] = print.myms.Columns[thecol[k]].Width;
                }
                array4[0] = Conversions.ToInteger(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0));
                int num12 = fromrow;
                int num13 = torow;
                for (int k = num12; k <= num13; k++)
                {
                    array4[k + 1] = print.myms.Rows[k].Height;
                }
                array5 = new float[num5 - 1 + 1];
                int[] array6 = new int[num5 - 1 + 1];
                num14 = 0f;
                num15 = print.Currentx;
                num16 = num15;
                if (printwidth <= 0f)
                {
                    num17 = unchecked(print.PaperPrintWidth - num16);
                }
                else
                {
                    num17 = printwidth;
                }
                int num18 = 0;
                int num19 = num5 - 1;
                for (int k = num18; k <= num19; k++)
                {
                    unchecked
                    {
                        if (print.myms.Columns[array[k]].Visible)
                        {
                            DataGridViewColumn dataGridViewColumn = print.myms.Columns[array[k]];
                            float num20 = print.ConvFromDisplay((float)dataGridViewColumn.Width, true);
                            array6[k] = dataGridViewColumn.Width;
                            num14 += num20;
                            array5[k] = num20;
                        }
                    }
                }
                mytree = new mytree(columnheadertree, print.myms);
                if (mytree.GetColumns() != print.myms.ColumnCount)
                {
                    columnheadertree = null;
                }
                if (mytitleheight != 0f)
                {
                    int columnHeadersHeight = print.myms.ColumnHeadersHeight;
                    print.myms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    print.myms.ColumnHeadersHeight = columnHeadersHeight;
                }
                else if (columnheadertree != null)
                {
                }
                array7 = new float[print.myms.ColumnCount - 1 + 1];
                if (autoresizewidth)
                {
                    if (num14 == 0f)
                    {
                        if (print.IsShowErrorMSG)
                        {
                            Interaction.MsgBox("不能打印DatGridView表格，当前没有可供打印的列数据", MsgBoxStyle.OkOnly, "提示信息");
                        }
                        return 0f;
                    }
                    float num21 = num17 / num14;
                    int num22 = 0;
                    int num23 = num5 - 1;
                    for (int k = num22; k <= num23; k++)
                    {
                        unchecked
                        {
                            array5[k] *= num21;
                        }
                        print.myms.Columns[array[k]].Width = (int)Math.Round((double)(unchecked((float)array6[k] * num21)));
                        array7[array[k]] = array5[k];
                    }
                    num14 = 0f;
                    int num24 = 0;
                    int num25 = num5 - 1;
                    for (int k = num24; k <= num25; k++)
                    {
                        unchecked
                        {
                            num14 += array5[k];
                        }
                    }
                    if (autoresizerowheight)
                    {
                        print.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    }
                }
                else
                {
                    int num26 = 0;
                    int num27 = num5 - 1;
                    for (int k = num26; k <= num27; k++)
                    {
                        array7[array[k]] = array5[k];
                    }
                }
                result = num14;
            }
            if (alignment == StringAlignment.Center)
            {
                float num28 = num17 - num14;
                num15 = num16 + num28 / 2f;
            }
            else if (alignment == StringAlignment.Far)
            {
                num15 = num16 + num17 - num14;
            }
            int currentPage = print.GetCurrentPage();
            float num29 = 0f;
            num29 = print.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0)), false);
            stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
            StringAlignment myHalg = StringAlignment.Near;
            string text = "";
            bool flag = false;
            StringAlignment myHalg2 = StringAlignment.Near;
            string text2 = "";
            bool flag2 = false;

            if (flag = print.CanSpanPrint(lefttitle, middletitle, righttitle, ref text, ref myHalg))
            {
                if (Operators.CompareString(lefttitle, "", false) != 0)
                {
                    myHalg = TableTopLeftTitleAlign;
                }
                else if (Operators.CompareString(middletitle, "", false) != 0)
                {
                    myHalg = TableTopMiddleTitleAlign;
                }
                else if (Operators.CompareString(righttitle, "", false) != 0)
                {
                    myHalg = TableTopRightTitleAlign;
                }
            }
            if (flag2 = print.CanSpanPrint(bl, bm, br, ref text2, ref myHalg2))
            {
                if (Operators.CompareString(bl, "", false) != 0)
                {
                    myHalg2 = TableBottomLeftTitleAlign;
                }
                else if (Operators.CompareString(bm, "", false) != 0)
                {
                    myHalg2 = TableBottomMiddleTitleAlign;
                }
                else if (Operators.CompareString(br, "", false) != 0)
                {
                    myHalg2 = TableBottomRightTitleAlign;
                }
            }
            float num30;
            float num31;
            float num32;
            float num33;
            float num34;
            float num35;
            if (mytitleheight == 0f)
            {
                if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
                {
                    num30 = 0f;
                    flag = false;
                }
                else if (flag)
                {
                    num30 = print.MeasureCell(text, topfont, num17, stringFormat).Height;
                }
                else
                {
                    SizeF sizeF = print.MeasureCell(lefttitle, topfont, num17 / 3f, stringFormat);
                    SizeF sizeF2 = print.MeasureCell(middletitle, topfont, num17 / 3f, stringFormat);
                    num30 = sizeF.Height;
                    float height = sizeF2.Height;
                    if (num30 < height)
                    {
                        num30 = height;
                    }
                    height = print.MeasureCell(righttitle, topfont, num17 / 3f, stringFormat).Height;
                    if (num30 < height)
                    {
                        num30 = height;
                    }
                }
                num31 = print.MeasureText(title, titleFont, num17, stringFormat).Height;
                if (num31 == 0f)
                {
                    num32 = 0f;
                }
                else
                {
                    num32 = (float)((double)print.MeasureText("游", titleFont, num14, stringFormat).Height / 2.5);
                }
                num33 = print.MeasureText(subtitle, subtitlefont, num17, stringFormat).Height;
                if (num33 == 0f)
                {
                    num34 = 0f;
                }
                else
                {
                    num34 = (float)((double)print.MeasureText("平", subtitlefont, num14, stringFormat).Height / 2.5);
                }
                if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(br, "", false) == 0 & Operators.CompareString(bm, "", false) == 0)
                {
                    num35 = 0f;
                    flag2 = false;
                }
                else
                {
                    if (flag2)
                    {
                        num35 = print.MeasureCell(text2, bottomfont, num17, stringFormat).Height;
                    }
                    else
                    {
                        SizeF sizeF = print.MeasureCell(bl, bottomfont, num17 / 3f, stringFormat);
                        SizeF sizeF2 = print.MeasureCell(bm, bottomfont, num17 / 3f, stringFormat);
                        num35 = sizeF.Height;
                        float height = sizeF2.Height;
                        if (num35 < height)
                        {
                            num35 = height;
                        }
                        height = print.MeasureCell(br, bottomfont, num17 / 3f, stringFormat).Height;
                        if (num35 < height)
                        {
                            num35 = height;
                        }
                    }
                    num35 += print.MeasureText("测试", new Font("宋体", 12f)).Height / 8f;
                }
                if (print.OuterBorder)
                {
                    num30 = num30 + print.DoubleLineSpace + print.OuterBorderWidth / 2f;
                    num35 = num35 + print.DoubleLineSpace + print.OuterBorderWidth / 2f;
                }
                else if (print.IsUseDoubleLine)
                {
                    num30 += print.DoubleLineSpace / 2f;
                    num35 += print.DoubleLineSpace / 2f;
                }
            }
            else
            {
                num31 = mytitleheight;
                num33 = mysubtitleheight;
                num32 = myoneline1height;
                num34 = myoneline2height;
                num30 = mytopheight;
                num35 = mybottomheight;
            }
            int num36 = -1;
            int num37 = 0;
            checked
            {
                int num38 = print.myms.RowCount - 1;
                int k = num37;
                while (k <= num38)
                {
                    if (!print.myms.Rows[k].Visible)
                    {
                        k++;
                    }
                    else
                    {
                        num36 = k;
                    IL_B68:
                        mytree mytree2;
                        float doubleLineSpace;
                        float num42;
                        bool flag3;
                        float[] array8;
                        float currenty=0;
                        Color textforecolor = new Color();
                        bool mulline=false;
                        unchecked
                        {
                            if (num36 == -1)
                            {
                                print.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(print.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(print.OuterBorder, print.DoubleLineSpace + print.OuterBorderWidth / 2f, 0)))) + print.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0)), false), true);
                            }
                            else
                            {
                                if (print.Currenty > 0f)
                                {
                                    print.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(print.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(print.OuterBorder, print.DoubleLineSpace + print.OuterBorderWidth / 2f, 0)))) + print.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0)), false) + print.ConvFromDisplay((float)print.myms.Rows[num36].Height, false), true);
                                }
                                if (num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(print.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(print.OuterBorder, print.DoubleLineSpace + print.OuterBorderWidth / 2f, 0)))) + print.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0)), false) + print.ConvFromDisplay((float)print.myms.Rows[num36].Height, false) > print.PaperPrintHeight)
                                {
                                    try
                                    {
                                        print.myms.Rows[num36].Height = checked((int)Math.Round((double)print.ConvToDisplay(unchecked(print.PaperPrintHeight - (num31 + num32 + num33 + num34 + num30 + Conversions.ToSingle(Interaction.IIf(print.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(print.OuterBorder, print.DoubleLineSpace + print.OuterBorderWidth / 2f, 0)))) + print.ConvFromDisplay(Conversions.ToSingle(Interaction.IIf(print.myms.ColumnHeadersVisible, print.myms.ColumnHeadersHeight, 0)), false))), false)));
                                    }
                                    catch (Exception ex2)
                                    {
                                    }
                                }
                            }
                            currentPage = print.GetCurrentPage();
                            mytree2 = new mytree(columnheadertree, print.myms, array7);
                            float num39 = 0f;
                            float num40 = 0f;
                            doubleLineSpace = print.DoubleLineSpace;
                            float num41 = print.ConvFromDisplay((float)print.myms.ColumnHeadersHeight, false);
                            num42 = 0f;
                            flag3 = true;
                            array8 = new float[4];
                            array8 = print.ParaseBorder(myborder);
                            int num43 = fromrow;
                            int num44 = torow;
                            k = num43;
                            while (k <= num44 && !print.CancelDocument)
                            {
                                print.Currentx = num15;
                                if (!(currentPage != print.GetCurrentPage() | k == fromrow))
                                {
                                    goto IL_2085;
                                }
                                currentPage = print.GetCurrentPage();
                                flag3 = true;
                                if (k == 0 || reppagetitle)
                                {
                                    if (Operators.CompareString(title, "", false) != 0)
                                    {
                                        print.Currentx = num16;
                                        print.DrawText(title, num17, num31, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
                                        print.NewRow(num31 + num32);
                                    }
                                    print.Currentx = num16;
                                    if (Operators.CompareString(subtitle, "", false) != 0)
                                    {
                                        print.DrawText(subtitle, num17, num33, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
                                        print.NewRow(num33 + num34);
                                    }
                                    if (Operators.CompareString(lefttitle, "", false) == 0 & Operators.CompareString(middletitle, "", false) == 0 & Operators.CompareString(righttitle, "", false) == 0)
                                    {
                                        print.NewRow(num30);
                                    }
                                    else if (flag)
                                    {
                                        print.Currentx = num16;
                                        print.DrawText(text, num17, num30, topfont, myHalg, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        print.NewRow(num30);
                                    }
                                    else
                                    {
                                        print.Currentx = num16;
                                        print.DrawText(lefttitle, num17 / 3f, num30, topfont, TableTopLeftTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        print.DrawText(middletitle, num17 / 3f, num30, topfont, TableTopMiddleTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        print.DrawText(righttitle, num17 / 3f, num30, topfont, TableTopRightTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        print.NewRow(num30);
                                    }
                                }
                                print.Currentx = num15;
                                currenty = print.Currenty;
                                num42 = 0f;
                                if (print.myms.ColumnHeadersVisible)
                                {
                                    checked
                                    {
                                        if (columnheadertree == null)
                                        {
                                            bool flag4 = true;
                                            int num45 = 0;
                                            int num46 = num5 - 1;
                                            for (int l = num45; l <= num46; l++)
                                            {
                                                DataGridViewColumn dataGridViewColumn = print.myms.Columns[array[l]];
                                                unchecked
                                                {
                                                    if (dataGridViewColumn.Visible)
                                                    {
                                                        if (print.IsUseDoubleLine)
                                                        {
                                                            if (flag4)
                                                            {
                                                                print.Currentx += doubleLineSpace / 2f;
                                                            }
                                                            else
                                                            {
                                                                print.Currentx += doubleLineSpace;
                                                            }
                                                            print.Currenty = currenty + doubleLineSpace / 2f;
                                                            print.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l] - doubleLineSpace, num41 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
                                                        }
                                                        else
                                                        {
                                                            print.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l], num41, myborder, PrintBackColor, minfontsize);
                                                        }
                                                        flag4 = false;
                                                        num42 += array5[l];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            int leves = mytree2.GetLeves();
                                            int num47 = 0;
                                            int num48 = num5 - 1;
                                            for (int l = num47; l <= num48; l++)
                                            {
                                                unchecked
                                                {
                                                    if (print.myms.Columns[array[l]].Visible)
                                                    {
                                                        num42 += array5[l];
                                                    }
                                                }
                                            }
                                            int num49 = 1;
                                            int num50 = leves;
                                            for (int m = num49; m <= num50; m++)
                                            {
                                                print.Currentx = num15;
                                                int num51;
                                                unchecked
                                                {
                                                    if (print.IsUseDoubleLine)
                                                    {
                                                        print.Currentx = num15 + doubleLineSpace / 2f;
                                                    }
                                                    print.Currenty = currenty + num29 / (float)leves * (float)(checked(m - 1));
                                                    if (print.IsUseDoubleLine)
                                                    {
                                                        print.Currenty += doubleLineSpace / 2f;
                                                    }
                                                    num51 = 0;
                                                }
                                                int num52 = num5 - 1;
                                                for (int l = num51; l <= num52; l++)
                                                {
                                                    DataGridViewColumn dataGridViewColumn = print.myms.Columns[array[l]];
                                                    unchecked
                                                    {
                                                        if (dataGridViewColumn.Visible)
                                                        {
                                                            float num53 = mytree2.GetCellHeight(array[l], m);
                                                            float cellWidth = mytree2.GetCellWidth(array[l], m);
                                                            num53 = print.ConvFromDisplay(num53, false);
                                                            string nodeText = mytree2.GetNodeText(array[l], m);
                                                            if (num53 == 0f | cellWidth == 0f)
                                                            {
                                                                print.Currentx += array5[l];
                                                            }
                                                            else if (dataGridViewColumn.Visible)
                                                            {
                                                                Font font = mytree2.GetNodeFont(array[l], m);
                                                                if (font == null)
                                                                {
                                                                    font = Module1.GetDGVHeaderFont(dataGridViewColumn);
                                                                }
                                                                textforecolor = mytree2.GetNodeForeColor(array[l], m);
                                                                if (textforecolor.IsEmpty)
                                                                {
                                                                    textforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
                                                                }
                                                                mulline = Module1.GetDGVHeaderMulline(dataGridViewColumn);
                                                                Color backcolor = mytree2.GetNodeBackColor(array[l], m);
                                                                if (backcolor.IsEmpty)
                                                                {
                                                                    backcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
                                                                }
                                                                mulline = true;
                                                                if (print.IsUseDoubleLine)
                                                                {
                                                                    if (!PrintBackColor)
                                                                    {
                                                                        print.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, print.myms.GridColor, 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        print.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, print.myms.GridColor, 0);
                                                                    }
                                                                    print.Currentx = print.Currentx + array5[l] + doubleLineSpace - cellWidth;
                                                                }
                                                                else
                                                                {
                                                                    if (!PrintBackColor)
                                                                    {
                                                                        print.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, print.myms.GridColor, 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        print.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, print.myms.GridColor, 0);
                                                                    }
                                                                    print.Currentx = print.Currentx + array5[l] - cellWidth;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (print.IsUseDoubleLine)
                                    {
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num41);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num41);
                                    }
                                    if (print.OuterBorder)
                                    {
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num41);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace - print.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + print.OuterBorderWidth / 2f, currenty - doubleLineSpace);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num41);
                                    }
                                    flag3 = false;
                                }
                                print.Currentx = num15;
                                print.Currenty = currenty + num29;
                                if (print.Currenty + print.ConvFromDisplay((float)print.myms.Rows[k].Height, false) > print.PaperPrintHeight)
                                {
                                    try
                                    {
                                        print.myms.Rows[k].Height = checked((int)Math.Round((double)print.ConvToDisplay(unchecked(print.PaperPrintHeight - print.Currenty), false)));
                                        goto IL_2085;
                                    }
                                    catch (Exception ex3)
                                    {
                                        goto IL_2085;
                                    }
                                }
                                goto IL_2085;
                            IL_207A:
                                DataGridViewRow dataGridViewRow;
                                checked
                                {
                                    k++;
                                    continue;
                                IL_162A:
                                    dataGridViewRow = print.myms.Rows[k];
                                    bool flag4 = true;
                                    currenty = print.Currenty;
                                    num42 = 0f;
                                    int num54 = 0;
                                    int num55 = num5 - 1;
                                    for (int l = num54; l <= num55; l++)
                                    {
                                        if (Module1.G_CancelDocument)
                                        {
                                            goto IL_278C;
                                        }
                                        DataGridViewColumn dataGridViewColumn = print.myms.Columns[array[l]];
                                        unchecked
                                        {
                                            if (dataGridViewColumn.Visible)
                                            {
                                                num40 = array5[l];
                                                num42 += num40;
                                                num39 = print.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                                string left2 = Conversions.ToString(dataGridViewRow.Cells[array[l]].Tag);
                                                if (Operators.CompareString(left2, "垂直合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (Operators.CompareString(left2, "上合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (Operators.CompareString(left2, "下合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (Operators.CompareString(left2, "水平合并", false) != 0)
                                                {
                                                    if (Operators.CompareString(left2, "左合并", false) != 0)
                                                    {
                                                        if (Operators.CompareString(left2, "右合并", false) != 0)
                                                        {
                                                            if (Operators.CompareString(left2, "合并", false) != 0)
                                                            {
                                                                if (Operators.CompareString(left2, "左上合并", false) != 0)
                                                                {
                                                                    if (Operators.CompareString(left2, "左下合并", false) != 0)
                                                                    {
                                                                        if (Operators.CompareString(left2, "右上合并", false) != 0)
                                                                        {
                                                                            if (Operators.CompareString(left2, "右下合并", false) != 0)
                                                                            {
                                                                                if (Operators.CompareString(left2, "上边合并", false) != 0)
                                                                                {
                                                                                    if (Operators.CompareString(left2, "下边合并", false) != 0)
                                                                                    {
                                                                                        if (Operators.CompareString(left2, "左边合并", false) != 0)
                                                                                        {
                                                                                            if (Operators.CompareString(left2, "右边合并", false) != 0)
                                                                                            {
                                                                                                if (Operators.CompareString(left2, "#*已水平合并*#", false) == 0)
                                                                                                {
                                                                                                    goto IL_1942;
                                                                                                }
                                                                                                if (Operators.CompareString(left2, "#*已垂直合并*#", false) == 0)
                                                                                                {
                                                                                                    print.Currentx += array5[l];
                                                                                                    goto IL_1942;
                                                                                                }
                                                                                                goto IL_1878;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            print.GetHVMergeWidthAndHeight(print.myms, num5, l, k, array, array5, torow, ref num40, ref num39);
                                                            goto IL_1878;
                                                        }
                                                    }
                                                }
                                                int num56;
                                                num40 = print.GetHMergeWidth(print.myms, num5, l, k, array, array5, ref num56, true);
                                            IL_1878:
                                                if (print.IsUseDoubleLine)
                                                {
                                                    if (flag4)
                                                    {
                                                        print.Currentx += doubleLineSpace / 2f;
                                                    }
                                                    else
                                                    {
                                                        print.Currentx += doubleLineSpace;
                                                    }
                                                    if (flag3)
                                                    {
                                                        print.Currenty = currenty + doubleLineSpace / 2f;
                                                    }
                                                    else
                                                    {
                                                        print.Currenty = currenty + doubleLineSpace / 2f;
                                                    }
                                                    print.MyDrawDGVCell(print.myms.Rows[k].Cells[array[l]], num40 - doubleLineSpace, num39 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
                                                }
                                                else
                                                {
                                                    print.MyDrawDGVCell(print.myms.Rows[k].Cells[array[l]], num40, num39, myborder, PrintBackColor, minfontsize);
                                                }
                                                flag4 = false;
                                                goto IL_1942;
                                            IL_185F:
                                                num39 = print.GetVMergeHeight(print.myms, l, k, array, torow, ref num56, true);
                                                goto IL_1878;
                                            }
                                        IL_1942:;
                                        }
                                    }
                                }
                                if (print.IsUseDoubleLine)
                                {
                                    if (flag3)
                                    {
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num39);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                    else
                                    {
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                }
                                if (print.OuterBorder)
                                {
                                    if (flag3)
                                    {
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace - print.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + print.OuterBorderWidth / 2f, currenty - doubleLineSpace);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num39);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                    else
                                    {
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                }
                                if (flag3)
                                {
                                    flag3 = false;
                                }
                                print.Currenty = currenty + print.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                currenty = print.Currenty;
                                if (k == torow)
                                {
                                    break;
                                }
                                dataGridViewRow = print.myms.Rows[checked(k + 1)];
                                float num57 = print.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                if (print.IsDrawTableFooterEveryPage && print.IsNewPage(num57 + num35))
                                {
                                    if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(bm, "", false) == 0 & Operators.CompareString(br, "", false) == 0)
                                    {
                                        print.Currenty += num35;
                                    }
                                    else
                                    {
                                        bool isNeedCheckNewPage = print.IsNeedCheckNewPage;
                                        print.IsNeedCheckNewPage = false;
                                        if (flag2)
                                        {
                                            print.Currentx = num16;
                                            print.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            print.NewRow(num35);
                                        }
                                        else
                                        {
                                            print.Currentx = num16;
                                            print.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            print.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            print.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            print.NewRow(num35);
                                        }
                                        print.IsNeedCheckNewPage = isNeedCheckNewPage;
                                        print.Currenty += num35;
                                    }
                                }
                                if (!(print.IsUseDoubleLine | print.OuterBorder))
                                {
                                    print.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(print.OuterBorder, print.OuterBorderWidth / 2f, 0)), true);
                                    goto IL_207A;
                                }
                                if (print.IsUseDoubleLine)
                                {
                                    if (print.IsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(print.OuterBorder, print.OuterBorderWidth / 2f, 0))))
                                    {
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        if (print.OuterBorder)
                                        {
                                            print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace - print.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + print.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                            print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                            print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                                        }
                                        print.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(print.OuterBorder, print.OuterBorderWidth / 2f, 0)), true);
                                        goto IL_207A;
                                    }
                                    goto IL_207A;
                                }
                                else
                                {
                                    if (print.OuterBorder && print.IsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(print.OuterBorder, print.OuterBorderWidth / 2f, 0))))
                                    {
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace - print.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + print.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                                        print.MyIsNewPage(num57 + Conversions.ToSingle(Interaction.IIf(print.OuterBorder, print.OuterBorderWidth / 2f, 0)), true);
                                        goto IL_207A;
                                    }
                                    goto IL_207A;
                                }
                            IL_278C:
                                return 0f;
                            IL_2085:
                                if (!print.myms.Rows[k].Visible)
                                {
                                    goto IL_207A;
                                }

                            }
                        }
                        if (print.IsAutoAddEmptyRow && CanAddEmptyRow)
                        {
                            int num58;
                            try
                            {
                                num58 = (int)Math.Round(Math.Floor((double)(unchecked(print.PaperPrintHeight - print.Currenty - num35) / print.ConvFromDisplay((float)print.myms.Rows[torow].Height, false))));
                            }
                            catch (Exception ex4)
                            {
                                num58 = 0;
                            }
                            if (Module1.G_CancelDocument)
                            {
                                return 0f;
                            }
                            DataGridViewRow dataGridViewRow = print.myms.Rows[torow];
                            float num39 = print.ConvFromDisplay((float)dataGridViewRow.Height, false);
                            num42 = 0f;
                            int num59 = 1;
                            int num60 = num58;
                            for (int n = num59; n <= num60; n++)
                            {
                                print.Currentx = num15;
                                currenty = print.Currenty;
                                bool flag4 = true;
                                num42 = 0f;
                                int num61 = 0;
                                int num62 = num5 - 1;
                                for (int l = num61; l <= num62; l++)
                                {
                                    DataGridViewColumn dataGridViewColumn = print.myms.Columns[array[l]];
                                    unchecked
                                    {
                                        if (dataGridViewColumn.Visible)
                                        {
                                            float num40 = array5[l];
                                            num42 += num40;
                                            Color backcolor = Color.White;
                                            if (print.IsUseDoubleLine)
                                            {
                                                if (flag4)
                                                {
                                                    print.Currentx += doubleLineSpace / 2f;
                                                }
                                                else
                                                {
                                                    print.Currentx += doubleLineSpace;
                                                }
                                                if (flag3)
                                                {
                                                    print.Currenty = currenty + doubleLineSpace / 2f;
                                                }
                                                else
                                                {
                                                    print.Currenty = currenty + doubleLineSpace / 2f;
                                                }
                                                if (!PrintBackColor)
                                                {
                                                    print.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, print.myms.GridColor, 0);
                                                }
                                                else
                                                {
                                                    print.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, print.myms.GridColor, 0);
                                                }
                                            }
                                            else if (!PrintBackColor)
                                            {
                                                print.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, print.myms.GridColor, 0);
                                            }
                                            else
                                            {
                                                print.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, print.myms.GridColor, 0);
                                            }
                                            flag4 = false;
                                        }
                                    }
                                }
                                unchecked
                                {
                                    if (print.IsUseDoubleLine)
                                    {
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
                                        print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                    if (print.OuterBorder)
                                    {
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
                                        print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                    print.Currenty = currenty + num39;
                                    currenty = print.Currenty;
                                }
                            }
                        }
                        int num63;
                        unchecked
                        {
                            if (print.IsUseDoubleLine)
                            {
                                print.DrawLine(new Pen(print.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                print.DrawLine(new Pen(print.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                print.DrawLine(new Pen(print.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                            }
                            if (print.OuterBorder)
                            {
                                print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace - print.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + print.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                print.DrawLine(new Pen(print.OuterBorderColor, print.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                            }
                            if (Operators.CompareString(bl, "", false) == 0 & Operators.CompareString(bm, "", false) == 0 & Operators.CompareString(br, "", false) == 0)
                            {
                                print.NewRow(num35);
                            }
                            else
                            {
                                print.MyIsNewPage(num35, true);
                                if (flag2)
                                {
                                    print.Currentx = num16;
                                    print.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    print.NewRow(num35);
                                }
                                else
                                {
                                    print.Currentx = num16;
                                    print.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    print.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    print.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    print.NewRow(num35);
                                }
                            }
                            print.Currentx = 0f;
                            if (Module1.G_CancelDocument)
                            {
                                return 0f;
                            }
                            num63 = 0;
                        }
                        int num64 = num5 - 1;
                        for (k = num63; k <= num64; k++)
                        {
                            print.myms.Columns[thecol[k]].Width = array3[k];
                        }
                        try
                        {
                            if (array4[0] != 0)
                            {
                                print.myms.ColumnHeadersHeight = array4[0];
                            }
                        }
                        catch (Exception ex5)
                        {
                        }
                        int num65 = fromrow;
                        int num66 = torow;
                        for (k = num65; k <= num66; k++)
                        {
                            print.myms.Rows[k].Height = array4[k + 1];
                        }
                        try
                        {
                            mytree2.Dispose();
                            mytree2 = null;
                            mytree.Dispose();
                            mytree = null;
                            stringFormat.Dispose();
                            stringFormat = null;
                            stringFormat2.Dispose();
                            stringFormat2 = null;
                            array = null;
                            array3 = null;
                            array4 = null;
                            array5 = null;
                            array7 = null;
                            return result;
                        }
                        catch (Exception ex6)
                        {
                            return result;
                        }

                    }
                }

            }

            return result;
        }





        public static void MyDrawDGVCell(this VB2008Print print, DataGridViewCell dgvcell, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
        {
            checked
            {
                if (dgvcell != null)
                {
                    DataGridView dataGridView = dgvcell.DataGridView;
                    string s = "";
                    Bitmap bitmap = null;
                    DataGridViewColumn dataGridViewColumn = dataGridView.Columns[dgvcell.ColumnIndex];
                    DataGridViewRow dataGridViewRow = dataGridView.Rows[dgvcell.RowIndex];
                    if (dataGridViewColumn.Visible)
                    {
                        Margins cellMargin = print.CellMargin;
                        if (print.IsUseDGVPadding)
                        {
                            Margins dgvcellPadding = Module1.GetDGVCellPadding(dgvcell);
                            print.CellMargin = new Margins((int)Math.Round((double)print.ConvFromDisplay((float)dgvcellPadding.Left, true)), (int)Math.Round((double)print.ConvFromDisplay((float)dgvcellPadding.Right, true)), (int)Math.Round((double)print.ConvFromDisplay((float)dgvcellPadding.Top, false)), (int)Math.Round((double)print.ConvFromDisplay((float)dgvcellPadding.Bottom, false)));
                        }
                        if (mycellwidth <= 0f)
                        {
                            mycellwidth = print.ConvFromDisplay((float)dataGridViewColumn.Width, true);
                        }
                        if (mycellheight <= 0f)
                        {
                            mycellheight = print.ConvFromDisplay((float)dataGridViewRow.Height, false);
                        }
                        Font myf = Module1.GetDGVCellFont(dgvcell);
                        DataGridViewCellStyle dataGridViewCellStyle = Module1.GetDGVCellStyle(dgvcell);
                        Color dgvcellForeColor = Module1.GetDGVCellForeColor(dgvcell);
                        Color dgvcellBackColor = Module1.GetDGVCellBackColor(dgvcell);
                        bool dgvcellMulline = Module1.GetDGVCellMulline(dgvcell);
                        bool flag = false;
                        int num=0;
                        if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewCheckBoxColumn", false) == 0)
                        {
                            CheckBox checkBox = new CheckBox();
                            Control control = checkBox;
                            Size size = new Size(14, 14);
                            control.Size = size;
                            if (isprintbackcolor)
                            {
                                checkBox.BackColor = dgvcellBackColor;
                            }
                            else
                            {
                                checkBox.BackColor = Color.Transparent;
                            }
                            if (Operators.CompareString(Versioned.TypeName(RuntimeHelpers.GetObjectValue(dgvcell.FormattedValue)), "Boolean", false) == 0)
                            {
                                if (Conversions.ToBoolean(dgvcell.FormattedValue))
                                {
                                    checkBox.Checked = true;
                                }
                                else
                                {
                                    checkBox.Checked = false;
                                }
                            }
                            else
                            {
                                switch (Conversions.ToInteger(dgvcell.FormattedValue))
                                {
                                    case 0:
                                        checkBox.Checked = false;
                                        break;
                                    case 1:
                                        checkBox.Checked = true;
                                        break;
                                    default:
                                        checkBox.CheckState = CheckState.Indeterminate;
                                        break;
                                }
                            }
                            if (bitmap != null)
                            {
                                try
                                {
                                    bitmap.Dispose();
                                    bitmap = null;
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            try
                            {
                                bitmap = new Bitmap((int)Math.Round((double)print.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)print.ConvToDisplay(mycellheight, false)));
                                Graphics graphics = Graphics.FromImage(bitmap);
                                Brush brush;
                                if (isprintbackcolor)
                                {
                                    brush = new SolidBrush(dgvcellBackColor);
                                }
                                else
                                {
                                    brush = Brushes.White;
                                }
                                Graphics graphics2 = graphics;
                                Brush brush2 = brush;
                                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                                graphics2.FillRectangle(brush2, rectangle);
                                if (bitmap.Height < checkBox.Height)
                                {
                                    checkBox.Height = bitmap.Height;
                                }
                                if (bitmap.Width < checkBox.Width)
                                {
                                    checkBox.Width = bitmap.Width;
                                }
                                Control control2 = checkBox;
                                Bitmap bitmap2 = bitmap;
                                rectangle = new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height);
                                control2.DrawToBitmap(bitmap2, rectangle);
                                graphics.Dispose();
                                checkBox.Dispose();
                                checkBox = null;
                            }
                            catch (Exception ex2)
                            {
                            }
                            flag = true;
                            num = 2;
                        }
                        else if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewButtonColumn", false) == 0)
                        {
                            Button button = new Button();
                            button.AutoSize = false;
                            Control control3 = button;
                            Size size = new Size((int)Math.Round((double)print.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)print.ConvToDisplay(mycellheight, false)));
                            control3.Size = size;
                            button.Text = "";
                            if (isprintbackcolor)
                            {
                                button.BackColor = dgvcellBackColor;
                            }
                            else
                            {
                                button.BackColor = Color.Transparent;
                            }
                            float currentx = print.Currentx;
                            float currenty = print.Currenty;
                            try
                            {
                                bitmap = new Bitmap(button.Width, dataGridViewRow.Height);
                                Control control4 = button;
                                Bitmap bitmap3 = bitmap;
                                Rectangle rectangle = new Rectangle(0, 0, button.Width, (int)Math.Round((double)print.ConvToDisplay(mycellheight, false)));
                                control4.DrawToBitmap(bitmap3, rectangle);
                                print.DrawCellImage(bitmap, print.Currentx, print.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, "0000", true, StringAlignment.Center, StringAlignment.Center);
                                bitmap.Dispose();
                                bitmap = null;
                                button.Dispose();
                            }
                            catch (Exception ex3)
                            {
                            }
                            print.Currentx = currentx;
                            print.Currenty = currenty;
                            flag = true;
                            num = 3;
                        }
                        else if (Operators.CompareString(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
                        {
                            flag = true;
                            num = 1;
                        }
                        else
                        {
                            s = Conversions.ToString(dgvcell.FormattedValue) + "";
                        }
                        if (!flag)
                        {
                            if (!isprintbackcolor)
                            {
                                print.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, print.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                            }
                            else
                            {
                                print.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, print.IsDGVCellValignmentCenter), dgvcellMulline, false, false, false, minfontsize, dgvcellBackColor, dataGridView.GridColor, 0);
                            }
                        }
                        else if (num == 1)
                        {
                            DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)dgvcell;
                            print.DrawCellImage((Bitmap)dgvcell.FormattedValue, print.Currentx, print.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, dataGridViewImageCell.ImageLayout, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, print.IsDGVCellValignmentCenter));
                        }
                        else if (num == 2)
                        {
                            print.DrawCellImage(bitmap, print.Currentx, print.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, true, StringAlignment.Center, StringAlignment.Center);
                        }
                        else if (num == 3)
                        {
                            s = Conversions.ToString(dgvcell.FormattedValue) + "";
                            print.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, print.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                        }
                        if (print.IsUseDGVPadding)
                        {
                            print.CellMargin = cellMargin;
                        }
                    }
                    if (bitmap != null)
                    {
                        try
                        {
                            bitmap.Dispose();
                            bitmap = null;
                        }
                        catch (Exception ex4)
                        {
                        }
                    }
                    try
                    {
                        dataGridView = null;
                        Font myf = null;
                        DataGridViewCellStyle dataGridViewCellStyle = null;
                    }
                    catch (Exception ex5)
                    {
                    }
                }
            }
        }



        public static void MyDrawDGVHeaderCell(this VB2008Print print, DataGridViewColumn mycolumn, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
        {
            if (mycolumn != null)
            {
                DataGridView dataGridView = mycolumn.DataGridView;
                if (mycolumn.Visible)
                {
                    if (mycellwidth <= 0f)
                    {
                        mycellwidth = print.ConvFromDisplay((float)mycolumn.Width, true);
                    }
                    if (mycellheight <= 0f)
                    {
                        mycellheight = print.ConvFromDisplay((float)dataGridView.ColumnHeadersHeight, false);
                    }
                    Font dgvheaderFont = Module1.GetDGVHeaderFont(mycolumn);
                    Color dgvheaderForeColor = Module1.GetDGVHeaderForeColor(mycolumn);
                    bool mulline = Module1.GetDGVHeaderMulline(mycolumn);
                    Color dgvheaderBackColor = Module1.GetDGVHeaderBackColor(mycolumn);
                    mulline = true;
                    if (!isprintbackcolor)
                    {
                        print.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                    }
                    else
                    {
                        print.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, dgvheaderBackColor, dataGridView.GridColor, 0);
                    }
                }
                try
                {
                }
                catch (Exception ex)
                {
                }
            }
        }




        // Token: 0x060013AC RID: 5036 RVA: 0x0009633C File Offset: 0x0009453C
        public static int GetDGVVisibleCols(this DataGridView myd)
        {
            checked
            {
                int result;
                if (myd == null)
                {
                    result = 0;
                }
                else
                {
                    int num = 0;
                    int num2 = 0;
                    int num3 = myd.ColumnCount - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        if (myd.Columns[i].Visible)
                        {
                            num++;
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

    }
}
