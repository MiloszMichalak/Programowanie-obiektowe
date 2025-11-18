using TrainTickerReservationSystem.builder;
using TrainTickerReservationSystem.utils;

namespace TrainTickerReservationSystem.factory;

public class PolRegioTrainReservationSystem : IReservationService
{
    private static readonly Dictionary<int, string> Cities = new()
    {
        { 2, "Lublin" },
        { 3, "Rzeszów" },
        { 4, "Sosnowiec" },
    };
    
    public TrainTicket MakeReservation()
    {
        ITrainTicketBuilder builder = new PolregioTrainTicketBuilder();

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