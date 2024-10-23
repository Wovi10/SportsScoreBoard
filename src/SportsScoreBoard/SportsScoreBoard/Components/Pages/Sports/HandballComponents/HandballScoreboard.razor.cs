using Microsoft.AspNetCore.Components;
using Timer = SportsScoreBoard.Components.Shared.Timer;

namespace SportsScoreBoard.Components.Pages.Sports.HandballComponents;

public partial class HandballScoreboard
{
    private Timer _handballTimer;

    public void ResetTimer()
        => _handballTimer.ResetTimer();
}