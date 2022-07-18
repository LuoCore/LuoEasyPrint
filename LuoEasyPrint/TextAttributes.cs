using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	// Token: 0x02000148 RID: 328
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TextAttributes : Attributes
	{
		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000A5DF File Offset: 0x000087DF
		public TextAttributes()
		{
			this._Text = "";
			this._OffsetY = 0;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000A5F9 File Offset: 0x000087F9
		public TextAttributes(string Text)
		{
			this._Text = "";
			this._OffsetY = 0;
			this.Text = Text;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000A61A File Offset: 0x0000881A
		public TextAttributes(string Text, int OffsetY)
		{
			this._Text = "";
			this._OffsetY = 0;
			this.Text = Text;
			this.OffsetY = OffsetY;
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000F6F9C File Offset: 0x000F519C
		public TextAttributes(string Text, int OffsetY, bool Show, Color ForeColor, Color BackColor, Font Font)
		{
			this._Text = "";
			this._OffsetY = 0;
			this.Text = Text;
			this.OffsetY = OffsetY;
			this.Show = Show;
			this.Font = Font;
			this.ForeColor = ForeColor;
			this.BackColor = BackColor;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000F6FF0 File Offset: 0x000F51F0
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0000A642 File Offset: 0x00008842
		[Description("文字")]
		[Category("Chartlet")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x000F7008 File Offset: 0x000F5208
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0000A64B File Offset: 0x0000884B
		[Description("文字的位置偏移，用来微调文字在图上的位置")]
		[Category("Chartlet")]
		public int OffsetY
		{
			get
			{
				return this._OffsetY;
			}
			set
			{
				this._OffsetY = value;
			}
		}

		// Token: 0x04000F77 RID: 3959
		private string _Text;

		// Token: 0x04000F78 RID: 3960
		private int _OffsetY;
	}
}
