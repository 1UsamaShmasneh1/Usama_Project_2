using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexers2
{
    public partial class Form1 : Form
    {
        StudentManagament students = new StudentManagament();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = students.GetStudentById(Convert.ToInt32(textBoxId.Text));
            var sudent1 = students[Convert.ToInt32(textBoxId.Text)];
            int grade = 85;
            Student[] studentsArray = students[grade];
        }
    }
}
