using Microsoft.AspNetCore.Components;
using MudBlazor.Utilities;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Models;
using SportsScoreBoard.Models.Handball;

namespace SportsScoreBoard.Components.Pages.Sports.HandballComponents;

public partial class Handball : ComponentBase
{
    private HandballScoreboard _handballScoreboard;
    private HandballSettings _handballSettings;
    private static HandballGame Game { get; } = new();

    protected override void OnInitialized()
        => MainLayout.SubpageTitle = "Handball";

    private async Task ResetGameClicked()
    {
        Game.ResetGame();
        _handballScoreboard.ResetTimer();
        await _handballSettings.ResetColors();
    }

    private static void ResetScoreClicked()
        => Game.ResetScore();

    private static void ResetTimeoutsClicked()
        => Game.ResetTimeouts();

    private void ResetTimerClicked()
        => _handballScoreboard.ResetTimer();

    private static void ToggleShowTimeouts()
        => Game.ToggleShowTimeouts();

    private static void ToggleShowTeamNames()
        => Game.ToggleShowTeamNames();

    private static void ToggleManualScoring()
        => Game.ToggleManualScoring();

    private static void ToggleShowTimer()
        => Game.ToggleShowTimer();

    public static void ChangeHomeName(string newValue)
        => Game.ChangeHomeName(newValue);

    public static void ChangeAwayName(string newValue)
        => Game.ChangeAwayName(newValue);

    public static void IncrementHome()
        => Game.IncrementHome();

    public static void IncrementAway()
        => Game.IncrementAway();

    public static void DecrementHome()
        => Game.DecrementHome();

    public static void DecrementAway()
        => Game.DecrementAway();

    private void OnHomeBackgroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Home, ComponentColor.Background, mudColor);
        StateHasChanged();
    }

    private void OnAwayBackgroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Away, ComponentColor.Background, mudColor);
        StateHasChanged();
    }

    private void OnHomeForegroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Home, ComponentColor.Foreground, mudColor);
        StateHasChanged();
    }

    private void OnAwayForegroundChanged(MudColor mudColor)
    {
        Game.ChangeColor(Team.Away, ComponentColor.Foreground, mudColor);
        StateHasChanged();
    }

    private void ResetColors()
        => Game.ResetColors();
}