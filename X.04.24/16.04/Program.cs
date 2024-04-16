using _15._04.classes;

namespace _15._04;

// symulator samochodu - wersja poprawiona - lepsza
class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

        while (true)
        {
            DisplayMenu();
            int choice = GetUserInput();

            switch (choice)
            {
                case 1:
                    AddCar(cars, carDictionary);
                    
                    break;
                case 2:
                    DisplayCars(carDictionary);

                    break;
                case 3:
                    DisplayCars(carDictionary);
                    DriveCar(carDictionary);
                    
                    break;
                case 4:
                    DisplayCars(carDictionary);
                    SimulateDamage(carDictionary);
                    
                    break;
                case 5:
                    DisplayCars(carDictionary);
                    if (carDictionary.Count != 0)
                    {
                        ScrapCar(cars, carDictionary);
                    }
                    
                    break;
                case 6:
                    Console.WriteLine("Zamykanie symulatora");
                    return;
                default:
                    break;
                    
            }

            Console.WriteLine("\nNacisnij dowolny klawisz, aby wrocic do menu");
            Console.ReadKey();
        }
    }

    private static void ScrapCar(List<Car> cars, Dictionary<int, Car> carDictionary)
    {
        int carNumber = GetUserInput();
        Console.WriteLine($"\n Samochod {carDictionary[carNumber].Brand} {carDictionary[carNumber].Model} zostal zezlomowany");
        cars.RemoveAt(carNumber);
        carDictionary.Remove(carNumber);
    }

    private static void SimulateDamage(Dictionary<int, Car> carDictionary)
    {
        int carNumber = GetUserInput();
        Car carToDamage = carDictionary[carNumber];
        carToDamage.SimulatedRandomDamage();
    }

    private static void DriveCar(Dictionary<int, Car> carDictionary)
    {
        int carNumber = GetUserInput(carDictionary);
        Car carToDrive = carDictionary[carNumber];
        Console.WriteLine(carToDrive.Drive());
    }

    private static void DisplayCars(Dictionary<int, Car> carDictionary)
    {
        if (carDictionary.Count == 0)
        {
            Console.WriteLine("Brak samochodow do wyswietlenia");
        }
        else
        {
            Console.WriteLine("Lista samochodow:");
            foreach (var item in carDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Brand} {item.Value.Model}");
            }
        }
    }

    private static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
    {
        Console.Clear();
        
        Console.Write("Podaj marke: ");
        string brand = Console.ReadLine();
        Console.Write("Podaj model: ");
        string model = Console.ReadLine();
        
        Car car = new Car(brand, model);
        carDictionary[cars.Count + 1] = car;
        cars.Add(car);

        WriteColorLine("Samochod dodany pomyslnie", ConsoleColor.Green);
    }

    private static void WriteColorLine(string sentence, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(sentence);
        Console.ResetColor();
    }

    // jezeli przypiszemy nulla to domyslnie jest null i nie musi zostac podany jako parametr
    private static int GetUserInput(Dictionary<int, Car> carDictionary = null)
    {
        int input;
        while (true)
        {
            Console.Write("podaj wartosc (int): ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (carDictionary == null || carDictionary.ContainsKey(input))
                {
                    return input;
                }
                WriteColorLine("\nNumer samochodu nie istnieje w slowniku\n", ConsoleColor.Red);
            }
            else
            {
                WriteColorLine("\nNieprawidlowy format. Sprobuj ponownie", ConsoleColor.Red);
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu symulatora jazdy samochodem");
        Console.WriteLine("1. Dodaj samochod");
        Console.WriteLine("2. Wyswietl liste samochodow");
        Console.WriteLine("3. Jedz samochodem");
        Console.WriteLine("4. Symuluj losowe uszkodzenia");
        Console.WriteLine("5. Zezlomuj samochod");
        Console.WriteLine("6. Wyjscie");
        Console.Write("Wybierz opcje (1-6), ");
    }
}
