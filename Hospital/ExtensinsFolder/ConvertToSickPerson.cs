using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public static class ConvertToSickPerson
    {
        public static SickPerson ConvertToSickPersonFunk(this Person person)
        {
            SickPerson.turns++;
            SickPerson sickPerson = new SickPerson(person.Id, person.FarstName, person.LastName, person.Gender, person.Age);
            return sickPerson;
        }
    }
}
