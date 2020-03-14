using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    public class ValidateEtelNevIsEmpty : Exception
    {
        public ValidateEtelNevIsEmpty()
        {
        }

        public ValidateEtelNevIsEmpty(string message) : base(message)
        {
        }

        public ValidateEtelNevIsEmpty(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateEtelNevIsEmpty(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}