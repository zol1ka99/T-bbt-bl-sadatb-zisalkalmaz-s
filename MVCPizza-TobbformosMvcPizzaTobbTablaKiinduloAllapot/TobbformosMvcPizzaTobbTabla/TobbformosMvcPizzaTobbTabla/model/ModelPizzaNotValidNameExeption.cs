using System;
using System.Runtime.Serialization;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    [Serializable]
    internal class ModelPizzaNotValidNameExeption : Exception
    {
        public ModelPizzaNotValidNameExeption()
        {
        }

        public ModelPizzaNotValidNameExeption(string message) : base(message)
        {
        }

        public ModelPizzaNotValidNameExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelPizzaNotValidNameExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}