using Zadanie___symulator.classes;

namespace Zadanie___symulator;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

        while (true)
        {
            Console.WriteLine("Menu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochod");
            Console.WriteLine("2. Wyswietl liste samochodow");
            Console.WriteLine("3. Jedz samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenia");
            Console.WriteLine("5. Zazlomuj samochod");
            Console.WriteLine("6. wyjscie");

            Console.Write("Wybierz opcje (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Podaj marke: ");
                    string brand = Console.ReadLine();
                    Console.Write("Podaj model: ");
                    string model = Console.ReadLine();

                    Car car = new Car(brand, model);
                    carDictionary[cars.Count + 1] = car;
                    cars.Add(car);
                    Console.WriteLine("Samochod zostal dodany pomyslnie");
                    
                    break;
                
                case 2:
                    Console.WriteLine("Lista samochodow:");
                    foreach (var item in cars)
                    {
                        Console.WriteLine($"{item.Brand} {item.Model}");
                    }

                    break;
                case 3:
                    Console.Write("Podaj numer samochodu do jazdy: ");
                    int carNumber = Convert.ToInt32(Console.ReadLine());
                    if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
                    {
                        Console.WriteLine(selectedCar.Drive());
                    }
                    else
                    {
                        Console.WriteLine("\n Nieprawidlowy numer samochodu");
                    }
                    
                    break;
                case 4:
                    Console.Write("Podaj numer samochodu do symulacji uszkodzenia: ");
                    carNumber = Convert.ToInt32(Console.ReadLine());
                    if (carDictionary.TryGetValue(carNumber, out Car damagedCar))
                    {
                        damagedCar.SimulatedRandomDamage();
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowy numer samochodu");
                    }
                    
                    break;
                case 5:
                    Console.Write("Podaj numer samochodu do zezlomowania: ");
                    carNumber = Convert.ToInt32(Console.ReadLine());
                    if (carDictionary.TryGetValue(carNumber, out Car scrappedCar))
                    {
                        cars.Remove(scrappedCar);
                        carDictionary.Remove(carNumber);
                        Console.WriteLine($"Samochod {scrappedCar.Brand} {scrappedCar.Model} zostal zezlomowany");
                        scrappedCar = null;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowy numer samochodu");
                    }
                    
                    break;
                case 6:
                    Console.WriteLine("Zamykanie symulatora");
                    return;
                default:
                    break;
                    
            }
        }
    }
}
