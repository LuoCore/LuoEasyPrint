using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace LuoEasyPrint
{
	// Token: 0x02000083 RID: 131
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PreviewController : PreviewPrintController
	{
		// Token: 0x060011F1 RID: 4593 RVA: 0x0000696A File Offset: 0x00004B6A
		public override void OnStartPrint(PrintDocument document, PrintEventArgs e)
		{
			base.OnStartPrint(document, e);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0008E388 File Offset: 0x0008C588
		public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e)
		{
			return base.OnStartPage(document, e);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00006974 File Offset: 0x00004B74
		public override void OnEndPrint(PrintDocument document, PrintEventArgs e)
		{
			base.OnEndPrint(document, e);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0008E3A0 File Offset: 0x0008C5A0
		public static void StartDo(PrintDocument document)
		{
			if (document != null)
			{
				PrintController printController = document.PrintController;
				PreviewController printController2 = new PreviewController();
				document.PrintController = printController2;
				document.Print();
				document.PrintController = printController;
			}
		}
	}
}
