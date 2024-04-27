using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    internal class DuplicateCartItemException : Exception
    {
        public DuplicateCartItemException()
        {
        }

        public DuplicateCartItemException(string? message) : base(message)
        {
        }

        public DuplicateCartItemException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateCartItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}