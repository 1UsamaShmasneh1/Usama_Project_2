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
        T[] Array
        {
            get
            {
                return Array;
            }
            set
            {
                switch (IsReadOnly)
                {
                    case false:
                        throw new InvalidOperationException("");
                }
            }
        }
    }
}
