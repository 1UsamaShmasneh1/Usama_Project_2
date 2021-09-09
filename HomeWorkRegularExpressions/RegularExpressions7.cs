using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions7
    {
        public static bool IsFullName(this string str)
        {
            var regex = new Regex(@"\D{2,18} {2,}");
            return regex.IsMatch(str);
        }
    }
}
