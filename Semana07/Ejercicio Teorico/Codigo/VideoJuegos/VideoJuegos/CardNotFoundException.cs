using System;

namespace VideoJuegos
{
    public class CardNotFoundException : Exception
    {
        public CardNotFoundException(string message) : base(message)
        {
            
        }
        
    }
}