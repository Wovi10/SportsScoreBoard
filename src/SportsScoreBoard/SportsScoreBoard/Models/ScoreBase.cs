namespace SportsScoreBoard.Models;

public abstract class ScoreBase
{
    public int HomePoints { get; private set; }
    public int AwayPoints { get; private set; }

    public bool? Result => HomePoints > AwayPoints ? true : AwayPoints > HomePoints? false : null;
    
    public virtual void IncrementHome() 
        => HomePoints++;

    public void DecrementHome()
    {
        if (HomePoints == 0)
            return;

        HomePoints--;
    }

    public virtual void IncrementAway() 
        => AwayPoints++;

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