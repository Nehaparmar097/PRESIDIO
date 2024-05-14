using System.Runtime.Serialization;

namespace RequestTrackerBLLibrary
{
    [Serializable]
    internal class NoSolutionExists : Exception
    {
        public NoSolutionExists()
        {
        }

        public NoSolutionExists(string? message) : base(message)
        {
        }

        public NoSolutionExists(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSolutionExists(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}