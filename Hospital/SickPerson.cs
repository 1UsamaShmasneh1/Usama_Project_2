using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class SickPerson: Person
    {
        SeverityOfDisease severityOfDisease;
        public bool IsTreating { get; set; } = false;
        public bool IsReleased { get; set; } = false;
        public override bool IsSick { get; set; } = true;
        public int NumOfTurn { get; set; } = 1;
        public SickPerson(int id, string farstName, string lastName, string gender, int age, SeverityOfDisease severityOfDisease): base(id, farstName, lastName, gender, age)
        {
            this.severityOfDisease = severityOfDisease;
        }
    }
}
