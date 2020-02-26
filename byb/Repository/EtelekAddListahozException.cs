using System;
using System.Runtime.Serialization;

namespace byb.Repository
{
    [Serializable]
    internal class EtelekAddListahozException : Exception
    {
        public EtelekAddListahozException()
        {
        }

        public EtelekAddListahozException(string message) : base(message)
        {
        }

        public EtelekAddListahozException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EtelekAddListahozException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}