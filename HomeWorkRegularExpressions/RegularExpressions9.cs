using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions9
    {
        public static bool IsDouble3(this string str)
        {
            var regex = new Regex(@"^[0-9]+(.)[0-9]{3}");
            return regex.IsMatch(str);
        }
    }
}
