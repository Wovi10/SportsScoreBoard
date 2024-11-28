using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public abstract class SportsGameBase(bool usesSets = false, bool usesBestOf = false)
{
    public abstract TeamBase Home { get; }
    public abstract TeamBase Away { get; }
    private bool GameHasFinished { get; set; }
    public virtual SettingsBase SettingsBase { get; }
    public ScoreBase Score { get; } = new(usesSets, usesBestOf);

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

    public void ResetServingTeam()
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

    public void ToggleShowServing()
        => SettingsBase.ToggleShowServing();

    public void ToggleShowSets()
        => SettingsBase.ToggleShowSets();

    public void BestOfChanged(int newBestOf)
    {
        Score.SetBestOf(newBestOf);
        Score.SetIncremented();
    }

    public void ToggleShowTimeouts()
        => SettingsBase.ToggleShowTimeouts();

    public void ToggleManualScoring()
        => SettingsBase.ToggleShowManualScoring();

    public void ToggleShowPreviousSets()

        => SettingsBase.ToggleShowPreviousSets();

    public void ToggleShowTeamNames()
        => SettingsBase.ToggleShowTeamNames();

    public void ToggleShowTimer()
        => SettingsBase.ToggleShowTimer();
}