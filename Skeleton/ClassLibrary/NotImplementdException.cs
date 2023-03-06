using System;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [Serializable]
    internal class NotImplementdException : Exception
    {
        public NotImplementdException()
        {
        }

        public NotImplementdException(string message) : base(message)
        {
        }

        public NotImplementdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplementdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}