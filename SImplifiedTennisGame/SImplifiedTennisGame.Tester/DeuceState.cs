public class DeuceState : IGameState
{
    public IGameState PointWonByPlayer(int playerNumber, GameContext context)
    {
        if (playerNumber == 1)
            context.Player1Points++;
        else if (playerNumber == 2)
            context.Player2Points++;
        else
            throw new ArgumentException("Invalid player number.");

        return new AdvantageState();
    }

    public string GetScore(GameContext context)
    {
        return "Deuce";
    }
}