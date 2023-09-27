using System.Security;
using Microsoft.VisualBasic;

public class Team {
    private string _name; 
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;
    
    public Team(string name);
    {
        _name = name; 
    }
    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }
    public void AddWin()
    {
        _wins++; 
    }
    public void AddLosses()
    {
        _losses++; 
    }
    public void DisplayRoster();
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"Wins: {_winds} Losses: {_losses}");
        Console.WriteLine("------------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();
    }
}