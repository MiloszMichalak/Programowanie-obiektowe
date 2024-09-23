namespace dziedziczenie.classes;

public abstract class Shape
{
    public abstract float CalculateArea();

    public abstract float CalculatePerimeter();

    internal void DisplayInfo()
    {
        Console.WriteLine("To jest ksztalt");
    }
}