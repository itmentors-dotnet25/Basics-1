using System.Text;
using Basics.Exceptions;
using Microsoft.VisualBasic;

namespace Basics.Tasks;

public class ExceptionHandlingTasks
{
    /// <summary>
    /// Задание 4.1: Напишите метод, который безопасно делит два числа с обработкой исключений.
    /// В случае исключения возвращайте 0.
    /// </summary>
    public double SafeDivide(double a, double b)
    {
        var result = a / b;
        
        return (double.IsNaN(result) || double.IsInfinity(result)) 
            ? 0 
            : result;
    }

    /// <summary>
    /// Задание 4.2: Напишите метод, который преобразует строку в число с обработкой FormatException.
    /// </summary>
    public int? ParseStringToInt(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch (FormatException ex)
        {
            //TODO Логировать ошибку ex.Message
            
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
            throw new NegativeNumberException(paramName: nameof(number));
    }

    /// <summary>
    /// Задание 4.5: Напишите метод с использованием try-catch-finally
    /// </summary>
    public string TryFinallyExample()
    {
        var sb = new StringBuilder();
        
        try
        {
            var a = 5;
            var b = 0;
            var result = a / b;
        }
        catch (Exception ex)
        {
            sb.Append($"Error: {ex.Message}");
        }
        finally
        {
            sb.Append("Info: Попытка использования конструкции try-catch-finally успешна.");
        }

        return sb.ToString();
    }
}