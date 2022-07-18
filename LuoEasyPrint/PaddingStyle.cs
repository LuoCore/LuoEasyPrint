using System;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000A7 RID: 167
	public sealed class PaddingStyle : IDisposable
	{
		// Token: 0x060016DE RID: 5854 RVA: 0x0000816A File Offset: 0x0000636A
		public PaddingStyle()
		{
			this.Init();
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00008178 File Offset: 0x00006378
		public PaddingStyle(XmlPaddingStyle xmlStyle) : this()
		{
			this.ParseFormat(xmlStyle);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000C450C File Offset: 0x000C270C
		public PaddingStyle(XmlNode style) : this()
		{
			XmlPaddingStyle xmlPaddingStyle = new XmlPaddingStyle(style);
			xmlPaddingStyle.Parse();
			this.ParseFormat(xmlPaddingStyle);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002590 File Offset: 0x00000790
		public void Dispose()
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00008187 File Offset: 0x00006387
		private void Init()
		{
			this._Left = 0f;
			this._Right = 0f;
			this._Top = 0f;
			this._Bottom = 0f;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x000C4534 File Offset: 0x000C2734
		private void ParseFormat(XmlPaddingStyle xmlStyle)
		{
			if (String.Compare(xmlStyle.Left.Trim(), "", false) != 0)
			{
				this._Left = float.Parse(xmlStyle.Left);
			}
			if (String.Compare(xmlStyle.Right.Trim(), "", false) != 0)
			{
				this._Right = float.Parse(xmlStyle.Right);
			}
			if (String.Compare(xmlStyle.Top.Trim(), "", false) != 0)
			{
				this._Top = float.Parse(xmlStyle.Top);
			}
			if (String.Compare(xmlStyle.Bottom.Trim(), "", false) != 0)
			{
				this._Bottom = float.Parse(xmlStyle.Bottom);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000C45EC File Offset: 0x000C27EC
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x000081B5 File Offset: 0x000063B5
		public float Bottom
		{
			get
			{
				return this._Bottom;
			}
			set
			{
				this._Bottom = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000C4604 File Offset: 0x000C2804
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x000081BE File Offset: 0x000063BE
		public float Left
		{
			get
			{
				return this._Left;
			}
			set
			{
				this._Left = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000C461C File Offset: 0x000C281C
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x000081C7 File Offset: 0x000063C7
		public float Right
		{
			get
			{
				return this._Right;
			}
			set
			{
				this._Right = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000C4634 File Offset: 0x000C2834
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x000081D0 File Offset: 0x000063D0
		public float Top
		{
			get
			{
				return this._Top;
			}
			set
			{
				this._Top = value;
			}
		}

		// Token: 0x04000ADA RID: 2778
		private float _Bottom;

		// Token: 0x04000ADB RID: 2779
		private float _Left;

		// Token: 0x04000ADC RID: 2780
		private float _Right;

		// Token: 0x04000ADD RID: 2781
		private float _Top;
	}
}
