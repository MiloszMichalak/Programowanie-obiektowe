namespace Zadanie;

class Program
{
    static void Main(string[] args)
    {
        var listaDokumentow = new List<IDrukowalny>();

        var raport1 = new Raport("Raport 1");
        var raport2 = new Raport("Raport 2");
        
        var Ksiazka1 = new Ksiazka("Ksiazka 1");
        var Ksiazka2 = new Ksiazka("Ksiazka 2");
        
        listaDokumentow.Add(raport1);
        listaDokumentow.Add(raport2);
        listaDokumentow.Add(Ksiazka1);
        listaDokumentow.Add(Ksiazka2);

        foreach (var drukow in listaDokumentow)
        {
            drukow.Drukuj();
        }
    }
}