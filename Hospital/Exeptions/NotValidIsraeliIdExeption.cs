using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class NotValidIsraeliIdExeption : ApplicationException
    {
        public NotValidIsraeliIdExeption()
        {
        }

        public NotValidIsraeliIdExeption(string message) : base(message)
        {
        }

        public NotValidIsraeliIdExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotValidIsraeliIdExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
