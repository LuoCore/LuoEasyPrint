using iText.Commons.Actions.Data;
using iText.Kernel.XMP.Impl;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuoEasyPrint
{
    [ToolboxBitmap(typeof(DotNetPrint), "PRINT.BMP")]
    [DefaultEvent("PrintDocument")]
    [Description("可混合打印窗口中的一个或多个DataGridView表格及文本和图片等的可视化打印控件。注意请不要被名称误解了，控件在.NET环境下的C#等语言中也是可以使用的(6.01版，net2.0)")]
    public partial class DotNetPrint : UserControl, objsafe.IObjectSafety
    {
        public DotNetPrint()
        {
            InitializeComponent();
        }

        private bool myouterborder;
        private short _printcopys;
        private bool myenablecgprint;
        private bool myenablesaveaspdf;
        private bool myenablesaveasimage;
        private bool myisautoadjustprintermargin;
        private float myPYx;
        private float myPYy;
        private bool myisneedprintpageheaderandfooter;
        private Color myouterbordercolor;
        private float myouterborderwidth;
        private float thedoublelinespace;
        private bool myisusedoubleline;
        private bool myisdrawtablefootereverypage;
        private bool myisautoaddemptyrow;
        private bool myisshowerrormsg;


        public void GetInterfaceSafetyOptions(ref Guid iid, ref int pdwSupportedOptions, ref int pdwEnabledOptions)
        {
            pdwSupportedOptions = 3;
            pdwEnabledOptions = 3;
        }

        public void SetInterfaceSafetyOptions(ref Guid iid, int dwOptionSetMask, int dwEnabledOptions)
        {

        }

        [Description("在打印预览前发生（PrintDocument事件前发生），可以在此进行默认页面设置")]
        public event QueryDefaultPageSettingsEventHandler QueryDefaultPageSettings;
        [Description("开始打印，可将要打印的代码写在此事件中（要对每页进行不同的页面设置，请在newpage中指定参数）")]
        public event PrintDocumentEventHandler PrintDocument;
        [Description("页眉页脚打印输出事件，在此事件中可以调用输出页眉页脚的函数打印页眉页脚")]
        public event HeaderFooterOutEventHandler HeaderFooterOut;
        public event EndPrintToPrinterEventHandler EndPrintToPrinter;
        public event BeginPrintEventHandler BeginPrint;
        public event EndPreViewEventHandler EndPreView;
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }

        // Token: 0x17000699 RID: 1689
        // (get) Token: 0x06001308 RID: 4872 RVA: 0x0009449C File Offset: 0x0009269C
        // (set) Token: 0x06001309 RID: 4873 RVA: 0x00006D44 File Offset: 0x00004F44
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

        [Description("设置或获取一个值，用于指示控件工具栏中的\u3000草稿打印\u3000按钮是否可用")]
        public bool EnablePrintDraft
        {
            get
            {
                return this.myenablecgprint;
            }
            set
            {
                this.myenablecgprint = value;
                this.cgprint.Enabled = value;
            }
        }

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

        [Description("设置或获取一个值，用于指示自动校正打印边距。该属性为5.8版新增加  注意：该值默认为true，一般来说，您也应该将该属性设置为true以解决打印预览结果与打印结果位置不一样的问题。 只有在特殊情况下比如原来使用以前版本的打印控件并且经实际打印测试调整好了页边距，为完整保留原打印效果，才将该属性设置为false")]
        public bool IsAutoAdjustPrinterMargin
        {
            get
            {
                return this.myisautoadjustprintermargin;
            }
            set
            {
                this.myisautoadjustprintermargin = value;
            }
        }

        [Description("设置或获取X位置的偏移，以PageUnits指定的值为计量单位，正数表示向右偏移，负数表示向左偏移")]
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

        [Description("设置或获取Y位置的偏移，以PageUnits指定的值为计量单位，正数表示向下偏移，负数表示向上偏移")]
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [Description("指示是否需要处理HeaderFooterOut事件（即是否需要打印页眉与页脚、装订线与水印），如果不需要打印页眉、页脚、水印、装订线，则可以将该属性设置为false，这样可以提高速度。默认情况下，该属性为true")]
        public bool IsNeedPrintPageHeaderAndFooter
        {
            get
            {
                return this.myisneedprintpageheaderandfooter;
            }
            set
            {
                this.myisneedprintpageheaderandfooter = value;
            }
        }

        [Description("纸张背景颜色，也即除纸张外的其余部分的背景颜色")]
        public Color PaperBackColor
        {
            get
            {
                return this.PrintPreviewControl1.BackColor;
            }
            set
            {
                this.PrintPreviewControl1.BackColor = value;
            }
        }

        [Description("前景颜色（也就是打印预览结果中纸张显示的背景颜色，仅对预览有效，不会打印出来）")]
        public Color PaperForeColor
        {
            get
            {
                return this.PrintPreviewControl1.ForeColor;
            }
            set
            {
                this.PrintPreviewControl1.ForeColor = value;
            }
        }

        [Description("表格外边框颜色，仅当OuterBorder为True时有效")]
        public Color OuterBorderColor
        {
            get
            {
                return this.myouterbordercolor;
            }
            set
            {
                this.myouterbordercolor = value;
            }
        }

        [Description("表格外边框宽度，以PageUnits指定的值为计量单位，仅当OuterBorder为True时有效")]
        public float OuterBorderWidth
        {
            get
            {
                return this.myouterborderwidth;
            }
            set
            {
                if (value >= 0f)
                {
                    this.myouterborderwidth = value;
                }
            }
        }

        [Description("指示在用PrintDGV等函数打印DataGridView时，是否在表格外添加外边框。")]
        public bool OuterBorder
        {
            get
            {
                return this.myouterborder;
            }
            set
            {
                this.myouterborder = value;
            }
        }

        [Description("设置或获取双线条打印DGV时双线之间的间距（以PageUnits指定的值为计量单位），仅当以双线条样式调用PrintDGV等函数打印DataGridView时有效（将属性IsUseDoubleLine为true）")]
        public float DoubleLineSpace
        {
            get
            {
                return this.thedoublelinespace;
            }
            set
            {
                if (value >= 0f & value < 10000f)
                {
                    this.thedoublelinespace = value;
                }
            }
        }

        // Token: 0x170006A7 RID: 1703
        // (get) Token: 0x06001324 RID: 4900 RVA: 0x00094614 File Offset: 0x00092814
        // (set) Token: 0x06001325 RID: 4901 RVA: 0x00006DDE File Offset: 0x00004FDE
        [Description("指定在调用PrintDGV等函数打印DataGridView时，是否使用双线框打印")]
        public bool IsUseDoubleLine
        {
            get
            {
                return this.myisusedoubleline;
            }
            set
            {
                this.myisusedoubleline = value;
            }
        }

        // Token: 0x170006A8 RID: 1704
        // (get) Token: 0x06001326 RID: 4902 RVA: 0x00094628 File Offset: 0x00092828
        // (set) Token: 0x06001327 RID: 4903 RVA: 0x00006DE7 File Offset: 0x00004FE7
        [Description("指示打印DataGridView时(如用PrintDGV、PrintDGVPages等函数在指定了表格页脚的情况下,对多栏打印PrintGVCols函数有的情况下无效，对工资条形式打印函数无效），表格页脚是否每一页都打印。为True表示每一页都打印表格页脚，为False表示仅表格的最后一页打印")]
        public bool IsDrawTableFooterEveryPage
        {
            get
            {
                return this.myisdrawtablefootereverypage;
            }
            set
            {
                this.myisdrawtablefootereverypage = value;
            }
        }

        // Token: 0x170006A9 RID: 1705
        // (get) Token: 0x06001328 RID: 4904 RVA: 0x0009463C File Offset: 0x0009283C
        [Browsable(false)]
        [Description("获取一个值，用于指示是否在生成打印预览期间，用户是否单击状态窗口中的取消按钮，取消打印预览的生成")]
        public bool CancelDocument
        {
            get
            {
                return Module1.G_CancelDocument;
            }
        }

        // Token: 0x170006AA RID: 1706
        // (get) Token: 0x06001329 RID: 4905 RVA: 0x00094650 File Offset: 0x00092850
        // (set) Token: 0x0600132A RID: 4906 RVA: 0x00006DF0 File Offset: 0x00004FF0
        [Description("指示打印DataGridView时，是否自动加添空行以正好填满纸张高度。注意，对工资条打印无效，分栏打印可以自动添加空行，但此时请不要设置表格页脚，不然表格页脚打印位置不正确")]
        public bool IsAutoAddEmptyRow
        {
            get
            {
                return this.myisautoaddemptyrow;
            }
            set
            {
                this.myisautoaddemptyrow = value;
            }
        }

        // Token: 0x170006AB RID: 1707
        // (get) Token: 0x0600132B RID: 4907 RVA: 0x00094664 File Offset: 0x00092864
        // (set) Token: 0x0600132C RID: 4908 RVA: 0x00006DF9 File Offset: 0x00004FF9
        [Browsable(false)]
        public bool IsShowErrorMSG
        {
            get
            {
                return this.myisshowerrormsg;
            }
            set
            {
                this.myisshowerrormsg = value;
            }
        }

        private bool myisneedchecknewpage;
        [Description("在使用DrawCell、DrawText、DrawMultiCell函数进行打印输出时，打印输出前是先自动检查是否需要换页才能打印。如果为True，则在使用这几个函数进行打印前，先检查当前Y位置（不检查X位置）是否超出打印范围需要换页，如果需要则自动换页，再进行打印输出；如果为False则不检测，自动在当前位置继续输出，不管输出结果会不会处在页面范围之外")]
        public bool IsNeedCheckNewPage
        {
            get
            {
                return this.myisneedchecknewpage;
            }
            set
            {
                this.myisneedchecknewpage = value;
            }
        }

        private bool myisdrawpageheaderline;
        [Description("是否在页眉与正文之间画一条横线，以便区分页眉与正文")]
        public bool IsDrawPageHeaderLine
        {
            get
            {
                return this.myisdrawpageheaderline;
            }
            set
            {
                this.myisdrawpageheaderline = value;
            }
        }

        private bool myisdrawpagefooterline;
        [Description("是否在正文与页脚之间画一条横线，以便区分正文与页脚")]
        public bool IsDrawPageFooterLine
        {
            get
            {
                return this.myisdrawpagefooterline;
            }
            set
            {
                this.myisdrawpagefooterline = value;
            }
        }

        private bool myisshowcontextmenu;
        [Description("获取或设置一个值,用于指示是否容许在打印预览界面显示右键快捷菜单")]
        public bool IsShowContextMenu
        {
            get
            {
                return this.myisshowcontextmenu;
            }
            set
            {
                this.myisshowcontextmenu = value;
                if (this.myisshowcontextmenu)
                {
                    this.PrintPreviewControl1.ContextMenuStrip = this.ContextMenuStrip1;
                }
                else
                {
                    this.PrintPreviewControl1.ContextMenuStrip = null;
                }
            }
        }

        private string mywatermarktext;
        [Description("设置要打印水印的文字,为空字符串表示不打印水印")]
        public string WaterMarkText
        {
            get
            {
                return this.mywatermarktext;
            }
            set
            {
                this.mywatermarktext = value;
            }
        }

        private Font mywatermarkfont;
        [Description("设置要打印的水印文字的字体字号")]
        public Font WaterMarkFont
        {
            get
            {
                Font result;
                if (this.mywatermarkfont == null)
                {
                    result = null;
                }
                else
                {
                    result = (Font)this.mywatermarkfont.Clone();
                }
                return result;
            }
            set
            {
                if (value != null)
                {
                    this.mywatermarkfont = (Font)value.Clone();
                }
            }
        }

        private bool mywatermarklandscape;
        [Description("设置要打印的水印的文字方向,TRUE表示水印文字横着打印,为FALSE表示水印文字竖着打印")]
        public bool WaterMarkLandscape
        {
            get
            {
                return this.mywatermarklandscape;
            }
            set
            {
                this.mywatermarklandscape = value;
            }
        }

        private byte mywatermarkopacity;
        [Description("设置要打印的水印文本的透明程度,0表示完全透明,255表示完全不透明")]
        public byte WaterMarkOpacity
        {
            get
            {
                return this.mywatermarkopacity;
            }
            set
            {
                this.mywatermarkopacity = value;
            }
        }

        private Color mywatermarkcolor;
        [Description("设置要打印的水印的文字的前景颜色")]
        public Color WaterMarkColor
        {
            get
            {
                return this.mywatermarkcolor;
            }
            set
            {
                this.mywatermarkcolor = value;
            }
        }

        private bool myisshowprogress;
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
                this.PrintPreviewControl1.IsShowprocessDialog = value;
            }
        }

        private bool myIsShowMessageIfPrinterNotSupportPaper;
        [Description("设置或获取一个值，指示如果打印机不支持当前所使用的纸张，在输出到打印机前是否给出提示信息")]
        public bool IsShowMessageIfPrinterNotSupportPaper
        {
            get
            {
                return this.myIsShowMessageIfPrinterNotSupportPaper;
            }
            set
            {
                this.myIsShowMessageIfPrinterNotSupportPaper = value;
            }
        }

        private bool myisuseAPIprintDialog;
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

        private PageSettings mypagesetting;
        [Description("设置或获取打印所用的纸张(纸张大小总是以百分之一英寸为单位),与PaperKind属性的区别是,此属性允许使用自定义纸张")]
        public PaperSize PaperSize
        {
            get
            {
                return this.mypagesetting.PaperSize;
            }
            set
            {
                if (!this.isstarting && value != null)
                {
                    if (value.Width <= 0 | value.Height <= 0)
                    {
                        value = definepaper.GetPrintForm(this.GetCurrentPrinterName(), value.PaperName);
                    }
                    if (value != null)
                    {
                        try
                        {
                            if (String.Compare(value.PaperName, "", false) == 0)
                            {
                                value.PaperName = "用户自定义(空名称)";
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        this.mypagesetting.PaperSize = value;
                    }
                }
            }
        }

        private bool myIsImmediatePrintNotPreviewShowPrintDialog;
        [Description("如果IsImmediatePrintNotPreview为TRUE，指示在打印前是否显示打印机选择的对话框，为TRUE表示要显示，为FALSE表示不显示，使用当前打印机立即输出到打印机。")]
        public bool IsImmediatePrintNotPreviewShowPrintDialog
        {
            get
            {
                return this.myIsImmediatePrintNotPreviewShowPrintDialog;
            }
            set
            {
                this.myIsImmediatePrintNotPreviewShowPrintDialog = value;
            }
        }

        private bool myisimmediateprintnotpreview;
        [Description("指示在预处理完成后是否立即调用print方法进行打印而不再在预览中显示出来")]
        public bool IsImmediatePrintNotPreview
        {
            get
            {
                return this.myisimmediateprintnotpreview;
            }
            set
            {
                this.myisimmediateprintnotpreview = value;
            }
        }

        private bool myisendpreview;
        [Browsable(false)]
        public bool IsEndPreview
        {
            get
            {
                return this.myisendpreview;
            }
        }

        private bool myIsDGVCellValignmentCenter;
        [Description("打印DataGridView时,单元格文本垂直对齐方式是统一使用居中对齐打印,还是和水平对齐一样都使用DataGridView单元格本身的格式设置")]
        public bool IsDGVCellValignmentCenter
        {
            get
            {
                return this.myIsDGVCellValignmentCenter;
            }
            set
            {
                this.myIsDGVCellValignmentCenter = value;
            }
        }

        private int myshapedepth;
        [Description("用DrawText、DrawCell等函数打印输出文字时，如果最后一个参数textoutstyle不为0(即输出除普通文字外的其他形式的特效文字时),要打印特效文字的深度,计量单位为打印控件的当前单位")]
        public int ShapeDepth
        {
            get
            {
                return this.myshapedepth;
            }
            set
            {
                this.myshapedepth = value;
            }
        }


        [Description("获取或设置一个值，该值指示页面的显示大小，值为 1.0 指示实际大小，为0表示自适应纸张大小,最大值为10(即最大放大10倍)")]
        public double Zoom
        {
            get
            {
                double result;
                if (this.PrintPreviewControl1.AutoZoom)
                {
                    result = 0.0;
                }
                else
                {
                    result = this.PrintPreviewControl1.Zoom;
                }
                return result;
            }
            set
            {
                if (value >= 0.0)
                {
                    if (value * 100.0 < 3.0)
                    {
                        value = 0.03;
                    }
                    if (value > 10.0)
                    {
                        value = 10.0;
                    }
                    this.ToolStripMenuItem.Checked = false;
                    this.ToolStripMenuItem0.Checked = false;
                    this.ToolStripMenuItem1.Checked = false;
                    this.ToolStripMenuItem2.Checked = false;
                    this.ToolStripMenuItem3.Checked = false;
                    this.ToolStripMenuItem4.Checked = false;
                    this.ToolStripMenuItem5.Checked = false;
                    this.ToolStripMenuItem6.Checked = false;
                    this.ToolStripMenuItem7.Checked = false;
                    this.ToolStripMenuItem8.Checked = false;
                    this.ToolStripMenuItem9.Checked = false;
                    this.ToolStripMenuItem10.Checked = false;
                    this.ToolStripMenuItem11.Checked = false;
                    this.PrintPreviewControl1.AutoZoom = false;
                    double num = value;
                    if (num == 0.0)
                    {
                        this.PrintPreviewControl1.AutoZoom = true;
                        this.ToolStripMenuItem10.Checked = true;
                    }
                    else
                    {
                        if (num == 0.1)
                        {
                            this.ToolStripMenuItem11.Checked = true;
                        }
                        else if (num == 0.25)
                        {
                            this.ToolStripMenuItem.Checked = true;
                        }
                        else if (num == 0.5)
                        {
                            this.ToolStripMenuItem0.Checked = true;
                        }
                        else if (num == 0.75)
                        {
                            this.ToolStripMenuItem1.Checked = true;
                        }
                        else if (num == 1.0)
                        {
                            this.ToolStripMenuItem2.Checked = true;
                        }
                        else if (num == 1.25)
                        {
                            this.ToolStripMenuItem3.Checked = true;
                        }
                        else if (num == 1.5)
                        {
                            this.ToolStripMenuItem4.Checked = true;
                        }
                        else if (num == 2.0)
                        {
                            this.ToolStripMenuItem5.Checked = true;
                        }
                        else if (num == 2.5)
                        {
                            this.ToolStripMenuItem6.Checked = true;
                        }
                        else if (num == 3.0)
                        {
                            this.ToolStripMenuItem7.Checked = true;
                        }
                        else if (num == 4.0)
                        {
                            this.ToolStripMenuItem8.Checked = true;
                        }
                        else if (num == 5.0)
                        {
                            this.ToolStripMenuItem9.Checked = true;
                        }
                        try
                        {
                            this.PrintPreviewControl1.Zoom = value;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        private bool myisshowpagecontinues;
        [Description("设置或获取一个值，用于指示打印预览结果在有多页的情况下，是以'单页方式'还是'连续显示方式'显示打印预览结果。为true表示连续显示，为false表示单页显示")]
        public bool IsShowPageContinues
        {
            get
            {
                return this.myisshowpagecontinues;
            }
            set
            {
                this.myisshowpagecontinues = value;
                if (value)
                {
                    this.mytype1.Checked = true;
                    this.mytype2.Checked = false;
                }
                else
                {
                    this.mytype1.Checked = false;
                    this.mytype2.Checked = true;
                }
                this.SetPages();
            }
        }

        public delegate void ZDYButtonClickEventHandler();
        [Description("工具栏中自定义按钮的单击事件")]
        public event ZDYButtonClickEventHandler ZDYButtonClick;

        private bool myiszdybuttonvisible;
        [Description("工具栏中自定义的按钮是否可见")]
        public bool ZDYButtonVisible
        {
            get
            {
                return this.myiszdybuttonvisible;
            }
            set
            {
                this.myiszdybuttonvisible = value;
                this.zdybutton.Visible = value;
            }
        }


        [Description("工具栏中自定义按钮显示的按钮文本")]
        public string ZDYButtonText
        {
            get
            {
                return this.zdybutton.Text;
            }
            set
            {
                this.zdybutton.Text = value;
            }
        }


        [Description("工具栏中自定义按钮显示的按钮提示文本")]
        public string ZDYButtonToolTipText
        {
            get
            {
                return this.zdybutton.ToolTipText;
            }
            set
            {
                this.zdybutton.ToolTipText = value;
            }
        }

        public delegate void ZDYButton2ClickEventHandler();
        [Description("工具栏中自定义按钮2的单击事件")]
        public event ZDYButton2ClickEventHandler ZDYButton2Click;

        private bool myiszdybutton2visible;
        [Description("工具栏中自定义按钮2是否可见")]
        public bool ZDYButton2Visible
        {
            get
            {
                return this.myiszdybutton2visible;
            }
            set
            {
                this.myiszdybutton2visible = value;
                this.ZDYButton2.Visible = value;
            }
        }


        [Description("工具栏中自定义按钮2显示的按钮文本")]
        public string ZDYButton2Text
        {
            get
            {
                return this.ZDYButton2.Text;
            }
            set
            {
                this.ZDYButton2.Text = value;
            }
        }

        [Description("工具栏中自定义按钮2显示的按钮提示文本")]
        public string ZDYButton2ToolTipText
        {
            get
            {
                return this.ZDYButton2.ToolTipText;
            }
            set
            {
                this.ZDYButton2.ToolTipText = value;
            }
        }

        public enum PageExportUnit
        {

            CentiMeter,

            Inch = 3
        }
        private PageExportUnit mypageunits;
        [Description("设置页面输出单位,CentiMeter表示1/100厘米，Inch表示1/100英寸")]
        public PageExportUnit PageUnits
        {
            get
            {
                return this.mypageunits;
            }
            set
            {
                this.mypageunits = value;
            }
        }

        private bool myishowprintstatusdialog;
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


        [Description("是否使用操作系统的防锯齿功能，使用操作系统的防锯齿功能可能提高打印预览的显示效果，但速度较慢")]
        public bool UseAntiAlias
        {
            get
            {
                return this.PrintPreviewControl1.UseAntiAlias;
            }
            set
            {
                this.PrintPreviewControl1.UseAntiAlias = value;
            }
        }

        private bool myenabledprint;
        [Description("设置或获取一个值，用于指示控件工具栏中的 打印 按钮是否可用，为true表示可用，为false表示不可用")]
        public bool EnabledPrint
        {
            get
            {
                return this.myenabledprint;
            }
            set
            {
                this.myenabledprint = value;
                if (value)
                {
                    this.printd.Enabled = true;
                    this.printd.Visible = true;
                }
                else
                {
                    this.printd.Enabled = false;
                    this.printd.Visible = false;
                }
            }
        }

        private bool myenabledpagesetting;
        [Description("工具栏中的页面设置按钮是否可用")]
        public bool EnabledPageSetting
        {
            get
            {
                return this.myenabledpagesetting;
            }
            set
            {
                this.myenabledpagesetting = value;
                if (value)
                {
                    this.pagesetup.Enabled = true;
                    this.pagesetup.Visible = true;
                }
                else
                {
                    this.pagesetup.Enabled = false;
                    this.pagesetup.Visible = false;
                }
            }
        }

        private bool myisusedgvpadding;
        [Description("指示在打印DataGridView时，是否使用DGV本身的DefaultCellStyle .Padding 指定的值做为单元格边距。如果为True,表示是，如果为False,则表示使用本控件的CellMargin属性指定的值作为打印DGV是的单元格边距")]
        public bool IsUseDGVPadding
        {
            get
            {
                return this.myisusedgvpadding;
            }
            set
            {
                this.myisusedgvpadding = value;
            }
        }

        private Margins myCellmargin;
        [Description("单元格边距")]
        public Margins CellMargin
        {
            get
            {
                Margins margins = new Margins();
                try
                {
                    margins.Left = this.myCellmargin.Left;
                    margins.Bottom = this.myCellmargin.Bottom;
                    margins.Top = this.myCellmargin.Top;
                    margins.Right = this.myCellmargin.Right;
                }
                catch (Exception ex)
                {
                }
                return margins;
            }
            set
            {
                try
                {
                    this.myCellmargin.Left = value.Left;
                    this.myCellmargin.Right = value.Right;
                    this.myCellmargin.Bottom = value.Bottom;
                    this.myCellmargin.Top = value.Top;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private bool myisdrawmargin;
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

        private float mylastdrawtextheight;
        [Browsable(false)]
        public float LastDrawTextHeight
        {
            get
            {
                return this.MyConvFrom(this.mylastdrawtextheight);
            }
        }

        private float mylastdrawtextwidth;
        [Browsable(false)]
        public float LastDrawTextWidth
        {
            get
            {
                return this.MyConvFrom(this.mylastdrawtextwidth);
            }
        }

        private bool myistoolbarvisible;
        [Description("打印预览窗口工具栏是否可见")]
        public bool ToolBarVisible
        {
            get
            {
                return this.myistoolbarvisible;
            }
            set
            {
                this.myistoolbarvisible = value;
                this.ToolStrip1.Visible = value;
            }
        }

        private bool mycanopenreport;
        [Description("是否允许打开报表文件")]
        public bool CanOpenReport
        {
            get
            {
                return this.mycanopenreport;
            }
            set
            {
                this.mycanopenreport = value;
                if (value)
                {
                    this.myopen.Enabled = true;
                    this.myopen.Visible = true;
                }
                else
                {
                    this.myopen.Enabled = false;
                    this.myopen.Visible = false;
                }
            }
        }

        private bool mycansavereport;
        [Description("是否允许保存预览显示结果为报表文件")]
        public bool CanSaveReport
        {
            get
            {
                return this.mycansavereport;
            }
            set
            {
                this.mycansavereport = value;
                if (value)
                {
                    this.mysave.Enabled = true;
                    this.mysave.Visible = true;
                }
                else
                {
                    this.mysave.Enabled = false;
                    this.mysave.Visible = false;
                }
            }
        }
        private bool isstarting;
        [Description("指定页面边距")]
        public Margins PaperMargins
        {
            get
            {
                Margins margins = new Margins();
                checked
                {
                    Margins result;
                    if (this.mypagesetting == null)
                    {
                        result = margins;
                    }
                    else
                    {
                        margins.Left = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Left));
                        margins.Top = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Top));
                        margins.Bottom = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Bottom));
                        margins.Right = (int)Math.Round((double)this.MyConvFrom((float)this.mypagesetting.Margins.Right));
                        result = margins;
                    }
                    return result;
                }
            }
            set
            {
                checked
                {
                    if (!this.isstarting)
                    {
                        this.mypagesetting.Margins.Left = (int)Math.Round((double)this.MyConvTo((float)value.Left));
                        this.mypagesetting.Margins.Top = (int)Math.Round((double)this.MyConvTo((float)value.Top));
                        this.mypagesetting.Margins.Bottom = (int)Math.Round((double)this.MyConvTo((float)value.Bottom));
                        this.mypagesetting.Margins.Right = (int)Math.Round((double)this.MyConvTo((float)value.Right));
                        this.Pd.DefaultPageSettings = this.mypagesetting;
                    }
                }
            }
        }


        [Description("指定纸张类型")]
        public PaperKind PaperKind
        {
            get
            {
                return this.mypagesetting.PaperSize.Kind;
            }
            set
            {
                if (!this.isstarting)
                {
                    try
                    {
                        foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
                        {
                            PaperSize paperSize = (PaperSize)obj;
                            if (paperSize.Kind == value)
                            {
                                this.mypagesetting.PaperSize = paperSize;
                            }
                        }
                    }
                    finally
                    {

                    }
                    this.Pd.DefaultPageSettings = this.mypagesetting;
                }
            }
        }


        [Description("设置纸张打印方向")]
        public bool PaperLandscape
        {
            get
            {
                return this.mypagesetting != null && this.mypagesetting.Landscape;
            }
            set
            {
                if (!this.isstarting)
                {
                    try
                    {
                        this.mypagesetting.Landscape = value;
                        this.Pd.DefaultPageSettings = this.mypagesetting;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private float[] myPaperWidth;
        private float[] myPaperHeight;
        private int currentpage;
        public float PaperWidth
        {
            get
            {
                float result;
                try
                {
                    if (!this.PaperLandscape)
                    {
                        result = this.MyConvFrom(this.myPaperWidth[this.currentpage]);
                    }
                    else
                    {
                        result = this.MyConvFrom(this.myPaperHeight[this.currentpage]);
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (!this.PaperLandscape)
                        {
                            result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Width);
                        }
                        else
                        {
                            result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Height);

                        }
                    }
                    catch (Exception ex2)
                    {
                        result = 0f;
                    }
                }
                return result;
            }
        }

      
        public float PaperHeight
        {
            get
            {
                float result;
                try
                {
                    if (!this.PaperLandscape)
                    {
                        result = this.MyConvFrom(this.myPaperHeight[this.currentpage]);
                    }
                    else
                    {
                        result = this.MyConvFrom(this.myPaperWidth[this.currentpage]);
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (!this.PaperLandscape)
                        {
                            result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Height);
                            ProjectData.ClearProjectError();
                        }
                        else
                        {
                            result = this.MyConvFrom((float)this.mypagesetting.PaperSize.Width);
                            ProjectData.ClearProjectError();
                        }
                    }
                    catch (Exception ex2)
                    {
                        result = 0f;
                    }
                }
                return result;
            }
        }

   
        private void SavePaperHeightAndWidth(PaperSize tt)
        {
            checked
            {
                if (!(this.currentpage > this.GetPages() | this.currentpage < 0))
                {
                    if (this.myPaperHeight == null | this.myPaperWidth == null)
                    {
                        this.myPaperHeight = (float[])Utils.CopyArray((Array)this.myPaperHeight, new float[this.GetPages() + 1]);
                        this.myPaperWidth = (float[])Utils.CopyArray((Array)this.myPaperWidth, new float[this.GetPages() + 1]);
                    }
                    else if (this.myPaperHeight.Length <= this.GetPages())
                    {
                        this.myPaperHeight = (float[])Utils.CopyArray((Array)this.myPaperHeight, new float[this.GetPages() + 1]);
                        this.myPaperWidth = (float[])Utils.CopyArray((Array)this.myPaperWidth, new float[this.GetPages() + 1]);
                    }
                    this.myPaperHeight[this.currentpage] = (float)tt.Height;
                    this.myPaperWidth[this.currentpage] = (float)tt.Width;
                }
            }
        }

       
        [Browsable(false)]
        public float PaperPrintWidth
        {
            get
            {
                return this.PaperWidth - (float)this.PaperMargins.Left - (float)this.PaperMargins.Right;
            }
        }

      
        [Browsable(false)]
        public float PaperPrintHeight
        {
            get
            {
                return this.PaperHeight - (float)this.PaperMargins.Top - (float)this.PaperMargins.Bottom;
            }
        }

      
        [Description("默认前景颜色，在打印输出函数中没有指定前景颜色对象时，将使用该属性所指定的前景颜色进行打印输出")]
        public Color TextColor
        {
            get
            {
                return this.myforecolor;
            }
            set
            {
                this.myforecolor = value;
            }
        }

      
        [Description("默认字体格式，在打印输出函数中没有指定字体对象时，将使用该对象所确定的字体格式进行打印输出")]
        public Font TextFont
        {
            get
            {
                Font result;
                if (this.myfont == null)
                {
                    result = null;
                }
                else
                {
                    try
                    {
                        result = (Font)this.myfont.Clone();
                    }
                    catch (Exception ex)
                    {
                        result = null;
                    }
                }
                return result;
            }
            set
            {
                if (value != null)
                {
                    this.myfont = (Font)value.Clone();
                }
            }
        }

      
        [Browsable(false)]
        public float Currentx
        {
            get
            {
                return this.MyConvFrom(this.mycurrentx);
            }
            set
            {
                this.mycurrentx = this.MyConvTo(value);
            }
        }

      
        [Browsable(false)]
        public float Currenty
        {
            get
            {
                return this.MyConvFrom(this.mycurrenty);
            }
            set
            {
                this.mycurrenty = this.MyConvTo(value);
            }
        }

       
        [Description("设置打印文档名称，该名称将显示在打印机打印任务的文档名称栏中")]
        public string DocumentName
        {
            get
            {
                return this.myDocumentName;
            }
            set
            {
                this.myDocumentName = value;
            }
        }

     
        [Description("获取或设置页面实际打印的缩放比例，为1表示100%比例。注意，该属性与Zoom属性的区别，Zoom的大小只影响屏幕显示比例，而此属性只影响实际打印比例。")]
        public float PageScale
        {
            get
            {
                return this.mypagescale;
            }
            set
            {
                if (value >= 0f)
                {
                    if (value == 0f)
                    {
                        this.mypagescale = 1f;
                    }
                    this.mypagescale = value;
                }
            }
        }

        [Description("设置或获取一个值，用于指定是否打印装订线")]
        public bool IsDrawZDX
        {
            get
            {
                return this.myisdrawZDX;
            }
            set
            {
                this.myisdrawZDX = value;
            }
        }

      
        [Description("装订线的类型，是靠纸张的左边、上边、右边、下边的哪一边装订")]
        public TheZDXTYPE ZDXType
        {
            get
            {
                return this.myZDXtype;
            }
            set
            {
                this.myZDXtype = value;
            }
        }

       
        [Description("指定装订线距纸张边界的大小（以PageUnits指定的值为计量单位）。为0表示打印在页边距的中间，为其他值则表示距纸张边界的距离")]
        public float ZDXPosition
        {
            get
            {
                return this.MyConvFrom(this.myZDXposition);
            }
            set
            {
                this.myZDXposition = this.MyConvTo(value);
            }
        }

     
        [Description("要打印的装订线中线条的类型")]
        public DashStyle ZDXLineStyle
        {
            get
            {
                return this.myZDXlinestyle;
            }
            set
            {
                this.myZDXlinestyle = value;
            }
        }

       
        [Description("装订线线条的颜色")]
        public Color ZDXLinecoLor
        {
            get
            {
                return this.myZDXlinecolor;
            }
            set
            {
                this.myZDXlinecolor = value;
            }
        }


        [Description("装订线文本的打印颜色")]
        public Color ZDXTextColor
        {
            get
            {
                return this.myZDXtextcolor;
            }
            set
            {
                this.myZDXtextcolor = value;
            }
        }

        [Description("装订线中文本打印的字体")]
        public Font ZDXFont
        {
            get
            {
                Font result;
                if (this.myZDXfont == null)
                {
                    result = null;
                }
                else
                {
                    result = (Font)this.myZDXfont.Clone();
                }
                return result;
            }
            set
            {
                if (value != null)
                {
                    try
                    {
                        this.myZDXfont = (Font)value.Clone();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        // Token: 0x170006E7 RID: 1767
        // (get) Token: 0x060013A1 RID: 5025 RVA: 0x000955D8 File Offset: 0x000937D8
        // (set) Token: 0x060013A2 RID: 5026 RVA: 0x0000717D File Offset: 0x0000537D
        [Description("装订线中要打印的文本内容")]
        public string ZDXText
        {
            get
            {
                return this.myZDXtext;
            }
            set
            {
                this.myZDXtext = value;
                this.myZDXtext = this.myZDXtext.Replace("\r\n", "");
            }
        }

        // Token: 0x060013A3 RID: 5027 RVA: 0x000955F0 File Offset: 0x000937F0
        private void PrintZDX()
        {
            if (this.IsDrawZDX && !this.CancelDocument)
            {
                this.r_font = null;
                this.Currentx = 0f;
                Pen pen = new Pen(this.ZDXLinecoLor);
                bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
                this.IsNeedCheckNewPage = false;
                pen.DashStyle = this.ZDXLineStyle;
                switch (this.ZDXType)
                {
                    case TheZDXTYPE.TOP:
                        {
                            float num;
                            if (this.ZDXPosition <= 0f)
                            {
                                num = (float)((double)this.PaperMargins.Top / 2.0 - (double)this.PaperMargins.Top);
                            }
                            else
                            {
                                num = this.ZDXPosition - (float)this.PaperMargins.Top;
                            }
                            float num2 = 0f;
                            float x = this.PaperPrintWidth;
                            float y = num;
                            this.DrawLine(pen, num2, num, x, y);
                            float num3 = this.MeasureText("测", this.ZDXFont).Height;
                            this.Currentx = num2;
                            this.Currenty = num - num3 / 2f;
                            this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, true, true, this.PaperPrintWidth, num3, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
                            break;
                        }
                    case TheZDXTYPE.RIGHT:
                        {
                            float num2;
                            if (this.ZDXPosition <= 0f)
                            {
                                num2 = (float)((double)this.PaperPrintWidth + (double)this.PaperMargins.Right / 2.0);
                            }
                            else
                            {
                                num2 = this.PaperPrintWidth + ((float)this.PaperMargins.Right - this.ZDXPosition);
                            }
                            float num = 0f;
                            float x = num2;
                            float y = this.PaperPrintHeight;
                            this.DrawLine(pen, num2, num, x, y);
                            float num3 = this.MeasureText("测", this.ZDXFont).Width;
                            this.Currentx = num2 - num3 / 2f;
                            this.Currenty = num;
                            this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, false, true, num3, this.PaperPrintHeight, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
                            break;
                        }
                    case TheZDXTYPE.BOTTOM:
                        {
                            float num;
                            if (this.ZDXPosition <= 0f)
                            {
                                num = (float)((double)this.PaperHeight - (double)this.PaperMargins.Bottom / 2.0 - (double)this.PaperMargins.Top);
                            }
                            else
                            {
                                num = this.PaperHeight - this.ZDXPosition - (float)this.PaperMargins.Top;
                            }
                            float num2 = 0f;
                            float x = this.PaperPrintWidth;
                            float y = num;
                            this.DrawLine(pen, num2, num, x, y);
                            float num3 = this.MeasureText("测", this.ZDXFont).Height;
                            this.Currentx = num2;
                            this.Currenty = num - num3 / 2f;
                            this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, true, true, this.PaperPrintWidth, num3, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
                            break;
                        }
                    default:
                        {
                            float num2;
                            if (this.ZDXPosition <= 0f)
                            {
                                num2 = (float)((double)this.PaperMargins.Left / 2.0 - (double)this.PaperMargins.Left);
                            }
                            else
                            {
                                num2 = this.ZDXPosition - (float)this.PaperMargins.Left;
                            }
                            float num = 0f;
                            float x = num2;
                            float y = this.PaperPrintHeight;
                            this.DrawLine(pen, num2, num, x, y);
                            float num3 = this.MeasureText("测", this.ZDXFont).Width;
                            this.Currentx = num2 - num3 / 2f;
                            this.Currenty = num;
                            this.DrawMultiCell(this.ZDXText, (long)this.ZDXText.Length, false, true, num3, this.PaperPrintHeight, this.ZDXFont, this.ZDXTextColor, "", Color.Black, 6f, 0);
                            break;
                        }
                }
                this.IsNeedCheckNewPage = isNeedCheckNewPage;
                pen.Dispose();
            }
        }

        // Token: 0x060013A4 RID: 5028 RVA: 0x000959F0 File Offset: 0x00093BF0
        public int GetCurrentPage()
        {
            int result;
            if (this.isstarting)
            {
                result = this.currentpage;
            }
            else
            {
                try
                {
                    result = checked((int)Math.Round(Conversion.Val(Strings.Mid(this.cpage.Text, 2))));
                }
                catch (Exception ex)
                {
                    result = this.currentpage;
                }
            }
            return result;
        }

        // Token: 0x060013A5 RID: 5029 RVA: 0x00095A54 File Offset: 0x00093C54
        public bool SetCurrentPage(int pagenumber)
        {
            bool result;
            if (pagenumber > this.GetPages())
            {
                result = false;
            }
            else if (pagenumber <= 0)
            {
                result = false;
            }
            else if (this.isstarting)
            {
                if (this.currentpage == pagenumber)
                {
                    this.SaveFont(this.r_font, null);
                    result = true;
                }
                else
                {
                    int page = this.currentpage;
                    this.currentpage = pagenumber;
                    this.SaveFont(this.r_font, null);
                    if (!this.IsPaperSizeEqual(page, this.currentpage))
                    {
                        this.GetPageAndPaperSettings(this.currentpage);
                    }
                    result = true;
                }
            }
            else
            {
                this.currentpage = pagenumber;
                this.PrintPreviewControl1.StartPage = checked(this.currentpage - 1);
                result = true;
            }
            return result;
        }

        // Token: 0x060013A6 RID: 5030 RVA: 0x00095AF4 File Offset: 0x00093CF4
        public int GetPages()
        {
            int result;
            if (this.mypages == null)
            {
                result = 0;
            }
            else
            {
                result = checked(this.mypages.Length - 1);
            }
            return result;
        }

        // Token: 0x060013A7 RID: 5031 RVA: 0x00095B1C File Offset: 0x00093D1C
        private float GetPYx()
        {
            float num = this.MyConvTo(this.myPYx);
            if (this.IsAutoAdjustPrinterMargin && this.isprinttoprinter)
            {
                num -= this.unprintablex;
            }
            return num;
        }

        // Token: 0x060013A8 RID: 5032 RVA: 0x00095B54 File Offset: 0x00093D54
        private float GetPYy()
        {
            float num = this.MyConvTo(this.myPYy);
            if (this.IsAutoAdjustPrinterMargin && this.isprinttoprinter)
            {
                num -= this.unprintabley;
            }
            return num;
        }

        // Token: 0x060013A9 RID: 5033 RVA: 0x000071A1 File Offset: 0x000053A1
        private void PY(Graphics g)
        {
            g.TranslateTransform(this.GetPYx(), this.GetPYy());
        }

        // Token: 0x060013AA RID: 5034 RVA: 0x00095B8C File Offset: 0x00093D8C
        private void MyDrawDGVHeaderCell(DataGridViewColumn mycolumn, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
        {
            if (mycolumn != null)
            {
                DataGridView dataGridView = mycolumn.DataGridView;
                if (mycolumn.Visible)
                {
                    if (mycellwidth <= 0f)
                    {
                        mycellwidth = this.ConvFromDisplay((float)mycolumn.Width, true);
                    }
                    if (mycellheight <= 0f)
                    {
                        mycellheight = this.ConvFromDisplay((float)dataGridView.ColumnHeadersHeight, false);
                    }
                    Font dgvheaderFont = Module1.GetDGVHeaderFont(mycolumn);
                    Color dgvheaderForeColor = Module1.GetDGVHeaderForeColor(mycolumn);
                    bool mulline = Module1.GetDGVHeaderMulline(mycolumn);
                    Color dgvheaderBackColor = Module1.GetDGVHeaderBackColor(mycolumn);
                    mulline = true;
                    if (!isprintbackcolor)
                    {
                        this.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                    }
                    else
                    {
                        this.DrawCell(mycolumn.HeaderText, mycellwidth, mycellheight, dgvheaderFont, dgvheaderForeColor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, dgvheaderBackColor, dataGridView.GridColor, 0);
                    }
                }
                try
                {
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x060013AB RID: 5035 RVA: 0x00095C78 File Offset: 0x00093E78
        private void MyDrawDGVCell(DataGridViewCell dgvcell, float mycellwidth, float mycellheight, string myborder, bool isprintbackcolor, float minfontsize)
        {
            checked
            {
                if (dgvcell != null)
                {
                    DataGridView dataGridView = dgvcell.DataGridView;
                    string s = "";
                    Bitmap bitmap = null;
                    DataGridViewColumn dataGridViewColumn = dataGridView.Columns[dgvcell.ColumnIndex];
                    DataGridViewRow dataGridViewRow = dataGridView.Rows[dgvcell.RowIndex];
                    if (dataGridViewColumn.Visible)
                    {
                        Margins cellMargin = this.CellMargin;
                        if (this.IsUseDGVPadding)
                        {
                            Margins dgvcellPadding = Module1.GetDGVCellPadding(dgvcell);
                            this.CellMargin = new Margins((int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Left, true)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Right, true)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Top, false)), (int)Math.Round((double)this.ConvFromDisplay((float)dgvcellPadding.Bottom, false)));
                        }
                        if (mycellwidth <= 0f)
                        {
                            mycellwidth = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
                        }
                        if (mycellheight <= 0f)
                        {
                            mycellheight = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
                        }
                        Font myf = Module1.GetDGVCellFont(dgvcell);
                        DataGridViewCellStyle dataGridViewCellStyle = Module1.GetDGVCellStyle(dgvcell);
                        Color dgvcellForeColor = Module1.GetDGVCellForeColor(dgvcell);
                        Color dgvcellBackColor = Module1.GetDGVCellBackColor(dgvcell);
                        bool dgvcellMulline = Module1.GetDGVCellMulline(dgvcell);
                        bool flag = false;
                        int num = 0;
                        if (String.Compare(Versioned.TypeName(dataGridViewColumn), "DataGridViewCheckBoxColumn", false) == 0)
                        {
                            CheckBox checkBox = new CheckBox();
                            Control control = checkBox;
                            Size size = new Size(14, 14);
                            control.Size = size;
                            if (isprintbackcolor)
                            {
                                checkBox.BackColor = dgvcellBackColor;
                            }
                            else
                            {
                                checkBox.BackColor = Color.Transparent;
                            }
                            if (String.Compare(Versioned.TypeName(RuntimeHelpers.GetObjectValue(dgvcell.FormattedValue)), "Boolean", false) == 0)
                            {
                                if (DataTypeConversion.ToBoolean(dgvcell.FormattedValue))
                                {
                                    checkBox.Checked = true;
                                }
                                else
                                {
                                    checkBox.Checked = false;
                                }
                            }
                            else
                            {
                                switch (Convert.ToInt32(dgvcell.FormattedValue))
                                {
                                    case 0:
                                        checkBox.Checked = false;
                                        break;
                                    case 1:
                                        checkBox.Checked = true;
                                        break;
                                    default:
                                        checkBox.CheckState = CheckState.Indeterminate;
                                        break;
                                }
                            }
                            if (bitmap != null)
                            {
                                try
                                {
                                    bitmap.Dispose();
                                    bitmap = null;
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            try
                            {
                                bitmap = new Bitmap((int)Math.Round((double)this.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
                                Graphics graphics = Graphics.FromImage(bitmap);
                                Brush brush;
                                if (isprintbackcolor)
                                {
                                    brush = new SolidBrush(dgvcellBackColor);
                                }
                                else
                                {
                                    brush = Brushes.White;
                                }
                                Graphics graphics2 = graphics;
                                Brush brush2 = brush;
                                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                                graphics2.FillRectangle(brush2, rectangle);
                                if (bitmap.Height < checkBox.Height)
                                {
                                    checkBox.Height = bitmap.Height;
                                }
                                if (bitmap.Width < checkBox.Width)
                                {
                                    checkBox.Width = bitmap.Width;
                                }
                                Control control2 = checkBox;
                                Bitmap bitmap2 = bitmap;
                                rectangle = new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height);
                                control2.DrawToBitmap(bitmap2, rectangle);
                                graphics.Dispose();
                                checkBox.Dispose();
                                checkBox = null;
                            }
                            catch (Exception ex2)
                            {
                            }
                            flag = true;
                            num = 2;
                        }
                        else if (String.Compare(Versioned.TypeName(dataGridViewColumn), "DataGridViewButtonColumn", false) == 0)
                        {
                            Button button = new Button();
                            button.AutoSize = false;
                            Control control3 = button;
                            Size size = new Size((int)Math.Round((double)this.ConvToDisplay(mycellwidth, true)), (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
                            control3.Size = size;
                            button.Text = "";
                            if (isprintbackcolor)
                            {
                                button.BackColor = dgvcellBackColor;
                            }
                            else
                            {
                                button.BackColor = Color.Transparent;
                            }
                            float currentx = this.Currentx;
                            float currenty = this.Currenty;
                            try
                            {
                                bitmap = new Bitmap(button.Width, dataGridViewRow.Height);
                                Control control4 = button;
                                Bitmap bitmap3 = bitmap;
                                Rectangle rectangle = new Rectangle(0, 0, button.Width, (int)Math.Round((double)this.ConvToDisplay(mycellheight, false)));
                                control4.DrawToBitmap(bitmap3, rectangle);
                                this.DrawCellImage(bitmap, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, "0000", true, StringAlignment.Center, StringAlignment.Center);
                                bitmap.Dispose();
                                bitmap = null;
                                button.Dispose();
                            }
                            catch (Exception ex3)
                            {
                            }
                            this.Currentx = currentx;
                            this.Currenty = currenty;
                            flag = true;
                            num = 3;
                        }
                        else if (String.Compare(Versioned.TypeName(dataGridViewColumn), "DataGridViewImageColumn", false) == 0)
                        {
                            flag = true;
                            num = 1;
                        }
                        else
                        {
                            s = Convert.ToString(dgvcell.FormattedValue) + "";
                        }
                        if (!flag)
                        {
                            if (!isprintbackcolor)
                            {
                                this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                            }
                            else
                            {
                                this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, false, false, false, minfontsize, dgvcellBackColor, dataGridView.GridColor, 0);
                            }
                        }
                        else if (num == 1)
                        {
                            DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)dgvcell;
                            this.DrawCellImage((Bitmap)dgvcell.FormattedValue, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, dataGridViewImageCell.ImageLayout, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter));
                        }
                        else if (num == 2)
                        {
                            this.DrawCellImage(bitmap, this.Currentx, this.Currenty, mycellwidth, mycellheight, dataGridView.GridColor, myborder, true, StringAlignment.Center, StringAlignment.Center);
                        }
                        else if (num == 3)
                        {
                            s = Convert.ToString(dgvcell.FormattedValue) + "";
                            this.DrawCell(s, mycellwidth, mycellheight, myf, dgvcellForeColor, myborder, Module1.GetHAlignment(dataGridViewCellStyle.Alignment), Module1.GetVAlignment(dataGridViewCellStyle.Alignment, this.IsDGVCellValignmentCenter), dgvcellMulline, true, false, false, minfontsize, Color.White, dataGridView.GridColor, 0);
                        }
                        if (this.IsUseDGVPadding)
                        {
                            this.CellMargin = cellMargin;
                        }
                    }
                    if (bitmap != null)
                    {
                        try
                        {
                            bitmap.Dispose();
                            bitmap = null;
                        }
                        catch (Exception ex4)
                        {
                        }
                    }
                    try
                    {
                        dataGridView = null;
                        Font myf = null;
                        DataGridViewCellStyle dataGridViewCellStyle = null;
                    }
                    catch (Exception ex5)
                    {
                    }
                }
            }
        }

        // Token: 0x060013AC RID: 5036 RVA: 0x0009633C File Offset: 0x0009453C
        private static int GetDGVVisibleCols(DataGridView myd)
        {
            checked
            {
                int result;
                if (myd == null)
                {
                    result = 0;
                }
                else
                {
                    int num = 0;
                    int num2 = 0;
                    int num3 = myd.ColumnCount - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        if (myd.Columns[i].Visible)
                        {
                            num++;
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x060013AD RID: 5037 RVA: 0x00096384 File Offset: 0x00094584
        private void MyWrite(string thename, string thevalue)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = thename + "\0" + thevalue;
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013AE RID: 5038 RVA: 0x000963E0 File Offset: 0x000945E0
        private void MyWrite(string t1, string t2, string t3)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013AF RID: 5039 RVA: 0x00096458 File Offset: 0x00094658
        private void MyWrite(string t1, string t2, string t3, string t4)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B0 RID: 5040 RVA: 0x000964DC File Offset: 0x000946DC
        private void MyWrite(string t1, string t2, string t3, string t4, string t5)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B1 RID: 5041 RVA: 0x00096570 File Offset: 0x00094770
        private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5,
                        "\0",
                        t6,
                        "\0",
                        t7
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B2 RID: 5042 RVA: 0x00096628 File Offset: 0x00094828
        private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5,
                        "\0",
                        t6,
                        "\0",
                        t7,
                        "\0",
                        t8
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B3 RID: 5043 RVA: 0x000966EC File Offset: 0x000948EC
        private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5,
                        "\0",
                        t6,
                        "\0",
                        t7,
                        "\0",
                        t8,
                        "\0",
                        t9
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B4 RID: 5044 RVA: 0x000967C0 File Offset: 0x000949C0
        private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5,
                        "\0",
                        t6,
                        "\0",
                        t7,
                        "\0",
                        t8,
                        "\0",
                        t9,
                        "\0",
                        t10
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B5 RID: 5045 RVA: 0x000968A4 File Offset: 0x00094AA4
        private void MyWrite(string t1, string t2, string t3, string t4, string t5, string t6)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string str = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        t2,
                        "\0",
                        t3,
                        "\0",
                        t4,
                        "\0",
                        t5,
                        "\0",
                        t6
                    });
                    this.mypages[this.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }

        // Token: 0x060013B6 RID: 5046 RVA: 0x00096948 File Offset: 0x00094B48
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        t7,
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Convert.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = text + Convert.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Convert.ToString(Interaction.IIf(t13, "1", "0"));
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013B7 RID: 5047 RVA: 0x00096AE0 File Offset: 0x00094CE0
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, StringFormatFlags t10)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        t7,
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text += Convert.ToString((int)t10);
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013B8 RID: 5048 RVA: 0x00096BF8 File Offset: 0x00094DF8
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        colorConverter.ConvertToString(t7),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text += Convert.ToString((int)t10);
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013B9 RID: 5049 RVA: 0x00096D24 File Offset: 0x00094F24
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        colorConverter.ConvertToString(t7),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Convert.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = text + Convert.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Convert.ToString(Interaction.IIf(t13, "1", "0"));
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013BA RID: 5050 RVA: 0x00096ECC File Offset: 0x000950CC
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13, string t14)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        colorConverter.ConvertToString(t7),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Convert.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(Interaction.IIf(t12, "1", "0")),
                        "\0",
                        Convert.ToString(Interaction.IIf(t13, "1", "0")),
                        "\0"
                    });
                    text += t14;
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013BB RID: 5051 RVA: 0x00097098 File Offset: 0x00095298
        private void MyWrite(string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10, string t11)
        {
            if (this.currentpage < this.mypages.Length)
            {
                if (this.currentpage <= 0)
                {
                    this.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Convert.ToString(t2),
                        "\0",
                        Convert.ToString(t3),
                        "\0",
                        Convert.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Convert.ToString(t5),
                        "\0",
                        t6,
                        "\0",
                        colorConverter.ConvertToString(t7),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        t8,
                        "\0",
                        t9,
                        "\0"
                    });
                    text = text + Convert.ToString((int)t10) + "\0";
                    text += t11;
                    this.mypages[this.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }

        // Token: 0x060013BC RID: 5052 RVA: 0x000071B5 File Offset: 0x000053B5
        private void ShowWriteError()
        {
            if (this.IsShowErrorMSG & !this.hasshownewpageerror)
            {
                this.hasshownewpageerror = true;
                Interaction.MsgBox("您在调用控件的打印方法打印输出前未调用NewPage函数创建第1个打印页面\r\n这将导致这部分的打印输出无效（打印内容部分丢失），请注意检查。", MsgBoxStyle.Exclamation, "警告");
            }
        }

        // Token: 0x060013BD RID: 5053 RVA: 0x000971D0 File Offset: 0x000953D0
        private bool SaveFont(Font newfont, Font sourcefont)
        {
            FontConverter fontConverter = new FontConverter();
            bool result;
            if (sourcefont == null)
            {
                string text = fontConverter.ConvertToString(newfont);
                this.MyWrite("f", text);
                result = true;
            }
            else
            {
                string right = fontConverter.ConvertToString(sourcefont);
                string text = fontConverter.ConvertToString(newfont);
                if (String.Compare(text, right, false) != 0)
                {
                    this.MyWrite("f", text);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        // Token: 0x060013BE RID: 5054 RVA: 0x00097234 File Offset: 0x00095434
        private void SaveCS()
        {
            this.templandscape = this.PaperLandscape;
            this.temppaperkind = this.PaperKind;
            this.temppapersize = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.PaperSize.PaperName);
            this.temppageunits = this.PageUnits;
            this.tempmargintleft = this.mypagesetting.Margins.Left;
            this.tempmargintright = this.mypagesetting.Margins.Right;
            this.tempmarginttop = this.mypagesetting.Margins.Top;
            this.tempmargintbottom = this.mypagesetting.Margins.Bottom;
            this.tempforecolor = this.TextColor;
            this.tempfont = (Font)this.TextFont.Clone();
            this.tempfontwater = (Font)this.WaterMarkFont.Clone();
            this.tempforecolorwater = this.WaterMarkColor;
            this.templandscapewater = this.WaterMarkLandscape;
            this.tempopacitywater = this.mywatermarkopacity;
            this.tempshapedepth = this.myshapedepth;
            this.tempcellmargin = this.myCellmargin;
            this.tempisdrawtableeverypage = this.IsDrawTableFooterEveryPage;
            this.tempisautoaddemptyrow = this.IsAutoAddEmptyRow;
            this.tempisneedchecknewpage = this.IsNeedCheckNewPage;
            this.tempouterborder = this.myouterborder;
            this.tempouterborderwidth = this.myouterborderwidth;
            this.tempouterbordercolor = this.myouterbordercolor;
            this.tempisusedoubleline = this.myisusedoubleline;
            this.tempdoublelinespace = this.thedoublelinespace;
            this.tempIsDGVCellValignmentCenter = this.myIsDGVCellValignmentCenter;
            this.tempIsDrawPageFooterLine = this.myisdrawpagefooterline;
            this.tempIsDrawPageHeaderLine = this.myisdrawpageheaderline;
            this.tempIsUseDGVPadding = this.myisusedgvpadding;
            this.tempoffsetx = this.myPYx;
            this.tempoffsety = this.myPYy;
        }

        // Token: 0x060013BF RID: 5055 RVA: 0x000071E2 File Offset: 0x000053E2
        private void RestoreEndCS()
        {
            if (this.tempfont != null)
            {
                this.RestoreCS();
            }
        }

        // Token: 0x060013C0 RID: 5056 RVA: 0x000973F8 File Offset: 0x000955F8
        private void RestoreCS()
        {
            this.PaperLandscape = this.templandscape;
            this.PaperKind = this.temppaperkind;
            if (this.temppapersize != null)
            {
                PaperSize printForm = definepaper.GetPrintForm(this.GetCurrentPrinterName(), this.temppapersize.PaperName);
                if (printForm != null)
                {
                    this.PaperSize = printForm;
                }
            }
            this.PageUnits = this.temppageunits;
            try
            {
                this.mypagesetting.Margins.Left = this.tempmargintleft;
                this.mypagesetting.Margins.Right = this.tempmargintright;
                this.mypagesetting.Margins.Top = this.tempmarginttop;
                this.mypagesetting.Margins.Bottom = this.tempmargintbottom;
            }
            catch (Exception ex)
            {
            }
            try
            {
                this.TextFont = (Font)this.tempfont.Clone();
                this.TextColor = this.tempforecolor;
                this.WaterMarkColor = this.tempforecolorwater;
                this.WaterMarkFont = (Font)this.tempfontwater.Clone();
                this.WaterMarkLandscape = this.templandscapewater;
                this.mywatermarkopacity = this.tempopacitywater;
                this.myshapedepth = this.tempshapedepth;
                this.myCellmargin = this.tempcellmargin;
            }
            catch (Exception ex2)
            {
            }
            this.IsDrawTableFooterEveryPage = this.tempisdrawtableeverypage;
            this.IsAutoAddEmptyRow = this.tempisautoaddemptyrow;
            this.IsNeedCheckNewPage = this.tempisneedchecknewpage;
            this.myouterborder = this.tempouterborder;
            this.myouterborderwidth = this.tempouterborderwidth;
            this.myouterbordercolor = this.tempouterbordercolor;
            this.myisusedoubleline = this.tempisusedoubleline;
            this.thedoublelinespace = this.tempdoublelinespace;
            this.myIsDGVCellValignmentCenter = this.tempIsDGVCellValignmentCenter;
            this.myisdrawpagefooterline = this.tempIsDrawPageFooterLine;
            this.myisdrawpageheaderline = this.tempIsDrawPageHeaderLine;
            this.myisusedgvpadding = this.tempIsUseDGVPadding;
            this.myPYx = this.tempoffsetx;
            this.myPYy = this.tempoffsety;
        }

        // Token: 0x060013C1 RID: 5057 RVA: 0x00097604 File Offset: 0x00095804
        private float MyConvTo(float oldvalue)
        {
            switch (this.mypageunits)
            {
                case PageExportUnit.CentiMeter:
                    return (float)((double)oldvalue / 2.54);
                case PageExportUnit.Inch:
                    return oldvalue;
            }
            return oldvalue;
        }

        // Token: 0x060013C2 RID: 5058 RVA: 0x00097648 File Offset: 0x00095848
        private float MyConvFrom(float oldvalue)
        {
            switch (this.mypageunits)
            {
                case PageExportUnit.CentiMeter:
                    return (float)((double)oldvalue * 2.54);
                case PageExportUnit.Inch:
                    return oldvalue;
            }
            return oldvalue;
        }

        // Token: 0x060013C3 RID: 5059 RVA: 0x0009768C File Offset: 0x0009588C
        private float ConvFromDisplayToMM(float myw)
        {
            float pixelsperinchx = this.PIXELSPERINCHX;
            return (float)((double)(myw / pixelsperinchx) * 2.54 * 10.0);
        }

        // Token: 0x060013C4 RID: 5060 RVA: 0x000976C0 File Offset: 0x000958C0
        private float ConvFromMMToDisplay(float myw)
        {
            float num = (float)((double)(myw / 10f) / 2.54);
            float num2 = this.PIXELSPERINCHX;
            num2 = num * num2;
            return Convert.ToSingle(Math.Floor(new decimal(num2)));
        }

        // Token: 0x060013C5 RID: 5061 RVA: 0x00097700 File Offset: 0x00095900
        private static bool CanSpanPrint(string myleft, string mymiddle, string myright, ref string mys, ref StringAlignment alg)
        {
            int num = 0;
            StringAlignment stringAlignment = StringAlignment.Near;
            checked
            {
                if (String.Compare(myleft, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Near;
                    mys = myleft;
                }
                if (String.Compare(mymiddle, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Center;
                    mys = mymiddle;
                }
                if (String.Compare(myright, "", false) != 0)
                {
                    num++;
                    stringAlignment = StringAlignment.Far;
                    mys = myright;
                }
                bool result = num == 1;
                alg = stringAlignment;
                return result;
            }
        }

        // Token: 0x060013C6 RID: 5062 RVA: 0x0009776C File Offset: 0x0009596C
        private void SavePageCS()
        {
            PaperSize paperSize = this.mypagesetting.PaperSize;
            this.SavePaperHeightAndWidth(paperSize);
            this.mypages[0].Append("\u0002\u0004");
            this.TheWrite(0, "papersize", Convert.ToString((int)paperSize.Kind));
            if (paperSize.Kind == PaperKind.Custom)
            {
                this.TheWrite(0, "paperzdy", string.Concat(new string[]
                {
                    paperSize.PaperName,
                    "\u0006",
                    Convert.ToString(paperSize.Width),
                    "\u0006",
                    Convert.ToString(paperSize.Height)
                }));
            }
            else
            {
                this.TheWrite(0, "paperzdy", string.Concat(new string[]
                {
                    "[",
                    paperSize.PaperName,
                    "]\u0006",
                    Convert.ToString(paperSize.Width),
                    "\u0006",
                    Convert.ToString(paperSize.Height)
                }));
            }
            this.TheWrite(0, "orientation", Convert.ToString(Interaction.IIf(this.mypagesetting.Landscape, "1", "0")));
            this.TheWrite(0, "leftmargin", Convert.ToString(this.mypagesetting.Margins.Left));
            this.TheWrite(0, "topmargin", Convert.ToString(this.mypagesetting.Margins.Top));
            this.TheWrite(0, "bottommargin", Convert.ToString(this.mypagesetting.Margins.Bottom));
            this.TheWrite(0, "rightmargin", Convert.ToString(this.mypagesetting.Margins.Right));
        }

        // Token: 0x060013C7 RID: 5063 RVA: 0x00097918 File Offset: 0x00095B18
        private void TheWrite(int thepage, string thename, string thevalue)
        {
            string str = thename + "\0" + thevalue;
            this.mypages[thepage].Append("\u0001\u0003" + str);
        }

        // Token: 0x060013C8 RID: 5064 RVA: 0x0009794C File Offset: 0x00095B4C
        private void MyNewPage()
        {
            checked
            {
                if (!Module1.G_CancelDocument)
                {
                    if (this.currentpage + 1 <= this.GetPages())
                    {
                        this.currentpage++;
                        this.Currentx = 0f;
                        this.Currenty = 0f;
                        this.SaveFont(this.r_font, null);
                    }
                    else
                    {
                        this.currentpage = this.GetPages() + 1;
                        this.Currentx = 0f;
                        this.Currenty = 0f;
                        this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[this.currentpage + 1]);
                        this.mypages[this.currentpage] = new StringBuilder("   ");
                        this.NewPageAfter();
                    }
                }
            }
        }

        // Token: 0x060013C9 RID: 5065 RVA: 0x000071F2 File Offset: 0x000053F2
        private void MyNewPage(bool paperLandscape)
        {
            this.mypagesetting.Landscape = paperLandscape;
            this.Pd.DefaultPageSettings = this.mypagesetting;
            this.MyNewPage();
        }

        // Token: 0x060013CA RID: 5066 RVA: 0x00097A10 File Offset: 0x00095C10
        private void SetStatus(string tt)
        {
            if (Strings.InStr(tt, "页眉", CompareMethod.Binary) > 0)
            {
                this.mystatus.Text = string.Concat(new string[]
                {
                    "共[",
                    this.GetPages().ToString(),
                    "]页,生成页眉页脚〖",
                    Convert.ToString(this.currentpage),
                    "〗"
                });
            }
            else
            {
                this.mystatus.Text = "共[" + this.GetPages().ToString() + "]页 ";
            }
            try
            {
                this.SetStatusNew(tt);
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x060013CB RID: 5067 RVA: 0x00097ACC File Offset: 0x00095CCC
        private void myNewDoc()
        {
            if (this.myisshowprogress)
            {
                this.ShowStatus();
            }
            Module1.G_CancelDocument = false;
            this.isstarting = true;
            this.myisendpreview = false;
            this.IsOpenReporting = false;
            this.isprinttoprinter = false;
            this.hasshownewpageerror = false;
            this.currentpage = 0;
            this.Currentx = 0f;
            this.Currenty = 0f;
            this.mypictures = 0;
            this.W_myrtfnum = 0;
            this.W_myrtfC = null;
            this.mypicture = null;
            this.myPaperHeight = null;
            this.myPaperWidth = null;
            this.DelMypages();
            GC.Collect();
            this.mypages = (StringBuilder[])Utils.CopyArray((Array)this.mypages, new StringBuilder[1]);
            this.mypages[0] = new StringBuilder("   ");
            if (this.mypagesetting.PaperSize.Height <= 0 | this.mypagesetting.PaperSize.Width <= 0)
            {
                if (this.IsShowErrorMSG)
                {
                    Interaction.MsgBox("打印纸张类型出现错误(纸张宽度或高度中出现小于等于0的情况)，将使用A4纸进行打印\r\n原因可能是您使用的自定义纸张大小不正确，或者是控件调用.NET的PageSetupDialog方法时不能返回正确的纸张类型\r\n如果您在本控件的页面设置中更换了打印机，而这两个打印机所支持的纸张类型不一致，就有可能出现此问题。\r\n解决办法是，不要在页面设置中更换打印机，而是应该在控制面板中将要进行打印输出的打印机设置为默认打印机。", MsgBoxStyle.OkOnly, "提示信息");
                }
                try
                {
                    foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
                    {
                        PaperSize paperSize = (PaperSize)obj;
                        if (paperSize.Kind == PaperKind.A4)
                        {
                            this.mypagesetting.PaperSize = paperSize;
                            break;
                        }
                    }
                }
                finally
                {

                }
            }
            this.TheWrite(0, "papersize", Convert.ToString((int)this.mypagesetting.PaperSize.Kind));
            this.TheWrite(0, "paperzdy", Convert.ToString(Interaction.IIf(this.PaperKind == PaperKind.Custom, string.Concat(new string[]
            {
                this.mypagesetting.PaperSize.PaperName,
                "\u0006",
                Convert.ToString(this.mypagesetting.PaperSize.Width),
                "\u0006",
                Convert.ToString(this.mypagesetting.PaperSize.Height)
            }), "")));
            this.TheWrite(0, "orientation", Convert.ToString(Interaction.IIf(this.mypagesetting.Landscape, "1", "0")));
            this.TheWrite(0, "leftmargin", Convert.ToString(this.mypagesetting.Margins.Left));
            this.TheWrite(0, "topmargin", Convert.ToString(this.mypagesetting.Margins.Top));
            this.TheWrite(0, "bottommargin", Convert.ToString(this.mypagesetting.Margins.Bottom));
            this.TheWrite(0, "rightmargin", Convert.ToString(this.mypagesetting.Margins.Right));
            PaperSize paperSize2 = this.mypagesetting.PaperSize;
            this.SavePaperHeightAndWidth(paperSize2);
            if (this.tempfont != null)
            {
                this.tempfont.Dispose();
            }
            if (this.tempfontwater != null)
            {
                this.tempfontwater.Dispose();
            }
            this.r_font = this.TextFont;
            this.SaveCS();
        }

        // Token: 0x060013CC RID: 5068 RVA: 0x00097DEC File Offset: 0x00095FEC
        private bool IsPaperSizeEqual(int page1, int page2)
        {
            bool result = true;
            if (page1 == page2)
            {
                result = true;
            }
            else
            {
                try
                {
                    string[] array = Strings.Split(this.mypages[0].ToString(), "\u0002\u0004", -1, CompareMethod.Binary);
                    result = Strings.Trim(array[page1]).Equals(Strings.Trim(array[page2]));
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }
            return result;
        }

        // Token: 0x060013CD RID: 5069 RVA: 0x00097E64 File Offset: 0x00096064
        private void myEndDoc()
        {
            if (this.myisneedprintpageheaderandfooter)
            {
                int num = 1;
                int num2 = this.GetPages();
                int num3 = num;
                while (num3 <= num2 && !this.CancelDocument)
                {
                    this.SetCurrentPage(num3);
                    this.SetStatus(string.Concat(new string[]
                    {
                        "预处理，正在处理第【",
                        Convert.ToString(this.currentpage),
                        "】页的页眉、页脚和水印（共 ",
                        Convert.ToString(this.GetPages()),
                        " 页需要处理）"
                    }));
                    this.myheaderlineposition = 0f;
                    HeaderFooterOutEventHandler headerFooterOutEvent = this.HeaderFooterOut;
                    if (headerFooterOutEvent != null)
                    {
                        headerFooterOutEvent(this.GetPages(), num3);
                    }
                    this.SetCurrentPage(num3);
                    float num4 = 1f;
                    float num5 = 10f;
                    if (this.PageUnits == PageExportUnit.Inch)
                    {
                        num4 = (float)((double)num4 / 2.54);
                        num5 = (float)((double)num5 / 2.54);
                    }
                    if (this.myheaderlineposition == 0f)
                    {
                        num5 = (float)((double)this.PaperMargins.Top / 2.0);
                    }
                    else
                    {
                        num5 = ((float)this.PaperMargins.Top - this.myheaderlineposition) / 2f - num5;
                    }
                    if (this.IsDrawPageHeaderLine)
                    {
                        this.DrawLine(0f, 0f - num5, this.PaperPrintWidth, 0f - num5, Color.Black, num4);
                    }
                    num5 = 10f;
                    if (this.PageUnits == PageExportUnit.Inch)
                    {
                        num4 = (float)((double)num4 / 2.54);
                        num5 = (float)((double)num5 / 2.54);
                    }
                    if (this.IsDrawPageFooterLine)
                    {
                        this.DrawLine(0f, this.PaperPrintHeight + num5, this.PaperPrintWidth, this.PaperPrintHeight + num5, Color.Black, num4);
                    }
                    this.PrintWaterMark();
                    this.PrintZDX();
                    checked
                    {
                        num3++;
                    }
                }
            }
            this.SetStatus("正在生成预览效果");
            this.RestoreCS();
            this.CloseStatus();
            checked
            {
                try
                {
                    this.cpage.Items.Clear();
                    int num6 = 1;
                    int num7 = this.GetPages();
                    for (int i = num6; i <= num7; i++)
                    {
                        this.cpage.Items.Add("第" + Convert.ToString(i) + "页");
                    }
                    this.MyShow();
                    this.Enabled = true;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private progress myprogresswait;
        private void CloseStatus()
        {
            try
            {
                if (this.myprogresswait != null)
                {
                    this.myprogresswait.Dispose();
                    this.myprogresswait = null;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void MyShow()
        {
            this.currentpage = 1;
            this.myisendpreview = false;
            this.isstarting = false;
            this.Pd.DocumentName = Convert.ToString(this.GetPages());
            if (this.myisimmediateprintnotpreview)
            {
                this.myisendpreview = true;
                this.Print(this.myIsImmediatePrintNotPreviewShowPrintDialog);
            }
            else
            {
                this.PrintPreviewControl1.InvalidatePreview();
            }
            try
            {
                this.mystatus.Text = "共【" + Convert.ToString(this.GetPages()) + "】页";
                if (this.GetPages() >= 1)
                {
                    this.cpage.SelectedIndex = 0;
                }
                this.SetPages();
                if (!this.Visible | this.Parent == null)
                {
                }
            }
            catch (Exception ex)
            {
            }
        }

       
        [Description("开始打印")]
        public void Print()
        {
            this.Print(false);
        }

      
        [Description("开始打印")]
        public void Print(bool showdialog)
        {
            this.Print(showdialog, false);
        }

        // Token: 0x06001541 RID: 5441 RVA: 0x000AC1DC File Offset: 0x000AA3DC
        [Description("开始打印")]
        public void Print(bool showdialog, bool isDuplex)
        {
            this.Pd.PrinterSettings.Copies = this._printcopys;
            checked
            {
                if (this.GetPages() > 0)
                {
                    if (!this.isstarting)
                    {
                        while (!this.IsEndPreview)
                        {
                            Thread.Sleep(100);
                            Application.DoEvents();
                        }
                        if (showdialog)
                        {
                            bool flag = false;
                            if (!this.IsUseAPIprintDialog)
                            {
                                switch (this.ShowDefaultPrinterDialog(false, this._printcopys))
                                {
                                    case -1:
                                        switch (this.ShowDefaultPrinterDialog(true, this._printcopys))
                                        {
                                            case -1:
                                                switch (this.ShowAPIPrinterDialog(this._printcopys))
                                                {
                                                    case -1:
                                                        flag = true;
                                                        break;
                                                    case 0:
                                                        flag = true;
                                                        break;
                                                    case 1:
                                                        flag = false;
                                                        break;
                                                }
                                                break;
                                            case 0:
                                                flag = true;
                                                break;
                                            case 1:
                                                flag = false;
                                                break;
                                        }
                                        break;
                                    case 0:
                                        flag = true;
                                        break;
                                    case 1:
                                        flag = false;
                                        break;
                                }
                            }
                            else
                            {
                                switch (this.ShowAPIPrinterDialog(this._printcopys))
                                {
                                    case -1:
                                        switch (this.ShowDefaultPrinterDialog(false, this._printcopys))
                                        {
                                            case -1:
                                                switch (this.ShowDefaultPrinterDialog(true, this._printcopys))
                                                {
                                                    case -1:
                                                        flag = true;
                                                        break;
                                                    case 0:
                                                        flag = true;
                                                        break;
                                                    case 1:
                                                        flag = false;
                                                        break;
                                                }
                                                break;
                                            case 0:
                                                flag = true;
                                                break;
                                            case 1:
                                                flag = false;
                                                break;
                                        }
                                        break;
                                    case 0:
                                        flag = true;
                                        break;
                                    case 1:
                                        flag = false;
                                        break;
                                }
                            }
                            if (!flag)
                            {
                                this.isprinttoprinter = true;
                                Module1.G_CancelPrint = false;
                                this.Pd.DocumentName = this.DocumentName;
                                this.HideDefaultPrintDialog();
                                this.ShowPrintProgressDialog();
                                this.MyParasePage(0);
                                if (!isDuplex)
                                {
                                    if ((int)this.Pd.PrinterSettings.Copies > this.Pd.PrinterSettings.MaximumCopies)
                                    {
                                        int copies = (int)this.Pd.PrinterSettings.Copies;
                                        PrintRange printRange = this.Pd.PrinterSettings.PrintRange;
                                        int fromPage = this.Pd.PrinterSettings.FromPage;
                                        int toPage = this.Pd.PrinterSettings.ToPage;
                                        int num = 1;
                                        int num2 = copies;
                                        for (int i = num; i <= num2; i++)
                                        {
                                            this.isprinttoprinter = true;
                                            this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
                                            this.Pd.DefaultPageSettings = this.mypagesetting;
                                            if (printRange == PrintRange.SomePages)
                                            {
                                                this.currentpage = fromPage;
                                                this.Pd.PrinterSettings.PrintRange = printRange;
                                                this.Pd.PrinterSettings.FromPage = fromPage;
                                                this.Pd.PrinterSettings.ToPage = toPage;
                                            }
                                            else
                                            {
                                                this.currentpage = 1;
                                            }
                                            this.SaveCS();
                                            this.Pd.Print();
                                            this.RestoreCS();
                                            if (Module1.G_CancelPrint)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
                                        this.Pd.DefaultPageSettings = this.mypagesetting;
                                        if (this.Pd.PrinterSettings.PrintRange == PrintRange.SomePages)
                                        {
                                            this.currentpage = this.Pd.PrinterSettings.FromPage;
                                        }
                                        else
                                        {
                                            this.currentpage = 1;
                                        }
                                        this.SaveCS();
                                        try
                                        {
                                            this.Pd.Print();
                                        }
                                        catch (Exception ex)
                                        {
                                        }
                                        this.RestoreCS();
                                    }
                                }
                                else
                                {
                                    this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
                                    this.Pd.PrinterSettings.Copies = 1;
                                    this.Pd.DefaultPageSettings = this.mypagesetting;
                                    int num3;
                                    int toPage2;
                                    if (this.Pd.PrinterSettings.PrintRange == PrintRange.SomePages)
                                    {
                                        num3 = this.Pd.PrinterSettings.FromPage;
                                        toPage2 = this.Pd.PrinterSettings.ToPage;
                                    }
                                    else
                                    {
                                        num3 = 1;
                                        toPage2 = this.GetPages();
                                    }
                                    this.currentpage = num3;
                                    this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
                                    this.w_duplexfrom = num3;
                                    this.w_duplexto = toPage2;
                                    if (num3 % 2 == 0)
                                    {
                                        this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_OS;
                                    }
                                    else
                                    {
                                        this.w_myprintrange = VB2008Print.MyPrintPageRange.PageRange_JS;
                                    }
                                    this.SaveCS();
                                    try
                                    {
                                        this.Pd.Print();
                                    }
                                    catch (Exception ex2)
                                    {
                                    }
                                    try
                                    {
                                        this.RestoreCS();
                                    }
                                    catch (Exception ex3)
                                    {
                                    }
                                    if (toPage2 - num3 >= 1)
                                    {
                                        if (num3 % 2 == 0)
                                        {
                                            Interaction.MsgBox("偶数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印奇数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
                                        }
                                        else
                                        {
                                            Interaction.MsgBox("奇数页已发送到打印机打印，请等待打印机打印完成后，将打印好的纸取出并重新放好，单击 确定 按钮将接着打印偶数页（按页码从小到大的顺序打印）.", MsgBoxStyle.OkOnly, "提示信息");
                                        }
                                        this.Pd.PrinterSettings.Copies = 1;
                                        this.isprinttoprinter = true;
                                        this.Pd.DefaultPageSettings = this.mypagesetting;
                                        this.currentpage = num3 + 1;
                                        this.Pd.PrinterSettings.PrintRange = PrintRange.Selection;
                                        this.w_duplexfrom = num3;
                                        this.w_duplexto = toPage2;
                                        if (num3 % 2 == 0)
                                        {
                                            this.w_myprintrange = MyPrintPageRange.PageRange_JS;
                                        }
                                        else
                                        {
                                            this.w_myprintrange = MyPrintPageRange.PageRange_OS;
                                        }
                                        this.SaveCS();
                                        try
                                        {
                                            this.Pd.Print();
                                        }
                                        catch (Exception ex4)
                                        {
                                        }
                                        try
                                        {
                                            this.RestoreCS();
                                        }
                                        catch (Exception ex5)
                                        {
                                        }
                                    }
                                }
                                Module1.G_CancelPrint = false;
                                this.ClosePrintProgressDialog();
                                EndPrintToPrinterEventHandler endPrintToPrinterEvent = this.EndPrintToPrinter;
                                if (endPrintToPrinterEvent != null)
                                {
                                    endPrintToPrinterEvent();
                                }
                                this.currentpage = 1;
                                this.Pd.PrinterSettings.Copies = 1;
                            }
                            else
                            {
                                EndPrintToPrinterEventHandler endPrintToPrinterEvent = this.EndPrintToPrinter;
                                if (endPrintToPrinterEvent != null)
                                {
                                    endPrintToPrinterEvent();
                                }
                            }
                        }
                        else
                        {
                            this.SaveCS();
                            this.Print(1, this.GetPages());
                            try
                            {
                                this.RestoreCS();
                            }
                            catch (Exception ex6)
                            {
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x060013CF RID: 5071 RVA: 0x00098194 File Offset: 0x00096394
        private void MyEndThread()
        {
            Thread.Sleep(100);
            this.myisendpreview = true;
            if (this.isprinttoprinter)
            {
                this.isprinttoprinter = false;
            }
            else if (this.GetPages() > 0)
            {
                EndPreViewEventHandler endPreViewEvent = this.EndPreView;
                if (endPreViewEvent != null)
                {
                    endPreViewEvent();
                }
            }
        }

        // Token: 0x060013D0 RID: 5072 RVA: 0x000981DC File Offset: 0x000963DC
        private SizeF MeasureString(string txt, bool includedcellmargins = true)
        {
            return this.MeasureString(txt, this.myfont, includedcellmargins);
        }

        // Token: 0x060013D1 RID: 5073 RVA: 0x000981FC File Offset: 0x000963FC
        private SizeF MeasureString(string txt, Font myf, bool includedcellmargins = true)
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
            SizeF result = this.MeasureString(txt, myf, stringFormat, includedcellmargins);
            stringFormat.Dispose();
            return result;
        }

        // Token: 0x060013D2 RID: 5074 RVA: 0x0009823C File Offset: 0x0009643C
        private SizeF MeasureString(string txt, Font myf, SizeF mysize, bool includedcellmargins = true)
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
            SizeF result = this.MeasureString(txt, myf, mysize, stringFormat, includedcellmargins);
            stringFormat.Dispose();
            return result;
        }

        // Token: 0x060013D3 RID: 5075 RVA: 0x00098280 File Offset: 0x00096480
        private SizeF MeasureString(string txt, Font myf, float mywidth, bool includedcellmargins = true)
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
            SizeF result = this.MeasureString(txt, myf, mywidth, stringFormat, includedcellmargins);
            stringFormat.Dispose();
            return result;
        }

        // Token: 0x060013D4 RID: 5076 RVA: 0x000982C4 File Offset: 0x000964C4
        private SizeF MeasureString(string txt, Font myf, float mywidth, StringFormat myformat, bool includedcellmargins = true)
        {
            SizeF sizeF = default(SizeF);
            mywidth = this.MyConvTo(mywidth);
            SizeF result;
            if (!includedcellmargins)
            {
                sizeF = this.myg.MeasureString(txt, myf, checked((int)Math.Round((double)(unchecked(mywidth + 1f)))), myformat);
                sizeF.Width = this.MyConvFrom(sizeF.Width);
                sizeF.Height = this.MyConvFrom(sizeF.Height);
                result = sizeF;
            }
            else
            {
                sizeF = this.myg.MeasureString(txt, myf, checked((int)Math.Round((double)(unchecked(mywidth + 1f - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right))))), myformat);
                sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
                sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
                result = sizeF;
            }
            return result;
        }

        // Token: 0x060013D5 RID: 5077 RVA: 0x000983D8 File Offset: 0x000965D8
        private SizeF MeasureString(string txt, Font myf, StringFormat myformat, bool includedcellmargins = true)
        {
            PointF origin = new PointF(0f, 0f);
            SizeF sizeF = default(SizeF);
            SizeF result;
            if (!includedcellmargins)
            {
                sizeF = this.myg.MeasureString(txt, myf, origin, myformat);
                sizeF.Width = this.MyConvFrom(sizeF.Width);
                sizeF.Height = this.MyConvFrom(sizeF.Height);
                result = sizeF;
            }
            else
            {
                try
                {
                    sizeF = this.myg.MeasureString(txt, myf, origin, myformat);
                }
                catch (Exception ex)
                {
                }
                if (this.myCellmargin != null)
                {
                    sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
                    sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
                }
                result = sizeF;
            }
            return result;
        }

        // Token: 0x060013D6 RID: 5078 RVA: 0x000984D8 File Offset: 0x000966D8
        private SizeF MeasureString(string txt, Font myf, SizeF mysize, StringFormat myformat, bool includedcellmargins = true)
        {
            SizeF sizeF = default(SizeF);
            mysize.Height = this.MyConvTo(mysize.Height) + 1f;
            mysize.Width = this.MyConvTo(mysize.Width) + 1f;
            SizeF result;
            if (!includedcellmargins)
            {
                sizeF = this.myg.MeasureString(txt, myf, mysize, myformat);
                sizeF.Width = this.MyConvFrom(sizeF.Width);
                sizeF.Height = this.MyConvFrom(sizeF.Height);
                result = sizeF;
            }
            else
            {
                mysize.Width = mysize.Width - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right);
                mysize.Height = mysize.Height - this.MyConvTo((float)this.myCellmargin.Top) - this.MyConvTo((float)this.myCellmargin.Bottom);
                sizeF = this.myg.MeasureString(txt, myf, mysize, myformat);
                sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
                sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
                result = sizeF;
            }
            return result;
        }

        // Token: 0x060013D7 RID: 5079 RVA: 0x00098640 File Offset: 0x00096840
        private SizeF MeasureString(string txt, Font myf, SizeF mysize, StringFormat myformat, ref int charactersFitted, ref int linesFilled, bool includedcellmargins = true)
        {
            mysize.Height = this.MyConvTo(mysize.Height) + 1f;
            mysize.Width = this.MyConvTo(mysize.Width) + 1f;
            SizeF sizeF = default(SizeF);
            SizeF result;
            if (!includedcellmargins)
            {
                sizeF = this.myg.MeasureString(txt, myf, mysize, myformat, out charactersFitted, out linesFilled);
                sizeF.Width = this.MyConvFrom(sizeF.Width);
                sizeF.Height = this.MyConvFrom(sizeF.Height);
                result = sizeF;
            }
            else
            {
                mysize.Width = mysize.Width - this.MyConvTo((float)this.myCellmargin.Left) - this.MyConvTo((float)this.myCellmargin.Right);
                mysize.Height = mysize.Height - this.MyConvTo((float)this.myCellmargin.Top) - this.MyConvTo((float)this.myCellmargin.Bottom);
                try
                {
                    sizeF = this.myg.MeasureString(txt, myf, mysize, myformat, out charactersFitted, out linesFilled);
                }
                catch (Exception ex)
                {
                }
                sizeF.Width = this.MyConvFrom(sizeF.Width) + (float)this.myCellmargin.Left + (float)this.myCellmargin.Right;
                sizeF.Height = this.MyConvFrom(sizeF.Height) + (float)this.myCellmargin.Top + (float)this.myCellmargin.Bottom;
                result = sizeF;
            }
            return result;
        }

        // Token: 0x060013D8 RID: 5080 RVA: 0x000987D0 File Offset: 0x000969D0
        private void DrawString(string text, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            SizeF mysize = default(SizeF);
            SizeF sizeF = default(SizeF);
            float currentx = this.Currentx;
            mysize = this.MeasureString(text, myf, myformat, includemargins);
            float num = this.PaperPrintHeight - this.Currenty;
            while (mysize.Height > num)
            {
                mysize.Height = num;
                int num2 = 0;
                int num3 = 0;
                sizeF = this.MeasureString(text, myf, mysize, myformat, ref num2, ref num3, includemargins);
                string text2 = Strings.Mid(text, 1, num2);
                this.Currentx = currentx;
                string text3 = text2;
                RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, sizeF.Width, sizeF.Height);
                this.DrawString(text3, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
                text = Strings.Mid(text, checked(num2 + 1));
                this.MyNewPage();
                mysize = this.MeasureString(text, myf, myformat, includemargins);
                num = this.PaperPrintHeight - this.Currenty;
            }
            if (String.Compare(text, "", false) != 0)
            {
                this.Currentx = currentx;
                string text4 = text;
                RectangleF myrect = new RectangleF(this.Currentx, this.Currenty, mysize.Width, mysize.Height);
                this.DrawString(text4, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
            }
        }

        // Token: 0x060013D9 RID: 5081 RVA: 0x00098910 File Offset: 0x00096B10
        private void DrawString(string text, float mywidth, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            SizeF mysize = default(SizeF);
            SizeF sizeF = default(SizeF);
            mysize = this.MeasureString(text, myf, mywidth, myformat, includemargins);
            float num = this.PaperPrintHeight - this.Currenty;
            float currentx = this.Currentx;
            while (mysize.Height > num)
            {
                mysize.Height = num;
                mysize.Width = mywidth;
                int num2 = 0;
                int num3 = 0;
                sizeF = this.MeasureString(text, myf, mysize, myformat, ref num2, ref num3, includemargins);
                string text2 = Strings.Mid(text, 1, num2);
                string text3 = text2;
                RectangleF myrect = new RectangleF(currentx, this.Currenty, mywidth, sizeF.Height);
                this.DrawString(text3, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
                text = Strings.Mid(text, checked(num2 + 1));
                if (String.Compare(text, "", false) == 0)
                {
                    break;
                }
                this.MyNewPage();
                mysize = this.MeasureString(text, myf, mywidth, myformat, includemargins);
                num = this.PaperPrintHeight - this.Currenty;
            }
            if (String.Compare(text, "", false) != 0)
            {
                string text4 = text;
                RectangleF myrect = new RectangleF(currentx, this.Currenty, mywidth, mysize.Height);
                this.DrawString(text4, myrect, myf, textforecolor, myformat, myborder, 0f, includemargins, backcolor, linecolor, textoutstyle);
            }
        }

        // Token: 0x060013DA RID: 5082 RVA: 0x00098A4C File Offset: 0x00096C4C
        private void DrawString(string s, float mywidth, float myheight, Font myf, Color textforecolor, string myborder, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, textforecolor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
        }

        // Token: 0x060013DB RID: 5083 RVA: 0x00098A90 File Offset: 0x00096C90
        private void DrawString(string s, float mywidth, float myheight, Font myf, string myborder, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            this.DrawOutText(s, this.Currentx, this.Currenty, mywidth, myheight, myf, myborder, this.TextColor, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
        }

        // Token: 0x060013DC RID: 5084 RVA: 0x00098AD8 File Offset: 0x00096CD8
        private void DrawString(string text, RectangleF myrect, Color textforecolor, StringFormat myformat, string myborder, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            this.DrawString(text, myrect, this.myfont, textforecolor, myformat, myborder, minfontsize, includemargins, backcolor, linecolor, textoutstyle);
        }

        // Token: 0x060013DD RID: 5085 RVA: 0x00098B04 File Offset: 0x00096D04
        private void DrawString(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int textoutstyle)
        {
            this.DrawOutText(text, myrect.X, myrect.Y, myrect.Width, myrect.Height, myf, myborder, textforecolor, myformat, minfontsize, includemargins, backcolor, linecolor, textoutstyle, 0f);
        }

        // Token: 0x060013DE RID: 5086 RVA: 0x00098B4C File Offset: 0x00096D4C
        private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Color textforecolor, StringFormat myformat, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
        {
            if (myf == null)
            {
                myf = (Font)this.myfont.Clone();
            }
            if (myf == null)
            {
                myf = new Font("宋体", 10f, FontStyle.Regular);
            }
            RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
            myformat.FormatFlags |= StringFormatFlags.LineLimit;
            bool flag = (myformat.FormatFlags & StringFormatFlags.NoWrap) != StringFormatFlags.NoWrap;
            Font font = null;
            try
            {
                font = (Font)myf.Clone();
            }
            catch (Exception ex)
            {
                try
                {
                    font = Module1.ConvertStringToFont(Module1.ConvertFontToString(myf));
                }
                catch (Exception ex2)
                {
                    font = (Font)this.myfont.Clone();
                }
            }
            float num = myf.Size;
            if (minfontsize > 0f)
            {
                SizeF sizeF = default(SizeF);
                SizeF mysize = new SizeF(mywidth, myheight);
                if (flag)
                {
                    int num2 = 0;
                    int num3 = 0;
                    sizeF = this.MeasureString(s, myf, mysize, myformat, ref num2, ref num3, includemargins);
                    while (num2 < Strings.Len(s) & num > minfontsize)
                    {
                        num -= 1f;
                        font.Dispose();
                        font = null;
                        font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
                        sizeF = this.MeasureString(s, font, mysize, myformat, ref num2, ref num3, includemargins);
                    }
                }
                else
                {
                    sizeF = this.MeasureString(s, myf, myformat, includemargins);
                    while ((sizeF.Height > mysize.Height | sizeF.Width > mysize.Width) & num > minfontsize)
                    {
                        num -= 1f;
                        font.Dispose();
                        font = null;
                        font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
                        sizeF = this.MeasureString(s, font, myformat, includemargins);
                    }
                }
            }
            this.DrawTextTrue(s, myrect, font, textforecolor, myformat, myborder, includemargins, backcolor, linecolor, mytextstyle, angle);
            myrect = default(RectangleF);
            font.Dispose();
            font = null;
        }

        // Token: 0x060013DF RID: 5087 RVA: 0x00098D7C File Offset: 0x00096F7C
        private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Color textforecolor, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical, float minfontsize, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
        {
            if (myf == null)
            {
                myf = (Font)this.myfont.Clone();
            }
            if (myf == null)
            {
                myf = new Font("宋体", 10f, FontStyle.Regular);
            }
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
            stringFormat.LineAlignment = myValg;
            stringFormat.Alignment = myHalg;
            if (!mulline)
            {
                stringFormatFlags |= StringFormatFlags.NoWrap;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.NoWrap;
            }
            if (overflow)
            {
                stringFormatFlags |= StringFormatFlags.NoClip;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.NoClip;
            }
            if (directrighttoleft)
            {
                stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
            }
            if (directionVertical)
            {
                stringFormatFlags |= StringFormatFlags.DirectionVertical;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
            }
            stringFormat.FormatFlags = stringFormatFlags;
            this.DrawOutText(s, x, y, mywidth, myheight, myf, myborder, textforecolor, stringFormat, minfontsize, includemargins, backcolor, linecolor, mytextstyle, angle);
            stringFormat.Dispose();
        }

        // Token: 0x060013E0 RID: 5088 RVA: 0x00098E54 File Offset: 0x00097054
        private void DrawOutText(string s, float x, float y, float mywidth, float myheight, Font myf, string myborder, Brush textbrush, StringFormat myformat, float minfontsize, bool includemargins, Color backcolor, Color linecolor)
        {
            if (myf == null)
            {
                myf = (Font)this.myfont.Clone();
            }
            if (myf == null)
            {
                myf = new Font("宋体", 10f, FontStyle.Regular);
            }
            RectangleF myrect = new RectangleF(x, y, mywidth, myheight);
            myformat.FormatFlags |= StringFormatFlags.LineLimit;
            bool flag = (myformat.FormatFlags & StringFormatFlags.NoWrap) != StringFormatFlags.NoWrap;
            Font font = (Font)myf.Clone();
            float num = myf.Size;
            if (minfontsize > 0f)
            {
                SizeF sizeF = default(SizeF);
                SizeF mysize = new SizeF(mywidth, myheight);
                if (flag)
                {
                    int num2 = 0;
                    int num3 = 0;
                    sizeF = this.MeasureString(s, myf, mysize, myformat, ref num2, ref num3, includemargins);
                    while (num2 < Strings.Len(s) & num > minfontsize)
                    {
                        num -= 1f;
                        font.Dispose();
                        font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
                        sizeF = this.MeasureString(s, font, mysize, myformat, ref num2, ref num3, includemargins);
                    }
                }
                else
                {
                    sizeF = this.MeasureString(s, myf, myformat, includemargins);
                    while ((sizeF.Height > mysize.Height | sizeF.Width > mysize.Width) & num > minfontsize)
                    {
                        num -= 1f;
                        font.Dispose();
                        font = new Font(myf.FontFamily, num, myf.Style, myf.Unit, myf.GdiCharSet, myf.GdiVerticalFont);
                        sizeF = this.MeasureString(s, font, myformat, includemargins);
                    }
                }
            }
            this.DrawTextTrue(s, myrect, font, textbrush, myformat, myborder, includemargins, backcolor, linecolor);
            myrect = default(RectangleF);
            font.Dispose();
        }

        // Token: 0x060013E1 RID: 5089 RVA: 0x00099024 File Offset: 0x00097224
        private void DrawTextTrue(string text, RectangleF myrect, Font myf, Color textforecolor, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor, int mytextstyle, float angle)
        {
            text += "";
            int num = 1;
            string t;
            string t2;
            checked
            {
                do
                {
                    if (Strings.InStr(text, Convert.ToString(Strings.Chr(num)), CompareMethod.Binary) > 0)
                    {
                        text = Strings.Replace(text, Convert.ToString(Strings.Chr(num)), "", 1, -1, CompareMethod.Binary);
                    }
                    num++;
                }
                while (num <= 7);
                if (myformat.LineAlignment == StringAlignment.Center)
                {
                    t = "2";
                }
                else if (myformat.LineAlignment == StringAlignment.Near)
                {
                    t = "1";
                }
                else
                {
                    t = "3";
                }
                if (myformat.Alignment == StringAlignment.Center)
                {
                    t2 = "2";
                }
                else if (myformat.Alignment == StringAlignment.Near)
                {
                    t2 = "1";
                }
                else
                {
                    t2 = "3";
                }
                if (this.SaveFont(myf, this.r_font))
                {
                    this.r_font = myf;
                }
                if (backcolor != Color.White)
                {
                    this.DrawFillRect(myrect, backcolor);
                }
            }
            if (String.Compare(text, "", false) != 0)
            {
                switch (mytextstyle)
                {
                    case 0:
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        break;
                    case 1:
                        if (includemargins)
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        else
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        break;
                    case 2:
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Gray, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Gray, t2, t, myformat.FormatFlags);
                        }
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        break;
                    case 3:
                        if (includemargins)
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Gray, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        else
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Gray, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        if (includemargins)
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        else
                        {
                            this.MyWrite("th", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags, Convert.ToString(angle));
                        }
                        break;
                    case 4:
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
                        }
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.White, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.White, t2, t, myformat.FormatFlags);
                        }
                        break;
                    case 5:
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left - (float)this.ShapeDepth), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top - (float)this.ShapeDepth), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X - (float)this.ShapeDepth), this.MyConvTo(myrect.Y - (float)this.ShapeDepth), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
                        }
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.White, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.White, t2, t, myformat.FormatFlags);
                        }
                        break;
                    case 6:
                        {
                            for (int i = this.ShapeDepth; i >= 0; i = checked(i + -1))
                            {
                                if (includemargins)
                                {
                                    this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left - this.MyConvFrom((float)i)), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top + this.MyConvFrom((float)i)), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, Color.Black, t2, t, myformat.FormatFlags);
                                }
                                else
                                {
                                    this.MyWrite("t", this.MyConvTo(myrect.X - this.MyConvFrom((float)i)), this.MyConvTo(myrect.Y + this.MyConvFrom((float)i)), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, Color.Black, t2, t, myformat.FormatFlags);
                                }
                            }
                            Color t3;
                            if (textforecolor == Color.Black)
                            {
                                t3 = Color.Red;
                            }
                            else
                            {
                                t3 = textforecolor;
                            }
                            if (includemargins)
                            {
                                this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, t3, t2, t, myformat.FormatFlags);
                            }
                            else
                            {
                                this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, t3, t2, t, myformat.FormatFlags);
                            }
                            break;
                        }
                    default:
                        if (includemargins)
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        else
                        {
                            this.MyWrite("t", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, textforecolor, t2, t, myformat.FormatFlags);
                        }
                        break;
                }
            }
            this.Currentx = myrect.X + myrect.Width;
            this.mylastdrawtextheight = this.MyConvTo(myrect.Height);
            this.mylastdrawtextwidth = this.MyConvTo(myrect.Width);
            if (String.Compare(myborder, "", false) != 0)
            {
                float[] array = new float[4];
                array = ParaseBorder(myborder);
                if (array[0] == array[1] & array[1] == array[2] & array[2] == array[3])
                {
                    if (array[0] != 0f)
                    {
                        this.DrawRect(myrect.X, myrect.Y, myrect.Width, myrect.Height, linecolor, array[0]);
                    }
                }
                else
                {
                    if (array[0] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y, myrect.X, myrect.Y + myrect.Height, linecolor, array[0]);
                    }
                    if (array[1] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y, myrect.X + myrect.Width, myrect.Y, linecolor, array[1]);
                    }
                    if (array[2] != 0f)
                    {
                        this.DrawLine(myrect.X + myrect.Width, myrect.Y, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[2]);
                    }
                    if (array[3] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y + myrect.Height, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[3]);
                    }
                }
            }
        }

        // Token: 0x060013E2 RID: 5090 RVA: 0x0009A070 File Offset: 0x00098270
        private void DrawTextTrue(string text, RectangleF myrect, Font myf, Brush textbrush, StringFormat myformat, string myborder, bool includemargins, Color backcolor, Color linecolor)
        {
            text += "";
            int num = 1;
            string t;
            string t2;
            checked
            {
                do
                {
                    if (Strings.InStr(text, Convert.ToString(Strings.Chr(num)), CompareMethod.Binary) > 0)
                    {
                        text = Strings.Replace(text, Convert.ToString(Strings.Chr(num)), "", 1, -1, CompareMethod.Binary);
                    }
                    num++;
                }
                while (num <= 7);
                if (myformat.LineAlignment == StringAlignment.Center)
                {
                    t = "2";
                }
                else if (myformat.LineAlignment == StringAlignment.Near)
                {
                    t = "1";
                }
                else
                {
                    t = "3";
                }
                if (myformat.Alignment == StringAlignment.Center)
                {
                    t2 = "2";
                }
                else if (myformat.Alignment == StringAlignment.Near)
                {
                    t2 = "1";
                }
                else
                {
                    t2 = "3";
                }
                if (this.SaveFont(myf, this.r_font))
                {
                    this.r_font = myf;
                }
                if (backcolor != Color.White)
                {
                    this.DrawFillRect(myrect, backcolor);
                }
            }
            if (String.Compare(text, "", false) != 0)
            {
                if (includemargins)
                {
                    this.MyWrite("t2", this.MyConvTo(myrect.X + (float)this.CellMargin.Left), this.MyConvTo(myrect.Y + (float)this.CellMargin.Top), this.MyConvTo(myrect.Width - (float)this.CellMargin.Left - (float)this.CellMargin.Right), this.MyConvTo(myrect.Height - (float)this.CellMargin.Top - (float)this.CellMargin.Bottom), text, this.SaveBrush(textbrush), t2, t, myformat.FormatFlags);
                }
                else
                {
                    this.MyWrite("t2", this.MyConvTo(myrect.X), this.MyConvTo(myrect.Y), this.MyConvTo(myrect.Width), this.MyConvTo(myrect.Height), text, this.SaveBrush(textbrush), t2, t, myformat.FormatFlags);
                }
            }
            this.Currentx = myrect.X + myrect.Width;
            this.mylastdrawtextheight = this.MyConvTo(myrect.Height);
            this.mylastdrawtextwidth = this.MyConvTo(myrect.Width);
            if (String.Compare(myborder, "", false) != 0)
            {
                float[] array = new float[4];
                array = ParaseBorder(myborder);
                if (array[0] == array[1] & array[1] == array[2] & array[2] == array[3])
                {
                    if (array[0] != 0f)
                    {
                        this.DrawRect(myrect.X, myrect.Y, myrect.Width, myrect.Height, linecolor, array[0]);
                    }
                }
                else
                {
                    if (array[0] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y, myrect.X, myrect.Y + myrect.Height, linecolor, array[0]);
                    }
                    if (array[1] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y, myrect.X + myrect.Width, myrect.Y, linecolor, array[1]);
                    }
                    if (array[2] != 0f)
                    {
                        this.DrawLine(myrect.X + myrect.Width, myrect.Y, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[2]);
                    }
                    if (array[3] != 0f)
                    {
                        this.DrawLine(myrect.X, myrect.Y + myrect.Height, myrect.X + myrect.Width, myrect.Y + myrect.Height, linecolor, array[3]);
                    }
                }
            }
        }

        // Token: 0x060013E3 RID: 5091 RVA: 0x0009A410 File Offset: 0x00098610
        private void MyDrawText2(float x, float y, float mywidth, float myheight, string s, string mybrushstring, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
        {
            Brush brush = RestoreBrush(mybrushstring);
            this.MyDrawTextOut(x, y, mywidth, myheight, s, brush, myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical);
            brush.Dispose();
        }

        // Token: 0x060013E4 RID: 5092 RVA: 0x0009A448 File Offset: 0x00098648
        private void MyDrawText2(float x, float y, float mywidth, float myheight, string s, string mybrushstring, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
        {
            Brush brush = RestoreBrush(mybrushstring);
            this.MyDrawTextOut(x, y, mywidth, myheight, s, brush, myHalg, myValg, myflags);
            brush.Dispose();
        }

        // Token: 0x060013E5 RID: 5093 RVA: 0x0009A47C File Offset: 0x0009867C
        private void MyDrawText(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
        {
            this.MyDrawTextOut(x, y, mywidth, myheight, s, new SolidBrush(color), myHalg, myValg, mulline, overflow, directrighttoleft, directionVertical);
        }

        // Token: 0x060013E6 RID: 5094 RVA: 0x0009A4AC File Offset: 0x000986AC
        private void MyDrawText(float x, float y, float mywidth, float myheight, string s, Color color, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
        {
            this.MyDrawTextOut(x, y, mywidth, myheight, s, new SolidBrush(color), myHalg, myValg, myflags);
        }

        // Token: 0x060013E7 RID: 5095 RVA: 0x0009A4D4 File Offset: 0x000986D4
        private void MyDrawTextOut(float x, float y, float mywidth, float myheight, string s, Brush mybrush, StringAlignment myHalg, StringAlignment myValg, bool mulline, bool overflow, bool directrighttoleft, bool directionVertical)
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            StringFormatFlags stringFormatFlags = stringFormat.FormatFlags;
            if (!mulline)
            {
                stringFormatFlags |= StringFormatFlags.NoWrap;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.NoWrap;
            }
            if (overflow)
            {
                stringFormatFlags |= StringFormatFlags.NoClip;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.NoClip;
            }
            if (directrighttoleft)
            {
                stringFormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionRightToLeft;
            }
            if (directionVertical)
            {
                stringFormatFlags |= StringFormatFlags.DirectionVertical;
            }
            else
            {
                stringFormatFlags &= ~StringFormatFlags.DirectionVertical;
            }
            this.MyDrawTextOut(x, y, mywidth, myheight, s, mybrush, myHalg, myValg, stringFormatFlags);
            stringFormat.Dispose();
        }

        // Token: 0x060013E8 RID: 5096 RVA: 0x0009A55C File Offset: 0x0009875C
        private void MyDrawTextOut(float x, float y, float mywidth, float myheight, string s, Brush mybrush, StringAlignment myHalg, StringAlignment myValg, StringFormatFlags myflags)
        {
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            stringFormat.FormatFlags = (myflags & ~StringFormatFlags.LineLimit);
            stringFormat.Alignment = myHalg;
            stringFormat.LineAlignment = myValg;
            mywidth += 1f;
            RectangleF layoutRectangle = new RectangleF(x + (float)this.mypagesetting.Margins.Left, y + (float)this.mypagesetting.Margins.Top, mywidth, myheight);
            Matrix transform = this.myg.Transform;
            this.PY(this.myg);
            this.myg.DrawString(s, this.myfont, mybrush, layoutRectangle, stringFormat);
            this.myg.Transform = transform;
            stringFormat.Dispose();
            layoutRectangle = default(RectangleF);
        }

        // Token: 0x060013E9 RID: 5097 RVA: 0x00007217 File Offset: 0x00005417
        private void DrawMargin()
        {
            this.MyWrite("mydrawmargin", "");
        }

        // Token: 0x060013EA RID: 5098 RVA: 0x0009A618 File Offset: 0x00098818
        private void MyDrawMargin()
        {
            checked
            {
                if (!this.isprinttoprinter && this.IsDrawmargin)
                {
                    this.myg.DrawRectangle(new Pen(Color.Red, 2f), -2, -2, this.mypagesetting.Margins.Left - 2, this.mypagesetting.Margins.Top - 2);
                    this.myg.DrawRectangle(new Pen(Color.Red, 2f), unchecked(this.MyConvTo(this.PaperPrintWidth) + (float)this.mypagesetting.Margins.Left + 2f), -2f, (float)this.mypagesetting.Margins.Right, (float)(this.mypagesetting.Margins.Top - 2));
                    this.myg.DrawRectangle(new Pen(Color.Red, 2f), -2f, unchecked(this.MyConvTo(this.PaperPrintHeight) + (float)this.mypagesetting.Margins.Top + 2f), (float)(this.mypagesetting.Margins.Left - 2), (float)(this.mypagesetting.Margins.Bottom + 2));
                    this.myg.DrawRectangle(new Pen(Color.Red, 2f), unchecked(this.MyConvTo(this.PaperPrintWidth) + (float)this.mypagesetting.Margins.Left + 2f), unchecked(this.MyConvTo(this.PaperPrintHeight) + (float)this.mypagesetting.Margins.Top + 2f), (float)(this.mypagesetting.Margins.Right + 2), (float)(this.mypagesetting.Margins.Bottom + 2));
                }
            }
        }

        // Token: 0x060013EB RID: 5099 RVA: 0x0009A7D8 File Offset: 0x000989D8
        private void GetPageAndPaperSettings(int thepage)
        {
            checked
            {
                if (thepage >= 0)
                {
                    string[] array;
                    try
                    {
                        array = Strings.Split(this.mypages[0].ToString(), "\u0002\u0004", -1, CompareMethod.Binary);
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                    if (thepage <= Information.UBound(array, 1))
                    {
                        string expression = array[thepage];
                        string[] array2 = Strings.Split(expression, "\u0001\u0003", -1, CompareMethod.Binary);
                        bool flag = true;
                        int num = 0;
                        int num2 = array2.Length - 1;
                        int i = num;
                        while (i <= num2)
                        {
                            try
                            {
                                goto IL_331;
                            }
                            catch (Exception ex2)
                            {
                                goto IL_331;
                            }
                            goto Block_4;
                        IL_328:
                            i++;
                            continue;
                        Block_4:
                            string[] array3;
                            try
                            {
                            IL_83:
                                foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
                                {
                                    PaperSize paperSize = (PaperSize)obj;
                                    if (paperSize.Kind == (PaperKind)Convert.ToInt32(array3[1]) & paperSize.Kind != PaperKind.Custom)
                                    {
                                        this.mypagesetting.PaperSize = paperSize;
                                        if (this.mypagesetting.PaperSize.Width == 0)
                                        {
                                            if (this.IsShowErrorMSG)
                                            {
                                                Interaction.MsgBox("控件纸张类型出现错误，将使用A4纸进行打印\r\n原因是本控件调用.NET的PageSetupDialog方法时不能返回您选择的正确的纸张类型（经上网查询，应该是.NET本身的原因）\r\n如果您在本控件的页面设置中更换了打印机，而这两个打印机所支持的纸张类型不一致，就有可能出现此问题。\r\n解决办法是，不要在页面设置中更换打印机，而是应该在控制面版中将要进行打印输出的打印机设置为默认打印机。", MsgBoxStyle.OkOnly, "提示信息");
                                            }
                                            try
                                            {
                                                foreach (object obj2 in this.Pd.PrinterSettings.PaperSizes)
                                                {
                                                    PaperSize paperSize2 = (PaperSize)obj2;
                                                    if (paperSize2.Kind == PaperKind.A4)
                                                    {
                                                        this.mypagesetting.PaperSize = paperSize2;
                                                        flag = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            finally
                                            {
                                                IEnumerator enumerator2;
                                                if (enumerator2 is IDisposable)
                                                {
                                                    (enumerator2 as IDisposable).Dispose();
                                                }
                                            }
                                        }
                                        flag = false;
                                    IL_17A:
                                        goto IL_328;
                                    }
                                }

                            }
                            finally
                            {
                                IEnumerator enumerator;
                                if (enumerator is IDisposable)
                                {
                                    (enumerator as IDisposable).Dispose();
                                }
                            }
                        IL_195:
                            string left;
                            if (String.Compare(left, "orientation", false) == 0)
                            {
                                if (String.Compare(array3[1], "1", false) == 0)
                                {
                                    this.mypagesetting.Landscape = true;
                                    goto IL_328;
                                }
                                this.mypagesetting.Landscape = false;
                                goto IL_328;
                            }
                            else
                            {
                                if (String.Compare(left, "leftmargin", false) == 0)
                                {
                                    this.mypagesetting.Margins.Left = Convert.ToInt32(array3[1]);
                                    goto IL_328;
                                }
                                if (String.Compare(left, "topmargin", false) == 0)
                                {
                                    this.mypagesetting.Margins.Top = Convert.ToInt32(array3[1]);
                                    goto IL_328;
                                }
                                if (String.Compare(left, "bottommargin", false) == 0)
                                {
                                    this.mypagesetting.Margins.Bottom = Convert.ToInt32(array3[1]);
                                    goto IL_328;
                                }
                                if (String.Compare(left, "rightmargin", false) == 0)
                                {
                                    this.mypagesetting.Margins.Right = Convert.ToInt32(array3[1]);
                                    goto IL_328;
                                }
                                if (String.Compare(left, "paperzdy", false) != 0)
                                {
                                    goto IL_328;
                                }
                                if (String.Compare(Strings.Trim(array3[1] + ""), "", false) == 0)
                                {
                                    goto IL_328;
                                }
                                if (flag)
                                {
                                    string[] array4 = Strings.Split(array3[1], "\u0006", -1, CompareMethod.Binary);
                                    string name = Strings.Trim(array4[0] + "");
                                    int width = Convert.ToInt32(array4[1]);
                                    int height = Convert.ToInt32(array4[2]);
                                    bool flag2 = this.isstarting;
                                    this.isstarting = false;
                                    this.PaperSize = new PaperSize(name, width, height);
                                    this.isstarting = flag2;
                                    goto IL_328;
                                }
                                goto IL_328;
                            }
                        IL_331:
                            array3 = Strings.Split(array2[i], "\0", -1, CompareMethod.Binary);
                            left = array3[0];
                            if (String.Compare(left, "papersize", false) == 0)
                            {

                            }
                            goto IL_195;
                        }
                        try
                        {
                            array2 = null;
                            array = null;
                        }
                        catch (Exception ex3)
                        {
                        }
                    }
                }
            }
        }

        // Token: 0x060013EC RID: 5100 RVA: 0x0009AB9C File Offset: 0x00098D9C
        private void PrintWaterMark()
        {
            if (String.Compare(Strings.Trim(this.mywatermarktext), "", false) != 0)
            {
                StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.FormatFlags &= ~StringFormatFlags.LineLimit;
                if (!this.mywatermarklandscape)
                {
                    stringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
                }
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                Color textforecolor = Color.FromArgb((int)this.mywatermarkopacity, this.mywatermarkcolor);
                RectangleF rectangleF = new RectangleF(0f, 0f, this.PaperPrintWidth, this.PaperPrintHeight);
                this.DrawOutText(this.mywatermarktext, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height, this.mywatermarkfont, "", textforecolor, stringFormat, 0f, false, Color.White, Color.White, 1, 0f);
                this.Currentx = 0f;
                this.Currenty = 0f;
                stringFormat.Dispose();
                rectangleF = default(RectangleF);
            }
        }

        // Token: 0x060013ED RID: 5101 RVA: 0x0009ACA8 File Offset: 0x00098EA8
        private void MyParasePage(int num)
        {
            checked
            {
                if (num != 0)
                {
                    ColorConverter colorConverter = new ColorConverter();
                    FontConverter fontConverter = new FontConverter();
                    string[] array = Strings.Split(this.mypages[num].ToString(), "\u0001\u0003", -1, CompareMethod.Binary);
                    MemoryStream memoryStream = null;
                    int num2 = 0;
                    int num3 = array.Length - 1;
                    int i = num2;
                    while (i <= num3)
                    {
                        try
                        {
                        }
                        catch (Exception ex)
                        {
                        }
                        string[] array2 = Strings.Split(array[i], "\0", -1, CompareMethod.Binary);
                        string left = array2[0];
                        if (String.Compare(left, "papersize", false) == 0)
                        {
                            try
                            {
                                foreach (object obj in this.Pd.PrinterSettings.PaperSizes)
                                {
                                    PaperSize paperSize = (PaperSize)obj;
                                    if (paperSize.Kind == (PaperKind)Convert.ToInt32(array2[1]))
                                    {
                                        this.mypagesetting.PaperSize = paperSize;
                                    }
                                }
                                goto IL_13C2;
                            }
                            finally
                            {

                            }
                            goto IL_E7;
                        }
                        goto IL_E7;
                    IL_13C2:
                        i++;
                        continue;
                    IL_E7:
                        if (String.Compare(left, "orientation", false) == 0)
                        {
                            if (String.Compare(array2[1], "1", false) == 0)
                            {
                                this.mypagesetting.Landscape = true;
                                goto IL_13C2;
                            }
                            this.mypagesetting.Landscape = false;
                            goto IL_13C2;
                        }
                        else
                        {
                            if (String.Compare(left, "leftmargin", false) == 0)
                            {
                                this.mypagesetting.Margins.Left = Convert.ToInt32(array2[1]);
                                goto IL_13C2;
                            }
                            if (String.Compare(left, "topmargin", false) == 0)
                            {
                                this.mypagesetting.Margins.Top = Convert.ToInt32(array2[1]);
                                goto IL_13C2;
                            }
                            if (String.Compare(left, "bottommargin", false) == 0)
                            {
                                this.mypagesetting.Margins.Bottom = Convert.ToInt32(array2[1]);
                                goto IL_13C2;
                            }
                            if (String.Compare(left, "rightmargin", false) == 0)
                            {
                                this.mypagesetting.Margins.Right = Convert.ToInt32(array2[1]);
                                goto IL_13C2;
                            }
                            if (String.Compare(left, "setpage", false) == 0)
                            {
                                this.mypagesetting.PrinterSettings.PrinterName = this.GetCurrentPrinterName();
                                this.Pd.DefaultPageSettings = this.mypagesetting;
                                goto IL_13C2;
                            }
                            if (String.Compare(left, "f", false) == 0)
                            {
                                this.TextFont = (Font)fontConverter.ConvertFromString(array2[1]);
                                if (this.PageScale != 1f & this.isprinttoprinter)
                                {
                                    this.TextFont = new Font(this.TextFont.FontFamily, unchecked(this.TextFont.Size * this.PageScale), this.TextFont.Style, this.TextFont.Unit, this.TextFont.GdiCharSet, this.TextFont.GdiVerticalFont);
                                    goto IL_13C2;
                                }
                                goto IL_13C2;
                            }
                            else
                            {
                                Color color = new Color();
                                if (String.Compare(left, "l", false) == 0)
                                {
                                    float x = Convert.ToSingle(array2[1]);
                                    float y = Convert.ToSingle(array2[2]);
                                    float x2 = Convert.ToSingle(array2[3]);
                                    float y2 = Convert.ToSingle(array2[4]);
                                    object obj2 = colorConverter.ConvertFromString(array2[5]);
                                    this.MyDrawline(x, y, x2, y2, (obj2 != null) ? ((Color)obj2) : color, Convert.ToSingle(array2[6]));
                                    goto IL_13C2;
                                }
                                if (String.Compare(left, "lines", false) == 0)
                                {
                                    this.MyDrawLines(array2[1], array2[2]);
                                    goto IL_13C2;
                                }
                                if (String.Compare(left, "curve", false) == 0)
                                {
                                    switch (array2.Length)
                                    {
                                        case 3:
                                            this.MyDrawCurve(array2[1], array2[2]);
                                            goto IL_13C2;
                                        case 4:
                                            this.MyDrawCurve(array2[1], array2[2], array2[3]);
                                            goto IL_13C2;
                                        case 5:
                                            this.MyDrawCurve(array2[1], array2[2], array2[3], array2[4]);
                                            goto IL_13C2;
                                        case 6:
                                            this.MyDrawCurve(array2[1], array2[2], array2[3], array2[4], array2[5]);
                                            goto IL_13C2;
                                        default:
                                            goto IL_13C2;
                                    }
                                }
                                else if (String.Compare(left, "closedcurve", false) == 0)
                                {
                                    if (array2.Length == 5)
                                    {
                                        this.MyDrawClosedCurve(array2[1], array2[2], array2[3], array2[4]);
                                        goto IL_13C2;
                                    }
                                    this.MyDrawClosedCurve(array2[1], array2[2]);
                                    goto IL_13C2;
                                }
                                else if (String.Compare(left, "fclosedcurve", false) == 0)
                                {
                                    if (array2.Length == 5)
                                    {
                                        this.MyDrawFillClosedCurve(array2[1], array2[2], array2[3], array2[4]);
                                        goto IL_13C2;
                                    }
                                    if (array2.Length == 4)
                                    {
                                        this.MyDrawFillClosedCurve(array2[1], array2[2], array2[3]);
                                        goto IL_13C2;
                                    }
                                    this.MyDrawFillClosedCurve(array2[1], array2[2]);
                                    goto IL_13C2;
                                }
                                else
                                {
                                    if (String.Compare(left, "dl", false) == 0)
                                    {
                                        float x3 = Convert.ToSingle(array2[1]);
                                        float y3 = Convert.ToSingle(array2[2]);
                                        float x4 = Convert.ToSingle(array2[3]);
                                        float y4 = Convert.ToSingle(array2[4]);
                                        object obj3 = colorConverter.ConvertFromString(array2[5]);
                                        this.MyDrawDashline(x3, y3, x4, y4, (obj3 != null) ? ((Color)obj3) : color, Convert.ToSingle(array2[6]), (DashStyle)Convert.ToInt32(array2[7]));
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "r", false) == 0)
                                    {
                                        float x5 = Convert.ToSingle(array2[1]);
                                        float y5 = Convert.ToSingle(array2[2]);
                                        float mywidth = Convert.ToSingle(array2[3]);
                                        float myheight = Convert.ToSingle(array2[4]);
                                        object obj4 = colorConverter.ConvertFromString(array2[5]);
                                        this.MyDrawRect(x5, y5, mywidth, myheight, (obj4 != null) ? ((Color)obj4) : color, Convert.ToSingle(array2[6]));
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "rect", false) == 0)
                                    {
                                        this.MyDrawRect(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "frect", false) == 0)
                                    {
                                        this.MyDrawFillRect(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "rects", false) == 0)
                                    {
                                        this.MyDrawRectangles(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "frects", false) == 0)
                                    {
                                        this.MyDrawFillRectangles(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "polygon", false) == 0)
                                    {
                                        this.MyDrawPolygon(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    if (String.Compare(left, "fpolygon", false) == 0)
                                    {
                                        if (array2.Length == 4)
                                        {
                                            this.MyDrawFillPolygon(array2[1], array2[2], array2[3]);
                                            goto IL_13C2;
                                        }
                                        this.MyDrawFillPolygon(array2[1], array2[2]);
                                        goto IL_13C2;
                                    }
                                    else
                                    {
                                        if (String.Compare(left, "i", false) == 0)
                                        {
                                            Image image;
                                            if (Versioned.IsNumeric(array2[1]))
                                            {
                                                memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                image = Image.FromStream(memoryStream, true, true);
                                            }
                                            else
                                            {
                                                image = Module1.ConvertStringToImage(array2[1]);
                                            }
                                            this.MyDrawImage(image, Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]));
                                            image.Dispose();
                                            if (memoryStream != null)
                                            {
                                                memoryStream.Dispose();
                                            }
                                            memoryStream = null;
                                            goto IL_13C2;
                                        }
                                        if (String.Compare(left, "p", false) == 0)
                                        {
                                            Image image = Module1.ConvertStringToImage(array2[1]);
                                            this.MyDrawImage(image, Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]));
                                            image.Dispose();
                                            goto IL_13C2;
                                        }
                                        if (String.Compare(left, "i2", false) == 0)
                                        {
                                            Image image;
                                            if (Versioned.IsNumeric(array2[1]))
                                            {
                                                memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                image = Image.FromStream(memoryStream, true, true);
                                            }
                                            else
                                            {
                                                image = Module1.ConvertStringToImage(array2[1]);
                                            }
                                            this.MyDrawImage(image, Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]), Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]));
                                            image.Dispose();
                                            if (memoryStream != null)
                                            {
                                                memoryStream.Dispose();
                                            }
                                            memoryStream = null;
                                            goto IL_13C2;
                                        }
                                        if (String.Compare(left, "DrawImageUnscaledAndClipped", false) == 0)
                                        {
                                            Image image;
                                            if (Versioned.IsNumeric(array2[1]))
                                            {
                                                memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                image = Image.FromStream(memoryStream, true, true);
                                            }
                                            else
                                            {
                                                image = Module1.ConvertStringToImage(array2[1]);
                                            }
                                            this.MyDrawImageUnscaledAndClipped(image, array2[2]);
                                            image.Dispose();
                                            if (memoryStream != null)
                                            {
                                                memoryStream.Dispose();
                                            }
                                            memoryStream = null;
                                            goto IL_13C2;
                                        }
                                        if (String.Compare(left, "DrawImageUnscaled", false) == 0)
                                        {
                                            Image image;
                                            if (Versioned.IsNumeric(array2[1]))
                                            {
                                                memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                image = Image.FromStream(memoryStream, true, true);
                                            }
                                            else
                                            {
                                                image = Module1.ConvertStringToImage(array2[1]);
                                            }
                                            this.MyDrawImageUnscaled(image, array2[2]);
                                            image.Dispose();
                                            if (memoryStream != null)
                                            {
                                                memoryStream.Dispose();
                                            }
                                            memoryStream = null;
                                            goto IL_13C2;
                                        }
                                        StringAlignment myHalg;
                                        StringAlignment myValg;
                                        if (String.Compare(left, "t", false) != 0)
                                        {
                                            if (String.Compare(left, "t2", false) != 0)
                                            {
                                                if (String.Compare(left, "th", false) == 0)
                                                {
                                                    if (String.Compare(array2[7], "2", false) == 0)
                                                    {
                                                        myHalg = StringAlignment.Center;
                                                    }
                                                    else if (String.Compare(array2[7], "3", false) == 0)
                                                    {
                                                        myHalg = StringAlignment.Far;
                                                    }
                                                    else
                                                    {
                                                        myHalg = StringAlignment.Near;
                                                    }
                                                    if (String.Compare(array2[8], "2", false) == 0)
                                                    {
                                                        myValg = StringAlignment.Center;
                                                    }
                                                    else if (String.Compare(array2[8], "3", false) == 0)
                                                    {
                                                        myValg = StringAlignment.Far;
                                                    }
                                                    else
                                                    {
                                                        myValg = StringAlignment.Near;
                                                    }
                                                    if (array2.Length > 11)
                                                    {
                                                        float x6 = Convert.ToSingle(array2[1]);
                                                        float y6 = Convert.ToSingle(array2[2]);
                                                        float mywidth2 = Convert.ToSingle(array2[3]);
                                                        float myheight2 = Convert.ToSingle(array2[4]);
                                                        string s = array2[5];
                                                        object obj5 = colorConverter.ConvertFromString(array2[6]);
                                                        this.MydrawtextHollow(x6, y6, mywidth2, myheight2, s, (obj5 != null) ? ((Color)obj5) : color, myHalg, myValg, DataTypeConversion.ToBoolean(array2[9]), DataTypeConversion.ToBoolean(array2[10]), DataTypeConversion.ToBoolean(array2[11]), DataTypeConversion.ToBoolean(array2[12]), Convert.ToSingle(Convert.ToDecimal(array2[13])));
                                                        goto IL_13C2;
                                                    }
                                                    float x7 = Convert.ToSingle(array2[1]);
                                                    float y7 = Convert.ToSingle(array2[2]);
                                                    float mywidth3 = Convert.ToSingle(array2[3]);
                                                    float myheight3 = Convert.ToSingle(array2[4]);
                                                    string s2 = array2[5];
                                                    object obj6 = colorConverter.ConvertFromString(array2[6]);
                                                    this.MydrawtextHollow(x7, y7, mywidth3, myheight3, s2, (obj6 != null) ? ((Color)obj6) : color, myHalg, myValg, (StringFormatFlags)Convert.ToInt32(array2[9]), Convert.ToSingle(Convert.ToDecimal(array2[10])));
                                                    goto IL_13C2;
                                                }
                                                else
                                                {
                                                    if (String.Compare(left, "mydrawmargin", false) == 0)
                                                    {
                                                        this.MyDrawMargin();
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "rf", false) == 0)
                                                    {
                                                        float x8 = Convert.ToSingle(array2[1]);
                                                        float y8 = Convert.ToSingle(array2[2]);
                                                        float mywidth4 = Convert.ToSingle(array2[3]);
                                                        float myheight4 = Convert.ToSingle(array2[4]);
                                                        object obj7 = colorConverter.ConvertFromString(array2[5]);
                                                        this.MyDrawFillRect(x8, y8, mywidth4, myheight4, (obj7 != null) ? ((Color)obj7) : color);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "arc", false) == 0)
                                                    {
                                                        float x9 = Convert.ToSingle(array2[1]);
                                                        float y9 = Convert.ToSingle(array2[2]);
                                                        float mywidth5 = Convert.ToSingle(array2[3]);
                                                        float myheight5 = Convert.ToSingle(array2[4]);
                                                        object obj8 = colorConverter.ConvertFromString(array2[5]);
                                                        this.MyDrawArc(x9, y9, mywidth5, myheight5, (obj8 != null) ? ((Color)obj8) : color, Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]), Convert.ToSingle(array2[8]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "arc2", false) == 0)
                                                    {
                                                        this.MyDrawArc2(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5], Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "bezier", false) == 0)
                                                    {
                                                        this.MyDrawBezier(array2[1], Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]), Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]), Convert.ToSingle(array2[8]), Convert.ToSingle(array2[9]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "beziers", false) == 0)
                                                    {
                                                        this.MyDrawBeziers(array2[1], array2[2]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "de", false) == 0)
                                                    {
                                                        float x10 = Convert.ToSingle(array2[1]);
                                                        float y10 = Convert.ToSingle(array2[2]);
                                                        float mywidth6 = Convert.ToSingle(array2[3]);
                                                        float myheight6 = Convert.ToSingle(array2[4]);
                                                        object obj9 = colorConverter.ConvertFromString(array2[5]);
                                                        this.MyDrawEllipse(x10, y10, mywidth6, myheight6, (obj9 != null) ? ((Color)obj9) : color, Convert.ToSingle(array2[6]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "ellipse", false) == 0)
                                                    {
                                                        this.MyDrawEllipse(array2[1], array2[2]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "dfe", false) == 0)
                                                    {
                                                        float x11 = Convert.ToSingle(array2[1]);
                                                        float y11 = Convert.ToSingle(array2[2]);
                                                        float mywidth7 = Convert.ToSingle(array2[3]);
                                                        float myheight7 = Convert.ToSingle(array2[4]);
                                                        object obj10 = colorConverter.ConvertFromString(array2[5]);
                                                        this.MyDrawFillEllipse(x11, y11, mywidth7, myheight7, (obj10 != null) ? ((Color)obj10) : color);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "fellipse", false) == 0)
                                                    {
                                                        this.MyDrawFillEllipse(array2[1], array2[2]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "rtf", false) == 0)
                                                    {
                                                        this.MyDrawRTF(this.W_myrtfC[Convert.ToInt32(array2[1])].mypi, Convert.ToInt32(array2[2]), Convert.ToInt32(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]), Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]), Convert.ToSingle(array2[8]), Convert.ToSingle(array2[9]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "pie", false) == 0)
                                                    {
                                                        this.MyDrawPie(array2[1], array2[2], array2[3], array2[4]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "fpie", false) == 0)
                                                    {
                                                        this.MyDrawFillPie(array2[1], array2[2], array2[3], array2[4]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "dp", false) == 0)
                                                    {
                                                        this.myDrawPath(array2[1], array2[2], array2[3]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "fp", false) == 0)
                                                    {
                                                        try
                                                        {
                                                            GraphicsPath graphicsPath = RestoreGraphicsPath(array2[1], array2[2]);
                                                            if (graphicsPath == null)
                                                            {
                                                                return;
                                                            }
                                                            Brush brush = RestoreBrush(array2[3]);
                                                            if (brush == null)
                                                            {
                                                                graphicsPath.Dispose();
                                                            }
                                                            else
                                                            {
                                                                this.myDrawFillPath(graphicsPath, brush);
                                                                brush.Dispose();
                                                                graphicsPath.Dispose();
                                                            }
                                                            goto IL_13C2;
                                                        }
                                                        catch (Exception ex2)
                                                        {
                                                            goto IL_13C2;
                                                        }
                                                    }
                                                    if (String.Compare(left, "resetrotate", false) == 0)
                                                    {
                                                        this.MyResetRotate();
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "rotate", false) == 0)
                                                    {
                                                        this.MyRotate(Convert.ToDouble(array2[1]), Convert.ToDouble(array2[2]), Convert.ToDouble(array2[3]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "ttf", false) == 0)
                                                    {
                                                        this.myTranslateTransform(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "ttf2", false) == 0)
                                                    {
                                                        this.myTranslateTransform(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), (MatrixOrder)Convert.ToInt32(array2[3]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "rtff", false) == 0)
                                                    {
                                                        this.myRotateTransform(Convert.ToSingle(array2[1]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "rtff2", false) == 0)
                                                    {
                                                        this.myRotateTransform(Convert.ToSingle(array2[1]), (MatrixOrder)Convert.ToInt32(array2[2]));
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "drawmetaimage", false) == 0)
                                                    {
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "drawchartlet", false) == 0)
                                                    {
                                                        this.MyDrawChartlet(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "drawexpress", false) == 0)
                                                    {
                                                        this.MyDrawExpression(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "setclip", false) == 0)
                                                    {
                                                        this.mySetClip(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "setclip2", false) == 0)
                                                    {
                                                        this.mySetClip(array2[1], array2[2], array2[3]);
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "resetclip", false) == 0)
                                                    {
                                                        this.myResetClip();
                                                        goto IL_13C2;
                                                    }
                                                    if (String.Compare(left, "i3", false) == 0)
                                                    {
                                                        Image image;
                                                        if (Versioned.IsNumeric(array2[1]))
                                                        {
                                                            memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                            image = Image.FromStream(memoryStream, true, true);
                                                        }
                                                        else
                                                        {
                                                            image = Module1.ConvertStringToImage(array2[1]);
                                                        }
                                                        this.MyDrawImage(image, array2[2], Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]), Convert.ToSingle(array2[6]), Convert.ToInt32(array2[7]));
                                                        image.Dispose();
                                                        if (memoryStream != null)
                                                        {
                                                            memoryStream.Dispose();
                                                            goto IL_13C2;
                                                        }
                                                        goto IL_13C2;
                                                    }
                                                    else if (String.Compare(left, "i4", false) == 0)
                                                    {
                                                        Image image;
                                                        if (Versioned.IsNumeric(array2[1]))
                                                        {
                                                            memoryStream = new MemoryStream(this.mypicture[Convert.ToInt32(array2[1])].mypi);
                                                            image = Image.FromStream(memoryStream, true, true);
                                                        }
                                                        else
                                                        {
                                                            image = Module1.ConvertStringToImage(array2[1]);
                                                        }
                                                        this.MyDrawImage(image, Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), Convert.ToSingle(array2[5]), Convert.ToSingle(array2[6]), Convert.ToSingle(array2[7]), Convert.ToInt32(array2[8]));
                                                        image.Dispose();
                                                        if (memoryStream != null)
                                                        {
                                                            memoryStream.Dispose();
                                                            goto IL_13C2;
                                                        }
                                                        goto IL_13C2;
                                                    }
                                                    else if (String.Compare(left, "drawicon", false) == 0)
                                                    {
                                                        Icon icon = Module1.ConvertStringToIcon(array2[3]);
                                                        if (icon != null)
                                                        {
                                                            this.myDrawIcon(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), icon);
                                                            goto IL_13C2;
                                                        }
                                                        goto IL_13C2;
                                                    }
                                                    else if (String.Compare(left, "drawicon2", false) == 0)
                                                    {
                                                        Icon icon2 = Module1.ConvertStringToIcon(array2[2]);
                                                        if (icon2 != null)
                                                        {
                                                            this.myDrawIcon(array2[1], icon2);
                                                            goto IL_13C2;
                                                        }
                                                        goto IL_13C2;
                                                    }
                                                    else
                                                    {
                                                        if (String.Compare(left, "shape", false) == 0)
                                                        {
                                                            this.MyDrawShape(array2[1], array2[2], Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]));
                                                            goto IL_13C2;
                                                        }
                                                        goto IL_13C2;
                                                    }
                                                }
                                            }
                                        }
                                        if (String.Compare(array2[7], "2", false) == 0)
                                        {
                                            myHalg = StringAlignment.Center;
                                        }
                                        else if (String.Compare(array2[7], "3", false) == 0)
                                        {
                                            myHalg = StringAlignment.Far;
                                        }
                                        else
                                        {
                                            myHalg = StringAlignment.Near;
                                        }
                                        if (String.Compare(array2[8], "2", false) == 0)
                                        {
                                            myValg = StringAlignment.Center;
                                        }
                                        else if (String.Compare(array2[8], "3", false) == 0)
                                        {
                                            myValg = StringAlignment.Far;
                                        }
                                        else
                                        {
                                            myValg = StringAlignment.Near;
                                        }
                                        if (String.Compare(array2[0], "t2", false) == 0)
                                        {
                                            if (array2.Length > 10)
                                            {
                                                this.MyDrawText2(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5], array2[6], myHalg, myValg, DataTypeConversion.ToBoolean(array2[9]), DataTypeConversion.ToBoolean(array2[10]), DataTypeConversion.ToBoolean(array2[11]), DataTypeConversion.ToBoolean(array2[12]));
                                                goto IL_13C2;
                                            }
                                            this.MyDrawText2(Convert.ToSingle(array2[1]), Convert.ToSingle(array2[2]), Convert.ToSingle(array2[3]), Convert.ToSingle(array2[4]), array2[5], array2[6], myHalg, myValg, (StringFormatFlags)Convert.ToInt32(array2[9]));
                                            goto IL_13C2;
                                        }
                                        else
                                        {
                                            if (array2.Length > 10)
                                            {
                                                float x12 = Convert.ToSingle(array2[1]);
                                                float y12 = Convert.ToSingle(array2[2]);
                                                float mywidth8 = Convert.ToSingle(array2[3]);
                                                float myheight8 = Convert.ToSingle(array2[4]);
                                                string s3 = array2[5];
                                                object obj11 = colorConverter.ConvertFromString(array2[6]);
                                                this.MyDrawText(x12, y12, mywidth8, myheight8, s3, (obj11 != null) ? ((Color)obj11) : color, myHalg, myValg, DataTypeConversion.ToBoolean(array2[9]), DataTypeConversion.ToBoolean(array2[10]), DataTypeConversion.ToBoolean(array2[11]), DataTypeConversion.ToBoolean(array2[12]));
                                                goto IL_13C2;
                                            }
                                            float x13 = Convert.ToSingle(array2[1]);
                                            float y13 = Convert.ToSingle(array2[2]);
                                            float mywidth9 = Convert.ToSingle(array2[3]);
                                            float myheight9 = Convert.ToSingle(array2[4]);
                                            string s4 = array2[5];
                                            object obj12 = colorConverter.ConvertFromString(array2[6]);
                                            this.MyDrawText(x13, y13, mywidth9, myheight9, s4, (obj12 != null) ? ((Color)obj12) : color, myHalg, myValg, (StringFormatFlags)Convert.ToInt32(array2[9]));
                                            goto IL_13C2;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    try
                    {
                        fontConverter = null;
                        array = null;
                        colorConverter = null;
                        memoryStream = null;
                    }
                    catch (Exception ex3)
                    {
                    }
                }
            }
        }

        // Token: 0x060013EE RID: 5102 RVA: 0x0009C0D4 File Offset: 0x0009A2D4
        private void SetPages(int num)
        {
            if (this.GetPages() > 0 && num > 0)
            {
                if (this.mytype1.Checked)
                {
                    this.cpage.Enabled = false;
                    this.fpage.Enabled = false;
                    this.ppage.Enabled = false;
                    this.npage.Enabled = false;
                    this.lpage.Enabled = false;
                    this.PrintPreviewControl1.Columns = num;
                    this.PrintPreviewControl1.Rows = checked((int)Math.Round(Math.Ceiling((double)this.GetPages() / (double)num)));
                }
                else if (this.GetPages() > 0)
                {
                    this.cpage.Enabled = true;
                    this.PrintPreviewControl1.Columns = num;
                    this.PrintPreviewControl1.Rows = 1;
                    string left = Convert.ToString(this.cpage.SelectedItem);
                    if (String.Compare(left, "", false) == 0)
                    {
                        this.cpage.SelectedIndex = 0;
                    }
                    this.cpage_SelectedIndexChanged(null, null);
                }
            }
        }

        // Token: 0x060013EF RID: 5103 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
        private void SetPages()
        {
            if (this.ToolStripMenuItem_7.Checked)
            {
                this.SetPages(1);
            }
            else if (this.ToolStripMenuItem_8.Checked)
            {
                this.SetPages(2);
            }
            else if (this.ToolStripMenuItem_9.Checked)
            {
                this.SetPages(3);
            }
            else if (this.ToolStripMenuItem_10.Checked)
            {
                this.SetPages(4);
            }
            else if (this.ToolStripMenuItem_11.Checked)
            {
                this.SetPages(5);
            }
            else if (this.ToolStripMenuItem_12.Checked)
            {
                this.SetPages(6);
            }
            else if (this.ToolStripMenuItem_13.Checked)
            {
                this.SetPages(8);
            }
            else if (this.ToolStripMenuItem_14.Checked)
            {
                this.SetPages(10);
            }
        }

        // Token: 0x060013F0 RID: 5104 RVA: 0x0009C298 File Offset: 0x0009A498
        private float PrintDGVOut(DataGridView mymstoprint, int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, bool autoformat, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
        {
            float result;
            if (Module1.G_CancelDocument)
            {
                result = 0f;
            }
            else
            {
                Module1.CopyDataGridView(mymstoprint, this.myms);
                if (autoformat)
                {
                    this.myms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
                result = this.PrintDGVOut(colsnum, thecol, fromrow, torow, title, titleFont, subtitle, subtitlefont, alignment, myborder, autoresizewidth, autoresizerowheight, reppagetitle, topfont, lefttitle, middletitle, righttitle, bottomfont, bl, bm, br, minfontsize, mytitleheight, myoneline1height, mysubtitleheight, myoneline2height, mytopheight, PrintBackColor, titletextstyle, subtitlestyle, columnheadertree, TableTopLeftTitleAlign, TableTopMiddleTitleAlign, TableTopRightTitleAlign, TableBottomLeftTitleAlign, TableBottomMiddleTitleAlign, TableBottomRightTitleAlign, CanAddEmptyRow, mybottomheight, printwidth);
            }
            return result;
        }

        // Token: 0x060013F1 RID: 5105 RVA: 0x0009C334 File Offset: 0x0009A534
        private float PrintDGVOut(int colsnum, int[] thecol, int fromrow, int torow, string title, Font titleFont, string subtitle, Font subtitlefont, StringAlignment alignment, string myborder, bool autoresizewidth, bool autoresizerowheight, bool reppagetitle, Font topfont, string lefttitle, string middletitle, string righttitle, Font bottomfont, string bl, string bm, string br, float minfontsize, float mytitleheight, float myoneline1height, float mysubtitleheight, float myoneline2height, float mytopheight, bool PrintBackColor, int titletextstyle, int subtitlestyle, TreeView columnheadertree, StringAlignment TableTopLeftTitleAlign, StringAlignment TableTopMiddleTitleAlign, StringAlignment TableTopRightTitleAlign, StringAlignment TableBottomLeftTitleAlign, StringAlignment TableBottomMiddleTitleAlign, StringAlignment TableBottomRightTitleAlign, bool CanAddEmptyRow, float mybottomheight, float printwidth = 0f)
        {
            StringFormat stringFormat;
            StringFormat stringFormat2;
            int num5;
            int[] array;
            int[] array3;
            int[] array4;
            float[] array5;
            float num14 = 0;
            float num15 = 0;
            float num16 = 0;
            float num17 = 0;
            mytree mytree = null;
            float[] array7;
            float result = 0;
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.myms.ColumnCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        int num3 = 0;
                        int num4 = this.myms.RowCount - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            string left = Convert.ToString(this.myms.Rows[j].Cells[i].Tag);
                            if (String.Compare(left, "水平合并", false) != 0 & String.Compare(left, "垂直合并", false) != 0 & String.Compare(left, "合并", false) != 0 & String.Compare(left, "不合并", false) != 0 & String.Compare(left, "上合并", false) != 0 & String.Compare(left, "下合并", false) != 0 & String.Compare(left, "左合并", false) != 0 & String.Compare(left, "右合并", false) != 0 & String.Compare(left, "左上合并", false) != 0 & String.Compare(left, "左下合并", false) != 0 & String.Compare(left, "右上合并", false) != 0 & String.Compare(left, "右下合并", false) != 0 & String.Compare(left, "上边合并", false) != 0 & String.Compare(left, "下边合并", false) != 0 & String.Compare(left, "左边合并", false) != 0 & String.Compare(left, "右边合并", false) != 0)
                            {
                                if (String.Compare(Convert.ToString(this.myms.Columns[i].Tag), "合并", false) == 0)
                                {
                                    if (String.Compare(Convert.ToString(this.myms.Rows[j].Tag), "合并", false) == 0)
                                    {
                                        this.myms.Rows[j].Cells[i].Tag = "合并";
                                    }
                                    else
                                    {
                                        this.myms.Rows[j].Cells[i].Tag = "垂直合并";
                                    }
                                }
                                else if (String.Compare(Convert.ToString(this.myms.Rows[j].Tag), "合并", false) == 0)
                                {
                                    this.myms.Rows[j].Cells[i].Tag = "水平合并";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                if (titleFont == null)
                {
                    titleFont = new Font("黑体", 18f, FontStyle.Bold);
                }
                if (subtitlefont == null)
                {
                    subtitlefont = new Font("隶书", 15f, FontStyle.Regular);
                }
                if (topfont == null)
                {
                    topfont = new Font("宋体", 10f, FontStyle.Regular);
                }
                if (bottomfont == null)
                {
                    bottomfont = new Font("宋体", 10f, FontStyle.Regular);
                }
                stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat2 = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
                if (colsnum == 0)
                {
                    num5 = this.myms.ColumnCount;
                }
                else
                {
                    num5 = colsnum;
                }
                array = new int[num5 - 1 + 1];
                if (colsnum == 0)
                {
                    thecol = new int[num5 - 1 + 1];
                    int num6 = 0;
                    int num7 = num5 - 1;
                    for (int k = num6; k <= num7; k++)
                    {
                        thecol[k] = k;
                    }
                }
                if (fromrow > torow)
                {
                    fromrow = 0;
                }
                if (fromrow <= 0)
                {
                    fromrow = 1;
                }
                if (torow <= 0)
                {
                    torow = this.myms.RowCount;
                }
                fromrow--;
                torow--;
                int[] array2 = new int[num5 - 1 + 1];
                int num8 = 0;
                int num9 = num5 - 1;
                for (int k = num8; k <= num9; k++)
                {
                    array[k] = thecol[k];
                    array2[k] = this.myms.Columns[thecol[k]].DisplayIndex;
                }
                Array.Sort<int, int>(array2, array);
                array3 = new int[num5 + 1];
                array4 = new int[this.myms.RowCount + 1];
                int num10 = 0;
                int num11 = num5 - 1;
                for (int k = num10; k <= num11; k++)
                {
                    array3[k] = this.myms.Columns[thecol[k]].Width;
                }
                array4[0] = Convert.ToInt32(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0));
                int num12 = fromrow;
                int num13 = torow;
                for (int k = num12; k <= num13; k++)
                {
                    array4[k + 1] = this.myms.Rows[k].Height;
                }
                array5 = new float[num5 - 1 + 1];
                int[] array6 = new int[num5 - 1 + 1];
                num14 = 0f;
                num15 = this.Currentx;
                num16 = num15;
                if (printwidth <= 0f)
                {
                    num17 = unchecked(this.PaperPrintWidth - num16);
                }
                else
                {
                    num17 = printwidth;
                }
                int num18 = 0;
                int num19 = num5 - 1;
                for (int k = num18; k <= num19; k++)
                {
                    unchecked
                    {
                        if (this.myms.Columns[array[k]].Visible)
                        {
                            DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[k]];
                            float num20 = this.ConvFromDisplay((float)dataGridViewColumn.Width, true);
                            array6[k] = dataGridViewColumn.Width;
                            num14 += num20;
                            array5[k] = num20;
                        }
                    }
                }
                mytree = new mytree(columnheadertree, this.myms);
                if (mytree.GetColumns() != this.myms.ColumnCount)
                {
                    columnheadertree = null;
                }
                if (mytitleheight != 0f)
                {
                    int columnHeadersHeight = this.myms.ColumnHeadersHeight;
                    this.myms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    this.myms.ColumnHeadersHeight = columnHeadersHeight;
                }
                else if (columnheadertree != null)
                {
                }
                array7 = new float[this.myms.ColumnCount - 1 + 1];
                if (autoresizewidth)
                {
                    if (num14 == 0f)
                    {
                        if (this.IsShowErrorMSG)
                        {
                            Interaction.MsgBox("不能打印DatGridView表格，当前没有可供打印的列数据", MsgBoxStyle.OkOnly, "提示信息");
                        }
                        return 0f;
                    }
                    float num21 = num17 / num14;
                    int num22 = 0;
                    int num23 = num5 - 1;
                    for (int k = num22; k <= num23; k++)
                    {
                        unchecked
                        {
                            array5[k] *= num21;
                        }
                        this.myms.Columns[array[k]].Width = (int)Math.Round((double)(unchecked((float)array6[k] * num21)));
                        array7[array[k]] = array5[k];
                    }
                    num14 = 0f;
                    int num24 = 0;
                    int num25 = num5 - 1;
                    for (int k = num24; k <= num25; k++)
                    {
                        unchecked
                        {
                            num14 += array5[k];
                        }
                    }
                    if (autoresizerowheight)
                    {
                        this.myms.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    }
                }
                else
                {
                    int num26 = 0;
                    int num27 = num5 - 1;
                    for (int k = num26; k <= num27; k++)
                    {
                        array7[array[k]] = array5[k];
                    }
                }
                result = num14;
            }
            if (alignment == StringAlignment.Center)
            {
                float num28 = num17 - num14;
                num15 = num16 + num28 / 2f;
            }
            else if (alignment == StringAlignment.Far)
            {
                num15 = num16 + num17 - num14;
            }
            int currentPage = this.GetCurrentPage();
            float num29 = 0f;
            num29 = this.ConvFromDisplay(Convert.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false);
            stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
            StringAlignment myHalg = StringAlignment.Near;
            string text = "";
            bool flag = false;
            StringAlignment myHalg2 = StringAlignment.Near;
            string text2 = "";
            bool flag2 = false;
            if (flag = CanSpanPrint(lefttitle, middletitle, righttitle, ref text, ref myHalg))
            {
                if (String.Compare(lefttitle, "", false) != 0)
                {
                    myHalg = TableTopLeftTitleAlign;
                }
                else if (String.Compare(middletitle, "", false) != 0)
                {
                    myHalg = TableTopMiddleTitleAlign;
                }
                else if (String.Compare(righttitle, "", false) != 0)
                {
                    myHalg = TableTopRightTitleAlign;
                }
            }
            if (flag2 = CanSpanPrint(bl, bm, br, ref text2, ref myHalg2))
            {
                if (String.Compare(bl, "", false) != 0)
                {
                    myHalg2 = TableBottomLeftTitleAlign;
                }
                else if (String.Compare(bm, "", false) != 0)
                {
                    myHalg2 = TableBottomMiddleTitleAlign;
                }
                else if (String.Compare(br, "", false) != 0)
                {
                    myHalg2 = TableBottomRightTitleAlign;
                }
            }
            float num30 = 0;
            float num31 = 0;
            float num32 = 0;
            float num33 = 0;
            float num34 = 0;
            float num35 = 0;
            if (mytitleheight == 0f)
            {
                if (String.Compare(lefttitle, "", false) == 0 & String.Compare(middletitle, "", false) == 0 & String.Compare(righttitle, "", false) == 0)
                {
                    num30 = 0f;
                    flag = false;
                }
                else if (flag)
                {
                    num30 = this.MeasureCell(text, topfont, num17, stringFormat).Height;
                }
                else
                {
                    SizeF sizeF = this.MeasureCell(lefttitle, topfont, num17 / 3f, stringFormat);
                    SizeF sizeF2 = this.MeasureCell(middletitle, topfont, num17 / 3f, stringFormat);
                    num30 = sizeF.Height;
                    float height = sizeF2.Height;
                    if (num30 < height)
                    {
                        num30 = height;
                    }
                    height = this.MeasureCell(righttitle, topfont, num17 / 3f, stringFormat).Height;
                    if (num30 < height)
                    {
                        num30 = height;
                    }
                }
                num31 = this.MeasureText(title, titleFont, num17, stringFormat).Height;
                if (num31 == 0f)
                {
                    num32 = 0f;
                }
                else
                {
                    num32 = (float)((double)this.MeasureText("游", titleFont, num14, stringFormat).Height / 2.5);
                }
                num33 = this.MeasureText(subtitle, subtitlefont, num17, stringFormat).Height;
                if (num33 == 0f)
                {
                    num34 = 0f;
                }
                else
                {
                    num34 = (float)((double)this.MeasureText("平", subtitlefont, num14, stringFormat).Height / 2.5);
                }
                if (String.Compare(bl, "", false) == 0 & String.Compare(br, "", false) == 0 & String.Compare(bm, "", false) == 0)
                {
                    num35 = 0f;
                    flag2 = false;
                }
                else
                {
                    if (flag2)
                    {
                        num35 = this.MeasureCell(text2, bottomfont, num17, stringFormat).Height;
                    }
                    else
                    {
                        SizeF sizeF = this.MeasureCell(bl, bottomfont, num17 / 3f, stringFormat);
                        SizeF sizeF2 = this.MeasureCell(bm, bottomfont, num17 / 3f, stringFormat);
                        num35 = sizeF.Height;
                        float height = sizeF2.Height;
                        if (num35 < height)
                        {
                            num35 = height;
                        }
                        height = this.MeasureCell(br, bottomfont, num17 / 3f, stringFormat).Height;
                        if (num35 < height)
                        {
                            num35 = height;
                        }
                    }
                    num35 += this.MeasureText("测试", new Font("宋体", 12f)).Height / 8f;
                }
                if (this.OuterBorder)
                {
                    num30 = num30 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
                    num35 = num35 + this.DoubleLineSpace + this.OuterBorderWidth / 2f;
                }
                else if (this.IsUseDoubleLine)
                {
                    num30 += this.DoubleLineSpace / 2f;
                    num35 += this.DoubleLineSpace / 2f;
                }
            }
            else
            {
                num31 = mytitleheight;
                num33 = mysubtitleheight;
                num32 = myoneline1height;
                num34 = myoneline2height;
                num30 = mytopheight;
                num35 = mybottomheight;
            }
            int num36 = -1;
            int num37 = 0;
            checked
            {
                int num38 = this.myms.RowCount - 1;
                int k = num37;
                while (k <= num38)
                {
                    if (!this.myms.Rows[k].Visible)
                    {
                        k++;
                    }
                    else
                    {
                        num36 = k;
                        mytree mytree2;
                        float doubleLineSpace = 0;
                        float num42 = 0;
                        bool flag3 = false;
                        float[] array8;
                        float currenty = 0;
                        Color textforecolor = new Color();
                        bool mulline = false;
                        unchecked
                        {
                            if (num36 == -1)
                            {
                                this.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Convert.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Convert.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false), true);
                            }
                            else
                            {
                                if (this.Currenty > 0f)
                                {
                                    this.MyIsNewPage(num31 + num32 + num33 + num34 + num30 + Convert.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Convert.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num36].Height, false), true);
                                }
                                if (num31 + num32 + num33 + num34 + num30 + Convert.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Convert.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false) + this.ConvFromDisplay((float)this.myms.Rows[num36].Height, false) > this.PaperPrintHeight)
                                {
                                    try
                                    {
                                        this.myms.Rows[num36].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - (num31 + num32 + num33 + num34 + num30 + Convert.ToSingle(Interaction.IIf(this.IsDrawTableFooterEveryPage, num35, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.OuterBorder, this.DoubleLineSpace + this.OuterBorderWidth / 2f, 0)))) + this.ConvFromDisplay(Convert.ToSingle(Interaction.IIf(this.myms.ColumnHeadersVisible, this.myms.ColumnHeadersHeight, 0)), false))), false)));
                                    }
                                    catch (Exception ex2)
                                    {
                                    }
                                }
                            }
                            currentPage = this.GetCurrentPage();
                            mytree2 = new mytree(columnheadertree, this.myms, array7);
                            float num39 = 0f;
                            float num40 = 0f;
                            doubleLineSpace = this.DoubleLineSpace;
                            float num41 = this.ConvFromDisplay((float)this.myms.ColumnHeadersHeight, false);
                            num42 = 0f;
                            flag3 = true;
                            array8 = new float[4];
                            array8 = ParaseBorder(myborder);
                            int num43 = fromrow;
                            int num44 = torow;
                            k = num43;
                            while (k <= num44 && !this.CancelDocument)
                            {
                                this.Currentx = num15;
                                if (!(currentPage != this.GetCurrentPage() | k == fromrow))
                                {
                                    goto IL_2085;
                                }
                                currentPage = this.GetCurrentPage();
                                flag3 = true;
                                if (k == 0 || reppagetitle)
                                {
                                    if (String.Compare(title, "", false) != 0)
                                    {
                                        this.Currentx = num16;
                                        this.DrawText(title, num17, num31, titleFont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, titletextstyle);
                                        this.NewRow(num31 + num32);
                                    }
                                    this.Currentx = num16;
                                    if (String.Compare(subtitle, "", false) != 0)
                                    {
                                        this.DrawText(subtitle, num17, num33, subtitlefont, StringAlignment.Center, StringAlignment.Center, true, false, false, false, 0f, subtitlestyle);
                                        this.NewRow(num33 + num34);
                                    }
                                    if (String.Compare(lefttitle, "", false) == 0 & String.Compare(middletitle, "", false) == 0 & String.Compare(righttitle, "", false) == 0)
                                    {
                                        this.NewRow(num30);
                                    }
                                    else if (flag)
                                    {
                                        this.Currentx = num16;
                                        this.DrawText(text, num17, num30, topfont, myHalg, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        this.NewRow(num30);
                                    }
                                    else
                                    {
                                        this.Currentx = num16;
                                        this.DrawText(lefttitle, num17 / 3f, num30, topfont, TableTopLeftTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        this.DrawText(middletitle, num17 / 3f, num30, topfont, TableTopMiddleTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        this.DrawText(righttitle, num17 / 3f, num30, topfont, TableTopRightTitleAlign, StringAlignment.Near, true, false, false, false, 0f, 0);
                                        this.NewRow(num30);
                                    }
                                }
                                this.Currentx = num15;
                                currenty = this.Currenty;
                                num42 = 0f;
                                if (this.myms.ColumnHeadersVisible)
                                {
                                    checked
                                    {
                                        if (columnheadertree == null)
                                        {
                                            bool flag4 = true;
                                            int num45 = 0;
                                            int num46 = num5 - 1;
                                            for (int l = num45; l <= num46; l++)
                                            {
                                                DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
                                                unchecked
                                                {
                                                    if (dataGridViewColumn.Visible)
                                                    {
                                                        if (this.IsUseDoubleLine)
                                                        {
                                                            if (flag4)
                                                            {
                                                                this.Currentx += doubleLineSpace / 2f;
                                                            }
                                                            else
                                                            {
                                                                this.Currentx += doubleLineSpace;
                                                            }
                                                            this.Currenty = currenty + doubleLineSpace / 2f;
                                                            this.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l] - doubleLineSpace, num41 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
                                                        }
                                                        else
                                                        {
                                                            this.MyDrawDGVHeaderCell(dataGridViewColumn, array5[l], num41, myborder, PrintBackColor, minfontsize);
                                                        }
                                                        flag4 = false;
                                                        num42 += array5[l];
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            int leves = mytree2.GetLeves();
                                            int num47 = 0;
                                            int num48 = num5 - 1;
                                            for (int l = num47; l <= num48; l++)
                                            {
                                                unchecked
                                                {
                                                    if (this.myms.Columns[array[l]].Visible)
                                                    {
                                                        num42 += array5[l];
                                                    }
                                                }
                                            }
                                            int num49 = 1;
                                            int num50 = leves;
                                            for (int m = num49; m <= num50; m++)
                                            {
                                                this.Currentx = num15;
                                                int num51;
                                                unchecked
                                                {
                                                    if (this.IsUseDoubleLine)
                                                    {
                                                        this.Currentx = num15 + doubleLineSpace / 2f;
                                                    }
                                                    this.Currenty = currenty + num29 / (float)leves * (float)(checked(m - 1));
                                                    if (this.IsUseDoubleLine)
                                                    {
                                                        this.Currenty += doubleLineSpace / 2f;
                                                    }
                                                    num51 = 0;
                                                }
                                                int num52 = num5 - 1;
                                                for (int l = num51; l <= num52; l++)
                                                {
                                                    DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
                                                    unchecked
                                                    {
                                                        if (dataGridViewColumn.Visible)
                                                        {
                                                            float num53 = mytree2.GetCellHeight(array[l], m);
                                                            float cellWidth = mytree2.GetCellWidth(array[l], m);
                                                            num53 = this.ConvFromDisplay(num53, false);
                                                            string nodeText = mytree2.GetNodeText(array[l], m);
                                                            if (num53 == 0f | cellWidth == 0f)
                                                            {
                                                                this.Currentx += array5[l];
                                                            }
                                                            else if (dataGridViewColumn.Visible)
                                                            {
                                                                Font font = mytree2.GetNodeFont(array[l], m);
                                                                if (font == null)
                                                                {
                                                                    font = Module1.GetDGVHeaderFont(dataGridViewColumn);
                                                                }
                                                                textforecolor = mytree2.GetNodeForeColor(array[l], m);
                                                                if (textforecolor.IsEmpty)
                                                                {
                                                                    textforecolor = Module1.GetDGVHeaderForeColor(dataGridViewColumn);
                                                                }
                                                                mulline = Module1.GetDGVHeaderMulline(dataGridViewColumn);
                                                                Color backcolor = mytree2.GetNodeBackColor(array[l], m);
                                                                if (backcolor.IsEmpty)
                                                                {
                                                                    backcolor = Module1.GetDGVHeaderBackColor(dataGridViewColumn);
                                                                }
                                                                mulline = true;
                                                                if (this.IsUseDoubleLine)
                                                                {
                                                                    if (!PrintBackColor)
                                                                    {
                                                                        this.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        this.DrawCell(nodeText, cellWidth - doubleLineSpace, num53 - doubleLineSpace, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
                                                                    }
                                                                    this.Currentx = this.Currentx + array5[l] + doubleLineSpace - cellWidth;
                                                                }
                                                                else
                                                                {
                                                                    if (!PrintBackColor)
                                                                    {
                                                                        this.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
                                                                    }
                                                                    else
                                                                    {
                                                                        this.DrawCell(nodeText, cellWidth, num53, font, textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
                                                                    }
                                                                    this.Currentx = this.Currentx + array5[l] - cellWidth;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (this.IsUseDoubleLine)
                                    {
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num41);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num41);
                                    }
                                    if (this.OuterBorder)
                                    {
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num41);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num41);
                                    }
                                    flag3 = false;
                                }
                                this.Currentx = num15;
                                this.Currenty = currenty + num29;
                                if (this.Currenty + this.ConvFromDisplay((float)this.myms.Rows[k].Height, false) > this.PaperPrintHeight)
                                {
                                    try
                                    {
                                        this.myms.Rows[k].Height = checked((int)Math.Round((double)this.ConvToDisplay(unchecked(this.PaperPrintHeight - this.Currenty), false)));
                                        goto IL_2085;
                                    }
                                    catch (Exception ex3)
                                    {
                                        goto IL_2085;
                                    }

                                }
                                goto IL_2085;
                            IL_207A:
                                DataGridViewRow dataGridViewRow;
                                checked
                                {
                                    k++;
                                    continue;
                                IL_162A:
                                    dataGridViewRow = this.myms.Rows[k];
                                    bool flag4 = true;
                                    currenty = this.Currenty;
                                    num42 = 0f;
                                    int num54 = 0;
                                    int num55 = num5 - 1;
                                    for (int l = num54; l <= num55; l++)
                                    {
                                        if (Module1.G_CancelDocument)
                                        {
                                            goto IL_278C;
                                        }
                                        DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
                                        unchecked
                                        {
                                            if (dataGridViewColumn.Visible)
                                            {
                                                num40 = array5[l];
                                                num42 += num40;
                                                num39 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                                string left2 = Convert.ToString(dataGridViewRow.Cells[array[l]].Tag);
                                                if (String.Compare(left2, "垂直合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (String.Compare(left2, "上合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (String.Compare(left2, "下合并", false) == 0)
                                                {
                                                    goto IL_185F;
                                                }
                                                if (String.Compare(left2, "水平合并", false) != 0)
                                                {
                                                    if (String.Compare(left2, "左合并", false) != 0)
                                                    {
                                                        if (String.Compare(left2, "右合并", false) != 0)
                                                        {
                                                            if (String.Compare(left2, "合并", false) != 0)
                                                            {
                                                                if (String.Compare(left2, "左上合并", false) != 0)
                                                                {
                                                                    if (String.Compare(left2, "左下合并", false) != 0)
                                                                    {
                                                                        if (String.Compare(left2, "右上合并", false) != 0)
                                                                        {
                                                                            if (String.Compare(left2, "右下合并", false) != 0)
                                                                            {
                                                                                if (String.Compare(left2, "上边合并", false) != 0)
                                                                                {
                                                                                    if (String.Compare(left2, "下边合并", false) != 0)
                                                                                    {
                                                                                        if (String.Compare(left2, "左边合并", false) != 0)
                                                                                        {
                                                                                            if (String.Compare(left2, "右边合并", false) != 0)
                                                                                            {
                                                                                                if (String.Compare(left2, "#*已水平合并*#", false) == 0)
                                                                                                {
                                                                                                    goto IL_1942;
                                                                                                }
                                                                                                if (String.Compare(left2, "#*已垂直合并*#", false) == 0)
                                                                                                {
                                                                                                    this.Currentx += array5[l];
                                                                                                    goto IL_1942;
                                                                                                }
                                                                                                goto IL_1878;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            this.GetHVMergeWidthAndHeight(this.myms, num5, l, k, array, array5, torow, ref num40, ref num39);
                                                            goto IL_1878;
                                                        }
                                                    }
                                                }
                                                int num56;
                                                num40 = GetHMergeWidth(this.myms, num5, l, k, array, array5, ref num56, true);
                                            IL_1878:
                                                if (this.IsUseDoubleLine)
                                                {
                                                    if (flag4)
                                                    {
                                                        this.Currentx += doubleLineSpace / 2f;
                                                    }
                                                    else
                                                    {
                                                        this.Currentx += doubleLineSpace;
                                                    }
                                                    if (flag3)
                                                    {
                                                        this.Currenty = currenty + doubleLineSpace / 2f;
                                                    }
                                                    else
                                                    {
                                                        this.Currenty = currenty + doubleLineSpace / 2f;
                                                    }
                                                    this.MyDrawDGVCell(this.myms.Rows[k].Cells[array[l]], num40 - doubleLineSpace, num39 - doubleLineSpace, myborder, PrintBackColor, minfontsize);
                                                }
                                                else
                                                {
                                                    this.MyDrawDGVCell(this.myms.Rows[k].Cells[array[l]], num40, num39, myborder, PrintBackColor, minfontsize);
                                                }
                                                flag4 = false;
                                                goto IL_1942;
                                            IL_185F:
                                                num39 = this.GetVMergeHeight(this.myms, l, k, array, torow, ref num56, true);
                                                goto IL_1878;
                                            }
                                        IL_1942:;
                                        }
                                    }
                                }
                                if (this.IsUseDoubleLine)
                                {
                                    if (flag3)
                                    {
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[1]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 - doubleLineSpace / 2f, currenty + num39);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty - doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                    else
                                    {
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                }
                                if (this.OuterBorder)
                                {
                                    if (flag3)
                                    {
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty - doubleLineSpace);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty - doubleLineSpace, num15 - doubleLineSpace, currenty + num39);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty - doubleLineSpace, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                    else
                                    {
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                }
                                if (flag3)
                                {
                                    flag3 = false;
                                }
                                this.Currenty = currenty + this.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                currenty = this.Currenty;
                                if (k == torow)
                                {
                                    break;
                                }
                                dataGridViewRow = this.myms.Rows[checked(k + 1)];
                                float num57 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
                                if (this.IsDrawTableFooterEveryPage && this.IsNewPage(num57 + num35))
                                {
                                    if (String.Compare(bl, "", false) == 0 & String.Compare(bm, "", false) == 0 & String.Compare(br, "", false) == 0)
                                    {
                                        this.Currenty += num35;
                                    }
                                    else
                                    {
                                        bool isNeedCheckNewPage = this.IsNeedCheckNewPage;
                                        this.IsNeedCheckNewPage = false;
                                        if (flag2)
                                        {
                                            this.Currentx = num16;
                                            this.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            this.NewRow(num35);
                                        }
                                        else
                                        {
                                            this.Currentx = num16;
                                            this.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            this.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            this.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                            this.NewRow(num35);
                                        }
                                        this.IsNeedCheckNewPage = isNeedCheckNewPage;
                                        this.Currenty += num35;
                                    }
                                }
                                if (!(this.IsUseDoubleLine | this.OuterBorder))
                                {
                                    this.MyIsNewPage(num57 + Convert.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
                                    goto IL_207A;
                                }
                                if (this.IsUseDoubleLine)
                                {
                                    if (this.IsNewPage(num57 + Convert.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0))))
                                    {
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                        if (this.OuterBorder)
                                        {
                                            this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                            this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                            this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                                        }
                                        this.MyIsNewPage(num57 + Convert.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
                                        goto IL_207A;
                                    }
                                    goto IL_207A;
                                }
                                else
                                {
                                    if (this.OuterBorder && this.IsNewPage(num57 + Convert.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0))))
                                    {
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                                        this.MyIsNewPage(num57 + Convert.ToSingle(Interaction.IIf(this.OuterBorder, this.OuterBorderWidth / 2f, 0)), true);
                                        goto IL_207A;
                                    }
                                    goto IL_207A;
                                }
                            IL_278C:
                                return 0f;
                            IL_2085:
                                if (!this.myms.Rows[k].Visible)
                                {
                                    goto IL_207A;
                                }

                            }
                        }
                        if (this.IsAutoAddEmptyRow && CanAddEmptyRow)
                        {
                            int num58;
                            try
                            {
                                num58 = (int)Math.Round(Math.Floor((double)(unchecked(this.PaperPrintHeight - this.Currenty - num35) / this.ConvFromDisplay((float)this.myms.Rows[torow].Height, false))));
                            }
                            catch (Exception ex4)
                            {
                                num58 = 0;
                            }
                            if (Module1.G_CancelDocument)
                            {
                                return 0f;
                            }
                            DataGridViewRow dataGridViewRow = this.myms.Rows[torow];
                            float num39 = this.ConvFromDisplay((float)dataGridViewRow.Height, false);
                            num42 = 0f;
                            int num59 = 1;
                            int num60 = num58;
                            for (int n = num59; n <= num60; n++)
                            {
                                this.Currentx = num15;
                                currenty = this.Currenty;
                                bool flag4 = true;
                                num42 = 0f;
                                int num61 = 0;
                                int num62 = num5 - 1;
                                for (int l = num61; l <= num62; l++)
                                {
                                    DataGridViewColumn dataGridViewColumn = this.myms.Columns[array[l]];
                                    unchecked
                                    {
                                        if (dataGridViewColumn.Visible)
                                        {
                                            float num40 = array5[l];
                                            num42 += num40;
                                            Color backcolor = Color.White;
                                            if (this.IsUseDoubleLine)
                                            {
                                                if (flag4)
                                                {
                                                    this.Currentx += doubleLineSpace / 2f;
                                                }
                                                else
                                                {
                                                    this.Currentx += doubleLineSpace;
                                                }
                                                if (flag3)
                                                {
                                                    this.Currenty = currenty + doubleLineSpace / 2f;
                                                }
                                                else
                                                {
                                                    this.Currenty = currenty + doubleLineSpace / 2f;
                                                }
                                                if (!PrintBackColor)
                                                {
                                                    this.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
                                                }
                                                else
                                                {
                                                    this.DrawCell("", num40 - doubleLineSpace, num39 - doubleLineSpace, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
                                                }
                                            }
                                            else if (!PrintBackColor)
                                            {
                                                this.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, true, false, false, minfontsize, Color.White, this.myms.GridColor, 0);
                                            }
                                            else
                                            {
                                                this.DrawCell("", num40, num39, new Font("宋体", 12f), textforecolor, myborder, StringAlignment.Center, StringAlignment.Center, mulline, false, false, false, minfontsize, backcolor, this.myms.GridColor, 0);
                                            }
                                            flag4 = false;
                                        }
                                    }
                                }
                                unchecked
                                {
                                    if (this.IsUseDoubleLine)
                                    {
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + num39);
                                        this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + num39);
                                    }
                                    if (this.OuterBorder)
                                    {
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + num39);
                                        this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + num39);
                                    }
                                    this.Currenty = currenty + num39;
                                    currenty = this.Currenty;
                                }
                            }
                        }
                        int num63 = 0;
                        unchecked
                        {
                            if (this.IsUseDoubleLine)
                            {
                                this.DrawLine(new Pen(this.myms.GridColor, array8[3]), num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                this.DrawLine(new Pen(this.myms.GridColor, array8[0]), num15 - doubleLineSpace / 2f, currenty, num15 - doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                                this.DrawLine(new Pen(this.myms.GridColor, array8[2]), num15 + num42 + doubleLineSpace / 2f, currenty, num15 + num42 + doubleLineSpace / 2f, currenty + doubleLineSpace / 2f);
                            }
                            if (this.OuterBorder)
                            {
                                this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace - this.OuterBorderWidth / 2f, currenty + doubleLineSpace, num15 + num42 + doubleLineSpace + this.OuterBorderWidth / 2f, currenty + doubleLineSpace);
                                this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 - doubleLineSpace, currenty, num15 - doubleLineSpace, currenty + doubleLineSpace);
                                this.DrawLine(new Pen(this.OuterBorderColor, this.OuterBorderWidth), num15 + num42 + doubleLineSpace, currenty, num15 + num42 + doubleLineSpace, currenty + doubleLineSpace);
                            }
                            if (String.Compare(bl, "", false) == 0 & String.Compare(bm, "", false) == 0 & String.Compare(br, "", false) == 0)
                            {
                                this.NewRow(num35);
                            }
                            else
                            {
                                this.MyIsNewPage(num35, true);
                                if (flag2)
                                {
                                    this.Currentx = num16;
                                    this.DrawText(text2, num17, num35, bottomfont, myHalg2, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    this.NewRow(num35);
                                }
                                else
                                {
                                    this.Currentx = num16;
                                    this.DrawText(bl, num17 / 3f, num35, bottomfont, TableBottomLeftTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    this.DrawText(bm, num17 / 3f, num35, bottomfont, TableBottomMiddleTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    this.DrawText(br, num17 / 3f, num35, bottomfont, TableBottomRightTitleAlign, StringAlignment.Far, true, false, false, false, 0f, 0);
                                    this.NewRow(num35);
                                }
                            }
                            this.Currentx = 0f;
                            if (Module1.G_CancelDocument)
                            {
                                return 0f;
                            }
                            num63 = 0;
                        }
                        int num64 = num5 - 1;
                        for (k = num63; k <= num64; k++)
                        {
                            this.myms.Columns[thecol[k]].Width = array3[k];
                        }
                        try
                        {
                            if (array4[0] != 0)
                            {
                                this.myms.ColumnHeadersHeight = array4[0];
                            }
                        }
                        catch (Exception ex5)
                        {
                        }
                        int num65 = fromrow;
                        int num66 = torow;
                        for (k = num65; k <= num66; k++)
                        {
                            this.myms.Rows[k].Height = array4[k + 1];
                        }
                        try
                        {
                            mytree2.Dispose();
                            mytree2 = null;
                            mytree.Dispose();
                            mytree = null;
                            stringFormat.Dispose();
                            stringFormat = null;
                            stringFormat2.Dispose();
                            stringFormat2 = null;
                            array = null;
                            array3 = null;
                            array4 = null;
                            array5 = null;
                            array7 = null;

                        }
                        catch (Exception ex6)
                        {
                            return result;
                        }

                    }
                }

            }
            return result;
        }





        // Token: 0x060013F2 RID: 5106 RVA: 0x0009EB6C File Offset: 0x0009CD6C
        private static float GetHMergeWidth(DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, ref int colsmerged, bool dobz = true)
        {
            DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
            float num = cellwidth[curcol];
            checked
            {
                try
                {
                    if (String.Compare(Convert.ToString(dataGridViewCell.Tag), "水平合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右上合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
                    {
                        colsmerged = 1;
                        return num;
                    }
                    if (curcol == cols - 1)
                    {
                        colsmerged = 1;
                        return num;
                    }
                    int num2 = curcol + 1;
                    int num3 = cols - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        if (ms.Columns[mycol[i]].Visible)
                        {
                            DataGridViewCell dataGridViewCell2 = ms.Rows[currow].Cells[mycol[i]];
                            if (!(String.Compare(Convert.ToString(dataGridViewCell2.Tag), "水平合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左下合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "下边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
                            {
                                unchecked
                                {
                                    num += cellwidth[i];
                                }
                                if (!(String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左下合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左边合并", false) == 0))
                                {
                                    if (dobz)
                                    {
                                        ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
                                        goto IL_331;
                                    }
                                    goto IL_331;
                                }
                                else
                                {
                                    if (dobz)
                                    {
                                        ms.Rows[currow].Cells[mycol[i]].Tag = "#*已水平合并*#";
                                    }
                                    i++;
                                }
                            }
                        IL_36B:
                            colsmerged = i - curcol;
                            goto IL_385;
                        }
                    IL_331:;
                    }

                }
                catch (Exception ex)
                {
                    colsmerged = 1;
                }
            IL_385:
                return num;
            }
        }

        // Token: 0x060013F3 RID: 5107 RVA: 0x0009EF20 File Offset: 0x0009D120
        private float GetVMergeHeight(DataGridView ms, int curcol, int currow, int[] mycol, int torow, ref int rowsmerged, bool dobz = true)
        {
            DataGridViewCell dataGridViewCell = ms.Rows[currow].Cells[mycol[curcol]];
            float num = this.ConvFromDisplay((float)ms.Rows[currow].Height, false);
            checked
            {
                try
                {
                    if (String.Compare(Convert.ToString(dataGridViewCell.Tag), "垂直合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "下合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "左下合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右下合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "下边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "左边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell.Tag), "右边合并", false) != 0)
                    {
                        rowsmerged = 1;
                        return num;
                    }
                    if (currow == torow)
                    {
                        rowsmerged = 1;
                        return num;
                    }
                    for (int i = currow + 1; i <= torow; i++)
                    {
                        if (ms.Rows[i].Visible)
                        {
                            DataGridViewCell dataGridViewCell2 = ms.Rows[i].Cells[mycol[curcol]];
                            if (!(String.Compare(Convert.ToString(dataGridViewCell2.Tag), "垂直合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "上合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左上合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "右上合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左边合并", false) != 0 & String.Compare(Convert.ToString(dataGridViewCell2.Tag), "右边合并", false) != 0) && dataGridViewCell.FormattedValue.Equals(RuntimeHelpers.GetObjectValue(dataGridViewCell2.FormattedValue)))
                            {
                                float num2 = this.ConvFromDisplay((float)ms.Rows[i].Height, false);
                                if (!this.MyIsNewPage(unchecked(num + num2), false))
                                {
                                    unchecked
                                    {
                                        num += num2;
                                    }
                                    if (!(String.Compare(Convert.ToString(dataGridViewCell2.Tag), "上合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "右上合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "左上合并", false) == 0 | String.Compare(Convert.ToString(dataGridViewCell2.Tag), "上边合并", false) == 0))
                                    {
                                        if (dobz)
                                        {
                                            ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
                                            goto IL_36A;
                                        }
                                        goto IL_36A;
                                    }
                                    else
                                    {
                                        if (dobz)
                                        {
                                            ms.Rows[i].Cells[mycol[curcol]].Tag = "#*已垂直合并*#";
                                        }
                                        i++;
                                    }
                                }
                            }
                        IL_3A4:
                            rowsmerged = i - currow;
                            goto IL_3BE;
                        }
                    IL_36A:;
                    }

                }
                catch (Exception ex)
                {
                    rowsmerged = 1;
                }
            IL_3BE:
                return num;
            }
        }

        // Token: 0x060013F4 RID: 5108 RVA: 0x0009F30C File Offset: 0x0009D50C
        private void GetHVMergeWidthAndHeight(DataGridView ms, int cols, int curcol, int currow, int[] mycol, float[] cellwidth, int torow, ref float mywidth, ref float myheight)
        {
            int num = 0;
            myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, false);
            checked
            {
                if (num == 1)
                {
                    int num2 = 0;
                    mywidth = GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, true);
                }
                else
                {
                    int num2 = 0;
                    mywidth = GetHMergeWidth(ms, cols, curcol, currow, mycol, cellwidth, ref num2, false);
                    if (num2 == 1)
                    {
                        myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
                    }
                    else
                    {
                        mywidth = cellwidth[curcol];
                        int i = 1;
                        while (i <= num - 1)
                        {
                            if (ms.Rows[i].Visible)
                            {
                                if (String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右上合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右下合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "右边合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow + i].Cells[mycol[curcol]].Tag), "下边合并", false) != 0)
                                {
                                    return;
                                }
                                i++;
                            }
                        }
                        myheight = this.GetVMergeHeight(ms, curcol, currow, mycol, torow, ref num, true);
                        int num3 = curcol + 1;
                        int num4 = curcol + num2 - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            unchecked
                            {
                                if (ms.Columns[mycol[j]].Visible)
                                {
                                    int num5 = 0;
                                    this.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, false);
                                    if (num5 < num | (String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "上边合并", false) != 0 & String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "下边合并", false) != 0))
                                    {
                                        break;
                                    }
                                    mywidth += cellwidth[j];
                                    this.GetVMergeHeight(ms, j, currow, mycol, torow, ref num5, true);
                                    if (String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左合并", false) == 0 | String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左上合并", false) == 0 | String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左下合并", false) == 0 | String.Compare(Convert.ToString(ms.Rows[currow].Cells[mycol[j]].Tag), "左边合并", false) == 0)
                                    {
                                        ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
                                        break;
                                    }
                                    ms.Rows[currow].Cells[mycol[j]].Tag = "#*已水平合并*#";
                                }
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x060013F5 RID: 5109 RVA: 0x0009F874 File Offset: 0x0009DA74
        private void DrawPageBackGroundImage()
        {
            if (this.mypagebackgroundimage != null)
            {
                try
                {
                    this.DrawImage(this.mypagebackgroundimage, 0f, 0f, this.PaperPrintWidth, this.PaperPrintHeight, true, StringAlignment.Center, StringAlignment.Center);
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x060013F6 RID: 5110 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
        private bool CheckPrinter(bool showmsg)
        {
            bool result;
            if (PrinterSettings.InstalledPrinters != null && PrinterSettings.InstalledPrinters.Count > 0)
            {
                this.hasprinterinstalled = true;
                result = true;
            }
            else
            {
                if (showmsg)
                {
                    string text = "检测到您的计算机上未安装任何打印机，因此无法进行打印预览和打印操作。";
                    text += "\r\n\r\n";
                    text += "注意：您的计算机上必须安装有打印机驱动程序（不一定要连接真实的打印机），才能进行打印预览及打印操作。";
                    Interaction.MsgBox(text, MsgBoxStyle.Exclamation, "提示信息");
                }
                this.hasprinterinstalled = false;
                result = false;
            }
            return result;
        }
    }
}
