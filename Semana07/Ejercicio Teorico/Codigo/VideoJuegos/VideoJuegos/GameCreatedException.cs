using System;

namespace VideoJuegos
{
    public class GameCreatedException : Exception 
    {
        public GameCreatedException(string message) : base(message)
        {
        }
    }
}