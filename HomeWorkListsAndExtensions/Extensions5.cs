using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    static class Extensions5
    {
        public static bool IsNull(this object opj)
        {
            if (opj == null)
                return true;
            return false;
        }
    }
}
