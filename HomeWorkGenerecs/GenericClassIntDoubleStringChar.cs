using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    public class GenericClassIntDoubleStringChar<T>: GenericConstraint<int, double, string, char>
    {
        public GenericClassIntDoubleStringChar() : base(typeof(T))
        {

        }
        T[] Items { get; set; }
        int count = 0;
        public void Add(T item)
        {
            Items[count] = item;
            Array.Sort(Items);
        }
        public T this[int index]
        {
            get
            {
                return Items[index];
            }
        }
    }
}
