using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions11
    {
        public static bool IsUrl(this string str)
        {
            var regex = new Regex(@"(?<Protocol>\w+):\/\/[0-9a-zA-Z]([-.\w]*(co.il))\/?[\w\.?=%&=\-@/$,]*");
            return regex.IsMatch(str);
        }
    }
}
