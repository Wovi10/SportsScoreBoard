using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Components.Layout;
using SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball;

public partial class VolleyballComponent : ComponentBase
{
    public static VolleyballGame Game { get; set; } = new();

    protected VolleyballSettings _volleyballSettingsComponent;
    protected VolleyballScoreboard _volleyballScoreboardSettings;

    protected override void OnInitialized()
    {
        MainLayout.SubpageTitle = "Volleyball";
        Game.Home.IsServing = true;
    }

    public void ResetScore()
    {
        Game.ResetScore();
        StateChange();
    }

    public void IncrementHome()
    {
        Game.IncrementHome();
        StateChange();
    }

    public void IncrementAway()
    {
        Game.IncrementAway();
        StateChange();
    }
    
    public void ChangeHomeName(string name)
    {
        Game.ChangeHomeName(name);
        StateChange();
    }
    
    public void ChangeAwayName(string name)
    {
        Game.ChangeAwayName(name);
        StateChange();
    }

    private void StateChange()
    {
        StateHasChanged();
        _volleyballScoreboardSettings.RefreshMe();
        _volleyballSettingsComponent.RefreshMe();
    }
}