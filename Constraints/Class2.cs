using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Class2<T, U>
    {
        public void GetT(T t) { }
        public void GetT(U u) { }
        public void GetT(T t, U u) { }
    }
    class PlayGround2
    {
        void SandBox()
        {
            Class2<int, string> classInt = new Class2<int, string>();
            classInt.GetT(2);
            classInt.GetT(2);
            classInt.GetT(2, "");
        }
        
    }
}
