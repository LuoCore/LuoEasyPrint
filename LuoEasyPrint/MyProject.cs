using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

namespace LuoEasyPrint
{
	// Token: 0x02000004 RID: 4
	[HideModuleName]
	[StandardModule]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000AC88 File Offset: 0x00008E88
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000ACDC File Offset: 0x00008EDC
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000009 RID: 9 RVA: 0x0000AD14 File Offset: 0x00008F14
			// (set) Token: 0x06000024 RID: 36 RVA: 0x00002094 File Offset: 0x00000294
			public AboutBox1 AboutBox1
			{
				get
				{
					this.m_AboutBox1 = MyProject.MyForms.Create__Instance__<AboutBox1>(this.m_AboutBox1);
					return this.m_AboutBox1;
				}
				set
				{
					if (value != this.m_AboutBox1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AboutBox1>(ref this.m_AboutBox1);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000A RID: 10 RVA: 0x0000AD3C File Offset: 0x00008F3C
			// (set) Token: 0x06000025 RID: 37 RVA: 0x000020BB File Offset: 0x000002BB
			public ChooseExcelSheet ChooseExcelSheet
			{
				get
				{
					this.m_ChooseExcelSheet = MyProject.MyForms.Create__Instance__<ChooseExcelSheet>(this.m_ChooseExcelSheet);
					return this.m_ChooseExcelSheet;
				}
				set
				{
					if (value != this.m_ChooseExcelSheet)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ChooseExcelSheet>(ref this.m_ChooseExcelSheet);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000B RID: 11 RVA: 0x0000AD64 File Offset: 0x00008F64
			// (set) Token: 0x06000026 RID: 38 RVA: 0x000020E2 File Offset: 0x000002E2
			public DataGridViewPrintSet DataGridViewPrintSet
			{
				get
				{
					this.m_DataGridViewPrintSet = MyProject.MyForms.Create__Instance__<DataGridViewPrintSet>(this.m_DataGridViewPrintSet);
					return this.m_DataGridViewPrintSet;
				}
				set
				{
					if (value != this.m_DataGridViewPrintSet)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DataGridViewPrintSet>(ref this.m_DataGridViewPrintSet);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000C RID: 12 RVA: 0x0000AD8C File Offset: 0x00008F8C
			// (set) Token: 0x06000027 RID: 39 RVA: 0x00002109 File Offset: 0x00000309
			public draftset draftset
			{
				get
				{
					this.m_draftset = MyProject.MyForms.Create__Instance__<draftset>(this.m_draftset);
					return this.m_draftset;
				}
				set
				{
					if (value != this.m_draftset)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<draftset>(ref this.m_draftset);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600000D RID: 13 RVA: 0x0000ADB4 File Offset: 0x00008FB4
			// (set) Token: 0x06000028 RID: 40 RVA: 0x00002130 File Offset: 0x00000330
			public FormDsgn FormDsgn
			{
				get
				{
					this.m_FormDsgn = MyProject.MyForms.Create__Instance__<FormDsgn>(this.m_FormDsgn);
					return this.m_FormDsgn;
				}
				set
				{
					if (value != this.m_FormDsgn)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormDsgn>(ref this.m_FormDsgn);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600000E RID: 14 RVA: 0x0000ADDC File Offset: 0x00008FDC
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002157 File Offset: 0x00000357
			public mywait mywait
			{
				get
				{
					this.m_mywait = MyProject.MyForms.Create__Instance__<mywait>(this.m_mywait);
					return this.m_mywait;
				}
				set
				{
					if (value != this.m_mywait)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<mywait>(ref this.m_mywait);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600000F RID: 15 RVA: 0x0000AE04 File Offset: 0x00009004
			// (set) Token: 0x0600002A RID: 42 RVA: 0x0000217E File Offset: 0x0000037E
			public OpenmmDialog OpenmmDialog
			{
				get
				{
					this.m_OpenmmDialog = MyProject.MyForms.Create__Instance__<OpenmmDialog>(this.m_OpenmmDialog);
					return this.m_OpenmmDialog;
				}
				set
				{
					if (value != this.m_OpenmmDialog)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<OpenmmDialog>(ref this.m_OpenmmDialog);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000010 RID: 16 RVA: 0x0000AE2C File Offset: 0x0000902C
			// (set) Token: 0x0600002B RID: 43 RVA: 0x000021A5 File Offset: 0x000003A5
			public PivotTableDetail PivotTableDetail
			{
				get
				{
					this.m_PivotTableDetail = MyProject.MyForms.Create__Instance__<PivotTableDetail>(this.m_PivotTableDetail);
					return this.m_PivotTableDetail;
				}
				set
				{
					if (value != this.m_PivotTableDetail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PivotTableDetail>(ref this.m_PivotTableDetail);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000011 RID: 17 RVA: 0x0000AE54 File Offset: 0x00009054
			// (set) Token: 0x0600002C RID: 44 RVA: 0x000021CC File Offset: 0x000003CC
			public PivotTableView PivotTableView
			{
				get
				{
					this.m_PivotTableView = MyProject.MyForms.Create__Instance__<PivotTableView>(this.m_PivotTableView);
					return this.m_PivotTableView;
				}
				set
				{
					if (value != this.m_PivotTableView)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PivotTableView>(ref this.m_PivotTableView);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000012 RID: 18 RVA: 0x0000AE7C File Offset: 0x0000907C
			// (set) Token: 0x0600002D RID: 45 RVA: 0x000021F3 File Offset: 0x000003F3
			public PrintView PrintView
			{
				get
				{
					this.m_PrintView = MyProject.MyForms.Create__Instance__<PrintView>(this.m_PrintView);
					return this.m_PrintView;
				}
				set
				{
					if (value != this.m_PrintView)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PrintView>(ref this.m_PrintView);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000013 RID: 19 RVA: 0x0000AEA4 File Offset: 0x000090A4
			// (set) Token: 0x0600002E RID: 46 RVA: 0x0000221A File Offset: 0x0000041A
			public PrintZoomSet PrintZoomSet
			{
				get
				{
					this.m_PrintZoomSet = MyProject.MyForms.Create__Instance__<PrintZoomSet>(this.m_PrintZoomSet);
					return this.m_PrintZoomSet;
				}
				set
				{
					if (value != this.m_PrintZoomSet)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PrintZoomSet>(ref this.m_PrintZoomSet);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000014 RID: 20 RVA: 0x0000AECC File Offset: 0x000090CC
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00002241 File Offset: 0x00000441
			public progress progress
			{
				get
				{
					this.m_progress = MyProject.MyForms.Create__Instance__<progress>(this.m_progress);
					return this.m_progress;
				}
				set
				{
					if (value != this.m_progress)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<progress>(ref this.m_progress);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000015 RID: 21 RVA: 0x0000AEF4 File Offset: 0x000090F4
			// (set) Token: 0x06000030 RID: 48 RVA: 0x00002268 File Offset: 0x00000468
			public progress2 progress2
			{
				get
				{
					this.m_progress2 = MyProject.MyForms.Create__Instance__<progress2>(this.m_progress2);
					return this.m_progress2;
				}
				set
				{
					if (value != this.m_progress2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<progress2>(ref this.m_progress2);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000016 RID: 22 RVA: 0x0000AF1C File Offset: 0x0000911C
			// (set) Token: 0x06000031 RID: 49 RVA: 0x0000228F File Offset: 0x0000048F
			public progressexcel progressexcel
			{
				get
				{
					this.m_progressexcel = MyProject.MyForms.Create__Instance__<progressexcel>(this.m_progressexcel);
					return this.m_progressexcel;
				}
				set
				{
					if (value != this.m_progressexcel)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<progressexcel>(ref this.m_progressexcel);
					}
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000017 RID: 23 RVA: 0x0000AF44 File Offset: 0x00009144
			// (set) Token: 0x06000032 RID: 50 RVA: 0x000022B6 File Offset: 0x000004B6
			public ReportPageSetup ReportPageSetup
			{
				get
				{
					this.m_ReportPageSetup = MyProject.MyForms.Create__Instance__<ReportPageSetup>(this.m_ReportPageSetup);
					return this.m_ReportPageSetup;
				}
				set
				{
					if (value != this.m_ReportPageSetup)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ReportPageSetup>(ref this.m_ReportPageSetup);
					}
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000018 RID: 24 RVA: 0x0000AF6C File Offset: 0x0000916C
			// (set) Token: 0x06000033 RID: 51 RVA: 0x000022DD File Offset: 0x000004DD
			public reportprint reportprint
			{
				get
				{
					this.m_reportprint = MyProject.MyForms.Create__Instance__<reportprint>(this.m_reportprint);
					return this.m_reportprint;
				}
				set
				{
					if (value != this.m_reportprint)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<reportprint>(ref this.m_reportprint);
					}
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000019 RID: 25 RVA: 0x0000AF94 File Offset: 0x00009194
			// (set) Token: 0x06000034 RID: 52 RVA: 0x00002304 File Offset: 0x00000504
			public ReportWizard ReportWizard
			{
				get
				{
					this.m_ReportWizard = MyProject.MyForms.Create__Instance__<ReportWizard>(this.m_ReportWizard);
					return this.m_ReportWizard;
				}
				set
				{
					if (value != this.m_ReportWizard)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ReportWizard>(ref this.m_ReportWizard);
					}
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600001A RID: 26 RVA: 0x0000AFBC File Offset: 0x000091BC
			// (set) Token: 0x06000035 RID: 53 RVA: 0x0000232B File Offset: 0x0000052B
			public savemmdialog savemmdialog
			{
				get
				{
					this.m_savemmdialog = MyProject.MyForms.Create__Instance__<savemmdialog>(this.m_savemmdialog);
					return this.m_savemmdialog;
				}
				set
				{
					if (value != this.m_savemmdialog)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<savemmdialog>(ref this.m_savemmdialog);
					}
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600001B RID: 27 RVA: 0x0000AFE4 File Offset: 0x000091E4
			// (set) Token: 0x06000036 RID: 54 RVA: 0x00002352 File Offset: 0x00000552
			public SetNumberFormat SetNumberFormat
			{
				get
				{
					this.m_SetNumberFormat = MyProject.MyForms.Create__Instance__<SetNumberFormat>(this.m_SetNumberFormat);
					return this.m_SetNumberFormat;
				}
				set
				{
					if (value != this.m_SetNumberFormat)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SetNumberFormat>(ref this.m_SetNumberFormat);
					}
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600001C RID: 28 RVA: 0x0000B00C File Offset: 0x0000920C
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002379 File Offset: 0x00000579
			public showpreview showpreview
			{
				get
				{
					this.m_showpreview = MyProject.MyForms.Create__Instance__<showpreview>(this.m_showpreview);
					return this.m_showpreview;
				}
				set
				{
					if (value != this.m_showpreview)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<showpreview>(ref this.m_showpreview);
					}
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600001D RID: 29 RVA: 0x0000B034 File Offset: 0x00009234
			// (set) Token: 0x06000038 RID: 56 RVA: 0x000023A0 File Offset: 0x000005A0
			public SimpleReportAddHeader SimpleReportAddHeader
			{
				get
				{
					this.m_SimpleReportAddHeader = MyProject.MyForms.Create__Instance__<SimpleReportAddHeader>(this.m_SimpleReportAddHeader);
					return this.m_SimpleReportAddHeader;
				}
				set
				{
					if (value != this.m_SimpleReportAddHeader)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SimpleReportAddHeader>(ref this.m_SimpleReportAddHeader);
					}
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600001E RID: 30 RVA: 0x0000B05C File Offset: 0x0000925C
			// (set) Token: 0x06000039 RID: 57 RVA: 0x000023C7 File Offset: 0x000005C7
			public SimpleReportPrint SimpleReportPrint
			{
				get
				{
					this.m_SimpleReportPrint = MyProject.MyForms.Create__Instance__<SimpleReportPrint>(this.m_SimpleReportPrint);
					return this.m_SimpleReportPrint;
				}
				set
				{
					if (value != this.m_SimpleReportPrint)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SimpleReportPrint>(ref this.m_SimpleReportPrint);
					}
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600001F RID: 31 RVA: 0x0000B084 File Offset: 0x00009284
			// (set) Token: 0x0600003A RID: 58 RVA: 0x000023EE File Offset: 0x000005EE
			public SimpleReportSet SimpleReportSet
			{
				get
				{
					this.m_SimpleReportSet = MyProject.MyForms.Create__Instance__<SimpleReportSet>(this.m_SimpleReportSet);
					return this.m_SimpleReportSet;
				}
				set
				{
					if (value != this.m_SimpleReportSet)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SimpleReportSet>(ref this.m_SimpleReportSet);
					}
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000020 RID: 32 RVA: 0x0000B0AC File Offset: 0x000092AC
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002415 File Offset: 0x00000615
			public SimpleReportTextEdit SimpleReportTextEdit
			{
				get
				{
					this.m_SimpleReportTextEdit = MyProject.MyForms.Create__Instance__<SimpleReportTextEdit>(this.m_SimpleReportTextEdit);
					return this.m_SimpleReportTextEdit;
				}
				set
				{
					if (value != this.m_SimpleReportTextEdit)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SimpleReportTextEdit>(ref this.m_SimpleReportTextEdit);
					}
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000021 RID: 33 RVA: 0x0000B0D4 File Offset: 0x000092D4
			// (set) Token: 0x0600003C RID: 60 RVA: 0x0000243C File Offset: 0x0000063C
			public tempform tempform
			{
				get
				{
					this.m_tempform = MyProject.MyForms.Create__Instance__<tempform>(this.m_tempform);
					return this.m_tempform;
				}
				set
				{
					if (value != this.m_tempform)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<tempform>(ref this.m_tempform);
					}
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000022 RID: 34 RVA: 0x0000B0FC File Offset: 0x000092FC
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00002463 File Offset: 0x00000663
			public TextEdit TextEdit
			{
				get
				{
					this.m_TextEdit = MyProject.MyForms.Create__Instance__<TextEdit>(this.m_TextEdit);
					return this.m_TextEdit;
				}
				set
				{
					if (value != this.m_TextEdit)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TextEdit>(ref this.m_TextEdit);
					}
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000023 RID: 35 RVA: 0x0000B124 File Offset: 0x00009324
			// (set) Token: 0x0600003E RID: 62 RVA: 0x0000248A File Offset: 0x0000068A
			public TextEdit_Express TextEdit_Express
			{
				get
				{
					this.m_TextEdit_Express = MyProject.MyForms.Create__Instance__<TextEdit_Express>(this.m_TextEdit_Express);
					return this.m_TextEdit_Express;
				}
				set
				{
					if (value != this.m_TextEdit_Express)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TextEdit_Express>(ref this.m_TextEdit_Express);
					}
				}
			}

			// Token: 0x0600003F RID: 63 RVA: 0x0000B14C File Offset: 0x0000934C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				T result;
				if (Instance != null && !Instance.IsDisposed)
				{
					result = Instance;
				}
				else
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						result = Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return result;
			}

			// Token: 0x06000040 RID: 64 RVA: 0x0000B258 File Offset: 0x00009458
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000041 RID: 65 RVA: 0x000024B1 File Offset: 0x000006B1
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000042 RID: 66 RVA: 0x0000B280 File Offset: 0x00009480
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000043 RID: 67 RVA: 0x0000B29C File Offset: 0x0000949C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000044 RID: 68 RVA: 0x0000B2B4 File Offset: 0x000094B4
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000045 RID: 69 RVA: 0x0000B2D0 File Offset: 0x000094D0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000006 RID: 6
			public AboutBox1 m_AboutBox1;

			// Token: 0x04000007 RID: 7
			public ChooseExcelSheet m_ChooseExcelSheet;

			// Token: 0x04000008 RID: 8
			public DataGridViewPrintSet m_DataGridViewPrintSet;

			// Token: 0x04000009 RID: 9
			public draftset m_draftset;

			// Token: 0x0400000A RID: 10
			public FormDsgn m_FormDsgn;

			// Token: 0x0400000B RID: 11
			public mywait m_mywait;

			// Token: 0x0400000C RID: 12
			public OpenmmDialog m_OpenmmDialog;

			// Token: 0x0400000D RID: 13
			public PivotTableDetail m_PivotTableDetail;

			// Token: 0x0400000E RID: 14
			public PivotTableView m_PivotTableView;

			// Token: 0x0400000F RID: 15
			public PrintView m_PrintView;

			// Token: 0x04000010 RID: 16
			public PrintZoomSet m_PrintZoomSet;

			// Token: 0x04000011 RID: 17
			public progress m_progress;

			// Token: 0x04000012 RID: 18
			public progress2 m_progress2;

			// Token: 0x04000013 RID: 19
			public progressexcel m_progressexcel;

			// Token: 0x04000014 RID: 20
			public ReportPageSetup m_ReportPageSetup;

			// Token: 0x04000015 RID: 21
			public reportprint m_reportprint;

			// Token: 0x04000016 RID: 22
			public ReportWizard m_ReportWizard;

			// Token: 0x04000017 RID: 23
			public savemmdialog m_savemmdialog;

			// Token: 0x04000018 RID: 24
			public SetNumberFormat m_SetNumberFormat;

			// Token: 0x04000019 RID: 25
			public showpreview m_showpreview;

			// Token: 0x0400001A RID: 26
			public SimpleReportAddHeader m_SimpleReportAddHeader;

			// Token: 0x0400001B RID: 27
			public SimpleReportPrint m_SimpleReportPrint;

			// Token: 0x0400001C RID: 28
			public SimpleReportSet m_SimpleReportSet;

			// Token: 0x0400001D RID: 29
			public SimpleReportTextEdit m_SimpleReportTextEdit;

			// Token: 0x0400001E RID: 30
			public tempform m_tempform;

			// Token: 0x0400001F RID: 31
			public TextEdit m_TextEdit;

			// Token: 0x04000020 RID: 32
			public TextEdit_Express m_TextEdit_Express;

			// Token: 0x04000021 RID: 33
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000046 RID: 70 RVA: 0x0000B2E8 File Offset: 0x000094E8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000047 RID: 71 RVA: 0x0000B304 File Offset: 0x00009504
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000048 RID: 72 RVA: 0x0000B31C File Offset: 0x0000951C
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000049 RID: 73 RVA: 0x0000B338 File Offset: 0x00009538
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600004A RID: 74 RVA: 0x0000B350 File Offset: 0x00009550
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600004B RID: 75 RVA: 0x0000B370 File Offset: 0x00009570
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600004C RID: 76 RVA: 0x000024B1 File Offset: 0x000006B1
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600004D RID: 77 RVA: 0x0000B38C File Offset: 0x0000958C
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					T t = this.m_Context.Value;
					if (t == null)
					{
						t = Activator.CreateInstance<T>();
						this.m_Context.Value = t;
					}
					return t;
				}
			}

			// Token: 0x0600004E RID: 78 RVA: 0x000024B9 File Offset: 0x000006B9
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
				this.m_Context = new ContextValue<T>();
			}

			// Token: 0x04000022 RID: 34
			private readonly ContextValue<T> m_Context;
		}
	}
}
