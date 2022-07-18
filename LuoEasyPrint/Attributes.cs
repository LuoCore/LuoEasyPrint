using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Attributes
	{
		
		public Attributes()
		{
			this._Show = true;
			this._Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._ForeColor = Color.Black;
			this._BackColor = Color.White;
		}
		public Attributes(bool Show, Color ForeColor, Color BackColor, Font Font)
		{
			this._Show = true;
			this._Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._ForeColor = Color.Black;
			this._BackColor = Color.White;
			this.Show = Show;
			this.Font = Font;
			this.ForeColor = ForeColor;
			this.BackColor = BackColor;
		}
		public Attributes(bool Show, Color ForeColor, Color BackColor)
		{
			this._Show = true;
			this._Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
			this._ForeColor = Color.Black;
			this._BackColor = Color.White;
			this.Show = Show;
			this.ForeColor = ForeColor;
			this.BackColor = BackColor;
		}
		[Description("是否显示")]
		[Category("Chartlet")]
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

		[Category("Chartlet")]
		[Description("字体")]
		public Font Font
		{
			get
			{
				return this._Font;
			}
			set
			{
				this._Font = value;
			}
		}

		[Category("Chartlet")]
		[Description("前景色，大部分时候指的是字体颜色")]
		public Color ForeColor
		{
			get
			{
				return this._ForeColor;
			}
			set
			{
				this._ForeColor = value;
			}
		}

		[Category("Chartlet")]
		[Description("背景色")]
		public Color BackColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				this._BackColor = value;
			}
		}

		private bool _Show;
		private Font _Font;

		private Color _ForeColor;

		
		private Color _BackColor;
	}
}
