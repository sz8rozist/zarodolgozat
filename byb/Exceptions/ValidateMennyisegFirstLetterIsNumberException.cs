using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    public class ValidateMennyisegFirstLetterIsNumberException : Exception
    {
        public ValidateMennyisegFirstLetterIsNumberException()
        {
        }

        public ValidateMennyisegFirstLetterIsNumberException(string message) : base(message)
        {
        }

        public ValidateMennyisegFirstLetterIsNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateMennyisegFirstLetterIsNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}