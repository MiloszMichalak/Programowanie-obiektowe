namespace CalculatorApp;

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }
    
    public int Divide(int x, int y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return x / y;
    }
}