using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LuoEasyPrint
{
    public class DataTypeConversion
    {
        public static bool ToBoolean(object thisValue)
        {
            bool reval = false;
           
            if (thisValue != null && thisValue != DBNull.Value && bool.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }

        public static bool IsNumeric(object Expression)
        {
            IConvertible convertible = Expression as IConvertible;
            if (convertible == null)
            {
                return false;
            }
            switch (convertible.GetTypeCode())
            {
                case TypeCode.Boolean:
                    return true;
                case TypeCode.Char:
                case TypeCode.String:
                    {
                        string value = convertible.ToString(null);
                        try
                        {
                            long num = 0;
                            if (IsHexOrOctValue(value, ref num))
                            {
                                return true;
                            }
                        }
                        catch (FormatException ex)
                        {
                            return false;
                        }
                        double num2;
                        return double.TryParse(value, out num2);
                    }
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
            }
            return false;
        }
        internal static bool IsHexOrOctValue(string Value, ref long i64Value)
        {
            int length = Value.Length;
            checked
            {
                int i = 0;
                while (i < length)
                {
                    char c = Value[i];
                    if (c == '&' && i + 2 < length)
                    {
                        c = char.ToLower(Value[i + 1], CultureInfo.InvariantCulture);
                        string value = ToHalfwidthNumbers(Value.Substring(i + 2), GetCultureInfo());
                        if (c == 'h')
                        {
                            i64Value = Convert.ToInt64(value, 16);
                        }
                        else
                        {
                            if (c != 'o')
                            {
                                throw new FormatException();
                            }
                            i64Value = Convert.ToInt64(value, 8);
                        }
                        return true;
                    }
                    if (c != ' ' && c != '\u3000')
                    {
                        return false;
                    }
                    i++;
                }
                return false;
            }
        }
        internal static string ToHalfwidthNumbers(string s, CultureInfo culture)
        {
            int lcid = culture.LCID;
            int num = lcid & 1023;
            if (num != 4 && num != 17 && num != 18)
            {
                return s;
            }

            return vbLCMapString(culture, 4194304, s);
        }
        internal static string vbLCMapString(CultureInfo loc, int dwMapFlags, string sSrc)
        {
            int num;
            if (sSrc == null)
            {
                num = 0;
            }
            else
            {
                num = sSrc.Length;
            }
            if (num == 0)
            {
                return "";
            }
            int lcid = loc.LCID;
            Encoding encoding = Encoding.GetEncoding(loc.TextInfo.ANSICodePage);
            int num2;
            string result;
            if (!encoding.IsSingleByte)
            {
                string s = sSrc;
                byte[] bytes = encoding.GetBytes(s);
                num2 = LCMapStringA(lcid, dwMapFlags, bytes, bytes.Length, null, 0);
                byte[] array = new byte[checked(num2 - 1 + 1)];
                num2 = LCMapStringA(lcid, dwMapFlags, bytes, bytes.Length, array, num2);
                result = encoding.GetString(array);
                return result;
            }
            result = new string(' ', num);
            num2 = LCMapString(lcid, dwMapFlags, ref sSrc, num, ref result, num);
            return result;
        }

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        internal static extern int LCMapStringA(int Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPArray)] byte[] lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPArray)] byte[] lpDestStr, int cchDest);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int LCMapString(int Locale, int dwMapFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDestStr, int cchDest);


        internal static CultureInfo GetCultureInfo()
        {
            return Thread.CurrentThread.CurrentCulture;
        }
    }
}
