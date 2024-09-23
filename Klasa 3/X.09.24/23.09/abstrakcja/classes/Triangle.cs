namespace dziedziczenie.classes;

public class Triangle : Shape
{
    private float a;
    private float b;
    private float c;

    public Triangle(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override float CalculateArea()
    {
        float s = (a + b + c) / 2;
        return (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public override float CalculatePerimeter()
    {
        return a + b + c;
    }
}