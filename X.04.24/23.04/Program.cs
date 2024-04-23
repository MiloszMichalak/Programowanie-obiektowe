using _23._04.classes;

namespace _23._04;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("Lamborghini", "Urus", 250, FuelType.Diesel);
        Console.WriteLine(vehicle.Brand);
        Console.WriteLine($"Pojazd {vehicle.Brand} {vehicle.Model} {vehicle.StartEngine()}");
        Console.WriteLine($"Pojazd {vehicle.Brand} {vehicle.Model} {vehicle.StopEngine()}");
        Console.WriteLine();
        Console.WriteLine(vehicle.GetInfo());

        Console.WriteLine();
        
        Car car1 = new Car("Fiat", "Tipo" , 140, 1.6, "I4", FuelType.Diesel, 5, false);
        Console.WriteLine(car1.Brand);
        Console.WriteLine($"Pojazd {car1.Brand} {vehicle.Model} {car1.StartEngine()}");
        Console.WriteLine($"Pojazd {car1.Brand} {vehicle.Model} {car1.StopEngine()}");
        Console.WriteLine();
        Console.WriteLine(car1.GetInfo());
        
        car1.ChangeGear(5);

        Car car2 = new Car("Toyota", "Supra", 200, 2.5, "V6", FuelType.Petrol, 6, true);
        Console.WriteLine(car2.GetInfo());
        Console.WriteLine();
        car1.ChangeGear(4);

    }
}
