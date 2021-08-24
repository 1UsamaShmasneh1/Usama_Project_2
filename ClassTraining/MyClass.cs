using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    interface IEntity
    {

    }
    class MyClass<T> where T: IEntity
    {
    }

    class MyClass2
    {
        public void Do<T, X, Y>(T t) { }
        public void Do<T, X, Y>(X x) { }
        public void Do<T, X, Y>(Y y) { }
        public void Do<T, X, Y>(T t, X x, Y y) { }
    }
}
