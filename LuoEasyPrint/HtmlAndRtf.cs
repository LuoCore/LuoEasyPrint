using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000175 RID: 373
	[StandardModule]
	internal sealed class HtmlAndRtf
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x001016C8 File Offset: 0x000FF8C8
		public static string RTF_To_HTML(string sRTF)
		{
			Microsoft.Office.Interop.Word.Application application = null;
			object obj = 0;
			string result = "";
			try
			{
				application = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.application", "");
				application.Visible = false;
				Documents documents = application.Documents;
				object value = Missing.Value;
				object value2 = Missing.Value;
				object value3 = Missing.Value;
				object obj2 = Missing.Value;
				documents.Add(ref value, ref value2, ref value3, ref obj2);
				DataObject dataObject = new DataObject();
				dataObject.SetData("Rich Text Format", sRTF);
				Clipboard.SetDataObject(dataObject);
				Windows windows = application.Windows;
				obj2 = 1;
				windows[ref obj2].Selection.Paste();
				Windows windows2 = application.Windows;
				obj2 = 1;
				windows2[ref obj2].Selection.WholeStory();
				Windows windows3 = application.Windows;
				obj2 = 1;
				windows3[ref obj2].Selection.Copy();
				string text = Convert.ToString(Clipboard.GetData(DataFormats.Html));
				text = text.Substring(text.IndexOf("<html"));
				text = text.Replace("Â", "");
				result = text;
				if (application != null)
				{
					_Application application2 = application;
					obj2 = Missing.Value;
					value3 = Missing.Value;
					application2.Quit(ref obj, ref obj2, ref value3);
					application = null;
				}
			}
			catch (Exception ex)
			{
				if (application != null)
				{
					try
					{
						_Application application3 = application;
						object obj2 = Missing.Value;
						object value3 = Missing.Value;
						application3.Quit(ref obj, ref obj2, ref value3);
						application = null;
					}
					catch (Exception ex2)
					{
						application = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00101880 File Offset: 0x000FFA80
		public static string HTML_To_RTF(string shtml)
		{
			WebBrowser webBrowser = new WebBrowser();
			webBrowser.DocumentText = shtml;
			while (webBrowser.IsBusy | webBrowser.ReadyState != WebBrowserReadyState.Complete)
			{
				Thread.Sleep(100);
				System.Windows.Forms.Application.DoEvents();
			}
            Microsoft.Office.Interop.Word.Application application = null;
			object obj = 0;
			string result = "";
			try
			{
				application = (Microsoft.Office.Interop.Word.Application)Interaction.CreateObject("Word.application", "");
				application.Visible = false;
				application.DisplayAlerts = 0;
				Documents documents = application.Documents;
				object value = Missing.Value;
				object value2 = Missing.Value;
				object value3 = Missing.Value;
				object obj2 = Missing.Value;
				documents.Add(ref value, ref value2, ref value3, ref obj2);
				webBrowser.Document.ExecCommand("SELECTALL", false, "");
				webBrowser.Document.ExecCommand("COPY", false, "");
				Windows windows = application.Windows;
				obj2 = 1;
				windows[ref obj2].Selection.PasteAndFormat(WdRecoveryType.wdFormatOriginalFormatting);
				Windows windows2 = application.Windows;
				obj2 = 1;
				windows2[ref obj2].Selection.WholeStory();
				Windows windows3 = application.Windows;
				obj2 = 1;
				windows3[ref obj2].Selection.Copy();
				string text = Convert.ToString(Clipboard.GetData(DataFormats.Rtf));
				result = text;
				if (application != null)
				{
					_Application application2 = application;
					obj2 = Missing.Value;
					value3 = Missing.Value;
					application2.Quit(ref obj, ref obj2, ref value3);
					application = null;
				}
			}
			catch (Exception ex)
			{
				if (application != null)
				{
					try
					{
						_Application application3 = application;
						object obj2 = Missing.Value;
						object value3 = Missing.Value;
						application3.Quit(ref obj, ref obj2, ref value3);
						application = null;
					}
					catch (Exception ex2)
					{
						application = null;
					}
				}
			}
			webBrowser.Dispose();
			webBrowser = null;
			return result;
		}
	}
}
