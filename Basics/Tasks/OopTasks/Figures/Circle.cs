namespace Basics.Tasks.OopTasks.Figures;

public class Circle: IShape
{
    private const double MaxSafeRadius = 7.543613993858101E+153; // Math.Sqrt(double.MaxValue / Math.PI)
    
    public double Radius { get; init; }

    public Circle(double radius)
    {
        if (double.IsNaN(radius) || double.IsInfinity(radius))
            throw new ArgumentException("Радиус не может быть NaN или бесконечностью.", nameof(radius));
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус не может быть отрицательным.");
        if (radius > MaxSafeRadius)
            throw new ArgumentOutOfRangeException(
                nameof(radius), 
                $"Радиус слишком велик (макс. допустимый: {MaxSafeRadius}). Приведёт к переполнению при вычислении площади.");

        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;

    public double CalculatePerimeter() => 2 * Math.PI * Radius;
}