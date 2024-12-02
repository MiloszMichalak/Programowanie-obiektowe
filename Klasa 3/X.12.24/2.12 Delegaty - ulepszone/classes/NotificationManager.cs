namespace _2._12_Delegaty.classes;

public delegate void NotificationHandler(string message);

public class NotificationManager
{
    private NotificationHandler Notify;

    public void AddNotificationMethod(NotificationHandler handler)
    {
        Notify += handler;
    }

    public void RemoveNotificationMethod(NotificationHandler handler)
    {
        Notify -= handler;
    }

    public void SendNotification(string message)
    {
        if (Notify == null)
        {
            Console.WriteLine("Brak dostepnych metod powiadomien");
        }

        Notify?.Invoke(message);
    }
}