using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public class TeamBase(string name, bool isHome)
{
    private const string DefaultHomeName = "Home";
    private const string DefaultAwayName = "Away";

    public string Name { get; private set; } = name;
    public bool IsHome { get; } = isHome;
    public bool IsServing { get; set; }
    public int Timeouts { get; private set; }

    public ColorPair Colors { get;} = new();

    public void ChangeName(string newValue) 
        => Name = newValue;

    public void ResetName()
        => Name = IsHome ? DefaultHomeName : DefaultAwayName;

    public void ChangeColor(ComponentColor component, MudColor mudColor)
        => Colors.ChangeColor(component, mudColor);

    public void ResetColors()
        => Colors.ResetColors();

    public void ResetTimeouts()
        => Timeouts = 0;

    public void TimeoutsClicked()
    {
        Timeouts++;
        if (Timeouts > 2)
            Timeouts = 0;
    }
}