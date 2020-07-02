using System;

namespace UltimoEjercicio
{
    public class EmptyException : Exception
    {
        public EmptyException(String message) : base(message){}
    }
}