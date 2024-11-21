using SportsScoreBoard.Components.Pages.Sports.HandballComponents;

namespace SportsScoreBoard.Models.Handball;

public class HandballGame : SportsGameBase
{
    public HandballTeam Home { get; } = new("Home", true);
    public HandballTeam Away { get; } = new("Away", false);
    public HandballScore Score { get; } = new();
    public HandballSettings Settings { get; } = new();

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

    public void ChangeHomeName(string newValue)
    {
        if (GameHasFinished)
            return;

        Home.ChangeName(newValue);
    }

    public void ChangeAwayName(string newValue)
    {
        if (GameHasFinished)
            return;

        Away.ChangeName(newValue);
    }
}