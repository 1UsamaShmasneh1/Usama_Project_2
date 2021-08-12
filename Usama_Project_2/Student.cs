using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usama_Project_2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class StudentManagament
    {
        public Student[] Students { get; set; } = new Student[100000];
        public int Count { get; set; }
        public void Add(Student student)
        {
            Students[Count] = student;
            Count++;
        }
        public Student GetStudentById(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                    return student;
            }
            return null;
        }
        public Student GetStudentByIndex(int index)
        {
            if (index > Count - 1)
                throw new ArgumentException("");
            return Students[index];
        }
    }
}
