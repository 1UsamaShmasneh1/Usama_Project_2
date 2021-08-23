using HomeWorkGenerecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usama_Project_2
{
    public partial class Form1 : Form
    {
        StudentManagament managament = new StudentManagament();
        public Form1()
        {
            InitializeComponent();
            Student student = new Student()
            {
                Id = 29,
                Name = "Usama",
                Age = 28
            };
            managament.Add(student);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = managament.GetStudentByIndex(Convert.ToInt32(txtId.Text));
            txtAge.Text = student.Age.ToString();
            txtName.Text = student.Name.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericClassIntDoubleStringChar<bool> num = new GenericClassIntDoubleStringChar<bool>();
            num.Add(true);
            Debug.WriteLine(num[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
