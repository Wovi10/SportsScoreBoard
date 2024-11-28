namespace SportsScoreBoard.Models.Basketball;

public class BasketballGame : SportsGameBase
{
    public override BasketballSettingsBase SettingsBase { get; } = new();
    public override TeamBase Home { get; } = new(StaticValues.DefaultHomeName, true);
    public override TeamBase Away { get; } = new(StaticValues.DefaultAwayName, false);
}