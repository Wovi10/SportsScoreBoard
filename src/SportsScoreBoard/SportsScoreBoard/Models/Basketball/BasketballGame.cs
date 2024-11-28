namespace SportsScoreBoard.Models.Basketball;

public class BasketballGame : SportsGameBase
{
    public override BasketballSettings Settings { get; } = new();
    public override TeamBase Home { get; } = new(StaticValues.DefaultHomeName, true);
    public override TeamBase Away { get; } = new(StaticValues.DefaultAwayName, false);
    public override int[] ScoreAmounts { get; } = {1, 2, 3};
    public override int DefaultScoreAmount => 2;
}