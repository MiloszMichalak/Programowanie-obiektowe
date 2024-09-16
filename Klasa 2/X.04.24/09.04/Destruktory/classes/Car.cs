namespace _09._04___destruktory.classes;

public class Car
{
    private string Name;
    private double EngineCapacity;

    public Car(string name, double EngineCapacity)
    {
        Name = name;
        EngineCapacity = EngineCapacity;
    }

    ~Car()
    {
        Console.WriteLine($"Samochod {Name} zostal rozwalony");
    }

    public string StartRace()
    {
        return "Started a race";
    }
    
}