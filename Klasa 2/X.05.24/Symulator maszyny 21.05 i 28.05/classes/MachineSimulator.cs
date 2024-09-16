namespace _21._05.classes;

public class MachineSimulator
{
    private List<Machine> Machines = new List<Machine>();

    public void AddMachine(Machine machine)
    {
        Machines.Add(machine);
    }

    public void StartAll()
    {
        foreach (var machine in Machines)
        {
            machine.Start();
        }
    }
    
    public void WorkAll()
    {
        foreach (var machine in Machines)
        {
            machine.Work();
        }
    }
    
    public void StopAll()
    {
        foreach (var machine in Machines)
        {
            machine.Stop();
        }
    }


    public void DisplayAllMachines()
    {
        Console.WriteLine(string.Join(", ", Machines));
    }

    public void AddNewMachine(MachineTypeManager typeManager)
    {
        typeManager.DisplayMachineTypes();
        Console.Write("Wybierz typ maszyny do dodania: ");
        string machineType = Console.ReadLine();
        if (typeManager.IsValidType(machineType))
        {
            Machine newMachine = MachineFactory.CreateMachine(machineType);
            AddMachine(newMachine);
        }
        else
        {
            Console.WriteLine("Nieznany typ maszyny");
        }
    }
}