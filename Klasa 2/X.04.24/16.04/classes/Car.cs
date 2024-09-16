namespace _15._04.classes;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsDamaged { get; set; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        IsDamaged = false;
    }

    ~Car()
    {
        Console.WriteLine("Samochod zostal zezlomowany");
    }

    public string Drive()
    {
        if (IsDamaged)
        {
            return $"\nSamochod {Brand} {Model} nie nadaje sie do jazdy\n";
        }
        else
        {
            return $"\nSamochod {Brand} {Model} jedzie\n";
        }
    }

    public void SimulatedRandomDamage()
    {
        Random random = new Random();
        int damageType = random.Next(1, 4);
        switch (damageType)
        {
            case 1:
                Console.WriteLine($"Samochod {Brand} {Model} ma przebita opone");
                break;
            case 2:
                Console.WriteLine($"Samochod {Brand} {Model} ma uszkodzony silnik");
                break;
            case 3:
                Console.WriteLine($"Samochod {Brand} {Model} ma przebita opone");
                break;
        }

        IsDamaged = true;
    }
}
