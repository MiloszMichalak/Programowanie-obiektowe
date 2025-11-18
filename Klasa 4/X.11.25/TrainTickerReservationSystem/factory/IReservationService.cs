using TrainTickerReservationSystem.builder;

namespace TrainTickerReservationSystem.factory;

public interface IReservationService
{
    TrainTicket MakeReservation();
}