namespace Preferences.classes;

public class PushNotifier: INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Powiadomieie push wysłane: {message}");
    }
}