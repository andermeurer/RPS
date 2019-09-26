using RPS.RPS.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace RPS.RPS
{
    public class RockPaperScissor
    {
        public static PlayerMove rps_game_winner(IEnumerable<PlayerMove> list)
        {
            if (list == null || list.Count() != 2)
                throw new WrongNumberOfPlayersError();

            var firstPlayer = list.First();
            var lastPlayer = list.Last();

            if (!firstPlayer.HasAllowedMove())
                throw new NoSuchStrategyError();

            if (!lastPlayer.HasAllowedMove())
                throw new NoSuchStrategyError();

            if (firstPlayer.Move == lastPlayer.Move)
                return firstPlayer;

            else if (firstPlayer.Move == "R" &&
                lastPlayer.Move == "S")
                return firstPlayer;

            else if (firstPlayer.Move == "P" &&
                lastPlayer.Move == "R")
                return firstPlayer;

            else if (firstPlayer.Move == "S" &&
                lastPlayer.Move == "P")
                return firstPlayer;

            else
                return lastPlayer;
        }


        public static PlayerMove rps_tournament_winner(Tournament tournament)
        {
            return rps_game_winner(new List<PlayerMove> {
                resolve_bracketed_games(tournament.LeftBracket),
                resolve_bracketed_games(tournament.RightBracket)
                });
        }               

        private static PlayerMove resolve_bracketed_games(List<IEnumerable<PlayerMove>> bracketedGames)
        {
            var innerWinnersBracket = new List<IEnumerable<PlayerMove>> { };

            PlayerMove winner1 = null;
            for (int i = 0; i < bracketedGames.Count(); i++)
            {
                winner1 = rps_game_winner(bracketedGames[i]);
                i++;
                if (i >= bracketedGames.Count())
                    break;

                var winner2 = rps_game_winner(bracketedGames[i]);

                innerWinnersBracket.Add(new List<PlayerMove> { winner1, winner2 });
            }

            if (innerWinnersBracket.Count > 0)
                return resolve_bracketed_games(innerWinnersBracket);

            return winner1;
        }
    }
}
