using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Models.Handball;

namespace SportsScoreBoard.Components.Pages.Sports.HandballComponents;

public partial class Handball : ComponentBase
{
    private HandballScoreboard _handballScoreboard;
    private HandballSettings _handballSettings;
    private static HandballGame Game { get; } = new();

    protected override void OnInitialized()
        => MainLayout.SubpageTitle = "Handball";

    private void ResetGameClicked()
    {
        Game.ResetGame();
        _handballScoreboard.ResetTimer();
    }

    private void ResetScoreClicked()
        => Game.ResetScore();

    private void ResetTimeoutsClicked()
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
}