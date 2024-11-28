namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballSettingsBase : SettingsBase
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Sets, ResetButtons.Timeouts};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
    {ToggleButtons.Serving, ToggleButtons.Sets, ToggleButtons.Timeouts, ToggleButtons.ManualScoring,
        ToggleButtons.PreviousSets, ToggleButtons.TeamNames, ToggleButtons.Timer};

    public VolleyballSettingsBase()
    {
        ToggleShowServing();
        ToggleShowSets();
        ToggleShowTimeouts();
        ToggleShowManualScoring();
        ToggleShowPreviousSets();
        ToggleShowTeamNames();
    }
}