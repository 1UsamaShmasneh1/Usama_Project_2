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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int count = 1;
        StudentLinkedList list = new StudentLinkedList();
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = "Student" + (count++).ToString()
            };
            list.Add(student);
        }
    }
}
