namespace _30._04.classes;

public class Car : Vehicle
{
    public byte MaxGear { get; set; }
    public bool IsAutomatic { get; set; }
    public byte CurrentGear { get; set; }
    public Car(string brand, string model, ushort speed, FuelType fuelType, byte maxGear, bool isAutomatic) 
        : base(brand, model, speed, fuelType)
    {
        MaxGear = maxGear;
        IsAutomatic = isAutomatic;
    }

    public override string StopEngine()
    {
        return "Car's engine stopped";
    }

    public void ChangeGear(byte gear)
    {
        if (!IsAutomatic)
        {
            if (gear > MaxGear || gear == 0)
            {
                Console.WriteLine("Nieprawidlowy bieg");
            }
            else
            {
                CurrentGear = gear;
                Console.WriteLine($"Zmiana biegu na {gear}");
            }
        }
        else
        {
            Console.WriteLine("Skrzynia biegow jest automatyczna");
        }
    }

    private void AutomaticGear(ushort speed)
    {
        if (IsAutomatic)
        {
            if (speed < 20)
            {
                CurrentGear = 1;
            } else if (speed > 20 && speed < 50)
            {
                CurrentGear = 2;
            } else if (speed > 50 && speed < 70)
            {
                CurrentGear = 3;
            }
            else
            {
                CurrentGear = MaxGear;
            }
        }
        else
        {
            Console.WriteLine("Manualna skrzynia biegow");
        }

        Console.WriteLine($"Automatyczna zmiana biegu na {CurrentGear} przy predkosci {speed}");
    }
    
    public override string GetInfo()
    {
        return base.GetInfo() + "\n" +
               $"Maksymalny bieg: {MaxGear} \n" +
               $"Obecny bieg: {CurrentGear} \n" +
               $"Czy automat: {IsAutomatic}"; 

    }
}