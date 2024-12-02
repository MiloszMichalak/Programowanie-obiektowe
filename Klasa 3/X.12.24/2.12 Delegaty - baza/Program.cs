using _2._12_Delegaty.classes;

namespace _2._12_Delegaty;

public class Program
{
    static void Main(string[] args)
    {
        var emailNotifier = new EmailNotifier();
        var smsNotifier = new SMSNotifier();
        var pushNotifier = new PushNotifier();
        
        var notificationManager = new NotificationManager();
        
        notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
        notificationManager.AddNotificationMethod(smsNotifier.SendSMS);
        notificationManager.AddNotificationMethod(pushNotifier.SendPushNotification);
        
        notificationManager.SendNotification("Pierwsza wiadomosc");
        Console.WriteLine();
        
        notificationManager.RemoveNotificationMethod(pushNotifier.SendPushNotification);
        notificationManager.SendNotification("Druga wiadomosc");
        
    }
}