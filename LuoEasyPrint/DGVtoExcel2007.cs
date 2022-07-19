using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace LuoEasyPrint
{
    // Token: 0x0200011B RID: 283
    [StandardModule]
    internal sealed class DGVtoExcel2007
    {
        // Token: 0x06001CBA RID: 7354 RVA: 0x000E42D8 File Offset: 0x000E24D8
        public static bool DGVToExcel(DataGridView mydgv, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", string sheetname = "", bool numericmode = true)
        {
            bool result = DGVtoExcel2007.myDGVToExcel(mydgv, null, title, FileName, Tableheader, TableFooter, sheetname, numericmode);
            GC.Collect();
            return result;
        }

        // Token: 0x06001CBB RID: 7355 RVA: 0x000E42FC File Offset: 0x000E24FC
        public static bool DGVToExcel(DataGridView mydgv, TreeView columnheadertree, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", bool numericmode = true)
        {
            bool result = DGVtoExcel2007.myDGVToExcel(mydgv, columnheadertree, title, FileName, Tableheader, TableFooter, "", numericmode);
            GC.Collect();
            return result;
        }

        // Token: 0x06001CBC RID: 7356 RVA: 0x000E4324 File Offset: 0x000E2524
        private static bool myDGVToExcel(DataGridView mydgv, TreeView columnheadertree, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", string sheetname = "", bool numericmode = true)
        {
            return DGVtoExcel2007.myDGVToExcel(mydgv, columnheadertree, new Font("黑体", 18f, FontStyle.Bold), title, FileName, new Font("宋体", 12f), Tableheader, new Font("宋体", 12f), TableFooter, sheetname, true, true, null, numericmode, false, false);
        }

        // Token: 0x06001CBD RID: 7357 RVA: 0x000E4378 File Offset: 0x000E2578
        public static bool myDGVToExcel(DataGridView mydgv, TreeView columnheadertree, Font titlefont, string title, string FileName, Font tableheaderfont, string Tableheader, Font tablefooterfont, string TableFooter, string sheetname, bool isopenfile, bool isshowprogress = true, Image pic = null, bool numericmode = true, bool saveformula = false, bool addmode = false)
        {
            DGVtoExcel2007.w_saveformula = saveformula;
            checked
            {
                bool result;
                if (mydgv == null)
                {
                    result = false;
                }
                else
                {
                    if (titlefont == null)
                    {
                        titlefont = new Font("黑体", 18f, FontStyle.Bold);
                    }
                    if (tableheaderfont == null)
                    {
                        tableheaderfont = new Font("宋体", 12f);
                    }
                    if (tablefooterfont == null)
                    {
                        tablefooterfont = new Font("宋体", 12f);
                    }
                    progressexcel progressexcel = null;
                    Module1.G_CancelExportDGVToExcel = false;
                    if (isshowprogress)
                    {
                        progressexcel = new progressexcel();
                        progressexcel.TopMost = true;
                        progressexcel.Visible = true;
                    }
                    Ruler ruler = new Ruler();
                    try
                    {
                        if (isshowprogress)
                        {
                            progressexcel.Label1.Text = "正在做导出前的准备，请稍侯……";
                            progressexcel.ProgressBar1.Value = 0;
                            Application.DoEvents();
                        }
                        int columnCount = mydgv.ColumnCount;
                        int[] array = new int[columnCount - 1 + 1];
                        int[] array2 = new int[columnCount - 1 + 1];
                        int num = 0;
                        int num2 = 0;
                        int num3 = columnCount - 1;
                        for (int i = num2; i <= num3; i++)
                        {
                            array[i] = i;
                            array2[i] = mydgv.Columns[i].DisplayIndex;
                            if (mydgv.Columns[i].Visible)
                            {
                                num++;
                            }
                        }
                        if (num <= 0)
                        {
                            if (isshowprogress)
                            {
                                progressexcel.Close();
                                progressexcel.Dispose();
                            }
                            result = true;
                        }
                        else
                        {
                            Array.Sort<int, int>(array2, array);
                            int[] array3 = new int[num - 1 + 1];
                            int j = 0;
                            int num4 = 0;
                            int num5 = columnCount - 1;
                            for (int i = num4; i <= num5; i++)
                            {
                                if (mydgv.Columns[array[i]].Visible)
                                {
                                    array3[j] = array[i];
                                    j++;
                                }
                            }
                            DGVtoExcel2007.w_ZDYcolors = 8;
                            int endcol = num - 1;
                            if (String.Compare(FileName, "", false) == 0)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.Title = "请选择要导出Excel文件的路径和文件名";
                                saveFileDialog.AddExtension = true;
                                saveFileDialog.OverwritePrompt = false;
                                saveFileDialog.DefaultExt = "xls";
                                saveFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
                                saveFileDialog.FileName = string.Concat(new string[]
                                {
                                    Convert.ToString(DateAndTime.Today.Year),
                                    "-",
                                    Convert.ToString(DateAndTime.Today.Month),
                                    "-",
                                    Convert.ToString(DateAndTime.Today.Day)
                                });
                                if (isshowprogress)
                                {
                                    progressexcel.Visible = false;
                                }
                                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                                {
                                    if (isshowprogress)
                                    {
                                        progressexcel.Close();
                                        progressexcel.Dispose();
                                    }
                                    saveFileDialog.Dispose();
                                    return false;
                                }
                                FileName = saveFileDialog.FileName;
                                saveFileDialog.Dispose();
                                if (isshowprogress)
                                {
                                    progressexcel.Visible = true;
                                }
                            }
                            DGVtoExcel2007.w_font = null;
                            DGVtoExcel2007.w_ifont = null;
                            DGVtoExcel2007.w_Cellstyle = null;
                            DGVtoExcel2007.w_iCellstyle = null;
                            DGVtoExcel2007.w_color = null;
                            if (MyProject.Computer.FileSystem.FileExists(FileName))
                            {
                                if (isshowprogress)
                                {
                                    progressexcel.Visible = false;
                                }
                                if (!addmode)
                                {
                                    switch (Interaction.MsgBox("选择的文件【" + FileName + "】已经存在，您确定要覆盖原来的文件吗？注意：覆盖原文件后，原文件中的全部数据都将丢失！\r\n单击[是]按钮，将覆盖原文件，单击[否]按钮，导出数据将以追加的形式添加到文件中，单击[取消]按钮将取消导出", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息"))
                                    {
                                        case MsgBoxResult.Cancel:
                                            if (isshowprogress)
                                            {
                                                progressexcel.Close();
                                                progressexcel.Dispose();
                                            }
                                            return false;
                                        case MsgBoxResult.Yes:
                                            try
                                            {
                                                MyProject.Computer.FileSystem.DeleteFile(FileName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                                            }
                                            catch (Exception ex)
                                            {
                                                Interaction.MsgBox("数据导出失败，原因是文件【" + FileName + "】无法覆盖，可能该文件正在使用中，请关闭该文件后再试", MsgBoxStyle.Exclamation, "提示信息");
                                                if (isshowprogress)
                                                {
                                                    progressexcel.Close();
                                                    progressexcel.Dispose();
                                                }
                                                return false;
                                            }
                                            break;
                                    }
                                }
                                if (isshowprogress)
                                {
                                    progressexcel.Visible = true;
                                }
                            }
                            XSSFWorkbook xssfworkbook = null;
                            if (MyProject.Computer.FileSystem.FileExists(FileName))
                            {
                                FileStream fileStream;
                                try
                                {
                                    fileStream = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
                                }
                                catch (Exception ex2)
                                {
                                    if (isshowprogress)
                                    {
                                        progressexcel.Close();
                                        progressexcel.Dispose();
                                    }
                                    Interaction.MsgBox("数据导出失败，原因是打开Excel文件〖" + FileName + "〗失败，" + ex2.Message, MsgBoxStyle.Exclamation, "提示信息");
                                    fileStream = null;
                                    return false;
                                }
                                try
                                {
                                    xssfworkbook = new XSSFWorkbook(fileStream);
                                    goto IL_477;
                                }
                                catch (Exception ex3)
                                {
                                    if (isshowprogress)
                                    {
                                        progressexcel.Close();
                                        progressexcel.Dispose();
                                    }
                                    fileStream.Dispose();
                                    fileStream = null;
                                    Interaction.MsgBox("数据导出失败，原因是打开Excel文件〖" + FileName + "〗失败，可能不是有效的Office97-2003 Excel文件格式，因此无法向该文件中追加导出的数据", MsgBoxStyle.Exclamation, "提示信息");
                                    xssfworkbook = null;
                                    return false;
                                }
                            }
                            try
                            {
                                xssfworkbook = new XSSFWorkbook();
                            }
                            catch (Exception ex4)
                            {
                            }
                        IL_477:
                            string excelNewSheetName = DGVtoExcel2007.GetExcelNewSheetName(xssfworkbook, sheetname);
                            XSSFSheet xssfsheet = (XSSFSheet)xssfworkbook.CreateSheet(excelNewSheetName);
                            int num6;
                            if (String.Compare(title, "", false) == 0)
                            {
                                num6 = 0;
                            }
                            else
                            {
                                DGVtoExcel2007.SetTitle(xssfworkbook, xssfsheet, 0, 0, 0, endcol, title, titlefont);
                                num6 = 1;
                            }
                            if (String.Compare(Tableheader, "", false) != 0)
                            {
                                DGVtoExcel2007.SetTitle(xssfworkbook, xssfsheet, num6, num6, 0, endcol, Tableheader, tableheaderfont);
                                num6++;
                            }
                            DGVtoExcel2007.w_gridcolor = new XSSFColor(mydgv.GridColor);
                            if (mydgv.ColumnHeadersVisible)
                            {
                                if (columnheadertree == null)
                                {
                                    IRow row = xssfsheet.CreateRow(num6);
                                    row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.ColumnHeadersHeight, false)) * 72f);
                                    int num7 = 0;
                                    int num8 = num - 1;
                                    for (int i = num7; i <= num8; i++)
                                    {
                                        DGVtoExcel2007.SetCellValue(xssfsheet, num6, i, mydgv.Columns[array3[i]].HeaderText, "");
                                        Font font = Module1.GetDGVHeaderFont(mydgv.Columns[array3[i]]);
                                        Color bkcolor = Module1.GetDGVHeaderBackColor(mydgv.Columns[array3[i]]);
                                        Color forcolor = Module1.GetDGVHeaderForeColor(mydgv.Columns[array3[i]]);
                                        DGVtoExcel2007.SetCellStyle(xssfworkbook, xssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                    }
                                }
                                else
                                {
                                    mytree mytree = new mytree(columnheadertree, mydgv);
                                    int leves = mytree.GetLeves();
                                    if (mytree.GetColumns() != mydgv.ColumnCount)
                                    {
                                        mytree.Dispose();
                                        IRow row = xssfsheet.CreateRow(num6);
                                        row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.ColumnHeadersHeight, false)) * 72f);
                                        int num9 = 0;
                                        int num10 = num - 1;
                                        for (int i = num9; i <= num10; i++)
                                        {
                                            DGVtoExcel2007.SetCellValue(xssfsheet, num6, i, mydgv.Columns[array3[i]].HeaderText, "");
                                            Font font = Module1.GetDGVHeaderFont(mydgv.Columns[array3[i]]);
                                            Color bkcolor = Module1.GetDGVHeaderBackColor(mydgv.Columns[array3[i]]);
                                            Color forcolor = Module1.GetDGVHeaderForeColor(mydgv.Columns[array3[i]]);
                                            DGVtoExcel2007.SetCellStyle(xssfworkbook, xssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                        }
                                    }
                                    else
                                    {
                                        int num11 = 1;
                                        int num12 = leves;
                                        for (int k = num11; k <= num12; k++)
                                        {
                                            IRow row = xssfsheet.CreateRow(num6 + k - 1);
                                            row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)((double)mydgv.ColumnHeadersHeight / (double)leves), false)) * 72f);
                                        }
                                        int num13 = 1;
                                        int num14 = leves;
                                        for (int k = num13; k <= num14; k++)
                                        {
                                            if (k != 1)
                                            {
                                                num6++;
                                            }
                                            int num15 = 0;
                                            int num16 = num - 1;
                                            for (int i = num15; i <= num16; i++)
                                            {
                                                string nodeText = mytree.GetNodeText(array3[i], k);
                                                int cellHeightLevels = mytree.GetCellHeightLevels(array3[i], k);
                                                int cellWidthCols = mytree.GetCellWidthCols(array3[i], k);
                                                if (!(cellHeightLevels == 0 | cellWidthCols == 0))
                                                {
                                                    Font font = mytree.GetNodeFont(array3[i], k);
                                                    if (font == null)
                                                    {
                                                        font = Module1.GetDGVHeaderFont(mydgv.Columns[array3[i]]);
                                                    }
                                                    Color forcolor = mytree.GetNodeForeColor(array3[i], k);
                                                    if (forcolor.IsEmpty)
                                                    {
                                                        forcolor = Module1.GetDGVHeaderForeColor(mydgv.Columns[array3[i]]);
                                                    }
                                                    Color bkcolor = mytree.GetNodeBackColor(array3[i], k);
                                                    if (bkcolor.IsEmpty)
                                                    {
                                                        bkcolor = Module1.GetDGVHeaderBackColor(mydgv.Columns[array3[i]]);
                                                    }
                                                    if (cellWidthCols == 1 & cellHeightLevels == 1)
                                                    {
                                                        DGVtoExcel2007.SetCellValue(xssfsheet, num6, i, nodeText, "");
                                                        DGVtoExcel2007.SetCellStyle(xssfworkbook, xssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                                    }
                                                    else
                                                    {
                                                        DGVtoExcel2007.SetCellValue(xssfsheet, num6, i, nodeText, "");
                                                        DGVtoExcel2007.SetCellStyle(xssfworkbook, xssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                                        int num17 = num6;
                                                        int num18 = num6 + cellHeightLevels - 1;
                                                        for (int l = num17; l <= num18; l++)
                                                        {
                                                            int num19 = i;
                                                            int num20 = i + cellWidthCols - 1;
                                                            for (int m = num19; m <= num20; m++)
                                                            {
                                                                if (l != num6 | m != i)
                                                                {
                                                                    DGVtoExcel2007.SetCellBorder(xssfworkbook, xssfsheet, l, m, true, true, true, true);
                                                                }
                                                            }
                                                        }
                                                        DGVtoExcel2007.SetMergeCell(xssfsheet, num6, i, num6 + cellHeightLevels - 1, i + cellWidthCols - 1);
                                                    }
                                                }
                                            }
                                        }
                                        mytree.Dispose();
                                    }
                                }
                                num6++;
                            }
                            int num21 = 1;
                            int num22 = 0;
                            int num23 = 0;
                            int num24 = 0;
                            int num25 = 0;
                            int num26 = 1;
                            int num27 = 0;
                            int num28 = mydgv.RowCount - 1;
                            for (int i = num27; i <= num28; i++)
                            {
                                IRow row = xssfsheet.CreateRow(num6 + i);
                                row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.Rows[i].Height, false)) * 72f);
                                if (!mydgv.Rows[i].Visible)
                                {
                                    row.ZeroHeight = true;
                                }
                            }
                            int num29 = 0;
                            if (isshowprogress)
                            {
                                progressexcel.ProgressBar1.Maximum = mydgv.RowCount;
                            }
                            int num30 = 0;
                            int num31 = mydgv.RowCount - 1;
                            for (int i = num30; i <= num31; i++)
                            {
                                bool flag = false;
                                if (isshowprogress)
                                {
                                    progressexcel.Label1.Text = string.Concat(new string[]
                                    {
                                        "正在导出第〖",
                                        Convert.ToString(i + 1),
                                        "〗条记录，共〖",
                                        Convert.ToString(mydgv.RowCount),
                                        "〗条记录，已完成〖",
                                        Strings.Format((double)(i + 1) / (double)mydgv.RowCount, "###.##%"),
                                        "〗"
                                    });
                                    progressexcel.ProgressBar1.Value = i + 1;
                                    Application.DoEvents();
                                }
                                if (Module1.G_CancelExportDGVToExcel)
                                {
                                    break;
                                }
                                int num32 = 0;
                                int num33 = num - 1;
                                j = num32;
                                while (j <= num33)
                                {
                                    int num34;
                                    if (mydgv.Columns[array3[j]].ValueType == null)
                                    {
                                        num34 = -1;
                                    }
                                    else
                                    {
                                        string left = Strings.Left(mydgv.Columns[array3[j]].ValueType.Name.ToUpper(), 3);
                                        if (String.Compare(left, "STR", false) == 0)
                                        {
                                            num34 = 0;
                                        }
                                        else
                                        {
                                            if (String.Compare(left, "INT", false) != 0)
                                            {
                                                if (String.Compare(left, "DEC", false) != 0)
                                                {
                                                    if (String.Compare(left, "DOU", false) != 0)
                                                    {
                                                        if (String.Compare(left, "BYT", false) != 0)
                                                        {
                                                            if (String.Compare(left, "SIN", false) != 0)
                                                            {
                                                                if (String.Compare(left, "DAT", false) == 0)
                                                                {
                                                                    num34 = 2;
                                                                    goto IL_B81;
                                                                }
                                                                if (String.Compare(left, "BOO", false) == 0)
                                                                {
                                                                    num34 = 3;
                                                                    flag = false;
                                                                    goto IL_B81;
                                                                }
                                                                num34 = 0;
                                                                goto IL_B81;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            num34 = 1;
                                            flag = false;
                                        }
                                    }
                                IL_B81:
                                    num26 = 1;
                                    num21 = 1;
                                    num24 = 0;
                                    num22 = 0;
                                    num25 = 0;
                                    num24 = 0;
                                    num22 = 0;
                                    num23 = 0;
                                    string left2 = Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag);
                                    if (String.Compare(left2, "垂直合并", false) == 0)
                                    {
                                        
                                    }
                                    if (String.Compare(left2, "#垂直合并#", false) == 0)
                                    {
                                       
                                    }
                                    if (String.Compare(left2, "上合并", false) == 0)
                                    {
                                        
                                    }
                                    if (String.Compare(left2, "下合并", false) == 0)
                                    {
                                       
                                    }
                                    float num35 = 0;
                                    float num36 = 0;
                                    int num37 = 0;
                                    int num38 = 0;
                                    int num39 = 0;
                                    int num40 = 0;
                                    if (String.Compare(left2, "水平合并", false) != 0)
                                    {
                                        if (String.Compare(left2, "#水平合并#", false) != 0)
                                        {
                                            if (String.Compare(left2, "左合并", false) != 0)
                                            {
                                                if (String.Compare(left2, "右合并", false) != 0)
                                                {
                                                    if (String.Compare(left2, "合并", false) != 0)
                                                    {
                                                        if (String.Compare(left2, "左上合并", false) != 0)
                                                        {
                                                            if (String.Compare(left2, "左下合并", false) != 0)
                                                            {
                                                                if (String.Compare(left2, "右上合并", false) != 0)
                                                                {
                                                                    if (String.Compare(left2, "右下合并", false) != 0)
                                                                    {
                                                                        if (String.Compare(left2, "上边合并", false) != 0)
                                                                        {
                                                                            if (String.Compare(left2, "下边合并", false) != 0)
                                                                            {
                                                                                if (String.Compare(left2, "左边合并", false) != 0)
                                                                                {
                                                                                    if (String.Compare(left2, "右边合并", false) != 0)
                                                                                    {
                                                                                        num26 = 1;
                                                                                        num21 = 1;
                                                                                       
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    mymerge.GetHVMergeWidthAndHeight(mydgv, array3[j], i, ref num35, ref num36, ref num25, ref num24, ref num22, ref num23, ref num37, ref num38, ref num39, ref num40);
                                                    num26 = num24 + num25 + 1;
                                                    num21 = num22 + num23 + 1;
                                                   
                                                }
                                            }
                                        }
                                    }
                                    num35 = (float)((int)Math.Round((double)mymerge.GetHMergeWidth(mydgv, array3[j], i, ref num26, ref num24, ref num25, ref num37, ref num39, true)));
                                
                                    if (!(num24 > 0 | num22 > 0))
                                    {
                                        if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewImageColumn", false) == 0)
                                        {
                                            if (mydgv.Rows[i].Cells[array3[j]].Value != null)
                                            {
                                                Image img = (Image)mydgv.Rows[i].Cells[array3[j]].FormattedValue;
                                                byte[] byteByImage = DGVtoExcel2007.GetByteByImage(img);
                                                int num41 = xssfworkbook.AddPicture(byteByImage, 5);
                                                XSSFDrawing xssfdrawing = (XSSFDrawing)xssfsheet.CreateDrawingPatriarch();
                                                XSSFClientAnchor xssfclientAnchor = new XSSFClientAnchor(0, 0, 0, 0, j, num6 + i, j + 1, num6 + i + 1);
                                                xssfdrawing.CreatePicture(xssfclientAnchor, num41);
                                            }
                                        }
                                        else if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewCheckBoxColumn", false) == 0)
                                        {
                                            if (mydgv.Rows[i].Cells[array3[j]].Value != null && DataTypeConversion.ToBoolean(mydgv.Rows[i].Cells[array3[j]].FormattedValue))
                                            {
                                                DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, true);
                                            }
                                            flag = false;
                                        }
                                        else
                                        {
                                            string text = Convert.ToString(mydgv.Rows[i].Cells[array3[j]].FormattedValue) + "";
                                            flag = (Strings.InStr(text, "\r\n", CompareMethod.Binary) > 0);
                                            switch (num34)
                                            {
                                                case -1:
                                                    if (numericmode && DataTypeConversion.IsNumeric(text) && Convert.ToDouble(text) <= 99999999999.0)
                                                    {
                                                        DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, Convert.ToDouble(text), Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                        goto IL_10D6;
                                                    }
                                                    DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D6;
                                                case 1:
                                                    if (DataTypeConversion.IsNumeric(text))
                                                    {
                                                        DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, Convert.ToDouble(text), Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                        goto IL_10D6;
                                                    }
                                                    DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D6;
                                                case 2:
                                                    DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D6;
                                            }
                                            DGVtoExcel2007.SetCellValue(xssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                        }
                                    IL_10D6:
                                        DataGridViewCellStyle dgvcellStyle = Module1.GetDGVCellStyle(mydgv.Rows[i].Cells[array3[j]]);
                                        DataGridViewContentAlignment alignment = dgvcellStyle.Alignment;
                                        StringAlignment valign = StringAlignment.Far;
                                        StringAlignment halign = StringAlignment.Center;
                                        if (alignment == DataGridViewContentAlignment.BottomCenter)
                                        {
                                            valign = StringAlignment.Far;
                                            halign = StringAlignment.Center;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.MiddleCenter)
                                        {
                                            valign = StringAlignment.Center;
                                            halign = StringAlignment.Center;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.TopCenter)
                                        {
                                            valign = StringAlignment.Near;
                                            halign = StringAlignment.Center;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.BottomLeft)
                                        {
                                            valign = StringAlignment.Far;
                                            halign = StringAlignment.Near;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.MiddleLeft)
                                        {
                                            valign = StringAlignment.Center;
                                            halign = StringAlignment.Near;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.TopLeft)
                                        {
                                            valign = StringAlignment.Near;
                                            halign = StringAlignment.Near;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.BottomRight)
                                        {
                                            valign = StringAlignment.Far;
                                            halign = StringAlignment.Far;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.MiddleRight)
                                        {
                                            valign = StringAlignment.Center;
                                            halign = StringAlignment.Far;
                                        }
                                        else if (alignment == DataGridViewContentAlignment.TopRight)
                                        {
                                            valign = StringAlignment.Near;
                                            halign = StringAlignment.Far;
                                        }
                                        if (!flag && Module1.GetDGVCellMulline(mydgv.Rows[i].Cells[array3[j]]))
                                        {
                                            flag = true;
                                        }
                                        Color bkcolor = Module1.GetDGVCellBackColor(mydgv.Rows[i].Cells[array3[j]]);
                                        Color forcolor = Module1.GetDGVCellForeColor(mydgv.Rows[i].Cells[array3[j]]);
                                        DGVtoExcel2007.SetCellStyle(xssfworkbook, xssfsheet, num6 + i, j, true, true, true, true, halign, valign, Module1.GetDGVCellFont(mydgv.Rows[i].Cells[array3[j]]), bkcolor, forcolor, flag);
                                        if (!(num26 == 1 & num21 == 1))
                                        {
                                            int num42 = num6 + i;
                                            int num43 = num6 + i + num23;
                                            for (int n = num42; n <= num43; n++)
                                            {
                                                int num44 = j;
                                                int num45 = j + num25;
                                                for (int num46 = num44; num46 <= num45; num46++)
                                                {
                                                    if (n != num6 + i | num46 != j)
                                                    {
                                                        DGVtoExcel2007.SetCellBorder(xssfworkbook, xssfsheet, n, num46, true, true, true, true);
                                                    }
                                                }
                                            }
                                            DGVtoExcel2007.SetMergeCell(xssfsheet, num6 + i, j, num6 + i + num23, j + num25);
                                            j += num25;
                                        }
                                    }
                                    j++;
                                    continue;
                                     num39 = 0;
                                     num40 = 0;
                                    num36 = (float)mymerge.GetVMergeHeight(mydgv, array3[j], i, ref num21, ref num23, ref num22, ref num38, ref num40);
                                    
                                }
                            }
                            if (num29 == 0)
                            {
                                num6 += mydgv.RowCount;
                            }
                            else
                            {
                                num6 = num29 - 1;
                            }
                            if (String.Compare(TableFooter, "", false) != 0)
                            {
                                DGVtoExcel2007.SetTitle(xssfworkbook, xssfsheet, num6, num6, 0, endcol, TableFooter, tablefooterfont);
                                num6++;
                            }
                            if (pic != null)
                            {
                                xssfsheet.CreateRow(num6);
                                byte[] byteByImage2 = DGVtoExcel2007.GetByteByImage(pic);
                                int num47 = xssfworkbook.AddPicture(byteByImage2, 5);
                                IDrawing drawing = xssfsheet.CreateDrawingPatriarch();
                                HSSFClientAnchor hssfclientAnchor = new HSSFClientAnchor(0, 0, 0, 0, 0, num6, 0, num6);
                                IPicture picture = drawing.CreatePicture(hssfclientAnchor, num47);
                                picture.Resize();
                            }
                            DGVtoExcel2007.w_font = null;
                            DGVtoExcel2007.w_ifont = null;
                            DGVtoExcel2007.w_Cellstyle = null;
                            DGVtoExcel2007.w_iCellstyle = null;
                            DGVtoExcel2007.w_color = null;
                            int num48 = 0;
                            int num49 = num - 1;
                            for (int num50 = num48; num50 <= num49; num50++)
                            {
                                xssfsheet.SetColumnWidth(num50, (int)Math.Round(unchecked(Math.Ceiling((double)mydgv.Columns[array3[num50]].Width / 8.0) * 256.0)));
                            }
                            ruler.Dispose();
                            ruler = null;
                            if (isshowprogress)
                            {
                                progressexcel.Close();
                                progressexcel.Dispose();
                            }
                            xssfworkbook.SetActiveSheet(xssfworkbook.GetSheetIndex(excelNewSheetName));
                            xssfsheet.ForceFormulaRecalculation = true;
                            if (!DGVtoExcel2007.WriteToFile(xssfworkbook, FileName))
                            {
                                xssfworkbook = null;
                                result = false;
                            }
                            else
                            {
                                xssfworkbook = null;
                                if (isopenfile && Interaction.MsgBox("导出的Excel文件已保存到【" + FileName + " 】\r\n您是否要立即打开这个文件以查看其内容?", MsgBoxStyle.YesNoCancel, "提示信息") == MsgBoxResult.Yes)
                                {
                                    try
                                    {
                                        Process.Start(FileName);
                                    }
                                    catch (Exception ex5)
                                    {
                                        try
                                        {
                                            Thread.Sleep(100);
                                            Process.Start(FileName);
                                        }
                                        catch (Exception ex6)
                                        {
                                        }
                                    }
                                }
                                result = true;
                            }
                        }
                    }
                    catch (Exception ex7)
                    {
                        if (isshowprogress)
                        {
                            progressexcel.Close();
                            progressexcel.Dispose();
                        }
                        try
                        {
                            ruler.Dispose();
                            ruler = null;
                        }
                        catch (Exception ex8)
                        {
                        }
                        if (String.Compare(FileName, "", false) == 0)
                        {
                            result = DGVToExcelFile.myNewDGVtoExcel(mydgv, FileName, title, Tableheader, TableFooter, true);
                        }
                        else
                        {
                            result = DGVToExcelFile.myNewDGVtoExcel(mydgv, FileName, title, Tableheader, TableFooter, false);
                        }
                    }
                }
                return result;
            }
        }

        // Token: 0x06001CBE RID: 7358 RVA: 0x000E5958 File Offset: 0x000E3B58
        private static void SetTitle(XSSFWorkbook mybook, XSSFSheet mysheet, int startrow, int endrow, int startcol, int endcol, string titltext, Font titlefont)
        {
            XSSFRow xssfrow = null;
            checked
            {
                for (int i = startrow; i <= endrow; i++)
                {
                    xssfrow = (XSSFRow)mysheet.CreateRow(i);
                }
                XSSFCell xssfcell = (XSSFCell)xssfrow.CreateCell(0);
                xssfcell.SetCellValue(titltext);
                DGVtoExcel2007.SetCellStyle(mybook, mysheet, startrow, startcol, false, false, false, false, StringAlignment.Center, StringAlignment.Center, titlefont, Color.Transparent, Color.Black, true);
                xssfrow.HeightInPoints = DGVtoExcel2007.TestHeight(titltext, titlefont);
                DGVtoExcel2007.SetMergeCell(mysheet, startrow, startcol, endrow, endcol);
            }
        }

        // Token: 0x06001CBF RID: 7359 RVA: 0x000E59D4 File Offset: 0x000E3BD4
        private static float TestHeight(string tt, Font f)
        {
            PrintDocument printDocument = new PrintDocument();
            Graphics graphics = printDocument.PrinterSettings.CreateMeasurementGraphics();
            float height = graphics.MeasureString(tt, f).Height;
            graphics.Dispose();
            printDocument.Dispose();
            return height;
        }

        // Token: 0x06001CC0 RID: 7360 RVA: 0x000E5A18 File Offset: 0x000E3C18
        private static void SetMergeCell(XSSFSheet mysheet, int startrow, int startcol, int endrow, int endcol)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(startrow, endrow, startcol, endcol);
            mysheet.AddMergedRegion(cellRangeAddress);
        }

        // Token: 0x06001CC1 RID: 7361 RVA: 0x000E5A3C File Offset: 0x000E3C3C
        private static void SetCellBorder(XSSFWorkbook mybook, XSSFSheet mysheet, int rowindex, int colindex, bool leftborder, bool rightborder, bool topborder, bool bottomborder)
        {
            NPOI.SS.UserModel.BorderStyle borderStyle = (NPOI.SS.UserModel.BorderStyle) 1;
            ICell cell = mysheet.GetRow(rowindex).GetCell(colindex);
            if (cell == null)
            {
                cell = mysheet.GetRow(rowindex).CreateCell(colindex);
            }
            XSSFCellStyle xssfcellStyle = (XSSFCellStyle)mybook.CreateCellStyle();
            if (leftborder)
            {
                xssfcellStyle.BorderLeft = borderStyle;
                xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)3, DGVtoExcel2007.w_gridcolor);
            }
            else
            {
                xssfcellStyle.BorderLeft = 0;
            }
            if (rightborder)
            {
                xssfcellStyle.BorderRight = borderStyle;
                xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)1, DGVtoExcel2007.w_gridcolor);
            }
            else
            {
                xssfcellStyle.BorderRight = 0;
            }
            if (topborder)
            {
                xssfcellStyle.BorderTop = borderStyle;
                xssfcellStyle.SetBorderColor(0, DGVtoExcel2007.w_gridcolor);
            }
            else
            {
                xssfcellStyle.BorderTop = 0;
            }
            if (bottomborder)
            {
                xssfcellStyle.BorderBottom = borderStyle;
                xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)2, DGVtoExcel2007.w_gridcolor);
            }
            else
            {
                xssfcellStyle.BorderBottom = 0;
            }
            cell.CellStyle = xssfcellStyle;
        }

        // Token: 0x06001CC2 RID: 7362 RVA: 0x000E5B00 File Offset: 0x000E3D00
        private static void SetCellValue(XSSFSheet mysheet, int rowindex, int colindex, string value, string thetag)
        {
            if (DGVtoExcel2007.w_saveformula && thetag != null && Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) > 0)
            {
                thetag = Strings.Mid(thetag, checked(Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) + Strings.Len("$公式：$")));
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellFormula(thetag);
            }
            else
            {
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
            }
        }

        // Token: 0x06001CC3 RID: 7363 RVA: 0x000E5B74 File Offset: 0x000E3D74
        private static void SetCellValue(XSSFSheet mysheet, int rowindex, int colindex, double value, string thetag)
        {
            if (DGVtoExcel2007.w_saveformula && thetag != null && Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) > 0)
            {
                thetag = Strings.Mid(thetag, checked(Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) + Strings.Len("$公式：$")));
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellFormula(thetag);
            }
            else
            {
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
            }
        }

        // Token: 0x06001CC4 RID: 7364 RVA: 0x0000A14F File Offset: 0x0000834F
        private static void SetCellValue(XSSFSheet mysheet, int rowindex, int colindex, DateTime value)
        {
            mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
        }

        // Token: 0x06001CC5 RID: 7365 RVA: 0x0000A164 File Offset: 0x00008364
        private static void SetCellValue(XSSFSheet mysheet, int rowindex, int colindex, bool value)
        {
            mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
        }

        // Token: 0x06001CC6 RID: 7366 RVA: 0x000E5BE8 File Offset: 0x000E3DE8
        private static void SetCellStyle(XSSFWorkbook mybook, XSSFSheet mysheet, int rowindex, int colindex, bool leftborder, bool rightborder, bool topborder, bool bottomborder, StringAlignment halign, StringAlignment valign, Font myfont, Color bkcolor, Color forcolor, bool needwrap = false)
        {
            NPOI.SS.UserModel.BorderStyle borderStyle = (NPOI.SS.UserModel.BorderStyle)1;
            XSSFCell xssfcell = (XSSFCell)mysheet.GetRow(rowindex).GetCell(colindex);
            if (xssfcell == null)
            {
                xssfcell = (XSSFCell)mysheet.GetRow(rowindex).CreateCell(colindex);
            }
            XSSFCellStyle xssfcellStyle = null;
            bool flag = false;
            checked
            {
                string cellStyleString;
                int num3=0;
                if (DGVtoExcel2007.w_Cellstyle != null)
                {
                    cellStyleString = DGVtoExcel2007.GetCellStyleString(leftborder, rightborder, topborder, bottomborder, halign, valign, myfont, bkcolor, forcolor, needwrap);
                    int num = 0;
                    int num2 = DGVtoExcel2007.w_Cellstyle.Length - 1;
                    int i = num;
                    while (i <= num2)
                    {
                        if (String.Compare(cellStyleString, DGVtoExcel2007.w_Cellstyle[i], false) == 0)
                        {
                            flag = true;
                        IL_C6:
                            if (flag)
                            {
                                xssfcellStyle = DGVtoExcel2007.w_iCellstyle[i];
                                goto IL_11F;
                            }
                            num3 = DGVtoExcel2007.w_Cellstyle.Length;
                            DGVtoExcel2007.w_Cellstyle = (string[])Utils.CopyArray((Array)DGVtoExcel2007.w_Cellstyle, new string[num3 + 1]);
                            DGVtoExcel2007.w_iCellstyle = (XSSFCellStyle[])Utils.CopyArray((Array)DGVtoExcel2007.w_iCellstyle, new XSSFCellStyle[num3 + 1]);
                            goto IL_11F;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                DGVtoExcel2007.w_Cellstyle = new string[1];
                DGVtoExcel2007.w_iCellstyle = new XSSFCellStyle[1];
                num3 = 0;
                cellStyleString = DGVtoExcel2007.GetCellStyleString(leftborder, rightborder, topborder, bottomborder, halign, valign, myfont, bkcolor, forcolor, needwrap);
            IL_11F:
                if (!flag)
                {
                    xssfcellStyle = (XSSFCellStyle)mybook.CreateCellStyle();
                    if (leftborder)
                    {
                        xssfcellStyle.BorderLeft = borderStyle;
                        xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)3, DGVtoExcel2007.w_gridcolor);
                    }
                    else
                    {
                        xssfcellStyle.BorderLeft = 0;
                    }
                    if (rightborder)
                    {
                        xssfcellStyle.BorderRight = borderStyle;
                        xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)1, DGVtoExcel2007.w_gridcolor);
                    }
                    else
                    {
                        xssfcellStyle.BorderRight = 0;
                    }
                    if (topborder)
                    {
                        xssfcellStyle.BorderTop = borderStyle;
                        xssfcellStyle.SetBorderColor(0, DGVtoExcel2007.w_gridcolor);
                    }
                    else
                    {
                        xssfcellStyle.BorderTop = 0;
                    }
                    if (bottomborder)
                    {
                        xssfcellStyle.BorderBottom = borderStyle;
                        xssfcellStyle.SetBorderColor((NPOI.XSSF.UserModel.Extensions.BorderSide)2, DGVtoExcel2007.w_gridcolor);
                    }
                    else
                    {
                        xssfcellStyle.BorderBottom = 0;
                    }
                    if (halign == StringAlignment.Center)
                    {
                        xssfcellStyle.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)2;
                    }
                    else if (halign == StringAlignment.Far)
                    {
                        xssfcellStyle.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)3;
                    }
                    else
                    {
                        xssfcellStyle.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)1;
                    }
                    if (valign == StringAlignment.Near)
                    {
                        xssfcellStyle.VerticalAlignment = 0;
                    }
                    else if (valign == StringAlignment.Far)
                    {
                        xssfcellStyle.VerticalAlignment = (VerticalAlignment)2;
                    }
                    else
                    {
                        xssfcellStyle.VerticalAlignment = (VerticalAlignment)1;
                    }
                    if (!bkcolor.IsEmpty)
                    {
                        if (bkcolor.Equals(Color.Transparent) | bkcolor.Equals(Color.White))
                        {
                            xssfcellStyle.FillPattern =(FillPattern) 0;
                            xssfcellStyle.SetFillForegroundColor(new XSSFColor(Color.White));
                        }
                        else
                        {
                            xssfcellStyle.FillPattern =(FillPattern) 1;
                            xssfcellStyle.SetFillForegroundColor(new XSSFColor(bkcolor));
                        }
                    }
                    if (needwrap)
                    {
                        xssfcellStyle.WrapText = true;
                    }
                    else
                    {
                        xssfcellStyle.WrapText = false;
                    }
                    XSSFFont ifontByFont = DGVtoExcel2007.GetIFontByFont(mybook, myfont, forcolor);
                    if (!forcolor.IsEmpty && !(forcolor.Equals(Color.Transparent) | forcolor.Equals(Color.Black)))
                    {
                        ifontByFont.SetColor(new XSSFColor(forcolor));
                    }
                    xssfcellStyle.SetFont(ifontByFont);
                    DGVtoExcel2007.w_Cellstyle[num3] = cellStyleString;
                    DGVtoExcel2007.w_iCellstyle[num3] = xssfcellStyle;
                }
                xssfcell.CellStyle = xssfcellStyle;
            }
        }

        // Token: 0x06001CC7 RID: 7367 RVA: 0x000E5EF8 File Offset: 0x000E40F8
        private static byte[] GetByteByImage(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, ImageFormat.Jpeg);
            checked
            {
                byte[] array = new byte[(int)memoryStream.Length + 1];
                memoryStream.Position = 0L;
                memoryStream.Read(array, 0, (int)memoryStream.Length);
                memoryStream.Close();
                return array;
            }
        }

        // Token: 0x06001CC8 RID: 7368 RVA: 0x000E5F50 File Offset: 0x000E4150
        private static XSSFFont GetIFontByFont(XSSFWorkbook mybook, Font myfont, Color forecolor)
        {
            checked
            {
                int num3;
                if (DGVtoExcel2007.w_font != null)
                {
                    bool flag = false;
                    int num = 0;
                    int num2 = DGVtoExcel2007.w_font.Length - 1;
                    int i = num;
                    while (i <= num2)
                    {
                        if (!(DGVtoExcel2007.IsEqualFont(myfont, DGVtoExcel2007.w_font[i]) & forecolor.Equals(DGVtoExcel2007.w_color[i])))
                        {
                            i++;
                        }
                        else
                        {
                            flag = true;
                        IL_81:
                            if (flag)
                            {
                                return DGVtoExcel2007.w_ifont[i];
                            }
                            num3 = DGVtoExcel2007.w_font.Length;
                            DGVtoExcel2007.w_font = (Font[])Utils.CopyArray((Array)DGVtoExcel2007.w_font, new Font[num3 + 1]);
                            DGVtoExcel2007.w_ifont = (XSSFFont[])Utils.CopyArray((Array)DGVtoExcel2007.w_ifont, new XSSFFont[num3 + 1]);
                            DGVtoExcel2007.w_color = (Color[])Utils.CopyArray((Array)DGVtoExcel2007.w_color, new Color[num3 + 1]);
                            goto IL_FD;
                        }
                    };
                }
                DGVtoExcel2007.w_font = new Font[1];
                DGVtoExcel2007.w_ifont = new XSSFFont[1];
                DGVtoExcel2007.w_color = new Color[1];
                num3 = 0;
            IL_FD:
                XSSFFont xssffont = (XSSFFont)mybook.CreateFont();
                xssffont.FontHeightInPoints = (short)Math.Round((double)myfont.SizeInPoints);
                xssffont.FontName = myfont.Name;
                xssffont.IsItalic = myfont.Italic;
                xssffont.IsStrikeout = myfont.Strikeout;
                if (myfont.Underline)
                {
                    xssffont.Underline =(FontUnderlineType) 1;
                }
                if (myfont.Bold)
                {
                    xssffont.Boldweight = 700;
                }
                else
                {
                    xssffont.Boldweight = 400;
                }
                DGVtoExcel2007.w_font[num3] = myfont;
                DGVtoExcel2007.w_ifont[num3] = xssffont;
                DGVtoExcel2007.w_color[num3] = forecolor;
                return xssffont;
            }
        }

        // Token: 0x06001CC9 RID: 7369 RVA: 0x000E60F0 File Offset: 0x000E42F0
        private static bool IsEqualFont(Font f1, Font f2)
        {
            FontConverter fontConverter = new FontConverter();
            string left = fontConverter.ConvertToString(f1);
            string right = fontConverter.ConvertToString(f2);
            return String.Compare(left, right, false) == 0;
        }

        // Token: 0x06001CCA RID: 7370 RVA: 0x000E6128 File Offset: 0x000E4328
        private static string GetCellStyleString(bool leftborder, bool rightborder, bool topborder, bool bottomborder, StringAlignment halign, StringAlignment valign, Font myfont, Color bkcolor, Color forcolor, bool needwrap)
        {
            string str;
            if (leftborder)
            {
                str = "1";
            }
            else
            {
                str = "0";
            }
            if (rightborder)
            {
                str += "1";
            }
            else
            {
                str += "0";
            }
            if (topborder)
            {
                str += "1";
            }
            else
            {
                str += "0";
            }
            if (bottomborder)
            {
                str += "1";
            }
            else
            {
                str += "0";
            }
            switch (halign)
            {
                case StringAlignment.Near:
                    str += "3";
                    break;
                case StringAlignment.Center:
                    str += "1";
                    break;
                case StringAlignment.Far:
                    str += "2";
                    break;
            }
            switch (valign)
            {
                case StringAlignment.Near:
                    str += "3";
                    break;
                case StringAlignment.Center:
                    str += "1";
                    break;
                case StringAlignment.Far:
                    str += "2";
                    break;
            }
            if (needwrap)
            {
                str += "1";
            }
            else
            {
                str += "2";
            }
            str += Module1.ConvertFontToString(myfont);
            str += Module1.ConvertColorToString(bkcolor);
            return str + Module1.ConvertColorToString(forcolor);
        }

        // Token: 0x06001CCB RID: 7371 RVA: 0x000E6268 File Offset: 0x000E4468
        private static bool WriteToFile(XSSFWorkbook mybook, string filename)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "导出Excel失败");
                return false;
            }
            try
            {
                mybook.Write(fileStream);
            }
            catch (Exception ex2)
            {
            }
            fileStream.Close();
            return true;
        }

        // Token: 0x06001CCC RID: 7372 RVA: 0x000E62E4 File Offset: 0x000E44E4
        private static string GetExcelNewSheetName(XSSFWorkbook mybook, string sheetname)
        {
            sheetname = Strings.Trim(sheetname);
            checked
            {
                if (mybook != null)
                {
                    int numberOfSheets = mybook.NumberOfSheets;
                    if (String.Compare(sheetname, "", false) == 0)
                    {
                        sheetname = "导出结果";
                    }
                    int num = 1;
                    string[] array = new string[numberOfSheets - 1 + 1];
                    int num2 = 0;
                    int num3 = numberOfSheets - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        array[i] = mybook.GetSheetName(i);
                    }
                    bool flag = false;
                    int num4 = 0;
                    int num5 = numberOfSheets - 1;
                    for (int j = num4; j <= num5; j++)
                    {
                        if (String.Compare(array[j], sheetname, false) == 0)
                        {
                            flag = true;
                        IL_91:
                            string str = sheetname;
                            if (flag)
                            {
                                while (flag)
                                {
                                    flag = false;
                                    sheetname = str + "-" + Convert.ToString(num);
                                    num++;
                                    int num6 = 0;
                                    int num7 = numberOfSheets - 1;
                                    for (int k = num6; k <= num7; k++)
                                    {
                                        if (String.Compare(array[k], sheetname, false) == 0)
                                        {
                                            flag = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            return sheetname;
                        }
                    }
                }
                return "";
            }
        }

        // Token: 0x04000E24 RID: 3620
        private static Font[] w_font = null;

        // Token: 0x04000E25 RID: 3621
        private static XSSFFont[] w_ifont = null;

        // Token: 0x04000E26 RID: 3622
        private static Color[] w_color;

        // Token: 0x04000E27 RID: 3623
        private static XSSFColor w_gridcolor;

        // Token: 0x04000E28 RID: 3624
        private static string[] w_Cellstyle = null;

        // Token: 0x04000E29 RID: 3625
        private static XSSFCellStyle[] w_iCellstyle = null;

        // Token: 0x04000E2A RID: 3626
        private static short w_ZDYcolors = 0;

        // Token: 0x04000E2B RID: 3627
        private static bool w_saveformula = false;
    }
}
