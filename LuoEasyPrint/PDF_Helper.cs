using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LuoEasyPrint.VB2008Print;

namespace LuoEasyPrint
{
    public  static partial class PDF_Helper
    {
		public static bool SaveAsPdf(this VB2008Print print,Document thedocument, int pagenumber)
		{
			bool result;
			try
			{
				if (thedocument == null)
				{
					result = false;
				}
				else if (pagenumber > print.GetPages() | pagenumber <= 0)
				{
					result = false;
				}
				else
				{
					string text = MyProject.Computer.FileSystem.GetTempFileName() + ".png";
					print.SaveAsImage(pagenumber, text);
					print.GetPageAndPaperSettings(pagenumber);
					float num;
					float num2;
					if (print.PageUnits == PageExportUnit.Inch)
					{
						num = print.PaperWidth * 72f / 100f;
						num2 = print.PaperHeight * 72f / 100f;
					}
					else
					{
						num = print.ConvertCmToInch(print.PaperWidth) * 72f / 100f;
						num2 = print.ConvertCmToInch(print.PaperHeight) * 72f / 100f;
					}
                    iTextSharp.text.Rectangle rectangle;
					if (print.PaperLandscape | num > num2)
					{
						rectangle = new iTextSharp.text.Rectangle(0f, 0f, num2, num);
						thedocument.SetMargins(0f, 0f, 0f, 0f);
						thedocument.SetPageSize(rectangle.Rotate());
					}
					else
					{
						rectangle = new iTextSharp.text.Rectangle(0f, 0f, num, num2);
						thedocument.SetMargins(0f, 0f, 0f, 0f);
						thedocument.SetPageSize(rectangle);
					}
					thedocument.NewPage();
                    iTextSharp.text.Image instance = iTextSharp.text.Image.GetInstance(text);
					if (print.PaperLandscape | num > num2)
					{
						instance.ScaleAbsolute(rectangle.Height, rectangle.Width);
					}
					else
					{
						instance.ScaleAbsolute(rectangle.Width, rectangle.Height);
					}
					thedocument.Add(instance);
					MyProject.Computer.FileSystem.DeleteFile(text);
					result = true;
				}
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}
		public static bool SaveAsPdf(this VB2008Print print, string filename, bool onlycurrentpage)
		{
			progressexcel progressexcel = new progressexcel();
			checked
			{
				bool result;
				try
				{
					if (print.GetCurrentPage() <= 0 | print.GetPages() <= 0)
					{
						result = false;
					}
					else
					{
						if (Operators.CompareString(filename, "", false) == 0)
						{
							SaveFileDialog saveFileDialog = new SaveFileDialog();
							saveFileDialog.Title = "请选择要保存的PDF文件名";
							saveFileDialog.Filter = "PDF文件(*.pdf)|*.pdf";
							saveFileDialog.DefaultExt = "pdf";
							saveFileDialog.FileName = Strings.Format(DateAndTime.Today, "yyyy-M-dd");
							if (saveFileDialog.ShowDialog() != DialogResult.OK)
							{
								saveFileDialog.Dispose();
								return false;
							}
							filename = saveFileDialog.FileName;
							saveFileDialog.Dispose();
						}
						Document document = new Document();
						PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
						document.AddAuthor("DotNetPrint");
						document.AddKeywords("YP17804355");
						document.Open();
						if (onlycurrentpage)
						{
							SaveAsPdf(print, document, print.GetCurrentPage());
						}
						else
						{
							Module1.G_CancelExportDGVToExcel = false;
							progressexcel.Text = "保存为PDF文件";
							progressexcel.ProgressBar1.Value = 0;
							progressexcel.ProgressBar1.Maximum = print.GetPages();
							progressexcel.Show(print.ParentForm);
							int num = 1;
							int num2 = print.GetPages();
							for (int i = num; i <= num2; i++)
							{
								if (Module1.G_CancelExportDGVToExcel)
								{
									progressexcel.Dispose();
									progressexcel = null;
									document.Close();
									return false;
								}
								progressexcel.Label1.Text = string.Concat(new string[]
								{
									"正在保存第〖",
									Conversions.ToString(i),
									"〗页，共〖",
									Conversions.ToString(print.GetPages()),
									"〗页，已完成〖",
									Strings.Format((double)(i - 1) / (double)print.GetPages(), "###.##%"),
									"〗"
								});
								Application.DoEvents();
								progressexcel.ProgressBar1.Value = i - 1;
								SaveAsPdf(print, document, i);
							}
							progressexcel.ProgressBar1.Value = print.GetPages();
							progressexcel.Label1.Text = "保存完成，正在做最后处理";
							progressexcel.Dispose();
							progressexcel = null;
						}
						document.Close();
						result = true;
					}
				}
				catch (Exception ex)
				{
					if (progressexcel != null)
					{
						progressexcel.Dispose();
						progressexcel = null;
					}
					result = false;
				}
				return result;
			}
		}
	}
}
