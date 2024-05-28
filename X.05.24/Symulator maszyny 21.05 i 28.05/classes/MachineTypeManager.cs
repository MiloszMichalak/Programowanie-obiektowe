namespace _21._05.classes;

public class MachineTypeManager
{
    private List<string> machineTypes = new List<string>();

    public MachineTypeManager()
    {
        machineTypes.Add("Koparka");
        machineTypes.Add("Dzwig");
        machineTypes.Add("Spychacz");
        machineTypes.Add("Ladowarka");
    }

    public void AddMachineType(string type)
    {
        if (!machineTypes.Contains(type))
        {
            machineTypes.Add(type);
            Console.WriteLine($"Typ maszyny {type} zostal dodany");
        }
        else
        {
            Console.WriteLine($"Typ maszyny {type} juz istnieje");
        }
    }

    public void DisplayMachineTypes()
    {
        Console.WriteLine("Dostepne typy maszyn: " + string.Join(" ", machineTypes));
    }

    public bool IsValidType(string type)
    {
        return machineTypes.Contains(type);
    }
}