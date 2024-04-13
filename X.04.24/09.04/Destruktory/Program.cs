using _09._04___destruktory.classes;

namespace _09._04___destruktory;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Ferrari", 4.8);
        Car car2 = new Car("Golf", 1.9);
        Car car3 = new Car("Ford", 1.2);

        Console.WriteLine(car1.StartRace());
        Console.WriteLine(car2.StartRace());
        Console.WriteLine(car3.StartRace());

        car3 = null;
        GC.Collect();

        Console.ReadKey();
    }
}
