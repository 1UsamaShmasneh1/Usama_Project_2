using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validations1
{
    public static class StringExtensions
    {
        public static bool IsValidName(this string name)
        {
            /*
             "a+" = one or more times
             "a*" = zero or any times
             "a{5}" = 5 times
             "a{5,9} = 5 times to 9 times
             
             "^D.*" = string that starts with D
             */
            //if (name.Length < 2) return false;
            var regex = new Regex(@"\D{2,50} \D{0,50}");
            return regex.IsMatch(name);
            //foreach (var characater in name)
            //{
            //    if (characater < 'A' || characater > 'z' || characater == '\\') return false;
            //}
            //return true;
        }
        public static bool IsIlIdenentity(this string id)
        {
            var regex = new Regex(@"\d{9}");
            return regex.IsMatch(id);
            //if (id.Length != 9) return false;
            //foreach(var characater in id.PadLeft(9, '0'))
            //{
            //    if (characater < '0' || characater > '9') return false;
            //}
            //return true;
        }
    }
}
