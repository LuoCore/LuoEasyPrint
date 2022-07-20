using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	public partial class VB2008Print_Convert:VB2008Print
	{
		public static float MyConvTo(float oldvalue)
		{
			switch (this.mypageunits)
			{
				case VB2008Print.PageExportUnit.CentiMeter:
					return (float)((double)oldvalue / 2.54);
				case VB2008Print.PageExportUnit.Inch:
					return oldvalue;
			}
			return oldvalue;
		}
		public static string ConvertPointsToString( PointF[] points)
		{
			checked
			{
				string result;
				if (points == null)
				{
					result = "";
				}
				else if (points.Length <= 0)
				{
					result = "";
				}
				else
				{
					string text = Conversions.ToString(this.MyConvTo(points[0].X)) + "," + Conversions.ToString(this.MyConvTo(points[0].Y));
					int num = 1;
					int num2 = points.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = string.Concat(new string[]
						{
							text,
							";",
							Conversions.ToString(MyConvTo(points[i].X)),
							",",
							Conversions.ToString(MyConvTo(points[i].Y))
						});
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000A81C8 File Offset: 0x000A63C8
		public static PointF[] ConvertStringToPoints( string ss)
		{
			checked
			{
				PointF[] result;
				if (Operators.CompareString(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					string[] array = Strings.Split(ss, ";", -1, CompareMethod.Binary);
					if (array.Length <= 0)
					{
						result = null;
					}
					else
					{
						PointF[] array2 = new PointF[array.Length - 1 + 1];
						int num = 0;
						int num2 = array.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							string[] array3 = Strings.Split(array[i], ",", -1, CompareMethod.Binary);
							unchecked
							{
								array2[i].X = Conversions.ToSingle(array3[0]) + (float)this.mypagesetting.Margins.Left;
								array2[i].Y = Conversions.ToSingle(array3[1]) + (float)this.mypagesetting.Margins.Top;
							}
						}
						result = array2;
					}
				}
				return result;
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000A8290 File Offset: 0x000A6490
		public static string ConvertPointToString( PointF point)
		{
			return Conversions.ToString(MyConvTo( point.X)) + "," + Conversions.ToString(MyConvTo(point.Y));
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000A82D8 File Offset: 0x000A64D8
		public static PointF ConvertStringToPoint(string ss)
		{
			PointF result = new PointF();
			if (Operators.CompareString(ss, "", false) == 0)
			{
				PointF pointF=new PointF();
				result = pointF;
			}
			else
			{
				string[] array = Strings.Split(ss, ",", -1, CompareMethod.Binary);
				if (array.Length <= 0)
				{
					result = PointF.Empty;
				}
				else
				{
					PointF pointF2 = new PointF();
					pointF2.X = Conversions.ToSingle(array[0]) + (float)this.mypagesetting.Margins.Left;
					pointF2.Y = Conversions.ToSingle(array[1]) + (float)this.mypagesetting.Margins.Top;
					result = pointF2;
				}
			}
			return result;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000A835C File Offset: 0x000A655C
		public static string ConvertRectToString( RectangleF rec)
		{
			return string.Concat(new string[]
			{
				Conversions.ToString(this.MyConvTo(rec.X)),
				",",
				Conversions.ToString(this.MyConvTo(rec.Y)),
				",",
				Conversions.ToString(this.MyConvTo(rec.Width)),
				",",
				Conversions.ToString(this.MyConvTo(rec.Height))
			});
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000A83EC File Offset: 0x000A65EC
		public static RectangleF ConvertStringToRect( string ss)
		{
			string[] array = Strings.Split(ss, ",", -1, CompareMethod.Binary);
			RectangleF result = new RectangleF();
			result.X = Conversions.ToSingle(array[0]) + (float)this.mypagesetting.Margins.Left;
			result.Y = Conversions.ToSingle(array[1]) + (float)this.mypagesetting.Margins.Top;
			result.Width = Conversions.ToSingle(array[2]);
			result.Height = Conversions.ToSingle(array[3]);
			return result;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000A846C File Offset: 0x000A666C
		public static string ConvertRectSToString( RectangleF[] rec)
		{
			checked
			{
				string result;
				if (rec == null)
				{
					result = "";
				}
				else if (rec.Length <= 0)
				{
					result = "";
				}
				else
				{
					string text = this.ConvertRectToString(rec[0]);
					int num = 1;
					int num2 = rec.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = text + ";" + this.ConvertRectToString(rec[i]);
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000A84E0 File Offset: 0x000A66E0
		public static RectangleF[] ConvertStringToRectS( string ss)
		{
			checked
			{
				RectangleF[] result;
				if (Operators.CompareString(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					try
					{
						string[] array = Strings.Split(ss, ";", -1, CompareMethod.Binary);
						RectangleF[] array2 = new RectangleF[array.Length - 1 + 1];
						int num = 0;
						int num2 = array.Length - 1;
						for (int i = num; i <= num2; i++)
						{
							array2[i] = this.ConvertStringToRect(array[i]);
						}
						result = array2;
					}
					catch (Exception ex)
					{
						result = null;
					}
				}
				return result;
			}
		}
	}
}
