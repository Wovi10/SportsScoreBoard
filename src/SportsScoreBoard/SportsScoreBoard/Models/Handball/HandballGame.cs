namespace SportsScoreBoard.Models.Handball;

public class HandballGame() : SportsGameBase(usesSets: false)
{
    public override HandballSettings Settings { get; } = new();
    public override TeamBase Home { get; } = new(StaticValues.DefaultHomeName, true);
    public override TeamBase Away { get; } = new(StaticValues.DefaultAwayName, false);
}