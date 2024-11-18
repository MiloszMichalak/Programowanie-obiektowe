namespace Miłosz_Michalak_grupa2.classes;

public class Cat : Animal
{
    public Cat(string name, string species, int age, string owner) : base(name, species, age, owner)
    { }

    public override void MakeSound()
    {
        Console.WriteLine("Miau!");
    }
}