using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LuoEasyPrint
{
	// Token: 0x0200014E RID: 334
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class LineAttributes
	{
		// Token: 0x06001E1C RID: 7708 RVA: 0x0000A7D8 File Offset: 0x000089D8
		public LineAttributes()
		{
			this._Width = 1;
			this._Color = Color.Black;
			this._EnableTexture = false;
			this._TextureStyle = HatchStyle.Cross;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000F75A0 File Offset: 0x000F57A0
		public LineAttributes(int Width, Color Color, bool EnableTexture, HatchStyle TextureStype)
		{
			this._Width = 1;
			this._Color = Color.Black;
			this._EnableTexture = false;
			this._TextureStyle = HatchStyle.Cross;
			this.Color = Color;
			this.EnableTexture = EnableTexture;
			this.Width = Width;
			this.TextureStyle = this.TextureStyle;
			this.TextureStyle = this.TextureStyle;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000F7600 File Offset: 0x000F5800
		public LineAttributes(int Width, Color Color)
		{
			this._Width = 1;
			this._Color = Color.Black;
			this._EnableTexture = false;
			this._TextureStyle = HatchStyle.Cross;
			this.Color = Color;
			this.Width = Width;
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000F7644 File Offset: 0x000F5844
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0000A800 File Offset: 0x00008A00
		[Category("Chartlet")]
		[Description("线条的粗细")]
		public int Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				this._Width = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000F765C File Offset: 0x000F585C
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0000A809 File Offset: 0x00008A09
		[Description("线条的颜色")]
		[Category("Chartlet")]
		public Color Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				this._Color = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000F7674 File Offset: 0x000F5874
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0000A812 File Offset: 0x00008A12
		[Description("使用纹理线条")]
		[Category("Chartlet")]
		public bool EnableTexture
		{
			get
			{
				return this._EnableTexture;
			}
			set
			{
				this._EnableTexture = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000F7688 File Offset: 0x000F5888
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0000A81B File Offset: 0x00008A1B
		[Category("Chartlet")]
		[Description("纹理线条的纹理类型")]
		public HatchStyle TextureStyle
		{
			get
			{
				return this._TextureStyle;
			}
			set
			{
				this._TextureStyle = value;
			}
		}

		// Token: 0x04000F8B RID: 3979
		private int _Width;

		// Token: 0x04000F8C RID: 3980
		private Color _Color;

		// Token: 0x04000F8D RID: 3981
		private bool _EnableTexture;

		// Token: 0x04000F8E RID: 3982
		private HatchStyle _TextureStyle;
	}
}
