using System;
using System.Runtime.Serialization;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    [Serializable]
    internal class RepositoryExceptionCantModified : Exception
    {
        public RepositoryExceptionCantModified()
        {
        }

        public RepositoryExceptionCantModified(string message) : base(message)
        {
        }

        public RepositoryExceptionCantModified(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryExceptionCantModified(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}