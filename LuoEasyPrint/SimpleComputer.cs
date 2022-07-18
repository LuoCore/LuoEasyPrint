using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000019 RID: 25
	[StandardModule]
	internal sealed class SimpleComputer
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x00036FA0 File Offset: 0x000351A0
		private static string BuildingRPN(string s)
		{
			StringBuilder stringBuilder = new StringBuilder(s);
			Stack stack = new Stack();
			StringBuilder stringBuilder2 = new StringBuilder();
			int num = 0;
			checked
			{
				int num2 = stringBuilder.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					char c = stringBuilder[i];
					if (char.IsDigit(c))
					{
						stringBuilder2.Append(c);
					}
					else
					{
						char c2 = c;
						if (c2 != '+')
						{
							if (c2 != '-')
							{
								if (c2 != '*')
								{
									if (c2 != '/')
									{
										if (c2 != '(')
										{
											if (c2 != ')')
											{
												if (c2 != '.')
												{
													if (c2 != '^')
													{
														if (c2 == ' ')
														{
															goto IL_95;
														}
														return "";
													}
												}
											}
										}
									}
								}
							}
						}
						stringBuilder2.Append(c);
					}
					IL_95:;
				}
				stringBuilder = new StringBuilder(stringBuilder2.ToString());
				int num3 = 0;
				int num4 = stringBuilder.Length - 1;
				for (int j = num3; j <= num4; j++)
				{
					if (String.Compare(Convert.ToString(stringBuilder[j]), "-", false) == 0)
					{
						if (j == 0)
						{
							stringBuilder[j] = '!';
						}
						else if (String.Compare(Convert.ToString(stringBuilder[j - 1]), "(", false) == 0)
						{
							stringBuilder[j] = '!';
						}
					}
				}
				stringBuilder2 = new StringBuilder();
				int num5 = 0;
				int num6 = stringBuilder.Length - 1;
				for (int k = num5; k <= num6; k++)
				{
					if (char.IsDigit(stringBuilder[k]) | String.Compare(Convert.ToString(stringBuilder[k]), ".", false) == 0)
					{
						stringBuilder2.Append(stringBuilder[k]);
					}
					else
					{
						if (String.Compare(Convert.ToString(stringBuilder[k]), "+", false) == 0 | String.Compare(Convert.ToString(stringBuilder[k]), "-", false) == 0 | String.Compare(Convert.ToString(stringBuilder[k]), "*", false) == 0 | String.Compare(Convert.ToString(stringBuilder[k]), "/", false) == 0 | String.Compare(Convert.ToString(stringBuilder[k]), "^", false) == 0 | String.Compare(Convert.ToString(stringBuilder[k]), "!", false) == 0)
						{
							while (stack.Count > 0)
							{
								char c = Convert.ToChar(stack.Pop());
								if (String.Compare(Convert.ToString(c), "(", false) == 0)
								{
									stack.Push(c);
								}
								else
								{
									if (SimpleComputer.Power(c) >= SimpleComputer.Power(stringBuilder[k]))
									{
										stringBuilder2.Append(" ");
										stringBuilder2.Append(c);
										continue;
									}
									stack.Push(c);
								}
								IL_294:
								stack.Push(stringBuilder[k]);
								stringBuilder2.Append(" ");
								goto IL_367;
							}
						
						}
						if (String.Compare(Convert.ToString(stringBuilder[k]), "(", false) == 0)
						{
							stack.Push("(");
							stringBuilder2.Append(" ");
						}
						else if (String.Compare(Convert.ToString(stringBuilder[k]), ")", false) == 0)
						{
							while (stack.Count > 0)
							{
								char c = Convert.ToChar(stack.Pop());
								if (String.Compare(Convert.ToString(c), "(", false) == 0)
								{
									break;
								}
								stringBuilder2.Append(" ");
								stringBuilder2.Append(c);
								stringBuilder2.Append(" ");
							}
						}
						else
						{
							stringBuilder2.Append(stringBuilder[k]);
						}
					}
					IL_367:;
				}
				while (stack.Count > 0)
				{
					stringBuilder2.Append(" ");
					stringBuilder2.Append(RuntimeHelpers.GetObjectValue(stack.Pop()));
				}
				stringBuilder2.Append(" ");
				return SimpleComputer.FormatSpace(stringBuilder2.ToString());
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00037370 File Offset: 0x00035570
		public static string ComputeSimple(string ss)
		{
			string text = SimpleComputer.BuildingRPN(ss);
			checked
			{
				string result;
				if (String.Compare(Strings.Trim(text), "", false) == 0)
				{
					result = "";
				}
				else if (!SimpleComputer.IsValidate(ss))
				{
					result = "";
				}
				else
				{
					Stack stack = new Stack();
					StringBuilder stringBuilder = new StringBuilder();
					int num = 0;
					int num2 = text.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						char c = text[i];
						unchecked
						{
							if (char.IsDigit(c) | String.Compare(Convert.ToString(c), ".", false) == 0)
							{
								stringBuilder.Append(c);
							}
							else if (String.Compare(Convert.ToString(c), " ", false) == 0 & stringBuilder.Length > 0)
							{
								try
								{
									string text2 = stringBuilder.ToString();
									if (text2.StartsWith("-"))
									{
										stack.Push(-Convert.ToDouble(text2.Substring(1, checked(text2.Length - 1))));
									}
									else
									{
										stack.Push(Convert.ToDouble(text2));
									}
								}
								catch (Exception ex)
								{
									return "";
								}
								stringBuilder = new StringBuilder();
							}
							else
							{
								if (String.Compare(Convert.ToString(c), "+", false) == 0 | String.Compare(Convert.ToString(c), "-", false) == 0 | String.Compare(Convert.ToString(c), "*", false) == 0 | String.Compare(Convert.ToString(c), "/", false) == 0 | String.Compare(Convert.ToString(c), "^", false) == 0)
								{
									if (stack.Count <= 0)
									{
										stack.Push(0);
										break;
									}
									double num3 = Convert.ToDouble(stack.Pop());
									if (stack.Count <= 0)
									{
										stack.Push(num3);
										break;
									}
									double num4 = Convert.ToDouble(stack.Pop());
									char c2 = c;
									if (c2 == '+')
									{
										stack.Push(num4 + num3);
										goto IL_2CD;
									}
									if (c2 == '-')
									{
										stack.Push(num4 - num3);
										goto IL_2CD;
									}
									if (c2 == '*')
									{
										stack.Push(num4 * num3);
										goto IL_2CD;
									}
									if (c2 == '/')
									{
										try
										{
											stack.Push(num4 / num3);
											goto IL_2CD;
										}
										catch (Exception ex2)
										{
											return "";
										}
									}
									if (c2 != '^')
									{
										goto IL_2CD;
									}
									try
									{
										stack.Push(Math.Pow(num4, num3));
										goto IL_2CD;
									}
									catch (Exception ex3)
									{
										return "";
									}
								}
								if (String.Compare(Convert.ToString(c), "!", false) == 0)
								{
									stack.Push(-Convert.ToDouble(stack.Pop()));
								}
							}
							IL_2CD:;
						}
					}
					if (stack.Count > 1)
					{
						result = "";
					}
					else if (stack.Count == 0)
					{
						result = "";
					}
					else
					{
						result = stack.Pop().ToString();
					}
				}
				return result;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000376CC File Offset: 0x000358CC
		private static string FormatSpace(string s)
		{
			while (Strings.InStr(s, "  ", CompareMethod.Binary) > 0)
			{
				s = Strings.Replace(s, "  ", " ", 1, -1, CompareMethod.Binary);
			}
			return s;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00037704 File Offset: 0x00035904
		private static int Power(char opr)
		{
			if (opr != '+')
			{
				if (opr != '-')
				{
					if (opr != '*')
					{
						if (opr != '/')
						{
							if (opr != '^')
							{
								if (opr != '!')
								{
									return 0;
								}
							}
							return 3;
						}
					}
					return 2;
				}
			}
			return 1;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00037748 File Offset: 0x00035948
		private static bool IsValidate(string ss)
		{
			checked
			{
				bool result;
				if (String.Compare(ss, "", false) == 0)
				{
					result = false;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					bool flag = false;
					int num3 = 0;
					int num4 = ss.Length - 1;
					int i = num3;
					while (i <= num4)
					{
						string text = Strings.Mid(ss, i + 1, 1);
						string left = text;
						if (String.Compare(left, "+", false) == 0)
						{
							goto IL_B9;
						}
						if (String.Compare(left, "-", false) == 0)
						{
							goto IL_B9;
						}
						if (String.Compare(left, "*", false) == 0)
						{
							goto IL_B9;
						}
						if (String.Compare(left, "/", false) == 0)
						{
							goto IL_B9;
						}
						if (String.Compare(left, "(", false) == 0)
						{
							num++;
							flag = false;
						}
						else if (String.Compare(left, ")", false) == 0)
						{
							num2++;
							flag = false;
						}
						else
						{
							flag = false;
						}
						IL_BE:
						i++;
						continue;
						IL_B9:
						if (!flag)
						{
							flag = true;
							goto IL_BE;
						}
						return false;
					}
					result = (num == num2);
				}
				return result;
			}
		}
	}
}
