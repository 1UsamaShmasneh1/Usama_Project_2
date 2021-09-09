using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    public class OutOfRangeConsoleException : ApplicationException
    {
        public OutOfRangeConsoleException()
        {
        }

        public OutOfRangeConsoleException(string message) : base(message)
        {
        }

        public OutOfRangeConsoleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfRangeConsoleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
