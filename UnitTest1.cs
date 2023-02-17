using Xunit;
using MyAvgLib;
namespace MyAvgLibTest;

public class UnitTest1
{
    [Fact]
    public void TestAvg3()
    {
        double a = 2; //Arrange
        double b = 10;
        double c = 48;
        double expected = 20;

        double actual = MyAvgLib.Avg.Average(a, b, c); //Act
        Assert.Equal(expected, actual); //Assert

    }

    [Fact]
    public void TestAvg2()
    {
        double a = 33; //Arrange
        double b = 18;
        double expected = 25.5;

        double actual = MyAvgLib.Avg.Average(a, b); //Act
        Assert.Equal(expected, actual); //Assert
    }
}