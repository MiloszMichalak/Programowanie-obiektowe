namespace ZadanieSingleton;

public class GameSession
{
    private static GameSession _instance;
    public static GameSession Instance => _instance ??= new GameSession();
    public long Uptime { get; set; }
    public uint KilledMobs { get; set; }
}