namespace SportsScoreBoard.Models.Handball;

public class HandballSettingsBase: SettingsBase
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
        {ToggleButtons.TeamNames, ToggleButtons.Timer, ToggleButtons.Timeouts};

    public HandballSettingsBase()
    {
        ToggleShowTimeouts();
        ToggleShowManualScoring();
        ToggleShowTeamNames();
        ToggleShowTimer();
    }
}