namespace SportsScoreBoard.Models;

public abstract class GameScoreBase
{
    public int Home { get; private set; }
    public int Away { get; private set; }

    public void Reset()
    {
        Home = 0;
        Away = 0;
    }

    public virtual void AwayScored()
    {
        Away++;
    }

    public virtual void HomeScored()
    {
        Home++;
    }
}