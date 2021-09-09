using System;
using System.Runtime.Serialization;

namespace ProjectGame
{
    [Serializable]
    internal class NotValidLocationException : ApplicationException
    {
        public NotValidLocationException()
        {
        }

        public NotValidLocationException(string message) : base(message)
        {
        }

        public NotValidLocationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotValidLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}