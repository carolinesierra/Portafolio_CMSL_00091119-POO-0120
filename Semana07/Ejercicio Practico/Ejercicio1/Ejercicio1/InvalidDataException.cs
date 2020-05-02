using System;

namespace Ejercicio1
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(String message) : base(message)
        {
            
        }
    }
}