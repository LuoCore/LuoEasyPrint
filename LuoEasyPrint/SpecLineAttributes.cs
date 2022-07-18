using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LuoEasyPrint
{
	// Token: 0x0200014F RID: 335
	[EditorBrowsable(EditorBrowsableState.Never)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SpecLineAttributes : LineAttributes
	{
		// Token: 0x06001E27 RID: 7719 RVA: 0x0000A824 File Offset: 0x00008A24
		public SpecLineAttributes()
		{
			this._LowLimit = 0;
			this._HighLimit = 0;
			this._Show = false;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x000F76A0 File Offset: 0x000F58A0
		public SpecLineAttributes(bool Show, int LowLimit, int HighLimit, int Width, Color Color, bool EnableTexture, HatchStyle TextureStype)
		{
			this._LowLimit = 0;
			this._HighLimit = 0;
			this._Show = false;
			this.Color = Color;
			this.EnableTexture = EnableTexture;
			this.Width = Width;
			this.TextureStyle = this.TextureStyle;
			this.Show = Show;
			this.LowLimit = LowLimit;
			this.HighLimit = HighLimit;
			this.TextureStyle = this.TextureStyle;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0000A841 File Offset: 0x00008A41
		public SpecLineAttributes(bool Show, int LowLimit, int HighLimit)
		{
			this._LowLimit = 0;
			this._HighLimit = 0;
			this._Show = false;
			this.Show = Show;
			this.LowLimit = LowLimit;
			this.HighLimit = HighLimit;
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000F7710 File Offset: 0x000F5910
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000A873 File Offset: 0x00008A73
		[Category("Chartlet")]
		[Description("Spec线条的下限")]
		public int LowLimit
		{
			get
			{
				return this._LowLimit;
			}
			set
			{
				this._LowLimit = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000F7728 File Offset: 0x000F5928
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000A87C File Offset: 0x00008A7C
		[Category("Chartlet")]
		[Description("Spec线条的上限")]
		public int HighLimit
		{
			get
			{
				return this._HighLimit;
			}
			set
			{
				this._HighLimit = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000F7740 File Offset: 0x000F5940
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0000A885 File Offset: 0x00008A85
		[Category("Chartlet")]
		[Description("是否显示Spec极限线条")]
		public bool Show
		{
			get
			{
				return this._Show;
			}
			set
			{
				this._Show = value;
			}
		}

		// Token: 0x04000F8F RID: 3983
		private int _LowLimit;

		// Token: 0x04000F90 RID: 3984
		private int _HighLimit;

		// Token: 0x04000F91 RID: 3985
		private bool _Show;
	}
}
