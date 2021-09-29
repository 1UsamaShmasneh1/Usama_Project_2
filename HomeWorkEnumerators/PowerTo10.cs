using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEnumerators
{
    public class PowerTo10 : IEnumerable<int>
    {
        public int Num { get; set; }
        public PowerTo10(int num)
        {
            Num = num;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return Num ^ i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
