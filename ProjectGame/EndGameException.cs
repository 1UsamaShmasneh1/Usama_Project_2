using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    class EndGameException : ApplicationException
    {
        public EndGameException()
        {
        }

        public EndGameException(string message) : base(message)
        {
        }

        public EndGameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EndGameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
