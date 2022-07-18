using System;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;
using ZXing.Common;
using ZXing.Datamatrix;
using ZXing.OneD;
using ZXing.PDF417;
using ZXing.QrCode;

namespace LuoEasyPrint
{
	// Token: 0x020000D0 RID: 208
	[StandardModule]
	internal sealed class ZXingBarCode
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x000CA37C File Offset: 0x000C857C
		public static Bitmap GetQRbmp(string txt, int width, int height, Color forecolor, Color bkcolor, int bartype, int margin = 4, string character = "")
		{
			Bitmap result;
			if (String.Compare(txt, "", false) == 0)
			{
				result = null;
			}
			else
			{
				if (margin < 0)
				{
					margin = 0;
				}
				if (width <= 0 | height <= 0)
				{
					Interaction.MsgBox("二维码的宽度和高度必须大于0", MsgBoxStyle.OkOnly, "提示信息");
					result = null;
				}
				else
				{
					Bitmap bitmap = null;
					BarcodeWriter<Bitmap> barcodeWriter = new BarcodeWriter<Bitmap>();
					barcodeWriter.Format =(BarcodeFormat) 2048;
					try
					{
						if (bartype == 2048)
						{
							QrCodeEncodingOptions qrCodeEncodingOptions = new QrCodeEncodingOptions();
							if (String.Compare(Strings.Trim(character), "", false) == 0)
							{
								qrCodeEncodingOptions.CharacterSet = "UTF-8";
							}
							else
							{
								qrCodeEncodingOptions.CharacterSet = character;
							}
							qrCodeEncodingOptions.Margin = margin;
							qrCodeEncodingOptions.Width = width;
							qrCodeEncodingOptions.Height = height;
							qrCodeEncodingOptions.DisableECI = true;
							barcodeWriter.Options = qrCodeEncodingOptions;
							bitmap = barcodeWriter.Write(txt);
							bitmap = ZXingBarCode.FormatBMP(bitmap, margin);
						}
						else if (bartype == 32)
						{
							DatamatrixEncodingOptions datamatrixEncodingOptions = new DatamatrixEncodingOptions();
							datamatrixEncodingOptions.Margin = margin;
							datamatrixEncodingOptions.Width = width;
							datamatrixEncodingOptions.Height = height;
							barcodeWriter.Format = (BarcodeFormat)32;
							barcodeWriter.Options = datamatrixEncodingOptions;
							bitmap = barcodeWriter.Write(txt);
						}
						else if (bartype == 1024)
						{
							PDF417EncodingOptions pdf417EncodingOptions = new PDF417EncodingOptions();
							pdf417EncodingOptions.Width = width;
							pdf417EncodingOptions.Height = height;
							pdf417EncodingOptions.Margin = margin;
							barcodeWriter.Format = (BarcodeFormat)1024;
							barcodeWriter.Options = pdf417EncodingOptions;
							bitmap = barcodeWriter.Write(txt);
						}
						else
						{
							if (bartype != 16)
							{
								if (bartype != 17)
								{
									EncodingOptions encodingOptions = new EncodingOptions();
									encodingOptions.Width = width;
									encodingOptions.Height = height;
									encodingOptions.Margin = margin;
									barcodeWriter.Format = (BarcodeFormat)bartype;
									barcodeWriter.Options = encodingOptions;
									bitmap = barcodeWriter.Write(txt);
									goto IL_203;
								}
							}
							Code128EncodingOptions code128EncodingOptions = new Code128EncodingOptions();
							if (bartype == 16)
							{
								code128EncodingOptions.ForceCodesetB = false;
							}
							else
							{
								code128EncodingOptions.ForceCodesetB = true;
							}
							code128EncodingOptions.Width = width;
							code128EncodingOptions.Height = height;
							code128EncodingOptions.Margin = margin;
							barcodeWriter.Format = (BarcodeFormat)16;
							barcodeWriter.Options = code128EncodingOptions;
							bitmap = barcodeWriter.Write(txt);
						}
						IL_203:;
					}
					catch (Exception ex)
					{
					}
					ZXingBarCode.ToImage(bitmap, forecolor, bkcolor);
					result = bitmap;
				}
			}
			return result;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000CA5C4 File Offset: 0x000C87C4
		private static void ToImage(Bitmap myimage, Color forecolor, Color bkcolor)
		{
			checked
			{
				if (myimage != null)
				{
					int width = myimage.Width;
					int height = myimage.Height;
					int num = Color.Black.ToArgb();
					int num2 = Color.White.ToArgb();
					if (!(forecolor.ToArgb() == num & (bkcolor.ToArgb() == num2 | bkcolor.ToArgb() == Color.Transparent.ToArgb())))
					{
						int num3 = 0;
						int num4 = width - 1;
						for (int i = num3; i <= num4; i++)
						{
							int num5 = 0;
							int num6 = height - 1;
							for (int j = num5; j <= num6; j++)
							{
								int num7 = myimage.GetPixel(i, j).ToArgb();
								if (num7 == num)
								{
									if (forecolor.ToArgb() != num)
									{
										myimage.SetPixel(i, j, forecolor);
									}
								}
								else if (num7 == num2 && bkcolor.ToArgb() != num2)
								{
									myimage.SetPixel(i, j, bkcolor);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000CA6A8 File Offset: 0x000C88A8
		private static Bitmap FormatBMP(Bitmap bmp, int margin)
		{
			checked
			{
				Bitmap result;
				if (bmp == null)
				{
					result = null;
				}
				else
				{
					int width = bmp.Width;
					int height = bmp.Height;
					int num = -1;
					int num2 = -1;
					int num3 = -1;
					int num4 = -1;
					int num5 = 0;
					int num6 = height - 1;
					for (int i = num5; i <= num6; i++)
					{
						int num7 = 0;
						int num8 = width - 1;
						int j;
						for (j = num7; j <= num8; j++)
						{
							if (bmp.GetPixel(j, i).ToArgb() != Color.White.ToArgb())
							{
								break;
							}
						}
						if (num2 == -1)
						{
							num2 = j;
						}
						else if (num2 > j)
						{
							num2 = j;
						}
					}
					int num9 = 0;
					int num10 = height - 1;
					for (int i = num9; i <= num10; i++)
					{
						int j;
						for (j = width - 1; j >= 0; j += -1)
						{
							if (bmp.GetPixel(j, i).ToArgb() != Color.White.ToArgb())
							{
								break;
							}
						}
						if (num3 == -1)
						{
							num3 = j;
						}
						else if (num3 < j)
						{
							num3 = j;
						}
					}
					int num11 = 0;
					int num12 = width - 1;
					for (int i = num11; i <= num12; i++)
					{
						int num13 = 0;
						int num14 = height - 1;
						int j;
						for (j = num13; j <= num14; j++)
						{
							if (bmp.GetPixel(i, j).ToArgb() != Color.White.ToArgb())
							{
								break;
							}
						}
						if (num == -1)
						{
							num = j;
						}
						else if (num > j)
						{
							num = j;
						}
					}
					int num15 = 0;
					int num16 = width - 1;
					for (int i = num15; i <= num16; i++)
					{
						int j;
						for (j = height - 1; j >= 0; j += -1)
						{
							if (bmp.GetPixel(i, j).ToArgb() != Color.White.ToArgb())
							{
								break;
							}
						}
						if (num4 == -1)
						{
							num4 = j;
						}
						else if (num4 < j)
						{
							num4 = j;
						}
					}
					if (num2 > margin)
					{
						num2 -= margin;
					}
					if (num > margin)
					{
						num -= margin;
					}
					if (num4 + margin <= height)
					{
						num4 += margin;
					}
					if (num3 + margin <= width)
					{
						num3 += margin;
					}
					int width2 = num3 - num2 + 1;
					int height2 = num4 - num + 1;
					Bitmap bitmap = new Bitmap(width2, height2, PixelFormat.Format24bppRgb);
					Graphics graphics = Graphics.FromImage(bitmap);
					Graphics graphics2 = graphics;
					Rectangle rectangle = new Rectangle(0, 0, width2, height2);
					Rectangle destRect = rectangle;
					Rectangle srcRect = new Rectangle(num2, num, width - (width - num3) - num2 + 1, height - (height - num4) - num + 1);
					graphics2.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel);
					graphics.Dispose();
					result = bitmap;
				}
				return result;
			}
		}
	}
}
