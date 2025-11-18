using TrainTickerReservationSystem;
using TrainTickerReservationSystem.api;
using TrainTickerReservationSystem.builder;
using TrainTickerReservationSystem.factory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Witaj w systemie rezerwacji biletow na pociag!");
        Console.WriteLine("Wybierz rodzaj pociagu:");
        Console.WriteLine("1. EIP");
        Console.WriteLine("2. TLK");
        Console.WriteLine("3. PolRegio");
        Console.WriteLine("4. Wyswietl zapisane bilety");
        Console.Write("Podaj swoj wybor: ");
        
        var api = TrainTicketApiClient.Instance;

        var choice = Console.ReadLine();
        
        if (choice == "4")
        {
            var tickets = api.GetTicketsAsync().Result;

            if (tickets == null || tickets.Count == 0)
            {
                Console.WriteLine("Brak biletow w bazie.");
            }
            else
            {
                Console.WriteLine("Bilety zapisane w bazie:");
                int i = 1;
                foreach (var t in tickets)
                {
                    Console.WriteLine(
                        $"{i}. {t}");
                    i++;
                }
            }

            return;
        }

        IReservationService reservationService = ReservationFactory.Create(choice);
        
        var ticket = reservationService.MakeReservation();
        Console.WriteLine("Szczegoly rezerwacji:");
        Console.WriteLine(ticket);
        
        Console.WriteLine("Rezerwacja zapisana!");
        
        var response = api.CreateTicketAsync(ticket).Result;
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Bilet zapisany na serwerze.");
        }
    }
}