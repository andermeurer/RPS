using System.Collections.Generic;

namespace RPS.RPS
{
    public class TournamentBracket
    {
        public IEnumerable<PlayerMove> Game { get; set; }
        public TournamentBracket[] InnerBracket { get; set; }
    }
}
