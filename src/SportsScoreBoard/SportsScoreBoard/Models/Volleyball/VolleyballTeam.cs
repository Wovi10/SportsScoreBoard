namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballTeam(string name, bool isHome) : TeamBase(name, isHome)
{
    public int NumberOfTimeouts { get; set; }
    public bool IsServing { get; set; }
}