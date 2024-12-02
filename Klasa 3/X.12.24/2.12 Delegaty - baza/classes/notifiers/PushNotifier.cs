namespace _2._12_Delegaty.classes;

public class PushNotifier
{
    public void SendPushNotification(string message)
    {
        Console.WriteLine($"Powiadomienie push wyslane: {message}");
    }
}