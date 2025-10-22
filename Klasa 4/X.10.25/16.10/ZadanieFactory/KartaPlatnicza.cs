namespace ZadanieFactory;

public class KartaPlatnicza : IPlatnosc
{
    public void Autoryzuj()
    {
        Console.WriteLine("Autoryzuje karte...");
    }

    public void PobierzOpis()
    {
        Console.WriteLine("Pobieram opis karty...");
    }
}