using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents;
using SportsScoreBoard.Models;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballComponent : ComponentBase
{
    [Inject] private IDialogService DialogService { get; set; } = default!;

    public static VolleyballGame Game { get; set; } = new();

    private VolleyballSettingsComponent _volleyballSettingsComponent;
    private VolleyballScoreboard _volleyballScoreboardSettings;

    private TeamWonDialog _teamWonDialog = default!;
    private VolleyballTeam _teamThatWon;

    protected override void OnInitialized()
    {
        MainLayout.SubpageTitle = "Volleyball";
        Game.Home.IsServing = true;
    }

    private static void ResetGame()
    {
        Game.Reset();
    }

    public static void ResetScore()
    {
        Game.ResetScore();
    }
    
    public static void ResetSets()
    {
        Game.ResetSets();
    }
    
    public static void ResetTimeouts()
    {
        Game.ResetTimeouts();
    }
    
    public static void ToggleShowServing()
    {
        Game.ToggleShowServing();
    }
    
    public static void ToggleShowSets()
    {
        Game.ToggleShowSets();
    }
    
    public static void ToggleShowTimeouts()
    {
        Game.ToggleShowTimeouts();
    }

    public async Task IncrementHome()
    {
        Game.IncrementHome();
        await CheckTeamWonAsync();
    }
    
    private static void DecrementHome()
    {
        Game.DecrementHome();
    }

    public async Task IncrementAway()
    {
        Game.IncrementAway();
        await CheckTeamWonAsync();
    }

    private static void DecrementAway()
    {
        Game.DecrementAway();
    }
    
    public static void ChangeHomeName(string name)
    {
        Game.ChangeHomeName(name);
    }
    
    public static void ChangeAwayName(string name)
    {
        Game.ChangeAwayName(name);
    }

    private void StateChange()
    {
        StateHasChanged();
        _volleyballScoreboardSettings.RefreshMe();
        _volleyballSettingsComponent.RefreshMe();
    }

    private static void ToggleManualScoring()
    {
        Game.ToggleManualScoring();
    }

    private static void ToggleShowPreviousSets()
    {
        Game.ToggleShowPreviousSets();
    }

    private static void ToggleShowTeamNames()
    {
        Game.ToggleShowTeamNames();
    }

    private async Task BestOfValueChanged(int newValue)
    {
        Game.BestOfChanged(newValue);
        await CheckTeamWonAsync();
    }

    private void OnHomeBackgroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Home, ComponentColor.Background, mudColor);
        StateChange();
    }

    private void OnAwayBackgroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Away, ComponentColor.Background, mudColor);
        StateChange();
    }

    private void OnHomeForegroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Home, ComponentColor.Foreground, mudColor);
        StateChange();
    }

    private void OnAwayForegroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Away, ComponentColor.Foreground, mudColor);
        StateChange();
    }

    private void ResetColors()
    {
        Game.ResetColors();
        StateChange();
    }

    private async Task CheckTeamWonAsync()
    {
        if (Game.Score.HomeWon is null)
            return;

        _teamThatWon = Game.Score.HomeWon == true ? Game.Home : Game.Away;

        await _teamWonDialog.ShowAsync();
    }
}