using LuoEasyPrint;

namespace FormsPrintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + @"\Print\»Îø‚±Í«©.mb";
            string pathMbFile = Path.GetDirectoryName(strPath);
            if (!Directory.Exists(pathMbFile))
            {
                Directory.CreateDirectory(pathMbFile);
            }
            using (EasyReport easyRep = new EasyReport(this.components)
            {
                EnableSaveAsImage = true,
                EnableSaveAsPDF = true,
                IsDrawmargin = false,
                IsShowPrintStatusDialog = true,
                IsShowProgess = true,
                IsUseAPIprintDialog = true,
                OffsetX = 0F,
                OffsetY = 0F,
                PrintCopys = ((short)(1))
            })
            {
                easyRep.SetReportFile(strPath);
                if (File.Exists(strPath))
                {
                    easyRep.EditReport();
                }
                else
                {
                    easyRep.CreateReport();
                }

            }
        }
    }
}