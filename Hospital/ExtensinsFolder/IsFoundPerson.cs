using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public static class IsFoundPerson
    {
        public static bool IsFoundPersonFunk(this PersonManagamentList<Person> people, string id)
        {
            foreach(Person person in people)
            {
                if (person.Id == id)
                    return true;
            }
            return false;
        }
    }
}
