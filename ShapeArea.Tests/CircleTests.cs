using Xunit;

namespace ShapeArea.Tests;

public class CircleTests
{
    [Fact]
    public void TestCalculateArea()
    {
        var circle = new Circle(2);

        var area = circle.CalculateArea();

        Assert.Equal(Math.PI * 2, area);
    }

    [Fact]
    public void TestInvalidCircle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
}