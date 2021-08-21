using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class SickPersonManagament
    {
        SickPerson[] sickPeople = new SickPerson[10];
        public void Add(SickPerson sickPerson)
        {
            if (Array.IndexOf(sickPeople, null) != -1)
            {
                sickPeople[Array.IndexOf(sickPeople, null)] = sickPerson;
            }
            else
            {
                Debug.WriteLine("ther are no range for more sick people");
            }
        }
        public SickPerson this[SickPerson sickPerson]
        {
            set => Add(sickPerson);
        }
    }
}
