using System;

namespace SwordAndMagic.Exceptions
{
    public class ObjectOutOfBoundsException : Exception
    {
        public ObjectOutOfBoundsException(string message)
            : base(message)
        {
        }
    }
}
