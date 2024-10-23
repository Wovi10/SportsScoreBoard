using MudBlazor;
using SportsScoreBoard.Models;

namespace SportsScoreBoard.Components.Layout;

public partial class MainLayout
{
    private bool _drawerOpen;
    private bool _isDarkMode;
    private readonly MudTheme _theme = MyMudThemeProvider.MyCustomTheme;
    private MudThemeProvider _mudThemeProvider;
    public static string SubpageTitle { get; set; } = string.Empty;
    
    private void ToggleDrawer()
        => _drawerOpen = !_drawerOpen;
}