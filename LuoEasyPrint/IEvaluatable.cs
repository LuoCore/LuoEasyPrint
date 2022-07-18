using System;
using System.ComponentModel;

namespace LuoEasyPrint
{
	// Token: 0x0200016D RID: 365
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IEvaluatable
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001EE8 RID: 7912
		// (set) Token: 0x06001EE9 RID: 7913
		string ExpressionText { get; set; }

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001EEA RID: 7914
		bool IsValid { get; }

		// Token: 0x06001EEB RID: 7915
		double Evaluate(double dvalueX);
	}
}
