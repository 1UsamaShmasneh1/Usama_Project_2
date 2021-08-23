using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    public class GenericConstraint<T1, T2, T3, T4>
    {
        public GenericConstraint(Type type)
        {
            if(type is not T1 and not T2 and not T3 and not T4)
            {
                throw new Exception("this not supported type");
            }
        }
    }
}
