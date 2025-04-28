namespace CalculatorApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(2, 3);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Divide_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Divide(12, 3);
        
        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Divide(12, 0);
        
        // Assert
        Assert.Throws<DivideByZeroException>(() => result);
    }
}
