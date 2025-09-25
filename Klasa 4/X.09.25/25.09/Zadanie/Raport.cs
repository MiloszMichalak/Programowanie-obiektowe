namespace Zadanie;

public class Raport : Dokument, IDrukowalny
{
    public Raport(string tytul) : base(tytul)
    {
        
    }

    public void Drukuj()
    {
        Console.WriteLine("Drukuj raport");
    }
}