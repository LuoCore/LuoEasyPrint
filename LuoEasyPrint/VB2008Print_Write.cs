using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuoEasyPrint
{
    public static class VB2008Print_Write
    {
        public static void ShowWriteError(this VB2008Print print)
        {
            if (print.IsShowErrorMSG & !print.hasshownewpageerror)
            {
                print.hasshownewpageerror = true;
                Interaction.MsgBox("您在调用控件的打印方法打印输出前未调用NewPage函数创建第1个打印页面\r\n这将导致这部分的打印输出无效（打印内容部分丢失），请注意检查。", MsgBoxStyle.Exclamation, "警告");
            }
        }
        public static void MyWrite(this VB2008Print print, string thename, string thevalue)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    string str = thename + "\0" + thevalue;
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5, string t6, string t7)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, string t2, string t3, string t4, string t5, string t6)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
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
                    print.mypages[print.currentpage].Append("\u0001\u0003" + str);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                        Conversions.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Conversions.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = text + Conversions.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Conversions.ToString(Interaction.IIf(t13, "1", "0"));
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, string t7, string t8, string t9, StringFormatFlags t10)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                    text += Conversions.ToString((int)t10);
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                    text += Conversions.ToString((int)t10);
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                        Conversions.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Conversions.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = text + Conversions.ToString(Interaction.IIf(t12, "1", "0")) + "\0" + Conversions.ToString(Interaction.IIf(t13, "1", "0"));
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, bool t10, bool t11, bool t12, bool t13, string t14)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                        Conversions.ToString(Interaction.IIf(t10, "1", "0")),
                        "\0",
                        Conversions.ToString(Interaction.IIf(t11, "1", "0")),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(Interaction.IIf(t12, "1", "0")),
                        "\0",
                        Conversions.ToString(Interaction.IIf(t13, "1", "0")),
                        "\0"
                    });
                    text += t14;
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
        public static void MyWrite(this VB2008Print print, string t1, float t2, float t3, float t4, float t5, string t6, Color t7, string t8, string t9, StringFormatFlags t10, string t11)
        {
            if (print.currentpage < print.mypages.Length)
            {
                if (print.currentpage <= 0)
                {
                    print.ShowWriteError();
                }
                else
                {
                    ColorConverter colorConverter = new ColorConverter();
                    string text = string.Concat(new string[]
                    {
                        t1,
                        "\0",
                        Conversions.ToString(t2),
                        "\0",
                        Conversions.ToString(t3),
                        "\0",
                        Conversions.ToString(t4),
                        "\0"
                    });
                    text = string.Concat(new string[]
                    {
                        text,
                        Conversions.ToString(t5),
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
                    text = text + Conversions.ToString((int)t10) + "\0";
                    text += t11;
                    print.mypages[print.currentpage].Append("\u0001\u0003" + text);
                }
            }
        }
    }
}
