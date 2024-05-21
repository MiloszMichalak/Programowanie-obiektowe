using _21._05.classes;

namespace _21._05;

public enum MachineType
{
    Excuvator,
    Crane,
    Bulldozer,
    Loader
}


class Program
{
    static void Main(string[] args)
    {
        Machine machine = new Machine("C2000", MachineType.Crane);
        machine.Start();

        Console.WriteLine();
        
        Excavator excavator = new Excavator("B265", MachineType.Excuvator);
        excavator.Start();
        excavator.Work();
        excavator.Stop("Zatrzymanie bezpieczenstwa");

        Console.WriteLine();
        
        MachineSimulator simulator = new MachineSimulator();
        simulator.AddMachine(machine);
        simulator.AddMachine(excavator);
        simulator.StartAll();
    }
}
