using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.RPS;
using RPS.RPS.Exceptions;
using System.Collections.Generic;

namespace RPSTests
{
    [TestClass]
    public class RpsTest
    {
        [TestMethod]
        public void RpsGameWinner_Should_Raise_WrongNumberOfPlayersError()
        {
            Assert.ThrowsException<WrongNumberOfPlayersError>(() => RockPaperScissor.rps_game_winner(new List<PlayerMove> { }));
        }

        [TestMethod]
        public void RpsGameWinner_Should_Raise_NoSuchStrategyError()
        {
            Assert.ThrowsException<NoSuchStrategyError>(() =>
                RockPaperScissor.rps_game_winner(
                    new List<PlayerMove> {
                        new PlayerMove("ABC", "P"),
                        new PlayerMove("ABCD", "e"),
                    }));
        }

        [TestMethod]
        public void RpsGameWinner_Should_Return_FirstPlayerWin_SameMove()
        {
            var player1 = new PlayerMove("ABC", "P");
            var player2 = new PlayerMove("CBA", "P");

            var retorno = RockPaperScissor.rps_game_winner(
                    new List<PlayerMove> {
                        player1,
                        player2,
                    });

            Assert.AreEqual(player1, retorno);
        }
    }
}
