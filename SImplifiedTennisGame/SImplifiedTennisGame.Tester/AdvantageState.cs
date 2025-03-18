public class AdvantageState : IGameState
{
    public IGameState PointWonByPlayer(int playerNumber, GameContext context)
    {
        if (playerNumber == 1)
            context.Player1Points++;
        else if (playerNumber == 2)
            context.Player2Points++;
        else
            throw new ArgumentException("Invalid player number.");

        if (Math.Abs(context.Player1Points - context.Player2Points) >= 2)
            return new GameWonState(context.Player1Points > context.Player2Points ? 1 : 2);
        if (context.Player1Points == context.Player2Points)
            return new DeuceState();
        return this;
    }

    public string GetScore(GameContext context)
    {
        return context.Player1Points > context.Player2Points
            ? "Player1 has the advantage."
            : "Player2 has the advantage.";
    }
}