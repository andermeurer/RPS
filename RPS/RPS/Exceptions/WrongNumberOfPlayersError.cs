using System;

namespace RPS.RPS.Exceptions
{
    [Serializable]
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError()
            : base("Wrong number of players for a game")
        {
        }
    }
}
