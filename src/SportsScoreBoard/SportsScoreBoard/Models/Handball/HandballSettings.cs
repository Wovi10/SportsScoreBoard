namespace SportsScoreBoard.Models.Handball;

public class HandballSettings: Settings
{
    public readonly ResetButtons[] VisibleButtons = {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer};
    public readonly ToggleButtons[] VisibleToggleButtons = {ToggleButtons.TeamNames, ToggleButtons.Timer};
}