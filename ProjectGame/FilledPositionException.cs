using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    public class FilledPositionException : ApplicationException
    {
        public FilledPositionException()
        {
        }

        public FilledPositionException(string message) : base(message)
        {
        }

        public FilledPositionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FilledPositionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
