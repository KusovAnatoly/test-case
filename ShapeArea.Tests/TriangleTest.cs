namespace ShapeArea.Tests;

using Xunit;
using ShapeArea;

public class TriangleTest
{
    [Fact]
    public void TestCalculateArea()
    {
        var triangle = new Triangle(3, 4);

        var area = triangle.CalculateArea();

        Assert.Equal(6, area);
    }

    [Fact]
    public void TestIsRightAngled()
    {
        var triangle = new Triangle(8, 6);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }

    [Fact]
    public void TestInvalidTriangle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0));
    }
}