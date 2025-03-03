namespace _3._03_zdarzenia;

class Program
{
    static void Main(string[] args)
    {
        PasswordManager.PasswordVerified += (username, success) => 
            Console.WriteLine($"Logownie uzytkownika o nazwie {username}: {(success ? "udane" : "nieudane")}");
        
        PasswordManager.SavePassword("admin", "admin");
        Console.WriteLine("Wprowadz nazwe uzytkownika: ");
    }
}