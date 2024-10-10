﻿using MudBlazor.Utilities;

namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame : SportsGameBase
{
    public VolleyballSettings Settings { get; set; } = new();
    public new VolleyballTeam Home { get; set; } = new("Home", true);
    public new VolleyballTeam Away { get; set; } = new("Away", false);
    public new VolleyballScore Score { get; set; } = new();
    public int BestOf { get; private set; } = 5;
    private bool _gameHasFinished;

    public void IncrementHome()
    {
        if (_gameHasFinished)
            return;

        Score.IncrementHome();
        SetHomeServing();

        if (Score.HomeWon is not null)
            _gameHasFinished = true;
    }

    public void IncrementAway()
    {
        if (_gameHasFinished)
            return;

        Score.IncrementAway();
        SetAwayServing();

        if (Score.HomeWon is not null)
            _gameHasFinished = true;
    }

    public void DecrementAway()
    {
        if (_gameHasFinished)
            return;

        Score.DecrementAway();
    }

    public void DecrementHome()
    {
        if (_gameHasFinished)
            return;

        Score.DecrementHome();
    }

    public void ChangeHomeName(string newValue)
    {
        if (_gameHasFinished)
            return;

        Home.ChangeName(newValue);
    }

    public void ChangeAwayName(string newValue)
    {
        if (_gameHasFinished)
            return;

        Away.ChangeName(newValue);
    }

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
        VolleyballScore.SetBestOf(newBestOf);
        Score.SetIncremented();
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
        if (_gameHasFinished)
            return;

        Home.IsServing = true;
        Away.IsServing = false;
    }

    private void SetAwayServing()
    {
        if (_gameHasFinished)
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

    public void ResetColors()
    {
        Home.Colors.ResetColors();
        Away.Colors.ResetColors();
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
        }
    }
}