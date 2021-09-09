using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    static class Extensions3
    {
        public static string Print(this int num)
        {
            string[] numsStr1 = { "", "zero", "one", "tow", "three", "four", "five", "six", "seven", "eight", "nine" , "ten"};
            string[] numsStr2 = { "teen", "twenty", "thirty", "fourty", "fivty", "sixty", "siventy", "eighty", "ninty" };
            if(num >= 0 && num <= 10)
            {
                return numsStr1[num +1];
            }
            else if (num == 11)
            {
                return "eleven";
            }
            else if (num == 12)
            {
                return "twelve";
            }
            else if (num == 13)
            {
                return "thirteen";
            }
            else if (num < 20)
            {
                return $"{numsStr1[num - 9]} {numsStr2[0]}";
            }
            else if (num <= 100 && num % 10 == 0)
            {
                return $"{numsStr2[num / 10 - 1]}";
            }
            else if (num < 100)
            {
                return $"{numsStr2[num / 10 - 1]} {numsStr1[num % 10 +1]}";
            }
            return "Ad kan!";
        }
    }
}
