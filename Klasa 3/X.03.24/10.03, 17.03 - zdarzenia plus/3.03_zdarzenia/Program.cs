namespace _3._03_zdarzenia;

class Program
{
    public delegate void FileOperation(string filePath);
    
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
                if (rbacSystem.HasPermission(user, Permission.Read))
                {
                    Console.WriteLine("1. Odczytaj pliku");
                }
                if (rbacSystem.HasPermission(user, Permission.Write))
                {
                    Console.WriteLine("2. Zapisz plik");
                }
                if (rbacSystem.HasPermission(user, Permission.Delete))
                {
                    Console.WriteLine("3. Modyfikuj plik");
                }
                if (rbacSystem.HasPermission(user, Permission.ManageUsers))
                {
                    Console.WriteLine("4. Dodaj nowego uzytkownika");
                }

                Console.WriteLine("5. Wyloguj sie");
                Console.WriteLine("6. Wyjdz z programu");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Niepoprawny wybor.");
                    Console.WriteLine("Wcisnij dowolny klawisz aby kontynuowac.");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        FileManager.ReadFile(filePath); break;
                    case 2:
                        if (rbacSystem.HasPermission(user, Permission.Write))
                        {
                            FileManager.WriteToFile(filePath);
                        }
                        else
                        {
                            Console.WriteLine("Nie masz uprawnien");
                        }
                        break;
                    case 3:
                        if (rbacSystem.HasPermission(user, Permission.Delete))
                        {
                            FileManager.ModifyFile(filePath);
                        }
                        else
                        {
                            Console.WriteLine("Nie masz uprawnien");
                        }
                        break;
                    case 4:
                        if (rbacSystem.HasPermission(user, Permission.ManageUsers))
                        {
                            FileManager.AddNewUser();
                        }
                        else
                        {
                            Console.WriteLine("Nie masz uprawnien");
                        }
                        break;
                    case 5:
                        Console.WriteLine("wylogowano");
                        logout = true;
                        break;
                    case 6:
                        Console.WriteLine("Zamykanie programu");
                        exitProgram = true;
                        return;
                    default:
                        Console.WriteLine("Niepoprawny wybor.");
                        break;
                }

                Console.WriteLine("Nacisnij dowolny klawisz aby kontynuowac");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Dziekujemy za skorzystanie z programu.");
    }
}