namespace SportsScoreBoard.Models;

public abstract class ScoreBase
{
    public int HomePoints { get; private set; }
    public int AwayPoints { get; private set; }

    public bool? Result => HomePoints > AwayPoints ? true : AwayPoints > HomePoints? false : null;
    
    public virtual void IncrementHome(int amount = 1)
        => HomePoints += amount;

    public void DecrementHome()
    {
        if (HomePoints == 0)
            return;

        HomePoints--;
    }

    public virtual void IncrementAway(int amount = 1)
        => AwayPoints += amount;

    public void DecrementAway()
    {
        if (AwayPoints == 0)
            return;

        AwayPoints--;
    }

    public void ResetPoints()
    {
        HomePoints = 0;
        AwayPoints = 0;
    }
}