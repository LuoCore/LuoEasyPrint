using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LuoEasyPrint
{
	// Token: 0x0200014C RID: 332
	[EditorBrowsable(EditorBrowsableState.Never)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class StrokeStyle : Painting
	{
		// Token: 0x06001E0E RID: 7694 RVA: 0x0000A78F File Offset: 0x0000898F
		public StrokeStyle()
		{
			this._Width = 0;
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0000A79E File Offset: 0x0000899E
		public StrokeStyle(int Width)
		{
			this._Width = 0;
			this.Width = Width;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x000F73A0 File Offset: 0x000F55A0
		public StrokeStyle(int ShiftStep, Color Color1, Color Color2, Color Color3, bool TextureEnable, HatchStyle TextureStyle, int Width)
		{
			this._Width = 0;
			this.Width = Width;
			this.ShiftStep = ShiftStep;
			this.Color1 = Color1;
			this.Color2 = Color2;
			this.Color3 = Color3;
			this.TextureEnable = TextureEnable;
			this.TextureStyle = TextureStyle;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x000F73F0 File Offset: 0x000F55F0
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0000A7B4 File Offset: 0x000089B4
		[Category("Chartlet")]
		[Description("边框宽度")]
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

		// Token: 0x04000F87 RID: 3975
		private int _Width;
	}
}
