using AppCs.Library;
using Xunit;

namespace AppCs.Tests;

public class StatisticsTests
{
    [Fact]
    public void Mean_ReturnsAverage()
    {
        var result = Statistics.Mean(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 });
        Assert.Equal(3.0, result, 5);
    }

    [Fact]
    public void Median_WorksForOddAndEven()
    {
        Assert.Equal(2.5, Statistics.Median(new[] { 1.0, 2.0, 3.0, 4.0 }));
        Assert.Equal(2.0, Statistics.Median(new[] { 1.0, 2.0, 3.0 }));
    }

    [Fact]
    public void StandardDeviation_ReturnsSD()
    {
        double[] data = { 2, 4, 4, 4, 5, 5, 7, 9 };
        Assert.Equal(2.0, Statistics.StandardDeviation(data), 5);
    }

    [Fact]
    public void EmptyCollection_Throws()
    {
        Assert.Throws<ArgumentException>(() => Statistics.Mean(Array.Empty<double>()));
        Assert.Throws<ArgumentException>(() => Statistics.Median(Array.Empty<double>()));
        Assert.Throws<ArgumentException>(() => Statistics.StandardDeviation(Array.Empty<double>()));
    }
}
