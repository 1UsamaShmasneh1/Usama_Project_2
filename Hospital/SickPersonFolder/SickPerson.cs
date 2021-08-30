using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class SickPerson: Person
    {
        public static int turns = 1;
        public SeverityOfDisease severityOfDisease;
        public bool IsTreating { get; set; } = false;
        public bool IsReleased { get; set; } = false;
        public override bool IsSick { get; set; } = true;
        public int NumOfTurn { get; } = turns;
        public PendingTo pendingTo;
        public SickPerson(string id, string farstName, string lastName, string gender, int age): base(id, farstName, lastName, gender, age) { }
    }
}
