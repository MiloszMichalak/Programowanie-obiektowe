namespace Zadanie___symulator.classes;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool isDamaged { get; set; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        isDamaged = false;
    }

    ~Car()
    {
        Console.WriteLine("Samochod zostal zezlomowany");
    }

    public string Drive()
    {
        if (isDamaged)
        {
            return $"Samochod {Brand} {Model} nie nadaje sie do jazdy";
        }
        else
        {
            return $"Samochod {Brand} {Model} jedzie";
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

        isDamaged = true;
    }
}
