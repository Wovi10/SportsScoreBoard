namespace SportsScoreBoard.Models;

public abstract class ScoreBase
{
    public int Home { get; set; }
    public int Away { get; set; }

    public bool? Result => Home > Away ? true : Away > Home? false : null;
    
    public void IncrementHome() 
        => Home++;

    public void IncrementAway() 
        => Away++;

    public void Reset()
    {
        Home = 0;
        Away = 0;
    }
}