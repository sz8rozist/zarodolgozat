using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    internal class ValidateKiegeszitoException : Exception
    {
        public ValidateKiegeszitoException()
        {
        }

        public ValidateKiegeszitoException(string message) : base(message)
        {
        }

        public ValidateKiegeszitoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateKiegeszitoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}