namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Zenek", 5);
        Cat cat = new Cat("Filemon", 3);
        
        dog.MakeSound();
        dog.Eat();
        
        cat.MakeSound();
        cat.Eat();
        
        Console.Clear();
        
        // List<IAnimal> animals = new List<IAnimal>();
        // animals.Add(dog);
        // animals.Add(cat);

        var animals = new List<IAnimal>()
        {
            dog,
            cat
        };
        
        foreach (IAnimal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}