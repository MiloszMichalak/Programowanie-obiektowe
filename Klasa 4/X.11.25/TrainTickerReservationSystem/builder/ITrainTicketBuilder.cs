namespace TrainTickerReservationSystem.builder;

public interface ITrainTicketBuilder
{
    ITrainTicketBuilder SetPassengerName(string name);
    ITrainTicketBuilder SetDeparture(string departure);
    ITrainTicketBuilder SetDestination(string destination);
    ITrainTicketBuilder SetDepartureTime(DateTime date);
    ITrainTicketBuilder SetSeatNumber(int seatNumber);
    ITrainTicketBuilder SetTrainNumber(int depId, int destId);
    TrainTicket Build();
}