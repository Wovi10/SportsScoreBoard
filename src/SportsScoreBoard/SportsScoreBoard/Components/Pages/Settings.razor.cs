using Microsoft.AspNetCore.Components;
using MudBlazor;
using SportsScoreBoard.Components.Layout;

namespace SportsScoreBoard.Components.Pages;

public partial class Settings : ComponentBase
{
    private DrawerClipMode _drawerClipMode = DrawerClipMode.Docked;
    private bool _appBarIsDense;
    private Breakpoint _navbarBreakpoint;

    private void OnDrawerClipModeChanged(DrawerClipMode newDrawerClipMode)
    {
        MainLayout.SetNavbarClipMode(newDrawerClipMode);
        _drawerClipMode = newDrawerClipMode;
    }

    private void OnDrawerBreakPointChanged(Breakpoint newBreakpoint)
    {
        MainLayout.SetNavbarBreakpoint(newBreakpoint);
        _navbarBreakpoint = newBreakpoint;
    }

    private void OnAppBarDensityChanged(bool newAppBarDensity)
    {
        MainLayout.SetAppBarDense(newAppBarDensity);
        _appBarIsDense = newAppBarDensity;
    }
}