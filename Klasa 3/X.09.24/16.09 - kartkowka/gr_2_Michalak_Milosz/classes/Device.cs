namespace gr_2_Michalak_Milosz.classes;

public abstract class Device
{
    protected string Brand;
    protected string Model;
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Marka: {Brand} \nModel: {Model}");
    }
}
