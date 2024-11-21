namespace SportsScoreBoard.Models;

public class Settings(bool showServing = false, bool showSets = false, bool showTimeOuts = false,
    bool showManualScoring = false, bool showPreviousSets = false, bool showTeamNames = false, bool showTimer = false)
{
    public bool ShowServing { get; private set; } = showServing;
    public bool ShowSets { get; private set; } = showSets;
    public bool ShowTimeouts { get; private set; } = showTimeOuts;
    public bool ShowManualScoring { get; private set; } = showManualScoring;
    public bool ShowPreviousSets { get; private set; } = showPreviousSets;
    public bool ShowTeamNames { get; private set; } = showTeamNames;
    public bool ShowTimer { get; private set; } = showTimer;

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

    public void ToggleShowTimer()
        => ShowTimer = !ShowTimer;
}