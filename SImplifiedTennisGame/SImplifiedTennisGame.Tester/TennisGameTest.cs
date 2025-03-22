using Core;
using Xunit;

namespace SimplifiedTennisGame.Tester
{
    public class TennisGameTest
    {
        [Fact]
        public void InitialScore_ShouldAllBeLove()
        {
            TennisGame tennisGame = new TennisGame();

            Assert.Equal("love - love", tennisGame.Score());
        }

        [Fact]
        public void Player1Scores_FirstPoint_ShouldBe15Love()
        {
            TennisGame game = new TennisGame();
            game.PointWonByPlayerNumber(1);
            Assert.Equal("15 - love", game.Score());
        }

        [Fact]
        public void Player1ScoresFinalPoint_ShouldWin()
        {
            TennisGame game = new TennisGame();

            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(1);

            Assert.Equal("Player1 won!", game.Score());

        }

        [Fact]
        public void PlayerReachDeuce_ShouldReturnDeuce()
        {
            TennisGame game = new TennisGame();

            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(2);

            Assert.Equal("Deuce", game.Score());
        }

        [Fact]
        public void Player1HasTheAdvantage_ShouldReturnAdvantagePlayer1()
        {
            TennisGame game = new TennisGame();

            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(1);
            game.PointWonByPlayerNumber(2);
            game.PointWonByPlayerNumber(1);

            Assert.Equal("Player1 has the advantage.", game.Score());
        }

        [Fact]
        public void InvalidPlayerScores_Exception()
        {
            TennisGame game = new TennisGame();
            Assert.Throws<ArgumentException>(() => game.PointWonByPlayerNumber(3));
        }
    }
}
