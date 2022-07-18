using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x02000150 RID: 336
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TrendAttributes
	{
		// Token: 0x06001E30 RID: 7728 RVA: 0x0000A88E File Offset: 0x00008A8E
		public TrendAttributes()
		{
			this._Start = DateTime.Now;
			this._End = DateTime.Now;
			this._TimeSpan = Chartlet.TimeSpanTypes.Hour;
			this._ValueFormat = "hh:mm";
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000F7754 File Offset: 0x000F5954
		public TrendAttributes(string StartString, string EndString, Chartlet.TimeSpanTypes TimeSpan, string ValueFormat)
		{
			this._Start = DateTime.Now;
			this._End = DateTime.Now;
			this._TimeSpan = Chartlet.TimeSpanTypes.Hour;
			this._ValueFormat = "hh:mm";
			this.StartString = StartString;
			this.EndString = EndString;
			this.TimeSpan = TimeSpan;
			this.ValueFormat = ValueFormat;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000F77AC File Offset: 0x000F59AC
		public TrendAttributes(DateTime Start, DateTime End, Chartlet.TimeSpanTypes TimeSpan, string ValueFormat)
		{
			this._Start = DateTime.Now;
			this._End = DateTime.Now;
			this._TimeSpan = Chartlet.TimeSpanTypes.Hour;
			this._ValueFormat = "hh:mm";
			this.Start = Start;
			this.End = End;
			this.TimeSpan = TimeSpan;
			this.ValueFormat = ValueFormat;
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000F7804 File Offset: 0x000F5A04
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0000A8BE File Offset: 0x00008ABE
		[Category("Chartlet")]
		[Description("趋势图的横坐标起始时间")]
		public DateTime Start
		{
			get
			{
				return this._Start;
			}
			set
			{
				this._Start = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000F781C File Offset: 0x000F5A1C
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0000A8C7 File Offset: 0x00008AC7
		[Category("Chartlet")]
		[Description("趋势图的横坐标结束时间")]
		public DateTime End
		{
			get
			{
				return this._End;
			}
			set
			{
				this._End = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000F7834 File Offset: 0x000F5A34
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		[Description("趋势图的横坐标步长(年，月，日，时，分，秒)")]
		[Category("Chartlet")]
		public Chartlet.TimeSpanTypes TimeSpan
		{
			get
			{
				return this._TimeSpan;
			}
			set
			{
				this._TimeSpan = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000F784C File Offset: 0x000F5A4C
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0000A8D9 File Offset: 0x00008AD9
		[Description("趋势图的横坐标步长(年，月，日，时，分，秒)")]
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x000F7864 File Offset: 0x000F5A64
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0000A8E2 File Offset: 0x00008AE2
		[Category("Chartlet")]
		[Description("趋势图的横坐标起始时间(字符串格式)")]
		public string StartString
		{
			get
			{
				return this._Start.ToString();
			}
			set
			{
				this._Start = DateTime.Parse(value);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x000F7880 File Offset: 0x000F5A80
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Category("Chartlet")]
		[Description("趋势图的横坐标结束时间(字符串格式)")]
		public string EndString
		{
			get
			{
				return this._End.ToString();
			}
			set
			{
				this._End = DateTime.Parse(value);
			}
		}

		// Token: 0x04000F92 RID: 3986
		private DateTime _Start;

		// Token: 0x04000F93 RID: 3987
		private DateTime _End;

		// Token: 0x04000F94 RID: 3988
		private Chartlet.TimeSpanTypes _TimeSpan;

		// Token: 0x04000F95 RID: 3989
		private string _ValueFormat;
	}
}
