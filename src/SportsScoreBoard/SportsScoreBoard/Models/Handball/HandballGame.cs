namespace SportsScoreBoard.Models.Handball;

public class HandballGame : SportsGameBase
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";
    public HandballSettings Settings { get; } = new();
    public override HandballTeam Home { get; } = new(DefaultHomeName, true);
    public override HandballTeam Away { get; } = new(DefaultAwayName, false);
    public HandballScore Score { get; } = new();

    public override void ResetScore()
        => Score.ResetPoints();

    private void ResetNames()
    {
        Home.ResetName();
        Away.ResetName();
    }

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

    public void ResetGame()
    {
        ResetScore();
        ResetTimeouts();
        ResetNames();
        GameHasFinished = false;
    }

    public void ResetTimeouts()
    {
        Home.ResetTimeouts();
        Away.ResetTimeouts();
    }

    public void ToggleShowTimeouts()
        => Settings.ToggleShowTimeouts();

    public void ToggleShowTeamNames()
        => Settings.ToggleShowTeamNames();

    public void ToggleManualScoring()
        => Settings.ToggleManualScoring();

    public void ToggleShowTimer()
        => Settings.ToggleShowTimer();
}