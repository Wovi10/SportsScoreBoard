using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public abstract class TeamBase(string name, bool isHome)
{
    public string Name { get; private set; } = name;
    public bool IsHome { get; set; } = isHome;

    public ColorPair Colors { get;} = new();

    public void ChangeName(string newValue) 
        => Name = newValue;
}