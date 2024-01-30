namespace ShapeArea;

public class Triangle: Shape
{
    private readonly double _baseSide;
    private readonly double _height;
    
    /// <summary>
    /// Конструктор для класса "Треугольник"
    /// </summary>
    /// <param name="baseSide">Основание</param>
    /// <param name="height">Высота</param>
    /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если хотя бы одна из сторон меньше или равна нулю</exception>
    public Triangle(double baseSide, double height)
    {
        if (baseSide <= 0 || height <= 0)
        {
            throw new ArgumentOutOfRangeException("Треугольник не существует.");
        }
        _baseSide = baseSide;
        _height = height;
    }
    
    /// <summary>
    /// Возвращает площадь треугольника
    /// </summary>
    /// <remarks>
    /// Area = (base × height) / 2
    /// </remarks>
    public override double CalculateArea()
    {
        return (_baseSide * _height) / 2;
    }

    /// <summary>
    /// Возвращает true если треугольник прямоугольный, иначе false
    /// </summary>
    /// <remarks>
    /// Использует теорему Пифагора
    /// </remarks>
    public bool IsRightAngled()
    {
        // sqrt(64 * 
        double hypotenuse = Math.Sqrt(Math.Pow(_baseSide, 2) + Math.Pow(_height, 2));
        
        // 64 + 36 = 100
        if (Math.Pow(hypotenuse, 2) == Math.Pow(_baseSide, 2) + Math.Pow(_height, 2))
        {
            return true;
        }
        return false;
    }
}