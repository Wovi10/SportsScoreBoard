namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame(): SportsGameBase(usesSets:true, usesBestOf: true)
{
    public override VolleyballSettings Settings { get; } = new();
    public override TeamBase Home { get; } = new(StaticValues.DefaultHomeName, true);
    public override TeamBase Away { get; } = new(StaticValues.DefaultAwayName, false);
}