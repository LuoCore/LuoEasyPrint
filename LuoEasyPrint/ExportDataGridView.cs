using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;



namespace LuoEasyPrint
{
	// Token: 0x020000D4 RID: 212
	[Guid("36DFD7E0-CE2F-4355-BF58-976997D5027B")]
	[ToolboxBitmap(typeof(ExportDataGridView), "export.ico")]
	[Description("将DataGridView导出为RTF\\PDF\\HTML\\EXCEL格式")]
	public class ExportDataGridView : Component, objsafe.IObjectSafety
	{
		// Token: 0x060018FF RID: 6399 RVA: 0x000CF7B0 File Offset: 0x000CD9B0
		public ExportDataGridView()
		{
			this._title = "";
			this._titlefont = new Font("黑体", 18f, FontStyle.Bold);
			this._tableheader = "";
			this._tableheaderfont = new Font("宋体", 12f);
			this._tablefooter = "";
			this._tablefooterfont = new Font("宋体", 12f);
			this._file = "";
			this._openfile = false;
			this._paperwidth = 210f;
			this._paperheight = 297f;
			this._paperlandscape = false;
			this._margin = new Margins(10, 10, 10, 10);
			this._isShowProgress = true;
			this._repeatheader = true;
			this._image = null;
			this._numericmode = true;
			this._saveformula = false;
			this._addmode = false;
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x000CF890 File Offset: 0x000CDA90
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00008BFA File Offset: 0x00006DFA
		[Description("导出Excel时，是否使用追加模式，默认为false。仅对导出Excel有效。若此属性为true，则当文件已经存在的情况下，直接向文件中添加工作表而不提示；若为false，则会提示是覆盖文件还是追加工作表。")]
		public bool AddMode
		{
			get
			{
				return this._addmode;
			}
			set
			{
				this._addmode = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000CF8A4 File Offset: 0x000CDAA4
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00008C03 File Offset: 0x00006E03
		[Description("导出Excel时，是否将公式也导出，默认为false。仅当导入Excel时有公式有效，且仅对导出Excel有效。若此属性为true请确保导出Excel时不要设置主标题title及表头tableheader，即要保证导入与导出时样式是完全一样的，否则公式会不正确。")]
		public bool SaveFormula
		{
			get
			{
				return this._saveformula;
			}
			set
			{
				this._saveformula = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000CF8B8 File Offset: 0x000CDAB8
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Description("导出Excel时，如果DGV列没有列类型，对于数值内容是否以数值形式导出，默认为true，仅对导出Excel有效")]
		public bool NumericMode
		{
			get
			{
				return this._numericmode;
			}
			set
			{
				this._numericmode = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000CF8CC File Offset: 0x000CDACC
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00008C15 File Offset: 0x00006E15
		[Description("导出Excel时，表格尾部要添加的图形对象，仅对导出Excel有效")]
		public Image Image
		{
			get
			{
				return this._image;
			}
			set
			{
				if (this._image != null)
				{
					this._image.Dispose();
					this._image = null;
				}
				if (value == null)
				{
					this._image = null;
				}
				else
				{
					this._image = (Image)value.Clone();
				}
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000CF8E4 File Offset: 0x000CDAE4
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00008C4E File Offset: 0x00006E4E
		[Description("导出的PDF表格是否每页都显示表头（列标题）,仅对导出格式为PDF时有效")]
		public bool RepeatHeader
		{
			get
			{
				return this._repeatheader;
			}
			set
			{
				this._repeatheader = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x000CF8F8 File Offset: 0x000CDAF8
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00008C57 File Offset: 0x00006E57
		[Description("是否显示导出进度窗口")]
		public bool IsShowProgress
		{
			get
			{
				return this._isShowProgress;
			}
			set
			{
				this._isShowProgress = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x000CF90C File Offset: 0x000CDB0C
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x00008C60 File Offset: 0x00006E60
		[Description("页边距，以毫米为单位，仅对导出PDF格式有效")]
		public Margins PaperMargin
		{
			get
			{
				return this._margin;
			}
			set
			{
				this._margin = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000CF924 File Offset: 0x000CDB24
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x00008C69 File Offset: 0x00006E69
		[Description("以毫米为单位的纸张宽度，若为0，则表示以DataGridView的宽度自动确定，在此情况下，将忽略PaperLandScape的设置，仅对导出PDF格式有效")]
		public float PaperWidth
		{
			get
			{
				return this._paperwidth;
			}
			set
			{
				this._paperwidth = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000CF93C File Offset: 0x000CDB3C
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x00008C72 File Offset: 0x00006E72
		[Description("纸张高度，以毫米为计量单位，仅对导出PDF格式有效")]
		public float PaperHeight
		{
			get
			{
				return this._paperheight;
			}
			set
			{
				if (value > 0f)
				{
					this._paperheight = value;
				}
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000CF954 File Offset: 0x000CDB54
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00008C83 File Offset: 0x00006E83
		[Description("纸张方向，为true表示横向，为false表示纵向，仅对导出PDF格式有效")]
		public bool PaperLandScape
		{
			get
			{
				return this._paperlandscape;
			}
			set
			{
				this._paperlandscape = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000CF968 File Offset: 0x000CDB68
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x00008C8C File Offset: 0x00006E8C
		[Description("导出完成后，是否提示打开该文件，为false表示不打开，为true表示提示用户是否打开")]
		public bool OpenFile
		{
			get
			{
				return this._openfile;
			}
			set
			{
				this._openfile = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x000CF97C File Offset: 0x000CDB7C
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x00008C95 File Offset: 0x00006E95
		[Description("工作表名称，仅对导出Excel有效")]
		public string SheetName
		{
			get
			{
				return this._sheetname;
			}
			set
			{
				this._sheetname = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x000CF994 File Offset: 0x000CDB94
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x00008C9E File Offset: 0x00006E9E
		[Description("要导出的文件名，若为空，则会自动弹出文件选择对话框")]
		public string FileName
		{
			get
			{
				return this._file;
			}
			set
			{
				this._file = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000CF9AC File Offset: 0x000CDBAC
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00008CA7 File Offset: 0x00006EA7
		[Description("导出主标题内容")]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				this._title = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x000CF9C4 File Offset: 0x000CDBC4
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00008CB0 File Offset: 0x00006EB0
		[Description("主标题字体")]
		public Font TitleFont
		{
			get
			{
				return this._titlefont;
			}
			set
			{
				if (value != null)
				{
					this._titlefont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x000CF9DC File Offset: 0x000CDBDC
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00008CC6 File Offset: 0x00006EC6
		[Description("表头要显示的文字")]
		public string TableHeader
		{
			get
			{
				return this._tableheader;
			}
			set
			{
				this._tableheader = value;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00008CCF File Offset: 0x00006ECF
		[Description("表头文字要显示的字体大小")]
		public Font TableHeaderFont
		{
			get
			{
				return this._tableheaderfont;
			}
			set
			{
				if (value != null)
				{
					this._tableheaderfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x000CFA0C File Offset: 0x000CDC0C
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x00008CE5 File Offset: 0x00006EE5
		[Description("表尾要显示的文字内容")]
		public string TableFooter
		{
			get
			{
				return this._tablefooter;
			}
			set
			{
				this._tablefooter = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x000CFA24 File Offset: 0x000CDC24
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00008CEE File Offset: 0x00006EEE
		[Description("表尾文字要显示的字体大小")]
		public Font TableFooterFont
		{
			get
			{
				return this._tablefooterfont;
			}
			set
			{
				if (value != null)
				{
					this._tablefooterfont = (Font)value.Clone();
				}
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00008D04 File Offset: 0x00006F04
		public void ExportDGV(MulHeaderDataGridView dgv, ExportDataGridView.ExportDataGridViewType exporttype)
		{
			this.ExportDGV(dgv, dgv.ColHeaderTreeView, exporttype);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00008D14 File Offset: 0x00006F14
		public void ExportDGV(MulHeaderDataGridView dgv)
		{
			this.ExportDGV(dgv, dgv.ColHeaderTreeView);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00008D23 File Offset: 0x00006F23
		public void ExportDGV(DataGridView dgv, ExportDataGridView.ExportDataGridViewType exporttype)
		{
			this.ExportDGV(dgv, null, exporttype);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x000CFA3C File Offset: 0x000CDC3C
		public void ExportDGV(DataGridView dgv)
		{
			TreeView columnheadertree = null;
			this.ExportDGV(dgv, columnheadertree);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000CFA54 File Offset: 0x000CDC54
		private void ExportDGV(DataGridView dgv, TreeView columnheadertree)
		{
			if (dgv != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.AddExtension = true;
				saveFileDialog.OverwritePrompt = true;
				saveFileDialog.Title = "请选择要导出文件的路径和文件名";
				saveFileDialog.DefaultExt = "xls";
				saveFileDialog.Filter = "Excel 97-2003文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|HTML网页文件(*.htm)|*.htm|RTF富文本文件(*.rtf)|*.rtf|pdf文件(*.pdf)|*.pdf";
				saveFileDialog.FilterIndex = 1;
				if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				{
					saveFileDialog.Dispose();
				}
				else
				{
					string fileName = saveFileDialog.FileName;
					int filterIndex = saveFileDialog.FilterIndex;
					saveFileDialog.Dispose();
					if (MyProject.Computer.FileSystem.FileExists(fileName) & (filterIndex != 1 & filterIndex != 2))
					{
						try
						{
							MyProject.Computer.FileSystem.DeleteFile(fileName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
						}
						catch (Exception ex)
						{
							Interaction.MsgBox("数据导出失败，原因是文件【" + fileName + "】无法覆盖，可能该文件正在使用中，请关闭该文件后再试", MsgBoxStyle.Exclamation, "提示信息");
							return;
						}
					}
					string fileName2 = this.FileName;
					this.FileName = fileName;
					switch (filterIndex)
					{
					case 1:
						this.ExportDGV(dgv, columnheadertree, ExportDataGridView.ExportDataGridViewType.Excel);
						break;
					case 2:
						this.ExportDGV(dgv, columnheadertree, ExportDataGridView.ExportDataGridViewType.Excel2007);
						break;
					case 3:
						this.ExportDGV(dgv, columnheadertree, ExportDataGridView.ExportDataGridViewType.HTML);
						break;
					case 4:
						this.ExportDGV(dgv, columnheadertree, ExportDataGridView.ExportDataGridViewType.RTF);
						break;
					case 5:
						this.ExportDGV(dgv, columnheadertree, ExportDataGridView.ExportDataGridViewType.PDF);
						break;
					}
					this.FileName = fileName2;
				}
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000CFBA8 File Offset: 0x000CDDA8
		internal void ExportDGV(DataGridView dgv, TreeView columnheadertree, ExportDataGridView.ExportDataGridViewType exporttype)
		{
			if (dgv != null)
			{
				string text = this._file;
				switch (exporttype)
				{
				case ExportDataGridView.ExportDataGridViewType.Excel:
				case ExportDataGridView.ExportDataGridViewType.HTML:
				case ExportDataGridView.ExportDataGridViewType.RTF:
					break;
				default:
					Module1.MyMsgBox("导出格式不正确");
					break;
				}
				if (String.Compare(Strings.Trim(text), "", false) == 0)
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.AddExtension = true;
					saveFileDialog.OverwritePrompt = true;
					switch (exporttype)
					{
					case ExportDataGridView.ExportDataGridViewType.Excel:
						saveFileDialog.Title = "请选择要导出Excel文件的路径和文件名";
						saveFileDialog.DefaultExt = "xls";
						saveFileDialog.Filter = "Excel 97-2003文件(*.xls)|*.xls";
						break;
					case ExportDataGridView.ExportDataGridViewType.Excel2007:
						saveFileDialog.Title = "请选择要导出Excel文件的路径和文件名";
						saveFileDialog.DefaultExt = "xlsx";
						saveFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
						break;
					case ExportDataGridView.ExportDataGridViewType.HTML:
						saveFileDialog.Title = "请选择要导出HTML文件的路径和文件名";
						saveFileDialog.DefaultExt = "htm";
						saveFileDialog.Filter = "HTML网页文件(*.htm)|*.htm";
						break;
					case ExportDataGridView.ExportDataGridViewType.RTF:
						saveFileDialog.Title = "请选择要导出RTF文件的路径和文件名";
						saveFileDialog.DefaultExt = "rtf";
						saveFileDialog.Filter = "RTF富文本文件(*.rtf)|*.rtf";
						break;
					case ExportDataGridView.ExportDataGridViewType.PDF:
						saveFileDialog.Title = "请选择要导出PDF文件的路径和文件名";
						saveFileDialog.DefaultExt = "pdf";
						saveFileDialog.Filter = "pdf文件(*.pdf)|*.pdf";
						break;
					default:
						Module1.MyMsgBox("导出格式不正确");
						break;
					}
					saveFileDialog.FileName = "";
					if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
					{
						saveFileDialog.Dispose();
						return;
					}
					text = saveFileDialog.FileName;
					saveFileDialog.Dispose();
				}
				if (MyProject.Computer.FileSystem.FileExists(text) & (exporttype != ExportDataGridView.ExportDataGridViewType.Excel & exporttype != ExportDataGridView.ExportDataGridViewType.Excel2007))
				{
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(text, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("数据导出失败，原因是文件【" + text + "】无法覆盖，可能该文件正在使用中，请关闭该文件后再试", MsgBoxStyle.Exclamation, "提示信息");
						return;
					}
				}
				switch (exporttype)
				{
				case ExportDataGridView.ExportDataGridViewType.Excel:
					DGVtoExcel.myDGVToExcel(dgv, columnheadertree, this._titlefont, this._title, text, this._tableheaderfont, this._tableheader, this._tablefooterfont, this._tablefooter, this._sheetname, false, this._isShowProgress, this.Image, this.NumericMode, this._saveformula, this._addmode);
					break;
				case ExportDataGridView.ExportDataGridViewType.Excel2007:
					DGVtoExcel2007.myDGVToExcel(dgv, columnheadertree, this._titlefont, this._title, text, this._tableheaderfont, this._tableheader, this._tablefooterfont, this._tablefooter, this._sheetname, false, this._isShowProgress, this.Image, this.NumericMode, this._saveformula, this._addmode);
					break;
				case ExportDataGridView.ExportDataGridViewType.HTML:
				{
							ExportDataGridViewToHTML ExportDataGridViewToHTML = new ExportDataGridViewToHTML();
					ExportDataGridViewToHTML.ExportDGVToHTML(dgv, columnheadertree, this._title, this._titlefont, this._tableheaderfont, this._tableheader, this._tablefooterfont, this._tablefooter, text, this._isShowProgress);
					break;
				}
				
				default:
					Interaction.MsgBox("导出格式不正确", MsgBoxStyle.OkOnly, null);
					return;
				}
				if (this.OpenFile && Interaction.MsgBox("导出的文件已保存到【" + text + " 】\r\n您是否要立即打开这个文件以查看其内容?", MsgBoxStyle.YesNoCancel, "提示信息") == MsgBoxResult.Yes)
				{
					try
					{
						Process.Start(text);
					}
					catch (Exception ex2)
					{
						try
						{
							Thread.Sleep(100);
							Process.Start(text);
						}
						catch (Exception ex3)
						{
						}
					}
				}
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00002588 File Offset: 0x00000788
		public void GetInterfaceSafetyOptions(ref Guid riid, ref int supportedOptions, ref int enabledOptions)
		{
			supportedOptions = 3;
			enabledOptions = 3;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002590 File Offset: 0x00000790
		public void SetInterfaceSafetyOptions(ref Guid riid, int optionSetMask, int enabledOptions)
		{
		}

		// Token: 0x04000BAA RID: 2986
		private string _title;

		// Token: 0x04000BAB RID: 2987
		private Font _titlefont;

		// Token: 0x04000BAC RID: 2988
		private string _tableheader;

		// Token: 0x04000BAD RID: 2989
		private Font _tableheaderfont;

		// Token: 0x04000BAE RID: 2990
		private string _tablefooter;

		// Token: 0x04000BAF RID: 2991
		private Font _tablefooterfont;

		// Token: 0x04000BB0 RID: 2992
		private string _file;

		// Token: 0x04000BB1 RID: 2993
		private bool _openfile;

		// Token: 0x04000BB2 RID: 2994
		private float _paperwidth;

		// Token: 0x04000BB3 RID: 2995
		private float _paperheight;

		// Token: 0x04000BB4 RID: 2996
		private bool _paperlandscape;

		// Token: 0x04000BB5 RID: 2997
		private Margins _margin;

		// Token: 0x04000BB6 RID: 2998
		private bool _isShowProgress;

		// Token: 0x04000BB7 RID: 2999
		private bool _repeatheader;

		// Token: 0x04000BB8 RID: 3000
		private Image _image;

		// Token: 0x04000BB9 RID: 3001
		private bool _numericmode;

		// Token: 0x04000BBA RID: 3002
		private bool _saveformula;

		// Token: 0x04000BBB RID: 3003
		private bool _addmode;

		// Token: 0x04000BBC RID: 3004
		private string _sheetname;

		// Token: 0x020000D5 RID: 213
		public enum ExportDataGridViewType
		{
			// Token: 0x04000BBE RID: 3006
			Excel,
			// Token: 0x04000BBF RID: 3007
			Excel2007,
			// Token: 0x04000BC0 RID: 3008
			HTML,
			// Token: 0x04000BC1 RID: 3009
			RTF,
			// Token: 0x04000BC2 RID: 3010
			PDF
		}
	}
}
