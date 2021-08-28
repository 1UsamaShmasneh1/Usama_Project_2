using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexers2
{
    public class SortStudentsByAge : IComparer<Student2>
    {

        public int Compare(Student2 x, Student2 y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    public class Student2 : IComparable<Student2>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student2(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }

        public int CompareTo(Student2? other)
        {
            if (this.FirstName == "afrime")
                return -1;
            if(LastName.CompareTo(other.LastName) == 0)
                return FirstName.CompareTo(other.FirstName);
            return LastName.CompareTo(other.LastName);

        }
        public override bool Equals(object obj)
        {
            return object.ReferenceEquals(this, obj) ? true : (obj as Student2)?.Id == this.Id ? true : false;
        }
    }
    public class Lists
    {
        static List<Student2> studentlist = new List<Student2>();
        List<string> strList = new List<string>(new string[] { "nael", "sahar", "sami"});
        public void ListsFunk()
        {
            studentlist.Add(new Student2("usama", "s", 19));
            studentlist.Add(new Student2("moshe", "d", 28));
            studentlist.Add(new Student2("gell", "b", 21));
            studentlist.Add(new Student2("afrime", "n", 25));
            studentlist.Sort();
            int x = 200;
            bool same = x.Equals(200);
            Student2 s1 = new Student2("dd", "y", 20);
            Student2 s2 = new Student2("dd", "g", 30);
            same = s1.Equals(s2);
            strList.Add("usama");
            strList.Add("moshe");
            strList.Add("gell");
            strList.Sort();
            strList.Remove("usama");
            MessageBox.Show("");

            
        }
        
    }
}
