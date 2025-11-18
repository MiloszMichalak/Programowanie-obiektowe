using TrainTickerReservationSystem;
using TrainTickerReservationSystem.factory;

public class ReservationFactory
{
    public static IReservationService Create(string choice)
    {
        return choice switch
        {
            "1" => new EIPTrainReservationSystem(),
            "2" => new PolRegioTrainReservationSystem(),
            "3" => new TLKTrainReservationService(),
             _  => throw new ArgumentException("Nieznany typ pociągu.")
        };
    }
}