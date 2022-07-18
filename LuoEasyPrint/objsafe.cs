using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000176 RID: 374
	[StandardModule]
	internal sealed class objsafe
	{
		// Token: 0x02000177 RID: 375
		[Guid("CB5BDC81-93C1-11CF-8F20-00805F2CD064")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface IObjectSafety
		{
			// Token: 0x06001EFD RID: 7933
			void GetInterfaceSafetyOptions(ref Guid iid, ref int pdwSupportedOptions, ref int pdwEnabledOptions);

			// Token: 0x06001EFE RID: 7934
			void SetInterfaceSafetyOptions(ref Guid iid, int dwOptionSetMask, int dwEnabledOptions);
		}

		// Token: 0x02000178 RID: 376
		public enum ObjectSafetyFlags
		{
			// Token: 0x040010DD RID: 4317
			INTERFACESAFE_FOR_UNTRUSTED_CALLER = 1,
			// Token: 0x040010DE RID: 4318
			INTERFACESAFE_FOR_UNTRUSTED_DATA,
			// Token: 0x040010DF RID: 4319
			INTERFACE_USES_DISPEX = 4,
			// Token: 0x040010E0 RID: 4320
			INTERFACE_USES_SECURITY_MANAGER = 8,
			// Token: 0x040010E1 RID: 4321
			SafeForScripting = 3
		}
	}
}
