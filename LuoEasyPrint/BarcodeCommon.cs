using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x0200015A RID: 346
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class BarcodeCommon
	{
		// Token: 0x06001E4D RID: 7757 RVA: 0x0000A968 File Offset: 0x00008B68
		protected BarcodeCommon()
		{
			this.Raw_Data = "";
			this.Formatted_Data = "";
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x000F7BA0 File Offset: 0x000F5DA0
		public string RawData
		{
			get
			{
				return this.Raw_Data;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x000F7BB8 File Offset: 0x000F5DB8
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0000A986 File Offset: 0x00008B86
		public string FormattedData
		{
			get
			{
				return this.Formatted_Data;
			}
			set
			{
				this.Formatted_Data = value;
			}
		}

		// Token: 0x0400105C RID: 4188
		protected string Raw_Data;

		// Token: 0x0400105D RID: 4189
		protected string Formatted_Data;
	}
}
