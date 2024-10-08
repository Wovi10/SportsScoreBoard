using MudBlazor.Utilities;

namespace SportsScoreBoard.Models;

public class ColorPair
{
    public MudColor? Background { get; private set; }
    public MudColor? Foreground { get; private set; }

    public void ChangeBackgroundColor(MudColor mudColor)
        => Background = mudColor;

    public void ChangeForegroundColor(MudColor mudColor)
        => Foreground = mudColor;

    public void ResetColors()
    {
        Background = null;
        Foreground = null;
    }
}