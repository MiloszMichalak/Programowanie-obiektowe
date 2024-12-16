namespace Preferences.classes;

public delegate void NotificationHandler(string message);

public class NotificationManager
{
    public NotificationHandler? Notify;
    private readonly Dictionary<string, User> _users = new();
    private readonly List<INotifier> _notifiers = new();

    public void AddUser(string name, Priorities priority)
    {
        if (!_users.ContainsKey(name))
        {
            _users[name] = new User { Name = name, Priority = priority };
            Console.WriteLine($"Dodano użytkownika: {name} z priorytetem {priority}.");
        }
        else
        {
            Console.WriteLine($"Użytkownik o nazwie {name} już istnieje.");
        }
    }

    public void RemoveUser(string name)
    {
        if (_users.Remove(name))
        {
            Console.WriteLine($"Usunieto uzytkownika {name}.");
        }
        else
        {
            Console.WriteLine($"Użytkownik o nazwie {name} nie istnieje.");
        }
    }

    public User GetUserByName(string name)
    {
        return _users.GetValueOrDefault(name);
    }

    public void ListUsers()
    {
        if (_users.Count == 0)
        {
            Console.WriteLine("Brak użytkowników.");
            return;
        }

        Console.WriteLine("Lista użytkowników:");
        int index = 1;
        foreach (var user in _users)
        {
            Console.WriteLine($"{index}. {user.Key} (priorytet: {user.Value.Priority})");
            index++;
        }
    }

    public void SendNotification(string message, Priorities priority)
    {
        if (_notifiers.Count == 0)
        {
            Console.WriteLine("Brak dostepnych metod powiadomien");
            return;
        }

        var filteredUsers = new List<User>(_users.Values).FindAll(user => user.Priority <= priority);

        if (filteredUsers.Count == 0)
        {
            Console.WriteLine($"Brak użytkownikow z priorytetem rownym lub wyzszym niz {priority}");
            return;
        }

        Console.WriteLine($"Wiadomosc \"{message}\"");
        foreach (var notifier in _notifiers)
        {
            notifier.Notify(message);
        }

        Console.WriteLine("Powiadomienie zotalo wyslane do: ");
        foreach (var user in filteredUsers)
        {
            Console.WriteLine($"- {user.Name} (priorytet: {user.Priority})");
        }
    }

    public void AddNotifier(INotifier notifier)
    {
        if (!_notifiers.Contains(notifier))
        {
            _notifiers.Add(notifier);
            Console.WriteLine("Metoda powiadomienia zostala dodana");
        }
        else
        {
            Console.WriteLine("Ta metoda powiadomienia juz istnieje");
        }
    }
    
    public void RemoveNotifier(INotifier notifier)
    {
        Console.WriteLine(_notifiers.Remove(notifier)
            ? "Metoda powiadomienia zostala usunieta"
            : "Nie znaleziono tej metody powiadomienia");
    }

    public void ListNotifiers()
    {
        if (_notifiers.Count == 0)
        {
            Console.WriteLine("Brak dostepnych metod powiadomien");
            return;
        }

        Console.WriteLine("Dostepne metody powiadomien: ");
        foreach (var notifier in _notifiers)
        {
            Console.WriteLine(notifier.GetType().Name);
        }
    }
}