namespace ZadanieSingleton;

class Program
{
    static void Main(string[] args)
    {
        var gameSession = GameSession.Instance;
        
        gameSession.Uptime = 5;
        gameSession.KilledMobs = 67;
        
        Console.WriteLine(gameSession.Uptime);
        Console.WriteLine(gameSession.KilledMobs);
    }
}