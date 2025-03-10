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
        
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.Clear();
            Console.WriteLine("=== System logowania ===");
            
            Console.WriteLine("Wprowadz nazwe uzytkownika: ");
            string username = Console.ReadLine();

            Console.WriteLine("\nWprowadz haslo: ");
            string password = Console.ReadLine();
            
            if (!PasswordManager.VerifyPassword(username, password))
            {
                Console.WriteLine("Niepoprawna nazwa uzytkownika lub haslo.");
                Console.WriteLine("Wcisnij dowolny klawisz aby kontynuowac.");
                Console.ReadKey();
                continue;
            }
            
            var user = new User(username);
            if (username == "admin") user.AddRole(Role.Admin);
            else if (username == "manager") user.AddRole(Role.Manager);
            else if (username == "normalUser") user.AddRole(Role.User);

            var rbacSystem = new RBAC();
            var filePath = "testFile.txt";

            var logout = false;
            while (!logout)
            {
                Console.Clear();
                Console.WriteLine("Zalogowano jako uzytkownik {0}", username);
                Console.WriteLine("\n Wybierz opcje");
            }


        }
    }
}