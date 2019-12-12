using System;
using System.Runtime.Serialization;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    [Serializable]
    internal class ModelMegrendeloNotValidNameExeption : Exception
    {
        public ModelMegrendeloNotValidNameExeption()
        {
        }

        public ModelMegrendeloNotValidNameExeption(string message) : base(message)
        {
        }

        public ModelMegrendeloNotValidNameExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelMegrendeloNotValidNameExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}