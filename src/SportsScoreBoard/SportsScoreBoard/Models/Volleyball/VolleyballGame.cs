namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballGame : SportsGameBase
{
    public new VolleyballTeam Home { get; set; } = new("Home", true);
    public new VolleyballTeam Away { get; set; } = new("Away", false);
    public new VolleyballScore Score { get; set; } = new();

    public void IncrementHome()
    {
        Score.IncrementHome();
        SetHomeServing();
    }

    public void IncrementAway()
    {
        Score.IncrementAway();
        SetAwayServing();
    }

    public void ChangeHomeName(string newValue) 
        => Home.ChangeName(newValue);
    
    public void ChangeAwayName(string newValue)
        => Away.ChangeName(newValue);

    public override void ResetScore() => Score.Reset();
    
    private void SetHomeServing()
    {
        Home.IsServing = true;
        Away.IsServing = false;
    }
    
    private void SetAwayServing()
    {
        Home.IsServing = false;
        Away.IsServing = true;
    }
}