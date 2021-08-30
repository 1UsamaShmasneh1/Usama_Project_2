using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class SickPersonManagamentList<T> : List<T> where T: SickPerson
    {
        public T GetByNumOfTurn(int turn)
        {
            foreach(T t in this)
            {
                if (t.NumOfTurn == turn)
                    return t;
            }
            return null;
        }
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
