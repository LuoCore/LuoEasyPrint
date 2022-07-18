using System;
using System.ComponentModel;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000168 RID: 360
	[Description("液晶数字显示")]
	public class LcdDigital : Shape
	{
		// Token: 0x06001E93 RID: 7827 RVA: 0x000FF20C File Offset: 0x000FD40C
		public LcdDigital()
		{
			this.Background_Color_temp = Color.White;
			this.Character_length_temp = 2;
			this.Digital_Color_fales_temp = Color.Transparent;
			this.Digital_Color_true_temp = Color.Green;
			this.Scalesdecimal_digits_temp = 0;
			this.shuzhi = 0.0;
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000FF260 File Offset: 0x000FD460
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0000AA8C File Offset: 0x00008C8C
		[Category("杂项")]
		[Description("背景颜色")]
		public Color Background_Color
		{
			get
			{
				return this.Background_Color_temp;
			}
			set
			{
				this.Background_Color_temp = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000FF278 File Offset: 0x000FD478
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0000AA95 File Offset: 0x00008C95
		[Description("字符串长度")]
		[Category("杂项")]
		public int Character_length
		{
			get
			{
				return this.Character_length_temp;
			}
			set
			{
				this.Character_length_temp = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000FF290 File Offset: 0x000FD490
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0000AA9E File Offset: 0x00008C9E
		[Category("杂项")]
		[Description("数字暗时颜色,建议使用透明色或与背景颜色相同")]
		public Color Digital_Color_fales
		{
			get
			{
				return this.Digital_Color_fales_temp;
			}
			set
			{
				this.Digital_Color_fales_temp = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x000FF2A8 File Offset: 0x000FD4A8
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0000AAA7 File Offset: 0x00008CA7
		[Description("数字亮时颜色")]
		[Category("杂项")]
		public Color Digital_Color_true
		{
			get
			{
				return this.Digital_Color_true_temp;
			}
			set
			{
				this.Digital_Color_true_temp = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x000FF2C0 File Offset: 0x000FD4C0
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		[Description("小数位数")]
		[Category("杂项")]
		public int Scalesdecimal_digits
		{
			get
			{
				return this.Scalesdecimal_digits_temp;
			}
			set
			{
				this.Scalesdecimal_digits_temp = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x000FF2D8 File Offset: 0x000FD4D8
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0000AAB9 File Offset: 0x00008CB9
		[Description("要显示的值")]
		[Category("杂项")]
		public double value
		{
			get
			{
				return this.shuzhi;
			}
			set
			{
				this.shuzhi = value;
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000FF2F0 File Offset: 0x000FD4F0
		public override void Draw(Graphics g, int width, int height)
		{
			new Digital_display
			{
				Background_Color = this.Background_Color,
				Character_length = this.Character_length,
				Digital_Color_fales = this.Digital_Color_fales,
				Digital_Color_true = this.Digital_Color_true,
				Scalesdecimal_digits = this.Scalesdecimal_digits,
				value = this.value
			}.Draw(g, width, height);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000FF354 File Offset: 0x000FD554
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void RestoreFromString(string ss)
		{
			if (String.Compare(ss, "", false) != 0)
			{
				string[] array = Strings.Split(ss, this._split1, -1, CompareMethod.Binary);
				try
				{
					this.Background_Color_temp = Module1.ConvertStringToColor(array[0]);
					this.Character_length_temp = Convert.ToInt32(array[1]);
					this.Digital_Color_fales_temp = Module1.ConvertStringToColor(array[2]);
					this.Digital_Color_true_temp = Module1.ConvertStringToColor(array[3]);
					this.Scalesdecimal_digits_temp = Convert.ToInt32(array[4]);
					this.shuzhi = Convert.ToDouble(array[5]);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000FF3F8 File Offset: 0x000FD5F8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public override string SaveAsString()
		{
			string str = Module1.ConvertColorToString(this.Background_Color_temp);
			str = str + this._split1 + Convert.ToString(this.Character_length_temp);
			str = str + this._split1 + Module1.ConvertColorToString(this.Digital_Color_fales_temp);
			str = str + this._split1 + Module1.ConvertColorToString(this.Digital_Color_true_temp);
			str = str + this._split1 + Convert.ToString(this.Scalesdecimal_digits_temp);
			return str + this._split1 + Convert.ToString(this.shuzhi);
		}

		// Token: 0x04001085 RID: 4229
		private Color Background_Color_temp;

		// Token: 0x04001086 RID: 4230
		private int Character_length_temp;

		// Token: 0x04001087 RID: 4231
		private Color Digital_Color_fales_temp;

		// Token: 0x04001088 RID: 4232
		private Color Digital_Color_true_temp;

		// Token: 0x04001089 RID: 4233
		private int Scalesdecimal_digits_temp;

		// Token: 0x0400108A RID: 4234
		private double shuzhi;
	}
}
