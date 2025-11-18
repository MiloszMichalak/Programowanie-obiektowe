namespace TrainTickerReservationSystem.utils;

public class CitySelector
{
    private static Dictionary<int, string> _cities = new();

    public CitySelector(Dictionary<int, string> cities)
    {
        _cities = cities;
    }

    private (int id, string name) ChooseCity(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            foreach (var city in _cities)
            {
                Console.WriteLine($"{city.Key} - {city.Value}");
            }
                

            Console.Write("> ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var key) && _cities.TryGetValue(key, out var value))
                return (key, value);

            Console.WriteLine("Nieprawidłowy wybór miasta, sprobuj ponownie.\n");
        }
    }
    
    public (int departureId, int destinationId, string departure, string destination) ChooseRoute()
    {
        while (true)
        {
            var (depId, depName) = ChooseCity("Wybierz miasto początkowe:");
            var (destId, destName) = ChooseCity("Wybierz miasto docelowe:");

            if (!string.Equals(depName, destName))
                return (depId, destId, depName, destName);

            Console.WriteLine("Nie można wybrać tego samego miasta jako początkowe i docelowe. Spróbuj ponownie.\n");
        }
    }
}