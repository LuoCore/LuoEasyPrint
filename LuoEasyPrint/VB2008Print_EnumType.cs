using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuoEasyPrint
{
    public static class VB2008Print_EnumType
    {
        public  enum PageExportUnit
        {
            // Token: 0x04000AA6 RID: 2726
            CentiMeter,
            // Token: 0x04000AA7 RID: 2727
            Inch = 3
        }
        private  enum MyPrintPageRange
        {
            // Token: 0x04000A87 RID: 2695
            PageRange_JS = 1,
            // Token: 0x04000A88 RID: 2696
            PageRange_OS
        }

        // Token: 0x02000091 RID: 145
        public  enum BarcodeFormat
        {
            // Token: 0x04000A8A RID: 2698
            AZTEC = 1,
            // Token: 0x04000A8B RID: 2699
            CODABAR,
            // Token: 0x04000A8C RID: 2700
            CODE_39 = 4,
            // Token: 0x04000A8D RID: 2701
            CODE_93 = 8,
            // Token: 0x04000A8E RID: 2702
            CODE_128 = 16,
            // Token: 0x04000A8F RID: 2703
            CODE_128B,
            // Token: 0x04000A90 RID: 2704
            DATA_MATRIX = 32,
            // Token: 0x04000A91 RID: 2705
            EAN_8 = 64,
            // Token: 0x04000A92 RID: 2706
            EAN_13 = 128,
            // Token: 0x04000A93 RID: 2707
            ITF = 256,
            // Token: 0x04000A94 RID: 2708
            MAXICODE = 512,
            // Token: 0x04000A95 RID: 2709
            PDF_417 = 1024,
            // Token: 0x04000A96 RID: 2710
            QR_CODE = 2048
        }

        // Token: 0x02000092 RID: 146
        public  enum BarCode
        {
            // Token: 0x04000A98 RID: 2712
            EAN13,
            // Token: 0x04000A99 RID: 2713
            ENA8,
            // Token: 0x04000A9A RID: 2714
            Code39,
            // Token: 0x04000A9B RID: 2715
            Code128,
            // Token: 0x04000A9C RID: 2716
            Code128A,
            // Token: 0x04000A9D RID: 2717
            Code128B,
            // Token: 0x04000A9E RID: 2718
            Code128C,
            // Token: 0x04000A9F RID: 2719
            Codabar,
            // Token: 0x04000AA0 RID: 2720
            Code11,
            // Token: 0x04000AA1 RID: 2721
            Code25,
            // Token: 0x04000AA2 RID: 2722
            Code25_Stand,
            // Token: 0x04000AA3 RID: 2723
            ISBN,
            // Token: 0x04000AA4 RID: 2724
            CODE39Extended
        }
        public  enum TheZDXTYPE
        {
            // Token: 0x04000AAA RID: 2730
            LEFT,
            // Token: 0x04000AAB RID: 2731
            TOP,
            // Token: 0x04000AAC RID: 2732
            RIGHT,
            // Token: 0x04000AAD RID: 2733
            BOTTOM
        }

        // Token: 0x0200009E RID: 158
        public  enum DGVCopyRange
        {
            // Token: 0x04000AAF RID: 2735
            SelectedRows,
            // Token: 0x04000AB0 RID: 2736
            SelectedColumns,
            // Token: 0x04000AB1 RID: 2737
            SelectedRowsAndColumns
        }
    }
}
