using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Person
    {
        public string Id { get; set; }
        public string FarstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public virtual bool IsSick { get; set; } = false;
        public Person(string id, string farstName, string lastName, string gender, int age)
        {
            Id = id;
            FarstName = farstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }
    }
}
