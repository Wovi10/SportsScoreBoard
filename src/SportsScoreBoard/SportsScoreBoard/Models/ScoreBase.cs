namespace SportsScoreBoard.Models;

public class ScoreBase(bool usesSets = false, bool usesBestOf = false)
{
    public int HomePoints { get; private set; }
    public int AwayPoints { get; private set; }
    public int HomeSets { get; private set; }
    public int AwaySets { get; private set; }
    public List<SetScore> SetScores { get; } = new();
    public bool? HomeWon { get; private set; }
    public int BestOf { get; private set; } = 5;
    public bool UsesBestOf { get; } = usesBestOf;

    private int SetsPlayed => HomeSets + AwaySets;
    private bool IsDecidingSet => UsesBestOf && SetsPlayed == BestOf - 1;
    private int RequiredPoints => IsDecidingSet ? 15 : 25;

    private int MinSetsToBePlayed => BestOf / 2 + 1;
    private int GameDifference => Math.Abs(HomePoints - AwayPoints);
    private const int MinPointsDifference = 2;
    public bool? Result => HomePoints > AwayPoints ? true : AwayPoints > HomePoints? false : null;

    public void Increment(Team team, int amount = 1)
    {
        if (team == Team.Home)
            HomePoints += amount;
        else
            AwayPoints += amount;

        if (!SetCanIncrease())
            return;

        IncrementSet(team);
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

    public void ResetSets()
    {
        HomeSets = 0;
        AwaySets = 0;
        SetScores.Clear();
    }

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

    public void DecrementSet(Team team)
    {
        if (team == Team.Home)
            HomeSets--;
        else
            AwaySets--;
    }

    private void SaveSetScore()
        => SetScores.Add(new SetScore(HomePoints,AwayPoints));

    public void SetIncremented()
    {
        if (!UsesBestOf)
            return;

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

    public void SetBestOf(int newBestOf)
        => BestOf = newBestOf;

    private bool SetCanIncrease()
        => usesSets &&
           GameDifference >= MinPointsDifference && (HomePoints >= RequiredPoints || AwayPoints >= RequiredPoints);
}