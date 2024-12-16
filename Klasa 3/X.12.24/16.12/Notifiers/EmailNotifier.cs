namespace Preferences.classes;

public class EmailNotifier: INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email wysłany: {message}");
    }
}