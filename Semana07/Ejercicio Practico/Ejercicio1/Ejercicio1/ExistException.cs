using System;

namespace Ejercicio1
{
    public class ExistException : Exception
    {
        public ExistException(String message): base(message){}
    }
}