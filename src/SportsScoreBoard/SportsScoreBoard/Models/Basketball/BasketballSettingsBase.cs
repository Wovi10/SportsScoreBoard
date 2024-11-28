namespace SportsScoreBoard.Models.Basketball;

public class BasketballSettingsBase : SettingsBase
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
        {ToggleButtons.TeamNames, ToggleButtons.Timer, ToggleButtons.Timeouts};
}