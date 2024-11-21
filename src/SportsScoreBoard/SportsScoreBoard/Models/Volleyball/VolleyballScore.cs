namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballScore : ScoreBase
{
    public int HomeSets { get; private set; }
    public int AwaySets { get; private set; }
    public List<SetScore> SetScores { get; } = new();
    public bool? HomeWon { get; private set; }
    private int SetsPlayed => HomeSets + AwaySets;
    private bool IsDecidingSet => SetsPlayed == _bestOf - 1;
    private int RequiredPoints => IsDecidingSet ? 15 : 25;
    private static int _bestOf = 5;
    private static int MinSetsToBePlayed => _bestOf / 2 + 1;
    private int GameDifference => Math.Abs(HomePoints - AwayPoints);
    private const int MinPointsDifference = 2;

    public override void Increment(Team team, int amount = 1)
    {
        base.Increment(team, amount);
        if (!SetCanIncrease())
            return;

        IncrementSet(team);
    }

    private bool SetCanIncrease()
        => GameDifference >= MinPointsDifference && (HomePoints >= RequiredPoints || AwayPoints >= RequiredPoints);

    private void IncrementSet(Team team)
    {
        SaveSetScore();

        if (team == Team.Home)
            HomeSets++;
        else
            AwaySets++;
        ResetPoints();

        SetIncremented();
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
        if (SetsPlayed < MinSetsToBePlayed)
            return;

        if (HomeSets == MinSetsToBePlayed)
        {
            HomeWon = true;
            return;
        }

        if (AwaySets == MinSetsToBePlayed)
        {
            HomeWon = false;
            return;
        }

        HomeWon = null;
    }
}