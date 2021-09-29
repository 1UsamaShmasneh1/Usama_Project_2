using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEnumerators
{
    public class Print10To100 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Print10To100ForEach
    {
        public void Print()
        {
            foreach (int num in new Print10To100())
            {
                Console.WriteLine(num);
            }
        }
    }
}
