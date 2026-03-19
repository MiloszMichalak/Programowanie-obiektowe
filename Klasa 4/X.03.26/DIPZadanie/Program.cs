namespace DIPZadanie;

public interface IChargingMethod
{
    void Charge();
}

public class AcCharging : IChargingMethod
{
    public void Charge()
    {
        Console.WriteLine("Ładowanie AC");
    }
}

public class DcCharging : IChargingMethod
{
    public void Charge()
    {
        Console.WriteLine("Ładowanie DC");
    }
}

public class InductiveCharging : IChargingMethod
{
    public void Charge()
    {
        Console.WriteLine("Ładowanie indukcyjne");
    }
}

public class SolarCharging : IChargingMethod
{
    public void Charge()
    {
        Console.WriteLine("Ładowanie solarne");
    }
}

public class CarCharger(IChargingMethod chargingMethod)
{
    public void StartCharging()
    {
        Console.WriteLine("Rozpoczynam ładowanie pojazdu");
        chargingMethod.Charge();
        Console.WriteLine("Ładowanie zakończone.\n");
    }
}

static class Program
{
    static void Main()
    {
        var charger = new CarCharger(new DcCharging());
        charger.StartCharging();

        var solarCharger = new CarCharger(new SolarCharging());
        solarCharger.StartCharging();
    }
}