using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions1
    {
        public static bool IsStartWithD(this string str)
        {
            var regex = new Regex(@"^[D].*");
            return regex.IsMatch(str);
        }
    }
}
