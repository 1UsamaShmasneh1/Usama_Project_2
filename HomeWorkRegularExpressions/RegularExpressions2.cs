using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions2
    {
        public static bool IsStartWithDOrFOrJ(this string str)
        {
            var regex = new Regex(@"^[DFJ].*");
            return regex.IsMatch(str);
        }
    }
}
