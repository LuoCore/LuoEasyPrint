using System;
using System.ComponentModel;
using System.Drawing;

namespace LuoEasyPrint
{
	
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BackgroundAttributes
	{
		
		public BackgroundAttributes()
		{
			this._Highlight = Color.FromArgb(80, 238, 237, 238);
			this._Lowlight = Color.FromArgb(255, 220, 220, 220);
			this._Paper = Color.FromArgb(255, Color.White);
		}

	
		public BackgroundAttributes(Color Highlight, Color Lowlight)
		{
			this._Highlight = Color.FromArgb(80, 238, 237, 238);
			this._Lowlight = Color.FromArgb(255, 220, 220, 220);
			this._Paper = Color.FromArgb(255, Color.White);
			this.Highlight = Highlight;
			this.Lowlight = Lowlight;
		}

		
		public BackgroundAttributes(Color Highlight, Color Lowlight, Color Paper)
		{
			this._Highlight = Color.FromArgb(80, 238, 237, 238);
			this._Lowlight = Color.FromArgb(255, 220, 220, 220);
			this._Paper = Color.FromArgb(255, Color.White);
			this.Highlight = Highlight;
			this.Lowlight = Lowlight;
			this.Paper = Paper;
		}

		
		[Category("Chartlet")]
		[Description("背景色的高亮色")]
		public Color Highlight
		{
			get
			{
				return this._Highlight;
			}
			set
			{
				this._Highlight = value;
			}
		}
		[Description("背景色的暗色")]
		[Category("Chartlet")]
		public Color Lowlight
		{
			get
			{
				return this._Lowlight;
			}
			set
			{
				this._Lowlight = value;
			}
		}
		[Description("画板颜色(最背景的颜色)")]
		[Category("Chartlet")]
		public Color Paper
		{
			get
			{
				return this._Paper;
			}
			set
			{
				this._Paper = value;
			}
		}
		private Color _Highlight;
		private Color _Lowlight;
		private Color _Paper;
	}
}
