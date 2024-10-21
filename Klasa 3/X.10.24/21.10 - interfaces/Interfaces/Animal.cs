namespace Interfaces;

public abstract class Animal : IAnimal
{
    public string name;
    public int age;
    
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine($"{name} je");   
    }
}