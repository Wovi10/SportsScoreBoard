﻿using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents.ScoreCard;

public partial class SetsPart : ComponentBase
{
    [Parameter] public required int Sets { get; set; }
    [Parameter] public required VolleyballTeam Team { get; set; }
    [Parameter] public required bool ShowTimeouts { get; set; }
    
    private void OnTimeoutsClicked() 
        => Team.TimeoutsClicked();
}