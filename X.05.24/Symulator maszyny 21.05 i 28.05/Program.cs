using _21._05.classes;

namespace _21._05;

public enum MachineType
{
    Excavator,
    Crane,
    Bulldozer,
    Loader
}

class Program
{
    static void Main(string[] args)
    {

        MachineSimulator machineSimulator = new MachineSimulator();
        MachineTypeManager machineTypeManager = new MachineTypeManager();
        MenuManager menuManager = new MenuManager();

        string userInput = "";

        Excavator excavator = new Excavator("e-100", MachineType.Excavator);
        machineSimulator.AddMachine(excavator);

        do
        {
            menuManager.DisplayMenu();
            Console.WriteLine("Wybierz opcja");
            userInput = menuManager.GetUserInput();
            menuManager.ExecuteActions(userInput, machineSimulator, machineTypeManager);
        } while (userInput != "9");
    }
}
