using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents;

public partial class TeamScorePart : ComponentBase
{
    [Parameter] public required VolleyballSettings GameSettings { get; set; }
    [Parameter] public required VolleyballTeam Team { get; set; }
    [Parameter] public required int Score { get; set; }
    [Parameter] public required Action IncrementScore { get; set; }
    [Parameter] public required Action<string> ChangeTeamName { get; set; }
    
    private void OnScoredClick()
        => IncrementScore.Invoke();
    
    public void OnTeamNameChange(string name) 
        => ChangeTeamName.Invoke(name);
}