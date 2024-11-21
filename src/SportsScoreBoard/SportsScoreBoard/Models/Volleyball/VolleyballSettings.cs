namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballSettings : Settings
{
    public readonly ResetButtons[] VisibleResetButtons = {ResetButtons.Game, ResetButtons.Score, ResetButtons.Sets, ResetButtons.Timeouts};
    public readonly ToggleButtons[] VisibleToggleButtons = {ToggleButtons.Serving, ToggleButtons.Sets, ToggleButtons.Timeouts,
        ToggleButtons.ManualScoring, ToggleButtons.PreviousSets, ToggleButtons.TeamNames, ToggleButtons.Timer};
}