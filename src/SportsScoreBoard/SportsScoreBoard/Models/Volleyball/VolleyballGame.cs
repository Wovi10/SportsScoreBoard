namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame(): SportsGameBase(usesSets:true, usesBestOf: true)
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";
    public override VolleyballSettings Settings { get; } = new();
    public override TeamBase Home { get; } = new(DefaultHomeName, true);
    public override TeamBase Away { get; } = new(DefaultAwayName, false);
}