using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    internal class NoProductWithGivenIdException : Exception
    {
        public NoProductWithGivenIdException()
        {
        }

        public NoProductWithGivenIdException(string? message) : base(message)
        {
        }

        public NoProductWithGivenIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoProductWithGivenIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}