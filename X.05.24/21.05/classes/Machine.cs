namespace _21._05.classes;

public class Machine
{
    public string Name { get; set; }
    public MachineType Type { get; set; }

    // konstruktor glowny
    public Machine(string name, MachineType machineType)
    {
        Name = name;
        Type = machineType;
        Console.WriteLine($"{Name} zostala stworzona");
    }

    //konstruktor kopiujacy
    public Machine(Machine machine)
    {
        Name = machine.Name;
        Console.WriteLine($"Kopia maszyny {Name} zostala stworzona");
    }

    ~Machine()
    {
        Console.WriteLine($"{Name} zostala zniszczona");
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Name} zostala uruchomiona");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} zostala zatrzymana");
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} pracuje");
    }
}