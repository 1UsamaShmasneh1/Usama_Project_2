using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class SickPersonManagament<T> : List<T> where T: SickPerson
    {
        public T GetSickPersonByNumOfTurn(int turn)
        {
            foreach(T t in this)
            {
                if (t.NumOfTurn == turn)
                    return t;
            }
            return null;
        }
        public T GetSickPersonByFullName(string fullName)
        {
            foreach (T t in this)
            {
                if ($"{t.FarstName} {t.LastName}" == fullName || $"{t.LastName} {t.FarstName}" == fullName)
                    return t;
            }
            return null;
        }
        public T GetSickPersonById(int turn)
        {
            foreach (T t in this)
            {
                if (t.Id == turn)
                    return t;
            }
            return null;
        }
    }
}
