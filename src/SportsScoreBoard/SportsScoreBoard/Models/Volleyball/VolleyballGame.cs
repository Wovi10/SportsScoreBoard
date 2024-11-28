namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame : SportsGameBase
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";
    public VolleyballSettings Settings { get; set; } = new();
    public override VolleyballTeam Home { get; } = new(DefaultHomeName, true);
    public override VolleyballTeam Away { get; } = new(DefaultAwayName, false);
    public new VolleyballScore Score { get; set; } = new();
    public int BestOf { get; private set; } = 5;

    public void IncrementHome()
    {
        if (GameHasFinished)
            return;

        Score.Increment(Team.Home);
        SetHomeServing();

        if (Score.HomeWon is not null)
            GameHasFinished = true;
    }

    public void IncrementAway()
    {
        if (GameHasFinished)
            return;

        Score.Increment(Team.Away);
        SetAwayServing();

        if (Score.HomeWon is not null)
            GameHasFinished = true;
    }

    public void DecrementAway()
    {
        if (GameHasFinished)
            return;

        Score.DecrementAway();
    }

    public void DecrementHome()
    {
        if (GameHasFinished)
            return;

        Score.DecrementHome();
    }

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

    public void Reset()
    {
        ResetScore();
        ResetSets();
        ResetServingTeam();
        ResetNames();
    }

    public override void ResetScore()
    {
        Score.ResetPoints();
        ResetServingTeam();
    }

    public void ResetSets()
    {
        Score.ResetSets();
        ResetServingTeam();
    }

    public void ToggleShowServing()
        => Settings.ToggleShowServing();

    public void ToggleShowSets()
        => Settings.ToggleShowSets();

    public void BestOfChanged(int newBestOf)
    {
        BestOf = newBestOf;
        VolleyballScore.SetBestOf(newBestOf);
        Score.SetIncremented();
    }

    private void ResetServingTeam()
    {
        Home.IsServing = false;
        Away.IsServing = false;
    }

    private void ResetNames()
    {
        Home.ResetName();
        Away.ResetName();
    }

    public void ResetTimeouts()
    {
        Home.ResetTimeouts();
        Away.ResetTimeouts();
    }

    private void SetHomeServing()
    {
        if (GameHasFinished)
            return;

        Home.IsServing = true;
        Away.IsServing = false;
    }

    private void SetAwayServing()
    {
        if (GameHasFinished)
            return;

        Home.IsServing = false;
        Away.IsServing = true;
    }

    public void ToggleShowTimeouts() 
        => Settings.ToggleShowTimeouts();

    public void ToggleManualScoring() 
        => Settings.ToggleManualScoring();

    public void ToggleShowPreviousSets() 
        
        => Settings.ToggleShowPreviousSets();

    public void ToggleShowTeamNames() 
        => Settings.ToggleShowTeamNames();

    public void ToggleShowTimer()
        => Settings.ToggleShowTimer();
}