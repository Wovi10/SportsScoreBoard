﻿using Microsoft.AspNetCore.Components;
using SportsScoreBoard.Models.Volleyball;

namespace SportsScoreBoard.Components.Pages.Sports.Volleyball.ScoreComponents.ScoreCard;

public partial class SetsPart : ComponentBase
{
    [Parameter] public required int SetsWon { get; set; }
    [Parameter] public required bool IsHome { get; set; }
}