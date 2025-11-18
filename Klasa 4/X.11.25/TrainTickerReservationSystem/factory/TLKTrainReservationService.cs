using TrainTickerReservationSystem.builder;
using TrainTickerReservationSystem.utils;

namespace TrainTickerReservationSystem.factory;

public class TLKTrainReservationService : IReservationService
{
    private static readonly Dictionary<int, string> Cities = new()
    {
        { 1, "Warszawa" },
        { 2, "Lublin"},
        { 4, "Katowice" },
        { 8, "Szczecin" }
    };
    
    public TrainTicket MakeReservation()
    { 
        ITrainTicketBuilder builder = new TLKTrainTicketBuilder();

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