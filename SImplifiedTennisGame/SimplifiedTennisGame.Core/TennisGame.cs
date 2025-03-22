namespace Core
{
    public class TennisGame
    {
        private readonly GameContext _context;
        private IGameState _state;

        public TennisGame()
        {
            _context = new GameContext();
            _state = new NormalState();
        }

        public string Score() => _state.GetScore(_context);

        public void PointWonByPlayerNumber(int playerNumber)
        {
            _state = _state.PointWonByPlayer(playerNumber, _context);
        }
    }
}