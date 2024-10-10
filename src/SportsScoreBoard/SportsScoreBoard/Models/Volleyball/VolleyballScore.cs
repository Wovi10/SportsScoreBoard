namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballScore : ScoreBase
{
    public int HomeSets { get; private set; }
    public int AwaySets { get; private set; }
    public List<SetScore> SetScores { get; } = new();
    public bool? HomeWon { get; private set; }
    private int SetsPlayed => HomeSets + AwaySets;
    private bool IsDecidingGame => SetsPlayed == _bestOf - 1;
    private int RequiredPoints => IsDecidingGame ? 15 : 25;
    private static int _bestOf = 5;
    private static int _minSetsToBePlayed => _bestOf / 2 + 1;
    private int GameDifference => Math.Abs(HomePoints - AwayPoints);


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
        SaveSetScore();
        HomeSets++;
        ResetPoints();

        SetIncremented();
    }

    private void IncrementAwaySet()
    {
        SaveSetScore();
        AwaySets++;
        ResetPoints();
    }

    public static void SetBestOf(int newBestOf)
        => _bestOf = newBestOf;

    public void ResetSets()
    {
        HomeSets = 0;
        AwaySets = 0;
        SetScores.Clear();
    }
    
    private void SaveSetScore() 
        => SetScores.Add(new SetScore(HomePoints,AwayPoints));


    public void SetIncremented()
    {
        if (SetsPlayed < _minSetsToBePlayed)
            return;

        if (HomeSets == _minSetsToBePlayed)
        {
            HomeWon = true;
            return;
        }

        if (AwaySets == _minSetsToBePlayed)
        {
            HomeWon = false;
            return;
        }

        HomeWon = null;
    }
}