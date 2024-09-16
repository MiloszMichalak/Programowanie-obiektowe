using gr_2_Michalak_Milosz.classes;

namespace gr_2_Michalak_Milosz;

class Program
{
    
    static void Main(string[] args)
    {
        string brand;
        string model;
        int batteryLife;
        bool has5G;

        brand = GetStringFromUserInput("Podaj marke: ");
        model = GetStringFromUserInput("Podaj model: ");
        batteryLife = GetIntFromUserInput("Podaj ilosc baterii: ");
        
        Laptop laptop = new Laptop(brand, model, batteryLife);
        laptop.DisplayInfo();
        
        Console.WriteLine();
        
        brand = GetStringFromUserInput("Podaj marke: ");
        model = GetStringFromUserInput("Podaj model: ");
        has5G = GetBoolFromUserInput("Podaj czy ma 5G(true/false): ");
        
        Smartphone smartphone = new Smartphone(brand, model, has5G);
        smartphone.DisplayInfo();
    }

    public static string GetStringFromUserInput(String message)
    {
        string input = null;
        while (string.IsNullOrEmpty(input))
        {
            Console.Write(message);
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) {break;}
            Console.WriteLine("Puste wejscie, sprobuj ponownie");
        }
        return input;
    }

    public static int GetIntFromUserInput(string message)
    {
        int result = 0;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Nieprawidlowa liczba, sprobuj ponownie");
            Console.Write(message);
        }

        return result;
    }
    
    public static bool GetBoolFromUserInput(string message)
    {
        bool result;
        Console.Write(message);
        while (!bool.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Nieprawidlowa zmienna, sprobuj ponownie");
            Console.Write(message);
        }

        return result;
    }
}