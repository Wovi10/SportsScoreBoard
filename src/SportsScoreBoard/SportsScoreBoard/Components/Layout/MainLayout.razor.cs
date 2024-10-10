using MudBlazor;
using SportsScoreBoard.Models;

namespace SportsScoreBoard.Components.Layout;

public partial class MainLayout
{
    private static bool _drawerOpen = false;
    private static Breakpoint _navbarBreakpoint = Breakpoint.None;
    private static DrawerClipMode _navbarClipMode = DrawerClipMode.Docked;
    private static bool _appBarDense = false;
    private static bool _isDarkMode;
    private MudThemeProvider _mudThemeProvider;
    private readonly MudTheme _theme = MyMudThemeProvider.MyCustomTheme;
    public static string SubpageTitle { get; set; } = string.Empty;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // _isDarkMode = await _mudThemeProvider.GetSystemPreference();
            _isDarkMode = false;
            StateHasChanged();
        }
    }
    
    public static void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
    
    public static void SetAppBarDense(bool dense)
    {
        _appBarDense = dense;
    }
    
    public static void SetNavbarBreakpoint(Breakpoint breakpoint)
    {
        _navbarBreakpoint = breakpoint;
    }
    
    public static void SetNavbarClipMode(DrawerClipMode clipMode)
    {
        _navbarClipMode = clipMode;
    }
}