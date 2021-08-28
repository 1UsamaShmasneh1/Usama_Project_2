using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    static class Extensions1
    {
        public static bool HasLowerChars(this string str)
        {
            foreach(char ch in str)
            {
                if(Convert.ToString(ch) == Convert.ToString(ch).ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
