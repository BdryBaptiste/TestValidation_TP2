public interface IGameState
{
    IGameState PointWonByPlayer(int playerNumber, GameContext context);
    string GetScore(GameContext context);
}