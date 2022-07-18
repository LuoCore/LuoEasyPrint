using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace LuoEasyPrint
{
    // Token: 0x02000016 RID: 22
    [Description("窗口程序中使用的简单报表组件，用于新建、修改报表模板以及根据报表模板和DataGridView对象生成打印预览结果或直接打印(net2.0)")]
    [ToolboxBitmap(typeof(EasyReport), "NewReport.bmp")]
    [Guid("2FD8184D-2874-40cf-876E-36DA63AD2691")]
    public class EasyReport : Component
    {
        // Token: 0x0600050C RID: 1292 RVA: 0x00003756 File Offset: 0x00001956
        [DebuggerNonUserCode]
        public EasyReport(IContainer container) : this()
        {
            if (container != null)
            {
                container.Add(this);
            }
        }

        // Token: 0x0600050D RID: 1293 RVA: 0x0002ED28 File Offset: 0x0002CF28
        [DebuggerNonUserCode]
        public EasyReport()
        {
            base.Disposed += this.EasyReport_Disposed;
            this.myReportFile = "";
            this.mydgv = null;
            this.mycs = null;
            this.myisshowprogress = true;
            this.myishowprintstatusdialog = true;
            this.myisuseAPIprintDialog = true;
            this.myisdrawmargin = false;
            this.myenablesaveaspdf = true;
            this.myenablesaveasimage = true;
            this._printcopys = 1;
            this.myPYx = 0f;
            this.myPYy = 0f;
            this.InitializeComponent();
        }

        // Token: 0x0600050E RID: 1294 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Token: 0x0600050F RID: 1295 RVA: 0x00003768 File Offset: 0x00001968
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
        }

        // Token: 0x17000209 RID: 521
        // (get) Token: 0x06000510 RID: 1296 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
        // (set) Token: 0x06000511 RID: 1297 RVA: 0x00003775 File Offset: 0x00001975
        [Description("设置或获取一个值，用于指示控件在打印时的默认打印份数")]
        public short PrintCopys
        {
            get
            {
                return this._printcopys;
            }
            set
            {
                if (value > 0)
                {
                    this._printcopys = value;
                }
            }
        }

        // Token: 0x1700020A RID: 522
        // (get) Token: 0x06000512 RID: 1298 RVA: 0x0002EE0C File Offset: 0x0002D00C
        // (set) Token: 0x06000513 RID: 1299 RVA: 0x00003782 File Offset: 0x00001982
        [Description("设置或获取X位置的偏移，以百分之一厘米为计量单位，正数表示向右偏移，负数表示向左偏移")]
        public float OffsetX
        {
            get
            {
                return this.myPYx;
            }
            set
            {
                this.myPYx = value;
            }
        }

        // Token: 0x1700020B RID: 523
        // (get) Token: 0x06000514 RID: 1300 RVA: 0x0002EE24 File Offset: 0x0002D024
        // (set) Token: 0x06000515 RID: 1301 RVA: 0x0000378B File Offset: 0x0000198B
        [Description("设置或获取Y位置的偏移，以百分之一厘米为计量单位，正数表示向下偏移，负数表示向上偏移")]
        public float OffsetY
        {
            get
            {
                return this.myPYy;
            }
            set
            {
                this.myPYy = value;
            }
        }

        // Token: 0x1700020C RID: 524
        // (get) Token: 0x06000516 RID: 1302 RVA: 0x0002EE3C File Offset: 0x0002D03C
        // (set) Token: 0x06000517 RID: 1303 RVA: 0x00003794 File Offset: 0x00001994
        [Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为PDF 功能是否可用")]
        public bool EnableSaveAsPDF
        {
            get
            {
                return this.myenablesaveaspdf;
            }
            set
            {
                this.myenablesaveaspdf = value;
            }
        }

        // Token: 0x1700020D RID: 525
        // (get) Token: 0x06000518 RID: 1304 RVA: 0x0002EE50 File Offset: 0x0002D050
        // (set) Token: 0x06000519 RID: 1305 RVA: 0x0000379D File Offset: 0x0000199D
        [Description("设置一个值，指示打印预览界面工具栏 保存 按钮下的 保存为图片 功能是否可用")]
        public bool EnableSaveAsImage
        {
            get
            {
                return this.myenablesaveasimage;
            }
            set
            {
                this.myenablesaveasimage = value;
            }
        }

        // Token: 0x1700020E RID: 526
        // (get) Token: 0x0600051A RID: 1306 RVA: 0x0002EE64 File Offset: 0x0002D064
        // (set) Token: 0x0600051B RID: 1307 RVA: 0x000037A6 File Offset: 0x000019A6
        [Description("设置或获取一个值，指示是否在打印预览时画出页边距")]
        public bool IsDrawmargin
        {
            get
            {
                return this.myisdrawmargin;
            }
            set
            {
                this.myisdrawmargin = value;
            }
        }

        // Token: 0x1700020F RID: 527
        // (get) Token: 0x0600051C RID: 1308 RVA: 0x0002EE78 File Offset: 0x0002D078
        // (set) Token: 0x0600051D RID: 1309 RVA: 0x000037AF File Offset: 0x000019AF
        [Description("指示是否使用调用API函数的页面设置和打印机选择对话框，为TRUE表示使用API的，为FALSE表示使用.NET自身的。如果没计划使用自定义纸张进行打印，建议设置为FALSE")]
        public bool IsUseAPIprintDialog
        {
            get
            {
                return this.myisuseAPIprintDialog;
            }
            set
            {
                this.myisuseAPIprintDialog = value;
            }
        }

        // Token: 0x17000210 RID: 528
        // (get) Token: 0x0600051E RID: 1310 RVA: 0x0002EE8C File Offset: 0x0002D08C
        // (set) Token: 0x0600051F RID: 1311 RVA: 0x000037B8 File Offset: 0x000019B8
        [Description("指示在发送到打印机打印时，是否显示一个指示正在打印的状态窗口")]
        public bool IsShowPrintStatusDialog
        {
            get
            {
                return this.myishowprintstatusdialog;
            }
            set
            {
                this.myishowprintstatusdialog = value;
            }
        }

        // Token: 0x17000211 RID: 529
        // (get) Token: 0x06000520 RID: 1312 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
        // (set) Token: 0x06000521 RID: 1313 RVA: 0x000037C1 File Offset: 0x000019C1
        [Description("指示是否显示打印预览前程序预处理的进度条")]
        public bool IsShowProgess
        {
            get
            {
                return this.myisshowprogress;
            }
            set
            {
                this.myisshowprogress = value;
            }
        }

        // Token: 0x06000522 RID: 1314 RVA: 0x000037CA File Offset: 0x000019CA
        public void SetReportFile(string rptfile)
        {
            this.myReportFile = rptfile;
        }

        // Token: 0x06000523 RID: 1315 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
        public void SetReportDataSource(DataGridView dgv)
        {
            if (this.mydgv != null)
            {
                this.mydgv.Dispose();
            }
            if (dgv != null)
            {
                this.mydgv = new DataGridView();
                this.mydgv.AllowUserToAddRows = false;
                Module1.CopyDataGridViewShowStatus(dgv, this.mydgv, false);
            }
            else
            {
                this.mydgv = null;
            }
        }

        // Token: 0x06000524 RID: 1316 RVA: 0x0002EF04 File Offset: 0x0002D104
        public void SetReportDataSource(DataTable tb)
        {
            if (this.mydgv != null)
            {
                this.mydgv.Dispose();
                this.mydgv = null;
            }
            if (tb != null)
            {
                this.mydgv = new DataGridView();
                this.mydgv.AllowUserToAddRows = false;
                tempform tempform = new tempform();
                tempform.dd.DataSource = null;
                tempform.dd.DataSource = tb;
                Module1.CopyDataGridView(tempform.dd, this.mydgv);
                tempform.Dispose();
            }
            else
            {
                this.mydgv = null;
            }
        }

        // Token: 0x06000525 RID: 1317 RVA: 0x000037D3 File Offset: 0x000019D3
        public void SetReportVar(string varname, Image varval)
        {
            if (varval == null)
            {
                this.SetReportVar(varname, "");
            }
            else
            {
                this.SetReportVar(varname, Module1.ConvertImageToString(varval));
            }
        }

        // Token: 0x06000526 RID: 1318 RVA: 0x000037F3 File Offset: 0x000019F3
        public void SetReportVar(string varname, string varval)
        {
            if (this.mycs == null)
            {
                this.mycs = new Hashtable();
            }
            this.mycs[varname] = varval;
        }

        // Token: 0x06000527 RID: 1319 RVA: 0x00003815 File Offset: 0x00001A15
        public void SetReportVar(Hashtable hstable)
        {
            if (hstable != null)
            {
                this.mycs = (Hashtable)hstable.Clone();
            }
            else
            {
                this.mycs = null;
            }
        }

        // Token: 0x06000528 RID: 1320 RVA: 0x0002EF88 File Offset: 0x0002D188
        public void CreateReport()
        {
            if (MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                if (Interaction.MsgBox("打印模板文件〖" + this.myReportFile + "〗已经存在，继续创建会覆盖该文件，您确认要继续吗？", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                {
                    return;
                }
                MyProject.Computer.FileSystem.DeleteFile(this.myReportFile);
            }
            FormDsgn formDsgn = new FormDsgn();
            formDsgn.dgv1 = this.mydgv;
            formDsgn.mycs = this.mycs;
            formDsgn.MbToOpen = this.myReportFile;
            formDsgn.ShowDialog();
            formDsgn.Dispose();
        }

        // Token: 0x06000529 RID: 1321 RVA: 0x0002F01C File Offset: 0x0002D21C
        public void CreateReportWizard()
        {
            if (this.mydgv == null)
            {
                Interaction.MsgBox("不能使用报表模板创建向导，因为您尚未用SetReportDataSource函数指定报表数据源\r\n报表模板创建向导主要用于有数据源的报表模板的创建", MsgBoxStyle.OkOnly, "提示信息");
            }
            else if (this.mydgv.Columns.Count <= 0)
            {
                Interaction.MsgBox("不能使用报表模板创建向导，您指定的报表数据源是空的，没有数据结构（即ＣolumnCount为０\u3000）\r\n报表模板创建向导主要用于有数据源的报表模板的创建", MsgBoxStyle.OkOnly, "提示信息");
            }
            else
            {
                ReportWizard reportWizard = new ReportWizard();
                DataGridView dataGridView = new DataGridView();
                Module1.CopyDataGridView(this.mydgv, dataGridView);
                Module1.DelDGVAllUnvisibleCols(dataGridView);
                reportWizard.dgvtoprint = dataGridView;
                reportWizard.mycs = this.mycs;
                reportWizard.mbname = this.myReportFile;
                reportWizard.ShowDialog();
                reportWizard.Dispose();
                dataGridView.Dispose();
            }
        }

        // Token: 0x0600052A RID: 1322 RVA: 0x0002F0BC File Offset: 0x0002D2BC
        public void EditReport()
        {
            if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                Interaction.MsgBox("打印报表模板文件〖" + this.myReportFile + "〗不存在，因此无法修改", MsgBoxStyle.OkOnly, "提示信息");
            }
            else
            {
                FormDsgn formDsgn = new FormDsgn();
                formDsgn.dgv1 = this.mydgv;
                formDsgn.mycs = this.mycs;
                formDsgn.MbToOpen = this.myReportFile;
                formDsgn.ShowDialog();
                formDsgn.Dispose();
            }
        }

        // Token: 0x0600052B RID: 1323 RVA: 0x0002F13C File Offset: 0x0002D33C
        public string GetReportString(bool istd)
        {
            string result;
            if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                Interaction.MsgBox("打印报表模板文件〖" + this.myReportFile + "〗不存在，因此无法打印", MsgBoxStyle.OkOnly, "提示信息");
                result = "";
            }
            else
            {
                reportprint reportprint = new reportprint();
                reportprint.reportname = this.myReportFile;
                reportprint.dgv1 = this.mydgv;
                reportprint.myvar = this.mycs;
                reportprint.IsTd = istd;
                reportprint.CanEditReport = false;
                reportprint.IsImmediatePrint = false;
                reportprint.IsGetReoprtString = true;
                reportprint.isresetpagemargin = false;
                reportprint.myisshowprogress = this.myisshowprogress;
                ControlDesign controlDesign = new ControlDesign();
                controlDesign.myvar = this.mycs;
                if (!controlDesign.OpenMb(this.mydgv, this.myReportFile, true))
                {
                    Interaction.MsgBox("无法打印，打印模板文件〖" + this.myReportFile + "〗打开失败！可能格式不正确或文件被破坏", MsgBoxStyle.OkOnly, "提示信息");
                    reportprint.Dispose();
                    controlDesign.Dispose();
                    result = null;
                }
                else
                {
                    reportprint.cd = controlDesign;
                    reportprint.ShowInTaskbar = false;
                    reportprint.MyStart();
                    string text = reportprint.p.SaveReportAsString();
                    reportprint.Dispose();
                    controlDesign.Dispose();
                    result = text;
                }
            }
            return result;
        }

        // Token: 0x0600052C RID: 1324 RVA: 0x0002F26C File Offset: 0x0002D46C
        public string GetReportString(bool istd, float leftmargin, float rightmargin, float topmargin, float bottommargin)
        {
            string result;
            if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                Interaction.MsgBox("打印报表模板文件〖" + this.myReportFile + "〗不存在，因此无法打印", MsgBoxStyle.OkOnly, "提示信息");
                result = "";
            }
            else
            {
                reportprint reportprint = new reportprint();
                reportprint.reportname = this.myReportFile;
                reportprint.dgv1 = this.mydgv;
                reportprint.myvar = this.mycs;
                reportprint.IsTd = istd;
                reportprint.CanEditReport = false;
                reportprint.IsImmediatePrint = false;
                reportprint.IsGetReoprtString = true;
                reportprint.isresetpagemargin = true;
                reportprint.leftmargin = leftmargin;
                reportprint.rightmargin = rightmargin;
                reportprint.topmargin = topmargin;
                reportprint.bottommargin = bottommargin;
                ControlDesign controlDesign = new ControlDesign();
                controlDesign.myvar = this.mycs;
                if (!controlDesign.OpenMb(this.mydgv, this.myReportFile, true))
                {
                    Interaction.MsgBox("无法打印，打印模板文件〖" + this.myReportFile + "〗打开失败！可能格式不正确或文件被破坏", MsgBoxStyle.OkOnly, "提示信息");
                    reportprint.Dispose();
                    controlDesign.Dispose();
                    result = null;
                }
                else
                {
                    reportprint.cd = controlDesign;
                    reportprint.ShowInTaskbar = false;
                    reportprint.MyStart();
                    string text = reportprint.p.SaveReportAsString();
                    reportprint.Dispose();
                    controlDesign.Dispose();
                    result = text;
                }
            }
            return result;
        }

        // Token: 0x0600052D RID: 1325 RVA: 0x0002F3B0 File Offset: 0x0002D5B0
        public bool PrintReport(bool IsTd, bool CanEditReport)
        {
            return this.PrintReport(IsTd, false, false, CanEditReport);
        }

        // Token: 0x0600052E RID: 1326 RVA: 0x0002F3C8 File Offset: 0x0002D5C8
        public bool PrintReport(bool IsTd, bool IsImmediatePrintToPrinter, bool IsImmediatePrintShowPrinter, bool CanEditReport)
        {
            return this.PrintReport(IsTd, IsImmediatePrintToPrinter, IsImmediatePrintShowPrinter, CanEditReport, "");
        }

        // Token: 0x0600052F RID: 1327 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
        public bool PrintReport(bool IsTd, bool IsImmediatePrintToPrinter, bool IsImmediatePrintShowPrinter, bool CanEditReport, string PrinterName)
        {
            bool result;
            if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                Interaction.MsgBox("打印报表模板文件〖" + this.myReportFile + "〗不存在，因此无法打印", MsgBoxStyle.OkOnly, "提示信息");
                result = false;
            }
            else
            {
                reportprint reportprint = new reportprint();
                reportprint.myprintername = PrinterName;
                reportprint.reportname = this.myReportFile;
                reportprint.dgv1 = this.mydgv;
                reportprint.myvar = this.mycs;
                reportprint.IsTd = IsTd;
                reportprint.IsGetReoprtString = false;
                reportprint.IsImmediatePrint = IsImmediatePrintToPrinter;
                reportprint.IsImmediatePrintShowPrinter = IsImmediatePrintShowPrinter;
                reportprint.IsUseAPIprintDialog = this.IsUseAPIprintDialog;
                reportprint.CanEditReport = CanEditReport;
                reportprint.myisshowprintstatusdialog = this.myishowprintstatusdialog;
                reportprint.myisshowprogress = this.myisshowprogress;
                reportprint.myisdrawmargin = this.myisdrawmargin;
                reportprint.isresetpagemargin = false;
                reportprint.myPYx = this.OffsetX;
                reportprint.myPYy = this.OffsetY;
                reportprint._printcopys = this.PrintCopys;
                reportprint.myenablesaveasimage = this.myenablesaveasimage;
                reportprint.myenablesaveaspdf = this.myenablesaveaspdf;
                ControlDesign controlDesign = new ControlDesign();
                controlDesign.myvar = this.mycs;
                progress2 progress = new progress2();
                progress.Label1.Text = "正在读取报表模板……请稍侯";
                if (this.IsShowProgess)
                {
                    progress.Show();
                    Application.DoEvents();
                }
                if (!controlDesign.OpenMb(this.mydgv, this.myReportFile, true))
                {
                    try
                    {
                        progress.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                    if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
                    {
                        Interaction.MsgBox("无法打印，打印模板文件〖" + this.myReportFile + "〗不存在，请确保模板文件存在且指定绝对路径", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        Interaction.MsgBox("无法打印，打印模板文件〖" + this.myReportFile + "〗打开失败！格式不正确或文件被损坏", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    try
                    {
                        progress.Dispose();
                        reportprint.Dispose();
                        controlDesign.Dispose();
                    }
                    catch (Exception ex2)
                    {
                    }
                    result = false;
                }
                else
                {
                    progress.Close();
                    progress.Dispose();
                    reportprint.cd = controlDesign;
                    if (IsImmediatePrintToPrinter)
                    {
                        reportprint.MyStart();
                        reportprint.ShowInTaskbar = false;
                    }
                    else
                    {
                        reportprint.ShowDialog();
                    }
                    reportprint.Dispose();
                    reportprint = null;
                    controlDesign.Dispose();
                    controlDesign = null;
                    result = true;
                }
            }
            return result;
        }

        // Token: 0x06000530 RID: 1328 RVA: 0x0002F644 File Offset: 0x0002D844
        public bool PrintReport(bool IsTd, bool IsImmediatePrintToPrinter, bool IsImmediatePrintShowPrinter, bool CanEditReport, float leftmargin, float rightmargin, float topmargin, float bottommargin)
        {
            return this.PrintReport(IsTd, IsImmediatePrintToPrinter, IsImmediatePrintShowPrinter, CanEditReport, "", leftmargin, rightmargin, topmargin, bottommargin);
        }

        // Token: 0x06000531 RID: 1329 RVA: 0x0002F66C File Offset: 0x0002D86C
        public bool PrintReport(bool IsTd, bool IsImmediatePrintToPrinter, bool IsImmediatePrintShowPrinter, bool CanEditReport, string PrinterName, float leftmargin, float rightmargin, float topmargin, float bottommargin)
        {
            bool result;
            if (!MyProject.Computer.FileSystem.FileExists(this.myReportFile))
            {
                Interaction.MsgBox("打印报表模板文件〖" + this.myReportFile + "〗不存在，因此无法打印", MsgBoxStyle.OkOnly, "提示信息");
                result = false;
            }
            else
            {
                reportprint reportprint = new reportprint();
                reportprint.myprintername = PrinterName;
                reportprint.reportname = this.myReportFile;
                reportprint.dgv1 = this.mydgv;
                reportprint.myvar = this.mycs;
                reportprint.IsTd = IsTd;
                reportprint.IsGetReoprtString = false;
                reportprint.IsImmediatePrint = IsImmediatePrintToPrinter;
                reportprint.IsImmediatePrintShowPrinter = IsImmediatePrintShowPrinter;
                reportprint.IsUseAPIprintDialog = this.IsUseAPIprintDialog;
                reportprint.CanEditReport = CanEditReport;
                reportprint.myisshowprintstatusdialog = this.myishowprintstatusdialog;
                reportprint.myisshowprogress = this.myisshowprogress;
                reportprint.myPYx = this.OffsetX;
                reportprint.myPYy = this.OffsetY;
                reportprint._printcopys = this.PrintCopys;
                reportprint.myenablesaveasimage = this.myenablesaveasimage;
                reportprint.myenablesaveaspdf = this.myenablesaveaspdf;
                reportprint.isresetpagemargin = true;
                reportprint.leftmargin = leftmargin;
                reportprint.rightmargin = rightmargin;
                reportprint.topmargin = topmargin;
                reportprint.bottommargin = bottommargin;
                ControlDesign controlDesign = new ControlDesign();
                controlDesign.myvar = this.mycs;
                progress2 progress = new progress2();
                progress.Label1.Text = "正在读取报表模板……请稍侯";
                if (this.IsShowProgess)
                {
                    progress.Show();
                    Application.DoEvents();
                }
                if (!controlDesign.OpenMb(this.mydgv, this.myReportFile, true))
                {
                    try
                    {
                        progress.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                    Interaction.MsgBox("无法打印，打印模板文件〖" + this.myReportFile + "〗打开失败！可能格式不正确或文件被损坏", MsgBoxStyle.OkOnly, "提示信息");
                    try
                    {
                        progress.Dispose();
                        reportprint.Dispose();
                        controlDesign.Dispose();
                    }
                    catch (Exception ex2)
                    {
                    }
                    result = false;
                }
                else
                {
                    progress.Close();
                    progress.Dispose();
                    reportprint.cd = controlDesign;
                    if (IsImmediatePrintToPrinter)
                    {
                        reportprint.MyStart();
                        reportprint.ShowInTaskbar = false;
                    }
                    else
                    {
                        reportprint.ShowDialog();
                    }
                    reportprint.Dispose();
                    controlDesign.Dispose();
                    result = true;
                }
            }
            return result;
        }

        // Token: 0x06000532 RID: 1330 RVA: 0x0002F89C File Offset: 0x0002DA9C
        private void EasyReport_Disposed(object sender, EventArgs e)
        {
            try
            {
                this.mydgv = null;
                if (this.mycs != null)
                    this.mycs.Clear();
                this.mycs = null;
                this.myReportFile = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x0400034F RID: 847
        private IContainer components;

        // Token: 0x04000350 RID: 848
        private string myReportFile;

        // Token: 0x04000351 RID: 849
        private DataGridView mydgv;

        // Token: 0x04000352 RID: 850
        private Hashtable mycs;

        // Token: 0x04000353 RID: 851
        private bool myisshowprogress;

        // Token: 0x04000354 RID: 852
        private bool myishowprintstatusdialog;

        // Token: 0x04000355 RID: 853
        private bool myisuseAPIprintDialog;

        // Token: 0x04000356 RID: 854
        private bool myisdrawmargin;

        // Token: 0x04000357 RID: 855
        private bool myenablesaveaspdf;

        // Token: 0x04000358 RID: 856
        private bool myenablesaveasimage;

        // Token: 0x04000359 RID: 857
        private short _printcopys;

        // Token: 0x0400035A RID: 858
        private float myPYx;

        // Token: 0x0400035B RID: 859
        private float myPYy;
    }
}
