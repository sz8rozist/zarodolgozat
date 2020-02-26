using System;
using System.Runtime.Serialization;

namespace byb.Repository
{
    [Serializable]
    internal class TorlesEtkezesException : Exception
    {
        public TorlesEtkezesException()
        {
        }

        public TorlesEtkezesException(string message) : base(message)
        {
        }

        public TorlesEtkezesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TorlesEtkezesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}