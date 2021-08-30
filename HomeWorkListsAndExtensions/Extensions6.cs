using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    static class Extensions6
    {
        public static bool IsValidIsraeliIdNumber(this string id)
        {
            int sum = 0;
            int counter = 1;
            string temp;
            if (id.Length == 9)
            {
                foreach (char ch in id)
                {
                    if (counter++ % 2 == 0)
                    {
                        if (Convert.ToInt32(ch) * 2 > 9)
                        {
                            temp = Convert.ToString(Convert.ToInt32(ch) * 2);
                            sum += Convert.ToInt32(temp[0]) + Convert.ToInt32(temp[1]);
                        }
                        else
                        {
                            sum += Convert.ToInt32(ch) * 2;
                        }
                    }
                    else
                    {
                        sum += Convert.ToInt32(ch);
                    }
                }
                if (sum % 10 == 0)
                    return true;
            }
            return false;
        }
    }
}
