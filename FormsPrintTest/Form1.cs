using LuoEasyPrint;

namespace FormsPrintTest
{
    public partial class Form1 : Form
    {
        string strPath = Application.StartupPath + @"\Print\»Îø‚±Í«©.mb";
       
        public Form1()
        {
            InitializeComponent();
            string pathMbFile = Path.GetDirectoryName(strPath);
            if (!Directory.Exists(pathMbFile))
            {
                Directory.CreateDirectory(pathMbFile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            string sss = "0\u0005\a50.27\u0005\a21.7\u0005\a15.08\u0005\a0.2\u0005\aBlack\u0005\a6.09\u0005\aTransparent";
            string[] strArray = sss.Split("\u0005\a", StringSplitOptions.RemoveEmptyEntries);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
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
                easyRep.PrintReport(false, true, false, true);

            }
           
        }
    }
}