using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SportsScoreBoard.Models;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballSettings
{
    [Parameter] public required Action ResetScore { get; set; }
    [Parameter] public required VolleyballGame Game { get; set; }

    private static int _bestOf = 3;
    private static int FirstTo => (_bestOf / 2) + 1;
    public bool Expanded { get; set; } = true;

    private void ToggleExpand()
    {
        Expanded = !Expanded;
    }

    private void OnResetScoresClick(MouseEventArgs obj)
    {
        ResetScore();
    }

    private void OnShowTimerClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowTimeoutsClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowTeamNamesClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowSetsClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnSHowServeClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    private void OnShowPreviousSetsClick(MouseEventArgs obj)
    {
        throw new NotImplementedException();
    }

    public void RefreshMe()
    {
        StateHasChanged();
    }
}