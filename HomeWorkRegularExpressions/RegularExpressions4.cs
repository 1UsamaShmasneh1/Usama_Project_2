using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions4
    {
        public static string Replace(this string str)
        {
            var regex = new Regex(@"\d(yyy)|(זזזז)");
            return regex.Replace(str, " ");
        }
    }
}
