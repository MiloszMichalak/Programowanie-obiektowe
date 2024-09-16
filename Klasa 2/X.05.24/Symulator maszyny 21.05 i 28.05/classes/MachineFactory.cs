namespace _21._05.classes;

public class MachineFactory
{
    public static Machine CreateMachine(string type)
    {
        switch (type)
        {
            case "Koparka":
                return new Excavator("Nowa koparka", MachineType.Excavator);
                break;
            case "Dzwig":
                return new Crane("Nowy dzwikg", MachineType.Crane);
                break;
            case "Spychacz":
                return new Bulldozer("Nowy buldozer", MachineType.Bulldozer);
                break;
            case "Ladowarka":
                return new Loader("Nowa koparka", MachineType.Loader);
                break;
            default:
                throw new ArgumentException("Nieznany typ maszyny");
                break;
        }
    }
}