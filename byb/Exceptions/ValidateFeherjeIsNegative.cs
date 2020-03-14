using System;
using System.Runtime.Serialization;

namespace byb.Modell
{
    [Serializable]
    public class ValidateFeherjeIsNegative : Exception
    {
        public ValidateFeherjeIsNegative()
        {
        }

        public ValidateFeherjeIsNegative(string message) : base(message)
        {
        }

        public ValidateFeherjeIsNegative(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidateFeherjeIsNegative(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}