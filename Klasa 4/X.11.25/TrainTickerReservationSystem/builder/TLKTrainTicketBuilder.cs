namespace TrainTickerReservationSystem.builder;

public class TLKTrainTicketBuilder : ITrainTicketBuilder
{
    private TrainTicket _ticket = new();

    public ITrainTicketBuilder SetPassengerName(string name)
    {
        _ticket.PassengerName = name;
        return this;
    }

    public ITrainTicketBuilder SetDeparture(string departure)
    {
        _ticket.Departure = departure;
        return this;
    }

    public ITrainTicketBuilder SetDestination(string destination)
    {
        _ticket.Destination = destination;
        return this;
    }

    public ITrainTicketBuilder SetDepartureTime(DateTime date)
    {
        _ticket.DepartureTime = date;
        return this;
    }

    public ITrainTicketBuilder SetSeatNumber(int seatNumber)
    {
        _ticket.SeatNumber = seatNumber;
        return this;
    }

    public ITrainTicketBuilder SetTrainNumber(int depId, int destId)
    {
        string trainNumber = $"{depId}{destId}";
        Random random = new Random();
        string numberWithSuffix = trainNumber + random.Next(0, 200).ToString("D3");
        _ticket.TrainNumber = numberWithSuffix;
        return this;
    }

    public TrainTicket Build()
    {
        var built = _ticket;
        _ticket = new TrainTicket();
        return built;
    }
}