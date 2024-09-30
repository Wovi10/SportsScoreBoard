namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame : SportsGameBase
{
    public VolleyballGame()
    {
        Home = new VolleyballTeam("Home", true);
        Away = new VolleyballTeam("Away", false);
        Score = new VolleyballScore();
    }

    public void IncrementHome() 
        => Score.IncrementHome();

    public void IncrementAway() 
        => Score.IncrementAway();

    public void ChangeHomeName(string newValue) 
        => Home.ChangeName(newValue);
    
    public void ChangeAwayName(string newValue)
        => Away.ChangeName(newValue);
}