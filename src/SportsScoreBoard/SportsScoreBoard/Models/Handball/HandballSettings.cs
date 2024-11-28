namespace SportsScoreBoard.Models.Handball;

public class HandballSettings: Settings
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
        {ToggleButtons.TeamNames, ToggleButtons.Timer, ToggleButtons.Timeouts};

    public HandballSettings()
    {
        ToggleShowTimeouts();
        ToggleShowManualScoring();
        ToggleShowTeamNames();
        ToggleShowTimer();
    }
}