using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LuoEasyPrint
{
	// Token: 0x0200014B RID: 331
	[EditorBrowsable(EditorBrowsableState.Never)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Painting
	{
		// Token: 0x06001DFD RID: 7677 RVA: 0x0000A72B File Offset: 0x0000892B
		public Painting()
		{
			this._ShiftStep = 0;
			this._TextureStyle = HatchStyle.DarkUpwardDiagonal;
			this._TextureEnable = false;
			this._ColorStyle = Chartlet.ColorStyles.None;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000F724C File Offset: 0x000F544C
		public Painting(int ShiftStep, Color Color1, Color Color2, Color Color3, bool TextureEnable, HatchStyle TextureStyle)
		{
			this._ShiftStep = 0;
			this._TextureStyle = HatchStyle.DarkUpwardDiagonal;
			this._TextureEnable = false;
			this._ColorStyle = Chartlet.ColorStyles.None;
			this.ShiftStep = ShiftStep;
			this.Color1 = Color1;
			this.Color2 = Color2;
			this.Color3 = Color3;
			this.TextureEnable = TextureEnable;
			this.TextureStyle = TextureStyle;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000F72AC File Offset: 0x000F54AC
		public Painting(int ShiftStep, Color Color1, Color Color2, Color Color3)
		{
			this._ShiftStep = 0;
			this._TextureStyle = HatchStyle.DarkUpwardDiagonal;
			this._TextureEnable = false;
			this._ColorStyle = Chartlet.ColorStyles.None;
			this.ShiftStep = ShiftStep;
			this.Color1 = Color1;
			this.Color2 = Color2;
			this.Color3 = Color3;
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x000F72FC File Offset: 0x000F54FC
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000A750 File Offset: 0x00008950
		[Description("颜色样式")]
		[Category("Chartlet")]
		public Chartlet.ColorStyles ColorStyle
		{
			get
			{
				return this._ColorStyle;
			}
			set
			{
				this._ColorStyle = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000F7314 File Offset: 0x000F5514
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0000A759 File Offset: 0x00008959
		[Description("颜色索引")]
		[Category("Chartlet")]
		public int ShiftStep
		{
			get
			{
				return this._ShiftStep;
			}
			set
			{
				this._ShiftStep = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000F732C File Offset: 0x000F552C
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0000A762 File Offset: 0x00008962
		[Description("纹理样式")]
		[Category("Chartlet")]
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

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000F7344 File Offset: 0x000F5544
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0000A76B File Offset: 0x0000896B
		[Description("颜色1")]
		[Category("Chartlet")]
		public Color Color1
		{
			get
			{
				return this._Color1;
			}
			set
			{
				this._Color1 = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000F735C File Offset: 0x000F555C
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x0000A774 File Offset: 0x00008974
		[Category("Chartlet")]
		[Description("颜色2")]
		public Color Color2
		{
			get
			{
				return this._Color2;
			}
			set
			{
				this._Color2 = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000F7374 File Offset: 0x000F5574
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x0000A77D File Offset: 0x0000897D
		[Category("Chartlet")]
		[Description("颜色3")]
		public Color Color3
		{
			get
			{
				return this._Color3;
			}
			set
			{
				this._Color3 = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x000F738C File Offset: 0x000F558C
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0000A786 File Offset: 0x00008986
		[Description("启用纹理样式")]
		[Category("Chartlet")]
		public bool TextureEnable
		{
			get
			{
				return this._TextureEnable;
			}
			set
			{
				this._TextureEnable = value;
			}
		}

		// Token: 0x04000F80 RID: 3968
		private int _ShiftStep;

		// Token: 0x04000F81 RID: 3969
		private HatchStyle _TextureStyle;

		// Token: 0x04000F82 RID: 3970
		private Color _Color1;

		// Token: 0x04000F83 RID: 3971
		private Color _Color2;

		// Token: 0x04000F84 RID: 3972
		private Color _Color3;

		// Token: 0x04000F85 RID: 3973
		private bool _TextureEnable;

		// Token: 0x04000F86 RID: 3974
		private Chartlet.ColorStyles _ColorStyle;
	}
}
