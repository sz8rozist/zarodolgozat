using System;
using System.Runtime.Serialization;

namespace byb.Repository.Felhasznalok
{
    [Serializable]
    internal class FelhasznalokException : Exception
    {
        public FelhasznalokException()
        {
        }

        public FelhasznalokException(string message) : base(message)
        {
        }

        public FelhasznalokException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FelhasznalokException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}