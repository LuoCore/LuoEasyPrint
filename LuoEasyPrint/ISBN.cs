using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000165 RID: 357
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ISBN : BarcodeCommon, IBarcode
	{
		// Token: 0x06001E78 RID: 7800 RVA: 0x0000AA08 File Offset: 0x00008C08
		public ISBN(string input)
		{
			this.Raw_Data = input;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000FD960 File Offset: 0x000FBB60
		private string Encode_ISBN_Bookland()
		{
			if (!barmodule.CheckNumericOnly(this.Raw_Data))
			{
				throw new Exception("EBOOKLANDISBN-1: 本形条码只允许有数字标识");
			}
			string left = "UNKNOWN";
			if (this.Raw_Data.Length == 10 | this.Raw_Data.Length == 9)
			{
				if (this.Raw_Data.Length == 10)
				{
					this.Raw_Data = this.Raw_Data.Remove(9, 1);
				}
				this.Raw_Data = "978" + this.Raw_Data;
				left = "ISBN";
			}
			else if (this.Raw_Data.Length == 12 & this.Raw_Data.StartsWith("978"))
			{
				left = "BOOKLAND-NOCHECKDIGIT";
			}
			else if (this.Raw_Data.Length == 13 & this.Raw_Data.StartsWith("978"))
			{
				left = "BOOKLAND-CHECKDIGIT";
				this.Raw_Data = this.Raw_Data.Remove(12, 1);
			}
			if (String.Compare(left, "UNKNOWN", false) == 0)
			{
				throw new Exception("EBOOKLANDISBN-2: 输入不正确，必须以 978 开头并且长度必须是 9, 10, 12, 13 个字数字长度");
			}
			EAN13 ean = new EAN13(this.Raw_Data);
			this.Raw_Data = ean.RawData;
			return ean.Encoded_Value;
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000FDA90 File Offset: 0x000FBC90
		public string Encoded_Value
		{
			get
			{
				return this.Encode_ISBN_Bookland();
			}
		}
	}
}
