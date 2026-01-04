namespace Basics.Tasks;

public class SyntaxTasks
{
    /// <summary>
    /// Задание 1.1: Напишите метод, который принимает три числа и возвращает наибольшее из них.
    /// </summary>
    public int FindMaxOfThree(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    /// <summary>
    /// Задание 1.2: Напишите метод, который вычисляет сумму всех чисел от 1 до N.
    /// </summary>
    public int CalculateSumFrom1ToN(int n)
    {
        return n * (n + 1) / 2; // арефметическая прогрессия
    }

    /// <summary>
    /// Задание 1.3: Напишите метод, который проверяет, является ли число простым.
    /// </summary>
    public bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    /// <summary>
    /// Задание 1.4: Напишите метод, который генерирует массив первых N чисел Фибоначчи.
    /// </summary>
    public int[] GenerateFibonacciArray(int n)
    {
        if (n <= 0)
            return [];

        int[] fibonacci = new int[n];

        fibonacci[0] = 0;

        if (n >= 2)
            fibonacci[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return fibonacci;
    }

    /// <summary>
    /// Задание 1.5: Напишите метод, который находит среднее арифметическое элементов массива.
    /// </summary>
    public double CalculateArrayAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0.0;

        long sum = numbers.Sum();

        return (double)sum / numbers.Length;
    }

    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр).
    /// </summary>
    public bool IsStringPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return true;

        string cleaned = new string(text.Where(char.IsLetterOrDigit)
            .Select(char.ToLowerInvariant)
            .ToArray());

        string reversed = new string(cleaned.Reverse().ToArray());
        return cleaned == reversed;
    }

    /// <summary>
    /// Задание 1.7: Напишите метод, который транспонирует матрицу (меняет строки и столбцы местами).
    /// </summary>
    public int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        return transposed;
    }

    /// <summary>
    /// Задание 1.8: Напишите метод, который решает квадратное уравнение ax² + bx + c = 0.
    /// Возвращает массив с корнями (0, 1 или 2 корня). Корни должны быть перечислены по возрастанию.
    /// </summary>
    public double[] SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                return [];
            }
            return [-c / b];
        }

        double d = b * b - 4 * a * c;

        if (d < 0)
            return [];
        if (d == 0)
            return [-b / (2 * a)];

        double sqrtD = Math.Sqrt(d);
        double r1 = (-b - sqrtD) / (2 * a);
        double r2 = (-b + sqrtD) / (2 * a);

        return r1 < r2 ? [r1, r2] : [r2, r1];
    }
}