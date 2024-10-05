namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballSettings
{
    public bool ShowServing { get; private set; } = true;
    public bool ShowSets { get; private set; } = true;
    public bool ShowTimeouts { get; private set; } = true;
    
    public void ToggleShowServing()
        => ShowServing = !ShowServing;

    public void ToggleShowSets() 
        => ShowSets = !ShowSets;

    public void ToggleShowTimeouts() 
        => ShowTimeouts = !ShowTimeouts;
}