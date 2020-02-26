using System;
using System.Runtime.Serialization;

namespace byb.Repository
{
    [Serializable]
    internal class TorlesEtkezesekViewnException : Exception
    {
        public TorlesEtkezesekViewnException()
        {
        }

        public TorlesEtkezesekViewnException(string message) : base(message)
        {
        }

        public TorlesEtkezesekViewnException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TorlesEtkezesekViewnException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}