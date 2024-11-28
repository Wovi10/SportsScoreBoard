using MudBlazor;

namespace SportsScoreBoard.Models.StaticValues;

public static class StaticValues
{
    internal static readonly SportInfo[] AllSports =
        {
            new("Volleyball", Icons.Material.Filled.SportsVolleyball, "/volleyball"),
            new("Handball", Icons.Material.Filled.SportsHandball, "/handball"),
            new("Basketball", Icons.Material.Filled.SportsBasketball, "/basketball")
        };

    internal record SportInfo(string Sport, string Icon, string Route);
}