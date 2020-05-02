using System;

namespace VideoJuegos
{
    public class CardAlreadyCreatedException : Exception
    {
        public CardAlreadyCreatedException(string message) : base(message)
        {
            
        }
    }
}