namespace SportsScoreBoard.Models;

public abstract class ScoreBase
{
    public int HomePoints { get; private set; }
    public int AwayPoints { get; private set; }

    public bool? Result => HomePoints > AwayPoints ? true : AwayPoints > HomePoints? false : null;

    public virtual void Increment(Team team, int amount = 1)
    {
        if (team == Team.Home)
            HomePoints += amount;
        else
            AwayPoints += amount;
    }

    public void DecrementHome(int amount = 1)
    {
        if (HomePoints == 0)
            return;

        Increment(Team.Home, amount * -1);
    }

    public void DecrementAway(int amount = 1)
    {
        if (AwayPoints == 0)
            return;

        Increment(Team.Away, amount * -1);
    }

    public void ResetPoints()
    {
        HomePoints = 0;
        AwayPoints = 0;
    }
}