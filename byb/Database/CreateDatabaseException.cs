using System;
using System.Runtime.Serialization;

namespace byb.Database
{
    [Serializable]
    internal class CreateDatabaseException : Exception
    {
        public CreateDatabaseException()
        {
        }

        public CreateDatabaseException(string message) : base(message)
        {
        }

        public CreateDatabaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CreateDatabaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}