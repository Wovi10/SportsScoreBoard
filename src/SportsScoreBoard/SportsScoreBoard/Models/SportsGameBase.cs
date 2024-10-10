namespace SportsScoreBoard.Models;

public abstract class SportsGameBase
{
    public TeamBase Home { get; set; }
    public TeamBase Away { get; set; }
    public ScoreBase Score { get; set; }
    protected bool GameHasFinished { get; set; }

    public abstract void ResetScore();
}