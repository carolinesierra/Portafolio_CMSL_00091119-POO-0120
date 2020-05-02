using System;

namespace Ejercicio1
{
    public class EmptyException : Exception
    {
        public EmptyException(String message) : base(message){}
    }
}