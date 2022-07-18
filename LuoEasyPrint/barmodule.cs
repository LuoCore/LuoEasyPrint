using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200015B RID: 347
	[StandardModule]
	internal sealed class barmodule
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x000F7BD0 File Offset: 0x000F5DD0
		public static bool CheckNumericOnly(string Data)
		{
			int num = 18;
			string text = Data;
			checked
			{
				string[] array = new string[(int)Math.Round(unchecked(Math.Truncate((double)Data.Length / (double)18f) + (double)Conversions.ToInteger(Interaction.IIf(Data.Length % 18 == 0, 0, 1)))) + 1];
				int num2 = 0;
				int num3 = array.Length - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (text.Length >= num)
					{
						array[i] = text.Substring(0, num);
						text = text.Substring(num);
					}
					else
					{
						array[i] = text.Substring(0);
					}
				}
				foreach (string s in array)
				{
					long num4 = 0L;
					if (!long.TryParse(s, out num4))
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}
