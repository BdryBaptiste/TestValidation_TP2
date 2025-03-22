namespace Core
{
    public class GameWonState : IGameState
    {
        private readonly int _winningPlayer;

        public GameWonState(int winningPlayer)
        {
            _winningPlayer = winningPlayer;
        }

        public IGameState PointWonByPlayer(int playerNumber, GameContext context)
        {
            throw new InvalidOperationException("Game already finished.");
        }

        public string GetScore(GameContext context)
        {
            return _winningPlayer == 1 ? "Player1 won!" : "Player2 won!";
        }
    }
}