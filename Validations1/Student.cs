using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations1
{
    public class Student
    {
        public int Id { get; set; }
        public string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { value.IsValidName(); }
        }
    }
}
