using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenerecs
{
    public class HasProperty
    {
        public override string ToString()
        {
            if (this.GetType().GetProperty("Name") != null)
                return base.ToString() + $"{this.GetType().GetProperty("Name")}";
            else
                return base.ToString() + " there no property named Name";
        }
    }
}
