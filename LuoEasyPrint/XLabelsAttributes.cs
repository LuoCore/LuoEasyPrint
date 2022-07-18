using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	// Token: 0x0200014A RID: 330
	[EditorBrowsable(EditorBrowsableState.Never)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class XLabelsAttributes : LabelsAttributes
	{
		// Token: 0x06001DF6 RID: 7670 RVA: 0x0000A6D7 File Offset: 0x000088D7
		public XLabelsAttributes()
		{
			this._SampleSize = 1;
			this._RotateAngle = 30f;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0000A6F1 File Offset: 0x000088F1
		public XLabelsAttributes(int SampleSize, float RotateAngle)
		{
			this._SampleSize = 1;
			this._RotateAngle = 30f;
			this.SampleSize = SampleSize;
			this.RotateAngle = RotateAngle;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000F71B0 File Offset: 0x000F53B0
		public XLabelsAttributes(bool Show, Color ForeColor, Color BackColor, Font Font, string UnitText, string ValueFormat, Font UnitFont, int SampleSize, float RotateAngle)
		{
			this._SampleSize = 1;
			this._RotateAngle = 30f;
			this.SampleSize = SampleSize;
			this.RotateAngle = RotateAngle;
			this.Show = Show;
			this.Font = Font;
			this.ForeColor = ForeColor;
			this.BackColor = BackColor;
			this.UnitText = UnitText;
			this.ValueFormat = ValueFormat;
			this.UnitFont = UnitFont;
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000F721C File Offset: 0x000F541C
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0000A719 File Offset: 0x00008919
		[Description("X坐标抽样率")]
		[Category("Chartlet")]
		public int SampleSize
		{
			get
			{
				return this._SampleSize;
			}
			set
			{
				this._SampleSize = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000F7234 File Offset: 0x000F5434
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0000A722 File Offset: 0x00008922
		[Category("Chartlet")]
		[Description("X坐标文字旋转角度")]
		public float RotateAngle
		{
			get
			{
				return this._RotateAngle;
			}
			set
			{
				this._RotateAngle = value;
			}
		}

		// Token: 0x04000F7E RID: 3966
		private int _SampleSize;

		// Token: 0x04000F7F RID: 3967
		private float _RotateAngle;
	}
}
