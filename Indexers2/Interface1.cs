using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    interface IId<T>
    {
        public T Id { get; set; }
    }

    class Person : IId<int>
    {
        public int Id { get; set; }
    }
}
