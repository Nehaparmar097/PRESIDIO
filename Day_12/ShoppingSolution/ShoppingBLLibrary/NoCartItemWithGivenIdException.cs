using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    internal class NoCartItemWithGivenIdException : Exception
    {
        public NoCartItemWithGivenIdException()
        {
        }

        public NoCartItemWithGivenIdException(string? message) : base(message)
        {
        }

        public NoCartItemWithGivenIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoCartItemWithGivenIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}