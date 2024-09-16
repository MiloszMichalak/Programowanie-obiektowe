namespace _30._04.classes;

public class Truck : Vehicle
{
    public double LoadCapacity { get; set; }
    public Truck(string brand, string model, ushort speed, FuelType fuelType, double loadCapacity) : base(brand, model, speed, fuelType)
    {
        LoadCapacity = loadCapacity;
    }

    public void LoadCargo(double weight)
    {
        if (weight <= 0)
        {
            Console.WriteLine("Nie mozna zaladowac ujemnej wagi");
        } else if (weight >= LoadCapacity)
        {
            if (Brand.ToLower() == "iveco")
            {
                Console.WriteLine($"Na iveco mozna zaladowac wszystko. Przeladowales iveco o {weight - LoadCapacity} kg. Masz teraz na pace {weight} kg");
                return;
            }
            Console.WriteLine($"Nie mozna zaladowac ladunku o wadze {weight} kg, poniewaz przekracza maksymalna noscno pojazdu wynoszaca {LoadCapacity}");
        }
        else
        {
            Console.WriteLine($"Zaladowano ladunek o wadze {weight} kg");
        }
    }
}