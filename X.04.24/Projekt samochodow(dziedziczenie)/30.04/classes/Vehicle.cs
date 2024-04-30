namespace _30._04.classes;

public enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    private double Fuel{ get; set; }
    public FuelType FuelType { get; protected set; }
    public ushort Speed { get; set; }

    public Vehicle(string brand, string model, ushort speed, FuelType fuelType)
    {
        Brand = brand;
        Model = model;
        Speed = speed;
        FuelType = fuelType;
        Fuel = 5;
    }

    public void UpdateSpeed(ushort speed)
    {
        Speed = speed;
    }

    public virtual string GetInfo()
    {
        return $"Pojazd {Brand} {Model} \n" +
               $"Predkosc maksymalna: {Speed} \n" +
               $"Rodzaj paliwa: {FuelType}\n" +
               $"Paliwo w baku: {Fuel}";
    }

    public virtual string StartEngine()
    {
        return "Engine started";
    }

    public virtual string StopEngine()
    {
        return "Engine stopped";
    }

    public void Refuel(double amount)
    {
        Fuel += amount;
        Console.WriteLine($"Zatankowano {amount} litrow paliwa w pojezdzie ");
    }
}