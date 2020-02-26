using System;
using System.Runtime.Serialization;

namespace byb.Repository
{
    [Serializable]
    internal class EtkezesekViewnAddListahozException : Exception
    {
        public EtkezesekViewnAddListahozException()
        {
        }

        public EtkezesekViewnAddListahozException(string message) : base(message)
        {
        }

        public EtkezesekViewnAddListahozException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EtkezesekViewnAddListahozException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}