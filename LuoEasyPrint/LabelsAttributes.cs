using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	// Token: 0x02000149 RID: 329
	[EditorBrowsable(EditorBrowsableState.Never)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class LabelsAttributes : Attributes, IDisposable
	{
		// Token: 0x06001DE8 RID: 7656 RVA: 0x0000A654 File Offset: 0x00008854
		public LabelsAttributes()
		{
			this._UnitText = "%";
			this._ValueFormat = "0.0";
			this._UnitFont = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._LabelCount = 5;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000F7020 File Offset: 0x000F5220
		public LabelsAttributes(string UnitText, string ValueFormat)
		{
			this._UnitText = "%";
			this._ValueFormat = "0.0";
			this._UnitFont = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._LabelCount = 5;
			this.UnitText = UnitText;
			this.ValueFormat = ValueFormat;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000F7078 File Offset: 0x000F5278
		public LabelsAttributes(string UnitText, string ValueFormat, Font UnitFont)
		{
			this._UnitText = "%";
			this._ValueFormat = "0.0";
			this._UnitFont = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._LabelCount = 5;
			this.UnitText = UnitText;
			this.ValueFormat = ValueFormat;
			this.UnitFont = UnitFont;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000F70D4 File Offset: 0x000F52D4
		public LabelsAttributes(bool Show, Color ForeColor, Color BackColor, Font Font, string UnitText, string ValueFormat, Font UnitFont)
		{
			this._UnitText = "%";
			this._ValueFormat = "0.0";
			this._UnitFont = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._LabelCount = 5;
			this.Show = Show;
			this.Font = Font;
			this.ForeColor = ForeColor;
			this.BackColor = BackColor;
			this.UnitText = UnitText;
			this.ValueFormat = ValueFormat;
			this.UnitFont = UnitFont;
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x000F7150 File Offset: 0x000F5350
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000A690 File Offset: 0x00008890
		[Description("坐标文字的单位")]
		[Category("Chartlet")]
		public string UnitText
		{
			get
			{
				return this._UnitText;
			}
			set
			{
				this._UnitText = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x000F7168 File Offset: 0x000F5368
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000A699 File Offset: 0x00008899
		[Description("坐标轴单位文字的字体")]
		[Category("Chartlet")]
		public Font UnitFont
		{
			get
			{
				return this._UnitFont;
			}
			set
			{
				this._UnitFont = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x000F7180 File Offset: 0x000F5380
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000A6A2 File Offset: 0x000088A2
		[Category("Chartlet")]
		[Description("坐标轴单位文字的个数")]
		public int LabelCount
		{
			get
			{
				return this._LabelCount;
			}
			set
			{
				this._LabelCount = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000F7198 File Offset: 0x000F5398
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000A6AB File Offset: 0x000088AB
		[Description("纵坐标数值显示格式(用来控制小数位数)")]
		[Category("Chartlet")]
		public string ValueFormat
		{
			get
			{
				return this._ValueFormat;
			}
			set
			{
				this._ValueFormat = value;
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0000A6B4 File Offset: 0x000088B4
		protected virtual void Dispose(bool disposing)
		{
			if (this.disposedValue || !disposing)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000F79 RID: 3961
		private string _UnitText;

		// Token: 0x04000F7A RID: 3962
		private string _ValueFormat;

		// Token: 0x04000F7B RID: 3963
		private Font _UnitFont;

		// Token: 0x04000F7C RID: 3964
		private int _LabelCount;

		// Token: 0x04000F7D RID: 3965
		private bool disposedValue;
	}
}
