namespace ShapeArea;

public class Circle: Shape
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным.");
        }
        _radius = radius;
    }
    
    /// <summary>
    /// Вовзращает площадь круга
    /// </summary>
    /// <remarks>
    /// Area = π × radius²
    /// </remarks>
    public override double CalculateArea()
    {
        return Math.PI * _radius;
    }
}