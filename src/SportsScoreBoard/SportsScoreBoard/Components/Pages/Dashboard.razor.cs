using MudBlazor;

namespace SportsScoreBoard.Components.Pages;

public partial class Dashboard
{
    private static readonly IDictionary<Models.Sports, string> AllSportsDictionary = new Dictionary<Models.Sports, string>
    {
        { Models.Sports.Volleyball, Icons.Material.Filled.SportsVolleyball }
    };
    private Task GoTo(Models.Sports volleyball)
    {
        NavManager.NavigateTo($"/{volleyball}");
        return Task.CompletedTask;
    }
}