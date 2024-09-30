using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballScoreboard
{
    [Parameter] public required VolleyballGame Game { get; set; }
    [Parameter] public required Action IncrementHome { get; set; }
    [Parameter] public required Action IncrementAway { get; set; }
    [Parameter] public required Action<string> HomeNameChanged { get; set; }
    [Parameter] public required Action<string> AwayNameChanged { get; set; }

    private void OnHomeScoredClick()
        => IncrementHome.Invoke();

    private void OnAwayScoredClick()
        => IncrementAway.Invoke();
    
    private void OnHomeNameChanged(string newValue)
        => HomeNameChanged.Invoke(newValue);
    
    private void OnAwayNameChanged(string newValue)
        => AwayNameChanged.Invoke(newValue);

    public void RefreshMe()
        => StateHasChanged();
}