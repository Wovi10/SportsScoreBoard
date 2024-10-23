using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Handball;

namespace SportsScoreBoard.Components.Pages.Sports.HandballComponents;

public partial class HandballSettingsComponent : ComponentBase
{
    [Parameter] public required EventCallback ResetTimerClicked { get; set; }
    [Parameter] public required HandballGame Game { get; set; }
}