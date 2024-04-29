﻿using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    internal class DuplicateProductException : Exception
    {
        public DuplicateProductException()
        {
        }

        public DuplicateProductException(string? message) : base(message)
        {
        }

        public DuplicateProductException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}