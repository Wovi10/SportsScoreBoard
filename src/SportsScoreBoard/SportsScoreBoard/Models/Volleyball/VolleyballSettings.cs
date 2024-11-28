using SportsScoreBoard.Models.Enums;

namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballSettings : SettingsBase
{
    public override ResetButtons[] VisibleResetButtons { get; } =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Sets, ResetButtons.Timeouts, ResetButtons.Names};
    public override ToggleButtons[] VisibleToggleButtons { get; } =
    {ToggleButtons.Serving, ToggleButtons.Sets, ToggleButtons.Timeouts, ToggleButtons.ManualScoring,
        ToggleButtons.PreviousSets, ToggleButtons.TeamNames, ToggleButtons.Timer};

    public VolleyballSettings()
    {
        ToggleShowServing();
        ToggleShowSets();
        ToggleShowTimeouts();
        ToggleShowManualScoring();
        ToggleShowPreviousSets();
        ToggleShowTeamNames();
    }
}