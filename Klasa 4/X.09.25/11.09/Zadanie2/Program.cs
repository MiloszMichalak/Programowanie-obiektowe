namespace Zadanie2;

class Program
{
    static void Main(string[] args)
    {
        var urzadzenie = new Urzadzenie();
        var telefon =  new Telefon();
        var smartfon = new Smartfon();
        
        urzadzenie.Wlacz();
        
        telefon.Wlacz();
        telefon.Zadzwon();
        
        smartfon.Wlacz();
        smartfon.Zadzwon();
        smartfon.PrzegladajInternet();
    }
}