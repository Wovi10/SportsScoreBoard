﻿using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballComponent : ComponentBase
{
    public static VolleyballGame Game { get; set; } = new();

    protected VolleyballSettingsComponent _volleyballSettingsComponent;
    protected VolleyballScoreboard _volleyballScoreboardSettings;

    protected override void OnInitialized()
    {
        MainLayout.SubpageTitle = "Volleyball";
        Game.Home.IsServing = true;
    }

    private void ResetGame()
    {
        Game.Reset();
        StateChange();
    }

    public void ResetScore()
    {
        Game.ResetScore();
        StateChange();
    }
    
    public void ResetSets()
    {
        Game.ResetSets();
        StateChange();
    }
    
    public void ResetTimeouts()
    {
        Game.ResetTimeouts();
        StateChange();
    }
    
    public void ToggleShowServing()
    {
        Game.ToggleShowServing();
        StateChange();
    }
    
    public void ToggleShowSets()
    {
        Game.ToggleShowSets();
        StateChange();
    }
    
    public void ToggleShowTimeouts()
    {
        Game.ToggleShowTimeouts();
        StateChange();
    }

    public void IncrementHome()
    {
        Game.IncrementHome();
        StateChange();
    }
    
    private void DecrementHome()
    {
        Game.DecrementHome();
        StateChange();
    }

    public void IncrementAway()
    {
        Game.IncrementAway();
        StateChange();
    }

    private void DecrementAway()
    {
        Game.DecrementAway();
        StateChange();
    }
    
    public void ChangeHomeName(string name)
    {
        Game.ChangeHomeName(name);
        StateChange();
    }
    
    public void ChangeAwayName(string name)
    {
        Game.ChangeAwayName(name);
        StateChange();
    }

    private void StateChange()
    {
        StateHasChanged();
        _volleyballScoreboardSettings.RefreshMe();
        _volleyballSettingsComponent.RefreshMe();
    }

    private void ToggleManualScoring()
    {
        Game.ToggleManualScoring();
        StateChange();
    }

    private void ToggleShowPreviousSets()
    {
        Game.ToggleShowPreviousSets();
        StateChange();
    }

    private void ToggleShowTeamNames()
    {
        Game.ToggleShowTeamNames();
        StateChange();
    }
    
    private void ToggleShowTimer()
    {
        throw new NotImplementedException();
    }

    private void BestOfValueChanged(int newValue)
    {
        Game.BestOfChanged(newValue);
        StateChange();
    }
}