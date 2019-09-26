using System;
using System.Linq;

namespace RPS.RPS
{
    public class PlayerMove
    {
        private readonly string[] _allowed_moves = new string[] { "p", "r", "s" };

        public PlayerMove(string name, string move)
        {
            Name = name;
            Move = move;
        }

        public string Name { get; private set; }
        public string Move { get; private set; }

        public bool HasAllowedMove()
        {
            return _allowed_moves.Contains(this.Move.ToLowerInvariant());
        }
    }
}
