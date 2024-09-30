namespace SportsScoreBoard.Models.Volleyball;

public class VolleyballScore:ScoreBase
{
    private int GameDifference => Math.Abs(Home - Away);
    
    public bool IsGameOver(bool isDecidingGame)
    {
        if (GameDifference < 2)
            return false;

        var numberToWin = isDecidingGame ? 15 : 25;

        return Home >= numberToWin || Away >= numberToWin;
    }
}