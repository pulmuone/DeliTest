using System;
using System.Runtime.Serialization;

namespace DeliTest
{
    [Serializable]
    internal class OperationTransientException : Exception
    {
        public OperationTransientException()
        {
        }

        public OperationTransientException(string message) : base(message)
        {
        }

        public OperationTransientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OperationTransientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}