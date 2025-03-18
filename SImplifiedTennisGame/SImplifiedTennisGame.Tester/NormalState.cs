public class NormalState : IGameState
{
    private readonly string[] scoreLabels = { "love", "15", "30", "40" };

    public IGameState PointWonByPlayer(int playerNumber, GameContext context)
    {
        if (playerNumber == 1)
            context.Player1Points++;
        else if (playerNumber == 2)
            context.Player2Points++;
        else
            throw new ArgumentException("Invalid player number.");

        if (context.Player1Points >= 3 && context.Player2Points >= 3)
        {
            if (context.Player1Points == context.Player2Points)
                return new DeuceState();
            if (Math.Abs(context.Player1Points - context.Player2Points) == 1)
                return new AdvantageState();
        }

        if ((context.Player1Points >= 4 || context.Player2Points >= 4) &&
            Math.Abs(context.Player1Points - context.Player2Points) >= 2)
        {
            return new GameWonState(context.Player1Points > context.Player2Points ? 1 : 2);
        }

        return this;
    }

    public string GetScore(GameContext context)
    {
        return $"{scoreLabels[context.Player1Points]} - {scoreLabels[context.Player2Points]}";
    }
}
