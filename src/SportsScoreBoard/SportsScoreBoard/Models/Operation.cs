namespace SportsScoreBoard.Models;

public class Operation(Action action, string name)
{
    public Action Action = action;
    public string Name = name;
    
    public void Execute()
    {
        Action();
    }
}