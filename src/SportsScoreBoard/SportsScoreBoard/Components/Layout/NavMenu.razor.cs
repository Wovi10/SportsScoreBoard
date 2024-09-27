using MudBlazor;

namespace SportsScoreBoard.Components.Layout;

public partial class NavMenu
{
    private bool _open = false;
    private Breakpoint _breakpoint = Breakpoint.Lg;

    private void ToggleDrawer()
    {
        _open = !_open;
    }
}