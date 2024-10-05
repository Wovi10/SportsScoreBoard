using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents.ScoreCard;

public partial class TimeoutPart : ComponentBase
{
    [Parameter] public required VolleyballTeam Team { get; set; }
    [Parameter] public required bool ShowTimeouts { get; set; }
    [Parameter] public required Action TimeoutsClicked { get; set; }

    private int _timeoutCount = 0;

    private void OnTimeoutsClicked() 
        => TimeoutsClicked();
}