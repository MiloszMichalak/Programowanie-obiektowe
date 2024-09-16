namespace _21._05.classes;

public class MenuManager
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Wyswietl wszystkie maszyny");
        Console.WriteLine("2. Uruchom wszystkie maszyny");
        Console.WriteLine("3. Pracuj wszystkimi maszynami");
        Console.WriteLine("4. Zatrzymaj wszystkie maszyny");
        Console.WriteLine("5. Wyswietl status wszystkich maszyn");
        Console.WriteLine("6. Losowe awarie maszyn");
        Console.WriteLine("7. Napraw wszystkie maszyny");
        Console.WriteLine("8. Dodaj nowy typ maszyny");
        Console.WriteLine("9. Dodaj nowa maszyne");
        Console.WriteLine("10. Wyjdz");
        Console.WriteLine();
    }

    public string GetUserInput()
    {
        string input = Console.ReadLine();
        while (!IsValidInput(input, 1, 10))
        {
            ShowErrorMessage("Nieprawidlowa opcja, sporobuj ponownie");
            input = Console.ReadLine();
        }

        return input;
    }

    private void ShowErrorMessage(string message)
    {
        Console.WriteLine(message);
    }

    private bool IsValidInput(string input, byte min, byte max)
    {
        return int.TryParse(input, out int number) && number >= min && number <= max;
    }

    public void ExecuteActions(string userInput, MachineSimulator machineSimulator, MachineTypeManager machineTypeManager)
    {
        int action = Convert.ToInt32(Console.ReadLine());
        switch (action)
        {
            case 1:
                machineSimulator.DisplayAllMachines();
                break;
            case 2:
                machineSimulator.StartAll();
                break;
            case 3:
                machineSimulator.WorkAll();
                break;
            case 4:
                machineSimulator.StopAll();
                break;
            case 5:
                // machineSimulator.DisplayStatusAll();
                break;
            case 6:
                // machineSimulator.RandomlyFailMachines;
                break;
            case 7:
                // machineSimulator.RepairAllMachines();
                break;
            case 8:
                Console.Write("Podaj nazwe nowego typu maszyny: ");
                string newType = Console.ReadLine();
                machineTypeManager.AddMachineType(newType);
                break;
            case 9:
                machineSimulator.AddNewMachine(machineTypeManager);
                break;
            case 10:
                Console.WriteLine("Zakonczenie programu");
                break;
            default: ShowErrorMessage("Nieprawidlowa opcja. Sproboj ponownie");
                break;
        }
    }
}