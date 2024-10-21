namespace Interfaces;

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    { }

    public override void MakeSound()
    {
        Console.WriteLine("Hau");
    }
}