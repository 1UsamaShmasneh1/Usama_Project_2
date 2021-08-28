using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    static class StringEctensions
    {
        public static bool IsName(this string s)
        {
            foreach (var ch in s)
            {
                if (ch < '9' && ch >= '0') return false;
            }
            return true;
        }
    }
    class Extensions
    {        
        public void Work()
        {
            var firstName = "yakir";
            if (!firstName.IsName())
                Debug.WriteLine("");
        }
    }
}
