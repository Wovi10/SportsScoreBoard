using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SportsScoreBoard.Models;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballSettingsComponent
{
    [Parameter] public required Action ResetGame { get; set; }
    [Parameter] public required Action ResetScore { get; set; }
    [Parameter] public required Action ResetSets { get; set; }
    [Parameter] public required Action ResetTimeouts { get; set; }
    [Parameter] public required Action ToggleShowServing { get; set; }
    [Parameter] public required Action ToggleShowSets { get; set; }
    [Parameter] public required Action ToggleShowTimeouts { get; set; }
    [Parameter] public required VolleyballGame Game { get; set; }

    private static int _bestOf = 5;
    private static int FirstTo => _bestOf / 2 + 1;
    private bool Expanded { get; set; } = true;

    private void ToggleExpand()
    {
        Expanded = !Expanded;
    }

    private void OnGameResetClick(MouseEventArgs obj) 
        => ResetGame();

    private void OnResetScoresClick(MouseEventArgs obj) 
        => ResetScore();
    
    private void OnResetSetsClick(MouseEventArgs obj) 
        => ResetSets();

    private void OnResetTimeoutsClick(MouseEventArgs obj) 
        => ResetTimeouts();

    private void OnShowTimerClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowTimeoutsClick(MouseEventArgs obj) 
        => ToggleShowTimeouts();

    private void OnShowTeamNamesClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowSetsClick(MouseEventArgs obj)
    {
        ToggleShowSets();
    }

    private void OnShowServeClick(MouseEventArgs obj)
    {
        ToggleShowServing();
    }

    private void OnShowPreviousSetsClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }
    
    private void OnBestOfValueChanged(int newBestOf)
    {
        Game.BestOfChanged(newBestOf);
        _bestOf = newBestOf;
    }

    public void RefreshMe()
    {
        StateHasChanged();
    }
}