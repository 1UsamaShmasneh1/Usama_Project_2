using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    abstract public class Shape
    {
        abstract public void ShapeDrow();
        abstract protected void GetIdices();
        abstract protected void CheckValidLocation();
    }
}
