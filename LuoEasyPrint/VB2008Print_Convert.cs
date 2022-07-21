using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	public static partial class VB2008Print_Convert
	{
		public static float ConvFromMMToDisplay(this VB2008Print print, float myw)
		{
			float num = (float)((double)(myw / 10f) / 2.54);
			float num2 = print.PIXELSPERINCHX;
			num2 = num * num2;
			return Convert.ToSingle(Math.Floor(new decimal(num2)));
		}
		public static float MyConvTo(this VB2008Print print, float oldvalue)
		{
			switch (print.mypageunits)
			{
				case VB2008Print_EnumType.PageExportUnit.CentiMeter:
					return (float)((double)oldvalue / 2.54);
				case VB2008Print_EnumType.PageExportUnit.Inch:
					return oldvalue;
			}
			return oldvalue;
		}
		public static string ConvertPointsToString(this VB2008Print print, PointF[] points)
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
					string text = Conversions.ToString(print.MyConvTo(points[0].X)) + "," + Conversions.ToString(print.MyConvTo(points[0].Y));
					int num = 1;
					int num2 = points.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = string.Concat(new string[]
						{
							text,
							";",
							Conversions.ToString(print.MyConvTo(points[i].X)),
							",",
							Conversions.ToString(print.MyConvTo(points[i].Y))
						});
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000A81C8 File Offset: 0x000A63C8
		public static PointF[] ConvertStringToPoints(this VB2008Print print, string ss)
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
								array2[i].X = Conversions.ToSingle(array3[0]) + (float)print.mypagesetting.Margins.Left;
								array2[i].Y = Conversions.ToSingle(array3[1]) + (float)print.mypagesetting.Margins.Top;
							}
						}
						result = array2;
					}
				}
				return result;
			}
		}
		public static string ConvertPointToString(this VB2008Print print, PointF point)
		{
			return Conversions.ToString(print.MyConvTo( point.X)) + "," + Conversions.ToString(print.MyConvTo(point.Y));
		}
		public static PointF ConvertStringToPoint(this VB2008Print print, string ss)
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
					pointF2.X = Conversions.ToSingle(array[0]) + (float)print.mypagesetting.Margins.Left;
					pointF2.Y = Conversions.ToSingle(array[1]) + (float)print.mypagesetting.Margins.Top;
					result = pointF2;
				}
			}
			return result;
		}

	
		public static string ConvertRectToString(this VB2008Print print, RectangleF rec)
		{
			return string.Concat(new string[]
			{
				Conversions.ToString(print.MyConvTo(rec.X)),
				",",
				Conversions.ToString(print.MyConvTo(rec.Y)),
				",",
				Conversions.ToString(print.MyConvTo(rec.Width)),
				",",
				Conversions.ToString(print.MyConvTo(rec.Height))
			});
		}

	
		public static RectangleF ConvertStringToRect(this VB2008Print print, string ss)
		{
			
			string[] array = Strings.Split(ss, ",", -1, CompareMethod.Binary);
			RectangleF result = new RectangleF();
			result.X = Conversions.ToSingle(array[0]) + (float)print.mypagesetting.Margins.Left;
			result.Y = Conversions.ToSingle(array[1]) + (float)print.mypagesetting.Margins.Top;
			result.Width = Conversions.ToSingle(array[2]);
			result.Height = Conversions.ToSingle(array[3]);
			return result;
		}

		public static string ConvertRectSToString(this VB2008Print print, RectangleF[] rec)
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
					string text = print.ConvertRectToString(rec[0]);
					int num = 1;
					int num2 = rec.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = text + ";" + print.ConvertRectToString(rec[i]);
					}
					result = text;
				}
				return result;
			}
		}

		public static RectangleF[] ConvertStringToRectS(this VB2008Print print, string ss)
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
							array2[i] = print.ConvertStringToRect(array[i]);
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
