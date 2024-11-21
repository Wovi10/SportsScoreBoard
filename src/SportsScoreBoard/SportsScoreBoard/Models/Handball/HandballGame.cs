namespace SportsScoreBoard.Models.Handball;

public class HandballGame : SportsGameBase
{
    public HandballTeam Home { get; set; } = new("Home", true);
    public HandballTeam Away { get; set; } = new("Away", false);
    public HandballScore Score { get; private set; } = new();

    public override void ResetScore()
        => Score.ResetPoints();

    public void IncrementHome()
        => Score.Increment(Team.Home);

    public void IncrementAway()
        => Score.Increment(Team.Away);

    public void DecrementHome()
        => Score.DecrementHome();

    public void DecrementAway()
        => Score.DecrementAway();
}