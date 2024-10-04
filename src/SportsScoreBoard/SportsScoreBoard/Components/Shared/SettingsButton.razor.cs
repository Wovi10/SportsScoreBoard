using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace SportsScoreBoard.Components.Shared;

public partial class SettingsButton : ComponentBase
{
    [Parameter] public string Text { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public required Action<MouseEventArgs> OnClick { get; set; }
    
    private void HandleClick(MouseEventArgs e) 
        => OnClick.Invoke(e);
}