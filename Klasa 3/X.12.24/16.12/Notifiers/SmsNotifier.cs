namespace Preferences.classes;

public class SmsNotifier: INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sms wysłany: {message}");
    }
}