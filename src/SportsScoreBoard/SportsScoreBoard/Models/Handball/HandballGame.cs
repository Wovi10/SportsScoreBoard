namespace SportsScoreBoard.Models.Handball;

public class HandballGame() : SportsGameBase(usesSets: false)
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";
    public override HandballSettings Settings { get; } = new();
    public override TeamBase Home { get; } = new(DefaultHomeName, true);
    public override TeamBase Away { get; } = new(DefaultAwayName, false);
}