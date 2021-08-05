using System;

namespace Infrastructure.Exceptions
{
    public class ValidationException : Exception
    {
        private string Property { get; }

        public ValidationException(string message, string property) : base(message)
        {
            Property = property;
        }
    }
}
