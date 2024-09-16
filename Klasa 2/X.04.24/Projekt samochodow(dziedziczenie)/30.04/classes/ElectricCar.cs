using System.Text.Json.Serialization.Metadata;

namespace _30._04.classes;

public class ElectricCar : Car
{
    public double BatteryCapacity { get; set; }
    public double MaxBatteryCapacity { get; set; }

    public ElectricCar(string brand, string model, ushort speed, FuelType fuelType, byte maxGear, bool isAutomatic, double maxBatteryCapacity) : base(brand, model, speed, fuelType, maxGear, isAutomatic)
    {
        BatteryCapacity = 30;
        MaxBatteryCapacity = maxBatteryCapacity;
    }

    public override string StartEngine()
    {
        return "Zamknieto obieg elektryczny";
    }

    public override string StopEngine()
    {
        return "Otwarto obieg elektryczny";
    }

    public override string GetInfo()
    {
        return base.GetInfo() + "\n" + 
               $"Pojemnosc bateri: {BatteryCapacity}";
    }

    public void ChargeBattery(double kWh)
    {
        if (kWh <= 0)
        {
            Console.WriteLine("Nie mozna naladowac ujemna albo zerowa wartoscia");
        }
        else if (BatteryCapacity + kWh > MaxBatteryCapacity)
        {
            Console.WriteLine($"Nie mozna naladowac bateri o {kWh} poniewaz przekraczylo by to pojemnosc akumulatora wynoszaca: {MaxBatteryCapacity}");
        }
        else
        {
            BatteryCapacity += kWh;
            AnimationHelper.ShowProgress("Ladujesz baterie: ", "zakonczono", 200, 10);
            Console.WriteLine($"Naladowano baterie o {kWh} kWh"); 

        }
    }
}