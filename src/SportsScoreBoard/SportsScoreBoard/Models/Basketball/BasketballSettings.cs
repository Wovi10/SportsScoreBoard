using SportsScoreBoard.Models.Enums;

namespace SportsScoreBoard.Models.Basketball;

public class BasketballSettings : SettingsBase
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer, ResetButtons.Names};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
        {ToggleButtons.TeamNames, ToggleButtons.Timer, ToggleButtons.Timeouts};

    public BasketballSettings()
    {
        ToggleShowTimeouts();
        ToggleShowManualScoring();
        ToggleShowTeamNames();
        ToggleShowTimer();
    }
}