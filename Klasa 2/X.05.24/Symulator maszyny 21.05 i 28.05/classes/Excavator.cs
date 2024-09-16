namespace _21._05.classes;

public class Excavator : Machine
{
    public Excavator(string name, MachineType machineType) : base(name, machineType)
    { }

    public Excavator(Excavator excavator) : base(excavator)
    { }

    ~Excavator()
    {
        Console.WriteLine($"Koparka {Name} zostala zniszczona");
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine($"Koparka {Name} rozpoczyna kopanie");
    }

    public void Stop(string reason)
    {
        Console.Write($"Koparka {Name} zostala zatrzymana z powodu: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(reason);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void Dig()
    {
        Console.WriteLine($"Koparka {Name} kopie");
    }

    public override void Work()
    {
        Dig();
    }
}