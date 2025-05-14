namespace _3._03_zdarzenia;

class Program
{
    static void Main(string[] args)
    {
        PasswordManager.PasswordVerified += (username, success) => 
            Console.WriteLine($"Logownie uzytkownika o nazwie {username}: {(success ? "udane" : "nieudane")}");
        
        PasswordManager.SavePassword("admin", "admin");
        PasswordManager.SavePassword("manager", "pass");
        PasswordManager.SavePassword("normalUser", "pass");
        PasswordManager.SavePassword("xyz", "pass");
        
        Console.WriteLine("Wprowadz nazwe uzytkownika: ");
        string username = Console.ReadLine();

        Console.WriteLine("\nWprowadz haslo: ");
        string password = Console.ReadLine();
        Console.WriteLine();

        if (!PasswordManager.VerifyPassword(username, password))
        {
            Console.WriteLine("Niepoprawna nazwa uzytkownika lub haslo.");
            return;
        }
        
        var user = new User(username);
        switch (username)
        {
            case "admin":
                user.AddRole(Role.Admin);
                break;
            case "manager":
                user.AddRole(Role.Manager);
                break;
            case "normalUser":
                user.AddRole(Role.User);
                break;
        }

        var rbacSystem = new RBAC();
        Console.WriteLine("\n Sprawdzanie dostepu do rożnych zasobów:");

        Console.WriteLine("Read: " + rbacSystem.HasPermission(user,"read"));
        Console.WriteLine("Write: " + rbacSystem.HasPermission(user,"write"));
        Console.WriteLine("Delete: " + rbacSystem.HasPermission(user,"delete"));
    }
}