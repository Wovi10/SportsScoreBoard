namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballSettings
{
    public readonly ResetButtons[] VisibleButtons = {ResetButtons.Game, ResetButtons.Score, ResetButtons.Sets, ResetButtons.Timeouts};
    public bool ShowServing { get; private set; } = true;
    public bool ShowSets { get; private set; } = true;
    public bool ShowTimeouts { get; private set; } = true;
    public bool ShowManualScoring { get; private set; } = true;
    public bool ShowPreviousSets { get; private set; } = true;
    public bool ShowTeamNames { get; private set; } = true;

    public void ToggleShowServing()
        => ShowServing = !ShowServing;

    public void ToggleShowSets() 
        => ShowSets = !ShowSets;

    public void ToggleShowTimeouts() 
        => ShowTimeouts = !ShowTimeouts;

    public void ToggleManualScoring() 
        => ShowManualScoring = !ShowManualScoring;
    
    public void ToggleShowPreviousSets()
        => ShowPreviousSets = !ShowPreviousSets;

    public void ToggleShowTeamNames() 
        => ShowTeamNames = !ShowTeamNames;
}