namespace Basics.Tasks;

public class SyntaxTasks
{
    /// <summary>
    /// Задание 1.1: Напишите метод, который принимает три числа и возвращает наибольшее из них.
    /// </summary>
    public int FindMaxOfThree(int a, int b, int c)
    {
        //var max = b > a ? b : a;
        //return max > c ? max : c;

        //return Math.Max(a, Math.Max(b, c));

        return Max(a, Max(b, c));
    }

    private static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    /// <summary>
    /// Задание 1.2: Напишите метод, который вычисляет сумму всех чисел от 1 до N.
    /// </summary>
    public int CalculateSumFrom1ToN(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        return n * (n + 1) / 2;

        /* или циклом
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
        */
    }

    /// <summary>
    /// Задание 1.3: Напишите метод, который проверяет, является ли число простым.
    /// </summary>
    public bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Задание 1.4: Напишите метод, который генерирует массив первых N чисел Фибоначчи.
    /// </summary>
    public int[] GenerateFibonacciArray(int n)
    {
        if (n <= 0)
        {
            return new int[0];
        }

        int[] fibonacci = new int[n];
        fibonacci[0] = 0;

        if (n >= 2)
        {
            fibonacci[1] = 1;
        }

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
        if (numbers == null || numbers.Length == 0)
        {
            return 0.0;
        }

        long totalSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            totalSum += numbers[i];
        }

        return (double)totalSum / numbers.Length;
    }

    /// <summary>
    /// Задание 1.6: Напишите метод, который проверяет, является ли строка палиндромом (игнорируя регистр).
    /// </summary>
    public bool IsStringPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return true;

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(text[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(text[right]))
            {
                right--;
            }

            if (char.ToLower(text[left]) != char.ToLower(text[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
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
                return new double[0];
            }
            else
            {
                return new double[] { -c / b };
            }
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            return new double[0];
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            double sqrtD = Math.Sqrt(discriminant);
            double root1 = (-b - sqrtD) / (2 * a);
            double root2 = (-b + sqrtD) / (2 * a);

            if (root1 <= root2)
            {
                return new double[] { root1, root2 };
            }
            else
            {
                return new double[] { root2, root1 };
            }
        }
    }
}