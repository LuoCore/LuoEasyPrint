using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000046 RID: 70
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class U_Editor : UITypeEditor
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x0005F54C File Offset: 0x0005D74C
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0005F55C File Offset: 0x0005D75C
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			try
			{
				IWindowsFormsEditorService windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (windowsFormsEditorService != null && value is string)
				{
					TextEdit textEdit = new TextEdit();
					textEdit.TextBox1.Text = Convert.ToString(value);
					if (windowsFormsEditorService.ShowDialog(textEdit) == DialogResult.OK)
					{
						return textEdit.TextBox1.Text;
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
