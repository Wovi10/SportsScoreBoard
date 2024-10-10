using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents.AwayComponents;

public partial class AwayScorePart : ComponentBase
{
    [Parameter] public required VolleyballSettings GameSettings { get; set; }
    [Parameter] public required VolleyballTeam Team { get; set; }
    [Parameter] public required int Score { get; set; }
    [Parameter] public required int Sets { get; set; }
    [Parameter] public required EventCallback IncrementScore { get; set; }
    [Parameter] public required EventCallback DecrementScore { get; set; }
    [Parameter] public required EventCallback<string> ChangeTeamName { get; set; }
}