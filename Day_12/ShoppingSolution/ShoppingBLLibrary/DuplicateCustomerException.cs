using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    internal class DuplicateCustomerException : Exception
    {
        public DuplicateCustomerException()
        {
        }

        public DuplicateCustomerException(string? message) : base(message)
        {
        }

        public DuplicateCustomerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateCustomerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}