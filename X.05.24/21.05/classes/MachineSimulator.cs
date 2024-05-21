namespace _21._05.classes;

internal class MachineSimulator
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
    
}