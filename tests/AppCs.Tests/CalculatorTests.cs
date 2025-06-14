using AppCs.Library;
using Xunit;

namespace AppCs.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -2, -3)]
    [InlineData(-1, 2, 1)]
    public void Add_ReturnsSum(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Add(a, b));
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-5, -3, -2)]
    [InlineData(-5, 3, -8)]
    public void Subtract_ReturnsDifference(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Subtract(a, b));
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, -3, 6)]
    [InlineData(-2, 3, -6)]
    public void Multiply_ReturnsProduct(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Multiply(a, b));
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(-6, -3, 2)]
    [InlineData(-6, 3, -2)]
    public void Divide_ReturnsQuotient(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Divide(a, b));
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
    }

    [Theory]
    [InlineData(2, 0, 1)]
    [InlineData(2, 3, 8)]
    [InlineData(-2, 2, 4)]
    public void Power_ReturnsPower(int baseValue, int exponent, int expected)
    {
        Assert.Equal(expected, _calculator.Power(baseValue, exponent));
    }

    [Fact]
    public void Power_NegativeExponent_Throws()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Power(2, -1));
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    public void Factorial_ReturnsFactorial(int n, int expected)
    {
        Assert.Equal(expected, _calculator.Factorial(n));
    }

    [Fact]
    public void Factorial_Negative_Throws()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));
    }

    [Theory]
    [InlineData(54, 24, 6)]
    [InlineData(5, 0, 5)]
    [InlineData(-5, -10, 5)]
    public void Gcd_ReturnsGreatestCommonDivisor(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Gcd(a, b));
    }
}
