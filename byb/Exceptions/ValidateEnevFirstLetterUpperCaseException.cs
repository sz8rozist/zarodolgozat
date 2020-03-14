using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    public class ValidateEnevFirstLetterUpperCaseException : Exception
    {
        public ValidateEnevFirstLetterUpperCaseException()
        {
        }

        public ValidateEnevFirstLetterUpperCaseException(string message) : base(message)
        {
        }

        public ValidateEnevFirstLetterUpperCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateEnevFirstLetterUpperCaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}