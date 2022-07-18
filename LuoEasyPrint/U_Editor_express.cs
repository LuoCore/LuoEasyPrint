using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000047 RID: 71
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class U_Editor_express : UITypeEditor
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x0005F5F4 File Offset: 0x0005D7F4
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0005F604 File Offset: 0x0005D804
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			try
			{
				IWindowsFormsEditorService windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (windowsFormsEditorService != null && value is string)
				{
					TextEdit_Express textEdit_Express = new TextEdit_Express();
					textEdit_Express.TextBox1.Text = Convert.ToString(value);
					if (windowsFormsEditorService.ShowDialog(textEdit_Express) == DialogResult.OK)
					{
						return textEdit_Express.TextBox1.Text;
					}
					return value;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("属性编辑器出错", MsgBoxStyle.OkOnly, "提示信息");
				return value;
			}
			return value;
		}
	}
}
