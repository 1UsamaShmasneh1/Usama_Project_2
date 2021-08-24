using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Class1<T> where T: Person
    {
    }
    class Person { }
    class Student : Person { }
    class PlayGround
    {
        void SandBox()
        {
            //Class1<int> classInt = new Class1<int>();
            //Class1<string> classString = new Class1<string>();
            Class1<Person> classPerson = new Class1<Person>();
        }
    }
}
