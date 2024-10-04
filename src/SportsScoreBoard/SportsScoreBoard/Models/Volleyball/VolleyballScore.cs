namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballScore : ScoreBase
{
    public int HomeSets { get; set; }
    public int AwaySets { get; set; }
    public int SetsPlayed => HomeSets + AwaySets;
    public bool IsDecidingGame => SetsPlayed == 4;
    public int RequiredPoints { get; set; } = 25;
    private int GameDifference => Math.Abs(HomePoints - AwayPoints);

    public bool IsGameOver(bool isDecidingGame)
    {
        if (GameDifference < 2)
            return false;

        var numberToWin = isDecidingGame ? 15 : 25;

        return HomePoints >= numberToWin || AwayPoints >= numberToWin;
    }

    public override void IncrementHome()
    {
        if (GameDifference < 2 || HomePoints <= AwayPoints || HomePoints < RequiredPoints)
            return;

        IncrementHomeSet();
    }
    
    public override void IncrementAway()
    {
        if (GameDifference < 2 || AwayPoints <= HomePoints || AwayPoints < RequiredPoints)
            return;

        IncrementAwaySet();
    }

    private void IncrementHomeSet()
    {
        HomeSets++;
        if (IsDecidingGame) 
            RequiredPoints = 15;

        Reset();
    }
    
    private void IncrementAwaySet()
    {
        AwaySets++;
        if (IsDecidingGame) 
            RequiredPoints = 15;

        Reset();
    }
}