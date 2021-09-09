using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions8
    {
        public static bool IsDouble(this string str)
        {
            var regex = new Regex(@"^[0-9]+(.)[0-9]+");
            return regex.IsMatch(str);
        }
    }
}
