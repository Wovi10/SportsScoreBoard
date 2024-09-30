namespace SportsScoreBoard.Models;

public abstract class SportsGameBase
{
    public TeamBase Home { get; set; }
    public TeamBase Away { get; set; }
    public ScoreBase Score { get; set; }
    
    public void ResetScore()
    {
        Score.Reset();
    }
}