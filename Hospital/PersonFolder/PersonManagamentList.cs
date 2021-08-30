using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class PersonManagamentList<T>: List<T> where T: Person
    {
        public T GetByFullName(string fullName)
        {
            foreach (T t in this)
            {
                if ($"{t.FarstName} {t.LastName}" == fullName || $"{t.LastName} {t.FarstName}" == fullName)
                    return t;
            }
            return null;
        }
        public T GetById(string id)
        {
            foreach (T t in this)
            {
                if (t.Id == id)
                    return t;
            }
            return null;
        }
    }
}
