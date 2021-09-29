using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratursEnumarable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 2, 3 };
            foreach(var item in vs)
            {

            }

            var myMofaOfSidra = new SidraTenTo100();
            while (myMofaOfSidra.MoveNext())
            {
                var item = myMofaOfSidra.Current;
            }

            List<int> vs1 = new List<int>(new int[] { 1, 2, 3 });
            foreach (var item in new SidraTenTo100())
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }
        }
    }
}
