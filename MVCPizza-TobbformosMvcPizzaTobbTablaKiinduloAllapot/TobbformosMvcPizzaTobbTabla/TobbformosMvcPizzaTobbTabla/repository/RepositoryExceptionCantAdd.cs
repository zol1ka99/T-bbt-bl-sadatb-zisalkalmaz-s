using System;
using System.Runtime.Serialization;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    [Serializable]
    internal class RepositoryExceptionCantAdd : Exception
    {
        public RepositoryExceptionCantAdd()
        {
        }

        public RepositoryExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}