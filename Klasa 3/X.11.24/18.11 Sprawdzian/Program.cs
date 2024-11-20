using Miłosz_Michalak_grupa2.classes;

namespace Miłosz_Michalak_grupa2;

class Program
{
    private static List<Animal> animals = new();
    static void Main(string[] args)
    {
        // CZESC 1

        Dog dog1 = new Dog("Azor", "Pies", 2, "Jan Kowalski");
        Cat cat1 = new Cat("Filemon", "Kot", 3, "Anna Nowak");
        Dog dog2 = new Dog("Reksio", "Pies", 4, "Piotr Wiśniewski");
        Cat cat2 = new Cat("Mruczek", "Kot", 1, "Katarzyna Zielińska");

        dog1.MakeSound();
        dog1.Eat();
        cat1.MakeSound();
        cat1.Eat();
        dog2.MakeSound();
        dog2.Eat();
        cat2.MakeSound();
        cat2.Eat();

        animals = [dog1, dog2, cat1, cat2];

        Console.WriteLine("\nWyswietlanie MakeSound i Eat poprzez Iterowanie");
        animals.ForEach(animal =>
        {
            animal.MakeSound();
            animal.Eat();
        });
        
        // CZESC 2

        Console.WriteLine("\nSortowanie wedlug wlasciela");
        SortByOwnerAndPrint();

        Console.WriteLine("\nSortowanie wedlug gatunku");
        SortBySpeciesAndPrint();

        Console.WriteLine("\nSortowanie wedlug wieku");
        SortByAgeAndPrint();

        Console.WriteLine("\nSortowanie wedlug imienia");
        SortByNameAndPrint();

        Console.WriteLine();
        // CZESC 3 
        while (true)
        {
            ShowMenuInfo();
            int choice = GetIntFromUser();
            switch (choice)
            {
                case 1:
                    SortByOwnerAndPrint();
                    break;
                case 2:
                    SortBySpeciesAndPrint();
                    break;
                case 3:
                    SortByAgeAndPrint();
                    break;
                case 4:
                    SortByNameAndPrint();
                    break;
                case 5:
                    return;
            }
        }
    }

    private static void SortByNameAndPrint()
    {
        var animalsSortedByName = animals.OrderBy(animal => animal.Name);

        foreach (var animal in animalsSortedByName)
        {
            Console.WriteLine(animal);
        }
    }

    private static void SortByAgeAndPrint()
    {
        var animalsSortedByAge = animals.OrderBy(animal => animal.Age);

        foreach (var animal in animalsSortedByAge)
        {
            Console.WriteLine(animal);
        }
    }

    private static void SortBySpeciesAndPrint()
    {
        var animalsSortedBySpecies = animals.OrderBy(animal => animal.Species);

        foreach (var animal in animalsSortedBySpecies)
        {
            Console.WriteLine(animal);
        }
    }

    private static void SortByOwnerAndPrint()
    {
        var animalsSortedByOwner = animals.OrderBy(animal => animal.Owner);
        
        foreach (var animal in animalsSortedByOwner)
        {
            Console.WriteLine(animal);
        }
    }

    private static void ShowMenuInfo()
    {
        Console.WriteLine("1. Sortowanie wedlug wlasciciela");
        Console.WriteLine("2. Sortowanie wedlug gatunku");
        Console.WriteLine("3. Sortowanie wedlug wieku");
        Console.WriteLine("4. Sortowanie wedlug imienia");
        Console.WriteLine("5. Wyjscie");
    }

    private static int GetIntFromUser()
    {
        if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= 5)
        {
            return result;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj liczbe calkowita pomiędzy 1 a 5");
        Console.ResetColor();
        return GetIntFromUser();
    }
}