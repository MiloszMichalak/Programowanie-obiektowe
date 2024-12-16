using Preferences.classes;

namespace Preferences;

class Program
{
    static void Main(string[] args)
    {
        string name;
        Priorities priority;
        INotifier notifier;
        
        var notificationManager = new NotificationManager();
        
        var emailNotifier = new EmailNotifier();
        var smsNotifier = new SmsNotifier();
        var pushNotifier = new PushNotifier();

        while (true)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Usuń użytkownika");
            Console.WriteLine("3. Wyślij powiadomienie do użytkownika");
            Console.WriteLine("4. Wyświetl użytkowników");
            Console.WriteLine("5. Dodaj metodę powiadomień");
            Console.WriteLine("6. Usuń metodę powiadomień");
            Console.WriteLine("7. Wyświetl metody powiadomien");
            Console.WriteLine("8. Wyjdż");

            Console.WriteLine("\nWybierz opcję: ");

            int choice = GetIntFromUser();

            switch (choice)
            {
                case 1:
                    name = GetStringFromUser("Podaj nazwę użytkownika: ");
                    priority = GetPriorityFromUser();   
                    notificationManager.AddUser(name, priority);
                    break;
                case 2:
                    notificationManager.ListUsers();
                    name = GetStringFromUser("Podaj nazwę użytkownika: ");
                    notificationManager.RemoveUser(name);
                    break;
                case 3:
                    name = GetStringFromUser("Podaj tresc wiadomosci: ");
                    priority = GetPriorityFromUser();
                    notificationManager.SendNotification(name, priority);
                    break;
                case 4:
                    notificationManager.ListUsers();
                    break;
                case 5:
                    NotifiersList();
                    notifier = GetNotifierFromUser();
                    notificationManager.AddNotifier(notifier);
                    break;
                case 6:
                    Console.WriteLine("Przypidane notifiery: ");
                    notificationManager.ListNotifiers();
                    Console.WriteLine("ogolna lista notifierow");
                    NotifiersList();
                    notifier = GetNotifierFromUser();
                    notificationManager.RemoveNotifier(notifier);
                    break;
                case 7:
                    notificationManager.ListNotifiers();
                    break;
                case 8:
                    return;
            }
        }
    }

    private static void NotifiersList()
    {
        Console.WriteLine("1. Email");
        Console.WriteLine("2. Sms");
        Console.WriteLine("3. Push");
    }

    private static INotifier GetNotifierFromUser()
    {
        byte result;
        Console.WriteLine("Podaj cyfre od 1 do 3: ");
        while (!byte.TryParse(Console.ReadLine(), out result) || result is > 3 or < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj cyfre od 1 do 3: ");
            Console.ResetColor();   
        }
        
        INotifier notifier = result switch
        {
            1 => new EmailNotifier(),
            2 => new SmsNotifier(),
            3 => new PushNotifier(),
        };
        
        return notifier;
    }

    private static Priorities GetPriorityFromUser()
    {
        byte result;
        Console.WriteLine("Podaj cyfre od 1 do 3: ");
        while (!byte.TryParse(Console.ReadLine(), out result) || result is > 3 or < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj cyfre od 1 do 3: ");
            Console.ResetColor();   
        }
        
        Priorities priority = result switch
        {
            1 => Priorities.Low,
            2 => Priorities.Medium,
            3 => Priorities.High,
        };
        
        return priority;
    }

    private static int GetIntFromUser()
    {
        byte result;
        Console.WriteLine("Podaj cyfre od 1 do 8: ");
        while (!byte.TryParse(Console.ReadLine(), out result) || result is > 8 or < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj cyfre od 1 do 8: ");
            Console.ResetColor();   
        }

        return result;
    }
    
    private static string GetStringFromUser(string message)
    {
        string result;
        Console.WriteLine(message);
        while (string.IsNullOrWhiteSpace(result = Console.ReadLine()))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();   
        }

        return result;
    }
}