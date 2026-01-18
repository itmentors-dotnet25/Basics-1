namespace Basics.Tasks;

public class ExceptionHandlingTasks
{
    /// <summary>
    /// Задание 4.1: Напишите метод, который безопасно делит два числа с обработкой исключений.
    /// В случае исключения возвращайте 0.
    /// </summary>
    public static double SafeDivide(double a, double b)
    {
        if (b == 0.0)
            return 0;
        return (a / b);
       
    }

    /// <summary>
    /// Задание 4.2: Напишите метод, который преобразует строку в число с обработкой FormatException.
    /// </summary>
    public static int? ParseStringToInt(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Задание 4.3: Создайте собственное исключение NegativeNumberException
    /// </summary>
     
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string massage) : base(massage) { }
    }

    /// <summary>
    /// Задание 4.4: Напишите метод, который проверяет число на отрицательность и бросает исключение NegativeNumberException.
    /// </summary>
    public void ValidatePositiveNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException($"Число {number} меньше ноля");
        }
    }

    /// <summary>
    /// Задание 4.5: Напишите метод с использованием try-catch-finally
    /// </summary>
    public string TryFinallyExample()
    {
        throw new NotImplementedException();
    }
}