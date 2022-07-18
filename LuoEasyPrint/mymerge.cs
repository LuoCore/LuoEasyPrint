using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000D2 RID: 210
	[StandardModule]
	internal sealed class mymerge
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x000CD620 File Offset: 0x000CB820
		public static int GetNextVisibleColumnIndex(DataGridView dgv, int colindex)
		{
			int result = -1;
			int columnCount = dgv.ColumnCount;
			checked
			{
				try
				{
					int displayIndex = dgv.Columns[colindex].DisplayIndex;
					bool flag = false;
					int num = displayIndex + 1;
					int num2 = columnCount - 1;
					int i = num;
					IL_7C:
					while (i <= num2)
					{
						int num3 = 0;
						int num4 = columnCount - 1;
						int j = num3;
						while (j <= num4)
						{
							if (dgv.Columns[j].DisplayIndex != i || !dgv.Columns[j].Visible)
							{
								j++;
							}
							else
							{
								flag = true;
								result = j;
								IL_72:
								if (!flag)
								{
									i++;
									goto IL_7C;
								}
								goto IL_82;
							}
						}
					}
					IL_82:;
				}
				catch (Exception ex)
				{
				}
				return result;
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000CD6D4 File Offset: 0x000CB8D4
		public static int GetPriorVisibleColumnIndex(DataGridView dgv, int colindex)
		{
			int result = -1;
			int columnCount = dgv.ColumnCount;
			checked
			{
				try
				{
					int displayIndex = dgv.Columns[colindex].DisplayIndex;
					bool flag = false;
					int i = displayIndex - 1;
					IL_77:
					while (i >= 0)
					{
						int num = 0;
						int num2 = columnCount - 1;
						int j = num;
						while (j <= num2)
						{
							if (dgv.Columns[j].DisplayIndex != i || !dgv.Columns[j].Visible)
							{
								j++;
							}
							else
							{
								flag = true;
								result = j;
								IL_6D:
								if (!flag)
								{
									i += -1;
									goto IL_77;
								}
								goto IL_7C;
							}
						}
					}
					IL_7C:;
				}
				catch (Exception ex)
				{
				}
				return result;
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000CD780 File Offset: 0x000CB980
		public static float GetHMergeWidth(DataGridView dgv, int curcol, int currow, ref int colsmerged, ref int leftmerged, ref int rightmerged, ref int firstcolumn, ref int firstc, bool iscancheckheight = true)
		{
			DataGridViewCell dataGridViewCell = dgv.Rows[currow].Cells[curcol];
			float num = (float)dgv.Columns[curcol].Width;
			firstcolumn = 0;
			firstc = curcol;
			try
			{
				if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "水平合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#水平合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0)
				{
					colsmerged = 1;
					return num;
				}
				colsmerged = 1;
				rightmerged = 0;
				leftmerged = 0;
				int num2= 0;
				int num3= 0;
				int num4= 0;
				int num5= 0;
				int num6 = 0;
				if (iscancheckheight)
				{
					mymerge.GetVMergeHeight(dgv, curcol, currow, ref num2, ref num3, ref num4, ref num5, ref num6);
				}
				int i = mymerge.GetNextVisibleColumnIndex(dgv, curcol);
				int num7=0;
				if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "水平合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#水平合并#", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) == 0)
				{
					while (i >= 0)
					{
						if (dgv.Columns[i].Visible)
						{
							DataGridViewCell dataGridViewCell2 = dgv.Rows[currow].Cells[i];
							if ((String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "水平合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "#水平合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0) || !dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
							{
								break;
							}
							mymerge.GetVMergeHeight(dgv, i, currow, ref num7, ref num3, ref num4, ref num5, ref num6);
							if (num7 > 1 && num7 != num2)
							{
								break;
							}
							num += (float)dgv.Columns[i].Width;
							checked
							{
								rightmerged++;
								if (String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) == 0)
								{
									break;
								}
							}
						}
						i = mymerge.GetNextVisibleColumnIndex(dgv, i);
					}
				}
				if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "水平合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#水平合并#", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) == 0)
				{
					for (i = mymerge.GetPriorVisibleColumnIndex(dgv, curcol); i >= 0; i = mymerge.GetPriorVisibleColumnIndex(dgv, i))
					{
						if (dgv.Columns[i].Visible)
						{
							DataGridViewCell dataGridViewCell2 = dgv.Rows[currow].Cells[i];
							if ((String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "水平合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "#水平合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0) || !dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
							{
								break;
							}
							if (iscancheckheight)
							{
								mymerge.GetVMergeHeight(dgv, i, currow, ref num7, ref num3, ref num4, ref num5, ref num6);
								if (num7 > 1 && num7 != num2)
								{
									break;
								}
							}
							num += (float)dgv.Columns[i].Width;
							checked
							{
								leftmerged++;
								firstcolumn += dgv.Columns[i].Width;
								firstc = i;
								if (String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) == 0)
								{
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				colsmerged = 1;
			}
			colsmerged = checked(rightmerged + leftmerged + 1);
			return num;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000CDFF0 File Offset: 0x000CC1F0
		public static int GetVMergeHeight(DataGridView dgv, int curcol, int currow, ref int rowsmerged, ref int downrowsmerged, ref int uprowsmerged, ref int firstrow, ref int firstr)
		{
			DataGridViewCell dataGridViewCell = dgv.Rows[currow].Cells[curcol];
			int num = dgv.Rows[currow].Height;
			firstrow = 0;
			firstr = currow;
			checked
			{
				try
				{
					if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "垂直合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#垂直合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
					{
						rowsmerged = 1;
						return num;
					}
					int rowCount = dgv.RowCount;
					downrowsmerged = 0;
					uprowsmerged = 0;
					rowsmerged = 1;
					if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "垂直合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#垂直合并#", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "下边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) == 0)
					{
						int num2 = currow + 1;
						int num3 = rowCount - 1;
						for (int i = num2; i <= num3; i++)
						{
							if (dgv.Rows[i].Visible)
							{
								DataGridViewCell dataGridViewCell2 = dgv.Rows[i].Cells[curcol];
								if ((String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "垂直合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "#垂直合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0) || !dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
								{
									break;
								}
								float num4 = (float)dgv.Rows[i].Height;
								num = (int)Math.Round((double)(unchecked((float)num + num4)));
								downrowsmerged++;
								if (String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "上边合并", false) == 0)
								{
									break;
								}
							}
						}
					}
					if (String.Compare(Conversions.ToString(dataGridViewCell.Tag), "垂直合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "#垂直合并#", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右上合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "上边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "左边合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell.Tag), "右边合并", false) == 0)
					{
						for (int i = currow - 1; i >= 0; i += -1)
						{
							if (dgv.Rows[i].Visible)
							{
								DataGridViewCell dataGridViewCell2 = dgv.Rows[i].Cells[curcol];
								if ((String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "垂直合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "#垂直合并#", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右下合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0) || !dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
								{
									break;
								}
								float num4 = (float)dgv.Rows[i].Height;
								num = (int)Math.Round((double)(unchecked((float)num + num4)));
								uprowsmerged++;
								firstrow = (int)Math.Round((double)(unchecked((float)firstrow + num4)));
								firstr = i;
								if (String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "左下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "右下合并", false) == 0 | String.Compare(Conversions.ToString(dataGridViewCell2.Tag), "下边合并", false) == 0)
								{
									break;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					rowsmerged = 1;
				}
				rowsmerged = uprowsmerged + downrowsmerged + 1;
				return num;
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000CE810 File Offset: 0x000CCA10
		public static void GetHVMergeWidthAndHeight(DataGridView dgv, int curcol, int currow, ref float mywidth, ref float myheight, ref int rightmergecols, ref int leftmergecols, ref int upmergerows, ref int downmergerows, ref int firstcolumn, ref int firstrow, ref int firstc, ref int firstr)
		{
			int num = 1;
			int num2 = 1;
			rightmergecols = 0;
			leftmergecols = 0;
			upmergerows = 0;
			downmergerows = 0;
			firstcolumn = 0;
			firstrow = 0;
			myheight = (float)mymerge.GetVMergeHeight(dgv, curcol, currow, ref num2, ref downmergerows, ref upmergerows, ref firstrow, ref firstr);
			checked
			{
				if (num2 == 1)
				{
					mywidth = mymerge.GetHMergeWidth(dgv, curcol, currow, ref num, ref leftmergecols, ref rightmergecols, ref firstcolumn, ref firstc, true);
				}
				else
				{
					mywidth = mymerge.GetHMergeWidth(dgv, curcol, currow, ref num, ref leftmergecols, ref rightmergecols, ref firstcolumn, ref firstc, true);
					if (num != 1)
					{
						int num3 = curcol;
						firstcolumn = 0;
						mywidth = (float)dgv.Columns[curcol].Width;
						int num4 = 1;
						int num5 = rightmergecols;
						for (int i = num4; i <= num5; i++)
						{
							num3 = mymerge.GetNextVisibleColumnIndex(dgv, num3);
							if (dgv.Columns[num3].Visible)
							{
								int num6= 0;
								int num7= 0;
								int num8= 0;
								int num9 = 0;
								int num10=0;
								mymerge.GetVMergeHeight(dgv, num3, currow, ref num6, ref num7, ref num8, ref num9, ref num10);
								if (!(num6 < num2 | (String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左上合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左下合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左边合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "下边合并", false) != 0)))
								{
									unchecked
									{
										mywidth += (float)dgv.Columns[num3].Width;
										if (!(String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左上合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左下合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "左边合并", false) == 0))
										{
											goto IL_30D;
										}
									}
								}
								else
								{
									rightmergecols = i - 1;
								}
								IL_325:
								num3 = curcol;
								firstc = curcol;
								int num11 = num3;
								int num12 = 1;
								int num13 = leftmergecols;
								for (int j = num12; j <= num13; j++)
								{
									num3 = mymerge.GetPriorVisibleColumnIndex(dgv, num3);
									if (dgv.Columns[num3].Visible)
									{
										mymerge.GetVMergeHeight(dgv, num3, currow, ref num6, ref num7, ref num8, ref num9, ref num10);
										if (!(num6 < num2 | (String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右上合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右下合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右边合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "上边合并", false) != 0 & String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "下边合并", false) != 0)))
										{
											unchecked
											{
												mywidth += (float)dgv.Columns[num3].Width;
											}
											firstcolumn += dgv.Columns[num3].Width;
											if (!(String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右上合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右下合并", false) == 0 | String.Compare(Conversions.ToString(dgv.Rows[currow].Cells[num3].Tag), "右边合并", false) == 0))
											{
												goto IL_5CA;
											}
										}
										else
										{
											leftmergecols = j - 1;
										}
										IL_5E4:
										firstc = num11;
										num = leftmergecols + rightmergecols + 1;
										return;
									}
									IL_5CA:
									num11 = num3;
								}
							
							}
							IL_30D:;
						}
					
					}
				}
			}
		}
	}
}
