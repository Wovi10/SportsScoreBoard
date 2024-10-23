using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Models.Handball;

namespace SportsScoreBoard.Components.Pages.Sports.HandballComponents;

public partial class Handball : ComponentBase
{
    private HandballScoreboard _handballScoreboard;
    private HandballSettingsComponent _handballSettings;
    private static HandballGame Game { get; } = new();

    protected override void OnInitialized()
    {
        MainLayout.SubpageTitle = "Handball";
    }

    private void ResetTimerClicked()
        => _handballScoreboard.ResetTimer();
}