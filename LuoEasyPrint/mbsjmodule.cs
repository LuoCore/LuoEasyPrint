using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace LuoEasyPrint
{
    // Token: 0x0200002F RID: 47
    [StandardModule]
    internal sealed class mbsjmodule
    {
        // Token: 0x060007E3 RID: 2019 RVA: 0x000480EC File Offset: 0x000462EC
        public static string[,] ParaseVar(Hashtable myvar)
        {
            checked
            {
                string[,] result;
                if (myvar == null)
                {
                    result = null;
                }
                else
                {
                    int count = myvar.Count;
                    if (count <= 0)
                    {
                        result = null;
                    }
                    else
                    {
                        string[,] array = new string[count - 1 + 1, 2];
                        int num = 0;
                        foreach (object obj in myvar)
                        {
                            DictionaryEntry dictionaryEntry2 = new DictionaryEntry();
                            DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
                            array[num, 0] = Convert.ToString(dictionaryEntry.Key);
                            array[num, 1] = Convert.ToString(dictionaryEntry.Value);
                            num++;
                        }
                        result = array;
                    }
                }
                return result;
            }
        }

        // Token: 0x060007E4 RID: 2020 RVA: 0x00048180 File Offset: 0x00046380
        public static void ShowWaitWindow()
        {
            if (mbsjmodule.G_WaitWindow != null)
            {
                try
                {
                    mbsjmodule.G_WaitWindow.Close();
                    mbsjmodule.G_WaitWindow.Dispose();
                    mbsjmodule.G_WaitWindow = null;
                }
                catch (Exception ex)
                {
                }
            }
            mbsjmodule.G_WaitWindow = new mywait();
            Application.DoEvents();
            mbsjmodule.G_WaitWindow.Show();
            Application.DoEvents();
        }

        // Token: 0x060007E5 RID: 2021 RVA: 0x000481EC File Offset: 0x000463EC
        public static void CloseWaitWindow()
        {
            if (mbsjmodule.G_WaitWindow != null)
            {
                try
                {
                    mbsjmodule.G_WaitWindow.Close();
                    mbsjmodule.G_WaitWindow.Dispose();
                    mbsjmodule.G_WaitWindow = null;
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x060007E6 RID: 2022 RVA: 0x000041D5 File Offset: 0x000023D5
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static void MyShowHelp(string tt = "")
        {
            if (String.Compare(tt, "", false) == 0)
            {
                tt = "start.htm";
            }
            Help.ShowHelp(null, MyProject.Application.Info.DirectoryPath + "\\myhelp.chm", tt);
        }

        // Token: 0x060007E7 RID: 2023 RVA: 0x0004823C File Offset: 0x0004643C
        public static StringAlignment GetValign(ContentAlignment alg)
        {
            if (alg != ContentAlignment.BottomCenter)
            {
                if (alg != ContentAlignment.BottomLeft)
                {
                    if (alg != ContentAlignment.BottomRight)
                    {
                        if (alg != ContentAlignment.MiddleCenter)
                        {
                            if (alg != ContentAlignment.MiddleLeft)
                            {
                                if (alg != ContentAlignment.MiddleRight)
                                {
                                    if (alg != ContentAlignment.TopCenter)
                                    {
                                        if (alg != ContentAlignment.TopLeft)
                                        {
                                            if (alg != ContentAlignment.TopRight)
                                            {
                                                return StringAlignment.Center;
                                            }
                                        }
                                    }
                                    return StringAlignment.Near;
                                }
                            }
                        }
                        return StringAlignment.Center;
                    }
                }
            }
            return StringAlignment.Far;
        }

        // Token: 0x060007E8 RID: 2024 RVA: 0x0004829C File Offset: 0x0004649C
        public static StringAlignment GetHalign(ContentAlignment alg)
        {
            if (alg != ContentAlignment.BottomCenter)
            {
                if (alg != ContentAlignment.MiddleCenter)
                {
                    if (alg != ContentAlignment.TopCenter)
                    {
                        if (alg != ContentAlignment.BottomLeft)
                        {
                            if (alg != ContentAlignment.MiddleLeft)
                            {
                                if (alg != ContentAlignment.TopLeft)
                                {
                                    if (alg != ContentAlignment.BottomRight)
                                    {
                                        if (alg != ContentAlignment.MiddleRight)
                                        {
                                            if (alg != ContentAlignment.TopRight)
                                            {
                                                return StringAlignment.Near;
                                            }
                                        }
                                    }
                                    return StringAlignment.Far;
                                }
                            }
                        }
                        return StringAlignment.Near;
                    }
                }
            }
            return StringAlignment.Center;
        }

        // Token: 0x060007E9 RID: 2025 RVA: 0x000482FC File Offset: 0x000464FC
        public static string SaveControl(Control cc)
        {
            string text = "";
            if (cc is U_Field)
            {
                text = ((U_Field)cc).SaveAsString();
                text = "字段" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Text)
            {
                text = ((U_Text)cc).SaveAsString();
                text = "文本" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Comput)
            {
                text = ((U_Comput)cc).SaveAsString();
                text = "计算" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Image)
            {
                text = ((U_Image)cc).SaveAsString();
                text = "图片" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Rect)
            {
                text = ((U_Rect)cc).SaveAsString();
                text = "矩形" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_HLine)
            {
                text = ((U_HLine)cc).SaveAsString();
                text = "水平" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_VLine)
            {
                text = ((U_VLine)cc).SaveAsString();
                text = "垂直" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Bar)
            {
                text = ((U_Bar)cc).SaveAsString();
                text = "条码" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Bias)
            {
                text = ((U_Bias)cc).SaveAsString();
                text = "斜线" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Express)
            {
                text = ((U_Express)cc).SaveAsString();
                text = "表达式" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_Ellipse)
            {
                text = ((U_Ellipse)cc).SaveAsString();
                text = "椭圆" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_fBias)
            {
                text = ((U_fBias)cc).SaveAsString();
                text = "反斜线" + mbsjmodule.G_MB_Spetator_control + text;
            }
            else if (cc is U_QC)
            {
                text = ((U_QC)cc).SaveAsString();
                text = "二维码" + mbsjmodule.G_MB_Spetator_control + text;
            }
            return text;
        }

        // Token: 0x060007EA RID: 2026 RVA: 0x00048528 File Offset: 0x00046728
        public static Control RestoreControl(string ss)
        {
            string[] array = Strings.Split(ss, mbsjmodule.G_MB_Spetator_control, -1, CompareMethod.Binary);
            Control control = null;
            string left = array[0];
            Control result;
            if (String.Compare(left, "字段", false) == 0)
            {
                U_Field u_Field = new U_Field();
                u_Field.RestoreFromString(array[1]);
                result = u_Field;
            }
            else if (String.Compare(left, "文本", false) == 0)
            {
                U_Text u_Text = new U_Text();
                u_Text.RestoreFromString(array[1]);
                result = u_Text;
            }
            else if (String.Compare(left, "计算", false) == 0)
            {
                U_Comput u_Comput = new U_Comput();
                u_Comput.RestoreFromString(array[1]);
                result = u_Comput;
            }
            else if (String.Compare(left, "图片", false) == 0)
            {
                U_Image u_Image = new U_Image();
                u_Image.RestoreFromString(array[1]);
                result = u_Image;
            }
            else if (String.Compare(left, "矩形", false) == 0)
            {
                U_Rect u_Rect = new U_Rect();
                u_Rect.RestoreFromString(array[1]);
                result = u_Rect;
            }
            else if (String.Compare(left, "水平", false) == 0)
            {
                U_HLine u_HLine = new U_HLine();
                u_HLine.RestoreFromString(array[1]);
                result = u_HLine;
            }
            else if (String.Compare(left, "垂直", false) == 0)
            {
                U_VLine u_VLine = new U_VLine();
                u_VLine.RestoreFromString(array[1]);
                result = u_VLine;
            }
            else if (String.Compare(left, "条码", false) == 0)
            {
                U_Bar u_Bar = new U_Bar();
                u_Bar.RestoreFromString(array[1]);
                result = u_Bar;
            }
            else if (String.Compare(left, "斜线", false) == 0)
            {
                U_Bias u_Bias = new U_Bias();
                u_Bias.RestoreFromString(array[1]);
                result = u_Bias;
            }
            else if (String.Compare(left, "表达式", false) == 0)
            {
                U_Express u_Express = new U_Express();
                u_Express.RestoreFromString(array[1]);
                result = u_Express;
            }
            else if (String.Compare(left, "椭圆", false) == 0)
            {
                U_Ellipse u_Ellipse = new U_Ellipse();
                u_Ellipse.RestoreFromString(array[1]);
                result = u_Ellipse;
            }
            else if (String.Compare(left, "反斜线", false) == 0)
            {
                U_fBias u_fBias = new U_fBias();
                u_fBias.RestoreFromString(array[1]);
                result = u_fBias;
            }
            else if (String.Compare(left, "二维码", false) == 0)
            {
                U_QC u_QC = new U_QC();
                u_QC.RestoreFromString(array[1]);
                result = u_QC;
            }
            else
            {
                result = control;
            }
            return result;
        }

        // Token: 0x04000468 RID: 1128
        public static string[] FieldsString;

        // Token: 0x04000469 RID: 1129
        public static string[,] FieldsString2 = new string[1, 2];

        // Token: 0x0400046A RID: 1130
        public static string G_MB_Spetator_Band = "\u0001\u0003";

        // Token: 0x0400046B RID: 1131
        public static string G_MB_Spetator_Line = "\u0002\u0004";

        // Token: 0x0400046C RID: 1132
        public static string G_MB_Spetator_Proper = "\u0005\a";

        // Token: 0x0400046D RID: 1133
        public static string G_MB_Spetator_control = "\u0006\b";

        // Token: 0x0400046E RID: 1134
        public static string G_MB_Spetator_BandContent = "\n\v";

        // Token: 0x0400046F RID: 1135
        public static float G_MB_Default_Width = 170f;

        // Token: 0x04000470 RID: 1136
        public static mywait G_WaitWindow;

        // Token: 0x02000030 RID: 48
        public class StrChoice2 : StringConverter
        {
            // Token: 0x060007EC RID: 2028 RVA: 0x00048754 File Offset: 0x00046954
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            // Token: 0x060007ED RID: 2029 RVA: 0x00048764 File Offset: 0x00046964
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return false;
            }

            // Token: 0x060007EE RID: 2030 RVA: 0x00048774 File Offset: 0x00046974
            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return this.values;
            }

            // Token: 0x170002C1 RID: 705
            // (get) Token: 0x060007EF RID: 2031 RVA: 0x0004878C File Offset: 0x0004698C
            private TypeConverter.StandardValuesCollection values
            {
                get
                {
                    if (this.thevalues == null)
                    {
                        this.thevalues = new TypeConverter.StandardValuesCollection(mbsjmodule.FieldsString);
                    }
                    return this.thevalues;
                }
            }

            // Token: 0x04000471 RID: 1137
            private TypeConverter.StandardValuesCollection thevalues;
        }

        // Token: 0x02000031 RID: 49
        public class StrChoice : StringConverter
        {
            // Token: 0x060007F1 RID: 2033 RVA: 0x000487BC File Offset: 0x000469BC
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            // Token: 0x060007F2 RID: 2034 RVA: 0x000487CC File Offset: 0x000469CC
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return false;
            }

            // Token: 0x060007F3 RID: 2035 RVA: 0x000487DC File Offset: 0x000469DC
            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return this.values;
            }

            // Token: 0x170002C2 RID: 706
            // (get) Token: 0x060007F4 RID: 2036 RVA: 0x000487F4 File Offset: 0x000469F4
            private TypeConverter.StandardValuesCollection values
            {
                get
                {
                    checked
                    {
                        if (this.thevalues == null)
                        {
                            if (mbsjmodule.FieldsString == null)
                            {
                                return null;
                            }
                            int num = mbsjmodule.FieldsString.Length;
                            string[] array = new string[num - 1 + 1];
                            int num2 = 0;
                            int num3 = mbsjmodule.FieldsString.Length - 1;
                            for (int i = num2; i <= num3; i++)
                            {
                                array[i] = mbsjmodule.FieldsString[i];
                            }
                            this.thevalues = new TypeConverter.StandardValuesCollection(array);
                        }
                        return this.thevalues;
                    }
                }
            }

            // Token: 0x04000472 RID: 1138
            private TypeConverter.StandardValuesCollection thevalues;
        }

        // Token: 0x02000032 RID: 50
        public class StrChoice3 : StringConverter
        {
            // Token: 0x060007F6 RID: 2038 RVA: 0x00048860 File Offset: 0x00046A60
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            // Token: 0x060007F7 RID: 2039 RVA: 0x00048870 File Offset: 0x00046A70
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return false;
            }

            // Token: 0x060007F8 RID: 2040 RVA: 0x00048880 File Offset: 0x00046A80
            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return this.values;
            }

            // Token: 0x170002C3 RID: 707
            // (get) Token: 0x060007F9 RID: 2041 RVA: 0x00048898 File Offset: 0x00046A98
            private TypeConverter.StandardValuesCollection values
            {
                get
                {
                    if (this.thevalues == null)
                    {
                        this.thevalues = new TypeConverter.StandardValuesCollection(new string[]
                        {
                            "",
                            "数字",
                            "日期时间"
                        });
                    }
                    return this.thevalues;
                }
            }

            // Token: 0x04000473 RID: 1139
            private TypeConverter.StandardValuesCollection thevalues;
        }
    }
}
