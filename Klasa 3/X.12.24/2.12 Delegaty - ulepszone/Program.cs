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

        while (true)
        {
            ShowMenu();
            byte choice = GetByteFromUser();
            switch (choice)
            {
                case 1:
                    notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
                    Console.WriteLine("Dodano powiadomienie email");
                    break;
                case 2:
                    notificationManager.AddNotificationMethod(smsNotifier.SendSMS);
                    Console.WriteLine("Dodano powiadomienie sms");
                    break;
                case 3:
                    notificationManager.AddNotificationMethod(pushNotifier.SendPushNotification);
                    Console.WriteLine("Dodano powiadomienie push");
                    break;
                case 4:
                    notificationManager.RemoveNotificationMethod(emailNotifier.SendEmail);
                    Console.WriteLine("Usunieto powiadomienie email");
                    break;
                case 5:
                    notificationManager.RemoveNotificationMethod(smsNotifier.SendSMS);
                    Console.WriteLine("Usunieto powiadomienie sms");
                    break;
                case 6:
                    notificationManager.RemoveNotificationMethod(pushNotifier.SendPushNotification);
                    Console.WriteLine("Usunieto powiadomienie push");
                    break;
                case 7:
                    Console.Write("Podaj wiadomosc do wyslania: ");
                    string message = Console.ReadLine()!;
                    
                    notificationManager.SendNotification(message);
                    break;
                case 8:
                    return;
            }
        }
    }

    public static byte GetByteFromUser()
    {
        byte number;
        while (!byte.TryParse(Console.ReadLine(), out number) || number > 8)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj liczba, pomiedzy 1 a 8");
            Console.ResetColor();
        }

        return number;
    }

    public static void ShowMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Dodaj powiadomienie email");
        Console.WriteLine("2. Dodaj powiadomienie sms");
        Console.WriteLine("3. Dodaj powiadomienie push");
        Console.WriteLine("4. Usun powiadomienie email");
        Console.WriteLine("5. Usun powiadomienie sms");
        Console.WriteLine("6. Usun powiadomienie push");
        Console.WriteLine("7. Wyslij powiadomienie");
        Console.WriteLine("8. Wyjscie");
        Console.WriteLine("Wybierz opcje:");
    }
}