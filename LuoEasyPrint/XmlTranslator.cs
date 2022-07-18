using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A4 RID: 164
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTranslator : XmlDocument, IDisposable
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000C1ED8 File Offset: 0x000C00D8
		public ArrayList GetErrors
		{
			get
			{
				return this.errors;
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000800C File Offset: 0x0000620C
		public XmlTranslator()
		{
			this.errors = new ArrayList();
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000C1EF0 File Offset: 0x000C00F0
		public XmlTranslator(string xmlText)
		{
			this.errors = new ArrayList();
			try
			{
				xmlText = XmlTranslator.TrimBody(xmlText);
				this.reader = new XmlTextReader(new StringReader("<XmlTranslator_root>" + xmlText + "</XmlTranslator_root>"));
				this.reader.WhitespaceHandling = WhitespaceHandling.All;
				this.Load(this.reader);
			}
			catch (Exception ex)
			{
				this.errors.Add("创建DOM出错. " + ex.Message);
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000C1F8C File Offset: 0x000C018C
		public static string TrimBody(string xmlText)
		{
			string text = xmlText.ToLower();
			int num = text.IndexOf("<body");
			if (num > 0)
			{
				xmlText = xmlText.Substring(num);
			}
			text = xmlText.ToLower();
			int num2 = checked(text.LastIndexOf("</body>") + 7);
			if (num2 > 7)
			{
				xmlText = xmlText.Substring(0, num2);
			}
			return xmlText;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000C1FE0 File Offset: 0x000C01E0
		public RtfDocument ToRtfDocument()
		{
			this.rtfDocument = new RtfDocument();
			try
			{
				try
				{
					foreach (object obj in this.DocumentElement.ChildNodes)
					{
						XmlNode x = (XmlNode)obj;
						this.rtfDocument.AppendText("{\\pard\\lang2052 ");
						this.TranslateXmlNodeIntoRtfGroup(x, 3);
						this.rtfDocument.AppendText("}");
					}
				}
				finally
				{
					
				}
			}
			catch (Exception ex)
			{
				this.errors.Add("Error during translation. " + ex.Message);
			}
			return this.rtfDocument;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000C20B0 File Offset: 0x000C02B0
		public static string GetMyString(string tt)
		{
			checked
			{
				string result;
				if (String.Compare(tt, "", false) == 0)
				{
					result = "";
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder("");
					int num = 0;
					int num2 = tt.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						string text = Strings.Mid(tt, i + 1, 1);
						string text2;
						if (Strings.Asc(text) < 0)
						{
							text = Conversion.Hex(Strings.Asc(text) + 65536).ToLower();
							text2 = "\\'" + Strings.Left(text, 2);
							text2 = text2 + "\\'" + Strings.Right(text, 2);
						}
						else
						{
							text2 = text;
						}
						stringBuilder.Append(text2);
					}
					result = stringBuilder.ToString();
				}
				return result;
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000C2164 File Offset: 0x000C0364
		public void TranslateXmlNodeIntoRtfGroup(XmlNode x, int baseFontSize)
		{
			checked
			{
				if (x != null)
				{
					if (String.Compare(x.Name.ToLower().ToLower(), "#text", false) == 0)
					{
						this.rtfDocument.AppendText("{" + XmlTranslator.GetMyString(x.InnerText) + "}");
					}
					else
					{
						bool flag = true;
						this.rtfDocument.AppendText("{");
						if (String.Compare(x.Name.ToLower(), "body", false) == 0)
						{
							try
							{
								foreach (object obj in x.Attributes)
								{
									XmlAttribute xmlAttribute = (XmlAttribute)obj;
									if (String.Compare(xmlAttribute.Name.ToLower(), "text", false) == 0)
									{
										int value = this.rtfDocument.UseColor(this.TranslateXhtmlColorIntoColorFromArgb(xmlAttribute.Value));
										this.rtfDocument.AppendText("\\cf" + Conversions.ToString(value) + " ");
									}
								}
								goto IL_8B6;
							}
							finally
							{
								
							}
						}
						if (String.Compare(x.Name.ToLower(), "br", false) == 0)
						{
							this.rtfDocument.AppendText("{\\par}");
						}
						else if (String.Compare(x.Name.ToLower(), "h1", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs48\\par ");
							baseFontSize = 6;
						}
						else if (String.Compare(x.Name.ToLower(), "h2", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs36\\par ");
							baseFontSize = 5;
						}
						else if (String.Compare(x.Name.ToLower(), "h3", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs27\\par ");
							baseFontSize = 4;
						}
						else if (String.Compare(x.Name.ToLower(), "h4", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs24\\par ");
							baseFontSize = 3;
						}
						else if (String.Compare(x.Name.ToLower(), "h5", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs20\\par ");
							baseFontSize = 2;
						}
						else if (String.Compare(x.Name.ToLower(), "h6", false) == 0)
						{
							this.rtfDocument.AppendText("\\b\\fs15\\par ");
							baseFontSize = 1;
						}
						else if (String.Compare(x.Name.ToLower(), "b", false) == 0 | String.Compare(x.Name.ToLower(), "strong", false) == 0)
						{
							this.rtfDocument.AppendText("\\b ");
						}
						else if (String.Compare(x.Name.ToLower(), "i", false) == 0 | String.Compare(x.Name.ToLower(), "em", false) == 0 | String.Compare(x.Name.ToLower(), "cite", false) == 0 | String.Compare(x.Name.ToLower(), "dfn", false) == 0 | String.Compare(x.Name.ToLower(), "var", false) == 0)
						{
							this.rtfDocument.AppendText("\\i ");
						}
						else if (String.Compare(x.Name.ToLower(), "u", false) == 0)
						{
							this.rtfDocument.AppendText("\\ul ");
						}
						else if (String.Compare(x.Name.ToLower(), "s", false) == 0 | String.Compare(x.Name.ToLower(), "strike", false) == 0)
						{
							this.rtfDocument.AppendText("\\strike ");
						}
						else if (String.Compare(x.Name.ToLower(), "tt", false) == 0 | String.Compare(x.Name.ToLower(), "pre", false) == 0 | String.Compare(x.Name.ToLower(), "code", false) == 0 | String.Compare(x.Name.ToLower(), "samp", false) == 0)
						{
							int value2 = this.rtfDocument.UseFont("Courier New");
							this.rtfDocument.AppendText("\\f" + Conversions.ToString(value2) + "\\fs20 ");
							baseFontSize = 2;
						}
						else if (String.Compare(x.Name.ToLower(), "big", false) == 0)
						{
							baseFontSize++;
							this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)) + " ");
						}
						else if (String.Compare(x.Name.ToLower(), "small", false) == 0)
						{
							baseFontSize--;
							this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)) + " ");
						}
						else if (String.Compare(x.Name.ToLower(), "a", false) == 0)
						{
							int value3 = this.rtfDocument.UseColor(Color.FromArgb(0, 0, 255));
							this.rtfDocument.AppendText("\\cf" + Conversions.ToString(value3) + "\\ul ");
						}
						else if (String.Compare(x.Name.ToLower(), "ul", false) == 0)
						{
							this.rtfDocument.AppendText("\\pn\\pnlvlblt ");
						}
						else if (String.Compare(x.Name.ToLower(), "li", false) == 0)
						{
							this.rtfDocument.AppendText("\\pnlvlcont\\par\\pnlvlblt ");
						}
						else
						{
							if (String.Compare(x.Name.ToLower(), "basefont", false) == 0)
							{
								try
								{
									foreach (object obj2 in x.Attributes)
									{
										XmlAttribute xmlAttribute2 = (XmlAttribute)obj2;
										if (String.Compare(xmlAttribute2.Name.ToLower(), "size", false) == 0)
										{
											baseFontSize = int.Parse(xmlAttribute2.Value);
											this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)));
										}
									}
									goto IL_8B6;
								}
								finally
								{
									
								}
							}
							if (String.Compare(x.Name.ToLower(), "font", false) == 0)
							{
								try
								{
									foreach (object obj3 in x.Attributes)
									{
										XmlAttribute xmlAttribute3 = (XmlAttribute)obj3;
										if (String.Compare(xmlAttribute3.Name.ToLower(), "face", false) == 0)
										{
											int num = xmlAttribute3.Value.IndexOf(",");
											int value4;
											if (num > 0)
											{
												value4 = this.rtfDocument.UseFont(xmlAttribute3.Value.Substring(0, num));
											}
											else
											{
												value4 = this.rtfDocument.UseFont(xmlAttribute3.Value);
											}
											this.rtfDocument.AppendText("\\f" + Conversions.ToString(value4) + " ");
										}
										else if (String.Compare(xmlAttribute3.Name.ToLower(), "size", false) == 0)
										{
											if (xmlAttribute3.Value.StartsWith("+"))
											{
												baseFontSize += int.Parse(xmlAttribute3.Value);
												this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)) + " ");
											}
											else if (xmlAttribute3.Value.StartsWith("-"))
											{
												baseFontSize -= int.Parse(xmlAttribute3.Value);
												this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)) + " ");
											}
											else
											{
												baseFontSize = int.Parse(xmlAttribute3.Value);
												this.rtfDocument.AppendText("\\fs" + Conversions.ToString(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize)) + " ");
											}
										}
										else if (String.Compare(xmlAttribute3.Name.ToLower(), "color", false) == 0)
										{
											int value5 = this.rtfDocument.UseColor(this.TranslateXhtmlColorIntoColorFromArgb(xmlAttribute3.Value));
											this.rtfDocument.AppendText("\\cf" + Conversions.ToString(value5) + " ");
										}
									}
									goto IL_8B6;
								}
								finally
								{
									
								}
							}
							if (String.Compare(x.Name.ToLower(), "head", false) == 0 | String.Compare(x.Name.ToLower(), "#comment", false) == 0)
							{
								flag = false;
							}
						}
						IL_8B6:
						if (flag)
						{
							try
							{
								foreach (object obj4 in x.Attributes)
								{
									XmlAttribute xmlAttribute4 = (XmlAttribute)obj4;
									if (String.Compare(xmlAttribute4.Name.ToLower(), "style", false) == 0)
									{
										char[] separator = new char[]
										{
											';'
										};
										string[] array = xmlAttribute4.Value.Split(separator);
										int num2 = 0;
										int num3 = array.Length - 1;
										for (int i = num2; i <= num3; i++)
										{
											char[] separator2 = new char[]
											{
												':'
											};
											string[] array2 = array[i].Split(separator2);
											if (String.Compare(array2[0].ToLower().Trim(), "font-family", false) == 0)
											{
												int num4 = array2[1].Trim().IndexOf(",");
												if (num4 > 0)
												{
													int value6 = this.rtfDocument.UseFont(array2[1].Substring(0, num4).Trim());
												}
												else
												{
													int value6 = this.rtfDocument.UseFont(array2[1].Trim());
													this.rtfDocument.AppendText("\\f" + Conversions.ToString(value6) + " ");
												}
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "font-size", false) == 0)
											{
												int num5 = this.TranslateStyleFontSizeIntoRtfFontSize(array2[1].Trim(), baseFontSize);
												baseFontSize = XmlTranslator.TranslateRtfFontSizeIntoXhtmlFontSize(num5);
												this.rtfDocument.AppendText("\\fs" + Conversions.ToString(num5) + " ");
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "font-style", false) == 0)
											{
												if (String.Compare(array2[1].ToLower().Trim(), "normal", false) == 0)
												{
													this.rtfDocument.AppendText("\\i0 ");
												}
												else if (String.Compare(array2[1].ToLower().Trim(), "italic", false) == 0 | String.Compare(array2[1].ToLower().Trim(), "oblique", false) == 0)
												{
													this.rtfDocument.AppendText("\\i ");
												}
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "font-weight", false) == 0)
											{
												if (String.Compare(array2[1].ToLower().Trim(), "normal", false) == 0 | String.Compare(array2[1].ToLower().Trim(), "lighter", false) == 0)
												{
													this.rtfDocument.AppendText("\\b0 ");
												}
												else
												{
													this.rtfDocument.AppendText("\\b ");
												}
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "text-align", false) == 0)
											{
												if (String.Compare(array2[1].ToLower().Trim(), "right", false) == 0)
												{
													this.rtfDocument.AppendText("\\qr ");
												}
												else if (String.Compare(array2[1].ToLower().Trim(), "center", false) == 0)
												{
													this.rtfDocument.AppendText("\\qc ");
												}
												else if (String.Compare(array2[1].ToLower().Trim(), "justify", false) == 0)
												{
													this.rtfDocument.AppendText("\\qj ");
												}
												else
												{
													this.rtfDocument.AppendText("\\ql ");
												}
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "text-decoration", false) == 0)
											{
												if (String.Compare(array2[1].ToLower().Trim(), "none", false) == 0)
												{
													this.rtfDocument.AppendText("\\ul0\\strike0 ");
												}
												else if (String.Compare(array2[1].ToLower().Trim(), "underline", false) == 0)
												{
													this.rtfDocument.AppendText("\\ul ");
												}
												else if (String.Compare(array2[1].ToLower().Trim(), "line-through", false) == 0)
												{
													this.rtfDocument.AppendText("\\strike ");
												}
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "color", false) == 0)
											{
												int value7 = this.rtfDocument.UseColor(this.TranslateXhtmlColorIntoColorFromArgb(array2[1].ToLower().Trim()));
												this.rtfDocument.AppendText("\\cf" + Conversions.ToString(value7) + " ");
											}
											else if (String.Compare(array2[0].ToLower().Trim(), "line-height", false) == 0)
											{
												int num6 = this.TranslateStyleFontSizeIntoRtfFontSize(array2[1].Trim(), baseFontSize);
												this.rtfDocument.AppendText("\\sl" + Conversions.ToString(10 * num6) + "\\slmult1 ");
											}
										}
									}
								}
							}
							finally
							{
								
							}
							try
							{
								foreach (object obj5 in x.ChildNodes)
								{
									XmlNode x2 = (XmlNode)obj5;
									this.TranslateXmlNodeIntoRtfGroup(x2, baseFontSize);
								}
							}
							finally
							{
								
							}
						}
						if (String.Compare(x.Name.ToLower(), "p", false) == 0)
						{
							try
							{
								foreach (object obj6 in x.Attributes)
								{
									XmlAttribute xmlAttribute5 = (XmlAttribute)obj6;
									if (String.Compare(xmlAttribute5.Name.ToLower(), "align", false) == 0)
									{
										if (String.Compare(xmlAttribute5.Value, "right", false) == 0)
										{
											this.rtfDocument.AppendText("\\qr ");
										}
										else if (String.Compare(xmlAttribute5.Value, "center", false) == 0)
										{
											this.rtfDocument.AppendText("\\qc ");
										}
										else if (String.Compare(xmlAttribute5.Value, "justify", false) == 0)
										{
											this.rtfDocument.AppendText("\\qj ");
										}
										else
										{
											this.rtfDocument.AppendText("\\ql ");
										}
									}
								}
							}
							finally
							{
								
							}
							this.rtfDocument.AppendText("\\par");
						}
						else if (String.Compare(x.Name.ToLower(), "h1", false) == 0 | String.Compare(x.Name.ToLower(), "h2", false) == 0 | String.Compare(x.Name.ToLower(), "h3", false) == 0 | String.Compare(x.Name.ToLower(), "h4", false) == 0 | String.Compare(x.Name.ToLower(), "h5", false) == 0 | String.Compare(x.Name.ToLower(), "h6", false) == 0)
						{
							this.rtfDocument.AppendText("\\par");
						}
						this.rtfDocument.AppendText("}");
						if (String.Compare(x.Name.ToLower(), "ul", false) == 0)
						{
							this.rtfDocument.AppendText("\\pard");
						}
					}
				}
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000C320C File Offset: 0x000C140C
		private int TranslateXhtmlFontSizeIntoRtfFontSize(int xhtmlFontSize)
		{
			int result;
			switch (xhtmlFontSize)
			{
			case 1:
				result = 15;
				break;
			case 2:
				result = 20;
				break;
			case 3:
				result = 24;
				break;
			case 4:
				result = 27;
				break;
			case 5:
				result = 36;
				break;
			case 6:
				result = 48;
				break;
			case 7:
				result = 72;
				break;
			default:
				this.errors.Add("不能识别的 XHTML 字体大小。设置为默认值12 pt.");
				result = 24;
				break;
			}
			return result;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000C3278 File Offset: 0x000C1478
		private static int TranslateRtfFontSizeIntoXhtmlFontSize(int rtfFontSize)
		{
			int result;
			if (rtfFontSize <= 15)
			{
				result = 1;
			}
			else if (rtfFontSize <= 20)
			{
				result = 2;
			}
			else if (rtfFontSize <= 24)
			{
				result = 3;
			}
			else if (rtfFontSize <= 27)
			{
				result = 4;
			}
			else if (rtfFontSize <= 36)
			{
				result = 5;
			}
			else if (rtfFontSize <= 48)
			{
				result = 6;
			}
			else
			{
				result = 7;
			}
			return result;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000C32C0 File Offset: 0x000C14C0
		private int TranslateStyleFontSizeIntoRtfFontSize(string styleFontSize, int baseFontSize)
		{
			int result;
			if (String.Compare(styleFontSize.ToLower(), "xx-small", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(1);
			}
			else if (String.Compare(styleFontSize.ToLower(), "x-small", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(2);
			}
			else if (String.Compare(styleFontSize.ToLower(), "small", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(3);
			}
			else if (String.Compare(styleFontSize.ToLower(), "medium", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(4);
			}
			else if (String.Compare(styleFontSize.ToLower(), "large", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(5);
			}
			else if (String.Compare(styleFontSize.ToLower(), "x-large", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(6);
			}
			else if (String.Compare(styleFontSize.ToLower(), "xx-large", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(7);
			}
			else if (String.Compare(styleFontSize.ToLower(), "smaller", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(checked(baseFontSize - 1));
			}
			else if (String.Compare(styleFontSize.ToLower(), "bigger", false) == 0)
			{
				result = this.TranslateXhtmlFontSizeIntoRtfFontSize(checked(baseFontSize + 1));
			}
			else
			{
				try
				{
					if (styleFontSize.ToLower().EndsWith("%"))
					{
						result = Convert.ToInt32((double)(checked(this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize) * int.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("%"))))) / 100.0);
					}
					else if (styleFontSize.ToLower().EndsWith("em"))
					{
						result = Convert.ToInt32((double)this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize) * double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("em"))));
					}
					else if (styleFontSize.ToLower().EndsWith("ex"))
					{
						result = Convert.ToInt32((double)this.TranslateXhtmlFontSizeIntoRtfFontSize(baseFontSize) / 2.0 * double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("ex"))));
					}
					else if (styleFontSize.ToLower().EndsWith("pt"))
					{
						result = Convert.ToInt32(2.0 * double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("pt"))));
					}
					else if (styleFontSize.ToLower().EndsWith("in"))
					{
						Font font = new Font("", Convert.ToSingle(new decimal(double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("in"))))), GraphicsUnit.Inch);
						result = Convert.ToInt32(2.0 * (double)font.SizeInPoints);
					}
					else if (styleFontSize.ToLower().EndsWith("cm"))
					{
						Font font = new Font("", Convert.ToSingle(new decimal(double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("cm"))) / 10.0)), GraphicsUnit.Millimeter);
						result = Convert.ToInt32(2.0 * (double)font.SizeInPoints);
					}
					else if (styleFontSize.ToLower().EndsWith("mm"))
					{
						Font font = new Font("", Convert.ToSingle(new decimal(double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("mm"))))), GraphicsUnit.Millimeter);
						result = Convert.ToInt32(2.0 * (double)font.SizeInPoints);
					}
					else if (styleFontSize.ToLower().EndsWith("pc"))
					{
						Font font = new Font("", Convert.ToSingle(new decimal(double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("pc"))) * 12.0)), GraphicsUnit.Point);
						result = Convert.ToInt32(2.0 * (double)font.SizeInPoints);
					}
					else if (styleFontSize.ToLower().EndsWith("px"))
					{
						Font font = new Font("", Convert.ToSingle(new decimal(double.Parse(styleFontSize.Substring(0, styleFontSize.ToLower().IndexOf("px"))))), GraphicsUnit.Pixel);
						result = Convert.ToInt32(2.0 * (double)font.SizeInPoints);
					}
					else
					{
						this.errors.Add("不合法的字号单位，设置为默认的 12 pt.");
						result = 24;
					}
				}
				catch (Exception ex)
				{
					this.errors.Add("不合法的字号，设置为默认的 12 pt.");
					result = 24;
				}
			}
			return result;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000C3760 File Offset: 0x000C1960
		private Color TranslateXhtmlColorIntoColorFromArgb(string xhtmlColor)
		{
			xhtmlColor = xhtmlColor.ToLower();
			Color result;
			if (String.Compare(xhtmlColor, "black", false) == 0)
			{
				result = Color.FromArgb(0, 0, 0);
			}
			else if (String.Compare(xhtmlColor, "silver", false) == 0)
			{
				result = Color.FromArgb(192, 192, 192);
			}
			else if (String.Compare(xhtmlColor, "gray", false) == 0)
			{
				result = Color.FromArgb(128, 128, 128);
			}
			else if (String.Compare(xhtmlColor, "white", false) == 0)
			{
				result = Color.FromArgb(255, 255, 255);
			}
			else if (String.Compare(xhtmlColor, "maroon", false) == 0)
			{
				result = Color.FromArgb(128, 0, 0);
			}
			else if (String.Compare(xhtmlColor, "red", false) == 0)
			{
				result = Color.FromArgb(255, 0, 0);
			}
			else if (String.Compare(xhtmlColor, "purple", false) == 0)
			{
				result = Color.FromArgb(128, 0, 128);
			}
			else if (String.Compare(xhtmlColor, "fuchsia", false) == 0)
			{
				result = Color.FromArgb(255, 0, 255);
			}
			else if (String.Compare(xhtmlColor, "green", false) == 0)
			{
				result = Color.FromArgb(0, 128, 0);
			}
			else if (String.Compare(xhtmlColor, "lime", false) == 0)
			{
				result = Color.FromArgb(0, 255, 0);
			}
			else if (String.Compare(xhtmlColor, "olive", false) == 0)
			{
				result = Color.FromArgb(128, 128, 0);
			}
			else if (String.Compare(xhtmlColor, "yellow", false) == 0)
			{
				result = Color.FromArgb(255, 255, 0);
			}
			else if (String.Compare(xhtmlColor, "navy", false) == 0)
			{
				result = Color.FromArgb(0, 0, 128);
			}
			else if (String.Compare(xhtmlColor, "blue", false) == 0)
			{
				result = Color.FromArgb(0, 0, 255);
			}
			else if (String.Compare(xhtmlColor, "teal", false) == 0)
			{
				result = Color.FromArgb(0, 128, 128);
			}
			else if (String.Compare(xhtmlColor, "aqua", false) == 0)
			{
				result = Color.FromArgb(0, 255, 255);
			}
			else
			{
				if (xhtmlColor.StartsWith("#"))
				{
					try
					{
						int num = int.Parse(xhtmlColor.Substring(1), NumberStyles.HexNumber);
						int red = Convert.ToInt32((double)(num & 16711680) / 65536.0);
						int green = Convert.ToInt32((double)(num & 65280) / 256.0);
						int blue = Convert.ToInt32(num & 255);
						return Color.FromArgb(red, green, blue);
					}
					catch (Exception ex)
					{
						this.errors.Add("Invalid color value. Defaulting to black.");
						return Color.FromArgb(0, 0, 0);
					}
				}
				if (xhtmlColor.StartsWith("rgb"))
				{
					try
					{
						string[] array = xhtmlColor.Split(new char[]
						{
							' '
						});
						int num2 = 1;
						byte red2;
						byte green2;
						checked
						{
							while (String.Compare(array[num2], "", false) == 0)
							{
								num2++;
							}
							red2 = Convert.ToByte(unchecked(double.Parse(array[num2].Trim()) * 255.0));
							num2++;
							while (String.Compare(array[num2], "", false) == 0)
							{
								num2++;
							}
							green2 = Convert.ToByte(unchecked(double.Parse(array[num2].Trim()) * 255.0));
							num2++;
							while (String.Compare(array[num2], "", false) == 0)
							{
								num2++;
							}
						}
						byte blue2 = Convert.ToByte(double.Parse(array[num2].Trim()) * 255.0);
						return Color.FromArgb((int)red2, (int)green2, (int)blue2);
					}
					catch (Exception ex2)
					{
						this.errors.Add("Invalid color value. Defaulting to black.");
						return Color.FromArgb(0, 0, 0);
					}
				}
				this.errors.Add("Invalid color format. Defaulting to black.");
				result = Color.FromArgb(0, 0, 0);
			}
			return result;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000C3BA4 File Offset: 0x000C1DA4
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					try
					{
						this.rtfDocument.Dispose();
						this.errors.Clear();
						this.errors = null;
						this.reader = null;
					}
					catch (Exception ex)
					{
					}
				}
				try
				{
					this.reader.Close();
					this.reader = null;
				}
				catch (Exception ex2)
				{
				}
			}
			this.disposedValue = true;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0000801F File Offset: 0x0000621F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000ABF RID: 2751
		private RtfDocument rtfDocument;

		// Token: 0x04000AC0 RID: 2752
		private XmlTextReader reader;

		// Token: 0x04000AC1 RID: 2753
		private ArrayList errors;

		// Token: 0x04000AC2 RID: 2754
		private bool disposedValue;
	}
}
