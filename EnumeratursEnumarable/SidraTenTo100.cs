using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratursEnumarable
{
    public class SidraTenTo100 : IEnumerable<int>
    {
        int i = 0;

        public bool MoveNext()
        {
            if (i <= 10)
            {
                i++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            i = 0;
        }

        public int Current { get { return i * 10; } }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
