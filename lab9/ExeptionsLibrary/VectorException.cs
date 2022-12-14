using System;

namespace ExeptionsLibrary
{
    public class VectorException : Exception
    {
        public VectorException(string message)
        : base(message) { }
    }
}
