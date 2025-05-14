namespace _3._03_zdarzenia.Services;

public class FileManager
{
    public static void ReadFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            var content = File.ReadAllText(filePath);
            Console.WriteLine("Zawartosc pliku:\n {0}", content);
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }

    public static void WriteToFile(string filePath)
    {
        Console.WriteLine("Podaj tekst do zapisania w pliku: ");
        var text = Console.ReadLine();
        File.WriteAllText(filePath, text);
        Console.WriteLine("Zapisano do pliku");
    }

    public static void ModifyFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("Podaj tekst, ktory bedzie dopisany do pliku");
            var text = Console.ReadLine();
            File.AppendAllText(filePath, Environment.NewLine + text);
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }

    public static void AddNewUser()
    {
        Console.WriteLine("Podaj nazwe użytkownika: ");
        var username = Console.ReadLine();

        Console.WriteLine("Podaj haslo uzytkownika: ");
        var password = Console.ReadLine();
        
        PasswordManager.SavePassword(username, password);
        Console.WriteLine("Dodano nowego uzytkownika");
    }
}