using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    class ReadOnly<T>
    {
        private bool IsReadOnly { get; set; }
        T[] Array { get; set; }
        int count = 0;
        public void Add(T t)
        {
            switch (IsReadOnly)
            {
                case false:
                    throw new InvalidOperationException("");
            }
            Array[count] = t;
        }
    }
}
