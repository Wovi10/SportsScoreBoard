namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballScore : ScoreBase
{
    public int HomeSets { get; set; }
    public int AwaySets { get; set; }
    private int SetsPlayed => HomeSets + AwaySets;
    private bool IsDecidingGame => SetsPlayed == _bestOf - 1;
    private int RequiredPoints => IsDecidingGame ? 15 : 25;
    private int GameDifference => Math.Abs(HomePoints - AwayPoints);
    private static int _bestOf = 5;

    public bool IsGameOver()
    {
        if (GameDifference < 2)
            return false;

        return HomePoints >= RequiredPoints || AwayPoints >= RequiredPoints;
    }

    public override void IncrementHome()
    {
        base.IncrementHome();
        if (GameDifference < 2 || HomePoints <= AwayPoints || HomePoints < RequiredPoints)
            return;

        IncrementHomeSet();
    }

    public override void IncrementAway()
    {
        base.IncrementAway();
        if (GameDifference < 2 || AwayPoints <= HomePoints || AwayPoints < RequiredPoints)
            return;

        IncrementAwaySet();
    }

    private void IncrementHomeSet()
    {
        HomeSets++;
        ResetPoints();
    }

    private void IncrementAwaySet()
    {
        AwaySets++;
        ResetPoints();
    }

    public void SetBestOf(int newBestOf) 
        => _bestOf = newBestOf;

    public void ResetSets()
    {
        HomeSets = 0;
        AwaySets = 0;
    }
}