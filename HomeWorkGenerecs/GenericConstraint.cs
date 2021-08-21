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
            if(!(type is T1) || !(type is T2) || !(type is T3) || !(type is T4))
            {
                throw new Exception("this not supported type");
            }

        }
    }
}
