using RPS.RPS;
using System;
using System.Collections.Generic;

namespace RPS
{
    class Program
    {

        static void Main(string[] args)
        {
            var armandoPlays = new PlayerMove("Armando", "P");
            var davePlays = new PlayerMove("Dave", "S");
            var richardPlays = new PlayerMove("Richard", "R");
            var michaelPlays = new PlayerMove("Michael", "S");
            var allenPlays = new PlayerMove("Allen", "S");
            var omerPlays = new PlayerMove("Omer", "P");
            var davidEPlays = new PlayerMove("David E.", "R");
            var richardXPlays = new PlayerMove("Richard X.", "P");

            var champion = RockPaperScissor.rps_tournament_winner(new Tournament
            {
                LeftBracket = new List<IEnumerable<PlayerMove>> {
                    new List<PlayerMove> { armandoPlays, davePlays },
                    new List<PlayerMove> { richardPlays, michaelPlays }
            },
                RightBracket = new List<IEnumerable<PlayerMove>>
                {
                    new List<PlayerMove> { allenPlays, omerPlays },
                    new List<PlayerMove> { davidEPlays, richardXPlays }
                }
            });

            Console.WriteLine($"Congratulations to the Tournament Winner!!! --- {champion.Name.ToUpper()} ---");
        }
    }
}
