using System.Collections.Generic;

namespace RPS.RPS
{

    public class Tournament
    {
        public List<IEnumerable<PlayerMove>> LeftBracket { get; set; }
        public List<IEnumerable<PlayerMove>> RightBracket { get; set; }
    }
}
