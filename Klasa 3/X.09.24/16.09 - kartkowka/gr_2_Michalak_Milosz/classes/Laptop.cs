namespace gr_2_Michalak_Milosz.classes;

public class Laptop : Device
{
    private int BatteryLife;

    public Laptop(string brand, String model, int batteryLife)
    {
        Brand = brand;
        Model = model;
        BatteryLife = batteryLife;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Procent bateri: {BatteryLife} %");
    }
}