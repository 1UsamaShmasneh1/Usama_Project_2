using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkListsAndExtensions
{
    class Lists1
    {
        List<Student> studintList = new List<Student>();
        public void SortByLastName()
        {
            studintList.Sort((x, y) =>
            {
                return x.LastName.CompareTo(y.LastName);
            });
        }
        public void SortByGrade()
        {
            studintList.Sort((x, y) =>
            {
                return x.Grade.CompareTo(y.Grade) * -1;
            });
        }
        public void SortByLastNameThenFirstName()
        {
            studintList.Sort((x, y) =>
            {
                if(x.LastName.CompareTo(y.LastName) == 0)
                {
                    if(x.FirstName.CompareTo(y.FirstName) == 0)
                    {
                        return x.Grade.CompareTo(y.Grade) * -1;
                    }
                    return x.FirstName.CompareTo(y.FirstName);
                }
                return x.LastName.CompareTo(y.LastName);
            });
        }
    }
    class Student//: IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        //public int CompareTo(Student other)
        //{
        //    if (LastName.CompareTo(other.LastName) == 0)
        //    {
        //        if(FirstName.CompareTo(other.FirstName) == 0)
        //            return Grade.CompareTo(other.Grade) * -1;
        //        return FirstName.CompareTo(other.FirstName);
        //    }

        //    return LastName.CompareTo(other.LastName);
        //}
    }
}
