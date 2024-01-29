namespace ShapeArea;

public class Triangle: Shape
{
    private readonly double _baseSide;
    private readonly double _height;

    public Triangle(double baseSide, double height)
    {
        _baseSide = baseSide;
        _height = height;
    }
    
    /// <summary>
    /// Returns a calculated triangle area
    /// </summary>
    /// <remarks>
    /// Area = (base × height) / 2
    /// </remarks>
    public override double CalculateArea()
    {
        return (_baseSide * _height) / 2;
    }

    /// <summary>
    /// Returns true if the triangle is squared otherwise false
    /// </summary>
    /// <remarks>
    /// Uses Pythagorean theorem
    /// </remarks>
    public bool IsRightAngled()
    {
        var hypotenuse = Math.Sqrt(Math.Pow(_baseSide, 2) * Math.Pow(_baseSide, 3));
        
        if (Math.Pow(hypotenuse, 2) == Math.Pow(_baseSide, 2) + Math.Pow(_baseSide, 3))
        {
            return true;
        }
        
        return false;
    }
}