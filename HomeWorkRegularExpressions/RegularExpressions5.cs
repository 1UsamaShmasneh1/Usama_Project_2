using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions5
    {
        public static bool IsStartWithCapetalChar(this string str)
        {
            var regex = new Regex(@"^[A-Z]");
            return regex.IsMatch(str);
        }
    }
}
