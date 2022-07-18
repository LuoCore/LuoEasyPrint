using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200005F RID: 95
	[StandardModule]
	[DebuggerNonUserCode]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0006C790 File Offset: 0x0006A990
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
