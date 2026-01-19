using Basics.Tasks.OopTasks.Animals;

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
        {
            return 0;
        }

        return a / b;
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
            throw new NegativeNumberException();
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
            var cat = new Cat("Матильда");
            result = cat.MakeSound();

            Console.WriteLine("Блок try");
            //throw new InvalidOperationException(); 
        }
        catch (Exception)
        {
            var dog = new Cat("Рекс");
            result = dog.MakeSound();

            Console.WriteLine("Блок catch");
            throw;
        }
        finally
        {
            var dog = new Cat("Шарик");
            result = dog.MakeSound();

            Console.WriteLine("Блок finally");
        }

        return result;
    }
}