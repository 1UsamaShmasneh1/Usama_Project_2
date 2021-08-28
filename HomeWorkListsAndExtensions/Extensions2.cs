using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    static class Extensions2
    {
        public static string ReverseCase(this string str)
        {
            string str1 = "";
            foreach (char ch in str1)
            {
                if (Convert.ToString(ch) == Convert.ToString(ch).ToLower())
                {
                    str1 += Convert.ToString(ch).ToUpper();
                }
                else
                {
                    str1 += Convert.ToString(ch).ToLower();
                }
            }
            return str1;
        }
    }
}
