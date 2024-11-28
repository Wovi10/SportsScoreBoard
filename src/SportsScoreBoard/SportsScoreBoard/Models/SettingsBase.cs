namespace SportsScoreBoard.Models;

public abstract class SettingsBase
{
    public abstract ResetButtons[] VisibleResetButtons { get; }
    public abstract ToggleButtons[] VisibleToggleButtons { get; }
    public bool ShowServing { get; private set; }
    public bool ShowSets { get; private set; }
    public bool ShowTimeouts { get; private set; }
    public bool ShowManualScoring { get; private set; }
    public bool ShowPreviousSets { get; private set; }
    public bool ShowTeamNames { get; private set; }
    public bool ShowTimer { get; private set; }

    public void ToggleShowServing()
        => ShowServing = !ShowServing;

    public void ToggleShowSets()
        => ShowSets = !ShowSets;

    public void ToggleShowTimeouts()
        => ShowTimeouts = !ShowTimeouts;

    public void ToggleShowManualScoring()
        => ShowManualScoring = !ShowManualScoring;

    public void ToggleShowPreviousSets()
        => ShowPreviousSets = !ShowPreviousSets;

    public void ToggleShowTeamNames()
        => ShowTeamNames = !ShowTeamNames;

    public void ToggleShowTimer()
        => ShowTimer = !ShowTimer;
}