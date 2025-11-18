namespace TrainTickerReservationSystem.utils;

public class TrainSeatSelector
{
    private static void PrintSeats()
    {
        Console.WriteLine("╔════———————════════———————═══════———————═════════————————═══════———————════════————————═══════———————═══════————————══════————————═════╗");
        Console.WriteLine("║ [15]    [16] | [25]    [26] | [35]    [36] | [45]    [46] | [55]    [56] | [65]    [66] | [75]    [76] | [85]    [86] | [95]    [96]  ║");
        Console.WriteLine("║ [13]    [14] | [23]    [24] | [33]    [34] | [43]    [44] | [53]    [54] | [63]    [64] | [73]    [74] | [83]    [84] | [93]    [94]  ║");
        Console.WriteLine("║ [11]    [12] | [21]    [22] | [31]    [32] | [41]    [42] | [51]    [52] | [61]    [62] | [71]    [72] | [81]    [82] | [91]    [92]  ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
    }
    
    public static int SelectSeat()
    {
        PrintSeats();

        while (true)
        {
            Console.Write("Numer siedzenia: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var seat))
            {
                if (IsSeatValid(seat))
                    return seat;

                Console.WriteLine("Niepoprawny numer siedzenia, sprobuj ponowanie.");
            }
            else
            {
                Console.WriteLine("Wprowadz cyfre.");
            }
        }
    }
    
    private static bool IsSeatValid(int seat)
    {
        if (seat < 11 || seat > 96)
            return false;
        
        var ones = seat % 10;
        
        if (ones < 1 || ones > 6)
            return false;
        
        return true;
    }
}