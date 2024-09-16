namespace dziedziczenie.classes;

public class Rectangle : Shape
{
    private float width;
    private float height;

    public void SetDimension(float w, float h)
    {
        width = w;
        height = h;
    }

    public override float CalculateArea()
    {
        return width * height;
    }

    public override float CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}