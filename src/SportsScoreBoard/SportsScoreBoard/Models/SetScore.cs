namespace SportsScoreBoard.Models;

public record SetScore(int Home, int Away)
{
    public override string ToString()
    {
        return $"{Home} - {Away}";
    }
}