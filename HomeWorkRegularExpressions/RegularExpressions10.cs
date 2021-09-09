using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkRegularExpressions
{
    public static class RegularExpressions10
    {
        public static bool IsEmail(this string str)
        {
            var regex = new Regex(@"^\d{8,20}(@)(gmail|yahoo)(.)(com)");
            return regex.IsMatch(str);
        }
    }
}
