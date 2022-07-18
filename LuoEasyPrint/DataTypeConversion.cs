using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
