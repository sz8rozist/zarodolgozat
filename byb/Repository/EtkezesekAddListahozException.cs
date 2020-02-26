using System;
using System.Runtime.Serialization;

namespace byb.Repository
{
    [Serializable]
    internal class EtkezesekAddListahozException : Exception
    {
        public EtkezesekAddListahozException()
        {
        }

        public EtkezesekAddListahozException(string message) : base(message)
        {
        }

        public EtkezesekAddListahozException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EtkezesekAddListahozException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}