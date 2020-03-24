using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    public class ValidateMindenMezoKitoltveException : Exception
    {
        public ValidateMindenMezoKitoltveException()
        {
        }

        public ValidateMindenMezoKitoltveException(string message) : base(message)
        {
        }

        public ValidateMindenMezoKitoltveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateMindenMezoKitoltveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}