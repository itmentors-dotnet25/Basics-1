namespace Basics.Tasks;

public class ExceptionHandlingTasks
{
    /// <summary>
    /// Задание 4.1: Напишите метод, который безопасно делит два числа с обработкой исключений.
    /// В случае исключения возвращайте 0.
    /// </summary>
    public double SafeDivide(double a, double b)
    {
        if (b == 0)
            return 0;
        
        try
        {
            return a / b;
        }
        catch
        {
            return 0;
        }
    }

    /// <summary>
    /// Задание 4.2: Напишите метод, который преобразует строку в число с обработкой FormatException.
    /// </summary>
    public int? ParseStringToInt(string input)
    {
        return int.TryParse(input, out int result) ? result : null;
    }

    /// <summary>
    /// Задание 4.3: Создайте собственное исключение NegativeNumberException
    /// </summary>
    /// <summary>
    /// Задание 4.4: Напишите метод, который проверяет число на отрицательность и бросает исключение NegativeNumberException.
    /// </summary>
    public void ValidatePositiveNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("Число не должно быть отрицательным!");
        }
    }

    /// <summary>
    /// Задание 4.5: Напишите метод с использованием try-catch-finally
    /// </summary>
    public string TryFinallyExample()
    {
        string result = "";

        try
        {
            int value = int.Parse("invalid format");
            result = $"Success: {value}";
        }
        catch (FormatException e)
        {
            result = $"Error: {e.Message}";
        }
        finally
        {
            result += " [finally executed]";
        }

        return result;
    }
}