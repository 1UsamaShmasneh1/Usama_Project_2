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

    public partial class Form1 : Form
    {
        PersonManagamentList<Person> people = new PersonManagamentList<Person>();
        SickPersonManagamentList<SickPerson> sickpeople = new SickPersonManagamentList<SickPerson>();
        public Form1()
        {
            InitializeComponent();
            people.Add(new Person("308127125", "usama", "shmasneh", "male", 30));
        }

        private void buttonEnterId_Click(object sender, EventArgs e)
        {
            Person person = people.GetById(TextBoxEnterId.Text.ToString());
            SickPerson sickPerson = ConvertToSickPerson.ConvertToSickPersonFunk(person);
            try
            {
                if (!TextBoxEnterId.Text.ToString().IsValidIsraeliIdNumber())
                {
                    throw new NotValidIsraeliIdExeption();
                }
                sickpeople.Add(sickPerson);
                MessageBox.Show($"your turn is {sickPerson.NumOfTurn}");
            }
            catch (NotValidIsraeliIdExeption ex)
            {
                MessageBox.Show("Not Valid Id !");
            }
        }
    }
}
