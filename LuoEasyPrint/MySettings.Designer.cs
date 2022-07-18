using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200005E RID: 94
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0006C77C File Offset: 0x0006A97C
		public static MySettings Default
		{
			get
			{
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x04000668 RID: 1640
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
	}
}
