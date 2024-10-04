using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents.ScoreCard;

public partial class ScorePart : ComponentBase
{
    [Parameter] public required Action IncrementScore { get; set; }
    [Parameter] public required VolleyballTeam Team { get; set; }
    [Parameter] public required VolleyballSettings GameSettings { get; set; }
    [Parameter] public required int Score { get; set; }
    
    private void OnScoredClick()
        => IncrementScore.Invoke();
}