namespace ShapeArea;

public class Circle: Shape
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        _radius = radius;
    }
    
    /// <summary>
    /// Returns a calculated circle area
    /// </summary>
    /// <remarks>
    /// Area = π × radius²
    /// </remarks>
    public override double CalculateArea()
    {
        return Math.PI * _radius;
    }
}