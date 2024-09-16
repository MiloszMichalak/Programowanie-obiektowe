namespace gr_2_Michalak_Milosz.classes;

public class Smartphone : Device
{
    private bool Has5G;

    public Smartphone(string brand, string model, bool has5G)
    {
        Brand = brand;
        Model = model;
        Has5G = has5G;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ma 5G?: {Has5G}");
    }
}