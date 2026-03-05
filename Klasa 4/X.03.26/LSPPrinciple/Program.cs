// Naruszenie LSP polega na tym że klasa Bicycle nie może być używana w miejscu, gdzie oczekiwany jest obiekt klasy Vehicle 
// Metoda StartEngine w klasie Bicycle rzuca wyjąte co jest sprzeczne z oczekiwanym zachowaniem klasy bazowej Vehicle
// Jeśli w programie użyjemy obiektu Bicycle tam gdzie oczekiwany jest Vehicle może to prowadzić do błędów w czasie wykonywania.

interface IVehicle
{
    void Move();
}

interface IEngineVehicle : IVehicle
{
    void StartEngine();
}

class EngineVehicle : IEngineVehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Silnik uruchomiony");
    }

    public virtual void Move()
    {
        Console.WriteLine("Pojazd się porusza");
    }
}

class Bicycle : IVehicle
{
    public void Move()
    {
        Console.WriteLine("Rower się porusza");
    }
}

class Car : EngineVehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Silnik samochodu uruchomiony");
    }

    public override void Move()
    {
        Console.WriteLine("Samochód się porusza");
    }
}

// 4 Aby unikać łamania LSP należy projektować hierarchie tak aby klasy pochodne mogły być używane w miejscu
// klas bazowych bez zmiany oczekiwanego zachowania programu