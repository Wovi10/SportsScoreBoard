namespace SportsScoreBoard.Models.Volleyball;

public record SetScore(int Home, int Away)
{
    public override string ToString()
    {
        return $"{Home} - {Away}";
    }
}