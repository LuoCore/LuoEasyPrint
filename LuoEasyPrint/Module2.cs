using System;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000159 RID: 345
	[StandardModule]
	internal sealed class Module2
	{
		// Token: 0x06001E49 RID: 7753 RVA: 0x000F7A04 File Offset: 0x000F5C04
		public static string SaveArrayAsString2(string[] pp)
		{
			string str = "\b\u0002";
			checked
			{
				string result;
				if (pp == null)
				{
					result = "";
				}
				else if (pp.Length <= 0)
				{
					result = "";
				}
				else
				{
					string text = pp[0];
					int num = 1;
					int num2 = pp.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = text + str + pp[i];
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000F7A5C File Offset: 0x000F5C5C
		public static string[] RestoreArrayFromString2(string ss)
		{
			string delimiter = "\b\u0002";
			checked
			{
				string[] result;
				if (String.Compare(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					string[] array = Strings.Split(ss, delimiter, -1, CompareMethod.Binary);
					string[] array2 = new string[array.Length - 1 + 1];
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						array2[i] = array[i];
					}
					result = array2;
				}
				return result;
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000F7ABC File Offset: 0x000F5CBC
		public static string SaveArrayAsString3(Color[] pp)
		{
			string str = "\b\u0002";
			checked
			{
				string result;
				if (pp == null)
				{
					result = "";
				}
				else if (pp.Length <= 0)
				{
					result = "";
				}
				else
				{
					string text = Module1.ConvertColorToString(pp[0]);
					int num = 1;
					int num2 = pp.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						text = text + str + Module1.ConvertColorToString(pp[i]);
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000F7B30 File Offset: 0x000F5D30
		public static Color[] RestoreArrayFromString3(string ss)
		{
			string delimiter = "\b\u0002";
			checked
			{
				Color[] result;
				if (String.Compare(ss, "", false) == 0)
				{
					result = null;
				}
				else
				{
					string[] array = Strings.Split(ss, delimiter, -1, CompareMethod.Binary);
					Color[] array2 = new Color[array.Length - 1 + 1];
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						array2[i] = Module1.ConvertStringToColor(array[i]);
					}
					result = array2;
				}
				return result;
			}
		}
	}
}
