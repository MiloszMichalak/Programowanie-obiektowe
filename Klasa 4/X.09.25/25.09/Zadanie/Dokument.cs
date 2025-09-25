namespace Zadanie;

public class Dokument
{
    public string Tytul;
    
    public Dokument(string Tytul) => this.Tytul = Tytul;

    public string PokazTytul()
    {
        return Tytul;
    }
}