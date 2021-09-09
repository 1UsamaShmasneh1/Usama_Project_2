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

    public partial class GetTurnForm : Form
    {
        PersonManagamentList<Person> people = new PersonManagamentList<Person>();
        SickPersonManagamentList<SickPerson> sickpeople = new SickPersonManagamentList<SickPerson>();
        public GetTurnForm()
        {
            InitializeComponent();
            people.Add(new Person("308127125", "usama", "shmasneh", "male", 30));
        }

        private void buttonEnterId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TextBoxEnterId.Text.ToString().IsValidIsraeliIdNumber() || !people.IsFoundPersonFunk(TextBoxEnterId.Text.ToString()))
                {
                    throw new NotValidIsraeliIdExeption();
                }
                Person person = people.GetById(TextBoxEnterId.Text.ToString());
                SickPerson sickPerson = person.ConvertToSickPersonFunk();
                sickpeople.Add(sickPerson);
                MessageBox.Show($"your turn is {sickPerson.NumOfTurn}");
            }
            catch (NotValidIsraeliIdExeption)
            {
                MessageBox.Show("Not Valid Id !");
            }
            MainForm f = new MainForm();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
