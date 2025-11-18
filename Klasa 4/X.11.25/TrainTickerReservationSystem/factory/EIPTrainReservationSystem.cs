using TrainTickerReservationSystem.builder;
using TrainTickerReservationSystem.utils;

namespace TrainTickerReservationSystem.factory;

public class EIPTrainReservationSystem : IReservationService
{
    
    private static readonly Dictionary<int, string> Cities = new()
    {
        { 1, "Warszawa" },
        { 3, "Kraków" },
        { 5, "Gdańsk" },
        { 6, "Wrocław" },
        { 7, "Poznań" }
    };
    
    public TrainTicket MakeReservation()
    {
        ITrainTicketBuilder builder = new EIPTrainTicketBuilder();

        Console.Write("Imie: ");
        string name = Console.ReadLine();
        
        var citySelector = new CitySelector(cities: Cities);
        var (departureId,destinationId, departure, destination) = citySelector.ChooseRoute();

        Console.Write("Departure time (YYYY-MM-DD HH:mm): ");
        var dtInput = Console.ReadLine();
        var departureTime = DateTime.TryParse(dtInput, out var parsed)
            ? parsed
            : DateTime.Now.AddHours(1);
        
        var seat = TrainSeatSelector.SelectSeat();
        
        return builder
            .SetPassengerName(name)
            .SetDeparture(departure)
            .SetDestination(destination)
            .SetDepartureTime(departureTime)
            .SetSeatNumber(seat)
            .SetTrainNumber(departureId, destinationId)
            .Build();
    }
}