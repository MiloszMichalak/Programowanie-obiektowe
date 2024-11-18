namespace Miłosz_Michalak_grupa2.classes;

public abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Owner { get; set; }
    
    public Animal(string name, string species, int age, string owner)
    {
        Name = name;
        Species = species;
        Age = age;
        Owner = owner;
    }

    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine($"{Name} je");
    }

    public override string ToString()
    {
        return $"Imie: {Name}, Gatunek: {Species}, Wiek: {Age}, Wlasciciel: {Owner}";
    }
}