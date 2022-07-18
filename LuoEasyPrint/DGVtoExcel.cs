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
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace LuoEasyPrint
{
    // Token: 0x0200011A RID: 282
    [StandardModule]
    internal sealed class DGVtoExcel
    {
        // Token: 0x06001CA5 RID: 7333 RVA: 0x000E2024 File Offset: 0x000E0224
        public static bool DGVToExcel(DataGridView mydgv, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", string sheetname = "", bool numericmode = true)
        {
            bool result = DGVtoExcel.myDGVToExcel(mydgv, null, title, FileName, Tableheader, TableFooter, sheetname, numericmode);
            GC.Collect();
            return result;
        }

        // Token: 0x06001CA6 RID: 7334 RVA: 0x000E2048 File Offset: 0x000E0248
        public static bool DGVToExcel(DataGridView mydgv, TreeView columnheadertree, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", bool numericmode = true)
        {
            bool result = DGVtoExcel.myDGVToExcel(mydgv, columnheadertree, title, FileName, Tableheader, TableFooter, "", numericmode);
            GC.Collect();
            return result;
        }

        // Token: 0x06001CA7 RID: 7335 RVA: 0x000E2070 File Offset: 0x000E0270
        private static bool myDGVToExcel(DataGridView mydgv, TreeView columnheadertree, string title = "", string FileName = "", string Tableheader = "", string TableFooter = "", string sheetname = "", bool numericmode = true)
        {
            return DGVtoExcel.myDGVToExcel(mydgv, columnheadertree, new Font("黑体", 18f, FontStyle.Bold), title, FileName, new Font("宋体", 12f), Tableheader, new Font("宋体", 12f), TableFooter, sheetname, true, true, null, numericmode, false, false);
        }

        // Token: 0x06001CA8 RID: 7336 RVA: 0x000E20C4 File Offset: 0x000E02C4
        public static bool myDGVToExcel(DataGridView mydgv, TreeView columnheadertree, Font titlefont, string title, string FileName, Font tableheaderfont, string Tableheader, Font tablefooterfont, string TableFooter, string sheetname, bool isopenfile, bool isshowprogress = true, Image pic = null, bool numericmode = true, bool saveformula = false, bool addmode = false)
        {
            DGVtoExcel.w_saveformula = saveformula;
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
                            DGVtoExcel.w_ZDYcolors = 8;
                            int endcol = num - 1;
                            if (String.Compare(FileName, "", false) == 0)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.Title = "请选择要导出Excel文件的路径和文件名";
                                saveFileDialog.AddExtension = true;
                                saveFileDialog.OverwritePrompt = false;
                                saveFileDialog.DefaultExt = "xls";
                                saveFileDialog.Filter = "97-2003 Excel文件(*.xls)|*.xls";
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
                            DGVtoExcel.w_font = null;
                            DGVtoExcel.w_ifont = null;
                            DGVtoExcel.w_Cellstyle = null;
                            DGVtoExcel.w_iCellstyle = null;
                            DGVtoExcel.w_color = null;
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
                            HSSFWorkbook hssfworkbook;
                            if (MyProject.Computer.FileSystem.FileExists(FileName))
                            {
                                FileStream fileStream;
                                try
                                {
                                    fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
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
                                    hssfworkbook = new HSSFWorkbook(fileStream);
                                    goto IL_464;
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
                                    hssfworkbook = null;
                                    return false;
                                }
                            }
                            hssfworkbook = new HSSFWorkbook();
                        IL_464:
                            string excelNewSheetName = DGVtoExcel.GetExcelNewSheetName(hssfworkbook, sheetname);
                            HSSFSheet hssfsheet = (HSSFSheet)hssfworkbook.CreateSheet(excelNewSheetName);
                            int num6;
                            if (String.Compare(title, "", false) == 0)
                            {
                                num6 = 0;
                            }
                            else
                            {
                                DGVtoExcel.SetTitle(hssfworkbook, hssfsheet, 0, 0, 0, endcol, title, titlefont);
                                num6 = 1;
                            }
                            if (String.Compare(Tableheader, "", false) != 0)
                            {
                                DGVtoExcel.SetTitle(hssfworkbook, hssfsheet, num6, num6, 0, endcol, Tableheader, tableheaderfont);
                                num6++;
                            }
                            DGVtoExcel.w_gridcolor = DGVtoExcel.GetXLColour(hssfworkbook, mydgv.GridColor);
                            if (mydgv.ColumnHeadersVisible)
                            {
                                if (columnheadertree == null)
                                {
                                    IRow row = hssfsheet.CreateRow(num6);
                                    row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.ColumnHeadersHeight, false)) * 72f);
                                    int num7 = 0;
                                    int num8 = num - 1;
                                    for (int i = num7; i <= num8; i++)
                                    {
                                        DGVtoExcel.SetCellValue(hssfsheet, num6, i, mydgv.Columns[array3[i]].HeaderText, "");
                                        Font font = Module1.GetDGVHeaderFont(mydgv.Columns[array3[i]]);
                                        Color bkcolor = Module1.GetDGVHeaderBackColor(mydgv.Columns[array3[i]]);
                                        Color forcolor = Module1.GetDGVHeaderForeColor(mydgv.Columns[array3[i]]);
                                        DGVtoExcel.SetCellStyle(hssfworkbook, hssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                    }
                                }
                                else
                                {
                                    mytree mytree = new mytree(columnheadertree, mydgv);
                                    int leves = mytree.GetLeves();
                                    if (mytree.GetColumns() != mydgv.ColumnCount)
                                    {
                                        mytree.Dispose();
                                        IRow row = hssfsheet.CreateRow(num6);
                                        row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.ColumnHeadersHeight, false)) * 72f);
                                        int num9 = 0;
                                        int num10 = num - 1;
                                        for (int i = num9; i <= num10; i++)
                                        {
                                            DGVtoExcel.SetCellValue(hssfsheet, num6, i, mydgv.Columns[array3[i]].HeaderText, "");
                                            Font font = Module1.GetDGVHeaderFont(mydgv.Columns[array3[i]]);
                                            Color bkcolor = Module1.GetDGVHeaderBackColor(mydgv.Columns[array3[i]]);
                                            Color forcolor = Module1.GetDGVHeaderForeColor(mydgv.Columns[array3[i]]);
                                            DGVtoExcel.SetCellStyle(hssfworkbook, hssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                        }
                                    }
                                    else
                                    {
                                        int num11 = 1;
                                        int num12 = leves;
                                        for (int k = num11; k <= num12; k++)
                                        {
                                            IRow row = hssfsheet.CreateRow(num6 + k - 1);
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
                                                        DGVtoExcel.SetCellValue(hssfsheet, num6, i, nodeText, "");
                                                        DGVtoExcel.SetCellStyle(hssfworkbook, hssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
                                                    }
                                                    else
                                                    {
                                                        DGVtoExcel.SetCellValue(hssfsheet, num6, i, nodeText, "");
                                                        DGVtoExcel.SetCellStyle(hssfworkbook, hssfsheet, num6, i, true, true, true, true, StringAlignment.Center, StringAlignment.Center, font, bkcolor, forcolor, false);
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
                                                                    DGVtoExcel.SetCellBorder(hssfworkbook, hssfsheet, l, m, true, true, true, true);
                                                                }
                                                            }
                                                        }
                                                        DGVtoExcel.SetMergeCell(hssfsheet, num6, i, num6 + cellHeightLevels - 1, i + cellWidthCols - 1);
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
                                IRow row = hssfsheet.CreateRow(num6 + i);
                                row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.Rows[i].Height, false)) * 72f);
                                if (!mydgv.Rows[i].Visible)
                                {
                                    row.ZeroHeight = true;
                                }
                                if (i + num6 == 65535)
                                {
                                    break;
                                }
                            }
                            int num29 = 0;
                            int num30 = 0;
                            if (isshowprogress)
                            {
                                progressexcel.ProgressBar1.Maximum = mydgv.RowCount;
                            }
                            int num31 = 0;
                            int num32 = mydgv.RowCount - 1;
                            for (int i = num31; i <= num32; i++)
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
                                int num33 = 0;
                                int num34 = num - 1;
                                j = num33;
                                while (j <= num34)
                                {
                                    int num35;
                                    if (mydgv.Columns[array3[j]].ValueType == null)
                                    {
                                        num35 = -1;
                                    }
                                    else
                                    {
                                        string left = Strings.Left(mydgv.Columns[array3[j]].ValueType.Name.ToUpper(), 3);
                                        if (String.Compare(left, "STR", false) == 0)
                                        {
                                            num35 = 0;
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
                                                                    num35 = 2;
                                                                    goto IL_B81;
                                                                }
                                                                if (String.Compare(left, "BOO", false) == 0)
                                                                {
                                                                    num35 = 3;
                                                                    flag = false;
                                                                    goto IL_B81;
                                                                }
                                                                num35 = 0;
                                                                goto IL_B81;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            num35 = 1;
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
                                    float num36 = 0;
                                    float num37 = 0;
                                    int num38 = 0;
                                    int num39 = 0;
                                    int num40 = 0;
                                    int num41 = 0;
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
                                                                                        goto IL_D85;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    mymerge.GetHVMergeWidthAndHeight(mydgv, array3[j], i, ref num36, ref num37, ref num25, ref num24, ref num22, ref num23, ref num38, ref num39, ref num40, ref num41);
                                                    num26 = num24 + num25 + 1;
                                                    num21 = num22 + num23 + 1;
                                                    goto IL_D85;
                                                }
                                            }
                                        }
                                    }
                                    num36 = (float)((int)Math.Round((double)mymerge.GetHMergeWidth(mydgv, array3[j], i, ref num26, ref num24, ref num25, ref num38, ref num40, true)));
                                IL_D85:
                                    if (!(num24 > 0 | num22 > 0))
                                    {
                                        if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewImageColumn", false) == 0)
                                        {
                                            if (mydgv.Rows[i].Cells[array3[j]].Value != null)
                                            {
                                                Image img = (Image)mydgv.Rows[i].Cells[array3[j]].FormattedValue;
                                                byte[] byteByImage = DGVtoExcel.GetByteByImage(img);
                                                int num42 = hssfworkbook.AddPicture(byteByImage, PictureType.JPEG);
                                                IDrawing drawing = hssfsheet.CreateDrawingPatriarch();
                                                HSSFClientAnchor hssfclientAnchor = new HSSFClientAnchor(0, 0, 0, 0, j, num6 + i, j + 1, num6 + i + 1);
                                                drawing.CreatePicture(hssfclientAnchor, num42);
                                            }
                                        }
                                        else if (String.Compare(Versioned.TypeName(mydgv.Columns[array3[j]]), "DataGridViewCheckBoxColumn", false) == 0)
                                        {
                                            if (mydgv.Rows[i].Cells[array3[j]].Value != null && DataTypeConversion.ToBoolean(mydgv.Rows[i].Cells[array3[j]].FormattedValue))
                                            {
                                                DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, true);
                                            }
                                            flag = false;
                                        }
                                        else
                                        {
                                            string text = Convert.ToString(mydgv.Rows[i].Cells[array3[j]].FormattedValue) + "";
                                            flag = (Strings.InStr(text, "\r\n", CompareMethod.Binary) > 0);
                                            switch (num35)
                                            {
                                                case -1:
                                                    if (numericmode && Versioned.IsNumeric(text) && Convert.ToDouble(text) <= 99999999999.0)
                                                    {
                                                        DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, Convert.ToDouble(text), Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                        goto IL_10D1;
                                                    }
                                                    DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D1;
                                                case 1:
                                                    if (Versioned.IsNumeric(text))
                                                    {
                                                        DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, Convert.ToDouble(text), Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                        goto IL_10D1;
                                                    }
                                                    DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D1;
                                                case 2:
                                                    DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                                    goto IL_10D1;
                                            }
                                            DGVtoExcel.SetCellValue(hssfsheet, num6 + i, j, text, Convert.ToString(mydgv.Rows[i].Cells[array3[j]].Tag));
                                        }
                                    IL_10D1:
                                        DataGridViewCellStyle dgvcellStyle = Module1.GetDGVCellStyle(mydgv.Rows[i].Cells[array3[j]]);
                                        DataGridViewContentAlignment alignment = dgvcellStyle.Alignment;
                                        StringAlignment valign = StringAlignment.Near;
                                        StringAlignment halign = StringAlignment.Near;
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
                                        DGVtoExcel.SetCellStyle(hssfworkbook, hssfsheet, num6 + i, j, true, true, true, true, halign, valign, Module1.GetDGVCellFont(mydgv.Rows[i].Cells[array3[j]]), bkcolor, forcolor, flag);
                                        if (!(num26 == 1 & num21 == 1))
                                        {
                                            int num43 = num6 + i;
                                            int num44 = num6 + i + num23;
                                            for (int n = num43; n <= num44; n++)
                                            {
                                                int num45 = j;
                                                int num46 = j + num25;
                                                for (int num47 = num45; num47 <= num46; num47++)
                                                {
                                                    if (n != num6 + i | num47 != j)
                                                    {
                                                        DGVtoExcel.SetCellBorder(hssfworkbook, hssfsheet, n, num47, true, true, true, true);
                                                    }
                                                }
                                            }
                                            DGVtoExcel.SetMergeCell(hssfsheet, num6 + i, j, num6 + i + num23, j + num25);
                                            j += num25;
                                        }
                                    }
                                    j++;
                                    continue;
                            
                                    num37 = (float)mymerge.GetVMergeHeight(mydgv, array3[j], i, ref num21, ref num23, ref num22, ref num39, ref num41);
                                }
                                if (i + num6 == 65535 & i != mydgv.RowCount - 1)
                                {
                                    int num48 = 0;
                                    int num49 = num - 1;
                                    for (int num50 = num48; num50 <= num49; num50++)
                                    {
                                        hssfsheet.SetColumnWidth(num50, (int)Math.Round(unchecked(Math.Ceiling((double)mydgv.Columns[array3[num50]].Width / 8.0) * 256.0)));
                                    }
                                    num29++;
                                    excelNewSheetName = DGVtoExcel.GetExcelNewSheetName(hssfworkbook, sheetname);
                                    hssfsheet = (HSSFSheet)hssfworkbook.CreateSheet(excelNewSheetName);
                                    num30 = 1;
                                    int num51 = i + 1;
                                    int num52 = mydgv.RowCount - 1;
                                    for (j = num51; j <= num52; j++)
                                    {
                                        IRow row = hssfsheet.CreateRow(num30 - 1);
                                        if (!mydgv.Rows[j].Visible)
                                        {
                                            row.ZeroHeight = true;
                                        }
                                        row.HeightInPoints = unchecked(Module1.ConvertMmToInch(ruler.ConvertToMM((float)mydgv.Rows[j].Height, false)) * 72f);
                                        if (num30 == 65536)
                                        {
                                            break;
                                        }
                                        num30++;
                                    }
                                    num6 = 0 - i - 1;
                                }
                            }
                            if (num30 == 0)
                            {
                                num6 += mydgv.RowCount;
                            }
                            else
                            {
                                num6 = num30 - 1;
                            }
                            if (String.Compare(TableFooter, "", false) != 0)
                            {
                                DGVtoExcel.SetTitle(hssfworkbook, hssfsheet, num6, num6, 0, endcol, TableFooter, tablefooterfont);
                                num6++;
                            }
                            if (pic != null)
                            {
                                hssfsheet.CreateRow(num6);
                                byte[] byteByImage2 = DGVtoExcel.GetByteByImage(pic);
                                int num53 = hssfworkbook.AddPicture(byteByImage2, PictureType.JPEG);
                                IDrawing drawing2 = hssfsheet.CreateDrawingPatriarch();
                                HSSFClientAnchor hssfclientAnchor2 = new HSSFClientAnchor(0, 0, 0, 0, 0, num6, 0, num6);
                                IPicture picture = drawing2.CreatePicture(hssfclientAnchor2, num53);
                                picture.Resize();
                            }
                            DGVtoExcel.w_font = null;
                            DGVtoExcel.w_ifont = null;
                            DGVtoExcel.w_Cellstyle = null;
                            DGVtoExcel.w_iCellstyle = null;
                            DGVtoExcel.w_color = null;
                            int num54 = 0;
                            int num55 = num - 1;
                            for (int num56 = num54; num56 <= num55; num56++)
                            {
                                hssfsheet.SetColumnWidth(num56, (int)Math.Round(unchecked(Math.Ceiling((double)mydgv.Columns[array3[num56]].Width / 8.0) * 256.0)));
                            }
                            ruler.Dispose();
                            ruler = null;
                            if (isshowprogress)
                            {
                                progressexcel.Close();
                                progressexcel.Dispose();
                            }
                            hssfworkbook.SetActiveSheet(hssfworkbook.GetSheetIndex(excelNewSheetName));
                            hssfsheet.ForceFormulaRecalculation = true;
                            if (!DGVtoExcel.WriteToFile(hssfworkbook, FileName))
                            {
                                hssfworkbook = null;
                                result = false;
                            }
                            else
                            {
                                hssfworkbook = null;
                                if (isopenfile && Interaction.MsgBox("导出的Excel文件已保存到【" + FileName + " 】\r\n您是否要立即打开这个文件以查看其内容?", MsgBoxStyle.YesNoCancel, "提示信息") == MsgBoxResult.Yes)
                                {
                                    try
                                    {
                                        Process.Start(FileName);
                                    }
                                    catch (Exception ex4)
                                    {
                                        try
                                        {
                                            Thread.Sleep(100);
                                            Process.Start(FileName);
                                        }
                                        catch (Exception ex5)
                                        {
                                        }
                                    }
                                }
                                result = true;
                            }
                        }
                    }
                    catch (Exception ex6)
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
                        catch (Exception ex7)
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

        // Token: 0x06001CA9 RID: 7337 RVA: 0x000E37AC File Offset: 0x000E19AC
        private static void SetTitle(HSSFWorkbook mybook, HSSFSheet mysheet, int startrow, int endrow, int startcol, int endcol, string titltext, Font titlefont)
        {
            IRow row = null;
            checked
            {
                for (int i = startrow; i <= endrow; i++)
                {
                    row = mysheet.CreateRow(i);
                }
                ICell cell = row.CreateCell(0);
                cell.SetCellValue(titltext);
                DGVtoExcel.SetCellStyle(mybook, mysheet, startrow, startcol, false, false, false, false, StringAlignment.Center, StringAlignment.Center, titlefont, Color.Transparent, Color.Black, true);
                row.HeightInPoints = DGVtoExcel.TestHeight(titltext, titlefont);
                DGVtoExcel.SetMergeCell(mysheet, startrow, startcol, endrow, endcol);
            }
        }

        // Token: 0x06001CAA RID: 7338 RVA: 0x000E381C File Offset: 0x000E1A1C
        private static float TestHeight(string tt, Font f)
        {
            PrintDocument printDocument = new PrintDocument();
            Graphics graphics = printDocument.PrinterSettings.CreateMeasurementGraphics();
            float height = graphics.MeasureString(tt, f).Height;
            graphics.Dispose();
            printDocument.Dispose();
            return height;
        }

        // Token: 0x06001CAB RID: 7339 RVA: 0x000E3860 File Offset: 0x000E1A60
        private static void SetMergeCell(HSSFSheet mysheet, int startrow, int startcol, int endrow, int endcol)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(startrow, endrow, startcol, endcol);
            mysheet.AddMergedRegion(cellRangeAddress);
        }

        // Token: 0x06001CAC RID: 7340 RVA: 0x000E3884 File Offset: 0x000E1A84
        private static void SetCellBorder(HSSFWorkbook mybook, HSSFSheet mysheet, int rowindex, int colindex, bool leftborder, bool rightborder, bool topborder, bool bottomborder)
        {
            NPOI.SS.UserModel.BorderStyle borderStyle = NPOI.SS.UserModel.BorderStyle.None;
            ICell cell = mysheet.GetRow(rowindex).GetCell(colindex);
            if (cell == null)
            {
                cell = mysheet.GetRow(rowindex).CreateCell(colindex);
            }
            ICellStyle cellStyle = mybook.CreateCellStyle();
            if (leftborder)
            {
                cellStyle.BorderLeft = borderStyle;
                cellStyle.LeftBorderColor = DGVtoExcel.w_gridcolor;
            }
            else
            {
                cellStyle.BorderLeft = 0;
            }
            if (rightborder)
            {
                cellStyle.BorderRight = borderStyle;
                cellStyle.RightBorderColor = DGVtoExcel.w_gridcolor;
            }
            else
            {
                cellStyle.BorderRight = 0;
            }
            if (topborder)
            {
                cellStyle.BorderTop = borderStyle;
                cellStyle.TopBorderColor = DGVtoExcel.w_gridcolor;
            }
            else
            {
                cellStyle.BorderTop = 0;
            }
            if (bottomborder)
            {
                cellStyle.BorderBottom = borderStyle;
                cellStyle.BottomBorderColor = DGVtoExcel.w_gridcolor;
            }
            else
            {
                cellStyle.BorderBottom = 0;
            }
            cell.CellStyle = cellStyle;
        }

        // Token: 0x06001CAD RID: 7341 RVA: 0x000E393C File Offset: 0x000E1B3C
        private static void SetCellValue(HSSFSheet mysheet, int rowindex, int colindex, string value, string thetag)
        {
            if (DGVtoExcel.w_saveformula && thetag != null && Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) > 0)
            {
                thetag = Strings.Mid(thetag, checked(Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) + Strings.Len("$公式：$")));
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellFormula(thetag);
            }
            else
            {
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
            }
        }

        // Token: 0x06001CAE RID: 7342 RVA: 0x000E39B0 File Offset: 0x000E1BB0
        private static void SetCellValue(HSSFSheet mysheet, int rowindex, int colindex, double value, string thetag)
        {
            if (DGVtoExcel.w_saveformula && thetag != null && Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) > 0)
            {
                thetag = Strings.Mid(thetag, checked(Strings.InStr(thetag, "$公式：$", CompareMethod.Binary) + Strings.Len("$公式：$")));
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellFormula(thetag);
            }
            else
            {
                mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
            }
        }

        // Token: 0x06001CAF RID: 7343 RVA: 0x0000A0FF File Offset: 0x000082FF
        private static void SetCellValue(HSSFSheet mysheet, int rowindex, int colindex, DateTime value)
        {
            mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
        }

        // Token: 0x06001CB0 RID: 7344 RVA: 0x0000A114 File Offset: 0x00008314
        private static void SetCellValue(HSSFSheet mysheet, int rowindex, int colindex, bool value)
        {
            mysheet.GetRow(rowindex).CreateCell(colindex).SetCellValue(value);
        }

        // Token: 0x06001CB1 RID: 7345 RVA: 0x000E3A24 File Offset: 0x000E1C24
        private static void SetCellStyle(HSSFWorkbook mybook, HSSFSheet mysheet, int rowindex, int colindex, bool leftborder, bool rightborder, bool topborder, bool bottomborder, StringAlignment halign, StringAlignment valign, Font myfont, Color bkcolor, Color forcolor, bool needwrap = false)
        {
            NPOI.SS.UserModel.BorderStyle borderStyle = NPOI.SS.UserModel.BorderStyle.Thin;
            ICell cell = mysheet.GetRow(rowindex).GetCell(colindex);
            if (cell == null)
            {
                cell = mysheet.GetRow(rowindex).CreateCell(colindex);
            }
            ICellStyle cellStyle = null;
            bool flag = false;
            checked
            {
                string cellStyleString;
                int num3 = 0;
                if (DGVtoExcel.w_Cellstyle != null)
                {
                    cellStyleString = DGVtoExcel.GetCellStyleString(leftborder, rightborder, topborder, bottomborder, halign, valign, myfont, bkcolor, forcolor, needwrap);
                    int num = 0;
                    int num2 = DGVtoExcel.w_Cellstyle.Length - 1;
                    int i = num;
                    while (i <= num2)
                    {
                        if (String.Compare(cellStyleString, DGVtoExcel.w_Cellstyle[i], false) == 0)
                        {
                            flag = true;
                        IL_BC:
                            if (flag)
                            {
                                cellStyle = DGVtoExcel.w_iCellstyle[i];
                                goto IL_115;
                            }
                            num3 = DGVtoExcel.w_Cellstyle.Length;
                            DGVtoExcel.w_Cellstyle = (string[])Utils.CopyArray((Array)DGVtoExcel.w_Cellstyle, new string[num3 + 1]);
                            DGVtoExcel.w_iCellstyle = (ICellStyle[])Utils.CopyArray((Array)DGVtoExcel.w_iCellstyle, new ICellStyle[num3 + 1]);
                            goto IL_115;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                DGVtoExcel.w_Cellstyle = new string[1];
                DGVtoExcel.w_iCellstyle = new ICellStyle[1];
                num3 = 0;
                cellStyleString = DGVtoExcel.GetCellStyleString(leftborder, rightborder, topborder, bottomborder, halign, valign, myfont, bkcolor, forcolor, needwrap);
            IL_115:
                if (!flag)
                {
                    cellStyle = mybook.CreateCellStyle();
                    if (leftborder)
                    {
                        cellStyle.BorderLeft = borderStyle;
                        cellStyle.LeftBorderColor = DGVtoExcel.w_gridcolor;
                    }
                    else
                    {
                        cellStyle.BorderLeft = 0;
                    }
                    if (rightborder)
                    {
                        cellStyle.BorderRight = borderStyle;
                        cellStyle.RightBorderColor = DGVtoExcel.w_gridcolor;
                    }
                    else
                    {
                        cellStyle.BorderRight = 0;
                    }
                    if (topborder)
                    {
                        cellStyle.BorderTop = borderStyle;
                        cellStyle.TopBorderColor = DGVtoExcel.w_gridcolor;
                    }
                    else
                    {
                        cellStyle.BorderTop = 0;
                    }
                    if (bottomborder)
                    {
                        cellStyle.BorderBottom = borderStyle;
                        cellStyle.BottomBorderColor = DGVtoExcel.w_gridcolor;
                    }
                    else
                    {
                        cellStyle.BorderBottom = 0;
                    }
                    if (halign == StringAlignment.Center)
                    {
                        cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    }
                    else if (halign == StringAlignment.Far)
                    {
                        cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Justify;
                    }
                    else
                    {
                        cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    }
                    if (valign == StringAlignment.Near)
                    {
                        cellStyle.VerticalAlignment = 0;
                    }
                    else if (valign == StringAlignment.Far)
                    {
                        cellStyle.VerticalAlignment = VerticalAlignment.Bottom;
                    }
                    else
                    {
                        cellStyle.VerticalAlignment = VerticalAlignment.Center;
                    }
                    if (!bkcolor.IsEmpty && !(bkcolor.Equals(Color.Transparent) | bkcolor.Equals(Color.White)))
                    {
                        cellStyle.FillPattern = FillPattern.SparseDots;
                        cellStyle.FillForegroundColor = DGVtoExcel.GetXLColour(mybook, bkcolor);
                    }
                    if (needwrap)
                    {
                        cellStyle.WrapText = true;
                    }
                    else
                    {
                        cellStyle.WrapText = false;
                    }
                    IFont ifontByFont = DGVtoExcel.GetIFontByFont(mybook, myfont, forcolor);
                    if (!forcolor.IsEmpty && !(forcolor.Equals(Color.Transparent) | forcolor.Equals(Color.Black)))
                    {
                        ifontByFont.Color = DGVtoExcel.GetXLColour(mybook, forcolor);
                    }
                    cellStyle.SetFont(ifontByFont);
                    DGVtoExcel.w_Cellstyle[num3] = cellStyleString;
                    DGVtoExcel.w_iCellstyle[num3] = cellStyle;
                }
                cell.CellStyle = cellStyle;
            }
        }

        // Token: 0x06001CB2 RID: 7346 RVA: 0x000E3D08 File Offset: 0x000E1F08
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

        // Token: 0x06001CB3 RID: 7347 RVA: 0x000E3D60 File Offset: 0x000E1F60
        private static IFont GetIFontByFont(HSSFWorkbook mybook, Font myfont, Color forecolor)
        {
            checked
            {
                int num3;
                if (DGVtoExcel.w_font != null)
                {
                    bool flag = false;
                    int num = 0;
                    int num2 = DGVtoExcel.w_font.Length - 1;
                    int i = num;
                    while (i <= num2)
                    {
                        if (!(DGVtoExcel.IsEqualFont(myfont, DGVtoExcel.w_font[i]) & forecolor.Equals(DGVtoExcel.w_color[i])))
                        {
                            i++;
                        }
                        else
                        {
                            flag = true;
                        IL_81:
                            if (flag)
                            {
                                return DGVtoExcel.w_ifont[i];
                            }
                            num3 = DGVtoExcel.w_font.Length;
                            DGVtoExcel.w_font = (Font[])Utils.CopyArray((Array)DGVtoExcel.w_font, new Font[num3 + 1]);
                            DGVtoExcel.w_ifont = (IFont[])Utils.CopyArray((Array)DGVtoExcel.w_ifont, new IFont[num3 + 1]);
                            DGVtoExcel.w_color = (Color[])Utils.CopyArray((Array)DGVtoExcel.w_color, new Color[num3 + 1]);
                            goto IL_FD;
                        }
                    }
                }
                DGVtoExcel.w_font = new Font[1];
                DGVtoExcel.w_ifont = new IFont[1];
                DGVtoExcel.w_color = new Color[1];
                num3 = 0;
            IL_FD:
                IFont font = mybook.CreateFont();
                font.FontHeightInPoints = (short)Math.Round((double)myfont.SizeInPoints);
                font.FontName = myfont.Name;
                font.IsItalic = myfont.Italic;
                font.IsStrikeout = myfont.Strikeout;
                if (myfont.Underline)
                {
                    font.Underline = FontUnderlineType.Single;
                }
                else
                {
                    font.Underline = 0;
                }
                if (myfont.Bold)
                {
                    font.Boldweight = 700;
                }
                else
                {
                    font.Boldweight = 400;
                }
                DGVtoExcel.w_font[num3] = myfont;
                DGVtoExcel.w_ifont[num3] = font;
                DGVtoExcel.w_color[num3] = forecolor;
                return font;
            }
        }

        // Token: 0x06001CB4 RID: 7348 RVA: 0x000E3F04 File Offset: 0x000E2104
        private static bool IsEqualFont(Font f1, Font f2)
        {
            FontConverter fontConverter = new FontConverter();
            string left = fontConverter.ConvertToString(f1);
            string right = fontConverter.ConvertToString(f2);
            return String.Compare(left, right, false) == 0;
        }

        // Token: 0x06001CB5 RID: 7349 RVA: 0x000E3F3C File Offset: 0x000E213C
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

        // Token: 0x06001CB6 RID: 7350 RVA: 0x000E407C File Offset: 0x000E227C
        private static short GetXLColour(HSSFWorkbook mybook, Color SystemColour)
        {
            HSSFPalette customPalette = mybook.GetCustomPalette();
            HSSFColor hssfcolor = customPalette.FindColor(SystemColour.R, SystemColour.G, SystemColour.B);
            checked
            {
                short indexed;
                if (!Information.IsNothing(hssfcolor) && !(hssfcolor.Indexed >= DGVtoExcel.w_ZDYcolors & hssfcolor.Indexed <= 64))
                {
                    indexed = hssfcolor.Indexed;
                }
                else
                {
                    if (DGVtoExcel.w_ZDYcolors <= 64)
                    {
                        try
                        {
                            customPalette.SetColorAtIndex(DGVtoExcel.w_ZDYcolors, SystemColour.R, SystemColour.G, SystemColour.B);
                            short result = DGVtoExcel.w_ZDYcolors;
                            DGVtoExcel.w_ZDYcolors += 1;
                            return result;
                        }
                        catch (Exception ex)
                        {
                            hssfcolor = customPalette.FindSimilarColor(SystemColour.R, SystemColour.G, SystemColour.B);
                            return hssfcolor.Indexed;
                        }
                    }
                    hssfcolor = customPalette.FindSimilarColor(SystemColour.R, SystemColour.G, SystemColour.B);
                    indexed = hssfcolor.Indexed;
                }
                return indexed;
            }
        }

        // Token: 0x06001CB7 RID: 7351 RVA: 0x000E4188 File Offset: 0x000E2388
        private static bool WriteToFile(HSSFWorkbook mybook, string filename)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filename, FileMode.Create);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "导出Excel失败");
                return false;
            }
            mybook.Write(fileStream);
            fileStream.Close();
            return true;
        }

        // Token: 0x06001CB8 RID: 7352 RVA: 0x000E41E4 File Offset: 0x000E23E4
        private static string GetExcelNewSheetName(HSSFWorkbook mybook, string sheetname)
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

        // Token: 0x04000E1C RID: 3612
        private static Font[] w_font = null;

        // Token: 0x04000E1D RID: 3613
        private static IFont[] w_ifont = null;

        // Token: 0x04000E1E RID: 3614
        private static Color[] w_color;

        // Token: 0x04000E1F RID: 3615
        private static short w_gridcolor;

        // Token: 0x04000E20 RID: 3616
        private static string[] w_Cellstyle = null;

        // Token: 0x04000E21 RID: 3617
        private static ICellStyle[] w_iCellstyle = null;

        // Token: 0x04000E22 RID: 3618
        private static short w_ZDYcolors = 0;

        // Token: 0x04000E23 RID: 3619
        private static bool w_saveformula = false;
    }
}
