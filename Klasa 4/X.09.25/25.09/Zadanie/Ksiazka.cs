namespace Zadanie;

public class Ksiazka: Dokument, IDrukowalny
{
    public Ksiazka(string tytul) : base(tytul)
    {
        
    }

    public Ksiazka(Ksiazka ksiazkaCopy) : base(ksiazkaCopy.Tytul)
    {
        
    }
    
    public void Drukuj()
    {
        Console.WriteLine("Drukuj ksiazke");
    }
}