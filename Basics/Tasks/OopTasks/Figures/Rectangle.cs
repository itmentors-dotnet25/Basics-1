namespace Basics.Tasks.OopTasks.Figures;

public class Rectangle: IShape
{
    public double Height { get; init; }
    public double Width { get; init; }

    public Rectangle(double height, double width)
    {
        if (double.IsNaN(height) || double.IsInfinity(height))
            throw new ArgumentException("Длина не может быть NaN или бесконечностью.", nameof(height));
        if (height < 0)
            throw new ArgumentOutOfRangeException(nameof(height), "Длина не может быть отрицательной.");
        if (double.IsNaN(width) || double.IsInfinity(width))
            throw new ArgumentException("Ширина не может быть NaN или бесконечностью.", nameof(width));
        if (width < 0)
            throw new ArgumentOutOfRangeException(nameof(width), "Ширина не может быть отрицательной.");
        // Защита от переполнения при расчётах
        if (height > Math.Sqrt(double.MaxValue))
            throw new ArgumentOutOfRangeException(nameof(height), 
                "Height слишком велик: приведёт к переполнению при вычислении площади.");
        if (width > Math.Sqrt(double.MaxValue))
            throw new ArgumentOutOfRangeException(nameof(width), 
                "Width слишком велик: приведёт к переполнению при вычислении площади.");
        
        Height = height;
        Width = width;
    }

    public double CalculateArea() => Height * Width;

    public double CalculatePerimeter() => 2 * (Height + Width);
}