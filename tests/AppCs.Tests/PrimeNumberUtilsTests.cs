using AppCs.Library;
using Xunit;

namespace AppCs.Tests;

public class PrimeNumberUtilsTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(1, false)]
    public void IsPrime_Works(int value, bool expected)
    {
        Assert.Equal(expected, PrimeNumberUtils.IsPrime(value));
    }

    [Fact]
    public void GetPrimesUpTo_ReturnsPrimes()
    {
        var primes = PrimeNumberUtils.GetPrimesUpTo(10);
        Assert.Equal(new[] { 2, 3, 5, 7 }, primes);
    }

    [Fact]
    public void PrimeFactors_ReturnsFactors()
    {
        var factors = PrimeNumberUtils.PrimeFactors(28);
        Assert.Equal(new[] { 2, 2, 7 }, factors);
    }

    [Fact]
    public void PrimeFactors_Prime_ReturnsSelf()
    {
        var factors = PrimeNumberUtils.PrimeFactors(13);
        Assert.Equal(new[] { 13 }, factors);
    }

    [Fact]
    public void PrimeFactors_InvalidInput_Throws()
    {
        Assert.Throws<ArgumentException>(() => PrimeNumberUtils.PrimeFactors(1));
    }
}
