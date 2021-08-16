using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class StudentManagament
    {
        Student[] students = new Student[1000];
        public int Count { get; set; }

        public Student GetStudentById(int id)
        {
            for(int i = 0; i < Count; i++)
            {
                if (students[i].Id == id) return students[i];
            }
            return null;
        }
        public Student GetStudentByName(string name)
        {
            for (int i = 0; i < Count; i++)
            {
                if (students[i].Name == name) return students[i];
            }
            return null;
        }
        public Student[] this[int grade]
        {
            get
            {
                Student[] bestStudents = new Student[1000];
                int counter = 0;
                foreach(var student in students)
                {
                    if(student.Grade > grade)
                        bestStudents[counter++] = student;
                }
                return bestStudents;
            }
        }
        //public Student this[int id] // => GetStudentById
        //{
        //    get { return students[id]; }
        //    set { students[id] = value; }
        //}
        
    }
}
