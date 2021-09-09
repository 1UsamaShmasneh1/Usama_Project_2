using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions6
    {
        public static bool IsHasABC(this string str)
        {
            var regex = new Regex(@"\b(abc)|(ABC)");
            return regex.IsMatch(str);
        }
    }
}
