using MudBlazor.Utilities;

namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame : SportsGameBase
{
    public VolleyballSettings Settings { get; set; } = new();
    public new VolleyballTeam Home { get; set; } = new("Home", true);
    public new VolleyballTeam Away { get; set; } = new("Away", false);
    public new VolleyballScore Score { get; set; } = new();
    public int BestOf { get; private set; } = 5;

    public void IncrementHome()
    {
        Score.IncrementHome();
        SetHomeServing();
    }

    public void IncrementAway()
    {
        Score.IncrementAway();
        SetAwayServing();
    }

    public void DecrementAway() 
        => Score.DecrementAway();
    
    public void DecrementHome() 
        => Score.DecrementHome();

    public void ChangeHomeName(string newValue)
        => Home.ChangeName(newValue);

    public void ChangeAwayName(string newValue)
        => Away.ChangeName(newValue);

    public void Reset()
    {
        ResetScore();
        ResetSets();
        ResetServingTeam();
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
        Score.SetBestOf(newBestOf);
    }

    private void ResetServingTeam()
    {
        Home.IsServing = false;
        Away.IsServing = false;
    }

    public void ResetTimeouts()
    {
        Home.ResetTimeouts();
        Away.ResetTimeouts();
    }

    private void SetHomeServing()
    {
        Home.IsServing = true;
        Away.IsServing = false;
    }

    private void SetAwayServing()
    {
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

    public void ResetColors()
    {
        Home.Colors.ResetColors();
        Away.Colors.ResetColors();
    }
}