namespace dziedziczenie.classes;

public class Circle : Shape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public void SetRadius(float radius)
    {
        this.radius = radius;
    }

    public override float CalculateArea()
    {
        return (float)Math.Round(Math.PI * radius * radius, 2);
    }

    public override float CalculatePerimeter()
    {
        return (float)Math.Round(2 * Math.PI * radius, 2
            );
    }
}