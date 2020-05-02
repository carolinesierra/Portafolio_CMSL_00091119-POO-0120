using System;

namespace Ejercicio1
{
    public class EvaluationNonExistentException : Exception
    {
        public EvaluationNonExistentException(String message) : base(message)
        {
            
        }
    }
}