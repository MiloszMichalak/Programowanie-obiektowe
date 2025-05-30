using System.Security.Cryptography;
using System.Text;

namespace _3._03_zdarzenia;

public class PasswordManager
{
    private const string _passwordFilePath = "userPasswords.txt";
    public static event Action<string, bool> PasswordVerified;

    static PasswordManager()
    {
        if (!File.Exists(_passwordFilePath))
        {
            File.Create(_passwordFilePath).Dispose();
        }
    }
    
    public static void SavePassword(string username, string password)
    {
        if (File.ReadLines(_passwordFilePath).Any(line => line.Split(",")[0].Equals(username)))
        {
            Console.WriteLine($"Uzytkownik o nazwie {username} juz istnieje w systemie.");
            return;
        }

        string hashedPassword = HashPassword(password);
        File.AppendAllText(_passwordFilePath, $"{username},{hashedPassword}");
        Console.WriteLine($"Uzytkownik {username} zostal zapisany.");
    }

    private static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    public static bool VerifyPassword(string username, string password)
    {
        string hashedPassword = HashPassword(password);
        foreach (var line in File.ReadLines(_passwordFilePath))
        {
            var parts = line.Split(",");
			if (parts[0].Equals(username) && parts[1].Equals(hashedPassword))
            {
                PasswordVerified?.Invoke(username, true);
                return true;
            }
        }

        PasswordVerified?.Invoke(username, false);
        return false;
    }
}