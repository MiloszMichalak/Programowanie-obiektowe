using _30._04.classes;

namespace _30._04;

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
        
        Car car1 = new Car("Fiat", "Tipo" , 140, FuelType.Diesel, 5, false);
        Console.WriteLine(car1.Brand);
        Console.WriteLine($"Pojazd {car1.Brand} {vehicle.Model} {car1.StartEngine()}");
        Console.WriteLine($"Pojazd {car1.Brand} {vehicle.Model} {car1.StopEngine()}");
        Console.WriteLine();
        car1.Refuel(5);
        car1.ChangeGear(5);
        Console.WriteLine(car1.GetInfo());

        Console.WriteLine();

        Car car2 = new Car("Toyota", "Supra", 200, FuelType.Petrol, 6, true);
        Console.WriteLine(car2.GetInfo());
        Console.WriteLine();
        car1.ChangeGear(4);

        ElectricCar electricCar = new ElectricCar("Tesla", "S", 250, FuelType.Electric, 7, true, 80);
        electricCar.StartEngine();
        electricCar.ChargeBattery(10);
        Console.WriteLine(electricCar.GetInfo());

        Truck iveco = new Truck("Iveco", "Strails", 90, FuelType.Petrol, 1500);
        iveco.LoadCargo(4000);
        iveco.StartEngine();
        iveco.UpdateSpeed(80);
        iveco.StopEngine();


    }
}

