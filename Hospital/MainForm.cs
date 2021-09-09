using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MainForm : Form
    {
        public PersonManagamentList<Person> People { get; set; }
        public MainForm(PersonManagamentList<Person> people)
        {
            People = people;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AddPeopleForm addPeopleForm = new AddPeopleForm();
            addPeopleForm.ShowDialog();
            Show();
        }
    }
}
