using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    internal class ValidateMennyisegContainBetuException : Exception
    {
        public ValidateMennyisegContainBetuException()
        {
        }

        public ValidateMennyisegContainBetuException(string message) : base(message)
        {
        }

        public ValidateMennyisegContainBetuException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateMennyisegContainBetuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}