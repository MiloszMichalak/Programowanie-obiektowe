namespace TrainTickerReservationSystem.builder;

public class TrainTicket
{
    public string PassengerName { get; set; }
    public string Departure { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public int SeatNumber { get; set; }
    public string TrainNumber { get; set; }

    public override string ToString()
    {
        return "Imie: " + PassengerName + ", Z: " + Departure + ", Do: " + Destination +
               ", Odjazd o: " + DepartureTime + ", Numer pociagu: " + TrainNumber + ", Numer siedzenia: " + SeatNumber;
    }
}