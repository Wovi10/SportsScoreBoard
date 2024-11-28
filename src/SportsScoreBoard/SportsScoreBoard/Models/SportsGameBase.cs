using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public abstract class SportsGameBase(bool usesSets = false, bool usesBestOf = false)
{
    public abstract TeamBase Home { get; }
    public abstract TeamBase Away { get; }
    private bool GameHasFinished { get; set; }
    public virtual SettingsBase Settings { get; }
    public ScoreBase Score { get; } = new(usesSets, usesBestOf);
    public virtual int[] ScoreAmounts { get; } = {1};
    public virtual int DefaultScoreAmount => 1;

    public void IncrementHome(int amount = 1)
    {
        if (GameHasFinished)
            return;

        Score.Increment(Team.Home, amount);
        SetHomeServing();

        if (Score.HomeWon is not null)
            GameHasFinished = true;
    }

    public void IncrementAway(int amount = 1)
    {
        if (GameHasFinished)
            return;

        Score.Increment(Team.Away, amount);
        SetAwayServing();

        if (Score.HomeWon is not null)
            GameHasFinished = true;
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

    public void DecrementAway(int amount = 1)
    {
        if (GameHasFinished)
            return;

        Score.DecrementAway(amount);
    }

    public void DecrementHome(int amount = 1)
    {
        if (GameHasFinished)
            return;

        Score.DecrementHome(amount);
    }

    public void ChangeColor(Team team, ComponentColor background, MudColor mudColor)
    {
        switch (team)
        {
            case Team.Home:
                Home.ChangeColor(background, mudColor);
                break;
            case Team.Away:
                Away.ChangeColor(background, mudColor);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(team), team, null);
        }
    }

    public void ResetColors()
    {
        Home.ResetColors();
        Away.ResetColors();
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
        ResetTimeouts();
        GameHasFinished = false;
    }

    public void ResetScore()
    {
        Score.ResetPoints();
        ResetServingTeam();
    }

    public void ResetSets()
    {
        Score.ResetSets();
        ResetServingTeam();
    }

    private void ResetServingTeam()
    {
        Home.IsServing = false;
        Away.IsServing = false;
    }

    public void ResetNames()
    {
        Home.ResetName();
        Away.ResetName();
    }

    public void ResetTimeouts()
    {
        Home.ResetTimeouts();
        Away.ResetTimeouts();
    }

    public void ToggleShowServing()
        => Settings.ToggleShowServing();

    public void ToggleShowSets()
        => Settings.ToggleShowSets();

    public void BestOfChanged(int newBestOf)
    {
        Score.SetBestOf(newBestOf);
        Score.SetIncremented();
    }

    public void ToggleShowTimeouts()
        => Settings.ToggleShowTimeouts();

    public void ToggleManualScoring()
        => Settings.ToggleShowManualScoring();

    public void ToggleShowPreviousSets()

        => Settings.ToggleShowPreviousSets();

    public void ToggleShowTeamNames()
        => Settings.ToggleShowTeamNames();

    public void ToggleShowTimer()
        => Settings.ToggleShowTimer();
}