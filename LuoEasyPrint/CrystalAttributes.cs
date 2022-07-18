using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x02000146 RID: 326
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrystalAttributes
	{
		// Token: 0x06001DCB RID: 7627 RVA: 0x0000A4FE File Offset: 0x000086FE
		public CrystalAttributes(bool Enable, bool CoverFull, int Contraction)
		{
			this._Enable = false;
			this._CoverFull = false;
			this._Contraction = 2;
			this._Direction = Chartlet.Direction.LeftRight;
			this.Enable = Enable;
			this.CoverFull = CoverFull;
			this.Contraction = Contraction;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0000A537 File Offset: 0x00008737
		public CrystalAttributes()
		{
			this._Enable = false;
			this._CoverFull = false;
			this._Contraction = 2;
			this._Direction = Chartlet.Direction.LeftRight;
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x000F6E28 File Offset: 0x000F5028
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0000A55B File Offset: 0x0000875B
		[Category("Chartlet")]
		[Description("是否使用水晶效果")]
		public bool Enable
		{
			get
			{
				return this._Enable;
			}
			set
			{
				this._Enable = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000F6E3C File Offset: 0x000F503C
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0000A564 File Offset: 0x00008764
		[Description("全高亮水晶效果，还是半高亮水晶效果")]
		[Category("Chartlet")]
		public bool CoverFull
		{
			get
			{
				return this._CoverFull;
			}
			set
			{
				this._CoverFull = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000F6E50 File Offset: 0x000F5050
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0000A56D File Offset: 0x0000876D
		[Description("高亮区域收缩像素")]
		[Category("Chartlet")]
		public int Contraction
		{
			get
			{
				return this._Contraction;
			}
			set
			{
				this._Contraction = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000F6E68 File Offset: 0x000F5068
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0000A576 File Offset: 0x00008776
		[Category("Chartlet")]
		[Description("水晶效果的投射方向")]
		public Chartlet.Direction Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				this._Direction = value;
			}
		}

		// Token: 0x04000F6F RID: 3951
		private bool _Enable;

		// Token: 0x04000F70 RID: 3952
		private bool _CoverFull;

		// Token: 0x04000F71 RID: 3953
		private int _Contraction;

		// Token: 0x04000F72 RID: 3954
		private Chartlet.Direction _Direction;
	}
}
