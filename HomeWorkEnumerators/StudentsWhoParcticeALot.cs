using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEnumerators
{
    public class Student
    {
        public int Grade { get; set; }
    }
    public class StudentsWhoParcticeALot : IEnumerable<int>
    {
        public List<Student> Students { get; set; } 
        public StudentsWhoParcticeALot(List<Student> students)
        {
            Students = students;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Grade > 10)
                    yield return Students[i].Grade;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class Prog
    {
        List<Student> students = new List<Student>();
    }
}
