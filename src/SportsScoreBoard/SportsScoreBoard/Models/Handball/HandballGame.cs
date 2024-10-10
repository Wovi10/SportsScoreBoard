namespace SportsScoreBoard.Models.Handball;

public class HandballGame : SportsGameBase
{
    public HandballTeam Home { get; set; } = new("Home", true);
    public HandballTeam Away { get; set; } = new("Away", false);
    public HandballScore Score { get; private set; } = new();

    public override void ResetScore()
        => Score.ResetPoints();

    public void IncrementHome()
        => Score.IncrementHome();

    public void IncrementAway()
        => Score.IncrementAway();

    public void DecrementHome()
        => Score.DecrementHome();

    public void DecrementAway()
        => Score.DecrementAway();
}