using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions3
    {
        public static bool IsStartWithDOrFOrJSpecial(this string str)
        {
            var regex = new Regex(@"^[DFJ]\d[0-9]{3}\d(_)\d[A-Z]{2}");
            return regex.IsMatch(str);
        }
    }
}
