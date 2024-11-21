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

    private void ResetTimerClicked()
        => _handballScoreboard.ResetTimer();

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