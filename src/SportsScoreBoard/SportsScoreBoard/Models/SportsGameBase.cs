using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public abstract class SportsGameBase
{
    public virtual TeamBase Home { get; }
    public virtual TeamBase Away { get; }
    protected bool GameHasFinished { get; set; }

    public abstract void ResetScore();

    public void ChangeColor(Team team, ComponentColor background, MudColor mudColor)
    {
        switch (team)
        {
            case Team.Home:
                Home.ChangeColor(background, mudColor);
                break;
            case Team.Away:
                Away.ChangeColor(background, mudColor);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(team), team, null);
        }
    }

    public void ResetColors()
    {
        Home.ResetColors();
        Away.ResetColors();
    }
}