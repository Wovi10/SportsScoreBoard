using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public abstract class TeamBase(string name, bool isHome)
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";

    public string Name { get; private set; } = name;
    public bool IsHome { get; } = isHome;

    public ColorPair Colors { get;} = new();

    public void ChangeName(string newValue) 
        => Name = newValue;

    public void ResetName()
        => Name = IsHome ? DefaultHomeName : DefaultAwayName;

    public void ChangeColor(ComponentColor component, MudColor mudColor)
        => Colors.ChangeColor(component, mudColor);

    public void ResetColors()
        => Colors.ResetColors();
}