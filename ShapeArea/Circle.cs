namespace ShapeArea;

public class Circle: Shape
{
    private readonly double _radius;
    
    /// <summary>
    /// Конструктор для класса "Круг"
    /// </summary>
    /// <param name="radius">Радиус (положительное число с плавающей запятой)</param>
    /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если аргумент меньше или равен нулю</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException("Радиус не может быть меньше или равен нулю.");
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