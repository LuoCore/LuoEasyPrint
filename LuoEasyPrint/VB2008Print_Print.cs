using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
    public static class VB2008Print_Print
    {
        public static bool CanSpanPrint(this VB2008Print print, string myleft, string mymiddle, string myright, ref string mys, ref StringAlignment alg)
        {
            int num = 0;
            StringAlignment stringAlignment = StringAlignment.Near;
            checked
            {
                if (Operators.CompareString(myleft, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Near;
                    mys = myleft;
                }
                if (Operators.CompareString(mymiddle, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Center;
                    mys = mymiddle;
                }
                if (Operators.CompareString(myright, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Far;
                    mys = myright;
                }
                bool result = num == 1;
                alg = stringAlignment;
                return result;
            }
        }
        public static float[] ParaseBorder(this VB2008Print print, string myborder)
        {
            float[] array = new float[4];
            string[] array2 = Strings.Split(myborder, ",", -1, CompareMethod.Binary);
            try
            {
                if (array2.Length == 1)
                {
                    if (Versioned.IsNumeric(myborder) & Strings.Len(myborder) == 4 & Strings.InStr(myborder, ".", CompareMethod.Binary) <= 0)
                    {
                        array[0] = (float)Conversion.Val(Strings.Mid(myborder, 1, 1));
                        array[1] = (float)Conversion.Val(Strings.Mid(myborder, 2, 1));
                        array[2] = (float)Conversion.Val(Strings.Mid(myborder, 3, 1));
                        array[3] = (float)Conversion.Val(Strings.Mid(myborder, 4, 1));
                    }
                    else if (Versioned.IsNumeric(myborder))
                    {
                        array[0] = (float)Conversion.Val(myborder);
                        array[1] = (float)Conversion.Val(myborder);
                        array[2] = (float)Conversion.Val(myborder);
                        array[3] = (float)Conversion.Val(myborder);
                    }
                    else
                    {
                        array[0] = 0f;
                        array[1] = 0f;
                        array[2] = 0f;
                        array[3] = 0f;
                    }
                }
                else if (array2.Length == 4)
                {
                    array[0] = (float)Conversion.Val(array2[0]);
                    array[1] = (float)Conversion.Val(array2[1]);
                    array[2] = (float)Conversion.Val(array2[2]);
                    array[3] = (float)Conversion.Val(array2[3]);
                }
                else
                {
                    array[0] = 0f;
                    array[1] = 0f;
                    array[2] = 0f;
                    array[3] = 0f;
                }
            }
            catch (Exception ex)
            {
                array[0] = 0f;
                array[1] = 0f;
                array[2] = 0f;
                array[3] = 0f;
            }
            return array;
        }


        public static void GetHVMergeWidthAndHeight(this VB2008Print print, DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, int torow, ref float mywidth, ref float myheight)
        {
            int num=0;
            myheight = print.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, false);
            checked
            {
                if (num == 1)
                {
                    int num2=0;
                    mywidth = print.GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, true);
                }
                else
                {
                    int num2=0;
                    mywidth = print.GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, false);
                    if (num2 == 1)
                    {
                        myheight = print.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
                    }
                    else
                    {
                        mywidth = cellwidth[curcol];
                        int i = 1;
                        while (i <= num - 1)
                        {
                            if (ms.Rows[i].Visible)
                            {
                                if (Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "下边合并", false) != 0)
                                {
                                    return;
                                }
                                i++;
                            }
                        }
                        myheight = print.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
                        int num3 = curcol + 1;
                        int num4 = curcol + num2 - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            unchecked
                            {
                                if (ms.Columns[mycol[j]].Visible)
                                {
                                    int num5=0;
                                    print.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, false);
                                    if (num5 < num | (Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "下边合并", false) != 0))
                                    {
                                        break;
                                    }
                                    mywidth += cellwidth[j];
                                    print.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, true);
                                    if (Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) == 0 | Operators.CompareString(Conversions.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) == 0)
                                    {
                                        ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
                                        break;
                                    }
                                    ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
                                }
                            }
                        }
                    }
                }
            }
        }


        public static float GetHMergeWidth(this VB2008Print print, DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, ref int colsmerged, bool dobz = true)
        {
            DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
            float num = cellwidth[curcol];
            checked
            {
                try
                {
                    if (Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "水平合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
                    {
                        colsmerged = 1;
                        return num;
                    }
                    if (curcol == cols - 1)
                    {
                        colsmerged = 1;
                        return num;
                    }
                    int num2 = curcol + 1;
                    int num3 = cols - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        if (ms.Columns[mycol[i]].Visible)
                        {
                            DataGridViewCell dataGridViewCell2 = ms.Rows[currow].Cells[mycol[i]];
                            if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "水平合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
                            {
                                unchecked
                                {
                                    num += cellwidth[i];
                                }
                                if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) == 0))
                                {
                                    if (dobz)
                                    {
                                        ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
                                        goto IL_331;
                                    }
                                    goto IL_331;
                                }
                                else
                                {
                                    if (dobz)
                                    {
                                        ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
                                    }
                                    i++;
                                }
                            }
                        IL_36B:
                            colsmerged = i - curcol;
                            goto IL_385;
                        }
                    IL_331:;
                    }

                }
                catch (Exception ex)
                {
                    colsmerged = 1;
                }
            IL_385:
                return num;
            }
        }

        // Token: 0x060013F3 RID: 5107 RVA: 0x0009EF20 File Offset: 0x0009D120
        public static float GetVMergeHeight(this VB2008Print print, DataGridView ms, int curcol, int currow, int[] mycol, int torow, ref int rowsmerged, bool dobz = true)
        {
            DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
            float num = print.ConvFromDisplay((float)ms.Rows[currow].Height, false);
            checked
            {
                try
                {
                    if (Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "垂直合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
                    {
                        rowsmerged = 1;
                        return num;
                    }
                    if (currow == torow)
                    {
                        rowsmerged = 1;
                        return num;
                    }
                    for (int i = currow + 1; i <= torow; i++)
                    {
                        if (ms.Rows[i].Visible)
                        {
                            DataGridViewCell dataGridViewCell2 = ms.Rows[i].Cells[mycol[curcol]];
                            if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "垂直合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
                            {
                                float num2 = print.ConvFromDisplay((float)ms.Rows[i].Height, false);
                                if (!print.MyIsNewPage(unchecked(num + num2), false))
                                {
                                    unchecked
                                    {
                                        num += num2;
                                    }
                                    if (!(Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | Operators.CompareString(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) == 0))
                                    {
                                        if (dobz)
                                        {
                                            ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
                                            goto IL_36A;
                                        }
                                        goto IL_36A;
                                    }
                                    else
                                    {
                                        if (dobz)
                                        {
                                            ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
                                        }
                                        i++;
                                    }
                                }
                            }
                        IL_3A4:
                            rowsmerged = i - currow;
                            goto IL_3BE;
                        }
                    IL_36A:;
                    }

                }
                catch (Exception ex)
                {
                    rowsmerged = 1;
                }
            IL_3BE:
                return num;
            }
        }
    }
}
