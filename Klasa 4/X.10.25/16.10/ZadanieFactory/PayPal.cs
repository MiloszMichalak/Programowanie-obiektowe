namespace ZadanieFactory;

public class PayPal: IPlatnosc
{
    public void Autoryzuj()
    {
        Console.WriteLine("Autoryzuje paypala...");
    }

    public void PobierzOpis()
    {
        Console.WriteLine("Pobieram opis paypala...");
    }
}