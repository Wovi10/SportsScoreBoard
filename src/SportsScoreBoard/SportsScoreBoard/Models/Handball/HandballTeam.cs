namespace SportsScoreBoard.Models.Handball;

public class HandballTeam(string name, bool isHome) : TeamBase(name, isHome)
{
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