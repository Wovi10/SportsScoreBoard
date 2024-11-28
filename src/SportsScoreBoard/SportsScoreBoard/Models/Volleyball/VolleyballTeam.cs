namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballTeam(string name, bool isHome) : TeamBase(name, isHome)
{
    public bool IsServing { get; set; }
    public int Timeouts { get; private set; }

    public void ResetTimeouts() 
        => Timeouts = 0;
    
    public void TimeoutsClicked()
    {
        Timeouts++;
        if (Timeouts > 2) 
            Timeouts = 0;
    }
}