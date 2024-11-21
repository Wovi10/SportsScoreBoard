namespace SportsScoreBoard.Models.Handball;

public class HandballSettings()
    : Settings(showTimeOuts: true, showManualScoring: true, showTeamNames: true, showTimer: true)
{
    public readonly ResetButtons[] VisibleButtons =
        {ResetButtons.Game, ResetButtons.Score, ResetButtons.Timeouts, ResetButtons.Timer};

    public readonly ToggleButtons[] VisibleToggleButtons = {ToggleButtons.TeamNames, ToggleButtons.Timer, ToggleButtons.Timeouts};
}