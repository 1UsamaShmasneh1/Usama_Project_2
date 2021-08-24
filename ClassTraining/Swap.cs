using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    public static class Swap
    {
        public static void SwapItems<T>(ref T item1, ref T item2) where T: struct
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
