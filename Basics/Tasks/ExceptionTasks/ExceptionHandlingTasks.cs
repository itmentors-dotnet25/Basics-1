namespace Basics.Tasks;

public class ExceptionHandlingTasks
{
    /// <summary>
    /// Задание 4.1: Напишите метод, который безопасно делит два числа с обработкой исключений.
    /// В случае исключения возвращайте 0.
    /// </summary>
    public double SafeDivide(double a, double b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            return 0;
        }
    }

    /// <summary>
    /// Задание 4.2: Напишите метод, который преобразует строку в число с обработкой FormatException.
    /// </summary>
    public int? ParseStringToInt(string input)
    {
        try
        {
            return Convert.ToInt32(input);
        }
        catch (FormatException)
        {
            return null;
        }
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
            throw new NegativeNumberException("Число должно быть неотрицательным.");
        }
    }

    /// <summary>
    /// Задание 4.5: Напишите метод с использованием try-catch-finally
    /// </summary>
    /// Нету теста для метода
    public string TryFinallyExample(int input)
    {
        try
        {
            return Convert.ToString(input);
        }
        catch (FormatException)
        {
            return "Строку нельзя привести к int16";
        }
        finally
        {
            Console.WriteLine("Метод завершился.");
        }
    }
}